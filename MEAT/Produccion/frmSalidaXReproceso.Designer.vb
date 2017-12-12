<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalidaXReproceso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalidaXReproceso))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label17 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.gbCajas = New System.Windows.Forms.GroupBox
        Me.btnVaciarPistola = New System.Windows.Forms.Button
        Me.imgCajas = New System.Windows.Forms.ImageList(Me.components)
        Me.btnBusquedaEtiquetas = New System.Windows.Forms.Button
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
        Me.txtFolioEtiqueta = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        'Me.Codigobarras = New AxTALBarCode.AxTALBarCd
        Me.ListaImagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.txtLoteCorteReproceso = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPiezas = New System.Windows.Forms.TextBox
        Me.txtkilos = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpFechaCaducidad = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaCorte = New System.Windows.Forms.DateTimePicker
        Me._LblEtiqueta_2 = New System.Windows.Forms.Label
        Me._LblEtiqueta_9 = New System.Windows.Forms.Label
        Me.gbCajas.SuspendLayout()
        CType(Me.DgvCortes, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.Codigobarras, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label17.Size = New System.Drawing.Size(899, 32)
        Me.Label17.TabIndex = 49
        Me.Label17.Text = "Salida De Cajas Por Reproceso"
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
        Me.mtb.MostrarCancelar = False
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = False
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = False
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 585)
        Me.mtb.TabIndex = 50
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
        'Me.gbCajas.Controls.Add(Me.Codigobarras)
        Me.gbCajas.Enabled = False
        Me.gbCajas.Location = New System.Drawing.Point(54, 66)
        Me.gbCajas.Name = "gbCajas"
        Me.gbCajas.Size = New System.Drawing.Size(883, 507)
        Me.gbCajas.TabIndex = 51
        Me.gbCajas.TabStop = False
        Me.gbCajas.Text = "Cajas En Reproceso"
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
        Me.DgvCortes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCortes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmSelecciono, Me.clmEtiqueta, Me.clmLoteCorte, Me.clmCliente, Me.clmPrecorte, Me.clmCorte, Me.clmPiezas, Me.clmKilos, Me.clmFechaCorte, Me.clmFechaCad, Me.clmIdCliente, Me.clmIdCorte, Me.clmGrados, Me.clmIdPreCorte})
        Me.DgvCortes.Location = New System.Drawing.Point(6, 58)
        Me.DgvCortes.MultiSelect = False
        Me.DgvCortes.Name = "DgvCortes"
        Me.DgvCortes.RowHeadersVisible = False
        Me.DgvCortes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCortes.Size = New System.Drawing.Size(871, 443)
        Me.DgvCortes.TabIndex = 7
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
        '
        'clmEtiqueta
        '
        Me.clmEtiqueta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmEtiqueta.DataPropertyName = "IdFolioEtiqueta"
        Me.clmEtiqueta.HeaderText = "Folio Etiqueta"
        Me.clmEtiqueta.Name = "clmEtiqueta"
        Me.clmEtiqueta.ReadOnly = True
        Me.clmEtiqueta.Width = 88
        '
        'clmLoteCorte
        '
        Me.clmLoteCorte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmLoteCorte.DataPropertyName = "LoteCorte"
        Me.clmLoteCorte.HeaderText = "Lote Corte"
        Me.clmLoteCorte.Name = "clmLoteCorte"
        Me.clmLoteCorte.ReadOnly = True
        Me.clmLoteCorte.Width = 75
        '
        'clmCliente
        '
        Me.clmCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmCliente.HeaderText = "Cliente"
        Me.clmCliente.Name = "clmCliente"
        Me.clmCliente.ReadOnly = True
        Me.clmCliente.Width = 64
        '
        'clmPrecorte
        '
        Me.clmPrecorte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmPrecorte.DataPropertyName = "NomCorte"
        Me.clmPrecorte.HeaderText = "Precorte"
        Me.clmPrecorte.Name = "clmPrecorte"
        Me.clmPrecorte.ReadOnly = True
        Me.clmPrecorte.Width = 72
        '
        'clmCorte
        '
        Me.clmCorte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmCorte.DataPropertyName = "NomSubCorte"
        Me.clmCorte.HeaderText = "Corte"
        Me.clmCorte.Name = "clmCorte"
        Me.clmCorte.ReadOnly = True
        Me.clmCorte.Width = 57
        '
        'clmPiezas
        '
        Me.clmPiezas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmPiezas.DataPropertyName = "CantPzas"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.clmPiezas.DefaultCellStyle = DataGridViewCellStyle5
        Me.clmPiezas.HeaderText = "Piezas"
        Me.clmPiezas.Name = "clmPiezas"
        Me.clmPiezas.ReadOnly = True
        Me.clmPiezas.Width = 63
        '
        'clmKilos
        '
        Me.clmKilos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmKilos.DataPropertyName = "CantKgrs"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N3"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.clmKilos.DefaultCellStyle = DataGridViewCellStyle6
        Me.clmKilos.HeaderText = "Kilos"
        Me.clmKilos.Name = "clmKilos"
        Me.clmKilos.ReadOnly = True
        Me.clmKilos.Width = 54
        '
        'clmFechaCorte
        '
        Me.clmFechaCorte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmFechaCorte.DataPropertyName = "FechaCorte"
        DataGridViewCellStyle7.Format = "d"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.clmFechaCorte.DefaultCellStyle = DataGridViewCellStyle7
        Me.clmFechaCorte.HeaderText = "Fecha Corte"
        Me.clmFechaCorte.Name = "clmFechaCorte"
        Me.clmFechaCorte.ReadOnly = True
        Me.clmFechaCorte.Width = 83
        '
        'clmFechaCad
        '
        Me.clmFechaCad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmFechaCad.DataPropertyName = "Fechacad"
        DataGridViewCellStyle8.Format = "d"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.clmFechaCad.DefaultCellStyle = DataGridViewCellStyle8
        Me.clmFechaCad.HeaderText = "Fecha Caducidad"
        Me.clmFechaCad.Name = "clmFechaCad"
        Me.clmFechaCad.ReadOnly = True
        Me.clmFechaCad.Width = 106
        '
        'clmIdCliente
        '
        Me.clmIdCliente.DataPropertyName = "IdCliente"
        Me.clmIdCliente.HeaderText = "Id Cliente"
        Me.clmIdCliente.Name = "clmIdCliente"
        Me.clmIdCliente.ReadOnly = True
        Me.clmIdCliente.Visible = False
        '
        'clmIdCorte
        '
        Me.clmIdCorte.DataPropertyName = "IdProducto"
        Me.clmIdCorte.HeaderText = "Id Corte"
        Me.clmIdCorte.Name = "clmIdCorte"
        Me.clmIdCorte.ReadOnly = True
        Me.clmIdCorte.Visible = False
        '
        'clmGrados
        '
        Me.clmGrados.DataPropertyName = "Grados"
        Me.clmGrados.HeaderText = "Grados"
        Me.clmGrados.Name = "clmGrados"
        Me.clmGrados.ReadOnly = True
        Me.clmGrados.Visible = False
        '
        'clmIdPreCorte
        '
        Me.clmIdPreCorte.HeaderText = "Id PreCorte"
        Me.clmIdPreCorte.Name = "clmIdPreCorte"
        Me.clmIdPreCorte.ReadOnly = True
        Me.clmIdPreCorte.Visible = False
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
        'Codigobarras
        '
        'Me.Codigobarras.Enabled = True
        'Me.Codigobarras.Location = New System.Drawing.Point(41, 131)
        'Me.Codigobarras.Name = "Codigobarras"
        'Me.Codigobarras.OcxState = CType(resources.GetObject("Codigobarras.OcxState"), System.Windows.Forms.AxHost.State)
        'Me.Codigobarras.Size = New System.Drawing.Size(153, 109)
        'Me.Codigobarras.TabIndex = 8
        'Me.Codigobarras.Visible = False
        '
        'ListaImagenes
        '
        Me.ListaImagenes.ImageStream = CType(resources.GetObject("ListaImagenes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ListaImagenes.TransparentColor = System.Drawing.Color.Transparent
        Me.ListaImagenes.Images.SetKeyName(0, "fELCHA.JPG")
        Me.ListaImagenes.Images.SetKeyName(1, "GetAttachment.aspx.jpg")
        Me.ListaImagenes.Images.SetKeyName(2, "images.jpg")
        '
        'txtLoteCorteReproceso
        '
        Me.txtLoteCorteReproceso.Enabled = False
        Me.txtLoteCorteReproceso.Location = New System.Drawing.Point(149, 40)
        Me.txtLoteCorteReproceso.Name = "txtLoteCorteReproceso"
        Me.txtLoteCorteReproceso.Size = New System.Drawing.Size(109, 20)
        Me.txtLoteCorteReproceso.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(57, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Lote Reproceso:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(264, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Piezas:"
        '
        'txtPiezas
        '
        Me.txtPiezas.Enabled = False
        Me.txtPiezas.Location = New System.Drawing.Point(311, 40)
        Me.txtPiezas.Name = "txtPiezas"
        Me.txtPiezas.Size = New System.Drawing.Size(50, 20)
        Me.txtPiezas.TabIndex = 53
        '
        'txtkilos
        '
        Me.txtkilos.Enabled = False
        Me.txtkilos.Location = New System.Drawing.Point(405, 40)
        Me.txtkilos.Name = "txtkilos"
        Me.txtkilos.Size = New System.Drawing.Size(100, 20)
        Me.txtkilos.TabIndex = 55
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(367, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Kilos:"
        '
        'dtpFechaCaducidad
        '
        Me.dtpFechaCaducidad.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFechaCaducidad.Enabled = False
        Me.dtpFechaCaducidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaCaducidad.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaCaducidad.Location = New System.Drawing.Point(737, 40)
        Me.dtpFechaCaducidad.Name = "dtpFechaCaducidad"
        Me.dtpFechaCaducidad.Size = New System.Drawing.Size(97, 20)
        Me.dtpFechaCaducidad.TabIndex = 77
        '
        'dtpFechaCorte
        '
        Me.dtpFechaCorte.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFechaCorte.Enabled = False
        Me.dtpFechaCorte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaCorte.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaCorte.Location = New System.Drawing.Point(560, 40)
        Me.dtpFechaCorte.Name = "dtpFechaCorte"
        Me.dtpFechaCorte.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaCorte.TabIndex = 76
        '
        '_LblEtiqueta_2
        '
        Me._LblEtiqueta_2.AutoSize = True
        Me._LblEtiqueta_2.BackColor = System.Drawing.SystemColors.Control
        Me._LblEtiqueta_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._LblEtiqueta_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._LblEtiqueta_2.Location = New System.Drawing.Point(511, 44)
        Me._LblEtiqueta_2.Name = "_LblEtiqueta_2"
        Me._LblEtiqueta_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._LblEtiqueta_2.Size = New System.Drawing.Size(43, 13)
        Me._LblEtiqueta_2.TabIndex = 75
        Me._LblEtiqueta_2.Text = "Fecha :"
        '
        '_LblEtiqueta_9
        '
        Me._LblEtiqueta_9.AutoSize = True
        Me._LblEtiqueta_9.BackColor = System.Drawing.SystemColors.Control
        Me._LblEtiqueta_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._LblEtiqueta_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._LblEtiqueta_9.Location = New System.Drawing.Point(666, 44)
        Me._LblEtiqueta_9.Name = "_LblEtiqueta_9"
        Me._LblEtiqueta_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._LblEtiqueta_9.Size = New System.Drawing.Size(65, 13)
        Me._LblEtiqueta_9.TabIndex = 74
        Me._LblEtiqueta_9.Text = "Fecha Cad :"
        '
        'frmSalidaXReproceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 585)
        Me.Controls.Add(Me.dtpFechaCaducidad)
        Me.Controls.Add(Me.txtkilos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpFechaCorte)
        Me.Controls.Add(Me._LblEtiqueta_9)
        Me.Controls.Add(Me.txtPiezas)
        Me.Controls.Add(Me._LblEtiqueta_2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtLoteCorteReproceso)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbCajas)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.MaximizeBox = False
        Me.Name = "frmSalidaXReproceso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salida De Cajas Por Reproceso"
        Me.gbCajas.ResumeLayout(False)
        Me.gbCajas.PerformLayout()
        CType(Me.DgvCortes, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.Codigobarras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents gbCajas As System.Windows.Forms.GroupBox
    Friend WithEvents btnVaciarPistola As System.Windows.Forms.Button
    Friend WithEvents imgCajas As System.Windows.Forms.ImageList
    Friend WithEvents btnBusquedaEtiquetas As System.Windows.Forms.Button
    Friend WithEvents DgvCortes As System.Windows.Forms.DataGridView
    Friend WithEvents txtFolioEtiqueta As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    'Friend WithEvents Codigobarras As AxTALBarCode.AxTALBarCd
    Friend WithEvents ListaImagenes As System.Windows.Forms.ImageList
    Friend WithEvents txtLoteCorteReproceso As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPiezas As System.Windows.Forms.TextBox
    Friend WithEvents txtkilos As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaCaducidad As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaCorte As System.Windows.Forms.DateTimePicker
    Public WithEvents _LblEtiqueta_2 As System.Windows.Forms.Label
    Public WithEvents _LblEtiqueta_9 As System.Windows.Forms.Label
End Class
