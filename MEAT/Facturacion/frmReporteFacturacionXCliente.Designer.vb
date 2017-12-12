<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteFacturacionXCliente
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
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCodigoCliente = New Integralab.Controles.TextBoxMejorado
        Me.cmbCliente = New Integralab.Controles.ComboBoxMejorado
        Me.chkFiltrar = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.dtFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.chkVigentes = New System.Windows.Forms.CheckBox
        Me.chkCanceladas = New System.Windows.Forms.CheckBox
        Me.chkAbonadas = New System.Windows.Forms.CheckBox
        Me.chkPagadas = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(50, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(469, 32)
        Me.lblTitulo.TabIndex = 52
        Me.lblTitulo.Text = "REPORTE DE FACTURACIÓN POR CLIENTE"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.mtb.Size = New System.Drawing.Size(50, 179)
        Me.mtb.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Cliente:"
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.ComboBoxEnlazado = Me.cmbCliente
        Me.txtCodigoCliente.Decimales = 0
        Me.txtCodigoCliente.Location = New System.Drawing.Point(104, 40)
        Me.txtCodigoCliente.MaxLength = 3000
        Me.txtCodigoCliente.MensajeCombo = "Seleccionar un cliente..."
        Me.txtCodigoCliente.MensajeNoExiste = "No existe un cliente con este código o se encuentra inactivo"
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.SiguienteControl = Me.chkFiltrar
        Me.txtCodigoCliente.Size = New System.Drawing.Size(46, 20)
        Me.txtCodigoCliente.TabIndex = 55
        Me.txtCodigoCliente.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        '
        'cmbCliente
        '
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(156, 40)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.NombreMetodo = Nothing
        Me.cmbCliente.Parametros = Nothing
        Me.cmbCliente.SiguienteControl = Me.chkFiltrar
        Me.cmbCliente.Size = New System.Drawing.Size(353, 21)
        Me.cmbCliente.Sorted = True
        Me.cmbCliente.TabIndex = 56
        Me.cmbCliente.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbCliente.TextBoxEnlazado = Me.txtCodigoCliente
        '
        'chkFiltrar
        '
        Me.chkFiltrar.AutoSize = True
        Me.chkFiltrar.Location = New System.Drawing.Point(9, 0)
        Me.chkFiltrar.Name = "chkFiltrar"
        Me.chkFiltrar.Size = New System.Drawing.Size(106, 17)
        Me.chkFiltrar.TabIndex = 58
        Me.chkFiltrar.Text = "Rango de Fecha"
        Me.chkFiltrar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkFiltrar)
        Me.GroupBox1.Controls.Add(Me.dtFechaFinal)
        Me.GroupBox1.Controls.Add(Me.dtFechaInicial)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(172, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(203, 73)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        '
        'dtFechaFinal
        '
        Me.dtFechaFinal.Enabled = False
        Me.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaFinal.Location = New System.Drawing.Point(82, 45)
        Me.dtFechaFinal.Name = "dtFechaFinal"
        Me.dtFechaFinal.Size = New System.Drawing.Size(112, 20)
        Me.dtFechaFinal.TabIndex = 3
        '
        'dtFechaInicial
        '
        Me.dtFechaInicial.Enabled = False
        Me.dtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaInicial.Location = New System.Drawing.Point(82, 19)
        Me.dtFechaInicial.Name = "dtFechaInicial"
        Me.dtFechaInicial.Size = New System.Drawing.Size(112, 20)
        Me.dtFechaInicial.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Fecha Final:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fecha Inicial:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Estatus:"
        '
        'chkVigentes
        '
        Me.chkVigentes.AutoSize = True
        Me.chkVigentes.Checked = True
        Me.chkVigentes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVigentes.Location = New System.Drawing.Point(107, 71)
        Me.chkVigentes.Name = "chkVigentes"
        Me.chkVigentes.Size = New System.Drawing.Size(80, 17)
        Me.chkVigentes.TabIndex = 59
        Me.chkVigentes.Tag = "VIGENTE"
        Me.chkVigentes.Text = "VIGENTES"
        Me.chkVigentes.UseVisualStyleBackColor = True
        '
        'chkCanceladas
        '
        Me.chkCanceladas.AutoSize = True
        Me.chkCanceladas.Checked = True
        Me.chkCanceladas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCanceladas.Location = New System.Drawing.Point(193, 72)
        Me.chkCanceladas.Name = "chkCanceladas"
        Me.chkCanceladas.Size = New System.Drawing.Size(97, 17)
        Me.chkCanceladas.TabIndex = 60
        Me.chkCanceladas.Tag = "CANCELADA"
        Me.chkCanceladas.Text = "CANCELADAS"
        Me.chkCanceladas.UseVisualStyleBackColor = True
        '
        'chkAbonadas
        '
        Me.chkAbonadas.AutoSize = True
        Me.chkAbonadas.Checked = True
        Me.chkAbonadas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAbonadas.Location = New System.Drawing.Point(296, 72)
        Me.chkAbonadas.Name = "chkAbonadas"
        Me.chkAbonadas.Size = New System.Drawing.Size(85, 17)
        Me.chkAbonadas.TabIndex = 61
        Me.chkAbonadas.Tag = "ABONADA"
        Me.chkAbonadas.Text = "ABONADAS"
        Me.chkAbonadas.UseVisualStyleBackColor = True
        '
        'chkPagadas
        '
        Me.chkPagadas.AutoSize = True
        Me.chkPagadas.Checked = True
        Me.chkPagadas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPagadas.Location = New System.Drawing.Point(387, 72)
        Me.chkPagadas.Name = "chkPagadas"
        Me.chkPagadas.Size = New System.Drawing.Size(77, 17)
        Me.chkPagadas.TabIndex = 62
        Me.chkPagadas.Tag = "PAGADA"
        Me.chkPagadas.Text = "PAGADAS"
        Me.chkPagadas.UseVisualStyleBackColor = True
        '
        'frmReporteFacturacionXCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 179)
        Me.Controls.Add(Me.chkPagadas)
        Me.Controls.Add(Me.chkAbonadas)
        Me.Controls.Add(Me.chkCanceladas)
        Me.Controls.Add(Me.chkVigentes)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbCliente)
        Me.Controls.Add(Me.txtCodigoCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmReporteFacturacionXCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Facturación por Cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoCliente As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents cmbCliente As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkFiltrar As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkVigentes As System.Windows.Forms.CheckBox
    Friend WithEvents chkCanceladas As System.Windows.Forms.CheckBox
    Friend WithEvents chkAbonadas As System.Windows.Forms.CheckBox
    Friend WithEvents chkPagadas As System.Windows.Forms.CheckBox
End Class
