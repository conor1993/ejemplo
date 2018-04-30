Imports CN = ClasesNegocio
Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CC = Integralab.ORM.CollectionClasses

Public Class DomicilioClienteClass
    Inherits ClassBase(Of EC.MfacClientesDatosFiscalesEntity)

#Region "Miembros"
    Private _Estado As EstadoClass
    Private _Ciudad As CiudadClass
    Private _Poblacion As PoblacionClass
    Private _Cliente As ClientesIntroductoresClass
#End Region

#Region "Constructores"
    Sub New()
        Me.Entity = New EC.MfacClientesDatosFiscalesEntity
    End Sub

    Sub New(ByVal Entidad As EC.MfacClientesDatosFiscalesEntity)
        Me.Entity = Entidad
    End Sub

    Sub New(ByVal IdCliente As Integer, ByVal IdRenglon As Integer)
        Me.Entity = New EC.MfacClientesDatosFiscalesEntity(IdCliente, IdRenglon)
    End Sub

    'Funcion que me valida la forma de un email
    Private Function ValidateEmail(ByVal email As String) As Boolean
        Dim emailRegex As _
            New System.Text.RegularExpressions.Regex( _
            "^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As _
            System.Text.RegularExpressions.Match = emailRegex.Match(email)
        Return emailMatch.Success
    End Function

    'Sub New(ByVal IdPoblacion As Integer, ByVal Colonia As String, ByVal Domicilio As String, ByVal CodigoPostal As String, ByVal Telefono As String, ByVal Celular As String, ByVal Fax As String, ByVal Email As String)
    '    validarDomicilio(IdPoblacion, Colonia, Domicilio, Email)

    '    Me.IdPoblacion = IdPoblacion
    '    Me.Colonia = Colonia
    '    Me.Domicilio = Domicilio
    '    Me.CodigPostal = CodigoPostal
    '    Me.Telefono1 = Telefono
    '    Me.Celular = Celular
    '    Me.Fax = Fax
    '    Me.Email = Email
    'End Sub

    Sub New(ByVal IdEstado As Integer, ByVal IdCiudad As Integer, ByVal IdPoblacion As Integer, ByVal Colonia As String, ByVal Calle As String, ByVal NoExt As String, ByVal NoInt As String, ByVal CodigoPostal As String, ByVal Telefono As String, ByVal Celular As String, ByVal Fax As String, ByVal Email As String)
        validarDomicilio(IdEstado, IdCiudad, IdPoblacion, Colonia, Calle, NoExt, NoInt, Email)
        Me.IdEstado = IdEstado
        Me.IdCiudad = IdCiudad
        Me.IdPoblacion = IdPoblacion
        Me.Colonia = Colonia
        Me.Calle = Calle
        Me.NoExt = NoExt
        Me.NoInt = NoInt
        Me.Domicilio = Calle + " " + NoExt + " " + NoInt
        Me.CodigPostal = CodigoPostal
        Me.Telefono1 = Telefono
        Me.Celular = Celular
        Me.Fax = Fax
        Me.Email = Email
    End Sub


    Sub New(ByVal IdEstado As Integer, ByVal IdCiudad As Integer, ByVal IdPoblacion As Integer, ByVal Colonia As String, ByVal Calle As String, ByVal NoExt As String, ByVal NoInt As String, ByVal CodigoPostal As String, ByVal Telefono As String, ByVal Celular As String, ByVal Fax As String, ByVal Email As String, ByVal IdDepartamento As Integer)
        validarDomicilio(IdEstado, IdCiudad, IdPoblacion, Colonia, Calle, NoExt, NoInt, Email)
        Me.IdEstado = IdEstado
        Me.IdCiudad = IdCiudad
        Me.IdPoblacion = IdPoblacion
        Me.Colonia = Colonia
        Me.Calle = Calle
        Me.NoExt = NoExt
        Me.NoInt = NoInt
        Me.Domicilio = Calle + " " + NoExt + " " + NoInt
        Me.CodigPostal = CodigoPostal
        Me.Telefono1 = Telefono
        Me.Celular = Celular
        Me.Fax = Fax
        Me.Email = Email
        Me.IdDepartamento = IdDepartamento
    End Sub
#End Region

#Region "Propiedades"
    Public Property IdCliente() As Integer
        Get
            Return Entity.IdCliente
        End Get
        Set(ByVal value As Integer)
            Entity.IdCliente = value
        End Set
    End Property

    Public Property IdRenglon() As Integer
        Get
            Return Entity.IdRenglon
        End Get
        Set(ByVal value As Integer)
            Entity.IdRenglon = value
        End Set
    End Property

    Public Property Calle() As String
        Get
            Return Entity.Calle
        End Get
        Set(ByVal value As String)
            Entity.Calle = value
            Entity.Domicilio = (Entity.Calle.Trim + " " + Entity.NoExt.Trim + " " + Entity.NoInt.Trim).Trim
        End Set
    End Property

    Public Property NoExt() As String
        Get
            Return Entity.NoExt
        End Get
        Set(ByVal value As String)
            Entity.NoExt = value
            Entity.Domicilio = (Entity.Calle.Trim + " " + Entity.NoExt.Trim + " " + Entity.NoInt.Trim).Trim
        End Set
    End Property

    Public Property NoInt() As String
        Get
            Return Entity.NoInt
        End Get
        Set(ByVal value As String)
            Entity.NoInt = value
            Entity.Domicilio = (Entity.Calle.Trim + " " + Entity.NoExt.Trim + " " + Entity.NoInt.Trim).Trim
        End Set
    End Property

    Public Property Domicilio() As String
        Get
            'Entity.Domicilio = (Entity.Calle.Trim + " " + Entity.NoExt.Trim + " " + Entity.NoInt.Trim).Trim
            Return Entity.Domicilio
        End Get
        Set(ByVal value As String)
            Entity.Domicilio = value
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

    Public Property CodigPostal() As String
        Get
            Return Entity.CodigoPostal
        End Get
        Set(ByVal value As String)
            Entity.CodigoPostal = value
        End Set
    End Property

    Public Property Telefono1() As String
        Get
            Return Entity.Telefono1
        End Get
        Set(ByVal value As String)
            Entity.Telefono1 = value
        End Set
    End Property

    Public Property Celular() As String
        Get
            Return Entity.Celular
        End Get
        Set(ByVal value As String)
            Entity.Celular = value
        End Set
    End Property

    Public Property Fax() As String
        Get
            Return Entity.Fax
        End Get
        Set(ByVal value As String)
            Entity.Fax = value
        End Set
    End Property

    Public Property Email() As String
        Get
            Return Entity.Email
        End Get
        Set(ByVal value As String)
            Entity.Email = value
        End Set
    End Property

    Public Property EsPrincipal() As Boolean
        Get
            Return Entity.EsPrincipal
        End Get
        Set(ByVal value As Boolean)
            Entity.EsPrincipal = value
        End Set
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

            'If value Is Nothing Then
            '    Entity.Poblacion = Nothing
            'Else
            '    Entity.Poblacion = value.ObtenerEntidad()
            'End If
        End Set
    End Property



    Public ReadOnly Property Ciudad() As CiudadClass
        Get
            If _Ciudad Is Nothing Then
                _Ciudad = New CiudadClass(Entity.IdEstado, Entity.IdCiudad)
            End If
            Return _Ciudad
        End Get
    End Property

    Public ReadOnly Property Estado() As EstadoClass
        Get
            If _Estado Is Nothing Then
                _Estado = New EstadoClass(Ciudad.ObtenerEntidad.Estado)
            End If
            Return _Estado
        End Get
    End Property

    Public ReadOnly Property Cliente() As ClientesIntroductoresClass
        Get
            If _Cliente Is Nothing Then
                _Cliente = New ClientesIntroductoresClass(Me.IdCliente)
            End If
            Return _Cliente
        End Get
    End Property

    Public Property IdDepartamento() As Integer
        Get
            Return Entity.IdDepartamento
        End Get
        Set(ByVal value As Integer)
            Entity.Email = value
        End Set
    End Property
#End Region




#Region "Metodos"
    Public Shadows Sub Guardar(ByVal Trans As HC.Transaction)
        Trans.Add(Entity)
        Entity.Save()
    End Sub

    Public Function Obtener(ByVal IdCliente As Integer, ByVal IdRenglon As Integer) As Boolean
        Try
            Return Me.Entity.FetchUsingPK(IdCliente, IdRenglon)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Sub validarDomicilio(ByVal IdEstado As Integer, ByVal IdCiudad As Integer, ByVal IdPoblacion As Integer, ByVal Colonia As String, ByVal Calle As String, ByVal NoExt As String, ByVal NoInt As String, ByVal Email As String)
        Dim Mensaje As New System.Text.StringBuilder()

        'If Domicilio.Trim = String.Empty Then
        '    Mensaje.AppendLine("Domicilio")
        'End If

        If Calle.Trim = String.Empty Then
            Mensaje.AppendLine("Calle")
        End If

        If NoExt.Trim = String.Empty Then
            Mensaje.AppendLine("Numero exterior")
        End If

        If Colonia.Trim = String.Empty Then
            Mensaje.AppendLine("Colonia")
        End If

        If New EC.PoblacionEntity(IdEstado, IdCiudad, IdPoblacion).IsNew Then
            Mensaje.AppendLine("Poblacion")
        End If

        If Email <> String.Empty AndAlso Not ValidateEmail(Email) Then
            Mensaje.AppendLine("Email (cuenta@dominio.com)")
        End If

        If Mensaje.ToString() <> String.Empty Then
            'Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.CATALOGO_CLIENTES, 1, Mensaje.ToString())
            Throw New Exception("Deben llenarse los siguientes campos: " + Mensaje.ToString())
        End If
    End Sub
#End Region

End Class

Public Class DomicilioClienteColeccionClass
    Inherits ColleccionBase(Of EC.MfacClientesDatosFiscalesEntity, CC.MfacClientesDatosFiscalesCollection, DomicilioClienteClass)

#Region "Contructores"
    Sub New()

    End Sub

    Sub New(ByVal DomiciliosFiscales As CC.MfacClientesDatosFiscalesCollection)
        Me.RellenarMe(DomiciliosFiscales)
    End Sub
#End Region
End Class
