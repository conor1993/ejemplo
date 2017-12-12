Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class frmRegistroPagosChequesDevueltos

#Region "Definiciones"

    Private Estado As FormState
    Private chkTodos As CheckBox
    Private dtDetallesPago As DataTable
    Private PagoChequeDevuelto As PagoCheDevueltoCabClass

#End Region

#Region "Metodos"

    Public Sub Inicializar_Forma()
        Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        tbEstados.StateBuscar = "001001111"
        tbEstados.StateLimpiar = ""
        tbEstados.StateCancelar = "100100011"
        tbEstados.StateNuevo = "011010001"
        tbEstados.StateGuardar = "100100011"
        tbEstados.StateBorrar = "100100011"
        tbEstados.StateEditar = ""
        tbEstados.StateImprimir = ""
        tbEstados.StateSalir = ""

        'Incrustar chekbox de Todos
        chkTodos = New CheckBox()
        chkTodos.ThreeState = True
        chkTodos.BackColor = Color.White
        Dim rect As Rectangle = dgvChequesDevueltos.GetCellDisplayRectangle(0, -1, True)
        chkTodos.Size = New Size(14, 14)
        chkTodos.Location = rect.Location
        chkTodos.Left = 5
        chkTodos.Top = 10
        AddHandler chkTodos.CheckStateChanged, AddressOf chkTodos_CheckedChanged
        dgvChequesDevueltos.Controls.Add(chkTodos)
        dgvChequesDevueltos.AutoGenerateColumns = False

        Controlador.LlenarComboBancos(ultcmbDeposito, CondicionEnum.ACTIVOS)

        Me.mtb.ToolBarButtonStatus = tbEstados
        Me.mtb.sbCambiarEstadoBotones("Cancelar")
        Estado = FormState.Cancelar
        Modo(False)
    End Sub

    Private Sub Modo(ByVal Edicion As Boolean)
        ultcmbCliente.Enabled = Edicion
        ultcmbDeposito.Enabled = Edicion
        txtObservaciones.Enabled = Edicion
        ultdtpFechaPago.Enabled = Edicion
        chkTodos.Visible = Edicion
        chkTodos.Enabled = Edicion
        dgvChequesDevueltos.ReadOnly = Not Edicion
        clmSeleccion.Visible = Edicion

        If Edicion Then
            lblSaldo.Text = "Saldo Actual:"
            clmImporte.DataPropertyName = ""
        Else
            lblSaldo.Text = "Saldo:"
            clmImporte.DataPropertyName = "Importe"
        End If
    End Sub

    Private Function CrearEstruturaDetallesPago() As DataTable
        Dim Key(1) As DataColumn
        CrearEstruturaDetallesPago = New DataTable
        CrearEstruturaDetallesPago.Columns.Add("IdChequeDevuelto", GetType(Integer))
        CrearEstruturaDetallesPago.Columns.Add("Saldo", GetType(Decimal))
        CrearEstruturaDetallesPago.Columns.Add("Importe", GetType(Decimal))
        Key(0) = CrearEstruturaDetallesPago.Columns(0)
        CrearEstruturaDetallesPago.PrimaryKey = Key
        Return CrearEstruturaDetallesPago
    End Function

    Private Sub ActualizarCheckBoxGeneral()
        Dim Todos As Boolean = True, Ninguno As Boolean = True

        For Each GridRow As DataGridViewRow In dgvChequesDevueltos.Rows
            Dim CeldaCheckBox As DataGridViewCheckBoxCell = CType(GridRow.Cells(clmSeleccion.Index), DataGridViewCheckBoxCell)

            If CeldaCheckBox.EditedFormattedValue Then
                Ninguno = False
            Else
                Todos = False
            End If
        Next

        RemoveHandler chkTodos.CheckStateChanged, AddressOf chkTodos_CheckedChanged
        If Todos Then
            chkTodos.CheckState = CheckState.Checked
        ElseIf Ninguno Then
            chkTodos.CheckState = CheckState.Unchecked
        Else
            chkTodos.CheckState = CheckState.Indeterminate
        End If
        AddHandler chkTodos.CheckStateChanged, AddressOf chkTodos_CheckedChanged
    End Sub

    Private Sub HabilitarDataGridViewRow(ByVal Edicion As Boolean, ByRef Renglon As DataGridViewRow)
        Renglon.Cells(clmImporte.Index).ReadOnly = Not Edicion

        If Not Edicion Then
            Dim ChequeDevuelto As ChequeDevueltoClass = CType(Renglon.DataBoundItem, ChequeDevueltoClass)
            Renglon.Cells(clmIdChequeDevuelto.Index).ReadOnly = True
            Renglon.Cells(clmNoCheque.Index).ReadOnly = True
            Renglon.Cells(clmBanco.Index).ReadOnly = True
            Renglon.Cells(clmFechaDevolucion.Index).ReadOnly = True
            Renglon.Cells(clmSaldo.Index).ReadOnly = True
            Renglon.Cells(clmImporte.Index).Value = ChequeDevuelto.Saldo
        End If
    End Sub

    Private Sub CalcularImportesTotales()
        Dim SaldoTotal As Decimal = 0D, ImportePago As Decimal = 0D

        For Each Fila As DataGridViewRow In dgvChequesDevueltos.Rows
            Dim CeldaCheckBox As DataGridViewCheckBoxCell = CType(Fila.Cells(clmSeleccion.Index), DataGridViewCheckBoxCell)

            SaldoTotal += CType(Fila.Cells(clmSaldo.Index).Value, Decimal)

            If CeldaCheckBox.EditingCellFormattedValue Then
                ImportePago += CType(Fila.Cells(clmImporte.Index).Value, Decimal)
            End If
        Next
        txtSaldoActual.Text = SaldoTotal.ToString("C2")
        txtImportePago.Text = ImportePago.ToString("C2")
    End Sub

#End Region

#Region "Acciones del Menu"

    Public Function Buscar() As Boolean
        Dim Busqueda As New frmBusquedaPagosCheDev(frmBusquedaPagosCheDev.Comportamiento.Busqueda)

        If Busqueda.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Controlador.LlenarComboClientes(ultcmbCliente, EstatusChar.TODOS)
            PagoChequeDevuelto = CType(Busqueda.dgvCabecero.SelectedRows(0).DataBoundItem, PagoCheDevueltoCabClass)
            ultcmbCliente.Value = PagoChequeDevuelto.Cliente.Codigo
            txtFolio.Text = PagoChequeDevuelto.Folio
            ultdtpFechaPago.Value = PagoChequeDevuelto.FechaPago
            ultcmbDeposito.Value = PagoChequeDevuelto.IdBancoDeposito
            txtObservaciones.Text = PagoChequeDevuelto.Referencia
            txtSaldoActual.Text = PagoChequeDevuelto.Saldo.ToString("C2")
            txtImportePago.Text = PagoChequeDevuelto.Importe.ToString("C2")
            dgvChequesDevueltos.DataSource = PagoChequeDevuelto.Detalles
            lblEstatus.Text = PagoChequeDevuelto.Estatus.ToString
            Estado = FormState.Buscar
            Return True
        End If
    End Function

    Public Sub Limpiar()
        ultcmbCliente.Value = Nothing
        txtFolio.ResetText()
        ultcmbDeposito.Value = Nothing
        ultcmbDeposito.Text = "Seleccione el Banco de Deposito"
        txtObservaciones.ResetText()
        ultdtpFechaPago.Value = Now
    End Sub

    Public Sub Cancelar()
        Limpiar()
        Modo(False)
        Estado = FormState.Cancelar
    End Sub

    Public Sub Nuevo()
        Controlador.LlenarComboClientes(ultcmbCliente, EstatusChar.VIGENTE)
        Modo(True)
        Estado = FormState.Nuevo
    End Sub

    Public Function Guardar(ByVal Trans As HC.Transaction) As Boolean
        Dim DetallesPago As New PagoCheDevueltoDetCollectionClass
        Dim IdBancoDeposito As Integer = 0

        For Each Fila As DataRow In dtDetallesPago.Rows
            Dim DetallePago As New PagoCheDevueltoDetClass(0, 0, CType(Fila("IdChequeDevuelto"), Integer), CType(Fila("Saldo"), Decimal), CType(Fila("Importe"), Decimal))
            DetallesPago.Add(DetallePago)
        Next

        If ultcmbDeposito.Value IsNot Nothing Then
            IdBancoDeposito = CType(ultcmbDeposito.Value, Integer)
        End If

        Dim Pago As PagoCheDevueltoCabClass = Controlador.RegistrarPagoChequeDevuelto(CType(ultdtpFechaPago.Value, Date), IdBancoDeposito, txtObservaciones.Text.Trim, DetallesPago, Trans)
        Trans.Commit()
        MessageBox.Show("El Pago con folio:" & Pago.Folio & " se ha registrado satisfactoriamente", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Cancelar()
        Return True
    End Function

    Public Function Borrar(ByVal Trans As HC.Transaction) As Boolean
        If PagoChequeDevuelto.Estatus = PagoCheDevueltoCabClass.EstatusPago.VIGENTE Then
            Controlador.CancelarPagoChequeDevuelto(PagoChequeDevuelto, Trans)
            Trans.Commit()
            MessageBox.Show("El Pago se ha cancelado satisfactoriamente", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Cancelar()
            Return True
        Else
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 0)
        End If
    End Function

    Public Sub Salir()
        Me.Close()
    End Sub

#End Region

#Region "Eventos"

    Private Sub RegistroPagosChequesDevueltos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Utilerias.RunControlException(Me, "Inicializar_Forma")
    End Sub

    Private Sub mtb_Acciones(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBuscar, mtb.ClickLimpiar, mtb.ClickCancelar, mtb.ClickNuevo, mtb.ClickGuardar, mtb.ClickBorrar, mtb.ClickEditar, mtb.ClickImprimir, mtb.ClickSalir
        If e.Button.Text = "Guardar" OrElse e.Button.Text = "Borrar" OrElse e.Button.Text = "Buscar" Then
            Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Cambio de Corral")
            Dim Resultado As Object = Nothing

            If e.Button.Text = "Buscar" Then
                Resultado = Utilerias.RunControlException(Me, e.Button.Text)
            Else
                Resultado = Utilerias.RunControlException(Me, e.Button.Text, New Object() {Trans})
            End If

            If Resultado Is Nothing OrElse Resultado = False Then
                Trans.Rollback()
                Cancelar = True
            End If
        Else
            Utilerias.RunControlException(Me, e.Button.Text)
        End If
    End Sub

    Private Sub chkTodos_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        Cursor = Cursors.WaitCursor
        Dim Check As CheckBox = CType(sender, CheckBox)
        RemoveHandler Check.CheckStateChanged, AddressOf chkTodos_CheckedChanged

        If Check.CheckState = CheckState.Checked Then
            Check.Checked = True
        Else
            Check.Checked = False
        End If
        AddHandler Check.CheckStateChanged, AddressOf chkTodos_CheckedChanged

        For Each Renglon As DataGridViewRow In dgvChequesDevueltos.Rows
            If CType(Renglon.Cells(clmSeleccion.Index).Value, Boolean) <> Check.Checked Then
                Dim Celda As DataGridViewCheckBoxCell = Renglon.Cells(clmSeleccion.Index)
                Celda.EditingCellFormattedValue = Check.Checked
                Celda.Value = Check.Checked
                dgvChequesDevueltos_CellContentClick(Check, New DataGridViewCellEventArgs(clmSeleccion.Index, Renglon.Index))
            End If
        Next
        Cursor = Cursors.Arrow
    End Sub

    Private Sub dgvChequesDevueltos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvChequesDevueltos.CellContentClick
        If e.ColumnIndex = clmSeleccion.Index Then
            If e.RowIndex >= 0 Then
                Dim Celda As DataGridViewCheckBoxCell = CType(dgvChequesDevueltos.Rows(e.RowIndex).Cells(clmSeleccion.Index), DataGridViewCheckBoxCell)
                dgvChequesDevueltos.Rows(e.RowIndex).Cells(clmImporte.Index).ReadOnly = Not CType(Celda.EditedFormattedValue, Boolean)
                HabilitarDataGridViewRow(CType(Celda.EditedFormattedValue, Boolean), dgvChequesDevueltos.Rows(e.RowIndex))

                If CType(Celda.EditedFormattedValue, Boolean) Then
                    If Decimal.Parse(dgvChequesDevueltos.Rows(e.RowIndex).Cells(clmImporte.Index).Value) > 0D Then
                        dtDetallesPago.Rows.Add(New Object() {dgvChequesDevueltos.Rows(e.RowIndex).Cells(clmIdChequeDevuelto.Index).Value, dgvChequesDevueltos.Rows(e.RowIndex).Cells(clmSaldo.Index).Value - dgvChequesDevueltos.Rows(e.RowIndex).Cells(clmImporte.Index).Value, dgvChequesDevueltos.Rows(e.RowIndex).Cells(clmImporte.Index).Value})
                    End If
                Else
                    Dim RegistrosEncontrados() As DataRow = dtDetallesPago.Select("IdChequeDevuelto = " & dgvChequesDevueltos.Rows(e.RowIndex).Cells(clmIdChequeDevuelto.Index).Value.ToString)

                    If RegistrosEncontrados.Length > 0 Then
                        dtDetallesPago.Rows.Remove(RegistrosEncontrados(0))
                    End If
                End If
                CalcularImportesTotales()

                If sender.GetType Is GetType(DataGridView) Then
                    ActualizarCheckBoxGeneral()
                End If
            End If
        End If
    End Sub

    Private Sub ultcmbCliente_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ultcmbCliente.ValueChanged
        dgvChequesDevueltos.DataSource = Nothing

        If Estado = FormState.Nuevo Then
            dtDetallesPago = CrearEstruturaDetallesPago()

            If ultcmbCliente.SelectedItem IsNot Nothing Then
                dgvChequesDevueltos.DataSource = Controlador.ObtenerChequesDevueltos(Nothing, Nothing, True, False, True, False, Integer.Parse(ultcmbCliente.Value), Nothing, Nothing, Nothing)

                For Each Renglon As DataGridViewRow In dgvChequesDevueltos.Rows
                    HabilitarDataGridViewRow(False, Renglon)
                Next
                CalcularImportesTotales()
            End If
            RemoveHandler chkTodos.CheckStateChanged, AddressOf chkTodos_CheckedChanged
            chkTodos.Checked = False
            AddHandler chkTodos.CheckStateChanged, AddressOf chkTodos_CheckedChanged
        End If
    End Sub

    Private Sub dgvChequesDevueltos_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvChequesDevueltos.EditingControlShowing
        If dgvChequesDevueltos.CurrentCell.ColumnIndex = clmImporte.Index Then
            RemoveHandler e.Control.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosDecimales
            AddHandler e.Control.KeyPress, AddressOf Utilerias.ValidarEntradaNumerosDecimales
        End If
    End Sub

    Private Sub dgvChequesDevueltos_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvChequesDevueltos.CellEndEdit
        If e.ColumnIndex = clmImporte.Index Then
            Dim Importe As Decimal = 0D

            If dgvChequesDevueltos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString <> String.Empty Then
                Importe = CType(dgvChequesDevueltos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value, Decimal)
            End If

            If Importe > 0 Then
                Dim Saldo As Decimal = CType(dgvChequesDevueltos.Rows(e.RowIndex).Cells(clmSaldo.Index).Value, Decimal)
                Dim RegistrosEncontrados() As DataRow = dtDetallesPago.Select("IdChequeDevuelto = " & dgvChequesDevueltos.Rows(e.RowIndex).Cells(clmIdChequeDevuelto.Index).Value.ToString)

                If Importe > Saldo Then
                    MessageBox.Show("El Importe establecido es superior al Saldo, no debe superar el Saldo" & vbNewLine & "El Importe se establecera en " & Saldo.ToString("C2"), Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Importe = Saldo
                    dgvChequesDevueltos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Importe
                End If

                If RegistrosEncontrados.Length > 0 Then
                    RegistrosEncontrados(0)("Importe") = Importe
                    RegistrosEncontrados(0)("Saldo") = Saldo - Importe
                End If
            Else
                MessageBox.Show("Ya que ha establecido el importe en cero" & vbNewLine & "La seleccion del Cheque Devuelto se deshabilitara", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim Celda As DataGridViewCheckBoxCell = dgvChequesDevueltos.Rows(e.RowIndex).Cells(clmSeleccion.Index)
                Celda.EditingCellFormattedValue = False
                Celda.Value = False
                dgvChequesDevueltos_CellContentClick(sender, New DataGridViewCellEventArgs(clmSeleccion.Index, e.RowIndex))
            End If
            CalcularImportesTotales()
        End If
    End Sub

    Private Sub dgvChequesDevueltos_Sorted(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvChequesDevueltos.Sorted
        If Estado = FormState.Nuevo Then
            Dim Todos As Boolean = True, Ninguno As Boolean = True

            For Each Renglon As DataGridViewRow In dgvChequesDevueltos.Rows
                Dim Celda As DataGridViewCheckBoxCell = Renglon.Cells(clmSeleccion.Index)
                Dim RegistrosEncontrados() As DataRow

                RegistrosEncontrados = dtDetallesPago.Select("IdChequeDevuelto =" & Renglon.Cells(clmIdChequeDevuelto.Index).Value.ToString)
                Celda.EditingCellFormattedValue = IIf(RegistrosEncontrados.Length > 0, True, False)
                Celda.Value = Celda.EditingCellFormattedValue
                HabilitarDataGridViewRow(Celda.Value, Renglon)

                If Not Celda.Value Then
                    Todos = False
                Else
                    Ninguno = False
                End If
            Next

            RemoveHandler chkTodos.CheckStateChanged, AddressOf chkTodos_CheckedChanged

            If Not (Todos OrElse Ninguno) Then
                chkTodos.CheckState = CheckState.Indeterminate
            ElseIf Todos Then
                chkTodos.CheckState = CheckState.Checked
            Else
                chkTodos.CheckState = CheckState.Unchecked
            End If
            AddHandler chkTodos.CheckStateChanged, AddressOf chkTodos_CheckedChanged
        End If
    End Sub

    Private Sub Controles_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ultcmbCliente.KeyPress, ultdtpFechaPago.KeyPress, ultcmbDeposito.KeyPress, txtObservaciones.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            SendKeys.Send(Chr(Keys.Tab))
        End If
    End Sub

#End Region

End Class