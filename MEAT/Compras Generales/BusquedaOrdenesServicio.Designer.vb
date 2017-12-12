<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusquedaOrdenesServicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GrpRecibidas = New System.Windows.Forms.GroupBox
        Me.RbtRecTodas = New System.Windows.Forms.RadioButton
        Me.RbtRecNo = New System.Windows.Forms.RadioButton
        Me.RbtRecSI = New System.Windows.Forms.RadioButton
        Me.GrpAutorizadas = New System.Windows.Forms.GroupBox
        Me.RbtautorizadasTodas = New System.Windows.Forms.RadioButton
        Me.RbtNo = New System.Windows.Forms.RadioButton
        Me.RbtSi = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbtTodas = New System.Windows.Forms.RadioButton
        Me.rbtCanceladas = New System.Windows.Forms.RadioButton
        Me.rbtActivas = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.clmFolio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPlaza = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmSucursal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPreveedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmSubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmDescuento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIva = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmMoneda = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmDiasCredito = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmAutorizada = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cllmRecibida = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtFolioOrden = New System.Windows.Forms.TextBox
        Me.cmbProveedor = New System.Windows.Forms.ComboBox
        Me.cmbSucursal = New System.Windows.Forms.ComboBox
        Me.cmbPlaza = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar
        Me.GrpRecibidas.SuspendLayout()
        Me.GrpAutorizadas.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpRecibidas
        '
        Me.GrpRecibidas.Controls.Add(Me.RbtRecTodas)
        Me.GrpRecibidas.Controls.Add(Me.RbtRecNo)
        Me.GrpRecibidas.Controls.Add(Me.RbtRecSI)
        Me.GrpRecibidas.Location = New System.Drawing.Point(505, 32)
        Me.GrpRecibidas.Name = "GrpRecibidas"
        Me.GrpRecibidas.Size = New System.Drawing.Size(194, 45)
        Me.GrpRecibidas.TabIndex = 55
        Me.GrpRecibidas.TabStop = False
        Me.GrpRecibidas.Text = "Recibidas"
        '
        'RbtRecTodas
        '
        Me.RbtRecTodas.AutoSize = True
        Me.RbtRecTodas.Checked = True
        Me.RbtRecTodas.Location = New System.Drawing.Point(126, 19)
        Me.RbtRecTodas.Name = "RbtRecTodas"
        Me.RbtRecTodas.Size = New System.Drawing.Size(55, 17)
        Me.RbtRecTodas.TabIndex = 3
        Me.RbtRecTodas.TabStop = True
        Me.RbtRecTodas.Text = "Todas"
        Me.RbtRecTodas.UseVisualStyleBackColor = True
        '
        'RbtRecNo
        '
        Me.RbtRecNo.AutoSize = True
        Me.RbtRecNo.Location = New System.Drawing.Point(69, 19)
        Me.RbtRecNo.Name = "RbtRecNo"
        Me.RbtRecNo.Size = New System.Drawing.Size(39, 17)
        Me.RbtRecNo.TabIndex = 1
        Me.RbtRecNo.Text = "No"
        Me.RbtRecNo.UseVisualStyleBackColor = True
        '
        'RbtRecSI
        '
        Me.RbtRecSI.AutoSize = True
        Me.RbtRecSI.Location = New System.Drawing.Point(6, 19)
        Me.RbtRecSI.Name = "RbtRecSI"
        Me.RbtRecSI.Size = New System.Drawing.Size(34, 17)
        Me.RbtRecSI.TabIndex = 0
        Me.RbtRecSI.Text = "Si"
        Me.RbtRecSI.UseVisualStyleBackColor = True
        '
        'GrpAutorizadas
        '
        Me.GrpAutorizadas.Controls.Add(Me.RbtautorizadasTodas)
        Me.GrpAutorizadas.Controls.Add(Me.RbtNo)
        Me.GrpAutorizadas.Controls.Add(Me.RbtSi)
        Me.GrpAutorizadas.Location = New System.Drawing.Point(735, 88)
        Me.GrpAutorizadas.Name = "GrpAutorizadas"
        Me.GrpAutorizadas.Size = New System.Drawing.Size(171, 49)
        Me.GrpAutorizadas.TabIndex = 54
        Me.GrpAutorizadas.TabStop = False
        Me.GrpAutorizadas.Text = "Autorizadas"
        '
        'RbtautorizadasTodas
        '
        Me.RbtautorizadasTodas.AutoSize = True
        Me.RbtautorizadasTodas.Checked = True
        Me.RbtautorizadasTodas.Location = New System.Drawing.Point(104, 19)
        Me.RbtautorizadasTodas.Name = "RbtautorizadasTodas"
        Me.RbtautorizadasTodas.Size = New System.Drawing.Size(55, 17)
        Me.RbtautorizadasTodas.TabIndex = 5
        Me.RbtautorizadasTodas.TabStop = True
        Me.RbtautorizadasTodas.Text = "Todas"
        Me.RbtautorizadasTodas.UseVisualStyleBackColor = True
        '
        'RbtNo
        '
        Me.RbtNo.AutoSize = True
        Me.RbtNo.Location = New System.Drawing.Point(59, 19)
        Me.RbtNo.Name = "RbtNo"
        Me.RbtNo.Size = New System.Drawing.Size(39, 17)
        Me.RbtNo.TabIndex = 4
        Me.RbtNo.Text = "No"
        Me.RbtNo.UseVisualStyleBackColor = True
        '
        'RbtSi
        '
        Me.RbtSi.AutoSize = True
        Me.RbtSi.Location = New System.Drawing.Point(7, 19)
        Me.RbtSi.Name = "RbtSi"
        Me.RbtSi.Size = New System.Drawing.Size(34, 17)
        Me.RbtSi.TabIndex = 3
        Me.RbtSi.Text = "Si"
        Me.RbtSi.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.rbtTodas)
        Me.GroupBox2.Controls.Add(Me.rbtCanceladas)
        Me.GroupBox2.Controls.Add(Me.rbtActivas)
        Me.GroupBox2.Location = New System.Drawing.Point(505, 86)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(224, 49)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estatus"
        '
        'rbtTodas
        '
        Me.rbtTodas.AutoSize = True
        Me.rbtTodas.Checked = True
        Me.rbtTodas.Location = New System.Drawing.Point(159, 20)
        Me.rbtTodas.Name = "rbtTodas"
        Me.rbtTodas.Size = New System.Drawing.Size(55, 17)
        Me.rbtTodas.TabIndex = 2
        Me.rbtTodas.TabStop = True
        Me.rbtTodas.Text = "Todas"
        Me.rbtTodas.UseVisualStyleBackColor = True
        '
        'rbtCanceladas
        '
        Me.rbtCanceladas.AutoSize = True
        Me.rbtCanceladas.Location = New System.Drawing.Point(72, 20)
        Me.rbtCanceladas.Name = "rbtCanceladas"
        Me.rbtCanceladas.Size = New System.Drawing.Size(81, 17)
        Me.rbtCanceladas.TabIndex = 1
        Me.rbtCanceladas.Text = "Canceladas"
        Me.rbtCanceladas.UseVisualStyleBackColor = True
        '
        'rbtActivas
        '
        Me.rbtActivas.AutoSize = True
        Me.rbtActivas.Location = New System.Drawing.Point(6, 19)
        Me.rbtActivas.Name = "rbtActivas"
        Me.rbtActivas.Size = New System.Drawing.Size(60, 17)
        Me.rbtActivas.TabIndex = 0
        Me.rbtActivas.Text = "Activas"
        Me.rbtActivas.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(56, 143)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(850, 290)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de Ordenes de Servicio"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmFolio, Me.clmPlaza, Me.clmSucursal, Me.clmPreveedor, Me.clmFecha, Me.clmSubTotal, Me.clmDescuento, Me.clmIva, Me.clmTotal, Me.clmMoneda, Me.clmDiasCredito, Me.clmAutorizada, Me.cllmRecibida, Me.clmEstatus, Me.clmObservaciones})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 22)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(835, 258)
        Me.DataGridView1.TabIndex = 0
        '
        'clmFolio
        '
        Me.clmFolio.DataPropertyName = "Folio"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.clmFolio.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmFolio.HeaderText = "Folio"
        Me.clmFolio.Name = "clmFolio"
        Me.clmFolio.ReadOnly = True
        '
        'clmPlaza
        '
        Me.clmPlaza.DataPropertyName = "Plaza"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.clmPlaza.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmPlaza.HeaderText = "Plaza"
        Me.clmPlaza.Name = "clmPlaza"
        Me.clmPlaza.ReadOnly = True
        '
        'clmSucursal
        '
        Me.clmSucursal.DataPropertyName = "Sucursal"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.clmSucursal.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmSucursal.HeaderText = "Sucursal"
        Me.clmSucursal.Name = "clmSucursal"
        Me.clmSucursal.ReadOnly = True
        '
        'clmPreveedor
        '
        Me.clmPreveedor.DataPropertyName = "Proveedor"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.clmPreveedor.DefaultCellStyle = DataGridViewCellStyle4
        Me.clmPreveedor.HeaderText = "Proveedor"
        Me.clmPreveedor.Name = "clmPreveedor"
        Me.clmPreveedor.ReadOnly = True
        '
        'clmFecha
        '
        Me.clmFecha.DataPropertyName = "FechaAlta"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "d"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.clmFecha.DefaultCellStyle = DataGridViewCellStyle5
        Me.clmFecha.HeaderText = "Fecha"
        Me.clmFecha.Name = "clmFecha"
        Me.clmFecha.ReadOnly = True
        '
        'clmSubTotal
        '
        Me.clmSubTotal.DataPropertyName = "SubTotal"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.clmSubTotal.DefaultCellStyle = DataGridViewCellStyle6
        Me.clmSubTotal.HeaderText = "Sub Total"
        Me.clmSubTotal.Name = "clmSubTotal"
        Me.clmSubTotal.ReadOnly = True
        Me.clmSubTotal.Width = 130
        '
        'clmDescuento
        '
        Me.clmDescuento.DataPropertyName = "Descuento"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.clmDescuento.DefaultCellStyle = DataGridViewCellStyle7
        Me.clmDescuento.HeaderText = "Descuento"
        Me.clmDescuento.Name = "clmDescuento"
        Me.clmDescuento.ReadOnly = True
        '
        'clmIva
        '
        Me.clmIva.DataPropertyName = "Iva"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.clmIva.DefaultCellStyle = DataGridViewCellStyle8
        Me.clmIva.HeaderText = "Iva"
        Me.clmIva.Name = "clmIva"
        Me.clmIva.ReadOnly = True
        '
        'clmTotal
        '
        Me.clmTotal.DataPropertyName = "Total"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.clmTotal.DefaultCellStyle = DataGridViewCellStyle9
        Me.clmTotal.HeaderText = "Total"
        Me.clmTotal.Name = "clmTotal"
        Me.clmTotal.ReadOnly = True
        '
        'clmMoneda
        '
        Me.clmMoneda.DataPropertyName = "TipoMoneda"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.clmMoneda.DefaultCellStyle = DataGridViewCellStyle10
        Me.clmMoneda.HeaderText = "Moneda"
        Me.clmMoneda.Name = "clmMoneda"
        Me.clmMoneda.ReadOnly = True
        '
        'clmDiasCredito
        '
        Me.clmDiasCredito.DataPropertyName = "DiasCredito"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.clmDiasCredito.DefaultCellStyle = DataGridViewCellStyle11
        Me.clmDiasCredito.HeaderText = "Dias Crédito"
        Me.clmDiasCredito.Name = "clmDiasCredito"
        Me.clmDiasCredito.ReadOnly = True
        Me.clmDiasCredito.Width = 130
        '
        'clmAutorizada
        '
        Me.clmAutorizada.DataPropertyName = "Autorizada"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.clmAutorizada.DefaultCellStyle = DataGridViewCellStyle12
        Me.clmAutorizada.HeaderText = "Autorizada"
        Me.clmAutorizada.Name = "clmAutorizada"
        Me.clmAutorizada.ReadOnly = True
        '
        'cllmRecibida
        '
        Me.cllmRecibida.DataPropertyName = "Recibida"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.cllmRecibida.DefaultCellStyle = DataGridViewCellStyle13
        Me.cllmRecibida.HeaderText = "Recibida"
        Me.cllmRecibida.Name = "cllmRecibida"
        Me.cllmRecibida.ReadOnly = True
        '
        'clmEstatus
        '
        Me.clmEstatus.DataPropertyName = "Estatus"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.clmEstatus.DefaultCellStyle = DataGridViewCellStyle14
        Me.clmEstatus.HeaderText = "Estatus"
        Me.clmEstatus.Name = "clmEstatus"
        Me.clmEstatus.ReadOnly = True
        '
        'clmObservaciones
        '
        Me.clmObservaciones.DataPropertyName = "Observaciones"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.clmObservaciones.DefaultCellStyle = DataGridViewCellStyle15
        Me.clmObservaciones.HeaderText = "Observaciones"
        Me.clmObservaciones.Name = "clmObservaciones"
        Me.clmObservaciones.ReadOnly = True
        Me.clmObservaciones.Width = 200
        '
        'txtFolioOrden
        '
        Me.txtFolioOrden.Location = New System.Drawing.Point(126, 37)
        Me.txtFolioOrden.MaxLength = 15
        Me.txtFolioOrden.Name = "txtFolioOrden"
        Me.txtFolioOrden.Size = New System.Drawing.Size(100, 20)
        Me.txtFolioOrden.TabIndex = 49
        '
        'cmbProveedor
        '
        Me.cmbProveedor.DisplayMember = "RazonSocial"
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(126, 116)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(373, 21)
        Me.cmbProveedor.TabIndex = 48
        Me.cmbProveedor.ValueMember = "Codigo"
        '
        'cmbSucursal
        '
        Me.cmbSucursal.DisplayMember = "Descripcion"
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(126, 90)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(373, 21)
        Me.cmbSucursal.TabIndex = 47
        Me.cmbSucursal.ValueMember = "Codigo"
        '
        'cmbPlaza
        '
        Me.cmbPlaza.DisplayMember = "Descripcion"
        Me.cmbPlaza.FormattingEnabled = True
        Me.cmbPlaza.Location = New System.Drawing.Point(126, 63)
        Me.cmbPlaza.Name = "cmbPlaza"
        Me.cmbPlaza.Size = New System.Drawing.Size(373, 21)
        Me.cmbPlaza.TabIndex = 46
        Me.cmbPlaza.ValueMember = "Codigo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(56, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Proveedor:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Folio Orden:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Sucursal:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Plaza:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(50, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(865, 29)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "BUSQUEDA DE ORDENES DE SERVICIO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MEAToolBar1
        '
        Me.MEAToolBar1.ButtonSize = New System.Drawing.Size(50, 50)
        Me.MEAToolBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MEAToolBar1.DropDownArrows = True
        Me.MEAToolBar1.HabilitarBorrar = False
        Me.MEAToolBar1.HabilitarBuscar = True
        Me.MEAToolBar1.HabilitarCancelar = False
        Me.MEAToolBar1.HabilitarEditar = False
        Me.MEAToolBar1.HabilitarGuardar = False
        Me.MEAToolBar1.HabilitarImprimir = False
        Me.MEAToolBar1.HabilitarLimpiar = True
        Me.MEAToolBar1.HabilitarNuevo = False
        Me.MEAToolBar1.HabilitarSalir = True
        Me.MEAToolBar1.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32
        Me.MEAToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.MEAToolBar1.MostrarBorrar = False
        Me.MEAToolBar1.MostrarBuscar = True
        Me.MEAToolBar1.MostrarCancelar = False
        Me.MEAToolBar1.MostrarEditar = False
        Me.MEAToolBar1.MostrarGuardar = False
        Me.MEAToolBar1.MostrarImprimir = False
        Me.MEAToolBar1.MostrarLimpiar = True
        Me.MEAToolBar1.MostrarNuevo = False
        Me.MEAToolBar1.MostrarSalir = True
        Me.MEAToolBar1.Name = "MEAToolBar1"
        Me.MEAToolBar1.ShowToolTips = True
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 440)
        Me.MEAToolBar1.TabIndex = 40
        '
        'BusquedaOrdenesServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 440)
        Me.Controls.Add(Me.GrpRecibidas)
        Me.Controls.Add(Me.GrpAutorizadas)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtFolioOrden)
        Me.Controls.Add(Me.cmbProveedor)
        Me.Controls.Add(Me.cmbSucursal)
        Me.Controls.Add(Me.cmbPlaza)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.MaximumSize = New System.Drawing.Size(923, 474)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(923, 474)
        Me.Name = "BusquedaOrdenesServicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BusquedaOrdenesServicio"
        Me.GrpRecibidas.ResumeLayout(False)
        Me.GrpRecibidas.PerformLayout()
        Me.GrpAutorizadas.ResumeLayout(False)
        Me.GrpAutorizadas.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpRecibidas As System.Windows.Forms.GroupBox
    Friend WithEvents RbtRecTodas As System.Windows.Forms.RadioButton
    Friend WithEvents RbtRecNo As System.Windows.Forms.RadioButton
    Friend WithEvents RbtRecSI As System.Windows.Forms.RadioButton
    Friend WithEvents GrpAutorizadas As System.Windows.Forms.GroupBox
    Friend WithEvents RbtautorizadasTodas As System.Windows.Forms.RadioButton
    Friend WithEvents RbtNo As System.Windows.Forms.RadioButton
    Friend WithEvents RbtSi As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtTodas As System.Windows.Forms.RadioButton
    Friend WithEvents rbtCanceladas As System.Windows.Forms.RadioButton
    Friend WithEvents rbtActivas As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtFolioOrden As System.Windows.Forms.TextBox
    Friend WithEvents cmbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPlaza As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents PlazaC As ClasesNegocio.PlazaCollectionClass
    Friend WithEvents ProveedorC As ClasesNegocio.ProveedorCollectionClass
    Friend WithEvents FolioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlazaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SucursalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaAltaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoMonedaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProveedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescuentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubTotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IvaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AutorizadaDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RecibidaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaAutorizacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaRecepcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiasCreditoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoCambioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SucursalC As ClasesNegocio.SucursalCollectionClass
    Friend WithEvents clmFolio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPlaza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSucursal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPreveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSubTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDescuento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmMoneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDiasCredito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmAutorizada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cllmRecibida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmObservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
