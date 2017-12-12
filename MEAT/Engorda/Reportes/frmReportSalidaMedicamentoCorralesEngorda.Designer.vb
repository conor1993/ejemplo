<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportSalidaMedicamentoCorralesEngorda
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Label17 = New System.Windows.Forms.Label
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbLote = New Integralab.Controles.ComboBoxMejorado
        Me.txtIdLote = New Integralab.Controles.TextBoxMejorado
        Me.dtFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.dtFechaFin = New System.Windows.Forms.DateTimePicker
        Me.gbRangoFechas = New System.Windows.Forms.GroupBox
        Me.chkFiltrar = New System.Windows.Forms.CheckBox
        Me.gbTipoReporte = New System.Windows.Forms.GroupBox
        Me.chkMedicamentoProrrateo = New System.Windows.Forms.CheckBox
        Me.chkProrrateoMedicamento = New System.Windows.Forms.CheckBox
        Me.chkMedicamentoAplicacion = New System.Windows.Forms.CheckBox
        Me.chkAplicacionMedicamento = New System.Windows.Forms.CheckBox
        Me.chkTodos = New System.Windows.Forms.CheckBox
        Me.gbRangoFechas.SuspendLayout()
        Me.gbTipoReporte.SuspendLayout()
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
        Me.Label17.Size = New System.Drawing.Size(629, 32)
        Me.Label17.TabIndex = 51
        Me.Label17.Text = "REPORTE DE SALIDAS DE MEDICAMENTO A CORRALES DE ENGORDA"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 178)
        Me.MEAToolBar1.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Fin:"
        '
        'cmbLote
        '
        Me.cmbLote.FormattingEnabled = True
        Me.cmbLote.Location = New System.Drawing.Point(171, 35)
        Me.cmbLote.Name = "cmbLote"
        Me.cmbLote.NombreMetodo = Nothing
        Me.cmbLote.Parametros = Nothing
        Me.cmbLote.SiguienteControl = Nothing
        Me.cmbLote.Size = New System.Drawing.Size(346, 21)
        Me.cmbLote.TabIndex = 57
        Me.cmbLote.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbLote.TextBoxEnlazado = Me.txtIdLote
        '
        'txtIdLote
        '
        Me.txtIdLote.ComboBoxEnlazado = Me.cmbLote
        Me.txtIdLote.Decimales = 0
        Me.txtIdLote.Location = New System.Drawing.Point(112, 35)
        Me.txtIdLote.MaxLength = 3000
        Me.txtIdLote.MensajeCombo = "Seleccionar un lote..."
        Me.txtIdLote.MensajeNoExiste = "No existe un Lote con este código o se encuentra inactivo"
        Me.txtIdLote.Name = "txtIdLote"
        Me.txtIdLote.SiguienteControl = Nothing
        Me.txtIdLote.Size = New System.Drawing.Size(53, 20)
        Me.txtIdLote.TabIndex = 56
        Me.txtIdLote.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtIdLote.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtIdLote.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'dtFechaInicio
        '
        Me.dtFechaInicio.CustomFormat = "dd/MMM/yyyy"
        Me.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFechaInicio.Location = New System.Drawing.Point(52, 18)
        Me.dtFechaInicio.Name = "dtFechaInicio"
        Me.dtFechaInicio.Size = New System.Drawing.Size(110, 20)
        Me.dtFechaInicio.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Inicio:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(55, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Lote:"
        '
        'dtFechaFin
        '
        Me.dtFechaFin.CustomFormat = "dd/MMM/yyyy"
        Me.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFechaFin.Location = New System.Drawing.Point(52, 44)
        Me.dtFechaFin.Name = "dtFechaFin"
        Me.dtFechaFin.Size = New System.Drawing.Size(110, 20)
        Me.dtFechaFin.TabIndex = 11
        '
        'gbRangoFechas
        '
        Me.gbRangoFechas.Controls.Add(Me.dtFechaFin)
        Me.gbRangoFechas.Controls.Add(Me.Label3)
        Me.gbRangoFechas.Controls.Add(Me.dtFechaInicio)
        Me.gbRangoFechas.Controls.Add(Me.Label2)
        Me.gbRangoFechas.Enabled = False
        Me.gbRangoFechas.Location = New System.Drawing.Point(56, 62)
        Me.gbRangoFechas.Name = "gbRangoFechas"
        Me.gbRangoFechas.Size = New System.Drawing.Size(173, 70)
        Me.gbRangoFechas.TabIndex = 53
        Me.gbRangoFechas.TabStop = False
        Me.gbRangoFechas.Text = "      Rango Fechas"
        '
        'chkFiltrar
        '
        Me.chkFiltrar.AutoSize = True
        Me.chkFiltrar.Location = New System.Drawing.Point(65, 63)
        Me.chkFiltrar.Name = "chkFiltrar"
        Me.chkFiltrar.Size = New System.Drawing.Size(15, 14)
        Me.chkFiltrar.TabIndex = 54
        Me.chkFiltrar.UseVisualStyleBackColor = True
        '
        'gbTipoReporte
        '
        Me.gbTipoReporte.Controls.Add(Me.chkMedicamentoProrrateo)
        Me.gbTipoReporte.Controls.Add(Me.chkProrrateoMedicamento)
        Me.gbTipoReporte.Controls.Add(Me.chkMedicamentoAplicacion)
        Me.gbTipoReporte.Controls.Add(Me.chkAplicacionMedicamento)
        Me.gbTipoReporte.Controls.Add(Me.chkTodos)
        Me.gbTipoReporte.Location = New System.Drawing.Point(235, 64)
        Me.gbTipoReporte.Name = "gbTipoReporte"
        Me.gbTipoReporte.Size = New System.Drawing.Size(352, 68)
        Me.gbTipoReporte.TabIndex = 58
        Me.gbTipoReporte.TabStop = False
        Me.gbTipoReporte.Text = "    Todos"
        '
        'chkMedicamentoProrrateo
        '
        Me.chkMedicamentoProrrateo.AutoSize = True
        Me.chkMedicamentoProrrateo.Checked = True
        Me.chkMedicamentoProrrateo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMedicamentoProrrateo.Location = New System.Drawing.Point(193, 42)
        Me.chkMedicamentoProrrateo.Name = "chkMedicamentoProrrateo"
        Me.chkMedicamentoProrrateo.Size = New System.Drawing.Size(155, 17)
        Me.chkMedicamentoProrrateo.TabIndex = 63
        Me.chkMedicamentoProrrateo.Text = "Medicamentos de prorrateo"
        Me.chkMedicamentoProrrateo.UseVisualStyleBackColor = True
        '
        'chkProrrateoMedicamento
        '
        Me.chkProrrateoMedicamento.AutoSize = True
        Me.chkProrrateoMedicamento.Checked = True
        Me.chkProrrateoMedicamento.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkProrrateoMedicamento.Location = New System.Drawing.Point(193, 19)
        Me.chkProrrateoMedicamento.Name = "chkProrrateoMedicamento"
        Me.chkProrrateoMedicamento.Size = New System.Drawing.Size(155, 17)
        Me.chkProrrateoMedicamento.TabIndex = 62
        Me.chkProrrateoMedicamento.Text = "Prorrateo de medicamentos"
        Me.chkProrrateoMedicamento.UseVisualStyleBackColor = True
        '
        'chkMedicamentoAplicacion
        '
        Me.chkMedicamentoAplicacion.AutoSize = True
        Me.chkMedicamentoAplicacion.Checked = True
        Me.chkMedicamentoAplicacion.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMedicamentoAplicacion.Location = New System.Drawing.Point(6, 42)
        Me.chkMedicamentoAplicacion.Name = "chkMedicamentoAplicacion"
        Me.chkMedicamentoAplicacion.Size = New System.Drawing.Size(172, 17)
        Me.chkMedicamentoAplicacion.TabIndex = 61
        Me.chkMedicamentoAplicacion.Text = "Medicamentos de aplicaciones"
        Me.chkMedicamentoAplicacion.UseVisualStyleBackColor = True
        '
        'chkAplicacionMedicamento
        '
        Me.chkAplicacionMedicamento.AutoSize = True
        Me.chkAplicacionMedicamento.Checked = True
        Me.chkAplicacionMedicamento.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAplicacionMedicamento.Location = New System.Drawing.Point(6, 19)
        Me.chkAplicacionMedicamento.Name = "chkAplicacionMedicamento"
        Me.chkAplicacionMedicamento.Size = New System.Drawing.Size(161, 17)
        Me.chkAplicacionMedicamento.TabIndex = 60
        Me.chkAplicacionMedicamento.Text = "Aplicación de medicamentos"
        Me.chkAplicacionMedicamento.UseVisualStyleBackColor = True
        '
        'chkTodos
        '
        Me.chkTodos.AutoSize = True
        Me.chkTodos.Checked = True
        Me.chkTodos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTodos.Location = New System.Drawing.Point(6, 0)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(15, 14)
        Me.chkTodos.TabIndex = 59
        Me.chkTodos.UseVisualStyleBackColor = True
        '
        'frmReportSalidaMedicamentoCorralesEngorda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 178)
        Me.Controls.Add(Me.gbTipoReporte)
        Me.Controls.Add(Me.cmbLote)
        Me.Controls.Add(Me.txtIdLote)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.chkFiltrar)
        Me.Controls.Add(Me.gbRangoFechas)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmReportSalidaMedicamentoCorralesEngorda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Salidas de Medicamento a Corrales de Engorda"
        Me.gbRangoFechas.ResumeLayout(False)
        Me.gbRangoFechas.PerformLayout()
        Me.gbTipoReporte.ResumeLayout(False)
        Me.gbTipoReporte.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbLote As Integralab.Controles.ComboBoxMejorado
    Friend WithEvents txtIdLote As Integralab.Controles.TextBoxMejorado
    Friend WithEvents dtFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbRangoFechas As System.Windows.Forms.GroupBox
    Friend WithEvents chkFiltrar As System.Windows.Forms.CheckBox
    Friend WithEvents gbTipoReporte As System.Windows.Forms.GroupBox
    Friend WithEvents chkMedicamentoProrrateo As System.Windows.Forms.CheckBox
    Friend WithEvents chkProrrateoMedicamento As System.Windows.Forms.CheckBox
    Friend WithEvents chkMedicamentoAplicacion As System.Windows.Forms.CheckBox
    Friend WithEvents chkAplicacionMedicamento As System.Windows.Forms.CheckBox
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
End Class
