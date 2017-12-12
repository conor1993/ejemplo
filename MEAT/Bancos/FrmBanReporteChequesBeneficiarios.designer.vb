<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBanReporteChequesBeneficiarios
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
        Me.Label17 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.GrpFechas = New System.Windows.Forms.GroupBox
        Me.DtpFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.DtpFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbBeneficiario = New Integralab.Controles.ComboBoxMejorado
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdbFecha = New System.Windows.Forms.RadioButton
        Me.rdbNombre = New System.Windows.Forms.RadioButton
        Me.txtCodigoBeneficiario = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chkCancelado = New System.Windows.Forms.CheckBox
        Me.chkVigente = New System.Windows.Forms.CheckBox
        Me.GrpFechas.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(0, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(429, 32)
        Me.Label17.TabIndex = 58
        Me.Label17.Text = "Cheques por Beneficiarios"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mtb
        '
        Me.mtb.ButtonSize = New System.Drawing.Size(50, 50)
        Me.mtb.Dock = System.Windows.Forms.DockStyle.None
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
        Me.mtb.Location = New System.Drawing.Point(0, -15)
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
        Me.mtb.Size = New System.Drawing.Size(50, 266)
        Me.mtb.TabIndex = 60
        '
        'GrpFechas
        '
        Me.GrpFechas.Controls.Add(Me.DtpFechaFinal)
        Me.GrpFechas.Controls.Add(Me.Label3)
        Me.GrpFechas.Controls.Add(Me.DtpFechaInicial)
        Me.GrpFechas.Controls.Add(Me.Label2)
        Me.GrpFechas.Location = New System.Drawing.Point(56, 70)
        Me.GrpFechas.Name = "GrpFechas"
        Me.GrpFechas.Size = New System.Drawing.Size(362, 60)
        Me.GrpFechas.TabIndex = 59
        Me.GrpFechas.TabStop = False
        Me.GrpFechas.Text = "Rango de Fechas"
        '
        'DtpFechaFinal
        '
        Me.DtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaFinal.Location = New System.Drawing.Point(268, 22)
        Me.DtpFechaFinal.Name = "DtpFechaFinal"
        Me.DtpFechaFinal.Size = New System.Drawing.Size(88, 20)
        Me.DtpFechaFinal.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(192, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha Final:"
        '
        'DtpFechaInicial
        '
        Me.DtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaInicial.Location = New System.Drawing.Point(82, 22)
        Me.DtpFechaInicial.Name = "DtpFechaInicial"
        Me.DtpFechaInicial.Size = New System.Drawing.Size(88, 20)
        Me.DtpFechaInicial.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fecha Inicial:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Beneficiario :"
        '
        'cmbBeneficiario
        '
        Me.cmbBeneficiario.FormattingEnabled = True
        Me.cmbBeneficiario.Location = New System.Drawing.Point(179, 43)
        Me.cmbBeneficiario.Name = "cmbBeneficiario"
        Me.cmbBeneficiario.NombreMetodo = Nothing
        Me.cmbBeneficiario.Parametros = Nothing
        Me.cmbBeneficiario.SiguienteControl = Nothing
        Me.cmbBeneficiario.Size = New System.Drawing.Size(239, 21)
        Me.cmbBeneficiario.TabIndex = 1
        Me.cmbBeneficiario.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbBeneficiario.TextBoxEnlazado = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbFecha)
        Me.GroupBox1.Controls.Add(Me.rdbNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(161, 48)
        Me.GroupBox1.TabIndex = 68
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ordenado por "
        '
        'rdbFecha
        '
        Me.rdbFecha.AutoSize = True
        Me.rdbFecha.Location = New System.Drawing.Point(97, 19)
        Me.rdbFecha.Name = "rdbFecha"
        Me.rdbFecha.Size = New System.Drawing.Size(55, 17)
        Me.rdbFecha.TabIndex = 1
        Me.rdbFecha.TabStop = True
        Me.rdbFecha.Text = "Fecha"
        Me.rdbFecha.UseVisualStyleBackColor = True
        '
        'rdbNombre
        '
        Me.rdbNombre.AutoSize = True
        Me.rdbNombre.Location = New System.Drawing.Point(11, 19)
        Me.rdbNombre.Name = "rdbNombre"
        Me.rdbNombre.Size = New System.Drawing.Size(80, 17)
        Me.rdbNombre.TabIndex = 0
        Me.rdbNombre.TabStop = True
        Me.rdbNombre.Text = "Beneficiario"
        Me.rdbNombre.UseVisualStyleBackColor = True
        '
        'txtCodigoBeneficiario
        '
        Me.txtCodigoBeneficiario.Location = New System.Drawing.Point(130, 43)
        Me.txtCodigoBeneficiario.Name = "txtCodigoBeneficiario"
        Me.txtCodigoBeneficiario.Size = New System.Drawing.Size(43, 20)
        Me.txtCodigoBeneficiario.TabIndex = 69
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkCancelado)
        Me.GroupBox2.Controls.Add(Me.chkVigente)
        Me.GroupBox2.Location = New System.Drawing.Point(223, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(194, 48)
        Me.GroupBox2.TabIndex = 69
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrado por "
        '
        'chkCancelado
        '
        Me.chkCancelado.AutoSize = True
        Me.chkCancelado.Location = New System.Drawing.Point(101, 19)
        Me.chkCancelado.Name = "chkCancelado"
        Me.chkCancelado.Size = New System.Drawing.Size(77, 17)
        Me.chkCancelado.TabIndex = 1
        Me.chkCancelado.Text = "Cancelado"
        Me.chkCancelado.UseVisualStyleBackColor = True
        '
        'chkVigente
        '
        Me.chkVigente.AutoSize = True
        Me.chkVigente.Location = New System.Drawing.Point(19, 19)
        Me.chkVigente.Name = "chkVigente"
        Me.chkVigente.Size = New System.Drawing.Size(62, 17)
        Me.chkVigente.TabIndex = 0
        Me.chkVigente.Text = "Vigente"
        Me.chkVigente.UseVisualStyleBackColor = True
        '
        'FrmBanReporteChequesBeneficiarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 195)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtCodigoBeneficiario)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbBeneficiario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.GrpFechas)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(437, 229)
        Me.MinimumSize = New System.Drawing.Size(437, 229)
        Me.Name = "FrmBanReporteChequesBeneficiarios"
        Me.Text = "Cheques por Beneficiario"
        Me.GrpFechas.ResumeLayout(False)
        Me.GrpFechas.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents GrpFechas As System.Windows.Forms.GroupBox
    Friend WithEvents DtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DtpFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbBeneficiario As Integralab.Controles.ComboBoxMejorado
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbFecha As System.Windows.Forms.RadioButton
    Friend WithEvents rdbNombre As System.Windows.Forms.RadioButton
    Friend WithEvents txtCodigoBeneficiario As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCancelado As System.Windows.Forms.CheckBox
    Friend WithEvents chkVigente As System.Windows.Forms.CheckBox
End Class
