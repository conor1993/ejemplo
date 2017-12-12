Imports CN = ClasesNegocio
Imports System.Data.SqlClient

Public Class FrmReporteDeEmbarques

    Dim Clientes As New CN.ClientesIntroductoresColeccion

    Private Sub FrmReporteDeEmbarques_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim fileContents As String = String.Empty
            Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            tbEstados.StateBuscar = "001101101"
            tbEstados.StateLimpiar = ""
            tbEstados.StateCancelar = "000100011"
            tbEstados.StateNuevo = "011010001"
            tbEstados.StateGuardar = "000100011"
            tbEstados.StateBorrar = "000100011"
            tbEstados.StateEditar = "010011001"
            tbEstados.StateImprimir = ""
            tbEstados.StateSalir = ""

            Me.mtb.ToolBarButtonStatus = tbEstados
            'Me.mtb.sbCambiarEstadoBotones("Nuevo")

            Clientes.Obtener(ClasesNegocio.CondicionEstatusEnum.ACTIVO)
            Me.cmbClientes.DisplayMember = "Nombre"
            Me.cmbClientes.ValueMember = "Codigo"
            Me.cmbClientes.DataSource = Clientes
            Me.cmbClientes.Text = "Todos"

            Me.Limpiar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        End Try

    End Sub

#Region "Métodos"

    Sub Habilitar()
        Me.cmbClientes.Enabled = True
        Me.dtpFechaFinal.Enabled = True
        Me.dtpFechaInicial.Enabled = True
        Me.chkCancelado.Enabled = True
        Me.chkFacturado.Enabled = True
        Me.chkTodos.Enabled = True
        Me.chkVigente.Enabled = True

    End Sub

    Sub Deshabilitar()
        Me.cmbClientes.Enabled = False
        Me.dtpFechaFinal.Enabled = False
        Me.dtpFechaInicial.Enabled = False
        Me.chkCancelado.Enabled = False
        Me.chkFacturado.Enabled = False
        Me.chkTodos.Enabled = False
        Me.chkVigente.Enabled = False
    End Sub

    Sub Limpiar()
        Me.cmbClientes.SelectedIndex = -1
        Me.dtpFechaFinal.Value = DateTime.Now.ToShortDateString
        Me.dtpFechaInicial.Value = DateTime.Now.ToShortDateString
        Me.chkCancelado.Checked = False
        Me.chkFacturado.Checked = False
        Me.chkTodos.Checked = False
        Me.chkVigente.Checked = True
    End Sub

    Sub Cheked()
        If (Me.chkTodos.Checked) Then
            Me.chkCancelado.Checked = True
            Me.chkFacturado.Checked = True
            Me.chkVigente.Checked = True
        Else
            Me.chkCancelado.Checked = False
            Me.chkFacturado.Checked = False
            Me.chkVigente.Checked = False
            Me.chkVigente.Checked = True
            'If (Me.chkVigente.Checked = False Or Me.chkFacturado.Checked = False Or Me.chkCancelado.Checked = False) Then
            '    Me.chkTodos.Checked = False
            'End If
        End If

    End Sub

    Public Function Estatus() As String
        Dim est As String = ""
        If (Me.chkTodos.Checked) = True Then
            est = "TODOS"
        ElseIf (Me.chkVigente.Checked = True) Then
            est = "VIGENTE"
        Else
            If (Me.chkFacturado.Checked = True) Then
                est = "FACTURADO"
            Else
                If (Me.chkCancelado.Checked = True) Then
                    est = "CANCELADO"
                End If
            End If
        End If
        Return est
    End Function

#End Region

#Region "Checked"

    Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodos.CheckedChanged
        Cheked()
    End Sub

    Private Sub chkVigente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVigente.CheckedChanged
        If (Me.chkTodos.Checked) Then
            Cheked()
        Else
            If (Me.chkVigente.Checked = True) Then
                Me.chkTodos.Checked = False
                Me.chkFacturado.Checked = False
                Me.chkCancelado.Checked = False
            End If
        End If
    End Sub

    Private Sub chkFacturado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFacturado.CheckedChanged
        If (Me.chkTodos.Checked) Then
            Cheked()
        Else
            If (Me.chkFacturado.Checked = True) Then
                Me.chkTodos.Checked = False
                Me.chkVigente.Checked = False
                Me.chkCancelado.Checked = False
            End If
        End If
    End Sub

    Private Sub chkCancelado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCancelado.CheckedChanged
        If (Me.chkTodos.Checked) Then
            Cheked()
        Else
            If (Me.chkCancelado.Checked = True) Then
                Me.chkTodos.Checked = False
                Me.chkVigente.Checked = False
                Me.chkFacturado.Checked = False
            End If
        End If
    End Sub

#End Region

#Region "Key Press"

    Private Sub cmbClientes_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbClientes.KeyPress, chkTodos.KeyPress, chkVigente.KeyPress, chkFacturado.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            SendKeys.Send(Chr(Keys.Tab))
        End If
    End Sub

#End Region

#Region "Tool Bar"

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickImprimir
        Try

            If Me.rbtDetallado.Checked Then
                ImprimirDetalle()
            Else
                If Me.dtpFechaFinal.Value.Ticks >= Me.dtpFechaInicial.Value.Ticks Then

                    If (Me.chkFacturado.Checked = True Or Me.chkTodos.Checked = True Or Me.chkCancelado.Checked = True Or Me.chkVigente.Checked = True) Then

                        Estatus()
                        Dim Reporte As Object = Nothing
                        Dim Tabla As New DataTable
                        Dim ConexionSql As New SqlClient.SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString)

                        ConexionSql.Open()
                        Dim comandoSql As New SqlClient.SqlCommand
                        comandoSql = ConexionSql.CreateCommand
                        Dim CadenaSql As String

                        If (Me.cmbClientes.SelectedIndex <= -1) Then
                            If (Estatus() <> "TODOS") Then
                                CadenaSql = "select * from dbo.VwReporteDeEmbarquesConcentrado where FechaEmbarque between '{0}' and  '{1}' and estatus = '{2}' "
                                CadenaSql = String.Format(CadenaSql, dtpFechaInicial.Value.Date.ToString("yyyyMMdd"), dtpFechaFinal.Value.AddDays(1).Date.ToString("yyyyMMdd"), Estatus())
                            Else
                                CadenaSql = "select * from dbo.VwReporteDeEmbarquesConcentrado where FechaEmbarque between '{0}'  and  '{1}' "
                                CadenaSql = String.Format(CadenaSql, dtpFechaInicial.Value.Date.ToString("yyyyMMdd"), dtpFechaFinal.Value.AddDays(1).Date.ToString("yyyyMMdd"))
                            End If
                        Else
                            If (Estatus() <> "TODOS") Then
                                CadenaSql = "select * from dbo.VwReporteDeEmbarquesConcentrado where IdCliente='{0}' and FechaEmbarque between '{1}'  and '{2}'  and Estatus='{3}' "
                                CadenaSql = String.Format(CadenaSql, Me.cmbClientes.SelectedValue, dtpFechaInicial.Value.Date.ToString("yyyyMMdd"), dtpFechaFinal.Value.AddDays(1).Date.ToString("yyyyMMdd"), Estatus())
                            Else
                                CadenaSql = "select * from dbo.VwReporteDeEmbarquesConcentrado where IdCliente='{0}' and FechaEmbarque between '{1}'  and '{2}'  "
                                CadenaSql = String.Format(CadenaSql, Me.cmbClientes.SelectedValue, dtpFechaInicial.Value.Date.ToString("yyyyMMdd"), dtpFechaFinal.Value.AddDays(1).Date.ToString("yyyyMMdd"))
                            End If
                        End If

                        comandoSql.CommandText = CadenaSql
                        Dim da As New SqlClient.SqlDataAdapter(CadenaSql, ConexionSql)

                        da.Fill(Tabla)

                        If Tabla.Rows.Count <> 0 Then
                            ConexionSql.Close()
                            Dim visualizar As New CN.PreVisualizarForm

                            If (Me.rbtConcentrado.Checked = True) Then
                                If Me.optCliente.Checked Then
                                    Reporte = New rptEmbarques2
                                ElseIf Me.optFactura.Checked Then
                                    Reporte = New rptEmbarquesporFactura
                                Else 'Salida
                                    Reporte = New rptEmbarquesPorReferencia
                                End If
                                Reporte.SetDataSource(Tabla)
                                Reporte.SetParameterValue("Empresa", Controlador.Sesion.MiEmpresa.Empnom)
                                Reporte.SetParameterValue("FechaInicio", Me.dtpFechaInicial.Value.ToShortDateString)
                                Reporte.SetParameterValue("Fechafin", Me.dtpFechaFinal.Value.ToShortDateString)
                                Reporte.SetParameterValue("Usuario", Controlador.Sesion.MiUsuario.Usrnomcom)
                                visualizar.Reporte = Reporte
                                visualizar.Text = "Reporte Concentrado de Embarques"
                            End If
                            visualizar.ShowDialog()
                        Else
                            MessageBox.Show("No se encontraron registros", Controlador.Sesion.MiEmpresa.Empnom)
                        End If
                    Else
                        MessageBox.Show("Seleccione el estatus que desea consultar", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Me.chkVigente.Checked = True
                    End If
                Else
                    MessageBox.Show("La Fecha Inicial no puede ser mayor a la Fecha Final", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.dtpFechaFinal.Value = DateTime.Now.ToShortDateString
                    Me.dtpFechaInicial.Value = DateTime.Now.ToShortDateString
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

#End Region

    Private Function ImprimirDetalle() As Boolean
        Try
            Dim Opcion As Integer
            If IsNothing(Me.cmbClientes.SelectedValue) Then
                Opcion = 2
            Else
                Opcion = 3
            End If

            Dim Tabla As New DataTable
            Dim ConexionSql As New SqlClient.SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString)

            ConexionSql.Open()
            Dim comandoSql As New SqlClient.SqlCommand
            comandoSql = ConexionSql.CreateCommand
            Dim CadenaSql As String
            'Dim TablaEmbarque As DataSet = Integralab.ORM.StoredProcedureCallerClasses.RetrievalProcedures.UspRptEmbarques(Opcion, "", Me.cmbClientes.SelectedValue, False)

            CadenaSql = "SELECT * FROM dbo.VwReportedeEmabarquesDetallado where FechaEmbarque between '{0}' and '{1}'  "

            If cmbClientes.SelectedValue IsNot Nothing Then
                CadenaSql &= " AND IdCliente = " & cmbClientes.SelectedValue.ToString
            End If

            CadenaSql = String.Format(CadenaSql, dtpFechaInicial.Value.Date.ToString("yyyyMMdd"), dtpFechaFinal.Value.AddDays(1).Date.ToString("yyyyMMdd"))
            comandoSql.CommandText = CadenaSql
            Dim da As New SqlClient.SqlDataAdapter(CadenaSql, ConexionSql)

            da.Fill(Tabla)

            Dim Reporte As New RegEmbarquesLoteCorte

            If Tabla.Rows.Count <> 0 Then
                ConexionSql.Close()

                Reporte.SetDataSource(tabla)

                Dim VerReporte As New FrmReportes

                VerReporte.CRV.ReportSource = Reporte
                VerReporte.ShowDialog()
            Else
                MessageBox.Show("No se encontro informacion en el criterio de busqueda especificado", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub TipoReporte_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtDetallado.CheckedChanged
        'grpRangoFechas.Enabled = Not rbtDetallado.Checked
        grpOrdenamiento.Enabled = Not rbtDetallado.Checked
        grpEstatus.Enabled = Not rbtDetallado.Checked
        grpTipoProducto.Enabled = Not rbtDetallado.Checked
    End Sub
End Class