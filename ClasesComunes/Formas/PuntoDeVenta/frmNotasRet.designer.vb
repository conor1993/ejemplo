<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotasRet
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvNotasRet = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.clmIdInterno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCantArt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTotalRet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvNotasRet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgvNotasRet)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(432, 160)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'dgvNotasRet
        '
        Me.dgvNotasRet.AllowUserToAddRows = False
        Me.dgvNotasRet.AllowUserToDeleteRows = False
        Me.dgvNotasRet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvNotasRet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNotasRet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmIdInterno, Me.clmId, Me.clmCantArt, Me.clmTotalRet, Me.clmFecha})
        Me.dgvNotasRet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvNotasRet.Location = New System.Drawing.Point(3, 16)
        Me.dgvNotasRet.MultiSelect = False
        Me.dgvNotasRet.Name = "dgvNotasRet"
        Me.dgvNotasRet.ReadOnly = True
        Me.dgvNotasRet.RowHeadersVisible = False
        Me.dgvNotasRet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvNotasRet.Size = New System.Drawing.Size(426, 141)
        Me.dgvNotasRet.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.MaximumSize = New System.Drawing.Size(800, 800)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(455, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione la nota a recuperar"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(376, 198)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(65, 25)
        Me.BtnCancelar.TabIndex = 10
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BtnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.Location = New System.Drawing.Point(255, 198)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(65, 25)
        Me.BtnAceptar.TabIndex = 9
        Me.BtnAceptar.Text = "Aplicar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'clmIdInterno
        '
        Me.clmIdInterno.DataPropertyName = "Id"
        Me.clmIdInterno.HeaderText = "IdInterno"
        Me.clmIdInterno.Name = "clmIdInterno"
        Me.clmIdInterno.ReadOnly = True
        Me.clmIdInterno.Visible = False
        '
        'clmId
        '
        Me.clmId.DataPropertyName = "IdNom"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.clmId.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmId.FillWeight = 80.0!
        Me.clmId.HeaderText = "Id"
        Me.clmId.Name = "clmId"
        Me.clmId.ReadOnly = True
        '
        'clmCantArt
        '
        Me.clmCantArt.DataPropertyName = "NumArticulos"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.clmCantArt.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmCantArt.FillWeight = 50.0!
        Me.clmCantArt.HeaderText = "Artículos"
        Me.clmCantArt.Name = "clmCantArt"
        Me.clmCantArt.ReadOnly = True
        '
        'clmTotalRet
        '
        Me.clmTotalRet.DataPropertyName = "Total"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "N2"
        Me.clmTotalRet.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmTotalRet.FillWeight = 90.0!
        Me.clmTotalRet.HeaderText = "Total"
        Me.clmTotalRet.Name = "clmTotalRet"
        Me.clmTotalRet.ReadOnly = True
        '
        'clmFecha
        '
        Me.clmFecha.DataPropertyName = "Fecha"
        DataGridViewCellStyle4.Format = "dd/MM/yyyy HH:mm"
        Me.clmFecha.DefaultCellStyle = DataGridViewCellStyle4
        Me.clmFecha.HeaderText = "Fecha y Hora"
        Me.clmFecha.Name = "clmFecha"
        Me.clmFecha.ReadOnly = True
        '
        'frmNotasRet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 235)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(472, 273)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(472, 273)
        Me.Name = "frmNotasRet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notas retenidas"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvNotasRet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvNotasRet As System.Windows.Forms.DataGridView
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents clmIdInterno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCantArt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTotalRet As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFecha As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
