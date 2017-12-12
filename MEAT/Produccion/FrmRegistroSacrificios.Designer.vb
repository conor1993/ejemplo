<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistroSacrificios
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
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblEstatus = New System.Windows.Forms.Label()
        Me.txtLoteRastro = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgCanales = New System.Windows.Forms.DataGridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.DgvDecomisos = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Piezas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmKilos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Motivos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.dgProductosRecibidos = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kilos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCantCabezasEnmantadas = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtIntroductor = New System.Windows.Forms.TextBox()
        Me.txtRendimiento = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCantCabezas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKilosCalientes = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCantCanales = New System.Windows.Forms.TextBox()
        Me.txtKilosEnPie = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpFechaSacrificio = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtLoteSacrificio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mtb = New MEAToolBar.MEAToolBar()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.Gb = New System.Windows.Forms.GroupBox()
        Me.cmbIntroductor = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvRecepcionesGanado = New System.Windows.Forms.DataGridView()
        Me.Checar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FechaSalida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaRecepcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoteRecepcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantCabezas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KilosRecibidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KiloPromedio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmCabezasSacrificio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteKilo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCabezasSacrificadas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Tiempo = New System.Windows.Forms.Timer(Me.components)
        Me.TmIntroductor = New System.Windows.Forms.Timer(Me.components)
        Me.Res = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KilosCanal1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KilosCanal2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgCanales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.DgvDecomisos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.dgProductosRecibidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Gb.SuspendLayout()
        CType(Me.dgvRecepcionesGanado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblEstatus)
        Me.GroupBox1.Controls.Add(Me.txtLoteRastro)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TabControl2)
        Me.GroupBox1.Controls.Add(Me.txtCantCabezasEnmantadas)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtIntroductor)
        Me.GroupBox1.Controls.Add(Me.txtRendimiento)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtCantCabezas)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtKilosCalientes)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtCantCanales)
        Me.GroupBox1.Controls.Add(Me.txtKilosEnPie)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dtpFechaSacrificio)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtLoteSacrificio)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(850, 456)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        '
        'lblEstatus
        '
        Me.lblEstatus.AutoSize = True
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblEstatus.Location = New System.Drawing.Point(740, 11)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(104, 24)
        Me.lblEstatus.TabIndex = 90
        Me.lblEstatus.Text = "ESTATUS"
        '
        'txtLoteRastro
        '
        Me.txtLoteRastro.Location = New System.Drawing.Point(158, 42)
        Me.txtLoteRastro.MaxLength = 10
        Me.txtLoteRastro.Name = "txtLoteRastro"
        Me.txtLoteRastro.Size = New System.Drawing.Size(102, 20)
        Me.txtLoteRastro.TabIndex = 89
        Me.txtLoteRastro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Lote Rastro:"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Location = New System.Drawing.Point(6, 174)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(583, 276)
        Me.TabControl2.TabIndex = 87
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgCanales)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(575, 250)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Canales / Combos"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgCanales
        '
        Me.dgCanales.AllowUserToAddRows = False
        Me.dgCanales.AllowUserToDeleteRows = False
        Me.dgCanales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgCanales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCanales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Res, Me.KilosCanal1, Me.KilosCanal2})
        Me.dgCanales.Location = New System.Drawing.Point(6, 6)
        Me.dgCanales.Name = "dgCanales"
        Me.dgCanales.ReadOnly = True
        Me.dgCanales.RowHeadersVisible = False
        Me.dgCanales.Size = New System.Drawing.Size(275, 238)
        Me.dgCanales.TabIndex = 86
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.DgvDecomisos)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(575, 250)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Decomisos"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'DgvDecomisos
        '
        Me.DgvDecomisos.AllowUserToAddRows = False
        Me.DgvDecomisos.AllowUserToDeleteRows = False
        Me.DgvDecomisos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvDecomisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDecomisos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Producto, Me.Piezas, Me.clmKilos, Me.Motivos})
        Me.DgvDecomisos.Location = New System.Drawing.Point(6, 6)
        Me.DgvDecomisos.Name = "DgvDecomisos"
        Me.DgvDecomisos.ReadOnly = True
        Me.DgvDecomisos.RowHeadersVisible = False
        Me.DgvDecomisos.Size = New System.Drawing.Size(563, 238)
        Me.DgvDecomisos.TabIndex = 87
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "IdProducto"
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 60
        '
        'Producto
        '
        Me.Producto.DataPropertyName = "Producto"
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        Me.Producto.Width = 150
        '
        'Piezas
        '
        Me.Piezas.DataPropertyName = "Piezas"
        Me.Piezas.HeaderText = "Piezas"
        Me.Piezas.Name = "Piezas"
        Me.Piezas.ReadOnly = True
        Me.Piezas.Width = 80
        '
        'clmKilos
        '
        Me.clmKilos.DataPropertyName = "Kilos"
        Me.clmKilos.HeaderText = "Kilos"
        Me.clmKilos.Name = "clmKilos"
        Me.clmKilos.ReadOnly = True
        '
        'Motivos
        '
        Me.Motivos.DataPropertyName = "Decomiso"
        Me.Motivos.HeaderText = "Motivos"
        Me.Motivos.Name = "Motivos"
        Me.Motivos.ReadOnly = True
        Me.Motivos.Width = 150
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.dgProductosRecibidos)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(575, 250)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "Productos Recibidos"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'dgProductosRecibidos
        '
        Me.dgProductosRecibidos.AllowUserToAddRows = False
        Me.dgProductosRecibidos.AllowUserToDeleteRows = False
        Me.dgProductosRecibidos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgProductosRecibidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProductosRecibidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Kilos})
        Me.dgProductosRecibidos.Location = New System.Drawing.Point(6, 6)
        Me.dgProductosRecibidos.Name = "dgProductosRecibidos"
        Me.dgProductosRecibidos.ReadOnly = True
        Me.dgProductosRecibidos.RowHeadersVisible = False
        Me.dgProductosRecibidos.Size = New System.Drawing.Size(563, 238)
        Me.dgProductosRecibidos.TabIndex = 87
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdProducto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Producto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Producto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Piezas"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Piezas"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'Kilos
        '
        Me.Kilos.DataPropertyName = "Kilos"
        Me.Kilos.HeaderText = "Kilos"
        Me.Kilos.Name = "Kilos"
        Me.Kilos.ReadOnly = True
        Me.Kilos.Width = 80
        '
        'txtCantCabezasEnmantadas
        '
        Me.txtCantCabezasEnmantadas.Location = New System.Drawing.Point(407, 97)
        Me.txtCantCabezasEnmantadas.Name = "txtCantCabezasEnmantadas"
        Me.txtCantCabezasEnmantadas.Size = New System.Drawing.Size(102, 20)
        Me.txtCantCabezasEnmantadas.TabIndex = 79
        Me.txtCantCabezasEnmantadas.Text = "0"
        Me.txtCantCabezasEnmantadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(272, 97)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 13)
        Me.Label13.TabIndex = 78
        Me.Label13.Text = "No. de Cab. Muertas :"
        '
        'txtIntroductor
        '
        Me.txtIntroductor.Enabled = False
        Me.txtIntroductor.Location = New System.Drawing.Point(158, 68)
        Me.txtIntroductor.Name = "txtIntroductor"
        Me.txtIntroductor.Size = New System.Drawing.Size(351, 20)
        Me.txtIntroductor.TabIndex = 77
        '
        'txtRendimiento
        '
        Me.txtRendimiento.Enabled = False
        Me.txtRendimiento.Location = New System.Drawing.Point(407, 123)
        Me.txtRendimiento.Name = "txtRendimiento"
        Me.txtRendimiento.Size = New System.Drawing.Size(102, 20)
        Me.txtRendimiento.TabIndex = 76
        Me.txtRendimiento.Text = "0"
        Me.txtRendimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(272, 126)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 13)
        Me.Label12.TabIndex = 75
        Me.Label12.Text = "% Rendimiento :"
        '
        'txtCantCabezas
        '
        Me.txtCantCabezas.Location = New System.Drawing.Point(158, 93)
        Me.txtCantCabezas.Name = "txtCantCabezas"
        Me.txtCantCabezas.Size = New System.Drawing.Size(102, 20)
        Me.txtCantCabezas.TabIndex = 59
        Me.txtCantCabezas.Text = "0"
        Me.txtCantCabezas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 13)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "No. de Cabezas / Piezas :"
        '
        'txtKilosCalientes
        '
        Me.txtKilosCalientes.Enabled = False
        Me.txtKilosCalientes.Location = New System.Drawing.Point(407, 149)
        Me.txtKilosCalientes.Name = "txtKilosCalientes"
        Me.txtKilosCalientes.Size = New System.Drawing.Size(102, 20)
        Me.txtKilosCalientes.TabIndex = 72
        Me.txtKilosCalientes.Text = "0"
        Me.txtKilosCalientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(272, 152)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 13)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "Kgs. en Canal Caliente :"
        '
        'txtCantCanales
        '
        Me.txtCantCanales.Enabled = False
        Me.txtCantCanales.Location = New System.Drawing.Point(158, 148)
        Me.txtCantCanales.Name = "txtCantCanales"
        Me.txtCantCanales.Size = New System.Drawing.Size(102, 20)
        Me.txtCantCanales.TabIndex = 70
        Me.txtCantCanales.Text = "0"
        Me.txtCantCanales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtKilosEnPie
        '
        Me.txtKilosEnPie.Enabled = False
        Me.txtKilosEnPie.Location = New System.Drawing.Point(158, 119)
        Me.txtKilosEnPie.Name = "txtKilosEnPie"
        Me.txtKilosEnPie.Size = New System.Drawing.Size(102, 20)
        Me.txtKilosEnPie.TabIndex = 69
        Me.txtKilosEnPie.Text = "0"
        Me.txtKilosEnPie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 151)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 13)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "No. Canales / Combos :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Kgrs. en Pie :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Introductor/Cliente"
        '
        'dtpFechaSacrificio
        '
        Me.dtpFechaSacrificio.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFechaSacrificio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaSacrificio.Location = New System.Drawing.Point(417, 16)
        Me.dtpFechaSacrificio.Name = "dtpFechaSacrificio"
        Me.dtpFechaSacrificio.Size = New System.Drawing.Size(92, 20)
        Me.dtpFechaSacrificio.TabIndex = 55
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(266, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(148, 13)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Fecha Sacrificio / Embarque :"
        '
        'txtLoteSacrificio
        '
        Me.txtLoteSacrificio.Enabled = False
        Me.txtLoteSacrificio.Location = New System.Drawing.Point(158, 16)
        Me.txtLoteSacrificio.Name = "txtLoteSacrificio"
        Me.txtLoteSacrificio.ReadOnly = True
        Me.txtLoteSacrificio.Size = New System.Drawing.Size(102, 20)
        Me.txtLoteSacrificio.TabIndex = 32
        Me.txtLoteSacrificio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Folio Sacrificio / Embarque :"
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
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 552)
        Me.mtb.TabIndex = 51
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(885, 32)
        Me.Label17.TabIndex = 50
        Me.Label17.Text = "Registro de Sacrificios / Embarques"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(56, 46)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(874, 494)
        Me.TabControl1.TabIndex = 53
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cmdAceptar)
        Me.TabPage1.Controls.Add(Me.Gb)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(866, 468)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Entrada de Ganado"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.AllowDrop = True
        Me.cmdAceptar.Location = New System.Drawing.Point(757, 400)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(93, 32)
        Me.cmdAceptar.TabIndex = 1
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'Gb
        '
        Me.Gb.Controls.Add(Me.cmbIntroductor)
        Me.Gb.Controls.Add(Me.Label4)
        Me.Gb.Controls.Add(Me.dgvRecepcionesGanado)
        Me.Gb.Location = New System.Drawing.Point(6, 22)
        Me.Gb.Name = "Gb"
        Me.Gb.Size = New System.Drawing.Size(850, 372)
        Me.Gb.TabIndex = 0
        Me.Gb.TabStop = False
        Me.Gb.Text = "A rastro"
        '
        'cmbIntroductor
        '
        Me.cmbIntroductor.FormattingEnabled = True
        Me.cmbIntroductor.Location = New System.Drawing.Point(118, 21)
        Me.cmbIntroductor.Name = "cmbIntroductor"
        Me.cmbIntroductor.Size = New System.Drawing.Size(314, 21)
        Me.cmbIntroductor.TabIndex = 67
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 13)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Introductor/Cliente : "
        '
        'dgvRecepcionesGanado
        '
        Me.dgvRecepcionesGanado.AllowUserToAddRows = False
        Me.dgvRecepcionesGanado.AllowUserToDeleteRows = False
        Me.dgvRecepcionesGanado.AllowUserToResizeRows = False
        Me.dgvRecepcionesGanado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecepcionesGanado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Checar, Me.FechaSalida, Me.FechaRecepcion, Me.LoteRecepcion, Me.CantCabezas, Me.KilosRecibidos, Me.KiloPromedio, Me.ClmCabezasSacrificio, Me.ImporteKilo, Me.ImporteTotal, Me.clmCabezasSacrificadas})
        Me.dgvRecepcionesGanado.Location = New System.Drawing.Point(6, 55)
        Me.dgvRecepcionesGanado.Name = "dgvRecepcionesGanado"
        Me.dgvRecepcionesGanado.RowHeadersVisible = False
        Me.dgvRecepcionesGanado.Size = New System.Drawing.Size(838, 311)
        Me.dgvRecepcionesGanado.TabIndex = 0
        '
        'Checar
        '
        Me.Checar.HeaderText = "   "
        Me.Checar.Name = "Checar"
        Me.Checar.Width = 20
        '
        'FechaSalida
        '
        Me.FechaSalida.HeaderText = "Fecha Salida"
        Me.FechaSalida.Name = "FechaSalida"
        Me.FechaSalida.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FechaSalida.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.FechaSalida.Visible = False
        Me.FechaSalida.Width = 80
        '
        'FechaRecepcion
        '
        Me.FechaRecepcion.DataPropertyName = "FechaRecepcion"
        Me.FechaRecepcion.HeaderText = "FechaEntrada"
        Me.FechaRecepcion.Name = "FechaRecepcion"
        Me.FechaRecepcion.ReadOnly = True
        Me.FechaRecepcion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FechaRecepcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.FechaRecepcion.Width = 80
        '
        'LoteRecepcion
        '
        Me.LoteRecepcion.DataPropertyName = "LoteRecepcion"
        Me.LoteRecepcion.HeaderText = "Lote Recepcion"
        Me.LoteRecepcion.Name = "LoteRecepcion"
        Me.LoteRecepcion.ReadOnly = True
        Me.LoteRecepcion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LoteRecepcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.LoteRecepcion.Width = 150
        '
        'CantCabezas
        '
        Me.CantCabezas.DataPropertyName = "CantCabezas"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle21.Format = "N0"
        DataGridViewCellStyle21.NullValue = Nothing
        Me.CantCabezas.DefaultCellStyle = DataGridViewCellStyle21
        Me.CantCabezas.HeaderText = "No. Cabezas"
        Me.CantCabezas.Name = "CantCabezas"
        Me.CantCabezas.ReadOnly = True
        Me.CantCabezas.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CantCabezas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CantCabezas.Width = 80
        '
        'KilosRecibidos
        '
        Me.KilosRecibidos.DataPropertyName = "KilosRecibidos"
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle22.Format = "N2"
        DataGridViewCellStyle22.NullValue = Nothing
        Me.KilosRecibidos.DefaultCellStyle = DataGridViewCellStyle22
        Me.KilosRecibidos.HeaderText = "Kgrs. Recibidos"
        Me.KilosRecibidos.Name = "KilosRecibidos"
        Me.KilosRecibidos.ReadOnly = True
        Me.KilosRecibidos.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.KilosRecibidos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.KilosRecibidos.Width = 150
        '
        'KiloPromedio
        '
        Me.KiloPromedio.DataPropertyName = "KilosPromedio"
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle23.Format = "N2"
        DataGridViewCellStyle23.NullValue = Nothing
        Me.KiloPromedio.DefaultCellStyle = DataGridViewCellStyle23
        Me.KiloPromedio.HeaderText = "Kgrs. prom/cab"
        Me.KiloPromedio.Name = "KiloPromedio"
        Me.KiloPromedio.ReadOnly = True
        Me.KiloPromedio.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.KiloPromedio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.KiloPromedio.Width = 90
        '
        'ClmCabezasSacrificio
        '
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle24.Format = "N0"
        DataGridViewCellStyle24.NullValue = Nothing
        Me.ClmCabezasSacrificio.DefaultCellStyle = DataGridViewCellStyle24
        Me.ClmCabezasSacrificio.HeaderText = "No. Cab. a Sacrificio"
        Me.ClmCabezasSacrificio.Name = "ClmCabezasSacrificio"
        Me.ClmCabezasSacrificio.Width = 130
        '
        'ImporteKilo
        '
        Me.ImporteKilo.HeaderText = "Importe / Kgr."
        Me.ImporteKilo.Name = "ImporteKilo"
        Me.ImporteKilo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ImporteKilo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ImporteKilo.Visible = False
        Me.ImporteKilo.Width = 80
        '
        'ImporteTotal
        '
        Me.ImporteTotal.HeaderText = "Importe Total"
        Me.ImporteTotal.Name = "ImporteTotal"
        Me.ImporteTotal.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ImporteTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ImporteTotal.Visible = False
        '
        'clmCabezasSacrificadas
        '
        Me.clmCabezasSacrificadas.DataPropertyName = "SumaCabezasDet"
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle25.Format = "N2"
        DataGridViewCellStyle25.NullValue = Nothing
        Me.clmCabezasSacrificadas.DefaultCellStyle = DataGridViewCellStyle25
        Me.clmCabezasSacrificadas.HeaderText = "Cab. Sacrificadas"
        Me.clmCabezasSacrificadas.Name = "clmCabezasSacrificadas"
        Me.clmCabezasSacrificadas.Width = 120
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(866, 468)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Sacrificios / Embarques"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Tiempo
        '
        Me.Tiempo.Interval = 60000
        '
        'TmIntroductor
        '
        Me.TmIntroductor.Interval = 1000
        '
        'Res
        '
        Me.Res.DataPropertyName = "Res"
        Me.Res.HeaderText = "Pza"
        Me.Res.Name = "Res"
        Me.Res.ReadOnly = True
        Me.Res.Width = 40
        '
        'KilosCanal1
        '
        Me.KilosCanal1.DataPropertyName = "KgsLado1"
        Me.KilosCanal1.HeaderText = "Kgrs. Canal 1"
        Me.KilosCanal1.Name = "KilosCanal1"
        Me.KilosCanal1.ReadOnly = True
        '
        'KilosCanal2
        '
        Me.KilosCanal2.DataPropertyName = "KgsLado2"
        Me.KilosCanal2.HeaderText = "Kgrs. Canal 2"
        Me.KilosCanal2.Name = "KilosCanal2"
        Me.KilosCanal2.ReadOnly = True
        '
        'FrmRegistroSacrificios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 552)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmRegistroSacrificios"
        Me.Text = "Registro de Sacrificios / Embarques"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgCanales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.DgvDecomisos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.dgProductosRecibidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Gb.ResumeLayout(False)
        Me.Gb.PerformLayout()
        CType(Me.dgvRecepcionesGanado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRendimiento As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtKilosCalientes As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCantCanales As System.Windows.Forms.TextBox
    Friend WithEvents txtKilosEnPie As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCantCabezas As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaSacrificio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtLoteSacrificio As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Gb As System.Windows.Forms.GroupBox
    Friend WithEvents dgvRecepcionesGanado As System.Windows.Forms.DataGridView
    Friend WithEvents txtCantCabezasEnmantadas As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtIntroductor As System.Windows.Forms.TextBox
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents dgCanales As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents DgvDecomisos As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents dgProductosRecibidos As System.Windows.Forms.DataGridView
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents cmbIntroductor As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Tiempo As System.Windows.Forms.Timer
    Friend WithEvents TmIntroductor As System.Windows.Forms.Timer
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kilos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Piezas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmKilos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Motivos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtLoteRastro As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents Checar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FechaSalida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaRecepcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoteRecepcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantCabezas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosRecibidos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KiloPromedio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmCabezasSacrificio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteKilo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCabezasSacrificadas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Res As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosCanal1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosCanal2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
