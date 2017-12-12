<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReEtiquetacion
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReEtiquetacion))
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.dtFechaCorteNuevo = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.DtpFechaCadNva = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DgvCortes = New System.Windows.Forms.DataGridView
        Me.clmSelecciono = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.clmEtiqueta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmLoteCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPrecorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPiezas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmKilos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFechaCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFechaCad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIdCliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIdCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmGrados = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIdPreCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFechaCaptura = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCodigoBarras = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.brnQuitarSeleccion = New System.Windows.Forms.Button
        Me.btnSeleccionarTodos = New System.Windows.Forms.Button
        Me.btnVaciarPistola = New System.Windows.Forms.Button
        Me.imgCajas = New System.Windows.Forms.ImageList(Me.components)
        Me.btnBusquedaEtiquetas = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtEmbarque = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        'Me.Codigobarras = New AxTALBarCode.AxTALBarCd
        Me.pdDocumento = New System.Drawing.Printing.PrintDocument
        Me.ListaImagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.txtCodigoDestino = New Integralab.Controles.TextBoxMejorado
        Me.cmbDestino = New Integralab.Controles.ComboBoxMejorado
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCodigoCliente = New Integralab.Controles.TextBoxMejorado
        Me.CmbCliente = New Integralab.Controles.ComboBoxMejorado
        Me.chkCambiarFechas = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtLoteCorte = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.nudCopias = New System.Windows.Forms.NumericUpDown
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
        Me.ppdVisor = New System.Windows.Forms.PrintPreviewDialog
        Me.chkExportacion = New System.Windows.Forms.CheckBox
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvCortes, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.Codigobarras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudCopias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MEAToolBar1
        '
        Me.MEAToolBar1.ButtonSize = New System.Drawing.Size(50, 50)
        Me.MEAToolBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MEAToolBar1.DropDownArrows = True
        Me.MEAToolBar1.HabilitarBorrar = True
        Me.MEAToolBar1.HabilitarBuscar = True
        Me.MEAToolBar1.HabilitarCancelar = True
        Me.MEAToolBar1.HabilitarEditar = True
        Me.MEAToolBar1.HabilitarGuardar = True
        Me.MEAToolBar1.HabilitarImprimir = True
        Me.MEAToolBar1.HabilitarLimpiar = True
        Me.MEAToolBar1.HabilitarNuevo = True
        Me.MEAToolBar1.HabilitarSalir = True
        Me.MEAToolBar1.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32
        Me.MEAToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.MEAToolBar1.MostrarBorrar = False
        Me.MEAToolBar1.MostrarBuscar = False
        Me.MEAToolBar1.MostrarCancelar = False
        Me.MEAToolBar1.MostrarEditar = False
        Me.MEAToolBar1.MostrarGuardar = False
        Me.MEAToolBar1.MostrarImprimir = True
        Me.MEAToolBar1.MostrarLimpiar = True
        Me.MEAToolBar1.MostrarNuevo = False
        Me.MEAToolBar1.MostrarSalir = True
        Me.MEAToolBar1.Name = "MEAToolBar1"
        Me.MEAToolBar1.ShowToolTips = True
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 611)
        Me.MEAToolBar1.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(895, 32)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Reimpresión de Etiquetas"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(118, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Fecha de Corte Nueva:"
        '
        'dtFechaCorteNuevo
        '
        Me.dtFechaCorteNuevo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaCorteNuevo.Location = New System.Drawing.Point(142, 17)
        Me.dtFechaCorteNuevo.Name = "dtFechaCorteNuevo"
        Me.dtFechaCorteNuevo.Size = New System.Drawing.Size(87, 20)
        Me.dtFechaCorteNuevo.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(52, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Cliente:"
        '
        'DtpFechaCadNva
        '
        Me.DtpFechaCadNva.Enabled = False
        Me.DtpFechaCadNva.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaCadNva.Location = New System.Drawing.Point(142, 43)
        Me.DtpFechaCadNva.Name = "DtpFechaCadNva"
        Me.DtpFechaCadNva.Size = New System.Drawing.Size(87, 20)
        Me.DtpFechaCadNva.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(129, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Fecha Caducidad Nueva:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.DgvCortes)
        Me.GroupBox2.Controls.Add(Me.brnQuitarSeleccion)
        Me.GroupBox2.Controls.Add(Me.btnSeleccionarTodos)
        Me.GroupBox2.Controls.Add(Me.btnVaciarPistola)
        Me.GroupBox2.Controls.Add(Me.btnBusquedaEtiquetas)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtEmbarque)
        Me.GroupBox2.Controls.Add(Me.Label12)
        'Me.GroupBox2.Controls.Add(Me.Codigobarras)
        Me.GroupBox2.Location = New System.Drawing.Point(56, 117)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(877, 482)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Etiquetas de Cortes a Modificar"
        '
        'DgvCortes
        '
        Me.DgvCortes.AllowUserToAddRows = False
        Me.DgvCortes.AllowUserToDeleteRows = False
        Me.DgvCortes.AllowUserToResizeRows = False
        Me.DgvCortes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvCortes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCortes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmSelecciono, Me.clmEtiqueta, Me.clmLoteCorte, Me.clmCliente, Me.clmPrecorte, Me.clmCorte, Me.clmPiezas, Me.clmKilos, Me.clmFechaCorte, Me.clmFechaCad, Me.clmIdCliente, Me.clmIdCorte, Me.clmGrados, Me.clmIdPreCorte, Me.clmFechaCaptura, Me.clmCodigoBarras})
        Me.DgvCortes.Location = New System.Drawing.Point(6, 80)
        Me.DgvCortes.MultiSelect = False
        Me.DgvCortes.Name = "DgvCortes"
        Me.DgvCortes.RowHeadersVisible = False
        Me.DgvCortes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCortes.Size = New System.Drawing.Size(865, 396)
        Me.DgvCortes.TabIndex = 7
        '
        'clmSelecciono
        '
        Me.clmSelecciono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmSelecciono.HeaderText = ""
        Me.clmSelecciono.MinimumWidth = 30
        Me.clmSelecciono.Name = "clmSelecciono"
        Me.clmSelecciono.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmSelecciono.Width = 30
        '
        'clmEtiqueta
        '
        Me.clmEtiqueta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmEtiqueta.DataPropertyName = "IdFolioEtiqueta"
        Me.clmEtiqueta.HeaderText = "Etiqueta"
        Me.clmEtiqueta.Name = "clmEtiqueta"
        Me.clmEtiqueta.ReadOnly = True
        Me.clmEtiqueta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clmEtiqueta.Width = 52
        '
        'clmLoteCorte
        '
        Me.clmLoteCorte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmLoteCorte.DataPropertyName = "LoteCorte"
        Me.clmLoteCorte.HeaderText = "Lote Corte"
        Me.clmLoteCorte.Name = "clmLoteCorte"
        Me.clmLoteCorte.ReadOnly = True
        Me.clmLoteCorte.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clmLoteCorte.Width = 56
        '
        'clmCliente
        '
        Me.clmCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmCliente.HeaderText = "Cliente"
        Me.clmCliente.Name = "clmCliente"
        Me.clmCliente.ReadOnly = True
        Me.clmCliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clmCliente.Width = 45
        '
        'clmPrecorte
        '
        Me.clmPrecorte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmPrecorte.DataPropertyName = "NomCorte"
        Me.clmPrecorte.HeaderText = "Precorte"
        Me.clmPrecorte.Name = "clmPrecorte"
        Me.clmPrecorte.ReadOnly = True
        Me.clmPrecorte.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clmPrecorte.Width = 53
        '
        'clmCorte
        '
        Me.clmCorte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmCorte.DataPropertyName = "NomSubCorte"
        Me.clmCorte.HeaderText = "Corte"
        Me.clmCorte.Name = "clmCorte"
        Me.clmCorte.ReadOnly = True
        Me.clmCorte.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clmCorte.Width = 38
        '
        'clmPiezas
        '
        Me.clmPiezas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmPiezas.DataPropertyName = "CantPzas"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.clmPiezas.DefaultCellStyle = DataGridViewCellStyle9
        Me.clmPiezas.HeaderText = "Piezas"
        Me.clmPiezas.Name = "clmPiezas"
        Me.clmPiezas.ReadOnly = True
        Me.clmPiezas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clmPiezas.Width = 44
        '
        'clmKilos
        '
        Me.clmKilos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmKilos.DataPropertyName = "CantKgrs"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N3"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.clmKilos.DefaultCellStyle = DataGridViewCellStyle10
        Me.clmKilos.HeaderText = "Kilos"
        Me.clmKilos.Name = "clmKilos"
        Me.clmKilos.ReadOnly = True
        Me.clmKilos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clmKilos.Width = 35
        '
        'clmFechaCorte
        '
        Me.clmFechaCorte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmFechaCorte.DataPropertyName = "FechaCorte"
        DataGridViewCellStyle11.Format = "d"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.clmFechaCorte.DefaultCellStyle = DataGridViewCellStyle11
        Me.clmFechaCorte.HeaderText = "Fecha Corte"
        Me.clmFechaCorte.Name = "clmFechaCorte"
        Me.clmFechaCorte.ReadOnly = True
        Me.clmFechaCorte.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clmFechaCorte.Width = 64
        '
        'clmFechaCad
        '
        Me.clmFechaCad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmFechaCad.DataPropertyName = "Fechacad"
        DataGridViewCellStyle12.Format = "d"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.clmFechaCad.DefaultCellStyle = DataGridViewCellStyle12
        Me.clmFechaCad.HeaderText = "Fecha Caducidad"
        Me.clmFechaCad.Name = "clmFechaCad"
        Me.clmFechaCad.ReadOnly = True
        Me.clmFechaCad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clmFechaCad.Width = 87
        '
        'clmIdCliente
        '
        Me.clmIdCliente.DataPropertyName = "IdCliente"
        Me.clmIdCliente.HeaderText = "Id Cliente"
        Me.clmIdCliente.Name = "clmIdCliente"
        Me.clmIdCliente.ReadOnly = True
        Me.clmIdCliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clmIdCliente.Visible = False
        '
        'clmIdCorte
        '
        Me.clmIdCorte.DataPropertyName = "IdProducto"
        Me.clmIdCorte.HeaderText = "Id Corte"
        Me.clmIdCorte.Name = "clmIdCorte"
        Me.clmIdCorte.ReadOnly = True
        Me.clmIdCorte.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clmIdCorte.Visible = False
        '
        'clmGrados
        '
        Me.clmGrados.DataPropertyName = "Grados"
        Me.clmGrados.HeaderText = "Grados"
        Me.clmGrados.Name = "clmGrados"
        Me.clmGrados.ReadOnly = True
        Me.clmGrados.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clmGrados.Visible = False
        '
        'clmIdPreCorte
        '
        Me.clmIdPreCorte.HeaderText = "Id PreCorte"
        Me.clmIdPreCorte.Name = "clmIdPreCorte"
        Me.clmIdPreCorte.ReadOnly = True
        Me.clmIdPreCorte.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clmIdPreCorte.Visible = False
        '
        'clmFechaCaptura
        '
        Me.clmFechaCaptura.HeaderText = "Fecha Captura"
        Me.clmFechaCaptura.Name = "clmFechaCaptura"
        Me.clmFechaCaptura.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clmFechaCaptura.Visible = False
        '
        'clmCodigoBarras
        '
        Me.clmCodigoBarras.HeaderText = "Codigo Barras"
        Me.clmCodigoBarras.Name = "clmCodigoBarras"
        Me.clmCodigoBarras.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clmCodigoBarras.Visible = False
        '
        'brnQuitarSeleccion
        '
        Me.brnQuitarSeleccion.Location = New System.Drawing.Point(133, 51)
        Me.brnQuitarSeleccion.Name = "brnQuitarSeleccion"
        Me.brnQuitarSeleccion.Size = New System.Drawing.Size(161, 23)
        Me.brnQuitarSeleccion.TabIndex = 6
        Me.brnQuitarSeleccion.Text = "Quitar Todas las Selecciones"
        Me.brnQuitarSeleccion.UseVisualStyleBackColor = True
        '
        'btnSeleccionarTodos
        '
        Me.btnSeleccionarTodos.Location = New System.Drawing.Point(14, 51)
        Me.btnSeleccionarTodos.Name = "btnSeleccionarTodos"
        Me.btnSeleccionarTodos.Size = New System.Drawing.Size(113, 23)
        Me.btnSeleccionarTodos.TabIndex = 5
        Me.btnSeleccionarTodos.Text = "Seleccionar Todos"
        Me.btnSeleccionarTodos.UseVisualStyleBackColor = True
        '
        'btnVaciarPistola
        '
        Me.btnVaciarPistola.ImageIndex = 3
        Me.btnVaciarPistola.ImageList = Me.imgCajas
        Me.btnVaciarPistola.Location = New System.Drawing.Point(342, 12)
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
        Me.btnBusquedaEtiquetas.Location = New System.Drawing.Point(300, 12)
        Me.btnBusquedaEtiquetas.Name = "btnBusquedaEtiquetas"
        Me.btnBusquedaEtiquetas.Size = New System.Drawing.Size(36, 33)
        Me.btnBusquedaEtiquetas.TabIndex = 3
        Me.btnBusquedaEtiquetas.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label14.Location = New System.Drawing.Point(200, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 30)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Precione F3 para buscar un embarque"
        '
        'txtEmbarque
        '
        Me.txtEmbarque.Location = New System.Drawing.Point(73, 19)
        Me.txtEmbarque.MaxLength = 10
        Me.txtEmbarque.Name = "txtEmbarque"
        Me.txtEmbarque.Size = New System.Drawing.Size(121, 20)
        Me.txtEmbarque.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Embarque:"
        '
        'Codigobarras
        '
        'Me.Codigobarras.Enabled = True
        'Me.Codigobarras.Location = New System.Drawing.Point(14, 88)
        'Me.Codigobarras.Name = "Codigobarras"
        'Me.Codigobarras.OcxState = CType(resources.GetObject("Codigobarras.OcxState"), System.Windows.Forms.AxHost.State)
        'Me.Codigobarras.Size = New System.Drawing.Size(153, 120)
        'Me.Codigobarras.TabIndex = 8
        '
        'ListaImagenes
        '
        Me.ListaImagenes.ImageStream = CType(resources.GetObject("ListaImagenes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ListaImagenes.TransparentColor = System.Drawing.Color.Transparent
        Me.ListaImagenes.Images.SetKeyName(0, "fELCHA.JPG")
        Me.ListaImagenes.Images.SetKeyName(1, "GetAttachment.aspx.jpg")
        Me.ListaImagenes.Images.SetKeyName(2, "images.jpg")
        '
        'txtCodigoDestino
        '
        Me.txtCodigoDestino.ComboBoxEnlazado = Nothing
        Me.txtCodigoDestino.Decimales = 0
        Me.txtCodigoDestino.Location = New System.Drawing.Point(102, 63)
        Me.txtCodigoDestino.MensajeCombo = "Seleccionar un item..."
        Me.txtCodigoDestino.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtCodigoDestino.Name = "txtCodigoDestino"
        Me.txtCodigoDestino.SiguienteControl = Nothing
        Me.txtCodigoDestino.Size = New System.Drawing.Size(44, 20)
        Me.txtCodigoDestino.TabIndex = 6
        Me.txtCodigoDestino.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'cmbDestino
        '
        Me.cmbDestino.FormattingEnabled = True
        Me.cmbDestino.Location = New System.Drawing.Point(152, 63)
        Me.cmbDestino.Name = "cmbDestino"
        Me.cmbDestino.NombreMetodo = Nothing
        Me.cmbDestino.Parametros = Nothing
        Me.cmbDestino.SiguienteControl = Nothing
        Me.cmbDestino.Size = New System.Drawing.Size(399, 21)
        Me.cmbDestino.TabIndex = 7
        Me.cmbDestino.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbDestino.TextBoxEnlazado = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Destino:"
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.ComboBoxEnlazado = Nothing
        Me.txtCodigoCliente.Decimales = 0
        Me.txtCodigoCliente.Location = New System.Drawing.Point(102, 36)
        Me.txtCodigoCliente.MensajeCombo = "Seleccionar un item..."
        Me.txtCodigoCliente.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.SiguienteControl = Nothing
        Me.txtCodigoCliente.Size = New System.Drawing.Size(44, 20)
        Me.txtCodigoCliente.TabIndex = 3
        Me.txtCodigoCliente.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'CmbCliente
        '
        Me.CmbCliente.FormattingEnabled = True
        Me.CmbCliente.Location = New System.Drawing.Point(152, 36)
        Me.CmbCliente.Name = "CmbCliente"
        Me.CmbCliente.NombreMetodo = Nothing
        Me.CmbCliente.Parametros = Nothing
        Me.CmbCliente.SiguienteControl = Nothing
        Me.CmbCliente.Size = New System.Drawing.Size(399, 21)
        Me.CmbCliente.TabIndex = 4
        Me.CmbCliente.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.CmbCliente.TextBoxEnlazado = Nothing
        '
        'chkCambiarFechas
        '
        Me.chkCambiarFechas.AutoSize = True
        Me.chkCambiarFechas.Location = New System.Drawing.Point(557, 38)
        Me.chkCambiarFechas.Name = "chkCambiarFechas"
        Me.chkCambiarFechas.Size = New System.Drawing.Size(102, 17)
        Me.chkCambiarFechas.TabIndex = 8
        Me.chkCambiarFechas.Text = "Cambiar Fechas"
        Me.chkCambiarFechas.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.DtpFechaCadNva)
        Me.GroupBox1.Controls.Add(Me.dtFechaCorteNuevo)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(665, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(238, 75)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fechas:"
        '
        'txtLoteCorte
        '
        Me.txtLoteCorte.Location = New System.Drawing.Point(216, 90)
        Me.txtLoteCorte.MaxLength = 9
        Me.txtLoteCorte.Name = "txtLoteCorte"
        Me.txtLoteCorte.Size = New System.Drawing.Size(121, 20)
        Me.txtLoteCorte.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Lote de Corte Para Reemplazar:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(343, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "No. Copias:"
        '
        'nudCopias
        '
        Me.nudCopias.Location = New System.Drawing.Point(411, 90)
        Me.nudCopias.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudCopias.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCopias.Name = "nudCopias"
        Me.nudCopias.Size = New System.Drawing.Size(38, 20)
        Me.nudCopias.TabIndex = 12
        Me.nudCopias.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdFolioEtiqueta"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Etiqueta"
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
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NomCorte"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Precorte"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "NomSubCorte"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Corte"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CantPzas"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "N2"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn6.HeaderText = "Piezas"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CantKgrs"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "N3"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn7.HeaderText = "Kilos"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "FechaCorte"
        DataGridViewCellStyle15.Format = "d"
        DataGridViewCellStyle15.NullValue = Nothing
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn8.HeaderText = "Fecha Corte"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Fechacad"
        DataGridViewCellStyle16.Format = "d"
        DataGridViewCellStyle16.NullValue = Nothing
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewTextBoxColumn9.HeaderText = "Fecha Caducidad"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "IdCliente"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Id Cliente"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "IdProducto"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Id Corte"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Grados"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Grados"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "Id PreCorte"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "Fecha Captura"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "Codigo Barras"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'ppdVisor
        '
        Me.ppdVisor.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.ppdVisor.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.ppdVisor.ClientSize = New System.Drawing.Size(400, 300)
        Me.ppdVisor.Enabled = True
        Me.ppdVisor.Icon = CType(resources.GetObject("ppdVisor.Icon"), System.Drawing.Icon)
        Me.ppdVisor.Name = "ppdVisor"
        Me.ppdVisor.Visible = False
        '
        'chkExportacion
        '
        Me.chkExportacion.AutoSize = True
        Me.chkExportacion.Location = New System.Drawing.Point(557, 65)
        Me.chkExportacion.Name = "chkExportacion"
        Me.chkExportacion.Size = New System.Drawing.Size(82, 17)
        Me.chkExportacion.TabIndex = 13
        Me.chkExportacion.Text = "Exportación"
        Me.chkExportacion.UseVisualStyleBackColor = True
        '
        'FrmReEtiquetacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 611)
        Me.Controls.Add(Me.chkExportacion)
        Me.Controls.Add(Me.nudCopias)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLoteCorte)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkCambiarFechas)
        Me.Controls.Add(Me.CmbCliente)
        Me.Controls.Add(Me.txtCodigoCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbDestino)
        Me.Controls.Add(Me.txtCodigoDestino)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmReEtiquetacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reimpresión de Etiquetas"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DgvCortes, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.Codigobarras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nudCopias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DtpFechaCadNva As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DgvCortes As System.Windows.Forms.DataGridView
    Friend WithEvents txtEmbarque As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtFechaCorteNuevo As System.Windows.Forms.DateTimePicker
    Friend WithEvents pdDocumento As System.Drawing.Printing.PrintDocument
    Friend WithEvents ListaImagenes As System.Windows.Forms.ImageList
    Friend WithEvents btnBusquedaEtiquetas As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents imgCajas As System.Windows.Forms.ImageList
    Friend WithEvents btnVaciarPistola As System.Windows.Forms.Button
    Friend WithEvents brnQuitarSeleccion As System.Windows.Forms.Button
    Friend WithEvents btnSeleccionarTodos As System.Windows.Forms.Button
    Friend WithEvents txtCodigoDestino As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents cmbDestino As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoCliente As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents CmbCliente As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents chkCambiarFechas As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
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
    Friend WithEvents txtLoteCorte As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nudCopias As System.Windows.Forms.NumericUpDown
    'Friend WithEvents Codigobarras As AxTALBarCode.AxTALBarCd
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ppdVisor As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents clmSelecciono As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents clmEtiqueta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmLoteCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPrecorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPiezas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmKilos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaCad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmGrados As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdPreCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaCaptura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCodigoBarras As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkExportacion As System.Windows.Forms.CheckBox
End Class
