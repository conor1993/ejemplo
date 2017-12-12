<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalidasRecibaCorral
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtFolio = New System.Windows.Forms.TextBox
        Me.cmbCorral = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.dgvDetalle = New System.Windows.Forms.DataGridView
        Me.txtTotalKilos = New System.Windows.Forms.TextBox
        Me.txtTotalImporte = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbLoteDestino = New System.Windows.Forms.ComboBox
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.dgvTiposGanadoReciba = New System.Windows.Forms.DataGridView
        Me.clmTipoGanadoDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmTipoGanadoCabezas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmTipoGanadoKilos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grbGanado = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgvTiposGanadoLote = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmAreteTransporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmAreteSiniiga = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmArete = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIdTipoGanado = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.clmCabezas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmKilos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCostoxKilo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmImporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTiposGanadoReciba, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbGanado.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvTiposGanadoLote, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MEAToolBar1.MostrarBorrar = True
        Me.MEAToolBar1.MostrarBuscar = True
        Me.MEAToolBar1.MostrarCancelar = True
        Me.MEAToolBar1.MostrarEditar = False
        Me.MEAToolBar1.MostrarGuardar = True
        Me.MEAToolBar1.MostrarImprimir = True
        Me.MEAToolBar1.MostrarLimpiar = True
        Me.MEAToolBar1.MostrarNuevo = True
        Me.MEAToolBar1.MostrarSalir = True
        Me.MEAToolBar1.Name = "MEAToolBar1"
        Me.MEAToolBar1.ShowToolTips = True
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 563)
        Me.MEAToolBar1.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(50, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(669, 29)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "TRANSFERENCIA DE RECIBA A CORRAL"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Folio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Corral Recepcion:"
        '
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(94, 41)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.ReadOnly = True
        Me.txtFolio.Size = New System.Drawing.Size(100, 20)
        Me.txtFolio.TabIndex = 30
        '
        'cmbCorral
        '
        Me.cmbCorral.FormattingEnabled = True
        Me.cmbCorral.Location = New System.Drawing.Point(154, 67)
        Me.cmbCorral.Name = "cmbCorral"
        Me.cmbCorral.Size = New System.Drawing.Size(196, 21)
        Me.cmbCorral.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(219, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(265, 41)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(85, 20)
        Me.dtpFecha.TabIndex = 34
        '
        'dgvDetalle
        '
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmAreteTransporte, Me.clmAreteSiniiga, Me.clmArete, Me.clmIdTipoGanado, Me.clmCabezas, Me.clmKilos, Me.clmCostoxKilo, Me.clmImporte})
        Me.dgvDetalle.Location = New System.Drawing.Point(59, 209)
        Me.dgvDetalle.MultiSelect = False
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.RowHeadersVisible = False
        Me.dgvDetalle.Size = New System.Drawing.Size(645, 312)
        Me.dgvDetalle.TabIndex = 36
        '
        'txtTotalKilos
        '
        Me.txtTotalKilos.Location = New System.Drawing.Point(479, 527)
        Me.txtTotalKilos.Name = "txtTotalKilos"
        Me.txtTotalKilos.ReadOnly = True
        Me.txtTotalKilos.Size = New System.Drawing.Size(70, 20)
        Me.txtTotalKilos.TabIndex = 38
        Me.txtTotalKilos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalImporte
        '
        Me.txtTotalImporte.Location = New System.Drawing.Point(604, 527)
        Me.txtTotalImporte.Name = "txtTotalImporte"
        Me.txtTotalImporte.ReadOnly = True
        Me.txtTotalImporte.Size = New System.Drawing.Size(80, 20)
        Me.txtTotalImporte.TabIndex = 39
        Me.txtTotalImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(397, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Lote Destino:"
        '
        'cmbLoteDestino
        '
        Me.cmbLoteDestino.FormattingEnabled = True
        Me.cmbLoteDestino.Location = New System.Drawing.Point(473, 67)
        Me.cmbLoteDestino.Name = "cmbLoteDestino"
        Me.cmbLoteDestino.Size = New System.Drawing.Size(196, 21)
        Me.cmbLoteDestino.TabIndex = 41
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Cabezas"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cabezas"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 70
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Kilos"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Kilos"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 70
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CostoxKilo"
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn3.HeaderText = "CostoxKilo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 70
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Importe"
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn4.HeaderText = "Importe"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CabezasExistentes"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cabezas Existentes"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 55
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "KilosExistentes"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "C2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn6.HeaderText = "Kilos Existentes"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 60
        '
        'lblEstatus
        '
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(554, 32)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(115, 21)
        Me.lblEstatus.TabIndex = 61
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvTiposGanadoReciba
        '
        Me.dgvTiposGanadoReciba.AllowUserToAddRows = False
        Me.dgvTiposGanadoReciba.AllowUserToDeleteRows = False
        Me.dgvTiposGanadoReciba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTiposGanadoReciba.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmTipoGanadoDescripcion, Me.clmTipoGanadoCabezas, Me.clmTipoGanadoKilos})
        Me.dgvTiposGanadoReciba.Location = New System.Drawing.Point(6, 16)
        Me.dgvTiposGanadoReciba.Name = "dgvTiposGanadoReciba"
        Me.dgvTiposGanadoReciba.ReadOnly = True
        Me.dgvTiposGanadoReciba.RowHeadersVisible = False
        Me.dgvTiposGanadoReciba.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTiposGanadoReciba.Size = New System.Drawing.Size(301, 87)
        Me.dgvTiposGanadoReciba.TabIndex = 62
        '
        'clmTipoGanadoDescripcion
        '
        Me.clmTipoGanadoDescripcion.DataPropertyName = "TipoGanado"
        Me.clmTipoGanadoDescripcion.HeaderText = "Tipo de Ganado"
        Me.clmTipoGanadoDescripcion.Name = "clmTipoGanadoDescripcion"
        Me.clmTipoGanadoDescripcion.ReadOnly = True
        Me.clmTipoGanadoDescripcion.Width = 120
        '
        'clmTipoGanadoCabezas
        '
        Me.clmTipoGanadoCabezas.DataPropertyName = "ExistCabezas"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        Me.clmTipoGanadoCabezas.DefaultCellStyle = DataGridViewCellStyle9
        Me.clmTipoGanadoCabezas.HeaderText = "Cabezas"
        Me.clmTipoGanadoCabezas.Name = "clmTipoGanadoCabezas"
        Me.clmTipoGanadoCabezas.ReadOnly = True
        Me.clmTipoGanadoCabezas.Width = 70
        '
        'clmTipoGanadoKilos
        '
        Me.clmTipoGanadoKilos.DataPropertyName = "ExistKilos"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        Me.clmTipoGanadoKilos.DefaultCellStyle = DataGridViewCellStyle10
        Me.clmTipoGanadoKilos.HeaderText = "Kilos"
        Me.clmTipoGanadoKilos.Name = "clmTipoGanadoKilos"
        Me.clmTipoGanadoKilos.ReadOnly = True
        Me.clmTipoGanadoKilos.Width = 90
        '
        'grbGanado
        '
        Me.grbGanado.Controls.Add(Me.dgvTiposGanadoReciba)
        Me.grbGanado.Location = New System.Drawing.Point(56, 94)
        Me.grbGanado.Name = "grbGanado"
        Me.grbGanado.Size = New System.Drawing.Size(313, 109)
        Me.grbGanado.TabIndex = 63
        Me.grbGanado.TabStop = False
        Me.grbGanado.Text = "Ganado de Corral Reciba"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvTiposGanadoLote)
        Me.GroupBox1.Location = New System.Drawing.Point(400, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(313, 109)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ganado de Lote Destino"
        '
        'dgvTiposGanadoLote
        '
        Me.dgvTiposGanadoLote.AllowUserToAddRows = False
        Me.dgvTiposGanadoLote.AllowUserToDeleteRows = False
        Me.dgvTiposGanadoLote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTiposGanadoLote.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.dgvTiposGanadoLote.Location = New System.Drawing.Point(6, 16)
        Me.dgvTiposGanadoLote.Name = "dgvTiposGanadoLote"
        Me.dgvTiposGanadoLote.ReadOnly = True
        Me.dgvTiposGanadoLote.RowHeadersVisible = False
        Me.dgvTiposGanadoLote.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTiposGanadoLote.Size = New System.Drawing.Size(301, 87)
        Me.dgvTiposGanadoLote.TabIndex = 62
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "DescripcionTipoGanado"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Tipo de Ganado"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 120
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Cabezas"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn8.HeaderText = "Cabezas"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 70
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "KilosEntrada"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N2"
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn9.HeaderText = "Kilos"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 90
        '
        'clmAreteTransporte
        '
        Me.clmAreteTransporte.DataPropertyName = "AreteTransporte"
        Me.clmAreteTransporte.HeaderText = "Arete de Transporte"
        Me.clmAreteTransporte.Name = "clmAreteTransporte"
        Me.clmAreteTransporte.Width = 75
        '
        'clmAreteSiniiga
        '
        Me.clmAreteSiniiga.DataPropertyName = "AreteSiniiga"
        Me.clmAreteSiniiga.HeaderText = "Arete de SINIIGA"
        Me.clmAreteSiniiga.Name = "clmAreteSiniiga"
        Me.clmAreteSiniiga.Width = 75
        '
        'clmArete
        '
        Me.clmArete.DataPropertyName = "Arete"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.clmArete.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmArete.HeaderText = "Arete Propio"
        Me.clmArete.Name = "clmArete"
        Me.clmArete.Width = 75
        '
        'clmIdTipoGanado
        '
        Me.clmIdTipoGanado.DataPropertyName = "IdTipoGanado"
        Me.clmIdTipoGanado.HeaderText = "Tipo de Ganado"
        Me.clmIdTipoGanado.Name = "clmIdTipoGanado"
        Me.clmIdTipoGanado.Width = 200
        '
        'clmCabezas
        '
        Me.clmCabezas.HeaderText = "Cabezas"
        Me.clmCabezas.Name = "clmCabezas"
        Me.clmCabezas.Visible = False
        '
        'clmKilos
        '
        Me.clmKilos.DataPropertyName = "Kilos"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.clmKilos.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmKilos.HeaderText = "Kilos"
        Me.clmKilos.Name = "clmKilos"
        Me.clmKilos.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmKilos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clmKilos.Width = 55
        '
        'clmCostoxKilo
        '
        Me.clmCostoxKilo.DataPropertyName = "CostoxKilo"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.clmCostoxKilo.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmCostoxKilo.HeaderText = "Costo/Kg."
        Me.clmCostoxKilo.Name = "clmCostoxKilo"
        Me.clmCostoxKilo.ReadOnly = True
        Me.clmCostoxKilo.Width = 60
        '
        'clmImporte
        '
        Me.clmImporte.DataPropertyName = "Importe"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.clmImporte.DefaultCellStyle = DataGridViewCellStyle4
        Me.clmImporte.HeaderText = "Importe"
        Me.clmImporte.Name = "clmImporte"
        Me.clmImporte.ReadOnly = True
        Me.clmImporte.Width = 90
        '
        'frmSalidasRecibaCorral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 563)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grbGanado)
        Me.Controls.Add(Me.lblEstatus)
        Me.Controls.Add(Me.cmbLoteDestino)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTotalImporte)
        Me.Controls.Add(Me.txtTotalKilos)
        Me.Controls.Add(Me.dgvDetalle)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbCorral)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.Name = "frmSalidasRecibaCorral"
        Me.Text = "TRANSFERENCIA DE RECIBA A CORRAL"
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTiposGanadoReciba, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbGanado.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvTiposGanadoLote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents cmbCorral As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtTotalKilos As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalImporte As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbLoteDestino As System.Windows.Forms.ComboBox
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents dgvTiposGanadoReciba As System.Windows.Forms.DataGridView
    Friend WithEvents grbGanado As System.Windows.Forms.GroupBox
    Friend WithEvents clmTipoGanadoDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTipoGanadoCabezas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTipoGanadoKilos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvTiposGanadoLote As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmAreteTransporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmAreteSiniiga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmArete As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdTipoGanado As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents clmCabezas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmKilos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCostoxKilo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmImporte As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
