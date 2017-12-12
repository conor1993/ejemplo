<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerarMovtosAlmacenCOpia
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.mtb = New MEAToolBar.MEAToolBar()
        Me.gbPrincipal = New System.Windows.Forms.GroupBox()
        Me.dgvArticulos = New Integralab.Controles.DataGridViewMejorado()
        Me.cmbTipoMov = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalCantidad = New System.Windows.Forms.Label()
        Me.lblCostoTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.clmCodigoBarra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmArticulo = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.clmUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MeaToolBar1 = New MEAToolBar.MEAToolBar()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.asdasdasd = New System.Windows.Forms.GroupBox()
        CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(0, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 23)
        Me.Label17.TabIndex = 51
        Me.Label17.Text = "REGISTRO DE MOVIMIENTOS DE ALMACEN"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.mtb.Location = New System.Drawing.Point(87, 17)
        Me.mtb.MostrarBorrar = False
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 42)
        Me.mtb.TabIndex = 52
        '
        'gbPrincipal
        '
        Me.gbPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.gbPrincipal.Name = "gbPrincipal"
        Me.gbPrincipal.Size = New System.Drawing.Size(200, 100)
        Me.gbPrincipal.TabIndex = 53
        Me.gbPrincipal.TabStop = False
        '
        'dgvArticulos
        '
        Me.dgvArticulos.AllowUserToDeleteRows = False
        Me.dgvArticulos.AllowUserToOrderColumns = True
        Me.dgvArticulos.AllowUserToResizeRows = False
        DataGridViewCellStyle7.NullValue = Nothing
        Me.dgvArticulos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvArticulos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvArticulos.CausesValidation = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvArticulos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvArticulos.Location = New System.Drawing.Point(0, 0)
        Me.dgvArticulos.MultiSelect = False
        Me.dgvArticulos.Name = "dgvArticulos"
        Me.dgvArticulos.ReemplazarKey = System.Windows.Forms.Keys.[Return]
        Me.dgvArticulos.ReemplazarKeyPor = System.Windows.Forms.Keys.Tab
        Me.dgvArticulos.RowHeadersVisible = False
        Me.dgvArticulos.Size = New System.Drawing.Size(240, 150)
        Me.dgvArticulos.TabIndex = 2
        '
        'cmbTipoMov
        '
        Me.cmbTipoMov.FormattingEnabled = True
        Me.cmbTipoMov.Location = New System.Drawing.Point(0, 0)
        Me.cmbTipoMov.Name = "cmbTipoMov"
        Me.cmbTipoMov.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipoMov.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de Movimiento:"
        '
        'lblTotalCantidad
        '
        Me.lblTotalCantidad.AutoSize = True
        Me.lblTotalCantidad.Location = New System.Drawing.Point(0, 0)
        Me.lblTotalCantidad.Name = "lblTotalCantidad"
        Me.lblTotalCantidad.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalCantidad.TabIndex = 54
        Me.lblTotalCantidad.Text = "0.00"
        Me.lblTotalCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCostoTotal
        '
        Me.lblCostoTotal.AutoSize = True
        Me.lblCostoTotal.Location = New System.Drawing.Point(0, 0)
        Me.lblCostoTotal.Name = "lblCostoTotal"
        Me.lblCostoTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblCostoTotal.TabIndex = 55
        Me.lblCostoTotal.Text = "0.00"
        Me.lblCostoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Total"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'clmCodigoBarra
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle9.Format = "N0"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.clmCodigoBarra.DefaultCellStyle = DataGridViewCellStyle9
        Me.clmCodigoBarra.FillWeight = 80.0!
        Me.clmCodigoBarra.HeaderText = "Cod. de Barras"
        Me.clmCodigoBarra.Name = "clmCodigoBarra"
        '
        'clmArticulo
        '
        Me.clmArticulo.FillWeight = 200.0!
        Me.clmArticulo.HeaderText = "Articulo"
        Me.clmArticulo.Name = "clmArticulo"
        '
        'clmUnidad
        '
        Me.clmUnidad.FillWeight = 40.0!
        Me.clmUnidad.HeaderText = "Unidad"
        Me.clmUnidad.Name = "clmUnidad"
        Me.clmUnidad.ReadOnly = True
        '
        'clmCantidad
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N3"
        Me.clmCantidad.DefaultCellStyle = DataGridViewCellStyle10
        Me.clmCantidad.FillWeight = 65.0!
        Me.clmCantidad.HeaderText = "Cantidad"
        Me.clmCantidad.Name = "clmCantidad"
        '
        'clmCosto
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        Me.clmCosto.DefaultCellStyle = DataGridViewCellStyle11
        Me.clmCosto.FillWeight = 65.0!
        Me.clmCosto.HeaderText = "Costo"
        Me.clmCosto.Name = "clmCosto"
        Me.clmCosto.ReadOnly = True
        '
        'clmTotal
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N2"
        Me.clmTotal.DefaultCellStyle = DataGridViewCellStyle12
        Me.clmTotal.FillWeight = 80.0!
        Me.clmTotal.HeaderText = "Total"
        Me.clmTotal.Name = "clmTotal"
        Me.clmTotal.ReadOnly = True
        '
        'MeaToolBar1
        '
        Me.MeaToolBar1.ButtonSize = New System.Drawing.Size(50, 50)
        Me.MeaToolBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MeaToolBar1.DropDownArrows = True
        Me.MeaToolBar1.HabilitarBorrar = True
        Me.MeaToolBar1.HabilitarBuscar = True
        Me.MeaToolBar1.HabilitarCancelar = True
        Me.MeaToolBar1.HabilitarEditar = True
        Me.MeaToolBar1.HabilitarGuardar = True
        Me.MeaToolBar1.HabilitarImprimir = True
        Me.MeaToolBar1.HabilitarLimpiar = True
        Me.MeaToolBar1.HabilitarNuevo = True
        Me.MeaToolBar1.HabilitarSalir = True
        Me.MeaToolBar1.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32
        Me.MeaToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.MeaToolBar1.MostrarBorrar = False
        Me.MeaToolBar1.MostrarBuscar = False
        Me.MeaToolBar1.MostrarCancelar = True
        Me.MeaToolBar1.MostrarEditar = False
        Me.MeaToolBar1.MostrarGuardar = True
        Me.MeaToolBar1.MostrarImprimir = False
        Me.MeaToolBar1.MostrarLimpiar = True
        Me.MeaToolBar1.MostrarNuevo = True
        Me.MeaToolBar1.MostrarSalir = True
        Me.MeaToolBar1.Name = "MeaToolBar1"
        Me.MeaToolBar1.ShowToolTips = True
        Me.MeaToolBar1.Size = New System.Drawing.Size(50, 486)
        Me.MeaToolBar1.TabIndex = 10
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(50, 0)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(714, 30)
        Me.lblTitulo.TabIndex = 99
        Me.lblTitulo.Text = "REGISTRO DE MOVIMIENTOS"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(96, 426)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 15)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Tipo Movimiento:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(212, 425)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(471, 21)
        Me.ComboBox1.TabIndex = 101
        '
        'asdasdasd
        '
        Me.asdasdasd.Location = New System.Drawing.Point(56, 33)
        Me.asdasdasd.Name = "asdasdasd"
        Me.asdasdasd.Size = New System.Drawing.Size(696, 374)
        Me.asdasdasd.TabIndex = 102
        Me.asdasdasd.TabStop = False
        '
        'frmGenerarMovtosAlmacenCOpia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 486)
        Me.Controls.Add(Me.asdasdasd)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.MeaToolBar1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmGenerarMovtosAlmacenCOpia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Movimientos de Almacen"
        CType(Me.dgvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents gbPrincipal As System.Windows.Forms.GroupBox
    Friend WithEvents cmbTipoMov As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvArticulos As Integralab.Controles.DataGridViewMejorado
    Friend WithEvents lblTotalCantidad As System.Windows.Forms.Label
    Friend WithEvents lblCostoTotal As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents clmCodigoBarra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmArticulo As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents clmUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCosto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MeaToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents asdasdasd As System.Windows.Forms.GroupBox
End Class
