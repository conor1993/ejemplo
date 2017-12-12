Imports CN = ClasesNegocio

Public Class FrmBanDiarioMovimientos

    Private Sub FrmBanDiarioMovimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure

            tbEstados.StateBuscar = "001101101"
            tbEstados.StateLimpiar = ""
            tbEstados.StateCancelar = "100100011"
            tbEstados.StateNuevo = "011010001"
            tbEstados.StateGuardar = "100100011"
            tbEstados.StateBorrar = "100100011"
            tbEstados.StateEditar = "010011001"
            tbEstados.StateImprimir = ""
            tbEstados.StateSalir = ""

            Me.mtb.ToolBarButtonStatus = tbEstados
            Me.mtb.sbCambiarEstadoBotones("Cancelar")

            'Productos.Obtener(ClasesNegocio.CondicionEstatusEnum.TODOS)
            'Me.cmbProducto.DisplayMember = "Descripcion"
            'Me.cmbProducto.ValueMember = "IdProducto"
            'Me.cmbProducto.DataSource = Productos

            DtpFechaInicial.Value = Now.Date
            DtpFechaFinal.Value = Now.AddDays(1).Date
            'Me.Limpiar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        End Try
    End Sub

#Region "Métodos"

    Sub Habilitar()
        'Me.cmbProducto.Enabled = True
        Me.dtpFechaFinal.Enabled = True
        Me.dtpFechaInicial.Enabled = True
    End Sub

    Sub Deshabilitar()
        'Me.cmbProducto.Enabled = False
        Me.DtpFechaInicial.Enabled = False
        Me.DtpFechaFinal.Enabled = False
    End Sub

    Sub Limpiar()
        'Me.cmbProducto.SelectedValue = -1
        Me.dtpFechaFinal.Value = DateTime.Now.ToShortDateString
        Me.dtpFechaInicial.Value = DateTime.Now.ToShortDateString
    End Sub

#End Region


    Private Sub mtb_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles mtb.ButtonClick

    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Cursor = Cursors.WaitCursor

        Try
            If (Me.DtpFechaInicial.Value.Ticks > Me.DtpFechaFinal.Value.Ticks) Then
                MessageBox.Show("Rango de fechas no válido, intente de nuevo", "Error", MessageBoxButtons.OK)
                Me.DtpFechaFinal.Value = DateTime.Now.ToShortDateString
                Me.DtpFechaInicial.Value = DateTime.Now.ToShortDateString
                Me.DtpFechaInicial.Focus()
            Else

                Dim producto As Integer = -1
                Dim Reporte As New rptDiariodeBancos
                Dim Tabla As New DataTable

                Using ad As New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("dbo.BancosReportes", _
                       New SqlClient.SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString)))
                    ad.SelectCommand.CommandType = CommandType.StoredProcedure

                    With ad.SelectCommand.Parameters
                        .Add("@Opcion", SqlDbType.VarChar).Value = 2
                        .Add("@FechaInicial", SqlDbType.DateTime).Value = Me.DtpFechaInicial.Value.ToShortDateString
                        .Add("@FechaFinal", SqlDbType.DateTime).Value = Me.DtpFechaFinal.Value.AddDays(1).ToShortDateString
                        .Add("@Banco", SqlDbType.VarChar).Value = 0
                    End With

                    ad.SelectCommand.CommandTimeout = 120
                    ad.SelectCommand.Connection.Open()

                    ad.Fill(Tabla)
                    ad.SelectCommand.Connection.Close()

                End Using

                Reporte.SetDataSource(Tabla)
                Reporte.SetParameterValue("Empresa", Controlador.Sesion.MiEmpresa.Empnom)
                Reporte.SetParameterValue("FechaInicio", Me.DtpFechaInicial.Value.ToShortDateString)
                Reporte.SetParameterValue("Fechafin", Me.DtpFechaFinal.Value.ToShortDateString)
                Reporte.SetParameterValue("Usuario", Controlador.Sesion.MiUsuario.Usrnomcom)

                Dim visualizar As New CN.PreVisualizarForm

                visualizar.Reporte = Reporte
                visualizar.Text = "Reporte de Diario de Movimientos Bancarios"
                visualizar.ShowDialog()
            End If
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al imprimir, intente de nuevo", MsgBoxStyle.Critical, "Error")
#End If
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub
End Class