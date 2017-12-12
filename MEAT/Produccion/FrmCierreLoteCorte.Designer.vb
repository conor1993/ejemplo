<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCierreLoteCorte
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.txtObservaciones = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtpFechaCaducidad = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtDiasCaducidad = New System.Windows.Forms.TextBox
        Me.dtpFechaSacrificio = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.dtpFechaLoteCorte = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtLoteSacrificio = New System.Windows.Forms.TextBox
        Me.txtLoteCorte = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DgvLotes = New System.Windows.Forms.DataGridView
        Me.clmLoteCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmLoteSacrificio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFechaCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIntroductor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmlKilos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmDiasCad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dgvDetalle = New System.Windows.Forms.DataGridView
        Me.clmCliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPiezas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmKilos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblEstatus)
        Me.GroupBox1.Controls.Add(Me.txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpFechaCaducidad)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtDiasCaducidad)
        Me.GroupBox1.Controls.Add(Me.dtpFechaSacrificio)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.dtpFechaLoteCorte)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtLoteSacrificio)
        Me.GroupBox1.Controls.Add(Me.txtLoteCorte)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(730, 198)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        '
        'lblEstatus
        '
        Me.lblEstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(574, 21)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(122, 21)
        Me.lblEstatus.TabIndex = 177
        Me.lblEstatus.Text = "ACTIVO"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEstatus.Visible = False
        '
        'txtObservaciones
        '
        Me.txtObservaciones.AcceptsReturn = True
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Enabled = False
        Me.txtObservaciones.Location = New System.Drawing.Point(108, 124)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ReadOnly = True
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(295, 69)
        Me.txtObservaciones.TabIndex = 59
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Observaciones :"
        '
        'dtpFechaCaducidad
        '
        Me.dtpFechaCaducidad.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFechaCaducidad.Enabled = False
        Me.dtpFechaCaducidad.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaCaducidad.Location = New System.Drawing.Point(311, 98)
        Me.dtpFechaCaducidad.Name = "dtpFechaCaducidad"
        Me.dtpFechaCaducidad.Size = New System.Drawing.Size(92, 20)
        Me.dtpFechaCaducidad.TabIndex = 57
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(208, 102)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 13)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "Fecha Caducidad :"
        '
        'txtDiasCaducidad
        '
        Me.txtDiasCaducidad.AcceptsReturn = True
        Me.txtDiasCaducidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDiasCaducidad.Enabled = False
        Me.txtDiasCaducidad.Location = New System.Drawing.Point(108, 100)
        Me.txtDiasCaducidad.Name = "txtDiasCaducidad"
        Me.txtDiasCaducidad.ReadOnly = True
        Me.txtDiasCaducidad.Size = New System.Drawing.Size(50, 20)
        Me.txtDiasCaducidad.TabIndex = 55
        '
        'dtpFechaSacrificio
        '
        Me.dtpFechaSacrificio.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFechaSacrificio.Enabled = False
        Me.dtpFechaSacrificio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaSacrificio.Location = New System.Drawing.Point(311, 47)
        Me.dtpFechaSacrificio.Name = "dtpFechaSacrificio"
        Me.dtpFechaSacrificio.Size = New System.Drawing.Size(92, 20)
        Me.dtpFechaSacrificio.TabIndex = 53
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(216, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 13)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Fecha Sacrificio :"
        '
        'dtpFechaLoteCorte
        '
        Me.dtpFechaLoteCorte.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFechaLoteCorte.Enabled = False
        Me.dtpFechaLoteCorte.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaLoteCorte.Location = New System.Drawing.Point(311, 21)
        Me.dtpFechaLoteCorte.Name = "dtpFechaLoteCorte"
        Me.dtpFechaLoteCorte.Size = New System.Drawing.Size(92, 20)
        Me.dtpFechaLoteCorte.TabIndex = 51
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Dias Caducidad :"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(108, 74)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(295, 20)
        Me.txtNombre.TabIndex = 46
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Productor :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(216, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Fecha Corte :"
        '
        'txtLoteSacrificio
        '
        Me.txtLoteSacrificio.AcceptsReturn = True
        Me.txtLoteSacrificio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLoteSacrificio.Enabled = False
        Me.txtLoteSacrificio.Location = New System.Drawing.Point(108, 48)
        Me.txtLoteSacrificio.Name = "txtLoteSacrificio"
        Me.txtLoteSacrificio.ReadOnly = True
        Me.txtLoteSacrificio.Size = New System.Drawing.Size(102, 20)
        Me.txtLoteSacrificio.TabIndex = 36
        '
        'txtLoteCorte
        '
        Me.txtLoteCorte.Enabled = False
        Me.txtLoteCorte.Location = New System.Drawing.Point(108, 21)
        Me.txtLoteCorte.Name = "txtLoteCorte"
        Me.txtLoteCorte.ReadOnly = True
        Me.txtLoteCorte.Size = New System.Drawing.Size(102, 20)
        Me.txtLoteCorte.TabIndex = 30
        Me.txtLoteCorte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Lote de Sacrifio :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lote Corte :"
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
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 641)
        Me.mtb.TabIndex = 44
        '
        'Label17
        '
        Me.Label17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(56, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(747, 32)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "Cierre de Lotes de Corte"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DgvLotes)
        Me.GroupBox2.Location = New System.Drawing.Point(60, 234)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(726, 218)
        Me.GroupBox2.TabIndex = 178
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lote de Cortes"
        '
        'DgvLotes
        '
        Me.DgvLotes.AllowUserToAddRows = False
        Me.DgvLotes.AllowUserToDeleteRows = False
        Me.DgvLotes.AllowUserToResizeRows = False
        Me.DgvLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvLotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmLoteCorte, Me.clmLoteSacrificio, Me.clmFechaCorte, Me.clmIntroductor, Me.cmlKilos, Me.clmEstatus, Me.clmDiasCad})
        Me.DgvLotes.Location = New System.Drawing.Point(9, 19)
        Me.DgvLotes.MultiSelect = False
        Me.DgvLotes.Name = "DgvLotes"
        Me.DgvLotes.ReadOnly = True
        Me.DgvLotes.RowHeadersVisible = False
        Me.DgvLotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvLotes.Size = New System.Drawing.Size(707, 187)
        Me.DgvLotes.TabIndex = 73
        '
        'clmLoteCorte
        '
        Me.clmLoteCorte.DataPropertyName = "LoteCorte"
        Me.clmLoteCorte.HeaderText = "Lote Corte"
        Me.clmLoteCorte.Name = "clmLoteCorte"
        Me.clmLoteCorte.ReadOnly = True
        '
        'clmLoteSacrificio
        '
        Me.clmLoteSacrificio.DataPropertyName = "LoteSacrificio"
        Me.clmLoteSacrificio.HeaderText = "Lote Sacrificio"
        Me.clmLoteSacrificio.Name = "clmLoteSacrificio"
        Me.clmLoteSacrificio.ReadOnly = True
        '
        'clmFechaCorte
        '
        Me.clmFechaCorte.DataPropertyName = "FechaCorte"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.clmFechaCorte.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmFechaCorte.HeaderText = "Fecha de Corte"
        Me.clmFechaCorte.Name = "clmFechaCorte"
        Me.clmFechaCorte.ReadOnly = True
        '
        'clmIntroductor
        '
        Me.clmIntroductor.DataPropertyName = "Introductor"
        Me.clmIntroductor.HeaderText = "Introductor"
        Me.clmIntroductor.Name = "clmIntroductor"
        Me.clmIntroductor.ReadOnly = True
        Me.clmIntroductor.Width = 200
        '
        'cmlKilos
        '
        Me.cmlKilos.DataPropertyName = "TotalKgs"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.cmlKilos.DefaultCellStyle = DataGridViewCellStyle2
        Me.cmlKilos.HeaderText = "Kgrs Producidos"
        Me.cmlKilos.Name = "cmlKilos"
        Me.cmlKilos.ReadOnly = True
        '
        'clmEstatus
        '
        Me.clmEstatus.DataPropertyName = "EstatusCad"
        Me.clmEstatus.HeaderText = "Estatus"
        Me.clmEstatus.Name = "clmEstatus"
        Me.clmEstatus.ReadOnly = True
        '
        'clmDiasCad
        '
        Me.clmDiasCad.DataPropertyName = "DiasCad"
        Me.clmDiasCad.HeaderText = "Dias Cad"
        Me.clmDiasCad.Name = "clmDiasCad"
        Me.clmDiasCad.ReadOnly = True
        Me.clmDiasCad.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvDetalle)
        Me.GroupBox3.Location = New System.Drawing.Point(60, 458)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(726, 171)
        Me.GroupBox3.TabIndex = 179
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalle"
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToDeleteRows = False
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmCliente, Me.clmIdProducto, Me.clmCorte, Me.clmPiezas, Me.clmKilos})
        Me.dgvDetalle.Location = New System.Drawing.Point(9, 19)
        Me.dgvDetalle.MultiSelect = False
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.ReadOnly = True
        Me.dgvDetalle.RowHeadersVisible = False
        Me.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalle.Size = New System.Drawing.Size(707, 146)
        Me.dgvDetalle.TabIndex = 0
        '
        'clmCliente
        '
        Me.clmCliente.DataPropertyName = "NombreCli"
        Me.clmCliente.HeaderText = "Cliente"
        Me.clmCliente.Name = "clmCliente"
        Me.clmCliente.ReadOnly = True
        Me.clmCliente.Width = 200
        '
        'clmIdProducto
        '
        Me.clmIdProducto.DataPropertyName = "IdProducto"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.clmIdProducto.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmIdProducto.HeaderText = "Cod. Producto"
        Me.clmIdProducto.Name = "clmIdProducto"
        Me.clmIdProducto.ReadOnly = True
        '
        'clmCorte
        '
        Me.clmCorte.DataPropertyName = "Descripcion"
        Me.clmCorte.HeaderText = "Corte"
        Me.clmCorte.Name = "clmCorte"
        Me.clmCorte.ReadOnly = True
        Me.clmCorte.Width = 200
        '
        'clmPiezas
        '
        Me.clmPiezas.DataPropertyName = "Column1"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.clmPiezas.DefaultCellStyle = DataGridViewCellStyle4
        Me.clmPiezas.HeaderText = "Piezas"
        Me.clmPiezas.Name = "clmPiezas"
        Me.clmPiezas.ReadOnly = True
        '
        'clmKilos
        '
        Me.clmKilos.DataPropertyName = "Column2"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.clmKilos.DefaultCellStyle = DataGridViewCellStyle5
        Me.clmKilos.HeaderText = "Kilos"
        Me.clmKilos.Name = "clmKilos"
        Me.clmKilos.ReadOnly = True
        '
        'FrmCierreLoteCorte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 641)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.Label17)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmCierreLoteCorte"
        Me.Text = "Cierre de Lotes de Corte "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DgvLotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaCaducidad As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDiasCaducidad As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaSacrificio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaLoteCorte As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLoteSacrificio As System.Windows.Forms.TextBox
    Friend WithEvents txtLoteCorte As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DgvLotes As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents clmLoteCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmLoteSacrificio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIntroductor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmlKilos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDiasCad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPiezas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmKilos As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
