<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarProductoListaPrecio
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.txtCosto = New System.Windows.Forms.TextBox
        Me.txtPrecioVentaC = New System.Windows.Forms.TextBox
        Me.txtPrecioVentaP = New System.Windows.Forms.TextBox
        Me.txtComicionC = New System.Windows.Forms.TextBox
        Me.txtComicionP = New System.Windows.Forms.TextBox
        Me.TxtUtilidad = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Codigo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripción:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Costo $:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Precio Venta $:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(199, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "%"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Comisión $:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(199, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "%"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(165, 163)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 8
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(246, 163)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Location = New System.Drawing.Point(93, 6)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(93, 32)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(228, 20)
        Me.txtDescripcion.TabIndex = 1
        '
        'txtCosto
        '
        Me.txtCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCosto.Location = New System.Drawing.Point(93, 58)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.ReadOnly = True
        Me.txtCosto.Size = New System.Drawing.Size(100, 20)
        Me.txtCosto.TabIndex = 2
        '
        'txtPrecioVentaC
        '
        Me.txtPrecioVentaC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrecioVentaC.Location = New System.Drawing.Point(93, 110)
        Me.txtPrecioVentaC.Name = "txtPrecioVentaC"
        Me.txtPrecioVentaC.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecioVentaC.TabIndex = 4
        '
        'txtPrecioVentaP
        '
        Me.txtPrecioVentaP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrecioVentaP.Location = New System.Drawing.Point(221, 110)
        Me.txtPrecioVentaP.Name = "txtPrecioVentaP"
        Me.txtPrecioVentaP.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecioVentaP.TabIndex = 5
        '
        'txtComicionC
        '
        Me.txtComicionC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComicionC.Location = New System.Drawing.Point(93, 136)
        Me.txtComicionC.Name = "txtComicionC"
        Me.txtComicionC.Size = New System.Drawing.Size(100, 20)
        Me.txtComicionC.TabIndex = 6
        '
        'txtComicionP
        '
        Me.txtComicionP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComicionP.Location = New System.Drawing.Point(221, 136)
        Me.txtComicionP.Name = "txtComicionP"
        Me.txtComicionP.Size = New System.Drawing.Size(100, 20)
        Me.txtComicionP.TabIndex = 7
        '
        'TxtUtilidad
        '
        Me.TxtUtilidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtUtilidad.Location = New System.Drawing.Point(93, 84)
        Me.TxtUtilidad.Name = "TxtUtilidad"
        Me.TxtUtilidad.Size = New System.Drawing.Size(100, 20)
        Me.TxtUtilidad.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Utilidad $:"
        '
        'frmAgregarProductoListaPrecio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 189)
        Me.Controls.Add(Me.TxtUtilidad)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtComicionP)
        Me.Controls.Add(Me.txtComicionC)
        Me.Controls.Add(Me.txtPrecioVentaP)
        Me.Controls.Add(Me.txtPrecioVentaC)
        Me.Controls.Add(Me.txtCosto)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAgregarProductoListaPrecio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Producto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCosto As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecioVentaC As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecioVentaP As System.Windows.Forms.TextBox
    Friend WithEvents txtComicionC As System.Windows.Forms.TextBox
    Friend WithEvents txtComicionP As System.Windows.Forms.TextBox
    Friend WithEvents TxtUtilidad As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
