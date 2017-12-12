<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CatAlmRegEntAlmTransferencia
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
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label17 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.mtxtFolioSalida = New System.Windows.Forms.MaskedTextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.TxtObservaciones = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtTotal = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.DataGrid = New System.Windows.Forms.DataGridView
        Me.clmCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmProducto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmLote = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmUnidadMedida = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCosto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmImporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIva = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFechaCaducidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TxtAlmDest = New System.Windows.Forms.TextBox
        Me.TxtAlmOrigen = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtFolioEntrada = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.DTPFecha = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtRecibe = New System.Windows.Forms.TextBox
        Me.TxtEntrega = New System.Windows.Forms.TextBox
        Me.CmbPlaza = New System.Windows.Forms.ComboBox
        Me.PlazaCol = New ClasesNegocio.PlazaCollectionClass
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.mtb.MostrarBorrar = True
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
        Me.mtb.Size = New System.Drawing.Size(50, 577)
        Me.mtb.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(813, 29)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "REGISTRO DE ENTRADAS A ALMACEN POR TRANSFERENCIAS"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.mtxtFolioSalida)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.lblEstatus)
        Me.Panel1.Controls.Add(Me.TxtObservaciones)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.TxtAlmDest)
        Me.Panel1.Controls.Add(Me.TxtAlmOrigen)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TxtFolioEntrada)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.DTPFecha)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TxtRecibe)
        Me.Panel1.Controls.Add(Me.TxtEntrega)
        Me.Panel1.Controls.Add(Me.CmbPlaza)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(56, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(795, 530)
        Me.Panel1.TabIndex = 2
        '
        'mtxtFolioSalida
        '
        Me.mtxtFolioSalida.Location = New System.Drawing.Point(111, 57)
        Me.mtxtFolioSalida.Mask = "0000-0000000"
        Me.mtxtFolioSalida.Name = "mtxtFolioSalida"
        Me.mtxtFolioSalida.Size = New System.Drawing.Size(143, 20)
        Me.mtxtFolioSalida.TabIndex = 104
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label11.Location = New System.Drawing.Point(260, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(244, 13)
        Me.Label11.TabIndex = 103
        Me.Label11.Text = "Presione F3 para buscar salidas por transferencias"
        '
        'lblEstatus
        '
        Me.lblEstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(665, 3)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(127, 21)
        Me.lblEstatus.TabIndex = 102
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtObservaciones.Location = New System.Drawing.Point(114, 444)
        Me.TxtObservaciones.MaxLength = 250
        Me.TxtObservaciones.Multiline = True
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtObservaciones.Size = New System.Drawing.Size(359, 68)
        Me.TxtObservaciones.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(27, 447)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 13)
        Me.Label10.TabIndex = 101
        Me.Label10.Text = "Observaciones:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TxtTotal)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.DataGrid)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 187)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(789, 251)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de Movimiento"
        '
        'TxtTotal
        '
        Me.TxtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTotal.Location = New System.Drawing.Point(671, 226)
        Me.TxtTotal.MaxLength = 10
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(112, 20)
        Me.TxtTotal.TabIndex = 1
        Me.TxtTotal.Text = "0"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(625, 229)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 77
        Me.Label9.Text = "Total:"
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
        Me.DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmCodigo, Me.clmProducto, Me.clmLote, Me.clmCantidad, Me.clmUnidadMedida, Me.clmCosto, Me.clmImporte, Me.clmEstatus, Me.clmIva, Me.clmFechaCaducidad})
        Me.DataGrid.Location = New System.Drawing.Point(6, 19)
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        Me.DataGrid.Size = New System.Drawing.Size(777, 201)
        Me.DataGrid.TabIndex = 0
        '
        'clmCodigo
        '
        Me.clmCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmCodigo.HeaderText = "Código"
        Me.clmCodigo.Name = "clmCodigo"
        Me.clmCodigo.ReadOnly = True
        Me.clmCodigo.Width = 65
        '
        'clmProducto
        '
        Me.clmProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmProducto.HeaderText = "Producto"
        Me.clmProducto.Name = "clmProducto"
        Me.clmProducto.ReadOnly = True
        Me.clmProducto.Width = 75
        '
        'clmLote
        '
        Me.clmLote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle16.NullValue = """"""
        Me.clmLote.DefaultCellStyle = DataGridViewCellStyle16
        Me.clmLote.HeaderText = "Lote"
        Me.clmLote.Name = "clmLote"
        Me.clmLote.ReadOnly = True
        Me.clmLote.Width = 53
        '
        'clmCantidad
        '
        Me.clmCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle17.Format = "N3"
        DataGridViewCellStyle17.NullValue = Nothing
        Me.clmCantidad.DefaultCellStyle = DataGridViewCellStyle17
        Me.clmCantidad.HeaderText = "Cantidad"
        Me.clmCantidad.Name = "clmCantidad"
        Me.clmCantidad.ReadOnly = True
        Me.clmCantidad.Width = 74
        '
        'clmUnidadMedida
        '
        Me.clmUnidadMedida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmUnidadMedida.HeaderText = "Unidad Medida"
        Me.clmUnidadMedida.Name = "clmUnidadMedida"
        Me.clmUnidadMedida.ReadOnly = True
        Me.clmUnidadMedida.Width = 96
        '
        'clmCosto
        '
        Me.clmCosto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle18.Format = "C2"
        DataGridViewCellStyle18.NullValue = Nothing
        Me.clmCosto.DefaultCellStyle = DataGridViewCellStyle18
        Me.clmCosto.HeaderText = "Costo"
        Me.clmCosto.Name = "clmCosto"
        Me.clmCosto.ReadOnly = True
        Me.clmCosto.Width = 59
        '
        'clmImporte
        '
        Me.clmImporte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle19.Format = "C2"
        DataGridViewCellStyle19.NullValue = Nothing
        Me.clmImporte.DefaultCellStyle = DataGridViewCellStyle19
        Me.clmImporte.HeaderText = "Importe"
        Me.clmImporte.Name = "clmImporte"
        Me.clmImporte.ReadOnly = True
        Me.clmImporte.Width = 67
        '
        'clmEstatus
        '
        Me.clmEstatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmEstatus.HeaderText = "Estatus"
        Me.clmEstatus.Name = "clmEstatus"
        Me.clmEstatus.ReadOnly = True
        Me.clmEstatus.Visible = False
        '
        'clmIva
        '
        Me.clmIva.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle20.Format = "C2"
        DataGridViewCellStyle20.NullValue = Nothing
        Me.clmIva.DefaultCellStyle = DataGridViewCellStyle20
        Me.clmIva.HeaderText = "Iva"
        Me.clmIva.Name = "clmIva"
        Me.clmIva.ReadOnly = True
        Me.clmIva.Visible = False
        '
        'clmFechaCaducidad
        '
        Me.clmFechaCaducidad.HeaderText = "Fecha Caducidad"
        Me.clmFechaCaducidad.Name = "clmFechaCaducidad"
        Me.clmFechaCaducidad.ReadOnly = True
        Me.clmFechaCaducidad.Visible = False
        '
        'TxtAlmDest
        '
        Me.TxtAlmDest.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAlmDest.Enabled = False
        Me.TxtAlmDest.Location = New System.Drawing.Point(111, 112)
        Me.TxtAlmDest.MaxLength = 30
        Me.TxtAlmDest.Name = "TxtAlmDest"
        Me.TxtAlmDest.ReadOnly = True
        Me.TxtAlmDest.Size = New System.Drawing.Size(401, 20)
        Me.TxtAlmDest.TabIndex = 6
        '
        'TxtAlmOrigen
        '
        Me.TxtAlmOrigen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAlmOrigen.Enabled = False
        Me.TxtAlmOrigen.Location = New System.Drawing.Point(111, 85)
        Me.TxtAlmOrigen.MaxLength = 30
        Me.TxtAlmOrigen.Name = "TxtAlmOrigen"
        Me.TxtAlmOrigen.ReadOnly = True
        Me.TxtAlmOrigen.Size = New System.Drawing.Size(401, 20)
        Me.TxtAlmOrigen.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 13)
        Me.Label8.TabIndex = 96
        Me.Label8.Text = "Almacén Destino:"
        '
        'TxtFolioEntrada
        '
        Me.TxtFolioEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtFolioEntrada.Enabled = False
        Me.TxtFolioEntrada.Location = New System.Drawing.Point(111, 5)
        Me.TxtFolioEntrada.MaxLength = 6
        Me.TxtFolioEntrada.Name = "TxtFolioEntrada"
        Me.TxtFolioEntrada.ReadOnly = True
        Me.TxtFolioEntrada.Size = New System.Drawing.Size(143, 20)
        Me.TxtFolioEntrada.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 94
        Me.Label7.Text = "Folio Entrada:"
        '
        'DTPFecha
        '
        Me.DTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecha.Location = New System.Drawing.Point(306, 5)
        Me.DTPFecha.Name = "DTPFecha"
        Me.DTPFecha.Size = New System.Drawing.Size(106, 20)
        Me.DTPFecha.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(260, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Fecha:"
        '
        'TxtRecibe
        '
        Me.TxtRecibe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtRecibe.Location = New System.Drawing.Point(111, 163)
        Me.TxtRecibe.MaxLength = 30
        Me.TxtRecibe.Name = "TxtRecibe"
        Me.TxtRecibe.Size = New System.Drawing.Size(401, 20)
        Me.TxtRecibe.TabIndex = 8
        '
        'TxtEntrega
        '
        Me.TxtEntrega.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtEntrega.Location = New System.Drawing.Point(111, 136)
        Me.TxtEntrega.MaxLength = 30
        Me.TxtEntrega.Name = "TxtEntrega"
        Me.TxtEntrega.Size = New System.Drawing.Size(401, 20)
        Me.TxtEntrega.TabIndex = 7
        '
        'CmbPlaza
        '
        Me.CmbPlaza.DataSource = Me.PlazaCol
        Me.CmbPlaza.DisplayMember = "Descripcion"
        Me.CmbPlaza.FormattingEnabled = True
        Me.CmbPlaza.Location = New System.Drawing.Point(111, 30)
        Me.CmbPlaza.Name = "CmbPlaza"
        Me.CmbPlaza.Size = New System.Drawing.Size(401, 21)
        Me.CmbPlaza.TabIndex = 1
        Me.CmbPlaza.ValueMember = "Codigo"
        Me.CmbPlaza.Visible = False
        '
        'PlazaCol
        '
        Me.PlazaCol.AllowEdit = True
        Me.PlazaCol.AllowNew = True
        Me.PlazaCol.AllowRemove = True
        Me.PlazaCol.Name = ""
        Me.PlazaCol.RaiseListChangedEvents = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 89
        Me.Label5.Text = "Recibe:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "Entrega:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Almacén Origen:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Folio Salida:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Plaza:"
        Me.Label1.Visible = False
        '
        'CatAlmRegEntAlmTransferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 577)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(798, 510)
        Me.Name = "CatAlmRegEntAlmTransferencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Entradas a Almacén por Transferencias"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TxtAlmDest As System.Windows.Forms.TextBox
    Friend WithEvents TxtAlmOrigen As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtFolioEntrada As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DTPFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtRecibe As System.Windows.Forms.TextBox
    Friend WithEvents TxtEntrega As System.Windows.Forms.TextBox
    Friend WithEvents CmbPlaza As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents PlazaCol As ClasesNegocio.PlazaCollectionClass
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents mtxtFolioSalida As System.Windows.Forms.MaskedTextBox
    Friend WithEvents clmCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmLote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmUnidadMedida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCosto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaCaducidad As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
