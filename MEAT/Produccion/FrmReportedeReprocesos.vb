Imports CN = ClasesNegocio
Imports System.Data.SqlClient

Public Class FrmReportedeReprocesos
    Private Opcion As Integer

    Private Sub FrmReportedeReprocesos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = MdiParent.Icon
        Me.mtb.Buttons(1).Visible = False
        Me.mtb.Buttons(4).Visible = False
        Me.DtpFechaInicial.Value = Now
        Me.DtpFechaFinal.Value = Now
    End Sub
    Private Function Validar() As Boolean
        If Me.DtpFechaInicial.Value > Me.DtpFechaFinal.Value Then
            MsgBox("La Fecha inicial debe ser menor o igual a la fecha final", MsgBoxStyle.Exclamation, "Aviso")
            Return False
        Else
            Return True
        End If
    End Function


    Private Sub txtFolio_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtFolio.PreviewKeyDown
        If e.KeyCode = Keys.F3 Then
            Dim Ventana As New _960BusquasedaLotesDeCortes
            Ventana.Text = "SELECCIONE UN LOTE DE CORTE PARA EL REPORTE"
            Ventana.Label17.Text = "SELECCIONE UN LOTE DE CORTE PARA EL REPORTE"
            Ventana.Icon = Me.Icon
            If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtFolio.Text = Ventana.DgvLotes.SelectedRows(0).Cells(Ventana.clmLoteCorte.Index).Value
            End If
        End If
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Dim sqlCon As New SqlConnection(IntegraLab.ORM.HelperClasses.DbUtils.ActualConnectionString)

        Try
            Dim sqlCom As New SqlCommand("CajasEnReproceso", sqlCon)
            Dim ds As New DataSet
            Dim ad As New SqlDataAdapter(sqlCom)
            Dim reporte As New rptReporteReprocesos
            Dim prev As New ClasesNegocio.PreVisualizarForm

            sqlCom.CommandType = CommandType.StoredProcedure

            With sqlCom.Parameters
                'las Opciones para usar el procedimiento son
                '1 todos los clientes en un rango de fechas
                '2 un cliente con un rango de fechas

                'If Me.cmbClientes.SelectedIndex > -1 Then
                .Add("@Opcion", SqlDbType.Int).Value = Me.Opcion
                .Add("@LoteCorte", SqlDbType.Char).Value = Me.txtFolio.Text
                'Else
                '    .Add("@idCliente", SqlDbType.Int).Value = 0
                '    .Add("@FechaIni", SqlDbType.DateTime).Value = Me.DtpFechaInicial.Value.ToShortDateString
                '    .Add("@FechaFin", SqlDbType.DateTime).Value = Me.DtpFechaFinal.Value.AddDays(1).ToShortDateString
                '    .Add("@Opcion", SqlDbType.Int).Value = 1
                'End If

            End With

            sqlCon.Open()

            ad.Fill(ds)


            reporte.SetDataSource(ds.Tables(0))
            'reporte.Subreports(0).SetDataSource(ds.Tables(1))
            reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
            reporte.SetParameterValue(1, "Producción\Reportes\Reprocesos")
            reporte.SetParameterValue(2, Controlador.Sesion.MiUsuario.Usrnomcom)
            'reporte.SetParameterValue(2, Me.DtpFechaInicial.Value)
            'reporte.SetParameterValue(1, Me.DtpFechaFinal.Value)
            prev.Reporte = reporte


            prev.Text = "Reporte de Facturas Generales por Cliente y Cargo a Cliente"
            prev.Icon = Icon
            prev.StartPosition = FormStartPosition.CenterScreen
            prev.WindowState = FormWindowState.Maximized
            'reporte.SaveAs("c:\tempRpt\Reporte", True)
            prev.ShowDialog()
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al mostrar el reporte", MsgBoxStyle.Critical, "Error")
#End If
        Finally
            If sqlCon.State = ConnectionState.Open Then
                sqlCon.Close()
            End If
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub OptEnviadasaReproceso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptEnviadasaReproceso.CheckedChanged
        If Me.OptEnviadasaReproceso.Checked Then
            Opcion = 1
        Else
            Opcion = 0
        End If
    End Sub

    Private Sub optProducidas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optProducidas.CheckedChanged
        If Me.optProducidas.Checked Then
            Opcion = 2
        Else
            Opcion = 0
        End If
    End Sub

    Private Sub optAmbas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAmbas.CheckedChanged
        If Me.optAmbas.Checked Then
            Opcion = 3
        Else
            Opcion = 0
        End If
    End Sub
End Class