<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNotaCredito
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
        Me.components = New System.ComponentModel.Container()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.mtb = New MEAToolBar.MEAToolBar()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFolioFactura = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblEstatus = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvFacturas = New System.Windows.Forms.DataGridView()
        Me.clmChecado = New Infragistics.Win.UltraDataGridView.UltraCheckEditorColumn(Me.components)
        Me.clmCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmUnidadSAT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmClaveProdSAT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmIva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTotalFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmSaldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTotalNotas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCodigoCliente = New System.Windows.Forms.TextBox()
        Me.txtRFC = New System.Windows.Forms.TextBox()
        Me.lblRFC = New System.Windows.Forms.Label()
        Me.LblClaveCliente = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.LblMunicipio = New System.Windows.Forms.Label()
        Me.TxtLocalidad = New System.Windows.Forms.TextBox()
        Me.LblLocalidad = New System.Windows.Forms.Label()
        Me.TxtCP = New System.Windows.Forms.TextBox()
        Me.LblCP = New System.Windows.Forms.Label()
        Me.LblColonia = New System.Windows.Forms.Label()
        Me.txtColonia = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.CmbMetodoPago = New System.Windows.Forms.ComboBox()
        Me.LblMetPag = New System.Windows.Forms.Label()
        Me.LblForPag = New System.Windows.Forms.Label()
        Me.CmbFormaPago = New System.Windows.Forms.ComboBox()
        Me.lblUsoCFDI = New System.Windows.Forms.Label()
        Me.UsoCFDI = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtIdClienteBuscar = New System.Windows.Forms.TextBox()
        Me.txtClienteBuscar = New System.Windows.Forms.TextBox()
        Me.txtIVA = New System.Windows.Forms.TextBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.lblIVA = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.mtb.MostrarBorrar = True
        Me.mtb.MostrarBuscar = True
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 625)
        Me.mtb.TabIndex = 62
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
        Me.Label17.Size = New System.Drawing.Size(846, 32)
        Me.Label17.TabIndex = 63
        Me.Label17.Text = "NOTAS DE CRÉDITO"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Folio:"
        '
        'txtFolioFactura
        '
        Me.txtFolioFactura.Location = New System.Drawing.Point(132, 71)
        Me.txtFolioFactura.Name = "txtFolioFactura"
        Me.txtFolioFactura.ReadOnly = True
        Me.txtFolioFactura.Size = New System.Drawing.Size(90, 20)
        Me.txtFolioFactura.TabIndex = 65
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(742, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Fecha:"
        '
        'DtpFecha
        '
        Me.DtpFecha.Enabled = False
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(788, 64)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(89, 20)
        Me.DtpFecha.TabIndex = 67
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 518)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Obervaciones:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Location = New System.Drawing.Point(144, 515)
        Me.txtObservaciones.MaxLength = 150
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(381, 72)
        Me.txtObservaciones.TabIndex = 73
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(708, 570)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 80
        Me.lblTotal.Text = "Total:"
        '
        'lblEstatus
        '
        Me.lblEstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(659, 38)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(229, 21)
        Me.lblEstatus.TabIndex = 86
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NomCliente"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NomConcepto"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Concepto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Estatus"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Estatus"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(777, 567)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 96
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvFacturas)
        Me.GroupBox3.Location = New System.Drawing.Point(56, 246)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(828, 256)
        Me.GroupBox3.TabIndex = 98
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Facturas"
        '
        'dgvFacturas
        '
        Me.dgvFacturas.AllowUserToAddRows = False
        Me.dgvFacturas.AllowUserToDeleteRows = False
        Me.dgvFacturas.AllowUserToOrderColumns = True
        Me.dgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvFacturas.CausesValidation = False
        Me.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmChecado, Me.clmCantidad, Me.clmUnidadSAT, Me.clmEstatus, Me.clmUnidad, Me.clmClaveProdSAT, Me.clmDescripcion, Me.clmImporte, Me.clmIva, Me.clmFactura, Me.clmTotal, Me.clmTotalFactura, Me.clmSaldo, Me.clmTotalNotas})
        Me.dgvFacturas.Location = New System.Drawing.Point(8, 19)
        Me.dgvFacturas.Name = "dgvFacturas"
        Me.dgvFacturas.RowHeadersVisible = False
        Me.dgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFacturas.Size = New System.Drawing.Size(811, 225)
        Me.dgvFacturas.TabIndex = 97
        '
        'clmChecado
        '
        Me.clmChecado.CheckedAppearance = Appearance4
        Me.clmChecado.DataPropertyName = "Seleccionado"
        Me.clmChecado.DefaultNewRowValue = 0
        Me.clmChecado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.[Default]
        Me.clmChecado.FillWeight = 6.0!
        Me.clmChecado.HeaderText = " "
        Me.clmChecado.HotTrackingAppearance = Appearance5
        Me.clmChecado.IndeterminateAppearance = Appearance6
        Me.clmChecado.Name = "clmChecado"
        Me.clmChecado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmChecado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clmChecado.Visible = False
        '
        'clmCantidad
        '
        Me.clmCantidad.FillWeight = 6.0!
        Me.clmCantidad.HeaderText = "Cantidad"
        Me.clmCantidad.Name = "clmCantidad"
        Me.clmCantidad.ReadOnly = True
        '
        'clmUnidadSAT
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Format = "d"
        Me.clmUnidadSAT.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmUnidadSAT.FillWeight = 12.0!
        Me.clmUnidadSAT.HeaderText = "Unidad SAT"
        Me.clmUnidadSAT.Name = "clmUnidadSAT"
        Me.clmUnidadSAT.ReadOnly = True
        '
        'clmEstatus
        '
        Me.clmEstatus.FillWeight = 6.0!
        Me.clmEstatus.HeaderText = "Estatus"
        Me.clmEstatus.Name = "clmEstatus"
        Me.clmEstatus.ReadOnly = True
        Me.clmEstatus.Visible = False
        '
        'clmUnidad
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.clmUnidad.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmUnidad.FillWeight = 7.0!
        Me.clmUnidad.HeaderText = "Unidad"
        Me.clmUnidad.Name = "clmUnidad"
        Me.clmUnidad.ReadOnly = True
        '
        'clmClaveProdSAT
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.clmClaveProdSAT.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmClaveProdSAT.FillWeight = 19.0!
        Me.clmClaveProdSAT.HeaderText = "Productos / Servicios SAT"
        Me.clmClaveProdSAT.Name = "clmClaveProdSAT"
        Me.clmClaveProdSAT.ReadOnly = True
        '
        'clmDescripcion
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.clmDescripcion.DefaultCellStyle = DataGridViewCellStyle4
        Me.clmDescripcion.FillWeight = 30.0!
        Me.clmDescripcion.HeaderText = "Descripcion"
        Me.clmDescripcion.Name = "clmDescripcion"
        '
        'clmImporte
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.clmImporte.DefaultCellStyle = DataGridViewCellStyle5
        Me.clmImporte.FillWeight = 11.0!
        Me.clmImporte.HeaderText = "Prec Unitario"
        Me.clmImporte.Name = "clmImporte"
        '
        'clmIva
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.clmIva.DefaultCellStyle = DataGridViewCellStyle6
        Me.clmIva.FillWeight = 9.0!
        Me.clmIva.HeaderText = "Importe"
        Me.clmIva.Name = "clmIva"
        '
        'clmFactura
        '
        Me.clmFactura.HeaderText = "factura"
        Me.clmFactura.Name = "clmFactura"
        Me.clmFactura.Visible = False
        '
        'clmTotal
        '
        Me.clmTotal.HeaderText = "total"
        Me.clmTotal.Name = "clmTotal"
        Me.clmTotal.Visible = False
        '
        'clmTotalFactura
        '
        Me.clmTotalFactura.HeaderText = "totalfactura"
        Me.clmTotalFactura.Name = "clmTotalFactura"
        Me.clmTotalFactura.Visible = False
        '
        'clmSaldo
        '
        Me.clmSaldo.HeaderText = "Saldo"
        Me.clmSaldo.Name = "clmSaldo"
        Me.clmSaldo.Visible = False
        '
        'clmTotalNotas
        '
        Me.clmTotalNotas.HeaderText = "Total Notas"
        Me.clmTotalNotas.Name = "clmTotalNotas"
        Me.clmTotalNotas.Visible = False
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.Location = New System.Drawing.Point(67, 19)
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.Size = New System.Drawing.Size(65, 20)
        Me.txtCodigoCliente.TabIndex = 100
        '
        'txtRFC
        '
        Me.txtRFC.Enabled = False
        Me.txtRFC.Location = New System.Drawing.Point(67, 45)
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(101, 20)
        Me.txtRFC.TabIndex = 99
        '
        'lblRFC
        '
        Me.lblRFC.AutoSize = True
        Me.lblRFC.Location = New System.Drawing.Point(11, 49)
        Me.lblRFC.Name = "lblRFC"
        Me.lblRFC.Size = New System.Drawing.Size(43, 13)
        Me.lblRFC.TabIndex = 103
        Me.lblRFC.Text = "R.F.C. :"
        '
        'LblClaveCliente
        '
        Me.LblClaveCliente.AutoSize = True
        Me.LblClaveCliente.Location = New System.Drawing.Point(11, 23)
        Me.LblClaveCliente.Name = "LblClaveCliente"
        Me.LblClaveCliente.Size = New System.Drawing.Size(45, 13)
        Me.LblClaveCliente.TabIndex = 102
        Me.LblClaveCliente.Text = "Cliente :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCliente)
        Me.GroupBox1.Controls.Add(Me.txtEstado)
        Me.GroupBox1.Controls.Add(Me.lblEstado)
        Me.GroupBox1.Controls.Add(Me.txtMunicipio)
        Me.GroupBox1.Controls.Add(Me.LblMunicipio)
        Me.GroupBox1.Controls.Add(Me.TxtLocalidad)
        Me.GroupBox1.Controls.Add(Me.LblLocalidad)
        Me.GroupBox1.Controls.Add(Me.TxtCP)
        Me.GroupBox1.Controls.Add(Me.LblCP)
        Me.GroupBox1.Controls.Add(Me.LblColonia)
        Me.GroupBox1.Controls.Add(Me.txtColonia)
        Me.GroupBox1.Controls.Add(Me.txtCalle)
        Me.GroupBox1.Controls.Add(Me.lblCalle)
        Me.GroupBox1.Controls.Add(Me.LblClaveCliente)
        Me.GroupBox1.Controls.Add(Me.txtCodigoCliente)
        Me.GroupBox1.Controls.Add(Me.txtRFC)
        Me.GroupBox1.Controls.Add(Me.lblRFC)
        Me.GroupBox1.Location = New System.Drawing.Point(65, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(542, 134)
        Me.GroupBox1.TabIndex = 104
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(147, 18)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(377, 20)
        Me.txtCliente.TabIndex = 116
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(329, 97)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(195, 20)
        Me.txtEstado.TabIndex = 115
        '
        'lblEstado
        '
        Me.lblEstado.Location = New System.Drawing.Point(270, 102)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(58, 16)
        Me.lblEstado.TabIndex = 114
        Me.lblEstado.Text = "Estado:"
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Location = New System.Drawing.Point(329, 71)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(195, 20)
        Me.txtMunicipio.TabIndex = 113
        '
        'LblMunicipio
        '
        Me.LblMunicipio.Location = New System.Drawing.Point(270, 75)
        Me.LblMunicipio.Name = "LblMunicipio"
        Me.LblMunicipio.Size = New System.Drawing.Size(58, 16)
        Me.LblMunicipio.TabIndex = 112
        Me.LblMunicipio.Text = "Municipio:"
        '
        'TxtLocalidad
        '
        Me.TxtLocalidad.Location = New System.Drawing.Point(329, 44)
        Me.TxtLocalidad.Name = "TxtLocalidad"
        Me.TxtLocalidad.Size = New System.Drawing.Size(195, 20)
        Me.TxtLocalidad.TabIndex = 111
        '
        'LblLocalidad
        '
        Me.LblLocalidad.Location = New System.Drawing.Point(270, 49)
        Me.LblLocalidad.Name = "LblLocalidad"
        Me.LblLocalidad.Size = New System.Drawing.Size(58, 16)
        Me.LblLocalidad.TabIndex = 110
        Me.LblLocalidad.Text = "Localidad:"
        '
        'TxtCP
        '
        Me.TxtCP.Location = New System.Drawing.Point(203, 45)
        Me.TxtCP.Name = "TxtCP"
        Me.TxtCP.Size = New System.Drawing.Size(61, 20)
        Me.TxtCP.TabIndex = 109
        '
        'LblCP
        '
        Me.LblCP.AutoEllipsis = True
        Me.LblCP.AutoSize = True
        Me.LblCP.Location = New System.Drawing.Point(169, 49)
        Me.LblCP.Name = "LblCP"
        Me.LblCP.Size = New System.Drawing.Size(30, 13)
        Me.LblCP.TabIndex = 108
        Me.LblCP.Text = "C.P.:"
        '
        'LblColonia
        '
        Me.LblColonia.Location = New System.Drawing.Point(13, 101)
        Me.LblColonia.Name = "LblColonia"
        Me.LblColonia.Size = New System.Drawing.Size(50, 13)
        Me.LblColonia.TabIndex = 107
        Me.LblColonia.Text = "Colonia:"
        '
        'txtColonia
        '
        Me.txtColonia.Location = New System.Drawing.Point(69, 98)
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(195, 20)
        Me.txtColonia.TabIndex = 106
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(69, 72)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(195, 20)
        Me.txtCalle.TabIndex = 105
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Location = New System.Drawing.Point(13, 76)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(33, 13)
        Me.lblCalle.TabIndex = 104
        Me.lblCalle.Text = "Calle:"
        '
        'CmbMetodoPago
        '
        Me.CmbMetodoPago.FormattingEnabled = True
        Me.CmbMetodoPago.Location = New System.Drawing.Point(103, 93)
        Me.CmbMetodoPago.Name = "CmbMetodoPago"
        Me.CmbMetodoPago.Size = New System.Drawing.Size(147, 21)
        Me.CmbMetodoPago.TabIndex = 105
        '
        'LblMetPag
        '
        Me.LblMetPag.Location = New System.Drawing.Point(4, 96)
        Me.LblMetPag.Name = "LblMetPag"
        Me.LblMetPag.Size = New System.Drawing.Size(99, 15)
        Me.LblMetPag.TabIndex = 106
        Me.LblMetPag.Text = "Metodo de Pago:"
        '
        'LblForPag
        '
        Me.LblForPag.Location = New System.Drawing.Point(4, 32)
        Me.LblForPag.Name = "LblForPag"
        Me.LblForPag.Size = New System.Drawing.Size(99, 16)
        Me.LblForPag.TabIndex = 107
        Me.LblForPag.Text = "Forma de Pago:"
        '
        'CmbFormaPago
        '
        Me.CmbFormaPago.FormattingEnabled = True
        Me.CmbFormaPago.Location = New System.Drawing.Point(103, 29)
        Me.CmbFormaPago.Name = "CmbFormaPago"
        Me.CmbFormaPago.Size = New System.Drawing.Size(147, 21)
        Me.CmbFormaPago.TabIndex = 108
        '
        'lblUsoCFDI
        '
        Me.lblUsoCFDI.Location = New System.Drawing.Point(4, 66)
        Me.lblUsoCFDI.Name = "lblUsoCFDI"
        Me.lblUsoCFDI.Size = New System.Drawing.Size(99, 17)
        Me.lblUsoCFDI.TabIndex = 109
        Me.lblUsoCFDI.Text = "Uso de CFDI:"
        '
        'UsoCFDI
        '
        Me.UsoCFDI.FormattingEnabled = True
        Me.UsoCFDI.Location = New System.Drawing.Point(103, 62)
        Me.UsoCFDI.Name = "UsoCFDI"
        Me.UsoCFDI.Size = New System.Drawing.Size(147, 21)
        Me.UsoCFDI.TabIndex = 110
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.UsoCFDI)
        Me.GroupBox2.Controls.Add(Me.lblUsoCFDI)
        Me.GroupBox2.Controls.Add(Me.CmbFormaPago)
        Me.GroupBox2.Controls.Add(Me.LblForPag)
        Me.GroupBox2.Controls.Add(Me.LblMetPag)
        Me.GroupBox2.Controls.Add(Me.CmbMetodoPago)
        Me.GroupBox2.Location = New System.Drawing.Point(619, 105)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(265, 133)
        Me.GroupBox2.TabIndex = 111
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacion del Pago"
        '
        'txtIdClienteBuscar
        '
        Me.txtIdClienteBuscar.Location = New System.Drawing.Point(132, 44)
        Me.txtIdClienteBuscar.Name = "txtIdClienteBuscar"
        Me.txtIdClienteBuscar.Size = New System.Drawing.Size(90, 20)
        Me.txtIdClienteBuscar.TabIndex = 112
        '
        'txtClienteBuscar
        '
        Me.txtClienteBuscar.Location = New System.Drawing.Point(229, 44)
        Me.txtClienteBuscar.Name = "txtClienteBuscar"
        Me.txtClienteBuscar.Size = New System.Drawing.Size(303, 20)
        Me.txtClienteBuscar.TabIndex = 113
        '
        'txtIVA
        '
        Me.txtIVA.Location = New System.Drawing.Point(777, 541)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.ReadOnly = True
        Me.txtIVA.Size = New System.Drawing.Size(100, 20)
        Me.txtIVA.TabIndex = 114
        Me.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Location = New System.Drawing.Point(777, 511)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubTotal.TabIndex = 115
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblIVA
        '
        Me.lblIVA.Location = New System.Drawing.Point(708, 544)
        Me.lblIVA.Name = "lblIVA"
        Me.lblIVA.Size = New System.Drawing.Size(52, 17)
        Me.lblIVA.TabIndex = 116
        Me.lblIVA.Text = "I.V.A.:"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.Location = New System.Drawing.Point(708, 514)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(52, 17)
        Me.lblSubTotal.TabIndex = 117
        Me.lblSubTotal.Text = "SubTotal:"
        '
        'FrmNotaCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 625)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.lblIVA)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.txtIVA)
        Me.Controls.Add(Me.txtClienteBuscar)
        Me.Controls.Add(Me.txtIdClienteBuscar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblEstatus)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DtpFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFolioFactura)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.Name = "FrmNotaCredito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notas de Crédito"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvEmbarques As System.Windows.Forms.ListView
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFolioFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents txtCodigoCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtRFC As System.Windows.Forms.TextBox
    Friend WithEvents lblRFC As System.Windows.Forms.Label
    Friend WithEvents LblClaveCliente As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtCP As System.Windows.Forms.TextBox
    Friend WithEvents LblCP As System.Windows.Forms.Label
    Friend WithEvents LblColonia As System.Windows.Forms.Label
    Friend WithEvents txtColonia As System.Windows.Forms.TextBox
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents lblCalle As System.Windows.Forms.Label
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents txtMunicipio As System.Windows.Forms.TextBox
    Friend WithEvents LblMunicipio As System.Windows.Forms.Label
    Friend WithEvents TxtLocalidad As System.Windows.Forms.TextBox
    Friend WithEvents LblLocalidad As System.Windows.Forms.Label
    Friend WithEvents CmbMetodoPago As System.Windows.Forms.ComboBox
    Friend WithEvents LblMetPag As System.Windows.Forms.Label
    Friend WithEvents LblForPag As System.Windows.Forms.Label
    Friend WithEvents CmbFormaPago As System.Windows.Forms.ComboBox
    Friend WithEvents lblUsoCFDI As System.Windows.Forms.Label
    Friend WithEvents UsoCFDI As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtIdClienteBuscar As System.Windows.Forms.TextBox
    Friend WithEvents txtClienteBuscar As System.Windows.Forms.TextBox
    Friend WithEvents txtIVA As System.Windows.Forms.TextBox
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblIVA As System.Windows.Forms.Label
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents clmChecado As Infragistics.Win.UltraDataGridView.UltraCheckEditorColumn
    Friend WithEvents clmCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmUnidadSAT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmClaveProdSAT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTotalFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSaldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTotalNotas As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
