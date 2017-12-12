<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmABCTipoGanado
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dgvTipoGanado = New System.Windows.Forms.DataGridView
        Me.IdTipoGanadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescCortaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LadosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoGanadoC = New ClasesNegocio.TipoGanadoColecttionClass
        Me.DtpFechaEntrada = New System.Windows.Forms.DateTimePicker
        Me.DtpFechaSalida = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtObservaciones = New System.Windows.Forms.TextBox
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtFiltro = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtAcumCab = New Integralab.Controles.TextBoxMejorado
        Me.txtAcumKilos = New Integralab.Controles.TextBoxMejorado
        Me.txtlados = New Integralab.Controles.TextBoxMejorado
        CType(Me.dgvTipoGanado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvTipoGanado
        '
        Me.dgvTipoGanado.AllowUserToAddRows = False
        Me.dgvTipoGanado.AllowUserToDeleteRows = False
        Me.dgvTipoGanado.AllowUserToResizeRows = False
        Me.dgvTipoGanado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTipoGanado.AutoGenerateColumns = False
        Me.dgvTipoGanado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTipoGanado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdTipoGanadoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.DescCortaDataGridViewTextBoxColumn, Me.LadosDataGridViewTextBoxColumn, Me.EstatusDataGridViewTextBoxColumn})
        Me.dgvTipoGanado.DataSource = Me.TipoGanadoC
        Me.dgvTipoGanado.Location = New System.Drawing.Point(6, 45)
        Me.dgvTipoGanado.MultiSelect = False
        Me.dgvTipoGanado.Name = "dgvTipoGanado"
        Me.dgvTipoGanado.ReadOnly = True
        Me.dgvTipoGanado.RowHeadersVisible = False
        Me.dgvTipoGanado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTipoGanado.Size = New System.Drawing.Size(687, 160)
        Me.dgvTipoGanado.TabIndex = 48
        '
        'IdTipoGanadoDataGridViewTextBoxColumn
        '
        Me.IdTipoGanadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.IdTipoGanadoDataGridViewTextBoxColumn.DataPropertyName = "IdTipoGanado"
        Me.IdTipoGanadoDataGridViewTextBoxColumn.HeaderText = "Id Tipo Ganado"
        Me.IdTipoGanadoDataGridViewTextBoxColumn.Name = "IdTipoGanadoDataGridViewTextBoxColumn"
        Me.IdTipoGanadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdTipoGanadoDataGridViewTextBoxColumn.Width = 95
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 86
        '
        'DescCortaDataGridViewTextBoxColumn
        '
        Me.DescCortaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DescCortaDataGridViewTextBoxColumn.DataPropertyName = "DescCorta"
        Me.DescCortaDataGridViewTextBoxColumn.HeaderText = "Descripción Corta"
        Me.DescCortaDataGridViewTextBoxColumn.Name = "DescCortaDataGridViewTextBoxColumn"
        Me.DescCortaDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescCortaDataGridViewTextBoxColumn.Width = 104
        '
        'LadosDataGridViewTextBoxColumn
        '
        Me.LadosDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.LadosDataGridViewTextBoxColumn.DataPropertyName = "Lados"
        Me.LadosDataGridViewTextBoxColumn.HeaderText = "Lados"
        Me.LadosDataGridViewTextBoxColumn.Name = "LadosDataGridViewTextBoxColumn"
        Me.LadosDataGridViewTextBoxColumn.ReadOnly = True
        Me.LadosDataGridViewTextBoxColumn.Width = 59
        '
        'EstatusDataGridViewTextBoxColumn
        '
        Me.EstatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.EstatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.HeaderText = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.Name = "EstatusDataGridViewTextBoxColumn"
        Me.EstatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstatusDataGridViewTextBoxColumn.Width = 65
        '
        'TipoGanadoC
        '
        Me.TipoGanadoC.AllowEdit = True
        Me.TipoGanadoC.AllowNew = True
        Me.TipoGanadoC.AllowRemove = True
        Me.TipoGanadoC.MaximoElementosSeleccionados = 1
        Me.TipoGanadoC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.TipoGanadoC.MostrarAlertas = False
        Me.TipoGanadoC.Name = ""
        Me.TipoGanadoC.RaiseListChangedEvents = True
        Me.TipoGanadoC.Transaction = Nothing
        '
        'DtpFechaEntrada
        '
        Me.DtpFechaEntrada.Enabled = False
        Me.DtpFechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaEntrada.Location = New System.Drawing.Point(353, 152)
        Me.DtpFechaEntrada.Name = "DtpFechaEntrada"
        Me.DtpFechaEntrada.Size = New System.Drawing.Size(92, 20)
        Me.DtpFechaEntrada.TabIndex = 50
        '
        'DtpFechaSalida
        '
        Me.DtpFechaSalida.Enabled = False
        Me.DtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaSalida.Location = New System.Drawing.Point(353, 124)
        Me.DtpFechaSalida.Name = "DtpFechaSalida"
        Me.DtpFechaSalida.Size = New System.Drawing.Size(92, 20)
        Me.DtpFechaSalida.TabIndex = 49
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(268, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Última Entrada:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(268, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Última Salida:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(57, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Acum. kilos:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Acum. Cabezas:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.AcceptsReturn = True
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Location = New System.Drawing.Point(160, 178)
        Me.txtObservaciones.MaxLength = 500
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(422, 65)
        Me.txtObservaciones.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(57, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Observaciones :"
        '
        'txtDescCorta
        '
        Me.txtDescCorta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescCorta.Location = New System.Drawing.Point(160, 99)
        Me.txtDescCorta.MaxLength = 6
        Me.txtDescCorta.Name = "txtDescCorta"
        Me.txtDescCorta.Size = New System.Drawing.Size(102, 20)
        Me.txtDescCorta.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Descripción Corta :"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AcceptsReturn = True
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(160, 73)
        Me.txtDescripcion.MaxLength = 60
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(422, 20)
        Me.txtDescripcion.TabIndex = 36
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(160, 47)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(58, 20)
        Me.txtCodigo.TabIndex = 30
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblEstatus
        '
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(585, 40)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(142, 24)
        Me.lblEstatus.TabIndex = 29
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEstatus.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripción :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo :"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(775, 29)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "CATÁLOGO TIPOS DE GANADO"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mtb
        '
        Me.mtb.ButtonSize = New System.Drawing.Size(50, 50)
        Me.mtb.Dock = System.Windows.Forms.DockStyle.None
        Me.mtb.DropDownArrows = True
        Me.mtb.HabilitarBorrar = True
        Me.mtb.HabilitarBuscar = False
        Me.mtb.HabilitarCancelar = True
        Me.mtb.HabilitarEditar = True
        Me.mtb.HabilitarGuardar = True
        Me.mtb.HabilitarImprimir = True
        Me.mtb.HabilitarLimpiar = True
        Me.mtb.HabilitarNuevo = True
        Me.mtb.HabilitarSalir = True
        Me.mtb.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32
        Me.mtb.Location = New System.Drawing.Point(3, 27)
        Me.mtb.MostrarBorrar = True
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = True
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 747)
        Me.mtb.TabIndex = 45
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.txtFiltro)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.dgvTipoGanado)
        Me.GroupBox2.Location = New System.Drawing.Point(56, 249)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(699, 211)
        Me.GroupBox2.TabIndex = 49
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista tipos de ganado"
        '
        'txtFiltro
        '
        Me.txtFiltro.AcceptsReturn = True
        Me.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFiltro.Location = New System.Drawing.Point(91, 19)
        Me.txtFiltro.MaxLength = 60
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(298, 20)
        Me.txtFiltro.TabIndex = 52
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 13)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Descripción :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(466, 155)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Lados:"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdTipoGanado"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DescCorta"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Desc Corta"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Observaciones"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Estatus"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Estatus"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "AcumuladoCabezas"
        Me.DataGridViewTextBoxColumn6.HeaderText = "AcumuladoCabezas"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "AcumuladoKilos"
        Me.DataGridViewTextBoxColumn7.HeaderText = "AcumuladoKilos"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'txtAcumCab
        '
        Me.txtAcumCab.ComboBoxEnlazado = Nothing
        Me.txtAcumCab.Decimales = 0
        Me.txtAcumCab.Enabled = False
        Me.txtAcumCab.Location = New System.Drawing.Point(160, 125)
        Me.txtAcumCab.MaxLength = 3000
        Me.txtAcumCab.MensajeCombo = "Seleccionar un item..."
        Me.txtAcumCab.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtAcumCab.Name = "txtAcumCab"
        Me.txtAcumCab.SiguienteControl = Me.txtAcumKilos
        Me.txtAcumCab.Size = New System.Drawing.Size(100, 20)
        Me.txtAcumCab.TabIndex = 52
        Me.txtAcumCab.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtAcumCab.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.[Decimal]
        Me.txtAcumCab.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtAcumCab.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtAcumKilos
        '
        Me.txtAcumKilos.ComboBoxEnlazado = Nothing
        Me.txtAcumKilos.Decimales = 0
        Me.txtAcumKilos.Enabled = False
        Me.txtAcumKilos.Location = New System.Drawing.Point(160, 152)
        Me.txtAcumKilos.MaxLength = 3000
        Me.txtAcumKilos.MensajeCombo = "Seleccionar un item..."
        Me.txtAcumKilos.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtAcumKilos.Name = "txtAcumKilos"
        Me.txtAcumKilos.SiguienteControl = Me.txtlados
        Me.txtAcumKilos.Size = New System.Drawing.Size(100, 20)
        Me.txtAcumKilos.TabIndex = 53
        Me.txtAcumKilos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtAcumKilos.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.[Decimal]
        Me.txtAcumKilos.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtAcumKilos.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtlados
        '
        Me.txtlados.ComboBoxEnlazado = Nothing
        Me.txtlados.Decimales = 0
        Me.txtlados.Location = New System.Drawing.Point(511, 152)
        Me.txtlados.MaxLength = 3000
        Me.txtlados.MensajeCombo = "Seleccionar un item..."
        Me.txtlados.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtlados.Name = "txtlados"
        Me.txtlados.SiguienteControl = Me.txtObservaciones
        Me.txtlados.Size = New System.Drawing.Size(71, 20)
        Me.txtlados.TabIndex = 54
        Me.txtlados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtlados.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.[Decimal]
        Me.txtlados.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtlados.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'FrmABCTipoGanado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 472)
        Me.Controls.Add(Me.txtlados)
        Me.Controls.Add(Me.txtAcumKilos)
        Me.Controls.Add(Me.txtAcumCab)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DtpFechaEntrada)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DtpFechaSalida)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblEstatus)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDescCorta)
        Me.MaximizeBox = False
        Me.Name = "FrmABCTipoGanado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipos de Ganado"
        CType(Me.dgvTipoGanado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvTipoGanado As System.Windows.Forms.DataGridView
    Friend WithEvents txtDescCorta As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents TipoGanadoC As ClasesNegocio.TipoGanadoColecttionClass
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DtpFechaEntrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpFechaSalida As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtAcumCab As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtAcumKilos As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtlados As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents IdTipoGanadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescCortaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LadosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
