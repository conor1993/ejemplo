<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaComprasGanado
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
        Me.Label17 = New System.Windows.Forms.Label
        Me.chkFiltrar = New System.Windows.Forms.CheckBox
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.dgvResultados = New System.Windows.Forms.DataGridView
        Me.FolioRecepcionCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LugarCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CompradorGanadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CorralDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CabezasCompDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KilosCompDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PesoEntRealDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostosIndiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ImpteCompDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaRecepcionCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdLugarCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdCompradorGanadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdCorralDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumGuiasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ImpteXguiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StaCerradoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.busquedaRecepcionCompras = New IntegraLab.ORM.TypedViewClasses.VwBusquedaComprasdeGanadoTypedView
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.CompradoresGanadoC = New ClasesNegocio.CompradorGanadoCollectionClass
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DtpFechaFin = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.DtpFechaIni = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chkCanceladas = New System.Windows.Forms.CheckBox
        Me.chkVigentes = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCodigoProveedor = New IntegraLab.Controles.TextBoxMejorado
        Me.cmbProveedor = New IntegraLab.Controles.ComboBoxMejorado
        Me.txtCodigoComprador = New IntegraLab.Controles.TextBoxMejorado
        Me.cmbComprador = New IntegraLab.Controles.ComboBoxMejorado
        Me.txtCodigoCorral = New IntegraLab.Controles.TextBoxMejorado
        Me.cmbCorral = New IntegraLab.Controles.ComboBoxMejorado
        Me.CorralesColecttionC = New ClasesNegocio.CorralColecttionClass
        Me.txtCodigoLugarCompra = New IntegraLab.Controles.TextBoxMejorado
        Me.cmbLugarCompra = New IntegraLab.Controles.ComboBoxMejorado
        Me.LugaresDeCompraC = New ClasesNegocio.LugaresDeCompraCollectionClass
        Me.txtFolioCompra = New IntegraLab.Controles.TextBoxMejorado
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.busquedaRecepcionCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(900, 32)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Consulta de Compras de Ganado "
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkFiltrar
        '
        Me.chkFiltrar.AutoSize = True
        Me.chkFiltrar.Location = New System.Drawing.Point(604, 39)
        Me.chkFiltrar.Name = "chkFiltrar"
        Me.chkFiltrar.Size = New System.Drawing.Size(103, 17)
        Me.chkFiltrar.TabIndex = 37
        Me.chkFiltrar.Text = "Filtrar Por Fecha"
        Me.chkFiltrar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Location = New System.Drawing.Point(782, 571)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 39
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Location = New System.Drawing.Point(863, 571)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 40
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'dgvResultados
        '
        Me.dgvResultados.AllowUserToAddRows = False
        Me.dgvResultados.AllowUserToDeleteRows = False
        Me.dgvResultados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvResultados.AutoGenerateColumns = False
        Me.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FolioRecepcionCompraDataGridViewTextBoxColumn, Me.ProveedorDataGridViewTextBoxColumn, Me.LugarCompraDataGridViewTextBoxColumn, Me.CompradorGanadoDataGridViewTextBoxColumn, Me.CorralDataGridViewTextBoxColumn, Me.CabezasCompDataGridViewTextBoxColumn, Me.KilosCompDataGridViewTextBoxColumn, Me.PesoEntRealDataGridViewTextBoxColumn, Me.CostosIndiDataGridViewTextBoxColumn, Me.ImpteCompDataGridViewTextBoxColumn, Me.FechaRecepcionCompraDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.IdProveedorDataGridViewTextBoxColumn, Me.IdLugarCompraDataGridViewTextBoxColumn, Me.IdCompradorGanadoDataGridViewTextBoxColumn, Me.IdCorralDataGridViewTextBoxColumn, Me.NumGuiasDataGridViewTextBoxColumn, Me.ImpteXguiaDataGridViewTextBoxColumn, Me.StaCerradoDataGridViewCheckBoxColumn})
        Me.dgvResultados.DataSource = Me.busquedaRecepcionCompras
        Me.dgvResultados.Location = New System.Drawing.Point(6, 19)
        Me.dgvResultados.Name = "dgvResultados"
        Me.dgvResultados.ReadOnly = True
        Me.dgvResultados.RowHeadersVisible = False
        Me.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvResultados.Size = New System.Drawing.Size(864, 368)
        Me.dgvResultados.TabIndex = 41
        '
        'FolioRecepcionCompraDataGridViewTextBoxColumn
        '
        Me.FolioRecepcionCompraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.FolioRecepcionCompraDataGridViewTextBoxColumn.DataPropertyName = "FolioRecepcionCompra"
        Me.FolioRecepcionCompraDataGridViewTextBoxColumn.HeaderText = "Folio Recepción Compra"
        Me.FolioRecepcionCompraDataGridViewTextBoxColumn.Name = "FolioRecepcionCompraDataGridViewTextBoxColumn"
        Me.FolioRecepcionCompraDataGridViewTextBoxColumn.ReadOnly = True
        Me.FolioRecepcionCompraDataGridViewTextBoxColumn.Width = 133
        '
        'ProveedorDataGridViewTextBoxColumn
        '
        Me.ProveedorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ProveedorDataGridViewTextBoxColumn.DataPropertyName = "Proveedor"
        Me.ProveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor"
        Me.ProveedorDataGridViewTextBoxColumn.Name = "ProveedorDataGridViewTextBoxColumn"
        Me.ProveedorDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProveedorDataGridViewTextBoxColumn.Width = 79
        '
        'LugarCompraDataGridViewTextBoxColumn
        '
        Me.LugarCompraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.LugarCompraDataGridViewTextBoxColumn.DataPropertyName = "LugarCompra"
        Me.LugarCompraDataGridViewTextBoxColumn.HeaderText = "Lugar de Compra"
        Me.LugarCompraDataGridViewTextBoxColumn.Name = "LugarCompraDataGridViewTextBoxColumn"
        Me.LugarCompraDataGridViewTextBoxColumn.ReadOnly = True
        Me.LugarCompraDataGridViewTextBoxColumn.Width = 102
        '
        'CompradorGanadoDataGridViewTextBoxColumn
        '
        Me.CompradorGanadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CompradorGanadoDataGridViewTextBoxColumn.DataPropertyName = "CompradorGanado"
        Me.CompradorGanadoDataGridViewTextBoxColumn.HeaderText = "Comprador de Ganado"
        Me.CompradorGanadoDataGridViewTextBoxColumn.Name = "CompradorGanadoDataGridViewTextBoxColumn"
        Me.CompradorGanadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CompradorGanadoDataGridViewTextBoxColumn.Width = 91
        '
        'CorralDataGridViewTextBoxColumn
        '
        Me.CorralDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CorralDataGridViewTextBoxColumn.DataPropertyName = "Corral"
        Me.CorralDataGridViewTextBoxColumn.HeaderText = "Corral"
        Me.CorralDataGridViewTextBoxColumn.Name = "CorralDataGridViewTextBoxColumn"
        Me.CorralDataGridViewTextBoxColumn.ReadOnly = True
        Me.CorralDataGridViewTextBoxColumn.Width = 57
        '
        'CabezasCompDataGridViewTextBoxColumn
        '
        Me.CabezasCompDataGridViewTextBoxColumn.DataPropertyName = "CabezasComp"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.CabezasCompDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.CabezasCompDataGridViewTextBoxColumn.HeaderText = "Cabezas Compradas"
        Me.CabezasCompDataGridViewTextBoxColumn.Name = "CabezasCompDataGridViewTextBoxColumn"
        Me.CabezasCompDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KilosCompDataGridViewTextBoxColumn
        '
        Me.KilosCompDataGridViewTextBoxColumn.DataPropertyName = "KilosComp"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N4"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.KilosCompDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.KilosCompDataGridViewTextBoxColumn.HeaderText = "Kilos Comprados"
        Me.KilosCompDataGridViewTextBoxColumn.Name = "KilosCompDataGridViewTextBoxColumn"
        Me.KilosCompDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PesoEntRealDataGridViewTextBoxColumn
        '
        Me.PesoEntRealDataGridViewTextBoxColumn.DataPropertyName = "PesoEntReal"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N4"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.PesoEntRealDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.PesoEntRealDataGridViewTextBoxColumn.HeaderText = "Kilos Recibidos"
        Me.PesoEntRealDataGridViewTextBoxColumn.Name = "PesoEntRealDataGridViewTextBoxColumn"
        Me.PesoEntRealDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CostosIndiDataGridViewTextBoxColumn
        '
        Me.CostosIndiDataGridViewTextBoxColumn.DataPropertyName = "CostosIndi"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.CostosIndiDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.CostosIndiDataGridViewTextBoxColumn.HeaderText = "Costos Indirectos"
        Me.CostosIndiDataGridViewTextBoxColumn.Name = "CostosIndiDataGridViewTextBoxColumn"
        Me.CostosIndiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ImpteCompDataGridViewTextBoxColumn
        '
        Me.ImpteCompDataGridViewTextBoxColumn.DataPropertyName = "ImpteComp"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.ImpteCompDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.ImpteCompDataGridViewTextBoxColumn.HeaderText = "Importe Compra"
        Me.ImpteCompDataGridViewTextBoxColumn.Name = "ImpteCompDataGridViewTextBoxColumn"
        Me.ImpteCompDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaRecepcionCompraDataGridViewTextBoxColumn
        '
        Me.FechaRecepcionCompraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.FechaRecepcionCompraDataGridViewTextBoxColumn.DataPropertyName = "FechaRecepcionCompra"
        DataGridViewCellStyle6.Format = "d"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.FechaRecepcionCompraDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.FechaRecepcionCompraDataGridViewTextBoxColumn.HeaderText = "Fecha Recepción Compra"
        Me.FechaRecepcionCompraDataGridViewTextBoxColumn.Name = "FechaRecepcionCompraDataGridViewTextBoxColumn"
        Me.FechaRecepcionCompraDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaRecepcionCompraDataGridViewTextBoxColumn.Width = 140
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "EstatusStr"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Estatus"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdProveedorDataGridViewTextBoxColumn
        '
        Me.IdProveedorDataGridViewTextBoxColumn.DataPropertyName = "IdProveedor"
        Me.IdProveedorDataGridViewTextBoxColumn.HeaderText = "IdProveedor"
        Me.IdProveedorDataGridViewTextBoxColumn.Name = "IdProveedorDataGridViewTextBoxColumn"
        Me.IdProveedorDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdProveedorDataGridViewTextBoxColumn.Visible = False
        '
        'IdLugarCompraDataGridViewTextBoxColumn
        '
        Me.IdLugarCompraDataGridViewTextBoxColumn.DataPropertyName = "IdLugarCompra"
        Me.IdLugarCompraDataGridViewTextBoxColumn.HeaderText = "IdLugarCompra"
        Me.IdLugarCompraDataGridViewTextBoxColumn.Name = "IdLugarCompraDataGridViewTextBoxColumn"
        Me.IdLugarCompraDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdLugarCompraDataGridViewTextBoxColumn.Visible = False
        '
        'IdCompradorGanadoDataGridViewTextBoxColumn
        '
        Me.IdCompradorGanadoDataGridViewTextBoxColumn.DataPropertyName = "IdCompradorGanado"
        Me.IdCompradorGanadoDataGridViewTextBoxColumn.HeaderText = "IdCompradorGanado"
        Me.IdCompradorGanadoDataGridViewTextBoxColumn.Name = "IdCompradorGanadoDataGridViewTextBoxColumn"
        Me.IdCompradorGanadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCompradorGanadoDataGridViewTextBoxColumn.Visible = False
        '
        'IdCorralDataGridViewTextBoxColumn
        '
        Me.IdCorralDataGridViewTextBoxColumn.DataPropertyName = "IdCorral"
        Me.IdCorralDataGridViewTextBoxColumn.HeaderText = "IdCorral"
        Me.IdCorralDataGridViewTextBoxColumn.Name = "IdCorralDataGridViewTextBoxColumn"
        Me.IdCorralDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCorralDataGridViewTextBoxColumn.Visible = False
        '
        'NumGuiasDataGridViewTextBoxColumn
        '
        Me.NumGuiasDataGridViewTextBoxColumn.DataPropertyName = "NumGuias"
        Me.NumGuiasDataGridViewTextBoxColumn.HeaderText = "NumGuias"
        Me.NumGuiasDataGridViewTextBoxColumn.Name = "NumGuiasDataGridViewTextBoxColumn"
        Me.NumGuiasDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumGuiasDataGridViewTextBoxColumn.Visible = False
        '
        'ImpteXguiaDataGridViewTextBoxColumn
        '
        Me.ImpteXguiaDataGridViewTextBoxColumn.DataPropertyName = "ImpteXguia"
        Me.ImpteXguiaDataGridViewTextBoxColumn.HeaderText = "ImpteXguia"
        Me.ImpteXguiaDataGridViewTextBoxColumn.Name = "ImpteXguiaDataGridViewTextBoxColumn"
        Me.ImpteXguiaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImpteXguiaDataGridViewTextBoxColumn.Visible = False
        '
        'StaCerradoDataGridViewCheckBoxColumn
        '
        Me.StaCerradoDataGridViewCheckBoxColumn.DataPropertyName = "StaCerrado"
        Me.StaCerradoDataGridViewCheckBoxColumn.HeaderText = "Cerrado"
        Me.StaCerradoDataGridViewCheckBoxColumn.Name = "StaCerradoDataGridViewCheckBoxColumn"
        Me.StaCerradoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.StaCerradoDataGridViewCheckBoxColumn.Visible = False
        '
        'busquedaRecepcionCompras
        '
        Me.busquedaRecepcionCompras.TableName = "VwBusquedaComprasdeGanado"
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
        Me.mtb.Size = New System.Drawing.Size(50, 606)
        Me.mtb.TabIndex = 48
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.dgvResultados)
        Me.GroupBox3.Location = New System.Drawing.Point(62, 172)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(876, 393)
        Me.GroupBox3.TabIndex = 49
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Resultados"
        '
        'CompradoresGanadoC
        '
        Me.CompradoresGanadoC.AllowEdit = True
        Me.CompradoresGanadoC.AllowNew = True
        Me.CompradoresGanadoC.AllowRemove = True
        Me.CompradoresGanadoC.MaximoElementosSeleccionados = 1
        Me.CompradoresGanadoC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.CompradoresGanadoC.MostrarAlertas = False
        Me.CompradoresGanadoC.Name = ""
        Me.CompradoresGanadoC.RaiseListChangedEvents = True
        Me.CompradoresGanadoC.Transaction = Nothing
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(59, 123)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "Corral :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(59, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Comprador:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Proveedor :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Folio :"
        '
        'DtpFechaFin
        '
        Me.DtpFechaFin.Enabled = False
        Me.DtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaFin.Location = New System.Drawing.Point(80, 45)
        Me.DtpFechaFin.Name = "DtpFechaFin"
        Me.DtpFechaFin.Size = New System.Drawing.Size(85, 20)
        Me.DtpFechaFin.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Fecha Final :"
        '
        'DtpFechaIni
        '
        Me.DtpFechaIni.Enabled = False
        Me.DtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaIni.Location = New System.Drawing.Point(80, 19)
        Me.DtpFechaIni.Name = "DtpFechaIni"
        Me.DtpFechaIni.Size = New System.Drawing.Size(85, 20)
        Me.DtpFechaIni.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Fecha Inicial :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DtpFechaFin)
        Me.GroupBox1.Controls.Add(Me.DtpFechaIni)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(604, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(173, 75)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rango de Fecha"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkCanceladas)
        Me.GroupBox2.Controls.Add(Me.chkVigentes)
        Me.GroupBox2.Location = New System.Drawing.Point(783, 65)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(99, 75)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estatus"
        '
        'chkCanceladas
        '
        Me.chkCanceladas.AutoSize = True
        Me.chkCanceladas.Checked = True
        Me.chkCanceladas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCanceladas.Location = New System.Drawing.Point(6, 42)
        Me.chkCanceladas.Name = "chkCanceladas"
        Me.chkCanceladas.Size = New System.Drawing.Size(82, 17)
        Me.chkCanceladas.TabIndex = 57
        Me.chkCanceladas.Text = "Canceladas"
        Me.chkCanceladas.UseVisualStyleBackColor = True
        '
        'chkVigentes
        '
        Me.chkVigentes.AutoSize = True
        Me.chkVigentes.Checked = True
        Me.chkVigentes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVigentes.Location = New System.Drawing.Point(6, 19)
        Me.chkVigentes.Name = "chkVigentes"
        Me.chkVigentes.Size = New System.Drawing.Size(67, 17)
        Me.chkVigentes.TabIndex = 56
        Me.chkVigentes.Text = "Vigentes"
        Me.chkVigentes.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(59, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Lugar de Compra:"
        '
        'txtCodigoProveedor
        '
        Me.txtCodigoProveedor.ComboBoxEnlazado = Me.cmbProveedor
        Me.txtCodigoProveedor.Decimales = 0
        Me.txtCodigoProveedor.Location = New System.Drawing.Point(156, 65)
        Me.txtCodigoProveedor.MaxLength = 3000
        Me.txtCodigoProveedor.MensajeCombo = "Seleccionar un proveedor..."
        Me.txtCodigoProveedor.MensajeNoExiste = "No existe un proveedor con este código o se encuentra inactivo"
        Me.txtCodigoProveedor.Name = "txtCodigoProveedor"
        Me.txtCodigoProveedor.SiguienteControl = Me.txtCodigoComprador
        Me.txtCodigoProveedor.Size = New System.Drawing.Size(57, 20)
        Me.txtCodigoProveedor.TabIndex = 69
        Me.txtCodigoProveedor.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtCodigoProveedor.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCodigoProveedor.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cmbProveedor
        '
        Me.cmbProveedor.DisplayMember = "RazonSocial"
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(219, 65)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.NombreMetodo = ""
        Me.cmbProveedor.Parametros = Nothing
        Me.cmbProveedor.SiguienteControl = Me.txtCodigoComprador
        Me.cmbProveedor.Size = New System.Drawing.Size(379, 21)
        Me.cmbProveedor.TabIndex = 73
        Me.cmbProveedor.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbProveedor.TextBoxEnlazado = Me.txtCodigoProveedor
        Me.cmbProveedor.ValueMember = "Codigo"
        '
        'txtCodigoComprador
        '
        Me.txtCodigoComprador.ComboBoxEnlazado = Me.cmbComprador
        Me.txtCodigoComprador.Decimales = 0
        Me.txtCodigoComprador.Location = New System.Drawing.Point(156, 92)
        Me.txtCodigoComprador.MensajeCombo = "Seleccionar un comprador..."
        Me.txtCodigoComprador.MensajeNoExiste = "No existe un comprador con este código o se encuentra inactivo"
        Me.txtCodigoComprador.Name = "txtCodigoComprador"
        Me.txtCodigoComprador.SiguienteControl = Me.txtCodigoCorral
        Me.txtCodigoComprador.Size = New System.Drawing.Size(57, 20)
        Me.txtCodigoComprador.TabIndex = 70
        Me.txtCodigoComprador.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtCodigoComprador.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCodigoComprador.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cmbComprador
        '
        Me.cmbComprador.DataSource = Me.CompradoresGanadoC
        Me.cmbComprador.DisplayMember = "NomCompleto"
        Me.cmbComprador.FormattingEnabled = True
        Me.cmbComprador.Location = New System.Drawing.Point(219, 92)
        Me.cmbComprador.Name = "cmbComprador"
        Me.cmbComprador.NombreMetodo = "Obtener"
        Me.cmbComprador.Parametros = Nothing
        Me.cmbComprador.SiguienteControl = Me.txtCodigoCorral
        Me.cmbComprador.Size = New System.Drawing.Size(379, 21)
        Me.cmbComprador.TabIndex = 74
        Me.cmbComprador.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbComprador.TextBoxEnlazado = Me.txtCodigoComprador
        Me.cmbComprador.ValueMember = "IdComprador"
        '
        'txtCodigoCorral
        '
        Me.txtCodigoCorral.ComboBoxEnlazado = Me.cmbCorral
        Me.txtCodigoCorral.Decimales = 0
        Me.txtCodigoCorral.Location = New System.Drawing.Point(156, 119)
        Me.txtCodigoCorral.MensajeCombo = "Seleccionar un corral..."
        Me.txtCodigoCorral.MensajeNoExiste = "No existe un corral con este código o se encuentra inactivo"
        Me.txtCodigoCorral.Name = "txtCodigoCorral"
        Me.txtCodigoCorral.SiguienteControl = Me.txtCodigoLugarCompra
        Me.txtCodigoCorral.Size = New System.Drawing.Size(57, 20)
        Me.txtCodigoCorral.TabIndex = 71
        Me.txtCodigoCorral.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtCodigoCorral.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCodigoCorral.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cmbCorral
        '
        Me.cmbCorral.DataSource = Me.CorralesColecttionC
        Me.cmbCorral.DisplayMember = "Descripcion"
        Me.cmbCorral.FormattingEnabled = True
        Me.cmbCorral.Location = New System.Drawing.Point(219, 119)
        Me.cmbCorral.Name = "cmbCorral"
        Me.cmbCorral.NombreMetodo = "Obtener"
        Me.cmbCorral.Parametros = Nothing
        Me.cmbCorral.SiguienteControl = Me.txtCodigoLugarCompra
        Me.cmbCorral.Size = New System.Drawing.Size(379, 21)
        Me.cmbCorral.TabIndex = 75
        Me.cmbCorral.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbCorral.TextBoxEnlazado = Me.txtCodigoCorral
        Me.cmbCorral.ValueMember = "IdCorral"
        '
        'CorralesColecttionC
        '
        Me.CorralesColecttionC.AllowEdit = True
        Me.CorralesColecttionC.AllowNew = True
        Me.CorralesColecttionC.AllowRemove = True
        Me.CorralesColecttionC.MaximoElementosSeleccionados = 1
        Me.CorralesColecttionC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.CorralesColecttionC.MostrarAlertas = False
        Me.CorralesColecttionC.Name = Nothing
        Me.CorralesColecttionC.RaiseListChangedEvents = True
        Me.CorralesColecttionC.Transaction = Nothing
        '
        'txtCodigoLugarCompra
        '
        Me.txtCodigoLugarCompra.ComboBoxEnlazado = Me.cmbLugarCompra
        Me.txtCodigoLugarCompra.Decimales = 0
        Me.txtCodigoLugarCompra.Location = New System.Drawing.Point(156, 146)
        Me.txtCodigoLugarCompra.MensajeCombo = "Seleccionar un lugar de compra..."
        Me.txtCodigoLugarCompra.MensajeNoExiste = "No existe un lugar de compra con este código o se encuentra inactivo"
        Me.txtCodigoLugarCompra.Name = "txtCodigoLugarCompra"
        Me.txtCodigoLugarCompra.SiguienteControl = Me.chkFiltrar
        Me.txtCodigoLugarCompra.Size = New System.Drawing.Size(57, 20)
        Me.txtCodigoLugarCompra.TabIndex = 72
        Me.txtCodigoLugarCompra.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtCodigoLugarCompra.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCodigoLugarCompra.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cmbLugarCompra
        '
        Me.cmbLugarCompra.DataSource = Me.LugaresDeCompraC
        Me.cmbLugarCompra.DisplayMember = "Descripcion"
        Me.cmbLugarCompra.FormattingEnabled = True
        Me.cmbLugarCompra.Location = New System.Drawing.Point(219, 146)
        Me.cmbLugarCompra.Name = "cmbLugarCompra"
        Me.cmbLugarCompra.NombreMetodo = "Obtener"
        Me.cmbLugarCompra.Parametros = Nothing
        Me.cmbLugarCompra.SiguienteControl = Me.chkFiltrar
        Me.cmbLugarCompra.Size = New System.Drawing.Size(379, 21)
        Me.cmbLugarCompra.TabIndex = 76
        Me.cmbLugarCompra.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbLugarCompra.TextBoxEnlazado = Me.txtCodigoLugarCompra
        Me.cmbLugarCompra.ValueMember = "IdLugarCompra"
        '
        'LugaresDeCompraC
        '
        Me.LugaresDeCompraC.AllowEdit = True
        Me.LugaresDeCompraC.AllowNew = True
        Me.LugaresDeCompraC.AllowRemove = True
        Me.LugaresDeCompraC.MaximoElementosSeleccionados = 1
        Me.LugaresDeCompraC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.LugaresDeCompraC.MostrarAlertas = False
        Me.LugaresDeCompraC.Name = Nothing
        Me.LugaresDeCompraC.RaiseListChangedEvents = True
        Me.LugaresDeCompraC.Transaction = Nothing
        '
        'txtFolioCompra
        '
        Me.txtFolioCompra.ComboBoxEnlazado = Nothing
        Me.txtFolioCompra.Decimales = 0
        Me.txtFolioCompra.Location = New System.Drawing.Point(156, 39)
        Me.txtFolioCompra.MensajeCombo = "Seleccionar un item..."
        Me.txtFolioCompra.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtFolioCompra.Name = "txtFolioCompra"
        Me.txtFolioCompra.SiguienteControl = Me.txtCodigoProveedor
        Me.txtFolioCompra.Size = New System.Drawing.Size(137, 20)
        Me.txtFolioCompra.TabIndex = 77
        Me.txtFolioCompra.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtFolioCompra.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtFolioCompra.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'FrmConsultaComprasGanado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 606)
        Me.Controls.Add(Me.txtFolioCompra)
        Me.Controls.Add(Me.cmbLugarCompra)
        Me.Controls.Add(Me.cmbCorral)
        Me.Controls.Add(Me.cmbComprador)
        Me.Controls.Add(Me.cmbProveedor)
        Me.Controls.Add(Me.txtCodigoLugarCompra)
        Me.Controls.Add(Me.txtCodigoCorral)
        Me.Controls.Add(Me.txtCodigoComprador)
        Me.Controls.Add(Me.txtCodigoProveedor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.chkFiltrar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mtb)
        Me.MaximizeBox = False
        Me.Name = "FrmConsultaComprasGanado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Compra de Ganado"
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.busquedaRecepcionCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents chkFiltrar As System.Windows.Forms.CheckBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents dgvResultados As System.Windows.Forms.DataGridView
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DtpFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CompradoresGanadoC As ClasesNegocio.CompradorGanadoCollectionClass
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCanceladas As System.Windows.Forms.CheckBox
    Friend WithEvents chkVigentes As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoProveedor As Integralab.Controles.TextBoxMejorado
    Friend WithEvents txtCodigoComprador As Integralab.Controles.TextBoxMejorado
    Friend WithEvents txtCodigoCorral As Integralab.Controles.TextBoxMejorado
    Friend WithEvents txtCodigoLugarCompra As Integralab.Controles.TextBoxMejorado
    Friend WithEvents cmbProveedor As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents cmbComprador As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents cmbLugarCompra As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents cmbCorral As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents txtFolioCompra As Integralab.Controles.TextBoxMejorado
    Friend WithEvents LugaresDeCompraC As ClasesNegocio.LugaresDeCompraCollectionClass
    Friend WithEvents CorralesColecttionC As ClasesNegocio.CorralColecttionClass
    Friend WithEvents busquedaRecepcionCompras As IntegraLab.ORM.TypedViewClasses.VwBusquedaComprasdeGanadoTypedView
    Friend WithEvents FolioRecepcionCompraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProveedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LugarCompraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompradorGanadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CorralDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CabezasCompDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosCompDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PesoEntRealDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostosIndiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImpteCompDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaRecepcionCompraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdProveedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdLugarCompraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdCompradorGanadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdCorralDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumGuiasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImpteXguiaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StaCerradoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
