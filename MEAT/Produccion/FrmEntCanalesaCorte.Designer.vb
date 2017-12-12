<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEntCanalesaCorte
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtTotalKilos = New System.Windows.Forms.TextBox
        Me.txtTotalCanales = New System.Windows.Forms.TextBox
        Me.txtProductor = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtpFechaSacrificio = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtLoteSacrificio = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtFolioCanal = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtLoteRastro = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtKilosaCorte = New System.Windows.Forms.TextBox
        Me.txtlectorPeso = New wclTextBoxSerial.TextBoxSerial
        Me.chkActivarLectura = New System.Windows.Forms.CheckBox
        Me.txtCodCliente = New System.Windows.Forms.TextBox
        Me.txtLoteCorte = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.dtpFechaCorte = New System.Windows.Forms.DateTimePicker
        Me.txtNoCanales = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.dgvCanales = New System.Windows.Forms.DataGridView
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtLado = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtNoRes = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFolioSacrificio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmRes = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FolioCanal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KilosCalientes = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KilosBascula = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFolioCanal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFolioMovimientoAlmacen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFolioMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmConsecutivo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvCanales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Kilogramos :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Canales :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 244)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Kgrs. a Corte :"
        '
        'txtTotalKilos
        '
        Me.txtTotalKilos.Enabled = False
        Me.txtTotalKilos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalKilos.Location = New System.Drawing.Point(76, 56)
        Me.txtTotalKilos.Name = "txtTotalKilos"
        Me.txtTotalKilos.Size = New System.Drawing.Size(126, 29)
        Me.txtTotalKilos.TabIndex = 30
        Me.txtTotalKilos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalCanales
        '
        Me.txtTotalCanales.Enabled = False
        Me.txtTotalCanales.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCanales.Location = New System.Drawing.Point(112, 21)
        Me.txtTotalCanales.Name = "txtTotalCanales"
        Me.txtTotalCanales.Size = New System.Drawing.Size(90, 29)
        Me.txtTotalCanales.TabIndex = 29
        Me.txtTotalCanales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtProductor
        '
        Me.txtProductor.Enabled = False
        Me.txtProductor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductor.Location = New System.Drawing.Point(184, 156)
        Me.txtProductor.Name = "txtProductor"
        Me.txtProductor.Size = New System.Drawing.Size(352, 29)
        Me.txtProductor.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Introductor :"
        '
        'dtpFechaSacrificio
        '
        Me.dtpFechaSacrificio.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFechaSacrificio.Enabled = False
        Me.dtpFechaSacrificio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaSacrificio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaSacrificio.Location = New System.Drawing.Point(404, 40)
        Me.dtpFechaSacrificio.Name = "dtpFechaSacrificio"
        Me.dtpFechaSacrificio.Size = New System.Drawing.Size(131, 29)
        Me.dtpFechaSacrificio.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(309, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Fecha Sacrificio :"
        '
        'txtLoteSacrificio
        '
        Me.txtLoteSacrificio.Enabled = False
        Me.txtLoteSacrificio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoteSacrificio.Location = New System.Drawing.Point(94, 51)
        Me.txtLoteSacrificio.Name = "txtLoteSacrificio"
        Me.txtLoteSacrificio.Size = New System.Drawing.Size(175, 29)
        Me.txtLoteSacrificio.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Lote Sacrificio :"
        '
        'txtFolioCanal
        '
        Me.txtFolioCanal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFolioCanal.Location = New System.Drawing.Point(94, 16)
        Me.txtFolioCanal.Name = "txtFolioCanal"
        Me.txtFolioCanal.Size = New System.Drawing.Size(175, 29)
        Me.txtFolioCanal.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Folio Canal :"
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
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 579)
        Me.mtb.TabIndex = 48
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(567, 32)
        Me.Label17.TabIndex = 47
        Me.Label17.Text = "Entrada de Canales a Corte"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtLoteRastro)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.dtpFechaSacrificio)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtKilosaCorte)
        Me.GroupBox2.Controls.Add(Me.txtlectorPeso)
        Me.GroupBox2.Controls.Add(Me.chkActivarLectura)
        Me.GroupBox2.Controls.Add(Me.txtCodCliente)
        Me.GroupBox2.Controls.Add(Me.txtLoteCorte)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.dtpFechaCorte)
        Me.GroupBox2.Controls.Add(Me.txtNoCanales)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtLado)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtNoRes)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtFolioCanal)
        Me.GroupBox2.Controls.Add(Me.txtLoteSacrificio)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtProductor)
        Me.GroupBox2.Location = New System.Drawing.Point(47, 35)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(562, 537)
        Me.GroupBox2.TabIndex = 49
        Me.GroupBox2.TabStop = False
        '
        'txtLoteRastro
        '
        Me.txtLoteRastro.Enabled = False
        Me.txtLoteRastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoteRastro.Location = New System.Drawing.Point(94, 86)
        Me.txtLoteRastro.Name = "txtLoteRastro"
        Me.txtLoteRastro.Size = New System.Drawing.Size(175, 29)
        Me.txtLoteRastro.TabIndex = 99
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 94)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 13)
        Me.Label14.TabIndex = 98
        Me.Label14.Text = "Lote Rastro :"
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label13.Location = New System.Drawing.Point(275, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(150, 32)
        Me.Label13.TabIndex = 95
        Me.Label13.Text = "Precione F3 para buscar canales recibidos."
        '
        'txtKilosaCorte
        '
        Me.txtKilosaCorte.AcceptsReturn = True
        Me.txtKilosaCorte.BackColor = System.Drawing.SystemColors.Window
        Me.txtKilosaCorte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtKilosaCorte.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKilosaCorte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKilosaCorte.Location = New System.Drawing.Point(94, 226)
        Me.txtKilosaCorte.MaxLength = 0
        Me.txtKilosaCorte.Name = "txtKilosaCorte"
        Me.txtKilosaCorte.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtKilosaCorte.Size = New System.Drawing.Size(161, 50)
        Me.txtKilosaCorte.TabIndex = 97
        Me.txtKilosaCorte.Text = "0.00"
        Me.txtKilosaCorte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtlectorPeso
        '
        Me.txtlectorPeso.BaudRate = 9600
        Me.txtlectorPeso.DataBit = 8
        Me.txtlectorPeso.Format = wclTextBoxSerial.TextBoxSerial.FormatoDatos.Ascii
        Me.txtlectorPeso.Location = New System.Drawing.Point(184, 191)
        Me.txtlectorPeso.Name = "txtlectorPeso"
        Me.txtlectorPeso.Parity = wclTextBoxSerial.Rs232.DataParity.Parity_None
        Me.txtlectorPeso.Port = 1
        Me.txtlectorPeso.Size = New System.Drawing.Size(100, 20)
        Me.txtlectorPeso.StopBit = wclTextBoxSerial.Rs232.DataStopBit.StopBit_1
        Me.txtlectorPeso.TabIndex = 96
        Me.txtlectorPeso.TimeOut = 1500
        Me.txtlectorPeso.TimeToWaitForMoreData = 300
        Me.txtlectorPeso.Visible = False
        '
        'chkActivarLectura
        '
        Me.chkActivarLectura.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkActivarLectura.Location = New System.Drawing.Point(261, 226)
        Me.chkActivarLectura.Name = "chkActivarLectura"
        Me.chkActivarLectura.Size = New System.Drawing.Size(76, 49)
        Me.chkActivarLectura.TabIndex = 93
        Me.chkActivarLectura.Text = "Lectura de Peso Desactivada"
        Me.chkActivarLectura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkActivarLectura.UseVisualStyleBackColor = True
        '
        'txtCodCliente
        '
        Me.txtCodCliente.Enabled = False
        Me.txtCodCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodCliente.Location = New System.Drawing.Point(94, 156)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.Size = New System.Drawing.Size(81, 29)
        Me.txtCodCliente.TabIndex = 92
        '
        'txtLoteCorte
        '
        Me.txtLoteCorte.Enabled = False
        Me.txtLoteCorte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoteCorte.Location = New System.Drawing.Point(404, 75)
        Me.txtLoteCorte.Name = "txtLoteCorte"
        Me.txtLoteCorte.Size = New System.Drawing.Size(131, 26)
        Me.txtLoteCorte.TabIndex = 91
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(310, 82)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 90
        Me.Label12.Text = "Lote Corte :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(310, 115)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 13)
        Me.Label11.TabIndex = 88
        Me.Label11.Text = "Fecha Corte :"
        '
        'dtpFechaCorte
        '
        Me.dtpFechaCorte.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFechaCorte.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaCorte.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaCorte.Location = New System.Drawing.Point(404, 107)
        Me.dtpFechaCorte.Name = "dtpFechaCorte"
        Me.dtpFechaCorte.Size = New System.Drawing.Size(131, 29)
        Me.dtpFechaCorte.TabIndex = 89
        '
        'txtNoCanales
        '
        Me.txtNoCanales.Enabled = False
        Me.txtNoCanales.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoCanales.Location = New System.Drawing.Point(94, 191)
        Me.txtNoCanales.Name = "txtNoCanales"
        Me.txtNoCanales.ReadOnly = True
        Me.txtNoCanales.Size = New System.Drawing.Size(81, 29)
        Me.txtNoCanales.TabIndex = 87
        Me.txtNoCanales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 193)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 86
        Me.Label9.Text = "No. Canales:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgvCanales)
        Me.GroupBox4.Location = New System.Drawing.Point(10, 289)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(541, 242)
        Me.GroupBox4.TabIndex = 83
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Detalle de canales "
        '
        'dgvCanales
        '
        Me.dgvCanales.AllowUserToAddRows = False
        Me.dgvCanales.AllowUserToDeleteRows = False
        Me.dgvCanales.AllowUserToResizeRows = False
        Me.dgvCanales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCanales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCanales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmFolioSacrificio, Me.clmRes, Me.FolioCanal, Me.KilosCalientes, Me.KilosBascula, Me.clmFolioCanal, Me.clmFolioMovimientoAlmacen, Me.clmFolioMovimiento, Me.clmConsecutivo})
        Me.dgvCanales.Location = New System.Drawing.Point(6, 19)
        Me.dgvCanales.MultiSelect = False
        Me.dgvCanales.Name = "dgvCanales"
        Me.dgvCanales.ReadOnly = True
        Me.dgvCanales.RowHeadersVisible = False
        Me.dgvCanales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCanales.Size = New System.Drawing.Size(525, 217)
        Me.dgvCanales.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(151, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Lado :"
        '
        'txtLado
        '
        Me.txtLado.AcceptsReturn = True
        Me.txtLado.BackColor = System.Drawing.SystemColors.Window
        Me.txtLado.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLado.Enabled = False
        Me.txtLado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtLado.Location = New System.Drawing.Point(194, 121)
        Me.txtLado.MaxLength = 0
        Me.txtLado.Name = "txtLado"
        Me.txtLado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLado.Size = New System.Drawing.Size(42, 29)
        Me.txtLado.TabIndex = 81
        Me.txtLado.Text = "1"
        Me.txtLado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Num. Res :"
        '
        'txtNoRes
        '
        Me.txtNoRes.AcceptsReturn = True
        Me.txtNoRes.BackColor = System.Drawing.SystemColors.Window
        Me.txtNoRes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNoRes.Enabled = False
        Me.txtNoRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoRes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNoRes.Location = New System.Drawing.Point(94, 121)
        Me.txtNoRes.MaxLength = 0
        Me.txtNoRes.Name = "txtNoRes"
        Me.txtNoRes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNoRes.Size = New System.Drawing.Size(51, 29)
        Me.txtNoRes.TabIndex = 79
        Me.txtNoRes.Text = "1"
        Me.txtNoRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtTotalCanales)
        Me.GroupBox3.Controls.Add(Me.txtTotalKilos)
        Me.GroupBox3.Location = New System.Drawing.Point(343, 191)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(208, 92)
        Me.GroupBox3.TabIndex = 34
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Totales a Corte "
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdFolioCanal"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "Folio Canal"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 120
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "KgrsCalientes"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle5.Format = "N3"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn2.Frozen = True
        Me.DataGridViewTextBoxColumn2.HeaderText = "Kilos Calientes"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 180
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "KgrsEnCorte"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Format = "N3"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn3.Frozen = True
        Me.DataGridViewTextBoxColumn3.HeaderText = "Kilos a Corte"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 180
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "KgrsCalientes"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle7.Format = "N3"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn4.Frozen = True
        Me.DataGridViewTextBoxColumn4.HeaderText = "Kilos Calientes"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 120
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "KgrsEnCorte"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle8.Format = "N3"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn5.Frozen = True
        Me.DataGridViewTextBoxColumn5.HeaderText = "Kilos a Corte"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 120
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "IdFolioCanal"
        Me.DataGridViewTextBoxColumn6.Frozen = True
        Me.DataGridViewTextBoxColumn6.HeaderText = "Folio Canal"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'clmFolioSacrificio
        '
        Me.clmFolioSacrificio.DataPropertyName = "FolioSacrificio"
        Me.clmFolioSacrificio.Frozen = True
        Me.clmFolioSacrificio.HeaderText = "Folio Sacrificio"
        Me.clmFolioSacrificio.Name = "clmFolioSacrificio"
        Me.clmFolioSacrificio.ReadOnly = True
        '
        'clmRes
        '
        Me.clmRes.DataPropertyName = "Res"
        Me.clmRes.Frozen = True
        Me.clmRes.HeaderText = "Res"
        Me.clmRes.Name = "clmRes"
        Me.clmRes.ReadOnly = True
        Me.clmRes.Width = 70
        '
        'FolioCanal
        '
        Me.FolioCanal.DataPropertyName = "Lado"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.FolioCanal.DefaultCellStyle = DataGridViewCellStyle1
        Me.FolioCanal.Frozen = True
        Me.FolioCanal.HeaderText = "Lado"
        Me.FolioCanal.Name = "FolioCanal"
        Me.FolioCanal.ReadOnly = True
        Me.FolioCanal.Width = 70
        '
        'KilosCalientes
        '
        Me.KilosCalientes.DataPropertyName = "KgrsCalientes"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "N3"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.KilosCalientes.DefaultCellStyle = DataGridViewCellStyle2
        Me.KilosCalientes.Frozen = True
        Me.KilosCalientes.HeaderText = "Kilos Calientes"
        Me.KilosCalientes.Name = "KilosCalientes"
        Me.KilosCalientes.ReadOnly = True
        Me.KilosCalientes.Width = 120
        '
        'KilosBascula
        '
        Me.KilosBascula.DataPropertyName = "KgrsEnCorte"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "N3"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.KilosBascula.DefaultCellStyle = DataGridViewCellStyle3
        Me.KilosBascula.Frozen = True
        Me.KilosBascula.HeaderText = "Kilos a Corte"
        Me.KilosBascula.Name = "KilosBascula"
        Me.KilosBascula.ReadOnly = True
        Me.KilosBascula.Width = 120
        '
        'clmFolioCanal
        '
        Me.clmFolioCanal.DataPropertyName = "IdFolioCanal"
        Me.clmFolioCanal.Frozen = True
        Me.clmFolioCanal.HeaderText = "Folio Canal"
        Me.clmFolioCanal.Name = "clmFolioCanal"
        Me.clmFolioCanal.ReadOnly = True
        Me.clmFolioCanal.Visible = False
        '
        'clmFolioMovimientoAlmacen
        '
        Me.clmFolioMovimientoAlmacen.DataPropertyName = "IdFolioMovimientoAlmacen"
        Me.clmFolioMovimientoAlmacen.Frozen = True
        Me.clmFolioMovimientoAlmacen.HeaderText = "Folio Movimiento Almacen"
        Me.clmFolioMovimientoAlmacen.Name = "clmFolioMovimientoAlmacen"
        Me.clmFolioMovimientoAlmacen.ReadOnly = True
        Me.clmFolioMovimientoAlmacen.Visible = False
        '
        'clmFolioMovimiento
        '
        Me.clmFolioMovimiento.DataPropertyName = "FolioMovimiento"
        Me.clmFolioMovimiento.Frozen = True
        Me.clmFolioMovimiento.HeaderText = "Folio Movimiento"
        Me.clmFolioMovimiento.Name = "clmFolioMovimiento"
        Me.clmFolioMovimiento.ReadOnly = True
        Me.clmFolioMovimiento.Visible = False
        '
        'clmConsecutivo
        '
        Me.clmConsecutivo.DataPropertyName = "Consecutivo"
        Me.clmConsecutivo.Frozen = True
        Me.clmConsecutivo.HeaderText = "Consecutivo"
        Me.clmConsecutivo.Name = "clmConsecutivo"
        Me.clmConsecutivo.ReadOnly = True
        Me.clmConsecutivo.Visible = False
        '
        'FrmEntCanalesaCorte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 579)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmEntCanalesaCorte"
        Me.Text = "Entrada de Canales a Corte"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvCanales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTotalKilos As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalCanales As System.Windows.Forms.TextBox
    Friend WithEvents txtProductor As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaSacrificio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLoteSacrificio As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFolioCanal As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents txtLado As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents txtNoRes As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvCanales As System.Windows.Forms.DataGridView
    Friend WithEvents txtNoCanales As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaCorte As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtLoteCorte As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCodCliente As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkActivarLectura As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtlectorPeso As wclTextBoxSerial.TextBoxSerial
    Public WithEvents txtKilosaCorte As System.Windows.Forms.TextBox
    Friend WithEvents txtLoteRastro As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFolioSacrificio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmRes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FolioCanal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosCalientes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosBascula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFolioCanal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFolioMovimientoAlmacen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFolioMovimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmConsecutivo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
