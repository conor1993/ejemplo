<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaPagosCheDev
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.dgvCabecero = New System.Windows.Forms.DataGridView
        Me.txtFolio = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ultdtpFechaFinal = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.ultdtpFechaInicial = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.dgvDetalle = New System.Windows.Forms.DataGridView
        Me.clmNoCheque = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmBanco = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFechaDevolucion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmSaldo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmDetalleImporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNoCheque = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chkCancelado = New System.Windows.Forms.CheckBox
        Me.chkVigente = New System.Windows.Forms.CheckBox
        Me.txtObservaciones = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.ultcmbCliente = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.clmFolio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFechaPago = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmImporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgvCabecero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ultdtpFechaFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ultdtpFechaInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ultcmbCliente, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.mtb.Size = New System.Drawing.Size(50, 431)
        Me.mtb.TabIndex = 78
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(50, 0)
        Me.lblTitulo.MaximumSize = New System.Drawing.Size(1600, 900)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(614, 32)
        Me.lblTitulo.TabIndex = 87
        Me.lblTitulo.Text = "BUSQUEDA DE PAGOS DE CHEQUES DEVUELTOS"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvCabecero
        '
        Me.dgvCabecero.AllowUserToAddRows = False
        Me.dgvCabecero.AllowUserToDeleteRows = False
        Me.dgvCabecero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCabecero.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmFolio, Me.clmCliente, Me.clmFechaPago, Me.clmImporte, Me.clmEstatus})
        Me.dgvCabecero.Location = New System.Drawing.Point(56, 121)
        Me.dgvCabecero.MultiSelect = False
        Me.dgvCabecero.Name = "dgvCabecero"
        Me.dgvCabecero.ReadOnly = True
        Me.dgvCabecero.RowHeadersVisible = False
        Me.dgvCabecero.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCabecero.Size = New System.Drawing.Size(597, 134)
        Me.dgvCabecero.TabIndex = 88
        '
        'txtFolio
        '
        Me.txtFolio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFolio.Location = New System.Drawing.Point(103, 68)
        Me.txtFolio.MaxLength = 10
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(116, 20)
        Me.txtFolio.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(52, 71)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 98
        Me.Label10.Text = "Folio :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "&Cliente :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ultdtpFechaFinal)
        Me.GroupBox1.Controls.Add(Me.ultdtpFechaInicial)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(461, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(192, 79)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rango de Fechas"
        '
        'ultdtpFechaFinal
        '
        Me.ultdtpFechaFinal.Location = New System.Drawing.Point(88, 46)
        Me.ultdtpFechaFinal.Name = "ultdtpFechaFinal"
        Me.ultdtpFechaFinal.Size = New System.Drawing.Size(92, 21)
        Me.ultdtpFechaFinal.TabIndex = 1
        '
        'ultdtpFechaInicial
        '
        Me.ultdtpFechaInicial.Location = New System.Drawing.Point(88, 19)
        Me.ultdtpFechaInicial.Name = "ultdtpFechaInicial"
        Me.ultdtpFechaInicial.Size = New System.Drawing.Size(92, 21)
        Me.ultdtpFechaInicial.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 95
        Me.Label3.Text = "Fecha Final:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 93
        Me.Label8.Text = "Fecha Inicial:"
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToDeleteRows = False
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmNoCheque, Me.clmBanco, Me.clmFechaDevolucion, Me.clmSaldo, Me.clmDetalleImporte})
        Me.dgvDetalle.Location = New System.Drawing.Point(56, 261)
        Me.dgvDetalle.MultiSelect = False
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.ReadOnly = True
        Me.dgvDetalle.RowHeadersVisible = False
        Me.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalle.Size = New System.Drawing.Size(597, 130)
        Me.dgvDetalle.TabIndex = 101
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
        Me.clmBanco.Width = 185
        '
        'clmFechaDevolucion
        '
        Me.clmFechaDevolucion.DataPropertyName = "FechaDevolucion"
        DataGridViewCellStyle3.Format = "d"
        Me.clmFechaDevolucion.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmFechaDevolucion.HeaderText = "Fecha Devolucion"
        Me.clmFechaDevolucion.Name = "clmFechaDevolucion"
        Me.clmFechaDevolucion.ReadOnly = True
        Me.clmFechaDevolucion.Width = 90
        '
        'clmSaldo
        '
        Me.clmSaldo.DataPropertyName = "Saldo"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        Me.clmSaldo.DefaultCellStyle = DataGridViewCellStyle4
        Me.clmSaldo.HeaderText = "Saldo"
        Me.clmSaldo.Name = "clmSaldo"
        Me.clmSaldo.ReadOnly = True
        '
        'clmDetalleImporte
        '
        Me.clmDetalleImporte.DataPropertyName = "Importe"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        Me.clmDetalleImporte.DefaultCellStyle = DataGridViewCellStyle5
        Me.clmDetalleImporte.HeaderText = "Importe"
        Me.clmDetalleImporte.Name = "clmDetalleImporte"
        Me.clmDetalleImporte.ReadOnly = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(578, 399)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 103
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(497, 399)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 102
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(304, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "No Cheque :"
        '
        'txtNoCheque
        '
        Me.txtNoCheque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNoCheque.Location = New System.Drawing.Point(377, 42)
        Me.txtNoCheque.MaxLength = 10
        Me.txtNoCheque.Name = "txtNoCheque"
        Me.txtNoCheque.Size = New System.Drawing.Size(78, 20)
        Me.txtNoCheque.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkCancelado)
        Me.GroupBox2.Controls.Add(Me.chkVigente)
        Me.GroupBox2.Location = New System.Drawing.Point(275, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(180, 51)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estatus"
        '
        'chkCancelado
        '
        Me.chkCancelado.AutoSize = True
        Me.chkCancelado.Location = New System.Drawing.Point(84, 22)
        Me.chkCancelado.Name = "chkCancelado"
        Me.chkCancelado.Size = New System.Drawing.Size(91, 17)
        Me.chkCancelado.TabIndex = 1
        Me.chkCancelado.Text = "CANCELADO"
        Me.chkCancelado.UseVisualStyleBackColor = True
        '
        'chkVigente
        '
        Me.chkVigente.AutoSize = True
        Me.chkVigente.Location = New System.Drawing.Point(5, 22)
        Me.chkVigente.Name = "chkVigente"
        Me.chkVigente.Size = New System.Drawing.Size(73, 17)
        Me.chkVigente.TabIndex = 0
        Me.chkVigente.Text = "VIGENTE"
        Me.chkVigente.UseVisualStyleBackColor = True
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Location = New System.Drawing.Point(103, 94)
        Me.txtObservaciones.MaxLength = 10
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(166, 20)
        Me.txtObservaciones.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "Obs. :"
        '
        'ultcmbCliente
        '
        Me.ultcmbCliente.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.ultcmbCliente.Location = New System.Drawing.Point(103, 41)
        Me.ultcmbCliente.Name = "ultcmbCliente"
        Me.ultcmbCliente.NullText = "Seleccione el Cliente"
        Me.ultcmbCliente.Size = New System.Drawing.Size(195, 21)
        Me.ultcmbCliente.TabIndex = 109
        '
        'clmFolio
        '
        Me.clmFolio.DataPropertyName = "Folio"
        Me.clmFolio.HeaderText = "Folio"
        Me.clmFolio.Name = "clmFolio"
        Me.clmFolio.ReadOnly = True
        Me.clmFolio.Width = 85
        '
        'clmCliente
        '
        Me.clmCliente.DataPropertyName = "Cliente"
        Me.clmCliente.HeaderText = "Cliente"
        Me.clmCliente.Name = "clmCliente"
        Me.clmCliente.ReadOnly = True
        Me.clmCliente.Width = 200
        '
        'clmFechaPago
        '
        Me.clmFechaPago.DataPropertyName = "FechaPago"
        DataGridViewCellStyle1.Format = "d"
        Me.clmFechaPago.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmFechaPago.HeaderText = "Fecha Pago"
        Me.clmFechaPago.Name = "clmFechaPago"
        Me.clmFechaPago.ReadOnly = True
        Me.clmFechaPago.Width = 90
        '
        'clmImporte
        '
        Me.clmImporte.DataPropertyName = "Importe"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        Me.clmImporte.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmImporte.HeaderText = "Importe"
        Me.clmImporte.Name = "clmImporte"
        Me.clmImporte.ReadOnly = True
        '
        'clmEstatus
        '
        Me.clmEstatus.DataPropertyName = "Estatus"
        Me.clmEstatus.HeaderText = "Estatus"
        Me.clmEstatus.Name = "clmEstatus"
        Me.clmEstatus.ReadOnly = True
        Me.clmEstatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'frmBusquedaPagosCheDev
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 431)
        Me.Controls.Add(Me.ultcmbCliente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtNoCheque)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.dgvDetalle)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvCabecero)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmBusquedaPagosCheDev"
        Me.Text = "BUSQUEDA DE PAGOS DE CHEQUES DEVUELTOS"
        CType(Me.dgvCabecero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ultdtpFechaFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ultdtpFechaInicial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ultcmbCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents dgvCabecero As System.Windows.Forms.DataGridView
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents ultdtpFechaInicial As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents ultdtpFechaFinal As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNoCheque As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCancelado As System.Windows.Forms.CheckBox
    Friend WithEvents chkVigente As System.Windows.Forms.CheckBox
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ultcmbCliente As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents clmNoCheque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmBanco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaDevolucion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSaldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDetalleImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFolio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
