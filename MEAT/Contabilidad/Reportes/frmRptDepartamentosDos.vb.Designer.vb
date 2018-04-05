<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptDepartamentosDos
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
        Me.lblDepartamento = New System.Windows.Forms.Label()
        Me.cmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.cmbMeses = New System.Windows.Forms.ComboBox()
        Me.lblMeses = New System.Windows.Forms.Label()
        Me.cmbAnio = New System.Windows.Forms.ComboBox()
        Me.lblAnio = New System.Windows.Forms.Label()
        Me.chbComparativo = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbSimplificado = New System.Windows.Forms.RadioButton()
        Me.rdbDetallado = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDepartamento
        '
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.Location = New System.Drawing.Point(12, 23)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(77, 13)
        Me.lblDepartamento.TabIndex = 0
        Me.lblDepartamento.Text = "Departamento:"
        '
        'cmbDepartamento
        '
        Me.cmbDepartamento.FormattingEnabled = True
        Me.cmbDepartamento.Location = New System.Drawing.Point(91, 20)
        Me.cmbDepartamento.Name = "cmbDepartamento"
        Me.cmbDepartamento.Size = New System.Drawing.Size(203, 21)
        Me.cmbDepartamento.TabIndex = 1
        '
        'cmbMeses
        '
        Me.cmbMeses.FormattingEnabled = True
        Me.cmbMeses.Location = New System.Drawing.Point(91, 47)
        Me.cmbMeses.Name = "cmbMeses"
        Me.cmbMeses.Size = New System.Drawing.Size(203, 21)
        Me.cmbMeses.TabIndex = 3
        '
        'lblMeses
        '
        Me.lblMeses.AutoSize = True
        Me.lblMeses.Location = New System.Drawing.Point(12, 50)
        Me.lblMeses.Name = "lblMeses"
        Me.lblMeses.Size = New System.Drawing.Size(41, 13)
        Me.lblMeses.TabIndex = 2
        Me.lblMeses.Text = "Meses:"
        '
        'cmbAnio
        '
        Me.cmbAnio.FormattingEnabled = True
        Me.cmbAnio.Location = New System.Drawing.Point(91, 74)
        Me.cmbAnio.Name = "cmbAnio"
        Me.cmbAnio.Size = New System.Drawing.Size(114, 21)
        Me.cmbAnio.TabIndex = 5
        '
        'lblAnio
        '
        Me.lblAnio.AutoSize = True
        Me.lblAnio.Location = New System.Drawing.Point(12, 77)
        Me.lblAnio.Name = "lblAnio"
        Me.lblAnio.Size = New System.Drawing.Size(29, 13)
        Me.lblAnio.TabIndex = 4
        Me.lblAnio.Text = "Año:"
        '
        'chbComparativo
        '
        Me.chbComparativo.AutoSize = True
        Me.chbComparativo.Location = New System.Drawing.Point(15, 104)
        Me.chbComparativo.Name = "chbComparativo"
        Me.chbComparativo.Size = New System.Drawing.Size(85, 17)
        Me.chbComparativo.TabIndex = 6
        Me.chbComparativo.Text = "Comparativo"
        Me.chbComparativo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbDetallado)
        Me.GroupBox1.Controls.Add(Me.rdbSimplificado)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 134)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(281, 70)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mostrar por"
        '
        'rdbSimplificado
        '
        Me.rdbSimplificado.AutoSize = True
        Me.rdbSimplificado.Location = New System.Drawing.Point(20, 29)
        Me.rdbSimplificado.Name = "rdbSimplificado"
        Me.rdbSimplificado.Size = New System.Drawing.Size(81, 17)
        Me.rdbSimplificado.TabIndex = 0
        Me.rdbSimplificado.TabStop = True
        Me.rdbSimplificado.Text = "Simplificado"
        Me.rdbSimplificado.UseVisualStyleBackColor = True
        '
        'rdbDetallado
        '
        Me.rdbDetallado.AutoSize = True
        Me.rdbDetallado.Location = New System.Drawing.Point(122, 29)
        Me.rdbDetallado.Name = "rdbDetallado"
        Me.rdbDetallado.Size = New System.Drawing.Size(70, 17)
        Me.rdbDetallado.TabIndex = 1
        Me.rdbDetallado.TabStop = True
        Me.rdbDetallado.Text = "Detallado"
        Me.rdbDetallado.UseVisualStyleBackColor = True
        '
        'frmRptDepartamentosDos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 220)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chbComparativo)
        Me.Controls.Add(Me.cmbAnio)
        Me.Controls.Add(Me.lblAnio)
        Me.Controls.Add(Me.cmbMeses)
        Me.Controls.Add(Me.lblMeses)
        Me.Controls.Add(Me.cmbDepartamento)
        Me.Controls.Add(Me.lblDepartamento)
        Me.Name = "frmRptDepartamentosDos"
        Me.Text = "Reporte de Departamentos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDepartamento As System.Windows.Forms.Label
    Friend WithEvents cmbDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMeses As System.Windows.Forms.ComboBox
    Friend WithEvents lblMeses As System.Windows.Forms.Label
    Friend WithEvents cmbAnio As System.Windows.Forms.ComboBox
    Friend WithEvents lblAnio As System.Windows.Forms.Label
    Friend WithEvents chbComparativo As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbDetallado As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSimplificado As System.Windows.Forms.RadioButton
End Class
