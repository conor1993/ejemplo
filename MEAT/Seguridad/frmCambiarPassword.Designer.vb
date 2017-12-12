<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambiarPassword
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label
        Me.miCancelButton = New System.Windows.Forms.Button
        Me.OKButton = New System.Windows.Forms.Button
        Me.RePasswordTextBox = New System.Windows.Forms.TextBox
        Me.PasswordTextBox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtContraseñaActual = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(390, 59)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "La contraseña debe tener como minimo 6 caracteres, no debe tener espacios, pueden" & _
            " ser letras, numeros, o caracteres especiales exceptuando el espacio."
        '
        'miCancelButton
        '
        Me.miCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.miCancelButton.Location = New System.Drawing.Point(329, 110)
        Me.miCancelButton.Name = "miCancelButton"
        Me.miCancelButton.Size = New System.Drawing.Size(75, 23)
        Me.miCancelButton.TabIndex = 8
        Me.miCancelButton.Text = "&Cancelar"
        Me.miCancelButton.UseVisualStyleBackColor = True
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(248, 110)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 7
        Me.OKButton.Text = "&Aceptar"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'RePasswordTextBox
        '
        Me.RePasswordTextBox.Location = New System.Drawing.Point(147, 84)
        Me.RePasswordTextBox.Name = "RePasswordTextBox"
        Me.RePasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.RePasswordTextBox.Size = New System.Drawing.Size(257, 20)
        Me.RePasswordTextBox.TabIndex = 6
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(147, 58)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(257, 20)
        Me.PasswordTextBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Re-escriba la Contraseña:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Escriba una Contraseña:"
        '
        'txtContraseñaActual
        '
        Me.txtContraseñaActual.Location = New System.Drawing.Point(147, 32)
        Me.txtContraseñaActual.Name = "txtContraseñaActual"
        Me.txtContraseñaActual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseñaActual.Size = New System.Drawing.Size(257, 20)
        Me.txtContraseñaActual.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Contraseña Actual:"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(0, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(417, 29)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "CAMBIAR CONTRASEÑA"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmCambiarPassword
        '
        Me.ClientSize = New System.Drawing.Size(417, 204)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtContraseñaActual)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.miCancelButton)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.RePasswordTextBox)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCambiarPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambiar Contraseña"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents miCancelButton As System.Windows.Forms.Button
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents RePasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtContraseñaActual As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label

End Class
