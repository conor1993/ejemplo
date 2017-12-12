<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComEmisionOrdenCompra
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CtmDataGrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CotizacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtFolioOrden = New System.Windows.Forms.TextBox()
        Me.txtTipoCambio = New System.Windows.Forms.TextBox()
        Me.txtDiasCredito = New System.Windows.Forms.TextBox()
        Me.txtSolicito = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.dtFechaAlta = New System.Windows.Forms.DateTimePicker()
        Me.dgvDetalleOrdenCompra = New System.Windows.Forms.DataGridView()
        Me.OrdenCompraDetalleC = New ClasesNegocio.OrdenCompraDetalleCollectionClass()
        Me.grpImportesOtraMoneda = New System.Windows.Forms.GroupBox()
        Me.txtIVAFletesOtraMoneda = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtTotalOtraMoneda = New System.Windows.Forms.TextBox()
        Me.txtIVAOtraMoneda = New System.Windows.Forms.TextBox()
        Me.txtFletesOtraMonedas = New System.Windows.Forms.TextBox()
        Me.txtDescuentoOtraMoneda = New System.Windows.Forms.TextBox()
        Me.txtSubTotalOtraMoneda = New System.Windows.Forms.TextBox()
        Me.lblEstatus = New System.Windows.Forms.Label()
        Me.cmbMoneda = New System.Windows.Forms.ComboBox()
        Me.MonedaTC = New ClasesNegocio.TipoMonedaCollectionClass()
        Me.cmbProveedor = New System.Windows.Forms.ComboBox()
        Me.ProveedorC = New ClasesNegocio.ProveedorCollectionClass()
        Me.cmbSucursal = New System.Windows.Forms.ComboBox()
        Me.SucursalC = New ClasesNegocio.SucursalCollectionClass()
        Me.cmbPlaza = New System.Windows.Forms.ComboBox()
        Me.PlazaC = New ClasesNegocio.PlazaCollectionClass()
        Me.TmSucursal = New System.Windows.Forms.Timer(Me.components)
        Me.Tmplaza = New System.Windows.Forms.Timer(Me.components)
        Me.TmProveedor = New System.Windows.Forms.Timer(Me.components)
        Me.grpImportesPeso = New System.Windows.Forms.GroupBox()
        Me.txtIVAFletes = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtIVAPesos = New System.Windows.Forms.TextBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtFletes = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.sstab = New System.Windows.Forms.TabControl()
        Me.tpSolicitudes = New System.Windows.Forms.TabPage()
        Me.dgvSolicitudes = New System.Windows.Forms.DataGridView()
        Me.clmSelSolicitud = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.clmSolicitud = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFechaSolicitud = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmUnidadMedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFechaSurtir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPrioridad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmIdSolicitud = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmEntregar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tpDetalle = New System.Windows.Forms.TabPage()
        Me.dgvEspejoOrden = New System.Windows.Forms.DataGridView()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtEntregarA = New System.Windows.Forms.TextBox()
        Me.clmProductoEspejo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmUnidadEspejo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCantSolEspejo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCantOrdEspejo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCostoUnitarioEspejo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDescuentoEspejo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmIVAEspejo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPorcentajeIVAEspejo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmImporteEspejo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFolioSolicitudEspejo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmIdSolicitudEspejo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmProductoOrdenCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmUnidadMedidaOrdenCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCantidadSolicitada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCantidadOrdenada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCostoUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDescuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmsubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmIVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPorcentajeIVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmImporteDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrdenCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CtmDataGrid.SuspendLayout()
        CType(Me.dgvDetalleOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpImportesOtraMoneda.SuspendLayout()
        Me.grpImportesPeso.SuspendLayout()
        Me.sstab.SuspendLayout()
        Me.tpSolicitudes.SuspendLayout()
        CType(Me.dgvSolicitudes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpDetalle.SuspendLayout()
        CType(Me.dgvEspejoOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(50, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(832, 29)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "EMISIÓN DE ORDEN DE COMPRA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.MEAToolBar1.MostrarEditar = False
        Me.MEAToolBar1.MostrarGuardar = True
        Me.MEAToolBar1.MostrarImprimir = True
        Me.MEAToolBar1.MostrarLimpiar = True
        Me.MEAToolBar1.MostrarNuevo = True
        Me.MEAToolBar1.MostrarSalir = True
        Me.MEAToolBar1.Name = "MEAToolBar1"
        Me.MEAToolBar1.ShowToolTips = True
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 634)
        Me.MEAToolBar1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Plaza:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Sucursal:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(485, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Folio Orden:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(62, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Fecha :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(283, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Moneda:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(485, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Tipo Cambio:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(693, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Dias Crédito:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(62, 102)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Proveedor:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(485, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Solicito:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(485, 131)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Observaciones:"
        '
        'CtmDataGrid
        '
        Me.CtmDataGrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CotizacionesToolStripMenuItem})
        Me.CtmDataGrid.Name = "CtmDataGrid"
        Me.CtmDataGrid.Size = New System.Drawing.Size(142, 26)
        '
        'CotizacionesToolStripMenuItem
        '
        Me.CotizacionesToolStripMenuItem.Name = "CotizacionesToolStripMenuItem"
        Me.CotizacionesToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.CotizacionesToolStripMenuItem.Text = "Cotizaciones"
        '
        'txtFolioOrden
        '
        Me.txtFolioOrden.Location = New System.Drawing.Point(575, 40)
        Me.txtFolioOrden.Name = "txtFolioOrden"
        Me.txtFolioOrden.ReadOnly = True
        Me.txtFolioOrden.Size = New System.Drawing.Size(100, 20)
        Me.txtFolioOrden.TabIndex = 25
        Me.txtFolioOrden.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.Location = New System.Drawing.Point(575, 66)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.ReadOnly = True
        Me.txtTipoCambio.Size = New System.Drawing.Size(100, 20)
        Me.txtTipoCambio.TabIndex = 26
        Me.txtTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiasCredito
        '
        Me.txtDiasCredito.Location = New System.Drawing.Point(766, 66)
        Me.txtDiasCredito.Name = "txtDiasCredito"
        Me.txtDiasCredito.ReadOnly = True
        Me.txtDiasCredito.Size = New System.Drawing.Size(100, 20)
        Me.txtDiasCredito.TabIndex = 27
        Me.txtDiasCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSolicito
        '
        Me.txtSolicito.Location = New System.Drawing.Point(575, 94)
        Me.txtSolicito.Name = "txtSolicito"
        Me.txtSolicito.ReadOnly = True
        Me.txtSolicito.Size = New System.Drawing.Size(295, 20)
        Me.txtSolicito.TabIndex = 28
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(575, 120)
        Me.txtObservaciones.MaxLength = 250
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(295, 68)
        Me.txtObservaciones.TabIndex = 29
        '
        'dtFechaAlta
        '
        Me.dtFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaAlta.Location = New System.Drawing.Point(162, 154)
        Me.dtFechaAlta.Name = "dtFechaAlta"
        Me.dtFechaAlta.Size = New System.Drawing.Size(95, 20)
        Me.dtFechaAlta.TabIndex = 30
        '
        'dgvDetalleOrdenCompra
        '
        Me.dgvDetalleOrdenCompra.AllowUserToDeleteRows = False
        Me.dgvDetalleOrdenCompra.AllowUserToResizeRows = False
        Me.dgvDetalleOrdenCompra.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalleOrdenCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleOrdenCompra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmProductoOrdenCompra, Me.clmUnidadMedidaOrdenCompra, Me.clmCantidadSolicitada, Me.clmCantidadOrdenada, Me.clmCostoUnitario, Me.clmDescuento, Me.clmsubtotal, Me.clmIVA, Me.clmPorcentajeIVA, Me.clmImporteDetalle, Me.OrdenCompraDataGridViewTextBoxColumn})
        Me.dgvDetalleOrdenCompra.Location = New System.Drawing.Point(6, 6)
        Me.dgvDetalleOrdenCompra.MultiSelect = False
        Me.dgvDetalleOrdenCompra.Name = "dgvDetalleOrdenCompra"
        Me.dgvDetalleOrdenCompra.RowHeadersVisible = False
        Me.dgvDetalleOrdenCompra.Size = New System.Drawing.Size(800, 196)
        Me.dgvDetalleOrdenCompra.TabIndex = 0
        '
        'OrdenCompraDetalleC
        '
        Me.OrdenCompraDetalleC.AllowEdit = True
        Me.OrdenCompraDetalleC.AllowNew = True
        Me.OrdenCompraDetalleC.AllowRemove = True
        Me.OrdenCompraDetalleC.MaximoElementosSeleccionados = 1
        Me.OrdenCompraDetalleC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.OrdenCompraDetalleC.MostrarAlertas = False
        Me.OrdenCompraDetalleC.Name = ""
        Me.OrdenCompraDetalleC.RaiseListChangedEvents = True
        Me.OrdenCompraDetalleC.Transaction = Nothing
        '
        'grpImportesOtraMoneda
        '
        Me.grpImportesOtraMoneda.Controls.Add(Me.txtIVAFletesOtraMoneda)
        Me.grpImportesOtraMoneda.Controls.Add(Me.Label14)
        Me.grpImportesOtraMoneda.Controls.Add(Me.Label15)
        Me.grpImportesOtraMoneda.Controls.Add(Me.Label16)
        Me.grpImportesOtraMoneda.Controls.Add(Me.Label17)
        Me.grpImportesOtraMoneda.Controls.Add(Me.Label18)
        Me.grpImportesOtraMoneda.Controls.Add(Me.Label25)
        Me.grpImportesOtraMoneda.Controls.Add(Me.txtTotalOtraMoneda)
        Me.grpImportesOtraMoneda.Controls.Add(Me.txtIVAOtraMoneda)
        Me.grpImportesOtraMoneda.Controls.Add(Me.txtFletesOtraMonedas)
        Me.grpImportesOtraMoneda.Controls.Add(Me.txtDescuentoOtraMoneda)
        Me.grpImportesOtraMoneda.Controls.Add(Me.txtSubTotalOtraMoneda)
        Me.grpImportesOtraMoneda.Location = New System.Drawing.Point(528, 444)
        Me.grpImportesOtraMoneda.Name = "grpImportesOtraMoneda"
        Me.grpImportesOtraMoneda.Size = New System.Drawing.Size(168, 183)
        Me.grpImportesOtraMoneda.TabIndex = 34
        Me.grpImportesOtraMoneda.TabStop = False
        Me.grpImportesOtraMoneda.Text = "Importes en Otra Moneda"
        Me.grpImportesOtraMoneda.Visible = False
        '
        'txtIVAFletesOtraMoneda
        '
        Me.txtIVAFletesOtraMoneda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIVAFletesOtraMoneda.Location = New System.Drawing.Point(71, 101)
        Me.txtIVAFletesOtraMoneda.Name = "txtIVAFletesOtraMoneda"
        Me.txtIVAFletesOtraMoneda.ReadOnly = True
        Me.txtIVAFletesOtraMoneda.Size = New System.Drawing.Size(88, 20)
        Me.txtIVAFletesOtraMoneda.TabIndex = 64
        Me.txtIVAFletesOtraMoneda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 105)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 13)
        Me.Label14.TabIndex = 63
        Me.Label14.Text = "IVA Fletes :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 157)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(34, 13)
        Me.Label15.TabIndex = 62
        Me.Label15.Text = "Total:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(8, 130)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(27, 13)
        Me.Label16.TabIndex = 61
        Me.Label16.Text = "IVA:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 27)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 13)
        Me.Label17.TabIndex = 60
        Me.Label17.Text = "Sub-Total:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(8, 53)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(62, 13)
        Me.Label18.TabIndex = 59
        Me.Label18.Text = "Descuento:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(8, 79)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(35, 13)
        Me.Label25.TabIndex = 58
        Me.Label25.Text = "Fletes"
        '
        'txtTotalOtraMoneda
        '
        Me.txtTotalOtraMoneda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalOtraMoneda.Location = New System.Drawing.Point(71, 153)
        Me.txtTotalOtraMoneda.Name = "txtTotalOtraMoneda"
        Me.txtTotalOtraMoneda.ReadOnly = True
        Me.txtTotalOtraMoneda.Size = New System.Drawing.Size(88, 20)
        Me.txtTotalOtraMoneda.TabIndex = 44
        Me.txtTotalOtraMoneda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIVAOtraMoneda
        '
        Me.txtIVAOtraMoneda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIVAOtraMoneda.Location = New System.Drawing.Point(71, 127)
        Me.txtIVAOtraMoneda.Name = "txtIVAOtraMoneda"
        Me.txtIVAOtraMoneda.ReadOnly = True
        Me.txtIVAOtraMoneda.Size = New System.Drawing.Size(88, 20)
        Me.txtIVAOtraMoneda.TabIndex = 43
        Me.txtIVAOtraMoneda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFletesOtraMonedas
        '
        Me.txtFletesOtraMonedas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFletesOtraMonedas.Location = New System.Drawing.Point(71, 77)
        Me.txtFletesOtraMonedas.Name = "txtFletesOtraMonedas"
        Me.txtFletesOtraMonedas.ReadOnly = True
        Me.txtFletesOtraMonedas.Size = New System.Drawing.Size(88, 20)
        Me.txtFletesOtraMonedas.TabIndex = 42
        Me.txtFletesOtraMonedas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDescuentoOtraMoneda
        '
        Me.txtDescuentoOtraMoneda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescuentoOtraMoneda.Location = New System.Drawing.Point(71, 51)
        Me.txtDescuentoOtraMoneda.Name = "txtDescuentoOtraMoneda"
        Me.txtDescuentoOtraMoneda.ReadOnly = True
        Me.txtDescuentoOtraMoneda.Size = New System.Drawing.Size(88, 20)
        Me.txtDescuentoOtraMoneda.TabIndex = 41
        Me.txtDescuentoOtraMoneda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubTotalOtraMoneda
        '
        Me.txtSubTotalOtraMoneda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSubTotalOtraMoneda.Location = New System.Drawing.Point(71, 25)
        Me.txtSubTotalOtraMoneda.Name = "txtSubTotalOtraMoneda"
        Me.txtSubTotalOtraMoneda.ReadOnly = True
        Me.txtSubTotalOtraMoneda.Size = New System.Drawing.Size(88, 20)
        Me.txtSubTotalOtraMoneda.TabIndex = 36
        Me.txtSubTotalOtraMoneda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblEstatus
        '
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(705, 37)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(161, 21)
        Me.lblEstatus.TabIndex = 59
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEstatus.Visible = False
        '
        'cmbMoneda
        '
        Me.cmbMoneda.DataSource = Me.MonedaTC
        Me.cmbMoneda.DisplayMember = "Descripcion"
        Me.cmbMoneda.FormattingEnabled = True
        Me.cmbMoneda.Location = New System.Drawing.Point(357, 154)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.Size = New System.Drawing.Size(100, 21)
        Me.cmbMoneda.TabIndex = 23
        Me.cmbMoneda.ValueMember = "Codigo"
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
        'cmbProveedor
        '
        Me.cmbProveedor.DataSource = Me.ProveedorC
        Me.cmbProveedor.DisplayMember = "RazonSocial"
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(162, 101)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(295, 21)
        Me.cmbProveedor.TabIndex = 22
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
        'cmbSucursal
        '
        Me.cmbSucursal.DataSource = Me.SucursalC
        Me.cmbSucursal.DisplayMember = "Descripcion"
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(162, 74)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(295, 21)
        Me.cmbSucursal.TabIndex = 21
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
        Me.cmbPlaza.FormattingEnabled = True
        Me.cmbPlaza.Location = New System.Drawing.Point(162, 47)
        Me.cmbPlaza.Name = "cmbPlaza"
        Me.cmbPlaza.Size = New System.Drawing.Size(295, 21)
        Me.cmbPlaza.TabIndex = 20
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
        'TmSucursal
        '
        Me.TmSucursal.Interval = 1000
        '
        'Tmplaza
        '
        Me.Tmplaza.Interval = 1000
        '
        'TmProveedor
        '
        Me.TmProveedor.Interval = 1000
        '
        'grpImportesPeso
        '
        Me.grpImportesPeso.Controls.Add(Me.txtIVAFletes)
        Me.grpImportesPeso.Controls.Add(Me.Label24)
        Me.grpImportesPeso.Controls.Add(Me.txtTotal)
        Me.grpImportesPeso.Controls.Add(Me.txtIVAPesos)
        Me.grpImportesPeso.Controls.Add(Me.txtSubTotal)
        Me.grpImportesPeso.Controls.Add(Me.txtDescuento)
        Me.grpImportesPeso.Controls.Add(Me.Label13)
        Me.grpImportesPeso.Controls.Add(Me.Label19)
        Me.grpImportesPeso.Controls.Add(Me.Label20)
        Me.grpImportesPeso.Controls.Add(Me.Label21)
        Me.grpImportesPeso.Controls.Add(Me.txtFletes)
        Me.grpImportesPeso.Controls.Add(Me.Label22)
        Me.grpImportesPeso.Location = New System.Drawing.Point(704, 444)
        Me.grpImportesPeso.Name = "grpImportesPeso"
        Me.grpImportesPeso.Size = New System.Drawing.Size(168, 183)
        Me.grpImportesPeso.TabIndex = 60
        Me.grpImportesPeso.TabStop = False
        Me.grpImportesPeso.Text = "Importes"
        '
        'txtIVAFletes
        '
        Me.txtIVAFletes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIVAFletes.Location = New System.Drawing.Point(74, 101)
        Me.txtIVAFletes.Name = "txtIVAFletes"
        Me.txtIVAFletes.ReadOnly = True
        Me.txtIVAFletes.Size = New System.Drawing.Size(88, 20)
        Me.txtIVAFletes.TabIndex = 58
        Me.txtIVAFletes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(9, 103)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(61, 13)
        Me.Label24.TabIndex = 57
        Me.Label24.Text = "IVA Fletes :"
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.Location = New System.Drawing.Point(74, 153)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(88, 20)
        Me.txtTotal.TabIndex = 56
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIVAPesos
        '
        Me.txtIVAPesos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIVAPesos.Location = New System.Drawing.Point(74, 127)
        Me.txtIVAPesos.Name = "txtIVAPesos"
        Me.txtIVAPesos.ReadOnly = True
        Me.txtIVAPesos.Size = New System.Drawing.Size(88, 20)
        Me.txtIVAPesos.TabIndex = 55
        Me.txtIVAPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSubTotal.Location = New System.Drawing.Point(74, 24)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(88, 20)
        Me.txtSubTotal.TabIndex = 54
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDescuento
        '
        Me.txtDescuento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescuento.Location = New System.Drawing.Point(74, 50)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.ReadOnly = True
        Me.txtDescuento.Size = New System.Drawing.Size(88, 20)
        Me.txtDescuento.TabIndex = 53
        Me.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 155)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 13)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "Total:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(9, 128)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(27, 13)
        Me.Label19.TabIndex = 51
        Me.Label19.Text = "IVA:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(9, 25)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 13)
        Me.Label20.TabIndex = 50
        Me.Label20.Text = "Sub-Total:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(9, 51)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(62, 13)
        Me.Label21.TabIndex = 49
        Me.Label21.Text = "Descuento:"
        '
        'txtFletes
        '
        Me.txtFletes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFletes.Location = New System.Drawing.Point(74, 76)
        Me.txtFletes.Name = "txtFletes"
        Me.txtFletes.ReadOnly = True
        Me.txtFletes.Size = New System.Drawing.Size(88, 20)
        Me.txtFletes.TabIndex = 48
        Me.txtFletes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(9, 77)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(35, 13)
        Me.Label22.TabIndex = 47
        Me.Label22.Text = "Fletes"
        '
        'sstab
        '
        Me.sstab.Controls.Add(Me.tpSolicitudes)
        Me.sstab.Controls.Add(Me.tpDetalle)
        Me.sstab.Location = New System.Drawing.Point(56, 194)
        Me.sstab.Name = "sstab"
        Me.sstab.SelectedIndex = 0
        Me.sstab.Size = New System.Drawing.Size(820, 244)
        Me.sstab.TabIndex = 61
        '
        'tpSolicitudes
        '
        Me.tpSolicitudes.Controls.Add(Me.dgvSolicitudes)
        Me.tpSolicitudes.Location = New System.Drawing.Point(4, 22)
        Me.tpSolicitudes.Name = "tpSolicitudes"
        Me.tpSolicitudes.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSolicitudes.Size = New System.Drawing.Size(812, 218)
        Me.tpSolicitudes.TabIndex = 0
        Me.tpSolicitudes.Text = "Solicitudes"
        Me.tpSolicitudes.UseVisualStyleBackColor = True
        '
        'dgvSolicitudes
        '
        Me.dgvSolicitudes.AllowUserToAddRows = False
        Me.dgvSolicitudes.AllowUserToDeleteRows = False
        Me.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSolicitudes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmSelSolicitud, Me.clmSolicitud, Me.clmFechaSolicitud, Me.clmProducto, Me.clmCantidad, Me.clmUnidadMedida, Me.clmFechaSurtir, Me.clmPrioridad, Me.clmIdSolicitud, Me.clmEntregar})
        Me.dgvSolicitudes.Location = New System.Drawing.Point(5, 6)
        Me.dgvSolicitudes.Name = "dgvSolicitudes"
        Me.dgvSolicitudes.RowHeadersVisible = False
        Me.dgvSolicitudes.Size = New System.Drawing.Size(801, 204)
        Me.dgvSolicitudes.TabIndex = 0
        '
        'clmSelSolicitud
        '
        Me.clmSelSolicitud.HeaderText = ""
        Me.clmSelSolicitud.Name = "clmSelSolicitud"
        Me.clmSelSolicitud.Width = 40
        '
        'clmSolicitud
        '
        Me.clmSolicitud.DataPropertyName = "FolioSolicitud"
        Me.clmSolicitud.HeaderText = "Solicitud"
        Me.clmSolicitud.Name = "clmSolicitud"
        Me.clmSolicitud.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmSolicitud.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'clmFechaSolicitud
        '
        Me.clmFechaSolicitud.DataPropertyName = "FechaSolicitud"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle8.Format = "d"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.clmFechaSolicitud.DefaultCellStyle = DataGridViewCellStyle8
        Me.clmFechaSolicitud.HeaderText = "Fecha Solicitud"
        Me.clmFechaSolicitud.Name = "clmFechaSolicitud"
        Me.clmFechaSolicitud.Width = 120
        '
        'clmProducto
        '
        Me.clmProducto.DataPropertyName = "Producto"
        Me.clmProducto.HeaderText = "Producto"
        Me.clmProducto.Name = "clmProducto"
        Me.clmProducto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmProducto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clmProducto.Width = 240
        '
        'clmCantidad
        '
        Me.clmCantidad.DataPropertyName = "Cantidad"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = "0"
        Me.clmCantidad.DefaultCellStyle = DataGridViewCellStyle9
        Me.clmCantidad.HeaderText = "Cantidad"
        Me.clmCantidad.Name = "clmCantidad"
        Me.clmCantidad.ReadOnly = True
        Me.clmCantidad.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmCantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'clmUnidadMedida
        '
        Me.clmUnidadMedida.DataPropertyName = "UnidadMedida"
        Me.clmUnidadMedida.HeaderText = "Unidad"
        Me.clmUnidadMedida.Name = "clmUnidadMedida"
        Me.clmUnidadMedida.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmUnidadMedida.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clmUnidadMedida.Width = 70
        '
        'clmFechaSurtir
        '
        Me.clmFechaSurtir.DataPropertyName = "FechaSolicitud"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Format = "d"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.clmFechaSurtir.DefaultCellStyle = DataGridViewCellStyle10
        Me.clmFechaSurtir.HeaderText = "Fecha Surtir"
        Me.clmFechaSurtir.Name = "clmFechaSurtir"
        Me.clmFechaSurtir.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmFechaSurtir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clmFechaSurtir.Width = 120
        '
        'clmPrioridad
        '
        Me.clmPrioridad.DataPropertyName = "DescripcionUrgente"
        Me.clmPrioridad.HeaderText = "Prioridad"
        Me.clmPrioridad.Name = "clmPrioridad"
        Me.clmPrioridad.Width = 80
        '
        'clmIdSolicitud
        '
        Me.clmIdSolicitud.DataPropertyName = "IdSolicitud"
        Me.clmIdSolicitud.HeaderText = "CodigoSolicitud"
        Me.clmIdSolicitud.Name = "clmIdSolicitud"
        Me.clmIdSolicitud.Visible = False
        '
        'clmEntregar
        '
        Me.clmEntregar.DataPropertyName = "EntregarA"
        Me.clmEntregar.HeaderText = "Entregar"
        Me.clmEntregar.Name = "clmEntregar"
        Me.clmEntregar.Visible = False
        '
        'tpDetalle
        '
        Me.tpDetalle.Controls.Add(Me.dgvEspejoOrden)
        Me.tpDetalle.Controls.Add(Me.dgvDetalleOrdenCompra)
        Me.tpDetalle.Location = New System.Drawing.Point(4, 22)
        Me.tpDetalle.Name = "tpDetalle"
        Me.tpDetalle.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDetalle.Size = New System.Drawing.Size(812, 218)
        Me.tpDetalle.TabIndex = 1
        Me.tpDetalle.Text = "Detalle"
        Me.tpDetalle.UseVisualStyleBackColor = True
        '
        'dgvEspejoOrden
        '
        Me.dgvEspejoOrden.AllowUserToDeleteRows = False
        Me.dgvEspejoOrden.AllowUserToResizeRows = False
        Me.dgvEspejoOrden.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvEspejoOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEspejoOrden.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmProductoEspejo, Me.clmUnidadEspejo, Me.clmCantSolEspejo, Me.clmCantOrdEspejo, Me.clmCostoUnitarioEspejo, Me.clmDescuentoEspejo, Me.Subtotal, Me.clmIVAEspejo, Me.clmPorcentajeIVAEspejo, Me.clmImporteEspejo, Me.clmFolioSolicitudEspejo, Me.clmIdSolicitudEspejo})
        Me.dgvEspejoOrden.Location = New System.Drawing.Point(6, 109)
        Me.dgvEspejoOrden.MultiSelect = False
        Me.dgvEspejoOrden.Name = "dgvEspejoOrden"
        Me.dgvEspejoOrden.RowHeadersVisible = False
        Me.dgvEspejoOrden.Size = New System.Drawing.Size(800, 134)
        Me.dgvEspejoOrden.TabIndex = 1
        Me.dgvEspejoOrden.Visible = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(62, 131)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(62, 13)
        Me.Label23.TabIndex = 62
        Me.Label23.Text = "Entregar a :"
        '
        'txtEntregarA
        '
        Me.txtEntregarA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEntregarA.Location = New System.Drawing.Point(162, 128)
        Me.txtEntregarA.Name = "txtEntregarA"
        Me.txtEntregarA.Size = New System.Drawing.Size(295, 20)
        Me.txtEntregarA.TabIndex = 63
        '
        'clmProductoEspejo
        '
        Me.clmProductoEspejo.HeaderText = "Articulo/insumo"
        Me.clmProductoEspejo.Name = "clmProductoEspejo"
        Me.clmProductoEspejo.ReadOnly = True
        Me.clmProductoEspejo.Width = 250
        '
        'clmUnidadEspejo
        '
        Me.clmUnidadEspejo.HeaderText = "Unidad"
        Me.clmUnidadEspejo.Name = "clmUnidadEspejo"
        Me.clmUnidadEspejo.ReadOnly = True
        Me.clmUnidadEspejo.Width = 60
        '
        'clmCantSolEspejo
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N3"
        DataGridViewCellStyle11.NullValue = "0"
        Me.clmCantSolEspejo.DefaultCellStyle = DataGridViewCellStyle11
        Me.clmCantSolEspejo.HeaderText = "Cant Sol"
        Me.clmCantSolEspejo.Name = "clmCantSolEspejo"
        Me.clmCantSolEspejo.Width = 90
        '
        'clmCantOrdEspejo
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N3"
        DataGridViewCellStyle12.NullValue = "0"
        Me.clmCantOrdEspejo.DefaultCellStyle = DataGridViewCellStyle12
        Me.clmCantOrdEspejo.HeaderText = "Cant Ord"
        Me.clmCantOrdEspejo.Name = "clmCantOrdEspejo"
        Me.clmCantOrdEspejo.Width = 90
        '
        'clmCostoUnitarioEspejo
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "N2"
        DataGridViewCellStyle13.NullValue = "0"
        Me.clmCostoUnitarioEspejo.DefaultCellStyle = DataGridViewCellStyle13
        Me.clmCostoUnitarioEspejo.HeaderText = "Costo Unitario"
        Me.clmCostoUnitarioEspejo.Name = "clmCostoUnitarioEspejo"
        '
        'clmDescuentoEspejo
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "N2"
        DataGridViewCellStyle14.NullValue = "0"
        Me.clmDescuentoEspejo.DefaultCellStyle = DataGridViewCellStyle14
        Me.clmDescuentoEspejo.HeaderText = "Descuento"
        Me.clmDescuentoEspejo.Name = "clmDescuentoEspejo"
        Me.clmDescuentoEspejo.Width = 90
        '
        'Subtotal
        '
        Me.Subtotal.HeaderText = "clmsubtotal"
        Me.Subtotal.Name = "Subtotal"
        '
        'clmIVAEspejo
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Format = "N2"
        DataGridViewCellStyle15.NullValue = "0"
        Me.clmIVAEspejo.DefaultCellStyle = DataGridViewCellStyle15
        Me.clmIVAEspejo.HeaderText = "IVA"
        Me.clmIVAEspejo.Name = "clmIVAEspejo"
        Me.clmIVAEspejo.Width = 60
        '
        'clmPorcentajeIVAEspejo
        '
        Me.clmPorcentajeIVAEspejo.HeaderText = "Porcentaje IVA Espejo"
        Me.clmPorcentajeIVAEspejo.Name = "clmPorcentajeIVAEspejo"
        '
        'clmImporteEspejo
        '
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.Format = "N2"
        DataGridViewCellStyle16.NullValue = "0"
        Me.clmImporteEspejo.DefaultCellStyle = DataGridViewCellStyle16
        Me.clmImporteEspejo.HeaderText = "Importe"
        Me.clmImporteEspejo.Name = "clmImporteEspejo"
        '
        'clmFolioSolicitudEspejo
        '
        Me.clmFolioSolicitudEspejo.HeaderText = "Solicitud"
        Me.clmFolioSolicitudEspejo.Name = "clmFolioSolicitudEspejo"
        Me.clmFolioSolicitudEspejo.ReadOnly = True
        '
        'clmIdSolicitudEspejo
        '
        Me.clmIdSolicitudEspejo.HeaderText = "IdSolicitud"
        Me.clmIdSolicitudEspejo.Name = "clmIdSolicitudEspejo"
        '
        'clmProductoOrdenCompra
        '
        Me.clmProductoOrdenCompra.HeaderText = "Articulo/insumo"
        Me.clmProductoOrdenCompra.Name = "clmProductoOrdenCompra"
        Me.clmProductoOrdenCompra.ReadOnly = True
        Me.clmProductoOrdenCompra.Width = 250
        '
        'clmUnidadMedidaOrdenCompra
        '
        Me.clmUnidadMedidaOrdenCompra.HeaderText = "Unidad"
        Me.clmUnidadMedidaOrdenCompra.Name = "clmUnidadMedidaOrdenCompra"
        Me.clmUnidadMedidaOrdenCompra.ReadOnly = True
        Me.clmUnidadMedidaOrdenCompra.Width = 60
        '
        'clmCantidadSolicitada
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N3"
        DataGridViewCellStyle1.NullValue = "0"
        Me.clmCantidadSolicitada.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmCantidadSolicitada.HeaderText = "Cant Sol"
        Me.clmCantidadSolicitada.Name = "clmCantidadSolicitada"
        Me.clmCantidadSolicitada.Width = 90
        '
        'clmCantidadOrdenada
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N3"
        DataGridViewCellStyle2.NullValue = "0"
        Me.clmCantidadOrdenada.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmCantidadOrdenada.HeaderText = "Cant Ord"
        Me.clmCantidadOrdenada.Name = "clmCantidadOrdenada"
        Me.clmCantidadOrdenada.Width = 90
        '
        'clmCostoUnitario
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.clmCostoUnitario.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmCostoUnitario.HeaderText = "Costo Unitario"
        Me.clmCostoUnitario.Name = "clmCostoUnitario"
        '
        'clmDescuento
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.clmDescuento.DefaultCellStyle = DataGridViewCellStyle4
        Me.clmDescuento.HeaderText = "Descuento"
        Me.clmDescuento.Name = "clmDescuento"
        Me.clmDescuento.Width = 85
        '
        'clmsubtotal
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.clmsubtotal.DefaultCellStyle = DataGridViewCellStyle5
        Me.clmsubtotal.HeaderText = "Subtotal"
        Me.clmsubtotal.Name = "clmsubtotal"
        '
        'clmIVA
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = "0"
        Me.clmIVA.DefaultCellStyle = DataGridViewCellStyle6
        Me.clmIVA.HeaderText = "IVA"
        Me.clmIVA.Name = "clmIVA"
        Me.clmIVA.Width = 60
        '
        'clmPorcentajeIVA
        '
        Me.clmPorcentajeIVA.HeaderText = "Porcentaje IVA"
        Me.clmPorcentajeIVA.Name = "clmPorcentajeIVA"
        Me.clmPorcentajeIVA.Visible = False
        '
        'clmImporteDetalle
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = "0"
        Me.clmImporteDetalle.DefaultCellStyle = DataGridViewCellStyle7
        Me.clmImporteDetalle.HeaderText = "Importe"
        Me.clmImporteDetalle.Name = "clmImporteDetalle"
        '
        'OrdenCompraDataGridViewTextBoxColumn
        '
        Me.OrdenCompraDataGridViewTextBoxColumn.HeaderText = "OrdenCompra"
        Me.OrdenCompraDataGridViewTextBoxColumn.Name = "OrdenCompraDataGridViewTextBoxColumn"
        Me.OrdenCompraDataGridViewTextBoxColumn.ReadOnly = True
        Me.OrdenCompraDataGridViewTextBoxColumn.Visible = False
        '
        'ComEmisionOrdenCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 634)
        Me.Controls.Add(Me.cmbPlaza)
        Me.Controls.Add(Me.txtEntregarA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblEstatus)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.sstab)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtFolioOrden)
        Me.Controls.Add(Me.cmbSucursal)
        Me.Controls.Add(Me.dtFechaAlta)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpImportesPeso)
        Me.Controls.Add(Me.cmbProveedor)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.Controls.Add(Me.txtDiasCredito)
        Me.Controls.Add(Me.txtTipoCambio)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.txtSolicito)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbMoneda)
        Me.Controls.Add(Me.grpImportesOtraMoneda)
        Me.Controls.Add(Me.Label9)
        Me.MaximizeBox = False
        Me.Name = "ComEmisionOrdenCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Emisión de Orden de Compra"
        Me.CtmDataGrid.ResumeLayout(False)
        CType(Me.dgvDetalleOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpImportesOtraMoneda.ResumeLayout(False)
        Me.grpImportesOtraMoneda.PerformLayout()
        Me.grpImportesPeso.ResumeLayout(False)
        Me.grpImportesPeso.PerformLayout()
        Me.sstab.ResumeLayout(False)
        Me.tpSolicitudes.ResumeLayout(False)
        CType(Me.dgvSolicitudes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpDetalle.ResumeLayout(False)
        CType(Me.dgvEspejoOrden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbPlaza As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents cmbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents txtFolioOrden As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoCambio As System.Windows.Forms.TextBox
    Friend WithEvents txtDiasCredito As System.Windows.Forms.TextBox
    Friend WithEvents txtSolicito As System.Windows.Forms.TextBox
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents dtFechaAlta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgvDetalleOrdenCompra As System.Windows.Forms.DataGridView
    Friend WithEvents grpImportesOtraMoneda As System.Windows.Forms.GroupBox
    Friend WithEvents txtSubTotalOtraMoneda As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalOtraMoneda As System.Windows.Forms.TextBox
    Friend WithEvents txtIVAOtraMoneda As System.Windows.Forms.TextBox
    Friend WithEvents txtFletesOtraMonedas As System.Windows.Forms.TextBox
    Friend WithEvents txtDescuentoOtraMoneda As System.Windows.Forms.TextBox
    Friend WithEvents PlazaC As ClasesNegocio.PlazaCollectionClass
    Friend WithEvents SucursalC As ClasesNegocio.SucursalCollectionClass
    Friend WithEvents ProveedorC As ClasesNegocio.ProveedorCollectionClass
    Friend WithEvents OrdenCompraDetalleC As ClasesNegocio.OrdenCompraDetalleCollectionClass
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents MonedaTC As ClasesNegocio.TipoMonedaCollectionClass
    'Friend WithEvents crCortes1 As FLEXI.crCortes
    Friend WithEvents CtmDataGrid As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CotizacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TmSucursal As System.Windows.Forms.Timer
    Friend WithEvents Tmplaza As System.Windows.Forms.Timer
    Friend WithEvents TmProveedor As System.Windows.Forms.Timer
    Friend WithEvents CodigoProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grpImportesPeso As System.Windows.Forms.GroupBox
    Friend WithEvents sstab As System.Windows.Forms.TabControl
    Friend WithEvents tpSolicitudes As System.Windows.Forms.TabPage
    Friend WithEvents tpDetalle As System.Windows.Forms.TabPage
    Friend WithEvents dgvSolicitudes As System.Windows.Forms.DataGridView
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtIVAFletes As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtIVAPesos As System.Windows.Forms.TextBox
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtFletes As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtIVAFletesOtraMoneda As System.Windows.Forms.TextBox
    Friend WithEvents txtEntregarA As System.Windows.Forms.TextBox
    Friend WithEvents dgvEspejoOrden As System.Windows.Forms.DataGridView
    Friend WithEvents clmSelSolicitud As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents clmSolicitud As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaSolicitud As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmUnidadMedida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaSurtir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPrioridad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdSolicitud As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEntregar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmProductoEspejo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmUnidadEspejo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCantSolEspejo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCantOrdEspejo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCostoUnitarioEspejo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDescuentoEspejo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIVAEspejo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPorcentajeIVAEspejo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmImporteEspejo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFolioSolicitudEspejo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdSolicitudEspejo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmProductoOrdenCompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmUnidadMedidaOrdenCompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCantidadSolicitada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCantidadOrdenada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCostoUnitario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDescuento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmsubtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPorcentajeIVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmImporteDetalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrdenCompraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
