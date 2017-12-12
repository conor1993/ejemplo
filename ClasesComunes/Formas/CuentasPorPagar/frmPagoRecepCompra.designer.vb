<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagoRecepCompra
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblImporte = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbProveedor = New System.Windows.Forms.ComboBox()
        Me.dgvRecepComp = New System.Windows.Forms.DataGridView()
        Me.Pagar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.clmIdRecepCom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFolioNRR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmNoFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFechaRecep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmIva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmieps = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDetalle = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.clmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCheTrans = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.label15 = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblIva = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblIeps = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbBancos = New System.Windows.Forms.ComboBox()
        Me.rbCheque = New System.Windows.Forms.RadioButton()
        Me.rbTrans = New System.Windows.Forms.RadioButton()
        Me.rbEfect = New System.Windows.Forms.RadioButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbCuenta = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtNumCheque = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtReferencia = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmbBancosR = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtCuentaRecep = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkSinFacturar = New System.Windows.Forms.CheckBox()
        Me.gbFacturar = New System.Windows.Forms.GroupBox()
        Me.lblFactura = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MtxtUUID = New System.Windows.Forms.MaskedTextBox()
        Me.txtNumRemision = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DtpFechaFac = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFactura = New System.Windows.Forms.TextBox()
        Me.chkPagada = New System.Windows.Forms.CheckBox()
        Me.lblTotalConcepto = New System.Windows.Forms.Label()
        Me.chkSPagar = New System.Windows.Forms.CheckBox()
        Me.lblTotalDocTexto = New System.Windows.Forms.Label()
        Me.chkFacturada = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gbFacturadas = New System.Windows.Forms.GroupBox()
        Me.rbPagadas = New System.Windows.Forms.RadioButton()
        Me.rbSinPagar = New System.Windows.Forms.RadioButton()
        Me.rbSinDocto = New System.Windows.Forms.RadioButton()
        Me.rbNotaRem = New System.Windows.Forms.RadioButton()
        Me.rbFactura = New System.Windows.Forms.RadioButton()
        Me.GBPrincipal = New System.Windows.Forms.GroupBox()
        Me.chkFormaPago = New System.Windows.Forms.CheckBox()
        Me.gbFormaPago = New System.Windows.Forms.GroupBox()
        Me.lblIepsFact = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblIvaFact = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblSubTotalFact = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblTotalFact = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.dgvFacturas = New System.Windows.Forms.DataGridView()
        Me.btnAgregarFact = New System.Windows.Forms.Button()
        Me.mtb = New MEAToolBar.MEAToolBar()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dgvRecepComp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.gbFacturar.SuspendLayout()
        Me.gbFacturadas.SuspendLayout()
        Me.GBPrincipal.SuspendLayout()
        Me.gbFormaPago.SuspendLayout()
        CType(Me.dgvFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(53, 0)
        Me.Label1.MaximumSize = New System.Drawing.Size(1100, 800)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(877, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Recepcion y Pago de Facturas/Recepciones"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(632, 329)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Total:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(624, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Fecha:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFecha
        '
        Me.lblFecha.BackColor = System.Drawing.SystemColors.Menu
        Me.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFecha.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(671, 22)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(180, 21)
        Me.lblFecha.TabIndex = 0
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblImporte
        '
        Me.lblImporte.BackColor = System.Drawing.SystemColors.Window
        Me.lblImporte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblImporte.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImporte.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblImporte.Location = New System.Drawing.Point(686, 327)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(127, 20)
        Me.lblImporte.TabIndex = 0
        Me.lblImporte.Text = "$0.0"
        Me.lblImporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 16)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Proveedor:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbProveedor
        '
        Me.cmbProveedor.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(81, 19)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(378, 24)
        Me.cmbProveedor.TabIndex = 1
        '
        'dgvRecepComp
        '
        Me.dgvRecepComp.AllowUserToAddRows = False
        Me.dgvRecepComp.AllowUserToDeleteRows = False
        Me.dgvRecepComp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRecepComp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvRecepComp.ColumnHeadersHeight = 40
        Me.dgvRecepComp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvRecepComp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Pagar, Me.clmIdRecepCom, Me.clmFolioNRR, Me.clmNoFactura, Me.clmFechaRecep, Me.clmSubtotal, Me.clmIva, Me.clmieps, Me.clmTotal, Me.clmDetalle, Me.clmEstatus, Me.clmCheTrans})
        Me.dgvRecepComp.Location = New System.Drawing.Point(8, 70)
        Me.dgvRecepComp.Name = "dgvRecepComp"
        Me.dgvRecepComp.RowHeadersVisible = False
        Me.dgvRecepComp.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvRecepComp.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvRecepComp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRecepComp.Size = New System.Drawing.Size(827, 166)
        Me.dgvRecepComp.TabIndex = 2
        '
        'Pagar
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.NullValue = False
        Me.Pagar.DefaultCellStyle = DataGridViewCellStyle1
        Me.Pagar.FillWeight = 15.0!
        Me.Pagar.HeaderText = ""
        Me.Pagar.Name = "Pagar"
        '
        'clmIdRecepCom
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.clmIdRecepCom.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmIdRecepCom.FillWeight = 25.0!
        Me.clmIdRecepCom.HeaderText = "Id"
        Me.clmIdRecepCom.Name = "clmIdRecepCom"
        Me.clmIdRecepCom.ReadOnly = True
        Me.clmIdRecepCom.Visible = False
        '
        'clmFolioNRR
        '
        Me.clmFolioNRR.FillWeight = 40.0!
        Me.clmFolioNRR.HeaderText = "Folio"
        Me.clmFolioNRR.Name = "clmFolioNRR"
        Me.clmFolioNRR.ReadOnly = True
        '
        'clmNoFactura
        '
        Me.clmNoFactura.FillWeight = 40.0!
        Me.clmNoFactura.HeaderText = "No.Fact"
        Me.clmNoFactura.Name = "clmNoFactura"
        '
        'clmFechaRecep
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.Format = "dd/MM/yyyy"
        Me.clmFechaRecep.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmFechaRecep.FillWeight = 35.0!
        Me.clmFechaRecep.HeaderText = "Fecha Recep."
        Me.clmFechaRecep.Name = "clmFechaRecep"
        Me.clmFechaRecep.ReadOnly = True
        '
        'clmSubtotal
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.clmSubtotal.DefaultCellStyle = DataGridViewCellStyle4
        Me.clmSubtotal.FillWeight = 50.0!
        Me.clmSubtotal.HeaderText = "SubTotal"
        Me.clmSubtotal.Name = "clmSubtotal"
        Me.clmSubtotal.ReadOnly = True
        '
        'clmIva
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.clmIva.DefaultCellStyle = DataGridViewCellStyle5
        Me.clmIva.FillWeight = 50.0!
        Me.clmIva.HeaderText = "IVA"
        Me.clmIva.Name = "clmIva"
        Me.clmIva.ReadOnly = True
        '
        'clmieps
        '
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.clmieps.DefaultCellStyle = DataGridViewCellStyle6
        Me.clmieps.FillWeight = 50.0!
        Me.clmieps.HeaderText = "IEPS"
        Me.clmieps.Name = "clmieps"
        Me.clmieps.ReadOnly = True
        '
        'clmTotal
        '
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.clmTotal.DefaultCellStyle = DataGridViewCellStyle7
        Me.clmTotal.FillWeight = 50.0!
        Me.clmTotal.HeaderText = "Total"
        Me.clmTotal.Name = "clmTotal"
        Me.clmTotal.ReadOnly = True
        '
        'clmDetalle
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.clmDetalle.DefaultCellStyle = DataGridViewCellStyle8
        Me.clmDetalle.FillWeight = 20.0!
        Me.clmDetalle.HeaderText = "Detalle"
        Me.clmDetalle.Name = "clmDetalle"
        Me.clmDetalle.Text = "..."
        Me.clmDetalle.ToolTipText = "Ver detalle de la recepcion"
        '
        'clmEstatus
        '
        Me.clmEstatus.FillWeight = 40.0!
        Me.clmEstatus.HeaderText = "Estatus"
        Me.clmEstatus.Name = "clmEstatus"
        Me.clmEstatus.ReadOnly = True
        '
        'clmCheTrans
        '
        Me.clmCheTrans.FillWeight = 40.0!
        Me.clmCheTrans.HeaderText = "Cheque/Trans"
        Me.clmCheTrans.Name = "clmCheTrans"
        Me.clmCheTrans.ReadOnly = True
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label15.ForeColor = System.Drawing.SystemColors.Desktop
        Me.label15.Location = New System.Drawing.Point(608, 254)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(53, 16)
        Me.label15.TabIndex = 0
        Me.label15.Text = "SubTotal:"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BackColor = System.Drawing.SystemColors.Window
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubtotal.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblSubtotal.Location = New System.Drawing.Point(686, 251)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(127, 20)
        Me.lblSubtotal.TabIndex = 0
        Me.lblSubtotal.Text = "$0.0"
        Me.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label12.Location = New System.Drawing.Point(632, 278)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "IVA:"
        '
        'lblIva
        '
        Me.lblIva.BackColor = System.Drawing.SystemColors.Window
        Me.lblIva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIva.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIva.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblIva.Location = New System.Drawing.Point(686, 276)
        Me.lblIva.Name = "lblIva"
        Me.lblIva.Size = New System.Drawing.Size(127, 20)
        Me.lblIva.TabIndex = 0
        Me.lblIva.Text = "$0.0"
        Me.lblIva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label11.Location = New System.Drawing.Point(633, 303)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "IEPS:"
        '
        'lblIeps
        '
        Me.lblIeps.BackColor = System.Drawing.SystemColors.Window
        Me.lblIeps.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIeps.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIeps.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblIeps.Location = New System.Drawing.Point(686, 301)
        Me.lblIeps.Name = "lblIeps"
        Me.lblIeps.Size = New System.Drawing.Size(127, 20)
        Me.lblIeps.TabIndex = 0
        Me.lblIeps.Text = "$0.0"
        Me.lblIeps.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label13.Location = New System.Drawing.Point(394, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 16)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "Banco:"
        '
        'cmbBancos
        '
        Me.cmbBancos.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBancos.FormattingEnabled = True
        Me.cmbBancos.ItemHeight = 16
        Me.cmbBancos.Location = New System.Drawing.Point(472, 65)
        Me.cmbBancos.Name = "cmbBancos"
        Me.cmbBancos.Size = New System.Drawing.Size(239, 24)
        Me.cmbBancos.TabIndex = 13
        '
        'rbCheque
        '
        Me.rbCheque.AutoSize = True
        Me.rbCheque.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCheque.ForeColor = System.Drawing.SystemColors.Desktop
        Me.rbCheque.Location = New System.Drawing.Point(57, 27)
        Me.rbCheque.Name = "rbCheque"
        Me.rbCheque.Size = New System.Drawing.Size(64, 20)
        Me.rbCheque.TabIndex = 10
        Me.rbCheque.TabStop = True
        Me.rbCheque.Text = "Cheque"
        Me.rbCheque.UseVisualStyleBackColor = True
        '
        'rbTrans
        '
        Me.rbTrans.AutoSize = True
        Me.rbTrans.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTrans.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rbTrans.Location = New System.Drawing.Point(229, 27)
        Me.rbTrans.Name = "rbTrans"
        Me.rbTrans.Size = New System.Drawing.Size(91, 20)
        Me.rbTrans.TabIndex = 11
        Me.rbTrans.TabStop = True
        Me.rbTrans.Text = "Transferencia"
        Me.rbTrans.UseVisualStyleBackColor = True
        '
        'rbEfect
        '
        Me.rbEfect.AutoSize = True
        Me.rbEfect.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEfect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rbEfect.Location = New System.Drawing.Point(425, 27)
        Me.rbEfect.Name = "rbEfect"
        Me.rbEfect.Size = New System.Drawing.Size(62, 20)
        Me.rbEfect.TabIndex = 12
        Me.rbEfect.TabStop = True
        Me.rbEfect.Text = "Efectivo"
        Me.rbEfect.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(51, 65)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 16)
        Me.Label14.TabIndex = 53
        Me.Label14.Text = "Cuenta:"
        '
        'cmbCuenta
        '
        Me.cmbCuenta.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCuenta.FormattingEnabled = True
        Me.cmbCuenta.ItemHeight = 16
        Me.cmbCuenta.Location = New System.Drawing.Point(124, 62)
        Me.cmbCuenta.Name = "cmbCuenta"
        Me.cmbCuenta.Size = New System.Drawing.Size(226, 24)
        Me.cmbCuenta.TabIndex = 14
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label16.Location = New System.Drawing.Point(19, 102)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 16)
        Me.Label16.TabIndex = 55
        Me.Label16.Text = "Num. Cheque:"
        '
        'txtNumCheque
        '
        Me.txtNumCheque.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumCheque.Location = New System.Drawing.Point(125, 99)
        Me.txtNumCheque.Name = "txtNumCheque"
        Me.txtNumCheque.Size = New System.Drawing.Size(141, 22)
        Me.txtNumCheque.TabIndex = 15
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(376, 102)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 16)
        Me.Label17.TabIndex = 57
        Me.Label17.Text = "Referencia:"
        '
        'txtReferencia
        '
        Me.txtReferencia.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferencia.Location = New System.Drawing.Point(472, 99)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(239, 22)
        Me.txtReferencia.TabIndex = 16
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label19.Location = New System.Drawing.Point(9, 134)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(87, 16)
        Me.Label19.TabIndex = 60
        Me.Label19.Text = "Banco Receptor:"
        '
        'cmbBancosR
        '
        Me.cmbBancosR.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBancosR.FormattingEnabled = True
        Me.cmbBancosR.Location = New System.Drawing.Point(124, 131)
        Me.cmbBancosR.Name = "cmbBancosR"
        Me.cmbBancosR.Size = New System.Drawing.Size(226, 24)
        Me.cmbBancosR.TabIndex = 17
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(356, 134)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(79, 16)
        Me.Label20.TabIndex = 62
        Me.Label20.Text = "Cuenta Recep:"
        '
        'txtCuentaRecep
        '
        Me.txtCuentaRecep.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaRecep.Location = New System.Drawing.Point(472, 131)
        Me.txtCuentaRecep.Name = "txtCuentaRecep"
        Me.txtCuentaRecep.Size = New System.Drawing.Size(241, 22)
        Me.txtCuentaRecep.TabIndex = 18
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkSinFacturar)
        Me.GroupBox2.Controls.Add(Me.dgvRecepComp)
        Me.GroupBox2.Controls.Add(Me.gbFacturar)
        Me.GroupBox2.Controls.Add(Me.chkPagada)
        Me.GroupBox2.Controls.Add(Me.lblTotalConcepto)
        Me.GroupBox2.Controls.Add(Me.chkSPagar)
        Me.GroupBox2.Controls.Add(Me.lblTotalDocTexto)
        Me.GroupBox2.Controls.Add(Me.chkFacturada)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lblIeps)
        Me.GroupBox2.Controls.Add(Me.label15)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblImporte)
        Me.GroupBox2.Controls.Add(Me.lblSubtotal)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.lblIva)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox2.Location = New System.Drawing.Point(16, 49)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(841, 359)
        Me.GroupBox2.TabIndex = 64
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Documento a pagar"
        '
        'chkSinFacturar
        '
        Me.chkSinFacturar.AutoSize = True
        Me.chkSinFacturar.ForeColor = System.Drawing.SystemColors.Desktop
        Me.chkSinFacturar.Location = New System.Drawing.Point(163, 21)
        Me.chkSinFacturar.Name = "chkSinFacturar"
        Me.chkSinFacturar.Size = New System.Drawing.Size(77, 20)
        Me.chkSinFacturar.TabIndex = 82
        Me.chkSinFacturar.Text = "S/Facturar"
        Me.chkSinFacturar.UseVisualStyleBackColor = True
        '
        'gbFacturar
        '
        Me.gbFacturar.Controls.Add(Me.lblFactura)
        Me.gbFacturar.Controls.Add(Me.Button1)
        Me.gbFacturar.Controls.Add(Me.MtxtUUID)
        Me.gbFacturar.Controls.Add(Me.txtNumRemision)
        Me.gbFacturar.Controls.Add(Me.Label6)
        Me.gbFacturar.Controls.Add(Me.DtpFechaFac)
        Me.gbFacturar.Controls.Add(Me.Label3)
        Me.gbFacturar.Controls.Add(Me.Label4)
        Me.gbFacturar.Controls.Add(Me.txtFactura)
        Me.gbFacturar.Location = New System.Drawing.Point(13, 241)
        Me.gbFacturar.Name = "gbFacturar"
        Me.gbFacturar.Size = New System.Drawing.Size(441, 102)
        Me.gbFacturar.TabIndex = 81
        Me.gbFacturar.TabStop = False
        '
        'lblFactura
        '
        Me.lblFactura.AutoSize = True
        Me.lblFactura.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFactura.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblFactura.Location = New System.Drawing.Point(18, 18)
        Me.lblFactura.Name = "lblFactura"
        Me.lblFactura.Size = New System.Drawing.Size(67, 16)
        Me.lblFactura.TabIndex = 0
        Me.lblFactura.Text = "No. Factura:"
        Me.lblFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(362, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 23)
        Me.Button1.TabIndex = 68
        Me.Button1.Text = "XD"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'MtxtUUID
        '
        Me.MtxtUUID.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MtxtUUID.Location = New System.Drawing.Point(101, 47)
        Me.MtxtUUID.Mask = ">AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA"
        Me.MtxtUUID.Name = "MtxtUUID"
        Me.MtxtUUID.Size = New System.Drawing.Size(248, 22)
        Me.MtxtUUID.TabIndex = 7
        '
        'txtNumRemision
        '
        Me.txtNumRemision.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumRemision.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumRemision.Location = New System.Drawing.Point(102, 106)
        Me.txtNumRemision.Name = "txtNumRemision"
        Me.txtNumRemision.Size = New System.Drawing.Size(247, 22)
        Me.txtNumRemision.TabIndex = 9
        Me.txtNumRemision.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label6.Location = New System.Drawing.Point(47, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "UUID:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DtpFechaFac
        '
        Me.DtpFechaFac.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFechaFac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaFac.Location = New System.Drawing.Point(101, 73)
        Me.DtpFechaFac.Name = "DtpFechaFac"
        Me.DtpFechaFac.Size = New System.Drawing.Size(129, 22)
        Me.DtpFechaFac.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label3.Location = New System.Drawing.Point(11, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "No. Remisión:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label4.Location = New System.Drawing.Point(40, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Fecha:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFactura
        '
        Me.txtFactura.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFactura.Location = New System.Drawing.Point(101, 18)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(248, 22)
        Me.txtFactura.TabIndex = 6
        '
        'chkPagada
        '
        Me.chkPagada.AutoSize = True
        Me.chkPagada.ForeColor = System.Drawing.SystemColors.Desktop
        Me.chkPagada.Location = New System.Drawing.Point(278, 21)
        Me.chkPagada.Name = "chkPagada"
        Me.chkPagada.Size = New System.Drawing.Size(69, 20)
        Me.chkPagada.TabIndex = 71
        Me.chkPagada.Text = "Pagadas"
        Me.chkPagada.UseVisualStyleBackColor = True
        '
        'lblTotalConcepto
        '
        Me.lblTotalConcepto.AutoSize = True
        Me.lblTotalConcepto.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalConcepto.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblTotalConcepto.Location = New System.Drawing.Point(585, 219)
        Me.lblTotalConcepto.Name = "lblTotalConcepto"
        Me.lblTotalConcepto.Size = New System.Drawing.Size(29, 17)
        Me.lblTotalConcepto.TabIndex = 80
        Me.lblTotalConcepto.Text = "0.00"
        Me.lblTotalConcepto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTotalConcepto.Visible = False
        '
        'chkSPagar
        '
        Me.chkSPagar.AutoSize = True
        Me.chkSPagar.ForeColor = System.Drawing.SystemColors.Desktop
        Me.chkSPagar.Location = New System.Drawing.Point(385, 21)
        Me.chkSPagar.Name = "chkSPagar"
        Me.chkSPagar.Size = New System.Drawing.Size(66, 20)
        Me.chkSPagar.TabIndex = 70
        Me.chkSPagar.Text = "S/Pagar"
        Me.chkSPagar.UseVisualStyleBackColor = True
        '
        'lblTotalDocTexto
        '
        Me.lblTotalDocTexto.AutoSize = True
        Me.lblTotalDocTexto.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDocTexto.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblTotalDocTexto.Location = New System.Drawing.Point(459, 219)
        Me.lblTotalDocTexto.Name = "lblTotalDocTexto"
        Me.lblTotalDocTexto.Size = New System.Drawing.Size(35, 17)
        Me.lblTotalDocTexto.TabIndex = 79
        Me.lblTotalDocTexto.Text = "Total"
        Me.lblTotalDocTexto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTotalDocTexto.Visible = False
        '
        'chkFacturada
        '
        Me.chkFacturada.AutoSize = True
        Me.chkFacturada.ForeColor = System.Drawing.SystemColors.Desktop
        Me.chkFacturada.Location = New System.Drawing.Point(47, 21)
        Me.chkFacturada.Name = "chkFacturada"
        Me.chkFacturada.Size = New System.Drawing.Size(80, 20)
        Me.chkFacturada.TabIndex = 69
        Me.chkFacturada.Text = "Facturadas"
        Me.chkFacturada.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 16)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "Recepciones de compra"
        '
        'gbFacturadas
        '
        Me.gbFacturadas.Controls.Add(Me.rbPagadas)
        Me.gbFacturadas.Controls.Add(Me.rbSinPagar)
        Me.gbFacturadas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gbFacturadas.Location = New System.Drawing.Point(931, 218)
        Me.gbFacturadas.Name = "gbFacturadas"
        Me.gbFacturadas.Size = New System.Drawing.Size(160, 35)
        Me.gbFacturadas.TabIndex = 72
        Me.gbFacturadas.TabStop = False
        '
        'rbPagadas
        '
        Me.rbPagadas.AutoSize = True
        Me.rbPagadas.Location = New System.Drawing.Point(81, 13)
        Me.rbPagadas.Name = "rbPagadas"
        Me.rbPagadas.Size = New System.Drawing.Size(63, 19)
        Me.rbPagadas.TabIndex = 82
        Me.rbPagadas.Text = "Pagadas"
        Me.rbPagadas.UseVisualStyleBackColor = True
        '
        'rbSinPagar
        '
        Me.rbSinPagar.AutoSize = True
        Me.rbSinPagar.Checked = True
        Me.rbSinPagar.Location = New System.Drawing.Point(6, 13)
        Me.rbSinPagar.Name = "rbSinPagar"
        Me.rbSinPagar.Size = New System.Drawing.Size(60, 19)
        Me.rbSinPagar.TabIndex = 81
        Me.rbSinPagar.TabStop = True
        Me.rbSinPagar.Text = "S/Pagar"
        Me.rbSinPagar.UseVisualStyleBackColor = True
        '
        'rbSinDocto
        '
        Me.rbSinDocto.AutoSize = True
        Me.rbSinDocto.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSinDocto.ForeColor = System.Drawing.SystemColors.InfoText
        Me.rbSinDocto.Location = New System.Drawing.Point(965, 165)
        Me.rbSinDocto.Name = "rbSinDocto"
        Me.rbSinDocto.Size = New System.Drawing.Size(97, 20)
        Me.rbSinDocto.TabIndex = 5
        Me.rbSinDocto.TabStop = True
        Me.rbSinDocto.Text = "Sin Documento"
        Me.rbSinDocto.UseVisualStyleBackColor = True
        '
        'rbNotaRem
        '
        Me.rbNotaRem.AutoSize = True
        Me.rbNotaRem.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNotaRem.ForeColor = System.Drawing.SystemColors.InfoText
        Me.rbNotaRem.Location = New System.Drawing.Point(965, 131)
        Me.rbNotaRem.Name = "rbNotaRem"
        Me.rbNotaRem.Size = New System.Drawing.Size(109, 20)
        Me.rbNotaRem.TabIndex = 4
        Me.rbNotaRem.TabStop = True
        Me.rbNotaRem.Text = "Nota de Remisión"
        Me.rbNotaRem.UseVisualStyleBackColor = True
        '
        'rbFactura
        '
        Me.rbFactura.AutoSize = True
        Me.rbFactura.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFactura.ForeColor = System.Drawing.SystemColors.InfoText
        Me.rbFactura.Location = New System.Drawing.Point(965, 90)
        Me.rbFactura.Name = "rbFactura"
        Me.rbFactura.Size = New System.Drawing.Size(62, 20)
        Me.rbFactura.TabIndex = 3
        Me.rbFactura.TabStop = True
        Me.rbFactura.Text = "Factura"
        Me.rbFactura.UseVisualStyleBackColor = True
        '
        'GBPrincipal
        '
        Me.GBPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBPrincipal.Controls.Add(Me.GroupBox2)
        Me.GBPrincipal.Controls.Add(Me.gbFacturadas)
        Me.GBPrincipal.Controls.Add(Me.rbSinDocto)
        Me.GBPrincipal.Controls.Add(Me.chkFormaPago)
        Me.GBPrincipal.Controls.Add(Me.rbNotaRem)
        Me.GBPrincipal.Controls.Add(Me.rbFactura)
        Me.GBPrincipal.Controls.Add(Me.cmbProveedor)
        Me.GBPrincipal.Controls.Add(Me.Label10)
        Me.GBPrincipal.Controls.Add(Me.lblFecha)
        Me.GBPrincipal.Controls.Add(Me.Label5)
        Me.GBPrincipal.Controls.Add(Me.gbFormaPago)
        Me.GBPrincipal.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBPrincipal.Location = New System.Drawing.Point(53, 32)
        Me.GBPrincipal.Name = "GBPrincipal"
        Me.GBPrincipal.Size = New System.Drawing.Size(865, 621)
        Me.GBPrincipal.TabIndex = 1
        Me.GBPrincipal.TabStop = False
        '
        'chkFormaPago
        '
        Me.chkFormaPago.AutoSize = True
        Me.chkFormaPago.Location = New System.Drawing.Point(18, 441)
        Me.chkFormaPago.Name = "chkFormaPago"
        Me.chkFormaPago.Size = New System.Drawing.Size(15, 14)
        Me.chkFormaPago.TabIndex = 77
        Me.chkFormaPago.UseVisualStyleBackColor = True
        Me.chkFormaPago.Visible = False
        '
        'gbFormaPago
        '
        Me.gbFormaPago.Controls.Add(Me.rbTrans)
        Me.gbFormaPago.Controls.Add(Me.txtCuentaRecep)
        Me.gbFormaPago.Controls.Add(Me.Label14)
        Me.gbFormaPago.Controls.Add(Me.cmbCuenta)
        Me.gbFormaPago.Controls.Add(Me.Label20)
        Me.gbFormaPago.Controls.Add(Me.rbEfect)
        Me.gbFormaPago.Controls.Add(Me.Label16)
        Me.gbFormaPago.Controls.Add(Me.cmbBancosR)
        Me.gbFormaPago.Controls.Add(Me.rbCheque)
        Me.gbFormaPago.Controls.Add(Me.txtNumCheque)
        Me.gbFormaPago.Controls.Add(Me.Label19)
        Me.gbFormaPago.Controls.Add(Me.cmbBancos)
        Me.gbFormaPago.Controls.Add(Me.Label17)
        Me.gbFormaPago.Controls.Add(Me.txtReferencia)
        Me.gbFormaPago.Controls.Add(Me.Label13)
        Me.gbFormaPago.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFormaPago.ForeColor = System.Drawing.SystemColors.Desktop
        Me.gbFormaPago.Location = New System.Drawing.Point(24, 443)
        Me.gbFormaPago.Name = "gbFormaPago"
        Me.gbFormaPago.Size = New System.Drawing.Size(724, 167)
        Me.gbFormaPago.TabIndex = 65
        Me.gbFormaPago.TabStop = False
        Me.gbFormaPago.Text = "Forma de pago"
        '
        'lblIepsFact
        '
        Me.lblIepsFact.BackColor = System.Drawing.SystemColors.Window
        Me.lblIepsFact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIepsFact.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIepsFact.Location = New System.Drawing.Point(783, 822)
        Me.lblIepsFact.Name = "lblIepsFact"
        Me.lblIepsFact.Size = New System.Drawing.Size(127, 20)
        Me.lblIepsFact.TabIndex = 73
        Me.lblIepsFact.Text = "$0.0"
        Me.lblIepsFact.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblIepsFact.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(730, 824)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 16)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "IEPS:"
        Me.Label8.Visible = False
        '
        'lblIvaFact
        '
        Me.lblIvaFact.BackColor = System.Drawing.SystemColors.Window
        Me.lblIvaFact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIvaFact.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIvaFact.Location = New System.Drawing.Point(783, 792)
        Me.lblIvaFact.Name = "lblIvaFact"
        Me.lblIvaFact.Size = New System.Drawing.Size(127, 20)
        Me.lblIvaFact.TabIndex = 75
        Me.lblIvaFact.Text = "$0.0"
        Me.lblIvaFact.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblIvaFact.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(729, 794)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(28, 16)
        Me.Label21.TabIndex = 74
        Me.Label21.Text = "IVA:"
        Me.Label21.Visible = False
        '
        'lblSubTotalFact
        '
        Me.lblSubTotalFact.BackColor = System.Drawing.SystemColors.Window
        Me.lblSubTotalFact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubTotalFact.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotalFact.Location = New System.Drawing.Point(783, 762)
        Me.lblSubTotalFact.Name = "lblSubTotalFact"
        Me.lblSubTotalFact.Size = New System.Drawing.Size(127, 20)
        Me.lblSubTotalFact.TabIndex = 69
        Me.lblSubTotalFact.Text = "$0.0"
        Me.lblSubTotalFact.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblSubTotalFact.Visible = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(705, 765)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(53, 16)
        Me.Label23.TabIndex = 68
        Me.Label23.Text = "SubTotal:"
        Me.Label23.Visible = False
        '
        'lblTotalFact
        '
        Me.lblTotalFact.BackColor = System.Drawing.SystemColors.Window
        Me.lblTotalFact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalFact.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalFact.Location = New System.Drawing.Point(783, 853)
        Me.lblTotalFact.Name = "lblTotalFact"
        Me.lblTotalFact.Size = New System.Drawing.Size(127, 20)
        Me.lblTotalFact.TabIndex = 71
        Me.lblTotalFact.Text = "$0.0"
        Me.lblTotalFact.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTotalFact.Visible = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(729, 855)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(34, 16)
        Me.Label25.TabIndex = 70
        Me.Label25.Text = "Total:"
        Me.Label25.Visible = False
        '
        'dgvFacturas
        '
        Me.dgvFacturas.AllowUserToAddRows = False
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFacturas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFacturas.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvFacturas.Location = New System.Drawing.Point(58, 765)
        Me.dgvFacturas.Name = "dgvFacturas"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFacturas.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvFacturas.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvFacturas.Size = New System.Drawing.Size(644, 105)
        Me.dgvFacturas.TabIndex = 67
        Me.dgvFacturas.Visible = False
        '
        'btnAgregarFact
        '
        Me.btnAgregarFact.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarFact.Location = New System.Drawing.Point(385, 660)
        Me.btnAgregarFact.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregarFact.Name = "btnAgregarFact"
        Me.btnAgregarFact.Size = New System.Drawing.Size(45, 24)
        Me.btnAgregarFact.TabIndex = 66
        Me.btnAgregarFact.Text = "V"
        Me.btnAgregarFact.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregarFact.UseVisualStyleBackColor = True
        Me.btnAgregarFact.Visible = False
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
        Me.mtb.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.mtb.MostrarBorrar = False
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = False
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 665)
        Me.mtb.TabIndex = 21
        '
        'timer1
        '
        Me.timer1.Enabled = True
        Me.timer1.Interval = 1
        '
        'frmPagoRecepCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 665)
        Me.Controls.Add(Me.GBPrincipal)
        Me.Controls.Add(Me.btnAgregarFact)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblIepsFact)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblIvaFact)
        Me.Controls.Add(Me.dgvFacturas)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.lblSubTotalFact)
        Me.Controls.Add(Me.lblTotalFact)
        Me.Controls.Add(Me.Label23)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPagoRecepCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recepcion y Pago de Facturas/Recepciones"
        CType(Me.dgvRecepComp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbFacturar.ResumeLayout(False)
        Me.gbFacturar.PerformLayout()
        Me.gbFacturadas.ResumeLayout(False)
        Me.gbFacturadas.PerformLayout()
        Me.GBPrincipal.ResumeLayout(False)
        Me.GBPrincipal.PerformLayout()
        Me.gbFormaPago.ResumeLayout(False)
        Me.gbFormaPago.PerformLayout()
        CType(Me.dgvFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblImporte As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents dgvRecepComp As System.Windows.Forms.DataGridView
    Friend WithEvents label15 As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblIva As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblIeps As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbBancos As System.Windows.Forms.ComboBox
    Friend WithEvents rbCheque As System.Windows.Forms.RadioButton
    Friend WithEvents rbTrans As System.Windows.Forms.RadioButton
    Friend WithEvents rbEfect As System.Windows.Forms.RadioButton
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtNumCheque As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtReferencia As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmbBancosR As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtCuentaRecep As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbSinDocto As System.Windows.Forms.RadioButton
    Friend WithEvents txtFactura As System.Windows.Forms.TextBox
    Friend WithEvents lblFactura As System.Windows.Forms.Label
    Friend WithEvents rbNotaRem As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DtpFechaFac As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbFactura As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MtxtUUID As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GBPrincipal As System.Windows.Forms.GroupBox
    Friend WithEvents gbFormaPago As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNumRemision As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregarFact As System.Windows.Forms.Button
    Friend WithEvents dgvFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents lblIepsFact As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblIvaFact As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lblSubTotalFact As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lblTotalFact As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label

    Friend WithEvents timer1 As System.Windows.Forms.Timer
    Friend WithEvents chkFormaPago As System.Windows.Forms.CheckBox

    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblTotalConcepto As System.Windows.Forms.Label
    Friend WithEvents lblTotalDocTexto As System.Windows.Forms.Label
    Friend WithEvents chkPagada As System.Windows.Forms.CheckBox
    Friend WithEvents chkSPagar As System.Windows.Forms.CheckBox
    Friend WithEvents chkFacturada As System.Windows.Forms.CheckBox
    Friend WithEvents gbFacturadas As System.Windows.Forms.GroupBox
    Friend WithEvents rbPagadas As System.Windows.Forms.RadioButton
    Friend WithEvents rbSinPagar As System.Windows.Forms.RadioButton
    Friend WithEvents Pagar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents clmIdRecepCom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFolioNRR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmNoFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaRecep As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSubtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmieps As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDetalle As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents clmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCheTrans As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gbFacturar As System.Windows.Forms.GroupBox
    Friend WithEvents chkSinFacturar As System.Windows.Forms.CheckBox
End Class
