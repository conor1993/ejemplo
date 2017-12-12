<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CatABCPuntosDeVenta
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
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.chkTerceros = New System.Windows.Forms.CheckBox
        Me.gbTipoProducto = New System.Windows.Forms.GroupBox
        Me.rbtVenta = New System.Windows.Forms.RadioButton
        Me.rbtCongelado = New System.Windows.Forms.RadioButton
        Me.rbtFresco = New System.Windows.Forms.RadioButton
        Me.rbtGeneral = New System.Windows.Forms.RadioButton
        Me.btnCuentaContable = New System.Windows.Forms.Button
        Me.txtCuentaContable = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.CmbTipoAlmacen = New System.Windows.Forms.ComboBox
        Me.TipoAlmacenC = New ClasesNegocio.TipoAlmacenCollectionClass
        Me.Label9 = New System.Windows.Forms.Label
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.CmbTerceros = New System.Windows.Forms.ComboBox
        Me.TxtLetra = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.CmbPlaza = New System.Windows.Forms.ComboBox
        Me.PlazaC = New ClasesNegocio.PlazaCollectionClass
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtDescripcionCorta = New System.Windows.Forms.TextBox
        Me.TxtDescripcion = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtCodigo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.AlmacenAlmacenesC = New ClasesNegocio.AlmacenCollectionClass
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtFiltro = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dgvFamiliasenAlmacen = New System.Windows.Forms.DataGridView
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.clmFamiliaAlmacen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCodigoAlmacen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgvFamilias = New System.Windows.Forms.DataGridView
        Me.clmChecar = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.clmFamilia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label10 = New System.Windows.Forms.Label
        Me.DataGrid = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AlmacenTodosC = New ClasesNegocio.AlmacenCollectionClass
        Me.dgvFamilasEspejo = New System.Windows.Forms.DataGridView
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.clmDescripcionFamiliaEspejo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCodigoFamiliaEspejo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1.SuspendLayout()
        Me.gbTipoProducto.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvFamiliasenAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvFamilias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFamilasEspejo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mtb
        '
        Me.mtb.ButtonSize = New System.Drawing.Size(50, 50)
        Me.mtb.Dock = System.Windows.Forms.DockStyle.None
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
        Me.mtb.Location = New System.Drawing.Point(3, 28)
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
        Me.mtb.Size = New System.Drawing.Size(50, 578)
        Me.mtb.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.chkTerceros)
        Me.Panel1.Controls.Add(Me.gbTipoProducto)
        Me.Panel1.Controls.Add(Me.btnCuentaContable)
        Me.Panel1.Controls.Add(Me.txtCuentaContable)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lblEstatus)
        Me.Panel1.Controls.Add(Me.CmbTipoAlmacen)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.DtpFecha)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.CmbTerceros)
        Me.Panel1.Controls.Add(Me.TxtLetra)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.CmbPlaza)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TxtDescripcionCorta)
        Me.Panel1.Controls.Add(Me.TxtDescripcion)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtCodigo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(56, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(671, 192)
        Me.Panel1.TabIndex = 2
        '
        'chkTerceros
        '
        Me.chkTerceros.AutoSize = True
        Me.chkTerceros.Location = New System.Drawing.Point(17, 136)
        Me.chkTerceros.Name = "chkTerceros"
        Me.chkTerceros.Size = New System.Drawing.Size(68, 17)
        Me.chkTerceros.TabIndex = 21
        Me.chkTerceros.Text = "Terceros"
        Me.chkTerceros.UseVisualStyleBackColor = True
        '
        'gbTipoProducto
        '
        Me.gbTipoProducto.Controls.Add(Me.rbtVenta)
        Me.gbTipoProducto.Controls.Add(Me.rbtCongelado)
        Me.gbTipoProducto.Controls.Add(Me.rbtFresco)
        Me.gbTipoProducto.Controls.Add(Me.rbtGeneral)
        Me.gbTipoProducto.Location = New System.Drawing.Point(409, 51)
        Me.gbTipoProducto.Name = "gbTipoProducto"
        Me.gbTipoProducto.Size = New System.Drawing.Size(96, 104)
        Me.gbTipoProducto.TabIndex = 17
        Me.gbTipoProducto.TabStop = False
        Me.gbTipoProducto.Text = "Tipo Producto"
        Me.gbTipoProducto.Visible = False
        '
        'rbtVenta
        '
        Me.rbtVenta.AutoSize = True
        Me.rbtVenta.Location = New System.Drawing.Point(6, 85)
        Me.rbtVenta.Name = "rbtVenta"
        Me.rbtVenta.Size = New System.Drawing.Size(53, 17)
        Me.rbtVenta.TabIndex = 3
        Me.rbtVenta.Text = "Venta"
        Me.rbtVenta.UseVisualStyleBackColor = True
        '
        'rbtCongelado
        '
        Me.rbtCongelado.AutoSize = True
        Me.rbtCongelado.Location = New System.Drawing.Point(6, 62)
        Me.rbtCongelado.Name = "rbtCongelado"
        Me.rbtCongelado.Size = New System.Drawing.Size(76, 17)
        Me.rbtCongelado.TabIndex = 2
        Me.rbtCongelado.Text = "Congelado"
        Me.rbtCongelado.UseVisualStyleBackColor = True
        '
        'rbtFresco
        '
        Me.rbtFresco.AutoSize = True
        Me.rbtFresco.Location = New System.Drawing.Point(6, 39)
        Me.rbtFresco.Name = "rbtFresco"
        Me.rbtFresco.Size = New System.Drawing.Size(57, 17)
        Me.rbtFresco.TabIndex = 1
        Me.rbtFresco.Text = "Fresco"
        Me.rbtFresco.UseVisualStyleBackColor = True
        '
        'rbtGeneral
        '
        Me.rbtGeneral.AutoSize = True
        Me.rbtGeneral.Checked = True
        Me.rbtGeneral.Location = New System.Drawing.Point(6, 16)
        Me.rbtGeneral.Name = "rbtGeneral"
        Me.rbtGeneral.Size = New System.Drawing.Size(62, 17)
        Me.rbtGeneral.TabIndex = 0
        Me.rbtGeneral.TabStop = True
        Me.rbtGeneral.Text = "General"
        Me.rbtGeneral.UseVisualStyleBackColor = True
        '
        'btnCuentaContable
        '
        Me.btnCuentaContable.Location = New System.Drawing.Point(511, 158)
        Me.btnCuentaContable.Name = "btnCuentaContable"
        Me.btnCuentaContable.Size = New System.Drawing.Size(27, 23)
        Me.btnCuentaContable.TabIndex = 20
        Me.btnCuentaContable.Text = "..."
        Me.btnCuentaContable.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCuentaContable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCuentaContable.UseVisualStyleBackColor = True
        '
        'txtCuentaContable
        '
        Me.txtCuentaContable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuentaContable.Enabled = False
        Me.txtCuentaContable.Location = New System.Drawing.Point(121, 159)
        Me.txtCuentaContable.Name = "txtCuentaContable"
        Me.txtCuentaContable.ReadOnly = True
        Me.txtCuentaContable.Size = New System.Drawing.Size(384, 20)
        Me.txtCuentaContable.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Cuenta Contable:"
        '
        'lblEstatus
        '
        Me.lblEstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(569, 3)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(99, 21)
        Me.lblEstatus.TabIndex = 4
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbTipoAlmacen
        '
        Me.CmbTipoAlmacen.DataSource = Me.TipoAlmacenC
        Me.CmbTipoAlmacen.DisplayMember = "Descripcion"
        Me.CmbTipoAlmacen.FormattingEnabled = True
        Me.CmbTipoAlmacen.Location = New System.Drawing.Point(121, 108)
        Me.CmbTipoAlmacen.Name = "CmbTipoAlmacen"
        Me.CmbTipoAlmacen.Size = New System.Drawing.Size(282, 21)
        Me.CmbTipoAlmacen.TabIndex = 14
        Me.CmbTipoAlmacen.ValueMember = "Codigo"
        Me.CmbTipoAlmacen.Visible = False
        '
        'TipoAlmacenC
        '
        Me.TipoAlmacenC.AllowEdit = True
        Me.TipoAlmacenC.AllowNew = True
        Me.TipoAlmacenC.AllowRemove = True
        Me.TipoAlmacenC.Name = ""
        Me.TipoAlmacenC.RaiseListChangedEvents = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Tipo Almacén:"
        Me.Label9.Visible = False
        '
        'DtpFecha
        '
        Me.DtpFecha.Enabled = False
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(430, 2)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(92, 20)
        Me.DtpFecha.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(348, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Fecha de Alta:"
        '
        'CmbTerceros
        '
        Me.CmbTerceros.FormattingEnabled = True
        Me.CmbTerceros.Location = New System.Drawing.Point(121, 134)
        Me.CmbTerceros.Name = "CmbTerceros"
        Me.CmbTerceros.Size = New System.Drawing.Size(282, 21)
        Me.CmbTerceros.TabIndex = 16
        '
        'TxtLetra
        '
        Me.TxtLetra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLetra.Location = New System.Drawing.Point(351, 55)
        Me.TxtLetra.MaximumSize = New System.Drawing.Size(80, 20)
        Me.TxtLetra.MaxLength = 1
        Me.TxtLetra.MinimumSize = New System.Drawing.Size(20, 20)
        Me.TxtLetra.Name = "TxtLetra"
        Me.TxtLetra.Size = New System.Drawing.Size(52, 20)
        Me.TxtLetra.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(311, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Letra:"
        '
        'CmbPlaza
        '
        Me.CmbPlaza.DataSource = Me.PlazaC
        Me.CmbPlaza.DisplayMember = "Descripcion"
        Me.CmbPlaza.FormattingEnabled = True
        Me.CmbPlaza.Location = New System.Drawing.Point(121, 81)
        Me.CmbPlaza.Name = "CmbPlaza"
        Me.CmbPlaza.Size = New System.Drawing.Size(282, 21)
        Me.CmbPlaza.TabIndex = 12
        Me.CmbPlaza.ValueMember = "Codigo"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Plaza:"
        '
        'TxtDescripcionCorta
        '
        Me.TxtDescripcionCorta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescripcionCorta.Location = New System.Drawing.Point(121, 55)
        Me.TxtDescripcionCorta.MaxLength = 15
        Me.TxtDescripcionCorta.Name = "TxtDescripcionCorta"
        Me.TxtDescripcionCorta.Size = New System.Drawing.Size(184, 20)
        Me.TxtDescripcionCorta.TabIndex = 8
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescripcion.Location = New System.Drawing.Point(121, 29)
        Me.TxtDescripcion.MaxLength = 50
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(401, 20)
        Me.TxtDescripcion.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Descripción Corta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Descripción:"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCodigo.Location = New System.Drawing.Point(121, 3)
        Me.TxtCodigo.MaximumSize = New System.Drawing.Size(120, 20)
        Me.TxtCodigo.MinimumSize = New System.Drawing.Size(60, 20)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.ReadOnly = True
        Me.TxtCodigo.Size = New System.Drawing.Size(79, 20)
        Me.TxtCodigo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        '
        'AlmacenAlmacenesC
        '
        Me.AlmacenAlmacenesC.AllowEdit = True
        Me.AlmacenAlmacenesC.AllowNew = True
        Me.AlmacenAlmacenesC.AllowRemove = True
        Me.AlmacenAlmacenesC.Name = ""
        Me.AlmacenAlmacenesC.RaiseListChangedEvents = True
        Me.AlmacenAlmacenesC.Tipo = ClasesNegocio.AlmacenEnum.ALMACEN
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(0, 0)
        Me.Label17.MaximumSize = New System.Drawing.Size(1600, 900)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(743, 29)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "CATÁLOGO DE PUNTOS DE VENTA"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.dgvFamilasEspejo)
        Me.GroupBox3.Controls.Add(Me.txtFiltro)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.DataGrid)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(60, 230)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(649, 281)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Almacenes Registrados"
        Me.GroupBox3.Visible = False
        '
        'txtFiltro
        '
        Me.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFiltro.Location = New System.Drawing.Point(111, 25)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(282, 22)
        Me.txtFiltro.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvFamiliasenAlmacen)
        Me.GroupBox2.Location = New System.Drawing.Point(296, 267)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(290, 281)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Familias en Almacen"
        '
        'dgvFamiliasenAlmacen
        '
        Me.dgvFamiliasenAlmacen.AllowUserToAddRows = False
        Me.dgvFamiliasenAlmacen.AllowUserToDeleteRows = False
        Me.dgvFamiliasenAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFamiliasenAlmacen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1, Me.clmFamiliaAlmacen, Me.clmCodigoAlmacen})
        Me.dgvFamiliasenAlmacen.Enabled = False
        Me.dgvFamiliasenAlmacen.Location = New System.Drawing.Point(10, 23)
        Me.dgvFamiliasenAlmacen.Name = "dgvFamiliasenAlmacen"
        Me.dgvFamiliasenAlmacen.RowHeadersVisible = False
        Me.dgvFamiliasenAlmacen.Size = New System.Drawing.Size(264, 247)
        Me.dgvFamiliasenAlmacen.TabIndex = 0
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = " "
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 40
        '
        'clmFamiliaAlmacen
        '
        Me.clmFamiliaAlmacen.HeaderText = "Familia"
        Me.clmFamiliaAlmacen.Name = "clmFamiliaAlmacen"
        Me.clmFamiliaAlmacen.Width = 200
        '
        'clmCodigoAlmacen
        '
        Me.clmCodigoAlmacen.HeaderText = "Codigo"
        Me.clmCodigoAlmacen.Name = "clmCodigoAlmacen"
        Me.clmCodigoAlmacen.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvFamilias)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 267)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(290, 281)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Familias"
        '
        'dgvFamilias
        '
        Me.dgvFamilias.AllowUserToAddRows = False
        Me.dgvFamilias.AllowUserToDeleteRows = False
        Me.dgvFamilias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFamilias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmChecar, Me.clmFamilia, Me.clmCodigo})
        Me.dgvFamilias.Enabled = False
        Me.dgvFamilias.Location = New System.Drawing.Point(10, 23)
        Me.dgvFamilias.Name = "dgvFamilias"
        Me.dgvFamilias.RowHeadersVisible = False
        Me.dgvFamilias.Size = New System.Drawing.Size(264, 247)
        Me.dgvFamilias.TabIndex = 0
        '
        'clmChecar
        '
        Me.clmChecar.HeaderText = " "
        Me.clmChecar.Name = "clmChecar"
        Me.clmChecar.Width = 40
        '
        'clmFamilia
        '
        Me.clmFamilia.HeaderText = "Familia"
        Me.clmFamilia.Name = "clmFamilia"
        Me.clmFamilia.Width = 200
        '
        'clmCodigo
        '
        Me.clmCodigo.HeaderText = "Codigo"
        Me.clmCodigo.Name = "clmCodigo"
        Me.clmCodigo.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Descripción:"
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.AllowUserToResizeRows = False
        Me.DataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGrid.AutoGenerateColumns = False
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn3})
        Me.DataGrid.DataSource = Me.AlmacenTodosC
        Me.DataGrid.Location = New System.Drawing.Point(6, 47)
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(637, 226)
        Me.DataGrid.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Codigo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 70
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 200
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DescripcionCorta"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripción Corta"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 170
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Letras"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Letras"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 50
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Plaza"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Plaza"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 200
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TipoAlmacen"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Tipo de Almacen"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 200
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "FechaAlta"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Fecha de Alta"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Estatus"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Estatus"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'AlmacenTodosC
        '
        Me.AlmacenTodosC.AllowEdit = True
        Me.AlmacenTodosC.AllowNew = True
        Me.AlmacenTodosC.AllowRemove = True
        Me.AlmacenTodosC.Name = ""
        Me.AlmacenTodosC.RaiseListChangedEvents = True
        Me.AlmacenTodosC.Tipo = ClasesNegocio.AlmacenEnum.TODOS
        '
        'dgvFamilasEspejo
        '
        Me.dgvFamilasEspejo.AllowUserToAddRows = False
        Me.dgvFamilasEspejo.AllowUserToDeleteRows = False
        Me.dgvFamilasEspejo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFamilasEspejo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn2, Me.clmDescripcionFamiliaEspejo, Me.clmCodigoFamiliaEspejo})
        Me.dgvFamilasEspejo.Enabled = False
        Me.dgvFamilasEspejo.Location = New System.Drawing.Point(411, 142)
        Me.dgvFamilasEspejo.Name = "dgvFamilasEspejo"
        Me.dgvFamilasEspejo.RowHeadersVisible = False
        Me.dgvFamilasEspejo.Size = New System.Drawing.Size(264, 247)
        Me.dgvFamilasEspejo.TabIndex = 5
        Me.dgvFamilasEspejo.Visible = False
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.HeaderText = " "
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Width = 40
        '
        'clmDescripcionFamiliaEspejo
        '
        Me.clmDescripcionFamiliaEspejo.HeaderText = "Familia"
        Me.clmDescripcionFamiliaEspejo.Name = "clmDescripcionFamiliaEspejo"
        Me.clmDescripcionFamiliaEspejo.Width = 200
        '
        'clmCodigoFamiliaEspejo
        '
        Me.clmCodigoFamiliaEspejo.HeaderText = "Codigo"
        Me.clmCodigoFamiliaEspejo.Name = "clmCodigoFamiliaEspejo"
        Me.clmCodigoFamiliaEspejo.Visible = False
        '
        'CatABCPuntosDeVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 523)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CatABCPuntosDeVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Puntos de Venta"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gbTipoProducto.ResumeLayout(False)
        Me.gbTipoProducto.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvFamiliasenAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvFamilias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFamilasEspejo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TxtLetra As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CmbPlaza As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtDescripcionCorta As System.Windows.Forms.TextBox
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents CmbTerceros As System.Windows.Forms.ComboBox
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    'Friend WithEvents AlmacenCollectionClass1 As ClasesNegocio.AlmacenCollectionClass
    Friend WithEvents CmbTipoAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    'Friend WithEvents AlmacenCollectionClass2 As ClasesNegocio.AlmacenCollectionClass
    Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionCortaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlmacenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoAlmacenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LetrasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlazaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaAltaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents AlmacenTodosC As ClasesNegocio.AlmacenCollectionClass
    Friend WithEvents AlmacenAlmacenesC As ClasesNegocio.AlmacenCollectionClass
    Friend WithEvents TipoAlmacenC As ClasesNegocio.TipoAlmacenCollectionClass
    Friend WithEvents PlazaC As ClasesNegocio.PlazaCollectionClass
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCuentaContable As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCuentaContable As System.Windows.Forms.Button
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents gbTipoProducto As System.Windows.Forms.GroupBox
    Friend WithEvents rbtCongelado As System.Windows.Forms.RadioButton
    Friend WithEvents rbtFresco As System.Windows.Forms.RadioButton
    Friend WithEvents rbtGeneral As System.Windows.Forms.RadioButton
    Friend WithEvents rbtVenta As System.Windows.Forms.RadioButton
    Friend WithEvents chkTerceros As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvFamilias As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvFamiliasenAlmacen As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents clmFamiliaAlmacen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCodigoAlmacen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmChecar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents clmFamilia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvFamilasEspejo As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents clmDescripcionFamiliaEspejo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCodigoFamiliaEspejo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
