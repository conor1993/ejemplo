<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKardexProduccion
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtExistenciaInicialKgrs = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtExistenciaInicialPzas = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtCostoInicial = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DgvDetalles = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtExistenciaPzas = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtTotalSalidasKgrs = New System.Windows.Forms.TextBox
        Me.txtTotalEntradasKgrs = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtExistenciaKgrs = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtTotalSalidasPzas = New System.Windows.Forms.TextBox
        Me.txtTotalEntradasPzas = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.CmbAño = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbAlmacen = New System.Windows.Forms.ComboBox
        Me.AlmacenC = New ClasesNegocio.AlmacenCollectionClass
        Me.cmbMes = New System.Windows.Forms.ComboBox
        Me.CmbProducto = New System.Windows.Forms.ComboBox
        Me.ProductosCol = New ClasesNegocio.ProductosCollectionsClass
        Me.Label6 = New System.Windows.Forms.Label
        Me.clmFechaMov = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFolioMvto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmAlmacen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCantidadKgrs = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCantidadPzas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmExistenciaPzas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmExistenciaKgrs = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCosto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCostoProm = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmTipoMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgvDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Label1.Size = New System.Drawing.Size(883, 29)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "KARDEX DE PRODUCTOS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mtb
        '
        Me.mtb.ButtonSize = New System.Drawing.Size(50, 50)
        Me.mtb.Dock = System.Windows.Forms.DockStyle.Left
        Me.mtb.DropDownArrows = True
        Me.mtb.HabilitarBorrar = True
        Me.mtb.HabilitarBuscar = True
        Me.mtb.HabilitarCancelar = True
        Me.mtb.HabilitarEditar = False
        Me.mtb.HabilitarGuardar = True
        Me.mtb.HabilitarImprimir = True
        Me.mtb.HabilitarLimpiar = True
        Me.mtb.HabilitarNuevo = True
        Me.mtb.HabilitarSalir = True
        Me.mtb.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32
        Me.mtb.Location = New System.Drawing.Point(0, 0)
        Me.mtb.MostrarBorrar = False
        Me.mtb.MostrarBuscar = True
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = False
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 472)
        Me.mtb.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.CmbAño)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DtpFecha)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmbAlmacen)
        Me.GroupBox1.Controls.Add(Me.cmbMes)
        Me.GroupBox1.Controls.Add(Me.CmbProducto)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(53, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(868, 430)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.txtExistenciaInicialKgrs)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.txtExistenciaInicialPzas)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.txtCostoInicial)
        Me.GroupBox4.Location = New System.Drawing.Point(13, 131)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(416, 82)
        Me.GroupBox4.TabIndex = 28
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Cantidades Iniciales"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 52)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(118, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Existencia Inicial Kgrs..:"
        '
        'txtExistenciaInicialKgrs
        '
        Me.txtExistenciaInicialKgrs.Location = New System.Drawing.Point(130, 49)
        Me.txtExistenciaInicialKgrs.Name = "txtExistenciaInicialKgrs"
        Me.txtExistenciaInicialKgrs.ReadOnly = True
        Me.txtExistenciaInicialKgrs.Size = New System.Drawing.Size(93, 20)
        Me.txtExistenciaInicialKgrs.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Existencia Inicial Pzas.:"
        '
        'txtExistenciaInicialPzas
        '
        Me.txtExistenciaInicialPzas.Location = New System.Drawing.Point(130, 22)
        Me.txtExistenciaInicialPzas.Name = "txtExistenciaInicialPzas"
        Me.txtExistenciaInicialPzas.ReadOnly = True
        Me.txtExistenciaInicialPzas.Size = New System.Drawing.Size(93, 20)
        Me.txtExistenciaInicialPzas.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(228, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Costo Inicial:"
        '
        'txtCostoInicial
        '
        Me.txtCostoInicial.Location = New System.Drawing.Point(301, 22)
        Me.txtCostoInicial.Name = "txtCostoInicial"
        Me.txtCostoInicial.ReadOnly = True
        Me.txtCostoInicial.Size = New System.Drawing.Size(93, 20)
        Me.txtCostoInicial.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.DgvDetalles)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 219)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(855, 205)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalle de Movimientos"
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
        Me.DgvDetalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmFechaMov, Me.clmFolioMvto, Me.clmAlmacen, Me.clmMovimiento, Me.clmCantidadKgrs, Me.clmCantidadPzas, Me.clmExistenciaPzas, Me.clmExistenciaKgrs, Me.clmCosto, Me.clmCostoProm, Me.clmTipoMovimiento})
        Me.DgvDetalles.Location = New System.Drawing.Point(6, 19)
        Me.DgvDetalles.Name = "DgvDetalles"
        Me.DgvDetalles.ReadOnly = True
        Me.DgvDetalles.RowHeadersVisible = False
        Me.DgvDetalles.Size = New System.Drawing.Size(843, 180)
        Me.DgvDetalles.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.txtExistenciaPzas)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtTotalSalidasKgrs)
        Me.GroupBox2.Controls.Add(Me.txtTotalEntradasKgrs)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtExistenciaKgrs)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtTotalSalidasPzas)
        Me.GroupBox2.Controls.Add(Me.txtTotalEntradasPzas)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(477, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(385, 194)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Totales"
        '
        'txtExistenciaPzas
        '
        Me.txtExistenciaPzas.Location = New System.Drawing.Point(155, 134)
        Me.txtExistenciaPzas.Name = "txtExistenciaPzas"
        Me.txtExistenciaPzas.ReadOnly = True
        Me.txtExistenciaPzas.Size = New System.Drawing.Size(118, 20)
        Me.txtExistenciaPzas.TabIndex = 16
        Me.txtExistenciaPzas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 137)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 13)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Existencia Pzas.:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Total de Salidas Kgrs.:"
        '
        'txtTotalSalidasKgrs
        '
        Me.txtTotalSalidasKgrs.Location = New System.Drawing.Point(155, 109)
        Me.txtTotalSalidasKgrs.Name = "txtTotalSalidasKgrs"
        Me.txtTotalSalidasKgrs.ReadOnly = True
        Me.txtTotalSalidasKgrs.Size = New System.Drawing.Size(118, 20)
        Me.txtTotalSalidasKgrs.TabIndex = 13
        Me.txtTotalSalidasKgrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalEntradasKgrs
        '
        Me.txtTotalEntradasKgrs.Location = New System.Drawing.Point(155, 54)
        Me.txtTotalEntradasKgrs.Name = "txtTotalEntradasKgrs"
        Me.txtTotalEntradasKgrs.ReadOnly = True
        Me.txtTotalEntradasKgrs.Size = New System.Drawing.Size(118, 20)
        Me.txtTotalEntradasKgrs.TabIndex = 12
        Me.txtTotalEntradasKgrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Total de Entradas Kgrs.:"
        '
        'txtExistenciaKgrs
        '
        Me.txtExistenciaKgrs.Location = New System.Drawing.Point(155, 160)
        Me.txtExistenciaKgrs.Name = "txtExistenciaKgrs"
        Me.txtExistenciaKgrs.ReadOnly = True
        Me.txtExistenciaKgrs.Size = New System.Drawing.Size(118, 20)
        Me.txtExistenciaKgrs.TabIndex = 10
        Me.txtExistenciaKgrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 163)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Existencia Kgrs.:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 85)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Total de Salidas Pzas.:"
        '
        'txtTotalSalidasPzas
        '
        Me.txtTotalSalidasPzas.Location = New System.Drawing.Point(155, 82)
        Me.txtTotalSalidasPzas.Name = "txtTotalSalidasPzas"
        Me.txtTotalSalidasPzas.ReadOnly = True
        Me.txtTotalSalidasPzas.Size = New System.Drawing.Size(118, 20)
        Me.txtTotalSalidasPzas.TabIndex = 6
        Me.txtTotalSalidasPzas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalEntradasPzas
        '
        Me.txtTotalEntradasPzas.Location = New System.Drawing.Point(155, 27)
        Me.txtTotalEntradasPzas.Name = "txtTotalEntradasPzas"
        Me.txtTotalEntradasPzas.ReadOnly = True
        Me.txtTotalEntradasPzas.Size = New System.Drawing.Size(118, 20)
        Me.txtTotalEntradasPzas.TabIndex = 5
        Me.txtTotalEntradasPzas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Total de Entradas Pzas.:"
        '
        'CmbAño
        '
        Me.CmbAño.FormattingEnabled = True
        Me.CmbAño.Location = New System.Drawing.Point(72, 104)
        Me.CmbAño.Name = "CmbAño"
        Me.CmbAño.Size = New System.Drawing.Size(133, 21)
        Me.CmbAño.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Año Inicial:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Almacén:"
        '
        'DtpFecha
        '
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpFecha.Location = New System.Drawing.Point(289, 77)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(93, 20)
        Me.DtpFecha.TabIndex = 22
        Me.DtpFecha.Value = New Date(2008, 4, 8, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Producto:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(211, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Ultima Fecha:"
        '
        'cmbAlmacen
        '
        Me.cmbAlmacen.DataSource = Me.AlmacenC
        Me.cmbAlmacen.DisplayMember = "Descripcion"
        Me.cmbAlmacen.FormattingEnabled = True
        Me.cmbAlmacen.Location = New System.Drawing.Point(70, 46)
        Me.cmbAlmacen.Name = "cmbAlmacen"
        Me.cmbAlmacen.Size = New System.Drawing.Size(359, 21)
        Me.cmbAlmacen.TabIndex = 13
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
        'cmbMes
        '
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Location = New System.Drawing.Point(72, 77)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(133, 21)
        Me.cmbMes.TabIndex = 20
        '
        'CmbProducto
        '
        Me.CmbProducto.DataSource = Me.ProductosCol
        Me.CmbProducto.DisplayMember = "Descripcion"
        Me.CmbProducto.FormattingEnabled = True
        Me.CmbProducto.Location = New System.Drawing.Point(70, 19)
        Me.CmbProducto.Name = "CmbProducto"
        Me.CmbProducto.Size = New System.Drawing.Size(359, 21)
        Me.CmbProducto.TabIndex = 27
        Me.CmbProducto.ValueMember = "IdProducto"
        '
        'ProductosCol
        '
        Me.ProductosCol.AllowEdit = True
        Me.ProductosCol.AllowNew = True
        Me.ProductosCol.AllowRemove = True
        Me.ProductosCol.Name = ""
        Me.ProductosCol.RaiseListChangedEvents = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Mes Inicial:"
        '
        'clmFechaMov
        '
        Me.clmFechaMov.DataPropertyName = "FechaMovimiento"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.clmFechaMov.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmFechaMov.HeaderText = "Fecha Movto."
        Me.clmFechaMov.Name = "clmFechaMov"
        Me.clmFechaMov.ReadOnly = True
        '
        'clmFolioMvto
        '
        Me.clmFolioMvto.DataPropertyName = "IdFolioMovimiento"
        Me.clmFolioMvto.HeaderText = "Folio Movto."
        Me.clmFolioMvto.Name = "clmFolioMvto"
        Me.clmFolioMvto.ReadOnly = True
        '
        'clmAlmacen
        '
        Me.clmAlmacen.DataPropertyName = "Almacen"
        Me.clmAlmacen.HeaderText = "Almacen"
        Me.clmAlmacen.Name = "clmAlmacen"
        Me.clmAlmacen.ReadOnly = True
        '
        'clmMovimiento
        '
        Me.clmMovimiento.DataPropertyName = "Descripcion"
        Me.clmMovimiento.HeaderText = "Movimiento"
        Me.clmMovimiento.Name = "clmMovimiento"
        Me.clmMovimiento.ReadOnly = True
        '
        'clmCantidadKgrs
        '
        Me.clmCantidadKgrs.DataPropertyName = "CantKilos"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.clmCantidadKgrs.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmCantidadKgrs.HeaderText = "Cantidad Kilos"
        Me.clmCantidadKgrs.Name = "clmCantidadKgrs"
        Me.clmCantidadKgrs.ReadOnly = True
        '
        'clmCantidadPzas
        '
        Me.clmCantidadPzas.DataPropertyName = "CantPzas"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.clmCantidadPzas.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmCantidadPzas.HeaderText = "Cantidad Piezas"
        Me.clmCantidadPzas.Name = "clmCantidadPzas"
        Me.clmCantidadPzas.ReadOnly = True
        Me.clmCantidadPzas.Width = 120
        '
        'clmExistenciaPzas
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.clmExistenciaPzas.DefaultCellStyle = DataGridViewCellStyle4
        Me.clmExistenciaPzas.HeaderText = "Existencia Pzas"
        Me.clmExistenciaPzas.Name = "clmExistenciaPzas"
        Me.clmExistenciaPzas.ReadOnly = True
        Me.clmExistenciaPzas.Width = 110
        '
        'clmExistenciaKgrs
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.clmExistenciaKgrs.DefaultCellStyle = DataGridViewCellStyle5
        Me.clmExistenciaKgrs.HeaderText = "Existencia Kgrs"
        Me.clmExistenciaKgrs.Name = "clmExistenciaKgrs"
        Me.clmExistenciaKgrs.ReadOnly = True
        Me.clmExistenciaKgrs.Width = 110
        '
        'clmCosto
        '
        Me.clmCosto.DataPropertyName = "CostoUnitario"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.clmCosto.DefaultCellStyle = DataGridViewCellStyle6
        Me.clmCosto.HeaderText = "Costo"
        Me.clmCosto.Name = "clmCosto"
        Me.clmCosto.ReadOnly = True
        Me.clmCosto.Visible = False
        '
        'clmCostoProm
        '
        Me.clmCostoProm.DataPropertyName = "CostoProm"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.clmCostoProm.DefaultCellStyle = DataGridViewCellStyle7
        Me.clmCostoProm.HeaderText = "Costo Prom."
        Me.clmCostoProm.Name = "clmCostoProm"
        Me.clmCostoProm.ReadOnly = True
        Me.clmCostoProm.Visible = False
        '
        'clmTipoMovimiento
        '
        Me.clmTipoMovimiento.DataPropertyName = "Direccion"
        Me.clmTipoMovimiento.HeaderText = "Tipo Movimiento"
        Me.clmTipoMovimiento.Name = "clmTipoMovimiento"
        Me.clmTipoMovimiento.ReadOnly = True
        Me.clmTipoMovimiento.Visible = False
        '
        'frmKardexProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 472)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmKardexProduccion"
        Me.Text = "Kardex de Productos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DgvDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DgvDetalles As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtExistenciaKgrs As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTotalSalidasPzas As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalEntradasPzas As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtExistenciaInicialPzas As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCostoInicial As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CmbAño As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMes As System.Windows.Forms.ComboBox
    Friend WithEvents CmbProducto As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents AlmacenC As ClasesNegocio.AlmacenCollectionClass
    Friend WithEvents ProductosCol As ClasesNegocio.ProductosCollectionsClass
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtExistenciaInicialKgrs As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalEntradasKgrs As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTotalSalidasKgrs As System.Windows.Forms.TextBox
    Friend WithEvents txtExistenciaPzas As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents clmFechaMov As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFolioMvto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmAlmacen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmMovimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCantidadKgrs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCantidadPzas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmExistenciaPzas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmExistenciaKgrs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCosto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCostoProm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTipoMovimiento As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
