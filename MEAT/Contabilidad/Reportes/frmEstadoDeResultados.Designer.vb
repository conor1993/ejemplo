<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstadodeResultados
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
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem7 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem8 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem9 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem10 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem11 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem12 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstadodeResultados))
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ultcmbMes = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.dgvCuentasContables = New System.Windows.Forms.DataGridView()
        Me.clmCodigoCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCuentaDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCodigoTitulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDescripcionTitulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCodigoSubtitulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDescripcionSubtitulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmSaldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintBalance = New System.Drawing.Printing.PrintDocument()
        Me.ppDg = New System.Windows.Forms.PrintPreviewDialog()
        Me.pDg = New System.Windows.Forms.PrintDialog()
        CType(Me.ultcmbMes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCuentasContables, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MEAToolBar1.Location = New System.Drawing.Point(0, -58)
        Me.MEAToolBar1.MostrarBorrar = False
        Me.MEAToolBar1.MostrarBuscar = False
        Me.MEAToolBar1.MostrarCancelar = False
        Me.MEAToolBar1.MostrarEditar = False
        Me.MEAToolBar1.MostrarGuardar = False
        Me.MEAToolBar1.MostrarImprimir = True
        Me.MEAToolBar1.MostrarLimpiar = True
        Me.MEAToolBar1.MostrarNuevo = False
        Me.MEAToolBar1.MostrarSalir = True
        Me.MEAToolBar1.Name = "MEAToolBar1"
        Me.MEAToolBar1.ShowToolTips = True
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 266)
        Me.MEAToolBar1.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(56, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Mes a Generar:"
        '
        'ultcmbMes
        '
        Me.ultcmbMes.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        ValueListItem1.DataValue = CType(1, Byte)
        ValueListItem1.DisplayText = "ENERO"
        ValueListItem2.DataValue = CType(2, Byte)
        ValueListItem2.DisplayText = "FEBRERO"
        ValueListItem3.DataValue = CType(3, Byte)
        ValueListItem3.DisplayText = "MARZO"
        ValueListItem4.DataValue = CType(4, Byte)
        ValueListItem4.DisplayText = "ABRIL"
        ValueListItem5.DataValue = CType(5, Byte)
        ValueListItem5.DisplayText = "MAYO"
        ValueListItem6.DataValue = CType(6, Byte)
        ValueListItem6.DisplayText = "JUNIO"
        ValueListItem7.DataValue = CType(7, Byte)
        ValueListItem7.DisplayText = "JULIO"
        ValueListItem8.DataValue = CType(8, Byte)
        ValueListItem8.DisplayText = "AGOSTO"
        ValueListItem9.DataValue = CType(9, Byte)
        ValueListItem9.DisplayText = "SEPTIEMBRE"
        ValueListItem10.DataValue = CType(10, Byte)
        ValueListItem10.DisplayText = "OCTUBRE"
        ValueListItem11.DataValue = CType(11, Byte)
        ValueListItem11.DisplayText = "NOVIEMBRE"
        ValueListItem12.DataValue = CType(12, Byte)
        ValueListItem12.DisplayText = "DICIEMBRE"
        Me.ultcmbMes.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2, ValueListItem3, ValueListItem4, ValueListItem5, ValueListItem6, ValueListItem7, ValueListItem8, ValueListItem9, ValueListItem10, ValueListItem11, ValueListItem12})
        Me.ultcmbMes.Location = New System.Drawing.Point(169, 72)
        Me.ultcmbMes.Name = "ultcmbMes"
        Me.ultcmbMes.NullText = "Seleccione el Mes"
        Me.ultcmbMes.Size = New System.Drawing.Size(121, 21)
        Me.ultcmbMes.TabIndex = 41
        Me.ultcmbMes.Text = "Seleccione el Mes"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(74, 111)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(201, 20)
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
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
        Me.lblTitulo.TabIndex = 44
        Me.lblTitulo.Text = "Estado de Resultados"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvCuentasContables
        '
        Me.dgvCuentasContables.AllowUserToAddRows = False
        Me.dgvCuentasContables.AllowUserToDeleteRows = False
        Me.dgvCuentasContables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCuentasContables.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmCodigoCuenta, Me.clmCuentaDescripcion, Me.clmCodigoTitulo, Me.clmDescripcionTitulo, Me.clmCodigoSubtitulo, Me.clmDescripcionSubtitulo, Me.clmSaldo})
        Me.dgvCuentasContables.Location = New System.Drawing.Point(213, 127)
        Me.dgvCuentasContables.Name = "dgvCuentasContables"
        Me.dgvCuentasContables.Size = New System.Drawing.Size(752, 253)
        Me.dgvCuentasContables.TabIndex = 45
        Me.dgvCuentasContables.Visible = False
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
        'PrintBalance
        '
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
        'frmEstadodeResultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 213)
        Me.Controls.Add(Me.dgvCuentasContables)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ultcmbMes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.Name = "frmEstadodeResultados"
        Me.Text = "Estado de Resultados"
        CType(Me.ultcmbMes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCuentasContables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ultcmbMes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents dgvCuentasContables As System.Windows.Forms.DataGridView
    Friend WithEvents clmCodigoCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCuentaDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCodigoTitulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDescripcionTitulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCodigoSubtitulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDescripcionSubtitulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSaldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrintBalance As System.Drawing.Printing.PrintDocument
    Friend WithEvents ppDg As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents pDg As System.Windows.Forms.PrintDialog
End Class
