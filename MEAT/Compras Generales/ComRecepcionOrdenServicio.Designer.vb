<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComRecepcionOrdenServicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
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
        Me.ToolBar = New MEAToolBar.MEAToolBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbSucursal = New System.Windows.Forms.ComboBox
        Me.SucursalC = New ClasesNegocio.SucursalCollectionClass
        Me.cmbPlaza = New System.Windows.Forms.ComboBox
        Me.PlazaC = New ClasesNegocio.PlazaCollectionClass
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtMoneda = New System.Windows.Forms.TextBox
        Me.txtProveedor = New System.Windows.Forms.TextBox
        Me.btBuscarOrdenes = New System.Windows.Forms.Button
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker
        Me.txtNoFactura = New System.Windows.Forms.TextBox
        Me.txtTipoCambio = New System.Windows.Forms.TextBox
        Me.txtFolioOrden = New System.Windows.Forms.TextBox
        Me.txtFolioRecepcion = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dgvDetalle = New System.Windows.Forms.DataGridView
        Me.clmFolioCotiz = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ServicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadSolicDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadOrdenarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescuentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IVADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ServicioDetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FolioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FolioDetSolicDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IndiceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OrdenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OrdenServicioDetC = New ClasesNegocio.OrdenServicioDetCollectionClass
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.txtIVA = New System.Windows.Forms.TextBox
        Me.txtSubTotal = New System.Windows.Forms.TextBox
        Me.txtDescuento = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtObservaciones = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Tmplaza = New System.Windows.Forms.Timer(Me.components)
        Me.TmSucursal = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolBar
        '
        Me.ToolBar.ButtonSize = New System.Drawing.Size(50, 50)
        Me.ToolBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolBar.DropDownArrows = True
        Me.ToolBar.HabilitarBorrar = True
        Me.ToolBar.HabilitarBuscar = True
        Me.ToolBar.HabilitarCancelar = True
        Me.ToolBar.HabilitarEditar = True
        Me.ToolBar.HabilitarGuardar = True
        Me.ToolBar.HabilitarImprimir = True
        Me.ToolBar.HabilitarLimpiar = True
        Me.ToolBar.HabilitarNuevo = True
        Me.ToolBar.HabilitarSalir = True
        Me.ToolBar.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32
        Me.ToolBar.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar.MostrarBorrar = True
        Me.ToolBar.MostrarBuscar = True
        Me.ToolBar.MostrarCancelar = True
        Me.ToolBar.MostrarEditar = False
        Me.ToolBar.MostrarGuardar = True
        Me.ToolBar.MostrarImprimir = False
        Me.ToolBar.MostrarLimpiar = True
        Me.ToolBar.MostrarNuevo = True
        Me.ToolBar.MostrarSalir = True
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.ShowToolTips = True
        Me.ToolBar.Size = New System.Drawing.Size(50, 574)
        Me.ToolBar.TabIndex = 0
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
        Me.Label1.Size = New System.Drawing.Size(808, 29)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "RECEPCIÓN ÓRDENES DE SERVICIOS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbSucursal
        '
        Me.cmbSucursal.Enabled = False
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(92, 47)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(278, 21)
        Me.cmbSucursal.TabIndex = 35
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
        Me.cmbPlaza.Enabled = False
        Me.cmbPlaza.FormattingEnabled = True
        Me.cmbPlaza.Location = New System.Drawing.Point(92, 20)
        Me.cmbPlaza.Name = "cmbPlaza"
        Me.cmbPlaza.Size = New System.Drawing.Size(278, 21)
        Me.cmbPlaza.TabIndex = 34
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Sucursal:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Plaza:"
        '
        'lblEstatus
        '
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(631, 23)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(99, 21)
        Me.lblEstatus.TabIndex = 60
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEstatus.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtMoneda)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtProveedor)
        Me.GroupBox2.Controls.Add(Me.btBuscarOrdenes)
        Me.GroupBox2.Controls.Add(Me.lblEstatus)
        Me.GroupBox2.Controls.Add(Me.cmbSucursal)
        Me.GroupBox2.Controls.Add(Me.DtpFecha)
        Me.GroupBox2.Controls.Add(Me.txtNoFactura)
        Me.GroupBox2.Controls.Add(Me.cmbPlaza)
        Me.GroupBox2.Controls.Add(Me.txtTipoCambio)
        Me.GroupBox2.Controls.Add(Me.txtFolioOrden)
        Me.GroupBox2.Controls.Add(Me.txtFolioRecepcion)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(56, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(792, 134)
        Me.GroupBox2.TabIndex = 62
        Me.GroupBox2.TabStop = False
        '
        'txtMoneda
        '
        Me.txtMoneda.Location = New System.Drawing.Point(473, 47)
        Me.txtMoneda.Name = "txtMoneda"
        Me.txtMoneda.ReadOnly = True
        Me.txtMoneda.Size = New System.Drawing.Size(100, 20)
        Me.txtMoneda.TabIndex = 57
        '
        'txtProveedor
        '
        Me.txtProveedor.Location = New System.Drawing.Point(92, 102)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.ReadOnly = True
        Me.txtProveedor.Size = New System.Drawing.Size(278, 20)
        Me.txtProveedor.TabIndex = 56
        '
        'btBuscarOrdenes
        '
        Me.btBuscarOrdenes.Enabled = False
        Me.btBuscarOrdenes.Location = New System.Drawing.Point(590, 90)
        Me.btBuscarOrdenes.Name = "btBuscarOrdenes"
        Me.btBuscarOrdenes.Size = New System.Drawing.Size(189, 29)
        Me.btBuscarOrdenes.TabIndex = 55
        Me.btBuscarOrdenes.Text = "Obtener Orden de Serivicio..."
        Me.btBuscarOrdenes.UseVisualStyleBackColor = True
        '
        'DtpFecha
        '
        Me.DtpFecha.Enabled = False
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(92, 74)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(100, 20)
        Me.DtpFecha.TabIndex = 53
        '
        'txtNoFactura
        '
        Me.txtNoFactura.Location = New System.Drawing.Point(270, 74)
        Me.txtNoFactura.Name = "txtNoFactura"
        Me.txtNoFactura.Size = New System.Drawing.Size(100, 20)
        Me.txtNoFactura.TabIndex = 52
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.Location = New System.Drawing.Point(473, 75)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.ReadOnly = True
        Me.txtTipoCambio.Size = New System.Drawing.Size(100, 20)
        Me.txtTipoCambio.TabIndex = 51
        '
        'txtFolioOrden
        '
        Me.txtFolioOrden.Location = New System.Drawing.Point(473, 20)
        Me.txtFolioOrden.Name = "txtFolioOrden"
        Me.txtFolioOrden.ReadOnly = True
        Me.txtFolioOrden.Size = New System.Drawing.Size(100, 20)
        Me.txtFolioOrden.TabIndex = 50
        '
        'txtFolioRecepcion
        '
        Me.txtFolioRecepcion.Location = New System.Drawing.Point(473, 102)
        Me.txtFolioRecepcion.Name = "txtFolioRecepcion"
        Me.txtFolioRecepcion.ReadOnly = True
        Me.txtFolioRecepcion.Size = New System.Drawing.Size(100, 20)
        Me.txtFolioRecepcion.TabIndex = 49
        Me.txtFolioRecepcion.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(380, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Tipo Cambio:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(380, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Moneda:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(198, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "No. Factura:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Fecha Alta:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Proveedor:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(380, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Folio Orden:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(380, 105)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 13)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Folio Recepción:"
        Me.Label10.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.CausesValidation = False
        Me.GroupBox3.Controls.Add(Me.dgvDetalle)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(56, 172)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(792, 252)
        Me.GroupBox3.TabIndex = 63
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalle de Orden"
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToDeleteRows = False
        Me.dgvDetalle.AllowUserToResizeRows = False
        Me.dgvDetalle.AutoGenerateColumns = False
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmFolioCotiz, Me.ServicioDataGridViewTextBoxColumn, Me.CantidadSolicDataGridViewTextBoxColumn, Me.CantidadOrdenarDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.DescuentoDataGridViewTextBoxColumn, Me.IVADataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn, Me.EstatusDataGridViewTextBoxColumn, Me.ServicioDetDataGridViewTextBoxColumn, Me.FolioDataGridViewTextBoxColumn, Me.FolioDetSolicDataGridViewTextBoxColumn, Me.IndiceDataGridViewTextBoxColumn, Me.OrdenDataGridViewTextBoxColumn})
        Me.dgvDetalle.DataSource = Me.OrdenServicioDetC
        Me.dgvDetalle.Location = New System.Drawing.Point(6, 22)
        Me.dgvDetalle.MultiSelect = False
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.ReadOnly = True
        Me.dgvDetalle.RowHeadersVisible = False
        Me.dgvDetalle.Size = New System.Drawing.Size(775, 218)
        Me.dgvDetalle.TabIndex = 1
        '
        'clmFolioCotiz
        '
        Me.clmFolioCotiz.HeaderText = "Cotización"
        Me.clmFolioCotiz.Name = "clmFolioCotiz"
        Me.clmFolioCotiz.ReadOnly = True
        Me.clmFolioCotiz.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clmFolioCotiz.Visible = False
        '
        'ServicioDataGridViewTextBoxColumn
        '
        Me.ServicioDataGridViewTextBoxColumn.DataPropertyName = "Servicio"
        Me.ServicioDataGridViewTextBoxColumn.HeaderText = "Servicio"
        Me.ServicioDataGridViewTextBoxColumn.Name = "ServicioDataGridViewTextBoxColumn"
        Me.ServicioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadSolicDataGridViewTextBoxColumn
        '
        Me.CantidadSolicDataGridViewTextBoxColumn.DataPropertyName = "CantidadSolic"
        Me.CantidadSolicDataGridViewTextBoxColumn.HeaderText = "Cant. Solic"
        Me.CantidadSolicDataGridViewTextBoxColumn.Name = "CantidadSolicDataGridViewTextBoxColumn"
        Me.CantidadSolicDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadOrdenarDataGridViewTextBoxColumn
        '
        Me.CantidadOrdenarDataGridViewTextBoxColumn.DataPropertyName = "CantidadOrdenar"
        Me.CantidadOrdenarDataGridViewTextBoxColumn.HeaderText = "Cant. Ord"
        Me.CantidadOrdenarDataGridViewTextBoxColumn.Name = "CantidadOrdenarDataGridViewTextBoxColumn"
        Me.CantidadOrdenarDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "Precio"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.PrecioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescuentoDataGridViewTextBoxColumn
        '
        Me.DescuentoDataGridViewTextBoxColumn.DataPropertyName = "Descuento"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DescuentoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.DescuentoDataGridViewTextBoxColumn.HeaderText = "Descuento"
        Me.DescuentoDataGridViewTextBoxColumn.Name = "DescuentoDataGridViewTextBoxColumn"
        Me.DescuentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IVADataGridViewTextBoxColumn
        '
        Me.IVADataGridViewTextBoxColumn.DataPropertyName = "IVA"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.IVADataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.IVADataGridViewTextBoxColumn.HeaderText = "IVA(%)"
        Me.IVADataGridViewTextBoxColumn.Name = "IVADataGridViewTextBoxColumn"
        Me.IVADataGridViewTextBoxColumn.ReadOnly = True
        '
        'ImporteDataGridViewTextBoxColumn
        '
        Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "Importe"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.ImporteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
        Me.ImporteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstatusDataGridViewTextBoxColumn
        '
        Me.EstatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.HeaderText = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.Name = "EstatusDataGridViewTextBoxColumn"
        Me.EstatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstatusDataGridViewTextBoxColumn.Visible = False
        '
        'ServicioDetDataGridViewTextBoxColumn
        '
        Me.ServicioDetDataGridViewTextBoxColumn.DataPropertyName = "ServicioDet"
        Me.ServicioDetDataGridViewTextBoxColumn.HeaderText = "ServicioDet"
        Me.ServicioDetDataGridViewTextBoxColumn.Name = "ServicioDetDataGridViewTextBoxColumn"
        Me.ServicioDetDataGridViewTextBoxColumn.ReadOnly = True
        Me.ServicioDetDataGridViewTextBoxColumn.Visible = False
        '
        'FolioDataGridViewTextBoxColumn
        '
        Me.FolioDataGridViewTextBoxColumn.DataPropertyName = "Folio"
        Me.FolioDataGridViewTextBoxColumn.HeaderText = "Folio"
        Me.FolioDataGridViewTextBoxColumn.Name = "FolioDataGridViewTextBoxColumn"
        Me.FolioDataGridViewTextBoxColumn.ReadOnly = True
        Me.FolioDataGridViewTextBoxColumn.Visible = False
        '
        'FolioDetSolicDataGridViewTextBoxColumn
        '
        Me.FolioDetSolicDataGridViewTextBoxColumn.DataPropertyName = "FolioDetSolic"
        Me.FolioDetSolicDataGridViewTextBoxColumn.HeaderText = "FolioDetSolic"
        Me.FolioDetSolicDataGridViewTextBoxColumn.Name = "FolioDetSolicDataGridViewTextBoxColumn"
        Me.FolioDetSolicDataGridViewTextBoxColumn.ReadOnly = True
        Me.FolioDetSolicDataGridViewTextBoxColumn.Visible = False
        '
        'IndiceDataGridViewTextBoxColumn
        '
        Me.IndiceDataGridViewTextBoxColumn.DataPropertyName = "Indice"
        Me.IndiceDataGridViewTextBoxColumn.HeaderText = "Indice"
        Me.IndiceDataGridViewTextBoxColumn.Name = "IndiceDataGridViewTextBoxColumn"
        Me.IndiceDataGridViewTextBoxColumn.ReadOnly = True
        Me.IndiceDataGridViewTextBoxColumn.Visible = False
        '
        'OrdenDataGridViewTextBoxColumn
        '
        Me.OrdenDataGridViewTextBoxColumn.DataPropertyName = "Orden"
        Me.OrdenDataGridViewTextBoxColumn.HeaderText = "Orden"
        Me.OrdenDataGridViewTextBoxColumn.Name = "OrdenDataGridViewTextBoxColumn"
        Me.OrdenDataGridViewTextBoxColumn.ReadOnly = True
        Me.OrdenDataGridViewTextBoxColumn.Visible = False
        '
        'OrdenServicioDetC
        '
        Me.OrdenServicioDetC.AllowEdit = True
        Me.OrdenServicioDetC.AllowNew = True
        Me.OrdenServicioDetC.AllowRemove = True
        Me.OrdenServicioDetC.Name = ""
        Me.OrdenServicioDetC.RaiseListChangedEvents = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtTotal)
        Me.GroupBox4.Controls.Add(Me.txtIVA)
        Me.GroupBox4.Controls.Add(Me.txtSubTotal)
        Me.GroupBox4.Controls.Add(Me.txtDescuento)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Location = New System.Drawing.Point(663, 430)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(185, 137)
        Me.GroupBox4.TabIndex = 64
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Importes"
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.Location = New System.Drawing.Point(82, 97)
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
        Me.txtIVA.Location = New System.Drawing.Point(82, 71)
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
        Me.txtSubTotal.Location = New System.Drawing.Point(82, 19)
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
        Me.txtDescuento.Location = New System.Drawing.Point(82, 45)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.ReadOnly = True
        Me.txtDescuento.Size = New System.Drawing.Size(92, 20)
        Me.txtDescuento.TabIndex = 41
        Me.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(34, 100)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(34, 13)
        Me.Label18.TabIndex = 40
        Me.Label18.Text = "Total:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(41, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 13)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "IVA:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 13)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "Sub-Total:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 13)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Descuento:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(161, 437)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ReadOnly = True
        Me.txtObservaciones.Size = New System.Drawing.Size(468, 84)
        Me.txtObservaciones.TabIndex = 30
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(74, 439)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Observaciones:"
        '
        'Tmplaza
        '
        Me.Tmplaza.Interval = 1000
        '
        'TmSucursal
        '
        Me.TmSucursal.Interval = 1000
        '
        'ComRecepcionOrdenServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 574)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolBar)
        Me.Name = "ComRecepcionOrdenServicio"
        Me.Text = "Recepción de Ordenes de Servicios"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolBar As MEAToolBar.MEAToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPlaza As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btBuscarOrdenes As System.Windows.Forms.Button
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNoFactura As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoCambio As System.Windows.Forms.TextBox
    Friend WithEvents txtFolioOrden As System.Windows.Forms.TextBox
    Friend WithEvents txtFolioRecepcion As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtIVA As System.Windows.Forms.TextBox
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PlazaC As ClasesNegocio.PlazaCollectionClass
    Friend WithEvents SucursalC As ClasesNegocio.SucursalCollectionClass
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents OrdenServicioDetC As ClasesNegocio.OrdenServicioDetCollectionClass
    Friend WithEvents txtMoneda As System.Windows.Forms.TextBox
    Friend WithEvents txtProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Tmplaza As System.Windows.Forms.Timer
    Friend WithEvents TmSucursal As System.Windows.Forms.Timer
    Friend WithEvents clmFolioCotiz As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadSolicDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadOrdenarDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescuentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IVADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServicioDetDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FolioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FolioDetSolicDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IndiceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrdenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
