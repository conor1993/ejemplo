Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports ClasesNegocio
Imports EST = ClasesNegocio.AplicacionMedicamentoClass.EstatusAplicacionMedicamento

Public Class frmBusquedaAplicacionMedicamento
    Dim configuracion As EC.ConfigGanEntity
    Private m_AplicacionMedicamento As AplicacionMedicamentoClass

    Public Property AplicacionMedicamento() As AplicacionMedicamentoClass
        Get
            Return Me.m_AplicacionMedicamento
        End Get
        Set(ByVal value As AplicacionMedicamentoClass)
            Me.m_AplicacionMedicamento = value
        End Set
    End Property

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Try
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.dgResultado.SelectedRows.Count > 0 Then
            Me.AplicacionMedicamento = _
                    New AplicacionMedicamentoClass(Me.dgResultado.SelectedRows(0).Cells(Me.FolioAplicacionMedicamentoDataGridViewTextBoxColumn.Index).Value.ToString)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub cmbAlmacen_ActualizarCombo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAlmacen.ActualizarCombo
        Try
            Me.cmbAlmacen.ValueMember = "AlmacenId"
            Me.cmbAlmacen.DataSource = CC.AlmacenCollection.GetMultiAsDataTable(HC.AlmacenFields.TipoAlmacen = _
                                Me.configuracion.IdTipoAlmacenFormula And _
                                HC.AlmacenFields.Estatus = 1, _
                                0, New OC.SortExpression(New OC.SortClause(HC.AlmacenFields.Descripcion, _
                                SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)), Nothing)
            Me.cmbAlmacen.DisplayMember = "Descripcion"
            Me.cmbAlmacen.SelectedIndex = -1
            Me.cmbAlmacen.Text = "Seleccione un almacén"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub frmBusquedaAplicacionFormula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim configuracionEngorda As New CC.ConfigGanCollection

            configuracionEngorda.GetMulti(Nothing, 1)

            If configuracionEngorda.Count = 0 Then
                MsgBox("Primero establesca una configuracón de engorda, Engorda/Configuración", MsgBoxStyle.Exclamation, "Aviso")
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Else
                configuracion = configuracionEngorda(0)
            End If

            Me.cmbAlmacen.OnActualizaCombo()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBuscar
        Try
            Dim filtro As New OC.PredicateExpression
            Dim filtroEstatus As New OC.PredicateExpression

            If Me.txtFolio.Text.Trim.Length > 0 Then
                filtro.Add(HC.VwBusquedaAplicacionMedicamentoFields.FolioAplicacionMedicamento Mod String.Format("%{0}%", Me.txtFolio.Text.Trim))
            Else
                If Me.cmbAlmacen.SelectedIndex > -1 Then
                    filtro.Add(HC.VwBusquedaAplicacionMedicamentoFields.IdAlmacen = CInt(Me.cmbAlmacen.SelectedValue))
                End If

                If Me.chkFiltrar.Checked Then
                    filtro.Add(New OC.FieldBetweenPredicate(HC.VwBusquedaAplicacionMedicamentoFields.FechaAplicacionMedicamento, _
                                Me.dtFechaInicio.Value.ToShortDateString, Me.dtFechaFin.Value.AddDays(1).ToShortDateString))
                End If

                If Me.chkVigente.Checked Then
                    filtroEstatus.Add(HC.VwBusquedaAplicacionMedicamentoFields.Estatus = EST.VIGENTE)
                End If

                If Me.chkContabilizado.Checked Then
                    If filtroEstatus.Count = 0 Then
                        filtroEstatus.Add(HC.VwBusquedaAplicacionMedicamentoFields.Estatus = EST.CONTABILIZADO)
                    Else
                        filtroEstatus.AddWithOr(HC.VwBusquedaAplicacionMedicamentoFields.Estatus = EST.CONTABILIZADO)
                    End If
                End If

                If Me.chkCancelado.Checked Then
                    If filtroEstatus.Count = 0 Then
                        filtroEstatus.Add(HC.VwBusquedaAplicacionMedicamentoFields.Estatus = EST.CANCELADA)
                    Else
                        filtroEstatus.AddWithOr(HC.VwBusquedaAplicacionMedicamentoFields.Estatus = EST.CANCELADA)
                    End If
                End If

                If filtroEstatus.Count > 0 Then
                    filtro.Add(filtroEstatus)
                End If
            End If

            Me.aplicacionesMedicamentos.Clear()
            Me.aplicacionesMedicamentos.Fill(0, Nothing, False, filtro)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub chkFiltrar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFiltrar.CheckedChanged
        Me.dtFechaFin.Value = Now
        Me.dtFechaInicio.Value = Now

        Me.gbRangoFechas.Enabled = Me.chkFiltrar.Checked
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        Try
            Me.txtFolio.Clear()
            Me.cmbAlmacen.SelectedIndex = -1
            Me.txtCodigoAlmacen.Clear()
            Me.chkFiltrar.Checked = False
            Me.chkVigente.Checked = True
            Me.chkCancelado.Checked = True
            Me.chkContabilizado.Checked = True
            Me.aplicacionesMedicamentos.Clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class