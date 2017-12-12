Imports ORM = Integralab.ORM
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class LoteDetClass
    Inherits EC.McecatLotesDetEntity

#Region "Miembros"

    Private _LoteCabecero As LoteClass
    Private _TipoGanado As TipoGanadoClass
    Private _CorralDetalle As CorralDetalleClass

    Public Enum EstatusLoteDetalle As Byte
        VIGENTE = 1
        CERRADO = 2
    End Enum

#End Region

#Region "Constructores"

    Sub New(ByVal IdLoteDet As Integer)
        Me.FetchUsingPK(IdLoteDet)
    End Sub

    Sub New(ByVal Entidad As EC.McecatLotesDetEntity)
        If MyBase.FetchUsingPK(Entidad.IdMcecatLotesDet) AndAlso Entidad.IsDirty Then
            Me.IdLote = Entidad.IdLote
            Me.IdTipoGanado = Entidad.IdTipoGanado
            Me.AretePropio = Entidad.AretePropio
            Me.AreteSiniiga = Entidad.AreteSiniiga
            Me.AreteTransporte = Entidad.AreteTransporte
            Me.KilosEntrada = Entidad.KilosEntrada
            Me.KilosSalida = Entidad.KilosSalida
            Me.FechaEntrada = Entidad.FechaEntrada
            Me.FechaSalida = Entidad.FechaSalida
            Me.Impte = Entidad.Impte
            Me.ImpteAlim = Entidad.ImpteAlim
            Me.ImpteMed = Entidad.ImpteMed
            Me.KilosAlim = Entidad.KilosAlim
            Me.Gdpini = Entidad.Gdpini
            Me.Gdp = Entidad.Gdp
            Me.Eca = Entidad.Eca
            Me.Cki = Entidad.Cki
            Me.SaldoCostoInd = Entidad.SaldoCostoInd
            MyBase.Estatus = Entidad.Estatus
        End If
    End Sub

    Sub New(ByVal IdLote As Integer, ByVal IdTipoGanado As Integer, ByVal AretePropio As String, _
    ByVal AreteSiniiga As String, ByVal AreteTransporte As String, ByVal KilosEntrada As Decimal, _
    ByVal KilosSalida As Decimal, ByVal FechaEntrada As Date, ByVal FechaSalida As Nullable(Of Date), _
    ByVal KilosAlim As Decimal, ByVal ImpteAlim As Decimal, ByVal ImpteMed As Decimal, _
    ByVal GDPIni As Decimal, ByVal GDP As Decimal, ByVal ECA As Decimal, ByVal CKI As Decimal, _
    ByVal SaldoCostoInd As Decimal, ByVal Estatus As Byte, ByVal CostoEntrada As Decimal)
        Me.IdLote = IdLote
        Me.IdTipoGanado = IdTipoGanado
        Me.AretePropio = AretePropio
        Me.AreteSiniiga = AreteSiniiga
        Me.AreteTransporte = AreteTransporte
        Me.KilosEntrada = KilosEntrada
        Me.KilosSalida = KilosSalida
        Me.FechaEntrada = FechaEntrada
        Me.FechaSalida = FechaSalida
        Me.Impte = CostoEntrada
        Me.ImpteAlim = ImpteAlim
        Me.ImpteMed = ImpteMed
        Me.KilosAlim = KilosAlim
        Me.Gdpini = GDPIni
        Me.Gdp = GDP
        Me.Eca = ECA
        Me.Cki = CKI
        Me.SaldoCostoInd = SaldoCostoInd
        MyBase.Estatus = Estatus
    End Sub

    Sub New()
        Me.KilosSalida = 0D
        Me.FechaSalida = Nothing
        Me.KilosAlim = 0D
        Me.ImpteAlim = 0D
        Me.ImpteMed = 0D
        Me.Gdp = 0D
        Me.Eca = 0D
        Me.Cki = 0D
        Me.SaldoCostoInd = 0D
        Me.Estatus = EstatusLoteDetalle.VIGENTE
    End Sub

#End Region

#Region "Propiedades"

    Public ReadOnly Property LoteCabecero() As LoteClass
        Get
            If _LoteCabecero Is Nothing Then
                _LoteCabecero = New LoteClass(Me.McecatLotesCab)
            End If
            Return _LoteCabecero
        End Get
    End Property

    Public ReadOnly Property TipoGanado() As TipoGanadoClass
        Get
            If _TipoGanado Is Nothing Then
                _TipoGanado = New TipoGanadoClass(Me.McgcatTiposdeGanado)
            End If
            Return _TipoGanado
        End Get
    End Property

    Public Shadows Property Estatus() As EstatusLoteDetalle
        Get
            Return CType(MyBase.Estatus, EstatusLoteDetalle)
        End Get
        Set(ByVal value As EstatusLoteDetalle)
            MyBase.Estatus = value
        End Set
    End Property

    Public ReadOnly Property Corral() As CorralClass
        Get
            Return LoteCabecero.Corral
        End Get
    End Property

    Public ReadOnly Property CostoxKilo() As Decimal
        Get
            Dim Kilos As Decimal = 0D

            If Me.FechaSalida.HasValue Then
                Kilos = Me.KilosSalida
            Else
                Kilos = PesoEstimado
            End If

            If Kilos <> 0 Then
                Return (Me.Impte + Me.ImpteAlim + Me.ImpteMed + Me.SaldoCostoInd) / Kilos
            End If
            Return 0D
        End Get
    End Property

    Public ReadOnly Property ImporteTotal() As Decimal
        Get
            Return CostoxKilo * CType(IIf(Me.FechaSalida.HasValue, Me.KilosSalida, Me.KilosEntrada), Decimal)
        End Get
    End Property

    Public ReadOnly Property DiasEngorda() As Integer
        Get
            If Estatus = EstatusLoteDetalle.CERRADO Then
                Return CType((FechaSalida.Value.Ticks - FechaEntrada.Ticks) / TimeSpan.TicksPerDay, Integer)
            Else
                Return CType((Now.Ticks - FechaEntrada.Ticks) / TimeSpan.TicksPerDay, Integer)
            End If
        End Get
    End Property

    Public Shadows ReadOnly Property PesoEstimado() As Decimal
        Get
            Return Me.LoteCabecero.GDPINI * Me.DiasEngorda + Me.KilosEntrada
        End Get
    End Property

    Public ReadOnly Property GananciaKilos() As Decimal
        Get
            If Me.KilosSalida > 0 Then
                Return Me.KilosSalida - Me.KilosEntrada
            End If
            Return 0D
        End Get
    End Property

    Public ReadOnly Property ImporteTotalEstimado() As Decimal
        Get
            Return PesoEstimado * CostoxKilo
        End Get
    End Property

#End Region

#Region "Metodos"

    Friend Sub EstablecerCabecero(ByRef LoteCabecero As LoteClass)
        _LoteCabecero = LoteCabecero
    End Sub

#End Region

End Class

Public Class LoteDetCollectionClass
    Inherits ColleccionBase(Of LoteDetClass)

#Region "Miembros"

    Private _LoteCabecero As LoteClass

#End Region

#Region "Constructores"

    Sub New(ByVal Lote As EC.McecatLotesCabEntity)
        _LoteCabecero = New LoteClass(Lote)
    End Sub

    Sub New(ByVal Lote As LoteClass)
        _LoteCabecero = Lote
    End Sub

    Sub New()

    End Sub

#End Region

#Region "Propiedades"

    Public ReadOnly Property LoteCabecero() As LoteClass
        Get
            Return Me._LoteCabecero
        End Get
    End Property

#End Region

#Region "Metodos"

    Protected Overrides Function AddNewCore() As Object
        Dim LoteDetalle As LoteDetClass = CType(MyBase.AddNewCore(), LoteDetClass)
        LoteDetalle.EstablecerCabecero(LoteCabecero)
        Return LoteDetalle
    End Function

    Public Shadows Sub Add(ByVal LoteDetalle As LoteDetClass)
        LoteDetalle.EstablecerCabecero(LoteCabecero)
        MyBase.Add(LoteDetalle)
    End Sub

    Public Shadows Sub Add(ByVal Entidad As EC.McecatLotesDetEntity)
        Me.Add(New LoteDetClass(Entidad))
    End Sub

#End Region

End Class