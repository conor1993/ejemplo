<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistroChequesDevueltos
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label17 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNoCheque = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtObservaciones = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtRecibio = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtSaldo = New System.Windows.Forms.TextBox
        Me.dgvPagos = New System.Windows.Forms.DataGridView
        Me.clmIdPago = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmImporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFechaPago = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ultdtpFechaDevolucion = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.ultnedImporte = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Me.ultcmbBanco = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.ultcmbCliente = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ultdtpFechaDevolucion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ultnedImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ultcmbBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ultcmbCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Label17.Size = New System.Drawing.Size(508, 32)
        Me.Label17.TabIndex = 77
        Me.Label17.Text = "REGISTRÓ DE CHEQUES DEVUELTOS"
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
        Me.mtb.MostrarBorrar = True
        Me.mtb.MostrarBuscar = True
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = True
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 440)
        Me.mtb.TabIndex = 76
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Cliente :"
        '
        'txtNoCheque
        '
        Me.txtNoCheque.Location = New System.Drawing.Point(173, 121)
        Me.txtNoCheque.MaxLength = 20
        Me.txtNoCheque.Name = "txtNoCheque"
        Me.txtNoCheque.Size = New System.Drawing.Size(171, 20)
        Me.txtNoCheque.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "No. Cheque :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(52, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 13)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "Fecha de Devolucion :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(52, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 86
        Me.Label11.Text = "Banco :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Importe :"
        '
        'lblEstatus
        '
        Me.lblEstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(409, 32)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(114, 21)
        Me.lblEstatus.TabIndex = 84
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Observaciones :"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Location = New System.Drawing.Point(173, 199)
        Me.txtObservaciones.MaxLength = 300
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtObservaciones.Size = New System.Drawing.Size(370, 53)
        Me.txtObservaciones.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Recibio :"
        '
        'txtRecibio
        '
        Me.txtRecibio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRecibio.Location = New System.Drawing.Point(173, 173)
        Me.txtRecibio.MaxLength = 100
        Me.txtRecibio.Name = "txtRecibio"
        Me.txtRecibio.Size = New System.Drawing.Size(370, 20)
        Me.txtRecibio.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtSaldo)
        Me.GroupBox1.Controls.Add(Me.dgvPagos)
        Me.GroupBox1.Location = New System.Drawing.Point(55, 258)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(494, 175)
        Me.GroupBox1.TabIndex = 94
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pagos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(64, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Saldo :"
        '
        'txtSaldo
        '
        Me.txtSaldo.Location = New System.Drawing.Point(110, 150)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.Size = New System.Drawing.Size(100, 20)
        Me.txtSaldo.TabIndex = 1
        Me.txtSaldo.TabStop = False
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvPagos
        '
        Me.dgvPagos.AllowUserToAddRows = False
        Me.dgvPagos.AllowUserToDeleteRows = False
        Me.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmIdPago, Me.clmImporte, Me.clmFechaPago, Me.clmObservaciones})
        Me.dgvPagos.Location = New System.Drawing.Point(6, 19)
        Me.dgvPagos.MultiSelect = False
        Me.dgvPagos.Name = "dgvPagos"
        Me.dgvPagos.ReadOnly = True
        Me.dgvPagos.RowHeadersVisible = False
        Me.dgvPagos.Size = New System.Drawing.Size(482, 125)
        Me.dgvPagos.TabIndex = 0
        '
        'clmIdPago
        '
        Me.clmIdPago.DataPropertyName = "Folio"
        Me.clmIdPago.HeaderText = "Folio"
        Me.clmIdPago.Name = "clmIdPago"
        Me.clmIdPago.ReadOnly = True
        '
        'clmImporte
        '
        Me.clmImporte.DataPropertyName = "Importe"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        Me.clmImporte.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmImporte.HeaderText = "Importe"
        Me.clmImporte.Name = "clmImporte"
        Me.clmImporte.ReadOnly = True
        '
        'clmFechaPago
        '
        Me.clmFechaPago.DataPropertyName = "FechaPago"
        DataGridViewCellStyle4.Format = "d"
        Me.clmFechaPago.DefaultCellStyle = DataGridViewCellStyle4
        Me.clmFechaPago.HeaderText = "Fecha Pago"
        Me.clmFechaPago.Name = "clmFechaPago"
        Me.clmFechaPago.ReadOnly = True
        Me.clmFechaPago.Width = 90
        '
        'clmObservaciones
        '
        Me.clmObservaciones.DataPropertyName = "Observaciones"
        Me.clmObservaciones.HeaderText = "Observaciones"
        Me.clmObservaciones.Name = "clmObservaciones"
        Me.clmObservaciones.ReadOnly = True
        Me.clmObservaciones.Width = 170
        '
        'ultdtpFechaDevolucion
        '
        Me.ultdtpFechaDevolucion.Location = New System.Drawing.Point(173, 95)
        Me.ultdtpFechaDevolucion.Name = "ultdtpFechaDevolucion"
        Me.ultdtpFechaDevolucion.Nullable = False
        Me.ultdtpFechaDevolucion.Size = New System.Drawing.Size(85, 21)
        Me.ultdtpFechaDevolucion.TabIndex = 2
        '
        'ultnedImporte
        '
        Me.ultnedImporte.Location = New System.Drawing.Point(173, 147)
        Me.ultnedImporte.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ultnedImporte.Name = "ultnedImporte"
        Me.ultnedImporte.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Decimal]
        Me.ultnedImporte.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.ultnedImporte.Size = New System.Drawing.Size(100, 21)
        Me.ultnedImporte.TabIndex = 4
        '
        'ultcmbBanco
        '
        Me.ultcmbBanco.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.ultcmbBanco.Location = New System.Drawing.Point(173, 41)
        Me.ultcmbBanco.Name = "ultcmbBanco"
        Me.ultcmbBanco.NullText = "Seleccione el Banco"
        Me.ultcmbBanco.Size = New System.Drawing.Size(200, 21)
        Me.ultcmbBanco.TabIndex = 0
        '
        'ultcmbCliente
        '
        Me.ultcmbCliente.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.ultcmbCliente.Location = New System.Drawing.Point(173, 68)
        Me.ultcmbCliente.Name = "ultcmbCliente"
        Me.ultcmbCliente.NullText = "Seleccione el Cliente"
        Me.ultcmbCliente.Size = New System.Drawing.Size(370, 21)
        Me.ultcmbCliente.TabIndex = 1
        '
        'frmRegistroChequesDevueltos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 440)
        Me.Controls.Add(Me.ultcmbCliente)
        Me.Controls.Add(Me.ultcmbBanco)
        Me.Controls.Add(Me.ultnedImporte)
        Me.Controls.Add(Me.ultdtpFechaDevolucion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtRecibio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblEstatus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtNoCheque)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmRegistroChequesDevueltos"
        Me.Text = "REGISTRÓ DE CHEQUES DEVUELTOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ultdtpFechaDevolucion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ultnedImporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ultcmbBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ultcmbCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNoCheque As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRecibio As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvPagos As System.Windows.Forms.DataGridView
    Friend WithEvents ultdtpFechaDevolucion As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents ultnedImporte As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents ultcmbBanco As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents ultcmbCliente As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents clmIdPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmObservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
