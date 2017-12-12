Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class frmBusquedaProductos

    Private Sub mtb_ClickBuscar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBuscar
        Dim Filtro As New OC.PredicateExpression

        Try
            Filtro.Add(HC.MsccatProductosFields.Corte = 0 And HC.MsccatProductosFields.PreCorte = 0)
            'Filtro.Add(HC.MsccatProductosFields.SubProducto = True _
            '   Or HC.MsccatProductosFields.ValorAgregado = True Or HC.MsccatProductosFields.Decomisa = True _
            '   Or HC.MsccatProductosFields.Canal = True Or HC.MsccatProductosFields.EsMerma = True Or HC.MsccatProductosFields.EsDerivable = True)

            If Me.txtCodigo.Text = String.Empty Then
                Filtro.Add(HC.MsccatProductosFields.Descripcion Mod String.Format("%{0}%", Me.txtDescripcion.Text))

                If Me.chkActivo.Checked And Not Me.chkInactivo.Checked Then
                    Filtro.Add(HC.MsccatProductosFields.Estatus = ClasesNegocio.CondicionEstatusEnum.ACTIVO)
                ElseIf Not Me.chkActivo.Checked And Me.chkInactivo.Checked Then
                    Filtro.Add(HC.MsccatProductosFields.Estatus = ClasesNegocio.CondicionEstatusEnum.INACTIVO)
                End If
            Else
                Filtro.Add(HC.MsccatProductosFields.IdProducto Mod String.Format("%{0}%", Me.txtCodigo.Text))
            End If

            ProductosC.Obtener(Filtro)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Controlador.Sesion.MiEmpresa.Empnom)
        End Try
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex > -1 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub DataGridView1_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError

    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub Limpiar()
        Me.txtCodigo.Clear()
        Me.txtDescripcion.Clear()
        Me.chkActivo.Checked = True
        Me.chkInactivo.Checked = True
    End Sub

    

    Private Sub chkActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActivo.CheckedChanged
        If Not Me.chkActivo.Checked AndAlso Not Me.chkInactivo.Checked Then
            Me.chkActivo.Checked = True
            Me.chkInactivo.Checked = True
        End If
    End Sub

    Private Sub chkInactivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkInactivo.CheckedChanged
        If Not Me.chkActivo.Checked AndAlso Not Me.chkInactivo.Checked Then
            Me.chkActivo.Checked = True
            Me.chkInactivo.Checked = True
        End If
    End Sub
End Class