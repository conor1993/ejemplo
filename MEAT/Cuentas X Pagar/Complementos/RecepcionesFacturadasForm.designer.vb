<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FacturasDetallesForm
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.FolioRecepcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaRecepcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FolioOrden = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GradosBrix = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GradosCentigrados = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FolioRecepcion, Me.FechaRecepcion, Me.FolioOrden, Me.Producto, Me.Cantidad, Me.GradosBrix, Me.GradosCentigrados})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 25
        Me.DataGridView1.Size = New System.Drawing.Size(597, 333)
        Me.DataGridView1.TabIndex = 0
        '
        'FolioRecepcion
        '
        Me.FolioRecepcion.DataPropertyName = "FolioRecepcion"
        Me.FolioRecepcion.HeaderText = "Folio"
        Me.FolioRecepcion.Name = "FolioRecepcion"
        Me.FolioRecepcion.ReadOnly = True
        '
        'FechaRecepcion
        '
        Me.FechaRecepcion.DataPropertyName = "FechaRecepcion"
        Me.FechaRecepcion.HeaderText = "Fecha Recepción"
        Me.FechaRecepcion.Name = "FechaRecepcion"
        Me.FechaRecepcion.ReadOnly = True
        '
        'FolioOrden
        '
        Me.FolioOrden.DataPropertyName = "FolioOrden"
        Me.FolioOrden.HeaderText = "Folio Orden"
        Me.FolioOrden.Name = "FolioOrden"
        Me.FolioOrden.ReadOnly = True
        '
        'Producto
        '
        Me.Producto.DataPropertyName = "Nombre"
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.DataPropertyName = "Cantidad"
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'GradosBrix
        '
        Me.GradosBrix.DataPropertyName = "GradosBrix"
        Me.GradosBrix.HeaderText = "Grados Brix"
        Me.GradosBrix.Name = "GradosBrix"
        Me.GradosBrix.ReadOnly = True
        '
        'GradosCentigrados
        '
        Me.GradosCentigrados.DataPropertyName = "GradosCentigrados"
        Me.GradosCentigrados.HeaderText = "Grados Centigrados"
        Me.GradosCentigrados.Name = "GradosCentigrados"
        Me.GradosCentigrados.ReadOnly = True
        '
        'FacturasDetallesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 333)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FacturasDetallesForm"
        Me.Text = "Recepciones Facturadas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents FolioRecepcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaRecepcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FolioOrden As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GradosBrix As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GradosCentigrados As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
