<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PolizaDiario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.mtb = New MEAToolBar.MEAToolBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblEstatus = New System.Windows.Forms.Label()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.txtConcepto = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPoliza = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalCargo = New System.Windows.Forms.TextBox()
        Me.txtTotalAbono = New System.Windows.Forms.TextBox()
        Me.txtDiferencia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvPoliza = New System.Windows.Forms.DataGridView()
        Me.PolizaDetalleC = New ClasesNegocio.PolizaDetalleCollectionClass()
        Me.clmIdCuentaContable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdGastoDepartamental = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PolizaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPosicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCuentaContablePri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CtaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCtaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SSCtaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SSSCtaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmConcepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmAbono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvPoliza, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblTitulo.Size = New System.Drawing.Size(861, 29)
        Me.lblTitulo.TabIndex = 135
        Me.lblTitulo.Text = "CAPTURA DE PÓLIZAS DIARIO"
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
        Me.mtb.MostrarBorrar = True
        Me.mtb.MostrarBuscar = True
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = True
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 514)
        Me.mtb.TabIndex = 134
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblEstatus)
        Me.GroupBox1.Controls.Add(Me.txtImporte)
        Me.GroupBox1.Controls.Add(Me.txtConcepto)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtPoliza)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DtpFecha)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(55, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(698, 135)
        Me.GroupBox1.TabIndex = 167
        Me.GroupBox1.TabStop = False
        '
        'lblEstatus
        '
        Me.lblEstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(562, 12)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(122, 21)
        Me.lblEstatus.TabIndex = 176
        Me.lblEstatus.Text = "ACTIVO"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEstatus.Visible = False
        '
        'txtImporte
        '
        Me.txtImporte.Enabled = False
        Me.txtImporte.Location = New System.Drawing.Point(63, 41)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.ReadOnly = True
        Me.txtImporte.Size = New System.Drawing.Size(100, 20)
        Me.txtImporte.TabIndex = 175
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtConcepto
        '
        Me.txtConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConcepto.Location = New System.Drawing.Point(63, 70)
        Me.txtConcepto.Multiline = True
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(445, 47)
        Me.txtConcepto.TabIndex = 174
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 70)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 173
        Me.Label12.Text = "Concepto:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 41)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 172
        Me.Label11.Text = "Importe:"
        '
        'txtPoliza
        '
        Me.txtPoliza.BackColor = System.Drawing.SystemColors.Control
        Me.txtPoliza.Enabled = False
        Me.txtPoliza.Location = New System.Drawing.Point(63, 12)
        Me.txtPoliza.Name = "txtPoliza"
        Me.txtPoliza.ReadOnly = True
        Me.txtPoliza.Size = New System.Drawing.Size(100, 20)
        Me.txtPoliza.TabIndex = 171
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 170
        Me.Label3.Text = "Folio:"
        '
        'DtpFecha
        '
        Me.DtpFecha.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaptionText
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(288, 15)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(100, 20)
        Me.DtpFecha.TabIndex = 167
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(202, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 166
        Me.Label1.Text = "Fecha Captura:"
        '
        'txtTotalCargo
        '
        Me.txtTotalCargo.Location = New System.Drawing.Point(565, 431)
        Me.txtTotalCargo.Name = "txtTotalCargo"
        Me.txtTotalCargo.ReadOnly = True
        Me.txtTotalCargo.Size = New System.Drawing.Size(92, 20)
        Me.txtTotalCargo.TabIndex = 169
        Me.txtTotalCargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalAbono
        '
        Me.txtTotalAbono.Location = New System.Drawing.Point(662, 431)
        Me.txtTotalAbono.Name = "txtTotalAbono"
        Me.txtTotalAbono.ReadOnly = True
        Me.txtTotalAbono.Size = New System.Drawing.Size(84, 20)
        Me.txtTotalAbono.TabIndex = 170
        Me.txtTotalAbono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiferencia
        '
        Me.txtDiferencia.Location = New System.Drawing.Point(662, 457)
        Me.txtDiferencia.Name = "txtDiferencia"
        Me.txtDiferencia.ReadOnly = True
        Me.txtDiferencia.Size = New System.Drawing.Size(84, 20)
        Me.txtDiferencia.TabIndex = 171
        Me.txtDiferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(591, 460)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 174
        Me.Label2.Text = "Diferencia:"
        '
        'dgvPoliza
        '
        Me.dgvPoliza.AutoGenerateColumns = False
        Me.dgvPoliza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPoliza.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmIdCuentaContable, Me.IdGastoDepartamental, Me.PolizaDataGridViewTextBoxColumn, Me.clmPosicion, Me.clmCuentaContablePri, Me.CtaDataGridViewTextBoxColumn, Me.SCtaDataGridViewTextBoxColumn, Me.SSCtaDataGridViewTextBoxColumn, Me.SSSCtaDataGridViewTextBoxColumn, Me.clmDescripcion, Me.clmConcepto, Me.clmCargo, Me.clmAbono, Me.ImporteDataGridViewTextBoxColumn})
        Me.dgvPoliza.DataSource = Me.PolizaDetalleC
        Me.dgvPoliza.Location = New System.Drawing.Point(55, 173)
        Me.dgvPoliza.MultiSelect = False
        Me.dgvPoliza.Name = "dgvPoliza"
        Me.dgvPoliza.Size = New System.Drawing.Size(844, 252)
        Me.dgvPoliza.TabIndex = 168
        '
        'PolizaDetalleC
        '
        Me.PolizaDetalleC.AllowEdit = True
        Me.PolizaDetalleC.AllowNew = True
        Me.PolizaDetalleC.AllowRemove = True
        Me.PolizaDetalleC.Name = Nothing
        Me.PolizaDetalleC.RaiseListChangedEvents = True
        '
        'clmIdCuentaContable
        '
        Me.clmIdCuentaContable.DataPropertyName = "IdCuentaContable"
        Me.clmIdCuentaContable.HeaderText = "IdCuentaContable"
        Me.clmIdCuentaContable.Name = "clmIdCuentaContable"
        Me.clmIdCuentaContable.Visible = False
        '
        'IdGastoDepartamental
        '
        Me.IdGastoDepartamental.DataPropertyName = "ID_GastoDepartamental"
        Me.IdGastoDepartamental.HeaderText = "IdGastoDepartamental"
        Me.IdGastoDepartamental.Name = "IdGastoDepartamental"
        Me.IdGastoDepartamental.Visible = False
        '
        'PolizaDataGridViewTextBoxColumn
        '
        Me.PolizaDataGridViewTextBoxColumn.DataPropertyName = "Poliza"
        Me.PolizaDataGridViewTextBoxColumn.HeaderText = "Poliza"
        Me.PolizaDataGridViewTextBoxColumn.Name = "PolizaDataGridViewTextBoxColumn"
        Me.PolizaDataGridViewTextBoxColumn.Visible = False
        '
        'clmPosicion
        '
        Me.clmPosicion.DataPropertyName = "Posicion"
        Me.clmPosicion.HeaderText = "Posicion"
        Me.clmPosicion.Name = "clmPosicion"
        Me.clmPosicion.Visible = False
        '
        'clmCuentaContablePri
        '
        Me.clmCuentaContablePri.DataPropertyName = "CuentaContable"
        Me.clmCuentaContablePri.HeaderText = "CuentaContable"
        Me.clmCuentaContablePri.Name = "clmCuentaContablePri"
        Me.clmCuentaContablePri.Visible = False
        '
        'CtaDataGridViewTextBoxColumn
        '
        Me.CtaDataGridViewTextBoxColumn.DataPropertyName = "Cta"
        Me.CtaDataGridViewTextBoxColumn.HeaderText = "Cta"
        Me.CtaDataGridViewTextBoxColumn.Name = "CtaDataGridViewTextBoxColumn"
        Me.CtaDataGridViewTextBoxColumn.Width = 50
        '
        'SCtaDataGridViewTextBoxColumn
        '
        Me.SCtaDataGridViewTextBoxColumn.DataPropertyName = "SCta"
        Me.SCtaDataGridViewTextBoxColumn.HeaderText = "SCta"
        Me.SCtaDataGridViewTextBoxColumn.Name = "SCtaDataGridViewTextBoxColumn"
        Me.SCtaDataGridViewTextBoxColumn.Width = 50
        '
        'SSCtaDataGridViewTextBoxColumn
        '
        Me.SSCtaDataGridViewTextBoxColumn.DataPropertyName = "SSCta"
        Me.SSCtaDataGridViewTextBoxColumn.HeaderText = "SSCta"
        Me.SSCtaDataGridViewTextBoxColumn.Name = "SSCtaDataGridViewTextBoxColumn"
        Me.SSCtaDataGridViewTextBoxColumn.Width = 50
        '
        'SSSCtaDataGridViewTextBoxColumn
        '
        Me.SSSCtaDataGridViewTextBoxColumn.DataPropertyName = "SSSCta"
        Me.SSSCtaDataGridViewTextBoxColumn.HeaderText = "SSSCta"
        Me.SSSCtaDataGridViewTextBoxColumn.Name = "SSSCtaDataGridViewTextBoxColumn"
        Me.SSSCtaDataGridViewTextBoxColumn.Width = 50
        '
        'clmDescripcion
        '
        Me.clmDescripcion.DataPropertyName = "NombreCta"
        Me.clmDescripcion.HeaderText = "Descripción"
        Me.clmDescripcion.Name = "clmDescripcion"
        Me.clmDescripcion.ReadOnly = True
        Me.clmDescripcion.Width = 200
        '
        'clmConcepto
        '
        Me.clmConcepto.DataPropertyName = "Concepto"
        Me.clmConcepto.HeaderText = "Concepto"
        Me.clmConcepto.Name = "clmConcepto"
        '
        'clmCargo
        '
        Me.clmCargo.DataPropertyName = "Cargo"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.clmCargo.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmCargo.HeaderText = "Cargo"
        Me.clmCargo.Name = "clmCargo"
        '
        'clmAbono
        '
        Me.clmAbono.DataPropertyName = "Abono"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.clmAbono.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmAbono.HeaderText = "Abono"
        Me.clmAbono.Name = "clmAbono"
        '
        'ImporteDataGridViewTextBoxColumn
        '
        Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "Importe"
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ImporteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
        Me.ImporteDataGridViewTextBoxColumn.Visible = False
        '
        'PolizaDiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 514)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDiferencia)
        Me.Controls.Add(Me.txtTotalAbono)
        Me.Controls.Add(Me.txtTotalCargo)
        Me.Controls.Add(Me.dgvPoliza)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.mtb)
        Me.Name = "PolizaDiario"
        Me.Text = "Poliza de Diario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvPoliza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtPoliza As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvPoliza As System.Windows.Forms.DataGridView
    Friend WithEvents PolizaDetalleC As ClasesNegocio.PolizaDetalleCollectionClass
    Friend WithEvents txtTotalCargo As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalAbono As System.Windows.Forms.TextBox
    Friend WithEvents txtDiferencia As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents clmIdCuentaContable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdGastoDepartamental As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PolizaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPosicion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCuentaContablePri As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CtaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SCtaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SSCtaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SSSCtaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmConcepto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmAbono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
