<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaCortes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvCortes = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Piezas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoPrecorte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionPrecorte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDescCorta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvCortes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCortes
        '
        Me.dgvCortes.AllowUserToAddRows = False
        Me.dgvCortes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCortes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCortes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Descripcion, Me.Piezas, Me.CodigoPrecorte, Me.DescripcionPrecorte, Me.clmDescCorta})
        Me.dgvCortes.Location = New System.Drawing.Point(12, 12)
        Me.dgvCortes.Name = "dgvCortes"
        Me.dgvCortes.ReadOnly = True
        Me.dgvCortes.RowTemplate.Height = 50
        Me.dgvCortes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCortes.Size = New System.Drawing.Size(726, 546)
        Me.dgvCortes.TabIndex = 17
        '
        'Codigo
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Codigo.DefaultCellStyle = DataGridViewCellStyle1
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 60
        '
        'Descripcion
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descripcion.DefaultCellStyle = DataGridViewCellStyle2
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 500
        '
        'Piezas
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Piezas.DefaultCellStyle = DataGridViewCellStyle3
        Me.Piezas.HeaderText = "Piezas"
        Me.Piezas.Name = "Piezas"
        Me.Piezas.ReadOnly = True
        Me.Piezas.Width = 70
        '
        'CodigoPrecorte
        '
        Me.CodigoPrecorte.HeaderText = "CodigoPrecorte"
        Me.CodigoPrecorte.Name = "CodigoPrecorte"
        Me.CodigoPrecorte.ReadOnly = True
        Me.CodigoPrecorte.Visible = False
        '
        'DescripcionPrecorte
        '
        Me.DescripcionPrecorte.HeaderText = "DescripcionPrecorte"
        Me.DescripcionPrecorte.Name = "DescripcionPrecorte"
        Me.DescripcionPrecorte.ReadOnly = True
        Me.DescripcionPrecorte.Visible = False
        '
        'clmDescCorta
        '
        Me.clmDescCorta.HeaderText = "Desc. Corta"
        Me.clmDescCorta.Name = "clmDescCorta"
        Me.clmDescCorta.ReadOnly = True
        Me.clmDescCorta.Visible = False
        '
        'FrmConsultaCortes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 570)
        Me.Controls.Add(Me.dgvCortes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmConsultaCortes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Cortes"
        CType(Me.dgvCortes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvCortes As System.Windows.Forms.DataGridView
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Piezas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoPrecorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionPrecorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDescCorta As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
