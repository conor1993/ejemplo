<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _390AntiguedadSaldosFrm
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmbProveedor = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpFechaCorte = New System.Windows.Forms.DateTimePicker
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DgvFacturas = New System.Windows.Forms.DataGridView
        Me.ClmNoFactura = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmFechaVencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmFechaFactura = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmSaldo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmPorvencer = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmDe1a7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmDe8a14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmDe15a21 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmDe22a28 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmMasde28 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lblEmpresa = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.TmProveedor = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Proveedor:"
        '
        'CmbProveedor
        '
        Me.CmbProveedor.FormattingEnabled = True
        Me.CmbProveedor.Location = New System.Drawing.Point(121, 65)
        Me.CmbProveedor.Name = "CmbProveedor"
        Me.CmbProveedor.Size = New System.Drawing.Size(279, 21)
        Me.CmbProveedor.TabIndex = 102
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(492, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Fecha Corte:"
        '
        'dtpFechaCorte
        '
        Me.dtpFechaCorte.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaCorte.Location = New System.Drawing.Point(566, 64)
        Me.dtpFechaCorte.Name = "dtpFechaCorte"
        Me.dtpFechaCorte.Size = New System.Drawing.Size(93, 20)
        Me.dtpFechaCorte.TabIndex = 104
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
        Me.mtb.Size = New System.Drawing.Size(50, 406)
        Me.mtb.TabIndex = 105
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
        Me.lblTitulo.Size = New System.Drawing.Size(714, 29)
        Me.lblTitulo.TabIndex = 106
        Me.lblTitulo.Text = "REPORTE DE ANTIGÜEDAD DE SALDOS"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvFacturas)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(700, 301)
        Me.GroupBox1.TabIndex = 107
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Facturas Registradas"
        '
        'DgvFacturas
        '
        Me.DgvFacturas.AllowUserToAddRows = False
        Me.DgvFacturas.AllowUserToDeleteRows = False
        Me.DgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClmNoFactura, Me.ClmProveedor, Me.ClmFechaVencimiento, Me.ClmFechaFactura, Me.clmSaldo, Me.ClmPorvencer, Me.ClmDe1a7, Me.ClmDe8a14, Me.ClmDe15a21, Me.ClmDe22a28, Me.ClmMasde28})
        Me.DgvFacturas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvFacturas.Location = New System.Drawing.Point(3, 16)
        Me.DgvFacturas.Name = "DgvFacturas"
        Me.DgvFacturas.ReadOnly = True
        Me.DgvFacturas.RowHeadersVisible = False
        Me.DgvFacturas.Size = New System.Drawing.Size(694, 282)
        Me.DgvFacturas.TabIndex = 0
        '
        'ClmNoFactura
        '
        Me.ClmNoFactura.DataPropertyName = "NoFactura"
        Me.ClmNoFactura.Frozen = True
        Me.ClmNoFactura.HeaderText = "No Factura"
        Me.ClmNoFactura.Name = "ClmNoFactura"
        Me.ClmNoFactura.ReadOnly = True
        '
        'ClmProveedor
        '
        Me.ClmProveedor.DataPropertyName = "PrRazSocial"
        Me.ClmProveedor.Frozen = True
        Me.ClmProveedor.HeaderText = "Proveedor"
        Me.ClmProveedor.Name = "ClmProveedor"
        Me.ClmProveedor.ReadOnly = True
        '
        'ClmFechaVencimiento
        '
        Me.ClmFechaVencimiento.DataPropertyName = "FechaVencimiento"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.ClmFechaVencimiento.DefaultCellStyle = DataGridViewCellStyle1
        Me.ClmFechaVencimiento.Frozen = True
        Me.ClmFechaVencimiento.HeaderText = "Fecha Venc."
        Me.ClmFechaVencimiento.Name = "ClmFechaVencimiento"
        Me.ClmFechaVencimiento.ReadOnly = True
        '
        'ClmFechaFactura
        '
        Me.ClmFechaFactura.DataPropertyName = "FechaFactura"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.ClmFechaFactura.DefaultCellStyle = DataGridViewCellStyle2
        Me.ClmFechaFactura.HeaderText = "Fecha Factura"
        Me.ClmFechaFactura.Name = "ClmFechaFactura"
        Me.ClmFechaFactura.ReadOnly = True
        '
        'clmSaldo
        '
        Me.clmSaldo.DataPropertyName = "Saldo"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.clmSaldo.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmSaldo.HeaderText = "Saldo"
        Me.clmSaldo.Name = "clmSaldo"
        Me.clmSaldo.ReadOnly = True
        '
        'ClmPorvencer
        '
        Me.ClmPorvencer.DataPropertyName = "PorVencer"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.ClmPorvencer.DefaultCellStyle = DataGridViewCellStyle4
        Me.ClmPorvencer.HeaderText = "Por Vencer "
        Me.ClmPorvencer.Name = "ClmPorvencer"
        Me.ClmPorvencer.ReadOnly = True
        '
        'ClmDe1a7
        '
        Me.ClmDe1a7.DataPropertyName = "De1a7"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.ClmDe1a7.DefaultCellStyle = DataGridViewCellStyle5
        Me.ClmDe1a7.HeaderText = "De 1 -7"
        Me.ClmDe1a7.Name = "ClmDe1a7"
        Me.ClmDe1a7.ReadOnly = True
        '
        'ClmDe8a14
        '
        Me.ClmDe8a14.DataPropertyName = "De8a14"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.ClmDe8a14.DefaultCellStyle = DataGridViewCellStyle6
        Me.ClmDe8a14.HeaderText = "De 8-14"
        Me.ClmDe8a14.Name = "ClmDe8a14"
        Me.ClmDe8a14.ReadOnly = True
        '
        'ClmDe15a21
        '
        Me.ClmDe15a21.DataPropertyName = "De15a21"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.ClmDe15a21.DefaultCellStyle = DataGridViewCellStyle7
        Me.ClmDe15a21.HeaderText = "De 15-21"
        Me.ClmDe15a21.Name = "ClmDe15a21"
        Me.ClmDe15a21.ReadOnly = True
        '
        'ClmDe22a28
        '
        Me.ClmDe22a28.DataPropertyName = "De22a28"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.ClmDe22a28.DefaultCellStyle = DataGridViewCellStyle8
        Me.ClmDe22a28.HeaderText = "De 22-28"
        Me.ClmDe22a28.Name = "ClmDe22a28"
        Me.ClmDe22a28.ReadOnly = True
        '
        'ClmMasde28
        '
        Me.ClmMasde28.DataPropertyName = "Masde28"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.ClmMasde28.DefaultCellStyle = DataGridViewCellStyle9
        Me.ClmMasde28.HeaderText = "Mas de 28"
        Me.ClmMasde28.Name = "ClmMasde28"
        Me.ClmMasde28.ReadOnly = True
        '
        'lblEmpresa
        '
        Me.lblEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmpresa.Location = New System.Drawing.Point(121, 36)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(390, 20)
        Me.lblEmpresa.TabIndex = 108
        Me.lblEmpresa.Text = "Label3"
        Me.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(56, 40)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 13)
        Me.Label18.TabIndex = 109
        Me.Label18.Text = "Empresa:"
        '
        'TmProveedor
        '
        Me.TmProveedor.Interval = 1000
        '
        '_390AntiguedadSaldosFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 406)
        Me.Controls.Add(Me.lblEmpresa)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.dtpFechaCorte)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbProveedor)
        Me.Controls.Add(Me.Label1)
        Me.Name = "_390AntiguedadSaldosFrm"
        Me.Text = "Reporte de Antigüedad de Saldos"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgvFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaCorte As System.Windows.Forms.DateTimePicker
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DgvFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents lblEmpresa As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TmProveedor As System.Windows.Forms.Timer
    Friend WithEvents ClmNoFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmFechaVencimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmFechaFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSaldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmPorvencer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmDe1a7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmDe8a14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmDe15a21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmDe22a28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmMasde28 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
