Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class FrmRptTranferenciasRecibaLotesTotalizado

#Region "Miembros"

#End Region

#Region "Metodos"
    Public Sub Inicializar_Forma()
        Controlador.LlenarComboLotes(cmbLote, LoteClass.EstatusLote.TODOS)
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
        cmbLote.SelectedIndex = -1
        cmbLote.Text = "Seleccione el Lote"
        txtLote.ResetText()
        chkPorFecha.Checked = False
        dtpFechaInicial.Value = Now
        dtpFechaInicial.Enabled = False
        dtpFechaFinal.Value = Now.AddDays(1)
        dtpFechaFinal.Enabled = False
        chkVigentes.Checked = True
        chkCanceladas.Checked = True
        rbnFecha.Checked = True
    End Sub

    Public Sub Imprimir()
        If Me.Validate() Then
            Dim Estatus As EstatusChar = EstatusChar.TODOS
            Dim RangoDeFechas As RangoFechas = Nothing

            If chkVigentes.Checked And Not chkCanceladas.Checked Then
                Estatus = EstatusChar.VIGENTE
            ElseIf chkCanceladas.Checked And Not chkVigentes.Checked Then
                Estatus = EstatusChar.CANCELADO
            End If

            If chkPorFecha.Checked Then
                RangoDeFechas = New RangoFechas(dtpFechaInicial.Value.ToShortDateString, dtpFechaFinal.Value.AddDays(1).ToShortDateString)
            End If
            Controlador.ReporteTransferenciasRecibaLotesTotalizado(Estatus, rbnLote.Checked, cmbLote.SelectedValue, RangoDeFechas)
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

    Private Sub cmbLote_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbLote.KeyDown
        If e.KeyCode = Keys.F12 Then
            Controlador.LlenarComboLotes(cmbLote, LoteClass.EstatusLote.TODOS)
            txtLote.ResetText()
        End If
    End Sub

    Private Sub chkVigentesCanceladas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVigentes.CheckedChanged, chkCanceladas.CheckedChanged
        If chkCanceladas.Checked = False And chkVigentes.Checked = False Then
            chkVigentes.Checked = True
            chkCanceladas.Checked = True
        End If
    End Sub

    Private Sub txtLote_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLote.TextChanged
        For Each Item As LoteClass In cmbLote.Items
            If Item.IdLote.ToString() = sender.Text.Trim Then
                cmbLote.SelectedValue = Item.IdLote
                Exit Sub
            End If
        Next
        cmbLote.SelectedIndex = -1
        cmbLote.Text = "Seleccione el Lote"
    End Sub

    Private Sub cmbLote_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLote.SelectedValueChanged
        If sender.SelectedValue IsNot Nothing Then
            txtLote.Text = sender.SelectedValue
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
#End Region

End Class