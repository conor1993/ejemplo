Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Public Class PuntosEntregaClass
    Inherits ClassBase(Of EC.MgralcatPuntosEntregaEntity)
    Dim _Estado As EstadoClass
    Dim _Ciudad As CiudadClass
    Dim _Poblacion As PoblacionClass
    Dim _Cliente As ClientesIntroductoresClass

#Region "Constructores"

    Sub New()
        Entity = New EC.MgralcatPuntosEntregaEntity
    End Sub

    Sub New(ByVal Entidad As EC.MgralcatPuntosEntregaEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal Codigo As Integer)
        Entity = New EC.MgralcatPuntosEntregaEntity(Codigo)
    End Sub
#End Region

#Region "Propiedades"
    Public Property Codigo() As Integer
        Get
            Return Entity.IdPuntoEntrega
        End Get
        Set(ByVal value As Integer)
            Entity.IdPuntoEntrega = value
        End Set
    End Property

    Public Property Estado() As EstadoClass
        Get
            If _Estado Is Nothing Then
                _Estado = New EstadoClass(Entity.Estado)
            End If
            Return _Estado
        End Get
        Set(ByVal value As EstadoClass)
            _Estado = value
            If value Is Nothing Then
                Entity.Estado = Nothing
            Else
                Entity.Estado = value.ObtenerEntidad
            End If
        End Set
    End Property

    Public Property IdEstado() As Integer
        Get
            Return Entity.IdEstado
        End Get
        Set(ByVal value As Integer)
            Entity.IdEstado = value
        End Set
    End Property

    Public Property IdCiudad() As Integer
        Get
            Return Entity.IdCiudad
        End Get
        Set(ByVal value As Integer)
            Entity.IdCiudad = value
        End Set
    End Property

    Public Property IdPoblacion() As Integer
        Get
            Return Entity.IdPoblacion
        End Get
        Set(ByVal value As Integer)
            Entity.IdPoblacion = value
        End Set
    End Property

    Public Property IdCliente() As Integer
        Get
            Return Entity.IdCliente
        End Get
        Set(ByVal value As Integer)
            Entity.IdCliente = value
        End Set
    End Property

    Public ReadOnly Property NomEstado() As String
        Get
            Return Estado.Descripcion
        End Get
    End Property

    Public Property Ciudad() As CiudadClass
        Get
            If _Ciudad Is Nothing Then
                _Ciudad = New CiudadClass(Entity.IdEstado, Entity.IdCiudad)
            End If
            Return _Ciudad
        End Get
        Set(ByVal value As CiudadClass)
            _Ciudad = value
            If value Is Nothing Then
                Entity.IdCiudad = 0
                'Else
                '    Entity.Ciudad = value.ObtenerEntidad.Codigo
            End If
        End Set
    End Property

    Public ReadOnly Property NomCiudad() As String
        Get
            Return Ciudad.Descripcion
        End Get
    End Property

    Public Property Poblacion() As PoblacionClass
        Get
            If _Poblacion Is Nothing Then
                _Poblacion = New PoblacionClass(Entity.IdEstado, Entity.IdCiudad, Entity.IdPoblacion)
            End If
            Return _Poblacion
        End Get
        Set(ByVal value As PoblacionClass)
            _Poblacion = value
            If value Is Nothing Then
                Entity.IdPoblacion = 0
            Else
                Entity.IdPoblacion = value.Codigo
            End If
        End Set
    End Property

    Public ReadOnly Property NomPoblacion() As String
        Get
            Return Poblacion.Descripcion
        End Get
    End Property

    Public Property Cliente() As ClientesIntroductoresClass
        Get
            If _Cliente Is Nothing Then
                _Cliente = New ClientesIntroductoresClass(Entity.MfacCatClientes)
            End If
            Return _Cliente
        End Get
        Set(ByVal value As ClientesIntroductoresClass)
            _Cliente = value
            If value Is Nothing Then
                Entity.MfacCatClientes = Nothing
            Else
                Entity.MfacCatClientes = value.ObtenerEntidad
            End If
        End Set
    End Property

    Public ReadOnly Property NomCliente() As String
        Get
            Return Cliente.Nombre
        End Get
    End Property

    Public Property Descripcion() As String
        Get
            Return Entity.Descripcion
        End Get
        Set(ByVal value As String)
            Entity.Descripcion = value
        End Set
    End Property

    Public Property Direccion() As String
        Get
            Return Entity.Direccion
        End Get
        Set(ByVal value As String)
            Entity.Direccion = value
        End Set
    End Property

    Public Property Colonia() As String
        Get
            Return Entity.Colonia
        End Get
        Set(ByVal value As String)
            Entity.Colonia = value
        End Set
    End Property

    Public Property CodgoPostal() As String
        Get
            Return Entity.CodigoPostal
        End Get
        Set(ByVal value As String)
            Entity.CodigoPostal = value
        End Set
    End Property

    Public Property Telefono() As String
        Get
            Return Entity.Telefono
        End Get
        Set(ByVal value As String)
            Entity.Telefono = value
        End Set
    End Property

    Public Property Estatus() As EstatusChar
        Get
            Return Asc(Entity.Estatus)
        End Get
        Set(ByVal value As EstatusChar)
            Entity.Estatus = Chr(value)
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Function Obtener(ByVal _Codigo As Integer) As Boolean
        Try
            Return Entity.FetchUsingPK(_Codigo)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function
#End Region
End Class

Public Class PuntosEntregaCollectionClass
    Inherits ColleccionBase(Of EC.MgralcatPuntosEntregaEntity, CC.MgralcatPuntosEntregaCollection, PuntosEntregaClass)

    Public Overloads Function Obtener(Optional ByVal Codigo As Integer = -1, Optional ByVal Descripcion As String = "") As Integer
        Try
            coleccion.Clear()
            Dim Filtro As New OC.PredicateExpression

            If Not Codigo = -1 Then
                Filtro.Add(HC.MgralcatPuntosEntregaFields.IdPuntoEntrega = Codigo)
            End If

            If Not Descripcion = "" Then
                Filtro.Add(HC.MgralcatPuntosEntregaFields.Descripcion Mod String.Format("%{0}%", Descripcion))
            End If

            coleccion.GetMulti(Filtro)

            Rellenar()

            Return Count
        Catch ex As Exception
            Return -1
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function
End Class