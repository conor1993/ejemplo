<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteAplicacionMedicamentosPorLote
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
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.dtFechaFin = New System.Windows.Forms.DateTimePicker
        Me.gbRangoFechas = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.chkFiltrar = New System.Windows.Forms.CheckBox
        Me.cmbLote = New Integralab.Controles.ComboBoxMejorado
        Me.txtIdLote = New Integralab.Controles.TextBoxMejorado
        Me.Label8 = New System.Windows.Forms.Label
        Me.gbRangoFechas.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Label17.Size = New System.Drawing.Size(644, 29)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "REPORTE APLICACIÓN DE MEDICAMENTO POR LOTE"
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
        Me.mtb.Size = New System.Drawing.Size(50, 174)
        Me.mtb.TabIndex = 20
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
        Me.gbRangoFechas.Location = New System.Drawing.Point(56, 78)
        Me.gbRangoFechas.Name = "gbRangoFechas"
        Me.gbRangoFechas.Size = New System.Drawing.Size(173, 70)
        Me.gbRangoFechas.TabIndex = 41
        Me.gbRangoFechas.TabStop = False
        Me.gbRangoFechas.Text = "Rango Fechas"
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
        'chkFiltrar
        '
        Me.chkFiltrar.AutoSize = True
        Me.chkFiltrar.Location = New System.Drawing.Point(56, 58)
        Me.chkFiltrar.Name = "chkFiltrar"
        Me.chkFiltrar.Size = New System.Drawing.Size(89, 17)
        Me.chkFiltrar.TabIndex = 42
        Me.chkFiltrar.Text = "Filtrar Fechas"
        Me.chkFiltrar.UseVisualStyleBackColor = True
        '
        'cmbLote
        '
        Me.cmbLote.FormattingEnabled = True
        Me.cmbLote.Location = New System.Drawing.Point(167, 32)
        Me.cmbLote.Name = "cmbLote"
        Me.cmbLote.NombreMetodo = Nothing
        Me.cmbLote.Parametros = Nothing
        Me.cmbLote.SiguienteControl = Nothing
        Me.cmbLote.Size = New System.Drawing.Size(346, 21)
        Me.cmbLote.TabIndex = 45
        Me.cmbLote.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbLote.TextBoxEnlazado = Me.txtIdLote
        '
        'txtIdLote
        '
        Me.txtIdLote.ComboBoxEnlazado = Me.cmbLote
        Me.txtIdLote.Decimales = 0
        Me.txtIdLote.Location = New System.Drawing.Point(108, 32)
        Me.txtIdLote.MaxLength = 3000
        Me.txtIdLote.MensajeCombo = "Seleccionar un lote..."
        Me.txtIdLote.MensajeNoExiste = "No existe un Lote con este código o se encuentra inactivo"
        Me.txtIdLote.Name = "txtIdLote"
        Me.txtIdLote.SiguienteControl = Nothing
        Me.txtIdLote.Size = New System.Drawing.Size(53, 20)
        Me.txtIdLote.TabIndex = 44
        Me.txtIdLote.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtIdLote.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtIdLote.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(51, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Lote:"
        '
        'frmReporteAplicacionMedicamentosPorLote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 174)
        Me.Controls.Add(Me.cmbLote)
        Me.Controls.Add(Me.txtIdLote)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.gbRangoFechas)
        Me.Controls.Add(Me.chkFiltrar)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmReporteAplicacionMedicamentosPorLote"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Aplicación De Medicamento Por Lote"
        Me.gbRangoFechas.ResumeLayout(False)
        Me.gbRangoFechas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents dtFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbRangoFechas As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkFiltrar As System.Windows.Forms.CheckBox
    Friend WithEvents cmbLote As Integralab.Controles.ComboBoxMejorado
    Friend WithEvents txtIdLote As Integralab.Controles.TextBoxMejorado
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
