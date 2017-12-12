<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfiguracionDocumento

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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.grbTamano = New System.Windows.Forms.GroupBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.pnlTexto = New System.Windows.Forms.Panel
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rbnHorizontal = New System.Windows.Forms.RadioButton
        Me.rbnVertical = New System.Windows.Forms.RadioButton
        Me.btnColor = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.btnFuente = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.clmDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmTipo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmX = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmY = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label12 = New System.Windows.Forms.Label
        Me.TextBox7 = New System.Windows.Forms.TextBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbTamano.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnlTexto.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEstatus
        '
        Me.lblEstatus.Location = New System.Drawing.Point(461, 31)
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(580, 29)
        Me.lblTitulo.Text = "Configuracion de Documento"
        '
        'tbrMenu
        '
        Me.tbrMenu.Size = New System.Drawing.Size(50, 588)
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmDescripcion, Me.clmTipo, Me.clmX, Me.clmY})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(538, 188)
        Me.DataGridView1.TabIndex = 64
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Descripcion:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(151, 36)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(288, 20)
        Me.TextBox1.TabIndex = 66
        '
        'grbTamano
        '
        Me.grbTamano.Controls.Add(Me.TextBox3)
        Me.grbTamano.Controls.Add(Me.Label4)
        Me.grbTamano.Controls.Add(Me.Label3)
        Me.grbTamano.Controls.Add(Me.ComboBox1)
        Me.grbTamano.Controls.Add(Me.Label2)
        Me.grbTamano.Controls.Add(Me.TextBox2)
        Me.grbTamano.Location = New System.Drawing.Point(55, 89)
        Me.grbTamano.Name = "grbTamano"
        Me.grbTamano.Size = New System.Drawing.Size(447, 52)
        Me.grbTamano.TabIndex = 68
        Me.grbTamano.TabStop = False
        Me.grbTamano.Text = "Tamaño"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(358, 19)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(76, 20)
        Me.TextBox3.TabIndex = 71
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(311, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Height:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(185, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Width:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(58, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Medida:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(229, 19)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(76, 20)
        Me.TextBox2.TabIndex = 69
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Tipo Documento:"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(151, 62)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(169, 21)
        Me.ComboBox2.TabIndex = 71
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pnlTexto)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(55, 147)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(562, 333)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Etiquetas, Imagenes y Campos"
        '
        'pnlTexto
        '
        Me.pnlTexto.Controls.Add(Me.TextBox7)
        Me.pnlTexto.Controls.Add(Me.Label12)
        Me.pnlTexto.Controls.Add(Me.GroupBox3)
        Me.pnlTexto.Controls.Add(Me.btnColor)
        Me.pnlTexto.Controls.Add(Me.Label11)
        Me.pnlTexto.Controls.Add(Me.TextBox6)
        Me.pnlTexto.Controls.Add(Me.Label10)
        Me.pnlTexto.Controls.Add(Me.btnFuente)
        Me.pnlTexto.Controls.Add(Me.Label9)
        Me.pnlTexto.Location = New System.Drawing.Point(6, 42)
        Me.pnlTexto.Name = "pnlTexto"
        Me.pnlTexto.Size = New System.Drawing.Size(550, 66)
        Me.pnlTexto.TabIndex = 8
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbnHorizontal)
        Me.GroupBox3.Controls.Add(Me.rbnVertical)
        Me.GroupBox3.Location = New System.Drawing.Point(428, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(116, 60)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Orientacion"
        '
        'rbnHorizontal
        '
        Me.rbnHorizontal.AutoSize = True
        Me.rbnHorizontal.Location = New System.Drawing.Point(22, 14)
        Me.rbnHorizontal.Name = "rbnHorizontal"
        Me.rbnHorizontal.Size = New System.Drawing.Size(72, 17)
        Me.rbnHorizontal.TabIndex = 13
        Me.rbnHorizontal.TabStop = True
        Me.rbnHorizontal.Text = "Horizontal"
        Me.rbnHorizontal.UseVisualStyleBackColor = True
        '
        'rbnVertical
        '
        Me.rbnVertical.AutoSize = True
        Me.rbnVertical.Location = New System.Drawing.Point(22, 37)
        Me.rbnVertical.Name = "rbnVertical"
        Me.rbnVertical.Size = New System.Drawing.Size(60, 17)
        Me.rbnVertical.TabIndex = 14
        Me.rbnVertical.TabStop = True
        Me.rbnVertical.Text = "Vertical"
        Me.rbnVertical.UseVisualStyleBackColor = True
        '
        'btnColor
        '
        Me.btnColor.Location = New System.Drawing.Point(346, 35)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(75, 23)
        Me.btnColor.TabIndex = 9
        Me.btnColor.Text = "..."
        Me.btnColor.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(306, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Color:"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(245, 37)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(55, 20)
        Me.TextBox6.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(190, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Tamaño:"
        '
        'btnFuente
        '
        Me.btnFuente.Location = New System.Drawing.Point(52, 35)
        Me.btnFuente.Name = "btnFuente"
        Me.btnFuente.Size = New System.Drawing.Size(132, 23)
        Me.btnFuente.TabIndex = 9
        Me.btnFuente.Text = "..."
        Me.btnFuente.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Fuente:"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(297, 16)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(46, 20)
        Me.TextBox5.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(274, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Y:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(222, 16)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(46, 20)
        Me.TextBox4.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(199, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "X:"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(475, 14)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 3
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 114)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(550, 213)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(58, 16)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(135, 21)
        Me.ComboBox3.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Tipo:"
        '
        'clmDescripcion
        '
        Me.clmDescripcion.HeaderText = "Descripcion"
        Me.clmDescripcion.Name = "clmDescripcion"
        '
        'clmTipo
        '
        Me.clmTipo.HeaderText = "Tipo"
        Me.clmTipo.Name = "clmTipo"
        '
        'clmX
        '
        Me.clmX.HeaderText = "X"
        Me.clmX.Name = "clmX"
        '
        'clmY
        '
        Me.clmY.HeaderText = "Y"
        Me.clmY.Name = "clmY"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Texto:"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(52, 9)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(288, 20)
        Me.TextBox7.TabIndex = 73
        '
        'frmConfiguracionDocumento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 588)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.grbTamano)
        Me.Name = "frmConfiguracionDocumento"
        Me.Text = "Configuracion de Documento"
        Me.Controls.SetChildIndex(Me.grbTamano, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.ComboBox2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.TextBox1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.lblEstatus, 0)
        Me.Controls.SetChildIndex(Me.tbrMenu, 0)
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbTamano.ResumeLayout(False)
        Me.grbTamano.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlTexto.ResumeLayout(False)
        Me.pnlTexto.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents grbTamano As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents pnlTexto As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnFuente As System.Windows.Forms.Button
    Friend WithEvents btnColor As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents rbnVertical As System.Windows.Forms.RadioButton
    Friend WithEvents rbnHorizontal As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents clmDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmX As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
