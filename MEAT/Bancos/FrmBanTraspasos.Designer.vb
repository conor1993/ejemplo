<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBanTraspasos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.pan = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lvCuentasBancariasdestino = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtSaldoCuentaDestino = New System.Windows.Forms.TextBox
        Me.txtCuentaDestino = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmbBancoDestino = New System.Windows.Forms.ComboBox
        Me.BancosDestino = New ClasesNegocio.BancosCollectionClass
        Me.txtBancoDestino = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtp = New System.Windows.Forms.DateTimePicker
        Me.gpoCuentas = New System.Windows.Forms.GroupBox
        Me.lv = New System.Windows.Forms.ListView
        Me.chCuenta = New System.Windows.Forms.ColumnHeader
        Me.chDescripcion = New System.Windows.Forms.ColumnHeader
        Me.chTipoMoneda = New System.Windows.Forms.ColumnHeader
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtSaldo = New System.Windows.Forms.TextBox
        Me.txtCuenta = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbBanco = New System.Windows.Forms.ComboBox
        Me.Bancos = New ClasesNegocio.BancosCollectionClass
        Me.txtBanco = New System.Windows.Forms.TextBox
        Me.txtPoliza = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtFolio = New Integra.Controles.TextboxInteger
        Me.txtReferencia = New System.Windows.Forms.TextBox
        Me.chkElectronico = New System.Windows.Forms.CheckBox
        Me.txtConcepto = New System.Windows.Forms.TextBox
        Me.txtImporteLetra = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblRef = New System.Windows.Forms.Label
        Me.gpo = New System.Windows.Forms.GroupBox
        Me.tab = New System.Windows.Forms.TableLayoutPanel
        Me.DgvCuentas = New System.Windows.Forms.DataGridView
        Me.ClmCtaMayor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmSubCta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmSsbCta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmSssCta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmCargo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmAbono = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtAbono = New System.Windows.Forms.TextBox
        Me.txtCargo = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.ImprimirCheque = New ClasesNegocio.PrintDocumentChequeClass
        Me.PagoElectronico = New ClasesNegocio.PrintDocumentPagoElectronicoClass
        Me.pDg = New System.Windows.Forms.PrintDialog
        Me.Abonos = New ClasesNegocio.ChequeCollectionClass
        Me.txtImporte = New System.Windows.Forms.TextBox
        Me.txtTipoCambio = New System.Windows.Forms.TextBox
        Me.pan.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gpoCuentas.SuspendLayout()
        Me.gpo.SuspendLayout()
        Me.tab.SuspendLayout()
        CType(Me.DgvCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.mtb.HabilitarEditar = False
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
        Me.mtb.Size = New System.Drawing.Size(50, 652)
        Me.mtb.TabIndex = 7
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
        Me.lblTitulo.Size = New System.Drawing.Size(713, 30)
        Me.lblTitulo.TabIndex = 8
        Me.lblTitulo.Text = "Label1"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pan
        '
        Me.pan.Controls.Add(Me.GroupBox1)
        Me.pan.Controls.Add(Me.Label10)
        Me.pan.Controls.Add(Me.cmbBancoDestino)
        Me.pan.Controls.Add(Me.txtBancoDestino)
        Me.pan.Controls.Add(Me.Label2)
        Me.pan.Controls.Add(Me.dtp)
        Me.pan.Controls.Add(Me.gpoCuentas)
        Me.pan.Controls.Add(Me.Label1)
        Me.pan.Controls.Add(Me.cmbBanco)
        Me.pan.Controls.Add(Me.txtBanco)
        Me.pan.Location = New System.Drawing.Point(55, 33)
        Me.pan.Name = "pan"
        Me.pan.Size = New System.Drawing.Size(699, 338)
        Me.pan.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lvCuentasBancariasdestino)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtSaldoCuentaDestino)
        Me.GroupBox1.Controls.Add(Me.txtCuentaDestino)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 197)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(683, 138)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cuentas"
        '
        'lvCuentasBancariasdestino
        '
        Me.lvCuentasBancariasdestino.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvCuentasBancariasdestino.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvCuentasBancariasdestino.FullRowSelect = True
        Me.lvCuentasBancariasdestino.Location = New System.Drawing.Point(6, 19)
        Me.lvCuentasBancariasdestino.MultiSelect = False
        Me.lvCuentasBancariasdestino.Name = "lvCuentasBancariasdestino"
        Me.lvCuentasBancariasdestino.Size = New System.Drawing.Size(671, 83)
        Me.lvCuentasBancariasdestino.TabIndex = 0
        Me.lvCuentasBancariasdestino.UseCompatibleStateImageBehavior = False
        Me.lvCuentasBancariasdestino.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "N� Cuenta"
        Me.ColumnHeader1.Width = 200
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Descripci�n"
        Me.ColumnHeader2.Width = 300
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Tipo de Moneda"
        Me.ColumnHeader3.Width = 100
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Cuenta Seleccionada:"
        '
        'txtSaldoCuentaDestino
        '
        Me.txtSaldoCuentaDestino.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSaldoCuentaDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoCuentaDestino.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtSaldoCuentaDestino.Location = New System.Drawing.Point(457, 108)
        Me.txtSaldoCuentaDestino.Name = "txtSaldoCuentaDestino"
        Me.txtSaldoCuentaDestino.ReadOnly = True
        Me.txtSaldoCuentaDestino.Size = New System.Drawing.Size(220, 22)
        Me.txtSaldoCuentaDestino.TabIndex = 3
        Me.txtSaldoCuentaDestino.TabStop = False
        Me.txtSaldoCuentaDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCuentaDestino
        '
        Me.txtCuentaDestino.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCuentaDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaDestino.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtCuentaDestino.Location = New System.Drawing.Point(123, 108)
        Me.txtCuentaDestino.Name = "txtCuentaDestino"
        Me.txtCuentaDestino.ReadOnly = True
        Me.txtCuentaDestino.Size = New System.Drawing.Size(329, 22)
        Me.txtCuentaDestino.TabIndex = 2
        Me.txtCuentaDestino.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 176)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Banco Destino :"
        '
        'cmbBancoDestino
        '
        Me.cmbBancoDestino.DataSource = Me.BancosDestino
        Me.cmbBancoDestino.DisplayMember = "Descripcion"
        Me.cmbBancoDestino.Enabled = False
        Me.cmbBancoDestino.FormattingEnabled = True
        Me.cmbBancoDestino.Location = New System.Drawing.Point(200, 173)
        Me.cmbBancoDestino.Name = "cmbBancoDestino"
        Me.cmbBancoDestino.Size = New System.Drawing.Size(272, 21)
        Me.cmbBancoDestino.TabIndex = 16
        Me.cmbBancoDestino.ValueMember = "DescripcionCta"
        '
        'BancosDestino
        '
        Me.BancosDestino.AllowEdit = True
        Me.BancosDestino.AllowNew = True
        Me.BancosDestino.AllowRemove = True
        Me.BancosDestino.Name = ""
        Me.BancosDestino.RaiseListChangedEvents = True
        '
        'txtBancoDestino
        '
        Me.txtBancoDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBancoDestino.Enabled = False
        Me.txtBancoDestino.Location = New System.Drawing.Point(94, 173)
        Me.txtBancoDestino.Name = "txtBancoDestino"
        Me.txtBancoDestino.Size = New System.Drawing.Size(100, 20)
        Me.txtBancoDestino.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(480, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha:"
        '
        'dtp
        '
        Me.dtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp.Location = New System.Drawing.Point(526, 8)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(118, 20)
        Me.dtp.TabIndex = 4
        '
        'gpoCuentas
        '
        Me.gpoCuentas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpoCuentas.Controls.Add(Me.lv)
        Me.gpoCuentas.Controls.Add(Me.Label6)
        Me.gpoCuentas.Controls.Add(Me.txtSaldo)
        Me.gpoCuentas.Controls.Add(Me.txtCuenta)
        Me.gpoCuentas.Location = New System.Drawing.Point(10, 34)
        Me.gpoCuentas.Name = "gpoCuentas"
        Me.gpoCuentas.Size = New System.Drawing.Size(683, 133)
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
        Me.lv.Location = New System.Drawing.Point(6, 17)
        Me.lv.MultiSelect = False
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(671, 82)
        Me.lv.TabIndex = 0
        Me.lv.UseCompatibleStateImageBehavior = False
        Me.lv.View = System.Windows.Forms.View.Details
        '
        'chCuenta
        '
        Me.chCuenta.Text = "N� Cuenta"
        Me.chCuenta.Width = 200
        '
        'chDescripcion
        '
        Me.chDescripcion.Text = "Descripci�n"
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
        Me.Label6.Location = New System.Drawing.Point(3, 110)
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
        Me.txtSaldo.Location = New System.Drawing.Point(455, 105)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.Size = New System.Drawing.Size(221, 22)
        Me.txtSaldo.TabIndex = 3
        Me.txtSaldo.TabStop = False
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCuenta
        '
        Me.txtCuenta.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtCuenta.Location = New System.Drawing.Point(121, 105)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.ReadOnly = True
        Me.txtCuenta.Size = New System.Drawing.Size(329, 22)
        Me.txtCuenta.TabIndex = 2
        Me.txtCuenta.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Banco Origen :"
        '
        'cmbBanco
        '
        Me.cmbBanco.DataSource = Me.Bancos
        Me.cmbBanco.DisplayMember = "Descripcion"
        Me.cmbBanco.FormattingEnabled = True
        Me.cmbBanco.Location = New System.Drawing.Point(200, 8)
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
        Me.txtBanco.Location = New System.Drawing.Point(94, 8)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(100, 20)
        Me.txtBanco.TabIndex = 1
        '
        'txtPoliza
        '
        Me.txtPoliza.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtPoliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPoliza.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtPoliza.Location = New System.Drawing.Point(603, 464)
        Me.txtPoliza.Name = "txtPoliza"
        Me.txtPoliza.ReadOnly = True
        Me.txtPoliza.Size = New System.Drawing.Size(145, 22)
        Me.txtPoliza.TabIndex = 33
        Me.txtPoliza.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(559, 469)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Poliza:"
        '
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(420, 379)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Signo = Integra.Controles.TextboxInteger.RespuestaEnum.NO
        Me.txtFolio.Size = New System.Drawing.Size(100, 20)
        Me.txtFolio.TabIndex = 21
        Me.txtFolio.Text = "0"
        Me.txtFolio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtFolio.Visible = False
        '
        'txtReferencia
        '
        Me.txtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReferencia.Location = New System.Drawing.Point(139, 379)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(148, 20)
        Me.txtReferencia.TabIndex = 24
        '
        'chkElectronico
        '
        Me.chkElectronico.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkElectronico.Location = New System.Drawing.Point(538, 377)
        Me.chkElectronico.Name = "chkElectronico"
        Me.chkElectronico.Size = New System.Drawing.Size(97, 24)
        Me.chkElectronico.TabIndex = 22
        Me.chkElectronico.Text = "Es Electronico"
        Me.chkElectronico.UseVisualStyleBackColor = True
        Me.chkElectronico.Visible = False
        '
        'txtConcepto
        '
        Me.txtConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConcepto.Location = New System.Drawing.Point(139, 464)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(414, 20)
        Me.txtConcepto.TabIndex = 31
        '
        'txtImporteLetra
        '
        Me.txtImporteLetra.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtImporteLetra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporteLetra.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtImporteLetra.Location = New System.Drawing.Point(245, 407)
        Me.txtImporteLetra.Multiline = True
        Me.txtImporteLetra.Name = "txtImporteLetra"
        Me.txtImporteLetra.ReadOnly = True
        Me.txtImporteLetra.Size = New System.Drawing.Size(503, 53)
        Me.txtImporteLetra.TabIndex = 27
        Me.txtImporteLetra.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(61, 436)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "T.C. :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 410)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Importe: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 469)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Concepto:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(339, 382)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Num. Cheque:"
        Me.Label7.Visible = False
        '
        'lblRef
        '
        Me.lblRef.AutoSize = True
        Me.lblRef.Location = New System.Drawing.Point(61, 382)
        Me.lblRef.Name = "lblRef"
        Me.lblRef.Size = New System.Drawing.Size(62, 13)
        Me.lblRef.TabIndex = 23
        Me.lblRef.Text = "Referencia:"
        '
        'gpo
        '
        Me.gpo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpo.Controls.Add(Me.tab)
        Me.gpo.Location = New System.Drawing.Point(55, 486)
        Me.gpo.Name = "gpo"
        Me.gpo.Size = New System.Drawing.Size(699, 154)
        Me.gpo.TabIndex = 34
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
        Me.tab.Size = New System.Drawing.Size(687, 129)
        Me.tab.TabIndex = 4
        '
        'DgvCuentas
        '
        Me.DgvCuentas.AllowUserToAddRows = False
        Me.DgvCuentas.AllowUserToDeleteRows = False
        Me.DgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClmCtaMayor, Me.ClmSubCta, Me.ClmSsbCta, Me.ClmSssCta, Me.ClmDescripcion, Me.ClmCargo, Me.ClmAbono})
        Me.DgvCuentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvCuentas.Location = New System.Drawing.Point(3, 3)
        Me.DgvCuentas.Name = "DgvCuentas"
        Me.DgvCuentas.RowHeadersVisible = False
        Me.DgvCuentas.Size = New System.Drawing.Size(681, 85)
        Me.DgvCuentas.TabIndex = 5
        '
        'ClmCtaMayor
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ClmCtaMayor.DefaultCellStyle = DataGridViewCellStyle1
        Me.ClmCtaMayor.HeaderText = "Cta. May"
        Me.ClmCtaMayor.Name = "ClmCtaMayor"
        Me.ClmCtaMayor.Width = 80
        '
        'ClmSubCta
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ClmSubCta.DefaultCellStyle = DataGridViewCellStyle2
        Me.ClmSubCta.HeaderText = "Sub Cta."
        Me.ClmSubCta.Name = "ClmSubCta"
        Me.ClmSubCta.Width = 75
        '
        'ClmSsbCta
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ClmSsbCta.DefaultCellStyle = DataGridViewCellStyle3
        Me.ClmSsbCta.HeaderText = "Ssb Cta."
        Me.ClmSsbCta.Name = "ClmSsbCta"
        Me.ClmSsbCta.Width = 75
        '
        'ClmSssCta
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ClmSssCta.DefaultCellStyle = DataGridViewCellStyle4
        Me.ClmSssCta.HeaderText = "Sss Cta."
        Me.ClmSssCta.Name = "ClmSssCta"
        Me.ClmSssCta.Width = 75
        '
        'ClmDescripcion
        '
        Me.ClmDescripcion.HeaderText = "Descripci�n"
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
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtAbono)
        Me.Panel1.Controls.Add(Me.txtCargo)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 99)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(687, 30)
        Me.Panel1.TabIndex = 4
        '
        'txtAbono
        '
        Me.txtAbono.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtAbono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbono.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtAbono.Location = New System.Drawing.Point(584, 4)
        Me.txtAbono.Name = "txtAbono"
        Me.txtAbono.ReadOnly = True
        Me.txtAbono.Size = New System.Drawing.Size(100, 22)
        Me.txtAbono.TabIndex = 6
        Me.txtAbono.Text = "0.00"
        Me.txtAbono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCargo
        '
        Me.txtCargo.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCargo.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtCargo.Location = New System.Drawing.Point(485, 4)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.ReadOnly = True
        Me.txtCargo.Size = New System.Drawing.Size(100, 22)
        Me.txtCargo.TabIndex = 5
        Me.txtCargo.Text = "0.00"
        Me.txtCargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.DarkRed
        Me.Label11.Location = New System.Drawing.Point(6, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(300, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "* Para mostrar la Busqueda de Cuentas Contables presione F3"
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
        'Abonos
        '
        Me.Abonos.AllowEdit = True
        Me.Abonos.AllowNew = True
        Me.Abonos.AllowRemove = True
        Me.Abonos.Name = Nothing
        Me.Abonos.RaiseListChangedEvents = True
        '
        'txtImporte
        '
        Me.txtImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporte.Location = New System.Drawing.Point(139, 407)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(100, 22)
        Me.txtImporte.TabIndex = 35
        Me.txtImporte.Text = "0.00"
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtTipoCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCambio.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtTipoCambio.Location = New System.Drawing.Point(139, 436)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.ReadOnly = True
        Me.txtTipoCambio.Size = New System.Drawing.Size(100, 22)
        Me.txtTipoCambio.TabIndex = 36
        Me.txtTipoCambio.Text = "0.00"
        Me.txtTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FrmBanTraspasos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 652)
        Me.Controls.Add(Me.txtTipoCambio)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.gpo)
        Me.Controls.Add(Me.txtPoliza)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.txtReferencia)
        Me.Controls.Add(Me.chkElectronico)
        Me.Controls.Add(Me.txtConcepto)
        Me.Controls.Add(Me.txtImporteLetra)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblRef)
        Me.Controls.Add(Me.pan)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.mtb)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(771, 686)
        Me.MinimumSize = New System.Drawing.Size(771, 686)
        Me.Name = "FrmBanTraspasos"
        Me.Text = "Traspasos Bancarios"
        Me.pan.ResumeLayout(False)
        Me.pan.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents pan As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents gpoCuentas As System.Windows.Forms.GroupBox
    Friend WithEvents lv As System.Windows.Forms.ListView
    Friend WithEvents chCuenta As System.Windows.Forms.ColumnHeader
    Friend WithEvents chDescripcion As System.Windows.Forms.ColumnHeader
    Friend WithEvents chTipoMoneda As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbBanco As System.Windows.Forms.ComboBox
    Friend WithEvents txtBanco As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lvCuentasBancariasdestino As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoCuentaDestino As System.Windows.Forms.TextBox
    Friend WithEvents txtCuentaDestino As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbBancoDestino As System.Windows.Forms.ComboBox
    Friend WithEvents txtBancoDestino As System.Windows.Forms.TextBox
    Friend WithEvents txtPoliza As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtFolio As Integra.Controles.TextboxInteger
    Friend WithEvents txtReferencia As System.Windows.Forms.TextBox
    Friend WithEvents chkElectronico As System.Windows.Forms.CheckBox
    Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
    Friend WithEvents txtImporteLetra As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblRef As System.Windows.Forms.Label
    Friend WithEvents gpo As System.Windows.Forms.GroupBox
    Friend WithEvents tab As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DgvCuentas As System.Windows.Forms.DataGridView
    Friend WithEvents ClmCtaMayor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmSubCta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmSsbCta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmSssCta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmCargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmAbono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Bancos As ClasesNegocio.BancosCollectionClass
    Friend WithEvents ImprimirCheque As ClasesNegocio.PrintDocumentChequeClass
    Friend WithEvents PagoElectronico As ClasesNegocio.PrintDocumentPagoElectronicoClass
    Friend WithEvents pDg As System.Windows.Forms.PrintDialog
    Friend WithEvents Abonos As ClasesNegocio.ChequeCollectionClass
    Friend WithEvents BancosDestino As ClasesNegocio.BancosCollectionClass
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTipoCambio As System.Windows.Forms.TextBox
    Friend WithEvents txtAbono As System.Windows.Forms.TextBox
    Friend WithEvents txtCargo As System.Windows.Forms.TextBox
End Class
