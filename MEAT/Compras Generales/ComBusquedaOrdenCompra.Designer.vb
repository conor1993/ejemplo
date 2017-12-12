<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComBusquedaOrdenCompra
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtFolioOrden = New System.Windows.Forms.TextBox
        Me.cmbProveedor = New System.Windows.Forms.ComboBox
        Me.cmbSucursal = New System.Windows.Forms.ComboBox
        Me.cmbPlaza = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Dgvproductos = New System.Windows.Forms.DataGridView
        Me.DgvOrdencompra = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbtTodas = New System.Windows.Forms.RadioButton
        Me.rbtCanceladas = New System.Windows.Forms.RadioButton
        Me.rbtAcivas = New System.Windows.Forms.RadioButton
        Me.RbtSi = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RbtautorizadasTodas = New System.Windows.Forms.RadioButton
        Me.RbtNo = New System.Windows.Forms.RadioButton
        Me.PlazaC = New ClasesNegocio.PlazaCollectionClass
        Me.SucursalC = New ClasesNegocio.SucursalCollectionClass
        Me.ProveedorC = New ClasesNegocio.ProveedorCollectionClass
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.RbtRecTodas = New System.Windows.Forms.RadioButton
        Me.RbtRecParcial = New System.Windows.Forms.RadioButton
        Me.RbtRecNo = New System.Windows.Forms.RadioButton
        Me.RbtRecSI = New System.Windows.Forms.RadioButton
        Me.ClmIdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmUnidadMedida = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmCantidadOrdenada = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCostoUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmDescuento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIVA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmImporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmCantidadRecibida = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Folio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaAlta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Sucursal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Moneda = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Descuento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IVA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Estatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Solicitud = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIdOrdenCompra = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dgvproductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvOrdencompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'MEAToolBar1
        '
        Me.MEAToolBar1.ButtonSize = New System.Drawing.Size(50, 50)
        Me.MEAToolBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MEAToolBar1.DropDownArrows = True
        Me.MEAToolBar1.HabilitarBorrar = False
        Me.MEAToolBar1.HabilitarBuscar = True
        Me.MEAToolBar1.HabilitarCancelar = False
        Me.MEAToolBar1.HabilitarEditar = False
        Me.MEAToolBar1.HabilitarGuardar = False
        Me.MEAToolBar1.HabilitarImprimir = False
        Me.MEAToolBar1.HabilitarLimpiar = True
        Me.MEAToolBar1.HabilitarNuevo = False
        Me.MEAToolBar1.HabilitarSalir = True
        Me.MEAToolBar1.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32
        Me.MEAToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.MEAToolBar1.MostrarBorrar = False
        Me.MEAToolBar1.MostrarBuscar = True
        Me.MEAToolBar1.MostrarCancelar = False
        Me.MEAToolBar1.MostrarEditar = False
        Me.MEAToolBar1.MostrarGuardar = False
        Me.MEAToolBar1.MostrarImprimir = False
        Me.MEAToolBar1.MostrarLimpiar = True
        Me.MEAToolBar1.MostrarNuevo = False
        Me.MEAToolBar1.MostrarSalir = True
        Me.MEAToolBar1.Name = "MEAToolBar1"
        Me.MEAToolBar1.ShowToolTips = True
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 608)
        Me.MEAToolBar1.TabIndex = 0
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
        Me.Label1.Size = New System.Drawing.Size(1046, 29)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "BUSQUEDA DE ORDENES DE COMPRA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFolioOrden
        '
        Me.txtFolioOrden.Location = New System.Drawing.Point(126, 37)
        Me.txtFolioOrden.MaxLength = 15
        Me.txtFolioOrden.Name = "txtFolioOrden"
        Me.txtFolioOrden.Size = New System.Drawing.Size(100, 20)
        Me.txtFolioOrden.TabIndex = 33
        '
        'cmbProveedor
        '
        Me.cmbProveedor.DisplayMember = "RazonSocial"
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(126, 116)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(373, 21)
        Me.cmbProveedor.TabIndex = 32
        Me.cmbProveedor.ValueMember = "Codigo"
        '
        'cmbSucursal
        '
        Me.cmbSucursal.DisplayMember = "Descripcion"
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(126, 90)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(373, 21)
        Me.cmbSucursal.TabIndex = 31
        Me.cmbSucursal.ValueMember = "Codigo"
        '
        'cmbPlaza
        '
        Me.cmbPlaza.DisplayMember = "Descripcion"
        Me.cmbPlaza.FormattingEnabled = True
        Me.cmbPlaza.Location = New System.Drawing.Point(126, 63)
        Me.cmbPlaza.Name = "cmbPlaza"
        Me.cmbPlaza.Size = New System.Drawing.Size(373, 21)
        Me.cmbPlaza.TabIndex = 30
        Me.cmbPlaza.ValueMember = "Codigo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(56, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Proveedor:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Folio Orden:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Sucursal:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Plaza:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Dgvproductos)
        Me.GroupBox1.Controls.Add(Me.DgvOrdencompra)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(56, 143)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1035, 459)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de Ordenes de Compras"
        '
        'Dgvproductos
        '
        Me.Dgvproductos.AllowUserToAddRows = False
        Me.Dgvproductos.AllowUserToDeleteRows = False
        Me.Dgvproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvproductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClmIdProducto, Me.ClmDescripcion, Me.ClmUnidadMedida, Me.ClmCantidadOrdenada, Me.clmCostoUnitario, Me.clmDescuento, Me.clmIVA, Me.clmImporte, Me.ClmCantidadRecibida})
        Me.Dgvproductos.Location = New System.Drawing.Point(6, 239)
        Me.Dgvproductos.Name = "Dgvproductos"
        Me.Dgvproductos.ReadOnly = True
        Me.Dgvproductos.RowHeadersVisible = False
        Me.Dgvproductos.Size = New System.Drawing.Size(1024, 211)
        Me.Dgvproductos.TabIndex = 1
        '
        'DgvOrdencompra
        '
        Me.DgvOrdencompra.AllowUserToAddRows = False
        Me.DgvOrdencompra.AllowUserToDeleteRows = False
        Me.DgvOrdencompra.AllowUserToResizeRows = False
        Me.DgvOrdencompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvOrdencompra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Folio, Me.FechaAlta, Me.Proveedor, Me.Sucursal, Me.Moneda, Me.SubTotal, Me.Descuento, Me.IVA, Me.Total, Me.Observaciones, Me.Estatus, Me.Solicitud, Me.clmIdOrdenCompra})
        Me.DgvOrdencompra.Location = New System.Drawing.Point(6, 22)
        Me.DgvOrdencompra.MultiSelect = False
        Me.DgvOrdencompra.Name = "DgvOrdencompra"
        Me.DgvOrdencompra.RowHeadersVisible = False
        Me.DgvOrdencompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvOrdencompra.Size = New System.Drawing.Size(1024, 211)
        Me.DgvOrdencompra.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.rbtTodas)
        Me.GroupBox2.Controls.Add(Me.rbtCanceladas)
        Me.GroupBox2.Controls.Add(Me.rbtAcivas)
        Me.GroupBox2.Location = New System.Drawing.Point(507, 40)
        Me.GroupBox2.MaximumSize = New System.Drawing.Size(250, 50)
        Me.GroupBox2.MinimumSize = New System.Drawing.Size(250, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(250, 50)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estatus"
        '
        'rbtTodas
        '
        Me.rbtTodas.AutoSize = True
        Me.rbtTodas.Checked = True
        Me.rbtTodas.Location = New System.Drawing.Point(164, 20)
        Me.rbtTodas.Name = "rbtTodas"
        Me.rbtTodas.Size = New System.Drawing.Size(55, 17)
        Me.rbtTodas.TabIndex = 2
        Me.rbtTodas.TabStop = True
        Me.rbtTodas.Text = "Todas"
        Me.rbtTodas.UseVisualStyleBackColor = True
        '
        'rbtCanceladas
        '
        Me.rbtCanceladas.AutoSize = True
        Me.rbtCanceladas.Location = New System.Drawing.Point(71, 19)
        Me.rbtCanceladas.Name = "rbtCanceladas"
        Me.rbtCanceladas.Size = New System.Drawing.Size(81, 17)
        Me.rbtCanceladas.TabIndex = 1
        Me.rbtCanceladas.Text = "Canceladas"
        Me.rbtCanceladas.UseVisualStyleBackColor = True
        '
        'rbtAcivas
        '
        Me.rbtAcivas.AutoSize = True
        Me.rbtAcivas.Location = New System.Drawing.Point(5, 20)
        Me.rbtAcivas.Name = "rbtAcivas"
        Me.rbtAcivas.Size = New System.Drawing.Size(60, 17)
        Me.rbtAcivas.TabIndex = 0
        Me.rbtAcivas.Text = "Activas"
        Me.rbtAcivas.UseVisualStyleBackColor = True
        '
        'RbtSi
        '
        Me.RbtSi.AutoSize = True
        Me.RbtSi.Location = New System.Drawing.Point(7, 19)
        Me.RbtSi.Name = "RbtSi"
        Me.RbtSi.Size = New System.Drawing.Size(34, 17)
        Me.RbtSi.TabIndex = 3
        Me.RbtSi.Text = "Si"
        Me.RbtSi.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RbtautorizadasTodas)
        Me.GroupBox3.Controls.Add(Me.RbtNo)
        Me.GroupBox3.Controls.Add(Me.RbtSi)
        Me.GroupBox3.Location = New System.Drawing.Point(761, 40)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(171, 49)
        Me.GroupBox3.TabIndex = 38
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Autorizadas"
        '
        'RbtautorizadasTodas
        '
        Me.RbtautorizadasTodas.AutoSize = True
        Me.RbtautorizadasTodas.Checked = True
        Me.RbtautorizadasTodas.Location = New System.Drawing.Point(104, 19)
        Me.RbtautorizadasTodas.Name = "RbtautorizadasTodas"
        Me.RbtautorizadasTodas.Size = New System.Drawing.Size(55, 17)
        Me.RbtautorizadasTodas.TabIndex = 5
        Me.RbtautorizadasTodas.TabStop = True
        Me.RbtautorizadasTodas.Text = "Todas"
        Me.RbtautorizadasTodas.UseVisualStyleBackColor = True
        '
        'RbtNo
        '
        Me.RbtNo.AutoSize = True
        Me.RbtNo.Location = New System.Drawing.Point(59, 19)
        Me.RbtNo.Name = "RbtNo"
        Me.RbtNo.Size = New System.Drawing.Size(39, 17)
        Me.RbtNo.TabIndex = 4
        Me.RbtNo.Text = "No"
        Me.RbtNo.UseVisualStyleBackColor = True
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
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RbtRecTodas)
        Me.GroupBox4.Controls.Add(Me.RbtRecParcial)
        Me.GroupBox4.Controls.Add(Me.RbtRecNo)
        Me.GroupBox4.Controls.Add(Me.RbtRecSI)
        Me.GroupBox4.Location = New System.Drawing.Point(507, 94)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(349, 45)
        Me.GroupBox4.TabIndex = 39
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Recibidas"
        '
        'RbtRecTodas
        '
        Me.RbtRecTodas.AutoSize = True
        Me.RbtRecTodas.Checked = True
        Me.RbtRecTodas.Location = New System.Drawing.Point(249, 19)
        Me.RbtRecTodas.Name = "RbtRecTodas"
        Me.RbtRecTodas.Size = New System.Drawing.Size(55, 17)
        Me.RbtRecTodas.TabIndex = 3
        Me.RbtRecTodas.TabStop = True
        Me.RbtRecTodas.Text = "Todas"
        Me.RbtRecTodas.UseVisualStyleBackColor = True
        '
        'RbtRecParcial
        '
        Me.RbtRecParcial.AutoSize = True
        Me.RbtRecParcial.Location = New System.Drawing.Point(146, 19)
        Me.RbtRecParcial.Name = "RbtRecParcial"
        Me.RbtRecParcial.Size = New System.Drawing.Size(89, 17)
        Me.RbtRecParcial.TabIndex = 2
        Me.RbtRecParcial.Text = "Parcialmente "
        Me.RbtRecParcial.UseVisualStyleBackColor = True
        '
        'RbtRecNo
        '
        Me.RbtRecNo.AutoSize = True
        Me.RbtRecNo.Location = New System.Drawing.Point(69, 19)
        Me.RbtRecNo.Name = "RbtRecNo"
        Me.RbtRecNo.Size = New System.Drawing.Size(39, 17)
        Me.RbtRecNo.TabIndex = 1
        Me.RbtRecNo.Text = "No"
        Me.RbtRecNo.UseVisualStyleBackColor = True
        '
        'RbtRecSI
        '
        Me.RbtRecSI.AutoSize = True
        Me.RbtRecSI.Location = New System.Drawing.Point(6, 19)
        Me.RbtRecSI.Name = "RbtRecSI"
        Me.RbtRecSI.Size = New System.Drawing.Size(34, 17)
        Me.RbtRecSI.TabIndex = 0
        Me.RbtRecSI.Text = "Si"
        Me.RbtRecSI.UseVisualStyleBackColor = True
        '
        'ClmIdProducto
        '
        Me.ClmIdProducto.DataPropertyName = "IdProducto"
        Me.ClmIdProducto.HeaderText = "Codigo"
        Me.ClmIdProducto.Name = "ClmIdProducto"
        Me.ClmIdProducto.ReadOnly = True
        '
        'ClmDescripcion
        '
        Me.ClmDescripcion.DataPropertyName = "ProductoNombre"
        Me.ClmDescripcion.HeaderText = "Descripcion"
        Me.ClmDescripcion.Name = "ClmDescripcion"
        Me.ClmDescripcion.ReadOnly = True
        Me.ClmDescripcion.Width = 240
        '
        'ClmUnidadMedida
        '
        Me.ClmUnidadMedida.DataPropertyName = "UnidadMedida"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.NullValue = Nothing
        Me.ClmUnidadMedida.DefaultCellStyle = DataGridViewCellStyle1
        Me.ClmUnidadMedida.HeaderText = "Unidad Medida"
        Me.ClmUnidadMedida.Name = "ClmUnidadMedida"
        Me.ClmUnidadMedida.ReadOnly = True
        Me.ClmUnidadMedida.Width = 150
        '
        'ClmCantidadOrdenada
        '
        Me.ClmCantidadOrdenada.DataPropertyName = "CantidadOrdenada"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.ClmCantidadOrdenada.DefaultCellStyle = DataGridViewCellStyle2
        Me.ClmCantidadOrdenada.HeaderText = "Cant Ord"
        Me.ClmCantidadOrdenada.Name = "ClmCantidadOrdenada"
        Me.ClmCantidadOrdenada.ReadOnly = True
        '
        'clmCostoUnitario
        '
        Me.clmCostoUnitario.DataPropertyName = "Precio"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.clmCostoUnitario.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmCostoUnitario.HeaderText = "Cost Uni"
        Me.clmCostoUnitario.Name = "clmCostoUnitario"
        Me.clmCostoUnitario.ReadOnly = True
        '
        'clmDescuento
        '
        Me.clmDescuento.DataPropertyName = "Descuento"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.clmDescuento.DefaultCellStyle = DataGridViewCellStyle4
        Me.clmDescuento.HeaderText = "Descuento"
        Me.clmDescuento.Name = "clmDescuento"
        Me.clmDescuento.ReadOnly = True
        '
        'clmIVA
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.clmIVA.DefaultCellStyle = DataGridViewCellStyle5
        Me.clmIVA.HeaderText = "IVA"
        Me.clmIVA.Name = "clmIVA"
        Me.clmIVA.ReadOnly = True
        '
        'clmImporte
        '
        Me.clmImporte.DataPropertyName = "Importe"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.clmImporte.DefaultCellStyle = DataGridViewCellStyle6
        Me.clmImporte.HeaderText = "Importe"
        Me.clmImporte.Name = "clmImporte"
        Me.clmImporte.ReadOnly = True
        '
        'ClmCantidadRecibida
        '
        Me.ClmCantidadRecibida.DataPropertyName = "CantRecibidas"
        Me.ClmCantidadRecibida.HeaderText = "Cantidad Recibida"
        Me.ClmCantidadRecibida.Name = "ClmCantidadRecibida"
        Me.ClmCantidadRecibida.ReadOnly = True
        Me.ClmCantidadRecibida.Visible = False
        '
        'Folio
        '
        Me.Folio.DataPropertyName = "FolioOrdenCompra"
        Me.Folio.HeaderText = "Folio"
        Me.Folio.Name = "Folio"
        Me.Folio.Width = 130
        '
        'FechaAlta
        '
        Me.FechaAlta.DataPropertyName = "FechaOrdenCompra"
        Me.FechaAlta.HeaderText = "Fecha"
        Me.FechaAlta.Name = "FechaAlta"
        '
        'Proveedor
        '
        Me.Proveedor.DataPropertyName = "Proveedor"
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        Me.Proveedor.Width = 250
        '
        'Sucursal
        '
        Me.Sucursal.DataPropertyName = "Sucursal"
        Me.Sucursal.HeaderText = "Sucursal"
        Me.Sucursal.Name = "Sucursal"
        '
        'Moneda
        '
        Me.Moneda.DataPropertyName = "Moneda"
        Me.Moneda.HeaderText = "Moneda"
        Me.Moneda.Name = "Moneda"
        Me.Moneda.Visible = False
        '
        'SubTotal
        '
        Me.SubTotal.DataPropertyName = "SubTotal"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.SubTotal.DefaultCellStyle = DataGridViewCellStyle7
        Me.SubTotal.HeaderText = "SubTotal"
        Me.SubTotal.Name = "SubTotal"
        '
        'Descuento
        '
        Me.Descuento.DataPropertyName = "Descuento"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.Descuento.DefaultCellStyle = DataGridViewCellStyle8
        Me.Descuento.HeaderText = "Descuento"
        Me.Descuento.Name = "Descuento"
        '
        'IVA
        '
        Me.IVA.DataPropertyName = "IVATotal"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.IVA.DefaultCellStyle = DataGridViewCellStyle9
        Me.IVA.HeaderText = "IVA"
        Me.IVA.Name = "IVA"
        '
        'Total
        '
        Me.Total.DataPropertyName = "Total"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.Total.DefaultCellStyle = DataGridViewCellStyle10
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        '
        'Observaciones
        '
        Me.Observaciones.DataPropertyName = "Observaciones"
        Me.Observaciones.HeaderText = "Observaciones"
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.Visible = False
        '
        'Estatus
        '
        Me.Estatus.DataPropertyName = "EstatusDes"
        Me.Estatus.HeaderText = "Estatus"
        Me.Estatus.Name = "Estatus"
        '
        'Solicitud
        '
        Me.Solicitud.DataPropertyName = "SolicitudId"
        Me.Solicitud.HeaderText = "Solicitud"
        Me.Solicitud.Name = "Solicitud"
        Me.Solicitud.Visible = False
        '
        'clmIdOrdenCompra
        '
        Me.clmIdOrdenCompra.DataPropertyName = "IdOrdenCompra"
        Me.clmIdOrdenCompra.HeaderText = "OrdenCompra"
        Me.clmIdOrdenCompra.Name = "clmIdOrdenCompra"
        Me.clmIdOrdenCompra.Visible = False
        '
        'ComBusquedaOrdenCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 608)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtFolioOrden)
        Me.Controls.Add(Me.cmbProveedor)
        Me.Controls.Add(Me.cmbSucursal)
        Me.Controls.Add(Me.cmbPlaza)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1104, 642)
        Me.MinimumSize = New System.Drawing.Size(1104, 642)
        Me.Name = "ComBusquedaOrdenCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Búsqueda de  Ordenes de Compras"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Dgvproductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvOrdencompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFolioOrden As System.Windows.Forms.TextBox
    Friend WithEvents cmbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPlaza As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DgvOrdencompra As System.Windows.Forms.DataGridView
    Friend WithEvents PlazaC As ClasesNegocio.PlazaCollectionClass
    Friend WithEvents SucursalC As ClasesNegocio.SucursalCollectionClass
    Friend WithEvents ProveedorC As ClasesNegocio.ProveedorCollectionClass
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtTodas As System.Windows.Forms.RadioButton
    Friend WithEvents rbtCanceladas As System.Windows.Forms.RadioButton
    Friend WithEvents rbtAcivas As System.Windows.Forms.RadioButton
    Friend WithEvents RbtSi As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RbtautorizadasTodas As System.Windows.Forms.RadioButton
    Friend WithEvents RbtNo As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RbtRecNo As System.Windows.Forms.RadioButton
    Friend WithEvents RbtRecSI As System.Windows.Forms.RadioButton
    Friend WithEvents RbtRecTodas As System.Windows.Forms.RadioButton
    Friend WithEvents RbtRecParcial As System.Windows.Forms.RadioButton
    Friend WithEvents Dgvproductos As System.Windows.Forms.DataGridView
    Friend WithEvents ClmIdProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmUnidadMedida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmCantidadOrdenada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCostoUnitario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDescuento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmCantidadRecibida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Folio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaAlta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sucursal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Moneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descuento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Observaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Solicitud As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdOrdenCompra As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
