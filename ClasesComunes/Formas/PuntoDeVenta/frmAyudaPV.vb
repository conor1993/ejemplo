Public Class frmAyudaPV

    Public Sub MySub()
        InitializeComponent()
    End Sub



    Private Sub frmAyudaPV_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape) Then
            DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub
End Class