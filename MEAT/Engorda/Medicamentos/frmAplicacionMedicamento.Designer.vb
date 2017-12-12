<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAplicacionMedicamento
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.chkSeleccionAretes = New System.Windows.Forms.CheckBox
        Me.dgAretes = New System.Windows.Forms.DataGridView
        Me.SeleccionadoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.AretePropioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KilosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ImporteDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AplicacionMedicamentoDetalleDetalleCollectionClass1 = New ClasesNegocio.AplicacionMedicamentoDetalleDetalleCollectionClass
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgDetalle = New System.Windows.Forms.DataGridView
        Me.IdLoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.IdMedicamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.CantidadDetalleDataGridViewTextBox = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CorralDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AplicacionMedicamentoDetalleCollectionClass1 = New ClasesNegocio.AplicacionMedicamentoDetalleCollectionClass
        Me.dtFecha = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtFolio = New System.Windows.Forms.TextBox
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtSalidaAlmacen = New System.Windows.Forms.TextBox
        Me.gbTipoMedicamento = New System.Windows.Forms.GroupBox
        Me.rbTratamiento = New System.Windows.Forms.RadioButton
        Me.rbReimplante = New System.Windows.Forms.RadioButton
        Me.rbTrabajo = New System.Windows.Forms.RadioButton
        Me.btnBuscarSalidaMedicamento = New System.Windows.Forms.Button
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgAretes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTipoMedicamento.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.MaximumSize = New System.Drawing.Size(1600, 900)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(906, 29)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "APLICACIÓN DE MEDICAMENTOS"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.chkSeleccionAretes)
        Me.GroupBox3.Controls.Add(Me.dgAretes)
        Me.GroupBox3.Location = New System.Drawing.Point(56, 296)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(889, 262)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Prorrateo de medicamento"
        '
        'chkSeleccionAretes
        '
        Me.chkSeleccionAretes.AutoSize = True
        Me.chkSeleccionAretes.Location = New System.Drawing.Point(23, 24)
        Me.chkSeleccionAretes.Name = "chkSeleccionAretes"
        Me.chkSeleccionAretes.Size = New System.Drawing.Size(15, 14)
        Me.chkSeleccionAretes.TabIndex = 1
        Me.chkSeleccionAretes.UseVisualStyleBackColor = True
        '
        'dgAretes
        '
        Me.dgAretes.AllowUserToAddRows = False
        Me.dgAretes.AllowUserToDeleteRows = False
        Me.dgAretes.AllowUserToResizeColumns = False
        Me.dgAretes.AllowUserToResizeRows = False
        Me.dgAretes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgAretes.AutoGenerateColumns = False
        Me.dgAretes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAretes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SeleccionadoDataGridViewCheckBoxColumn, Me.AretePropioDataGridViewTextBoxColumn, Me.KilosDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn1, Me.CostoDataGridViewTextBoxColumn1, Me.ImporteDataGridViewTextBoxColumn1})
        Me.dgAretes.DataSource = Me.AplicacionMedicamentoDetalleDetalleCollectionClass1
        Me.dgAretes.Location = New System.Drawing.Point(6, 19)
        Me.dgAretes.MultiSelect = False
        Me.dgAretes.Name = "dgAretes"
        Me.dgAretes.ReadOnly = True
        Me.dgAretes.RowHeadersVisible = False
        Me.dgAretes.Size = New System.Drawing.Size(877, 237)
        Me.dgAretes.TabIndex = 0
        '
        'SeleccionadoDataGridViewCheckBoxColumn
        '
        Me.SeleccionadoDataGridViewCheckBoxColumn.DataPropertyName = "Seleccionado"
        Me.SeleccionadoDataGridViewCheckBoxColumn.Frozen = True
        Me.SeleccionadoDataGridViewCheckBoxColumn.HeaderText = ""
        Me.SeleccionadoDataGridViewCheckBoxColumn.MinimumWidth = 45
        Me.SeleccionadoDataGridViewCheckBoxColumn.Name = "SeleccionadoDataGridViewCheckBoxColumn"
        Me.SeleccionadoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.SeleccionadoDataGridViewCheckBoxColumn.Width = 45
        '
        'AretePropioDataGridViewTextBoxColumn
        '
        Me.AretePropioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.AretePropioDataGridViewTextBoxColumn.DataPropertyName = "AretePropio"
        Me.AretePropioDataGridViewTextBoxColumn.HeaderText = "AretePropio"
        Me.AretePropioDataGridViewTextBoxColumn.Name = "AretePropioDataGridViewTextBoxColumn"
        Me.AretePropioDataGridViewTextBoxColumn.ReadOnly = True
        Me.AretePropioDataGridViewTextBoxColumn.Width = 85
        '
        'KilosDataGridViewTextBoxColumn
        '
        Me.KilosDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.KilosDataGridViewTextBoxColumn.DataPropertyName = "Kilos"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N3"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.KilosDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.KilosDataGridViewTextBoxColumn.HeaderText = "Kilos"
        Me.KilosDataGridViewTextBoxColumn.Name = "KilosDataGridViewTextBoxColumn"
        Me.KilosDataGridViewTextBoxColumn.ReadOnly = True
        Me.KilosDataGridViewTextBoxColumn.Width = 52
        '
        'CantidadDataGridViewTextBoxColumn1
        '
        Me.CantidadDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CantidadDataGridViewTextBoxColumn1.DataPropertyName = "Cantidad"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N3"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.CantidadDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.CantidadDataGridViewTextBoxColumn1.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn1.Name = "CantidadDataGridViewTextBoxColumn1"
        Me.CantidadDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CantidadDataGridViewTextBoxColumn1.Width = 72
        '
        'CostoDataGridViewTextBoxColumn1
        '
        Me.CostoDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CostoDataGridViewTextBoxColumn1.DataPropertyName = "Costo"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.CostoDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle3
        Me.CostoDataGridViewTextBoxColumn1.HeaderText = "Costo"
        Me.CostoDataGridViewTextBoxColumn1.Name = "CostoDataGridViewTextBoxColumn1"
        Me.CostoDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CostoDataGridViewTextBoxColumn1.Width = 57
        '
        'ImporteDataGridViewTextBoxColumn1
        '
        Me.ImporteDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ImporteDataGridViewTextBoxColumn1.DataPropertyName = "Importe"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.ImporteDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle4
        Me.ImporteDataGridViewTextBoxColumn1.HeaderText = "Importe"
        Me.ImporteDataGridViewTextBoxColumn1.Name = "ImporteDataGridViewTextBoxColumn1"
        Me.ImporteDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ImporteDataGridViewTextBoxColumn1.Width = 65
        '
        'AplicacionMedicamentoDetalleDetalleCollectionClass1
        '
        Me.AplicacionMedicamentoDetalleDetalleCollectionClass1.AllowEdit = True
        Me.AplicacionMedicamentoDetalleDetalleCollectionClass1.AllowNew = True
        Me.AplicacionMedicamentoDetalleDetalleCollectionClass1.AllowRemove = True
        Me.AplicacionMedicamentoDetalleDetalleCollectionClass1.MaximoElementosSeleccionados = 1
        Me.AplicacionMedicamentoDetalleDetalleCollectionClass1.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.AplicacionMedicamentoDetalleDetalleCollectionClass1.MostrarAlertas = False
        Me.AplicacionMedicamentoDetalleDetalleCollectionClass1.Name = Nothing
        Me.AplicacionMedicamentoDetalleDetalleCollectionClass1.RaiseListChangedEvents = True
        Me.AplicacionMedicamentoDetalleDetalleCollectionClass1.Transaction = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgDetalle)
        Me.GroupBox1.Location = New System.Drawing.Point(55, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(889, 198)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Medicamentos a aplicar"
        '
        'dgDetalle
        '
        Me.dgDetalle.AllowUserToDeleteRows = False
        Me.dgDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDetalle.AutoGenerateColumns = False
        Me.dgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdLoteDataGridViewTextBoxColumn, Me.IdMedicamentoDataGridViewTextBoxColumn, Me.CantidadDetalleDataGridViewTextBox, Me.CostoDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn, Me.CorralDataGridViewTextBoxColumn})
        Me.dgDetalle.DataSource = Me.AplicacionMedicamentoDetalleCollectionClass1
        Me.dgDetalle.Location = New System.Drawing.Point(6, 19)
        Me.dgDetalle.MultiSelect = False
        Me.dgDetalle.Name = "dgDetalle"
        Me.dgDetalle.ReadOnly = True
        Me.dgDetalle.Size = New System.Drawing.Size(877, 173)
        Me.dgDetalle.TabIndex = 0
        '
        'IdLoteDataGridViewTextBoxColumn
        '
        Me.IdLoteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.IdLoteDataGridViewTextBoxColumn.DataPropertyName = "IdLote"
        Me.IdLoteDataGridViewTextBoxColumn.HeaderText = "Lote"
        Me.IdLoteDataGridViewTextBoxColumn.Name = "IdLoteDataGridViewTextBoxColumn"
        Me.IdLoteDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdLoteDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IdLoteDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.IdLoteDataGridViewTextBoxColumn.Width = 51
        '
        'IdMedicamentoDataGridViewTextBoxColumn
        '
        Me.IdMedicamentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.IdMedicamentoDataGridViewTextBoxColumn.DataPropertyName = "IdMedicamento"
        Me.IdMedicamentoDataGridViewTextBoxColumn.HeaderText = "Medicamento"
        Me.IdMedicamentoDataGridViewTextBoxColumn.Name = "IdMedicamentoDataGridViewTextBoxColumn"
        Me.IdMedicamentoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdMedicamentoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IdMedicamentoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.IdMedicamentoDataGridViewTextBoxColumn.Width = 94
        '
        'CantidadDetalleDataGridViewTextBox
        '
        Me.CantidadDetalleDataGridViewTextBox.DataPropertyName = "Cantidad"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N3"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.CantidadDetalleDataGridViewTextBox.DefaultCellStyle = DataGridViewCellStyle5
        Me.CantidadDetalleDataGridViewTextBox.HeaderText = "Cantidad"
        Me.CantidadDetalleDataGridViewTextBox.Name = "CantidadDetalleDataGridViewTextBox"
        Me.CantidadDetalleDataGridViewTextBox.ReadOnly = True
        '
        'CostoDataGridViewTextBoxColumn
        '
        Me.CostoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CostoDataGridViewTextBoxColumn.DataPropertyName = "Costo"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.CostoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.CostoDataGridViewTextBoxColumn.HeaderText = "Costo"
        Me.CostoDataGridViewTextBoxColumn.Name = "CostoDataGridViewTextBoxColumn"
        Me.CostoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CostoDataGridViewTextBoxColumn.Width = 57
        '
        'ImporteDataGridViewTextBoxColumn
        '
        Me.ImporteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "Importe"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.ImporteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
        Me.ImporteDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImporteDataGridViewTextBoxColumn.Width = 65
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
        'AplicacionMedicamentoDetalleCollectionClass1
        '
        Me.AplicacionMedicamentoDetalleCollectionClass1.AllowEdit = True
        Me.AplicacionMedicamentoDetalleCollectionClass1.AllowNew = True
        Me.AplicacionMedicamentoDetalleCollectionClass1.AllowRemove = True
        Me.AplicacionMedicamentoDetalleCollectionClass1.MaximoElementosSeleccionados = 1
        Me.AplicacionMedicamentoDetalleCollectionClass1.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.AplicacionMedicamentoDetalleCollectionClass1.MostrarAlertas = False
        Me.AplicacionMedicamentoDetalleCollectionClass1.Name = Nothing
        Me.AplicacionMedicamentoDetalleCollectionClass1.RaiseListChangedEvents = True
        Me.AplicacionMedicamentoDetalleCollectionClass1.Transaction = Nothing
        '
        'dtFecha
        '
        Me.dtFecha.CustomFormat = "dd/MMM/yyyy"
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFecha.Location = New System.Drawing.Point(304, 39)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(98, 20)
        Me.dtFecha.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(243, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Fecha:"
        '
        'txtFolio
        '
        Me.txtFolio.Enabled = False
        Me.txtFolio.Location = New System.Drawing.Point(100, 40)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(137, 20)
        Me.txtFolio.TabIndex = 19
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
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 570)
        Me.mtb.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Folio:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(58, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Salida de Almacén:"
        '
        'txtSalidaAlmacen
        '
        Me.txtSalidaAlmacen.Enabled = False
        Me.txtSalidaAlmacen.Location = New System.Drawing.Point(162, 66)
        Me.txtSalidaAlmacen.Name = "txtSalidaAlmacen"
        Me.txtSalidaAlmacen.Size = New System.Drawing.Size(180, 20)
        Me.txtSalidaAlmacen.TabIndex = 33
        '
        'gbTipoMedicamento
        '
        Me.gbTipoMedicamento.Controls.Add(Me.rbTratamiento)
        Me.gbTipoMedicamento.Controls.Add(Me.rbReimplante)
        Me.gbTipoMedicamento.Controls.Add(Me.rbTrabajo)
        Me.gbTipoMedicamento.Location = New System.Drawing.Point(696, 35)
        Me.gbTipoMedicamento.Name = "gbTipoMedicamento"
        Me.gbTipoMedicamento.Size = New System.Drawing.Size(248, 51)
        Me.gbTipoMedicamento.TabIndex = 34
        Me.gbTipoMedicamento.TabStop = False
        '
        'rbTratamiento
        '
        Me.rbTratamiento.AutoSize = True
        Me.rbTratamiento.Location = New System.Drawing.Point(157, 19)
        Me.rbTratamiento.Name = "rbTratamiento"
        Me.rbTratamiento.Size = New System.Drawing.Size(81, 17)
        Me.rbTratamiento.TabIndex = 2
        Me.rbTratamiento.Text = "Tratamiento"
        Me.rbTratamiento.UseVisualStyleBackColor = True
        '
        'rbReimplante
        '
        Me.rbReimplante.AutoSize = True
        Me.rbReimplante.Location = New System.Drawing.Point(73, 19)
        Me.rbReimplante.Name = "rbReimplante"
        Me.rbReimplante.Size = New System.Drawing.Size(78, 17)
        Me.rbReimplante.TabIndex = 1
        Me.rbReimplante.Text = "Reimplante"
        Me.rbReimplante.UseVisualStyleBackColor = True
        '
        'rbTrabajo
        '
        Me.rbTrabajo.AutoSize = True
        Me.rbTrabajo.Checked = True
        Me.rbTrabajo.Location = New System.Drawing.Point(6, 19)
        Me.rbTrabajo.Name = "rbTrabajo"
        Me.rbTrabajo.Size = New System.Drawing.Size(61, 17)
        Me.rbTrabajo.TabIndex = 0
        Me.rbTrabajo.TabStop = True
        Me.rbTrabajo.Text = "Trabajo"
        Me.rbTrabajo.UseVisualStyleBackColor = True
        '
        'btnBuscarSalidaMedicamento
        '
        Me.btnBuscarSalidaMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscarSalidaMedicamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarSalidaMedicamento.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscarSalidaMedicamento.Location = New System.Drawing.Point(348, 66)
        Me.btnBuscarSalidaMedicamento.Name = "btnBuscarSalidaMedicamento"
        Me.btnBuscarSalidaMedicamento.Size = New System.Drawing.Size(54, 20)
        Me.btnBuscarSalidaMedicamento.TabIndex = 35
        Me.btnBuscarSalidaMedicamento.Text = "Buscar"
        Me.btnBuscarSalidaMedicamento.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Contenedor"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N3"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn1.HeaderText = "Contenedor"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Costo"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "C2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn2.HeaderText = "Costo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Importe"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "C2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn3.HeaderText = "Importe"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Corral"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Corral"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "AretePropio"
        Me.DataGridViewTextBoxColumn5.HeaderText = "AretePropio"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Kilos"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N3"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn6.HeaderText = "Kilos"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Cantidad"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N3"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn7.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Costo"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "C2"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn8.HeaderText = "Costo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Importe"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "C2"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn9.HeaderText = "Importe"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'frmAplicacionMedicamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 570)
        Me.Controls.Add(Me.btnBuscarSalidaMedicamento)
        Me.Controls.Add(Me.gbTipoMedicamento)
        Me.Controls.Add(Me.txtSalidaAlmacen)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "frmAplicacionMedicamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplicación de Medicamentos"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgAretes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTipoMedicamento.ResumeLayout(False)
        Me.gbTipoMedicamento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgAretes As System.Windows.Forms.DataGridView
    Friend WithEvents dgDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSalidaAlmacen As System.Windows.Forms.TextBox
    Friend WithEvents gbTipoMedicamento As System.Windows.Forms.GroupBox
    Friend WithEvents rbReimplante As System.Windows.Forms.RadioButton
    Friend WithEvents rbTrabajo As System.Windows.Forms.RadioButton
    Friend WithEvents rbTratamiento As System.Windows.Forms.RadioButton
    Friend WithEvents AplicacionMedicamentoDetalleCollectionClass1 As ClasesNegocio.AplicacionMedicamentoDetalleCollectionClass
    Friend WithEvents btnBuscarSalidaMedicamento As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AplicacionMedicamentoDetalleDetalleCollectionClass1 As ClasesNegocio.AplicacionMedicamentoDetalleDetalleCollectionClass
    Friend WithEvents chkSeleccionAretes As System.Windows.Forms.CheckBox
    Friend WithEvents SeleccionadoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents AretePropioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdLoteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents IdMedicamentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents CantidadDetalleDataGridViewTextBox As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CorralDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
