Public Class frmBusquedaEstadoResultado

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir

    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        Me.txtRubro.Clear()
        Me.txtDescripcion.Clear()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub txtRubro_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtRubro.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            Buscar()
        End If
    End Sub

    Private Sub txtRubro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRubro.TextChanged
        Buscar()
    End Sub

    Private Sub Buscar()
        If Me.txtRubro.Text = "" OrElse Microsoft.VisualBasic.Right("000" & txtRubro.Text, 3) = "000" Then
            Me.EstadoResultadoCollectionClas1.Obtener("", Me.txtDescripcion.Text)
        Else
            Me.EstadoResultadoCollectionClas1.Obtener(Microsoft.VisualBasic.Right("000" & txtRubro.Text, 3), Me.txtDescripcion.Text)
        End If
    End Sub

    Private Sub txtDescripcion_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtDescripcion.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            Buscar()
        End If
    End Sub

    Private Sub txtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged
        Buscar()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.dgEstadoResultado.SelectedRows.Count > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub frmBusquedaEstadoResultado_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Buscar()
    End Sub
End Class