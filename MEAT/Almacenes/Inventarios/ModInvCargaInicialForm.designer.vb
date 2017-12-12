<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModInvCargaInicialForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModInvCargaInicialForm))
        Me.lblTema = New System.Windows.Forms.Label
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.clmClave = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmProducto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmLinea = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmUltimoCosto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCostoPromedio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmLote = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCaduca = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.clmFechaCaducidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmSeManejaPorLotes = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmProductoId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIdLinea = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.lblMensaje = New System.Windows.Forms.Label
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtClave = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblFecha = New System.Windows.Forms.Label
        Me.cmbAlmacen = New System.Windows.Forms.ComboBox
        Me.txtProducto = New System.Windows.Forms.TextBox
        Me.txtLinea = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTema
        '
        Me.lblTema.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTema.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTema.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTema.ForeColor = System.Drawing.Color.Transparent
        Me.lblTema.Location = New System.Drawing.Point(0, 0)
        Me.lblTema.Name = "lblTema"
        Me.lblTema.Size = New System.Drawing.Size(935, 29)
        Me.lblTema.TabIndex = 0
        Me.lblTema.Text = "ENTRADA DE INVENTARIO POR INICIO DE SISTEMA"
        Me.lblTema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeRows = False
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmClave, Me.clmProducto, Me.clmLinea, Me.clmCantidad, Me.clmUltimoCosto, Me.clmCostoPromedio, Me.clmLote, Me.clmCaduca, Me.clmFechaCaducidad, Me.clmSeManejaPorLotes, Me.clmProductoId, Me.clmIdLinea})
        Me.dgv.Location = New System.Drawing.Point(12, 93)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersVisible = False
        Me.dgv.Size = New System.Drawing.Size(911, 411)
        Me.dgv.TabIndex = 4
        '
        'clmClave
        '
        Me.clmClave.DataPropertyName = "Clave"
        Me.clmClave.HeaderText = "Cláve"
        Me.clmClave.Name = "clmClave"
        Me.clmClave.ReadOnly = True
        Me.clmClave.Width = 60
        '
        'clmProducto
        '
        Me.clmProducto.DataPropertyName = "Producto"
        Me.clmProducto.HeaderText = "Producto"
        Me.clmProducto.Name = "clmProducto"
        Me.clmProducto.ReadOnly = True
        Me.clmProducto.Width = 200
        '
        'clmLinea
        '
        Me.clmLinea.DataPropertyName = "Linea"
        Me.clmLinea.HeaderText = "Línea"
        Me.clmLinea.Name = "clmLinea"
        Me.clmLinea.ReadOnly = True
        Me.clmLinea.Width = 150
        '
        'clmCantidad
        '
        Me.clmCantidad.DataPropertyName = "Cantidad"
        DataGridViewCellStyle1.Format = "N3"
        Me.clmCantidad.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmCantidad.HeaderText = "Cantidad"
        Me.clmCantidad.Name = "clmCantidad"
        '
        'clmUltimoCosto
        '
        Me.clmUltimoCosto.DataPropertyName = "UltimoCosto"
        Me.clmUltimoCosto.HeaderText = "Ultimo Costo"
        Me.clmUltimoCosto.Name = "clmUltimoCosto"
        Me.clmUltimoCosto.Width = 80
        '
        'clmCostoPromedio
        '
        Me.clmCostoPromedio.DataPropertyName = "CostoPromedio"
        Me.clmCostoPromedio.HeaderText = "Costo Promedio"
        Me.clmCostoPromedio.Name = "clmCostoPromedio"
        Me.clmCostoPromedio.Width = 80
        '
        'clmLote
        '
        Me.clmLote.DataPropertyName = "Lote"
        Me.clmLote.HeaderText = "Lote"
        Me.clmLote.Name = "clmLote"
        '
        'clmCaduca
        '
        Me.clmCaduca.DataPropertyName = "Caduca"
        Me.clmCaduca.HeaderText = "Caduca"
        Me.clmCaduca.Name = "clmCaduca"
        Me.clmCaduca.ReadOnly = True
        Me.clmCaduca.Width = 50
        '
        'clmFechaCaducidad
        '
        Me.clmFechaCaducidad.DataPropertyName = "Caducidad"
        Me.clmFechaCaducidad.HeaderText = "Fecha Caducidad"
        Me.clmFechaCaducidad.Name = "clmFechaCaducidad"
        Me.clmFechaCaducidad.Width = 70
        '
        'clmSeManejaPorLotes
        '
        Me.clmSeManejaPorLotes.DataPropertyName = "SeManejaPorLotes"
        Me.clmSeManejaPorLotes.HeaderText = "SeManejaPorLotes"
        Me.clmSeManejaPorLotes.Name = "clmSeManejaPorLotes"
        Me.clmSeManejaPorLotes.ReadOnly = True
        Me.clmSeManejaPorLotes.Visible = False
        '
        'clmProductoId
        '
        Me.clmProductoId.DataPropertyName = "ProductoId"
        Me.clmProductoId.HeaderText = "ProductoId"
        Me.clmProductoId.Name = "clmProductoId"
        Me.clmProductoId.ReadOnly = True
        Me.clmProductoId.Visible = False
        '
        'clmIdLinea
        '
        Me.clmIdLinea.DataPropertyName = "IdLinea"
        Me.clmIdLinea.HeaderText = "IdLinea"
        Me.clmIdLinea.Name = "clmIdLinea"
        Me.clmIdLinea.ReadOnly = True
        Me.clmIdLinea.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.lblMensaje)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 510)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(911, 79)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Location = New System.Drawing.Point(830, 16)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 40)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblMensaje
        '
        Me.lblMensaje.Location = New System.Drawing.Point(6, 16)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(727, 40)
        Me.lblMensaje.TabIndex = 0
        Me.lblMensaje.Text = resources.GetString("lblMensaje.Text")
        Me.lblMensaje.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(749, 16)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 40)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Almacén:"
        '
        'txtClave
        '
        Me.txtClave.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtClave.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClave.Location = New System.Drawing.Point(69, 40)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(106, 20)
        Me.txtClave.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(758, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Fecha:"
        '
        'lblFecha
        '
        Me.lblFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(804, 40)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(119, 21)
        Me.lblFecha.TabIndex = 7
        Me.lblFecha.Text = "Label3"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbAlmacen
        '
        Me.cmbAlmacen.DisplayMember = "Descripcion"
        Me.cmbAlmacen.FormattingEnabled = True
        Me.cmbAlmacen.Location = New System.Drawing.Point(181, 40)
        Me.cmbAlmacen.Name = "cmbAlmacen"
        Me.cmbAlmacen.Size = New System.Drawing.Size(355, 21)
        Me.cmbAlmacen.TabIndex = 3
        Me.cmbAlmacen.ValueMember = "Codigo"
        '
        'txtProducto
        '
        Me.txtProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProducto.Location = New System.Drawing.Point(69, 67)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(208, 20)
        Me.txtProducto.TabIndex = 8
        '
        'txtLinea
        '
        Me.txtLinea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLinea.Location = New System.Drawing.Point(327, 67)
        Me.txtLinea.Name = "txtLinea"
        Me.txtLinea.Size = New System.Drawing.Size(209, 20)
        Me.txtLinea.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Producto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(283, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Línea:"
        '
        'ModInvCargaInicialForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 601)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLinea)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbAlmacen)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.lblTema)
        Me.MaximizeBox = False
        Me.Name = "ModInvCargaInicialForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entrada de Inventario por Inicio de Sistema"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents lblTema As System.Windows.Forms.Label
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents cmbAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtProducto As System.Windows.Forms.TextBox
    Friend WithEvents txtLinea As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents clmClave As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmLinea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmUltimoCosto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCostoPromedio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmLote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCaduca As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents clmFechaCaducidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSeManejaPorLotes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmProductoId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdLinea As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
