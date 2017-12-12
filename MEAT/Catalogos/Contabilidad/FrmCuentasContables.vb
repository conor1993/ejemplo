
Imports CN = ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports TC = IntegraLab.ORM.TypedViewClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports EC = Integralab.ORM.EntityClasses

Public Class FrmCuentasContables

    '/////////////////// CUENTAS FISCALES  /////////////////////////////

#Region "Miembros"

    Private WithEvents Cuenta As CN.CuentaContableClass
    Private CuentaPadre As CN.CuentaContableClass
    Private WithEvents CuentaCont As CN.CuentaContableClass
    Private bl As Boolean = False

#End Region

    Private Sub FrmCuentasContables_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Icon = Me.ParentForm.Icon

            Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
            MtbEstados.StateBuscar = "110101111"
            MtbEstados.StateLimpiar = ""
            MtbEstados.StateCancelar = "000100011"
            MtbEstados.StateNuevo = "011010001"
            MtbEstados.StateGuardar = "110100011"
            MtbEstados.StateBorrar = "100100001"
            MtbEstados.StateEditar = "001010001"
            MtbEstados.StateImprimir = ""
            MtbEstados.StateSalir = ""
            mtb.ToolBarButtonStatus = MtbEstados
            'Me.mtb.Buttons(0).ToolTipText = "Busca los Proveedores Registrados."
            Me.mtb.Buttons(2).ToolTipText = "Limpia todos los datos que ya hayan sido capturados."
            Me.mtb.Buttons(3).ToolTipText = "Cancela la acción actual."
            Me.mtb.Buttons(5).ToolTipText = "Crea una nueva Cuenta Contable."
            Me.mtb.Buttons(6).ToolTipText = "Guarda la Cuenta Contable o los cambios que se le hayan Realizado."
            Me.mtb.Buttons(7).ToolTipText = "Cambia el estatus de la Cuenta Contable a Inactiva."
            Me.mtb.Buttons(8).ToolTipText = "Permite Modificar la Cuenta Contable."
            Me.mtb.Buttons(10).ToolTipText = "Imprime las Cuentas Contables Registradas."
            Me.mtb.Buttons(12).ToolTipText = "Cierra la Ventana Ignorando los cambios que no hayan sido Guardados."
            Me.mtb.Buttons(4).Visible = False
            Me.mtb.Buttons(1).Visible = False
            mtb.sbCambiarEstadoBotones("Cancelar")

            Lectura()
            Me.MostrarCuentas()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#Region "Metodos"
    Public Sub Escritura()
        pan.Enabled = True
        gpo.Enabled = False
    End Sub

    Public Sub Lectura()
        pan.Enabled = False
        gpo.Enabled = True

    End Sub

    Public Sub Limpiar()
        Try
            txtNombre.Clear()
            txtCtaC.Clear()
            For Each ctrl As Control In Me.pan.Controls
                Select Case ctrl.GetType.ToString
                    'Case GetType(Integra.Controles.TextboxDecimal).ToString
                    '    DirectCast(ctrl, Integra.Controles.TextboxDecimal).Clear()
                    Case GetType(System.Windows.Forms.GroupBox).ToString
                        For Each ctrl2 As Control In DirectCast(ctrl, GroupBox).Controls
                            Select Case ctrl2.GetType.ToString
                                Case GetType(RadioButton).ToString
                                    DirectCast(ctrl2, RadioButton).Checked = False
                                Case GetType(CheckBox).ToString
                                    DirectCast(ctrl2, CheckBox).Checked = False
                            End Select
                        Next
                End Select
            Next
            txtCta.Text = "0000"
            txtSCta.Text = "0000"
            txtSSCta.Text = "0000"
            txtSSSCta.Text = "0000"
            txtCta.Enabled = False
            txtSCta.Enabled = False
            txtSSCta.Enabled = False
            txtSSSCta.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Mostrar()
        RellenarCuentas()
        txtNombre.Text = Cuenta.NombreCuenta
        txtCta.Text = Cuenta.CuentaMayor
        txtSCta.Text = Cuenta.SubCuenta
        txtSSCta.Text = Cuenta.SSubCuenta
        txtSSSCta.Text = Cuenta.SSSubCuenta
        txtSdoAnt.Text = Cuenta.SaldoAñoAnterior
        txtSdoIni.Text = Cuenta.SaldoInicioEjercicio
        If Not IsNothing(Cuenta.CuentaPadre) Then
            txtCtaC.Text = String.Format("{0} : {1}", Cuenta.CuentaPadre.NombreCuenta, Cuenta.CuentaPadre.CuentaContable)
        Else
            txtCtaC.Text = "CUENTA DE MAYOR"
        End If

        If Cuenta.Naturaleza = ClasesNegocio.CuentaContableNaturalezaEnum.ACREEDORA Then
            rdbAcredora.Checked = True
            rdbDeudora.Checked = False
        Else
            rdbAcredora.Checked = False
            rdbDeudora.Checked = True
        End If
        chkBancos.Checked = Cuenta.Bancos
        chkAfectable.Checked = Cuenta.Afectable
        chkDepartamentalizable.Checked = Cuenta.Departamentalizable
        chkInactiva.Checked = Cuenta.Inactiva
        chkPresupuestos.Checked = Cuenta.Presupuesto
        chkResultados.Checked = Cuenta.Resultado
    End Sub

    Public Function Validar() As String
        Try
            Dim Cadena As String = "Faltan los siguientes datos:" & vbCrLf
            Dim Bl As Boolean = False
            If txtNombre.Text.Replace(" ", "").Length = 0 Then
                Bl = True
                Cadena &= "* Nombre" & vbCrLf
            End If
            If Not (rdbAcredora.Checked Or rdbDeudora.Checked) Then
                Bl = True
                Cadena &= "* Naturaleza" & vbCrLf
            End If
            If Me.txtCta.Text = "0000" Then
                Bl = True
                Cadena &= "* Número de Cuenta" & vbCrLf
            End If

            If Not Bl Then
                'Se le asignan los datos a la cuenta Fisc
                Cuenta.CuentaMayor = txtCta.Text
                Cuenta.SSSubCuenta = txtSSSCta.Text
                Cuenta.SSubCuenta = txtSSCta.Text
                Cuenta.SubCuenta = txtSCta.Text
                Cuenta.Departamentalizable = chkDepartamentalizable.Checked
                Cuenta.Inactiva = chkInactiva.Checked

                'Se le asignan los datos a la cuentaCont
                If Not CuentaCont Is Nothing Then
                    CuentaCont.CuentaMayor = txtCta.Text
                    CuentaCont.SSSubCuenta = txtSSSCta.Text
                    CuentaCont.SSubCuenta = txtSSCta.Text
                    CuentaCont.SubCuenta = txtSCta.Text
                    CuentaCont.Departamentalizable = chkDepartamentalizable.Checked
                    CuentaCont.Inactiva = chkInactiva.Checked
                    If rdbAcredora.Checked Then
                        Cuenta.Naturaleza = ClasesNegocio.CuentaContableNaturalezaEnum.ACREEDORA
                        CuentaCont.Naturaleza = ClasesNegocio.CuentaContableNaturalezaEnum.ACREEDORA
                    Else
                        Cuenta.Naturaleza = ClasesNegocio.CuentaContableNaturalezaEnum.DEUDORA
                        CuentaCont.Naturaleza = ClasesNegocio.CuentaContableNaturalezaEnum.DEUDORA
                    End If
                    Cuenta.NombreCuenta = txtNombre.Text
                    Cuenta.Presupuesto = chkPresupuestos.Checked
                    Cuenta.Resultado = chkResultados.Checked
                    Cuenta.Bancos = chkBancos.Checked
                    Cuenta.SaldoAñoAnterior = txtSdoAnt.Valor
                    Cuenta.SaldoInicioEjercicio = txtSdoIni.Valor

                    CuentaCont.NombreCuenta = txtNombre.Text
                    CuentaCont.Presupuesto = chkPresupuestos.Checked
                    CuentaCont.Resultado = chkResultados.Checked
                    CuentaCont.Bancos = chkBancos.Checked
                    CuentaCont.SaldoAñoAnterior = txtSdoAnt.Valor
                    CuentaCont.SaldoInicioEjercicio = txtSdoIni.Valor
                End If

                Cadena = Nothing
            End If
            Return Cadena
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try
    End Function

    Private Sub BuscarCuentas()
        Try
            Dim naturaleza, afectable As Object
            naturaleza = Nothing
            afectable = Nothing

            If Me.cmbNaturazleza.SelectedIndex = 1 Then
                naturaleza = CN.CuentaContableNaturalezaEnum.ACREEDORA
            ElseIf Me.cmbNaturazleza.SelectedIndex = 2 Then
                naturaleza = CN.CuentaContableNaturalezaEnum.DEUDORA
            End If

            If Me.cmbAfectable.SelectedIndex = 1 Then
                afectable = True
            ElseIf Me.cmbAfectable.SelectedIndex = 2 Then
                afectable = False
            End If

            Me.CuentasContable.Obtener(cmbEstatus.SelectedValue, Me.Txtfiltro.Text.Trim, , , , , naturaleza, , , , , afectable)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MostrarCuentas()
        Try
            Dim Filtro As New OC.PredicateExpression
            Dim Caracteristica As Boolean
            Dim Naturaleza As String

            If Not Me.cmbEstatus.SelectedValue = Nothing Or Not Me.cmbEstatus.SelectedValue = 2 Then
                Filtro.Add(HC.VwCuentasFiscFields.Inactiva <> Me.cmbEstatus.SelectedValue)
            End If

            If Me.cmbNaturazleza.SelectedIndex = 1 Then
                Naturaleza = CN.CuentaContableNaturalezaEnum.ACREEDORA
                Filtro.Add(HC.VwCuentasFiscFields.NaturalezaCad = Chr(Naturaleza))
            ElseIf Me.cmbNaturazleza.SelectedIndex = 2 Then
                Naturaleza = CN.CuentaContableNaturalezaEnum.DEUDORA
                Filtro.Add(HC.VwCuentasFiscFields.NaturalezaCad = Chr(Naturaleza))
            End If

            If Me.cmbAfectable.SelectedIndex = 1 Then
                Caracteristica = Integra.Clases.SiNoEnum.SI
                Filtro.Add(HC.VwCuentasFiscFields.AfectableCad = Caracteristica)
            End If
            If Me.cmbAfectable.SelectedIndex = 2 Then
                Caracteristica = Integra.Clases.SiNoEnum.NO
                Filtro.Add(HC.VwCuentasFiscFields.AfectableCad = Caracteristica)
            End If

            If Me.cmbEstatus.SelectedIndex = 1 Then
                Filtro.Add(HC.VwCuentasFiscFields.Inactiva = "SI")
            End If
            If Me.cmbEstatus.SelectedIndex = 2 Then
                Filtro.Add(HC.VwCuentasFiscFields.Inactiva = "NO")
            End If

            If Not Me.txtCtaBusq.Text = "0000" Then
                Filtro.Add(HC.VwCuentasFiscFields.Cta = Me.txtCtaBusq.Text)
                Filtro.Add(HC.VwCuentasFiscFields.SubCta = Me.txtSctaBusq.Text)
                Filtro.Add(HC.VwCuentasFiscFields.SsubCta = Me.txtSSCtaBusq.Text)
                Filtro.Add(HC.VwCuentasFiscFields.SssubCta = Me.txtSSSCtaBusq.Text)
            End If
            'If Not Me.txtFiltroNombre.Text = "" Then
            Filtro.Add(HC.VwCuentasFiscFields.NombreCuenta Mod String.Format("%{0}%", Txtfiltro.Text))
            ' End If

            Dim Lista As New TC.VwCuentasFiscTypedView
            Lista.Fill(0, Nothing, True, Filtro)

            Me.dgv.AutoGenerateColumns = False
            Me.dgv.DataSource = Lista
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region " Rellenar "
    Private Sub RellenarCuentas()
        txtCta.Enabled = True
        txtSCta.Enabled = False
        txtSSCta.Enabled = False
        txtSSSCta.Enabled = False
    End Sub
#End Region

    Private Sub mtb_ClickBorrar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickBorrar
        Cancelar = True
        If Cuenta.Borrar() Then
            Limpiar()
            Lectura()
        Else
            Cancelar = True
        End If
        'CuentasContable.Obtener(cmbEstatus.SelectedValue)
        Me.MostrarCuentas()
    End Sub

    Private Sub mtb_ClickCancelar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickCancelar
        Cuenta = Nothing
        Lectura()
        Limpiar()
        'CuentasContable.Obtener(cmbEstatus.SelectedValue)
        Me.MostrarCuentas()
    End Sub

    Private Sub mtb_ClickEditar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickEditar
        Escritura()
        btnCta.Enabled = False
        'btnCtaMayor.Enabled = False
        'If Cuenta.SubCuenta = "0000" Then
        '    txtCta.Enabled = True
        '    txtSCta.Enabled = False
        '    txtSSCta.Enabled = False
        '    txtSSSCta.Enabled = False
        'ElseIf Cuenta.SSubCuenta = "0000" Then
        '    txtCta.Enabled = False
        '    txtSCta.Enabled = True
        '    txtSSCta.Enabled = False
        '    txtSSSCta.Enabled = False
        'ElseIf Cuenta.SSSubCuenta = "0000" Then
        '    txtCta.Enabled = False
        '    txtSCta.Enabled = False
        '    txtSSCta.Enabled = True
        '    txtSSSCta.Enabled = False
        'Else
        '    txtCta.Enabled = False
        '    txtSCta.Enabled = False
        '    txtSSCta.Enabled = False
        '    txtSSSCta.Enabled = True
        'End If
        If Me.Cuenta.NoHijos > 0 Then
            Me.chkInactiva.Enabled = False
        End If
        If txtCta.Text <> "0000" And txtSCta.Text = "0000" And txtSSCta.Text = "0000" And txtSSSCta.Text = "0000" Then
            gpoNaturaleza.Enabled = True
            gpoCaracteristicas.Enabled = True
        Else
            gpoNaturaleza.Enabled = False
            gpoCaracteristicas.Enabled = False
        End If
        txtCta.Enabled = False
        txtSCta.Enabled = False
        txtSSCta.Enabled = False
        txtSSSCta.Enabled = False
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Guadar Cuentas")
        Try
            If IsNothing(Validar()) Then
                Dim blc As Boolean = True
                If Cuenta.NoHijos > 0 Then If MessageBox.Show("Los cambios realizados a esta cuenta afectarán a las subcuentas, esta operación puede tardar, ¿Desea continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = Windows.Forms.DialogResult.No Then bl = False
                If blc Then
                    If Not Cuenta.Guardar(Trans) Then
                        Trans.Rollback()
                    End If

                    If MessageBox.Show("¿Desea crear la cuenta contable?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        If Not CuentaCont.Guardar(Trans, True, Cuenta.ObtenerEntidad) Then
                            Trans.Rollback()
                        End If
                    End If
                    Trans.Commit()
                    MsgBox("Se ha Guardado la Cuenta", MsgBoxStyle.Information, "Aviso")
                    Limpiar()
                    Lectura()
                    Cancelar = False
                End If
            Else
                MessageBox.Show(Validar, "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            'CuentasContable.Obtener(cmbEstatus.SelectedValue)
            Me.MostrarCuentas()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Cancelar = True
        End Try
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Dim Reporte As New CN.RptCuentaFiscal
        Reporte.SetDataSource(Me.dgv.DataSource)
        Reporte.SetParameterValue(0, Controlador.Sesion.MiEmpresa.Empnom)
        Reporte.SetParameterValue(1, Controlador.Sesion.MiUsuario.Usrnomcom)
        Reporte.SetParameterValue(2, "Catalogos / Cuentas Contables")

        Dim pre As New ClasesNegocio.PreVisualizarForm
        pre.Reporte = Reporte
        pre.ShowDialog()
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Limpiar()
        Escritura()
        Cuenta = New ClasesNegocio.CuentaContableClass
        CuentaCont = New CN.CuentaContableClass
        RellenarCuentas()
        txtCtaC.Text = "CUENTA DE MAYOR"
        'txtCtaE.Text = "No definida..."
        'txtCtaS.Text = "No definida..."
        btnCta.Enabled = True
        'btnCtaMayor.Enabled = True
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Close()
    End Sub

    Private Sub cmbEstatus_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbEstatus.SelectedIndexChanged
        If cmbEstatus.SelectedIndex > -1 Then
            'CuentasContable.Obtener(cmbEstatus.SelectedValue)
            ' Me.BuscarCuentas()
            Me.MostrarCuentas()
        End If
    End Sub

    Private Sub dgv_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv.Click
        If Me.dgv.SelectedRows.Count > 0 Then
            Cuenta = New CN.CuentaContableClass
            CuentaCont = New CN.CuentaContableClass
            Dim CuentaConCol As New CN.CuentaContableCollectionClass
            Cuenta.Obtener(Me.dgv.SelectedRows(0).Cells("clmCodigo").Value)
            CuentaCont = CuentaConCol.ObtenerCuentaContable(Me.dgv.SelectedRows(0).Cells(Me.ClmCuentaMayor.Index).Value, Me.dgv.SelectedRows(0).Cells(Me.ClmSubCuenta.Index).Value, _
                        Me.dgv.SelectedRows(0).Cells(Me.ClmSSubCuenta.Index).Value, Me.dgv.SelectedRows(0).Cells(Me.ClmSSSubCuenta.Index).Value)

            If CuentaCont Is Nothing Then
                CuentaCont = New CN.CuentaContableClass
            End If
            If Not IsNothing(Cuenta) Then
                Mostrar()
                mtb.sbCambiarEstadoBotones("Buscar")
            End If
        End If
    End Sub

    Private Sub txtSdoIni_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSdoIni.TextChanged
        If Not bl Then
            bl = True
            txtSdoIni.Text = txtSdoIni.Valor.ToString("C")
            bl = False
        End If
    End Sub


    Private Sub txtSdoAnt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSdoAnt.TextChanged
        If Not bl Then
            bl = True
            txtSdoAnt.Text = txtSdoAnt.Valor.ToString("C")
            bl = False
        End If
    End Sub

    Private Sub btnCta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCta.Click
        Dim buscarCuenta As New BusquedaCuentasContablesForm

        If buscarCuenta.ShowDialog = Windows.Forms.DialogResult.OK Then
            CuentaPadre = buscarCuenta.CuentaContable
            Cuenta.CuentaPadre = CuentaPadre

            Dim CuentaCol As New CN.CuentaContableCollectionClass
            CuentaCont.CuentaPadre = CuentaCol.ObtenerCuentaContable(CuentaPadre.CuentaMayor, CuentaPadre.SubCuenta, CuentaPadre.SSubCuenta, CuentaPadre.SSSubCuenta)

            txtCtaC.Text = String.Format("{0} : {1}", CuentaPadre.NombreCuenta, CuentaPadre.CuentaContable)
            txtCta.Text = CuentaPadre.CuentaMayor
            txtSCta.Text = CuentaPadre.SubCuenta
            txtSSCta.Text = CuentaPadre.SSubCuenta
            gpoCaracteristicas.Enabled = False
            gpoNaturaleza.Enabled = False
            Select Case CuentaPadre.Naturaleza
                Case ClasesNegocio.CuentaContableNaturalezaEnum.ACREEDORA
                    rdbAcredora.Checked = True
                    rdbDeudora.Checked = False
                Case ClasesNegocio.CuentaContableNaturalezaEnum.DEUDORA
                    rdbAcredora.Checked = False
                    rdbDeudora.Checked = True
            End Select
            chkAfectable.Checked = CuentaPadre.Afectable
            chkBancos.Checked = CuentaPadre.Bancos
            chkDepartamentalizable.Checked = CuentaPadre.Departamentalizable
            chkInactiva.Checked = CuentaPadre.Inactiva
            chkPresupuestos.Checked = CuentaPadre.Presupuesto
            chkResultados.Checked = CuentaPadre.Resultado
            If CuentaPadre.CuentaMayor <> "0000" Then
                txtCta.Enabled = False
                txtSCta.Enabled = True
                txtSSCta.Enabled = False
                txtSSSCta.Enabled = False
            End If
            If CuentaPadre.SubCuenta <> "0000" Then
                txtCta.Enabled = False
                txtSCta.Enabled = False
                txtSSCta.Enabled = True
                txtSSSCta.Enabled = False
            End If
            If CuentaPadre.SSubCuenta <> "0000" Then
                txtCta.Enabled = False
                txtSCta.Enabled = False
                txtSSCta.Enabled = False
                txtSSSCta.Enabled = True
            End If
        End If
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        Try
            'Para pasar al siguiente control
            If e.KeyChar = Chr(13) Then
                Me.SelectNextControl(sender, True, True, False, True)
                If txtCta.Enabled = True Then
                    txtCta.Focus()
                End If
                If txtSCta.Enabled = True Then
                    txtSCta.Focus()
                End If
                If txtSSCta.Enabled = True Then
                    txtSSCta.Focus()
                End If
                If txtSSSCta.Enabled = True Then
                    txtSSSCta.Focus()
                End If
                If txtNombre.Text = "" Then
                    MsgBox("Agregue Información a Nombre", MsgBoxStyle.Exclamation, "Aviso")
                    txtNombre.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtSdoAnt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSdoAnt.KeyPress
        Try
            'Para pasar al siguiente control
            If e.KeyChar = Chr(13) Then
                Me.SelectNextControl(sender, True, True, False, True)
                txtSdoIni.Focus()
                If txtSdoAnt.Text = "" Then
                    MsgBox("Agregue Información a Saldo Anterior", MsgBoxStyle.Exclamation, "Aviso")
                    txtSdoAnt.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub txtSdoIni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSdoIni.KeyPress
        Try
            'Para pasar al siguiente control
            If e.KeyChar = Chr(13) Then
                Me.SelectNextControl(sender, True, True, False, True)
                ' btnCtaE.Focus()
                If txtSdoIni.Text = "" Then
                    MsgBox("Agregue Información a Saldo Inicial", MsgBoxStyle.Exclamation, "Aviso")
                    txtSdoIni.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Txtfiltro_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtfiltro.KeyPress
        'If e.KeyChar = Chr(13) Then
        '    ' Me.BuscarCuentas()
        'End If
        Try
            If e.KeyChar = Chr(13) Then
                Me.MostrarCuentas()
            Else
                If Me.Txtfiltro.Text.Length >= 3 Then
                    Me.MostrarCuentas()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbNaturazleza_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNaturazleza.SelectedIndexChanged
        'Me.BuscarCuentas()
        MostrarCuentas()
    End Sub

    Private Sub cmbAfectable_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAfectable.SelectedIndexChanged
        'Me.BuscarCuentas()
        Me.MostrarCuentas()
    End Sub

    Private Sub txtCtaBusq_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCtaBusq.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            MostrarCuentas()
            Me.txtSctaBusq.Focus()
        End If
    End Sub

    Private Sub txtSctaBusq_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSctaBusq.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            MostrarCuentas()
            Me.txtSSCtaBusq.Focus()
        End If
    End Sub

    Private Sub txtSSSCtaBusq_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSSSCtaBusq.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            MostrarCuentas()
        End If
    End Sub

    Private Sub txtSSCtaBusq_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSSCtaBusq.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            MostrarCuentas()
            Me.txtSSSCtaBusq.Focus()
        End If
    End Sub

    Private Sub txtCta_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCta.GotFocus
        Me.txtCta.Text = CInt(Me.txtCta.Text)
        If Me.txtCta.Text = 0 Then
            Me.txtCta.Clear()
        End If
    End Sub

    Private Sub txtCta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCta.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.rdbAcredora.Focus()
        End If
    End Sub

    Private Sub txtCta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCta.LostFocus
        If Not Me.txtCta.Text = "" Then
            Me.txtCta.Text = CInt(Me.txtCta.Text).ToString("0000")
        Else
            Me.txtCta.Text = "0000"
        End If
    End Sub

    Private Sub txtSCta_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSCta.GotFocus
        Me.txtSCta.Text = CInt(Me.txtSCta.Text)
        If Me.txtSCta.Text = 0 Then
            Me.txtSCta.Clear()
        End If
    End Sub

    Private Sub txtSCta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSCta.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.rdbAcredora.Focus()
        End If
    End Sub

    Private Sub txtSCta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSCta.LostFocus
        If Not Me.txtSCta.Text = "" Then
            Me.txtSCta.Text = CInt(Me.txtSCta.Text).ToString("0000")
        Else
            Me.txtSCta.Text = "0000"
        End If
    End Sub

    Private Sub txtSSCta_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSSCta.GotFocus
        Me.txtSSCta.Text = CInt(Me.txtSSCta.Text)
        If Me.txtSCta.Text = 0 Then
            Me.txtSSCta.Clear()
        End If
    End Sub

    Private Sub txtSSCta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSSCta.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.rdbAcredora.Focus()
        End If
    End Sub

    Private Sub txtSSCta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSSCta.LostFocus
        If Not Me.txtSSCta.Text = "" Then
            Me.txtSSCta.Text = CInt(Me.txtSSCta.Text).ToString("0000")
        Else
            Me.txtSSCta.Text = "0000"
        End If
    End Sub

    Private Sub txtSSSCta_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSSSCta.GotFocus
        Me.txtSSSCta.Text = CInt(Me.txtSSSCta.Text)
        If Me.txtSSSCta.Text = 0 Then
            Me.txtSSSCta.Clear()
        End If
    End Sub

    Private Sub txtSSSCta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSSSCta.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.rdbAcredora.Focus()
        End If
    End Sub

    Private Sub txtSSSCta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSSSCta.LostFocus
        If Not Me.txtSSSCta.Text = "" Then
            Me.txtSSSCta.Text = CInt(Me.txtSSSCta.Text).ToString("0000")
        Else
            Me.txtSSSCta.Text = "0000"
        End If
    End Sub
End Class