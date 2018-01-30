<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmABCCortes
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
        Me.mtb = New MEAToolBar.MEAToolBar()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionCortaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubProductoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PreCorteDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CorteDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CanalDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DecomisaDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EnPiezasDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodProdAntDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaximoPiezasxCajaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreInglesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoBarraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCuentaContableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuentaContableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuentaContableNombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioXKiloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PiezasXCabezaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetallePropRelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorAgregadoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EsMermaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CatProductos = New ClasesNegocio.ProductosCollectionsClass()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblEstatus = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodigoBarra = New IntegraLab.Controles.TextBoxMejorado()
        Me.txtDescripcion = New IntegraLab.Controles.TextBoxMejorado()
        Me.txtDescCorta = New IntegraLab.Controles.TextBoxMejorado()
        Me.txtMaximoPiezasxCaja = New IntegraLab.Controles.TextBoxMejorado()
        Me.txtNombreIngles = New IntegraLab.Controles.TextBoxMejorado()
        Me.txtCodigoPrecorte = New IntegraLab.Controles.TextBoxMejorado()
        Me.cmbPreCortes = New IntegraLab.Controles.ComboBoxMejorado()
        Me.txtPrecio = New IntegraLab.Controles.TextBoxMejorado()
        Me.txtPiezasXCabeza = New IntegraLab.Controles.TextBoxMejorado()
        Me.chkHueso = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtFiltro = New IntegraLab.Controles.TextBoxMejorado()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbProdSAT = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.mtb.MostrarBorrar = True
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = True
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 545)
        Me.mtb.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(525, 29)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "CORTES"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.AllowUserToDeleteRows = False
        Me.dgvProductos.AllowUserToResizeRows = False
        Me.dgvProductos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvProductos.AutoGenerateColumns = False
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProductoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.DescripcionCortaDataGridViewTextBoxColumn, Me.ObservacionesDataGridViewTextBoxColumn, Me.SubProductoDataGridViewCheckBoxColumn, Me.PreCorteDataGridViewCheckBoxColumn, Me.CorteDataGridViewCheckBoxColumn, Me.CanalDataGridViewCheckBoxColumn, Me.DecomisaDataGridViewCheckBoxColumn, Me.EnPiezasDataGridViewCheckBoxColumn, Me.EstatusDataGridViewTextBoxColumn, Me.CodProdAntDataGridViewTextBoxColumn, Me.MaximoPiezasxCajaDataGridViewTextBoxColumn, Me.NombreInglesDataGridViewTextBoxColumn, Me.CodigoBarraDataGridViewTextBoxColumn, Me.CodProductoDataGridViewTextBoxColumn, Me.IdCuentaContableDataGridViewTextBoxColumn, Me.CuentaContableDataGridViewTextBoxColumn, Me.CuentaContableNombreDataGridViewTextBoxColumn, Me.PrecioXKiloDataGridViewTextBoxColumn, Me.PiezasXCabezaDataGridViewTextBoxColumn, Me.DetallePropRelDataGridViewTextBoxColumn, Me.ValorAgregadoDataGridViewCheckBoxColumn, Me.EsMermaDataGridViewTextBoxColumn})
        Me.dgvProductos.DataSource = Me.CatProductos
        Me.dgvProductos.Location = New System.Drawing.Point(6, 62)
        Me.dgvProductos.MultiSelect = False
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = True
        Me.dgvProductos.RowHeadersVisible = False
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.Size = New System.Drawing.Size(492, 188)
        Me.dgvProductos.TabIndex = 12
        '
        'IdProductoDataGridViewTextBoxColumn
        '
        Me.IdProductoDataGridViewTextBoxColumn.DataPropertyName = "IdProducto"
        Me.IdProductoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.IdProductoDataGridViewTextBoxColumn.Name = "IdProductoDataGridViewTextBoxColumn"
        Me.IdProductoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdProductoDataGridViewTextBoxColumn.Width = 50
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 240
        '
        'DescripcionCortaDataGridViewTextBoxColumn
        '
        Me.DescripcionCortaDataGridViewTextBoxColumn.DataPropertyName = "DescripcionCorta"
        Me.DescripcionCortaDataGridViewTextBoxColumn.HeaderText = "Desc Corta"
        Me.DescripcionCortaDataGridViewTextBoxColumn.Name = "DescripcionCortaDataGridViewTextBoxColumn"
        Me.DescripcionCortaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ObservacionesDataGridViewTextBoxColumn
        '
        Me.ObservacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.Name = "ObservacionesDataGridViewTextBoxColumn"
        Me.ObservacionesDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObservacionesDataGridViewTextBoxColumn.Visible = False
        '
        'SubProductoDataGridViewCheckBoxColumn
        '
        Me.SubProductoDataGridViewCheckBoxColumn.DataPropertyName = "SubProducto"
        Me.SubProductoDataGridViewCheckBoxColumn.HeaderText = "SubProducto"
        Me.SubProductoDataGridViewCheckBoxColumn.Name = "SubProductoDataGridViewCheckBoxColumn"
        Me.SubProductoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.SubProductoDataGridViewCheckBoxColumn.Visible = False
        '
        'PreCorteDataGridViewCheckBoxColumn
        '
        Me.PreCorteDataGridViewCheckBoxColumn.DataPropertyName = "PreCorte"
        Me.PreCorteDataGridViewCheckBoxColumn.HeaderText = "PreCorte"
        Me.PreCorteDataGridViewCheckBoxColumn.Name = "PreCorteDataGridViewCheckBoxColumn"
        Me.PreCorteDataGridViewCheckBoxColumn.ReadOnly = True
        Me.PreCorteDataGridViewCheckBoxColumn.Visible = False
        '
        'CorteDataGridViewCheckBoxColumn
        '
        Me.CorteDataGridViewCheckBoxColumn.DataPropertyName = "Corte"
        Me.CorteDataGridViewCheckBoxColumn.HeaderText = "Corte"
        Me.CorteDataGridViewCheckBoxColumn.Name = "CorteDataGridViewCheckBoxColumn"
        Me.CorteDataGridViewCheckBoxColumn.ReadOnly = True
        Me.CorteDataGridViewCheckBoxColumn.Visible = False
        '
        'CanalDataGridViewCheckBoxColumn
        '
        Me.CanalDataGridViewCheckBoxColumn.DataPropertyName = "Canal"
        Me.CanalDataGridViewCheckBoxColumn.HeaderText = "Canal"
        Me.CanalDataGridViewCheckBoxColumn.Name = "CanalDataGridViewCheckBoxColumn"
        Me.CanalDataGridViewCheckBoxColumn.ReadOnly = True
        Me.CanalDataGridViewCheckBoxColumn.Visible = False
        '
        'DecomisaDataGridViewCheckBoxColumn
        '
        Me.DecomisaDataGridViewCheckBoxColumn.DataPropertyName = "Decomisa"
        Me.DecomisaDataGridViewCheckBoxColumn.HeaderText = "Decomisa"
        Me.DecomisaDataGridViewCheckBoxColumn.Name = "DecomisaDataGridViewCheckBoxColumn"
        Me.DecomisaDataGridViewCheckBoxColumn.ReadOnly = True
        Me.DecomisaDataGridViewCheckBoxColumn.Visible = False
        '
        'EnPiezasDataGridViewCheckBoxColumn
        '
        Me.EnPiezasDataGridViewCheckBoxColumn.DataPropertyName = "EnPiezas"
        Me.EnPiezasDataGridViewCheckBoxColumn.HeaderText = "EnPiezas"
        Me.EnPiezasDataGridViewCheckBoxColumn.Name = "EnPiezasDataGridViewCheckBoxColumn"
        Me.EnPiezasDataGridViewCheckBoxColumn.ReadOnly = True
        Me.EnPiezasDataGridViewCheckBoxColumn.Visible = False
        '
        'EstatusDataGridViewTextBoxColumn
        '
        Me.EstatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.HeaderText = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.Name = "EstatusDataGridViewTextBoxColumn"
        Me.EstatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodProdAntDataGridViewTextBoxColumn
        '
        Me.CodProdAntDataGridViewTextBoxColumn.DataPropertyName = "CodProdAnt"
        Me.CodProdAntDataGridViewTextBoxColumn.HeaderText = "CodProdAnt"
        Me.CodProdAntDataGridViewTextBoxColumn.Name = "CodProdAntDataGridViewTextBoxColumn"
        Me.CodProdAntDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodProdAntDataGridViewTextBoxColumn.Visible = False
        '
        'MaximoPiezasxCajaDataGridViewTextBoxColumn
        '
        Me.MaximoPiezasxCajaDataGridViewTextBoxColumn.DataPropertyName = "MaximoPiezasxCaja"
        Me.MaximoPiezasxCajaDataGridViewTextBoxColumn.HeaderText = "MaximoPiezasxCaja"
        Me.MaximoPiezasxCajaDataGridViewTextBoxColumn.Name = "MaximoPiezasxCajaDataGridViewTextBoxColumn"
        Me.MaximoPiezasxCajaDataGridViewTextBoxColumn.ReadOnly = True
        Me.MaximoPiezasxCajaDataGridViewTextBoxColumn.Visible = False
        '
        'NombreInglesDataGridViewTextBoxColumn
        '
        Me.NombreInglesDataGridViewTextBoxColumn.DataPropertyName = "NombreIngles"
        Me.NombreInglesDataGridViewTextBoxColumn.HeaderText = "NombreIngles"
        Me.NombreInglesDataGridViewTextBoxColumn.Name = "NombreInglesDataGridViewTextBoxColumn"
        Me.NombreInglesDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreInglesDataGridViewTextBoxColumn.Visible = False
        '
        'CodigoBarraDataGridViewTextBoxColumn
        '
        Me.CodigoBarraDataGridViewTextBoxColumn.DataPropertyName = "CodigoBarra"
        Me.CodigoBarraDataGridViewTextBoxColumn.HeaderText = "CodigoBarra"
        Me.CodigoBarraDataGridViewTextBoxColumn.Name = "CodigoBarraDataGridViewTextBoxColumn"
        Me.CodigoBarraDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoBarraDataGridViewTextBoxColumn.Visible = False
        '
        'CodProductoDataGridViewTextBoxColumn
        '
        Me.CodProductoDataGridViewTextBoxColumn.DataPropertyName = "CodProducto"
        Me.CodProductoDataGridViewTextBoxColumn.HeaderText = "CodProducto"
        Me.CodProductoDataGridViewTextBoxColumn.Name = "CodProductoDataGridViewTextBoxColumn"
        Me.CodProductoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodProductoDataGridViewTextBoxColumn.Visible = False
        '
        'IdCuentaContableDataGridViewTextBoxColumn
        '
        Me.IdCuentaContableDataGridViewTextBoxColumn.DataPropertyName = "IdCuentaContable"
        Me.IdCuentaContableDataGridViewTextBoxColumn.HeaderText = "IdCuentaContable"
        Me.IdCuentaContableDataGridViewTextBoxColumn.Name = "IdCuentaContableDataGridViewTextBoxColumn"
        Me.IdCuentaContableDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCuentaContableDataGridViewTextBoxColumn.Visible = False
        '
        'CuentaContableDataGridViewTextBoxColumn
        '
        Me.CuentaContableDataGridViewTextBoxColumn.DataPropertyName = "CuentaContable"
        Me.CuentaContableDataGridViewTextBoxColumn.HeaderText = "CuentaContable"
        Me.CuentaContableDataGridViewTextBoxColumn.Name = "CuentaContableDataGridViewTextBoxColumn"
        Me.CuentaContableDataGridViewTextBoxColumn.ReadOnly = True
        Me.CuentaContableDataGridViewTextBoxColumn.Visible = False
        '
        'CuentaContableNombreDataGridViewTextBoxColumn
        '
        Me.CuentaContableNombreDataGridViewTextBoxColumn.DataPropertyName = "CuentaContableNombre"
        Me.CuentaContableNombreDataGridViewTextBoxColumn.HeaderText = "CuentaContableNombre"
        Me.CuentaContableNombreDataGridViewTextBoxColumn.Name = "CuentaContableNombreDataGridViewTextBoxColumn"
        Me.CuentaContableNombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.CuentaContableNombreDataGridViewTextBoxColumn.Visible = False
        '
        'PrecioXKiloDataGridViewTextBoxColumn
        '
        Me.PrecioXKiloDataGridViewTextBoxColumn.DataPropertyName = "PrecioXKilo"
        Me.PrecioXKiloDataGridViewTextBoxColumn.HeaderText = "PrecioXKilo"
        Me.PrecioXKiloDataGridViewTextBoxColumn.Name = "PrecioXKiloDataGridViewTextBoxColumn"
        Me.PrecioXKiloDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioXKiloDataGridViewTextBoxColumn.Visible = False
        '
        'PiezasXCabezaDataGridViewTextBoxColumn
        '
        Me.PiezasXCabezaDataGridViewTextBoxColumn.DataPropertyName = "PiezasXCabeza"
        Me.PiezasXCabezaDataGridViewTextBoxColumn.HeaderText = "PiezasXCabeza"
        Me.PiezasXCabezaDataGridViewTextBoxColumn.Name = "PiezasXCabezaDataGridViewTextBoxColumn"
        Me.PiezasXCabezaDataGridViewTextBoxColumn.ReadOnly = True
        Me.PiezasXCabezaDataGridViewTextBoxColumn.Visible = False
        '
        'DetallePropRelDataGridViewTextBoxColumn
        '
        Me.DetallePropRelDataGridViewTextBoxColumn.DataPropertyName = "DetallePropRel"
        Me.DetallePropRelDataGridViewTextBoxColumn.HeaderText = "DetallePropRel"
        Me.DetallePropRelDataGridViewTextBoxColumn.Name = "DetallePropRelDataGridViewTextBoxColumn"
        Me.DetallePropRelDataGridViewTextBoxColumn.ReadOnly = True
        Me.DetallePropRelDataGridViewTextBoxColumn.Visible = False
        '
        'ValorAgregadoDataGridViewCheckBoxColumn
        '
        Me.ValorAgregadoDataGridViewCheckBoxColumn.DataPropertyName = "ValorAgregado"
        Me.ValorAgregadoDataGridViewCheckBoxColumn.HeaderText = "ValorAgregado"
        Me.ValorAgregadoDataGridViewCheckBoxColumn.Name = "ValorAgregadoDataGridViewCheckBoxColumn"
        Me.ValorAgregadoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ValorAgregadoDataGridViewCheckBoxColumn.Visible = False
        '
        'EsMermaDataGridViewTextBoxColumn
        '
        Me.EsMermaDataGridViewTextBoxColumn.DataPropertyName = "EsMerma"
        Me.EsMermaDataGridViewTextBoxColumn.HeaderText = "EsMerma"
        Me.EsMermaDataGridViewTextBoxColumn.Name = "EsMermaDataGridViewTextBoxColumn"
        Me.EsMermaDataGridViewTextBoxColumn.ReadOnly = True
        Me.EsMermaDataGridViewTextBoxColumn.Visible = False
        '
        'CatProductos
        '
        Me.CatProductos.AllowEdit = True
        Me.CatProductos.AllowNew = True
        Me.CatProductos.AllowRemove = True
        Me.CatProductos.MaximoElementosSeleccionados = 1
        Me.CatProductos.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.CatProductos.MostrarAlertas = False
        Me.CatProductos.Name = ""
        Me.CatProductos.RaiseListChangedEvents = True
        Me.CatProductos.Transaction = Nothing
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(340, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Maximo Piezas x Caja :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(272, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Codigo Barra :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(62, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Pre Corte :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Nombre en Ingles :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Des. Corta :"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(164, 70)
        Me.txtCodigo.MaxLength = 6
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(58, 20)
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblEstatus
        '
        Me.lblEstatus.AutoSize = True
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(401, 36)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(104, 24)
        Me.lblEstatus.TabIndex = 2
        Me.lblEstatus.Text = "ESTATUS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Descripción :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Codigo :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(291, 236)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Piezas X Cabeza:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Precio X Kilo:"
        '
        'txtCodigoBarra
        '
        Me.txtCodigoBarra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoBarra.ComboBoxEnlazado = Nothing
        Me.txtCodigoBarra.Decimales = 0
        Me.txtCodigoBarra.Location = New System.Drawing.Point(349, 70)
        Me.txtCodigoBarra.MaxLength = 50
        Me.txtCodigoBarra.MensajeCombo = "Seleccionar un item..."
        Me.txtCodigoBarra.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtCodigoBarra.Name = "txtCodigoBarra"
        Me.txtCodigoBarra.SiguienteControl = Me.txtDescripcion
        Me.txtCodigoBarra.Size = New System.Drawing.Size(156, 20)
        Me.txtCodigoBarra.TabIndex = 1
        Me.txtCodigoBarra.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtCodigoBarra.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCodigoBarra.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.ComboBoxEnlazado = Nothing
        Me.txtDescripcion.Decimales = 0
        Me.txtDescripcion.Location = New System.Drawing.Point(164, 96)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.MensajeCombo = "Seleccionar un item..."
        Me.txtDescripcion.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.SiguienteControl = Me.txtDescCorta
        Me.txtDescripcion.Size = New System.Drawing.Size(397, 20)
        Me.txtDescripcion.TabIndex = 2
        Me.txtDescripcion.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtDescripcion.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtDescripcion.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtDescCorta
        '
        Me.txtDescCorta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescCorta.ComboBoxEnlazado = Nothing
        Me.txtDescCorta.Decimales = 0
        Me.txtDescCorta.Location = New System.Drawing.Point(164, 122)
        Me.txtDescCorta.MaxLength = 30
        Me.txtDescCorta.MensajeCombo = "Seleccionar un item..."
        Me.txtDescCorta.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtDescCorta.Name = "txtDescCorta"
        Me.txtDescCorta.SiguienteControl = Me.txtMaximoPiezasxCaja
        Me.txtDescCorta.Size = New System.Drawing.Size(170, 20)
        Me.txtDescCorta.TabIndex = 3
        Me.txtDescCorta.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtDescCorta.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtDescCorta.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtMaximoPiezasxCaja
        '
        Me.txtMaximoPiezasxCaja.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMaximoPiezasxCaja.ComboBoxEnlazado = Nothing
        Me.txtMaximoPiezasxCaja.Decimales = 0
        Me.txtMaximoPiezasxCaja.Location = New System.Drawing.Point(461, 122)
        Me.txtMaximoPiezasxCaja.MaxLength = 3000
        Me.txtMaximoPiezasxCaja.MensajeCombo = "Seleccionar un item..."
        Me.txtMaximoPiezasxCaja.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtMaximoPiezasxCaja.Name = "txtMaximoPiezasxCaja"
        Me.txtMaximoPiezasxCaja.SiguienteControl = Me.txtNombreIngles
        Me.txtMaximoPiezasxCaja.Size = New System.Drawing.Size(100, 20)
        Me.txtMaximoPiezasxCaja.TabIndex = 4
        Me.txtMaximoPiezasxCaja.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtMaximoPiezasxCaja.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtMaximoPiezasxCaja.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtNombreIngles
        '
        Me.txtNombreIngles.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreIngles.ComboBoxEnlazado = Nothing
        Me.txtNombreIngles.Decimales = 0
        Me.txtNombreIngles.Location = New System.Drawing.Point(164, 149)
        Me.txtNombreIngles.MensajeCombo = "Seleccionar un item..."
        Me.txtNombreIngles.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtNombreIngles.Name = "txtNombreIngles"
        Me.txtNombreIngles.SiguienteControl = Me.txtCodigoPrecorte
        Me.txtNombreIngles.Size = New System.Drawing.Size(397, 20)
        Me.txtNombreIngles.TabIndex = 5
        Me.txtNombreIngles.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtNombreIngles.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtNombreIngles.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtCodigoPrecorte
        '
        Me.txtCodigoPrecorte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoPrecorte.ComboBoxEnlazado = Me.cmbPreCortes
        Me.txtCodigoPrecorte.Decimales = 0
        Me.txtCodigoPrecorte.Location = New System.Drawing.Point(164, 203)
        Me.txtCodigoPrecorte.MaxLength = 3000
        Me.txtCodigoPrecorte.MensajeCombo = "Seleccionar un Precorte"
        Me.txtCodigoPrecorte.MensajeNoExiste = "No existe un Precorte con este código o se encuentra inactivo"
        Me.txtCodigoPrecorte.Name = "txtCodigoPrecorte"
        Me.txtCodigoPrecorte.SiguienteControl = Me.txtPrecio
        Me.txtCodigoPrecorte.Size = New System.Drawing.Size(60, 20)
        Me.txtCodigoPrecorte.TabIndex = 6
        Me.txtCodigoPrecorte.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtCodigoPrecorte.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCodigoPrecorte.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cmbPreCortes
        '
        Me.cmbPreCortes.FormattingEnabled = True
        Me.cmbPreCortes.Location = New System.Drawing.Point(230, 203)
        Me.cmbPreCortes.Name = "cmbPreCortes"
        Me.cmbPreCortes.NombreMetodo = Nothing
        Me.cmbPreCortes.Parametros = Nothing
        Me.cmbPreCortes.SiguienteControl = Me.txtPrecio
        Me.cmbPreCortes.Size = New System.Drawing.Size(275, 21)
        Me.cmbPreCortes.TabIndex = 7
        Me.cmbPreCortes.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbPreCortes.TextBoxEnlazado = Me.txtCodigoPrecorte
        '
        'txtPrecio
        '
        Me.txtPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrecio.ComboBoxEnlazado = Nothing
        Me.txtPrecio.Decimales = 4
        Me.txtPrecio.Location = New System.Drawing.Point(164, 232)
        Me.txtPrecio.MaxLength = 3000
        Me.txtPrecio.MensajeCombo = "Seleccionar un item..."
        Me.txtPrecio.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.SiguienteControl = Me.txtPiezasXCabeza
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 8
        Me.txtPrecio.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.[Decimal]
        Me.txtPrecio.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtPrecio.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtPiezasXCabeza
        '
        Me.txtPiezasXCabeza.ComboBoxEnlazado = Nothing
        Me.txtPiezasXCabeza.Decimales = 0
        Me.txtPiezasXCabeza.Location = New System.Drawing.Point(392, 232)
        Me.txtPiezasXCabeza.MaxLength = 3000
        Me.txtPiezasXCabeza.MensajeCombo = "Seleccionar un item..."
        Me.txtPiezasXCabeza.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtPiezasXCabeza.Name = "txtPiezasXCabeza"
        Me.txtPiezasXCabeza.SiguienteControl = Me.chkHueso
        Me.txtPiezasXCabeza.Size = New System.Drawing.Size(100, 20)
        Me.txtPiezasXCabeza.TabIndex = 9
        Me.txtPiezasXCabeza.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtPiezasXCabeza.ValorMaximo = New Decimal(New Integer() {99, 0, 0, 0})
        Me.txtPiezasXCabeza.ValorMinimo = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'chkHueso
        '
        Me.chkHueso.AutoSize = True
        Me.chkHueso.Location = New System.Drawing.Point(504, 234)
        Me.chkHueso.Name = "chkHueso"
        Me.chkHueso.Size = New System.Drawing.Size(57, 17)
        Me.chkHueso.TabIndex = 10
        Me.chkHueso.Text = "Hueso"
        Me.chkHueso.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtFiltro)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.dgvProductos)
        Me.GroupBox1.Location = New System.Drawing.Point(59, 277)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(504, 256)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cortes Regitrados"
        '
        'txtFiltro
        '
        Me.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFiltro.ComboBoxEnlazado = Nothing
        Me.txtFiltro.Decimales = 0
        Me.txtFiltro.Location = New System.Drawing.Point(101, 23)
        Me.txtFiltro.MaxLength = 100
        Me.txtFiltro.MensajeCombo = "Seleccionar un item..."
        Me.txtFiltro.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.SiguienteControl = Me.dgvProductos
        Me.txtFiltro.Size = New System.Drawing.Size(317, 20)
        Me.txtFiltro.TabIndex = 11
        Me.txtFiltro.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtFiltro.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtFiltro.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Descripción :"
        '
        'cmbProdSAT
        '
        Me.cmbProdSAT.FormattingEnabled = True
        Me.cmbProdSAT.Location = New System.Drawing.Point(164, 175)
        Me.cmbProdSAT.Name = "cmbProdSAT"
        Me.cmbProdSAT.Size = New System.Drawing.Size(121, 21)
        Me.cmbProdSAT.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(63, 178)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 13)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Productos SAT"
        '
        'FrmABCCortes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 545)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmbProdSAT)
        Me.Controls.Add(Me.chkHueso)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtPiezasXCabeza)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.cmbPreCortes)
        Me.Controls.Add(Me.txtCodigoPrecorte)
        Me.Controls.Add(Me.txtNombreIngles)
        Me.Controls.Add(Me.txtDescCorta)
        Me.Controls.Add(Me.txtMaximoPiezasxCaja)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtCodigoBarra)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblEstatus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmABCCortes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cortes"
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dgvProductos As System.Windows.Forms.DataGridView
    Friend WithEvents CatProductos As ClasesNegocio.ProductosCollectionsClass
    Friend WithEvents CtaMayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubCtaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SsbCtaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SssCtaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoBarra As Integralab.Controles.TextBoxMejorado
    Friend WithEvents txtDescripcion As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtMaximoPiezasxCaja As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtDescCorta As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtNombreIngles As Integralab.Controles.TextBoxMejorado
    Friend WithEvents txtCodigoPrecorte As Integralab.Controles.TextBoxMejorado
    Friend WithEvents cmbPreCortes As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents txtPrecio As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtPiezasXCabeza As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents IdProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionCortaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubProductoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PreCorteDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CorteDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CanalDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DecomisaDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents EnPiezasDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodProdAntDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaximoPiezasxCajaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreInglesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoBarraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdCuentaContableDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CuentaContableDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CuentaContableNombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioXKiloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PiezasXCabezaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DetallePropRelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorAgregadoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents EsMermaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkHueso As System.Windows.Forms.CheckBox
    Friend WithEvents cmbProdSAT As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
