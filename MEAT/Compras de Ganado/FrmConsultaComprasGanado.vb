Imports EC = IntegraLab.ORM.EntityClasses
Imports System.Data.SqlClient
Imports ClasesNegocio
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = sd.LLBLGen.Pro.ORMSupportClasses

Public Class FrmConsultaComprasGanado
#Region "Miembros"
    Private compraGanado As ClasesNegocio.CompraGanadoClass
#End Region

#Region "Propiedades"
    Public ReadOnly Property CompraGanadoSeleccionada() As CompraGanadoClass
        Get
            Return compraGanado
        End Get
    End Property
#End Region

#Region "Metodos"
    Private Sub Limpiar()
        Me.cmbProveedor.SelectedIndex = -1
        Me.cmbComprador.SelectedIndex = -1
        Me.cmbCorral.SelectedIndex = -1
        Me.cmbLugarCompra.SelectedIndex = -1
        Me.txtFolioCompra.Clear()
        Me.chkFiltrar.Checked = False
        Me.chkVigentes.Checked = True
        Me.chkCanceladas.Checked = True
        Me.busquedaRecepcionCompras.Clear()
    End Sub

    Private Sub Buscar()
        Dim filtro As New OC.PredicateExpression

        If Me.txtFolioCompra.Text.Trim = "" Then
            If Me.cmbComprador.SelectedIndex > -1 Then _
                        filtro.Add(HC.VwBusquedaComprasdeGanadoFields.IdCompradorGanado = CInt(Me.cmbComprador.SelectedValue))
            If Me.cmbProveedor.SelectedIndex > -1 Then _
                        filtro.Add(HC.VwBusquedaComprasdeGanadoFields.IdProveedor = CInt(Me.cmbProveedor.SelectedValue))
            If Me.cmbLugarCompra.SelectedIndex > -1 Then _
                        filtro.Add(HC.VwBusquedaComprasdeGanadoFields.IdLugarCompra = CInt(Me.cmbLugarCompra.SelectedValue))
            If Me.cmbCorral.SelectedIndex > -1 Then _
                        filtro.Add(HC.VwBusquedaComprasdeGanadoFields.IdCorral = Me.cmbCorral.SelectedValue)
            If Me.chkFiltrar.Checked Then _
                        filtro.Add(New OC.FieldBetweenPredicate(HC.VwBusquedaComprasdeGanadoFields.FechaRecepcionCompra, _
                                    Me.DtpFechaIni.Value.ToShortDateString, Me.DtpFechaFin.Value.AddDays(1).ToShortDateString))

            If Not (Me.chkCanceladas.Checked And Me.chkVigentes.Checked) Then
                If Me.chkCanceladas.Checked Then
                    filtro.Add(HC.VwBusquedaComprasdeGanadoFields.Status = Chr(EstatusChar.CANCELADO))
                Else
                    filtro.Add(HC.VwBusquedaComprasdeGanadoFields.Status = Chr(EstatusChar.VIGENTE))
                End If
            End If
        Else
            filtro.Add(HC.VwBusquedaComprasdeGanadoFields.FolioRecepcionCompra Mod String.Format("%{0}%", Me.txtFolioCompra.Text.Trim))
        End If

        Me.busquedaRecepcionCompras.Clear()
        Me.busquedaRecepcionCompras.Fill(0, Nothing, False, filtro)
    End Sub
#End Region

#Region "Eventos"
#Region "Form"
    Private Sub FrmConsultaComprasGanado_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.cmbProveedor.OnActualizaCombo()
            Me.cmbComprador.OnActualizaCombo()
            Me.cmbCorral.OnActualizaCombo()
            Me.cmbLugarCompra.OnActualizaCombo()
            Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

#Region "ToolBar"
    Private Sub mtb_ClickBuscar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBuscar
        Cursor = Cursors.WaitCursor

        Try
            Buscar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickSalir
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
#End Region

#Region "Buttons"
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.dgvResultados.SelectedRows.Count > 0 Then
            Me.compraGanado = New ClasesNegocio.CompraGanadoClass
            Me.compraGanado.Obtener(Me.dgvResultados.CurrentRow.Cells(Me.FolioRecepcionCompraDataGridViewTextBoxColumn.Index).Value)

            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
#End Region

#Region "DataGrid"
    Private Sub dgvResultados_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvResultados.CellDoubleClick
        If dgvResultados.SelectedRows.Count > 0 Then
            btnAceptar_Click(sender, New EventArgs())
        End If
    End Sub
#End Region

#Region "ComboBox"
    Private Sub cmbProveedor_ActualizarCombo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProveedor.ActualizarCombo
        Try
            Me.cmbProveedor.ValueMember = "Codigo"
            Me.cmbProveedor.DataSource = CC.ProveedorCollection.GetMultiAsDataTable(Nothing, 0, Nothing)
            Me.cmbProveedor.DisplayMember = "RazonSocial"

            Me.cmbProveedor.SelectedIndex = -1
            Me.cmbProveedor.Text = Me.txtCodigoProveedor.MensajeCombo
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub cmbComprador_ActualizarCombo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbComprador.ActualizarCombo
        Try
            Me.CompradoresGanadoC.Obtener(CondicionEnum.TODOS)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub cmbCorral_ActualizarCombo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCorral.ActualizarCombo
        Try
            Me.CorralesColecttionC.Obtener(CondicionEstatusEnum.TODOS)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub cmbLugarCompra_ActualizarCombo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLugarCompra.ActualizarCombo
        Try
            Me.LugaresDeCompraC.Obtener(CondicionEnum.TODOS)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

#Region "CheckBox"
    Private Sub chkFiltrar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFiltrar.CheckedChanged
        If Me.chkFiltrar.Checked Then
            Me.DtpFechaIni.Value = Now
            Me.DtpFechaFin.Value = Now
        End If
    End Sub

    Private Sub chkVigentes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVigentes.CheckedChanged
        If Not Me.chkCanceladas.Checked AndAlso Not Me.chkVigentes.Checked Then
            Me.chkCanceladas.Checked = True
            Me.chkVigentes.Checked = True
        End If
    End Sub

    Private Sub chkCanceladas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCanceladas.CheckedChanged
        If Not Me.chkCanceladas.Checked AndAlso Not Me.chkVigentes.Checked Then
            Me.chkCanceladas.Checked = True
            Me.chkVigentes.Checked = True
        End If
    End Sub
#End Region
#End Region

End Class