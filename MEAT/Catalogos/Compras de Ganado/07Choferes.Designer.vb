<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CatComp07Choferes
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
        Me.TxtAmaterno = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtAPaterno = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtNombre = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtCodigo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Txtfiltro = New System.Windows.Forms.TextBox
        Me.DgvChoferes = New System.Windows.Forms.DataGridView
        Me.clmNombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEstado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCiudad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPoblacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtLicencia = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.cmbCiudad = New System.Windows.Forms.ComboBox
        Me.cmbEstado = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtColonia = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtCalle = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cmbPoblacion = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtTipoLicencia = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtNombreCorto = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtTelefono = New System.Windows.Forms.TextBox
        Me.txtCelular = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtObservaciones = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.DtpFechaVencimiento = New System.Windows.Forms.DateTimePicker
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtTipoSangre = New System.Windows.Forms.TextBox
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvChoferes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtAmaterno
        '
        Me.TxtAmaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAmaterno.Location = New System.Drawing.Point(481, 84)
        Me.TxtAmaterno.MaximumSize = New System.Drawing.Size(510, 20)
        Me.TxtAmaterno.MaxLength = 70
        Me.TxtAmaterno.Name = "TxtAmaterno"
        Me.TxtAmaterno.Size = New System.Drawing.Size(190, 20)
        Me.TxtAmaterno.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(378, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Apellido Materno:"
        '
        'TxtAPaterno
        '
        Me.TxtAPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAPaterno.Location = New System.Drawing.Point(165, 84)
        Me.TxtAPaterno.MaximumSize = New System.Drawing.Size(510, 20)
        Me.TxtAPaterno.MaxLength = 70
        Me.TxtAPaterno.Name = "TxtAPaterno"
        Me.TxtAPaterno.Size = New System.Drawing.Size(181, 20)
        Me.TxtAPaterno.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(59, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Apellido Paterno:"
        '
        'TxtNombre
        '
        Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre.Location = New System.Drawing.Point(165, 58)
        Me.TxtNombre.MaximumSize = New System.Drawing.Size(510, 20)
        Me.TxtNombre.MaxLength = 100
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(181, 20)
        Me.TxtNombre.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(59, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Nombre:"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCodigo.Enabled = False
        Me.TxtCodigo.Location = New System.Drawing.Point(165, 32)
        Me.TxtCodigo.MaximumSize = New System.Drawing.Size(100, 20)
        Me.TxtCodigo.MaxLength = 4
        Me.TxtCodigo.MinimumSize = New System.Drawing.Size(100, 20)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.ReadOnly = True
        Me.TxtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodigo.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Codigo:"
        '
        'MEAToolBar1
        '
        Me.MEAToolBar1.ButtonSize = New System.Drawing.Size(50, 50)
        Me.MEAToolBar1.Dock = System.Windows.Forms.DockStyle.None
        Me.MEAToolBar1.DropDownArrows = True
        Me.MEAToolBar1.HabilitarBorrar = True
        Me.MEAToolBar1.HabilitarBuscar = False
        Me.MEAToolBar1.HabilitarCancelar = True
        Me.MEAToolBar1.HabilitarEditar = True
        Me.MEAToolBar1.HabilitarGuardar = True
        Me.MEAToolBar1.HabilitarImprimir = True
        Me.MEAToolBar1.HabilitarLimpiar = True
        Me.MEAToolBar1.HabilitarNuevo = True
        Me.MEAToolBar1.HabilitarSalir = True
        Me.MEAToolBar1.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32
        Me.MEAToolBar1.Location = New System.Drawing.Point(3, 28)
        Me.MEAToolBar1.MostrarBorrar = True
        Me.MEAToolBar1.MostrarBuscar = False
        Me.MEAToolBar1.MostrarCancelar = True
        Me.MEAToolBar1.MostrarEditar = True
        Me.MEAToolBar1.MostrarGuardar = True
        Me.MEAToolBar1.MostrarImprimir = True
        Me.MEAToolBar1.MostrarLimpiar = True
        Me.MEAToolBar1.MostrarNuevo = True
        Me.MEAToolBar1.MostrarSalir = True
        Me.MEAToolBar1.Name = "MEAToolBar1"
        Me.MEAToolBar1.ShowToolTips = True
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 747)
        Me.MEAToolBar1.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.MaximumSize = New System.Drawing.Size(1800, 1800)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(717, 29)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "CATÁLOGO CHOFERES"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Txtfiltro)
        Me.GroupBox1.Controls.Add(Me.DgvChoferes)
        Me.GroupBox1.Location = New System.Drawing.Point(62, 349)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(643, 244)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de Choferes"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(21, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Buscar:"
        '
        'Txtfiltro
        '
        Me.Txtfiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtfiltro.Location = New System.Drawing.Point(85, 16)
        Me.Txtfiltro.MaxLength = 40
        Me.Txtfiltro.Name = "Txtfiltro"
        Me.Txtfiltro.Size = New System.Drawing.Size(299, 20)
        Me.Txtfiltro.TabIndex = 18
        '
        'DgvChoferes
        '
        Me.DgvChoferes.AllowUserToAddRows = False
        Me.DgvChoferes.AllowUserToDeleteRows = False
        Me.DgvChoferes.AllowUserToResizeRows = False
        Me.DgvChoferes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvChoferes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvChoferes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmNombre, Me.clmEstado, Me.clmCiudad, Me.clmPoblacion, Me.clmEstatus})
        Me.DgvChoferes.Location = New System.Drawing.Point(3, 42)
        Me.DgvChoferes.Name = "DgvChoferes"
        Me.DgvChoferes.ReadOnly = True
        Me.DgvChoferes.RowHeadersVisible = False
        Me.DgvChoferes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvChoferes.Size = New System.Drawing.Size(634, 196)
        Me.DgvChoferes.TabIndex = 19
        '
        'clmNombre
        '
        Me.clmNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmNombre.DataPropertyName = "NombreCompleto"
        Me.clmNombre.HeaderText = "Nombre"
        Me.clmNombre.Name = "clmNombre"
        Me.clmNombre.ReadOnly = True
        Me.clmNombre.Width = 67
        '
        'clmEstado
        '
        Me.clmEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmEstado.DataPropertyName = "NomEstado"
        Me.clmEstado.HeaderText = "Estado"
        Me.clmEstado.Name = "clmEstado"
        Me.clmEstado.ReadOnly = True
        Me.clmEstado.Width = 63
        '
        'clmCiudad
        '
        Me.clmCiudad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmCiudad.DataPropertyName = "NomCiudad"
        Me.clmCiudad.HeaderText = "Ciudad"
        Me.clmCiudad.Name = "clmCiudad"
        Me.clmCiudad.ReadOnly = True
        Me.clmCiudad.Width = 63
        '
        'clmPoblacion
        '
        Me.clmPoblacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmPoblacion.DataPropertyName = "NomPoblacion"
        Me.clmPoblacion.HeaderText = "Poblacion"
        Me.clmPoblacion.Name = "clmPoblacion"
        Me.clmPoblacion.ReadOnly = True
        Me.clmPoblacion.Width = 77
        '
        'clmEstatus
        '
        Me.clmEstatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmEstatus.DataPropertyName = "Estatus"
        Me.clmEstatus.HeaderText = "Estatus"
        Me.clmEstatus.Name = "clmEstatus"
        Me.clmEstatus.ReadOnly = True
        Me.clmEstatus.Width = 65
        '
        'txtLicencia
        '
        Me.txtLicencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLicencia.Location = New System.Drawing.Point(505, 245)
        Me.txtLicencia.MaximumSize = New System.Drawing.Size(312, 20)
        Me.txtLicencia.MaxLength = 20
        Me.txtLicencia.Name = "txtLicencia"
        Me.txtLicencia.Size = New System.Drawing.Size(157, 20)
        Me.txtLicencia.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(399, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Licencia de Manejo:"
        '
        'lblEstatus
        '
        Me.lblEstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(579, 32)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(123, 21)
        Me.lblEstatus.TabIndex = 37
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbCiudad
        '
        Me.cmbCiudad.DisplayMember = "Nombre"
        Me.cmbCiudad.FormattingEnabled = True
        Me.cmbCiudad.Location = New System.Drawing.Point(165, 217)
        Me.cmbCiudad.Name = "cmbCiudad"
        Me.cmbCiudad.Size = New System.Drawing.Size(225, 21)
        Me.cmbCiudad.TabIndex = 7
        Me.cmbCiudad.ValueMember = "IdCiudad"
        '
        'cmbEstado
        '
        Me.cmbEstado.DisplayMember = "Nombre"
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(165, 190)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(225, 21)
        Me.cmbEstado.TabIndex = 6
        Me.cmbEstado.ValueMember = "IdEstado"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(59, 221)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Ciudad :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(59, 194)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "Estado :"
        '
        'txtColonia
        '
        Me.txtColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtColonia.Location = New System.Drawing.Point(165, 164)
        Me.txtColonia.MaxLength = 100
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(225, 20)
        Me.txtColonia.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(59, 168)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Colonia :"
        '
        'txtCalle
        '
        Me.txtCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCalle.Location = New System.Drawing.Point(165, 138)
        Me.txtCalle.MaxLength = 200
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(359, 20)
        Me.txtCalle.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(59, 141)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 13)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "Calle y Numero :"
        '
        'cmbPoblacion
        '
        Me.cmbPoblacion.DisplayMember = "Nombre"
        Me.cmbPoblacion.FormattingEnabled = True
        Me.cmbPoblacion.Location = New System.Drawing.Point(165, 244)
        Me.cmbPoblacion.Name = "cmbPoblacion"
        Me.cmbPoblacion.Size = New System.Drawing.Size(225, 21)
        Me.cmbPoblacion.TabIndex = 8
        Me.cmbPoblacion.ValueMember = "idPoblacion"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(59, 248)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 13)
        Me.Label13.TabIndex = 60
        Me.Label13.Text = "Poblacion :"
        '
        'txtTipoLicencia
        '
        Me.txtTipoLicencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipoLicencia.Location = New System.Drawing.Point(165, 271)
        Me.txtTipoLicencia.MaximumSize = New System.Drawing.Size(312, 20)
        Me.txtTipoLicencia.MaxLength = 1
        Me.txtTipoLicencia.Name = "txtTipoLicencia"
        Me.txtTipoLicencia.Size = New System.Drawing.Size(29, 20)
        Me.txtTipoLicencia.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(57, 271)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 13)
        Me.Label14.TabIndex = 63
        Me.Label14.Text = "Tipo de Licencia:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(59, 115)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 13)
        Me.Label15.TabIndex = 64
        Me.Label15.Text = "Nombre Corto:"
        '
        'txtNombreCorto
        '
        Me.txtNombreCorto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreCorto.Location = New System.Drawing.Point(165, 112)
        Me.txtNombreCorto.MaximumSize = New System.Drawing.Size(510, 20)
        Me.txtNombreCorto.MaxLength = 70
        Me.txtNombreCorto.Name = "txtNombreCorto"
        Me.txtNombreCorto.Size = New System.Drawing.Size(181, 20)
        Me.txtNombreCorto.TabIndex = 3
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(399, 194)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 13)
        Me.Label16.TabIndex = 66
        Me.Label16.Text = "Telefono:"
        '
        'txtTelefono
        '
        Me.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelefono.Location = New System.Drawing.Point(505, 190)
        Me.txtTelefono.MaximumSize = New System.Drawing.Size(312, 20)
        Me.txtTelefono.MaxLength = 20
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(157, 20)
        Me.txtTelefono.TabIndex = 10
        '
        'txtCelular
        '
        Me.txtCelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCelular.Location = New System.Drawing.Point(505, 164)
        Me.txtCelular.MaximumSize = New System.Drawing.Size(312, 20)
        Me.txtCelular.MaxLength = 20
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(157, 20)
        Me.txtCelular.TabIndex = 9
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(399, 168)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(87, 13)
        Me.Label17.TabIndex = 68
        Me.Label17.Text = "Telefono Celular:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(58, 297)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(81, 13)
        Me.Label18.TabIndex = 70
        Me.Label18.Text = "Observaciones:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Location = New System.Drawing.Point(165, 297)
        Me.txtObservaciones.MaxLength = 250
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(307, 46)
        Me.txtObservaciones.TabIndex = 15
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(200, 274)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(113, 13)
        Me.Label19.TabIndex = 72
        Me.Label19.Text = "Fecha de Vencimiento"
        '
        'DtpFechaVencimiento
        '
        Me.DtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaVencimiento.Location = New System.Drawing.Point(319, 271)
        Me.DtpFechaVencimiento.Name = "DtpFechaVencimiento"
        Me.DtpFechaVencimiento.Size = New System.Drawing.Size(99, 20)
        Me.DtpFechaVencimiento.TabIndex = 12
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(399, 221)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(83, 13)
        Me.Label20.TabIndex = 74
        Me.Label20.Text = "Tipo de Sangre:"
        '
        'txtTipoSangre
        '
        Me.txtTipoSangre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipoSangre.Location = New System.Drawing.Point(505, 217)
        Me.txtTipoSangre.MaximumSize = New System.Drawing.Size(312, 20)
        Me.txtTipoSangre.MaxLength = 10
        Me.txtTipoSangre.Name = "txtTipoSangre"
        Me.txtTipoSangre.Size = New System.Drawing.Size(85, 20)
        Me.txtTipoSangre.TabIndex = 14
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NombreCompleto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 250
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NomEstado"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NomCiudad"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Ciudad"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NomPoblacion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Poblacion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Estatus"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Estatus"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'CatComp07Choferes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 605)
        Me.Controls.Add(Me.txtTipoSangre)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.DtpFechaVencimiento)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtCelular)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtNombreCorto)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtTipoLicencia)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cmbPoblacion)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cmbCiudad)
        Me.Controls.Add(Me.cmbEstado)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtColonia)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCalle)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblEstatus)
        Me.Controls.Add(Me.txtLicencia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtAmaterno)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtAPaterno)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtCodigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(574, 535)
        Me.Name = "CatComp07Choferes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choferes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvChoferes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtAmaterno As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtAPaterno As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DgvChoferes As System.Windows.Forms.DataGridView
    Friend WithEvents txtLicencia As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidoPaternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidoMaternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LicenciaManejoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    'Friend WithEvents ChoferC As ClasesNegocios.ChoferCollectionClass
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents Txtfiltro As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbCiudad As System.Windows.Forms.ComboBox
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtColonia As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbPoblacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTipoLicencia As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtNombreCorto As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtCelular As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents DtpFechaVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtTipoSangre As System.Windows.Forms.TextBox
    Friend WithEvents clmNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEstado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCiudad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPoblacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
