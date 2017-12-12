Imports CCS = Integralab.ORMSeguridad.CollectionClasses
Imports ECS = Integralab.ORMSeguridad.EntityClasses
Imports HCS = Integralab.ORMSeguridad.HelperClasses

Public Class frmCambiarPassword
    Private m_Usuario As ECS.UsuarioEntity

    Public Property Usuario() As ECS.UsuarioEntity
        Get
            Return m_Usuario
        End Get
        Set(ByVal value As ECS.UsuarioEntity)
            m_Usuario = value
        End Set
    End Property

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Try
            If PasswordTextBox.Text = RePasswordTextBox.Text Then
                If Me.CambiarContraseña Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    Me.RePasswordTextBox.Clear()
                    Me.PasswordTextBox.Clear()
                    Me.txtContraseñaActual.Clear()
                End If
            Else
                MsgBox("Las contraseñas no coinciden, vuelva a escribirlas.")
                PasswordTextBox.Clear()
                RePasswordTextBox.Clear()
                PasswordTextBox.Focus()
            End If
        Catch ex As Exception
            MsgBox("No se pudo cambiar la contraseña, ocurrio un error", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function CambiarContraseña() As Boolean
        Dim Encriptador As New ClasesNegocio.EncriptadorClass
        If txtContraseñaActual.Text.Length = 0 Then txtContraseñaActual.Text = "."

        'se verifica el password es correcto
        If Usuario.Usrpas = Encriptador.Encriptar(Me.txtContraseñaActual.Text) Then
            If Me.RePasswordTextBox.Text.Trim.Length >= 6 Then
                Usuario.Usrpas = Encriptador.Encriptar(Me.RePasswordTextBox.Text)
                Usuario.Save()
                MsgBox("Se cambio la contraseña", MsgBoxStyle.Information, "Aviso")
                Return True
            Else
                MsgBox("La contraseña debe tener minimo 6 caracteres", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
        Else
            MsgBox("contraseña Actual no válida")
            Return False
        End If
    End Function

    Private Sub miCancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miCancelButton.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class