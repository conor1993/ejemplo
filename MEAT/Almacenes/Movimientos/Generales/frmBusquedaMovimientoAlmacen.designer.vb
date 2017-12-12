<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaMovimientoAlmacen
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Entradas")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Salidas")
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtFolioMovimeintoAlmacen = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.dgMovimientosAlmacen = New System.Windows.Forms.DataGridView
        Me.FolioMovimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AlmacenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoMovimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReferenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OrigenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EntregaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RecibeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostoTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AfectaCostoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaMovimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdAlmacenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.movimientosAlmacen = New Integralab.ORM.TypedViewClasses.VwBusquedaMovimientosAlmacenTypedView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.gbRangoFechas = New System.Windows.Forms.GroupBox
        Me.dtFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.dtFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.chkFiltrarFechas = New System.Windows.Forms.CheckBox
        Me.tvTipoMovimientos = New System.Windows.Forms.TreeView
        Me.Label7 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.txtRecibe = New Integralab.Controles.TextBoxMejorado
        Me.txtEntrega = New Integralab.Controles.TextBoxMejorado
        Me.cmbAlmacen = New Integralab.Controles.ComboBoxMejorado
        Me.txtCodigoAlmacen = New Integralab.Controles.TextBoxMejorado
        CType(Me.dgMovimientosAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.movimientosAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbRangoFechas.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Almacén:"
        '
        'txtFolioMovimeintoAlmacen
        '
        Me.txtFolioMovimeintoAlmacen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFolioMovimeintoAlmacen.Location = New System.Drawing.Point(105, 38)
        Me.txtFolioMovimeintoAlmacen.MaxLength = 20
        Me.txtFolioMovimeintoAlmacen.Name = "txtFolioMovimeintoAlmacen"
        Me.txtFolioMovimeintoAlmacen.Size = New System.Drawing.Size(163, 20)
        Me.txtFolioMovimeintoAlmacen.TabIndex = 79
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Folio:"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(922, 29)
        Me.Label17.TabIndex = 77
        Me.Label17.Text = "BUSQUEDA MOVIMIENTOS DE ALMACÉN"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Location = New System.Drawing.Point(885, 579)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 85
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Location = New System.Drawing.Point(804, 579)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 84
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'dgMovimientosAlmacen
        '
        Me.dgMovimientosAlmacen.AllowUserToAddRows = False
        Me.dgMovimientosAlmacen.AllowUserToDeleteRows = False
        Me.dgMovimientosAlmacen.AllowUserToResizeRows = False
        Me.dgMovimientosAlmacen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgMovimientosAlmacen.AutoGenerateColumns = False
        Me.dgMovimientosAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMovimientosAlmacen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FolioMovimientoDataGridViewTextBoxColumn, Me.AlmacenDataGridViewTextBoxColumn, Me.TipoMovimientoDataGridViewTextBoxColumn, Me.ReferenciaDataGridViewTextBoxColumn, Me.OrigenDataGridViewTextBoxColumn, Me.EntregaDataGridViewTextBoxColumn, Me.RecibeDataGridViewTextBoxColumn, Me.CostoTotalDataGridViewTextBoxColumn, Me.AfectaCostoDataGridViewCheckBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.FechaMovimientoDataGridViewTextBoxColumn, Me.IdAlmacenDataGridViewTextBoxColumn})
        Me.dgMovimientosAlmacen.DataSource = Me.movimientosAlmacen
        Me.dgMovimientosAlmacen.Location = New System.Drawing.Point(6, 19)
        Me.dgMovimientosAlmacen.MultiSelect = False
        Me.dgMovimientosAlmacen.Name = "dgMovimientosAlmacen"
        Me.dgMovimientosAlmacen.ReadOnly = True
        Me.dgMovimientosAlmacen.RowHeadersVisible = False
        Me.dgMovimientosAlmacen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMovimientosAlmacen.Size = New System.Drawing.Size(897, 349)
        Me.dgMovimientosAlmacen.TabIndex = 0
        '
        'FolioMovimientoDataGridViewTextBoxColumn
        '
        Me.FolioMovimientoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.FolioMovimientoDataGridViewTextBoxColumn.DataPropertyName = "FolioMovimiento"
        Me.FolioMovimientoDataGridViewTextBoxColumn.HeaderText = "Folio Movimiento"
        Me.FolioMovimientoDataGridViewTextBoxColumn.Name = "FolioMovimientoDataGridViewTextBoxColumn"
        Me.FolioMovimientoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AlmacenDataGridViewTextBoxColumn
        '
        Me.AlmacenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.AlmacenDataGridViewTextBoxColumn.DataPropertyName = "Almacen"
        Me.AlmacenDataGridViewTextBoxColumn.HeaderText = "Almacen"
        Me.AlmacenDataGridViewTextBoxColumn.Name = "AlmacenDataGridViewTextBoxColumn"
        Me.AlmacenDataGridViewTextBoxColumn.ReadOnly = True
        Me.AlmacenDataGridViewTextBoxColumn.Width = 71
        '
        'TipoMovimientoDataGridViewTextBoxColumn
        '
        Me.TipoMovimientoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TipoMovimientoDataGridViewTextBoxColumn.DataPropertyName = "TipoMovimiento"
        Me.TipoMovimientoDataGridViewTextBoxColumn.HeaderText = "Tipo Movimiento"
        Me.TipoMovimientoDataGridViewTextBoxColumn.Name = "TipoMovimientoDataGridViewTextBoxColumn"
        Me.TipoMovimientoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoMovimientoDataGridViewTextBoxColumn.Width = 99
        '
        'ReferenciaDataGridViewTextBoxColumn
        '
        Me.ReferenciaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ReferenciaDataGridViewTextBoxColumn.DataPropertyName = "Referencia"
        Me.ReferenciaDataGridViewTextBoxColumn.HeaderText = "Referencia"
        Me.ReferenciaDataGridViewTextBoxColumn.Name = "ReferenciaDataGridViewTextBoxColumn"
        Me.ReferenciaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ReferenciaDataGridViewTextBoxColumn.Width = 82
        '
        'OrigenDataGridViewTextBoxColumn
        '
        Me.OrigenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.OrigenDataGridViewTextBoxColumn.DataPropertyName = "Origen"
        Me.OrigenDataGridViewTextBoxColumn.HeaderText = "Origen"
        Me.OrigenDataGridViewTextBoxColumn.Name = "OrigenDataGridViewTextBoxColumn"
        Me.OrigenDataGridViewTextBoxColumn.ReadOnly = True
        Me.OrigenDataGridViewTextBoxColumn.Width = 61
        '
        'EntregaDataGridViewTextBoxColumn
        '
        Me.EntregaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.EntregaDataGridViewTextBoxColumn.DataPropertyName = "Entrega"
        Me.EntregaDataGridViewTextBoxColumn.HeaderText = "Entrega"
        Me.EntregaDataGridViewTextBoxColumn.Name = "EntregaDataGridViewTextBoxColumn"
        Me.EntregaDataGridViewTextBoxColumn.ReadOnly = True
        Me.EntregaDataGridViewTextBoxColumn.Width = 67
        '
        'RecibeDataGridViewTextBoxColumn
        '
        Me.RecibeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.RecibeDataGridViewTextBoxColumn.DataPropertyName = "Recibe"
        Me.RecibeDataGridViewTextBoxColumn.HeaderText = "Recibe"
        Me.RecibeDataGridViewTextBoxColumn.Name = "RecibeDataGridViewTextBoxColumn"
        Me.RecibeDataGridViewTextBoxColumn.ReadOnly = True
        Me.RecibeDataGridViewTextBoxColumn.Width = 64
        '
        'CostoTotalDataGridViewTextBoxColumn
        '
        Me.CostoTotalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CostoTotalDataGridViewTextBoxColumn.DataPropertyName = "CostoTotal"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.CostoTotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.CostoTotalDataGridViewTextBoxColumn.HeaderText = "Costo Total"
        Me.CostoTotalDataGridViewTextBoxColumn.Name = "CostoTotalDataGridViewTextBoxColumn"
        Me.CostoTotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.CostoTotalDataGridViewTextBoxColumn.Width = 77
        '
        'AfectaCostoDataGridViewCheckBoxColumn
        '
        Me.AfectaCostoDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.AfectaCostoDataGridViewCheckBoxColumn.DataPropertyName = "AfectaCosto"
        Me.AfectaCostoDataGridViewCheckBoxColumn.HeaderText = "Afecta Costo"
        Me.AfectaCostoDataGridViewCheckBoxColumn.Name = "AfectaCostoDataGridViewCheckBoxColumn"
        Me.AfectaCostoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.AfectaCostoDataGridViewCheckBoxColumn.Width = 65
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "DireccionStr"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DireccionDataGridViewTextBoxColumn.Width = 75
        '
        'FechaMovimientoDataGridViewTextBoxColumn
        '
        Me.FechaMovimientoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.FechaMovimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaMovimiento"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.FechaMovimientoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.FechaMovimientoDataGridViewTextBoxColumn.HeaderText = "Fecha Movimiento"
        Me.FechaMovimientoDataGridViewTextBoxColumn.Name = "FechaMovimientoDataGridViewTextBoxColumn"
        Me.FechaMovimientoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaMovimientoDataGridViewTextBoxColumn.Width = 107
        '
        'IdAlmacenDataGridViewTextBoxColumn
        '
        Me.IdAlmacenDataGridViewTextBoxColumn.DataPropertyName = "IdAlmacen"
        Me.IdAlmacenDataGridViewTextBoxColumn.HeaderText = "IdAlmacen"
        Me.IdAlmacenDataGridViewTextBoxColumn.Name = "IdAlmacenDataGridViewTextBoxColumn"
        Me.IdAlmacenDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdAlmacenDataGridViewTextBoxColumn.Visible = False
        '
        'movimientosAlmacen
        '
        Me.movimientosAlmacen.TableName = "VwBusquedaMovimientosAlmacen"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgMovimientosAlmacen)
        Me.GroupBox1.Location = New System.Drawing.Point(51, 199)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(909, 374)
        Me.GroupBox1.TabIndex = 82
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resultado de la Busqueda"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Entrega:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Recibe:"
        '
        'gbRangoFechas
        '
        Me.gbRangoFechas.Controls.Add(Me.dtFechaFinal)
        Me.gbRangoFechas.Controls.Add(Me.dtFechaInicial)
        Me.gbRangoFechas.Controls.Add(Me.Label6)
        Me.gbRangoFechas.Controls.Add(Me.Label5)
        Me.gbRangoFechas.Enabled = False
        Me.gbRangoFechas.Location = New System.Drawing.Point(146, 143)
        Me.gbRangoFechas.Name = "gbRangoFechas"
        Me.gbRangoFechas.Size = New System.Drawing.Size(251, 50)
        Me.gbRangoFechas.TabIndex = 93
        Me.gbRangoFechas.TabStop = False
        Me.gbRangoFechas.Text = "Rango de Fechas"
        '
        'dtFechaFinal
        '
        Me.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaFinal.Location = New System.Drawing.Point(149, 19)
        Me.dtFechaFinal.Name = "dtFechaFinal"
        Me.dtFechaFinal.Size = New System.Drawing.Size(92, 20)
        Me.dtFechaFinal.TabIndex = 3
        '
        'dtFechaInicial
        '
        Me.dtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaInicial.Location = New System.Drawing.Point(35, 19)
        Me.dtFechaInicial.Name = "dtFechaInicial"
        Me.dtFechaInicial.Size = New System.Drawing.Size(92, 20)
        Me.dtFechaInicial.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(130, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "a"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "De"
        '
        'chkFiltrarFechas
        '
        Me.chkFiltrarFechas.AutoSize = True
        Me.chkFiltrarFechas.Location = New System.Drawing.Point(51, 143)
        Me.chkFiltrarFechas.Name = "chkFiltrarFechas"
        Me.chkFiltrarFechas.Size = New System.Drawing.Size(89, 17)
        Me.chkFiltrarFechas.TabIndex = 94
        Me.chkFiltrarFechas.Text = "Filtrar Fechas"
        Me.chkFiltrarFechas.UseVisualStyleBackColor = True
        '
        'tvTipoMovimientos
        '
        Me.tvTipoMovimientos.CheckBoxes = True
        Me.tvTipoMovimientos.FullRowSelect = True
        Me.tvTipoMovimientos.Location = New System.Drawing.Point(527, 52)
        Me.tvTipoMovimientos.Name = "tvTipoMovimientos"
        TreeNode1.Checked = True
        TreeNode1.Name = "ndEntradas"
        TreeNode1.Text = "Entradas"
        TreeNode1.ToolTipText = "Tipos de entradas al almacén"
        TreeNode2.Checked = True
        TreeNode2.Name = "ndSalidas"
        TreeNode2.Text = "Salidas"
        TreeNode2.ToolTipText = "Tipo de salidas de almacén"
        Me.tvTipoMovimientos.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Me.tvTipoMovimientos.Size = New System.Drawing.Size(433, 141)
        Me.tvTipoMovimientos.TabIndex = 95
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(527, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(433, 11)
        Me.Label7.TabIndex = 96
        Me.Label7.Text = "Tipo Movimientos de Almacén"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.mtb.Size = New System.Drawing.Size(50, 614)
        Me.mtb.TabIndex = 76
        '
        'txtRecibe
        '
        Me.txtRecibe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRecibe.ComboBoxEnlazado = Nothing
        Me.txtRecibe.Decimales = 0
        Me.txtRecibe.Location = New System.Drawing.Point(105, 117)
        Me.txtRecibe.MensajeCombo = "Seleccionar un item..."
        Me.txtRecibe.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtRecibe.Name = "txtRecibe"
        Me.txtRecibe.SiguienteControl = Nothing
        Me.txtRecibe.Size = New System.Drawing.Size(416, 20)
        Me.txtRecibe.TabIndex = 91
        Me.txtRecibe.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtRecibe.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtRecibe.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtEntrega
        '
        Me.txtEntrega.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEntrega.ComboBoxEnlazado = Nothing
        Me.txtEntrega.Decimales = 0
        Me.txtEntrega.Location = New System.Drawing.Point(105, 91)
        Me.txtEntrega.MensajeCombo = "Seleccionar un item..."
        Me.txtEntrega.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtEntrega.Name = "txtEntrega"
        Me.txtEntrega.SiguienteControl = Nothing
        Me.txtEntrega.Size = New System.Drawing.Size(416, 20)
        Me.txtEntrega.TabIndex = 89
        Me.txtEntrega.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtEntrega.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtEntrega.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cmbAlmacen
        '
        Me.cmbAlmacen.FormattingEnabled = True
        Me.cmbAlmacen.Location = New System.Drawing.Point(162, 64)
        Me.cmbAlmacen.Name = "cmbAlmacen"
        Me.cmbAlmacen.NombreMetodo = Nothing
        Me.cmbAlmacen.Parametros = Nothing
        Me.cmbAlmacen.SiguienteControl = Nothing
        Me.cmbAlmacen.Size = New System.Drawing.Size(359, 21)
        Me.cmbAlmacen.TabIndex = 88
        Me.cmbAlmacen.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbAlmacen.TextBoxEnlazado = Nothing
        '
        'txtCodigoAlmacen
        '
        Me.txtCodigoAlmacen.ComboBoxEnlazado = Me.cmbAlmacen
        Me.txtCodigoAlmacen.Decimales = 0
        Me.txtCodigoAlmacen.Location = New System.Drawing.Point(105, 64)
        Me.txtCodigoAlmacen.MaxLength = 3000
        Me.txtCodigoAlmacen.MensajeCombo = "Seleccionar un almacén..."
        Me.txtCodigoAlmacen.MensajeNoExiste = "No existe un almacén con este código o se encuentra inactivo"
        Me.txtCodigoAlmacen.Name = "txtCodigoAlmacen"
        Me.txtCodigoAlmacen.SiguienteControl = Nothing
        Me.txtCodigoAlmacen.Size = New System.Drawing.Size(51, 20)
        Me.txtCodigoAlmacen.TabIndex = 87
        Me.txtCodigoAlmacen.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtCodigoAlmacen.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCodigoAlmacen.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'frmBusquedaMovimientoAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 614)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tvTipoMovimientos)
        Me.Controls.Add(Me.chkFiltrarFechas)
        Me.Controls.Add(Me.gbRangoFechas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtRecibe)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEntrega)
        Me.Controls.Add(Me.cmbAlmacen)
        Me.Controls.Add(Me.txtCodigoAlmacen)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFolioMovimeintoAlmacen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmBusquedaMovimientoAlmacen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda Movimientos de Almacén"
        CType(Me.dgMovimientosAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.movimientosAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.gbRangoFechas.ResumeLayout(False)
        Me.gbRangoFechas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    'Friend WithEvents AlmacenC As ClasesNegocio.AlmacenCollectionClass
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFolioMovimeintoAlmacen As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents dgMovimientosAlmacen As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodigoAlmacen As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents cmbAlmacen As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents txtEntrega As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRecibe As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents gbRangoFechas As System.Windows.Forms.GroupBox
    Friend WithEvents dtFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkFiltrarFechas As System.Windows.Forms.CheckBox
    Friend WithEvents tvTipoMovimientos As System.Windows.Forms.TreeView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents movimientosAlmacen As IntegraLab.ORM.TypedViewClasses.VwBusquedaMovimientosAlmacenTypedView
    Friend WithEvents FolioMovimientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlmacenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoMovimientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReferenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrigenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EntregaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RecibeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoTotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AfectaCostoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaMovimientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdAlmacenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
