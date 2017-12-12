Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class MetodoProrrateoDetalleClass
    Inherits ClassBase(Of EC.MetodoDetEntity)

#Region "Miembros"
    Private WithEvents m_Metodo As MetodoProrrateoClass
    Private WithEvents m_Departamento As DepartamentosClass

#Region "Eventos"

#End Region
#End Region

#Region "Constructores"
    Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal entidad As EC.MetodoDetEntity)
        MyBase.New(entidad)
    End Sub

    Sub New(ByVal idMetodoProrrateo As Integer, ByVal idCosto As Integer)
        MyBase.New(New EC.MetodoDetEntity(idMetodoProrrateo, idCosto))
    End Sub
#End Region

#Region "Propiedades"
    Public Property IdMetodoProrrateo() As Integer
        Get
            Return Entity.CodMetodo
        End Get
        Set(ByVal value As Integer)
            Entity.CodMetodo = value
        End Set
    End Property

    Public Property MetodoProrrateo() As MetodoProrrateoClass
        Get
            If m_Metodo Is Nothing Then
                m_Metodo = New MetodoProrrateoClass(Entity.MetodoCab)
            ElseIf Not m_Metodo.Codigo = IdMetodoProrrateo Then
                m_Metodo.Entidad = Entity.MetodoCab
            End If

            Return m_Metodo
        End Get
        Set(ByVal value As MetodoProrrateoClass)
            m_Metodo = value

            If value Is Nothing Then
                Entity.MetodoCab = Nothing
            Else
                Entity.MetodoCab = value.Entidad
            End If
        End Set
    End Property

    <ComponentModel.DisplayName("Código Departamento")> _
    Public Property IdDepartamento() As Integer
        Get
            Return Entity.CodCentroCosto
        End Get
        Set(ByVal value As Integer)
            Entity.CodCentroCosto = value
        End Set
    End Property

    Public Property Departamento() As DepartamentosClass
        Get
            If m_Departamento Is Nothing Then
                m_Departamento = New DepartamentosClass(Entity.CatDeptos)
            ElseIf Not m_Departamento.Codigo = Entity.CodCentroCosto Then
                m_Departamento.Entidad = Entity.CatDeptos
            End If

            Return m_Departamento
        End Get
        Set(ByVal value As DepartamentosClass)
            m_Departamento = value

            If value Is Nothing Then
                Entity.CatDeptos = Nothing
            Else
                Entity.CatDeptos = value.Entidad
            End If
        End Set
    End Property

    Public Property Porcentaje() As Decimal
        Get
            Return Entity.Porcentaje
        End Get
        Set(ByVal value As Decimal)
            Entity.Porcentaje = value
            Me.OnItemModificado()
        End Set
    End Property
#End Region

#Region "Metodos"

#End Region

#Region "Eventos"

#End Region
End Class