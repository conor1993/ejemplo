Imports ClasesNegocio
Public Class PasswordForm

    Private WithEvents tmr As New Timer
    Private Encriptador As New EncriptadorClass

    ReadOnly Property Password() As String
        Get
            Return Encriptador.Encriptar(PasswordTextBox.Text)
        End Get
    End Property

    Private Sub PasswordForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tmr.Interval = 10
        tmr.Enabled = True
    End Sub

    Private Sub tmr_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmr.Tick
        If PasswordTextBox.Text.Trim.Length > 5 And RePasswordTextBox.Text.Trim.Length > 5 Then
            OKButton.Enabled = True
        Else
            OKButton.Enabled = False
        End If
    End Sub

    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles miCancelButton.Click
        Me.Close()
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        If PasswordTextBox.Text = RePasswordTextBox.Text Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            MsgBox("Las contraseñas no coinciden, vuelva a escribirlas.")
            PasswordTextBox.Clear()
            RePasswordTextBox.Clear()
            PasswordTextBox.Focus()
        End If
    End Sub
End Class