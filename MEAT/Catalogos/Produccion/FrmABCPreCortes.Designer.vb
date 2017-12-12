<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmABCPreCortes
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
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label17 = New System.Windows.Forms.Label
        Me.dgvProductos = New System.Windows.Forms.DataGridView
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionCortaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ObservacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubProductoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.PreCorteDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.CorteDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.CanalDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DecomisaDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.EnPiezasDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodProdAntDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MaximoPiezasxCajaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreInglesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoBarraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdCuentaContableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CuentaContableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CuentaContableNombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrecioXKiloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PiezasXCabezaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DetallePropRelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ValorAgregadoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.EsMermaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CatProductos = New ClasesNegocio.ProductosCollectionsClass
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtPiezasXCabeza = New Integralab.Controles.TextBoxMejorado
        Me.txtFiltro = New Integralab.Controles.TextBoxMejorado
        Me.txtPrecio = New Integralab.Controles.TextBoxMejorado
        Me.txtNombreIngles = New Integralab.Controles.TextBoxMejorado
        Me.txtDescCorta = New Integralab.Controles.TextBoxMejorado
        Me.txtDescripcion = New Integralab.Controles.TextBoxMejorado
        Me.txtCodigoBarra = New Integralab.Controles.TextBoxMejorado
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
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
        Me.mtb.Size = New System.Drawing.Size(50, 515)
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
        Me.Label17.Size = New System.Drawing.Size(482, 29)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "PRE-CORTES"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.AllowUserToDeleteRows = False
        Me.dgvProductos.AllowUserToResizeRows = False
        Me.dgvProductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProductos.AutoGenerateColumns = False
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProductoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.DescripcionCortaDataGridViewTextBoxColumn, Me.ObservacionesDataGridViewTextBoxColumn, Me.SubProductoDataGridViewCheckBoxColumn, Me.PreCorteDataGridViewCheckBoxColumn, Me.CorteDataGridViewCheckBoxColumn, Me.CanalDataGridViewCheckBoxColumn, Me.DecomisaDataGridViewCheckBoxColumn, Me.EnPiezasDataGridViewCheckBoxColumn, Me.EstatusDataGridViewTextBoxColumn, Me.CodProdAntDataGridViewTextBoxColumn, Me.MaximoPiezasxCajaDataGridViewTextBoxColumn, Me.NombreInglesDataGridViewTextBoxColumn, Me.CodigoBarraDataGridViewTextBoxColumn, Me.CodProductoDataGridViewTextBoxColumn, Me.IdCuentaContableDataGridViewTextBoxColumn, Me.CuentaContableDataGridViewTextBoxColumn, Me.CuentaContableNombreDataGridViewTextBoxColumn, Me.PrecioXKiloDataGridViewTextBoxColumn, Me.PiezasXCabezaDataGridViewTextBoxColumn, Me.DetallePropRelDataGridViewTextBoxColumn, Me.ValorAgregadoDataGridViewCheckBoxColumn, Me.EsMermaDataGridViewTextBoxColumn})
        Me.dgvProductos.DataSource = Me.CatProductos
        Me.dgvProductos.Location = New System.Drawing.Point(6, 48)
        Me.dgvProductos.MultiSelect = False
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = True
        Me.dgvProductos.RowHeadersVisible = False
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.Size = New System.Drawing.Size(444, 256)
        Me.dgvProductos.TabIndex = 8
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
        Me.DescripcionDataGridViewTextBoxColumn.Width = 200
        '
        'DescripcionCortaDataGridViewTextBoxColumn
        '
        Me.DescripcionCortaDataGridViewTextBoxColumn.DataPropertyName = "DescripcionCorta"
        Me.DescripcionCortaDataGridViewTextBoxColumn.HeaderText = "Descripcion Corta"
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Des. Corta :"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(107, 34)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(58, 20)
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblEstatus
        '
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(380, 32)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(152, 24)
        Me.lblEstatus.TabIndex = 2
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Descripción :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Codigo :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(327, 149)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Piezas X Cabeza:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(54, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Precio X Kilo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Nombre en Ingles:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(171, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Código de Barra:"
        '
        'txtPiezasXCabeza
        '
        Me.txtPiezasXCabeza.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPiezasXCabeza.ComboBoxEnlazado = Nothing
        Me.txtPiezasXCabeza.Decimales = 0
        Me.txtPiezasXCabeza.Location = New System.Drawing.Point(423, 146)
        Me.txtPiezasXCabeza.MaxLength = 3000
        Me.txtPiezasXCabeza.MensajeCombo = "Seleccionar un item..."
        Me.txtPiezasXCabeza.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtPiezasXCabeza.Name = "txtPiezasXCabeza"
        Me.txtPiezasXCabeza.SiguienteControl = Me.txtFiltro
        Me.txtPiezasXCabeza.Size = New System.Drawing.Size(81, 20)
        Me.txtPiezasXCabeza.TabIndex = 6
        Me.txtPiezasXCabeza.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPiezasXCabeza.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtPiezasXCabeza.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtPiezasXCabeza.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtFiltro
        '
        Me.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFiltro.ComboBoxEnlazado = Nothing
        Me.txtFiltro.Decimales = 0
        Me.txtFiltro.Location = New System.Drawing.Point(98, 22)
        Me.txtFiltro.MaxLength = 100
        Me.txtFiltro.MensajeCombo = "Seleccionar un item..."
        Me.txtFiltro.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.SiguienteControl = Me.dgvProductos
        Me.txtFiltro.Size = New System.Drawing.Size(264, 20)
        Me.txtFiltro.TabIndex = 7
        Me.txtFiltro.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtFiltro.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtFiltro.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtPrecio
        '
        Me.txtPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrecio.ComboBoxEnlazado = Nothing
        Me.txtPrecio.Decimales = 4
        Me.txtPrecio.Location = New System.Drawing.Point(154, 146)
        Me.txtPrecio.MaxLength = 3000
        Me.txtPrecio.MensajeCombo = "Seleccionar un item..."
        Me.txtPrecio.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.SiguienteControl = Me.txtPiezasXCabeza
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 5
        Me.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPrecio.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.[Decimal]
        Me.txtPrecio.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtPrecio.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtNombreIngles
        '
        Me.txtNombreIngles.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreIngles.ComboBoxEnlazado = Nothing
        Me.txtNombreIngles.Decimales = 0
        Me.txtNombreIngles.Location = New System.Drawing.Point(154, 120)
        Me.txtNombreIngles.MaxLength = 100
        Me.txtNombreIngles.MensajeCombo = "Seleccionar un item..."
        Me.txtNombreIngles.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtNombreIngles.Name = "txtNombreIngles"
        Me.txtNombreIngles.SiguienteControl = Me.txtPrecio
        Me.txtNombreIngles.Size = New System.Drawing.Size(350, 20)
        Me.txtNombreIngles.TabIndex = 4
        Me.txtNombreIngles.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtNombreIngles.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtNombreIngles.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtDescCorta
        '
        Me.txtDescCorta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescCorta.ComboBoxEnlazado = Nothing
        Me.txtDescCorta.Decimales = 0
        Me.txtDescCorta.Location = New System.Drawing.Point(154, 94)
        Me.txtDescCorta.MaxLength = 30
        Me.txtDescCorta.MensajeCombo = "Seleccionar un item..."
        Me.txtDescCorta.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtDescCorta.Name = "txtDescCorta"
        Me.txtDescCorta.SiguienteControl = Me.txtNombreIngles
        Me.txtDescCorta.Size = New System.Drawing.Size(100, 20)
        Me.txtDescCorta.TabIndex = 3
        Me.txtDescCorta.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtDescCorta.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtDescCorta.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.ComboBoxEnlazado = Nothing
        Me.txtDescripcion.Decimales = 0
        Me.txtDescripcion.Location = New System.Drawing.Point(154, 69)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.MensajeCombo = "Seleccionar un item..."
        Me.txtDescripcion.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.SiguienteControl = Me.txtDescCorta
        Me.txtDescripcion.Size = New System.Drawing.Size(350, 20)
        Me.txtDescripcion.TabIndex = 2
        Me.txtDescripcion.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtDescripcion.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtDescripcion.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtCodigoBarra
        '
        Me.txtCodigoBarra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoBarra.ComboBoxEnlazado = Nothing
        Me.txtCodigoBarra.Decimales = 0
        Me.txtCodigoBarra.Location = New System.Drawing.Point(263, 34)
        Me.txtCodigoBarra.MaxLength = 50
        Me.txtCodigoBarra.MensajeCombo = "Seleccionar un item..."
        Me.txtCodigoBarra.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtCodigoBarra.Name = "txtCodigoBarra"
        Me.txtCodigoBarra.SiguienteControl = Me.txtDescripcion
        Me.txtCodigoBarra.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigoBarra.TabIndex = 1
        Me.txtCodigoBarra.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtCodigoBarra.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCodigoBarra.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdProducto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdProducto"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DescripcionCorta"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DescripcionCorta"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Observaciones"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Estatus"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Estatus"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CodProdAnt"
        Me.DataGridViewTextBoxColumn6.HeaderText = "CodProdAnt"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "MaximoPiezasxCaja"
        Me.DataGridViewTextBoxColumn7.HeaderText = "MaximoPiezasxCaja"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "NombreIngles"
        Me.DataGridViewTextBoxColumn8.HeaderText = "NombreIngles"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "CodigoBarra"
        Me.DataGridViewTextBoxColumn9.HeaderText = "CodigoBarra"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "IdCeuntaContable"
        Me.DataGridViewTextBoxColumn10.HeaderText = "IdCeuntaContable"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "PrecioXkilo"
        Me.DataGridViewTextBoxColumn11.HeaderText = "PrecioXkilo"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "PiezasXcabeza"
        Me.DataGridViewTextBoxColumn12.HeaderText = "PiezasXcabeza"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "KilosMaximo"
        Me.DataGridViewTextBoxColumn13.HeaderText = "KilosMaximo"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "KilosMinimo"
        Me.DataGridViewTextBoxColumn14.HeaderText = "KilosMinimo"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtFiltro)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dgvProductos)
        Me.GroupBox1.Location = New System.Drawing.Point(57, 187)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(462, 323)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Precortes"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Descripción :"
        '
        'FrmABCPreCortes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 515)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtPiezasXCabeza)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtNombreIngles)
        Me.Controls.Add(Me.txtDescCorta)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtCodigoBarra)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblEstatus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmABCPreCortes"
        Me.Text = "Pre-Cortes"
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CtaMayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubCtaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SsbCtaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SssCtaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoBarra As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtDescripcion As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtDescCorta As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtNombreIngles As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtPiezasXCabeza As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtPrecio As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As Integralab.Controles.TextBoxMejorado
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
