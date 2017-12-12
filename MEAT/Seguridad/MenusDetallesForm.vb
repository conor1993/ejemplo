Imports CCS = Integralab.ORMSeguridad.CollectionClasses
Imports ECS = Integralab.ORMSeguridad.EntityClasses
Imports HCS = Integralab.ORMSeguridad.HelperClasses
Imports ClasesNegocio

Public Class MenusDetallesForm

    Private usr As ECS.UsuarioEntity
    Private gpo As ECS.GruposEntity
    Private mens As New ClasesNegocio.MenuCollectionClass
    Private menus As New ClasesNegocio.MenuCollectionClass
    Private _Solucion As String

    Property Solucion() As String
        Get
            Return _Solucion
        End Get
        Set(ByVal value As String)
            _Solucion = value
        End Set
    End Property

    Sub New(ByVal usuario As ECS.UsuarioEntity, ByRef FormaPrincipal As Windows.Forms.Form)
        Me.InitializeComponent()
        Me.Owner = FormaPrincipal
        _Solucion = FormaPrincipal.Tag
        usr = usuario
        Me.txtNombre.Text = usr.Usrnomcom
        menus.Obtener(usr)
    End Sub

    Sub New(ByVal grupo As ECS.GruposEntity, ByVal Solucion As String)
        Me.InitializeComponent()
        _Solucion = Solucion
        gpo = grupo
        Me.txtNombre.Text = gpo.Gponom
        menus.Obtener(gpo)
    End Sub

    Private Sub MenusDetallesForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mens.Obtener(_Solucion)
        tvMenus.Menus = New ILTreeViewMenu.MenuCollectionClass(mens.ObtenerColeccion)
        tvMenus.MenusMarcados = New ILTreeViewMenu.MenuCollectionClass(menus.ObtenerColeccion)
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Not IsNothing(usr) Then
            Dim usrMenus As New MenusDeUsuario(usr)
            usrMenus.Menus = New MenuCollectionClass(tvMenus.MenusMarcados.ObtenerColeccion)
            usrMenus.Guardar()

            If Controlador IsNot Nothing AndAlso usr.Usrndx = Controlador.Sesion.MiUsuario.Usrndx AndAlso MsgBox("¿Desea reiniciar la aplicacion para aplicar los cambios?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, Controlador.Sesion.MiUsuario.Usrnomcom) = MsgBoxResult.Yes Then
                CType(Me.Owner, MDIMenuPrincipal).ChecarDerechos(Controlador.Sesion.MiUsuario.Usrndx, 0)
            End If
        Else
            Dim gpoMenus As New MenusDeGrupo(gpo)
            gpoMenus.Menus = New MenuCollectionClass(tvMenus.MenusMarcados.ObtenerColeccion)
            gpoMenus.Guardar()
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class