<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListaPrecio
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblEstatus = New System.Windows.Forms.Label()
        Me.TxtDescCorta = New System.Windows.Forms.TextBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGDetalle = New System.Windows.Forms.DataGridView()
        Me.ProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UtilidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioVentaCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioVentaPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComicionCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LineaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LPDEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LPdIdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListaPrecioDetalleCollectionClass1 = New ClasesNegocio.ListaPrecioDetalleCollectionClass()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.CmbTipoVenta = New System.Windows.Forms.ComboBox()
        Me.TipoVentaC = New ClasesNegocio.TipoVentaCollectionClass()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtUtilidad = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtComVta2 = New System.Windows.Forms.TextBox()
        Me.TxtComVta1 = New System.Windows.Forms.TextBox()
        Me.TxtPreVta2 = New System.Windows.Forms.TextBox()
        Me.TxtPreVta1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ChkBase = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DtpFechaA = New System.Windows.Forms.DateTimePicker()
        Me.DtpFechaDe = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CmbPlaza = New System.Windows.Forms.ComboBox()
        Me.PlazaC = New ClasesNegocio.PlazaCollectionClass()
        Me.TxtPlaza = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnQuitar = New System.Windows.Forms.Button()
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEstatus
        '
        Me.lblEstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(821, 9)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(91, 21)
        Me.lblEstatus.TabIndex = 4
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEstatus.Visible = False
        '
        'TxtDescCorta
        '
        Me.TxtDescCorta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescCorta.Location = New System.Drawing.Point(115, 89)
        Me.TxtDescCorta.MaxLength = 15
        Me.TxtDescCorta.MinimumSize = New System.Drawing.Size(35, 20)
        Me.TxtDescCorta.Name = "TxtDescCorta"
        Me.TxtDescCorta.Size = New System.Drawing.Size(253, 20)
        Me.TxtDescCorta.TabIndex = 11
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescripcion.Location = New System.Drawing.Point(115, 63)
        Me.TxtDescripcion.MaxLength = 50
        Me.TxtDescripcion.MinimumSize = New System.Drawing.Size(35, 20)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(431, 20)
        Me.TxtDescripcion.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DGDetalle)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 201)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(909, 366)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Productos de la Lista de Precios"
        '
        'DGDetalle
        '
        Me.DGDetalle.AllowUserToAddRows = False
        Me.DGDetalle.AllowUserToDeleteRows = False
        Me.DGDetalle.AllowUserToResizeRows = False
        Me.DGDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGDetalle.AutoGenerateColumns = False
        Me.DGDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductoDataGridViewTextBoxColumn, Me.CostoDataGridViewTextBoxColumn, Me.UtilidadDataGridViewTextBoxColumn, Me.PrecioVentaCDataGridViewTextBoxColumn, Me.PrecioVentaPDataGridViewTextBoxColumn, Me.ComicionCDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.MarcaDataGridViewTextBoxColumn, Me.LineaDataGridViewTextBoxColumn, Me.LPDEstatus, Me.LPdIdProducto})
        Me.DGDetalle.DataSource = Me.ListaPrecioDetalleCollectionClass1
        Me.DGDetalle.Location = New System.Drawing.Point(6, 23)
        Me.DGDetalle.Name = "DGDetalle"
        Me.DGDetalle.ReadOnly = True
        Me.DGDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGDetalle.Size = New System.Drawing.Size(897, 343)
        Me.DGDetalle.TabIndex = 0
        '
        'ProductoDataGridViewTextBoxColumn
        '
        Me.ProductoDataGridViewTextBoxColumn.DataPropertyName = "NomProducto"
        Me.ProductoDataGridViewTextBoxColumn.Frozen = True
        Me.ProductoDataGridViewTextBoxColumn.HeaderText = "Producto"
        Me.ProductoDataGridViewTextBoxColumn.Name = "ProductoDataGridViewTextBoxColumn"
        Me.ProductoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductoDataGridViewTextBoxColumn.Width = 270
        '
        'CostoDataGridViewTextBoxColumn
        '
        Me.CostoDataGridViewTextBoxColumn.DataPropertyName = "Costo"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.CostoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.CostoDataGridViewTextBoxColumn.HeaderText = "Costo"
        Me.CostoDataGridViewTextBoxColumn.Name = "CostoDataGridViewTextBoxColumn"
        Me.CostoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CostoDataGridViewTextBoxColumn.Width = 70
        '
        'UtilidadDataGridViewTextBoxColumn
        '
        Me.UtilidadDataGridViewTextBoxColumn.DataPropertyName = "Utilidad"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.UtilidadDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.UtilidadDataGridViewTextBoxColumn.HeaderText = "Utilidad"
        Me.UtilidadDataGridViewTextBoxColumn.Name = "UtilidadDataGridViewTextBoxColumn"
        Me.UtilidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioVentaCDataGridViewTextBoxColumn
        '
        Me.PrecioVentaCDataGridViewTextBoxColumn.DataPropertyName = "PrecioVentaC"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.PrecioVentaCDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.PrecioVentaCDataGridViewTextBoxColumn.HeaderText = "$ de P. V."
        Me.PrecioVentaCDataGridViewTextBoxColumn.Name = "PrecioVentaCDataGridViewTextBoxColumn"
        Me.PrecioVentaCDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioVentaCDataGridViewTextBoxColumn.Width = 120
        '
        'PrecioVentaPDataGridViewTextBoxColumn
        '
        Me.PrecioVentaPDataGridViewTextBoxColumn.DataPropertyName = "PrecioVentaP"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.PrecioVentaPDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.PrecioVentaPDataGridViewTextBoxColumn.HeaderText = "% P. V."
        Me.PrecioVentaPDataGridViewTextBoxColumn.Name = "PrecioVentaPDataGridViewTextBoxColumn"
        Me.PrecioVentaPDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioVentaPDataGridViewTextBoxColumn.Width = 120
        '
        'ComicionCDataGridViewTextBoxColumn
        '
        Me.ComicionCDataGridViewTextBoxColumn.DataPropertyName = "ComicionC"
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.ComicionCDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.ComicionCDataGridViewTextBoxColumn.HeaderText = "$ de Comisión"
        Me.ComicionCDataGridViewTextBoxColumn.Name = "ComicionCDataGridViewTextBoxColumn"
        Me.ComicionCDataGridViewTextBoxColumn.ReadOnly = True
        Me.ComicionCDataGridViewTextBoxColumn.Visible = False
        Me.ComicionCDataGridViewTextBoxColumn.Width = 115
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ComisionP"
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn1.HeaderText = "% de Comisión"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 115
        '
        'MarcaDataGridViewTextBoxColumn
        '
        Me.MarcaDataGridViewTextBoxColumn.DataPropertyName = "NomMarca"
        Me.MarcaDataGridViewTextBoxColumn.FillWeight = 60.0!
        Me.MarcaDataGridViewTextBoxColumn.HeaderText = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.Name = "MarcaDataGridViewTextBoxColumn"
        Me.MarcaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LineaDataGridViewTextBoxColumn
        '
        Me.LineaDataGridViewTextBoxColumn.DataPropertyName = "NomLinea"
        Me.LineaDataGridViewTextBoxColumn.FillWeight = 60.0!
        Me.LineaDataGridViewTextBoxColumn.HeaderText = "Linea"
        Me.LineaDataGridViewTextBoxColumn.Name = "LineaDataGridViewTextBoxColumn"
        Me.LineaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LPDEstatus
        '
        Me.LPDEstatus.DataPropertyName = "LPDEstatus"
        Me.LPDEstatus.HeaderText = "LPDEstatus"
        Me.LPDEstatus.Name = "LPDEstatus"
        Me.LPDEstatus.ReadOnly = True
        Me.LPDEstatus.Visible = False
        '
        'LPdIdProducto
        '
        Me.LPdIdProducto.DataPropertyName = "CodProducto"
        Me.LPdIdProducto.HeaderText = "LPdIdProducto"
        Me.LPdIdProducto.Name = "LPdIdProducto"
        Me.LPdIdProducto.ReadOnly = True
        Me.LPdIdProducto.Visible = False
        '
        'ListaPrecioDetalleCollectionClass1
        '
        Me.ListaPrecioDetalleCollectionClass1.AllowEdit = True
        Me.ListaPrecioDetalleCollectionClass1.AllowNew = True
        Me.ListaPrecioDetalleCollectionClass1.AllowRemove = True
        Me.ListaPrecioDetalleCollectionClass1.Name = ""
        Me.ListaPrecioDetalleCollectionClass1.RaiseListChangedEvents = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Descripción Corta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Descripción:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Controls.Add(Me.CmbTipoVenta)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.TxtUtilidad)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.TxtComVta2)
        Me.Panel1.Controls.Add(Me.TxtComVta1)
        Me.Panel1.Controls.Add(Me.TxtPreVta2)
        Me.Panel1.Controls.Add(Me.TxtPreVta1)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.ChkBase)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.DtpFecha)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.DtpFechaA)
        Me.Panel1.Controls.Add(Me.DtpFechaDe)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.CmbPlaza)
        Me.Panel1.Controls.Add(Me.TxtPlaza)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.lblEstatus)
        Me.Panel1.Controls.Add(Me.TxtDescCorta)
        Me.Panel1.Controls.Add(Me.TxtDescripcion)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtCodigo)
        Me.Panel1.Location = New System.Drawing.Point(59, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(915, 570)
        Me.Panel1.TabIndex = 2
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(18, 178)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(43, 13)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "Buscar:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(115, 175)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(253, 20)
        Me.txtBuscar.TabIndex = 30
        '
        'CmbTipoVenta
        '
        Me.CmbTipoVenta.DataSource = Me.TipoVentaC
        Me.CmbTipoVenta.DisplayMember = "Descripcion"
        Me.CmbTipoVenta.FormattingEnabled = True
        Me.CmbTipoVenta.Location = New System.Drawing.Point(115, 141)
        Me.CmbTipoVenta.Name = "CmbTipoVenta"
        Me.CmbTipoVenta.Size = New System.Drawing.Size(253, 21)
        Me.CmbTipoVenta.TabIndex = 18
        Me.CmbTipoVenta.ValueMember = "Codigo"
        Me.CmbTipoVenta.Visible = False
        '
        'TipoVentaC
        '
        Me.TipoVentaC.AllowEdit = True
        Me.TipoVentaC.AllowNew = True
        Me.TipoVentaC.AllowRemove = True
        Me.TipoVentaC.Name = ""
        Me.TipoVentaC.RaiseListChangedEvents = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(18, 145)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 13)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Tipo de Venta:"
        Me.Label14.Visible = False
        '
        'TxtUtilidad
        '
        Me.TxtUtilidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtUtilidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtUtilidad.Enabled = False
        Me.TxtUtilidad.Location = New System.Drawing.Point(437, 175)
        Me.TxtUtilidad.MaximumSize = New System.Drawing.Size(100, 20)
        Me.TxtUtilidad.MaxLength = 14
        Me.TxtUtilidad.MinimumSize = New System.Drawing.Size(35, 20)
        Me.TxtUtilidad.Name = "TxtUtilidad"
        Me.TxtUtilidad.Size = New System.Drawing.Size(89, 20)
        Me.TxtUtilidad.TabIndex = 20
        Me.TxtUtilidad.Visible = False
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(454, 159)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 13)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "$ Utilidad:"
        Me.Label13.Visible = False
        '
        'TxtComVta2
        '
        Me.TxtComVta2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtComVta2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtComVta2.Enabled = False
        Me.TxtComVta2.Location = New System.Drawing.Point(817, 175)
        Me.TxtComVta2.MaximumSize = New System.Drawing.Size(100, 20)
        Me.TxtComVta2.MaxLength = 14
        Me.TxtComVta2.MinimumSize = New System.Drawing.Size(35, 20)
        Me.TxtComVta2.Name = "TxtComVta2"
        Me.TxtComVta2.Size = New System.Drawing.Size(89, 20)
        Me.TxtComVta2.TabIndex = 28
        Me.TxtComVta2.Visible = False
        '
        'TxtComVta1
        '
        Me.TxtComVta1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtComVta1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtComVta1.Enabled = False
        Me.TxtComVta1.Location = New System.Drawing.Point(722, 175)
        Me.TxtComVta1.MaximumSize = New System.Drawing.Size(100, 20)
        Me.TxtComVta1.MaxLength = 14
        Me.TxtComVta1.MinimumSize = New System.Drawing.Size(35, 20)
        Me.TxtComVta1.Name = "TxtComVta1"
        Me.TxtComVta1.Size = New System.Drawing.Size(89, 20)
        Me.TxtComVta1.TabIndex = 26
        Me.TxtComVta1.Visible = False
        '
        'TxtPreVta2
        '
        Me.TxtPreVta2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPreVta2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPreVta2.Enabled = False
        Me.TxtPreVta2.Location = New System.Drawing.Point(627, 175)
        Me.TxtPreVta2.MaximumSize = New System.Drawing.Size(100, 20)
        Me.TxtPreVta2.MaxLength = 14
        Me.TxtPreVta2.MinimumSize = New System.Drawing.Size(35, 20)
        Me.TxtPreVta2.Name = "TxtPreVta2"
        Me.TxtPreVta2.Size = New System.Drawing.Size(89, 20)
        Me.TxtPreVta2.TabIndex = 24
        '
        'TxtPreVta1
        '
        Me.TxtPreVta1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPreVta1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPreVta1.Enabled = False
        Me.TxtPreVta1.Location = New System.Drawing.Point(532, 175)
        Me.TxtPreVta1.MaximumSize = New System.Drawing.Size(100, 20)
        Me.TxtPreVta1.MaxLength = 14
        Me.TxtPreVta1.MinimumSize = New System.Drawing.Size(35, 20)
        Me.TxtPreVta1.Name = "TxtPreVta1"
        Me.TxtPreVta1.Size = New System.Drawing.Size(89, 20)
        Me.TxtPreVta1.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(816, 159)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 13)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "% Comisión Venta:"
        Me.Label12.Visible = False
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(720, 159)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 13)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "$ Comisión Venta:"
        Me.Label11.Visible = False
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(630, 159)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "% Precio Venta:"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(536, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "$ Precio Venta:"
        '
        'ChkBase
        '
        Me.ChkBase.AutoSize = True
        Me.ChkBase.Location = New System.Drawing.Point(385, 91)
        Me.ChkBase.Name = "ChkBase"
        Me.ChkBase.Size = New System.Drawing.Size(161, 17)
        Me.ChkBase.TabIndex = 12
        Me.ChkBase.Text = "¿Es  Lista de Precios Base ?"
        Me.ChkBase.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(381, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Fecha de Alta:"
        '
        'DtpFecha
        '
        Me.DtpFecha.Enabled = False
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(463, 9)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(83, 20)
        Me.DtpFecha.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(209, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "a:"
        '
        'DtpFechaA
        '
        Me.DtpFechaA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaA.Location = New System.Drawing.Point(231, 115)
        Me.DtpFechaA.Name = "DtpFechaA"
        Me.DtpFechaA.Size = New System.Drawing.Size(86, 20)
        Me.DtpFechaA.TabIndex = 16
        '
        'DtpFechaDe
        '
        Me.DtpFechaDe.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaDe.Location = New System.Drawing.Point(115, 115)
        Me.DtpFechaDe.Name = "DtpFechaDe"
        Me.DtpFechaDe.Size = New System.Drawing.Size(88, 20)
        Me.DtpFechaDe.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Vigencia:"
        '
        'CmbPlaza
        '
        Me.CmbPlaza.DataSource = Me.PlazaC
        Me.CmbPlaza.DisplayMember = "Descripcion"
        Me.CmbPlaza.FormattingEnabled = True
        Me.CmbPlaza.Location = New System.Drawing.Point(180, 36)
        Me.CmbPlaza.Name = "CmbPlaza"
        Me.CmbPlaza.Size = New System.Drawing.Size(366, 21)
        Me.CmbPlaza.TabIndex = 7
        Me.CmbPlaza.ValueMember = "Codigo"
        '
        'PlazaC
        '
        Me.PlazaC.AllowEdit = True
        Me.PlazaC.AllowNew = True
        Me.PlazaC.AllowRemove = True
        Me.PlazaC.MaximoElementosSeleccionados = 1
        Me.PlazaC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.PlazaC.MostrarAlertas = False
        Me.PlazaC.Name = ""
        Me.PlazaC.RaiseListChangedEvents = True
        Me.PlazaC.Transaction = Nothing
        '
        'TxtPlaza
        '
        Me.TxtPlaza.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPlaza.Enabled = False
        Me.TxtPlaza.Location = New System.Drawing.Point(115, 36)
        Me.TxtPlaza.MaximumSize = New System.Drawing.Size(100, 20)
        Me.TxtPlaza.MaxLength = 4
        Me.TxtPlaza.MinimumSize = New System.Drawing.Size(35, 20)
        Me.TxtPlaza.Name = "TxtPlaza"
        Me.TxtPlaza.Size = New System.Drawing.Size(59, 20)
        Me.TxtPlaza.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Plaza:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código:"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCodigo.Enabled = False
        Me.TxtCodigo.Location = New System.Drawing.Point(115, 9)
        Me.TxtCodigo.MaximumSize = New System.Drawing.Size(100, 20)
        Me.TxtCodigo.MaxLength = 4
        Me.TxtCodigo.MinimumSize = New System.Drawing.Size(35, 20)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.ReadOnly = True
        Me.TxtCodigo.Size = New System.Drawing.Size(92, 20)
        Me.TxtCodigo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(50, 0)
        Me.Label1.MaximumSize = New System.Drawing.Size(1800, 1800)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(927, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LISTAS DE PRECIOS"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAgregar.Enabled = False
        Me.BtnAgregar.Location = New System.Drawing.Point(818, 621)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 3
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        Me.BtnAgregar.Visible = False
        '
        'BtnQuitar
        '
        Me.BtnQuitar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnQuitar.Enabled = False
        Me.BtnQuitar.Location = New System.Drawing.Point(899, 621)
        Me.BtnQuitar.Name = "BtnQuitar"
        Me.BtnQuitar.Size = New System.Drawing.Size(75, 23)
        Me.BtnQuitar.TabIndex = 4
        Me.BtnQuitar.Text = "Quitar"
        Me.BtnQuitar.UseVisualStyleBackColor = True
        Me.BtnQuitar.Visible = False
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
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 652)
        Me.MEAToolBar1.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(65, 608)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(181, 17)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "F3    = Filtrar Productos"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(65, 630)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(274, 17)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "ESC  = Muestra Todos los Productos"
        '
        'FrmListaPrecio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 652)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnQuitar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(993, 690)
        Me.MinimumSize = New System.Drawing.Size(993, 688)
        Me.Name = "FrmListaPrecio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listas de Precios"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents TxtDescCorta As System.Windows.Forms.TextBox
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DGDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DtpFechaDe As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CmbPlaza As System.Windows.Forms.ComboBox
    Friend WithEvents TxtPlaza As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DtpFechaA As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ChkBase As System.Windows.Forms.CheckBox
    Friend WithEvents TxtComVta2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtComVta1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtPreVta2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtPreVta1 As System.Windows.Forms.TextBox
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents BtnQuitar As System.Windows.Forms.Button
    Friend WithEvents PlazaC As ClasesNegocio.PlazaCollectionClass
    Friend WithEvents ListaPrecioDetalleCollectionClass1 As ClasesNegocio.ListaPrecioDetalleCollectionClass
    Friend WithEvents TxtUtilidad As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ComisionPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CmbTipoVenta As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TipoVentaC As ClasesNegocio.TipoVentaCollectionClass
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents SubLineaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UtilidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioVentaCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioVentaPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComicionCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LineaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LPDEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LPdIdProducto As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
