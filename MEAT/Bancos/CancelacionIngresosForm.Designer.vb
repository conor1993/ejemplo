<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CancelacionIngresosForm
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
        Me.pan = New System.Windows.Forms.Panel()
        Me.chkAnticipo = New System.Windows.Forms.CheckBox()
        Me.lblEstatus = New System.Windows.Forms.Label()
        Me.txtPoliza = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtReferencia = New System.Windows.Forms.TextBox()
        Me.chkElectronico = New System.Windows.Forms.CheckBox()
        Me.txtConcepto = New System.Windows.Forms.TextBox()
        Me.txtImporteLetra = New System.Windows.Forms.TextBox()
        Me.txtTipoCambio = New Integra.Controles.TextboxDecimal()
        Me.txtImporte = New Integra.Controles.TextboxDecimal()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gpoCuentas = New System.Windows.Forms.GroupBox()
        Me.lv = New System.Windows.Forms.ListView()
        Me.chCuenta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDescripcion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTipoMoneda = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblRef = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbBanco = New System.Windows.Forms.ComboBox()
        Me.Bancos = New ClasesNegocio.BancosCollectionClass()
        Me.txtBanco = New System.Windows.Forms.TextBox()
        Me.mtb = New MEAToolBar.MEAToolBar()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Ingresos = New ClasesNegocio.ChequeCollectionClass()
        Me.ImprimirCheque = New ClasesNegocio.PrintDocumentChequeClass()
        Me.PagoElectronico = New ClasesNegocio.PrintDocumentPagoElectronicoClass()
        Me.pDg = New System.Windows.Forms.PrintDialog()
        Me.gpo = New System.Windows.Forms.GroupBox()
        Me.tab = New System.Windows.Forms.TableLayoutPanel()
        Me.DgvCuentas = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtAbono = New Integra.Controles.TextboxDecimal()
        Me.txtCargo = New Integra.Controles.TextboxDecimal()
        Me.ClmCtaMayor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmSubCta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmSsbCta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmSssCta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmCargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmAbono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCuentaContable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Posicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pan.SuspendLayout()
        Me.gpoCuentas.SuspendLayout()
        Me.gpo.SuspendLayout()
        Me.tab.SuspendLayout()
        CType(Me.DgvCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pan
        '
        Me.pan.Controls.Add(Me.chkAnticipo)
        Me.pan.Controls.Add(Me.lblEstatus)
        Me.pan.Controls.Add(Me.txtPoliza)
        Me.pan.Controls.Add(Me.Label9)
        Me.pan.Controls.Add(Me.txtReferencia)
        Me.pan.Controls.Add(Me.chkElectronico)
        Me.pan.Controls.Add(Me.txtConcepto)
        Me.pan.Controls.Add(Me.txtImporteLetra)
        Me.pan.Controls.Add(Me.txtTipoCambio)
        Me.pan.Controls.Add(Me.txtImporte)
        Me.pan.Controls.Add(Me.Label2)
        Me.pan.Controls.Add(Me.dtp)
        Me.pan.Controls.Add(Me.Label8)
        Me.pan.Controls.Add(Me.gpoCuentas)
        Me.pan.Controls.Add(Me.Label4)
        Me.pan.Controls.Add(Me.Label5)
        Me.pan.Controls.Add(Me.lblRef)
        Me.pan.Controls.Add(Me.Label1)
        Me.pan.Controls.Add(Me.cmbBanco)
        Me.pan.Controls.Add(Me.txtBanco)
        Me.pan.Location = New System.Drawing.Point(53, 33)
        Me.pan.Name = "pan"
        Me.pan.Size = New System.Drawing.Size(698, 342)
        Me.pan.TabIndex = 10
        '
        'chkAnticipo
        '
        Me.chkAnticipo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkAnticipo.Location = New System.Drawing.Point(7, 191)
        Me.chkAnticipo.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.chkAnticipo.Name = "chkAnticipo"
        Me.chkAnticipo.Size = New System.Drawing.Size(89, 24)
        Me.chkAnticipo.TabIndex = 182
        Me.chkAnticipo.Text = "Es Anticipo:"
        Me.chkAnticipo.UseVisualStyleBackColor = True
        '
        'lblEstatus
        '
        Me.lblEstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(581, 12)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(122, 21)
        Me.lblEstatus.TabIndex = 178
        Me.lblEstatus.Text = "ACTIVO"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEstatus.Visible = False
        '
        'txtPoliza
        '
        Me.txtPoliza.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtPoliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPoliza.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtPoliza.Location = New System.Drawing.Point(544, 280)
        Me.txtPoliza.Name = "txtPoliza"
        Me.txtPoliza.ReadOnly = True
        Me.txtPoliza.Size = New System.Drawing.Size(143, 22)
        Me.txtPoliza.TabIndex = 19
        Me.txtPoliza.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(500, 285)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Poliza:"
        '
        'txtReferencia
        '
        Me.txtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReferencia.Location = New System.Drawing.Point(289, 193)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(397, 20)
        Me.txtReferencia.TabIndex = 10
        '
        'chkElectronico
        '
        Me.chkElectronico.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkElectronico.Location = New System.Drawing.Point(102, 191)
        Me.chkElectronico.Name = "chkElectronico"
        Me.chkElectronico.Size = New System.Drawing.Size(97, 24)
        Me.chkElectronico.TabIndex = 8
        Me.chkElectronico.Text = "Es Electronico"
        Me.chkElectronico.UseVisualStyleBackColor = True
        '
        'txtConcepto
        '
        Me.txtConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConcepto.Location = New System.Drawing.Point(88, 280)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(406, 20)
        Me.txtConcepto.TabIndex = 17
        '
        'txtImporteLetra
        '
        Me.txtImporteLetra.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtImporteLetra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporteLetra.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtImporteLetra.Location = New System.Drawing.Point(192, 221)
        Me.txtImporteLetra.Multiline = True
        Me.txtImporteLetra.Name = "txtImporteLetra"
        Me.txtImporteLetra.ReadOnly = True
        Me.txtImporteLetra.Size = New System.Drawing.Size(495, 53)
        Me.txtImporteLetra.TabIndex = 13
        Me.txtImporteLetra.TabStop = False
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtTipoCambio.Decimales = CType(2UI, UInteger)
        Me.txtTipoCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCambio.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtTipoCambio.Location = New System.Drawing.Point(88, 252)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.ReadOnly = True
        Me.txtTipoCambio.Signo = Integra.Controles.TextboxDecimal.RespuestaEnum.NO
        Me.txtTipoCambio.Size = New System.Drawing.Size(98, 22)
        Me.txtTipoCambio.TabIndex = 15
        Me.txtTipoCambio.TabStop = False
        Me.txtTipoCambio.Text = "0.00"
        Me.txtTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtImporte
        '
        Me.txtImporte.Decimales = CType(2UI, UInteger)
        Me.txtImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporte.Location = New System.Drawing.Point(88, 221)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Signo = Integra.Controles.TextboxDecimal.RespuestaEnum.NO
        Me.txtImporte.Size = New System.Drawing.Size(98, 22)
        Me.txtImporte.TabIndex = 12
        Me.txtImporte.Text = "0.00"
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(434, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha:"
        '
        'dtp
        '
        Me.dtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp.Location = New System.Drawing.Point(480, 13)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(95, 20)
        Me.dtp.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 257)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "T.C. :"
        '
        'gpoCuentas
        '
        Me.gpoCuentas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpoCuentas.Controls.Add(Me.lv)
        Me.gpoCuentas.Controls.Add(Me.Label6)
        Me.gpoCuentas.Controls.Add(Me.txtSaldo)
        Me.gpoCuentas.Controls.Add(Me.txtCuenta)
        Me.gpoCuentas.Location = New System.Drawing.Point(10, 38)
        Me.gpoCuentas.Name = "gpoCuentas"
        Me.gpoCuentas.Size = New System.Drawing.Size(682, 147)
        Me.gpoCuentas.TabIndex = 5
        Me.gpoCuentas.TabStop = False
        Me.gpoCuentas.Text = "Cuentas"
        '
        'lv
        '
        Me.lv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chCuenta, Me.chDescripcion, Me.chTipoMoneda})
        Me.lv.FullRowSelect = True
        Me.lv.Location = New System.Drawing.Point(6, 19)
        Me.lv.MultiSelect = False
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(670, 96)
        Me.lv.TabIndex = 0
        Me.lv.UseCompatibleStateImageBehavior = False
        Me.lv.View = System.Windows.Forms.View.Details
        '
        'chCuenta
        '
        Me.chCuenta.Text = "Nº Cuenta"
        Me.chCuenta.Width = 200
        '
        'chDescripcion
        '
        Me.chDescripcion.Text = "Descripción"
        Me.chDescripcion.Width = 300
        '
        'chTipoMoneda
        '
        Me.chTipoMoneda.Text = "Tipo de Moneda"
        Me.chTipoMoneda.Width = 100
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Cuenta Seleccionada:"
        '
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtSaldo.Location = New System.Drawing.Point(484, 119)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.Size = New System.Drawing.Size(192, 22)
        Me.txtSaldo.TabIndex = 3
        Me.txtSaldo.TabStop = False
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCuenta
        '
        Me.txtCuenta.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtCuenta.Location = New System.Drawing.Point(124, 119)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.ReadOnly = True
        Me.txtCuenta.Size = New System.Drawing.Size(351, 22)
        Me.txtCuenta.TabIndex = 2
        Me.txtCuenta.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Importe: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 283)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Concepto:"
        '
        'lblRef
        '
        Me.lblRef.AutoSize = True
        Me.lblRef.Location = New System.Drawing.Point(221, 196)
        Me.lblRef.Name = "lblRef"
        Me.lblRef.Size = New System.Drawing.Size(62, 13)
        Me.lblRef.TabIndex = 9
        Me.lblRef.Text = "Referencia:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Banco:"
        '
        'cmbBanco
        '
        Me.cmbBanco.DataSource = Me.Bancos
        Me.cmbBanco.DisplayMember = "Descripcion"
        Me.cmbBanco.FormattingEnabled = True
        Me.cmbBanco.Location = New System.Drawing.Point(156, 12)
        Me.cmbBanco.Name = "cmbBanco"
        Me.cmbBanco.Size = New System.Drawing.Size(272, 21)
        Me.cmbBanco.TabIndex = 2
        Me.cmbBanco.ValueMember = "DescripcionCta"
        '
        'Bancos
        '
        Me.Bancos.AllowEdit = True
        Me.Bancos.AllowNew = True
        Me.Bancos.AllowRemove = True
        Me.Bancos.Name = ""
        Me.Bancos.RaiseListChangedEvents = True
        '
        'txtBanco
        '
        Me.txtBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBanco.Location = New System.Drawing.Point(50, 12)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(100, 20)
        Me.txtBanco.TabIndex = 1
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
        Me.mtb.MostrarBorrar = True
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
        Me.mtb.Size = New System.Drawing.Size(50, 560)
        Me.mtb.TabIndex = 8
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(50, 0)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(728, 30)
        Me.lblTitulo.TabIndex = 9
        Me.lblTitulo.Text = "Label1"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Ingresos
        '
        Me.Ingresos.AllowEdit = True
        Me.Ingresos.AllowNew = True
        Me.Ingresos.AllowRemove = True
        Me.Ingresos.MaximoElementosSeleccionados = 1
        Me.Ingresos.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.Ingresos.MostrarAlertas = False
        Me.Ingresos.Name = Nothing
        Me.Ingresos.RaiseListChangedEvents = True
        Me.Ingresos.Transaction = Nothing
        '
        'ImprimirCheque
        '
        Me.ImprimirCheque.AbonoEnCuenta = System.Windows.Forms.DialogResult.None
        Me.ImprimirCheque.Banco = 0
        Me.ImprimirCheque.Cheque = Nothing
        '
        'PagoElectronico
        '
        Me.PagoElectronico.Cheque = Nothing
        '
        'pDg
        '
        Me.pDg.UseEXDialog = True
        '
        'gpo
        '
        Me.gpo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpo.Controls.Add(Me.tab)
        Me.gpo.Location = New System.Drawing.Point(54, 344)
        Me.gpo.Name = "gpo"
        Me.gpo.Size = New System.Drawing.Size(695, 203)
        Me.gpo.TabIndex = 20
        Me.gpo.TabStop = False
        '
        'tab
        '
        Me.tab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tab.ColumnCount = 1
        Me.tab.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tab.Controls.Add(Me.DgvCuentas, 0, 0)
        Me.tab.Controls.Add(Me.Panel1, 0, 2)
        Me.tab.Location = New System.Drawing.Point(6, 19)
        Me.tab.Name = "tab"
        Me.tab.RowCount = 2
        Me.tab.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tab.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tab.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tab.Size = New System.Drawing.Size(683, 178)
        Me.tab.TabIndex = 4
        '
        'DgvCuentas
        '
        Me.DgvCuentas.AllowUserToAddRows = False
        Me.DgvCuentas.AllowUserToDeleteRows = False
        Me.DgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClmCtaMayor, Me.ClmSubCta, Me.ClmSsbCta, Me.ClmSssCta, Me.ClmDescripcion, Me.ClmCargo, Me.ClmAbono, Me.IdCuentaContable, Me.Posicion})
        Me.DgvCuentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvCuentas.Location = New System.Drawing.Point(3, 3)
        Me.DgvCuentas.Name = "DgvCuentas"
        Me.DgvCuentas.RowHeadersVisible = False
        Me.DgvCuentas.Size = New System.Drawing.Size(677, 134)
        Me.DgvCuentas.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtAbono)
        Me.Panel1.Controls.Add(Me.txtCargo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 148)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(683, 30)
        Me.Panel1.TabIndex = 4
        '
        'txtAbono
        '
        Me.txtAbono.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtAbono.Decimales = CType(2UI, UInteger)
        Me.txtAbono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbono.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtAbono.Location = New System.Drawing.Point(585, 4)
        Me.txtAbono.Margin = New System.Windows.Forms.Padding(0)
        Me.txtAbono.Name = "txtAbono"
        Me.txtAbono.ReadOnly = True
        Me.txtAbono.Signo = Integra.Controles.TextboxDecimal.RespuestaEnum.NO
        Me.txtAbono.Size = New System.Drawing.Size(90, 22)
        Me.txtAbono.TabIndex = 1
        Me.txtAbono.TabStop = False
        Me.txtAbono.Text = "0.00"
        Me.txtAbono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCargo
        '
        Me.txtCargo.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCargo.Decimales = CType(2UI, UInteger)
        Me.txtCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCargo.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtCargo.Location = New System.Drawing.Point(496, 4)
        Me.txtCargo.Margin = New System.Windows.Forms.Padding(0)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.ReadOnly = True
        Me.txtCargo.Signo = Integra.Controles.TextboxDecimal.RespuestaEnum.NO
        Me.txtCargo.Size = New System.Drawing.Size(90, 22)
        Me.txtCargo.TabIndex = 0
        Me.txtCargo.TabStop = False
        Me.txtCargo.Text = "0.00"
        Me.txtCargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ClmCtaMayor
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ClmCtaMayor.DefaultCellStyle = DataGridViewCellStyle1
        Me.ClmCtaMayor.HeaderText = "Cta. Mayor"
        Me.ClmCtaMayor.Name = "ClmCtaMayor"
        Me.ClmCtaMayor.ReadOnly = True
        Me.ClmCtaMayor.Width = 85
        '
        'ClmSubCta
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ClmSubCta.DefaultCellStyle = DataGridViewCellStyle2
        Me.ClmSubCta.HeaderText = "Sub Cta."
        Me.ClmSubCta.Name = "ClmSubCta"
        Me.ClmSubCta.ReadOnly = True
        Me.ClmSubCta.Width = 75
        '
        'ClmSsbCta
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ClmSsbCta.DefaultCellStyle = DataGridViewCellStyle3
        Me.ClmSsbCta.HeaderText = "Ssb Cta."
        Me.ClmSsbCta.Name = "ClmSsbCta"
        Me.ClmSsbCta.ReadOnly = True
        Me.ClmSsbCta.Width = 75
        '
        'ClmSssCta
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ClmSssCta.DefaultCellStyle = DataGridViewCellStyle4
        Me.ClmSssCta.HeaderText = "Sss Cta."
        Me.ClmSssCta.Name = "ClmSssCta"
        Me.ClmSssCta.ReadOnly = True
        Me.ClmSssCta.Width = 75
        '
        'ClmDescripcion
        '
        Me.ClmDescripcion.HeaderText = "Descripción"
        Me.ClmDescripcion.Name = "ClmDescripcion"
        Me.ClmDescripcion.ReadOnly = True
        Me.ClmDescripcion.Width = 150
        '
        'ClmCargo
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.PapayaWhip
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.ClmCargo.DefaultCellStyle = DataGridViewCellStyle5
        Me.ClmCargo.HeaderText = "Cargo"
        Me.ClmCargo.Name = "ClmCargo"
        Me.ClmCargo.ReadOnly = True
        '
        'ClmAbono
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Wheat
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.ClmAbono.DefaultCellStyle = DataGridViewCellStyle6
        Me.ClmAbono.HeaderText = "Abono"
        Me.ClmAbono.Name = "ClmAbono"
        Me.ClmAbono.ReadOnly = True
        '
        'IdCuentaContable
        '
        Me.IdCuentaContable.HeaderText = "IdCuentaContable"
        Me.IdCuentaContable.Name = "IdCuentaContable"
        Me.IdCuentaContable.Visible = False
        '
        'Posicion
        '
        Me.Posicion.HeaderText = "Posicion"
        Me.Posicion.Name = "Posicion"
        Me.Posicion.Visible = False
        '
        'CancelacionIngresosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 560)
        Me.Controls.Add(Me.gpo)
        Me.Controls.Add(Me.pan)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(766, 588)
        Me.MinimumSize = New System.Drawing.Size(766, 588)
        Me.Name = "CancelacionIngresosForm"
        Me.Text = "Cancelación de Depositos"
        Me.pan.ResumeLayout(False)
        Me.pan.PerformLayout()
        Me.gpoCuentas.ResumeLayout(False)
        Me.gpoCuentas.PerformLayout()
        Me.gpo.ResumeLayout(False)
        Me.tab.ResumeLayout(False)
        CType(Me.DgvCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    'ojo
    'Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents pan As System.Windows.Forms.Panel
    Friend WithEvents txtPoliza As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtReferencia As System.Windows.Forms.TextBox
    Friend WithEvents chkElectronico As System.Windows.Forms.CheckBox
    Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
    Friend WithEvents txtImporteLetra As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoCambio As Integra.Controles.TextboxDecimal
    Friend WithEvents txtImporte As Integra.Controles.TextboxDecimal
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents gpoCuentas As System.Windows.Forms.GroupBox
    Friend WithEvents lv As System.Windows.Forms.ListView
    Friend WithEvents chCuenta As System.Windows.Forms.ColumnHeader
    Friend WithEvents chDescripcion As System.Windows.Forms.ColumnHeader
    Friend WithEvents chTipoMoneda As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblRef As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbBanco As System.Windows.Forms.ComboBox
    Friend WithEvents txtBanco As System.Windows.Forms.TextBox
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents Ingresos As ClasesNegocio.ChequeCollectionClass
    Friend WithEvents ImprimirCheque As ClasesNegocio.PrintDocumentChequeClass
    Friend WithEvents PagoElectronico As ClasesNegocio.PrintDocumentPagoElectronicoClass
    Friend WithEvents pDg As System.Windows.Forms.PrintDialog
    Friend WithEvents gpo As System.Windows.Forms.GroupBox
    Friend WithEvents tab As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DgvCuentas As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtAbono As Integra.Controles.TextboxDecimal
    Friend WithEvents txtCargo As Integra.Controles.TextboxDecimal
    Friend WithEvents Bancos As ClasesNegocio.BancosCollectionClass
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents chkAnticipo As System.Windows.Forms.CheckBox
    Friend WithEvents ClmCtaMayor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmSubCta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmSsbCta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmSssCta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmCargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmAbono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdCuentaContable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Posicion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
