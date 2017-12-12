<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecepcionFacturasForm
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
        Me.lblEmpresa = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.DtpFechaCaptura = New System.Windows.Forms.DateTimePicker
        Me.CmbProveedor = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtFactura = New System.Windows.Forms.TextBox
        Me.DtpFechaFactura = New System.Windows.Forms.DateTimePicker
        Me.txtDiasPlazo = New System.Windows.Forms.TextBox
        Me.DtpFechaVencimiento = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtObservaciones = New System.Windows.Forms.TextBox
        Me.LblPolizaDiaria = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtCheque = New System.Windows.Forms.TextBox
        Me.txtPoliza = New System.Windows.Forms.TextBox
        Me.chkPagada = New System.Windows.Forms.CheckBox
        Me.TxtTotal = New System.Windows.Forms.TextBox
        Me.TxtAnticipo = New System.Windows.Forms.TextBox
        Me.txtIva = New System.Windows.Forms.TextBox
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DgvRecepciones = New System.Windows.Forms.DataGridView
        Me.Agregar = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Folio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaRecepcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaRetiro = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreProducto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadProducto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FolioOrden = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TmProveedor = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TxtSubtotal = New System.Windows.Forms.TextBox
        Me.chkServicio = New System.Windows.Forms.CheckBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtConcepto = New System.Windows.Forms.TextBox
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.GrpCuentas = New System.Windows.Forms.GroupBox
        Me.txtSumaCargo = New System.Windows.Forms.TextBox
        Me.DgvCuentas = New System.Windows.Forms.DataGridView
        Me.ClmCtaMayor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmSubCta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmSsbCta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmSssCta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmCargo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmAbono = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvRecepciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpCuentas.SuspendLayout()
        CType(Me.DgvCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEmpresa
        '
        Me.lblEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmpresa.Location = New System.Drawing.Point(116, 32)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(490, 20)
        Me.lblEmpresa.TabIndex = 63
        Me.lblEmpresa.Text = "Label3"
        Me.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblEmpresa.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(61, 36)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 13)
        Me.Label18.TabIndex = 65
        Me.Label18.Text = "Empresa:"
        Me.Label18.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Proveedor:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Folio Factura:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(274, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Fecha Recepción:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(74, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Fecha Factura:"
        '
        'DtpFechaCaptura
        '
        Me.DtpFechaCaptura.Enabled = False
        Me.DtpFechaCaptura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaCaptura.Location = New System.Drawing.Point(371, 87)
        Me.DtpFechaCaptura.Name = "DtpFechaCaptura"
        Me.DtpFechaCaptura.Size = New System.Drawing.Size(100, 20)
        Me.DtpFechaCaptura.TabIndex = 71
        '
        'CmbProveedor
        '
        Me.CmbProveedor.FormattingEnabled = True
        Me.CmbProveedor.Location = New System.Drawing.Point(151, 60)
        Me.CmbProveedor.Name = "CmbProveedor"
        Me.CmbProveedor.Size = New System.Drawing.Size(320, 21)
        Me.CmbProveedor.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.CmbProveedor, "Presione F12 para Actualizar la Lista de Proveedores")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(274, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Días de Plazo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(481, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Fecha Vencimiento:"
        '
        'TxtFactura
        '
        Me.TxtFactura.Location = New System.Drawing.Point(153, 86)
        Me.TxtFactura.Name = "TxtFactura"
        Me.TxtFactura.Size = New System.Drawing.Size(100, 20)
        Me.TxtFactura.TabIndex = 1
        '
        'DtpFechaFactura
        '
        Me.DtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaFactura.Location = New System.Drawing.Point(181, 111)
        Me.DtpFechaFactura.Name = "DtpFechaFactura"
        Me.DtpFechaFactura.Size = New System.Drawing.Size(87, 20)
        Me.DtpFechaFactura.TabIndex = 2
        '
        'txtDiasPlazo
        '
        Me.txtDiasPlazo.Enabled = False
        Me.txtDiasPlazo.Location = New System.Drawing.Point(371, 111)
        Me.txtDiasPlazo.Name = "txtDiasPlazo"
        Me.txtDiasPlazo.Size = New System.Drawing.Size(100, 20)
        Me.txtDiasPlazo.TabIndex = 3
        '
        'DtpFechaVencimiento
        '
        Me.DtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaVencimiento.Location = New System.Drawing.Point(588, 111)
        Me.DtpFechaVencimiento.Name = "DtpFechaVencimiento"
        Me.DtpFechaVencimiento.Size = New System.Drawing.Size(87, 20)
        Me.DtpFechaVencimiento.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(504, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "SubTotal:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(509, 169)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "IVA:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(509, 195)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 82
        Me.Label10.Text = "Anticipo:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(509, 222)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 83
        Me.Label11.Text = "Total:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(75, 199)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 13)
        Me.Label12.TabIndex = 84
        Me.Label12.Text = "Observaciones:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Location = New System.Drawing.Point(181, 196)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(317, 48)
        Me.txtObservaciones.TabIndex = 5
        '
        'LblPolizaDiaria
        '
        Me.LblPolizaDiaria.BackColor = System.Drawing.Color.SteelBlue
        Me.LblPolizaDiaria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblPolizaDiaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPolizaDiaria.ForeColor = System.Drawing.Color.White
        Me.LblPolizaDiaria.Location = New System.Drawing.Point(129, 32)
        Me.LblPolizaDiaria.Name = "LblPolizaDiaria"
        Me.LblPolizaDiaria.Size = New System.Drawing.Size(490, 20)
        Me.LblPolizaDiaria.TabIndex = 91
        Me.LblPolizaDiaria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblPolizaDiaria.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(619, 63)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "Cheque:"
        Me.Label9.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(619, 88)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 13)
        Me.Label13.TabIndex = 93
        Me.Label13.Text = "Póliza:"
        Me.Label13.Visible = False
        '
        'txtCheque
        '
        Me.txtCheque.Location = New System.Drawing.Point(672, 61)
        Me.txtCheque.Name = "txtCheque"
        Me.txtCheque.Size = New System.Drawing.Size(100, 20)
        Me.txtCheque.TabIndex = 94
        Me.txtCheque.Visible = False
        '
        'txtPoliza
        '
        Me.txtPoliza.Location = New System.Drawing.Point(672, 87)
        Me.txtPoliza.Name = "txtPoliza"
        Me.txtPoliza.Size = New System.Drawing.Size(100, 20)
        Me.txtPoliza.TabIndex = 95
        Me.txtPoliza.Visible = False
        '
        'chkPagada
        '
        Me.chkPagada.AutoSize = True
        Me.chkPagada.Location = New System.Drawing.Point(501, 87)
        Me.chkPagada.Name = "chkPagada"
        Me.chkPagada.Size = New System.Drawing.Size(63, 17)
        Me.chkPagada.TabIndex = 96
        Me.chkPagada.Text = "Pagada"
        Me.chkPagada.UseVisualStyleBackColor = True
        Me.chkPagada.Visible = False
        '
        'TxtTotal
        '
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Location = New System.Drawing.Point(577, 219)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(98, 20)
        Me.TxtTotal.TabIndex = 9
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtAnticipo
        '
        Me.TxtAnticipo.Location = New System.Drawing.Point(577, 192)
        Me.TxtAnticipo.Name = "TxtAnticipo"
        Me.TxtAnticipo.Size = New System.Drawing.Size(98, 20)
        Me.TxtAnticipo.TabIndex = 8
        Me.TxtAnticipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIva
        '
        Me.txtIva.Enabled = False
        Me.txtIva.Location = New System.Drawing.Point(577, 166)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.Size = New System.Drawing.Size(98, 20)
        Me.txtIva.TabIndex = 7
        Me.txtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.lblTitulo.Size = New System.Drawing.Size(727, 29)
        Me.lblTitulo.TabIndex = 98
        Me.lblTitulo.Text = "RECEPCIÓN DE FACTURAS DE PROVEEDORES"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEstatus
        '
        Me.lblEstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(639, 31)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(122, 21)
        Me.lblEstatus.TabIndex = 99
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DgvRecepciones)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(74, 250)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(601, 176)
        Me.GroupBox2.TabIndex = 100
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Recepciones"
        '
        'DgvRecepciones
        '
        Me.DgvRecepciones.AllowUserToAddRows = False
        Me.DgvRecepciones.AllowUserToDeleteRows = False
        Me.DgvRecepciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRecepciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Agregar, Me.Folio, Me.FechaRecepcion, Me.FechaRetiro, Me.NombreProducto, Me.CantidadProducto, Me.Precio, Me.Importe, Me.FolioOrden})
        Me.DgvRecepciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvRecepciones.Location = New System.Drawing.Point(3, 16)
        Me.DgvRecepciones.MultiSelect = False
        Me.DgvRecepciones.Name = "DgvRecepciones"
        Me.DgvRecepciones.RowHeadersVisible = False
        Me.DgvRecepciones.RowHeadersWidth = 20
        Me.DgvRecepciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvRecepciones.Size = New System.Drawing.Size(595, 157)
        Me.DgvRecepciones.TabIndex = 0
        '
        'Agregar
        '
        Me.Agregar.HeaderText = "Agregar"
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Agregar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Agregar.Width = 60
        '
        'Folio
        '
        Me.Folio.HeaderText = "Folio"
        Me.Folio.Name = "Folio"
        Me.Folio.ReadOnly = True
        '
        'FechaRecepcion
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.FechaRecepcion.DefaultCellStyle = DataGridViewCellStyle1
        Me.FechaRecepcion.HeaderText = "Fecha"
        Me.FechaRecepcion.Name = "FechaRecepcion"
        Me.FechaRecepcion.ReadOnly = True
        '
        'FechaRetiro
        '
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.FechaRetiro.DefaultCellStyle = DataGridViewCellStyle2
        Me.FechaRetiro.HeaderText = "Fecha Retiro"
        Me.FechaRetiro.Name = "FechaRetiro"
        Me.FechaRetiro.ReadOnly = True
        Me.FechaRetiro.Visible = False
        '
        'NombreProducto
        '
        Me.NombreProducto.HeaderText = "Producto"
        Me.NombreProducto.Name = "NombreProducto"
        Me.NombreProducto.ReadOnly = True
        Me.NombreProducto.Visible = False
        '
        'CantidadProducto
        '
        Me.CantidadProducto.DataPropertyName = "Cantidad"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.CantidadProducto.DefaultCellStyle = DataGridViewCellStyle3
        Me.CantidadProducto.HeaderText = "Cantidad"
        Me.CantidadProducto.Name = "CantidadProducto"
        Me.CantidadProducto.ReadOnly = True
        '
        'Precio
        '
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Precio.DefaultCellStyle = DataGridViewCellStyle4
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Visible = False
        '
        'Importe
        '
        Me.Importe.DataPropertyName = "Total"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.Importe.DefaultCellStyle = DataGridViewCellStyle5
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        '
        'FolioOrden
        '
        Me.FolioOrden.HeaderText = "Folio O.C."
        Me.FolioOrden.Name = "FolioOrden"
        Me.FolioOrden.ReadOnly = True
        Me.FolioOrden.Width = 120
        '
        'TmProveedor
        '
        Me.TmProveedor.Interval = 1000
        '
        'ToolTip1
        '
        Me.ToolTip1.ShowAlways = True
        '
        'TxtSubtotal
        '
        Me.TxtSubtotal.Location = New System.Drawing.Point(577, 140)
        Me.TxtSubtotal.Name = "TxtSubtotal"
        Me.TxtSubtotal.Size = New System.Drawing.Size(98, 20)
        Me.TxtSubtotal.TabIndex = 6
        Me.TxtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkServicio
        '
        Me.chkServicio.AutoSize = True
        Me.chkServicio.Location = New System.Drawing.Point(501, 63)
        Me.chkServicio.Name = "chkServicio"
        Me.chkServicio.Size = New System.Drawing.Size(118, 17)
        Me.chkServicio.TabIndex = 101
        Me.chkServicio.Text = "Factura de Servicio"
        Me.chkServicio.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(74, 147)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 13)
        Me.Label14.TabIndex = 102
        Me.Label14.Text = "Concepto:"
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(181, 144)
        Me.txtConcepto.Multiline = True
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(317, 46)
        Me.txtConcepto.TabIndex = 103
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
        Me.mtb.MostrarBorrar = True
        Me.mtb.MostrarBuscar = True
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = True
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 597)
        Me.mtb.TabIndex = 66
        '
        'GrpCuentas
        '
        Me.GrpCuentas.Controls.Add(Me.txtSumaCargo)
        Me.GrpCuentas.Controls.Add(Me.DgvCuentas)
        Me.GrpCuentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpCuentas.Location = New System.Drawing.Point(71, 432)
        Me.GrpCuentas.Name = "GrpCuentas"
        Me.GrpCuentas.Size = New System.Drawing.Size(601, 161)
        Me.GrpCuentas.TabIndex = 145
        Me.GrpCuentas.TabStop = False
        Me.GrpCuentas.Text = "Cuentas Contables a Cargar el Servicio"
        '
        'txtSumaCargo
        '
        Me.txtSumaCargo.Enabled = False
        Me.txtSumaCargo.Location = New System.Drawing.Point(472, 137)
        Me.txtSumaCargo.Name = "txtSumaCargo"
        Me.txtSumaCargo.Size = New System.Drawing.Size(100, 20)
        Me.txtSumaCargo.TabIndex = 1
        '
        'DgvCuentas
        '
        Me.DgvCuentas.AllowUserToAddRows = False
        Me.DgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClmCtaMayor, Me.ClmSubCta, Me.ClmSsbCta, Me.ClmSssCta, Me.ClmDescripcion, Me.ClmCargo, Me.ClmAbono})
        Me.DgvCuentas.Location = New System.Drawing.Point(3, 16)
        Me.DgvCuentas.Name = "DgvCuentas"
        Me.DgvCuentas.RowHeadersVisible = False
        Me.DgvCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCuentas.Size = New System.Drawing.Size(595, 117)
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
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.ClmCargo.DefaultCellStyle = DataGridViewCellStyle6
        Me.ClmCargo.HeaderText = "Cargo"
        Me.ClmCargo.Name = "ClmCargo"
        '
        'ClmAbono
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.ClmAbono.DefaultCellStyle = DataGridViewCellStyle7
        Me.ClmAbono.HeaderText = "Abono"
        Me.ClmAbono.Name = "ClmAbono"
        Me.ClmAbono.Visible = False
        '
        'RecepcionFacturasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 597)
        Me.Controls.Add(Me.GrpCuentas)
        Me.Controls.Add(Me.txtConcepto)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.chkServicio)
        Me.Controls.Add(Me.TxtSubtotal)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblEstatus)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.chkPagada)
        Me.Controls.Add(Me.txtPoliza)
        Me.Controls.Add(Me.txtCheque)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LblPolizaDiaria)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.TxtAnticipo)
        Me.Controls.Add(Me.txtIva)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DtpFechaVencimiento)
        Me.Controls.Add(Me.txtDiasPlazo)
        Me.Controls.Add(Me.DtpFechaFactura)
        Me.Controls.Add(Me.TxtFactura)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CmbProveedor)
        Me.Controls.Add(Me.DtpFechaCaptura)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.lblEmpresa)
        Me.Controls.Add(Me.Label18)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "RecepcionFacturasForm"
        Me.Text = "Recepción de Facturas de Proveedores"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DgvRecepciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpCuentas.ResumeLayout(False)
        Me.GrpCuentas.PerformLayout()
        CType(Me.DgvCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEmpresa As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DtpFechaCaptura As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtFactura As System.Windows.Forms.TextBox
    Friend WithEvents DtpFechaFactura As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDiasPlazo As System.Windows.Forms.TextBox
    Friend WithEvents DtpFechaVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents LblPolizaDiaria As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCheque As System.Windows.Forms.TextBox
    Friend WithEvents txtPoliza As System.Windows.Forms.TextBox
    Friend WithEvents chkPagada As System.Windows.Forms.CheckBox
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents TxtAnticipo As System.Windows.Forms.TextBox
    Friend WithEvents txtIva As System.Windows.Forms.TextBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DgvRecepciones As System.Windows.Forms.DataGridView
    'ojo
    'Friend WithEvents ListaContratosCompraTypedView1 As IntegraLab.ORM.TypedViewClasses.ListaContratosCompraTypedView
    'Friend WithEvents ListaContratoVentaTypedView1 As IntegraLab.ORM.TypedViewClasses.ListaContratoVentaTypedView
    Friend WithEvents TmProveedor As System.Windows.Forms.Timer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TxtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents chkServicio As System.Windows.Forms.CheckBox
    Friend WithEvents Agregar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Folio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaRecepcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaRetiro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FolioOrden As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents GrpCuentas As System.Windows.Forms.GroupBox
    Friend WithEvents DgvCuentas As System.Windows.Forms.DataGridView
    Friend WithEvents txtSumaCargo As System.Windows.Forms.TextBox
    Friend WithEvents ClmCtaMayor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmSubCta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmSsbCta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmSssCta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmCargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmAbono As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
