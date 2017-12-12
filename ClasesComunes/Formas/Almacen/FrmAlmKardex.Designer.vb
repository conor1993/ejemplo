<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAlmKardex
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.mtb = New MEAToolBar.MEAToolBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbAlmacen = New System.Windows.Forms.ComboBox()
        Me.AlmacenC = New ClasesNegocio.AlmacenCollectionClass()
        Me.CmbProducto = New System.Windows.Forms.ComboBox()
        Me.ProductosVistaC = New ClasesNegocio.ProductosVistaCollectionClass()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLinea = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUnidadMed = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbMes = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DgvDetalles = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtExistencia = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTotalSalidas = New System.Windows.Forms.TextBox()
        Me.txtTotalEntradas = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtExistenciaInicial = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCostoInicial = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CmbAño = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.clmFechaMov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFolioMvto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmEntrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmSalida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmExistencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCostoProm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgvDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
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
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 450)
        Me.mtb.TabIndex = 9
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
        Me.Label1.Size = New System.Drawing.Size(846, 29)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "KARDEX DE PRODUCTOS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Almacén:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Producto:"
        '
        'cmbAlmacen
        '
        Me.cmbAlmacen.DataSource = Me.AlmacenC
        Me.cmbAlmacen.DisplayMember = "Descripcion"
        Me.cmbAlmacen.FormattingEnabled = True
        Me.cmbAlmacen.Location = New System.Drawing.Point(70, 46)
        Me.cmbAlmacen.Name = "cmbAlmacen"
        Me.cmbAlmacen.Size = New System.Drawing.Size(359, 21)
        Me.cmbAlmacen.TabIndex = 13
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
        Me.CmbProducto.FormattingEnabled = True
        Me.CmbProducto.Location = New System.Drawing.Point(70, 19)
        Me.CmbProducto.Name = "CmbProducto"
        Me.CmbProducto.Size = New System.Drawing.Size(359, 21)
        Me.CmbProducto.TabIndex = 27
        '
        'ProductosVistaC
        '
        Me.ProductosVistaC.AllowEdit = True
        Me.ProductosVistaC.AllowNew = True
        Me.ProductosVistaC.AllowRemove = True
        Me.ProductosVistaC.Name = ""
        Me.ProductosVistaC.RaiseListChangedEvents = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Linea:"
        '
        'txtLinea
        '
        Me.txtLinea.Location = New System.Drawing.Point(70, 73)
        Me.txtLinea.Name = "txtLinea"
        Me.txtLinea.ReadOnly = True
        Me.txtLinea.Size = New System.Drawing.Size(157, 20)
        Me.txtLinea.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(233, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Unidad de Medida:"
        '
        'txtUnidadMed
        '
        Me.txtUnidadMed.Location = New System.Drawing.Point(336, 73)
        Me.txtUnidadMed.Name = "txtUnidadMed"
        Me.txtUnidadMed.ReadOnly = True
        Me.txtUnidadMed.Size = New System.Drawing.Size(93, 20)
        Me.txtUnidadMed.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Mes Inicial:"
        '
        'cmbMes
        '
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Location = New System.Drawing.Point(70, 99)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(133, 21)
        Me.cmbMes.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(233, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Ultima Fecha:"
        '
        'DtpFecha
        '
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpFecha.Location = New System.Drawing.Point(336, 99)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(93, 20)
        Me.DtpFecha.TabIndex = 22
        Me.DtpFecha.Value = New Date(2008, 4, 8, 0, 0, 0, 0)
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.CmbAño)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DtpFecha)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmbAlmacen)
        Me.GroupBox1.Controls.Add(Me.cmbMes)
        Me.GroupBox1.Controls.Add(Me.CmbProducto)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtUnidadMed)
        Me.GroupBox1.Controls.Add(Me.txtLinea)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(55, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(829, 406)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.DgvDetalles)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 163)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(816, 237)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalle de Movimientos"
        '
        'DgvDetalles
        '
        Me.DgvDetalles.AllowUserToAddRows = False
        Me.DgvDetalles.AllowUserToDeleteRows = False
        Me.DgvDetalles.AllowUserToResizeRows = False
        Me.DgvDetalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmFechaMov, Me.clmFolioMvto, Me.clmMovimiento, Me.clmEntrada, Me.clmSalida, Me.clmExistencia, Me.clmCosto, Me.clmCostoProm})
        Me.DgvDetalles.Location = New System.Drawing.Point(6, 19)
        Me.DgvDetalles.Name = "DgvDetalles"
        Me.DgvDetalles.ReadOnly = True
        Me.DgvDetalles.RowHeadersVisible = False
        Me.DgvDetalles.Size = New System.Drawing.Size(804, 212)
        Me.DgvDetalles.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.txtExistencia)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtTotalSalidas)
        Me.GroupBox2.Controls.Add(Me.txtTotalEntradas)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtExistenciaInicial)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtCostoInicial)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(557, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(266, 144)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        '
        'txtExistencia
        '
        Me.txtExistencia.Location = New System.Drawing.Point(109, 117)
        Me.txtExistencia.Name = "txtExistencia"
        Me.txtExistencia.ReadOnly = True
        Me.txtExistencia.Size = New System.Drawing.Size(118, 20)
        Me.txtExistencia.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 115)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Existencia Actual:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 91)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Total de Salidas:"
        '
        'txtTotalSalidas
        '
        Me.txtTotalSalidas.Location = New System.Drawing.Point(109, 91)
        Me.txtTotalSalidas.Name = "txtTotalSalidas"
        Me.txtTotalSalidas.ReadOnly = True
        Me.txtTotalSalidas.Size = New System.Drawing.Size(118, 20)
        Me.txtTotalSalidas.TabIndex = 6
        '
        'txtTotalEntradas
        '
        Me.txtTotalEntradas.Location = New System.Drawing.Point(109, 65)
        Me.txtTotalEntradas.Name = "txtTotalEntradas"
        Me.txtTotalEntradas.ReadOnly = True
        Me.txtTotalEntradas.Size = New System.Drawing.Size(118, 20)
        Me.txtTotalEntradas.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 68)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Total de Entradas:"
        '
        'txtExistenciaInicial
        '
        Me.txtExistenciaInicial.Location = New System.Drawing.Point(109, 39)
        Me.txtExistenciaInicial.Name = "txtExistenciaInicial"
        Me.txtExistenciaInicial.ReadOnly = True
        Me.txtExistenciaInicial.Size = New System.Drawing.Size(118, 20)
        Me.txtExistenciaInicial.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Existencia Inicial:"
        '
        'txtCostoInicial
        '
        Me.txtCostoInicial.Location = New System.Drawing.Point(109, 13)
        Me.txtCostoInicial.Name = "txtCostoInicial"
        Me.txtCostoInicial.ReadOnly = True
        Me.txtCostoInicial.Size = New System.Drawing.Size(118, 20)
        Me.txtCostoInicial.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Costo Inicial:"
        '
        'CmbAño
        '
        Me.CmbAño.FormattingEnabled = True
        Me.CmbAño.Location = New System.Drawing.Point(70, 126)
        Me.CmbAño.Name = "CmbAño"
        Me.CmbAño.Size = New System.Drawing.Size(133, 21)
        Me.CmbAño.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Año Inicial:"
        '
        'clmFechaMov
        '
        Me.clmFechaMov.DataPropertyName = "FechaMovimiento"
        Me.clmFechaMov.FillWeight = 18.0!
        Me.clmFechaMov.HeaderText = "Fecha Movto."
        Me.clmFechaMov.Name = "clmFechaMov"
        Me.clmFechaMov.ReadOnly = True
        '
        'clmFolioMvto
        '
        Me.clmFolioMvto.DataPropertyName = "FolioMovimiento"
        Me.clmFolioMvto.FillWeight = 18.0!
        Me.clmFolioMvto.HeaderText = "Folio Movto."
        Me.clmFolioMvto.Name = "clmFolioMvto"
        Me.clmFolioMvto.ReadOnly = True
        '
        'clmMovimiento
        '
        Me.clmMovimiento.DataPropertyName = "Descripcion"
        Me.clmMovimiento.FillWeight = 18.0!
        Me.clmMovimiento.HeaderText = "Movimiento"
        Me.clmMovimiento.Name = "clmMovimiento"
        Me.clmMovimiento.ReadOnly = True
        '
        'clmEntrada
        '
        Me.clmEntrada.DataPropertyName = "CantidadEntradas"
        Me.clmEntrada.FillWeight = 8.0!
        Me.clmEntrada.HeaderText = "Entrada"
        Me.clmEntrada.Name = "clmEntrada"
        Me.clmEntrada.ReadOnly = True
        '
        'clmSalida
        '
        Me.clmSalida.DataPropertyName = "CantidadSalidas"
        Me.clmSalida.FillWeight = 8.0!
        Me.clmSalida.HeaderText = "Salida"
        Me.clmSalida.Name = "clmSalida"
        Me.clmSalida.ReadOnly = True
        '
        'clmExistencia
        '
        Me.clmExistencia.FillWeight = 10.0!
        Me.clmExistencia.HeaderText = "Existencia"
        Me.clmExistencia.Name = "clmExistencia"
        Me.clmExistencia.ReadOnly = True
        '
        'clmCosto
        '
        Me.clmCosto.DataPropertyName = "Costo"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.clmCosto.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmCosto.FillWeight = 10.0!
        Me.clmCosto.HeaderText = "Costo"
        Me.clmCosto.Name = "clmCosto"
        Me.clmCosto.ReadOnly = True
        '
        'clmCostoProm
        '
        Me.clmCostoProm.DataPropertyName = "CostoPromedio"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.clmCostoProm.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmCostoProm.FillWeight = 10.0!
        Me.clmCostoProm.HeaderText = "Costo Prom."
        Me.clmCostoProm.Name = "clmCostoProm"
        Me.clmCostoProm.ReadOnly = True
        '
        'FrmAlmKardex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmAlmKardex"
        Me.Text = "Kardex de Productos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DgvDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents CmbProducto As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLinea As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtUnidadMed As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbMes As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CmbAño As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtExistencia As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTotalSalidas As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalEntradas As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtExistenciaInicial As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCostoInicial As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DgvDetalles As System.Windows.Forms.DataGridView
    Friend WithEvents AlmacenC As ClasesNegocio.AlmacenCollectionClass
    ' Friend WithEvents ProductoC As ClasesNegocio.ProductoCollectionClass
    Friend WithEvents ProductosVistaC As ClasesNegocio.ProductosVistaCollectionClass
    Friend WithEvents clmFechaMov As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFolioMvto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmMovimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEntrada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSalida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmExistencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCosto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCostoProm As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
