<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturasNotas
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
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbDomiciliosFiscales = New System.Windows.Forms.ComboBox()
        Me.CmbCliente = New System.Windows.Forms.ComboBox()
        Me.txtFolioNota = New System.Windows.Forms.TextBox()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotaVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescuentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IEPSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.lblUUID = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lvNotasVenta = New System.Windows.Forms.ListView()
        Me.dgvDetalleConcentrado = New System.Windows.Forms.DataGridView()
        Me.clmCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmUniMed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPrecioUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmIva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmIEPS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPorcIEPS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmNotaVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtUUID = New System.Windows.Forms.TextBox()
        Me.txtCodigoCliente = New System.Windows.Forms.TextBox()
        Me.dtpFechaVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rdCredito = New System.Windows.Forms.RadioButton()
        Me.rdContado = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtIEPS = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtIVA = New System.Windows.Forms.TextBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.txtDiasCredito = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtRFC = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblEstatus = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFolioFactura = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtFechaFactura = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar()
        Me.pdDocumento = New System.Drawing.Printing.PrintDocument()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalleConcentrado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmbDomiciliosFiscales)
        Me.GroupBox1.Controls.Add(Me.CmbCliente)
        Me.GroupBox1.Controls.Add(Me.txtFolioNota)
        Me.GroupBox1.Controls.Add(Me.dgvDetalle)
        Me.GroupBox1.Controls.Add(Me.txtSerie)
        Me.GroupBox1.Controls.Add(Me.lblUUID)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lvNotasVenta)
        Me.GroupBox1.Controls.Add(Me.dgvDetalleConcentrado)
        Me.GroupBox1.Controls.Add(Me.txtUUID)
        Me.GroupBox1.Controls.Add(Me.txtCodigoCliente)
        Me.GroupBox1.Controls.Add(Me.dtpFechaVencimiento)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.txtDiasCredito)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtRFC)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lblEstatus)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtFolioFactura)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtFechaFactura)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(55, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(791, 495)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cmbDomiciliosFiscales
        '
        Me.cmbDomiciliosFiscales.FormattingEnabled = True
        Me.cmbDomiciliosFiscales.Location = New System.Drawing.Point(98, 118)
        Me.cmbDomiciliosFiscales.Name = "cmbDomiciliosFiscales"
        Me.cmbDomiciliosFiscales.Size = New System.Drawing.Size(370, 21)
        Me.cmbDomiciliosFiscales.TabIndex = 42
        '
        'CmbCliente
        '
        Me.CmbCliente.FormattingEnabled = True
        Me.CmbCliente.Location = New System.Drawing.Point(169, 64)
        Me.CmbCliente.Name = "CmbCliente"
        Me.CmbCliente.Size = New System.Drawing.Size(299, 21)
        Me.CmbCliente.TabIndex = 6
        '
        'txtFolioNota
        '
        Me.txtFolioNota.Location = New System.Drawing.Point(486, 64)
        Me.txtFolioNota.Name = "txtFolioNota"
        Me.txtFolioNota.Size = New System.Drawing.Size(123, 20)
        Me.txtFolioNota.TabIndex = 10
        Me.txtFolioNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn, Me.NotaVentaDataGridViewTextBoxColumn, Me.IdProductoDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn, Me.DescuentoDataGridViewTextBoxColumn, Me.IVADataGridViewTextBoxColumn, Me.IEPSDataGridViewTextBoxColumn})
        Me.dgvDetalle.Location = New System.Drawing.Point(12, 339)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.Size = New System.Drawing.Size(762, 136)
        Me.dgvDetalle.TabIndex = 14
        Me.dgvDetalle.Visible = False
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        '
        'NotaVentaDataGridViewTextBoxColumn
        '
        Me.NotaVentaDataGridViewTextBoxColumn.DataPropertyName = "NotaVenta"
        Me.NotaVentaDataGridViewTextBoxColumn.HeaderText = "NotaVenta"
        Me.NotaVentaDataGridViewTextBoxColumn.Name = "NotaVentaDataGridViewTextBoxColumn"
        '
        'IdProductoDataGridViewTextBoxColumn
        '
        Me.IdProductoDataGridViewTextBoxColumn.DataPropertyName = "IdProducto"
        Me.IdProductoDataGridViewTextBoxColumn.HeaderText = "IdProducto"
        Me.IdProductoDataGridViewTextBoxColumn.Name = "IdProductoDataGridViewTextBoxColumn"
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        '
        'ImporteDataGridViewTextBoxColumn
        '
        Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
        '
        'DescuentoDataGridViewTextBoxColumn
        '
        Me.DescuentoDataGridViewTextBoxColumn.DataPropertyName = "Descuento"
        Me.DescuentoDataGridViewTextBoxColumn.HeaderText = "Descuento"
        Me.DescuentoDataGridViewTextBoxColumn.Name = "DescuentoDataGridViewTextBoxColumn"
        '
        'IVADataGridViewTextBoxColumn
        '
        Me.IVADataGridViewTextBoxColumn.DataPropertyName = "IVA"
        Me.IVADataGridViewTextBoxColumn.HeaderText = "IVA"
        Me.IVADataGridViewTextBoxColumn.Name = "IVADataGridViewTextBoxColumn"
        '
        'IEPSDataGridViewTextBoxColumn
        '
        Me.IEPSDataGridViewTextBoxColumn.DataPropertyName = "IEPS"
        Me.IEPSDataGridViewTextBoxColumn.HeaderText = "IEPS"
        Me.IEPSDataGridViewTextBoxColumn.Name = "IEPSDataGridViewTextBoxColumn"
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(98, 12)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.ReadOnly = True
        Me.txtSerie.Size = New System.Drawing.Size(34, 20)
        Me.txtSerie.TabIndex = 41
        '
        'lblUUID
        '
        Me.lblUUID.AutoSize = True
        Me.lblUUID.Location = New System.Drawing.Point(258, 16)
        Me.lblUUID.Name = "lblUUID"
        Me.lblUUID.Size = New System.Drawing.Size(37, 13)
        Me.lblUUID.TabIndex = 40
        Me.lblUUID.Text = "UUID:"
        Me.lblUUID.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(528, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 20)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = ">>"
        Me.ToolTip1.SetToolTip(Me.Button1, "Muestra el folio consecutivo")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Domicilio Fiscal:"
        '
        'lvNotasVenta
        '
        Me.lvNotasVenta.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.lvNotasVenta.LabelWrap = False
        Me.lvNotasVenta.Location = New System.Drawing.Point(615, 64)
        Me.lvNotasVenta.MultiSelect = False
        Me.lvNotasVenta.Name = "lvNotasVenta"
        Me.lvNotasVenta.ShowGroups = False
        Me.lvNotasVenta.Size = New System.Drawing.Size(159, 48)
        Me.lvNotasVenta.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvNotasVenta.TabIndex = 37
        Me.lvNotasVenta.UseCompatibleStateImageBehavior = False
        Me.lvNotasVenta.View = System.Windows.Forms.View.List
        '
        'dgvDetalleConcentrado
        '
        Me.dgvDetalleConcentrado.AllowUserToAddRows = False
        Me.dgvDetalleConcentrado.AllowUserToDeleteRows = False
        Me.dgvDetalleConcentrado.AllowUserToResizeRows = False
        Me.dgvDetalleConcentrado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDetalleConcentrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleConcentrado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmCodigo, Me.clmCantidad, Me.clmUniMed, Me.clmDescripcion, Me.clmPrecioUnit, Me.clmImporte, Me.clmIva, Me.clmIEPS, Me.clmPorcIEPS, Me.clmTotal, Me.clmNotaVenta})
        Me.dgvDetalleConcentrado.Location = New System.Drawing.Point(6, 244)
        Me.dgvDetalleConcentrado.Name = "dgvDetalleConcentrado"
        Me.dgvDetalleConcentrado.ReadOnly = True
        Me.dgvDetalleConcentrado.RowHeadersVisible = False
        Me.dgvDetalleConcentrado.Size = New System.Drawing.Size(779, 240)
        Me.dgvDetalleConcentrado.TabIndex = 15
        '
        'clmCodigo
        '
        Me.clmCodigo.DataPropertyName = "Codigo"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle17.Format = "N0"
        DataGridViewCellStyle17.NullValue = Nothing
        Me.clmCodigo.DefaultCellStyle = DataGridViewCellStyle17
        Me.clmCodigo.FillWeight = 5.0!
        Me.clmCodigo.HeaderText = "Codigo"
        Me.clmCodigo.Name = "clmCodigo"
        Me.clmCodigo.ReadOnly = True
        '
        'clmCantidad
        '
        Me.clmCantidad.DataPropertyName = "Cantidad"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle18.Format = "N4"
        DataGridViewCellStyle18.NullValue = Nothing
        Me.clmCantidad.DefaultCellStyle = DataGridViewCellStyle18
        Me.clmCantidad.FillWeight = 10.0!
        Me.clmCantidad.HeaderText = "Cantidad"
        Me.clmCantidad.Name = "clmCantidad"
        Me.clmCantidad.ReadOnly = True
        '
        'clmUniMed
        '
        Me.clmUniMed.DataPropertyName = "Unidad"
        Me.clmUniMed.FillWeight = 10.0!
        Me.clmUniMed.HeaderText = "Unidad"
        Me.clmUniMed.Name = "clmUniMed"
        Me.clmUniMed.ReadOnly = True
        '
        'clmDescripcion
        '
        Me.clmDescripcion.DataPropertyName = "Descripcion"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.clmDescripcion.DefaultCellStyle = DataGridViewCellStyle19
        Me.clmDescripcion.FillWeight = 25.0!
        Me.clmDescripcion.HeaderText = "Descripcion"
        Me.clmDescripcion.Name = "clmDescripcion"
        Me.clmDescripcion.ReadOnly = True
        '
        'clmPrecioUnit
        '
        Me.clmPrecioUnit.DataPropertyName = "PrecioUnitario"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle20.Format = "N2"
        DataGridViewCellStyle20.NullValue = Nothing
        Me.clmPrecioUnit.DefaultCellStyle = DataGridViewCellStyle20
        Me.clmPrecioUnit.FillWeight = 10.0!
        Me.clmPrecioUnit.HeaderText = "Precio Unitario"
        Me.clmPrecioUnit.Name = "clmPrecioUnit"
        Me.clmPrecioUnit.ReadOnly = True
        '
        'clmImporte
        '
        Me.clmImporte.DataPropertyName = "Importe"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle21.Format = "N2"
        DataGridViewCellStyle21.NullValue = Nothing
        Me.clmImporte.DefaultCellStyle = DataGridViewCellStyle21
        Me.clmImporte.FillWeight = 10.0!
        Me.clmImporte.HeaderText = "Importe"
        Me.clmImporte.Name = "clmImporte"
        Me.clmImporte.ReadOnly = True
        '
        'clmIva
        '
        Me.clmIva.DataPropertyName = "Iva"
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle22.Format = "N2"
        DataGridViewCellStyle22.NullValue = Nothing
        Me.clmIva.DefaultCellStyle = DataGridViewCellStyle22
        Me.clmIva.FillWeight = 10.0!
        Me.clmIva.HeaderText = "IVA"
        Me.clmIva.Name = "clmIva"
        Me.clmIva.ReadOnly = True
        '
        'clmIEPS
        '
        Me.clmIEPS.DataPropertyName = "Ieps"
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle23.Format = "N2"
        DataGridViewCellStyle23.NullValue = Nothing
        Me.clmIEPS.DefaultCellStyle = DataGridViewCellStyle23
        Me.clmIEPS.FillWeight = 10.0!
        Me.clmIEPS.HeaderText = "IEPS"
        Me.clmIEPS.Name = "clmIEPS"
        Me.clmIEPS.ReadOnly = True
        '
        'clmPorcIEPS
        '
        Me.clmPorcIEPS.FillWeight = 10.0!
        Me.clmPorcIEPS.HeaderText = "Porc IEPS"
        Me.clmPorcIEPS.Name = "clmPorcIEPS"
        Me.clmPorcIEPS.ReadOnly = True
        Me.clmPorcIEPS.Visible = False
        '
        'clmTotal
        '
        Me.clmTotal.DataPropertyName = "Total"
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle24.Format = "N2"
        DataGridViewCellStyle24.NullValue = Nothing
        Me.clmTotal.DefaultCellStyle = DataGridViewCellStyle24
        Me.clmTotal.FillWeight = 10.0!
        Me.clmTotal.HeaderText = "Total"
        Me.clmTotal.Name = "clmTotal"
        Me.clmTotal.ReadOnly = True
        '
        'clmNotaVenta
        '
        Me.clmNotaVenta.HeaderText = "NotaVenta"
        Me.clmNotaVenta.Name = "clmNotaVenta"
        Me.clmNotaVenta.ReadOnly = True
        Me.clmNotaVenta.Visible = False
        '
        'txtUUID
        '
        Me.txtUUID.Enabled = False
        Me.txtUUID.Location = New System.Drawing.Point(301, 12)
        Me.txtUUID.Name = "txtUUID"
        Me.txtUUID.ReadOnly = True
        Me.txtUUID.Size = New System.Drawing.Size(308, 20)
        Me.txtUUID.TabIndex = 20
        Me.txtUUID.Visible = False
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.Location = New System.Drawing.Point(98, 65)
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.Size = New System.Drawing.Size(65, 20)
        Me.txtCodigoCliente.TabIndex = 5
        '
        'dtpFechaVencimiento
        '
        Me.dtpFechaVencimiento.Enabled = False
        Me.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaVencimiento.Location = New System.Drawing.Point(380, 38)
        Me.dtpFechaVencimiento.Name = "dtpFechaVencimiento"
        Me.dtpFechaVencimiento.Size = New System.Drawing.Size(88, 20)
        Me.dtpFechaVencimiento.TabIndex = 4
        Me.dtpFechaVencimiento.Value = New Date(2007, 7, 31, 0, 0, 0, 0)
        Me.dtpFechaVencimiento.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(270, 41)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(104, 13)
        Me.Label18.TabIndex = 27
        Me.Label18.Text = "Fecha Vencimiento :"
        Me.Label18.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rdCredito)
        Me.GroupBox4.Controls.Add(Me.rdContado)
        Me.GroupBox4.Location = New System.Drawing.Point(486, 144)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(98, 88)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tipo Factura"
        Me.GroupBox4.Visible = False
        '
        'rdCredito
        '
        Me.rdCredito.AutoSize = True
        Me.rdCredito.Location = New System.Drawing.Point(11, 48)
        Me.rdCredito.Name = "rdCredito"
        Me.rdCredito.Size = New System.Drawing.Size(58, 17)
        Me.rdCredito.TabIndex = 14
        Me.rdCredito.TabStop = True
        Me.rdCredito.Text = "Crédito"
        Me.rdCredito.UseVisualStyleBackColor = True
        '
        'rdContado
        '
        Me.rdContado.AutoSize = True
        Me.rdContado.Location = New System.Drawing.Point(11, 24)
        Me.rdContado.Name = "rdContado"
        Me.rdContado.Size = New System.Drawing.Size(65, 17)
        Me.rdContado.TabIndex = 13
        Me.rdContado.TabStop = True
        Me.rdContado.Text = "Contado"
        Me.rdContado.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtIEPS)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtTotal)
        Me.GroupBox3.Controls.Add(Me.txtIVA)
        Me.GroupBox3.Controls.Add(Me.txtSubTotal)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox3.Location = New System.Drawing.Point(606, 121)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(179, 122)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Importes"
        '
        'txtIEPS
        '
        Me.txtIEPS.Enabled = False
        Me.txtIEPS.Location = New System.Drawing.Point(68, 71)
        Me.txtIEPS.Name = "txtIEPS"
        Me.txtIEPS.ReadOnly = True
        Me.txtIEPS.Size = New System.Drawing.Size(100, 20)
        Me.txtIEPS.TabIndex = 24
        Me.txtIEPS.TabStop = False
        Me.txtIEPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(6, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "IEPS :"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(68, 97)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 22
        Me.txtTotal.TabStop = False
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIVA
        '
        Me.txtIVA.Enabled = False
        Me.txtIVA.Location = New System.Drawing.Point(68, 45)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.ReadOnly = True
        Me.txtIVA.Size = New System.Drawing.Size(100, 20)
        Me.txtIVA.TabIndex = 21
        Me.txtIVA.TabStop = False
        Me.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Enabled = False
        Me.txtSubTotal.Location = New System.Drawing.Point(68, 19)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubTotal.TabIndex = 19
        Me.txtSubTotal.TabStop = False
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(6, 100)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Total  :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(6, 45)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(30, 13)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "IVA :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(6, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 13)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "SubTotal :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 147)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Observaciones :"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(98, 147)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(370, 88)
        Me.txtObservaciones.TabIndex = 9
        '
        'txtDiasCredito
        '
        Me.txtDiasCredito.Enabled = False
        Me.txtDiasCredito.Location = New System.Drawing.Point(409, 91)
        Me.txtDiasCredito.Name = "txtDiasCredito"
        Me.txtDiasCredito.ReadOnly = True
        Me.txtDiasCredito.Size = New System.Drawing.Size(59, 20)
        Me.txtDiasCredito.TabIndex = 30
        Me.txtDiasCredito.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(331, 94)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 13)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Días Crédito :"
        Me.Label14.Visible = False
        '
        'txtRFC
        '
        Me.txtRFC.Enabled = False
        Me.txtRFC.Location = New System.Drawing.Point(98, 91)
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.ReadOnly = True
        Me.txtRFC.Size = New System.Drawing.Size(157, 20)
        Me.txtRFC.TabIndex = 7
        Me.txtRFC.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 91)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "R.F.C. :"
        '
        'lblEstatus
        '
        Me.lblEstatus.AutoSize = True
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(631, 14)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(104, 24)
        Me.lblEstatus.TabIndex = 15
        Me.lblEstatus.Text = "ESTATUS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(483, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Folio Nota de Venta :"
        '
        'txtFolioFactura
        '
        Me.txtFolioFactura.Location = New System.Drawing.Point(138, 12)
        Me.txtFolioFactura.Name = "txtFolioFactura"
        Me.txtFolioFactura.ReadOnly = True
        Me.txtFolioFactura.Size = New System.Drawing.Size(91, 20)
        Me.txtFolioFactura.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Cliente :"
        '
        'dtFechaFactura
        '
        Me.dtFechaFactura.CustomFormat = "dd/MM/yyyy hh:mm:ss"
        Me.dtFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFechaFactura.Location = New System.Drawing.Point(98, 40)
        Me.dtFechaFactura.Name = "dtFechaFactura"
        Me.dtFechaFactura.Size = New System.Drawing.Size(157, 20)
        Me.dtFechaFactura.TabIndex = 2
        Me.dtFechaFactura.Value = New Date(2007, 7, 31, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha Factura :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(612, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Notas de venta :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Folio Factura :"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(808, 32)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Facturas de Ventas"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.MEAToolBar1.MostrarBorrar = True
        Me.MEAToolBar1.MostrarBuscar = True
        Me.MEAToolBar1.MostrarCancelar = True
        Me.MEAToolBar1.MostrarEditar = True
        Me.MEAToolBar1.MostrarGuardar = True
        Me.MEAToolBar1.MostrarImprimir = True
        Me.MEAToolBar1.MostrarLimpiar = True
        Me.MEAToolBar1.MostrarNuevo = True
        Me.MEAToolBar1.MostrarSalir = True
        Me.MEAToolBar1.Name = "MEAToolBar1"
        Me.MEAToolBar1.ShowToolTips = True
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 542)
        Me.MEAToolBar1.TabIndex = 30
        '
        'frmFacturasNotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 542)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmFacturasNotas"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = " Facturas de Ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalleConcentrado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFolioNota As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtFechaFactura As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFolioFactura As System.Windows.Forms.TextBox
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents txtRFC As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtDiasCredito As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtIVA As System.Windows.Forms.TextBox
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rdCredito As System.Windows.Forms.RadioButton
    Friend WithEvents rdContado As System.Windows.Forms.RadioButton
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents dtpFechaVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoCliente As System.Windows.Forms.TextBox
    Friend WithEvents CuentaControl As IntegraLab.ORM.CollectionClasses.CfgCtrlCtasCollection
    Friend WithEvents txtUUID As System.Windows.Forms.TextBox
    Friend WithEvents dgvDetalleConcentrado As System.Windows.Forms.DataGridView
    Friend WithEvents pdDocumento As System.Drawing.Printing.PrintDocument
    Friend WithEvents lvNotasVenta As System.Windows.Forms.ListView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    ' Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblUUID As System.Windows.Forms.Label
    Friend WithEvents txtIEPS As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents clmPrecio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents CmbCliente As System.Windows.Forms.ComboBox
    Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NotaVentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescuentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IVADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IEPSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DetalleNotaVenta As ClasesNegocio.NotaVentaDetalleCollectionClass
    Friend WithEvents cmbDomiciliosFiscales As System.Windows.Forms.ComboBox
    Friend WithEvents clmCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmUniMed As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPrecioUnit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIEPS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPorcIEPS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmNotaVenta As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
