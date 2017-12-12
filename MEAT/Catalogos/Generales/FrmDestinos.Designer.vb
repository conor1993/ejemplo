<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDestinos
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
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtFiltroDesc = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtFiltroCod = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.DgvDestinos = New System.Windows.Forms.DataGridView
        Me.clmCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmDescripción = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmDomicilio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmColonia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEstado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCiudad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPoblacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CmbEstados = New Integralab.Controles.ComboBoxMejorado
        Me.CmbCiudad = New Integralab.Controles.ComboBoxMejorado
        Me.CmbPoblacion = New Integralab.Controles.ComboBoxMejorado
        Me.txtDescripcion = New Integralab.Controles.TextBoxMejorado
        Me.txtDomicilio = New Integralab.Controles.TextBoxMejorado
        Me.txtColonia = New Integralab.Controles.TextBoxMejorado
        Me.txtTelefono = New Integralab.Controles.TextBoxMejorado
        Me.txtCP = New Integralab.Controles.TextBoxMejorado
        Me.cmbClientes = New Integralab.Controles.ComboBoxMejorado
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvDestinos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.mtb.Location = New System.Drawing.Point(1, -27)
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
        Me.mtb.TabIndex = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(787, 29)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "CATÁLOGO DESTINOS"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Estado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Ciudad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Población:"
        '
        'lblEstatus
        '
        Me.lblEstatus.AutoSize = True
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblEstatus.Location = New System.Drawing.Point(664, 33)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(104, 24)
        Me.lblEstatus.TabIndex = 2
        Me.lblEstatus.Text = "ESTATUS"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(128, 38)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(66, 20)
        Me.txtCodigo.TabIndex = 10
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Código:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(374, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Descripción:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(374, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Domicilio:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(374, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Colonia:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(374, 148)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Telefono:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(623, 148)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "C.P. :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(58, 148)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Cliente:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtFiltroDesc)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtFiltroCod)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.DgvDestinos)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(61, 172)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(686, 287)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Destinos Registrados"
        '
        'txtFiltroDesc
        '
        Me.txtFiltroDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFiltroDesc.Location = New System.Drawing.Point(246, 21)
        Me.txtFiltroDesc.Name = "txtFiltroDesc"
        Me.txtFiltroDesc.Size = New System.Drawing.Size(301, 20)
        Me.txtFiltroDesc.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(162, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Descripción:"
        '
        'txtFiltroCod
        '
        Me.txtFiltroCod.Location = New System.Drawing.Point(62, 21)
        Me.txtFiltroCod.Name = "txtFiltroCod"
        Me.txtFiltroCod.Size = New System.Drawing.Size(81, 20)
        Me.txtFiltroCod.TabIndex = 1
        Me.txtFiltroCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Código:"
        '
        'DgvDestinos
        '
        Me.DgvDestinos.AllowUserToAddRows = False
        Me.DgvDestinos.AllowUserToDeleteRows = False
        Me.DgvDestinos.AllowUserToResizeRows = False
        Me.DgvDestinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDestinos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmCodigo, Me.clmDescripción, Me.clmDomicilio, Me.clmColonia, Me.clmCliente, Me.clmEstado, Me.clmCiudad, Me.clmPoblacion, Me.ClmEstatus})
        Me.DgvDestinos.Location = New System.Drawing.Point(6, 53)
        Me.DgvDestinos.MultiSelect = False
        Me.DgvDestinos.Name = "DgvDestinos"
        Me.DgvDestinos.ReadOnly = True
        Me.DgvDestinos.RowHeadersVisible = False
        Me.DgvDestinos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDestinos.Size = New System.Drawing.Size(670, 228)
        Me.DgvDestinos.TabIndex = 4
        '
        'clmCodigo
        '
        Me.clmCodigo.DataPropertyName = "Codigo"
        Me.clmCodigo.HeaderText = "Código"
        Me.clmCodigo.Name = "clmCodigo"
        Me.clmCodigo.ReadOnly = True
        '
        'clmDescripción
        '
        Me.clmDescripción.DataPropertyName = "Descripcion"
        Me.clmDescripción.HeaderText = "Descripción"
        Me.clmDescripción.Name = "clmDescripción"
        Me.clmDescripción.ReadOnly = True
        '
        'clmDomicilio
        '
        Me.clmDomicilio.DataPropertyName = "Domicilio"
        Me.clmDomicilio.HeaderText = "Domicilio"
        Me.clmDomicilio.Name = "clmDomicilio"
        Me.clmDomicilio.ReadOnly = True
        '
        'clmColonia
        '
        Me.clmColonia.DataPropertyName = "Colonia"
        Me.clmColonia.HeaderText = "Colonia"
        Me.clmColonia.Name = "clmColonia"
        Me.clmColonia.ReadOnly = True
        '
        'clmCliente
        '
        Me.clmCliente.DataPropertyName = "NomCliente"
        Me.clmCliente.HeaderText = "Cliente"
        Me.clmCliente.Name = "clmCliente"
        Me.clmCliente.ReadOnly = True
        '
        'clmEstado
        '
        Me.clmEstado.DataPropertyName = "NomEstado"
        Me.clmEstado.HeaderText = "Estado"
        Me.clmEstado.Name = "clmEstado"
        Me.clmEstado.ReadOnly = True
        '
        'clmCiudad
        '
        Me.clmCiudad.DataPropertyName = "NomCiudad"
        Me.clmCiudad.HeaderText = "Ciudad"
        Me.clmCiudad.Name = "clmCiudad"
        Me.clmCiudad.ReadOnly = True
        '
        'clmPoblacion
        '
        Me.clmPoblacion.DataPropertyName = "NomPoblacion"
        Me.clmPoblacion.HeaderText = "Población"
        Me.clmPoblacion.Name = "clmPoblacion"
        Me.clmPoblacion.ReadOnly = True
        '
        'ClmEstatus
        '
        Me.ClmEstatus.DataPropertyName = "Estatus"
        Me.ClmEstatus.HeaderText = "Estatus"
        Me.ClmEstatus.Name = "ClmEstatus"
        Me.ClmEstatus.ReadOnly = True
        '
        'CmbEstados
        '
        Me.CmbEstados.FormattingEnabled = True
        Me.CmbEstados.Location = New System.Drawing.Point(128, 64)
        Me.CmbEstados.Name = "CmbEstados"
        Me.CmbEstados.NombreMetodo = Nothing
        Me.CmbEstados.Parametros = Nothing
        Me.CmbEstados.SiguienteControl = Me.CmbCiudad
        Me.CmbEstados.Size = New System.Drawing.Size(230, 21)
        Me.CmbEstados.TabIndex = 4
        Me.CmbEstados.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.CmbEstados.TextBoxEnlazado = Nothing
        '
        'CmbCiudad
        '
        Me.CmbCiudad.FormattingEnabled = True
        Me.CmbCiudad.Location = New System.Drawing.Point(128, 91)
        Me.CmbCiudad.Name = "CmbCiudad"
        Me.CmbCiudad.NombreMetodo = Nothing
        Me.CmbCiudad.Parametros = Nothing
        Me.CmbCiudad.SiguienteControl = Me.CmbPoblacion
        Me.CmbCiudad.Size = New System.Drawing.Size(230, 21)
        Me.CmbCiudad.TabIndex = 6
        Me.CmbCiudad.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.CmbCiudad.TextBoxEnlazado = Nothing
        '
        'CmbPoblacion
        '
        Me.CmbPoblacion.FormattingEnabled = True
        Me.CmbPoblacion.Location = New System.Drawing.Point(128, 118)
        Me.CmbPoblacion.Name = "CmbPoblacion"
        Me.CmbPoblacion.NombreMetodo = Nothing
        Me.CmbPoblacion.Parametros = Nothing
        Me.CmbPoblacion.SiguienteControl = Me.txtDescripcion
        Me.CmbPoblacion.Size = New System.Drawing.Size(230, 21)
        Me.CmbPoblacion.TabIndex = 8
        Me.CmbPoblacion.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.CmbPoblacion.TextBoxEnlazado = Nothing
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.ComboBoxEnlazado = Nothing
        Me.txtDescripcion.Decimales = 0
        Me.txtDescripcion.Location = New System.Drawing.Point(446, 65)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.MensajeCombo = "Seleccionar un item..."
        Me.txtDescripcion.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.SiguienteControl = Me.txtDomicilio
        Me.txtDescripcion.Size = New System.Drawing.Size(301, 20)
        Me.txtDescripcion.TabIndex = 12
        Me.txtDescripcion.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtDescripcion.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtDescripcion.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtDomicilio
        '
        Me.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDomicilio.ComboBoxEnlazado = Nothing
        Me.txtDomicilio.Decimales = 0
        Me.txtDomicilio.Location = New System.Drawing.Point(446, 92)
        Me.txtDomicilio.MaxLength = 100
        Me.txtDomicilio.MensajeCombo = "Seleccionar un item..."
        Me.txtDomicilio.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.SiguienteControl = Me.txtColonia
        Me.txtDomicilio.Size = New System.Drawing.Size(301, 20)
        Me.txtDomicilio.TabIndex = 14
        Me.txtDomicilio.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtDomicilio.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtDomicilio.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtColonia
        '
        Me.txtColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtColonia.ComboBoxEnlazado = Nothing
        Me.txtColonia.Decimales = 0
        Me.txtColonia.Location = New System.Drawing.Point(446, 119)
        Me.txtColonia.MaxLength = 50
        Me.txtColonia.MensajeCombo = "Seleccionar un item..."
        Me.txtColonia.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.SiguienteControl = Me.txtTelefono
        Me.txtColonia.Size = New System.Drawing.Size(301, 20)
        Me.txtColonia.TabIndex = 16
        Me.txtColonia.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtColonia.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtColonia.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtTelefono
        '
        Me.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelefono.ComboBoxEnlazado = Nothing
        Me.txtTelefono.Decimales = 0
        Me.txtTelefono.Location = New System.Drawing.Point(446, 145)
        Me.txtTelefono.MaxLength = 3000
        Me.txtTelefono.MensajeCombo = "Seleccionar un item..."
        Me.txtTelefono.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.SiguienteControl = Me.txtCP
        Me.txtTelefono.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono.TabIndex = 18
        Me.txtTelefono.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtTelefono.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtTelefono.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtCP
        '
        Me.txtCP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCP.ComboBoxEnlazado = Nothing
        Me.txtCP.Decimales = 0
        Me.txtCP.Location = New System.Drawing.Point(662, 145)
        Me.txtCP.MaxLength = 3000
        Me.txtCP.MensajeCombo = "Seleccionar un item..."
        Me.txtCP.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtCP.Name = "txtCP"
        Me.txtCP.SiguienteControl = Me.cmbClientes
        Me.txtCP.Size = New System.Drawing.Size(85, 20)
        Me.txtCP.TabIndex = 20
        Me.txtCP.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtCP.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCP.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cmbClientes
        '
        Me.cmbClientes.FormattingEnabled = True
        Me.cmbClientes.Location = New System.Drawing.Point(128, 145)
        Me.cmbClientes.Name = "cmbClientes"
        Me.cmbClientes.NombreMetodo = Nothing
        Me.cmbClientes.Parametros = Nothing
        Me.cmbClientes.SiguienteControl = Nothing
        Me.cmbClientes.Size = New System.Drawing.Size(230, 21)
        Me.cmbClientes.TabIndex = 22
        Me.cmbClientes.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbClientes.TextBoxEnlazado = Nothing
        '
        'FrmDestinos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 478)
        Me.Controls.Add(Me.txtCP)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtColonia)
        Me.Controls.Add(Me.txtDomicilio)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.cmbClientes)
        Me.Controls.Add(Me.CmbPoblacion)
        Me.Controls.Add(Me.CmbCiudad)
        Me.Controls.Add(Me.CmbEstados)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblEstatus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.mtb)
        Me.Name = "FrmDestinos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Destinos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvDestinos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DgvDestinos As System.Windows.Forms.DataGridView
    Friend WithEvents txtFiltroCod As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtFiltroDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Private WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents clmCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDescripción As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDomicilio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmColonia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEstado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCiudad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPoblacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CmbEstados As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents CmbCiudad As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents CmbPoblacion As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents cmbClientes As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents txtDescripcion As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtDomicilio As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtColonia As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtTelefono As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtCP As IntegraLab.Controles.TextBoxMejorado
End Class
