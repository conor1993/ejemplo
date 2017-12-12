<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusqCanalEmbarque
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
        Me.Label17 = New System.Windows.Forms.Label
        Me.DgvCanales = New System.Windows.Forms.DataGridView
        Me.clmSeleccion = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ClmLoteSacrificio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFolioCanal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmKgrs = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFechaSacrificio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BtnAceptar = New System.Windows.Forms.Button
        Me.BrnCancelar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtLoteSacrificio = New System.Windows.Forms.TextBox
        Me.BtnBuscar = New System.Windows.Forms.Button
        CType(Me.DgvCanales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(0, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(475, 32)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Búsqueda de Canales"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DgvCanales
        '
        Me.DgvCanales.AllowUserToAddRows = False
        Me.DgvCanales.AllowUserToDeleteRows = False
        Me.DgvCanales.AllowUserToResizeRows = False
        Me.DgvCanales.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvCanales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmSeleccion, Me.ClmLoteSacrificio, Me.clmFolioCanal, Me.clmKgrs, Me.clmFechaSacrificio})
        Me.DgvCanales.Location = New System.Drawing.Point(12, 74)
        Me.DgvCanales.Name = "DgvCanales"
        Me.DgvCanales.RowHeadersVisible = False
        Me.DgvCanales.Size = New System.Drawing.Size(447, 305)
        Me.DgvCanales.TabIndex = 17
        '
        'clmSeleccion
        '
        Me.clmSeleccion.HeaderText = ""
        Me.clmSeleccion.Name = "clmSeleccion"
        Me.clmSeleccion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmSeleccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clmSeleccion.Width = 30
        '
        'ClmLoteSacrificio
        '
        Me.ClmLoteSacrificio.DataPropertyName = "FolioSacrificio"
        Me.ClmLoteSacrificio.HeaderText = "LoteSacrificio"
        Me.ClmLoteSacrificio.Name = "ClmLoteSacrificio"
        '
        'clmFolioCanal
        '
        Me.clmFolioCanal.DataPropertyName = "CodigoBarra"
        Me.clmFolioCanal.HeaderText = "Folio Canal"
        Me.clmFolioCanal.Name = "clmFolioCanal"
        '
        'clmKgrs
        '
        Me.clmKgrs.DataPropertyName = "KgrsBascula"
        Me.clmKgrs.HeaderText = "Kilogramos"
        Me.clmKgrs.Name = "clmKgrs"
        '
        'clmFechaSacrificio
        '
        Me.clmFechaSacrificio.DataPropertyName = "FechaSacrificio"
        Me.clmFechaSacrificio.HeaderText = "Fecha Sacrificio"
        Me.clmFechaSacrificio.Name = "clmFechaSacrificio"
        Me.clmFechaSacrificio.Width = 120
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(263, 394)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 18
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BrnCancelar
        '
        Me.BrnCancelar.Location = New System.Drawing.Point(354, 394)
        Me.BrnCancelar.Name = "BrnCancelar"
        Me.BrnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BrnCancelar.TabIndex = 19
        Me.BrnCancelar.Text = "Cancelar"
        Me.BrnCancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Lote Sacrificio:"
        '
        'txtLoteSacrificio
        '
        Me.txtLoteSacrificio.Location = New System.Drawing.Point(103, 45)
        Me.txtLoteSacrificio.Name = "txtLoteSacrificio"
        Me.txtLoteSacrificio.Size = New System.Drawing.Size(144, 20)
        Me.txtLoteSacrificio.TabIndex = 21
        Me.txtLoteSacrificio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(263, 43)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 24
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'FrmBusqCanalEmbarque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 440)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.txtLoteSacrificio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BrnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.DgvCanales)
        Me.Controls.Add(Me.Label17)
        Me.Name = "FrmBusqCanalEmbarque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Búsqueda de Canales"
        CType(Me.DgvCanales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents DgvCanales As System.Windows.Forms.DataGridView
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents BrnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLoteSacrificio As System.Windows.Forms.TextBox
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents clmSeleccion As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ClmLoteSacrificio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFolioCanal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmKgrs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaSacrificio As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
