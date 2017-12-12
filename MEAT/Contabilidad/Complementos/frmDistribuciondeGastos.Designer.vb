<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDistribuciondeGastos
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dgvMetodos = New System.Windows.Forms.DataGridView
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgvDetalledeProrrateo = New System.Windows.Forms.DataGridView
        Me.clmDepartamento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPorcentaje = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmImporteDepartamento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmSucursal = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.clmMetodoProrrateo = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.clmImporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnAceptar = New System.Windows.Forms.Button
        CType(Me.dgvMetodos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDetalledeProrrateo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMetodos
        '
        Me.dgvMetodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMetodos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmSucursal, Me.clmMetodoProrrateo, Me.clmImporte})
        Me.dgvMetodos.Location = New System.Drawing.Point(12, 56)
        Me.dgvMetodos.MultiSelect = False
        Me.dgvMetodos.Name = "dgvMetodos"
        Me.dgvMetodos.RowHeadersVisible = False
        Me.dgvMetodos.Size = New System.Drawing.Size(576, 165)
        Me.dgvMetodos.TabIndex = 169
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
        Me.lblTitulo.Size = New System.Drawing.Size(602, 29)
        Me.lblTitulo.TabIndex = 170
        Me.lblTitulo.Text = "DISTRIBUCION DE GASTOS"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvDetalledeProrrateo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 236)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 156)
        Me.GroupBox1.TabIndex = 171
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle del Prorrateo"
        '
        'dgvDetalledeProrrateo
        '
        Me.dgvDetalledeProrrateo.AllowUserToAddRows = False
        Me.dgvDetalledeProrrateo.AllowUserToDeleteRows = False
        Me.dgvDetalledeProrrateo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalledeProrrateo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmDepartamento, Me.clmPorcentaje, Me.clmImporteDepartamento})
        Me.dgvDetalledeProrrateo.Location = New System.Drawing.Point(6, 18)
        Me.dgvDetalledeProrrateo.MultiSelect = False
        Me.dgvDetalledeProrrateo.Name = "dgvDetalledeProrrateo"
        Me.dgvDetalledeProrrateo.ReadOnly = True
        Me.dgvDetalledeProrrateo.Size = New System.Drawing.Size(564, 132)
        Me.dgvDetalledeProrrateo.TabIndex = 170
        '
        'clmDepartamento
        '
        Me.clmDepartamento.DataPropertyName = "Departamento"
        Me.clmDepartamento.HeaderText = "Departamento"
        Me.clmDepartamento.Name = "clmDepartamento"
        Me.clmDepartamento.ReadOnly = True
        Me.clmDepartamento.Width = 200
        '
        'clmPorcentaje
        '
        Me.clmPorcentaje.DataPropertyName = "Porcentaje"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = "0"
        Me.clmPorcentaje.DefaultCellStyle = DataGridViewCellStyle10
        Me.clmPorcentaje.HeaderText = "Porcentaje"
        Me.clmPorcentaje.Name = "clmPorcentaje"
        Me.clmPorcentaje.ReadOnly = True
        '
        'clmImporteDepartamento
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        DataGridViewCellStyle11.NullValue = "0"
        Me.clmImporteDepartamento.DefaultCellStyle = DataGridViewCellStyle11
        Me.clmImporteDepartamento.HeaderText = "Importe"
        Me.clmImporteDepartamento.Name = "clmImporteDepartamento"
        Me.clmImporteDepartamento.ReadOnly = True
        Me.clmImporteDepartamento.Width = 150
        '
        'clmSucursal
        '
        Me.clmSucursal.HeaderText = "Sucursal"
        Me.clmSucursal.Name = "clmSucursal"
        Me.clmSucursal.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmSucursal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clmSucursal.Width = 200
        '
        'clmMetodoProrrateo
        '
        Me.clmMetodoProrrateo.HeaderText = "Prorrateo"
        Me.clmMetodoProrrateo.Name = "clmMetodoProrrateo"
        Me.clmMetodoProrrateo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmMetodoProrrateo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clmMetodoProrrateo.Width = 200
        '
        'clmImporte
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N2"
        DataGridViewCellStyle12.NullValue = "0"
        Me.clmImporte.DefaultCellStyle = DataGridViewCellStyle12
        Me.clmImporte.HeaderText = "Importe"
        Me.clmImporte.Name = "clmImporte"
        Me.clmImporte.Width = 150
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Location = New System.Drawing.Point(486, 397)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(102, 34)
        Me.btnAceptar.TabIndex = 172
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'frmDistribuciondeGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 436)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.dgvMetodos)
        Me.Name = "frmDistribuciondeGastos"
        Me.Text = "DISTRIBUCION DE GASTOS"
        CType(Me.dgvMetodos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvDetalledeProrrateo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvMetodos As System.Windows.Forms.DataGridView
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDetalledeProrrateo As System.Windows.Forms.DataGridView
    Friend WithEvents clmSucursal As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents clmMetodoProrrateo As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents clmImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDepartamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPorcentaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmImporteDepartamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
End Class
