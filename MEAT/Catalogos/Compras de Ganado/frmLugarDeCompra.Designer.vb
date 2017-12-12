<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLugarDeCompra
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mtb = New MEAToolBar.MEAToolBar()
        Me.lblEstatus = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigo = New IntegraLab.Controles.TextBoxMejorado()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New IntegraLab.Controles.TextBoxMejorado()
        Me.txtCodigoEstado = New IntegraLab.Controles.TextBoxMejorado()
        Me.cmbEstado = New IntegraLab.Controles.ComboBoxMejorado()
        Me.EstadoC = New ClasesNegocio.EstadoCollectionClass()
        Me.txtCodigoCiudad = New IntegraLab.Controles.TextBoxMejorado()
        Me.cmbCiudad = New IntegraLab.Controles.ComboBoxMejorado()
        Me.CiudadC = New ClasesNegocio.CiudadCollectionClass()
        Me.txtCodigoPoblacion = New IntegraLab.Controles.TextBoxMejorado()
        Me.cmbPoblacion = New IntegraLab.Controles.ComboBoxMejorado()
        Me.PoblacionC = New ClasesNegocio.PoblacionCollectionClass()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgLugaresDeCompra = New System.Windows.Forms.DataGridView()
        Me.IdLugarCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PoblacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LugaresDeCompraC = New ClasesNegocio.LugaresDeCompraCollectionClass()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtHorasTransporte = New IntegraLab.Controles.TextBoxMejorado()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgLugaresDeCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(887, 29)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "CATÁLOGO LUGARES DE COMPRA"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mtb
        '
        Me.mtb.ButtonSize = New System.Drawing.Size(50, 50)
        Me.mtb.Dock = System.Windows.Forms.DockStyle.None
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
        Me.mtb.Location = New System.Drawing.Point(3, -27)
        Me.mtb.MostrarBorrar = True
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = True
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 747)
        Me.mtb.TabIndex = 66
        '
        'lblEstatus
        '
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblEstatus.Location = New System.Drawing.Point(713, 41)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(157, 24)
        Me.lblEstatus.TabIndex = 68
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.ComboBoxEnlazado = Nothing
        Me.txtCodigo.Decimales = 0
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(142, 37)
        Me.txtCodigo.MaxLength = 3000
        Me.txtCodigo.MensajeCombo = "Seleccionar un item..."
        Me.txtCodigo.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.SiguienteControl = Nothing
        Me.txtCodigo.Size = New System.Drawing.Size(48, 20)
        Me.txtCodigo.TabIndex = 70
        Me.txtCodigo.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtCodigo.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCodigo.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Descripción:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.ComboBoxEnlazado = Nothing
        Me.txtDescripcion.Decimales = 0
        Me.txtDescripcion.Location = New System.Drawing.Point(142, 63)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.MensajeCombo = "Seleccionar un item..."
        Me.txtDescripcion.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.SiguienteControl = Me.txtCodigoEstado
        Me.txtDescripcion.Size = New System.Drawing.Size(561, 20)
        Me.txtDescripcion.TabIndex = 72
        Me.txtDescripcion.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtDescripcion.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtDescripcion.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtCodigoEstado
        '
        Me.txtCodigoEstado.ComboBoxEnlazado = Me.cmbEstado
        Me.txtCodigoEstado.Decimales = 0
        Me.txtCodigoEstado.Location = New System.Drawing.Point(142, 89)
        Me.txtCodigoEstado.MaxLength = 3000
        Me.txtCodigoEstado.MensajeCombo = "Seleccionar un estado..."
        Me.txtCodigoEstado.MensajeNoExiste = "No existe un estado con este código o se encuentra inactivo"
        Me.txtCodigoEstado.Name = "txtCodigoEstado"
        Me.txtCodigoEstado.SiguienteControl = Me.txtCodigoCiudad
        Me.txtCodigoEstado.Size = New System.Drawing.Size(48, 20)
        Me.txtCodigoEstado.TabIndex = 74
        Me.txtCodigoEstado.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtCodigoEstado.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCodigoEstado.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cmbEstado
        '
        Me.cmbEstado.DataSource = Me.EstadoC
        Me.cmbEstado.DisplayMember = "Descripcion"
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(196, 89)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.NombreMetodo = Nothing
        Me.cmbEstado.Parametros = Nothing
        Me.cmbEstado.SiguienteControl = Me.txtCodigoCiudad
        Me.cmbEstado.Size = New System.Drawing.Size(360, 21)
        Me.cmbEstado.TabIndex = 75
        Me.cmbEstado.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbEstado.TextBoxEnlazado = Me.txtCodigoEstado
        Me.cmbEstado.ValueMember = "Codigo"
        '
        'EstadoC
        '
        Me.EstadoC.AllowEdit = True
        Me.EstadoC.AllowNew = True
        Me.EstadoC.AllowRemove = True
        Me.EstadoC.Name = ""
        Me.EstadoC.RaiseListChangedEvents = True
        '
        'txtCodigoCiudad
        '
        Me.txtCodigoCiudad.ComboBoxEnlazado = Me.cmbCiudad
        Me.txtCodigoCiudad.Decimales = 0
        Me.txtCodigoCiudad.Location = New System.Drawing.Point(142, 116)
        Me.txtCodigoCiudad.MaxLength = 3000
        Me.txtCodigoCiudad.MensajeCombo = "Seleccionar una ciudad..."
        Me.txtCodigoCiudad.MensajeNoExiste = "No existe una ciudad con este código o se encuentra inactivo"
        Me.txtCodigoCiudad.Name = "txtCodigoCiudad"
        Me.txtCodigoCiudad.SiguienteControl = Me.txtCodigoPoblacion
        Me.txtCodigoCiudad.Size = New System.Drawing.Size(48, 20)
        Me.txtCodigoCiudad.TabIndex = 77
        Me.txtCodigoCiudad.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtCodigoCiudad.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCodigoCiudad.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cmbCiudad
        '
        Me.cmbCiudad.DataSource = Me.CiudadC
        Me.cmbCiudad.DisplayMember = "Descripcion"
        Me.cmbCiudad.FormattingEnabled = True
        Me.cmbCiudad.Location = New System.Drawing.Point(196, 116)
        Me.cmbCiudad.Name = "cmbCiudad"
        Me.cmbCiudad.NombreMetodo = Nothing
        Me.cmbCiudad.Parametros = Nothing
        Me.cmbCiudad.SiguienteControl = Me.txtCodigoPoblacion
        Me.cmbCiudad.Size = New System.Drawing.Size(360, 21)
        Me.cmbCiudad.TabIndex = 78
        Me.cmbCiudad.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbCiudad.TextBoxEnlazado = Me.txtCodigoCiudad
        Me.cmbCiudad.ValueMember = "Codigo"
        '
        'CiudadC
        '
        Me.CiudadC.AllowEdit = True
        Me.CiudadC.AllowNew = True
        Me.CiudadC.AllowRemove = True
        Me.CiudadC.Name = ""
        Me.CiudadC.RaiseListChangedEvents = True
        '
        'txtCodigoPoblacion
        '
        Me.txtCodigoPoblacion.ComboBoxEnlazado = Me.cmbPoblacion
        Me.txtCodigoPoblacion.Decimales = 0
        Me.txtCodigoPoblacion.Location = New System.Drawing.Point(142, 143)
        Me.txtCodigoPoblacion.MaxLength = 3000
        Me.txtCodigoPoblacion.MensajeCombo = "Seleccionar una población..."
        Me.txtCodigoPoblacion.MensajeNoExiste = "No existe una población con este código o se encuentra inactivo"
        Me.txtCodigoPoblacion.Name = "txtCodigoPoblacion"
        Me.txtCodigoPoblacion.SiguienteControl = Nothing
        Me.txtCodigoPoblacion.Size = New System.Drawing.Size(48, 20)
        Me.txtCodigoPoblacion.TabIndex = 80
        Me.txtCodigoPoblacion.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtCodigoPoblacion.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCodigoPoblacion.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cmbPoblacion
        '
        Me.cmbPoblacion.DataSource = Me.PoblacionC
        Me.cmbPoblacion.DisplayMember = "Descripcion"
        Me.cmbPoblacion.FormattingEnabled = True
        Me.cmbPoblacion.Location = New System.Drawing.Point(196, 143)
        Me.cmbPoblacion.Name = "cmbPoblacion"
        Me.cmbPoblacion.NombreMetodo = Nothing
        Me.cmbPoblacion.Parametros = Nothing
        Me.cmbPoblacion.SiguienteControl = Nothing
        Me.cmbPoblacion.Size = New System.Drawing.Size(360, 21)
        Me.cmbPoblacion.TabIndex = 81
        Me.cmbPoblacion.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbPoblacion.TextBoxEnlazado = Me.txtCodigoPoblacion
        Me.cmbPoblacion.ValueMember = "Codigo"
        '
        'PoblacionC
        '
        Me.PoblacionC.AllowEdit = True
        Me.PoblacionC.AllowNew = True
        Me.PoblacionC.AllowRemove = True
        Me.PoblacionC.MaximoElementosSeleccionados = 1
        Me.PoblacionC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.PoblacionC.MostrarAlertas = False
        Me.PoblacionC.Name = ""
        Me.PoblacionC.RaiseListChangedEvents = True
        Me.PoblacionC.Transaction = Nothing
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Estado:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(59, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "Ciudad:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(59, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "Población:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgLugaresDeCompra)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 174)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(814, 389)
        Me.GroupBox1.TabIndex = 82
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de Lugares de Compra"
        '
        'dgLugaresDeCompra
        '
        Me.dgLugaresDeCompra.AllowUserToAddRows = False
        Me.dgLugaresDeCompra.AllowUserToDeleteRows = False
        Me.dgLugaresDeCompra.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgLugaresDeCompra.AutoGenerateColumns = False
        Me.dgLugaresDeCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLugaresDeCompra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdLugarCompraDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.PoblacionDataGridViewTextBoxColumn, Me.EstatusDataGridViewTextBoxColumn})
        Me.dgLugaresDeCompra.DataSource = Me.LugaresDeCompraC
        Me.dgLugaresDeCompra.Location = New System.Drawing.Point(6, 19)
        Me.dgLugaresDeCompra.Name = "dgLugaresDeCompra"
        Me.dgLugaresDeCompra.ReadOnly = True
        Me.dgLugaresDeCompra.RowHeadersVisible = False
        Me.dgLugaresDeCompra.Size = New System.Drawing.Size(802, 364)
        Me.dgLugaresDeCompra.TabIndex = 0
        '
        'IdLugarCompraDataGridViewTextBoxColumn
        '
        Me.IdLugarCompraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.IdLugarCompraDataGridViewTextBoxColumn.DataPropertyName = "IdLugarCompra"
        Me.IdLugarCompraDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.IdLugarCompraDataGridViewTextBoxColumn.Name = "IdLugarCompraDataGridViewTextBoxColumn"
        Me.IdLugarCompraDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdLugarCompraDataGridViewTextBoxColumn.Width = 65
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 88
        '
        'PoblacionDataGridViewTextBoxColumn
        '
        Me.PoblacionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.PoblacionDataGridViewTextBoxColumn.DataPropertyName = "Poblacion"
        Me.PoblacionDataGridViewTextBoxColumn.HeaderText = "Poblacion"
        Me.PoblacionDataGridViewTextBoxColumn.Name = "PoblacionDataGridViewTextBoxColumn"
        Me.PoblacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.PoblacionDataGridViewTextBoxColumn.Width = 79
        '
        'EstatusDataGridViewTextBoxColumn
        '
        Me.EstatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.EstatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.HeaderText = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.Name = "EstatusDataGridViewTextBoxColumn"
        Me.EstatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstatusDataGridViewTextBoxColumn.Width = 67
        '
        'LugaresDeCompraC
        '
        Me.LugaresDeCompraC.AllowEdit = True
        Me.LugaresDeCompraC.AllowNew = True
        Me.LugaresDeCompraC.AllowRemove = True
        Me.LugaresDeCompraC.MaximoElementosSeleccionados = 1
        Me.LugaresDeCompraC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.LugaresDeCompraC.MostrarAlertas = False
        Me.LugaresDeCompraC.Name = Nothing
        Me.LugaresDeCompraC.RaiseListChangedEvents = True
        Me.LugaresDeCompraC.Transaction = Nothing
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(563, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 83
        Me.Label7.Text = "Horas de Viaje:"
        '
        'txtHorasTransporte
        '
        Me.txtHorasTransporte.ComboBoxEnlazado = Nothing
        Me.txtHorasTransporte.Decimales = 2
        Me.txtHorasTransporte.Location = New System.Drawing.Point(645, 93)
        Me.txtHorasTransporte.MaxLength = 3000
        Me.txtHorasTransporte.MensajeCombo = "Seleccionar un item..."
        Me.txtHorasTransporte.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtHorasTransporte.Name = "txtHorasTransporte"
        Me.txtHorasTransporte.SiguienteControl = Nothing
        Me.txtHorasTransporte.Size = New System.Drawing.Size(55, 20)
        Me.txtHorasTransporte.TabIndex = 84
        Me.txtHorasTransporte.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.[Decimal]
        Me.txtHorasTransporte.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtHorasTransporte.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'frmLugarDeCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 575)
        Me.Controls.Add(Me.txtHorasTransporte)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbPoblacion)
        Me.Controls.Add(Me.txtCodigoPoblacion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbCiudad)
        Me.Controls.Add(Me.txtCodigoCiudad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbEstado)
        Me.Controls.Add(Me.txtCodigoEstado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.lblEstatus)
        Me.Name = "frmLugarDeCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lugares de Compra"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgLugaresDeCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoEstado As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents cmbEstado As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents cmbCiudad As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents txtCodigoCiudad As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbPoblacion As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents txtCodigoPoblacion As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgLugaresDeCompra As System.Windows.Forms.DataGridView
    Friend WithEvents CiudadC As ClasesNegocio.CiudadCollectionClass
    Friend WithEvents EstadoC As ClasesNegocio.EstadoCollectionClass
    Friend WithEvents PoblacionC As ClasesNegocio.PoblacionCollectionClass
    Friend WithEvents IdLugarCompraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PoblacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LugaresDeCompraC As ClasesNegocio.LugaresDeCompraCollectionClass
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtHorasTransporte As Integralab.Controles.TextBoxMejorado
End Class
