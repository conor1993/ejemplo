Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class SalidaGanadoDetalleClass
    Inherits EC.SalidaGanadoDetEntity
    Implements IMovimientoGanadoDetalle

#Region "Miembros"
    Private _SalidaGanadoCabecero As SalidaGanadoCabeceroClass
    Private _TipoGanado As TipoGanadoClass
    Private _Lote As LoteClass
    Private _CorralDetalle As CorralDetalleClass
    Private _LoteDetalle As LoteDetClass
    Private _FolioMovimientoGanado As String
#End Region

#Region "Constructores"
    Sub New(ByVal IdCorralReciba As Integer, ByVal IdTipoGanado As Integer)
        MyBase.FetchUsingPK("", IdCorralReciba, IdTipoGanado)
    End Sub

    Sub New(ByVal Entidad As EC.SalidaGanadoDetEntity)
        Me.IdSalidaGanadoCab = Entidad.IdSalidaGanadoCab
        Me.IdLote = Entidad.IdLote
        Me.Arete = Entidad.Arete
        Me.IdTipoGanado = Entidad.IdTipoGanado
        Me.IdSalidaGanadoDet = Entidad.IdSalidaGanadoDet
        Me.IdMcecatLotesDet = Entidad.IdMcecatLotesDet
        Me.Fecha = Entidad.Fecha
        Me.Cabezas = Entidad.Cabezas
        Me.Kilos = Entidad.Kilos
        Me.CostoxKilo = Entidad.CostoxKilo
        Me.CostoEntrada = Entidad.CostoEntrada
        Me.CostoAlimento = Entidad.CostoAlimento
        Me.CostoMedicina = Entidad.CostoMedicina
        Me.KilosAlimento = Entidad.KilosAlimento
        Me.AreteSiniiga = Entidad.AreteSiniiga
        Me.AreteTransporte = Entidad.AreteTransporte
        Me.PrecioxKilo = Entidad.PrecioxKilo
        Me.CostoOperacional = Entidad.CostoOperacional
        Me.IsDirty = Entidad.IsDirty
        Me.IsNew = Entidad.IsNew
    End Sub

    Sub New(ByVal IdSalidaGanadoCab As Integer, ByVal IdTipoGanado As Integer, ByVal IdSalidaGanadoDet As Integer, ByVal Fecha As Date, ByVal IdLote As Nullable(Of Integer), ByVal CostoOperacional As Decimal, ByVal Cabezas As Integer, ByVal Kilos As Double, ByVal CostoxKilo As Decimal, ByVal CostoEntrada As Decimal, ByVal CostoAlimento As Decimal, ByVal CostoMedicina As Decimal, ByVal KilosAlimento As Decimal, ByVal IdMceCatLotesDet As Nullable(Of Integer), ByVal Arete As String, ByVal AreteSiniiga As String, ByVal AreteTransporte As String, ByVal PrecioxKilo As Decimal)
        Me.IdSalidaGanadoCab = IdSalidaGanadoCab
        Me.IdSalidaGanadoDet = IdSalidaGanadoDet
        Me.IdMcecatLotesDet = IdMceCatLotesDet
        Me.AreteSiniiga = AreteSiniiga
        Me.AreteTransporte = AreteTransporte
        Me.Arete = Arete
        Me.IdLote = IdLote
        Me.IdTipoGanado = IdTipoGanado
        Me.Fecha = Fecha
        Me.Cabezas = Cabezas
        Me.Kilos = Kilos
        Me.CostoxKilo = CostoxKilo
        Me.CostoEntrada = CostoEntrada
        Me.CostoAlimento = CostoAlimento
        Me.CostoMedicina = CostoMedicina
        Me.KilosAlimento = KilosAlimento
        Me.PrecioxKilo = PrecioxKilo
        Me.CostoOperacional = CostoOperacional
    End Sub

    Sub New()

    End Sub
#End Region

#Region "Propiedades"
    Public Overrides Property Fecha() As Date Implements IMovimientoGanadoDetalle.FechaMovimiento
        Get
            Return IIf(MyBase.Fecha = Date.MinValue, Me.SalidaGanadoCabecero.Fecha, MyBase.Fecha)
        End Get
        Set(ByVal value As Date)
            MyBase.Fecha = value
        End Set
    End Property

    Public Overrides Property Cabezas() As Integer Implements IMovimientoGanadoDetalle.Cabezas
        Get
            Return MyBase.Cabezas
        End Get
        Set(ByVal value As Integer)
            MyBase.Cabezas = value

            If Me.IsNew Then
                Calcular_CostoxKilo()
            End If
        End Set
    End Property

    Public Overrides Property CostoxKilo() As Decimal Implements IMovimientoGanadoDetalle.CostoKilo
        Get
            Return MyBase.CostoxKilo
        End Get
        Set(ByVal value As Decimal)
            MyBase.CostoxKilo = value
        End Set
    End Property

    Public Overrides Property Kilos() As Decimal Implements IMovimientoGanadoDetalle.Kilos
        Get
            Return MyBase.Kilos
        End Get
        Set(ByVal value As Decimal)
            MyBase.Kilos = value

            If Me.IsNew Then
                Calcular_CostoxKilo()
            End If
        End Set
    End Property

    Public Overrides Property IdTipoGanado() As Integer Implements IMovimientoGanadoDetalle.IdTipoGanado
        Get
            Return MyBase.IdTipoGanado
        End Get
        Set(ByVal value As Integer)
            MyBase.IdTipoGanado = value

            If Me.IsNew Then
                Calcular_CostoxKilo()
            End If
        End Set
    End Property

    Public ReadOnly Property CabezasExistentes() As Integer
        Get
            If CorralDetalle IsNot Nothing AndAlso Not CorralDetalle.Entidad.IsNew Then
                Return CorralDetalle.ExistCabezas
            Else
                Return 0
            End If
        End Get
    End Property

    Public Overrides Property Arete() As String
        Get
            If IdMcecatLotesDet.HasValue Then
                Return LoteDetalle.AretePropio
            Else
                Return MyBase.Arete
            End If
        End Get
        Set(ByVal value As String)
            MyBase.Arete = value
        End Set
    End Property

    Public Overrides Property AreteSiniiga() As String
        Get
            If IdMcecatLotesDet.HasValue Then
                Return LoteDetalle.AreteSiniiga
            Else
                Return MyBase.AreteSiniiga
            End If
        End Get
        Set(ByVal value As String)
            MyBase.AreteSiniiga = value
        End Set
    End Property

    Public Overrides Property AreteTransporte() As String
        Get
            If IdMcecatLotesDet.HasValue Then
                Return LoteDetalle.AreteTransporte
            Else
                Return MyBase.AreteTransporte
            End If
        End Get
        Set(ByVal value As String)
            MyBase.AreteTransporte = value
        End Set
    End Property

#End Region

#Region "Propiedades Calculadas"
    Public ReadOnly Property FolioMovimientoGanado() As String Implements IMovimientoGanadoDetalle.FolioMovimeintoGanado
        Get
            Return MovimientoGanado.FolioMovimeinto
        End Get
    End Property

    Public ReadOnly Property MovimientoGanado() As MovimientoGanadoClass Implements IMovimientoGanadoDetalle.MovimeintoGanado
        Get
            Return SalidaGanadoCabecero.MovimientoGanado
        End Get
    End Property

    Public ReadOnly Property Importe() As Decimal Implements IMovimientoGanadoDetalle.Importe
        Get
            Return Me.CostoxKilo * Me.Kilos
        End Get
    End Property

    Public ReadOnly Property ImporteVenta() As Decimal
        Get
            Return IIf(Me.PrecioxKilo.HasValue, Me.PrecioxKilo, 0D) * Me.Kilos
        End Get
    End Property

    ' prohibido agregar la condicion elseif/OrElse _salidaganadocabecero.IdSalidaGanadoCab <> me.IdSalidaGanadoCab
    ' ya que generaria errores en las Salidas de Ganado
    Public ReadOnly Property SalidaGanadoCabecero() As SalidaGanadoCabeceroClass
        Get
            If _SalidaGanadoCabecero Is Nothing Then
                _SalidaGanadoCabecero = New SalidaGanadoCabeceroClass(Me.SalidaGanadoCab)
            End If
            Return _SalidaGanadoCabecero
        End Get
    End Property

    Public ReadOnly Property TipoGanado() As TipoGanadoClass
        Get
            If _TipoGanado Is Nothing OrElse _TipoGanado.IdTipoGanado <> Me.IdTipoGanado Then
                _TipoGanado = New TipoGanadoClass(Me.McgcatTiposdeGanado)

                If Me.IsNew Then
                    Calcular_CostoxKilo()
                End If
            End If
            Return _TipoGanado
        End Get
    End Property

    Public ReadOnly Property Lote() As LoteClass
        Get
            If _Lote Is Nothing OrElse _Lote.IdLote <> Me.IdLote.Value Then
                _Lote = New LoteClass(Me.McecatLotesCab)

                If Me.IsNew Then
                    Calcular_CostoxKilo()
                End If
            End If
            Return _Lote
        End Get
    End Property

    Public ReadOnly Property CorralDestino() As CorralClass
        Get
            Return Lote.Corral
        End Get
    End Property

    Public ReadOnly Property CorralDetalle() As CorralDetalleClass
        Get
            If _CorralDetalle Is Nothing OrElse (_CorralDetalle.IdCorral <> Me.SalidaGanadoCabecero.IdCorral Or _TipoGanado.IdTipoGanado <> Me.IdTipoGanado) Then
                _CorralDetalle = New CorralDetalleClass(Me.SalidaGanadoCabecero.IdCorral, TipoGanado.IdTipoGanado)

                If Me.IsNew Then
                    Calcular_CostoxKilo()
                End If
            End If
            Return _CorralDetalle
        End Get
    End Property

    Public ReadOnly Property LoteDetalle() As LoteDetClass
        Get
            If _LoteDetalle Is Nothing OrElse Me.IdMcecatLotesDet.HasValue AndAlso _LoteDetalle.IdMcecatLotesDet <> Me.IdMcecatLotesDet.Value Then
                _LoteDetalle = New LoteDetClass(Me.McecatLotesDet)

                If Me.IsNew Then
                    Calcular_CostoxKilo()
                End If
            End If
            Return _LoteDetalle
        End Get
    End Property

    Public ReadOnly Property CostoIndirecto() As Decimal
        Get
            Return Me.CostoxKilo - Me.CostoEntrada - Me.CostoAlimento - Me.CostoMedicina
        End Get
    End Property
#End Region

#Region "Metodos"
    Public Sub Calcular_CostoxKilo()
        Me.CalcularKilosAlimentoxKilo()
        Me.CostoxKilo = Me.CalcularCostoEntradaxKilo + Me.CalcularCostoAlimentoxKilo + Me.CalcularCostoMedicamentosxKilo + Me.CalcularCostoIndirectoxKilo
    End Sub

    Friend Sub EstablecerCabecero(ByRef Cabecero As SalidaGanadoCabeceroClass)
        _SalidaGanadoCabecero = Cabecero
    End Sub

    Private Function CalcularCostoEntradaxKilo() As Decimal
        Me.CostoEntrada = 0D

        If SalidaGanadoCabecero.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_a_Rastro _
        OrElse SalidaGanadoCabecero.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_a_Venta _
        OrElse SalidaGanadoCabecero.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_por_Muerte _
        OrElse SalidaGanadoCabecero.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_por_Tranferencia Then
            If Me.LoteDetalle IsNot Nothing AndAlso Not Me.LoteDetalle.IsNew Then
                If Me.Kilos <> 0 Then
                    Me.CostoEntrada = Me.LoteDetalle.Impte / Me.Kilos
                ElseIf Me.LoteDetalle.KilosEntrada <> 0 Then
                    Me.CostoEntrada = Me.LoteDetalle.Impte / Me.LoteDetalle.KilosEntrada
                End If
            End If
        Else
            If Not CorralDetalle.Entidad.IsNew Then
                If Me.CorralDetalle.ExistCabezas <> 0 AndAlso Me.Kilos <> 0 AndAlso Me.Cabezas <> 0 Then
                    Me.CostoEntrada = Me.CorralDetalle.CostoEnt / Me.CorralDetalle.ExistCabezas / Me.Kilos * Me.Cabezas
                ElseIf CorralDetalle.ExistKilos <> 0 Then
                    Me.CostoEntrada = CorralDetalle.CostoEnt / CorralDetalle.ExistKilos
                End If
            End If
        End If
        Return Me.CostoEntrada
    End Function

    Private Function CalcularCostoMedicamentosxKilo() As Decimal
        Me.CostoMedicina = 0D

        If SalidaGanadoCabecero.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_a_Rastro _
        Or SalidaGanadoCabecero.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_a_Venta _
        Or SalidaGanadoCabecero.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_por_Muerte _
        OrElse SalidaGanadoCabecero.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_por_Tranferencia Then
            If Me.LoteDetalle IsNot Nothing AndAlso Not Me.LoteDetalle.IsNew Then
                If Me.Kilos <> 0 Then
                    Me.CostoMedicina = Me.LoteDetalle.ImpteMed / Me.Kilos
                ElseIf Me.LoteDetalle.KilosEntrada <> 0 Then
                    Me.CostoMedicina = Me.LoteDetalle.ImpteMed / Me.LoteDetalle.KilosEntrada
                End If
            End If
        Else
            If Not CorralDetalle.Entidad.IsNew Then
                If CorralDetalle.ExistCabezas <> 0 AndAlso Me.Kilos <> 0 AndAlso Me.Cabezas <> 0 Then
                    Me.CostoMedicina = CorralDetalle.ImpteMedicamento / CorralDetalle.ExistCabezas / Me.Kilos * Me.Cabezas
                ElseIf CorralDetalle.ExistKilos <> 0 Then
                    Me.CostoMedicina = CorralDetalle.ImpteMedicamento / CorralDetalle.ExistKilos
                End If
            End If
        End If
        Return Me.CostoMedicina
    End Function

    Private Function CalcularCostoAlimentoxKilo() As Decimal
        Me.CostoAlimento = 0D

        If SalidaGanadoCabecero.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_a_Rastro _
        Or SalidaGanadoCabecero.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_a_Venta _
        Or SalidaGanadoCabecero.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_por_Muerte _
        OrElse SalidaGanadoCabecero.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_por_Tranferencia Then
            If Me.LoteDetalle IsNot Nothing AndAlso Not Me.LoteDetalle.IsNew Then
                If Me.Kilos <> 0 Then
                    Me.CostoAlimento = Me.LoteDetalle.ImpteAlim / Me.Kilos
                ElseIf Me.LoteDetalle.KilosEntrada <> 0 Then
                    Me.CostoAlimento = Me.LoteDetalle.ImpteAlim / Me.LoteDetalle.KilosEntrada
                End If
            End If
        Else
            If Not CorralDetalle.Entidad.IsNew Then
                If CorralDetalle.ExistCabezas <> 0 AndAlso Me.Kilos <> 0 AndAlso Me.Cabezas <> 0 Then
                    Me.CostoAlimento = CorralDetalle.ImpteAlimento / CorralDetalle.ExistCabezas / Me.Kilos * Me.Cabezas
                ElseIf CorralDetalle.ExistKilos <> 0 Then
                    Me.CostoAlimento = CorralDetalle.ImpteAlimento / CorralDetalle.ExistKilos
                End If
            End If
        End If
        Return Me.CostoAlimento
    End Function

    Private Function CalcularKilosAlimentoxKilo() As Decimal
        Me.KilosAlimento = 0D

        If SalidaGanadoCabecero.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_a_Rastro _
        Or SalidaGanadoCabecero.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_a_Venta _
        Or SalidaGanadoCabecero.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_por_Muerte _
        OrElse SalidaGanadoCabecero.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_por_Tranferencia Then
            If Me.LoteDetalle IsNot Nothing AndAlso Not Me.LoteDetalle.IsNew Then
                If Me.Kilos <> 0 Then
                    Me.KilosAlimento = Me.LoteDetalle.KilosAlim / Me.Kilos
                ElseIf Me.LoteDetalle.KilosEntrada <> 0 Then
                    Me.KilosAlimento = Me.LoteDetalle.KilosAlim / Me.LoteDetalle.KilosEntrada
                End If
            End If
        Else
            If Not CorralDetalle.Entidad.IsNew Then
                If CorralDetalle.ExistCabezas <> 0 AndAlso Me.Kilos <> 0 AndAlso Me.Cabezas <> 0 Then
                    Me.KilosAlimento = CorralDetalle.KilosAlimento / CorralDetalle.ExistCabezas / Me.Kilos * Me.Cabezas
                ElseIf CorralDetalle.ExistKilos <> 0 Then
                    Me.KilosAlimento = CorralDetalle.KilosAlimento / CorralDetalle.ExistKilos
                End If
            End If
        End If
        Return Me.KilosAlimento
    End Function

    Private Function CalcularCostoIndirectoxKilo() As Decimal
        If SalidaGanadoCabecero.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_a_Rastro _
        Or SalidaGanadoCabecero.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_a_Venta _
        Or SalidaGanadoCabecero.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_por_Muerte _
        OrElse SalidaGanadoCabecero.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_por_Tranferencia Then
            If Me.LoteDetalle IsNot Nothing AndAlso Not Me.LoteDetalle.IsNew Then
                If Me.Kilos <> 0 Then
                    Return Me.LoteDetalle.SaldoCostoInd / Me.Kilos
                ElseIf Me.LoteDetalle.KilosEntrada <> 0 Then
                    Return Me.LoteDetalle.SaldoCostoInd / Me.LoteDetalle.KilosEntrada
                End If
            End If
        Else
            If Not CorralDetalle.Entidad.IsNew Then
                If Me.CorralDetalle.ExistCabezas <> 0 AndAlso Me.Kilos <> 0 AndAlso Me.Cabezas <> 0 Then
                    Return Me.CorralDetalle.SaldoCostoInd / Me.CorralDetalle.ExistCabezas / Me.Kilos * Me.Cabezas
                ElseIf Me.CorralDetalle.ExistKilos <> 0 Then
                    Return Me.CorralDetalle.SaldoCostoInd / Me.CorralDetalle.ExistKilos
                End If
            End If
        End If
        Return 0D
    End Function

    Public Shadows Function Save() As Boolean
        Me.IdSalidaGanadoCab = Me.SalidaGanadoCabecero.IdSalidaGanadoCab
        Me.Fecha = Me.SalidaGanadoCabecero.Fecha
        Return MyBase.Save()
    End Function
#End Region
End Class

Public Class SalidaGanadoDetalleCollectionClass
    Inherits ColleccionBase(Of SalidaGanadoDetalleClass)

#Region "Miembros"

    Dim _Cabecero As SalidaGanadoCabeceroClass

#End Region

#Region "Constructores"

    Sub New(ByRef Cabecero As SalidaGanadoCabeceroClass)
        _Cabecero = Cabecero
    End Sub

    Sub New()

    End Sub

#End Region

#Region "Propiedades"

    Public ReadOnly Property Cabecero() As SalidaGanadoCabeceroClass
        Get
            Return _Cabecero
        End Get
    End Property

#End Region

#Region "Metodos"

    Protected Overrides Function AddNewCore() As Object
        Dim CorralRecibaDetalle As SalidaGanadoDetalleClass = CType(MyBase.AddNewCore(), SalidaGanadoDetalleClass)
        CorralRecibaDetalle.EstablecerCabecero(Cabecero)

        If Cabecero.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Transferencia_de_Reciba_a_Corral Then
            CorralRecibaDetalle.Cabezas = 1
        End If
        Return CorralRecibaDetalle
    End Function

    Public Shadows Sub Add(ByVal Entidad As SalidaGanadoDetalleClass)
        Entidad.EstablecerCabecero(Cabecero)
        MyBase.Add(Entidad)
    End Sub

    Public Shadows Sub Add(ByVal Entidad As EC.SalidaGanadoDetEntity)
        Me.Add(New SalidaGanadoDetalleClass(Entidad))
    End Sub

#End Region

End Class
