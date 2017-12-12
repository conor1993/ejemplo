Public Class frmBusquedaListaPrecio
    Private _NombreCorto As String
    Private ListaPrecio As New ClasesNegocio.ListaPrecioClass
    Dim plaza As Integer = -1
    Dim codigo As Integer = -1
    Dim condicion As ClasesNegocio.CondicionEnum = ClasesNegocio.CondicionEnum.Todos

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.DataGrid.SelectedRows.Count > 0 Then
            TxtCodigo.Text = DataGrid.CurrentRow.Cells(0).Value.ToString
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub frmBusquedaListaPrecio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PlazaCol.Obtener(ClasesNegocio.CondicionEnum.TODOS)
        Limpiar()
        MEAToolBar1_ClickBuscar(New Object, Nothing, False)
        Application.DoEvents()
        DataGrid.Focus()
    End Sub

    Private Sub DataGrid_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGrid.DataError

    End Sub

    Private Sub MEAToolBar1_ClickBuscar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickBuscar
        Try
            Cursor = Cursors.WaitCursor
            If IsNumeric(TxtCodigo.Text) Then
                Me.ListaPrecioCol.Obtener(Me.TxtDescripcion.Text, Me.TxtDescta.Text, Me.plaza, Me.codigo, Me.condicion)
            Else
                Me.ListaPrecioCol.Obtener(Me.TxtDescripcion.Text, Me.TxtDescta.Text, Me.plaza, , Me.condicion)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub Limpiar()
        cmbPlaza.SelectedIndex = -1
        cmbPlaza.SelectedValue = "Seleccione Plaza"
        TxtCodigo.Clear()
        TxtDescripcion.Clear()
        TxtDescta.Clear()
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub MEAToolBar1_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickImprimir
        Try
            Cursor = Cursors.WaitCursor
            'Dim Previsualizar As New ClasesNegocio.PreVisualizarForm
            'Previsualizar.Text = "Reporte de Listas de Precios"
            'Previsualizar.Reporte = ListaPrecioCol.Rpt
            'Previsualizar.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickSalir
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub TxtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCodigo.TextChanged
        'Para pasar al siguiente control
        'If e.KeyChar = Chr(13) Then
        If IsNumeric(Me.TxtCodigo.Text) Then
            Dim lis As New ClasesNegocio.ListaPrecioClass
            If lis.Obtener(Me.TxtCodigo.Text) Then
                codigo = Me.TxtCodigo.Text
                Me.TxtDescripcion.Focus()
            Else
                MsgBox("No extiste Lista de Precios con ese Codigo", MsgBoxStyle.Exclamation, "Aviso")
                Me.TxtCodigo.Text = ""
            End If
        Else
            codigo = -1
        End If
    End Sub

    Private Sub cmbPlaza_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPlaza.SelectedIndexChanged
        If cmbPlaza.SelectedIndex > -1 Then
            plaza = cmbPlaza.SelectedValue
        Else
            plaza = -1
        End If
    End Sub

    Private Sub DataGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid.DoubleClick
        If Me.DataGrid.SelectedRows.Count > 0 Then
            TxtCodigo.Text = DataGrid.CurrentRow.Cells(0).Value.ToString
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub
End Class