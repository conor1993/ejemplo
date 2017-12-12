<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmABCLotes
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.tbc = New System.Windows.Forms.TabControl
        Me.tbp1 = New System.Windows.Forms.TabPage
        Me.txtPesoProyectado = New Integralab.Controles.TextBoxMejorado
        Me.txtGDP = New Integralab.Controles.TextBoxMejorado
        Me.txtTotalKilosGanancia = New System.Windows.Forms.TextBox
        Me.txtTotalKilosSalida = New System.Windows.Forms.TextBox
        Me.txtTotalKilosEntrada = New System.Windows.Forms.TextBox
        Me.txtTotalCabezas = New System.Windows.Forms.TextBox
        Me.txtDiasLote = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.dgDetallesTipoGanado = New System.Windows.Forms.DataGridView
        Me.TipoGanado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cabezas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KilosEntrada = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KilosSalida = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ganancia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtPesoActualxCabeza = New System.Windows.Forms.TextBox
        Me.txtPesoActualTotal = New System.Windows.Forms.TextBox
        Me.txtDiasEngorda = New System.Windows.Forms.TextBox
        Me.dtpFechaSal = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.nudSemanasReimplante = New System.Windows.Forms.NumericUpDown
        Me.txtObserbacionesDesparasitacion = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.dtpFechaReimplante = New System.Windows.Forms.DateTimePicker
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.dgCabezas = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtObservaciones = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.cmbCorral = New System.Windows.Forms.ComboBox
        Me.CorralesC = New ClasesNegocio.CorralColecttionClass
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDescCorta = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.btnFormulas = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.tbc.SuspendLayout()
        Me.tbp1.SuspendLayout()
        CType(Me.dgDetallesTipoGanado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.nudSemanasReimplante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgCabezas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbc)
        Me.GroupBox1.Location = New System.Drawing.Point(54, 193)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(563, 350)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        '
        'tbc
        '
        Me.tbc.Controls.Add(Me.tbp1)
        Me.tbc.Controls.Add(Me.TabPage2)
        Me.tbc.Controls.Add(Me.TabPage3)
        Me.tbc.Location = New System.Drawing.Point(9, 19)
        Me.tbc.Name = "tbc"
        Me.tbc.SelectedIndex = 0
        Me.tbc.Size = New System.Drawing.Size(547, 325)
        Me.tbc.TabIndex = 0
        '
        'tbp1
        '
        Me.tbp1.Controls.Add(Me.txtPesoProyectado)
        Me.tbp1.Controls.Add(Me.txtGDP)
        Me.tbp1.Controls.Add(Me.txtTotalKilosGanancia)
        Me.tbp1.Controls.Add(Me.txtTotalKilosSalida)
        Me.tbp1.Controls.Add(Me.txtTotalKilosEntrada)
        Me.tbp1.Controls.Add(Me.txtTotalCabezas)
        Me.tbp1.Controls.Add(Me.txtDiasLote)
        Me.tbp1.Controls.Add(Me.Label11)
        Me.tbp1.Controls.Add(Me.Label8)
        Me.tbp1.Controls.Add(Me.Label6)
        Me.tbp1.Controls.Add(Me.dgDetallesTipoGanado)
        Me.tbp1.Controls.Add(Me.txtPesoActualxCabeza)
        Me.tbp1.Controls.Add(Me.txtPesoActualTotal)
        Me.tbp1.Controls.Add(Me.txtDiasEngorda)
        Me.tbp1.Controls.Add(Me.dtpFechaSal)
        Me.tbp1.Controls.Add(Me.dtpFechaInicio)
        Me.tbp1.Controls.Add(Me.Label14)
        Me.tbp1.Controls.Add(Me.Label13)
        Me.tbp1.Controls.Add(Me.Label12)
        Me.tbp1.Controls.Add(Me.Label10)
        Me.tbp1.Controls.Add(Me.Label9)
        Me.tbp1.Location = New System.Drawing.Point(4, 22)
        Me.tbp1.Name = "tbp1"
        Me.tbp1.Padding = New System.Windows.Forms.Padding(3)
        Me.tbp1.Size = New System.Drawing.Size(539, 299)
        Me.tbp1.TabIndex = 0
        Me.tbp1.Text = "Propiedades de Lote"
        Me.tbp1.UseVisualStyleBackColor = True
        '
        'txtPesoProyectado
        '
        Me.txtPesoProyectado.ComboBoxEnlazado = Nothing
        Me.txtPesoProyectado.Decimales = 3
        Me.txtPesoProyectado.Location = New System.Drawing.Point(352, 87)
        Me.txtPesoProyectado.MaxLength = 3000
        Me.txtPesoProyectado.MensajeCombo = "Seleccionar un item..."
        Me.txtPesoProyectado.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtPesoProyectado.Name = "txtPesoProyectado"
        Me.txtPesoProyectado.SiguienteControl = Nothing
        Me.txtPesoProyectado.Size = New System.Drawing.Size(92, 20)
        Me.txtPesoProyectado.TabIndex = 1
        Me.txtPesoProyectado.Text = "0.000"
        Me.txtPesoProyectado.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.[Decimal]
        Me.txtPesoProyectado.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtPesoProyectado.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtGDP
        '
        Me.txtGDP.ComboBoxEnlazado = Nothing
        Me.txtGDP.Decimales = 3
        Me.txtGDP.Location = New System.Drawing.Point(127, 61)
        Me.txtGDP.MaxLength = 3000
        Me.txtGDP.MensajeCombo = "Seleccionar un item..."
        Me.txtGDP.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtGDP.Name = "txtGDP"
        Me.txtGDP.SiguienteControl = Nothing
        Me.txtGDP.Size = New System.Drawing.Size(92, 20)
        Me.txtGDP.TabIndex = 0
        Me.txtGDP.Text = "0.000"
        Me.txtGDP.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.[Decimal]
        Me.txtGDP.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtGDP.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtTotalKilosGanancia
        '
        Me.txtTotalKilosGanancia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalKilosGanancia.Enabled = False
        Me.txtTotalKilosGanancia.Location = New System.Drawing.Point(413, 264)
        Me.txtTotalKilosGanancia.Name = "txtTotalKilosGanancia"
        Me.txtTotalKilosGanancia.Size = New System.Drawing.Size(92, 20)
        Me.txtTotalKilosGanancia.TabIndex = 73
        Me.txtTotalKilosGanancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalKilosSalida
        '
        Me.txtTotalKilosSalida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalKilosSalida.Enabled = False
        Me.txtTotalKilosSalida.Location = New System.Drawing.Point(315, 264)
        Me.txtTotalKilosSalida.Name = "txtTotalKilosSalida"
        Me.txtTotalKilosSalida.Size = New System.Drawing.Size(92, 20)
        Me.txtTotalKilosSalida.TabIndex = 72
        Me.txtTotalKilosSalida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalKilosEntrada
        '
        Me.txtTotalKilosEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalKilosEntrada.Enabled = False
        Me.txtTotalKilosEntrada.Location = New System.Drawing.Point(217, 264)
        Me.txtTotalKilosEntrada.Name = "txtTotalKilosEntrada"
        Me.txtTotalKilosEntrada.Size = New System.Drawing.Size(92, 20)
        Me.txtTotalKilosEntrada.TabIndex = 71
        Me.txtTotalKilosEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalCabezas
        '
        Me.txtTotalCabezas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalCabezas.Enabled = False
        Me.txtTotalCabezas.Location = New System.Drawing.Point(132, 264)
        Me.txtTotalCabezas.Name = "txtTotalCabezas"
        Me.txtTotalCabezas.Size = New System.Drawing.Size(79, 20)
        Me.txtTotalCabezas.TabIndex = 70
        Me.txtTotalCabezas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiasLote
        '
        Me.txtDiasLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDiasLote.Enabled = False
        Me.txtDiasLote.Location = New System.Drawing.Point(127, 35)
        Me.txtDiasLote.Name = "txtDiasLote"
        Me.txtDiasLote.ReadOnly = True
        Me.txtDiasLote.Size = New System.Drawing.Size(92, 20)
        Me.txtDiasLote.TabIndex = 69
        Me.txtDiasLote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 39)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 13)
        Me.Label11.TabIndex = 68
        Me.Label11.Text = "Días Lote :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "G.D.P. :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(231, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 13)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Peso proyectado/cbz:"
        '
        'dgDetallesTipoGanado
        '
        Me.dgDetallesTipoGanado.AllowUserToAddRows = False
        Me.dgDetallesTipoGanado.AllowUserToDeleteRows = False
        Me.dgDetallesTipoGanado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDetallesTipoGanado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TipoGanado, Me.Cabezas, Me.KilosEntrada, Me.KilosSalida, Me.Ganancia})
        Me.dgDetallesTipoGanado.Location = New System.Drawing.Point(9, 113)
        Me.dgDetallesTipoGanado.Name = "dgDetallesTipoGanado"
        Me.dgDetallesTipoGanado.ReadOnly = True
        Me.dgDetallesTipoGanado.RowHeadersVisible = False
        Me.dgDetallesTipoGanado.Size = New System.Drawing.Size(521, 145)
        Me.dgDetallesTipoGanado.TabIndex = 63
        '
        'TipoGanado
        '
        Me.TipoGanado.DataPropertyName = "DescripcionTipoGanado"
        Me.TipoGanado.HeaderText = "Tipo de Ganado"
        Me.TipoGanado.Name = "TipoGanado"
        Me.TipoGanado.ReadOnly = True
        Me.TipoGanado.Width = 120
        '
        'Cabezas
        '
        Me.Cabezas.DataPropertyName = "Cabezas"
        Me.Cabezas.HeaderText = "Cabezas"
        Me.Cabezas.Name = "Cabezas"
        Me.Cabezas.ReadOnly = True
        Me.Cabezas.Width = 80
        '
        'KilosEntrada
        '
        Me.KilosEntrada.DataPropertyName = "KilosEntrada"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "N2"
        Me.KilosEntrada.DefaultCellStyle = DataGridViewCellStyle13
        Me.KilosEntrada.HeaderText = "Kilos Entrada"
        Me.KilosEntrada.Name = "KilosEntrada"
        Me.KilosEntrada.ReadOnly = True
        '
        'KilosSalida
        '
        Me.KilosSalida.DataPropertyName = "KilosSalida"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "N2"
        Me.KilosSalida.DefaultCellStyle = DataGridViewCellStyle14
        Me.KilosSalida.HeaderText = "Kilos Salida"
        Me.KilosSalida.Name = "KilosSalida"
        Me.KilosSalida.ReadOnly = True
        '
        'Ganancia
        '
        Me.Ganancia.DataPropertyName = "GananciaKilos"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Format = "N2"
        Me.Ganancia.DefaultCellStyle = DataGridViewCellStyle15
        Me.Ganancia.HeaderText = "Ganancia Kilos"
        Me.Ganancia.Name = "Ganancia"
        Me.Ganancia.ReadOnly = True
        '
        'txtPesoActualxCabeza
        '
        Me.txtPesoActualxCabeza.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPesoActualxCabeza.Enabled = False
        Me.txtPesoActualxCabeza.Location = New System.Drawing.Point(352, 61)
        Me.txtPesoActualxCabeza.Name = "txtPesoActualxCabeza"
        Me.txtPesoActualxCabeza.ReadOnly = True
        Me.txtPesoActualxCabeza.Size = New System.Drawing.Size(92, 20)
        Me.txtPesoActualxCabeza.TabIndex = 62
        Me.txtPesoActualxCabeza.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPesoActualTotal
        '
        Me.txtPesoActualTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPesoActualTotal.Enabled = False
        Me.txtPesoActualTotal.Location = New System.Drawing.Point(352, 35)
        Me.txtPesoActualTotal.Name = "txtPesoActualTotal"
        Me.txtPesoActualTotal.ReadOnly = True
        Me.txtPesoActualTotal.Size = New System.Drawing.Size(92, 20)
        Me.txtPesoActualTotal.TabIndex = 61
        Me.txtPesoActualTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiasEngorda
        '
        Me.txtDiasEngorda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDiasEngorda.Location = New System.Drawing.Point(127, 87)
        Me.txtDiasEngorda.Name = "txtDiasEngorda"
        Me.txtDiasEngorda.ReadOnly = True
        Me.txtDiasEngorda.Size = New System.Drawing.Size(92, 20)
        Me.txtDiasEngorda.TabIndex = 60
        Me.txtDiasEngorda.TabStop = False
        Me.txtDiasEngorda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpFechaSal
        '
        Me.dtpFechaSal.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFechaSal.Enabled = False
        Me.dtpFechaSal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaSal.Location = New System.Drawing.Point(352, 9)
        Me.dtpFechaSal.Name = "dtpFechaSal"
        Me.dtpFechaSal.Size = New System.Drawing.Size(92, 20)
        Me.dtpFechaSal.TabIndex = 58
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFechaInicio.Enabled = False
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaInicio.Location = New System.Drawing.Point(127, 9)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(92, 20)
        Me.dtpFechaInicio.TabIndex = 57
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(231, 65)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(115, 13)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "Peso actual x cabeza :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 90)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 13)
        Me.Label13.TabIndex = 55
        Me.Label13.Text = "Dias de Engorda :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(231, 39)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 13)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "Peso total actual :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(231, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 13)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Fecha Sal. Estimada :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 13)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Fecha de Inicio :"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.nudSemanasReimplante)
        Me.TabPage2.Controls.Add(Me.txtObserbacionesDesparasitacion)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.dtpFechaReimplante)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(539, 299)
        Me.TabPage2.TabIndex = 2
        Me.TabPage2.Text = "Desparasitación y Reimplante"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'nudSemanasReimplante
        '
        Me.nudSemanasReimplante.Location = New System.Drawing.Point(139, 12)
        Me.nudSemanasReimplante.Name = "nudSemanasReimplante"
        Me.nudSemanasReimplante.Size = New System.Drawing.Size(97, 20)
        Me.nudSemanasReimplante.TabIndex = 0
        '
        'txtObserbacionesDesparasitacion
        '
        Me.txtObserbacionesDesparasitacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObserbacionesDesparasitacion.Location = New System.Drawing.Point(139, 64)
        Me.txtObserbacionesDesparasitacion.Multiline = True
        Me.txtObserbacionesDesparasitacion.Name = "txtObserbacionesDesparasitacion"
        Me.txtObserbacionesDesparasitacion.Size = New System.Drawing.Size(372, 52)
        Me.txtObserbacionesDesparasitacion.TabIndex = 2
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(10, 67)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(84, 13)
        Me.Label18.TabIndex = 86
        Me.Label18.Text = "Observaciones :"
        '
        'dtpFechaReimplante
        '
        Me.dtpFechaReimplante.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFechaReimplante.Enabled = False
        Me.dtpFechaReimplante.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaReimplante.Location = New System.Drawing.Point(139, 38)
        Me.dtpFechaReimplante.Name = "dtpFechaReimplante"
        Me.dtpFechaReimplante.Size = New System.Drawing.Size(97, 20)
        Me.dtpFechaReimplante.TabIndex = 1
        Me.dtpFechaReimplante.Value = New Date(2007, 7, 31, 0, 0, 0, 0)
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(9, 42)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(99, 13)
        Me.Label17.TabIndex = 41
        Me.Label17.Text = "Fecha Reimplante :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(10, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(122, 13)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "Semanas a Reimplante :"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgCabezas)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(539, 299)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "Cabezas"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgCabezas
        '
        Me.dgCabezas.AllowUserToAddRows = False
        Me.dgCabezas.AllowUserToDeleteRows = False
        Me.dgCabezas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCabezas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.dgCabezas.Location = New System.Drawing.Point(6, 6)
        Me.dgCabezas.Name = "dgCabezas"
        Me.dgCabezas.ReadOnly = True
        Me.dgCabezas.RowHeadersVisible = False
        Me.dgCabezas.Size = New System.Drawing.Size(524, 287)
        Me.dgCabezas.TabIndex = 64
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "AretePropio"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Arete"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 83
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "TipoGanado"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Tipo de Ganado"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 120
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "KilosEntrada"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.Format = "N2"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewTextBoxColumn3.HeaderText = "Kilos Entrada"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "KilosSalida"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle17.Format = "N2"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridViewTextBoxColumn4.HeaderText = "Kilos Salida"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "GananciaKilos"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle18.Format = "N2"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridViewTextBoxColumn5.HeaderText = "Ganancia Kilos"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Location = New System.Drawing.Point(141, 142)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(344, 47)
        Me.txtObservaciones.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(52, 144)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 13)
        Me.Label15.TabIndex = 55
        Me.Label15.Text = "Observaciones :"
        '
        'cmbCorral
        '
        Me.cmbCorral.DataSource = Me.CorralesC
        Me.cmbCorral.DisplayMember = "Descripcion"
        Me.cmbCorral.FormattingEnabled = True
        Me.cmbCorral.Location = New System.Drawing.Point(141, 115)
        Me.cmbCorral.Name = "cmbCorral"
        Me.cmbCorral.Size = New System.Drawing.Size(344, 21)
        Me.cmbCorral.TabIndex = 2
        Me.cmbCorral.ValueMember = "IdCorral"
        '
        'CorralesC
        '
        Me.CorralesC.AllowEdit = True
        Me.CorralesC.AllowNew = True
        Me.CorralesC.AllowRemove = True
        Me.CorralesC.MaximoElementosSeleccionados = 1
        Me.CorralesC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.CorralesC.MostrarAlertas = False
        Me.CorralesC.Name = Nothing
        Me.CorralesC.RaiseListChangedEvents = True
        Me.CorralesC.Transaction = Nothing
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Corral :"
        '
        'txtDescCorta
        '
        Me.txtDescCorta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescCorta.Location = New System.Drawing.Point(141, 89)
        Me.txtDescCorta.Name = "txtDescCorta"
        Me.txtDescCorta.Size = New System.Drawing.Size(102, 20)
        Me.txtDescCorta.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Des. Corta :"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AcceptsReturn = True
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(141, 63)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(278, 20)
        Me.txtDescripcion.TabIndex = 0
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(141, 35)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(56, 20)
        Me.txtCodigo.TabIndex = 30
        Me.txtCodigo.TabStop = False
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblEstatus
        '
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(449, 35)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(168, 24)
        Me.lblEstatus.TabIndex = 29
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEstatus.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripción :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lote:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(625, 32)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "CATÁLOGO DE LOTES"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.mtb.Location = New System.Drawing.Point(2, 31)
        Me.mtb.MostrarBorrar = False
        Me.mtb.MostrarBuscar = True
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = True
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 630)
        Me.mtb.TabIndex = 49
        '
        'btnFormulas
        '
        Me.btnFormulas.Location = New System.Drawing.Point(497, 149)
        Me.btnFormulas.Name = "btnFormulas"
        Me.btnFormulas.Size = New System.Drawing.Size(109, 40)
        Me.btnFormulas.TabIndex = 4
        Me.btnFormulas.Text = "Formulas"
        Me.btnFormulas.UseVisualStyleBackColor = True
        '
        'FrmABCLotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 555)
        Me.Controls.Add(Me.btnFormulas)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.cmbCorral)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDescCorta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblEstatus)
        Me.Controls.Add(Me.txtDescripcion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmABCLotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lotes"
        Me.GroupBox1.ResumeLayout(False)
        Me.tbc.ResumeLayout(False)
        Me.tbp1.ResumeLayout(False)
        Me.tbp1.PerformLayout()
        CType(Me.dgDetallesTipoGanado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.nudSemanasReimplante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgCabezas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbc As System.Windows.Forms.TabControl
    Friend WithEvents tbp1 As System.Windows.Forms.TabPage
    Friend WithEvents cmbCorral As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDescCorta As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaSal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPesoActualxCabeza As System.Windows.Forms.TextBox
    Friend WithEvents txtPesoActualTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtDiasEngorda As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgDetallesTipoGanado As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtDiasLote As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalKilosSalida As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalKilosEntrada As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalCabezas As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtObserbacionesDesparasitacion As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaReimplante As System.Windows.Forms.DateTimePicker
    Friend WithEvents CorralesC As ClasesNegocio.CorralColecttionClass
    Friend WithEvents txtTotalKilosGanancia As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents dgCabezas As System.Windows.Forms.DataGridView
    Friend WithEvents txtGDP As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtPesoProyectado As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents TipoGanado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cabezas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosEntrada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosSalida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ganancia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nudSemanasReimplante As System.Windows.Forms.NumericUpDown
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnFormulas As System.Windows.Forms.Button
End Class
