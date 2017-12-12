Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports EC = IntegraLab.ORM.EntityClasses

Public Class FrmBusqBalance
    Private Sub FrmBusqBalance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Limpiar()
            Buscar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Limpiar()
        Me.txtIdRubro.Text = ""
        Me.txtDescripcion.Text = ""
        Me.dgvCab.DataSource = Nothing
        Me.DgvDet.DataSource = Nothing
    End Sub

    Private Sub Buscar()
        Try
            Me.BalanceCol.Obtener(Me.txtIdRubro.Text, Me.txtDescripcion.Text)
            Me.dgvCab.AutoGenerateColumns = False
            Me.dgvCab.DataSource = Me.BalanceCol
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvCab_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvCab.Click
        Try
            If Me.dgvCab.SelectedRows.Count > 0 Then
                Dim CveBalance As String = Me.dgvCab.SelectedRows(0).Cells(Me.clmRubro.Index).Value
                Me.BalanceDetC.Obtener(CveBalance)
                Me.DgvDet.AutoGenerateColumns = False
                Me.DgvDet.DataSource = Me.BalanceDetC
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub dgvCab_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvCab.DoubleClick
        If Me.dgvCab.SelectedRows.Count > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub dgvCab_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCab.RowEnter
        Try
            If Me.dgvCab.SelectedRows.Count > 0 Then
                Dim CveBalance As Integer = Me.dgvCab.SelectedRows(0).Cells(Me.clmRubro.Index).Value
                Me.BalanceDetC.Obtener(CveBalance)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If Me.dgvCab.SelectedRows.Count > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub txtIdRubro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIdRubro.KeyPress
        If Me.txtIdRubro.Text.Length > 2 Then
            Buscar()
        End If
    End Sub

    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If Me.txtDescripcion.Text.Length > 4 Then
            Buscar()
        End If
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Buscar()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class