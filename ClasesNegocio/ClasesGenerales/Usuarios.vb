Imports ECS = Integralab.ORMSeguridad.EntityClasses
Imports OCS = Integralab.ORMSeguridad.CollectionClasses
Imports HCS = Integralab.ORMSeguridad.HelperClasses

Public Class UsuarioClass
    Inherits ClassBase(Of ECS.UsuarioEntity)

    Sub New()
        Entity = New ECS.UsuarioEntity
    End Sub

    Sub New(ByVal Entidad As ECS.UsuarioEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal Codigo As Integer)
        Entity = New ECS.UsuarioEntity(Codigo)
    End Sub

    Public Property ApellidoMaterno() As String
        Get
            Return Entity.Usrapm
        End Get
        Set(ByVal value As String)
            Entity.Usrapm = value
        End Set
    End Property

    Public Property ApellidoPaterno() As String
        Get
            Return Entity.Usrapp
        End Get
        Set(ByVal value As String)
            Entity.Usrapp = value
        End Set
    End Property

    Public Property Ciudad() As String
        Get
            Return Entity.Usrgracd
        End Get
        Set(ByVal value As String)
            Entity.Usrgracd = value
        End Set
    End Property

    Public Property Colonia() As String
        Get
            Return Entity.Usrgracol
        End Get
        Set(ByVal value As String)
            Entity.Usrgracol = value
        End Set
    End Property

    Public Property CodigoPostal() As String
        Get
            Return Entity.Usrgracp
        End Get
        Set(ByVal value As String)
            Entity.Usrgracp = value
        End Set
    End Property
    Public Property Domicilio() As String
        Get
            Return Entity.Usrgradom
        End Get
        Set(ByVal value As String)
            Entity.Usrgradom = value
        End Set
    End Property

    Public Property Estado() As String
        Get
            Return Entity.Usrgraedo
        End Get
        Set(ByVal value As String)
            Entity.Usrgraedo = value
        End Set
    End Property

    Public Property Telefono1() As String
        Get
            Return Entity.Usrgrate1
        End Get
        Set(ByVal value As String)
            Entity.Usrgrate1 = value
        End Set
    End Property

    Public Property Telefono2() As String
        Get
            Return Entity.Usrgrate2
        End Get
        Set(ByVal value As String)
            Entity.Usrgrate2 = value
        End Set
    End Property

    Public Property UserName() As String
        Get
            Return Me.Entity.Usrid
        End Get
        Set(ByVal value As String)
            Entity.Usrid = value
        End Set
    End Property

    Public Property FechaNacimiento() As Date
        Get
            Return Entity.Usrnac
        End Get
        Set(ByVal value As Date)
            Entity.Usrnac = value
        End Set
    End Property

    Public Property Codigo() As Integer
        Get
            Return Entity.Usrndx
        End Get
        Set(ByVal value As Integer)
            Entity.Usrndx = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return Entity.Usrnom
        End Get
        Set(ByVal value As String)
            Entity.Usrnom = value
        End Set
    End Property

    Public Property NombreCompleto() As String
        Get
            Return Entity.Usrnomcom
        End Get
        Set(ByVal value As String)
            Entity.Usrnomcom = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return Entity.Usrpas
        End Get
        Set(ByVal value As String)
            Entity.Usrpas = value
        End Set
    End Property

    Public Property RFC() As String
        Get
            Return Entity.Usrrfc
        End Get
        Set(ByVal value As String)
            Entity.Usrrfc = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Me.NombreCompleto
    End Function

    Public Function ObtenerEntidad() As ECS.UsuarioEntity
        Return Entity
    End Function

    Public Function AsociarSucursal(ByVal Sucursal As SucursalClass) As Boolean
        'If usuario.Sucursal.Count = 0 Then
        '    Dim ususuc As New Integralab.ORM.EntityClasses.UsuarioEntity
        '    ususuc.Usrndx = Sucursal.ObtenerEntidad
        '    ususuc.Usrndx = usuario.Usrndx
        '    usuario.Sucursal.SaveMulti()
        '    Return True
        'Else
        '    Return False
        'End If
    End Function

    Public Function DesasociarSucursal(ByVal Sucursal As SucursalClass) As Boolean
        'If usuario.Sucursal.Count > 0 Then
        '    If usuario.Sucursal(0).Codigo = Sucursal.Codigo Then
        '        Dim ususuc As Integralab.ORM.EntityClasses.UsuarioSucursalEntity = usuario.Sucursal
        '        ususuc.Delete()
        '        Return True
        '    End If
        '    Return False
        'Else
        '    Return False
        'End If
    End Function

End Class

Public Class UsuariosColeccionClass
    Inherits ColleccionBase(Of ECS.UsuarioEntity, OCS.UsuarioCollection, UsuarioClass)

End Class
