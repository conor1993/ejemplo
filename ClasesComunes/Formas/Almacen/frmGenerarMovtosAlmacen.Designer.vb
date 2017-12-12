<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerarMovtosAlmacen
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Mtb = New MEAToolBar.MEAToolBar()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.gbPrincipal = New System.Windows.Forms.GroupBox()
        Me.dgvDetalleArticulos = New Integralab.Controles.DataGridViewMejorado()
        Me.cmbTipoMov = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.clmCodigoBarra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmArticulo = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.clmUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbPrincipal.SuspendLayout()
        CType(Me.dgvDetalleArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Mtb
        '
        Me.Mtb.ButtonSize = New System.Drawing.Size(50, 50)
        Me.Mtb.Dock = System.Windows.Forms.DockStyle.Left
        Me.Mtb.DropDownArrows = True
        Me.Mtb.HabilitarBorrar = True
        Me.Mtb.HabilitarBuscar = True
        Me.Mtb.HabilitarCancelar = True
        Me.Mtb.HabilitarEditar = True
        Me.Mtb.HabilitarGuardar = True
        Me.Mtb.HabilitarImprimir = True
        Me.Mtb.HabilitarLimpiar = True
        Me.Mtb.HabilitarNuevo = True
        Me.Mtb.HabilitarSalir = True
        Me.Mtb.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32
        Me.Mtb.Location = New System.Drawing.Point(0, 0)
        Me.Mtb.MostrarBorrar = False
        Me.Mtb.MostrarBuscar = False
        Me.Mtb.MostrarCancelar = True
        Me.Mtb.MostrarEditar = False
        Me.Mtb.MostrarGuardar = True
        Me.Mtb.MostrarImprimir = False
        Me.Mtb.MostrarLimpiar = True
        Me.Mtb.MostrarNuevo = True
        Me.Mtb.MostrarSalir = True
        Me.Mtb.Name = "Mtb"
        Me.Mtb.ShowToolTips = True
        Me.Mtb.Size = New System.Drawing.Size(50, 370)
        Me.Mtb.TabIndex = 11
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
        Me.lblTitulo.Size = New System.Drawing.Size(674, 30)
        Me.lblTitulo.TabIndex = 100
        Me.lblTitulo.Text = "REGISTRO DE MOVIMIENTOS"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbPrincipal
        '
        Me.gbPrincipal.Controls.Add(Me.dgvDetalleArticulos)
        Me.gbPrincipal.Controls.Add(Me.cmbTipoMov)
        Me.gbPrincipal.Controls.Add(Me.Label3)
        Me.gbPrincipal.Location = New System.Drawing.Point(56, 33)
        Me.gbPrincipal.Name = "gbPrincipal"
        Me.gbPrincipal.Size = New System.Drawing.Size(658, 308)
        Me.gbPrincipal.TabIndex = 103
        Me.gbPrincipal.TabStop = False
        '
        'dgvDetalleArticulos
        '
        Me.dgvDetalleArticulos.AllowUserToDeleteRows = False
        Me.dgvDetalleArticulos.AllowUserToOrderColumns = True
        Me.dgvDetalleArticulos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.NullValue = Nothing
        Me.dgvDetalleArticulos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDetalleArticulos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalleArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalleArticulos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDetalleArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleArticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmCodigoBarra, Me.clmArticulo, Me.clmUnidad, Me.clmCantidad, Me.clmCosto, Me.clmTotal})
        Me.dgvDetalleArticulos.Location = New System.Drawing.Point(0, 56)
        Me.dgvDetalleArticulos.Name = "dgvDetalleArticulos"
        Me.dgvDetalleArticulos.ReemplazarKey = System.Windows.Forms.Keys.[Return]
        Me.dgvDetalleArticulos.ReemplazarKeyPor = System.Windows.Forms.Keys.Tab
        Me.dgvDetalleArticulos.RowHeadersVisible = False
        Me.dgvDetalleArticulos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvDetalleArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvDetalleArticulos.Size = New System.Drawing.Size(646, 246)
        Me.dgvDetalleArticulos.TabIndex = 2
        '
        'cmbTipoMov
        '
        Me.cmbTipoMov.FormattingEnabled = True
        Me.cmbTipoMov.Location = New System.Drawing.Point(133, 15)
        Me.cmbTipoMov.Name = "cmbTipoMov"
        Me.cmbTipoMov.Size = New System.Drawing.Size(471, 21)
        Me.cmbTipoMov.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 15)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "Tipo Movimiento:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(597, 344)
        Me.lblTotal.MinimumSize = New System.Drawing.Size(100, 13)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 13)
        Me.lblTotal.TabIndex = 104
        Me.lblTotal.Text = "0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.Location = New System.Drawing.Point(406, 344)
        Me.lblCantidad.MinimumSize = New System.Drawing.Size(100, 13)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(100, 13)
        Me.lblCantidad.TabIndex = 105
        Me.lblCantidad.Text = "0.000"
        Me.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(318, 344)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Total Cantidad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(531, 344)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "Gran Total:"
        '
        'clmCodigoBarra
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.clmCodigoBarra.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmCodigoBarra.FillWeight = 70.0!
        Me.clmCodigoBarra.HeaderText = "Código de Barras"
        Me.clmCodigoBarra.Name = "clmCodigoBarra"
        '
        'clmArticulo
        '
        Me.clmArticulo.FillWeight = 150.0!
        Me.clmArticulo.HeaderText = "Articulo"
        Me.clmArticulo.Name = "clmArticulo"
        '
        'clmUnidad
        '
        Me.clmUnidad.FillWeight = 35.0!
        Me.clmUnidad.HeaderText = "Unidad"
        Me.clmUnidad.Name = "clmUnidad"
        Me.clmUnidad.ReadOnly = True
        '
        'clmCantidad
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N3"
        Me.clmCantidad.DefaultCellStyle = DataGridViewCellStyle4
        Me.clmCantidad.FillWeight = 60.0!
        Me.clmCantidad.HeaderText = "Cantidad"
        Me.clmCantidad.Name = "clmCantidad"
        '
        'clmCosto
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        Me.clmCosto.DefaultCellStyle = DataGridViewCellStyle5
        Me.clmCosto.FillWeight = 60.0!
        Me.clmCosto.HeaderText = "Costo"
        Me.clmCosto.Name = "clmCosto"
        '
        'clmTotal
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.clmTotal.DefaultCellStyle = DataGridViewCellStyle6
        Me.clmTotal.FillWeight = 70.0!
        Me.clmTotal.HeaderText = "Total"
        Me.clmTotal.Name = "clmTotal"
        Me.clmTotal.ReadOnly = True
        '
        'frmGenerarMovtosAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 370)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.gbPrincipal)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.Mtb)
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(740, 408)
        Me.MinimumSize = New System.Drawing.Size(740, 408)
        Me.Name = "frmGenerarMovtosAlmacen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Movimientos de Almacen"
        Me.gbPrincipal.ResumeLayout(False)
        Me.gbPrincipal.PerformLayout()
        CType(Me.dgvDetalleArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Mtb As MEAToolBar.MEAToolBar
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents gbPrincipal As System.Windows.Forms.GroupBox
    Friend WithEvents cmbTipoMov As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents dgvDetalleArticulos As IntegraLab.Controles.DataGridViewMejorado
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents clmCodigoBarra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmArticulo As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents clmUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCosto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTotal As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
