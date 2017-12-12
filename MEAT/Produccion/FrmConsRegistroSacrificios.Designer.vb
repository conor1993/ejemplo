<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteRegistroSacrificios
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DgvSacrificios = New System.Windows.Forms.DataGridView
        Me.LoteSacrificio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmLoteRastro = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaSacrificio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantCabezasSacrificio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KilosSacrificio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Canales = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmKilosEnPie = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPesoPromCanal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.grpFecha = New System.Windows.Forms.GroupBox
        Me.DtpFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.DtpFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.BtnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.chkFiltrar = New System.Windows.Forms.CheckBox
        Me.grpEstatus = New System.Windows.Forms.GroupBox
        Me.rbtTodos = New System.Windows.Forms.RadioButton
        Me.rbtInactivos = New System.Windows.Forms.RadioButton
        Me.rbtActivos = New System.Windows.Forms.RadioButton
        Me.txtCodigoIntroductor = New IntegraLab.Controles.TextBoxMejorado
        Me.CmbIntroductor = New IntegraLab.Controles.ComboBoxMejorado
        Me.chkPorCabezas = New System.Windows.Forms.CheckBox
        Me.txtLoteSacrificio = New IntegraLab.Controles.TextBoxMejorado
        Me.grpCabezas = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtNumeroCabezasA = New IntegraLab.Controles.TextBoxMejorado
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtNumeroCabezasDe = New IntegraLab.Controles.TextBoxMejorado
        Me.rbtCerrados = New System.Windows.Forms.RadioButton
        CType(Me.DgvSacrificios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFecha.SuspendLayout()
        Me.grpEstatus.SuspendLayout()
        Me.grpCabezas.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvSacrificios
        '
        Me.DgvSacrificios.AllowUserToAddRows = False
        Me.DgvSacrificios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvSacrificios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSacrificios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LoteSacrificio, Me.clmLoteRastro, Me.FechaSacrificio, Me.Nombre, Me.CantCabezasSacrificio, Me.KilosSacrificio, Me.Canales, Me.clmKilosEnPie, Me.clmPesoPromCanal})
        Me.DgvSacrificios.Location = New System.Drawing.Point(56, 171)
        Me.DgvSacrificios.Name = "DgvSacrificios"
        Me.DgvSacrificios.ReadOnly = True
        Me.DgvSacrificios.RowHeadersVisible = False
        Me.DgvSacrificios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvSacrificios.Size = New System.Drawing.Size(894, 398)
        Me.DgvSacrificios.TabIndex = 12
        '
        'LoteSacrificio
        '
        Me.LoteSacrificio.DataPropertyName = "FolioSacrificio"
        Me.LoteSacrificio.HeaderText = "Lote Sacrificio"
        Me.LoteSacrificio.Name = "LoteSacrificio"
        Me.LoteSacrificio.ReadOnly = True
        '
        'clmLoteRastro
        '
        Me.clmLoteRastro.DataPropertyName = "LoteRastro"
        Me.clmLoteRastro.HeaderText = "Lote Rastro"
        Me.clmLoteRastro.Name = "clmLoteRastro"
        Me.clmLoteRastro.ReadOnly = True
        '
        'FechaSacrificio
        '
        Me.FechaSacrificio.DataPropertyName = "FechaSacrificio"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.FechaSacrificio.DefaultCellStyle = DataGridViewCellStyle1
        Me.FechaSacrificio.HeaderText = "Fecha Sacrificio"
        Me.FechaSacrificio.Name = "FechaSacrificio"
        Me.FechaSacrificio.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Cliente"
        Me.Nombre.HeaderText = "Introductor"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 200
        '
        'CantCabezasSacrificio
        '
        Me.CantCabezasSacrificio.DataPropertyName = "CantCabSacrificio"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.CantCabezasSacrificio.DefaultCellStyle = DataGridViewCellStyle2
        Me.CantCabezasSacrificio.HeaderText = "Cant. Cabezas"
        Me.CantCabezasSacrificio.Name = "CantCabezasSacrificio"
        Me.CantCabezasSacrificio.ReadOnly = True
        Me.CantCabezasSacrificio.Width = 70
        '
        'KilosSacrificio
        '
        Me.KilosSacrificio.DataPropertyName = "KilosSacrificio"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.KilosSacrificio.DefaultCellStyle = DataGridViewCellStyle3
        Me.KilosSacrificio.HeaderText = "Kilos Sacrificio"
        Me.KilosSacrificio.Name = "KilosSacrificio"
        Me.KilosSacrificio.ReadOnly = True
        Me.KilosSacrificio.Visible = False
        Me.KilosSacrificio.Width = 70
        '
        'Canales
        '
        Me.Canales.DataPropertyName = "CantCanales"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Canales.DefaultCellStyle = DataGridViewCellStyle4
        Me.Canales.HeaderText = "Canales"
        Me.Canales.Name = "Canales"
        Me.Canales.ReadOnly = True
        '
        'clmKilosEnPie
        '
        Me.clmKilosEnPie.DataPropertyName = "KgsEnPie"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.clmKilosEnPie.DefaultCellStyle = DataGridViewCellStyle5
        Me.clmKilosEnPie.HeaderText = "Kgs. En Pie"
        Me.clmKilosEnPie.Name = "clmKilosEnPie"
        Me.clmKilosEnPie.ReadOnly = True
        '
        'clmPesoPromCanal
        '
        Me.clmPesoPromCanal.DataPropertyName = "KgsCanal"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.clmPesoPromCanal.DefaultCellStyle = DataGridViewCellStyle6
        Me.clmPesoPromCanal.HeaderText = "Kgs. Promedio Por Canal"
        Me.clmPesoPromCanal.Name = "clmPesoPromCanal"
        Me.clmPesoPromCanal.ReadOnly = True
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(912, 32)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Consulta de Registro de Sacrificios"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Lote de Sacrificio : "
        '
        'grpFecha
        '
        Me.grpFecha.Controls.Add(Me.DtpFechaFinal)
        Me.grpFecha.Controls.Add(Me.DtpFechaInicio)
        Me.grpFecha.Controls.Add(Me.Label3)
        Me.grpFecha.Controls.Add(Me.Label2)
        Me.grpFecha.Enabled = False
        Me.grpFecha.Location = New System.Drawing.Point(590, 88)
        Me.grpFecha.Name = "grpFecha"
        Me.grpFecha.Size = New System.Drawing.Size(192, 77)
        Me.grpFecha.TabIndex = 11
        Me.grpFecha.TabStop = False
        Me.grpFecha.Text = "Rango de Fechas"
        '
        'DtpFechaFinal
        '
        Me.DtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaFinal.Location = New System.Drawing.Point(80, 47)
        Me.DtpFechaFinal.Name = "DtpFechaFinal"
        Me.DtpFechaFinal.Size = New System.Drawing.Size(104, 20)
        Me.DtpFechaFinal.TabIndex = 3
        '
        'DtpFechaInicio
        '
        Me.DtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaInicio.Location = New System.Drawing.Point(80, 21)
        Me.DtpFechaInicio.Name = "DtpFechaInicio"
        Me.DtpFechaInicio.Size = New System.Drawing.Size(104, 20)
        Me.DtpFechaInicio.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha Final :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fecha Inicio :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Introductor :"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAceptar.Location = New System.Drawing.Point(794, 575)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 13
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(875, 575)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
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
        Me.mtb.Size = New System.Drawing.Size(50, 610)
        Me.mtb.TabIndex = 0
        '
        'chkFiltrar
        '
        Me.chkFiltrar.AutoSize = True
        Me.chkFiltrar.Location = New System.Drawing.Point(590, 65)
        Me.chkFiltrar.Name = "chkFiltrar"
        Me.chkFiltrar.Size = New System.Drawing.Size(115, 17)
        Me.chkFiltrar.TabIndex = 10
        Me.chkFiltrar.Text = "¿Filtrar Por Fecha?"
        Me.chkFiltrar.UseVisualStyleBackColor = True
        '
        'grpEstatus
        '
        Me.grpEstatus.Controls.Add(Me.rbtCerrados)
        Me.grpEstatus.Controls.Add(Me.rbtTodos)
        Me.grpEstatus.Controls.Add(Me.rbtInactivos)
        Me.grpEstatus.Controls.Add(Me.rbtActivos)
        Me.grpEstatus.Location = New System.Drawing.Point(237, 118)
        Me.grpEstatus.Name = "grpEstatus"
        Me.grpEstatus.Size = New System.Drawing.Size(347, 47)
        Me.grpEstatus.TabIndex = 9
        Me.grpEstatus.TabStop = False
        Me.grpEstatus.Text = "Estatus"
        '
        'rbtTodos
        '
        Me.rbtTodos.AutoSize = True
        Me.rbtTodos.Location = New System.Drawing.Point(278, 20)
        Me.rbtTodos.Name = "rbtTodos"
        Me.rbtTodos.Size = New System.Drawing.Size(63, 17)
        Me.rbtTodos.TabIndex = 2
        Me.rbtTodos.Text = "TODOS"
        Me.rbtTodos.UseVisualStyleBackColor = True
        '
        'rbtInactivos
        '
        Me.rbtInactivos.AutoSize = True
        Me.rbtInactivos.Location = New System.Drawing.Point(175, 20)
        Me.rbtInactivos.Name = "rbtInactivos"
        Me.rbtInactivos.Size = New System.Drawing.Size(97, 17)
        Me.rbtInactivos.TabIndex = 1
        Me.rbtInactivos.Text = "CANCELADOS"
        Me.rbtInactivos.UseVisualStyleBackColor = True
        '
        'rbtActivos
        '
        Me.rbtActivos.AutoSize = True
        Me.rbtActivos.Checked = True
        Me.rbtActivos.Location = New System.Drawing.Point(6, 20)
        Me.rbtActivos.Name = "rbtActivos"
        Me.rbtActivos.Size = New System.Drawing.Size(79, 17)
        Me.rbtActivos.TabIndex = 0
        Me.rbtActivos.TabStop = True
        Me.rbtActivos.Text = "VIGENTES"
        Me.rbtActivos.UseVisualStyleBackColor = True
        '
        'txtCodigoIntroductor
        '
        Me.txtCodigoIntroductor.ComboBoxEnlazado = Me.CmbIntroductor
        Me.txtCodigoIntroductor.Decimales = 0
        Me.txtCodigoIntroductor.Location = New System.Drawing.Point(160, 69)
        Me.txtCodigoIntroductor.MaxLength = 3000
        Me.txtCodigoIntroductor.MensajeCombo = "Seleccionar un introductor..."
        Me.txtCodigoIntroductor.MensajeNoExiste = "No existe un introductor con este código o se encuentra inactivo"
        Me.txtCodigoIntroductor.Name = "txtCodigoIntroductor"
        Me.txtCodigoIntroductor.SiguienteControl = Me.chkPorCabezas
        Me.txtCodigoIntroductor.Size = New System.Drawing.Size(62, 20)
        Me.txtCodigoIntroductor.TabIndex = 5
        Me.txtCodigoIntroductor.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtCodigoIntroductor.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCodigoIntroductor.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'CmbIntroductor
        '
        Me.CmbIntroductor.FormattingEnabled = True
        Me.CmbIntroductor.Location = New System.Drawing.Point(228, 69)
        Me.CmbIntroductor.Name = "CmbIntroductor"
        Me.CmbIntroductor.NombreMetodo = Nothing
        Me.CmbIntroductor.Parametros = Nothing
        Me.CmbIntroductor.SiguienteControl = Me.chkPorCabezas
        Me.CmbIntroductor.Size = New System.Drawing.Size(356, 21)
        Me.CmbIntroductor.TabIndex = 6
        Me.CmbIntroductor.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.CmbIntroductor.TextBoxEnlazado = Me.txtCodigoIntroductor
        '
        'chkPorCabezas
        '
        Me.chkPorCabezas.AutoSize = True
        Me.chkPorCabezas.Location = New System.Drawing.Point(59, 95)
        Me.chkPorCabezas.Name = "chkPorCabezas"
        Me.chkPorCabezas.Size = New System.Drawing.Size(176, 17)
        Me.chkPorCabezas.TabIndex = 7
        Me.chkPorCabezas.Text = "¿Filtrar Por Rango de Cabezas?"
        Me.chkPorCabezas.UseVisualStyleBackColor = True
        '
        'txtLoteSacrificio
        '
        Me.txtLoteSacrificio.ComboBoxEnlazado = Nothing
        Me.txtLoteSacrificio.Decimales = 0
        Me.txtLoteSacrificio.Location = New System.Drawing.Point(160, 43)
        Me.txtLoteSacrificio.MaxLength = 11
        Me.txtLoteSacrificio.MensajeCombo = "Seleccionar un item..."
        Me.txtLoteSacrificio.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtLoteSacrificio.Name = "txtLoteSacrificio"
        Me.txtLoteSacrificio.SiguienteControl = Me.txtCodigoIntroductor
        Me.txtLoteSacrificio.Size = New System.Drawing.Size(100, 20)
        Me.txtLoteSacrificio.TabIndex = 3
        Me.txtLoteSacrificio.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtLoteSacrificio.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtLoteSacrificio.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'grpCabezas
        '
        Me.grpCabezas.Controls.Add(Me.Label6)
        Me.grpCabezas.Controls.Add(Me.txtNumeroCabezasA)
        Me.grpCabezas.Controls.Add(Me.Label5)
        Me.grpCabezas.Controls.Add(Me.txtNumeroCabezasDe)
        Me.grpCabezas.Enabled = False
        Me.grpCabezas.Location = New System.Drawing.Point(56, 118)
        Me.grpCabezas.Name = "grpCabezas"
        Me.grpCabezas.Size = New System.Drawing.Size(175, 47)
        Me.grpCabezas.TabIndex = 8
        Me.grpCabezas.TabStop = False
        Me.grpCabezas.Text = "Rango de Cabezas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(89, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "A:"
        '
        'txtNumeroCabezasA
        '
        Me.txtNumeroCabezasA.ComboBoxEnlazado = Nothing
        Me.txtNumeroCabezasA.Decimales = 0
        Me.txtNumeroCabezasA.Location = New System.Drawing.Point(112, 18)
        Me.txtNumeroCabezasA.MaxLength = 3000
        Me.txtNumeroCabezasA.MensajeCombo = "Seleccionar un item..."
        Me.txtNumeroCabezasA.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtNumeroCabezasA.Name = "txtNumeroCabezasA"
        Me.txtNumeroCabezasA.SiguienteControl = Nothing
        Me.txtNumeroCabezasA.Size = New System.Drawing.Size(47, 20)
        Me.txtNumeroCabezasA.TabIndex = 3
        Me.txtNumeroCabezasA.Text = "0"
        Me.txtNumeroCabezasA.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtNumeroCabezasA.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtNumeroCabezasA.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "De:"
        '
        'txtNumeroCabezasDe
        '
        Me.txtNumeroCabezasDe.ComboBoxEnlazado = Nothing
        Me.txtNumeroCabezasDe.Decimales = 0
        Me.txtNumeroCabezasDe.Location = New System.Drawing.Point(36, 18)
        Me.txtNumeroCabezasDe.MaxLength = 3000
        Me.txtNumeroCabezasDe.MensajeCombo = "Seleccionar un item..."
        Me.txtNumeroCabezasDe.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtNumeroCabezasDe.Name = "txtNumeroCabezasDe"
        Me.txtNumeroCabezasDe.SiguienteControl = Nothing
        Me.txtNumeroCabezasDe.Size = New System.Drawing.Size(47, 20)
        Me.txtNumeroCabezasDe.TabIndex = 1
        Me.txtNumeroCabezasDe.Text = "0"
        Me.txtNumeroCabezasDe.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtNumeroCabezasDe.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtNumeroCabezasDe.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'rbtCerrados
        '
        Me.rbtCerrados.AutoSize = True
        Me.rbtCerrados.Location = New System.Drawing.Point(84, 20)
        Me.rbtCerrados.Name = "rbtCerrados"
        Me.rbtCerrados.Size = New System.Drawing.Size(85, 17)
        Me.rbtCerrados.TabIndex = 3
        Me.rbtCerrados.Text = "CERRADOS"
        Me.rbtCerrados.UseVisualStyleBackColor = True
        '
        'ReporteRegistroSacrificios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(962, 610)
        Me.Controls.Add(Me.chkPorCabezas)
        Me.Controls.Add(Me.grpCabezas)
        Me.Controls.Add(Me.txtLoteSacrificio)
        Me.Controls.Add(Me.CmbIntroductor)
        Me.Controls.Add(Me.txtCodigoIntroductor)
        Me.Controls.Add(Me.grpEstatus)
        Me.Controls.Add(Me.chkFiltrar)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.grpFecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgvSacrificios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ReporteRegistroSacrificios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Registro de Sacrificios"
        CType(Me.DgvSacrificios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFecha.ResumeLayout(False)
        Me.grpFecha.PerformLayout()
        Me.grpEstatus.ResumeLayout(False)
        Me.grpEstatus.PerformLayout()
        Me.grpCabezas.ResumeLayout(False)
        Me.grpCabezas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpFecha As System.Windows.Forms.GroupBox
    Friend WithEvents DtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents chkFiltrar As System.Windows.Forms.CheckBox
    Friend WithEvents grpEstatus As System.Windows.Forms.GroupBox
    Friend WithEvents rbtTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbtInactivos As System.Windows.Forms.RadioButton
    Friend WithEvents rbtActivos As System.Windows.Forms.RadioButton
    Friend WithEvents txtCodigoIntroductor As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents CmbIntroductor As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents txtLoteSacrificio As Integralab.Controles.TextBoxMejorado
    Friend WithEvents grpCabezas As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroCabezasA As Integralab.Controles.TextBoxMejorado
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroCabezasDe As Integralab.Controles.TextBoxMejorado
    Friend WithEvents chkPorCabezas As System.Windows.Forms.CheckBox
    Private WithEvents DgvSacrificios As System.Windows.Forms.DataGridView
    Friend WithEvents LoteSacrificio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmLoteRastro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaSacrificio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantCabezasSacrificio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosSacrificio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Canales As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmKilosEnPie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPesoPromCanal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rbtCerrados As System.Windows.Forms.RadioButton
End Class
