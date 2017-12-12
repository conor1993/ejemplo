<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmABCProductosCompras
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.chkDecomisable = New System.Windows.Forms.CheckBox
        Me.chkManejoPiezas = New System.Windows.Forms.CheckBox
        Me.chkProductoValorAgregado = New System.Windows.Forms.CheckBox
        Me.ProductosC = New ClasesNegocio.ProductosCollectionsClass
        Me.chkMerma = New System.Windows.Forms.CheckBox
        Me.chkCorte = New System.Windows.Forms.CheckBox
        Me.chkCanal = New System.Windows.Forms.CheckBox
        Me.chkSubproducto = New System.Windows.Forms.CheckBox
        Me.chkDerivable = New System.Windows.Forms.CheckBox
        Me.txtPiezasXCabeza = New Integralab.Controles.TextBoxMejorado
        Me.txtPrecio = New Integralab.Controles.TextBoxMejorado
        Me.txtNombreIngles = New Integralab.Controles.TextBoxMejorado
        Me.txtMaximoPiezasxCaja = New Integralab.Controles.TextBoxMejorado
        Me.txtDescCorta = New Integralab.Controles.TextBoxMejorado
        Me.txtDescripcion = New Integralab.Controles.TextBoxMejorado
        Me.txtCodigoBarra = New Integralab.Controles.TextBoxMejorado
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label17 = New System.Windows.Forms.Label
        Me.grpListaDecomisos = New System.Windows.Forms.GroupBox
        Me.lsbListaDecomiso = New System.Windows.Forms.ListBox
        Me.MotivosDecomisoC = New ClasesNegocio.MotivosDecomisoCollectionClass
        Me.grpListaDecomisosAgregados = New System.Windows.Forms.GroupBox
        Me.lsbDecomisosAgregados = New System.Windows.Forms.ListBox
        Me.ProductoDetalleDecomisoC = New ClasesNegocio.ProductosDetalleDecomisoCollectionClass
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.btnAgregarTodos = New System.Windows.Forms.Button
        Me.btnQuitar = New System.Windows.Forms.Button
        Me.btnQuitarTodos = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.grpListaDecomisos.SuspendLayout()
        Me.grpListaDecomisosAgregados.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FlowLayoutPanel1)
        Me.GroupBox1.Controls.Add(Me.txtPiezasXCabeza)
        Me.GroupBox1.Controls.Add(Me.txtPrecio)
        Me.GroupBox1.Controls.Add(Me.txtNombreIngles)
        Me.GroupBox1.Controls.Add(Me.txtMaximoPiezasxCaja)
        Me.GroupBox1.Controls.Add(Me.txtDescCorta)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.txtCodigoBarra)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(60, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(460, 263)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.chkDecomisable)
        Me.FlowLayoutPanel1.Controls.Add(Me.chkManejoPiezas)
        Me.FlowLayoutPanel1.Controls.Add(Me.chkProductoValorAgregado)
        Me.FlowLayoutPanel1.Controls.Add(Me.chkMerma)
        Me.FlowLayoutPanel1.Controls.Add(Me.chkCorte)
        Me.FlowLayoutPanel1.Controls.Add(Me.chkCanal)
        Me.FlowLayoutPanel1.Controls.Add(Me.chkSubproducto)
        Me.FlowLayoutPanel1.Controls.Add(Me.chkDerivable)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(6, 151)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(302, 100)
        Me.FlowLayoutPanel1.TabIndex = 16
        '
        'chkDecomisable
        '
        Me.chkDecomisable.AutoSize = True
        Me.chkDecomisable.Location = New System.Drawing.Point(3, 3)
        Me.chkDecomisable.Name = "chkDecomisable"
        Me.chkDecomisable.Size = New System.Drawing.Size(87, 17)
        Me.chkDecomisable.TabIndex = 0
        Me.chkDecomisable.Text = "Decomisable"
        Me.chkDecomisable.UseVisualStyleBackColor = True
        '
        'chkManejoPiezas
        '
        Me.chkManejoPiezas.AutoSize = True
        Me.chkManejoPiezas.Location = New System.Drawing.Point(3, 26)
        Me.chkManejoPiezas.Name = "chkManejoPiezas"
        Me.chkManejoPiezas.Size = New System.Drawing.Size(112, 17)
        Me.chkManejoPiezas.TabIndex = 1
        Me.chkManejoPiezas.Text = "Manejo en piezas "
        Me.chkManejoPiezas.UseVisualStyleBackColor = True
        '
        'chkProductoValorAgregado
        '
        Me.chkProductoValorAgregado.AutoSize = True
        Me.chkProductoValorAgregado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ProductosC, "ValorAgregado", True))
        Me.chkProductoValorAgregado.Location = New System.Drawing.Point(3, 49)
        Me.chkProductoValorAgregado.Name = "chkProductoValorAgregado"
        Me.chkProductoValorAgregado.Size = New System.Drawing.Size(158, 17)
        Me.chkProductoValorAgregado.TabIndex = 2
        Me.chkProductoValorAgregado.Text = "Producto de valor agregado"
        Me.chkProductoValorAgregado.UseVisualStyleBackColor = True
        '
        'ProductosC
        '
        Me.ProductosC.AllowEdit = True
        Me.ProductosC.AllowNew = True
        Me.ProductosC.AllowRemove = True
        Me.ProductosC.MaximoElementosSeleccionados = 1
        Me.ProductosC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.ProductosC.MostrarAlertas = False
        Me.ProductosC.Name = ""
        Me.ProductosC.RaiseListChangedEvents = True
        Me.ProductosC.Transaction = Nothing
        '
        'chkMerma
        '
        Me.chkMerma.AutoSize = True
        Me.chkMerma.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ProductosC, "ValorAgregado", True))
        Me.chkMerma.Location = New System.Drawing.Point(3, 72)
        Me.chkMerma.Name = "chkMerma"
        Me.chkMerma.Size = New System.Drawing.Size(73, 17)
        Me.chkMerma.TabIndex = 3
        Me.chkMerma.Text = "Es Merma"
        Me.chkMerma.UseVisualStyleBackColor = True
        '
        'chkCorte
        '
        Me.chkCorte.AutoSize = True
        Me.chkCorte.Location = New System.Drawing.Point(167, 3)
        Me.chkCorte.Name = "chkCorte"
        Me.chkCorte.Size = New System.Drawing.Size(51, 17)
        Me.chkCorte.TabIndex = 4
        Me.chkCorte.Text = "Corte"
        Me.chkCorte.UseVisualStyleBackColor = True
        Me.chkCorte.Visible = False
        '
        'chkCanal
        '
        Me.chkCanal.AutoSize = True
        Me.chkCanal.Location = New System.Drawing.Point(167, 26)
        Me.chkCanal.Name = "chkCanal"
        Me.chkCanal.Size = New System.Drawing.Size(53, 17)
        Me.chkCanal.TabIndex = 5
        Me.chkCanal.Text = "Canal"
        Me.chkCanal.UseVisualStyleBackColor = True
        '
        'chkSubproducto
        '
        Me.chkSubproducto.AutoSize = True
        Me.chkSubproducto.Location = New System.Drawing.Point(167, 49)
        Me.chkSubproducto.Name = "chkSubproducto"
        Me.chkSubproducto.Size = New System.Drawing.Size(88, 17)
        Me.chkSubproducto.TabIndex = 6
        Me.chkSubproducto.Text = "SubProducto"
        Me.chkSubproducto.UseVisualStyleBackColor = True
        '
        'chkDerivable
        '
        Me.chkDerivable.AutoSize = True
        Me.chkDerivable.Location = New System.Drawing.Point(167, 72)
        Me.chkDerivable.Name = "chkDerivable"
        Me.chkDerivable.Size = New System.Drawing.Size(71, 17)
        Me.chkDerivable.TabIndex = 7
        Me.chkDerivable.Text = "Derivable"
        Me.chkDerivable.UseVisualStyleBackColor = True
        '
        'txtPiezasXCabeza
        '
        Me.txtPiezasXCabeza.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPiezasXCabeza.ComboBoxEnlazado = Nothing
        Me.txtPiezasXCabeza.Decimales = 0
        Me.txtPiezasXCabeza.Location = New System.Drawing.Point(383, 124)
        Me.txtPiezasXCabeza.MaxLength = 3000
        Me.txtPiezasXCabeza.MensajeCombo = "Seleccionar un item..."
        Me.txtPiezasXCabeza.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtPiezasXCabeza.Name = "txtPiezasXCabeza"
        Me.txtPiezasXCabeza.SiguienteControl = Nothing
        Me.txtPiezasXCabeza.Size = New System.Drawing.Size(67, 20)
        Me.txtPiezasXCabeza.TabIndex = 15
        Me.txtPiezasXCabeza.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtPiezasXCabeza.ValorMaximo = New Decimal(New Integer() {99, 0, 0, 0})
        Me.txtPiezasXCabeza.ValorMinimo = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtPrecio
        '
        Me.txtPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrecio.ComboBoxEnlazado = Nothing
        Me.txtPrecio.Decimales = 0
        Me.txtPrecio.Location = New System.Drawing.Point(110, 125)
        Me.txtPrecio.MaxLength = 3000
        Me.txtPrecio.MensajeCombo = "Seleccionar un item..."
        Me.txtPrecio.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.SiguienteControl = Me.txtPiezasXCabeza
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 13
        Me.txtPrecio.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        Me.txtPrecio.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtPrecio.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtNombreIngles
        '
        Me.txtNombreIngles.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreIngles.ComboBoxEnlazado = Nothing
        Me.txtNombreIngles.Decimales = 0
        Me.txtNombreIngles.Location = New System.Drawing.Point(110, 98)
        Me.txtNombreIngles.MensajeCombo = "Seleccionar un item..."
        Me.txtNombreIngles.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtNombreIngles.Name = "txtNombreIngles"
        Me.txtNombreIngles.SiguienteControl = Me.txtPrecio
        Me.txtNombreIngles.Size = New System.Drawing.Size(340, 20)
        Me.txtNombreIngles.TabIndex = 11
        Me.txtNombreIngles.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtNombreIngles.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtNombreIngles.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtMaximoPiezasxCaja
        '
        Me.txtMaximoPiezasxCaja.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMaximoPiezasxCaja.ComboBoxEnlazado = Nothing
        Me.txtMaximoPiezasxCaja.Decimales = 0
        Me.txtMaximoPiezasxCaja.Location = New System.Drawing.Point(383, 71)
        Me.txtMaximoPiezasxCaja.MaxLength = 3000
        Me.txtMaximoPiezasxCaja.MensajeCombo = "Seleccionar un item..."
        Me.txtMaximoPiezasxCaja.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtMaximoPiezasxCaja.Name = "txtMaximoPiezasxCaja"
        Me.txtMaximoPiezasxCaja.SiguienteControl = Me.txtNombreIngles
        Me.txtMaximoPiezasxCaja.Size = New System.Drawing.Size(67, 20)
        Me.txtMaximoPiezasxCaja.TabIndex = 9
        Me.txtMaximoPiezasxCaja.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtMaximoPiezasxCaja.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtMaximoPiezasxCaja.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtDescCorta
        '
        Me.txtDescCorta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescCorta.ComboBoxEnlazado = Nothing
        Me.txtDescCorta.Decimales = 0
        Me.txtDescCorta.Location = New System.Drawing.Point(110, 72)
        Me.txtDescCorta.MensajeCombo = "Seleccionar un item..."
        Me.txtDescCorta.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtDescCorta.Name = "txtDescCorta"
        Me.txtDescCorta.SiguienteControl = Me.txtMaximoPiezasxCaja
        Me.txtDescCorta.Size = New System.Drawing.Size(147, 20)
        Me.txtDescCorta.TabIndex = 7
        Me.txtDescCorta.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtDescCorta.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtDescCorta.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.ComboBoxEnlazado = Nothing
        Me.txtDescripcion.Decimales = 0
        Me.txtDescripcion.Location = New System.Drawing.Point(109, 46)
        Me.txtDescripcion.MensajeCombo = "Seleccionar un item..."
        Me.txtDescripcion.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.SiguienteControl = Me.txtDescCorta
        Me.txtDescripcion.Size = New System.Drawing.Size(341, 20)
        Me.txtDescripcion.TabIndex = 5
        Me.txtDescripcion.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtDescripcion.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtDescripcion.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtCodigoBarra
        '
        Me.txtCodigoBarra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoBarra.ComboBoxEnlazado = Nothing
        Me.txtCodigoBarra.Decimales = 0
        Me.txtCodigoBarra.Location = New System.Drawing.Point(294, 21)
        Me.txtCodigoBarra.MensajeCombo = "Seleccionar un item..."
        Me.txtCodigoBarra.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtCodigoBarra.Name = "txtCodigoBarra"
        Me.txtCodigoBarra.SiguienteControl = Me.txtDescripcion
        Me.txtCodigoBarra.Size = New System.Drawing.Size(156, 20)
        Me.txtCodigoBarra.TabIndex = 3
        Me.txtCodigoBarra.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtCodigoBarra.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCodigoBarra.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(287, 127)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Piezas X Cabeza:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Precio X Kilo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(263, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Maximo Piezas x Caja :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(214, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Codigo Barra :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Nombre en Ingles :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Des. Corta :"
        '
        'txtCodigo
        '
        Me.txtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosC, "IdProducto", True))
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(109, 20)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(67, 20)
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Descripción :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo :"
        '
        'lblEstatus
        '
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(546, 55)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(126, 24)
        Me.lblEstatus.TabIndex = 6
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.mtb.MostrarBorrar = True
        Me.mtb.MostrarBuscar = True
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = True
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 585)
        Me.mtb.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(634, 32)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "PRODUCTOS DE SALA DE CORTES"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpListaDecomisos
        '
        Me.grpListaDecomisos.Controls.Add(Me.lsbListaDecomiso)
        Me.grpListaDecomisos.Enabled = False
        Me.grpListaDecomisos.Location = New System.Drawing.Point(56, 304)
        Me.grpListaDecomisos.Name = "grpListaDecomisos"
        Me.grpListaDecomisos.Size = New System.Drawing.Size(274, 269)
        Me.grpListaDecomisos.TabIndex = 3
        Me.grpListaDecomisos.TabStop = False
        Me.grpListaDecomisos.Text = "Relación de Motivos de Decomiso"
        '
        'lsbListaDecomiso
        '
        Me.lsbListaDecomiso.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsbListaDecomiso.DataSource = Me.MotivosDecomisoC
        Me.lsbListaDecomiso.DisplayMember = "Descripcion"
        Me.lsbListaDecomiso.FormattingEnabled = True
        Me.lsbListaDecomiso.Location = New System.Drawing.Point(6, 19)
        Me.lsbListaDecomiso.Name = "lsbListaDecomiso"
        Me.lsbListaDecomiso.Size = New System.Drawing.Size(265, 238)
        Me.lsbListaDecomiso.Sorted = True
        Me.lsbListaDecomiso.TabIndex = 0
        Me.lsbListaDecomiso.ValueMember = "IdDecomiso"
        '
        'MotivosDecomisoC
        '
        Me.MotivosDecomisoC.AllowEdit = True
        Me.MotivosDecomisoC.AllowNew = True
        Me.MotivosDecomisoC.AllowRemove = True
        Me.MotivosDecomisoC.MaximoElementosSeleccionados = 1
        Me.MotivosDecomisoC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.MotivosDecomisoC.MostrarAlertas = False
        Me.MotivosDecomisoC.Name = ""
        Me.MotivosDecomisoC.RaiseListChangedEvents = True
        Me.MotivosDecomisoC.Transaction = Nothing
        '
        'grpListaDecomisosAgregados
        '
        Me.grpListaDecomisosAgregados.Controls.Add(Me.lsbDecomisosAgregados)
        Me.grpListaDecomisosAgregados.Enabled = False
        Me.grpListaDecomisosAgregados.Location = New System.Drawing.Point(397, 304)
        Me.grpListaDecomisosAgregados.Name = "grpListaDecomisosAgregados"
        Me.grpListaDecomisosAgregados.Size = New System.Drawing.Size(275, 269)
        Me.grpListaDecomisosAgregados.TabIndex = 5
        Me.grpListaDecomisosAgregados.TabStop = False
        Me.grpListaDecomisosAgregados.Text = "Motivos de Decomiso Agregados"
        '
        'lsbDecomisosAgregados
        '
        Me.lsbDecomisosAgregados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsbDecomisosAgregados.DataBindings.Add(New System.Windows.Forms.Binding("DataSource", Me.ProductosC, "DetallePropRel", True))
        Me.lsbDecomisosAgregados.DataSource = Me.ProductoDetalleDecomisoC
        Me.lsbDecomisosAgregados.DisplayMember = "DecomisoNombre"
        Me.lsbDecomisosAgregados.FormattingEnabled = True
        Me.lsbDecomisosAgregados.Location = New System.Drawing.Point(6, 19)
        Me.lsbDecomisosAgregados.Name = "lsbDecomisosAgregados"
        Me.lsbDecomisosAgregados.Size = New System.Drawing.Size(263, 238)
        Me.lsbDecomisosAgregados.Sorted = True
        Me.lsbDecomisosAgregados.TabIndex = 0
        Me.lsbDecomisosAgregados.ValueMember = "IdDecomiso"
        '
        'ProductoDetalleDecomisoC
        '
        Me.ProductoDetalleDecomisoC.AllowEdit = True
        Me.ProductoDetalleDecomisoC.AllowNew = True
        Me.ProductoDetalleDecomisoC.AllowRemove = True
        Me.ProductoDetalleDecomisoC.MaximoElementosSeleccionados = 1
        Me.ProductoDetalleDecomisoC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.ProductoDetalleDecomisoC.MostrarAlertas = False
        Me.ProductoDetalleDecomisoC.Name = ""
        Me.ProductoDetalleDecomisoC.RaiseListChangedEvents = True
        Me.ProductoDetalleDecomisoC.Transaction = Nothing
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(3, 3)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(51, 23)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = ">"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnAgregarTodos
        '
        Me.btnAgregarTodos.Location = New System.Drawing.Point(3, 32)
        Me.btnAgregarTodos.Name = "btnAgregarTodos"
        Me.btnAgregarTodos.Size = New System.Drawing.Size(51, 23)
        Me.btnAgregarTodos.TabIndex = 1
        Me.btnAgregarTodos.Text = ">>"
        Me.btnAgregarTodos.UseVisualStyleBackColor = True
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(3, 61)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(51, 23)
        Me.btnQuitar.TabIndex = 2
        Me.btnQuitar.Text = "<"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'btnQuitarTodos
        '
        Me.btnQuitarTodos.Location = New System.Drawing.Point(3, 90)
        Me.btnQuitarTodos.Name = "btnQuitarTodos"
        Me.btnQuitarTodos.Size = New System.Drawing.Size(51, 23)
        Me.btnQuitarTodos.TabIndex = 3
        Me.btnQuitarTodos.Text = "<<"
        Me.btnQuitarTodos.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnAgregar)
        Me.Panel1.Controls.Add(Me.btnAgregarTodos)
        Me.Panel1.Controls.Add(Me.btnQuitar)
        Me.Panel1.Controls.Add(Me.btnQuitarTodos)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(333, 383)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(58, 117)
        Me.Panel1.TabIndex = 4
        '
        'frmABCProductosCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 585)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.grpListaDecomisosAgregados)
        Me.Controls.Add(Me.grpListaDecomisos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.lblEstatus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmABCProductosCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos de Sala de Cortes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.grpListaDecomisos.ResumeLayout(False)
        Me.grpListaDecomisosAgregados.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents chkManejoPiezas As System.Windows.Forms.CheckBox
    Friend WithEvents chkSubproducto As System.Windows.Forms.CheckBox
    Friend WithEvents chkDecomisable As System.Windows.Forms.CheckBox
    Friend WithEvents chkProductoValorAgregado As System.Windows.Forms.CheckBox
    Friend WithEvents grpListaDecomisos As System.Windows.Forms.GroupBox
    Friend WithEvents grpListaDecomisosAgregados As System.Windows.Forms.GroupBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnAgregarTodos As System.Windows.Forms.Button
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents btnQuitarTodos As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lsbListaDecomiso As System.Windows.Forms.ListBox
    Friend WithEvents lsbDecomisosAgregados As System.Windows.Forms.ListBox
    Friend WithEvents MotivosDecomisoC As ClasesNegocio.MotivosDecomisoCollectionClass
    Friend WithEvents ProductoDetalleDecomisoC As ClasesNegocio.ProductosDetalleDecomisoCollectionClass
    Friend WithEvents ProductosC As ClasesNegocio.ProductosCollectionsClass
    Friend WithEvents chkMerma As System.Windows.Forms.CheckBox
    Friend WithEvents txtPrecio As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtNombreIngles As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtMaximoPiezasxCaja As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtDescCorta As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtDescripcion As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtCodigoBarra As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtPiezasXCabeza As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents chkCorte As System.Windows.Forms.CheckBox
    Friend WithEvents chkCanal As System.Windows.Forms.CheckBox
    Friend WithEvents chkDerivable As System.Windows.Forms.CheckBox
End Class
