<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CatAlmConsultaInventProd
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
        Me.mtb = New MEAToolBar.MEAToolBar()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtTotalI = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.CodigoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlmacenColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimoCtoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoPromColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExistenciaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtUnidad = New System.Windows.Forms.TextBox()
        Me.TxtSublinea = New System.Windows.Forms.TextBox()
        Me.TxtLinea = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbProducto = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = True
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 441)
        Me.mtb.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(54, 0)
        Me.Label17.MaximumSize = New System.Drawing.Size(1600, 900)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(770, 29)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "CONSULTA DE INVENTARIO POR PRODUCTO"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TxtTotalI)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DataGrid)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(59, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(727, 314)
        Me.GroupBox1.TabIndex = 97
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle"
        '
        'TxtTotalI
        '
        Me.TxtTotalI.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTotalI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTotalI.Location = New System.Drawing.Point(472, 284)
        Me.TxtTotalI.MaxLength = 10
        Me.TxtTotalI.Name = "TxtTotalI"
        Me.TxtTotalI.ReadOnly = True
        Me.TxtTotalI.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotalI.TabIndex = 2
        Me.TxtTotalI.Text = "0"
        Me.TxtTotalI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(404, 291)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 97
        Me.Label5.Text = "Total:"
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoColumn, Me.AlmacenColumn, Me.UltimoCtoColumn, Me.CostoPromColumn, Me.ExistenciaColumn, Me.ImporteColumn})
        Me.DataGrid.Location = New System.Drawing.Point(6, 19)
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        Me.DataGrid.Size = New System.Drawing.Size(715, 263)
        Me.DataGrid.TabIndex = 0
        '
        'CodigoColumn
        '
        Me.CodigoColumn.HeaderText = "Código"
        Me.CodigoColumn.Name = "CodigoColumn"
        Me.CodigoColumn.ReadOnly = True
        Me.CodigoColumn.Visible = False
        '
        'AlmacenColumn
        '
        Me.AlmacenColumn.HeaderText = "Almacen"
        Me.AlmacenColumn.Name = "AlmacenColumn"
        Me.AlmacenColumn.ReadOnly = True
        Me.AlmacenColumn.Width = 200
        '
        'UltimoCtoColumn
        '
        Me.UltimoCtoColumn.HeaderText = "Ultimo Costo"
        Me.UltimoCtoColumn.Name = "UltimoCtoColumn"
        Me.UltimoCtoColumn.ReadOnly = True
        Me.UltimoCtoColumn.Width = 120
        '
        'CostoPromColumn
        '
        Me.CostoPromColumn.HeaderText = "Costo Promedio"
        Me.CostoPromColumn.Name = "CostoPromColumn"
        Me.CostoPromColumn.ReadOnly = True
        Me.CostoPromColumn.Width = 120
        '
        'ExistenciaColumn
        '
        Me.ExistenciaColumn.HeaderText = "Existencia"
        Me.ExistenciaColumn.Name = "ExistenciaColumn"
        Me.ExistenciaColumn.ReadOnly = True
        '
        'ImporteColumn
        '
        Me.ImporteColumn.HeaderText = "Importe Ult. Costo"
        Me.ImporteColumn.Name = "ImporteColumn"
        Me.ImporteColumn.ReadOnly = True
        Me.ImporteColumn.Width = 150
        '
        'TxtUnidad
        '
        Me.TxtUnidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtUnidad.Location = New System.Drawing.Point(634, 63)
        Me.TxtUnidad.MaxLength = 4
        Me.TxtUnidad.Name = "TxtUnidad"
        Me.TxtUnidad.Size = New System.Drawing.Size(100, 20)
        Me.TxtUnidad.TabIndex = 95
        '
        'TxtSublinea
        '
        Me.TxtSublinea.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSublinea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSublinea.Location = New System.Drawing.Point(122, 89)
        Me.TxtSublinea.MaxLength = 20
        Me.TxtSublinea.Name = "TxtSublinea"
        Me.TxtSublinea.Size = New System.Drawing.Size(414, 20)
        Me.TxtSublinea.TabIndex = 96
        '
        'TxtLinea
        '
        Me.TxtLinea.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtLinea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLinea.Location = New System.Drawing.Point(122, 63)
        Me.TxtLinea.MaxLength = 20
        Me.TxtLinea.Name = "TxtLinea"
        Me.TxtLinea.Size = New System.Drawing.Size(414, 20)
        Me.TxtLinea.TabIndex = 94
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(568, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "Unidad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Sub-Linea:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Linea:"
        '
        'CmbProducto
        '
        Me.CmbProducto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbProducto.FormattingEnabled = True
        Me.CmbProducto.Location = New System.Drawing.Point(122, 36)
        Me.CmbProducto.Name = "CmbProducto"
        Me.CmbProducto.Size = New System.Drawing.Size(612, 21)
        Me.CmbProducto.TabIndex = 93
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "Producto :"
        '
        'CatAlmConsultaInventProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 441)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtUnidad)
        Me.Controls.Add(Me.TxtSublinea)
        Me.Controls.Add(Me.TxtLinea)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbProducto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.Name = "CatAlmConsultaInventProd"
        Me.Text = "Consulta de Inventario por Producto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents AlmacenCol As ClasesNegocio.AlmacenCollectionClass
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtTotalI As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents CodigoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlmacenColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UltimoCtoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoPromColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExistenciaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtUnidad As System.Windows.Forms.TextBox
    Friend WithEvents TxtSublinea As System.Windows.Forms.TextBox
    Friend WithEvents TxtLinea As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbProducto As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
