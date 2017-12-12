<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusquedaCortesEmbarque
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
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.DgvCortes = New System.Windows.Forms.DataGridView
        Me.clmSeleccion = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ClmCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.BtnAceptar = New System.Windows.Forms.Button
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.BtnBucar = New System.Windows.Forms.Button
        CType(Me.DgvCortes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(411, 32)
        Me.lblTitulo.TabIndex = 16
        Me.lblTitulo.Text = "Búsqueda de Cortes"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DgvCortes
        '
        Me.DgvCortes.AllowUserToAddRows = False
        Me.DgvCortes.AllowUserToDeleteRows = False
        Me.DgvCortes.AllowUserToResizeRows = False
        Me.DgvCortes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCortes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmSeleccion, Me.ClmCodigo, Me.ClmDescripcion})
        Me.DgvCortes.Location = New System.Drawing.Point(12, 77)
        Me.DgvCortes.Name = "DgvCortes"
        Me.DgvCortes.RowHeadersVisible = False
        Me.DgvCortes.Size = New System.Drawing.Size(384, 284)
        Me.DgvCortes.TabIndex = 17
        '
        'clmSeleccion
        '
        Me.clmSeleccion.HeaderText = ""
        Me.clmSeleccion.Name = "clmSeleccion"
        Me.clmSeleccion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmSeleccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clmSeleccion.Width = 30
        '
        'ClmCodigo
        '
        Me.ClmCodigo.DataPropertyName = "IdProducto"
        Me.ClmCodigo.HeaderText = "Código"
        Me.ClmCodigo.Name = "ClmCodigo"
        '
        'ClmDescripcion
        '
        Me.ClmDescripcion.DataPropertyName = "Descripcion"
        Me.ClmDescripcion.HeaderText = "Descripción"
        Me.ClmDescripcion.Name = "ClmDescripcion"
        Me.ClmDescripcion.Width = 250
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(58, 43)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 19
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(217, 367)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 20
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(308, 367)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 21
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnBucar
        '
        Me.BtnBucar.Location = New System.Drawing.Point(293, 41)
        Me.BtnBucar.Name = "BtnBucar"
        Me.BtnBucar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBucar.TabIndex = 22
        Me.BtnBucar.Text = "Buscar"
        Me.BtnBucar.UseVisualStyleBackColor = True
        '
        'FrmBusquedaCortesEmbarque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 402)
        Me.Controls.Add(Me.BtnBucar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgvCortes)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "FrmBusquedaCortesEmbarque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Búsqueda de Cortes"
        CType(Me.DgvCortes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents DgvCortes As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents clmSeleccion As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ClmCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnBucar As System.Windows.Forms.Button
End Class
