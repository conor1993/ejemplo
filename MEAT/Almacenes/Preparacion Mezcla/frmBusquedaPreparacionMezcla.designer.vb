<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaPreparacionMezcla
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Plazas = New ClasesNegocio.PlazaCollectionClass
        Me.AlmacenC = New ClasesNegocio.AlmacenCollectionClass
        Me.Mezclas = New ClasesNegocio.ProductoCollectionClass
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chkCanceladas = New System.Windows.Forms.CheckBox
        Me.chkPreparadas = New System.Windows.Forms.CheckBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.dgTransferencias = New System.Windows.Forms.DataGridView
        Me.clmFolioPreparacionMezcla = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmMezcla = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPlaza = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmAlmacen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCantidadPreparada = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEnvase = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCantidadEnvase = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFechaPreparacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIdPlaza = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.gbRangoFecha = New System.Windows.Forms.GroupBox
        Me.dtFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.chkFiltrarFechas = New System.Windows.Forms.CheckBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbPlaza = New IntegraLab.Controles.ComboBoxMejorado
        Me.txtCodigoAlmacen = New IntegraLab.Controles.TextBoxMejorado
        Me.cmbAlmacen = New IntegraLab.Controles.ComboBoxMejorado
        Me.txtCodigoMezcla = New IntegraLab.Controles.TextBoxMejorado
        Me.cmbMezcla = New IntegraLab.Controles.ComboBoxMejorado
        Me.txtCodigoPlaza = New IntegraLab.Controles.TextBoxMejorado
        Me.txtFolioPreparacion = New IntegraLab.Controles.TextBoxMejorado
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgTransferencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbRangoFecha.SuspendLayout()
        Me.SuspendLayout()
        '
        'Plazas
        '
        Me.Plazas.AllowEdit = True
        Me.Plazas.AllowNew = True
        Me.Plazas.AllowRemove = True
        Me.Plazas.Name = Nothing
        Me.Plazas.RaiseListChangedEvents = True
        '
        'AlmacenC
        '
        Me.AlmacenC.AllowEdit = True
        Me.AlmacenC.AllowNew = True
        Me.AlmacenC.AllowRemove = True
        Me.AlmacenC.Name = Nothing
        Me.AlmacenC.RaiseListChangedEvents = True
        Me.AlmacenC.Tipo = ClasesNegocio.AlmacenEnum.ALMACEN
        '
        'Mezclas
        '
        Me.Mezclas.AllowEdit = True
        Me.Mezclas.AllowNew = True
        Me.Mezclas.AllowRemove = True
        Me.Mezclas.Name = Nothing
        Me.Mezclas.RaiseListChangedEvents = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Location = New System.Drawing.Point(810, 545)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 74
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkCanceladas)
        Me.GroupBox2.Controls.Add(Me.chkPreparadas)
        Me.GroupBox2.Location = New System.Drawing.Point(752, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(99, 74)
        Me.GroupBox2.TabIndex = 73
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estatus"
        '
        'chkCanceladas
        '
        Me.chkCanceladas.AutoSize = True
        Me.chkCanceladas.Checked = True
        Me.chkCanceladas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCanceladas.Location = New System.Drawing.Point(6, 45)
        Me.chkCanceladas.Name = "chkCanceladas"
        Me.chkCanceladas.Size = New System.Drawing.Size(82, 17)
        Me.chkCanceladas.TabIndex = 2
        Me.chkCanceladas.Text = "Canceladas"
        Me.chkCanceladas.UseVisualStyleBackColor = True
        '
        'chkPreparadas
        '
        Me.chkPreparadas.AutoSize = True
        Me.chkPreparadas.Checked = True
        Me.chkPreparadas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPreparadas.Location = New System.Drawing.Point(6, 22)
        Me.chkPreparadas.Name = "chkPreparadas"
        Me.chkPreparadas.Size = New System.Drawing.Size(80, 17)
        Me.chkPreparadas.TabIndex = 1
        Me.chkPreparadas.Text = "Preparadas"
        Me.chkPreparadas.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(928, 29)
        Me.Label17.TabIndex = 65
        Me.Label17.Text = "BUSQUEDA PREPARACIÓN MEZCLA"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Location = New System.Drawing.Point(891, 545)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 75
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'dgTransferencias
        '
        Me.dgTransferencias.AllowUserToAddRows = False
        Me.dgTransferencias.AllowUserToDeleteRows = False
        Me.dgTransferencias.AllowUserToResizeRows = False
        Me.dgTransferencias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgTransferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTransferencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmFolioPreparacionMezcla, Me.clmMezcla, Me.clmPlaza, Me.clmAlmacen, Me.clmCantidadPreparada, Me.clmEnvase, Me.clmCantidadEnvase, Me.clmFechaPreparacion, Me.clmEstatus, Me.clmIdPlaza})
        Me.dgTransferencias.Location = New System.Drawing.Point(6, 19)
        Me.dgTransferencias.Name = "dgTransferencias"
        Me.dgTransferencias.ReadOnly = True
        Me.dgTransferencias.RowHeadersVisible = False
        Me.dgTransferencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTransferencias.Size = New System.Drawing.Size(899, 369)
        Me.dgTransferencias.TabIndex = 0
        '
        'clmFolioPreparacionMezcla
        '
        Me.clmFolioPreparacionMezcla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmFolioPreparacionMezcla.DataPropertyName = "FolPrepForm"
        Me.clmFolioPreparacionMezcla.HeaderText = "Folio Preparación Mezcla"
        Me.clmFolioPreparacionMezcla.Name = "clmFolioPreparacionMezcla"
        Me.clmFolioPreparacionMezcla.ReadOnly = True
        Me.clmFolioPreparacionMezcla.Width = 138
        '
        'clmMezcla
        '
        Me.clmMezcla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmMezcla.DataPropertyName = "Mezcla"
        Me.clmMezcla.HeaderText = "Mezcla"
        Me.clmMezcla.Name = "clmMezcla"
        Me.clmMezcla.ReadOnly = True
        Me.clmMezcla.Width = 66
        '
        'clmPlaza
        '
        Me.clmPlaza.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmPlaza.DataPropertyName = "Plaza"
        Me.clmPlaza.HeaderText = "Plaza"
        Me.clmPlaza.Name = "clmPlaza"
        Me.clmPlaza.ReadOnly = True
        Me.clmPlaza.Width = 58
        '
        'clmAlmacen
        '
        Me.clmAlmacen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmAlmacen.DataPropertyName = "Almacen"
        Me.clmAlmacen.HeaderText = "Alamcén"
        Me.clmAlmacen.Name = "clmAlmacen"
        Me.clmAlmacen.ReadOnly = True
        Me.clmAlmacen.Width = 73
        '
        'clmCantidadPreparada
        '
        Me.clmCantidadPreparada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmCantidadPreparada.DataPropertyName = "CantRealaPrep"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N3"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.clmCantidadPreparada.DefaultCellStyle = DataGridViewCellStyle4
        Me.clmCantidadPreparada.HeaderText = "Cantidad Preparada"
        Me.clmCantidadPreparada.Name = "clmCantidadPreparada"
        Me.clmCantidadPreparada.ReadOnly = True
        Me.clmCantidadPreparada.Width = 115
        '
        'clmEnvase
        '
        Me.clmEnvase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmEnvase.DataPropertyName = "Envase"
        Me.clmEnvase.HeaderText = "Envase"
        Me.clmEnvase.Name = "clmEnvase"
        Me.clmEnvase.ReadOnly = True
        Me.clmEnvase.Width = 68
        '
        'clmCantidadEnvase
        '
        Me.clmCantidadEnvase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmCantidadEnvase.DataPropertyName = "CantidadEnvase"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N3"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.clmCantidadEnvase.DefaultCellStyle = DataGridViewCellStyle5
        Me.clmCantidadEnvase.HeaderText = "Cantidad Envase"
        Me.clmCantidadEnvase.Name = "clmCantidadEnvase"
        Me.clmCantidadEnvase.ReadOnly = True
        Me.clmCantidadEnvase.Width = 104
        '
        'clmFechaPreparacion
        '
        Me.clmFechaPreparacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmFechaPreparacion.DataPropertyName = "FecPrepForm"
        DataGridViewCellStyle6.Format = "d"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.clmFechaPreparacion.DefaultCellStyle = DataGridViewCellStyle6
        Me.clmFechaPreparacion.HeaderText = "Fecha Preparación"
        Me.clmFechaPreparacion.Name = "clmFechaPreparacion"
        Me.clmFechaPreparacion.ReadOnly = True
        Me.clmFechaPreparacion.Width = 112
        '
        'clmEstatus
        '
        Me.clmEstatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmEstatus.DataPropertyName = "EstatusStr"
        Me.clmEstatus.HeaderText = "Estatus"
        Me.clmEstatus.Name = "clmEstatus"
        Me.clmEstatus.ReadOnly = True
        Me.clmEstatus.Width = 67
        '
        'clmIdPlaza
        '
        Me.clmIdPlaza.DataPropertyName = "IdPlaza"
        Me.clmIdPlaza.HeaderText = "Código Plaza"
        Me.clmIdPlaza.Name = "clmIdPlaza"
        Me.clmIdPlaza.ReadOnly = True
        Me.clmIdPlaza.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgTransferencias)
        Me.GroupBox1.Location = New System.Drawing.Point(55, 145)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(911, 394)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resultado de la Busqueda"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Mezcla:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Almacen:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 13)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Folio Preparación Mezcla:"
        '
        'gbRangoFecha
        '
        Me.gbRangoFecha.Controls.Add(Me.dtFechaFinal)
        Me.gbRangoFecha.Controls.Add(Me.Label5)
        Me.gbRangoFecha.Controls.Add(Me.dtFechaInicial)
        Me.gbRangoFecha.Controls.Add(Me.Label1)
        Me.gbRangoFecha.Enabled = False
        Me.gbRangoFecha.Location = New System.Drawing.Point(549, 65)
        Me.gbRangoFecha.Name = "gbRangoFecha"
        Me.gbRangoFecha.Size = New System.Drawing.Size(197, 73)
        Me.gbRangoFecha.TabIndex = 81
        Me.gbRangoFecha.TabStop = False
        Me.gbRangoFecha.Text = "Rango de Fechas"
        '
        'dtFechaFinal
        '
        Me.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaFinal.Location = New System.Drawing.Point(84, 45)
        Me.dtFechaFinal.Name = "dtFechaFinal"
        Me.dtFechaFinal.Size = New System.Drawing.Size(104, 20)
        Me.dtFechaFinal.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Fecha Fin:"
        '
        'dtFechaInicial
        '
        Me.dtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaInicial.Location = New System.Drawing.Point(84, 19)
        Me.dtFechaInicial.Name = "dtFechaInicial"
        Me.dtFechaInicial.Size = New System.Drawing.Size(104, 20)
        Me.dtFechaInicial.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Inicio:"
        '
        'chkFiltrarFechas
        '
        Me.chkFiltrarFechas.AutoSize = True
        Me.chkFiltrarFechas.Location = New System.Drawing.Point(549, 42)
        Me.chkFiltrarFechas.Name = "chkFiltrarFechas"
        Me.chkFiltrarFechas.Size = New System.Drawing.Size(104, 17)
        Me.chkFiltrarFechas.TabIndex = 82
        Me.chkFiltrarFechas.Text = "Filtrar por fechas"
        Me.chkFiltrarFechas.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 83
        Me.Label6.Text = "Plaza:"
        '
        'cmbPlaza
        '
        Me.cmbPlaza.DataSource = Me.Plazas
        Me.cmbPlaza.DisplayMember = "Descripcion"
        Me.cmbPlaza.FormattingEnabled = True
        Me.cmbPlaza.Location = New System.Drawing.Point(169, 64)
        Me.cmbPlaza.Name = "cmbPlaza"
        Me.cmbPlaza.NombreMetodo = Nothing
        Me.cmbPlaza.Parametros = Nothing
        Me.cmbPlaza.SiguienteControl = Me.txtCodigoAlmacen
        Me.cmbPlaza.Size = New System.Drawing.Size(374, 21)
        Me.cmbPlaza.TabIndex = 85
        Me.cmbPlaza.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbPlaza.TextBoxEnlazado = Me.txtCodigoPlaza
        Me.cmbPlaza.ValueMember = "Codigo"
        '
        'txtCodigoAlmacen
        '
        Me.txtCodigoAlmacen.ComboBoxEnlazado = Me.cmbAlmacen
        Me.txtCodigoAlmacen.Decimales = 0
        Me.txtCodigoAlmacen.Location = New System.Drawing.Point(109, 91)
        Me.txtCodigoAlmacen.MaxLength = 3000
        Me.txtCodigoAlmacen.MensajeCombo = "Seleccionar un almacén..."
        Me.txtCodigoAlmacen.MensajeNoExiste = "No existe un almacén con este código o se encuentra inactivo"
        Me.txtCodigoAlmacen.Name = "txtCodigoAlmacen"
        Me.txtCodigoAlmacen.SiguienteControl = Me.txtCodigoMezcla
        Me.txtCodigoAlmacen.Size = New System.Drawing.Size(54, 20)
        Me.txtCodigoAlmacen.TabIndex = 77
        Me.txtCodigoAlmacen.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtCodigoAlmacen.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCodigoAlmacen.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cmbAlmacen
        '
        Me.cmbAlmacen.DataSource = Me.AlmacenC
        Me.cmbAlmacen.DisplayMember = "Descripcion"
        Me.cmbAlmacen.FormattingEnabled = True
        Me.cmbAlmacen.Location = New System.Drawing.Point(169, 91)
        Me.cmbAlmacen.Name = "cmbAlmacen"
        Me.cmbAlmacen.NombreMetodo = Nothing
        Me.cmbAlmacen.Parametros = Nothing
        Me.cmbAlmacen.SiguienteControl = Me.txtCodigoMezcla
        Me.cmbAlmacen.Size = New System.Drawing.Size(374, 21)
        Me.cmbAlmacen.TabIndex = 79
        Me.cmbAlmacen.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbAlmacen.TextBoxEnlazado = Me.txtCodigoAlmacen
        Me.cmbAlmacen.ValueMember = "Codigo"
        '
        'txtCodigoMezcla
        '
        Me.txtCodigoMezcla.ComboBoxEnlazado = Me.cmbMezcla
        Me.txtCodigoMezcla.Decimales = 0
        Me.txtCodigoMezcla.Location = New System.Drawing.Point(109, 118)
        Me.txtCodigoMezcla.MaxLength = 3000
        Me.txtCodigoMezcla.MensajeCombo = "Seleccionar una mezcla..."
        Me.txtCodigoMezcla.MensajeNoExiste = "No existe una mezcla con este código o se encuentra inactivo"
        Me.txtCodigoMezcla.Name = "txtCodigoMezcla"
        Me.txtCodigoMezcla.SiguienteControl = Me.chkPreparadas
        Me.txtCodigoMezcla.Size = New System.Drawing.Size(54, 20)
        Me.txtCodigoMezcla.TabIndex = 78
        Me.txtCodigoMezcla.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtCodigoMezcla.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCodigoMezcla.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cmbMezcla
        '
        Me.cmbMezcla.DataSource = Me.Mezclas
        Me.cmbMezcla.DisplayMember = "Descripcion"
        Me.cmbMezcla.FormattingEnabled = True
        Me.cmbMezcla.Location = New System.Drawing.Point(169, 118)
        Me.cmbMezcla.Name = "cmbMezcla"
        Me.cmbMezcla.NombreMetodo = Nothing
        Me.cmbMezcla.Parametros = Nothing
        Me.cmbMezcla.SiguienteControl = Me.chkPreparadas
        Me.cmbMezcla.Size = New System.Drawing.Size(374, 21)
        Me.cmbMezcla.TabIndex = 80
        Me.cmbMezcla.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbMezcla.TextBoxEnlazado = Nothing
        Me.cmbMezcla.ValueMember = "Codigo"
        '
        'txtCodigoPlaza
        '
        Me.txtCodigoPlaza.ComboBoxEnlazado = Me.cmbPlaza
        Me.txtCodigoPlaza.Decimales = 0
        Me.txtCodigoPlaza.Location = New System.Drawing.Point(109, 64)
        Me.txtCodigoPlaza.MaxLength = 3000
        Me.txtCodigoPlaza.MensajeCombo = "Seleccionar una plaza..."
        Me.txtCodigoPlaza.MensajeNoExiste = "No existe una plaza con este código o se encuentra inactivo"
        Me.txtCodigoPlaza.Name = "txtCodigoPlaza"
        Me.txtCodigoPlaza.SiguienteControl = Me.txtCodigoAlmacen
        Me.txtCodigoPlaza.Size = New System.Drawing.Size(54, 20)
        Me.txtCodigoPlaza.TabIndex = 84
        Me.txtCodigoPlaza.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtCodigoPlaza.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCodigoPlaza.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtFolioPreparacion
        '
        Me.txtFolioPreparacion.ComboBoxEnlazado = Nothing
        Me.txtFolioPreparacion.Decimales = 0
        Me.txtFolioPreparacion.Location = New System.Drawing.Point(187, 38)
        Me.txtFolioPreparacion.MaxLength = 8
        Me.txtFolioPreparacion.MensajeCombo = "Seleccionar un item..."
        Me.txtFolioPreparacion.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtFolioPreparacion.Name = "txtFolioPreparacion"
        Me.txtFolioPreparacion.SiguienteControl = Me.txtCodigoAlmacen
        Me.txtFolioPreparacion.Size = New System.Drawing.Size(138, 20)
        Me.txtFolioPreparacion.TabIndex = 76
        Me.txtFolioPreparacion.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtFolioPreparacion.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtFolioPreparacion.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
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
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 580)
        Me.mtb.TabIndex = 64
        '
        'frmBusquedaPreparacionMezcla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 580)
        Me.Controls.Add(Me.cmbPlaza)
        Me.Controls.Add(Me.txtCodigoPlaza)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.chkFiltrarFechas)
        Me.Controls.Add(Me.gbRangoFecha)
        Me.Controls.Add(Me.cmbMezcla)
        Me.Controls.Add(Me.cmbAlmacen)
        Me.Controls.Add(Me.txtCodigoMezcla)
        Me.Controls.Add(Me.txtCodigoAlmacen)
        Me.Controls.Add(Me.txtFolioPreparacion)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mtb)
        Me.Name = "frmBusquedaPreparacionMezcla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda Preparación Mezcla"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgTransferencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.gbRangoFecha.ResumeLayout(False)
        Me.gbRangoFecha.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCanceladas As System.Windows.Forms.CheckBox
    Friend WithEvents chkPreparadas As System.Windows.Forms.CheckBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents AlmacenC As ClasesNegocio.AlmacenCollectionClass
    Friend WithEvents dgTransferencias As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents txtFolioPreparacion As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtCodigoAlmacen As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtCodigoMezcla As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents cmbAlmacen As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents cmbMezcla As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents gbRangoFecha As System.Windows.Forms.GroupBox
    Friend WithEvents dtFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkFiltrarFechas As System.Windows.Forms.CheckBox
    Friend WithEvents Mezclas As ClasesNegocio.ProductoCollectionClass
    Friend WithEvents cmbPlaza As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents Plazas As ClasesNegocio.PlazaCollectionClass
    Friend WithEvents txtCodigoPlaza As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents clmFolioPreparacionMezcla As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmMezcla As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPlaza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmAlmacen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCantidadPreparada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEnvase As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCantidadEnvase As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaPreparacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdPlaza As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
