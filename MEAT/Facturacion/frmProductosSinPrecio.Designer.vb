<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductosSinPrecio
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
        Me.lblMensaje = New System.Windows.Forms.Label
        Me.lblMensaje2 = New System.Windows.Forms.Label
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblCliente = New System.Windows.Forms.Label
        Me.lblPuntoEntrega = New System.Windows.Forms.Label
        Me.lbxProductos = New System.Windows.Forms.ListBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Location = New System.Drawing.Point(6, 15)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(39, 13)
        Me.lblMensaje.TabIndex = 0
        Me.lblMensaje.Text = "Label1"
        '
        'lblMensaje2
        '
        Me.lblMensaje2.Location = New System.Drawing.Point(6, 109)
        Me.lblMensaje2.Name = "lblMensaje2"
        Me.lblMensaje2.Size = New System.Drawing.Size(348, 29)
        Me.lblMensaje2.TabIndex = 1
        Me.lblMensaje2.Text = "Label2"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(302, 206)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Punto de Entrega:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbxProductos)
        Me.GroupBox1.Controls.Add(Me.lblMensaje)
        Me.GroupBox1.Controls.Add(Me.lblMensaje2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(365, 149)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(108, 9)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(39, 13)
        Me.lblCliente.TabIndex = 7
        Me.lblCliente.Text = "Cliente"
        '
        'lblPuntoEntrega
        '
        Me.lblPuntoEntrega.AutoSize = True
        Me.lblPuntoEntrega.Location = New System.Drawing.Point(108, 32)
        Me.lblPuntoEntrega.Name = "lblPuntoEntrega"
        Me.lblPuntoEntrega.Size = New System.Drawing.Size(90, 13)
        Me.lblPuntoEntrega.TabIndex = 8
        Me.lblPuntoEntrega.Text = "Punto de Entrega"
        '
        'lbxProductos
        '
        Me.lbxProductos.FormattingEnabled = True
        Me.lbxProductos.Location = New System.Drawing.Point(9, 33)
        Me.lbxProductos.Name = "lbxProductos"
        Me.lbxProductos.Size = New System.Drawing.Size(345, 69)
        Me.lbxProductos.TabIndex = 2
        '
        'frmProductosSinPrecio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 232)
        Me.Controls.Add(Me.lblPuntoEntrega)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProductosSinPrecio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Productos requeridos con precio"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents lblMensaje2 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents lblPuntoEntrega As System.Windows.Forms.Label
    Friend WithEvents lbxProductos As System.Windows.Forms.ListBox
End Class
