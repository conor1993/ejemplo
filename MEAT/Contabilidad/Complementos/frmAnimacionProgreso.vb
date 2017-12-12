Public Class frmAnimacionProgreso

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.ProgressBar1.Value = Me.ProgressBar1.Maximum Then
            Me.ProgressBar1.Value = 0
        Else
            Me.ProgressBar1.Value += 1
        End If
    End Sub

    Private Sub frmAnimacionProgreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ProgressBar1.Value = 0
    End Sub
End Class