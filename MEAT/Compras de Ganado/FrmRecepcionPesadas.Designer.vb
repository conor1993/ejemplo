<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRecepcionPesadas
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.mtbMenu = New MEAToolBar.MEAToolBar
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.tbcOpcion = New System.Windows.Forms.TabControl
        Me.tabGanado = New System.Windows.Forms.TabPage
        Me.txtTotalCabezas = New Integralab.Controles.TextBoxMejorado
        Me.Label14 = New System.Windows.Forms.Label
        Me.dgvGanado = New System.Windows.Forms.DataGridView
        Me.clmCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmTipoGanado = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.TipoGanado = New ClasesNegocio.TipoGanadoColecttionClass
        Me.clmCabezas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tabIngredientes = New System.Windows.Forms.TabPage
        Me.txtCodigoProducto = New Integralab.Controles.TextBoxMejorado
        Me.cmbProducto = New Integralab.Controles.ComboBoxMejorado
        Me.Label5 = New System.Windows.Forms.Label
        Me.tabOtros = New System.Windows.Forms.TabPage
        Me.txtProducto = New Integralab.Controles.TextBoxMejorado
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtProveedor = New Integralab.Controles.TextBoxMejorado
        Me.txtKilosRecibidos = New Integralab.Controles.TextBoxMejorado
        Me.txtKilos2Pesada = New Integralab.Controles.TextBoxMejorado
        Me.txtObservaciones = New Integralab.Controles.TextBoxMejorado
        Me.txtPlacas = New Integralab.Controles.TextBoxMejorado
        Me.txtConductor = New Integralab.Controles.TextBoxMejorado
        Me.txtUnidad = New Integralab.Controles.TextBoxMejorado
        Me.txtKilosEnviados = New Integralab.Controles.TextBoxMejorado
        Me.txtKilos1Pesada = New Integralab.Controles.TextBoxMejorado
        Me.cmbProveedor = New Integralab.Controles.ComboBoxMejorado
        Me.txtFolio = New Integralab.Controles.TextBoxMejorado
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.txtLeerPeso = New wclTextBoxSerial.TextBoxSerial
        Me.chkBascula = New System.Windows.Forms.CheckBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.rbnSi = New System.Windows.Forms.RadioButton
        Me.rbnNo = New System.Windows.Forms.RadioButton
        Me.tbcOpcion.SuspendLayout()
        Me.tabGanado.SuspendLayout()
        CType(Me.dgvGanado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabIngredientes.SuspendLayout()
        Me.tabOtros.SuspendLayout()
        Me.SuspendLayout()
        '
        'mtbMenu
        '
        Me.mtbMenu.ButtonSize = New System.Drawing.Size(50, 50)
        Me.mtbMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.mtbMenu.DropDownArrows = True
        Me.mtbMenu.HabilitarBorrar = True
        Me.mtbMenu.HabilitarBuscar = True
        Me.mtbMenu.HabilitarCancelar = True
        Me.mtbMenu.HabilitarEditar = True
        Me.mtbMenu.HabilitarGuardar = True
        Me.mtbMenu.HabilitarImprimir = True
        Me.mtbMenu.HabilitarLimpiar = True
        Me.mtbMenu.HabilitarNuevo = True
        Me.mtbMenu.HabilitarSalir = True
        Me.mtbMenu.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32
        Me.mtbMenu.Location = New System.Drawing.Point(0, 0)
        Me.mtbMenu.MostrarBorrar = True
        Me.mtbMenu.MostrarBuscar = True
        Me.mtbMenu.MostrarCancelar = True
        Me.mtbMenu.MostrarEditar = True
        Me.mtbMenu.MostrarGuardar = True
        Me.mtbMenu.MostrarImprimir = True
        Me.mtbMenu.MostrarLimpiar = True
        Me.mtbMenu.MostrarNuevo = True
        Me.mtbMenu.MostrarSalir = True
        Me.mtbMenu.Name = "mtbMenu"
        Me.mtbMenu.ShowToolTips = True
        Me.mtbMenu.Size = New System.Drawing.Size(50, 535)
        Me.mtbMenu.TabIndex = 35
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(56, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(493, 32)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = "RECEPCIÓN DE PESADAS"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Folio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(225, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(271, 46)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha.TabIndex = 40
        Me.dtpFecha.Value = New Date(2009, 5, 1, 0, 0, 0, 0)
        '
        'tbcOpcion
        '
        Me.tbcOpcion.Controls.Add(Me.tabGanado)
        Me.tbcOpcion.Controls.Add(Me.tabIngredientes)
        Me.tbcOpcion.Controls.Add(Me.tabOtros)
        Me.tbcOpcion.Location = New System.Drawing.Point(60, 82)
        Me.tbcOpcion.Name = "tbcOpcion"
        Me.tbcOpcion.SelectedIndex = 0
        Me.tbcOpcion.Size = New System.Drawing.Size(385, 156)
        Me.tbcOpcion.TabIndex = 41
        '
        'tabGanado
        '
        Me.tabGanado.Controls.Add(Me.txtTotalCabezas)
        Me.tabGanado.Controls.Add(Me.Label14)
        Me.tabGanado.Controls.Add(Me.dgvGanado)
        Me.tabGanado.Location = New System.Drawing.Point(4, 22)
        Me.tabGanado.Name = "tabGanado"
        Me.tabGanado.Size = New System.Drawing.Size(377, 130)
        Me.tabGanado.TabIndex = 0
        Me.tabGanado.Text = "Ganado"
        Me.tabGanado.UseVisualStyleBackColor = True
        '
        'txtTotalCabezas
        '
        Me.txtTotalCabezas.ComboBoxEnlazado = Nothing
        Me.txtTotalCabezas.Decimales = 0
        Me.txtTotalCabezas.Location = New System.Drawing.Point(285, 107)
        Me.txtTotalCabezas.MensajeCombo = "Seleccionar un item..."
        Me.txtTotalCabezas.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtTotalCabezas.Name = "txtTotalCabezas"
        Me.txtTotalCabezas.SiguienteControl = Nothing
        Me.txtTotalCabezas.Size = New System.Drawing.Size(68, 20)
        Me.txtTotalCabezas.TabIndex = 58
        Me.txtTotalCabezas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalCabezas.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(186, 110)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 13)
        Me.Label14.TabIndex = 58
        Me.Label14.Text = "Total de Cabezas:"
        '
        'dgvGanado
        '
        Me.dgvGanado.AllowUserToDeleteRows = False
        Me.dgvGanado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGanado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmCodigo, Me.clmTipoGanado, Me.clmCabezas})
        Me.dgvGanado.Location = New System.Drawing.Point(3, 5)
        Me.dgvGanado.Name = "dgvGanado"
        Me.dgvGanado.RowHeadersVisible = False
        Me.dgvGanado.Size = New System.Drawing.Size(371, 100)
        Me.dgvGanado.TabIndex = 0
        '
        'clmCodigo
        '
        Me.clmCodigo.DataPropertyName = "LoteRecepcion"
        Me.clmCodigo.HeaderText = "Codigo"
        Me.clmCodigo.Name = "clmCodigo"
        Me.clmCodigo.ReadOnly = True
        Me.clmCodigo.Visible = False
        '
        'clmTipoGanado
        '
        Me.clmTipoGanado.DataPropertyName = "IdTipoGanado"
        Me.clmTipoGanado.DataSource = Me.TipoGanado
        Me.clmTipoGanado.DisplayMember = "Descripcion"
        Me.clmTipoGanado.HeaderText = "Tipo de Ganado"
        Me.clmTipoGanado.Name = "clmTipoGanado"
        Me.clmTipoGanado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmTipoGanado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clmTipoGanado.ValueMember = "IdTipoGanado"
        Me.clmTipoGanado.Width = 280
        '
        'TipoGanado
        '
        Me.TipoGanado.AllowEdit = True
        Me.TipoGanado.AllowNew = True
        Me.TipoGanado.AllowRemove = True
        Me.TipoGanado.MaximoElementosSeleccionados = 1
        Me.TipoGanado.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.TipoGanado.MostrarAlertas = False
        Me.TipoGanado.Name = ""
        Me.TipoGanado.RaiseListChangedEvents = True
        '
        'clmCabezas
        '
        Me.clmCabezas.DataPropertyName = "CantCabezas"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.clmCabezas.DefaultCellStyle = DataGridViewCellStyle9
        Me.clmCabezas.HeaderText = "Cabezas"
        Me.clmCabezas.Name = "clmCabezas"
        Me.clmCabezas.Width = 68
        '
        'tabIngredientes
        '
        Me.tabIngredientes.Controls.Add(Me.txtCodigoProducto)
        Me.tabIngredientes.Controls.Add(Me.cmbProducto)
        Me.tabIngredientes.Controls.Add(Me.Label5)
        Me.tabIngredientes.Location = New System.Drawing.Point(4, 22)
        Me.tabIngredientes.Name = "tabIngredientes"
        Me.tabIngredientes.Size = New System.Drawing.Size(377, 130)
        Me.tabIngredientes.TabIndex = 1
        Me.tabIngredientes.Text = "Ingredientes"
        Me.tabIngredientes.UseVisualStyleBackColor = True
        '
        'txtCodigoProducto
        '
        Me.txtCodigoProducto.ComboBoxEnlazado = Nothing
        Me.txtCodigoProducto.Decimales = 0
        Me.txtCodigoProducto.Location = New System.Drawing.Point(64, 12)
        Me.txtCodigoProducto.MaxLength = 3000
        Me.txtCodigoProducto.MensajeCombo = "Seleccionar un item..."
        Me.txtCodigoProducto.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtCodigoProducto.Name = "txtCodigoProducto"
        Me.txtCodigoProducto.SiguienteControl = Nothing
        Me.txtCodigoProducto.Size = New System.Drawing.Size(67, 20)
        Me.txtCodigoProducto.TabIndex = 0
        Me.txtCodigoProducto.Text = "0"
        Me.txtCodigoProducto.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        '
        'cmbProducto
        '
        Me.cmbProducto.DisplayMember = "Descripcion"
        Me.cmbProducto.FormattingEnabled = True
        Me.cmbProducto.Location = New System.Drawing.Point(137, 12)
        Me.cmbProducto.Name = "cmbProducto"
        Me.cmbProducto.NombreMetodo = Nothing
        Me.cmbProducto.Parametros = Nothing
        Me.cmbProducto.SiguienteControl = Nothing
        Me.cmbProducto.Size = New System.Drawing.Size(229, 21)
        Me.cmbProducto.TabIndex = 1
        Me.cmbProducto.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbProducto.TextBoxEnlazado = Nothing
        Me.cmbProducto.ValueMember = "Codigo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Producto:"
        '
        'tabOtros
        '
        Me.tabOtros.Controls.Add(Me.txtProducto)
        Me.tabOtros.Controls.Add(Me.Label13)
        Me.tabOtros.Location = New System.Drawing.Point(4, 22)
        Me.tabOtros.Name = "tabOtros"
        Me.tabOtros.Size = New System.Drawing.Size(377, 130)
        Me.tabOtros.TabIndex = 2
        Me.tabOtros.Text = "Otros"
        Me.tabOtros.UseVisualStyleBackColor = True
        '
        'txtProducto
        '
        Me.txtProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProducto.ComboBoxEnlazado = Nothing
        Me.txtProducto.Decimales = 0
        Me.txtProducto.Location = New System.Drawing.Point(65, 12)
        Me.txtProducto.MensajeCombo = "Seleccionar un item..."
        Me.txtProducto.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.SiguienteControl = Nothing
        Me.txtProducto.Size = New System.Drawing.Size(301, 20)
        Me.txtProducto.TabIndex = 0
        Me.txtProducto.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 13)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Producto:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(56, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Kilos Enviados:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(56, 309)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 13)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Kilos 1er. Pesada:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(56, 336)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Proveedor:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(56, 364)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Unidad:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(56, 391)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Conductor:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(56, 418)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Placas:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(56, 445)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 13)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Observaciones:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(294, 309)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Kilos 2da. Pesada:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(294, 255)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Kilos Recibidos:"
        '
        'txtProveedor
        '
        Me.txtProveedor.ComboBoxEnlazado = Nothing
        Me.txtProveedor.Decimales = 0
        Me.txtProveedor.Location = New System.Drawing.Point(154, 333)
        Me.txtProveedor.MaxLength = 3000
        Me.txtProveedor.MensajeCombo = "Seleccionar un item..."
        Me.txtProveedor.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.SiguienteControl = Nothing
        Me.txtProveedor.Size = New System.Drawing.Size(67, 20)
        Me.txtProveedor.TabIndex = 49
        Me.txtProveedor.Text = "0"
        Me.txtProveedor.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        '
        'txtKilosRecibidos
        '
        Me.txtKilosRecibidos.ComboBoxEnlazado = Nothing
        Me.txtKilosRecibidos.Decimales = 0
        Me.txtKilosRecibidos.Location = New System.Drawing.Point(395, 252)
        Me.txtKilosRecibidos.MaxLength = 3000
        Me.txtKilosRecibidos.MensajeCombo = "Seleccionar un item..."
        Me.txtKilosRecibidos.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtKilosRecibidos.Name = "txtKilosRecibidos"
        Me.txtKilosRecibidos.ReadOnly = True
        Me.txtKilosRecibidos.SiguienteControl = Nothing
        Me.txtKilosRecibidos.Size = New System.Drawing.Size(125, 20)
        Me.txtKilosRecibidos.TabIndex = 44
        Me.txtKilosRecibidos.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.[Decimal]
        '
        'txtKilos2Pesada
        '
        Me.txtKilos2Pesada.ComboBoxEnlazado = Nothing
        Me.txtKilos2Pesada.Decimales = 0
        Me.txtKilos2Pesada.Location = New System.Drawing.Point(395, 306)
        Me.txtKilos2Pesada.MaxLength = 3000
        Me.txtKilos2Pesada.MensajeCombo = "Seleccionar un item..."
        Me.txtKilos2Pesada.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtKilos2Pesada.Name = "txtKilos2Pesada"
        Me.txtKilos2Pesada.SiguienteControl = Nothing
        Me.txtKilos2Pesada.Size = New System.Drawing.Size(125, 20)
        Me.txtKilos2Pesada.TabIndex = 48
        Me.txtKilos2Pesada.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.[Decimal]
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.ComboBoxEnlazado = Nothing
        Me.txtObservaciones.Decimales = 0
        Me.txtObservaciones.Location = New System.Drawing.Point(154, 442)
        Me.txtObservaciones.MensajeCombo = "Seleccionar un item..."
        Me.txtObservaciones.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.SiguienteControl = Nothing
        Me.txtObservaciones.Size = New System.Drawing.Size(366, 85)
        Me.txtObservaciones.TabIndex = 54
        Me.txtObservaciones.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'txtPlacas
        '
        Me.txtPlacas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlacas.ComboBoxEnlazado = Nothing
        Me.txtPlacas.Decimales = 0
        Me.txtPlacas.Location = New System.Drawing.Point(154, 415)
        Me.txtPlacas.MensajeCombo = "Seleccionar un item..."
        Me.txtPlacas.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtPlacas.Name = "txtPlacas"
        Me.txtPlacas.SiguienteControl = Nothing
        Me.txtPlacas.Size = New System.Drawing.Size(126, 20)
        Me.txtPlacas.TabIndex = 53
        Me.txtPlacas.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'txtConductor
        '
        Me.txtConductor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConductor.ComboBoxEnlazado = Nothing
        Me.txtConductor.Decimales = 0
        Me.txtConductor.Location = New System.Drawing.Point(154, 387)
        Me.txtConductor.MensajeCombo = "Seleccionar un item..."
        Me.txtConductor.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtConductor.Name = "txtConductor"
        Me.txtConductor.SiguienteControl = Nothing
        Me.txtConductor.Size = New System.Drawing.Size(366, 20)
        Me.txtConductor.TabIndex = 52
        Me.txtConductor.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'txtUnidad
        '
        Me.txtUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUnidad.ComboBoxEnlazado = Nothing
        Me.txtUnidad.Decimales = 0
        Me.txtUnidad.Location = New System.Drawing.Point(154, 361)
        Me.txtUnidad.MensajeCombo = "Seleccionar un item..."
        Me.txtUnidad.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.SiguienteControl = Nothing
        Me.txtUnidad.Size = New System.Drawing.Size(366, 20)
        Me.txtUnidad.TabIndex = 51
        Me.txtUnidad.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'txtKilosEnviados
        '
        Me.txtKilosEnviados.ComboBoxEnlazado = Nothing
        Me.txtKilosEnviados.Decimales = 0
        Me.txtKilosEnviados.Location = New System.Drawing.Point(154, 252)
        Me.txtKilosEnviados.MaxLength = 3000
        Me.txtKilosEnviados.MensajeCombo = "Seleccionar un item..."
        Me.txtKilosEnviados.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtKilosEnviados.Name = "txtKilosEnviados"
        Me.txtKilosEnviados.SiguienteControl = Nothing
        Me.txtKilosEnviados.Size = New System.Drawing.Size(125, 20)
        Me.txtKilosEnviados.TabIndex = 43
        Me.txtKilosEnviados.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.[Decimal]
        '
        'txtKilos1Pesada
        '
        Me.txtKilos1Pesada.ComboBoxEnlazado = Nothing
        Me.txtKilos1Pesada.Decimales = 0
        Me.txtKilos1Pesada.Location = New System.Drawing.Point(154, 306)
        Me.txtKilos1Pesada.MaxLength = 3000
        Me.txtKilos1Pesada.MensajeCombo = "Seleccionar un item..."
        Me.txtKilos1Pesada.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtKilos1Pesada.Name = "txtKilos1Pesada"
        Me.txtKilos1Pesada.SiguienteControl = Nothing
        Me.txtKilos1Pesada.Size = New System.Drawing.Size(125, 20)
        Me.txtKilos1Pesada.TabIndex = 47
        Me.txtKilos1Pesada.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.[Decimal]
        '
        'cmbProveedor
        '
        Me.cmbProveedor.DisplayMember = "RazonSocial"
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(227, 333)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.NombreMetodo = Nothing
        Me.cmbProveedor.Parametros = Nothing
        Me.cmbProveedor.SiguienteControl = Me.txtUnidad
        Me.cmbProveedor.Size = New System.Drawing.Size(293, 21)
        Me.cmbProveedor.TabIndex = 50
        Me.cmbProveedor.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbProveedor.TextBoxEnlazado = Nothing
        Me.cmbProveedor.ValueMember = "Codigo"
        '
        'txtFolio
        '
        Me.txtFolio.ComboBoxEnlazado = Nothing
        Me.txtFolio.Decimales = 0
        Me.txtFolio.Location = New System.Drawing.Point(95, 47)
        Me.txtFolio.MaxLength = 3000
        Me.txtFolio.MensajeCombo = "Seleccionar un item..."
        Me.txtFolio.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.ReadOnly = True
        Me.txtFolio.SiguienteControl = Me.dtpFecha
        Me.txtFolio.Size = New System.Drawing.Size(100, 20)
        Me.txtFolio.TabIndex = 36
        Me.txtFolio.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Tipo de Ganado"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 200
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cabezas"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 60
        '
        'lblEstatus
        '
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(405, 33)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(115, 21)
        Me.lblEstatus.TabIndex = 58
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLeerPeso
        '
        Me.txtLeerPeso.BaudRate = 9600
        Me.txtLeerPeso.DataBit = 8
        Me.txtLeerPeso.Format = wclTextBoxSerial.TextBoxSerial.FormatoDatos.Ascii
        Me.txtLeerPeso.Location = New System.Drawing.Point(68, 485)
        Me.txtLeerPeso.Name = "txtLeerPeso"
        Me.txtLeerPeso.Parity = wclTextBoxSerial.Rs232.DataParity.Parity_None
        Me.txtLeerPeso.Port = 1
        Me.txtLeerPeso.Size = New System.Drawing.Size(67, 20)
        Me.txtLeerPeso.StopBit = wclTextBoxSerial.Rs232.DataStopBit.StopBit_1
        Me.txtLeerPeso.TabIndex = 84
        Me.txtLeerPeso.TimeOut = 1500
        Me.txtLeerPeso.TimeToWaitForMoreData = 300
        Me.txtLeerPeso.Visible = False
        '
        'chkBascula
        '
        Me.chkBascula.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkBascula.Location = New System.Drawing.Point(444, 137)
        Me.chkBascula.Name = "chkBascula"
        Me.chkBascula.Size = New System.Drawing.Size(76, 72)
        Me.chkBascula.TabIndex = 41
        Me.chkBascula.Text = "Lectura de Bascula Desactivada"
        Me.chkBascula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkBascula.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(56, 282)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 13)
        Me.Label15.TabIndex = 86
        Me.Label15.Text = "Esta lleno?"
        '
        'rbnSi
        '
        Me.rbnSi.AutoSize = True
        Me.rbnSi.Location = New System.Drawing.Point(154, 280)
        Me.rbnSi.Name = "rbnSi"
        Me.rbnSi.Size = New System.Drawing.Size(34, 17)
        Me.rbnSi.TabIndex = 45
        Me.rbnSi.TabStop = True
        Me.rbnSi.Text = "Si"
        Me.rbnSi.UseVisualStyleBackColor = True
        '
        'rbnNo
        '
        Me.rbnNo.AutoSize = True
        Me.rbnNo.Location = New System.Drawing.Point(194, 280)
        Me.rbnNo.Name = "rbnNo"
        Me.rbnNo.Size = New System.Drawing.Size(39, 17)
        Me.rbnNo.TabIndex = 46
        Me.rbnNo.TabStop = True
        Me.rbnNo.Text = "No"
        Me.rbnNo.UseVisualStyleBackColor = True
        '
        'FrmRecepcionPesadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 535)
        Me.Controls.Add(Me.rbnNo)
        Me.Controls.Add(Me.rbnSi)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.chkBascula)
        Me.Controls.Add(Me.txtLeerPeso)
        Me.Controls.Add(Me.lblEstatus)
        Me.Controls.Add(Me.txtProveedor)
        Me.Controls.Add(Me.txtKilosRecibidos)
        Me.Controls.Add(Me.txtKilos2Pesada)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.txtPlacas)
        Me.Controls.Add(Me.txtConductor)
        Me.Controls.Add(Me.txtUnidad)
        Me.Controls.Add(Me.txtKilosEnviados)
        Me.Controls.Add(Me.txtKilos1Pesada)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbcOpcion)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbProveedor)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.mtbMenu)
        Me.Controls.Add(Me.Label17)
        Me.Name = "FrmRecepcionPesadas"
        Me.Text = "RECEPCIÓN DE PESADAS"
        Me.tbcOpcion.ResumeLayout(False)
        Me.tabGanado.ResumeLayout(False)
        Me.tabGanado.PerformLayout()
        CType(Me.dgvGanado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabIngredientes.ResumeLayout(False)
        Me.tabIngredientes.PerformLayout()
        Me.tabOtros.ResumeLayout(False)
        Me.tabOtros.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtbMenu As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtFolio As Integralab.Controles.TextBoxMejorado
    Friend WithEvents cmbProveedor As Integralab.Controles.ComboBoxMejorado
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbcOpcion As System.Windows.Forms.TabControl
    Friend WithEvents tabGanado As System.Windows.Forms.TabPage
    Friend WithEvents tabIngredientes As System.Windows.Forms.TabPage
    Friend WithEvents tabOtros As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtKilos1Pesada As Integralab.Controles.TextBoxMejorado
    Friend WithEvents txtKilosEnviados As Integralab.Controles.TextBoxMejorado
    Friend WithEvents txtUnidad As Integralab.Controles.TextBoxMejorado
    Friend WithEvents txtConductor As Integralab.Controles.TextBoxMejorado
    Friend WithEvents txtPlacas As Integralab.Controles.TextBoxMejorado
    Friend WithEvents txtObservaciones As Integralab.Controles.TextBoxMejorado
    Friend WithEvents dgvGanado As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtKilosRecibidos As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtKilos2Pesada As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtProveedor As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents cmbProducto As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtProducto As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoProducto As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents TipoGanado As ClasesNegocio.TipoGanadoColecttionClass
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtTotalCabezas As Integralab.Controles.TextBoxMejorado
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents txtLeerPeso As wclTextBoxSerial.TextBoxSerial
    Friend WithEvents chkBascula As System.Windows.Forms.CheckBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents rbnSi As System.Windows.Forms.RadioButton
    Friend WithEvents rbnNo As System.Windows.Forms.RadioButton
    Friend WithEvents clmCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTipoGanado As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents clmCabezas As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
