<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarAlmacenes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.lblTema = New System.Windows.Forms.Label
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.label4 = New System.Windows.Forms.Label
        Me.gbTipoProducto = New System.Windows.Forms.GroupBox
        Me.chkTodosTiposProductos = New System.Windows.Forms.CheckBox
        Me.chkVenta = New System.Windows.Forms.CheckBox
        Me.chkCongelado = New System.Windows.Forms.CheckBox
        Me.chkFresco = New System.Windows.Forms.CheckBox
        Me.chkGeneral = New System.Windows.Forms.CheckBox
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.chkCancelados = New System.Windows.Forms.CheckBox
        Me.chkVigentes = New System.Windows.Forms.CheckBox
        Me.chkTodosEstatus = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chkTodoAlmacenes = New System.Windows.Forms.CheckBox
        Me.chkTerceros = New System.Windows.Forms.CheckBox
        Me.chkPropios = New System.Windows.Forms.CheckBox
        Me.dgvAlmacenes = New System.Windows.Forms.DataGridView
        Me.clmCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmDescripcionCorta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmLetra = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPlaza = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.gbTipoProducto.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvAlmacenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
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
        Me.mtb.Size = New System.Drawing.Size(50, 403)
        Me.mtb.TabIndex = 25
        '
        'lblTema
        '
        Me.lblTema.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTema.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTema.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTema.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTema.Location = New System.Drawing.Point(50, 0)
        Me.lblTema.Name = "lblTema"
        Me.lblTema.Size = New System.Drawing.Size(599, 29)
        Me.lblTema.TabIndex = 26
        Me.lblTema.Text = "Busqueda de Almacenes"
        Me.lblTema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(130, 43)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(282, 20)
        Me.txtDescripcion.TabIndex = 28
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(52, 46)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(72, 13)
        Me.label4.TabIndex = 27
        Me.label4.Text = "Descripción : "
        '
        'gbTipoProducto
        '
        Me.gbTipoProducto.Controls.Add(Me.chkTodosTiposProductos)
        Me.gbTipoProducto.Controls.Add(Me.chkVenta)
        Me.gbTipoProducto.Controls.Add(Me.chkCongelado)
        Me.gbTipoProducto.Controls.Add(Me.chkFresco)
        Me.gbTipoProducto.Controls.Add(Me.chkGeneral)
        Me.gbTipoProducto.Location = New System.Drawing.Point(369, 70)
        Me.gbTipoProducto.Name = "gbTipoProducto"
        Me.gbTipoProducto.Size = New System.Drawing.Size(195, 61)
        Me.gbTipoProducto.TabIndex = 31
        Me.gbTipoProducto.TabStop = False
        '
        'chkTodosTiposProductos
        '
        Me.chkTodosTiposProductos.AutoSize = True
        Me.chkTodosTiposProductos.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.chkTodosTiposProductos.Location = New System.Drawing.Point(8, 0)
        Me.chkTodosTiposProductos.Name = "chkTodosTiposProductos"
        Me.chkTodosTiposProductos.Size = New System.Drawing.Size(167, 17)
        Me.chkTodosTiposProductos.TabIndex = 36
        Me.chkTodosTiposProductos.Text = "Todos los Tipos de Productos"
        Me.chkTodosTiposProductos.UseVisualStyleBackColor = True
        '
        'chkVenta
        '
        Me.chkVenta.AutoSize = True
        Me.chkVenta.Location = New System.Drawing.Point(74, 41)
        Me.chkVenta.Name = "chkVenta"
        Me.chkVenta.Size = New System.Drawing.Size(54, 17)
        Me.chkVenta.TabIndex = 40
        Me.chkVenta.Text = "Venta"
        Me.chkVenta.UseVisualStyleBackColor = True
        '
        'chkCongelado
        '
        Me.chkCongelado.AutoSize = True
        Me.chkCongelado.Location = New System.Drawing.Point(74, 20)
        Me.chkCongelado.Name = "chkCongelado"
        Me.chkCongelado.Size = New System.Drawing.Size(77, 17)
        Me.chkCongelado.TabIndex = 39
        Me.chkCongelado.Text = "Congelado"
        Me.chkCongelado.UseVisualStyleBackColor = True
        '
        'chkFresco
        '
        Me.chkFresco.AutoSize = True
        Me.chkFresco.Location = New System.Drawing.Point(6, 41)
        Me.chkFresco.Name = "chkFresco"
        Me.chkFresco.Size = New System.Drawing.Size(58, 17)
        Me.chkFresco.TabIndex = 38
        Me.chkFresco.Text = "Fresco"
        Me.chkFresco.UseVisualStyleBackColor = True
        '
        'chkGeneral
        '
        Me.chkGeneral.AutoSize = True
        Me.chkGeneral.Location = New System.Drawing.Point(6, 20)
        Me.chkGeneral.Name = "chkGeneral"
        Me.chkGeneral.Size = New System.Drawing.Size(63, 17)
        Me.chkGeneral.TabIndex = 37
        Me.chkGeneral.Text = "General"
        Me.chkGeneral.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.chkCancelados)
        Me.groupBox1.Controls.Add(Me.chkVigentes)
        Me.groupBox1.Controls.Add(Me.chkTodosEstatus)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(212, 69)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(151, 61)
        Me.groupBox1.TabIndex = 32
        Me.groupBox1.TabStop = False
        '
        'chkCancelados
        '
        Me.chkCancelados.AutoSize = True
        Me.chkCancelados.Location = New System.Drawing.Point(6, 41)
        Me.chkCancelados.Name = "chkCancelados"
        Me.chkCancelados.Size = New System.Drawing.Size(82, 17)
        Me.chkCancelados.TabIndex = 34
        Me.chkCancelados.Text = "Cancelados"
        Me.chkCancelados.UseVisualStyleBackColor = True
        '
        'chkVigentes
        '
        Me.chkVigentes.AutoSize = True
        Me.chkVigentes.Location = New System.Drawing.Point(6, 20)
        Me.chkVigentes.Name = "chkVigentes"
        Me.chkVigentes.Size = New System.Drawing.Size(67, 17)
        Me.chkVigentes.TabIndex = 36
        Me.chkVigentes.Text = "Vigentes"
        Me.chkVigentes.UseVisualStyleBackColor = True
        '
        'chkTodosEstatus
        '
        Me.chkTodosEstatus.AutoSize = True
        Me.chkTodosEstatus.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.chkTodosEstatus.Location = New System.Drawing.Point(6, 1)
        Me.chkTodosEstatus.Name = "chkTodosEstatus"
        Me.chkTodosEstatus.Size = New System.Drawing.Size(110, 17)
        Me.chkTodosEstatus.TabIndex = 35
        Me.chkTodosEstatus.Text = "Todos los Estatus"
        Me.chkTodosEstatus.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkTodoAlmacenes)
        Me.GroupBox2.Controls.Add(Me.chkTerceros)
        Me.GroupBox2.Controls.Add(Me.chkPropios)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(55, 69)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(151, 61)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        '
        'chkTodoAlmacenes
        '
        Me.chkTodoAlmacenes.AutoSize = True
        Me.chkTodoAlmacenes.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.chkTodoAlmacenes.Location = New System.Drawing.Point(11, 0)
        Me.chkTodoAlmacenes.Name = "chkTodoAlmacenes"
        Me.chkTodoAlmacenes.Size = New System.Drawing.Size(127, 17)
        Me.chkTodoAlmacenes.TabIndex = 34
        Me.chkTodoAlmacenes.Text = "Todos los Almacenes"
        Me.chkTodoAlmacenes.UseVisualStyleBackColor = True
        '
        'chkTerceros
        '
        Me.chkTerceros.AutoSize = True
        Me.chkTerceros.Location = New System.Drawing.Point(11, 41)
        Me.chkTerceros.Name = "chkTerceros"
        Me.chkTerceros.Size = New System.Drawing.Size(68, 17)
        Me.chkTerceros.TabIndex = 1
        Me.chkTerceros.Text = "Terceros"
        Me.chkTerceros.UseVisualStyleBackColor = True
        '
        'chkPropios
        '
        Me.chkPropios.AutoSize = True
        Me.chkPropios.Location = New System.Drawing.Point(11, 20)
        Me.chkPropios.Name = "chkPropios"
        Me.chkPropios.Size = New System.Drawing.Size(61, 17)
        Me.chkPropios.TabIndex = 0
        Me.chkPropios.Text = "Propios"
        Me.chkPropios.UseVisualStyleBackColor = True
        '
        'dgvAlmacenes
        '
        Me.dgvAlmacenes.AllowUserToAddRows = False
        Me.dgvAlmacenes.AllowUserToDeleteRows = False
        Me.dgvAlmacenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlmacenes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmCodigo, Me.clmDescripcion, Me.clmDescripcionCorta, Me.clmLetra, Me.clmPlaza})
        Me.dgvAlmacenes.Location = New System.Drawing.Point(11, 19)
        Me.dgvAlmacenes.Name = "dgvAlmacenes"
        Me.dgvAlmacenes.ReadOnly = True
        Me.dgvAlmacenes.RowHeadersVisible = False
        Me.dgvAlmacenes.Size = New System.Drawing.Size(568, 229)
        Me.dgvAlmacenes.TabIndex = 34
        '
        'clmCodigo
        '
        Me.clmCodigo.DataPropertyName = "AlmacenId"
        Me.clmCodigo.HeaderText = "Codigo"
        Me.clmCodigo.Name = "clmCodigo"
        Me.clmCodigo.ReadOnly = True
        Me.clmCodigo.Width = 60
        '
        'clmDescripcion
        '
        Me.clmDescripcion.DataPropertyName = "Descripcion"
        Me.clmDescripcion.HeaderText = "Descripcion"
        Me.clmDescripcion.Name = "clmDescripcion"
        Me.clmDescripcion.ReadOnly = True
        Me.clmDescripcion.Width = 250
        '
        'clmDescripcionCorta
        '
        Me.clmDescripcionCorta.HeaderText = "Descr. Corta"
        Me.clmDescripcionCorta.Name = "clmDescripcionCorta"
        Me.clmDescripcionCorta.ReadOnly = True
        '
        'clmLetra
        '
        Me.clmLetra.DataPropertyName = "Letra"
        Me.clmLetra.HeaderText = "Letra"
        Me.clmLetra.Name = "clmLetra"
        Me.clmLetra.ReadOnly = True
        Me.clmLetra.Width = 40
        '
        'clmPlaza
        '
        Me.clmPlaza.DataPropertyName = "Plaza_"
        Me.clmPlaza.HeaderText = "Plaza"
        Me.clmPlaza.Name = "clmPlaza"
        Me.clmPlaza.ReadOnly = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvAlmacenes)
        Me.GroupBox3.Location = New System.Drawing.Point(55, 137)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(585, 254)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Resultado"
        '
        'FrmBuscarAlmacenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 403)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.gbTipoProducto)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.lblTema)
        Me.Controls.Add(Me.mtb)
        Me.Name = "FrmBuscarAlmacenes"
        Me.Text = "Busqueda de Almacenes"
        Me.gbTipoProducto.ResumeLayout(False)
        Me.gbTipoProducto.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvAlmacenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Private WithEvents lblTema As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents gbTipoProducto As System.Windows.Forms.GroupBox
    Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCancelados As System.Windows.Forms.CheckBox
    Friend WithEvents chkVigentes As System.Windows.Forms.CheckBox
    Friend WithEvents chkTodosEstatus As System.Windows.Forms.CheckBox
    Friend WithEvents chkTodoAlmacenes As System.Windows.Forms.CheckBox
    Friend WithEvents chkTerceros As System.Windows.Forms.CheckBox
    Friend WithEvents chkPropios As System.Windows.Forms.CheckBox
    Friend WithEvents chkVenta As System.Windows.Forms.CheckBox
    Friend WithEvents chkCongelado As System.Windows.Forms.CheckBox
    Friend WithEvents chkFresco As System.Windows.Forms.CheckBox
    Friend WithEvents chkGeneral As System.Windows.Forms.CheckBox
    Friend WithEvents chkTodosTiposProductos As System.Windows.Forms.CheckBox
    Friend WithEvents dgvAlmacenes As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents clmCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDescripcionCorta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmLetra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPlaza As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
