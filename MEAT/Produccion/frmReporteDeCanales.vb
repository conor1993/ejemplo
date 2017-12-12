Imports System.Data.SqlClient
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class frmReporteDeCanales

#Region "Metodos"
    Private Sub Imprimir()
        Try
            Dim tvw As New TC.VwReporteCanalesTypedView
            Dim filtro As New OC.PredicateExpression

            If Me.txtFolioSacrificio.Text.Trim = "F3 PARA BUSCAR" Then
                If cmbIntroductor.SelectedIndex > -1 Then
                    filtro.Add(HC.VwReporteCanalesFields.IdCliente = cmbIntroductor.SelectedValue)
                End If

                If Me.chkFiltrar.Checked Then
                    filtro.Add(New OC.FieldBetweenPredicate(HC.VwReporteCanalesFields.Fecha, Me.dtFechaInicial.Value.ToString("dd/MM/yyyy"), Me.dtFechaFinal.Value.AddDays(1).ToString("dd/MM/yyyy")))
                End If

                If Not (Me.chkCorte.Checked And Me.chkEmbarcado.Checked And Me.chkExistentes.Checked) Then
                    Dim filtroEst As New OC.PredicateExpression

                    If Me.chkExistentes.Checked Then
                        filtroEst.AddWithOr(HC.VwReporteCanalesFields.Estatus = "V")
                    End If

                    If Me.chkEmbarcado.Checked Then
                        filtroEst.AddWithOr(HC.VwReporteCanalesFields.Estatus = "E")
                    End If

                    If Me.chkCorte.Checked Then
                        filtroEst.AddWithOr(HC.VwReporteCanalesFields.Estatus = "T")
                    End If

                    filtro.Add(filtroEst)
                End If
            Else
                filtro.Add(HC.VwReporteCanalesFields.FolioSacrificio = Me.txtFolioSacrificio.Text)
            End If

            tvw.Fill(0, Nothing, False, filtro)

            Dim rep As New rptRecepcionCanales
            Dim vent As New ClasesNegocio.PreVisualizarForm

            vent.Text = "Reporte de Canales"
            rep.SetDataSource(CType(tvw, Object))
            rep.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
            rep.SetParameterValue(1, "Producción/Reportes/Canales")
            rep.SetParameterValue(2, Controlador.Sesion.MiUsuario.Usrnomcom)
            vent.Reporte = rep
            vent.StartPosition = FormStartPosition.CenterScreen
            vent.WindowState = FormWindowState.Maximized

            vent.ShowDialog()
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al consultar los canales", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub LlenarIntroducto()
        Dim sqlCon As New SqlConnection(IntegraLab.ORM.HelperClasses.DbUtils.ActualConnectionString)

        Try
            Dim consulta As String = "SELECT IdCliente, Nombre, Estatus FROM MFacCatClientes WHERE (Estatus = 1 and Introductor=1) ORDER BY Nombre"
            Dim tb As New DataTable
            Dim ad As New SqlDataAdapter(New SqlCommand(consulta, sqlCon))

            sqlCon.Open()
            ad.Fill(tb)

            Me.cmbIntroductor.DataSource = tb
            Me.cmbIntroductor.DisplayMember = "Nombre"
            Me.cmbIntroductor.ValueMember = "IdCliente"

            Me.cmbIntroductor.SelectedIndex = -1
            Me.cmbIntroductor.Text = "Seleccione un introductor.."
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al consultar los introductores", MsgBoxStyle.Critical, "Error")
#End If
        Finally
            If sqlCon.State = ConnectionState.Open Then
                sqlCon.Close()
            End If
        End Try
    End Sub

    Private Sub Limpiar()
        Me.txtCodigoIntroductor.Clear()
        Me.cmbIntroductor.SelectedIndex = -1
        Me.cmbIntroductor.Text = "Seleccionar un introductor"
        Me.txtFolioSacrificio.Text = "F3 PARA BUSCAR"
        Me.txtFolioSacrificio.ForeColor = Color.Gray
        Me.dtFechaFinal.Value = Now
        Me.dtFechaInicial.Value = Now
        Me.lblTitulo.Focus()
    End Sub
#End Region

#Region "Evento"
    Private Sub frmReporteDeCanales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LlenarIntroducto()
        Limpiar()
    End Sub

    Private Sub chkExistentes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkExistentes.CheckedChanged
        If Not Me.chkCorte.Checked And Not Me.chkEmbarcado.Checked And Not Me.chkExistentes.Checked Then
            Me.chkExistentes.Checked = True
            Me.chkEmbarcado.Checked = True
            Me.chkCorte.Checked = True
        End If
    End Sub

    Private Sub chkCorte_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCorte.CheckedChanged
        If Not Me.chkCorte.Checked And Not Me.chkEmbarcado.Checked And Not Me.chkExistentes.Checked Then
            Me.chkExistentes.Checked = True
            Me.chkEmbarcado.Checked = True
            Me.chkCorte.Checked = True
        End If
    End Sub

    Private Sub chkEmbarcado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEmbarcado.CheckedChanged
        If Not Me.chkCorte.Checked And Not Me.chkEmbarcado.Checked And Not Me.chkExistentes.Checked Then
            Me.chkExistentes.Checked = True
            Me.chkEmbarcado.Checked = True
            Me.chkCorte.Checked = True
        End If
    End Sub
#End Region

    Private Sub cmbIntroductor_ActualizarCombo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbIntroductor.ActualizarCombo
        Me.LlenarIntroducto()
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickImprimir
        Imprimir()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub txtFolioSacrificio_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFolioSacrificio.GotFocus
        If Me.txtFolioSacrificio.Text = "F3 PARA BUSCAR" Then
            Me.txtFolioSacrificio.Clear()
            Me.txtFolioSacrificio.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtFolioSacrificio_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFolioSacrificio.LostFocus
        If Me.txtFolioSacrificio.Text.Trim = "" Then
            Me.txtFolioSacrificio.Text = "F3 PARA BUSCAR"
            Me.txtFolioSacrificio.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtFolioSacrificio_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtFolioSacrificio.PreviewKeyDown
        If e.KeyCode = Keys.F3 Then
            Dim ventana As New ReporteRegistroSacrificio

            ventana.Text = "SELECCIONE UN LOTE DE SACRIFICIO PARA EL REPORTE"
            ventana.Label17.Text = "SELECCIONE UN LOTE DE SACRIFICIO PARA EL REPORTE"
            ventana.BtnImprimir.Visible = False
            ventana.Busqueda = True

            If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtFolioSacrificio.Text = ventana.DgvSacrificios.SelectedRows(0).Cells(ventana.LoteSacrificio.Index).Value
            End If
        End If
    End Sub

    Private Sub cmbIntroductor_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbIntroductor.PreviewKeyDown
        If e.KeyCode = Keys.F12 Then
            Me.LlenarIntroducto()
        End If
    End Sub
End Class