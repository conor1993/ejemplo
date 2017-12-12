<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptReporteDeMarbetes
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
        Me.components = New System.ComponentModel.Container
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.AlmacenCollectionClass1 = New ClasesNegocio.AlmacenCollectionClass
        Me.lblAlmacen = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.LineaCollectionClass1 = New ClasesNegocio.LineaCollectionClass
        Me.lblLinea = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.clmAlmacen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmLinea = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmProducto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmbAlmacen = New IntegraLab.Controles.ComboBoxMejorado
        Me.txtAlmacen = New IntegraLab.Controles.TextBoxMejorado
        Me.cmbLinea = New IntegraLab.Controles.ComboBoxMejorado
        Me.txtLinea = New IntegraLab.Controles.TextBoxMejorado
        Me.lblMensaje = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mtb
        '
        Me.mtb.ButtonSize = New System.Drawing.Size(50, 50)
        Me.mtb.Dock = System.Windows.Forms.DockStyle.Left
        Me.mtb.DropDownArrows = True
        Me.mtb.HabilitarBorrar = False
        Me.mtb.HabilitarBuscar = False
        Me.mtb.HabilitarCancelar = True
        Me.mtb.HabilitarEditar = False
        Me.mtb.HabilitarGuardar = False
        Me.mtb.HabilitarImprimir = True
        Me.mtb.HabilitarLimpiar = False
        Me.mtb.HabilitarNuevo = True
        Me.mtb.HabilitarSalir = True
        Me.mtb.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32
        Me.mtb.Location = New System.Drawing.Point(0, 0)
        Me.mtb.MostrarBorrar = False
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = False
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = False
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 293)
        Me.mtb.TabIndex = 7
        '
        'AlmacenCollectionClass1
        '
        Me.AlmacenCollectionClass1.AllowEdit = True
        Me.AlmacenCollectionClass1.AllowNew = True
        Me.AlmacenCollectionClass1.AllowRemove = True
        Me.AlmacenCollectionClass1.Name = ""
        Me.AlmacenCollectionClass1.RaiseListChangedEvents = True
        Me.AlmacenCollectionClass1.Tipo = ClasesNegocio.AlmacenEnum.ALMACEN
        '
        'lblAlmacen
        '
        Me.lblAlmacen.AutoSize = True
        Me.lblAlmacen.Location = New System.Drawing.Point(68, 53)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.Size = New System.Drawing.Size(48, 13)
        Me.lblAlmacen.TabIndex = 1
        Me.lblAlmacen.Text = "Almacen"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.MaximumSize = New System.Drawing.Size(1600, 900)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(493, 29)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "REPORTE DE MARBETES"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LineaCollectionClass1
        '
        Me.LineaCollectionClass1.AllowEdit = True
        Me.LineaCollectionClass1.AllowNew = True
        Me.LineaCollectionClass1.AllowRemove = True
        Me.LineaCollectionClass1.Name = ""
        Me.LineaCollectionClass1.RaiseListChangedEvents = True
        '
        'lblLinea
        '
        Me.lblLinea.AutoSize = True
        Me.lblLinea.Location = New System.Drawing.Point(68, 92)
        Me.lblLinea.Name = "lblLinea"
        Me.lblLinea.Size = New System.Drawing.Size(33, 13)
        Me.lblLinea.TabIndex = 4
        Me.lblLinea.Text = "Linea"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(55, 137)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(476, 144)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de Reporte de Marbetes"
        Me.GroupBox1.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmAlmacen, Me.clmLinea, Me.clmCodigo, Me.clmProducto})
        Me.DataGridView1.Location = New System.Drawing.Point(16, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(447, 102)
        Me.DataGridView1.TabIndex = 0
        Me.DataGridView1.Visible = False
        '
        'clmAlmacen
        '
        Me.clmAlmacen.HeaderText = "Almacen"
        Me.clmAlmacen.Name = "clmAlmacen"
        Me.clmAlmacen.Width = 150
        '
        'clmLinea
        '
        Me.clmLinea.HeaderText = "Linea"
        Me.clmLinea.Name = "clmLinea"
        Me.clmLinea.Width = 120
        '
        'clmCodigo
        '
        Me.clmCodigo.HeaderText = "Codigo"
        Me.clmCodigo.Name = "clmCodigo"
        Me.clmCodigo.Width = 70
        '
        'clmProducto
        '
        Me.clmProducto.HeaderText = "producto"
        Me.clmProducto.Name = "clmProducto"
        Me.clmProducto.Width = 150
        '
        'cmbAlmacen
        '
        Me.cmbAlmacen.DataSource = Me.AlmacenCollectionClass1
        Me.cmbAlmacen.DisplayMember = "Descripcion"
        Me.cmbAlmacen.FormattingEnabled = True
        Me.cmbAlmacen.Location = New System.Drawing.Point(195, 50)
        Me.cmbAlmacen.Name = "cmbAlmacen"
        Me.cmbAlmacen.NombreMetodo = Nothing
        Me.cmbAlmacen.Parametros = Nothing
        Me.cmbAlmacen.SiguienteControl = Nothing
        Me.cmbAlmacen.Size = New System.Drawing.Size(210, 21)
        Me.cmbAlmacen.TabIndex = 3
        Me.cmbAlmacen.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbAlmacen.TextBoxEnlazado = Me.txtAlmacen
        Me.cmbAlmacen.ValueMember = "Codigo"
        '
        'txtAlmacen
        '
        Me.txtAlmacen.ComboBoxEnlazado = Me.cmbAlmacen
        Me.txtAlmacen.Decimales = 0
        Me.txtAlmacen.Location = New System.Drawing.Point(122, 50)
        Me.txtAlmacen.MaxLength = 3000
        Me.txtAlmacen.MensajeCombo = "Seleccionar un almacen..."
        Me.txtAlmacen.MensajeNoExiste = "No existe"
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.SiguienteControl = Me.cmbAlmacen
        Me.txtAlmacen.Size = New System.Drawing.Size(67, 20)
        Me.txtAlmacen.TabIndex = 2
        Me.txtAlmacen.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtAlmacen.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtAlmacen.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cmbLinea
        '
        Me.cmbLinea.DataSource = Me.LineaCollectionClass1
        Me.cmbLinea.DisplayMember = "Descripcion"
        Me.cmbLinea.FormattingEnabled = True
        Me.cmbLinea.Location = New System.Drawing.Point(195, 84)
        Me.cmbLinea.Name = "cmbLinea"
        Me.cmbLinea.NombreMetodo = Nothing
        Me.cmbLinea.Parametros = Nothing
        Me.cmbLinea.SiguienteControl = Me.mtb
        Me.cmbLinea.Size = New System.Drawing.Size(210, 21)
        Me.cmbLinea.TabIndex = 6
        Me.cmbLinea.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbLinea.TextBoxEnlazado = Me.txtLinea
        Me.cmbLinea.ValueMember = "Codigo"
        '
        'txtLinea
        '
        Me.txtLinea.ComboBoxEnlazado = Me.cmbLinea
        Me.txtLinea.Decimales = 0
        Me.txtLinea.Location = New System.Drawing.Point(122, 85)
        Me.txtLinea.MaxLength = 3000
        Me.txtLinea.MensajeCombo = "Seleccionar una Plaza..."
        Me.txtLinea.MensajeNoExiste = "No existe "
        Me.txtLinea.Name = "txtLinea"
        Me.txtLinea.SiguienteControl = Me.cmbLinea
        Me.txtLinea.Size = New System.Drawing.Size(67, 20)
        Me.txtLinea.TabIndex = 5
        Me.txtLinea.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtLinea.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtLinea.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.BackColor = System.Drawing.SystemColors.Control
        Me.lblMensaje.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMensaje.Location = New System.Drawing.Point(68, 121)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(39, 13)
        Me.lblMensaje.TabIndex = 11
        Me.lblMensaje.Text = "Label1"
        Me.lblMensaje.Visible = False
        '
        'rptReporteDeMarbetes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 293)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.cmbLinea)
        Me.Controls.Add(Me.txtLinea)
        Me.Controls.Add(Me.cmbAlmacen)
        Me.Controls.Add(Me.txtAlmacen)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblLinea)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lblAlmacen)
        Me.Controls.Add(Me.mtb)
        Me.Name = "rptReporteDeMarbetes"
        Me.Text = "REPORTE DE MARBETES"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents lblAlmacen As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblLinea As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents AlmacenCollectionClass1 As ClasesNegocio.AlmacenCollectionClass
    Friend WithEvents LineaCollectionClass1 As ClasesNegocio.LineaCollectionClass
    Friend WithEvents clmAlmacen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmLinea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbAlmacen As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents txtAlmacen As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents cmbLinea As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents txtLinea As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
End Class
