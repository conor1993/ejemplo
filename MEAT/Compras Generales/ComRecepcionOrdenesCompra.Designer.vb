<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComRecepcionOrdenesCompra
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtFolioRecepcion = New System.Windows.Forms.TextBox
        Me.txtFolioOrden = New System.Windows.Forms.TextBox
        Me.txtTipoCambio = New System.Windows.Forms.TextBox
        Me.txtNoFactura = New System.Windows.Forms.TextBox
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker
        Me.Mtb = New MEAToolBar.MEAToolBar
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtSumaRecibidas = New System.Windows.Forms.TextBox
        Me.txtSumaOrdenada = New System.Windows.Forms.TextBox
        Me.txtSumaRecibir = New System.Windows.Forms.TextBox
        Me.dgvDetalleOrdenCompra = New System.Windows.Forms.DataGridView
        Me.AlmacenC = New ClasesNegocio.AlmacenCollectionClass
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtObservaciones = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.txtIVA = New System.Windows.Forms.TextBox
        Me.txtSubTotal = New System.Windows.Forms.TextBox
        Me.txtDescuento = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtImporteTotal = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.cmbAlmacen = New System.Windows.Forms.ComboBox
        Me.cmbProveedor = New System.Windows.Forms.ComboBox
        Me.ProveedorC = New ClasesNegocio.ProveedorCollectionClass
        Me.cmbMoneda = New System.Windows.Forms.ComboBox
        Me.MonedaTC = New ClasesNegocio.TipoMonedaCollectionClass
        Me.cmbSucursal = New System.Windows.Forms.ComboBox
        Me.SucursalC = New ClasesNegocio.SucursalCollectionClass
        Me.cmbPlaza = New System.Windows.Forms.ComboBox
        Me.PlazaC = New ClasesNegocio.PlazaCollectionClass
        Me.RecepcionOrdenCompraDetC = New ClasesNegocio.RecepcionOrdenCompraDetCollectionClass
        Me.RecepcionOrdenCompraC = New ClasesNegocio.RecepcionOrdenCompraCollectionClass
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.Tmplaza = New System.Windows.Forms.Timer(Me.components)
        Me.TmSucursal = New System.Windows.Forms.Timer(Me.components)
        Me.TmProveedor = New System.Windows.Forms.Timer(Me.components)
        Me.GrpImportesPesos = New System.Windows.Forms.GroupBox
        Me.txtTotalPesos = New System.Windows.Forms.TextBox
        Me.txtIvaPesos = New System.Windows.Forms.TextBox
        Me.txtSubTotalPesos = New System.Windows.Forms.TextBox
        Me.txtDescuentoPesos = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtImportePesos = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dgvOrdenCompra = New System.Windows.Forms.DataGridView
        Me.clmFecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFolioOrdenCompra = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmSubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmDescuentoOrden = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIVAOrden = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmMoneda = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIdOrdenCompra = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIVAPor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmSucursal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvFamilias = New System.Windows.Forms.DataGridView
        Me.clmIdAlmacen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIdFamilia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.clmIdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmProducto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmUM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmAlmacen = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.clmRecibir = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCantOrdenada = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCantRecibida = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmDescuento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIva = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmImporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIdDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEstatusRecepcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDetalleOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GrpImportesPesos.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFamilias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(908, 29)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "RECEPCIÓN DE ORDENES DE COMPRAS"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Plaza:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Sucursal:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(516, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Folio Recepción:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(539, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Folio Orden:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Proveedor:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(729, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Fecha Alta:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(724, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "No. Factura:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(441, 169)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Moneda:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(918, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Tipo Cambio:"
        Me.Label9.Visible = False
        '
        'txtFolioRecepcion
        '
        Me.txtFolioRecepcion.Location = New System.Drawing.Point(604, 37)
        Me.txtFolioRecepcion.Name = "txtFolioRecepcion"
        Me.txtFolioRecepcion.ReadOnly = True
        Me.txtFolioRecepcion.Size = New System.Drawing.Size(100, 20)
        Me.txtFolioRecepcion.TabIndex = 17
        '
        'txtFolioOrden
        '
        Me.txtFolioOrden.Location = New System.Drawing.Point(604, 63)
        Me.txtFolioOrden.Name = "txtFolioOrden"
        Me.txtFolioOrden.ReadOnly = True
        Me.txtFolioOrden.Size = New System.Drawing.Size(100, 20)
        Me.txtFolioOrden.TabIndex = 18
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.Location = New System.Drawing.Point(919, 139)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.ReadOnly = True
        Me.txtTipoCambio.Size = New System.Drawing.Size(66, 20)
        Me.txtTipoCambio.TabIndex = 20
        Me.txtTipoCambio.Visible = False
        '
        'txtNoFactura
        '
        Me.txtNoFactura.Enabled = False
        Me.txtNoFactura.Location = New System.Drawing.Point(796, 63)
        Me.txtNoFactura.Name = "txtNoFactura"
        Me.txtNoFactura.Size = New System.Drawing.Size(100, 20)
        Me.txtNoFactura.TabIndex = 21
        '
        'DtpFecha
        '
        Me.DtpFecha.Enabled = False
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(796, 35)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(100, 20)
        Me.DtpFecha.TabIndex = 22
        '
        'Mtb
        '
        Me.Mtb.ButtonSize = New System.Drawing.Size(50, 50)
        Me.Mtb.Dock = System.Windows.Forms.DockStyle.Left
        Me.Mtb.DropDownArrows = True
        Me.Mtb.HabilitarBorrar = True
        Me.Mtb.HabilitarBuscar = True
        Me.Mtb.HabilitarCancelar = True
        Me.Mtb.HabilitarEditar = True
        Me.Mtb.HabilitarGuardar = True
        Me.Mtb.HabilitarImprimir = True
        Me.Mtb.HabilitarLimpiar = True
        Me.Mtb.HabilitarNuevo = True
        Me.Mtb.HabilitarSalir = True
        Me.Mtb.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32
        Me.Mtb.Location = New System.Drawing.Point(0, 0)
        Me.Mtb.MostrarBorrar = True
        Me.Mtb.MostrarBuscar = True
        Me.Mtb.MostrarCancelar = True
        Me.Mtb.MostrarEditar = False
        Me.Mtb.MostrarGuardar = True
        Me.Mtb.MostrarImprimir = True
        Me.Mtb.MostrarLimpiar = True
        Me.Mtb.MostrarNuevo = True
        Me.Mtb.MostrarSalir = True
        Me.Mtb.Name = "Mtb"
        Me.Mtb.ShowToolTips = True
        Me.Mtb.Size = New System.Drawing.Size(50, 620)
        Me.Mtb.TabIndex = 23
        '
        'GroupBox1
        '
        Me.GroupBox1.CausesValidation = False
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.txtSumaRecibidas)
        Me.GroupBox1.Controls.Add(Me.txtSumaOrdenada)
        Me.GroupBox1.Controls.Add(Me.txtSumaRecibir)
        Me.GroupBox1.Controls.Add(Me.dgvDetalleOrdenCompra)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(62, 420)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(890, 190)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de Orden"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Bisque
        Me.Label23.Location = New System.Drawing.Point(6, 163)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(273, 17)
        Me.Label23.TabIndex = 28
        Me.Label23.Text = "Productos que no se pueden recibir "
        '
        'txtSumaRecibidas
        '
        Me.txtSumaRecibidas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSumaRecibidas.Location = New System.Drawing.Point(749, 160)
        Me.txtSumaRecibidas.Name = "txtSumaRecibidas"
        Me.txtSumaRecibidas.ReadOnly = True
        Me.txtSumaRecibidas.Size = New System.Drawing.Size(135, 23)
        Me.txtSumaRecibidas.TabIndex = 27
        Me.txtSumaRecibidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSumaOrdenada
        '
        Me.txtSumaOrdenada.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSumaOrdenada.Location = New System.Drawing.Point(593, 160)
        Me.txtSumaOrdenada.Name = "txtSumaOrdenada"
        Me.txtSumaOrdenada.ReadOnly = True
        Me.txtSumaOrdenada.Size = New System.Drawing.Size(135, 23)
        Me.txtSumaOrdenada.TabIndex = 26
        Me.txtSumaOrdenada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSumaRecibir
        '
        Me.txtSumaRecibir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSumaRecibir.Location = New System.Drawing.Point(439, 160)
        Me.txtSumaRecibir.Name = "txtSumaRecibir"
        Me.txtSumaRecibir.ReadOnly = True
        Me.txtSumaRecibir.Size = New System.Drawing.Size(135, 23)
        Me.txtSumaRecibir.TabIndex = 25
        Me.txtSumaRecibir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvDetalleOrdenCompra
        '
        Me.dgvDetalleOrdenCompra.AllowUserToAddRows = False
        Me.dgvDetalleOrdenCompra.AllowUserToDeleteRows = False
        Me.dgvDetalleOrdenCompra.AllowUserToResizeRows = False
        Me.dgvDetalleOrdenCompra.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalleOrdenCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleOrdenCompra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmIdProducto, Me.clmProducto, Me.ClmUM, Me.clmAlmacen, Me.clmRecibir, Me.clmCantOrdenada, Me.clmCantRecibida, Me.clmPrecio, Me.clmDescuento, Me.clmIva, Me.clmImporte, Me.clmIdDetalle, Me.clmEstatusRecepcion})
        Me.dgvDetalleOrdenCompra.Enabled = False
        Me.dgvDetalleOrdenCompra.Location = New System.Drawing.Point(6, 22)
        Me.dgvDetalleOrdenCompra.Name = "dgvDetalleOrdenCompra"
        Me.dgvDetalleOrdenCompra.RowHeadersVisible = False
        Me.dgvDetalleOrdenCompra.Size = New System.Drawing.Size(878, 132)
        Me.dgvDetalleOrdenCompra.TabIndex = 0
        '
        'AlmacenC
        '
        Me.AlmacenC.AllowEdit = True
        Me.AlmacenC.AllowNew = True
        Me.AlmacenC.AllowRemove = True
        Me.AlmacenC.Name = ""
        Me.AlmacenC.RaiseListChangedEvents = True
        Me.AlmacenC.Tipo = ClasesNegocio.AlmacenEnum.ALMACEN
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Observaciones:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Enabled = False
        Me.txtObservaciones.Location = New System.Drawing.Point(95, 127)
        Me.txtObservaciones.MaxLength = 250
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(338, 73)
        Me.txtObservaciones.TabIndex = 28
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTotal)
        Me.GroupBox2.Controls.Add(Me.txtIVA)
        Me.GroupBox2.Controls.Add(Me.txtSubTotal)
        Me.GroupBox2.Controls.Add(Me.txtDescuento)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtImporteTotal)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Location = New System.Drawing.Point(519, 93)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(185, 155)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Importes"
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.Location = New System.Drawing.Point(87, 123)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(92, 20)
        Me.txtTotal.TabIndex = 44
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIVA
        '
        Me.txtIVA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIVA.Location = New System.Drawing.Point(87, 97)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.ReadOnly = True
        Me.txtIVA.Size = New System.Drawing.Size(92, 20)
        Me.txtIVA.TabIndex = 43
        Me.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSubTotal.Location = New System.Drawing.Point(87, 71)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(92, 20)
        Me.txtSubTotal.TabIndex = 42
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDescuento
        '
        Me.txtDescuento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescuento.Location = New System.Drawing.Point(87, 45)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.ReadOnly = True
        Me.txtDescuento.Size = New System.Drawing.Size(92, 20)
        Me.txtDescuento.TabIndex = 41
        Me.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(47, 126)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(34, 13)
        Me.Label18.TabIndex = 40
        Me.Label18.Text = "Total:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(54, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 13)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "IVA:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(25, 74)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 13)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "Sub-Total:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(19, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 13)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Descuento:"
        '
        'txtImporteTotal
        '
        Me.txtImporteTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImporteTotal.Location = New System.Drawing.Point(87, 19)
        Me.txtImporteTotal.Name = "txtImporteTotal"
        Me.txtImporteTotal.ReadOnly = True
        Me.txtImporteTotal.Size = New System.Drawing.Size(92, 20)
        Me.txtImporteTotal.TabIndex = 36
        Me.txtImporteTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 13)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Importe Total:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 105)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 13)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Almacen:"
        '
        'cmbAlmacen
        '
        Me.cmbAlmacen.DataSource = Me.AlmacenC
        Me.cmbAlmacen.DisplayMember = "Descripcion"
        Me.cmbAlmacen.Enabled = False
        Me.cmbAlmacen.FormattingEnabled = True
        Me.cmbAlmacen.Location = New System.Drawing.Point(95, 100)
        Me.cmbAlmacen.Name = "cmbAlmacen"
        Me.cmbAlmacen.Size = New System.Drawing.Size(338, 21)
        Me.cmbAlmacen.TabIndex = 37
        Me.cmbAlmacen.ValueMember = "Codigo"
        '
        'cmbProveedor
        '
        Me.cmbProveedor.DataSource = Me.ProveedorC
        Me.cmbProveedor.DisplayMember = "RazonSocial"
        Me.cmbProveedor.Enabled = False
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(95, 73)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(338, 21)
        Me.cmbProveedor.TabIndex = 40
        Me.cmbProveedor.ValueMember = "Codigo"
        '
        'ProveedorC
        '
        Me.ProveedorC.AllowEdit = True
        Me.ProveedorC.AllowNew = True
        Me.ProveedorC.AllowRemove = True
        Me.ProveedorC.MaximoElementosSeleccionados = 1
        Me.ProveedorC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.ProveedorC.Mostrar = ClasesNegocio.MostrarEnum.CLIENTES
        Me.ProveedorC.MostrarAlertas = False
        Me.ProveedorC.Name = ""
        Me.ProveedorC.RaiseListChangedEvents = True
        Me.ProveedorC.Transaction = Nothing
        '
        'cmbMoneda
        '
        Me.cmbMoneda.DataSource = Me.MonedaTC
        Me.cmbMoneda.DisplayMember = "Descripcion"
        Me.cmbMoneda.Enabled = False
        Me.cmbMoneda.FormattingEnabled = True
        Me.cmbMoneda.Location = New System.Drawing.Point(918, 114)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.Size = New System.Drawing.Size(69, 21)
        Me.cmbMoneda.TabIndex = 16
        Me.cmbMoneda.ValueMember = "Codigo"
        Me.cmbMoneda.Visible = False
        '
        'MonedaTC
        '
        Me.MonedaTC.AllowEdit = True
        Me.MonedaTC.AllowNew = True
        Me.MonedaTC.AllowRemove = True
        Me.MonedaTC.MaximoElementosSeleccionados = 1
        Me.MonedaTC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.MonedaTC.MostrarAlertas = False
        Me.MonedaTC.Name = ""
        Me.MonedaTC.RaiseListChangedEvents = True
        Me.MonedaTC.Transaction = Nothing
        '
        'cmbSucursal
        '
        Me.cmbSucursal.DataSource = Me.SucursalC
        Me.cmbSucursal.DisplayMember = "Descripcion"
        Me.cmbSucursal.Enabled = False
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(95, 46)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(338, 21)
        Me.cmbSucursal.TabIndex = 15
        Me.cmbSucursal.ValueMember = "Codigo"
        '
        'SucursalC
        '
        Me.SucursalC.AllowEdit = True
        Me.SucursalC.AllowNew = True
        Me.SucursalC.AllowRemove = True
        Me.SucursalC.MaximoElementosSeleccionados = 1
        Me.SucursalC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.SucursalC.MostrarAlertas = False
        Me.SucursalC.Name = ""
        Me.SucursalC.RaiseListChangedEvents = True
        Me.SucursalC.Transaction = Nothing
        '
        'cmbPlaza
        '
        Me.cmbPlaza.DataSource = Me.PlazaC
        Me.cmbPlaza.DisplayMember = "Descripcion"
        Me.cmbPlaza.Enabled = False
        Me.cmbPlaza.FormattingEnabled = True
        Me.cmbPlaza.Location = New System.Drawing.Point(95, 19)
        Me.cmbPlaza.Name = "cmbPlaza"
        Me.cmbPlaza.Size = New System.Drawing.Size(338, 21)
        Me.cmbPlaza.TabIndex = 14
        Me.cmbPlaza.ValueMember = "Codigo"
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
        'RecepcionOrdenCompraDetC
        '
        Me.RecepcionOrdenCompraDetC.AllowEdit = True
        Me.RecepcionOrdenCompraDetC.AllowNew = True
        Me.RecepcionOrdenCompraDetC.AllowRemove = True
        Me.RecepcionOrdenCompraDetC.MaximoElementosSeleccionados = 1
        Me.RecepcionOrdenCompraDetC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.RecepcionOrdenCompraDetC.MostrarAlertas = False
        Me.RecepcionOrdenCompraDetC.Name = ""
        Me.RecepcionOrdenCompraDetC.RaiseListChangedEvents = True
        Me.RecepcionOrdenCompraDetC.Transaction = Nothing
        '
        'RecepcionOrdenCompraC
        '
        Me.RecepcionOrdenCompraC.AllowEdit = True
        Me.RecepcionOrdenCompraC.AllowNew = True
        Me.RecepcionOrdenCompraC.AllowRemove = True
        Me.RecepcionOrdenCompraC.MaximoElementosSeleccionados = 1
        Me.RecepcionOrdenCompraC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.RecepcionOrdenCompraC.MostrarAlertas = False
        Me.RecepcionOrdenCompraC.Name = ""
        Me.RecepcionOrdenCompraC.RaiseListChangedEvents = True
        Me.RecepcionOrdenCompraC.Transaction = Nothing
        '
        'lblEstatus
        '
        Me.lblEstatus.AutoSize = True
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblEstatus.Location = New System.Drawing.Point(848, 2)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(104, 24)
        Me.lblEstatus.TabIndex = 66
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.Visible = False
        '
        'Tmplaza
        '
        Me.Tmplaza.Interval = 1000
        '
        'TmSucursal
        '
        Me.TmSucursal.Interval = 1000
        '
        'TmProveedor
        '
        Me.TmProveedor.Interval = 1000
        '
        'GrpImportesPesos
        '
        Me.GrpImportesPesos.Controls.Add(Me.txtTotalPesos)
        Me.GrpImportesPesos.Controls.Add(Me.txtIvaPesos)
        Me.GrpImportesPesos.Controls.Add(Me.txtSubTotalPesos)
        Me.GrpImportesPesos.Controls.Add(Me.txtDescuentoPesos)
        Me.GrpImportesPesos.Controls.Add(Me.Label13)
        Me.GrpImportesPesos.Controls.Add(Me.Label19)
        Me.GrpImportesPesos.Controls.Add(Me.Label20)
        Me.GrpImportesPesos.Controls.Add(Me.Label21)
        Me.GrpImportesPesos.Controls.Add(Me.txtImportePesos)
        Me.GrpImportesPesos.Controls.Add(Me.Label22)
        Me.GrpImportesPesos.Location = New System.Drawing.Point(727, 93)
        Me.GrpImportesPesos.Name = "GrpImportesPesos"
        Me.GrpImportesPesos.Size = New System.Drawing.Size(185, 155)
        Me.GrpImportesPesos.TabIndex = 67
        Me.GrpImportesPesos.TabStop = False
        Me.GrpImportesPesos.Text = "Importes en Pesos"
        '
        'txtTotalPesos
        '
        Me.txtTotalPesos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalPesos.Location = New System.Drawing.Point(87, 123)
        Me.txtTotalPesos.Name = "txtTotalPesos"
        Me.txtTotalPesos.ReadOnly = True
        Me.txtTotalPesos.Size = New System.Drawing.Size(92, 20)
        Me.txtTotalPesos.TabIndex = 44
        Me.txtTotalPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIvaPesos
        '
        Me.txtIvaPesos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIvaPesos.Location = New System.Drawing.Point(87, 97)
        Me.txtIvaPesos.Name = "txtIvaPesos"
        Me.txtIvaPesos.ReadOnly = True
        Me.txtIvaPesos.Size = New System.Drawing.Size(92, 20)
        Me.txtIvaPesos.TabIndex = 43
        Me.txtIvaPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubTotalPesos
        '
        Me.txtSubTotalPesos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSubTotalPesos.Location = New System.Drawing.Point(87, 71)
        Me.txtSubTotalPesos.Name = "txtSubTotalPesos"
        Me.txtSubTotalPesos.ReadOnly = True
        Me.txtSubTotalPesos.Size = New System.Drawing.Size(92, 20)
        Me.txtSubTotalPesos.TabIndex = 42
        Me.txtSubTotalPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDescuentoPesos
        '
        Me.txtDescuentoPesos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescuentoPesos.Location = New System.Drawing.Point(87, 45)
        Me.txtDescuentoPesos.Name = "txtDescuentoPesos"
        Me.txtDescuentoPesos.ReadOnly = True
        Me.txtDescuentoPesos.Size = New System.Drawing.Size(92, 20)
        Me.txtDescuentoPesos.TabIndex = 41
        Me.txtDescuentoPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(47, 126)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 13)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Total:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(54, 100)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(27, 13)
        Me.Label19.TabIndex = 39
        Me.Label19.Text = "IVA:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(25, 74)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 13)
        Me.Label20.TabIndex = 38
        Me.Label20.Text = "Sub-Total:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(19, 48)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(62, 13)
        Me.Label21.TabIndex = 37
        Me.Label21.Text = "Descuento:"
        '
        'txtImportePesos
        '
        Me.txtImportePesos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImportePesos.Location = New System.Drawing.Point(87, 19)
        Me.txtImportePesos.Name = "txtImportePesos"
        Me.txtImportePesos.ReadOnly = True
        Me.txtImportePesos.Size = New System.Drawing.Size(92, 20)
        Me.txtImportePesos.TabIndex = 36
        Me.txtImportePesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(9, 22)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 13)
        Me.Label22.TabIndex = 35
        Me.Label22.Text = "Importe Total:"
        '
        'GroupBox3
        '
        Me.GroupBox3.CausesValidation = False
        Me.GroupBox3.Controls.Add(Me.dgvOrdenCompra)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(62, 254)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(890, 160)
        Me.GroupBox3.TabIndex = 68
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Orden de Compra"
        '
        'dgvOrdenCompra
        '
        Me.dgvOrdenCompra.AllowUserToAddRows = False
        Me.dgvOrdenCompra.AllowUserToDeleteRows = False
        Me.dgvOrdenCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrdenCompra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmFecha, Me.clmProveedor, Me.clmFolioOrdenCompra, Me.clmSubTotal, Me.clmDescuentoOrden, Me.clmIVAOrden, Me.clmTotal, Me.clmMoneda, Me.clmIdOrdenCompra, Me.clmIVAPor, Me.clmSucursal})
        Me.dgvOrdenCompra.Enabled = False
        Me.dgvOrdenCompra.Location = New System.Drawing.Point(6, 22)
        Me.dgvOrdenCompra.Name = "dgvOrdenCompra"
        Me.dgvOrdenCompra.ReadOnly = True
        Me.dgvOrdenCompra.RowHeadersVisible = False
        Me.dgvOrdenCompra.Size = New System.Drawing.Size(878, 132)
        Me.dgvOrdenCompra.TabIndex = 0
        '
        'clmFecha
        '
        Me.clmFecha.DataPropertyName = "FechaOrdenCompra"
        Me.clmFecha.HeaderText = "Fecha"
        Me.clmFecha.Name = "clmFecha"
        Me.clmFecha.ReadOnly = True
        '
        'clmProveedor
        '
        Me.clmProveedor.DataPropertyName = "Proveedor"
        Me.clmProveedor.HeaderText = "Proveedor"
        Me.clmProveedor.Name = "clmProveedor"
        Me.clmProveedor.ReadOnly = True
        Me.clmProveedor.Width = 200
        '
        'clmFolioOrdenCompra
        '
        Me.clmFolioOrdenCompra.DataPropertyName = "FolioOrdenCompra"
        Me.clmFolioOrdenCompra.HeaderText = "Folio"
        Me.clmFolioOrdenCompra.Name = "clmFolioOrdenCompra"
        Me.clmFolioOrdenCompra.ReadOnly = True
        Me.clmFolioOrdenCompra.Width = 130
        '
        'clmSubTotal
        '
        Me.clmSubTotal.DataPropertyName = "SubTotal"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "C2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.clmSubTotal.DefaultCellStyle = DataGridViewCellStyle9
        Me.clmSubTotal.HeaderText = "SubTotal"
        Me.clmSubTotal.Name = "clmSubTotal"
        Me.clmSubTotal.ReadOnly = True
        '
        'clmDescuentoOrden
        '
        Me.clmDescuentoOrden.DataPropertyName = "Descuento"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "C2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.clmDescuentoOrden.DefaultCellStyle = DataGridViewCellStyle10
        Me.clmDescuentoOrden.HeaderText = "Descuento"
        Me.clmDescuentoOrden.Name = "clmDescuentoOrden"
        Me.clmDescuentoOrden.ReadOnly = True
        '
        'clmIVAOrden
        '
        Me.clmIVAOrden.DataPropertyName = "IVATotal"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "C2"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.clmIVAOrden.DefaultCellStyle = DataGridViewCellStyle11
        Me.clmIVAOrden.HeaderText = "IVA"
        Me.clmIVAOrden.Name = "clmIVAOrden"
        Me.clmIVAOrden.ReadOnly = True
        '
        'clmTotal
        '
        Me.clmTotal.DataPropertyName = "Total"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "C2"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.clmTotal.DefaultCellStyle = DataGridViewCellStyle12
        Me.clmTotal.HeaderText = "Total"
        Me.clmTotal.Name = "clmTotal"
        Me.clmTotal.ReadOnly = True
        '
        'clmMoneda
        '
        Me.clmMoneda.HeaderText = "Moneda"
        Me.clmMoneda.Name = "clmMoneda"
        Me.clmMoneda.ReadOnly = True
        Me.clmMoneda.Visible = False
        '
        'clmIdOrdenCompra
        '
        Me.clmIdOrdenCompra.DataPropertyName = "IdORdenCompra"
        Me.clmIdOrdenCompra.HeaderText = "IdOrdenCompra"
        Me.clmIdOrdenCompra.Name = "clmIdOrdenCompra"
        Me.clmIdOrdenCompra.ReadOnly = True
        Me.clmIdOrdenCompra.Visible = False
        '
        'clmIVAPor
        '
        Me.clmIVAPor.DataPropertyName = "IVAPor"
        Me.clmIVAPor.HeaderText = "Porcentaje"
        Me.clmIVAPor.Name = "clmIVAPor"
        Me.clmIVAPor.ReadOnly = True
        Me.clmIVAPor.Visible = False
        '
        'clmSucursal
        '
        Me.clmSucursal.DataPropertyName = "Sucural"
        Me.clmSucursal.HeaderText = "Sucursal"
        Me.clmSucursal.Name = "clmSucursal"
        Me.clmSucursal.ReadOnly = True
        Me.clmSucursal.Visible = False
        '
        'dgvFamilias
        '
        Me.dgvFamilias.AllowUserToAddRows = False
        Me.dgvFamilias.AllowUserToDeleteRows = False
        Me.dgvFamilias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFamilias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmIdAlmacen, Me.clmIdFamilia})
        Me.dgvFamilias.Location = New System.Drawing.Point(919, 35)
        Me.dgvFamilias.Name = "dgvFamilias"
        Me.dgvFamilias.ReadOnly = True
        Me.dgvFamilias.RowHeadersVisible = False
        Me.dgvFamilias.Size = New System.Drawing.Size(206, 51)
        Me.dgvFamilias.TabIndex = 69
        Me.dgvFamilias.Visible = False
        '
        'clmIdAlmacen
        '
        Me.clmIdAlmacen.DataPropertyName = "CodigoAlmacen"
        Me.clmIdAlmacen.HeaderText = "Almacen"
        Me.clmIdAlmacen.Name = "clmIdAlmacen"
        Me.clmIdAlmacen.ReadOnly = True
        '
        'clmIdFamilia
        '
        Me.clmIdFamilia.DataPropertyName = "CodigoLinea"
        Me.clmIdFamilia.HeaderText = "Familia"
        Me.clmIdFamilia.Name = "clmIdFamilia"
        Me.clmIdFamilia.ReadOnly = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmbPlaza)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.txtObservaciones)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.cmbSucursal)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.cmbProveedor)
        Me.GroupBox4.Controls.Add(Me.cmbAlmacen)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Location = New System.Drawing.Point(62, 37)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(439, 211)
        Me.GroupBox4.TabIndex = 70
        Me.GroupBox4.TabStop = False
        '
        'clmIdProducto
        '
        Me.clmIdProducto.DataPropertyName = "codigoProducto"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.clmIdProducto.DefaultCellStyle = DataGridViewCellStyle13
        Me.clmIdProducto.HeaderText = "Código Producto"
        Me.clmIdProducto.Name = "clmIdProducto"
        Me.clmIdProducto.ReadOnly = True
        Me.clmIdProducto.Visible = False
        '
        'clmProducto
        '
        Me.clmProducto.DataPropertyName = "Producto"
        Me.clmProducto.HeaderText = "Producto"
        Me.clmProducto.Name = "clmProducto"
        Me.clmProducto.ReadOnly = True
        Me.clmProducto.Width = 320
        '
        'ClmUM
        '
        Me.ClmUM.DataPropertyName = "UnidadMedida"
        Me.ClmUM.HeaderText = "Medida"
        Me.ClmUM.Name = "ClmUM"
        '
        'clmAlmacen
        '
        Me.clmAlmacen.DataSource = Me.AlmacenC
        Me.clmAlmacen.DisplayMember = "Descripcion"
        Me.clmAlmacen.HeaderText = "Almacen"
        Me.clmAlmacen.Name = "clmAlmacen"
        Me.clmAlmacen.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmAlmacen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clmAlmacen.ValueMember = "Codigo"
        Me.clmAlmacen.Visible = False
        '
        'clmRecibir
        '
        Me.clmRecibir.DataPropertyName = "CantPendiente"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "N3"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.clmRecibir.DefaultCellStyle = DataGridViewCellStyle14
        Me.clmRecibir.HeaderText = "Cant a Recibir"
        Me.clmRecibir.Name = "clmRecibir"
        Me.clmRecibir.Width = 150
        '
        'clmCantOrdenada
        '
        Me.clmCantOrdenada.DataPropertyName = "CantidadOrdenada"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Format = "N3"
        DataGridViewCellStyle15.NullValue = Nothing
        Me.clmCantOrdenada.DefaultCellStyle = DataGridViewCellStyle15
        Me.clmCantOrdenada.HeaderText = "Cant Ordenada"
        Me.clmCantOrdenada.Name = "clmCantOrdenada"
        Me.clmCantOrdenada.ReadOnly = True
        Me.clmCantOrdenada.Width = 150
        '
        'clmCantRecibida
        '
        Me.clmCantRecibida.DataPropertyName = "CantRecibida"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.Format = "N3"
        DataGridViewCellStyle16.NullValue = "0"
        Me.clmCantRecibida.DefaultCellStyle = DataGridViewCellStyle16
        Me.clmCantRecibida.HeaderText = "Cant Recibida"
        Me.clmCantRecibida.Name = "clmCantRecibida"
        Me.clmCantRecibida.ReadOnly = True
        Me.clmCantRecibida.Width = 150
        '
        'clmPrecio
        '
        Me.clmPrecio.DataPropertyName = "Precio"
        Me.clmPrecio.HeaderText = "Precio"
        Me.clmPrecio.Name = "clmPrecio"
        Me.clmPrecio.Visible = False
        '
        'clmDescuento
        '
        Me.clmDescuento.DataPropertyName = "Descuento"
        Me.clmDescuento.HeaderText = "Descuento"
        Me.clmDescuento.Name = "clmDescuento"
        Me.clmDescuento.Visible = False
        '
        'clmIva
        '
        Me.clmIva.HeaderText = "Iva"
        Me.clmIva.Name = "clmIva"
        Me.clmIva.Visible = False
        '
        'clmImporte
        '
        Me.clmImporte.HeaderText = "Importe"
        Me.clmImporte.Name = "clmImporte"
        Me.clmImporte.Visible = False
        '
        'clmIdDetalle
        '
        Me.clmIdDetalle.DataPropertyName = "Renglon"
        Me.clmIdDetalle.HeaderText = "Detalle"
        Me.clmIdDetalle.Name = "clmIdDetalle"
        Me.clmIdDetalle.Visible = False
        '
        'clmEstatusRecepcion
        '
        Me.clmEstatusRecepcion.HeaderText = "Estatus"
        Me.clmEstatusRecepcion.Name = "clmEstatusRecepcion"
        Me.clmEstatusRecepcion.Visible = False
        '
        'ComRecepcionOrdenesCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 620)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.dgvFamilias)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GrpImportesPesos)
        Me.Controls.Add(Me.lblEstatus)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DtpFecha)
        Me.Controls.Add(Me.txtTipoCambio)
        Me.Controls.Add(Me.cmbMoneda)
        Me.Controls.Add(Me.txtNoFactura)
        Me.Controls.Add(Me.txtFolioOrden)
        Me.Controls.Add(Me.txtFolioRecepcion)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Mtb)
        Me.MaximizeBox = False
        Me.Name = "ComRecepcionOrdenesCompra"
        Me.Text = "Recepción de Ordenes de Compras"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvDetalleOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GrpImportesPesos.ResumeLayout(False)
        Me.GrpImportesPesos.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFamilias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbPlaza As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents txtFolioRecepcion As System.Windows.Forms.TextBox
    Friend WithEvents txtFolioOrden As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoCambio As System.Windows.Forms.TextBox
    Friend WithEvents txtNoFactura As System.Windows.Forms.TextBox
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Mtb As MEAToolBar.MEAToolBar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSumaRecibidas As System.Windows.Forms.TextBox
    Friend WithEvents txtSumaOrdenada As System.Windows.Forms.TextBox
    Friend WithEvents txtSumaRecibir As System.Windows.Forms.TextBox
    Friend WithEvents dgvDetalleOrdenCompra As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtIVA As System.Windows.Forms.TextBox
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtImporteTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents ProveedorC As ClasesNegocio.ProveedorCollectionClass
    Friend WithEvents SucursalC As ClasesNegocio.SucursalCollectionClass
    Friend WithEvents PlazaC As ClasesNegocio.PlazaCollectionClass
    Friend WithEvents cmbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents MonedaTC As ClasesNegocio.TipoMonedaCollectionClass
    Friend WithEvents AlamacenCatalagoC As ClasesNegocio.AlamacenCatalagoColletionClass
    Friend WithEvents RecepcionOrdenCompraDetC As ClasesNegocio.RecepcionOrdenCompraDetCollectionClass
    Friend WithEvents AlmacenC As ClasesNegocio.AlmacenCollectionClass
    Friend WithEvents RecepcionOrdenCompraC As ClasesNegocio.RecepcionOrdenCompraCollectionClass
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents Tmplaza As System.Windows.Forms.Timer
    Friend WithEvents TmSucursal As System.Windows.Forms.Timer
    Friend WithEvents TmProveedor As System.Windows.Forms.Timer
    Friend WithEvents GrpImportesPesos As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotalPesos As System.Windows.Forms.TextBox
    Friend WithEvents txtIvaPesos As System.Windows.Forms.TextBox
    Friend WithEvents txtSubTotalPesos As System.Windows.Forms.TextBox
    Friend WithEvents txtDescuentoPesos As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtImportePesos As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvOrdenCompra As System.Windows.Forms.DataGridView
    Friend WithEvents dgvFamilias As System.Windows.Forms.DataGridView
    Friend WithEvents clmIdAlmacen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdFamilia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents clmFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFolioOrdenCompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSubTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDescuentoOrden As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIVAOrden As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmMoneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdOrdenCompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIVAPor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSucursal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents clmIdProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmUM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmAlmacen As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents clmRecibir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCantOrdenada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCantRecibida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPrecio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDescuento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdDetalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEstatusRecepcion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
