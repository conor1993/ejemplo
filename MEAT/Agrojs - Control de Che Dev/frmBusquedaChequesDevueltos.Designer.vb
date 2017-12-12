<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaChequesDevueltos
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
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.dgvChequesDevueltos = New System.Windows.Forms.DataGridView
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtNoCheque = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ultdtpFechaFinal = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.ultdtpFechaInicial = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label3 = New System.Windows.Forms.Label
        Me.ultcmbBanco = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.ultcmbCliente = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtObservaciones = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chkPagado = New System.Windows.Forms.CheckBox
        Me.chkAbonado = New System.Windows.Forms.CheckBox
        Me.chkCancelado = New System.Windows.Forms.CheckBox
        Me.chkVigente = New System.Windows.Forms.CheckBox
        Me.chkReporteDetallado = New System.Windows.Forms.CheckBox
        Me.clmNoCheque = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmBanco = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmSaldo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmImporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgvChequesDevueltos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ultdtpFechaFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ultdtpFechaInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ultcmbBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ultcmbCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
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
        Me.mtb.Size = New System.Drawing.Size(50, 433)
        Me.mtb.TabIndex = 77
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
        Me.lblTitulo.Size = New System.Drawing.Size(790, 32)
        Me.lblTitulo.TabIndex = 78
        Me.lblTitulo.Text = "BUSQUEDA DE CHEQUES DEVUELTOS"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvChequesDevueltos
        '
        Me.dgvChequesDevueltos.AllowUserToAddRows = False
        Me.dgvChequesDevueltos.AllowUserToDeleteRows = False
        Me.dgvChequesDevueltos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChequesDevueltos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmNoCheque, Me.clmBanco, Me.clmCliente, Me.clmSaldo, Me.clmImporte, Me.clmFecha, Me.clmEstatus})
        Me.dgvChequesDevueltos.Location = New System.Drawing.Point(55, 147)
        Me.dgvChequesDevueltos.MultiSelect = False
        Me.dgvChequesDevueltos.Name = "dgvChequesDevueltos"
        Me.dgvChequesDevueltos.ReadOnly = True
        Me.dgvChequesDevueltos.RowHeadersVisible = False
        Me.dgvChequesDevueltos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvChequesDevueltos.Size = New System.Drawing.Size(773, 246)
        Me.dgvChequesDevueltos.TabIndex = 10
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(672, 402)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 80
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(753, 402)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 81
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(53, 71)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 94
        Me.Label11.Text = "Banco:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(35, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 93
        Me.Label8.Text = "Fecha Inicial:"
        '
        'txtNoCheque
        '
        Me.txtNoCheque.Location = New System.Drawing.Point(140, 41)
        Me.txtNoCheque.Name = "txtNoCheque"
        Me.txtNoCheque.Size = New System.Drawing.Size(145, 20)
        Me.txtNoCheque.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "No. Cheque:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Cliente:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ultdtpFechaFinal)
        Me.GroupBox1.Controls.Add(Me.ultdtpFechaInicial)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(422, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(406, 50)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rango de Fechas"
        '
        'ultdtpFechaFinal
        '
        Me.ultdtpFechaFinal.Location = New System.Drawing.Point(280, 19)
        Me.ultdtpFechaFinal.Name = "ultdtpFechaFinal"
        Me.ultdtpFechaFinal.Size = New System.Drawing.Size(92, 21)
        Me.ultdtpFechaFinal.TabIndex = 5
        '
        'ultdtpFechaInicial
        '
        Me.ultdtpFechaInicial.Location = New System.Drawing.Point(111, 19)
        Me.ultdtpFechaInicial.Name = "ultdtpFechaInicial"
        Me.ultdtpFechaInicial.Size = New System.Drawing.Size(92, 21)
        Me.ultdtpFechaInicial.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(209, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 95
        Me.Label3.Text = "Fecha Final:"
        '
        'ultcmbBanco
        '
        Me.ultcmbBanco.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.ultcmbBanco.Location = New System.Drawing.Point(140, 67)
        Me.ultcmbBanco.Name = "ultcmbBanco"
        Me.ultcmbBanco.NullText = "Seleccione el Banco"
        Me.ultcmbBanco.Size = New System.Drawing.Size(276, 21)
        Me.ultcmbBanco.TabIndex = 1
        '
        'ultcmbCliente
        '
        Me.ultcmbCliente.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.ultcmbCliente.Location = New System.Drawing.Point(140, 94)
        Me.ultcmbCliente.Name = "ultcmbCliente"
        Me.ultcmbCliente.NullText = "Seleccione el Cliente"
        Me.ultcmbCliente.Size = New System.Drawing.Size(276, 21)
        Me.ultcmbCliente.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 99
        Me.Label4.Text = "Observaciones:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(140, 121)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(276, 20)
        Me.txtObservaciones.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkPagado)
        Me.GroupBox2.Controls.Add(Me.chkAbonado)
        Me.GroupBox2.Controls.Add(Me.chkCancelado)
        Me.GroupBox2.Controls.Add(Me.chkVigente)
        Me.GroupBox2.Location = New System.Drawing.Point(422, 94)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(406, 47)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estatus"
        '
        'chkPagado
        '
        Me.chkPagado.AutoSize = True
        Me.chkPagado.Location = New System.Drawing.Point(298, 19)
        Me.chkPagado.Name = "chkPagado"
        Me.chkPagado.Size = New System.Drawing.Size(71, 17)
        Me.chkPagado.TabIndex = 9
        Me.chkPagado.Text = "PAGADO"
        Me.chkPagado.UseVisualStyleBackColor = True
        '
        'chkAbonado
        '
        Me.chkAbonado.AutoSize = True
        Me.chkAbonado.Location = New System.Drawing.Point(213, 19)
        Me.chkAbonado.Name = "chkAbonado"
        Me.chkAbonado.Size = New System.Drawing.Size(79, 17)
        Me.chkAbonado.TabIndex = 8
        Me.chkAbonado.Text = "ABONADO"
        Me.chkAbonado.UseVisualStyleBackColor = True
        '
        'chkCancelado
        '
        Me.chkCancelado.AutoSize = True
        Me.chkCancelado.Location = New System.Drawing.Point(116, 19)
        Me.chkCancelado.Name = "chkCancelado"
        Me.chkCancelado.Size = New System.Drawing.Size(91, 17)
        Me.chkCancelado.TabIndex = 7
        Me.chkCancelado.Text = "CANCELADO"
        Me.chkCancelado.UseVisualStyleBackColor = True
        '
        'chkVigente
        '
        Me.chkVigente.AutoSize = True
        Me.chkVigente.Location = New System.Drawing.Point(37, 19)
        Me.chkVigente.Name = "chkVigente"
        Me.chkVigente.Size = New System.Drawing.Size(73, 17)
        Me.chkVigente.TabIndex = 6
        Me.chkVigente.Text = "VIGENTE"
        Me.chkVigente.UseVisualStyleBackColor = True
        '
        'chkReporteDetallado
        '
        Me.chkReporteDetallado.AutoSize = True
        Me.chkReporteDetallado.Location = New System.Drawing.Point(300, 44)
        Me.chkReporteDetallado.Name = "chkReporteDetallado"
        Me.chkReporteDetallado.Size = New System.Drawing.Size(112, 17)
        Me.chkReporteDetallado.TabIndex = 100
        Me.chkReporteDetallado.Text = "Reporte Detallado"
        Me.chkReporteDetallado.UseVisualStyleBackColor = True
        '
        'clmNoCheque
        '
        Me.clmNoCheque.DataPropertyName = "NoCheque"
        Me.clmNoCheque.HeaderText = "No. Cheque"
        Me.clmNoCheque.Name = "clmNoCheque"
        Me.clmNoCheque.ReadOnly = True
        Me.clmNoCheque.Width = 90
        '
        'clmBanco
        '
        Me.clmBanco.DataPropertyName = "Banco"
        Me.clmBanco.HeaderText = "Banco"
        Me.clmBanco.Name = "clmBanco"
        Me.clmBanco.ReadOnly = True
        Me.clmBanco.Width = 130
        '
        'clmCliente
        '
        Me.clmCliente.DataPropertyName = "Cliente"
        Me.clmCliente.HeaderText = "Cliente"
        Me.clmCliente.Name = "clmCliente"
        Me.clmCliente.ReadOnly = True
        Me.clmCliente.Width = 182
        '
        'clmSaldo
        '
        Me.clmSaldo.DataPropertyName = "Saldo"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "C2"
        Me.clmSaldo.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmSaldo.HeaderText = "Saldo"
        Me.clmSaldo.Name = "clmSaldo"
        Me.clmSaldo.ReadOnly = True
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
        'clmFecha
        '
        Me.clmFecha.DataPropertyName = "FechaDevolucion"
        DataGridViewCellStyle3.Format = "d"
        Me.clmFecha.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmFecha.HeaderText = "Fecha de Devolucion"
        Me.clmFecha.Name = "clmFecha"
        Me.clmFecha.ReadOnly = True
        Me.clmFecha.Width = 70
        '
        'clmEstatus
        '
        Me.clmEstatus.DataPropertyName = "Estatus"
        Me.clmEstatus.HeaderText = "Estatus"
        Me.clmEstatus.Name = "clmEstatus"
        Me.clmEstatus.ReadOnly = True
        Me.clmEstatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clmEstatus.Width = 80
        '
        'frmBusquedaChequesDevueltos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 433)
        Me.Controls.Add(Me.chkReporteDetallado)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ultcmbCliente)
        Me.Controls.Add(Me.ultcmbBanco)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtNoCheque)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.dgvChequesDevueltos)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmBusquedaChequesDevueltos"
        Me.Text = "BUSQUEDA DE CHEQUES DEVUELTOS"
        CType(Me.dgvChequesDevueltos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ultdtpFechaFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ultdtpFechaInicial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ultcmbBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ultcmbCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents dgvChequesDevueltos As System.Windows.Forms.DataGridView
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNoCheque As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ultcmbBanco As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents ultcmbCliente As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents ultdtpFechaFinal As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents ultdtpFechaInicial As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkVigente As System.Windows.Forms.CheckBox
    Friend WithEvents chkCancelado As System.Windows.Forms.CheckBox
    Friend WithEvents chkPagado As System.Windows.Forms.CheckBox
    Friend WithEvents chkAbonado As System.Windows.Forms.CheckBox
    Friend WithEvents chkReporteDetallado As System.Windows.Forms.CheckBox
    Friend WithEvents clmNoCheque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmBanco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSaldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
