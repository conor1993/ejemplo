Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports ClasesNegocio

Public Class frmReporteAplicacionMedicamentosPorLote

    Private Sub Limpiar()
        Me.txtIdLote.Clear()
        Me.cmbLote.SelectedIndex = -1
        Me.cmbLote.Text = "Seleccione un Lote"
        Me.chkFiltrar.Checked = False
        Me.dtFechaFin.Value = Now
        Me.dtFechaInicio.Value = Now
    End Sub

    Private Sub frmReporteAplicacionMedicamentosPorLote_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cmbLote.OnActualizaCombo()
        Limpiar()
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickImprimir
        Cursor = Cursors.WaitCursor

        Dim sqlCon As SqlClient.SqlConnection = HC.DbUtils.CreateConnection

        Try
            Dim sqlCom As New SqlClient.SqlCommand("SELECT      AplicMediDet.FolioAplicacionMedicamento AS Aplicacion, " & _
                                                   "            AplicMedi.FechaAplicacionMedicamento AS Fecha, " & _
                                                   "            AplicMediDet.Cantidad, " & _
                                                   "            AplicMediDet.CosProm AS CostoUnitario, " & _
                                                   "            AplicMediDet.Importe, MCECatLotesCab.NombreLote AS Lote, " & _
                                                   "            MCECatCorralesCab.NombreCorral AS Corral, " & _
                                                   "            MCatCompProductos.PdDescripcion AS Medicamento, " & _
                                                   "            MCatCompUnidadMedida.UMDescripcion AS Unidad " & _
                                                   "FROM        AplicMediDet INNER JOIN MCatCompProductos ON " & _
                                                   "            AplicMediDet.IdMedicamento = MCatCompProductos.PdIdProducto " & _
                                                   "            INNER JOIN MCECatLotesCab ON AplicMediDet.IdLote = " & _
                                                   "            MCECatLotesCab.IdLote INNER JOIN MCECatCorralesCab ON " & _
                                                   "            AplicMediDet.IdCorral = MCECatCorralesCab.IdCorral " & _
                                                   "            INNER JOIN AplicMedi ON AplicMediDet.FolioAplicacionMedicamento = " & _
                                                   "            AplicMedi.FolioAplicacionMedicamento INNER JOIN " & _
                                                   "            MCatCompUnidadMedida ON MCatCompProductos.PdIdUnidadMedida = " & _
                                                   "            MCatCompUnidadMedida.UMIdUnidadMedida", sqlCon)
            Dim sqlDa As New SqlClient.SqlDataAdapter(sqlCom)
            Dim tb As New DataTable
            Dim reporte As New ClasesNegocio.rptAplicacionMedicamentoPorLote
            Dim ventana As New ClasesNegocio.PreVisualizarForm

            If Me.cmbLote.SelectedIndex > -1 Then
                If Me.chkFiltrar.Checked Then
                    sqlCom.CommandText &= " WHERE AplicMediDet.IdLote = " & CInt(Me.cmbLote.SelectedValue)
                    sqlCom.CommandText &= String.Format(" AND AplicMedi.FechaAplicacionMedicamento BETWEEN '{0}' AND '{1}'", Me.dtFechaInicio.Value.ToShortDateString, Me.dtFechaFin.Value.AddDays(1).ToShortDateString)
                Else
                    sqlCom.CommandText &= " WHERE AplicMediDet.IdLote = " & CInt(Me.cmbLote.SelectedValue)
                End If
            ElseIf Me.chkFiltrar.Checked Then
                sqlCom.CommandText &= String.Format("WHERE AplicMedi.FechaAplicacionMedicamento BETWEEN '{0}' AND '{1}'", Me.dtFechaInicio.Value.ToShortDateString, Me.dtFechaFin.Value.AddDays(1).ToShortDateString)
            End If

            sqlDa.Fill(tb)

            reporte.SetDataSource(tb)
            reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
            reporte.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
            reporte.SetParameterValue(2, "Manejo de Ganado/Reportes/Aplicación Medicamento/Por Lotes")

            ventana.Reporte = reporte
            ventana.Text = "Reporte de Aplciación De Medicamento Por Lote"

            ventana.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub cmbLote_ActualizarCombo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLote.ActualizarCombo
        Try
            Me.cmbLote.DataSource = CC.McecatLotesCabCollection.GetMultiAsDataTable( _
                                        HC.McecatLotesCabFields.Estatus = ClasesNegocio.EstatusEnum.ACTIVO, _
                                        0, New OC.SortExpression(New OC.SortClause(HC.McecatLotesCabFields.NombreLote, _
                                        SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
            Me.cmbLote.DisplayMember = "NombreLote"
            Me.cmbLote.ValueMember = "IdLote"
            Me.cmbLote.SelectedIndex = -1
            Me.cmbLote.Text = "Seleccione un Lote"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub chkFiltrar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFiltrar.CheckedChanged
        If Me.chkFiltrar.Checked Then
            Me.gbRangoFechas.Enabled = True
            Me.dtFechaFin.Value = Now
            Me.dtFechaInicio.Value = Now
        End If
    End Sub
End Class