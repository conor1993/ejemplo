Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses

Public Class frmReporteTransferenciasCaja

    Private Sub frmReporteTransferenciasCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim rel As New OC.RelationCollection

            rel.Add(New OC.EntityRelation(HC.TipoAlmacenFields.Codigo, HC.AlmacenFields.TipoAlmacen, _
                    SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany))
            Me.AlmacenC.Obtener(HC.TipoAlmacenFields.DeProduccion = 1 And HC.AlmacenFields.Estatus = 1, rel)
            Me.cmbAlmacen.SelectedIndex = -1
            Me.cmbAlmacen.Text = "Seleccione un almacén"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickImprimir
        Try
            Dim col As New CC.MinvTransferenciaAlmacenProdCollection
            Dim filtro As New OC.PredicateExpression
            Dim reporte As New rptTransferenciasCajas
            Dim tb As New dstTransferenciasCajas.TransferenciaCabDataTable
            Dim tbDet As New dstTransferenciasCajas.TransferenciaDetDataTable
            Dim almacen As New EC.AlmacenEntity
            Dim caja As New CC.MscloteCortesDetCollection
            Dim dst As New DataSet

            If Me.txtfolioTrasferencia.Text.Trim = "" Then
                If Me.chkFiltrarFecha.Checked Then
                    filtro.Add(New OC.FieldBetweenPredicate(HC.MinvTransferenciaAlmacenProdFields.FechaMovimiento, Me.dtFechaInicio.Value.Date, Me.dtFechaFinal.Value.Date.AddDays(1).AddTicks(-1)))
                End If

                If Me.cmbAlmacen.SelectedIndex > -1 Then
                    filtro.Add(HC.MinvTransferenciaAlmacenProdFields.IdAlmacenDestino = Me.cmbAlmacen.SelectedValue)
                End If
            Else
                filtro.Add(HC.MinvTransferenciaAlmacenProdFields.FolioTransferencia = Me.txtfolioTrasferencia.Text.Trim)
            End If

            col.GetMulti(filtro)

            For Each ent As EC.MinvTransferenciaAlmacenProdEntity In col
                almacen.FetchUsingPK(ent.IdAlmacenDestino)

                Dim row As dstTransferenciasCajas.TransferenciaCabRow = _
                        tb.AddTransferenciaCabRow(ent.FolioTransferencia, _
                        ent.IdAlmacenDestino, almacen.Descripcion, _
                        ent.Piezas, ent.Kilos, ent.FechaMovimiento, ent.MinvTransferenciaAlmacenProdDetalle.Count)

                For Each det As EC.MinvTransferenciaAlmacenProdDetalleEntity In ent.MinvTransferenciaAlmacenProdDetalle
                    caja.GetMulti(HC.MscloteCortesDetFields.IdFolioEtiqueta = det.FolioEtiqueta.Trim)

                    tbDet.AddTransferenciaDetRow(row, det.FolioEtiqueta, caja(0).CodigoBarra.Trim, _
                                            det.IdProducto, det.MsccatProductos.Descripcion, _
                                            Me.dtFechaFinal.Value.ToShortDateString, _
                                            caja(0).FechaCaducidad.GetValueOrDefault(Me.dtFechaInicio.Value).ToShortDateString, _
                                            det.Piezas, det.Kilos, det.Almacen.Descripcion)
                Next
            Next

            dst.Tables.Add(tb)
            dst.Tables.Add(tbDet)

            reporte.SetDataSource(dst)
            reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)

            Dim ventana As New ClasesNegocio.PreVisualizarForm
            ventana.Reporte = reporte
            ventana.Text = "Reporte de Transferencias de Cajas"
            ventana.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub chkFiltrarFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFiltrarFecha.CheckedChanged
        dtFechaInicio.Enabled = chkFiltrarFecha.Checked
        dtFechaFinal.Enabled = chkFiltrarFecha.Checked
    End Sub
End Class