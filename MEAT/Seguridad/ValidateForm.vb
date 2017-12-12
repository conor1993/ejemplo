Imports CCS = Integralab.ORMSeguridad.CollectionClasses
Imports ECS = Integralab.ORMSeguridad.EntityClasses
Imports HCS = Integralab.ORMSeguridad.HelperClasses
Imports ClasesNegocio

Public Class ValidateForm

    Private usuario As New ECS.UsuarioEntity
    Private _grupos As New CCS.GruposCollection

    ReadOnly Property Grupos() As CCS.GruposCollection
        Get
            Return (_grupos)
        End Get
    End Property

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Dim _usrs As New CCS.UsuarioCollection
        'se busca a un usuario por el nombre de usuario
        If _usrs.GetDbCount(HCS.UsuarioFields.Usrid = UsernameTextBox.Text) > 0 Then
            _usrs.GetMulti(HCS.UsuarioFields.Usrid = UsernameTextBox.Text)
            usuario = _usrs(0)

            Dim Encriptador As New EncriptadorClass

            'se verifica el password es correcto
            If usuario.Usrpas = Encriptador.Encriptar(PasswordTextBox.Text) Then
                _grupos.GetMultiManyToManyUsingMisUsuarios(usuario)
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            Else
                MsgBox("contraseña no valida")
            End If
        Else
            MsgBox("usuario no valido")
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub ValidateForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
