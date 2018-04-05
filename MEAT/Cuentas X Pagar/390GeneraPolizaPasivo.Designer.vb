<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _390GeneraPolizaPasivo
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
        Me.mtb = New MEAToolBar.MEAToolBar()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCargo = New System.Windows.Forms.TextBox()
        Me.txtAbono = New System.Windows.Forms.TextBox()
        Me.DgvFacturas = New System.Windows.Forms.DataGridView()
        Me.check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IdProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmSubCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmSSubCta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmSSSubCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmAbono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtpFechaConta = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbProveedor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvGastos = New System.Windows.Forms.DataGridView()
        Me.chkb = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPoliza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdSucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdMetodo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ptj_Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProveedorFG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvGastos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 438)
        Me.mtb.TabIndex = 108
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
        Me.lblTitulo.Size = New System.Drawing.Size(838, 29)
        Me.lblTitulo.TabIndex = 109
        Me.lblTitulo.Text = "POLIZA DE PASIVO"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEmpresa
        '
        Me.lblEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmpresa.Location = New System.Drawing.Point(117, 39)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(390, 20)
        Me.lblEmpresa.TabIndex = 122
        Me.lblEmpresa.Text = "Label3"
        Me.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(52, 41)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 13)
        Me.Label18.TabIndex = 123
        Me.Label18.Text = "Empresa:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtCargo)
        Me.GroupBox1.Controls.Add(Me.txtAbono)
        Me.GroupBox1.Controls.Add(Me.DgvFacturas)
        Me.GroupBox1.Location = New System.Drawing.Point(52, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(824, 331)
        Me.GroupBox1.TabIndex = 121
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Facturas Registradas"
        '
        'txtCargo
        '
        Me.txtCargo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCargo.Location = New System.Drawing.Point(623, 303)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.ReadOnly = True
        Me.txtCargo.Size = New System.Drawing.Size(94, 20)
        Me.txtCargo.TabIndex = 125
        Me.txtCargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAbono
        '
        Me.txtAbono.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAbono.Location = New System.Drawing.Point(720, 303)
        Me.txtAbono.Name = "txtAbono"
        Me.txtAbono.ReadOnly = True
        Me.txtAbono.Size = New System.Drawing.Size(90, 20)
        Me.txtAbono.TabIndex = 124
        Me.txtAbono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DgvFacturas
        '
        Me.DgvFacturas.AllowUserToAddRows = False
        Me.DgvFacturas.AllowUserToDeleteRows = False
        Me.DgvFacturas.AllowUserToResizeRows = False
        Me.DgvFacturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.check, Me.IdProveedor, Me.NoFactura, Me.clmCodigo, Me.clmCta, Me.clmSubCuenta, Me.clmSSubCta, Me.clmSSSubCuenta, Me.clmNombre, Me.clmCargo, Me.clmAbono})
        Me.DgvFacturas.Location = New System.Drawing.Point(11, 25)
        Me.DgvFacturas.Name = "DgvFacturas"
        Me.DgvFacturas.RowHeadersVisible = False
        Me.DgvFacturas.Size = New System.Drawing.Size(807, 272)
        Me.DgvFacturas.TabIndex = 0
        '
        'check
        '
        Me.check.HeaderText = ""
        Me.check.Name = "check"
        Me.check.Width = 20
        '
        'IdProveedor
        '
        Me.IdProveedor.DataPropertyName = "IdProveedor"
        Me.IdProveedor.HeaderText = "IdProveedor"
        Me.IdProveedor.Name = "IdProveedor"
        Me.IdProveedor.Visible = False
        '
        'NoFactura
        '
        Me.NoFactura.DataPropertyName = "NoFactura"
        Me.NoFactura.HeaderText = "Factura"
        Me.NoFactura.Name = "NoFactura"
        Me.NoFactura.Width = 75
        '
        'clmCodigo
        '
        Me.clmCodigo.DataPropertyName = "CuentaContableId"
        Me.clmCodigo.HeaderText = "Código"
        Me.clmCodigo.Name = "clmCodigo"
        Me.clmCodigo.Width = 50
        '
        'clmCta
        '
        Me.clmCta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clmCta.DataPropertyName = "Cta"
        Me.clmCta.HeaderText = "Cta"
        Me.clmCta.Name = "clmCta"
        Me.clmCta.Width = 48
        '
        'clmSubCuenta
        '
        Me.clmSubCuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clmSubCuenta.DataPropertyName = "SubCta"
        Me.clmSubCuenta.HeaderText = "Sub Cuenta"
        Me.clmSubCuenta.Name = "clmSubCuenta"
        Me.clmSubCuenta.Width = 88
        '
        'clmSSubCta
        '
        Me.clmSSubCta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clmSSubCta.DataPropertyName = "SSubCta"
        Me.clmSSubCta.HeaderText = "SSub Cuenta"
        Me.clmSSubCta.Name = "clmSSubCta"
        Me.clmSSubCta.Width = 95
        '
        'clmSSSubCuenta
        '
        Me.clmSSSubCuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clmSSSubCuenta.DataPropertyName = "SSSubCta"
        Me.clmSSSubCuenta.HeaderText = "SSSub Cuenta"
        Me.clmSSSubCuenta.Name = "clmSSSubCuenta"
        Me.clmSSSubCuenta.Width = 102
        '
        'clmNombre
        '
        Me.clmNombre.DataPropertyName = "NomCuenta"
        Me.clmNombre.HeaderText = "Nombre"
        Me.clmNombre.Name = "clmNombre"
        Me.clmNombre.Width = 125
        '
        'clmCargo
        '
        Me.clmCargo.DataPropertyName = "Cargo"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.clmCargo.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmCargo.HeaderText = "Cargo"
        Me.clmCargo.Name = "clmCargo"
        '
        'clmAbono
        '
        Me.clmAbono.DataPropertyName = "Abono"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.clmAbono.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmAbono.HeaderText = "Abono"
        Me.clmAbono.Name = "clmAbono"
        '
        'dtpFechaConta
        '
        Me.dtpFechaConta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaConta.Location = New System.Drawing.Point(535, 61)
        Me.dtpFechaConta.Name = "dtpFechaConta"
        Me.dtpFechaConta.Size = New System.Drawing.Size(93, 20)
        Me.dtpFechaConta.TabIndex = 120
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(415, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "Fecha Contabilización:"
        '
        'CmbProveedor
        '
        Me.CmbProveedor.FormattingEnabled = True
        Me.CmbProveedor.Location = New System.Drawing.Point(117, 61)
        Me.CmbProveedor.Name = "CmbProveedor"
        Me.CmbProveedor.Size = New System.Drawing.Size(279, 21)
        Me.CmbProveedor.TabIndex = 118
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 117
        Me.Label1.Text = "Proveedor:"
        '
        'dgvGastos
        '
        Me.dgvGastos.AllowUserToAddRows = False
        Me.dgvGastos.AllowUserToDeleteRows = False
        Me.dgvGastos.AllowUserToResizeRows = False
        Me.dgvGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chkb, Me.Factura, Me.IdPoliza, Me.IdSucursal, Me.IdMetodo, Me.Cuenta, Me.Ptj_Importe, Me.Importe, Me.Fecha, Me.Estatus, Me.IdProveedorFG})
        Me.dgvGastos.Location = New System.Drawing.Point(634, 32)
        Me.dgvGastos.Name = "dgvGastos"
        Me.dgvGastos.RowHeadersVisible = False
        Me.dgvGastos.Size = New System.Drawing.Size(236, 83)
        Me.dgvGastos.TabIndex = 124
        Me.dgvGastos.Visible = False
        '
        'chkb
        '
        Me.chkb.HeaderText = ""
        Me.chkb.Name = "chkb"
        Me.chkb.Width = 20
        '
        'Factura
        '
        Me.Factura.DataPropertyName = "Factura"
        Me.Factura.HeaderText = "Factura"
        Me.Factura.Name = "Factura"
        '
        'IdPoliza
        '
        Me.IdPoliza.DataPropertyName = "IdPoliza"
        Me.IdPoliza.HeaderText = "IdPoliza"
        Me.IdPoliza.Name = "IdPoliza"
        '
        'IdSucursal
        '
        Me.IdSucursal.DataPropertyName = "IdSucursal"
        Me.IdSucursal.HeaderText = "IdSucursal"
        Me.IdSucursal.Name = "IdSucursal"
        '
        'IdMetodo
        '
        Me.IdMetodo.DataPropertyName = "IdMetodo"
        Me.IdMetodo.HeaderText = "IdMetodo"
        Me.IdMetodo.Name = "IdMetodo"
        '
        'Cuenta
        '
        Me.Cuenta.DataPropertyName = "Cuenta"
        Me.Cuenta.HeaderText = "Cuenta"
        Me.Cuenta.Name = "Cuenta"
        '
        'Ptj_Importe
        '
        Me.Ptj_Importe.DataPropertyName = "Ptj_Importe"
        Me.Ptj_Importe.HeaderText = "Ptj_Importe"
        Me.Ptj_Importe.Name = "Ptj_Importe"
        '
        'Importe
        '
        Me.Importe.DataPropertyName = "Importe"
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "Fecha"
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        '
        'Estatus
        '
        Me.Estatus.DataPropertyName = "Estatus"
        Me.Estatus.HeaderText = "Estatus"
        Me.Estatus.Name = "Estatus"
        '
        'IdProveedorFG
        '
        Me.IdProveedorFG.DataPropertyName = "Idprovedor"
        Me.IdProveedorFG.HeaderText = "IdProveedor"
        Me.IdProveedorFG.Name = "IdProveedorFG"
        '
        '_390GeneraPolizaPasivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 438)
        Me.Controls.Add(Me.dgvGastos)
        Me.Controls.Add(Me.lblEmpresa)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtpFechaConta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbProveedor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.mtb)
        Me.Name = "_390GeneraPolizaPasivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Poliza de Pasivo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvGastos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblEmpresa As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DgvFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents dtpFechaConta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAbono As System.Windows.Forms.TextBox
    Friend WithEvents txtCargo As System.Windows.Forms.TextBox
    Friend WithEvents dgvGastos As System.Windows.Forms.DataGridView
    Friend WithEvents chkb As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Factura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdPoliza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdSucursal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdMetodo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ptj_Importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdProveedorFG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents check As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IdProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSubCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSSubCta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSSSubCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmAbono As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
