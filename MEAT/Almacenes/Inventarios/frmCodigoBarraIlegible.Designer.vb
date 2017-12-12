<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCodigoBarraIlegible
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
        Me.lblMensaje = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.btnIgnorar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnAbortar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.Location = New System.Drawing.Point(12, 3)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(316, 17)
        Me.lblMensaje.TabIndex = 3
        Me.lblMensaje.Text = "El siguiente codigo de barra no es legible:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(144, 24)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(251, 20)
        Me.txtCodigo.TabIndex = 4
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnIgnorar
        '
        Me.btnIgnorar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIgnorar.Location = New System.Drawing.Point(184, 70)
        Me.btnIgnorar.Name = "btnIgnorar"
        Me.btnIgnorar.Size = New System.Drawing.Size(75, 23)
        Me.btnIgnorar.TabIndex = 0
        Me.btnIgnorar.Text = "Ignorar"
        Me.btnIgnorar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(127, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(285, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "¿Desea ignorar este codigo de barra?"
        '
        'btnAbortar
        '
        Me.btnAbortar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbortar.Location = New System.Drawing.Point(265, 70)
        Me.btnAbortar.Name = "btnAbortar"
        Me.btnAbortar.Size = New System.Drawing.Size(75, 23)
        Me.btnAbortar.TabIndex = 1
        Me.btnAbortar.Text = "Abortar"
        Me.btnAbortar.UseVisualStyleBackColor = True
        '
        'frmCodigoBarraIlegible
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 102)
        Me.Controls.Add(Me.btnAbortar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnIgnorar)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblMensaje)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCodigoBarraIlegible"
        Me.Text = "CODIGO DE BARRA ILEGIBLE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents btnIgnorar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAbortar As System.Windows.Forms.Button
End Class
