<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusquedaEmpleados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.ChkFechas = New System.Windows.Forms.CheckBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtAPaterno = New System.Windows.Forms.TextBox
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView
        Me.EmpleadosCollectionClass1 = New ClasesNegocio.EmpleadosCollectionClass
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbtnTodos = New System.Windows.Forms.RadioButton
        Me.rbtnInactivo = New System.Windows.Forms.RadioButton
        Me.rbtnActivo = New System.Windows.Forms.RadioButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TxtAMaterno = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.ChColeccion1 = New ClasesNegocio.ChColeccion
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ApellidoMaternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ApellidoPaternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RFCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CURPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TelefonosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CelularDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColoniaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescansoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PadreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MadreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ConyugeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SalarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmpoblacion = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DepartamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdPuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AplicaISRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstadoCivilDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IMSSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoPostalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SDIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FONACOTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SEXODataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DomicilioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdDepartamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TurnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpFechaFinal)
        Me.GroupBox1.Controls.Add(Me.dtpFechaInicial)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(443, 30)
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
        'ChkFechas
        '
        Me.ChkFechas.AutoSize = True
        Me.ChkFechas.Location = New System.Drawing.Point(443, 7)
        Me.ChkFechas.Name = "ChkFechas"
        Me.ChkFechas.Size = New System.Drawing.Size(102, 17)
        Me.ChkFechas.TabIndex = 25
        Me.ChkFechas.Text = "Filtrar por Fecha"
        Me.ChkFechas.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Apellido Paterno:"
        '
        'txtAPaterno
        '
        Me.txtAPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAPaterno.Location = New System.Drawing.Point(98, 58)
        Me.txtAPaterno.Name = "txtAPaterno"
        Me.txtAPaterno.Size = New System.Drawing.Size(299, 20)
        Me.txtAPaterno.TabIndex = 23
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Location = New System.Drawing.Point(539, 513)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 26)
        Me.btnAceptar.TabIndex = 18
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
        Me.BtnCancelar.TabIndex = 19
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.dgvEmpleados)
        Me.GroupBox3.Location = New System.Drawing.Point(51, 236)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(700, 266)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Empleados"
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.AllowUserToAddRows = False
        Me.dgvEmpleados.AllowUserToDeleteRows = False
        Me.dgvEmpleados.AllowUserToOrderColumns = True
        Me.dgvEmpleados.AllowUserToResizeRows = False
        Me.dgvEmpleados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvEmpleados.AutoGenerateColumns = False
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn, Me.NombresDataGridViewTextBoxColumn, Me.ApellidoMaternoDataGridViewTextBoxColumn, Me.ApellidoPaternoDataGridViewTextBoxColumn, Me.RFCDataGridViewTextBoxColumn, Me.CURPDataGridViewTextBoxColumn, Me.TelefonosDataGridViewTextBoxColumn, Me.CelularDataGridViewTextBoxColumn, Me.ColoniaDataGridViewTextBoxColumn, Me.DescansoDataGridViewTextBoxColumn, Me.PadreDataGridViewTextBoxColumn, Me.MadreDataGridViewTextBoxColumn, Me.ConyugeDataGridViewTextBoxColumn, Me.SalarioDataGridViewTextBoxColumn, Me.clmpoblacion, Me.DepartamentoDataGridViewTextBoxColumn, Me.IdPuestoDataGridViewTextBoxColumn, Me.AplicaISRDataGridViewTextBoxColumn, Me.EstadoCivilDataGridViewTextBoxColumn, Me.IMSSDataGridViewTextBoxColumn, Me.CodigoPostalDataGridViewTextBoxColumn, Me.SDIDataGridViewTextBoxColumn, Me.FONACOTDataGridViewTextBoxColumn, Me.SEXODataGridViewCheckBoxColumn, Me.DomicilioDataGridViewTextBoxColumn, Me.IdDepartamentoDataGridViewTextBoxColumn, Me.TurnoDataGridViewTextBoxColumn, Me.EstatusDataGridViewTextBoxColumn})
        Me.dgvEmpleados.DataSource = Me.EmpleadosCollectionClass1
        Me.dgvEmpleados.Location = New System.Drawing.Point(6, 19)
        Me.dgvEmpleados.MultiSelect = False
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.ReadOnly = True
        Me.dgvEmpleados.RowHeadersVisible = False
        Me.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmpleados.Size = New System.Drawing.Size(688, 239)
        Me.dgvEmpleados.TabIndex = 0
        '
        'EmpleadosCollectionClass1
        '
        Me.EmpleadosCollectionClass1.AllowEdit = True
        Me.EmpleadosCollectionClass1.AllowNew = True
        Me.EmpleadosCollectionClass1.AllowRemove = True
        Me.EmpleadosCollectionClass1.MaximoElementosSeleccionados = 1
        Me.EmpleadosCollectionClass1.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.EmpleadosCollectionClass1.mostrar = ClasesNegocio.MostrarEnum.CLIENTES
        Me.EmpleadosCollectionClass1.MostrarAlertas = False
        Me.EmpleadosCollectionClass1.Name = Nothing
        Me.EmpleadosCollectionClass1.RaiseListChangedEvents = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbtnTodos)
        Me.GroupBox2.Controls.Add(Me.rbtnInactivo)
        Me.GroupBox2.Controls.Add(Me.rbtnActivo)
        Me.GroupBox2.Location = New System.Drawing.Point(443, 116)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(228, 52)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estatus"
        '
        'rbtnTodos
        '
        Me.rbtnTodos.AutoSize = True
        Me.rbtnTodos.Checked = True
        Me.rbtnTodos.Location = New System.Drawing.Point(157, 19)
        Me.rbtnTodos.Name = "rbtnTodos"
        Me.rbtnTodos.Size = New System.Drawing.Size(63, 17)
        Me.rbtnTodos.TabIndex = 2
        Me.rbtnTodos.TabStop = True
        Me.rbtnTodos.Text = "TODOS"
        Me.rbtnTodos.UseVisualStyleBackColor = True
        '
        'rbtnInactivo
        '
        Me.rbtnInactivo.AutoSize = True
        Me.rbtnInactivo.Location = New System.Drawing.Point(76, 19)
        Me.rbtnInactivo.Name = "rbtnInactivo"
        Me.rbtnInactivo.Size = New System.Drawing.Size(75, 17)
        Me.rbtnInactivo.TabIndex = 1
        Me.rbtnInactivo.Text = "INACTIVO"
        Me.rbtnInactivo.UseVisualStyleBackColor = True
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TxtAMaterno)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.ChkFechas)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.txtAPaterno)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtCodigo)
        Me.Panel1.Location = New System.Drawing.Point(51, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(700, 189)
        Me.Panel1.TabIndex = 16
        '
        'TxtAMaterno
        '
        Me.TxtAMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAMaterno.Location = New System.Drawing.Point(98, 84)
        Me.TxtAMaterno.Name = "TxtAMaterno"
        Me.TxtAMaterno.Size = New System.Drawing.Size(299, 20)
        Me.TxtAMaterno.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 87)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Apellido Materno:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(98, 33)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(299, 20)
        Me.txtNombre.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(98, 7)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(84, 20)
        Me.txtCodigo.TabIndex = 8
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "Búsqueda de Empleados"
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
        Me.mtb.TabIndex = 14
        '
        'ChColeccion1
        '
        Me.ChColeccion1.AllowEdit = True
        Me.ChColeccion1.AllowNew = True
        Me.ChColeccion1.AllowRemove = True
        Me.ChColeccion1.MaximoElementosSeleccionados = 1
        Me.ChColeccion1.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.ChColeccion1.MostrarAlertas = False
        Me.ChColeccion1.Name = Nothing
        Me.ChColeccion1.RaiseListChangedEvents = True
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombresDataGridViewTextBoxColumn
        '
        Me.NombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres"
        Me.NombresDataGridViewTextBoxColumn.HeaderText = "Nombres"
        Me.NombresDataGridViewTextBoxColumn.Name = "NombresDataGridViewTextBoxColumn"
        Me.NombresDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApellidoMaternoDataGridViewTextBoxColumn
        '
        Me.ApellidoMaternoDataGridViewTextBoxColumn.DataPropertyName = "ApellidoMaterno"
        Me.ApellidoMaternoDataGridViewTextBoxColumn.HeaderText = "ApellidoMaterno"
        Me.ApellidoMaternoDataGridViewTextBoxColumn.Name = "ApellidoMaternoDataGridViewTextBoxColumn"
        Me.ApellidoMaternoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApellidoPaternoDataGridViewTextBoxColumn
        '
        Me.ApellidoPaternoDataGridViewTextBoxColumn.DataPropertyName = "ApellidoPaterno"
        Me.ApellidoPaternoDataGridViewTextBoxColumn.HeaderText = "ApellidoPaterno"
        Me.ApellidoPaternoDataGridViewTextBoxColumn.Name = "ApellidoPaternoDataGridViewTextBoxColumn"
        Me.ApellidoPaternoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RFCDataGridViewTextBoxColumn
        '
        Me.RFCDataGridViewTextBoxColumn.DataPropertyName = "RFC"
        Me.RFCDataGridViewTextBoxColumn.HeaderText = "RFC"
        Me.RFCDataGridViewTextBoxColumn.Name = "RFCDataGridViewTextBoxColumn"
        Me.RFCDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CURPDataGridViewTextBoxColumn
        '
        Me.CURPDataGridViewTextBoxColumn.DataPropertyName = "CURP"
        Me.CURPDataGridViewTextBoxColumn.HeaderText = "CURP"
        Me.CURPDataGridViewTextBoxColumn.Name = "CURPDataGridViewTextBoxColumn"
        Me.CURPDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelefonosDataGridViewTextBoxColumn
        '
        Me.TelefonosDataGridViewTextBoxColumn.DataPropertyName = "Telefonos"
        Me.TelefonosDataGridViewTextBoxColumn.HeaderText = "Telefonos"
        Me.TelefonosDataGridViewTextBoxColumn.Name = "TelefonosDataGridViewTextBoxColumn"
        Me.TelefonosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CelularDataGridViewTextBoxColumn
        '
        Me.CelularDataGridViewTextBoxColumn.DataPropertyName = "Celular"
        Me.CelularDataGridViewTextBoxColumn.HeaderText = "Celular"
        Me.CelularDataGridViewTextBoxColumn.Name = "CelularDataGridViewTextBoxColumn"
        Me.CelularDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ColoniaDataGridViewTextBoxColumn
        '
        Me.ColoniaDataGridViewTextBoxColumn.DataPropertyName = "Colonia"
        Me.ColoniaDataGridViewTextBoxColumn.HeaderText = "Colonia"
        Me.ColoniaDataGridViewTextBoxColumn.Name = "ColoniaDataGridViewTextBoxColumn"
        Me.ColoniaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescansoDataGridViewTextBoxColumn
        '
        Me.DescansoDataGridViewTextBoxColumn.DataPropertyName = "Descanso"
        Me.DescansoDataGridViewTextBoxColumn.HeaderText = "Descanso"
        Me.DescansoDataGridViewTextBoxColumn.Name = "DescansoDataGridViewTextBoxColumn"
        Me.DescansoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PadreDataGridViewTextBoxColumn
        '
        Me.PadreDataGridViewTextBoxColumn.DataPropertyName = "Padre"
        Me.PadreDataGridViewTextBoxColumn.HeaderText = "Padre"
        Me.PadreDataGridViewTextBoxColumn.Name = "PadreDataGridViewTextBoxColumn"
        Me.PadreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MadreDataGridViewTextBoxColumn
        '
        Me.MadreDataGridViewTextBoxColumn.DataPropertyName = "Madre"
        Me.MadreDataGridViewTextBoxColumn.HeaderText = "Madre"
        Me.MadreDataGridViewTextBoxColumn.Name = "MadreDataGridViewTextBoxColumn"
        Me.MadreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ConyugeDataGridViewTextBoxColumn
        '
        Me.ConyugeDataGridViewTextBoxColumn.DataPropertyName = "Conyuge"
        Me.ConyugeDataGridViewTextBoxColumn.HeaderText = "Conyuge"
        Me.ConyugeDataGridViewTextBoxColumn.Name = "ConyugeDataGridViewTextBoxColumn"
        Me.ConyugeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SalarioDataGridViewTextBoxColumn
        '
        Me.SalarioDataGridViewTextBoxColumn.DataPropertyName = "Salario"
        Me.SalarioDataGridViewTextBoxColumn.HeaderText = "Salario"
        Me.SalarioDataGridViewTextBoxColumn.Name = "SalarioDataGridViewTextBoxColumn"
        Me.SalarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'clmpoblacion
        '
        Me.clmpoblacion.DataPropertyName = "Nombres"
        Me.clmpoblacion.HeaderText = "Poblacion"
        Me.clmpoblacion.Name = "clmpoblacion"
        Me.clmpoblacion.ReadOnly = True
        '
        'DepartamentoDataGridViewTextBoxColumn
        '
        Me.DepartamentoDataGridViewTextBoxColumn.DataPropertyName = "Departamento"
        Me.DepartamentoDataGridViewTextBoxColumn.HeaderText = "Departamento"
        Me.DepartamentoDataGridViewTextBoxColumn.Name = "DepartamentoDataGridViewTextBoxColumn"
        Me.DepartamentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdPuestoDataGridViewTextBoxColumn
        '
        Me.IdPuestoDataGridViewTextBoxColumn.DataPropertyName = "IdPuesto"
        Me.IdPuestoDataGridViewTextBoxColumn.HeaderText = "IdPuesto"
        Me.IdPuestoDataGridViewTextBoxColumn.Name = "IdPuestoDataGridViewTextBoxColumn"
        Me.IdPuestoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AplicaISRDataGridViewTextBoxColumn
        '
        Me.AplicaISRDataGridViewTextBoxColumn.DataPropertyName = "AplicaISR"
        Me.AplicaISRDataGridViewTextBoxColumn.HeaderText = "AplicaISR"
        Me.AplicaISRDataGridViewTextBoxColumn.Name = "AplicaISRDataGridViewTextBoxColumn"
        Me.AplicaISRDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoCivilDataGridViewTextBoxColumn
        '
        Me.EstadoCivilDataGridViewTextBoxColumn.DataPropertyName = "EstadoCivil"
        Me.EstadoCivilDataGridViewTextBoxColumn.HeaderText = "EstadoCivil"
        Me.EstadoCivilDataGridViewTextBoxColumn.Name = "EstadoCivilDataGridViewTextBoxColumn"
        Me.EstadoCivilDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IMSSDataGridViewTextBoxColumn
        '
        Me.IMSSDataGridViewTextBoxColumn.DataPropertyName = "IMSS"
        Me.IMSSDataGridViewTextBoxColumn.HeaderText = "IMSS"
        Me.IMSSDataGridViewTextBoxColumn.Name = "IMSSDataGridViewTextBoxColumn"
        Me.IMSSDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodigoPostalDataGridViewTextBoxColumn
        '
        Me.CodigoPostalDataGridViewTextBoxColumn.DataPropertyName = "CodigoPostal"
        Me.CodigoPostalDataGridViewTextBoxColumn.HeaderText = "CodigoPostal"
        Me.CodigoPostalDataGridViewTextBoxColumn.Name = "CodigoPostalDataGridViewTextBoxColumn"
        Me.CodigoPostalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SDIDataGridViewTextBoxColumn
        '
        Me.SDIDataGridViewTextBoxColumn.DataPropertyName = "SDI"
        Me.SDIDataGridViewTextBoxColumn.HeaderText = "SDI"
        Me.SDIDataGridViewTextBoxColumn.Name = "SDIDataGridViewTextBoxColumn"
        Me.SDIDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FONACOTDataGridViewTextBoxColumn
        '
        Me.FONACOTDataGridViewTextBoxColumn.DataPropertyName = "FONACOT"
        Me.FONACOTDataGridViewTextBoxColumn.HeaderText = "FONACOT"
        Me.FONACOTDataGridViewTextBoxColumn.Name = "FONACOTDataGridViewTextBoxColumn"
        Me.FONACOTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SEXODataGridViewCheckBoxColumn
        '
        Me.SEXODataGridViewCheckBoxColumn.DataPropertyName = "SEXO"
        Me.SEXODataGridViewCheckBoxColumn.HeaderText = "SEXO"
        Me.SEXODataGridViewCheckBoxColumn.Name = "SEXODataGridViewCheckBoxColumn"
        Me.SEXODataGridViewCheckBoxColumn.ReadOnly = True
        '
        'DomicilioDataGridViewTextBoxColumn
        '
        Me.DomicilioDataGridViewTextBoxColumn.DataPropertyName = "Domicilio"
        Me.DomicilioDataGridViewTextBoxColumn.HeaderText = "Domicilio"
        Me.DomicilioDataGridViewTextBoxColumn.Name = "DomicilioDataGridViewTextBoxColumn"
        Me.DomicilioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdDepartamentoDataGridViewTextBoxColumn
        '
        Me.IdDepartamentoDataGridViewTextBoxColumn.DataPropertyName = "IdDepartamento"
        Me.IdDepartamentoDataGridViewTextBoxColumn.HeaderText = "IdDepartamento"
        Me.IdDepartamentoDataGridViewTextBoxColumn.Name = "IdDepartamentoDataGridViewTextBoxColumn"
        Me.IdDepartamentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TurnoDataGridViewTextBoxColumn
        '
        Me.TurnoDataGridViewTextBoxColumn.DataPropertyName = "Turno"
        Me.TurnoDataGridViewTextBoxColumn.HeaderText = "Turno"
        Me.TurnoDataGridViewTextBoxColumn.Name = "TurnoDataGridViewTextBoxColumn"
        Me.TurnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstatusDataGridViewTextBoxColumn
        '
        Me.EstatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.HeaderText = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.Name = "EstatusDataGridViewTextBoxColumn"
        Me.EstatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FrmBusquedaEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 551)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.Name = "FrmBusquedaEmpleados"
        Me.Text = "FrmBusquedaEmpleados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ChkFechas As System.Windows.Forms.CheckBox
    Friend WithEvents dgvEmpleados As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAPaterno As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnInactivo As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnActivo As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents TxtAMaterno As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ChColeccion1 As ClasesNegocio.ChColeccion
    Friend WithEvents EmpleadosCollectionClass1 As ClasesNegocio.EmpleadosCollectionClass
    Friend WithEvents IdPoblacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombresDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidoMaternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidoPaternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RFCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CURPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CelularDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColoniaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescansoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PadreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MadreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConyugeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SalarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmpoblacion As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DepartamentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdPuestoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AplicaISRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoCivilDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMSSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoPostalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SDIDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FONACOTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SEXODataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DomicilioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDepartamentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TurnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
