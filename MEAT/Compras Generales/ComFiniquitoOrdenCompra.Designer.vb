<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComFiniquitoOrdenCompra
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.txtDescuento = New System.Windows.Forms.TextBox
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.txtIVA = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtSubTotal = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtImporte = New System.Windows.Forms.TextBox
        Me.cmbSucursal = New System.Windows.Forms.ComboBox
        Me.cmbPlaza = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dgvDetalleOrdenCompra = New System.Windows.Forms.DataGridView
        Me.clmProducto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UnidadMedidaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCantidadOrdenada = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCantRecibida = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCosto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmDescuento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIVA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtCantidadEmitida = New System.Windows.Forms.TextBox
        Me.txtCantidadSolicitada = New System.Windows.Forms.TextBox
        Me.OrdenCompraDetalleC = New ClasesNegocio.OrdenCompraDetalleCollectionClass
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgOrdenesCompra = New System.Windows.Forms.DataGridView
        Me.clmSeleccion = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.FolioOrdenCompra = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SucursalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AutorizadaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RecibidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescuentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IvaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OrdenadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIdOrdenCompra = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VwCompFiniquitoOrdenCompraTypedView1 = New Integralab.ORM.TypedViewClasses.VwCompFiniquitoOrdenCompraTypedView
        Me.SucursalC = New ClasesNegocio.SucursalCollectionClass
        Me.PlazaC = New ClasesNegocio.PlazaCollectionClass
        Me.OrdenCompraC = New ClasesNegocio.OrdenCompraCollectionClass
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvDetalleOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgOrdenesCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwCompFiniquitoOrdenCompraTypedView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Size = New System.Drawing.Size(978, 29)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "FINIQUITO DE ORDENES DE COMPRAS"
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
        Me.MEAToolBar1.MostrarBorrar = False
        Me.MEAToolBar1.MostrarBuscar = True
        Me.MEAToolBar1.MostrarCancelar = False
        Me.MEAToolBar1.MostrarEditar = False
        Me.MEAToolBar1.MostrarGuardar = True
        Me.MEAToolBar1.MostrarImprimir = False
        Me.MEAToolBar1.MostrarLimpiar = True
        Me.MEAToolBar1.MostrarNuevo = False
        Me.MEAToolBar1.MostrarSalir = True
        Me.MEAToolBar1.Name = "MEAToolBar1"
        Me.MEAToolBar1.ShowToolTips = True
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 698)
        Me.MEAToolBar1.TabIndex = 9
        '
        'GroupBox9
        '
        Me.GroupBox9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox9.Controls.Add(Me.txtDescuento)
        Me.GroupBox9.Controls.Add(Me.txtTotal)
        Me.GroupBox9.Controls.Add(Me.txtIVA)
        Me.GroupBox9.Controls.Add(Me.Label4)
        Me.GroupBox9.Controls.Add(Me.Label5)
        Me.GroupBox9.Controls.Add(Me.Label6)
        Me.GroupBox9.Controls.Add(Me.Label7)
        Me.GroupBox9.Controls.Add(Me.txtSubTotal)
        Me.GroupBox9.Controls.Add(Me.Label12)
        Me.GroupBox9.Controls.Add(Me.txtImporte)
        Me.GroupBox9.Location = New System.Drawing.Point(725, 545)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(232, 141)
        Me.GroupBox9.TabIndex = 38
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Importes"
        '
        'txtDescuento
        '
        Me.txtDescuento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescuento.Location = New System.Drawing.Point(94, 37)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.ReadOnly = True
        Me.txtDescuento.Size = New System.Drawing.Size(92, 20)
        Me.txtDescuento.TabIndex = 41
        Me.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.Location = New System.Drawing.Point(94, 115)
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
        Me.txtIVA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtIVA.Location = New System.Drawing.Point(94, 89)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.ReadOnly = True
        Me.txtIVA.Size = New System.Drawing.Size(92, 20)
        Me.txtIVA.TabIndex = 43
        Me.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Total:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "IVA:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Sub-Total:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Descuento:"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSubTotal.Location = New System.Drawing.Point(94, 63)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(92, 20)
        Me.txtSubTotal.TabIndex = 42
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(31, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Importe:"
        '
        'txtImporte
        '
        Me.txtImporte.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImporte.Location = New System.Drawing.Point(94, 13)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.ReadOnly = True
        Me.txtImporte.Size = New System.Drawing.Size(92, 20)
        Me.txtImporte.TabIndex = 36
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbSucursal
        '
        Me.cmbSucursal.DisplayMember = "Descripcion"
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(110, 62)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(188, 21)
        Me.cmbSucursal.TabIndex = 75
        Me.cmbSucursal.ValueMember = "Codigo"
        '
        'cmbPlaza
        '
        Me.cmbPlaza.DisplayMember = "Descripcion"
        Me.cmbPlaza.FormattingEnabled = True
        Me.cmbPlaza.Location = New System.Drawing.Point(110, 35)
        Me.cmbPlaza.Name = "cmbPlaza"
        Me.cmbPlaza.Size = New System.Drawing.Size(188, 21)
        Me.cmbPlaza.TabIndex = 74
        Me.cmbPlaza.ValueMember = "Codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Plaza:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Sucursal:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.dgvDetalleOrdenCompra)
        Me.GroupBox2.Controls.Add(Me.txtCantidadEmitida)
        Me.GroupBox2.Controls.Add(Me.txtCantidadSolicitada)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(58, 310)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(936, 229)
        Me.GroupBox2.TabIndex = 77
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle de Orden"
        '
        'dgvDetalleOrdenCompra
        '
        Me.dgvDetalleOrdenCompra.AllowUserToAddRows = False
        Me.dgvDetalleOrdenCompra.AllowUserToDeleteRows = False
        Me.dgvDetalleOrdenCompra.AllowUserToResizeRows = False
        Me.dgvDetalleOrdenCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleOrdenCompra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmProducto, Me.UnidadMedidaColumn, Me.clmCantidadOrdenada, Me.clmCantRecibida, Me.clmCosto, Me.clmDescuento, Me.clmIVA, Me.Importe})
        Me.dgvDetalleOrdenCompra.Location = New System.Drawing.Point(6, 19)
        Me.dgvDetalleOrdenCompra.MultiSelect = False
        Me.dgvDetalleOrdenCompra.Name = "dgvDetalleOrdenCompra"
        Me.dgvDetalleOrdenCompra.RowHeadersVisible = False
        Me.dgvDetalleOrdenCompra.Size = New System.Drawing.Size(924, 177)
        Me.dgvDetalleOrdenCompra.TabIndex = 3
        '
        'clmProducto
        '
        Me.clmProducto.DataPropertyName = "Producto"
        Me.clmProducto.HeaderText = "Producto"
        Me.clmProducto.Name = "clmProducto"
        Me.clmProducto.Width = 200
        '
        'UnidadMedidaColumn
        '
        Me.UnidadMedidaColumn.DataPropertyName = "UnidadMedida"
        Me.UnidadMedidaColumn.HeaderText = "Unidad"
        Me.UnidadMedidaColumn.Name = "UnidadMedidaColumn"
        Me.UnidadMedidaColumn.ReadOnly = True
        Me.UnidadMedidaColumn.Width = 60
        '
        'clmCantidadOrdenada
        '
        Me.clmCantidadOrdenada.DataPropertyName = "CantidadOrdenada"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.clmCantidadOrdenada.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmCantidadOrdenada.HeaderText = "Cant Ordenada"
        Me.clmCantidadOrdenada.Name = "clmCantidadOrdenada"
        Me.clmCantidadOrdenada.Width = 120
        '
        'clmCantRecibida
        '
        Me.clmCantRecibida.DataPropertyName = "CantRecibida"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.clmCantRecibida.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmCantRecibida.HeaderText = "Cant Recibida"
        Me.clmCantRecibida.Name = "clmCantRecibida"
        Me.clmCantRecibida.Width = 120
        '
        'clmCosto
        '
        Me.clmCosto.DataPropertyName = "Precio"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.clmCosto.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmCosto.HeaderText = "Costo"
        Me.clmCosto.Name = "clmCosto"
        '
        'clmDescuento
        '
        Me.clmDescuento.DataPropertyName = "Descuento"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.clmDescuento.DefaultCellStyle = DataGridViewCellStyle4
        Me.clmDescuento.HeaderText = "Descuento"
        Me.clmDescuento.Name = "clmDescuento"
        '
        'clmIVA
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.clmIVA.DefaultCellStyle = DataGridViewCellStyle5
        Me.clmIVA.HeaderText = "IVA"
        Me.clmIVA.Name = "clmIVA"
        '
        'Importe
        '
        Me.Importe.DataPropertyName = "Importe"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = "0"
        Me.Importe.DefaultCellStyle = DataGridViewCellStyle6
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        '
        'txtCantidadEmitida
        '
        Me.txtCantidadEmitida.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCantidadEmitida.Location = New System.Drawing.Point(475, 203)
        Me.txtCantidadEmitida.MaxLength = 10
        Me.txtCantidadEmitida.Name = "txtCantidadEmitida"
        Me.txtCantidadEmitida.ReadOnly = True
        Me.txtCantidadEmitida.Size = New System.Drawing.Size(98, 20)
        Me.txtCantidadEmitida.TabIndex = 3
        Me.txtCantidadEmitida.Text = "0"
        Me.txtCantidadEmitida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCantidadSolicitada
        '
        Me.txtCantidadSolicitada.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCantidadSolicitada.Location = New System.Drawing.Point(336, 203)
        Me.txtCantidadSolicitada.MaxLength = 10
        Me.txtCantidadSolicitada.Name = "txtCantidadSolicitada"
        Me.txtCantidadSolicitada.ReadOnly = True
        Me.txtCantidadSolicitada.Size = New System.Drawing.Size(98, 20)
        Me.txtCantidadSolicitada.TabIndex = 2
        Me.txtCantidadSolicitada.Text = "0"
        Me.txtCantidadSolicitada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgOrdenesCompra)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(58, 100)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(936, 204)
        Me.GroupBox1.TabIndex = 76
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado de Ordenes de Compra"
        '
        'dgOrdenesCompra
        '
        Me.dgOrdenesCompra.AllowUserToAddRows = False
        Me.dgOrdenesCompra.AllowUserToDeleteRows = False
        Me.dgOrdenesCompra.AllowUserToResizeRows = False
        Me.dgOrdenesCompra.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgOrdenesCompra.AutoGenerateColumns = False
        Me.dgOrdenesCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgOrdenesCompra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmSeleccion, Me.FolioOrdenCompra, Me.FechaDataGridViewTextBoxColumn, Me.SucursalDataGridViewTextBoxColumn, Me.ProveedorDataGridViewTextBoxColumn, Me.AutorizadaDataGridViewTextBoxColumn, Me.RecibidoDataGridViewTextBoxColumn, Me.EstatusDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn, Me.SubTotalDataGridViewTextBoxColumn, Me.DescuentoDataGridViewTextBoxColumn, Me.IvaDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.OrdenadoDataGridViewTextBoxColumn, Me.clmIdOrdenCompra})
        Me.dgOrdenesCompra.DataSource = Me.VwCompFiniquitoOrdenCompraTypedView1
        Me.dgOrdenesCompra.Location = New System.Drawing.Point(6, 19)
        Me.dgOrdenesCompra.MultiSelect = False
        Me.dgOrdenesCompra.Name = "dgOrdenesCompra"
        Me.dgOrdenesCompra.RowHeadersVisible = False
        Me.dgOrdenesCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgOrdenesCompra.Size = New System.Drawing.Size(924, 179)
        Me.dgOrdenesCompra.TabIndex = 1
        '
        'clmSeleccion
        '
        Me.clmSeleccion.HeaderText = ""
        Me.clmSeleccion.Name = "clmSeleccion"
        Me.clmSeleccion.Width = 40
        '
        'FolioOrdenCompra
        '
        Me.FolioOrdenCompra.DataPropertyName = "FolioOrdenCompra"
        Me.FolioOrdenCompra.HeaderText = "Folio"
        Me.FolioOrdenCompra.Name = "FolioOrdenCompra"
        Me.FolioOrdenCompra.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 90
        '
        'SucursalDataGridViewTextBoxColumn
        '
        Me.SucursalDataGridViewTextBoxColumn.DataPropertyName = "Sucursal"
        Me.SucursalDataGridViewTextBoxColumn.HeaderText = "Sucursal"
        Me.SucursalDataGridViewTextBoxColumn.Name = "SucursalDataGridViewTextBoxColumn"
        Me.SucursalDataGridViewTextBoxColumn.ReadOnly = True
        Me.SucursalDataGridViewTextBoxColumn.Width = 120
        '
        'ProveedorDataGridViewTextBoxColumn
        '
        Me.ProveedorDataGridViewTextBoxColumn.DataPropertyName = "Proveedor"
        Me.ProveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor"
        Me.ProveedorDataGridViewTextBoxColumn.Name = "ProveedorDataGridViewTextBoxColumn"
        Me.ProveedorDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProveedorDataGridViewTextBoxColumn.Width = 150
        '
        'AutorizadaDataGridViewTextBoxColumn
        '
        Me.AutorizadaDataGridViewTextBoxColumn.DataPropertyName = "Autorizada"
        Me.AutorizadaDataGridViewTextBoxColumn.HeaderText = "Aut"
        Me.AutorizadaDataGridViewTextBoxColumn.Name = "AutorizadaDataGridViewTextBoxColumn"
        Me.AutorizadaDataGridViewTextBoxColumn.ReadOnly = True
        Me.AutorizadaDataGridViewTextBoxColumn.Visible = False
        Me.AutorizadaDataGridViewTextBoxColumn.Width = 50
        '
        'RecibidoDataGridViewTextBoxColumn
        '
        Me.RecibidoDataGridViewTextBoxColumn.DataPropertyName = "Recibido"
        Me.RecibidoDataGridViewTextBoxColumn.HeaderText = "Recibido"
        Me.RecibidoDataGridViewTextBoxColumn.Name = "RecibidoDataGridViewTextBoxColumn"
        Me.RecibidoDataGridViewTextBoxColumn.ReadOnly = True
        Me.RecibidoDataGridViewTextBoxColumn.Visible = False
        '
        'EstatusDataGridViewTextBoxColumn
        '
        Me.EstatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.HeaderText = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.Name = "EstatusDataGridViewTextBoxColumn"
        Me.EstatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstatusDataGridViewTextBoxColumn.Visible = False
        '
        'ImporteDataGridViewTextBoxColumn
        '
        Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
        Me.ImporteDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImporteDataGridViewTextBoxColumn.Visible = False
        '
        'SubTotalDataGridViewTextBoxColumn
        '
        Me.SubTotalDataGridViewTextBoxColumn.DataPropertyName = "SubTotal"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = "0"
        Me.SubTotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.SubTotalDataGridViewTextBoxColumn.HeaderText = "SubTotal"
        Me.SubTotalDataGridViewTextBoxColumn.Name = "SubTotalDataGridViewTextBoxColumn"
        Me.SubTotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescuentoDataGridViewTextBoxColumn
        '
        Me.DescuentoDataGridViewTextBoxColumn.DataPropertyName = "Descuento"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = "0"
        Me.DescuentoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.DescuentoDataGridViewTextBoxColumn.HeaderText = "Descuento"
        Me.DescuentoDataGridViewTextBoxColumn.Name = "DescuentoDataGridViewTextBoxColumn"
        Me.DescuentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IvaDataGridViewTextBoxColumn
        '
        Me.IvaDataGridViewTextBoxColumn.DataPropertyName = "Iva"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = "0"
        Me.IvaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.IvaDataGridViewTextBoxColumn.HeaderText = "Iva"
        Me.IvaDataGridViewTextBoxColumn.Name = "IvaDataGridViewTextBoxColumn"
        Me.IvaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = "0"
        Me.TotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OrdenadoDataGridViewTextBoxColumn
        '
        Me.OrdenadoDataGridViewTextBoxColumn.DataPropertyName = "Ordenado"
        Me.OrdenadoDataGridViewTextBoxColumn.HeaderText = "Ordenado"
        Me.OrdenadoDataGridViewTextBoxColumn.Name = "OrdenadoDataGridViewTextBoxColumn"
        Me.OrdenadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.OrdenadoDataGridViewTextBoxColumn.Visible = False
        '
        'clmIdOrdenCompra
        '
        Me.clmIdOrdenCompra.DataPropertyName = "IdOrdenCompra"
        Me.clmIdOrdenCompra.HeaderText = "IdOrdenCompra"
        Me.clmIdOrdenCompra.Name = "clmIdOrdenCompra"
        Me.clmIdOrdenCompra.ReadOnly = True
        Me.clmIdOrdenCompra.Visible = False
        '
        'VwCompFiniquitoOrdenCompraTypedView1
        '
        Me.VwCompFiniquitoOrdenCompraTypedView1.TableName = "VwCompFiniquitoOrdenCompra"
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
        'OrdenCompraC
        '
        Me.OrdenCompraC.AllowEdit = True
        Me.OrdenCompraC.AllowNew = True
        Me.OrdenCompraC.AllowRemove = True
        Me.OrdenCompraC.MaximoElementosSeleccionados = 1
        Me.OrdenCompraC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.OrdenCompraC.MostrarAlertas = False
        Me.OrdenCompraC.Name = ""
        Me.OrdenCompraC.RaiseListChangedEvents = True
        Me.OrdenCompraC.Transaction = Nothing
        '
        'ComFiniquitoOrdenCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 698)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbSucursal)
        Me.Controls.Add(Me.cmbPlaza)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.MaximizeBox = False
        Me.Name = "ComFiniquitoOrdenCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Finiquito de Ordenes de Compras"
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvDetalleOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgOrdenesCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwCompFiniquitoOrdenCompraTypedView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtIVA As System.Windows.Forms.TextBox
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPlaza As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SucursalC As ClasesNegocio.SucursalCollectionClass
    Friend WithEvents PlazaC As ClasesNegocio.PlazaCollectionClass
    Friend WithEvents OrdenCompraC As ClasesNegocio.OrdenCompraCollectionClass
    Friend WithEvents OrdenCompraDetalleC As ClasesNegocio.OrdenCompraDetalleCollectionClass
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDetalleOrdenCompra As System.Windows.Forms.DataGridView
    Friend WithEvents CodigoProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImproteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCantidadEmitida As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidadSolicitada As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgOrdenesCompra As System.Windows.Forms.DataGridView
    Friend WithEvents VwCompFiniquitoOrdenCompraTypedView1 As IntegraLab.ORM.TypedViewClasses.VwCompFiniquitoOrdenCompraTypedView
    Friend WithEvents FolioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSeleccion As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FolioOrdenCompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SucursalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProveedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AutorizadaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RecibidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubTotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescuentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IvaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrdenadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdOrdenCompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnidadMedidaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCantidadOrdenada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCantRecibida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCosto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDescuento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Importe As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
