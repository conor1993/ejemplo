Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class FrmRptSalidasReciba

#Region "Miembros"

#End Region

#Region "Metodos"
    Public Sub Inicializar_Forma()
        Controlador.LlenarComboCorralesRecepcion(cmbCorralRecepcion)
        Controlador.LlenarComboCausasMuerte(cmbCausaMuerte)
        Limpiar()
        chkPorFecha.Checked = True
        dtpFechaInicial.Value = Now
        dtpFechaInicial.Enabled = True
        dtpFechaFinal.Value = Now.AddDays(1)
        dtpFechaFinal.Enabled = True
    End Sub
#End Region

#Region "Acciones_Menu"
    Public Sub Limpiar()
        cmbTipoSalida.SelectedIndex = 0
        cmbCorralRecepcion.SelectedIndex = -1
        cmbCorralRecepcion.Text = "Seleccione el Corral de Recepcion"
        cmbCausaMuerte.SelectedIndex = -1
        cmbCausaMuerte.Text = "Seleccione la Causa de Muerte"
        chkPorFecha.Checked = False
        dtpFechaInicial.Value = Now
        dtpFechaInicial.Enabled = False
        dtpFechaFinal.Value = Now.AddDays(1)
        dtpFechaFinal.Enabled = False
        chkVigentes.Checked = True
        chkCanceladas.Checked = True
        rbnFecha.Checked = True
        txtCorralRecepcion.ResetText()
        txtCausaMuerte.ResetText()
        rbnCausaMuerte.Enabled = False
        cmbCausaMuerte.Enabled = False
        txtCausaMuerte.Enabled = False
    End Sub

    Public Sub Imprimir()
        If Me.Validate() Then
            Dim Estatus As EstatusChar = EstatusChar.TODOS
            Dim RangoDeFechas As RangoFechas = Nothing
            Dim TipoSalida As ControladorGanadera.ReporteSalidasReciba
            Dim Orden As ControladorGanadera.ReporteSalidasOrden

            If chkVigentes.Checked And Not chkCanceladas.Checked Then
                Estatus = EstatusChar.VIGENTE
            ElseIf chkCanceladas.Checked And Not chkVigentes.Checked Then
                Estatus = EstatusChar.CANCELADO
            End If

            If chkPorFecha.Checked Then
                RangoDeFechas = New RangoFechas(dtpFechaInicial.Value.ToShortDateString, dtpFechaFinal.Value.AddDays(1).ToShortDateString)
            End If

            Select Case cmbTipoSalida.Text
                Case "SALIDAS A RASTRO"
                    TipoSalida = ControladorGanadera.ReporteSalidasReciba.Rastro
                Case "SALIDAS A VENTA"
                    TipoSalida = ControladorGanadera.ReporteSalidasReciba.Venta
                Case "SALIDAS POR MUERTE"
                    TipoSalida = ControladorGanadera.ReporteSalidasReciba.Muerte
                Case Else
                    TipoSalida = ControladorGanadera.ReporteSalidasReciba.Todos
            End Select

            If rbnFecha.Checked Then
                Orden = ControladorGanadera.ReporteSalidasOrden.Fecha
            ElseIf rbnCorral.Checked Then
                Orden = ControladorGanadera.ReporteSalidasOrden.CorralRecepcion
            ElseIf rbnCausaMuerte.Checked Then
                Orden = ControladorGanadera.ReporteSalidasOrden.CausaMuerte
            End If
            Controlador.ReporteSalidasDeReciba(CType(cmbCorralRecepcion.SelectedValue, String), CType(cmbCausaMuerte.SelectedValue, Integer), TipoSalida, Orden, RangoDeFechas, Estatus)
        End If
    End Sub

    Public Sub Salir()
        Me.AutoValidate = Windows.Forms.AutoValidate.Disable
        Me.Close()
    End Sub
#End Region

#Region "Eventos"
    Private Sub FrmRptMermas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Utilerias.RunControlException(Me, "Inicializar_Forma")
    End Sub

    Private Sub Acciones_Menu(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar, mtb.ClickImprimir, mtb.ClickSalir
        Utilerias.RunControlException(Me, e.Button.Text)
    End Sub

    Private Sub chkPorFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPorFecha.CheckedChanged
        dtpFechaInicial.Enabled = sender.Checked
        dtpFechaFinal.Enabled = sender.Checked
    End Sub

    Private Sub chkVigentesCanceladas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVigentes.CheckedChanged, chkCanceladas.CheckedChanged
        If chkCanceladas.Checked = False And chkVigentes.Checked = False Then
            chkVigentes.Checked = True
            chkCanceladas.Checked = True
        End If
    End Sub

    Private Sub dtpFechaInicialYFinal_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtpFechaInicial.Validating, dtpFechaFinal.Validating
        If dtpFechaInicial.Value > dtpFechaFinal.Value Then
            If chkPorFecha.Checked Then
                e.Cancel = True
                MessageBox.Show("La Fecha Inicial no debe ser mayor a la Fecha Final", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub cmbTipoSalida_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoSalida.SelectedValueChanged
        Select Case cmbTipoSalida.Text
            Case "SALIDAS POR MUERTE"
                rbnCausaMuerte.Enabled = True
                cmbCausaMuerte.Enabled = True
                txtCausaMuerte.Enabled = True
            Case Else
                rbnCausaMuerte.Enabled = False
                cmbCausaMuerte.Enabled = False
                txtCausaMuerte.Enabled = False
                txtCausaMuerte.ResetText()

                If rbnCausaMuerte.Checked Then
                    rbnFecha.Checked = True
                End If
                cmbCausaMuerte.SelectedIndex = -1
                cmbCausaMuerte.Text = "Seleccione la Causa de Muerte"
        End Select
    End Sub

    Private Sub cmbCorralRecepcion_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCorralRecepcion.KeyDown
        If e.KeyCode = Keys.F12 Then
            Controlador.LlenarComboCorralesRecepcion(cmbCorralRecepcion)
        End If
    End Sub

    Private Sub cmbCausaMuerte_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCausaMuerte.KeyDown
        If e.KeyCode = Keys.F12 Then
            Controlador.LlenarComboCausasMuerte(cmbCausaMuerte)
        End If
    End Sub

    Private Sub txtCausaMuerte_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCausaMuerte.TextChanged
        For Each Item As EC.McgcatCausasMuerteEntity In cmbCausaMuerte.Items
            If Item.IdCausaMuerte.ToString() = sender.Text.Trim Then
                cmbCausaMuerte.SelectedValue = Item.IdCausaMuerte
                Exit Sub
            End If
        Next
        cmbCausaMuerte.SelectedIndex = -1
        cmbCausaMuerte.Text = "Seleccione la Causa de Muerte"
    End Sub

    Private Sub cmbCausaMuerte_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCausaMuerte.SelectedValueChanged
        If sender.SelectedValue IsNot Nothing Then
            txtCausaMuerte.Text = sender.SelectedValue
        End If
    End Sub

    Private Sub txtCorralRecepcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCorralRecepcion.TextChanged
        For Each Item As EC.McecatCorralesCabEntity In cmbCorralRecepcion.Items
            If Item.IdCorral.ToString() = sender.Text.Trim Then
                cmbCorralRecepcion.SelectedValue = Item.IdCorral
                Exit Sub
            End If
        Next
        cmbCorralRecepcion.SelectedIndex = -1
        cmbCorralRecepcion.Text = "Seleccione el Corral de Recepcion"
    End Sub

    Private Sub cmbCorralRecepcion_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCorralRecepcion.SelectedValueChanged
        If sender.SelectedValue IsNot Nothing Then
            txtCorralRecepcion.Text = sender.SelectedValue
        End If
    End Sub
#End Region

End Class