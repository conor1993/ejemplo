<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBanAbonosDiversos
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
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.pan = New System.Windows.Forms.Panel
        Me.chkAnticipo = New System.Windows.Forms.CheckBox
        Me.txtTipoCambio = New System.Windows.Forms.TextBox
        Me.txtImporte = New System.Windows.Forms.TextBox
        Me.txtPoliza = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtReferencia = New System.Windows.Forms.TextBox
        Me.chkElectronico = New System.Windows.Forms.CheckBox
        Me.txtConcepto = New System.Windows.Forms.TextBox
        Me.txtImporteLetra = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtp = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.gpoCuentas = New System.Windows.Forms.GroupBox
        Me.lv = New System.Windows.Forms.ListView
        Me.chCuenta = New System.Windows.Forms.ColumnHeader
        Me.chDescripcion = New System.Windows.Forms.ColumnHeader
        Me.chTipoMoneda = New System.Windows.Forms.ColumnHeader
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtSaldo = New System.Windows.Forms.TextBox
        Me.txtCuenta = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblRef = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbBanco = New System.Windows.Forms.ComboBox
        Me.Bancos = New ClasesNegocio.BancosCollectionClass
        Me.txtBanco = New System.Windows.Forms.TextBox
        Me.pDg = New System.Windows.Forms.PrintDialog
        Me.Abonos = New ClasesNegocio.ChequeCollectionClass
        Me.ImprimirCheque = New ClasesNegocio.PrintDocumentChequeClass
        Me.PagoElectronico = New ClasesNegocio.PrintDocumentPagoElectronicoClass
        Me.tab = New System.Windows.Forms.TableLayoutPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtCargo = New System.Windows.Forms.TextBox
        Me.txtAbono = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.DgvCuentas = New System.Windows.Forms.DataGridView
        Me.ClmAbono = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmCargo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmSssCta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmSsbCta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmSubCta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmCtaMayor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gpo = New System.Windows.Forms.GroupBox
        Me.pan.SuspendLayout()
        Me.gpoCuentas.SuspendLayout()
        Me.tab.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpo.SuspendLayout()
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
        Me.mtb.Size = New System.Drawing.Size(50, 534)
        Me.mtb.TabIndex = 6
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
        Me.lblTitulo.Size = New System.Drawing.Size(708, 30)
        Me.lblTitulo.TabIndex = 7
        Me.lblTitulo.Text = "Label1"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pan
        '
        Me.pan.Controls.Add(Me.chkAnticipo)
        Me.pan.Controls.Add(Me.txtTipoCambio)
        Me.pan.Controls.Add(Me.txtImporte)
        Me.pan.Controls.Add(Me.txtPoliza)
        Me.pan.Controls.Add(Me.Label9)
        Me.pan.Controls.Add(Me.chkElectronico)
        Me.pan.Controls.Add(Me.txtReferencia)
        Me.pan.Controls.Add(Me.txtConcepto)
        Me.pan.Controls.Add(Me.txtImporteLetra)
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
        Me.pan.Location = New System.Drawing.Point(55, 33)
        Me.pan.Name = "pan"
        Me.pan.Size = New System.Drawing.Size(695, 312)
        Me.pan.TabIndex = 8
        '
        'chkAnticipo
        '
        Me.chkAnticipo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkAnticipo.Location = New System.Drawing.Point(6, 191)
        Me.chkAnticipo.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.chkAnticipo.Name = "chkAnticipo"
        Me.chkAnticipo.Size = New System.Drawing.Size(87, 24)
        Me.chkAnticipo.TabIndex = 22
        Me.chkAnticipo.Text = "Es Anticipo:"
        Me.chkAnticipo.UseVisualStyleBackColor = True
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtTipoCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCambio.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtTipoCambio.Location = New System.Drawing.Point(75, 250)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.ReadOnly = True
        Me.txtTipoCambio.Size = New System.Drawing.Size(100, 22)
        Me.txtTipoCambio.TabIndex = 21
        Me.txtTipoCambio.Text = "0.00"
        Me.txtTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtImporte
        '
        Me.txtImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporte.Location = New System.Drawing.Point(75, 221)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(100, 22)
        Me.txtImporte.TabIndex = 20
        Me.txtImporte.Text = "0.00"
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPoliza
        '
        Me.txtPoliza.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtPoliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPoliza.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtPoliza.Location = New System.Drawing.Point(509, 279)
        Me.txtPoliza.Name = "txtPoliza"
        Me.txtPoliza.ReadOnly = True
        Me.txtPoliza.Size = New System.Drawing.Size(174, 22)
        Me.txtPoliza.TabIndex = 19
        Me.txtPoliza.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(465, 284)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Poliza:"
        '
        'txtReferencia
        '
        Me.txtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReferencia.Location = New System.Drawing.Point(270, 191)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(413, 20)
        Me.txtReferencia.TabIndex = 10
        '
        'chkElectronico
        '
        Me.chkElectronico.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkElectronico.Location = New System.Drawing.Point(99, 191)
        Me.chkElectronico.Name = "chkElectronico"
        Me.chkElectronico.Size = New System.Drawing.Size(100, 24)
        Me.chkElectronico.TabIndex = 8
        Me.chkElectronico.Text = "Es Electronico"
        Me.chkElectronico.UseVisualStyleBackColor = True
        '
        'txtConcepto
        '
        Me.txtConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConcepto.Location = New System.Drawing.Point(75, 281)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(384, 20)
        Me.txtConcepto.TabIndex = 17
        '
        'txtImporteLetra
        '
        Me.txtImporteLetra.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtImporteLetra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporteLetra.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtImporteLetra.Location = New System.Drawing.Point(181, 219)
        Me.txtImporteLetra.Multiline = True
        Me.txtImporteLetra.Name = "txtImporteLetra"
        Me.txtImporteLetra.ReadOnly = True
        Me.txtImporteLetra.Size = New System.Drawing.Size(502, 53)
        Me.txtImporteLetra.TabIndex = 13
        Me.txtImporteLetra.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(434, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha:"
        '
        'dtp
        '
        Me.dtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp.Location = New System.Drawing.Point(480, 12)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(95, 20)
        Me.dtp.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 255)
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
        Me.gpoCuentas.Size = New System.Drawing.Size(679, 147)
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
        Me.lv.Size = New System.Drawing.Size(667, 96)
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
        Me.txtSaldo.Location = New System.Drawing.Point(458, 119)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.Size = New System.Drawing.Size(215, 22)
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
        Me.txtCuenta.Size = New System.Drawing.Size(325, 22)
        Me.txtCuenta.TabIndex = 2
        Me.txtCuenta.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Importe: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Concepto:"
        '
        'lblRef
        '
        Me.lblRef.AutoSize = True
        Me.lblRef.Location = New System.Drawing.Point(202, 196)
        Me.lblRef.Name = "lblRef"
        Me.lblRef.Size = New System.Drawing.Size(62, 13)
        Me.lblRef.TabIndex = 9
        Me.lblRef.Text = "Referencia:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 14)
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
        Me.cmbBanco.Location = New System.Drawing.Point(156, 11)
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
        Me.txtBanco.Location = New System.Drawing.Point(50, 11)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(100, 20)
        Me.txtBanco.TabIndex = 1
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
        Me.tab.Size = New System.Drawing.Size(676, 162)
        Me.tab.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtAbono)
        Me.Panel1.Controls.Add(Me.txtCargo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 132)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(676, 30)
        Me.Panel1.TabIndex = 4
        '
        'txtCargo
        '
        Me.txtCargo.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCargo.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtCargo.Location = New System.Drawing.Point(496, 4)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.ReadOnly = True
        Me.txtCargo.Size = New System.Drawing.Size(90, 22)
        Me.txtCargo.TabIndex = 2
        Me.txtCargo.Text = "0.00"
        Me.txtCargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAbono
        '
        Me.txtAbono.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtAbono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbono.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtAbono.Location = New System.Drawing.Point(585, 4)
        Me.txtAbono.Name = "txtAbono"
        Me.txtAbono.ReadOnly = True
        Me.txtAbono.Size = New System.Drawing.Size(90, 22)
        Me.txtAbono.TabIndex = 3
        Me.txtAbono.Text = "0.00"
        Me.txtAbono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.DarkRed
        Me.Label10.Location = New System.Drawing.Point(8, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(300, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "* Para mostrar la Busqueda de Cuentas Contables presione F3"
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
        Me.DgvCuentas.Size = New System.Drawing.Size(670, 118)
        Me.DgvCuentas.TabIndex = 5
        '
        'ClmAbono
        '
        DataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle36.BackColor = System.Drawing.Color.Wheat
        DataGridViewCellStyle36.Format = "C2"
        DataGridViewCellStyle36.NullValue = Nothing
        Me.ClmAbono.DefaultCellStyle = DataGridViewCellStyle36
        Me.ClmAbono.HeaderText = "Abono"
        Me.ClmAbono.Name = "ClmAbono"
        Me.ClmAbono.Width = 90
        '
        'ClmCargo
        '
        DataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle35.BackColor = System.Drawing.Color.PapayaWhip
        DataGridViewCellStyle35.Format = "C2"
        DataGridViewCellStyle35.NullValue = Nothing
        Me.ClmCargo.DefaultCellStyle = DataGridViewCellStyle35
        Me.ClmCargo.HeaderText = "Cargo"
        Me.ClmCargo.Name = "ClmCargo"
        Me.ClmCargo.Width = 90
        '
        'ClmDescripcion
        '
        Me.ClmDescripcion.HeaderText = "Descripci�n"
        Me.ClmDescripcion.Name = "ClmDescripcion"
        Me.ClmDescripcion.ReadOnly = True
        Me.ClmDescripcion.Width = 150
        '
        'ClmSssCta
        '
        DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ClmSssCta.DefaultCellStyle = DataGridViewCellStyle34
        Me.ClmSssCta.HeaderText = "Sss Cta."
        Me.ClmSssCta.Name = "ClmSssCta"
        Me.ClmSssCta.Width = 75
        '
        'ClmSsbCta
        '
        DataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ClmSsbCta.DefaultCellStyle = DataGridViewCellStyle33
        Me.ClmSsbCta.HeaderText = "Ssb Cta."
        Me.ClmSsbCta.Name = "ClmSsbCta"
        Me.ClmSsbCta.Width = 75
        '
        'ClmSubCta
        '
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ClmSubCta.DefaultCellStyle = DataGridViewCellStyle32
        Me.ClmSubCta.HeaderText = "Sub Cta."
        Me.ClmSubCta.Name = "ClmSubCta"
        Me.ClmSubCta.Width = 75
        '
        'ClmCtaMayor
        '
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ClmCtaMayor.DefaultCellStyle = DataGridViewCellStyle31
        Me.ClmCtaMayor.HeaderText = "Cta. May"
        Me.ClmCtaMayor.Name = "ClmCtaMayor"
        Me.ClmCtaMayor.Width = 75
        '
        'gpo
        '
        Me.gpo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpo.Controls.Add(Me.tab)
        Me.gpo.Location = New System.Drawing.Point(55, 340)
        Me.gpo.Name = "gpo"
        Me.gpo.Size = New System.Drawing.Size(694, 181)
        Me.gpo.TabIndex = 9
        Me.gpo.TabStop = False
        '
        'FrmBanAbonosDiversos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 534)
        Me.Controls.Add(Me.pan)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.gpo)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(766, 568)
        Me.MinimumSize = New System.Drawing.Size(766, 568)
        Me.Name = "FrmBanAbonosDiversos"
        Me.Text = "Abonos Diversos"
        Me.pan.ResumeLayout(False)
        Me.pan.PerformLayout()
        Me.gpoCuentas.ResumeLayout(False)
        Me.gpoCuentas.PerformLayout()
        Me.tab.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgvCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpo.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents pan As System.Windows.Forms.Panel
    Friend WithEvents txtPoliza As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtReferencia As System.Windows.Forms.TextBox
    Friend WithEvents chkElectronico As System.Windows.Forms.CheckBox
    Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
    Friend WithEvents txtImporteLetra As System.Windows.Forms.TextBox
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
    Friend WithEvents Bancos As ClasesNegocio.BancosCollectionClass
    Friend WithEvents pDg As System.Windows.Forms.PrintDialog
    Friend WithEvents Abonos As ClasesNegocio.ChequeCollectionClass
    Friend WithEvents ImprimirCheque As ClasesNegocio.PrintDocumentChequeClass
    Friend WithEvents PagoElectronico As ClasesNegocio.PrintDocumentPagoElectronicoClass
    Friend WithEvents txtTipoCambio As System.Windows.Forms.TextBox
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents chkAnticipo As System.Windows.Forms.CheckBox
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
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtAbono As System.Windows.Forms.TextBox
    Friend WithEvents txtCargo As System.Windows.Forms.TextBox
    Friend WithEvents gpo As System.Windows.Forms.GroupBox
End Class
