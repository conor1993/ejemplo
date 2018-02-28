<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MFacRegFacturasVentas
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmbUsoCFDI = New System.Windows.Forms.ComboBox()
        Me.txtlugarexpedicion = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtnumerodecuenta = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmbmetododepago = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmbformadepago = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ultcmbDomiciliosFiscales = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lvEmbarques = New System.Windows.Forms.ListView()
        Me.ChkVarios = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbClientesVarios = New System.Windows.Forms.ComboBox()
        Me.dgvDetalleConcentrado = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KilosEmbarcados = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KilosFacturados = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmiva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteFacturado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteEmbarcado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPrecioReal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPiezas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmunidadsat = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.clmproductoserv = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.chkiva = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txtPoliza = New System.Windows.Forms.TextBox()
        Me.txtCodigoCliente = New System.Windows.Forms.TextBox()
        Me.dtpFechaVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rdCredito = New System.Windows.Forms.RadioButton()
        Me.rdContado = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCajas = New System.Windows.Forms.TextBox()
        Me.txtKgrs = New System.Windows.Forms.TextBox()
        Me.txtPiezas = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtIVA = New System.Windows.Forms.TextBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.txtDiasCredito = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtRFC = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblEstatus = New System.Windows.Forms.Label()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.txtFolioFactura = New System.Windows.Forms.TextBox()
        Me.txtFolioEmbarque = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtFechaFactura = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar()
        Me.pdDocumento = New System.Drawing.Printing.PrintDocument()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CuentaControl = New IntegraLab.ORM.CollectionClasses.CfgCtrlCtasCollection()
        Me.Etiqueta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Corte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Piezas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kilos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteIVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodserv = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.ultcmbDomiciliosFiscales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalleConcentrado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.cmbUsoCFDI)
        Me.GroupBox1.Controls.Add(Me.txtlugarexpedicion)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.ultcmbDomiciliosFiscales)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lvEmbarques)
        Me.GroupBox1.Controls.Add(Me.ChkVarios)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CmbClientesVarios)
        Me.GroupBox1.Controls.Add(Me.dgvDetalleConcentrado)
        Me.GroupBox1.Controls.Add(Me.txtPoliza)
        Me.GroupBox1.Controls.Add(Me.txtCodigoCliente)
        Me.GroupBox1.Controls.Add(Me.dtpFechaVencimiento)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.txtDiasCredito)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtRFC)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lblEstatus)
        Me.GroupBox1.Controls.Add(Me.dgvDetalle)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCliente)
        Me.GroupBox1.Controls.Add(Me.txtFolioFactura)
        Me.GroupBox1.Controls.Add(Me.txtFolioEmbarque)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtFechaFactura)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(55, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1067, 598)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 122)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(56, 13)
        Me.Label23.TabIndex = 165
        Me.Label23.Text = "Uso CFDI:"
        '
        'cmbUsoCFDI
        '
        Me.cmbUsoCFDI.FormattingEnabled = True
        Me.cmbUsoCFDI.Location = New System.Drawing.Point(98, 116)
        Me.cmbUsoCFDI.Name = "cmbUsoCFDI"
        Me.cmbUsoCFDI.Size = New System.Drawing.Size(483, 21)
        Me.cmbUsoCFDI.TabIndex = 164
        '
        'txtlugarexpedicion
        '
        Me.txtlugarexpedicion.Location = New System.Drawing.Point(718, 53)
        Me.txtlugarexpedicion.Name = "txtlugarexpedicion"
        Me.txtlugarexpedicion.Size = New System.Drawing.Size(286, 20)
        Me.txtlugarexpedicion.TabIndex = 159
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(603, 56)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(109, 13)
        Me.Label22.TabIndex = 158
        Me.Label22.Text = "Lugar de Expedicíon:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtnumerodecuenta)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.cmbmetododepago)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.cmbformadepago)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox5.Location = New System.Drawing.Point(791, 79)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(213, 198)
        Me.GroupBox5.TabIndex = 155
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Información del pago"
        '
        'txtnumerodecuenta
        '
        Me.txtnumerodecuenta.Location = New System.Drawing.Point(6, 146)
        Me.txtnumerodecuenta.Name = "txtnumerodecuenta"
        Me.txtnumerodecuenta.Size = New System.Drawing.Size(203, 20)
        Me.txtnumerodecuenta.TabIndex = 6
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(6, 125)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(99, 13)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Número de Cuenta:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(6, 76)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(89, 13)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "Metodo de Pago:"
        '
        'cmbmetododepago
        '
        Me.cmbmetododepago.FormattingEnabled = True
        Me.cmbmetododepago.Location = New System.Drawing.Point(6, 94)
        Me.cmbmetododepago.Name = "cmbmetododepago"
        Me.cmbmetododepago.Size = New System.Drawing.Size(203, 21)
        Me.cmbmetododepago.TabIndex = 2
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(6, 22)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(82, 13)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "Forma de Pago:"
        '
        'cmbformadepago
        '
        Me.cmbformadepago.FormattingEnabled = True
        Me.cmbformadepago.Location = New System.Drawing.Point(9, 43)
        Me.cmbformadepago.Name = "cmbformadepago"
        Me.cmbformadepago.Size = New System.Drawing.Size(198, 21)
        Me.cmbformadepago.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(195, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 20)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "No. Folio"
        Me.ToolTip1.SetToolTip(Me.Button1, "Muestra el folio consecutivo")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ultcmbDomiciliosFiscales
        '
        Me.ultcmbDomiciliosFiscales.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Appearance4.BackColor = System.Drawing.SystemColors.Window
        Appearance4.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ultcmbDomiciliosFiscales.DisplayLayout.Appearance = Appearance4
        Me.ultcmbDomiciliosFiscales.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ultcmbDomiciliosFiscales.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance1.BorderColor = System.Drawing.SystemColors.Window
        Me.ultcmbDomiciliosFiscales.DisplayLayout.GroupByBox.Appearance = Appearance1
        Appearance2.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ultcmbDomiciliosFiscales.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance2
        Me.ultcmbDomiciliosFiscales.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance3.BackColor2 = System.Drawing.SystemColors.Control
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ultcmbDomiciliosFiscales.DisplayLayout.GroupByBox.PromptAppearance = Appearance3
        Me.ultcmbDomiciliosFiscales.DisplayLayout.MaxColScrollRegions = 1
        Me.ultcmbDomiciliosFiscales.DisplayLayout.MaxRowScrollRegions = 1
        Appearance12.BackColor = System.Drawing.SystemColors.Window
        Appearance12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ultcmbDomiciliosFiscales.DisplayLayout.Override.ActiveCellAppearance = Appearance12
        Appearance7.BackColor = System.Drawing.SystemColors.Highlight
        Appearance7.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ultcmbDomiciliosFiscales.DisplayLayout.Override.ActiveRowAppearance = Appearance7
        Me.ultcmbDomiciliosFiscales.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ultcmbDomiciliosFiscales.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance6.BackColor = System.Drawing.SystemColors.Window
        Me.ultcmbDomiciliosFiscales.DisplayLayout.Override.CardAreaAppearance = Appearance6
        Appearance5.BorderColor = System.Drawing.Color.Silver
        Appearance5.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ultcmbDomiciliosFiscales.DisplayLayout.Override.CellAppearance = Appearance5
        Me.ultcmbDomiciliosFiscales.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ultcmbDomiciliosFiscales.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.ultcmbDomiciliosFiscales.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance11.TextHAlignAsString = "Left"
        Me.ultcmbDomiciliosFiscales.DisplayLayout.Override.HeaderAppearance = Appearance11
        Me.ultcmbDomiciliosFiscales.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ultcmbDomiciliosFiscales.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance10.BackColor = System.Drawing.SystemColors.Window
        Appearance10.BorderColor = System.Drawing.Color.Silver
        Me.ultcmbDomiciliosFiscales.DisplayLayout.Override.RowAppearance = Appearance10
        Me.ultcmbDomiciliosFiscales.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ultcmbDomiciliosFiscales.DisplayLayout.Override.TemplateAddRowAppearance = Appearance8
        Me.ultcmbDomiciliosFiscales.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ultcmbDomiciliosFiscales.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ultcmbDomiciliosFiscales.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ultcmbDomiciliosFiscales.DisplayMember = "Domicilio"
        Me.ultcmbDomiciliosFiscales.Location = New System.Drawing.Point(98, 89)
        Me.ultcmbDomiciliosFiscales.Name = "ultcmbDomiciliosFiscales"
        Me.ultcmbDomiciliosFiscales.Size = New System.Drawing.Size(370, 22)
        Me.ultcmbDomiciliosFiscales.TabIndex = 7
        Me.ultcmbDomiciliosFiscales.Text = "Seleccione el Domicilio Fiscal"
        Me.ultcmbDomiciliosFiscales.ValueMember = "IdRenglon"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Domicilio Fiscal:"
        '
        'lvEmbarques
        '
        Me.lvEmbarques.Location = New System.Drawing.Point(492, 10)
        Me.lvEmbarques.Name = "lvEmbarques"
        Me.lvEmbarques.Size = New System.Drawing.Size(95, 97)
        Me.lvEmbarques.TabIndex = 37
        Me.lvEmbarques.UseCompatibleStateImageBehavior = False
        Me.lvEmbarques.View = System.Windows.Forms.View.List
        '
        'ChkVarios
        '
        Me.ChkVarios.AutoSize = True
        Me.ChkVarios.Location = New System.Drawing.Point(396, 64)
        Me.ChkVarios.Name = "ChkVarios"
        Me.ChkVarios.Size = New System.Drawing.Size(96, 17)
        Me.ChkVarios.TabIndex = 6
        Me.ChkVarios.Text = "Cliente Varios  "
        Me.ChkVarios.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Remitir a:"
        '
        'CmbClientesVarios
        '
        Me.CmbClientesVarios.FormattingEnabled = True
        Me.CmbClientesVarios.Location = New System.Drawing.Point(98, 142)
        Me.CmbClientesVarios.Name = "CmbClientesVarios"
        Me.CmbClientesVarios.Size = New System.Drawing.Size(291, 21)
        Me.CmbClientesVarios.TabIndex = 8
        '
        'dgvDetalleConcentrado
        '
        Me.dgvDetalleConcentrado.AllowUserToAddRows = False
        Me.dgvDetalleConcentrado.AllowUserToDeleteRows = False
        Me.dgvDetalleConcentrado.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalleConcentrado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDetalleConcentrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleConcentrado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Descripcion, Me.KilosEmbarcados, Me.KilosFacturados, Me.Precios, Me.clmiva, Me.ImporteFacturado, Me.ImporteEmbarcado, Me.clmPrecioReal, Me.clmPiezas, Me.clmunidadsat, Me.clmproductoserv, Me.chkiva})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetalleConcentrado.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvDetalleConcentrado.Location = New System.Drawing.Point(1, 357)
        Me.dgvDetalleConcentrado.Name = "dgvDetalleConcentrado"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalleConcentrado.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvDetalleConcentrado.RowHeadersVisible = False
        Me.dgvDetalleConcentrado.Size = New System.Drawing.Size(1052, 200)
        Me.dgvDetalleConcentrado.TabIndex = 15
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "Codigo"
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 60
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'KilosEmbarcados
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.KilosEmbarcados.DefaultCellStyle = DataGridViewCellStyle2
        Me.KilosEmbarcados.HeaderText = "Kilos Embarcados"
        Me.KilosEmbarcados.Name = "KilosEmbarcados"
        Me.KilosEmbarcados.ReadOnly = True
        Me.KilosEmbarcados.Width = 120
        '
        'KilosFacturados
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0.00"
        Me.KilosFacturados.DefaultCellStyle = DataGridViewCellStyle3
        Me.KilosFacturados.HeaderText = "Kilos Facturados"
        Me.KilosFacturados.Name = "KilosFacturados"
        Me.KilosFacturados.Width = 120
        '
        'Precios
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Precios.DefaultCellStyle = DataGridViewCellStyle4
        Me.Precios.HeaderText = "PrecioxKgr"
        Me.Precios.Name = "Precios"
        '
        'clmiva
        '
        DataGridViewCellStyle5.NullValue = "0.00"
        Me.clmiva.DefaultCellStyle = DataGridViewCellStyle5
        Me.clmiva.HeaderText = "Iva"
        Me.clmiva.Name = "clmiva"
        Me.clmiva.ReadOnly = True
        Me.clmiva.Width = 50
        '
        'ImporteFacturado
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = "0.00"
        Me.ImporteFacturado.DefaultCellStyle = DataGridViewCellStyle6
        Me.ImporteFacturado.HeaderText = "Importe Facturado"
        Me.ImporteFacturado.Name = "ImporteFacturado"
        Me.ImporteFacturado.ReadOnly = True
        Me.ImporteFacturado.Width = 120
        '
        'ImporteEmbarcado
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.ImporteEmbarcado.DefaultCellStyle = DataGridViewCellStyle7
        Me.ImporteEmbarcado.HeaderText = "Importe Embarcado"
        Me.ImporteEmbarcado.Name = "ImporteEmbarcado"
        Me.ImporteEmbarcado.ReadOnly = True
        Me.ImporteEmbarcado.Width = 130
        '
        'clmPrecioReal
        '
        Me.clmPrecioReal.HeaderText = "Precio Real"
        Me.clmPrecioReal.Name = "clmPrecioReal"
        Me.clmPrecioReal.Visible = False
        '
        'clmPiezas
        '
        Me.clmPiezas.HeaderText = "Piezas"
        Me.clmPiezas.Name = "clmPiezas"
        Me.clmPiezas.Visible = False
        '
        'clmunidadsat
        '
        Me.clmunidadsat.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.clmunidadsat.HeaderText = "Unidad sat"
        Me.clmunidadsat.Name = "clmunidadsat"
        Me.clmunidadsat.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmunidadsat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'clmproductoserv
        '
        Me.clmproductoserv.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.clmproductoserv.HeaderText = "Producto/Servicio"
        Me.clmproductoserv.Name = "clmproductoserv"
        Me.clmproductoserv.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmproductoserv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'chkiva
        '
        Me.chkiva.HeaderText = "iva"
        Me.chkiva.Name = "chkiva"
        Me.chkiva.Width = 50
        '
        'txtPoliza
        '
        Me.txtPoliza.Enabled = False
        Me.txtPoliza.Location = New System.Drawing.Point(276, 13)
        Me.txtPoliza.Name = "txtPoliza"
        Me.txtPoliza.Size = New System.Drawing.Size(91, 20)
        Me.txtPoliza.TabIndex = 20
        Me.txtPoliza.Visible = False
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.Location = New System.Drawing.Point(98, 65)
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.Size = New System.Drawing.Size(65, 20)
        Me.txtCodigoCliente.TabIndex = 5
        '
        'dtpFechaVencimiento
        '
        Me.dtpFechaVencimiento.Enabled = False
        Me.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaVencimiento.Location = New System.Drawing.Point(301, 38)
        Me.dtpFechaVencimiento.Name = "dtpFechaVencimiento"
        Me.dtpFechaVencimiento.Size = New System.Drawing.Size(88, 20)
        Me.dtpFechaVencimiento.TabIndex = 4
        Me.dtpFechaVencimiento.Value = New Date(2007, 7, 31, 0, 0, 0, 0)
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(192, 41)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(104, 13)
        Me.Label18.TabIndex = 27
        Me.Label18.Text = "Fecha Vencimiento :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rdCredito)
        Me.GroupBox4.Controls.Add(Me.rdContado)
        Me.GroupBox4.Location = New System.Drawing.Point(444, 214)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(98, 99)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tipo Factura"
        '
        'rdCredito
        '
        Me.rdCredito.AutoSize = True
        Me.rdCredito.Location = New System.Drawing.Point(11, 48)
        Me.rdCredito.Name = "rdCredito"
        Me.rdCredito.Size = New System.Drawing.Size(58, 17)
        Me.rdCredito.TabIndex = 14
        Me.rdCredito.TabStop = True
        Me.rdCredito.Text = "Crédito"
        Me.rdCredito.UseVisualStyleBackColor = True
        '
        'rdContado
        '
        Me.rdContado.AutoSize = True
        Me.rdContado.Location = New System.Drawing.Point(11, 24)
        Me.rdContado.Name = "rdContado"
        Me.rdContado.Size = New System.Drawing.Size(65, 17)
        Me.rdContado.TabIndex = 13
        Me.rdContado.TabStop = True
        Me.rdContado.Text = "Contado"
        Me.rdContado.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCajas)
        Me.GroupBox2.Controls.Add(Me.txtKgrs)
        Me.GroupBox2.Controls.Add(Me.txtPiezas)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox2.Location = New System.Drawing.Point(606, 184)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(179, 99)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Totales"
        '
        'txtCajas
        '
        Me.txtCajas.Enabled = False
        Me.txtCajas.Location = New System.Drawing.Point(68, 71)
        Me.txtCajas.Name = "txtCajas"
        Me.txtCajas.Size = New System.Drawing.Size(100, 20)
        Me.txtCajas.TabIndex = 22
        Me.txtCajas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtKgrs
        '
        Me.txtKgrs.Enabled = False
        Me.txtKgrs.Location = New System.Drawing.Point(68, 45)
        Me.txtKgrs.Name = "txtKgrs"
        Me.txtKgrs.Size = New System.Drawing.Size(100, 20)
        Me.txtKgrs.TabIndex = 21
        Me.txtKgrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPiezas
        '
        Me.txtPiezas.Enabled = False
        Me.txtPiezas.Location = New System.Drawing.Point(68, 19)
        Me.txtPiezas.Name = "txtPiezas"
        Me.txtPiezas.Size = New System.Drawing.Size(100, 20)
        Me.txtPiezas.TabIndex = 19
        Me.txtPiezas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(6, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Cajas :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(6, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Kgrs :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(6, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Piezas :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtTotal)
        Me.GroupBox3.Controls.Add(Me.txtIVA)
        Me.GroupBox3.Controls.Add(Me.txtSubTotal)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox3.Location = New System.Drawing.Point(606, 79)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(179, 99)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Importes"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(68, 71)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 22
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIVA
        '
        Me.txtIVA.Enabled = False
        Me.txtIVA.Location = New System.Drawing.Point(68, 45)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.Size = New System.Drawing.Size(100, 20)
        Me.txtIVA.TabIndex = 21
        Me.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Enabled = False
        Me.txtSubTotal.Location = New System.Drawing.Point(68, 19)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubTotal.TabIndex = 19
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(6, 71)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Total  :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(6, 45)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(30, 13)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "IVA :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(6, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 13)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "SubTotal :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 225)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Observaciones :"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(98, 225)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(325, 88)
        Me.txtObservaciones.TabIndex = 3
        '
        'txtDiasCredito
        '
        Me.txtDiasCredito.Enabled = False
        Me.txtDiasCredito.Location = New System.Drawing.Point(364, 200)
        Me.txtDiasCredito.Name = "txtDiasCredito"
        Me.txtDiasCredito.ReadOnly = True
        Me.txtDiasCredito.Size = New System.Drawing.Size(59, 20)
        Me.txtDiasCredito.TabIndex = 30
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(286, 203)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 13)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Días Crédito :"
        '
        'txtRFC
        '
        Me.txtRFC.Enabled = False
        Me.txtRFC.Location = New System.Drawing.Point(98, 200)
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(157, 20)
        Me.txtRFC.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 200)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "R.F.C. :"
        '
        'lblEstatus
        '
        Me.lblEstatus.AutoSize = True
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(900, 16)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(104, 24)
        Me.lblEstatus.TabIndex = 15
        Me.lblEstatus.Text = "ESTATUS"
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Etiqueta, Me.Corte, Me.Piezas, Me.Kilos, Me.PrecioUnitario, Me.IVA, Me.ImporteIVA, Me.Importe, Me.prodserv})
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetalle.DefaultCellStyle = DataGridViewCellStyle16
        Me.dgvDetalle.Location = New System.Drawing.Point(23, 357)
        Me.dgvDetalle.Name = "dgvDetalle"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.dgvDetalle.Size = New System.Drawing.Size(1017, 200)
        Me.dgvDetalle.TabIndex = 14
        '
        'txtDireccion
        '
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Location = New System.Drawing.Point(98, 171)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(444, 20)
        Me.txtDireccion.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Direccion :"
        '
        'txtCliente
        '
        Me.txtCliente.Enabled = False
        Me.txtCliente.Location = New System.Drawing.Point(169, 65)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(220, 20)
        Me.txtCliente.TabIndex = 5
        '
        'txtFolioFactura
        '
        Me.txtFolioFactura.Location = New System.Drawing.Point(98, 13)
        Me.txtFolioFactura.Name = "txtFolioFactura"
        Me.txtFolioFactura.ReadOnly = True
        Me.txtFolioFactura.Size = New System.Drawing.Size(91, 20)
        Me.txtFolioFactura.TabIndex = 0
        '
        'txtFolioEmbarque
        '
        Me.txtFolioEmbarque.Location = New System.Drawing.Point(276, 13)
        Me.txtFolioEmbarque.Name = "txtFolioEmbarque"
        Me.txtFolioEmbarque.Size = New System.Drawing.Size(91, 20)
        Me.txtFolioEmbarque.TabIndex = 9
        Me.txtFolioEmbarque.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Cliente :"
        '
        'dtFechaFactura
        '
        Me.dtFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaFactura.Location = New System.Drawing.Point(98, 40)
        Me.dtFechaFactura.Name = "dtFechaFactura"
        Me.dtFechaFactura.Size = New System.Drawing.Size(88, 20)
        Me.dtFechaFactura.TabIndex = 2
        Me.dtFechaFactura.Value = New Date(2007, 7, 31, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha Factura :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(414, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Embarque(s) :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Folio Factura :"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(1084, 32)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Facturas de Ventas"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MEAToolBar1
        '
        Me.MEAToolBar1.ButtonSize = New System.Drawing.Size(50, 50)
        Me.MEAToolBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MEAToolBar1.DropDownArrows = True
        Me.MEAToolBar1.HabilitarBorrar = True
        Me.MEAToolBar1.HabilitarBuscar = True
        Me.MEAToolBar1.HabilitarCancelar = True
        Me.MEAToolBar1.HabilitarEditar = True
        Me.MEAToolBar1.HabilitarGuardar = True
        Me.MEAToolBar1.HabilitarImprimir = True
        Me.MEAToolBar1.HabilitarLimpiar = True
        Me.MEAToolBar1.HabilitarNuevo = True
        Me.MEAToolBar1.HabilitarSalir = True
        Me.MEAToolBar1.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32
        Me.MEAToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.MEAToolBar1.MostrarBorrar = True
        Me.MEAToolBar1.MostrarBuscar = True
        Me.MEAToolBar1.MostrarCancelar = True
        Me.MEAToolBar1.MostrarEditar = True
        Me.MEAToolBar1.MostrarGuardar = True
        Me.MEAToolBar1.MostrarImprimir = True
        Me.MEAToolBar1.MostrarLimpiar = True
        Me.MEAToolBar1.MostrarNuevo = True
        Me.MEAToolBar1.MostrarSalir = True
        Me.MEAToolBar1.Name = "MEAToolBar1"
        Me.MEAToolBar1.ShowToolTips = True
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 655)
        Me.MEAToolBar1.TabIndex = 30
        '
        'CuentaControl
        '
        Me.CuentaControl.ActiveContext = Nothing
        Me.CuentaControl.AllowEdit = True
        Me.CuentaControl.AllowNew = True
        Me.CuentaControl.AllowRemove = True
        Me.CuentaControl.Capacity = 32
        Me.CuentaControl.ConcurrencyPredicateFactoryToUse = Nothing
        Me.CuentaControl.DoNotPerformAddIfPresent = False
        Me.CuentaControl.EntityFactoryToUse = New IntegraLab.ORM.FactoryClasses.CfgCtrlCtasEntityFactory()
        Me.CuentaControl.IsReadOnly = False
        Me.CuentaControl.MaxNumberOfItemsToReturn = CType(0, Long)
        Me.CuentaControl.SortClauses = Nothing
        Me.CuentaControl.SuppressClearInGetMulti = False
        Me.CuentaControl.Transaction = Nothing
        '
        'Etiqueta
        '
        Me.Etiqueta.HeaderText = "Etiqueta"
        Me.Etiqueta.Name = "Etiqueta"
        '
        'Corte
        '
        Me.Corte.HeaderText = "Corte"
        Me.Corte.Name = "Corte"
        '
        'Piezas
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.Piezas.DefaultCellStyle = DataGridViewCellStyle11
        Me.Piezas.HeaderText = "Piezas"
        Me.Piezas.Name = "Piezas"
        '
        'Kilos
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.Kilos.DefaultCellStyle = DataGridViewCellStyle12
        Me.Kilos.HeaderText = "Kilos"
        Me.Kilos.Name = "Kilos"
        '
        'PrecioUnitario
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle13.Format = "N2"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.PrecioUnitario.DefaultCellStyle = DataGridViewCellStyle13
        Me.PrecioUnitario.HeaderText = "Precio Unitario"
        Me.PrecioUnitario.Name = "PrecioUnitario"
        '
        'IVA
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle14.Format = "N2"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.IVA.DefaultCellStyle = DataGridViewCellStyle14
        Me.IVA.HeaderText = "% de IVA"
        Me.IVA.Name = "IVA"
        '
        'ImporteIVA
        '
        Me.ImporteIVA.HeaderText = "Importe IVA"
        Me.ImporteIVA.Name = "ImporteIVA"
        Me.ImporteIVA.Visible = False
        '
        'Importe
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle15.Format = "N2"
        DataGridViewCellStyle15.NullValue = Nothing
        Me.Importe.DefaultCellStyle = DataGridViewCellStyle15
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        '
        'prodserv
        '
        Me.prodserv.HeaderText = "Producto/Servicio"
        Me.prodserv.Name = "prodserv"
        '
        'MFacRegFacturasVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 655)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MFacRegFacturasVentas"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = " Facturas de Ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.ultcmbDomiciliosFiscales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalleConcentrado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFolioEmbarque As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtFechaFactura As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtFolioFactura As System.Windows.Forms.TextBox
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents txtRFC As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtDiasCredito As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCajas As System.Windows.Forms.TextBox
    Friend WithEvents txtKgrs As System.Windows.Forms.TextBox
    Friend WithEvents txtPiezas As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtIVA As System.Windows.Forms.TextBox
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rdCredito As System.Windows.Forms.RadioButton
    Friend WithEvents rdContado As System.Windows.Forms.RadioButton
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents dtpFechaVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoCliente As System.Windows.Forms.TextBox
    Friend WithEvents CuentaControl As IntegraLab.ORM.CollectionClasses.CfgCtrlCtasCollection
    Friend WithEvents txtPoliza As System.Windows.Forms.TextBox
    Friend WithEvents dgvDetalleConcentrado As System.Windows.Forms.DataGridView
    Friend WithEvents CmbClientesVarios As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ChkVarios As System.Windows.Forms.CheckBox
    Friend WithEvents pdDocumento As System.Drawing.Printing.PrintDocument
    Friend WithEvents lvEmbarques As System.Windows.Forms.ListView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DomicilioClienteColeccionClass1 As ClasesNegocio.DomicilioClienteColeccionClass
    Friend WithEvents ultcmbDomiciliosFiscales As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtnumerodecuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cmbmetododepago As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmbformadepago As System.Windows.Forms.ComboBox
    Friend WithEvents txtlugarexpedicion As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmbUsoCFDI As System.Windows.Forms.ComboBox
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosEmbarcados As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosFacturados As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precios As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmiva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteFacturado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteEmbarcado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPrecioReal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPiezas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmunidadsat As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents clmproductoserv As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents chkiva As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Etiqueta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Corte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Piezas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kilos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteIVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prodserv As System.Windows.Forms.DataGridViewComboBoxColumn

End Class
