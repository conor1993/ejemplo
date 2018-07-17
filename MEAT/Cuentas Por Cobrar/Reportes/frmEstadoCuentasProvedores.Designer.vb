<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEstadoCuentasProvedores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.mtb = New MEAToolBar.MEAToolBar()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lbl_Proveedores = New System.Windows.Forms.Label()
        Me.cb_Provedores = New System.Windows.Forms.ComboBox()
        Me.gp_Facturas = New System.Windows.Forms.GroupBox()
        Me.dgv_Facturas = New System.Windows.Forms.DataGridView()
        Me.clmNoFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFechaFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmSaldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtp_FechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtp_FechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.lbl_FechaInicial = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gp_Polizas = New System.Windows.Forms.GroupBox()
        Me.dgv_Polizas = New System.Windows.Forms.DataGridView()
        Me.cb_RangoFechas = New System.Windows.Forms.CheckBox()
        Me.clmFechaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPoliza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCheque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmImportePoliza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gp_Facturas.SuspendLayout()
        CType(Me.dgv_Facturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gp_Polizas.SuspendLayout()
        CType(Me.dgv_Polizas, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 568)
        Me.mtb.TabIndex = 51
        '
        'Label17
        '
        Me.Label17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(47, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(644, 32)
        Me.Label17.TabIndex = 52
        Me.Label17.Text = "Estado de Cuentas de Proveedores"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_Proveedores
        '
        Me.lbl_Proveedores.AutoSize = True
        Me.lbl_Proveedores.Location = New System.Drawing.Point(56, 87)
        Me.lbl_Proveedores.Name = "lbl_Proveedores"
        Me.lbl_Proveedores.Size = New System.Drawing.Size(70, 13)
        Me.lbl_Proveedores.TabIndex = 53
        Me.lbl_Proveedores.Text = "Proveedores:"
        '
        'cb_Provedores
        '
        Me.cb_Provedores.FormattingEnabled = True
        Me.cb_Provedores.Location = New System.Drawing.Point(132, 84)
        Me.cb_Provedores.Name = "cb_Provedores"
        Me.cb_Provedores.Size = New System.Drawing.Size(264, 21)
        Me.cb_Provedores.TabIndex = 54
        '
        'gp_Facturas
        '
        Me.gp_Facturas.Controls.Add(Me.dgv_Facturas)
        Me.gp_Facturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gp_Facturas.Location = New System.Drawing.Point(59, 143)
        Me.gp_Facturas.Name = "gp_Facturas"
        Me.gp_Facturas.Size = New System.Drawing.Size(599, 201)
        Me.gp_Facturas.TabIndex = 55
        Me.gp_Facturas.TabStop = False
        Me.gp_Facturas.Text = "Facturas"
        '
        'dgv_Facturas
        '
        Me.dgv_Facturas.AllowDrop = True
        Me.dgv_Facturas.AllowUserToAddRows = False
        Me.dgv_Facturas.AllowUserToDeleteRows = False
        Me.dgv_Facturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_Facturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmNoFactura, Me.clmFechaFactura, Me.clmImporte, Me.clmPago, Me.clmSaldo})
        Me.dgv_Facturas.Location = New System.Drawing.Point(6, 19)
        Me.dgv_Facturas.Name = "dgv_Facturas"
        Me.dgv_Facturas.ReadOnly = True
        Me.dgv_Facturas.RowHeadersVisible = False
        Me.dgv_Facturas.Size = New System.Drawing.Size(587, 176)
        Me.dgv_Facturas.TabIndex = 0
        '
        'clmNoFactura
        '
        Me.clmNoFactura.DataPropertyName = "No Factura"
        Me.clmNoFactura.HeaderText = "Factura"
        Me.clmNoFactura.Name = "clmNoFactura"
        Me.clmNoFactura.ReadOnly = True
        Me.clmNoFactura.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clmNoFactura.Width = 49
        '
        'clmFechaFactura
        '
        Me.clmFechaFactura.DataPropertyName = "Fecha Factura"
        Me.clmFechaFactura.HeaderText = "Fecha Factura"
        Me.clmFechaFactura.Name = "clmFechaFactura"
        Me.clmFechaFactura.ReadOnly = True
        Me.clmFechaFactura.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clmFechaFactura.Width = 82
        '
        'clmImporte
        '
        Me.clmImporte.DataPropertyName = "Importe"
        Me.clmImporte.HeaderText = "Importe"
        Me.clmImporte.Name = "clmImporte"
        Me.clmImporte.ReadOnly = True
        Me.clmImporte.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clmImporte.Width = 48
        '
        'clmPago
        '
        Me.clmPago.DataPropertyName = "Pago"
        Me.clmPago.HeaderText = "Pago"
        Me.clmPago.Name = "clmPago"
        Me.clmPago.ReadOnly = True
        Me.clmPago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clmPago.Width = 38
        '
        'clmSaldo
        '
        Me.clmSaldo.HeaderText = "Saldo"
        Me.clmSaldo.Name = "clmSaldo"
        Me.clmSaldo.ReadOnly = True
        Me.clmSaldo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clmSaldo.Width = 40
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtp_FechaFinal)
        Me.GroupBox1.Controls.Add(Me.dtp_FechaInicial)
        Me.GroupBox1.Controls.Add(Me.lbl_FechaInicial)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(437, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(221, 70)
        Me.GroupBox1.TabIndex = 58
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rango de Fechas"
        '
        'dtp_FechaFinal
        '
        Me.dtp_FechaFinal.CustomFormat = "dd-MM-yyyy"
        Me.dtp_FechaFinal.Enabled = False
        Me.dtp_FechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaFinal.Location = New System.Drawing.Point(82, 46)
        Me.dtp_FechaFinal.Name = "dtp_FechaFinal"
        Me.dtp_FechaFinal.Size = New System.Drawing.Size(122, 20)
        Me.dtp_FechaFinal.TabIndex = 3
        '
        'dtp_FechaInicial
        '
        Me.dtp_FechaInicial.CustomFormat = "dd-MM-yyyy"
        Me.dtp_FechaInicial.Enabled = False
        Me.dtp_FechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaInicial.Location = New System.Drawing.Point(82, 20)
        Me.dtp_FechaInicial.Name = "dtp_FechaInicial"
        Me.dtp_FechaInicial.Size = New System.Drawing.Size(122, 20)
        Me.dtp_FechaInicial.TabIndex = 2
        '
        'lbl_FechaInicial
        '
        Me.lbl_FechaInicial.AutoSize = True
        Me.lbl_FechaInicial.Location = New System.Drawing.Point(6, 26)
        Me.lbl_FechaInicial.Name = "lbl_FechaInicial"
        Me.lbl_FechaInicial.Size = New System.Drawing.Size(70, 13)
        Me.lbl_FechaInicial.TabIndex = 1
        Me.lbl_FechaInicial.Text = "Fecha Inicial:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Final:"
        '
        'gp_Polizas
        '
        Me.gp_Polizas.Controls.Add(Me.dgv_Polizas)
        Me.gp_Polizas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gp_Polizas.Location = New System.Drawing.Point(59, 350)
        Me.gp_Polizas.Name = "gp_Polizas"
        Me.gp_Polizas.Size = New System.Drawing.Size(599, 201)
        Me.gp_Polizas.TabIndex = 56
        Me.gp_Polizas.TabStop = False
        Me.gp_Polizas.Text = "Polizas"
        '
        'dgv_Polizas
        '
        Me.dgv_Polizas.AllowUserToAddRows = False
        Me.dgv_Polizas.AllowUserToDeleteRows = False
        Me.dgv_Polizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Polizas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmFechaPago, Me.clmPoliza, Me.clmCheque, Me.clmImportePoliza})
        Me.dgv_Polizas.Location = New System.Drawing.Point(12, 25)
        Me.dgv_Polizas.Name = "dgv_Polizas"
        Me.dgv_Polizas.ReadOnly = True
        Me.dgv_Polizas.RowHeadersVisible = False
        Me.dgv_Polizas.Size = New System.Drawing.Size(587, 176)
        Me.dgv_Polizas.TabIndex = 0
        '
        'cb_RangoFechas
        '
        Me.cb_RangoFechas.AutoSize = True
        Me.cb_RangoFechas.Location = New System.Drawing.Point(437, 44)
        Me.cb_RangoFechas.Name = "cb_RangoFechas"
        Me.cb_RangoFechas.Size = New System.Drawing.Size(147, 17)
        Me.cb_RangoFechas.TabIndex = 59
        Me.cb_RangoFechas.Text = "Activar Rango de Fechas"
        Me.cb_RangoFechas.UseVisualStyleBackColor = True
        '
        'clmFechaPago
        '
        Me.clmFechaPago.DataPropertyName = "Fecha de Pago"
        Me.clmFechaPago.HeaderText = "Fecha Pago"
        Me.clmFechaPago.Name = "clmFechaPago"
        Me.clmFechaPago.ReadOnly = True
        Me.clmFechaPago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'clmPoliza
        '
        Me.clmPoliza.DataPropertyName = "No Poliza"
        Me.clmPoliza.HeaderText = "No Poliza"
        Me.clmPoliza.Name = "clmPoliza"
        Me.clmPoliza.ReadOnly = True
        Me.clmPoliza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'clmCheque
        '
        Me.clmCheque.DataPropertyName = "No Cheque"
        Me.clmCheque.HeaderText = "No Cheque"
        Me.clmCheque.Name = "clmCheque"
        Me.clmCheque.ReadOnly = True
        Me.clmCheque.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'clmImportePoliza
        '
        Me.clmImportePoliza.DataPropertyName = "Importe"
        Me.clmImportePoliza.HeaderText = "Importe"
        Me.clmImportePoliza.Name = "clmImportePoliza"
        Me.clmImportePoliza.ReadOnly = True
        Me.clmImportePoliza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'frmEstadoCuentasProvedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 568)
        Me.Controls.Add(Me.cb_RangoFechas)
        Me.Controls.Add(Me.gp_Polizas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gp_Facturas)
        Me.Controls.Add(Me.cb_Provedores)
        Me.Controls.Add(Me.lbl_Proveedores)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmEstadoCuentasProvedores"
        Me.Text = "Estado de Cuentas de Proveedores"
        Me.gp_Facturas.ResumeLayout(False)
        CType(Me.dgv_Facturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gp_Polizas.ResumeLayout(False)
        CType(Me.dgv_Polizas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As Label
    Friend WithEvents lbl_Proveedores As Label
    Friend WithEvents cb_Provedores As ComboBox
    Friend WithEvents gp_Facturas As GroupBox
    Friend WithEvents dgv_Facturas As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtp_FechaFinal As DateTimePicker
    Friend WithEvents dtp_FechaInicial As DateTimePicker
    Friend WithEvents lbl_FechaInicial As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents gp_Polizas As GroupBox
    Friend WithEvents dgv_Polizas As DataGridView
    Friend WithEvents cb_RangoFechas As CheckBox
    Friend WithEvents clmNoFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSaldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaPago As DataGridViewTextBoxColumn
    Friend WithEvents clmPoliza As DataGridViewTextBoxColumn
    Friend WithEvents clmCheque As DataGridViewTextBoxColumn
    Friend WithEvents clmImportePoliza As DataGridViewTextBoxColumn
End Class
