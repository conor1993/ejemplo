Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports SPR = IntegraLab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
Imports CN = ClasesNegocio
Imports System.ComponentModel

Public Class ReportedeEstadodeCuenta
    Dim Clientes As CN.ClientesIntroductoresClass

#Region "Metodos"

    Public Sub ImprimirResumen(ByVal IdClienteInicial As Integer, ByVal IdClienteFinal As Integer)
        If Not bdWorker.IsBusy Then
            CType(Me.MdiParent, MDIMenuPrincipal).tlsProgressBar.Visible = True
            bdWorker.RunWorkerAsync(New Object() {rbnSaldoActual.Checked, IdClienteInicial, IdClienteFinal, DtpFechaInicio.Value, DtpFechaFinal.Value})
        End If
    End Sub

    Private Sub ImprimirDetallado(ByVal IdClienteInicial As Integer, ByVal IdClienteFinal As Integer)
        If Not bdWorker.IsBusy Then
            CType(Me.MdiParent, MDIMenuPrincipal).tlsProgressBar.Visible = True
            bdWorker.RunWorkerAsync(New Object() {rdbFecha.Checked, Me.chkExcluirPagadas.Checked, Me.DtpFechaInicio.Value.Date, Me.DtpFechaFinal.Value.Date.AddDays(1).AddTicks(-1), IdClienteInicial, IdClienteFinal})
        End If
    End Sub

#End Region

#Region "Eventos"

    Private Sub ReportedeEstadodeCuenta_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If bdWorker.IsBusy Then
            e.Cancel = True
        End If
    End Sub

    Private Sub ReportedeEstadodeCuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            MtbEstados.StateBuscar = ""
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = ""
            MtbEstados.StateNuevo = ""
            MtbEstados.StateGuardar = ""
            MtbEstados.StateBorrar = ""
            MtbEstados.StateEditar = ""
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""

            mtb.ToolBarButtonStatus = MtbEstados
            Controlador.LlenarComboClientes(ultcmbCliente, ClasesNegocio.EstatusChar.TODOS, True)
            CType(ultcmbCliente.DataSource, DataTable).Rows.InsertAt(CType(ultcmbCliente.DataSource, DataTable).NewRow, 0)
            CType(ultcmbCliente.DataSource, DataTable).Rows(0)("IdCliente") = 0
            CType(ultcmbCliente.DataSource, DataTable).Rows(0)("Nombre") = "TODOS"
            Limpiar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Limpiar()
        ultcmbCliente.SelectedIndex = 0
        Me.DtpFechaInicio.Value = Now
        Me.DtpFechaFinal.Value = Now
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Dim IdClienteInicial As Integer = 0, IdClienteFinal As Integer = 99999

        If ultcmbCliente.Value IsNot Nothing AndAlso CType(ultcmbCliente.Value, Integer) <> 0 Then
            If IsNumeric(ultcmbCliente.Value.ToString) Then
                IdClienteInicial = CType(ultcmbCliente.Value.ToString, Integer)
            End If

            If IsNumeric(ultcmbCliente.Value.ToString) Then
                IdClienteFinal = CType(ultcmbCliente.Value.ToString, Integer)
            End If
        End If

        If chkResumen.Checked Then
            Me.ImprimirResumen(IdClienteInicial, IdClienteFinal)
        Else
            Me.ImprimirDetallado(IdClienteInicial, IdClienteFinal)
        End If
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        If Not bdWorker.IsBusy Then
            Close()
        Else
            MessageBox.Show("Hay tareas pendientes por terminar, espere a que terminen antes de salir", Controlador.Sesion.MiEmpresa.Empnom)
        End If
    End Sub

    Private Sub chkResumen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkResumen.CheckedChanged
        grpOrdenResumen.Visible = chkResumen.Checked
        grpOrdenamiento.Visible = Not chkResumen.Checked
        chkExcluirPagadas.Enabled = Not chkResumen.Checked
        chkFacturasCanceladas.Enabled = Not chkResumen.Checked
    End Sub

    Private Sub ultcmbCliente_AfterEnterEditMode(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ultcmbCliente.AfterEnterEditMode
        ultcmbCliente.SelectionStart = 0
        ultcmbCliente.SelectionLength = ultcmbCliente.Text.Length
    End Sub

    Private Sub ultcmbCliente_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ultcmbCliente.Leave
        If ultcmbCliente.Value Is Nothing Then
            ultcmbCliente.SelectedIndex = 0
        End If
    End Sub

    <System.Diagnostics.DebuggerNonUserCode()> _
    Private Sub bdWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bdWorker.DoWork
        If e.Argument.length = 5 Then
            Utilerias.RunControlException(Controlador, "ReporteSaldosClientesAcumulados", New Object() {CType(sender, BackgroundWorker), CType(e.Argument(0), Boolean), CType(e.Argument(1), Integer), CType(e.Argument(2), Integer), CType(e.Argument(3), Date), CType(e.Argument(4), Date)})
        Else
            Try
                Dim EstadodeCuenta As New DataSet
                Dim Reporte As New CN.RptEstadodeCuenta
                Dim Orden As String = "NoFactura"

                If CType(e.Argument(0), Boolean) Then
                    Orden = "FechaFactura"
                End If
                bdWorker.ReportProgress(10)

                If CType(e.Argument(1), Boolean) Then
                    EstadodeCuenta = SPR.PaCxcestadodeCuentaClientes(2, CType(e.Argument(2), Date), CType(e.Argument(3), Date), CType(e.Argument(4), Integer), CType(e.Argument(5), Integer))
                    Orden &= ", Cargo desc"
                Else
                    EstadodeCuenta = SPR.PaCxcestadodeCuentaClientes(1, CType(e.Argument(2), Date), CType(e.Argument(3), Date), CType(e.Argument(4), Integer), CType(e.Argument(5), Integer))

                    If rdbFecha.Checked Then
                        Orden &= ", Tipo"
                    End If
                End If
                bdWorker.ReportProgress(60)

                If EstadodeCuenta.Tables(0).Rows.Count = 0 Then
                    MsgBox("No existe información de saldos de clientes", MsgBoxStyle.Information, "")
                Else

                    Dim dt As DataTable = EstadodeCuenta.Tables(0).Clone
                    Dim DataRow() As DataRow = EstadodeCuenta.Tables(0).Select("", Orden)

                    For i As Integer = 0 To DataRow.Length - 1
                        dt.ImportRow(DataRow(i))
                    Next
                    bdWorker.ReportProgress(80)

                    Reporte.SetDataSource(dt)
                    Reporte.SetParameterValue(1, Controlador.Sesion.MiEmpresa.Empnom)
                    Reporte.SetParameterValue(0, Me.DtpFechaInicio.Value)
                    Reporte.SetParameterValue(2, Controlador.Sesion.MiUsuario.Usrnomcom)

                    Dim VerReporte As New FrmReportes

                    VerReporte.CRV.ReportSource = Reporte
                    bdWorker.ReportProgress(100)
                    VerReporte.ShowDialog()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub bdWorker_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bdWorker.ProgressChanged
        CType(Me.MdiParent, MDIMenuPrincipal).tlsProgressBar.Value = e.ProgressPercentage
    End Sub

    Private Sub bdWorker_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bdWorker.RunWorkerCompleted
        CType(Me.MdiParent, MDIMenuPrincipal).tlsProgressBar.Visible = False
        CType(Me.MdiParent, MDIMenuPrincipal).tlsProgressBar.Value = 0
    End Sub

#End Region

End Class