<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsAperturaLote2
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.mtb = New MEAToolBar.MEAToolBar()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.chkFiltrarFecha = New System.Windows.Forms.CheckBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.dvgAperturaLotes = New System.Windows.Forms.DataGridView()
        Me.LoteCorte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaFapsa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCorte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoteSacrificio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiasCad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dvgAperturaLotes, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.mtb.Size = New System.Drawing.Size(50, 638)
        Me.mtb.TabIndex = 53
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(914, 32)
        Me.Label17.TabIndex = 54
        Me.Label17.Text = "Consulta de compras de productos de terceros"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkFiltrarFecha
        '
        Me.chkFiltrarFecha.AutoSize = True
        Me.chkFiltrarFecha.Location = New System.Drawing.Point(56, 35)
        Me.chkFiltrarFecha.Name = "chkFiltrarFecha"
        Me.chkFiltrarFecha.Size = New System.Drawing.Size(115, 17)
        Me.chkFiltrarFecha.TabIndex = 55
        Me.chkFiltrarFecha.Text = "¿Filtrar Por Fecha?"
        Me.chkFiltrarFecha.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(637, 35)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 56
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        Me.BtnBuscar.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpFechaFinal)
        Me.GroupBox1.Controls.Add(Me.dtpFechaInicio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(54, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 88)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rango de Fechas"
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(94, 53)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(90, 20)
        Me.dtpFechaFinal.TabIndex = 3
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(94, 23)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(90, 20)
        Me.dtpFechaInicio.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha Final :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Inicio :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(260, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Buscar por Lote:"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBusqueda.Location = New System.Drawing.Point(351, 130)
        Me.txtBusqueda.MaxLength = 50
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(346, 20)
        Me.txtBusqueda.TabIndex = 59
        '
        'dvgAperturaLotes
        '
        Me.dvgAperturaLotes.AllowUserToAddRows = False
        Me.dvgAperturaLotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dvgAperturaLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgAperturaLotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LoteCorte, Me.FechaFapsa, Me.FechaCorte, Me.LoteSacrificio, Me.DiasCad, Me.FechaCad, Me.Observaciones})
        Me.dvgAperturaLotes.Location = New System.Drawing.Point(54, 157)
        Me.dvgAperturaLotes.Name = "dvgAperturaLotes"
        Me.dvgAperturaLotes.ReadOnly = True
        Me.dvgAperturaLotes.RowHeadersVisible = False
        Me.dvgAperturaLotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvgAperturaLotes.Size = New System.Drawing.Size(898, 474)
        Me.dvgAperturaLotes.TabIndex = 60
        '
        'LoteCorte
        '
        Me.LoteCorte.DataPropertyName = "LoteCorte"
        Me.LoteCorte.HeaderText = "Folio de Compra"
        Me.LoteCorte.Name = "LoteCorte"
        Me.LoteCorte.ReadOnly = True
        Me.LoteCorte.Width = 110
        '
        'FechaFapsa
        '
        Me.FechaFapsa.DataPropertyName = "FechaFapsa"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.Format = "dd/MMM/yyyy"
        Me.FechaFapsa.DefaultCellStyle = DataGridViewCellStyle4
        Me.FechaFapsa.HeaderText = "Fecha Factura"
        Me.FechaFapsa.Name = "FechaFapsa"
        Me.FechaFapsa.ReadOnly = True
        Me.FechaFapsa.Width = 150
        '
        'FechaCorte
        '
        Me.FechaCorte.DataPropertyName = "FechaCorte"
        DataGridViewCellStyle5.Format = "dd/MMM/yyyy"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.FechaCorte.DefaultCellStyle = DataGridViewCellStyle5
        Me.FechaCorte.HeaderText = "Fecha Corte"
        Me.FechaCorte.Name = "FechaCorte"
        Me.FechaCorte.ReadOnly = True
        Me.FechaCorte.Width = 150
        '
        'LoteSacrificio
        '
        Me.LoteSacrificio.DataPropertyName = "LoteSacrificio"
        Me.LoteSacrificio.HeaderText = "Lote Sacrificio"
        Me.LoteSacrificio.Name = "LoteSacrificio"
        Me.LoteSacrificio.ReadOnly = True
        Me.LoteSacrificio.Width = 110
        '
        'DiasCad
        '
        Me.DiasCad.DataPropertyName = "DiasCad"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DiasCad.DefaultCellStyle = DataGridViewCellStyle6
        Me.DiasCad.HeaderText = "Días Caducidad"
        Me.DiasCad.Name = "DiasCad"
        Me.DiasCad.ReadOnly = True
        Me.DiasCad.Width = 70
        '
        'FechaCad
        '
        Me.FechaCad.DataPropertyName = "FechaCad"
        Me.FechaCad.HeaderText = "Fecha Caducidad"
        Me.FechaCad.Name = "FechaCad"
        Me.FechaCad.ReadOnly = True
        Me.FechaCad.Width = 150
        '
        'Observaciones
        '
        Me.Observaciones.DataPropertyName = "Observaciones"
        Me.Observaciones.HeaderText = "Observaciones"
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.ReadOnly = True
        Me.Observaciones.Width = 200
        '
        'FrmConsAperturaLote2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 638)
        Me.Controls.Add(Me.dvgAperturaLotes)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.chkFiltrarFecha)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.Name = "FrmConsAperturaLote2"
        Me.Text = "Consulta de Apertura de Lotes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dvgAperturaLotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents chkFiltrarFecha As System.Windows.Forms.CheckBox
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents dvgAperturaLotes As System.Windows.Forms.DataGridView
    Friend WithEvents LoteCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaFapsa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoteSacrificio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiasCad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaCad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Observaciones As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
