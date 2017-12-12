<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusquedaPagoClientes
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
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label17 = New System.Windows.Forms.Label
        Me.DgvFacturas = New System.Windows.Forms.DataGridView
        Me.FolioIngresoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NoFactura = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DocumentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ImporteFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ImporteIngresoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ImporteNotaCredito = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaldoFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PagosDeClientesC = New ClasesNegocio.PagosDeClientesCollectionClass
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CmbClientes = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RbtnTodos = New System.Windows.Forms.RadioButton
        Me.RbtnCancelados = New System.Windows.Forms.RadioButton
        Me.RbtnVigentes = New System.Windows.Forms.RadioButton
        Me.txtNoPago = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DtpFechaFin = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.DtPFechaini = New System.Windows.Forms.DateTimePicker
        Me.ChkFechas = New System.Windows.Forms.CheckBox
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.BrnAceptar = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.dgvPagos = New System.Windows.Forms.DataGridView
        Me.clmFolioIngreso = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmImporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIdCliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtNoFactura = New System.Windows.Forms.TextBox
        CType(Me.DgvFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvPagos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.mtb.Size = New System.Drawing.Size(50, 608)
        Me.mtb.TabIndex = 51
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(631, 32)
        Me.Label17.TabIndex = 52
        Me.Label17.Text = "Búsqueda de Pagos de Clientes"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DgvFacturas
        '
        Me.DgvFacturas.AllowUserToAddRows = False
        Me.DgvFacturas.AllowUserToDeleteRows = False
        Me.DgvFacturas.AllowUserToResizeRows = False
        Me.DgvFacturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvFacturas.AutoGenerateColumns = False
        Me.DgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FolioIngresoDataGridViewTextBoxColumn, Me.NoFactura, Me.TipoPagoDataGridViewTextBoxColumn, Me.DocumentoDataGridViewTextBoxColumn, Me.ImporteFacturaDataGridViewTextBoxColumn, Me.ImporteIngresoDataGridViewTextBoxColumn, Me.ImporteNotaCredito, Me.SaldoFacturaDataGridViewTextBoxColumn, Me.EstatusDataGridViewTextBoxColumn})
        Me.DgvFacturas.DataSource = Me.PagosDeClientesC
        Me.DgvFacturas.Location = New System.Drawing.Point(6, 19)
        Me.DgvFacturas.MultiSelect = False
        Me.DgvFacturas.Name = "DgvFacturas"
        Me.DgvFacturas.ReadOnly = True
        Me.DgvFacturas.RowHeadersVisible = False
        Me.DgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvFacturas.Size = New System.Drawing.Size(609, 192)
        Me.DgvFacturas.TabIndex = 0
        '
        'FolioIngresoDataGridViewTextBoxColumn
        '
        Me.FolioIngresoDataGridViewTextBoxColumn.DataPropertyName = "FolioIngreso"
        Me.FolioIngresoDataGridViewTextBoxColumn.HeaderText = "Folio Ingreso"
        Me.FolioIngresoDataGridViewTextBoxColumn.Name = "FolioIngresoDataGridViewTextBoxColumn"
        Me.FolioIngresoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FolioIngresoDataGridViewTextBoxColumn.Visible = False
        '
        'NoFactura
        '
        Me.NoFactura.DataPropertyName = "NoFactura"
        Me.NoFactura.HeaderText = "No. Factura"
        Me.NoFactura.Name = "NoFactura"
        Me.NoFactura.ReadOnly = True
        '
        'TipoPagoDataGridViewTextBoxColumn
        '
        Me.TipoPagoDataGridViewTextBoxColumn.DataPropertyName = "TipoPago"
        Me.TipoPagoDataGridViewTextBoxColumn.HeaderText = "Tipo Pago"
        Me.TipoPagoDataGridViewTextBoxColumn.Name = "TipoPagoDataGridViewTextBoxColumn"
        Me.TipoPagoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoPagoDataGridViewTextBoxColumn.Visible = False
        '
        'DocumentoDataGridViewTextBoxColumn
        '
        Me.DocumentoDataGridViewTextBoxColumn.DataPropertyName = "Documento"
        Me.DocumentoDataGridViewTextBoxColumn.HeaderText = "Documento"
        Me.DocumentoDataGridViewTextBoxColumn.Name = "DocumentoDataGridViewTextBoxColumn"
        Me.DocumentoDataGridViewTextBoxColumn.ReadOnly = True
        Me.DocumentoDataGridViewTextBoxColumn.Visible = False
        '
        'ImporteFacturaDataGridViewTextBoxColumn
        '
        Me.ImporteFacturaDataGridViewTextBoxColumn.DataPropertyName = "ImporteFactura"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.ImporteFacturaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.ImporteFacturaDataGridViewTextBoxColumn.HeaderText = "Importe Factura"
        Me.ImporteFacturaDataGridViewTextBoxColumn.Name = "ImporteFacturaDataGridViewTextBoxColumn"
        Me.ImporteFacturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ImporteIngresoDataGridViewTextBoxColumn
        '
        Me.ImporteIngresoDataGridViewTextBoxColumn.DataPropertyName = "ImporteIngreso"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.ImporteIngresoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.ImporteIngresoDataGridViewTextBoxColumn.HeaderText = "Importe Ingreso"
        Me.ImporteIngresoDataGridViewTextBoxColumn.Name = "ImporteIngresoDataGridViewTextBoxColumn"
        Me.ImporteIngresoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ImporteNotaCredito
        '
        Me.ImporteNotaCredito.DataPropertyName = "ImporteNotaCredito"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.ImporteNotaCredito.DefaultCellStyle = DataGridViewCellStyle3
        Me.ImporteNotaCredito.HeaderText = "Impte. Notas de Credito"
        Me.ImporteNotaCredito.Name = "ImporteNotaCredito"
        Me.ImporteNotaCredito.ReadOnly = True
        '
        'SaldoFacturaDataGridViewTextBoxColumn
        '
        Me.SaldoFacturaDataGridViewTextBoxColumn.DataPropertyName = "SaldoFactura"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.SaldoFacturaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.SaldoFacturaDataGridViewTextBoxColumn.HeaderText = "Saldo Factura"
        Me.SaldoFacturaDataGridViewTextBoxColumn.Name = "SaldoFacturaDataGridViewTextBoxColumn"
        Me.SaldoFacturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstatusDataGridViewTextBoxColumn
        '
        Me.EstatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.HeaderText = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.Name = "EstatusDataGridViewTextBoxColumn"
        Me.EstatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PagosDeClientesC
        '
        Me.PagosDeClientesC.AllowEdit = True
        Me.PagosDeClientesC.AllowNew = True
        Me.PagosDeClientesC.AllowRemove = True
        Me.PagosDeClientesC.MaximoElementosSeleccionados = 1
        Me.PagosDeClientesC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.PagosDeClientesC.MostrarAlertas = False
        Me.PagosDeClientesC.Name = Nothing
        Me.PagosDeClientesC.RaiseListChangedEvents = True
        Me.PagosDeClientesC.Transaction = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DgvFacturas)
        Me.GroupBox1.Location = New System.Drawing.Point(49, 366)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(622, 190)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles"
        '
        'CmbClientes
        '
        Me.CmbClientes.FormattingEnabled = True
        Me.CmbClientes.Location = New System.Drawing.Point(116, 74)
        Me.CmbClientes.Name = "CmbClientes"
        Me.CmbClientes.Size = New System.Drawing.Size(299, 21)
        Me.CmbClientes.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Cliente :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.RbtnTodos)
        Me.GroupBox2.Controls.Add(Me.RbtnCancelados)
        Me.GroupBox2.Controls.Add(Me.RbtnVigentes)
        Me.GroupBox2.Location = New System.Drawing.Point(552, 62)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(112, 102)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estatus"
        '
        'RbtnTodos
        '
        Me.RbtnTodos.AutoSize = True
        Me.RbtnTodos.Location = New System.Drawing.Point(6, 68)
        Me.RbtnTodos.Name = "RbtnTodos"
        Me.RbtnTodos.Size = New System.Drawing.Size(63, 17)
        Me.RbtnTodos.TabIndex = 60
        Me.RbtnTodos.TabStop = True
        Me.RbtnTodos.Text = "TODOS"
        Me.RbtnTodos.UseVisualStyleBackColor = True
        '
        'RbtnCancelados
        '
        Me.RbtnCancelados.AutoSize = True
        Me.RbtnCancelados.Location = New System.Drawing.Point(6, 42)
        Me.RbtnCancelados.Name = "RbtnCancelados"
        Me.RbtnCancelados.Size = New System.Drawing.Size(97, 17)
        Me.RbtnCancelados.TabIndex = 59
        Me.RbtnCancelados.TabStop = True
        Me.RbtnCancelados.Text = "CANCELADOS"
        Me.RbtnCancelados.UseVisualStyleBackColor = True
        '
        'RbtnVigentes
        '
        Me.RbtnVigentes.AutoSize = True
        Me.RbtnVigentes.Location = New System.Drawing.Point(6, 19)
        Me.RbtnVigentes.Name = "RbtnVigentes"
        Me.RbtnVigentes.Size = New System.Drawing.Size(79, 17)
        Me.RbtnVigentes.TabIndex = 58
        Me.RbtnVigentes.TabStop = True
        Me.RbtnVigentes.Text = "VIGENTES"
        Me.RbtnVigentes.UseVisualStyleBackColor = True
        '
        'txtNoPago
        '
        Me.txtNoPago.Location = New System.Drawing.Point(116, 48)
        Me.txtNoPago.Name = "txtNoPago"
        Me.txtNoPago.Size = New System.Drawing.Size(100, 20)
        Me.txtNoPago.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "No Pago:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DtpFechaFin)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.DtPFechaini)
        Me.GroupBox3.Location = New System.Drawing.Point(50, 130)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(378, 46)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Fechas"
        '
        'DtpFechaFin
        '
        Me.DtpFechaFin.Enabled = False
        Me.DtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaFin.Location = New System.Drawing.Point(274, 18)
        Me.DtpFechaFin.Name = "DtpFechaFin"
        Me.DtpFechaFin.Size = New System.Drawing.Size(91, 20)
        Me.DtpFechaFin.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(203, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Fecha Final:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Fecha Inicial:"
        '
        'DtPFechaini
        '
        Me.DtPFechaini.Enabled = False
        Me.DtPFechaini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtPFechaini.Location = New System.Drawing.Point(82, 19)
        Me.DtPFechaini.Name = "DtPFechaini"
        Me.DtPFechaini.Size = New System.Drawing.Size(91, 20)
        Me.DtPFechaini.TabIndex = 0
        '
        'ChkFechas
        '
        Me.ChkFechas.AutoSize = True
        Me.ChkFechas.Location = New System.Drawing.Point(56, 107)
        Me.ChkFechas.Name = "ChkFechas"
        Me.ChkFechas.Size = New System.Drawing.Size(107, 17)
        Me.ChkFechas.TabIndex = 4
        Me.ChkFechas.Text = "Filtrar por Fechas"
        Me.ChkFechas.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCancelar.Location = New System.Drawing.Point(569, 573)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 9
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BrnAceptar
        '
        Me.BrnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BrnAceptar.Location = New System.Drawing.Point(472, 573)
        Me.BrnAceptar.Name = "BrnAceptar"
        Me.BrnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BrnAceptar.TabIndex = 8
        Me.BrnAceptar.Text = "Aceptar"
        Me.BrnAceptar.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.dgvPagos)
        Me.GroupBox4.Location = New System.Drawing.Point(50, 182)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(621, 177)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Pagos Efectuados"
        '
        'dgvPagos
        '
        Me.dgvPagos.AllowUserToAddRows = False
        Me.dgvPagos.AllowUserToDeleteRows = False
        Me.dgvPagos.AllowUserToResizeRows = False
        Me.dgvPagos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmFolioIngreso, Me.clmFecha, Me.clmCliente, Me.clmImporte, Me.clmIdCliente})
        Me.dgvPagos.Location = New System.Drawing.Point(9, 19)
        Me.dgvPagos.MultiSelect = False
        Me.dgvPagos.Name = "dgvPagos"
        Me.dgvPagos.ReadOnly = True
        Me.dgvPagos.RowHeadersVisible = False
        Me.dgvPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPagos.Size = New System.Drawing.Size(605, 147)
        Me.dgvPagos.TabIndex = 0
        '
        'clmFolioIngreso
        '
        Me.clmFolioIngreso.DataPropertyName = "FolIngreso"
        Me.clmFolioIngreso.HeaderText = "Folio Pago"
        Me.clmFolioIngreso.Name = "clmFolioIngreso"
        Me.clmFolioIngreso.ReadOnly = True
        '
        'clmFecha
        '
        Me.clmFecha.DataPropertyName = "FecIngreso"
        Me.clmFecha.HeaderText = "Fecha"
        Me.clmFecha.Name = "clmFecha"
        Me.clmFecha.ReadOnly = True
        Me.clmFecha.Width = 150
        '
        'clmCliente
        '
        Me.clmCliente.DataPropertyName = "Nombre"
        Me.clmCliente.HeaderText = "Cliente"
        Me.clmCliente.Name = "clmCliente"
        Me.clmCliente.ReadOnly = True
        Me.clmCliente.Width = 250
        '
        'clmImporte
        '
        Me.clmImporte.DataPropertyName = "Importe"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C4"
        DataGridViewCellStyle5.NullValue = "0"
        Me.clmImporte.DefaultCellStyle = DataGridViewCellStyle5
        Me.clmImporte.HeaderText = "Importe"
        Me.clmImporte.Name = "clmImporte"
        Me.clmImporte.ReadOnly = True
        '
        'clmIdCliente
        '
        Me.clmIdCliente.DataPropertyName = "CveCliente"
        Me.clmIdCliente.HeaderText = "Id Cliente"
        Me.clmIdCliente.Name = "clmIdCliente"
        Me.clmIdCliente.ReadOnly = True
        Me.clmIdCliente.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(246, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "No Factura:"
        '
        'txtNoFactura
        '
        Me.txtNoFactura.Location = New System.Drawing.Point(315, 48)
        Me.txtNoFactura.Name = "txtNoFactura"
        Me.txtNoFactura.Size = New System.Drawing.Size(100, 20)
        Me.txtNoFactura.TabIndex = 1
        '
        'FrmBusquedaPagoClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 608)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNoFactura)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.BrnAceptar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.ChkFechas)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNoPago)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.CmbClientes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmBusquedaPagoClientes"
        Me.Text = "Búsqueda de Pagos de Clientes"
        CType(Me.DgvFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents DgvFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CmbClientes As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RbtnTodos As System.Windows.Forms.RadioButton
    Friend WithEvents RbtnCancelados As System.Windows.Forms.RadioButton
    Friend WithEvents RbtnVigentes As System.Windows.Forms.RadioButton
    Friend WithEvents PagosDeClientesC As ClasesNegocio.PagosDeClientesCollectionClass
    Friend WithEvents txtNoPago As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DtPFechaini As System.Windows.Forms.DateTimePicker
    Friend WithEvents ChkFechas As System.Windows.Forms.CheckBox
    Friend WithEvents FolioFacturaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BrnAceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvPagos As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNoFactura As System.Windows.Forms.TextBox
    Friend WithEvents clmFolioIngreso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FolioIngresoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocumentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteFacturaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteIngresoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteNotaCredito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoFacturaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
