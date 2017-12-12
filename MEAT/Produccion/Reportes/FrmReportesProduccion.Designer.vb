<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportesProduccion
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbProductores = New System.Windows.Forms.ComboBox
        Me.cmdImprimir = New System.Windows.Forms.Button
        Me.optCortes = New System.Windows.Forms.RadioButton
        Me.optCanales = New System.Windows.Forms.RadioButton
        Me.optRegistro = New System.Windows.Forms.RadioButton
        Me.optRecepcion = New System.Windows.Forms.RadioButton
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Productor :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbProductores)
        Me.GroupBox1.Controls.Add(Me.cmdImprimir)
        Me.GroupBox1.Controls.Add(Me.optCortes)
        Me.GroupBox1.Controls.Add(Me.optCanales)
        Me.GroupBox1.Controls.Add(Me.optRegistro)
        Me.GroupBox1.Controls.Add(Me.optRecepcion)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(442, 158)
        Me.GroupBox1.TabIndex = 86
        Me.GroupBox1.TabStop = False
        '
        'cmbProductores
        '
        Me.cmbProductores.FormattingEnabled = True
        Me.cmbProductores.Location = New System.Drawing.Point(87, 19)
        Me.cmbProductores.Name = "cmbProductores"
        Me.cmbProductores.Size = New System.Drawing.Size(285, 21)
        Me.cmbProductores.TabIndex = 91
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Location = New System.Drawing.Point(201, 129)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(75, 23)
        Me.cmdImprimir.TabIndex = 90
        Me.cmdImprimir.Text = "Imprimir"
        Me.cmdImprimir.UseVisualStyleBackColor = True
        '
        'optCortes
        '
        Me.optCortes.AutoSize = True
        Me.optCortes.Location = New System.Drawing.Point(268, 87)
        Me.optCortes.Name = "optCortes"
        Me.optCortes.Size = New System.Drawing.Size(55, 17)
        Me.optCortes.TabIndex = 89
        Me.optCortes.TabStop = True
        Me.optCortes.Text = "Cortes"
        Me.optCortes.UseVisualStyleBackColor = True
        '
        'optCanales
        '
        Me.optCanales.AutoSize = True
        Me.optCanales.Location = New System.Drawing.Point(268, 57)
        Me.optCanales.Name = "optCanales"
        Me.optCanales.Size = New System.Drawing.Size(63, 17)
        Me.optCanales.TabIndex = 88
        Me.optCanales.TabStop = True
        Me.optCanales.Text = "Canales"
        Me.optCanales.UseVisualStyleBackColor = True
        '
        'optRegistro
        '
        Me.optRegistro.AutoSize = True
        Me.optRegistro.Location = New System.Drawing.Point(87, 87)
        Me.optRegistro.Name = "optRegistro"
        Me.optRegistro.Size = New System.Drawing.Size(130, 17)
        Me.optRegistro.TabIndex = 87
        Me.optRegistro.TabStop = True
        Me.optRegistro.Text = "Registro de Sacrificios"
        Me.optRegistro.UseVisualStyleBackColor = True
        '
        'optRecepcion
        '
        Me.optRecepcion.AutoSize = True
        Me.optRecepcion.Location = New System.Drawing.Point(87, 57)
        Me.optRecepcion.Name = "optRecepcion"
        Me.optRecepcion.Size = New System.Drawing.Size(144, 17)
        Me.optRecepcion.TabIndex = 86
        Me.optRecepcion.TabStop = True
        Me.optRecepcion.Text = "Recepciones de Ganado"
        Me.optRecepcion.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(-3, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(470, 32)
        Me.Label17.TabIndex = 87
        Me.Label17.Text = "Reportes de Produccion"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmReportesProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 228)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmReportesProduccion"
        Me.Text = "Reportes de Produccion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optCortes As System.Windows.Forms.RadioButton
    Friend WithEvents optCanales As System.Windows.Forms.RadioButton
    Friend WithEvents optRegistro As System.Windows.Forms.RadioButton
    Friend WithEvents optRecepcion As System.Windows.Forms.RadioButton
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmdImprimir As System.Windows.Forms.Button
    Friend WithEvents cmbProductores As System.Windows.Forms.ComboBox
End Class
