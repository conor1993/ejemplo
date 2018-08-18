Imports SPR = IntegraLab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
Imports HC = IntegraLab.ORM.HelperClasses

Imports System.Data.SqlClient

Public Class FrmReporteCanal_CortePorFecha

    Private Sub FrmReporteCanal_Corte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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


    Private Sub txtFolio_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs)
        'If e.KeyCode = Keys.F3 Then
        '    Dim Ventana As New _960BusquasedaLotesDeCortes
        '    Ventana.Text = "SELECCIONE UN LOTE DE CORTE PARA EL REPORTE"
        '    Ventana.Label17.Text = "SELECCIONE UN LOTE DE CORTE PARA EL REPORTE"
        '    Ventana.Icon = Me.Icon
        '    If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
        '        Me.txtFolio.Text = Ventana.DgvLotes.SelectedRows(0).Cells(Ventana.clmLoteCorte.Index).Value
        '    End If
        'End If
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try
            Dim Reporte As New RptPiezasCanalCortePorFecha
            Dim Ds As New DataSet
            Dim Tabla As New DataTable

            If Validar() Then
                Dim query As String = "RptCanal_CortePorFecha"
                Dim sqlCon As New SqlClient.SqlConnection(HC.DbUtils.ActualConnectionString)
                Dim command As New SqlCommand(query, sqlCon)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.Add(New SqlParameter("@FechaInicial", Me.DtpFechaInicial.Value.ToShortDateString))
                'command.Parameters.Add(New SqlParameter("@FechaFinal", Me.DtpFechaFinal.Value.AddDays(1).ToShortDateString))
                command.Parameters.Add(New SqlParameter("@FechaFinal", Me.DtpFechaFinal.Value.ToShortDateString))
                'command.Parameters.Add(New"@FechaInicial", SqlDbType.DateTime).value = Me.DtpFechaInicial.Value.ToShortDateString
                Dim adapter As New SqlDataAdapter(command)
                adapter.Fill(Tabla)

                If Tabla.Rows.Count > 0 Then
                    Ds.Tables.Add(Tabla)

                    For Each row As DataRow In Tabla.Rows
                        If CInt(row("Canales")) = 0 Then
                            If MessageBox.Show("El Reporte lleva lotes de cortes sin canales, esto puede provocar errores en los calculos de rendimiento.", _
                                "Lotes de Corte Sin Canales", MessageBoxButtons.OKCancel, _
                                MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1) = _
                                Windows.Forms.DialogResult.Cancel Then
                                Exit Sub
                            Else
                                Exit For
                            End If
                        End If
                    Next

                    Reporte.SetDataSource(Ds.Tables(0))
                    Reporte.SetParameterValue("Empresa", Controlador.Sesion.MiEmpresa.Empnom)
                    Reporte.SetParameterValue("Modulo", "Produccion")
                    Reporte.SetParameterValue("Usuario", Controlador.Sesion.MiUsuario.Usrnomcom)
                    Reporte.SetParameterValue("FechaInicial", Me.DtpFechaInicial.Value.ToShortDateString)
                    Reporte.SetParameterValue("FechaFinal", Me.DtpFechaFinal.Value.ToShortDateString)
                    Dim VerReporte As New FrmReportes
                    VerReporte.CRV.ReportSource = Reporte
                    VerReporte.Show()
                Else
                    MsgBox("No se encontro información con el lote de corte proporcionado", MsgBoxStyle.Exclamation, "Aviso")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub
End Class