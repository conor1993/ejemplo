Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class frmBusquedaPagosCheDev

#Region "Miembros"

    Private Modo As Comportamiento

    Enum Comportamiento
        Busqueda
        Reporte
    End Enum

#End Region

#Region "Constructores"

    Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Modo = Comportamiento.Reporte
    End Sub

    Sub New(ByVal _Modo As Comportamiento)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Modo = _Modo
    End Sub

#End Region

#Region "Metodos"

    Public Sub Iniciarlizar_Forma()
        If Modo = Comportamiento.Reporte Then
            lblTitulo.Text = "REPORTE DE PAGOS DE CHEQUES DEVUELTOS"
            Me.Text = lblTitulo.Text
            Me.Height -= btnAceptar.Size.Height * 1.5
        Else
            mtb.MostrarImprimir = False
        End If

        dgvCabecero.AutoGenerateColumns = False
        dgvDetalle.AutoGenerateColumns = False
        Controlador.LlenarComboClientes(ultcmbCliente, EstatusChar.VIGENTE)
        Limpiar()
        txtFolio.Focus()
    End Sub

#End Region

#Region "Acciones del Menu"

    Public Sub Limpiar()
        ultcmbCliente.Value = Nothing
        ultdtpFechaInicial.Value = Nothing
        ultdtpFechaFinal.Value = Nothing
        txtFolio.ResetText()
        txtNoCheque.ResetText()
        txtObservaciones.ResetText()
        chkVigente.Checked = True
        chkCancelado.Checked = True
    End Sub

    Public Function Buscar() As PagoCheDevueltoCabCollectionClass
        Dim IdCliente As Nullable(Of Integer)

        If ultcmbCliente.SelectedItem IsNot Nothing Then
            IdCliente = ultcmbCliente.SelectedItem.DataValue
        End If
        Buscar = Controlador.ObtenerPagosChequesDevueltos(ultdtpFechaInicial.Value, ultdtpFechaFinal.Value, chkVigente.Checked, chkCancelado.Checked, IdCliente, txtFolio.Text.Trim, txtNoCheque.Text.Trim, txtObservaciones.Text.Trim)
        dgvCabecero.DataSource = Buscar
        Return Buscar
    End Function

    Public Sub Imprimir()
        Dim Pagos As New PagoCheDevueltoCabCollectionClass()

        If dgvCabecero.Rows.Count = 0 Then
            Buscar()
        End If

        For Each Fila As DataGridViewRow In Me.dgvCabecero.Rows
            Pagos.Add(CType(Fila.DataBoundItem, PagoCheDevueltoCabClass))
        Next
        Controlador.ReportePagosCheDevueltos(Pagos, True)
    End Sub

    Public Sub Salir()
        Me.Close()
    End Sub

#End Region

#Region "Eventos"

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.dgvCabecero.SelectedRows.Count > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub frmBusquedaPagosCheDev_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Utilerias.RunControlException(Me, "Iniciarlizar_Forma")
    End Sub

    Private Sub mtb_Acciones(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBuscar, mtb.ClickLimpiar, mtb.ClickImprimir, mtb.ClickSalir
        Utilerias.RunControlException(Me, e.Button.Text)
    End Sub

    Private Sub Estatus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVigente.CheckedChanged, chkCancelado.CheckedChanged
        If Not (chkVigente.Checked OrElse chkCancelado.Checked) Then
            chkCancelado.Checked = True
            chkVigente.Checked = True
        End If
    End Sub

    Private Sub Controles_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFolio.KeyPress, txtNoCheque.KeyPress, ultcmbCliente.KeyPress, txtObservaciones.KeyPress, ultdtpFechaInicial.KeyPress, ultdtpFechaFinal.KeyPress, chkVigente.KeyPress, chkCancelado.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            SendKeys.Send(Chr(Keys.Tab))
        End If
    End Sub

    Private Sub dgvCabecero_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvCabecero.SelectionChanged
        If dgvCabecero.SelectedRows.Count > 0 Then
            dgvDetalle.DataSource = CType(dgvCabecero.SelectedRows(0).DataBoundItem, PagoCheDevueltoCabClass).Detalles
        End If
    End Sub

    Private Sub dgvCabecero_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCabecero.CellDoubleClick
        If e.RowIndex >= 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

#End Region

End Class