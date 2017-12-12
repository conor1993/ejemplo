<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistroPagosChequesDevueltos
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
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.dgvChequesDevueltos = New System.Windows.Forms.DataGridView
        Me.clmSeleccion = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.clmIdChequeDevuelto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmNoCheque = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmBanco = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFechaDevolucion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmSaldo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmImporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtFolio = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtObservaciones = New System.Windows.Forms.TextBox
        Me.txtImportePago = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtSaldoActual = New System.Windows.Forms.TextBox
        Me.lblSaldo = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ultcmbCliente = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.ultdtpFechaPago = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label4 = New System.Windows.Forms.Label
        Me.ultcmbDeposito = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        CType(Me.dgvChequesDevueltos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ultcmbCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ultdtpFechaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ultcmbDeposito, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.mtb.MostrarBorrar = True
        Me.mtb.MostrarBuscar = True
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 408)
        Me.mtb.TabIndex = 77
        '
        'lblEstatus
        '
        Me.lblEstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(525, 32)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(113, 21)
        Me.lblEstatus.TabIndex = 85
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.MaximumSize = New System.Drawing.Size(1600, 900)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(594, 32)
        Me.Label17.TabIndex = 86
        Me.Label17.Text = "REGISTRÓ DE PAGOS DE CHEQUES DEVUELTOS"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvChequesDevueltos
        '
        Me.dgvChequesDevueltos.AllowUserToAddRows = False
        Me.dgvChequesDevueltos.AllowUserToDeleteRows = False
        Me.dgvChequesDevueltos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChequesDevueltos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmSeleccion, Me.clmIdChequeDevuelto, Me.clmNoCheque, Me.clmBanco, Me.clmFechaDevolucion, Me.clmSaldo, Me.clmImporte})
        Me.dgvChequesDevueltos.Location = New System.Drawing.Point(56, 180)
        Me.dgvChequesDevueltos.MultiSelect = False
        Me.dgvChequesDevueltos.Name = "dgvChequesDevueltos"
        Me.dgvChequesDevueltos.ReadOnly = True
        Me.dgvChequesDevueltos.RowHeadersVisible = False
        Me.dgvChequesDevueltos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvChequesDevueltos.Size = New System.Drawing.Size(582, 221)
        Me.dgvChequesDevueltos.TabIndex = 4
        '
        'clmSeleccion
        '
        Me.clmSeleccion.HeaderText = ""
        Me.clmSeleccion.Name = "clmSeleccion"
        Me.clmSeleccion.ReadOnly = True
        Me.clmSeleccion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmSeleccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clmSeleccion.Width = 20
        '
        'clmIdChequeDevuelto
        '
        Me.clmIdChequeDevuelto.DataPropertyName = "IdChequeDevuelto"
        Me.clmIdChequeDevuelto.HeaderText = "IdChequeDevuelto"
        Me.clmIdChequeDevuelto.Name = "clmIdChequeDevuelto"
        Me.clmIdChequeDevuelto.ReadOnly = True
        Me.clmIdChequeDevuelto.Visible = False
        '
        'clmNoCheque
        '
        Me.clmNoCheque.DataPropertyName = "NoCheque"
        Me.clmNoCheque.HeaderText = "No. Cheque"
        Me.clmNoCheque.Name = "clmNoCheque"
        Me.clmNoCheque.ReadOnly = True
        '
        'clmBanco
        '
        Me.clmBanco.DataPropertyName = "Banco"
        Me.clmBanco.HeaderText = "Banco"
        Me.clmBanco.Name = "clmBanco"
        Me.clmBanco.ReadOnly = True
        Me.clmBanco.Width = 140
        '
        'clmFechaDevolucion
        '
        Me.clmFechaDevolucion.DataPropertyName = "FechaDevolucion"
        DataGridViewCellStyle1.Format = "d"
        Me.clmFechaDevolucion.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmFechaDevolucion.HeaderText = "Fecha Devolucion"
        Me.clmFechaDevolucion.Name = "clmFechaDevolucion"
        Me.clmFechaDevolucion.ReadOnly = True
        Me.clmFechaDevolucion.Width = 90
        '
        'clmSaldo
        '
        Me.clmSaldo.DataPropertyName = "Saldo"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        Me.clmSaldo.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmSaldo.HeaderText = "Saldo"
        Me.clmSaldo.Name = "clmSaldo"
        Me.clmSaldo.ReadOnly = True
        Me.clmSaldo.Width = 105
        '
        'clmImporte
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.clmImporte.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmImporte.HeaderText = "Importe"
        Me.clmImporte.Name = "clmImporte"
        Me.clmImporte.ReadOnly = True
        Me.clmImporte.Width = 105
        '
        'txtFolio
        '
        Me.txtFolio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFolio.Location = New System.Drawing.Point(139, 75)
        Me.txtFolio.MaxLength = 10
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.ReadOnly = True
        Me.txtFolio.Size = New System.Drawing.Size(116, 20)
        Me.txtFolio.TabIndex = 95
        Me.txtFolio.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(52, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 94
        Me.Label10.Text = "Folio:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "Observaciones:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Location = New System.Drawing.Point(139, 128)
        Me.txtObservaciones.MaxLength = 300
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtObservaciones.Size = New System.Drawing.Size(296, 46)
        Me.txtObservaciones.TabIndex = 3
        '
        'txtImportePago
        '
        Me.txtImportePago.Location = New System.Drawing.Point(530, 127)
        Me.txtImportePago.Name = "txtImportePago"
        Me.txtImportePago.ReadOnly = True
        Me.txtImportePago.Size = New System.Drawing.Size(102, 20)
        Me.txtImportePago.TabIndex = 103
        Me.txtImportePago.TabStop = False
        Me.txtImportePago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(441, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 102
        Me.Label6.Text = "Importe Total:"
        '
        'txtSaldoActual
        '
        Me.txtSaldoActual.Location = New System.Drawing.Point(530, 101)
        Me.txtSaldoActual.Name = "txtSaldoActual"
        Me.txtSaldoActual.ReadOnly = True
        Me.txtSaldoActual.Size = New System.Drawing.Size(102, 20)
        Me.txtSaldoActual.TabIndex = 101
        Me.txtSaldoActual.TabStop = False
        Me.txtSaldoActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Location = New System.Drawing.Point(441, 104)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(70, 13)
        Me.lblSaldo.TabIndex = 100
        Me.lblSaldo.Text = "Saldo Actual:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(441, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Fecha de Pago:"
        '
        'ultcmbCliente
        '
        Me.ultcmbCliente.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.ultcmbCliente.Location = New System.Drawing.Point(139, 39)
        Me.ultcmbCliente.Name = "ultcmbCliente"
        Me.ultcmbCliente.NullText = "Seleccione el Cliente"
        Me.ultcmbCliente.Size = New System.Drawing.Size(382, 21)
        Me.ultcmbCliente.TabIndex = 0
        '
        'ultdtpFechaPago
        '
        Me.ultdtpFechaPago.Location = New System.Drawing.Point(530, 72)
        Me.ultdtpFechaPago.Name = "ultdtpFechaPago"
        Me.ultdtpFechaPago.Nullable = False
        Me.ultdtpFechaPago.Size = New System.Drawing.Size(102, 21)
        Me.ultdtpFechaPago.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "Banco Dep. :"
        '
        'ultcmbDeposito
        '
        Me.ultcmbDeposito.Location = New System.Drawing.Point(139, 101)
        Me.ultcmbDeposito.Name = "ultcmbDeposito"
        Me.ultcmbDeposito.NullText = "Seleccione el Bando de Deposito"
        Me.ultcmbDeposito.Size = New System.Drawing.Size(296, 21)
        Me.ultcmbDeposito.TabIndex = 2
        '
        'frmRegistroPagosChequesDevueltos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 408)
        Me.Controls.Add(Me.ultcmbDeposito)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ultdtpFechaPago)
        Me.Controls.Add(Me.ultcmbCliente)
        Me.Controls.Add(Me.txtImportePago)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSaldoActual)
        Me.Controls.Add(Me.lblSaldo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvChequesDevueltos)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lblEstatus)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmRegistroPagosChequesDevueltos"
        Me.Text = "REGISTRÓ DE PAGOS DE CHEQUES DEVUELTOS"
        CType(Me.dgvChequesDevueltos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ultcmbCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ultdtpFechaPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ultcmbDeposito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dgvChequesDevueltos As System.Windows.Forms.DataGridView
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents txtImportePago As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoActual As System.Windows.Forms.TextBox
    Friend WithEvents lblSaldo As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ultcmbCliente As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents ultdtpFechaPago As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents clmSeleccion As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents clmIdChequeDevuelto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmNoCheque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmBanco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaDevolucion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSaldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ultcmbDeposito As Infragistics.Win.UltraWinEditors.UltraComboEditor
End Class
