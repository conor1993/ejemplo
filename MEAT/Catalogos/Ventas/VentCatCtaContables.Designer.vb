<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentCatCtaContables
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TxtCta4 = New System.Windows.Forms.TextBox
        Me.TxtCta3 = New System.Windows.Forms.TextBox
        Me.TxtCta2 = New System.Windows.Forms.TextBox
        Me.TxtDescripcion = New System.Windows.Forms.TextBox
        Me.TxtCta1 = New System.Windows.Forms.TextBox
        Me.TxtCtaCtrl = New System.Windows.Forms.TextBox
        Me.TxtCodigo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnAceptar = New System.Windows.Forms.Button
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TxtCta4)
        Me.Panel1.Controls.Add(Me.TxtCta3)
        Me.Panel1.Controls.Add(Me.TxtCta2)
        Me.Panel1.Controls.Add(Me.TxtDescripcion)
        Me.Panel1.Controls.Add(Me.TxtCta1)
        Me.Panel1.Controls.Add(Me.TxtCtaCtrl)
        Me.Panel1.Controls.Add(Me.TxtCodigo)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(10, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(377, 130)
        Me.Panel1.TabIndex = 1
        '
        'TxtCta4
        '
        Me.TxtCta4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCta4.Location = New System.Drawing.Point(302, 65)
        Me.TxtCta4.MaxLength = 4
        Me.TxtCta4.Name = "TxtCta4"
        Me.TxtCta4.Size = New System.Drawing.Size(61, 20)
        Me.TxtCta4.TabIndex = 5
        Me.TxtCta4.Text = "0"
        '
        'TxtCta3
        '
        Me.TxtCta3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCta3.Location = New System.Drawing.Point(240, 65)
        Me.TxtCta3.MaxLength = 4
        Me.TxtCta3.Name = "TxtCta3"
        Me.TxtCta3.Size = New System.Drawing.Size(61, 20)
        Me.TxtCta3.TabIndex = 4
        Me.TxtCta3.Text = "0"
        '
        'TxtCta2
        '
        Me.TxtCta2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCta2.Location = New System.Drawing.Point(179, 65)
        Me.TxtCta2.MaxLength = 4
        Me.TxtCta2.Name = "TxtCta2"
        Me.TxtCta2.Size = New System.Drawing.Size(61, 20)
        Me.TxtCta2.TabIndex = 3
        Me.TxtCta2.Text = "0"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescripcion.Location = New System.Drawing.Point(117, 91)
        Me.TxtDescripcion.MaxLength = 30
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(246, 20)
        Me.TxtDescripcion.TabIndex = 6
        '
        'TxtCta1
        '
        Me.TxtCta1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCta1.Location = New System.Drawing.Point(117, 65)
        Me.TxtCta1.MaxLength = 4
        Me.TxtCta1.Name = "TxtCta1"
        Me.TxtCta1.Size = New System.Drawing.Size(61, 20)
        Me.TxtCta1.TabIndex = 2
        Me.TxtCta1.Text = "0"
        '
        'TxtCtaCtrl
        '
        Me.TxtCtaCtrl.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCtaCtrl.Location = New System.Drawing.Point(117, 38)
        Me.TxtCtaCtrl.MaxLength = 30
        Me.TxtCtaCtrl.Name = "TxtCtaCtrl"
        Me.TxtCtaCtrl.Size = New System.Drawing.Size(246, 20)
        Me.TxtCtaCtrl.TabIndex = 1
        '
        'TxtCodigo
        '
        Me.TxtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCodigo.Enabled = False
        Me.TxtCodigo.Location = New System.Drawing.Point(117, 12)
        Me.TxtCodigo.MaxLength = 4
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(74, 20)
        Me.TxtCodigo.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Descripción:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cuenta Contable:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cuenta de Control:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(201, 169)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 2
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(300, 169)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 3
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.SteelBlue
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.MaximumSize = New System.Drawing.Size(1600, 800)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(398, 29)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "CUENTAS CONTABLES"
        '
        'VentCatCtaContables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 198)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.Panel1)
        Me.MinimumSize = New System.Drawing.Size(406, 232)
        Me.Name = "VentCatCtaContables"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuentas Contables"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtCta4 As System.Windows.Forms.TextBox
    Friend WithEvents TxtCta3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtCta2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents TxtCta1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtCtaCtrl As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
