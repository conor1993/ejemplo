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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvMetodos = New System.Windows.Forms.DataGridView()
        Me.clmSucursal = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.clmMetodoProrrateo = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.clmImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvDetalledeProrrateo = New System.Windows.Forms.DataGridView()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtPorcentaje = New System.Windows.Forms.TextBox()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.Cve_Depto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDepartamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPorcentaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmImporteDepartamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        'clmSucursal
        '
        Me.clmSucursal.DataPropertyName = "SCDescripcion"
        Me.clmSucursal.HeaderText = "Sucursal"
        Me.clmSucursal.Name = "clmSucursal"
        Me.clmSucursal.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmSucursal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clmSucursal.Width = 200
        '
        'clmMetodoProrrateo
        '
        Me.clmMetodoProrrateo.DataPropertyName = "Descripcion"
        Me.clmMetodoProrrateo.HeaderText = "Prorrateo"
        Me.clmMetodoProrrateo.Name = "clmMetodoProrrateo"
        Me.clmMetodoProrrateo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmMetodoProrrateo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clmMetodoProrrateo.Width = 200
        '
        'clmImporte
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.clmImporte.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmImporte.HeaderText = "Importe"
        Me.clmImporte.Name = "clmImporte"
        Me.clmImporte.ReadOnly = True
        Me.clmImporte.Width = 150
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
        Me.lblTitulo.Size = New System.Drawing.Size(610, 29)
        Me.lblTitulo.TabIndex = 170
        Me.lblTitulo.Text = "DISTRIBUCION DE GASTOS"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvDetalledeProrrateo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 236)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 162)
        Me.GroupBox1.TabIndex = 171
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle del Prorrateo"
        '
        'dgvDetalledeProrrateo
        '
        Me.dgvDetalledeProrrateo.AllowUserToAddRows = False
        Me.dgvDetalledeProrrateo.AllowUserToDeleteRows = False
        Me.dgvDetalledeProrrateo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalledeProrrateo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cve_Depto, Me.clmDepartamento, Me.clmPorcentaje, Me.clmImporteDepartamento})
        Me.dgvDetalledeProrrateo.Location = New System.Drawing.Point(6, 19)
        Me.dgvDetalledeProrrateo.MultiSelect = False
        Me.dgvDetalledeProrrateo.Name = "dgvDetalledeProrrateo"
        Me.dgvDetalledeProrrateo.Size = New System.Drawing.Size(564, 132)
        Me.dgvDetalledeProrrateo.TabIndex = 170
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Location = New System.Drawing.Point(494, 442)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(102, 34)
        Me.btnAceptar.TabIndex = 172
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtPorcentaje
        '
        Me.txtPorcentaje.Enabled = False
        Me.txtPorcentaje.Location = New System.Drawing.Point(263, 399)
        Me.txtPorcentaje.Name = "txtPorcentaje"
        Me.txtPorcentaje.Size = New System.Drawing.Size(109, 20)
        Me.txtPorcentaje.TabIndex = 173
        Me.txtPorcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtImporte
        '
        Me.txtImporte.Enabled = False
        Me.txtImporte.Location = New System.Drawing.Point(401, 399)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(109, 20)
        Me.txtImporte.TabIndex = 174
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Cve_Depto
        '
        Me.Cve_Depto.DataPropertyName = "IdDepartamento"
        Me.Cve_Depto.HeaderText = "Clave Departamento"
        Me.Cve_Depto.Name = "Cve_Depto"
        Me.Cve_Depto.Visible = False
        '
        'clmDepartamento
        '
        Me.clmDepartamento.DataPropertyName = "Departamento"
        Me.clmDepartamento.HeaderText = "Departamento"
        Me.clmDepartamento.Name = "clmDepartamento"
        Me.clmDepartamento.Width = 200
        '
        'clmPorcentaje
        '
        Me.clmPorcentaje.DataPropertyName = "Porcentaje"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.clmPorcentaje.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmPorcentaje.HeaderText = "Porcentaje"
        Me.clmPorcentaje.Name = "clmPorcentaje"
        '
        'clmImporteDepartamento
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.clmImporteDepartamento.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmImporteDepartamento.HeaderText = "Importe"
        Me.clmImporteDepartamento.Name = "clmImporteDepartamento"
        Me.clmImporteDepartamento.Width = 150
        '
        'frmDistribuciondeGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 481)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.txtPorcentaje)
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
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvMetodos As System.Windows.Forms.DataGridView
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDetalledeProrrateo As System.Windows.Forms.DataGridView
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents txtPorcentaje As System.Windows.Forms.TextBox
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents clmSucursal As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents clmMetodoProrrateo As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents clmImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cve_Depto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDepartamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPorcentaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmImporteDepartamento As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
