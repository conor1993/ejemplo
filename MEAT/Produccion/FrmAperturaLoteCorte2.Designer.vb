<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAperturaLoteCorte2
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFechaCaducidad = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDiasCaducidad = New System.Windows.Forms.TextBox()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.dtpFechaSacrificio = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpFechaLoteCorte = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFolioSacrificio = New System.Windows.Forms.TextBox()
        Me.txtLoteCorte = New System.Windows.Forms.TextBox()
        Me.lblEstatus = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNoPiezas = New IntegraLab.Controles.TextBoxMejorado()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtKilosRecibidos = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CmbTipoGanado = New System.Windows.Forms.ComboBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtNoFactura = New System.Windows.Forms.TextBox()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtUnidad = New System.Windows.Forms.TextBox()
        Me.txtConductor = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPlacas = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmbProveedor = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmbComprador = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CmbLugarCompra = New System.Windows.Forms.ComboBox()
        Me.txtHorasViaje = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.tbOtrosGastos = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.DgvConceptoGastos = New System.Windows.Forms.DataGridView()
        Me.clmcmbConceptoGasto = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.clmtxtIva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmtxtImporteGasto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmRenglon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtIVA = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.TxtFolio = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tbDatosPago = New System.Windows.Forms.TabPage()
        Me.dtpFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtDiasDeCredito = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tabControl.SuspendLayout()
        Me.tbOtrosGastos.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgvConceptoGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbDatosPago.SuspendLayout()
        Me.SuspendLayout()
        '
        'MEAToolBar1
        '
        Me.MEAToolBar1.ButtonSize = New System.Drawing.Size(50, 50)
        Me.MEAToolBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MEAToolBar1.DropDownArrows = True
        Me.MEAToolBar1.HabilitarBorrar = True
        Me.MEAToolBar1.HabilitarBuscar = True
        Me.MEAToolBar1.HabilitarCancelar = True
        Me.MEAToolBar1.HabilitarEditar = True
        Me.MEAToolBar1.HabilitarGuardar = True
        Me.MEAToolBar1.HabilitarImprimir = True
        Me.MEAToolBar1.HabilitarLimpiar = True
        Me.MEAToolBar1.HabilitarNuevo = True
        Me.MEAToolBar1.HabilitarSalir = True
        Me.MEAToolBar1.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32
        Me.MEAToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.MEAToolBar1.MostrarBorrar = False
        Me.MEAToolBar1.MostrarBuscar = True
        Me.MEAToolBar1.MostrarCancelar = False
        Me.MEAToolBar1.MostrarEditar = False
        Me.MEAToolBar1.MostrarGuardar = True
        Me.MEAToolBar1.MostrarImprimir = True
        Me.MEAToolBar1.MostrarLimpiar = False
        Me.MEAToolBar1.MostrarNuevo = False
        Me.MEAToolBar1.MostrarSalir = True
        Me.MEAToolBar1.Name = "MEAToolBar1"
        Me.MEAToolBar1.ShowToolTips = True
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 907)
        Me.MEAToolBar1.TabIndex = 41
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(61, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(607, 32)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = "Apertura de Lotes de Corte"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpFechaCaducidad)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtDiasCaducidad)
        Me.GroupBox1.Controls.Add(Me.txtCodCliente)
        Me.GroupBox1.Controls.Add(Me.dtpFechaSacrificio)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.dtpFechaLoteCorte)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtFolioSacrificio)
        Me.GroupBox1.Controls.Add(Me.txtLoteCorte)
        Me.GroupBox1.Controls.Add(Me.lblEstatus)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(635, 212)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        '
        'txtObservaciones
        '
        Me.txtObservaciones.AcceptsReturn = True
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Location = New System.Drawing.Point(108, 124)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(295, 69)
        Me.txtObservaciones.TabIndex = 59
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Observaciones :"
        '
        'dtpFechaCaducidad
        '
        Me.dtpFechaCaducidad.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFechaCaducidad.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaCaducidad.Location = New System.Drawing.Point(311, 98)
        Me.dtpFechaCaducidad.Name = "dtpFechaCaducidad"
        Me.dtpFechaCaducidad.Size = New System.Drawing.Size(92, 20)
        Me.dtpFechaCaducidad.TabIndex = 57
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(208, 102)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 13)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "Fecha Caducidad :"
        '
        'txtDiasCaducidad
        '
        Me.txtDiasCaducidad.AcceptsReturn = True
        Me.txtDiasCaducidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDiasCaducidad.Location = New System.Drawing.Point(108, 100)
        Me.txtDiasCaducidad.Name = "txtDiasCaducidad"
        Me.txtDiasCaducidad.Size = New System.Drawing.Size(50, 20)
        Me.txtDiasCaducidad.TabIndex = 55
        '
        'txtCodCliente
        '
        Me.txtCodCliente.AcceptsReturn = True
        Me.txtCodCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodCliente.Location = New System.Drawing.Point(108, 74)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.Size = New System.Drawing.Size(50, 20)
        Me.txtCodCliente.TabIndex = 54
        '
        'dtpFechaSacrificio
        '
        Me.dtpFechaSacrificio.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFechaSacrificio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaSacrificio.Location = New System.Drawing.Point(311, 47)
        Me.dtpFechaSacrificio.Name = "dtpFechaSacrificio"
        Me.dtpFechaSacrificio.Size = New System.Drawing.Size(92, 20)
        Me.dtpFechaSacrificio.TabIndex = 53
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(216, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 13)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Fecha Sacrificio :"
        '
        'dtpFechaLoteCorte
        '
        Me.dtpFechaLoteCorte.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFechaLoteCorte.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaLoteCorte.Location = New System.Drawing.Point(311, 21)
        Me.dtpFechaLoteCorte.Name = "dtpFechaLoteCorte"
        Me.dtpFechaLoteCorte.Size = New System.Drawing.Size(92, 20)
        Me.dtpFechaLoteCorte.TabIndex = 51
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Dias Caducidad :"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(163, 74)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(240, 20)
        Me.txtNombre.TabIndex = 46
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Cliente :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(216, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Fecha Corte :"
        '
        'txtFolioSacrificio
        '
        Me.txtFolioSacrificio.AcceptsReturn = True
        Me.txtFolioSacrificio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFolioSacrificio.Location = New System.Drawing.Point(108, 48)
        Me.txtFolioSacrificio.Name = "txtFolioSacrificio"
        Me.txtFolioSacrificio.Size = New System.Drawing.Size(102, 20)
        Me.txtFolioSacrificio.TabIndex = 36
        '
        'txtLoteCorte
        '
        Me.txtLoteCorte.Enabled = False
        Me.txtLoteCorte.Location = New System.Drawing.Point(108, 21)
        Me.txtLoteCorte.Name = "txtLoteCorte"
        Me.txtLoteCorte.Size = New System.Drawing.Size(102, 20)
        Me.txtLoteCorte.TabIndex = 30
        Me.txtLoteCorte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblEstatus
        '
        Me.lblEstatus.AutoSize = True
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(492, 21)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(104, 24)
        Me.lblEstatus.TabIndex = 29
        Me.lblEstatus.Text = "ESTATUS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Folio de Sacrifio :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lote Corte :"
        '
        'txtNoPiezas
        '
        Me.txtNoPiezas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNoPiezas.ComboBoxEnlazado = Nothing
        Me.txtNoPiezas.Decimales = 0
        Me.txtNoPiezas.Location = New System.Drawing.Point(137, 36)
        Me.txtNoPiezas.MaxLength = 3000
        Me.txtNoPiezas.MensajeCombo = "Seleccionar un item..."
        Me.txtNoPiezas.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtNoPiezas.Name = "txtNoPiezas"
        Me.txtNoPiezas.SiguienteControl = Me.txtObservaciones
        Me.txtNoPiezas.Size = New System.Drawing.Size(96, 20)
        Me.txtNoPiezas.TabIndex = 2
        Me.txtNoPiezas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtNoPiezas.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtNoPiezas.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtNoPiezas.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 36)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 13)
        Me.Label14.TabIndex = 87
        Me.Label14.Text = "No. de  piezas:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "Kilos Recibidos :"
        '
        'txtKilosRecibidos
        '
        Me.txtKilosRecibidos.Enabled = False
        Me.txtKilosRecibidos.Location = New System.Drawing.Point(137, 66)
        Me.txtKilosRecibidos.Name = "txtKilosRecibidos"
        Me.txtKilosRecibidos.Size = New System.Drawing.Size(96, 20)
        Me.txtKilosRecibidos.TabIndex = 88
        Me.txtKilosRecibidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 105)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 91
        Me.Label13.Text = "Producto :"
        '
        'CmbTipoGanado
        '
        Me.CmbTipoGanado.FormattingEnabled = True
        Me.CmbTipoGanado.Location = New System.Drawing.Point(137, 105)
        Me.CmbTipoGanado.Name = "CmbTipoGanado"
        Me.CmbTipoGanado.Size = New System.Drawing.Size(459, 21)
        Me.CmbTipoGanado.TabIndex = 90
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(365, 39)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(89, 13)
        Me.Label33.TabIndex = 105
        Me.Label33.Text = "Num. de Factura:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(365, 62)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(45, 13)
        Me.Label25.TabIndex = 106
        Me.Label25.Text = "Importe:"
        '
        'txtNoFactura
        '
        Me.txtNoFactura.Location = New System.Drawing.Point(454, 36)
        Me.txtNoFactura.Name = "txtNoFactura"
        Me.txtNoFactura.Size = New System.Drawing.Size(142, 20)
        Me.txtNoFactura.TabIndex = 107
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(454, 59)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(142, 20)
        Me.txtImporte.TabIndex = 108
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 146)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 13)
        Me.Label15.TabIndex = 117
        Me.Label15.Text = "Unidad :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 169)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 118
        Me.Label12.Text = "Conductor :"
        '
        'txtUnidad
        '
        Me.txtUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUnidad.Location = New System.Drawing.Point(137, 143)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(459, 20)
        Me.txtUnidad.TabIndex = 109
        '
        'txtConductor
        '
        Me.txtConductor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConductor.Location = New System.Drawing.Point(137, 166)
        Me.txtConductor.Name = "txtConductor"
        Me.txtConductor.Size = New System.Drawing.Size(459, 20)
        Me.txtConductor.TabIndex = 110
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 119
        Me.Label8.Text = "Placas :"
        '
        'txtPlacas
        '
        Me.txtPlacas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlacas.Location = New System.Drawing.Point(137, 189)
        Me.txtPlacas.Name = "txtPlacas"
        Me.txtPlacas.Size = New System.Drawing.Size(102, 20)
        Me.txtPlacas.TabIndex = 111
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 289)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 13)
        Me.Label11.TabIndex = 120
        Me.Label11.Text = "Observaciones :"
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Location = New System.Drawing.Point(137, 289)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(459, 61)
        Me.TextBox1.TabIndex = 116
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(8, 216)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(62, 13)
        Me.Label19.TabIndex = 121
        Me.Label19.Text = "Proveedor :"
        '
        'cmbProveedor
        '
        Me.cmbProveedor.DisplayMember = "RazonSocial"
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(137, 213)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(459, 21)
        Me.cmbProveedor.TabIndex = 113
        Me.cmbProveedor.ValueMember = "Codigo"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(8, 266)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 13)
        Me.Label18.TabIndex = 122
        Me.Label18.Text = "Comprador :"
        '
        'cmbComprador
        '
        Me.cmbComprador.DisplayMember = "NomCompleto"
        Me.cmbComprador.FormattingEnabled = True
        Me.cmbComprador.Location = New System.Drawing.Point(137, 263)
        Me.cmbComprador.Name = "cmbComprador"
        Me.cmbComprador.Size = New System.Drawing.Size(459, 21)
        Me.cmbComprador.TabIndex = 115
        Me.cmbComprador.ValueMember = "IdComprador"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(8, 241)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 13)
        Me.Label16.TabIndex = 123
        Me.Label16.Text = "Lugar de Compra:"
        '
        'CmbLugarCompra
        '
        Me.CmbLugarCompra.FormattingEnabled = True
        Me.CmbLugarCompra.Location = New System.Drawing.Point(137, 238)
        Me.CmbLugarCompra.Name = "CmbLugarCompra"
        Me.CmbLugarCompra.Size = New System.Drawing.Size(459, 21)
        Me.CmbLugarCompra.TabIndex = 114
        '
        'txtHorasViaje
        '
        Me.txtHorasViaje.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtHorasViaje.Location = New System.Drawing.Point(322, 189)
        Me.txtHorasViaje.Name = "txtHorasViaje"
        Me.txtHorasViaje.Size = New System.Drawing.Size(56, 20)
        Me.txtHorasViaje.TabIndex = 112
        Me.txtHorasViaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tabControl)
        Me.GroupBox2.Controls.Add(Me.txtHorasViaje)
        Me.GroupBox2.Controls.Add(Me.CmbLugarCompra)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.cmbComprador)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.cmbProveedor)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtPlacas)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtConductor)
        Me.GroupBox2.Controls.Add(Me.txtUnidad)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtImporte)
        Me.GroupBox2.Controls.Add(Me.txtNoFactura)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label33)
        Me.GroupBox2.Controls.Add(Me.CmbTipoGanado)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtKilosRecibidos)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtNoPiezas)
        Me.GroupBox2.Location = New System.Drawing.Point(56, 254)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(635, 641)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        '
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.tbOtrosGastos)
        Me.tabControl.Controls.Add(Me.tbDatosPago)
        Me.tabControl.Location = New System.Drawing.Point(9, 361)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(609, 274)
        Me.tabControl.TabIndex = 124
        '
        'tbOtrosGastos
        '
        Me.tbOtrosGastos.BackColor = System.Drawing.SystemColors.Menu
        Me.tbOtrosGastos.Controls.Add(Me.GroupBox3)
        Me.tbOtrosGastos.Controls.Add(Me.TxtFolio)
        Me.tbOtrosGastos.Controls.Add(Me.Label20)
        Me.tbOtrosGastos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbOtrosGastos.Location = New System.Drawing.Point(4, 22)
        Me.tbOtrosGastos.Name = "tbOtrosGastos"
        Me.tbOtrosGastos.Padding = New System.Windows.Forms.Padding(3)
        Me.tbOtrosGastos.Size = New System.Drawing.Size(601, 248)
        Me.tbOtrosGastos.TabIndex = 0
        Me.tbOtrosGastos.Text = "Otros Gastos"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.DgvConceptoGastos)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.txtSubTotal)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.txtIVA)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.txtTotal)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 32)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(586, 204)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Gastos de Transporte"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(7, 180)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(104, 13)
        Me.Label28.TabIndex = 98
        Me.Label28.Text = "<supr> Borrar fila"
        '
        'DgvConceptoGastos
        '
        Me.DgvConceptoGastos.AllowUserToDeleteRows = False
        Me.DgvConceptoGastos.AllowUserToResizeRows = False
        Me.DgvConceptoGastos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvConceptoGastos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvConceptoGastos.BackgroundColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvConceptoGastos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvConceptoGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvConceptoGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmcmbConceptoGasto, Me.clmtxtIva, Me.clmtxtImporteGasto, Me.clmRenglon})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvConceptoGastos.DefaultCellStyle = DataGridViewCellStyle4
        Me.DgvConceptoGastos.Location = New System.Drawing.Point(6, 18)
        Me.DgvConceptoGastos.MultiSelect = False
        Me.DgvConceptoGastos.Name = "DgvConceptoGastos"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvConceptoGastos.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DgvConceptoGastos.RowHeadersVisible = False
        Me.DgvConceptoGastos.Size = New System.Drawing.Size(574, 105)
        Me.DgvConceptoGastos.TabIndex = 22
        '
        'clmcmbConceptoGasto
        '
        Me.clmcmbConceptoGasto.DataPropertyName = "IdGasto"
        Me.clmcmbConceptoGasto.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.clmcmbConceptoGasto.FillWeight = 70.0!
        Me.clmcmbConceptoGasto.HeaderText = "Gasto"
        Me.clmcmbConceptoGasto.Name = "clmcmbConceptoGasto"
        Me.clmcmbConceptoGasto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'clmtxtIva
        '
        Me.clmtxtIva.DataPropertyName = "PorcentajeIva"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        Me.clmtxtIva.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmtxtIva.FillWeight = 10.0!
        Me.clmtxtIva.HeaderText = "Iva %"
        Me.clmtxtIva.Name = "clmtxtIva"
        '
        'clmtxtImporteGasto
        '
        Me.clmtxtImporteGasto.DataPropertyName = "ImporteGasto"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.clmtxtImporteGasto.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmtxtImporteGasto.FillWeight = 20.0!
        Me.clmtxtImporteGasto.HeaderText = "Importe"
        Me.clmtxtImporteGasto.Name = "clmtxtImporteGasto"
        '
        'clmRenglon
        '
        Me.clmRenglon.DataPropertyName = "Renglon"
        Me.clmRenglon.HeaderText = "Renglon"
        Me.clmRenglon.Name = "clmRenglon"
        Me.clmRenglon.Visible = False
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(385, 176)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(34, 13)
        Me.Label24.TabIndex = 14
        Me.Label24.Text = "Total:"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.AcceptsTab = True
        Me.txtSubTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSubTotal.Enabled = False
        Me.txtSubTotal.Location = New System.Drawing.Point(429, 129)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(152, 20)
        Me.txtSubTotal.TabIndex = 9
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(392, 154)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(27, 13)
        Me.Label23.TabIndex = 13
        Me.Label23.Text = "IVA:"
        '
        'txtIVA
        '
        Me.txtIVA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIVA.Enabled = False
        Me.txtIVA.Location = New System.Drawing.Point(429, 151)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.ReadOnly = True
        Me.txtIVA.Size = New System.Drawing.Size(152, 20)
        Me.txtIVA.TabIndex = 10
        Me.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(363, 132)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(56, 13)
        Me.Label22.TabIndex = 12
        Me.Label22.Text = "Sub Total:"
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(429, 173)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(152, 20)
        Me.txtTotal.TabIndex = 11
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtFolio
        '
        Me.TxtFolio.Enabled = False
        Me.TxtFolio.Location = New System.Drawing.Point(40, 6)
        Me.TxtFolio.Name = "TxtFolio"
        Me.TxtFolio.Size = New System.Drawing.Size(102, 20)
        Me.TxtFolio.TabIndex = 8
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(5, 9)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(32, 13)
        Me.Label20.TabIndex = 7
        Me.Label20.Text = "Folio:"
        '
        'tbDatosPago
        '
        Me.tbDatosPago.BackColor = System.Drawing.SystemColors.Menu
        Me.tbDatosPago.Controls.Add(Me.dtpFechaPago)
        Me.tbDatosPago.Controls.Add(Me.Label27)
        Me.tbDatosPago.Controls.Add(Me.Label26)
        Me.tbDatosPago.Controls.Add(Me.txtDiasDeCredito)
        Me.tbDatosPago.Location = New System.Drawing.Point(4, 22)
        Me.tbDatosPago.Name = "tbDatosPago"
        Me.tbDatosPago.Padding = New System.Windows.Forms.Padding(3)
        Me.tbDatosPago.Size = New System.Drawing.Size(601, 248)
        Me.tbDatosPago.TabIndex = 1
        Me.tbDatosPago.Text = "Datos de Pago"
        '
        'dtpFechaPago
        '
        Me.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaPago.Location = New System.Drawing.Point(99, 31)
        Me.dtpFechaPago.Name = "dtpFechaPago"
        Me.dtpFechaPago.Size = New System.Drawing.Size(105, 20)
        Me.dtpFechaPago.TabIndex = 19
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(6, 35)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(85, 13)
        Me.Label27.TabIndex = 28
        Me.Label27.Text = "Fecha del Pago:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(6, 13)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(84, 13)
        Me.Label26.TabIndex = 27
        Me.Label26.Text = "Dias De Crédito:"
        '
        'txtDiasDeCredito
        '
        Me.txtDiasDeCredito.Location = New System.Drawing.Point(99, 9)
        Me.txtDiasDeCredito.Name = "txtDiasDeCredito"
        Me.txtDiasDeCredito.ReadOnly = True
        Me.txtDiasDeCredito.Size = New System.Drawing.Size(105, 20)
        Me.txtDiasDeCredito.TabIndex = 26
        '
        'FrmAperturaLoteCorte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 907)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.Controls.Add(Me.Label17)
        Me.Name = "FrmAperturaLoteCorte"
        Me.Text = "Apertur de Lotes de Corte"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tabControl.ResumeLayout(False)
        Me.tbOtrosGastos.ResumeLayout(False)
        Me.tbOtrosGastos.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DgvConceptoGastos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbDatosPago.ResumeLayout(False)
        Me.tbDatosPago.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFolioSacrificio As System.Windows.Forms.TextBox
    Friend WithEvents txtLoteCorte As System.Windows.Forms.TextBox
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaLoteCorte As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaSacrificio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCodCliente As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaCaducidad As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDiasCaducidad As System.Windows.Forms.TextBox
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNoPiezas As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtKilosRecibidos As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CmbTipoGanado As System.Windows.Forms.ComboBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtNoFactura As System.Windows.Forms.TextBox
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtUnidad As System.Windows.Forms.TextBox
    Friend WithEvents txtConductor As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPlacas As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cmbComprador As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents CmbLugarCompra As System.Windows.Forms.ComboBox
    Friend WithEvents txtHorasViaje As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tabControl As System.Windows.Forms.TabControl
    Friend WithEvents tbOtrosGastos As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents DgvConceptoGastos As System.Windows.Forms.DataGridView
    Friend WithEvents clmcmbConceptoGasto As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents clmtxtIva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmtxtImporteGasto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmRenglon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtIVA As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents TxtFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents tbDatosPago As System.Windows.Forms.TabPage
    Friend WithEvents dtpFechaPago As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtDiasDeCredito As System.Windows.Forms.TextBox
End Class
