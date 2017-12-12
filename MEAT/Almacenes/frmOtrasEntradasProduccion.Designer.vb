<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOtrasEntradasProduccion
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DgvProductos = New System.Windows.Forms.DataGridView
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.ProductosC = New ClasesNegocio.ProductosCollectionsClass
        Me.PiezasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KilosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EsCorteDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.EsProductoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.CanalDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.CapturaInventarioC = New ClasesNegocio.CapturaInventarioCollectionClass
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtObservaciones = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.dtFechaAlta = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtFolio = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.AlmacenC = New ClasesNegocio.AlmacenCollectionClass
        Me.TipoMovimientoC = New ClasesNegocio.TipoMovimientoAlmacenCollectionClass
        Me.txtRecibe = New IntegraLab.Controles.TextBoxMejorado
        Me.txtEntregarA = New IntegraLab.Controles.TextBoxMejorado
        Me.cmbMovimiento = New IntegraLab.Controles.ComboBoxMejorado
        Me.txtCodigoMovimiento = New IntegraLab.Controles.TextBoxMejorado
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmbAlmacen = New IntegraLab.Controles.ComboBoxMejorado
        Me.txtCodigoAlmacen = New IntegraLab.Controles.TextBoxMejorado
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(50, 0)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(857, 29)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "OTRAS ENTRADAS A ALMACÉN"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 579)
        Me.mtb.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DgvProductos)
        Me.GroupBox1.Location = New System.Drawing.Point(55, 233)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(844, 342)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de Entrada :"
        '
        'DgvProductos
        '
        Me.DgvProductos.AllowUserToResizeRows = False
        Me.DgvProductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvProductos.AutoGenerateColumns = False
        Me.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProductoDataGridViewTextBoxColumn, Me.ProductoDataGridViewTextBoxColumn, Me.PiezasDataGridViewTextBoxColumn, Me.KilosDataGridViewTextBoxColumn, Me.Costo, Me.EsCorteDataGridViewCheckBoxColumn, Me.EsProductoDataGridViewCheckBoxColumn, Me.CanalDataGridViewCheckBoxColumn})
        Me.DgvProductos.DataSource = Me.CapturaInventarioC
        Me.DgvProductos.Location = New System.Drawing.Point(6, 19)
        Me.DgvProductos.Name = "DgvProductos"
        Me.DgvProductos.Size = New System.Drawing.Size(832, 317)
        Me.DgvProductos.TabIndex = 0
        '
        'IdProductoDataGridViewTextBoxColumn
        '
        Me.IdProductoDataGridViewTextBoxColumn.DataPropertyName = "IdProducto"
        Me.IdProductoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.IdProductoDataGridViewTextBoxColumn.Name = "IdProductoDataGridViewTextBoxColumn"
        Me.IdProductoDataGridViewTextBoxColumn.Width = 60
        '
        'ProductoDataGridViewTextBoxColumn
        '
        Me.ProductoDataGridViewTextBoxColumn.DataPropertyName = "IdProducto"
        Me.ProductoDataGridViewTextBoxColumn.DataSource = Me.ProductosC
        Me.ProductoDataGridViewTextBoxColumn.DisplayMember = "Descripcion"
        Me.ProductoDataGridViewTextBoxColumn.HeaderText = "Producto"
        Me.ProductoDataGridViewTextBoxColumn.Name = "ProductoDataGridViewTextBoxColumn"
        Me.ProductoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ProductoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ProductoDataGridViewTextBoxColumn.ValueMember = "IdProducto"
        Me.ProductoDataGridViewTextBoxColumn.Width = 300
        '
        'ProductosC
        '
        Me.ProductosC.AllowEdit = True
        Me.ProductosC.AllowNew = True
        Me.ProductosC.AllowRemove = True
        Me.ProductosC.Name = ""
        Me.ProductosC.RaiseListChangedEvents = True
        '
        'PiezasDataGridViewTextBoxColumn
        '
        Me.PiezasDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.PiezasDataGridViewTextBoxColumn.DataPropertyName = "Piezas"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N0"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.PiezasDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.PiezasDataGridViewTextBoxColumn.HeaderText = "Piezas"
        Me.PiezasDataGridViewTextBoxColumn.Name = "PiezasDataGridViewTextBoxColumn"
        Me.PiezasDataGridViewTextBoxColumn.Width = 63
        '
        'KilosDataGridViewTextBoxColumn
        '
        Me.KilosDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.KilosDataGridViewTextBoxColumn.DataPropertyName = "Kilos"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.KilosDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.KilosDataGridViewTextBoxColumn.HeaderText = "Kilos"
        Me.KilosDataGridViewTextBoxColumn.Name = "KilosDataGridViewTextBoxColumn"
        Me.KilosDataGridViewTextBoxColumn.Width = 54
        '
        'Costo
        '
        Me.Costo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Costo.DataPropertyName = "Costo"
        DataGridViewCellStyle9.Format = "C2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.Costo.DefaultCellStyle = DataGridViewCellStyle9
        Me.Costo.HeaderText = "Costo"
        Me.Costo.Name = "Costo"
        Me.Costo.Width = 59
        '
        'EsCorteDataGridViewCheckBoxColumn
        '
        Me.EsCorteDataGridViewCheckBoxColumn.DataPropertyName = "EsCorte"
        Me.EsCorteDataGridViewCheckBoxColumn.HeaderText = "Corte"
        Me.EsCorteDataGridViewCheckBoxColumn.Name = "EsCorteDataGridViewCheckBoxColumn"
        Me.EsCorteDataGridViewCheckBoxColumn.ReadOnly = True
        Me.EsCorteDataGridViewCheckBoxColumn.Width = 60
        '
        'EsProductoDataGridViewCheckBoxColumn
        '
        Me.EsProductoDataGridViewCheckBoxColumn.DataPropertyName = "EsProducto"
        Me.EsProductoDataGridViewCheckBoxColumn.HeaderText = "Producto"
        Me.EsProductoDataGridViewCheckBoxColumn.Name = "EsProductoDataGridViewCheckBoxColumn"
        Me.EsProductoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.EsProductoDataGridViewCheckBoxColumn.Width = 60
        '
        'CanalDataGridViewCheckBoxColumn
        '
        Me.CanalDataGridViewCheckBoxColumn.DataPropertyName = "Canal"
        Me.CanalDataGridViewCheckBoxColumn.HeaderText = "Canal"
        Me.CanalDataGridViewCheckBoxColumn.Name = "CanalDataGridViewCheckBoxColumn"
        Me.CanalDataGridViewCheckBoxColumn.ReadOnly = True
        Me.CanalDataGridViewCheckBoxColumn.Width = 60
        '
        'CapturaInventarioC
        '
        Me.CapturaInventarioC.AllowEdit = True
        Me.CapturaInventarioC.AllowNew = True
        Me.CapturaInventarioC.AllowRemove = True
        Me.CapturaInventarioC.Name = Nothing
        Me.CapturaInventarioC.RaiseListChangedEvents = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Tipo de Movimiento :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Recibe :"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Location = New System.Drawing.Point(164, 168)
        Me.txtObservaciones.MaxLength = 250
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(373, 59)
        Me.txtObservaciones.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Observaciones :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(52, 117)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Entrega :"
        '
        'dtFechaAlta
        '
        Me.dtFechaAlta.Enabled = False
        Me.dtFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaAlta.Location = New System.Drawing.Point(437, 36)
        Me.dtFechaAlta.Name = "dtFechaAlta"
        Me.dtFechaAlta.ShowUpDown = True
        Me.dtFechaAlta.Size = New System.Drawing.Size(100, 20)
        Me.dtFechaAlta.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(374, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Fecha :"
        '
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(164, 36)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.ReadOnly = True
        Me.txtFolio.Size = New System.Drawing.Size(100, 20)
        Me.txtFolio.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Folio :"
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
        'TipoMovimientoC
        '
        Me.TipoMovimientoC.AllowEdit = True
        Me.TipoMovimientoC.AllowNew = True
        Me.TipoMovimientoC.AllowRemove = True
        Me.TipoMovimientoC.Name = ""
        Me.TipoMovimientoC.RaiseListChangedEvents = True
        '
        'txtRecibe
        '
        Me.txtRecibe.ComboBoxEnlazado = Nothing
        Me.txtRecibe.Decimales = 0
        Me.txtRecibe.Location = New System.Drawing.Point(164, 142)
        Me.txtRecibe.MensajeCombo = "Seleccionar un item..."
        Me.txtRecibe.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtRecibe.Name = "txtRecibe"
        Me.txtRecibe.SiguienteControl = Me.txtObservaciones
        Me.txtRecibe.Size = New System.Drawing.Size(373, 20)
        Me.txtRecibe.TabIndex = 15
        Me.txtRecibe.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'txtEntregarA
        '
        Me.txtEntregarA.ComboBoxEnlazado = Nothing
        Me.txtEntregarA.Decimales = 0
        Me.txtEntregarA.Location = New System.Drawing.Point(164, 116)
        Me.txtEntregarA.MensajeCombo = "Seleccionar un item..."
        Me.txtEntregarA.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtEntregarA.Name = "txtEntregarA"
        Me.txtEntregarA.SiguienteControl = Me.txtRecibe
        Me.txtEntregarA.Size = New System.Drawing.Size(373, 20)
        Me.txtEntregarA.TabIndex = 13
        Me.txtEntregarA.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'cmbMovimiento
        '
        Me.cmbMovimiento.DataSource = Me.TipoMovimientoC
        Me.cmbMovimiento.DisplayMember = "Nombre"
        Me.cmbMovimiento.FormattingEnabled = True
        Me.cmbMovimiento.Location = New System.Drawing.Point(224, 89)
        Me.cmbMovimiento.Name = "cmbMovimiento"
        Me.cmbMovimiento.NombreMetodo = Nothing
        Me.cmbMovimiento.Parametros = Nothing
        Me.cmbMovimiento.SiguienteControl = Me.txtEntregarA
        Me.cmbMovimiento.Size = New System.Drawing.Size(313, 21)
        Me.cmbMovimiento.TabIndex = 11
        Me.cmbMovimiento.Tag = "Seleccione un Tipo de Movimiento..."
        Me.cmbMovimiento.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbMovimiento.TextBoxEnlazado = Me.txtCodigoMovimiento
        Me.cmbMovimiento.ValueMember = "Codigo"
        '
        'txtCodigoMovimiento
        '
        Me.txtCodigoMovimiento.ComboBoxEnlazado = Me.cmbMovimiento
        Me.txtCodigoMovimiento.Decimales = 0
        Me.txtCodigoMovimiento.Location = New System.Drawing.Point(164, 89)
        Me.txtCodigoMovimiento.MaxLength = 3000
        Me.txtCodigoMovimiento.MensajeCombo = "Seleccionar un movimiento..."
        Me.txtCodigoMovimiento.MensajeNoExiste = "No existe un movimiento con este código o se encuentra inactivo"
        Me.txtCodigoMovimiento.Name = "txtCodigoMovimiento"
        Me.txtCodigoMovimiento.SiguienteControl = Me.txtEntregarA
        Me.txtCodigoMovimiento.Size = New System.Drawing.Size(54, 20)
        Me.txtCodigoMovimiento.TabIndex = 10
        Me.txtCodigoMovimiento.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdProducto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Piezas"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N0"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn2.HeaderText = "Piezas"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Kilos"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn3.HeaderText = "Kilos"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Costo"
        DataGridViewCellStyle12.Format = "C2"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn4.HeaderText = "Costo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'cmbAlmacen
        '
        Me.cmbAlmacen.DataSource = Me.AlmacenC
        Me.cmbAlmacen.DisplayMember = "Descripcion"
        Me.cmbAlmacen.FormattingEnabled = True
        Me.cmbAlmacen.Location = New System.Drawing.Point(224, 62)
        Me.cmbAlmacen.Name = "cmbAlmacen"
        Me.cmbAlmacen.NombreMetodo = Nothing
        Me.cmbAlmacen.Parametros = Nothing
        Me.cmbAlmacen.SiguienteControl = Me.txtCodigoAlmacen
        Me.cmbAlmacen.Size = New System.Drawing.Size(313, 21)
        Me.cmbAlmacen.TabIndex = 20
        Me.cmbAlmacen.Tag = "Seleccione un Almacén..."
        Me.cmbAlmacen.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbAlmacen.TextBoxEnlazado = Me.txtCodigoAlmacen
        Me.cmbAlmacen.ValueMember = "Codigo"
        '
        'txtCodigoAlmacen
        '
        Me.txtCodigoAlmacen.ComboBoxEnlazado = Me.cmbAlmacen
        Me.txtCodigoAlmacen.Decimales = 0
        Me.txtCodigoAlmacen.Location = New System.Drawing.Point(164, 62)
        Me.txtCodigoAlmacen.MaxLength = 3000
        Me.txtCodigoAlmacen.MensajeCombo = "Seleccionar un Almacén..."
        Me.txtCodigoAlmacen.MensajeNoExiste = "No existe un Almacén con este código o se encuentra inactivo"
        Me.txtCodigoAlmacen.Name = "txtCodigoAlmacen"
        Me.txtCodigoAlmacen.SiguienteControl = Me.txtCodigoMovimiento
        Me.txtCodigoAlmacen.Size = New System.Drawing.Size(54, 20)
        Me.txtCodigoAlmacen.TabIndex = 19
        Me.txtCodigoAlmacen.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Almacen"
        '
        'frmOtrasEntradasProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 579)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbAlmacen)
        Me.Controls.Add(Me.txtCodigoAlmacen)
        Me.Controls.Add(Me.txtRecibe)
        Me.Controls.Add(Me.txtEntregarA)
        Me.Controls.Add(Me.cmbMovimiento)
        Me.Controls.Add(Me.txtCodigoMovimiento)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dtFechaAlta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmOtrasEntradasProduccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Otras Entradas a Almacén"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DgvProductos As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtFechaAlta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CapturaInventarioC As ClasesNegocio.CapturaInventarioCollectionClass
    Friend WithEvents txtCodigoMovimiento As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents cmbMovimiento As Integralab.Controles.ComboBoxMejorado
    Friend WithEvents AlmacenC As ClasesNegocio.AlmacenCollectionClass
    Friend WithEvents TipoMovimientoC As ClasesNegocio.TipoMovimientoAlmacenCollectionClass
    Friend WithEvents ProductosC As ClasesNegocio.ProductosCollectionsClass
    Friend WithEvents txtEntregarA As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtRecibe As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents PiezasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EsCorteDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents EsProductoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CanalDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cmbAlmacen As Integralab.Controles.ComboBoxMejorado
    Friend WithEvents txtCodigoAlmacen As Integralab.Controles.TextBoxMejorado
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
