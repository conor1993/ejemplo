<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBalanceGeneral
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
        Me.components = New System.ComponentModel.Container()
        Dim ValueListItem13 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem14 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem15 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem16 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem17 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem18 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem19 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem20 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem21 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem22 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem23 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem24 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBalanceGeneral))
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ultcmbMes = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.ppDg = New System.Windows.Forms.PrintPreviewDialog()
        Me.pDg = New System.Windows.Forms.PrintDialog()
        Me.PrintBalance = New System.Drawing.Printing.PrintDocument()
        Me.dgvCuentasContables = New System.Windows.Forms.DataGridView()
        Me.clmCodigoCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCuentaDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCodigoTitulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDescripcionTitulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCodigoSubtitulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDescripcionSubtitulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmSaldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ultCmbEjercicio = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        CType(Me.ultcmbMes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCuentasContables, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ultCmbEjercicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MEAToolBar1
        '
        Me.MEAToolBar1.ButtonSize = New System.Drawing.Size(50, 50)
        Me.MEAToolBar1.Dock = System.Windows.Forms.DockStyle.None
        Me.MEAToolBar1.DropDownArrows = True
        Me.MEAToolBar1.HabilitarBorrar = True
        Me.MEAToolBar1.HabilitarBuscar = True
        Me.MEAToolBar1.HabilitarCancelar = True
        Me.MEAToolBar1.HabilitarEditar = True
        Me.MEAToolBar1.HabilitarGuardar = True
        Me.MEAToolBar1.HabilitarImprimir = True
        Me.MEAToolBar1.HabilitarLimpiar = True
        Me.MEAToolBar1.HabilitarNuevo = True
        Me.MEAToolBar1.HabilitarSalir = True
        Me.MEAToolBar1.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32
        Me.MEAToolBar1.Location = New System.Drawing.Point(0, 4)
        Me.MEAToolBar1.MostrarBorrar = False
        Me.MEAToolBar1.MostrarBuscar = False
        Me.MEAToolBar1.MostrarCancelar = False
        Me.MEAToolBar1.MostrarEditar = False
        Me.MEAToolBar1.MostrarGuardar = False
        Me.MEAToolBar1.MostrarImprimir = False
        Me.MEAToolBar1.MostrarLimpiar = True
        Me.MEAToolBar1.MostrarNuevo = False
        Me.MEAToolBar1.MostrarSalir = True
        Me.MEAToolBar1.Name = "MEAToolBar1"
        Me.MEAToolBar1.ShowToolTips = True
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 162)
        Me.MEAToolBar1.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(56, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 17)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Mes:"
        '
        'ultcmbMes
        '
        Me.ultcmbMes.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        ValueListItem13.DataValue = CType(1, Byte)
        ValueListItem13.DisplayText = "ENERO"
        ValueListItem14.DataValue = CType(2, Byte)
        ValueListItem14.DisplayText = "FEBRERO"
        ValueListItem15.DataValue = CType(3, Byte)
        ValueListItem15.DisplayText = "MARZO"
        ValueListItem16.DataValue = CType(4, Byte)
        ValueListItem16.DisplayText = "ABRIL"
        ValueListItem17.DataValue = CType(5, Byte)
        ValueListItem17.DisplayText = "MAYO"
        ValueListItem18.DataValue = CType(6, Byte)
        ValueListItem18.DisplayText = "JUNIO"
        ValueListItem19.DataValue = CType(7, Byte)
        ValueListItem19.DisplayText = "JULIO"
        ValueListItem20.DataValue = CType(8, Byte)
        ValueListItem20.DisplayText = "AGOSTO"
        ValueListItem21.DataValue = CType(9, Byte)
        ValueListItem21.DisplayText = "SEPTIEMBRE"
        ValueListItem22.DataValue = CType(10, Byte)
        ValueListItem22.DisplayText = "OCTUBRE"
        ValueListItem23.DataValue = CType(11, Byte)
        ValueListItem23.DisplayText = "NOVIEMBRE"
        ValueListItem24.DataValue = CType(12, Byte)
        ValueListItem24.DisplayText = "DICIEMBRE"
        Me.ultcmbMes.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem13, ValueListItem14, ValueListItem15, ValueListItem16, ValueListItem17, ValueListItem18, ValueListItem19, ValueListItem20, ValueListItem21, ValueListItem22, ValueListItem23, ValueListItem24})
        Me.ultcmbMes.Location = New System.Drawing.Point(100, 44)
        Me.ultcmbMes.Name = "ultcmbMes"
        Me.ultcmbMes.NullText = "Seleccione el Mes"
        Me.ultcmbMes.Size = New System.Drawing.Size(150, 21)
        Me.ultcmbMes.TabIndex = 41
        Me.ultcmbMes.Text = "Seleccione el Mes"
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(53, 0)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(265, 29)
        Me.lblTitulo.TabIndex = 43
        Me.lblTitulo.Text = "BALANCE GENERAL"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ppDg
        '
        Me.ppDg.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.ppDg.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.ppDg.ClientSize = New System.Drawing.Size(400, 300)
        Me.ppDg.Enabled = True
        Me.ppDg.Icon = CType(resources.GetObject("ppDg.Icon"), System.Drawing.Icon)
        Me.ppDg.Name = "ppDg"
        Me.ppDg.Visible = False
        '
        'pDg
        '
        Me.pDg.UseEXDialog = True
        '
        'PrintBalance
        '
        '
        'dgvCuentasContables
        '
        Me.dgvCuentasContables.AllowUserToAddRows = False
        Me.dgvCuentasContables.AllowUserToDeleteRows = False
        Me.dgvCuentasContables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCuentasContables.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmCodigoCuenta, Me.clmCuentaDescripcion, Me.clmCodigoTitulo, Me.clmDescripcionTitulo, Me.clmCodigoSubtitulo, Me.clmDescripcionSubtitulo, Me.clmSaldo})
        Me.dgvCuentasContables.Location = New System.Drawing.Point(0, 170)
        Me.dgvCuentasContables.Name = "dgvCuentasContables"
        Me.dgvCuentasContables.Size = New System.Drawing.Size(579, 241)
        Me.dgvCuentasContables.TabIndex = 44
        '
        'clmCodigoCuenta
        '
        Me.clmCodigoCuenta.DataPropertyName = "Codigo"
        Me.clmCodigoCuenta.HeaderText = "Codigo"
        Me.clmCodigoCuenta.Name = "clmCodigoCuenta"
        '
        'clmCuentaDescripcion
        '
        Me.clmCuentaDescripcion.DataPropertyName = "NomCuenta"
        Me.clmCuentaDescripcion.HeaderText = "Descripcion"
        Me.clmCuentaDescripcion.Name = "clmCuentaDescripcion"
        '
        'clmCodigoTitulo
        '
        Me.clmCodigoTitulo.DataPropertyName = "Titulo"
        Me.clmCodigoTitulo.HeaderText = "CodTitulo"
        Me.clmCodigoTitulo.Name = "clmCodigoTitulo"
        '
        'clmDescripcionTitulo
        '
        Me.clmDescripcionTitulo.DataPropertyName = "TituloDes"
        Me.clmDescripcionTitulo.HeaderText = "Titulo"
        Me.clmDescripcionTitulo.Name = "clmDescripcionTitulo"
        '
        'clmCodigoSubtitulo
        '
        Me.clmCodigoSubtitulo.DataPropertyName = "Subtitulo"
        Me.clmCodigoSubtitulo.HeaderText = "CodSubtitulo"
        Me.clmCodigoSubtitulo.Name = "clmCodigoSubtitulo"
        '
        'clmDescripcionSubtitulo
        '
        Me.clmDescripcionSubtitulo.DataPropertyName = "Subtitulodes"
        Me.clmDescripcionSubtitulo.HeaderText = "Descripion"
        Me.clmDescripcionSubtitulo.Name = "clmDescripcionSubtitulo"
        '
        'clmSaldo
        '
        Me.clmSaldo.HeaderText = "Saldo"
        Me.clmSaldo.Name = "clmSaldo"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(116, 127)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 37)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Generar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(56, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 17)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Año:"
        '
        'ultCmbEjercicio
        '
        Me.ultCmbEjercicio.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.ultCmbEjercicio.DisplayMember = "Ejercicio"
        Me.ultCmbEjercicio.Location = New System.Drawing.Point(100, 79)
        Me.ultCmbEjercicio.Name = "ultCmbEjercicio"
        Me.ultCmbEjercicio.NullText = "Seleccione el Mes"
        Me.ultCmbEjercicio.Size = New System.Drawing.Size(150, 21)
        Me.ultCmbEjercicio.TabIndex = 47
        Me.ultCmbEjercicio.Text = "Seleccione el Año"
        Me.ultCmbEjercicio.ValueMember = "Ejercicio"
        '
        'frmBalanceGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 414)
        Me.Controls.Add(Me.ultCmbEjercicio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvCuentasContables)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.ultcmbMes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.Name = "frmBalanceGeneral"
        Me.Text = "Balance General"
        CType(Me.ultcmbMes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCuentasContables, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ultCmbEjercicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ultcmbMes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents ppDg As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents pDg As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintBalance As System.Drawing.Printing.PrintDocument
    Friend WithEvents dgvCuentasContables As System.Windows.Forms.DataGridView
    Friend WithEvents clmCodigoCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCuentaDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCodigoTitulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDescripcionTitulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCodigoSubtitulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDescripcionSubtitulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSaldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ultCmbEjercicio As Infragistics.Win.UltraWinEditors.UltraComboEditor
End Class
