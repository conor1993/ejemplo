Imports ClasesNegocio
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports System.Data.SqlClient

Public Class CompCatProveedor

    Dim WithEvents Proveedor As New ClasesNegocio.ProveedorClass
    Dim WithEvents Proveedorav As New ClasesNegocio.ProvAvanzadoClass
    Dim WithEvents ProveedorCol As New ClasesNegocio.ProveedorCollectionClass
    Dim WithEvents Estado As New ClasesNegocio.EstadoClass
    Dim WithEvents Estados As New ClasesNegocio.EstadoCollectionClass
    Dim WithEvents Ciudad As New ClasesNegocio.CiudadClass
    Dim WithEvents Ciudades As New ClasesNegocio.CiudadCollectionClass
    Dim WithEvents Poblacion As New ClasesNegocio.PoblacionClass
    Dim WithEvents Poblaciones As New ClasesNegocio.PoblacionCollectionClass
    Dim WithEvents Bancos As New ClasesNegocio.BancosCollectionClass
    Dim WithEvents TipoProveedor As New ClasesNegocio.TiposProveedorCollectionClass
    Dim PuedoRefrescar As Boolean = True
    Dim Editar As Boolean = False
    Dim Seleccionado As Boolean = False
    Dim Buscando As Boolean = False
    'Dim Busqueda As New ClasesNegocio.BusquedaClass(Of ClasesNegocio.ProveedorClass)
    Dim diasrev As New ClasesNegocio.DiasClass
    Dim diaspag As New ClasesNegocio.DiasClass
    Dim band As Boolean = False

    Dim bandera As Boolean = False

    Private Sub CompCatProveedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            SendKeys.Send(Keys.Tab)
            'Me.SelectNextControl(sender, True, True, False, True)
        End If
    End Sub

    Private Sub CompCatProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TabControl4.TabPages.RemoveByKey(TabPage4.Name)
        bandera = False
        'Barra de botones de la ToolBar...
        Dim MtbEstados As New MEAToolBar.MEAToolBar.ToolBarButtonStatusStructure
        MtbEstados.StateBuscar = "110101111"
        MtbEstados.StateLimpiar = "100100011"
        MtbEstados.StateCancelar = "100100011"
        MtbEstados.StateNuevo = "011010001"
        MtbEstados.StateGuardar = "100100001"
        MtbEstados.StateBorrar = "100100011"
        MtbEstados.StateEditar = "0010100001"
        MtbEstados.StateImprimir = ""
        MtbEstados.StateSalir = ""
        MEAToolBar1.ToolBarButtonStatus = MtbEstados
        MEAToolBar1.sbCambiarEstadoBotones("Cancelar")
        deshabilitar()
        Me.LblEstatus.Visible = False

        'Obtener Informacion para los Combos
        'Estados
        Estados.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        CmbEstado.DataSource = Estados
        CmbEstado.DisplayMember = "Descripcion"
        CmbEstado.ValueMember = "Codigo"

        'Ciudades
        'Ciudades.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        'CmbCiudad.DataSource = Ciudades
        CmbCiudad.DisplayMember = "Descripcion"
        CmbCiudad.ValueMember = "Codigo"
        ''Poblaciones
        'Poblaciones.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        'CmbPoblación.DataSource = Poblaciones
        CmbPoblación.DisplayMember = "Descripcion"
        CmbPoblación.ValueMember = "Codigo"
        ' Bancos
        Bancos.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        cmbBanco.DataSource = Bancos
        cmbBanco.DisplayMember = "descripcion"
        cmbBanco.ValueMember = "codigo"
        'Tipos de Proveedor
        TipoProveedor.Obtener()
        CmbProveedor.DataSource = TipoProveedor
        CmbProveedor.DisplayMember = "descripcion"
        CmbProveedor.ValueMember = "codigo"
        'Dias de Revision
        CmbDiaRevisión.DataSource = diasrev
        CmbDiaRevisión.DisplayMember = "Dia"
        CmbDiaRevisión.ValueMember = "Dia"
        'Dias de Pago
        CmbDiaPgo.DataSource = diaspag
        CmbDiaPgo.DisplayMember = "Dia"
        CmbDiaPgo.ValueMember = "Dia"
        'Lugares de Compra
        cmbLugarCompra.DisplayMember = "Descripcion"
        cmbLugarCompra.ValueMember = "IdLugarCompra"
        cmbLugarCompra.DataSource = LugaresDeCompraCollectionClass.CargarLugaresdeCompra()
        bandera = True

        'tipo de moneda
        Try
            Dim FormasPago As DataSet = New DataSet
            Dim queryString As String = "SELECT IdTipoMoneda,Descripcion+'/'+DescCorta as Moneda FROM CatTiposMoneda"
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(queryString, HC.DbUtils.ActualConnectionString)
            adapter.Fill(FormasPago)
            Me.cmbMoneda.DataSource = FormasPago.Tables(0)
            Me.cmbMoneda.DisplayMember = "Moneda"
            Me.cmbMoneda.ValueMember = "IdTipoMoneda"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'tipo de operacion 
        Try
            Dim FormasPago As DataSet = New DataSet
            Dim queryString As String = "SELECT * FROM ContDiotTiposOperacion"
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(queryString, HC.DbUtils.ActualConnectionString)
            adapter.Fill(FormasPago)
            Me.cmbOperacion.DataSource = FormasPago.Tables(0)
            Me.cmbOperacion.DisplayMember = "Descripcion"
            Me.cmbOperacion.ValueMember = "CodDiot"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'tipo de terceros 
        Try
            Dim FormasPago As DataSet = New DataSet
            Dim queryString As String = "SELECT * FROM ContDiotTiposTerceros"
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(queryString, HC.DbUtils.ActualConnectionString)
            adapter.Fill(FormasPago)
            Me.cmbTercero.DataSource = FormasPago.Tables(0)
            Me.cmbTercero.DisplayMember = "Descripcion"
            Me.cmbTercero.ValueMember = "CodDiot"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

#Region "Validaciones"

    'Private Sub DtpFechAlta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DtpFechAlta.KeyPress
    '    'Para pasar al siguiente control
    '    If e.KeyChar = Chr(13) Then
    '        Me.SelectNextControl(sender, True, True, False, True)
    '        TxtRazonSocial.Focus()
    '    End If
    'End Sub

    'Private Sub TxtRazonSocial_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtRazonSocial.KeyPress
    '    'Para pasar al siguiente control
    '    If e.KeyChar = Chr(13) Then
    '        Me.SelectNextControl(sender, True, True, False, True)
    '        TxtRazonSocial.Focus()
    '        If TxtRazonSocial.Text = "" Then
    '            MsgBox("Agregue Informacion a Razón Social. . . ")
    '            TxtRazonSocial.Focus()
    '        End If
    '        If Editar = True Then
    '            band = True
    '        End If
    '    End If
    'End Sub

    'Private Sub TxtRFC_Leave(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtRFC.Leave
    '    If TxtRFC.Text = "" Then
    '        MsgBox("Agregue Información a RFC (EJEMAAMMDDXXX). . . ")
    '        TxtRFC.Focus()
    '    Else
    '        If Not ValidateRFC(TxtRFC.Text) Then
    '            MsgBox("RFC Invalido (EJEMAAMMDDXXX). . . ")
    '            TxtRFC.Focus()
    '        End If
    '    End If
    'End Sub

    'Private Sub TxtBeneficiario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBeneficiario.KeyPress
    '    'Para pasar al siguiente control
    '    If e.KeyChar = Chr(13) Then
    '        Me.SelectNextControl(sender, True, True, False, True)
    '        TxtContacto.Focus()
    '        If TxtBeneficiario.Text = "" Then
    '            MsgBox("Agregue Informacion a Beneficiario . . . ")
    '            TxtBeneficiario.Focus()
    '        End If
    '    End If
    'End Sub

    'Private Sub TxtContacto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtContacto.KeyPress
    '    'Para pasar al siguiente control
    '    If e.KeyChar = Chr(13) Then
    '        Me.SelectNextControl(sender, True, True, False, True)
    '        TxtRepresentante.Focus()
    '        If TxtContacto.Text = "" Then
    '            MsgBox("Agregue Informacion a Contacto . . . ")
    '            TxtContacto.Focus()
    '        End If
    '    End If
    'End Sub

    'Private Sub TxtRepresentante_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtRepresentante.KeyPress
    '    'Para pasar al siguiente controlHandles
    '    If e.KeyChar = Chr(13) Then
    '        Me.SelectNextControl(sender, True, True, False, True)
    '        TxtDomicilio.Focus()
    '        If TxtRepresentante.Text = "" Then
    '            MsgBox("Agregue Informacion a Representante. . . ")
    '            TxtRepresentante.Focus()
    '        End If
    '    End If
    'End Sub

    'Private Sub TxtDomicilio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDomicilio.KeyPress
    '    'Para pasar al siguiente control
    '    If e.KeyChar = Chr(13) Then
    '        Me.SelectNextControl(sender, True, True, False, True)
    '        TxtColonia.Focus()
    '        If TxtDomicilio.Text = "" Then
    '            MsgBox("Agregue Informacion a Domicilio. . . ")
    '            TxtDomicilio.Focus()
    '        End If

    '    End If
    'End Sub

    'Private Sub TxtColonia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtColonia.KeyPress
    '    'Para pasar al siguiente control
    '    If e.KeyChar = Chr(13) Then
    '        Me.SelectNextControl(sender, True, True, False, True)
    '        TxtCP.Focus()
    '        If TxtColonia.Text = "" Then
    '            MsgBox("Agregue Informacion a Colonia. . . ")
    '            TxtColonia.Focus()
    '        End If
    '    End If
    'End Sub

    Private Sub TxtCP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCP.KeyPress
        ''Para pasar al siguiente control
        'If e.KeyChar = Chr(13) Then
        '    Me.SelectNextControl(sender, True, True, False, True)
        '    TxtCodEdo.Focus()
        '    If TxtCP.Text = "" Then
        '        MsgBox("Agregue Informacion a Código Postal. . . ")
        '        TxtCP.Focus()
        '    End If
        'End If
        ''Si no preciona Retroceso que realice las  validaciones
        'If Not e.KeyChar = Chr(8) Then
        '    'Valida que el caracter ingresado sea numerico
        '    If Not IsNumeric(e.KeyChar) Then
        '        e.Handled = True
        '    End If
        'End If
        If Not (Asc(e.KeyChar) < 32 Or Char.IsDigit(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub TxtCodEdo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodEdo.KeyPress
        ''Para pasar al siguiente control
        'If e.KeyChar = Chr(13) Then
        '    If IsNumeric(TxtCodEdo.Text) Then
        '        If Estado.Obtener(CInt(Me.TxtCodEdo.Text)) Then
        '            CmbEstado.SelectedValue = CInt(TxtCodEdo.Text)
        '            TxtCodCdad.Focus()
        '        Else
        '            Me.CmbEstado.SelectedIndex = -1
        '            Me.TxtCodEdo.Text = ""
        '        End If
        '    Else
        '        Me.TxtCodEdo.Text = ""
        '        Me.CmbEstado.SelectedIndex = -1
        '        CmbEstado.Focus()
        '    End If
        'End If
        ''Si no preciona Retroceso que realice las  validaciones
        'If Not e.KeyChar = Chr(8) Then
        '    If Not IsNumeric(e.KeyChar) Then
        '        e.Handled = True
        '    End If
        'End If
        If Not (Asc(e.KeyChar) < 32 Or Char.IsDigit(e.KeyChar)) Then e.Handled = True
    End Sub

    'Private Sub CmbEstado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbEstado.KeyPress
    '    'Para pasar al siguiente control
    '    If e.KeyChar = Chr(13) Then
    '        Me.SelectNextControl(sender, True, True, False, True)
    '        TxtCodCdad.Focus()
    '    End If
    'End Sub

    Private Sub TxtCodCdad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodCdad.KeyPress
        If e.KeyChar = Chr(13) Then
            If IsNumeric(TxtCodCdad.Text) Then
                If Ciudad.Obtener(CInt(Me.TxtCodCdad.Text)) Then
                    Me.CmbEstado.SelectedValue = Ciudad.CodigoEstado
                    Me.CmbCiudad.SelectedValue = Ciudad.Codigo
                    Me.TxtCodEdo.Text = Ciudad.CodigoEstado.ToString
                    Me.TxtCodPob.Focus()
                Else
                    Proveedor_MensajeError(sender, "No se encontro una ciudad con ese Codigo")
                    Me.CmbEstado.SelectedIndex = -1
                    Me.TxtCodPob.Text = ""
                End If
            Else
                Me.TxtCodCdad.Text = ""
                Me.CmbEstado.SelectedIndex = -1
                Me.CmbCiudad.Focus()
            End If
        End If
        ''Si no preciona Retroceso que realice las  validaciones
        'If Not e.KeyChar = Chr(8) Then
        '    If Not IsNumeric(e.KeyChar) Then
        '        e.Handled = True
        '    End If
        'End If
        If Not (Asc(e.KeyChar) < 32 Or Char.IsDigit(e.KeyChar)) Then e.Handled = True
    End Sub

    'Private Sub CmbCiudad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbCiudad.KeyPress
    '    'Para pasar al siguiente control
    '    If e.KeyChar = Chr(13) Then
    '        Me.SelectNextControl(sender, True, True, False, True)
    '        TxtCodPob.Focus()
    '    End If
    'End Sub

    Private Sub TxtCodPob_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodPob.KeyPress
        If e.KeyChar = Chr(13) Then
            If IsNumeric(Me.TxtCodPob.Text) Then
                If Poblacion.Obtener(CInt(Me.TxtCodEdo.Text), CInt(Me.TxtCodCdad.Text), CInt(Me.TxtCodPob.Text)) Then
                    Me.CmbEstado.SelectedValue = Poblacion.CodigoEstado
                    Me.CmbCiudad.SelectedValue = Poblacion.CodigoCiudad
                    Me.CmbPoblación.SelectedValue = Poblacion.Codigo
                    Me.TxtCodEdo.Text = Poblacion.CodigoEstado.ToString
                    Me.TxtCodCdad.Text = Poblacion.CodigoCiudad.ToString
                    Me.TxtCodPob.Text = Poblacion.Codigo.ToString
                    Me.TxtEmail.Focus()
                Else
                    Proveedor_MensajeError(sender, "No se encontro una poblacion con ese Codigo")
                    Me.TxtCodPob.Text = ""
                    Me.TxtCodCdad.Text = ""
                    Me.TxtCodEdo.Text = ""
                    Me.CmbEstado.SelectedIndex = -1
                    'Me.CmbCiudad.DataSource = Nothing
                    'Me.CmbPoblacion.DataSource = Nothing
                End If
            Else
                Me.TxtCodPob.Text = ""
                Me.TxtCodCdad.Text = ""
                Me.TxtCodEdo.Text = ""
                Me.CmbEstado.SelectedIndex = -1
                Me.CmbEstado.Focus()
            End If
        End If
        'Si no preciona Retroceso que realice las  validaciones
        'If Not e.KeyChar = Chr(8) Then
        '    If Not IsNumeric(e.KeyChar) Then
        '        e.Handled = True
        '    End If
        'End If
        If Not (Asc(e.KeyChar) < 32 Or Char.IsDigit(e.KeyChar)) Then e.Handled = True
    End Sub

    'Private Sub CmbPoblación_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbPoblación.KeyPress
    '    'Para pasar al siguiente control
    '    If e.KeyChar = Chr(13) Then
    '        Me.SelectNextControl(sender, True, True, False, True)
    '        TxtEmail.Focus()
    '    End If
    'End Sub

    Private Sub TxtEmail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtEmail.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            If ValidateEmail(TxtEmail.Text) Then
                Me.SelectNextControl(sender, True, True, False, True)
                ChekPago.Focus()
                If TxtEmail.Text = "" Then
                    MsgBox("Agregue Informacion a Email (nombre@ejemplo.com). . . ")
                    TxtEmail.Focus()
                End If
            Else
                MsgBox("Email Invalido (nombre@ejemplo.com). . . ")
            End If
        End If
    End Sub

    'Private Sub ChekPago_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ChekPago.KeyPress
    '    If e.KeyChar = Chr(13) Then
    '        ChekPago.Checked = Not ChekPago.Checked
    '        Me.SelectNextControl(sender, True, True, False, True)
    '        TxtPaginaWeb.Focus()
    '    End If
    'End Sub

    Private Sub TxtPaginaWeb_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPaginaWeb.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            If ValidarUrl(TxtPaginaWeb.Text) Then
                Me.SelectNextControl(sender, True, True, False, True)
                TxtDiasCredito.Focus()
                If TxtPaginaWeb.Text = "" Then
                    MsgBox("Agregue Informacion a Pagina Web (http://www.ejemplo.com.mx). . . ")
                    TxtPaginaWeb.Focus()
                End If
            Else
                MsgBox("Pagina Web Invalida (http://www.ejemplo.com.mx)")
            End If
        End If
    End Sub

    Private Sub TxtDiasCredito_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDiasCredito.KeyPress
        ''Para pasar al siguiente control
        'If e.KeyChar = Chr(13) Then
        '    Me.SelectNextControl(sender, True, True, False, True)
        '    CmbProveedor.Focus()
        '    If TxtDiasCredito.Text = "" Then
        '        MsgBox("Agregue Informacion a Dias de Credito. . . ")
        '        TxtDiasCredito.Focus()
        '    End If
        'End If
        ''Si no preciona Retroceso que realice las  validaciones
        'If Not e.KeyChar = Chr(8) Then
        '    'Valida que el caracter ingresado sea numerico
        '    If Not IsNumeric(e.KeyChar) Then
        '        e.Handled = True
        '    End If
        'End If
        If Not (Asc(e.KeyChar) < 32 Or Char.IsDigit(e.KeyChar)) Then e.Handled = True
    End Sub

    'Private Sub CmbProveedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbProveedor.KeyPress
    '    'Para pasar al siguiente control
    '    If e.KeyChar = Chr(13) Then
    '        Me.SelectNextControl(sender, True, True, False, True)
    '        TxtDescuento.Focus()
    '    End If
    'End Sub

    Private Sub TxtDescuento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDescuento.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtClave.Focus()
            If TxtDescuento.Text = "" Then
                MsgBox("Agregue Informacion a Descuento. . . ")
                TxtDescuento.Focus()
            End If
        End If
        'Limite de Decimales 0.####
        Dim NDecimales As Integer = 4
        'Limite de Numeros ######.00
        Dim NNumeros As Integer = 6

        'Si no preciona Retroceso que realice las  validaciones
        If Not e.KeyChar = Chr(8) Then
            'Si preciono "." que valide que no haya otro "."
            If e.KeyChar = "." Then
                'Valida que no se haya ingresado un "." anteriormente
                If Me.TxtDescuento.Text.IndexOf(".") >= 0 Then
                    MsgBox("No se permite mas de un '.'")
                    e.Handled = True
                End If
            Else
                'Valida que el caracter ingresado sea numerico
                If Not IsNumeric(e.KeyChar) Then
                    e.Handled = True
                    'Valida que ya se haya ingresado un "." para validar el limite de Decimales
                ElseIf Me.TxtDescuento.Text.IndexOf(".") >= 0 Then
                    'Valida que la candidad de Decimales no sea mayor al establecido
                    If Me.TxtDescuento.Text.Length - Me.TxtDescuento.Text.IndexOf(".") > NDecimales Then
                        e.Handled = True
                    End If
                    'Valida que la cantidad de Numeros antes del "." sean <= a los establecidos
                ElseIf Me.TxtDescuento.Text.Length >= NNumeros Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub TxtClave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtClave.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            cmbBanco.Focus()
            If TxtClave.Text = "" Then
                MsgBox("Agregue Informacion a Clave. . . ")
                TxtClave.Focus()
            End If
        End If
        'Si no preciona Retroceso que realice las  validaciones
        'If Not e.KeyChar = Chr(8) Then
        '    'Valida que el caracter ingresado sea numerico
        '    If Not IsNumeric(e.KeyChar) Then
        '        e.Handled = True
        '    End If
        'End If
        If Not (Asc(e.KeyChar) < 32 Or Char.IsDigit(e.KeyChar)) Then e.Handled = True
    End Sub

    'Private Sub cmbBanco_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbBanco.KeyPress
    '    'Para pasar al siguiente control
    '    If e.KeyChar = Chr(13) Then
    '        Me.SelectNextControl(sender, True, True, False, True)
    '        TxtLada.Focus()
    '    End If
    'End Sub

    Private Sub TxtLada_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtLada.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtTelefono.Focus()
            If TxtLada.Text = "" Then
                MsgBox("Agregue Informacion a Lada de Telefono. . . ")
                TxtLada.Focus()
            End If
        End If
        'Si no preciona Retroceso que realice las  validaciones
        'If Not e.KeyChar = Chr(8) Then
        '    'Valida que el caracter ingresado sea numerico
        '    If Not IsNumeric(e.KeyChar) Then
        '        e.Handled = True
        '    End If
        'End If
        If Not (Asc(e.KeyChar) < 32 Or Char.IsDigit(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub TxtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTelefono.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtLada1.Focus()
            If TxtTelefono.Text = "" Then
                MsgBox("Agregue Informacion a Numero de Telefono. . . ")
                TxtTelefono.Focus()
            End If
        End If
        ''Si no preciona Retroceso que realice las  validaciones
        'If Not e.KeyChar = Chr(8) Then
        '    'Valida que el caracter ingresado sea numerico
        '    If Not IsNumeric(e.KeyChar) Then
        '        e.Handled = True
        '    End If
        'End If
        If Not (Asc(e.KeyChar) < 32 Or Char.IsDigit(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub TxtLada1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtLada1.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtTelefono1.Focus()
            If TxtLada1.Text = "" Then
                MsgBox("Agregue Informacion a Lada de Telefono. . . ")
                TxtLada1.Focus()
            End If
        End If
        ''Si no preciona Retroceso que realice las  validaciones
        'If Not e.KeyChar = Chr(8) Then
        '    'Valida que el caracter ingresado sea numerico
        '    If Not IsNumeric(e.KeyChar) Then
        '        e.Handled = True
        '    End If
        'End If
        If Not (Asc(e.KeyChar) < 32 Or Char.IsDigit(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub TxtTelefono1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTelefono1.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtLada2.Focus()
            If TxtTelefono1.Text = "" Then
                MsgBox("Agregue Informacion a Numero de Telefono. . . ")
                TxtTelefono1.Focus()
            End If
        End If
        ''Si no preciona Retroceso que realice las  validaciones
        'If Not e.KeyChar = Chr(8) Then
        '    'Valida que el caracter ingresado sea numerico
        '    If Not IsNumeric(e.KeyChar) Then
        '        e.Handled = True
        '    End If
        'End If
        If Not (Asc(e.KeyChar) < 32 Or Char.IsDigit(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub TxtLada2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtLada2.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            TxtFax.Focus()
            If TxtLada2.Text = "" Then
                MsgBox("Agregue Informacion a Lada de Fax. . . ")
                TxtLada2.Focus()
            End If
        End If
        ''Si no preciona Retroceso que realice las  validaciones
        'If Not e.KeyChar = Chr(8) Then
        '    'Valida que el caracter ingresado sea numerico
        '    If Not IsNumeric(e.KeyChar) Then
        '        e.Handled = True
        '    End If
        'End If
        If Not (Asc(e.KeyChar) < 32 Or Char.IsDigit(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub TxtFax_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFax.KeyPress
        'Para pasar al siguiente control
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, False, True)
            CmbDiaRevisión.Focus()
            If TxtFax.Text = "" Then
                MsgBox("Agregue Informacion a Numero de Fax. . . ")
                TxtFax.Focus()
            End If
        End If
        ''Si no preciona Retroceso que realice las  validaciones
        'If Not e.KeyChar = Chr(8) Then
        '    'Valida que el caracter ingresado sea numerico
        '    If Not IsNumeric(e.KeyChar) Then
        '        e.Handled = True
        '    End If
        'End If
        If Not (Asc(e.KeyChar) < 32 Or Char.IsDigit(e.KeyChar)) Then e.Handled = True
    End Sub

    'Private Sub CmbDiaRevisión_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbDiaRevisión.KeyPress
    '    'Para pasar al siguiente control
    '    If e.KeyChar = Chr(13) Then
    '        Me.SelectNextControl(sender, True, True, False, True)
    '        CmbDiaPgo.Focus()
    '    End If
    'End Sub

    Private Sub DataGrid_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)

    End Sub

    Private Sub Validar()
        Dim provC As New ClasesNegocio.ProveedorCollectionClass
        provC.Obtener(False, Me.TxtRazonSocial.Text, ClasesNegocio.CondicionEnum.ACTIVOS)
    End Sub

    Private Sub Proveedor_Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Handles Proveedor.Modificado
        If PuedoRefrescar Then
            Me.txtCtaCont.Text = Proveedor.CuentaContable2.NombreCuenta & ": " & Proveedor.CuentaContable2.CuentaContable
            Me.txtCtaAnt.Text = Proveedor.CuentaAnticipo.NombreCuenta & ": " & Proveedor.CuentaAnticipo.CuentaContable
            TxtCodigo.Text = Proveedor.Codigo
            txtNombre.Text = Proveedor.Nombre
            If Proveedor.rfc.Length > 3 Then
                If Char.IsDigit(Proveedor.rfc.Substring(3, 1)) Then
                    rbtPerMoral.Checked = True
                Else
                    rbtPerFisica.Checked = True
                End If
            Else
                rbtPerFisica.Checked = True
            End If
            mtbRFC.Text = Proveedor.rfc
            TxtRazonSocial.Text = Proveedor.RazonSocial
            TxtBeneficiario.Text = Proveedor.NomBeneficiario
            TxtContacto.Text = Proveedor.Contacto
            TxtRepresentante.Text = Proveedor.RepLegal
            TxtDomicilio.Text = Proveedor.Domicilio
            TxtColonia.Text = Proveedor.Colonia
            TxtCP.Text = Proveedor.CP
            TxtCodEdo.Text = Proveedor.Estado.Codigo
            CmbEstado.SelectedValue = Proveedor.Estado.Codigo
            TxtCodCdad.Text = Proveedor.Ciudad.Codigo
            CmbCiudad.SelectedValue = Proveedor.Ciudad.Codigo
            TxtCodPob.Text = Proveedor.Poblacion.Codigo
            CmbPoblación.SelectedValue = Proveedor.Poblacion.Codigo
            Me.LblEstatus.Visible = True
            LblEstatus.Text = Proveedor.Estatus.ToString
            TxtEmail.Text = Proveedor.Email
            ChekPago.Checked = Proveedor.ppago
            TxtPaginaWeb.Text = Proveedor.Web
            'TxtClaveBancaria.Text = Proveedor.PrClaveBancaria
            If Proveedor.prClaveBancaria Is Nothing Then
                TxtClaveBancaria.Text = 0
            Else
                TxtClaveBancaria.Text = Proveedor.prClaveBancaria
            End If

            'TxtNoCuenta.Text = Proveedor.prNoCuenta
            If Proveedor.prNoCuenta Is Nothing Then
                TxtNoCuenta.Text = 0
            Else
                TxtNoCuenta.Text = Proveedor.prNoCuenta

            End If

            If Proveedor.TipoMoneda IsNot Nothing Then
                cmbMoneda.SelectedValue = Proveedor.TipoMoneda
            End If

            If Proveedor.TipoTerceros IsNot Nothing Then
                cmbTercero.SelectedValue = Proveedor.TipoTerceros
            End If

            If Proveedor.TipoOperacion IsNot Nothing Then
                cmbOperacion.SelectedValue = Proveedor.TipoOperacion
            End If

            If Proveedor.TipoProveedor.HasValue Then
                CmbProveedor.SelectedValue = Proveedor.TipoProveedor
            End If

            If Proveedor.Banco.HasValue Then
                cmbBanco.SelectedValue = Proveedor.Banco
            End If
            CmbDiaRevisión.SelectedValue = Proveedor.DiaRevision
            CmbDiaPgo.SelectedValue = Proveedor.DiaPago
            TxtTelefono.Text = Proveedor.Telefono1
            TxtTelefono1.Text = Proveedor.Telefono2
            TxtFax.Text = Proveedor.Fax
            TxtLada.Text = Proveedor.lada1
            TxtLada1.Text = Proveedor.lada2
            TxtLada2.Text = Proveedor.ladafax
            TxtDiasCredito.Text = Proveedor.DiasCredito
            TxtDescuento.Text = Proveedor.PorcDescto
            TxtClave.Text = Proveedor.Clabe
            chkEsdeGanado.Checked = Proveedor.EsdeGanado

            If Proveedor.EsdeGanado Then
                If Proveedor.IdLugarCompra.Value <> -1 Then
                    cmbLugarCompra.SelectedValue = Proveedor.IdLugarCompra.Value
                End If
            End If




            chkAutoFactura.Checked = Proveedor.AutoFactura
            txtImporteUltimaCompra.Text = Proveedor.ImporteUltimaCompra.ToString
            txtImporteUltimoPago.Text = Proveedor.ImporteUltimoPago
            dtpFechaUltimaCompra.Value = Proveedor.FechaUltimaCompra
            dtpFechaUltimoPago.Value = Proveedor.FechaUltimoPago
            txtComprasAnoActual.Text = Proveedor.ComprasAnoActual
            txtComprasAnoAnterior.Text = Proveedor.ComprasAnoAnterior
            txtAcumComCab.Text = Proveedor.AcumComCab
            txtAcumComKilos.Text = Proveedor.AcumComKil
            txtSaldoActual.Text = Proveedor.SaldoActual
            txtAcumComCabAnterior.Text = Proveedor.AcumComCabAnterior
            txtAcumComKilosAnterior.Text = Proveedor.AcumComKilAnterior
            txtPorcentajeFinanciero.Text = Proveedor.PorcentajeFinanciero

            Me.DomicilioFiscalCol = Proveedor.DomicilioFiscales
            Me.DgFiscal.DataSource = Me.DomicilioFiscalCol
        End If
    End Sub

    Private Sub Proveedor_MensajeError(ByVal sender As Object, ByVal mensaje As String) Handles Proveedor.MensajeError
        MessageBox.Show(mensaje)
    End Sub
#End Region


    Private Sub CmbEstado_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles CmbEstado.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                'Estados
                Estados.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
                CmbEstado.DataSource = Estados
                CmbEstado.DisplayMember = "Descripcion"
                CmbEstado.ValueMember = "Codigo"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Obtiene las Ciudades del estado seleccionado
    Private Sub CmbEstado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbEstado.SelectedIndexChanged
        If CmbEstado.SelectedIndex > -1 And Not Me.CmbEstado.ValueMember = "" And bandera = True Then
            Me.TxtCodEdo.Text = Me.CmbEstado.SelectedValue
            Ciudades = DirectCast(CmbEstado.SelectedItem, ClasesNegocio.EstadoClass).ObtenerCiudad
            CmbCiudad.DataSource = Ciudades
            Me.CmbCiudad.SelectedIndex = -1
            Me.CmbPoblación.DataSource = Nothing
            CmbCiudad.Text = "Seleccione una Ciudad..."

            Me.TxtCodPob.Text = ""
            Me.TxtCodCdad.Text = ""
            Me.CmbPoblación.Text = ""
        Else
            Me.CmbCiudad.DataSource = Nothing
            Me.CmbPoblación.DataSource = Nothing
            Me.TxtCodEdo.Text = ""
            Me.TxtCodCdad.Text = ""
            Me.TxtCodPob.Text = ""
        End If
    End Sub

    Private Sub CmbCiudad_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles CmbCiudad.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                Me.CmbEstado_SelectedIndexChanged(Me, e)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Obtiene las Poblaciones de la ciudad seleccionada
    Private Sub CmbCiudad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCiudad.SelectedIndexChanged
        If Me.CmbCiudad.SelectedIndex > -1 And Not Me.CmbCiudad.ValueMember = "" And bandera Then
            'Poblaciones.Obtener(Me.CmbCiudad.SelectedItem, ClasesNegocio.CondicionEnum.ACTIVOS)
            Me.TxtCodCdad.Text = Me.CmbCiudad.SelectedValue
            Poblaciones.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS, CInt(TxtCodEdo.Text), CInt(TxtCodCdad.Text))
            'Poblaciones = DirectCast(CmbCiudad.SelectedItem, ClasesNegocio.CiudadClass).Obtenerpoblacion
            CmbPoblación.DataSource = Poblaciones
            Me.CmbPoblación.SelectedIndex = -1
            CmbPoblación.Text = "Seleccione una Población..."

            Me.TxtCodPob.Text = ""
        Else
            Me.CmbPoblación.DataSource = Nothing
            Me.TxtCodPob.Text = ""
            Me.TxtCodCdad.Text = ""
        End If
    End Sub

    Private Sub CmbPoblación_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles CmbPoblación.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                Me.CmbCiudad_SelectedIndexChanged(Me, e)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    '
    Private Sub CmbPoblación_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPoblación.SelectedIndexChanged
        If Me.CmbPoblación.SelectedIndex > -1 And Not Me.CmbPoblación.ValueMember = "" Then
            Me.TxtCodPob.Text = Me.CmbPoblación.SelectedValue
        Else
            Me.TxtCodPob.Text = ""
        End If
    End Sub

#Region "Metodos"

    Private Sub Limpiar()
        TxtCodigo.Clear()
        DtpFechAlta.Value = Now
        TxtRazonSocial.Clear()
        mtbRFC.Clear()
        TxtBeneficiario.Clear()
        TxtContacto.Clear()
        TxtRepresentante.Clear()
        TxtDomicilio.Clear()
        TxtColonia.Clear()
        TxtCP.Clear()
        TxtCodEdo.Clear()
        CmbEstado.SelectedValue = -1
        CmbEstado.Text = "Seleccione un Estado"
        TxtCodCdad.Clear()
        CmbCiudad.SelectedValue = -1
        CmbCiudad.Text = ""
        TxtCodPob.Clear()
        CmbPoblación.SelectedValue = -1
        CmbPoblación.Text = ""
        ChekPago.Checked = False
        TxtEmail.Clear()
        TxtPaginaWeb.Clear()
        TxtDiasCredito.Clear()
        CmbProveedor.SelectedValue = -1
        CmbProveedor.Text = ""
        TxtDescuento.Clear()
        TxtClave.Clear()
        cmbBanco.SelectedValue = -1
        cmbBanco.Text = ""
        CmbDiaRevisión.SelectedValue = -1
        CmbDiaRevisión.Text = ""
        CmbDiaPgo.SelectedValue = -1
        CmbDiaPgo.Text = ""
        TxtLada.Clear()
        TxtTelefono.Clear()
        TxtLada1.Clear()
        TxtTelefono1.Clear()
        TxtLada2.Clear()
        TxtFax.Clear()
        Me.LblEstatus.Visible = False
        LblEstatus.Text = "ESTATUS"
        Seleccionado = False
        Me.txtCtaAnt.Text = ""
        Me.txtCtaCont.Text = ""
        TxtClaveBancaria.Text = 0
        TxtNoCuenta.Text = 0
        cmbMoneda.SelectedValue = -1
        cmbOperacion.SelectedValue = -1
        cmbTercero.SelectedValue = -1

        'By: Jorge
        txtNombre.Text = String.Empty
        txtImporteUltimaCompra.Text = String.Empty
        txtImporteUltimoPago.Text = String.Empty
        txtComprasAnoActual.Text = String.Empty
        txtAcumComCab.Text = String.Empty
        txtAcumComKilos.Text = String.Empty
        txtSaldoActual.Text = String.Empty
        dtpFechaUltimaCompra.Value = Now
        dtpFechaUltimoPago.Value = Now
        txtComprasAnoAnterior.Text = String.Empty
        txtAcumComCabAnterior.Text = String.Empty
        txtAcumComKilosAnterior.Text = String.Empty
        cmbLugarCompra.SelectedIndex = -1
        cmbLugarCompra.SelectedText = "Seleccione el lugar de compra"
        txtPorcentajeFinanciero.Text = String.Empty
        chkAutoFactura.Checked = False
        Me.chkEsdeGanado.Checked = False
    End Sub

    Private Sub deshabilitar()
        TxtCodigo.Enabled = False
        DtpFechAlta.Enabled = False
        TxtRazonSocial.Enabled = False
        mtbRFC.Enabled = False
        TxtBeneficiario.Enabled = False
        TxtContacto.Enabled = False
        TxtRepresentante.Enabled = False
        TxtDomicilio.Enabled = False
        TxtColonia.Enabled = False
        TxtCP.Enabled = False
        TxtCodEdo.Enabled = False
        CmbEstado.Enabled = False
        TxtCodCdad.Enabled = False
        CmbCiudad.Enabled = False
        TxtCodPob.Enabled = False
        CmbPoblación.Enabled = False
        ChekPago.Enabled = False
        TxtEmail.Enabled = False
        TxtPaginaWeb.Enabled = False
        TxtDiasCredito.Enabled = False
        CmbProveedor.Enabled = False
        TxtDescuento.Enabled = False
        TxtClave.Enabled = False
        cmbBanco.Enabled = False
        CmbDiaRevisión.Enabled = False
        CmbDiaPgo.Enabled = False
        TxtLada.Enabled = False
        TxtTelefono.Enabled = False
        TxtLada1.Enabled = False
        TxtTelefono1.Enabled = False
        TxtLada2.Enabled = False
        TxtFax.Enabled = False
        Me.txtCtaAnt.Enabled = False
        Me.txtCtaCont.Enabled = False
        Me.btnCtaAnt.Enabled = False
        Me.btnCtaCont.Enabled = False
        grpTipoPersona.Enabled = False
        TxtClaveBancaria.Enabled = False
        TxtNoCuenta.Enabled = False
        cmbMoneda.Enabled = False
        cmbOperacion.Enabled = False
        cmbTercero.Enabled = False


        'By: Jorge
        chkEsdeGanado.Enabled = False
        txtNombre.Enabled = False
        chkAutoFactura.Enabled = False
        cmbLugarCompra.Enabled = False
    End Sub

    Private Sub habilitar()
        TxtCodigo.Enabled = False
        DtpFechAlta.Enabled = True
        TxtRazonSocial.Enabled = True
        mtbRFC.Enabled = True
        '  TxtBeneficiario.Enabled = True
        TxtContacto.Enabled = True
        TxtRepresentante.Enabled = True
        TxtDomicilio.Enabled = True
        TxtColonia.Enabled = True
        TxtCP.Enabled = True
        TxtCodEdo.Enabled = True
        CmbEstado.Enabled = True
        TxtCodCdad.Enabled = True
        CmbCiudad.Enabled = True
        TxtCodPob.Enabled = True
        CmbPoblación.Enabled = True
        ChekPago.Enabled = True
        TxtEmail.Enabled = True
        TxtPaginaWeb.Enabled = True
        TxtDiasCredito.Enabled = True
        CmbProveedor.Enabled = True
        TxtDescuento.Enabled = True
        TxtClave.Enabled = True
        cmbBanco.Enabled = True
        CmbDiaRevisión.Enabled = True
        CmbDiaPgo.Enabled = True
        TxtLada.Enabled = True
        TxtTelefono.Enabled = True
        TxtLada1.Enabled = True
        TxtTelefono1.Enabled = True
        TxtLada2.Enabled = True
        TxtFax.Enabled = True
        Me.txtCtaAnt.Enabled = True
        Me.txtCtaCont.Enabled = True
        Me.btnCtaAnt.Enabled = True
        Me.btnCtaCont.Enabled = True
        grpTipoPersona.Enabled = True
        TxtClaveBancaria.Enabled = True
        TxtNoCuenta.Enabled = True
        cmbMoneda.Enabled = True
        cmbOperacion.Enabled = True
        cmbTercero.Enabled = True

        'By: Jorge
        chkEsdeGanado.Enabled = True
        txtNombre.Enabled = True
        chkAutoFactura.Enabled = True

        If chkEsdeGanado.Checked Then
            cmbLugarCompra.Enabled = True
        End If
        Me.Label28.Visible = False
        Me.Label29.Visible = False
        Me.Label40.Visible = False
        Me.Label41.Visible = False
        Me.txtAcumComCab.Visible = False
        Me.txtAcumComCabAnterior.Visible = False
        Me.txtAcumComKilos.Visible = False
        Me.txtAcumComKilosAnterior.Visible = False
    End Sub

    Private Sub guardar()
        Try
            Proveedor.Nombre = txtNombre.Text.Trim
            Proveedor.rfc = mtbRFC.Text
            Proveedor.RazonSocial = TxtRazonSocial.Text
            Proveedor.NomBeneficiario = TxtBeneficiario.Text
            Proveedor.Contacto = TxtContacto.Text
            Proveedor.RepLegal = TxtRepresentante.Text
            Proveedor.Domicilio = TxtDomicilio.Text
            Proveedor.Colonia = TxtColonia.Text
            Proveedor.CP = TxtCP.Text
            Proveedor.Poblacion = DirectCast(CmbPoblación.SelectedItem, ClasesNegocio.PoblacionClass)
            Proveedor.FechaAlta = Now
            Proveedor.Banco = cmbBanco.SelectedValue
            Proveedor.prClaveBancaria = TxtClaveBancaria.Text
            Proveedor.prNoCuenta = TxtNoCuenta.Text
            Proveedor.TipoMoneda = cmbMoneda.SelectedValue
            Proveedor.TipoOperacion = cmbOperacion.SelectedValue
            Proveedor.TipoTerceros = cmbTercero.SelectedValue


            If ChekPago.Checked Then
                Proveedor.ppago = ClasesNegocio.PPagoEnum.SI
            End If
            Proveedor.Email = TxtEmail.Text
            Proveedor.Web = TxtPaginaWeb.Text
            Proveedor.TipoProveedor = CmbProveedor.SelectedValue
            Proveedor.DiaRevision = CmbDiaRevisión.SelectedValue
            Proveedor.DiaPago = CmbDiaPgo.SelectedValue
            Proveedor.Telefono1 = TxtTelefono.Text
            Proveedor.Telefono2 = TxtTelefono1.Text
            Proveedor.Fax = TxtFax.Text
            Proveedor.lada1 = TxtLada.Text
            Proveedor.lada2 = TxtLada1.Text
            Proveedor.ladafax = TxtLada2.Text
            Proveedor.DiasCredito = TxtDiasCredito.Text
            Proveedor.PorcDescto = TxtDescuento.Text
            Proveedor.Clabe = TxtClave.Text
            Proveedor.EsdeGanado = chkEsdeGanado.Checked
            If Proveedor.EsdeGanado Then
                Proveedor.IdLugarCompra = cmbLugarCompra.SelectedValue
            End If
            Proveedor.AutoFactura = chkAutoFactura.Checked
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function GuardarBeneficiario(ByRef Trans As HC.Transaction) As Boolean
        Dim Var As Boolean = True
        If Editar = True Then
            ' Dim Beneficiario As EC.BeneficiarioEntity
            Dim Beneficiario As ClasesNegocio.BeneficiarioClass = Proveedor.Beneficiario
            Beneficiario.Beneficiario = Me.TxtRazonSocial.Text
            'Beneficiario.Beneficiario = Me.TxtRazonSocial.Text
            Trans.Add(Beneficiario.ObtenerEntidad)
            If Not Beneficiario.Guardar(Var) Then
                Return False
            End If
            Return True
        End If
    End Function

    Private Function Validar2() As Boolean
        Try
            Dim Mensaje As String = ""

            If txtNombre.Text = String.Empty Then
                'MessageBox.Show("El Nombre es Obligatoria Agregue Información ")
                'Me.txtNombre.Focus()
                'Return False
                Mensaje = Mensaje + "   * El nombre es un dato requerido." + vbNewLine
            End If
            'If TxtRazonSocial.Text = "" Or mtbRFC.Text = "" Then
            '    MessageBox.Show("La Razón Social y R.F.C. es Obligatoria Agregue Información ")
            '    Me.TxtRazonSocial.Focus()
            '    Return False
            'End If
            If TxtRazonSocial.Text = "" Then
                Mensaje = Mensaje + "   * La razón social es un dato requerido." + vbNewLine
            End If
            If mtbRFC.Text = "" Then
                Mensaje = Mensaje + "   * El R.F.C. es un dato requerido." + vbNewLine
            Else
                If Not ValidateRFC(mtbRFC.Text) Then
                    Mensaje = Mensaje + "   * El R.F.C. no está correctamente capturado." + vbNewLine
                End If
            End If

            If Me.TxtDiasCredito.Text = "" Or Me.TxtDescuento.Text = "" Then
                'MessageBox.Show("Los días crédito y el descuento son obligatorios Agregue Información", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'Me.TxtDiasCredito.Focus()
                'Return False
                Mensaje = Mensaje + "   * Los días crédito y el descuento son obligatorios." + vbNewLine
            End If
            If Me.CmbEstado.SelectedIndex = -1 Then
                'MessageBox.Show("Seleccione un Estado", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'Me.CmbEstado.Focus()
                'Return False
                Mensaje = Mensaje + "   * Seleccione un Estado." + vbNewLine
            End If
            If Me.CmbCiudad.SelectedIndex = -1 Then
                'MessageBox.Show("Seleccione una Ciudad", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'Me.CmbCiudad.Focus()
                'Return False
                Mensaje = Mensaje + "   * Seleccione una Ciudad." + vbNewLine
            End If
            If Me.CmbPoblación.SelectedIndex = -1 Then
                'MessageBox.Show("Seleccione una población", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'Me.CmbPoblación.Focus()
                'Return False
                Mensaje = Mensaje + "   * Seleccione una población." + vbNewLine
            End If
            If Me.CmbProveedor.SelectedIndex = -1 Then
                Mensaje = Mensaje + "   * Debe escoger un tipo de proveedor." + vbNewLine
            End If
            If chkEsdeGanado.Checked And cmbLugarCompra.SelectedValue Is Nothing Then
                'MessageBox.Show("El Lugar de Compra es Obligatorio Agregue Información ")
                'Me.cmbLugarCompra.Focus()
                'Return False
                Mensaje = Mensaje + "   * El lugar de compra es obligatorio." + vbNewLine
            End If

            If Mensaje = "" Then
                Return True
            Else
                MessageBox.Show("Es necesario corregir lo siguiente:" + vbNewLine + Mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
#End Region

    Private Sub MEAToolBar1_ClickLimpiar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickLimpiar
        If Me.Seleccionado Then
            Limpiar()
        Else
            Limpiar()
            Cancelar = True
        End If
    End Sub

    Private Sub MEAToolBar1_ClickSalir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickSalir
        Me.Close()
    End Sub

    Private Sub MEAToolBar1_ClickCancelar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickCancelar
        Limpiar()
        deshabilitar()
        MEAToolBar1.sbCambiarEstadoBotones("buscar")
    End Sub

    Private Sub MEAToolBar1_ClickBorrar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickBorrar
        If Proveedor.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
            If Proveedor.Borrar Then
                MessageBox.Show("El Proveedor ha sido Inactivado.")
                deshabilitar()
                ProveedorCol.Obtener()
            Else
                Cancelar = True
            End If
            Limpiar()
        Else
            MessageBox.Show("El Proveedor Ya Esta Inactivado.")
            Limpiar()
            deshabilitar()
        End If
    End Sub

    Private Sub MEAToolBar1_ClickEditar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickEditar
        If Proveedor.Estatus = ClasesNegocio.EstatusEnum.ACTIVO Then
            habilitar()
            Editar = True
        Else
            MessageBox.Show("El Proveedor esta Inactivo No se Puede Editar.")
            Editar = False
            Cancelar = True
            MEAToolBar1.sbCambiarEstadoBotones("Guardar")
            Limpiar()
            deshabilitar()
        End If
    End Sub

    Private Sub MEAToolBar1_ClickGuardar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickGuardar
        Dim trans As New HC.Transaction(IsolationLevel.ReadCommitted, "Proveedor")
        Try
            PuedoRefrescar = False
            If Not Validar2() Then
                Cancelar = True
                Exit Sub
            End If
            guardar()
            PuedoRefrescar = True
            If band = True Then
                If Not GuardarBeneficiario(trans) Then
                    trans.Rollback()
                    Cancelar = True
                End If
            End If
            If Proveedor.Guardar(trans) Then
                MessageBox.Show("El Proveedor se ha guardado satisfactoriamente.")
                deshabilitar()
                Limpiar()
                ProveedorCol.Obtener()
            Else
                trans.Rollback()
                Cancelar = True
            End If
            trans.Commit()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MEAToolBar1_ClickImprimir(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickImprimir
        Dim Previsualizar As New ClasesNegocio.PreVisualizarForm
        If Me.Proveedor.Codigo = 0 Then
            ProveedorCol.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
        End If
        Previsualizar.Reporte = ProveedorCol.Reporte(Controlador.Sesion.MiEmpresa.Empnom, Controlador.Sesion.MiUsuario.Usrnom)
        Previsualizar.ShowDialog()
    End Sub

    Private Sub MEAToolBar1_ClickNuevo(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickNuevo
        Limpiar()
        habilitar()
        Editar = False
        Proveedor = New ClasesNegocio.ProveedorClass()
        Proveedor.DomicilioFiscales = New ClasesNegocio.DomicilioFiscalCollectionClass
        Me.DgFiscal.DataSource = Proveedor.DomicilioFiscales
    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ventana As New BusquedaCuentasContablesForm

        ventana.AfectableDefault(True) = ClasesNegocio.CondicionAsignadaEnum.SI
        ventana.NarutalezaDefault(True) = ClasesNegocio.CuentaContableNaturalezaCondicionEnum.DEUDORAS

        If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.Proveedor.CuentaContable2 = ventana.CuentaContable
            'Proveedor.AgregarDatosContables(FrmVentCatCtaContables.ProveedorContable)
            'Me.txtCuentaContable.Text = ventana.CuentaContable.NombreCuenta & ": " & ventana.CuentaContable.CuentaContable
        End If
        'Dim FrmVentCatCtaContables As New VentCatCtaContables
        'If FrmVentCatCtaContables.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    'Proveedor.AgregarDatosContables(FrmVentCatCtaContables.ProveedorContable)
        '    Proveedor.cuentacontable.Add(FrmVentCatCtaContables.ProveedorContable)
        'End If
    End Sub

    Private Sub ChekPago_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChekPago.CheckedChanged
        ChekPago.Enabled = ChekPago.Checked
    End Sub

    'Funcion que me valida la forma de un email
    Function ValidateEmail(ByVal email As String) As Boolean
        Dim emailRegex As _
            New System.Text.RegularExpressions.Regex( _
            "^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As  _
            System.Text.RegularExpressions.Match = emailRegex.Match(email)
        Return emailMatch.Success
    End Function

    'Funcion que me valida la forma de un RFC

    Function ValidateRFC(ByVal RFC As String) As Boolean
        Dim RFCRegex As New System.Text.RegularExpressions.Regex("^[a-zA-Z]{3,4}(\d{6})((\D|\d){3})?$")
        Dim RFCMatch As System.Text.RegularExpressions.Match = RFCRegex.Match(RFC)
        Return RFCMatch.Success

    End Function

    'FUNCION QUE VALIDA UNA PAGINA WEB
    Public Function ValidarUrl(ByVal URL As String) As Boolean
        'Comprobamos si la dirección es correcta, en caso de no ser así devolvemos False y salimos de la función.
        If Not System.Uri.IsWellFormedUriString(URL, UriKind.Absolute) Then
            MsgBox("Pagina Web no es valida")
            Return False
            Exit Function
        End If
        'Instanciamos la clase Uri para poder comprobar el scheme.
        Dim objUri As Uri = New Uri(URL)
        'Y ahora comprobamos si es de tipo HTTP o HTTPs
        If objUri.Scheme = Uri.UriSchemeHttp Or objUri.Scheme = Uri.UriSchemeHttps Then
            Return True
            Exit Function
        Else
            Return False
        End If
    End Function

    Private Sub MEAToolBar1_ClickBuscar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs, ByRef Cancelar As System.Boolean) Handles MEAToolBar1.ClickBuscar
        Dim ventana As New FrmBuscarProveedores

        If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
            Proveedor = New ClasesNegocio.ProveedorClass(New EC.ProveedorEntity(ventana.DataGrid.SelectedRows(0).Cells(ventana.clmCodigo.Index).Value))
            Me.PuedoRefrescar = True
            Me.Proveedor_Modificado(Me, New EventArgs)
            Me.PuedoRefrescar = False
            Me.ProveedorCol.Add(Proveedor)
        End If
    End Sub

    Private Sub BtnAgrega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgrega.Click
        If Me.mtbRFC.Text = "" Then
            MsgBox("Primero Establesca su RFC", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If
        Dim ventana As New frmBusquedaDomicilioFiscal
        ventana.RFC = Me.mtbRFC.Text

        If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
            For i As Integer = 0 To ventana.DataGridView1.SelectedRows.Count - 1
                Dim entc As ClasesNegocio.DomicilioFiscalClass
                entc = DirectCast(ventana.DataGridView1.SelectedRows(i).DataBoundItem, ClasesNegocio.DomicilioFiscalClass)
                If Proveedor.DomicilioFiscales Is Nothing Then
                    Proveedor.DomicilioFiscales = New ClasesNegocio.DomicilioFiscalCollectionClass
                    Me.DomicilioFiscalCol = Proveedor.DomicilioFiscales
                    Me.DgFiscal.DataSource = Me.DomicilioFiscalCol
                End If
                If Proveedor.DomicilioFiscales.Existe(entc) Then
                    MsgBox(String.Format("Ya esta el domicilio fiscal con el Código:{1} y RFC: {0}, en la lista de domicilios fiscales", entc.RFC, entc.Codigo), MsgBoxStyle.Information, "Aviso")
                Else
                    Proveedor.DomicilioFiscales.Add(entc)
                End If
            Next
        End If
    End Sub

    Private Sub btnCtaCont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCtaCont.Click
        Dim ventana As New BusquedaCuentasContablesForm

        ventana.chkAfe.Checked = True
        ventana.chkBan.CheckState = CheckState.Indeterminate
        ventana.chkDep.CheckState = CheckState.Indeterminate
        ventana.chkIna.Checked = False
        ventana.chkPre.CheckState = CheckState.Indeterminate
        ventana.chkRes.CheckState = CheckState.Indeterminate

        ventana.Var = False
        ventana.BloquearCaracteristicas = True
        ventana.AfectableDefault = ClasesNegocio.CondicionAsignadaEnum.SI

        If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
            If Not ventana.CuentaContable.NombreCuenta & ": " & ventana.CuentaContable.CuentaContable = txtCtaAnt.Text Then
                Me.Proveedor.CuentaContable2 = ventana.CuentaContable
                Me.txtCtaCont.Text = ventana.CuentaContable.NombreCuenta & ": " & ventana.CuentaContable.CuentaContable
            Else
                MessageBox.Show("La Cuenta Contable debe ser diferente a la Cuenta de Anticipo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub btnCtaAnt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCtaAnt.Click
        Try
            Dim ventana As New BusquedaCuentasContablesForm

            ventana.chkAfe.Checked = True
            ventana.chkBan.CheckState = CheckState.Indeterminate
            ventana.chkDep.CheckState = CheckState.Indeterminate
            ventana.chkIna.Checked = False
            ventana.chkPre.CheckState = CheckState.Indeterminate
            ventana.chkRes.CheckState = CheckState.Indeterminate

            ventana.Var = False
            ventana.BloquearCaracteristicas = True
            ventana.AfectableDefault = ClasesNegocio.CondicionAsignadaEnum.SI

            If ventana.ShowDialog = Windows.Forms.DialogResult.OK Then
                If Not ventana.CuentaContable.NombreCuenta & ": " & ventana.CuentaContable.CuentaContable = Me.txtCtaAnt.Text Then
                    Me.Proveedor.CuentaAnticipo = ventana.CuentaContable
                    Me.txtCtaAnt.Text = ventana.CuentaContable.NombreCuenta & ": " & ventana.CuentaContable.CuentaContable
                Else
                    MessageBox.Show("La cuenta de Anticipo debe ser diferente a la cuenta contable", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CmbProveedor_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles CmbProveedor.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                TipoProveedor.Obtener()
                CmbProveedor.DataSource = TipoProveedor
                CmbProveedor.DisplayMember = "descripcion"
                CmbProveedor.ValueMember = "codigo"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbBanco_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbBanco.PreviewKeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                ' Bancos
                Bancos.Obtener(ClasesNegocio.CondicionEnum.ACTIVOS)
                cmbBanco.DataSource = Bancos
                cmbBanco.DisplayMember = "descripcion"
                cmbBanco.ValueMember = "codigo"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkEsdeGanado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEsdeGanado.CheckedChanged
        If CType(sender, CheckBox).Checked Then
            'If Me.puedorefrescar = False Then
            cmbLugarCompra.Enabled = True
            'End If
            Me.Label28.Visible = True
            Me.Label29.Visible = True
            Me.Label40.Visible = True
            Me.Label41.Visible = True
            Me.txtAcumComCab.Visible = True
            Me.txtAcumComCabAnterior.Visible = True
            Me.txtAcumComKilos.Visible = True
            Me.txtAcumComKilosAnterior.Visible = True
        Else
            cmbLugarCompra.Enabled = False
            Me.Label28.Visible = False
            Me.Label29.Visible = False
            Me.Label40.Visible = False
            Me.Label41.Visible = False
            Me.txtAcumComCab.Visible = False
            Me.txtAcumComCabAnterior.Visible = False
            Me.txtAcumComKilos.Visible = False
            Me.txtAcumComKilosAnterior.Visible = False
        End If
    End Sub

    'Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
    '    If e.KeyChar = Chr(13) Then
    '        Me.SelectNextControl(sender, True, True, False, True)
    '        Me.TxtRFC.Focus()
    '    End If
    'End Sub

    Private Sub TxtRazonSocial_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtRazonSocial.TextChanged
        TxtBeneficiario.Text = TxtRazonSocial.Text
    End Sub

    Private Sub rbtPerFisica_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtPerFisica.CheckedChanged
        If rbtPerFisica.Checked Then
            Dim rfc As String
            If mtbRFC.Text.Length > 3 Then
                rfc = mtbRFC.Text.Substring(0, 3) + "X" + mtbRFC.Text.Substring(3)
            Else
                rfc = mtbRFC.Text
            End If
            mtbRFC.Text = ""
            mtbRFC.Mask = ">LLLL-000000-AAA"
            mtbRFC.Text = rfc
        End If
    End Sub

    Private Sub rbtPerMoral_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtPerMoral.CheckedChanged
        If rbtPerMoral.Checked Then
            Dim rfc As String
            If mtbRFC.Text.Length > 3 Then
                rfc = mtbRFC.Text.Substring(0, 3) + mtbRFC.Text.Substring(4)
            Else
                rfc = mtbRFC.Text
            End If
            mtbRFC.Text = ""
            mtbRFC.Mask = ">LLL-000000-AAA"
            mtbRFC.Text = rfc
        End If
    End Sub
End Class