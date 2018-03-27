<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusquedaFacturasForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TxtFactura = New System.Windows.Forms.TextBox()
        Me.CmbProveedor = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DgvFacturas = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RecepcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.NoFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idfacturacancelada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Factura:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No. Factura:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Proveedor:"
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(543, 29)
        Me.lblTitulo.TabIndex = 55
        Me.lblTitulo.Text = "BÚSQUEDA DE FACTURAS"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(174, 52)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 56
        '
        'TxtFactura
        '
        Me.TxtFactura.Location = New System.Drawing.Point(136, 112)
        Me.TxtFactura.Name = "TxtFactura"
        Me.TxtFactura.Size = New System.Drawing.Size(100, 20)
        Me.TxtFactura.TabIndex = 57
        '
        'CmbProveedor
        '
        Me.CmbProveedor.FormattingEnabled = True
        Me.CmbProveedor.Location = New System.Drawing.Point(136, 138)
        Me.CmbProveedor.Name = "CmbProveedor"
        Me.CmbProveedor.Size = New System.Drawing.Size(292, 21)
        Me.CmbProveedor.TabIndex = 58
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvFacturas)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 179)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(519, 295)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Facturas Registradas"
        '
        'DgvFacturas
        '
        Me.DgvFacturas.AllowUserToAddRows = False
        Me.DgvFacturas.AllowUserToDeleteRows = False
        Me.DgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoFactura, Me.FechaFactura, Me.FechaVencimiento, Me.Proveedor, Me.Importe, Me.Estatus, Me.idfacturacancelada})
        Me.DgvFacturas.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DgvFacturas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvFacturas.Location = New System.Drawing.Point(3, 16)
        Me.DgvFacturas.Name = "DgvFacturas"
        Me.DgvFacturas.ReadOnly = True
        Me.DgvFacturas.RowHeadersVisible = False
        Me.DgvFacturas.RowHeadersWidth = 20
        Me.DgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvFacturas.Size = New System.Drawing.Size(513, 276)
        Me.DgvFacturas.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecepcionesToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(141, 26)
        '
        'RecepcionesToolStripMenuItem
        '
        Me.RecepcionesToolStripMenuItem.Name = "RecepcionesToolStripMenuItem"
        Me.RecepcionesToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.RecepcionesToolStripMenuItem.Text = "Recepciones"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(434, 138)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 60
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(304, 480)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(87, 23)
        Me.BtnAceptar.TabIndex = 61
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(411, 480)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(87, 23)
        Me.BtnCancelar.TabIndex = 62
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(133, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Inicio:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(133, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Fin:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(174, 79)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker2.TabIndex = 65
        '
        'NoFactura
        '
        Me.NoFactura.DataPropertyName = "NoFactura"
        Me.NoFactura.HeaderText = "No Factura"
        Me.NoFactura.Name = "NoFactura"
        Me.NoFactura.ReadOnly = True
        '
        'FechaFactura
        '
        Me.FechaFactura.DataPropertyName = "FechaFactura"
        Me.FechaFactura.HeaderText = "Fecha Factura"
        Me.FechaFactura.Name = "FechaFactura"
        Me.FechaFactura.ReadOnly = True
        '
        'FechaVencimiento
        '
        Me.FechaVencimiento.DataPropertyName = "FechaVencimiento"
        Me.FechaVencimiento.HeaderText = "Fecha Vencimiento"
        Me.FechaVencimiento.Name = "FechaVencimiento"
        Me.FechaVencimiento.ReadOnly = True
        '
        'Proveedor
        '
        Me.Proveedor.DataPropertyName = "PrRazSocial"
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        Me.Proveedor.ReadOnly = True
        Me.Proveedor.Width = 200
        '
        'Importe
        '
        Me.Importe.DataPropertyName = "Importe"
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        '
        'Estatus
        '
        Me.Estatus.DataPropertyName = "EstatusFactura"
        Me.Estatus.HeaderText = "Estatus"
        Me.Estatus.Name = "Estatus"
        Me.Estatus.ReadOnly = True
        '
        'idfacturacancelada
        '
        Me.idfacturacancelada.DataPropertyName = "idfacturacancelada"
        Me.idfacturacancelada.HeaderText = "idfacturacancelada"
        Me.idfacturacancelada.Name = "idfacturacancelada"
        Me.idfacturacancelada.ReadOnly = True
        Me.idfacturacancelada.Visible = False
        '
        'BusquedaFacturasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 509)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CmbProveedor)
        Me.Controls.Add(Me.TxtFactura)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "BusquedaFacturasForm"
        Me.Text = "Búsqueda de Facturas"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgvFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtFactura As System.Windows.Forms.TextBox
    Friend WithEvents CmbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DgvFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RecepcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NoFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaVencimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idfacturacancelada As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
