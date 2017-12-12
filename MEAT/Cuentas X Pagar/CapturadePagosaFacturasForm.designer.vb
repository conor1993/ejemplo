<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CapturadePagosaFacturasForm
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Nodo0")
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.tvwProveedores = New System.Windows.Forms.TreeView
        Me.txtfiltro = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgvFacturas = New System.Windows.Forms.DataGridView
        Me.EmpresaIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NoFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaVencimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ImporteTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ImporteAbono = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ImporteApagar = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FacturasApagar = New Integralab.ORM.CollectionClasses.UsrCxpfacturasApagarCollection
        Me.Label2 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dgvFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(757, 34)
        Me.lblTitulo.TabIndex = 100
        Me.lblTitulo.Text = "CAPTURA DE PAGOS A FACTURAS"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tvwProveedores
        '
        Me.tvwProveedores.Location = New System.Drawing.Point(12, 87)
        Me.tvwProveedores.Name = "tvwProveedores"
        TreeNode1.Name = "Proveedor"
        TreeNode1.Text = "Nodo0"
        Me.tvwProveedores.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.tvwProveedores.Size = New System.Drawing.Size(180, 242)
        Me.tvwProveedores.TabIndex = 101
        '
        'txtfiltro
        '
        Me.txtfiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtfiltro.Location = New System.Drawing.Point(12, 61)
        Me.txtfiltro.Name = "txtfiltro"
        Me.txtfiltro.Size = New System.Drawing.Size(180, 20)
        Me.txtfiltro.TabIndex = 103
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Buscar Proveedor:"
        '
        'dgvFacturas
        '
        Me.dgvFacturas.AllowUserToAddRows = False
        Me.dgvFacturas.AllowUserToDeleteRows = False
        Me.dgvFacturas.AutoGenerateColumns = False
        Me.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpresaIdDataGridViewTextBoxColumn, Me.IdProveedorDataGridViewTextBoxColumn, Me.NoFacturaDataGridViewTextBoxColumn, Me.FechaVencimientoDataGridViewTextBoxColumn, Me.ImporteTotal, Me.ImporteAbono, Me.ImporteApagar, Me.Saldo})
        Me.dgvFacturas.DataSource = Me.FacturasApagar
        Me.dgvFacturas.Location = New System.Drawing.Point(198, 87)
        Me.dgvFacturas.Name = "dgvFacturas"
        Me.dgvFacturas.RowHeadersVisible = False
        Me.dgvFacturas.Size = New System.Drawing.Size(546, 242)
        Me.dgvFacturas.TabIndex = 102
        '
        'EmpresaIdDataGridViewTextBoxColumn
        '
        Me.EmpresaIdDataGridViewTextBoxColumn.DataPropertyName = "EmpresaId"
        Me.EmpresaIdDataGridViewTextBoxColumn.HeaderText = "EmpresaId"
        Me.EmpresaIdDataGridViewTextBoxColumn.Name = "EmpresaIdDataGridViewTextBoxColumn"
        Me.EmpresaIdDataGridViewTextBoxColumn.Visible = False
        '
        'IdProveedorDataGridViewTextBoxColumn
        '
        Me.IdProveedorDataGridViewTextBoxColumn.DataPropertyName = "IdProveedor"
        Me.IdProveedorDataGridViewTextBoxColumn.HeaderText = "IdProveedor"
        Me.IdProveedorDataGridViewTextBoxColumn.Name = "IdProveedorDataGridViewTextBoxColumn"
        Me.IdProveedorDataGridViewTextBoxColumn.Visible = False
        '
        'NoFacturaDataGridViewTextBoxColumn
        '
        Me.NoFacturaDataGridViewTextBoxColumn.DataPropertyName = "NoFactura"
        Me.NoFacturaDataGridViewTextBoxColumn.HeaderText = "Factura"
        Me.NoFacturaDataGridViewTextBoxColumn.Name = "NoFacturaDataGridViewTextBoxColumn"
        Me.NoFacturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaVencimientoDataGridViewTextBoxColumn
        '
        Me.FechaVencimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaVencimiento"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.FechaVencimientoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.FechaVencimientoDataGridViewTextBoxColumn.HeaderText = "Fecha Vencimiento"
        Me.FechaVencimientoDataGridViewTextBoxColumn.Name = "FechaVencimientoDataGridViewTextBoxColumn"
        Me.FechaVencimientoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ImporteTotal
        '
        Me.ImporteTotal.DataPropertyName = "ImporteTotal"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.ImporteTotal.DefaultCellStyle = DataGridViewCellStyle2
        Me.ImporteTotal.HeaderText = "Total"
        Me.ImporteTotal.Name = "ImporteTotal"
        Me.ImporteTotal.ReadOnly = True
        '
        'ImporteAbono
        '
        Me.ImporteAbono.DataPropertyName = "ImporteAbono"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ImporteAbono.DefaultCellStyle = DataGridViewCellStyle3
        Me.ImporteAbono.HeaderText = "Abono"
        Me.ImporteAbono.Name = "ImporteAbono"
        Me.ImporteAbono.ReadOnly = True
        '
        'ImporteApagar
        '
        Me.ImporteApagar.DataPropertyName = "ImporteApagar"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.ImporteApagar.DefaultCellStyle = DataGridViewCellStyle4
        Me.ImporteApagar.HeaderText = "Apagar"
        Me.ImporteApagar.Name = "ImporteApagar"
        '
        'Saldo
        '
        Me.Saldo.DataPropertyName = "saldo"
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Saldo.DefaultCellStyle = DataGridViewCellStyle5
        Me.Saldo.HeaderText = "Saldo"
        Me.Saldo.Name = "Saldo"
        Me.Saldo.ReadOnly = True
        '
        'FacturasApagar
        '
        Me.FacturasApagar.ActiveContext = Nothing
        Me.FacturasApagar.AllowEdit = True
        Me.FacturasApagar.AllowNew = True
        Me.FacturasApagar.AllowRemove = True
        Me.FacturasApagar.Capacity = 32
        Me.FacturasApagar.ConcurrencyPredicateFactoryToUse = Nothing
        Me.FacturasApagar.DoNotPerformAddIfPresent = False
        Me.FacturasApagar.EntityFactoryToUse = New Integralab.ORM.FactoryClasses.UsrCxpfacturasApagarEntityFactory
        Me.FacturasApagar.IsReadOnly = False
        Me.FacturasApagar.MaxNumberOfItemsToReturn = CType(0, Long)
        Me.FacturasApagar.SortClauses = Nothing
        Me.FacturasApagar.SuppressClearInGetMulti = False
        Me.FacturasApagar.Transaction = Nothing
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(216, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "Label2"
        '
        'CapturadePagosaFacturasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 341)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtfiltro)
        Me.Controls.Add(Me.dgvFacturas)
        Me.Controls.Add(Me.tvwProveedores)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "CapturadePagosaFacturasForm"
        Me.Text = "Captura de Pagos a Facturas "
        CType(Me.dgvFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents tvwProveedores As System.Windows.Forms.TreeView
    Friend WithEvents dgvFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents FacturasApagar As Integralab.ORM.CollectionClasses.UsrCxpfacturasApagarCollection
    Friend WithEvents txtfiltro As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EmpresaIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdProveedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoFacturaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaVencimientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteAbono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteApagar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Saldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
