Public Class FrmConsultaCortes
    Private Sub dgvCortes_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCortes.CellDoubleClick
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class