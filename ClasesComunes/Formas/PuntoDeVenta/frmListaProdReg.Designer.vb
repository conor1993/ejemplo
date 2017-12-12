<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaProdReg
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.groupBox2 = New System.Windows.Forms.GroupBox
        Me.chkMaterialEnvace = New System.Windows.Forms.CheckBox
        Me.chkIngrediente = New System.Windows.Forms.CheckBox
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.rbtTodos = New System.Windows.Forms.RadioButton
        Me.rbtInactivos = New System.Windows.Forms.RadioButton
        Me.rbtActivos = New System.Windows.Forms.RadioButton
        Me.gbProducto = New System.Windows.Forms.GroupBox
        Me.chkMezcla = New System.Windows.Forms.CheckBox
        Me.chkProductoGeneral = New System.Windows.Forms.CheckBox
        Me.cmbLinea = New System.Windows.Forms.ComboBox
        Me.cmbMarca = New System.Windows.Forms.ComboBox
        Me.cmbSubLinea = New System.Windows.Forms.ComboBox
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.label4 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.gbProductosRegistrados = New System.Windows.Forms.GroupBox
        Me.dgvProductosReg = New System.Windows.Forms.DataGridView
        Me.CodigoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescCortaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MarcaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LineaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubLineaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmMezcla = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmProductoGeneral = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IngredienteColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmMaterialEnvase = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lblTema = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.groupBox2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.gbProducto.SuspendLayout()
        Me.gbProductosRegistrados.SuspendLayout()
        CType(Me.dgvProductosReg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.chkMaterialEnvace)
        Me.groupBox2.Controls.Add(Me.chkIngrediente)
        Me.groupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox2.Location = New System.Drawing.Point(567, 32)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(144, 77)
        Me.groupBox2.TabIndex = 39
        Me.groupBox2.TabStop = False
        '
        'chkMaterialEnvace
        '
        Me.chkMaterialEnvace.AutoSize = True
        Me.chkMaterialEnvace.Location = New System.Drawing.Point(5, 43)
        Me.chkMaterialEnvace.Name = "chkMaterialEnvace"
        Me.chkMaterialEnvace.Size = New System.Drawing.Size(133, 17)
        Me.chkMaterialEnvace.TabIndex = 17
        Me.chkMaterialEnvace.Text = "Material Para Envaces"
        Me.chkMaterialEnvace.UseVisualStyleBackColor = True
        '
        'chkIngrediente
        '
        Me.chkIngrediente.AutoSize = True
        Me.chkIngrediente.Location = New System.Drawing.Point(6, 20)
        Me.chkIngrediente.Name = "chkIngrediente"
        Me.chkIngrediente.Size = New System.Drawing.Size(79, 17)
        Me.chkIngrediente.TabIndex = 16
        Me.chkIngrediente.Text = "Ingregiente"
        Me.chkIngrediente.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.rbtTodos)
        Me.groupBox1.Controls.Add(Me.rbtInactivos)
        Me.groupBox1.Controls.Add(Me.rbtActivos)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(717, 32)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(84, 91)
        Me.groupBox1.TabIndex = 38
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
        'gbProducto
        '
        Me.gbProducto.Controls.Add(Me.chkMezcla)
        Me.gbProducto.Controls.Add(Me.chkProductoGeneral)
        Me.gbProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbProducto.Location = New System.Drawing.Point(435, 32)
        Me.gbProducto.Name = "gbProducto"
        Me.gbProducto.Size = New System.Drawing.Size(126, 77)
        Me.gbProducto.TabIndex = 37
        Me.gbProducto.TabStop = False
        '
        'chkMezcla
        '
        Me.chkMezcla.AutoSize = True
        Me.chkMezcla.Location = New System.Drawing.Point(6, 43)
        Me.chkMezcla.Name = "chkMezcla"
        Me.chkMezcla.Size = New System.Drawing.Size(60, 17)
        Me.chkMezcla.TabIndex = 17
        Me.chkMezcla.Text = "Mezcla"
        Me.chkMezcla.UseVisualStyleBackColor = True
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
        'cmbLinea
        '
        Me.cmbLinea.FormattingEnabled = True
        Me.cmbLinea.Location = New System.Drawing.Point(132, 39)
        Me.cmbLinea.Name = "cmbLinea"
        Me.cmbLinea.Size = New System.Drawing.Size(297, 21)
        Me.cmbLinea.TabIndex = 36
        '
        'cmbMarca
        '
        Me.cmbMarca.FormattingEnabled = True
        Me.cmbMarca.Location = New System.Drawing.Point(132, 93)
        Me.cmbMarca.Name = "cmbMarca"
        Me.cmbMarca.Size = New System.Drawing.Size(297, 21)
        Me.cmbMarca.TabIndex = 35
        '
        'cmbSubLinea
        '
        Me.cmbSubLinea.FormattingEnabled = True
        Me.cmbSubLinea.Location = New System.Drawing.Point(132, 66)
        Me.cmbSubLinea.Name = "cmbSubLinea"
        Me.cmbSubLinea.Size = New System.Drawing.Size(297, 21)
        Me.cmbSubLinea.TabIndex = 34
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(132, 120)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(297, 20)
        Me.txtDescripcion.TabIndex = 33
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(54, 123)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(72, 13)
        Me.label4.TabIndex = 32
        Me.label4.Text = "Descripción : "
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(54, 96)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(46, 13)
        Me.label3.TabIndex = 31
        Me.label3.Text = "Marca : "
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(54, 69)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(71, 13)
        Me.label2.TabIndex = 30
        Me.label2.Text = "Sub-Líneas : "
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(54, 42)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(44, 13)
        Me.label1.TabIndex = 29
        Me.label1.Text = "Línea : "
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Location = New System.Drawing.Point(884, 607)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 28
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Location = New System.Drawing.Point(803, 607)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 27
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'gbProductosRegistrados
        '
        Me.gbProductosRegistrados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbProductosRegistrados.Controls.Add(Me.dgvProductosReg)
        Me.gbProductosRegistrados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbProductosRegistrados.Location = New System.Drawing.Point(56, 146)
        Me.gbProductosRegistrados.Name = "gbProductosRegistrados"
        Me.gbProductosRegistrados.Size = New System.Drawing.Size(906, 454)
        Me.gbProductosRegistrados.TabIndex = 26
        Me.gbProductosRegistrados.TabStop = False
        Me.gbProductosRegistrados.Text = "Relación de Productos Registrados"
        '
        'dgvProductosReg
        '
        Me.dgvProductosReg.AllowUserToAddRows = False
        Me.dgvProductosReg.AllowUserToDeleteRows = False
        Me.dgvProductosReg.AllowUserToResizeRows = False
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvProductosReg.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvProductosReg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductosReg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvProductosReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductosReg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoColumn, Me.DescColumn, Me.DescCortaColumn, Me.MarcaColumn, Me.LineaColumn, Me.SubLineaColumn, Me.clmMezcla, Me.clmProductoGeneral, Me.IngredienteColumn, Me.clmMaterialEnvase})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProductosReg.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvProductosReg.Location = New System.Drawing.Point(6, 19)
        Me.dgvProductosReg.Name = "dgvProductosReg"
        Me.dgvProductosReg.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductosReg.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvProductosReg.RowHeadersVisible = False
        Me.dgvProductosReg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductosReg.Size = New System.Drawing.Size(894, 429)
        Me.dgvProductosReg.TabIndex = 0
        '
        'CodigoColumn
        '
        Me.CodigoColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CodigoColumn.DataPropertyName = "Codigo"
        Me.CodigoColumn.HeaderText = "Codigo"
        Me.CodigoColumn.Name = "CodigoColumn"
        Me.CodigoColumn.ReadOnly = True
        Me.CodigoColumn.Width = 65
        '
        'DescColumn
        '
        Me.DescColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DescColumn.DataPropertyName = "Descripcion"
        Me.DescColumn.HeaderText = "Descripción"
        Me.DescColumn.Name = "DescColumn"
        Me.DescColumn.ReadOnly = True
        Me.DescColumn.Width = 88
        '
        'DescCortaColumn
        '
        Me.DescCortaColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DescCortaColumn.DataPropertyName = "DescCorta"
        Me.DescCortaColumn.HeaderText = "Descripción Corta"
        Me.DescCortaColumn.Name = "DescCortaColumn"
        Me.DescCortaColumn.ReadOnly = True
        Me.DescCortaColumn.Width = 106
        '
        'MarcaColumn
        '
        Me.MarcaColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.MarcaColumn.DataPropertyName = "Marca"
        Me.MarcaColumn.HeaderText = "Marca"
        Me.MarcaColumn.Name = "MarcaColumn"
        Me.MarcaColumn.ReadOnly = True
        Me.MarcaColumn.Width = 62
        '
        'LineaColumn
        '
        Me.LineaColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.LineaColumn.DataPropertyName = "Linea"
        Me.LineaColumn.HeaderText = "Línea"
        Me.LineaColumn.Name = "LineaColumn"
        Me.LineaColumn.ReadOnly = True
        Me.LineaColumn.Width = 60
        '
        'SubLineaColumn
        '
        Me.SubLineaColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SubLineaColumn.DataPropertyName = "SubLinea"
        Me.SubLineaColumn.HeaderText = "Sub-Línea"
        Me.SubLineaColumn.Name = "SubLineaColumn"
        Me.SubLineaColumn.ReadOnly = True
        Me.SubLineaColumn.Width = 82
        '
        'clmMezcla
        '
        Me.clmMezcla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmMezcla.DataPropertyName = "Paquete"
        Me.clmMezcla.HeaderText = "Es Mezcla"
        Me.clmMezcla.Name = "clmMezcla"
        Me.clmMezcla.ReadOnly = True
        Me.clmMezcla.Width = 75
        '
        'clmProductoGeneral
        '
        Me.clmProductoGeneral.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmProductoGeneral.DataPropertyName = "ProductoGeneral"
        Me.clmProductoGeneral.HeaderText = "Es Producto General"
        Me.clmProductoGeneral.Name = "clmProductoGeneral"
        Me.clmProductoGeneral.ReadOnly = True
        Me.clmProductoGeneral.Width = 119
        '
        'IngredienteColumn
        '
        Me.IngredienteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.IngredienteColumn.DataPropertyName = "Ingrediente"
        Me.IngredienteColumn.HeaderText = "Es Ingrediente"
        Me.IngredienteColumn.Name = "IngredienteColumn"
        Me.IngredienteColumn.ReadOnly = True
        Me.IngredienteColumn.Width = 92
        '
        'clmMaterialEnvase
        '
        Me.clmMaterialEnvase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmMaterialEnvase.DataPropertyName = "MaterialEnvase"
        Me.clmMaterialEnvase.HeaderText = "Es Material Para Envase"
        Me.clmMaterialEnvase.Name = "clmMaterialEnvase"
        Me.clmMaterialEnvase.ReadOnly = True
        Me.clmMaterialEnvase.Width = 103
        '
        'lblTema
        '
        Me.lblTema.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTema.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTema.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTema.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTema.Location = New System.Drawing.Point(50, 0)
        Me.lblTema.Name = "lblTema"
        Me.lblTema.Size = New System.Drawing.Size(924, 29)
        Me.lblTema.TabIndex = 25
        Me.lblTema.Text = "LISTA DE PRODUCTOS REGISTRADOS"
        Me.lblTema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = False
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = False
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 638)
        Me.mtb.TabIndex = 40
        '
        'frmListaProdReg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 638)
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
        Me.Name = "frmListaProdReg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Lista de Productos Registrados"
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.gbProducto.ResumeLayout(False)
        Me.gbProducto.PerformLayout()
        Me.gbProductosRegistrados.ResumeLayout(False)
        CType(Me.dgvProductosReg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents chkMaterialEnvace As System.Windows.Forms.CheckBox
    Private WithEvents chkIngrediente As System.Windows.Forms.CheckBox
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents rbtTodos As System.Windows.Forms.RadioButton
    Private WithEvents rbtInactivos As System.Windows.Forms.RadioButton
    Private WithEvents rbtActivos As System.Windows.Forms.RadioButton
    Private WithEvents gbProducto As System.Windows.Forms.GroupBox
    Private WithEvents chkMezcla As System.Windows.Forms.CheckBox
    Private WithEvents chkProductoGeneral As System.Windows.Forms.CheckBox
    Private WithEvents cmbLinea As System.Windows.Forms.ComboBox
    Private WithEvents cmbMarca As System.Windows.Forms.ComboBox
    Private WithEvents cmbSubLinea As System.Windows.Forms.ComboBox
    Private WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents btnCancelar As System.Windows.Forms.Button
    Private WithEvents btnAceptar As System.Windows.Forms.Button
    Private WithEvents gbProductosRegistrados As System.Windows.Forms.GroupBox
    Private WithEvents dgvProductosReg As System.Windows.Forms.DataGridView
    Private WithEvents CodigoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents DescColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents DescCortaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents MarcaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents LineaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents SubLineaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents clmMezcla As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents clmProductoGeneral As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents IngredienteColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents clmMaterialEnvase As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents lblTema As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
End Class
