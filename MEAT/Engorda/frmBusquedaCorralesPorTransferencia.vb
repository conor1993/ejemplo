Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class frmBusquedaCorralesporTransferencia

#Region "Miembros"

#End Region

#Region "Metodos"
    Public Sub Inicializar_Forma()
        dgvCorralesRecibaCab.AutoGenerateColumns = False
        dgvCorralRecibaDet.AutoGenerateColumns = False

        Controlador.LlenarComboLotes(cmbLoteSalida, LoteClass.EstatusLote.TODOS)
        Controlador.LlenarComboLotes(cmbLoteEntrada, LoteClass.EstatusLote.TODOS)

        Limpiar()
        Buscar()
    End Sub
#End Region

#Region "Acciones del Menu"
    Public Sub Buscar()
        Dim RangodeFechas As New RangoFechas(ultdtpFechaInicial.Value, ultdtpFechaFinal.Value)
        Dim Estatus As EstatusChar

        If chkVigentes.Checked And Not chkCancelados.Checked Then
            Estatus = EstatusChar.VIGENTE
        ElseIf chkCancelados.Checked And Not chkVigentes.Checked Then
            Estatus = EstatusChar.CANCELADO
        End If
        dgvCorralesRecibaCab.DataSource = Nothing
        dgvCorralRecibaDet.DataSource = Nothing
        dgvCorralesRecibaCab.DataSource = Controlador.ObtenerSalidasDeCorralporTransferencia(txtFolio.Text, RangodeFechas, Estatus, txtArete.Text.Trim, cmbLoteSalida.SelectedItem, cmbLoteEntrada.SelectedItem)
    End Sub

    Public Sub Limpiar()
        txtFolio.ResetText()
        txtArete.ResetText()
        ultdtpFechaInicial.Value = Now.AddDays(-8)
        ultdtpFechaFinal.Value = Nothing
        dgvCorralesRecibaCab.DataSource = Nothing
        dgvCorralRecibaDet.DataSource = Nothing
        chkVigentes.Checked = True
        chkCancelados.Checked = False
        cmbLoteSalida.SelectedIndex = -1
        cmbLoteSalida.Text = "Seleccione el Lote de Salida"
        cmbLoteEntrada.SelectedIndex = -1
        cmbLoteEntrada.Text = "Seleccione el Lote de Entrada"
    End Sub

    Public Sub Salir()
        Me.Close()
    End Sub
#End Region

#Region "Eventos"
    Private Sub frmBusquedaCorralesReciba_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Utilerias.RunControlException(Me, "Inicializar_Forma")
    End Sub

    Private Sub Acciones_Menu(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar, mtb.ClickBuscar, mtb.ClickCancelar, mtb.ClickEditar, mtb.ClickGuardar, mtb.ClickImprimir, mtb.ClickLimpiar, mtb.ClickNuevo, mtb.ClickSalir
        Utilerias.RunControlException(Me, e.Button.Text)
    End Sub

    Private Sub Estatus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVigentes.CheckedChanged, chkCancelados.CheckedChanged
        If Not chkVigentes.Checked And Not chkCancelados.Checked Then
            chkVigentes.Checked = True
            chkCancelados.Checked = True
        End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub dgvCorralesRecibaCab_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvCorralesRecibaCab.SelectionChanged
        If dgvCorralesRecibaCab.CurrentRow IsNot Nothing Then
            dgvCorralRecibaDet.DataSource = CType(dgvCorralesRecibaCab.CurrentRow.DataBoundItem, SalidaGanadoCabeceroClass).Detalles
        End If
    End Sub

    Private Sub dgvCorralesRecibaCab_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCorralesRecibaCab.CellDoubleClick
        If e.RowIndex >= 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub dgvCorralesRecibaCab_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvCorralesRecibaCab.DataError

    End Sub

    Private Sub dgvCorralRecibaDet_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvCorralRecibaDet.DataError

    End Sub
#End Region

End Class