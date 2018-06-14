<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRecepcionPagosClientes
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.mtb = New MEAToolBar.MEAToolBar()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdAplicarNota = New System.Windows.Forms.Button()
        Me.lblEstatus = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCuentaHabiente = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBanco = New System.Windows.Forms.TextBox()
        Me.CmbCuentas = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtFolio = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDocumento = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNotasCredito = New System.Windows.Forms.TextBox()
        Me.txtChequesPos = New System.Windows.Forms.TextBox()
        Me.txtImportePago = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSaldoActual = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtImporteTotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtImporteDetalle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DgvFacturas = New System.Windows.Forms.DataGridView()
        Me.clmChk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ClmNoFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFechaFact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFechaVence = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmAbono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmSaldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmNotaCrédito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmImporteNotaCredito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmApagar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmIdCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmSerie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtpFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.CmbClientes = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 532)
        Me.mtb.TabIndex = 50
        '
        'Label17
        '
        Me.Label17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(56, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(859, 32)
        Me.Label17.TabIndex = 49
        Me.Label17.Text = "Recepción Pagos de Clientes"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdAplicarNota)
        Me.GroupBox1.Controls.Add(Me.lblEstatus)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtCuentaHabiente)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtBanco)
        Me.GroupBox1.Controls.Add(Me.CmbCuentas)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtFolio)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtDocumento)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtNotasCredito)
        Me.GroupBox1.Controls.Add(Me.txtChequesPos)
        Me.GroupBox1.Controls.Add(Me.txtImportePago)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtSaldoActual)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtImporteTotal)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtImporteDetalle)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.DtpFechaPago)
        Me.GroupBox1.Controls.Add(Me.CmbClientes)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(852, 485)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cmdAplicarNota
        '
        Me.cmdAplicarNota.Location = New System.Drawing.Point(295, 171)
        Me.cmdAplicarNota.Name = "cmdAplicarNota"
        Me.cmdAplicarNota.Size = New System.Drawing.Size(75, 43)
        Me.cmdAplicarNota.TabIndex = 54
        Me.cmdAplicarNota.Text = "Aplicar Nota de Crédito"
        Me.cmdAplicarNota.UseVisualStyleBackColor = True
        Me.cmdAplicarNota.Visible = False
        '
        'lblEstatus
        '
        Me.lblEstatus.AutoSize = True
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(637, 15)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(104, 24)
        Me.lblEstatus.TabIndex = 53
        Me.lblEstatus.Text = "ESTATUS"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 137)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 13)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Cuenta Habiente:"
        '
        'txtCuentaHabiente
        '
        Me.txtCuentaHabiente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuentaHabiente.Location = New System.Drawing.Point(107, 135)
        Me.txtCuentaHabiente.MaxLength = 10
        Me.txtCuentaHabiente.Name = "txtCuentaHabiente"
        Me.txtCuentaHabiente.ReadOnly = True
        Me.txtCuentaHabiente.Size = New System.Drawing.Size(263, 20)
        Me.txtCuentaHabiente.TabIndex = 3
        Me.txtCuentaHabiente.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 111)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Banco:"
        '
        'txtBanco
        '
        Me.txtBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBanco.Location = New System.Drawing.Point(107, 109)
        Me.txtBanco.MaxLength = 10
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.ReadOnly = True
        Me.txtBanco.Size = New System.Drawing.Size(263, 20)
        Me.txtBanco.TabIndex = 2
        Me.txtBanco.TabStop = False
        '
        'CmbCuentas
        '
        Me.CmbCuentas.FormattingEnabled = True
        Me.CmbCuentas.Location = New System.Drawing.Point(107, 82)
        Me.CmbCuentas.Name = "CmbCuentas"
        Me.CmbCuentas.Size = New System.Drawing.Size(116, 21)
        Me.CmbCuentas.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 85)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 13)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Cta. Bancaria:"
        '
        'txtFolio
        '
        Me.txtFolio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFolio.Location = New System.Drawing.Point(107, 56)
        Me.txtFolio.MaxLength = 10
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.ReadOnly = True
        Me.txtFolio.Size = New System.Drawing.Size(116, 20)
        Me.txtFolio.TabIndex = 1
        Me.txtFolio.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Folio :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Importe Detalle :"
        '
        'txtDocumento
        '
        Me.txtDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDocumento.Location = New System.Drawing.Point(107, 161)
        Me.txtDocumento.MaxLength = 10
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(116, 20)
        Me.txtDocumento.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 163)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Documento :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(535, 171)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Notas Crédito :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(535, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Cheques PostFechados:"
        '
        'txtNotasCredito
        '
        Me.txtNotasCredito.Location = New System.Drawing.Point(664, 168)
        Me.txtNotasCredito.Name = "txtNotasCredito"
        Me.txtNotasCredito.ReadOnly = True
        Me.txtNotasCredito.Size = New System.Drawing.Size(102, 20)
        Me.txtNotasCredito.TabIndex = 30
        Me.txtNotasCredito.TabStop = False
        Me.txtNotasCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtChequesPos
        '
        Me.txtChequesPos.Location = New System.Drawing.Point(664, 142)
        Me.txtChequesPos.Name = "txtChequesPos"
        Me.txtChequesPos.ReadOnly = True
        Me.txtChequesPos.Size = New System.Drawing.Size(102, 20)
        Me.txtChequesPos.TabIndex = 29
        Me.txtChequesPos.TabStop = False
        Me.txtChequesPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtImportePago
        '
        Me.txtImportePago.Location = New System.Drawing.Point(664, 116)
        Me.txtImportePago.Name = "txtImportePago"
        Me.txtImportePago.ReadOnly = True
        Me.txtImportePago.Size = New System.Drawing.Size(102, 20)
        Me.txtImportePago.TabIndex = 28
        Me.txtImportePago.TabStop = False
        Me.txtImportePago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(535, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Importe del Pago :"
        '
        'txtSaldoActual
        '
        Me.txtSaldoActual.Location = New System.Drawing.Point(664, 89)
        Me.txtSaldoActual.Name = "txtSaldoActual"
        Me.txtSaldoActual.ReadOnly = True
        Me.txtSaldoActual.Size = New System.Drawing.Size(102, 20)
        Me.txtSaldoActual.TabIndex = 0
        Me.txtSaldoActual.TabStop = False
        Me.txtSaldoActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(535, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Saldo Actual :"
        '
        'txtImporteTotal
        '
        Me.txtImporteTotal.Location = New System.Drawing.Point(664, 194)
        Me.txtImporteTotal.Name = "txtImporteTotal"
        Me.txtImporteTotal.ReadOnly = True
        Me.txtImporteTotal.Size = New System.Drawing.Size(102, 20)
        Me.txtImporteTotal.TabIndex = 21
        Me.txtImporteTotal.TabStop = False
        Me.txtImporteTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(535, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Importe Total :"
        '
        'txtImporteDetalle
        '
        Me.txtImporteDetalle.Location = New System.Drawing.Point(107, 187)
        Me.txtImporteDetalle.Name = "txtImporteDetalle"
        Me.txtImporteDetalle.Size = New System.Drawing.Size(116, 20)
        Me.txtImporteDetalle.TabIndex = 3
        Me.txtImporteDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(535, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Fecha de Pago:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.DgvFacturas)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 220)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(830, 259)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Facturas a pagar"
        '
        'DgvFacturas
        '
        Me.DgvFacturas.AllowUserToAddRows = False
        Me.DgvFacturas.AllowUserToDeleteRows = False
        Me.DgvFacturas.AllowUserToResizeRows = False
        Me.DgvFacturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmChk, Me.ClmNoFactura, Me.clmFechaFact, Me.clmFechaVence, Me.clmTotal, Me.clmAbono, Me.clmSaldo, Me.clmNotaCrédito, Me.clmImporteNotaCredito, Me.clmApagar, Me.clmIdCliente, Me.clmSerie})
        Me.DgvFacturas.Location = New System.Drawing.Point(6, 19)
        Me.DgvFacturas.Name = "DgvFacturas"
        Me.DgvFacturas.RowHeadersVisible = False
        Me.DgvFacturas.Size = New System.Drawing.Size(815, 234)
        Me.DgvFacturas.TabIndex = 0
        '
        'clmChk
        '
        Me.clmChk.Frozen = True
        Me.clmChk.HeaderText = ""
        Me.clmChk.Name = "clmChk"
        Me.clmChk.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmChk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clmChk.Width = 35
        '
        'ClmNoFactura
        '
        Me.ClmNoFactura.DataPropertyName = "NoFactura"
        Me.ClmNoFactura.Frozen = True
        Me.ClmNoFactura.HeaderText = "NoFactura"
        Me.ClmNoFactura.Name = "ClmNoFactura"
        Me.ClmNoFactura.Width = 80
        '
        'clmFechaFact
        '
        Me.clmFechaFact.DataPropertyName = "FechaFactura"
        Me.clmFechaFact.Frozen = True
        Me.clmFechaFact.HeaderText = "Fec. Fac."
        Me.clmFechaFact.Name = "clmFechaFact"
        Me.clmFechaFact.Width = 90
        '
        'clmFechaVence
        '
        Me.clmFechaVence.DataPropertyName = "FechaVencimiento"
        Me.clmFechaVence.Frozen = True
        Me.clmFechaVence.HeaderText = "Fec. Ven."
        Me.clmFechaVence.Name = "clmFechaVence"
        Me.clmFechaVence.Width = 90
        '
        'clmTotal
        '
        Me.clmTotal.DataPropertyName = "Total"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.clmTotal.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmTotal.HeaderText = "Importe"
        Me.clmTotal.Name = "clmTotal"
        '
        'clmAbono
        '
        Me.clmAbono.DataPropertyName = "ImporteIngreso"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.clmAbono.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmAbono.HeaderText = "Abonos"
        Me.clmAbono.Name = "clmAbono"
        '
        'clmSaldo
        '
        Me.clmSaldo.DataPropertyName = "SaldoFactura"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.clmSaldo.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmSaldo.HeaderText = "S A L D O"
        Me.clmSaldo.Name = "clmSaldo"
        '
        'clmNotaCrédito
        '
        Me.clmNotaCrédito.HeaderText = "Nota Crédito"
        Me.clmNotaCrédito.Name = "clmNotaCrédito"
        Me.clmNotaCrédito.Visible = False
        '
        'clmImporteNotaCredito
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.clmImporteNotaCredito.DefaultCellStyle = DataGridViewCellStyle4
        Me.clmImporteNotaCredito.HeaderText = "Imp. Nota Cre"
        Me.clmImporteNotaCredito.Name = "clmImporteNotaCredito"
        Me.clmImporteNotaCredito.ReadOnly = True
        '
        'clmApagar
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.clmApagar.DefaultCellStyle = DataGridViewCellStyle5
        Me.clmApagar.HeaderText = "A Pagar"
        Me.clmApagar.Name = "clmApagar"
        '
        'clmIdCliente
        '
        Me.clmIdCliente.DataPropertyName = "IdCliente"
        Me.clmIdCliente.HeaderText = "Id Cliente"
        Me.clmIdCliente.Name = "clmIdCliente"
        Me.clmIdCliente.Visible = False
        Me.clmIdCliente.Width = 40
        '
        'clmSerie
        '
        Me.clmSerie.DataPropertyName = "Serie"
        Me.clmSerie.HeaderText = "Serie"
        Me.clmSerie.Name = "clmSerie"
        Me.clmSerie.Visible = False
        '
        'DtpFechaPago
        '
        Me.DtpFechaPago.CustomFormat = "dd/MMM/yyyy"
        Me.DtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaPago.Location = New System.Drawing.Point(664, 58)
        Me.DtpFechaPago.Name = "DtpFechaPago"
        Me.DtpFechaPago.Size = New System.Drawing.Size(99, 20)
        Me.DtpFechaPago.TabIndex = 4
        '
        'CmbClientes
        '
        Me.CmbClientes.FormattingEnabled = True
        Me.CmbClientes.Location = New System.Drawing.Point(107, 21)
        Me.CmbClientes.Name = "CmbClientes"
        Me.CmbClientes.Size = New System.Drawing.Size(385, 21)
        Me.CmbClientes.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "&Cliente :"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NoFactura"
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "NoFactura"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FechaFactura"
        Me.DataGridViewTextBoxColumn2.Frozen = True
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fec. Fac."
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 90
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FechaVencimiento"
        Me.DataGridViewTextBoxColumn3.Frozen = True
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fec. Ven."
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 90
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Total"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = "0"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn4.HeaderText = "Importe"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ImporteIngreso"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = "0"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn5.HeaderText = "Abonos"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "SaldoFactura"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "C2"
        DataGridViewCellStyle8.NullValue = "0"
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn6.HeaderText = "S A L D O"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Nota Crédito"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = "0"
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn8.HeaderText = "Imp. Nota Cre"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "C2"
        DataGridViewCellStyle10.NullValue = "0"
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn9.HeaderText = "A Pagar"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "IdCliente"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Id Cliente"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Visible = False
        Me.DataGridViewTextBoxColumn10.Width = 40
        '
        'FrmRecepcionPagosClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 532)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.Label17)
        Me.Name = "FrmRecepcionPagosClientes"
        Me.Text = "Recepción de Pagos de Clientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DgvFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CmbClientes As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DtpFechaPago As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DgvFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtImporteDetalle As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtImporteTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoActual As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNotasCredito As System.Windows.Forms.TextBox
    Friend WithEvents txtChequesPos As System.Windows.Forms.TextBox
    Friend WithEvents txtImportePago As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDocumento As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtBanco As System.Windows.Forms.TextBox
    Friend WithEvents CmbCuentas As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCuentaHabiente As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdAplicarNota As System.Windows.Forms.Button
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
    Friend WithEvents clmChk As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ClmNoFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaFact As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaVence As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmAbono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSaldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmNotaCrédito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmImporteNotaCredito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmApagar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSerie As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
