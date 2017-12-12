Imports HC = IntegraLab.ORM.HelperClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports ClasesNegocio

Public Class _660ReportedeCortes

    Private Sub _660ReportedeCortes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Icon = MdiParent.Icon
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            MtbEstados.StateBuscar = "110101111"
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = "100100011"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "100100011"
            MtbEstados.StateBorrar = "100100011"
            MtbEstados.StateEditar = "001010001"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""

            mtb.ToolBarButtonStatus = MtbEstados

            mtb.sbCambiarEstadoBotones("buscar")

            Controlador.LlenarComboAlmacenesDeProduccion(ultcmbAlmacen)
            Dim AlmacenTodos As New AlmacenClass
            AlmacenTodos.Descripcion = "TODOS"
            CType(ultcmbAlmacen.DataSource, AlmacenCollectionClass).Insert(0, AlmacenTodos)

            Limpiar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Limpiar()
        Me.txtFolioSacrificio.Text = ""
        Me.DtpFechaInicio.Value = Now
        Me.DtpFechaFinal.Value = Now
        ultcmbAlmacen.SelectedIndex = 0
        Me.dgvDetalleCortes.DataSource = Nothing
        Me.dgvRegistroCortes.DataSource = Nothing
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try

            'detalle de los lotes de cortes producidos
            Dim Filtro As New OC.PredicateExpression

            If txtLoteCorte1.Text.Trim <> String.Empty Then
                Filtro.Add(HC.VwProdCortesAgrupadosFields.LoteCorte = txtLoteCorte1.Text)
            ElseIf Me.txtFolioSacrificio.Text <> "" Then
                Filtro.Add(HC.VwProdCortesAgrupadosFields.LoteSacrificio = Me.txtFolioSacrificio.Text)
            ElseIf (chkRangodeFechas.Checked) Then
                Filtro.Add(New OC.FieldBetweenPredicate(HC.VwProdCortesAgrupadosFields.FechaCorte, Me.DtpFechaInicio.Value.ToShortDateString, Me.DtpFechaFinal.Value.AddDays(1).ToShortDateString))
            End If


            Dim VistaCortes As New TC.VwProdCortesAgrupadosTypedView
            VistaCortes.Fill(0, Nothing, True, Filtro)

            If VistaCortes.Rows.Count = 0 Then
                MsgBox("No existe información para este rango de fechas del " & Me.DtpFechaInicio.Value & " al " & Me.DtpFechaFinal.Value, MsgBoxStyle.Information, "")
                Exit Sub
            End If

            Me.dgvRegistroCortes.AutoGenerateColumns = False
            Me.dgvRegistroCortes.DataSource = VistaCortes
            Me.dgvRegistroCortes.ReadOnly = True

            'detalle del primer lote de corte 
            'Me.txtLoteCorte.Text = Me.dgvRegistroCortes.CurrentRow.Cells(Me.cLotedeCorte.Index).Value
            Me.txtFechaCorte.Text = Me.dgvRegistroCortes.CurrentRow.Cells(Me.FechaCorte.Index).Value
            Me.lblEstatus.Text = Me.dgvRegistroCortes.CurrentRow.Cells(Me.Estatus.Index).Value
            Me.txtCajasCanceladas.Text = Me.dgvRegistroCortes.CurrentRow.Cells(Me.CajasCanceladas.Index).Value
            Me.txtCajasEmbarcadas.Text = Me.dgvRegistroCortes.CurrentRow.Cells(Me.CajasEmbarcadas.Index).Value
            Me.txtCajasExistentes.Text = Me.dgvRegistroCortes.CurrentRow.Cells(Me.CajasExistentes.Index).Value
            Me.txtCajasProducidas.Text = Me.dgvRegistroCortes.CurrentRow.Cells(Me.CajasExistentes.Index).Value

            Dim FiltroDet As New OC.PredicateExpression

            If Me.txtLoteCorte1.Text.Trim <> "" Then
                FiltroDet.Add(HC.VwProdCortesFields.LoteCorte = Me.txtLoteCorte1.Text)
            End If

            If Me.ultcmbAlmacen.Value IsNot Nothing AndAlso Me.ultcmbAlmacen.Value <> 0 Then
                FiltroDet.Add(HC.VwProdCortesFields.IdAlmacenActual = Me.ultcmbAlmacen.Value)
            End If

            Dim VistaCortesDetalle As New TC.VwProdCortesTypedView
            VistaCortesDetalle.Fill(0, Nothing, True, FiltroDet)

            Me.dgvDetalleCortes.AutoGenerateColumns = False
            Me.dgvDetalleCortes.DataSource = VistaCortesDetalle
            Me.dgvDetalleCortes.ReadOnly = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvRegistroCortes_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRegistroCortes.RowEnter
        Try
            If Me.dgvRegistroCortes.SelectedRows.Count > 0 Then
                Dim Filtro As New OC.PredicateExpression

                Me.txtLoteCorte.Text = Me.dgvRegistroCortes.SelectedRows(0).Cells(Me.LoteCorte.Index).Value
                Me.txtFechaCorte.Text = Me.dgvRegistroCortes.SelectedRows(0).Cells(Me.FechaCorte.Index).Value
                Me.lblEstatus.Text = Me.dgvRegistroCortes.CurrentRow.Cells(Me.Estatus.Index).Value
                Me.txtCajasCanceladas.Text = Me.dgvRegistroCortes.SelectedRows(0).Cells(Me.CajasCanceladas.Index).Value
                Me.txtCajasEmbarcadas.Text = Me.dgvRegistroCortes.SelectedRows(0).Cells(Me.CajasEmbarcadas.Index).Value
                Me.txtCajasExistentes.Text = Me.dgvRegistroCortes.SelectedRows(0).Cells(Me.CajasExistentes.Index).Value
                Me.txtCajasProducidas.Text = Me.dgvRegistroCortes.SelectedRows(0).Cells(Me.CajasExistentes.Index).Value

                If Me.txtLoteCorte.Text <> "" Then
                    Filtro.Add(HC.VwProdCortesFields.LoteCorte = Me.txtLoteCorte.Text)
                End If

                Dim VistaCortes As New TC.VwProdCortesTypedView
                VistaCortes.Fill(0, Nothing, True, Filtro)

                Me.dgvDetalleCortes.AutoGenerateColumns = False
                Me.dgvDetalleCortes.DataSource = VistaCortes
                Me.dgvDetalleCortes.ReadOnly = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try
            Dim Filtro As New OC.PredicateExpression, VistaCortes As New TC.VwProdCortesTypedView
            Dim Orden As New OC.SortExpression(New OC.SortClause(HC.VwProdCortesFields.FechaCorte, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))

            'si tiene lote de corte
            If Me.txtLoteCorte1.Text <> "" Then
                Filtro.Add(HC.VwProdCortesFields.LoteCorte = Me.txtLoteCorte1.Text)
            End If

            'si solo es un corte vigente
            If Me.chkCorteEspecifico.Checked And Me.txtCodigoCorte.Text <> "" Then
                Filtro.Add(HC.VwProdCortesFields.CodCorte = Me.txtCodigoCorte.Text)
            End If

            'si son todos
            If Me.chkTodos.Checked Then
                'Filtro.Add(HC.VwProdCortesFields.Estatus = "EMBARCADA" Or (HC.VwProdCortesFields.Estatus = "VIGENTE" And HC.VwProdCortesFields.IdFolioEmbarque = ""))
            End If
            'si solo son cortes embarcados
            If Me.chkEmbarcados.Checked Then
                Filtro.Add(HC.VwProdCortesFields.Estatus = "EMBARCADA")
            End If

            'si solo son cortes vigentes
            If Me.chkVigentes.Checked Then
                Filtro.Add(HC.VwProdCortesFields.Estatus = "VIGENTE" And HC.VwProdCortesFields.IdFolioEmbarque = "")
            End If

            'con rango de fechas
            If Me.chkRangodeFechas.Checked Then
                Filtro.Add(New OC.FieldBetweenPredicate(HC.VwProdCortesFields.FechaCorte, Me.DtpFechaInicio.Value.ToShortDateString, Me.DtpFechaFinal.Value.AddDays(1).ToShortDateString))
            End If

            If Me.ultcmbAlmacen.Value IsNot Nothing AndAlso Me.ultcmbAlmacen.Value <> 0 Then
                Filtro.Add(HC.VwProdCortesFields.IdAlmacenActual = Me.ultcmbAlmacen.Value)
            End If

            VistaCortes.Fill(0, Orden, True, Filtro)

            If VistaCortes.Rows.Count = 0 Then
                MsgBox("No existe información en el criterio especificado", MsgBoxStyle.Information, "")
                Exit Sub
            End If

            Me.dgvDetalleCortes.AutoGenerateColumns = False
            Me.dgvDetalleCortes.DataSource = VistaCortes
            Me.dgvDetalleCortes.ReadOnly = True

            If Me.optdetallecortes.Checked OrElse Me.optConcentradodeCortes.Checked Then
                Dim Reporte As New RptDetalleCortes
                Dim VerReporte As New FrmReportes

                Reporte.SetDataSource(Me.dgvDetalleCortes.DataSource)
                Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
                Reporte.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
                If Me.optConcentradodeCortes.Checked = True Then
                    Reporte.SetParameterValue(2, True)
                Else
                    Reporte.SetParameterValue(2, False)
                End If
                VerReporte.CRV.ReportSource = Reporte
                VerReporte.Show(Me)
            Else
                Dim Reporte As New RptDetalleCortesPorLotedeCorte
                Dim VerReporte As New FrmReportes

                Reporte.SetDataSource(Me.dgvDetalleCortes.DataSource)
                Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
                Reporte.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
                VerReporte.CRV.ReportSource = Reporte
                VerReporte.Show(Me)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub optDetallado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.txtCodigoCorte.Enabled = False
        Me.chkCorteEspecifico.Enabled = False
    End Sub

    Private Sub txtCodigoCorte_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoCorte.KeyDown
        If e.KeyCode = Keys.F3 Then
            Dim Ventana As New FrmBusquedaCortesEmbarque ' se abre la ventana de busqueda de productos 

            Ventana.Cortes = True   ' se le especifica a la ventana de busqueda que se van a buscar productos que sean cortes

            If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtCorte.Text = Ventana.DgvCortes.CurrentRow.Cells(Ventana.ClmDescripcion.Index).Value
                Me.txtCodigoCorte.Text = Microsoft.VisualBasic.Right("000" + CStr(Ventana.DgvCortes.CurrentRow.Cells(Ventana.ClmCodigo.Index).Value), 3)
            End If
        End If
    End Sub

    Private Sub optdetallecortes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optdetallecortes.CheckedChanged
        Me.chkCorteEspecifico.Enabled = True
    End Sub

    Private Sub optTotalesGenerales_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.txtCodigoCorte.Enabled = False
        Me.chkCorteEspecifico.Enabled = False
    End Sub

    Private Sub chkCorteEspecifico_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCorteEspecifico.CheckedChanged
        If Me.chkCorteEspecifico.Checked = True Then
            Me.txtCodigoCorte.Enabled = True
        Else
            Me.txtCodigoCorte.Enabled = False
        End If
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub txtLoteCorte1_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtLoteCorte1.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F3 Then
                Dim Ventana As New _960BusquasedaLotesDeCortes

                Ventana.Icon = Me.Icon

                If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.txtLoteCorte1.Text = Ventana.DgvLotes.SelectedRows(0).Cells(Ventana.clmLoteCorte.Index).Value
                Else
                    Exit Sub
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    
    Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodos.CheckedChanged
        If Me.chkTodos.Checked Then
            Me.chkEmbarcados.Checked = False
            Me.chkVigentes.Checked = False
        End If
    End Sub

    Private Sub chkEmbarcados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEmbarcados.CheckedChanged
        If Me.chkEmbarcados.Checked Then
            Me.chkTodos.Checked = False
            Me.chkVigentes.Checked = False
        End If
    End Sub

    Private Sub chkVigentes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVigentes.CheckedChanged
        If Me.chkVigentes.Checked Then
            Me.chkTodos.Checked = False
            Me.chkEmbarcados.Checked = False
        End If
    End Sub

    Private Sub ultcmbAlmacen_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ultcmbAlmacen.Leave
        If ultcmbAlmacen.Value = Nothing Then
            ultcmbAlmacen.SelectedIndex = 0
        End If
    End Sub

End Class