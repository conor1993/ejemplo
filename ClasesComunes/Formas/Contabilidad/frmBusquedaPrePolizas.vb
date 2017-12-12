Imports ClasesNegocio
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class frmBusquedaPrePolizas
#Region "Miembros"

#End Region

#Region "Metodos"
    Private Sub Limpiar()
        txtCodigo.Text = ""
        txtDescripcion.Text = ""
        chkActivo.Checked = True
        chkInactivo.Checked = True
    End Sub

    Private Function Buscar() As Boolean
        Try
            Dim Filtro As New OC.PredicateExpression
            Dim Coleccion As New CC.PolizasModeloCabCollection()

            If txtCodigo.Text <> String.Empty Then
                Filtro.Add(HC.PolizasModeloCabFields.Codigo Mod String.Format("%{0}%", Me.txtCodigo.Text.Trim))
            Else
                If txtDescripcion.Text <> String.Empty Then
                    Filtro.Add(HC.PolizasModeloCabFields.Descripcion Mod String.Format("%{0}%", Me.txtDescripcion.Text.Trim))
                End If

                If chkActivo.Checked And Not chkInactivo.Checked Then
                    Filtro.Add(HC.PolizasModeloCabFields.Estatus = 1)
                ElseIf chkInactivo.Checked And Not chkActivo.Checked Then
                    Filtro.Add(HC.PolizasModeloCabFields.Estatus = 0)
                End If
            End If
            Coleccion.GetMulti(Filtro, 0, _
                            New OC.SortExpression(New OC.SortClause(HC.PolizasModeloCabFields.Descripcion, _
                            OC.SortOperator.Ascending)))
            dgvPrePolizas.Columns(0).DataPropertyName = "Codigo"
            dgvPrePolizas.DataSource = Coleccion

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub Estatus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActivo.CheckedChanged, chkInactivo.CheckedChanged
        If Not chkActivo.Checked And Not chkInactivo.Checked Then
            chkActivo.Checked = True
            chkInactivo.Checked = True
        End If
    End Sub
#End Region

#Region "Eventos"

#Region "Forma"
    Private Sub frmBusquedaPrePolizas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Buscar()
    End Sub
#End Region

#Region "TextBox Codigo"
    Private Sub txtCodigo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
#End Region

#Region "GridPrePolizas"
    Private Sub dgvPrePolizas_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvPrePolizas.DoubleClick
        If Me.dgvPrePolizas.Rows.Count > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub dgvPrePolizas_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvPrePolizas.CellFormatting
        If dgvPrePolizas.Columns(e.ColumnIndex).Name = "clmEstatus" Then
            If CType(e.Value, Short) = 1 Then
                e.Value = "ACTIVO"
            Else
                e.Value = "INACTIVO"
            End If
        End If
    End Sub
#End Region

#Region "Menu"
    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBuscar
        Cancelar = Not Buscar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub
#End Region

#End Region
End Class