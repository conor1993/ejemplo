Imports Integra.Clases

Public Class FrmBuscarComisionista
    Private Comisionista As New ClasesNegocio.VendedorClass

    Private Sub Buscar()
        If IsNumeric(txtCodigo.Text) Then
            Me.ComisionistaCol.Obtener(txtNombre.Text, txtApePat.Text, txtApeMat.Text, CInt(txtCodigo.Text), Me.cmbEstatus.SelectedValue, Me.txtRFC.Text)
        Else
            Me.ComisionistaCol.Obtener(txtNombre.Text, txtApePat.Text, txtApeMat.Text, , Me.cmbEstatus.SelectedValue, Me.txtRFC.Text)
        End If
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If Not e.KeyChar = Chr(8) Then
            If Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If Me.DataGrid.SelectedRows.Count = 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Else
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub MEAToolBar1_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickBuscar
        Buscar()
    End Sub

    Private Sub MEAToolBar1_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickImprimir
        Try
            Cursor = Cursors.WaitCursor
            Dim ventana As New ClasesNegocio.PreVisualizarForm
            ventana.Text = "Impresión de Vendedor"
            ventana.Reporte = Me.ComisionistaCol.Reporte(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnomcom)
            ventana.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickLimpiar
        Me.txtNombre.Clear()
        Me.txtCodigo.Clear()
        Me.txtApePat.Clear()
        Me.txtApeMat.Clear()
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickSalir
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub FrmBuscarComisionista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cmbEstatus.DataSource = New Integra.Clases.CondicionesClass()
        Me.cmbEstatus.ValueMember = "Condicion"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub DataGrid_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGrid.CellDoubleClick
        If Me.DataGrid.SelectedRows.Count > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub
End Class