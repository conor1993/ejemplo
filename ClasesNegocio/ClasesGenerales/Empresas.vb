Imports HCS = Integralab.ORMSeguridad.HelperClasses
Imports ECS = Integralab.ORMSeguridad.EntityClasses
Imports OCS = Integralab.ORMSeguridad.CollectionClasses

Public Class EmpresaClass
    Implements Integra.Clases.IEntidad

    Private empresa As ECS.EmpresasEntity
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements Integra.Clases.IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements Integra.Clases.IEntidad.Modificado

    Sub New()
        empresa = New ECS.EmpresasEntity
    End Sub

    Sub New(ByVal Entidad As ECS.EmpresasEntity)
        empresa = Entidad
    End Sub

    Sub New(ByVal Indice As Integer)
        Dim empresas As New EmpresaCollectionClass
        empresa = empresas.Obtener(Indice).ObtenerEntidad
    End Sub

    Public ReadOnly Property Codigo() As String
        Get
            Return empresa.Empid
        End Get
    End Property

    Public ReadOnly Property CodEmpndx() As Integer
        Get
            Return empresa.Empndx
        End Get
    End Property

    Public ReadOnly Property Index() As Integer
        Get
            Return empresa.Empndx
        End Get
    End Property

    Public Property Nombre() As String
        Get
            Return empresa.Empnom
        End Get
        Set(ByVal value As String)
            empresa.Empnom = value
        End Set
    End Property

    Public Property Domicilio() As String
        Get
            Return empresa.EmpDomicilio
        End Get
        Set(ByVal value As String)
            empresa.EmpDomicilio = value
        End Set
    End Property

    Public Property RFC() As String
        Get
            Return empresa.EmpRfc
        End Get
        Set(ByVal value As String)
            empresa.EmpRfc = value
        End Set
    End Property

    Public Property Catalogo() As String
        Get
            Return empresa.Empcat
        End Get
        Set(ByVal value As String)
            empresa.Empcat = value
        End Set
    End Property

    Public Property Servidor() As String
        Get
            Return empresa.Empsrv
        End Get
        Set(ByVal value As String)
            empresa.Empsrv = value
        End Set
    End Property

    Public Property Usuario() As String
        Get
            Return empresa.Empuser
        End Get
        Set(ByVal value As String)
            empresa.Empuser = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return empresa.Emppass
        End Get
        Set(ByVal value As String)
            empresa.Emppass = value
        End Set
    End Property

    Public Property SeguridadIntegrada() As Boolean
        Get
            Return empresa.Empsi
        End Get
        Set(ByVal value As Boolean)
            empresa.Empsi = value
        End Set
    End Property

    Public ReadOnly Property BDConnectionString() As String
        Get
            Dim Parametros As Object() = {empresa.Empsrv, empresa.Empcat, empresa.Empuser, empresa.Emppass}
            If empresa.Empsi Then
                Return String.Format("Data Source={0}; Initial Catalog={1}; Integrated Security=SSPI; Persist Security Info=False;Packet Size=4096", Parametros)
            Else
                Return String.Format("Data Source={0}; Initial Catalog={1}; User ID={2}; Password={3}; Packet Size=4096", Parametros)
            End If
        End Get
    End Property

    Public Property Estatus() As Integra.Clases.EstatusEnum Implements Integra.Clases.IEntidad.Estatus
        Get
            'Return Integra.Clases.EstatusEnum.Activo
        End Get
        Set(ByVal value As Integra.Clases.EstatusEnum)

        End Set
    End Property

    Public Function Borrar() As Boolean Implements Integra.Clases.IEntidad.Borrar

    End Function

    Public Function Guardar() As Boolean Implements Integra.Clases.IEntidad.Guardar

    End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean Implements Integra.Clases.IEntidad.Obtener
        Return empresa.FetchUsingPK(Codigo)
    End Function

    Public Function ObtenerEntidad() As ECS.EmpresasEntity
        Return empresa
    End Function

    Public Overrides Function ToString() As String
        Return Me.Nombre
    End Function

End Class

Public Class EmpresaCollectionClass
    Inherits System.ComponentModel.BindingList(Of EmpresaClass)

    Public Function Obtener(ByVal Indice As Integer) As EmpresaClass
        Dim c As New OCS.EmpresasCollection
        Dim e As New EmpresaClass
        If c.GetDbCount(HCS.EmpresasFields.Empndx = Indice) > 0 Then
            c.GetMulti(HCS.EmpresasFields.Empndx = Indice)
            e = New EmpresaClass(c(0))
        End If
        Return e
    End Function
End Class