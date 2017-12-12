Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports TC = Integralab.ORM.TypedViewClasses
Imports ClasesNegocio

Public Class frmReporteSalidaMedicamentoAlmacen

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Dim sqlCon As SqlClient.SqlConnection = HC.DbUtils.CreateConnection

        Try
            Dim query As String = _
                        "SELECT		    MInvMovimientosAlmacenDetalles.FolioMovimiento, " & _
                        "               MInvMovimientosAlmacen.FechaMovimiento, " & _
                        "               MInvMovimientosAlmacenDetalles.ProductoId, " & _
                        "               MCatCompProductos.PdDescripcion, " & _
                        "               MInvMovimientosAlmacenDetalles.Cantidad, " & _
                        "               MInvMovimientosAlmacenDetalles.Costo " & _
                        "FROM			MInvMovimientosAlmacenDetalles INNER JOIN " & _
                        "               MInvMovimientosAlmacen ON MInvMovimientosAlmacenDetalles.AlmacenId = MInvMovimientosAlmacen.AlmacenId AND " & _
                        "               MInvMovimientosAlmacenDetalles.FolioMovimiento = MInvMovimientosAlmacen.FolioMovimiento INNER JOIN " & _
                        "               MCatCompProductos ON MInvMovimientosAlmacenDetalles.ProductoId = MCatCompProductos.PdIdProducto " & _
                        "WHERE			MInvMovimientosAlmacen.TipoMovimientoId = @TipoMovimiento AND " & _
                        "               MInvMovimientosAlmacen.FechaMovimiento BETWEEN @FechaInicial AND @FechaFinal " & _
                        "GO " & _
                        "SELECT			AplicMedi.FolioAplicacionMedicamento, " & _
                        "               AplicMedi.FolioMovimientoAlmacen, " & _
                        "               AplicMedi.FechaAplicacionMedicamento, " & _
                        "               MCECatLotesCab.NombreLote, " & _
                        "               MCECatCorralesCab.NombreCorral, " & _
                        "               AplicMediDet.Cantidad, " & _
                        "               AplicMediDet.CosProm, " & _
                        "               AplicMediDet.Importe, " & _
                        "               AplicMediDet.IdMedicamento " & _
                        "FROM			AplicMediDet INNER JOIN " & _
                        "               AplicMedi ON AplicMediDet.FolioAplicacionMedicamento = AplicMedi.FolioAplicacionMedicamento INNER JOIN " & _
                        "               MCECatCorralesCab ON AplicMediDet.IdCorral = MCECatCorralesCab.IdCorral INNER JOIN " & _
                        "               MCECatLotesCab ON AplicMediDet.IdLote = MCECatLotesCab.IdLote " & _
                        "WHERE			AplicMedi.FolioMovimientoAlmacen IN (SELECT		MInvMovimientosAlmacenDetalles.FolioMovimiento " & _
                        "							                         FROM		MInvMovimientosAlmacenDetalles INNER JOIN " & _
                        "										                        MInvMovimientosAlmacen ON MInvMovimientosAlmacenDetalles.AlmacenId = MInvMovimientosAlmacen.AlmacenId AND  " & _
                        "															    MInvMovimientosAlmacenDetalles.FolioMovimiento = MInvMovimientosAlmacen.FolioMovimiento INNER JOIN " & _
                        "															    MCatCompProductos ON MInvMovimientosAlmacenDetalles.ProductoId = MCatCompProductos.PdIdProducto " & _
                        "													 WHERE		MInvMovimientosAlmacen.TipoMovimientoId = @TipoMovimiento AND " & _
                        "										                        MInvMovimientosAlmacen.FechaMovimiento BETWEEN @FechaInicial AND @FechaFinal)"
            Dim sqlAd As New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(query, sqlCon))
            Dim dst As New DataSet
            Dim reporte As New rptSalidaMedicmanetoAlmacen
            Dim ventana As New PreVisualizarForm

            sqlAd.Fill(dst)

            reporte.SetDataSource(dst)
            reporte.SetParameterValue(0, "")
            reporte.SetParameterValue(1, "")
            reporte.SetParameterValue(2, "")

            ventana.Reporte = reporte
            ventana.Text = "Reporte de Salida Medicamento Almacén"
            ventana.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If sqlCon.State = ConnectionState.Open Then
                sqlCon.Close()
            End If
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Me.dtFechaFin.Value = Now
        Me.dtFechaInicio.Value = Now
        Me.chkAplicaciones.Checked = True
        Me.chkProrrateo.Checked = True
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub chkProrrateo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkProrrateo.CheckedChanged
        If Not Me.chkAplicaciones.Checked AndAlso Not Me.chkProrrateo.Checked Then
            Me.chkProrrateo.Checked = True
            Me.chkAplicaciones.Checked = True
        End If
    End Sub
End Class