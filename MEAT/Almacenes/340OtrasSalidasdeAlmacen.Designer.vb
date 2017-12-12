<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _340OtrasSalidasdeAlmacen
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DgvProductos = New System.Windows.Forms.DataGridView
        Me.clmCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmProducto = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.ProductosVistaC = New ClasesNegocio.ProductosVistaCollectionClass
        Me.clmCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmUltimoCosto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmImporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtImporte = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.CmbMovimiento = New System.Windows.Forms.ComboBox
        Me.txtRecibe = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtObservaciones = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtEntrega = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.dtFechaAlta = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtFolio = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.CmbAlmacen = New System.Windows.Forms.ComboBox
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.mtb = New MiToolBar.miToolBar
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvProductos)
        Me.GroupBox1.Controls.Add(Me.txtImporte)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(59, 239)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(656, 224)
        Me.GroupBox1.TabIndex = 165
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de Salida :"
        '
        'DgvProductos
        '
        Me.DgvProductos.AllowUserToDeleteRows = False
        Me.DgvProductos.AllowUserToResizeRows = False
        Me.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmCodigo, Me.clmProducto, Me.clmCantidad, Me.ClmUnidad, Me.clmUltimoCosto, Me.clmImporte})
        Me.DgvProductos.Location = New System.Drawing.Point(6, 19)
        Me.DgvProductos.Name = "DgvProductos"
        Me.DgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvProductos.Size = New System.Drawing.Size(644, 168)
        Me.DgvProductos.TabIndex = 5
        '
        'clmCodigo
        '
        Me.clmCodigo.DataPropertyName = "ProductoId"
        Me.clmCodigo.HeaderText = "Codigo"
        Me.clmCodigo.Name = "clmCodigo"
        Me.clmCodigo.Width = 55
        '
        'clmProducto
        '
        Me.clmProducto.DataPropertyName = "ProductoId"
        Me.clmProducto.DataSource = Me.ProductosVistaC
        Me.clmProducto.DisplayMember = "Descripcion"
        Me.clmProducto.HeaderText = "Producto"
        Me.clmProducto.Name = "clmProducto"
        Me.clmProducto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmProducto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clmProducto.ValueMember = "Codigo"
        Me.clmProducto.Width = 150
        '
        'ProductosVistaC
        '
        Me.ProductosVistaC.AllowEdit = True
        Me.ProductosVistaC.AllowNew = True
        Me.ProductosVistaC.AllowRemove = True
        Me.ProductosVistaC.Name = ""
        Me.ProductosVistaC.RaiseListChangedEvents = True
        '
        'clmCantidad
        '
        Me.clmCantidad.DataPropertyName = "Cantidad"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N3"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.clmCantidad.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmCantidad.HeaderText = "Cantidad"
        Me.clmCantidad.Name = "clmCantidad"
        '
        'ClmUnidad
        '
        Me.ClmUnidad.DataPropertyName = "UnidadMedida"
        Me.ClmUnidad.HeaderText = "Unidad"
        Me.ClmUnidad.Name = "ClmUnidad"
        Me.ClmUnidad.ReadOnly = True
        '
        'clmUltimoCosto
        '
        Me.clmUltimoCosto.DataPropertyName = "Costo"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.clmUltimoCosto.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmUltimoCosto.HeaderText = "Costo"
        Me.clmUltimoCosto.Name = "clmUltimoCosto"
        '
        'clmImporte
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.clmImporte.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmImporte.HeaderText = "Importe"
        Me.clmImporte.Name = "clmImporte"
        Me.clmImporte.ReadOnly = True
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(550, 198)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.ReadOnly = True
        Me.txtImporte.Size = New System.Drawing.Size(100, 20)
        Me.txtImporte.TabIndex = 177
        Me.txtImporte.Text = "0"
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(460, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 176
        Me.Label4.Text = "Importe Total :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 164
        Me.Label3.Text = "Movimiento :"
        '
        'CmbMovimiento
        '
        Me.CmbMovimiento.DisplayMember = "Descripcion"
        Me.CmbMovimiento.FormattingEnabled = True
        Me.CmbMovimiento.Items.AddRange(New Object() {"OTRAS SALIDAS", "SALIDAS POR AJUSTE DE INVENTARIO"})
        Me.CmbMovimiento.Location = New System.Drawing.Point(143, 96)
        Me.CmbMovimiento.Name = "CmbMovimiento"
        Me.CmbMovimiento.Size = New System.Drawing.Size(282, 21)
        Me.CmbMovimiento.TabIndex = 1
        Me.CmbMovimiento.ValueMember = "Codigo"
        '
        'txtRecibe
        '
        Me.txtRecibe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRecibe.Location = New System.Drawing.Point(143, 148)
        Me.txtRecibe.MaxLength = 120
        Me.txtRecibe.Name = "txtRecibe"
        Me.txtRecibe.Size = New System.Drawing.Size(373, 20)
        Me.txtRecibe.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 161
        Me.Label2.Text = "Recibe :"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Location = New System.Drawing.Point(143, 174)
        Me.txtObservaciones.MaxLength = 250
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(373, 59)
        Me.txtObservaciones.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 159
        Me.Label1.Text = "Observaciones :"
        '
        'txtEntrega
        '
        Me.txtEntrega.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEntrega.Location = New System.Drawing.Point(143, 122)
        Me.txtEntrega.MaxLength = 120
        Me.txtEntrega.Name = "txtEntrega"
        Me.txtEntrega.Size = New System.Drawing.Size(373, 20)
        Me.txtEntrega.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(56, 124)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 157
        Me.Label11.Text = "Entrega :"
        '
        'dtFechaAlta
        '
        Me.dtFechaAlta.Enabled = False
        Me.dtFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaAlta.Location = New System.Drawing.Point(325, 44)
        Me.dtFechaAlta.Name = "dtFechaAlta"
        Me.dtFechaAlta.Size = New System.Drawing.Size(100, 20)
        Me.dtFechaAlta.TabIndex = 155
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(276, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 154
        Me.Label6.Text = "Fecha :"
        '
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(143, 45)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.ReadOnly = True
        Me.txtFolio.Size = New System.Drawing.Size(100, 20)
        Me.txtFolio.TabIndex = 153
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 152
        Me.Label5.Text = "Folio :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(56, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 151
        Me.Label7.Text = "Almacén:"
        '
        'CmbAlmacen
        '
        Me.CmbAlmacen.DisplayMember = "Descripcion"
        Me.CmbAlmacen.FormattingEnabled = True
        Me.CmbAlmacen.Location = New System.Drawing.Point(143, 70)
        Me.CmbAlmacen.Name = "CmbAlmacen"
        Me.CmbAlmacen.Size = New System.Drawing.Size(282, 21)
        Me.CmbAlmacen.TabIndex = 0
        Me.CmbAlmacen.ValueMember = "Codigo"
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
        Me.lblTitulo.Size = New System.Drawing.Size(684, 29)
        Me.lblTitulo.TabIndex = 147
        Me.lblTitulo.Text = "OTRAS SALIDAS DE ALMACÉN"
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
        Me.mtb.ImageButtonSize = MiToolBar.miToolBar.ImageButtonSizeEnum.de32
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
        Me.mtb.Size = New System.Drawing.Size(50, 475)
        Me.mtb.TabIndex = 6
        '
        '_340OtrasSalidasdeAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 475)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmbMovimiento)
        Me.Controls.Add(Me.txtRecibe)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEntrega)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dtFechaAlta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CmbAlmacen)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.mtb)
        Me.Name = "_340OtrasSalidasdeAlmacen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Otras Salidas de Almacén"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmbMovimiento As System.Windows.Forms.ComboBox
    Friend WithEvents txtRecibe As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEntrega As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtFechaAlta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CmbAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DgvProductos As System.Windows.Forms.DataGridView
    Friend WithEvents mtb As MiToolBar.miToolBar
    Friend WithEvents ProductosVistaC As ClasesNegocio.ProductosVistaCollectionClass
    Friend WithEvents clmCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmProducto As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents clmCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmUltimoCosto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmImporte As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
