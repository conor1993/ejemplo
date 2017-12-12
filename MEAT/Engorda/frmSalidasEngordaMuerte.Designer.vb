<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalidasEngordaMuerte

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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtFolio = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.dgvLotes = New System.Windows.Forms.DataGridView
        Me.txtTotalCabezas = New System.Windows.Forms.TextBox
        Me.txtTotalKilos = New System.Windows.Forms.TextBox
        Me.txtTotalImporte = New System.Windows.Forms.TextBox
        Me.dgvDetalleLote = New System.Windows.Forms.DataGridView
        Me.clmSeleccion = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.clmIdMceCatLotesDet = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmAreteTransporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmAreteSINIIGA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmArete = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmDetalleKilos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmDetalleCostoxKilo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmTipoGanado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label3 = New System.Windows.Forms.Label
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtNoAviso = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbCausaMuerte = New System.Windows.Forms.ComboBox
        Me.chkRecuperacion = New System.Windows.Forms.CheckBox
        Me.clmLote = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.clmCorral = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIdTipoGanado = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.clmCabezas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmKilos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmImporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgvLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalleLote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEstatus
        '
        Me.lblEstatus.Location = New System.Drawing.Point(407, 32)
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(554, 29)
        Me.lblTitulo.Text = "SALIDAS DE CORRAL POR MUERTE"
        '
        'tbrMenu
        '
        Me.tbrMenu.MostrarEditar = False
        Me.tbrMenu.Size = New System.Drawing.Size(50, 528)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Folio:"
        '
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(115, 37)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.ReadOnly = True
        Me.txtFolio.Size = New System.Drawing.Size(100, 20)
        Me.txtFolio.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(221, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(267, 37)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(85, 20)
        Me.dtpFecha.TabIndex = 34
        '
        'dgvLotes
        '
        Me.dgvLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmLote, Me.clmCorral, Me.clmIdTipoGanado, Me.clmCabezas, Me.clmKilos, Me.clmImporte})
        Me.dgvLotes.Location = New System.Drawing.Point(58, 90)
        Me.dgvLotes.MultiSelect = False
        Me.dgvLotes.Name = "dgvLotes"
        Me.dgvLotes.RowHeadersVisible = False
        Me.dgvLotes.Size = New System.Drawing.Size(532, 161)
        Me.dgvLotes.TabIndex = 36
        '
        'txtTotalCabezas
        '
        Me.txtTotalCabezas.Location = New System.Drawing.Point(354, 257)
        Me.txtTotalCabezas.Name = "txtTotalCabezas"
        Me.txtTotalCabezas.ReadOnly = True
        Me.txtTotalCabezas.Size = New System.Drawing.Size(54, 20)
        Me.txtTotalCabezas.TabIndex = 37
        Me.txtTotalCabezas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalKilos
        '
        Me.txtTotalKilos.Location = New System.Drawing.Point(411, 257)
        Me.txtTotalKilos.Name = "txtTotalKilos"
        Me.txtTotalKilos.ReadOnly = True
        Me.txtTotalKilos.Size = New System.Drawing.Size(70, 20)
        Me.txtTotalKilos.TabIndex = 38
        Me.txtTotalKilos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalImporte
        '
        Me.txtTotalImporte.Location = New System.Drawing.Point(483, 257)
        Me.txtTotalImporte.Name = "txtTotalImporte"
        Me.txtTotalImporte.ReadOnly = True
        Me.txtTotalImporte.Size = New System.Drawing.Size(89, 20)
        Me.txtTotalImporte.TabIndex = 39
        Me.txtTotalImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvDetalleLote
        '
        Me.dgvDetalleLote.AllowUserToAddRows = False
        Me.dgvDetalleLote.AllowUserToDeleteRows = False
        Me.dgvDetalleLote.CausesValidation = False
        Me.dgvDetalleLote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleLote.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmSeleccion, Me.clmIdMceCatLotesDet, Me.clmAreteTransporte, Me.clmAreteSINIIGA, Me.clmArete, Me.clmDetalleKilos, Me.clmDetalleCostoxKilo, Me.clmTipoGanado})
        Me.dgvDetalleLote.Location = New System.Drawing.Point(60, 283)
        Me.dgvDetalleLote.MultiSelect = False
        Me.dgvDetalleLote.Name = "dgvDetalleLote"
        Me.dgvDetalleLote.RowHeadersVisible = False
        Me.dgvDetalleLote.Size = New System.Drawing.Size(532, 233)
        Me.dgvDetalleLote.TabIndex = 60
        '
        'clmSeleccion
        '
        Me.clmSeleccion.HeaderText = ""
        Me.clmSeleccion.Name = "clmSeleccion"
        Me.clmSeleccion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmSeleccion.Width = 20
        '
        'clmIdMceCatLotesDet
        '
        Me.clmIdMceCatLotesDet.DataPropertyName = "IdMceCatLotesDet"
        Me.clmIdMceCatLotesDet.HeaderText = "IdMceCatLotesDet"
        Me.clmIdMceCatLotesDet.Name = "clmIdMceCatLotesDet"
        Me.clmIdMceCatLotesDet.ReadOnly = True
        Me.clmIdMceCatLotesDet.Visible = False
        '
        'clmAreteTransporte
        '
        Me.clmAreteTransporte.DataPropertyName = "AreteTransporte"
        Me.clmAreteTransporte.HeaderText = "Arete de Transporte"
        Me.clmAreteTransporte.Name = "clmAreteTransporte"
        Me.clmAreteTransporte.ReadOnly = True
        Me.clmAreteTransporte.Width = 80
        '
        'clmAreteSINIIGA
        '
        Me.clmAreteSINIIGA.DataPropertyName = "AreteSiniiga"
        Me.clmAreteSINIIGA.HeaderText = "Arete SINIIGA"
        Me.clmAreteSINIIGA.Name = "clmAreteSINIIGA"
        Me.clmAreteSINIIGA.ReadOnly = True
        Me.clmAreteSINIIGA.Width = 80
        '
        'clmArete
        '
        Me.clmArete.DataPropertyName = "AretePropio"
        Me.clmArete.HeaderText = "Arete Propio"
        Me.clmArete.Name = "clmArete"
        Me.clmArete.ReadOnly = True
        Me.clmArete.Width = 80
        '
        'clmDetalleKilos
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.clmDetalleKilos.DefaultCellStyle = DataGridViewCellStyle4
        Me.clmDetalleKilos.HeaderText = "Kilos"
        Me.clmDetalleKilos.Name = "clmDetalleKilos"
        Me.clmDetalleKilos.ReadOnly = True
        Me.clmDetalleKilos.Width = 70
        '
        'clmDetalleCostoxKilo
        '
        Me.clmDetalleCostoxKilo.DataPropertyName = "CostoxKilo"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.clmDetalleCostoxKilo.DefaultCellStyle = DataGridViewCellStyle5
        Me.clmDetalleCostoxKilo.HeaderText = "Costo/Kg"
        Me.clmDetalleCostoxKilo.Name = "clmDetalleCostoxKilo"
        Me.clmDetalleCostoxKilo.ReadOnly = True
        Me.clmDetalleCostoxKilo.Width = 70
        '
        'clmTipoGanado
        '
        Me.clmTipoGanado.DataPropertyName = "TipoGanado"
        Me.clmTipoGanado.HeaderText = "Tipo de Ganado"
        Me.clmTipoGanado.Name = "clmTipoGanado"
        Me.clmTipoGanado.ReadOnly = True
        Me.clmTipoGanado.Width = 110
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(309, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Total:"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Cabezas"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cabezas"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 70
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Kilos"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N0"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn2.HeaderText = "Kilos"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 70
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CostoxKilo"
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn3.HeaderText = "CostoxKilo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn3.Width = 70
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Importe"
        DataGridViewCellStyle8.Format = "C2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn4.HeaderText = "Importe"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CabezasExistentes"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "C2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cabezas Existentes"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 55
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "KilosExistentes"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N0"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn6.HeaderText = "Kilos Existentes"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 60
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Kilos"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn7.HeaderText = "Kilos"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 70
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CostoxKilo"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "C2"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn8.HeaderText = "CostoxKilo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 60
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "TipoGanado"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Tipo de Ganado"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 160
        '
        'txtNoAviso
        '
        Me.txtNoAviso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNoAviso.Location = New System.Drawing.Point(115, 63)
        Me.txtNoAviso.Name = "txtNoAviso"
        Me.txtNoAviso.Size = New System.Drawing.Size(100, 20)
        Me.txtNoAviso.TabIndex = 63
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "No Aviso."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(221, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Causa de Muerte:"
        '
        'cmbCausaMuerte
        '
        Me.cmbCausaMuerte.FormattingEnabled = True
        Me.cmbCausaMuerte.Location = New System.Drawing.Point(318, 63)
        Me.cmbCausaMuerte.Name = "cmbCausaMuerte"
        Me.cmbCausaMuerte.Size = New System.Drawing.Size(173, 21)
        Me.cmbCausaMuerte.TabIndex = 65
        '
        'chkRecuperacion
        '
        Me.chkRecuperacion.AutoSize = True
        Me.chkRecuperacion.Location = New System.Drawing.Point(497, 65)
        Me.chkRecuperacion.Name = "chkRecuperacion"
        Me.chkRecuperacion.Size = New System.Drawing.Size(93, 17)
        Me.chkRecuperacion.TabIndex = 66
        Me.chkRecuperacion.Text = "Recuperación"
        Me.chkRecuperacion.UseVisualStyleBackColor = True
        '
        'clmLote
        '
        Me.clmLote.HeaderText = "Lote"
        Me.clmLote.Name = "clmLote"
        '
        'clmCorral
        '
        Me.clmCorral.HeaderText = "Corral"
        Me.clmCorral.Name = "clmCorral"
        Me.clmCorral.ReadOnly = True
        Me.clmCorral.Width = 85
        '
        'clmIdTipoGanado
        '
        Me.clmIdTipoGanado.HeaderText = "Tipo de Ganado"
        Me.clmIdTipoGanado.Name = "clmIdTipoGanado"
        Me.clmIdTipoGanado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clmIdTipoGanado.Width = 115
        '
        'clmCabezas
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = "0"
        Me.clmCabezas.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmCabezas.HeaderText = "Cabezas"
        Me.clmCabezas.Name = "clmCabezas"
        Me.clmCabezas.ReadOnly = True
        Me.clmCabezas.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmCabezas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clmCabezas.Width = 50
        '
        'clmKilos
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.clmKilos.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmKilos.HeaderText = "Kilos"
        Me.clmKilos.Name = "clmKilos"
        Me.clmKilos.ReadOnly = True
        Me.clmKilos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clmKilos.Width = 70
        '
        'clmImporte
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.clmImporte.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmImporte.HeaderText = "Importe"
        Me.clmImporte.Name = "clmImporte"
        Me.clmImporte.ReadOnly = True
        Me.clmImporte.Width = 90
        '
        'frmSalidasEngordaMuerte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 528)
        Me.Controls.Add(Me.chkRecuperacion)
        Me.Controls.Add(Me.cmbCausaMuerte)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNoAviso)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvDetalleLote)
        Me.Controls.Add(Me.txtTotalImporte)
        Me.Controls.Add(Me.txtTotalKilos)
        Me.Controls.Add(Me.txtTotalCabezas)
        Me.Controls.Add(Me.dgvLotes)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmSalidasEngordaMuerte"
        Me.Text = "SALIDAS DE CORRAL POR MUERTE"
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.txtFolio, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.dtpFecha, 0)
        Me.Controls.SetChildIndex(Me.dgvLotes, 0)
        Me.Controls.SetChildIndex(Me.txtTotalCabezas, 0)
        Me.Controls.SetChildIndex(Me.txtTotalKilos, 0)
        Me.Controls.SetChildIndex(Me.txtTotalImporte, 0)
        Me.Controls.SetChildIndex(Me.dgvDetalleLote, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.txtNoAviso, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.cmbCausaMuerte, 0)
        Me.Controls.SetChildIndex(Me.lblEstatus, 0)
        Me.Controls.SetChildIndex(Me.chkRecuperacion, 0)
        Me.Controls.SetChildIndex(Me.tbrMenu, 0)
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        CType(Me.dgvLotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalleLote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgvLotes As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtTotalCabezas As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalKilos As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalImporte As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvDetalleLote As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtNoAviso As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbCausaMuerte As System.Windows.Forms.ComboBox
    Friend WithEvents chkRecuperacion As System.Windows.Forms.CheckBox
    Friend WithEvents clmSeleccion As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents clmIdMceCatLotesDet As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmAreteTransporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmAreteSINIIGA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmArete As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDetalleKilos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDetalleCostoxKilo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTipoGanado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmLote As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents clmCorral As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdTipoGanado As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents clmCabezas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmKilos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmImporte As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
