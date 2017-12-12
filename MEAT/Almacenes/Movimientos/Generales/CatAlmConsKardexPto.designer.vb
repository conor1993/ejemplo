<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CatAlmConsKardexPto
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
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label17 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmbSucursal = New System.Windows.Forms.ComboBox
        Me.lblsucursal = New System.Windows.Forms.Label
        Me.txtProducto = New System.Windows.Forms.TextBox
        Me.dtpFinal = New System.Windows.Forms.DateTimePicker
        Me.lblFechaFinal = New System.Windows.Forms.Label
        Me.lblFechaInicial = New System.Windows.Forms.Label
        Me.dtpInicial = New System.Windows.Forms.DateTimePicker
        Me.cmbAlmacen = New System.Windows.Forms.ComboBox
        Me.lblAlmacen = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGrid = New System.Windows.Forms.DataGridView
        Me.FechaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FolioColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MovtoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EntradaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SalidaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ExistenciaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostopColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.TxtExisActual = New System.Windows.Forms.TextBox
        Me.TxtSalidas = New System.Windows.Forms.TextBox
        Me.TxtEntrada = New System.Windows.Forms.TextBox
        Me.TxtExisInicial = New System.Windows.Forms.TextBox
        Me.TxtCostoInicial = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.TxtUnidad = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtLinea = New System.Windows.Forms.TextBox
        Me.CmbSublinea = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.CmbProducto = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmbPlaza = New System.Windows.Forms.ComboBox
        Me.PlazaCol = New ClasesNegocio.PlazaCollectionClass
        Me.Label1 = New System.Windows.Forms.Label
        Me.ProductoCol = New ClasesNegocio.ProductoCollectionClass
        Me.SubLineaCol = New ClasesNegocio.SubLineaCollectionClass
        Me.AlmacenCollectionClass1 = New ClasesNegocio.AlmacenCollectionClass
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
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
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = False
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 536)
        Me.mtb.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(53, 0)
        Me.Label17.MaximumSize = New System.Drawing.Size(1600, 900)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(923, 29)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "CONSULTA DE KARDEX DE PRODUCTOS"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.cmbSucursal)
        Me.Panel1.Controls.Add(Me.lblsucursal)
        Me.Panel1.Controls.Add(Me.txtProducto)
        Me.Panel1.Controls.Add(Me.dtpFinal)
        Me.Panel1.Controls.Add(Me.lblFechaFinal)
        Me.Panel1.Controls.Add(Me.lblFechaInicial)
        Me.Panel1.Controls.Add(Me.dtpInicial)
        Me.Panel1.Controls.Add(Me.cmbAlmacen)
        Me.Panel1.Controls.Add(Me.lblAlmacen)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.TxtUnidad)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TxtLinea)
        Me.Panel1.Controls.Add(Me.CmbSublinea)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.CmbProducto)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.CmbPlaza)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(56, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(911, 482)
        Me.Panel1.TabIndex = 2
        '
        'cmbSucursal
        '
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(87, 34)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(316, 21)
        Me.cmbSucursal.TabIndex = 116
        '
        'lblsucursal
        '
        Me.lblsucursal.AutoSize = True
        Me.lblsucursal.Location = New System.Drawing.Point(13, 37)
        Me.lblsucursal.Name = "lblsucursal"
        Me.lblsucursal.Size = New System.Drawing.Size(62, 13)
        Me.lblsucursal.TabIndex = 115
        Me.lblsucursal.Text = "Sucursales:"
        '
        'txtProducto
        '
        Me.txtProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProducto.Location = New System.Drawing.Point(87, 86)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(100, 20)
        Me.txtProducto.TabIndex = 114
        '
        'dtpFinal
        '
        Me.dtpFinal.CustomFormat = "MMM/yyyy"
        Me.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFinal.Location = New System.Drawing.Point(87, 203)
        Me.dtpFinal.Name = "dtpFinal"
        Me.dtpFinal.ShowUpDown = True
        Me.dtpFinal.Size = New System.Drawing.Size(89, 20)
        Me.dtpFinal.TabIndex = 113
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.AutoSize = True
        Me.lblFechaFinal.Location = New System.Drawing.Point(16, 203)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(62, 13)
        Me.lblFechaFinal.TabIndex = 112
        Me.lblFechaFinal.Text = "Fecha Final"
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.AutoSize = True
        Me.lblFechaInicial.Location = New System.Drawing.Point(13, 174)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(67, 13)
        Me.lblFechaInicial.TabIndex = 111
        Me.lblFechaInicial.Text = "Fecha Inicial"
        '
        'dtpInicial
        '
        Me.dtpInicial.CustomFormat = "MMM/yyyy"
        Me.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpInicial.Location = New System.Drawing.Point(87, 170)
        Me.dtpInicial.Name = "dtpInicial"
        Me.dtpInicial.ShowUpDown = True
        Me.dtpInicial.Size = New System.Drawing.Size(89, 20)
        Me.dtpInicial.TabIndex = 110
        '
        'cmbAlmacen
        '
        Me.cmbAlmacen.FormattingEnabled = True
        Me.cmbAlmacen.Location = New System.Drawing.Point(87, 59)
        Me.cmbAlmacen.Name = "cmbAlmacen"
        Me.cmbAlmacen.Size = New System.Drawing.Size(316, 21)
        Me.cmbAlmacen.TabIndex = 106
        '
        'lblAlmacen
        '
        Me.lblAlmacen.AutoSize = True
        Me.lblAlmacen.Location = New System.Drawing.Point(13, 62)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.Size = New System.Drawing.Size(51, 13)
        Me.lblAlmacen.TabIndex = 105
        Me.lblAlmacen.Text = "Almacen:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DataGrid)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 239)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(885, 230)
        Me.GroupBox1.TabIndex = 104
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de Movimientos"
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.AllowUserToResizeRows = False
        Me.DataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaColumn, Me.FolioColumn, Me.MovtoColumn, Me.EntradaColumn, Me.SalidaColumn, Me.ExistenciaColumn, Me.CostoColumn, Me.CostopColumn})
        Me.DataGrid.Location = New System.Drawing.Point(6, 19)
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        Me.DataGrid.Size = New System.Drawing.Size(863, 205)
        Me.DataGrid.TabIndex = 0
        '
        'FechaColumn
        '
        Me.FechaColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.FechaColumn.DataPropertyName = "fechamovimiento"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.FechaColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.FechaColumn.HeaderText = "Fecha Movimiento"
        Me.FechaColumn.Name = "FechaColumn"
        Me.FechaColumn.ReadOnly = True
        Me.FechaColumn.Width = 109
        '
        'FolioColumn
        '
        Me.FolioColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.FolioColumn.DataPropertyName = "FolioMovimiento"
        Me.FolioColumn.HeaderText = "Folio Movimiento"
        Me.FolioColumn.Name = "FolioColumn"
        Me.FolioColumn.ReadOnly = True
        Me.FolioColumn.Width = 102
        '
        'MovtoColumn
        '
        Me.MovtoColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.MovtoColumn.DataPropertyName = "movimiento"
        Me.MovtoColumn.HeaderText = "Movimiento"
        Me.MovtoColumn.Name = "MovtoColumn"
        Me.MovtoColumn.ReadOnly = True
        Me.MovtoColumn.Width = 86
        '
        'EntradaColumn
        '
        Me.EntradaColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.EntradaColumn.DataPropertyName = "entrada"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N4"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.EntradaColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.EntradaColumn.HeaderText = "Entrada"
        Me.EntradaColumn.Name = "EntradaColumn"
        Me.EntradaColumn.ReadOnly = True
        Me.EntradaColumn.Width = 69
        '
        'SalidaColumn
        '
        Me.SalidaColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SalidaColumn.DataPropertyName = "Salida"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N4"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.SalidaColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.SalidaColumn.HeaderText = "Salida"
        Me.SalidaColumn.Name = "SalidaColumn"
        Me.SalidaColumn.ReadOnly = True
        Me.SalidaColumn.Width = 61
        '
        'ExistenciaColumn
        '
        Me.ExistenciaColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ExistenciaColumn.DataPropertyName = "CantidadExistencia"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N4"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.ExistenciaColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.ExistenciaColumn.HeaderText = "Existencia"
        Me.ExistenciaColumn.Name = "ExistenciaColumn"
        Me.ExistenciaColumn.ReadOnly = True
        Me.ExistenciaColumn.Width = 80
        '
        'CostoColumn
        '
        Me.CostoColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CostoColumn.DataPropertyName = "Costo"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.CostoColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.CostoColumn.HeaderText = "Costo"
        Me.CostoColumn.Name = "CostoColumn"
        Me.CostoColumn.ReadOnly = True
        Me.CostoColumn.Width = 59
        '
        'CostopColumn
        '
        Me.CostopColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CostopColumn.DataPropertyName = "CostoPromedio"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.CostopColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.CostopColumn.HeaderText = "Costo Promedio"
        Me.CostopColumn.Name = "CostopColumn"
        Me.CostopColumn.ReadOnly = True
        Me.CostopColumn.Width = 97
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.TxtExisActual)
        Me.Panel2.Controls.Add(Me.TxtSalidas)
        Me.Panel2.Controls.Add(Me.TxtEntrada)
        Me.Panel2.Controls.Add(Me.TxtExisInicial)
        Me.Panel2.Controls.Add(Me.TxtCostoInicial)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Location = New System.Drawing.Point(635, 27)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(214, 161)
        Me.Panel2.TabIndex = 103
        '
        'TxtExisActual
        '
        Me.TxtExisActual.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtExisActual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtExisActual.Location = New System.Drawing.Point(108, 121)
        Me.TxtExisActual.MaxLength = 10
        Me.TxtExisActual.Name = "TxtExisActual"
        Me.TxtExisActual.Size = New System.Drawing.Size(94, 20)
        Me.TxtExisActual.TabIndex = 4
        Me.TxtExisActual.Text = "0"
        '
        'TxtSalidas
        '
        Me.TxtSalidas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSalidas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSalidas.Location = New System.Drawing.Point(108, 91)
        Me.TxtSalidas.MaxLength = 10
        Me.TxtSalidas.Name = "TxtSalidas"
        Me.TxtSalidas.Size = New System.Drawing.Size(94, 20)
        Me.TxtSalidas.TabIndex = 3
        Me.TxtSalidas.Text = "0"
        '
        'TxtEntrada
        '
        Me.TxtEntrada.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtEntrada.Location = New System.Drawing.Point(108, 65)
        Me.TxtEntrada.MaxLength = 10
        Me.TxtEntrada.Name = "TxtEntrada"
        Me.TxtEntrada.Size = New System.Drawing.Size(94, 20)
        Me.TxtEntrada.TabIndex = 2
        Me.TxtEntrada.Text = "0"
        '
        'TxtExisInicial
        '
        Me.TxtExisInicial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtExisInicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtExisInicial.Location = New System.Drawing.Point(108, 37)
        Me.TxtExisInicial.MaxLength = 10
        Me.TxtExisInicial.Name = "TxtExisInicial"
        Me.TxtExisInicial.Size = New System.Drawing.Size(94, 20)
        Me.TxtExisInicial.TabIndex = 1
        Me.TxtExisInicial.Text = "0"
        '
        'TxtCostoInicial
        '
        Me.TxtCostoInicial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCostoInicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCostoInicial.Location = New System.Drawing.Point(108, 10)
        Me.TxtCostoInicial.MaxLength = 10
        Me.TxtCostoInicial.Name = "TxtCostoInicial"
        Me.TxtCostoInicial.Size = New System.Drawing.Size(94, 20)
        Me.TxtCostoInicial.TabIndex = 0
        Me.TxtCostoInicial.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 13)
        Me.Label9.TabIndex = 108
        Me.Label9.Text = "Existencia Actual:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 13)
        Me.Label12.TabIndex = 105
        Me.Label12.Text = "Existencia Inicial:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 13)
        Me.Label10.TabIndex = 107
        Me.Label10.Text = "Total Salidas:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 13)
        Me.Label13.TabIndex = 104
        Me.Label13.Text = "Costo Inicial:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 13)
        Me.Label11.TabIndex = 106
        Me.Label11.Text = "Total Entradas:"
        '
        'TxtUnidad
        '
        Me.TxtUnidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtUnidad.Location = New System.Drawing.Point(277, 114)
        Me.TxtUnidad.MaxLength = 4
        Me.TxtUnidad.Name = "TxtUnidad"
        Me.TxtUnidad.Size = New System.Drawing.Size(118, 20)
        Me.TxtUnidad.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(227, 117)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = "Unidad:"
        '
        'TxtLinea
        '
        Me.TxtLinea.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtLinea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLinea.Location = New System.Drawing.Point(87, 114)
        Me.TxtLinea.MaxLength = 10
        Me.TxtLinea.Name = "TxtLinea"
        Me.TxtLinea.Size = New System.Drawing.Size(142, 20)
        Me.TxtLinea.TabIndex = 2
        '
        'CmbSublinea
        '
        Me.CmbSublinea.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbSublinea.FormattingEnabled = True
        Me.CmbSublinea.Location = New System.Drawing.Point(87, 143)
        Me.CmbSublinea.Name = "CmbSublinea"
        Me.CmbSublinea.Size = New System.Drawing.Size(316, 21)
        Me.CmbSublinea.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "Sub Linea:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "Linea:"
        '
        'CmbProducto
        '
        Me.CmbProducto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbProducto.FormattingEnabled = True
        Me.CmbProducto.Location = New System.Drawing.Point(193, 86)
        Me.CmbProducto.Name = "CmbProducto"
        Me.CmbProducto.Size = New System.Drawing.Size(210, 21)
        Me.CmbProducto.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Producto:"
        '
        'CmbPlaza
        '
        Me.CmbPlaza.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbPlaza.DataSource = Me.PlazaCol
        Me.CmbPlaza.DisplayMember = "Descripcion"
        Me.CmbPlaza.FormattingEnabled = True
        Me.CmbPlaza.Location = New System.Drawing.Point(87, 6)
        Me.CmbPlaza.Name = "CmbPlaza"
        Me.CmbPlaza.Size = New System.Drawing.Size(316, 21)
        Me.CmbPlaza.TabIndex = 0
        Me.CmbPlaza.ValueMember = "Codigo"
        '
        'PlazaCol
        '
        Me.PlazaCol.AllowEdit = True
        Me.PlazaCol.AllowNew = True
        Me.PlazaCol.AllowRemove = True
        Me.PlazaCol.Name = ""
        Me.PlazaCol.RaiseListChangedEvents = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Plaza:"
        '
        'ProductoCol
        '
        Me.ProductoCol.AllowEdit = True
        Me.ProductoCol.AllowNew = True
        Me.ProductoCol.AllowRemove = True
        Me.ProductoCol.Name = ""
        Me.ProductoCol.RaiseListChangedEvents = True
        '
        'SubLineaCol
        '
        Me.SubLineaCol.AllowEdit = True
        Me.SubLineaCol.AllowNew = True
        Me.SubLineaCol.AllowRemove = True
        Me.SubLineaCol.Name = ""
        Me.SubLineaCol.RaiseListChangedEvents = True
        '
        'AlmacenCollectionClass1
        '
        Me.AlmacenCollectionClass1.AllowEdit = True
        Me.AlmacenCollectionClass1.AllowNew = True
        Me.AlmacenCollectionClass1.AllowRemove = True
        Me.AlmacenCollectionClass1.Name = ""
        Me.AlmacenCollectionClass1.RaiseListChangedEvents = True
        Me.AlmacenCollectionClass1.Tipo = ClasesNegocio.AlmacenEnum.ALMACEN
        '
        'CatAlmConsKardexPto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 536)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.MinimumSize = New System.Drawing.Size(819, 505)
        Me.Name = "CatAlmConsKardexPto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Kardex de Productos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CmbProducto As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbPlaza As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtLinea As System.Windows.Forms.TextBox
    Friend WithEvents CmbSublinea As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TxtExisActual As System.Windows.Forms.TextBox
    Friend WithEvents TxtSalidas As System.Windows.Forms.TextBox
    Friend WithEvents TxtEntrada As System.Windows.Forms.TextBox
    Friend WithEvents TxtExisInicial As System.Windows.Forms.TextBox
    Friend WithEvents TxtCostoInicial As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtUnidad As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents PlazaCol As ClasesNegocio.PlazaCollectionClass
    Friend WithEvents ProductoCol As ClasesNegocio.ProductoCollectionClass
    Friend WithEvents SubLineaCol As ClasesNegocio.SubLineaCollectionClass
    Friend WithEvents AlmacenCollectionClass1 As ClasesNegocio.AlmacenCollectionClass
    Friend WithEvents cmbAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents lblAlmacen As System.Windows.Forms.Label
    Friend WithEvents lblFechaFinal As System.Windows.Forms.Label
    Friend WithEvents lblFechaInicial As System.Windows.Forms.Label
    Friend WithEvents dtpInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtProducto As System.Windows.Forms.TextBox
    Friend WithEvents cmbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents lblsucursal As System.Windows.Forms.Label
    Friend WithEvents FechaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FolioColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovtoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EntradaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SalidaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExistenciaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostopColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
