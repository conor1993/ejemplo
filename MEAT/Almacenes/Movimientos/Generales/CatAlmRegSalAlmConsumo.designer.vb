<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CatAlmRegSalAlmConsumo
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
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PlazaCol = New ClasesNegocio.PlazaCollectionClass
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.TxtObservaciones = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtTotal = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.DataGrid = New System.Windows.Forms.DataGridView
        Me.CódigoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProductoColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.CantidadColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmLote = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UMColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ImporteColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AplicacionColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.CentroDeCostosCollectionClass1 = New ClasesNegocio.CentroDeCostosCollectionClass
        Me.DTPFecha = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtRecibe = New System.Windows.Forms.TextBox
        Me.TxtEntrega = New System.Windows.Forms.TextBox
        Me.TxtFolio = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.AlmacenCol = New ClasesNegocio.AlmacenCollectionClass
        Me.Label17 = New System.Windows.Forms.Label
        Me.cmbPlaza = New IntegraLab.Controles.ComboBoxMejorado
        Me.txtPlaza = New IntegraLab.Controles.TextBoxMejorado
        Me.cmbAlmacen = New IntegraLab.Controles.ComboBoxMejorado
        Me.txtAlmacen = New IntegraLab.Controles.TextBoxMejorado
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 505)
        Me.mtb.TabIndex = 46
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.cmbAlmacen)
        Me.Panel1.Controls.Add(Me.txtAlmacen)
        Me.Panel1.Controls.Add(Me.cmbPlaza)
        Me.Panel1.Controls.Add(Me.txtPlaza)
        Me.Panel1.Controls.Add(Me.lblEstatus)
        Me.Panel1.Controls.Add(Me.TxtObservaciones)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.DTPFecha)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TxtRecibe)
        Me.Panel1.Controls.Add(Me.TxtEntrega)
        Me.Panel1.Controls.Add(Me.TxtFolio)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(59, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(711, 461)
        Me.Panel1.TabIndex = 47
        '
        'PlazaCol
        '
        Me.PlazaCol.AllowEdit = True
        Me.PlazaCol.AllowNew = True
        Me.PlazaCol.AllowRemove = True
        Me.PlazaCol.Name = ""
        Me.PlazaCol.RaiseListChangedEvents = True
        '
        'lblEstatus
        '
        Me.lblEstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(584, 0)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(109, 21)
        Me.lblEstatus.TabIndex = 83
        Me.lblEstatus.Text = "ESTATUS"
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtObservaciones.Location = New System.Drawing.Point(100, 355)
        Me.TxtObservaciones.MaxLength = 250
        Me.TxtObservaciones.Multiline = True
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.Size = New System.Drawing.Size(505, 95)
        Me.TxtObservaciones.TabIndex = 81
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 358)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Observaciones:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TxtTotal)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.DataGrid)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 169)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(677, 180)
        Me.GroupBox1.TabIndex = 80
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de Movimiento"
        '
        'TxtTotal
        '
        Me.TxtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTotal.Location = New System.Drawing.Point(532, 156)
        Me.TxtTotal.MaximumSize = New System.Drawing.Size(160, 20)
        Me.TxtTotal.MaxLength = 10
        Me.TxtTotal.MinimumSize = New System.Drawing.Size(80, 20)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(113, 20)
        Me.TxtTotal.TabIndex = 1
        Me.TxtTotal.Text = "0"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(492, 159)
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
        Me.DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CódigoColumn, Me.ProductoColumn, Me.CantidadColumn, Me.clmLote, Me.UMColumn, Me.CostoColumn, Me.ImporteColumn, Me.AplicacionColumn})
        Me.DataGrid.Location = New System.Drawing.Point(0, 35)
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.Size = New System.Drawing.Size(665, 121)
        Me.DataGrid.TabIndex = 0
        '
        'CódigoColumn
        '
        Me.CódigoColumn.HeaderText = "Código"
        Me.CódigoColumn.Name = "CódigoColumn"
        Me.CódigoColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'ProductoColumn
        '
        Me.ProductoColumn.HeaderText = "Producto"
        Me.ProductoColumn.Name = "ProductoColumn"
        Me.ProductoColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductoColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ProductoColumn.Width = 200
        '
        'CantidadColumn
        '
        Me.CantidadColumn.HeaderText = "Cantidad"
        Me.CantidadColumn.Name = "CantidadColumn"
        '
        'clmLote
        '
        Me.clmLote.HeaderText = "Lote"
        Me.clmLote.Name = "clmLote"
        '
        'UMColumn
        '
        Me.UMColumn.HeaderText = "Unidad Medida"
        Me.UMColumn.Name = "UMColumn"
        Me.UMColumn.ReadOnly = True
        Me.UMColumn.Width = 120
        '
        'CostoColumn
        '
        Me.CostoColumn.HeaderText = "Costo"
        Me.CostoColumn.Name = "CostoColumn"
        Me.CostoColumn.ReadOnly = True
        '
        'ImporteColumn
        '
        Me.ImporteColumn.HeaderText = "Importe"
        Me.ImporteColumn.Name = "ImporteColumn"
        Me.ImporteColumn.ReadOnly = True
        '
        'AplicacionColumn
        '
        Me.AplicacionColumn.DataSource = Me.CentroDeCostosCollectionClass1
        Me.AplicacionColumn.DisplayMember = "Descripcion"
        Me.AplicacionColumn.HeaderText = "Aplicación de Gasto"
        Me.AplicacionColumn.Name = "AplicacionColumn"
        Me.AplicacionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AplicacionColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.AplicacionColumn.ValueMember = "Codigo"
        Me.AplicacionColumn.Width = 130
        '
        'CentroDeCostosCollectionClass1
        '
        Me.CentroDeCostosCollectionClass1.AllowEdit = True
        Me.CentroDeCostosCollectionClass1.AllowNew = True
        Me.CentroDeCostosCollectionClass1.AllowRemove = True
        Me.CentroDeCostosCollectionClass1.MaximoElementosSeleccionados = 1
        Me.CentroDeCostosCollectionClass1.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.CentroDeCostosCollectionClass1.MostrarAlertas = False
        Me.CentroDeCostosCollectionClass1.Name = Nothing
        Me.CentroDeCostosCollectionClass1.RaiseListChangedEvents = True
        '
        'DTPFecha
        '
        Me.DTPFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTPFecha.Enabled = False
        Me.DTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecha.Location = New System.Drawing.Point(387, 54)
        Me.DTPFecha.Name = "DTPFecha"
        Me.DTPFecha.Size = New System.Drawing.Size(112, 20)
        Me.DTPFecha.TabIndex = 78
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(321, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "Fecha"
        '
        'TxtRecibe
        '
        Me.TxtRecibe.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtRecibe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtRecibe.Location = New System.Drawing.Point(70, 134)
        Me.TxtRecibe.MaxLength = 30
        Me.TxtRecibe.Name = "TxtRecibe"
        Me.TxtRecibe.Size = New System.Drawing.Size(429, 20)
        Me.TxtRecibe.TabIndex = 71
        '
        'TxtEntrega
        '
        Me.TxtEntrega.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtEntrega.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtEntrega.Location = New System.Drawing.Point(70, 107)
        Me.TxtEntrega.MaxLength = 30
        Me.TxtEntrega.Name = "TxtEntrega"
        Me.TxtEntrega.Size = New System.Drawing.Size(429, 20)
        Me.TxtEntrega.TabIndex = 70
        '
        'TxtFolio
        '
        Me.TxtFolio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtFolio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtFolio.Enabled = False
        Me.TxtFolio.Location = New System.Drawing.Point(70, 54)
        Me.TxtFolio.MaximumSize = New System.Drawing.Size(180, 20)
        Me.TxtFolio.MaxLength = 6
        Me.TxtFolio.Name = "TxtFolio"
        Me.TxtFolio.Size = New System.Drawing.Size(180, 20)
        Me.TxtFolio.TabIndex = 68
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "Recibe:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Entrega:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Almacén:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Folio:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Plaza:"
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
        'Label17
        '
        Me.Label17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(56, 0)
        Me.Label17.MaximumSize = New System.Drawing.Size(1600, 900)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(723, 29)
        Me.Label17.TabIndex = 49
        Me.Label17.Text = "REGISTRO DE SALIDAS DE ALMACEN POR CONSUMO"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbPlaza
        '
        Me.cmbPlaza.DataSource = Me.PlazaCol
        Me.cmbPlaza.DisplayMember = "Descripcion"
        Me.cmbPlaza.FormattingEnabled = True
        Me.cmbPlaza.Location = New System.Drawing.Point(131, 21)
        Me.cmbPlaza.Name = "cmbPlaza"
        Me.cmbPlaza.NombreMetodo = Nothing
        Me.cmbPlaza.Parametros = Nothing
        Me.cmbPlaza.SiguienteControl = Me.TxtFolio
        Me.cmbPlaza.Size = New System.Drawing.Size(368, 21)
        Me.cmbPlaza.TabIndex = 111
        Me.cmbPlaza.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbPlaza.TextBoxEnlazado = Me.txtPlaza
        Me.cmbPlaza.ValueMember = "Codigo"
        '
        'txtPlaza
        '
        Me.txtPlaza.ComboBoxEnlazado = Me.cmbPlaza
        Me.txtPlaza.Decimales = 0
        Me.txtPlaza.Location = New System.Drawing.Point(70, 22)
        Me.txtPlaza.MaxLength = 3000
        Me.txtPlaza.MensajeCombo = "Seleccione una plaza..."
        Me.txtPlaza.MensajeNoExiste = "No existe Plaza"
        Me.txtPlaza.Name = "txtPlaza"
        Me.txtPlaza.SiguienteControl = Me.cmbPlaza
        Me.txtPlaza.Size = New System.Drawing.Size(55, 20)
        Me.txtPlaza.TabIndex = 110
        Me.txtPlaza.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtPlaza.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtPlaza.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cmbAlmacen
        '
        Me.cmbAlmacen.DataSource = Me.AlmacenCol
        Me.cmbAlmacen.DisplayMember = "Descripcion"
        Me.cmbAlmacen.FormattingEnabled = True
        Me.cmbAlmacen.Location = New System.Drawing.Point(131, 80)
        Me.cmbAlmacen.Name = "cmbAlmacen"
        Me.cmbAlmacen.NombreMetodo = Nothing
        Me.cmbAlmacen.Parametros = Nothing
        Me.cmbAlmacen.SiguienteControl = Me.TxtEntrega
        Me.cmbAlmacen.Size = New System.Drawing.Size(368, 21)
        Me.cmbAlmacen.TabIndex = 113
        Me.cmbAlmacen.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbAlmacen.TextBoxEnlazado = Me.txtAlmacen
        Me.cmbAlmacen.ValueMember = "Codigo"
        '
        'txtAlmacen
        '
        Me.txtAlmacen.ComboBoxEnlazado = Me.cmbAlmacen
        Me.txtAlmacen.Decimales = 0
        Me.txtAlmacen.Location = New System.Drawing.Point(70, 81)
        Me.txtAlmacen.MaxLength = 3000
        Me.txtAlmacen.MensajeCombo = "Seleccione un almacen"
        Me.txtAlmacen.MensajeNoExiste = "No existe almacen"
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.SiguienteControl = Me.cmbAlmacen
        Me.txtAlmacen.Size = New System.Drawing.Size(55, 20)
        Me.txtAlmacen.TabIndex = 112
        Me.txtAlmacen.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtAlmacen.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtAlmacen.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'CatAlmRegSalAlmConsumo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 505)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.mtb)
        Me.MinimumSize = New System.Drawing.Size(694, 539)
        Me.Name = "CatAlmRegSalAlmConsumo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Salidas de Almacen por Consumo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TxtRecibe As System.Windows.Forms.TextBox
    Friend WithEvents TxtEntrega As System.Windows.Forms.TextBox
    Friend WithEvents TxtFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTPFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents TxtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents PlazaCol As ClasesNegocio.PlazaCollectionClass
    Friend WithEvents AlmacenCol As ClasesNegocio.AlmacenCollectionClass
    Friend WithEvents CódigoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductoColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents CantidadColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmLote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UMColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AplicacionColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents CentroDeCostosCollectionClass1 As ClasesNegocio.CentroDeCostosCollectionClass
    Friend WithEvents cmbPlaza As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents txtPlaza As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents cmbAlmacen As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents txtAlmacen As IntegraLab.Controles.TextBoxMejorado
End Class
