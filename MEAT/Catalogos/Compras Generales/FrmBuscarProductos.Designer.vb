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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.lblTema = New System.Windows.Forms.Label
        Me.gbProductosRegistrados = New System.Windows.Forms.GroupBox
        Me.dgvProductosReg = New System.Windows.Forms.DataGridView
        Me.CodigoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescCortaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MarcaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LineaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubLineaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmMezcla = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFormula = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmProductoGeneral = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IngredienteColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmMaterialEnvase = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.label1 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.label4 = New System.Windows.Forms.Label
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.cmbSubLinea = New System.Windows.Forms.ComboBox
        Me.cmbMarca = New System.Windows.Forms.ComboBox
        Me.cmbLinea = New System.Windows.Forms.ComboBox
        Me.gbProducto = New System.Windows.Forms.GroupBox
        Me.chkMezcla = New System.Windows.Forms.CheckBox
        Me.chkIngrediente = New System.Windows.Forms.CheckBox
        Me.chkProductoGeneral = New System.Windows.Forms.CheckBox
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.rbtTodos = New System.Windows.Forms.RadioButton
        Me.rbtInactivos = New System.Windows.Forms.RadioButton
        Me.rbtActivos = New System.Windows.Forms.RadioButton
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.groupBox2 = New System.Windows.Forms.GroupBox
        Me.chkMaterialEnvace = New System.Windows.Forms.CheckBox
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
        Me.lblTema.Size = New System.Drawing.Size(924, 29)
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
        Me.gbProductosRegistrados.Size = New System.Drawing.Size(906, 454)
        Me.gbProductosRegistrados.TabIndex = 8
        Me.gbProductosRegistrados.TabStop = False
        Me.gbProductosRegistrados.Text = "Relación de Productos Registrados"
        '
        'dgvProductosReg
        '
        Me.dgvProductosReg.AllowUserToAddRows = False
        Me.dgvProductosReg.AllowUserToDeleteRows = False
        Me.dgvProductosReg.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvProductosReg.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProductosReg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProductosReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductosReg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoColumn, Me.DescColumn, Me.DescCortaColumn, Me.MarcaColumn, Me.LineaColumn, Me.SubLineaColumn, Me.clmMezcla, Me.clmFormula, Me.clmProductoGeneral, Me.IngredienteColumn, Me.clmMaterialEnvase})
        Me.dgvProductosReg.Location = New System.Drawing.Point(6, 19)
        Me.dgvProductosReg.Name = "dgvProductosReg"
        Me.dgvProductosReg.ReadOnly = True
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
        Me.MarcaColumn.Visible = False
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
        Me.SubLineaColumn.Visible = False
        '
        'clmMezcla
        '
        Me.clmMezcla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmMezcla.DataPropertyName = "EsMezcla"
        Me.clmMezcla.HeaderText = "Es Fórmula"
        Me.clmMezcla.Name = "clmMezcla"
        Me.clmMezcla.ReadOnly = True
        Me.clmMezcla.Width = 78
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
        Me.clmMaterialEnvase.Visible = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Location = New System.Drawing.Point(803, 607)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 9
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Location = New System.Drawing.Point(884, 607)
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
        Me.gbProducto.Location = New System.Drawing.Point(435, 32)
        Me.gbProducto.Name = "gbProducto"
        Me.gbProducto.Size = New System.Drawing.Size(126, 91)
        Me.gbProducto.TabIndex = 22
        Me.gbProducto.TabStop = False
        '
        'chkMezcla
        '
        Me.chkMezcla.AutoSize = True
        Me.chkMezcla.Location = New System.Drawing.Point(6, 43)
        Me.chkMezcla.Name = "chkMezcla"
        Me.chkMezcla.Size = New System.Drawing.Size(106, 17)
        Me.chkMezcla.TabIndex = 17
        Me.chkMezcla.Text = "Mezcla (Fórmula)"
        Me.chkMezcla.UseVisualStyleBackColor = True
        '
        'chkIngrediente
        '
        Me.chkIngrediente.AutoSize = True
        Me.chkIngrediente.Location = New System.Drawing.Point(6, 66)
        Me.chkIngrediente.Name = "chkIngrediente"
        Me.chkIngrediente.Size = New System.Drawing.Size(79, 17)
        Me.chkIngrediente.TabIndex = 16
        Me.chkIngrediente.Text = "Ingregiente"
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
        Me.groupBox1.Location = New System.Drawing.Point(567, 32)
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
        Me.mtb.Size = New System.Drawing.Size(50, 638)
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
        Me.chkMaterialEnvace.Size = New System.Drawing.Size(133, 17)
        Me.chkMaterialEnvace.TabIndex = 17
        Me.chkMaterialEnvace.Text = "Material Para Envaces"
        Me.chkMaterialEnvace.UseVisualStyleBackColor = True
        '
        'FrmBuscarProductos
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
End Class