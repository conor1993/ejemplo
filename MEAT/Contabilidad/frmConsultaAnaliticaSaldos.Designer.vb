<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaAnaliticaSaldos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.mtb = New MEAToolBar.MEAToolBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSubCta = New IntegraLab.Controles.TextBoxMejorado()
        Me.txtCta = New IntegraLab.Controles.TextBoxMejorado()
        Me.txtSSSubCta = New IntegraLab.Controles.TextBoxMejorado()
        Me.txtSSubCta = New IntegraLab.Controles.TextBoxMejorado()
        Me.txtNombreCuenta = New IntegraLab.Controles.TextBoxMejorado()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSaldoAnterior = New IntegraLab.Controles.TextBoxMejorado()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSaldoActual = New IntegraLab.Controles.TextBoxMejorado()
        Me.txtAbonoMes = New IntegraLab.Controles.TextBoxMejorado()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCargoMes = New IntegraLab.Controles.TextBoxMejorado()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PolizaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxConcepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Operacion2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PolizaDetalleC = New ClasesNegocio.PolizaDetalleCollectionClass()
        Me.CuentaContableC = New ClasesNegocio.CuentaContableCollectionClass()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.lblTitulo.Size = New System.Drawing.Size(799, 29)
        Me.lblTitulo.TabIndex = 6
        Me.lblTitulo.Text = "CONSULTA ANALITICA DE SALDOS"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = False
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = False
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 562)
        Me.mtb.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Cuenta Contable:"
        '
        'txtSubCta
        '
        Me.txtSubCta.ComboBoxEnlazado = Nothing
        Me.txtSubCta.Decimales = 0
        Me.txtSubCta.Location = New System.Drawing.Point(199, 39)
        Me.txtSubCta.MaxLength = 3000
        Me.txtSubCta.MensajeCombo = "Seleccionar un item..."
        Me.txtSubCta.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtSubCta.Name = "txtSubCta"
        Me.txtSubCta.SiguienteControl = Nothing
        Me.txtSubCta.Size = New System.Drawing.Size(45, 20)
        Me.txtSubCta.TabIndex = 9
        Me.txtSubCta.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtSubCta.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtSubCta.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtCta
        '
        Me.txtCta.ComboBoxEnlazado = Nothing
        Me.txtCta.Decimales = 0
        Me.txtCta.Location = New System.Drawing.Point(151, 39)
        Me.txtCta.MaxLength = 3000
        Me.txtCta.MensajeCombo = "Seleccionar un item..."
        Me.txtCta.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtCta.Name = "txtCta"
        Me.txtCta.SiguienteControl = Nothing
        Me.txtCta.Size = New System.Drawing.Size(45, 20)
        Me.txtCta.TabIndex = 10
        Me.txtCta.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtCta.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCta.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtSSSubCta
        '
        Me.txtSSSubCta.ComboBoxEnlazado = Nothing
        Me.txtSSSubCta.Decimales = 0
        Me.txtSSSubCta.Location = New System.Drawing.Point(295, 39)
        Me.txtSSSubCta.MaxLength = 3000
        Me.txtSSSubCta.MensajeCombo = "Seleccionar un item..."
        Me.txtSSSubCta.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtSSSubCta.Name = "txtSSSubCta"
        Me.txtSSSubCta.SiguienteControl = Nothing
        Me.txtSSSubCta.Size = New System.Drawing.Size(45, 20)
        Me.txtSSSubCta.TabIndex = 11
        Me.txtSSSubCta.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtSSSubCta.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtSSSubCta.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtSSubCta
        '
        Me.txtSSubCta.ComboBoxEnlazado = Nothing
        Me.txtSSubCta.Decimales = 0
        Me.txtSSubCta.Location = New System.Drawing.Point(247, 39)
        Me.txtSSubCta.MaxLength = 3000
        Me.txtSSubCta.MensajeCombo = "Seleccionar un item..."
        Me.txtSSubCta.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtSSubCta.Name = "txtSSubCta"
        Me.txtSSubCta.SiguienteControl = Nothing
        Me.txtSSubCta.Size = New System.Drawing.Size(45, 20)
        Me.txtSSubCta.TabIndex = 12
        Me.txtSSubCta.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtSSubCta.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtSSubCta.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtNombreCuenta
        '
        Me.txtNombreCuenta.ComboBoxEnlazado = Nothing
        Me.txtNombreCuenta.Decimales = 0
        Me.txtNombreCuenta.Location = New System.Drawing.Point(346, 39)
        Me.txtNombreCuenta.MensajeCombo = "Seleccionar un item..."
        Me.txtNombreCuenta.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtNombreCuenta.Name = "txtNombreCuenta"
        Me.txtNombreCuenta.SiguienteControl = Nothing
        Me.txtNombreCuenta.Size = New System.Drawing.Size(350, 20)
        Me.txtNombreCuenta.TabIndex = 13
        Me.txtNombreCuenta.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtNombreCuenta.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtNombreCuenta.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "MM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(760, 39)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowUpDown = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(77, 20)
        Me.DateTimePicker1.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(703, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Mes/Año"
        '
        'txtSaldoAnterior
        '
        Me.txtSaldoAnterior.ComboBoxEnlazado = Nothing
        Me.txtSaldoAnterior.Decimales = 0
        Me.txtSaldoAnterior.Enabled = False
        Me.txtSaldoAnterior.Location = New System.Drawing.Point(151, 65)
        Me.txtSaldoAnterior.MaxLength = 3000
        Me.txtSaldoAnterior.MensajeCombo = "Seleccionar un item..."
        Me.txtSaldoAnterior.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtSaldoAnterior.Name = "txtSaldoAnterior"
        Me.txtSaldoAnterior.SiguienteControl = Nothing
        Me.txtSaldoAnterior.Size = New System.Drawing.Size(113, 20)
        Me.txtSaldoAnterior.TabIndex = 17
        Me.txtSaldoAnterior.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        Me.txtSaldoAnterior.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtSaldoAnterior.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Saldo Anterior:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Saldo Actual:"
        '
        'txtSaldoActual
        '
        Me.txtSaldoActual.ComboBoxEnlazado = Nothing
        Me.txtSaldoActual.Decimales = 0
        Me.txtSaldoActual.Enabled = False
        Me.txtSaldoActual.Location = New System.Drawing.Point(151, 91)
        Me.txtSaldoActual.MaxLength = 3000
        Me.txtSaldoActual.MensajeCombo = "Seleccionar un item..."
        Me.txtSaldoActual.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtSaldoActual.Name = "txtSaldoActual"
        Me.txtSaldoActual.SiguienteControl = Nothing
        Me.txtSaldoActual.Size = New System.Drawing.Size(113, 20)
        Me.txtSaldoActual.TabIndex = 19
        Me.txtSaldoActual.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        Me.txtSaldoActual.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtSaldoActual.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtAbonoMes
        '
        Me.txtAbonoMes.ComboBoxEnlazado = Nothing
        Me.txtAbonoMes.Decimales = 0
        Me.txtAbonoMes.Enabled = False
        Me.txtAbonoMes.Location = New System.Drawing.Point(724, 91)
        Me.txtAbonoMes.MaxLength = 3000
        Me.txtAbonoMes.MensajeCombo = "Seleccionar un item..."
        Me.txtAbonoMes.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtAbonoMes.Name = "txtAbonoMes"
        Me.txtAbonoMes.SiguienteControl = Nothing
        Me.txtAbonoMes.Size = New System.Drawing.Size(113, 20)
        Me.txtAbonoMes.TabIndex = 23
        Me.txtAbonoMes.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        Me.txtAbonoMes.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtAbonoMes.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(620, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Abonos del Mes:"
        '
        'txtCargoMes
        '
        Me.txtCargoMes.ComboBoxEnlazado = Nothing
        Me.txtCargoMes.Decimales = 0
        Me.txtCargoMes.Enabled = False
        Me.txtCargoMes.Location = New System.Drawing.Point(724, 65)
        Me.txtCargoMes.MaxLength = 3000
        Me.txtCargoMes.MensajeCombo = "Seleccionar un item..."
        Me.txtCargoMes.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtCargoMes.Name = "txtCargoMes"
        Me.txtCargoMes.SiguienteControl = Nothing
        Me.txtCargoMes.Size = New System.Drawing.Size(113, 20)
        Me.txtCargoMes.TabIndex = 21
        Me.txtCargoMes.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Moneda
        Me.txtCargoMes.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCargoMes.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(620, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Cargos del Mes:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxFecha, Me.PolizaDataGridViewTextBoxColumn, Me.DataGridViewTextBoxConcepto, Me.Operacion2DataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PolizaDetalleC
        Me.DataGridView1.Location = New System.Drawing.Point(56, 117)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(781, 433)
        Me.DataGridView1.TabIndex = 24
        '
        'DataGridViewTextBoxFecha
        '
        Me.DataGridViewTextBoxFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxFecha.DataPropertyName = "Fecha"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxFecha.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxFecha.HeaderText = "Fecha"
        Me.DataGridViewTextBoxFecha.Name = "DataGridViewTextBoxFecha"
        Me.DataGridViewTextBoxFecha.ReadOnly = True
        Me.DataGridViewTextBoxFecha.Width = 62
        '
        'PolizaDataGridViewTextBoxColumn
        '
        Me.PolizaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.PolizaDataGridViewTextBoxColumn.DataPropertyName = "Poliza"
        Me.PolizaDataGridViewTextBoxColumn.HeaderText = "Poliza"
        Me.PolizaDataGridViewTextBoxColumn.Name = "PolizaDataGridViewTextBoxColumn"
        Me.PolizaDataGridViewTextBoxColumn.ReadOnly = True
        Me.PolizaDataGridViewTextBoxColumn.Width = 60
        '
        'DataGridViewTextBoxConcepto
        '
        Me.DataGridViewTextBoxConcepto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxConcepto.DataPropertyName = "Concepto"
        Me.DataGridViewTextBoxConcepto.HeaderText = "Concepto"
        Me.DataGridViewTextBoxConcepto.Name = "DataGridViewTextBoxConcepto"
        Me.DataGridViewTextBoxConcepto.ReadOnly = True
        Me.DataGridViewTextBoxConcepto.Width = 78
        '
        'Operacion2DataGridViewTextBoxColumn
        '
        Me.Operacion2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Operacion2DataGridViewTextBoxColumn.DataPropertyName = "Operacion2"
        Me.Operacion2DataGridViewTextBoxColumn.HeaderText = "C/A"
        Me.Operacion2DataGridViewTextBoxColumn.Name = "Operacion2DataGridViewTextBoxColumn"
        Me.Operacion2DataGridViewTextBoxColumn.ReadOnly = True
        Me.Operacion2DataGridViewTextBoxColumn.Width = 51
        '
        'ImporteDataGridViewTextBoxColumn
        '
        Me.ImporteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "Importe"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.ImporteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
        Me.ImporteDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImporteDataGridViewTextBoxColumn.Width = 67
        '
        'PolizaDetalleC
        '
        Me.PolizaDetalleC.AllowEdit = True
        Me.PolizaDetalleC.AllowNew = True
        Me.PolizaDetalleC.AllowRemove = True
        Me.PolizaDetalleC.Name = Nothing
        Me.PolizaDetalleC.RaiseListChangedEvents = True
        '
        'CuentaContableC
        '
        Me.CuentaContableC.AllowEdit = True
        Me.CuentaContableC.AllowNew = True
        Me.CuentaContableC.AllowRemove = True
        Me.CuentaContableC.Name = Nothing
        Me.CuentaContableC.RaiseListChangedEvents = True
        '
        'frmConsultaAnaliticaSaldos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 562)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtAbonoMes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCargoMes)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSaldoActual)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSaldoAnterior)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtNombreCuenta)
        Me.Controls.Add(Me.txtSSubCta)
        Me.Controls.Add(Me.txtSSSubCta)
        Me.Controls.Add(Me.txtCta)
        Me.Controls.Add(Me.txtSubCta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.mtb)
        Me.MaximizeBox = False
        Me.Name = "frmConsultaAnaliticaSaldos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Analitica de Saldos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSubCta As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtCta As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtSSSubCta As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtSSubCta As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtNombreCuenta As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoAnterior As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoActual As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtAbonoMes As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCargoMes As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CuentaContableC As ClasesNegocio.CuentaContableCollectionClass
    Friend WithEvents PolizaDetalleC As ClasesNegocio.PolizaDetalleCollectionClass
    Friend WithEvents DataGridViewTextBoxFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PolizaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxConcepto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Operacion2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
