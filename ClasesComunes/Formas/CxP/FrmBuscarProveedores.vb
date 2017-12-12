Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports TC = Integralab.ORM.TypedViewClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class FrmBuscarProveedores
    Private proveedor As New ClasesNegocio.ProveedorClass

    Private Sub btnCacnelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCacnelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.DataGrid.SelectedRows.Count = 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Else
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub MEAToolBar1_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickBuscar
        Try
            Dim vista As New TC.VwBusquedaProveedorTypedView
            Dim filtro As New OC.PredicateExpression

            If IsNumeric(Me.txtCodigo.Text) Then
                filtro.Add(HC.VwBusquedaProveedorFields.IdProveedor = CInt(Me.txtCodigo.Text))
            Else
                filtro.Add(HC.VwBusquedaProveedorFields.PrRazSocial Mod String.Format("%{0}%", Me.txtRazonSocial.Text.Trim))
                filtro.Add(HC.VwBusquedaProveedorFields.PrRfc Mod String.Format("%{0}%", Me.txtRfc.Text.Trim))

                If Not (Me.chkInactivo.Checked = Me.chkVigente.Checked) Then
                    If Me.chkVigente.Checked Then
                        filtro.Add(HC.VwBusquedaProveedorFields.PrEstatus = 1)
                    Else
                        filtro.Add(HC.VwBusquedaProveedorFields.PrEstatus = 0)
                    End If
                End If
                If Me.chkDeGando.Checked Then
                    filtro.Add(HC.VwBusquedaProveedorFields.EsdeGanado = 1)
                End If
            End If

            vista.Fill(0, Nothing, True, filtro)

            Me.DataGrid.AutoGenerateColumns = False
            Me.DataGrid.DataSource = vista
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickLimpiar
        Me.txtCodigo.Text = ""
        Me.txtRazonSocial.Text = ""
        Me.txtRfc.Text = ""
        Me.chkVigente.Checked = True
        Me.chkInactivo.Checked = True
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles MEAToolBar1.ClickSalir
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub DataGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid.DoubleClick
        If Me.DataGrid.SelectedRows.Count = 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Else
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub FrmBuscarProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.TiposProveedorC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub chkVigente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVigente.CheckedChanged
        If Not Me.chkInactivo.Checked AndAlso Not Me.chkVigente.Checked Then
            Me.chkVigente.Checked = True
            Me.chkInactivo.Checked = True
        End If
    End Sub
End Class