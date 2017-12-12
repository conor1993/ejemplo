<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarFactRecep
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.mtb = New MEAToolBar.MEAToolBar()
        Me.lblTema = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFolio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbProveedor = New System.Windows.Forms.ComboBox()
        Me.rbFactura = New System.Windows.Forms.RadioButton()
        Me.rbNotaRem = New System.Windows.Forms.RadioButton()
        Me.rbSinDocto = New System.Windows.Forms.RadioButton()
        Me.dgvFacturas = New System.Windows.Forms.DataGridView()
        Me.clmNoFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFechaFact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFactSubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFactIVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFactIEPS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFactTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFactEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCodProveedorFact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvRecepComp = New System.Windows.Forms.DataGridView()
        Me.Pagar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.clmIdRecepCom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFechaRecep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmIva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmieps = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDetalle = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.clmTipoRecep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmProveedorRecep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmIdRecepcionDeCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmNomProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        CType(Me.dgvFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRecepComp, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.mtb.Size = New System.Drawing.Size(50, 339)
        Me.mtb.TabIndex = 25
        '
        'lblTema
        '
        Me.lblTema.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTema.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTema.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTema.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTema.Location = New System.Drawing.Point(50, 0)
        Me.lblTema.Name = "lblTema"
        Me.lblTema.Size = New System.Drawing.Size(654, 29)
        Me.lblTema.TabIndex = 26
        Me.lblTema.Text = "Busqueda de Facturas/Recepciones"
        Me.lblTema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Folio:"
        '
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(145, 95)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(267, 20)
        Me.txtFolio.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Proveedor:"
        '
        'cmbProveedor
        '
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(145, 66)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(267, 21)
        Me.cmbProveedor.TabIndex = 31
        '
        'rbFactura
        '
        Me.rbFactura.AutoSize = True
        Me.rbFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFactura.Location = New System.Drawing.Point(148, 41)
        Me.rbFactura.Name = "rbFactura"
        Me.rbFactura.Size = New System.Drawing.Size(74, 21)
        Me.rbFactura.TabIndex = 32
        Me.rbFactura.TabStop = True
        Me.rbFactura.Text = "Factura"
        Me.rbFactura.UseVisualStyleBackColor = True
        '
        'rbNotaRem
        '
        Me.rbNotaRem.AutoSize = True
        Me.rbNotaRem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNotaRem.Location = New System.Drawing.Point(250, 41)
        Me.rbNotaRem.Name = "rbNotaRem"
        Me.rbNotaRem.Size = New System.Drawing.Size(118, 21)
        Me.rbNotaRem.TabIndex = 33
        Me.rbNotaRem.TabStop = True
        Me.rbNotaRem.Text = "Nota Remisión"
        Me.rbNotaRem.UseVisualStyleBackColor = True
        '
        'rbSinDocto
        '
        Me.rbSinDocto.AutoSize = True
        Me.rbSinDocto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSinDocto.Location = New System.Drawing.Point(387, 41)
        Me.rbSinDocto.Name = "rbSinDocto"
        Me.rbSinDocto.Size = New System.Drawing.Size(122, 21)
        Me.rbSinDocto.TabIndex = 34
        Me.rbSinDocto.TabStop = True
        Me.rbSinDocto.Text = "Sin Documento"
        Me.rbSinDocto.UseVisualStyleBackColor = True
        '
        'dgvFacturas
        '
        Me.dgvFacturas.AllowUserToAddRows = False
        Me.dgvFacturas.AllowUserToDeleteRows = False
        Me.dgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFacturas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmNoFactura, Me.clmFechaFact, Me.clmFactSubTotal, Me.clmFactIVA, Me.clmFactIEPS, Me.clmFactTotal, Me.clmFactEstatus, Me.clmCodProveedorFact})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFacturas.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvFacturas.Location = New System.Drawing.Point(49, 131)
        Me.dgvFacturas.MultiSelect = False
        Me.dgvFacturas.Name = "dgvFacturas"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFacturas.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvFacturas.RowHeadersVisible = False
        Me.dgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFacturas.Size = New System.Drawing.Size(648, 171)
        Me.dgvFacturas.TabIndex = 36
        '
        'clmNoFactura
        '
        Me.clmNoFactura.DataPropertyName = "NoFactura"
        Me.clmNoFactura.FillWeight = 30.0!
        Me.clmNoFactura.HeaderText = "No. Factura"
        Me.clmNoFactura.Name = "clmNoFactura"
        Me.clmNoFactura.ReadOnly = True
        '
        'clmFechaFact
        '
        Me.clmFechaFact.DataPropertyName = "FechaFactura"
        DataGridViewCellStyle2.Format = "dd/MM/yyyy"
        Me.clmFechaFact.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmFechaFact.FillWeight = 18.0!
        Me.clmFechaFact.HeaderText = "Fecha Fact."
        Me.clmFechaFact.Name = "clmFechaFact"
        Me.clmFechaFact.ReadOnly = True
        '
        'clmFactSubTotal
        '
        Me.clmFactSubTotal.DataPropertyName = "Subtotal"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        Me.clmFactSubTotal.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmFactSubTotal.FillWeight = 15.0!
        Me.clmFactSubTotal.HeaderText = "SubTotal"
        Me.clmFactSubTotal.Name = "clmFactSubTotal"
        Me.clmFactSubTotal.ReadOnly = True
        '
        'clmFactIVA
        '
        Me.clmFactIVA.DataPropertyName = "IVA"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.clmFactIVA.DefaultCellStyle = DataGridViewCellStyle4
        Me.clmFactIVA.FillWeight = 15.0!
        Me.clmFactIVA.HeaderText = "IVA"
        Me.clmFactIVA.Name = "clmFactIVA"
        Me.clmFactIVA.ReadOnly = True
        '
        'clmFactIEPS
        '
        Me.clmFactIEPS.DataPropertyName = "IEPS"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        Me.clmFactIEPS.DefaultCellStyle = DataGridViewCellStyle5
        Me.clmFactIEPS.FillWeight = 15.0!
        Me.clmFactIEPS.HeaderText = "IEPS"
        Me.clmFactIEPS.Name = "clmFactIEPS"
        Me.clmFactIEPS.ReadOnly = True
        '
        'clmFactTotal
        '
        Me.clmFactTotal.DataPropertyName = "Total"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.clmFactTotal.DefaultCellStyle = DataGridViewCellStyle6
        Me.clmFactTotal.FillWeight = 20.0!
        Me.clmFactTotal.HeaderText = "Total"
        Me.clmFactTotal.Name = "clmFactTotal"
        Me.clmFactTotal.ReadOnly = True
        '
        'clmFactEstatus
        '
        Me.clmFactEstatus.DataPropertyName = "NomEstatus"
        Me.clmFactEstatus.FillWeight = 15.0!
        Me.clmFactEstatus.HeaderText = "Estatus"
        Me.clmFactEstatus.Name = "clmFactEstatus"
        Me.clmFactEstatus.ReadOnly = True
        '
        'clmCodProveedorFact
        '
        Me.clmCodProveedorFact.DataPropertyName = "CodigoProveedor"
        Me.clmCodProveedorFact.HeaderText = "Proveedor"
        Me.clmCodProveedorFact.Name = "clmCodProveedorFact"
        Me.clmCodProveedorFact.Visible = False
        '
        'dgvRecepComp
        '
        Me.dgvRecepComp.AllowUserToAddRows = False
        Me.dgvRecepComp.AllowUserToDeleteRows = False
        Me.dgvRecepComp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRecepComp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRecepComp.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvRecepComp.ColumnHeadersHeight = 21
        Me.dgvRecepComp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvRecepComp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Pagar, Me.clmIdRecepCom, Me.clmFechaRecep, Me.clmSubtotal, Me.clmIva, Me.clmieps, Me.clmTotal, Me.clmDetalle, Me.clmTipoRecep, Me.clmProveedorRecep, Me.clmIdRecepcionDeCompra, Me.clmNomProveedor})
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRecepComp.DefaultCellStyle = DataGridViewCellStyle18
        Me.dgvRecepComp.Location = New System.Drawing.Point(49, 131)
        Me.dgvRecepComp.MultiSelect = False
        Me.dgvRecepComp.Name = "dgvRecepComp"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRecepComp.RowHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.dgvRecepComp.RowHeadersVisible = False
        Me.dgvRecepComp.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvRecepComp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRecepComp.Size = New System.Drawing.Size(648, 171)
        Me.dgvRecepComp.TabIndex = 37
        '
        'Pagar
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.NullValue = False
        Me.Pagar.DefaultCellStyle = DataGridViewCellStyle10
        Me.Pagar.FillWeight = 10.0!
        Me.Pagar.HeaderText = ""
        Me.Pagar.Name = "Pagar"
        Me.Pagar.Visible = False
        '
        'clmIdRecepCom
        '
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.clmIdRecepCom.DefaultCellStyle = DataGridViewCellStyle11
        Me.clmIdRecepCom.FillWeight = 40.0!
        Me.clmIdRecepCom.HeaderText = "Id"
        Me.clmIdRecepCom.Name = "clmIdRecepCom"
        Me.clmIdRecepCom.ReadOnly = True
        '
        'clmFechaRecep
        '
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle12.Format = "dd/MM/yyyy"
        Me.clmFechaRecep.DefaultCellStyle = DataGridViewCellStyle12
        Me.clmFechaRecep.FillWeight = 30.0!
        Me.clmFechaRecep.HeaderText = "Fecha"
        Me.clmFechaRecep.Name = "clmFechaRecep"
        Me.clmFechaRecep.ReadOnly = True
        '
        'clmSubtotal
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle13.Format = "N2"
        Me.clmSubtotal.DefaultCellStyle = DataGridViewCellStyle13
        Me.clmSubtotal.FillWeight = 40.0!
        Me.clmSubtotal.HeaderText = "SubTotal"
        Me.clmSubtotal.Name = "clmSubtotal"
        Me.clmSubtotal.ReadOnly = True
        '
        'clmIva
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle14.Format = "N2"
        Me.clmIva.DefaultCellStyle = DataGridViewCellStyle14
        Me.clmIva.FillWeight = 40.0!
        Me.clmIva.HeaderText = "IVA"
        Me.clmIva.Name = "clmIva"
        Me.clmIva.ReadOnly = True
        '
        'clmieps
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle15.Format = "N2"
        Me.clmieps.DefaultCellStyle = DataGridViewCellStyle15
        Me.clmieps.FillWeight = 40.0!
        Me.clmieps.HeaderText = "IEPS"
        Me.clmieps.Name = "clmieps"
        Me.clmieps.ReadOnly = True
        '
        'clmTotal
        '
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle16.Format = "N2"
        Me.clmTotal.DefaultCellStyle = DataGridViewCellStyle16
        Me.clmTotal.FillWeight = 40.0!
        Me.clmTotal.HeaderText = "Total"
        Me.clmTotal.Name = "clmTotal"
        Me.clmTotal.ReadOnly = True
        '
        'clmDetalle
        '
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.clmDetalle.DefaultCellStyle = DataGridViewCellStyle17
        Me.clmDetalle.FillWeight = 20.0!
        Me.clmDetalle.HeaderText = "Detalle"
        Me.clmDetalle.Name = "clmDetalle"
        Me.clmDetalle.Text = "..."
        Me.clmDetalle.ToolTipText = "Ver detalle de la recepcion"
        Me.clmDetalle.Visible = False
        '
        'clmTipoRecep
        '
        Me.clmTipoRecep.HeaderText = "Tipo"
        Me.clmTipoRecep.Name = "clmTipoRecep"
        Me.clmTipoRecep.ReadOnly = True
        Me.clmTipoRecep.Visible = False
        '
        'clmProveedorRecep
        '
        Me.clmProveedorRecep.HeaderText = "Proveedor"
        Me.clmProveedorRecep.Name = "clmProveedorRecep"
        Me.clmProveedorRecep.Visible = False
        '
        'clmIdRecepcionDeCompra
        '
        Me.clmIdRecepcionDeCompra.HeaderText = "IDRECEP"
        Me.clmIdRecepcionDeCompra.Name = "clmIdRecepcionDeCompra"
        Me.clmIdRecepcionDeCompra.Visible = False
        '
        'clmNomProveedor
        '
        Me.clmNomProveedor.DataPropertyName = "NomProveedor"
        Me.clmNomProveedor.FillWeight = 55.0!
        Me.clmNomProveedor.HeaderText = "Proveedor"
        Me.clmNomProveedor.Name = "clmNomProveedor"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(532, 308)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 38
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(622, 308)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 39
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmBuscarFactRecep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 339)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.dgvRecepComp)
        Me.Controls.Add(Me.dgvFacturas)
        Me.Controls.Add(Me.rbSinDocto)
        Me.Controls.Add(Me.rbNotaRem)
        Me.Controls.Add(Me.rbFactura)
        Me.Controls.Add(Me.cmbProveedor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTema)
        Me.Controls.Add(Me.mtb)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(720, 377)
        Me.MinimumSize = New System.Drawing.Size(720, 377)
        Me.Name = "frmBuscarFactRecep"
        Me.Text = "Busqueda de Facturas/Recepciones"
        CType(Me.dgvFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRecepComp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Private WithEvents lblTema As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents rbFactura As System.Windows.Forms.RadioButton
    Friend WithEvents rbNotaRem As System.Windows.Forms.RadioButton
    Friend WithEvents rbSinDocto As System.Windows.Forms.RadioButton
    Friend WithEvents dgvFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents dgvRecepComp As System.Windows.Forms.DataGridView
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents clmNoFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaFact As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFactSubTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFactIVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFactIEPS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFactTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFactEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCodProveedorFact As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pagar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents clmIdRecepCom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaRecep As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSubtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmieps As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDetalle As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents clmTipoRecep As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmProveedorRecep As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdRecepcionDeCompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmNomProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
