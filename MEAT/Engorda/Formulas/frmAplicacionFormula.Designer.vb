<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAplicacionFormula
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
        Me.Label17 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtFolio = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtFecha = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgDetalle = New System.Windows.Forms.DataGridView
        Me.IdCorralDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CorralDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.listaCorrales = New Integralab.ORM.TypedListClasses.ListaCorralesTypedList
        Me.LoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdFormulaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FormulaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.listaFormulas = New Integralab.ORM.TypedListClasses.ProductosGeneralesTypedList
        Me.LoteAlmacenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadServida1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadServida2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadServida3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadServida4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalServidasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AplicacionFormulaDetalleC = New ClasesNegocio.AplicacionFormulaDetalleCollectionClass
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtNumLotes = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtNumCorrales = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCabezas = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dgFormulas = New System.Windows.Forms.DataGridView
        Me.FormulaListaFormulasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadListaFormulasDataGridViewColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtEstimadoPorFormula = New System.Windows.Forms.TextBox
        Me.txtTotalServidas = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtCodigoAlmacen = New Integralab.Controles.TextBoxMejorado
        Me.cmbAlmacen = New Integralab.Controles.ComboBoxMejorado
        Me.chkSoloFormulas = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listaCorrales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listaFormulas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgFormulas, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label17.Size = New System.Drawing.Size(908, 29)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "APLICACIÓN DE FORMULAS"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.mtb.Size = New System.Drawing.Size(50, 572)
        Me.mtb.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Folio:"
        '
        'txtFolio
        '
        Me.txtFolio.Enabled = False
        Me.txtFolio.Location = New System.Drawing.Point(100, 40)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(137, 20)
        Me.txtFolio.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(243, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha:"
        '
        'dtFecha
        '
        Me.dtFecha.CustomFormat = "dd/MMM/yyyy"
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFecha.Location = New System.Drawing.Point(295, 40)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(110, 20)
        Me.dtFecha.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgDetalle)
        Me.GroupBox1.Location = New System.Drawing.Point(55, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(891, 310)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles de Aplicaciones"
        '
        'dgDetalle
        '
        Me.dgDetalle.AllowUserToDeleteRows = False
        Me.dgDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDetalle.AutoGenerateColumns = False
        Me.dgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCorralDataGridViewTextBoxColumn, Me.CorralDataGridViewTextBoxColumn, Me.LoteDataGridViewTextBoxColumn, Me.IdFormulaDataGridViewTextBoxColumn, Me.FormulaDataGridViewTextBoxColumn, Me.LoteAlmacenDataGridViewTextBoxColumn, Me.CantidadServida1DataGridViewTextBoxColumn, Me.CantidadServida2DataGridViewTextBoxColumn, Me.CantidadServida3DataGridViewTextBoxColumn, Me.CantidadServida4DataGridViewTextBoxColumn, Me.TotalServidasDataGridViewTextBoxColumn})
        Me.dgDetalle.DataSource = Me.AplicacionFormulaDetalleC
        Me.dgDetalle.Location = New System.Drawing.Point(6, 19)
        Me.dgDetalle.MultiSelect = False
        Me.dgDetalle.Name = "dgDetalle"
        Me.dgDetalle.ReadOnly = True
        Me.dgDetalle.Size = New System.Drawing.Size(879, 285)
        Me.dgDetalle.TabIndex = 0
        '
        'IdCorralDataGridViewTextBoxColumn
        '
        Me.IdCorralDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.IdCorralDataGridViewTextBoxColumn.DataPropertyName = "IdCorral"
        Me.IdCorralDataGridViewTextBoxColumn.Frozen = True
        Me.IdCorralDataGridViewTextBoxColumn.HeaderText = "Código Corral"
        Me.IdCorralDataGridViewTextBoxColumn.Name = "IdCorralDataGridViewTextBoxColumn"
        Me.IdCorralDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCorralDataGridViewTextBoxColumn.Width = 88
        '
        'CorralDataGridViewTextBoxColumn
        '
        Me.CorralDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CorralDataGridViewTextBoxColumn.DataPropertyName = "IdCorral"
        Me.CorralDataGridViewTextBoxColumn.DataSource = Me.listaCorrales
        Me.CorralDataGridViewTextBoxColumn.DisplayMember = "NombreCorral"
        Me.CorralDataGridViewTextBoxColumn.Frozen = True
        Me.CorralDataGridViewTextBoxColumn.HeaderText = "Corral"
        Me.CorralDataGridViewTextBoxColumn.Name = "CorralDataGridViewTextBoxColumn"
        Me.CorralDataGridViewTextBoxColumn.ReadOnly = True
        Me.CorralDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CorralDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CorralDataGridViewTextBoxColumn.ValueMember = "IdCorral"
        Me.CorralDataGridViewTextBoxColumn.Width = 59
        '
        'listaCorrales
        '
        Me.listaCorrales.ObeyWeakRelations = False
        Me.listaCorrales.RemotingFormat = System.Data.SerializationFormat.Binary
        Me.listaCorrales.TableName = "ListaCorrales"
        '
        'LoteDataGridViewTextBoxColumn
        '
        Me.LoteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.LoteDataGridViewTextBoxColumn.DataPropertyName = "Lote"
        Me.LoteDataGridViewTextBoxColumn.Frozen = True
        Me.LoteDataGridViewTextBoxColumn.HeaderText = "Lote"
        Me.LoteDataGridViewTextBoxColumn.Name = "LoteDataGridViewTextBoxColumn"
        Me.LoteDataGridViewTextBoxColumn.ReadOnly = True
        Me.LoteDataGridViewTextBoxColumn.Width = 53
        '
        'IdFormulaDataGridViewTextBoxColumn
        '
        Me.IdFormulaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.IdFormulaDataGridViewTextBoxColumn.DataPropertyName = "IdFormula"
        Me.IdFormulaDataGridViewTextBoxColumn.Frozen = True
        Me.IdFormulaDataGridViewTextBoxColumn.HeaderText = "Código Formula"
        Me.IdFormulaDataGridViewTextBoxColumn.Name = "IdFormulaDataGridViewTextBoxColumn"
        Me.IdFormulaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdFormulaDataGridViewTextBoxColumn.Width = 97
        '
        'FormulaDataGridViewTextBoxColumn
        '
        Me.FormulaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.FormulaDataGridViewTextBoxColumn.DataPropertyName = "IdFormula"
        Me.FormulaDataGridViewTextBoxColumn.DataSource = Me.listaFormulas
        DataGridViewCellStyle1.NullValue = "0"
        Me.FormulaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.FormulaDataGridViewTextBoxColumn.DisplayMember = "Descripcion"
        Me.FormulaDataGridViewTextBoxColumn.Frozen = True
        Me.FormulaDataGridViewTextBoxColumn.HeaderText = "Formula"
        Me.FormulaDataGridViewTextBoxColumn.Name = "FormulaDataGridViewTextBoxColumn"
        Me.FormulaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FormulaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FormulaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FormulaDataGridViewTextBoxColumn.ValueMember = "Codigo"
        Me.FormulaDataGridViewTextBoxColumn.Width = 69
        '
        'listaFormulas
        '
        Me.listaFormulas.ObeyWeakRelations = False
        Me.listaFormulas.RemotingFormat = System.Data.SerializationFormat.Binary
        Me.listaFormulas.TableName = "ProductosGenerales"
        '
        'LoteAlmacenDataGridViewTextBoxColumn
        '
        Me.LoteAlmacenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.LoteAlmacenDataGridViewTextBoxColumn.DataPropertyName = "LoteAlmacen"
        Me.LoteAlmacenDataGridViewTextBoxColumn.HeaderText = "Lote Almacén"
        Me.LoteAlmacenDataGridViewTextBoxColumn.Name = "LoteAlmacenDataGridViewTextBoxColumn"
        Me.LoteAlmacenDataGridViewTextBoxColumn.ReadOnly = True
        Me.LoteAlmacenDataGridViewTextBoxColumn.Width = 89
        '
        'CantidadServida1DataGridViewTextBoxColumn
        '
        Me.CantidadServida1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CantidadServida1DataGridViewTextBoxColumn.DataPropertyName = "CantidadServida1"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N3"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.CantidadServida1DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.CantidadServida1DataGridViewTextBoxColumn.HeaderText = "Cantidad Servida 1"
        Me.CantidadServida1DataGridViewTextBoxColumn.Name = "CantidadServida1DataGridViewTextBoxColumn"
        Me.CantidadServida1DataGridViewTextBoxColumn.ReadOnly = True
        Me.CantidadServida1DataGridViewTextBoxColumn.Width = 112
        '
        'CantidadServida2DataGridViewTextBoxColumn
        '
        Me.CantidadServida2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CantidadServida2DataGridViewTextBoxColumn.DataPropertyName = "CantidadServida2"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N3"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.CantidadServida2DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.CantidadServida2DataGridViewTextBoxColumn.HeaderText = "Cantidad Servida 2"
        Me.CantidadServida2DataGridViewTextBoxColumn.Name = "CantidadServida2DataGridViewTextBoxColumn"
        Me.CantidadServida2DataGridViewTextBoxColumn.ReadOnly = True
        Me.CantidadServida2DataGridViewTextBoxColumn.Width = 112
        '
        'CantidadServida3DataGridViewTextBoxColumn
        '
        Me.CantidadServida3DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CantidadServida3DataGridViewTextBoxColumn.DataPropertyName = "CantidadServida3"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N3"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.CantidadServida3DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.CantidadServida3DataGridViewTextBoxColumn.HeaderText = "Cantidad Servida 3"
        Me.CantidadServida3DataGridViewTextBoxColumn.Name = "CantidadServida3DataGridViewTextBoxColumn"
        Me.CantidadServida3DataGridViewTextBoxColumn.ReadOnly = True
        Me.CantidadServida3DataGridViewTextBoxColumn.Width = 112
        '
        'CantidadServida4DataGridViewTextBoxColumn
        '
        Me.CantidadServida4DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CantidadServida4DataGridViewTextBoxColumn.DataPropertyName = "CantidadServida4"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N3"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.CantidadServida4DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.CantidadServida4DataGridViewTextBoxColumn.HeaderText = "Cantidad Servida 4"
        Me.CantidadServida4DataGridViewTextBoxColumn.Name = "CantidadServida4DataGridViewTextBoxColumn"
        Me.CantidadServida4DataGridViewTextBoxColumn.ReadOnly = True
        Me.CantidadServida4DataGridViewTextBoxColumn.Width = 112
        '
        'TotalServidasDataGridViewTextBoxColumn
        '
        Me.TotalServidasDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TotalServidasDataGridViewTextBoxColumn.DataPropertyName = "CantidadTotalServida"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N3"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.TotalServidasDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.TotalServidasDataGridViewTextBoxColumn.HeaderText = "Total Servidas"
        Me.TotalServidasDataGridViewTextBoxColumn.Name = "TotalServidasDataGridViewTextBoxColumn"
        Me.TotalServidasDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalServidasDataGridViewTextBoxColumn.Width = 92
        '
        'AplicacionFormulaDetalleC
        '
        Me.AplicacionFormulaDetalleC.AllowEdit = True
        Me.AplicacionFormulaDetalleC.AllowNew = True
        Me.AplicacionFormulaDetalleC.AllowRemove = True
        Me.AplicacionFormulaDetalleC.MaximoElementosSeleccionados = 1
        Me.AplicacionFormulaDetalleC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.AplicacionFormulaDetalleC.MostrarAlertas = False
        Me.AplicacionFormulaDetalleC.Name = Nothing
        Me.AplicacionFormulaDetalleC.RaiseListChangedEvents = True
        Me.AplicacionFormulaDetalleC.Transaction = Nothing
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.txtNumLotes)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtNumCorrales)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtCabezas)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(59, 414)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(218, 105)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Extras"
        '
        'txtNumLotes
        '
        Me.txtNumLotes.Enabled = False
        Me.txtNumLotes.Location = New System.Drawing.Point(69, 71)
        Me.txtNumLotes.Name = "txtNumLotes"
        Me.txtNumLotes.Size = New System.Drawing.Size(137, 20)
        Me.txtNumLotes.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Lotes:"
        '
        'txtNumCorrales
        '
        Me.txtNumCorrales.Enabled = False
        Me.txtNumCorrales.Location = New System.Drawing.Point(69, 45)
        Me.txtNumCorrales.Name = "txtNumCorrales"
        Me.txtNumCorrales.Size = New System.Drawing.Size(137, 20)
        Me.txtNumCorrales.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Corral:"
        '
        'txtCabezas
        '
        Me.txtCabezas.Enabled = False
        Me.txtCabezas.Location = New System.Drawing.Point(69, 19)
        Me.txtCabezas.Name = "txtCabezas"
        Me.txtCabezas.Size = New System.Drawing.Size(137, 20)
        Me.txtCabezas.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Cabezas:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.dgFormulas)
        Me.GroupBox3.Location = New System.Drawing.Point(533, 414)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(413, 146)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Totales Por Formula"
        '
        'dgFormulas
        '
        Me.dgFormulas.AllowUserToAddRows = False
        Me.dgFormulas.AllowUserToDeleteRows = False
        Me.dgFormulas.AllowUserToResizeRows = False
        Me.dgFormulas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgFormulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFormulas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FormulaListaFormulasDataGridViewTextBoxColumn, Me.CantidadListaFormulasDataGridViewColumn})
        Me.dgFormulas.Location = New System.Drawing.Point(6, 19)
        Me.dgFormulas.Name = "dgFormulas"
        Me.dgFormulas.ReadOnly = True
        Me.dgFormulas.RowHeadersVisible = False
        Me.dgFormulas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgFormulas.Size = New System.Drawing.Size(401, 121)
        Me.dgFormulas.TabIndex = 0
        '
        'FormulaListaFormulasDataGridViewTextBoxColumn
        '
        Me.FormulaListaFormulasDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.FormulaListaFormulasDataGridViewTextBoxColumn.DataPropertyName = "Formula"
        Me.FormulaListaFormulasDataGridViewTextBoxColumn.HeaderText = "Formula"
        Me.FormulaListaFormulasDataGridViewTextBoxColumn.Name = "FormulaListaFormulasDataGridViewTextBoxColumn"
        Me.FormulaListaFormulasDataGridViewTextBoxColumn.ReadOnly = True
        Me.FormulaListaFormulasDataGridViewTextBoxColumn.Width = 69
        '
        'CantidadListaFormulasDataGridViewColumn
        '
        Me.CantidadListaFormulasDataGridViewColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CantidadListaFormulasDataGridViewColumn.DataPropertyName = "Cantidad"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N3"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.CantidadListaFormulasDataGridViewColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.CantidadListaFormulasDataGridViewColumn.HeaderText = "Cantidad"
        Me.CantidadListaFormulasDataGridViewColumn.Name = "CantidadListaFormulasDataGridViewColumn"
        Me.CantidadListaFormulasDataGridViewColumn.ReadOnly = True
        Me.CantidadListaFormulasDataGridViewColumn.Width = 74
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(56, 391)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Consumo Estimado Por Formula:"
        '
        'txtEstimadoPorFormula
        '
        Me.txtEstimadoPorFormula.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtEstimadoPorFormula.Enabled = False
        Me.txtEstimadoPorFormula.Location = New System.Drawing.Point(250, 388)
        Me.txtEstimadoPorFormula.Name = "txtEstimadoPorFormula"
        Me.txtEstimadoPorFormula.Size = New System.Drawing.Size(114, 20)
        Me.txtEstimadoPorFormula.TabIndex = 11
        '
        'txtTotalServidas
        '
        Me.txtTotalServidas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalServidas.Enabled = False
        Me.txtTotalServidas.Location = New System.Drawing.Point(487, 388)
        Me.txtTotalServidas.Name = "txtTotalServidas"
        Me.txtTotalServidas.Size = New System.Drawing.Size(114, 20)
        Me.txtTotalServidas.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(370, 391)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Total de Servidas:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(411, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Almacén:"
        '
        'txtCodigoAlmacen
        '
        Me.txtCodigoAlmacen.ComboBoxEnlazado = Me.cmbAlmacen
        Me.txtCodigoAlmacen.Decimales = 0
        Me.txtCodigoAlmacen.Enabled = False
        Me.txtCodigoAlmacen.Location = New System.Drawing.Point(468, 41)
        Me.txtCodigoAlmacen.MaxLength = 3000
        Me.txtCodigoAlmacen.MensajeCombo = "Seleccionar un almacén..."
        Me.txtCodigoAlmacen.MensajeNoExiste = "No existe un almacén con este código o se encuentra inactivo"
        Me.txtCodigoAlmacen.Name = "txtCodigoAlmacen"
        Me.txtCodigoAlmacen.SiguienteControl = Me.dgDetalle
        Me.txtCodigoAlmacen.Size = New System.Drawing.Size(53, 20)
        Me.txtCodigoAlmacen.TabIndex = 7
        Me.txtCodigoAlmacen.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtCodigoAlmacen.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCodigoAlmacen.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cmbAlmacen
        '
        Me.cmbAlmacen.FormattingEnabled = True
        Me.cmbAlmacen.Location = New System.Drawing.Point(527, 40)
        Me.cmbAlmacen.Name = "cmbAlmacen"
        Me.cmbAlmacen.NombreMetodo = Nothing
        Me.cmbAlmacen.Parametros = Nothing
        Me.cmbAlmacen.SiguienteControl = Me.dgDetalle
        Me.cmbAlmacen.Size = New System.Drawing.Size(285, 21)
        Me.cmbAlmacen.TabIndex = 8
        Me.cmbAlmacen.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbAlmacen.TextBoxEnlazado = Me.txtCodigoAlmacen
        '
        'chkSoloFormulas
        '
        Me.chkSoloFormulas.AutoSize = True
        Me.chkSoloFormulas.Location = New System.Drawing.Point(819, 43)
        Me.chkSoloFormulas.Name = "chkSoloFormulas"
        Me.chkSoloFormulas.Size = New System.Drawing.Size(130, 17)
        Me.chkSoloFormulas.TabIndex = 16
        Me.chkSoloFormulas.Text = "Mostrar Solo Formulas"
        Me.chkSoloFormulas.UseVisualStyleBackColor = True
        '
        'frmAplicacionFormula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 572)
        Me.Controls.Add(Me.chkSoloFormulas)
        Me.Controls.Add(Me.cmbAlmacen)
        Me.Controls.Add(Me.txtCodigoAlmacen)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTotalServidas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEstimadoPorFormula)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAplicacionFormula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplicación de Formulas"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listaCorrales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listaFormulas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgFormulas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEstimadoPorFormula As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalServidas As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents AplicacionFormulaDetalleC As ClasesNegocio.AplicacionFormulaDetalleCollectionClass
    Friend WithEvents txtNumLotes As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNumCorrales As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCabezas As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgFormulas As System.Windows.Forms.DataGridView
    Friend WithEvents listaCorrales As Integralab.ORM.TypedListClasses.ListaCorralesTypedList
    Friend WithEvents listaFormulas As Integralab.ORM.TypedListClasses.ProductosGeneralesTypedList
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoAlmacen As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents cmbAlmacen As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents FormulaListaFormulasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadListaFormulasDataGridViewColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdCorralDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CorralDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents LoteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdFormulaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FormulaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents LoteAlmacenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadServida1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadServida2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadServida3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadServida4DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalServidasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkSoloFormulas As System.Windows.Forms.CheckBox
End Class
