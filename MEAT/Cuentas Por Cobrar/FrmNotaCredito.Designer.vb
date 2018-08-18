<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNotaCredito
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFolioFactura = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.lblEstatus = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtSumaAbono = New System.Windows.Forms.TextBox()
        Me.txtSumaCargo = New System.Windows.Forms.TextBox()
        Me.dgvCuentasContables = New System.Windows.Forms.DataGridView()
        Me.clmCtaMayor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmSubCta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmSSubCta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmSSSubCta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmAbono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCodigoCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.clmCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmProductoServicio = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.clmDescripcionEspecial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmProductoDes = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.clmUnidadSat = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.clmUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmIVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmIVAdecimales = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmImporteDecimales = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmConIVA = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txtCodigoCliente = New System.Windows.Forms.TextBox()
        Me.txtRFC = New System.Windows.Forms.TextBox()
        Me.lblRFC = New System.Windows.Forms.Label()
        Me.LblClaveCliente = New System.Windows.Forms.Label()
        Me.lblUsoCFDI = New System.Windows.Forms.Label()
        Me.cmbUsoCFDI = New System.Windows.Forms.ComboBox()
        Me.dtpFechaVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dtFechaFactura = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ultcmbDomiciliosFiscales = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSerieFactura = New System.Windows.Forms.TextBox()
        Me.txtSerieFolio = New System.Windows.Forms.TextBox()
        Me.txtFolioRelacion = New System.Windows.Forms.TextBox()
        Me.lblRelacion = New System.Windows.Forms.Label()
        Me.txtRelacion = New System.Windows.Forms.TextBox()
        Me.btnRelacion = New System.Windows.Forms.Button()
        Me.CmbCliente = New System.Windows.Forms.ComboBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtIVA = New System.Windows.Forms.TextBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.gbFacturar = New System.Windows.Forms.GroupBox()
        Me.OptExternos = New System.Windows.Forms.RadioButton()
        Me.OptProductos = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rdCredito = New System.Windows.Forms.RadioButton()
        Me.rdContado = New System.Windows.Forms.RadioButton()
        Me.gbFormaPago = New System.Windows.Forms.GroupBox()
        Me.txtNumCta = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbmetododepago = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmbformadepago = New System.Windows.Forms.ComboBox()
        Me.txtDiasCredito = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CmbClientesVarios = New System.Windows.Forms.ComboBox()
        Me.txtlugarexpedicion = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtUUID = New System.Windows.Forms.TextBox()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvCuentasContables, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ultcmbDomiciliosFiscales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbFacturar.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.gbFormaPago.SuspendLayout()
        Me.SuspendLayout()
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
        Me.MEAToolBar1.MostrarEditar = False
        Me.MEAToolBar1.MostrarGuardar = True
        Me.MEAToolBar1.MostrarImprimir = True
        Me.MEAToolBar1.MostrarLimpiar = True
        Me.MEAToolBar1.MostrarNuevo = True
        Me.MEAToolBar1.MostrarSalir = True
        Me.MEAToolBar1.Name = "MEAToolBar1"
        Me.MEAToolBar1.ShowToolTips = True
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 693)
        Me.MEAToolBar1.TabIndex = 62
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.MaximumSize = New System.Drawing.Size(1600, 900)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(1070, 32)
        Me.Label17.TabIndex = 63
        Me.Label17.Text = "NOTAS DE CRÉDITO"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Folio:"
        '
        'txtFolioFactura
        '
        Me.txtFolioFactura.Location = New System.Drawing.Point(715, 14)
        Me.txtFolioFactura.Name = "txtFolioFactura"
        Me.txtFolioFactura.ReadOnly = True
        Me.txtFolioFactura.Size = New System.Drawing.Size(90, 20)
        Me.txtFolioFactura.TabIndex = 65
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Obervaciones:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Location = New System.Drawing.Point(98, 263)
        Me.txtObservaciones.MaxLength = 150
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(515, 77)
        Me.txtObservaciones.TabIndex = 73
        '
        'lblEstatus
        '
        Me.lblEstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(851, 8)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(132, 21)
        Me.lblEstatus.TabIndex = 86
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Folio"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Folio"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NomCliente"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NomConcepto"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Concepto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Estatus"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Estatus"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtSumaAbono)
        Me.GroupBox3.Controls.Add(Me.txtSumaCargo)
        Me.GroupBox3.Controls.Add(Me.dgvCuentasContables)
        Me.GroupBox3.Controls.Add(Me.dgvDetalle)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox3.Location = New System.Drawing.Point(10, 346)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(973, 282)
        Me.GroupBox3.TabIndex = 98
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalles de la Nota de Crédito"
        '
        'txtSumaAbono
        '
        Me.txtSumaAbono.Enabled = False
        Me.txtSumaAbono.Location = New System.Drawing.Point(852, 259)
        Me.txtSumaAbono.Name = "txtSumaAbono"
        Me.txtSumaAbono.Size = New System.Drawing.Size(110, 20)
        Me.txtSumaAbono.TabIndex = 24
        Me.txtSumaAbono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSumaCargo
        '
        Me.txtSumaCargo.Enabled = False
        Me.txtSumaCargo.Location = New System.Drawing.Point(727, 259)
        Me.txtSumaCargo.Name = "txtSumaCargo"
        Me.txtSumaCargo.Size = New System.Drawing.Size(110, 20)
        Me.txtSumaCargo.TabIndex = 23
        Me.txtSumaCargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvCuentasContables
        '
        Me.dgvCuentasContables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCuentasContables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCuentasContables.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmCtaMayor, Me.clmSubCta, Me.clmSSubCta, Me.clmSSSubCta, Me.clmDescripcion, Me.clmCargo, Me.clmAbono, Me.clmCodigoCuenta})
        Me.dgvCuentasContables.Location = New System.Drawing.Point(6, 161)
        Me.dgvCuentasContables.Name = "dgvCuentasContables"
        Me.dgvCuentasContables.Size = New System.Drawing.Size(958, 92)
        Me.dgvCuentasContables.TabIndex = 25
        '
        'clmCtaMayor
        '
        Me.clmCtaMayor.FillWeight = 7.0!
        Me.clmCtaMayor.HeaderText = "Cta"
        Me.clmCtaMayor.Name = "clmCtaMayor"
        Me.clmCtaMayor.ReadOnly = True
        '
        'clmSubCta
        '
        Me.clmSubCta.FillWeight = 7.0!
        Me.clmSubCta.HeaderText = "SCta"
        Me.clmSubCta.Name = "clmSubCta"
        Me.clmSubCta.ReadOnly = True
        '
        'clmSSubCta
        '
        Me.clmSSubCta.FillWeight = 7.0!
        Me.clmSSubCta.HeaderText = "SSCta"
        Me.clmSSubCta.Name = "clmSSubCta"
        Me.clmSSubCta.ReadOnly = True
        '
        'clmSSSubCta
        '
        Me.clmSSSubCta.FillWeight = 7.0!
        Me.clmSSSubCta.HeaderText = "SSSubCta"
        Me.clmSSSubCta.Name = "clmSSSubCta"
        Me.clmSSSubCta.ReadOnly = True
        '
        'clmDescripcion
        '
        Me.clmDescripcion.FillWeight = 46.0!
        Me.clmDescripcion.HeaderText = "Descripcion"
        Me.clmDescripcion.Name = "clmDescripcion"
        Me.clmDescripcion.ReadOnly = True
        '
        'clmCargo
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        Me.clmCargo.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmCargo.FillWeight = 13.0!
        Me.clmCargo.HeaderText = "Cargo"
        Me.clmCargo.Name = "clmCargo"
        '
        'clmAbono
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        Me.clmAbono.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmAbono.FillWeight = 13.0!
        Me.clmAbono.HeaderText = "Abono"
        Me.clmAbono.Name = "clmAbono"
        '
        'clmCodigoCuenta
        '
        Me.clmCodigoCuenta.HeaderText = "Codigo"
        Me.clmCodigoCuenta.Name = "clmCodigoCuenta"
        Me.clmCodigoCuenta.Visible = False
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDetalle.CausesValidation = False
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmCodigo, Me.clmProductoServicio, Me.clmDescripcionEspecial, Me.clmProductoDes, Me.clmUnidadSat, Me.clmUnidad, Me.clmCantidad, Me.clmPrecio, Me.clmIVA, Me.clmIVAdecimales, Me.clmImporte, Me.clmImporteDecimales, Me.clmConIVA})
        Me.dgvDetalle.Enabled = False
        Me.dgvDetalle.Location = New System.Drawing.Point(6, 22)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.RowHeadersVisible = False
        Me.dgvDetalle.Size = New System.Drawing.Size(960, 133)
        Me.dgvDetalle.TabIndex = 22
        '
        'clmCodigo
        '
        Me.clmCodigo.DataPropertyName = "CodigoProducto"
        Me.clmCodigo.FillWeight = 5.0!
        Me.clmCodigo.HeaderText = "Codigo"
        Me.clmCodigo.Name = "clmCodigo"
        Me.clmCodigo.ReadOnly = True
        '
        'clmProductoServicio
        '
        Me.clmProductoServicio.DataPropertyName = "Concepto"
        Me.clmProductoServicio.FillWeight = 25.0!
        Me.clmProductoServicio.HeaderText = "Producto/Servicio"
        Me.clmProductoServicio.Name = "clmProductoServicio"
        '
        'clmDescripcionEspecial
        '
        Me.clmDescripcionEspecial.FillWeight = 25.0!
        Me.clmDescripcionEspecial.HeaderText = "Descripcion"
        Me.clmDescripcionEspecial.Name = "clmDescripcionEspecial"
        Me.clmDescripcionEspecial.Visible = False
        '
        'clmProductoDes
        '
        Me.clmProductoDes.DataPropertyName = "Descripcion"
        Me.clmProductoDes.FillWeight = 25.0!
        Me.clmProductoDes.HeaderText = "Descripcion"
        Me.clmProductoDes.Name = "clmProductoDes"
        Me.clmProductoDes.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmProductoDes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'clmUnidadSat
        '
        Me.clmUnidadSat.DataPropertyName = "Concepto"
        Me.clmUnidadSat.FillWeight = 15.0!
        Me.clmUnidadSat.HeaderText = "Unidad SAT"
        Me.clmUnidadSat.Name = "clmUnidadSat"
        '
        'clmUnidad
        '
        Me.clmUnidad.FillWeight = 7.0!
        Me.clmUnidad.HeaderText = "Unidad"
        Me.clmUnidad.Name = "clmUnidad"
        Me.clmUnidad.ReadOnly = True
        '
        'clmCantidad
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        Me.clmCantidad.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmCantidad.FillWeight = 6.0!
        Me.clmCantidad.HeaderText = "Cantidad"
        Me.clmCantidad.Name = "clmCantidad"
        '
        'clmPrecio
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.clmPrecio.DefaultCellStyle = DataGridViewCellStyle4
        Me.clmPrecio.FillWeight = 9.0!
        Me.clmPrecio.HeaderText = "Precio"
        Me.clmPrecio.Name = "clmPrecio"
        '
        'clmIVA
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        Me.clmIVA.DefaultCellStyle = DataGridViewCellStyle5
        Me.clmIVA.FillWeight = 8.0!
        Me.clmIVA.HeaderText = "IVA"
        Me.clmIVA.Name = "clmIVA"
        '
        'clmIVAdecimales
        '
        Me.clmIVAdecimales.HeaderText = "IVA decimales"
        Me.clmIVAdecimales.Name = "clmIVAdecimales"
        Me.clmIVAdecimales.Visible = False
        '
        'clmImporte
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.clmImporte.DefaultCellStyle = DataGridViewCellStyle6
        Me.clmImporte.FillWeight = 12.0!
        Me.clmImporte.HeaderText = "Importe"
        Me.clmImporte.Name = "clmImporte"
        Me.clmImporte.ReadOnly = True
        '
        'clmImporteDecimales
        '
        Me.clmImporteDecimales.HeaderText = "Importe decimales"
        Me.clmImporteDecimales.Name = "clmImporteDecimales"
        Me.clmImporteDecimales.Visible = False
        '
        'clmConIVA
        '
        Me.clmConIVA.FillWeight = 5.0!
        Me.clmConIVA.HeaderText = "C/IVA"
        Me.clmConIVA.Name = "clmConIVA"
        Me.clmConIVA.Visible = False
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.Location = New System.Drawing.Point(99, 64)
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.Size = New System.Drawing.Size(88, 20)
        Me.txtCodigoCliente.TabIndex = 100
        '
        'txtRFC
        '
        Me.txtRFC.Enabled = False
        Me.txtRFC.Location = New System.Drawing.Point(99, 150)
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(101, 20)
        Me.txtRFC.TabIndex = 99
        '
        'lblRFC
        '
        Me.lblRFC.AutoSize = True
        Me.lblRFC.Location = New System.Drawing.Point(8, 156)
        Me.lblRFC.Name = "lblRFC"
        Me.lblRFC.Size = New System.Drawing.Size(43, 13)
        Me.lblRFC.TabIndex = 103
        Me.lblRFC.Text = "R.F.C. :"
        '
        'LblClaveCliente
        '
        Me.LblClaveCliente.AutoSize = True
        Me.LblClaveCliente.Location = New System.Drawing.Point(8, 67)
        Me.LblClaveCliente.Name = "LblClaveCliente"
        Me.LblClaveCliente.Size = New System.Drawing.Size(45, 13)
        Me.LblClaveCliente.TabIndex = 102
        Me.LblClaveCliente.Text = "Cliente :"
        '
        'lblUsoCFDI
        '
        Me.lblUsoCFDI.Location = New System.Drawing.Point(8, 182)
        Me.lblUsoCFDI.Name = "lblUsoCFDI"
        Me.lblUsoCFDI.Size = New System.Drawing.Size(99, 17)
        Me.lblUsoCFDI.TabIndex = 109
        Me.lblUsoCFDI.Text = "Uso de CFDI:"
        '
        'cmbUsoCFDI
        '
        Me.cmbUsoCFDI.FormattingEnabled = True
        Me.cmbUsoCFDI.Location = New System.Drawing.Point(98, 178)
        Me.cmbUsoCFDI.Name = "cmbUsoCFDI"
        Me.cmbUsoCFDI.Size = New System.Drawing.Size(515, 21)
        Me.cmbUsoCFDI.TabIndex = 110
        '
        'dtpFechaVencimiento
        '
        Me.dtpFechaVencimiento.Enabled = False
        Me.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaVencimiento.Location = New System.Drawing.Point(307, 38)
        Me.dtpFechaVencimiento.Name = "dtpFechaVencimiento"
        Me.dtpFechaVencimiento.Size = New System.Drawing.Size(88, 20)
        Me.dtpFechaVencimiento.TabIndex = 119
        Me.dtpFechaVencimiento.Value = New Date(2007, 7, 31, 0, 0, 0, 0)
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(199, 41)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(104, 13)
        Me.Label18.TabIndex = 121
        Me.Label18.Text = "Fecha Vencimiento :"
        '
        'dtFechaFactura
        '
        Me.dtFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaFactura.Location = New System.Drawing.Point(99, 38)
        Me.dtFechaFactura.Name = "dtFechaFactura"
        Me.dtFechaFactura.Size = New System.Drawing.Size(88, 20)
        Me.dtFechaFactura.TabIndex = 118
        Me.dtFechaFactura.Value = New Date(2007, 7, 31, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 120
        Me.Label4.Text = "Fecha :"
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
        Me.ultcmbDomiciliosFiscales.Location = New System.Drawing.Point(158, 158)
        Me.ultcmbDomiciliosFiscales.Name = "ultcmbDomiciliosFiscales"
        Me.ultcmbDomiciliosFiscales.Size = New System.Drawing.Size(514, 22)
        Me.ultcmbDomiciliosFiscales.TabIndex = 126
        Me.ultcmbDomiciliosFiscales.Text = "Seleccione el Domicilio Fiscal"
        Me.ultcmbDomiciliosFiscales.ValueMember = "IdRenglon"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 127
        Me.Label3.Text = "Domicilio Fiscal:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSerieFactura)
        Me.GroupBox1.Controls.Add(Me.txtSerieFolio)
        Me.GroupBox1.Controls.Add(Me.txtFolioRelacion)
        Me.GroupBox1.Controls.Add(Me.lblRelacion)
        Me.GroupBox1.Controls.Add(Me.txtRelacion)
        Me.GroupBox1.Controls.Add(Me.btnRelacion)
        Me.GroupBox1.Controls.Add(Me.CmbCliente)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.gbFacturar)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.gbFormaPago)
        Me.GroupBox1.Controls.Add(Me.txtDiasCredito)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.lblEstatus)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.CmbClientesVarios)
        Me.GroupBox1.Controls.Add(Me.txtlugarexpedicion)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.txtUUID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCodigoCliente)
        Me.GroupBox1.Controls.Add(Me.LblClaveCliente)
        Me.GroupBox1.Controls.Add(Me.cmbUsoCFDI)
        Me.GroupBox1.Controls.Add(Me.txtFolioFactura)
        Me.GroupBox1.Controls.Add(Me.lblUsoCFDI)
        Me.GroupBox1.Controls.Add(Me.txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtFechaFactura)
        Me.GroupBox1.Controls.Add(Me.dtpFechaVencimiento)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.lblRFC)
        Me.GroupBox1.Controls.Add(Me.txtRFC)
        Me.GroupBox1.Location = New System.Drawing.Point(59, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1002, 642)
        Me.GroupBox1.TabIndex = 128
        Me.GroupBox1.TabStop = False
        '
        'txtSerieFactura
        '
        Me.txtSerieFactura.Location = New System.Drawing.Point(619, 13)
        Me.txtSerieFactura.Name = "txtSerieFactura"
        Me.txtSerieFactura.ReadOnly = True
        Me.txtSerieFactura.Size = New System.Drawing.Size(90, 20)
        Me.txtSerieFactura.TabIndex = 181
        '
        'txtSerieFolio
        '
        Me.txtSerieFolio.Location = New System.Drawing.Point(99, 13)
        Me.txtSerieFolio.Name = "txtSerieFolio"
        Me.txtSerieFolio.ReadOnly = True
        Me.txtSerieFolio.Size = New System.Drawing.Size(90, 20)
        Me.txtSerieFolio.TabIndex = 180
        '
        'txtFolioRelacion
        '
        Me.txtFolioRelacion.Location = New System.Drawing.Point(609, 36)
        Me.txtFolioRelacion.Name = "txtFolioRelacion"
        Me.txtFolioRelacion.Size = New System.Drawing.Size(100, 20)
        Me.txtFolioRelacion.TabIndex = 179
        Me.txtFolioRelacion.Visible = False
        '
        'lblRelacion
        '
        Me.lblRelacion.AutoSize = True
        Me.lblRelacion.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblRelacion.Location = New System.Drawing.Point(7, 94)
        Me.lblRelacion.Name = "lblRelacion"
        Me.lblRelacion.Size = New System.Drawing.Size(79, 13)
        Me.lblRelacion.TabIndex = 178
        Me.lblRelacion.Text = "Relacion CFDI:"
        '
        'txtRelacion
        '
        Me.txtRelacion.BackColor = System.Drawing.SystemColors.Window
        Me.txtRelacion.Location = New System.Drawing.Point(99, 91)
        Me.txtRelacion.Name = "txtRelacion"
        Me.txtRelacion.ReadOnly = True
        Me.txtRelacion.Size = New System.Drawing.Size(396, 20)
        Me.txtRelacion.TabIndex = 177
        '
        'btnRelacion
        '
        Me.btnRelacion.Location = New System.Drawing.Point(501, 90)
        Me.btnRelacion.Name = "btnRelacion"
        Me.btnRelacion.Size = New System.Drawing.Size(112, 20)
        Me.btnRelacion.TabIndex = 175
        Me.btnRelacion.Text = "Agregar Relación"
        Me.btnRelacion.UseVisualStyleBackColor = True
        '
        'CmbCliente
        '
        Me.CmbCliente.DisplayMember = "Nombre"
        Me.CmbCliente.FormattingEnabled = True
        Me.CmbCliente.ItemHeight = 13
        Me.CmbCliente.Location = New System.Drawing.Point(202, 63)
        Me.CmbCliente.Name = "CmbCliente"
        Me.CmbCliente.Size = New System.Drawing.Size(412, 21)
        Me.CmbCliente.TabIndex = 129
        Me.CmbCliente.ValueMember = "IdCliente"
        '
        'txtDireccion
        '
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Location = New System.Drawing.Point(98, 236)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(483, 20)
        Me.txtDireccion.TabIndex = 129
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 239)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 130
        Me.Label2.Text = "Direccion :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtDescuento)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtTotal)
        Me.GroupBox2.Controls.Add(Me.txtIVA)
        Me.GroupBox2.Controls.Add(Me.txtSubTotal)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox2.Location = New System.Drawing.Point(801, 225)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(182, 119)
        Me.GroupBox2.TabIndex = 174
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Importes"
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(73, 41)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(99, 20)
        Me.txtDescuento.TabIndex = 18
        Me.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(8, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Descuento :"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(73, 93)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(99, 21)
        Me.txtTotal.TabIndex = 0
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIVA
        '
        Me.txtIVA.Enabled = False
        Me.txtIVA.Location = New System.Drawing.Point(73, 67)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.Size = New System.Drawing.Size(99, 20)
        Me.txtIVA.TabIndex = 0
        Me.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Enabled = False
        Me.txtSubTotal.Location = New System.Drawing.Point(73, 17)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(99, 20)
        Me.txtSubTotal.TabIndex = 0
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(8, 94)
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
        Me.Label15.Location = New System.Drawing.Point(8, 68)
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
        Me.Label16.Location = New System.Drawing.Point(8, 18)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 13)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "SubTotal :"
        '
        'gbFacturar
        '
        Me.gbFacturar.Controls.Add(Me.OptExternos)
        Me.gbFacturar.Controls.Add(Me.OptProductos)
        Me.gbFacturar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFacturar.ForeColor = System.Drawing.SystemColors.Highlight
        Me.gbFacturar.Location = New System.Drawing.Point(645, 224)
        Me.gbFacturar.Name = "gbFacturar"
        Me.gbFacturar.Size = New System.Drawing.Size(150, 55)
        Me.gbFacturar.TabIndex = 172
        Me.gbFacturar.TabStop = False
        Me.gbFacturar.Text = "Facturar"
        '
        'OptExternos
        '
        Me.OptExternos.AutoSize = True
        Me.OptExternos.Checked = True
        Me.OptExternos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptExternos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptExternos.Location = New System.Drawing.Point(86, 25)
        Me.OptExternos.Name = "OptExternos"
        Me.OptExternos.Size = New System.Drawing.Size(50, 17)
        Me.OptExternos.TabIndex = 17
        Me.OptExternos.TabStop = True
        Me.OptExternos.Text = "Otros"
        Me.OptExternos.UseVisualStyleBackColor = True
        '
        'OptProductos
        '
        Me.OptProductos.AutoSize = True
        Me.OptProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptProductos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptProductos.Location = New System.Drawing.Point(11, 25)
        Me.OptProductos.Name = "OptProductos"
        Me.OptProductos.Size = New System.Drawing.Size(65, 17)
        Me.OptProductos.TabIndex = 16
        Me.OptProductos.Text = "Articulos"
        Me.OptProductos.UseVisualStyleBackColor = True
        Me.OptProductos.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rdCredito)
        Me.GroupBox4.Controls.Add(Me.rdContado)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox4.Location = New System.Drawing.Point(645, 284)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(150, 60)
        Me.GroupBox4.TabIndex = 173
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tipo Factura"
        '
        'rdCredito
        '
        Me.rdCredito.AutoSize = True
        Me.rdCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdCredito.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdCredito.Location = New System.Drawing.Point(89, 26)
        Me.rdCredito.Name = "rdCredito"
        Me.rdCredito.Size = New System.Drawing.Size(58, 17)
        Me.rdCredito.TabIndex = 20
        Me.rdCredito.Text = "Crédito"
        Me.rdCredito.UseVisualStyleBackColor = True
        '
        'rdContado
        '
        Me.rdContado.AutoSize = True
        Me.rdContado.Checked = True
        Me.rdContado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdContado.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdContado.Location = New System.Drawing.Point(9, 26)
        Me.rdContado.Name = "rdContado"
        Me.rdContado.Size = New System.Drawing.Size(65, 17)
        Me.rdContado.TabIndex = 19
        Me.rdContado.TabStop = True
        Me.rdContado.Text = "Contado"
        Me.rdContado.UseVisualStyleBackColor = True
        '
        'gbFormaPago
        '
        Me.gbFormaPago.Controls.Add(Me.txtNumCta)
        Me.gbFormaPago.Controls.Add(Me.Label11)
        Me.gbFormaPago.Controls.Add(Me.Label10)
        Me.gbFormaPago.Controls.Add(Me.cmbmetododepago)
        Me.gbFormaPago.Controls.Add(Me.Label20)
        Me.gbFormaPago.Controls.Add(Me.cmbformadepago)
        Me.gbFormaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFormaPago.ForeColor = System.Drawing.SystemColors.Highlight
        Me.gbFormaPago.Location = New System.Drawing.Point(645, 68)
        Me.gbFormaPago.Name = "gbFormaPago"
        Me.gbFormaPago.Size = New System.Drawing.Size(338, 135)
        Me.gbFormaPago.TabIndex = 129
        Me.gbFormaPago.TabStop = False
        Me.gbFormaPago.Text = "Información del pago"
        '
        'txtNumCta
        '
        Me.txtNumCta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumCta.Location = New System.Drawing.Point(106, 106)
        Me.txtNumCta.MaxLength = 5
        Me.txtNumCta.Name = "txtNumCta"
        Me.txtNumCta.Size = New System.Drawing.Size(68, 20)
        Me.txtNumCta.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(6, 109)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Número de Cuenta:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(6, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Metodo de Pago:"
        '
        'cmbmetododepago
        '
        Me.cmbmetododepago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbmetododepago.FormattingEnabled = True
        Me.cmbmetododepago.Location = New System.Drawing.Point(7, 81)
        Me.cmbmetododepago.Name = "cmbmetododepago"
        Me.cmbmetododepago.Size = New System.Drawing.Size(325, 21)
        Me.cmbmetododepago.TabIndex = 13
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(6, 19)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(82, 13)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Forma de Pago:"
        '
        'cmbformadepago
        '
        Me.cmbformadepago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbformadepago.FormattingEnabled = True
        Me.cmbformadepago.ItemHeight = 13
        Me.cmbformadepago.Location = New System.Drawing.Point(6, 38)
        Me.cmbformadepago.Name = "cmbformadepago"
        Me.cmbformadepago.Size = New System.Drawing.Size(326, 21)
        Me.cmbformadepago.TabIndex = 12
        '
        'txtDiasCredito
        '
        Me.txtDiasCredito.Enabled = False
        Me.txtDiasCredito.Location = New System.Drawing.Point(554, 205)
        Me.txtDiasCredito.Name = "txtDiasCredito"
        Me.txtDiasCredito.ReadOnly = True
        Me.txtDiasCredito.Size = New System.Drawing.Size(59, 20)
        Me.txtDiasCredito.TabIndex = 170
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(477, 208)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 13)
        Me.Label14.TabIndex = 171
        Me.Label14.Text = "Días Crédito :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 169
        Me.Label6.Text = "Remitir a:"
        '
        'CmbClientesVarios
        '
        Me.CmbClientesVarios.FormattingEnabled = True
        Me.CmbClientesVarios.Location = New System.Drawing.Point(98, 205)
        Me.CmbClientesVarios.Name = "CmbClientesVarios"
        Me.CmbClientesVarios.Size = New System.Drawing.Size(312, 21)
        Me.CmbClientesVarios.TabIndex = 168
        Me.CmbClientesVarios.TabStop = False
        '
        'txtlugarexpedicion
        '
        Me.txtlugarexpedicion.Location = New System.Drawing.Point(315, 152)
        Me.txtlugarexpedicion.MaxLength = 200
        Me.txtlugarexpedicion.Name = "txtlugarexpedicion"
        Me.txtlugarexpedicion.Size = New System.Drawing.Size(298, 20)
        Me.txtlugarexpedicion.TabIndex = 160
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(199, 17)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(37, 13)
        Me.Label21.TabIndex = 166
        Me.Label21.Text = "UUID:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(208, 155)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(109, 13)
        Me.Label19.TabIndex = 161
        Me.Label19.Text = "Lugar de Expedicíon:"
        '
        'txtUUID
        '
        Me.txtUUID.BackColor = System.Drawing.SystemColors.Window
        Me.txtUUID.Location = New System.Drawing.Point(236, 13)
        Me.txtUUID.Name = "txtUUID"
        Me.txtUUID.ReadOnly = True
        Me.txtUUID.Size = New System.Drawing.Size(377, 20)
        Me.txtUUID.TabIndex = 167
        '
        'FrmNotaCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 693)
        Me.Controls.Add(Me.ultcmbDomiciliosFiscales)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmNotaCredito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notas de Crédito"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvCuentasContables, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ultcmbDomiciliosFiscales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbFacturar.ResumeLayout(False)
        Me.gbFacturar.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.gbFormaPago.ResumeLayout(False)
        Me.gbFormaPago.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvEmbarques As System.Windows.Forms.ListView
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFolioFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodigoCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtRFC As System.Windows.Forms.TextBox
    Friend WithEvents lblRFC As System.Windows.Forms.Label
    Friend WithEvents LblClaveCliente As System.Windows.Forms.Label
    Friend WithEvents lblUsoCFDI As System.Windows.Forms.Label
    Friend WithEvents cmbUsoCFDI As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFechaVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents dtFechaFactura As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ultcmbDomiciliosFiscales As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtUUID As System.Windows.Forms.TextBox
    Friend WithEvents txtlugarexpedicion As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CmbClientesVarios As System.Windows.Forms.ComboBox
    Friend WithEvents txtDiasCredito As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents gbFormaPago As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumCta As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbmetododepago As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cmbformadepago As System.Windows.Forms.ComboBox
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents clmCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmProductoServicio As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents clmDescripcionEspecial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmProductoDes As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents clmUnidadSat As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents clmUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPrecio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIVAdecimales As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmImporteDecimales As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmConIVA As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtIVA As System.Windows.Forms.TextBox
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents gbFacturar As System.Windows.Forms.GroupBox
    Friend WithEvents OptExternos As System.Windows.Forms.RadioButton
    Friend WithEvents OptProductos As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rdCredito As System.Windows.Forms.RadioButton
    Friend WithEvents rdContado As System.Windows.Forms.RadioButton
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSumaAbono As System.Windows.Forms.TextBox
    Friend WithEvents txtSumaCargo As System.Windows.Forms.TextBox
    Friend WithEvents dgvCuentasContables As System.Windows.Forms.DataGridView
    Friend WithEvents clmCtaMayor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSubCta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSSubCta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSSSubCta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmAbono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCodigoCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CmbCliente As System.Windows.Forms.ComboBox
    Friend WithEvents txtRelacion As System.Windows.Forms.TextBox
    Friend WithEvents btnRelacion As System.Windows.Forms.Button
    Friend WithEvents lblRelacion As System.Windows.Forms.Label
    Friend WithEvents txtFolioRelacion As System.Windows.Forms.TextBox
    Friend WithEvents txtSerieFactura As System.Windows.Forms.TextBox
    Friend WithEvents txtSerieFolio As System.Windows.Forms.TextBox
End Class
