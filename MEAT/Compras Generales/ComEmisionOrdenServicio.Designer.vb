<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComEmisionOrdenServicio
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbPlaza = New System.Windows.Forms.ComboBox
        Me.PlazaC = New ClasesNegocio.PlazaCollectionClass
        Me.cmbSucursal = New System.Windows.Forms.ComboBox
        Me.SucursalC = New ClasesNegocio.SucursalCollectionClass
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtFolio = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.TbpDetalle = New System.Windows.Forms.TabPage
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.txtIVA = New System.Windows.Forms.TextBox
        Me.txtDescuento = New System.Windows.Forms.TextBox
        Me.txtSubTotal = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.dgvDetalle = New System.Windows.Forms.DataGridView
        Me.OrdenServicioDetC = New ClasesNegocio.OrdenServicioDetCollectionClass
        Me.TbpCotizaciones = New System.Windows.Forms.TabPage
        Me.dgvCotizaciones = New System.Windows.Forms.DataGridView
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.txtProveedor = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtObservaciones = New System.Windows.Forms.TextBox
        Me.CmbMoneda = New System.Windows.Forms.ComboBox
        Me.MonedaTC = New ClasesNegocio.TipoMonedaCollectionClass
        Me.Label12 = New System.Windows.Forms.Label
        Me.OrdenServicioC = New ClasesNegocio.OrdenServicioCollectionClass
        Me.Tmplaza = New System.Windows.Forms.Timer(Me.components)
        Me.TmSucursal = New System.Windows.Forms.Timer(Me.components)
        Me.clmSeleccion = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.clmProveedorId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIva = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmDescuento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIndice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCotizacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmServicio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFolioSolic = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCosto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmImporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFolioCotiz = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmServicios = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCantSol = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCantOrd = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmDescuentos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIVAs = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmImportes = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OrdenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IndiceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FolioDetSolicDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFolios = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TbpDetalle.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbpCotizaciones.SuspendLayout()
        CType(Me.dgvCotizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
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
        Me.mtb.HabilitarEditar = False
        Me.mtb.HabilitarGuardar = True
        Me.mtb.HabilitarImprimir = True
        Me.mtb.HabilitarLimpiar = True
        Me.mtb.HabilitarNuevo = True
        Me.mtb.HabilitarSalir = True
        Me.mtb.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32
        Me.mtb.Location = New System.Drawing.Point(0, 0)
        Me.mtb.MostrarBorrar = True
        Me.mtb.MostrarBuscar = True
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 523)
        Me.mtb.TabIndex = 8
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
        Me.Label1.Size = New System.Drawing.Size(801, 29)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "EMISIÓN DE ORDEN DE SERVICIOS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Plaza:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Sucursal:"
        '
        'cmbPlaza
        '
        Me.cmbPlaza.DataSource = Me.PlazaC
        Me.cmbPlaza.DisplayMember = "Descripcion"
        Me.cmbPlaza.FormattingEnabled = True
        Me.cmbPlaza.Location = New System.Drawing.Point(143, 40)
        Me.cmbPlaza.Name = "cmbPlaza"
        Me.cmbPlaza.Size = New System.Drawing.Size(323, 21)
        Me.cmbPlaza.TabIndex = 12
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
        'cmbSucursal
        '
        Me.cmbSucursal.DataSource = Me.SucursalC
        Me.cmbSucursal.DisplayMember = "Descripcion"
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(143, 67)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(323, 21)
        Me.cmbSucursal.TabIndex = 13
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(485, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Folio:"
        '
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(523, 40)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.ReadOnly = True
        Me.txtFolio.Size = New System.Drawing.Size(100, 20)
        Me.txtFolio.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Fecha de Alta:"
        '
        'DtpFecha
        '
        Me.DtpFecha.Enabled = False
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(143, 94)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(92, 20)
        Me.DtpFecha.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(56, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Proveedor:"
        '
        'lblEstatus
        '
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(730, 38)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(99, 21)
        Me.lblEstatus.TabIndex = 60
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEstatus.Visible = False
        '
        'TbpDetalle
        '
        Me.TbpDetalle.Controls.Add(Me.txtTotal)
        Me.TbpDetalle.Controls.Add(Me.txtIVA)
        Me.TbpDetalle.Controls.Add(Me.txtDescuento)
        Me.TbpDetalle.Controls.Add(Me.txtSubTotal)
        Me.TbpDetalle.Controls.Add(Me.Label10)
        Me.TbpDetalle.Controls.Add(Me.Label9)
        Me.TbpDetalle.Controls.Add(Me.Label8)
        Me.TbpDetalle.Controls.Add(Me.Label7)
        Me.TbpDetalle.Controls.Add(Me.dgvDetalle)
        Me.TbpDetalle.Location = New System.Drawing.Point(4, 22)
        Me.TbpDetalle.Name = "TbpDetalle"
        Me.TbpDetalle.Padding = New System.Windows.Forms.Padding(3)
        Me.TbpDetalle.Size = New System.Drawing.Size(781, 340)
        Me.TbpDetalle.TabIndex = 1
        Me.TbpDetalle.Text = "Detalle Orden"
        Me.TbpDetalle.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.Location = New System.Drawing.Point(669, 304)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 8
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIVA
        '
        Me.txtIVA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIVA.Location = New System.Drawing.Point(669, 278)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.ReadOnly = True
        Me.txtIVA.Size = New System.Drawing.Size(100, 20)
        Me.txtIVA.TabIndex = 6
        Me.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDescuento
        '
        Me.txtDescuento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescuento.Location = New System.Drawing.Point(669, 252)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.ReadOnly = True
        Me.txtDescuento.Size = New System.Drawing.Size(100, 20)
        Me.txtDescuento.TabIndex = 4
        Me.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSubTotal.Location = New System.Drawing.Point(669, 226)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubTotal.TabIndex = 2
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(599, 307)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Total:"
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(600, 281)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "IVA:"
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(600, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Descuento:"
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(600, 229)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Sub Total:"
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToDeleteRows = False
        Me.dgvDetalle.AllowUserToResizeRows = False
        Me.dgvDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalle.AutoGenerateColumns = False
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmFolioCotiz, Me.clmServicios, Me.clmCantSol, Me.clmCantOrd, Me.clmPrecio, Me.clmDescuentos, Me.clmIVAs, Me.clmImportes, Me.OrdenDataGridViewTextBoxColumn, Me.EstatusDataGridViewTextBoxColumn, Me.IndiceDataGridViewTextBoxColumn, Me.FolioDetSolicDataGridViewTextBoxColumn, Me.clmFolios})
        Me.dgvDetalle.DataSource = Me.OrdenServicioDetC
        Me.dgvDetalle.Location = New System.Drawing.Point(6, 6)
        Me.dgvDetalle.MultiSelect = False
        Me.dgvDetalle.Name = "dgvDetalle"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvDetalle.RowHeadersVisible = False
        Me.dgvDetalle.Size = New System.Drawing.Size(769, 210)
        Me.dgvDetalle.TabIndex = 0
        '
        'OrdenServicioDetC
        '
        Me.OrdenServicioDetC.AllowEdit = True
        Me.OrdenServicioDetC.AllowNew = True
        Me.OrdenServicioDetC.AllowRemove = True
        Me.OrdenServicioDetC.Name = ""
        Me.OrdenServicioDetC.RaiseListChangedEvents = True
        '
        'TbpCotizaciones
        '
        Me.TbpCotizaciones.Controls.Add(Me.dgvCotizaciones)
        Me.TbpCotizaciones.Location = New System.Drawing.Point(4, 22)
        Me.TbpCotizaciones.Name = "TbpCotizaciones"
        Me.TbpCotizaciones.Padding = New System.Windows.Forms.Padding(3)
        Me.TbpCotizaciones.Size = New System.Drawing.Size(781, 340)
        Me.TbpCotizaciones.TabIndex = 0
        Me.TbpCotizaciones.Text = "Cotizaciones"
        Me.TbpCotizaciones.UseVisualStyleBackColor = True
        '
        'dgvCotizaciones
        '
        Me.dgvCotizaciones.AllowUserToAddRows = False
        Me.dgvCotizaciones.AllowUserToDeleteRows = False
        Me.dgvCotizaciones.AllowUserToResizeRows = False
        Me.dgvCotizaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCotizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCotizaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmSeleccion, Me.clmProveedorId, Me.clmIva, Me.clmDescuento, Me.clmIndice, Me.clmCotizacion, Me.clmFecha, Me.clmServicio, Me.clmFolioSolic, Me.clmProveedor, Me.clmCantidad, Me.clmCosto, Me.clmImporte})
        Me.dgvCotizaciones.Location = New System.Drawing.Point(6, 6)
        Me.dgvCotizaciones.Name = "dgvCotizaciones"
        Me.dgvCotizaciones.RowHeadersVisible = False
        Me.dgvCotizaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCotizaciones.Size = New System.Drawing.Size(771, 219)
        Me.dgvCotizaciones.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TbpCotizaciones)
        Me.TabControl1.Controls.Add(Me.TbpDetalle)
        Me.TabControl1.Location = New System.Drawing.Point(56, 152)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(789, 366)
        Me.TabControl1.TabIndex = 61
        '
        'txtProveedor
        '
        Me.txtProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProveedor.Location = New System.Drawing.Point(143, 123)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.ReadOnly = True
        Me.txtProveedor.Size = New System.Drawing.Size(323, 20)
        Me.txtProveedor.TabIndex = 62
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(485, 70)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 13)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "Observaciones:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Location = New System.Drawing.Point(488, 86)
        Me.txtObservaciones.MaxLength = 250
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(341, 60)
        Me.txtObservaciones.TabIndex = 64
        '
        'CmbMoneda
        '
        Me.CmbMoneda.DataSource = Me.MonedaTC
        Me.CmbMoneda.DisplayMember = "Descripcion"
        Me.CmbMoneda.Enabled = False
        Me.CmbMoneda.FormattingEnabled = True
        Me.CmbMoneda.Location = New System.Drawing.Point(362, 95)
        Me.CmbMoneda.Name = "CmbMoneda"
        Me.CmbMoneda.Size = New System.Drawing.Size(104, 21)
        Me.CmbMoneda.TabIndex = 65
        Me.CmbMoneda.ValueMember = "Codigo"
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
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(307, 98)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 13)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "Moneda:"
        '
        'OrdenServicioC
        '
        Me.OrdenServicioC.AllowEdit = True
        Me.OrdenServicioC.AllowNew = True
        Me.OrdenServicioC.AllowRemove = True
        Me.OrdenServicioC.Name = ""
        Me.OrdenServicioC.RaiseListChangedEvents = True
        '
        'Tmplaza
        '
        Me.Tmplaza.Interval = 1000
        '
        'TmSucursal
        '
        Me.TmSucursal.Interval = 1000
        '
        'clmSeleccion
        '
        Me.clmSeleccion.HeaderText = ""
        Me.clmSeleccion.Name = "clmSeleccion"
        Me.clmSeleccion.Width = 35
        '
        'clmProveedorId
        '
        Me.clmProveedorId.DataPropertyName = "ProveedorId"
        Me.clmProveedorId.HeaderText = "ProveedorId"
        Me.clmProveedorId.Name = "clmProveedorId"
        Me.clmProveedorId.Visible = False
        '
        'clmIva
        '
        Me.clmIva.DataPropertyName = "IVA"
        Me.clmIva.HeaderText = "IVA"
        Me.clmIva.Name = "clmIva"
        Me.clmIva.Visible = False
        '
        'clmDescuento
        '
        Me.clmDescuento.DataPropertyName = "Descuento"
        Me.clmDescuento.HeaderText = "Descuento"
        Me.clmDescuento.Name = "clmDescuento"
        Me.clmDescuento.Visible = False
        '
        'clmIndice
        '
        Me.clmIndice.DataPropertyName = "Indice"
        Me.clmIndice.HeaderText = "Indice"
        Me.clmIndice.Name = "clmIndice"
        Me.clmIndice.Visible = False
        '
        'clmCotizacion
        '
        Me.clmCotizacion.DataPropertyName = "Folio"
        Me.clmCotizacion.HeaderText = "Cotización "
        Me.clmCotizacion.Name = "clmCotizacion"
        '
        'clmFecha
        '
        Me.clmFecha.DataPropertyName = "FechaAlta"
        DataGridViewCellStyle7.Format = "d"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.clmFecha.DefaultCellStyle = DataGridViewCellStyle7
        Me.clmFecha.HeaderText = "Fecha"
        Me.clmFecha.Name = "clmFecha"
        '
        'clmServicio
        '
        Me.clmServicio.DataPropertyName = "Servicio"
        Me.clmServicio.HeaderText = "Servicio"
        Me.clmServicio.Name = "clmServicio"
        '
        'clmFolioSolic
        '
        Me.clmFolioSolic.DataPropertyName = "FolioSolicitud"
        Me.clmFolioSolic.HeaderText = "Folio Solic"
        Me.clmFolioSolic.Name = "clmFolioSolic"
        Me.clmFolioSolic.Visible = False
        '
        'clmProveedor
        '
        Me.clmProveedor.DataPropertyName = "prRazSocial"
        Me.clmProveedor.HeaderText = "Proveedor"
        Me.clmProveedor.Name = "clmProveedor"
        '
        'clmCantidad
        '
        Me.clmCantidad.DataPropertyName = "Cantidad"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.clmCantidad.DefaultCellStyle = DataGridViewCellStyle8
        Me.clmCantidad.HeaderText = "Cantidad"
        Me.clmCantidad.Name = "clmCantidad"
        '
        'clmCosto
        '
        Me.clmCosto.DataPropertyName = "costo"
        Me.clmCosto.HeaderText = "Costo"
        Me.clmCosto.Name = "clmCosto"
        Me.clmCosto.Visible = False
        '
        'clmImporte
        '
        Me.clmImporte.DataPropertyName = "Total"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "C2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.clmImporte.DefaultCellStyle = DataGridViewCellStyle9
        Me.clmImporte.HeaderText = "Importe"
        Me.clmImporte.Name = "clmImporte"
        '
        'clmFolioCotiz
        '
        Me.clmFolioCotiz.HeaderText = "Cotización"
        Me.clmFolioCotiz.Name = "clmFolioCotiz"
        Me.clmFolioCotiz.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clmFolioCotiz.Visible = False
        '
        'clmServicios
        '
        Me.clmServicios.DataPropertyName = "Servicio"
        Me.clmServicios.HeaderText = "Servicio"
        Me.clmServicios.Name = "clmServicios"
        Me.clmServicios.ReadOnly = True
        Me.clmServicios.Width = 135
        '
        'clmCantSol
        '
        Me.clmCantSol.DataPropertyName = "CantidadSolic"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.clmCantSol.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmCantSol.HeaderText = "Cant. Solic"
        Me.clmCantSol.Name = "clmCantSol"
        Me.clmCantSol.ReadOnly = True
        Me.clmCantSol.Width = 85
        '
        'clmCantOrd
        '
        Me.clmCantOrd.DataPropertyName = "CantidadOrdenar"
        Me.clmCantOrd.HeaderText = "Cant. Ord"
        Me.clmCantOrd.Name = "clmCantOrd"
        Me.clmCantOrd.Width = 80
        '
        'clmPrecio
        '
        Me.clmPrecio.DataPropertyName = "Precio"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.clmPrecio.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmPrecio.HeaderText = "Costo"
        Me.clmPrecio.Name = "clmPrecio"
        Me.clmPrecio.ReadOnly = True
        '
        'clmDescuentos
        '
        Me.clmDescuentos.DataPropertyName = "Descuento"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.clmDescuentos.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmDescuentos.HeaderText = "Descuento"
        Me.clmDescuentos.Name = "clmDescuentos"
        Me.clmDescuentos.ReadOnly = True
        '
        'clmIVAs
        '
        Me.clmIVAs.DataPropertyName = "IVA"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.clmIVAs.DefaultCellStyle = DataGridViewCellStyle4
        Me.clmIVAs.HeaderText = "IVA(%)"
        Me.clmIVAs.Name = "clmIVAs"
        Me.clmIVAs.ReadOnly = True
        Me.clmIVAs.Width = 50
        '
        'clmImportes
        '
        Me.clmImportes.DataPropertyName = "Importe"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.clmImportes.DefaultCellStyle = DataGridViewCellStyle5
        Me.clmImportes.HeaderText = "Importe"
        Me.clmImportes.Name = "clmImportes"
        Me.clmImportes.ReadOnly = True
        '
        'OrdenDataGridViewTextBoxColumn
        '
        Me.OrdenDataGridViewTextBoxColumn.DataPropertyName = "Orden"
        Me.OrdenDataGridViewTextBoxColumn.HeaderText = "Orden"
        Me.OrdenDataGridViewTextBoxColumn.Name = "OrdenDataGridViewTextBoxColumn"
        Me.OrdenDataGridViewTextBoxColumn.ReadOnly = True
        Me.OrdenDataGridViewTextBoxColumn.Visible = False
        '
        'EstatusDataGridViewTextBoxColumn
        '
        Me.EstatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.HeaderText = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.Name = "EstatusDataGridViewTextBoxColumn"
        Me.EstatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstatusDataGridViewTextBoxColumn.Visible = False
        '
        'IndiceDataGridViewTextBoxColumn
        '
        Me.IndiceDataGridViewTextBoxColumn.DataPropertyName = "Indice"
        Me.IndiceDataGridViewTextBoxColumn.HeaderText = "Indice"
        Me.IndiceDataGridViewTextBoxColumn.Name = "IndiceDataGridViewTextBoxColumn"
        Me.IndiceDataGridViewTextBoxColumn.Visible = False
        '
        'FolioDetSolicDataGridViewTextBoxColumn
        '
        Me.FolioDetSolicDataGridViewTextBoxColumn.DataPropertyName = "FolioDetSolic"
        Me.FolioDetSolicDataGridViewTextBoxColumn.HeaderText = "FolioDetSolic"
        Me.FolioDetSolicDataGridViewTextBoxColumn.Name = "FolioDetSolicDataGridViewTextBoxColumn"
        Me.FolioDetSolicDataGridViewTextBoxColumn.Visible = False
        '
        'clmFolios
        '
        Me.clmFolios.DataPropertyName = "Folio"
        Me.clmFolios.HeaderText = "Folio"
        Me.clmFolios.Name = "clmFolios"
        Me.clmFolios.Visible = False
        '
        'ComEmisionOrdenServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 523)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.CmbMoneda)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtProveedor)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lblEstatus)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DtpFecha)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbSucursal)
        Me.Controls.Add(Me.cmbPlaza)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ComEmisionOrdenServicio"
        Me.Text = "Emision de Orden de Servicios"
        Me.TbpDetalle.ResumeLayout(False)
        Me.TbpDetalle.PerformLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbpCotizaciones.ResumeLayout(False)
        CType(Me.dgvCotizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbPlaza As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents SucursalC As ClasesNegocio.SucursalCollectionClass
    Friend WithEvents PlazaC As ClasesNegocio.PlazaCollectionClass
    Friend WithEvents TbpDetalle As System.Windows.Forms.TabPage
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtIVA As System.Windows.Forms.TextBox
    Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents TbpCotizaciones As System.Windows.Forms.TabPage
    Friend WithEvents dgvCotizaciones As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents txtProveedor As System.Windows.Forms.TextBox
    Friend WithEvents OrdenServicioDetC As ClasesNegocio.OrdenServicioDetCollectionClass
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents CmbMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents MonedaTC As ClasesNegocio.TipoMonedaCollectionClass
    Friend WithEvents OrdenServicioC As ClasesNegocio.OrdenServicioCollectionClass
    Friend WithEvents Tmplaza As System.Windows.Forms.Timer
    Friend WithEvents TmSucursal As System.Windows.Forms.Timer
    Friend WithEvents clmSeleccion As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents clmProveedorId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDescuento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIndice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCotizacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmServicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFolioSolic As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCosto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFolioCotiz As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmServicios As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCantSol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCantOrd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPrecio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDescuentos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIVAs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmImportes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrdenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IndiceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FolioDetSolicDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFolios As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
