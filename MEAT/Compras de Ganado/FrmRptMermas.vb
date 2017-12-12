Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class FrmRptMermas

#Region "Miembros"

#End Region

#Region "Metodos"
    Public Sub Inicializar_Forma()
        Controlador.LlenarComboProveedores(cmbProveedor, True)
        Controlador.LlenarComboCompradoresDeGanado(cmbComisionista)
        Controlador.LlenarComboLugaresDeCompra(cmbLugarDeCompra)
        Controlador.LlenarComboChoferes(cmbChofer)
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
        cmbProveedor.SelectedIndex = -1
        cmbProveedor.Text = "Seleccione el Proveedor"
        cmbComisionista.SelectedIndex = -1
        cmbComisionista.Text = "Seleccione el Comisionista"
        cmbLugarDeCompra.SelectedIndex = -1
        cmbLugarDeCompra.Text = "Seleccione el Lugar de Compra"
        cmbChofer.SelectedIndex = -1
        cmbChofer.Text = "Seleccione el Chofer"
        txtProveedor.ResetText()
        txtComisionista.ResetText()
        txtLugarDeCompra.ResetText()
        txtChofer.ResetText()
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
            Dim Agrupacion As ControladorGanadera.ReporteMermasAgrupacion
            Dim RangoDeFechas As RangoFechas = Nothing

            If chkVigentes.Checked And Not chkCanceladas.Checked Then
                Estatus = EstatusChar.VIGENTE
            ElseIf chkCanceladas.Checked And Not chkVigentes.Checked Then
                Estatus = EstatusChar.CANCELADO
            End If

            If rbnChofer.Checked Then
                Agrupacion = ControladorGanadera.ReporteMermasAgrupacion.Chofer
            ElseIf rbnFecha.Checked Then
                Agrupacion = ControladorGanadera.ReporteMermasAgrupacion.Fecha
            ElseIf rbnLugarCompra.Checked Then
                Agrupacion = ControladorGanadera.ReporteMermasAgrupacion.Lugar_de_Compra
            ElseIf rbnProveedor.Checked Then
                Agrupacion = ControladorGanadera.ReporteMermasAgrupacion.Proveedor
            ElseIf rbnComprador.Checked Then
                Agrupacion = ControladorGanadera.ReporteMermasAgrupacion.Comprador
            End If

            If chkPorFecha.Checked Then
                RangoDeFechas = New RangoFechas(dtpFechaInicial.Value.ToShortDateString, dtpFechaFinal.Value.AddDays(1).ToShortDateString)
            End If
            Controlador.ReporteMermas(Estatus, Agrupacion, cmbProveedor.SelectedValue, cmbComisionista.SelectedValue, cmbLugarDeCompra.SelectedValue, cmbChofer.SelectedValue, RangoDeFechas)
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

    Private Sub cmbProveedor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbProveedor.KeyDown
        If e.KeyCode = Keys.F12 Then
            Controlador.LlenarComboProveedores(sender, True)
            txtProveedor.ResetText()
        End If
    End Sub

    Private Sub cmbComisionista_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbComisionista.KeyDown
        If e.KeyCode = Keys.F12 Then
            Controlador.LlenarComboCompradoresDeGanado(sender)
            txtComisionista.ResetText()
        End If
    End Sub

    Private Sub cmbLugarDeCompra_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbLugarDeCompra.KeyDown
        If e.KeyCode = Keys.F12 Then
            Controlador.LlenarComboLugaresDeCompra(sender)
            txtLugarDeCompra.ResetText()
        End If
    End Sub

    Private Sub cmbChofer_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbChofer.KeyDown
        If e.KeyCode = Keys.F12 Then
            Controlador.LlenarComboChoferes(sender)
            txtChofer.ResetText()
        End If
    End Sub

    Private Sub chkVigentesCanceladas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVigentes.CheckedChanged, chkCanceladas.CheckedChanged
        If chkCanceladas.Checked = False And chkVigentes.Checked = False Then
            chkVigentes.Checked = True
            chkCanceladas.Checked = True
        End If
    End Sub

    Private Sub txtValidacionEntrada_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProveedor.KeyPress, txtLugarDeCompra.KeyPress, txtComisionista.KeyPress, txtChofer.KeyPress
        Utilerias.ValidarEntradaNumerosEnteros(sender, e)
    End Sub

    Private Sub txtProveedor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProveedor.TextChanged
        For Each Item As ProveedorClass In cmbProveedor.Items
            If Item.Codigo.ToString() = sender.Text.Trim Then
                cmbProveedor.SelectedValue = Item.Codigo
                Exit Sub
            End If
        Next
        cmbProveedor.SelectedIndex = -1
        cmbProveedor.Text = "Seleccione el Proveedor"
    End Sub

    Private Sub cmbProveedor_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProveedor.SelectedValueChanged
        If sender.SelectedValue IsNot Nothing Then
            txtProveedor.Text = sender.SelectedValue
        End If
    End Sub

    Private Sub txtComisionista_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtComisionista.TextChanged
        For Each Item As DataRowView In cmbComisionista.Items
            If Item("IdComprador").ToString() = sender.Text.Trim Then
                cmbComisionista.SelectedValue = Item("IdComprador")
                Exit Sub
            End If
        Next
        cmbComisionista.SelectedIndex = -1
        cmbComisionista.Text = "Seleccione el Comisionista"
    End Sub

    Private Sub cmbComisionista_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbComisionista.SelectedValueChanged
        If sender.SelectedValue IsNot Nothing Then
            txtComisionista.Text = sender.SelectedValue
        End If
    End Sub

    Private Sub txtLugarDeCompra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLugarDeCompra.TextChanged
        For Each Item As DataRowView In cmbLugarDeCompra.Items
            If Item("IdLugarCompra").ToString() = sender.Text.Trim Then
                cmbLugarDeCompra.SelectedValue = Item("IdLugarCompra")
                Exit Sub
            End If
        Next
        cmbLugarDeCompra.SelectedIndex = -1
        cmbLugarDeCompra.Text = "Seleccione el Lugar de Compra"
    End Sub

    Private Sub cmbLugarDeCompra_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLugarDeCompra.SelectedValueChanged
        If sender.SelectedValue IsNot Nothing Then
            txtLugarDeCompra.Text = sender.SelectedValue
        End If
    End Sub

    Private Sub txtChofer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtChofer.TextChanged
        For Each Item As DataRowView In cmbChofer.Items
            If Item("IdChofer").ToString() = sender.Text.Trim Then
                cmbChofer.SelectedValue = Item("IdChofer")
                Exit Sub
            End If
        Next
        cmbChofer.SelectedIndex = -1
        cmbChofer.Text = "Seleccione el Chofer"
    End Sub

    Private Sub cmbChofer_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbChofer.SelectedValueChanged
        If sender.SelectedValue IsNot Nothing Then
            txtChofer.Text = sender.SelectedValue
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