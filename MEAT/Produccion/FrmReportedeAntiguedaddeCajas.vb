Imports CN = ClasesNegocio
Imports System.Data.SqlClient

Public Class FrmReportedeAntiguedaddeCajas

   

    Private Sub FrmReportedeAntiguedaddeCajas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = MdiParent.Icon
        Me.mtb.Buttons(1).Visible = False
        Me.mtb.Buttons(4).Visible = False
        Me.Limpiar()
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Dim sqlCon As New SqlConnection(IntegraLab.ORM.HelperClasses.DbUtils.ActualConnectionString)

        Try
            Dim sqlCom As New SqlCommand("AntiguedaddeCajasExistentes", sqlCon)
            Dim ds As New DataSet
            Dim ad As New SqlDataAdapter(sqlCom)
            Dim reporte As New rptAntiguedaddeCajasExistentes
            Dim prev As New ClasesNegocio.PreVisualizarForm

            sqlCom.CommandType = CommandType.StoredProcedure

            With sqlCom.Parameters
                'las Opciones para usar el procedimiento son
                '1 todos los clientes en un rango de fechas
                '2 un cliente con un rango de fechas

                ''If Me.cmbClientes.SelectedIndex > -1 Then
                .Add("@DiaInicialPrimerColumna", SqlDbType.Int).Value = Me.NupDia1.Value
                .Add("@DiaFinalPrimerColumna", SqlDbType.Int).Value = Me.NupDia2.Value
                .Add("@DiaInicialSegundaColumna", SqlDbType.Int).Value = Me.NupDia3.Value
                .Add("@DiaFinalSegundaColumna", SqlDbType.Int).Value = Me.NupDia4.Value
                .Add("@DiaInicialTercerColumna", SqlDbType.Int).Value = Me.NupDia5.Value
                .Add("@DiaFinalTercerColumna", SqlDbType.Int).Value = Me.NupDia6.Value
                .Add("@DiaInicialCuartaColumna", SqlDbType.Int).Value = Me.NupDia7.Value
                .Add("@DiaFinalCuartaColumna", SqlDbType.Int).Value = Me.NupDia8.Value
                .Add("@DiaInicialQuintaColumna", SqlDbType.Int).Value = Me.NupDia9.Value
                .Add("@DiaFinalQuintaColumna", SqlDbType.Int).Value = Me.NupDia10.Value
                .Add("@FechaCorte", SqlDbType.DateTime).Value = Me.DtpFechaInicial.Value.AddDays(1).ToShortDateString
                ''Else
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
            reporte.SetParameterValue(3, Me.NupDia1.Value)
            reporte.SetParameterValue(4, Me.NupDia2.Value)
            reporte.SetParameterValue(5, Me.NupDia3.Value)
            reporte.SetParameterValue(6, Me.NupDia4.Value)
            reporte.SetParameterValue(7, Me.NupDia5.Value)
            reporte.SetParameterValue(8, Me.NupDia6.Value)
            reporte.SetParameterValue(9, Me.NupDia7.Value)
            reporte.SetParameterValue(10, Me.NupDia8.Value)
            reporte.SetParameterValue(11, Me.NupDia9.Value)
            reporte.SetParameterValue(12, Me.NupDia10.Value)

            prev.Reporte = reporte


            prev.Text = "Reporte de Antigüedad de Cajas"
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
#Region "METODOS"
    Private Sub Limpiar()
        Try
            Me.DtpFechaInicial.Value = Now
            Me.NupDia1.Value = 1
            Me.NupDia2.Value = 7
            Me.NupDia3.Value = 8
            Me.NupDia4.Value = 14
            Me.NupDia5.Value = 15
            Me.NupDia6.Value = 21
            Me.NupDia7.Value = 22
            Me.NupDia8.Value = 28
            Me.NupDia9.Value = 29
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region

    Private Sub NupDia2_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles NupDia2.Validated
        Try
            If Me.NupDia2.Value < Me.NupDia1.Value Then
                MessageBox.Show("Numero de dias menor al anterior", "", MessageBoxButtons.OK)
                Me.NupDia2.Focus()
            Else
                Exit Sub
                'Me.NupDia3.Focus()
                'Me.NupDia3.Value = Me.NupDia2.Value + 1
                'Me.NupDia4.Value = Me.NupDia2.Value + Me.NupDia2.Value
                'Me.NupDia5.Value = Me.NupDia4.Value + 1
                'Me.NupDia6.Value = Me.NupDia4.Value + Me.NupDia2.Value
                'Me.NupDia7.Value = Me.NupDia6.Value + 1
                'Me.NupDia8.Value = Me.NupDia6.Value + Me.NupDia2.Value
                'Me.NupDia9.Value = Me.NupDia8.Value + 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK)
        End Try
    End Sub

    'Private Sub NupDia4_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles NupDia4.Validated
    '    Try
    '        If Me.NupDia4.Value < Me.NupDia3.Value Then
    '            MessageBox.Show("Numero de dias menor al anterior", "", MessageBoxButtons.OK)
    '            Me.NupDia4.Focus()
    '        Else
    '            Me.NupDia5.Focus()
    '            Me.NupDia5.Value = Me.NupDia4.Value + 1
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "", MessageBoxButtons.OK)
    '    End Try
    'End Sub



    'Private Sub NupDia6_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles NupDia6.Validated
    '    Try
    '        If Me.NupDia6.Value < Me.NupDia5.Value Then
    '            MessageBox.Show("Numero de dias menor al anterior", "", MessageBoxButtons.OK)
    '            Me.NupDia6.Focus()
    '        Else
    '            Me.NupDia7.Focus()
    '            Me.NupDia7.Value = Me.NupDia6.Value + 1
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "", MessageBoxButtons.OK)
    '    End Try
    'End Sub

    'Private Sub NupDia8_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles NupDia8.Validated
    '    Try
    '        If Me.NupDia8.Value < Me.NupDia7.Value Then
    '            MessageBox.Show("Numero de dias menor al anterior", "", MessageBoxButtons.OK)
    '            Me.NupDia8.Focus()
    '        Else
    '            Me.NupDia9.Focus()
    '            Me.NupDia9.Value = Me.NupDia9.Value + 1
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "", MessageBoxButtons.OK)
    '    End Try
    'End Sub

    'Private Sub NupDia8_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NupDia8.ValueChanged

    'End Sub

    Private Sub NupDia2_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NupDia2.ValueChanged
        Try
            Me.NupDia3.Value = Me.NupDia2.Value + 1
            Me.NupDia4.Value = Me.NupDia2.Value + Me.NupDia2.Value
            Me.NupDia5.Value = Me.NupDia4.Value + 1
            Me.NupDia6.Value = Me.NupDia4.Value + Me.NupDia2.Value
            Me.NupDia7.Value = Me.NupDia6.Value + 1
            Me.NupDia8.Value = Me.NupDia6.Value + Me.NupDia2.Value
            Me.NupDia9.Value = Me.NupDia8.Value + 1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK)
        End Try
    End Sub

    
    
End Class