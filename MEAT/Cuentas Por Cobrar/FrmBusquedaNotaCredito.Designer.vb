<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusquedaNotaCredito
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.DgvNotas = New System.Windows.Forms.DataGridView
        Me.clmFolio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblCliente = New System.Windows.Forms.Label
        Me.ultcmbCliente = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox
        Me.ultdtpFechaFinal = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ultdtpFechaInicio = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label4 = New System.Windows.Forms.Label
        Me.ulttxtFolioNota = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox
        Me.ultchkCancelada = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.ultchkAplicada = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.ultchkVigente = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.ultbtnAceptar = New Infragistics.Win.Misc.UltraButton
        Me.Label17 = New System.Windows.Forms.Label
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ultbtnCancelar = New Infragistics.Win.Misc.UltraButton
        Me.ulttxtFolFactura = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dgvNotaCreditoDetalle = New System.Windows.Forms.DataGridView
        Me.clmFolFactura = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIVA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmTotalDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEstatusDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFechaAplicacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFolioPago = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ultchkParcialmenteAplicable = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        Me.ultchkNoAplicable = New Infragistics.Win.UltraWinEditors.UltraCheckEditor
        CType(Me.DgvNotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ultcmbCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.ultdtpFechaFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ultdtpFechaInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ulttxtFolioNota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.ulttxtFolFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvNotaCreditoDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.mtb.Size = New System.Drawing.Size(50, 513)
        Me.mtb.TabIndex = 63
        '
        'DgvNotas
        '
        Me.DgvNotas.AllowUserToAddRows = False
        Me.DgvNotas.AllowUserToDeleteRows = False
        Me.DgvNotas.AllowUserToResizeRows = False
        Me.DgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvNotas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmFolio, Me.clmFecha, Me.clmCliente, Me.clmTotal, Me.clmEstatus})
        Me.DgvNotas.Location = New System.Drawing.Point(9, 19)
        Me.DgvNotas.Name = "DgvNotas"
        Me.DgvNotas.ReadOnly = True
        Me.DgvNotas.RowHeadersVisible = False
        Me.DgvNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvNotas.Size = New System.Drawing.Size(605, 153)
        Me.DgvNotas.TabIndex = 64
        '
        'clmFolio
        '
        Me.clmFolio.DataPropertyName = "FolNota"
        Me.clmFolio.HeaderText = "Folio"
        Me.clmFolio.Name = "clmFolio"
        Me.clmFolio.ReadOnly = True
        Me.clmFolio.Width = 80
        '
        'clmFecha
        '
        Me.clmFecha.DataPropertyName = "FechaNota"
        DataGridViewCellStyle13.Format = "d"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.clmFecha.DefaultCellStyle = DataGridViewCellStyle13
        Me.clmFecha.HeaderText = "Fecha"
        Me.clmFecha.Name = "clmFecha"
        Me.clmFecha.ReadOnly = True
        '
        'clmCliente
        '
        Me.clmCliente.DataPropertyName = "NombreCliente"
        Me.clmCliente.HeaderText = "Cliente"
        Me.clmCliente.Name = "clmCliente"
        Me.clmCliente.ReadOnly = True
        Me.clmCliente.Width = 150
        '
        'clmTotal
        '
        Me.clmTotal.DataPropertyName = "Total"
        DataGridViewCellStyle14.Format = "C2"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.clmTotal.DefaultCellStyle = DataGridViewCellStyle14
        Me.clmTotal.HeaderText = "Total"
        Me.clmTotal.Name = "clmTotal"
        Me.clmTotal.ReadOnly = True
        Me.clmTotal.Width = 150
        '
        'clmEstatus
        '
        Me.clmEstatus.DataPropertyName = "EstatusDescripcion"
        Me.clmEstatus.HeaderText = "Estatus"
        Me.clmEstatus.Name = "clmEstatus"
        Me.clmEstatus.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvNotas)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(624, 178)
        Me.GroupBox1.TabIndex = 88
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Notas de Crédito"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(64, 98)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 13)
        Me.lblCliente.TabIndex = 89
        Me.lblCliente.Text = "Cliente:"
        '
        'ultcmbCliente
        '
        Me.ultcmbCliente.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.ultcmbCliente.Location = New System.Drawing.Point(141, 94)
        Me.ultcmbCliente.Name = "ultcmbCliente"
        Me.ultcmbCliente.Size = New System.Drawing.Size(186, 21)
        Me.ultcmbCliente.TabIndex = 90
        Me.ultcmbCliente.Text = "Seleccione el Cliente"
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.ultdtpFechaFinal)
        Me.UltraGroupBox2.Controls.Add(Me.Label3)
        Me.UltraGroupBox2.Controls.Add(Me.Label2)
        Me.UltraGroupBox2.Controls.Add(Me.ultdtpFechaInicio)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(340, 40)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(144, 75)
        Me.UltraGroupBox2.TabIndex = 94
        Me.UltraGroupBox2.Text = "Fechas"
        '
        'ultdtpFechaFinal
        '
        Me.ultdtpFechaFinal.Location = New System.Drawing.Point(50, 47)
        Me.ultdtpFechaFinal.MaskInput = "{date}"
        Me.ultdtpFechaFinal.Name = "ultdtpFechaFinal"
        Me.ultdtpFechaFinal.Size = New System.Drawing.Size(84, 21)
        Me.ultdtpFechaFinal.TabIndex = 97
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "Hasta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "Inicio:"
        '
        'ultdtpFechaInicio
        '
        Me.ultdtpFechaInicio.Location = New System.Drawing.Point(50, 15)
        Me.ultdtpFechaInicio.MaskInput = "{date}"
        Me.ultdtpFechaInicio.Name = "ultdtpFechaInicio"
        Me.ultdtpFechaInicio.Size = New System.Drawing.Size(84, 21)
        Me.ultdtpFechaInicio.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(64, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 97
        Me.Label4.Text = "Folio Nota:"
        '
        'ulttxtFolioNota
        '
        Me.ulttxtFolioNota.Location = New System.Drawing.Point(141, 40)
        Me.ulttxtFolioNota.MaxLength = 8
        Me.ulttxtFolioNota.Name = "ulttxtFolioNota"
        Me.ulttxtFolioNota.Size = New System.Drawing.Size(100, 21)
        Me.ulttxtFolioNota.TabIndex = 98
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.ultchkNoAplicable)
        Me.UltraGroupBox1.Controls.Add(Me.ultchkParcialmenteAplicable)
        Me.UltraGroupBox1.Controls.Add(Me.ultchkCancelada)
        Me.UltraGroupBox1.Controls.Add(Me.ultchkAplicada)
        Me.UltraGroupBox1.Controls.Add(Me.ultchkVigente)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(490, 40)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(190, 75)
        Me.UltraGroupBox1.TabIndex = 101
        Me.UltraGroupBox1.Text = "Estatus"
        '
        'ultchkCancelada
        '
        Me.ultchkCancelada.Location = New System.Drawing.Point(82, 16)
        Me.ultchkCancelada.Name = "ultchkCancelada"
        Me.ultchkCancelada.Size = New System.Drawing.Size(91, 20)
        Me.ultchkCancelada.TabIndex = 2
        Me.ultchkCancelada.Text = "CANCELADA"
        '
        'ultchkAplicada
        '
        Me.ultchkAplicada.Location = New System.Drawing.Point(6, 33)
        Me.ultchkAplicada.Name = "ultchkAplicada"
        Me.ultchkAplicada.Size = New System.Drawing.Size(79, 20)
        Me.ultchkAplicada.TabIndex = 1
        Me.ultchkAplicada.Text = "APLICADA"
        '
        'ultchkVigente
        '
        Me.ultchkVigente.Location = New System.Drawing.Point(6, 15)
        Me.ultchkVigente.Name = "ultchkVigente"
        Me.ultchkVigente.Size = New System.Drawing.Size(79, 20)
        Me.ultchkVigente.TabIndex = 0
        Me.ultchkVigente.Text = "VIGENTE"
        '
        'ultbtnAceptar
        '
        Me.ultbtnAceptar.Location = New System.Drawing.Point(524, 483)
        Me.ultbtnAceptar.Name = "ultbtnAceptar"
        Me.ultbtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.ultbtnAceptar.TabIndex = 102
        Me.ultbtnAceptar.Text = "Aceptar"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(640, 32)
        Me.Label17.TabIndex = 104
        Me.Label17.Text = "Búsqueda de Notas de Crédito"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Folio"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Folio"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NomCliente"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Importe"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Estatus"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Estatus"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Folio"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Folio"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 80
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "NomCliente"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 150
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Importe"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 150
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Estatus"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Estatus"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'ultbtnCancelar
        '
        Me.ultbtnCancelar.Location = New System.Drawing.Point(605, 483)
        Me.ultbtnCancelar.Name = "ultbtnCancelar"
        Me.ultbtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.ultbtnCancelar.TabIndex = 106
        Me.ultbtnCancelar.Text = "Cancelar"
        '
        'ulttxtFolFactura
        '
        Me.ulttxtFolFactura.Location = New System.Drawing.Point(141, 67)
        Me.ulttxtFolFactura.MaxLength = 8
        Me.ulttxtFolFactura.Name = "ulttxtFolFactura"
        Me.ulttxtFolFactura.Size = New System.Drawing.Size(100, 21)
        Me.ulttxtFolFactura.TabIndex = 107
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Folio Factura:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvNotaCreditoDetalle)
        Me.GroupBox2.Location = New System.Drawing.Point(56, 305)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(624, 165)
        Me.GroupBox2.TabIndex = 109
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nota de Crédito Detalle"
        '
        'dgvNotaCreditoDetalle
        '
        Me.dgvNotaCreditoDetalle.AllowUserToAddRows = False
        Me.dgvNotaCreditoDetalle.AllowUserToDeleteRows = False
        Me.dgvNotaCreditoDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNotaCreditoDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmFolFactura, Me.clmSubtotal, Me.clmIVA, Me.clmTotalDetalle, Me.clmEstatusDetalle, Me.clmFechaAplicacion, Me.clmFolioPago})
        Me.dgvNotaCreditoDetalle.Location = New System.Drawing.Point(9, 19)
        Me.dgvNotaCreditoDetalle.Name = "dgvNotaCreditoDetalle"
        Me.dgvNotaCreditoDetalle.RowHeadersVisible = False
        Me.dgvNotaCreditoDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvNotaCreditoDetalle.Size = New System.Drawing.Size(605, 140)
        Me.dgvNotaCreditoDetalle.TabIndex = 0
        '
        'clmFolFactura
        '
        Me.clmFolFactura.DataPropertyName = "FolFactura"
        Me.clmFolFactura.HeaderText = "Factura"
        Me.clmFolFactura.Name = "clmFolFactura"
        Me.clmFolFactura.Width = 90
        '
        'clmSubtotal
        '
        Me.clmSubtotal.DataPropertyName = "SubTotal"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Format = "C2"
        DataGridViewCellStyle15.NullValue = Nothing
        Me.clmSubtotal.DefaultCellStyle = DataGridViewCellStyle15
        Me.clmSubtotal.HeaderText = "SubTotal"
        Me.clmSubtotal.Name = "clmSubtotal"
        Me.clmSubtotal.Width = 80
        '
        'clmIVA
        '
        Me.clmIVA.DataPropertyName = "ImpteIVA"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.Format = "N2"
        DataGridViewCellStyle16.NullValue = Nothing
        Me.clmIVA.DefaultCellStyle = DataGridViewCellStyle16
        Me.clmIVA.HeaderText = "IVA"
        Me.clmIVA.Name = "clmIVA"
        Me.clmIVA.Width = 50
        '
        'clmTotalDetalle
        '
        Me.clmTotalDetalle.DataPropertyName = "Total"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle17.Format = "C2"
        DataGridViewCellStyle17.NullValue = Nothing
        Me.clmTotalDetalle.DefaultCellStyle = DataGridViewCellStyle17
        Me.clmTotalDetalle.HeaderText = "Total"
        Me.clmTotalDetalle.Name = "clmTotalDetalle"
        '
        'clmEstatusDetalle
        '
        Me.clmEstatusDetalle.HeaderText = "Estatus"
        Me.clmEstatusDetalle.Name = "clmEstatusDetalle"
        '
        'clmFechaAplicacion
        '
        Me.clmFechaAplicacion.DataPropertyName = "FecAplica"
        DataGridViewCellStyle18.Format = "d"
        DataGridViewCellStyle18.NullValue = Nothing
        Me.clmFechaAplicacion.DefaultCellStyle = DataGridViewCellStyle18
        Me.clmFechaAplicacion.HeaderText = "Fecha Aplicacion"
        Me.clmFechaAplicacion.Name = "clmFechaAplicacion"
        Me.clmFechaAplicacion.Width = 70
        '
        'clmFolioPago
        '
        Me.clmFolioPago.DataPropertyName = "FolPago"
        Me.clmFolioPago.HeaderText = "Folio Pago"
        Me.clmFolioPago.Name = "clmFolioPago"
        Me.clmFolioPago.Width = 90
        '
        'ultchkParcialmenteAplicable
        '
        Me.ultchkParcialmenteAplicable.Location = New System.Drawing.Point(6, 51)
        Me.ultchkParcialmenteAplicable.Name = "ultchkParcialmenteAplicable"
        Me.ultchkParcialmenteAplicable.Size = New System.Drawing.Size(174, 20)
        Me.ultchkParcialmenteAplicable.TabIndex = 3
        Me.ultchkParcialmenteAplicable.Text = "PARCIALMENTE APLICADO"
        '
        'ultchkNoAplicable
        '
        Me.ultchkNoAplicable.Location = New System.Drawing.Point(82, 33)
        Me.ultchkNoAplicable.Name = "ultchkNoAplicable"
        Me.ultchkNoAplicable.Size = New System.Drawing.Size(106, 20)
        Me.ultchkNoAplicable.TabIndex = 4
        Me.ultchkNoAplicable.Text = "NO APLICABLE"
        '
        'FrmBusquedaNotaCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 513)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ulttxtFolFactura)
        Me.Controls.Add(Me.ultbtnCancelar)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.ultbtnAceptar)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Controls.Add(Me.ulttxtFolioNota)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.UltraGroupBox2)
        Me.Controls.Add(Me.ultcmbCliente)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mtb)
        Me.Name = "FrmBusquedaNotaCredito"
        Me.Text = "Búsqueda de Notas de Crédito"
        CType(Me.DgvNotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ultcmbCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.ultdtpFechaFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ultdtpFechaInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ulttxtFolioNota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.ulttxtFolFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvNotaCreditoDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents DgvNotas As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents ultcmbCliente As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ultdtpFechaInicio As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents ultdtpFechaFinal As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ulttxtFolioNota As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ultchkCancelada As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents ultchkAplicada As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents ultchkVigente As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents ultbtnAceptar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ultbtnCancelar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents clmFolio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ulttxtFolFactura As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvNotaCreditoDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents clmFolFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSubtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTotalDetalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEstatusDetalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaAplicacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFolioPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ultchkParcialmenteAplicable As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents ultchkNoAplicable As Infragistics.Win.UltraWinEditors.UltraCheckEditor
End Class
