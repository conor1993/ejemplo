<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarRecepcionesForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DgvRecepciones = New System.Windows.Forms.DataGridView
        Me.Agregar = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Folio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaRecepcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FolioOrden = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaRetiro = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreProducto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadProducto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BtnAgregar = New System.Windows.Forms.Button
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvRecepciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvRecepciones)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(506, 290)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recepciones"
        '
        'DgvRecepciones
        '
        Me.DgvRecepciones.AllowUserToAddRows = False
        Me.DgvRecepciones.AllowUserToDeleteRows = False
        Me.DgvRecepciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRecepciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Agregar, Me.Folio, Me.FechaRecepcion, Me.FolioOrden, Me.FechaRetiro, Me.NombreProducto, Me.CantidadProducto})
        Me.DgvRecepciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvRecepciones.Location = New System.Drawing.Point(3, 16)
        Me.DgvRecepciones.Name = "DgvRecepciones"
        Me.DgvRecepciones.RowHeadersWidth = 20
        Me.DgvRecepciones.Size = New System.Drawing.Size(500, 271)
        Me.DgvRecepciones.TabIndex = 0
        '
        'Agregar
        '
        Me.Agregar.HeaderText = "Agregar"
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Agregar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Agregar.Width = 60
        '
        'Folio
        '
        Me.Folio.DataPropertyName = "FolioRecepcion"
        Me.Folio.HeaderText = "Folio"
        Me.Folio.Name = "Folio"
        '
        'FechaRecepcion
        '
        Me.FechaRecepcion.DataPropertyName = "FechaRecepcion"
        Me.FechaRecepcion.HeaderText = "Fecha"
        Me.FechaRecepcion.Name = "FechaRecepcion"
        '
        'FolioOrden
        '
        Me.FolioOrden.DataPropertyName = "FolioOrden"
        Me.FolioOrden.HeaderText = "Folio Orden Retiro"
        Me.FolioOrden.Name = "FolioOrden"
        '
        'FechaRetiro
        '
        Me.FechaRetiro.DataPropertyName = "FechaRetiro"
        Me.FechaRetiro.HeaderText = "Fecha Retiro"
        Me.FechaRetiro.Name = "FechaRetiro"
        '
        'NombreProducto
        '
        Me.NombreProducto.DataPropertyName = "NombreProducto"
        Me.NombreProducto.HeaderText = "Producto"
        Me.NombreProducto.Name = "NombreProducto"
        '
        'CantidadProducto
        '
        Me.CantidadProducto.DataPropertyName = "CantidadProducto"
        Me.CantidadProducto.HeaderText = "Cantidad"
        Me.CantidadProducto.Name = "CantidadProducto"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(295, 345)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(85, 23)
        Me.BtnAgregar.TabIndex = 65
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(408, 345)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(85, 23)
        Me.BtnCancelar.TabIndex = 66
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
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
        Me.lblTitulo.Size = New System.Drawing.Size(539, 29)
        Me.lblTitulo.TabIndex = 67
        Me.lblTitulo.Text = "AGREGAR RECEPCIONES A FACTURAS"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AgregarRecepcionesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 382)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "AgregarRecepcionesForm"
        Me.Text = "Agregar Recepciones a Facturas"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgvRecepciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DgvRecepciones As System.Windows.Forms.DataGridView
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents Agregar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Folio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaRecepcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FolioOrden As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaRetiro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
End Class
