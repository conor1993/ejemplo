<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CancelacionPagoAProveedoresForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CancelacionPagoAProveedoresForm))
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.lblEmpresa = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DgvFacturas = New System.Windows.Forms.DataGridView
        Me.ClmFactura = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmImportePago = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DgvPagos = New System.Windows.Forms.DataGridView
        Me.ClmCheque = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmFecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmImporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmCuentaBancaria = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmPoliza = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CmbProveedor = New System.Windows.Forms.ComboBox
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.pDg = New System.Windows.Forms.PrintDialog
        Me.ppDg = New System.Windows.Forms.PrintPreviewDialog
        Me.ImprimirCheque = New ClasesNegocio.PrintDocumentPolizaCancelacionClass
        Me.PagoElectronico = New ClasesNegocio.PrintDocumentPagoElectronicoClass
        Me.TmProveedor = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(49, 0)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(846, 30)
        Me.lblTitulo.TabIndex = 6
        Me.lblTitulo.Text = "CANCELACIÓN PAGOS A PROVEEDORES"
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
        Me.mtb.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.mtb.MostrarBorrar = True
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
        Me.mtb.Size = New System.Drawing.Size(50, 358)
        Me.mtb.TabIndex = 7
        '
        'lblEmpresa
        '
        Me.lblEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmpresa.Location = New System.Drawing.Point(192, 39)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(247, 20)
        Me.lblEmpresa.TabIndex = 66
        Me.lblEmpresa.Text = "Label3"
        Me.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(135, 43)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 13)
        Me.Label18.TabIndex = 67
        Me.Label18.Text = "Empresa:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Proveedor :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(495, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Fecha :"
        '
        'DtpFecha
        '
        Me.DtpFecha.Enabled = False
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(544, 39)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(95, 20)
        Me.DtpFecha.TabIndex = 71
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvFacturas)
        Me.GroupBox1.Controls.Add(Me.DgvPagos)
        Me.GroupBox1.Location = New System.Drawing.Point(64, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(814, 216)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pagos Registrados"
        '
        'DgvFacturas
        '
        Me.DgvFacturas.AllowUserToAddRows = False
        Me.DgvFacturas.AllowUserToDeleteRows = False
        Me.DgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClmFactura, Me.ClmImportePago})
        Me.DgvFacturas.Location = New System.Drawing.Point(601, 28)
        Me.DgvFacturas.Name = "DgvFacturas"
        Me.DgvFacturas.ReadOnly = True
        Me.DgvFacturas.RowHeadersVisible = False
        Me.DgvFacturas.Size = New System.Drawing.Size(208, 181)
        Me.DgvFacturas.TabIndex = 1
        '
        'ClmFactura
        '
        Me.ClmFactura.DataPropertyName = "NoFactura"
        Me.ClmFactura.HeaderText = "Factura"
        Me.ClmFactura.Name = "ClmFactura"
        Me.ClmFactura.ReadOnly = True
        '
        'ClmImportePago
        '
        Me.ClmImportePago.DataPropertyName = "Importe"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.ClmImportePago.DefaultCellStyle = DataGridViewCellStyle1
        Me.ClmImportePago.HeaderText = "Importe"
        Me.ClmImportePago.Name = "ClmImportePago"
        Me.ClmImportePago.ReadOnly = True
        '
        'DgvPagos
        '
        Me.DgvPagos.AllowUserToAddRows = False
        Me.DgvPagos.AllowUserToDeleteRows = False
        Me.DgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClmCheque, Me.ClmFecha, Me.ClmImporte, Me.ClmCuentaBancaria, Me.ClmPoliza})
        Me.DgvPagos.Location = New System.Drawing.Point(6, 29)
        Me.DgvPagos.Name = "DgvPagos"
        Me.DgvPagos.ReadOnly = True
        Me.DgvPagos.RowHeadersVisible = False
        Me.DgvPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPagos.Size = New System.Drawing.Size(589, 180)
        Me.DgvPagos.TabIndex = 0
        '
        'ClmCheque
        '
        Me.ClmCheque.DataPropertyName = "Cheque"
        Me.ClmCheque.HeaderText = "Cheque"
        Me.ClmCheque.Name = "ClmCheque"
        Me.ClmCheque.ReadOnly = True
        '
        'ClmFecha
        '
        Me.ClmFecha.DataPropertyName = "FechaMovimiento"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.ClmFecha.DefaultCellStyle = DataGridViewCellStyle2
        Me.ClmFecha.HeaderText = "Fecha"
        Me.ClmFecha.Name = "ClmFecha"
        Me.ClmFecha.ReadOnly = True
        '
        'ClmImporte
        '
        Me.ClmImporte.DataPropertyName = "Importe"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ClmImporte.DefaultCellStyle = DataGridViewCellStyle3
        Me.ClmImporte.HeaderText = "Importe Total"
        Me.ClmImporte.Name = "ClmImporte"
        Me.ClmImporte.ReadOnly = True
        Me.ClmImporte.Width = 120
        '
        'ClmCuentaBancaria
        '
        Me.ClmCuentaBancaria.DataPropertyName = "Cuenta"
        Me.ClmCuentaBancaria.HeaderText = "Cuenta Bancaria"
        Me.ClmCuentaBancaria.Name = "ClmCuentaBancaria"
        Me.ClmCuentaBancaria.ReadOnly = True
        Me.ClmCuentaBancaria.Width = 150
        '
        'ClmPoliza
        '
        Me.ClmPoliza.DataPropertyName = "NumeroPoliza"
        Me.ClmPoliza.HeaderText = "Póliza"
        Me.ClmPoliza.Name = "ClmPoliza"
        Me.ClmPoliza.ReadOnly = True
        '
        'CmbProveedor
        '
        Me.CmbProveedor.FormattingEnabled = True
        Me.CmbProveedor.Location = New System.Drawing.Point(135, 90)
        Me.CmbProveedor.Name = "CmbProveedor"
        Me.CmbProveedor.Size = New System.Drawing.Size(304, 21)
        Me.CmbProveedor.TabIndex = 69
        '
        'lblEstatus
        '
        Me.lblEstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(756, 35)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(122, 21)
        Me.lblEstatus.TabIndex = 100
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEstatus.Visible = False
        '
        'pDg
        '
        Me.pDg.UseEXDialog = True
        '
        'ppDg
        '
        Me.ppDg.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.ppDg.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.ppDg.ClientSize = New System.Drawing.Size(400, 300)
        Me.ppDg.Document = Me.ImprimirCheque
        Me.ppDg.Enabled = True
        Me.ppDg.Icon = CType(resources.GetObject("ppDg.Icon"), System.Drawing.Icon)
        Me.ppDg.Name = "ppDg"
        Me.ppDg.Visible = False
        '
        'ImprimirCheque
        '
        Me.ImprimirCheque.AbonoEnCuenta = System.Windows.Forms.DialogResult.None
        Me.ImprimirCheque.Cheque = Nothing
        '
        'PagoElectronico
        '
        Me.PagoElectronico.Cheque = Nothing
        '
        'TmProveedor
        '
        Me.TmProveedor.Interval = 1000
        '
        'CancelacionPagoAProveedoresForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 358)
        Me.Controls.Add(Me.lblEstatus)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DtpFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbProveedor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblEmpresa)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CancelacionPagoAProveedoresForm"
        Me.Text = "Cancelación Pagos a Proveedores"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgvFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents lblEmpresa As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DgvPagos As System.Windows.Forms.DataGridView
    Friend WithEvents DgvFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents ClmFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmImportePago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents ppDg As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents pDg As System.Windows.Forms.PrintDialog
    Friend WithEvents PagoElectronico As ClasesNegocio.PrintDocumentPagoElectronicoClass
    Friend WithEvents ImprimirCheque As ClasesNegocio.PrintDocumentPolizaCancelacionClass
    Friend WithEvents ClmCheque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmCuentaBancaria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmPoliza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TmProveedor As System.Windows.Forms.Timer
End Class
