<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CatCuentasForm
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
        Me.gpo = New System.Windows.Forms.GroupBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.chkTodos = New System.Windows.Forms.CheckBox
        Me.Txtfiltro = New System.Windows.Forms.TextBox
        Me.dgvCuentas = New System.Windows.Forms.DataGridView
        Me.EmpresaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CuentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.columnDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BancoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoMonedaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cuentas = New ClasesNegocio.CuentaCollectionClass
        Me.pan = New System.Windows.Forms.Panel
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.btnCtaCont = New System.Windows.Forms.Button
        Me.txtCtaCont = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtSdoIni = New Integra.Controles.TextboxDecimal
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbTipoMoneda = New System.Windows.Forms.ComboBox
        Me.TiposMoneda = New ClasesNegocio.TipoMonedaCollectionClass
        Me.cmbBanco = New System.Windows.Forms.ComboBox
        Me.BancosC = New ClasesNegocio.BancosCollectionClass
        Me.txtTipoMoneda = New System.Windows.Forms.TextBox
        Me.txtBanco = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.txtCuentaHabiente = New System.Windows.Forms.TextBox
        Me.txtCuenta = New System.Windows.Forms.TextBox
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.gpo.SuspendLayout()
        CType(Me.dgvCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpo
        '
        Me.gpo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpo.Controls.Add(Me.Label13)
        Me.gpo.Controls.Add(Me.chkTodos)
        Me.gpo.Controls.Add(Me.Txtfiltro)
        Me.gpo.Controls.Add(Me.dgvCuentas)
        Me.gpo.Location = New System.Drawing.Point(55, 210)
        Me.gpo.Name = "gpo"
        Me.gpo.Size = New System.Drawing.Size(793, 252)
        Me.gpo.TabIndex = 3
        Me.gpo.TabStop = False
        Me.gpo.Text = "Cuentas Registradas"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(80, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Buscar:"
        Me.Label13.Visible = False
        '
        'chkTodos
        '
        Me.chkTodos.AutoSize = True
        Me.chkTodos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkTodos.Location = New System.Drawing.Point(693, 19)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(94, 17)
        Me.chkTodos.TabIndex = 1
        Me.chkTodos.Text = "Mostrar Todos"
        Me.chkTodos.UseVisualStyleBackColor = True
        '
        'Txtfiltro
        '
        Me.Txtfiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtfiltro.Location = New System.Drawing.Point(164, 16)
        Me.Txtfiltro.Name = "Txtfiltro"
        Me.Txtfiltro.Size = New System.Drawing.Size(188, 20)
        Me.Txtfiltro.TabIndex = 42
        Me.Txtfiltro.Visible = False
        '
        'dgvCuentas
        '
        Me.dgvCuentas.AllowUserToAddRows = False
        Me.dgvCuentas.AllowUserToDeleteRows = False
        Me.dgvCuentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCuentas.AutoGenerateColumns = False
        Me.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpresaDataGridViewTextBoxColumn, Me.CuentaDataGridViewTextBoxColumn, Me.columnDescripcion, Me.BancoDataGridViewTextBoxColumn, Me.TipoMonedaDataGridViewTextBoxColumn, Me.EstatusDataGridViewTextBoxColumn})
        Me.dgvCuentas.DataSource = Me.Cuentas
        Me.dgvCuentas.Location = New System.Drawing.Point(10, 42)
        Me.dgvCuentas.MultiSelect = False
        Me.dgvCuentas.Name = "dgvCuentas"
        Me.dgvCuentas.ReadOnly = True
        Me.dgvCuentas.RowHeadersVisible = False
        Me.dgvCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCuentas.Size = New System.Drawing.Size(777, 204)
        Me.dgvCuentas.TabIndex = 0
        '
        'EmpresaDataGridViewTextBoxColumn
        '
        Me.EmpresaDataGridViewTextBoxColumn.DataPropertyName = "Empresa"
        Me.EmpresaDataGridViewTextBoxColumn.HeaderText = "Empresa"
        Me.EmpresaDataGridViewTextBoxColumn.Name = "EmpresaDataGridViewTextBoxColumn"
        Me.EmpresaDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmpresaDataGridViewTextBoxColumn.Visible = False
        Me.EmpresaDataGridViewTextBoxColumn.Width = 150
        '
        'CuentaDataGridViewTextBoxColumn
        '
        Me.CuentaDataGridViewTextBoxColumn.DataPropertyName = "Cuenta"
        Me.CuentaDataGridViewTextBoxColumn.HeaderText = "Cuenta Bancaria"
        Me.CuentaDataGridViewTextBoxColumn.Name = "CuentaDataGridViewTextBoxColumn"
        Me.CuentaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CuentaDataGridViewTextBoxColumn.Width = 150
        '
        'columnDescripcion
        '
        Me.columnDescripcion.DataPropertyName = "Descripcion"
        Me.columnDescripcion.HeaderText = "Descripción"
        Me.columnDescripcion.Name = "columnDescripcion"
        Me.columnDescripcion.ReadOnly = True
        Me.columnDescripcion.Width = 200
        '
        'BancoDataGridViewTextBoxColumn
        '
        Me.BancoDataGridViewTextBoxColumn.DataPropertyName = "Banco"
        Me.BancoDataGridViewTextBoxColumn.HeaderText = "Banco"
        Me.BancoDataGridViewTextBoxColumn.Name = "BancoDataGridViewTextBoxColumn"
        Me.BancoDataGridViewTextBoxColumn.ReadOnly = True
        Me.BancoDataGridViewTextBoxColumn.Width = 150
        '
        'TipoMonedaDataGridViewTextBoxColumn
        '
        Me.TipoMonedaDataGridViewTextBoxColumn.DataPropertyName = "TipoMoneda"
        Me.TipoMonedaDataGridViewTextBoxColumn.HeaderText = "Tipo de Moneda"
        Me.TipoMonedaDataGridViewTextBoxColumn.Name = "TipoMonedaDataGridViewTextBoxColumn"
        Me.TipoMonedaDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoMonedaDataGridViewTextBoxColumn.Width = 150
        '
        'EstatusDataGridViewTextBoxColumn
        '
        Me.EstatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.HeaderText = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.Name = "EstatusDataGridViewTextBoxColumn"
        Me.EstatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Cuentas
        '
        Me.Cuentas.AllowEdit = True
        Me.Cuentas.AllowNew = True
        Me.Cuentas.AllowRemove = True
        Me.Cuentas.Name = ""
        Me.Cuentas.RaiseListChangedEvents = True
        '
        'pan
        '
        Me.pan.Controls.Add(Me.lblEstatus)
        Me.pan.Controls.Add(Me.btnCtaCont)
        Me.pan.Controls.Add(Me.txtCtaCont)
        Me.pan.Controls.Add(Me.Label7)
        Me.pan.Controls.Add(Me.txtSdoIni)
        Me.pan.Controls.Add(Me.Label3)
        Me.pan.Controls.Add(Me.Label2)
        Me.pan.Controls.Add(Me.cmbTipoMoneda)
        Me.pan.Controls.Add(Me.cmbBanco)
        Me.pan.Controls.Add(Me.txtTipoMoneda)
        Me.pan.Controls.Add(Me.txtBanco)
        Me.pan.Controls.Add(Me.Label4)
        Me.pan.Controls.Add(Me.Label5)
        Me.pan.Controls.Add(Me.Label6)
        Me.pan.Controls.Add(Me.Label1)
        Me.pan.Controls.Add(Me.txtDescripcion)
        Me.pan.Controls.Add(Me.txtCuentaHabiente)
        Me.pan.Controls.Add(Me.txtCuenta)
        Me.pan.Location = New System.Drawing.Point(55, 33)
        Me.pan.Name = "pan"
        Me.pan.Size = New System.Drawing.Size(793, 171)
        Me.pan.TabIndex = 2
        '
        'lblEstatus
        '
        Me.lblEstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(665, 8)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(122, 21)
        Me.lblEstatus.TabIndex = 23
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCtaCont
        '
        Me.btnCtaCont.Location = New System.Drawing.Point(499, 144)
        Me.btnCtaCont.Name = "btnCtaCont"
        Me.btnCtaCont.Size = New System.Drawing.Size(26, 22)
        Me.btnCtaCont.TabIndex = 22
        Me.btnCtaCont.Text = "..."
        Me.btnCtaCont.UseVisualStyleBackColor = True
        '
        'txtCtaCont
        '
        Me.txtCtaCont.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCtaCont.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtaCont.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtCtaCont.Location = New System.Drawing.Point(110, 144)
        Me.txtCtaCont.Name = "txtCtaCont"
        Me.txtCtaCont.ReadOnly = True
        Me.txtCtaCont.Size = New System.Drawing.Size(383, 22)
        Me.txtCtaCont.TabIndex = 21
        Me.txtCtaCont.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Cta Contable:"
        '
        'txtSdoIni
        '
        Me.txtSdoIni.Decimales = CType(2UI, UInteger)
        Me.txtSdoIni.Location = New System.Drawing.Point(358, 92)
        Me.txtSdoIni.Name = "txtSdoIni"
        Me.txtSdoIni.Signo = Integra.Controles.TextboxDecimal.RespuestaEnum.NO
        Me.txtSdoIni.Size = New System.Drawing.Size(167, 20)
        Me.txtSdoIni.TabIndex = 13
        Me.txtSdoIni.Text = "0.00"
        Me.txtSdoIni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tipo de Moneda:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Banco:"
        '
        'cmbTipoMoneda
        '
        Me.cmbTipoMoneda.DataSource = Me.TiposMoneda
        Me.cmbTipoMoneda.DisplayMember = "Descripcion"
        Me.cmbTipoMoneda.FormattingEnabled = True
        Me.cmbTipoMoneda.Location = New System.Drawing.Point(216, 40)
        Me.cmbTipoMoneda.Name = "cmbTipoMoneda"
        Me.cmbTipoMoneda.Size = New System.Drawing.Size(309, 21)
        Me.cmbTipoMoneda.TabIndex = 8
        Me.cmbTipoMoneda.ValueMember = "DescripcionCorta"
        '
        'TiposMoneda
        '
        Me.TiposMoneda.AllowEdit = True
        Me.TiposMoneda.AllowNew = True
        Me.TiposMoneda.AllowRemove = True
        Me.TiposMoneda.MaximoElementosSeleccionados = 1
        Me.TiposMoneda.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.TiposMoneda.MostrarAlertas = False
        Me.TiposMoneda.Name = ""
        Me.TiposMoneda.RaiseListChangedEvents = True
        Me.TiposMoneda.Transaction = Nothing
        '
        'cmbBanco
        '
        Me.cmbBanco.DataSource = Me.BancosC
        Me.cmbBanco.DisplayMember = "Descripcion"
        Me.cmbBanco.FormattingEnabled = True
        Me.cmbBanco.Location = New System.Drawing.Point(216, 13)
        Me.cmbBanco.Name = "cmbBanco"
        Me.cmbBanco.Size = New System.Drawing.Size(309, 21)
        Me.cmbBanco.TabIndex = 6
        Me.cmbBanco.ValueMember = "DescripcionCta"
        '
        'BancosC
        '
        Me.BancosC.AllowEdit = True
        Me.BancosC.AllowNew = True
        Me.BancosC.AllowRemove = True
        Me.BancosC.Name = ""
        Me.BancosC.RaiseListChangedEvents = True
        '
        'txtTipoMoneda
        '
        Me.txtTipoMoneda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipoMoneda.Location = New System.Drawing.Point(110, 40)
        Me.txtTipoMoneda.Name = "txtTipoMoneda"
        Me.txtTipoMoneda.Size = New System.Drawing.Size(100, 20)
        Me.txtTipoMoneda.TabIndex = 7
        '
        'txtBanco
        '
        Me.txtBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBanco.Location = New System.Drawing.Point(110, 13)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(100, 20)
        Me.txtBanco.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Descripción:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Cuenta Habiente:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(285, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Saldo Inicial:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "No. Cta Bancaria:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(110, 118)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(415, 20)
        Me.txtDescripcion.TabIndex = 11
        '
        'txtCuentaHabiente
        '
        Me.txtCuentaHabiente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuentaHabiente.Location = New System.Drawing.Point(110, 66)
        Me.txtCuentaHabiente.Name = "txtCuentaHabiente"
        Me.txtCuentaHabiente.Size = New System.Drawing.Size(415, 20)
        Me.txtCuentaHabiente.TabIndex = 9
        '
        'txtCuenta
        '
        Me.txtCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCuenta.Location = New System.Drawing.Point(110, 92)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(169, 20)
        Me.txtCuenta.TabIndex = 10
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
        Me.mtb.Location = New System.Drawing.Point(3, -26)
        Me.mtb.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
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
        Me.lblTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(865, 30)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "CATÁLOGO CUENTAS BANCARIAS"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CatCuentasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 467)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.gpo)
        Me.Controls.Add(Me.pan)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(866, 499)
        Me.MinimumSize = New System.Drawing.Size(866, 499)
        Me.Name = "CatCuentasForm"
        Me.Text = "Cuentas Bancarias"
        Me.gpo.ResumeLayout(False)
        Me.gpo.PerformLayout()
        CType(Me.dgvCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan.ResumeLayout(False)
        Me.pan.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gpo As System.Windows.Forms.GroupBox
    Friend WithEvents dgvCuentas As System.Windows.Forms.DataGridView
    Friend WithEvents pan As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents Cuentas As ClasesNegocio.CuentaCollectionClass
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbBanco As System.Windows.Forms.ComboBox
    Friend WithEvents txtBanco As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents txtTipoMoneda As System.Windows.Forms.TextBox
    Friend WithEvents TiposMoneda As ClasesNegocio.TipoMonedaCollectionClass
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents EmpresaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CuentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BancoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoMonedaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCuentaHabiente As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSdoIni As Integra.Controles.TextboxDecimal
    Friend WithEvents btnCtaCont As System.Windows.Forms.Button
    Friend WithEvents txtCtaCont As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Txtfiltro As System.Windows.Forms.TextBox
    Friend WithEvents BancosC As ClasesNegocio.BancosCollectionClass
End Class
