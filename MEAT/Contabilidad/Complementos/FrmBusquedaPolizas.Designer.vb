<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusquedaPolizas
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
        Me.mtb = New MEAToolBar.MEAToolBar()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.DgvPolizas = New System.Windows.Forms.DataGridView()
        Me.clmCodPoliza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmNoPoliza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmConcepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmOrigen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFechaCaptura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DgvDetalles = New System.Windows.Forms.DataGridView()
        Me.clmCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmSubCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmSSubCta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmSSSubCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmAbono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNoPoliza = New System.Windows.Forms.TextBox()
        Me.GrpTipo = New System.Windows.Forms.GroupBox()
        Me.RbtnTodasTipo = New System.Windows.Forms.RadioButton()
        Me.rbtnCancelacion = New System.Windows.Forms.RadioButton()
        Me.rbtnDiario = New System.Windows.Forms.RadioButton()
        Me.RbtnEgreso = New System.Windows.Forms.RadioButton()
        Me.RbtnIngreso = New System.Windows.Forms.RadioButton()
        Me.GrpOrigen = New System.Windows.Forms.GroupBox()
        Me.rbtnTodasOrigen = New System.Windows.Forms.RadioButton()
        Me.rbtnVentas = New System.Windows.Forms.RadioButton()
        Me.rbtnCxP = New System.Windows.Forms.RadioButton()
        Me.rbtnCxC = New System.Windows.Forms.RadioButton()
        Me.rbtnContabilidad = New System.Windows.Forms.RadioButton()
        Me.rbtnCompras = New System.Windows.Forms.RadioButton()
        Me.rbtnBancos = New System.Windows.Forms.RadioButton()
        Me.rbtnAlmacen = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DtpFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkFechas = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.rbtnTodasEstatus = New System.Windows.Forms.RadioButton()
        Me.rbtnCanceladas = New System.Windows.Forms.RadioButton()
        Me.rbtnVigentes = New System.Windows.Forms.RadioButton()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        CType(Me.DgvPolizas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpTipo.SuspendLayout()
        Me.GrpOrigen.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
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
        Me.mtb.Size = New System.Drawing.Size(50, 646)
        Me.mtb.TabIndex = 109
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
        Me.lblTitulo.Size = New System.Drawing.Size(808, 29)
        Me.lblTitulo.TabIndex = 110
        Me.lblTitulo.Text = "BÚSQUEDA DE POLIZAS"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DgvPolizas
        '
        Me.DgvPolizas.AllowUserToAddRows = False
        Me.DgvPolizas.AllowUserToDeleteRows = False
        Me.DgvPolizas.AllowUserToResizeRows = False
        Me.DgvPolizas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvPolizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPolizas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmCodPoliza, Me.clmNoPoliza, Me.clmFecha, Me.clmConcepto, Me.clmTipo, Me.clmOrigen, Me.clmImporte, Me.clmFechaCaptura, Me.clmEstatus})
        Me.DgvPolizas.Location = New System.Drawing.Point(6, 19)
        Me.DgvPolizas.MultiSelect = False
        Me.DgvPolizas.Name = "DgvPolizas"
        Me.DgvPolizas.ReadOnly = True
        Me.DgvPolizas.RowHeadersVisible = False
        Me.DgvPolizas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPolizas.Size = New System.Drawing.Size(782, 185)
        Me.DgvPolizas.TabIndex = 111
        '
        'clmCodPoliza
        '
        Me.clmCodPoliza.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clmCodPoliza.DataPropertyName = "Codigo"
        Me.clmCodPoliza.HeaderText = "Codigo"
        Me.clmCodPoliza.Name = "clmCodPoliza"
        Me.clmCodPoliza.ReadOnly = True
        Me.clmCodPoliza.Width = 71
        '
        'clmNoPoliza
        '
        Me.clmNoPoliza.DataPropertyName = "NumeroPoliza"
        Me.clmNoPoliza.HeaderText = "No. Poliza"
        Me.clmNoPoliza.Name = "clmNoPoliza"
        Me.clmNoPoliza.ReadOnly = True
        Me.clmNoPoliza.Width = 90
        '
        'clmFecha
        '
        Me.clmFecha.DataPropertyName = "FechaPoliza"
        Me.clmFecha.HeaderText = "Fecha"
        Me.clmFecha.Name = "clmFecha"
        Me.clmFecha.ReadOnly = True
        Me.clmFecha.Width = 80
        '
        'clmConcepto
        '
        Me.clmConcepto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clmConcepto.DataPropertyName = "Concepto"
        Me.clmConcepto.HeaderText = "Concepto"
        Me.clmConcepto.Name = "clmConcepto"
        Me.clmConcepto.ReadOnly = True
        Me.clmConcepto.Width = 86
        '
        'clmTipo
        '
        Me.clmTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clmTipo.DataPropertyName = "TipoCad"
        Me.clmTipo.HeaderText = "Tipo"
        Me.clmTipo.Name = "clmTipo"
        Me.clmTipo.ReadOnly = True
        Me.clmTipo.Width = 57
        '
        'clmOrigen
        '
        Me.clmOrigen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clmOrigen.DataPropertyName = "OrigenCad"
        Me.clmOrigen.HeaderText = "Origen"
        Me.clmOrigen.Name = "clmOrigen"
        Me.clmOrigen.ReadOnly = True
        Me.clmOrigen.Width = 69
        '
        'clmImporte
        '
        Me.clmImporte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clmImporte.DataPropertyName = "Importe"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.clmImporte.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmImporte.HeaderText = "Importe"
        Me.clmImporte.Name = "clmImporte"
        Me.clmImporte.ReadOnly = True
        Me.clmImporte.Width = 74
        '
        'clmFechaCaptura
        '
        Me.clmFechaCaptura.DataPropertyName = "FechaCaptura"
        Me.clmFechaCaptura.HeaderText = "Fecha Captura"
        Me.clmFechaCaptura.Name = "clmFechaCaptura"
        Me.clmFechaCaptura.ReadOnly = True
        Me.clmFechaCaptura.Width = 120
        '
        'clmEstatus
        '
        Me.clmEstatus.DataPropertyName = "EstatusCad"
        Me.clmEstatus.HeaderText = "Estatus"
        Me.clmEstatus.Name = "clmEstatus"
        Me.clmEstatus.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DgvPolizas)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(50, 178)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(796, 210)
        Me.GroupBox1.TabIndex = 112
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Polizas"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.DgvDetalles)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(50, 394)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(798, 215)
        Me.GroupBox2.TabIndex = 113
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle"
        '
        'DgvDetalles
        '
        Me.DgvDetalles.AllowUserToAddRows = False
        Me.DgvDetalles.AllowUserToDeleteRows = False
        Me.DgvDetalles.AllowUserToResizeRows = False
        Me.DgvDetalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmCodigo, Me.clmCta, Me.clmSubCuenta, Me.clmSSubCta, Me.clmSSSubCuenta, Me.clmNombre, Me.clmCargo, Me.clmAbono})
        Me.DgvDetalles.Location = New System.Drawing.Point(10, 19)
        Me.DgvDetalles.MultiSelect = False
        Me.DgvDetalles.Name = "DgvDetalles"
        Me.DgvDetalles.ReadOnly = True
        Me.DgvDetalles.RowHeadersVisible = False
        Me.DgvDetalles.Size = New System.Drawing.Size(780, 190)
        Me.DgvDetalles.TabIndex = 1
        '
        'clmCodigo
        '
        Me.clmCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clmCodigo.DataPropertyName = "IdCuentaContable"
        Me.clmCodigo.HeaderText = "Código"
        Me.clmCodigo.Name = "clmCodigo"
        Me.clmCodigo.ReadOnly = True
        Me.clmCodigo.Width = 71
        '
        'clmCta
        '
        Me.clmCta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clmCta.DataPropertyName = "Cta"
        Me.clmCta.HeaderText = "Cta"
        Me.clmCta.Name = "clmCta"
        Me.clmCta.ReadOnly = True
        Me.clmCta.Width = 51
        '
        'clmSubCuenta
        '
        Me.clmSubCuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clmSubCuenta.DataPropertyName = "SCta"
        Me.clmSubCuenta.HeaderText = "SCuenta"
        Me.clmSubCuenta.Name = "clmSubCuenta"
        Me.clmSubCuenta.ReadOnly = True
        Me.clmSubCuenta.Width = 80
        '
        'clmSSubCta
        '
        Me.clmSSubCta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clmSSubCta.DataPropertyName = "SSCta"
        Me.clmSSubCta.HeaderText = "SSCuenta"
        Me.clmSSubCta.Name = "clmSSubCta"
        Me.clmSSubCta.ReadOnly = True
        Me.clmSSubCta.Width = 88
        '
        'clmSSSubCuenta
        '
        Me.clmSSSubCuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clmSSSubCuenta.DataPropertyName = "SSSCta"
        Me.clmSSSubCuenta.HeaderText = "SSSCuenta"
        Me.clmSSSubCuenta.Name = "clmSSSubCuenta"
        Me.clmSSSubCuenta.ReadOnly = True
        Me.clmSSSubCuenta.Width = 96
        '
        'clmNombre
        '
        Me.clmNombre.DataPropertyName = "NombreCta"
        Me.clmNombre.HeaderText = "Nombre"
        Me.clmNombre.Name = "clmNombre"
        Me.clmNombre.ReadOnly = True
        Me.clmNombre.Width = 200
        '
        'clmCargo
        '
        Me.clmCargo.DataPropertyName = "Cargo"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.clmCargo.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmCargo.HeaderText = "Cargo"
        Me.clmCargo.Name = "clmCargo"
        Me.clmCargo.ReadOnly = True
        '
        'clmAbono
        '
        Me.clmAbono.DataPropertyName = "Abono"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.clmAbono.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmAbono.HeaderText = "Abono"
        Me.clmAbono.Name = "clmAbono"
        Me.clmAbono.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "No. Poliza:"
        '
        'txtNoPoliza
        '
        Me.txtNoPoliza.Location = New System.Drawing.Point(135, 38)
        Me.txtNoPoliza.Name = "txtNoPoliza"
        Me.txtNoPoliza.Size = New System.Drawing.Size(101, 20)
        Me.txtNoPoliza.TabIndex = 115
        '
        'GrpTipo
        '
        Me.GrpTipo.Controls.Add(Me.RbtnTodasTipo)
        Me.GrpTipo.Controls.Add(Me.rbtnCancelacion)
        Me.GrpTipo.Controls.Add(Me.rbtnDiario)
        Me.GrpTipo.Controls.Add(Me.RbtnEgreso)
        Me.GrpTipo.Controls.Add(Me.RbtnIngreso)
        Me.GrpTipo.Location = New System.Drawing.Point(703, 38)
        Me.GrpTipo.Name = "GrpTipo"
        Me.GrpTipo.Size = New System.Drawing.Size(137, 134)
        Me.GrpTipo.TabIndex = 116
        Me.GrpTipo.TabStop = False
        Me.GrpTipo.Text = "Tipo de Poliza"
        '
        'RbtnTodasTipo
        '
        Me.RbtnTodasTipo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RbtnTodasTipo.AutoSize = True
        Me.RbtnTodasTipo.Checked = True
        Me.RbtnTodasTipo.Location = New System.Drawing.Point(6, 111)
        Me.RbtnTodasTipo.Name = "RbtnTodasTipo"
        Me.RbtnTodasTipo.Size = New System.Drawing.Size(62, 17)
        Me.RbtnTodasTipo.TabIndex = 121
        Me.RbtnTodasTipo.TabStop = True
        Me.RbtnTodasTipo.Text = "TODAS"
        Me.RbtnTodasTipo.UseVisualStyleBackColor = True
        '
        'rbtnCancelacion
        '
        Me.rbtnCancelacion.AutoSize = True
        Me.rbtnCancelacion.Location = New System.Drawing.Point(6, 88)
        Me.rbtnCancelacion.Name = "rbtnCancelacion"
        Me.rbtnCancelacion.Size = New System.Drawing.Size(100, 17)
        Me.rbtnCancelacion.TabIndex = 120
        Me.rbtnCancelacion.Text = "CANCELACIÓN"
        Me.rbtnCancelacion.UseVisualStyleBackColor = True
        '
        'rbtnDiario
        '
        Me.rbtnDiario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtnDiario.AutoSize = True
        Me.rbtnDiario.Location = New System.Drawing.Point(6, 65)
        Me.rbtnDiario.Name = "rbtnDiario"
        Me.rbtnDiario.Size = New System.Drawing.Size(62, 17)
        Me.rbtnDiario.TabIndex = 119
        Me.rbtnDiario.Text = "DIARIO"
        Me.rbtnDiario.UseVisualStyleBackColor = True
        '
        'RbtnEgreso
        '
        Me.RbtnEgreso.AutoSize = True
        Me.RbtnEgreso.Location = New System.Drawing.Point(6, 42)
        Me.RbtnEgreso.Name = "RbtnEgreso"
        Me.RbtnEgreso.Size = New System.Drawing.Size(70, 17)
        Me.RbtnEgreso.TabIndex = 118
        Me.RbtnEgreso.Text = "EGRESO"
        Me.RbtnEgreso.UseVisualStyleBackColor = True
        '
        'RbtnIngreso
        '
        Me.RbtnIngreso.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RbtnIngreso.AutoSize = True
        Me.RbtnIngreso.Location = New System.Drawing.Point(6, 19)
        Me.RbtnIngreso.Name = "RbtnIngreso"
        Me.RbtnIngreso.Size = New System.Drawing.Size(74, 17)
        Me.RbtnIngreso.TabIndex = 117
        Me.RbtnIngreso.Text = "INGRESO"
        Me.RbtnIngreso.UseVisualStyleBackColor = True
        '
        'GrpOrigen
        '
        Me.GrpOrigen.Controls.Add(Me.rbtnTodasOrigen)
        Me.GrpOrigen.Controls.Add(Me.rbtnVentas)
        Me.GrpOrigen.Controls.Add(Me.rbtnCxP)
        Me.GrpOrigen.Controls.Add(Me.rbtnCxC)
        Me.GrpOrigen.Controls.Add(Me.rbtnContabilidad)
        Me.GrpOrigen.Controls.Add(Me.rbtnCompras)
        Me.GrpOrigen.Controls.Add(Me.rbtnBancos)
        Me.GrpOrigen.Controls.Add(Me.rbtnAlmacen)
        Me.GrpOrigen.Location = New System.Drawing.Point(414, 41)
        Me.GrpOrigen.Name = "GrpOrigen"
        Me.GrpOrigen.Size = New System.Drawing.Size(262, 121)
        Me.GrpOrigen.TabIndex = 117
        Me.GrpOrigen.TabStop = False
        Me.GrpOrigen.Text = "Origen"
        '
        'rbtnTodasOrigen
        '
        Me.rbtnTodasOrigen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtnTodasOrigen.AutoSize = True
        Me.rbtnTodasOrigen.Checked = True
        Me.rbtnTodasOrigen.Location = New System.Drawing.Point(128, 88)
        Me.rbtnTodasOrigen.Name = "rbtnTodasOrigen"
        Me.rbtnTodasOrigen.Size = New System.Drawing.Size(62, 17)
        Me.rbtnTodasOrigen.TabIndex = 7
        Me.rbtnTodasOrigen.TabStop = True
        Me.rbtnTodasOrigen.Text = "TODAS"
        Me.rbtnTodasOrigen.UseVisualStyleBackColor = True
        '
        'rbtnVentas
        '
        Me.rbtnVentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtnVentas.AutoSize = True
        Me.rbtnVentas.Location = New System.Drawing.Point(128, 65)
        Me.rbtnVentas.Name = "rbtnVentas"
        Me.rbtnVentas.Size = New System.Drawing.Size(68, 17)
        Me.rbtnVentas.TabIndex = 6
        Me.rbtnVentas.Text = "VENTAS"
        Me.rbtnVentas.UseVisualStyleBackColor = True
        '
        'rbtnCxP
        '
        Me.rbtnCxP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtnCxP.AutoSize = True
        Me.rbtnCxP.Location = New System.Drawing.Point(128, 42)
        Me.rbtnCxP.Name = "rbtnCxP"
        Me.rbtnCxP.Size = New System.Drawing.Size(124, 17)
        Me.rbtnCxP.TabIndex = 5
        Me.rbtnCxP.Text = "CUENTAS x PAGAR"
        Me.rbtnCxP.UseVisualStyleBackColor = True
        '
        'rbtnCxC
        '
        Me.rbtnCxC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtnCxC.AutoSize = True
        Me.rbtnCxC.Location = New System.Drawing.Point(128, 19)
        Me.rbtnCxC.Name = "rbtnCxC"
        Me.rbtnCxC.Size = New System.Drawing.Size(132, 17)
        Me.rbtnCxC.TabIndex = 4
        Me.rbtnCxC.Text = "CUENTAS x COBRAR"
        Me.rbtnCxC.UseVisualStyleBackColor = True
        '
        'rbtnContabilidad
        '
        Me.rbtnContabilidad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtnContabilidad.AutoSize = True
        Me.rbtnContabilidad.Location = New System.Drawing.Point(6, 88)
        Me.rbtnContabilidad.Name = "rbtnContabilidad"
        Me.rbtnContabilidad.Size = New System.Drawing.Size(104, 17)
        Me.rbtnContabilidad.TabIndex = 3
        Me.rbtnContabilidad.Text = "CONTABILIDAD"
        Me.rbtnContabilidad.UseVisualStyleBackColor = True
        '
        'rbtnCompras
        '
        Me.rbtnCompras.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtnCompras.AutoSize = True
        Me.rbtnCompras.Location = New System.Drawing.Point(6, 65)
        Me.rbtnCompras.Name = "rbtnCompras"
        Me.rbtnCompras.Size = New System.Drawing.Size(78, 17)
        Me.rbtnCompras.TabIndex = 2
        Me.rbtnCompras.Text = "COMPRAS"
        Me.rbtnCompras.UseVisualStyleBackColor = True
        '
        'rbtnBancos
        '
        Me.rbtnBancos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtnBancos.AutoSize = True
        Me.rbtnBancos.Location = New System.Drawing.Point(6, 42)
        Me.rbtnBancos.Name = "rbtnBancos"
        Me.rbtnBancos.Size = New System.Drawing.Size(69, 17)
        Me.rbtnBancos.TabIndex = 1
        Me.rbtnBancos.Text = "BANCOS"
        Me.rbtnBancos.UseVisualStyleBackColor = True
        '
        'rbtnAlmacen
        '
        Me.rbtnAlmacen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtnAlmacen.AutoSize = True
        Me.rbtnAlmacen.Location = New System.Drawing.Point(6, 19)
        Me.rbtnAlmacen.Name = "rbtnAlmacen"
        Me.rbtnAlmacen.Size = New System.Drawing.Size(90, 17)
        Me.rbtnAlmacen.TabIndex = 0
        Me.rbtnAlmacen.Text = "ALMACENES"
        Me.rbtnAlmacen.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DtpFechaFin)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.DtpFechaIni)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Location = New System.Drawing.Point(58, 101)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(199, 65)
        Me.GroupBox5.TabIndex = 118
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Fechas"
        '
        'DtpFechaFin
        '
        Me.DtpFechaFin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtpFechaFin.Enabled = False
        Me.DtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaFin.Location = New System.Drawing.Point(82, 38)
        Me.DtpFechaFin.Name = "DtpFechaFin"
        Me.DtpFechaFin.Size = New System.Drawing.Size(102, 20)
        Me.DtpFechaFin.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha Final:"
        '
        'DtpFechaIni
        '
        Me.DtpFechaIni.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtpFechaIni.Enabled = False
        Me.DtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaIni.Location = New System.Drawing.Point(82, 12)
        Me.DtpFechaIni.Name = "DtpFechaIni"
        Me.DtpFechaIni.Size = New System.Drawing.Size(102, 20)
        Me.DtpFechaIni.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fecha Inicial:"
        '
        'chkFechas
        '
        Me.chkFechas.AutoSize = True
        Me.chkFechas.Location = New System.Drawing.Point(58, 78)
        Me.chkFechas.Name = "chkFechas"
        Me.chkFechas.Size = New System.Drawing.Size(111, 17)
        Me.chkFechas.TabIndex = 119
        Me.chkFechas.Text = "Rango de Fechas"
        Me.chkFechas.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.rbtnTodasEstatus)
        Me.GroupBox6.Controls.Add(Me.rbtnCanceladas)
        Me.GroupBox6.Controls.Add(Me.rbtnVigentes)
        Me.GroupBox6.Location = New System.Drawing.Point(276, 41)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(114, 97)
        Me.GroupBox6.TabIndex = 120
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Estatus"
        '
        'rbtnTodasEstatus
        '
        Me.rbtnTodasEstatus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtnTodasEstatus.AutoSize = True
        Me.rbtnTodasEstatus.Location = New System.Drawing.Point(6, 65)
        Me.rbtnTodasEstatus.Name = "rbtnTodasEstatus"
        Me.rbtnTodasEstatus.Size = New System.Drawing.Size(62, 17)
        Me.rbtnTodasEstatus.TabIndex = 3
        Me.rbtnTodasEstatus.Text = "TODAS"
        Me.rbtnTodasEstatus.UseVisualStyleBackColor = True
        '
        'rbtnCanceladas
        '
        Me.rbtnCanceladas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtnCanceladas.AutoSize = True
        Me.rbtnCanceladas.Location = New System.Drawing.Point(6, 42)
        Me.rbtnCanceladas.Name = "rbtnCanceladas"
        Me.rbtnCanceladas.Size = New System.Drawing.Size(96, 17)
        Me.rbtnCanceladas.TabIndex = 2
        Me.rbtnCanceladas.Text = "CANCELADAS"
        Me.rbtnCanceladas.UseVisualStyleBackColor = True
        '
        'rbtnVigentes
        '
        Me.rbtnVigentes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtnVigentes.AutoSize = True
        Me.rbtnVigentes.Checked = True
        Me.rbtnVigentes.Location = New System.Drawing.Point(6, 19)
        Me.rbtnVigentes.Name = "rbtnVigentes"
        Me.rbtnVigentes.Size = New System.Drawing.Size(79, 17)
        Me.rbtnVigentes.TabIndex = 1
        Me.rbtnVigentes.TabStop = True
        Me.rbtnVigentes.Text = "VIGENTES"
        Me.rbtnVigentes.UseVisualStyleBackColor = True
        '
        'btnaceptar
        '
        Me.btnaceptar.Location = New System.Drawing.Point(647, 615)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnaceptar.TabIndex = 121
        Me.btnaceptar.Text = "Aceptar"
        Me.btnaceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(743, 615)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 122
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'FrmBusquedaPolizas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 646)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.chkFechas)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GrpOrigen)
        Me.Controls.Add(Me.GrpTipo)
        Me.Controls.Add(Me.txtNoPoliza)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.mtb)
        Me.Name = "FrmBusquedaPolizas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Búsqueda de Polizas"
        CType(Me.DgvPolizas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DgvDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpTipo.ResumeLayout(False)
        Me.GrpTipo.PerformLayout()
        Me.GrpOrigen.ResumeLayout(False)
        Me.GrpOrigen.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents DgvPolizas As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNoPoliza As System.Windows.Forms.TextBox
    Friend WithEvents GrpTipo As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnCancelacion As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnDiario As System.Windows.Forms.RadioButton
    Friend WithEvents RbtnEgreso As System.Windows.Forms.RadioButton
    Friend WithEvents RbtnIngreso As System.Windows.Forms.RadioButton
    Friend WithEvents RbtnTodasTipo As System.Windows.Forms.RadioButton
    Friend WithEvents GrpOrigen As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnCxC As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnContabilidad As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnCompras As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnBancos As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnAlmacen As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnTodasOrigen As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnVentas As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnCxP As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents DtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DtpFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkFechas As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnTodasEstatus As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnCanceladas As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnVigentes As System.Windows.Forms.RadioButton
    Friend WithEvents DgvDetalles As System.Windows.Forms.DataGridView
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents clmCodPoliza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmNoPoliza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmConcepto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmOrigen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaCaptura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSubCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSSubCta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSSSubCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmAbono As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
