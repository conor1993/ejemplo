Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class frmRegistroChequesDevueltos

#Region "Definiciones"
    Private Estado As FormState
    Private ChequeDevuelto As ChequeDevueltoClass = Nothing
#End Region

#Region "Metodos"

    Public Sub Inicializar_Forma()
        Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        tbEstados.StateBuscar = "101001101"
        tbEstados.StateLimpiar = ""
        tbEstados.StateCancelar = "100100001"
        tbEstados.StateNuevo = "011010001"
        tbEstados.StateGuardar = "100100001"
        tbEstados.StateBorrar = "100100001"
        tbEstados.StateEditar = "001010001"
        tbEstados.StateImprimir = ""
        tbEstados.StateSalir = ""

        Me.mtb.ToolBarButtonStatus = tbEstados
        Me.mtb.sbCambiarEstadoBotones("Cancelar")
        dgvPagos.AutoGenerateColumns = False
        Modo(False)
        Estado = FormState.Cancelar
    End Sub

    Public Sub Modo(ByVal Edicion As Boolean)
        ultcmbBanco.Enabled = Edicion
        ultcmbCliente.Enabled = Edicion
        ultdtpFechaDevolucion.Enabled = Edicion
        txtNoCheque.Enabled = Edicion
        ultnedImporte.Enabled = Edicion
        txtObservaciones.Enabled = Edicion
        txtRecibio.Enabled = Edicion

        If Estado = FormState.Editar And Edicion Then
            dgvPagos.Enabled = True
        Else
            dgvPagos.Enabled = False
        End If
    End Sub

#End Region

#Region "Acciones del Menu"

    Public Function Buscar() As Boolean
        Dim Busqueda As New frmBusquedaChequesDevueltos(frmBusquedaChequesDevueltos.Comportamiento.Busqueda)

        If Busqueda.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Controlador.LlenarComboBancos(ultcmbBanco, CondicionEnum.TODOS)
            Controlador.LlenarComboClientes(ultcmbCliente, EstatusChar.TODOS, True)
            ChequeDevuelto = CType(Busqueda.dgvChequesDevueltos.SelectedRows(0).DataBoundItem, ChequeDevueltoClass)
            ultcmbBanco.Value = ChequeDevuelto.IdBanco
            ultcmbCliente.Value = ChequeDevuelto.IdCliente
            txtNoCheque.Text = ChequeDevuelto.NoCheque
            ultdtpFechaDevolucion.Value = ChequeDevuelto.FechaDevolucion
            ultnedImporte.Value = ChequeDevuelto.Importe
            txtRecibio.Text = ChequeDevuelto.Recibio
            txtObservaciones.Text = ChequeDevuelto.Observaciones
            lblEstatus.Text = ChequeDevuelto.Estatus.ToString
            dgvPagos.DataSource = ChequeDevuelto.Pagos_Vigentes
            txtSaldo.Text = ChequeDevuelto.Saldo.ToString("C2")
            Estado = FormState.Buscar
            Return True
        End If
    End Function

    Public Sub Limpiar()
        ultcmbBanco.SelectedIndex = -1
        ultcmbCliente.SelectedIndex = -1
        ultdtpFechaDevolucion.Value = Now
        txtNoCheque.ResetText()
        txtObservaciones.ResetText()
        txtRecibio.ResetText()
        ultnedImporte.ResetValue()
        dgvPagos.DataSource = Nothing
        txtSaldo.ResetText()

        If Estado <> FormState.Nuevo Then
            lblEstatus.Text = "ESTATUS"
        End If
    End Sub

    Public Sub Cancelar()
        Limpiar()
        Modo(False)
        Estado = FormState.Cancelar
    End Sub

    Public Sub Nuevo()
        Controlador.LlenarComboBancos(ultcmbBanco, CondicionEnum.ACTIVOS)
        Controlador.LlenarComboClientes(ultcmbCliente, EstatusChar.VIGENTE, True)
        ChequeDevuelto = Nothing
        Limpiar()
        Modo(True)
        Estado = FormState.Nuevo
        ultcmbBanco.Focus()
    End Sub

    Public Function Guardar(ByVal Trans As HC.Transaction) As Boolean
        Dim IdBanco As Integer = 0
        Dim IdCliente As Integer = 0

        If ultcmbBanco.SelectedItem IsNot Nothing Then
            IdBanco = ultcmbBanco.SelectedItem.DataValue
        End If

        If ultcmbCliente.SelectedItem IsNot Nothing Then
            IdCliente = ultcmbCliente.SelectedItem.DataValue
        End If

        If Estado = FormState.Nuevo Then
            ChequeDevuelto = New ChequeDevueltoClass(txtNoCheque.Text.Trim, IdBanco, IdCliente, ultdtpFechaDevolucion.Value, ultnedImporte.Value, txtRecibio.Text.Trim, txtObservaciones.Text.Trim)
        ElseIf Estado = FormState.Editar Then
            ChequeDevuelto.IdBanco = IdBanco
            ChequeDevuelto.IdCliente = IdCliente
            ChequeDevuelto.NoCheque = txtNoCheque.Text.Trim
            ChequeDevuelto.FechaDevolucion = ultdtpFechaDevolucion.Value
            ChequeDevuelto.Importe = ultnedImporte.Value
            ChequeDevuelto.Recibio = txtRecibio.Text.Trim
            ChequeDevuelto.Observaciones = txtObservaciones.Text.Trim
        End If
        Controlador.RegistrarChequeDevuelto(ChequeDevuelto, Trans)
        Trans.Commit()
        MessageBox.Show("El Registro se ha guardado satisfactoriamente", Controlador.Sesion.MiEmpresa.Empnom)
        Cancelar()
        Return True
    End Function

    Public Function Borrar(ByVal Trans As HC.Transaction) As Boolean
        If ChequeDevuelto.Estatus <> ChequeDevueltoClass.ChequeDevueltoEstatus.CANCELADO Then
            If MessageBox.Show("El Registro se cancelara" & vbNewLine & "¿Esta seguro?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                Controlador.CancelarChequeDevuelto(ChequeDevuelto, Trans)
                Trans.Commit()
                MessageBox.Show("El Registro se ha cancelado satisfactoriamente", Controlador.Sesion.MiEmpresa.Empnom)
                Cancelar()
                Return True
            End If
        Else
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 0)
        End If
    End Function

    Public Function Editar() As Boolean
        If ChequeDevuelto.Estatus = ChequeDevueltoClass.ChequeDevueltoEstatus.PAGADO _
        OrElse ChequeDevuelto.Estatus = ChequeDevueltoClass.ChequeDevueltoEstatus.ABONADO Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.CHEQUES_DEVUELTOS, 2)
        ElseIf ChequeDevuelto.Estatus = ChequeDevueltoClass.ChequeDevueltoEstatus.CANCELADO Then
            If MessageBox.Show("El Registro esta Cancelado" & vbNewLine & "¿Desea Activarlo?", Controlador.Sesion.MiEmpresa.Empnom, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                lblEstatus.Text = "VIGENTE"
                ChequeDevuelto.Estatus = ChequeDevueltoClass.ChequeDevueltoEstatus.VIGENTE
            Else
                Return False
            End If
        End If
        Estado = FormState.Editar
        Modo(True)
        Return True
    End Function

    Public Sub Salir()
        Me.Close()
    End Sub

#End Region

#Region "Eventos"

    Private Sub ChequesDevueltos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Utilerias.RunControlException(Me, "Inicializar_Forma")
    End Sub

    Private Sub mtb_Acciones(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickBuscar, mtb.ClickLimpiar, mtb.ClickCancelar, mtb.ClickNuevo, mtb.ClickGuardar, mtb.ClickBorrar, mtb.ClickEditar, mtb.ClickImprimir, mtb.ClickSalir
        If e.Button.Text = "Guardar" OrElse e.Button.Text = "Borrar" OrElse e.Button.Text = "Buscar" OrElse e.Button.Text = "Editar" Then
            Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Cambio de Corral")
            Dim Resultado As Object = Nothing

            If e.Button.Text = "Buscar" OrElse e.Button.Text = "Editar" Then
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

    Private Sub Controles_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ultcmbBanco.KeyPress, ultcmbCliente.KeyPress, txtNoCheque.KeyPress, txtRecibio.KeyPress, ultdtpFechaDevolucion.KeyPress, ultnedImporte.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            SendKeys.Send(Chr(Keys.Tab))
        End If
    End Sub

    'Private Sub frmRegistroChequesDevueltos_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
    '    If e.KeyCode = Keys.Escape Then
    '        If Estado = FormState.Cancelar Then
    '            Me.Close()
    '        Else
    '            mtb_Acciones(mtb, New ToolBarButtonClickEventArgs(mtb.Buttons("tbbtnCancelar")), New Boolean)
    '            Me.mtb.sbCambiarEstadoBotones("Cancelar")
    '        End If
    '    End If
    'End Sub

#End Region

End Class