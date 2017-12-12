<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaSaldo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCuenta = New IntegraLab.Controles.TextBoxMejorado
        Me.txtSubCuenta = New IntegraLab.Controles.TextBoxMejorado
        Me.txtSSubCuenta = New IntegraLab.Controles.TextBoxMejorado
        Me.txtSSSubCuenta = New IntegraLab.Controles.TextBoxMejorado
        Me.txtNombreCuentaContable = New IntegraLab.Controles.TextBoxMejorado
        Me.CuentaContableC = New ClasesNegocio.CuentaContableCollectionClass
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtSaldoInicial = New IntegraLab.Controles.TextBoxMejorado
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtEneroSaldo = New IntegraLab.Controles.TextBoxMejorado
        Me.txtFebreroSaldo = New IntegraLab.Controles.TextBoxMejorado
        Me.txtMarzoSaldo = New IntegraLab.Controles.TextBoxMejorado
        Me.txtAbrilSaldo = New IntegraLab.Controles.TextBoxMejorado
        Me.txtMayoSaldo = New IntegraLab.Controles.TextBoxMejorado
        Me.txtJunioSaldo = New IntegraLab.Controles.TextBoxMejorado
        Me.txtJulioSaldo = New IntegraLab.Controles.TextBoxMejorado
        Me.txtAgostoSaldo = New IntegraLab.Controles.TextBoxMejorado
        Me.txtSeptiembreSaldo = New IntegraLab.Controles.TextBoxMejorado
        Me.txtOctubreSaldo = New IntegraLab.Controles.TextBoxMejorado
        Me.txtNoviembreSaldo = New IntegraLab.Controles.TextBoxMejorado
        Me.txtDiciembreSaldo = New IntegraLab.Controles.TextBoxMejorado
        Me.txtTotalSaldo = New IntegraLab.Controles.TextBoxMejorado
        Me.txtTotalAbono = New IntegraLab.Controles.TextBoxMejorado
        Me.txtDiciembreAbono = New IntegraLab.Controles.TextBoxMejorado
        Me.txtNoviembreAbono = New IntegraLab.Controles.TextBoxMejorado
        Me.txtOctubreAbono = New IntegraLab.Controles.TextBoxMejorado
        Me.txtSeptiembreAbono = New IntegraLab.Controles.TextBoxMejorado
        Me.txtAgostoAbono = New IntegraLab.Controles.TextBoxMejorado
        Me.txtJulioAbono = New IntegraLab.Controles.TextBoxMejorado
        Me.txtJunioAbono = New IntegraLab.Controles.TextBoxMejorado
        Me.txtMayoAbono = New IntegraLab.Controles.TextBoxMejorado
        Me.txtAbrilAbono = New IntegraLab.Controles.TextBoxMejorado
        Me.txtMarzoAbono = New IntegraLab.Controles.TextBoxMejorado
        Me.txtFebreroAbono = New IntegraLab.Controles.TextBoxMejorado
        Me.txtEneroAbono = New IntegraLab.Controles.TextBoxMejorado
        Me.txtTotalCargo = New IntegraLab.Controles.TextBoxMejorado
        Me.txtDiciembreCargo = New IntegraLab.Controles.TextBoxMejorado
        Me.txtNoviembreCargo = New IntegraLab.Controles.TextBoxMejorado
        Me.txtOctubreCargo = New IntegraLab.Controles.TextBoxMejorado
        Me.txtSeptiembreCargo = New IntegraLab.Controles.TextBoxMejorado
        Me.txtAgostoCargo = New IntegraLab.Controles.TextBoxMejorado
        Me.txtJulioCargo = New IntegraLab.Controles.TextBoxMejorado
        Me.txtJunioCargo = New IntegraLab.Controles.TextBoxMejorado
        Me.txtMayoCargo = New IntegraLab.Controles.TextBoxMejorado
        Me.txtAbrirCargo = New IntegraLab.Controles.TextBoxMejorado
        Me.txtMarzoCargo = New IntegraLab.Controles.TextBoxMejorado
        Me.txtFebreroCargo = New IntegraLab.Controles.TextBoxMejorado
        Me.txtEneroCargo = New IntegraLab.Controles.TextBoxMejorado
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(50, 0)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(624, 29)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "CONSULTA DE SALDOS CONTABILIDAD GENERAL"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mtb
        '
        Me.mtb.ButtonSize = New System.Drawing.Size(50, 50)
        Me.mtb.Dock = System.Windows.Forms.DockStyle.Left
        Me.mtb.DropDownArrows = True
        Me.mtb.HabilitarBorrar = True
        Me.mtb.HabilitarBuscar = True
        Me.mtb.HabilitarCancelar = True
        Me.mtb.HabilitarEditar = True
        Me.mtb.HabilitarGuardar = True
        Me.mtb.HabilitarImprimir = True
        Me.mtb.HabilitarLimpiar = True
        Me.mtb.HabilitarNuevo = True
        Me.mtb.HabilitarSalir = True
        Me.mtb.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32
        Me.mtb.Location = New System.Drawing.Point(0, 0)
        Me.mtb.MostrarBorrar = False
        Me.mtb.MostrarBuscar = True
        Me.mtb.MostrarCancelar = False
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = False
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 512)
        Me.mtb.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cuenta Contable:"
        '
        'txtCuenta
        '
        Me.txtCuenta.ComboBoxEnlazado = Nothing
        Me.txtCuenta.Decimales = 0
        Me.txtCuenta.Location = New System.Drawing.Point(151, 39)
        Me.txtCuenta.MaxLength = 3000
        Me.txtCuenta.MensajeCombo = "Seleccionar un item..."
        Me.txtCuenta.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.SiguienteControl = Me.txtSubCuenta
        Me.txtCuenta.Size = New System.Drawing.Size(47, 20)
        Me.txtCuenta.TabIndex = 3
        Me.txtCuenta.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        '
        'txtSubCuenta
        '
        Me.txtSubCuenta.ComboBoxEnlazado = Nothing
        Me.txtSubCuenta.Decimales = 0
        Me.txtSubCuenta.Location = New System.Drawing.Point(204, 39)
        Me.txtSubCuenta.MaxLength = 3000
        Me.txtSubCuenta.MensajeCombo = "Seleccionar un item..."
        Me.txtSubCuenta.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtSubCuenta.Name = "txtSubCuenta"
        Me.txtSubCuenta.SiguienteControl = Me.txtSSubCuenta
        Me.txtSubCuenta.Size = New System.Drawing.Size(47, 20)
        Me.txtSubCuenta.TabIndex = 4
        Me.txtSubCuenta.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        '
        'txtSSubCuenta
        '
        Me.txtSSubCuenta.ComboBoxEnlazado = Nothing
        Me.txtSSubCuenta.Decimales = 0
        Me.txtSSubCuenta.Location = New System.Drawing.Point(257, 39)
        Me.txtSSubCuenta.MaxLength = 3000
        Me.txtSSubCuenta.MensajeCombo = "Seleccionar un item..."
        Me.txtSSubCuenta.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtSSubCuenta.Name = "txtSSubCuenta"
        Me.txtSSubCuenta.SiguienteControl = Me.txtSSSubCuenta
        Me.txtSSubCuenta.Size = New System.Drawing.Size(47, 20)
        Me.txtSSubCuenta.TabIndex = 5
        Me.txtSSubCuenta.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        '
        'txtSSSubCuenta
        '
        Me.txtSSSubCuenta.ComboBoxEnlazado = Nothing
        Me.txtSSSubCuenta.Decimales = 0
        Me.txtSSSubCuenta.Location = New System.Drawing.Point(310, 39)
        Me.txtSSSubCuenta.MaxLength = 3000
        Me.txtSSSubCuenta.MensajeCombo = "Seleccionar un item..."
        Me.txtSSSubCuenta.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtSSSubCuenta.Name = "txtSSSubCuenta"
        Me.txtSSSubCuenta.SiguienteControl = Me.txtCuenta
        Me.txtSSSubCuenta.Size = New System.Drawing.Size(47, 20)
        Me.txtSSSubCuenta.TabIndex = 6
        Me.txtSSSubCuenta.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        '
        'txtNombreCuentaContable
        '
        Me.txtNombreCuentaContable.ComboBoxEnlazado = Nothing
        Me.txtNombreCuentaContable.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "NombreCuenta", True))
        Me.txtNombreCuentaContable.Decimales = 0
        Me.txtNombreCuentaContable.Location = New System.Drawing.Point(151, 65)
        Me.txtNombreCuentaContable.MensajeCombo = "Seleccionar un item..."
        Me.txtNombreCuentaContable.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtNombreCuentaContable.Name = "txtNombreCuentaContable"
        Me.txtNombreCuentaContable.ReadOnly = True
        Me.txtNombreCuentaContable.SiguienteControl = Nothing
        Me.txtNombreCuentaContable.Size = New System.Drawing.Size(390, 20)
        Me.txtNombreCuentaContable.TabIndex = 7
        Me.txtNombreCuentaContable.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'CuentaContableC
        '
        Me.CuentaContableC.AllowEdit = True
        Me.CuentaContableC.AllowNew = True
        Me.CuentaContableC.AllowRemove = True
        Me.CuentaContableC.Name = Nothing
        Me.CuentaContableC.RaiseListChangedEvents = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "PERIODO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(186, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "CARGOS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(321, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "ABONOS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(452, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "SALDOS"
        '
        'txtSaldoInicial
        '
        Me.txtSaldoInicial.ComboBoxEnlazado = Nothing
        Me.txtSaldoInicial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "SaldoAñoAnterior", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtSaldoInicial.Decimales = 0
        Me.txtSaldoInicial.Location = New System.Drawing.Point(415, 123)
        Me.txtSaldoInicial.MaxLength = 3000
        Me.txtSaldoInicial.MensajeCombo = "Seleccionar un item..."
        Me.txtSaldoInicial.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtSaldoInicial.Name = "txtSaldoInicial"
        Me.txtSaldoInicial.ReadOnly = True
        Me.txtSaldoInicial.SiguienteControl = Nothing
        Me.txtSaldoInicial.Size = New System.Drawing.Size(126, 20)
        Me.txtSaldoInicial.TabIndex = 13
        Me.txtSaldoInicial.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(289, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Saldo Inicio de Ejercicio"
        '
        'txtEneroSaldo
        '
        Me.txtEneroSaldo.ComboBoxEnlazado = Nothing
        Me.txtEneroSaldo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "EneroSaldo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtEneroSaldo.Decimales = 0
        Me.txtEneroSaldo.Location = New System.Drawing.Point(415, 149)
        Me.txtEneroSaldo.MaxLength = 3000
        Me.txtEneroSaldo.MensajeCombo = "Seleccionar un item..."
        Me.txtEneroSaldo.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtEneroSaldo.Name = "txtEneroSaldo"
        Me.txtEneroSaldo.ReadOnly = True
        Me.txtEneroSaldo.SiguienteControl = Nothing
        Me.txtEneroSaldo.Size = New System.Drawing.Size(126, 20)
        Me.txtEneroSaldo.TabIndex = 17
        Me.txtEneroSaldo.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'txtFebreroSaldo
        '
        Me.txtFebreroSaldo.ComboBoxEnlazado = Nothing
        Me.txtFebreroSaldo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "FebreroSaldo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtFebreroSaldo.Decimales = 0
        Me.txtFebreroSaldo.Location = New System.Drawing.Point(415, 175)
        Me.txtFebreroSaldo.MaxLength = 3000
        Me.txtFebreroSaldo.MensajeCombo = "Seleccionar un item..."
        Me.txtFebreroSaldo.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtFebreroSaldo.Name = "txtFebreroSaldo"
        Me.txtFebreroSaldo.ReadOnly = True
        Me.txtFebreroSaldo.SiguienteControl = Nothing
        Me.txtFebreroSaldo.Size = New System.Drawing.Size(126, 20)
        Me.txtFebreroSaldo.TabIndex = 21
        Me.txtFebreroSaldo.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'txtMarzoSaldo
        '
        Me.txtMarzoSaldo.ComboBoxEnlazado = Nothing
        Me.txtMarzoSaldo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "MarzoSaldo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtMarzoSaldo.Decimales = 0
        Me.txtMarzoSaldo.Location = New System.Drawing.Point(415, 201)
        Me.txtMarzoSaldo.MaxLength = 3000
        Me.txtMarzoSaldo.MensajeCombo = "Seleccionar un item..."
        Me.txtMarzoSaldo.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtMarzoSaldo.Name = "txtMarzoSaldo"
        Me.txtMarzoSaldo.ReadOnly = True
        Me.txtMarzoSaldo.SiguienteControl = Nothing
        Me.txtMarzoSaldo.Size = New System.Drawing.Size(126, 20)
        Me.txtMarzoSaldo.TabIndex = 25
        Me.txtMarzoSaldo.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'txtAbrilSaldo
        '
        Me.txtAbrilSaldo.ComboBoxEnlazado = Nothing
        Me.txtAbrilSaldo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "AbrilSaldo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtAbrilSaldo.Decimales = 0
        Me.txtAbrilSaldo.Location = New System.Drawing.Point(415, 227)
        Me.txtAbrilSaldo.MaxLength = 3000
        Me.txtAbrilSaldo.MensajeCombo = "Seleccionar un item..."
        Me.txtAbrilSaldo.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtAbrilSaldo.Name = "txtAbrilSaldo"
        Me.txtAbrilSaldo.ReadOnly = True
        Me.txtAbrilSaldo.SiguienteControl = Nothing
        Me.txtAbrilSaldo.Size = New System.Drawing.Size(126, 20)
        Me.txtAbrilSaldo.TabIndex = 29
        Me.txtAbrilSaldo.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'txtMayoSaldo
        '
        Me.txtMayoSaldo.ComboBoxEnlazado = Nothing
        Me.txtMayoSaldo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "MayoSaldo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtMayoSaldo.Decimales = 0
        Me.txtMayoSaldo.Location = New System.Drawing.Point(415, 253)
        Me.txtMayoSaldo.MaxLength = 3000
        Me.txtMayoSaldo.MensajeCombo = "Seleccionar un item..."
        Me.txtMayoSaldo.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtMayoSaldo.Name = "txtMayoSaldo"
        Me.txtMayoSaldo.ReadOnly = True
        Me.txtMayoSaldo.SiguienteControl = Nothing
        Me.txtMayoSaldo.Size = New System.Drawing.Size(126, 20)
        Me.txtMayoSaldo.TabIndex = 33
        Me.txtMayoSaldo.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'txtJunioSaldo
        '
        Me.txtJunioSaldo.ComboBoxEnlazado = Nothing
        Me.txtJunioSaldo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "JunioSaldo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtJunioSaldo.Decimales = 0
        Me.txtJunioSaldo.Location = New System.Drawing.Point(415, 279)
        Me.txtJunioSaldo.MaxLength = 3000
        Me.txtJunioSaldo.MensajeCombo = "Seleccionar un item..."
        Me.txtJunioSaldo.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtJunioSaldo.Name = "txtJunioSaldo"
        Me.txtJunioSaldo.ReadOnly = True
        Me.txtJunioSaldo.SiguienteControl = Nothing
        Me.txtJunioSaldo.Size = New System.Drawing.Size(126, 20)
        Me.txtJunioSaldo.TabIndex = 37
        Me.txtJunioSaldo.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'txtJulioSaldo
        '
        Me.txtJulioSaldo.ComboBoxEnlazado = Nothing
        Me.txtJulioSaldo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "JulioSaldo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtJulioSaldo.Decimales = 0
        Me.txtJulioSaldo.Location = New System.Drawing.Point(415, 305)
        Me.txtJulioSaldo.MaxLength = 3000
        Me.txtJulioSaldo.MensajeCombo = "Seleccionar un item..."
        Me.txtJulioSaldo.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtJulioSaldo.Name = "txtJulioSaldo"
        Me.txtJulioSaldo.ReadOnly = True
        Me.txtJulioSaldo.SiguienteControl = Nothing
        Me.txtJulioSaldo.Size = New System.Drawing.Size(126, 20)
        Me.txtJulioSaldo.TabIndex = 41
        Me.txtJulioSaldo.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'txtAgostoSaldo
        '
        Me.txtAgostoSaldo.ComboBoxEnlazado = Nothing
        Me.txtAgostoSaldo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "AgostoSaldo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtAgostoSaldo.Decimales = 0
        Me.txtAgostoSaldo.Location = New System.Drawing.Point(415, 331)
        Me.txtAgostoSaldo.MaxLength = 3000
        Me.txtAgostoSaldo.MensajeCombo = "Seleccionar un item..."
        Me.txtAgostoSaldo.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtAgostoSaldo.Name = "txtAgostoSaldo"
        Me.txtAgostoSaldo.ReadOnly = True
        Me.txtAgostoSaldo.SiguienteControl = Nothing
        Me.txtAgostoSaldo.Size = New System.Drawing.Size(126, 20)
        Me.txtAgostoSaldo.TabIndex = 45
        Me.txtAgostoSaldo.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'txtSeptiembreSaldo
        '
        Me.txtSeptiembreSaldo.ComboBoxEnlazado = Nothing
        Me.txtSeptiembreSaldo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "SeptiembreSaldo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtSeptiembreSaldo.Decimales = 0
        Me.txtSeptiembreSaldo.Location = New System.Drawing.Point(415, 357)
        Me.txtSeptiembreSaldo.MaxLength = 3000
        Me.txtSeptiembreSaldo.MensajeCombo = "Seleccionar un item..."
        Me.txtSeptiembreSaldo.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtSeptiembreSaldo.Name = "txtSeptiembreSaldo"
        Me.txtSeptiembreSaldo.ReadOnly = True
        Me.txtSeptiembreSaldo.SiguienteControl = Nothing
        Me.txtSeptiembreSaldo.Size = New System.Drawing.Size(126, 20)
        Me.txtSeptiembreSaldo.TabIndex = 49
        Me.txtSeptiembreSaldo.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'txtOctubreSaldo
        '
        Me.txtOctubreSaldo.ComboBoxEnlazado = Nothing
        Me.txtOctubreSaldo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "OctubreSaldo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtOctubreSaldo.Decimales = 0
        Me.txtOctubreSaldo.Location = New System.Drawing.Point(415, 383)
        Me.txtOctubreSaldo.MaxLength = 3000
        Me.txtOctubreSaldo.MensajeCombo = "Seleccionar un item..."
        Me.txtOctubreSaldo.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtOctubreSaldo.Name = "txtOctubreSaldo"
        Me.txtOctubreSaldo.ReadOnly = True
        Me.txtOctubreSaldo.SiguienteControl = Nothing
        Me.txtOctubreSaldo.Size = New System.Drawing.Size(126, 20)
        Me.txtOctubreSaldo.TabIndex = 53
        Me.txtOctubreSaldo.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'txtNoviembreSaldo
        '
        Me.txtNoviembreSaldo.ComboBoxEnlazado = Nothing
        Me.txtNoviembreSaldo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "NoviembreSaldo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtNoviembreSaldo.Decimales = 0
        Me.txtNoviembreSaldo.Location = New System.Drawing.Point(415, 409)
        Me.txtNoviembreSaldo.MaxLength = 3000
        Me.txtNoviembreSaldo.MensajeCombo = "Seleccionar un item..."
        Me.txtNoviembreSaldo.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtNoviembreSaldo.Name = "txtNoviembreSaldo"
        Me.txtNoviembreSaldo.ReadOnly = True
        Me.txtNoviembreSaldo.SiguienteControl = Nothing
        Me.txtNoviembreSaldo.Size = New System.Drawing.Size(126, 20)
        Me.txtNoviembreSaldo.TabIndex = 57
        Me.txtNoviembreSaldo.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'txtDiciembreSaldo
        '
        Me.txtDiciembreSaldo.ComboBoxEnlazado = Nothing
        Me.txtDiciembreSaldo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "DiciembreSaldo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtDiciembreSaldo.Decimales = 0
        Me.txtDiciembreSaldo.Location = New System.Drawing.Point(415, 435)
        Me.txtDiciembreSaldo.MaxLength = 3000
        Me.txtDiciembreSaldo.MensajeCombo = "Seleccionar un item..."
        Me.txtDiciembreSaldo.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtDiciembreSaldo.Name = "txtDiciembreSaldo"
        Me.txtDiciembreSaldo.ReadOnly = True
        Me.txtDiciembreSaldo.SiguienteControl = Nothing
        Me.txtDiciembreSaldo.Size = New System.Drawing.Size(126, 20)
        Me.txtDiciembreSaldo.TabIndex = 61
        Me.txtDiciembreSaldo.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'txtTotalSaldo
        '
        Me.txtTotalSaldo.ComboBoxEnlazado = Nothing
        Me.txtTotalSaldo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "TotalSaldo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtTotalSaldo.Decimales = 0
        Me.txtTotalSaldo.Location = New System.Drawing.Point(415, 461)
        Me.txtTotalSaldo.MaxLength = 3000
        Me.txtTotalSaldo.MensajeCombo = "Seleccionar un item..."
        Me.txtTotalSaldo.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtTotalSaldo.Name = "txtTotalSaldo"
        Me.txtTotalSaldo.ReadOnly = True
        Me.txtTotalSaldo.SiguienteControl = Nothing
        Me.txtTotalSaldo.Size = New System.Drawing.Size(126, 20)
        Me.txtTotalSaldo.TabIndex = 65
        Me.txtTotalSaldo.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'txtTotalAbono
        '
        Me.txtTotalAbono.ComboBoxEnlazado = Nothing
        Me.txtTotalAbono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "TotalAbono", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtTotalAbono.Decimales = 0
        Me.txtTotalAbono.Location = New System.Drawing.Point(283, 461)
        Me.txtTotalAbono.MaxLength = 3000
        Me.txtTotalAbono.MensajeCombo = "Seleccionar un item..."
        Me.txtTotalAbono.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtTotalAbono.Name = "txtTotalAbono"
        Me.txtTotalAbono.ReadOnly = True
        Me.txtTotalAbono.SiguienteControl = Nothing
        Me.txtTotalAbono.Size = New System.Drawing.Size(126, 20)
        Me.txtTotalAbono.TabIndex = 64
        Me.txtTotalAbono.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'txtDiciembreAbono
        '
        Me.txtDiciembreAbono.ComboBoxEnlazado = Nothing
        Me.txtDiciembreAbono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "DiciembreAbono", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtDiciembreAbono.Decimales = 0
        Me.txtDiciembreAbono.Location = New System.Drawing.Point(283, 435)
        Me.txtDiciembreAbono.MaxLength = 3000
        Me.txtDiciembreAbono.MensajeCombo = "Seleccionar un item..."
        Me.txtDiciembreAbono.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtDiciembreAbono.Name = "txtDiciembreAbono"
        Me.txtDiciembreAbono.ReadOnly = True
        Me.txtDiciembreAbono.SiguienteControl = Nothing
        Me.txtDiciembreAbono.Size = New System.Drawing.Size(126, 20)
        Me.txtDiciembreAbono.TabIndex = 60
        Me.txtDiciembreAbono.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'txtNoviembreAbono
        '
        Me.txtNoviembreAbono.ComboBoxEnlazado = Nothing
        Me.txtNoviembreAbono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "NoviembreAbono", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtNoviembreAbono.Decimales = 0
        Me.txtNoviembreAbono.Location = New System.Drawing.Point(283, 409)
        Me.txtNoviembreAbono.MaxLength = 3000
        Me.txtNoviembreAbono.MensajeCombo = "Seleccionar un item..."
        Me.txtNoviembreAbono.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtNoviembreAbono.Name = "txtNoviembreAbono"
        Me.txtNoviembreAbono.ReadOnly = True
        Me.txtNoviembreAbono.SiguienteControl = Nothing
        Me.txtNoviembreAbono.Size = New System.Drawing.Size(126, 20)
        Me.txtNoviembreAbono.TabIndex = 56
        Me.txtNoviembreAbono.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'txtOctubreAbono
        '
        Me.txtOctubreAbono.ComboBoxEnlazado = Nothing
        Me.txtOctubreAbono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "OctubreAbono", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtOctubreAbono.Decimales = 0
        Me.txtOctubreAbono.Location = New System.Drawing.Point(283, 383)
        Me.txtOctubreAbono.MaxLength = 3000
        Me.txtOctubreAbono.MensajeCombo = "Seleccionar un item..."
        Me.txtOctubreAbono.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtOctubreAbono.Name = "txtOctubreAbono"
        Me.txtOctubreAbono.ReadOnly = True
        Me.txtOctubreAbono.SiguienteControl = Nothing
        Me.txtOctubreAbono.Size = New System.Drawing.Size(126, 20)
        Me.txtOctubreAbono.TabIndex = 52
        Me.txtOctubreAbono.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'txtSeptiembreAbono
        '
        Me.txtSeptiembreAbono.ComboBoxEnlazado = Nothing
        Me.txtSeptiembreAbono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "SeptiembreAbono", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtSeptiembreAbono.Decimales = 0
        Me.txtSeptiembreAbono.Location = New System.Drawing.Point(283, 357)
        Me.txtSeptiembreAbono.MaxLength = 3000
        Me.txtSeptiembreAbono.MensajeCombo = "Seleccionar un item..."
        Me.txtSeptiembreAbono.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtSeptiembreAbono.Name = "txtSeptiembreAbono"
        Me.txtSeptiembreAbono.ReadOnly = True
        Me.txtSeptiembreAbono.SiguienteControl = Nothing
        Me.txtSeptiembreAbono.Size = New System.Drawing.Size(126, 20)
        Me.txtSeptiembreAbono.TabIndex = 48
        Me.txtSeptiembreAbono.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'txtAgostoAbono
        '
        Me.txtAgostoAbono.ComboBoxEnlazado = Nothing
        Me.txtAgostoAbono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "AgostoAbono", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtAgostoAbono.Decimales = 0
        Me.txtAgostoAbono.Location = New System.Drawing.Point(283, 331)
        Me.txtAgostoAbono.MaxLength = 3000
        Me.txtAgostoAbono.MensajeCombo = "Seleccionar un item..."
        Me.txtAgostoAbono.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtAgostoAbono.Name = "txtAgostoAbono"
        Me.txtAgostoAbono.ReadOnly = True
        Me.txtAgostoAbono.SiguienteControl = Nothing
        Me.txtAgostoAbono.Size = New System.Drawing.Size(126, 20)
        Me.txtAgostoAbono.TabIndex = 44
        Me.txtAgostoAbono.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'txtJulioAbono
        '
        Me.txtJulioAbono.ComboBoxEnlazado = Nothing
        Me.txtJulioAbono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "JulioAbono", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtJulioAbono.Decimales = 0
        Me.txtJulioAbono.Location = New System.Drawing.Point(283, 305)
        Me.txtJulioAbono.MaxLength = 3000
        Me.txtJulioAbono.MensajeCombo = "Seleccionar un item..."
        Me.txtJulioAbono.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtJulioAbono.Name = "txtJulioAbono"
        Me.txtJulioAbono.ReadOnly = True
        Me.txtJulioAbono.SiguienteControl = Nothing
        Me.txtJulioAbono.Size = New System.Drawing.Size(126, 20)
        Me.txtJulioAbono.TabIndex = 40
        Me.txtJulioAbono.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'txtJunioAbono
        '
        Me.txtJunioAbono.ComboBoxEnlazado = Nothing
        Me.txtJunioAbono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "JunioAbono", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtJunioAbono.Decimales = 0
        Me.txtJunioAbono.Location = New System.Drawing.Point(283, 279)
        Me.txtJunioAbono.MaxLength = 3000
        Me.txtJunioAbono.MensajeCombo = "Seleccionar un item..."
        Me.txtJunioAbono.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtJunioAbono.Name = "txtJunioAbono"
        Me.txtJunioAbono.ReadOnly = True
        Me.txtJunioAbono.SiguienteControl = Nothing
        Me.txtJunioAbono.Size = New System.Drawing.Size(126, 20)
        Me.txtJunioAbono.TabIndex = 36
        Me.txtJunioAbono.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'txtMayoAbono
        '
        Me.txtMayoAbono.ComboBoxEnlazado = Nothing
        Me.txtMayoAbono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "MayoCargo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtMayoAbono.Decimales = 0
        Me.txtMayoAbono.Location = New System.Drawing.Point(283, 253)
        Me.txtMayoAbono.MaxLength = 3000
        Me.txtMayoAbono.MensajeCombo = "Seleccionar un item..."
        Me.txtMayoAbono.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtMayoAbono.Name = "txtMayoAbono"
        Me.txtMayoAbono.ReadOnly = True
        Me.txtMayoAbono.SiguienteControl = Nothing
        Me.txtMayoAbono.Size = New System.Drawing.Size(126, 20)
        Me.txtMayoAbono.TabIndex = 32
        Me.txtMayoAbono.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'txtAbrilAbono
        '
        Me.txtAbrilAbono.ComboBoxEnlazado = Nothing
        Me.txtAbrilAbono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "AbrilAbono", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtAbrilAbono.Decimales = 0
        Me.txtAbrilAbono.Location = New System.Drawing.Point(283, 227)
        Me.txtAbrilAbono.MaxLength = 3000
        Me.txtAbrilAbono.MensajeCombo = "Seleccionar un item..."
        Me.txtAbrilAbono.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtAbrilAbono.Name = "txtAbrilAbono"
        Me.txtAbrilAbono.ReadOnly = True
        Me.txtAbrilAbono.SiguienteControl = Nothing
        Me.txtAbrilAbono.Size = New System.Drawing.Size(126, 20)
        Me.txtAbrilAbono.TabIndex = 28
        Me.txtAbrilAbono.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'txtMarzoAbono
        '
        Me.txtMarzoAbono.ComboBoxEnlazado = Nothing
        Me.txtMarzoAbono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "MarzoAbono", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtMarzoAbono.Decimales = 0
        Me.txtMarzoAbono.Location = New System.Drawing.Point(283, 201)
        Me.txtMarzoAbono.MaxLength = 3000
        Me.txtMarzoAbono.MensajeCombo = "Seleccionar un item..."
        Me.txtMarzoAbono.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtMarzoAbono.Name = "txtMarzoAbono"
        Me.txtMarzoAbono.ReadOnly = True
        Me.txtMarzoAbono.SiguienteControl = Nothing
        Me.txtMarzoAbono.Size = New System.Drawing.Size(126, 20)
        Me.txtMarzoAbono.TabIndex = 24
        Me.txtMarzoAbono.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'txtFebreroAbono
        '
        Me.txtFebreroAbono.ComboBoxEnlazado = Nothing
        Me.txtFebreroAbono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "FebreroAbono", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtFebreroAbono.Decimales = 0
        Me.txtFebreroAbono.Location = New System.Drawing.Point(283, 175)
        Me.txtFebreroAbono.MaxLength = 3000
        Me.txtFebreroAbono.MensajeCombo = "Seleccionar un item..."
        Me.txtFebreroAbono.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtFebreroAbono.Name = "txtFebreroAbono"
        Me.txtFebreroAbono.ReadOnly = True
        Me.txtFebreroAbono.SiguienteControl = Nothing
        Me.txtFebreroAbono.Size = New System.Drawing.Size(126, 20)
        Me.txtFebreroAbono.TabIndex = 20
        Me.txtFebreroAbono.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'txtEneroAbono
        '
        Me.txtEneroAbono.ComboBoxEnlazado = Nothing
        Me.txtEneroAbono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "EneroAbono", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtEneroAbono.Decimales = 0
        Me.txtEneroAbono.Location = New System.Drawing.Point(283, 149)
        Me.txtEneroAbono.MaxLength = 3000
        Me.txtEneroAbono.MensajeCombo = "Seleccionar un item..."
        Me.txtEneroAbono.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtEneroAbono.Name = "txtEneroAbono"
        Me.txtEneroAbono.ReadOnly = True
        Me.txtEneroAbono.SiguienteControl = Nothing
        Me.txtEneroAbono.Size = New System.Drawing.Size(126, 20)
        Me.txtEneroAbono.TabIndex = 16
        Me.txtEneroAbono.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'txtTotalCargo
        '
        Me.txtTotalCargo.ComboBoxEnlazado = Nothing
        Me.txtTotalCargo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "TotalCargo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtTotalCargo.Decimales = 0
        Me.txtTotalCargo.Location = New System.Drawing.Point(151, 461)
        Me.txtTotalCargo.MaxLength = 3000
        Me.txtTotalCargo.MensajeCombo = "Seleccionar un item..."
        Me.txtTotalCargo.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtTotalCargo.Name = "txtTotalCargo"
        Me.txtTotalCargo.ReadOnly = True
        Me.txtTotalCargo.SiguienteControl = Nothing
        Me.txtTotalCargo.Size = New System.Drawing.Size(126, 20)
        Me.txtTotalCargo.TabIndex = 63
        Me.txtTotalCargo.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'txtDiciembreCargo
        '
        Me.txtDiciembreCargo.ComboBoxEnlazado = Nothing
        Me.txtDiciembreCargo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "DiciembreCargo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtDiciembreCargo.Decimales = 0
        Me.txtDiciembreCargo.Location = New System.Drawing.Point(151, 435)
        Me.txtDiciembreCargo.MaxLength = 3000
        Me.txtDiciembreCargo.MensajeCombo = "Seleccionar un item..."
        Me.txtDiciembreCargo.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtDiciembreCargo.Name = "txtDiciembreCargo"
        Me.txtDiciembreCargo.ReadOnly = True
        Me.txtDiciembreCargo.SiguienteControl = Nothing
        Me.txtDiciembreCargo.Size = New System.Drawing.Size(126, 20)
        Me.txtDiciembreCargo.TabIndex = 59
        Me.txtDiciembreCargo.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'txtNoviembreCargo
        '
        Me.txtNoviembreCargo.ComboBoxEnlazado = Nothing
        Me.txtNoviembreCargo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "NoviembreCargo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtNoviembreCargo.Decimales = 0
        Me.txtNoviembreCargo.Location = New System.Drawing.Point(151, 409)
        Me.txtNoviembreCargo.MaxLength = 3000
        Me.txtNoviembreCargo.MensajeCombo = "Seleccionar un item..."
        Me.txtNoviembreCargo.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtNoviembreCargo.Name = "txtNoviembreCargo"
        Me.txtNoviembreCargo.ReadOnly = True
        Me.txtNoviembreCargo.SiguienteControl = Nothing
        Me.txtNoviembreCargo.Size = New System.Drawing.Size(126, 20)
        Me.txtNoviembreCargo.TabIndex = 55
        Me.txtNoviembreCargo.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'txtOctubreCargo
        '
        Me.txtOctubreCargo.ComboBoxEnlazado = Nothing
        Me.txtOctubreCargo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "OctubreCargo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtOctubreCargo.Decimales = 0
        Me.txtOctubreCargo.Location = New System.Drawing.Point(151, 383)
        Me.txtOctubreCargo.MaxLength = 3000
        Me.txtOctubreCargo.MensajeCombo = "Seleccionar un item..."
        Me.txtOctubreCargo.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtOctubreCargo.Name = "txtOctubreCargo"
        Me.txtOctubreCargo.ReadOnly = True
        Me.txtOctubreCargo.SiguienteControl = Nothing
        Me.txtOctubreCargo.Size = New System.Drawing.Size(126, 20)
        Me.txtOctubreCargo.TabIndex = 51
        Me.txtOctubreCargo.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'txtSeptiembreCargo
        '
        Me.txtSeptiembreCargo.ComboBoxEnlazado = Nothing
        Me.txtSeptiembreCargo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "SeptiembreCargo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtSeptiembreCargo.Decimales = 0
        Me.txtSeptiembreCargo.Location = New System.Drawing.Point(151, 357)
        Me.txtSeptiembreCargo.MaxLength = 3000
        Me.txtSeptiembreCargo.MensajeCombo = "Seleccionar un item..."
        Me.txtSeptiembreCargo.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtSeptiembreCargo.Name = "txtSeptiembreCargo"
        Me.txtSeptiembreCargo.ReadOnly = True
        Me.txtSeptiembreCargo.SiguienteControl = Nothing
        Me.txtSeptiembreCargo.Size = New System.Drawing.Size(126, 20)
        Me.txtSeptiembreCargo.TabIndex = 47
        Me.txtSeptiembreCargo.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'txtAgostoCargo
        '
        Me.txtAgostoCargo.ComboBoxEnlazado = Nothing
        Me.txtAgostoCargo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "AgostoCargo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtAgostoCargo.Decimales = 0
        Me.txtAgostoCargo.Location = New System.Drawing.Point(151, 331)
        Me.txtAgostoCargo.MaxLength = 3000
        Me.txtAgostoCargo.MensajeCombo = "Seleccionar un item..."
        Me.txtAgostoCargo.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtAgostoCargo.Name = "txtAgostoCargo"
        Me.txtAgostoCargo.ReadOnly = True
        Me.txtAgostoCargo.SiguienteControl = Nothing
        Me.txtAgostoCargo.Size = New System.Drawing.Size(126, 20)
        Me.txtAgostoCargo.TabIndex = 43
        Me.txtAgostoCargo.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'txtJulioCargo
        '
        Me.txtJulioCargo.ComboBoxEnlazado = Nothing
        Me.txtJulioCargo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "JulioCargo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtJulioCargo.Decimales = 0
        Me.txtJulioCargo.Location = New System.Drawing.Point(151, 305)
        Me.txtJulioCargo.MaxLength = 3000
        Me.txtJulioCargo.MensajeCombo = "Seleccionar un item..."
        Me.txtJulioCargo.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtJulioCargo.Name = "txtJulioCargo"
        Me.txtJulioCargo.ReadOnly = True
        Me.txtJulioCargo.SiguienteControl = Nothing
        Me.txtJulioCargo.Size = New System.Drawing.Size(126, 20)
        Me.txtJulioCargo.TabIndex = 39
        Me.txtJulioCargo.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'txtJunioCargo
        '
        Me.txtJunioCargo.ComboBoxEnlazado = Nothing
        Me.txtJunioCargo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "JunioCargo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtJunioCargo.Decimales = 0
        Me.txtJunioCargo.Location = New System.Drawing.Point(151, 279)
        Me.txtJunioCargo.MaxLength = 3000
        Me.txtJunioCargo.MensajeCombo = "Seleccionar un item..."
        Me.txtJunioCargo.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtJunioCargo.Name = "txtJunioCargo"
        Me.txtJunioCargo.ReadOnly = True
        Me.txtJunioCargo.SiguienteControl = Nothing
        Me.txtJunioCargo.Size = New System.Drawing.Size(126, 20)
        Me.txtJunioCargo.TabIndex = 35
        Me.txtJunioCargo.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'txtMayoCargo
        '
        Me.txtMayoCargo.ComboBoxEnlazado = Nothing
        Me.txtMayoCargo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "MayoCargo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtMayoCargo.Decimales = 0
        Me.txtMayoCargo.Location = New System.Drawing.Point(151, 253)
        Me.txtMayoCargo.MaxLength = 3000
        Me.txtMayoCargo.MensajeCombo = "Seleccionar un item..."
        Me.txtMayoCargo.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtMayoCargo.Name = "txtMayoCargo"
        Me.txtMayoCargo.ReadOnly = True
        Me.txtMayoCargo.SiguienteControl = Nothing
        Me.txtMayoCargo.Size = New System.Drawing.Size(126, 20)
        Me.txtMayoCargo.TabIndex = 31
        Me.txtMayoCargo.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'txtAbrirCargo
        '
        Me.txtAbrirCargo.ComboBoxEnlazado = Nothing
        Me.txtAbrirCargo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "AbrilCargo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtAbrirCargo.Decimales = 0
        Me.txtAbrirCargo.Location = New System.Drawing.Point(151, 227)
        Me.txtAbrirCargo.MaxLength = 3000
        Me.txtAbrirCargo.MensajeCombo = "Seleccionar un item..."
        Me.txtAbrirCargo.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtAbrirCargo.Name = "txtAbrirCargo"
        Me.txtAbrirCargo.ReadOnly = True
        Me.txtAbrirCargo.SiguienteControl = Nothing
        Me.txtAbrirCargo.Size = New System.Drawing.Size(126, 20)
        Me.txtAbrirCargo.TabIndex = 27
        Me.txtAbrirCargo.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'txtMarzoCargo
        '
        Me.txtMarzoCargo.ComboBoxEnlazado = Nothing
        Me.txtMarzoCargo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "MarzoCargo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtMarzoCargo.Decimales = 0
        Me.txtMarzoCargo.Location = New System.Drawing.Point(151, 201)
        Me.txtMarzoCargo.MaxLength = 3000
        Me.txtMarzoCargo.MensajeCombo = "Seleccionar un item..."
        Me.txtMarzoCargo.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtMarzoCargo.Name = "txtMarzoCargo"
        Me.txtMarzoCargo.ReadOnly = True
        Me.txtMarzoCargo.SiguienteControl = Nothing
        Me.txtMarzoCargo.Size = New System.Drawing.Size(126, 20)
        Me.txtMarzoCargo.TabIndex = 23
        Me.txtMarzoCargo.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'txtFebreroCargo
        '
        Me.txtFebreroCargo.ComboBoxEnlazado = Nothing
        Me.txtFebreroCargo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "FebreroCargo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtFebreroCargo.Decimales = 0
        Me.txtFebreroCargo.Location = New System.Drawing.Point(151, 175)
        Me.txtFebreroCargo.MaxLength = 3000
        Me.txtFebreroCargo.MensajeCombo = "Seleccionar un item..."
        Me.txtFebreroCargo.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtFebreroCargo.Name = "txtFebreroCargo"
        Me.txtFebreroCargo.ReadOnly = True
        Me.txtFebreroCargo.SiguienteControl = Nothing
        Me.txtFebreroCargo.Size = New System.Drawing.Size(126, 20)
        Me.txtFebreroCargo.TabIndex = 19
        Me.txtFebreroCargo.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'txtEneroCargo
        '
        Me.txtEneroCargo.ComboBoxEnlazado = Nothing
        Me.txtEneroCargo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "EneroCargo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtEneroCargo.Decimales = 0
        Me.txtEneroCargo.Location = New System.Drawing.Point(151, 149)
        Me.txtEneroCargo.MaxLength = 3000
        Me.txtEneroCargo.MensajeCombo = "Seleccionar un item..."
        Me.txtEneroCargo.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtEneroCargo.Name = "txtEneroCargo"
        Me.txtEneroCargo.ReadOnly = True
        Me.txtEneroCargo.SiguienteControl = Nothing
        Me.txtEneroCargo.Size = New System.Drawing.Size(126, 20)
        Me.txtEneroCargo.TabIndex = 15
        Me.txtEneroCargo.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(56, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "ENERO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(56, 178)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "FEBRERO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(56, 204)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "MARZO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(56, 282)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "JUNIO"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(56, 256)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "MAYO"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(56, 230)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 13)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "ABRIL"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(56, 438)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 13)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "DICIEMBRE"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(56, 412)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 13)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = "NOVIEMBRE"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(56, 386)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 13)
        Me.Label15.TabIndex = 50
        Me.Label15.Text = "OCTUBRE"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(56, 360)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(76, 13)
        Me.Label16.TabIndex = 46
        Me.Label16.Text = "SEPTIEMBRE"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(56, 334)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 13)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "AGOSTO"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(56, 308)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(37, 13)
        Me.Label18.TabIndex = 38
        Me.Label18.Text = "JULIO"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(56, 464)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(42, 13)
        Me.Label19.TabIndex = 62
        Me.Label19.Text = "Totales"
        '
        'frmConsultaSaldo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 512)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTotalCargo)
        Me.Controls.Add(Me.txtDiciembreCargo)
        Me.Controls.Add(Me.txtNoviembreCargo)
        Me.Controls.Add(Me.txtOctubreCargo)
        Me.Controls.Add(Me.txtSeptiembreCargo)
        Me.Controls.Add(Me.txtAgostoCargo)
        Me.Controls.Add(Me.txtJulioCargo)
        Me.Controls.Add(Me.txtJunioCargo)
        Me.Controls.Add(Me.txtMayoCargo)
        Me.Controls.Add(Me.txtAbrirCargo)
        Me.Controls.Add(Me.txtMarzoCargo)
        Me.Controls.Add(Me.txtFebreroCargo)
        Me.Controls.Add(Me.txtEneroCargo)
        Me.Controls.Add(Me.txtTotalAbono)
        Me.Controls.Add(Me.txtDiciembreAbono)
        Me.Controls.Add(Me.txtNoviembreAbono)
        Me.Controls.Add(Me.txtOctubreAbono)
        Me.Controls.Add(Me.txtSeptiembreAbono)
        Me.Controls.Add(Me.txtAgostoAbono)
        Me.Controls.Add(Me.txtJulioAbono)
        Me.Controls.Add(Me.txtJunioAbono)
        Me.Controls.Add(Me.txtMayoAbono)
        Me.Controls.Add(Me.txtAbrilAbono)
        Me.Controls.Add(Me.txtMarzoAbono)
        Me.Controls.Add(Me.txtFebreroAbono)
        Me.Controls.Add(Me.txtEneroAbono)
        Me.Controls.Add(Me.txtTotalSaldo)
        Me.Controls.Add(Me.txtDiciembreSaldo)
        Me.Controls.Add(Me.txtNoviembreSaldo)
        Me.Controls.Add(Me.txtOctubreSaldo)
        Me.Controls.Add(Me.txtSeptiembreSaldo)
        Me.Controls.Add(Me.txtAgostoSaldo)
        Me.Controls.Add(Me.txtJulioSaldo)
        Me.Controls.Add(Me.txtJunioSaldo)
        Me.Controls.Add(Me.txtMayoSaldo)
        Me.Controls.Add(Me.txtAbrilSaldo)
        Me.Controls.Add(Me.txtMarzoSaldo)
        Me.Controls.Add(Me.txtFebreroSaldo)
        Me.Controls.Add(Me.txtEneroSaldo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSaldoInicial)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombreCuentaContable)
        Me.Controls.Add(Me.txtSSSubCuenta)
        Me.Controls.Add(Me.txtSSubCuenta)
        Me.Controls.Add(Me.txtSubCuenta)
        Me.Controls.Add(Me.txtCuenta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmConsultaSaldo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Saldos Contabilidad General"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCuenta As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtSubCuenta As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtSSubCuenta As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtSSSubCuenta As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtNombreCuentaContable As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoInicial As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtEneroSaldo As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtFebreroSaldo As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtMarzoSaldo As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtAbrilSaldo As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtMayoSaldo As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtJunioSaldo As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtJulioSaldo As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtAgostoSaldo As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtSeptiembreSaldo As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtOctubreSaldo As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtNoviembreSaldo As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtDiciembreSaldo As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtTotalSaldo As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtTotalAbono As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtDiciembreAbono As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtNoviembreAbono As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtOctubreAbono As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtSeptiembreAbono As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtAgostoAbono As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtJulioAbono As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtJunioAbono As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtMayoAbono As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtAbrilAbono As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtMarzoAbono As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtFebreroAbono As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtEneroAbono As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtTotalCargo As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtDiciembreCargo As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtNoviembreCargo As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtOctubreCargo As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtSeptiembreCargo As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtAgostoCargo As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtJulioCargo As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtJunioCargo As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtMayoCargo As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtAbrirCargo As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtMarzoCargo As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtFebreroCargo As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtEneroCargo As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents CuentaContableC As ClasesNegocio.CuentaContableCollectionClass
End Class
