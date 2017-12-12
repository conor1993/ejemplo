Imports System.Windows.Forms
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports SPR = IntegraLab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports InventarioConfigGanadoClass.TipoMovimientoGanadoEnum
Imports ClasesNegocio.AlmacenGeneral

Public Class CompraGanadoClass
    Inherits ClassBase(Of EC.CabRegComEntity)

#Region "Miembros"
    Private m_Detalle As ComprasGanadoDetalleCollectionClass
    Private m_Proveedor As ProveedorClass
    Private m_Comprador As CompradorGanadoClass
    Private m_LugarCompra As LugaresDeCompraClass
    Private m_Corral As CorralClass
    Private m_GastosTransporte As GastoTransporteClass
    Private m_MovimeintoGanado As MovimientoGanadoClass
    Private m_MovimientoGanadoCancelacion As MovimientoGanadoClass
#End Region

#Region "Constructores"
    Sub New()
        Entity = New EC.CabRegComEntity
    End Sub

    Sub New(ByVal Entidad As EC.CabRegComEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal Folio As String)
        Entity = New EC.CabRegComEntity(Folio)
    End Sub
#End Region

#Region "Propiedades"
    Public Property Folio() As String
        Get
            Return Entity.FolRecep
        End Get
        Set(ByVal value As String)
            Entity.FolRecep = value
        End Set
    End Property

    Public Property GastosTransporte() As GastoTransporteClass
        Get
            If Me.m_GastosTransporte Is Nothing Then
                m_GastosTransporte = New GastoTransporteClass(Entity.CabGasTrans)
            ElseIf Not m_GastosTransporte.Folio.Trim = Folio.Trim Then
                m_GastosTransporte.Entidad = Entity.CabGasTrans
            End If

            Return m_GastosTransporte
        End Get
        Set(ByVal value As GastoTransporteClass)
            m_GastosTransporte = value

            If value Is Nothing Then
                Entity.CabGasTrans = Nothing
            Else
                Entity.CabGasTrans = value.Entidad
            End If
        End Set
    End Property

    Public Property FechaRecepcion() As Date
        Get
            Return Entity.FecRecep
        End Get
        Set(ByVal value As Date)
            Entity.FecRecep = value
        End Set
    End Property

    Public Property IdProveedor() As Integer
        Get
            Return Entity.CveProveGan
        End Get
        Set(ByVal value As Integer)
            Entity.CveProveGan = value
        End Set
    End Property

    Public Property Proveedor() As ProveedorClass
        Get
            If m_Proveedor Is Nothing Then
                m_Proveedor = New ProveedorClass(Entity.Proveedor)
            ElseIf Not m_Proveedor.Codigo = Me.IdProveedor Then
                m_Proveedor.Entidad = Entity.Proveedor
            End If

            Return m_Proveedor
        End Get
        Set(ByVal value As ProveedorClass)
            m_Proveedor = value

            If value Is Nothing Then
                Entity.Proveedor = Nothing
            Else
                Entity.Proveedor = value.Entidad
            End If
        End Set
    End Property

    Public ReadOnly Property NombreProveedor() As String
        Get
            Return Proveedor.RazonSocial
        End Get
    End Property

    Public Property IdLugarCompra() As Integer
        Get
            Return Entity.CveLugCom
        End Get
        Set(ByVal value As Integer)
            Entity.CveLugCom = value
        End Set
    End Property

    Public Property LugarCompra() As LugaresDeCompraClass
        Get
            If Me.m_LugarCompra Is Nothing Then
                m_LugarCompra = New LugaresDeCompraClass(Entity.CatLugaresDeCompra)
            ElseIf Not m_LugarCompra.IdLugarCompra = Me.IdLugarCompra Then
                m_LugarCompra.Entidad = Entity.CatLugaresDeCompra
            End If

            Return m_LugarCompra
        End Get
        Set(ByVal value As LugaresDeCompraClass)
            m_LugarCompra = value

            If value Is Nothing Then
                Entity.CatLugaresDeCompra = Nothing
            Else
                Entity.CatLugaresDeCompra = value.Entidad
            End If
        End Set
    End Property

    Public Property IdComprador() As Integer
        Get
            Return Entity.CveComiGan
        End Get
        Set(ByVal value As Integer)
            Entity.CveComiGan = value
        End Set
    End Property

    Public Property Comprador() As CompradorGanadoClass
        Get
            If Me.m_Comprador Is Nothing Then
                m_Comprador = New CompradorGanadoClass(Entity.McgcatCompradoresdeGanado)
            ElseIf Not m_Comprador.IdComprador = IdComprador Then
                m_Comprador.Entidad = Entity.McgcatCompradoresdeGanado
            End If

            Return m_Comprador
        End Get
        Set(ByVal value As CompradorGanadoClass)
            m_Comprador = value

            If value Is Nothing Then
                Entity.McgcatCompradoresdeGanado = Nothing
            Else
                Entity.McgcatCompradoresdeGanado = value.Entidad
            End If
        End Set
    End Property

    Public Property NumGuias() As Short
        Get
            Return Entity.NumGuias
        End Get
        Set(ByVal value As Short)
            Entity.NumGuias = value
        End Set
    End Property

    Public Property ImporteXGuia() As Decimal
        Get
            Return Entity.ImpteXguia
        End Get
        Set(ByVal value As Decimal)
            Entity.ImpteXguia = value
        End Set
    End Property

    Public Property HorasViaje() As Decimal
        Get
            Return Entity.HorasViaje
        End Get
        Set(ByVal value As Decimal)
            Entity.HorasViaje = value
        End Set
    End Property

    Public Property ImportePredial() As Decimal
        Get
            Return Entity.ImptePredial
        End Get
        Set(ByVal value As Decimal)
            Entity.ImptePredial = value
        End Set
    End Property

    Public Property PagarImportePredial() As Boolean
        Get
            Return Entity.BooPredial
        End Get
        Set(ByVal value As Boolean)
            Entity.BooPredial = value
        End Set
    End Property

    Public Property ImporteEducacion() As Decimal
        Get
            Return Entity.ImpteEduc
        End Get
        Set(ByVal value As Decimal)
            Entity.ImpteEduc = value
        End Set
    End Property

    Public Property PagarImporteEducacion() As Boolean
        Get
            Return Entity.BooEduc
        End Get
        Set(ByVal value As Boolean)
            Entity.BooEduc = value
        End Set
    End Property

    Public Property KilosRecibidos() As Decimal
        Get
            Return Entity.PesoEntReal
        End Get
        Set(ByVal value As Decimal)
            Entity.PesoEntReal = value
        End Set
    End Property

    Public Property Cabezas() As Integer
        Get
            Return Entity.CabezasComp
        End Get
        Set(ByVal value As Integer)
            Entity.CabezasComp = value
        End Set
    End Property

    Public Property KilosComprados() As Decimal
        Get
            Return Entity.KilosComp
        End Get
        Set(ByVal value As Decimal)
            Entity.KilosComp = value
        End Set
    End Property

    Public ReadOnly Property KilosMerma() As Decimal
        Get
            Return Me.KilosComprados - Me.KilosRecibidos
        End Get
    End Property

    Public ReadOnly Property PorcentajeMerma() As Decimal
        Get
            Return Me.KilosMerma / Me.KilosComprados * 100D
        End Get
    End Property

    Public Property ImporteCompra() As Decimal
        Get
            Return Entity.ImpteComp
        End Get
        Set(ByVal value As Decimal)
            Entity.ImpteComp = value
        End Set
    End Property

    Public ReadOnly Property ImporteCompraTotal() As Decimal
        Get
            Return Me.ImporteCompra + Me.CostoIndirecto + Me.ImportePredial
        End Get
    End Property

    Public Property Observaciones() As String
        Get
            Return Entity.Observaciones
        End Get
        Set(ByVal value As String)
            Entity.Observaciones = value
        End Set
    End Property

    Public Property Cerrado() As Nullable(Of Boolean)
        Get
            Return Entity.StaCerrado
        End Get
        Set(ByVal value As Nullable(Of Boolean))
            Entity.StaCerrado = value
        End Set
    End Property

    Public Property IdCorral() As String
        Get
            Return Entity.CveCorral
        End Get
        Set(ByVal value As String)
            Entity.CveCorral = value
        End Set
    End Property

    Public ReadOnly Property Corral() As CorralClass
        Get
            If m_Corral Is Nothing Then
                m_Corral = New CorralClass(Entity.McecatCorralesCab)
            ElseIf Not m_Corral.IdCorral.Trim = IdCorral.Trim Then
                Entity.McecatCorralesCab.FetchUsingPK(IdCorral)
                m_Corral.Entidad = Entity.McecatCorralesCab
            End If

            Return m_Corral
        End Get
    End Property

    Public Property DiasCredito() As Byte
        Get
            Return Entity.DiasCredito
        End Get
        Set(ByVal value As Byte)
            Entity.DiasCredito = value
        End Set
    End Property

    Public Property FechaPago() As Date
        Get
            Return Entity.FecPago
        End Get
        Set(ByVal value As Date)
            Entity.FecPago = value
        End Set
    End Property

    Public Property NumFactura() As String
        Get
            Return Entity.NumFactura
        End Get
        Set(ByVal value As String)
            Entity.NumFactura = value
        End Set
    End Property

    Public Property NomBanco() As String
        Get
            Return Entity.NomBanco
        End Get
        Set(ByVal value As String)
            Entity.NomBanco = value
        End Set
    End Property

    Public Property NomSucursal() As String
        Get
            Return Entity.NomSucursal
        End Get
        Set(ByVal value As String)
            Entity.NomSucursal = value
        End Set
    End Property

    Public Property NumCuenta() As String
        Get
            Return Entity.NumCuenta
        End Get
        Set(ByVal value As String)
            Entity.NumCuenta = value
        End Set
    End Property

    Public Property FechaConta() As Date
        Get
            Return Entity.FecConta
        End Get
        Set(ByVal value As Date)
            Entity.FecConta = value
        End Set
    End Property

    Public Property NumPoliza() As String
        Get
            Return Entity.NumPoliza
        End Get
        Set(ByVal value As String)
            Entity.NumPoliza = value
        End Set
    End Property

    Public Property Comision() As Decimal
        Get
            Return Entity.ComiXcab
        End Get
        Set(ByVal value As Decimal)
            Entity.ComiXcab = value
        End Set
    End Property

    Public Property Estatus() As EstatusChar
        Get
            Return Asc(Entity.Status)
        End Get
        Set(ByVal value As EstatusChar)
            Entity.Status = Chr(value)
        End Set
    End Property

    Public Property CostoIndirecto() As Decimal
        Get
            Return Entity.CostosIndi
        End Get
        Set(ByVal value As Decimal)
            Entity.CostosIndi = value
        End Set
    End Property

    Public Property FolioFactura() As String
        Get
            Return Entity.FolFactura
        End Get
        Set(ByVal value As String)
            Entity.FolFactura = value
        End Set
    End Property

    Public Property FechaCaptura() As DateTime
        Get
            Return Entity.FechaCaptura
        End Get
        Set(ByVal value As DateTime)
            Entity.FechaCaptura = value
        End Set
    End Property

    Public Property FolioMovimientoGanado() As String
        Get
            Return Entity.FolioMovimientoGanado
        End Get
        Set(ByVal value As String)
            Entity.FolioMovimientoGanado = value
        End Set
    End Property

    Public Property MovimientoGanado() As MovimientoGanadoClass
        Get
            If Me.m_MovimeintoGanado Is Nothing Then
                Me.m_MovimeintoGanado = New MovimientoGanadoClass(Entity.CabMovGan)
            ElseIf Not Me.m_MovimeintoGanado.FolioMovimeinto.Trim = Me.FolioMovimientoGanado.Trim Then
                Me.m_MovimeintoGanado.Entidad = Entity.CabMovGan
            End If

            Return Me.m_MovimeintoGanado
        End Get
        Set(ByVal value As MovimientoGanadoClass)
            Me.m_MovimeintoGanado = value

            If value Is Nothing Then
                Entity.CabMovGan = Nothing
            Else
                Entity.CabMovGan = value.Entidad
            End If
        End Set
    End Property

    Public Property FolioMovimientoGanadoCancelacion() As String
        Get
            Return Entity.FolioMovimientoGanadoCancelacion
        End Get
        Set(ByVal value As String)
            Entity.FolioMovimientoGanadoCancelacion = value
        End Set
    End Property

    Public Property MovimientoGanadoCancelacion() As MovimientoGanadoClass
        Get
            If Me.m_MovimientoGanadoCancelacion Is Nothing Then
                Me.m_MovimientoGanadoCancelacion = New MovimientoGanadoClass(Entity.CabMovGan_)
            ElseIf Not Me.m_MovimientoGanadoCancelacion.FolioMovimeinto.Trim = Me.FolioMovimientoGanadoCancelacion Then
                Me.m_MovimientoGanadoCancelacion.Entidad = Entity.CabMovGan_
            End If

            Return Me.m_MovimientoGanadoCancelacion
        End Get
        Set(ByVal value As MovimientoGanadoClass)
            Me.m_MovimientoGanadoCancelacion = value

            If value Is Nothing Then
                Entity.CabMovGan_ = Nothing
            Else
                Entity.CabMovGan_ = value.Entidad
            End If
        End Set
    End Property

    Public Property TipoComision() As TiposComision
        Get
            Return Entity.TipoComision
        End Get
        Set(ByVal value As TiposComision)
            Entity.TipoComision = value
        End Set
    End Property

    Public Property FolioRecepcionPesada() As String
        Get
            Return Entity.FolioRecepcionPesada
        End Get
        Set(ByVal value As String)
            Entity.FolioRecepcionPesada = value
        End Set
    End Property

    Public ReadOnly Property Detalle() As ComprasGanadoDetalleCollectionClass
        Get
            If m_Detalle Is Nothing Then
                m_Detalle = New ComprasGanadoDetalleCollectionClass
                m_Detalle.RellenarMe(Entity.DetRegCom)
            End If

            Return m_Detalle
        End Get
    End Property

    Public Property IdUsuarioAlta() As Integer
        Get
            Return Entity.IdUsuarioAlta
        End Get
        Set(ByVal value As Integer)
            Entity.IdUsuarioAlta = value
        End Set
    End Property

    Public Property IdUsuarioCancelacion() As Nullable(Of Integer)
        Get
            Return Entity.IdUsuarioCancelacion
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Entity.IdUsuarioCancelacion = value
        End Set
    End Property

    Public Property FechaCancelacion() As Nullable(Of Date)
        Get
            Return Entity.FechaCancelacion
        End Get
        Set(ByVal value As Nullable(Of Date))
            Entity.FechaCancelacion = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Function Obtener(ByVal Folio As String) As Boolean
        Try
            Return Entity.FetchUsingPK(Folio)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Shadows Function Guardar() As Boolean
        Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Compra Ganado")

        Try
            If Entity.IsNew Then
                Me.GenerarFolioRecepcionGanado(trans)
                Me.GenerarMovimientoGanado(trans)
                Me.MovimientoGanado.Guardar(trans)

                If Me.GastosTransporte.Detalle.Count > 0 Then
                    Me.GastosTransporte.Guardar(trans)
                End If

                trans.Add(Entity)
                Entity.Save()

                Me.Detalle.Guardar(trans)

                Me.GenerarDetalleCorral(Operacion.SUMA)

                Dim detalleCorral As CC.McecatCorralesDetCollection = Me.Corral.Detalle.ObtenerColeccion

                trans.Add(detalleCorral)

                detalleCorral.SaveMulti()

                trans.Add(Me.Proveedor.Entidad)

                Me.Proveedor.FechaUltimaCompra = Me.FechaRecepcion
                Me.Proveedor.ComprasAnoActual += Me.ImporteCompraTotal
                Me.Proveedor.ImporteUltimaCompra = Me.ImporteCompraTotal
                Me.Proveedor.SaldoActual += Me.ImporteCompraTotal
                Me.Proveedor.AcumComCab += Decimal.Parse(Me.Cabezas.ToString)
                Me.Proveedor.AcumComKil += Me.KilosComprados

                Me.Proveedor.Entidad.Save()
            Else
                Me.IdCorral = Me.IdCorral
                Me.AfectarCorralEdicion()

                trans.Add(Entidad)

                Entidad.Save()

                If Me.GastosTransporte.Detalle.Count > 0 Then
                    Me.GastosTransporte.Folio = Me.Folio
                    Me.GastosTransporte.Guardar(trans)
                End If

                Dim detalleCorral As CC.McecatCorralesDetCollection = Me.Corral.Detalle.ObtenerColeccion

                trans.Add(detalleCorral)

                detalleCorral.SaveMulti()

                trans.Add(Me.Proveedor.Entidad)

                'Me.Proveedor.FechaUltimaCompra = Me.FechaRecepcion
                Me.Proveedor.ComprasAnoActual -= Me.ImporteCompraTotal
                Me.Proveedor.ImporteUltimaCompra = 0
                Me.Proveedor.SaldoActual -= Me.ImporteCompraTotal
                Me.Proveedor.AcumComCab -= Decimal.Parse(Me.Cabezas.ToString)
                Me.Proveedor.AcumComKil -= Me.KilosComprados

                Me.Proveedor.Entidad.Save()

            End If

            trans.Commit()

            Return True
        Catch ex As Exception
            trans.Rollback()
            Throw ex
        End Try
    End Function

    Public Shadows Function Borrar() As Boolean
        Dim Trans As New Integralab.ORM.HelperClasses.Transaction(IsolationLevel.ReadCommitted, "Compra Ganado")

        Try
            Trans.Add(Entity)

            Estatus = EstatusChar.CANCELADO
            Entity.Save()

            Me.GenerarMovimientoGanadoCancelacion(Trans)
            Me.MovimientoGanadoCancelacion.Guardar(Trans)
            Trans.Add(Me.MovimientoGanado.Entidad)
            Me.MovimientoGanado.Entidad.Save()
            Me.Detalle.Borrar(Trans)
            Me.GenerarDetalleCorral(Operacion.RESTA)

            Dim detalleCorral As CC.McecatCorralesDetCollection = Me.Corral.Detalle.ObtenerColeccion

            Trans.Add(detalleCorral)

            detalleCorral.SaveMulti()

            Trans.Commit()

            Return True
        Catch ex As Exception
            Estatus = EstatusChar.VIGENTE
            Trans.Rollback()
            Throw ex
        End Try
    End Function

    Public Overrides Function ToString() As String
        Return Me.Folio.Trim
    End Function

    Private Sub GenerarMovimientoGanado(ByRef Trans As HC.Transaction)
        Me.MovimientoGanado = New MovimientoGanadoClass

        With Me.MovimientoGanado
            .FechaMovimeinto = Me.FechaRecepcion
            '.EstablecerTipoMovimientoGanado(EntradaXcompraGanado, Trans)
            .EstablecerTipoMovimientoGanado(InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.EntradaXcompraGanado, Trans)
            .Estatus = MovimientoGanadoClass.EstatusMovimiento.VIGENTE
            .Referencia = ""
        End With

        For Each detalleCompra As CompraGanadoDetalleClass In Me.Detalle
            Me.MovimientoGanado.Detalle += CType(detalleCompra, IMovimientoGanadoDetalle)
        Next
    End Sub

    Private Sub GenerarMovimientoGanadoCancelacion(ByRef Trans As HC.Transaction)
        Me.MovimientoGanadoCancelacion = New MovimientoGanadoClass

        With Me.MovimientoGanadoCancelacion
            .FechaMovimeinto = Me.FechaCancelacion
            '.EstablecerTipoMovimientoGanado(SalidaXcancelacionCompraGanado, Trans)
            .EstablecerTipoMovimientoGanado(InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.SalidaXcancelacionCompraGanado, Trans)
            .Estatus = MovimientoGanadoClass.EstatusMovimiento.VIGENTE
            .Referencia = Me.MovimientoGanado.FolioMovimeinto
            Me.MovimientoGanado.Estatus = MovimientoGanadoClass.EstatusMovimiento.CANCELADO
        End With

        For Each detalleCompra As CompraGanadoDetalleClass In Me.Detalle
            Me.MovimientoGanadoCancelacion.Detalle += CType(detalleCompra, IMovimientoGanadoDetalleCancelacion)
        Next
    End Sub

    Private Sub GenerarFolioRecepcionGanado(ByVal trans As HC.Transaction)
        Dim folio As New FoliosClass

        folio.Año = 1
        folio.Mes = 1
        folio.Codigo = CodigodeFolios.CompradeGanado

        If Not folio.Guardar(trans) Then
            Throw New Exception("Error al generar el folio de compra de ganado")
        End If

        Me.GastosTransporte.Folio = "G" & folio.Consecutivo.ToString("000000000")
        Me.Folio = "G" & folio.Consecutivo.ToString("000000000")
    End Sub

    Private Sub GenerarDetalleCorral(ByVal fcOperacion As Operacion)
        Dim encontro As Boolean = False
        Corral.RefrescarDetalle()

        For Each tipoGanadoCompra As CompraGanadoDetalleClass In Me.Detalle
            encontro = False

            For Each tipoGanadoCorral As CorralDetalleClass In Corral.Detalle
                If tipoGanadoCompra.IdTipoGanado = tipoGanadoCorral.IdTipoGanado Then
                    tipoGanadoCorral.ExistCabezas += tipoGanadoCompra.CantCabezas * CDec(fcOperacion)
                    tipoGanadoCorral.ExistKilos += tipoGanadoCompra.CantKilos / Me.KilosComprados * Me.KilosRecibidos * CDec(fcOperacion)
                    tipoGanadoCorral.SaldoCostoInd += Me.CostoIndirecto / Me.Cabezas * tipoGanadoCompra.CantCabezas * CDec(fcOperacion)
                    tipoGanadoCorral.CostoEnt += (tipoGanadoCompra.Importe + _
                                            (tipoGanadoCompra.CantKilos / Me.KilosComprados * _
                                            (Me.Comision + Me.ImporteXGuia * Me.NumGuias + _
                                            Me.ImportePredial + Me.ImporteEducacion))) * CDec(fcOperacion)

                    If fcOperacion = Operacion.RESTA Then
                        tipoGanadoCorral.FEchaUltSal = Me.FechaCancelacion
                    Else
                        tipoGanadoCorral.FechaUltEnt = Me.FechaRecepcion
                    End If

                    encontro = True

                    Exit For
                End If
            Next

            If Not encontro AndAlso fcOperacion = Operacion.SUMA Then
                Dim nuevoTipoGanadoCorral As New CorralDetalleClass

                With nuevoTipoGanadoCorral
                    .IdCorral = Corral.IdCorral
                    .IdTipoGanado = tipoGanadoCompra.IdTipoGanado
                    .ExistCabezas = tipoGanadoCompra.CantCabezas
                    .ExistKilos = tipoGanadoCompra.CantKilos / Me.KilosComprados * Me.KilosRecibidos
                    .SaldoCostoInd = Me.CostoIndirecto / Me.Cabezas * tipoGanadoCompra.CantCabezas
                    .CostoEnt = tipoGanadoCompra.Importe + _
                                (tipoGanadoCompra.CantKilos / Me.KilosComprados * _
                                (Me.Comision + Me.ImporteXGuia * Me.NumGuias + _
                                Me.ImportePredial + Me.ImporteEducacion))
                    .ImpteMedicamento = 0D
                    .ImpteAlimento = 0D
                    .KilosAlimento = 0D
                    .FechaUltEnt = Me.FechaRecepcion
                End With

                Corral.Detalle.Add(nuevoTipoGanadoCorral)
            ElseIf Not encontro AndAlso fcOperacion = Operacion.RESTA Then
                Throw New Exception(String.Format("No es posible dar salida al tipo de ganado {0} en el corral {1} por que no tiene registrada una entrada.", tipoGanadoCompra.TipoGanado.Descripcion, Me.IdCorral))
            End If
        Next
    End Sub

    Private Sub AfectarCorralEdicion()
        Dim compraGanado As New CompraGanadoClass(Me.Folio)

        For Each tipoGanadoCompra As CompraGanadoDetalleClass In Me.Detalle
            For Each tipoGanadoCorral As CorralDetalleClass In Corral.Detalle
                If tipoGanadoCompra.IdTipoGanado = tipoGanadoCorral.IdTipoGanado Then
                    'Deshago la informacion que afecto la compra al guardarse por ultima vez
                    tipoGanadoCorral.SaldoCostoInd -= compraGanado.CostoIndirecto / compraGanado.Cabezas * tipoGanadoCompra.CantCabezas
                    tipoGanadoCorral.CostoEnt -= tipoGanadoCompra.Importe + _
                                                (tipoGanadoCompra.CantKilos / compraGanado.KilosComprados * _
                                                (compraGanado.Comision + compraGanado.ImporteXGuia * compraGanado.NumGuias + _
                                                compraGanado.ImportePredial + compraGanado.ImporteEducacion))

                    'Realizo los calculos con la nueva información
                    tipoGanadoCorral.SaldoCostoInd += (((Me.CostoIndirecto / Me.Cabezas) * tipoGanadoCompra.CantCabezas))
                    tipoGanadoCorral.CostoEnt += tipoGanadoCompra.Importe + _
                                                (tipoGanadoCompra.CantKilos / Me.KilosComprados * _
                                                (Me.Comision + Me.ImporteXGuia * Me.NumGuias + _
                                                Me.ImportePredial + Me.ImporteEducacion))
                    Exit For
                End If
            Next
        Next
    End Sub
#End Region

#Region "Enumeradores"
    Public Enum TiposComision
        SIN_COMISION
        CABEZAS
        KILOS
    End Enum

    Private Enum Operacion
        SUMA = 1
        RESTA = -1
    End Enum
#End Region
End Class