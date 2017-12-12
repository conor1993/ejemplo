<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransferenciasCajas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransferenciasCajas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.txtkilos = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpFechaTrasoaso = New System.Windows.Forms.DateTimePicker
        Me.txtPiezas = New System.Windows.Forms.TextBox
        Me._LblEtiqueta_2 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtFolioTransferencia = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.gbCajas = New System.Windows.Forms.GroupBox
        Me.btnVaciarPistola = New System.Windows.Forms.Button
        Me.imgCajas = New System.Windows.Forms.ImageList(Me.components)
        Me.btnBusquedaEtiquetas = New System.Windows.Forms.Button
        Me.DgvCortes = New System.Windows.Forms.DataGridView
        Me.txtFolioEtiqueta = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbAlmacenDestino = New System.Windows.Forms.ComboBox
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmSelecciono = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.clmAlmacen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEtiqueta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmLoteCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIdCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPiezas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmKilos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFechaCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFechaCad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFechaCaducidadAnterior = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEstatusCaja = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIdPreCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIdAlmacenOrigen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIdAlmacenActual = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFolioMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFolioMovimientoCancelacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmTipoProducto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmTipoProductoAnterior = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gbCajas.SuspendLayout()
        CType(Me.DgvCortes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtkilos
        '
        Me.txtkilos.Enabled = False
        Me.txtkilos.Location = New System.Drawing.Point(419, 40)
        Me.txtkilos.Name = "txtkilos"
        Me.txtkilos.Size = New System.Drawing.Size(100, 20)
        Me.txtkilos.TabIndex = 86
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(381, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "Kilos:"
        '
        'dtpFechaTrasoaso
        '
        Me.dtpFechaTrasoaso.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFechaTrasoaso.Enabled = False
        Me.dtpFechaTrasoaso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaTrasoaso.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaTrasoaso.Location = New System.Drawing.Point(574, 40)
        Me.dtpFechaTrasoaso.Name = "dtpFechaTrasoaso"
        Me.dtpFechaTrasoaso.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaTrasoaso.TabIndex = 89
        '
        'txtPiezas
        '
        Me.txtPiezas.Enabled = False
        Me.txtPiezas.Location = New System.Drawing.Point(325, 40)
        Me.txtPiezas.Name = "txtPiezas"
        Me.txtPiezas.Size = New System.Drawing.Size(50, 20)
        Me.txtPiezas.TabIndex = 84
        '
        '_LblEtiqueta_2
        '
        Me._LblEtiqueta_2.AutoSize = True
        Me._LblEtiqueta_2.BackColor = System.Drawing.SystemColors.Control
        Me._LblEtiqueta_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._LblEtiqueta_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._LblEtiqueta_2.Location = New System.Drawing.Point(525, 44)
        Me._LblEtiqueta_2.Name = "_LblEtiqueta_2"
        Me._LblEtiqueta_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._LblEtiqueta_2.Size = New System.Drawing.Size(43, 13)
        Me._LblEtiqueta_2.TabIndex = 88
        Me._LblEtiqueta_2.Text = "Fecha :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(278, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Piezas:"
        '
        'txtFolioTransferencia
        '
        Me.txtFolioTransferencia.Enabled = False
        Me.txtFolioTransferencia.Location = New System.Drawing.Point(163, 40)
        Me.txtFolioTransferencia.Name = "txtFolioTransferencia"
        Me.txtFolioTransferencia.Size = New System.Drawing.Size(109, 20)
        Me.txtFolioTransferencia.TabIndex = 79
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(57, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Folio Trasnferencia:"
        '
        'gbCajas
        '
        Me.gbCajas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbCajas.Controls.Add(Me.btnVaciarPistola)
        Me.gbCajas.Controls.Add(Me.btnBusquedaEtiquetas)
        Me.gbCajas.Controls.Add(Me.DgvCortes)
        Me.gbCajas.Controls.Add(Me.txtFolioEtiqueta)
        Me.gbCajas.Controls.Add(Me.Label12)
        Me.gbCajas.Location = New System.Drawing.Point(54, 93)
        Me.gbCajas.Name = "gbCajas"
        Me.gbCajas.Size = New System.Drawing.Size(883, 480)
        Me.gbCajas.TabIndex = 82
        Me.gbCajas.TabStop = False
        Me.gbCajas.Text = "Lista de Cajas Agregadas"
        '
        'btnVaciarPistola
        '
        Me.btnVaciarPistola.ImageIndex = 3
        Me.btnVaciarPistola.ImageList = Me.imgCajas
        Me.btnVaciarPistola.Location = New System.Drawing.Point(257, 19)
        Me.btnVaciarPistola.Name = "btnVaciarPistola"
        Me.btnVaciarPistola.Size = New System.Drawing.Size(36, 33)
        Me.btnVaciarPistola.TabIndex = 4
        Me.btnVaciarPistola.UseVisualStyleBackColor = True
        '
        'imgCajas
        '
        Me.imgCajas.ImageStream = CType(resources.GetObject("imgCajas.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgCajas.TransparentColor = System.Drawing.Color.Transparent
        Me.imgCajas.Images.SetKeyName(0, "images.jpg")
        Me.imgCajas.Images.SetKeyName(1, "caja.jpg")
        Me.imgCajas.Images.SetKeyName(2, "MC9000Ga.jpg")
        Me.imgCajas.Images.SetKeyName(3, "pistola.jpg")
        '
        'btnBusquedaEtiquetas
        '
        Me.btnBusquedaEtiquetas.ImageIndex = 1
        Me.btnBusquedaEtiquetas.ImageList = Me.imgCajas
        Me.btnBusquedaEtiquetas.Location = New System.Drawing.Point(215, 19)
        Me.btnBusquedaEtiquetas.Name = "btnBusquedaEtiquetas"
        Me.btnBusquedaEtiquetas.Size = New System.Drawing.Size(36, 33)
        Me.btnBusquedaEtiquetas.TabIndex = 3
        Me.btnBusquedaEtiquetas.UseVisualStyleBackColor = True
        '
        'DgvCortes
        '
        Me.DgvCortes.AllowUserToAddRows = False
        Me.DgvCortes.AllowUserToDeleteRows = False
        Me.DgvCortes.AllowUserToResizeRows = False
        Me.DgvCortes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvCortes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvCortes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCortes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmSelecciono, Me.clmAlmacen, Me.clmEtiqueta, Me.clmLoteCorte, Me.clmIdCorte, Me.clmCorte, Me.clmPiezas, Me.clmKilos, Me.clmFechaCorte, Me.clmFechaCad, Me.clmFechaCaducidadAnterior, Me.clmEstatusCaja, Me.clmIdPreCorte, Me.clmIdAlmacenOrigen, Me.clmIdAlmacenActual, Me.clmFolioMovimiento, Me.clmFolioMovimientoCancelacion, Me.clmTipoProducto, Me.clmTipoProductoAnterior})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvCortes.DefaultCellStyle = DataGridViewCellStyle7
        Me.DgvCortes.Location = New System.Drawing.Point(6, 58)
        Me.DgvCortes.MultiSelect = False
        Me.DgvCortes.Name = "DgvCortes"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvCortes.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DgvCortes.RowHeadersVisible = False
        Me.DgvCortes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCortes.Size = New System.Drawing.Size(871, 416)
        Me.DgvCortes.TabIndex = 7
        '
        'txtFolioEtiqueta
        '
        Me.txtFolioEtiqueta.Location = New System.Drawing.Point(88, 26)
        Me.txtFolioEtiqueta.Name = "txtFolioEtiqueta"
        Me.txtFolioEtiqueta.Size = New System.Drawing.Size(121, 20)
        Me.txtFolioEtiqueta.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Folio Etiqueta:"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(899, 32)
        Me.Label17.TabIndex = 80
        Me.Label17.Text = "TRASPASO DE CAJAS"
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
        Me.mtb.MostrarEditar = True
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = False
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 585)
        Me.mtb.TabIndex = 81
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(57, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Almacén Destino:"
        '
        'cmbAlmacenDestino
        '
        Me.cmbAlmacenDestino.FormattingEnabled = True
        Me.cmbAlmacenDestino.Location = New System.Drawing.Point(163, 66)
        Me.cmbAlmacenDestino.Name = "cmbAlmacenDestino"
        Me.cmbAlmacenDestino.Size = New System.Drawing.Size(356, 21)
        Me.cmbAlmacenDestino.TabIndex = 93
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdFolioEtiqueta"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Folio Etiqueta"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "LoteCorte"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Lote Corte"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IdProducto"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Id Corte"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NomSubCorte"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Corte"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CantPzas"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn5.HeaderText = "Piezas"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CantKgrs"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N3"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn6.HeaderText = "Kilos"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "FechaCorte"
        DataGridViewCellStyle11.Format = "d"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn7.HeaderText = "Fecha Corte"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Fechacad"
        DataGridViewCellStyle12.Format = "d"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn8.HeaderText = "Fecha Caducidad"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Fecha Caducidad Anterior"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Estatus Caja"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Id PreCorte"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "Id Almacen Origen"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "Id Almacen Actual"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "Folio Movimiento"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "Folio Movimiento Cancelacion"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "Tipo Producto"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.HeaderText = "Tipo Producto Anterior"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Visible = False
        '
        'clmSelecciono
        '
        Me.clmSelecciono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmSelecciono.HeaderText = ""
        Me.clmSelecciono.MinimumWidth = 30
        Me.clmSelecciono.Name = "clmSelecciono"
        Me.clmSelecciono.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmSelecciono.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clmSelecciono.Visible = False
        Me.clmSelecciono.Width = 30
        '
        'clmAlmacen
        '
        Me.clmAlmacen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmAlmacen.DataPropertyName = "Almacen"
        Me.clmAlmacen.HeaderText = "Almacen"
        Me.clmAlmacen.Name = "clmAlmacen"
        Me.clmAlmacen.ReadOnly = True
        Me.clmAlmacen.Width = 71
        '
        'clmEtiqueta
        '
        Me.clmEtiqueta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmEtiqueta.DataPropertyName = "IdFolioEtiqueta"
        Me.clmEtiqueta.HeaderText = "Folio Etiqueta"
        Me.clmEtiqueta.Name = "clmEtiqueta"
        Me.clmEtiqueta.ReadOnly = True
        Me.clmEtiqueta.Width = 94
        '
        'clmLoteCorte
        '
        Me.clmLoteCorte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmLoteCorte.DataPropertyName = "LoteCorte"
        Me.clmLoteCorte.HeaderText = "Lote Corte"
        Me.clmLoteCorte.Name = "clmLoteCorte"
        Me.clmLoteCorte.ReadOnly = True
        Me.clmLoteCorte.Width = 79
        '
        'clmIdCorte
        '
        Me.clmIdCorte.DataPropertyName = "IdProducto"
        Me.clmIdCorte.HeaderText = "Id Corte"
        Me.clmIdCorte.Name = "clmIdCorte"
        Me.clmIdCorte.ReadOnly = True
        '
        'clmCorte
        '
        Me.clmCorte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmCorte.DataPropertyName = "NomSubCorte"
        Me.clmCorte.HeaderText = "Corte"
        Me.clmCorte.Name = "clmCorte"
        Me.clmCorte.ReadOnly = True
        Me.clmCorte.Width = 55
        '
        'clmPiezas
        '
        Me.clmPiezas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmPiezas.DataPropertyName = "CantPzas"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.clmPiezas.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmPiezas.HeaderText = "Piezas"
        Me.clmPiezas.Name = "clmPiezas"
        Me.clmPiezas.ReadOnly = True
        Me.clmPiezas.Width = 61
        '
        'clmKilos
        '
        Me.clmKilos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmKilos.DataPropertyName = "CantKgrs"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N3"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.clmKilos.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmKilos.HeaderText = "Kilos"
        Me.clmKilos.Name = "clmKilos"
        Me.clmKilos.ReadOnly = True
        Me.clmKilos.Width = 52
        '
        'clmFechaCorte
        '
        Me.clmFechaCorte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmFechaCorte.DataPropertyName = "FechaCorte"
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.clmFechaCorte.DefaultCellStyle = DataGridViewCellStyle4
        Me.clmFechaCorte.HeaderText = "Fecha Corte"
        Me.clmFechaCorte.Name = "clmFechaCorte"
        Me.clmFechaCorte.ReadOnly = True
        Me.clmFechaCorte.Width = 88
        '
        'clmFechaCad
        '
        Me.clmFechaCad.DataPropertyName = "Fechacad"
        DataGridViewCellStyle5.Format = "d"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.clmFechaCad.DefaultCellStyle = DataGridViewCellStyle5
        Me.clmFechaCad.HeaderText = "Fecha Caducidad"
        Me.clmFechaCad.Name = "clmFechaCad"
        Me.clmFechaCad.ReadOnly = True
        '
        'clmFechaCaducidadAnterior
        '
        DataGridViewCellStyle6.Format = "d"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.clmFechaCaducidadAnterior.DefaultCellStyle = DataGridViewCellStyle6
        Me.clmFechaCaducidadAnterior.HeaderText = "Fecha Caducidad Anterior"
        Me.clmFechaCaducidadAnterior.Name = "clmFechaCaducidadAnterior"
        '
        'clmEstatusCaja
        '
        Me.clmEstatusCaja.HeaderText = "Estatus Caja"
        Me.clmEstatusCaja.Name = "clmEstatusCaja"
        Me.clmEstatusCaja.Visible = False
        '
        'clmIdPreCorte
        '
        Me.clmIdPreCorte.HeaderText = "Id PreCorte"
        Me.clmIdPreCorte.Name = "clmIdPreCorte"
        Me.clmIdPreCorte.ReadOnly = True
        Me.clmIdPreCorte.Visible = False
        '
        'clmIdAlmacenOrigen
        '
        Me.clmIdAlmacenOrigen.HeaderText = "Id Almacen Origen"
        Me.clmIdAlmacenOrigen.Name = "clmIdAlmacenOrigen"
        Me.clmIdAlmacenOrigen.Visible = False
        '
        'clmIdAlmacenActual
        '
        Me.clmIdAlmacenActual.HeaderText = "Id Almacen Actual"
        Me.clmIdAlmacenActual.Name = "clmIdAlmacenActual"
        Me.clmIdAlmacenActual.Visible = False
        '
        'clmFolioMovimiento
        '
        Me.clmFolioMovimiento.HeaderText = "Folio Movimiento"
        Me.clmFolioMovimiento.Name = "clmFolioMovimiento"
        Me.clmFolioMovimiento.Visible = False
        '
        'clmFolioMovimientoCancelacion
        '
        Me.clmFolioMovimientoCancelacion.HeaderText = "Folio Movimiento Cancelacion"
        Me.clmFolioMovimientoCancelacion.Name = "clmFolioMovimientoCancelacion"
        Me.clmFolioMovimientoCancelacion.Visible = False
        '
        'clmTipoProducto
        '
        Me.clmTipoProducto.HeaderText = "Tipo Producto"
        Me.clmTipoProducto.Name = "clmTipoProducto"
        Me.clmTipoProducto.Visible = False
        '
        'clmTipoProductoAnterior
        '
        Me.clmTipoProductoAnterior.HeaderText = "Tipo Producto Anterior"
        Me.clmTipoProductoAnterior.Name = "clmTipoProductoAnterior"
        Me.clmTipoProductoAnterior.Visible = False
        '
        'frmTransferenciasCajas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 585)
        Me.Controls.Add(Me.cmbAlmacenDestino)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtkilos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpFechaTrasoaso)
        Me.Controls.Add(Me.txtPiezas)
        Me.Controls.Add(Me._LblEtiqueta_2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFolioTransferencia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbCajas)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.Name = "frmTransferenciasCajas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Traspaso De Cajas"
        Me.gbCajas.ResumeLayout(False)
        Me.gbCajas.PerformLayout()
        CType(Me.DgvCortes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtkilos As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaTrasoaso As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPiezas As System.Windows.Forms.TextBox
    Public WithEvents _LblEtiqueta_2 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFolioTransferencia As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbCajas As System.Windows.Forms.GroupBox
    Friend WithEvents btnVaciarPistola As System.Windows.Forms.Button
    Friend WithEvents btnBusquedaEtiquetas As System.Windows.Forms.Button
    Friend WithEvents DgvCortes As System.Windows.Forms.DataGridView
    Friend WithEvents txtFolioEtiqueta As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    'Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbAlmacenDestino As System.Windows.Forms.ComboBox
    Friend WithEvents imgCajas As System.Windows.Forms.ImageList
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSelecciono As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents clmAlmacen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEtiqueta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmLoteCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPiezas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmKilos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaCad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaCaducidadAnterior As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEstatusCaja As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdPreCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdAlmacenOrigen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdAlmacenActual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFolioMovimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFolioMovimientoCancelacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTipoProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTipoProductoAnterior As System.Windows.Forms.DataGridViewTextBoxColumn
End Class