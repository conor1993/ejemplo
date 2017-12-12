<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteProductos
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
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar
        Me.Label17 = New System.Windows.Forms.Label
        Me.cmbIntroductor = New System.Windows.Forms.ComboBox
        Me.txtCodigoIntroductor = New Integralab.Controles.TextBoxMejorado
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtFolioSacrificio = New Integralab.Controles.TextBoxMejorado
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DtFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.dtFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MEAToolBar1
        '
        Me.MEAToolBar1.ButtonSize = New System.Drawing.Size(50, 50)
        Me.MEAToolBar1.Dock = System.Windows.Forms.DockStyle.Left
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
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 187)
        Me.MEAToolBar1.TabIndex = 31
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(483, 32)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "REPORTE DE PRODUCTOS"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbIntroductor
        '
        Me.cmbIntroductor.FormattingEnabled = True
        Me.cmbIntroductor.Location = New System.Drawing.Point(205, 67)
        Me.cmbIntroductor.Name = "cmbIntroductor"
        Me.cmbIntroductor.Size = New System.Drawing.Size(309, 21)
        Me.cmbIntroductor.TabIndex = 65
        '
        'txtCodigoIntroductor
        '
        Me.txtCodigoIntroductor.ComboBoxEnlazado = Me.cmbIntroductor
        Me.txtCodigoIntroductor.Decimales = 0
        Me.txtCodigoIntroductor.Location = New System.Drawing.Point(158, 67)
        Me.txtCodigoIntroductor.MaxLength = 3000
        Me.txtCodigoIntroductor.MensajeCombo = "Seleccionar un Introductor..."
        Me.txtCodigoIntroductor.MensajeNoExiste = "No existe un Introductor con este código o se encuentra inactivo"
        Me.txtCodigoIntroductor.Name = "txtCodigoIntroductor"
        Me.txtCodigoIntroductor.SiguienteControl = Me.cmbIntroductor
        Me.txtCodigoIntroductor.Size = New System.Drawing.Size(41, 20)
        Me.txtCodigoIntroductor.TabIndex = 64
        Me.txtCodigoIntroductor.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Introductor:"
        '
        'txtFolioSacrificio
        '
        Me.txtFolioSacrificio.ComboBoxEnlazado = Nothing
        Me.txtFolioSacrificio.Decimales = 0
        Me.txtFolioSacrificio.Location = New System.Drawing.Point(158, 41)
        Me.txtFolioSacrificio.MensajeCombo = "Seleccionar un item..."
        Me.txtFolioSacrificio.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtFolioSacrificio.Name = "txtFolioSacrificio"
        Me.txtFolioSacrificio.SiguienteControl = Nothing
        Me.txtFolioSacrificio.Size = New System.Drawing.Size(100, 20)
        Me.txtFolioSacrificio.TabIndex = 62
        Me.txtFolioSacrificio.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Folio de Sacrificio:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DtFechaFinal)
        Me.GroupBox1.Controls.Add(Me.dtFechaInicial)
        Me.GroupBox1.Location = New System.Drawing.Point(62, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(186, 78)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rengo de Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Fecha Final:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Fecha Inicio:"
        '
        'DtFechaFinal
        '
        Me.DtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaFinal.Location = New System.Drawing.Point(80, 46)
        Me.DtFechaFinal.Name = "DtFechaFinal"
        Me.DtFechaFinal.Size = New System.Drawing.Size(96, 20)
        Me.DtFechaFinal.TabIndex = 1
        '
        'dtFechaInicial
        '
        Me.dtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaInicial.Location = New System.Drawing.Point(80, 20)
        Me.dtFechaInicial.Name = "dtFechaInicial"
        Me.dtFechaInicial.Size = New System.Drawing.Size(96, 20)
        Me.dtFechaInicial.TabIndex = 0
        '
        'FrmReporteProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 187)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbIntroductor)
        Me.Controls.Add(Me.txtCodigoIntroductor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtFolioSacrificio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmReporteProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Productos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmbIntroductor As System.Windows.Forms.ComboBox
    Friend WithEvents txtCodigoIntroductor As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFolioSacrificio As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DtFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFechaInicial As System.Windows.Forms.DateTimePicker
End Class
