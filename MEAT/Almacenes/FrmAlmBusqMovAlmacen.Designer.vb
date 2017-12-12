<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAlmBusqMovAmacen
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DgvDetalle = New System.Windows.Forms.DataGridView
        Me.clmIdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmProducto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmMedida = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCosto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmImporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIva = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmDescuento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label5 = New System.Windows.Forms.Label
        Me.CmbMovimientos = New System.Windows.Forms.ComboBox
        Me.txtFolio = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DgvMovimientos = New System.Windows.Forms.DataGridView
        Me.ClmFolio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmAlmacen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmFecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEntrego = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmRecibio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmAlmacenId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChkFechas = New System.Windows.Forms.CheckBox
        Me.GrpFechas = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.DtpFechaFin = New System.Windows.Forms.DateTimePicker
        Me.DtpFechaIni = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.LblAlmacen = New System.Windows.Forms.Label
        Me.CmbAlmacenes = New System.Windows.Forms.ComboBox
        Me.BtnAceptar = New System.Windows.Forms.Button
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.TMovCol = New ClasesNegocio.TipoMovimientoAlmacenCollectionClass
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpFechas.SuspendLayout()
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
        Me.mtb.HabilitarEditar = False
        Me.mtb.HabilitarGuardar = True
        Me.mtb.HabilitarImprimir = False
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
        Me.mtb.Size = New System.Drawing.Size(50, 633)
        Me.mtb.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(50, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(758, 29)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "BÚSQUEDA DE MOVIMIENTOS DE ALMACÉN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CmbMovimientos)
        Me.GroupBox1.Controls.Add(Me.txtFolio)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.ChkFechas)
        Me.GroupBox1.Controls.Add(Me.GrpFechas)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LblAlmacen)
        Me.GroupBox1.Controls.Add(Me.CmbAlmacenes)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(745, 555)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DgvDetalle)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 325)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(669, 218)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalle"
        '
        'DgvDetalle
        '
        Me.DgvDetalle.AllowUserToAddRows = False
        Me.DgvDetalle.AllowUserToDeleteRows = False
        Me.DgvDetalle.AllowUserToResizeRows = False
        Me.DgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmIdProducto, Me.clmProducto, Me.clmCantidad, Me.clmMedida, Me.clmCosto, Me.clmImporte, Me.clmIva, Me.clmDescuento})
        Me.DgvDetalle.Location = New System.Drawing.Point(6, 19)
        Me.DgvDetalle.MultiSelect = False
        Me.DgvDetalle.Name = "DgvDetalle"
        Me.DgvDetalle.ReadOnly = True
        Me.DgvDetalle.RowHeadersVisible = False
        Me.DgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDetalle.Size = New System.Drawing.Size(654, 194)
        Me.DgvDetalle.TabIndex = 0
        '
        'clmIdProducto
        '
        Me.clmIdProducto.DataPropertyName = "Codigo"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.clmIdProducto.DefaultCellStyle = DataGridViewCellStyle5
        Me.clmIdProducto.HeaderText = "Código"
        Me.clmIdProducto.Name = "clmIdProducto"
        Me.clmIdProducto.ReadOnly = True
        Me.clmIdProducto.Width = 50
        '
        'clmProducto
        '
        Me.clmProducto.DataPropertyName = "Producto"
        Me.clmProducto.HeaderText = "Producto"
        Me.clmProducto.Name = "clmProducto"
        Me.clmProducto.ReadOnly = True
        Me.clmProducto.Width = 200
        '
        'clmCantidad
        '
        Me.clmCantidad.DataPropertyName = "Cantidad"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.clmCantidad.DefaultCellStyle = DataGridViewCellStyle6
        Me.clmCantidad.HeaderText = "Cantidad"
        Me.clmCantidad.Name = "clmCantidad"
        Me.clmCantidad.ReadOnly = True
        '
        'clmMedida
        '
        Me.clmMedida.DataPropertyName = "Medida"
        Me.clmMedida.HeaderText = "Medida"
        Me.clmMedida.Name = "clmMedida"
        Me.clmMedida.ReadOnly = True
        '
        'clmCosto
        '
        Me.clmCosto.DataPropertyName = "Costo"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomRight
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.clmCosto.DefaultCellStyle = DataGridViewCellStyle7
        Me.clmCosto.HeaderText = "Costo"
        Me.clmCosto.Name = "clmCosto"
        Me.clmCosto.ReadOnly = True
        '
        'clmImporte
        '
        Me.clmImporte.DataPropertyName = "Importe"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "C2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.clmImporte.DefaultCellStyle = DataGridViewCellStyle8
        Me.clmImporte.HeaderText = "Importe"
        Me.clmImporte.Name = "clmImporte"
        Me.clmImporte.ReadOnly = True
        '
        'clmIva
        '
        Me.clmIva.DataPropertyName = "IVA"
        Me.clmIva.HeaderText = "IVA"
        Me.clmIva.Name = "clmIva"
        Me.clmIva.ReadOnly = True
        Me.clmIva.Visible = False
        '
        'clmDescuento
        '
        Me.clmDescuento.DataPropertyName = "Descuento"
        Me.clmDescuento.HeaderText = "Descuento"
        Me.clmDescuento.Name = "clmDescuento"
        Me.clmDescuento.ReadOnly = True
        Me.clmDescuento.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Movimiento:"
        '
        'CmbMovimientos
        '
        Me.CmbMovimientos.DataSource = Me.TMovCol
        Me.CmbMovimientos.DisplayMember = "Nombre"
        Me.CmbMovimientos.FormattingEnabled = True
        Me.CmbMovimientos.Location = New System.Drawing.Point(83, 68)
        Me.CmbMovimientos.Name = "CmbMovimientos"
        Me.CmbMovimientos.Size = New System.Drawing.Size(253, 21)
        Me.CmbMovimientos.TabIndex = 8
        Me.CmbMovimientos.ValueMember = "Codigo"
        '
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(83, 15)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(100, 20)
        Me.txtFolio.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DgvMovimientos)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 99)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(733, 207)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Movimientos"
        '
        'DgvMovimientos
        '
        Me.DgvMovimientos.AllowUserToAddRows = False
        Me.DgvMovimientos.AllowUserToDeleteRows = False
        Me.DgvMovimientos.AllowUserToResizeRows = False
        Me.DgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMovimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClmFolio, Me.clmAlmacen, Me.ClmFecha, Me.clmEntrego, Me.clmRecibio, Me.clmObservaciones, Me.clmAlmacenId})
        Me.DgvMovimientos.Location = New System.Drawing.Point(6, 19)
        Me.DgvMovimientos.MultiSelect = False
        Me.DgvMovimientos.Name = "DgvMovimientos"
        Me.DgvMovimientos.ReadOnly = True
        Me.DgvMovimientos.RowHeadersVisible = False
        Me.DgvMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvMovimientos.Size = New System.Drawing.Size(721, 180)
        Me.DgvMovimientos.TabIndex = 0
        '
        'ClmFolio
        '
        Me.ClmFolio.DataPropertyName = "FolioMovimiento"
        Me.ClmFolio.HeaderText = "Folio"
        Me.ClmFolio.Name = "ClmFolio"
        Me.ClmFolio.ReadOnly = True
        '
        'clmAlmacen
        '
        Me.clmAlmacen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clmAlmacen.DataPropertyName = "Almacen"
        Me.clmAlmacen.HeaderText = "Almacén"
        Me.clmAlmacen.Name = "clmAlmacen"
        Me.clmAlmacen.ReadOnly = True
        Me.clmAlmacen.Width = 73
        '
        'ClmFecha
        '
        Me.ClmFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ClmFecha.DataPropertyName = "Fecha"
        Me.ClmFecha.HeaderText = "Fecha"
        Me.ClmFecha.Name = "ClmFecha"
        Me.ClmFecha.ReadOnly = True
        Me.ClmFecha.Width = 62
        '
        'clmEntrego
        '
        Me.clmEntrego.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clmEntrego.DataPropertyName = "Entrega"
        Me.clmEntrego.HeaderText = "Entregó"
        Me.clmEntrego.Name = "clmEntrego"
        Me.clmEntrego.ReadOnly = True
        Me.clmEntrego.Width = 69
        '
        'clmRecibio
        '
        Me.clmRecibio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clmRecibio.DataPropertyName = "Recibe"
        Me.clmRecibio.HeaderText = "Recibió"
        Me.clmRecibio.Name = "clmRecibio"
        Me.clmRecibio.ReadOnly = True
        Me.clmRecibio.Width = 68
        '
        'clmObservaciones
        '
        Me.clmObservaciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clmObservaciones.DataPropertyName = "Observaciones"
        Me.clmObservaciones.HeaderText = "Observaciones"
        Me.clmObservaciones.Name = "clmObservaciones"
        Me.clmObservaciones.ReadOnly = True
        Me.clmObservaciones.Width = 103
        '
        'clmAlmacenId
        '
        Me.clmAlmacenId.DataPropertyName = "AlmacenId"
        Me.clmAlmacenId.HeaderText = "AlmacenId"
        Me.clmAlmacenId.Name = "clmAlmacenId"
        Me.clmAlmacenId.ReadOnly = True
        Me.clmAlmacenId.Visible = False
        '
        'ChkFechas
        '
        Me.ChkFechas.AutoSize = True
        Me.ChkFechas.Location = New System.Drawing.Point(368, 17)
        Me.ChkFechas.Name = "ChkFechas"
        Me.ChkFechas.Size = New System.Drawing.Size(111, 17)
        Me.ChkFechas.TabIndex = 5
        Me.ChkFechas.Text = "Rango de Fechas"
        Me.ChkFechas.UseVisualStyleBackColor = True
        '
        'GrpFechas
        '
        Me.GrpFechas.Controls.Add(Me.Label4)
        Me.GrpFechas.Controls.Add(Me.Label3)
        Me.GrpFechas.Controls.Add(Me.DtpFechaFin)
        Me.GrpFechas.Controls.Add(Me.DtpFechaIni)
        Me.GrpFechas.Enabled = False
        Me.GrpFechas.Location = New System.Drawing.Point(368, 40)
        Me.GrpFechas.Name = "GrpFechas"
        Me.GrpFechas.Size = New System.Drawing.Size(365, 53)
        Me.GrpFechas.TabIndex = 4
        Me.GrpFechas.TabStop = False
        Me.GrpFechas.Text = "Fechas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(194, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fecha Final:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Fecha Inicial:"
        '
        'DtpFechaFin
        '
        Me.DtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaFin.Location = New System.Drawing.Point(265, 17)
        Me.DtpFechaFin.Name = "DtpFechaFin"
        Me.DtpFechaFin.Size = New System.Drawing.Size(93, 20)
        Me.DtpFechaFin.TabIndex = 1
        '
        'DtpFechaIni
        '
        Me.DtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaIni.Location = New System.Drawing.Point(82, 17)
        Me.DtpFechaIni.Name = "DtpFechaIni"
        Me.DtpFechaIni.Size = New System.Drawing.Size(93, 20)
        Me.DtpFechaIni.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Folio:"
        '
        'LblAlmacen
        '
        Me.LblAlmacen.AutoSize = True
        Me.LblAlmacen.Location = New System.Drawing.Point(11, 44)
        Me.LblAlmacen.Name = "LblAlmacen"
        Me.LblAlmacen.Size = New System.Drawing.Size(51, 13)
        Me.LblAlmacen.TabIndex = 1
        Me.LblAlmacen.Text = "Almacén:"
        '
        'CmbAlmacenes
        '
        Me.CmbAlmacenes.FormattingEnabled = True
        Me.CmbAlmacenes.Location = New System.Drawing.Point(83, 41)
        Me.CmbAlmacenes.Name = "CmbAlmacenes"
        Me.CmbAlmacenes.Size = New System.Drawing.Size(253, 21)
        Me.CmbAlmacenes.TabIndex = 0
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(621, 598)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 13
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(714, 598)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 14
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'TMovCol
        '
        Me.TMovCol.AllowEdit = True
        Me.TMovCol.AllowNew = True
        Me.TMovCol.AllowRemove = True
        Me.TMovCol.Name = ""
        Me.TMovCol.RaiseListChangedEvents = True
        '
        'FrmAlmBusqMovAmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 633)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmAlmBusqMovAmacen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Búsqueda de Movimientos de Almacén"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DgvMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpFechas.ResumeLayout(False)
        Me.GrpFechas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkFechas As System.Windows.Forms.CheckBox
    Friend WithEvents GrpFechas As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblAlmacen As System.Windows.Forms.Label
    Friend WithEvents CmbAlmacenes As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DgvMovimientos As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CmbMovimientos As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents clmIdProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmMedida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCosto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDescuento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents ClmFolio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmAlmacen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEntrego As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmRecibio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmObservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmAlmacenId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TMovCol As ClasesNegocio.TipoMovimientoAlmacenCollectionClass
End Class
