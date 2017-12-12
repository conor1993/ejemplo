Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports EC = IntegraLab.ORM.EntityClasses

Public Class MovimientoGanadoClass
    Inherits ClassBase(Of EC.CabMovGanEntity)

#Region "Miembros"
    Private m_TipoMovimientoGanado As TipoMovimientoGanadoClass
    Private m_Detalle As MovimientoGanadoDetalleCollectionClass

#Region "Eventos"

#End Region
#End Region

#Region "Constructores"
    Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal entidad As EC.CabMovGanEntity)
        MyBase.New(entidad)
    End Sub

    Sub New(ByVal folioMovimiento As String)
        MyBase.New(New EC.CabMovGanEntity(folioMovimiento))
    End Sub
#End Region

#Region "Propiedades"
    Public Property FolioMovimeinto() As String
        Get
            Return Entity.FolMovGan
        End Get
        Private Set(ByVal value As String)
            Entity.FolMovGan = value
        End Set
    End Property

    Public Property FechaMovimeinto() As Date
        Get
            Return Entity.FecMovGan
        End Get
        Set(ByVal value As Date)
            Entity.FecMovGan = value
        End Set
    End Property

    Public Property IdTipoMovimiento() As Integer
        Get
            Return Entity.CveMovGan
        End Get
        Set(ByVal value As Integer)
            Entity.CveMovGan = value
        End Set
    End Property

    Public Property TipoMovimiento() As TipoMovimientoGanadoClass
        Get
            If Me.m_TipoMovimientoGanado Is Nothing Then
                m_TipoMovimientoGanado = New TipoMovimientoGanadoClass(Entity.McgcatMovGanado)
            ElseIf Not m_TipoMovimientoGanado.IdMovGanado = IdTipoMovimiento Then
                m_TipoMovimientoGanado.Entidad = Entity.McgcatMovGanado
            End If

            Return m_TipoMovimientoGanado
        End Get
        Set(ByVal value As TipoMovimientoGanadoClass)
            m_TipoMovimientoGanado = value

            If value Is Nothing Then
                Entity.McgcatMovGanado = Nothing
            Else
                Entity.McgcatMovGanado = value.Entidad
            End If
        End Set
    End Property

    Public Property IdGanadera() As Byte
        Get
            Return Entity.CveGanadera
        End Get
        Set(ByVal value As Byte)
            Entity.CveGanadera = value
        End Set
    End Property

    Public Property FechaContabilizado() As Date
        Get
            Return Entity.FecConta
        End Get
        Set(ByVal value As Date)
            Entity.FecConta = value
        End Set
    End Property

    Public Property FolioPoliza() As String
        Get
            Return Entity.FolPoliza
        End Get
        Set(ByVal value As String)
            Entity.FolPoliza = value
        End Set
    End Property

    Public Property Estatus() As EstatusMovimiento
        Get
            Return Asc(Entity.StaMov)
        End Get
        Set(ByVal value As EstatusMovimiento)
            Entity.StaMov = Chr(value)
        End Set
    End Property

    Public Property CostoTotal() As Decimal
        Get
            Return Entity.CostoTotal
        End Get
        Set(ByVal value As Decimal)
            Entity.CostoTotal = value
        End Set
    End Property

    Public Property FolioMovimientoReferencia() As String
        Get
            Return Entity.FolRefere
        End Get
        Set(ByVal value As String)
            Entity.FolRefere = value
        End Set
    End Property

    Public Property Referencia() As String
        Get
            Return Entity.FolRefere
        End Get
        Set(ByVal value As String)
            Entity.FolRefere = value
        End Set
    End Property

    Public Property Detalle() As MovimientoGanadoDetalleCollectionClass
        Get
            If Me.m_Detalle Is Nothing Then
                m_Detalle = New MovimientoGanadoDetalleCollectionClass
                m_Detalle.RellenarMe(Entity.DetMovGan)
            End If

            Return m_Detalle
        End Get
        Protected Friend Set(ByVal value As MovimientoGanadoDetalleCollectionClass)
            Me.m_Detalle = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Shadows Function Guardar(ByVal trans As HC.Transaction) As Boolean
        Me.GenerarFolioMovimeintoAlmacen(trans)

        trans.Add(Entidad)

        Entidad.Save()
        Detalle.Guardar(trans)

        Return True
    End Function

    Private Sub GenerarFolioMovimeintoAlmacen(ByVal trans As HC.Transaction)
        Dim folio As New FoliosClass

        folio.Año = 1
        folio.Mes = 1
        folio.Codigo = CodigodeFolios.MovimientoGanado

        If Not folio.Guardar(trans) Then
            Throw New Exception("Ocurrio un error al generar el consecutivo de movimiento de ganado")
        End If

        Me.FolioMovimeinto = "G" & folio.Consecutivo.ToString("0000000000")
    End Sub

    Private Sub RegistrarYConfigurarTipoMovimiento(ByVal Concepto As String, ByRef ConfiguracionMovimientoGanado As EC.McgconfiguracionMovimientoGanadoEntity, ByVal Propiedad As Reflection.PropertyInfo, ByRef Trans As HC.Transaction)
        Dim TipoMovimientoGanado As New EC.McgcatMovGanadoEntity

        Trans.Add(TipoMovimientoGanado)
        TipoMovimientoGanado.NombreMovGanado = Concepto

        If Concepto.Length > 50 Then
            TipoMovimientoGanado.NomCorMovGanado = Concepto.Substring(0, 50)
        Else
            TipoMovimientoGanado.NomCorMovGanado = Concepto
        End If
        TipoMovimientoGanado.Salida = IIf(Concepto.Substring(0, 6).ToUpper().Contains("SALIDA"), True, False)
        TipoMovimientoGanado.Estatus = EstatusDatos.VIGENTE
        TipoMovimientoGanado.Save()

        Trans.Add(ConfiguracionMovimientoGanado)
        Propiedad.SetValue(ConfiguracionMovimientoGanado, TipoMovimientoGanado.IdMovGanado, Nothing)
        ConfiguracionMovimientoGanado.Save()
    End Sub

    Public Sub EstablecerTipoMovimientoGanado(ByVal tipoMovimiento As InventarioConfigGanadoClass.TipoMovimientoGanadoEnum, ByRef Trans As HC.Transaction)
        Dim Propiedad As Reflection.PropertyInfo
        Dim config As New CC.McgconfiguracionMovimientoGanadoCollection

        config.GetMulti(HC.McgconfiguracionMovimientoGanadoFields.Codigo = 1)

        If config.Count = 0 Then
            config.AddNew().Codigo = 1
            Trans.Add(config)
            config.SaveMulti()
        End If

        Propiedad = config(0).GetType().GetProperty(tipoMovimiento.ToString()) '.Replace("SalidaXCancelacionCompraGanado", "SalidaXcancelacionCompraGanado").Replace("EntradaXCompraGanado", "EntradaXcompraGanado")
        Select Case tipoMovimiento

            '================================================================'
            '=                           ENTRADAS                           ='
            '================================================================'
            Case InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.EntradaCorralCancelacionMuerte
                If config(0).EntradaCorralCancelacionMuerte.GetValueOrDefault(-1) = -1 Then
                    If Trans IsNot Nothing AndAlso Propiedad.CanWrite Then
                        RegistrarYConfigurarTipoMovimiento("ENTRADA A CORRAL POR CANCELACION DE MUERTE", config(0), Propiedad, Trans)
                    Else
                        Throw New Exception("No se encuentra configurado el movimiento de ganado Entradas a Corral Por Cancelacion de Muerte")
                    End If
                End If
                Me.IdTipoMovimiento = config(0).EntradaCorralCancelacionMuerte
            Case InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.EntradaCorralCancelacionRastro
                If config(0).EntradaCorralCancelacionRastro.GetValueOrDefault(-1) = -1 Then
                    If Trans IsNot Nothing AndAlso Propiedad.CanWrite Then
                        RegistrarYConfigurarTipoMovimiento("ENTRADA A CORRAL POR CANCELACION DE SALIDA A RASTRO", config(0), Propiedad, Trans)
                    Else
                        Throw New Exception("No se encuentra configurado el movimiento de ganado Entradas a Corral Por Cancelacion de Salida a Rastro")
                    End If
                End If
                Me.IdTipoMovimiento = config(0).EntradaCorralCancelacionRastro
            Case InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.EntradaCorralCancelacionTraspaso
                If config(0).EntradaCorralCancelacionTraspaso.GetValueOrDefault(-1) = -1 Then
                    If Trans IsNot Nothing AndAlso Propiedad.CanWrite Then
                        RegistrarYConfigurarTipoMovimiento("ENTRADA A CORRAL POR CANCELACION DE TRASPASO", config(0), Propiedad, Trans)
                    Else
                        Throw New Exception("No se encuentra configurado el movimiento de ganado Entradas a Corral Por Cancelacion de Traspaso")
                    End If
                End If
                Me.IdTipoMovimiento = config(0).EntradaCorralCancelacionTraspaso
            Case InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.EntradaCorralCancelacionVenta
                If config(0).EntradaCorralCancelacionVenta.GetValueOrDefault(-1) = -1 Then
                    If Trans IsNot Nothing AndAlso Propiedad.CanWrite Then
                        RegistrarYConfigurarTipoMovimiento("ENTRADA A CORRAL POR CANCELACION DE VENTAS", config(0), Propiedad, Trans)
                    Else
                        Throw New Exception("No se encuentra configurado el movimiento de ganado Entradas a Corral Por Cancelacion de Venta")
                    End If
                End If
                Me.IdTipoMovimiento = config(0).EntradaCorralCancelacionVenta
            Case InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.EntradaRecibaCancelacionEnfermeria
                If config(0).EntradaRecibaCancelacionEnfermeria.GetValueOrDefault(-1) = -1 Then
                    If Trans IsNot Nothing AndAlso Propiedad.CanWrite Then
                        RegistrarYConfigurarTipoMovimiento("ENTRADA A RECIBA POR CANCELACION DE SALIDA A ENFERMERIA", config(0), Propiedad, Trans)
                    Else
                        Throw New Exception("No se encuentra configurado el movimiento de ganado Entradas a Reciba Por Cancelacón de Salida a Enfermeria")
                    End If
                End If
                Me.IdTipoMovimiento = config(0).EntradaRecibaCancelacionEnfermeria
            Case InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.EntradaRecibaCancelacionMuerte
                If config(0).EntradaRecibaCancelacionMuerte.GetValueOrDefault(-1) = -1 Then
                    If Trans IsNot Nothing AndAlso Propiedad.CanWrite Then
                        RegistrarYConfigurarTipoMovimiento("ENTRADA A RECIBA POR CANCELACION DE SALIDA POR MUERTE", config(0), Propiedad, Trans)
                    Else
                        Throw New Exception("No se encuentra configurado el movimiento de ganado Entradas a Reciba Por Cancelacón de Salida Por Muerte")
                    End If
                End If
                Me.IdTipoMovimiento = config(0).EntradaRecibaCancelacionMuerte
            Case InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.EntradaRecibaCancelacionRastro
                If config(0).EntradaRecibaCancelacionRastro.GetValueOrDefault(-1) = -1 Then
                    If Trans IsNot Nothing AndAlso Propiedad.CanWrite Then
                        RegistrarYConfigurarTipoMovimiento("ENTRADA A RECIBA POR CANCELACION DE SALIDA A RASTRO", config(0), Propiedad, Trans)
                    Else
                        Throw New Exception("No se encuentra configurado el movimiento de ganado Entradas a Reciba Por Cancelacón de Salida a Rastro")
                    End If
                End If
                Me.IdTipoMovimiento = config(0).EntradaRecibaCancelacionRastro
            Case InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.EntradaRecibaCancelacionVenta
                If config(0).EntradaRecibaCancelacionVenta.GetValueOrDefault(-1) = -1 Then
                    If Trans IsNot Nothing AndAlso Propiedad.CanWrite Then
                        RegistrarYConfigurarTipoMovimiento("ENTRADA A RECIBA POR CANCELACION DE SALIDA POR VENTAS", config(0), Propiedad, Trans)
                    Else
                        Throw New Exception("No se encuentra configurado el movimiento de ganado Entradas a Reciba Por Cancelacón de Salida Por Venta")
                    End If
                End If
                Me.IdTipoMovimiento = config(0).EntradaRecibaCancelacionVenta
            Case InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.EntradaXcompraGanado
                If config(0).EntradaXcompraGanado.GetValueOrDefault(-1) = -1 Then
                    If Trans IsNot Nothing AndAlso Propiedad.CanWrite Then
                        RegistrarYConfigurarTipoMovimiento("ENTRADA POR COMPRA DE GANADO", config(0), Propiedad, Trans)
                    Else
                        Throw New Exception("No se encuentra configurado el movimiento de ganado Entradas Por Compra de Ganado")
                    End If
                End If
                Me.IdTipoMovimiento = config(0).EntradaXcompraGanado
            Case InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.EntradaReinicioReciba
                If config(0).EntradaReinicioReciba.GetValueOrDefault(-1) = -1 Then
                    If Trans IsNot Nothing AndAlso Propiedad.CanWrite Then
                        RegistrarYConfigurarTipoMovimiento("ENTRADA POR REINICIO DE RECIBA", config(0), Propiedad, Trans)
                    Else
                        Throw New Exception("No se encuentra configurado el movimiento de ganado Entradas Por Reinicio de Corral de Reciba")
                    End If
                End If
                Me.IdTipoMovimiento = config(0).EntradaReinicioReciba
            Case InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.EntradaRecibaXcancelacionTransferenciaRecibaAcorral
                If config(0).EntradaRecibaXcancelacionTransferenciaRecibaAcorral.GetValueOrDefault(-1) = -1 Then
                    If Trans IsNot Nothing AndAlso Propiedad.CanWrite Then
                        RegistrarYConfigurarTipoMovimiento("ENTRADA DE RECIBA POR CANCELACION DE TRANSFERENCIA DE RECIBA A CORRAL", config(0), Propiedad, Trans)
                    Else
                        Throw New Exception("No se encuentra configurado el movimiento de ganado Entradas de Reciba por Cancelacion de Transferencia de Reciba a Corral")
                    End If
                End If
                Me.IdTipoMovimiento = config(0).EntradaRecibaXcancelacionTransferenciaRecibaAcorral

                '================================================================'
                '=                           SALIDAS                            ='
                '================================================================'
            Case InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.SalidaCorralMuerte
                If config(0).SalidaCorralMuerte.GetValueOrDefault(-1) = -1 Then
                    If Trans IsNot Nothing AndAlso Propiedad.CanWrite Then
                        RegistrarYConfigurarTipoMovimiento("SALIDA DE CORRAL POR MUERTE", config(0), Propiedad, Trans)
                    Else
                        Throw New Exception("No se encuentra configurado el movimiento de ganado Salida Del Corral Por Muerte")
                    End If
                End If
                Me.IdTipoMovimiento = config(0).SalidaCorralMuerte
            Case InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.SalidaCorralRastro
                If config(0).SalidaCorralRastro.GetValueOrDefault(-1) = -1 Then
                    If Trans IsNot Nothing AndAlso Propiedad.CanWrite Then
                        RegistrarYConfigurarTipoMovimiento("SALIDA DE CORRAL A RASTRO", config(0), Propiedad, Trans)
                    Else
                        Throw New Exception("No se encuentra configurado el movimiento de ganado Salida Del Corral a Rastro")
                    End If
                End If
                Me.IdTipoMovimiento = config(0).SalidaCorralRastro
            Case InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.SalidaCorralTraspaso
                If config(0).SalidaCorralTraspaso.GetValueOrDefault(-1) = -1 Then
                    If Trans IsNot Nothing AndAlso Propiedad.CanWrite Then
                        RegistrarYConfigurarTipoMovimiento("SALIDA DE CORRAL POR TRANSPASO", config(0), Propiedad, Trans)
                    Else
                        Throw New Exception("No se encuentra configurado el movimiento de ganado Salida Del Corral Por Traspaso")
                    End If
                End If
                Me.IdTipoMovimiento = config(0).SalidaCorralTraspaso
            Case InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.SalidaCorralVenta
                If config(0).SalidaCorralVenta.GetValueOrDefault(-1) = -1 Then
                    If Trans IsNot Nothing AndAlso Propiedad.CanWrite Then
                        RegistrarYConfigurarTipoMovimiento("SALIDA DE CORRAL A VENTA", config(0), Propiedad, Trans)
                    Else
                        Throw New Exception("No se encuentra configurado el movimiento de ganado Salida Del Corral Por Venta")
                    End If
                End If
                Me.IdTipoMovimiento = config(0).SalidaCorralVenta
            Case InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.SalidaRecibaEnfermeria
                If config(0).SalidaRecibaEnfermeria.GetValueOrDefault(-1) = -1 Then
                    If Trans IsNot Nothing AndAlso Propiedad.CanWrite Then
                        RegistrarYConfigurarTipoMovimiento("SALIDA DE RECIBA A ENFERMERIA", config(0), Propiedad, Trans)
                    Else
                        Throw New Exception("No se encuentra configurado el movimiento de ganado Salida de Reciba a Enfermeria")
                    End If
                End If
                Me.IdTipoMovimiento = config(0).SalidaRecibaEnfermeria
            Case InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.SalidaRecibaMuerte
                If config(0).SalidaRecibaMuerte.GetValueOrDefault(-1) = -1 Then
                    If Trans IsNot Nothing AndAlso Propiedad.CanWrite Then
                        RegistrarYConfigurarTipoMovimiento("SALIDA DE RECIBA POR MUERTE", config(0), Propiedad, Trans)
                    Else
                        Throw New Exception("No se encuentra configurado el movimiento de ganado Salida de Reciba Por Muerte")
                    End If
                End If
                Me.IdTipoMovimiento = config(0).SalidaRecibaMuerte
            Case InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.SalidaRecibaRastro
                If config(0).SalidaRecibaRastro.GetValueOrDefault(-1) = -1 Then
                    If Trans IsNot Nothing AndAlso Propiedad.CanWrite Then
                        RegistrarYConfigurarTipoMovimiento("SALIDA DE RECIBA A RASTRO", config(0), Propiedad, Trans)
                    Else
                        Throw New Exception("No se encuentra configurado el movimiento de ganado Salida de Reciba a Rastro")
                    End If
                End If
                Me.IdTipoMovimiento = config(0).SalidaRecibaRastro
            Case InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.SalidaRecibaVenta
                If config(0).SalidaRecibaVenta.GetValueOrDefault(-1) = -1 Then
                    If Trans IsNot Nothing AndAlso Propiedad.CanWrite Then
                        RegistrarYConfigurarTipoMovimiento("SALIDA DE RECIBA A VENTA", config(0), Propiedad, Trans)
                    Else
                        Throw New Exception("No se encuentra configurado el movimiento de ganado Salida de Reciba Por Venta")
                    End If
                End If
                Me.IdTipoMovimiento = config(0).SalidaRecibaVenta
            Case InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.SalidaXcancelacionCompraGanado
                If config(0).SalidaXcancelacionCompraGanado.GetValueOrDefault(-1) = -1 Then
                    If Trans IsNot Nothing AndAlso Propiedad.CanWrite Then
                        RegistrarYConfigurarTipoMovimiento("SALIDA POR CANCELACION DE COMPRA DE GANADO", config(0), Propiedad, Trans)
                    Else
                        Throw New Exception("No se encuentra configurado el movimiento de ganado Salida Por Cancelación de Compra")
                    End If
                End If
                Me.IdTipoMovimiento = config(0).SalidaXcancelacionCompraGanado
            Case InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.SalidaRecibaXtransferenciaAcorral
                If config(0).SalidaRecibaXtransferenciaAcorral.GetValueOrDefault(-1) = -1 Then
                    If Trans IsNot Nothing AndAlso Propiedad.CanWrite Then
                        RegistrarYConfigurarTipoMovimiento("SALIDA DE RECIBA POR TRANSFERENCIA A CORRAL", config(0), Propiedad, Trans)
                    Else
                        Throw New Exception("No se encuentra configurado el movimiento de ganado Salida de Reciba por Transferencia a Corral")
                    End If
                End If
                Me.IdTipoMovimiento = config(0).SalidaRecibaXtransferenciaAcorral
        End Select
    End Sub

#End Region

#Region "Eventos"

#End Region

#Region "Tipos Anidados"
    Public Enum EstatusMovimiento
        CANCELADO = Asc("C"c)
        VIGENTE = Asc("V"c)
    End Enum
#End Region
End Class