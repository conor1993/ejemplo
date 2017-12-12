<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _390ConsultaProveedores
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.lblEmpresa = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmbProveedor = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpFechaCorte = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDias = New System.Windows.Forms.TextBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.dgvFacturasconsaldo = New System.Windows.Forms.DataGridView
        Me.ClmFactura = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmFecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmFechaVencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmImporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmAbonado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmFechapago = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmSaldo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.dgvFacturasSaldadas = New System.Windows.Forms.DataGridView
        Me.ClmFacturaS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmFechaS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmFechaVencimientoS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmImporteS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmFechaPagoS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmPolizaS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtSaldoGen = New System.Windows.Forms.TextBox
        Me.txtSinvencer = New System.Windows.Forms.TextBox
        Me.txtVencidos = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtVencidoMayor60 = New System.Windows.Forms.TextBox
        Me.txtVencidoMayor30Menor60 = New System.Windows.Forms.TextBox
        Me.txtVencidomenor30 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.TmProveedor = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvFacturasconsaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvFacturasSaldadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.mtb.MostrarBorrar = False
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = False
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = False
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 508)
        Me.mtb.TabIndex = 103
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
        Me.lblTitulo.Size = New System.Drawing.Size(748, 29)
        Me.lblTitulo.TabIndex = 132
        Me.lblTitulo.Text = "CONSULTA DE PROVEEDORES"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEmpresa
        '
        Me.lblEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmpresa.Location = New System.Drawing.Point(124, 36)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(412, 20)
        Me.lblEmpresa.TabIndex = 133
        Me.lblEmpresa.Text = "Label3"
        Me.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(56, 40)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 13)
        Me.Label18.TabIndex = 134
        Me.Label18.Text = "Empresa:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "Proveedor :"
        '
        'CmbProveedor
        '
        Me.CmbProveedor.FormattingEnabled = True
        Me.CmbProveedor.Location = New System.Drawing.Point(124, 81)
        Me.CmbProveedor.Name = "CmbProveedor"
        Me.CmbProveedor.Size = New System.Drawing.Size(295, 21)
        Me.CmbProveedor.TabIndex = 136
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(445, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = "Fecha Corte :"
        '
        'dtpFechaCorte
        '
        Me.dtpFechaCorte.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaCorte.Location = New System.Drawing.Point(448, 80)
        Me.dtpFechaCorte.Name = "dtpFechaCorte"
        Me.dtpFechaCorte.Size = New System.Drawing.Size(88, 20)
        Me.dtpFechaCorte.TabIndex = 138
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(557, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 139
        Me.Label3.Text = "Días :"
        '
        'txtDias
        '
        Me.txtDias.Location = New System.Drawing.Point(560, 80)
        Me.txtDias.MaxLength = 3
        Me.txtDias.Name = "txtDias"
        Me.txtDias.Size = New System.Drawing.Size(36, 20)
        Me.txtDias.TabIndex = 140
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(59, 122)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(736, 239)
        Me.TabControl1.TabIndex = 141
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvFacturasconsaldo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(728, 213)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Facturas con Saldo"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvFacturasconsaldo
        '
        Me.dgvFacturasconsaldo.AllowUserToAddRows = False
        Me.dgvFacturasconsaldo.AllowUserToDeleteRows = False
        Me.dgvFacturasconsaldo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFacturasconsaldo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClmFactura, Me.ClmFecha, Me.ClmFechaVencimiento, Me.ClmImporte, Me.ClmAbonado, Me.ClmFechapago, Me.ClmSaldo})
        Me.dgvFacturasconsaldo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvFacturasconsaldo.Location = New System.Drawing.Point(3, 3)
        Me.dgvFacturasconsaldo.MultiSelect = False
        Me.dgvFacturasconsaldo.Name = "dgvFacturasconsaldo"
        Me.dgvFacturasconsaldo.ReadOnly = True
        Me.dgvFacturasconsaldo.RowHeadersVisible = False
        Me.dgvFacturasconsaldo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFacturasconsaldo.Size = New System.Drawing.Size(722, 207)
        Me.dgvFacturasconsaldo.TabIndex = 0
        '
        'ClmFactura
        '
        Me.ClmFactura.DataPropertyName = "NoFactura"
        Me.ClmFactura.HeaderText = "Factura"
        Me.ClmFactura.Name = "ClmFactura"
        Me.ClmFactura.ReadOnly = True
        '
        'ClmFecha
        '
        Me.ClmFecha.DataPropertyName = "FechaFactura"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.ClmFecha.DefaultCellStyle = DataGridViewCellStyle1
        Me.ClmFecha.HeaderText = "Fecha"
        Me.ClmFecha.Name = "ClmFecha"
        Me.ClmFecha.ReadOnly = True
        '
        'ClmFechaVencimiento
        '
        Me.ClmFechaVencimiento.DataPropertyName = "FechaVencimiento"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.ClmFechaVencimiento.DefaultCellStyle = DataGridViewCellStyle2
        Me.ClmFechaVencimiento.HeaderText = "Fecha Ven."
        Me.ClmFechaVencimiento.Name = "ClmFechaVencimiento"
        Me.ClmFechaVencimiento.ReadOnly = True
        '
        'ClmImporte
        '
        Me.ClmImporte.DataPropertyName = "Total"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ClmImporte.DefaultCellStyle = DataGridViewCellStyle3
        Me.ClmImporte.HeaderText = "Importe"
        Me.ClmImporte.Name = "ClmImporte"
        Me.ClmImporte.ReadOnly = True
        '
        'ClmAbonado
        '
        Me.ClmAbonado.DataPropertyName = "Abonado"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.ClmAbonado.DefaultCellStyle = DataGridViewCellStyle4
        Me.ClmAbonado.HeaderText = "Abonado"
        Me.ClmAbonado.Name = "ClmAbonado"
        Me.ClmAbonado.ReadOnly = True
        '
        'ClmFechapago
        '
        Me.ClmFechapago.DataPropertyName = "FechaPago"
        DataGridViewCellStyle5.Format = "d"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.ClmFechapago.DefaultCellStyle = DataGridViewCellStyle5
        Me.ClmFechapago.HeaderText = "Fecha Pago"
        Me.ClmFechapago.Name = "ClmFechapago"
        Me.ClmFechapago.ReadOnly = True
        '
        'ClmSaldo
        '
        Me.ClmSaldo.DataPropertyName = "Saldo"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.ClmSaldo.DefaultCellStyle = DataGridViewCellStyle6
        Me.ClmSaldo.HeaderText = "Saldo"
        Me.ClmSaldo.Name = "ClmSaldo"
        Me.ClmSaldo.ReadOnly = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvFacturasSaldadas)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(728, 213)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Facturas Saldadas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvFacturasSaldadas
        '
        Me.dgvFacturasSaldadas.AllowUserToAddRows = False
        Me.dgvFacturasSaldadas.AllowUserToDeleteRows = False
        Me.dgvFacturasSaldadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFacturasSaldadas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClmFacturaS, Me.ClmFechaS, Me.ClmFechaVencimientoS, Me.ClmImporteS, Me.ClmFechaPagoS, Me.ClmPolizaS})
        Me.dgvFacturasSaldadas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvFacturasSaldadas.Location = New System.Drawing.Point(3, 3)
        Me.dgvFacturasSaldadas.Name = "dgvFacturasSaldadas"
        Me.dgvFacturasSaldadas.ReadOnly = True
        Me.dgvFacturasSaldadas.RowHeadersVisible = False
        Me.dgvFacturasSaldadas.Size = New System.Drawing.Size(722, 207)
        Me.dgvFacturasSaldadas.TabIndex = 0
        '
        'ClmFacturaS
        '
        Me.ClmFacturaS.DataPropertyName = "NoFactura"
        Me.ClmFacturaS.HeaderText = "Factura"
        Me.ClmFacturaS.Name = "ClmFacturaS"
        Me.ClmFacturaS.ReadOnly = True
        '
        'ClmFechaS
        '
        Me.ClmFechaS.DataPropertyName = "FechaFactura"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle7.Format = "d"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.ClmFechaS.DefaultCellStyle = DataGridViewCellStyle7
        Me.ClmFechaS.HeaderText = "Fecha"
        Me.ClmFechaS.Name = "ClmFechaS"
        Me.ClmFechaS.ReadOnly = True
        '
        'ClmFechaVencimientoS
        '
        Me.ClmFechaVencimientoS.DataPropertyName = "FechaVencimiento"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle8.Format = "d"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.ClmFechaVencimientoS.DefaultCellStyle = DataGridViewCellStyle8
        Me.ClmFechaVencimientoS.HeaderText = "Fecha Ven."
        Me.ClmFechaVencimientoS.Name = "ClmFechaVencimientoS"
        Me.ClmFechaVencimientoS.ReadOnly = True
        '
        'ClmImporteS
        '
        Me.ClmImporteS.DataPropertyName = "Total"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle9.Format = "C2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.ClmImporteS.DefaultCellStyle = DataGridViewCellStyle9
        Me.ClmImporteS.HeaderText = "Importe"
        Me.ClmImporteS.Name = "ClmImporteS"
        Me.ClmImporteS.ReadOnly = True
        '
        'ClmFechaPagoS
        '
        Me.ClmFechaPagoS.DataPropertyName = "FechaPago"
        DataGridViewCellStyle10.Format = "d"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.ClmFechaPagoS.DefaultCellStyle = DataGridViewCellStyle10
        Me.ClmFechaPagoS.HeaderText = "Fecha Pago"
        Me.ClmFechaPagoS.Name = "ClmFechaPagoS"
        Me.ClmFechaPagoS.ReadOnly = True
        '
        'ClmPolizaS
        '
        Me.ClmPolizaS.DataPropertyName = "NumeroPoliza"
        Me.ClmPolizaS.HeaderText = "Poliza"
        Me.ClmPolizaS.Name = "ClmPolizaS"
        Me.ClmPolizaS.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSaldoGen)
        Me.GroupBox1.Controls.Add(Me.txtSinvencer)
        Me.GroupBox1.Controls.Add(Me.txtVencidos)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(108, 367)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(236, 122)
        Me.GroupBox1.TabIndex = 142
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Saldos"
        '
        'txtSaldoGen
        '
        Me.txtSaldoGen.Enabled = False
        Me.txtSaldoGen.Location = New System.Drawing.Point(114, 75)
        Me.txtSaldoGen.Name = "txtSaldoGen"
        Me.txtSaldoGen.Size = New System.Drawing.Size(100, 20)
        Me.txtSaldoGen.TabIndex = 5
        Me.txtSaldoGen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSinvencer
        '
        Me.txtSinvencer.Enabled = False
        Me.txtSinvencer.Location = New System.Drawing.Point(114, 48)
        Me.txtSinvencer.Name = "txtSinvencer"
        Me.txtSinvencer.Size = New System.Drawing.Size(100, 20)
        Me.txtSinvencer.TabIndex = 4
        Me.txtSinvencer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVencidos
        '
        Me.txtVencidos.Enabled = False
        Me.txtVencidos.Location = New System.Drawing.Point(114, 22)
        Me.txtVencidos.Name = "txtVencidos"
        Me.txtVencidos.Size = New System.Drawing.Size(100, 20)
        Me.txtVencidos.TabIndex = 3
        Me.txtVencidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Saldo General :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Sin Vencer :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Vencidos :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtVencidoMayor60)
        Me.GroupBox2.Controls.Add(Me.txtVencidoMayor30Menor60)
        Me.GroupBox2.Controls.Add(Me.txtVencidomenor30)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(386, 367)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(288, 122)
        Me.GroupBox2.TabIndex = 143
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Días Vencidos "
        '
        'txtVencidoMayor60
        '
        Me.txtVencidoMayor60.Enabled = False
        Me.txtVencidoMayor60.Location = New System.Drawing.Point(150, 75)
        Me.txtVencidoMayor60.Name = "txtVencidoMayor60"
        Me.txtVencidoMayor60.Size = New System.Drawing.Size(100, 20)
        Me.txtVencidoMayor60.TabIndex = 5
        Me.txtVencidoMayor60.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVencidoMayor30Menor60
        '
        Me.txtVencidoMayor30Menor60.Enabled = False
        Me.txtVencidoMayor30Menor60.Location = New System.Drawing.Point(150, 48)
        Me.txtVencidoMayor30Menor60.Name = "txtVencidoMayor30Menor60"
        Me.txtVencidoMayor30Menor60.Size = New System.Drawing.Size(100, 20)
        Me.txtVencidoMayor30Menor60.TabIndex = 4
        Me.txtVencidoMayor30Menor60.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVencidomenor30
        '
        Me.txtVencidomenor30.Enabled = False
        Me.txtVencidomenor30.Location = New System.Drawing.Point(150, 22)
        Me.txtVencidomenor30.Name = "txtVencidomenor30"
        Me.txtVencidomenor30.Size = New System.Drawing.Size(100, 20)
        Me.txtVencidomenor30.TabIndex = 3
        Me.txtVencidomenor30.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Vencido > 60"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Vencido => 30 y <= 60"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Vencido < 30"
        '
        'TmProveedor
        '
        Me.TmProveedor.Interval = 1000
        '
        '_390ConsultaProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 508)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.txtDias)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpFechaCorte)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbProveedor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblEmpresa)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "_390ConsultaProveedores"
        Me.Text = "Consulta de Proveedores"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvFacturasconsaldo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvFacturasSaldadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblEmpresa As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaCorte As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDias As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgvFacturasconsaldo As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgvFacturasSaldadas As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtVencidos As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoGen As System.Windows.Forms.TextBox
    Friend WithEvents txtSinvencer As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtVencidoMayor60 As System.Windows.Forms.TextBox
    Friend WithEvents txtVencidoMayor30Menor60 As System.Windows.Forms.TextBox
    Friend WithEvents txtVencidomenor30 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TmProveedor As System.Windows.Forms.Timer
    Friend WithEvents ClmFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmFechaVencimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmAbonado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmFechapago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmSaldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmFacturaS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmFechaS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmFechaVencimientoS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmImporteS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmFechaPagoS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmPolizaS As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
