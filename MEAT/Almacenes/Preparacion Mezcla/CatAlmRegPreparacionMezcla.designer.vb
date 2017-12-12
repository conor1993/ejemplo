<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CatAlmRegPreparacionMezcla
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
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label17 = New System.Windows.Forms.Label
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.TxtObservaciones = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtTotal = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.dgIngredientes = New System.Windows.Forms.DataGridView
        Me.ProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PorcentajeMezclaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KilogramosMezclaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadDisponible = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KilogramosSalidaMezclaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostoUnitarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmImporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FolioPreparacionMezclaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdPlazaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PlazaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PreparacionMezclaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EntidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SeleccionadoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ContenedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IndiceEnContenedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ingredientes = New ClasesNegocio.IngredienteCollection
        Me.TxtFolioPreparacion = New System.Windows.Forms.TextBox
        Me.TxtUnidad = New System.Windows.Forms.TextBox
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker
        Me.CmbEnvase = New System.Windows.Forms.ComboBox
        Me.Envases = New ClasesNegocio.ProductoCollectionClass
        Me.CmbMezcla = New System.Windows.Forms.ComboBox
        Me.Mezclas = New ClasesNegocio.ProductoCollectionClass
        Me.CmbAlmacen = New System.Windows.Forms.ComboBox
        Me.Almacenes = New ClasesNegocio.AlmacenCollectionClass
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmbPlaza = New System.Windows.Forms.ComboBox
        Me.Plazas = New ClasesNegocio.PlazaCollectionClass
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCantidadEnvases = New Integralab.Controles.TextBoxMejorado
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtCantidadPreparar = New Integralab.Controles.TextBoxMejorado
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtCantidadRealPreparada = New Integralab.Controles.TextBoxMejorado
        Me.dtFechaCaducidad = New System.Windows.Forms.DateTimePicker
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtLote = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgIngredientes, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 571)
        Me.mtb.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.MaximumSize = New System.Drawing.Size(1600, 900)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(833, 29)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "REGISTRO DE PREPARACION DE FORMULAS"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEstatus
        '
        Me.lblEstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Latha", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(728, 32)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(143, 25)
        Me.lblEstatus.TabIndex = 68
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtObservaciones.Location = New System.Drawing.Point(145, 492)
        Me.TxtObservaciones.MaxLength = 250
        Me.TxtObservaciones.Multiline = True
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtObservaciones.Size = New System.Drawing.Size(406, 67)
        Me.TxtObservaciones.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(58, 495)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 13)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "Observaciones:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TxtTotal)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.dgIngredientes)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(61, 195)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(810, 291)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de Paquetes"
        '
        'TxtTotal
        '
        Me.TxtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.ForeColor = System.Drawing.Color.Red
        Me.TxtTotal.Location = New System.Drawing.Point(663, 263)
        Me.TxtTotal.MaxLength = 10
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(141, 22)
        Me.TxtTotal.TabIndex = 1
        Me.TxtTotal.Text = "0"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(623, 268)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "Total:"
        '
        'dgIngredientes
        '
        Me.dgIngredientes.AllowUserToAddRows = False
        Me.dgIngredientes.AllowUserToDeleteRows = False
        Me.dgIngredientes.AllowUserToResizeRows = False
        Me.dgIngredientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgIngredientes.AutoGenerateColumns = False
        Me.dgIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgIngredientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductoDataGridViewTextBoxColumn, Me.PorcentajeMezclaDataGridViewTextBoxColumn, Me.KilogramosMezclaDataGridViewTextBoxColumn, Me.CantidadDisponible, Me.KilogramosSalidaMezclaDataGridViewTextBoxColumn, Me.CostoUnitarioDataGridViewTextBoxColumn, Me.clmImporte, Me.FolioPreparacionMezclaDataGridViewTextBoxColumn, Me.IdProductoDataGridViewTextBoxColumn, Me.IdPlazaDataGridViewTextBoxColumn, Me.PlazaDataGridViewTextBoxColumn, Me.PreparacionMezclaDataGridViewTextBoxColumn, Me.EntidadDataGridViewTextBoxColumn, Me.SeleccionadoDataGridViewCheckBoxColumn, Me.ContenedorDataGridViewTextBoxColumn, Me.IndiceEnContenedorDataGridViewTextBoxColumn})
        Me.dgIngredientes.DataSource = Me.Ingredientes
        Me.dgIngredientes.Location = New System.Drawing.Point(6, 32)
        Me.dgIngredientes.Name = "dgIngredientes"
        Me.dgIngredientes.RowHeadersVisible = False
        Me.dgIngredientes.Size = New System.Drawing.Size(798, 225)
        Me.dgIngredientes.TabIndex = 0
        '
        'ProductoDataGridViewTextBoxColumn
        '
        Me.ProductoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ProductoDataGridViewTextBoxColumn.DataPropertyName = "Producto"
        Me.ProductoDataGridViewTextBoxColumn.HeaderText = "Ingrediente"
        Me.ProductoDataGridViewTextBoxColumn.Name = "ProductoDataGridViewTextBoxColumn"
        Me.ProductoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductoDataGridViewTextBoxColumn.Width = 85
        '
        'PorcentajeMezclaDataGridViewTextBoxColumn
        '
        Me.PorcentajeMezclaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.PorcentajeMezclaDataGridViewTextBoxColumn.DataPropertyName = "PorcentajeMezcla"
        Me.PorcentajeMezclaDataGridViewTextBoxColumn.HeaderText = "% Ingrediente"
        Me.PorcentajeMezclaDataGridViewTextBoxColumn.Name = "PorcentajeMezclaDataGridViewTextBoxColumn"
        Me.PorcentajeMezclaDataGridViewTextBoxColumn.ReadOnly = True
        Me.PorcentajeMezclaDataGridViewTextBoxColumn.Width = 88
        '
        'KilogramosMezclaDataGridViewTextBoxColumn
        '
        Me.KilogramosMezclaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.KilogramosMezclaDataGridViewTextBoxColumn.DataPropertyName = "KilogramosMezcla"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N3"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.KilogramosMezclaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.KilogramosMezclaDataGridViewTextBoxColumn.HeaderText = "Cantidad Sugerida"
        Me.KilogramosMezclaDataGridViewTextBoxColumn.Name = "KilogramosMezclaDataGridViewTextBoxColumn"
        Me.KilogramosMezclaDataGridViewTextBoxColumn.ReadOnly = True
        Me.KilogramosMezclaDataGridViewTextBoxColumn.Width = 109
        '
        'CantidadDisponible
        '
        Me.CantidadDisponible.DataPropertyName = "CantidadDisponible"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N3"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.CantidadDisponible.DefaultCellStyle = DataGridViewCellStyle2
        Me.CantidadDisponible.HeaderText = "Cantidad Disponible"
        Me.CantidadDisponible.Name = "CantidadDisponible"
        Me.CantidadDisponible.ReadOnly = True
        '
        'KilogramosSalidaMezclaDataGridViewTextBoxColumn
        '
        Me.KilogramosSalidaMezclaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.KilogramosSalidaMezclaDataGridViewTextBoxColumn.DataPropertyName = "KilogramosSalidaMezcla"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N3"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.KilogramosSalidaMezclaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.KilogramosSalidaMezclaDataGridViewTextBoxColumn.HeaderText = "Cantidad Salida"
        Me.KilogramosSalidaMezclaDataGridViewTextBoxColumn.Name = "KilogramosSalidaMezclaDataGridViewTextBoxColumn"
        Me.KilogramosSalidaMezclaDataGridViewTextBoxColumn.Width = 97
        '
        'CostoUnitarioDataGridViewTextBoxColumn
        '
        Me.CostoUnitarioDataGridViewTextBoxColumn.DataPropertyName = "CostoUnitario"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.CostoUnitarioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.CostoUnitarioDataGridViewTextBoxColumn.HeaderText = "Costo Unitario"
        Me.CostoUnitarioDataGridViewTextBoxColumn.Name = "CostoUnitarioDataGridViewTextBoxColumn"
        Me.CostoUnitarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.CostoUnitarioDataGridViewTextBoxColumn.Visible = False
        '
        'clmImporte
        '
        Me.clmImporte.DataPropertyName = "Importe"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.clmImporte.DefaultCellStyle = DataGridViewCellStyle5
        Me.clmImporte.HeaderText = "Importe"
        Me.clmImporte.Name = "clmImporte"
        Me.clmImporte.ReadOnly = True
        '
        'FolioPreparacionMezclaDataGridViewTextBoxColumn
        '
        Me.FolioPreparacionMezclaDataGridViewTextBoxColumn.DataPropertyName = "FolioPreparacionMezcla"
        Me.FolioPreparacionMezclaDataGridViewTextBoxColumn.HeaderText = "FolioPreparacionMezcla"
        Me.FolioPreparacionMezclaDataGridViewTextBoxColumn.Name = "FolioPreparacionMezclaDataGridViewTextBoxColumn"
        Me.FolioPreparacionMezclaDataGridViewTextBoxColumn.Visible = False
        '
        'IdProductoDataGridViewTextBoxColumn
        '
        Me.IdProductoDataGridViewTextBoxColumn.DataPropertyName = "IdProducto"
        Me.IdProductoDataGridViewTextBoxColumn.HeaderText = "IdProducto"
        Me.IdProductoDataGridViewTextBoxColumn.Name = "IdProductoDataGridViewTextBoxColumn"
        Me.IdProductoDataGridViewTextBoxColumn.Visible = False
        '
        'IdPlazaDataGridViewTextBoxColumn
        '
        Me.IdPlazaDataGridViewTextBoxColumn.DataPropertyName = "IdPlaza"
        Me.IdPlazaDataGridViewTextBoxColumn.HeaderText = "IdPlaza"
        Me.IdPlazaDataGridViewTextBoxColumn.Name = "IdPlazaDataGridViewTextBoxColumn"
        Me.IdPlazaDataGridViewTextBoxColumn.Visible = False
        '
        'PlazaDataGridViewTextBoxColumn
        '
        Me.PlazaDataGridViewTextBoxColumn.DataPropertyName = "Plaza"
        Me.PlazaDataGridViewTextBoxColumn.HeaderText = "Plaza"
        Me.PlazaDataGridViewTextBoxColumn.Name = "PlazaDataGridViewTextBoxColumn"
        Me.PlazaDataGridViewTextBoxColumn.Visible = False
        '
        'PreparacionMezclaDataGridViewTextBoxColumn
        '
        Me.PreparacionMezclaDataGridViewTextBoxColumn.DataPropertyName = "PreparacionMezcla"
        Me.PreparacionMezclaDataGridViewTextBoxColumn.HeaderText = "PreparacionMezcla"
        Me.PreparacionMezclaDataGridViewTextBoxColumn.Name = "PreparacionMezclaDataGridViewTextBoxColumn"
        Me.PreparacionMezclaDataGridViewTextBoxColumn.Visible = False
        '
        'EntidadDataGridViewTextBoxColumn
        '
        Me.EntidadDataGridViewTextBoxColumn.DataPropertyName = "Entidad"
        Me.EntidadDataGridViewTextBoxColumn.HeaderText = "Entidad"
        Me.EntidadDataGridViewTextBoxColumn.Name = "EntidadDataGridViewTextBoxColumn"
        Me.EntidadDataGridViewTextBoxColumn.Visible = False
        '
        'SeleccionadoDataGridViewCheckBoxColumn
        '
        Me.SeleccionadoDataGridViewCheckBoxColumn.DataPropertyName = "Seleccionado"
        Me.SeleccionadoDataGridViewCheckBoxColumn.HeaderText = "Seleccionado"
        Me.SeleccionadoDataGridViewCheckBoxColumn.Name = "SeleccionadoDataGridViewCheckBoxColumn"
        Me.SeleccionadoDataGridViewCheckBoxColumn.Visible = False
        '
        'ContenedorDataGridViewTextBoxColumn
        '
        Me.ContenedorDataGridViewTextBoxColumn.DataPropertyName = "Contenedor"
        Me.ContenedorDataGridViewTextBoxColumn.HeaderText = "Contenedor"
        Me.ContenedorDataGridViewTextBoxColumn.Name = "ContenedorDataGridViewTextBoxColumn"
        Me.ContenedorDataGridViewTextBoxColumn.Visible = False
        '
        'IndiceEnContenedorDataGridViewTextBoxColumn
        '
        Me.IndiceEnContenedorDataGridViewTextBoxColumn.DataPropertyName = "IndiceEnContenedor"
        Me.IndiceEnContenedorDataGridViewTextBoxColumn.HeaderText = "IndiceEnContenedor"
        Me.IndiceEnContenedorDataGridViewTextBoxColumn.Name = "IndiceEnContenedorDataGridViewTextBoxColumn"
        Me.IndiceEnContenedorDataGridViewTextBoxColumn.ReadOnly = True
        Me.IndiceEnContenedorDataGridViewTextBoxColumn.Visible = False
        '
        'Ingredientes
        '
        Me.Ingredientes.AllowEdit = True
        Me.Ingredientes.AllowNew = True
        Me.Ingredientes.AllowRemove = True
        Me.Ingredientes.MaximoElementosSeleccionados = 1
        Me.Ingredientes.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.Ingredientes.MostrarAlertas = False
        Me.Ingredientes.Name = Nothing
        Me.Ingredientes.RaiseListChangedEvents = True
        Me.Ingredientes.Transaction = Nothing
        '
        'TxtFolioPreparacion
        '
        Me.TxtFolioPreparacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtFolioPreparacion.Location = New System.Drawing.Point(168, 59)
        Me.TxtFolioPreparacion.MaxLength = 6
        Me.TxtFolioPreparacion.Name = "TxtFolioPreparacion"
        Me.TxtFolioPreparacion.ReadOnly = True
        Me.TxtFolioPreparacion.Size = New System.Drawing.Size(124, 20)
        Me.TxtFolioPreparacion.TabIndex = 2
        '
        'TxtUnidad
        '
        Me.TxtUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtUnidad.Location = New System.Drawing.Point(607, 139)
        Me.TxtUnidad.MaxLength = 6
        Me.TxtUnidad.Name = "TxtUnidad"
        Me.TxtUnidad.ReadOnly = True
        Me.TxtUnidad.Size = New System.Drawing.Size(74, 20)
        Me.TxtUnidad.TabIndex = 7
        '
        'DtpFecha
        '
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(353, 58)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(89, 20)
        Me.DtpFecha.TabIndex = 3
        '
        'CmbEnvase
        '
        Me.CmbEnvase.DataSource = Me.Envases
        Me.CmbEnvase.DisplayMember = "Descripcion"
        Me.CmbEnvase.FormattingEnabled = True
        Me.CmbEnvase.Location = New System.Drawing.Point(168, 165)
        Me.CmbEnvase.Name = "CmbEnvase"
        Me.CmbEnvase.Size = New System.Drawing.Size(383, 21)
        Me.CmbEnvase.TabIndex = 8
        Me.CmbEnvase.ValueMember = "Codigo"
        Me.CmbEnvase.Visible = False
        '
        'Envases
        '
        Me.Envases.AllowEdit = True
        Me.Envases.AllowNew = True
        Me.Envases.AllowRemove = True
        Me.Envases.MaximoElementosSeleccionados = 1
        Me.Envases.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.Envases.MostrarAlertas = False
        Me.Envases.Name = ""
        Me.Envases.RaiseListChangedEvents = True
        Me.Envases.Transaction = Nothing
        '
        'CmbMezcla
        '
        Me.CmbMezcla.DataSource = Me.Mezclas
        Me.CmbMezcla.DisplayMember = "Descripcion"
        Me.CmbMezcla.FormattingEnabled = True
        Me.CmbMezcla.Location = New System.Drawing.Point(168, 112)
        Me.CmbMezcla.Name = "CmbMezcla"
        Me.CmbMezcla.Size = New System.Drawing.Size(383, 21)
        Me.CmbMezcla.TabIndex = 5
        Me.CmbMezcla.ValueMember = "Codigo"
        '
        'Mezclas
        '
        Me.Mezclas.AllowEdit = True
        Me.Mezclas.AllowNew = True
        Me.Mezclas.AllowRemove = True
        Me.Mezclas.MaximoElementosSeleccionados = 1
        Me.Mezclas.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.Mezclas.MostrarAlertas = False
        Me.Mezclas.Name = ""
        Me.Mezclas.RaiseListChangedEvents = True
        Me.Mezclas.Transaction = Nothing
        '
        'CmbAlmacen
        '
        Me.CmbAlmacen.DataSource = Me.Almacenes
        Me.CmbAlmacen.DisplayMember = "Descripcion"
        Me.CmbAlmacen.FormattingEnabled = True
        Me.CmbAlmacen.Location = New System.Drawing.Point(168, 85)
        Me.CmbAlmacen.Name = "CmbAlmacen"
        Me.CmbAlmacen.Size = New System.Drawing.Size(383, 21)
        Me.CmbAlmacen.TabIndex = 4
        Me.CmbAlmacen.ValueMember = "Codigo"
        '
        'Almacenes
        '
        Me.Almacenes.AllowEdit = True
        Me.Almacenes.AllowNew = True
        Me.Almacenes.AllowRemove = True
        Me.Almacenes.Name = ""
        Me.Almacenes.RaiseListChangedEvents = True
        Me.Almacenes.Tipo = ClasesNegocio.AlmacenEnum.ALMACEN
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(298, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Fecha:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(58, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Envase:"
        Me.Label7.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(557, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Unidad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 13)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Cantidad a Preparar:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Formula:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Almacen:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Folio Preparacióin:"
        '
        'CmbPlaza
        '
        Me.CmbPlaza.DataSource = Me.Plazas
        Me.CmbPlaza.DisplayMember = "Descripcion"
        Me.CmbPlaza.FormattingEnabled = True
        Me.CmbPlaza.Location = New System.Drawing.Point(168, 32)
        Me.CmbPlaza.Name = "CmbPlaza"
        Me.CmbPlaza.Size = New System.Drawing.Size(383, 21)
        Me.CmbPlaza.TabIndex = 1
        Me.CmbPlaza.ValueMember = "Codigo"
        '
        'Plazas
        '
        Me.Plazas.AllowEdit = True
        Me.Plazas.AllowNew = True
        Me.Plazas.AllowRemove = True
        Me.Plazas.MaximoElementosSeleccionados = 1
        Me.Plazas.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.Plazas.MostrarAlertas = False
        Me.Plazas.Name = ""
        Me.Plazas.RaiseListChangedEvents = True
        Me.Plazas.Transaction = Nothing
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(58, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Plaza:"
        '
        'txtCantidadEnvases
        '
        Me.txtCantidadEnvases.ComboBoxEnlazado = Nothing
        Me.txtCantidadEnvases.Decimales = 3
        Me.txtCantidadEnvases.Location = New System.Drawing.Point(659, 165)
        Me.txtCantidadEnvases.MaxLength = 3000
        Me.txtCantidadEnvases.MensajeCombo = "Seleccionar un item..."
        Me.txtCantidadEnvases.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtCantidadEnvases.Name = "txtCantidadEnvases"
        Me.txtCantidadEnvases.SiguienteControl = Nothing
        Me.txtCantidadEnvases.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidadEnvases.TabIndex = 69
        Me.txtCantidadEnvases.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtCantidadEnvases.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCantidadEnvases.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCantidadEnvases.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(557, 169)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 13)
        Me.Label11.TabIndex = 70
        Me.Label11.Text = "Cantidad Envases:"
        Me.Label11.Visible = False
        '
        'txtCantidadPreparar
        '
        Me.txtCantidadPreparar.ComboBoxEnlazado = Nothing
        Me.txtCantidadPreparar.Decimales = 3
        Me.txtCantidadPreparar.Location = New System.Drawing.Point(168, 139)
        Me.txtCantidadPreparar.MaxLength = 3000
        Me.txtCantidadPreparar.MensajeCombo = "Seleccionar un item..."
        Me.txtCantidadPreparar.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtCantidadPreparar.Name = "txtCantidadPreparar"
        Me.txtCantidadPreparar.SiguienteControl = Nothing
        Me.txtCantidadPreparar.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidadPreparar.TabIndex = 71
        Me.txtCantidadPreparar.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.[Decimal]
        Me.txtCantidadPreparar.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCantidadPreparar.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(274, 142)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(129, 13)
        Me.Label12.TabIndex = 72
        Me.Label12.Text = "Cantidad Real Preparada:"
        '
        'txtCantidadRealPreparada
        '
        Me.txtCantidadRealPreparada.ComboBoxEnlazado = Nothing
        Me.txtCantidadRealPreparada.Decimales = 3
        Me.txtCantidadRealPreparada.Location = New System.Drawing.Point(409, 139)
        Me.txtCantidadRealPreparada.MaxLength = 3000
        Me.txtCantidadRealPreparada.MensajeCombo = "Seleccionar un item..."
        Me.txtCantidadRealPreparada.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtCantidadRealPreparada.Name = "txtCantidadRealPreparada"
        Me.txtCantidadRealPreparada.ReadOnly = True
        Me.txtCantidadRealPreparada.SiguienteControl = Nothing
        Me.txtCantidadRealPreparada.Size = New System.Drawing.Size(142, 20)
        Me.txtCantidadRealPreparada.TabIndex = 73
        Me.txtCantidadRealPreparada.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.[Decimal]
        Me.txtCantidadRealPreparada.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCantidadRealPreparada.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'dtFechaCaducidad
        '
        Me.dtFechaCaducidad.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaCaducidad.Location = New System.Drawing.Point(548, 59)
        Me.dtFechaCaducidad.Name = "dtFechaCaducidad"
        Me.dtFechaCaducidad.Size = New System.Drawing.Size(105, 20)
        Me.dtFechaCaducidad.TabIndex = 74
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(448, 62)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 13)
        Me.Label13.TabIndex = 75
        Me.Label13.Text = "Fecha Caducidad:"
        '
        'txtLote
        '
        Me.txtLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLote.Location = New System.Drawing.Point(594, 85)
        Me.txtLote.MaxLength = 15
        Me.txtLote.Name = "txtLote"
        Me.txtLote.ReadOnly = True
        Me.txtLote.Size = New System.Drawing.Size(87, 20)
        Me.txtLote.TabIndex = 76
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(557, 88)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 13)
        Me.Label14.TabIndex = 77
        Me.Label14.Text = "Lote:"
        '
        'CatAlmRegPreparacionMezcla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 571)
        Me.Controls.Add(Me.txtLote)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.dtFechaCaducidad)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtCantidadRealPreparada)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtCantidadPreparar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtCantidadEnvases)
        Me.Controls.Add(Me.lblEstatus)
        Me.Controls.Add(Me.TxtObservaciones)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CmbPlaza)
        Me.Controls.Add(Me.TxtFolioPreparacion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtUnidad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DtpFecha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmbEnvase)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CmbMezcla)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CmbAlmacen)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.MinimumSize = New System.Drawing.Size(626, 523)
        Me.Name = "CatAlmRegPreparacionMezcla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Preparación de Formula"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgIngredientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents CmbPlaza As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtFolioPreparacion As System.Windows.Forms.TextBox
    Friend WithEvents TxtUnidad As System.Windows.Forms.TextBox
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmbEnvase As System.Windows.Forms.ComboBox
    Friend WithEvents CmbMezcla As System.Windows.Forms.ComboBox
    Friend WithEvents CmbAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgIngredientes As System.Windows.Forms.DataGridView
    Friend WithEvents TxtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents txtCantidadEnvases As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Mezclas As ClasesNegocio.ProductoCollectionClass
    Friend WithEvents Envases As ClasesNegocio.ProductoCollectionClass
    Friend WithEvents Almacenes As ClasesNegocio.AlmacenCollectionClass
    Friend WithEvents Plazas As ClasesNegocio.PlazaCollectionClass
    Friend WithEvents Ingredientes As ClasesNegocio.IngredienteCollection
    Friend WithEvents txtCantidadPreparar As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCantidadRealPreparada As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents ProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PorcentajeMezclaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilogramosMezclaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadDisponible As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilogramosSalidaMezclaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoUnitarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FolioPreparacionMezclaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdPlazaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlazaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PreparacionMezclaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EntidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeleccionadoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ContenedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IndiceEnContenedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtFechaCaducidad As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtLote As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
