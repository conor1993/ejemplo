<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRptSalidasEngorda
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
        Me.grpPorFecha = New System.Windows.Forms.GroupBox
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.chkPorFecha = New System.Windows.Forms.CheckBox
        Me.cmbTipoSalida = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chkCanceladas = New System.Windows.Forms.CheckBox
        Me.chkVigentes = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rbnCausaMuerte = New System.Windows.Forms.RadioButton
        Me.rbnCorral = New System.Windows.Forms.RadioButton
        Me.rbnFecha = New System.Windows.Forms.RadioButton
        Me.cmbLote = New System.Windows.Forms.ComboBox
        Me.cmbCausaMuerte = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtLote = New System.Windows.Forms.TextBox
        Me.txtCausaMuerte = New System.Windows.Forms.TextBox
        Me.grpPorFecha.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpPorFecha
        '
        Me.grpPorFecha.Controls.Add(Me.dtpFechaFinal)
        Me.grpPorFecha.Controls.Add(Me.dtpFechaInicial)
        Me.grpPorFecha.Controls.Add(Me.Label6)
        Me.grpPorFecha.Controls.Add(Me.Label5)
        Me.grpPorFecha.Controls.Add(Me.chkPorFecha)
        Me.grpPorFecha.Location = New System.Drawing.Point(55, 122)
        Me.grpPorFecha.Name = "grpPorFecha"
        Me.grpPorFecha.Size = New System.Drawing.Size(204, 92)
        Me.grpPorFecha.TabIndex = 55
        Me.grpPorFecha.TabStop = False
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaFinal.Location = New System.Drawing.Point(94, 55)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(96, 20)
        Me.dtpFechaFinal.TabIndex = 47
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaInicial.Location = New System.Drawing.Point(94, 24)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(96, 20)
        Me.dtpFechaInicial.TabIndex = 46
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Fecha Final :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Fecha Inicial :"
        '
        'chkPorFecha
        '
        Me.chkPorFecha.AutoSize = True
        Me.chkPorFecha.Location = New System.Drawing.Point(6, 0)
        Me.chkPorFecha.Name = "chkPorFecha"
        Me.chkPorFecha.Size = New System.Drawing.Size(81, 17)
        Me.chkPorFecha.TabIndex = 0
        Me.chkPorFecha.Text = "Por Fecha :"
        Me.chkPorFecha.UseVisualStyleBackColor = True
        '
        'cmbTipoSalida
        '
        Me.cmbTipoSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoSalida.FormattingEnabled = True
        Me.cmbTipoSalida.Items.AddRange(New Object() {"Seleccione el Tipo de Salida", "SALIDAS POR TRANSFERENCIAS", "SALIDAS A RASTRO", "SALIDAS A VENTA", "SALIDAS POR MUERTE"})
        Me.cmbTipoSalida.Location = New System.Drawing.Point(172, 41)
        Me.cmbTipoSalida.Name = "cmbTipoSalida"
        Me.cmbTipoSalida.Size = New System.Drawing.Size(322, 21)
        Me.cmbTipoSalida.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Tipo de Salida :"
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
        Me.mtb.Size = New System.Drawing.Size(50, 224)
        Me.mtb.TabIndex = 46
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.SteelBlue
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Location = New System.Drawing.Point(50, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(485, 29)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "REPORTE DE SALIDAS DE CORRALES"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkCanceladas)
        Me.GroupBox2.Controls.Add(Me.chkVigentes)
        Me.GroupBox2.Location = New System.Drawing.Point(265, 123)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(128, 92)
        Me.GroupBox2.TabIndex = 61
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estatus"
        '
        'chkCanceladas
        '
        Me.chkCanceladas.AutoSize = True
        Me.chkCanceladas.Location = New System.Drawing.Point(16, 52)
        Me.chkCanceladas.Name = "chkCanceladas"
        Me.chkCanceladas.Size = New System.Drawing.Size(97, 17)
        Me.chkCanceladas.TabIndex = 49
        Me.chkCanceladas.Text = "CANCELADAS"
        Me.chkCanceladas.UseVisualStyleBackColor = True
        '
        'chkVigentes
        '
        Me.chkVigentes.AutoSize = True
        Me.chkVigentes.Location = New System.Drawing.Point(16, 29)
        Me.chkVigentes.Name = "chkVigentes"
        Me.chkVigentes.Size = New System.Drawing.Size(80, 17)
        Me.chkVigentes.TabIndex = 48
        Me.chkVigentes.Text = "VIGENTES"
        Me.chkVigentes.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbnCausaMuerte)
        Me.GroupBox3.Controls.Add(Me.rbnCorral)
        Me.GroupBox3.Controls.Add(Me.rbnFecha)
        Me.GroupBox3.Location = New System.Drawing.Point(399, 123)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(124, 91)
        Me.GroupBox3.TabIndex = 62
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ordenado Por:"
        '
        'rbnCausaMuerte
        '
        Me.rbnCausaMuerte.AutoSize = True
        Me.rbnCausaMuerte.Location = New System.Drawing.Point(7, 64)
        Me.rbnCausaMuerte.Name = "rbnCausaMuerte"
        Me.rbnCausaMuerte.Size = New System.Drawing.Size(111, 17)
        Me.rbnCausaMuerte.TabIndex = 2
        Me.rbnCausaMuerte.TabStop = True
        Me.rbnCausaMuerte.Text = "Causas de Muerte"
        Me.rbnCausaMuerte.UseVisualStyleBackColor = True
        '
        'rbnCorral
        '
        Me.rbnCorral.AutoSize = True
        Me.rbnCorral.Location = New System.Drawing.Point(7, 42)
        Me.rbnCorral.Name = "rbnCorral"
        Me.rbnCorral.Size = New System.Drawing.Size(52, 17)
        Me.rbnCorral.TabIndex = 1
        Me.rbnCorral.TabStop = True
        Me.rbnCorral.Text = "Corral"
        Me.rbnCorral.UseVisualStyleBackColor = True
        '
        'rbnFecha
        '
        Me.rbnFecha.AutoSize = True
        Me.rbnFecha.Location = New System.Drawing.Point(7, 19)
        Me.rbnFecha.Name = "rbnFecha"
        Me.rbnFecha.Size = New System.Drawing.Size(55, 17)
        Me.rbnFecha.TabIndex = 0
        Me.rbnFecha.TabStop = True
        Me.rbnFecha.Text = "Fecha"
        Me.rbnFecha.UseVisualStyleBackColor = True
        '
        'cmbLote
        '
        Me.cmbLote.FormattingEnabled = True
        Me.cmbLote.Location = New System.Drawing.Point(234, 68)
        Me.cmbLote.Name = "cmbLote"
        Me.cmbLote.Size = New System.Drawing.Size(260, 21)
        Me.cmbLote.TabIndex = 63
        '
        'cmbCausaMuerte
        '
        Me.cmbCausaMuerte.FormattingEnabled = True
        Me.cmbCausaMuerte.Location = New System.Drawing.Point(234, 95)
        Me.cmbCausaMuerte.Name = "cmbCausaMuerte"
        Me.cmbCausaMuerte.Size = New System.Drawing.Size(260, 21)
        Me.cmbCausaMuerte.TabIndex = 64
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Lote :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Causa de Muerte :"
        '
        'txtLote
        '
        Me.txtLote.Location = New System.Drawing.Point(172, 68)
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(56, 20)
        Me.txtLote.TabIndex = 67
        '
        'txtCausaMuerte
        '
        Me.txtCausaMuerte.Location = New System.Drawing.Point(172, 95)
        Me.txtCausaMuerte.Name = "txtCausaMuerte"
        Me.txtCausaMuerte.Size = New System.Drawing.Size(56, 20)
        Me.txtCausaMuerte.TabIndex = 68
        '
        'FrmRptSalidasEngorda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 224)
        Me.Controls.Add(Me.txtCausaMuerte)
        Me.Controls.Add(Me.txtLote)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbCausaMuerte)
        Me.Controls.Add(Me.cmbLote)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.grpPorFecha)
        Me.Controls.Add(Me.cmbTipoSalida)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mtb)
        Me.Name = "FrmRptSalidasEngorda"
        Me.Text = "REPORTE DE SALIDAS DE CORRALES"
        Me.grpPorFecha.ResumeLayout(False)
        Me.grpPorFecha.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpPorFecha As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkPorFecha As System.Windows.Forms.CheckBox
    Friend WithEvents cmbTipoSalida As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCanceladas As System.Windows.Forms.CheckBox
    Friend WithEvents chkVigentes As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbnFecha As System.Windows.Forms.RadioButton
    Friend WithEvents rbnCorral As System.Windows.Forms.RadioButton
    Friend WithEvents cmbLote As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCausaMuerte As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rbnCausaMuerte As System.Windows.Forms.RadioButton
    Friend WithEvents txtLote As System.Windows.Forms.TextBox
    Friend WithEvents txtCausaMuerte As System.Windows.Forms.TextBox
End Class
