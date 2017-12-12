<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusqNotasVenta
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.mtb = New MEAToolBar.MEAToolBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gpFechas = New System.Windows.Forms.GroupBox()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkFiltroFecha = New System.Windows.Forms.CheckBox()
        Me.txtFolio = New System.Windows.Forms.TextBox()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.cmlProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvNotas = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmModificada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gpFechas.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvNotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(0, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(561, 29)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Búsqueda de Notas de Venta"
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
        Me.mtb.Location = New System.Drawing.Point(0, 29)
        Me.mtb.MostrarBorrar = False
        Me.mtb.MostrarBuscar = True
        Me.mtb.MostrarCancelar = False
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = False
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 300)
        Me.mtb.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Folio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Desde:"
        '
        'gpFechas
        '
        Me.gpFechas.Controls.Add(Me.dtpHasta)
        Me.gpFechas.Controls.Add(Me.dtpDesde)
        Me.gpFechas.Controls.Add(Me.Label3)
        Me.gpFechas.Controls.Add(Me.Label2)
        Me.gpFechas.Location = New System.Drawing.Point(218, 31)
        Me.gpFechas.Name = "gpFechas"
        Me.gpFechas.Size = New System.Drawing.Size(326, 49)
        Me.gpFechas.TabIndex = 12
        Me.gpFechas.TabStop = False
        '
        'dtpHasta
        '
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(209, 20)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(105, 20)
        Me.dtpHasta.TabIndex = 14
        '
        'dtpDesde
        '
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(54, 20)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(104, 20)
        Me.dtpDesde.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(165, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Hasta:"
        '
        'chkFiltroFecha
        '
        Me.chkFiltroFecha.AutoSize = True
        Me.chkFiltroFecha.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.chkFiltroFecha.Location = New System.Drawing.Point(223, 33)
        Me.chkFiltroFecha.Name = "chkFiltroFecha"
        Me.chkFiltroFecha.Size = New System.Drawing.Size(15, 14)
        Me.chkFiltroFecha.TabIndex = 13
        Me.chkFiltroFecha.UseVisualStyleBackColor = True
        '
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(104, 51)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(94, 20)
        Me.txtFolio.TabIndex = 14
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToDeleteRows = False
        Me.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDetalle.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cmlProducto, Me.ClmCantidad, Me.clmPrecio, Me.clmTotal})
        Me.dgvDetalle.Location = New System.Drawing.Point(69, 204)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.RowHeadersVisible = False
        Me.dgvDetalle.Size = New System.Drawing.Size(475, 107)
        Me.dgvDetalle.TabIndex = 15
        '
        'cmlProducto
        '
        Me.cmlProducto.FillWeight = 200.0!
        Me.cmlProducto.HeaderText = "Producto"
        Me.cmlProducto.Name = "cmlProducto"
        Me.cmlProducto.ReadOnly = True
        '
        'ClmCantidad
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        Me.ClmCantidad.DefaultCellStyle = DataGridViewCellStyle1
        Me.ClmCantidad.FillWeight = 70.0!
        Me.ClmCantidad.HeaderText = "Cantidad"
        Me.ClmCantidad.Name = "ClmCantidad"
        Me.ClmCantidad.ReadOnly = True
        '
        'clmPrecio
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        Me.clmPrecio.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmPrecio.FillWeight = 70.0!
        Me.clmPrecio.HeaderText = "Precio"
        Me.clmPrecio.Name = "clmPrecio"
        Me.clmPrecio.ReadOnly = True
        '
        'clmTotal
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        Me.clmTotal.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmTotal.HeaderText = "Total"
        Me.clmTotal.Name = "clmTotal"
        Me.clmTotal.ReadOnly = True
        '
        'dgvNotas
        '
        Me.dgvNotas.AllowUserToAddRows = False
        Me.dgvNotas.AllowUserToDeleteRows = False
        Me.dgvNotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvNotas.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvNotas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNotas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Total, Me.FechaVenta, Me.clmModificada})
        Me.dgvNotas.Location = New System.Drawing.Point(69, 86)
        Me.dgvNotas.Name = "dgvNotas"
        Me.dgvNotas.RowHeadersVisible = False
        Me.dgvNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvNotas.Size = New System.Drawing.Size(475, 107)
        Me.dgvNotas.TabIndex = 16
        '
        'Codigo
        '
        Me.Codigo.FillWeight = 90.0!
        Me.Codigo.HeaderText = "Folio Nota"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Total
        '
        Me.Total.FillWeight = 90.0!
        Me.Total.HeaderText = "Total Nota"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'FechaVenta
        '
        Me.FechaVenta.HeaderText = "Fecha y Hora"
        Me.FechaVenta.Name = "FechaVenta"
        Me.FechaVenta.ReadOnly = True
        '
        'clmModificada
        '
        Me.clmModificada.HeaderText = "Modificada"
        Me.clmModificada.Name = "clmModificada"
        Me.clmModificada.Visible = False
        '
        'frmBusqNotasVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 329)
        Me.Controls.Add(Me.dgvNotas)
        Me.Controls.Add(Me.dgvDetalle)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.chkFiltroFecha)
        Me.Controls.Add(Me.gpFechas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.Label17)
        Me.KeyPreview = True
        Me.Name = "frmBusqNotasVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Busqueda de Notas de Venta"
        Me.gpFechas.ResumeLayout(False)
        Me.gpFechas.PerformLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvNotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gpFechas As System.Windows.Forms.GroupBox
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkFiltroFecha As System.Windows.Forms.CheckBox
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents dgvNotas As System.Windows.Forms.DataGridView
    Friend WithEvents cmlProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPrecio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmModificada As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
