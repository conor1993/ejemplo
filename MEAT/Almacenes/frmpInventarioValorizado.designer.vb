<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpinventariovalorizado
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtTotal = New Integralab.Controles.TextBoxMejorado
        Me.Label7 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Label17 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.lblAlmacen = New System.Windows.Forms.Label
        Me.lblPlaza = New System.Windows.Forms.Label
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmbAlmacen = New Integralab.Controles.ComboBoxMejorado
        Me.AlmacenCollectionClass1 = New ClasesNegocio.AlmacenCollectionClass
        Me.txtAlmacen = New Integralab.Controles.TextBoxMejorado
        Me.cmbPlaza = New Integralab.Controles.ComboBoxMejorado
        Me.PlazaCol = New ClasesNegocio.PlazaCollectionClass
        Me.txtPlaza = New Integralab.Controles.TextBoxMejorado
        Me.ProveedorCol = New ClasesNegocio.ProveedorCollectionClass
        Me.CachedrptOtrasEntradas1 = New ClasesNegocio.CachedrptOtrasEntradas
        Me.lblMensaje = New System.Windows.Forms.Label
        Me.clmPlaza = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmAlmacen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmProducto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmUnidadMedida = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmExistencia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCosto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(793, 256)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtTotal.ComboBoxEnlazado = Nothing
        Me.txtTotal.Decimales = 2
        Me.txtTotal.Location = New System.Drawing.Point(635, 223)
        Me.txtTotal.MaxLength = 3000
        Me.txtTotal.MensajeCombo = "Seleccionar un item..."
        Me.txtTotal.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.SiguienteControl = Nothing
        Me.txtTotal.Size = New System.Drawing.Size(139, 20)
        Me.txtTotal.TabIndex = 78
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotal.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        Me.txtTotal.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtTotal.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(586, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 77
        Me.Label7.Text = "Total:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmPlaza, Me.clmAlmacen, Me.clmCodigo, Me.clmProducto, Me.clmUnidadMedida, Me.clmExistencia, Me.clmCosto, Me.clmTotal})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(782, 202)
        Me.DataGridView1.TabIndex = 0
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
        Me.Label17.Size = New System.Drawing.Size(811, 29)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "REPORTE DE INVENTARIO VALORIZADO"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.mtb.Size = New System.Drawing.Size(50, 387)
        Me.mtb.TabIndex = 0
        '
        'lblAlmacen
        '
        Me.lblAlmacen.AutoSize = True
        Me.lblAlmacen.Location = New System.Drawing.Point(71, 87)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.Size = New System.Drawing.Size(48, 13)
        Me.lblAlmacen.TabIndex = 6
        Me.lblAlmacen.Text = "Almacen"
        '
        'lblPlaza
        '
        Me.lblPlaza.AutoSize = True
        Me.lblPlaza.Location = New System.Drawing.Point(71, 52)
        Me.lblPlaza.Name = "lblPlaza"
        Me.lblPlaza.Size = New System.Drawing.Size(33, 13)
        Me.lblPlaza.TabIndex = 2
        Me.lblPlaza.Text = "Plaza"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Plaza"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Almacen"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 70
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Producto"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        DataGridViewCellStyle4.Format = "N4"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn5.HeaderText = "Existencia"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        DataGridViewCellStyle5.Format = "c4"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn6.HeaderText = "Costo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        DataGridViewCellStyle6.Format = "C4"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn7.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'cmbAlmacen
        '
        Me.cmbAlmacen.DataSource = Me.AlmacenCollectionClass1
        Me.cmbAlmacen.DisplayMember = "Descripcion"
        Me.cmbAlmacen.FormattingEnabled = True
        Me.cmbAlmacen.Location = New System.Drawing.Point(212, 86)
        Me.cmbAlmacen.Name = "cmbAlmacen"
        Me.cmbAlmacen.NombreMetodo = Nothing
        Me.cmbAlmacen.Parametros = Nothing
        Me.cmbAlmacen.SiguienteControl = Me.DataGridView1
        Me.cmbAlmacen.Size = New System.Drawing.Size(291, 21)
        Me.cmbAlmacen.TabIndex = 18
        Me.cmbAlmacen.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbAlmacen.TextBoxEnlazado = Me.txtAlmacen
        Me.cmbAlmacen.ValueMember = "Codigo"
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
        'txtAlmacen
        '
        Me.txtAlmacen.ComboBoxEnlazado = Me.cmbAlmacen
        Me.txtAlmacen.Decimales = 0
        Me.txtAlmacen.Location = New System.Drawing.Point(139, 87)
        Me.txtAlmacen.MaxLength = 3000
        Me.txtAlmacen.MensajeCombo = "Todos Los almacenes"
        Me.txtAlmacen.MensajeNoExiste = "No existe"
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.SiguienteControl = Me.cmbAlmacen
        Me.txtAlmacen.Size = New System.Drawing.Size(67, 20)
        Me.txtAlmacen.TabIndex = 17
        Me.txtAlmacen.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtAlmacen.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtAlmacen.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cmbPlaza
        '
        Me.cmbPlaza.DataSource = Me.PlazaCol
        Me.cmbPlaza.DisplayMember = "Descripcion"
        Me.cmbPlaza.FormattingEnabled = True
        Me.cmbPlaza.Location = New System.Drawing.Point(212, 51)
        Me.cmbPlaza.Name = "cmbPlaza"
        Me.cmbPlaza.NombreMetodo = Nothing
        Me.cmbPlaza.Parametros = Nothing
        Me.cmbPlaza.SiguienteControl = Me.txtAlmacen
        Me.cmbPlaza.Size = New System.Drawing.Size(291, 21)
        Me.cmbPlaza.TabIndex = 16
        Me.cmbPlaza.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbPlaza.TextBoxEnlazado = Me.txtPlaza
        Me.cmbPlaza.ValueMember = "Codigo"
        '
        'PlazaCol
        '
        Me.PlazaCol.AllowEdit = True
        Me.PlazaCol.AllowNew = True
        Me.PlazaCol.AllowRemove = True
        Me.PlazaCol.MaximoElementosSeleccionados = 1
        Me.PlazaCol.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.PlazaCol.MostrarAlertas = False
        Me.PlazaCol.Name = ""
        Me.PlazaCol.RaiseListChangedEvents = True
        Me.PlazaCol.Transaction = Nothing
        '
        'txtPlaza
        '
        Me.txtPlaza.ComboBoxEnlazado = Me.cmbPlaza
        Me.txtPlaza.Decimales = 0
        Me.txtPlaza.Location = New System.Drawing.Point(139, 52)
        Me.txtPlaza.MaxLength = 3000
        Me.txtPlaza.MensajeCombo = "Todas Las Plazas"
        Me.txtPlaza.MensajeNoExiste = "No existe "
        Me.txtPlaza.Name = "txtPlaza"
        Me.txtPlaza.SiguienteControl = Me.cmbPlaza
        Me.txtPlaza.Size = New System.Drawing.Size(67, 20)
        Me.txtPlaza.TabIndex = 15
        Me.txtPlaza.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtPlaza.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtPlaza.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ProveedorCol
        '
        Me.ProveedorCol.AllowEdit = True
        Me.ProveedorCol.AllowNew = True
        Me.ProveedorCol.AllowRemove = True
        Me.ProveedorCol.MaximoElementosSeleccionados = 1
        Me.ProveedorCol.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.ProveedorCol.Mostrar = ClasesNegocio.MostrarEnum.CLIENTES
        Me.ProveedorCol.MostrarAlertas = False
        Me.ProveedorCol.Name = ""
        Me.ProveedorCol.RaiseListChangedEvents = True
        Me.ProveedorCol.Transaction = Nothing
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Location = New System.Drawing.Point(71, 119)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(39, 13)
        Me.lblMensaje.TabIndex = 19
        Me.lblMensaje.Text = "Label1"
        Me.lblMensaje.Visible = False
        '
        'clmPlaza
        '
        Me.clmPlaza.HeaderText = "Plaza"
        Me.clmPlaza.Name = "clmPlaza"
        Me.clmPlaza.ReadOnly = True
        '
        'clmAlmacen
        '
        Me.clmAlmacen.HeaderText = "Almacen"
        Me.clmAlmacen.Name = "clmAlmacen"
        Me.clmAlmacen.ReadOnly = True
        Me.clmAlmacen.Width = 150
        '
        'clmCodigo
        '
        Me.clmCodigo.HeaderText = "Codigo"
        Me.clmCodigo.Name = "clmCodigo"
        Me.clmCodigo.ReadOnly = True
        Me.clmCodigo.Visible = False
        Me.clmCodigo.Width = 70
        '
        'clmProducto
        '
        Me.clmProducto.HeaderText = "Producto"
        Me.clmProducto.Name = "clmProducto"
        Me.clmProducto.ReadOnly = True
        Me.clmProducto.Width = 150
        '
        'clmUnidadMedida
        '
        Me.clmUnidadMedida.HeaderText = "Unidad"
        Me.clmUnidadMedida.Name = "clmUnidadMedida"
        Me.clmUnidadMedida.ReadOnly = True
        Me.clmUnidadMedida.Width = 60
        '
        'clmExistencia
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.clmExistencia.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmExistencia.HeaderText = "Existencia"
        Me.clmExistencia.Name = "clmExistencia"
        Me.clmExistencia.ReadOnly = True
        '
        'clmCosto
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.clmCosto.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmCosto.HeaderText = "Costo"
        Me.clmCosto.Name = "clmCosto"
        Me.clmCosto.ReadOnly = True
        '
        'clmTotal
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.clmTotal.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmTotal.HeaderText = "Total"
        Me.clmTotal.Name = "clmTotal"
        Me.clmTotal.ReadOnly = True
        '
        'rptInventarioValorizado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 387)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.cmbAlmacen)
        Me.Controls.Add(Me.txtAlmacen)
        Me.Controls.Add(Me.cmbPlaza)
        Me.Controls.Add(Me.txtPlaza)
        Me.Controls.Add(Me.lblPlaza)
        Me.Controls.Add(Me.lblAlmacen)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.Name = "rptInventarioValorizado"
        Me.Text = "Reporte de Inventario Valorizado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents lblAlmacen As System.Windows.Forms.Label
    Friend WithEvents lblPlaza As System.Windows.Forms.Label
    Friend WithEvents PlazaCol As ClasesNegocio.PlazaCollectionClass
    Friend WithEvents ProveedorCol As ClasesNegocio.ProveedorCollectionClass
    Friend WithEvents CachedrptOtrasEntradas1 As ClasesNegocio.CachedrptOtrasEntradas
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPlaza As Integralab.Controles.TextBoxMejorado
    Friend WithEvents cmbPlaza As Integralab.Controles.ComboBoxMejorado
    Friend WithEvents txtAlmacen As Integralab.Controles.TextBoxMejorado
    Friend WithEvents cmbAlmacen As Integralab.Controles.ComboBoxMejorado
    Friend WithEvents txtTotal As Integralab.Controles.TextBoxMejorado
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlmacenCollectionClass1 As ClasesNegocio.AlmacenCollectionClass
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents clmPlaza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmAlmacen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmUnidadMedida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmExistencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCosto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTotal As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
