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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.tbcPaquetes = New System.Windows.Forms.TabControl
        Me.tpArmadoPaquetes = New System.Windows.Forms.TabPage
        Me.GpoPaquete = New System.Windows.Forms.GroupBox
        Me.rbEsMezcla = New System.Windows.Forms.RadioButton
        Me.rbProductoGeneral = New System.Windows.Forms.RadioButton
        Me.cmbTipoProd = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbPresentacion = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.cmbMarcas = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbSubFamilia = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.tpCostoIndirecto = New System.Windows.Forms.TabPage
        Me.Label12 = New System.Windows.Forms.Label
        Me.tpNutrientes = New System.Windows.Forms.TabPage
        Me.dgvNutrientes = New System.Windows.Forms.DataGridView
        Me.clmNutriente = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.clmPrjNutriente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tpHistorial = New System.Windows.Forms.TabPage
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.clmProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCostoUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lblTema = New System.Windows.Forms.Label
        Me.Pan = New System.Windows.Forms.Panel
        Me.txtUltimoCosto = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtCantidadUltimaCompra = New System.Windows.Forms.TextBox
        Me.txtImportteUltimaCompra = New System.Windows.Forms.TextBox
        Me.dtpFechaUltimaCompra = New System.Windows.Forms.DateTimePicker
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.chkAplicaIva = New System.Windows.Forms.CheckBox
        Me.chkSeFactura = New System.Windows.Forms.CheckBox
        Me.chkObtenerMermas = New System.Windows.Forms.CheckBox
        Me.txtPiezas = New System.Windows.Forms.TextBox
        Me.GpoIngrediente = New System.Windows.Forms.GroupBox
        Me.chkFormula = New System.Windows.Forms.CheckBox
        Me.chkIngrediente = New System.Windows.Forms.CheckBox
        Me.rbMaterialPaEnvases = New System.Windows.Forms.RadioButton
        Me.rbIngrediente = New System.Windows.Forms.RadioButton
        Me.chkFacturaSinExistencia = New System.Windows.Forms.CheckBox
        Me.chkSeRecibeParcialmente = New System.Windows.Forms.CheckBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtDescCorta = New System.Windows.Forms.TextBox
        Me.chkSeReciveSinFactura = New System.Windows.Forms.CheckBox
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.chkSeManejaProLotes = New System.Windows.Forms.CheckBox
        Me.txtCaducidad = New System.Windows.Forms.TextBox
        Me.lblestatus = New System.Windows.Forms.Label
        Me.chkCaduca = New System.Windows.Forms.CheckBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbUnidadesMedida = New System.Windows.Forms.ComboBox
        Me.cmbFamilia = New System.Windows.Forms.ComboBox
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.dgvIngredientes = New System.Windows.Forms.DataGridView
        Me.clmIngrediente = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.clmPrjIngrediente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProductosPaqueteC = New ClasesNegocio.ProductosPaqueteCollection
        Me.dgvCIR = New System.Windows.Forms.DataGridView
        Me.CostoIndirectoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProdCostoIndirectoC = New ClasesNegocio.ProdCostoIndirectoCollection
        Me.tbcPaquetes.SuspendLayout()
        Me.tpArmadoPaquetes.SuspendLayout()
        Me.GpoPaquete.SuspendLayout()
        Me.tpCostoIndirecto.SuspendLayout()
        Me.tpNutrientes.SuspendLayout()
        CType(Me.dgvNutrientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpHistorial.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pan.SuspendLayout()
        Me.GpoIngrediente.SuspendLayout()
        CType(Me.dgvIngredientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCIR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcPaquetes
        '
        Me.tbcPaquetes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbcPaquetes.Controls.Add(Me.tpArmadoPaquetes)
        Me.tbcPaquetes.Controls.Add(Me.tpCostoIndirecto)
        Me.tbcPaquetes.Controls.Add(Me.tpNutrientes)
        Me.tbcPaquetes.Controls.Add(Me.tpHistorial)
        Me.tbcPaquetes.Location = New System.Drawing.Point(56, 234)
        Me.tbcPaquetes.Name = "tbcPaquetes"
        Me.tbcPaquetes.SelectedIndex = 0
        Me.tbcPaquetes.Size = New System.Drawing.Size(776, 253)
        Me.tbcPaquetes.TabIndex = 20
        '
        'tpArmadoPaquetes
        '
        Me.tpArmadoPaquetes.Controls.Add(Me.dgvIngredientes)
        Me.tpArmadoPaquetes.Controls.Add(Me.GpoPaquete)
        Me.tpArmadoPaquetes.Controls.Add(Me.cmbMarcas)
        Me.tpArmadoPaquetes.Controls.Add(Me.Label7)
        Me.tpArmadoPaquetes.Controls.Add(Me.cmbSubFamilia)
        Me.tpArmadoPaquetes.Controls.Add(Me.Label4)
        Me.tpArmadoPaquetes.Location = New System.Drawing.Point(4, 22)
        Me.tpArmadoPaquetes.Name = "tpArmadoPaquetes"
        Me.tpArmadoPaquetes.Padding = New System.Windows.Forms.Padding(3)
        Me.tpArmadoPaquetes.Size = New System.Drawing.Size(768, 227)
        Me.tpArmadoPaquetes.TabIndex = 0
        Me.tpArmadoPaquetes.Text = "Generación de Mezclas"
        Me.tpArmadoPaquetes.UseVisualStyleBackColor = True
        '
        'GpoPaquete
        '
        Me.GpoPaquete.Controls.Add(Me.rbEsMezcla)
        Me.GpoPaquete.Controls.Add(Me.rbProductoGeneral)
        Me.GpoPaquete.Controls.Add(Me.cmbTipoProd)
        Me.GpoPaquete.Controls.Add(Me.Label6)
        Me.GpoPaquete.Controls.Add(Me.cmbPresentacion)
        Me.GpoPaquete.Controls.Add(Me.Label14)
        Me.GpoPaquete.Location = New System.Drawing.Point(457, 7)
        Me.GpoPaquete.Name = "GpoPaquete"
        Me.GpoPaquete.Size = New System.Drawing.Size(303, 34)
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
        'cmbTipoProd
        '
        Me.cmbTipoProd.FormattingEnabled = True
        Me.cmbTipoProd.Location = New System.Drawing.Point(-86, 19)
        Me.cmbTipoProd.Name = "cmbTipoProd"
        Me.cmbTipoProd.Size = New System.Drawing.Size(328, 21)
        Me.cmbTipoProd.TabIndex = 68
        Me.cmbTipoProd.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(-186, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Presentación:"
        Me.Label6.Visible = False
        '
        'cmbPresentacion
        '
        Me.cmbPresentacion.FormattingEnabled = True
        Me.cmbPresentacion.Location = New System.Drawing.Point(-86, 48)
        Me.cmbPresentacion.Name = "cmbPresentacion"
        Me.cmbPresentacion.Size = New System.Drawing.Size(328, 21)
        Me.cmbPresentacion.TabIndex = 59
        Me.cmbPresentacion.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(-186, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 13)
        Me.Label14.TabIndex = 67
        Me.Label14.Text = "Tipo de Producto:"
        Me.Label14.Visible = False
        '
        'cmbMarcas
        '
        Me.cmbMarcas.FormattingEnabled = True
        Me.cmbMarcas.Location = New System.Drawing.Point(448, 67)
        Me.cmbMarcas.Name = "cmbMarcas"
        Me.cmbMarcas.Size = New System.Drawing.Size(224, 21)
        Me.cmbMarcas.TabIndex = 57
        Me.cmbMarcas.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(348, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Marca:"
        Me.Label7.Visible = False
        '
        'cmbSubFamilia
        '
        Me.cmbSubFamilia.FormattingEnabled = True
        Me.cmbSubFamilia.Location = New System.Drawing.Point(426, 40)
        Me.cmbSubFamilia.Name = "cmbSubFamilia"
        Me.cmbSubFamilia.Size = New System.Drawing.Size(328, 21)
        Me.cmbSubFamilia.TabIndex = 53
        Me.cmbSubFamilia.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(326, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Sub-Línea :"
        Me.Label4.Visible = False
        '
        'tpCostoIndirecto
        '
        Me.tpCostoIndirecto.Controls.Add(Me.Label12)
        Me.tpCostoIndirecto.Controls.Add(Me.dgvCIR)
        Me.tpCostoIndirecto.Location = New System.Drawing.Point(4, 22)
        Me.tpCostoIndirecto.Name = "tpCostoIndirecto"
        Me.tpCostoIndirecto.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCostoIndirecto.Size = New System.Drawing.Size(768, 227)
        Me.tpCostoIndirecto.TabIndex = 1
        Me.tpCostoIndirecto.Text = "Costos Indirectos"
        Me.tpCostoIndirecto.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 211)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(152, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "F6 = Agregar Costos Indirectos"
        '
        'tpNutrientes
        '
        Me.tpNutrientes.Controls.Add(Me.dgvNutrientes)
        Me.tpNutrientes.Location = New System.Drawing.Point(4, 22)
        Me.tpNutrientes.Name = "tpNutrientes"
        Me.tpNutrientes.Padding = New System.Windows.Forms.Padding(3)
        Me.tpNutrientes.Size = New System.Drawing.Size(768, 227)
        Me.tpNutrientes.TabIndex = 2
        Me.tpNutrientes.Text = "Nutrientes"
        Me.tpNutrientes.UseVisualStyleBackColor = True
        '
        'dgvNutrientes
        '
        Me.dgvNutrientes.AllowUserToAddRows = False
        Me.dgvNutrientes.AllowUserToDeleteRows = False
        Me.dgvNutrientes.AllowUserToResizeRows = False
        Me.dgvNutrientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvNutrientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNutrientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmNutriente, Me.clmPrjNutriente})
        Me.dgvNutrientes.Location = New System.Drawing.Point(6, 6)
        Me.dgvNutrientes.Name = "dgvNutrientes"
        Me.dgvNutrientes.RowHeadersVisible = False
        Me.dgvNutrientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvNutrientes.Size = New System.Drawing.Size(757, 215)
        Me.dgvNutrientes.TabIndex = 0
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
        'clmPrjNutriente
        '
        Me.clmPrjNutriente.DataPropertyName = "PorcentajeNutriente"
        Me.clmPrjNutriente.HeaderText = "Porcentaje"
        Me.clmPrjNutriente.Name = "clmPrjNutriente"
        '
        'tpHistorial
        '
        Me.tpHistorial.Controls.Add(Me.DataGridView1)
        Me.tpHistorial.Location = New System.Drawing.Point(4, 22)
        Me.tpHistorial.Name = "tpHistorial"
        Me.tpHistorial.Padding = New System.Windows.Forms.Padding(3)
        Me.tpHistorial.Size = New System.Drawing.Size(768, 227)
        Me.tpHistorial.TabIndex = 3
        Me.tpHistorial.Text = "Historial de Compras"
        Me.tpHistorial.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmProveedor, Me.clmCostoUnitario, Me.clmFecha})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(756, 215)
        Me.DataGridView1.TabIndex = 0
        '
        'clmProveedor
        '
        Me.clmProveedor.HeaderText = "Proveedor"
        Me.clmProveedor.Name = "clmProveedor"
        Me.clmProveedor.ReadOnly = True
        Me.clmProveedor.Width = 300
        '
        'clmCostoUnitario
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.clmCostoUnitario.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmCostoUnitario.HeaderText = "Costo Unitario"
        Me.clmCostoUnitario.Name = "clmCostoUnitario"
        Me.clmCostoUnitario.ReadOnly = True
        '
        'clmFecha
        '
        Me.clmFecha.HeaderText = "Fecha Ult. Compra"
        Me.clmFecha.Name = "clmFecha"
        Me.clmFecha.ReadOnly = True
        Me.clmFecha.Width = 150
        '
        'lblTema
        '
        Me.lblTema.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTema.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTema.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTema.ForeColor = System.Drawing.Color.Transparent
        Me.lblTema.Location = New System.Drawing.Point(50, 0)
        Me.lblTema.Name = "lblTema"
        Me.lblTema.Size = New System.Drawing.Size(788, 29)
        Me.lblTema.TabIndex = 34
        Me.lblTema.Text = "CATÁLOGO DE PRODUCTOS"
        Me.lblTema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Pan
        '
        Me.Pan.Controls.Add(Me.txtUltimoCosto)
        Me.Pan.Controls.Add(Me.Label17)
        Me.Pan.Controls.Add(Me.txtCantidadUltimaCompra)
        Me.Pan.Controls.Add(Me.txtImportteUltimaCompra)
        Me.Pan.Controls.Add(Me.dtpFechaUltimaCompra)
        Me.Pan.Controls.Add(Me.Label16)
        Me.Pan.Controls.Add(Me.Label15)
        Me.Pan.Controls.Add(Me.Label11)
        Me.Pan.Controls.Add(Me.chkAplicaIva)
        Me.Pan.Controls.Add(Me.chkSeFactura)
        Me.Pan.Controls.Add(Me.chkObtenerMermas)
        Me.Pan.Controls.Add(Me.txtPiezas)
        Me.Pan.Controls.Add(Me.GpoIngrediente)
        Me.Pan.Controls.Add(Me.chkFacturaSinExistencia)
        Me.Pan.Controls.Add(Me.chkSeRecibeParcialmente)
        Me.Pan.Controls.Add(Me.Label13)
        Me.Pan.Controls.Add(Me.txtDescCorta)
        Me.Pan.Controls.Add(Me.chkSeReciveSinFactura)
        Me.Pan.Controls.Add(Me.dtpFecha)
        Me.Pan.Controls.Add(Me.Label10)
        Me.Pan.Controls.Add(Me.chkSeManejaProLotes)
        Me.Pan.Controls.Add(Me.txtCaducidad)
        Me.Pan.Controls.Add(Me.lblestatus)
        Me.Pan.Controls.Add(Me.chkCaduca)
        Me.Pan.Controls.Add(Me.Label8)
        Me.Pan.Controls.Add(Me.cmbUnidadesMedida)
        Me.Pan.Controls.Add(Me.cmbFamilia)
        Me.Pan.Controls.Add(Me.txtDescripcion)
        Me.Pan.Controls.Add(Me.txtCodigo)
        Me.Pan.Controls.Add(Me.Label9)
        Me.Pan.Controls.Add(Me.Label5)
        Me.Pan.Controls.Add(Me.Label3)
        Me.Pan.Controls.Add(Me.Label2)
        Me.Pan.Controls.Add(Me.Label1)
        Me.Pan.Location = New System.Drawing.Point(56, 32)
        Me.Pan.Name = "Pan"
        Me.Pan.Size = New System.Drawing.Size(776, 196)
        Me.Pan.TabIndex = 35
        '
        'txtUltimoCosto
        '
        Me.txtUltimoCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUltimoCosto.Location = New System.Drawing.Point(603, 164)
        Me.txtUltimoCosto.Name = "txtUltimoCosto"
        Me.txtUltimoCosto.Size = New System.Drawing.Size(92, 20)
        Me.txtUltimoCosto.TabIndex = 79
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(470, 168)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 13)
        Me.Label17.TabIndex = 78
        Me.Label17.Text = "Ultimo Costo :"
        '
        'txtCantidadUltimaCompra
        '
        Me.txtCantidadUltimaCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCantidadUltimaCompra.Location = New System.Drawing.Point(604, 139)
        Me.txtCantidadUltimaCompra.Name = "txtCantidadUltimaCompra"
        Me.txtCantidadUltimaCompra.Size = New System.Drawing.Size(92, 20)
        Me.txtCantidadUltimaCompra.TabIndex = 77
        '
        'txtImportteUltimaCompra
        '
        Me.txtImportteUltimaCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtImportteUltimaCompra.Location = New System.Drawing.Point(603, 117)
        Me.txtImportteUltimaCompra.Name = "txtImportteUltimaCompra"
        Me.txtImportteUltimaCompra.Size = New System.Drawing.Size(92, 20)
        Me.txtImportteUltimaCompra.TabIndex = 76
        '
        'dtpFechaUltimaCompra
        '
        Me.dtpFechaUltimaCompra.Enabled = False
        Me.dtpFechaUltimaCompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaUltimaCompra.Location = New System.Drawing.Point(603, 93)
        Me.dtpFechaUltimaCompra.Name = "dtpFechaUltimaCompra"
        Me.dtpFechaUltimaCompra.Size = New System.Drawing.Size(92, 20)
        Me.dtpFechaUltimaCompra.TabIndex = 75
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(470, 143)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(126, 13)
        Me.Label16.TabIndex = 74
        Me.Label16.Text = "Cantidad Ultima Compra :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(470, 121)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(119, 13)
        Me.Label15.TabIndex = 73
        Me.Label15.Text = "Importe Ultima Compra :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(470, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 13)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "Fecha Ultima Compra :"
        '
        'chkAplicaIva
        '
        Me.chkAplicaIva.AutoSize = True
        Me.chkAplicaIva.Location = New System.Drawing.Point(616, 36)
        Me.chkAplicaIva.Name = "chkAplicaIva"
        Me.chkAplicaIva.Size = New System.Drawing.Size(91, 17)
        Me.chkAplicaIva.TabIndex = 71
        Me.chkAplicaIva.Text = "Se Aplica IVA"
        Me.chkAplicaIva.UseVisualStyleBackColor = True
        '
        'chkSeFactura
        '
        Me.chkSeFactura.AutoSize = True
        Me.chkSeFactura.Location = New System.Drawing.Point(473, 35)
        Me.chkSeFactura.Name = "chkSeFactura"
        Me.chkSeFactura.Size = New System.Drawing.Size(78, 17)
        Me.chkSeFactura.TabIndex = 9
        Me.chkSeFactura.Text = "Se Factura"
        Me.chkSeFactura.UseVisualStyleBackColor = True
        '
        'chkObtenerMermas
        '
        Me.chkObtenerMermas.AutoSize = True
        Me.chkObtenerMermas.Location = New System.Drawing.Point(616, 34)
        Me.chkObtenerMermas.Name = "chkObtenerMermas"
        Me.chkObtenerMermas.Size = New System.Drawing.Size(104, 17)
        Me.chkObtenerMermas.TabIndex = 10
        Me.chkObtenerMermas.Text = "Obtener Mermas"
        Me.chkObtenerMermas.UseVisualStyleBackColor = True
        Me.chkObtenerMermas.Visible = False
        '
        'txtPiezas
        '
        Me.txtPiezas.Location = New System.Drawing.Point(117, 243)
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
        Me.GpoIngrediente.Location = New System.Drawing.Point(466, 53)
        Me.GpoIngrediente.Name = "GpoIngrediente"
        Me.GpoIngrediente.Size = New System.Drawing.Size(303, 36)
        Me.GpoIngrediente.TabIndex = 62
        Me.GpoIngrediente.TabStop = False
        Me.GpoIngrediente.Text = "Tipo de Producto"
        '
        'chkFormula
        '
        Me.chkFormula.AutoSize = True
        Me.chkFormula.Location = New System.Drawing.Point(152, 13)
        Me.chkFormula.Name = "chkFormula"
        Me.chkFormula.Size = New System.Drawing.Size(63, 17)
        Me.chkFormula.TabIndex = 3
        Me.chkFormula.Text = "Formula"
        Me.chkFormula.UseVisualStyleBackColor = True
        '
        'chkIngrediente
        '
        Me.chkIngrediente.AutoSize = True
        Me.chkIngrediente.Location = New System.Drawing.Point(26, 13)
        Me.chkIngrediente.Name = "chkIngrediente"
        Me.chkIngrediente.Size = New System.Drawing.Size(79, 17)
        Me.chkIngrediente.TabIndex = 2
        Me.chkIngrediente.Text = "Ingrediente"
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
        Me.chkFacturaSinExistencia.Location = New System.Drawing.Point(473, 58)
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
        Me.chkSeRecibeParcialmente.Location = New System.Drawing.Point(473, 88)
        Me.chkSeRecibeParcialmente.Name = "chkSeRecibeParcialmente"
        Me.chkSeRecibeParcialmente.Size = New System.Drawing.Size(140, 17)
        Me.chkSeRecibeParcialmente.TabIndex = 12
        Me.chkSeRecibeParcialmente.Text = "Se Recibe Parcialmente"
        Me.chkSeRecibeParcialmente.UseVisualStyleBackColor = True
        Me.chkSeRecibeParcialmente.Visible = False
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
        Me.txtDescCorta.TabIndex = 48
        '
        'chkSeReciveSinFactura
        '
        Me.chkSeReciveSinFactura.AutoSize = True
        Me.chkSeReciveSinFactura.Location = New System.Drawing.Point(473, 81)
        Me.chkSeReciveSinFactura.Name = "chkSeReciveSinFactura"
        Me.chkSeReciveSinFactura.Size = New System.Drawing.Size(131, 17)
        Me.chkSeReciveSinFactura.TabIndex = 13
        Me.chkSeReciveSinFactura.Text = "Se Recibe sin Factura"
        Me.chkSeReciveSinFactura.UseVisualStyleBackColor = True
        Me.chkSeReciveSinFactura.Visible = False
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(353, 8)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(92, 20)
        Me.dtpFecha.TabIndex = 63
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
        'chkSeManejaProLotes
        '
        Me.chkSeManejaProLotes.AutoSize = True
        Me.chkSeManejaProLotes.Location = New System.Drawing.Point(616, 57)
        Me.chkSeManejaProLotes.Name = "chkSeManejaProLotes"
        Me.chkSeManejaProLotes.Size = New System.Drawing.Size(124, 17)
        Me.chkSeManejaProLotes.TabIndex = 14
        Me.chkSeManejaProLotes.Text = "Se Maneja por Lotes"
        Me.chkSeManejaProLotes.UseVisualStyleBackColor = True
        Me.chkSeManejaProLotes.Visible = False
        '
        'txtCaducidad
        '
        Me.txtCaducidad.Location = New System.Drawing.Point(677, 85)
        Me.txtCaducidad.Name = "txtCaducidad"
        Me.txtCaducidad.Size = New System.Drawing.Size(65, 20)
        Me.txtCaducidad.TabIndex = 10
        Me.txtCaducidad.Text = "0"
        Me.txtCaducidad.Visible = False
        '
        'lblestatus
        '
        Me.lblestatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblestatus.BackColor = System.Drawing.Color.Navy
        Me.lblestatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblestatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblestatus.ForeColor = System.Drawing.Color.White
        Me.lblestatus.Location = New System.Drawing.Point(646, 4)
        Me.lblestatus.Name = "lblestatus"
        Me.lblestatus.Size = New System.Drawing.Size(121, 24)
        Me.lblestatus.TabIndex = 64
        Me.lblestatus.Text = "ESTATUS"
        Me.lblestatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkCaduca
        '
        Me.chkCaduca.AutoSize = True
        Me.chkCaduca.Location = New System.Drawing.Point(616, 78)
        Me.chkCaduca.Name = "chkCaduca"
        Me.chkCaduca.Size = New System.Drawing.Size(107, 17)
        Me.chkCaduca.TabIndex = 0
        Me.chkCaduca.Text = "Tiene Caducidad"
        Me.chkCaduca.UseVisualStyleBackColor = True
        Me.chkCaduca.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(616, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Dias Max.:"
        Me.Label8.Visible = False
        '
        'cmbUnidadesMedida
        '
        Me.cmbUnidadesMedida.FormattingEnabled = True
        Me.cmbUnidadesMedida.Location = New System.Drawing.Point(117, 134)
        Me.cmbUnidadesMedida.Name = "cmbUnidadesMedida"
        Me.cmbUnidadesMedida.Size = New System.Drawing.Size(150, 21)
        Me.cmbUnidadesMedida.TabIndex = 54
        '
        'cmbFamilia
        '
        Me.cmbFamilia.FormattingEnabled = True
        Me.cmbFamilia.Location = New System.Drawing.Point(117, 107)
        Me.cmbFamilia.Name = "cmbFamilia"
        Me.cmbFamilia.Size = New System.Drawing.Size(328, 21)
        Me.cmbFamilia.TabIndex = 50
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(117, 34)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDescripcion.Size = New System.Drawing.Size(328, 41)
        Me.txtDescripcion.TabIndex = 46
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(117, 8)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 45
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 245)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Piezas:"
        Me.Label9.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 139)
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
        Me.mtb.Size = New System.Drawing.Size(50, 496)
        Me.mtb.TabIndex = 0
        '
        'dgvIngredientes
        '
        Me.dgvIngredientes.AllowUserToAddRows = False
        Me.dgvIngredientes.AllowUserToDeleteRows = False
        Me.dgvIngredientes.AllowUserToResizeRows = False
        Me.dgvIngredientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvIngredientes.AutoGenerateColumns = False
        Me.dgvIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIngredientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmIngrediente, Me.clmPrjIngrediente})
        Me.dgvIngredientes.DataSource = Me.ProductosPaqueteC
        Me.dgvIngredientes.Location = New System.Drawing.Point(6, 6)
        Me.dgvIngredientes.Name = "dgvIngredientes"
        Me.dgvIngredientes.RowHeadersVisible = False
        Me.dgvIngredientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvIngredientes.Size = New System.Drawing.Size(756, 215)
        Me.dgvIngredientes.TabIndex = 0
        '
        'clmIngrediente
        '
        Me.clmIngrediente.DataPropertyName = "IdIngrediente"
        Me.clmIngrediente.HeaderText = "Ingrediente"
        Me.clmIngrediente.Name = "clmIngrediente"
        Me.clmIngrediente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clmIngrediente.Width = 300
        '
        'clmPrjIngrediente
        '
        Me.clmPrjIngrediente.DataPropertyName = "Cantidad"
        Me.clmPrjIngrediente.HeaderText = "Porcentaje"
        Me.clmPrjIngrediente.Name = "clmPrjIngrediente"
        '
        'ProductosPaqueteC
        '
        Me.ProductosPaqueteC.AllowEdit = True
        Me.ProductosPaqueteC.AllowNew = True
        Me.ProductosPaqueteC.AllowRemove = True
        Me.ProductosPaqueteC.MaximoElementosSeleccionados = 1
        Me.ProductosPaqueteC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.ProductosPaqueteC.MostrarAlertas = False
        Me.ProductosPaqueteC.Name = ""
        Me.ProductosPaqueteC.RaiseListChangedEvents = True
        Me.ProductosPaqueteC.Transaction = Nothing
        '
        'dgvCIR
        '
        Me.dgvCIR.AllowUserToAddRows = False
        Me.dgvCIR.AllowUserToDeleteRows = False
        Me.dgvCIR.AllowUserToResizeRows = False
        Me.dgvCIR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCIR.AutoGenerateColumns = False
        Me.dgvCIR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCIR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CostoIndirectoDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn})
        Me.dgvCIR.DataSource = Me.ProdCostoIndirectoC
        Me.dgvCIR.Location = New System.Drawing.Point(6, 6)
        Me.dgvCIR.Name = "dgvCIR"
        Me.dgvCIR.RowHeadersVisible = False
        Me.dgvCIR.Size = New System.Drawing.Size(759, 202)
        Me.dgvCIR.TabIndex = 1
        '
        'CostoIndirectoDataGridViewTextBoxColumn
        '
        Me.CostoIndirectoDataGridViewTextBoxColumn.DataPropertyName = "CostoIndirecto"
        Me.CostoIndirectoDataGridViewTextBoxColumn.HeaderText = "Costo Indirecto"
        Me.CostoIndirectoDataGridViewTextBoxColumn.Name = "CostoIndirectoDataGridViewTextBoxColumn"
        Me.CostoIndirectoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CostoIndirectoDataGridViewTextBoxColumn.Width = 300
        '
        'ImporteDataGridViewTextBoxColumn
        '
        Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "Importe"
        DataGridViewCellStyle1.Format = "C2"
        Me.ImporteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
        '
        'ProdCostoIndirectoC
        '
        Me.ProdCostoIndirectoC.AllowEdit = True
        Me.ProdCostoIndirectoC.AllowNew = True
        Me.ProdCostoIndirectoC.AllowRemove = True
        Me.ProdCostoIndirectoC.Name = ""
        Me.ProdCostoIndirectoC.RaiseListChangedEvents = True
        '
        'frmABCProducosComprasGen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 496)
        Me.Controls.Add(Me.Pan)
        Me.Controls.Add(Me.lblTema)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.tbcPaquetes)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmABCProducosComprasGen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catálogo de Productos"
        Me.tbcPaquetes.ResumeLayout(False)
        Me.tpArmadoPaquetes.ResumeLayout(False)
        Me.tpArmadoPaquetes.PerformLayout()
        Me.GpoPaquete.ResumeLayout(False)
        Me.GpoPaquete.PerformLayout()
        Me.tpCostoIndirecto.ResumeLayout(False)
        Me.tpCostoIndirecto.PerformLayout()
        Me.tpNutrientes.ResumeLayout(False)
        CType(Me.dgvNutrientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpHistorial.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pan.ResumeLayout(False)
        Me.Pan.PerformLayout()
        Me.GpoIngrediente.ResumeLayout(False)
        Me.GpoIngrediente.PerformLayout()
        CType(Me.dgvIngredientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCIR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents tbcPaquetes As System.Windows.Forms.TabControl
    Friend WithEvents tpArmadoPaquetes As System.Windows.Forms.TabPage
    Friend WithEvents dgvIngredientes As System.Windows.Forms.DataGridView
    Friend WithEvents tpCostoIndirecto As System.Windows.Forms.TabPage
    Friend WithEvents dgvCIR As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
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
    Friend WithEvents cmbTipoProd As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDescCorta As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GpoPaquete As System.Windows.Forms.GroupBox
    Friend WithEvents rbEsMezcla As System.Windows.Forms.RadioButton
    Friend WithEvents rbProductoGeneral As System.Windows.Forms.RadioButton
    Friend WithEvents lblestatus As System.Windows.Forms.Label
    Friend WithEvents cmbPresentacion As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMarcas As System.Windows.Forms.ComboBox
    Friend WithEvents cmbUnidadesMedida As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSubFamilia As System.Windows.Forms.ComboBox
    Friend WithEvents cmbFamilia As System.Windows.Forms.ComboBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProductosPaqueteC As ClasesNegocio.ProductosPaqueteCollection
    Friend WithEvents ProdCostoIndirectoC As ClasesNegocio.ProdCostoIndirectoCollection
    Friend WithEvents CostoIndirectoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtPiezas As System.Windows.Forms.TextBox
    Friend WithEvents txtCaducidad As System.Windows.Forms.TextBox
    Friend WithEvents chkAplicaIva As System.Windows.Forms.CheckBox
    Friend WithEvents tpNutrientes As System.Windows.Forms.TabPage
    Friend WithEvents dgvNutrientes As System.Windows.Forms.DataGridView
    Friend WithEvents clmNutriente As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents clmPrjNutriente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIngrediente As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents clmPrjIngrediente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkFormula As System.Windows.Forms.CheckBox
    Friend WithEvents chkIngrediente As System.Windows.Forms.CheckBox
    Friend WithEvents tpHistorial As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents clmProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCostoUnitario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtUltimoCosto As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtCantidadUltimaCompra As System.Windows.Forms.TextBox
    Friend WithEvents txtImportteUltimaCompra As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaUltimaCompra As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    'Friend WithEvents ProdCollection As ClasesNegocio.ProductosCollectionClass

End Class
