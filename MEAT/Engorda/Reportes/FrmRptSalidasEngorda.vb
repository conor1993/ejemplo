Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class FrmRptSalidasEngorda

#Region "Miembros"

#End Region

#Region "Metodos"
    Public Sub Inicializar_Forma()
        Controlador.LlenarComboLotes(cmbLote)
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
        cmbLote.SelectedIndex = -1
        cmbLote.Text = "Seleccione el Lote"
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
        txtLote.ResetText()
        txtCausaMuerte.ResetText()
        rbnCausaMuerte.Enabled = False
        cmbCausaMuerte.Enabled = False
        txtCausaMuerte.Enabled = False
    End Sub

    Public Sub Imprimir()
        If Me.Validate() Then
            Dim Estatus As EstatusChar = EstatusChar.TODOS
            Dim RangoDeFechas As RangoFechas = Nothing
            Dim TipoSalida As ControladorGanadera.ReporteSalidasEngorda
            Dim Orden As ControladorGanadera.ReporteSalidasOrden

            If chkVigentes.Checked And Not chkCanceladas.Checked Then
                Estatus = EstatusChar.VIGENTE
            ElseIf chkCanceladas.Checked And Not chkVigentes.Checked Then
                Estatus = EstatusChar.CANCELADO
            End If

            If chkPorFecha.Checked Then
                RangoDeFechas = New RangoFechas(dtpFechaInicial.Value.Date, dtpFechaFinal.Value.Date.AddDays(1).AddTicks(-1))
            End If

            Select Case cmbTipoSalida.Text
                Case "SALIDAS A RASTRO"
                    TipoSalida = ControladorGanadera.ReporteSalidasEngorda.Rastro
                Case "SALIDAS A VENTA"
                    TipoSalida = ControladorGanadera.ReporteSalidasEngorda.Venta
                Case "SALIDAS POR MUERTE"
                    TipoSalida = ControladorGanadera.ReporteSalidasEngorda.Muerte
                Case "SALIDAS POR TRANSFERENCIAS"
                    TipoSalida = ControladorGanadera.ReporteSalidasEngorda.Transferencia
                Case Else
                    TipoSalida = ControladorGanadera.ReporteSalidasEngorda.Todos
            End Select

            If rbnFecha.Checked Then
                Orden = ControladorGanadera.ReporteSalidasOrden.Fecha
            ElseIf rbnCorral.Checked Then
                Orden = ControladorGanadera.ReporteSalidasOrden.CorralRecepcion
            ElseIf rbnCausaMuerte.Checked Then
                Orden = ControladorGanadera.ReporteSalidasOrden.CausaMuerte
            End If
            Controlador.ReporteSalidasDeEngorda(CType(cmbLote.SelectedValue, Integer), CType(cmbCausaMuerte.SelectedValue, Integer), TipoSalida, Orden, RangoDeFechas, Estatus)
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
        Dim Control As CheckBox = CType(sender, CheckBox)

        dtpFechaInicial.Enabled = Control.Checked
        dtpFechaFinal.Enabled = Control.Checked
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

    Private Sub cmbLote_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbLote.KeyDown
        If e.KeyCode = Keys.F12 Then
            Controlador.LlenarComboLotes(cmbLote)
        End If
    End Sub

    Private Sub cmbCausaMuerte_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCausaMuerte.KeyDown
        If e.KeyCode = Keys.F12 Then
            Controlador.LlenarComboCausasMuerte(cmbCausaMuerte)
        End If
    End Sub

    Private Sub txtCausaMuerte_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCausaMuerte.TextChanged
        Dim Control As TextBox = CType(sender, TextBox)

        For Each Item As EC.McgcatCausasMuerteEntity In cmbCausaMuerte.Items
            If Item.IdCausaMuerte.ToString() = Control.Text.Trim Then
                cmbCausaMuerte.SelectedValue = Item.IdCausaMuerte
                Exit Sub
            End If
        Next
        cmbCausaMuerte.SelectedIndex = -1
        cmbCausaMuerte.Text = "Seleccione la Causa de Muerte"
    End Sub

    Private Sub cmbCausaMuerte_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCausaMuerte.SelectedValueChanged
        Dim Control As ComboBox = CType(sender, ComboBox)

        If Control.SelectedValue IsNot Nothing Then
            txtCausaMuerte.Text = Control.SelectedValue.ToString
        End If
    End Sub

    Private Sub txtLote_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLote.TextChanged
        Dim Control As TextBox = CType(sender, TextBox)

        For Each Item As LoteClass In cmbLote.Items
            If Item.IdCorral.ToString() = Control.Text.Trim Then
                cmbLote.SelectedValue = Item.IdLote
                Exit Sub
            End If
        Next
        cmbLote.SelectedIndex = -1
        cmbLote.Text = "Seleccione el Lote"
    End Sub

    Private Sub cmbLote_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLote.SelectedValueChanged
        Dim Control As ComboBox = CType(sender, ComboBox)

        If Control.SelectedValue IsNot Nothing Then
            txtLote.Text = Control.SelectedValue.ToString
        End If
    End Sub
#End Region

End Class