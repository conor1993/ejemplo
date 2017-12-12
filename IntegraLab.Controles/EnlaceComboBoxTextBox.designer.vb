<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnlaceComboBoxTextBox
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.ComboBoxMejorado1 = New IntegraLab.Controles.ComboBoxMejorado
        Me.TextBoxMejorado1 = New IntegraLab.Controles.TextBoxMejorado
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBoxMejorado1
        '
        Me.ComboBoxMejorado1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxMejorado1.FormattingEnabled = True
        Me.ComboBoxMejorado1.Location = New System.Drawing.Point(3, 3)
        Me.ComboBoxMejorado1.Name = "ComboBoxMejorado1"
        Me.ComboBoxMejorado1.NombreMetodo = Nothing
        Me.ComboBoxMejorado1.Parametros = Nothing
        Me.ComboBoxMejorado1.SiguienteControl = Nothing
        Me.ComboBoxMejorado1.Size = New System.Drawing.Size(419, 21)
        Me.ComboBoxMejorado1.TabIndex = 1
        Me.ComboBoxMejorado1.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.ComboBoxMejorado1.TextBoxEnlazado = Me.TextBoxMejorado1
        '
        'TextBoxMejorado1
        '
        Me.TextBoxMejorado1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxMejorado1.ComboBoxEnlazado = Me.ComboBoxMejorado1
        Me.TextBoxMejorado1.Decimales = 0
        Me.TextBoxMejorado1.Location = New System.Drawing.Point(3, 3)
        Me.TextBoxMejorado1.MaxLength = 3000
        Me.TextBoxMejorado1.MensajeCombo = "Seleccionar un item..."
        Me.TextBoxMejorado1.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.TextBoxMejorado1.Name = "TextBoxMejorado1"
        Me.TextBoxMejorado1.SiguienteControl = Nothing
        Me.TextBoxMejorado1.Size = New System.Drawing.Size(70, 20)
        Me.TextBoxMejorado1.TabIndex = 0
        Me.TextBoxMejorado1.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.TextBoxMejorado1.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.TextBoxMejorado1.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxMejorado1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ComboBoxMejorado1)
        Me.SplitContainer1.Size = New System.Drawing.Size(506, 28)
        Me.SplitContainer1.SplitterDistance = 77
        Me.SplitContainer1.TabIndex = 2
        '
        'EnlaceComboBoxTextBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "EnlaceComboBoxTextBox"
        Me.Size = New System.Drawing.Size(512, 31)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents TextBoxMejorado1 As IntegraLab.Controles.TextBoxMejorado
    Private WithEvents ComboBoxMejorado1 As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer

End Class
