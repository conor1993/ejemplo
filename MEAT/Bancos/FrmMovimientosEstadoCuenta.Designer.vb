<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMovimientosEstadoCuenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMovimientosEstadoCuenta))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbBanco = New System.Windows.Forms.ComboBox
        Me.BancosC = New ClasesNegocio.BancosCollectionClass
        Me.cmbCuenta = New System.Windows.Forms.ComboBox
        Me.dgvMovEstadoCuenta = New System.Windows.Forms.DataGridView
        Me.clmIdMveCta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIdCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFecha = New Infragistics.Win.UltraDataGridView.UltraDateTimeEditorColumn(Me.components)
        Me.clmReferenci = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmConcepto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmTipoMov = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmImporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmConciliar = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.dgvMovEstadoCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(673, 29)
        Me.lblTitulo.TabIndex = 4
        Me.lblTitulo.Text = "Captura Moviemientos de Estado de Cuenta"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.mtb.Location = New System.Drawing.Point(3, -27)
        Me.mtb.MostrarBorrar = False
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = False
        Me.mtb.MostrarEditar = True
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 519)
        Me.mtb.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(333, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Cta. Bancaria"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(94, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Banco"
        '
        'cmbBanco
        '
        Me.cmbBanco.DataSource = Me.BancosC
        Me.cmbBanco.DisplayMember = "Descripcion"
        Me.cmbBanco.FormattingEnabled = True
        Me.cmbBanco.Location = New System.Drawing.Point(138, 52)
        Me.cmbBanco.Name = "cmbBanco"
        Me.cmbBanco.Size = New System.Drawing.Size(156, 21)
        Me.cmbBanco.TabIndex = 64
        '
        'BancosC
        '
        Me.BancosC.AllowEdit = True
        Me.BancosC.AllowNew = True
        Me.BancosC.AllowRemove = True
        Me.BancosC.Name = ""
        Me.BancosC.RaiseListChangedEvents = True
        '
        'cmbCuenta
        '
        Me.cmbCuenta.FormattingEnabled = True
        Me.cmbCuenta.Location = New System.Drawing.Point(410, 52)
        Me.cmbCuenta.Name = "cmbCuenta"
        Me.cmbCuenta.Size = New System.Drawing.Size(160, 21)
        Me.cmbCuenta.TabIndex = 65
        '
        'dgvMovEstadoCuenta
        '
        Me.dgvMovEstadoCuenta.AllowUserToAddRows = False
        Me.dgvMovEstadoCuenta.AllowUserToDeleteRows = False
        Me.dgvMovEstadoCuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMovEstadoCuenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmIdMveCta, Me.clmIdCuenta, Me.clmFecha, Me.clmReferenci, Me.clmConcepto, Me.clmTipoMov, Me.clmImporte, Me.clmConciliar})
        Me.dgvMovEstadoCuenta.Location = New System.Drawing.Point(59, 79)
        Me.dgvMovEstadoCuenta.MultiSelect = False
        Me.dgvMovEstadoCuenta.Name = "dgvMovEstadoCuenta"
        Me.dgvMovEstadoCuenta.RowHeadersVisible = False
        Me.dgvMovEstadoCuenta.Size = New System.Drawing.Size(605, 257)
        Me.dgvMovEstadoCuenta.TabIndex = 66
        '
        'clmIdMveCta
        '
        Me.clmIdMveCta.DataPropertyName = "IdMveCta"
        Me.clmIdMveCta.HeaderText = "IdMveCta"
        Me.clmIdMveCta.Name = "clmIdMveCta"
        Me.clmIdMveCta.ReadOnly = True
        Me.clmIdMveCta.Visible = False
        '
        'clmIdCuenta
        '
        Me.clmIdCuenta.DataPropertyName = "IdCuenta"
        Me.clmIdCuenta.HeaderText = "Id Cuenta"
        Me.clmIdCuenta.Name = "clmIdCuenta"
        Me.clmIdCuenta.ReadOnly = True
        Me.clmIdCuenta.Visible = False
        '
        'clmFecha
        '
        Me.clmFecha.DataPropertyName = "Fecha"
        Me.clmFecha.DefaultNewRowValue = CType(resources.GetObject("clmFecha.DefaultNewRowValue"), Object)
        Me.clmFecha.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.WindowsVista
        Me.clmFecha.DropDownCalendarAlignment = Infragistics.Win.DropDownListAlignment.Right
        Me.clmFecha.HeaderText = "Fecha"
        Me.clmFecha.MaskInput = Nothing
        Me.clmFecha.Name = "clmFecha"
        Me.clmFecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clmFecha.SpinButtonAlignment = Infragistics.Win.SpinButtonDisplayStyle.None
        '
        'clmReferenci
        '
        Me.clmReferenci.DataPropertyName = "Referencia"
        Me.clmReferenci.HeaderText = "Referencia"
        Me.clmReferenci.Name = "clmReferenci"
        '
        'clmConcepto
        '
        Me.clmConcepto.DataPropertyName = "Concepto"
        Me.clmConcepto.HeaderText = "Concepto"
        Me.clmConcepto.Name = "clmConcepto"
        Me.clmConcepto.Width = 170
        '
        'clmTipoMov
        '
        Me.clmTipoMov.DataPropertyName = "TipoMovimiento"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.clmTipoMov.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmTipoMov.HeaderText = "Tipo Movto."
        Me.clmTipoMov.Name = "clmTipoMov"
        Me.clmTipoMov.Width = 90
        '
        'clmImporte
        '
        Me.clmImporte.DataPropertyName = "Importe"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.clmImporte.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmImporte.HeaderText = "Importe"
        Me.clmImporte.Name = "clmImporte"
        Me.clmImporte.Width = 80
        '
        'clmConciliar
        '
        Me.clmConciliar.DataPropertyName = "Conciliado"
        Me.clmConciliar.HeaderText = "Conciliar"
        Me.clmConciliar.Name = "clmConciliar"
        Me.clmConciliar.Width = 55
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(407, 342)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 13)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "D: Deposito        R: Retiro"
        '
        'FrmMovimientosEstadoCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 364)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.dgvMovEstadoCuenta)
        Me.Controls.Add(Me.cmbCuenta)
        Me.Controls.Add(Me.cmbBanco)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mtb)
        Me.Name = "FrmMovimientosEstadoCuenta"
        Me.Text = "Movimientos de Estado de Cuenta"
        CType(Me.dgvMovEstadoCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbBanco As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents BancosC As ClasesNegocio.BancosCollectionClass
    Friend WithEvents dgvMovEstadoCuenta As System.Windows.Forms.DataGridView
    Friend WithEvents clmIdMveCta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFecha As Infragistics.Win.UltraDataGridView.UltraDateTimeEditorColumn
    Friend WithEvents clmReferenci As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmConcepto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTipoMov As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmConciliar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
