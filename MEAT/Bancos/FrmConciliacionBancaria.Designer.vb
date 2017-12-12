<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConciliacionBancaria
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label17 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbCuentaBancaria = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.dgvConciliar = New System.Windows.Forms.DataGridView
        Me.cmbBanco = New System.Windows.Forms.ComboBox
        Me.BancosC = New ClasesNegocio.BancosCollectionClass
        Me.txtConcepto = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.CveConciliacion = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.cmdPoliza = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmdFechaCaptura = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmdFechaMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmdNoCheque = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmdReferencia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmdTipoMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmdImporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Concepto = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgvConciliar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(0, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(836, 29)
        Me.Label17.TabIndex = 58
        Me.Label17.Text = "Conciliacion Bancaria"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.mtb.Location = New System.Drawing.Point(2, 28)
        Me.mtb.MostrarBorrar = False
        Me.mtb.MostrarBuscar = True
        Me.mtb.MostrarCancelar = False
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 370)
        Me.mtb.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(310, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Cta. Bancaria:"
        '
        'cmbCuentaBancaria
        '
        Me.cmbCuentaBancaria.FormattingEnabled = True
        Me.cmbCuentaBancaria.Location = New System.Drawing.Point(390, 39)
        Me.cmbCuentaBancaria.Name = "cmbCuentaBancaria"
        Me.cmbCuentaBancaria.Size = New System.Drawing.Size(158, 21)
        Me.cmbCuentaBancaria.TabIndex = 62
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Banco:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(58, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Concepto:"
        '
        'dgvConciliar
        '
        Me.dgvConciliar.AllowUserToAddRows = False
        Me.dgvConciliar.AllowUserToDeleteRows = False
        Me.dgvConciliar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConciliar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CveConciliacion, Me.cmdPoliza, Me.cmdFechaCaptura, Me.cmdFechaMovimiento, Me.cmdNoCheque, Me.cmdReferencia, Me.cmdTipoMovimiento, Me.cmdImporte, Me.Concepto})
        Me.dgvConciliar.Location = New System.Drawing.Point(6, 6)
        Me.dgvConciliar.MultiSelect = False
        Me.dgvConciliar.Name = "dgvConciliar"
        Me.dgvConciliar.RowHeadersVisible = False
        Me.dgvConciliar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvConciliar.Size = New System.Drawing.Size(762, 264)
        Me.dgvConciliar.TabIndex = 71
        '
        'cmbBanco
        '
        Me.cmbBanco.DataSource = Me.BancosC
        Me.cmbBanco.DisplayMember = "Descripcion"
        Me.cmbBanco.FormattingEnabled = True
        Me.cmbBanco.Location = New System.Drawing.Point(130, 39)
        Me.cmbBanco.Name = "cmbBanco"
        Me.cmbBanco.Size = New System.Drawing.Size(174, 21)
        Me.cmbBanco.TabIndex = 73
        '
        'BancosC
        '
        Me.BancosC.AllowEdit = True
        Me.BancosC.AllowNew = True
        Me.BancosC.AllowRemove = True
        Me.BancosC.Name = ""
        Me.BancosC.RaiseListChangedEvents = True
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(130, 70)
        Me.txtConcepto.Multiline = True
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.ReadOnly = True
        Me.txtConcepto.Size = New System.Drawing.Size(428, 48)
        Me.txtConcepto.TabIndex = 70
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgvConciliar)
        Me.Panel2.Location = New System.Drawing.Point(61, 124)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(771, 274)
        Me.Panel2.TabIndex = 74
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(554, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "MM/yyyy"
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(600, 38)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.ShowUpDown = True
        Me.dtpFecha.Size = New System.Drawing.Size(97, 20)
        Me.dtpFecha.TabIndex = 76
        Me.dtpFecha.Value = New Date(2011, 1, 12, 0, 0, 0, 0)
        '
        'CveConciliacion
        '
        Me.CveConciliacion.DataPropertyName = "CveConciliacion"
        Me.CveConciliacion.HeaderText = "Conciliacion"
        Me.CveConciliacion.Name = "CveConciliacion"
        Me.CveConciliacion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CveConciliacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CveConciliacion.Width = 70
        '
        'cmdPoliza
        '
        Me.cmdPoliza.DataPropertyName = "PolizaId"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.cmdPoliza.DefaultCellStyle = DataGridViewCellStyle1
        Me.cmdPoliza.HeaderText = "No. Poliza"
        Me.cmdPoliza.Name = "cmdPoliza"
        Me.cmdPoliza.ReadOnly = True
        Me.cmdPoliza.Width = 80
        '
        'cmdFechaCaptura
        '
        Me.cmdFechaCaptura.DataPropertyName = "FechaDocumento"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.cmdFechaCaptura.DefaultCellStyle = DataGridViewCellStyle2
        Me.cmdFechaCaptura.HeaderText = "Fecha Capt."
        Me.cmdFechaCaptura.Name = "cmdFechaCaptura"
        Me.cmdFechaCaptura.ReadOnly = True
        '
        'cmdFechaMovimiento
        '
        Me.cmdFechaMovimiento.DataPropertyName = "FechaDocumento"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.cmdFechaMovimiento.DefaultCellStyle = DataGridViewCellStyle3
        Me.cmdFechaMovimiento.HeaderText = "Fecha Mvto."
        Me.cmdFechaMovimiento.Name = "cmdFechaMovimiento"
        Me.cmdFechaMovimiento.ReadOnly = True
        '
        'cmdNoCheque
        '
        Me.cmdNoCheque.DataPropertyName = "Folio"
        Me.cmdNoCheque.HeaderText = "No. Cheque"
        Me.cmdNoCheque.Name = "cmdNoCheque"
        Me.cmdNoCheque.ReadOnly = True
        Me.cmdNoCheque.Width = 90
        '
        'cmdReferencia
        '
        Me.cmdReferencia.DataPropertyName = "Referencia"
        Me.cmdReferencia.HeaderText = "Referencia"
        Me.cmdReferencia.Name = "cmdReferencia"
        Me.cmdReferencia.ReadOnly = True
        '
        'cmdTipoMovimiento
        '
        Me.cmdTipoMovimiento.DataPropertyName = "TipoMovimiento"
        Me.cmdTipoMovimiento.HeaderText = "Tipo Mvto."
        Me.cmdTipoMovimiento.Name = "cmdTipoMovimiento"
        Me.cmdTipoMovimiento.ReadOnly = True
        Me.cmdTipoMovimiento.Width = 90
        '
        'cmdImporte
        '
        Me.cmdImporte.DataPropertyName = "Importe"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.cmdImporte.DefaultCellStyle = DataGridViewCellStyle4
        Me.cmdImporte.HeaderText = "Importe"
        Me.cmdImporte.Name = "cmdImporte"
        Me.cmdImporte.ReadOnly = True
        Me.cmdImporte.Width = 80
        '
        'Concepto
        '
        Me.Concepto.DataPropertyName = "Concepto"
        Me.Concepto.HeaderText = "Concepto"
        Me.Concepto.Name = "Concepto"
        Me.Concepto.ReadOnly = True
        Me.Concepto.Visible = False
        '
        'FrmConciliacionBancaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 406)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cmbBanco)
        Me.Controls.Add(Me.txtConcepto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbCuentaBancaria)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.MaximizeBox = False
        Me.Name = "FrmConciliacionBancaria"
        Me.Text = "Conciliacion Bancaria"
        CType(Me.dgvConciliar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbCuentaBancaria As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgvConciliar As System.Windows.Forms.DataGridView
    Friend WithEvents cmbBanco As System.Windows.Forms.ComboBox
    Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BancosC As ClasesNegocio.BancosCollectionClass
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents CveConciliacion As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents cmdPoliza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdFechaCaptura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdFechaMovimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdNoCheque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdReferencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdTipoMovimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Concepto As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
