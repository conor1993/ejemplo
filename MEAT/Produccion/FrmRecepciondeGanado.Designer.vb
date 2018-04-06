<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRecepciondeGanado
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.mtb = New MEAToolBar.MEAToolBar()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTotalTotal = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.fieldGastos = New System.Windows.Forms.GroupBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.DgvConceptoGastos = New System.Windows.Forms.DataGridView()
        Me.clmcmbConceptoGasto = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.clmtxtIva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmtxtImporteGasto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmRenglon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Retencion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.proveedor = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtIVA = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.TxtFolio = New System.Windows.Forms.TextBox()
        Me.txtNoFactura = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtHorasViaje = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.CmbLugarCompra = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmbComprador = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmbProveedor = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.gb2dapesada = New System.Windows.Forms.GroupBox()
        Me.txtKilos2daPasada = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKilosRecibidos = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLeerPeso = New wclTextBoxSerial.TextBoxSerial()
        Me.chkBascula = New System.Windows.Forms.CheckBox()
        Me.txtCabezasHembra = New IntegraLab.Controles.TextBoxMejorado()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.txtCabezasMachos = New IntegraLab.Controles.TextBoxMejorado()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CmbTipoGanado = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtKilos1erpasada = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ChkMultiples = New System.Windows.Forms.CheckBox()
        Me.chkMaquila = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPlacas = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtConductor = New System.Windows.Forms.TextBox()
        Me.txtUnidad = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbIntroductor = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtKilosEnviados = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCantCabezas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLoteEngorda = New System.Windows.Forms.TextBox()
        Me.LblReferenciaOLote = New System.Windows.Forms.Label()
        Me.dtpFechaRecepcion = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtLoteRecepcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.lblEstatus = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.fieldGastos.SuspendLayout()
        CType(Me.DgvConceptoGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb2dapesada.SuspendLayout()
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
        Me.mtb.MostrarEditar = True
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 791)
        Me.mtb.TabIndex = 48
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(743, 32)
        Me.Label17.TabIndex = 47
        Me.Label17.Text = "Recepción de Animales a Sacrificio o en Pie / Materia Prima"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblEstatus)
        Me.GroupBox1.Controls.Add(Me.txtTotalTotal)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.fieldGastos)
        Me.GroupBox1.Controls.Add(Me.txtImporte)
        Me.GroupBox1.Controls.Add(Me.TxtFolio)
        Me.GroupBox1.Controls.Add(Me.txtNoFactura)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label33)
        Me.GroupBox1.Controls.Add(Me.txtHorasViaje)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.CmbLugarCompra)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.cmbComprador)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.cmbProveedor)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.gb2dapesada)
        Me.GroupBox1.Controls.Add(Me.txtLeerPeso)
        Me.GroupBox1.Controls.Add(Me.chkBascula)
        Me.GroupBox1.Controls.Add(Me.txtCabezasHembra)
        Me.GroupBox1.Controls.Add(Me.txtCabezasMachos)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.CmbTipoGanado)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtKilos1erpasada)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.ChkMultiples)
        Me.GroupBox1.Controls.Add(Me.chkMaquila)
        Me.GroupBox1.Controls.Add(Me.txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtPlacas)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtConductor)
        Me.GroupBox1.Controls.Add(Me.txtUnidad)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmbIntroductor)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtKilosEnviados)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCantCabezas)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtLoteEngorda)
        Me.GroupBox1.Controls.Add(Me.LblReferenciaOLote)
        Me.GroupBox1.Controls.Add(Me.dtpFechaRecepcion)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtLoteRecepcion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(53, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(706, 749)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        '
        'txtTotalTotal
        '
        Me.txtTotalTotal.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtTotalTotal.Enabled = False
        Me.txtTotalTotal.Location = New System.Drawing.Point(54, 715)
        Me.txtTotalTotal.Name = "txtTotalTotal"
        Me.txtTotalTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalTotal.TabIndex = 106
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(12, 718)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(40, 13)
        Me.Label26.TabIndex = 105
        Me.Label26.Text = "Total:"
        '
        'fieldGastos
        '
        Me.fieldGastos.Controls.Add(Me.Label28)
        Me.fieldGastos.Controls.Add(Me.DgvConceptoGastos)
        Me.fieldGastos.Controls.Add(Me.Label24)
        Me.fieldGastos.Controls.Add(Me.txtSubTotal)
        Me.fieldGastos.Controls.Add(Me.Label23)
        Me.fieldGastos.Controls.Add(Me.txtIVA)
        Me.fieldGastos.Controls.Add(Me.Label22)
        Me.fieldGastos.Controls.Add(Me.txtTotal)
        Me.fieldGastos.Location = New System.Drawing.Point(25, 484)
        Me.fieldGastos.Name = "fieldGastos"
        Me.fieldGastos.Size = New System.Drawing.Size(655, 214)
        Me.fieldGastos.TabIndex = 16
        Me.fieldGastos.TabStop = False
        Me.fieldGastos.Text = "Gastos de Transporte"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(7, 187)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(104, 13)
        Me.Label28.TabIndex = 98
        Me.Label28.Text = "<supr> Borrar fila"
        '
        'DgvConceptoGastos
        '
        Me.DgvConceptoGastos.AllowUserToDeleteRows = False
        Me.DgvConceptoGastos.AllowUserToResizeRows = False
        Me.DgvConceptoGastos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvConceptoGastos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvConceptoGastos.BackgroundColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvConceptoGastos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DgvConceptoGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvConceptoGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmcmbConceptoGasto, Me.clmtxtIva, Me.clmtxtImporteGasto, Me.clmRenglon, Me.Retencion, Me.Factura, Me.proveedor})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvConceptoGastos.DefaultCellStyle = DataGridViewCellStyle9
        Me.DgvConceptoGastos.Location = New System.Drawing.Point(6, 18)
        Me.DgvConceptoGastos.MultiSelect = False
        Me.DgvConceptoGastos.Name = "DgvConceptoGastos"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvConceptoGastos.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DgvConceptoGastos.RowHeadersVisible = False
        Me.DgvConceptoGastos.Size = New System.Drawing.Size(643, 115)
        Me.DgvConceptoGastos.TabIndex = 22
        '
        'clmcmbConceptoGasto
        '
        Me.clmcmbConceptoGasto.DataPropertyName = "IdGasto"
        Me.clmcmbConceptoGasto.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.clmcmbConceptoGasto.FillWeight = 35.2329!
        Me.clmcmbConceptoGasto.HeaderText = "Gasto"
        Me.clmcmbConceptoGasto.Name = "clmcmbConceptoGasto"
        Me.clmcmbConceptoGasto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'clmtxtIva
        '
        Me.clmtxtIva.DataPropertyName = "PorcentajeIva"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        Me.clmtxtIva.DefaultCellStyle = DataGridViewCellStyle7
        Me.clmtxtIva.FillWeight = 29.87783!
        Me.clmtxtIva.HeaderText = "Iva %"
        Me.clmtxtIva.Name = "clmtxtIva"
        '
        'clmtxtImporteGasto
        '
        Me.clmtxtImporteGasto.DataPropertyName = "ImporteGasto"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.clmtxtImporteGasto.DefaultCellStyle = DataGridViewCellStyle8
        Me.clmtxtImporteGasto.FillWeight = 36.86112!
        Me.clmtxtImporteGasto.HeaderText = "Importe"
        Me.clmtxtImporteGasto.Name = "clmtxtImporteGasto"
        '
        'clmRenglon
        '
        Me.clmRenglon.DataPropertyName = "Renglon"
        Me.clmRenglon.HeaderText = "Renglon"
        Me.clmRenglon.Name = "clmRenglon"
        Me.clmRenglon.Visible = False
        '
        'Retencion
        '
        Me.Retencion.DataPropertyName = "Retencion"
        Me.Retencion.FillWeight = 43.30653!
        Me.Retencion.HeaderText = "Importe Retencion "
        Me.Retencion.Name = "Retencion"
        '
        'Factura
        '
        Me.Factura.DataPropertyName = "NoFactura"
        Me.Factura.FillWeight = 45.80314!
        Me.Factura.HeaderText = "No. Factura"
        Me.Factura.Name = "Factura"
        '
        'proveedor
        '
        Me.proveedor.DataPropertyName = "CodProveedor"
        Me.proveedor.FillWeight = 45.90142!
        Me.proveedor.HeaderText = "Proveedor"
        Me.proveedor.Name = "proveedor"
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(454, 146)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(34, 13)
        Me.Label24.TabIndex = 14
        Me.Label24.Text = "Total:"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.AcceptsTab = True
        Me.txtSubTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSubTotal.Enabled = False
        Me.txtSubTotal.Location = New System.Drawing.Point(63, 143)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(152, 20)
        Me.txtSubTotal.TabIndex = 9
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(242, 146)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(27, 13)
        Me.Label23.TabIndex = 13
        Me.Label23.Text = "IVA:"
        '
        'txtIVA
        '
        Me.txtIVA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIVA.Enabled = False
        Me.txtIVA.Location = New System.Drawing.Point(271, 142)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.ReadOnly = True
        Me.txtIVA.Size = New System.Drawing.Size(152, 20)
        Me.txtIVA.TabIndex = 10
        Me.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(7, 146)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(56, 13)
        Me.Label22.TabIndex = 12
        Me.Label22.Text = "Sub Total:"
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(488, 142)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(152, 20)
        Me.txtTotal.TabIndex = 11
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(465, 92)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(105, 20)
        Me.txtImporte.TabIndex = 104
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtFolio
        '
        Me.TxtFolio.Enabled = False
        Me.TxtFolio.Location = New System.Drawing.Point(598, 173)
        Me.TxtFolio.Name = "TxtFolio"
        Me.TxtFolio.Size = New System.Drawing.Size(102, 20)
        Me.TxtFolio.TabIndex = 8
        Me.TxtFolio.Text = "No es visible"
        Me.TxtFolio.Visible = False
        '
        'txtNoFactura
        '
        Me.txtNoFactura.Location = New System.Drawing.Point(465, 69)
        Me.txtNoFactura.Name = "txtNoFactura"
        Me.txtNoFactura.Size = New System.Drawing.Size(105, 20)
        Me.txtNoFactura.TabIndex = 103
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(563, 176)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(32, 13)
        Me.Label20.TabIndex = 7
        Me.Label20.Text = "Folio:"
        Me.Label20.Visible = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(376, 95)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(45, 13)
        Me.Label25.TabIndex = 102
        Me.Label25.Text = "Importe:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(376, 72)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(89, 13)
        Me.Label33.TabIndex = 101
        Me.Label33.Text = "Num. de Factura:"
        '
        'txtHorasViaje
        '
        Me.txtHorasViaje.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtHorasViaje.Location = New System.Drawing.Point(346, 302)
        Me.txtHorasViaje.Name = "txtHorasViaje"
        Me.txtHorasViaje.Size = New System.Drawing.Size(56, 20)
        Me.txtHorasViaje.TabIndex = 14
        Me.txtHorasViaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(269, 305)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(78, 13)
        Me.Label21.TabIndex = 100
        Me.Label21.Text = "Horas de viaje:"
        '
        'CmbLugarCompra
        '
        Me.CmbLugarCompra.FormattingEnabled = True
        Me.CmbLugarCompra.Location = New System.Drawing.Point(161, 351)
        Me.CmbLugarCompra.Name = "CmbLugarCompra"
        Me.CmbLugarCompra.Size = New System.Drawing.Size(459, 21)
        Me.CmbLugarCompra.TabIndex = 16
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 354)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 13)
        Me.Label16.TabIndex = 98
        Me.Label16.Text = "Lugar de Compra:"
        '
        'cmbComprador
        '
        Me.cmbComprador.DisplayMember = "NomCompleto"
        Me.cmbComprador.FormattingEnabled = True
        Me.cmbComprador.Location = New System.Drawing.Point(161, 376)
        Me.cmbComprador.Name = "cmbComprador"
        Me.cmbComprador.Size = New System.Drawing.Size(459, 21)
        Me.cmbComprador.TabIndex = 17
        Me.cmbComprador.ValueMember = "IdComprador"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(12, 379)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 13)
        Me.Label18.TabIndex = 97
        Me.Label18.Text = "Comprador :"
        '
        'cmbProveedor
        '
        Me.cmbProveedor.DisplayMember = "RazonSocial"
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(161, 326)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(459, 21)
        Me.cmbProveedor.TabIndex = 15
        Me.cmbProveedor.ValueMember = "Codigo"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(12, 329)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(62, 13)
        Me.Label19.TabIndex = 95
        Me.Label19.Text = "Proveedor :"
        '
        'gb2dapesada
        '
        Me.gb2dapesada.Controls.Add(Me.txtKilos2daPasada)
        Me.gb2dapesada.Controls.Add(Me.Label2)
        Me.gb2dapesada.Controls.Add(Me.txtKilosRecibidos)
        Me.gb2dapesada.Controls.Add(Me.Label5)
        Me.gb2dapesada.Location = New System.Drawing.Point(277, 133)
        Me.gb2dapesada.Name = "gb2dapesada"
        Me.gb2dapesada.Size = New System.Drawing.Size(203, 72)
        Me.gb2dapesada.TabIndex = 6
        Me.gb2dapesada.TabStop = False
        Me.gb2dapesada.Text = "Kilos"
        '
        'txtKilos2daPasada
        '
        Me.txtKilos2daPasada.Location = New System.Drawing.Point(102, 40)
        Me.txtKilos2daPasada.Name = "txtKilos2daPasada"
        Me.txtKilos2daPasada.Size = New System.Drawing.Size(96, 20)
        Me.txtKilos2daPasada.TabIndex = 8
        Me.txtKilos2daPasada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "2da Pesada(tara) :"
        '
        'txtKilosRecibidos
        '
        Me.txtKilosRecibidos.Enabled = False
        Me.txtKilosRecibidos.Location = New System.Drawing.Point(101, 12)
        Me.txtKilosRecibidos.Name = "txtKilosRecibidos"
        Me.txtKilosRecibidos.Size = New System.Drawing.Size(96, 20)
        Me.txtKilosRecibidos.TabIndex = 7
        Me.txtKilosRecibidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Recibidos :"
        '
        'txtLeerPeso
        '
        Me.txtLeerPeso.BaudRate = 9600
        Me.txtLeerPeso.DataBit = 8
        Me.txtLeerPeso.Format = wclTextBoxSerial.TextBoxSerial.FormatoDatos.Ascii
        Me.txtLeerPeso.Location = New System.Drawing.Point(28, 431)
        Me.txtLeerPeso.Name = "txtLeerPeso"
        Me.txtLeerPeso.Parity = wclTextBoxSerial.Rs232.DataParity.Parity_None
        Me.txtLeerPeso.Port = 1
        Me.txtLeerPeso.Size = New System.Drawing.Size(67, 20)
        Me.txtLeerPeso.StopBit = wclTextBoxSerial.Rs232.DataStopBit.StopBit_1
        Me.txtLeerPeso.TabIndex = 91
        Me.txtLeerPeso.TimeOut = 1500
        Me.txtLeerPeso.TimeToWaitForMoreData = 300
        Me.txtLeerPeso.Visible = False
        '
        'chkBascula
        '
        Me.chkBascula.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkBascula.Location = New System.Drawing.Point(278, 62)
        Me.chkBascula.Name = "chkBascula"
        Me.chkBascula.Size = New System.Drawing.Size(76, 72)
        Me.chkBascula.TabIndex = 90
        Me.chkBascula.Text = "Lectura de Bascula Desactivada"
        Me.chkBascula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkBascula.UseVisualStyleBackColor = True
        '
        'txtCabezasHembra
        '
        Me.txtCabezasHembra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCabezasHembra.ComboBoxEnlazado = Nothing
        Me.txtCabezasHembra.Decimales = 0
        Me.txtCabezasHembra.Location = New System.Drawing.Point(161, 116)
        Me.txtCabezasHembra.MaxLength = 3000
        Me.txtCabezasHembra.MensajeCombo = "Seleccionar un item..."
        Me.txtCabezasHembra.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtCabezasHembra.Name = "txtCabezasHembra"
        Me.txtCabezasHembra.SiguienteControl = Me.txtObservaciones
        Me.txtCabezasHembra.Size = New System.Drawing.Size(72, 20)
        Me.txtCabezasHembra.TabIndex = 2
        Me.txtCabezasHembra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCabezasHembra.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtCabezasHembra.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCabezasHembra.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Location = New System.Drawing.Point(161, 402)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(459, 61)
        Me.txtObservaciones.TabIndex = 18
        '
        'txtCabezasMachos
        '
        Me.txtCabezasMachos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCabezasMachos.ComboBoxEnlazado = Nothing
        Me.txtCabezasMachos.Decimales = 0
        Me.txtCabezasMachos.Location = New System.Drawing.Point(161, 92)
        Me.txtCabezasMachos.MaxLength = 3000
        Me.txtCabezasMachos.MensajeCombo = "Seleccionar un item..."
        Me.txtCabezasMachos.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtCabezasMachos.Name = "txtCabezasMachos"
        Me.txtCabezasMachos.SiguienteControl = Me.txtObservaciones
        Me.txtCabezasMachos.Size = New System.Drawing.Size(72, 20)
        Me.txtCabezasMachos.TabIndex = 1
        Me.txtCabezasMachos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCabezasMachos.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtCabezasMachos.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCabezasMachos.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 119)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(109, 13)
        Me.Label15.TabIndex = 87
        Me.Label15.Text = "No. de Cab Hembras:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 95)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(148, 13)
        Me.Label14.TabIndex = 86
        Me.Label14.Text = "No. de Cab Machos/Combos:"
        '
        'CmbTipoGanado
        '
        Me.CmbTipoGanado.FormattingEnabled = True
        Me.CmbTipoGanado.Location = New System.Drawing.Point(161, 208)
        Me.CmbTipoGanado.Name = "CmbTipoGanado"
        Me.CmbTipoGanado.Size = New System.Drawing.Size(459, 21)
        Me.CmbTipoGanado.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 211)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(143, 13)
        Me.Label13.TabIndex = 84
        Me.Label13.Text = "Tipo Ganado/Materia prima :"
        '
        'txtKilos1erpasada
        '
        Me.txtKilos1erpasada.Location = New System.Drawing.Point(161, 185)
        Me.txtKilos1erpasada.Name = "txtKilos1erpasada"
        Me.txtKilos1erpasada.Size = New System.Drawing.Size(102, 20)
        Me.txtKilos1erpasada.TabIndex = 5
        Me.txtKilos1erpasada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 188)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 13)
        Me.Label12.TabIndex = 79
        Me.Label12.Text = "Kilos 1er Pesada :"
        '
        'ChkMultiples
        '
        Me.ChkMultiples.AutoSize = True
        Me.ChkMultiples.Location = New System.Drawing.Point(343, 45)
        Me.ChkMultiples.Name = "ChkMultiples"
        Me.ChkMultiples.Size = New System.Drawing.Size(132, 17)
        Me.ChkMultiples.TabIndex = 24
        Me.ChkMultiples.Text = "Múltiples Introductores"
        Me.ChkMultiples.UseVisualStyleBackColor = True
        '
        'chkMaquila
        '
        Me.chkMaquila.AutoSize = True
        Me.chkMaquila.Location = New System.Drawing.Point(277, 45)
        Me.chkMaquila.Name = "chkMaquila"
        Me.chkMaquila.Size = New System.Drawing.Size(63, 17)
        Me.chkMaquila.TabIndex = 23
        Me.chkMaquila.Text = "Maquila"
        Me.chkMaquila.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 402)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 13)
        Me.Label11.TabIndex = 73
        Me.Label11.Text = "Observaciones :"
        '
        'txtPlacas
        '
        Me.txtPlacas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlacas.Location = New System.Drawing.Point(161, 302)
        Me.txtPlacas.Name = "txtPlacas"
        Me.txtPlacas.Size = New System.Drawing.Size(102, 20)
        Me.txtPlacas.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 305)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "Placas :"
        '
        'txtConductor
        '
        Me.txtConductor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConductor.Location = New System.Drawing.Point(161, 279)
        Me.txtConductor.Name = "txtConductor"
        Me.txtConductor.Size = New System.Drawing.Size(459, 20)
        Me.txtConductor.TabIndex = 12
        '
        'txtUnidad
        '
        Me.txtUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUnidad.Location = New System.Drawing.Point(161, 256)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(459, 20)
        Me.txtUnidad.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 282)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Conductor :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 259)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Unidad :"
        '
        'cmbIntroductor
        '
        Me.cmbIntroductor.FormattingEnabled = True
        Me.cmbIntroductor.Location = New System.Drawing.Point(161, 232)
        Me.cmbIntroductor.Name = "cmbIntroductor"
        Me.cmbIntroductor.Size = New System.Drawing.Size(459, 21)
        Me.cmbIntroductor.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Introductor/Cliente :"
        '
        'txtKilosEnviados
        '
        Me.txtKilosEnviados.Location = New System.Drawing.Point(161, 162)
        Me.txtKilosEnviados.Name = "txtKilosEnviados"
        Me.txtKilosEnviados.Size = New System.Drawing.Size(102, 20)
        Me.txtKilosEnviados.TabIndex = 4
        Me.txtKilosEnviados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Kilos Enviados :"
        '
        'txtCantCabezas
        '
        Me.txtCantCabezas.Enabled = False
        Me.txtCantCabezas.Location = New System.Drawing.Point(161, 139)
        Me.txtCantCabezas.Name = "txtCantCabezas"
        Me.txtCantCabezas.Size = New System.Drawing.Size(102, 20)
        Me.txtCantCabezas.TabIndex = 3
        Me.txtCantCabezas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 13)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "No. Total de Cab/Combos :"
        '
        'txtLoteEngorda
        '
        Me.txtLoteEngorda.Location = New System.Drawing.Point(161, 69)
        Me.txtLoteEngorda.Name = "txtLoteEngorda"
        Me.txtLoteEngorda.Size = New System.Drawing.Size(102, 20)
        Me.txtLoteEngorda.TabIndex = 0
        Me.txtLoteEngorda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LblReferenciaOLote
        '
        Me.LblReferenciaOLote.AutoSize = True
        Me.LblReferenciaOLote.Location = New System.Drawing.Point(12, 72)
        Me.LblReferenciaOLote.Name = "LblReferenciaOLote"
        Me.LblReferenciaOLote.Size = New System.Drawing.Size(144, 13)
        Me.LblReferenciaOLote.TabIndex = 56
        Me.LblReferenciaOLote.Text = "Lote de Engorda/embarque :"
        '
        'dtpFechaRecepcion
        '
        Me.dtpFechaRecepcion.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFechaRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaRecepcion.Location = New System.Drawing.Point(397, 12)
        Me.dtpFechaRecepcion.Name = "dtpFechaRecepcion"
        Me.dtpFechaRecepcion.Size = New System.Drawing.Size(92, 20)
        Me.dtpFechaRecepcion.TabIndex = 55
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(284, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 13)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Fecha de Recepción:"
        '
        'txtLoteRecepcion
        '
        Me.txtLoteRecepcion.Location = New System.Drawing.Point(161, 46)
        Me.txtLoteRecepcion.MaxLength = 10
        Me.txtLoteRecepcion.Name = "txtLoteRecepcion"
        Me.txtLoteRecepcion.Size = New System.Drawing.Size(102, 20)
        Me.txtLoteRecepcion.TabIndex = 32
        Me.txtLoteRecepcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Folio interno :"
        '
        'lblEstatus
        '
        Me.lblEstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(552, 16)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(122, 21)
        Me.lblEstatus.TabIndex = 107
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmRecepciondeGanado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 791)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmRecepciondeGanado"
        Me.Text = "Recepción de Animales a Sacrificio o en Pie / Materia Prima"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.fieldGastos.ResumeLayout(False)
        Me.fieldGastos.PerformLayout()
        CType(Me.DgvConceptoGastos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb2dapesada.ResumeLayout(False)
        Me.gb2dapesada.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLoteRecepcion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaRecepcion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCantCabezas As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLoteEngorda As System.Windows.Forms.TextBox
    Friend WithEvents LblReferenciaOLote As System.Windows.Forms.Label
    Friend WithEvents txtKilosEnviados As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtConductor As System.Windows.Forms.TextBox
    Friend WithEvents txtUnidad As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbIntroductor As System.Windows.Forms.ComboBox
    Friend WithEvents txtPlacas As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents chkMaquila As System.Windows.Forms.CheckBox
    Friend WithEvents ChkMultiples As System.Windows.Forms.CheckBox
    Friend WithEvents SerialPort As System.IO.Ports.SerialPort
    Friend WithEvents txtKilos1erpasada As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CmbTipoGanado As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtCabezasHembra As Integralab.Controles.TextBoxMejorado
    Friend WithEvents txtCabezasMachos As Integralab.Controles.TextBoxMejorado
    Friend WithEvents chkBascula As System.Windows.Forms.CheckBox
    Friend WithEvents txtLeerPeso As wclTextBoxSerial.TextBoxSerial
    Friend WithEvents gb2dapesada As System.Windows.Forms.GroupBox
    Friend WithEvents txtKilos2daPasada As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtKilosRecibidos As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CmbLugarCompra As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmbComprador As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cmbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TxtFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents fieldGastos As System.Windows.Forms.GroupBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtIVA As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents DgvConceptoGastos As System.Windows.Forms.DataGridView
    Friend WithEvents txtHorasViaje As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents txtNoFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtTotalTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents clmcmbConceptoGasto As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents clmtxtIva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmtxtImporteGasto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmRenglon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Retencion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Factura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents proveedor As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
End Class
