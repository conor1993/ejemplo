Imports EC = Integralab.ORM.EntityClasses
Imports ECS = Integralab.ORMSeguridad.EntityClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CC = Integralab.ORM.CollectionClasses

Public Class AsignarPermisoClass
    Inherits ClassBase(Of EC.AutorizaProcesosEntity)

#Region "Miembros"

    Dim _Usuario As UsuarioClass
    Dim _Empresa As EmpresaClass

#End Region

#Region "Constructores"
    Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal entidad As EC.AutorizaProcesosEntity)
        MyBase.New(entidad)
    End Sub

    Sub New(ByVal idEmpresa As Integer, ByVal idUsuario As Integer)
        MyBase.New(New EC.AutorizaProcesosEntity(idEmpresa, idUsuario))
    End Sub
#End Region

#Region "Propiedades"
    Public Property IdEmpresa() As Integer
        Get
            Return Entity.EmpresaId
        End Get
        Set(ByVal value As Integer)
            Entity.EmpresaId = value
        End Set
    End Property

    Public Property IdUsuarioAlta() As Integer
        Get
            Return Entity.Usrndx
        End Get
        Set(ByVal value As Integer)
            Entity.Usrndx = value
        End Set
    End Property

    Public Property IdUsuario() As Integer
        Get
            Return Entity.Usrndx
        End Get
        Set(ByVal value As Integer)
            Entity.Usrndx = value
        End Set
    End Property

    Public ReadOnly Property Usuario() As UsuarioClass
        Get
            If _Usuario Is Nothing OrElse _Usuario.Codigo <> Me.IdUsuario Then
                _Usuario = New UsuarioClass(Me.IdUsuario)
            End If
            Return _Usuario
        End Get
    End Property

    Public ReadOnly Property Empresa() As EmpresaClass
        Get
            If _Empresa Is Nothing OrElse _Empresa.Index <> Me.IdEmpresa Then
                _Empresa = New EmpresaClass(Me.IdEmpresa)
            End If
            Return _Empresa
        End Get
    End Property

    <ComponentModel.DisplayName("Cambiar Precio En Factura")> _
    Public Property CambiarPrecioFacturacion() As Boolean
        Get
            Return Entity.CambiarPrecioFacturacion
        End Get
        Set(ByVal value As Boolean)
            Entity.CambiarPrecioFacturacion = value
        End Set
    End Property

    <ComponentModel.DisplayName("Cancelar Factura")> _
    Public Property CancelarFactura() As Boolean
        Get
            Return Entity.CancelarFactura
        End Get
        Set(ByVal value As Boolean)
            Entity.CancelarFactura = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Shadows Function Guardar() As Boolean
        Entity.Save()
    End Function
#End Region
End Class