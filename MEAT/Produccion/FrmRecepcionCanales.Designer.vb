<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRecepcionCanales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRecepcionCanales))
        Me.mtb = New MEAToolBar.MEAToolBar()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Gb = New System.Windows.Forms.GroupBox()
        Me.txtLoteCorteRastro = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtProductor = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.dgvServicios = New System.Windows.Forms.DataGridView()
        Me.ServiciosC = New ClasesNegocio.ServiciosCollectionClass()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.RbtnMacho = New System.Windows.Forms.RadioButton()
        Me.rbtnHembra = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgvCanales = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTotalKilos = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotalKgrsCalientes = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotalCanales = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCantCanales = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtKilosRecibidos = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtKilosCalientes = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCanales = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtpHora = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpFechaCaptura = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtKgrsRecibidos = New System.Windows.Forms.TextBox()
        Me.chkActivarLectura = New System.Windows.Forms.CheckBox()
        Me.txtKgrsRecibidos2 = New wclTextBoxSerial.TextBoxSerial()
        Me.CmbCliente = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtLado = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNoRes = New System.Windows.Forms.TextBox()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me._LblEtiqueta_3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.dtpFechaSacrificio = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtLoteSacrificio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ppdVisor = New System.Windows.Forms.PrintPreviewDialog()
        Me.pdDocumento = New System.Drawing.Printing.PrintDocument()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tmActualizacion = New System.Windows.Forms.Timer(Me.components)
        Me.clmSeleccion = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmRegistro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFolioMov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCanal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmKilosCalientes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmKilosRecbidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gb.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgvServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvCanales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
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
        Me.mtb.MostrarLimpiar = False
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 584)
        Me.mtb.TabIndex = 46
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(965, 32)
        Me.Label17.TabIndex = 45
        Me.Label17.Text = "Entrada de Canales / Materia prima a Almacén"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Gb
        '
        Me.Gb.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gb.Controls.Add(Me.txtLoteCorteRastro)
        Me.Gb.Controls.Add(Me.Label3)
        Me.Gb.Controls.Add(Me.txtProductor)
        Me.Gb.Controls.Add(Me.GroupBox6)
        Me.Gb.Controls.Add(Me.GroupBox5)
        Me.Gb.Controls.Add(Me.GroupBox4)
        Me.Gb.Controls.Add(Me.GroupBox2)
        Me.Gb.Controls.Add(Me.txtCantCanales)
        Me.Gb.Controls.Add(Me.Label18)
        Me.Gb.Controls.Add(Me.Label16)
        Me.Gb.Controls.Add(Me.ComboBox2)
        Me.Gb.Controls.Add(Me.GroupBox1)
        Me.Gb.Controls.Add(Me.dtpHora)
        Me.Gb.Controls.Add(Me.Label11)
        Me.Gb.Controls.Add(Me.dtpFechaCaptura)
        Me.Gb.Controls.Add(Me.Label10)
        Me.Gb.Controls.Add(Me.GroupBox3)
        Me.Gb.Controls.Add(Me.ComboBox1)
        Me.Gb.Controls.Add(Me.dtpFechaSacrificio)
        Me.Gb.Controls.Add(Me.Label9)
        Me.Gb.Controls.Add(Me.txtLoteSacrificio)
        Me.Gb.Controls.Add(Me.Label2)
        Me.Gb.Controls.Add(Me.Label1)
        Me.Gb.Location = New System.Drawing.Point(56, 35)
        Me.Gb.Name = "Gb"
        Me.Gb.Size = New System.Drawing.Size(947, 537)
        Me.Gb.TabIndex = 47
        Me.Gb.TabStop = False
        '
        'txtLoteCorteRastro
        '
        Me.txtLoteCorteRastro.Enabled = False
        Me.txtLoteCorteRastro.Location = New System.Drawing.Point(343, 105)
        Me.txtLoteCorteRastro.Name = "txtLoteCorteRastro"
        Me.txtLoteCorteRastro.Size = New System.Drawing.Size(107, 20)
        Me.txtLoteCorteRastro.TabIndex = 86
        Me.txtLoteCorteRastro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(254, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "Lote de Rastro :"
        '
        'txtProductor
        '
        Me.txtProductor.Enabled = False
        Me.txtProductor.Location = New System.Drawing.Point(155, 52)
        Me.txtProductor.Name = "txtProductor"
        Me.txtProductor.Size = New System.Drawing.Size(295, 20)
        Me.txtProductor.TabIndex = 77
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.dgvServicios)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 133)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(444, 168)
        Me.GroupBox6.TabIndex = 84
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Servicios de maquila"
        '
        'dgvServicios
        '
        Me.dgvServicios.AllowUserToAddRows = False
        Me.dgvServicios.AllowUserToDeleteRows = False
        Me.dgvServicios.AllowUserToResizeRows = False
        Me.dgvServicios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvServicios.AutoGenerateColumns = False
        Me.dgvServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvServicios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmSeleccion, Me.CodigoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn})
        Me.dgvServicios.DataSource = Me.ServiciosC
        Me.dgvServicios.Location = New System.Drawing.Point(6, 19)
        Me.dgvServicios.MultiSelect = False
        Me.dgvServicios.Name = "dgvServicios"
        Me.dgvServicios.RowHeadersVisible = False
        Me.dgvServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvServicios.Size = New System.Drawing.Size(432, 143)
        Me.dgvServicios.TabIndex = 1
        '
        'ServiciosC
        '
        Me.ServiciosC.AllowEdit = True
        Me.ServiciosC.AllowNew = True
        Me.ServiciosC.AllowRemove = True
        Me.ServiciosC.MaximoElementosSeleccionados = 1
        Me.ServiciosC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.ServiciosC.MostrarAlertas = False
        Me.ServiciosC.Name = Nothing
        Me.ServiciosC.RaiseListChangedEvents = True
        Me.ServiciosC.Transaction = Nothing
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.RbtnMacho)
        Me.GroupBox5.Controls.Add(Me.rbtnHembra)
        Me.GroupBox5.Location = New System.Drawing.Point(466, 134)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(223, 45)
        Me.GroupBox5.TabIndex = 83
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Sexo"
        '
        'RbtnMacho
        '
        Me.RbtnMacho.AutoSize = True
        Me.RbtnMacho.Location = New System.Drawing.Point(113, 19)
        Me.RbtnMacho.Name = "RbtnMacho"
        Me.RbtnMacho.Size = New System.Drawing.Size(58, 17)
        Me.RbtnMacho.TabIndex = 1
        Me.RbtnMacho.Text = "Macho"
        Me.RbtnMacho.UseVisualStyleBackColor = True
        '
        'rbtnHembra
        '
        Me.rbtnHembra.AutoSize = True
        Me.rbtnHembra.Checked = True
        Me.rbtnHembra.Location = New System.Drawing.Point(23, 19)
        Me.rbtnHembra.Name = "rbtnHembra"
        Me.rbtnHembra.Size = New System.Drawing.Size(62, 17)
        Me.rbtnHembra.TabIndex = 0
        Me.rbtnHembra.TabStop = True
        Me.rbtnHembra.Text = "Hembra"
        Me.rbtnHembra.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgvCanales)
        Me.GroupBox4.Location = New System.Drawing.Point(466, 186)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(469, 345)
        Me.GroupBox4.TabIndex = 72
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Canales / Combos Capturados"
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
        Me.dgvCanales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmRegistro, Me.clmFolioMov, Me.clmCanal, Me.clmKilosCalientes, Me.clmKilosRecbidos, Me.clmEstatus})
        Me.dgvCanales.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.dgvCanales.Location = New System.Drawing.Point(6, 17)
        Me.dgvCanales.MultiSelect = False
        Me.dgvCanales.Name = "dgvCanales"
        Me.dgvCanales.RowHeadersVisible = False
        Me.dgvCanales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvCanales.Size = New System.Drawing.Size(457, 322)
        Me.dgvCanales.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTotalKilos)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtTotalKgrsCalientes)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtTotalCanales)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(706, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(229, 102)
        Me.GroupBox2.TabIndex = 70
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Total de por Lote de Sacrificio / Embarque"
        '
        'txtTotalKilos
        '
        Me.txtTotalKilos.Enabled = False
        Me.txtTotalKilos.Location = New System.Drawing.Point(95, 70)
        Me.txtTotalKilos.Name = "txtTotalKilos"
        Me.txtTotalKilos.Size = New System.Drawing.Size(93, 20)
        Me.txtTotalKilos.TabIndex = 75
        Me.txtTotalKilos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Kilos recibidos  :"
        '
        'txtTotalKgrsCalientes
        '
        Me.txtTotalKgrsCalientes.Enabled = False
        Me.txtTotalKgrsCalientes.Location = New System.Drawing.Point(95, 45)
        Me.txtTotalKgrsCalientes.Name = "txtTotalKgrsCalientes"
        Me.txtTotalKgrsCalientes.Size = New System.Drawing.Size(93, 20)
        Me.txtTotalKgrsCalientes.TabIndex = 73
        Me.txtTotalKgrsCalientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Kilos calientes :"
        '
        'txtTotalCanales
        '
        Me.txtTotalCanales.Enabled = False
        Me.txtTotalCanales.Location = New System.Drawing.Point(95, 19)
        Me.txtTotalCanales.Name = "txtTotalCanales"
        Me.txtTotalCanales.Size = New System.Drawing.Size(93, 20)
        Me.txtTotalCanales.TabIndex = 71
        Me.txtTotalCanales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Piezas :"
        '
        'txtCantCanales
        '
        Me.txtCantCanales.Enabled = False
        Me.txtCantCanales.Location = New System.Drawing.Point(155, 105)
        Me.txtCantCanales.Name = "txtCantCanales"
        Me.txtCantCanales.Size = New System.Drawing.Size(93, 20)
        Me.txtCantCanales.TabIndex = 82
        Me.txtCantCanales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(8, 108)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(140, 13)
        Me.Label18.TabIndex = 81
        Me.Label18.Text = "Cant. de Canales / Combos:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(8, 81)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(34, 13)
        Me.Label16.TabIndex = 80
        Me.Label16.Text = "Lote :"
        '
        'ComboBox2
        '
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(155, 78)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(295, 21)
        Me.ComboBox2.TabIndex = 79
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtKilosRecibidos)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtKilosCalientes)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtCanales)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Location = New System.Drawing.Point(466, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 102)
        Me.GroupBox1.TabIndex = 78
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Total de Canales / Combos en Almacén"
        '
        'txtKilosRecibidos
        '
        Me.txtKilosRecibidos.Enabled = False
        Me.txtKilosRecibidos.Location = New System.Drawing.Point(98, 71)
        Me.txtKilosRecibidos.Name = "txtKilosRecibidos"
        Me.txtKilosRecibidos.Size = New System.Drawing.Size(111, 20)
        Me.txtKilosRecibidos.TabIndex = 75
        Me.txtKilosRecibidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 74)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 13)
        Me.Label13.TabIndex = 74
        Me.Label13.Text = "Kilos recibidos  :"
        '
        'txtKilosCalientes
        '
        Me.txtKilosCalientes.Enabled = False
        Me.txtKilosCalientes.Location = New System.Drawing.Point(98, 45)
        Me.txtKilosCalientes.Name = "txtKilosCalientes"
        Me.txtKilosCalientes.Size = New System.Drawing.Size(111, 20)
        Me.txtKilosCalientes.TabIndex = 73
        Me.txtKilosCalientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 13)
        Me.Label14.TabIndex = 72
        Me.Label14.Text = "Kilos calientes :"
        '
        'txtCanales
        '
        Me.txtCanales.Enabled = False
        Me.txtCanales.Location = New System.Drawing.Point(98, 19)
        Me.txtCanales.Name = "txtCanales"
        Me.txtCanales.Size = New System.Drawing.Size(111, 20)
        Me.txtCanales.TabIndex = 71
        Me.txtCanales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(15, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Piezas :"
        '
        'dtpHora
        '
        Me.dtpHora.Enabled = False
        Me.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHora.Location = New System.Drawing.Point(847, 160)
        Me.dtpHora.Name = "dtpHora"
        Me.dtpHora.Size = New System.Drawing.Size(85, 20)
        Me.dtpHora.TabIndex = 76
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(762, 164)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 75
        Me.Label11.Text = "Hora :"
        '
        'dtpFechaCaptura
        '
        Me.dtpFechaCaptura.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFechaCaptura.Enabled = False
        Me.dtpFechaCaptura.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaCaptura.Location = New System.Drawing.Point(847, 134)
        Me.dtpFechaCaptura.Name = "dtpFechaCaptura"
        Me.dtpFechaCaptura.Size = New System.Drawing.Size(85, 20)
        Me.dtpFechaCaptura.TabIndex = 74
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(762, 138)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 13)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "Fecha Captura :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtKgrsRecibidos)
        Me.GroupBox3.Controls.Add(Me.chkActivarLectura)
        Me.GroupBox3.Controls.Add(Me.txtKgrsRecibidos2)
        Me.GroupBox3.Controls.Add(Me.CmbCliente)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtLado)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtNoRes)
        Me.GroupBox3.Controls.Add(Me.txtPeso)
        Me.GroupBox3.Controls.Add(Me._LblEtiqueta_3)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 307)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(444, 219)
        Me.GroupBox3.TabIndex = 71
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de canal/combo"
        '
        'txtKgrsRecibidos
        '
        Me.txtKgrsRecibidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKgrsRecibidos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKgrsRecibidos.Location = New System.Drawing.Point(101, 156)
        Me.txtKgrsRecibidos.Name = "txtKgrsRecibidos"
        Me.txtKgrsRecibidos.Size = New System.Drawing.Size(145, 49)
        Me.txtKgrsRecibidos.TabIndex = 93
        Me.txtKgrsRecibidos.Text = "0.00"
        Me.txtKgrsRecibidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkActivarLectura
        '
        Me.chkActivarLectura.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkActivarLectura.Location = New System.Drawing.Point(252, 157)
        Me.chkActivarLectura.Name = "chkActivarLectura"
        Me.chkActivarLectura.Size = New System.Drawing.Size(76, 49)
        Me.chkActivarLectura.TabIndex = 91
        Me.chkActivarLectura.Text = "Lectura de Peso Desactivada"
        Me.chkActivarLectura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkActivarLectura.UseVisualStyleBackColor = True
        '
        'txtKgrsRecibidos2
        '
        Me.txtKgrsRecibidos2.BaudRate = 9600
        Me.txtKgrsRecibidos2.DataBit = 8
        Me.txtKgrsRecibidos2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKgrsRecibidos2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKgrsRecibidos2.Format = wclTextBoxSerial.TextBoxSerial.FormatoDatos.Ascii
        Me.txtKgrsRecibidos2.Location = New System.Drawing.Point(338, 112)
        Me.txtKgrsRecibidos2.Name = "txtKgrsRecibidos2"
        Me.txtKgrsRecibidos2.Parity = wclTextBoxSerial.Rs232.DataParity.Parity_None
        Me.txtKgrsRecibidos2.Port = 1
        Me.txtKgrsRecibidos2.Size = New System.Drawing.Size(41, 20)
        Me.txtKgrsRecibidos2.StopBit = wclTextBoxSerial.Rs232.DataStopBit.StopBit_1
        Me.txtKgrsRecibidos2.TabIndex = 90
        Me.txtKgrsRecibidos2.Text = "0.00"
        Me.txtKgrsRecibidos2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtKgrsRecibidos2.TimeOut = 1500
        Me.txtKgrsRecibidos2.TimeToWaitForMoreData = 300
        Me.txtKgrsRecibidos2.Visible = False
        '
        'CmbCliente
        '
        Me.CmbCliente.FormattingEnabled = True
        Me.CmbCliente.Location = New System.Drawing.Point(82, 17)
        Me.CmbCliente.Name = "CmbCliente"
        Me.CmbCliente.Size = New System.Drawing.Size(291, 21)
        Me.CmbCliente.TabIndex = 89
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(15, 20)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 13)
        Me.Label19.TabIndex = 88
        Me.Label19.Text = "Se envia a :"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(15, 159)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(74, 42)
        Me.Label12.TabIndex = 79
        Me.Label12.Text = "Kilos recibidos :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(193, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 78
        Me.Label8.Text = "Lado :"
        '
        'txtLado
        '
        Me.txtLado.AcceptsReturn = True
        Me.txtLado.BackColor = System.Drawing.SystemColors.Window
        Me.txtLado.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLado.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtLado.Location = New System.Drawing.Point(236, 44)
        Me.txtLado.MaxLength = 0
        Me.txtLado.Name = "txtLado"
        Me.txtLado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLado.Size = New System.Drawing.Size(81, 50)
        Me.txtLado.TabIndex = 77
        Me.txtLado.Text = "1"
        Me.txtLado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Num. Cab/Pza :"
        '
        'txtNoRes
        '
        Me.txtNoRes.AcceptsReturn = True
        Me.txtNoRes.BackColor = System.Drawing.SystemColors.Window
        Me.txtNoRes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNoRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoRes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNoRes.Location = New System.Drawing.Point(101, 44)
        Me.txtNoRes.MaxLength = 0
        Me.txtNoRes.Name = "txtNoRes"
        Me.txtNoRes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNoRes.Size = New System.Drawing.Size(81, 50)
        Me.txtNoRes.TabIndex = 69
        Me.txtNoRes.Text = "1"
        Me.txtNoRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPeso
        '
        Me.txtPeso.AcceptsReturn = True
        Me.txtPeso.BackColor = System.Drawing.SystemColors.Window
        Me.txtPeso.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPeso.Location = New System.Drawing.Point(101, 100)
        Me.txtPeso.MaxLength = 0
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPeso.Size = New System.Drawing.Size(145, 50)
        Me.txtPeso.TabIndex = 65
        Me.txtPeso.Text = "0.00"
        Me.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_LblEtiqueta_3
        '
        Me._LblEtiqueta_3.BackColor = System.Drawing.SystemColors.Control
        Me._LblEtiqueta_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._LblEtiqueta_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._LblEtiqueta_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._LblEtiqueta_3.Location = New System.Drawing.Point(15, 104)
        Me._LblEtiqueta_3.Name = "_LblEtiqueta_3"
        Me._LblEtiqueta_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._LblEtiqueta_3.Size = New System.Drawing.Size(74, 42)
        Me._LblEtiqueta_3.TabIndex = 66
        Me._LblEtiqueta_3.Text = "Kilos etiqueta :"
        '
        'ComboBox1
        '
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(155, 52)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(295, 21)
        Me.ComboBox1.TabIndex = 48
        Me.ComboBox1.Visible = False
        '
        'dtpFechaSacrificio
        '
        Me.dtpFechaSacrificio.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFechaSacrificio.Enabled = False
        Me.dtpFechaSacrificio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaSacrificio.Location = New System.Drawing.Point(358, 22)
        Me.dtpFechaSacrificio.Name = "dtpFechaSacrificio"
        Me.dtpFechaSacrificio.Size = New System.Drawing.Size(92, 20)
        Me.dtpFechaSacrificio.TabIndex = 53
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(263, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 13)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Fecha Sacrificio :"
        '
        'txtLoteSacrificio
        '
        Me.txtLoteSacrificio.Enabled = False
        Me.txtLoteSacrificio.Location = New System.Drawing.Point(155, 22)
        Me.txtLoteSacrificio.Name = "txtLoteSacrificio"
        Me.txtLoteSacrificio.Size = New System.Drawing.Size(102, 20)
        Me.txtLoteSacrificio.TabIndex = 30
        Me.txtLoteSacrificio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Productor :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lote de sacrificio / embarque :"
        '
        'ppdVisor
        '
        Me.ppdVisor.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.ppdVisor.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.ppdVisor.ClientSize = New System.Drawing.Size(400, 300)
        Me.ppdVisor.Enabled = True
        Me.ppdVisor.Icon = CType(resources.GetObject("ppdVisor.Icon"), System.Drawing.Icon)
        Me.ppdVisor.Name = "ppdVisor"
        Me.ppdVisor.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Codigo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Consecutivo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Registro"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "FolioMovimiento"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Folio Movimiento"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "IdFolioCanal"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Canal"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "KgrsCalientes"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Kilos Calientes"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "kgrsBascula"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Kilos Recibidos"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Estatus"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Estatus"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'tmActualizacion
        '
        Me.tmActualizacion.Interval = 60000
        '
        'clmSeleccion
        '
        Me.clmSeleccion.FillWeight = 10.0!
        Me.clmSeleccion.HeaderText = ""
        Me.clmSeleccion.Name = "clmSeleccion"
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoDataGridViewTextBoxColumn.Visible = False
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.FillWeight = 90.0!
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'clmRegistro
        '
        Me.clmRegistro.DataPropertyName = "Consecutivo"
        Me.clmRegistro.HeaderText = "Registro"
        Me.clmRegistro.Name = "clmRegistro"
        Me.clmRegistro.Visible = False
        '
        'clmFolioMov
        '
        Me.clmFolioMov.DataPropertyName = "FolioMovimiento"
        Me.clmFolioMov.HeaderText = "Folio Movimiento"
        Me.clmFolioMov.Name = "clmFolioMov"
        Me.clmFolioMov.ReadOnly = True
        Me.clmFolioMov.Visible = False
        '
        'clmCanal
        '
        Me.clmCanal.DataPropertyName = "IdFolioCanal"
        Me.clmCanal.HeaderText = "Pieza"
        Me.clmCanal.Name = "clmCanal"
        Me.clmCanal.ReadOnly = True
        '
        'clmKilosCalientes
        '
        Me.clmKilosCalientes.DataPropertyName = "KgrsCalientes"
        Me.clmKilosCalientes.HeaderText = "Kilos Calientes"
        Me.clmKilosCalientes.Name = "clmKilosCalientes"
        '
        'clmKilosRecbidos
        '
        Me.clmKilosRecbidos.DataPropertyName = "kgrsBascula"
        Me.clmKilosRecbidos.HeaderText = "Kilos Recibidos"
        Me.clmKilosRecbidos.Name = "clmKilosRecbidos"
        Me.clmKilosRecbidos.ReadOnly = True
        '
        'clmEstatus
        '
        Me.clmEstatus.DataPropertyName = "Estatus"
        Me.clmEstatus.HeaderText = "Estatus"
        Me.clmEstatus.Name = "clmEstatus"
        Me.clmEstatus.ReadOnly = True
        '
        'FrmRecepcionCanales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 584)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.Gb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmRecepcionCanales"
        Me.Text = "Entrada de Canales / Materia prima a Almacén"
        Me.Gb.ResumeLayout(False)
        Me.Gb.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.dgvServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvCanales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Gb As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaSacrificio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtLoteSacrificio As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Public WithEvents txtPeso As System.Windows.Forms.TextBox
    Public WithEvents _LblEtiqueta_3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Public WithEvents txtNoRes As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTotalKilos As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTotalKgrsCalientes As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTotalCanales As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvCanales As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents txtLado As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaCaptura As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtpHora As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtProductor As System.Windows.Forms.TextBox
    Public WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtKilosRecibidos As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtKilosCalientes As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtCanales As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents txtCantCanales As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents CmbCliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents RbtnMacho As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnHembra As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents ServiciosC As ClasesNegocio.ServiciosCollectionClass
    Friend WithEvents dgvServicios As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtKgrsRecibidos2 As wclTextBoxSerial.TextBoxSerial
    Friend WithEvents chkActivarLectura As System.Windows.Forms.CheckBox
    Friend WithEvents txtKgrsRecibidos As System.Windows.Forms.TextBox
    Friend WithEvents ppdVisor As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents pdDocumento As System.Drawing.Printing.PrintDocument
    'Friend WithEvents generadorCodigoBarra As AxTALBarCode.AxTALBarCd
    Friend WithEvents txtLoteCorteRastro As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tmActualizacion As System.Windows.Forms.Timer
    Friend WithEvents clmSeleccion As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmRegistro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFolioMov As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCanal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmKilosCalientes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmKilosRecbidos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
