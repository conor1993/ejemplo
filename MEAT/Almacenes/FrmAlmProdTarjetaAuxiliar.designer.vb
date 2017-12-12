<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAlmProdTarjetaAuxiliar
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbAlmacen = New System.Windows.Forms.ComboBox
        Me.AlmacenC = New ClasesNegocio.AlmacenCollectionClass
        Me.CmbProducto = New System.Windows.Forms.ComboBox
        Me.ProductosCol = New ClasesNegocio.ProductosCollectionsClass
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtExistenciaInicialKgrs = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtExistenciaInicialPzas = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.DtFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.dtFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dtpFechaUltimaSalida = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtpFechaUltimaEntrada = New System.Windows.Forms.DateTimePicker
        Me.dgvDetalles = New System.Windows.Forms.DataGridView
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtExistenciasEnKilos = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtExistenciaEnPiezas = New System.Windows.Forms.TextBox
        Me.clmFolio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCantidadPzas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCantidadKgrs = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmTipoMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Label1.Size = New System.Drawing.Size(653, 38)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "TARJETA AUXILIAR DE CORTES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.mtb.MostrarGuardar = False
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 432)
        Me.mtb.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Almacén:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Corte :"
        '
        'cmbAlmacen
        '
        Me.cmbAlmacen.DataSource = Me.AlmacenC
        Me.cmbAlmacen.DisplayMember = "Descripcion"
        Me.cmbAlmacen.FormattingEnabled = True
        Me.cmbAlmacen.Location = New System.Drawing.Point(113, 57)
        Me.cmbAlmacen.Name = "cmbAlmacen"
        Me.cmbAlmacen.Size = New System.Drawing.Size(359, 21)
        Me.cmbAlmacen.TabIndex = 30
        Me.cmbAlmacen.ValueMember = "Codigo"
        '
        'AlmacenC
        '
        Me.AlmacenC.AllowEdit = True
        Me.AlmacenC.AllowNew = True
        Me.AlmacenC.AllowRemove = True
        Me.AlmacenC.Name = ""
        Me.AlmacenC.RaiseListChangedEvents = True
        Me.AlmacenC.Tipo = ClasesNegocio.AlmacenEnum.ALMACEN
        '
        'CmbProducto
        '
        Me.CmbProducto.DataSource = Me.ProductosCol
        Me.CmbProducto.DisplayMember = "Descripcion"
        Me.CmbProducto.FormattingEnabled = True
        Me.CmbProducto.Location = New System.Drawing.Point(113, 84)
        Me.CmbProducto.Name = "CmbProducto"
        Me.CmbProducto.Size = New System.Drawing.Size(359, 21)
        Me.CmbProducto.TabIndex = 31
        Me.CmbProducto.ValueMember = "IdProducto"
        '
        'ProductosCol
        '
        Me.ProductosCol.AllowEdit = True
        Me.ProductosCol.AllowNew = True
        Me.ProductosCol.AllowRemove = True
        Me.ProductosCol.Name = ""
        Me.ProductosCol.RaiseListChangedEvents = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(347, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Ultima Fecha:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.txtExistenciaInicialKgrs)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.txtExistenciaInicialPzas)
        Me.GroupBox4.Location = New System.Drawing.Point(59, 168)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(176, 82)
        Me.GroupBox4.TabIndex = 34
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Existencias Iniciales"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 52)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Kilos :"
        '
        'txtExistenciaInicialKgrs
        '
        Me.txtExistenciaInicialKgrs.Location = New System.Drawing.Point(55, 49)
        Me.txtExistenciaInicialKgrs.Name = "txtExistenciaInicialKgrs"
        Me.txtExistenciaInicialKgrs.ReadOnly = True
        Me.txtExistenciaInicialKgrs.Size = New System.Drawing.Size(93, 20)
        Me.txtExistenciaInicialKgrs.TabIndex = 5
        Me.txtExistenciaInicialKgrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Piezas :"
        '
        'txtExistenciaInicialPzas
        '
        Me.txtExistenciaInicialPzas.Location = New System.Drawing.Point(55, 22)
        Me.txtExistenciaInicialPzas.Name = "txtExistenciaInicialPzas"
        Me.txtExistenciaInicialPzas.ReadOnly = True
        Me.txtExistenciaInicialPzas.Size = New System.Drawing.Size(93, 20)
        Me.txtExistenciaInicialPzas.TabIndex = 3
        Me.txtExistenciaInicialPzas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DtFechaFinal)
        Me.GroupBox1.Controls.Add(Me.dtFechaInicial)
        Me.GroupBox1.Location = New System.Drawing.Point(59, 111)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(413, 51)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rengo de Fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(202, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Fecha Final:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Fecha Inicio:"
        '
        'DtFechaFinal
        '
        Me.DtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaFinal.Location = New System.Drawing.Point(276, 20)
        Me.DtFechaFinal.Name = "DtFechaFinal"
        Me.DtFechaFinal.Size = New System.Drawing.Size(96, 20)
        Me.DtFechaFinal.TabIndex = 3
        '
        'dtFechaInicial
        '
        Me.dtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaInicial.Location = New System.Drawing.Point(80, 20)
        Me.dtFechaInicial.Name = "dtFechaInicial"
        Me.dtFechaInicial.Size = New System.Drawing.Size(96, 20)
        Me.dtFechaInicial.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpFechaUltimaSalida)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(241, 168)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(231, 82)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        '
        'dtpFechaUltimaSalida
        '
        Me.dtpFechaUltimaSalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaUltimaSalida.Location = New System.Drawing.Point(124, 49)
        Me.dtpFechaUltimaSalida.Name = "dtpFechaUltimaSalida"
        Me.dtpFechaUltimaSalida.Size = New System.Drawing.Size(96, 20)
        Me.dtpFechaUltimaSalida.TabIndex = 37
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Fecha Ultima Salida :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Fecha Ultima Entrada :"
        '
        'dtpFechaUltimaEntrada
        '
        Me.dtpFechaUltimaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaUltimaEntrada.Location = New System.Drawing.Point(365, 190)
        Me.dtpFechaUltimaEntrada.Name = "dtpFechaUltimaEntrada"
        Me.dtpFechaUltimaEntrada.Size = New System.Drawing.Size(96, 20)
        Me.dtpFechaUltimaEntrada.TabIndex = 4
        '
        'dgvDetalles
        '
        Me.dgvDetalles.AllowUserToAddRows = False
        Me.dgvDetalles.AllowUserToDeleteRows = False
        Me.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmFolio, Me.clmFecha, Me.clmMovimiento, Me.clmCantidadPzas, Me.clmCantidadKgrs, Me.clmTipoMovimiento})
        Me.dgvDetalles.Location = New System.Drawing.Point(59, 256)
        Me.dgvDetalles.Name = "dgvDetalles"
        Me.dgvDetalles.ReadOnly = True
        Me.dgvDetalles.RowHeadersVisible = False
        Me.dgvDetalles.Size = New System.Drawing.Size(621, 150)
        Me.dgvDetalles.TabIndex = 37
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtExistenciasEnKilos)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtExistenciaEnPiezas)
        Me.GroupBox3.Location = New System.Drawing.Point(495, 168)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(176, 82)
        Me.GroupBox3.TabIndex = 38
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Existencias "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Kilos :"
        '
        'txtExistenciasEnKilos
        '
        Me.txtExistenciasEnKilos.Location = New System.Drawing.Point(55, 49)
        Me.txtExistenciasEnKilos.Name = "txtExistenciasEnKilos"
        Me.txtExistenciasEnKilos.ReadOnly = True
        Me.txtExistenciasEnKilos.Size = New System.Drawing.Size(93, 20)
        Me.txtExistenciasEnKilos.TabIndex = 5
        Me.txtExistenciasEnKilos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Piezas :"
        '
        'txtExistenciaEnPiezas
        '
        Me.txtExistenciaEnPiezas.Location = New System.Drawing.Point(55, 22)
        Me.txtExistenciaEnPiezas.Name = "txtExistenciaEnPiezas"
        Me.txtExistenciaEnPiezas.ReadOnly = True
        Me.txtExistenciaEnPiezas.Size = New System.Drawing.Size(93, 20)
        Me.txtExistenciaEnPiezas.TabIndex = 3
        Me.txtExistenciaEnPiezas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'clmFolio
        '
        Me.clmFolio.DataPropertyName = "IdFolioMovimiento"
        Me.clmFolio.HeaderText = "Folio"
        Me.clmFolio.Name = "clmFolio"
        Me.clmFolio.ReadOnly = True
        '
        'clmFecha
        '
        Me.clmFecha.DataPropertyName = "FechaMovimiento"
        Me.clmFecha.HeaderText = "Fecha"
        Me.clmFecha.Name = "clmFecha"
        Me.clmFecha.ReadOnly = True
        Me.clmFecha.Width = 90
        '
        'clmMovimiento
        '
        Me.clmMovimiento.DataPropertyName = "Descripcion"
        Me.clmMovimiento.HeaderText = "Movimiento"
        Me.clmMovimiento.Name = "clmMovimiento"
        Me.clmMovimiento.ReadOnly = True
        Me.clmMovimiento.Width = 250
        '
        'clmCantidadPzas
        '
        Me.clmCantidadPzas.DataPropertyName = "CantPzas"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = "0"
        Me.clmCantidadPzas.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmCantidadPzas.HeaderText = "Piezas"
        Me.clmCantidadPzas.Name = "clmCantidadPzas"
        Me.clmCantidadPzas.ReadOnly = True
        Me.clmCantidadPzas.Width = 80
        '
        'clmCantidadKgrs
        '
        Me.clmCantidadKgrs.DataPropertyName = "CantKilos"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.clmCantidadKgrs.DefaultCellStyle = DataGridViewCellStyle4
        Me.clmCantidadKgrs.HeaderText = "Kilos"
        Me.clmCantidadKgrs.Name = "clmCantidadKgrs"
        Me.clmCantidadKgrs.ReadOnly = True
        Me.clmCantidadKgrs.Width = 80
        '
        'clmTipoMovimiento
        '
        Me.clmTipoMovimiento.DataPropertyName = "TipoMovimiento"
        Me.clmTipoMovimiento.HeaderText = "Direccion"
        Me.clmTipoMovimiento.Name = "clmTipoMovimiento"
        Me.clmTipoMovimiento.ReadOnly = True
        Me.clmTipoMovimiento.Visible = False
        '
        'FrmAlmProdTarjetaAuxiliar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 432)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dgvDetalles)
        Me.Controls.Add(Me.dtpFechaUltimaEntrada)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbAlmacen)
        Me.Controls.Add(Me.CmbProducto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mtb)
        Me.Name = "FrmAlmProdTarjetaAuxiliar"
        Me.Text = "TARJETA AUXILIAR DE CORTES"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents CmbProducto As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtExistenciaInicialKgrs As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtExistenciaInicialPzas As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DtFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaUltimaSalida As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaUltimaEntrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgvDetalles As System.Windows.Forms.DataGridView
    Friend WithEvents AlmacenC As ClasesNegocio.AlmacenCollectionClass
    Friend WithEvents ProductosCol As ClasesNegocio.ProductosCollectionsClass
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtExistenciasEnKilos As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtExistenciaEnPiezas As System.Windows.Forms.TextBox
    Friend WithEvents clmFolio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmMovimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCantidadPzas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCantidadKgrs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTipoMovimiento As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
