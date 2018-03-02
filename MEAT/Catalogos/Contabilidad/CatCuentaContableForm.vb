Imports CN = ClasesNegocio
Imports HC = Integralab.ORM.HelperClasses
Imports TC = Integralab.ORM.TypedViewClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports System.Data.SqlClient

'///////////////// CUENTAS CONTABLES  ///////////////////////       

Public Class CatCuentaContableForm
    Implements InterfaceForm

#Region " Declaraciones "

    Private WithEvents Cuenta As CN.CuentaContableClass
    Private CuentaPadre As CN.CuentaContableClass
    Private seleccion As New Integra.Clases.BusquedaClass(Of CN.CuentaContableClass)
    Private dtCuentas As DataTable


#End Region

#Region " Forma "

    Private Sub CatCuentaContableForm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            SendKeys.Send(Keys.Tab)
            'Me.SelectNextControl(sender, True, True, False, True)
        End If
    End Sub

    Private Sub CatCuentaContablesForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.lblTitulo.Text = Me.Text.ToUpper
        ' Barra de botones de la ToolBar...
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        MtbEstados.StateBuscar = "110101111"
        MtbEstados.StateLimpiar = ""
        MtbEstados.StateCancelar = "000100011"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "110100011"
        MtbEstados.StateBorrar = "100100001"
        MtbEstados.StateEditar = "001010000"
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


        'agregar titulos al combo

        Dim Clasificador As New CC.ClasificadorDeEstadosFinancierosCollection
        Clasificador.GetMulti(Nothing, 0, Nothing)
        Me.cmbTitulo.DisplayMember = "Descripcion"
        Me.cmbTitulo.ValueMember = "Codigo"
        Me.cmbTitulo.DataSource = Clasificador
        Me.cmbTitulo.SelectedValue = -1
        Me.cmbTitulo.SelectedText = "Seleccione el Titulo"
        Lectura()
        Me.MostrarCuentas()

        dtCuentas = CC.CuentaContableCollection.GetMultiAsDataTable(Nothing, 0, Nothing)
        Try
            Dim FormasPago As DataSet = New DataSet
            Dim queryString As String = "SELECT CodAgrupador, CodAgrupador+'.- '+NombreCuenta as agrupador FROM eCtSATCatCuentas"
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(queryString, HC.DbUtils.ActualConnectionString)
            adapter.Fill(FormasPago)
            Me.cmbAgrupacionSAT.DataSource = FormasPago.Tables(0)
            Me.cmbAgrupacionSAT.DisplayMember = "agrupador"
            Me.cmbAgrupacionSAT.ValueMember = "CodAgrupador"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Me.cmbAgrupacionSAT.SelectedItem = Nothing
    End Sub
#End Region

#Region " Metodos "
    Public Sub Escritura() Implements InterfaceForm.Escritura
        pan.Enabled = True
        gpo.Enabled = True
        cmbTitulo.Enabled = True
        cmbSubTitulo.Enabled = True
        Me.dgv.Enabled = False
        Me.gpoCaracteristicas.Enabled = True
        Me.gpoNaturaleza.Enabled = True
        Me.btnCtaE.Enabled = True
        'Me.btnCtaS.Enabled = True
        Me.BtnQuitarCtaE.Enabled = True
        'Me.BtnQuitarCtaS.Enabled = True
        Me.cmbAgrupacionSAT.Enabled = True
    End Sub

    Public Sub Lectura() Implements InterfaceForm.Lectura
        pan.Enabled = False
        gpo.Enabled = True
        cmbTitulo.Enabled = False
        cmbSubTitulo.Enabled = False
        Me.dgv.Enabled = True
        Me.btnCtaE.Enabled = False
        ' Me.btnCtaS.Enabled = False
        Me.BtnQuitarCtaE.Enabled = False
        'Me.BtnQuitarCtaS.Enabled = False
        Me.cmbAgrupacionSAT.Enabled = False
    End Sub

    Public Sub Limpiar() Implements InterfaceForm.Limpiar
        Try
            txtNombre.Clear()
            txtCtaC.Clear()
            For Each ctrl As Control In Me.pan.Controls
                Select Case ctrl.GetType.ToString
                    ''Case GetType(Integra.Controles.TextboxDecimal).ToString
                    ''    DirectCast(ctrl, Integra.Controles.TextboxDecimal).Clear()
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
            Me.txtCtaE.Text = "No Definida.."
            Me.txtCtaC.Text = ""
            Me.txtCtaC.Visible = False
            Me.cmbAgrupacionSAT.SelectedItem = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub Mostrar() Implements InterfaceForm.Mostrar
        Mostrar(True)
    End Sub

    Public Sub Mostrar(ByVal ActualizarNoCuenta As Boolean)
        RellenarCuentas()
        txtNombre.Text = Cuenta.NombreCuenta

        If ActualizarNoCuenta Then
            RemoveHandler txtCta.TextChanged, AddressOf txtCta_TextChanged
            RemoveHandler txtSCta.TextChanged, AddressOf txtSCta_TextChanged
            RemoveHandler txtSSCta.TextChanged, AddressOf txtSSCta_TextChanged
            RemoveHandler txtSSSCta.TextChanged, AddressOf txtSSSCta_TextChanged

            txtCta.Text = Cuenta.CuentaMayor
            txtSCta.Text = Cuenta.SubCuenta
            txtSSCta.Text = Cuenta.SSubCuenta
            txtSSSCta.Text = Cuenta.SSSubCuenta

            AddHandler txtCta.TextChanged, AddressOf txtCta_TextChanged
            AddHandler txtSCta.TextChanged, AddressOf txtSCta_TextChanged
            AddHandler txtSSCta.TextChanged, AddressOf txtSSCta_TextChanged
            AddHandler txtSSSCta.TextChanged, AddressOf txtSSSCta_TextChanged
        End If
        'txtSdoAnt.Text = Cuenta.SaldoAñoAnterior
        'txtSdoIni.Text = Cuenta.SaldoInicioEjercicio

        If Not Cuenta.SubCuenta = "0000" Then
            Dim NombreCuenta As String = Nothing
            Dim CuentaContable As String = Nothing

            If Cuenta.CuentaPadre IsNot Nothing Then
                NombreCuenta = Cuenta.CuentaPadre.NombreCuenta
                CuentaContable = Cuenta.CuentaPadre.CuentaContable
            End If

            ' txtCtaC.Text = String.Format("{0} : {1}", NombreCuenta, CuentaContable)
        Else
            txtCtaC.Text = "CUENTA DE MAYOR"
        End If
        txtCtaE.Text = String.Format("{0} : {1}", Cuenta.CuentaEntrada.NombreCuenta, Cuenta.CuentaEntrada.CuentaContable)
        ' txtCtaS.Text = String.Format("{0} : {1}", Cuenta.CuentaSalida.NombreCuenta, Cuenta.CuentaSalida.CuentaContable)
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
        Me.cmbTitulo.SelectedValue = Cuenta.TitulodeEstadoFinanciero
        Me.cmbSubTitulo.SelectedValue = Cuenta.SubTitulodeEstadoFinanciero
        Me.cmbAgrupacionSAT.SelectedValue = Cuenta.CodAgrupSAT
    End Sub

    Public Function Validar() As String Implements InterfaceForm.Validar
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
            If Cuenta Is Nothing Then Cuenta = New ClasesNegocio.CuentaContableClass
            Cuenta.CuentaMayor = txtCta.Text
            Cuenta.SSSubCuenta = txtSSSCta.Text
            Cuenta.SSubCuenta = txtSSCta.Text
            Cuenta.SubCuenta = txtSCta.Text
            Cuenta.Departamentalizable = chkDepartamentalizable.Checked
            Cuenta.Inactiva = chkInactiva.Checked
            If rdbAcredora.Checked Then
                Cuenta.Naturaleza = ClasesNegocio.CuentaContableNaturalezaEnum.ACREEDORA
            Else
                Cuenta.Naturaleza = ClasesNegocio.CuentaContableNaturalezaEnum.DEUDORA
            End If
            Cuenta.NombreCuenta = txtNombre.Text
            Cuenta.Presupuesto = chkPresupuestos.Checked
            Cuenta.Resultado = chkResultados.Checked
            Cuenta.Bancos = chkBancos.Checked
            'Cuenta.SaldoAñoAnterior = txtSdoAnt.Valor
            'Cuenta.SaldoInicioEjercicio = txtSdoIni.Valor
            Cuenta.TitulodeEstadoFinanciero = Me.cmbTitulo.SelectedValue
            Cuenta.SubTitulodeEstadoFinanciero = Me.cmbSubTitulo.SelectedValue
            Cuenta.CuentaPadre = CuentaPadre

            If (cmbAgrupacionSAT.SelectedIndex <> 0) Then
                Cuenta.CodAgrupSAT = cmbAgrupacionSAT.SelectedValue
            End If

            Cadena = Nothing
        End If
        Return Cadena
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

            Me.CuentasContable.Obtener(cmbEstatus.SelectedValue, Me.Txtfiltro.Text.Trim, Me.txtCta.Text, Me.txtSCta.Text, Me.txtSSCta.Text, Me.txtSSSCta.Text, naturaleza, , , , , afectable)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BuscarSoloUnaCuentaContable()
        Try
            Dim CuentaCol As New CN.CuentaContableCollectionClass
            Cuenta = CuentaCol.ObtenerCuentaContable(Me.txtCta.Text.PadLeft(4, "0"), Me.txtSCta.Text.PadLeft(4, "0"), Me.txtSSCta.Text.PadLeft(4, "0"), Me.txtSSSCta.Text.PadLeft(4, "0"))

            If Cuenta Is Nothing Then
                Exit Sub
            Else
                Mostrar(False)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

#End Region

#Region " ToolBar "
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
        If Me.Cuenta.NoHijos > 0 Then
            Me.chkInactiva.Enabled = False
        End If

        'If txtCta.Text <> "0000" And txtSCta.Text = "0000" And txtSSCta.Text = "0000" And txtSSSCta.Text = "0000" Then
        'Else
        '    gpoNaturaleza.Enabled = False
        '    gpoCaracteristicas.Enabled = False
        '    Me.gpoNaturaleza.Enabled = False
        'End If
        txtCta.Enabled = False
        txtSCta.Enabled = False
        txtSSCta.Enabled = False
        txtSSSCta.Enabled = False

        If Cuenta.CuentaPadre IsNot Nothing AndAlso Not Cuenta.CuentaPadre.Entidad.IsNew Then
            cmbTitulo.Enabled = False
            'cmbSubTitulo.Enabled = True
            cmbSubTitulo.Enabled = False
        Else
            cmbTitulo.Enabled = True
            cmbSubTitulo.Enabled = True
        End If
        gpoNaturaleza.Enabled = True
        gpoCaracteristicas.Enabled = True
    End Sub

    Private Sub mtb_ClickGuardar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickGuardar
        Cancelar = True
        Dim Trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Guardar Cuenta")
        If IsNothing(Validar()) Then
            'If Not Cuenta.CuentaEntrada.Codigo = 0 And Cuenta.CuentaSalida.Codigo = 0 Or Cuenta.CuentaEntrada.Codigo = 0 And Not Cuenta.CuentaSalida.Codigo = 0 Then
            '    MessageBox.Show("Ingrese la cuenta de entrada y la cuenta de salida o ninguna", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Cancelar = True
            '    Exit Sub
            'End If
            Dim blc As Boolean = True

            If Cuenta.NoHijos > 0 Then If MessageBox.Show("Los cambios realizados a esta cuenta afectarán a las subcuentas, esta operación puede tardar, ¿Desea continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = Windows.Forms.DialogResult.No Then blc = False

            If blc Then
                If Cuenta.Guardar(Trans) Then
                    'MsgBox("Se ha guardado la cuenta contable", MsgBoxStyle.Information, Controlador.Sesion.MiEmpresa.Empnom)
                    Limpiar()
                    Lectura()
                    MessageBox.Show("Se ha guardado la cuenta contable.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Cancelar = False
                End If
            End If
        Else
            MessageBox.Show(Validar, "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Me.MostrarCuentas()
    End Sub

    Private Sub mtb_ClickImprimir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickImprimir
        Try


            Dim datos As New DataSet
            Dim query = "EXEC  rptcuentascontables 1"
            Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
                Dim adapter As New SqlDataAdapter()
                adapter.SelectCommand = New SqlCommand(query, connection)
                adapter.Fill(datos)
            End Using


            ' Dim Reporte As New CN.RptCuentaContable
            'Reporte.SetDataSource(Me.dgv.DataSource)
            'Reporte.SetParameterValue("Empresa", Controlador.Empresa.Nombre)
            'Reporte.SetParameterValue("Usuario", Controlador.Sesion.MiUsuario.Usrnomcom)
            'Reporte.SetParameterValue("Modulo", "Catalogos\Contabilidad\Cuentas Contables")
            'Dim pre As New ClasesNegocio.PreVisualizarForm
            'pre.Reporte = Reporte
            'pre.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mtb_ClickLimpiar(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickLimpiar
        Limpiar()
    End Sub

    Private Sub mtb_ClickNuevo(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickNuevo
        Limpiar()
        Escritura()
        Cuenta = New ClasesNegocio.CuentaContableClass
        RellenarCuentas()


        txtCtaC.Text = "CUENTA DE MAYOR"
        txtCtaE.Text = "No definida..."
        '  txtCtaS.Text = "No definida..."
        btnCta.Enabled = True
        Me.txtCta.Focus()
        'txtNombre.Focus()
        'btnCtaMayor.Enabled = True
    End Sub

    Private Sub mtb_ClickSalir(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As Boolean) Handles mtb.ClickSalir
        Me.Close()
    End Sub
#End Region

#Region " Rellenar "
    Private Sub RellenarCuentas()
        txtCta.Enabled = True
        txtSCta.Enabled = True
        txtSSCta.Enabled = True
        txtSSSCta.Enabled = True
    End Sub
#End Region

#Region " Otros "
    Private Sub cmbEstatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEstatus.SelectedIndexChanged
        If cmbEstatus.SelectedIndex > -1 Then
            'CuentasContable.Obtener(cmbEstatus.SelectedValue)
            ' Me.BuscarCuentas()
            Me.MostrarCuentas()
        End If
    End Sub
#End Region

#Region " DataGrid "

    Private Sub dgv_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgv.Click
        'Cuenta = Nothing
        'Cuenta = seleccion.ObtenerdeDataGrid(dgv)
        If Me.dgv.SelectedRows.Count > 0 Then
            Cuenta = Nothing
            Cuenta = New CN.CuentaContableClass()
            Cuenta.Obtener(Me.dgv.SelectedRows(0).Cells("clmCodigo").Value)
            If Not IsNothing(Cuenta) Then
                Mostrar(True)
                mtb.sbCambiarEstadoBotones("Buscar")
            End If
        End If
    End Sub

#End Region

    Private Sub Cuenta_Mensajes(ByVal sender As Object, ByVal Message As ClasesNegocio.MensajeClass) Handles Cuenta.Mensajes
        MessageBox.Show(Message.Mensaje, Message.Titulo, MessageBoxButtons.OK, Message.Tipo)
    End Sub

    Private bl As Boolean = False


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

#Region "Botones"
    Private Sub btnCta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCta.Click

        Dim buscarCuenta As New BusquedaCuentasContablesForm
        If buscarCuenta.ShowDialog = Windows.Forms.DialogResult.OK Then
            CuentaPadre = buscarCuenta.CuentaContable
            Cuenta.CuentaPadre = CuentaPadre

            txtCtaC.Text = String.Format("{0} : {1}", CuentaPadre.NombreCuenta, CuentaPadre.CuentaContable)
            txtCta.Text = CuentaPadre.CuentaMayor
            txtSCta.Text = CuentaPadre.SubCuenta
            txtSSCta.Text = CuentaPadre.SSubCuenta
            gpoCaracteristicas.Enabled = False
            'gpoNaturaleza.Enabled = False

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

    'Private Sub btnCtaMayor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Cuenta.CuentaPadre = Nothing
    '    CuentaPadre = Nothing
    '    txtCtaC.Text = "CUENTA DE MAYOR"
    '    RellenarCuentas()
    '    txtCta.Text = "0000"
    '    txtSCta.Text = "0000"
    '    txtSSCta.Text = "0000"
    '    txtSSSCta.Text = "0000"
    'End Sub

#End Region

    'Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
    '    Try
    '        'Para pasar al siguiente control
    '        If e.KeyChar = Chr(13) Then
    '            Me.SelectNextControl(sender, True, True, False, True)
    '            If txtCta.Enabled = True Then
    '                txtCta.Focus()
    '            End If
    '            If txtSCta.Enabled = True Then
    '                txtSCta.Focus()
    '            End If
    '            If txtSSCta.Enabled = True Then
    '                txtSSCta.Focus()
    '            End If
    '            If txtSSSCta.Enabled = True Then
    '                txtSSSCta.Focus()
    '            End If
    '            If txtNombre.Text = "" Then
    '                MsgBox("Agregue Información a Nombre", MsgBoxStyle.Exclamation, "Aviso")
    '                txtNombre.Focus()
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '    End Try
    'End Sub


    'Private Sub txtSdoAnt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSdoAnt.KeyPress
    '    Try
    '        'Para pasar al siguiente control
    '        If e.KeyChar = Chr(13) Then
    '            Me.SelectNextControl(sender, True, True, False, True)
    '            txtSdoIni.Focus()
    '            If txtSdoAnt.Text = "" Then
    '                MsgBox("Agregue Información a Saldo Anterior", MsgBoxStyle.Exclamation, "Aviso")
    '                txtSdoAnt.Focus()
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '    End Try
    'End Sub

    'Private Sub txtSdoIni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSdoIni.KeyPress
    '    Try
    '        'Para pasar al siguiente control
    '        If e.KeyChar = Chr(13) Then
    '            Me.SelectNextControl(sender, True, True, False, True)
    '            btnCtaE.Focus()
    '            If txtSdoIni.Text = "" Then
    '                MsgBox("Agregue Información a Saldo Inicial", MsgBoxStyle.Exclamation, "Aviso")
    '                txtSdoIni.Focus()
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '    End Try
    'End Sub

    Private Sub Txtfiltro_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtfiltro.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.BuscarCuentas()
        End If
        Try
            If e.KeyChar = Chr(13) Then
                Me.MostrarCuentas()
            Else
                If Me.Txtfiltro.Text.Length >= 1 Then
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

    Private Sub MostrarCuentas()
        Try
            Dim Filtro As New OC.PredicateExpression
            Dim Caracteristica As String
            Dim Naturaleza As String

            If Not Me.cmbEstatus.SelectedValue Is Nothing Or Not CType(Me.cmbEstatus.SelectedValue, Integer) = 2 Then
                Filtro.Add(HC.VwContCuentasFields.Inactiva <> Me.cmbEstatus.SelectedValue)
            End If

            If Me.cmbNaturazleza.SelectedIndex = 1 Then
                Naturaleza = CN.CuentaContableNaturalezaEnum.ACREEDORA
                Filtro.Add(HC.VwContCuentasFields.NaturalezaCad = Chr(Naturaleza))
            ElseIf Me.cmbNaturazleza.SelectedIndex = 2 Then
                Naturaleza = CN.CuentaContableNaturalezaEnum.DEUDORA
                Filtro.Add(HC.VwContCuentasFields.NaturalezaCad = Chr(Naturaleza))
            End If

            If Me.cmbAfectable.SelectedIndex = 1 Then
                Caracteristica = "SI"
                Filtro.Add(HC.VwContCuentasFields.Afectable = Caracteristica)
            End If
            If Me.cmbAfectable.SelectedIndex = 2 Then
                Caracteristica = "NO"
                Filtro.Add(HC.VwContCuentasFields.Afectable = Caracteristica)
            End If

            If Me.cmbEstatus.SelectedIndex = 1 Then
                Filtro.Add(HC.VwContCuentasFields.Inactiva = "SI")
            End If

            If Me.cmbEstatus.SelectedIndex = 2 Then
                Filtro.Add(HC.VwContCuentasFields.Inactiva = "NO")
            End If

            If Not Me.txtCtaBusq.Text = "0000" Then
                Filtro.Add(HC.VwContCuentasFields.Cta = Me.txtCtaBusq.Text)
            End If

            If Not Me.txtSCtaBusq.Text = "0000" Then
                Filtro.Add(HC.VwContCuentasFields.SubCta = Me.txtSCtaBusq.Text)
            End If

            If Not Me.txtSSCtaBusq.Text = "0000" Then
                Filtro.Add(HC.VwContCuentasFields.SsubCta = Me.txtSSCtaBusq.Text)
            End If

            If Not Me.txtSSSCtaBusq.Text = "0000" Then
                Filtro.Add(HC.VwContCuentasFields.SssubCta = Me.txtSSSCtaBusq.Text)
            End If

            'If Not Me.txtFiltroNombre.Text = "" Then
            Filtro.Add(HC.VwContCuentasFields.NombreCuenta Mod String.Format("%{0}%", Txtfiltro.Text))
            ' End If

            Dim Lista As New TC.VwContCuentasTypedView
            Lista.Fill(0, Nothing, True, Filtro)

            Me.dgv.AutoGenerateColumns = False
            Me.dgv.DataSource = Lista
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCtaE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCtaE.Click
        Dim buscarCuenta As New BusquedaCuentasContablesForm
        'buscarCuenta.Afectables = CheckState.Checked
        'buscarCuenta.chkAfe.Enabled = False

        'If buscarCuenta.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    Cuenta.CuentaEntrada = buscarCuenta.CuentaContable
        '    txtCtaE.Text = String.Format("{0} : {1}", Cuenta.CuentaEntrada.NombreCuenta, Cuenta.CuentaEntrada.CuentaContable)
        'End If
    End Sub

    'Private Sub btnCtaS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim buscarCuenta As New FrmBusquedaCuentasfiscales
    '    buscarCuenta.Afectables = CheckState.Checked
    '    buscarCuenta.chkAfe.Enabled = False
    '    If buscarCuenta.ShowDialog = Windows.Forms.DialogResult.OK Then
    '        Cuenta.CuentaSalida = buscarCuenta.CuentaContable
    '        txtCtaS.Text = String.Format("{0} : {1}", Cuenta.CuentaSalida.NombreCuenta, Cuenta.CuentaSalida.CuentaContable)
    '    End If
    'End Sub

    Private Sub BtnQuitarCtaE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitarCtaE.Click
        txtCtaE.Text = "No definida..."
        Cuenta.CuentaEntrada = Nothing
    End Sub

    'Private Sub BtnQuitarCtaS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    txtCtaS.Text = "No definida..."
    '    Cuenta.CuentaSalida = Nothing
    'End Sub

    Private Sub txtCta_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCta.GotFocus
        Me.txtCta.Text = CInt(Me.txtCta.Text)
        'If Me.txtCta.Text = 0 Then
        '    Me.txtCta.Clear()
        'End If
    End Sub

    Private Sub AsignarPadre(ByVal Control As TextBox)
        Me.txtCtaC.Visible = True
        Me.txtNombre.Text = ""
        Me.gpoCaracteristicas.Enabled = True
        Me.chkAfectable.Enabled = False
        cmbTitulo.Enabled = False
        'cmbSubTitulo.Enabled = True
        cmbSubTitulo.Enabled = False
        CuentaPadre = Cuenta
    End Sub

    Private Sub txtCta_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtCta.TextChanged

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
        'If Me.txtSCta.Text = 0 Then
        '    Me.txtSCta.Clear()
        'End If
    End Sub

    Private Sub txtSCta_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtSCta.TextChanged

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
        'If Me.txtSCta.Text = 0 Then
        '    Me.txtSSCta.Clear()
        'End If
    End Sub

    Private Sub txtSSCta_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtSSCta.TextChanged

    End Sub

    Private Sub txtSSCta_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSSCta.Leave
        BuscacuentaSscta()

        If Not Me.txtSSCta.Text = "" Then
            Me.txtSSCta.Text = CInt(Me.txtSSCta.Text).ToString("0000")
        Else
            Me.txtSSCta.Text = "0000"
        End If
    End Sub

    Private Sub txtSSSCta_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSSSCta.GotFocus
        Me.txtSSSCta.Text = CInt(Me.txtSSSCta.Text)
        'If Me.txtSSSCta.Text = 0 Then
        '    Me.txtSSSCta.Clear()
        'End If
    End Sub

    Private Sub txtSSSCta_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtSSSCta.TextChanged

    End Sub

    Private Sub txtSSSCta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSSSCta.LostFocus
        If Not Me.txtSSSCta.Text = "" Then
            Me.txtSSSCta.Text = CInt(Me.txtSSSCta.Text).ToString("0000")
        Else
            Me.txtSSSCta.Text = "0000"
        End If
    End Sub

    Private Sub txtCtaBusq_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCtaBusq.GotFocus
        Me.txtCtaBusq.Text = CInt(Me.txtSSSCta.Text)
        If Me.txtCtaBusq.Text = 0 Then
            Me.txtCtaBusq.Clear()
        End If
    End Sub

    Private Sub txtCtaBusq_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCtaBusq.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            'Me.MostrarCuentas()
            Me.txtSCtaBusq.Focus()
        End If
    End Sub

    Private Sub txtCtaBusq_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCtaBusq.LostFocus
        If Not Me.txtCtaBusq.Text = "" Then
            Me.txtCtaBusq.Text = CInt(Me.txtCtaBusq.Text).ToString("0000")
        Else
            Me.txtCtaBusq.Text = "0000"
        End If
        Me.MostrarCuentas()
    End Sub

    Private Sub txtSCtaBusq_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSCtaBusq.GotFocus
        Me.txtSCtaBusq.Text = CInt(Me.txtSCtaBusq.Text)
        If Me.txtSCtaBusq.Text = 0 Then
            Me.txtSCtaBusq.Clear()
        End If
    End Sub

    Private Sub txtSCtaBusq_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSCtaBusq.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            ' Me.MostrarCuentas()
            Me.txtSSCtaBusq.Focus()
        End If
    End Sub

    Private Sub txtSCtaBusq_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSCtaBusq.LostFocus
        If Not Me.txtSCtaBusq.Text = "" Then
            Me.txtSCtaBusq.Text = CInt(Me.txtSCtaBusq.Text).ToString("0000")
        Else
            Me.txtSCtaBusq.Text = "0000"
        End If
        Me.MostrarCuentas()
    End Sub

    Private Sub txtSSCtaBusq_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSSCtaBusq.GotFocus
        Me.txtSSCtaBusq.Text = CInt(Me.txtSSCtaBusq.Text)
        If Me.txtSSCtaBusq.Text = 0 Then
            Me.txtSSCtaBusq.Clear()
        End If
    End Sub

    Private Sub txtSSCtaBusq_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSSCtaBusq.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            ' MostrarCuentas()
            Me.txtSSSCtaBusq.Focus()
        End If
    End Sub

    Private Sub txtSSCtaBusq_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSSCtaBusq.LostFocus
        If Not Me.txtSSCtaBusq.Text = "" Then
            Me.txtSSCtaBusq.Text = CInt(Me.txtSSCtaBusq.Text).ToString("0000")
        Else
            Me.txtSSCtaBusq.Text = "0000"
        End If
        Me.MostrarCuentas()
    End Sub

    Private Sub txtSSSCtaBusq_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSSSCtaBusq.GotFocus
        Me.txtSSSCtaBusq.Text = CInt(Me.txtSSCtaBusq.Text)
        If Me.txtSSSCtaBusq.Text = 0 Then
            Me.txtSSSCtaBusq.Clear()
        End If
    End Sub

    Private Sub txtSSSCtaBusq_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSSSCtaBusq.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            'MostrarCuentas()
            Me.txtCtaBusq.Focus()
        End If
    End Sub

    Private Sub txtSSSCtaBusq_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSSSCtaBusq.LostFocus
        If Not Me.txtSSSCtaBusq.Text = "" Then
            Me.txtSSSCtaBusq.Text = CInt(Me.txtSSSCtaBusq.Text).ToString("0000")
        Else
            Me.txtSSSCtaBusq.Text = "0000"
        End If
        MostrarCuentas()
    End Sub

    Private Sub cmbTitulo_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTitulo.SelectedValueChanged
        Try
            Dim Detalle As New CC.DetalleClasificadordeEstadosFinancierosCollection
            Detalle.GetMulti(HC.DetalleClasificadordeEstadosFinancierosFields.CodigoClasificador = Me.cmbTitulo.SelectedValue, 0, Nothing)

            If Detalle.Count > 0 Then
                Me.cmbSubTitulo.Enabled = True
                Me.cmbSubTitulo.DisplayMember = "Descripcion"
                Me.cmbSubTitulo.ValueMember = "Codigo"
                Me.cmbSubTitulo.DataSource = Detalle
            Else
                Me.cmbSubTitulo.Enabled = False
                Me.cmbSubTitulo.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Controlador.Empresa.Nombre, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function BuscarPadre() As String
        Dim Resultado() As DataRow = Nothing
        Dim Tipo As String = ""

        If txtSSCta.Text.PadLeft(4, "0") <> "0000" Then
            Resultado = dtCuentas.Select("Cta = '" & txtCta.Text.Trim.PadLeft(4, "0") & "' AND SubCta = '" & txtSCta.Text.Trim.PadLeft(4, "0") & "' AND SsubCta = '" & txtSSCta.Text.Trim.PadLeft(4, "0") & "'")
            Tipo = "SUB SUB CUENTA - "
        ElseIf txtSCta.Text.PadLeft(4, "0") <> "0000" Then
            Resultado = dtCuentas.Select("Cta = '" & txtCta.Text.Trim.PadLeft(4, "0") & "' AND SubCta = '" & txtSCta.Text.Trim.PadLeft(4, "0") & "'")
            Tipo = "SUB CUENTA - "
        ElseIf txtCta.Text.PadLeft(4, "0") <> "0000" Then
            Resultado = dtCuentas.Select("Cta = '" & txtCta.Text.Trim.PadLeft(4, "0") & "'")
            Tipo = "CUENTA MAYOR - "
        End If

        If Resultado IsNot Nothing AndAlso Resultado.Length > 0 Then
            Return Tipo & Resultado(0)("NomCuenta").ToString()
        Else
            Return String.Empty
        End If
    End Function

    ''--------------------------------    funciones de usqueda de cuentas  -----------------------------------------

    Public Sub buscacuentaCta()
        BuscarSoloUnaCuentaContable()

        If Cuenta IsNot Nothing Then
            If Me.txtSCta.Text = "0000" Then
                Me.txtCtaC.Text = BuscarPadre()
                AsignarPadre(Me.txtSCta)
            End If
        Else
            gpoNaturaleza.Enabled = True
            cmbTitulo.Enabled = True
            cmbSubTitulo.Enabled = True
            txtCtaC.Text = ""
        End If
    End Sub

    Public Sub buscacuentaScta()
        BuscarSoloUnaCuentaContable()

        If Cuenta IsNot Nothing Then
            If Me.txtSSCta.Text = "0000" Then
                Me.txtCtaC.Text = BuscarPadre()
                AsignarPadre(Me.txtSSCta)
            End If
        End If
    End Sub

    Public Sub BuscacuentaSscta()
        BuscarSoloUnaCuentaContable()

        If Cuenta IsNot Nothing Then
            If Me.txtSSSCta.Text = "0000" Then
                Me.txtCtaC.Text = BuscarPadre()
                AsignarPadre(Me.txtSSCta)
            End If
        End If
    End Sub

    Public Sub buscacuentaSsscta()
        BuscarSoloUnaCuentaContable()
        If Cuenta IsNot Nothing Then
            Me.txtSSSCta.Enabled = True
        End If
    End Sub

    Private Sub txtCta_Leave(sender As System.Object, e As System.EventArgs) Handles txtCta.Leave
        buscacuentaCta()
    End Sub

    Private Sub txtSCta_Leave(sender As System.Object, e As System.EventArgs) Handles txtSCta.Leave
        buscacuentaScta()
    End Sub

    Private Sub txtSSSCta_Leave(sender As System.Object, e As System.EventArgs) Handles txtSSSCta.Leave
        buscacuentaSsscta()
    End Sub
    ''----------------------------------------------------------------------------------------------------

End Class