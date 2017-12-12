<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportedeAntiguedaddeCajas
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
        Me.components = New System.ComponentModel.Container
        Me.Label4 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.DtpFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.NupDia1 = New System.Windows.Forms.NumericUpDown
        Me.NupDia2 = New System.Windows.Forms.NumericUpDown
        Me.NupDia3 = New System.Windows.Forms.NumericUpDown
        Me.NupDia4 = New System.Windows.Forms.NumericUpDown
        Me.NupDia5 = New System.Windows.Forms.NumericUpDown
        Me.NupDia6 = New System.Windows.Forms.NumericUpDown
        Me.NupDia7 = New System.Windows.Forms.NumericUpDown
        Me.NupDia8 = New System.Windows.Forms.NumericUpDown
        Me.NupDia9 = New System.Windows.Forms.NumericUpDown
        Me.NupDia10 = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.NupDia1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NupDia2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NupDia3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NupDia4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NupDia5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NupDia6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NupDia7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NupDia8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NupDia9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NupDia10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(50, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(501, 34)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "REPORTE DE ANTIGÜEDAD DE CAJAS"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mtb
        '
        Me.mtb.ButtonSize = New System.Drawing.Size(50, 50)
        Me.mtb.Dock = System.Windows.Forms.DockStyle.Left
        Me.mtb.DropDownArrows = True
        Me.mtb.HabilitarBorrar = True
        Me.mtb.HabilitarBuscar = True
        Me.mtb.HabilitarCancelar = True
        Me.mtb.HabilitarEditar = False
        Me.mtb.HabilitarGuardar = True
        Me.mtb.HabilitarImprimir = True
        Me.mtb.HabilitarLimpiar = True
        Me.mtb.HabilitarNuevo = True
        Me.mtb.HabilitarSalir = True
        Me.mtb.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32
        Me.mtb.Location = New System.Drawing.Point(0, 0)
        Me.mtb.MostrarBorrar = False
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = False
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = False
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = False
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 244)
        Me.mtb.TabIndex = 18
        '
        'DtpFechaInicial
        '
        Me.DtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaInicial.Location = New System.Drawing.Point(156, 47)
        Me.DtpFechaInicial.Name = "DtpFechaInicial"
        Me.DtpFechaInicial.Size = New System.Drawing.Size(88, 20)
        Me.DtpFechaInicial.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(107, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Fecha :"
        '
        'NupDia1
        '
        Me.NupDia1.Location = New System.Drawing.Point(79, 19)
        Me.NupDia1.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NupDia1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NupDia1.Name = "NupDia1"
        Me.NupDia1.Size = New System.Drawing.Size(45, 20)
        Me.NupDia1.TabIndex = 22
        Me.NupDia1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NupDia2
        '
        Me.NupDia2.Location = New System.Drawing.Point(155, 19)
        Me.NupDia2.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.NupDia2.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.NupDia2.Name = "NupDia2"
        Me.NupDia2.Size = New System.Drawing.Size(45, 20)
        Me.NupDia2.TabIndex = 23
        Me.NupDia2.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'NupDia3
        '
        Me.NupDia3.Enabled = False
        Me.NupDia3.Location = New System.Drawing.Point(79, 45)
        Me.NupDia3.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.NupDia3.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.NupDia3.Name = "NupDia3"
        Me.NupDia3.Size = New System.Drawing.Size(45, 20)
        Me.NupDia3.TabIndex = 24
        Me.NupDia3.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'NupDia4
        '
        Me.NupDia4.Enabled = False
        Me.NupDia4.Location = New System.Drawing.Point(155, 45)
        Me.NupDia4.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.NupDia4.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.NupDia4.Name = "NupDia4"
        Me.NupDia4.Size = New System.Drawing.Size(45, 20)
        Me.NupDia4.TabIndex = 25
        Me.NupDia4.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'NupDia5
        '
        Me.NupDia5.Enabled = False
        Me.NupDia5.Location = New System.Drawing.Point(79, 71)
        Me.NupDia5.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.NupDia5.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.NupDia5.Name = "NupDia5"
        Me.NupDia5.Size = New System.Drawing.Size(45, 20)
        Me.NupDia5.TabIndex = 26
        Me.NupDia5.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'NupDia6
        '
        Me.NupDia6.Enabled = False
        Me.NupDia6.Location = New System.Drawing.Point(155, 71)
        Me.NupDia6.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.NupDia6.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.NupDia6.Name = "NupDia6"
        Me.NupDia6.Size = New System.Drawing.Size(45, 20)
        Me.NupDia6.TabIndex = 27
        Me.NupDia6.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'NupDia7
        '
        Me.NupDia7.Enabled = False
        Me.NupDia7.Location = New System.Drawing.Point(79, 97)
        Me.NupDia7.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.NupDia7.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.NupDia7.Name = "NupDia7"
        Me.NupDia7.Size = New System.Drawing.Size(45, 20)
        Me.NupDia7.TabIndex = 28
        Me.NupDia7.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'NupDia8
        '
        Me.NupDia8.Enabled = False
        Me.NupDia8.Location = New System.Drawing.Point(155, 97)
        Me.NupDia8.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.NupDia8.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.NupDia8.Name = "NupDia8"
        Me.NupDia8.Size = New System.Drawing.Size(45, 20)
        Me.NupDia8.TabIndex = 29
        Me.NupDia8.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'NupDia9
        '
        Me.NupDia9.Enabled = False
        Me.NupDia9.Location = New System.Drawing.Point(79, 123)
        Me.NupDia9.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.NupDia9.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.NupDia9.Name = "NupDia9"
        Me.NupDia9.Size = New System.Drawing.Size(45, 20)
        Me.NupDia9.TabIndex = 30
        Me.NupDia9.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'NupDia10
        '
        Me.NupDia10.Enabled = False
        Me.NupDia10.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NupDia10.Location = New System.Drawing.Point(155, 123)
        Me.NupDia10.Maximum = New Decimal(New Integer() {365, 0, 0, 0})
        Me.NupDia10.Name = "NupDia10"
        Me.NupDia10.Size = New System.Drawing.Size(45, 20)
        Me.NupDia10.TabIndex = 31
        Me.NupDia10.Value = New Decimal(New Integer() {365, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 32
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.NupDia10)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.NupDia9)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.NupDia8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.NupDia7)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.NupDia1)
        Me.GroupBox1.Controls.Add(Me.NupDia2)
        Me.GroupBox1.Controls.Add(Me.NupDia3)
        Me.GroupBox1.Controls.Add(Me.NupDia4)
        Me.GroupBox1.Controls.Add(Me.NupDia5)
        Me.GroupBox1.Controls.Add(Me.NupDia6)
        Me.GroupBox1.Location = New System.Drawing.Point(110, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(356, 163)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dias a partir de la fecha de corte :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(76, 146)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(141, 13)
        Me.Label17.TabIndex = 41
        Me.Label17.Text = "60 dias maximo para rangos "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(206, 73)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(107, 13)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "Mediana antigüedad "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(206, 123)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 13)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Mayor antigüedad "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(206, 21)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 13)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Menor antigüedad "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(130, 125)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(19, 13)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "a :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 125)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 13)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "No. de dias :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(130, 99)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 13)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "a :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 99)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "No. de dias :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(130, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "a :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "No. de dias :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(130, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "a :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "No. de dias :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(130, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "a :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "No. de dias :"
        '
        'FrmReportedeAntiguedaddeCajas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 244)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DtpFechaInicial)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.mtb)
        Me.Name = "FrmReportedeAntiguedaddeCajas"
        Me.Text = "Reporte de Antigüedad de Cajas"
        CType(Me.NupDia1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NupDia2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NupDia3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NupDia4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NupDia5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NupDia6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NupDia7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NupDia8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NupDia9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NupDia10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents DtpFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NupDia1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NupDia2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NupDia3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NupDia4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NupDia5 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NupDia6 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NupDia7 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NupDia8 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NupDia9 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NupDia10 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class
