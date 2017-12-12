Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports SPR = IntegraLab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
Imports CN = ClasesNegocio

Public Class _692ReportedeSaldos
    Dim Clientes As CN.ClientesIntroductoresClass

    Private Sub _692ReportedeSaldos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
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

            Controlador.LlenarComboClientes(cmbCliente, ClasesNegocio.EstatusChar.TODOS)
            Limpiar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Limpiar()
        cmbCliente.SelectedIndex = -1
        cmbCliente.Text = "Seleccion el Cliente"
        Me.DtpFechaCorte.Text = Now
        Me.rdbCodigo.Checked = True
        Me.OptSaldosGeneralesxClienteFactura.Checked = True
        Me.chk16a30.Checked = True
        Me.chk1a7.Checked = True
        Me.chk30mas.Checked = True
        Me.chk8a15.Checked = True
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            Dim SaldosClientes As New DataSet
            Dim CodClienteInicial As Integer = 0
            Dim CodClienteFinal As Integer = 9999999

            If cmbCliente.SelectedValue IsNot Nothing Then
                CodClienteInicial = CType(cmbCliente.SelectedValue, Integer)
                CodClienteFinal = CodClienteInicial
            End If

            If optSaldosGeneralesxCliente.Checked Then
                SaldosClientes = SPR.PaCxcsaldosCliente(2, Me.DtpFechaCorte.Value, CodClienteInicial, CodClienteFinal, Me.chk1a7.Checked, _
                                Me.chk8a15.Checked, Me.chk16a30.Checked, Me.chk30mas.Checked)
            Else
                SaldosClientes = SPR.PaCxcsaldosCliente(1, Me.DtpFechaCorte.Value, CodClienteInicial, CodClienteFinal, Me.chk1a7.Checked, _
                                Me.chk8a15.Checked, Me.chk16a30.Checked, Me.chk30mas.Checked)
            End If

            If SaldosClientes.Tables(0).Rows.Count = 0 Then
                MsgBox("No existe información de saldos de clientes", MsgBoxStyle.Information, "")
            Else
                Me.dgvSaldos.AutoGenerateColumns = False
                Me.dgvSaldos.DataSource = SaldosClientes.Tables(0)
                Me.dgvSaldos.ReadOnly = True

                If optSaldosGeneralesxCliente.Checked = True Then
                    Me.Factura.Visible = False
                    Me.FechaFactura.Visible = False
                    Me.FechaVencimiento.Visible = False
                    Me.Importe.Visible = False
                    Me.DiasTranscurridos.Visible = False
                    Me.DiasVencidos.Visible = False
                    Me.Abonos.Visible = False
                    Me.Saldo.Visible = False
                    Me.PorVencer.Visible = True
                    Me.Total.Visible = True
                    Me.Vencidos.Visible = True
                Else
                    Me.PorVencer.Visible = False
                    Me.Total.Visible = False
                    Me.Vencidos.Visible = False
                    Me.Factura.Visible = True
                    Me.FechaFactura.Visible = True
                    Me.FechaVencimiento.Visible = True
                    Me.Importe.Visible = True
                    Me.DiasTranscurridos.Visible = True
                    Me.DiasVencidos.Visible = True
                    Me.Abonos.Visible = True
                    Me.Saldo.Visible = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try
            Dim SaldosClientes As New DataSet
            Dim CodClienteInicial As Integer = 0
            Dim CodClienteFinal As Integer = 9999999

            If cmbCliente.SelectedValue IsNot Nothing Then
                CodClienteInicial = CType(cmbCliente.SelectedValue, Integer)
                CodClienteFinal = CodClienteInicial
            End If

            If Me.OptSaldosGeneralesxClienteFactura.Checked Then
                SaldosClientes = SPR.PaCxcsaldosCliente(1, Me.DtpFechaCorte.Value.Date.AddDays(1).AddTicks(-1), CodClienteInicial, CodClienteFinal, Me.chk1a7.Checked, _
                                Me.chk8a15.Checked, Me.chk16a30.Checked, Me.chk30mas.Checked)
                If SaldosClientes.Tables(0).Rows.Count = 0 Then
                    MsgBox("No existe información de saldos de clientes", MsgBoxStyle.Information, "")
                Else
                    Dim Reporte As New CN.RptSaldosxClientexFactura
                    Dim Orden As String = "NoFactura"

                    If rdbFecha.Checked Then
                        Orden = "FechaFactura"
                    End If
                    Dim dt As DataTable = SaldosClientes.Tables(0).Clone
                    Dim DataRow() As DataRow = SaldosClientes.Tables(0).Select("", Orden)

                    For i As Integer = 0 To DataRow.Length - 1
                        dt.ImportRow(DataRow(i))
                    Next

                    Reporte.SetDataSource(dt)
                    Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
                    Reporte.SetParameterValue(1, Me.DtpFechaCorte.Value.ToShortDateString)
                    Reporte.SetParameterValue(2, Controlador.Sesion.MiUsuario.Usrnomcom)

                    Dim VerReporte As New FrmReportes

                    VerReporte.CRV.ReportSource = Reporte
                    VerReporte.Text = "Saldos Generales Por Cliente Factura"
                    VerReporte.WindowState = FormWindowState.Maximized
                    VerReporte.Show()
                End If
            End If
            If Me.optAcumulados.Checked Then
                SaldosClientes = SPR.PaCxcsaldosCliente(1, Me.DtpFechaCorte.Value.Date.AddDays(1).AddTicks(-1), CodClienteInicial, CodClienteFinal, Me.chk1a7.Checked, _
                                Me.chk8a15.Checked, Me.chk16a30.Checked, Me.chk30mas.Checked)
                If SaldosClientes.Tables(0).Rows.Count = 0 Then
                    MsgBox("No existe información de saldos de clientes", MsgBoxStyle.Information, "")
                Else
                    Dim Reporte As New CN.RptSaldosxClienteAcumulados
                    Reporte.SetDataSource(SaldosClientes.Tables(0))
                    Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
                    Reporte.SetParameterValue(1, Me.DtpFechaCorte.Value.ToShortDateString)
                    Reporte.SetParameterValue(2, Controlador.Sesion.MiUsuario.Usrnomcom)
                    Dim VerReporte As New FrmReportes
                    VerReporte.CRV.ReportSource = Reporte
                    VerReporte.Show()
                End If
            End If
            If Me.optSaldosGeneralesxCliente.Checked Then
                SaldosClientes = SPR.PaCxcsaldosCliente(2, Me.DtpFechaCorte.Value.Date.AddDays(1).AddTicks(-1), CodClienteInicial, CodClienteFinal, Me.chk1a7.Checked, _
                                Me.chk8a15.Checked, Me.chk16a30.Checked, Me.chk30mas.Checked)
                If SaldosClientes.Tables(0).Rows.Count = 0 Then
                    MsgBox("No existe información de saldos de clientes", MsgBoxStyle.Information, "")
                Else
                    Dim Reporte As New CN.RptSaldosGenerales
                    Reporte.SetDataSource(SaldosClientes.Tables(0))
                    Reporte.SetParameterValue(1, Controlador.Sesion.MiEmpresa.Empnom)
                    Reporte.SetParameterValue(0, Me.DtpFechaCorte.Value.ToShortDateString)
                    Reporte.SetParameterValue(2, Controlador.Sesion.MiUsuario.Usrnomcom)
                    Dim VerReporte As New FrmReportes
                    VerReporte.CRV.ReportSource = Reporte
                    VerReporte.Show()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
   
    Private Sub chk1a7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk1a7.CheckedChanged
        If Not Me.chk1a7.Checked And Not Me.chk8a15.Checked And Not Me.chk16a30.Checked And Not Me.chk30mas.Checked Then
            Me.chk1a7.Checked = True
            Me.chk8a15.Checked = True
            Me.chk16a30.Checked = True
            Me.chk30mas.Checked = True
        End If
    End Sub

    Private Sub chk8a15_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk8a15.CheckedChanged
        If Not Me.chk1a7.Checked And Not Me.chk8a15.Checked And Not Me.chk16a30.Checked And Not Me.chk30mas.Checked Then
            Me.chk1a7.Checked = True
            Me.chk8a15.Checked = True
            Me.chk16a30.Checked = True
            Me.chk30mas.Checked = True
        End If
    End Sub

    Private Sub chk16a30_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk16a30.CheckedChanged
        If Not Me.chk1a7.Checked And Not Me.chk8a15.Checked And Not Me.chk16a30.Checked And Not Me.chk30mas.Checked Then
            Me.chk1a7.Checked = True
            Me.chk8a15.Checked = True
            Me.chk16a30.Checked = True
            Me.chk30mas.Checked = True
        End If
    End Sub

    Private Sub chk30mas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk30mas.CheckedChanged
        If Not Me.chk1a7.Checked And Not Me.chk8a15.Checked And Not Me.chk16a30.Checked And Not Me.chk30mas.Checked Then
            Me.chk1a7.Checked = True
            Me.chk8a15.Checked = True
            Me.chk16a30.Checked = True
            Me.chk30mas.Checked = True
        End If
    End Sub

    Private Sub dgvSaldos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSaldos.CellContentClick

    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        Me.Limpiar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickSalir

        Me.Close()

    End Sub
End Class
