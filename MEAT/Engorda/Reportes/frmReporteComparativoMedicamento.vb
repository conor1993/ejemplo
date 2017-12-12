Imports HC = Integralab.ORM.HelperClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports TC = Integralab.ORM.TypedViewClasses
Imports ClasesNegocio

Public Class frmReporteComparativoMedicamento

    Private Sub mtb_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickImprimir
        Dim sqlCon As SqlClient.SqlConnection = HC.DbUtils.CreateConnection

        Try
            Dim vista As New TC.VwBusquedaComparacionMedicamentosTypedView
            Dim reporte As New rptComparativoMedicamentos
            Dim ventana As New ClasesNegocio.PreVisualizarForm

            vista.Fill(0, Nothing, True, _
                        New OC.FieldBetweenPredicate( _
                            HC.VwBusquedaComparacionMedicamentosFields.FechaAplicacionMedicamento, _
                            Me.dtFechaInicio.Value.ToShortDateString, Me.dtFechaFin.Value.AddDays(1).ToShortDateString))
            reporte.SetDataSource(CType(vista, Object))
            reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
            reporte.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
            reporte.SetParameterValue(2, "Manejo de Ganado/Reportes/Medicamentos/Comparativo")
            ventana.Reporte = reporte
            ventana.Text = "Reporte Comparativo de Medicamentos"
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
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub
End Class