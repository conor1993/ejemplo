Imports SPR = Integralab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
Public Class FrmReporteCanal_Corte

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
        Try
            Dim Reporte As New RptPiezasCanalCorte
            Dim Ds As New DataSet
            Dim Tabla As New DataTable

            If Validar() Then               
                Tabla = SPR.RptCanalCorte(Trim(Me.txtFolio.Text), Me.DtpFechaInicial.Value.ToShortDateString, Me.DtpFechaFinal.Value.AddDays(1).ToShortDateString)
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