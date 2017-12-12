<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSubLinea
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.CmbLinea = New System.Windows.Forms.ComboBox
        Me.LineaCollectionClass1 = New ClasesNegocio.LineaCollectionClass
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.TxtObservacion = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDescCorta = New System.Windows.Forms.TextBox
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGrid = New System.Windows.Forms.DataGridView
        Me.ClmCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmDescripcionCorta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmLinea = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmFechaAlta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubLineaCollectionClass1 = New ClasesNegocio.SubLineaCollectionClass
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(55, 0)
        Me.Label1.MaximumSize = New System.Drawing.Size(1800, 1800)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(710, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ABC DE SUB-LINEAS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.DtpFecha)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.CmbLinea)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.lblEstatus)
        Me.Panel1.Controls.Add(Me.TxtObservacion)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtDescCorta)
        Me.Panel1.Controls.Add(Me.txtDescripcion)
        Me.Panel1.Controls.Add(Me.txtCodigo)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(56, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(695, 166)
        Me.Panel1.TabIndex = 2
        '
        'DtpFecha
        '
        Me.DtpFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtpFecha.Enabled = False
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(449, 3)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(104, 20)
        Me.DtpFecha.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(367, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Fecha de Alta:"
        '
        'CmbLinea
        '
        Me.CmbLinea.DataSource = Me.LineaCollectionClass1
        Me.CmbLinea.DisplayMember = "Descripcion"
        Me.CmbLinea.FormattingEnabled = True
        Me.CmbLinea.Location = New System.Drawing.Point(101, 81)
        Me.CmbLinea.Name = "CmbLinea"
        Me.CmbLinea.Size = New System.Drawing.Size(318, 21)
        Me.CmbLinea.TabIndex = 10
        Me.CmbLinea.ValueMember = "Codigo"
        '
        'LineaCollectionClass1
        '
        Me.LineaCollectionClass1.AllowEdit = True
        Me.LineaCollectionClass1.AllowNew = True
        Me.LineaCollectionClass1.AllowRemove = True
        Me.LineaCollectionClass1.Name = ""
        Me.LineaCollectionClass1.RaiseListChangedEvents = True
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Linea:"
        '
        'lblEstatus
        '
        Me.lblEstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(603, 3)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(86, 21)
        Me.lblEstatus.TabIndex = 4
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEstatus.Visible = False
        '
        'TxtObservacion
        '
        Me.TxtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtObservacion.Location = New System.Drawing.Point(101, 108)
        Me.TxtObservacion.MaxLength = 250
        Me.TxtObservacion.Multiline = True
        Me.TxtObservacion.Name = "TxtObservacion"
        Me.TxtObservacion.Size = New System.Drawing.Size(454, 50)
        Me.TxtObservacion.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Observaciones:"
        '
        'txtDescCorta
        '
        Me.txtDescCorta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescCorta.Location = New System.Drawing.Point(101, 55)
        Me.txtDescCorta.MaxLength = 50
        Me.txtDescCorta.Name = "txtDescCorta"
        Me.txtDescCorta.Size = New System.Drawing.Size(211, 20)
        Me.txtDescCorta.TabIndex = 8
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(101, 29)
        Me.txtDescripcion.MaxLength = 80
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(454, 20)
        Me.txtDescripcion.TabIndex = 6
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(101, 3)
        Me.txtCodigo.MaxLength = 4
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(74, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Descripción Corta:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Descripción:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Código:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DataGrid)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(56, 207)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(695, 300)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sub-Lineas Registradas"
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.AllowUserToResizeRows = False
        Me.DataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClmCodigo, Me.ClmDescripcion, Me.ClmDescripcionCorta, Me.ClmLinea, Me.ClmObservaciones, Me.ClmFechaAlta, Me.ClmEstatus})
        Me.DataGrid.Location = New System.Drawing.Point(6, 23)
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGrid.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(683, 271)
        Me.DataGrid.TabIndex = 0
        '
        'ClmCodigo
        '
        Me.ClmCodigo.HeaderText = "Código"
        Me.ClmCodigo.Name = "ClmCodigo"
        Me.ClmCodigo.ReadOnly = True
        Me.ClmCodigo.Width = 85
        '
        'ClmDescripcion
        '
        Me.ClmDescripcion.HeaderText = "Descripción"
        Me.ClmDescripcion.Name = "ClmDescripcion"
        Me.ClmDescripcion.ReadOnly = True
        Me.ClmDescripcion.Width = 250
        '
        'ClmDescripcionCorta
        '
        Me.ClmDescripcionCorta.HeaderText = "Descripción Corta"
        Me.ClmDescripcionCorta.Name = "ClmDescripcionCorta"
        Me.ClmDescripcionCorta.ReadOnly = True
        Me.ClmDescripcionCorta.Width = 200
        '
        'ClmLinea
        '
        Me.ClmLinea.HeaderText = "Línea"
        Me.ClmLinea.Name = "ClmLinea"
        Me.ClmLinea.ReadOnly = True
        Me.ClmLinea.Width = 200
        '
        'ClmObservaciones
        '
        Me.ClmObservaciones.HeaderText = "Observaciones"
        Me.ClmObservaciones.Name = "ClmObservaciones"
        Me.ClmObservaciones.ReadOnly = True
        Me.ClmObservaciones.Width = 200
        '
        'ClmFechaAlta
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.ClmFechaAlta.DefaultCellStyle = DataGridViewCellStyle1
        Me.ClmFechaAlta.HeaderText = "Fecha de Alta"
        Me.ClmFechaAlta.Name = "ClmFechaAlta"
        Me.ClmFechaAlta.ReadOnly = True
        Me.ClmFechaAlta.Width = 150
        '
        'ClmEstatus
        '
        Me.ClmEstatus.HeaderText = "Estatus"
        Me.ClmEstatus.Name = "ClmEstatus"
        Me.ClmEstatus.ReadOnly = True
        Me.ClmEstatus.Width = 85
        '
        'SubLineaCollectionClass1
        '
        Me.SubLineaCollectionClass1.AllowEdit = True
        Me.SubLineaCollectionClass1.AllowNew = True
        Me.SubLineaCollectionClass1.AllowRemove = True
        Me.SubLineaCollectionClass1.Name = ""
        Me.SubLineaCollectionClass1.RaiseListChangedEvents = True
        '
        'MEAToolBar1
        '
        Me.MEAToolBar1.ButtonSize = New System.Drawing.Size(50, 50)
        Me.MEAToolBar1.Dock = System.Windows.Forms.DockStyle.Left
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
        Me.MEAToolBar1.Location = New System.Drawing.Point(0, 0)
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
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 519)
        Me.MEAToolBar1.TabIndex = 0
        '
        'FrmSubLinea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 519)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(771, 553)
        Me.MinimumSize = New System.Drawing.Size(637, 542)
        Me.Name = "FrmSubLinea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABC de Sub-Lineas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents TxtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescCorta As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmbLinea As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents SubLineaCollectionClass1 As ClasesNegocio.SubLineaCollectionClass
    Friend WithEvents LineaCollectionClass1 As ClasesNegocio.LineaCollectionClass
    Friend WithEvents ClmCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmDescripcionCorta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmLinea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmObservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmFechaAlta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
