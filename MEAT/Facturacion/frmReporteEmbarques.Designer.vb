<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteEmbarques
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtFolio = New Integralab.Controles.TextBoxMejorado
        Me.txtCodigoCLiente = New Integralab.Controles.TextBoxMejorado
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbCLiente = New Integralab.Controles.ComboBoxMejorado
        Me.chkFiltrar = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.DtFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.dtFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chkCancelados = New System.Windows.Forms.CheckBox
        Me.chkFacturados = New System.Windows.Forms.CheckBox
        Me.chkVigente = New System.Windows.Forms.CheckBox
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
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(500, 32)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "REPORTE DE EMBARQUES"
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
        Me.mtb.MostrarCancelar = False
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = False
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 206)
        Me.mtb.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Folio:"
        '
        'txtFolio
        '
        Me.txtFolio.ComboBoxEnlazado = Nothing
        Me.txtFolio.Decimales = 0
        Me.txtFolio.Location = New System.Drawing.Point(94, 44)
        Me.txtFolio.MensajeCombo = "Seleccionar un item..."
        Me.txtFolio.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.SiguienteControl = Me.txtCodigoCLiente
        Me.txtFolio.Size = New System.Drawing.Size(100, 20)
        Me.txtFolio.TabIndex = 3
        Me.txtFolio.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'txtCodigoCLiente
        '
        Me.txtCodigoCLiente.ComboBoxEnlazado = Me.cmbCLiente
        Me.txtCodigoCLiente.Decimales = 0
        Me.txtCodigoCLiente.Location = New System.Drawing.Point(104, 70)
        Me.txtCodigoCLiente.MaxLength = 3000
        Me.txtCodigoCLiente.MensajeCombo = "Seleccionar un cliente..."
        Me.txtCodigoCLiente.MensajeNoExiste = "No existe un cliente con este código o se encuentra inactivo"
        Me.txtCodigoCLiente.Name = "txtCodigoCLiente"
        Me.txtCodigoCLiente.SiguienteControl = Me.chkFiltrar
        Me.txtCodigoCLiente.Size = New System.Drawing.Size(47, 20)
        Me.txtCodigoCLiente.TabIndex = 5
        Me.txtCodigoCLiente.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cliente:"
        '
        'cmbCLiente
        '
        Me.cmbCLiente.FormattingEnabled = True
        Me.cmbCLiente.Location = New System.Drawing.Point(157, 70)
        Me.cmbCLiente.Name = "cmbCLiente"
        Me.cmbCLiente.NombreMetodo = Nothing
        Me.cmbCLiente.Parametros = Nothing
        Me.cmbCLiente.SiguienteControl = Me.chkFiltrar
        Me.cmbCLiente.Size = New System.Drawing.Size(381, 21)
        Me.cmbCLiente.TabIndex = 6
        Me.cmbCLiente.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbCLiente.TextBoxEnlazado = Nothing
        '
        'chkFiltrar
        '
        Me.chkFiltrar.AutoSize = True
        Me.chkFiltrar.Location = New System.Drawing.Point(59, 97)
        Me.chkFiltrar.Name = "chkFiltrar"
        Me.chkFiltrar.Size = New System.Drawing.Size(115, 17)
        Me.chkFiltrar.TabIndex = 7
        Me.chkFiltrar.Text = "¿Filtrar Por Fecha?"
        Me.chkFiltrar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DtFechaFinal)
        Me.GroupBox1.Controls.Add(Me.dtFechaInicial)
        Me.GroupBox1.Location = New System.Drawing.Point(54, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(186, 78)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rengo de Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha Final:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Fecha Inicio:"
        '
        'DtFechaFinal
        '
        Me.DtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaFinal.Location = New System.Drawing.Point(80, 46)
        Me.DtFechaFinal.Name = "DtFechaFinal"
        Me.DtFechaFinal.Size = New System.Drawing.Size(96, 20)
        Me.DtFechaFinal.TabIndex = 3
        '
        'dtFechaInicial
        '
        Me.dtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaInicial.Location = New System.Drawing.Point(80, 20)
        Me.dtFechaInicial.Name = "dtFechaInicial"
        Me.dtFechaInicial.Size = New System.Drawing.Size(96, 20)
        Me.dtFechaInicial.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkCancelados)
        Me.GroupBox2.Controls.Add(Me.chkFacturados)
        Me.GroupBox2.Controls.Add(Me.chkVigente)
        Me.GroupBox2.Location = New System.Drawing.Point(246, 110)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(97, 88)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estatus"
        '
        'chkCancelados
        '
        Me.chkCancelados.AutoSize = True
        Me.chkCancelados.Checked = True
        Me.chkCancelados.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCancelados.Location = New System.Drawing.Point(6, 65)
        Me.chkCancelados.Name = "chkCancelados"
        Me.chkCancelados.Size = New System.Drawing.Size(82, 17)
        Me.chkCancelados.TabIndex = 2
        Me.chkCancelados.Text = "Cancelados"
        Me.chkCancelados.UseVisualStyleBackColor = True
        '
        'chkFacturados
        '
        Me.chkFacturados.AutoSize = True
        Me.chkFacturados.Checked = True
        Me.chkFacturados.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFacturados.Location = New System.Drawing.Point(6, 42)
        Me.chkFacturados.Name = "chkFacturados"
        Me.chkFacturados.Size = New System.Drawing.Size(79, 17)
        Me.chkFacturados.TabIndex = 1
        Me.chkFacturados.Text = "Facturados"
        Me.chkFacturados.UseVisualStyleBackColor = True
        '
        'chkVigente
        '
        Me.chkVigente.AutoSize = True
        Me.chkVigente.Checked = True
        Me.chkVigente.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVigente.Location = New System.Drawing.Point(6, 19)
        Me.chkVigente.Name = "chkVigente"
        Me.chkVigente.Size = New System.Drawing.Size(67, 17)
        Me.chkVigente.TabIndex = 0
        Me.chkVigente.Text = "Vigentes"
        Me.chkVigente.UseVisualStyleBackColor = True
        '
        'frmReporteEmbarques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 206)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkFiltrar)
        Me.Controls.Add(Me.cmbCLiente)
        Me.Controls.Add(Me.txtCodigoCLiente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmReporteEmbarques"
        Me.Text = "Reporte de Embarques"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFolio As Integralab.Controles.TextBoxMejorado
    Friend WithEvents txtCodigoCLiente As Integralab.Controles.TextBoxMejorado
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbCLiente As Integralab.Controles.ComboBoxMejorado
    Friend WithEvents chkFiltrar As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DtFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCancelados As System.Windows.Forms.CheckBox
    Friend WithEvents chkFacturados As System.Windows.Forms.CheckBox
    Friend WithEvents chkVigente As System.Windows.Forms.CheckBox
End Class
