Public Class ConfiguracionForm
    Private Sub GuardarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarButton.Click
        Try
            Controlador.Seguridad.GuardarAdmin("sysadmin", PasswordTextBox.Text.Trim)
            MsgBox("Configuracion Guardada.")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Controlador.Sesion.MiEmpresa.Empnom)
        End Try
    End Sub

    Private Sub CancelarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarButton.Click
        Me.Close()
    End Sub
End Class