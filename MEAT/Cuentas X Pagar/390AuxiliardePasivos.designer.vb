<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _390AuxiliardePasivos
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.mtb = New MEAToolBar.MEAToolBar()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DgvFacturas = New System.Windows.Forms.DataGridView()
        Me.check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ClmNoFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmFechaCaptura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmFechaFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmFechaContable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmIdProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtpFechaCorte = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbProveedor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblTitulo.Size = New System.Drawing.Size(622, 29)
        Me.lblTitulo.TabIndex = 108
        Me.lblTitulo.Text = "REPORTE DE AUXILIAR DE PASIVOS"
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
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 421)
        Me.mtb.TabIndex = 107
        '
        'lblEmpresa
        '
        Me.lblEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmpresa.Location = New System.Drawing.Point(120, 41)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(390, 20)
        Me.lblEmpresa.TabIndex = 115
        Me.lblEmpresa.Text = "Label3"
        Me.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(55, 43)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 13)
        Me.Label18.TabIndex = 116
        Me.Label18.Text = "Empresa:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvFacturas)
        Me.GroupBox1.Location = New System.Drawing.Point(55, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(608, 301)
        Me.GroupBox1.TabIndex = 114
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Facturas Registradas"
        '
        'DgvFacturas
        '
        Me.DgvFacturas.AllowUserToAddRows = False
        Me.DgvFacturas.AllowUserToDeleteRows = False
        Me.DgvFacturas.AllowUserToResizeRows = False
        Me.DgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.check, Me.ClmNoFactura, Me.ClmFechaCaptura, Me.ClmFechaFactura, Me.clmImporte, Me.ClmFechaContable, Me.clmIdProveedor})
        Me.DgvFacturas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvFacturas.Location = New System.Drawing.Point(3, 16)
        Me.DgvFacturas.Name = "DgvFacturas"
        Me.DgvFacturas.RowHeadersVisible = False
        Me.DgvFacturas.Size = New System.Drawing.Size(602, 282)
        Me.DgvFacturas.TabIndex = 0
        '
        'check
        '
        Me.check.Frozen = True
        Me.check.HeaderText = ""
        Me.check.Name = "check"
        Me.check.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.check.Width = 20
        '
        'ClmNoFactura
        '
        Me.ClmNoFactura.DataPropertyName = "NoFactura"
        Me.ClmNoFactura.Frozen = True
        Me.ClmNoFactura.HeaderText = "Factura"
        Me.ClmNoFactura.Name = "ClmNoFactura"
        '
        'ClmFechaCaptura
        '
        Me.ClmFechaCaptura.DataPropertyName = "FechaCaptura"
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.ClmFechaCaptura.DefaultCellStyle = DataGridViewCellStyle4
        Me.ClmFechaCaptura.Frozen = True
        Me.ClmFechaCaptura.HeaderText = "Fecha Captura"
        Me.ClmFechaCaptura.Name = "ClmFechaCaptura"
        Me.ClmFechaCaptura.Width = 120
        '
        'ClmFechaFactura
        '
        Me.ClmFechaFactura.DataPropertyName = "FechaFactura"
        DataGridViewCellStyle5.Format = "d"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.ClmFechaFactura.DefaultCellStyle = DataGridViewCellStyle5
        Me.ClmFechaFactura.Frozen = True
        Me.ClmFechaFactura.HeaderText = "Fecha Factura"
        Me.ClmFechaFactura.Name = "ClmFechaFactura"
        Me.ClmFechaFactura.Width = 120
        '
        'clmImporte
        '
        Me.clmImporte.DataPropertyName = "Importe"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.clmImporte.DefaultCellStyle = DataGridViewCellStyle6
        Me.clmImporte.Frozen = True
        Me.clmImporte.HeaderText = "Importe"
        Me.clmImporte.Name = "clmImporte"
        Me.clmImporte.Width = 120
        '
        'ClmFechaContable
        '
        Me.ClmFechaContable.DataPropertyName = "FechaContabilizacion"
        Me.ClmFechaContable.Frozen = True
        Me.ClmFechaContable.HeaderText = "Fecha Contable"
        Me.ClmFechaContable.Name = "ClmFechaContable"
        Me.ClmFechaContable.Width = 120
        '
        'clmIdProveedor
        '
        Me.clmIdProveedor.DataPropertyName = "IdProveedor"
        Me.clmIdProveedor.Frozen = True
        Me.clmIdProveedor.HeaderText = "IdProvedor"
        Me.clmIdProveedor.Name = "clmIdProveedor"
        Me.clmIdProveedor.Visible = False
        '
        'dtpFechaCorte
        '
        Me.dtpFechaCorte.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaCorte.Location = New System.Drawing.Point(486, 64)
        Me.dtpFechaCorte.Name = "dtpFechaCorte"
        Me.dtpFechaCorte.Size = New System.Drawing.Size(93, 20)
        Me.dtpFechaCorte.TabIndex = 113
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(412, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "Fecha Corte:"
        '
        'CmbProveedor
        '
        Me.CmbProveedor.FormattingEnabled = True
        Me.CmbProveedor.Location = New System.Drawing.Point(120, 63)
        Me.CmbProveedor.Name = "CmbProveedor"
        Me.CmbProveedor.Size = New System.Drawing.Size(279, 21)
        Me.CmbProveedor.TabIndex = 111
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 110
        Me.Label1.Text = "Proveedor:"
        '
        '_390AuxiliardePasivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 421)
        Me.Controls.Add(Me.lblEmpresa)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtpFechaCorte)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbProveedor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.mtb)
        Me.Name = "_390AuxiliardePasivos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REPORTE DE AUXILIAR DE PASIVOS"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgvFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents lblEmpresa As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DgvFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents dtpFechaCorte As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents check As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ClmNoFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmFechaCaptura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmFechaFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmFechaContable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
