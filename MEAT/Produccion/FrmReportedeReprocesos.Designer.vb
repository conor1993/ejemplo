<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportedeReprocesos
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
        Me.GrpFechas = New System.Windows.Forms.GroupBox
        Me.DtpFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.DtpFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtFolio = New IntegraLab.Controles.TextBoxMejorado
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.optAmbas = New System.Windows.Forms.RadioButton
        Me.optProducidas = New System.Windows.Forms.RadioButton
        Me.OptEnviadasaReproceso = New System.Windows.Forms.RadioButton
        Me.GrpFechas.SuspendLayout()
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
        Me.Label4.Size = New System.Drawing.Size(399, 34)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "REPORTE DE REPROCESOS"
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
        Me.mtb.Size = New System.Drawing.Size(50, 208)
        Me.mtb.TabIndex = 16
        '
        'GrpFechas
        '
        Me.GrpFechas.Controls.Add(Me.DtpFechaFinal)
        Me.GrpFechas.Controls.Add(Me.Label3)
        Me.GrpFechas.Controls.Add(Me.DtpFechaInicial)
        Me.GrpFechas.Controls.Add(Me.Label2)
        Me.GrpFechas.Location = New System.Drawing.Point(56, 117)
        Me.GrpFechas.Name = "GrpFechas"
        Me.GrpFechas.Size = New System.Drawing.Size(362, 60)
        Me.GrpFechas.TabIndex = 15
        Me.GrpFechas.TabStop = False
        Me.GrpFechas.Text = "Rango de Fechas"
        Me.GrpFechas.Visible = False
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
        'txtFolio
        '
        Me.txtFolio.ComboBoxEnlazado = Nothing
        Me.txtFolio.Decimales = 0
        Me.txtFolio.Location = New System.Drawing.Point(146, 37)
        Me.txtFolio.MaxLength = 3000
        Me.txtFolio.MensajeCombo = "Seleccionar un item..."
        Me.txtFolio.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.SiguienteControl = Nothing
        Me.txtFolio.Size = New System.Drawing.Size(105, 20)
        Me.txtFolio.TabIndex = 14
        Me.txtFolio.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Folio Lote Corte:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optAmbas)
        Me.GroupBox1.Controls.Add(Me.optProducidas)
        Me.GroupBox1.Controls.Add(Me.OptEnviadasaReproceso)
        Me.GroupBox1.Location = New System.Drawing.Point(55, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(362, 43)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cajas en Reproceso :"
        '
        'optAmbas
        '
        Me.optAmbas.AutoSize = True
        Me.optAmbas.Location = New System.Drawing.Point(229, 19)
        Me.optAmbas.Name = "optAmbas"
        Me.optAmbas.Size = New System.Drawing.Size(57, 17)
        Me.optAmbas.TabIndex = 2
        Me.optAmbas.TabStop = True
        Me.optAmbas.Text = "Ambas"
        Me.optAmbas.UseVisualStyleBackColor = True
        '
        'optProducidas
        '
        Me.optProducidas.AutoSize = True
        Me.optProducidas.Location = New System.Drawing.Point(114, 19)
        Me.optProducidas.Name = "optProducidas"
        Me.optProducidas.Size = New System.Drawing.Size(81, 17)
        Me.optProducidas.TabIndex = 1
        Me.optProducidas.TabStop = True
        Me.optProducidas.Text = "Producidas "
        Me.optProducidas.UseVisualStyleBackColor = True
        '
        'OptEnviadasaReproceso
        '
        Me.OptEnviadasaReproceso.AutoSize = True
        Me.OptEnviadasaReproceso.Location = New System.Drawing.Point(9, 20)
        Me.OptEnviadasaReproceso.Name = "OptEnviadasaReproceso"
        Me.OptEnviadasaReproceso.Size = New System.Drawing.Size(72, 17)
        Me.OptEnviadasaReproceso.TabIndex = 0
        Me.OptEnviadasaReproceso.TabStop = True
        Me.OptEnviadasaReproceso.Text = "Enviadas "
        Me.OptEnviadasaReproceso.UseVisualStyleBackColor = True
        '
        'FrmReportedeReprocesos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 208)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrpFechas)
        Me.Name = "FrmReportedeReprocesos"
        Me.Text = "REPORTE DE REPROCESOS"
        Me.GrpFechas.ResumeLayout(False)
        Me.GrpFechas.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents GrpFechas As System.Windows.Forms.GroupBox
    Friend WithEvents DtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DtpFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFolio As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optAmbas As System.Windows.Forms.RadioButton
    Friend WithEvents optProducidas As System.Windows.Forms.RadioButton
    Friend WithEvents OptEnviadasaReproceso As System.Windows.Forms.RadioButton
End Class
