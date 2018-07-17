<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroFacGastosFrm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblEstatus = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.chkPagada = New System.Windows.Forms.CheckBox()
        Me.txtPoliza = New System.Windows.Forms.TextBox()
        Me.txtCheque = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblPolizaDiaria = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.TxtAnticipo = New System.Windows.Forms.TextBox()
        Me.txtIva = New System.Windows.Forms.TextBox()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DtpFechaVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtDiasPlazo = New System.Windows.Forms.TextBox()
        Me.DtpFechaFactura = New System.Windows.Forms.DateTimePicker()
        Me.TxtFactura = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CmbProveedor = New System.Windows.Forms.ComboBox()
        Me.DtpFechaCaptura = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mtb = New MEAToolBar.MEAToolBar()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DgvCuentas = New System.Windows.Forms.DataGridView()
        Me.clmIDCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCuentaContablePri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmCtaMayor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmSubCta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmSsbCta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmSssCta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmCargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmAbono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TmProveedor = New System.Windows.Forms.Timer(Me.components)
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtTasaIva = New System.Windows.Forms.TextBox()
        Me.TxtTasaISR = New System.Windows.Forms.TextBox()
        Me.TxtTasaRetIVA = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtISR = New System.Windows.Forms.TextBox()
        Me.txtRetIva = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.dgvdistribuciongastosdet = New System.Windows.Forms.DataGridView()
        Me.sucursal1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prorrateo1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cuenta1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cod_centro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idporcentaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.row = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSumaCargo = New System.Windows.Forms.TextBox()
        Me.txtSumaAbono = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Txtconcepto = New System.Windows.Forms.TextBox()
        Me.ckbFletes = New System.Windows.Forms.CheckBox()
        Me.ckbHonorarios = New System.Windows.Forms.CheckBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TxtIVAFlete = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TxtIVAFlete1 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.UUID = New System.Windows.Forms.MaskedTextBox()
        Me.dgvDistribuciondeGastos = New System.Windows.Forms.DataGridView()
        Me.clmIdPoliza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmSucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmMetodoProrrateo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCuentaContable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPorcentaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rowid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelBorrar = New System.Windows.Forms.Label()
        CType(Me.DgvCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvdistribuciongastosdet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDistribuciondeGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEstatus
        '
        Me.lblEstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(646, 29)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(122, 21)
        Me.lblEstatus.TabIndex = 132
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(50, 0)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(742, 29)
        Me.lblTitulo.TabIndex = 131
        Me.lblTitulo.Text = "REGISTRO DE FACTURAS DE GASTOS"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkPagada
        '
        Me.chkPagada.AutoSize = True
        Me.chkPagada.Location = New System.Drawing.Point(424, 84)
        Me.chkPagada.Name = "chkPagada"
        Me.chkPagada.Size = New System.Drawing.Size(63, 17)
        Me.chkPagada.TabIndex = 130
        Me.chkPagada.Text = "Pagada"
        Me.chkPagada.UseVisualStyleBackColor = True
        Me.chkPagada.Visible = False
        '
        'txtPoliza
        '
        Me.txtPoliza.Location = New System.Drawing.Point(679, 85)
        Me.txtPoliza.Name = "txtPoliza"
        Me.txtPoliza.Size = New System.Drawing.Size(100, 20)
        Me.txtPoliza.TabIndex = 129
        Me.txtPoliza.Visible = False
        '
        'txtCheque
        '
        Me.txtCheque.Location = New System.Drawing.Point(679, 62)
        Me.txtCheque.Name = "txtCheque"
        Me.txtCheque.Size = New System.Drawing.Size(100, 20)
        Me.txtCheque.TabIndex = 128
        Me.txtCheque.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(626, 88)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 13)
        Me.Label13.TabIndex = 127
        Me.Label13.Text = "Póliza:"
        Me.Label13.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(626, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 126
        Me.Label9.Text = "Cheque:"
        Me.Label9.Visible = False
        '
        'LblPolizaDiaria
        '
        Me.LblPolizaDiaria.BackColor = System.Drawing.Color.SteelBlue
        Me.LblPolizaDiaria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblPolizaDiaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPolizaDiaria.ForeColor = System.Drawing.Color.White
        Me.LblPolizaDiaria.Location = New System.Drawing.Point(95, 81)
        Me.LblPolizaDiaria.Name = "LblPolizaDiaria"
        Me.LblPolizaDiaria.Size = New System.Drawing.Size(275, 20)
        Me.LblPolizaDiaria.TabIndex = 125
        Me.LblPolizaDiaria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblPolizaDiaria.Visible = False
        '
        'TxtTotal
        '
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Location = New System.Drawing.Point(629, 307)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(98, 20)
        Me.TxtTotal.TabIndex = 14
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtAnticipo
        '
        Me.TxtAnticipo.Location = New System.Drawing.Point(629, 280)
        Me.TxtAnticipo.Name = "TxtAnticipo"
        Me.TxtAnticipo.Size = New System.Drawing.Size(98, 20)
        Me.TxtAnticipo.TabIndex = 13
        Me.TxtAnticipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIva
        '
        Me.txtIva.Location = New System.Drawing.Point(629, 176)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.Size = New System.Drawing.Size(98, 20)
        Me.txtIva.TabIndex = 10
        Me.txtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(629, 150)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(97, 20)
        Me.txtSubtotal.TabIndex = 9
        Me.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Location = New System.Drawing.Point(181, 377)
        Me.txtObservaciones.MaxLength = 250
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(334, 43)
        Me.txtObservaciones.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(74, 378)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 13)
        Me.Label12.TabIndex = 119
        Me.Label12.Text = "Observaciones:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(548, 310)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 118
        Me.Label11.Text = "Total:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(548, 283)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 117
        Me.Label10.Text = "Anticipo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(548, 179)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 116
        Me.Label8.Text = "IVA:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(548, 153)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 115
        Me.Label7.Text = "SubTotal:"
        '
        'DtpFechaVencimiento
        '
        Me.DtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaVencimiento.Location = New System.Drawing.Point(181, 227)
        Me.DtpFechaVencimiento.Name = "DtpFechaVencimiento"
        Me.DtpFechaVencimiento.Size = New System.Drawing.Size(87, 20)
        Me.DtpFechaVencimiento.TabIndex = 4
        '
        'txtDiasPlazo
        '
        Me.txtDiasPlazo.Enabled = False
        Me.txtDiasPlazo.Location = New System.Drawing.Point(181, 201)
        Me.txtDiasPlazo.Name = "txtDiasPlazo"
        Me.txtDiasPlazo.Size = New System.Drawing.Size(87, 20)
        Me.txtDiasPlazo.TabIndex = 3
        '
        'DtpFechaFactura
        '
        Me.DtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaFactura.Location = New System.Drawing.Point(181, 174)
        Me.DtpFechaFactura.Name = "DtpFechaFactura"
        Me.DtpFechaFactura.Size = New System.Drawing.Size(87, 20)
        Me.DtpFechaFactura.TabIndex = 2
        '
        'TxtFactura
        '
        Me.TxtFactura.Location = New System.Drawing.Point(181, 147)
        Me.TxtFactura.Name = "TxtFactura"
        Me.TxtFactura.Size = New System.Drawing.Size(87, 20)
        Me.TxtFactura.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(74, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 110
        Me.Label6.Text = "Fecha Vencimiento:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(74, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 109
        Me.Label5.Text = "Días de Plazo:"
        '
        'CmbProveedor
        '
        Me.CmbProveedor.FormattingEnabled = True
        Me.CmbProveedor.Location = New System.Drawing.Point(181, 117)
        Me.CmbProveedor.Name = "CmbProveedor"
        Me.CmbProveedor.Size = New System.Drawing.Size(249, 21)
        Me.CmbProveedor.TabIndex = 0
        '
        'DtpFechaCaptura
        '
        Me.DtpFechaCaptura.Enabled = False
        Me.DtpFechaCaptura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaCaptura.Location = New System.Drawing.Point(587, 116)
        Me.DtpFechaCaptura.Name = "DtpFechaCaptura"
        Me.DtpFechaCaptura.Size = New System.Drawing.Size(100, 20)
        Me.DtpFechaCaptura.TabIndex = 107
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(74, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "Fecha Factura:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(481, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = "Fecha Recepción:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Folio Factura:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "Proveedor:"
        '
        'mtb
        '
        Me.mtb.ButtonSize = New System.Drawing.Size(50, 50)
        Me.mtb.Dock = System.Windows.Forms.DockStyle.Left
        Me.mtb.DropDownArrows = True
        Me.mtb.HabilitarBorrar = True
        Me.mtb.HabilitarBuscar = True
        Me.mtb.HabilitarCancelar = True
        Me.mtb.HabilitarEditar = False
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
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 724)
        Me.mtb.TabIndex = 102
        '
        'lblEmpresa
        '
        Me.lblEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmpresa.Location = New System.Drawing.Point(131, 46)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(470, 22)
        Me.lblEmpresa.TabIndex = 100
        Me.lblEmpresa.Text = "Label3"
        Me.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(74, 51)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 13)
        Me.Label18.TabIndex = 101
        Me.Label18.Text = "Empresa:"
        '
        'DgvCuentas
        '
        Me.DgvCuentas.AllowUserToAddRows = False
        Me.DgvCuentas.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvCuentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmIDCuenta, Me.clmCuentaContablePri, Me.ClmCtaMayor, Me.ClmSubCta, Me.ClmSsbCta, Me.ClmSssCta, Me.ClmDescripcion, Me.ClmCargo, Me.ClmAbono})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvCuentas.DefaultCellStyle = DataGridViewCellStyle4
        Me.DgvCuentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvCuentas.Location = New System.Drawing.Point(3, 16)
        Me.DgvCuentas.Name = "DgvCuentas"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvCuentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DgvCuentas.RowHeadersVisible = False
        Me.DgvCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCuentas.Size = New System.Drawing.Size(663, 143)
        Me.DgvCuentas.TabIndex = 0
        '
        'clmIDCuenta
        '
        Me.clmIDCuenta.HeaderText = "ID Cuenta Contable"
        Me.clmIDCuenta.Name = "clmIDCuenta"
        Me.clmIDCuenta.Visible = False
        '
        'clmCuentaContablePri
        '
        Me.clmCuentaContablePri.HeaderText = "Cuenta Contable"
        Me.clmCuentaContablePri.Name = "clmCuentaContablePri"
        Me.clmCuentaContablePri.Visible = False
        '
        'ClmCtaMayor
        '
        Me.ClmCtaMayor.HeaderText = "Cta. Mayor"
        Me.ClmCtaMayor.Name = "ClmCtaMayor"
        Me.ClmCtaMayor.Width = 85
        '
        'ClmSubCta
        '
        Me.ClmSubCta.HeaderText = "Sub Cta."
        Me.ClmSubCta.Name = "ClmSubCta"
        Me.ClmSubCta.Width = 75
        '
        'ClmSsbCta
        '
        Me.ClmSsbCta.HeaderText = "Ssb Cta."
        Me.ClmSsbCta.Name = "ClmSsbCta"
        Me.ClmSsbCta.Width = 75
        '
        'ClmSssCta
        '
        Me.ClmSssCta.HeaderText = "Sss Cta."
        Me.ClmSssCta.Name = "ClmSssCta"
        Me.ClmSssCta.Width = 75
        '
        'ClmDescripcion
        '
        Me.ClmDescripcion.HeaderText = "Descripción"
        Me.ClmDescripcion.Name = "ClmDescripcion"
        Me.ClmDescripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ClmDescripcion.Width = 150
        '
        'ClmCargo
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.ClmCargo.DefaultCellStyle = DataGridViewCellStyle2
        Me.ClmCargo.HeaderText = "Cargo"
        Me.ClmCargo.Name = "ClmCargo"
        '
        'ClmAbono
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ClmAbono.DefaultCellStyle = DataGridViewCellStyle3
        Me.ClmAbono.HeaderText = "Abono"
        Me.ClmAbono.Name = "ClmAbono"
        '
        'TmProveedor
        '
        Me.TmProveedor.Interval = 1000
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(308, 147)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 13)
        Me.Label14.TabIndex = 134
        Me.Label14.Text = "Tasa IVA:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(309, 216)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 13)
        Me.Label15.TabIndex = 135
        Me.Label15.Text = "Tasa ISR:"
        Me.Label15.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(309, 188)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 13)
        Me.Label16.TabIndex = 136
        Me.Label16.Text = "Tasa Ret IVA:"
        Me.Label16.Visible = False
        '
        'txtTasaIva
        '
        Me.txtTasaIva.Location = New System.Drawing.Point(389, 144)
        Me.txtTasaIva.Name = "txtTasaIva"
        Me.txtTasaIva.Size = New System.Drawing.Size(80, 20)
        Me.txtTasaIva.TabIndex = 6
        Me.txtTasaIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTasaISR
        '
        Me.TxtTasaISR.Enabled = False
        Me.TxtTasaISR.Location = New System.Drawing.Point(389, 213)
        Me.TxtTasaISR.Name = "TxtTasaISR"
        Me.TxtTasaISR.Size = New System.Drawing.Size(80, 20)
        Me.TxtTasaISR.TabIndex = 7
        Me.TxtTasaISR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTasaISR.Visible = False
        '
        'TxtTasaRetIVA
        '
        Me.TxtTasaRetIVA.Enabled = False
        Me.TxtTasaRetIVA.Location = New System.Drawing.Point(389, 185)
        Me.TxtTasaRetIVA.Name = "TxtTasaRetIVA"
        Me.TxtTasaRetIVA.Size = New System.Drawing.Size(80, 20)
        Me.TxtTasaRetIVA.TabIndex = 8
        Me.TxtTasaRetIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTasaRetIVA.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(548, 204)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(28, 13)
        Me.Label17.TabIndex = 140
        Me.Label17.Text = "ISR:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(548, 230)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(79, 13)
        Me.Label19.TabIndex = 141
        Me.Label19.Text = "Retención IVA:"
        '
        'TxtISR
        '
        Me.TxtISR.Enabled = False
        Me.TxtISR.Location = New System.Drawing.Point(629, 201)
        Me.TxtISR.Name = "TxtISR"
        Me.TxtISR.Size = New System.Drawing.Size(97, 20)
        Me.TxtISR.TabIndex = 11
        Me.TxtISR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRetIva
        '
        Me.txtRetIva.Enabled = False
        Me.txtRetIva.Location = New System.Drawing.Point(629, 227)
        Me.txtRetIva.Name = "txtRetIva"
        Me.txtRetIva.Size = New System.Drawing.Size(97, 20)
        Me.txtRetIva.TabIndex = 12
        Me.txtRetIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvCuentas)
        Me.GroupBox1.Location = New System.Drawing.Point(80, 433)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(669, 162)
        Me.GroupBox1.TabIndex = 144
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cuentas Contables"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Location = New System.Drawing.Point(80, 676)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(688, 36)
        Me.GroupBox2.TabIndex = 145
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nota"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(53, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(232, 13)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Presione F3 Para Buscar las Cuentas Contables" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'dgvdistribuciongastosdet
        '
        Me.dgvdistribuciongastosdet.AllowUserToAddRows = False
        Me.dgvdistribuciongastosdet.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvdistribuciongastosdet.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvdistribuciongastosdet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdistribuciongastosdet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sucursal1, Me.Prorrateo1, Me.Cuenta1, Me.cod_centro, Me.idporcentaje, Me.row})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvdistribuciongastosdet.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvdistribuciongastosdet.Location = New System.Drawing.Point(83, 598)
        Me.dgvdistribuciongastosdet.Name = "dgvdistribuciongastosdet"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvdistribuciongastosdet.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvdistribuciongastosdet.RowHeadersVisible = False
        Me.dgvdistribuciongastosdet.Size = New System.Drawing.Size(235, 88)
        Me.dgvdistribuciongastosdet.TabIndex = 162
        Me.dgvdistribuciongastosdet.Visible = False
        '
        'sucursal1
        '
        Me.sucursal1.HeaderText = "Sucursal"
        Me.sucursal1.Name = "sucursal1"
        '
        'Prorrateo1
        '
        Me.Prorrateo1.HeaderText = "Metodo Prorrateo"
        Me.Prorrateo1.Name = "Prorrateo1"
        '
        'Cuenta1
        '
        Me.Cuenta1.HeaderText = "Cuenta Contable"
        Me.Cuenta1.Name = "Cuenta1"
        '
        'cod_centro
        '
        Me.cod_centro.HeaderText = "Centro Costos"
        Me.cod_centro.Name = "cod_centro"
        '
        'idporcentaje
        '
        Me.idporcentaje.HeaderText = "Porcentaje"
        Me.idporcentaje.Name = "idporcentaje"
        '
        'row
        '
        Me.row.DataPropertyName = "row"
        Me.row.HeaderText = "row"
        Me.row.Name = "row"
        '
        'txtSumaCargo
        '
        Me.txtSumaCargo.Enabled = False
        Me.txtSumaCargo.Location = New System.Drawing.Point(551, 601)
        Me.txtSumaCargo.Name = "txtSumaCargo"
        Me.txtSumaCargo.Size = New System.Drawing.Size(85, 20)
        Me.txtSumaCargo.TabIndex = 146
        Me.txtSumaCargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSumaAbono
        '
        Me.txtSumaAbono.Enabled = False
        Me.txtSumaAbono.Location = New System.Drawing.Point(650, 601)
        Me.txtSumaAbono.Name = "txtSumaAbono"
        Me.txtSumaAbono.Size = New System.Drawing.Size(85, 20)
        Me.txtSumaAbono.TabIndex = 147
        Me.txtSumaAbono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(548, 336)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(37, 13)
        Me.Label21.TabIndex = 148
        Me.Label21.Text = "Saldo:"
        Me.Label21.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(629, 333)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(97, 20)
        Me.TextBox1.TabIndex = 15
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBox1.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(74, 325)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(56, 13)
        Me.Label22.TabIndex = 149
        Me.Label22.Text = "Concepto:"
        '
        'Txtconcepto
        '
        Me.Txtconcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtconcepto.Location = New System.Drawing.Point(181, 322)
        Me.Txtconcepto.MaxLength = 250
        Me.Txtconcepto.Multiline = True
        Me.Txtconcepto.Name = "Txtconcepto"
        Me.Txtconcepto.Size = New System.Drawing.Size(334, 43)
        Me.Txtconcepto.TabIndex = 150
        '
        'ckbFletes
        '
        Me.ckbFletes.AutoSize = True
        Me.ckbFletes.Location = New System.Drawing.Point(285, 240)
        Me.ckbFletes.Name = "ckbFletes"
        Me.ckbFletes.Size = New System.Drawing.Size(54, 17)
        Me.ckbFletes.TabIndex = 151
        Me.ckbFletes.Text = "Fletes"
        Me.ckbFletes.UseVisualStyleBackColor = True
        '
        'ckbHonorarios
        '
        Me.ckbHonorarios.AutoSize = True
        Me.ckbHonorarios.Location = New System.Drawing.Point(285, 164)
        Me.ckbHonorarios.Name = "ckbHonorarios"
        Me.ckbHonorarios.Size = New System.Drawing.Size(77, 17)
        Me.ckbHonorarios.TabIndex = 152
        Me.ckbHonorarios.Text = "Honorarios"
        Me.ckbHonorarios.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(309, 260)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(53, 13)
        Me.Label23.TabIndex = 153
        Me.Label23.Text = "IVA Flete:"
        Me.Label23.Visible = False
        '
        'TxtIVAFlete
        '
        Me.TxtIVAFlete.Enabled = False
        Me.TxtIVAFlete.Location = New System.Drawing.Point(389, 257)
        Me.TxtIVAFlete.Name = "TxtIVAFlete"
        Me.TxtIVAFlete.Size = New System.Drawing.Size(80, 20)
        Me.TxtIVAFlete.TabIndex = 154
        Me.TxtIVAFlete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtIVAFlete.Visible = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(548, 257)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(53, 13)
        Me.Label24.TabIndex = 155
        Me.Label24.Text = "IVA Flete:"
        '
        'TxtIVAFlete1
        '
        Me.TxtIVAFlete1.Location = New System.Drawing.Point(629, 254)
        Me.TxtIVAFlete1.Name = "TxtIVAFlete1"
        Me.TxtIVAFlete1.Size = New System.Drawing.Size(97, 20)
        Me.TxtIVAFlete1.TabIndex = 157
        Me.TxtIVAFlete1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(74, 287)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(34, 13)
        Me.Label25.TabIndex = 158
        Me.Label25.Text = "UUID"
        '
        'UUID
        '
        Me.UUID.Location = New System.Drawing.Point(181, 284)
        Me.UUID.Mask = "aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"
        Me.UUID.Name = "UUID"
        Me.UUID.Size = New System.Drawing.Size(214, 20)
        Me.UUID.TabIndex = 160
        '
        'dgvDistribuciondeGastos
        '
        Me.dgvDistribuciondeGastos.AllowUserToAddRows = False
        Me.dgvDistribuciondeGastos.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDistribuciondeGastos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvDistribuciondeGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDistribuciondeGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmIdPoliza, Me.clmSucursal, Me.clmMetodoProrrateo, Me.clmCuentaContable, Me.clmImporte, Me.clmPorcentaje, Me.rowid})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDistribuciondeGastos.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvDistribuciondeGastos.Location = New System.Drawing.Point(358, 336)
        Me.dgvDistribuciondeGastos.Name = "dgvDistribuciondeGastos"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDistribuciondeGastos.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvDistribuciondeGastos.RowHeadersVisible = False
        Me.dgvDistribuciondeGastos.Size = New System.Drawing.Size(410, 104)
        Me.dgvDistribuciondeGastos.TabIndex = 161
        Me.dgvDistribuciondeGastos.Visible = False
        '
        'clmIdPoliza
        '
        Me.clmIdPoliza.DataPropertyName = "IdPoliza"
        Me.clmIdPoliza.HeaderText = "IdPoliza"
        Me.clmIdPoliza.Name = "clmIdPoliza"
        '
        'clmSucursal
        '
        Me.clmSucursal.DataPropertyName = "IdSucursal"
        Me.clmSucursal.HeaderText = "Sucursal"
        Me.clmSucursal.Name = "clmSucursal"
        '
        'clmMetodoProrrateo
        '
        Me.clmMetodoProrrateo.DataPropertyName = "IdMetodoProrrateo"
        Me.clmMetodoProrrateo.HeaderText = "Metodo Prorrateo"
        Me.clmMetodoProrrateo.Name = "clmMetodoProrrateo"
        '
        'clmCuentaContable
        '
        Me.clmCuentaContable.DataPropertyName = "IdCuentaContable"
        Me.clmCuentaContable.HeaderText = "Cuenta Contable"
        Me.clmCuentaContable.Name = "clmCuentaContable"
        '
        'clmImporte
        '
        Me.clmImporte.DataPropertyName = "Importe"
        Me.clmImporte.HeaderText = "Importe"
        Me.clmImporte.Name = "clmImporte"
        '
        'clmPorcentaje
        '
        Me.clmPorcentaje.DataPropertyName = "Ptj_Importe"
        Me.clmPorcentaje.HeaderText = "Porcentaje"
        Me.clmPorcentaje.Name = "clmPorcentaje"
        '
        'rowid
        '
        Me.rowid.DataPropertyName = "rowid"
        Me.rowid.HeaderText = "rowid"
        Me.rowid.Name = "rowid"
        '
        'LabelBorrar
        '
        Me.LabelBorrar.AutoSize = True
        Me.LabelBorrar.Location = New System.Drawing.Point(4, 307)
        Me.LabelBorrar.Name = "LabelBorrar"
        Me.LabelBorrar.Size = New System.Drawing.Size(43, 13)
        Me.LabelBorrar.TabIndex = 163
        Me.LabelBorrar.Text = "Eliminar"
        '
        'RegistroFacGastosFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 724)
        Me.Controls.Add(Me.LabelBorrar)
        Me.Controls.Add(Me.dgvdistribuciongastosdet)
        Me.Controls.Add(Me.UUID)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.TxtIVAFlete1)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.TxtIVAFlete)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.ckbHonorarios)
        Me.Controls.Add(Me.ckbFletes)
        Me.Controls.Add(Me.Txtconcepto)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtSumaAbono)
        Me.Controls.Add(Me.txtSumaCargo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtRetIva)
        Me.Controls.Add(Me.TxtISR)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TxtTasaRetIVA)
        Me.Controls.Add(Me.TxtTasaISR)
        Me.Controls.Add(Me.txtTasaIva)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblEstatus)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.chkPagada)
        Me.Controls.Add(Me.txtPoliza)
        Me.Controls.Add(Me.txtCheque)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LblPolizaDiaria)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.TxtAnticipo)
        Me.Controls.Add(Me.txtIva)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DtpFechaVencimiento)
        Me.Controls.Add(Me.txtDiasPlazo)
        Me.Controls.Add(Me.DtpFechaFactura)
        Me.Controls.Add(Me.TxtFactura)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CmbProveedor)
        Me.Controls.Add(Me.DtpFechaCaptura)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.lblEmpresa)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgvDistribuciondeGastos)
        Me.MaximizeBox = False
        Me.Name = "RegistroFacGastosFrm"
        Me.Text = "Registro de Facturas de Gastos"
        CType(Me.DgvCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvdistribuciongastosdet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDistribuciondeGastos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents chkPagada As System.Windows.Forms.CheckBox
    Friend WithEvents txtPoliza As System.Windows.Forms.TextBox
    Friend WithEvents txtCheque As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LblPolizaDiaria As System.Windows.Forms.Label
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents TxtAnticipo As System.Windows.Forms.TextBox
    Friend WithEvents txtIva As System.Windows.Forms.TextBox
    Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DtpFechaVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDiasPlazo As System.Windows.Forms.TextBox
    Friend WithEvents DtpFechaFactura As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CmbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents DtpFechaCaptura As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents lblEmpresa As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents DgvCuentas As System.Windows.Forms.DataGridView
    Friend WithEvents TmProveedor As System.Windows.Forms.Timer
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtTasaIva As System.Windows.Forms.TextBox
    Friend WithEvents TxtTasaISR As System.Windows.Forms.TextBox
    Friend WithEvents TxtTasaRetIVA As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TxtISR As System.Windows.Forms.TextBox
    Friend WithEvents txtRetIva As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtSumaCargo As System.Windows.Forms.TextBox
    Friend WithEvents txtSumaAbono As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Txtconcepto As System.Windows.Forms.TextBox
    Friend WithEvents ckbFletes As System.Windows.Forms.CheckBox
    Friend WithEvents ckbHonorarios As System.Windows.Forms.CheckBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TxtIVAFlete As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TxtIVAFlete1 As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents UUID As System.Windows.Forms.MaskedTextBox
    Friend WithEvents dgvDistribuciondeGastos As System.Windows.Forms.DataGridView
    Friend WithEvents clmIDCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCuentaContablePri As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmCtaMayor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmSubCta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmSsbCta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmSssCta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmCargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmAbono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvdistribuciongastosdet As System.Windows.Forms.DataGridView
    Friend WithEvents LabelBorrar As System.Windows.Forms.Label
    Friend WithEvents sucursal1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Prorrateo1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cuenta1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cod_centro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idporcentaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents row As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdPoliza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSucursal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmMetodoProrrateo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCuentaContable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPorcentaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rowid As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
