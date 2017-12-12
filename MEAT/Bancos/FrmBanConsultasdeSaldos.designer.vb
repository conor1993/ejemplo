<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBanConsultasdeSaldos
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
        Me.Label17 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtBanco = New Integralab.Controles.TextBoxMejorado
        Me.txtTipoMoneda = New Integralab.Controles.TextBoxMejorado
        Me.Cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Moneda = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Banco = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaldoAnterior = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cargodeldia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Abonosdeldia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaldoActual = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(735, 32)
        Me.Label17.TabIndex = 58
        Me.Label17.Text = "Consulta de Saldos de Bancos"
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
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = False
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = False
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = False
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 450)
        Me.mtb.TabIndex = 60
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cuenta, Me.Moneda, Me.Banco, Me.SaldoAnterior, Me.Cargodeldia, Me.Abonosdeldia, Me.SaldoActual})
        Me.DataGridView1.Location = New System.Drawing.Point(58, 101)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(720, 324)
        Me.DataGridView1.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Banco :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Moneda :"
        '
        'txtBanco
        '
        Me.txtBanco.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBanco.ComboBoxEnlazado = Nothing
        Me.txtBanco.Decimales = 0
        Me.txtBanco.Enabled = False
        Me.txtBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBanco.Location = New System.Drawing.Point(113, 41)
        Me.txtBanco.MensajeCombo = "Seleccionar un item..."
        Me.txtBanco.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.SiguienteControl = Nothing
        Me.txtBanco.Size = New System.Drawing.Size(237, 20)
        Me.txtBanco.TabIndex = 64
        Me.txtBanco.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtBanco.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtBanco.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtTipoMoneda
        '
        Me.txtTipoMoneda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTipoMoneda.ComboBoxEnlazado = Nothing
        Me.txtTipoMoneda.Decimales = 0
        Me.txtTipoMoneda.Enabled = False
        Me.txtTipoMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoMoneda.Location = New System.Drawing.Point(113, 67)
        Me.txtTipoMoneda.MensajeCombo = "Seleccionar un item..."
        Me.txtTipoMoneda.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtTipoMoneda.Name = "txtTipoMoneda"
        Me.txtTipoMoneda.SiguienteControl = Nothing
        Me.txtTipoMoneda.Size = New System.Drawing.Size(237, 20)
        Me.txtTipoMoneda.TabIndex = 65
        Me.txtTipoMoneda.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtTipoMoneda.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtTipoMoneda.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Cuenta
        '
        Me.Cuenta.DataPropertyName = "Cuenta"
        Me.Cuenta.HeaderText = "Cuenta"
        Me.Cuenta.Name = "Cuenta"
        Me.Cuenta.ReadOnly = True
        '
        'Moneda
        '
        Me.Moneda.DataPropertyName = "Moneda"
        Me.Moneda.HeaderText = "Moneda"
        Me.Moneda.Name = "Moneda"
        Me.Moneda.ReadOnly = True
        Me.Moneda.Visible = False
        '
        'Banco
        '
        Me.Banco.DataPropertyName = "Banco"
        Me.Banco.HeaderText = "Banco"
        Me.Banco.Name = "Banco"
        Me.Banco.ReadOnly = True
        Me.Banco.Visible = False
        '
        'SaldoAnterior
        '
        Me.SaldoAnterior.DataPropertyName = "Saldodiaant"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.SaldoAnterior.DefaultCellStyle = DataGridViewCellStyle1
        Me.SaldoAnterior.HeaderText = "Saldo Anterior"
        Me.SaldoAnterior.Name = "SaldoAnterior"
        Me.SaldoAnterior.ReadOnly = True
        Me.SaldoAnterior.Width = 150
        '
        'Cargodeldia
        '
        Me.Cargodeldia.DataPropertyName = "Cargo"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.Cargodeldia.DefaultCellStyle = DataGridViewCellStyle2
        Me.Cargodeldia.HeaderText = "Cargos del Día"
        Me.Cargodeldia.Name = "Cargodeldia"
        Me.Cargodeldia.ReadOnly = True
        Me.Cargodeldia.Width = 150
        '
        'Abonosdeldia
        '
        Me.Abonosdeldia.DataPropertyName = "Abono"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.Abonosdeldia.DefaultCellStyle = DataGridViewCellStyle3
        Me.Abonosdeldia.HeaderText = "Abonos del Día"
        Me.Abonosdeldia.Name = "Abonosdeldia"
        Me.Abonosdeldia.ReadOnly = True
        Me.Abonosdeldia.Width = 150
        '
        'SaldoActual
        '
        Me.SaldoActual.DataPropertyName = "SaldoActual"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.SaldoActual.DefaultCellStyle = DataGridViewCellStyle4
        Me.SaldoActual.HeaderText = "Saldo Actual"
        Me.SaldoActual.Name = "SaldoActual"
        Me.SaldoActual.ReadOnly = True
        Me.SaldoActual.Width = 150
        '
        'FrmBanConsultasdeSaldos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 450)
        Me.Controls.Add(Me.txtTipoMoneda)
        Me.Controls.Add(Me.txtBanco)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.Name = "FrmBanConsultasdeSaldos"
        Me.Text = "Consulta de Saldos de Bancos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBanco As Integralab.Controles.TextBoxMejorado
    Friend WithEvents txtTipoMoneda As Integralab.Controles.TextBoxMejorado
    Friend WithEvents Cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Moneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Banco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoAnterior As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cargodeldia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Abonosdeldia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoActual As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
