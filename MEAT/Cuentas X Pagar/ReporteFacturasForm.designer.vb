<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteFacturasForm
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
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DtpFecFin = New System.Windows.Forms.DateTimePicker
        Me.DtpFecInicio = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.CmbTipoProveedor = New System.Windows.Forms.ComboBox
        Me.lblEmpresa = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.CmbProveedor = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DgvFacturas = New System.Windows.Forms.DataGridView
        Me.ClmNoFactura = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmIdProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmTipoProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmFechaFactura = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmFechaVen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmDescuento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmIva = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmCheque = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DgvDetFacturas = New System.Windows.Forms.DataGridView
        Me.ClmFolioRecepcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmFechaRecepcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmProducto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmProveedorRec = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmSubtotalRec = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmIvaRec = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmTotalRec = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmEstatusRec = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chkServicio = New System.Windows.Forms.CheckBox
        Me.TmProveedor = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgvDetFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.mtb.Size = New System.Drawing.Size(50, 486)
        Me.mtb.TabIndex = 67
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
        Me.lblTitulo.Size = New System.Drawing.Size(757, 29)
        Me.lblTitulo.TabIndex = 99
        Me.lblTitulo.Text = "REPORTE DE FACTURAS"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "Tipo Proveedor:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "Proveedor:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DtpFecFin)
        Me.GroupBox1.Controls.Add(Me.DtpFecInicio)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(613, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(181, 80)
        Me.GroupBox1.TabIndex = 102
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rango"
        '
        'DtpFecFin
        '
        Me.DtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecFin.Location = New System.Drawing.Point(80, 50)
        Me.DtpFecFin.Name = "DtpFecFin"
        Me.DtpFecFin.Size = New System.Drawing.Size(92, 20)
        Me.DtpFecFin.TabIndex = 3
        '
        'DtpFecInicio
        '
        Me.DtpFecInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecInicio.Location = New System.Drawing.Point(80, 21)
        Me.DtpFecInicio.Name = "DtpFecInicio"
        Me.DtpFecInicio.Size = New System.Drawing.Size(92, 20)
        Me.DtpFecInicio.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Fecha Fin:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Fecha Inicio:"
        '
        'CmbTipoProveedor
        '
        Me.CmbTipoProveedor.FormattingEnabled = True
        Me.CmbTipoProveedor.Location = New System.Drawing.Point(172, 90)
        Me.CmbTipoProveedor.Name = "CmbTipoProveedor"
        Me.CmbTipoProveedor.Size = New System.Drawing.Size(235, 21)
        Me.CmbTipoProveedor.TabIndex = 103
        '
        'lblEmpresa
        '
        Me.lblEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmpresa.Location = New System.Drawing.Point(172, 43)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(390, 20)
        Me.lblEmpresa.TabIndex = 104
        Me.lblEmpresa.Text = "Label3"
        Me.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(83, 47)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 13)
        Me.Label18.TabIndex = 105
        Me.Label18.Text = "Empresa:"
        '
        'CmbProveedor
        '
        Me.CmbProveedor.FormattingEnabled = True
        Me.CmbProveedor.Location = New System.Drawing.Point(172, 116)
        Me.CmbProveedor.Name = "CmbProveedor"
        Me.CmbProveedor.Size = New System.Drawing.Size(235, 21)
        Me.CmbProveedor.TabIndex = 106
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DgvFacturas)
        Me.GroupBox2.Location = New System.Drawing.Point(66, 164)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(731, 147)
        Me.GroupBox2.TabIndex = 107
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Facturas"
        '
        'DgvFacturas
        '
        Me.DgvFacturas.AllowUserToAddRows = False
        Me.DgvFacturas.AllowUserToDeleteRows = False
        Me.DgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClmNoFactura, Me.ClmIdProveedor, Me.ClmProveedor, Me.ClmTipoProveedor, Me.ClmFechaFactura, Me.ClmFechaVen, Me.ClmSubtotal, Me.ClmDescuento, Me.ClmIva, Me.ClmTotal, Me.ClmCheque, Me.ClmEstatus})
        Me.DgvFacturas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvFacturas.Location = New System.Drawing.Point(3, 16)
        Me.DgvFacturas.Name = "DgvFacturas"
        Me.DgvFacturas.ReadOnly = True
        Me.DgvFacturas.RowHeadersVisible = False
        Me.DgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvFacturas.Size = New System.Drawing.Size(725, 128)
        Me.DgvFacturas.TabIndex = 0
        '
        'ClmNoFactura
        '
        Me.ClmNoFactura.DataPropertyName = "NoFactura"
        Me.ClmNoFactura.Frozen = True
        Me.ClmNoFactura.HeaderText = "No Factura"
        Me.ClmNoFactura.MaxInputLength = 20
        Me.ClmNoFactura.Name = "ClmNoFactura"
        Me.ClmNoFactura.ReadOnly = True
        Me.ClmNoFactura.Width = 90
        '
        'ClmIdProveedor
        '
        Me.ClmIdProveedor.DataPropertyName = "IdProveedor"
        Me.ClmIdProveedor.HeaderText = "IdProveedor"
        Me.ClmIdProveedor.Name = "ClmIdProveedor"
        Me.ClmIdProveedor.ReadOnly = True
        Me.ClmIdProveedor.Visible = False
        '
        'ClmProveedor
        '
        Me.ClmProveedor.DataPropertyName = "PrRazSocial"
        Me.ClmProveedor.Frozen = True
        Me.ClmProveedor.HeaderText = "Proveedor"
        Me.ClmProveedor.Name = "ClmProveedor"
        Me.ClmProveedor.ReadOnly = True
        '
        'ClmTipoProveedor
        '
        Me.ClmTipoProveedor.DataPropertyName = "TprDescripcion"
        Me.ClmTipoProveedor.Frozen = True
        Me.ClmTipoProveedor.HeaderText = "Tipo Proveedor"
        Me.ClmTipoProveedor.Name = "ClmTipoProveedor"
        Me.ClmTipoProveedor.ReadOnly = True
        Me.ClmTipoProveedor.Width = 115
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
        'ClmFechaVen
        '
        Me.ClmFechaVen.DataPropertyName = "FechaVencimiento"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.ClmFechaVen.DefaultCellStyle = DataGridViewCellStyle2
        Me.ClmFechaVen.HeaderText = "Fecha Vencimiento"
        Me.ClmFechaVen.Name = "ClmFechaVen"
        Me.ClmFechaVen.ReadOnly = True
        Me.ClmFechaVen.Width = 130
        '
        'ClmSubtotal
        '
        Me.ClmSubtotal.DataPropertyName = "Subtotal"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ClmSubtotal.DefaultCellStyle = DataGridViewCellStyle3
        Me.ClmSubtotal.HeaderText = "Subtotal"
        Me.ClmSubtotal.Name = "ClmSubtotal"
        Me.ClmSubtotal.ReadOnly = True
        '
        'ClmDescuento
        '
        Me.ClmDescuento.HeaderText = "Descuento"
        Me.ClmDescuento.Name = "ClmDescuento"
        Me.ClmDescuento.ReadOnly = True
        Me.ClmDescuento.Visible = False
        '
        'ClmIva
        '
        Me.ClmIva.DataPropertyName = "Iva"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.ClmIva.DefaultCellStyle = DataGridViewCellStyle4
        Me.ClmIva.HeaderText = "IVA"
        Me.ClmIva.Name = "ClmIva"
        Me.ClmIva.ReadOnly = True
        Me.ClmIva.Width = 90
        '
        'ClmTotal
        '
        Me.ClmTotal.DataPropertyName = "Total"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Bisque
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.ClmTotal.DefaultCellStyle = DataGridViewCellStyle5
        Me.ClmTotal.HeaderText = "Total"
        Me.ClmTotal.Name = "ClmTotal"
        Me.ClmTotal.ReadOnly = True
        '
        'ClmCheque
        '
        Me.ClmCheque.DataPropertyName = "Cheque"
        Me.ClmCheque.HeaderText = "Cheque"
        Me.ClmCheque.Name = "ClmCheque"
        Me.ClmCheque.ReadOnly = True
        '
        'ClmEstatus
        '
        Me.ClmEstatus.DataPropertyName = "EstatusFacturas"
        Me.ClmEstatus.HeaderText = "Estatus"
        Me.ClmEstatus.Name = "ClmEstatus"
        Me.ClmEstatus.ReadOnly = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DgvDetFacturas)
        Me.GroupBox3.Location = New System.Drawing.Point(66, 317)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(731, 157)
        Me.GroupBox3.TabIndex = 108
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Recepciones de la Factura"
        '
        'DgvDetFacturas
        '
        Me.DgvDetFacturas.AllowUserToAddRows = False
        Me.DgvDetFacturas.AllowUserToDeleteRows = False
        Me.DgvDetFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClmFolioRecepcion, Me.ClmFechaRecepcion, Me.ClmProducto, Me.ClmProveedorRec, Me.ClmCantidad, Me.ClmSubtotalRec, Me.ClmIvaRec, Me.ClmTotalRec, Me.ClmEstatusRec})
        Me.DgvDetFacturas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvDetFacturas.Location = New System.Drawing.Point(3, 16)
        Me.DgvDetFacturas.Name = "DgvDetFacturas"
        Me.DgvDetFacturas.ReadOnly = True
        Me.DgvDetFacturas.RowHeadersVisible = False
        Me.DgvDetFacturas.Size = New System.Drawing.Size(725, 138)
        Me.DgvDetFacturas.TabIndex = 0
        '
        'ClmFolioRecepcion
        '
        Me.ClmFolioRecepcion.HeaderText = "Folio Recepción"
        Me.ClmFolioRecepcion.Name = "ClmFolioRecepcion"
        Me.ClmFolioRecepcion.ReadOnly = True
        Me.ClmFolioRecepcion.Width = 110
        '
        'ClmFechaRecepcion
        '
        DataGridViewCellStyle6.Format = "d"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.ClmFechaRecepcion.DefaultCellStyle = DataGridViewCellStyle6
        Me.ClmFechaRecepcion.HeaderText = "Fecha"
        Me.ClmFechaRecepcion.Name = "ClmFechaRecepcion"
        Me.ClmFechaRecepcion.ReadOnly = True
        '
        'ClmProducto
        '
        Me.ClmProducto.HeaderText = "Producto"
        Me.ClmProducto.Name = "ClmProducto"
        Me.ClmProducto.ReadOnly = True
        Me.ClmProducto.Visible = False
        '
        'ClmProveedorRec
        '
        Me.ClmProveedorRec.HeaderText = "Proveedor"
        Me.ClmProveedorRec.Name = "ClmProveedorRec"
        Me.ClmProveedorRec.ReadOnly = True
        Me.ClmProveedorRec.Visible = False
        '
        'ClmCantidad
        '
        Me.ClmCantidad.HeaderText = "Cantidad"
        Me.ClmCantidad.Name = "ClmCantidad"
        Me.ClmCantidad.ReadOnly = True
        '
        'ClmSubtotalRec
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.ClmSubtotalRec.DefaultCellStyle = DataGridViewCellStyle7
        Me.ClmSubtotalRec.HeaderText = "Subtotal"
        Me.ClmSubtotalRec.Name = "ClmSubtotalRec"
        Me.ClmSubtotalRec.ReadOnly = True
        '
        'ClmIvaRec
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle8.Format = "C2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.ClmIvaRec.DefaultCellStyle = DataGridViewCellStyle8
        Me.ClmIvaRec.HeaderText = "Iva"
        Me.ClmIvaRec.Name = "ClmIvaRec"
        Me.ClmIvaRec.ReadOnly = True
        '
        'ClmTotalRec
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle9.Format = "C2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.ClmTotalRec.DefaultCellStyle = DataGridViewCellStyle9
        Me.ClmTotalRec.HeaderText = "Total"
        Me.ClmTotalRec.Name = "ClmTotalRec"
        Me.ClmTotalRec.ReadOnly = True
        '
        'ClmEstatusRec
        '
        Me.ClmEstatusRec.HeaderText = "Estatus"
        Me.ClmEstatusRec.Name = "ClmEstatusRec"
        Me.ClmEstatusRec.ReadOnly = True
        '
        'chkServicio
        '
        Me.chkServicio.AutoSize = True
        Me.chkServicio.Location = New System.Drawing.Point(439, 93)
        Me.chkServicio.Name = "chkServicio"
        Me.chkServicio.Size = New System.Drawing.Size(123, 17)
        Me.chkServicio.TabIndex = 109
        Me.chkServicio.Text = "Facturas de Servicio"
        Me.chkServicio.UseVisualStyleBackColor = True
        '
        'TmProveedor
        '
        Me.TmProveedor.Interval = 1000
        '
        'ReporteFacturasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 486)
        Me.Controls.Add(Me.chkServicio)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.CmbProveedor)
        Me.Controls.Add(Me.lblEmpresa)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.CmbTipoProveedor)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ReporteFacturasForm"
        Me.Text = "Reporte de Facturas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DgvFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DgvDetFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DtpFecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpFecInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmbTipoProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents lblEmpresa As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents CmbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DgvFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DgvDetFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents ClmNoFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmIdProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmTipoProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmFechaFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmFechaVen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmSubtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmDescuento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmIva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmCheque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkServicio As System.Windows.Forms.CheckBox
    Friend WithEvents ClmFolioRecepcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmFechaRecepcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmProveedorRec As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmSubtotalRec As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmIvaRec As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmTotalRec As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmEstatusRec As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TmProveedor As System.Windows.Forms.Timer
End Class
