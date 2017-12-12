<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _690ReporteFacturasGastos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DtpFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.CmbProveedor = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dgvFacturas = New System.Windows.Forms.DataGridView
        Me.ClmNoFactura = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmFechaFactura = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmFechaVencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmIva = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dgvCuentas = New System.Windows.Forms.DataGridView
        Me.ClmCtaMayor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmSubCta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmSsbCta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmSssCta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmCargo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmAbono = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChkRango = New System.Windows.Forms.CheckBox
        Me.CmbTipoProveedor = New System.Windows.Forms.ComboBox
        Me.TmProveedor = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 452)
        Me.mtb.TabIndex = 103
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
        Me.lblTitulo.Size = New System.Drawing.Size(737, 29)
        Me.lblTitulo.TabIndex = 132
        Me.lblTitulo.Text = "REPORTE DE FACTURAS DE GASTOS"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 133
        Me.Label1.Text = "Tipo Proveedor :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DtpFechaFinal)
        Me.GroupBox1.Controls.Add(Me.dtpFechaInicial)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(516, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(203, 75)
        Me.GroupBox1.TabIndex = 135
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rango de Fechas"
        '
        'DtpFechaFinal
        '
        Me.DtpFechaFinal.Enabled = False
        Me.DtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaFinal.Location = New System.Drawing.Point(85, 47)
        Me.DtpFechaFinal.Name = "DtpFechaFinal"
        Me.DtpFechaFinal.Size = New System.Drawing.Size(88, 20)
        Me.DtpFechaFinal.TabIndex = 3
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Enabled = False
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicial.Location = New System.Drawing.Point(85, 23)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(88, 20)
        Me.dtpFechaInicial.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Fecha Final :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fecha Inicial :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 136
        Me.Label4.Text = "Proveedor :"
        '
        'CmbProveedor
        '
        Me.CmbProveedor.FormattingEnabled = True
        Me.CmbProveedor.Location = New System.Drawing.Point(154, 93)
        Me.CmbProveedor.Name = "CmbProveedor"
        Me.CmbProveedor.Size = New System.Drawing.Size(279, 21)
        Me.CmbProveedor.TabIndex = 137
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvFacturas)
        Me.GroupBox2.Location = New System.Drawing.Point(59, 133)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(721, 171)
        Me.GroupBox2.TabIndex = 138
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Facturas Registradas"
        '
        'dgvFacturas
        '
        Me.dgvFacturas.AllowUserToAddRows = False
        Me.dgvFacturas.AllowUserToDeleteRows = False
        Me.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClmNoFactura, Me.ClmFechaFactura, Me.ClmFechaVencimiento, Me.ClmProveedor, Me.ClmSubtotal, Me.ClmIva, Me.ClmTotal})
        Me.dgvFacturas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvFacturas.Location = New System.Drawing.Point(3, 16)
        Me.dgvFacturas.Name = "dgvFacturas"
        Me.dgvFacturas.ReadOnly = True
        Me.dgvFacturas.RowHeadersVisible = False
        Me.dgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFacturas.Size = New System.Drawing.Size(715, 152)
        Me.dgvFacturas.TabIndex = 0
        '
        'ClmNoFactura
        '
        Me.ClmNoFactura.DataPropertyName = "NoFactura"
        Me.ClmNoFactura.HeaderText = "No Factura"
        Me.ClmNoFactura.Name = "ClmNoFactura"
        Me.ClmNoFactura.ReadOnly = True
        '
        'ClmFechaFactura
        '
        Me.ClmFechaFactura.DataPropertyName = "FechaFactura"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.ClmFechaFactura.DefaultCellStyle = DataGridViewCellStyle1
        Me.ClmFechaFactura.HeaderText = "Fecha Factura"
        Me.ClmFechaFactura.Name = "ClmFechaFactura"
        Me.ClmFechaFactura.ReadOnly = True
        '
        'ClmFechaVencimiento
        '
        Me.ClmFechaVencimiento.DataPropertyName = "FechaVencimiento"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.ClmFechaVencimiento.DefaultCellStyle = DataGridViewCellStyle2
        Me.ClmFechaVencimiento.HeaderText = "Fecha Vencimiento"
        Me.ClmFechaVencimiento.Name = "ClmFechaVencimiento"
        Me.ClmFechaVencimiento.ReadOnly = True
        '
        'ClmProveedor
        '
        Me.ClmProveedor.DataPropertyName = "ProveedorRazon"
        Me.ClmProveedor.HeaderText = "Proveedor"
        Me.ClmProveedor.Name = "ClmProveedor"
        Me.ClmProveedor.ReadOnly = True
        '
        'ClmSubtotal
        '
        Me.ClmSubtotal.DataPropertyName = "SubTotal"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ClmSubtotal.DefaultCellStyle = DataGridViewCellStyle3
        Me.ClmSubtotal.HeaderText = "SubTotal"
        Me.ClmSubtotal.Name = "ClmSubtotal"
        Me.ClmSubtotal.ReadOnly = True
        '
        'ClmIva
        '
        Me.ClmIva.DataPropertyName = "Iva"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.ClmIva.DefaultCellStyle = DataGridViewCellStyle4
        Me.ClmIva.HeaderText = "Iva"
        Me.ClmIva.Name = "ClmIva"
        Me.ClmIva.ReadOnly = True
        '
        'ClmTotal
        '
        Me.ClmTotal.DataPropertyName = "Total"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.ClmTotal.DefaultCellStyle = DataGridViewCellStyle5
        Me.ClmTotal.HeaderText = "Total"
        Me.ClmTotal.Name = "ClmTotal"
        Me.ClmTotal.ReadOnly = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvCuentas)
        Me.GroupBox3.Location = New System.Drawing.Point(62, 310)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(715, 128)
        Me.GroupBox3.TabIndex = 139
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cuentas Contables"
        '
        'dgvCuentas
        '
        Me.dgvCuentas.AllowUserToAddRows = False
        Me.dgvCuentas.AllowUserToDeleteRows = False
        Me.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClmCtaMayor, Me.ClmSubCta, Me.ClmSsbCta, Me.ClmSssCta, Me.ClmDescripcion, Me.ClmCargo, Me.ClmAbono})
        Me.dgvCuentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCuentas.Location = New System.Drawing.Point(3, 16)
        Me.dgvCuentas.Name = "dgvCuentas"
        Me.dgvCuentas.ReadOnly = True
        Me.dgvCuentas.RowHeadersVisible = False
        Me.dgvCuentas.Size = New System.Drawing.Size(709, 109)
        Me.dgvCuentas.TabIndex = 1
        '
        'ClmCtaMayor
        '
        Me.ClmCtaMayor.HeaderText = "Cta. Mayor"
        Me.ClmCtaMayor.Name = "ClmCtaMayor"
        Me.ClmCtaMayor.ReadOnly = True
        Me.ClmCtaMayor.Width = 85
        '
        'ClmSubCta
        '
        Me.ClmSubCta.HeaderText = "Sub Cta."
        Me.ClmSubCta.Name = "ClmSubCta"
        Me.ClmSubCta.ReadOnly = True
        Me.ClmSubCta.Width = 75
        '
        'ClmSsbCta
        '
        Me.ClmSsbCta.HeaderText = "Ssb Cta."
        Me.ClmSsbCta.Name = "ClmSsbCta"
        Me.ClmSsbCta.ReadOnly = True
        Me.ClmSsbCta.Width = 75
        '
        'ClmSssCta
        '
        Me.ClmSssCta.HeaderText = "Sss Cta."
        Me.ClmSssCta.Name = "ClmSssCta"
        Me.ClmSssCta.ReadOnly = True
        Me.ClmSssCta.Width = 75
        '
        'ClmDescripcion
        '
        Me.ClmDescripcion.HeaderText = "Descripción"
        Me.ClmDescripcion.Name = "ClmDescripcion"
        Me.ClmDescripcion.ReadOnly = True
        Me.ClmDescripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ClmDescripcion.Width = 150
        '
        'ClmCargo
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.ClmCargo.DefaultCellStyle = DataGridViewCellStyle6
        Me.ClmCargo.HeaderText = "Cargo"
        Me.ClmCargo.Name = "ClmCargo"
        Me.ClmCargo.ReadOnly = True
        '
        'ClmAbono
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.ClmAbono.DefaultCellStyle = DataGridViewCellStyle7
        Me.ClmAbono.HeaderText = "Abono"
        Me.ClmAbono.Name = "ClmAbono"
        Me.ClmAbono.ReadOnly = True
        '
        'ChkRango
        '
        Me.ChkRango.AutoSize = True
        Me.ChkRango.Location = New System.Drawing.Point(363, 39)
        Me.ChkRango.Name = "ChkRango"
        Me.ChkRango.Size = New System.Drawing.Size(147, 17)
        Me.ChkRango.TabIndex = 140
        Me.ChkRango.Text = "Activar Rango de Fechas"
        Me.ChkRango.UseVisualStyleBackColor = True
        '
        'CmbTipoProveedor
        '
        Me.CmbTipoProveedor.FormattingEnabled = True
        Me.CmbTipoProveedor.Location = New System.Drawing.Point(154, 66)
        Me.CmbTipoProveedor.Name = "CmbTipoProveedor"
        Me.CmbTipoProveedor.Size = New System.Drawing.Size(279, 21)
        Me.CmbTipoProveedor.TabIndex = 141
        '
        'TmProveedor
        '
        Me.TmProveedor.Interval = 1000
        '
        '_690ReporteFacturasGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 452)
        Me.Controls.Add(Me.CmbTipoProveedor)
        Me.Controls.Add(Me.ChkRango)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.CmbProveedor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.mtb)
        Me.Name = "_690ReporteFacturasGastos"
        Me.Text = "Reporte de Facturas de Gastos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CmbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvCuentas As System.Windows.Forms.DataGridView
    Friend WithEvents ChkRango As System.Windows.Forms.CheckBox
    Friend WithEvents ClmNoFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmFechaFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmFechaVencimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmSubtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmIva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmCtaMayor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmSubCta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmSsbCta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmSssCta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmCargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmAbono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CmbTipoProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents TmProveedor As System.Windows.Forms.Timer
End Class
