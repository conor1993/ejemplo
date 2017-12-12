<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCapturaInvFisico
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.mtb = New MEAToolBar.MEAToolBar()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbAlmacenes = New System.Windows.Forms.ComboBox()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DgvProductos = New System.Windows.Forms.DataGridView()
        Me.clmAlmacenId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmProductoId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCodBarra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPdDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmUnidadMedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmIdLinea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmGuardado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbLineas = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAjuste = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbNombre = New System.Windows.Forms.RadioButton()
        Me.rbId = New System.Windows.Forms.RadioButton()
        Me.rbCodBarra = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblCapturados = New System.Windows.Forms.Label()
        Me.lblPorCapturar = New System.Windows.Forms.Label()
        CType(Me.DgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbLineas.SuspendLayout()
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
        Me.mtb.MostrarBuscar = True
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = True
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 658)
        Me.mtb.TabIndex = 51
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(757, 32)
        Me.Label17.TabIndex = 52
        Me.Label17.Text = "Captura de Inventario Físico"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Almacén:"
        '
        'CmbAlmacenes
        '
        Me.CmbAlmacenes.FormattingEnabled = True
        Me.CmbAlmacenes.Location = New System.Drawing.Point(117, 40)
        Me.CmbAlmacenes.Name = "CmbAlmacenes"
        Me.CmbAlmacenes.Size = New System.Drawing.Size(295, 21)
        Me.CmbAlmacenes.TabIndex = 54
        '
        'DtpFecha
        '
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(117, 67)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(102, 20)
        Me.DtpFecha.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Fecha :"
        '
        'DgvProductos
        '
        Me.DgvProductos.AllowUserToAddRows = False
        Me.DgvProductos.AllowUserToDeleteRows = False
        Me.DgvProductos.AllowUserToResizeColumns = False
        Me.DgvProductos.AllowUserToResizeRows = False
        Me.DgvProductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmAlmacenId, Me.clmProductoId, Me.clmCodBarra, Me.clmPdDescripcion, Me.clmUnidadMedida, Me.clmCantidad, Me.clmIdLinea, Me.clmGuardado})
        Me.DgvProductos.Location = New System.Drawing.Point(12, 19)
        Me.DgvProductos.Name = "DgvProductos"
        Me.DgvProductos.RowHeadersVisible = False
        Me.DgvProductos.Size = New System.Drawing.Size(712, 291)
        Me.DgvProductos.TabIndex = 57
        '
        'clmAlmacenId
        '
        Me.clmAlmacenId.DataPropertyName = "AlmacenId"
        Me.clmAlmacenId.HeaderText = "AlmacenId"
        Me.clmAlmacenId.Name = "clmAlmacenId"
        Me.clmAlmacenId.ReadOnly = True
        Me.clmAlmacenId.Visible = False
        '
        'clmProductoId
        '
        Me.clmProductoId.DataPropertyName = "ProductoID"
        Me.clmProductoId.FillWeight = 50.0!
        Me.clmProductoId.HeaderText = "ProductoId"
        Me.clmProductoId.Name = "clmProductoId"
        Me.clmProductoId.ReadOnly = True
        Me.clmProductoId.Visible = False
        '
        'clmCodBarra
        '
        Me.clmCodBarra.FillWeight = 130.0!
        Me.clmCodBarra.HeaderText = "CodBarra"
        Me.clmCodBarra.Name = "clmCodBarra"
        Me.clmCodBarra.ReadOnly = True
        '
        'clmPdDescripcion
        '
        Me.clmPdDescripcion.DataPropertyName = "PdDescripcion"
        Me.clmPdDescripcion.FillWeight = 200.0!
        Me.clmPdDescripcion.HeaderText = "Producto"
        Me.clmPdDescripcion.Name = "clmPdDescripcion"
        Me.clmPdDescripcion.ReadOnly = True
        '
        'clmUnidadMedida
        '
        Me.clmUnidadMedida.DataPropertyName = "UMDescripcion"
        Me.clmUnidadMedida.FillWeight = 60.0!
        Me.clmUnidadMedida.HeaderText = "Unidad de Medida"
        Me.clmUnidadMedida.Name = "clmUnidadMedida"
        Me.clmUnidadMedida.ReadOnly = True
        '
        'clmCantidad
        '
        Me.clmCantidad.DataPropertyName = "Cantidad"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N3"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.clmCantidad.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmCantidad.FillWeight = 60.0!
        Me.clmCantidad.HeaderText = "Cantidad"
        Me.clmCantidad.Name = "clmCantidad"
        '
        'clmIdLinea
        '
        Me.clmIdLinea.HeaderText = "Idlinea"
        Me.clmIdLinea.Name = "clmIdLinea"
        Me.clmIdLinea.Visible = False
        '
        'clmGuardado
        '
        DataGridViewCellStyle2.NullValue = "N"
        Me.clmGuardado.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmGuardado.HeaderText = "Guardado"
        Me.clmGuardado.Name = "clmGuardado"
        Me.clmGuardado.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvProductos)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 250)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(730, 316)
        Me.GroupBox1.TabIndex = 58
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de Productos"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "AlmacenId"
        Me.DataGridViewTextBoxColumn1.HeaderText = "AlmacenId"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ProductoID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ProductoId"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PdDescripcion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Producto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 180
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "UMDescripcion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Unidad de Medida"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Cantidad"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N3"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'txtProducto
        '
        Me.txtProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProducto.Location = New System.Drawing.Point(112, 222)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(380, 20)
        Me.txtProducto.TabIndex = 59
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Producto:"
        Me.Label3.Visible = False
        '
        'gbLineas
        '
        Me.gbLineas.Controls.Add(Me.Panel1)
        Me.gbLineas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbLineas.Location = New System.Drawing.Point(56, 93)
        Me.gbLineas.Name = "gbLineas"
        Me.gbLineas.Size = New System.Drawing.Size(507, 96)
        Me.gbLineas.TabIndex = 61
        Me.gbLineas.TabStop = False
        Me.gbLineas.Text = "Lineas"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Location = New System.Drawing.Point(6, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(495, 68)
        Me.Panel1.TabIndex = 0
        '
        'btnAjuste
        '
        Me.btnAjuste.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjuste.Location = New System.Drawing.Point(358, 598)
        Me.btnAjuste.Name = "btnAjuste"
        Me.btnAjuste.Size = New System.Drawing.Size(134, 35)
        Me.btnAjuste.TabIndex = 62
        Me.btnAjuste.Text = "Realizar Ajuste"
        Me.btnAjuste.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(65, 630)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(287, 13)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "*Nota: Se omitiran los articulos que esten vacios."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Buscar por:"
        '
        'rbNombre
        '
        Me.rbNombre.AutoSize = True
        Me.rbNombre.Location = New System.Drawing.Point(148, 196)
        Me.rbNombre.Name = "rbNombre"
        Me.rbNombre.Size = New System.Drawing.Size(62, 17)
        Me.rbNombre.TabIndex = 65
        Me.rbNombre.TabStop = True
        Me.rbNombre.Text = "Nombre"
        Me.rbNombre.UseVisualStyleBackColor = True
        '
        'rbId
        '
        Me.rbId.AutoSize = True
        Me.rbId.Location = New System.Drawing.Point(400, 196)
        Me.rbId.Name = "rbId"
        Me.rbId.Size = New System.Drawing.Size(34, 17)
        Me.rbId.TabIndex = 999
        Me.rbId.TabStop = True
        Me.rbId.Text = "Id"
        Me.rbId.UseVisualStyleBackColor = True
        Me.rbId.Visible = False
        '
        'rbCodBarra
        '
        Me.rbCodBarra.AutoSize = True
        Me.rbCodBarra.Location = New System.Drawing.Point(247, 196)
        Me.rbCodBarra.Name = "rbCodBarra"
        Me.rbCodBarra.Size = New System.Drawing.Size(105, 17)
        Me.rbCodBarra.TabIndex = 67
        Me.rbCodBarra.TabStop = True
        Me.rbCodBarra.Text = "Codigo de barras"
        Me.rbCodBarra.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(173, 573)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 13)
        Me.Label6.TabIndex = 1000
        Me.Label6.Text = "Cantidad Total:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(340, 573)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 13)
        Me.Label7.TabIndex = 1001
        Me.Label7.Text = "Cantidad Capturados:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(534, 573)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 13)
        Me.Label8.TabIndex = 1002
        Me.Label8.Text = "Cantidad Por Capturar:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(273, 573)
        Me.lblTotal.MaximumSize = New System.Drawing.Size(40, 13)
        Me.lblTotal.MinimumSize = New System.Drawing.Size(50, 13)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(50, 13)
        Me.lblTotal.TabIndex = 1003
        Me.lblTotal.Text = "0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCapturados
        '
        Me.lblCapturados.AutoSize = True
        Me.lblCapturados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapturados.Location = New System.Drawing.Point(466, 573)
        Me.lblCapturados.MaximumSize = New System.Drawing.Size(40, 13)
        Me.lblCapturados.MinimumSize = New System.Drawing.Size(50, 13)
        Me.lblCapturados.Name = "lblCapturados"
        Me.lblCapturados.Size = New System.Drawing.Size(50, 13)
        Me.lblCapturados.TabIndex = 1004
        Me.lblCapturados.Text = "0"
        Me.lblCapturados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPorCapturar
        '
        Me.lblPorCapturar.AutoSize = True
        Me.lblPorCapturar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPorCapturar.Location = New System.Drawing.Point(667, 573)
        Me.lblPorCapturar.MaximumSize = New System.Drawing.Size(40, 13)
        Me.lblPorCapturar.MinimumSize = New System.Drawing.Size(50, 13)
        Me.lblPorCapturar.Name = "lblPorCapturar"
        Me.lblPorCapturar.Size = New System.Drawing.Size(50, 13)
        Me.lblPorCapturar.TabIndex = 1005
        Me.lblPorCapturar.Text = "0"
        Me.lblPorCapturar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmCapturaInvFisico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 658)
        Me.Controls.Add(Me.lblPorCapturar)
        Me.Controls.Add(Me.lblCapturados)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.rbCodBarra)
        Me.Controls.Add(Me.rbId)
        Me.Controls.Add(Me.rbNombre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnAjuste)
        Me.Controls.Add(Me.gbLineas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DtpFecha)
        Me.Controls.Add(Me.CmbAlmacenes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.MaximizeBox = False
        Me.Name = "FrmCapturaInvFisico"
        Me.Text = "Captura de Inventario Físico"
        CType(Me.DgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.gbLineas.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbAlmacenes As System.Windows.Forms.ComboBox
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DgvProductos As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbLineas As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnAjuste As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rbNombre As System.Windows.Forms.RadioButton
    Friend WithEvents rbId As System.Windows.Forms.RadioButton
    Friend WithEvents rbCodBarra As System.Windows.Forms.RadioButton
    Friend WithEvents clmAlmacenId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmProductoId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCodBarra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPdDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmUnidadMedida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdLinea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmGuardado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblCapturados As System.Windows.Forms.Label
    Friend WithEvents lblPorCapturar As System.Windows.Forms.Label
End Class
