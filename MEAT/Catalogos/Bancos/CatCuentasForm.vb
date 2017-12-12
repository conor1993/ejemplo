Imports CN = ClasesNegocio
Imports Integra.Clases
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses

Public Class CatCuentasForm
    Implements InterfaceForm

#Region " Declaraciones "
    Private blEstatus As CondicionEnum = CondicionEnum.ACTIVOS
    Private WithEvents Cuenta As CN.CuentaClass
    Private Empresa As CN.EmpresaClass
    Private seleccion As New Integra.Clases.BusquedaClass(Of CN.CuentaClass)
#End Region

#Region " Forma "
    Private Sub CatCuentasForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Me.lblTitulo.Text = Me.Text.ToUpper
            ' Barra de botones de la ToolBar...
            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            MtbEstados.StateBuscar = "110101111"
            Me.mtb.Buttons(2).ToolTipText = "Limpia todos los datos que ya hayan sido capturados."
            MtbEstados.StateLimpiar = ""
            Me.mtb.Buttons(3).ToolTipText = "Cancela la acción actual."
            MtbEstados.StateCancelar = "000100011"
            Me.mtb.Buttons(5).ToolTipText = "Crea una nueva Cuenta."
            MtbEstados.StateNuevo = "011010001"
            Me.mtb.Buttons(6).ToolTipText = "Guarda la Cuenta o los cambios que se le hayan Realizado."
            MtbEstados.StateGuardar = "110100011"
            Me.mtb.Buttons(7).ToolTipText = "Cambia el estatus de la Cuenta."
            MtbEstados.StateBorrar = "100100001"
            Me.mtb.Buttons(8).ToolTipText = "Permite Modificar la Cuenta."
            MtbEstados.StateEditar = "001010000"
            Me.mtb.Buttons(10).ToolTipText = "Imprime Las Cuentas Registradss."
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""
            mtb.ToolBarButtonStatus = MtbEstados
            mtb.sbCambiarEstadoBotones("Cancelar")
            Empresa = New CN.EmpresaClass(Controlador.Sesion.Empndx)
            Cuentas.Obtener(Empresa, blEstatus)
            RellenarBancos()
            RellenarTiposMoneda()
            Limpiar()
            Lectura()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region " Metodos "
    Public Sub Escritura() Implements InterfaceForm.Escritura
        pan.Enabled = True
        gpo.Enabled = False
    End Sub

    Public Sub Lectura() Implements InterfaceForm.Lectura
        pan.Enabled = False
        gpo.Enabled = True
    End Sub

    Public Sub Limpiar() Implements InterfaceForm.Limpiar
        Try
            txtSdoIni.Enabled = True
            txtSdoIni.Text = 0
            txtCuentaHabiente.Clear()
            txtCuenta.Clear()
            txtDescripcion.Clear()
            lblEstatus.Visible = False
            txtCtaCont.Clear()
            LimpiarBancos()
            LimpiarTiposMoneda()
            Me.Txtfiltro.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MEAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Mostrar() Implements InterfaceForm.Mostrar
        txtCuenta.Text = Cuenta.Cuenta
        txtBanco.Text = Cuenta.Banco.DescripcionCta
        txtSdoIni.Text = Cuenta.SaldoInicial
        txtTipoMoneda.Text = Cuenta.TipoMoneda.DescripcionCorta
        lblEstatus.Visible = True
        lblEstatus.Text = Cuenta.Estatus.ToString
        txtDescripcion.Text = Cuenta.Descripcion
        txtCuentaHabiente.Text = Cuenta.CuentaHabiente
        txtCtaCont.Text = String.Format("{0} : {1}", Cuenta.CuentaContable.NombreCuenta, Cuenta.CuentaContable.CuentaContable)
    End Sub

    Public Function Validar() As String Implements InterfaceForm.Validar
        Dim Cadena As String = "Faltan los siguientes datos:" & vbCrLf
        Dim Bl As Boolean = False
        If cmbBanco.SelectedIndex < 0 Then
            Cadena &= "* Banco" & vbCrLf
            Bl = True
        End If
        If cmbTipoMoneda.SelectedIndex < 0 Then
            Cadena &= "* Tipo de Moneda" & vbCrLf
            Bl = True
        End If
        If txtCuentaHabiente.Text.Replace(" ", "").Length = 0 Then
            Cadena &= "* Cuenta Habiente" & vbCrLf
            Bl = True
        End If
        If txtCuenta.Text.Replace(" ", "").Length = 0 Then
            Cadena &= "* No. de Chequera" & vbCrLf
            Bl = True
        End If
        If txtDescripcion.Text.Replace(" ", "").Length = 0 Then
            Cadena &= "* Descripción" & vbCrLf
            Bl = True
        End If
        If IsNothing(Cuenta.CuentaContable) Then
            Cadena &= "* Cuenta Contable" & vbCrLf
            Bl = True
        End If
        If Not Bl Then
            Cadena = Nothing
            Cuenta.Cuenta = txtCuenta.Text
            Cuenta.Banco = DirectCast(cmbBanco.SelectedItem, CN.BancosClass)
            Cuenta.TipoMoneda = DirectCast(cmbTipoMoneda.SelectedItem, CN.TipoMonedaClass)
            Cuenta.Empresa = Empresa
            Cuenta.Descripcion = txtDescripcion.Text
            Cuenta.SaldoInicial = txtSdoIni.Valor
            Cuenta.CuentaHabiente = txtCuentaHabiente.Text
        End If
        Return Cadena
    End Function
#End Region

#Region " Rellenar "
    Private Sub LimpiarBancos()
        txtBanco.Clear()
        cmbBanco.SelectedIndex = -1
        cmbBanco.Text = "Seleccione un Banco..."
    End Sub

    Private Sub RellenarBancos()
        BancosC.Obtener(CN.CondicionEnum.ACTIVOS)
        txtBanco.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtBanco.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtBanco.AutoCompleteCustomSource.AddRange(BancosC.Listar)
    End Sub


    Private Sub cmbBanco_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBanco.SelectedIndexChanged
        If cmbBanco.SelectedIndex > -1 Then
            txtBanco.Text = cmbBanco.SelectedValue
        End If
    End Sub

    Private Sub txtBanco_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBanco.KeyDown, cmbBanco.KeyDown
        Select Case e.KeyCode
            Case Keys.F12
                BancosC.Obtener(CN.CondicionEnum.ACTIVOS)
        End Select
    End Sub

    Private Sub txtBanco_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBanco.TextChanged
        cmbBanco.SelectedValue = txtBanco.Text
    End Sub

    Private Sub LimpiarTiposMoneda()
        txtTipoMoneda.Clear()
        cmbTipoMoneda.SelectedIndex = -1
        cmbTipoMoneda.Text = "Seleccione un Tipo de Moneda..."
    End Sub

    Private Sub RellenarTiposMoneda()
        TiposMoneda.Obtener(CondicionEnum.ACTIVOS)
        txtTipoMoneda.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtTipoMoneda.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtTipoMoneda.AutoCompleteCustomSource.AddRange(TiposMoneda.Listar)
    End Sub

    Private Sub cmbTipoMoneda_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTipoMoneda.SelectedIndexChanged
        If cmbTipoMoneda.SelectedIndex > -1 Then
            txtTipoMoneda.Text = cmbTipoMoneda.SelectedValue
        End If
    End Sub

    Private Sub txtTipoMoneda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoMoneda.KeyDown, cmbTipoMoneda.KeyDown
        Select Case e.KeyCode
            Case Keys.F12
                TiposMoneda.Obtener(CondicionEnum.ACTIVOS)
        End Select
    End Sub

    Private Sub txtTipoMoneda_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTipoMoneda.TextChanged
        cmbTipoMoneda.SelectedValue = txtTipoMoneda.Text
    End Sub
#End Region

#Region " ToolBar "
    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Cancelar = True
        If Cuenta.Borrar() Then
            MsgBox("La cuenta ha sido cancelada", MsgBoxStyle.Exclamation, "Aviso")
            Limpiar()
            Lectura()
        Else
            Cancelar = True
        End If
        Cuentas.Obtener(Empresa, blEstatus)
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Cuenta = Nothing
        Lectura()
        Limpiar()
        Cuentas.Obtener(Empresa, blEstatus)
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        'Escritura()
        'txtSdoIni.Enabled = False
        If Cuenta.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
            Escritura()
            txtSdoIni.Enabled = False
            Me.txtBanco.Focus()

        Else
            If MessageBox.Show("La Cuenta Bancaria esta Inactiva, ¿Desea activarla?", "Activar Cuenta Bancaria", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                Cuenta.Estatus = ClasesNegocio.EstatusEnum.ACTIVO
                Me.lblEstatus.Text = Cuenta.Estatus.ToString
                Escritura()
                Me.txtBanco.Focus()
            Else
                Cancelar = True
                mtb.sbCambiarEstadoBotones("Guardar")
                Limpiar()
                Lectura()
            End If
        End If
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Cancelar = True
        If IsNothing(Validar()) Then
            If Cuenta.Guardar() Then
                MsgBox("La Cuenta Bancaria ha sido Guardada Satisfactoriamente...")
                Limpiar()
                Lectura()
                Cancelar = False
            End If
        Else
            MessageBox.Show(Validar, "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Cuentas.Obtener(Empresa, blEstatus)
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Dim pre As New ClasesNegocio.PreVisualizarForm
        pre.Reporte = Me.Cuentas.Reporte(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnomcom)
        pre.ShowDialog()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Limpiar()
        Escritura()
        Cuenta = New ClasesNegocio.CuentaClass
        Me.cmbBanco.Focus()
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub
#End Region

#Region " Otros "
    Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodos.CheckedChanged
        If chkTodos.Checked Then
            blEstatus = CondicionEnum.TODOS
        Else
            blEstatus = CondicionEnum.ACTIVOS
        End If
        Cuentas.Obtener(Empresa, blEstatus)
    End Sub
#End Region

#Region " DataGrid "
    Private Sub dgvCuenta_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvCuentas.Click
        Cuenta = Nothing
        Cuenta = seleccion.ObtenerdeDataGrid(dgvCuentas)
        If Not IsNothing(Cuenta) Then
            Mostrar()
            mtb.sbCambiarEstadoBotones("Buscar")
        End If
    End Sub
#End Region

    Private Sub Cuenta_Mensajes(ByVal sender As Object, ByVal Message As ClasesNegocio.MensajeClass) Handles Cuenta.Mensajes
        MessageBox.Show(Message.Mensaje, Message.Titulo, MessageBoxButtons.OK, Message.Tipo)
    End Sub

    Dim bl As Boolean = False

    Private Sub txtSdoIni_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSdoIni.TextChanged
        If Not bl Then
            bl = True
            txtSdoIni.Text = txtSdoIni.Valor.ToString("C")
            bl = False
        End If
    End Sub

    Private Sub btnCtaCont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCtaCont.Click
        Try
            Dim CuentaConfiguracion As New CC.CfgCtrlCtasCollection
            Dim Relacion As New OC.RelationCollection
            Dim buscarCuenta As New BusquedaCuentasContablesForm

            buscarCuenta.chkAfe.Checked = True
            buscarCuenta.chkBan.CheckState = CheckState.Indeterminate
            buscarCuenta.chkDep.CheckState = CheckState.Indeterminate
            buscarCuenta.chkIna.Checked = False
            buscarCuenta.chkPre.CheckState = CheckState.Indeterminate
            buscarCuenta.chkRes.CheckState = CheckState.Indeterminate

            buscarCuenta.Var = False
            buscarCuenta.BloquearCaracteristicas = True
            buscarCuenta.AfectableDefault = ClasesNegocio.CondicionAsignadaEnum.SI

            Relacion.Add(EC.CfgCtrlCtasEntity.Relations.ConCfgCtasEntityUsingIdConCfgCtas)
            CuentaConfiguracion.GetMulti(HC.ConCfgCtasFields.Concepto Mod String.Format("%{0}%", "CUENTA DE BANCOS"), 0, Nothing, Relacion)

            If Not CuentaConfiguracion.Count > 0 Then
                MsgBox("No se ha establecido una configuracion contable para este concepto", MsgBoxStyle.Exclamation, Controlador.Sesion.MiEmpresa.Empnom)
                Exit Sub
            End If
            buscarCuenta.txtCta.Text = CuentaConfiguracion(0).CuentaContable.Cta
            buscarCuenta.txtSCta.Text = CuentaConfiguracion(0).CuentaContable.SubCta
            buscarCuenta.txtSSCta.Text = CuentaConfiguracion(0).CuentaContable.SsubCta
            buscarCuenta.txtSSSCta.Text = CuentaConfiguracion(0).CuentaContable.SssubCta

            buscarCuenta.txtNombre.Enabled = False
            buscarCuenta.txtCta.Enabled = False
            buscarCuenta.txtSCta.Enabled = False
            buscarCuenta.txtSSCta.Enabled = False
            buscarCuenta.txtSSSCta.Enabled = False

            If buscarCuenta.ShowDialog = Windows.Forms.DialogResult.OK Then
                Cuenta.CuentaContable = buscarCuenta.CuentaContable
                txtCtaCont.Text = String.Format("{0} : {1}", Cuenta.CuentaContable.NombreCuenta, Cuenta.CuentaContable.CuentaContable)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Sesion.MiEmpresa.Empnom & " - Catalogo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbBanco_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbBanco.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            cmbTipoMoneda.Focus()
            If cmbBanco.Text = "" Then
                MsgBox("Seleccione un Banco", MsgBoxStyle.Exclamation, "Aviso")
                cmbBanco.Focus()
            End If
        End If
    End Sub

    Private Sub cmbTipoMoneda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbTipoMoneda.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            txtCuentaHabiente.Focus()
            If cmbTipoMoneda.Text = "" Then
                MsgBox("Seleccione Tipo Moneda", MsgBoxStyle.Exclamation, "Aviso")
                cmbTipoMoneda.Focus()
            End If
        End If
    End Sub

    Private Sub txtCuentaHabiente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCuentaHabiente.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            txtCuenta.Focus()
            If txtCuentaHabiente.Text = "" Then
                MsgBox("Agregue Información a Cuenta Habiente", MsgBoxStyle.Exclamation, "Aviso")
                txtCuentaHabiente.Focus()
            End If
        End If
    End Sub

    Private Sub txtCuenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCuenta.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            txtSdoIni.Focus()
            If txtCuenta.Text = "" Then
                MsgBox("Agregue Información a Cuenta", MsgBoxStyle.Exclamation, "Aviso")
                txtCuenta.Focus()
            End If
        End If
    End Sub

    Private Sub txtSdoIni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSdoIni.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            txtDescripcion.Focus()
            If txtSdoIni.Text = "" Then
                MsgBox("Agregue Información a Saldo Inicial", MsgBoxStyle.Exclamation, "Aviso")
                txtSdoIni.Focus()
            End If
        End If
    End Sub

    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            txtCtaCont.Focus()
            If txtDescripcion.Text = "" Then
                MsgBox("Agregue Información a Descripción", MsgBoxStyle.Exclamation, "Aviso")
                txtDescripcion.Focus()
            End If
        End If
    End Sub

    Private Sub Txtfiltro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtfiltro.TextChanged
        Me.Cuentas.Obtener(Me.Txtfiltro.Text, Controlador.Sesion.Empndx)
        ' Me.dgvCuentas.DataSource = Cuentas
    End Sub

End Class