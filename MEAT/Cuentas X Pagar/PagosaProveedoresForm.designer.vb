<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PagosaProveedoresForm
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PagosaProveedoresForm))
        Me.gpo = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DgvCuentas = New System.Windows.Forms.DataGridView()
        Me.clmId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCuentaContablePri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmCtaMayor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmSubCta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmSsbCta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmSssCta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmCargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmAbono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvFacturas = New System.Windows.Forms.DataGridView()
        Me.ClmPagar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.clmNoFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFechaVencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Abono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmSaldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmApagar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtAbono = New Integra.Controles.TextboxDecimal()
        Me.txtCargo = New Integra.Controles.TextboxDecimal()
        Me.pan = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPoliza = New System.Windows.Forms.TextBox()
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
        Me.txtSaldo = New Integra.Controles.TextboxDecimal()
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
        Me.cmbBanco = New System.Windows.Forms.ComboBox()
        Me.Bancos = New ClasesNegocio.BancosCollectionClass()
        Me.txtFolio = New System.Windows.Forms.TextBox()
        Me.txtBeneficiario = New System.Windows.Forms.TextBox()
        Me.txtBanco = New System.Windows.Forms.TextBox()
        Me.Beneficiarios = New ClasesNegocio.BeneficiarioCollectionClass()
        Me.mtb = New MEAToolBar.MEAToolBar()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pDg = New System.Windows.Forms.PrintDialog()
        Me.PagoElectronico = New ClasesNegocio.PrintDocumentPagoElectronicoClass()
        Me.ppDg = New System.Windows.Forms.PrintPreviewDialog()
        Me.ImprimirCheque = New ClasesNegocio.PrintDocumentChequeClass()
        Me.Cheques = New ClasesNegocio.ChequeCollectionClass()
        Me.TmBeneficiario = New System.Windows.Forms.Timer(Me.components)
        Me.gpo.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DgvCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pan.SuspendLayout()
        Me.gpoCuentas.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpo
        '
        Me.gpo.Controls.Add(Me.Panel2)
        Me.gpo.Location = New System.Drawing.Point(53, 370)
        Me.gpo.Name = "gpo"
        Me.gpo.Size = New System.Drawing.Size(676, 278)
        Me.gpo.TabIndex = 7
        Me.gpo.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(670, 256)
        Me.Panel2.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.85075!))
        Me.TableLayoutPanel1.Controls.Add(Me.DgvCuentas, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DgvFacturas, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.91489!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.08511!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(670, 256)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'DgvCuentas
        '
        Me.DgvCuentas.AllowUserToAddRows = False
        Me.DgvCuentas.AllowUserToDeleteRows = False
        Me.DgvCuentas.BackgroundColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvCuentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmId, Me.clmCuentaContablePri, Me.ClmCtaMayor, Me.ClmSubCta, Me.ClmSsbCta, Me.ClmSssCta, Me.ClmDescripcion, Me.ClmCargo, Me.ClmAbono})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvCuentas.DefaultCellStyle = DataGridViewCellStyle4
        Me.DgvCuentas.Location = New System.Drawing.Point(3, 119)
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
        Me.DgvCuentas.Size = New System.Drawing.Size(664, 101)
        Me.DgvCuentas.TabIndex = 1
        '
        'clmId
        '
        Me.clmId.HeaderText = "ID Cuenta Contable"
        Me.clmId.Name = "clmId"
        Me.clmId.Visible = False
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
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LemonChiffon
        DataGridViewCellStyle2.Format = "C4"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.ClmCargo.DefaultCellStyle = DataGridViewCellStyle2
        Me.ClmCargo.HeaderText = "Cargo"
        Me.ClmCargo.Name = "ClmCargo"
        '
        'ClmAbono
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.Format = "C4"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ClmAbono.DefaultCellStyle = DataGridViewCellStyle3
        Me.ClmAbono.HeaderText = "Abono"
        Me.ClmAbono.Name = "ClmAbono"
        '
        'DgvFacturas
        '
        Me.DgvFacturas.AllowUserToAddRows = False
        Me.DgvFacturas.AllowUserToDeleteRows = False
        Me.DgvFacturas.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClmPagar, Me.clmNoFactura, Me.clmFechaVencimiento, Me.Abono, Me.clmTotal, Me.clmSaldo, Me.clmApagar})
        Me.DgvFacturas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvFacturas.Location = New System.Drawing.Point(3, 3)
        Me.DgvFacturas.MultiSelect = False
        Me.DgvFacturas.Name = "DgvFacturas"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvFacturas.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DgvFacturas.RowHeadersVisible = False
        Me.DgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvFacturas.Size = New System.Drawing.Size(664, 110)
        Me.DgvFacturas.TabIndex = 0
        '
        'ClmPagar
        '
        Me.ClmPagar.HeaderText = ""
        Me.ClmPagar.Name = "ClmPagar"
        Me.ClmPagar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ClmPagar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ClmPagar.Width = 50
        '
        'clmNoFactura
        '
        Me.clmNoFactura.DataPropertyName = "NoFactura"
        Me.clmNoFactura.HeaderText = "No Factura"
        Me.clmNoFactura.Name = "clmNoFactura"
        Me.clmNoFactura.ReadOnly = True
        Me.clmNoFactura.Width = 90
        '
        'clmFechaVencimiento
        '
        Me.clmFechaVencimiento.DataPropertyName = "FechaVencimiento"
        DataGridViewCellStyle6.Format = "d"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.clmFechaVencimiento.DefaultCellStyle = DataGridViewCellStyle6
        Me.clmFechaVencimiento.HeaderText = "Fecha Vencimiento"
        Me.clmFechaVencimiento.Name = "clmFechaVencimiento"
        Me.clmFechaVencimiento.ReadOnly = True
        Me.clmFechaVencimiento.Width = 121
        '
        'Abono
        '
        Me.Abono.DataPropertyName = "ImporteAbono"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.Abono.DefaultCellStyle = DataGridViewCellStyle7
        Me.Abono.HeaderText = "Abono"
        Me.Abono.Name = "Abono"
        Me.Abono.ReadOnly = True
        '
        'clmTotal
        '
        Me.clmTotal.DataPropertyName = "ImporteTotal"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "C2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.clmTotal.DefaultCellStyle = DataGridViewCellStyle8
        Me.clmTotal.HeaderText = "Total"
        Me.clmTotal.Name = "clmTotal"
        Me.clmTotal.ReadOnly = True
        '
        'clmSaldo
        '
        Me.clmSaldo.DataPropertyName = "Saldo"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "C2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.clmSaldo.DefaultCellStyle = DataGridViewCellStyle9
        Me.clmSaldo.HeaderText = "Saldo"
        Me.clmSaldo.Name = "clmSaldo"
        Me.clmSaldo.ReadOnly = True
        '
        'clmApagar
        '
        Me.clmApagar.DataPropertyName = "ImporteaPagar"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.LemonChiffon
        DataGridViewCellStyle10.Format = "C2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.clmApagar.DefaultCellStyle = DataGridViewCellStyle10
        Me.clmApagar.HeaderText = "A pagar"
        Me.clmApagar.Name = "clmApagar"
        Me.clmApagar.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtAbono)
        Me.Panel1.Controls.Add(Me.txtCargo)
        Me.Panel1.Location = New System.Drawing.Point(0, 223)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(670, 33)
        Me.Panel1.TabIndex = 3
        '
        'txtAbono
        '
        Me.txtAbono.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtAbono.Decimales = CType(2UI, UInteger)
        Me.txtAbono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbono.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtAbono.Location = New System.Drawing.Point(566, 2)
        Me.txtAbono.Margin = New System.Windows.Forms.Padding(0)
        Me.txtAbono.Name = "txtAbono"
        Me.txtAbono.ReadOnly = True
        Me.txtAbono.Signo = Integra.Controles.TextboxDecimal.RespuestaEnum.NO
        Me.txtAbono.Size = New System.Drawing.Size(98, 22)
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
        Me.txtCargo.Location = New System.Drawing.Point(463, 2)
        Me.txtCargo.Margin = New System.Windows.Forms.Padding(0)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.ReadOnly = True
        Me.txtCargo.Signo = Integra.Controles.TextboxDecimal.RespuestaEnum.NO
        Me.txtCargo.Size = New System.Drawing.Size(103, 22)
        Me.txtCargo.TabIndex = 0
        Me.txtCargo.TabStop = False
        Me.txtCargo.Text = "0.00"
        Me.txtCargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pan
        '
        Me.pan.Controls.Add(Me.Label10)
        Me.pan.Controls.Add(Me.txtPoliza)
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
        Me.pan.Controls.Add(Me.Label9)
        Me.pan.Controls.Add(Me.Label7)
        Me.pan.Controls.Add(Me.Label3)
        Me.pan.Controls.Add(Me.lblRef)
        Me.pan.Controls.Add(Me.Label1)
        Me.pan.Controls.Add(Me.cmbBeneficiario)
        Me.pan.Controls.Add(Me.cmbBanco)
        Me.pan.Controls.Add(Me.txtFolio)
        Me.pan.Controls.Add(Me.txtBeneficiario)
        Me.pan.Controls.Add(Me.txtBanco)
        Me.pan.Location = New System.Drawing.Point(53, 33)
        Me.pan.Name = "pan"
        Me.pan.Size = New System.Drawing.Size(667, 331)
        Me.pan.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 220)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "No. Beneficiario:"
        '
        'txtPoliza
        '
        Me.txtPoliza.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtPoliza.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPoliza.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtPoliza.Location = New System.Drawing.Point(543, 302)
        Me.txtPoliza.Name = "txtPoliza"
        Me.txtPoliza.ReadOnly = True
        Me.txtPoliza.Size = New System.Drawing.Size(112, 22)
        Me.txtPoliza.TabIndex = 23
        Me.txtPoliza.TabStop = False
        '
        'txtReferencia
        '
        Me.txtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReferencia.Location = New System.Drawing.Point(181, 192)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(275, 20)
        Me.txtReferencia.TabIndex = 9
        Me.txtReferencia.Visible = False
        '
        'chkElectronico
        '
        Me.chkElectronico.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkElectronico.Location = New System.Drawing.Point(6, 191)
        Me.chkElectronico.Name = "chkElectronico"
        Me.chkElectronico.Size = New System.Drawing.Size(97, 24)
        Me.chkElectronico.TabIndex = 7
        Me.chkElectronico.Text = "Es Electronico"
        Me.chkElectronico.UseVisualStyleBackColor = True
        '
        'txtConcepto
        '
        Me.txtConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConcepto.Enabled = False
        Me.txtConcepto.Location = New System.Drawing.Point(98, 302)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(395, 20)
        Me.txtConcepto.TabIndex = 21
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
        Me.txtImporteLetra.Size = New System.Drawing.Size(464, 53)
        Me.txtImporteLetra.TabIndex = 17
        Me.txtImporteLetra.TabStop = False
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtTipoCambio.Decimales = CType(2UI, UInteger)
        Me.txtTipoCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCambio.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtTipoCambio.Location = New System.Drawing.Point(98, 273)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.ReadOnly = True
        Me.txtTipoCambio.Signo = Integra.Controles.TextboxDecimal.RespuestaEnum.NO
        Me.txtTipoCambio.Size = New System.Drawing.Size(87, 22)
        Me.txtTipoCambio.TabIndex = 19
        Me.txtTipoCambio.TabStop = False
        Me.txtTipoCambio.Text = "0.00"
        Me.txtTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtImporte
        '
        Me.txtImporte.Decimales = CType(2UI, UInteger)
        Me.txtImporte.Enabled = False
        Me.txtImporte.Location = New System.Drawing.Point(98, 245)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Signo = Integra.Controles.TextboxDecimal.RespuestaEnum.NO
        Me.txtImporte.Size = New System.Drawing.Size(87, 20)
        Me.txtImporte.TabIndex = 16
        Me.txtImporte.Text = "0.00"
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.dtp.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 272)
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
        Me.gpoCuentas.Size = New System.Drawing.Size(657, 147)
        Me.gpoCuentas.TabIndex = 5
        Me.gpoCuentas.TabStop = False
        Me.gpoCuentas.Text = "Cuentas"
        '
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtSaldo.Decimales = CType(2UI, UInteger)
        Me.txtSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtSaldo.Location = New System.Drawing.Point(459, 119)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.Signo = Integra.Controles.TextboxDecimal.RespuestaEnum.NO
        Me.txtSaldo.Size = New System.Drawing.Size(186, 22)
        Me.txtSaldo.TabIndex = 3
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
        Me.lv.Size = New System.Drawing.Size(645, 96)
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
        Me.txtCuenta.Size = New System.Drawing.Size(329, 22)
        Me.txtCuenta.TabIndex = 2
        Me.txtCuenta.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 246)
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
        Me.Label9.Location = New System.Drawing.Point(499, 305)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Poliza:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(462, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Num. Cheque:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(191, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Beneficiario:"
        '
        'lblRef
        '
        Me.lblRef.AutoSize = True
        Me.lblRef.Location = New System.Drawing.Point(113, 196)
        Me.lblRef.Name = "lblRef"
        Me.lblRef.Size = New System.Drawing.Size(62, 13)
        Me.lblRef.TabIndex = 8
        Me.lblRef.Text = "Referencia:"
        Me.lblRef.Visible = False
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
        Me.cmbBeneficiario.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbBeneficiario.DisplayMember = "Beneficiario"
        Me.cmbBeneficiario.FormattingEnabled = True
        Me.cmbBeneficiario.Location = New System.Drawing.Point(262, 217)
        Me.cmbBeneficiario.Name = "cmbBeneficiario"
        Me.cmbBeneficiario.Size = New System.Drawing.Size(393, 21)
        Me.cmbBeneficiario.TabIndex = 14
        Me.cmbBeneficiario.ValueMember = "Codigo"
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
        Me.txtFolio.Location = New System.Drawing.Point(543, 191)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.ReadOnly = True
        Me.txtFolio.Size = New System.Drawing.Size(112, 22)
        Me.txtFolio.TabIndex = 11
        Me.txtFolio.TabStop = False
        '
        'txtBeneficiario
        '
        Me.txtBeneficiario.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtBeneficiario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBeneficiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBeneficiario.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtBeneficiario.Location = New System.Drawing.Point(98, 217)
        Me.txtBeneficiario.Name = "txtBeneficiario"
        Me.txtBeneficiario.ReadOnly = True
        Me.txtBeneficiario.Size = New System.Drawing.Size(87, 22)
        Me.txtBeneficiario.TabIndex = 13
        Me.txtBeneficiario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBanco
        '
        Me.txtBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBanco.Location = New System.Drawing.Point(85, 12)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(100, 20)
        Me.txtBanco.TabIndex = 1
        '
        'Beneficiarios
        '
        Me.Beneficiarios.AllowEdit = True
        Me.Beneficiarios.AllowNew = True
        Me.Beneficiarios.AllowRemove = True
        Me.Beneficiarios.Name = Nothing
        Me.Beneficiarios.RaiseListChangedEvents = True
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
        Me.mtb.Size = New System.Drawing.Size(50, 657)
        Me.mtb.TabIndex = 4
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(48, 0)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(700, 30)
        Me.lblTitulo.TabIndex = 5
        Me.lblTitulo.Text = "PAGOS A PROVEEDORES"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'ImprimirCheque
        '
        Me.ImprimirCheque.AbonoEnCuenta = System.Windows.Forms.DialogResult.No
        Me.ImprimirCheque.Banco = 0
        Me.ImprimirCheque.Cheque = Nothing
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
        'TmBeneficiario
        '
        Me.TmBeneficiario.Interval = 1000
        '
        'PagosaProveedoresForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 657)
        Me.Controls.Add(Me.gpo)
        Me.Controls.Add(Me.pan)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PagosaProveedoresForm"
        Me.Text = "Pagos a Proveedores"
        Me.gpo.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.DgvCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pan.ResumeLayout(False)
        Me.pan.PerformLayout()
        Me.gpoCuentas.ResumeLayout(False)
        Me.gpoCuentas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gpo As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtAbono As Integra.Controles.TextboxDecimal
    Friend WithEvents txtCargo As Integra.Controles.TextboxDecimal
    Friend WithEvents pan As System.Windows.Forms.Panel
    Friend WithEvents txtPoliza As System.Windows.Forms.TextBox
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
    Friend WithEvents txtSaldo As Integra.Controles.TextboxDecimal
    Friend WithEvents lv As System.Windows.Forms.ListView
    Friend WithEvents chCuenta As System.Windows.Forms.ColumnHeader
    Friend WithEvents chDescripcion As System.Windows.Forms.ColumnHeader
    Friend WithEvents chTipoMoneda As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblRef As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbBeneficiario As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBanco As System.Windows.Forms.ComboBox
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents txtBeneficiario As System.Windows.Forms.TextBox
    Friend WithEvents txtBanco As System.Windows.Forms.TextBox
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents pDg As System.Windows.Forms.PrintDialog
    Friend WithEvents PagoElectronico As ClasesNegocio.PrintDocumentPagoElectronicoClass
    Friend WithEvents ppDg As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents ImprimirCheque As ClasesNegocio.PrintDocumentChequeClass
    Friend WithEvents Cheques As ClasesNegocio.ChequeCollectionClass
    Friend WithEvents Beneficiarios As ClasesNegocio.BeneficiarioCollectionClass
    Friend WithEvents DgvFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TmBeneficiario As System.Windows.Forms.Timer
    Friend WithEvents Bancos As ClasesNegocio.BancosCollectionClass
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DgvCuentas As System.Windows.Forms.DataGridView
    Friend WithEvents clmId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCuentaContablePri As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmCtaMayor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmSubCta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmSsbCta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmSssCta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmCargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmAbono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmPagar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents clmNoFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaVencimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Abono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSaldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmApagar As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
