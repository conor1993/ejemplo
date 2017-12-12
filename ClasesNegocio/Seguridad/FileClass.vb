Imports System
Imports System.Security.Principal
Imports SC = System.Security.Cryptography
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HCS = Integralab.ORMSeguridad.HelperClasses
Imports CCS = Integralab.ORMSeguridad.CollectionClasses
Imports ECS = Integralab.ORMSeguridad.EntityClasses

Public Enum EstatusSeguridadEnum
    ACTIVO = True
    INACTIVO = False
End Enum

Public Class EncriptadorClass

    Private _palabra As String

    Property Palabra() As String
        Get
            Return _palabra
        End Get
        Set(ByVal value As String)
            _palabra = value
            Encriptar()
        End Set
    End Property

    Function Encriptar() As String
        Dim MD5 As New SC.MD5CryptoServiceProvider
        Dim RIPEMD160 As New SC.RIPEMD160Managed
        Dim SHA512 As New SC.SHA512Managed
        Dim SecuenciaBytes As Byte() = System.Text.UnicodeEncoding.UTF32.GetBytes(_palabra.ToCharArray, 0, _palabra.Length - 1)
        SecuenciaBytes = MD5.ComputeHash(SecuenciaBytes)
        SecuenciaBytes = RIPEMD160.ComputeHash(SecuenciaBytes)
        SecuenciaBytes = SHA512.ComputeHash(SecuenciaBytes)
        _palabra = System.Text.UnicodeEncoding.ASCII.GetString(SecuenciaBytes)
        Return _palabra
    End Function

    Function Encriptar(ByVal Palabra As String) As String
        Dim MD5 As New SC.MD5CryptoServiceProvider
        Dim RIPEMD160 As New SC.RIPEMD160Managed
        Dim SHA512 As New SC.SHA512Managed
        Dim SecuenciaBytes As Byte() = System.Text.UnicodeEncoding.UTF32.GetBytes(Palabra.ToCharArray, 0, Palabra.Length - 1)
        SecuenciaBytes = MD5.ComputeHash(SecuenciaBytes)
        SecuenciaBytes = RIPEMD160.ComputeHash(SecuenciaBytes)
        SecuenciaBytes = SHA512.ComputeHash(SecuenciaBytes)
        Return System.Text.UnicodeEncoding.ASCII.GetString(SecuenciaBytes)
    End Function
End Class

Public Class EscritorRegistroClass

    Public Event MensajeError(ByVal Sender As Object, ByVal e As String)
    Structure ConexionStructure
        Dim DataSource As String
        Dim Catalog As String
        Dim SI As Boolean
        Dim UserSQL As String
        Dim PassSQL As String
    End Structure

    Public Function ObtenerRegistroConexion() As ConexionStructure
        Dim CnxStr As New ConexionStructure
        Dim Registro As Microsoft.Win32.RegistryKey = ObtenerRegistro()
        If Not IsNothing(Registro) Then
            CnxStr.DataSource = Registro.GetValue("DATASOURCE", "")
            If CnxStr.DataSource = "" Then
                CnxStr.DataSource = "."
                CnxStr.Catalog = "ILSeguridad"
                CnxStr.SI = True
                CnxStr.UserSQL = ""
                CnxStr.PassSQL = ""
                GrabarRegistroConexion(CnxStr)
            End If
            CnxStr.Catalog = Registro.GetValue("CATALOG", "ILSeguridad")
            CnxStr.SI = Registro.GetValue("SI", True)
            CnxStr.UserSQL = Registro.GetValue("USERSQL", "")
            CnxStr.PassSQL = Registro.GetValue("PASSSQL", "")
        End If
        Return CnxStr
    End Function

    Public Sub GrabarRegistroConexion(ByVal Conexion As ConexionStructure)
        Try
            Dim Registro As Microsoft.Win32.RegistryKey = ObtenerRegistro()
            If Not IsNothing(Registro) Then
                Registro.SetValue("DATASOURCE", Conexion.DataSource)
                Registro.SetValue("CATALOG", Conexion.Catalog)
                Registro.SetValue("SI", Conexion.SI)
                Registro.SetValue("USERSQL", Conexion.UserSQL)
                Registro.SetValue("PASSSQL", Conexion.PassSQL)
            End If
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
        End Try
    End Sub

    Private Function ObtenerRegistro() As Microsoft.Win32.RegistryKey
        Dim registro As Microsoft.Win32.RegistryKey

        Try
            Dim registroS As Microsoft.Win32.RegistryKey = _
                            Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE", _
                            Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree, _
                            Security.AccessControl.RegistryRights.FullControl)

            registro = registroS.OpenSubKey("INTEGRALAB")
            If IsNothing(registro) Then registro = registroS.CreateSubKey("INTEGRALAB")

            registroS = registro
            registro = registroS.OpenSubKey("ILSEGURIDAD")
            If IsNothing(registro) Then registro = registroS.CreateSubKey("ILSEGURIDAD")

            registroS = registro
            registro = registroS.OpenSubKey("CONEXION", _
                        Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree, _
                        Security.AccessControl.RegistryRights.FullControl)
            If IsNothing(registro) Then registro = registroS.CreateSubKey("CONEXION", _
                                        Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree)
        Catch ex As Exception
            registro = Nothing
            RaiseEvent MensajeError(Me, ex.Message)
        End Try
        Return registro
    End Function
End Class

Public Class SesionClass

    Private sesion As ECS.SesionesEntity
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String)

    Public ReadOnly Property Codigo() As Guid
        Get
            Return sesion.Sesid
        End Get
    End Property

    Public ReadOnly Property FechaInicio() As DateTime
        Get
            Return sesion.Sesfecini
        End Get
    End Property

    Public ReadOnly Property FechaFin() As DateTime
        Get
            Return sesion.Sesfecfin
        End Get
    End Property

    Public ReadOnly Property Estatus() As EstatusEnum
        Get
            Return sesion.Sesact
        End Get
    End Property

    Public ReadOnly Property Usuario() As ECS.UsuarioEntity
        Get
            Return sesion.MiUsuario
        End Get
    End Property

    ReadOnly Property Empresa() As ECS.EmpresasEntity
        Get
            Return sesion.MiEmpresa
        End Get
    End Property

    Public ReadOnly Property Grupos() As CCS.GruposCollection
        Get
            Return sesion.MiUsuario.MisGrupos
        End Get
    End Property

    'Public ReadOnly Property Menus() As MenuColeccionClass
    '    Get
    '        _menus.RellenarCollection(sesion.Usuarios.MenusCollectionViaDetallemenususuarios)
    '        Return _menus
    '    End Get
    'End Property

    Sub New(ByVal usuario As ECS.UsuarioEntity, ByVal empresa As ECS.EmpresasEntity)
        If IsNothing(usuario) Or IsNothing(empresa) Then
            RaiseEvent MensajeError(Me, "No se ha especificado que usuario y/o empresa hara el inicio de sesion")
        Else
            Try
                sesion = New ECS.SesionesEntity
                sesion.Sesid = Guid.NewGuid()
                sesion.MiEmpresa = empresa
                sesion.MiUsuario = usuario
                sesion.Empndx = empresa.Empndx
                sesion.Usrndx = usuario.Usrndx
                sesion.Sesact = True
                sesion.Sesfecini = Now
                sesion.Save()
            Catch ex As Exception
                RaiseEvent MensajeError(Me, ex.Message)
            End Try
        End If
    End Sub

    Protected Overrides Sub finalize()
        Try
            sesion.Sesfecfin = Now
            sesion.Sesact = False
            sesion.Save()
            sesion = Nothing
            MyBase.Finalize()
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
        End Try
    End Sub

End Class

Public Class MenuClass

    Private menu As ECS.MenusEntity
    Private m_Hijos As MenuCollectionClass

    ReadOnly Property Codigo() As Integer
        Get
            Return menu.Mnundx
        End Get
    End Property

    Property NombreCorto() As String
        Get
            Return menu.Mnuid
        End Get
        Set(ByVal value As String)
            menu.Mnuid = value
        End Set
    End Property

    Property Nombre() As String
        Get
            Return menu.Mnunom
        End Get
        Set(ByVal value As String)
            menu.Mnunom = value
        End Set
    End Property

    Property Padre() As MenuClass
        Get
            Dim tmp As MenuClass
            If IsNothing(menu.MiPadre) Then 'padre
                tmp = Nothing
            Else
                tmp = New MenuClass(menu.MiPadre) 'padre
            End If
            Return tmp
        End Get
        Set(ByVal value As MenuClass)
            If Not IsNothing(value) Then menu.MiPadre = value.ObtenerEntidad 'padre
        End Set
    End Property

    ReadOnly Property MisMenus() As MenuCollectionClass
        Get
            If Me.m_Hijos Is Nothing Then
                If menu.IsNew Then
                    m_Hijos = New MenuCollectionClass
                Else
                    m_Hijos = New MenuCollectionClass(menu.MisMenus)
                End If
            End If

            Return m_Hijos
        End Get
    End Property

    Property Obligatorio() As Boolean
        Get
            Return menu.Mnuglo
        End Get
        Set(ByVal value As Boolean)
            menu.Mnuglo = value
        End Set
    End Property

    Property Solucion() As String
        Get
            Return menu.Mnusol
        End Get
        Set(ByVal value As String)
            menu.Mnusol = value
        End Set
    End Property

    Sub New()
        menu = New ECS.MenusEntity
        menu.Mnuglo = False
        menu.Mnuid = ""
        menu.Mnunom = ""
        menu.Mnusol = ""
    End Sub

    Sub New(ByVal codigo As Integer)
        menu = New ECS.MenusEntity(codigo)
    End Sub

    Sub New(ByVal Entidad As ECS.MenusEntity)
        menu = Entidad
    End Sub

    Public Sub LeerEntidad(ByVal Entidad As ECS.MenusEntity)
        menu = Entidad
    End Sub

    Public Function ObtenerEntidad() As ECS.MenusEntity
        Return menu
    End Function

    Public Function Guardar() As Boolean
        Try
            Return menu.Save
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
End Class

Public Class MenuCollectionClass
    Inherits System.ComponentModel.BindingList(Of MenuClass)

    Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal Coleccion As CCS.MenusCollection)
        MyBase.New()
        Me.LeerColeccion(Coleccion)
    End Sub

    Public Sub LeerColeccion(ByVal Coleccion As CCS.MenusCollection)
        Me.ClearItems()
        For Each entidad As ECS.MenusEntity In Coleccion
            Dim menu As New MenuClass(entidad)
            Me.Add(menu)
        Next
    End Sub

    Public Function ObtenerColeccion() As CCS.MenusCollection
        Dim tmp As New CCS.MenusCollection
        For Each menu As MenuClass In Me
            tmp.Add(menu.ObtenerEntidad)
        Next
        Return tmp
    End Function

    Public Function Obtener() As Integer
        Dim tmp As New CCS.MenusCollection
        tmp.GetMulti(Nothing)
        LeerColeccion(tmp)
        Return tmp.Count
    End Function

    Public Function Obtener(ByVal Solucion As String) As Integer
        Dim tmp As New CCS.MenusCollection
        tmp.GetMulti(HCS.MenusFields.Mnusol = Solucion And HCS.MenusFields.Mnupad = DBNull.Value)
        LeerColeccion(tmp)
        Return tmp.Count
    End Function

    Public Function Obtener(ByVal usuario As ECS.UsuarioEntity) As Integer
        Dim tmp As New CCS.MenusCollection
        Dim Condicion As New SD.LLBLGen.Pro.ORMSupportClasses.FieldCompareSetPredicate(HCS.MenusFields.Mnundx, HCS.DetallemenususuariosFields.Mnundx, SD.LLBLGen.Pro.ORMSupportClasses.SetOperator.In, HCS.DetallemenususuariosFields.Usrndx = usuario.Usrndx)
        tmp.GetMulti(Condicion)
        LeerColeccion(tmp)
        Return tmp.Count
    End Function

    Public Function Obtener(ByVal grupo As ECS.GruposEntity) As Integer
        Dim tmp As New CCS.MenusCollection
        Dim Condicion As New SD.LLBLGen.Pro.ORMSupportClasses.FieldCompareSetPredicate(HCS.MenusFields.Mnundx, _
                            HCS.DetallemenusgruposFields.Mnundx, SD.LLBLGen.Pro.ORMSupportClasses.SetOperator.In, _
                            HCS.DetallemenusgruposFields.Gpondx = grupo.Gpondx)
        tmp.GetMulti(Condicion)
        LeerColeccion(tmp)
        Return tmp.Count
    End Function

    Public Sub LeerMenuStrip(ByVal MenuPrincipal As Windows.Forms.MenuStrip, ByVal Solucion As String)
        'LeerMenusItems(MenuPrincipal.Items, Nothing, MenuPrincipal.FindForm.Tag.ToString)
        LeerMenusItems(MenuPrincipal.Items, Nothing, Solucion)
    End Sub

    Private Sub LeerMenusItems(ByVal Rama As Windows.Forms.ToolStripItemCollection, ByVal Padre As MenuClass, ByVal Solucion As String)
        For Each hoja As Windows.Forms.ToolStripItem In Rama
            If hoja.GetType Is GetType(Windows.Forms.ToolStripMenuItem) Then
                If hoja.Tag Is Nothing Then hoja.Tag = ""
                If Not hoja.Tag.ToString().Contains("I") Then
                    Dim hojad As Windows.Forms.ToolStripMenuItem = hoja
                    Dim HojaPadre As MenuClass

                    If Padre Is Nothing Then
                        HojaPadre = LeerMenu(hoja, Padre, Solucion)
                    Else
                        HojaPadre = Me.AgregarMenuHijo(hoja, Padre, Solucion)
                    End If
                    LeerMenusItems(hojad.DropDownItems, HojaPadre, Solucion)
                End If
            End If
        Next
    End Sub

    Private Function LeerMenu(ByVal Hoja As Windows.Forms.ToolStripMenuItem, ByVal padre As MenuClass, ByVal Solucion As String) As MenuClass
        Dim menu As New MenuClass

        menu.Nombre = Hoja.Text
        menu.NombreCorto = Hoja.Name
        menu.Obligatorio = False
        menu.Padre = padre
        menu.Solucion = Solucion
        Me.Add(menu)
        Return menu
    End Function

    Private Function AgregarMenuHijo(ByVal Hoja As Windows.Forms.ToolStripMenuItem, ByVal padre As MenuClass, ByVal Solucion As String) As MenuClass
        Dim menu As New MenuClass

        menu.Nombre = Hoja.Text
        menu.NombreCorto = Hoja.Name
        menu.Obligatorio = False
        'menu.Obligatorio = Hoja.Tag.ToString().Contains("O")
        menu.Padre = padre
        menu.Solucion = Solucion
        padre.MisMenus.Add(menu)
        Return menu
    End Function

    Public Function Guardar() As Integer
        Return Me.ObtenerColeccion.SaveMulti()
    End Function

End Class

Public Class MenusDeUsuario

    Private _usuario As ECS.UsuarioEntity

    Sub New(ByVal usuario As ECS.UsuarioEntity)
        _usuario = usuario
    End Sub

    Private _menus As New MenuCollectionClass

    Property Menus() As MenuCollectionClass
        Get
            Return _menus
        End Get
        Set(ByVal value As MenuCollectionClass)
            _menus = value
        End Set
    End Property

    Public Function Guardar() As Integer
        Dim tr As New HCS.Transaction(IsolationLevel.ReadCommitted, "Grabado")
        Try
            Dim tmp As New CCS.DetallemenususuariosCollection
            tr.Add(tmp)
            tmp.GetMulti(HCS.DetallemenususuariosFields.Usrndx = _usuario.Usrndx)
            tr.Add(tmp)
            tmp.DeleteMulti()
            tmp = New CCS.DetallemenususuariosCollection
            For Each menu As MenuClass In _menus
                Dim ent As New ECS.DetallemenususuariosEntity
                ent.Usuario = _usuario
                ent.Menus = menu.ObtenerEntidad
                tmp.Add(ent)
            Next
            tr.Add(tmp)
            Dim i As Integer = tmp.SaveMulti()
            tr.Commit()
            Return i
        Catch ex As Exception
            tr.Rollback()
        End Try
    End Function
End Class

Public Class MenusDeGrupo

    Private _grupo As ECS.GruposEntity

    Sub New(ByVal grupo As ECS.GruposEntity)
        _grupo = grupo
    End Sub

    Private _menus As New MenuCollectionClass

    Property Menus() As MenuCollectionClass
        Get
            Return _menus
        End Get
        Set(ByVal value As MenuCollectionClass)
            _menus = value
        End Set
    End Property

    Public Function Guardar() As Integer
        Dim tr As New HCS.Transaction(IsolationLevel.ReadCommitted, "Grabado")
        Try
            Dim tmp As New CCS.DetallemenusgruposCollection
            tr.Add(tmp)
            tmp.GetMulti(HCS.DetallemenusgruposFields.Gpondx = _grupo.Gpondx)
            tr.Add(tmp)
            tmp.DeleteMulti()
            tmp = New CCS.DetallemenusgruposCollection
            For Each menu As MenuClass In _menus
                Dim ent As New ECS.DetallemenusgruposEntity
                ent.Grupos = _grupo
                ent.Menus = menu.ObtenerEntidad
                tmp.Add(ent)
            Next
            tr.Add(tmp)
            Dim i As Integer = tmp.SaveMulti()
            tr.Commit()
            Return i
        Catch ex As Exception
            tr.Rollback()
        End Try
    End Function
End Class