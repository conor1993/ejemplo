<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistroSacrificioGanadero
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
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TabControl2 = New System.Windows.Forms.TabControl
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.Res = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KilosCanal1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KilosCanal2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.DataGridView3 = New System.Windows.Forms.DataGridView
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Piezas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Motivos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.DataGridView4 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Kilos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtImpteClasificacion = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtCantCabezasCalsificadas = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtImpteEnmantado = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtCantCabezasEnmantadas = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtImpteSacrificio = New System.Windows.Forms.TextBox
        Me.txtRendimiento = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtCantCabezas = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtKilosCalientes = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtCantCanales = New System.Windows.Forms.TextBox
        Me.txtKilosEnPie = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtLoteSacrificio = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbRastro = New System.Windows.Forms.ComboBox
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.mtb.Size = New System.Drawing.Size(50, 530)
        Me.mtb.TabIndex = 54
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(58, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(779, 32)
        Me.Label17.TabIndex = 53
        Me.Label17.Text = "Registro de Sacrificios"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TabControl2)
        Me.GroupBox1.Location = New System.Drawing.Point(62, 210)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(682, 275)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Location = New System.Drawing.Point(6, 19)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(597, 246)
        Me.TabControl2.TabIndex = 87
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DataGridView2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(589, 220)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Canales"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Res, Me.KilosCanal1, Me.KilosCanal2})
        Me.DataGridView2.Location = New System.Drawing.Point(15, 26)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(285, 162)
        Me.DataGridView2.TabIndex = 86
        '
        'Res
        '
        Me.Res.HeaderText = "Res"
        Me.Res.Name = "Res"
        Me.Res.ReadOnly = True
        Me.Res.Width = 40
        '
        'KilosCanal1
        '
        Me.KilosCanal1.HeaderText = "Kgrs. Canal 1"
        Me.KilosCanal1.Name = "KilosCanal1"
        Me.KilosCanal1.ReadOnly = True
        '
        'KilosCanal2
        '
        Me.KilosCanal2.HeaderText = "Kgrs. Canal 2"
        Me.KilosCanal2.Name = "KilosCanal2"
        Me.KilosCanal2.ReadOnly = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.DataGridView3)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(589, 220)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Decomisos"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Producto, Me.Piezas, Me.Motivos})
        Me.DataGridView3.Location = New System.Drawing.Point(16, 15)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.Size = New System.Drawing.Size(492, 162)
        Me.DataGridView3.TabIndex = 87
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 60
        '
        'Producto
        '
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        Me.Producto.Width = 150
        '
        'Piezas
        '
        Me.Piezas.HeaderText = "Piezas"
        Me.Piezas.Name = "Piezas"
        Me.Piezas.ReadOnly = True
        Me.Piezas.Width = 80
        '
        'Motivos
        '
        Me.Motivos.HeaderText = "Motivos"
        Me.Motivos.Name = "Motivos"
        Me.Motivos.ReadOnly = True
        Me.Motivos.Width = 150
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.DataGridView4)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(589, 220)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "Productos Recibidos"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'DataGridView4
        '
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Kilos})
        Me.DataGridView4.Location = New System.Drawing.Point(13, 15)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.ReadOnly = True
        Me.DataGridView4.Size = New System.Drawing.Size(416, 162)
        Me.DataGridView4.TabIndex = 87
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Codigo"
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
        Me.Kilos.HeaderText = "Kilos"
        Me.Kilos.Name = "Kilos"
        Me.Kilos.ReadOnly = True
        Me.Kilos.Width = 80
        '
        'txtImpteClasificacion
        '
        Me.txtImpteClasificacion.Location = New System.Drawing.Point(665, 146)
        Me.txtImpteClasificacion.Name = "txtImpteClasificacion"
        Me.txtImpteClasificacion.Size = New System.Drawing.Size(102, 20)
        Me.txtImpteClasificacion.TabIndex = 111
        Me.txtImpteClasificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtImpteClasificacion.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(525, 149)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 13)
        Me.Label16.TabIndex = 110
        Me.Label16.Text = "Impt. Clasificación :"
        Me.Label16.Visible = False
        '
        'txtCantCabezasCalsificadas
        '
        Me.txtCantCabezasCalsificadas.Location = New System.Drawing.Point(406, 146)
        Me.txtCantCabezasCalsificadas.Name = "txtCantCabezasCalsificadas"
        Me.txtCantCabezasCalsificadas.Size = New System.Drawing.Size(102, 20)
        Me.txtCantCabezasCalsificadas.TabIndex = 109
        Me.txtCantCabezasCalsificadas.Text = "0"
        Me.txtCantCabezasCalsificadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(271, 149)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(132, 13)
        Me.Label15.TabIndex = 108
        Me.Label15.Text = "No. de Cab. Clasificadas : "
        '
        'txtImpteEnmantado
        '
        Me.txtImpteEnmantado.Location = New System.Drawing.Point(665, 117)
        Me.txtImpteEnmantado.Name = "txtImpteEnmantado"
        Me.txtImpteEnmantado.Size = New System.Drawing.Size(102, 20)
        Me.txtImpteEnmantado.TabIndex = 107
        Me.txtImpteEnmantado.Text = "0"
        Me.txtImpteEnmantado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtImpteEnmantado.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(525, 120)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(134, 13)
        Me.Label14.TabIndex = 106
        Me.Label14.Text = "No. Cabezas sin sacrificio :"
        Me.Label14.Visible = False
        '
        'txtCantCabezasEnmantadas
        '
        Me.txtCantCabezasEnmantadas.Location = New System.Drawing.Point(406, 120)
        Me.txtCantCabezasEnmantadas.Name = "txtCantCabezasEnmantadas"
        Me.txtCantCabezasEnmantadas.Size = New System.Drawing.Size(102, 20)
        Me.txtCantCabezasEnmantadas.TabIndex = 105
        Me.txtCantCabezasEnmantadas.Text = "0"
        Me.txtCantCabezasEnmantadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(271, 120)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(132, 13)
        Me.Label13.TabIndex = 104
        Me.Label13.Text = "No. de Cab. Enmantadas :"
        '
        'txtImpteSacrificio
        '
        Me.txtImpteSacrificio.Location = New System.Drawing.Point(665, 172)
        Me.txtImpteSacrificio.Name = "txtImpteSacrificio"
        Me.txtImpteSacrificio.Size = New System.Drawing.Size(102, 20)
        Me.txtImpteSacrificio.TabIndex = 101
        Me.txtImpteSacrificio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtImpteSacrificio.Visible = False
        '
        'txtRendimiento
        '
        Me.txtRendimiento.Enabled = False
        Me.txtRendimiento.Location = New System.Drawing.Point(665, 91)
        Me.txtRendimiento.Name = "txtRendimiento"
        Me.txtRendimiento.Size = New System.Drawing.Size(102, 20)
        Me.txtRendimiento.TabIndex = 102
        Me.txtRendimiento.Text = "0"
        Me.txtRendimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(525, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Impte. de Sacrificio :"
        Me.Label2.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(525, 94)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 13)
        Me.Label12.TabIndex = 100
        Me.Label12.Text = "% Rendimiento :"
        '
        'txtCantCabezas
        '
        Me.txtCantCabezas.Location = New System.Drawing.Point(157, 120)
        Me.txtCantCabezas.Name = "txtCantCabezas"
        Me.txtCantCabezas.Size = New System.Drawing.Size(102, 20)
        Me.txtCantCabezas.TabIndex = 91
        Me.txtCantCabezas.Text = "0"
        Me.txtCantCabezas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "No. de Cabezas :"
        '
        'txtKilosCalientes
        '
        Me.txtKilosCalientes.Enabled = False
        Me.txtKilosCalientes.Location = New System.Drawing.Point(406, 172)
        Me.txtKilosCalientes.Name = "txtKilosCalientes"
        Me.txtKilosCalientes.Size = New System.Drawing.Size(102, 20)
        Me.txtKilosCalientes.TabIndex = 98
        Me.txtKilosCalientes.Text = "0"
        Me.txtKilosCalientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(271, 175)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 13)
        Me.Label10.TabIndex = 97
        Me.Label10.Text = "Kgs. en Canal Caliente :"
        '
        'txtCantCanales
        '
        Me.txtCantCanales.Enabled = False
        Me.txtCantCanales.Location = New System.Drawing.Point(157, 172)
        Me.txtCantCanales.Name = "txtCantCanales"
        Me.txtCantCanales.Size = New System.Drawing.Size(102, 20)
        Me.txtCantCanales.TabIndex = 96
        Me.txtCantCanales.Text = "0"
        Me.txtCantCanales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtKilosEnPie
        '
        Me.txtKilosEnPie.Enabled = False
        Me.txtKilosEnPie.Location = New System.Drawing.Point(157, 146)
        Me.txtKilosEnPie.Name = "txtKilosEnPie"
        Me.txtKilosEnPie.Size = New System.Drawing.Size(102, 20)
        Me.txtKilosEnPie.TabIndex = 95
        Me.txtKilosEnPie.Text = "0"
        Me.txtKilosEnPie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(59, 175)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "No. Canales :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(59, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "Kgrs. en Pie :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(59, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Rastro :"
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(416, 64)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(92, 20)
        Me.dtpFecha.TabIndex = 89
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(299, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 13)
        Me.Label9.TabIndex = 88
        Me.Label9.Text = "Fecha Sacrificio :"
        '
        'txtLoteSacrificio
        '
        Me.txtLoteSacrificio.Location = New System.Drawing.Point(157, 65)
        Me.txtLoteSacrificio.Name = "txtLoteSacrificio"
        Me.txtLoteSacrificio.Size = New System.Drawing.Size(102, 20)
        Me.txtLoteSacrificio.TabIndex = 87
        Me.txtLoteSacrificio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "Lote Sacrificio :"
        '
        'cmbRastro
        '
        Me.cmbRastro.FormattingEnabled = True
        Me.cmbRastro.Location = New System.Drawing.Point(157, 91)
        Me.cmbRastro.Name = "cmbRastro"
        Me.cmbRastro.Size = New System.Drawing.Size(351, 21)
        Me.cmbRastro.TabIndex = 112
        '
        'lblEstatus
        '
        Me.lblEstatus.AutoSize = True
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblEstatus.Location = New System.Drawing.Point(663, 57)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(104, 24)
        Me.lblEstatus.TabIndex = 113
        Me.lblEstatus.Text = "ESTATUS"
        '
        'FrmRegistroSacrificioGanadero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 530)
        Me.Controls.Add(Me.lblEstatus)
        Me.Controls.Add(Me.cmbRastro)
        Me.Controls.Add(Me.txtImpteClasificacion)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtCantCabezasCalsificadas)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtImpteEnmantado)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtCantCabezasEnmantadas)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtImpteSacrificio)
        Me.Controls.Add(Me.txtRendimiento)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtCantCabezas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtKilosCalientes)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCantCanales)
        Me.Controls.Add(Me.txtKilosEnPie)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtLoteSacrificio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmRegistroSacrificioGanadero"
        Me.Text = "FrmRegistroSacrificioGanadero"
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Res As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosCanal1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosCanal2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Piezas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Motivos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView4 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kilos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtImpteClasificacion As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtCantCabezasCalsificadas As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtImpteEnmantado As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtCantCabezasEnmantadas As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtImpteSacrificio As System.Windows.Forms.TextBox
    Friend WithEvents txtRendimiento As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCantCabezas As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtKilosCalientes As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCantCanales As System.Windows.Forms.TextBox
    Friend WithEvents txtKilosEnPie As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtLoteSacrificio As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbRastro As System.Windows.Forms.ComboBox
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
End Class
