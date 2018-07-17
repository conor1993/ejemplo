<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptAuxiliarCuentas
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
        Me.components = New System.ComponentModel.Container()
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtFinCuentaDescripcion = New System.Windows.Forms.TextBox()
        Me.txtFinCuentaP4 = New System.Windows.Forms.TextBox()
        Me.txtFinCuentaP3 = New System.Windows.Forms.TextBox()
        Me.txtFinCuentaP2 = New System.Windows.Forms.TextBox()
        Me.txtFinCuentaP1 = New System.Windows.Forms.TextBox()
        Me.txtIniCuentaDescripcion = New System.Windows.Forms.TextBox()
        Me.txtIniCuentaP4 = New System.Windows.Forms.TextBox()
        Me.txtIniCuentaP3 = New System.Windows.Forms.TextBox()
        Me.txtIniCuentaP2 = New System.Windows.Forms.TextBox()
        Me.txtIniCuentaP1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ultdtpFinal = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ultdtpInicial = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ultdtpFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ultdtpInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MEAToolBar1
        '
        Me.MEAToolBar1.ButtonSize = New System.Drawing.Size(50, 50)
        Me.MEAToolBar1.Dock = System.Windows.Forms.DockStyle.None
        Me.MEAToolBar1.DropDownArrows = True
        Me.MEAToolBar1.HabilitarBorrar = True
        Me.MEAToolBar1.HabilitarBuscar = True
        Me.MEAToolBar1.HabilitarCancelar = True
        Me.MEAToolBar1.HabilitarEditar = True
        Me.MEAToolBar1.HabilitarGuardar = True
        Me.MEAToolBar1.HabilitarImprimir = True
        Me.MEAToolBar1.HabilitarLimpiar = True
        Me.MEAToolBar1.HabilitarNuevo = True
        Me.MEAToolBar1.HabilitarSalir = True
        Me.MEAToolBar1.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32
        Me.MEAToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.MEAToolBar1.MostrarBorrar = False
        Me.MEAToolBar1.MostrarBuscar = False
        Me.MEAToolBar1.MostrarCancelar = False
        Me.MEAToolBar1.MostrarEditar = False
        Me.MEAToolBar1.MostrarGuardar = False
        Me.MEAToolBar1.MostrarImprimir = True
        Me.MEAToolBar1.MostrarLimpiar = True
        Me.MEAToolBar1.MostrarNuevo = False
        Me.MEAToolBar1.MostrarSalir = True
        Me.MEAToolBar1.Name = "MEAToolBar1"
        Me.MEAToolBar1.ShowToolTips = True
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 266)
        Me.MEAToolBar1.TabIndex = 39
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(422, 138)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(183, 20)
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(53, 0)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(552, 29)
        Me.lblTitulo.TabIndex = 44
        Me.lblTitulo.Text = "Reporte Auxiliar de Cuentas"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtFinCuentaDescripcion)
        Me.GroupBox1.Controls.Add(Me.txtFinCuentaP4)
        Me.GroupBox1.Controls.Add(Me.txtFinCuentaP3)
        Me.GroupBox1.Controls.Add(Me.txtFinCuentaP2)
        Me.GroupBox1.Controls.Add(Me.txtFinCuentaP1)
        Me.GroupBox1.Controls.Add(Me.txtIniCuentaDescripcion)
        Me.GroupBox1.Controls.Add(Me.txtIniCuentaP4)
        Me.GroupBox1.Controls.Add(Me.txtIniCuentaP3)
        Me.GroupBox1.Controls.Add(Me.txtIniCuentaP2)
        Me.GroupBox1.Controls.Add(Me.txtIniCuentaP1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(549, 75)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cuenta Contable"
        '
        'txtFinCuentaDescripcion
        '
        Me.txtFinCuentaDescripcion.Location = New System.Drawing.Point(205, 41)
        Me.txtFinCuentaDescripcion.Name = "txtFinCuentaDescripcion"
        Me.txtFinCuentaDescripcion.ReadOnly = True
        Me.txtFinCuentaDescripcion.Size = New System.Drawing.Size(250, 20)
        Me.txtFinCuentaDescripcion.TabIndex = 51
        Me.txtFinCuentaDescripcion.TabStop = False
        '
        'txtFinCuentaP4
        '
        Me.txtFinCuentaP4.Location = New System.Drawing.Point(166, 41)
        Me.txtFinCuentaP4.MaxLength = 4
        Me.txtFinCuentaP4.Name = "txtFinCuentaP4"
        Me.txtFinCuentaP4.Size = New System.Drawing.Size(33, 20)
        Me.txtFinCuentaP4.TabIndex = 50
        '
        'txtFinCuentaP3
        '
        Me.txtFinCuentaP3.Location = New System.Drawing.Point(127, 41)
        Me.txtFinCuentaP3.MaxLength = 4
        Me.txtFinCuentaP3.Name = "txtFinCuentaP3"
        Me.txtFinCuentaP3.Size = New System.Drawing.Size(33, 20)
        Me.txtFinCuentaP3.TabIndex = 49
        '
        'txtFinCuentaP2
        '
        Me.txtFinCuentaP2.Location = New System.Drawing.Point(88, 41)
        Me.txtFinCuentaP2.MaxLength = 4
        Me.txtFinCuentaP2.Name = "txtFinCuentaP2"
        Me.txtFinCuentaP2.Size = New System.Drawing.Size(33, 20)
        Me.txtFinCuentaP2.TabIndex = 48
        '
        'txtFinCuentaP1
        '
        Me.txtFinCuentaP1.Location = New System.Drawing.Point(49, 41)
        Me.txtFinCuentaP1.MaxLength = 4
        Me.txtFinCuentaP1.Name = "txtFinCuentaP1"
        Me.txtFinCuentaP1.Size = New System.Drawing.Size(33, 20)
        Me.txtFinCuentaP1.TabIndex = 47
        '
        'txtIniCuentaDescripcion
        '
        Me.txtIniCuentaDescripcion.Location = New System.Drawing.Point(205, 15)
        Me.txtIniCuentaDescripcion.Name = "txtIniCuentaDescripcion"
        Me.txtIniCuentaDescripcion.ReadOnly = True
        Me.txtIniCuentaDescripcion.Size = New System.Drawing.Size(250, 20)
        Me.txtIniCuentaDescripcion.TabIndex = 46
        Me.txtIniCuentaDescripcion.TabStop = False
        '
        'txtIniCuentaP4
        '
        Me.txtIniCuentaP4.Location = New System.Drawing.Point(166, 15)
        Me.txtIniCuentaP4.MaxLength = 4
        Me.txtIniCuentaP4.Name = "txtIniCuentaP4"
        Me.txtIniCuentaP4.Size = New System.Drawing.Size(33, 20)
        Me.txtIniCuentaP4.TabIndex = 5
        '
        'txtIniCuentaP3
        '
        Me.txtIniCuentaP3.Location = New System.Drawing.Point(127, 15)
        Me.txtIniCuentaP3.MaxLength = 4
        Me.txtIniCuentaP3.Name = "txtIniCuentaP3"
        Me.txtIniCuentaP3.Size = New System.Drawing.Size(33, 20)
        Me.txtIniCuentaP3.TabIndex = 4
        '
        'txtIniCuentaP2
        '
        Me.txtIniCuentaP2.Location = New System.Drawing.Point(88, 15)
        Me.txtIniCuentaP2.MaxLength = 4
        Me.txtIniCuentaP2.Name = "txtIniCuentaP2"
        Me.txtIniCuentaP2.Size = New System.Drawing.Size(33, 20)
        Me.txtIniCuentaP2.TabIndex = 3
        '
        'txtIniCuentaP1
        '
        Me.txtIniCuentaP1.Location = New System.Drawing.Point(49, 15)
        Me.txtIniCuentaP1.MaxLength = 4
        Me.txtIniCuentaP1.Name = "txtIniCuentaP1"
        Me.txtIniCuentaP1.Size = New System.Drawing.Size(33, 20)
        Me.txtIniCuentaP1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Final:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inicial:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ultdtpFinal)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.ultdtpInicial)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(56, 115)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 48)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rango de Fechas"
        '
        'ultdtpFinal
        '
        Me.ultdtpFinal.Location = New System.Drawing.Point(223, 19)
        Me.ultdtpFinal.MaskInput = "{date}"
        Me.ultdtpFinal.Name = "ultdtpFinal"
        Me.ultdtpFinal.Size = New System.Drawing.Size(106, 21)
        Me.ultdtpFinal.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(179, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Hasta:"
        '
        'ultdtpInicial
        '
        Me.ultdtpInicial.Location = New System.Drawing.Point(49, 19)
        Me.ultdtpInicial.MaskInput = "{date}"
        Me.ultdtpInicial.Name = "ultdtpInicial"
        Me.ultdtpInicial.Size = New System.Drawing.Size(104, 21)
        Me.ultdtpInicial.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Inicial:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.Location = New System.Drawing.Point(56, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "F3 - Buscar Cuentas Contables"
        '
        'frmRptAuxiliarCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 189)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.Name = "frmRptAuxiliarCuentas"
        Me.Text = "Reporte Auxiliar de Cuentas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ultdtpFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ultdtpInicial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIniCuentaP4 As System.Windows.Forms.TextBox
    Friend WithEvents txtIniCuentaP3 As System.Windows.Forms.TextBox
    Friend WithEvents txtIniCuentaP2 As System.Windows.Forms.TextBox
    Friend WithEvents txtIniCuentaP1 As System.Windows.Forms.TextBox
    Friend WithEvents txtFinCuentaDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtFinCuentaP4 As System.Windows.Forms.TextBox
    Friend WithEvents txtFinCuentaP3 As System.Windows.Forms.TextBox
    Friend WithEvents txtFinCuentaP2 As System.Windows.Forms.TextBox
    Friend WithEvents txtFinCuentaP1 As System.Windows.Forms.TextBox
    Friend WithEvents txtIniCuentaDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ultdtpInicial As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ultdtpFinal As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
