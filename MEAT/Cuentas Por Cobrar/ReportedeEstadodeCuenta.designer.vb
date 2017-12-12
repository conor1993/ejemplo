<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportedeEstadodeCuenta
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.chkExcluirPagadas = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DtpFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.DtpFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.grpOrdenamiento = New System.Windows.Forms.GroupBox
        Me.rdbCodigo = New System.Windows.Forms.RadioButton
        Me.rdbFecha = New System.Windows.Forms.RadioButton
        Me.chkFacturasCanceladas = New System.Windows.Forms.CheckBox
        Me.chkResumen = New System.Windows.Forms.CheckBox
        Me.grpOrdenResumen = New System.Windows.Forms.GroupBox
        Me.rbnCliente = New System.Windows.Forms.RadioButton
        Me.rbnSaldoActual = New System.Windows.Forms.RadioButton
        Me.ultcmbCliente = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.bdWorker = New System.ComponentModel.BackgroundWorker
        Me.GroupBox2.SuspendLayout()
        Me.grpOrdenamiento.SuspendLayout()
        Me.grpOrdenResumen.SuspendLayout()
        CType(Me.ultcmbCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Cliente:"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.MaximumSize = New System.Drawing.Size(1600, 900)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(527, 32)
        Me.Label17.TabIndex = 100
        Me.Label17.Text = "REPORTE DE ESTADO DE CUENTA"
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
        Me.mtb.Size = New System.Drawing.Size(50, 172)
        Me.mtb.TabIndex = 99
        '
        'chkExcluirPagadas
        '
        Me.chkExcluirPagadas.AutoSize = True
        Me.chkExcluirPagadas.Location = New System.Drawing.Point(265, 114)
        Me.chkExcluirPagadas.Name = "chkExcluirPagadas"
        Me.chkExcluirPagadas.Size = New System.Drawing.Size(146, 17)
        Me.chkExcluirPagadas.TabIndex = 3
        Me.chkExcluirPagadas.Text = "Excluir Facturas Pagadas"
        Me.chkExcluirPagadas.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DtpFechaFinal)
        Me.GroupBox2.Controls.Add(Me.DtpFechaInicio)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(55, 77)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(194, 83)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rango de Fechas"
        '
        'DtpFechaFinal
        '
        Me.DtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaFinal.Location = New System.Drawing.Point(83, 50)
        Me.DtpFechaFinal.Name = "DtpFechaFinal"
        Me.DtpFechaFinal.Size = New System.Drawing.Size(98, 20)
        Me.DtpFechaFinal.TabIndex = 3
        '
        'DtpFechaInicio
        '
        Me.DtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaInicio.Location = New System.Drawing.Point(83, 22)
        Me.DtpFechaInicio.Name = "DtpFechaInicio"
        Me.DtpFechaInicio.Size = New System.Drawing.Size(98, 20)
        Me.DtpFechaInicio.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Fecha Final :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Fecha Inicio :"
        '
        'grpOrdenamiento
        '
        Me.grpOrdenamiento.Controls.Add(Me.rdbCodigo)
        Me.grpOrdenamiento.Controls.Add(Me.rdbFecha)
        Me.grpOrdenamiento.Location = New System.Drawing.Point(437, 79)
        Me.grpOrdenamiento.Name = "grpOrdenamiento"
        Me.grpOrdenamiento.Size = New System.Drawing.Size(120, 81)
        Me.grpOrdenamiento.TabIndex = 110
        Me.grpOrdenamiento.TabStop = False
        Me.grpOrdenamiento.Text = "Ordenamiento por:"
        '
        'rdbCodigo
        '
        Me.rdbCodigo.AutoSize = True
        Me.rdbCodigo.Checked = True
        Me.rdbCodigo.Location = New System.Drawing.Point(20, 24)
        Me.rdbCodigo.Name = "rdbCodigo"
        Me.rdbCodigo.Size = New System.Drawing.Size(58, 17)
        Me.rdbCodigo.TabIndex = 1
        Me.rdbCodigo.TabStop = True
        Me.rdbCodigo.Text = "Codigo"
        Me.rdbCodigo.UseVisualStyleBackColor = True
        '
        'rdbFecha
        '
        Me.rdbFecha.AutoSize = True
        Me.rdbFecha.Location = New System.Drawing.Point(20, 51)
        Me.rdbFecha.Name = "rdbFecha"
        Me.rdbFecha.Size = New System.Drawing.Size(55, 17)
        Me.rdbFecha.TabIndex = 0
        Me.rdbFecha.Text = "Fecha"
        Me.rdbFecha.UseVisualStyleBackColor = True
        '
        'chkFacturasCanceladas
        '
        Me.chkFacturasCanceladas.AutoSize = True
        Me.chkFacturasCanceladas.Location = New System.Drawing.Point(265, 137)
        Me.chkFacturasCanceladas.Name = "chkFacturasCanceladas"
        Me.chkFacturasCanceladas.Size = New System.Drawing.Size(157, 17)
        Me.chkFacturasCanceladas.TabIndex = 4
        Me.chkFacturasCanceladas.Text = "Incluir Facturas Canceladas"
        Me.chkFacturasCanceladas.UseVisualStyleBackColor = True
        Me.chkFacturasCanceladas.Visible = False
        '
        'chkResumen
        '
        Me.chkResumen.AutoSize = True
        Me.chkResumen.Location = New System.Drawing.Point(265, 91)
        Me.chkResumen.Name = "chkResumen"
        Me.chkResumen.Size = New System.Drawing.Size(71, 17)
        Me.chkResumen.TabIndex = 2
        Me.chkResumen.Text = "Resumen"
        Me.chkResumen.UseVisualStyleBackColor = True
        '
        'grpOrdenResumen
        '
        Me.grpOrdenResumen.Controls.Add(Me.rbnCliente)
        Me.grpOrdenResumen.Controls.Add(Me.rbnSaldoActual)
        Me.grpOrdenResumen.Location = New System.Drawing.Point(437, 79)
        Me.grpOrdenResumen.Name = "grpOrdenResumen"
        Me.grpOrdenResumen.Size = New System.Drawing.Size(120, 81)
        Me.grpOrdenResumen.TabIndex = 5
        Me.grpOrdenResumen.TabStop = False
        Me.grpOrdenResumen.Text = "Ordenamiento por:"
        Me.grpOrdenResumen.Visible = False
        '
        'rbnCliente
        '
        Me.rbnCliente.AutoSize = True
        Me.rbnCliente.Checked = True
        Me.rbnCliente.Location = New System.Drawing.Point(20, 24)
        Me.rbnCliente.Name = "rbnCliente"
        Me.rbnCliente.Size = New System.Drawing.Size(57, 17)
        Me.rbnCliente.TabIndex = 1
        Me.rbnCliente.TabStop = True
        Me.rbnCliente.Text = "Cliente"
        Me.rbnCliente.UseVisualStyleBackColor = True
        '
        'rbnSaldoActual
        '
        Me.rbnSaldoActual.AutoSize = True
        Me.rbnSaldoActual.Location = New System.Drawing.Point(20, 51)
        Me.rbnSaldoActual.Name = "rbnSaldoActual"
        Me.rbnSaldoActual.Size = New System.Drawing.Size(85, 17)
        Me.rbnSaldoActual.TabIndex = 0
        Me.rbnSaldoActual.Text = "Saldo Actual"
        Me.rbnSaldoActual.UseVisualStyleBackColor = True
        '
        'ultcmbCliente
        '
        Me.ultcmbCliente.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.ultcmbCliente.Location = New System.Drawing.Point(105, 46)
        Me.ultcmbCliente.Name = "ultcmbCliente"
        Me.ultcmbCliente.Size = New System.Drawing.Size(369, 21)
        Me.ultcmbCliente.TabIndex = 0
        '
        'bdWorker
        '
        Me.bdWorker.WorkerReportsProgress = True
        '
        'ReportedeEstadodeCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 172)
        Me.Controls.Add(Me.ultcmbCliente)
        Me.Controls.Add(Me.grpOrdenResumen)
        Me.Controls.Add(Me.chkResumen)
        Me.Controls.Add(Me.grpOrdenamiento)
        Me.Controls.Add(Me.chkFacturasCanceladas)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.chkExcluirPagadas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.Name = "ReportedeEstadodeCuenta"
        Me.Text = "Reporte de Estado de Cuenta"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpOrdenamiento.ResumeLayout(False)
        Me.grpOrdenamiento.PerformLayout()
        Me.grpOrdenResumen.ResumeLayout(False)
        Me.grpOrdenResumen.PerformLayout()
        CType(Me.ultcmbCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents chkExcluirPagadas As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grpOrdenamiento As System.Windows.Forms.GroupBox
    Friend WithEvents rdbCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents rdbFecha As System.Windows.Forms.RadioButton
    Friend WithEvents chkFacturasCanceladas As System.Windows.Forms.CheckBox
    Friend WithEvents chkResumen As System.Windows.Forms.CheckBox
    Friend WithEvents grpOrdenResumen As System.Windows.Forms.GroupBox
    Friend WithEvents rbnCliente As System.Windows.Forms.RadioButton
    Friend WithEvents rbnSaldoActual As System.Windows.Forms.RadioButton
    Friend WithEvents ultcmbCliente As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents bdWorker As System.ComponentModel.BackgroundWorker
End Class
