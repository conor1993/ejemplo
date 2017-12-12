<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmABCProducosComprasGen
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTema = New System.Windows.Forms.Label()
        Me.Pan = New System.Windows.Forms.Panel()
        Me.lblestatus = New System.Windows.Forms.Label()
        Me.gbdet = New System.Windows.Forms.GroupBox()
        Me.chkAplicaIva = New System.Windows.Forms.CheckBox()
        Me.checkArtSinExis = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkCaduca = New System.Windows.Forms.CheckBox()
        Me.txtCaducidad = New System.Windows.Forms.TextBox()
        Me.chkSeManejaProLotes = New System.Windows.Forms.CheckBox()
        Me.chkSeFactura = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtieps = New System.Windows.Forms.TextBox()
        Me.dtpFechaUltimaCompra = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtImportteUltimaCompra = New System.Windows.Forms.TextBox()
        Me.txtUltimoCosto = New System.Windows.Forms.TextBox()
        Me.txtCantidadUltimaCompra = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.chkEsKit = New System.Windows.Forms.CheckBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbMarcas = New System.Windows.Forms.ComboBox()
        Me.txtCodigoBarra = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDescCorta = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbUnidadesMedida = New System.Windows.Forms.ComboBox()
        Me.cmbFamilia = New System.Windows.Forms.ComboBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkObtenerMermas = New System.Windows.Forms.CheckBox()
        Me.txtPiezas = New System.Windows.Forms.TextBox()
        Me.GpoIngrediente = New System.Windows.Forms.GroupBox()
        Me.chkFormula = New System.Windows.Forms.CheckBox()
        Me.chkIngrediente = New System.Windows.Forms.CheckBox()
        Me.rbMaterialPaEnvases = New System.Windows.Forms.RadioButton()
        Me.rbIngrediente = New System.Windows.Forms.RadioButton()
        Me.chkFacturaSinExistencia = New System.Windows.Forms.CheckBox()
        Me.chkSeRecibeParcialmente = New System.Windows.Forms.CheckBox()
        Me.chkSeReciveSinFactura = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.mtb = New MEAToolBar.MEAToolBar()
        Me.tbcPaquetes = New System.Windows.Forms.TabControl()
        Me.tpKit = New System.Windows.Forms.TabPage()
        Me.dgvKit = New Integralab.Controles.DataGridViewMejorado()
        Me.clmCodBarra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmProducto = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.clmCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPreVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPreKit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTotalPre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTotalPreKit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tpArmadoPaquetes = New System.Windows.Forms.TabPage()
        Me.dgvIngredientes = New System.Windows.Forms.DataGridView()
        Me.GpoPaquete = New System.Windows.Forms.GroupBox()
        Me.rbEsMezcla = New System.Windows.Forms.RadioButton()
        Me.rbProductoGeneral = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbTipoProd = New System.Windows.Forms.ComboBox()
        Me.cmbPresentacion = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbSubFamilia = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tpCostoIndirecto = New System.Windows.Forms.TabPage()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dgvCIR = New System.Windows.Forms.DataGridView()
        Me.tpHistorial = New System.Windows.Forms.TabPage()
        Me.dgvHistorialCompras = New System.Windows.Forms.DataGridView()
        Me.clmPrjNutriente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmNutriente = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarFilaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTotalKit = New System.Windows.Forms.Label()
        Me.lblTotalPrecio = New System.Windows.Forms.Label()
        Me.clmProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCostoUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pan.SuspendLayout()
        Me.gbdet.SuspendLayout()
        Me.GpoIngrediente.SuspendLayout()
        Me.tbcPaquetes.SuspendLayout()
        Me.tpKit.SuspendLayout()
        CType(Me.dgvKit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpArmadoPaquetes.SuspendLayout()
        CType(Me.dgvIngredientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GpoPaquete.SuspendLayout()
        Me.tpCostoIndirecto.SuspendLayout()
        CType(Me.dgvCIR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpHistorial.SuspendLayout()
        CType(Me.dgvHistorialCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTema
        '
        Me.lblTema.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTema.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTema.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTema.ForeColor = System.Drawing.Color.Transparent
        Me.lblTema.Location = New System.Drawing.Point(50, 0)
        Me.lblTema.Name = "lblTema"
        Me.lblTema.Size = New System.Drawing.Size(890, 29)
        Me.lblTema.TabIndex = 34
        Me.lblTema.Text = "CATÁLOGO DE PRODUCTOS"
        Me.lblTema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Pan
        '
        Me.Pan.Controls.Add(Me.lblestatus)
        Me.Pan.Controls.Add(Me.gbdet)
        Me.Pan.Controls.Add(Me.lblPrecio)
        Me.Pan.Controls.Add(Me.txtprecio)
        Me.Pan.Controls.Add(Me.chkEsKit)
        Me.Pan.Controls.Add(Me.Label19)
        Me.Pan.Controls.Add(Me.Label7)
        Me.Pan.Controls.Add(Me.cmbMarcas)
        Me.Pan.Controls.Add(Me.txtCodigoBarra)
        Me.Pan.Controls.Add(Me.Label13)
        Me.Pan.Controls.Add(Me.txtDescCorta)
        Me.Pan.Controls.Add(Me.dtpFecha)
        Me.Pan.Controls.Add(Me.Label10)
        Me.Pan.Controls.Add(Me.cmbUnidadesMedida)
        Me.Pan.Controls.Add(Me.cmbFamilia)
        Me.Pan.Controls.Add(Me.txtDescripcion)
        Me.Pan.Controls.Add(Me.txtCodigo)
        Me.Pan.Controls.Add(Me.Label5)
        Me.Pan.Controls.Add(Me.Label3)
        Me.Pan.Controls.Add(Me.Label2)
        Me.Pan.Controls.Add(Me.Label1)
        Me.Pan.Location = New System.Drawing.Point(56, 32)
        Me.Pan.Name = "Pan"
        Me.Pan.Size = New System.Drawing.Size(872, 231)
        Me.Pan.TabIndex = 35
        '
        'lblestatus
        '
        Me.lblestatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblestatus.BackColor = System.Drawing.Color.Navy
        Me.lblestatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblestatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblestatus.ForeColor = System.Drawing.Color.White
        Me.lblestatus.Location = New System.Drawing.Point(741, 3)
        Me.lblestatus.Name = "lblestatus"
        Me.lblestatus.Size = New System.Drawing.Size(121, 24)
        Me.lblestatus.TabIndex = 64
        Me.lblestatus.Text = "ESTATUS"
        Me.lblestatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbdet
        '
        Me.gbdet.Controls.Add(Me.chkAplicaIva)
        Me.gbdet.Controls.Add(Me.checkArtSinExis)
        Me.gbdet.Controls.Add(Me.Label8)
        Me.gbdet.Controls.Add(Me.chkCaduca)
        Me.gbdet.Controls.Add(Me.txtCaducidad)
        Me.gbdet.Controls.Add(Me.chkSeManejaProLotes)
        Me.gbdet.Controls.Add(Me.chkSeFactura)
        Me.gbdet.Controls.Add(Me.Label11)
        Me.gbdet.Controls.Add(Me.Label15)
        Me.gbdet.Controls.Add(Me.Label16)
        Me.gbdet.Controls.Add(Me.txtieps)
        Me.gbdet.Controls.Add(Me.dtpFechaUltimaCompra)
        Me.gbdet.Controls.Add(Me.Label4)
        Me.gbdet.Controls.Add(Me.txtImportteUltimaCompra)
        Me.gbdet.Controls.Add(Me.txtUltimoCosto)
        Me.gbdet.Controls.Add(Me.txtCantidadUltimaCompra)
        Me.gbdet.Controls.Add(Me.Label17)
        Me.gbdet.Location = New System.Drawing.Point(451, 12)
        Me.gbdet.Name = "gbdet"
        Me.gbdet.Size = New System.Drawing.Size(411, 216)
        Me.gbdet.TabIndex = 90
        Me.gbdet.TabStop = False
        '
        'chkAplicaIva
        '
        Me.chkAplicaIva.AutoSize = True
        Me.chkAplicaIva.Location = New System.Drawing.Point(21, 41)
        Me.chkAplicaIva.Name = "chkAplicaIva"
        Me.chkAplicaIva.Size = New System.Drawing.Size(91, 17)
        Me.chkAplicaIva.TabIndex = 8
        Me.chkAplicaIva.Text = "Se Aplica IVA"
        Me.chkAplicaIva.UseVisualStyleBackColor = True
        '
        'checkArtSinExis
        '
        Me.checkArtSinExis.AutoSize = True
        Me.checkArtSinExis.Location = New System.Drawing.Point(171, 87)
        Me.checkArtSinExis.Name = "checkArtSinExis"
        Me.checkArtSinExis.Size = New System.Drawing.Size(126, 17)
        Me.checkArtSinExis.TabIndex = 89
        Me.checkArtSinExis.Text = "Vender sin existencia"
        Me.checkArtSinExis.UseVisualStyleBackColor = True
        Me.checkArtSinExis.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Enabled = False
        Me.Label8.Location = New System.Drawing.Point(173, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Dias Max.:"
        '
        'chkCaduca
        '
        Me.chkCaduca.AutoSize = True
        Me.chkCaduca.Location = New System.Drawing.Point(171, 41)
        Me.chkCaduca.Name = "chkCaduca"
        Me.chkCaduca.Size = New System.Drawing.Size(107, 17)
        Me.chkCaduca.TabIndex = 11
        Me.chkCaduca.Text = "Tiene Caducidad"
        Me.chkCaduca.UseVisualStyleBackColor = True
        '
        'txtCaducidad
        '
        Me.txtCaducidad.Enabled = False
        Me.txtCaducidad.Location = New System.Drawing.Point(236, 65)
        Me.txtCaducidad.Name = "txtCaducidad"
        Me.txtCaducidad.Size = New System.Drawing.Size(38, 20)
        Me.txtCaducidad.TabIndex = 12
        Me.txtCaducidad.Text = "0"
        Me.txtCaducidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkSeManejaProLotes
        '
        Me.chkSeManejaProLotes.AutoSize = True
        Me.chkSeManejaProLotes.Location = New System.Drawing.Point(171, 20)
        Me.chkSeManejaProLotes.Name = "chkSeManejaProLotes"
        Me.chkSeManejaProLotes.Size = New System.Drawing.Size(124, 17)
        Me.chkSeManejaProLotes.TabIndex = 10
        Me.chkSeManejaProLotes.Text = "Se Maneja por Lotes"
        Me.chkSeManejaProLotes.UseVisualStyleBackColor = True
        '
        'chkSeFactura
        '
        Me.chkSeFactura.AutoSize = True
        Me.chkSeFactura.Location = New System.Drawing.Point(21, 18)
        Me.chkSeFactura.Name = "chkSeFactura"
        Me.chkSeFactura.Size = New System.Drawing.Size(78, 17)
        Me.chkSeFactura.TabIndex = 7
        Me.chkSeFactura.Text = "Se Factura"
        Me.chkSeFactura.UseVisualStyleBackColor = True
        Me.chkSeFactura.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(34, 113)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 13)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "Fecha Ultima Compra :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(34, 139)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(119, 13)
        Me.Label15.TabIndex = 73
        Me.Label15.Text = "Importe Ultima Compra :"
        Me.Label15.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(34, 165)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(126, 13)
        Me.Label16.TabIndex = 74
        Me.Label16.Text = "Cantidad Ultima Compra :"
        Me.Label16.Visible = False
        '
        'txtieps
        '
        Me.txtieps.Location = New System.Drawing.Point(74, 64)
        Me.txtieps.Name = "txtieps"
        Me.txtieps.Size = New System.Drawing.Size(38, 20)
        Me.txtieps.TabIndex = 9
        Me.txtieps.Text = "0"
        Me.txtieps.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpFechaUltimaCompra
        '
        Me.dtpFechaUltimaCompra.Enabled = False
        Me.dtpFechaUltimaCompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaUltimaCompra.Location = New System.Drawing.Point(171, 110)
        Me.dtpFechaUltimaCompra.Name = "dtpFechaUltimaCompra"
        Me.dtpFechaUltimaCompra.Size = New System.Drawing.Size(103, 20)
        Me.dtpFechaUltimaCompra.TabIndex = 75
        Me.dtpFechaUltimaCompra.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Location = New System.Drawing.Point(23, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "% IEPS:"
        '
        'txtImportteUltimaCompra
        '
        Me.txtImportteUltimaCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtImportteUltimaCompra.Location = New System.Drawing.Point(171, 136)
        Me.txtImportteUltimaCompra.Name = "txtImportteUltimaCompra"
        Me.txtImportteUltimaCompra.Size = New System.Drawing.Size(103, 20)
        Me.txtImportteUltimaCompra.TabIndex = 76
        Me.txtImportteUltimaCompra.TabStop = False
        Me.txtImportteUltimaCompra.Visible = False
        '
        'txtUltimoCosto
        '
        Me.txtUltimoCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUltimoCosto.Location = New System.Drawing.Point(171, 136)
        Me.txtUltimoCosto.Name = "txtUltimoCosto"
        Me.txtUltimoCosto.Size = New System.Drawing.Size(103, 20)
        Me.txtUltimoCosto.TabIndex = 79
        Me.txtUltimoCosto.TabStop = False
        '
        'txtCantidadUltimaCompra
        '
        Me.txtCantidadUltimaCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCantidadUltimaCompra.Location = New System.Drawing.Point(171, 162)
        Me.txtCantidadUltimaCompra.Name = "txtCantidadUltimaCompra"
        Me.txtCantidadUltimaCompra.Size = New System.Drawing.Size(103, 20)
        Me.txtCantidadUltimaCompra.TabIndex = 77
        Me.txtCantidadUltimaCompra.TabStop = False
        Me.txtCantidadUltimaCompra.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(34, 139)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 13)
        Me.Label17.TabIndex = 78
        Me.Label17.Text = "Ultimo Costo :"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(327, 191)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(40, 13)
        Me.lblPrecio.TabIndex = 88
        Me.lblPrecio.Text = "Precio:"
        Me.lblPrecio.Visible = False
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(373, 188)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(52, 20)
        Me.txtprecio.TabIndex = 87
        Me.txtprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtprecio.Visible = False
        '
        'chkEsKit
        '
        Me.chkEsKit.AutoSize = True
        Me.chkEsKit.Location = New System.Drawing.Point(273, 190)
        Me.chkEsKit.Name = "chkEsKit"
        Me.chkEsKit.Size = New System.Drawing.Size(53, 17)
        Me.chkEsKit.TabIndex = 84
        Me.chkEsKit.Text = "Es Kit"
        Me.chkEsKit.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(17, 191)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(91, 13)
        Me.Label19.TabIndex = 83
        Me.Label19.Text = "Código de Barras:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Marca:"
        '
        'cmbMarcas
        '
        Me.cmbMarcas.FormattingEnabled = True
        Me.cmbMarcas.Location = New System.Drawing.Point(117, 134)
        Me.cmbMarcas.Name = "cmbMarcas"
        Me.cmbMarcas.Size = New System.Drawing.Size(224, 21)
        Me.cmbMarcas.TabIndex = 4
        '
        'txtCodigoBarra
        '
        Me.txtCodigoBarra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoBarra.Location = New System.Drawing.Point(117, 188)
        Me.txtCodigoBarra.Name = "txtCodigoBarra"
        Me.txtCodigoBarra.Size = New System.Drawing.Size(150, 20)
        Me.txtCodigoBarra.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(17, 84)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 13)
        Me.Label13.TabIndex = 66
        Me.Label13.Text = "Descripción Corta:"
        '
        'txtDescCorta
        '
        Me.txtDescCorta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescCorta.Location = New System.Drawing.Point(117, 81)
        Me.txtDescCorta.Name = "txtDescCorta"
        Me.txtDescCorta.Size = New System.Drawing.Size(328, 20)
        Me.txtDescCorta.TabIndex = 2
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(353, 8)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(92, 20)
        Me.dtpFecha.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(265, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "Fecha de Alta:"
        '
        'cmbUnidadesMedida
        '
        Me.cmbUnidadesMedida.FormattingEnabled = True
        Me.cmbUnidadesMedida.Location = New System.Drawing.Point(117, 161)
        Me.cmbUnidadesMedida.Name = "cmbUnidadesMedida"
        Me.cmbUnidadesMedida.Size = New System.Drawing.Size(224, 21)
        Me.cmbUnidadesMedida.TabIndex = 5
        '
        'cmbFamilia
        '
        Me.cmbFamilia.FormattingEnabled = True
        Me.cmbFamilia.Location = New System.Drawing.Point(117, 107)
        Me.cmbFamilia.Name = "cmbFamilia"
        Me.cmbFamilia.Size = New System.Drawing.Size(328, 21)
        Me.cmbFamilia.TabIndex = 3
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(117, 34)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDescripcion.Size = New System.Drawing.Size(328, 41)
        Me.txtDescripcion.TabIndex = 1
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(117, 8)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Unidad de Medida :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Familia :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Descripción:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Codigo:"
        '
        'chkObtenerMermas
        '
        Me.chkObtenerMermas.AutoSize = True
        Me.chkObtenerMermas.Location = New System.Drawing.Point(26, 65)
        Me.chkObtenerMermas.Name = "chkObtenerMermas"
        Me.chkObtenerMermas.Size = New System.Drawing.Size(104, 17)
        Me.chkObtenerMermas.TabIndex = 10
        Me.chkObtenerMermas.Text = "Obtener Mermas"
        Me.chkObtenerMermas.UseVisualStyleBackColor = True
        Me.chkObtenerMermas.Visible = False
        '
        'txtPiezas
        '
        Me.txtPiezas.Location = New System.Drawing.Point(68, 101)
        Me.txtPiezas.Name = "txtPiezas"
        Me.txtPiezas.Size = New System.Drawing.Size(64, 20)
        Me.txtPiezas.TabIndex = 70
        Me.txtPiezas.Visible = False
        '
        'GpoIngrediente
        '
        Me.GpoIngrediente.Controls.Add(Me.chkFormula)
        Me.GpoIngrediente.Controls.Add(Me.chkIngrediente)
        Me.GpoIngrediente.Controls.Add(Me.rbMaterialPaEnvases)
        Me.GpoIngrediente.Controls.Add(Me.rbIngrediente)
        Me.GpoIngrediente.Location = New System.Drawing.Point(436, 96)
        Me.GpoIngrediente.Name = "GpoIngrediente"
        Me.GpoIngrediente.Size = New System.Drawing.Size(303, 36)
        Me.GpoIngrediente.TabIndex = 62
        Me.GpoIngrediente.TabStop = False
        Me.GpoIngrediente.Text = "Tipo de Producto"
        Me.GpoIngrediente.Visible = False
        '
        'chkFormula
        '
        Me.chkFormula.AutoSize = True
        Me.chkFormula.Location = New System.Drawing.Point(152, 13)
        Me.chkFormula.Name = "chkFormula"
        Me.chkFormula.Size = New System.Drawing.Size(66, 17)
        Me.chkFormula.TabIndex = 3
        Me.chkFormula.Text = "Paquete"
        Me.chkFormula.UseVisualStyleBackColor = True
        '
        'chkIngrediente
        '
        Me.chkIngrediente.AutoSize = True
        Me.chkIngrediente.Location = New System.Drawing.Point(26, 13)
        Me.chkIngrediente.Name = "chkIngrediente"
        Me.chkIngrediente.Size = New System.Drawing.Size(63, 17)
        Me.chkIngrediente.TabIndex = 2
        Me.chkIngrediente.Text = "Artículo"
        Me.chkIngrediente.UseVisualStyleBackColor = True
        '
        'rbMaterialPaEnvases
        '
        Me.rbMaterialPaEnvases.AutoSize = True
        Me.rbMaterialPaEnvases.Location = New System.Drawing.Point(152, 50)
        Me.rbMaterialPaEnvases.Name = "rbMaterialPaEnvases"
        Me.rbMaterialPaEnvases.Size = New System.Drawing.Size(131, 17)
        Me.rbMaterialPaEnvases.TabIndex = 1
        Me.rbMaterialPaEnvases.TabStop = True
        Me.rbMaterialPaEnvases.Text = "Material Para Envases"
        Me.rbMaterialPaEnvases.UseVisualStyleBackColor = True
        Me.rbMaterialPaEnvases.Visible = False
        '
        'rbIngrediente
        '
        Me.rbIngrediente.AutoSize = True
        Me.rbIngrediente.Location = New System.Drawing.Point(26, 50)
        Me.rbIngrediente.Name = "rbIngrediente"
        Me.rbIngrediente.Size = New System.Drawing.Size(78, 17)
        Me.rbIngrediente.TabIndex = 0
        Me.rbIngrediente.TabStop = True
        Me.rbIngrediente.Text = "Ingrediente"
        Me.rbIngrediente.UseVisualStyleBackColor = True
        Me.rbIngrediente.Visible = False
        '
        'chkFacturaSinExistencia
        '
        Me.chkFacturaSinExistencia.AutoSize = True
        Me.chkFacturaSinExistencia.Location = New System.Drawing.Point(26, 84)
        Me.chkFacturaSinExistencia.Name = "chkFacturaSinExistencia"
        Me.chkFacturaSinExistencia.Size = New System.Drawing.Size(129, 17)
        Me.chkFacturaSinExistencia.TabIndex = 11
        Me.chkFacturaSinExistencia.Text = "Factura sin Existencia"
        Me.chkFacturaSinExistencia.UseVisualStyleBackColor = True
        Me.chkFacturaSinExistencia.Visible = False
        '
        'chkSeRecibeParcialmente
        '
        Me.chkSeRecibeParcialmente.AutoSize = True
        Me.chkSeRecibeParcialmente.Location = New System.Drawing.Point(25, 42)
        Me.chkSeRecibeParcialmente.Name = "chkSeRecibeParcialmente"
        Me.chkSeRecibeParcialmente.Size = New System.Drawing.Size(140, 17)
        Me.chkSeRecibeParcialmente.TabIndex = 12
        Me.chkSeRecibeParcialmente.Text = "Se Recibe Parcialmente"
        Me.chkSeRecibeParcialmente.UseVisualStyleBackColor = True
        Me.chkSeRecibeParcialmente.Visible = False
        '
        'chkSeReciveSinFactura
        '
        Me.chkSeReciveSinFactura.AutoSize = True
        Me.chkSeReciveSinFactura.Location = New System.Drawing.Point(25, 19)
        Me.chkSeReciveSinFactura.Name = "chkSeReciveSinFactura"
        Me.chkSeReciveSinFactura.Size = New System.Drawing.Size(131, 17)
        Me.chkSeReciveSinFactura.TabIndex = 13
        Me.chkSeReciveSinFactura.Text = "Se Recibe sin Factura"
        Me.chkSeReciveSinFactura.UseVisualStyleBackColor = True
        Me.chkSeReciveSinFactura.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Piezas:"
        Me.Label9.Visible = False
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
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 599)
        Me.mtb.TabIndex = 0
        '
        'tbcPaquetes
        '
        Me.tbcPaquetes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbcPaquetes.Controls.Add(Me.tpKit)
        Me.tbcPaquetes.Controls.Add(Me.tpArmadoPaquetes)
        Me.tbcPaquetes.Controls.Add(Me.tpCostoIndirecto)
        Me.tbcPaquetes.Controls.Add(Me.tpHistorial)
        Me.tbcPaquetes.Location = New System.Drawing.Point(56, 269)
        Me.tbcPaquetes.Name = "tbcPaquetes"
        Me.tbcPaquetes.SelectedIndex = 0
        Me.tbcPaquetes.Size = New System.Drawing.Size(878, 276)
        Me.tbcPaquetes.TabIndex = 13
        '
        'tpKit
        '
        Me.tpKit.Controls.Add(Me.dgvKit)
        Me.tpKit.Location = New System.Drawing.Point(4, 22)
        Me.tpKit.Name = "tpKit"
        Me.tpKit.Padding = New System.Windows.Forms.Padding(3)
        Me.tpKit.Size = New System.Drawing.Size(870, 250)
        Me.tpKit.TabIndex = 4
        Me.tpKit.Text = "Construcción de Kit"
        Me.tpKit.UseVisualStyleBackColor = True
        '
        'dgvKit
        '
        Me.dgvKit.AllowUserToResizeRows = False
        DataGridViewCellStyle1.NullValue = Nothing
        Me.dgvKit.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvKit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvKit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvKit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvKit.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvKit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmCodBarra, Me.clmProducto, Me.clmCantidad, Me.clmPreVenta, Me.clmPreKit, Me.clmTotalPre, Me.clmTotalPreKit})
        Me.dgvKit.Location = New System.Drawing.Point(-4, 0)
        Me.dgvKit.Name = "dgvKit"
        Me.dgvKit.ReemplazarKey = System.Windows.Forms.Keys.[Return]
        Me.dgvKit.ReemplazarKeyPor = System.Windows.Forms.Keys.Tab
        Me.dgvKit.Size = New System.Drawing.Size(874, 254)
        Me.dgvKit.TabIndex = 1
        '
        'clmCodBarra
        '
        Me.clmCodBarra.FillWeight = 90.0!
        Me.clmCodBarra.HeaderText = "Cod. Barras"
        Me.clmCodBarra.Name = "clmCodBarra"
        '
        'clmProducto
        '
        Me.clmProducto.FillWeight = 120.0!
        Me.clmProducto.HeaderText = "Producto"
        Me.clmProducto.Name = "clmProducto"
        '
        'clmCantidad
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0.00"
        Me.clmCantidad.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmCantidad.FillWeight = 35.0!
        Me.clmCantidad.HeaderText = "Cantidad"
        Me.clmCantidad.Name = "clmCantidad"
        '
        'clmPreVenta
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        Me.clmPreVenta.DefaultCellStyle = DataGridViewCellStyle4
        Me.clmPreVenta.FillWeight = 35.0!
        Me.clmPreVenta.HeaderText = "Precio Venta"
        Me.clmPreVenta.Name = "clmPreVenta"
        '
        'clmPreKit
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        Me.clmPreKit.DefaultCellStyle = DataGridViewCellStyle5
        Me.clmPreKit.FillWeight = 35.0!
        Me.clmPreKit.HeaderText = "Precio en Kit"
        Me.clmPreKit.Name = "clmPreKit"
        '
        'clmTotalPre
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = "0.00"
        Me.clmTotalPre.DefaultCellStyle = DataGridViewCellStyle6
        Me.clmTotalPre.FillWeight = 50.0!
        Me.clmTotalPre.HeaderText = "Total Normal"
        Me.clmTotalPre.Name = "clmTotalPre"
        '
        'clmTotalPreKit
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = "0.00"
        Me.clmTotalPreKit.DefaultCellStyle = DataGridViewCellStyle7
        Me.clmTotalPreKit.FillWeight = 50.0!
        Me.clmTotalPreKit.HeaderText = "Total Kit"
        Me.clmTotalPreKit.Name = "clmTotalPreKit"
        '
        'tpArmadoPaquetes
        '
        Me.tpArmadoPaquetes.Controls.Add(Me.dgvIngredientes)
        Me.tpArmadoPaquetes.Controls.Add(Me.GpoPaquete)
        Me.tpArmadoPaquetes.Controls.Add(Me.Label6)
        Me.tpArmadoPaquetes.Controls.Add(Me.cmbTipoProd)
        Me.tpArmadoPaquetes.Controls.Add(Me.cmbPresentacion)
        Me.tpArmadoPaquetes.Controls.Add(Me.Label14)
        Me.tpArmadoPaquetes.Controls.Add(Me.cmbSubFamilia)
        Me.tpArmadoPaquetes.Controls.Add(Me.Label12)
        Me.tpArmadoPaquetes.Controls.Add(Me.GpoIngrediente)
        Me.tpArmadoPaquetes.Controls.Add(Me.chkSeReciveSinFactura)
        Me.tpArmadoPaquetes.Controls.Add(Me.Label9)
        Me.tpArmadoPaquetes.Controls.Add(Me.chkSeRecibeParcialmente)
        Me.tpArmadoPaquetes.Controls.Add(Me.chkFacturaSinExistencia)
        Me.tpArmadoPaquetes.Controls.Add(Me.txtPiezas)
        Me.tpArmadoPaquetes.Controls.Add(Me.chkObtenerMermas)
        Me.tpArmadoPaquetes.Location = New System.Drawing.Point(4, 22)
        Me.tpArmadoPaquetes.Name = "tpArmadoPaquetes"
        Me.tpArmadoPaquetes.Padding = New System.Windows.Forms.Padding(3)
        Me.tpArmadoPaquetes.Size = New System.Drawing.Size(870, 250)
        Me.tpArmadoPaquetes.TabIndex = 0
        Me.tpArmadoPaquetes.Text = "Generación de Paquetes"
        Me.tpArmadoPaquetes.UseVisualStyleBackColor = True
        '
        'dgvIngredientes
        '
        Me.dgvIngredientes.AllowUserToAddRows = False
        Me.dgvIngredientes.AllowUserToDeleteRows = False
        Me.dgvIngredientes.AllowUserToResizeRows = False
        Me.dgvIngredientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIngredientes.Location = New System.Drawing.Point(0, 3)
        Me.dgvIngredientes.Name = "dgvIngredientes"
        Me.dgvIngredientes.RowHeadersVisible = False
        Me.dgvIngredientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvIngredientes.Size = New System.Drawing.Size(868, 247)
        Me.dgvIngredientes.TabIndex = 0
        '
        'GpoPaquete
        '
        Me.GpoPaquete.Controls.Add(Me.rbEsMezcla)
        Me.GpoPaquete.Controls.Add(Me.rbProductoGeneral)
        Me.GpoPaquete.Location = New System.Drawing.Point(406, 6)
        Me.GpoPaquete.Name = "GpoPaquete"
        Me.GpoPaquete.Size = New System.Drawing.Size(356, 41)
        Me.GpoPaquete.TabIndex = 61
        Me.GpoPaquete.TabStop = False
        Me.GpoPaquete.Visible = False
        '
        'rbEsMezcla
        '
        Me.rbEsMezcla.AutoSize = True
        Me.rbEsMezcla.Location = New System.Drawing.Point(158, 13)
        Me.rbEsMezcla.Name = "rbEsMezcla"
        Me.rbEsMezcla.Size = New System.Drawing.Size(125, 17)
        Me.rbEsMezcla.TabIndex = 1
        Me.rbEsMezcla.TabStop = True
        Me.rbEsMezcla.Text = "Es Mezcla (Formulas)"
        Me.rbEsMezcla.UseVisualStyleBackColor = True
        '
        'rbProductoGeneral
        '
        Me.rbProductoGeneral.AutoSize = True
        Me.rbProductoGeneral.Location = New System.Drawing.Point(26, 13)
        Me.rbProductoGeneral.Name = "rbProductoGeneral"
        Me.rbProductoGeneral.Size = New System.Drawing.Size(108, 17)
        Me.rbProductoGeneral.TabIndex = 0
        Me.rbProductoGeneral.TabStop = True
        Me.rbProductoGeneral.Text = "Producto General"
        Me.rbProductoGeneral.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Presentación:"
        Me.Label6.Visible = False
        '
        'cmbTipoProd
        '
        Me.cmbTipoProd.FormattingEnabled = True
        Me.cmbTipoProd.Location = New System.Drawing.Point(122, 138)
        Me.cmbTipoProd.Name = "cmbTipoProd"
        Me.cmbTipoProd.Size = New System.Drawing.Size(328, 21)
        Me.cmbTipoProd.TabIndex = 68
        Me.cmbTipoProd.Visible = False
        '
        'cmbPresentacion
        '
        Me.cmbPresentacion.FormattingEnabled = True
        Me.cmbPresentacion.Location = New System.Drawing.Point(122, 167)
        Me.cmbPresentacion.Name = "cmbPresentacion"
        Me.cmbPresentacion.Size = New System.Drawing.Size(328, 21)
        Me.cmbPresentacion.TabIndex = 59
        Me.cmbPresentacion.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(22, 141)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 13)
        Me.Label14.TabIndex = 67
        Me.Label14.Text = "Tipo de Producto:"
        Me.Label14.Visible = False
        '
        'cmbSubFamilia
        '
        Me.cmbSubFamilia.FormattingEnabled = True
        Me.cmbSubFamilia.Location = New System.Drawing.Point(434, 53)
        Me.cmbSubFamilia.Name = "cmbSubFamilia"
        Me.cmbSubFamilia.Size = New System.Drawing.Size(328, 21)
        Me.cmbSubFamilia.TabIndex = 53
        Me.cmbSubFamilia.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(334, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "Sub-Línea :"
        Me.Label12.Visible = False
        '
        'tpCostoIndirecto
        '
        Me.tpCostoIndirecto.Controls.Add(Me.Label18)
        Me.tpCostoIndirecto.Controls.Add(Me.dgvCIR)
        Me.tpCostoIndirecto.Location = New System.Drawing.Point(4, 22)
        Me.tpCostoIndirecto.Name = "tpCostoIndirecto"
        Me.tpCostoIndirecto.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCostoIndirecto.Size = New System.Drawing.Size(870, 250)
        Me.tpCostoIndirecto.TabIndex = 1
        Me.tpCostoIndirecto.Text = "Costos Indirectos"
        Me.tpCostoIndirecto.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(2, 217)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(152, 13)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "F6 = Agregar Costos Indirectos"
        '
        'dgvCIR
        '
        Me.dgvCIR.AllowUserToAddRows = False
        Me.dgvCIR.AllowUserToDeleteRows = False
        Me.dgvCIR.AllowUserToResizeRows = False
        Me.dgvCIR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCIR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCIR.Location = New System.Drawing.Point(6, 6)
        Me.dgvCIR.Name = "dgvCIR"
        Me.dgvCIR.RowHeadersVisible = False
        Me.dgvCIR.Size = New System.Drawing.Size(852, 199)
        Me.dgvCIR.TabIndex = 1
        '
        'tpHistorial
        '
        Me.tpHistorial.Controls.Add(Me.dgvHistorialCompras)
        Me.tpHistorial.Location = New System.Drawing.Point(4, 22)
        Me.tpHistorial.Name = "tpHistorial"
        Me.tpHistorial.Padding = New System.Windows.Forms.Padding(3)
        Me.tpHistorial.Size = New System.Drawing.Size(870, 250)
        Me.tpHistorial.TabIndex = 3
        Me.tpHistorial.Text = "Historial de Compras"
        Me.tpHistorial.UseVisualStyleBackColor = True
        '
        'dgvHistorialCompras
        '
        Me.dgvHistorialCompras.AllowUserToAddRows = False
        Me.dgvHistorialCompras.AllowUserToDeleteRows = False
        Me.dgvHistorialCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistorialCompras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmProveedor, Me.clmCostoUnitario, Me.clmFecha})
        Me.dgvHistorialCompras.Location = New System.Drawing.Point(0, 3)
        Me.dgvHistorialCompras.Name = "dgvHistorialCompras"
        Me.dgvHistorialCompras.ReadOnly = True
        Me.dgvHistorialCompras.RowHeadersVisible = False
        Me.dgvHistorialCompras.Size = New System.Drawing.Size(867, 244)
        Me.dgvHistorialCompras.TabIndex = 0
        '
        'clmPrjNutriente
        '
        Me.clmPrjNutriente.DataPropertyName = "PorcentajeNutriente"
        Me.clmPrjNutriente.HeaderText = "Porcentaje"
        Me.clmPrjNutriente.Name = "clmPrjNutriente"
        '
        'clmNutriente
        '
        Me.clmNutriente.DataPropertyName = "IdNutriente"
        Me.clmNutriente.HeaderText = "Nutriente"
        Me.clmNutriente.Name = "clmNutriente"
        Me.clmNutriente.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmNutriente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clmNutriente.Width = 300
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarFilaToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(137, 26)
        '
        'EliminarFilaToolStripMenuItem
        '
        Me.EliminarFilaToolStripMenuItem.Name = "EliminarFilaToolStripMenuItem"
        Me.EliminarFilaToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.EliminarFilaToolStripMenuItem.Text = "Eliminar fila"
        '
        'lblTotalKit
        '
        Me.lblTotalKit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalKit.Location = New System.Drawing.Point(841, 548)
        Me.lblTotalKit.Name = "lblTotalKit"
        Me.lblTotalKit.Size = New System.Drawing.Size(87, 13)
        Me.lblTotalKit.TabIndex = 36
        Me.lblTotalKit.Text = "0.00"
        Me.lblTotalKit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalPrecio
        '
        Me.lblTotalPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPrecio.Location = New System.Drawing.Point(714, 548)
        Me.lblTotalPrecio.Name = "lblTotalPrecio"
        Me.lblTotalPrecio.Size = New System.Drawing.Size(121, 13)
        Me.lblTotalPrecio.TabIndex = 37
        Me.lblTotalPrecio.Text = "0.00"
        Me.lblTotalPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'clmProveedor
        '
        Me.clmProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clmProveedor.DataPropertyName = "Proveedor"
        Me.clmProveedor.FillWeight = 60.0!
        Me.clmProveedor.HeaderText = "Proveedor"
        Me.clmProveedor.Name = "clmProveedor"
        Me.clmProveedor.ReadOnly = True
        '
        'clmCostoUnitario
        '
        Me.clmCostoUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clmCostoUnitario.DataPropertyName = "Costo"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = "0"
        Me.clmCostoUnitario.DefaultCellStyle = DataGridViewCellStyle8
        Me.clmCostoUnitario.FillWeight = 20.0!
        Me.clmCostoUnitario.HeaderText = "Costo Unitario"
        Me.clmCostoUnitario.Name = "clmCostoUnitario"
        Me.clmCostoUnitario.ReadOnly = True
        '
        'clmFecha
        '
        Me.clmFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clmFecha.DataPropertyName = "Fecha"
        Me.clmFecha.FillWeight = 20.0!
        Me.clmFecha.HeaderText = "Fecha Ult. Compra"
        Me.clmFecha.Name = "clmFecha"
        Me.clmFecha.ReadOnly = True
        '
        'frmABCProducosComprasGen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 599)
        Me.Controls.Add(Me.lblTotalPrecio)
        Me.Controls.Add(Me.lblTotalKit)
        Me.Controls.Add(Me.tbcPaquetes)
        Me.Controls.Add(Me.Pan)
        Me.Controls.Add(Me.lblTema)
        Me.Controls.Add(Me.mtb)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(956, 637)
        Me.MinimumSize = New System.Drawing.Size(956, 637)
        Me.Name = "frmABCProducosComprasGen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catálogo de Productos"
        Me.Pan.ResumeLayout(False)
        Me.Pan.PerformLayout()
        Me.gbdet.ResumeLayout(False)
        Me.gbdet.PerformLayout()
        Me.GpoIngrediente.ResumeLayout(False)
        Me.GpoIngrediente.PerformLayout()
        Me.tbcPaquetes.ResumeLayout(False)
        Me.tpKit.ResumeLayout(False)
        CType(Me.dgvKit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpArmadoPaquetes.ResumeLayout(False)
        Me.tpArmadoPaquetes.PerformLayout()
        CType(Me.dgvIngredientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GpoPaquete.ResumeLayout(False)
        Me.GpoPaquete.PerformLayout()
        Me.tpCostoIndirecto.ResumeLayout(False)
        Me.tpCostoIndirecto.PerformLayout()
        CType(Me.dgvCIR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpHistorial.ResumeLayout(False)
        CType(Me.dgvHistorialCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Private WithEvents lblTema As System.Windows.Forms.Label
    Friend WithEvents PresentacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeObtieneMermasDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IngredienteDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SubLineaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeRecibeParcialDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ProductoGeneralDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MaterialEnvaseDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IsNewDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SeRecibeSinFacturaDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SeManejaPorLotesDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DescCortaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnidadMedidaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaBajaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObservacionBajaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoUsuarioBajaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PiezasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiasminCaducidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoMotivoBajaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeFacturaDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FechaAltaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeFacturaSinExistenciaDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CodigoUsuarioAltaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MezclaDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pan As System.Windows.Forms.Panel
    Friend WithEvents chkSeFactura As System.Windows.Forms.CheckBox
    Friend WithEvents chkObtenerMermas As System.Windows.Forms.CheckBox
    Friend WithEvents chkFacturaSinExistencia As System.Windows.Forms.CheckBox
    Friend WithEvents chkSeRecibeParcialmente As System.Windows.Forms.CheckBox
    Friend WithEvents chkSeReciveSinFactura As System.Windows.Forms.CheckBox
    Friend WithEvents chkSeManejaProLotes As System.Windows.Forms.CheckBox
    Friend WithEvents chkCaduca As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GpoIngrediente As System.Windows.Forms.GroupBox
    Friend WithEvents rbMaterialPaEnvases As System.Windows.Forms.RadioButton
    Friend WithEvents rbIngrediente As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDescCorta As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblestatus As System.Windows.Forms.Label
    Friend WithEvents cmbUnidadesMedida As System.Windows.Forms.ComboBox
    Friend WithEvents cmbFamilia As System.Windows.Forms.ComboBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProductosPaqueteC As ClasesNegocio.ProductosPaqueteCollection
    Friend WithEvents ProdCostoIndirectoC As ClasesNegocio.ProdCostoIndirectoCollection
    Friend WithEvents txtPiezas As System.Windows.Forms.TextBox
    Friend WithEvents txtCaducidad As System.Windows.Forms.TextBox
    Friend WithEvents chkAplicaIva As System.Windows.Forms.CheckBox
    Friend WithEvents chkFormula As System.Windows.Forms.CheckBox
    Friend WithEvents chkIngrediente As System.Windows.Forms.CheckBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtUltimoCosto As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtCantidadUltimaCompra As System.Windows.Forms.TextBox
    Friend WithEvents txtImportteUltimaCompra As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaUltimaCompra As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtieps As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbcPaquetes As System.Windows.Forms.TabControl
    Friend WithEvents tpArmadoPaquetes As System.Windows.Forms.TabPage
    Friend WithEvents dgvIngredientes As System.Windows.Forms.DataGridView
    Friend WithEvents GpoPaquete As System.Windows.Forms.GroupBox
    Friend WithEvents rbEsMezcla As System.Windows.Forms.RadioButton
    Friend WithEvents rbProductoGeneral As System.Windows.Forms.RadioButton
    Friend WithEvents cmbTipoProd As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbPresentacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbMarcas As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbSubFamilia As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tpCostoIndirecto As System.Windows.Forms.TabPage
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents dgvCIR As System.Windows.Forms.DataGridView
    Friend WithEvents CostoIndirectoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tpHistorial As System.Windows.Forms.TabPage
    Friend WithEvents dgvHistorialCompras As System.Windows.Forms.DataGridView
    Friend WithEvents clmPrjNutriente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmNutriente As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents clmIngrediente As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents clmPrjIngrediente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoBarra As System.Windows.Forms.TextBox
    Friend WithEvents chkEsKit As System.Windows.Forms.CheckBox
    Friend WithEvents tpKit As System.Windows.Forms.TabPage
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EliminarFilaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtprecio As System.Windows.Forms.TextBox
    Friend WithEvents lblPrecio As System.Windows.Forms.Label
    Friend WithEvents checkArtSinExis As System.Windows.Forms.CheckBox
    Friend WithEvents dgvKit As Integralab.Controles.DataGridViewMejorado
    Friend WithEvents lblTotalKit As System.Windows.Forms.Label
    Friend WithEvents lblTotalPrecio As System.Windows.Forms.Label
    Friend WithEvents gbdet As System.Windows.Forms.GroupBox
    Friend WithEvents clmCodBarra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmProducto As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents clmCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPreVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPreKit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTotalPre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTotalPreKit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCostoUnitario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    'Friend WithEvents ProdCollection As ClasesNegocio.ProductosCollectionClass

End Class
