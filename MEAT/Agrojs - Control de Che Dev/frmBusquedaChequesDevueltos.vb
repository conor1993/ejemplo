Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class frmBusquedaChequesDevueltos

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

    Public Sub Inicializar_Forma()
        If Modo = Comportamiento.Reporte Then
            lblTitulo.Text = "REPORTE DE CHEQUES DEVUELTOS"
            Me.Text = lblTitulo.Text
            Me.Height -= btnAceptar.Size.Height * 1.5
        Else
            mtb.MostrarImprimir = False
            chkReporteDetallado.Visible = False
        End If

        dgvChequesDevueltos.AutoGenerateColumns = False
        Controlador.LlenarComboBancos(ultcmbBanco, CondicionEnum.ACTIVOS)
        Controlador.LlenarComboClientes(ultcmbCliente, EstatusChar.VIGENTE)
        Limpiar()
        txtNoCheque.Focus()
    End Sub

#End Region

#Region "Acciones del Menu"

    Public Sub Limpiar()
        ultcmbBanco.Value = Nothing
        ultcmbCliente.Value = Nothing
        txtNoCheque.ResetText()
        ultdtpFechaInicial.Value = Nothing
        ultdtpFechaFinal.Value = Nothing
        txtObservaciones.ResetText()
        chkVigente.Checked = True
        chkCancelado.Checked = True
        chkAbonado.Checked = True
        chkPagado.Checked = True
    End Sub

    Public Function Buscar() As ChequeDevueltoCollectionClass
        Dim IdBanco As Nullable(Of Integer)
        Dim IdCliente As Nullable(Of Integer)

        If ultdtpFechaInicial.Value IsNot Nothing AndAlso ultdtpFechaFinal.Value IsNot Nothing Then
            If ultdtpFechaInicial.Value.Ticks > ultdtpFechaFinal.Value.Ticks Then
                MessageBox.Show("La Fecha Final debe ser mayor a la Fecha Inicial", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return Nothing
            End If
        End If

        If ultcmbBanco.SelectedItem IsNot Nothing Then
            IdBanco = ultcmbBanco.SelectedItem.DataValue
        End If

        If ultcmbCliente.SelectedItem IsNot Nothing Then
            IdCliente = ultcmbCliente.SelectedItem.DataValue
        End If
        Buscar = Controlador.ObtenerChequesDevueltos(ultdtpFechaInicial.Value, ultdtpFechaFinal.Value, chkVigente.Checked, chkCancelado.Checked, chkAbonado.Checked, chkPagado.Checked, IdCliente, IdBanco, txtNoCheque.Text.Trim, txtObservaciones.Text.Trim)
        dgvChequesDevueltos.DataSource = Buscar
        Return Buscar
    End Function

    Public Sub Imprimir()
        Dim ChequesDevueltos As New ChequeDevueltoCollectionClass

        If dgvChequesDevueltos.Rows.Count = 0 Then
            Buscar()
        End If

        For Each Fila As DataGridViewRow In dgvChequesDevueltos.Rows
            ChequesDevueltos.Add(CType(Fila.DataBoundItem, ChequeDevueltoClass))
        Next
        Controlador.ReporteChequesDevueltos(ChequesDevueltos, chkReporteDetallado.Checked)
    End Sub

    Public Sub Salir()
        Me.Close()
    End Sub

#End Region

#Region "Eventos"

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If dgvChequesDevueltos.SelectedRows.Count > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub frmBusquedaChequesDevueltos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Utilerias.RunControlException(Me, "Inicializar_Forma")
    End Sub

    Private Sub mtb_Acciones(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBuscar, mtb.ClickLimpiar, mtb.ClickImprimir, mtb.ClickSalir
        Utilerias.RunControlException(Me, e.Button.Text)
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub dgvChequesDevueltos_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvChequesDevueltos.CellDoubleClick
        If dgvChequesDevueltos.SelectedRows.Count > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub Estatus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVigente.CheckedChanged, chkCancelado.CheckedChanged, chkAbonado.CheckedChanged, chkPagado.CheckedChanged
        If Not (chkVigente.Checked OrElse chkCancelado.Checked OrElse chkAbonado.Checked OrElse chkPagado.Checked) Then
            chkVigente.Checked = True
            chkCancelado.Checked = True
            chkAbonado.Checked = True
            chkPagado.Checked = True
        End If
    End Sub

    Private Sub Controles_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoCheque.KeyPress, ultcmbBanco.KeyPress, ultcmbCliente.KeyPress, txtObservaciones.KeyPress, ultdtpFechaInicial.KeyPress, ultdtpFechaFinal.KeyPress, chkVigente.KeyPress, chkCancelado.KeyPress, chkAbonado.KeyPress, chkPagado.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            SendKeys.Send(Chr(Keys.Tab))
        End If
    End Sub

#End Region

End Class