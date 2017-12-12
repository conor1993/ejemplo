Imports CN = ClasesNegocio

Public Class FrmBanReporteChequesBeneficiarios
    Dim Beneficiarios As New CN.BeneficiarioCollectionClass
    Dim CodigoBeneficiario As Integer
    Dim Estatus As Integer

    Private Sub FrmBanReporteChequesBeneficiarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

            Beneficiarios.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            Me.cmbBeneficiario.DisplayMember = "Beneficiario"
            Me.cmbBeneficiario.ValueMember = "Codigo"
            Me.cmbBeneficiario.DataSource = Beneficiarios

            Me.Limpiar()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        End Try
    End Sub

#Region "Métodos"

    Sub Habilitar()
        Me.DtpFechaFinal.Enabled = True
        Me.DtpFechaInicial.Enabled = True
    End Sub

    Sub Deshabilitar()
        Me.DtpFechaInicial.Enabled = False
        Me.DtpFechaFinal.Enabled = False
    End Sub

    Sub Limpiar()
        Me.cmbBeneficiario.SelectedValue = -1
        Me.cmbBeneficiario.Text = "Seleccione un beneficiario..."

        Me.DtpFechaInicial.Value = Now.Date.AddDays(-1) 'DateTime.Now.ToShortDateString
        Me.DtpFechaFinal.Value = Now.Date 'DateTime.Now.ToShortDateString
        Me.rdbNombre.Checked = True
        Me.chkVigente.Checked = True
    End Sub

#End Region


#Region "Tool Bar"

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Cursor = Cursors.WaitCursor
        Try
            If (Me.DtpFechaInicial.Value > Me.DtpFechaFinal.Value) Then
                MessageBox.Show("Rango de fechas no válido, intente de nuevo", "Error", MessageBoxButtons.OK)
                Me.DtpFechaInicial.Value = Now.Date.AddDays(-1)
                Me.DtpFechaFinal.Value = Now.Date
                Me.DtpFechaInicial.Focus()
            Else

                Dim producto As Integer = -1
                Dim Reporte As New rptChequesPorBeneficiarios
                Dim Tabla As New DataTable
                Dim Tabla2 As DataTable

                FiltroEstatus()

                Using ad As New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("dbo.BancosChequeBeneficiarios", _
                       New SqlClient.SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString)))
                    ad.SelectCommand.CommandType = CommandType.StoredProcedure

                    With ad.SelectCommand.Parameters
                        .Add("@Opcion", SqlDbType.VarChar).Value = 1
                        .Add("@FechaInicial", SqlDbType.DateTime).Value = Me.DtpFechaInicial.Value.ToShortDateString
                        .Add("@FechaFinal", SqlDbType.DateTime).Value = Me.DtpFechaFinal.Value.AddDays(1).ToShortDateString
                        .Add("@Banco", SqlDbType.VarChar).Value = 0
                        .Add("@Beneficiario", SqlDbType.Int).Value = CodigoBeneficiario
                        .Add("@Estatus", SqlDbType.Int).Value = Estatus
                    End With

                    ad.SelectCommand.CommandTimeout = 120
                    ad.SelectCommand.Connection.Open()

                    ad.Fill(Tabla)
                    ad.SelectCommand.Connection.Close()

                End Using

                If Me.rdbFecha.Checked = True Then
                    Tabla2 = Tabla.Clone
                    Dim dr() As DataRow = Tabla.Select("", "fec_mov asc")
                    For i As Integer = 0 To dr.Length - 1
                        Tabla2.ImportRow(dr(i))
                    Next
                Else
                    Tabla2 = Tabla
                End If

                Reporte.SetDataSource(Tabla2)
                Reporte.SetParameterValue("Empresa", Controlador.Sesion.MiEmpresa.Empnom)
                Reporte.SetParameterValue("FechaInicio", Me.DtpFechaInicial.Value.ToShortDateString)
                Reporte.SetParameterValue("Fechafin", Me.DtpFechaFinal.Value.ToShortDateString)
                Reporte.SetParameterValue("Usuario", Controlador.Sesion.MiUsuario.Usrnomcom)
                Reporte.SetParameterValue("Modulo", "Bancos\Reportes\Cheques por Beneficiarios")

                Dim visualizar As New CN.PreVisualizarForm
                visualizar.Reporte = Reporte
                visualizar.Text = "Reporte de Cheques por Beneficiarios"
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

#End Region

    Private Sub cmbBeneficiario_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBeneficiario.SelectedValueChanged
        Me.txtCodigoBeneficiario.Text = CStr(Me.cmbBeneficiario.SelectedValue)
        If Me.txtCodigoBeneficiario.Text <> "" Then
            CodigoBeneficiario = Integer.Parse((Me.txtCodigoBeneficiario.Text))
        End If
    End Sub

    Private Sub txtCodigoBeneficiario_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoBeneficiario.TextChanged
        If Me.txtCodigoBeneficiario.Text = "" Then
            Me.cmbBeneficiario.SelectedValue = -1
            Me.cmbBeneficiario.Text = "Seleccione un beneficiario..."
            CodigoBeneficiario = 0
        End If
    End Sub

    Sub FiltroEstatus()
        If Me.chkVigente.Checked = True And Me.chkCancelado.Checked = True Then
            Estatus = -1
        Else
            If Me.chkVigente.Checked = True Then
                Estatus = 1
            Else
                Estatus = 0
            End If
        End If
    End Sub
End Class