<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecepcionesOrdenesDirectasMeat
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
        Me.GrpImportesPesos = New System.Windows.Forms.GroupBox
        Me.txtIVAFletesPesos = New System.Windows.Forms.TextBox
        Me.txtFletesPesos = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtTotalPesos = New System.Windows.Forms.TextBox
        Me.txtIvaPesos = New System.Windows.Forms.TextBox
        Me.txtSubTotalPesos = New System.Windows.Forms.TextBox
        Me.txtDescuentoPesos = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtImportePesos = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.cmbProveedor = New System.Windows.Forms.ComboBox
        Me.ProveedorC = New ClasesNegocio.ProveedorCollectionClass
        Me.cmbAlmacen = New System.Windows.Forms.ComboBox
        Me.AlmacenC = New ClasesNegocio.AlmacenCollectionClass
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtFletes = New Integralab.Controles.TextBoxMejorado
        Me.txtIVAFletes = New Integralab.Controles.TextBoxMejorado
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.txtIVA = New System.Windows.Forms.TextBox
        Me.txtSubTotal = New System.Windows.Forms.TextBox
        Me.txtDescuento = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtImporteTotal = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtSumaRecibir = New System.Windows.Forms.TextBox
        Me.dgvDetalleOrdenCompra = New System.Windows.Forms.DataGridView
        Me.clmIdProducto = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.clmCantSol = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCantOrd = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmDescuento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCantPend = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIva = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmImporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OrdenCompraDetalleC = New ClasesNegocio.OrdenCompraDetalleCollectionClass
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker
        Me.txtNoFactura = New System.Windows.Forms.TextBox
        Me.txtTipoCambio = New System.Windows.Forms.TextBox
        Me.txtFolio = New System.Windows.Forms.TextBox
        Me.cmbMoneda = New System.Windows.Forms.ComboBox
        Me.MonedaTC = New ClasesNegocio.TipoMonedaCollectionClass
        Me.cmbSucursal = New System.Windows.Forms.ComboBox
        Me.SucursalC = New ClasesNegocio.SucursalCollectionClass
        Me.cmbPlaza = New System.Windows.Forms.ComboBox
        Me.PlazaC = New ClasesNegocio.PlazaCollectionClass
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Mtb = New MEAToolBar.MEAToolBar
        Me.txtObservaciones = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.GrpImportesPesos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDetalleOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpImportesPesos
        '
        Me.GrpImportesPesos.Controls.Add(Me.txtIVAFletesPesos)
        Me.GrpImportesPesos.Controls.Add(Me.txtFletesPesos)
        Me.GrpImportesPesos.Controls.Add(Me.Label23)
        Me.GrpImportesPesos.Controls.Add(Me.Label24)
        Me.GrpImportesPesos.Controls.Add(Me.txtTotalPesos)
        Me.GrpImportesPesos.Controls.Add(Me.txtIvaPesos)
        Me.GrpImportesPesos.Controls.Add(Me.txtSubTotalPesos)
        Me.GrpImportesPesos.Controls.Add(Me.txtDescuentoPesos)
        Me.GrpImportesPesos.Controls.Add(Me.Label13)
        Me.GrpImportesPesos.Controls.Add(Me.Label19)
        Me.GrpImportesPesos.Controls.Add(Me.Label20)
        Me.GrpImportesPesos.Controls.Add(Me.Label21)
        Me.GrpImportesPesos.Controls.Add(Me.txtImportePesos)
        Me.GrpImportesPesos.Controls.Add(Me.Label22)
        Me.GrpImportesPesos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpImportesPesos.Location = New System.Drawing.Point(434, 202)
        Me.GrpImportesPesos.Name = "GrpImportesPesos"
        Me.GrpImportesPesos.Size = New System.Drawing.Size(185, 199)
        Me.GrpImportesPesos.TabIndex = 95
        Me.GrpImportesPesos.TabStop = False
        Me.GrpImportesPesos.Text = "Importes en Pesos"
        '
        'txtIVAFletesPesos
        '
        Me.txtIVAFletesPesos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIVAFletesPesos.Location = New System.Drawing.Point(87, 122)
        Me.txtIVAFletesPesos.Name = "txtIVAFletesPesos"
        Me.txtIVAFletesPesos.ReadOnly = True
        Me.txtIVAFletesPesos.Size = New System.Drawing.Size(92, 20)
        Me.txtIVAFletesPesos.TabIndex = 16
        Me.txtIVAFletesPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFletesPesos
        '
        Me.txtFletesPesos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFletesPesos.Location = New System.Drawing.Point(87, 97)
        Me.txtFletesPesos.Name = "txtFletesPesos"
        Me.txtFletesPesos.ReadOnly = True
        Me.txtFletesPesos.Size = New System.Drawing.Size(92, 20)
        Me.txtFletesPesos.TabIndex = 15
        Me.txtFletesPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 125)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(58, 13)
        Me.Label23.TabIndex = 50
        Me.Label23.Text = "IVA Fletes:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 100)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(38, 13)
        Me.Label24.TabIndex = 49
        Me.Label24.Text = "Fletes:"
        '
        'txtTotalPesos
        '
        Me.txtTotalPesos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalPesos.Location = New System.Drawing.Point(87, 173)
        Me.txtTotalPesos.Name = "txtTotalPesos"
        Me.txtTotalPesos.ReadOnly = True
        Me.txtTotalPesos.Size = New System.Drawing.Size(92, 20)
        Me.txtTotalPesos.TabIndex = 18
        Me.txtTotalPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIvaPesos
        '
        Me.txtIvaPesos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIvaPesos.Location = New System.Drawing.Point(87, 147)
        Me.txtIvaPesos.Name = "txtIvaPesos"
        Me.txtIvaPesos.ReadOnly = True
        Me.txtIvaPesos.Size = New System.Drawing.Size(92, 20)
        Me.txtIvaPesos.TabIndex = 17
        Me.txtIvaPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubTotalPesos
        '
        Me.txtSubTotalPesos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSubTotalPesos.Location = New System.Drawing.Point(87, 71)
        Me.txtSubTotalPesos.Name = "txtSubTotalPesos"
        Me.txtSubTotalPesos.ReadOnly = True
        Me.txtSubTotalPesos.Size = New System.Drawing.Size(92, 20)
        Me.txtSubTotalPesos.TabIndex = 14
        Me.txtSubTotalPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDescuentoPesos
        '
        Me.txtDescuentoPesos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescuentoPesos.Location = New System.Drawing.Point(87, 45)
        Me.txtDescuentoPesos.Name = "txtDescuentoPesos"
        Me.txtDescuentoPesos.ReadOnly = True
        Me.txtDescuentoPesos.Size = New System.Drawing.Size(92, 20)
        Me.txtDescuentoPesos.TabIndex = 13
        Me.txtDescuentoPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 176)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 13)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Total:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 150)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(27, 13)
        Me.Label19.TabIndex = 39
        Me.Label19.Text = "IVA:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 73)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 13)
        Me.Label20.TabIndex = 38
        Me.Label20.Text = "Sub-Total:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 48)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(62, 13)
        Me.Label21.TabIndex = 37
        Me.Label21.Text = "Descuento:"
        '
        'txtImportePesos
        '
        Me.txtImportePesos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImportePesos.Location = New System.Drawing.Point(87, 19)
        Me.txtImportePesos.Name = "txtImportePesos"
        Me.txtImportePesos.ReadOnly = True
        Me.txtImportePesos.Size = New System.Drawing.Size(92, 20)
        Me.txtImportePesos.TabIndex = 12
        Me.txtImportePesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 22)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 13)
        Me.Label22.TabIndex = 35
        Me.Label22.Text = "Importe:"
        '
        'lblEstatus
        '
        Me.lblEstatus.AutoSize = True
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblEstatus.Location = New System.Drawing.Point(768, 40)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(104, 24)
        Me.lblEstatus.TabIndex = 94
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.Visible = False
        '
        'cmbProveedor
        '
        Me.cmbProveedor.DataSource = Me.ProveedorC
        Me.cmbProveedor.DisplayMember = "RazonSocial"
        Me.cmbProveedor.Enabled = False
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(149, 126)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(281, 21)
        Me.cmbProveedor.TabIndex = 4
        Me.cmbProveedor.ValueMember = "Codigo"
        '
        'ProveedorC
        '
        Me.ProveedorC.AllowEdit = True
        Me.ProveedorC.AllowNew = True
        Me.ProveedorC.AllowRemove = True
        Me.ProveedorC.MaximoElementosSeleccionados = 1
        Me.ProveedorC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.ProveedorC.Mostrar = ClasesNegocio.MostrarEnum.CLIENTES
        Me.ProveedorC.MostrarAlertas = False
        Me.ProveedorC.Name = ""
        Me.ProveedorC.RaiseListChangedEvents = True
        Me.ProveedorC.Transaction = Nothing
        '
        'cmbAlmacen
        '
        Me.cmbAlmacen.DataSource = Me.AlmacenC
        Me.cmbAlmacen.DisplayMember = "Descripcion"
        Me.cmbAlmacen.FormattingEnabled = True
        Me.cmbAlmacen.Location = New System.Drawing.Point(149, 99)
        Me.cmbAlmacen.Name = "cmbAlmacen"
        Me.cmbAlmacen.Size = New System.Drawing.Size(281, 21)
        Me.cmbAlmacen.TabIndex = 5
        Me.cmbAlmacen.ValueMember = "Codigo"
        '
        'AlmacenC
        '
        Me.AlmacenC.AllowEdit = True
        Me.AlmacenC.AllowNew = True
        Me.AlmacenC.AllowRemove = True
        Me.AlmacenC.Name = ""
        Me.AlmacenC.RaiseListChangedEvents = True
        Me.AlmacenC.Tipo = ClasesNegocio.AlmacenEnum.ALMACEN
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(62, 102)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 13)
        Me.Label12.TabIndex = 90
        Me.Label12.Text = "Almacen:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtFletes)
        Me.GroupBox2.Controls.Add(Me.txtIVAFletes)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtTotal)
        Me.GroupBox2.Controls.Add(Me.txtIVA)
        Me.GroupBox2.Controls.Add(Me.txtSubTotal)
        Me.GroupBox2.Controls.Add(Me.txtDescuento)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtImporteTotal)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(625, 202)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(185, 199)
        Me.GroupBox2.TabIndex = 89
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Importes"
        '
        'txtFletes
        '
        Me.txtFletes.ComboBoxEnlazado = Nothing
        Me.txtFletes.Decimales = 0
        Me.txtFletes.Location = New System.Drawing.Point(87, 97)
        Me.txtFletes.MaxLength = 3000
        Me.txtFletes.MensajeCombo = "Seleccionar un item..."
        Me.txtFletes.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtFletes.Name = "txtFletes"
        Me.txtFletes.SiguienteControl = Me.txtIVAFletes
        Me.txtFletes.Size = New System.Drawing.Size(92, 20)
        Me.txtFletes.TabIndex = 99
        Me.txtFletes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtFletes.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        Me.txtFletes.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtFletes.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtIVAFletes
        '
        Me.txtIVAFletes.ComboBoxEnlazado = Nothing
        Me.txtIVAFletes.Decimales = 0
        Me.txtIVAFletes.Location = New System.Drawing.Point(87, 122)
        Me.txtIVAFletes.MaxLength = 3000
        Me.txtIVAFletes.MensajeCombo = "Seleccionar un item..."
        Me.txtIVAFletes.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtIVAFletes.Name = "txtIVAFletes"
        Me.txtIVAFletes.ReadOnly = True
        Me.txtIVAFletes.SiguienteControl = Nothing
        Me.txtIVAFletes.Size = New System.Drawing.Size(92, 20)
        Me.txtIVAFletes.TabIndex = 100
        Me.txtIVAFletes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIVAFletes.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        Me.txtIVAFletes.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtIVAFletes.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "IVA Fletes:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 100)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(38, 13)
        Me.Label17.TabIndex = 45
        Me.Label17.Text = "Fletes:"
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.Location = New System.Drawing.Point(87, 173)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(92, 20)
        Me.txtTotal.TabIndex = 25
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIVA
        '
        Me.txtIVA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIVA.Location = New System.Drawing.Point(87, 147)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.ReadOnly = True
        Me.txtIVA.Size = New System.Drawing.Size(92, 20)
        Me.txtIVA.TabIndex = 24
        Me.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSubTotal.Location = New System.Drawing.Point(87, 70)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(92, 20)
        Me.txtSubTotal.TabIndex = 21
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDescuento
        '
        Me.txtDescuento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescuento.Location = New System.Drawing.Point(87, 45)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.ReadOnly = True
        Me.txtDescuento.Size = New System.Drawing.Size(92, 20)
        Me.txtDescuento.TabIndex = 20
        Me.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 176)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(34, 13)
        Me.Label18.TabIndex = 40
        Me.Label18.Text = "Total:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 150)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 13)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "IVA:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 73)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 13)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "Sub-Total:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 13)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Descuento:"
        '
        'txtImporteTotal
        '
        Me.txtImporteTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImporteTotal.Location = New System.Drawing.Point(87, 19)
        Me.txtImporteTotal.Name = "txtImporteTotal"
        Me.txtImporteTotal.ReadOnly = True
        Me.txtImporteTotal.Size = New System.Drawing.Size(92, 20)
        Me.txtImporteTotal.TabIndex = 19
        Me.txtImporteTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Importe:"
        '
        'GroupBox1
        '
        Me.GroupBox1.CausesValidation = False
        Me.GroupBox1.Controls.Add(Me.txtSumaRecibir)
        Me.GroupBox1.Controls.Add(Me.dgvDetalleOrdenCompra)
        Me.GroupBox1.Controls.Add(Me.GrpImportesPesos)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(65, 180)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(816, 407)
        Me.GroupBox1.TabIndex = 86
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de Orden"
        '
        'txtSumaRecibir
        '
        Me.txtSumaRecibir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSumaRecibir.Location = New System.Drawing.Point(232, 202)
        Me.txtSumaRecibir.Name = "txtSumaRecibir"
        Me.txtSumaRecibir.ReadOnly = True
        Me.txtSumaRecibir.Size = New System.Drawing.Size(133, 23)
        Me.txtSumaRecibir.TabIndex = 25
        Me.txtSumaRecibir.Text = "0"
        Me.txtSumaRecibir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvDetalleOrdenCompra
        '
        Me.dgvDetalleOrdenCompra.AllowUserToDeleteRows = False
        Me.dgvDetalleOrdenCompra.AllowUserToOrderColumns = True
        Me.dgvDetalleOrdenCompra.AllowUserToResizeRows = False
        Me.dgvDetalleOrdenCompra.AutoGenerateColumns = False
        Me.dgvDetalleOrdenCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleOrdenCompra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmIdProducto, Me.clmCantSol, Me.clmCantOrd, Me.clmUnidad, Me.clmPrecio, Me.clmDescuento, Me.clmEstatus, Me.clmCantPend, Me.clmIva, Me.clmImporte})
        Me.dgvDetalleOrdenCompra.DataSource = Me.OrdenCompraDetalleC
        Me.dgvDetalleOrdenCompra.Location = New System.Drawing.Point(6, 22)
        Me.dgvDetalleOrdenCompra.Name = "dgvDetalleOrdenCompra"
        Me.dgvDetalleOrdenCompra.Size = New System.Drawing.Size(804, 168)
        Me.dgvDetalleOrdenCompra.TabIndex = 8
        '
        'clmIdProducto
        '
        Me.clmIdProducto.DataPropertyName = "IdProducto"
        Me.clmIdProducto.HeaderText = "Producto"
        Me.clmIdProducto.Name = "clmIdProducto"
        Me.clmIdProducto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clmIdProducto.Width = 190
        '
        'clmCantSol
        '
        Me.clmCantSol.DataPropertyName = "CantidadSolicitada"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.clmCantSol.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmCantSol.HeaderText = "Cant. Solicitada"
        Me.clmCantSol.Name = "clmCantSol"
        Me.clmCantSol.Visible = False
        '
        'clmCantOrd
        '
        Me.clmCantOrd.DataPropertyName = "CantidadOrdenada"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        Me.clmCantOrd.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmCantOrd.HeaderText = "Cant. Ordenada"
        Me.clmCantOrd.Name = "clmCantOrd"
        Me.clmCantOrd.Width = 130
        '
        'clmUnidad
        '
        Me.clmUnidad.DataPropertyName = "UnidadMedida"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.clmUnidad.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmUnidad.HeaderText = "Unidad"
        Me.clmUnidad.Name = "clmUnidad"
        Me.clmUnidad.ReadOnly = True
        Me.clmUnidad.Width = 70
        '
        'clmPrecio
        '
        Me.clmPrecio.DataPropertyName = "Precio"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.clmPrecio.DefaultCellStyle = DataGridViewCellStyle4
        Me.clmPrecio.HeaderText = "Precio"
        Me.clmPrecio.Name = "clmPrecio"
        Me.clmPrecio.Width = 70
        '
        'clmDescuento
        '
        Me.clmDescuento.DataPropertyName = "Descuento"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.clmDescuento.DefaultCellStyle = DataGridViewCellStyle5
        Me.clmDescuento.HeaderText = "% Desc."
        Me.clmDescuento.Name = "clmDescuento"
        Me.clmDescuento.Width = 90
        '
        'clmEstatus
        '
        Me.clmEstatus.DataPropertyName = "Estatus"
        Me.clmEstatus.HeaderText = "Estatus"
        Me.clmEstatus.Name = "clmEstatus"
        Me.clmEstatus.Visible = False
        '
        'clmCantPend
        '
        Me.clmCantPend.DataPropertyName = "CantPendiente"
        Me.clmCantPend.HeaderText = "CantPendiente"
        Me.clmCantPend.Name = "clmCantPend"
        Me.clmCantPend.Visible = False
        '
        'clmIva
        '
        Me.clmIva.DataPropertyName = "Iva"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "C2"
        Me.clmIva.DefaultCellStyle = DataGridViewCellStyle6
        Me.clmIva.HeaderText = "Iva"
        Me.clmIva.Name = "clmIva"
        Me.clmIva.ReadOnly = True
        '
        'clmImporte
        '
        Me.clmImporte.DataPropertyName = "Importe"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "C2"
        Me.clmImporte.DefaultCellStyle = DataGridViewCellStyle7
        Me.clmImporte.HeaderText = "Importe"
        Me.clmImporte.Name = "clmImporte"
        '
        'OrdenCompraDetalleC
        '
        Me.OrdenCompraDetalleC.AllowEdit = True
        Me.OrdenCompraDetalleC.AllowNew = True
        Me.OrdenCompraDetalleC.AllowRemove = True
        Me.OrdenCompraDetalleC.MaximoElementosSeleccionados = 1
        Me.OrdenCompraDetalleC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.OrdenCompraDetalleC.MostrarAlertas = False
        Me.OrdenCompraDetalleC.Name = ""
        Me.OrdenCompraDetalleC.RaiseListChangedEvents = True
        Me.OrdenCompraDetalleC.Transaction = Nothing
        '
        'DtpFecha
        '
        Me.DtpFecha.Enabled = False
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(716, 72)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(85, 20)
        Me.DtpFecha.TabIndex = 2
        '
        'txtNoFactura
        '
        Me.txtNoFactura.Location = New System.Drawing.Point(540, 72)
        Me.txtNoFactura.Name = "txtNoFactura"
        Me.txtNoFactura.Size = New System.Drawing.Size(100, 20)
        Me.txtNoFactura.TabIndex = 6
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.Location = New System.Drawing.Point(355, 154)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.ReadOnly = True
        Me.txtTipoCambio.Size = New System.Drawing.Size(75, 20)
        Me.txtTipoCambio.TabIndex = 11
        '
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(540, 45)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.ReadOnly = True
        Me.txtFolio.Size = New System.Drawing.Size(100, 20)
        Me.txtFolio.TabIndex = 10
        '
        'cmbMoneda
        '
        Me.cmbMoneda.DataSource = Me.MonedaTC
        Me.cmbMoneda.DisplayMember = "Descripcion"
        Me.cmbMoneda.Enabled = False
        Me.cmbMoneda.FormattingEnabled = True
        Me.cmbMoneda.Location = New System.Drawing.Point(149, 153)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.Size = New System.Drawing.Size(120, 21)
        Me.cmbMoneda.TabIndex = 3
        Me.cmbMoneda.ValueMember = "Codigo"
        '
        'MonedaTC
        '
        Me.MonedaTC.AllowEdit = True
        Me.MonedaTC.AllowNew = True
        Me.MonedaTC.AllowRemove = True
        Me.MonedaTC.MaximoElementosSeleccionados = 1
        Me.MonedaTC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.MonedaTC.MostrarAlertas = False
        Me.MonedaTC.Name = ""
        Me.MonedaTC.RaiseListChangedEvents = True
        Me.MonedaTC.Transaction = Nothing
        '
        'cmbSucursal
        '
        Me.cmbSucursal.DataSource = Me.SucursalC
        Me.cmbSucursal.DisplayMember = "Descripcion"
        Me.cmbSucursal.Enabled = False
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(149, 72)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(281, 21)
        Me.cmbSucursal.TabIndex = 1
        Me.cmbSucursal.ValueMember = "Codigo"
        '
        'SucursalC
        '
        Me.SucursalC.AllowEdit = True
        Me.SucursalC.AllowNew = True
        Me.SucursalC.AllowRemove = True
        Me.SucursalC.MaximoElementosSeleccionados = 1
        Me.SucursalC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.SucursalC.MostrarAlertas = False
        Me.SucursalC.Name = ""
        Me.SucursalC.RaiseListChangedEvents = True
        Me.SucursalC.Transaction = Nothing
        '
        'cmbPlaza
        '
        Me.cmbPlaza.DataSource = Me.PlazaC
        Me.cmbPlaza.DisplayMember = "Descripcion"
        Me.cmbPlaza.Enabled = False
        Me.cmbPlaza.FormattingEnabled = True
        Me.cmbPlaza.Location = New System.Drawing.Point(149, 45)
        Me.cmbPlaza.Name = "cmbPlaza"
        Me.cmbPlaza.Size = New System.Drawing.Size(281, 21)
        Me.cmbPlaza.TabIndex = 0
        Me.cmbPlaza.ValueMember = "Codigo"
        '
        'PlazaC
        '
        Me.PlazaC.AllowEdit = True
        Me.PlazaC.AllowNew = True
        Me.PlazaC.AllowRemove = True
        Me.PlazaC.MaximoElementosSeleccionados = 1
        Me.PlazaC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.PlazaC.MostrarAlertas = False
        Me.PlazaC.Name = ""
        Me.PlazaC.RaiseListChangedEvents = True
        Me.PlazaC.Transaction = Nothing
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(280, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "Tipo Cambio:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(62, 156)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "Moneda:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(453, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "No. Factura:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(649, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Fecha Alta:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Proveedor:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(453, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Folio :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Sucursal:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Plaza:"
        '
        'Mtb
        '
        Me.Mtb.ButtonSize = New System.Drawing.Size(50, 50)
        Me.Mtb.Dock = System.Windows.Forms.DockStyle.Left
        Me.Mtb.DropDownArrows = True
        Me.Mtb.HabilitarBorrar = True
        Me.Mtb.HabilitarBuscar = True
        Me.Mtb.HabilitarCancelar = True
        Me.Mtb.HabilitarEditar = True
        Me.Mtb.HabilitarGuardar = True
        Me.Mtb.HabilitarImprimir = True
        Me.Mtb.HabilitarLimpiar = True
        Me.Mtb.HabilitarNuevo = True
        Me.Mtb.HabilitarSalir = True
        Me.Mtb.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32
        Me.Mtb.Location = New System.Drawing.Point(0, 0)
        Me.Mtb.MostrarBorrar = True
        Me.Mtb.MostrarBuscar = True
        Me.Mtb.MostrarCancelar = True
        Me.Mtb.MostrarEditar = False
        Me.Mtb.MostrarGuardar = True
        Me.Mtb.MostrarImprimir = True
        Me.Mtb.MostrarLimpiar = True
        Me.Mtb.MostrarNuevo = True
        Me.Mtb.MostrarSalir = True
        Me.Mtb.Name = "Mtb"
        Me.Mtb.ShowToolTips = True
        Me.Mtb.Size = New System.Drawing.Size(50, 594)
        Me.Mtb.TabIndex = 9
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Location = New System.Drawing.Point(540, 102)
        Me.txtObservaciones.MaxLength = 250
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(341, 72)
        Me.txtObservaciones.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(453, 102)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 13)
        Me.Label10.TabIndex = 96
        Me.Label10.Text = "Observaciones:"
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
        Me.lblTitulo.Size = New System.Drawing.Size(839, 30)
        Me.lblTitulo.TabIndex = 98
        Me.lblTitulo.Text = "RECEPCION DE ORDENES DIRECTAS"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmRecepcionesOrdenesDirectas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 594)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblEstatus)
        Me.Controls.Add(Me.cmbAlmacen)
        Me.Controls.Add(Me.cmbProveedor)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DtpFecha)
        Me.Controls.Add(Me.txtNoFactura)
        Me.Controls.Add(Me.txtTipoCambio)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.cmbMoneda)
        Me.Controls.Add(Me.cmbSucursal)
        Me.Controls.Add(Me.cmbPlaza)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Mtb)
        Me.Name = "frmRecepcionesOrdenesDirectas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RECEPCION DE ORDENES DIRECTAS"
        Me.GrpImportesPesos.ResumeLayout(False)
        Me.GrpImportesPesos.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvDetalleOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpImportesPesos As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotalPesos As System.Windows.Forms.TextBox
    Friend WithEvents txtIvaPesos As System.Windows.Forms.TextBox
    Friend WithEvents txtSubTotalPesos As System.Windows.Forms.TextBox
    Friend WithEvents txtDescuentoPesos As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtImportePesos As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents cmbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtIVA As System.Windows.Forms.TextBox
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtImporteTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSumaRecibir As System.Windows.Forms.TextBox
    Friend WithEvents dgvDetalleOrdenCompra As System.Windows.Forms.DataGridView
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNoFactura As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoCambio As System.Windows.Forms.TextBox
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents cmbMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPlaza As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Mtb As MEAToolBar.MEAToolBar
    Friend WithEvents ProveedorC As ClasesNegocio.ProveedorCollectionClass
    Friend WithEvents SucursalC As ClasesNegocio.SucursalCollectionClass
    Friend WithEvents MonedaTC As ClasesNegocio.TipoMonedaCollectionClass
    Friend WithEvents AlmacenC As ClasesNegocio.AlmacenCollectionClass
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtIVAFletesPesos As System.Windows.Forms.TextBox
    Friend WithEvents txtFletesPesos As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents PlazaC As ClasesNegocio.PlazaCollectionClass
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents OrdenCompraDetalleC As ClasesNegocio.OrdenCompraDetalleCollectionClass
    Friend WithEvents txtFletes As Integralab.Controles.TextBoxMejorado
    Friend WithEvents txtIVAFletes As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents clmIdProducto As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents clmCantSol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCantOrd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPrecio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDescuento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCantPend As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmImporte As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
