Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class CorralRecibaDetalleClass
    Inherits EC.CorralRecibaDetEntity
    Implements IMovimientoGanadoDetalle

#Region "Declaraciones"
    Private _CorralRecibaCabecero As CorralRecibaCabeceroClass
    Private _TipoGanado As TipoGanadoClass
    Private _CorralDetalle As CorralDetalleClass
    Private _FolioMovimientoGanado As String
#End Region

#Region "Constructores"
    Sub New(ByVal IdCorralReciba As Integer, ByVal IdTipoGanado As Integer)
        MyBase.FetchUsingPK("", IdCorralReciba, IdTipoGanado)
    End Sub

    Sub New(ByVal Entidad As EC.CorralRecibaDetEntity)
        Me.IdCorralReciba = Entidad.IdCorralReciba
        Me.IdTipoGanado = Entidad.IdTipoGanado
        Me.IdCorralRecibaDet = Entidad.IdCorralRecibaDet
        Me.Fecha = Entidad.Fecha
        Me.Cabezas = Entidad.Cabezas
        Me.Kilos = Entidad.Kilos
        Me.CostoxKilo = Entidad.CostoxKilo
        Me.CostoEntrada = Entidad.CostoEntrada
        Me.CostoAlimento = Entidad.CostoAlimento
        Me.CostoMedicina = Entidad.CostoMedicina
        Me.KilosAlimento = Entidad.KilosAlimento
        Me.Arete = Entidad.Arete
        Me.AreteSiniiga = Entidad.AreteSiniiga
        Me.AreteTransporte = Entidad.AreteTransporte
        Me.PrecioxKilo = Entidad.PrecioxKilo
        Me.IsDirty = Entidad.IsDirty
        Me.IsNew = Entidad.IsNew
    End Sub

    Sub New(ByVal IdCorralReciba As Integer, ByVal IdTipoGanado As Integer, ByVal IdCorralRecibaDet As Integer, ByVal Fecha As Date, ByVal Cabezas As Integer, ByVal Kilos As Double, ByVal CostoxKilo As Decimal, ByVal CostoEntrada As Decimal, ByVal CostoAlimento As Decimal, ByVal CostoMedicina As Decimal, ByVal KilosAlimento As Decimal, ByVal Arete As String, ByVal AreteSiniiga As String, ByVal AreteTransporte As String, ByVal PrecioxKilo As Decimal)
        Me.IdCorralReciba = IdCorralReciba
        Me.IdTipoGanado = IdTipoGanado
        Me.IdCorralRecibaDet = IdCorralRecibaDet
        Me.Fecha = Fecha
        Me.Cabezas = Cabezas
        Me.Kilos = Kilos
        Me.CostoxKilo = CostoxKilo
        Me.CostoEntrada = CostoEntrada
        Me.CostoAlimento = CostoAlimento
        Me.CostoMedicina = CostoMedicina
        Me.KilosAlimento = KilosAlimento
        Me.Arete = Arete
        Me.AreteSiniiga = AreteSiniiga
        Me.AreteTransporte = AreteTransporte
        Me.PrecioxKilo = PrecioxKilo
    End Sub

    Sub New()

    End Sub
#End Region

#Region "Propiedades"
    Public Overrides Property Fecha() As Date Implements IMovimientoGanadoDetalle.FechaMovimiento
        Get
            Return IIf(MyBase.Fecha = Date.MinValue, Me.CorralRecibaCabecero.Fecha, MyBase.Fecha)
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
            Calcular_CostoxKilo()
        End Set
    End Property

    Public Overrides Property IdTipoGanado() As Integer Implements IMovimientoGanadoDetalle.IdTipoGanado
        Get
            Return MyBase.IdTipoGanado
        End Get
        Set(ByVal value As Integer)
            MyBase.IdTipoGanado = value
            Calcular_CostoxKilo()
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
#End Region

#Region "Propiedades Calculadas"
    Public ReadOnly Property FolioMovimientoGanado() As String Implements IMovimientoGanadoDetalle.FolioMovimeintoGanado
        Get
            Return MovimientoGanado.FolioMovimeinto
        End Get
    End Property

    Public ReadOnly Property MovimientoGanado() As MovimientoGanadoClass Implements IMovimientoGanadoDetalle.MovimeintoGanado
        Get
            Return CorralRecibaCabecero.MovimientoGanado
        End Get
    End Property

    Public ReadOnly Property Importe() As Decimal Implements IMovimientoGanadoDetalle.Importe
        Get
            Return Me.CostoxKilo * Me.Kilos
        End Get
    End Property

    Public ReadOnly Property CorralRecibaCabecero() As CorralRecibaCabeceroClass
        Get
            If _CorralRecibaCabecero Is Nothing Then
                _CorralRecibaCabecero = New CorralRecibaCabeceroClass(Me.CorralRecibaCab)
            End If
            Return _CorralRecibaCabecero
        End Get
    End Property

    Public ReadOnly Property TipoGanado() As TipoGanadoClass
        Get
            If _TipoGanado Is Nothing OrElse _TipoGanado.IdTipoGanado <> Me.IdTipoGanado Then
                _TipoGanado = New TipoGanadoClass(Me.McgcatTiposdeGanado)
                Calcular_CostoxKilo()
            End If
            Return _TipoGanado
        End Get
    End Property

    Public ReadOnly Property CorralDetalle() As CorralDetalleClass
        Get
            If _CorralDetalle Is Nothing OrElse (_CorralDetalle.IdCorral <> Me.CorralRecibaCabecero.IdCorral Or _TipoGanado.IdTipoGanado <> Me.IdTipoGanado) Then
                _CorralDetalle = New CorralDetalleClass(Me.CorralRecibaCabecero.IdCorral, TipoGanado.IdTipoGanado)
                Calcular_CostoxKilo()
            End If
            Return _CorralDetalle
        End Get
    End Property
#End Region

#Region "Metodos"
    Private Sub Calcular_CostoxKilo()
        Me.CalcularKilosAlimento()
        Me.CostoxKilo = Me.CalcularCostoEntrada + Me.CalcularCostoAlimento + Me.CalcularCostoMedicamentos
    End Sub

    Friend Sub EstablecerCabecero(ByRef Cabecero As CorralRecibaCabeceroClass)
        _CorralRecibaCabecero = Cabecero
    End Sub

    Public Function CalcularCostoEntrada() As Decimal
        Me.CostoEntrada = 0D

        If Not CorralDetalle.Entidad.IsNew Then
            If CorralDetalle.ExistKilos <> 0 Then
                Me.CostoEntrada = CorralDetalle.CostoEnt / CorralDetalle.ExistKilos
            End If
        End If
        Return Me.CostoEntrada
    End Function

    Public Function CalcularCostoMedicamentos() As Decimal
        Me.CostoMedicina = 0D

        If Not CorralDetalle.Entidad.IsNew Then
            If CorralDetalle.ExistKilos <> 0 Then
                Me.CostoMedicina = CorralDetalle.ImpteMedicamento / CorralDetalle.ExistKilos
            End If
        End If
        Return Me.CostoMedicina
    End Function

    Public Function CalcularCostoAlimento() As Decimal
        Me.CostoAlimento = 0D

        If Not CorralDetalle.Entidad.IsNew Then
            If CorralDetalle.ExistKilos <> 0 Then
                Me.CostoAlimento = CorralDetalle.ImpteAlimento / CorralDetalle.ExistKilos
            End If
        End If
        Return Me.CostoAlimento
    End Function

    Public Function CalcularKilosAlimento() As Decimal
        Me.KilosAlimento = 0D

        If Not CorralDetalle.Entidad.IsNew Then
            If CorralDetalle.ExistKilos <> 0 Then
                Me.KilosAlimento = CorralDetalle.KilosAlimento / CorralDetalle.ExistKilos
            End If
        End If
        Return Me.KilosAlimento
    End Function

    Public Shadows Function Save() As Boolean
        Me.IdCorralReciba = Me.CorralRecibaCabecero.IdCorralReciba
        Me.Fecha = Me.CorralRecibaCabecero.Fecha
        Return MyBase.Save()
    End Function
#End Region
End Class

Public Class CorralRecibaDetalleCollectionClass
    Inherits ColleccionBase(Of CorralRecibaDetalleClass)

#Region "Declaraciones"
    Dim _Cabecero As CorralRecibaCabeceroClass
#End Region

#Region "Constructores"
    Sub New(ByRef Cabecero As CorralRecibaCabeceroClass)
        _Cabecero = Cabecero
    End Sub

    Sub New()

    End Sub
#End Region

#Region "Propiedades"
    Public ReadOnly Property Cabecero() As CorralRecibaCabeceroClass
        Get
            Return _Cabecero
        End Get
    End Property
#End Region

#Region "Metodos"
    Protected Overrides Function AddNewCore() As Object
        Dim CorralRecibaDetalle As CorralRecibaDetalleClass = CType(MyBase.AddNewCore(), CorralRecibaDetalleClass)
        CorralRecibaDetalle.EstablecerCabecero(Cabecero)
        Return CorralRecibaDetalle
    End Function

    Public Shadows Sub Add(ByVal Entidad As CorralRecibaDetalleClass)
        Entidad.EstablecerCabecero(Cabecero)
        MyBase.Add(Entidad)
    End Sub

    Public Shadows Sub Add(ByVal Entidad As EC.CorralRecibaDetEntity)
        Me.Add(New CorralRecibaDetalleClass(Entidad))
    End Sub
#End Region
End Class
