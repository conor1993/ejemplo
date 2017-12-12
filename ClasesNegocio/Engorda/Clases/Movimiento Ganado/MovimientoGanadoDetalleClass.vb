Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports EC = IntegraLab.ORM.EntityClasses

Public Class MovimientoGanadoDetalleClass
    Inherits ClassBase(Of EC.DetMovGanEntity)

#Region "Miembros"
    Private m_MovimientoGanado As MovimientoGanadoClass
    Private m_TipoGanado As TipoGanadoClass
#End Region

#Region "Constructores"
    Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal entidad As EC.DetMovGanEntity)
        MyBase.New(entidad)
    End Sub

    Sub New(ByVal IdDetMovGan As Integer, ByVal folioMovimientoGanado As String, ByVal idTipoGanado As Integer)
        MyBase.New(New EC.DetMovGanEntity(IdDetMovGan.ToString, Integer.Parse(folioMovimientoGanado), idTipoGanado))
    End Sub

    Sub New(ByVal IdTipoGanado As Integer, ByVal IdGanadera As Byte, ByVal FechaMovimiento As Date, ByVal Cabezas As Integer, ByVal Kilos As Decimal, ByVal CostoxKilo As Decimal)
        Me.IdTipoGanado = IdTipoGanado
        Me.IdGanadera = IdGanadera
        Me.FechaMovimiento = FechaMovimiento
        Me.Cabezas = Cabezas
        Me.Kilos = Kilos
        Me.CostoXKilo = CostoxKilo
    End Sub
#End Region

#Region "Propiedades"
    Public Property FolioMovimientoGanado() As String
        Get
            Return Entity.FolMovGan
        End Get
        Set(ByVal value As String)
            Entity.FolMovGan = value
        End Set
    End Property

    Public Property IdDetMovGan() As Integer
        Get
            Return Entity.IdDetMovGan
        End Get
        Set(ByVal value As Integer)
            Entity.IdDetMovGan = value
        End Set
    End Property

    Public Property MovimeintoGanado() As MovimientoGanadoClass
        Get
            If Me.m_MovimientoGanado Is Nothing OrElse Me.m_MovimientoGanado.FolioMovimeinto = Me.FolioMovimientoGanado Then
                Me.m_MovimientoGanado = New MovimientoGanadoClass(Entity.CabMovGan)
            End If
            Return Me.m_MovimientoGanado
        End Get
        Set(ByVal value As MovimientoGanadoClass)
            Me.m_MovimientoGanado = value

            If value Is Nothing Then
                Entity.CabMovGan = Nothing
            Else
                Entity.CabMovGan = value.Entidad
            End If
        End Set
    End Property

    Public Property IdTipoGanado() As Integer
        Get
            Return Entity.CveGanado
        End Get
        Set(ByVal value As Integer)
            Entity.CveGanado = value
        End Set
    End Property

    Public Property TipoGanado() As TipoGanadoClass
        Get
            If m_TipoGanado Is Nothing Then
                m_TipoGanado = New TipoGanadoClass(Entity.McgcatTiposdeGanado)
            ElseIf Not m_TipoGanado.IdTipoGanado = IdTipoGanado Then
                m_TipoGanado.Entidad = Entity.McgcatTiposdeGanado
            End If

            Return m_TipoGanado
        End Get
        Set(ByVal value As TipoGanadoClass)
            m_TipoGanado = value

            If value Is Nothing Then
                Entity.McgcatTiposdeGanado = Nothing
            Else
                Entity.McgcatTiposdeGanado = value.Entidad
            End If
        End Set
    End Property

    Public Property FechaMovimiento() As Date
        Get
            Return Entity.FecMovGan
        End Get
        Set(ByVal value As Date)
            Entity.FecMovGan = value
        End Set
    End Property

    Public Property IdGanadera() As Nullable(Of Byte)
        Get
            Return Entity.CveGanadera
        End Get
        Set(ByVal value As Nullable(Of Byte))
            Entity.CveGanadera = value
        End Set
    End Property

    Public Property Cabezas() As Integer
        Get
            Return Entity.Cabezas
        End Get
        Set(ByVal value As Integer)
            Entity.Cabezas = value
        End Set
    End Property

    Public Property Kilos() As Decimal
        Get
            Return Entity.Kilos
        End Get
        Set(ByVal value As Decimal)
            Entity.Kilos = value
        End Set
    End Property

    Public Property CostoXKilo() As Decimal
        Get
            Return Entity.CostoxKilo
        End Get
        Set(ByVal value As Decimal)
            Entity.CostoxKilo = value
        End Set
    End Property

    Public ReadOnly Property Importe() As Decimal
        Get
            Return Kilos * CostoXKilo
        End Get
    End Property
#End Region

#Region "Metodos"
    Public Shadows Function Guardar(ByVal trans As HC.Transaction) As Boolean
        trans.Add(Entidad)

        Return Entidad.Save()
    End Function
#End Region

#Region "Eventos"

#End Region
End Class