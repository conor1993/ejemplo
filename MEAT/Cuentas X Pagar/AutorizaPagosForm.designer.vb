<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AutorizaPagosForm
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Nodo0")
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Nodo0")
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TvwProg = New System.Windows.Forms.TreeView
        Me.Label6 = New System.Windows.Forms.Label
        Me.DgvFacturasProg = New System.Windows.Forms.DataGridView
        Me.IdProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NoFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaVencimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ImporteTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ImporteAbono = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ImporteApagar = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaldoFinal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtfiltroProg = New System.Windows.Forms.TextBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtfiltroAuto = New System.Windows.Forms.TextBox
        Me.TvwAut = New System.Windows.Forms.TreeView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtSaldoBanco = New System.Windows.Forms.TextBox
        Me.TxtSaldoProveedor = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgvFacturasAuto = New System.Windows.Forms.DataGridView
        Me.Autorizar = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.NoFactura = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmFechaVencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmAbono = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmSaldo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmApagar = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmSaldoFinal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DgvFacturasProg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvFacturasAuto, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblTitulo.Size = New System.Drawing.Size(1019, 34)
        Me.lblTitulo.TabIndex = 105
        Me.lblTitulo.Text = "PROGRAMACIÓN DE PAGOS A FACTURAS"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(26, 55)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(993, 415)
        Me.TabControl1.TabIndex = 110
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.TvwProg)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.DgvFacturasProg)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txtfiltroProg)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(985, 389)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Programación de Pagos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(89, 364)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 13)
        Me.Label13.TabIndex = 121
        Me.Label13.Text = "Facturas Pagadas"
        Me.Label13.Visible = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.LightSalmon
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Location = New System.Drawing.Point(33, 364)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 12)
        Me.Label14.TabIndex = 120
        Me.Label14.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(89, 342)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 13)
        Me.Label10.TabIndex = 119
        Me.Label10.Text = "Facturas No Autorizadas"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(33, 342)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 12)
        Me.Label9.TabIndex = 118
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(89, 317)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 13)
        Me.Label8.TabIndex = 117
        Me.Label8.Text = "Facturas Autorizadas"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.NavajoWhite
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(33, 317)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 12)
        Me.Label5.TabIndex = 116
        '
        'TvwProg
        '
        Me.TvwProg.Location = New System.Drawing.Point(15, 55)
        Me.TvwProg.Name = "TvwProg"
        TreeNode1.Name = "Proveedor"
        TreeNode1.Text = "Nodo0"
        Me.TvwProg.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.TvwProg.Size = New System.Drawing.Size(180, 242)
        Me.TvwProg.TabIndex = 111
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(219, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 115
        Me.Label6.Text = "Label6"
        '
        'DgvFacturasProg
        '
        Me.DgvFacturasProg.AllowUserToAddRows = False
        Me.DgvFacturasProg.AllowUserToDeleteRows = False
        Me.DgvFacturasProg.AllowUserToResizeRows = False
        Me.DgvFacturasProg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFacturasProg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProveedorDataGridViewTextBoxColumn, Me.NoFacturaDataGridViewTextBoxColumn, Me.FechaVencimientoDataGridViewTextBoxColumn, Me.ImporteTotal, Me.ImporteAbono, Me.ImporteApagar, Me.Saldo, Me.SaldoFinal})
        Me.DgvFacturasProg.Location = New System.Drawing.Point(201, 55)
        Me.DgvFacturasProg.MultiSelect = False
        Me.DgvFacturasProg.Name = "DgvFacturasProg"
        Me.DgvFacturasProg.RowHeadersVisible = False
        Me.DgvFacturasProg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvFacturasProg.Size = New System.Drawing.Size(712, 242)
        Me.DgvFacturasProg.TabIndex = 112
        '
        'IdProveedorDataGridViewTextBoxColumn
        '
        Me.IdProveedorDataGridViewTextBoxColumn.DataPropertyName = "IdProveedor"
        Me.IdProveedorDataGridViewTextBoxColumn.HeaderText = "IdProveedor"
        Me.IdProveedorDataGridViewTextBoxColumn.Name = "IdProveedorDataGridViewTextBoxColumn"
        Me.IdProveedorDataGridViewTextBoxColumn.ReadOnly = True
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
        Me.Saldo.DataPropertyName = "Saldo"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Saldo.DefaultCellStyle = DataGridViewCellStyle5
        Me.Saldo.HeaderText = "Saldo"
        Me.Saldo.Name = "Saldo"
        Me.Saldo.ReadOnly = True
        '
        'SaldoFinal
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.SaldoFinal.DefaultCellStyle = DataGridViewCellStyle6
        Me.SaldoFinal.HeaderText = "Saldo Final"
        Me.SaldoFinal.Name = "SaldoFinal"
        Me.SaldoFinal.ReadOnly = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 13)
        Me.Label7.TabIndex = 114
        Me.Label7.Text = "Buscar Proveedor:"
        '
        'txtfiltroProg
        '
        Me.txtfiltroProg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtfiltroProg.Location = New System.Drawing.Point(15, 29)
        Me.txtfiltroProg.Name = "txtfiltroProg"
        Me.txtfiltroProg.Size = New System.Drawing.Size(180, 20)
        Me.txtfiltroProg.TabIndex = 113
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.txtfiltroAuto)
        Me.TabPage2.Controls.Add(Me.TvwAut)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.dgvFacturasAuto)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(985, 389)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Autorización de Pagos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(294, 325)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(93, 13)
        Me.Label15.TabIndex = 123
        Me.Label15.Text = "Facturas Pagadas"
        Me.Label15.Visible = False
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.LightSalmon
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Location = New System.Drawing.Point(242, 326)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(36, 12)
        Me.Label16.TabIndex = 122
        Me.Label16.Visible = False
        '
        'txtfiltroAuto
        '
        Me.txtfiltroAuto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtfiltroAuto.Location = New System.Drawing.Point(20, 34)
        Me.txtfiltroAuto.Name = "txtfiltroAuto"
        Me.txtfiltroAuto.Size = New System.Drawing.Size(180, 20)
        Me.txtfiltroAuto.TabIndex = 106
        '
        'TvwAut
        '
        Me.TvwAut.Location = New System.Drawing.Point(20, 60)
        Me.TvwAut.Name = "TvwAut"
        TreeNode2.Name = "Proveedor"
        TreeNode2.Text = "Nodo0"
        Me.TvwAut.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2})
        Me.TvwAut.Size = New System.Drawing.Size(180, 242)
        Me.TvwAut.TabIndex = 103
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSaldoBanco)
        Me.GroupBox1.Controls.Add(Me.TxtSaldoProveedor)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 308)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(199, 71)
        Me.GroupBox1.TabIndex = 109
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Saldos"
        '
        'txtSaldoBanco
        '
        Me.txtSaldoBanco.Enabled = False
        Me.txtSaldoBanco.Location = New System.Drawing.Point(71, 40)
        Me.txtSaldoBanco.Name = "txtSaldoBanco"
        Me.txtSaldoBanco.Size = New System.Drawing.Size(122, 20)
        Me.txtSaldoBanco.TabIndex = 3
        '
        'TxtSaldoProveedor
        '
        Me.TxtSaldoProveedor.Enabled = False
        Me.TxtSaldoProveedor.Location = New System.Drawing.Point(71, 16)
        Me.TxtSaldoProveedor.Name = "TxtSaldoProveedor"
        Me.TxtSaldoProveedor.Size = New System.Drawing.Size(122, 20)
        Me.TxtSaldoProveedor.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Banco :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Proveedor :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(221, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "Buscar Proveedor:"
        '
        'dgvFacturasAuto
        '
        Me.dgvFacturasAuto.AllowUserToAddRows = False
        Me.dgvFacturasAuto.AllowUserToDeleteRows = False
        Me.dgvFacturasAuto.AllowUserToResizeRows = False
        Me.dgvFacturasAuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFacturasAuto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Autorizar, Me.NoFactura, Me.ClmFechaVencimiento, Me.ClmTotal, Me.ClmAbono, Me.ClmSaldo, Me.ClmApagar, Me.ClmSaldoFinal})
        Me.dgvFacturasAuto.Location = New System.Drawing.Point(206, 60)
        Me.dgvFacturasAuto.MultiSelect = False
        Me.dgvFacturasAuto.Name = "dgvFacturasAuto"
        Me.dgvFacturasAuto.RowHeadersVisible = False
        Me.dgvFacturasAuto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFacturasAuto.Size = New System.Drawing.Size(771, 242)
        Me.dgvFacturasAuto.TabIndex = 104
        '
        'Autorizar
        '
        Me.Autorizar.DataPropertyName = "Autorizada"
        Me.Autorizar.HeaderText = "Autorizar"
        Me.Autorizar.Name = "Autorizar"
        Me.Autorizar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Autorizar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Autorizar.Width = 60
        '
        'NoFactura
        '
        Me.NoFactura.DataPropertyName = "NoFactura"
        Me.NoFactura.HeaderText = "NoFactura"
        Me.NoFactura.Name = "NoFactura"
        Me.NoFactura.ReadOnly = True
        '
        'ClmFechaVencimiento
        '
        Me.ClmFechaVencimiento.DataPropertyName = "FechaVencimiento"
        DataGridViewCellStyle7.Format = "d"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.ClmFechaVencimiento.DefaultCellStyle = DataGridViewCellStyle7
        Me.ClmFechaVencimiento.HeaderText = "Fecha Vencimiento"
        Me.ClmFechaVencimiento.Name = "ClmFechaVencimiento"
        Me.ClmFechaVencimiento.ReadOnly = True
        '
        'ClmTotal
        '
        Me.ClmTotal.DataPropertyName = "ImporteTotal"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle8.Format = "C2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.ClmTotal.DefaultCellStyle = DataGridViewCellStyle8
        Me.ClmTotal.HeaderText = "Total"
        Me.ClmTotal.Name = "ClmTotal"
        Me.ClmTotal.ReadOnly = True
        '
        'ClmAbono
        '
        Me.ClmAbono.DataPropertyName = "ImporteAbono"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle9.Format = "C2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.ClmAbono.DefaultCellStyle = DataGridViewCellStyle9
        Me.ClmAbono.HeaderText = "Abono"
        Me.ClmAbono.Name = "ClmAbono"
        Me.ClmAbono.ReadOnly = True
        '
        'ClmSaldo
        '
        Me.ClmSaldo.DataPropertyName = "Saldo"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle10.Format = "C2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.ClmSaldo.DefaultCellStyle = DataGridViewCellStyle10
        Me.ClmSaldo.HeaderText = "Saldo"
        Me.ClmSaldo.Name = "ClmSaldo"
        Me.ClmSaldo.ReadOnly = True
        '
        'ClmApagar
        '
        Me.ClmApagar.DataPropertyName = "ImporteApagar"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle11.Format = "C2"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.ClmApagar.DefaultCellStyle = DataGridViewCellStyle11
        Me.ClmApagar.HeaderText = "A pagar"
        Me.ClmApagar.Name = "ClmApagar"
        '
        'ClmSaldoFinal
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle12.Format = "C2"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.ClmSaldoFinal.DefaultCellStyle = DataGridViewCellStyle12
        Me.ClmSaldoFinal.HeaderText = "Saldo Final"
        Me.ClmSaldoFinal.Name = "ClmSaldoFinal"
        Me.ClmSaldoFinal.ReadOnly = True
        '
        'AutorizaPagosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 489)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "AutorizaPagosForm"
        Me.Text = "Programación de Pagos a Facturas"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DgvFacturasProg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvFacturasAuto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents ClmNoFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtfiltroAuto As System.Windows.Forms.TextBox
    Friend WithEvents TvwAut As System.Windows.Forms.TreeView
    Friend WithEvents dgvFacturasAuto As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSaldoBanco As System.Windows.Forms.TextBox
    Friend WithEvents TxtSaldoProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TvwProg As System.Windows.Forms.TreeView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DgvFacturasProg As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtfiltroProg As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents IdProveedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoFacturaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaVencimientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteAbono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteApagar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Saldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoFinal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Autorizar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NoFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmFechaVencimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmAbono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmSaldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmApagar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmSaldoFinal As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
