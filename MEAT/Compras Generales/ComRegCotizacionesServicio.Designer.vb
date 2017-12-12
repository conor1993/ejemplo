<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComRegCotizacionServicio
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
        Me.Label17 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtImporte = New System.Windows.Forms.TextBox
        Me.txtSuma = New System.Windows.Forms.TextBox
        Me.dgvDetalle = New System.Windows.Forms.DataGridView
        Me.clmFolio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIndice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmSeleccion = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.clmServicio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFechaSurtir = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmUrgente = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.clmCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCosto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmDescuento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIVA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmImporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmUltimoCosto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFechaUltimoServ = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.txtDescuento = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtIVA = New System.Windows.Forms.TextBox
        Me.txtSubTotal = New System.Windows.Forms.TextBox
        Me.txtObservaciones = New System.Windows.Forms.TextBox
        Me.cmbProveedor = New System.Windows.Forms.ComboBox
        Me.ProveedorC = New ClasesNegocio.ProveedorCollectionClass
        Me.txtSolicito = New System.Windows.Forms.TextBox
        Me.CmbSucursal = New System.Windows.Forms.ComboBox
        Me.SucursalC = New ClasesNegocio.SucursalCollectionClass
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker
        Me.txtFolio = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.cmbMoneda = New System.Windows.Forms.ComboBox
        Me.MonedaTC = New ClasesNegocio.TipoMonedaCollectionClass
        Me.Label1 = New System.Windows.Forms.Label
        Me.PlazaC = New ClasesNegocio.PlazaCollectionClass
        Me.CotizacionSolicCabC = New ClasesNegocio.CotizacionSolicCabCollecionClass
        Me.cmbPlaza = New System.Windows.Forms.ComboBox
        Me.Tmplaza = New System.Windows.Forms.Timer(Me.components)
        Me.TmSucursal = New System.Windows.Forms.Timer(Me.components)
        Me.TmProveedor = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
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
        Me.Label17.Size = New System.Drawing.Size(872, 29)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "REGISTRO DE COTIZACIONES DE SERVICIOS"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.mtb.MostrarBorrar = True
        Me.mtb.MostrarBuscar = True
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = True
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 555)
        Me.mtb.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtImporte)
        Me.GroupBox1.Controls.Add(Me.txtSuma)
        Me.GroupBox1.Controls.Add(Me.dgvDetalle)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.txtDescuento)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtIVA)
        Me.GroupBox1.Controls.Add(Me.txtSubTotal)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(59, 195)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(856, 351)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de Orden Servicios"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(203, 218)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 16)
        Me.Label11.TabIndex = 66
        Me.Label11.Text = "Cantidad Total:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtImporte
        '
        Me.txtImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporte.Location = New System.Drawing.Point(739, 217)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.ReadOnly = True
        Me.txtImporte.Size = New System.Drawing.Size(105, 20)
        Me.txtImporte.TabIndex = 9
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSuma
        '
        Me.txtSuma.Location = New System.Drawing.Point(341, 215)
        Me.txtSuma.Name = "txtSuma"
        Me.txtSuma.ReadOnly = True
        Me.txtSuma.Size = New System.Drawing.Size(97, 23)
        Me.txtSuma.TabIndex = 1
        Me.txtSuma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToDeleteRows = False
        Me.dgvDetalle.AllowUserToResizeRows = False
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmFolio, Me.clmIndice, Me.clmSeleccion, Me.clmServicio, Me.clmFechaSurtir, Me.clmUrgente, Me.clmCantidad, Me.clmCosto, Me.clmDescuento, Me.clmIVA, Me.clmImporte, Me.clmUltimoCosto, Me.clmFechaUltimoServ})
        Me.dgvDetalle.Location = New System.Drawing.Point(6, 22)
        Me.dgvDetalle.MultiSelect = False
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.RowHeadersVisible = False
        Me.dgvDetalle.Size = New System.Drawing.Size(838, 189)
        Me.dgvDetalle.TabIndex = 0
        '
        'clmFolio
        '
        Me.clmFolio.DataPropertyName = "Folio"
        Me.clmFolio.HeaderText = "Folio"
        Me.clmFolio.Name = "clmFolio"
        Me.clmFolio.Visible = False
        '
        'clmIndice
        '
        Me.clmIndice.DataPropertyName = "Indice"
        Me.clmIndice.HeaderText = "Indice"
        Me.clmIndice.Name = "clmIndice"
        Me.clmIndice.ReadOnly = True
        Me.clmIndice.Visible = False
        '
        'clmSeleccion
        '
        Me.clmSeleccion.DataPropertyName = "Seleccionado"
        Me.clmSeleccion.HeaderText = ""
        Me.clmSeleccion.Name = "clmSeleccion"
        Me.clmSeleccion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmSeleccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clmSeleccion.Width = 35
        '
        'clmServicio
        '
        Me.clmServicio.DataPropertyName = "Servicio"
        Me.clmServicio.HeaderText = "Servicio"
        Me.clmServicio.Name = "clmServicio"
        Me.clmServicio.Width = 200
        '
        'clmFechaSurtir
        '
        Me.clmFechaSurtir.DataPropertyName = "FechaServicio"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.clmFechaSurtir.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmFechaSurtir.HeaderText = "Fecha Servicio"
        Me.clmFechaSurtir.Name = "clmFechaSurtir"
        Me.clmFechaSurtir.Visible = False
        '
        'clmUrgente
        '
        Me.clmUrgente.DataPropertyName = "Urgente"
        Me.clmUrgente.HeaderText = "Urgente"
        Me.clmUrgente.Name = "clmUrgente"
        '
        'clmCantidad
        '
        Me.clmCantidad.DataPropertyName = "Cantidad"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.NullValue = Nothing
        Me.clmCantidad.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmCantidad.HeaderText = "Cantidad"
        Me.clmCantidad.Name = "clmCantidad"
        '
        'clmCosto
        '
        Me.clmCosto.DataPropertyName = "Costo"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.clmCosto.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmCosto.HeaderText = "Costo"
        Me.clmCosto.Name = "clmCosto"
        '
        'clmDescuento
        '
        Me.clmDescuento.DataPropertyName = "Descuento"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.clmDescuento.DefaultCellStyle = DataGridViewCellStyle4
        Me.clmDescuento.HeaderText = "Descuento"
        Me.clmDescuento.Name = "clmDescuento"
        '
        'clmIVA
        '
        Me.clmIVA.DataPropertyName = "IVA"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.clmIVA.DefaultCellStyle = DataGridViewCellStyle5
        Me.clmIVA.HeaderText = "IVA (%)"
        Me.clmIVA.Name = "clmIVA"
        '
        'clmImporte
        '
        Me.clmImporte.DataPropertyName = "Total"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.clmImporte.DefaultCellStyle = DataGridViewCellStyle6
        Me.clmImporte.HeaderText = "Importe"
        Me.clmImporte.Name = "clmImporte"
        Me.clmImporte.ReadOnly = True
        '
        'clmUltimoCosto
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.clmUltimoCosto.DefaultCellStyle = DataGridViewCellStyle7
        Me.clmUltimoCosto.HeaderText = "Costo Ultimo Servicio"
        Me.clmUltimoCosto.Name = "clmUltimoCosto"
        Me.clmUltimoCosto.ReadOnly = True
        Me.clmUltimoCosto.Visible = False
        '
        'clmFechaUltimoServ
        '
        DataGridViewCellStyle8.Format = "d"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.clmFechaUltimoServ.DefaultCellStyle = DataGridViewCellStyle8
        Me.clmFechaUltimoServ.HeaderText = "Ultimo Servicio"
        Me.clmFechaUltimoServ.Name = "clmFechaUltimoServ"
        Me.clmFechaUltimoServ.ReadOnly = True
        Me.clmFechaUltimoServ.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(682, 220)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Importe:"
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(739, 321)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(105, 20)
        Me.txtTotal.TabIndex = 5
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDescuento
        '
        Me.txtDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescuento.Location = New System.Drawing.Point(739, 243)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.ReadOnly = True
        Me.txtDescuento.Size = New System.Drawing.Size(105, 20)
        Me.txtDescuento.TabIndex = 7
        Me.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(671, 272)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Sub-Total:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(665, 246)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Descuento:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(700, 298)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(27, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "IVA:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(693, 324)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(34, 13)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Total:"
        '
        'txtIVA
        '
        Me.txtIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIVA.Location = New System.Drawing.Point(739, 295)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.ReadOnly = True
        Me.txtIVA.Size = New System.Drawing.Size(105, 20)
        Me.txtIVA.TabIndex = 3
        Me.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.Location = New System.Drawing.Point(739, 269)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(105, 20)
        Me.txtSubTotal.TabIndex = 1
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Location = New System.Drawing.Point(515, 105)
        Me.txtObservaciones.MaxLength = 250
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(388, 74)
        Me.txtObservaciones.TabIndex = 32
        '
        'cmbProveedor
        '
        Me.cmbProveedor.DataSource = Me.ProveedorC
        Me.cmbProveedor.DisplayMember = "RazonSocial"
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(106, 73)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(310, 21)
        Me.cmbProveedor.TabIndex = 30
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
        'txtSolicito
        '
        Me.txtSolicito.Location = New System.Drawing.Point(106, 127)
        Me.txtSolicito.Name = "txtSolicito"
        Me.txtSolicito.ReadOnly = True
        Me.txtSolicito.Size = New System.Drawing.Size(310, 20)
        Me.txtSolicito.TabIndex = 28
        '
        'CmbSucursal
        '
        Me.CmbSucursal.DataSource = Me.SucursalC
        Me.CmbSucursal.DisplayMember = "Descripcion"
        Me.CmbSucursal.FormattingEnabled = True
        Me.CmbSucursal.Location = New System.Drawing.Point(106, 46)
        Me.CmbSucursal.Name = "CmbSucursal"
        Me.CmbSucursal.Size = New System.Drawing.Size(310, 21)
        Me.CmbSucursal.TabIndex = 22
        Me.CmbSucursal.ValueMember = "Codigo"
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
        'DtpFecha
        '
        Me.DtpFecha.Enabled = False
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(106, 99)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(95, 20)
        Me.DtpFecha.TabIndex = 26
        '
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(603, 51)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.ReadOnly = True
        Me.txtFolio.Size = New System.Drawing.Size(94, 20)
        Me.txtFolio.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Fecha de Alta:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(512, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Observaciones:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Proveedor:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Solicitó:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(512, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Folio Cotización:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Sucursal:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Plaza:"
        '
        'lblEstatus
        '
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(804, 49)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(99, 21)
        Me.lblEstatus.TabIndex = 59
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEstatus.Visible = False
        '
        'cmbMoneda
        '
        Me.cmbMoneda.DataSource = Me.MonedaTC
        Me.cmbMoneda.DisplayMember = "Descripcion"
        Me.cmbMoneda.Enabled = False
        Me.cmbMoneda.FormattingEnabled = True
        Me.cmbMoneda.Location = New System.Drawing.Point(302, 100)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.Size = New System.Drawing.Size(114, 21)
        Me.cmbMoneda.TabIndex = 61
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(247, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Moneda:"
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
        'CotizacionSolicCabC
        '
        Me.CotizacionSolicCabC.AllowEdit = True
        Me.CotizacionSolicCabC.AllowNew = True
        Me.CotizacionSolicCabC.AllowRemove = True
        Me.CotizacionSolicCabC.MaximoElementosSeleccionados = 1
        Me.CotizacionSolicCabC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.CotizacionSolicCabC.MostrarAlertas = False
        Me.CotizacionSolicCabC.Name = ""
        Me.CotizacionSolicCabC.RaiseListChangedEvents = True
        Me.CotizacionSolicCabC.Transaction = Nothing
        '
        'cmbPlaza
        '
        Me.cmbPlaza.FormattingEnabled = True
        Me.cmbPlaza.Location = New System.Drawing.Point(106, 19)
        Me.cmbPlaza.Name = "cmbPlaza"
        Me.cmbPlaza.Size = New System.Drawing.Size(310, 21)
        Me.cmbPlaza.TabIndex = 64
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbPlaza)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.cmbMoneda)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.CmbSucursal)
        Me.GroupBox3.Controls.Add(Me.cmbProveedor)
        Me.GroupBox3.Controls.Add(Me.txtSolicito)
        Me.GroupBox3.Controls.Add(Me.DtpFecha)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(59, 32)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(438, 157)
        Me.GroupBox3.TabIndex = 65
        Me.GroupBox3.TabStop = False
        '
        'ComRegCotizacionServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 555)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblEstatus)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(930, 589)
        Me.MinimumSize = New System.Drawing.Size(930, 589)
        Me.Name = "ComRegCotizacionServicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Cotizaciones de Servicios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSuma As System.Windows.Forms.TextBox
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents cmbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents txtSolicito As System.Windows.Forms.TextBox
    Friend WithEvents CmbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents cmbMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtIVA As System.Windows.Forms.TextBox
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ProveedorC As ClasesNegocio.ProveedorCollectionClass
    Friend WithEvents MonedaTC As ClasesNegocio.TipoMonedaCollectionClass
    Friend WithEvents SucursalC As ClasesNegocio.SucursalCollectionClass
    Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PlazaC As ClasesNegocio.PlazaCollectionClass
    Friend WithEvents CotizacionSolicCabC As ClasesNegocio.CotizacionSolicCabCollecionClass
    Friend WithEvents cmbPlaza As System.Windows.Forms.ComboBox
    Friend WithEvents clmFolio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIndice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSeleccion As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents clmServicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaSurtir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmUrgente As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents clmCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCosto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDescuento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmUltimoCosto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaUltimoServ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tmplaza As System.Windows.Forms.Timer
    Friend WithEvents TmSucursal As System.Windows.Forms.Timer
    Friend WithEvents TmProveedor As System.Windows.Forms.Timer
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
