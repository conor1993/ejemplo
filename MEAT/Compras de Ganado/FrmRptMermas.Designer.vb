<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRptMermas
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
        Me.cmbChofer = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbLugarDeCompra = New System.Windows.Forms.ComboBox
        Me.cmbComisionista = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbProveedor = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtLugarDeCompra = New System.Windows.Forms.TextBox
        Me.txtChofer = New System.Windows.Forms.TextBox
        Me.txtComisionista = New System.Windows.Forms.TextBox
        Me.txtProveedor = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chkCanceladas = New System.Windows.Forms.CheckBox
        Me.chkVigentes = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rbnChofer = New System.Windows.Forms.RadioButton
        Me.rbnLugarCompra = New System.Windows.Forms.RadioButton
        Me.rbnComprador = New System.Windows.Forms.RadioButton
        Me.rbnProveedor = New System.Windows.Forms.RadioButton
        Me.rbnFecha = New System.Windows.Forms.RadioButton
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
        Me.grpPorFecha.Location = New System.Drawing.Point(59, 150)
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
        'cmbChofer
        '
        Me.cmbChofer.FormattingEnabled = True
        Me.cmbChofer.Location = New System.Drawing.Point(214, 123)
        Me.cmbChofer.Name = "cmbChofer"
        Me.cmbChofer.Size = New System.Drawing.Size(287, 21)
        Me.cmbChofer.TabIndex = 54
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Chofer :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Lugar de Compra :"
        '
        'cmbLugarDeCompra
        '
        Me.cmbLugarDeCompra.FormattingEnabled = True
        Me.cmbLugarDeCompra.Location = New System.Drawing.Point(214, 96)
        Me.cmbLugarDeCompra.Name = "cmbLugarDeCompra"
        Me.cmbLugarDeCompra.Size = New System.Drawing.Size(287, 21)
        Me.cmbLugarDeCompra.TabIndex = 51
        '
        'cmbComisionista
        '
        Me.cmbComisionista.FormattingEnabled = True
        Me.cmbComisionista.Location = New System.Drawing.Point(214, 69)
        Me.cmbComisionista.Name = "cmbComisionista"
        Me.cmbComisionista.Size = New System.Drawing.Size(287, 21)
        Me.cmbComisionista.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Comisionista :"
        '
        'cmbProveedor
        '
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(214, 40)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(287, 21)
        Me.cmbProveedor.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Proveedor :"
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
        Me.mtb.Size = New System.Drawing.Size(50, 251)
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
        Me.Label7.Size = New System.Drawing.Size(579, 29)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "REPORTE DE MERMAS"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLugarDeCompra
        '
        Me.txtLugarDeCompra.Location = New System.Drawing.Point(156, 97)
        Me.txtLugarDeCompra.Name = "txtLugarDeCompra"
        Me.txtLugarDeCompra.Size = New System.Drawing.Size(52, 20)
        Me.txtLugarDeCompra.TabIndex = 57
        '
        'txtChofer
        '
        Me.txtChofer.Location = New System.Drawing.Point(156, 124)
        Me.txtChofer.Name = "txtChofer"
        Me.txtChofer.Size = New System.Drawing.Size(52, 20)
        Me.txtChofer.TabIndex = 58
        '
        'txtComisionista
        '
        Me.txtComisionista.Location = New System.Drawing.Point(156, 70)
        Me.txtComisionista.Name = "txtComisionista"
        Me.txtComisionista.Size = New System.Drawing.Size(52, 20)
        Me.txtComisionista.TabIndex = 59
        '
        'txtProveedor
        '
        Me.txtProveedor.Location = New System.Drawing.Point(156, 41)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(52, 20)
        Me.txtProveedor.TabIndex = 60
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkCanceladas)
        Me.GroupBox2.Controls.Add(Me.chkVigentes)
        Me.GroupBox2.Location = New System.Drawing.Point(269, 151)
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
        Me.GroupBox3.Controls.Add(Me.rbnChofer)
        Me.GroupBox3.Controls.Add(Me.rbnLugarCompra)
        Me.GroupBox3.Controls.Add(Me.rbnComprador)
        Me.GroupBox3.Controls.Add(Me.rbnProveedor)
        Me.GroupBox3.Controls.Add(Me.rbnFecha)
        Me.GroupBox3.Location = New System.Drawing.Point(403, 151)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(214, 91)
        Me.GroupBox3.TabIndex = 62
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ordenado Por:"
        '
        'rbnChofer
        '
        Me.rbnChofer.AutoSize = True
        Me.rbnChofer.Location = New System.Drawing.Point(101, 41)
        Me.rbnChofer.Name = "rbnChofer"
        Me.rbnChofer.Size = New System.Drawing.Size(56, 17)
        Me.rbnChofer.TabIndex = 4
        Me.rbnChofer.TabStop = True
        Me.rbnChofer.Text = "Chofer"
        Me.rbnChofer.UseVisualStyleBackColor = True
        '
        'rbnLugarCompra
        '
        Me.rbnLugarCompra.AutoSize = True
        Me.rbnLugarCompra.Location = New System.Drawing.Point(101, 18)
        Me.rbnLugarCompra.Name = "rbnLugarCompra"
        Me.rbnLugarCompra.Size = New System.Drawing.Size(106, 17)
        Me.rbnLugarCompra.TabIndex = 3
        Me.rbnLugarCompra.TabStop = True
        Me.rbnLugarCompra.Text = "Lugar de Compra"
        Me.rbnLugarCompra.UseVisualStyleBackColor = True
        '
        'rbnComprador
        '
        Me.rbnComprador.AutoSize = True
        Me.rbnComprador.Location = New System.Drawing.Point(8, 64)
        Me.rbnComprador.Name = "rbnComprador"
        Me.rbnComprador.Size = New System.Drawing.Size(76, 17)
        Me.rbnComprador.TabIndex = 2
        Me.rbnComprador.TabStop = True
        Me.rbnComprador.Text = "Comprador"
        Me.rbnComprador.UseVisualStyleBackColor = True
        '
        'rbnProveedor
        '
        Me.rbnProveedor.AutoSize = True
        Me.rbnProveedor.Location = New System.Drawing.Point(8, 41)
        Me.rbnProveedor.Name = "rbnProveedor"
        Me.rbnProveedor.Size = New System.Drawing.Size(74, 17)
        Me.rbnProveedor.TabIndex = 1
        Me.rbnProveedor.TabStop = True
        Me.rbnProveedor.Text = "Proveedor"
        Me.rbnProveedor.UseVisualStyleBackColor = True
        '
        'rbnFecha
        '
        Me.rbnFecha.AutoSize = True
        Me.rbnFecha.Location = New System.Drawing.Point(8, 18)
        Me.rbnFecha.Name = "rbnFecha"
        Me.rbnFecha.Size = New System.Drawing.Size(55, 17)
        Me.rbnFecha.TabIndex = 0
        Me.rbnFecha.TabStop = True
        Me.rbnFecha.Text = "Fecha"
        Me.rbnFecha.UseVisualStyleBackColor = True
        '
        'FrmRptMermas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 251)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtProveedor)
        Me.Controls.Add(Me.txtComisionista)
        Me.Controls.Add(Me.txtChofer)
        Me.Controls.Add(Me.txtLugarDeCompra)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.grpPorFecha)
        Me.Controls.Add(Me.cmbChofer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbLugarDeCompra)
        Me.Controls.Add(Me.cmbComisionista)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbProveedor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mtb)
        Me.Name = "FrmRptMermas"
        Me.Text = "REPORTE DE MERMAS"
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
    Friend WithEvents cmbChofer As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbLugarDeCompra As System.Windows.Forms.ComboBox
    Friend WithEvents cmbComisionista As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtLugarDeCompra As System.Windows.Forms.TextBox
    Friend WithEvents txtChofer As System.Windows.Forms.TextBox
    Friend WithEvents txtComisionista As System.Windows.Forms.TextBox
    Friend WithEvents txtProveedor As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCanceladas As System.Windows.Forms.CheckBox
    Friend WithEvents chkVigentes As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbnFecha As System.Windows.Forms.RadioButton
    Friend WithEvents rbnComprador As System.Windows.Forms.RadioButton
    Friend WithEvents rbnProveedor As System.Windows.Forms.RadioButton
    Friend WithEvents rbnChofer As System.Windows.Forms.RadioButton
    Friend WithEvents rbnLugarCompra As System.Windows.Forms.RadioButton
End Class
