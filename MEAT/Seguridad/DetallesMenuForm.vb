Imports CCS = Integralab.ORMSeguridad.CollectionClasses
Imports ECS = Integralab.ORMSeguridad.EntityClasses
Imports HCS = Integralab.ORMSeguridad.HelperClasses

Public Class DetallesMenuForm

    Dim Menus As New Object 'MenuColeccionClass
    Dim Usuario As ECS.UsuarioEntity
    Dim Grupo As ECS.GruposEntity
    Dim WithEvents detMen As MenusDetallesForm

    Private Sub DetallesMenuForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Usuarios.Fill()
        Grupos.Fill()
        lstUsuarios.SelectedIndex = -1
        lstGrupos.SelectedIndex = -1
        btnMenusUsuario.Enabled = False
        btnMenusGrupo.Enabled = False
    End Sub

    Private Sub lstUsuarios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstUsuarios.SelectedIndexChanged
        If lstUsuarios.SelectedIndex > -1 Then
            Usuario = New ECS.UsuarioEntity(lstUsuarios.SelectedValue)
            btnMenusUsuario.Enabled = True
        Else
            Usuario = Nothing
            btnMenusUsuario.Enabled = False
        End If
    End Sub

    Private Sub lstGrupos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstGrupos.SelectedIndexChanged
        If lstGrupos.SelectedIndex > -1 Then
            Grupo = New ECS.GruposEntity(lstGrupos.SelectedValue)
            btnMenusGrupo.Enabled = True
        Else
            Grupo = Nothing
            btnMenusGrupo.Enabled = False
        End If
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickSalir
        Me.Close()
    End Sub

    Private Sub btnMenusUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenusUsuario.Click
        Try
            detMen = New MenusDetallesForm(Usuario, Me.MdiParent.FindForm)
            detMen.ShowDialog()
            detMen = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnMenusGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenusGrupo.Click
        Try
            detMen = New MenusDetallesForm(Grupo, Me.MdiParent.FindForm.Tag)
            detMen.ShowDialog()
            detMen = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

End Class