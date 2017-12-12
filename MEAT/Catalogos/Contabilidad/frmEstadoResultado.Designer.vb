<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstadoResultado
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
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.CuentaMayorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubCuentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SSubCuentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SSSubCuentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CuentaContableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SumaORestaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaldoAumuladoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstadoResultadoDetalleC = New ClasesNegocio.EstadoResultadoDetalleCollectionClas
        Me.txtDescripcion = New Integralab.Controles.TextBoxMejorado
        Me.txtRubro = New Integralab.Controles.TextBoxMejorado
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbCategoria = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
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
        Me.lblTitulo.Size = New System.Drawing.Size(913, 29)
        Me.lblTitulo.TabIndex = 3
        Me.lblTitulo.Text = "ESTADOS FINANCIEROS      ESTADO DE RESULTADO"
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
        Me.mtb.MostrarBuscar = True
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = True
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 578)
        Me.mtb.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Rubro:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Descripción:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(898, 449)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CuentaMayorDataGridViewTextBoxColumn, Me.SubCuentaDataGridViewTextBoxColumn, Me.SSubCuentaDataGridViewTextBoxColumn, Me.SSSubCuentaDataGridViewTextBoxColumn, Me.CuentaContableDataGridViewTextBoxColumn, Me.SumaORestaDataGridViewTextBoxColumn, Me.SaldoAumuladoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EstadoResultadoDetalleC
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(886, 424)
        Me.DataGridView1.TabIndex = 0
        '
        'CuentaMayorDataGridViewTextBoxColumn
        '
        Me.CuentaMayorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CuentaMayorDataGridViewTextBoxColumn.DataPropertyName = "CuentaMayor"
        Me.CuentaMayorDataGridViewTextBoxColumn.HeaderText = "Cuenta Mayor"
        Me.CuentaMayorDataGridViewTextBoxColumn.Name = "CuentaMayorDataGridViewTextBoxColumn"
        Me.CuentaMayorDataGridViewTextBoxColumn.Width = 88
        '
        'SubCuentaDataGridViewTextBoxColumn
        '
        Me.SubCuentaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SubCuentaDataGridViewTextBoxColumn.DataPropertyName = "SubCuenta"
        Me.SubCuentaDataGridViewTextBoxColumn.HeaderText = "SubCuenta"
        Me.SubCuentaDataGridViewTextBoxColumn.Name = "SubCuentaDataGridViewTextBoxColumn"
        Me.SubCuentaDataGridViewTextBoxColumn.Width = 83
        '
        'SSubCuentaDataGridViewTextBoxColumn
        '
        Me.SSubCuentaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SSubCuentaDataGridViewTextBoxColumn.DataPropertyName = "SSubCuenta"
        Me.SSubCuentaDataGridViewTextBoxColumn.HeaderText = "SSubCuenta"
        Me.SSubCuentaDataGridViewTextBoxColumn.Name = "SSubCuentaDataGridViewTextBoxColumn"
        Me.SSubCuentaDataGridViewTextBoxColumn.Width = 90
        '
        'SSSubCuentaDataGridViewTextBoxColumn
        '
        Me.SSSubCuentaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SSSubCuentaDataGridViewTextBoxColumn.DataPropertyName = "SSSubCuenta"
        Me.SSSubCuentaDataGridViewTextBoxColumn.HeaderText = "SSSubCuenta"
        Me.SSSubCuentaDataGridViewTextBoxColumn.Name = "SSSubCuentaDataGridViewTextBoxColumn"
        Me.SSSubCuentaDataGridViewTextBoxColumn.Width = 97
        '
        'CuentaContableDataGridViewTextBoxColumn
        '
        Me.CuentaContableDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CuentaContableDataGridViewTextBoxColumn.DataPropertyName = "CuentaContable"
        Me.CuentaContableDataGridViewTextBoxColumn.HeaderText = "Cuenta Contable"
        Me.CuentaContableDataGridViewTextBoxColumn.Name = "CuentaContableDataGridViewTextBoxColumn"
        Me.CuentaContableDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SumaORestaDataGridViewTextBoxColumn
        '
        Me.SumaORestaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SumaORestaDataGridViewTextBoxColumn.DataPropertyName = "SumaOResta"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.SumaORestaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.SumaORestaDataGridViewTextBoxColumn.HeaderText = "+/-"
        Me.SumaORestaDataGridViewTextBoxColumn.Name = "SumaORestaDataGridViewTextBoxColumn"
        Me.SumaORestaDataGridViewTextBoxColumn.Width = 44
        '
        'SaldoAumuladoDataGridViewTextBoxColumn
        '
        Me.SaldoAumuladoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SaldoAumuladoDataGridViewTextBoxColumn.DataPropertyName = "SaldoAumulado"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.SaldoAumuladoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.SaldoAumuladoDataGridViewTextBoxColumn.HeaderText = "Saldo"
        Me.SaldoAumuladoDataGridViewTextBoxColumn.Name = "SaldoAumuladoDataGridViewTextBoxColumn"
        Me.SaldoAumuladoDataGridViewTextBoxColumn.ReadOnly = True
        Me.SaldoAumuladoDataGridViewTextBoxColumn.Width = 57
        '
        'EstadoResultadoDetalleC
        '
        Me.EstadoResultadoDetalleC.AllowEdit = True
        Me.EstadoResultadoDetalleC.AllowNew = True
        Me.EstadoResultadoDetalleC.AllowRemove = True
        Me.EstadoResultadoDetalleC.MaximoElementosSeleccionados = 1
        Me.EstadoResultadoDetalleC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.EstadoResultadoDetalleC.MostrarAlertas = False
        Me.EstadoResultadoDetalleC.Name = Nothing
        Me.EstadoResultadoDetalleC.RaiseListChangedEvents = True
        Me.EstadoResultadoDetalleC.Transaction = Nothing
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.ComboBoxEnlazado = Nothing
        Me.txtDescripcion.Decimales = 0
        Me.txtDescripcion.Location = New System.Drawing.Point(138, 65)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.MensajeCombo = "Seleccionar un item..."
        Me.txtDescripcion.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.SiguienteControl = Nothing
        Me.txtDescripcion.Size = New System.Drawing.Size(485, 20)
        Me.txtDescripcion.TabIndex = 5
        Me.txtDescripcion.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtDescripcion.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtDescripcion.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtRubro
        '
        Me.txtRubro.ComboBoxEnlazado = Nothing
        Me.txtRubro.Decimales = 0
        Me.txtRubro.Location = New System.Drawing.Point(138, 39)
        Me.txtRubro.MaxLength = 3000
        Me.txtRubro.MensajeCombo = "Seleccionar un item..."
        Me.txtRubro.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtRubro.Name = "txtRubro"
        Me.txtRubro.SiguienteControl = Me.txtDescripcion
        Me.txtRubro.Size = New System.Drawing.Size(54, 20)
        Me.txtRubro.TabIndex = 4
        Me.txtRubro.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtRubro.ValorMaximo = New Decimal(New Integer() {999, 0, 0, 0})
        Me.txtRubro.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(68, 556)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(226, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Para Buscar una Cuenta Contable presione F3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Categoría:"
        Me.Label3.Visible = False
        '
        'cmbCategoria
        '
        Me.cmbCategoria.FormattingEnabled = True
        Me.cmbCategoria.Location = New System.Drawing.Point(138, 91)
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Size = New System.Drawing.Size(302, 21)
        Me.cmbCategoria.TabIndex = 16
        Me.cmbCategoria.Visible = False
        '
        'frmEstadoResultado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 578)
        Me.Controls.Add(Me.cmbCategoria)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtRubro)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmEstadoResultado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estaods Financieros      Estado de Resultados"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents txtRubro As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtDescripcion As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents EstadoResultadoDetalleC As ClasesNegocio.EstadoResultadoDetalleCollectionClas
    Friend WithEvents CuentaMayorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubCuentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SSubCuentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SSSubCuentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CuentaContableDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SumaORestaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoAumuladoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbCategoria As System.Windows.Forms.ComboBox
End Class
