<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CatAlmRegOtraEntradaAlmacen
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
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbMovimiento = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblEstatus = New System.Windows.Forms.Label()
        Me.txtAlmancen = New System.Windows.Forms.TextBox()
        Me.txtPlaza = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.CódigoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.clmLote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UMColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTPFecha = New System.Windows.Forms.DateTimePicker()
        Me.TxtRecibe = New System.Windows.Forms.TextBox()
        Me.CmbAlmacen = New System.Windows.Forms.ComboBox()
        Me.AlmacenCol = New ClasesNegocio.AlmacenCollectionClass()
        Me.TxtEntrga = New System.Windows.Forms.TextBox()
        Me.TxtFolio = New System.Windows.Forms.TextBox()
        Me.CmbPlaza = New System.Windows.Forms.ComboBox()
        Me.PlazaCol = New ClasesNegocio.PlazaCollectionClass()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mtb = New MEAToolBar.MEAToolBar()
        Me.ProductoCollectionClass1 = New ClasesNegocio.ProductoCollectionClass()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Label17.Size = New System.Drawing.Size(828, 29)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "REGISTRO DE OTRAS ENTRADAS A ALMACEN"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.cmbMovimiento)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.lblEstatus)
        Me.Panel1.Controls.Add(Me.txtAlmancen)
        Me.Panel1.Controls.Add(Me.txtPlaza)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.DTPFecha)
        Me.Panel1.Controls.Add(Me.TxtRecibe)
        Me.Panel1.Controls.Add(Me.CmbAlmacen)
        Me.Panel1.Controls.Add(Me.TxtEntrga)
        Me.Panel1.Controls.Add(Me.TxtFolio)
        Me.Panel1.Controls.Add(Me.CmbPlaza)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(56, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(816, 585)
        Me.Panel1.TabIndex = 2
        '
        'cmbMovimiento
        '
        Me.cmbMovimiento.FormattingEnabled = True
        Me.cmbMovimiento.Location = New System.Drawing.Point(106, 96)
        Me.cmbMovimiento.Name = "cmbMovimiento"
        Me.cmbMovimiento.Size = New System.Drawing.Size(429, 21)
        Me.cmbMovimiento.TabIndex = 108
        Me.cmbMovimiento.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 13)
        Me.Label8.TabIndex = 107
        Me.Label8.Text = "Tipo Movimiento:"
        Me.Label8.Visible = False
        '
        'lblEstatus
        '
        Me.lblEstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(605, 4)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(142, 21)
        Me.lblEstatus.TabIndex = 106
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAlmancen
        '
        Me.txtAlmancen.Location = New System.Drawing.Point(106, 70)
        Me.txtAlmancen.Name = "txtAlmancen"
        Me.txtAlmancen.Size = New System.Drawing.Size(55, 20)
        Me.txtAlmancen.TabIndex = 105
        '
        'txtPlaza
        '
        Me.txtPlaza.Location = New System.Drawing.Point(106, 17)
        Me.txtPlaza.Name = "txtPlaza"
        Me.txtPlaza.Size = New System.Drawing.Size(55, 20)
        Me.txtPlaza.TabIndex = 104
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TxtTotal)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.DataGrid)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 176)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(806, 406)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de Movimiento"
        '
        'TxtTotal
        '
        Me.TxtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTotal.Location = New System.Drawing.Point(688, 382)
        Me.TxtTotal.MaxLength = 10
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(112, 20)
        Me.TxtTotal.TabIndex = 1
        Me.TxtTotal.Text = "0"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(648, 385)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "Total:"
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CódigoColumn, Me.ProductoColumn, Me.clmLote, Me.CantidadColumn, Me.UMColumn, Me.CostoColumn, Me.ImporteColumn})
        Me.DataGrid.Location = New System.Drawing.Point(6, 17)
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.Size = New System.Drawing.Size(800, 359)
        Me.DataGrid.TabIndex = 0
        '
        'CódigoColumn
        '
        Me.CódigoColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CódigoColumn.HeaderText = "Código"
        Me.CódigoColumn.Name = "CódigoColumn"
        Me.CódigoColumn.Width = 65
        '
        'ProductoColumn
        '
        Me.ProductoColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ProductoColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.ProductoColumn.HeaderText = "Producto"
        Me.ProductoColumn.Name = "ProductoColumn"
        Me.ProductoColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductoColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ProductoColumn.Width = 75
        '
        'clmLote
        '
        Me.clmLote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmLote.HeaderText = "Lote"
        Me.clmLote.Name = "clmLote"
        Me.clmLote.Visible = False
        '
        'CantidadColumn
        '
        Me.CantidadColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CantidadColumn.HeaderText = "Cantidad"
        Me.CantidadColumn.Name = "CantidadColumn"
        Me.CantidadColumn.Width = 74
        '
        'UMColumn
        '
        Me.UMColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.UMColumn.HeaderText = "Unidad Medida"
        Me.UMColumn.Name = "UMColumn"
        Me.UMColumn.ReadOnly = True
        Me.UMColumn.Width = 96
        '
        'CostoColumn
        '
        Me.CostoColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CostoColumn.HeaderText = "Costo"
        Me.CostoColumn.Name = "CostoColumn"
        Me.CostoColumn.Width = 59
        '
        'ImporteColumn
        '
        Me.ImporteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ImporteColumn.HeaderText = "Importe"
        Me.ImporteColumn.Name = "ImporteColumn"
        Me.ImporteColumn.ReadOnly = True
        Me.ImporteColumn.Width = 67
        '
        'DTPFecha
        '
        Me.DTPFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecha.Location = New System.Drawing.Point(248, 43)
        Me.DTPFecha.Name = "DTPFecha"
        Me.DTPFecha.Size = New System.Drawing.Size(101, 20)
        Me.DTPFecha.TabIndex = 6
        '
        'TxtRecibe
        '
        Me.TxtRecibe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtRecibe.Location = New System.Drawing.Point(106, 150)
        Me.TxtRecibe.MaxLength = 30
        Me.TxtRecibe.Name = "TxtRecibe"
        Me.TxtRecibe.Size = New System.Drawing.Size(429, 20)
        Me.TxtRecibe.TabIndex = 5
        '
        'CmbAlmacen
        '
        Me.CmbAlmacen.DataSource = Me.AlmacenCol
        Me.CmbAlmacen.DisplayMember = "Descripcion"
        Me.CmbAlmacen.FormattingEnabled = True
        Me.CmbAlmacen.Location = New System.Drawing.Point(167, 69)
        Me.CmbAlmacen.Name = "CmbAlmacen"
        Me.CmbAlmacen.Size = New System.Drawing.Size(368, 21)
        Me.CmbAlmacen.TabIndex = 3
        Me.CmbAlmacen.ValueMember = "Codigo"
        '
        'AlmacenCol
        '
        Me.AlmacenCol.AllowEdit = True
        Me.AlmacenCol.AllowNew = True
        Me.AlmacenCol.AllowRemove = True
        Me.AlmacenCol.Name = ""
        Me.AlmacenCol.RaiseListChangedEvents = True
        Me.AlmacenCol.Tipo = ClasesNegocio.AlmacenEnum.ALMACEN
        '
        'TxtEntrga
        '
        Me.TxtEntrga.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtEntrga.Location = New System.Drawing.Point(106, 123)
        Me.TxtEntrga.MaxLength = 30
        Me.TxtEntrga.Name = "TxtEntrga"
        Me.TxtEntrga.Size = New System.Drawing.Size(429, 20)
        Me.TxtEntrga.TabIndex = 4
        '
        'TxtFolio
        '
        Me.TxtFolio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtFolio.Location = New System.Drawing.Point(106, 43)
        Me.TxtFolio.MaxLength = 6
        Me.TxtFolio.Name = "TxtFolio"
        Me.TxtFolio.Size = New System.Drawing.Size(90, 20)
        Me.TxtFolio.TabIndex = 2
        '
        'CmbPlaza
        '
        Me.CmbPlaza.DataSource = Me.PlazaCol
        Me.CmbPlaza.DisplayMember = "Descripcion"
        Me.CmbPlaza.FormattingEnabled = True
        Me.CmbPlaza.IntegralHeight = False
        Me.CmbPlaza.Location = New System.Drawing.Point(167, 17)
        Me.CmbPlaza.Name = "CmbPlaza"
        Me.CmbPlaza.Size = New System.Drawing.Size(368, 21)
        Me.CmbPlaza.TabIndex = 1
        Me.CmbPlaza.ValueMember = "Codigo"
        '
        'PlazaCol
        '
        Me.PlazaCol.AllowEdit = True
        Me.PlazaCol.AllowNew = True
        Me.PlazaCol.AllowRemove = True
        Me.PlazaCol.MaximoElementosSeleccionados = 1
        Me.PlazaCol.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.PlazaCol.MostrarAlertas = False
        Me.PlazaCol.Name = ""
        Me.PlazaCol.RaiseListChangedEvents = True
        Me.PlazaCol.Transaction = Nothing
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(202, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Fecha:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Recibe:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Entrega:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Almacén:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Folio:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Plaza:"
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
        Me.mtb.Size = New System.Drawing.Size(50, 629)
        Me.mtb.TabIndex = 0
        '
        'ProductoCollectionClass1
        '
        Me.ProductoCollectionClass1.AllowEdit = True
        Me.ProductoCollectionClass1.AllowNew = True
        Me.ProductoCollectionClass1.AllowRemove = True
        Me.ProductoCollectionClass1.MaximoElementosSeleccionados = 1
        Me.ProductoCollectionClass1.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.ProductoCollectionClass1.MostrarAlertas = False
        Me.ProductoCollectionClass1.Name = ""
        Me.ProductoCollectionClass1.RaiseListChangedEvents = True
        Me.ProductoCollectionClass1.Transaction = Nothing
        '
        'CatAlmRegOtraEntradaAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 629)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.MinimumSize = New System.Drawing.Size(658, 494)
        Me.Name = "CatAlmRegOtraEntradaAlmacen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Otras Entradas a Almacen"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DTPFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtRecibe As System.Windows.Forms.TextBox
    Friend WithEvents CmbAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents TxtEntrga As System.Windows.Forms.TextBox
    Friend WithEvents TxtFolio As System.Windows.Forms.TextBox
    Friend WithEvents CmbPlaza As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PlazaCol As ClasesNegocio.PlazaCollectionClass
    Friend WithEvents AlmacenCol As ClasesNegocio.AlmacenCollectionClass
    Friend WithEvents txtAlmancen As System.Windows.Forms.TextBox
    Friend WithEvents txtPlaza As System.Windows.Forms.TextBox
    Friend WithEvents ProductoCollectionClass1 As ClasesNegocio.ProductoCollectionClass
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents CódigoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductoColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents clmLote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UMColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbMovimiento As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
