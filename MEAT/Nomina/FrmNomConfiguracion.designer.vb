<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNomConfiguracion
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
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDiasdetrabajo = New IntegraLab.Controles.TextBoxMejorado
        Me.txtHorasDiarias = New IntegraLab.Controles.TextBoxMejorado
        Me.txtMesComercial = New IntegraLab.Controles.TextBoxMejorado
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtSalarioMinimoSinaloa = New IntegraLab.Controles.TextBoxMejorado
        Me.txtSalarioMinimoDF = New IntegraLab.Controles.TextBoxMejorado
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(224, 32)
        Me.Label17.TabIndex = 70
        Me.Label17.Text = "Configuración de Nomina"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 339)
        Me.mtb.TabIndex = 69
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(59, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "Dias de trabajo :"
        '
        'txtDiasdetrabajo
        '
        Me.txtDiasdetrabajo.ComboBoxEnlazado = Nothing
        Me.txtDiasdetrabajo.Decimales = 0
        Me.txtDiasdetrabajo.Location = New System.Drawing.Point(181, 153)
        Me.txtDiasdetrabajo.MaxLength = 3000
        Me.txtDiasdetrabajo.MensajeCombo = "Seleccionar un item..."
        Me.txtDiasdetrabajo.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtDiasdetrabajo.Name = "txtDiasdetrabajo"
        Me.txtDiasdetrabajo.SiguienteControl = Nothing
        Me.txtDiasdetrabajo.Size = New System.Drawing.Size(58, 20)
        Me.txtDiasdetrabajo.TabIndex = 83
        Me.txtDiasdetrabajo.Text = "0"
        Me.txtDiasdetrabajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDiasdetrabajo.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        '
        'txtHorasDiarias
        '
        Me.txtHorasDiarias.ComboBoxEnlazado = Nothing
        Me.txtHorasDiarias.Decimales = 0
        Me.txtHorasDiarias.Location = New System.Drawing.Point(181, 130)
        Me.txtHorasDiarias.MaxLength = 3000
        Me.txtHorasDiarias.MensajeCombo = "Seleccionar un item..."
        Me.txtHorasDiarias.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtHorasDiarias.Name = "txtHorasDiarias"
        Me.txtHorasDiarias.SiguienteControl = Nothing
        Me.txtHorasDiarias.Size = New System.Drawing.Size(58, 20)
        Me.txtHorasDiarias.TabIndex = 79
        Me.txtHorasDiarias.Text = "0"
        Me.txtHorasDiarias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtHorasDiarias.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        '
        'txtMesComercial
        '
        Me.txtMesComercial.ComboBoxEnlazado = Nothing
        Me.txtMesComercial.Decimales = 0
        Me.txtMesComercial.Location = New System.Drawing.Point(181, 105)
        Me.txtMesComercial.MaxLength = 3000
        Me.txtMesComercial.MensajeCombo = "Seleccionar un item..."
        Me.txtMesComercial.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtMesComercial.Name = "txtMesComercial"
        Me.txtMesComercial.SiguienteControl = Nothing
        Me.txtMesComercial.Size = New System.Drawing.Size(58, 20)
        Me.txtMesComercial.TabIndex = 78
        Me.txtMesComercial.Text = "0"
        Me.txtMesComercial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtMesComercial.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(58, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 13)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "Horas diarias de trabajo :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(59, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Mes Comercial :"
        '
        'txtSalarioMinimoSinaloa
        '
        Me.txtSalarioMinimoSinaloa.ComboBoxEnlazado = Nothing
        Me.txtSalarioMinimoSinaloa.Decimales = 0
        Me.txtSalarioMinimoSinaloa.Location = New System.Drawing.Point(181, 80)
        Me.txtSalarioMinimoSinaloa.MaxLength = 3000
        Me.txtSalarioMinimoSinaloa.MensajeCombo = "Seleccionar un item..."
        Me.txtSalarioMinimoSinaloa.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtSalarioMinimoSinaloa.Name = "txtSalarioMinimoSinaloa"
        Me.txtSalarioMinimoSinaloa.SiguienteControl = Nothing
        Me.txtSalarioMinimoSinaloa.Size = New System.Drawing.Size(58, 20)
        Me.txtSalarioMinimoSinaloa.TabIndex = 75
        Me.txtSalarioMinimoSinaloa.Text = "0"
        Me.txtSalarioMinimoSinaloa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSalarioMinimoSinaloa.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        '
        'txtSalarioMinimoDF
        '
        Me.txtSalarioMinimoDF.ComboBoxEnlazado = Nothing
        Me.txtSalarioMinimoDF.Decimales = 0
        Me.txtSalarioMinimoDF.Location = New System.Drawing.Point(181, 52)
        Me.txtSalarioMinimoDF.MaxLength = 3000
        Me.txtSalarioMinimoDF.MensajeCombo = "Seleccionar un item..."
        Me.txtSalarioMinimoDF.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtSalarioMinimoDF.Name = "txtSalarioMinimoDF"
        Me.txtSalarioMinimoDF.SiguienteControl = Nothing
        Me.txtSalarioMinimoDF.Size = New System.Drawing.Size(58, 20)
        Me.txtSalarioMinimoDF.TabIndex = 74
        Me.txtSalarioMinimoDF.Text = "0"
        Me.txtSalarioMinimoDF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSalarioMinimoDF.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.[Decimal]
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Salario Minimo DF : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 13)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Salario Minimo Sinaloa :"
        '
        'FrmNomConfiguracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 339)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDiasdetrabajo)
        Me.Controls.Add(Me.txtHorasDiarias)
        Me.Controls.Add(Me.txtMesComercial)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSalarioMinimoSinaloa)
        Me.Controls.Add(Me.txtSalarioMinimoDF)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.Name = "FrmNomConfiguracion"
        Me.Text = "Configuración de Nomina"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDiasdetrabajo As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtHorasDiarias As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtMesComercial As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSalarioMinimoSinaloa As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtSalarioMinimoDF As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
