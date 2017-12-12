<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteEmbarquesxDestinosyCliente
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
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label17 = New System.Windows.Forms.Label
        Me.ultdgvDetalle = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbCliente = New System.Windows.Forms.ComboBox
        Me.UltraGridExcelExporter1 = New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(Me.components)
        Me.chkRangoFechas = New System.Windows.Forms.CheckBox
        Me.grbFechas = New System.Windows.Forms.GroupBox
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.btnExportar = New System.Windows.Forms.Button
        CType(Me.ultdgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbFechas.SuspendLayout()
        Me.SuspendLayout()
        '
        'mtb
        '
        Me.mtb.ButtonSize = New System.Drawing.Size(50, 50)
        Me.mtb.Dock = System.Windows.Forms.DockStyle.None
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
        Me.mtb.Location = New System.Drawing.Point(3, -1)
        Me.mtb.MostrarBorrar = False
        Me.mtb.MostrarBuscar = True
        Me.mtb.MostrarCancelar = False
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = False
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 266)
        Me.mtb.TabIndex = 65
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(55, -1)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(835, 46)
        Me.Label17.TabIndex = 70
        Me.Label17.Text = "REPORTE DE EMBARQUES POR DESTINOS Y CLIENTE"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ultdgvDetalle
        '
        Appearance4.BackColor = System.Drawing.SystemColors.Window
        Appearance4.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ultdgvDetalle.DisplayLayout.Appearance = Appearance4
        Me.ultdgvDetalle.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ultdgvDetalle.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance1.BorderColor = System.Drawing.SystemColors.Window
        Me.ultdgvDetalle.DisplayLayout.GroupByBox.Appearance = Appearance1
        Appearance2.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ultdgvDetalle.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance2
        Me.ultdgvDetalle.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ultdgvDetalle.DisplayLayout.GroupByBox.Prompt = "Arrastre una columna aqui para agrupar"
        Appearance3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance3.BackColor2 = System.Drawing.SystemColors.Control
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ultdgvDetalle.DisplayLayout.GroupByBox.PromptAppearance = Appearance3
        Me.ultdgvDetalle.DisplayLayout.MaxColScrollRegions = 1
        Me.ultdgvDetalle.DisplayLayout.MaxRowScrollRegions = 1
        Appearance12.BackColor = System.Drawing.SystemColors.Window
        Appearance12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ultdgvDetalle.DisplayLayout.Override.ActiveCellAppearance = Appearance12
        Appearance7.BackColor = System.Drawing.SystemColors.Highlight
        Appearance7.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ultdgvDetalle.DisplayLayout.Override.ActiveRowAppearance = Appearance7
        Me.ultdgvDetalle.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ultdgvDetalle.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance6.BackColor = System.Drawing.SystemColors.Window
        Me.ultdgvDetalle.DisplayLayout.Override.CardAreaAppearance = Appearance6
        Appearance5.BorderColor = System.Drawing.Color.Silver
        Appearance5.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ultdgvDetalle.DisplayLayout.Override.CellAppearance = Appearance5
        Me.ultdgvDetalle.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ultdgvDetalle.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.ultdgvDetalle.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance11.TextHAlignAsString = "Left"
        Me.ultdgvDetalle.DisplayLayout.Override.HeaderAppearance = Appearance11
        Me.ultdgvDetalle.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ultdgvDetalle.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance10.BackColor = System.Drawing.SystemColors.Window
        Appearance10.BorderColor = System.Drawing.Color.Silver
        Me.ultdgvDetalle.DisplayLayout.Override.RowAppearance = Appearance10
        Me.ultdgvDetalle.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ultdgvDetalle.DisplayLayout.Override.TemplateAddRowAppearance = Appearance8
        Me.ultdgvDetalle.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ultdgvDetalle.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ultdgvDetalle.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ultdgvDetalle.Location = New System.Drawing.Point(59, 110)
        Me.ultdgvDetalle.Name = "ultdgvDetalle"
        Me.ultdgvDetalle.Size = New System.Drawing.Size(819, 304)
        Me.ultdgvDetalle.TabIndex = 71
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Cliente:"
        '
        'cmbCliente
        '
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(113, 54)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(383, 21)
        Me.cmbCliente.TabIndex = 73
        '
        'chkRangoFechas
        '
        Me.chkRangoFechas.AutoSize = True
        Me.chkRangoFechas.Checked = True
        Me.chkRangoFechas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRangoFechas.Location = New System.Drawing.Point(6, 0)
        Me.chkRangoFechas.Name = "chkRangoFechas"
        Me.chkRangoFechas.Size = New System.Drawing.Size(111, 17)
        Me.chkRangoFechas.TabIndex = 74
        Me.chkRangoFechas.Text = "Rango de Fechas"
        Me.chkRangoFechas.UseVisualStyleBackColor = True
        '
        'grbFechas
        '
        Me.grbFechas.Controls.Add(Me.dtpFechaFinal)
        Me.grbFechas.Controls.Add(Me.Label3)
        Me.grbFechas.Controls.Add(Me.Label2)
        Me.grbFechas.Controls.Add(Me.dtpFechaInicial)
        Me.grbFechas.Controls.Add(Me.chkRangoFechas)
        Me.grbFechas.Location = New System.Drawing.Point(502, 48)
        Me.grbFechas.Name = "grbFechas"
        Me.grbFechas.Size = New System.Drawing.Size(376, 56)
        Me.grbFechas.TabIndex = 75
        Me.grbFechas.TabStop = False
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaFinal.Location = New System.Drawing.Point(265, 22)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaFinal.TabIndex = 78
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(194, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Fecha Final:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Fecha Inicial:"
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaInicial.Location = New System.Drawing.Point(88, 22)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaInicial.TabIndex = 75
        '
        'btnExportar
        '
        Me.btnExportar.Location = New System.Drawing.Point(383, 81)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(113, 23)
        Me.btnExportar.TabIndex = 76
        Me.btnExportar.Text = "Exportar a Excel"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'FrmReporteEmbarquesxDestinosyCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 424)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.grbFechas)
        Me.Controls.Add(Me.cmbCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ultdgvDetalle)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmReporteEmbarquesxDestinosyCliente"
        Me.Text = "REPORTE DE EMBARQUES POR DESTINOS Y CLIENTE"
        CType(Me.ultdgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbFechas.ResumeLayout(False)
        Me.grbFechas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ultdgvDetalle As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbCliente As System.Windows.Forms.ComboBox
    Friend WithEvents UltraGridExcelExporter1 As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
    Friend WithEvents chkRangoFechas As System.Windows.Forms.CheckBox
    Friend WithEvents grbFechas As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnExportar As System.Windows.Forms.Button
End Class
