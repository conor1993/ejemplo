<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarProductos
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


#Region "Código generado por el Diseñador de Windows Forms"

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTema = New System.Windows.Forms.Label()
        Me.gbProductosRegistrados = New System.Windows.Forms.GroupBox()
        Me.dgvProductosReg = New System.Windows.Forms.DataGridView()
        Me.CodigoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCodBarras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescCortaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LineaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubLineaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmMezcla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFormula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmProductoGeneral = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IngredienteColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmMaterialEnvase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmExistencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.cmbSubLinea = New System.Windows.Forms.ComboBox()
        Me.cmbMarca = New System.Windows.Forms.ComboBox()
        Me.cmbLinea = New System.Windows.Forms.ComboBox()
        Me.gbProducto = New System.Windows.Forms.GroupBox()
        Me.chkMezcla = New System.Windows.Forms.CheckBox()
        Me.chkIngrediente = New System.Windows.Forms.CheckBox()
        Me.chkProductoGeneral = New System.Windows.Forms.CheckBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtTodos = New System.Windows.Forms.RadioButton()
        Me.rbtInactivos = New System.Windows.Forms.RadioButton()
        Me.rbtActivos = New System.Windows.Forms.RadioButton()
        Me.mtb = New MEAToolBar.MEAToolBar()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkMaterialEnvace = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodBarra = New System.Windows.Forms.TextBox()
        Me.gbProductosRegistrados.SuspendLayout()
        CType(Me.dgvProductosReg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbProducto.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTema
        '
        Me.lblTema.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTema.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTema.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTema.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTema.Location = New System.Drawing.Point(50, 0)
        Me.lblTema.Name = "lblTema"
        Me.lblTema.Size = New System.Drawing.Size(997, 29)
        Me.lblTema.TabIndex = 7
        Me.lblTema.Text = "LISTA DE PRODUCTOS REGISTRADOS"
        Me.lblTema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbProductosRegistrados
        '
        Me.gbProductosRegistrados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbProductosRegistrados.Controls.Add(Me.dgvProductosReg)
        Me.gbProductosRegistrados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbProductosRegistrados.Location = New System.Drawing.Point(57, 129)
        Me.gbProductosRegistrados.Name = "gbProductosRegistrados"
        Me.gbProductosRegistrados.Size = New System.Drawing.Size(979, 369)
        Me.gbProductosRegistrados.TabIndex = 8
        Me.gbProductosRegistrados.TabStop = False
        Me.gbProductosRegistrados.Text = "Relación de Productos Registrados"
        '
        'dgvProductosReg
        '
        Me.dgvProductosReg.AllowUserToAddRows = False
        Me.dgvProductosReg.AllowUserToDeleteRows = False
        Me.dgvProductosReg.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!)
        Me.dgvProductosReg.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProductosReg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProductosReg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProductosReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductosReg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoColumn, Me.clmCodBarras, Me.DescColumn, Me.DescCortaColumn, Me.MarcaColumn, Me.LineaColumn, Me.SubLineaColumn, Me.clmMezcla, Me.clmFormula, Me.clmProductoGeneral, Me.IngredienteColumn, Me.clmMaterialEnvase, Me.clmPrecio, Me.clmExistencia})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProductosReg.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvProductosReg.Location = New System.Drawing.Point(6, 19)
        Me.dgvProductosReg.Name = "dgvProductosReg"
        Me.dgvProductosReg.ReadOnly = True
        Me.dgvProductosReg.RowHeadersVisible = False
        Me.dgvProductosReg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductosReg.Size = New System.Drawing.Size(967, 344)
        Me.dgvProductosReg.TabIndex = 0
        '
        'CodigoColumn
        '
        Me.CodigoColumn.DataPropertyName = "Codigo"
        Me.CodigoColumn.FillWeight = 25.0!
        Me.CodigoColumn.HeaderText = "Codigo"
        Me.CodigoColumn.Name = "CodigoColumn"
        Me.CodigoColumn.ReadOnly = True
        '
        'clmCodBarras
        '
        Me.clmCodBarras.DataPropertyName = "CodigoBarra"
        Me.clmCodBarras.FillWeight = 55.0!
        Me.clmCodBarras.HeaderText = "Codigo de Barras"
        Me.clmCodBarras.Name = "clmCodBarras"
        Me.clmCodBarras.ReadOnly = True
        '
        'DescColumn
        '
        Me.DescColumn.DataPropertyName = "Descripcion"
        Me.DescColumn.FillWeight = 150.0!
        Me.DescColumn.HeaderText = "Descripción"
        Me.DescColumn.Name = "DescColumn"
        Me.DescColumn.ReadOnly = True
        '
        'DescCortaColumn
        '
        Me.DescCortaColumn.DataPropertyName = "DescCorta"
        Me.DescCortaColumn.FillWeight = 86.91676!
        Me.DescCortaColumn.HeaderText = "Descripción Corta"
        Me.DescCortaColumn.Name = "DescCortaColumn"
        Me.DescCortaColumn.ReadOnly = True
        Me.DescCortaColumn.Visible = False
        '
        'MarcaColumn
        '
        Me.MarcaColumn.DataPropertyName = "Marca"
        Me.MarcaColumn.HeaderText = "Marca"
        Me.MarcaColumn.Name = "MarcaColumn"
        Me.MarcaColumn.ReadOnly = True
        Me.MarcaColumn.Visible = False
        '
        'LineaColumn
        '
        Me.LineaColumn.DataPropertyName = "Linea"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.LineaColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.LineaColumn.FillWeight = 15.0!
        Me.LineaColumn.HeaderText = "Línea"
        Me.LineaColumn.Name = "LineaColumn"
        Me.LineaColumn.ReadOnly = True
        '
        'SubLineaColumn
        '
        Me.SubLineaColumn.DataPropertyName = "SubLinea"
        Me.SubLineaColumn.HeaderText = "Sub-Línea"
        Me.SubLineaColumn.Name = "SubLineaColumn"
        Me.SubLineaColumn.ReadOnly = True
        Me.SubLineaColumn.Visible = False
        '
        'clmMezcla
        '
        Me.clmMezcla.DataPropertyName = "EsMezcla"
        Me.clmMezcla.FillWeight = 18.72835!
        Me.clmMezcla.HeaderText = "Es Fórmula"
        Me.clmMezcla.Name = "clmMezcla"
        Me.clmMezcla.ReadOnly = True
        Me.clmMezcla.Visible = False
        '
        'clmFormula
        '
        Me.clmFormula.DataPropertyName = "Paquete"
        Me.clmFormula.HeaderText = "Fórmula"
        Me.clmFormula.Name = "clmFormula"
        Me.clmFormula.ReadOnly = True
        Me.clmFormula.Visible = False
        '
        'clmProductoGeneral
        '
        Me.clmProductoGeneral.DataPropertyName = "ProductoGeneral"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.clmProductoGeneral.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmProductoGeneral.FillWeight = 18.72835!
        Me.clmProductoGeneral.HeaderText = "Es Prod General"
        Me.clmProductoGeneral.Name = "clmProductoGeneral"
        Me.clmProductoGeneral.ReadOnly = True
        '
        'IngredienteColumn
        '
        Me.IngredienteColumn.DataPropertyName = "Ingrediente"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.IngredienteColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.IngredienteColumn.FillWeight = 18.72835!
        Me.IngredienteColumn.HeaderText = "Es Ingrediente"
        Me.IngredienteColumn.Name = "IngredienteColumn"
        Me.IngredienteColumn.ReadOnly = True
        '
        'clmMaterialEnvase
        '
        Me.clmMaterialEnvase.DataPropertyName = "MaterialEnvase"
        Me.clmMaterialEnvase.HeaderText = "Es Material Para Envase"
        Me.clmMaterialEnvase.Name = "clmMaterialEnvase"
        Me.clmMaterialEnvase.ReadOnly = True
        Me.clmMaterialEnvase.Visible = False
        '
        'clmPrecio
        '
        Me.clmPrecio.DataPropertyName = "PrecioV"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.clmPrecio.DefaultCellStyle = DataGridViewCellStyle5
        Me.clmPrecio.FillWeight = 25.0!
        Me.clmPrecio.HeaderText = "Precio"
        Me.clmPrecio.Name = "clmPrecio"
        Me.clmPrecio.ReadOnly = True
        '
        'clmExistencia
        '
        Me.clmExistencia.DataPropertyName = "CantidadExistencia"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.clmExistencia.DefaultCellStyle = DataGridViewCellStyle6
        Me.clmExistencia.FillWeight = 30.0!
        Me.clmExistencia.HeaderText = "Existencia"
        Me.clmExistencia.Name = "clmExistencia"
        Me.clmExistencia.ReadOnly = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Location = New System.Drawing.Point(876, 522)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 9
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Location = New System.Drawing.Point(957, 522)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(54, 42)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(44, 13)
        Me.label1.TabIndex = 11
        Me.label1.Text = "Línea : "
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(613, 96)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(71, 13)
        Me.label2.TabIndex = 12
        Me.label2.Text = "Sub-Líneas : "
        Me.label2.Visible = False
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(613, 123)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(46, 13)
        Me.label3.TabIndex = 13
        Me.label3.Text = "Marca : "
        Me.label3.Visible = False
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(54, 69)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(72, 13)
        Me.label4.TabIndex = 14
        Me.label4.Text = "Descripción : "
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(132, 66)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(297, 20)
        Me.txtDescripcion.TabIndex = 15
        '
        'cmbSubLinea
        '
        Me.cmbSubLinea.FormattingEnabled = True
        Me.cmbSubLinea.Location = New System.Drawing.Point(691, 93)
        Me.cmbSubLinea.Name = "cmbSubLinea"
        Me.cmbSubLinea.Size = New System.Drawing.Size(268, 21)
        Me.cmbSubLinea.TabIndex = 17
        Me.cmbSubLinea.Visible = False
        '
        'cmbMarca
        '
        Me.cmbMarca.FormattingEnabled = True
        Me.cmbMarca.Location = New System.Drawing.Point(691, 120)
        Me.cmbMarca.Name = "cmbMarca"
        Me.cmbMarca.Size = New System.Drawing.Size(268, 21)
        Me.cmbMarca.TabIndex = 18
        Me.cmbMarca.Visible = False
        '
        'cmbLinea
        '
        Me.cmbLinea.FormattingEnabled = True
        Me.cmbLinea.Location = New System.Drawing.Point(132, 39)
        Me.cmbLinea.Name = "cmbLinea"
        Me.cmbLinea.Size = New System.Drawing.Size(297, 21)
        Me.cmbLinea.TabIndex = 19
        '
        'gbProducto
        '
        Me.gbProducto.Controls.Add(Me.chkMezcla)
        Me.gbProducto.Controls.Add(Me.chkIngrediente)
        Me.gbProducto.Controls.Add(Me.chkProductoGeneral)
        Me.gbProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbProducto.Location = New System.Drawing.Point(525, 29)
        Me.gbProducto.Name = "gbProducto"
        Me.gbProducto.Size = New System.Drawing.Size(126, 91)
        Me.gbProducto.TabIndex = 22
        Me.gbProducto.TabStop = False
        Me.gbProducto.Visible = False
        '
        'chkMezcla
        '
        Me.chkMezcla.AutoSize = True
        Me.chkMezcla.Location = New System.Drawing.Point(6, 43)
        Me.chkMezcla.Name = "chkMezcla"
        Me.chkMezcla.Size = New System.Drawing.Size(66, 17)
        Me.chkMezcla.TabIndex = 17
        Me.chkMezcla.Text = "Paquete"
        Me.chkMezcla.UseVisualStyleBackColor = True
        '
        'chkIngrediente
        '
        Me.chkIngrediente.AutoSize = True
        Me.chkIngrediente.Location = New System.Drawing.Point(6, 66)
        Me.chkIngrediente.Name = "chkIngrediente"
        Me.chkIngrediente.Size = New System.Drawing.Size(79, 17)
        Me.chkIngrediente.TabIndex = 16
        Me.chkIngrediente.Text = "Ingrediente"
        Me.chkIngrediente.UseVisualStyleBackColor = True
        '
        'chkProductoGeneral
        '
        Me.chkProductoGeneral.AutoSize = True
        Me.chkProductoGeneral.Location = New System.Drawing.Point(6, 20)
        Me.chkProductoGeneral.Name = "chkProductoGeneral"
        Me.chkProductoGeneral.Size = New System.Drawing.Size(109, 17)
        Me.chkProductoGeneral.TabIndex = 16
        Me.chkProductoGeneral.Text = "Producto General"
        Me.chkProductoGeneral.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.rbtTodos)
        Me.groupBox1.Controls.Add(Me.rbtInactivos)
        Me.groupBox1.Controls.Add(Me.rbtActivos)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(435, 32)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(84, 91)
        Me.groupBox1.TabIndex = 23
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Estatus"
        '
        'rbtTodos
        '
        Me.rbtTodos.AutoSize = True
        Me.rbtTodos.Checked = True
        Me.rbtTodos.Location = New System.Drawing.Point(7, 65)
        Me.rbtTodos.Name = "rbtTodos"
        Me.rbtTodos.Size = New System.Drawing.Size(55, 17)
        Me.rbtTodos.TabIndex = 2
        Me.rbtTodos.TabStop = True
        Me.rbtTodos.Text = "Todos"
        Me.rbtTodos.UseVisualStyleBackColor = True
        '
        'rbtInactivos
        '
        Me.rbtInactivos.AutoSize = True
        Me.rbtInactivos.Location = New System.Drawing.Point(7, 42)
        Me.rbtInactivos.Name = "rbtInactivos"
        Me.rbtInactivos.Size = New System.Drawing.Size(68, 17)
        Me.rbtInactivos.TabIndex = 1
        Me.rbtInactivos.Text = "Inactivos"
        Me.rbtInactivos.UseVisualStyleBackColor = True
        '
        'rbtActivos
        '
        Me.rbtActivos.AutoSize = True
        Me.rbtActivos.Location = New System.Drawing.Point(7, 19)
        Me.rbtActivos.Name = "rbtActivos"
        Me.rbtActivos.Size = New System.Drawing.Size(60, 17)
        Me.rbtActivos.TabIndex = 0
        Me.rbtActivos.Text = "Activos"
        Me.rbtActivos.UseVisualStyleBackColor = True
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
        Me.mtb.MostrarBorrar = False
        Me.mtb.MostrarBuscar = True
        Me.mtb.MostrarCancelar = False
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = False
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 553)
        Me.mtb.TabIndex = 24
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.chkMaterialEnvace)
        Me.groupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox2.Location = New System.Drawing.Point(812, 44)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(144, 43)
        Me.groupBox2.TabIndex = 23
        Me.groupBox2.TabStop = False
        Me.groupBox2.Visible = False
        '
        'chkMaterialEnvace
        '
        Me.chkMaterialEnvace.AutoSize = True
        Me.chkMaterialEnvace.Location = New System.Drawing.Point(5, 13)
        Me.chkMaterialEnvace.Name = "chkMaterialEnvace"
        Me.chkMaterialEnvace.Size = New System.Drawing.Size(132, 17)
        Me.chkMaterialEnvace.TabIndex = 17
        Me.chkMaterialEnvace.Text = "Material Para Envases"
        Me.chkMaterialEnvace.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Cod. Barra:"
        '
        'txtCodBarra
        '
        Me.txtCodBarra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodBarra.Location = New System.Drawing.Point(132, 96)
        Me.txtCodBarra.Name = "txtCodBarra"
        Me.txtCodBarra.Size = New System.Drawing.Size(297, 20)
        Me.txtCodBarra.TabIndex = 26
        '
        'FrmBuscarProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1047, 553)
        Me.Controls.Add(Me.txtCodBarra)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.gbProducto)
        Me.Controls.Add(Me.cmbLinea)
        Me.Controls.Add(Me.cmbMarca)
        Me.Controls.Add(Me.cmbSubLinea)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.gbProductosRegistrados)
        Me.Controls.Add(Me.lblTema)
        Me.Controls.Add(Me.mtb)
        Me.KeyPreview = True
        Me.Name = "FrmBuscarProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Productos Registrados"
        Me.gbProductosRegistrados.ResumeLayout(False)
        CType(Me.dgvProductosReg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbProducto.ResumeLayout(False)
        Me.gbProducto.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private WithEvents lblTema As System.Windows.Forms.Label
    Friend WithEvents gbProductosRegistrados As System.Windows.Forms.GroupBox
    Friend WithEvents dgvProductosReg As System.Windows.Forms.DataGridView
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents cmbSubLinea As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMarca As System.Windows.Forms.ComboBox
    Friend WithEvents cmbLinea As System.Windows.Forms.ComboBox
    Friend WithEvents gbProducto As System.Windows.Forms.GroupBox
    Friend WithEvents chkMezcla As System.Windows.Forms.CheckBox
    Friend WithEvents chkProductoGeneral As System.Windows.Forms.CheckBox
    Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents rbtTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbtInactivos As System.Windows.Forms.RadioButton
    Friend WithEvents rbtActivos As System.Windows.Forms.RadioButton
    Friend WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkMaterialEnvace As System.Windows.Forms.CheckBox
    Friend WithEvents chkIngrediente As System.Windows.Forms.CheckBox
    Friend WithEvents CodigoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCodBarras As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescCortaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarcaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LineaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubLineaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmMezcla As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFormula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmProductoGeneral As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IngredienteColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmMaterialEnvase As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPrecio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmExistencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCodBarra As System.Windows.Forms.TextBox
End Class