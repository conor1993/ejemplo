<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmbarqueCanales
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label17 = New System.Windows.Forms.Label
        Me.mtb = New MiToolBar.miToolBar
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.CmbConductor = New System.Windows.Forms.ComboBox
        Me.CmbTransporte = New System.Windows.Forms.ComboBox
        Me.CmbCliente = New System.Windows.Forms.ComboBox
        Me.CmbPuntoEntrega = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtKilosFrios = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.CmdBuscaCanales = New System.Windows.Forms.Button
        Me.dgvCanales = New System.Windows.Forms.DataGridView
        Me.LoteSacrificio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FolioCanal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KilosCalientes = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KilosBascula = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtFolioCanal = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtTotalCanales = New System.Windows.Forms.TextBox
        Me.txtTotalKilos = New System.Windows.Forms.TextBox
        Me.txtFolioEmbarque = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpFechaEmbarque = New System.Windows.Forms.DateTimePicker
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvCanales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(56, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(624, 32)
        Me.Label17.TabIndex = 49
        Me.Label17.Text = "Canales a Venta"
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
        Me.mtb.ImageButtonSize = MiToolBar.miToolBar.ImageButtonSizeEnum.de32
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
        Me.mtb.Size = New System.Drawing.Size(50, 549)
        Me.mtb.TabIndex = 50
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.CmbConductor)
        Me.GroupBox2.Controls.Add(Me.CmbTransporte)
        Me.GroupBox2.Controls.Add(Me.CmbCliente)
        Me.GroupBox2.Controls.Add(Me.CmbPuntoEntrega)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.txtFolioEmbarque)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.dtpFechaEmbarque)
        Me.GroupBox2.Location = New System.Drawing.Point(56, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(612, 492)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "Punto de Entrega :"
        '
        'CmbConductor
        '
        Me.CmbConductor.FormattingEnabled = True
        Me.CmbConductor.Location = New System.Drawing.Point(106, 108)
        Me.CmbConductor.Name = "CmbConductor"
        Me.CmbConductor.Size = New System.Drawing.Size(285, 21)
        Me.CmbConductor.TabIndex = 89
        '
        'CmbTransporte
        '
        Me.CmbTransporte.FormattingEnabled = True
        Me.CmbTransporte.Location = New System.Drawing.Point(106, 81)
        Me.CmbTransporte.Name = "CmbTransporte"
        Me.CmbTransporte.Size = New System.Drawing.Size(285, 21)
        Me.CmbTransporte.TabIndex = 88
        '
        'CmbCliente
        '
        Me.CmbCliente.FormattingEnabled = True
        Me.CmbCliente.Location = New System.Drawing.Point(106, 54)
        Me.CmbCliente.Name = "CmbCliente"
        Me.CmbCliente.Size = New System.Drawing.Size(285, 21)
        Me.CmbCliente.TabIndex = 87
        '
        'CmbPuntoEntrega
        '
        Me.CmbPuntoEntrega.FormattingEnabled = True
        Me.CmbPuntoEntrega.Location = New System.Drawing.Point(106, 135)
        Me.CmbPuntoEntrega.Name = "CmbPuntoEntrega"
        Me.CmbPuntoEntrega.Size = New System.Drawing.Size(285, 21)
        Me.CmbPuntoEntrega.TabIndex = 91
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Conductor :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "Transporte :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "Cliente :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtKilosFrios)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.CmdBuscaCanales)
        Me.GroupBox4.Controls.Add(Me.dgvCanales)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.txtFolioCanal)
        Me.GroupBox4.Location = New System.Drawing.Point(10, 171)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(596, 288)
        Me.GroupBox4.TabIndex = 83
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Detalle de canales "
        '
        'txtKilosFrios
        '
        Me.txtKilosFrios.AcceptsReturn = True
        Me.txtKilosFrios.BackColor = System.Drawing.SystemColors.Window
        Me.txtKilosFrios.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtKilosFrios.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKilosFrios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKilosFrios.Location = New System.Drawing.Point(424, 19)
        Me.txtKilosFrios.MaxLength = 0
        Me.txtKilosFrios.Name = "txtKilosFrios"
        Me.txtKilosFrios.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtKilosFrios.Size = New System.Drawing.Size(161, 50)
        Me.txtKilosFrios.TabIndex = 86
        Me.txtKilosFrios.Text = "0.00"
        Me.txtKilosFrios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(346, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 13)
        Me.Label10.TabIndex = 85
        Me.Label10.Text = "Kgrs. a Frios :"
        '
        'CmdBuscaCanales
        '
        Me.CmdBuscaCanales.Location = New System.Drawing.Point(277, 23)
        Me.CmdBuscaCanales.Name = "CmdBuscaCanales"
        Me.CmdBuscaCanales.Size = New System.Drawing.Size(63, 25)
        Me.CmdBuscaCanales.TabIndex = 20
        Me.CmdBuscaCanales.Text = "Canales"
        Me.CmdBuscaCanales.UseVisualStyleBackColor = True
        '
        'dgvCanales
        '
        Me.dgvCanales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCanales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LoteSacrificio, Me.FolioCanal, Me.KilosCalientes, Me.KilosBascula})
        Me.dgvCanales.Location = New System.Drawing.Point(6, 84)
        Me.dgvCanales.Name = "dgvCanales"
        Me.dgvCanales.ReadOnly = True
        Me.dgvCanales.RowHeadersVisible = False
        Me.dgvCanales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCanales.Size = New System.Drawing.Size(584, 177)
        Me.dgvCanales.TabIndex = 0
        '
        'LoteSacrificio
        '
        Me.LoteSacrificio.DataPropertyName = "LoteSacrificio"
        Me.LoteSacrificio.HeaderText = "Lote Sacrificio"
        Me.LoteSacrificio.Name = "LoteSacrificio"
        Me.LoteSacrificio.ReadOnly = True
        '
        'FolioCanal
        '
        Me.FolioCanal.DataPropertyName = "FolioCanal"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.FolioCanal.DefaultCellStyle = DataGridViewCellStyle1
        Me.FolioCanal.HeaderText = "Folio Canal"
        Me.FolioCanal.Name = "FolioCanal"
        Me.FolioCanal.ReadOnly = True
        Me.FolioCanal.Width = 120
        '
        'KilosCalientes
        '
        Me.KilosCalientes.DataPropertyName = "KilosCalientes"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.KilosCalientes.DefaultCellStyle = DataGridViewCellStyle2
        Me.KilosCalientes.HeaderText = "Kilos Calientes"
        Me.KilosCalientes.Name = "KilosCalientes"
        Me.KilosCalientes.ReadOnly = True
        Me.KilosCalientes.Width = 180
        '
        'KilosBascula
        '
        Me.KilosBascula.DataPropertyName = "KilosFrios"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.KilosBascula.DefaultCellStyle = DataGridViewCellStyle3
        Me.KilosBascula.HeaderText = "Kilos Bascula"
        Me.KilosBascula.Name = "KilosBascula"
        Me.KilosBascula.ReadOnly = True
        Me.KilosBascula.Width = 180
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Folio Canal :"
        '
        'txtFolioCanal
        '
        Me.txtFolioCanal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFolioCanal.Location = New System.Drawing.Point(83, 19)
        Me.txtFolioCanal.Name = "txtFolioCanal"
        Me.txtFolioCanal.Size = New System.Drawing.Size(188, 29)
        Me.txtFolioCanal.TabIndex = 19
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtTotalCanales)
        Me.GroupBox3.Controls.Add(Me.txtTotalKilos)
        Me.GroupBox3.Location = New System.Drawing.Point(403, 54)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(203, 92)
        Me.GroupBox3.TabIndex = 34
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Totales a Venta :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Canales :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Kilogramos :"
        '
        'txtTotalCanales
        '
        Me.txtTotalCanales.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCanales.Location = New System.Drawing.Point(112, 18)
        Me.txtTotalCanales.Name = "txtTotalCanales"
        Me.txtTotalCanales.Size = New System.Drawing.Size(80, 29)
        Me.txtTotalCanales.TabIndex = 29
        Me.txtTotalCanales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalKilos
        '
        Me.txtTotalKilos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalKilos.Location = New System.Drawing.Point(76, 53)
        Me.txtTotalKilos.Name = "txtTotalKilos"
        Me.txtTotalKilos.Size = New System.Drawing.Size(116, 29)
        Me.txtTotalKilos.TabIndex = 30
        Me.txtTotalKilos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFolioEmbarque
        '
        Me.txtFolioEmbarque.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFolioEmbarque.Location = New System.Drawing.Point(106, 19)
        Me.txtFolioEmbarque.Name = "txtFolioEmbarque"
        Me.txtFolioEmbarque.Size = New System.Drawing.Size(175, 29)
        Me.txtFolioEmbarque.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Folio Embarque :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(307, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Fecha Embarque :"
        '
        'dtpFechaEmbarque
        '
        Me.dtpFechaEmbarque.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFechaEmbarque.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaEmbarque.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaEmbarque.Location = New System.Drawing.Point(407, 19)
        Me.dtpFechaEmbarque.Name = "dtpFechaEmbarque"
        Me.dtpFechaEmbarque.Size = New System.Drawing.Size(131, 29)
        Me.dtpFechaEmbarque.TabIndex = 23
        '
        'FrmEmbarqueCanales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 549)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.Name = "FrmEmbarqueCanales"
        Me.Text = "Canales a Venta"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgvCanales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents mtb As MiToolBar.miToolBar
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvCanales As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTotalCanales As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalKilos As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFolioCanal As System.Windows.Forms.TextBox
    Friend WithEvents txtFolioEmbarque As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaEmbarque As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmdBuscaCanales As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CmbConductor As System.Windows.Forms.ComboBox
    Friend WithEvents CmbTransporte As System.Windows.Forms.ComboBox
    Friend WithEvents CmbCliente As System.Windows.Forms.ComboBox
    Friend WithEvents CmbPuntoEntrega As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LoteSacrificio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FolioCanal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosCalientes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosBascula As System.Windows.Forms.DataGridViewTextBoxColumn
    Public WithEvents txtKilosFrios As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
