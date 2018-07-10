<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaSaldo
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.mtb = New MEAToolBar.MEAToolBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombreCuentaContable = New Integralab.Controles.TextBoxMejorado()
        Me.CuentaContableC = New ClasesNegocio.CuentaContableCollectionClass()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSSSubCuenta = New System.Windows.Forms.TextBox()
        Me.txtSSubCuenta = New System.Windows.Forms.TextBox()
        Me.txtSubCuenta = New System.Windows.Forms.TextBox()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.dgvConsulta = New System.Windows.Forms.DataGridView()
        Me.cmlPeriodo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmlCargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmlAbono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmlSaldos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSaldoInicial = New System.Windows.Forms.TextBox()
        CType(Me.dgvConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblTitulo.Size = New System.Drawing.Size(676, 29)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "CONSULTA DE SALDOS CONTABILIDAD GENERAL"
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
        Me.mtb.MostrarCancelar = False
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = False
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 468)
        Me.mtb.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cuenta Contable:"
        '
        'txtNombreCuentaContable
        '
        Me.txtNombreCuentaContable.ComboBoxEnlazado = Nothing
        Me.txtNombreCuentaContable.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuentaContableC, "NombreCuenta", True))
        Me.txtNombreCuentaContable.Decimales = 0
        Me.txtNombreCuentaContable.Location = New System.Drawing.Point(151, 65)
        Me.txtNombreCuentaContable.MensajeCombo = "Seleccionar un item..."
        Me.txtNombreCuentaContable.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtNombreCuentaContable.Name = "txtNombreCuentaContable"
        Me.txtNombreCuentaContable.ReadOnly = True
        Me.txtNombreCuentaContable.SiguienteControl = Nothing
        Me.txtNombreCuentaContable.Size = New System.Drawing.Size(431, 20)
        Me.txtNombreCuentaContable.TabIndex = 7
        Me.txtNombreCuentaContable.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtNombreCuentaContable.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtNombreCuentaContable.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'CuentaContableC
        '
        Me.CuentaContableC.AllowEdit = True
        Me.CuentaContableC.AllowNew = True
        Me.CuentaContableC.AllowRemove = True
        Me.CuentaContableC.Name = Nothing
        Me.CuentaContableC.RaiseListChangedEvents = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(330, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Saldo Inicio de Ejercicio"
        '
        'txtSSSubCuenta
        '
        Me.txtSSSubCuenta.Location = New System.Drawing.Point(310, 39)
        Me.txtSSSubCuenta.MaxLength = 4
        Me.txtSSSubCuenta.Name = "txtSSSubCuenta"
        Me.txtSSSubCuenta.Size = New System.Drawing.Size(47, 20)
        Me.txtSSSubCuenta.TabIndex = 6
        '
        'txtSSubCuenta
        '
        Me.txtSSubCuenta.Location = New System.Drawing.Point(257, 39)
        Me.txtSSubCuenta.MaxLength = 4
        Me.txtSSubCuenta.Name = "txtSSubCuenta"
        Me.txtSSubCuenta.Size = New System.Drawing.Size(47, 20)
        Me.txtSSubCuenta.TabIndex = 5
        '
        'txtSubCuenta
        '
        Me.txtSubCuenta.Location = New System.Drawing.Point(204, 39)
        Me.txtSubCuenta.MaxLength = 4
        Me.txtSubCuenta.Name = "txtSubCuenta"
        Me.txtSubCuenta.Size = New System.Drawing.Size(47, 20)
        Me.txtSubCuenta.TabIndex = 4
        '
        'txtCuenta
        '
        Me.txtCuenta.Location = New System.Drawing.Point(151, 39)
        Me.txtCuenta.MaxLength = 4
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(47, 20)
        Me.txtCuenta.TabIndex = 3
        '
        'dgvConsulta
        '
        Me.dgvConsulta.AllowUserToAddRows = False
        Me.dgvConsulta.AllowUserToDeleteRows = False
        Me.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsulta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cmlPeriodo, Me.cmlCargo, Me.cmlAbono, Me.cmlSaldos})
        Me.dgvConsulta.Location = New System.Drawing.Point(59, 128)
        Me.dgvConsulta.Name = "dgvConsulta"
        Me.dgvConsulta.RowHeadersVisible = False
        Me.dgvConsulta.Size = New System.Drawing.Size(523, 309)
        Me.dgvConsulta.TabIndex = 66
        '
        'cmlPeriodo
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmlPeriodo.DefaultCellStyle = DataGridViewCellStyle2
        Me.cmlPeriodo.HeaderText = "Periodo"
        Me.cmlPeriodo.Name = "cmlPeriodo"
        Me.cmlPeriodo.ReadOnly = True
        Me.cmlPeriodo.Width = 130
        '
        'cmlCargo
        '
        Me.cmlCargo.HeaderText = "Cargos"
        Me.cmlCargo.Name = "cmlCargo"
        Me.cmlCargo.ReadOnly = True
        Me.cmlCargo.Width = 130
        '
        'cmlAbono
        '
        Me.cmlAbono.HeaderText = "Abono"
        Me.cmlAbono.Name = "cmlAbono"
        Me.cmlAbono.ReadOnly = True
        Me.cmlAbono.Width = 130
        '
        'cmlSaldos
        '
        Me.cmlSaldos.HeaderText = "Saldos"
        Me.cmlSaldos.Name = "cmlSaldos"
        Me.cmlSaldos.ReadOnly = True
        Me.cmlSaldos.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cmlSaldos.Width = 130
        '
        'txtSaldoInicial
        '
        Me.txtSaldoInicial.Location = New System.Drawing.Point(456, 102)
        Me.txtSaldoInicial.Name = "txtSaldoInicial"
        Me.txtSaldoInicial.ReadOnly = True
        Me.txtSaldoInicial.Size = New System.Drawing.Size(126, 20)
        Me.txtSaldoInicial.TabIndex = 67
        '
        'frmConsultaSaldo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 468)
        Me.Controls.Add(Me.txtSaldoInicial)
        Me.Controls.Add(Me.dgvConsulta)
        Me.Controls.Add(Me.txtCuenta)
        Me.Controls.Add(Me.txtSubCuenta)
        Me.Controls.Add(Me.txtSSubCuenta)
        Me.Controls.Add(Me.txtSSSubCuenta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNombreCuentaContable)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmConsultaSaldo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Saldos Contabilidad General"
        CType(Me.dgvConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombreCuentaContable As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CuentaContableC As ClasesNegocio.CuentaContableCollectionClass
    Friend WithEvents txtSSSubCuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtSSubCuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtSubCuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents dgvConsulta As System.Windows.Forms.DataGridView
    Friend WithEvents txtSaldoInicial As System.Windows.Forms.TextBox
    Friend WithEvents cmlPeriodo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmlCargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmlAbono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmlSaldos As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
