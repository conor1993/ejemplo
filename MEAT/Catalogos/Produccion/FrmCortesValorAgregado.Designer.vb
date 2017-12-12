<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCortesValorAgregado
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
        Me.dgvCortes = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CatProductos = New Integralab.ORM.CollectionClasses.MsccatProductosCollection
        Me.Label17 = New System.Windows.Forms.Label
        CType(Me.dgvCortes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCortes
        '
        Me.dgvCortes.AllowUserToAddRows = False
        Me.dgvCortes.AllowUserToDeleteRows = False
        Me.dgvCortes.AutoGenerateColumns = False
        Me.dgvCortes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCortes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.DescripcionDataGridViewTextBoxColumn, Me.IdProductoDataGridViewTextBoxColumn})
        Me.dgvCortes.DataSource = Me.CatProductos
        Me.dgvCortes.Location = New System.Drawing.Point(12, 33)
        Me.dgvCortes.Name = "dgvCortes"
        Me.dgvCortes.Size = New System.Drawing.Size(368, 266)
        Me.dgvCortes.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column1.Width = 20
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.Width = 300
        '
        'IdProductoDataGridViewTextBoxColumn
        '
        Me.IdProductoDataGridViewTextBoxColumn.DataPropertyName = "IdProducto"
        Me.IdProductoDataGridViewTextBoxColumn.HeaderText = "IdProducto"
        Me.IdProductoDataGridViewTextBoxColumn.Name = "IdProductoDataGridViewTextBoxColumn"
        Me.IdProductoDataGridViewTextBoxColumn.Visible = False
        '
        'CatProductos
        '
        Me.CatProductos.ActiveContext = Nothing
        Me.CatProductos.AllowEdit = True
        Me.CatProductos.AllowNew = True
        Me.CatProductos.AllowRemove = True
        Me.CatProductos.Capacity = 32
        Me.CatProductos.ConcurrencyPredicateFactoryToUse = Nothing
        Me.CatProductos.DoNotPerformAddIfPresent = False
        Me.CatProductos.EntityFactoryToUse = New Integralab.ORM.FactoryClasses.MsccatProductosEntityFactory
        Me.CatProductos.IsReadOnly = False
        Me.CatProductos.MaxNumberOfItemsToReturn = CType(0, Long)
        Me.CatProductos.SortClauses = Nothing
        Me.CatProductos.SuppressClearInGetMulti = False
        Me.CatProductos.Transaction = Nothing
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(-2, -2)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(450, 32)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "Selección de Cortes  para Productos de Valor Agregado"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmCortesValorAgregado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 311)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.dgvCortes)
        Me.Name = "FrmCortesValorAgregado"
        Me.Text = "Selección de Cortes para Prodcutos de Valor Agregado"
        CType(Me.dgvCortes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvCortes As System.Windows.Forms.DataGridView
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents CatProductos As IntegraLab.ORM.CollectionClasses.MsccatProductosCollection
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
