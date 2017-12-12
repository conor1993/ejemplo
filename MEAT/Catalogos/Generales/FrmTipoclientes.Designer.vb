<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTipoclientes
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
        Me.lblTema = New System.Windows.Forms.Label()
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar()
        Me.TxtObservacion = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtDescripcionCorta = New System.Windows.Forms.TextBox()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblEstatus = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.clmcodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmdescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDescripcionCorta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTema
        '
        Me.lblTema.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTema.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTema.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTema.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTema.Location = New System.Drawing.Point(0, 0)
        Me.lblTema.Name = "lblTema"
        Me.lblTema.Size = New System.Drawing.Size(765, 29)
        Me.lblTema.TabIndex = 13
        Me.lblTema.Text = "CATÁLOGO TIPOS DE CLIENTES"
        Me.lblTema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.MEAToolBar1.Location = New System.Drawing.Point(5, -29)
        Me.MEAToolBar1.MostrarBorrar = True
        Me.MEAToolBar1.MostrarBuscar = False
        Me.MEAToolBar1.MostrarCancelar = True
        Me.MEAToolBar1.MostrarEditar = True
        Me.MEAToolBar1.MostrarGuardar = True
        Me.MEAToolBar1.MostrarImprimir = True
        Me.MEAToolBar1.MostrarLimpiar = True
        Me.MEAToolBar1.MostrarNuevo = True
        Me.MEAToolBar1.MostrarSalir = True
        Me.MEAToolBar1.Name = "MEAToolBar1"
        Me.MEAToolBar1.ShowToolTips = True
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 747)
        Me.MEAToolBar1.TabIndex = 12
        '
        'TxtObservacion
        '
        Me.TxtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtObservacion.Location = New System.Drawing.Point(114, 84)
        Me.TxtObservacion.MaxLength = 15
        Me.TxtObservacion.Multiline = True
        Me.TxtObservacion.Name = "TxtObservacion"
        Me.TxtObservacion.Size = New System.Drawing.Size(456, 44)
        Me.TxtObservacion.TabIndex = 28
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(114, 6)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(408, 6)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(95, 20)
        Me.dtpFecha.TabIndex = 3
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(114, 58)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(389, 20)
        Me.txtDescripcion.TabIndex = 1
        '
        'txtDescripcionCorta
        '
        Me.txtDescripcionCorta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionCorta.Location = New System.Drawing.Point(114, 32)
        Me.txtDescripcionCorta.MaxLength = 15
        Me.txtDescripcionCorta.Name = "txtDescripcionCorta"
        Me.txtDescripcionCorta.Size = New System.Drawing.Size(192, 20)
        Me.txtDescripcionCorta.TabIndex = 2
        '
        'panel2
        '
        Me.panel2.Controls.Add(Me.TxtObservacion)
        Me.panel2.Controls.Add(Me.Label4)
        Me.panel2.Controls.Add(Me.txtCodigo)
        Me.panel2.Controls.Add(Me.lblEstatus)
        Me.panel2.Controls.Add(Me.dtpFecha)
        Me.panel2.Controls.Add(Me.txtDescripcion)
        Me.panel2.Controls.Add(Me.txtDescripcionCorta)
        Me.panel2.Controls.Add(Me.label5)
        Me.panel2.Controls.Add(Me.label3)
        Me.panel2.Controls.Add(Me.label2)
        Me.panel2.Controls.Add(Me.label1)
        Me.panel2.Location = New System.Drawing.Point(55, 32)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(702, 139)
        Me.panel2.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Observaciones: : "
        '
        'lblEstatus
        '
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblEstatus.Location = New System.Drawing.Point(581, 4)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(112, 23)
        Me.lblEstatus.TabIndex = 26
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(327, 9)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(79, 13)
        Me.label5.TabIndex = 4
        Me.label5.Text = "Fecha de Alta :"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(13, 35)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(100, 13)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Descripción Corta : "
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(13, 61)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(72, 13)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Descripción : "
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(13, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(49, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Código : "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGrid)
        Me.GroupBox1.Location = New System.Drawing.Point(55, 177)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(702, 287)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipos de Clientes"
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.AllowUserToResizeRows = False
        Me.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmcodigo, Me.clmdescripcion, Me.clmDescripcionCorta})
        Me.DataGrid.Location = New System.Drawing.Point(6, 19)
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(690, 261)
        Me.DataGrid.TabIndex = 0
        '
        'clmcodigo
        '
        Me.clmcodigo.DataPropertyName = "Codigo"
        Me.clmcodigo.FillWeight = 10.0!
        Me.clmcodigo.HeaderText = "Codigo"
        Me.clmcodigo.Name = "clmcodigo"
        Me.clmcodigo.ReadOnly = True
        '
        'clmdescripcion
        '
        Me.clmdescripcion.DataPropertyName = "Descripcion"
        Me.clmdescripcion.FillWeight = 50.0!
        Me.clmdescripcion.HeaderText = "Descripcion"
        Me.clmdescripcion.Name = "clmdescripcion"
        Me.clmdescripcion.ReadOnly = True
        '
        'clmDescripcionCorta
        '
        Me.clmDescripcionCorta.DataPropertyName = "DescripcionCorta"
        Me.clmDescripcionCorta.FillWeight = 40.0!
        Me.clmDescripcionCorta.HeaderText = "Descripcion Corta"
        Me.clmDescripcionCorta.Name = "clmDescripcionCorta"
        Me.clmDescripcionCorta.ReadOnly = True
        '
        'FrmTipoclientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 472)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.lblTema)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.Name = "FrmTipoclientes"
        Me.Text = "Tipos de clientes"
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents lblTema As System.Windows.Forms.Label
    Private WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Private WithEvents TxtObservacion As System.Windows.Forms.TextBox
    Private WithEvents txtCodigo As System.Windows.Forms.TextBox
    Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Private WithEvents txtDescripcionCorta As System.Windows.Forms.TextBox
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents clmcodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmdescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDescripcionCorta As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
