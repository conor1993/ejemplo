<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerificarLicencia
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Campo1 = New System.Windows.Forms.TextBox()
        Me.Campo2 = New System.Windows.Forms.TextBox()
        Me.Campo3 = New System.Windows.Forms.TextBox()
        Me.Campo4 = New System.Windows.Forms.TextBox()
        Me.Campo5 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnActivar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(529, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Validación de Licencia"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Campo1
        '
        Me.Campo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Campo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Campo1.Location = New System.Drawing.Point(26, 51)
        Me.Campo1.MaxLength = 8
        Me.Campo1.Name = "Campo1"
        Me.Campo1.Size = New System.Drawing.Size(91, 23)
        Me.Campo1.TabIndex = 1
        Me.Campo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Campo2
        '
        Me.Campo2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Campo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Campo2.Location = New System.Drawing.Point(143, 51)
        Me.Campo2.MaxLength = 4
        Me.Campo2.Name = "Campo2"
        Me.Campo2.Size = New System.Drawing.Size(58, 23)
        Me.Campo2.TabIndex = 2
        Me.Campo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Campo3
        '
        Me.Campo3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Campo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Campo3.Location = New System.Drawing.Point(227, 51)
        Me.Campo3.MaxLength = 4
        Me.Campo3.Name = "Campo3"
        Me.Campo3.Size = New System.Drawing.Size(58, 23)
        Me.Campo3.TabIndex = 3
        Me.Campo3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Campo4
        '
        Me.Campo4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Campo4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Campo4.Location = New System.Drawing.Point(311, 51)
        Me.Campo4.MaxLength = 4
        Me.Campo4.Name = "Campo4"
        Me.Campo4.Size = New System.Drawing.Size(58, 23)
        Me.Campo4.TabIndex = 4
        Me.Campo4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Campo5
        '
        Me.Campo5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Campo5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Campo5.Location = New System.Drawing.Point(395, 51)
        Me.Campo5.MaxLength = 12
        Me.Campo5.Name = "Campo5"
        Me.Campo5.Size = New System.Drawing.Size(144, 23)
        Me.Campo5.TabIndex = 5
        Me.Campo5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(123, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(207, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "-"
        '
        'btnActivar
        '
        Me.btnActivar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActivar.Location = New System.Drawing.Point(227, 94)
        Me.btnActivar.Name = "btnActivar"
        Me.btnActivar.Size = New System.Drawing.Size(102, 30)
        Me.btnActivar.TabIndex = 8
        Me.btnActivar.Text = "Activar"
        Me.btnActivar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(291, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(375, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "-"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(548, 34)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Si cuenta con un problema con su licencia favor de comunicarse al numero (667) 28" & _
    "40483 con quien corresponda a Integra-Lab S.A. de C.V."
        '
        'frmVerificarLicencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 201)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnActivar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Campo5)
        Me.Controls.Add(Me.Campo4)
        Me.Controls.Add(Me.Campo3)
        Me.Controls.Add(Me.Campo2)
        Me.Controls.Add(Me.Campo1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(562, 225)
        Me.MinimumSize = New System.Drawing.Size(562, 225)
        Me.Name = "frmVerificarLicencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Validación de Licencia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Campo1 As System.Windows.Forms.TextBox
    Friend WithEvents Campo2 As System.Windows.Forms.TextBox
    Friend WithEvents Campo3 As System.Windows.Forms.TextBox
    Friend WithEvents Campo4 As System.Windows.Forms.TextBox
    Friend WithEvents Campo5 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnActivar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
