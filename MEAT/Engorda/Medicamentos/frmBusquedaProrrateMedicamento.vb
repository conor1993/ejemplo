Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports ClasesNegocio
Imports EST = ClasesNegocio.ProrrateoMedicamentoClass.EstatusProrrateoMedicamento

Public Class frmBusquedaProrrateMedicamento
    Dim configuracion As EC.ConfigGanEntity
    Private m_ProrrateoMedicamento As ProrrateoMedicamentoClass

    Public Property ProrrateoMedicamento() As ProrrateoMedicamentoClass
        Get
            Return Me.m_ProrrateoMedicamento
        End Get
        Set(ByVal value As ProrrateoMedicamentoClass)
            Me.m_ProrrateoMedicamento = value
        End Set
    End Property

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

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.dgResultado.SelectedRows.Count > 0 Then
            Me.ProrrateoMedicamento = _
                    New ProrrateoMedicamentoClass(Me.dgResultado.SelectedRows(0).Cells(Me.FolioProrrateoMedicamentoDataGridViewTextBoxColumn.Index).Value.ToString)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Try
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub frmBusquedaProrrateMedicamento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim col As New CC.ConfigGanCollection

            col.GetMulti(Nothing)

            If col.Count = 0 Then
                MsgBox("Debe establecer una configuración de engorda y establecer el tipo de almacén para formulas", MsgBoxStyle.Exclamation, "Aviso")
            Else
                Me.configuracion = col(0)
            End If

            Me.cmbAlmacen.OnActualizaCombo()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBuscar
        Cursor = Cursors.WaitCursor

        Try
            Dim filtro As New OC.PredicateExpression
            Dim filtroEstatus As New OC.PredicateExpression

            If Me.txtFolio.Text.Trim.Length > 0 Then
                filtro.Add(HC.VwBusquedaProrrateoMedicamentoFields.FolioProrrateoMedicamento Mod String.Format("%{0}%", Me.txtFolio.Text.Trim))
            Else
                If Me.cmbAlmacen.SelectedIndex > -1 Then
                    filtro.Add(HC.VwBusquedaProrrateoMedicamentoFields.IdAlmacen = CInt(Me.cmbAlmacen.SelectedValue))
                End If

                If Me.chkFiltrar.Checked Then
                    filtro.Add(New OC.FieldBetweenPredicate(HC.VwBusquedaProrrateoMedicamentoFields.FechaProrrateo, _
                                Me.dtFechaInicio.Value.ToShortDateString, Me.dtFechaFin.Value.AddDays(1).ToShortDateString))
                End If

                If Me.chkVigente.Checked Then
                    filtroEstatus.Add(HC.VwBusquedaProrrateoMedicamentoFields.Estatus = EST.VIGENTE)
                End If

                If Me.chkContabilizado.Checked Then
                    If filtroEstatus.Count = 0 Then
                        filtroEstatus.Add(HC.VwBusquedaProrrateoMedicamentoFields.Estatus = EST.CONTABILIZADO)
                    Else
                        filtroEstatus.AddWithOr(HC.VwBusquedaProrrateoMedicamentoFields.Estatus = EST.CONTABILIZADO)
                    End If
                End If

                If Me.chkCancelado.Checked Then
                    If filtroEstatus.Count = 0 Then
                        filtroEstatus.Add(HC.VwBusquedaProrrateoMedicamentoFields.Estatus = EST.CANCELADO)
                    Else
                        filtroEstatus.AddWithOr(HC.VwBusquedaProrrateoMedicamentoFields.Estatus = EST.CANCELADO)
                    End If
                End If

                If filtroEstatus.Count > 0 Then
                    filtro.Add(filtroEstatus)
                End If
            End If

            Me.vwBusquedaProrrateo.Clear()
            Me.vwBusquedaProrrateo.Fill(0, Nothing, False, filtro)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir

    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Try
            Me.cmbAlmacen.SelectedIndex = -1
            Me.cmbAlmacen.Text = "Seleccione un almacén"
            Me.chkFiltrar.Checked = False
            Me.chkVigente.Checked = True
            Me.chkContabilizado.Checked = True
            Me.chkCancelado.Checked = True
            Me.txtFolio.Clear()
            Me.txtCodigoAlmacen.Clear()
            Me.vwBusquedaProrrateo.Clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub
End Class