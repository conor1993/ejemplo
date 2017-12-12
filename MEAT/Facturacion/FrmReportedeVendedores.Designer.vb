<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportedeVendedores
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmbVendedores = New System.Windows.Forms.ComboBox
        Me.grpFechas = New System.Windows.Forms.GroupBox
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.chkPorFechas = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbtDescendente = New System.Windows.Forms.RadioButton
        Me.rbtAscendente = New System.Windows.Forms.RadioButton
        Me.grpFechas.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(50, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(449, 32)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "REPORTE DE VENDEDORES"
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
        Me.mtb.HabilitarEditar = True
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
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 192)
        Me.mtb.TabIndex = 63
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Vendedor :"
        '
        'CmbVendedores
        '
        Me.CmbVendedores.FormattingEnabled = True
        Me.CmbVendedores.Location = New System.Drawing.Point(121, 44)
        Me.CmbVendedores.Name = "CmbVendedores"
        Me.CmbVendedores.Size = New System.Drawing.Size(359, 21)
        Me.CmbVendedores.TabIndex = 67
        '
        'grpFechas
        '
        Me.grpFechas.Controls.Add(Me.dtpFechaFinal)
        Me.grpFechas.Controls.Add(Me.dtpFechaInicial)
        Me.grpFechas.Controls.Add(Me.Label3)
        Me.grpFechas.Controls.Add(Me.Label1)
        Me.grpFechas.Controls.Add(Me.chkPorFechas)
        Me.grpFechas.Location = New System.Drawing.Point(56, 71)
        Me.grpFechas.Name = "grpFechas"
        Me.grpFechas.Size = New System.Drawing.Size(190, 85)
        Me.grpFechas.TabIndex = 68
        Me.grpFechas.TabStop = False
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(88, 49)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(88, 20)
        Me.dtpFechaFinal.TabIndex = 72
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicial.Location = New System.Drawing.Point(88, 23)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(88, 20)
        Me.dtpFechaInicial.TabIndex = 71
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Fecha Final:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Fecha Inicial:"
        '
        'chkPorFechas
        '
        Me.chkPorFechas.AutoSize = True
        Me.chkPorFechas.Location = New System.Drawing.Point(15, 0)
        Me.chkPorFechas.Name = "chkPorFechas"
        Me.chkPorFechas.Size = New System.Drawing.Size(72, 17)
        Me.chkPorFechas.TabIndex = 0
        Me.chkPorFechas.Text = "Por fecha"
        Me.chkPorFechas.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbtDescendente)
        Me.GroupBox2.Controls.Add(Me.rbtAscendente)
        Me.GroupBox2.Location = New System.Drawing.Point(262, 71)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(195, 50)
        Me.GroupBox2.TabIndex = 69
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ordenamiento por Fecha"
        '
        'rbtDescendente
        '
        Me.rbtDescendente.AutoSize = True
        Me.rbtDescendente.Location = New System.Drawing.Point(100, 19)
        Me.rbtDescendente.Name = "rbtDescendente"
        Me.rbtDescendente.Size = New System.Drawing.Size(89, 17)
        Me.rbtDescendente.TabIndex = 69
        Me.rbtDescendente.TabStop = True
        Me.rbtDescendente.Text = "Descendente"
        Me.rbtDescendente.UseVisualStyleBackColor = True
        '
        'rbtAscendente
        '
        Me.rbtAscendente.AutoSize = True
        Me.rbtAscendente.Checked = True
        Me.rbtAscendente.Location = New System.Drawing.Point(9, 19)
        Me.rbtAscendente.Name = "rbtAscendente"
        Me.rbtAscendente.Size = New System.Drawing.Size(82, 17)
        Me.rbtAscendente.TabIndex = 68
        Me.rbtAscendente.TabStop = True
        Me.rbtAscendente.Text = "Ascendente"
        Me.rbtAscendente.UseVisualStyleBackColor = True
        '
        'FrmReportedeVendedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 192)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grpFechas)
        Me.Controls.Add(Me.CmbVendedores)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.mtb)
        Me.Name = "FrmReportedeVendedores"
        Me.Text = "REPORTE DE VENDEDORES"
        Me.grpFechas.ResumeLayout(False)
        Me.grpFechas.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbVendedores As System.Windows.Forms.ComboBox
    Friend WithEvents grpFechas As System.Windows.Forms.GroupBox
    Friend WithEvents chkPorFechas As System.Windows.Forms.CheckBox
    Friend WithEvents dtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtDescendente As System.Windows.Forms.RadioButton
    Friend WithEvents rbtAscendente As System.Windows.Forms.RadioButton
End Class
