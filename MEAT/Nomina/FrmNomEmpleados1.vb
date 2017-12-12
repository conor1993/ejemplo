Imports CN = ClasesNegocio
Public Class FrmNomEmpleados
    Dim Empleados As New CN.NomcatempleadosClass
    Dim EmpleadoC As New CN.EmpleadosCollectionClass
    Dim Estados As New CN.EstadoCollectionClass
    Dim Ciudades As New CN.CiudadCollectionClass
    Dim Poblaciones As New CN.PoblacionCollectionClass
    ' dim puestos as New CN.
    Dim dias As New CN.DiasClass
    Dim turno As New CN.TurnosClass
    Dim Editar As Boolean = False
    Dim PrimaVacacional As Decimal = 0
    Dim FactorIntegracion As Decimal = 0
    Dim DiasVacaciones As Decimal = 0
    Dim Inicio As Boolean

    Private Sub FrmNomEmpleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Icon = MdiParent.Icon
            Me.mtb.Buttons(1).Visible = False
            Me.mtb.Buttons(4).Visible = False
            Dim tbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            tbEstados.StateBuscar = "001101111"
            tbEstados.StateLimpiar = ""
            tbEstados.StateCancelar = "100100011"
            tbEstados.StateNuevo = "011010001"
            tbEstados.StateGuardar = "100100011"
            tbEstados.StateBorrar = "100100011"
            tbEstados.StateEditar = "001011001"
            tbEstados.StateImprimir = ""
            tbEstados.StateSalir = ""

            Me.mtb.ToolBarButtonStatus = tbEstados
            Me.mtb.sbCambiarEstadoBotones("Cancelar")

            Dim DepartamentoC As New CN.DepartamentosCollectionClas
            DepartamentoC.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            Me.cmbDepartamentos.DisplayMember = "descripcion"
            Me.cmbDepartamentos.ValueMember = "codigo"
            Me.cmbDepartamentos.DataSource = DepartamentoC

            Dim PuestosC As New CN.PuestosCollectionClass
            PuestosC.Obtener("", ClasesNegocio.CondicionEnum.ACTIVOS)
            Me.cmbPuestos.DisplayMember = "Descripcion"
            Me.cmbPuestos.ValueMember = "Codigo"
            Me.cmbPuestos.DataSource = PuestosC

            Me.cmbTurno.DisplayMember = "turno"
            Me.cmbTurno.ValueMember = "turno"
            Me.cmbTurno.DataSource = turno

            Me.cmbDiasDescanso.DisplayMember = "dia"
            Me.cmbDiasDescanso.ValueMember = "dia"
            Me.cmbDiasDescanso.DataSource = dias

            'Estados

            Estados.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            Me.CmbEstado.DisplayMember = "Descripcion"
            Me.CmbEstado.ValueMember = "Codigo"
            Me.CmbEstado.DataSource = Estados

            'Ciudades

            Ciudades.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            Me.CmbCiudad.DisplayMember = "Descripcion"
            Me.CmbCiudad.ValueMember = "Codigo"
            Me.CmbCiudad.DataSource = Ciudades

            'Poblaciones

            Poblaciones.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            Me.CmbPoblacion.DisplayMember = "Descripcion"
            Me.CmbPoblacion.ValueMember = "Codigo"
            Me.CmbPoblacion.DataSource = Poblaciones

            Limpiar()
            Deshabilitar()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

#Region "Metodos"

    Sub Limpiar()
        Me.txtCodigo.Text = ""
        Me.txtApellidoMaterno.Text = ""
        Me.txtApellidoPaterno.Text = ""
        Me.txtCelular.Text = ""
        Me.txtCodigoPostal.Text = ""
        Me.txtColonia.Text = ""
        Me.txtConyuge.Text = ""
        Me.txtCURP.Text = ""
        Me.txtDireccion.Text = ""
        Me.txtEstadoCivil.Text = ""
        Me.txtNoFonacot.Text = ""
        Me.txtNoIMSS.Text = ""
        Me.TxtNoClinica.Text = ""
        Me.TxtNomClinica.Text = ""
        Me.txtNombre.Text = ""
        Me.txtPadre.Text = ""
        Me.txtRFC.Text = ""
        Me.txtTelefono.Text = ""
        Me.TxtDiasAguinaldo.Text = ""
        Me.TxtDiaAguiAdicional.Text = ""
        Me.TxtDiasVacaciones.Text = ""
        Me.TxtDiaVacaAdicional.Text = ""
        Me.TxtDiasPrimaVacacion.Text = ""
        Me.TxtFactorIntegracion.Text = ""
        Me.txtSalarioActual.Text = ""
        Me.txtSDI.Text = ""
        Me.CmbCiudad.Text = ""
        Me.CmbCiudad.SelectedIndex = -1
        Me.cmbDepartamentos.Text = ""
        Me.cmbDepartamentos.SelectedIndex = -1
        Me.cmbDiasDescanso.Text = ""
        Me.cmbDiasDescanso.SelectedIndex = -1
        Me.CmbEstado.Text = ""
        Me.CmbEstado.SelectedIndex = -1
        Me.CmbPoblacion.Text = ""
        Me.CmbPoblacion.SelectedIndex = -1

        Me.cmbPuestos.Text = ""
        Me.cmbPuestos.SelectedIndex = -1
        Me.cmbTurno.Text = ""
        Me.cmbTurno.SelectedIndex = -1
        Me.lblEstatus.Visible = False
        Me.TxtInfonavit.Text = ""
        Me.TxtImporteDesc.Text = ""
        Me.lblDescuento.Visible = False
        Me.TxtPenAlimenticia.Text = ""
        Me.TxtPenAlimenticia.Visible = False
        Me.ChkPAlimenticia.Checked = False
        Me.DtpFechaIngreso.Value = Now
        Me.dtpFechaNacimiento.Value = Now
        Me.DtpFechaOtorgoCredito.Value = Now
    End Sub

    Sub Habilitar()
        Me.txtApellidoMaterno.Enabled = True
        Me.txtApellidoPaterno.Enabled = True
        Me.txtCelular.Enabled = True
        Me.txtCodigoPostal.Enabled = True
        Me.txtColonia.Enabled = True
        Me.txtConyuge.Enabled = True
        Me.txtCURP.Enabled = True
        Me.txtDireccion.Enabled = True
        Me.txtEstadoCivil.Enabled = True
        Me.txtNoFonacot.Enabled = True
        Me.txtNoIMSS.Enabled = True
        Me.TxtNoClinica.Enabled = True
        Me.TxtNomClinica.Enabled = True
        Me.txtNombre.Enabled = True
        Me.txtPadre.Enabled = True
        Me.txtMadre.Enabled = True
        Me.txtRFC.Enabled = True
        Me.txtSalarioActual.Enabled = True
        Me.txtSDI.Enabled = False
        Me.txtTelefono.Enabled = True
        Me.TxtDiasAguinaldo.Enabled = True
        Me.TxtDiaAguiAdicional.Enabled = True
        Me.TxtDiasVacaciones.Enabled = True
        Me.TxtDiaVacaAdicional.Enabled = True
        Me.TxtDiasPrimaVacacion.Enabled = False
        Me.TxtFactorIntegracion.Enabled = False
        Me.CmbCiudad.Enabled = True
        Me.cmbDepartamentos.Enabled = True
        Me.cmbDiasDescanso.Enabled = True
        Me.CmbEstado.Enabled = True
        Me.CmbPoblacion.Enabled = True
        Me.cmbPuestos.Enabled = True
        Me.cmbTurno.Enabled = True
        Me.dtpFechaNacimiento.Enabled = True
        Me.TxtInfonavit.Enabled = True
        Me.TxtImporteDesc.Enabled = True
        Me.DtpFechaIngreso.Enabled = True
        Me.DtpFechaOtorgoCredito.Enabled = True
        Me.ChkPAlimenticia.Enabled = True
    End Sub

    Sub Deshabilitar()
        Me.txtCodigo.Enabled = False
        Me.txtApellidoMaterno.Enabled = False
        Me.txtApellidoPaterno.Enabled = False
        Me.txtCelular.Enabled = False
        Me.txtCodigoPostal.Enabled = False
        Me.txtColonia.Enabled = False
        Me.txtConyuge.Enabled = False
        Me.txtCURP.Enabled = False
        Me.txtDireccion.Enabled = False
        Me.txtEstadoCivil.Enabled = False
        Me.txtNoFonacot.Enabled = False
        Me.txtNoIMSS.Enabled = False
        Me.txtNombre.Enabled = False
        Me.txtPadre.Enabled = False
        Me.txtMadre.Enabled = False
        Me.txtRFC.Enabled = False
        Me.txtTelefono.Enabled = False
        Me.TxtDiasAguinaldo.Enabled = False
        Me.TxtDiaAguiAdicional.Enabled = False
        Me.TxtDiasVacaciones.Enabled = False
        Me.TxtDiaVacaAdicional.Enabled = False
        Me.TxtDiasPrimaVacacion.Enabled = False
        Me.TxtFactorIntegracion.Enabled = False
        Me.txtSalarioActual.Enabled = False
        Me.txtSDI.Enabled = False
        Me.CmbCiudad.Enabled = False
        Me.cmbDepartamentos.Enabled = False
        Me.cmbDiasDescanso.Enabled = False
        Me.CmbEstado.Enabled = False
        Me.CmbPoblacion.Enabled = False

        Me.cmbPuestos.Enabled = False
        Me.cmbTurno.Enabled = False
        Me.dtpFechaNacimiento.Enabled = False
        Me.TxtInfonavit.Enabled = False
        Me.TxtImporteDesc.Enabled = False
        Me.TxtPenAlimenticia.Enabled = False
        Me.DtpFechaIngreso.Enabled = False
        Me.DtpFechaOtorgoCredito.Enabled = False
        Me.TxtPenAlimenticia.Enabled = False
        Me.TxtPenAlimenticia.Visible = False
    End Sub

    Private Function Guardar() As Boolean
        Try
            Empleados.ApellidoMaterno = Me.txtApellidoMaterno.Text
            Empleados.ApellidoPaterno = Me.txtApellidoPaterno.Text
            Empleados.AplicaIMSS = Me.chkIMSS.Checked
            Empleados.AplicaISR = Me.chkISR.Checked
            Empleados.Celular = Me.txtCelular.Text
            Empleados.CodigoPostal = Me.txtCodigoPostal.Text
            Empleados.Poblacion = DirectCast(CmbPoblacion.SelectedItem, ClasesNegocio.PoblacionClass)
            Empleados.Colonia = Me.txtColonia.Text
            Empleados.Conyuge = Me.txtConyuge.Text
            Empleados.CURP = Me.txtCURP.Text
            Empleados.Descanso = Me.cmbDiasDescanso.SelectedValue
            Empleados.Domicilio = Me.txtDireccion.Text
            Empleados.EstadoCivil = Me.txtEstadoCivil.Text
            Empleados.FechaNacimiento = Me.dtpFechaNacimiento.Value.ToShortDateString
            Empleados.FONACOT = Me.txtNoFonacot.Text
            Empleados.IdDepartamento = Me.cmbDepartamentos.SelectedValue
            Empleados.IdPuesto = DirectCast(Me.cmbPuestos.SelectedItem, CN.NomcatpuestosClass)
            Empleados.IMSS = Me.txtNoIMSS.Text
            Empleados.Madre = Me.txtMadre.Text
            Empleados.Nombres = Me.txtNombre.Text
            Empleados.Padre = Me.txtPadre.Text
            Empleados.RFC = Me.txtRFC.Text
            Empleados.Salario = Me.txtSalarioActual.Text
            Empleados.SDI = Me.txtSDI.Text
            If Me.optMasculino.Checked Then
                Empleados.SEXO = True
            Else
                Empleados.SEXO = False
            End If

            If Me.RbtVsm.Checked Then
                Empleados.TipoCredito = True
            Else
                Empleados.TipoCredito = False
            End If
            Empleados.Telefonos = Me.txtTelefono.Text

            Empleados.DiasAginaldo = Me.TxtDiasAguinaldo.Text
            Empleados.DiasAginaldoAdicional = Me.TxtDiaAguiAdicional.Text
            Empleados.DiasVacaciones = Me.TxtDiasVacaciones.Text
            Empleados.DiasVacacionesAdicional = Me.TxtDiaVacaAdicional.Text
            Empleados.DiasPrimaVacacional = Me.TxtDiasPrimaVacacion.Text
            Empleados.Factor = Me.TxtFactorIntegracion.Text

            Empleados.Turno = Me.cmbTurno.SelectedValue
            Empleados.FechaAlta = Me.dtpFechaAlta.Value
            Empleados.FechaIngreso = Me.DtpFechaIngreso.Value
            Empleados.FechaOtorgoCredito = Me.DtpFechaOtorgoCredito.Value
            Empleados.Infonavit = Me.TxtInfonavit.Text
            Empleados.ImporteInfonavit = Me.TxtImporteDesc.Text
            Empleados.AplicaPension = Me.ChkPAlimenticia.Checked
            'Empleados.ImportePensionAlimenticia = Me.TxtPenAlimenticia.Text
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub PonerDatos()
        Me.txtCodigo.Text = Empleados.Codigo
        Me.txtApellidoMaterno.Text = Empleados.ApellidoMaterno
        Me.txtApellidoPaterno.Text = Empleados.ApellidoPaterno
        Me.chkIMSS.Checked = Empleados.AplicaIMSS
        Me.chkISR.Checked = Empleados.AplicaISR
        Me.txtCelular.Text = Empleados.Celular
        Me.txtCodigoPostal.Text = Empleados.CodigoPostal
        Me.txtColonia.Text = Empleados.Colonia
        Me.txtTelefono.Text = Empleados.Telefonos
        Me.txtConyuge.Text = Empleados.Conyuge
        Me.txtCURP.Text = Empleados.CURP
        Me.cmbDiasDescanso.SelectedValue = Empleados.DiasDescanso.Dia
        Me.txtDireccion.Text = Empleados.Domicilio
        Me.txtEstadoCivil.Text = Empleados.EstadoCivil
       
        CmbEstado.SelectedValue = Empleados.Estado.Codigo
        CmbCiudad.SelectedValue = Empleados.Ciudad.Codigo
        CmbPoblacion.SelectedValue = Empleados.Poblacion.Codigo

        Me.dtpFechaNacimiento.Value = Empleados.FechaNacimiento
        Me.txtNoFonacot.Text = Empleados.FONACOT
        Me.cmbDepartamentos.SelectedValue = Empleados.Departamento.Codigo
        Me.cmbTurno.SelectedValue = Empleados.TURNOS.Turno
        Me.cmbPuestos.SelectedValue = Empleados.IdPuesto.IdPuesto
        Me.txtNoIMSS.Text = Empleados.IMSS
        Me.txtMadre.Text = Empleados.Madre
        Me.txtNombre.Text = Empleados.Nombres
        Me.txtPadre.Text = Empleados.Padre
        Me.txtRFC.Text = Empleados.RFC
        Me.TxtDiasAguinaldo.Text = Empleados.DiasAginaldo
        Me.TxtDiaAguiAdicional.Text = Empleados.DiasAginaldoAdicional
        Me.TxtDiasVacaciones.Text = Empleados.DiasVacaciones
        Me.TxtDiaVacaAdicional.Text = Empleados.DiasVacacionesAdicional
        Me.TxtDiasPrimaVacacion.Text = Empleados.DiasPrimaVacacional
        Me.TxtFactorIntegracion.Text = Empleados.Factor
        Me.txtSalarioActual.Text = Empleados.Salario
        Me.txtSDI.Text = Empleados.SDI
        Me.TxtInfonavit.Text = Empleados.Infonavit
        Me.TxtImporteDesc.Text = Empleados.ImporteInfonavit
        'Me.lblEstatus.Text = Puestos.Estatus.ToString
        'Me.lblEstatus.Visible = True
        Me.ChkPAlimenticia.Checked = Empleados.AplicaPension
        Me.lblDescuento.Visible = True
        Me.TxtPenAlimenticia.Visible = True
        Me.TxtPenAlimenticia.Text = Empleados.ImportePensionAlimenticia








    End Sub

    Private Function Validar() As Boolean
        Try

            If Trim(Me.txtNombre.Text) = "" Then
                MessageBox.Show("Ingrese el Nombre del Empleado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtNombre.Focus()
                Return False
            End If

            If Trim(Me.txtApellidoPaterno.Text) = "" Then
                MessageBox.Show("Ingrese el Apellido Paterno del Empleado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtApellidoPaterno.Focus()
                Return False
            End If

            If Trim(Me.txtApellidoMaterno.Text) = "" Then
                MessageBox.Show("Ingrese el Apellido Materno del Empleado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtApellidoMaterno.Focus()
                Return False
            End If

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

#End Region

#Region "ToolBar"

    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Try
            'If Empleados.Estatus = ClasesNegocio.EstatusDatos.CANCELADO Then
            '    MsgBox("No se puede cancelar el Empleado debido a que ya se encuentra cancelado", MsgBoxStyle.Information)
            '    Cancelar = True
            '    Exit Sub
            'End If

            If MessageBox.Show("Esta seguro de cancelar el Empleado", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                'Empleados.Estatus = ClasesNegocio.EstatusDatos.CANCELADO
                If Empleados.Borrar Then
                    MsgBox("Se ha cancelado el empleado", MsgBoxStyle.Information, "Aviso")
                    Limpiar()
                    Deshabilitar()
                    'Me.PuestosC.Obtener()
                End If
            Else
                Cancelar = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickBuscar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBuscar
        Try
            Inicio = False
            Dim Ventana As New FrmBusquedaEmpleados
            If Ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                Empleados = New CN.NomcatempleadosClass
                'EmpleadoC.Obtener(Ventana.dgvEmpleados.SelectedRows(0).Cells(Ventana.CodigoDataGridViewTextBoxColumn.Index).Value)
                Empleados.obtener(Ventana.dgvEmpleados.SelectedRows(0).Cells(Ventana.CodigoDataGridViewTextBoxColumn.Index).Value)
                Me.PonerDatos()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Limpiar()
        Deshabilitar()
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Try
            If Not Validar() Then
                Cancelar = True
                Exit Sub
            End If

            If Not Guardar() Then
                Cancelar = True
                Exit Sub
            End If

            If Empleados.Guardar() Then
                MsgBox("El empleado ha sido guardado con el código: " & Empleados.Codigo, MsgBoxStyle.Information, "Aviso")
                Limpiar()
                Deshabilitar()
            End If

            'Me.PuestosC.Obtener()
            'Me.DgvCentros.AutoGenerateColumns = False
            'Me.DgvCentros.DataSource = CentroDeCostosC
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Habilitar()
        Limpiar()
        Me.Empleados = New CN.NomcatempleadosClass
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles mtb.ClickEditar
        If Empleados.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
            Habilitar()
            Editar = True
            Me.txtNombre.Focus()
        Else
            If MessageBox.Show("El Empleado esta Inactivo, ¿Desea activarlo?", "Activar Empleado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                Empleados.Estatus = ClasesNegocio.EstatusEnum.ACTIVO
                Me.lblEstatus.Text = Empleados.Estatus.ToString
                Habilitar()
                Editar = True
                Me.txtNombre.Focus()
            Else
                Cancelar = True
                mtb.sbCambiarEstadoBotones("Guardar")
                Limpiar()
                Deshabilitar()
            End If
        End If
    End Sub

#End Region

#Region "KeyPress"

    Private Sub TxtDiasAguinaldo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDiasAguinaldo.KeyPress
        If e.KeyChar = Chr(13) Then
            If Not Me.TxtDiasAguinaldo.Text = "" Then
                Me.TxtDiasAguinaldo.Text = (CDec(Me.TxtDiasAguinaldo.Text)).ToString("C2")
                Me.TxtDiaAguiAdicional.Focus()
            End If
        End If
    End Sub

    Private Sub TxtDiaAguiAdicional_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDiaAguiAdicional.KeyPress
        If e.KeyChar = Chr(13) Then
            If Not Me.TxtDiaAguiAdicional.Text = "" Then
                Me.TxtDiaAguiAdicional.Text = (CDec(Me.TxtDiaAguiAdicional.Text)).ToString("C2")
                Me.TxtDiasVacaciones.Focus()
            End If
        End If
    End Sub

    Private Sub TxtDiasVacaciones_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDiasVacaciones.KeyPress
        If e.KeyChar = Chr(13) Then
            If Not Me.TxtDiasVacaciones.Text = "" Then
                Me.TxtDiasVacaciones.Text = (CDec(Me.TxtDiasVacaciones.Text)).ToString("C2")
                Me.TxtDiaVacaAdicional.Focus()
            End If
        End If
    End Sub

    Private Sub TxtDiaVacaAdicional_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDiaVacaAdicional.KeyPress
        If e.KeyChar = Chr(13) Then
            If Not Me.TxtDiaVacaAdicional.Text = "" Then
                Me.TxtDiaVacaAdicional.Text = (CDec(Me.TxtDiaVacaAdicional.Text)).ToString("C2")
                Me.txtSalarioActual.Focus()
            End If
        End If
    End Sub

    Private Sub txtSalarioActual_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSalarioActual.KeyPress
        If e.KeyChar = Chr(13) Then
            If Not Me.txtSalarioActual.Text = "" Then
                Me.txtSalarioActual.Text = (CDec(Me.txtSalarioActual.Text)).ToString("C2")
                Me.chkIMSS.Focus()
            End If
        End If
    End Sub

#End Region

    Private Sub CmbEstado_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles CmbEstado.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                Estados = New CN.EstadoCollectionClass
                Estados.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbEstado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbEstado.SelectedIndexChanged
        Try
            If CmbEstado.SelectedIndex > -1 And Not Me.CmbEstado.ValueMember = "" Then
                Ciudades = DirectCast(CmbEstado.SelectedItem, ClasesNegocio.EstadoClass).ObtenerCiudad
                CmbCiudad.DataSource = Ciudades
                Me.CmbCiudad.SelectedIndex = -1
                Me.CmbPoblacion.DataSource = Nothing
                CmbCiudad.Text = "Seleccione una Ciudad..."
            Else
                Me.CmbCiudad.DataSource = Nothing
                Me.CmbPoblacion.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CmbCiudad_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles CmbCiudad.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                Me.cmbEstado_SelectedIndexChanged(Me, e)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CmbCiudad_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbCiudad.SelectedIndexChanged
        Try
            If Me.CmbCiudad.SelectedIndex > -1 And Not Me.CmbCiudad.ValueMember = "" Then
                Poblaciones.Obtener(Me.CmbCiudad.SelectedItem, ClasesNegocio.CondicionEnum.ACTIVOS)
                Poblaciones = DirectCast(CmbCiudad.SelectedItem, ClasesNegocio.CiudadClass).Obtenerpoblacion
                CmbPoblacion.DataSource = Poblaciones
                Me.CmbPoblacion.SelectedIndex = -1
                CmbPoblacion.Text = "Seleccione una Población..."
            Else
                Me.CmbPoblacion.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CmbPoblacion_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles CmbPoblacion.PreviewKeyDown
        If e.KeyCode = Keys.F12 Then
            Poblaciones = New CN.PoblacionCollectionClass
            Poblaciones.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        End If
    End Sub

    Private Sub txtSalarioActual_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSalarioActual.TextChanged
        DiasVacaciones = (CDec(Me.TxtDiasVacaciones.Text) + CDec(Me.TxtDiaVacaAdicional.Text)).ToString("C2")
        Me.TxtDiasPrimaVacacion.Text = (DiasVacaciones * 0.25).ToString("C2")
        Me.TxtFactorIntegracion.Text = ((365 + CDec(Me.TxtDiasAguinaldo.Text) + CDec(TxtDiaAguiAdicional.Text) + CDec(Me.TxtDiasPrimaVacacion.Text)) / 365)
        Me.txtSDI.Text = (CDec(Me.txtSalarioActual.Text) * CDec(Me.TxtFactorIntegracion.Text)).ToString("C4")
    End Sub

    Private Sub ChkPAlimenticia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkPAlimenticia.CheckedChanged
        If Me.ChkPAlimenticia.Checked Then
            Me.lblDescuento.Visible = True
            Me.TxtPenAlimenticia.Visible = True
            Me.TxtPenAlimenticia.Enabled = True
        ElseIf Me.ChkPAlimenticia.Checked = False Then
            Me.lblDescuento.Visible = False
            Me.TxtPenAlimenticia.Visible = False
            Me.TxtPenAlimenticia.Enabled = False
        End If
    End Sub



End Class