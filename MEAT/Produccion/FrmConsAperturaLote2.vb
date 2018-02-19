Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = Integralab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CN = ClasesNegocio
Imports System.Data.SqlClient
Imports ClasesNegocio

Public Class FrmConsAperturaLote2

    Dim mFormPrincipal As FrmAperturaLoteCorte2
    Dim proveedores As New ProveedorCollectionClass

    Public Property FormPrincipal As FrmAperturaLoteCorte2
        Get
            Return (mFormPrincipal)
        End Get
        Set(value As FrmAperturaLoteCorte2)
            mFormPrincipal = value
        End Set
    End Property


    Private Sub txtIntroductor_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBusqueda.TextChanged
        Buscar()
    End Sub

    Private Sub Buscar()
        Dim sqlCon As New SqlClient.SqlConnection(HC.DbUtils.ActualConnectionString)

        Try
            'Dim cadenaConsulta As String = "SELECT usrProdRecepcionGanado.LoteRecepcion, usrProdRecepcionGanado.LoteEngorda, " & _
            '                                "usrProdRecepcionGanado.CantCabezas, usrProdRecepcionGanado.FechaRecepcion, " & _
            '                                 "
            'EXEC Usp_MSCLoteCortesCon 1, 0, 'kgn', '', '31/12/2017 00:00:00'
            Dim cadenaConsulta As String = "EXEC Usp_MSCLoteCortesCon 1, '{0}', '{1}', '{2}', '{3}'"
            cadenaConsulta = String.Format(cadenaConsulta, "", Me.txtBusqueda.Text, If(dtpFechaInicio.Enabled = True, Me.dtpFechaInicio.Value.ToShortDateString, String.Empty), Me.dtpFechaFinal.Value.ToShortDateString)

            'If Me.chkFiltrarFecha.Checked Then
            'cadenaConsulta &= String.Format(" usrProdRecepcionGanado.FechaRecepcion BETWEEN  '{0}' AND '{1}' AND ", Me.DtpFechaInicio.Value.ToShortDateString, Me.DtpFechaFin.Value.AddDays(1).ToShortDateString)
            'End If

            Dim sqlcom As New SqlCommand(cadenaConsulta, sqlCon)
            Dim adp As New SqlDataAdapter(sqlcom)

            Dim tb As New DataTable

            sqlCon.Open()
            adp.Fill(tb)
            'If tb.Rows.Count > 0 Then
            '    tb.Clear()
            '    cadenaConsulta = "consulta"
            '    sqlcom = New SqlCommand(cadenaConsulta, sqlCon)
            'End If



            Me.dvgAperturaLotes.DataSource = tb
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al consultar las recepciones", MsgBoxStyle.Critical, "Error")
#End If
        Finally
            If sqlCon.State = ConnectionState.Open Then
                sqlCon.Close()
            End If

            sqlCon.Dispose()
        End Try
    End Sub

    Private Sub chkFiltrarFecha_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkFiltrarFecha.CheckedChanged
        Me.GroupBox1.Enabled = Me.chkFiltrarFecha.Checked
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickLimpiar
        Me.txtBusqueda.Clear()
        Me.dtpFechaFinal.Value = Now
        Me.dtpFechaInicio.Value = Now
        Me.chkFiltrarFecha.Checked = False
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Buscar()
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBuscar
        Buscar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub

    Private Sub dvgAperturaLotes_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dvgAperturaLotes.CellDoubleClick

        If e.RowIndex > -1 And e.ColumnIndex > -1 Then
            Dim sqlCon As New SqlClient.SqlConnection(HC.DbUtils.ActualConnectionString)
            Dim ID_LoteCorte As String = dvgAperturaLotes.Rows(e.RowIndex).Cells("LoteCorte").Value.ToString()
            

            Try
                Dim cadenaConsulta As String = "EXEC Usp_MSCLoteCortesCon 1, '{0}', '{1}', '{2}', '{3}'"
                cadenaConsulta = String.Format(cadenaConsulta, ID_LoteCorte, Me.txtBusqueda.Text, If(dtpFechaInicio.Enabled = True, Me.dtpFechaInicio.Value.ToShortDateString, String.Empty), Me.dtpFechaFinal.Value.ToShortDateString)
                Using sqlcom As New SqlCommand(cadenaConsulta, sqlCon)
                    sqlCon.Open()
                    'Dim sqlcom As New SqlCommand(cadenaConsulta, sqlCon)
                    Dim adp As New SqlDataAdapter(sqlcom)
                    Dim Rs As SqlDataReader = sqlcom.ExecuteReader()
                    Rs.Read()
                    FormPrincipal.Limpiar()
                    FormPrincipal.txtLoteCorte.Text = ""
                    FormPrincipal.txtLoteCorte.Text = LTrim(Rs(0).ToString())
                    FormPrincipal.dtpFechaLoteCorte.Value = Rs(1).ToString()
                    FormPrincipal.txtFolioSacrificio.Text = Rs(2).ToString()
                    FormPrincipal.dtpFechaSacrificio.Value = Rs(3).ToString()
                    FormPrincipal.txtDiasCaducidad.Text = Rs(4).ToString()
                    FormPrincipal.dtpFechaCaducidad.Value = Rs(5).ToString()
                    FormPrincipal.txtObservaciones.Text = Rs(6).ToString()

                    FormPrincipal.txtNoPiezas.Text = Rs(7).ToString()
                    FormPrincipal.txtNoFactura.Text = Rs(8).ToString()
                    FormPrincipal.txtKilosRecibidos.Text = Rs(9).ToString()
                    FormPrincipal.txtImporte.Text = Rs(10).ToString()
                    FormPrincipal.CmbTipoGanado.SelectedValue = CInt((11).ToString())
                    FormPrincipal.txtUnidad.Text = Rs(12).ToString()
                    FormPrincipal.txtConductor.Text = Rs(13).ToString()
                    FormPrincipal.txtPlacas.Text = Rs(14).ToString()
                    FormPrincipal.txtHorasViaje.Text = Rs(15).ToString()

                    If String.IsNullOrEmpty(Rs(16).ToString()) = (Not True) Then
                        FormPrincipal.cmbProveedor.SelectedValue = CInt(Rs(16).ToString())
                    End If
                    If String.IsNullOrEmpty(Rs(17).ToString()) = (Not True) Then
                        FormPrincipal.CmbLugarCompra.SelectedValue = CInt(Rs(17).ToString())
                    End If
                    If String.IsNullOrEmpty(Rs(18).ToString()) = (Not True) Then
                        FormPrincipal.cmbComprador.SelectedValue = CInt(Rs(18).ToString())
                    End If
                    FormPrincipal.txtobserbacioneslote.Text = Rs(19).ToString()

                    Rs.Close()
                    'Llenamos los detalles el cual alimentamos de la tabla DetGasTrans
                    cadenaConsulta = "EXEC Usp_MSCLoteCortesCon 2, '{0}', '{1}', '{2}', '{3}'"
                    cadenaConsulta = String.Format(cadenaConsulta, ID_LoteCorte, String.Empty, String.Empty, String.Empty)

                    Dim sqlcomDetalle As SqlCommand = New SqlCommand(cadenaConsulta, sqlCon)

                    adp = New SqlDataAdapter(sqlcomDetalle)
                    Dim tb As New DataTable
                    adp.Fill(tb)
                    'tb.Select()

                    FormPrincipal.DgvConceptoGastos.DataSource = tb
                    FormPrincipal.DgvConceptoGastos.Refresh()

                    'FormPrincipal.DgvConceptoGastos.Data()

                    FormPrincipal.DgvConceptoGastos.AllowUserToAddRows = False

                    'FormPrincipal.DgvConceptoGastos.Columns.Remove("Fol_Recep")

                    FormPrincipal.calcularManual()
                    FormPrincipal.DgvConceptoGastos.ReadOnly = True
                    FormPrincipal.MEAToolBar1.MostrarNuevo = True
                    FormPrincipal.MEAToolBar1.HabilitarNuevo = True


                    sqlCon.Close()
                    Me.Close()


                End Using
            Catch ex As Exception
#If CONFIG = "Debug" Then
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al consultar las recepciones", MsgBoxStyle.Critical, "Error")
#End If
            Finally
                If sqlCon.State = ConnectionState.Open Then
                    sqlCon.Close()
                End If

                sqlCon.Dispose()
            End Try


        End If


        'dvgAperturaLotes.SelectedRows(0)

    End Sub

    Private Sub FrmConsAperturaLote2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dvgAperturaLotes.Columns.Remove("LoteSacrificio")
    End Sub
End Class