<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaNotas
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
        Me.mtb = New MEAToolBar.MEAToolBar()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rbtTodas = New System.Windows.Forms.RadioButton()
        Me.RbtnPersonaMoral = New System.Windows.Forms.RadioButton()
        Me.RbtnPersonaFisica = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbtnTodos = New System.Windows.Forms.RadioButton()
        Me.rbtnCancelado = New System.Windows.Forms.RadioButton()
        Me.rbtnActivo = New System.Windows.Forms.RadioButton()
        Me.ChkFechas = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbPoblacion = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbCiudad = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.clmCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmlRazonSocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmRFC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTipoPersona = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmIdEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCiudad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPoblacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDomicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmColonia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFechaAlta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmIntroductor = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.clmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.mtb.Size = New System.Drawing.Size(50, 551)
        Me.mtb.TabIndex = 6
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(708, 29)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "Búsqueda de Clientes"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(86, 8)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(63, 20)
        Me.txtCodigo.TabIndex = 8
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Código:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.ChkFechas)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.txtRazonSocial)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cmbPoblacion)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cmbCiudad)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cmbEstado)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtCodigo)
        Me.Panel1.Location = New System.Drawing.Point(51, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(700, 229)
        Me.Panel1.TabIndex = 10
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbtTodas)
        Me.GroupBox4.Controls.Add(Me.RbtnPersonaMoral)
        Me.GroupBox4.Controls.Add(Me.RbtnPersonaFisica)
        Me.GroupBox4.Location = New System.Drawing.Point(86, 165)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(320, 49)
        Me.GroupBox4.TabIndex = 27
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tipo de Persona"
        '
        'rbtTodas
        '
        Me.rbtTodas.AutoSize = True
        Me.rbtTodas.Checked = True
        Me.rbtTodas.Location = New System.Drawing.Point(244, 19)
        Me.rbtTodas.Name = "rbtTodas"
        Me.rbtTodas.Size = New System.Drawing.Size(55, 17)
        Me.rbtTodas.TabIndex = 16
        Me.rbtTodas.TabStop = True
        Me.rbtTodas.Text = "Todas"
        Me.rbtTodas.UseVisualStyleBackColor = True
        '
        'RbtnPersonaMoral
        '
        Me.RbtnPersonaMoral.AutoSize = True
        Me.RbtnPersonaMoral.Location = New System.Drawing.Point(132, 19)
        Me.RbtnPersonaMoral.Name = "RbtnPersonaMoral"
        Me.RbtnPersonaMoral.Size = New System.Drawing.Size(93, 17)
        Me.RbtnPersonaMoral.TabIndex = 15
        Me.RbtnPersonaMoral.Text = "Persona Moral"
        Me.RbtnPersonaMoral.UseVisualStyleBackColor = True
        '
        'RbtnPersonaFisica
        '
        Me.RbtnPersonaFisica.AutoSize = True
        Me.RbtnPersonaFisica.Location = New System.Drawing.Point(22, 19)
        Me.RbtnPersonaFisica.Name = "RbtnPersonaFisica"
        Me.RbtnPersonaFisica.Size = New System.Drawing.Size(94, 17)
        Me.RbtnPersonaFisica.TabIndex = 14
        Me.RbtnPersonaFisica.Text = "Persona Fisica"
        Me.RbtnPersonaFisica.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbtnTodos)
        Me.GroupBox2.Controls.Add(Me.rbtnCancelado)
        Me.GroupBox2.Controls.Add(Me.rbtnActivo)
        Me.GroupBox2.Location = New System.Drawing.Point(412, 116)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(270, 52)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estatus"
        '
        'rbtnTodos
        '
        Me.rbtnTodos.AutoSize = True
        Me.rbtnTodos.Checked = True
        Me.rbtnTodos.Location = New System.Drawing.Point(199, 19)
        Me.rbtnTodos.Name = "rbtnTodos"
        Me.rbtnTodos.Size = New System.Drawing.Size(63, 17)
        Me.rbtnTodos.TabIndex = 2
        Me.rbtnTodos.TabStop = True
        Me.rbtnTodos.Text = "TODOS"
        Me.rbtnTodos.UseVisualStyleBackColor = True
        '
        'rbtnCancelado
        '
        Me.rbtnCancelado.AutoSize = True
        Me.rbtnCancelado.Location = New System.Drawing.Point(92, 19)
        Me.rbtnCancelado.Name = "rbtnCancelado"
        Me.rbtnCancelado.Size = New System.Drawing.Size(90, 17)
        Me.rbtnCancelado.TabIndex = 1
        Me.rbtnCancelado.Text = "CANCELADO"
        Me.rbtnCancelado.UseVisualStyleBackColor = True
        '
        'rbtnActivo
        '
        Me.rbtnActivo.AutoSize = True
        Me.rbtnActivo.Location = New System.Drawing.Point(6, 19)
        Me.rbtnActivo.Name = "rbtnActivo"
        Me.rbtnActivo.Size = New System.Drawing.Size(64, 17)
        Me.rbtnActivo.TabIndex = 0
        Me.rbtnActivo.Text = "ACTIVO"
        Me.rbtnActivo.UseVisualStyleBackColor = True
        '
        'ChkFechas
        '
        Me.ChkFechas.AutoSize = True
        Me.ChkFechas.Location = New System.Drawing.Point(412, 7)
        Me.ChkFechas.Name = "ChkFechas"
        Me.ChkFechas.Size = New System.Drawing.Size(102, 17)
        Me.ChkFechas.TabIndex = 25
        Me.ChkFechas.Text = "Filtrar por Fecha"
        Me.ChkFechas.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpFechaFinal)
        Me.GroupBox1.Controls.Add(Me.dtpFechaInicial)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(412, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 74)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fechas"
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Enabled = False
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(92, 50)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(128, 20)
        Me.dtpFechaFinal.TabIndex = 3
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Enabled = False
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicial.Location = New System.Drawing.Point(92, 24)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(128, 20)
        Me.dtpFechaInicial.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Fecha Final:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Fecha Inicial:"
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRazonSocial.Location = New System.Drawing.Point(86, 59)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(299, 20)
        Me.txtRazonSocial.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Razón Social:"
        '
        'cmbPoblacion
        '
        Me.cmbPoblacion.FormattingEnabled = True
        Me.cmbPoblacion.Location = New System.Drawing.Point(86, 138)
        Me.cmbPoblacion.Name = "cmbPoblacion"
        Me.cmbPoblacion.Size = New System.Drawing.Size(229, 21)
        Me.cmbPoblacion.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Población:"
        '
        'cmbCiudad
        '
        Me.cmbCiudad.FormattingEnabled = True
        Me.cmbCiudad.Location = New System.Drawing.Point(86, 111)
        Me.cmbCiudad.Name = "cmbCiudad"
        Me.cmbCiudad.Size = New System.Drawing.Size(229, 21)
        Me.cmbCiudad.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Ciudad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Estado:"
        '
        'cmbEstado
        '
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(86, 84)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(229, 21)
        Me.cmbEstado.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(86, 34)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(299, 20)
        Me.txtNombre.TabIndex = 10
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.dgvClientes)
        Me.GroupBox3.Location = New System.Drawing.Point(51, 267)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(700, 235)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Clientes:"
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.AllowUserToOrderColumns = True
        Me.dgvClientes.AllowUserToResizeRows = False
        Me.dgvClientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmCodigo, Me.clmNombre, Me.clmlRazonSocial, Me.clmRFC, Me.clmTipoPersona, Me.clmIdEstado, Me.clmCiudad, Me.clmPoblacion, Me.clmDomicilio, Me.clmColonia, Me.clmFechaAlta, Me.clmIntroductor, Me.clmEstatus})
        Me.dgvClientes.Location = New System.Drawing.Point(6, 19)
        Me.dgvClientes.MultiSelect = False
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.RowHeadersVisible = False
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClientes.Size = New System.Drawing.Size(688, 208)
        Me.dgvClientes.TabIndex = 0
        '
        'clmCodigo
        '
        Me.clmCodigo.DataPropertyName = "idCliente"
        Me.clmCodigo.HeaderText = "Código"
        Me.clmCodigo.Name = "clmCodigo"
        Me.clmCodigo.ReadOnly = True
        Me.clmCodigo.Width = 50
        '
        'clmNombre
        '
        Me.clmNombre.DataPropertyName = "Nombre"
        Me.clmNombre.HeaderText = "Nombre"
        Me.clmNombre.Name = "clmNombre"
        Me.clmNombre.ReadOnly = True
        '
        'clmlRazonSocial
        '
        Me.clmlRazonSocial.DataPropertyName = "RazonSocial"
        Me.clmlRazonSocial.HeaderText = "Razon Social"
        Me.clmlRazonSocial.Name = "clmlRazonSocial"
        Me.clmlRazonSocial.ReadOnly = True
        '
        'clmRFC
        '
        Me.clmRFC.DataPropertyName = "RFC"
        Me.clmRFC.HeaderText = "RFC"
        Me.clmRFC.Name = "clmRFC"
        Me.clmRFC.ReadOnly = True
        '
        'clmTipoPersona
        '
        Me.clmTipoPersona.DataPropertyName = "TipoPersonaCad"
        Me.clmTipoPersona.HeaderText = "Tipo Persona"
        Me.clmTipoPersona.Name = "clmTipoPersona"
        Me.clmTipoPersona.ReadOnly = True
        '
        'clmIdEstado
        '
        Me.clmIdEstado.DataPropertyName = "Estado"
        Me.clmIdEstado.HeaderText = "Estado"
        Me.clmIdEstado.Name = "clmIdEstado"
        Me.clmIdEstado.ReadOnly = True
        '
        'clmCiudad
        '
        Me.clmCiudad.DataPropertyName = "Ciudad"
        Me.clmCiudad.HeaderText = "Ciudad"
        Me.clmCiudad.Name = "clmCiudad"
        Me.clmCiudad.ReadOnly = True
        '
        'clmPoblacion
        '
        Me.clmPoblacion.DataPropertyName = "Poblacion"
        Me.clmPoblacion.HeaderText = "Poblacion"
        Me.clmPoblacion.Name = "clmPoblacion"
        Me.clmPoblacion.ReadOnly = True
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
        'clmFechaAlta
        '
        Me.clmFechaAlta.DataPropertyName = "FechaAlta"
        Me.clmFechaAlta.HeaderText = "Fecha Alta"
        Me.clmFechaAlta.Name = "clmFechaAlta"
        Me.clmFechaAlta.ReadOnly = True
        '
        'clmIntroductor
        '
        Me.clmIntroductor.DataPropertyName = "Introductor"
        Me.clmIntroductor.HeaderText = "Introductor"
        Me.clmIntroductor.Name = "clmIntroductor"
        Me.clmIntroductor.ReadOnly = True
        '
        'clmEstatus
        '
        Me.clmEstatus.DataPropertyName = "EstatusCad"
        Me.clmEstatus.HeaderText = "Estatus"
        Me.clmEstatus.Name = "clmEstatus"
        Me.clmEstatus.ReadOnly = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Location = New System.Drawing.Point(539, 513)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 26)
        Me.btnAceptar.TabIndex = 12
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancelar.Location = New System.Drawing.Point(650, 513)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 26)
        Me.BtnCancelar.TabIndex = 13
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'frmBusquedaNotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 551)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.Name = "frmBusquedaNotas"
        Me.Text = "Búsqueda de Clientes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbCiudad As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents RbtnPersonaMoral As System.Windows.Forms.RadioButton
    Friend WithEvents RbtnPersonaFisica As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbPoblacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ChkFechas As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnActivo As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnCancelado As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvClientes As System.Windows.Forms.DataGridView
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtTodas As System.Windows.Forms.RadioButton
    Friend WithEvents clmCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmlRazonSocial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmRFC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTipoPersona As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdEstado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCiudad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPoblacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDomicilio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmColonia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaAlta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIntroductor As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents clmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
