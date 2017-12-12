Imports SPR = IntegraLab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports HC = IntegraLab.ORM.HelperClasses

Public Class FrmReporteIntegral

    Private Sub FrmReporteIntegral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.mtb.Buttons(1).Visible = False
        Me.mtb.Buttons(4).Visible = False
        Me.Icon = MdiParent.Icon
    End Sub

    Private Sub TextBoxMejorado1_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles TextBoxMejorado1.PreviewKeyDown
        If e.KeyCode = Keys.F3 Then
            Dim Ventana As New _960BusquasedaLotesDeCortes
            Ventana.Text = "SELECCIONE UN FOLIO DE SACRIFICIO PARA EL REPORTE"
            Ventana.Label17.Text = "SELECCIONE UN FOLIO DE SACRIFICIO PARA EL REPORTE"
            Ventana.Icon = Me.Icon
            If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.TextBoxMejorado1.Text = Ventana.DgvLotes.SelectedRows(0).Cells(Ventana.clmLoteCorte.Index).Value
            End If
        End If
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            If (Me.dtpFechaInicial.Value > Me.dtpFechaFinal.Value) Then
                MessageBox.Show("Rango de fechas no válido, intente de nuevo", "Error", MessageBoxButtons.OK)
                Me.dtpFechaFinal.Value = DateTime.Now.ToShortDateString
                Me.dtpFechaInicial.Value = DateTime.Now.ToShortDateString
                Me.dtpFechaInicial.Focus()
            Else

                Dim producto As Integer = -1

                Dim Reporte As New RptVentasPorProducto
                Dim Tabla As New DataTable
                Using ad As New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("ReporteIntegral", _
                            New SqlClient.SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString)))
                    ad.SelectCommand.CommandType = CommandType.StoredProcedure

                    With ad.SelectCommand.Parameters
                        .Add("@Opcion", SqlDbType.Int).Value = 1
                        .Add("@FechaInicial", SqlDbType.DateTime).Value = Me.dtpFechaInicial.Value.ToShortDateString
                        .Add("@FechaFinal", SqlDbType.DateTime).Value = Me.dtpFechaFinal.Value.AddDays(1).ToShortDateString
                        .Add("@FolioSacrificio", SqlDbType.VarChar).Value = ""
                    End With

                    ad.SelectCommand.Connection.Open()

                    ad.Fill(Tabla)
                    ad.SelectCommand.Connection.Close()
                End Using

                Me.dgvSacrificios.AutoGenerateColumns = False
                Me.dgvSacrificios.DataSource = Tabla

                'Reporte.SetDataSource(Tabla)
                'Reporte.SetParameterValue("Empresa", Controlador.Sesion.MiEmpresa.Empnom)
                'Reporte.SetParameterValue("FechaInicio", Me.dtpFechaInicial.Value.ToShortDateString)
                'Reporte.SetParameterValue("Fechafin", Me.dtpFechaFinal.Value.ToShortDateString)
                'Reporte.SetParameterValue("Usuario", Controlador.Sesion.MiUsuario.Usrnomcom)

                'Dim visualizar As New CN.PreVisualizarForm

                'visualizar.Reporte = Reporte
                'visualizar.Text = "Reporte de Ventas Por Productos"
                'visualizar.ShowDialog()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try
            Dim Reporte1 As New RptIntegral
            Dim DS1 As New DataSet
            DS1 = SPR.RptIntegral2(Me.TextBoxMejorado1.Text)
            Reporte1.SetDataSource(DS1.Tables(0))
            Reporte1.Subreports(0).SetDataSource(DS1.Tables(3))
            Reporte1.Subreports(1).SetDataSource(DS1.Tables(2))
            Reporte1.Subreports(2).SetDataSource(DS1.Tables(1))

            Reporte1.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
            Reporte1.SetParameterValue("Modulo", "Producción")
            Reporte1.SetParameterValue("Usuario", Controlador.Sesion.MiUsuario.Usrnomcom)

            Dim VerReporte As New FrmReportes
            VerReporte.CRV.ReportSource = Reporte1
            VerReporte.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

  

  

    Private Sub dgvSacrificios_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvSacrificios.SelectionChanged
        Try
            Dim LoteSacrificio As String
            If Me.dgvSacrificios.SelectedRows.Count > 0 Then
                LoteSacrificio = Me.dgvSacrificios.CurrentRow.Cells(Me.clmFolioSacrificio.Index).Value
                Dim Tabla1 As New DataTable
                Using ad As New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("Dbo.ReporteIntegral", _
                                           New SqlClient.SqlConnection(IntegraLab.ORM.HelperClasses.DbUtils.ActualConnectionString)))
                    ad.SelectCommand.CommandType = CommandType.StoredProcedure

                    With ad.SelectCommand.Parameters
                        .Add("@Opcion", SqlDbType.Int).Value = 2
                        .Add("@FechaInicial", SqlDbType.DateTime).Value = Me.dtpFechaInicial.Value.ToShortDateString
                        .Add("@FechaFinal", SqlDbType.DateTime).Value = Me.dtpFechaFinal.Value.AddDays(1).ToShortDateString
                        .Add("@FolioSacrificio", SqlDbType.VarChar).Value = LoteSacrificio
                    End With

                    ad.SelectCommand.Connection.Open()

                    ad.Fill(Tabla1)
                    ad.SelectCommand.Connection.Close()
                End Using

                Me.dgvCanales.AutoGenerateColumns = False
                Me.dgvCanales.DataSource = Tabla1

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class