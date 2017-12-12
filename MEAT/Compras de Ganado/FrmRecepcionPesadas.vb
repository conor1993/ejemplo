Imports ClasesNegocio
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports SD.LLBLGen.Pro.ORMSupportClasses
Imports EC = Integralab.ORM.EntityClasses
Imports Integralab.Controles

Public Class FrmRecepcionPesadas

#Region "Miembros"
    Dim State As FormState
    Dim WithEvents RecepcionGanado As RecepcionGanadoClass
#End Region

#Region "Metodos"

#Region "Acciones"

    Private Function Buscar() As Boolean
        State = FormState.Buscar
        Dim Busqueda As New frmBusquedaRecepcionPesadas()

        If Busqueda.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            RecepcionGanado = CType(Busqueda.dgvRecepcionPesadas.CurrentRow.DataBoundItem, RecepcionGanadoClass)
            txtFolio.Text = RecepcionGanado.LoteRecepcion
            dtpFecha.Value = RecepcionGanado.FechaRecepcion
            txtKilosEnviados.Text = RecepcionGanado.KilosEnviados
            txtKilosRecibidos.Text = RecepcionGanado.KilosRecibidos
            txtKilos1Pesada.Text = RecepcionGanado.KilosPrimeraPesada
            txtKilos2Pesada.Text = RecepcionGanado.KilosSegundaPesada
            cmbProveedor.SelectedValue = IIf(RecepcionGanado.Entidad.IdProveedor.HasValue, RecepcionGanado.Entidad.IdProveedor, -1)
            txtUnidad.Text = RecepcionGanado.Unidad
            txtConductor.Text = RecepcionGanado.Conductor
            txtPlacas.Text = RecepcionGanado.Placas
            txtObservaciones.Text = RecepcionGanado.Observaciones
            txtTotalCabezas.Text = RecepcionGanado.CantCabezas

            If Not RecepcionGanado.Estatus = "X" Then
                lblEstatus.Text = "VIGENTE"
            Else
                lblEstatus.Text = "CANCELADO"
            End If

            If RecepcionGanado.TipoPesada <> RecepcionGanadoClass.Tipo.Sacrificio Then
                tbcOpcion.SelectedIndex = RecepcionGanado.TipoPesada
            End If
            cmbProveedor.DataSource = ProveedorCollectionClass.CargarProveedores(IIf(tbcOpcion.SelectedTab.Text = "Ganado", HC.ProveedorFields.EsdeGanado = 1, Nothing))
            cmbProducto.DataSource = ProductoCollectionClass.CargarProductos(HC.ProductoFields.EsIngrediente = 1)
            TipoGanado.RellenarMe(TipoGanadoColecttionClass.CargarTiposGanado())

            dgvGanado.DataSource = Nothing
            If tbcOpcion.SelectedTab.Name = "tabGanado" Then
                dgvGanado.DataSource = RecepcionGanado.Detalle
            ElseIf tbcOpcion.SelectedTab.Name = "tabIngredientes" Then
                cmbProducto.SelectedValue = RecepcionGanado.Detalle(0).IdProducto
            Else
                txtProducto.Text = RecepcionGanado.Detalle(0).DescripcionProducto
            End If
            Return True
        End If
    End Function

    Private Function Limpiar() As Boolean
        If State = FormState.Editar Then
            CleanEditFields()
        ElseIf State = FormState.Buscar Then
            Acciones(Me, New ToolBarButtonClickEventArgs(mtbMenu.Buttons("tbbtnCancelar")), False)
            mtbMenu.sbCambiarEstadoBotones("Cancelar")
        Else
            CleanAllFields()
        End If

        Return True
    End Function

    Private Sub CleanAllFields()
        txtFolio.Text = String.Empty
        dtpFecha.Value = Now
        dgvGanado.Rows.Clear()
        txtTotalCabezas.Text = String.Empty
        txtKilosEnviados.Text = String.Empty
        txtKilosRecibidos.Text = String.Empty
        rbnSi.Checked = False
        rbnNo.Checked = False
        txtKilos1Pesada.ReadOnly = True
        txtKilos2Pesada.ReadOnly = True
        txtKilos1Pesada.Text = String.Empty
        txtKilos2Pesada.Text = String.Empty
        cmbProveedor.SelectedValue = -1
        cmbProveedor.Text = "Seleccione el proveedor"
        txtProveedor.Text = String.Empty
        cmbProducto.SelectedValue = -1
        cmbProducto.Text = "Seleccione el producto"
        txtCodigoProducto.Text = String.Empty
        txtUnidad.Text = String.Empty
        txtConductor.Text = String.Empty
        txtPlacas.Text = String.Empty
        txtObservaciones.Text = String.Empty
        txtProducto.Text = String.Empty
        chkBascula.Checked = False
    End Sub

    Private Sub CleanEditFields()
        dtpFecha.Value = Now
        dgvGanado.Rows.Clear()
        txtTotalCabezas.Text = String.Empty
        txtKilosEnviados.Text = String.Empty

        If Not txtKilos1Pesada.ReadOnly Then
            txtKilos1Pesada.Text = String.Empty
        Else
            txtKilos2Pesada.Text = String.Empty
        End If
        txtKilosRecibidos.Text = String.Empty
        cmbProveedor.SelectedValue = -1
        cmbProveedor.Text = "Seleccione el proveedor"
        txtProveedor.Text = String.Empty
        cmbProducto.SelectedValue = -1
        cmbProducto.Text = "Seleccione el producto"
        txtCodigoProducto.Text = String.Empty
        txtUnidad.Text = String.Empty
        txtConductor.Text = String.Empty
        txtPlacas.Text = String.Empty
        txtObservaciones.Text = String.Empty
        txtProducto.Text = String.Empty
    End Sub

    Private Function Cancelar() As Boolean
        State = FormState.Cancelar
        Limpiar()
        InhabilitarEdicion()
        Return True
    End Function

    Private Function Nuevo() As Boolean
        State = FormState.Nuevo
        Limpiar()
        HabilitarEdicion()
        RecepcionGanado = New RecepcionGanadoClass()
        dgvGanado.DataSource = RecepcionGanado.Detalle
        lblEstatus.Text = "VIGENTE"
        txtKilos2Pesada.ReadOnly = True

        dtpFecha.Value = Now

        cmbProveedor.DataSource = ProveedorCollectionClass.CargarProveedores(HC.ProveedorFields.EsdeGanado = 1)
        cmbProveedor.SelectedValue = -1
        cmbProveedor.Text = "Seleccione el proveedor"
        txtProveedor.Text = String.Empty

        cmbProducto.DataSource = ProductoCollectionClass.CargarProductos(HC.ProductoFields.EsIngrediente = 1)
        cmbProducto.SelectedValue = -1
        cmbProducto.Text = "Seleccione el producto"
        txtCodigoProducto.Text = String.Empty

        TipoGanado.RellenarMe(TipoGanadoColecttionClass.CargarTiposGanado())
        Return True
    End Function

    Private Function Guardar() As Boolean
        If ValidarGuardar() Then
            EstablecerValores()

            If RecepcionGanado.Guardar() Then
                MsgBox("Los datos se han guardado correctamente", MsgBoxStyle.Information, "RecepcionPesadas")
                Limpiar()
                InhabilitarEdicion()
                Return True
            End If
        End If
    End Function

    Private Function Borrar() As Boolean
        Dim Resultado As DialogResult = MessageBox.Show("¿Confirma la cancelarlo?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If Resultado = Windows.Forms.DialogResult.Yes Then
            If RecepcionGanado.Borrar() Then
                MsgBox("La recepcion se ha cancelado satisfactoriamente")
                Limpiar()
                InhabilitarEdicion()
                Return True
            End If
        End If
    End Function

    Private Function Editar() As Boolean
        If lblEstatus.Text.Contains("CANCELADO") Then
            MsgBox("Esta recepcion ya se ha cancelado", MsgBoxStyle.Exclamation, "Aviso")
            Return False
        ElseIf Double.Parse(txtKilos1Pesada.Text) <> 0 And Double.Parse(txtKilos2Pesada.Text) <> 0 Then
            MsgBox("Ya se han capturado las 2 pesadas, no es posible modificar", MsgBoxStyle.Exclamation, "Aviso")
            Return False
        ElseIf Double.Parse(txtKilos1Pesada.Text) <> 0 Then
            txtKilos1Pesada.ReadOnly = True
        Else
            txtKilos2Pesada.ReadOnly = True
        End If

        State = FormState.Editar
        HabilitarEdicion()
        Return True
    End Function

    Private Function Imprimir() As Boolean
        Dim LastState As FormState = State
        State = FormState.Imprimir
        Dim Todos As Boolean = True

        If LastState = FormState.Buscar Then
            Todos = False
        End If

        Return RecepcionGanadoColeccion.ImprimirRecepcionPesadas(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnomcom, IIf(Todos, Nothing, txtFolio.Text))
    End Function

    Private Sub Salir()
        Me.AutoValidate = Windows.Forms.AutoValidate.Disable
        Me.Close()
    End Sub

#End Region

    Private Sub EstablecerValores()
        If tbcOpcion.SelectedTab.Name = "tabOtros" Then
            RecepcionGanado.Proveedor = Nothing
        Else
            RecepcionGanado.IdProveedor = cmbProveedor.SelectedValue
        End If

        RecepcionGanado.FechaRecepcion = dtpFecha.Value
        RecepcionGanado.KilosEnviados = txtKilosEnviados.Text

        If RecepcionGanado.Entidad.IsNew Then
            RecepcionGanado.KilosSegundaPesada = 0
            RecepcionGanado.KilosPrimeraPesada = 0
        End If

        If Not txtKilos2Pesada.ReadOnly Then
            RecepcionGanado.KilosSegundaPesada = txtKilos2Pesada.Text
        Else
            RecepcionGanado.KilosPrimeraPesada = txtKilos1Pesada.Text
        End If

        If State = FormState.Editar Then
            RecepcionGanado.KilosRecibidos = txtKilosRecibidos.Text
        ElseIf State = FormState.Nuevo Then
            RecepcionGanado.KilosRecibidos = 0
        End If

        RecepcionGanado.Conductor = txtConductor.Text
        RecepcionGanado.Unidad = txtUnidad.Text
        RecepcionGanado.Placas = txtPlacas.Text
        RecepcionGanado.Observaciones = txtObservaciones.Text

        If tbcOpcion.SelectedTab.Name = "tabGanado" Then
            If dgvGanado.Rows.Count = RecepcionGanado.Detalle.Count Then
                RecepcionGanado.Detalle.RemoveAt(RecepcionGanado.Detalle.Count - 1)
            End If
            RecepcionGanado.CantCabezas = Integer.Parse(txtTotalCabezas.Text)
            RecepcionGanado.TipoPesada = RecepcionGanadoClass.Tipo.Ganado
        Else
            RecepcionGanado.Detalle.Clear()
            RecepcionGanado.Detalle.Add(New RecepcionPesadasDetalleClass())
            RecepcionGanado.Detalle(0).Renglon = 1

            If tbcOpcion.SelectedTab.Name = "tabIngredientes" Then
                RecepcionGanado.Detalle(0).IdProducto = cmbProducto.SelectedValue
                RecepcionGanado.TipoPesada = RecepcionGanadoClass.Tipo.Ingrediente
            Else
                RecepcionGanado.Detalle(0).DescripcionProducto = txtProducto.Text
                RecepcionGanado.TipoPesada = RecepcionGanadoClass.Tipo.Otros
            End If
        End If
        RecepcionGanado.Estatus = RecepcionGanado.TipoPesada.ToString().Chars(0)
    End Sub

    Private Function ValidarGuardar() As Boolean
        If tbcOpcion.SelectedTab.Name = "tabGanado" Then
            If dgvGanado.Rows.Count = 1 Then
                MsgBox("Debe proporcionar el ganado", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If

            If Not Me.Validate(False) Then
                Return False
            End If
            'For i As Integer = 0 To dgvGanado.Rows.Count - 2
            '    If dgvGanado.Rows(i).Cells("clmTipoGanado").Value Is Nothing Then
            '        MsgBox("Debe especificar el tipo de ganado", MsgBoxStyle.Exclamation, "Aviso")
            '        dgvGanado.Rows(i).Cells("clmTipoGanado").Selected = True
            '        Return False
            '    ElseIf Not IsNumeric(dgvGanado.Rows(i).Cells("clmCabezas").Value) Then
            '        MsgBox("Debe especificar la cantidad de cabezas", MsgBoxStyle.Exclamation, "Aviso")
            '        dgvGanado.Rows(i).Cells("clmCabezas").Selected = True
            '        Return False
            '    ElseIf dgvGanado.Rows(i).Cells("clmCabezas").Value <= 0 Then
            '        MsgBox("Debe especificar la cantidad de cabezas", MsgBoxStyle.Exclamation, "Aviso")
            '        dgvGanado.Rows(i).Cells("clmCabezas").Selected = True
            '        Return False
            '    End If
            'Next
        ElseIf tbcOpcion.SelectedTab.Name = "tabIngredientes" Then
            If cmbProducto.SelectedValue Is Nothing Then
                MsgBox("Debe especificar el ingrediente", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
        Else
            If txtProducto.Text = String.Empty Then
                MsgBox("Debe especificar el producto", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
        End If

        If txtKilosEnviados.Text = String.Empty Then
            MsgBox("Debe especificar los kg enviados", MsgBoxStyle.Exclamation, "Aviso")
            Return False
        ElseIf txtKilos1Pesada.ReadOnly And txtKilos2Pesada.ReadOnly Then
            MsgBox("Debe especificar si es llena o no y consecuentemente los kg de la pesada", MsgBoxStyle.Exclamation, "Aviso")
            Return False
        ElseIf Not txtKilos1Pesada.ReadOnly AndAlso txtKilos1Pesada.Text = String.Empty Then
            MsgBox("Debe especificar los kg de la primera pesada", MsgBoxStyle.Exclamation, "Aviso")
            Return False
        ElseIf Not txtKilos2Pesada.ReadOnly AndAlso txtKilos2Pesada.Text = String.Empty Then
            MsgBox("Debe especificar los kg de la segunda pesada", MsgBoxStyle.Exclamation, "Aviso")
            Return False
        ElseIf tbcOpcion.SelectedTab.Name <> "tabOtros" AndAlso cmbProveedor.SelectedValue Is Nothing Then
            MsgBox("Debe especificar el proveedor", MsgBoxStyle.Exclamation, "Aviso")
            Return False
        ElseIf txtUnidad.Text = String.Empty Then
            MsgBox("Debe especificar la unidad", MsgBoxStyle.Exclamation, "Aviso")
            Return False
        ElseIf txtConductor.Text = String.Empty Then
            MsgBox("Debe especificar el conductor", MsgBoxStyle.Exclamation, "Aviso")
            Return False
        ElseIf txtPlacas.Text = String.Empty Then
            MsgBox("Debe especificar las placas", MsgBoxStyle.Exclamation, "Aviso")
            Return False
        End If

        If State = FormState.Editar Then
            If Double.Parse(txtKilosRecibidos.Text) < 0 Then
                MsgBox("La segunda pesada(caja llena) no puede ser menor que la primera pesada(caja vacia)", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub InhabilitarEdicion()
        dtpFecha.Enabled = False
        dgvGanado.ReadOnly = True
        dgvGanado.AllowUserToAddRows = False
        txtKilosEnviados.ReadOnly = True
        rbnSi.Enabled = False
        rbnNo.Enabled = False
        txtKilos1Pesada.ReadOnly = True
        txtKilos2Pesada.ReadOnly = True
        cmbProveedor.Enabled = False
        txtProveedor.ReadOnly = True
        cmbProducto.Enabled = False
        txtCodigoProducto.ReadOnly = True
        txtUnidad.ReadOnly = True
        txtConductor.ReadOnly = True
        txtPlacas.ReadOnly = True
        txtObservaciones.ReadOnly = True
        txtProducto.ReadOnly = True
        txtTotalCabezas.ReadOnly = True
        tbcOpcion.Enabled = False
        chkBascula.Enabled = False
    End Sub

    Private Sub HabilitarEdicion()
        dtpFecha.Enabled = True
        dgvGanado.ReadOnly = False
        dgvGanado.AllowUserToAddRows = True
        txtKilosEnviados.ReadOnly = False
        cmbProveedor.Enabled = True
        txtProveedor.ReadOnly = False
        cmbProducto.Enabled = True
        txtCodigoProducto.ReadOnly = False
        txtUnidad.ReadOnly = False
        txtConductor.ReadOnly = False
        txtPlacas.ReadOnly = False
        txtObservaciones.ReadOnly = False
        txtProducto.ReadOnly = False
        txtTotalCabezas.ReadOnly = False
        tbcOpcion.Enabled = True
        chkBascula.Enabled = True

        If State = FormState.Nuevo Then
            txtKilos1Pesada.ReadOnly = True
            txtKilos2Pesada.ReadOnly = True
            rbnSi.Enabled = True
            rbnNo.Enabled = True
        ElseIf State = FormState.Editar Then
            If Double.Parse(txtKilos1Pesada.Text) <> 0 Then
                txtKilos2Pesada.ReadOnly = False
                rbnSi.Checked = True
            Else
                txtKilos1Pesada.ReadOnly = False
                rbnNo.Checked = True
            End If
            rbnSi.Enabled = False
            rbnNo.Enabled = False
        End If
    End Sub

    Private Function CalcularTotalCabezas() As Double?
        For i As Integer = 0 To dgvGanado.Rows.Count - 2
            CalcularTotalCabezas += _
            Double.Parse(IIf(Not IsNumeric(dgvGanado.Rows(i).Cells("clmCabezas").Value), _
            "0", dgvGanado.Rows(i).Cells("clmCabezas").Value))
        Next
    End Function

    Private Sub ValidarNumericos(ByVal Sender As Object, ByVal e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ConfigurarPuerto()
        txtLeerPeso.Port = 1 'Abro el com2
        txtLeerPeso.BaudRate = 9600 '9600 bits por segundo
        txtLeerPeso.DataBit = 8  '8 bits de datos
        txtLeerPeso.StopBit = wclTextBoxSerial.Rs232.DataStopBit.StopBit_1 'Un bit de parada
        txtLeerPeso.Parity = wclTextBoxSerial.Rs232.DataParity.Parity_None 'No paridad
        txtLeerPeso.TimeOut = 1500 'Esperar 1500 milisegundos antes de considerar time out

        'Esperar 300 milisegundos para dar tiempo a que llegue un grupo de bytes.
        'A menor tiempo menor es el número de bytes que llegan en cada llamada del evento SerialDataArrived.
        'Por ejemplo un lector que envia 14 bytes podrian llegar en la primer llamada al evento 7 caracteres y 
        'en otra llamada otros 7. Dando mayor tiempo damos oportunidad a que lleguen los 14 bytes juntos.
        txtLeerPeso.TimeToWaitForMoreData = 500

        'Puede mostrar la información con formato Ascii, Hexadecimal o Decimal. 
        'Por ejemplo si se recibe la cadena HOLA la salida sería:
        'ASCII: HOLA
        'Decimal:  072079076065
        'Hexadecimal: 484F4C41
        txtLeerPeso.Format = wclTextBoxSerial.TextBoxSerial.FormatoDatos.Ascii 'Formato en que se mostrará la información
    End Sub

    Private Function DetectarCampoPesada() As TextBox
        If Not txtKilos1Pesada.ReadOnly Then
            Return txtKilos1Pesada
        ElseIf Not txtKilos2Pesada.ReadOnly Then
            Return txtKilos2Pesada
        End If
        Return Nothing
    End Function
#End Region

#Region "Eventos"

#Region "Forma"
    Private Sub FrmRecepcionPesadas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConfigurarPuerto()
        dgvGanado.AutoGenerateColumns = False
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        MtbEstados.StateBuscar = "110101111"
        MtbEstados.StateLimpiar = ""
        MtbEstados.StateCancelar = "100100011"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "100100001"
        MtbEstados.StateBorrar = "100100001"
        MtbEstados.StateEditar = "001010000"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""
        mtbMenu.ToolBarButtonStatus = MtbEstados
        Acciones(Me, New ToolBarButtonClickEventArgs(mtbMenu.Buttons("tbbtnCancelar")), False)
        'Dim menuCancelar As New MEAToolBar.MEAToolBar.ClickCancelarEventHandler(AddressOf Acciones)
        'menuCancelar.Invoke(Me, New ToolBarButtonClickEventArgs(mtbMenu.Buttons("tbbtnCancelar")), False)
        mtbMenu.sbCambiarEstadoBotones("Cancelar")
    End Sub
#End Region

#Region "Menu"
    Private Sub Acciones(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtbMenu.ClickBuscar, mtbMenu.ClickGuardar, mtbMenu.ClickEditar, mtbMenu.ClickCancelar, mtbMenu.ClickBorrar, mtbMenu.ClickSalir, mtbMenu.ClickNuevo, mtbMenu.ClickLimpiar, mtbMenu.ClickImprimir
        Dim Resultado As Boolean = False

        Select Case e.Button.Text
            Case "Buscar"
                Resultado = Me.Buscar()
            Case "Limpiar"
                Resultado = Me.Limpiar()
            Case "Cancelar"
                Resultado = Me.Cancelar()
            Case "Nuevo"
                Resultado = Me.Nuevo()
            Case "Guardar"
                Resultado = Me.Guardar()
            Case "Borrar"
                Resultado = Me.Borrar()
            Case "Editar"
                Resultado = Me.Editar()
            Case "Imprimir"
                Resultado = Me.Imprimir()
            Case "Salir"
                Me.Salir()
        End Select

        Cancelar = Not Resultado
    End Sub
#End Region

#Region "Tab de Opciones"
    Private Sub tbcOpcion_Selecting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlCancelEventArgs) Handles tbcOpcion.Selecting
        e.Cancel = (State = FormState.Editar)

        If (State = FormState.Nuevo Or State = FormState.Editar) AndAlso Not e.Cancel Then
            If e.TabPage.Text = "Otros" Then
                txtProveedor.Enabled = False
                cmbProveedor.Enabled = False
            Else
                cmbProveedor.DataSource = ProveedorCollectionClass.CargarProveedores(IIf(e.TabPage.Text = "Ganado", HC.ProveedorFields.EsdeGanado = 1, Nothing))
                txtProveedor.Enabled = True
                cmbProveedor.Enabled = True
            End If
            txtProveedor.Text = String.Empty
            cmbProveedor.SelectedValue = -1
            cmbProveedor.Text = "Seleccione el proveedor"
        End If
    End Sub
#End Region

#Region "Grid de Ganado"
    Private Sub dgvGanado_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvGanado.EditingControlShowing
        If Not e.Control Is Nothing Then
            RemoveHandler e.Control.KeyPress, AddressOf ValidarNumericos

            If dgvGanado.Columns(dgvGanado.CurrentCell().ColumnIndex).Name = "clmTipoGanado" Then
                Dim control As DataGridViewComboBoxEditingControl = CType(e.Control, DataGridViewComboBoxEditingControl)
                If control.SelectedValue <> -1 Then
                    control.SelectedValue = -1
                    control.SelectedText = "Seleccione el tipo de ganado"
                End If
            ElseIf dgvGanado.Columns(dgvGanado.CurrentCell().ColumnIndex).Name = "clmCabezas" Then
                AddHandler e.Control.KeyPress, AddressOf ValidarNumericos
            End If
        End If
    End Sub

    Private Sub dgvGanado_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvGanado.CellEndEdit
        If dgvGanado.Columns(e.ColumnIndex).Name = "clmCabezas" Then
            txtTotalCabezas.Text = CalcularTotalCabezas()
        End If
    End Sub

    Private Sub dgvGanado_RowValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvGanado.RowValidating
        If Not dgvGanado.Rows(e.RowIndex) Is Nothing And Not dgvGanado.Rows(e.RowIndex).IsNewRow And dgvGanado.IsCurrentRowDirty Then
            If dgvGanado.Rows(e.RowIndex).Cells("clmTipoGanado").Value Is Nothing Then
                e.Cancel = True
                MsgBox("Debe especificar el tipo de ganado", MsgBoxStyle.Exclamation, "Aviso")
                Exit Sub
            ElseIf Not IsNumeric(dgvGanado.Rows(e.RowIndex).Cells("clmCabezas").Value) Then
                e.Cancel = True
                MsgBox("Debe especificar el numero de cabezas", MsgBoxStyle.Exclamation, "Aviso")
                Exit Sub
            ElseIf dgvGanado.Rows(e.RowIndex).Cells("clmCabezas").Value <= 0 Then
                e.Cancel = True
                MsgBox("Debe especificar una cantidad positiva de numero de cabezas", MsgBoxStyle.Exclamation, "Aviso")
                Exit Sub
            End If

            For i As Integer = 0 To dgvGanado.Rows.Count - 2
                If i <> e.RowIndex AndAlso dgvGanado.Rows(i).Cells("clmTipoGanado").Value = dgvGanado.Rows(e.RowIndex).Cells("clmTipoGanado").Value Then
                    e.Cancel = True
                    MsgBox("Ya se ha proporcionado ese tipo de ganado", MsgBoxStyle.Exclamation, "Aviso")
                    Exit Sub
                End If
            Next
        End If
    End Sub

    Private Sub dgvGanado_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles dgvGanado.PreviewKeyDown
        If e.KeyCode = Keys.Delete Then
            If e.KeyCode = Keys.Delete Then
                Dim resultado As New Windows.Forms.DialogResult

                If Not dgvGanado.CurrentRow Is Nothing Then
                    If dgvGanado.CurrentRow.Index <> dgvGanado.Rows.Count - 1 Then
                        resultado = _
                        MessageBox.Show("¿Seguro que quiere eliminarlo?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

                        If resultado = Windows.Forms.DialogResult.Yes Then
                            dgvGanado.Rows.RemoveAt(dgvGanado.CurrentRow.Index)
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub dgvGanado_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvGanado.DataError

    End Sub
#End Region

#Region "Boton Bascula"
    Private Sub chkBascula_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBascula.CheckedChanged
        Try
            If Me.chkBascula.Checked Then
                'Me.TextBox1.Text = ClasesNegocio.LecturaBasculaClass.ObtenerPeso(String.Format("<9  41290   355{0}<9  41285   355{0}<9  41280   355{0}<9  41280   355{0}<9  41275   355{0}<9  41275   355{0}<9  41275   355{0}<9  41280   3", vbNewLine), LecturaBasculaClass.TipoLectura.GRAMOS, LecturaBasculaClass.TipoLectura.KILOGRAMOS).ToString("N2")
                Me.txtLeerPeso.OpenPort()
                Me.chkBascula.Text = "Lectura de Bascula Activada"
            Else
                Me.txtLeerPeso.ClosePort()
                Me.chkBascula.Text = "Lectura de Bascula Desactivada"
            End If
        Catch UAex As UnauthorizedAccessException
            MsgBox("No se pudo conectar a la bascula, pruebe que este encendida o que no se este usando una lectura de bascula en otra ventana o aplicación", MsgBoxStyle.Exclamation, "Aviso")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

    Private Sub txtProveedor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProveedor.TextChanged
        If Not txtProveedor.Text = String.Empty Then
            For Each item As EC.ProveedorEntity In cmbProveedor.Items
                If item.Codigo = txtProveedor.Text Then
                    cmbProveedor.SelectedItem = item
                    Exit Sub
                End If
            Next
        End If
        cmbProveedor.SelectedValue = -1
        cmbProveedor.Text = "Seleccione el proveedor"
    End Sub

    Private Sub txtCodigoProducto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigoProducto.TextChanged
        If Not txtCodigoProducto.Text = String.Empty Then
            For Each item As EC.ProductoEntity In cmbProducto.Items
                If item.Codigo = txtCodigoProducto.Text Then
                    cmbProducto.SelectedItem = item
                    Exit Sub
                End If
            Next
        End If
        cmbProducto.SelectedValue = -1
        cmbProducto.Text = "Seleccione el producto"
    End Sub

    Private Sub cmbProveedor_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProveedor.SelectedValueChanged
        If Not cmbProveedor.SelectedValue Is Nothing Then
            txtProveedor.Text = cmbProveedor.SelectedValue.ToString()
        End If
    End Sub

    Private Sub cmbProducto_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProducto.SelectedValueChanged
        If Not cmbProducto.SelectedValue Is Nothing Then
            txtCodigoProducto.Text = cmbProducto.SelectedValue.ToString()
        End If
    End Sub

    Private Sub cmbProveedor_Format(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ListControlConvertEventArgs) Handles cmbProveedor.Format
        e.Value = e.Value.ToString().Trim()
    End Sub

    Private Sub cmbProducto_Format(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ListControlConvertEventArgs) Handles cmbProducto.Format
        e.Value = e.Value.ToString().Trim()
    End Sub

    Private Sub CalcularRecibidos(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKilos2Pesada.TextChanged, txtKilos1Pesada.TextChanged
        If State = FormState.Editar Then
            txtKilosRecibidos.Text = (Double.Parse(IIf(txtKilos2Pesada.Text = String.Empty, "0", txtKilos2Pesada.Text)) - Double.Parse(IIf(txtKilos1Pesada.Text = String.Empty, "0", txtKilos1Pesada.Text))).ToString()
        End If
    End Sub

    Private Sub EnterTab(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKilosEnviados.KeyPress, txtUnidad.KeyPress, txtProveedor.KeyPress, txtProducto.KeyPress, txtPlacas.KeyPress, txtObservaciones.KeyPress, txtKilosRecibidos.KeyPress, txtKilos2Pesada.KeyPress, txtKilos1Pesada.KeyPress, txtConductor.KeyPress, txtCodigoProducto.KeyPress, rbnSi.KeyPress, rbnNo.KeyPress, dtpFecha.KeyPress, cmbProveedor.KeyPress, txtFolio.KeyPress, cmbProducto.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            SelectNextControl(sender, True, True, True, True)
        End If
    End Sub

    Private Sub txtLeerPeso_SerialDataArrived(ByVal sender As System.Object, ByVal e As wclTextBoxSerial.SerialDataArrivedEventArgs) Handles txtLeerPeso.SerialDataArrived
        'En e.Data esta el grupo de caracteres recibidos desde el puerto serial
        If e.Data.Length >= 50 Then 'Si llegan 25 caracteres procesarlos
            Dim res As String = (ClasesNegocio.LecturaBasculaClass.ObtenerPeso(e.Data.Substring(0, 50), _
                                LecturaBasculaClass.TipoLectura.KILOGRAMOS, _
                                LecturaBasculaClass.TipoLectura.KILOGRAMOS)).ToString("N2") 'Se divide entre 10 por q la bascula de cortes arroja 3 decimales

            Dim CampoPesada As TextBox = DetectarCampoPesada()
            If CampoPesada IsNot Nothing Then
                CampoPesada.Text = res
            End If
        Else
            e.Handled = True 'Ignora los caracteres
        End If
    End Sub

    Private Sub rbnSi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnSi.CheckedChanged
        txtKilos1Pesada.ReadOnly = True
        txtKilos2Pesada.ReadOnly = False
    End Sub

    Private Sub rbnNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnSi.CheckedChanged, rbnNo.CheckedChanged
        txtKilos1Pesada.ReadOnly = False
        txtKilos2Pesada.ReadOnly = True
    End Sub

#End Region
End Class