<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroChequeForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistroChequeForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Cheques = New ClasesNegocio.ChequeCollectionClass()
        Me.mtb = New MEAToolBar.MEAToolBar()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pan = New System.Windows.Forms.Panel()
        Me.txtTipoCambio = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCodBeneficiario = New System.Windows.Forms.TextBox()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.txtPoliza = New System.Windows.Forms.TextBox()
        Me.txtReferencia = New System.Windows.Forms.TextBox()
        Me.chkElectronico = New System.Windows.Forms.CheckBox()
        Me.chkAnticipo = New System.Windows.Forms.CheckBox()
        Me.txtConcepto = New System.Windows.Forms.TextBox()
        Me.txtImporteLetra = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gpoCuentas = New System.Windows.Forms.GroupBox()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.lv = New System.Windows.Forms.ListView()
        Me.chCuenta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDescripcion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTipoMoneda = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblRef = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbBeneficiario = New System.Windows.Forms.ComboBox()
        Me.Beneficiarios = New ClasesNegocio.BeneficiarioCollectionClass()
        Me.cmbBanco = New System.Windows.Forms.ComboBox()
        Me.Bancos = New ClasesNegocio.BancosCollectionClass()
        Me.txtFolio = New System.Windows.Forms.TextBox()
        Me.txtBanco = New System.Windows.Forms.TextBox()
        Me.ImprimirCheque = New ClasesNegocio.PrintDocumentChequeClass()
        Me.pDg = New System.Windows.Forms.PrintDialog()
        Me.PagoElectronico = New ClasesNegocio.PrintDocumentPagoElectronicoClass()
        Me.ppDg = New System.Windows.Forms.PrintPreviewDialog()
        Me.GrpCuentas = New System.Windows.Forms.GroupBox()
        Me.dgvdistribuciongastosdet = New System.Windows.Forms.DataGridView()
        Me.sucursal1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prorrateo1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cuenta1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cod_centro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idporcentaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvDistribuciondeGastos = New System.Windows.Forms.DataGridView()
        Me.clmIdPoliza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmSucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmMetodoProrrateo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCuentaContable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPorcentaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtAbono = New System.Windows.Forms.TextBox()
        Me.txtCargo = New System.Windows.Forms.TextBox()
        Me.DgvCuentas = New System.Windows.Forms.DataGridView()
        Me.ClmCtaMayor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmSubCta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmSsbCta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmSssCta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmCargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmAbono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmidcuentacont = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pan.SuspendLayout()
        Me.gpoCuentas.SuspendLayout()
        Me.GrpCuentas.SuspendLayout()
        CType(Me.dgvdistribuciongastosdet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDistribuciondeGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cheques
        '
        Me.Cheques.AllowEdit = True
        Me.Cheques.AllowNew = True
        Me.Cheques.AllowRemove = True
        Me.Cheques.MaximoElementosSeleccionados = 1
        Me.Cheques.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.Cheques.MostrarAlertas = False
        Me.Cheques.Name = Nothing
        Me.Cheques.RaiseListChangedEvents = True
        Me.Cheques.Transaction = Nothing
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
        Me.mtb.Size = New System.Drawing.Size(50, 560)
        Me.mtb.TabIndex = 0
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
        Me.lblTitulo.Size = New System.Drawing.Size(711, 30)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Label1"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pan
        '
        Me.pan.Controls.Add(Me.txtTipoCambio)
        Me.pan.Controls.Add(Me.Label11)
        Me.pan.Controls.Add(Me.txtCodBeneficiario)
        Me.pan.Controls.Add(Me.txtImporte)
        Me.pan.Controls.Add(Me.txtPoliza)
        Me.pan.Controls.Add(Me.txtReferencia)
        Me.pan.Controls.Add(Me.chkElectronico)
        Me.pan.Controls.Add(Me.chkAnticipo)
        Me.pan.Controls.Add(Me.txtConcepto)
        Me.pan.Controls.Add(Me.txtImporteLetra)
        Me.pan.Controls.Add(Me.Label2)
        Me.pan.Controls.Add(Me.dtp)
        Me.pan.Controls.Add(Me.Label8)
        Me.pan.Controls.Add(Me.gpoCuentas)
        Me.pan.Controls.Add(Me.Label4)
        Me.pan.Controls.Add(Me.Label5)
        Me.pan.Controls.Add(Me.Label9)
        Me.pan.Controls.Add(Me.Label7)
        Me.pan.Controls.Add(Me.Label3)
        Me.pan.Controls.Add(Me.lblRef)
        Me.pan.Controls.Add(Me.Label1)
        Me.pan.Controls.Add(Me.cmbBeneficiario)
        Me.pan.Controls.Add(Me.cmbBanco)
        Me.pan.Controls.Add(Me.txtFolio)
        Me.pan.Controls.Add(Me.txtBanco)
        Me.pan.Location = New System.Drawing.Point(55, 33)
        Me.pan.Name = "pan"
        Me.pan.Size = New System.Drawing.Size(696, 331)
        Me.pan.TabIndex = 2
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtTipoCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCambio.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtTipoCambio.Location = New System.Drawing.Point(98, 273)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.ReadOnly = True
        Me.txtTipoCambio.Size = New System.Drawing.Size(87, 22)
        Me.txtTipoCambio.TabIndex = 12
        Me.txtTipoCambio.Text = "0.00"
        Me.txtTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 221)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "No. Beneficiario:"
        '
        'txtCodBeneficiario
        '
        Me.txtCodBeneficiario.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCodBeneficiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodBeneficiario.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtCodBeneficiario.Location = New System.Drawing.Point(98, 216)
        Me.txtCodBeneficiario.Name = "txtCodBeneficiario"
        Me.txtCodBeneficiario.ReadOnly = True
        Me.txtCodBeneficiario.Size = New System.Drawing.Size(87, 22)
        Me.txtCodBeneficiario.TabIndex = 9
        Me.txtCodBeneficiario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtImporte
        '
        Me.txtImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporte.Location = New System.Drawing.Point(98, 244)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(87, 22)
        Me.txtImporte.TabIndex = 11
        Me.txtImporte.Text = "0.00"
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPoliza
        '
        Me.txtPoliza.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtPoliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPoliza.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtPoliza.Location = New System.Drawing.Point(567, 302)
        Me.txtPoliza.Name = "txtPoliza"
        Me.txtPoliza.ReadOnly = True
        Me.txtPoliza.Size = New System.Drawing.Size(117, 22)
        Me.txtPoliza.TabIndex = 15
        Me.txtPoliza.TabStop = False
        '
        'txtReferencia
        '
        Me.txtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReferencia.Enabled = False
        Me.txtReferencia.Location = New System.Drawing.Point(282, 193)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(191, 20)
        Me.txtReferencia.TabIndex = 7
        '
        'chkElectronico
        '
        Me.chkElectronico.Location = New System.Drawing.Point(101, 191)
        Me.chkElectronico.Name = "chkElectronico"
        Me.chkElectronico.Size = New System.Drawing.Size(107, 24)
        Me.chkElectronico.TabIndex = 6
        Me.chkElectronico.Text = "Es Electronico"
        Me.chkElectronico.UseVisualStyleBackColor = True
        '
        'chkAnticipo
        '
        Me.chkAnticipo.Location = New System.Drawing.Point(10, 191)
        Me.chkAnticipo.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.chkAnticipo.Name = "chkAnticipo"
        Me.chkAnticipo.Size = New System.Drawing.Size(89, 24)
        Me.chkAnticipo.TabIndex = 5
        Me.chkAnticipo.Text = "Es Anticipo"
        Me.chkAnticipo.UseVisualStyleBackColor = True
        '
        'txtConcepto
        '
        Me.txtConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConcepto.Location = New System.Drawing.Point(98, 302)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(421, 22)
        Me.txtConcepto.TabIndex = 14
        '
        'txtImporteLetra
        '
        Me.txtImporteLetra.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtImporteLetra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporteLetra.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtImporteLetra.Location = New System.Drawing.Point(191, 243)
        Me.txtImporteLetra.Multiline = True
        Me.txtImporteLetra.Name = "txtImporteLetra"
        Me.txtImporteLetra.ReadOnly = True
        Me.txtImporteLetra.Size = New System.Drawing.Size(493, 53)
        Me.txtImporteLetra.TabIndex = 13
        Me.txtImporteLetra.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(479, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha:"
        '
        'dtp
        '
        Me.dtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp.Location = New System.Drawing.Point(525, 12)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(118, 20)
        Me.dtp.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 277)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "T.C. :"
        '
        'gpoCuentas
        '
        Me.gpoCuentas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpoCuentas.Controls.Add(Me.txtSaldo)
        Me.gpoCuentas.Controls.Add(Me.lv)
        Me.gpoCuentas.Controls.Add(Me.Label6)
        Me.gpoCuentas.Controls.Add(Me.txtCuenta)
        Me.gpoCuentas.Location = New System.Drawing.Point(10, 38)
        Me.gpoCuentas.Name = "gpoCuentas"
        Me.gpoCuentas.Size = New System.Drawing.Size(680, 147)
        Me.gpoCuentas.TabIndex = 4
        Me.gpoCuentas.TabStop = False
        Me.gpoCuentas.Text = "Cuentas"
        '
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtSaldo.Location = New System.Drawing.Point(500, 119)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.Size = New System.Drawing.Size(174, 22)
        Me.txtSaldo.TabIndex = 2
        Me.txtSaldo.TabStop = False
        Me.txtSaldo.Text = "0.00"
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.lv.Size = New System.Drawing.Size(668, 96)
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
        'txtCuenta
        '
        Me.txtCuenta.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtCuenta.Location = New System.Drawing.Point(124, 119)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.ReadOnly = True
        Me.txtCuenta.Size = New System.Drawing.Size(367, 22)
        Me.txtCuenta.TabIndex = 1
        Me.txtCuenta.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Importe: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 305)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Concepto:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(525, 305)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Poliza:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(479, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Num. Cheque:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(211, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Beneficiario:"
        '
        'lblRef
        '
        Me.lblRef.AutoSize = True
        Me.lblRef.Location = New System.Drawing.Point(214, 196)
        Me.lblRef.Name = "lblRef"
        Me.lblRef.Size = New System.Drawing.Size(62, 13)
        Me.lblRef.TabIndex = 6
        Me.lblRef.Text = "Referencia:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Banco:"
        '
        'cmbBeneficiario
        '
        Me.cmbBeneficiario.DataSource = Me.Beneficiarios
        Me.cmbBeneficiario.DisplayMember = "Beneficiario"
        Me.cmbBeneficiario.FormattingEnabled = True
        Me.cmbBeneficiario.Location = New System.Drawing.Point(282, 217)
        Me.cmbBeneficiario.Name = "cmbBeneficiario"
        Me.cmbBeneficiario.Size = New System.Drawing.Size(402, 21)
        Me.cmbBeneficiario.TabIndex = 10
        Me.cmbBeneficiario.ValueMember = "Beneficiario"
        '
        'Beneficiarios
        '
        Me.Beneficiarios.AllowEdit = True
        Me.Beneficiarios.AllowNew = True
        Me.Beneficiarios.AllowRemove = True
        Me.Beneficiarios.Name = Nothing
        Me.Beneficiarios.RaiseListChangedEvents = True
        '
        'cmbBanco
        '
        Me.cmbBanco.DataSource = Me.Bancos
        Me.cmbBanco.DisplayMember = "Descripcion"
        Me.cmbBanco.FormattingEnabled = True
        Me.cmbBanco.Location = New System.Drawing.Point(191, 12)
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
        'txtFolio
        '
        Me.txtFolio.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtFolio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFolio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFolio.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtFolio.Location = New System.Drawing.Point(567, 191)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.ReadOnly = True
        Me.txtFolio.Size = New System.Drawing.Size(117, 22)
        Me.txtFolio.TabIndex = 8
        Me.txtFolio.TabStop = False
        '
        'txtBanco
        '
        Me.txtBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBanco.Location = New System.Drawing.Point(85, 12)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(100, 20)
        Me.txtBanco.TabIndex = 1
        '
        'ImprimirCheque
        '
        Me.ImprimirCheque.AbonoEnCuenta = System.Windows.Forms.DialogResult.No
        Me.ImprimirCheque.Banco = 0
        Me.ImprimirCheque.Cheque = Nothing
        '
        'pDg
        '
        Me.pDg.UseEXDialog = True
        '
        'PagoElectronico
        '
        Me.PagoElectronico.Cheque = Nothing
        '
        'ppDg
        '
        Me.ppDg.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.ppDg.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.ppDg.ClientSize = New System.Drawing.Size(400, 300)
        Me.ppDg.Document = Me.ImprimirCheque
        Me.ppDg.Enabled = True
        Me.ppDg.Icon = CType(resources.GetObject("ppDg.Icon"), System.Drawing.Icon)
        Me.ppDg.Name = "ppDg"
        Me.ppDg.Visible = False
        '
        'GrpCuentas
        '
        Me.GrpCuentas.Controls.Add(Me.dgvdistribuciongastosdet)
        Me.GrpCuentas.Controls.Add(Me.dgvDistribuciondeGastos)
        Me.GrpCuentas.Controls.Add(Me.Label16)
        Me.GrpCuentas.Controls.Add(Me.txtAbono)
        Me.GrpCuentas.Controls.Add(Me.txtCargo)
        Me.GrpCuentas.Controls.Add(Me.DgvCuentas)
        Me.GrpCuentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpCuentas.Location = New System.Drawing.Point(65, 370)
        Me.GrpCuentas.Name = "GrpCuentas"
        Me.GrpCuentas.Size = New System.Drawing.Size(674, 161)
        Me.GrpCuentas.TabIndex = 146
        Me.GrpCuentas.TabStop = False
        '
        'dgvdistribuciongastosdet
        '
        Me.dgvdistribuciongastosdet.AllowUserToAddRows = False
        Me.dgvdistribuciongastosdet.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvdistribuciongastosdet.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvdistribuciongastosdet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdistribuciongastosdet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sucursal1, Me.Prorrateo1, Me.Cuenta1, Me.cod_centro, Me.idporcentaje})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvdistribuciongastosdet.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvdistribuciongastosdet.Location = New System.Drawing.Point(-4, 81)
        Me.dgvdistribuciongastosdet.Name = "dgvdistribuciongastosdet"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvdistribuciongastosdet.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvdistribuciongastosdet.RowHeadersVisible = False
        Me.dgvdistribuciongastosdet.Size = New System.Drawing.Size(235, 88)
        Me.dgvdistribuciongastosdet.TabIndex = 166
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
        'dgvDistribuciondeGastos
        '
        Me.dgvDistribuciondeGastos.AllowUserToAddRows = False
        Me.dgvDistribuciondeGastos.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDistribuciondeGastos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDistribuciondeGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDistribuciondeGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmIdPoliza, Me.clmSucursal, Me.clmMetodoProrrateo, Me.clmCuentaContable, Me.clmImporte, Me.clmPorcentaje})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDistribuciondeGastos.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvDistribuciondeGastos.Location = New System.Drawing.Point(238, 84)
        Me.dgvDistribuciondeGastos.Name = "dgvDistribuciondeGastos"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDistribuciondeGastos.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvDistribuciondeGastos.RowHeadersVisible = False
        Me.dgvDistribuciondeGastos.Size = New System.Drawing.Size(410, 104)
        Me.dgvDistribuciondeGastos.TabIndex = 165
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
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(9, 137)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(405, 13)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "<Presione F3 para ver el listado de Cuentas Contables del Proveedor>"
        '
        'txtAbono
        '
        Me.txtAbono.Enabled = False
        Me.txtAbono.Location = New System.Drawing.Point(566, 137)
        Me.txtAbono.Name = "txtAbono"
        Me.txtAbono.Size = New System.Drawing.Size(100, 20)
        Me.txtAbono.TabIndex = 2
        '
        'txtCargo
        '
        Me.txtCargo.Enabled = False
        Me.txtCargo.Location = New System.Drawing.Point(462, 137)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(100, 20)
        Me.txtCargo.TabIndex = 1
        '
        'DgvCuentas
        '
        Me.DgvCuentas.AllowUserToAddRows = False
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvCuentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClmCtaMayor, Me.ClmSubCta, Me.ClmSsbCta, Me.ClmSssCta, Me.ClmDescripcion, Me.ClmCargo, Me.ClmAbono, Me.clmidcuentacont})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvCuentas.DefaultCellStyle = DataGridViewCellStyle10
        Me.DgvCuentas.Location = New System.Drawing.Point(3, 16)
        Me.DgvCuentas.Name = "DgvCuentas"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvCuentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DgvCuentas.RowHeadersVisible = False
        Me.DgvCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCuentas.Size = New System.Drawing.Size(663, 117)
        Me.DgvCuentas.TabIndex = 0
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
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle8.Format = "C2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.ClmCargo.DefaultCellStyle = DataGridViewCellStyle8
        Me.ClmCargo.HeaderText = "Cargo"
        Me.ClmCargo.Name = "ClmCargo"
        '
        'ClmAbono
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle9.Format = "C2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.ClmAbono.DefaultCellStyle = DataGridViewCellStyle9
        Me.ClmAbono.HeaderText = "Abono"
        Me.ClmAbono.Name = "ClmAbono"
        '
        'clmidcuentacont
        '
        Me.clmidcuentacont.HeaderText = "clmidcuentacont"
        Me.clmidcuentacont.Name = "clmidcuentacont"
        Me.clmidcuentacont.ReadOnly = True
        Me.clmidcuentacont.Visible = False
        '
        'RegistroChequeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 560)
        Me.Controls.Add(Me.GrpCuentas)
        Me.Controls.Add(Me.pan)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(766, 588)
        Me.MinimumSize = New System.Drawing.Size(766, 588)
        Me.Name = "RegistroChequeForm"
        Me.Text = "Registro de Cheques y Pagos electrónicos"
        Me.pan.ResumeLayout(False)
        Me.pan.PerformLayout()
        Me.gpoCuentas.ResumeLayout(False)
        Me.gpoCuentas.PerformLayout()
        Me.GrpCuentas.ResumeLayout(False)
        Me.GrpCuentas.PerformLayout()
        CType(Me.dgvdistribuciongastosdet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDistribuciondeGastos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents pan As System.Windows.Forms.Panel
    Friend WithEvents gpoCuentas As System.Windows.Forms.GroupBox
    Friend WithEvents lv As System.Windows.Forms.ListView
    Friend WithEvents chCuenta As System.Windows.Forms.ColumnHeader
    Friend WithEvents chDescripcion As System.Windows.Forms.ColumnHeader
    Friend WithEvents chTipoMoneda As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbBanco As System.Windows.Forms.ComboBox
    Friend WithEvents txtBanco As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbBeneficiario As System.Windows.Forms.ComboBox
    Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
    Friend WithEvents txtImporteLetra As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Cheques As ClasesNegocio.ChequeCollectionClass
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents FechaGeneraciónDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkAnticipo As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents Beneficiarios As ClasesNegocio.BeneficiarioCollectionClass
    Friend WithEvents chkElectronico As System.Windows.Forms.CheckBox
    Friend WithEvents txtReferencia As System.Windows.Forms.TextBox
    Friend WithEvents lblRef As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    'ojo
    'Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents ImprimirCheque As ClasesNegocio.PrintDocumentChequeClass
    Friend WithEvents pDg As System.Windows.Forms.PrintDialog
    Friend WithEvents PagoElectronico As ClasesNegocio.PrintDocumentPagoElectronicoClass
    Friend WithEvents txtPoliza As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ppDg As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Bancos As ClasesNegocio.BancosCollectionClass
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCodBeneficiario As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoCambio As System.Windows.Forms.TextBox
    Friend WithEvents GrpCuentas As System.Windows.Forms.GroupBox
    Friend WithEvents dgvdistribuciongastosdet As System.Windows.Forms.DataGridView
    Friend WithEvents sucursal1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Prorrateo1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cuenta1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cod_centro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idporcentaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvDistribuciondeGastos As System.Windows.Forms.DataGridView
    Friend WithEvents clmIdPoliza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSucursal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmMetodoProrrateo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCuentaContable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPorcentaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtAbono As System.Windows.Forms.TextBox
    Friend WithEvents txtCargo As System.Windows.Forms.TextBox
    Friend WithEvents DgvCuentas As System.Windows.Forms.DataGridView
    Friend WithEvents ClmCtaMayor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmSubCta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmSsbCta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmSssCta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmCargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmAbono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmidcuentacont As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
