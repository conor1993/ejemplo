<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDecomisos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDecomisos))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CmbMotivoDecomiso = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnBascula = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtTotalKilos = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtTotalPiezas = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtPeso = New System.Windows.Forms.TextBox
        Me.txtPiezas = New System.Windows.Forms.TextBox
        Me._LblEtiqueta_3 = New System.Windows.Forms.Label
        Me._LblEtiqueta_7 = New System.Windows.Forms.Label
        Me.dgvDecomisos = New System.Windows.Forms.DataGridView
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmTipoDecomiso = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KilosRastro = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Kilos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIdMotivoDecomiso = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CancelarDecomiso = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmbProductos = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtProductor = New System.Windows.Forms.TextBox
        Me.dtpFechaSacrificio = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtLoteSacrificio = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label17 = New System.Windows.Forms.Label
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.TmProducto = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvDecomisos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmbMotivoDecomiso)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.BtnBascula)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtPeso)
        Me.GroupBox1.Controls.Add(Me.txtPiezas)
        Me.GroupBox1.Controls.Add(Me._LblEtiqueta_3)
        Me.GroupBox1.Controls.Add(Me._LblEtiqueta_7)
        Me.GroupBox1.Controls.Add(Me.dgvDecomisos)
        Me.GroupBox1.Controls.Add(Me.cmbProductos)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtProductor)
        Me.GroupBox1.Controls.Add(Me.dtpFechaSacrificio)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtLoteSacrificio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(60, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(594, 448)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        '
        'CmbMotivoDecomiso
        '
        Me.CmbMotivoDecomiso.FormattingEnabled = True
        Me.CmbMotivoDecomiso.Location = New System.Drawing.Point(122, 119)
        Me.CmbMotivoDecomiso.Name = "CmbMotivoDecomiso"
        Me.CmbMotivoDecomiso.Size = New System.Drawing.Size(260, 21)
        Me.CmbMotivoDecomiso.TabIndex = 94
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 13)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "Motivo de Decomiso :"
        '
        'BtnBascula
        '
        Me.BtnBascula.Image = CType(resources.GetObject("BtnBascula.Image"), System.Drawing.Image)
        Me.BtnBascula.Location = New System.Drawing.Point(398, 170)
        Me.BtnBascula.Name = "BtnBascula"
        Me.BtnBascula.Size = New System.Drawing.Size(76, 50)
        Me.BtnBascula.TabIndex = 92
        Me.BtnBascula.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTotalKilos)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtTotalPiezas)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Location = New System.Drawing.Point(389, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(175, 74)
        Me.GroupBox2.TabIndex = 91
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Total por lote de Sacrificio :"
        '
        'txtTotalKilos
        '
        Me.txtTotalKilos.Enabled = False
        Me.txtTotalKilos.Location = New System.Drawing.Point(65, 47)
        Me.txtTotalKilos.Name = "txtTotalKilos"
        Me.txtTotalKilos.Size = New System.Drawing.Size(102, 20)
        Me.txtTotalKilos.TabIndex = 73
        Me.txtTotalKilos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 47)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 13)
        Me.Label14.TabIndex = 72
        Me.Label14.Text = "Kilos :"
        '
        'txtTotalPiezas
        '
        Me.txtTotalPiezas.Enabled = False
        Me.txtTotalPiezas.Location = New System.Drawing.Point(65, 20)
        Me.txtTotalPiezas.Name = "txtTotalPiezas"
        Me.txtTotalPiezas.Size = New System.Drawing.Size(102, 20)
        Me.txtTotalPiezas.TabIndex = 71
        Me.txtTotalPiezas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(15, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Piezas :"
        '
        'txtPeso
        '
        Me.txtPeso.AcceptsReturn = True
        Me.txtPeso.BackColor = System.Drawing.SystemColors.Window
        Me.txtPeso.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPeso.Enabled = False
        Me.txtPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPeso.Location = New System.Drawing.Point(231, 170)
        Me.txtPeso.MaxLength = 0
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPeso.Size = New System.Drawing.Size(138, 50)
        Me.txtPeso.TabIndex = 88
        Me.txtPeso.Text = "0.00"
        Me.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPiezas
        '
        Me.txtPiezas.AcceptsReturn = True
        Me.txtPiezas.BackColor = System.Drawing.SystemColors.Window
        Me.txtPiezas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPiezas.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPiezas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPiezas.Location = New System.Drawing.Point(94, 170)
        Me.txtPiezas.MaxLength = 0
        Me.txtPiezas.Name = "txtPiezas"
        Me.txtPiezas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPiezas.Size = New System.Drawing.Size(81, 50)
        Me.txtPiezas.TabIndex = 87
        Me.txtPiezas.Text = "0"
        Me.txtPiezas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        '_LblEtiqueta_3
        '
        Me._LblEtiqueta_3.AutoSize = True
        Me._LblEtiqueta_3.BackColor = System.Drawing.SystemColors.Control
        Me._LblEtiqueta_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._LblEtiqueta_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._LblEtiqueta_3.Location = New System.Drawing.Point(190, 170)
        Me._LblEtiqueta_3.Name = "_LblEtiqueta_3"
        Me._LblEtiqueta_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._LblEtiqueta_3.Size = New System.Drawing.Size(35, 13)
        Me._LblEtiqueta_3.TabIndex = 90
        Me._LblEtiqueta_3.Text = "Kilos :"
        '
        '_LblEtiqueta_7
        '
        Me._LblEtiqueta_7.AutoSize = True
        Me._LblEtiqueta_7.BackColor = System.Drawing.SystemColors.Control
        Me._LblEtiqueta_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._LblEtiqueta_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._LblEtiqueta_7.Location = New System.Drawing.Point(4, 170)
        Me._LblEtiqueta_7.Name = "_LblEtiqueta_7"
        Me._LblEtiqueta_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._LblEtiqueta_7.Size = New System.Drawing.Size(44, 13)
        Me._LblEtiqueta_7.TabIndex = 89
        Me._LblEtiqueta_7.Text = "Piezas :"
        '
        'dgvDecomisos
        '
        Me.dgvDecomisos.AllowUserToAddRows = False
        Me.dgvDecomisos.AllowUserToDeleteRows = False
        Me.dgvDecomisos.AllowUserToResizeRows = False
        Me.dgvDecomisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDecomisos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Descripcion, Me.clmTipoDecomiso, Me.KilosRastro, Me.Kilos, Me.clmIdMotivoDecomiso})
        Me.dgvDecomisos.ContextMenuStrip = Me.CancelarDecomiso
        Me.dgvDecomisos.Location = New System.Drawing.Point(9, 226)
        Me.dgvDecomisos.Name = "dgvDecomisos"
        Me.dgvDecomisos.ReadOnly = True
        Me.dgvDecomisos.RowHeadersVisible = False
        Me.dgvDecomisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDecomisos.Size = New System.Drawing.Size(579, 216)
        Me.dgvDecomisos.TabIndex = 86
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "FolioSacrificio"
        Me.Codigo.HeaderText = "Lote Sacrificio"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Producto"
        Me.Descripcion.FillWeight = 150.0!
        Me.Descripcion.HeaderText = "Producto"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 250
        '
        'clmTipoDecomiso
        '
        Me.clmTipoDecomiso.DataPropertyName = "Motivo Decomiso"
        Me.clmTipoDecomiso.HeaderText = "Motivo Decomiso"
        Me.clmTipoDecomiso.Name = "clmTipoDecomiso"
        Me.clmTipoDecomiso.ReadOnly = True
        '
        'KilosRastro
        '
        Me.KilosRastro.DataPropertyName = "Piezas"
        Me.KilosRastro.HeaderText = "Piezas"
        Me.KilosRastro.Name = "KilosRastro"
        Me.KilosRastro.ReadOnly = True
        '
        'Kilos
        '
        Me.Kilos.DataPropertyName = "Kilos"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Kilos.DefaultCellStyle = DataGridViewCellStyle3
        Me.Kilos.HeaderText = "Kilos"
        Me.Kilos.Name = "Kilos"
        Me.Kilos.ReadOnly = True
        '
        'clmIdMotivoDecomiso
        '
        Me.clmIdMotivoDecomiso.DataPropertyName = "IdDecomiso"
        Me.clmIdMotivoDecomiso.HeaderText = "Código Motivo Decomiso"
        Me.clmIdMotivoDecomiso.Name = "clmIdMotivoDecomiso"
        Me.clmIdMotivoDecomiso.ReadOnly = True
        Me.clmIdMotivoDecomiso.Visible = False
        '
        'CancelarDecomiso
        '
        Me.CancelarDecomiso.Name = "CancelarDecomiso"
        Me.CancelarDecomiso.Size = New System.Drawing.Size(61, 4)
        Me.CancelarDecomiso.Text = "Cancelar Decomiso"
        '
        'cmbProductos
        '
        Me.cmbProductos.FormattingEnabled = True
        Me.cmbProductos.Location = New System.Drawing.Point(122, 90)
        Me.cmbProductos.Name = "cmbProductos"
        Me.cmbProductos.Size = New System.Drawing.Size(260, 21)
        Me.cmbProductos.TabIndex = 85
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Producto :"
        '
        'txtProductor
        '
        Me.txtProductor.Enabled = False
        Me.txtProductor.Location = New System.Drawing.Point(122, 63)
        Me.txtProductor.Name = "txtProductor"
        Me.txtProductor.Size = New System.Drawing.Size(260, 20)
        Me.txtProductor.TabIndex = 83
        '
        'dtpFechaSacrificio
        '
        Me.dtpFechaSacrificio.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFechaSacrificio.Enabled = False
        Me.dtpFechaSacrificio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaSacrificio.Location = New System.Drawing.Point(454, 32)
        Me.dtpFechaSacrificio.Name = "dtpFechaSacrificio"
        Me.dtpFechaSacrificio.Size = New System.Drawing.Size(92, 20)
        Me.dtpFechaSacrificio.TabIndex = 82
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(350, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 13)
        Me.Label9.TabIndex = 81
        Me.Label9.Text = "Fecha Sacrificio :"
        '
        'txtLoteSacrificio
        '
        Me.txtLoteSacrificio.Enabled = False
        Me.txtLoteSacrificio.Location = New System.Drawing.Point(122, 33)
        Me.txtLoteSacrificio.Name = "txtLoteSacrificio"
        Me.txtLoteSacrificio.Size = New System.Drawing.Size(102, 20)
        Me.txtLoteSacrificio.TabIndex = 80
        Me.txtLoteSacrificio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Introductor :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Lote de sacrificio :"
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
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 495)
        Me.mtb.TabIndex = 44
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(616, 32)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "Decomisos de Productos"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TmProducto
        '
        Me.TmProducto.Interval = 1000
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "LoteSacrificio"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 70
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NombreProducto"
        Me.DataGridViewTextBoxColumn2.FillWeight = 150.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Producto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Piezas"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Piezas"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Kilos"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn4.HeaderText = "Kilos"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Estatus"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Estatus"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'FrmDecomisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 495)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmDecomisos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Decomiso de Productos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvDecomisos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtProductor As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaSacrificio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtLoteSacrificio As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbProductos As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgvDecomisos As System.Windows.Forms.DataGridView
    Public WithEvents txtPeso As System.Windows.Forms.TextBox
    Public WithEvents txtPiezas As System.Windows.Forms.TextBox
    Public WithEvents _LblEtiqueta_3 As System.Windows.Forms.Label
    Public WithEvents _LblEtiqueta_7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotalKilos As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtTotalPiezas As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents CancelarDecomiso As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BtnBascula As System.Windows.Forms.Button
    Friend WithEvents CmbMotivoDecomiso As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SerialPort As System.IO.Ports.SerialPort
    Friend WithEvents TmProducto As System.Windows.Forms.Timer
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTipoDecomiso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosRastro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kilos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdMotivoDecomiso As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
