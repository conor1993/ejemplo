<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSucursal
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtDescripcionCorta = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.lblEstatus = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.cmbPlaza = New System.Windows.Forms.ComboBox()
        Me.PlazaCol = New ClasesNegocio.PlazaCollectionClass()
        Me.label6 = New System.Windows.Forms.Label()
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.PanelSucursales = New System.Windows.Forms.Panel()
        Me.cmbSerieFactura = New System.Windows.Forms.ComboBox()
        Me.FacturaFoliosCol = New ClasesNegocio.FacturaFoliosCollectionClass()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkActivar = New System.Windows.Forms.CheckBox()
        Me.txtLetras = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.lblTema = New System.Windows.Forms.Label()
        Me.SucursalCol = New ClasesNegocio.SucursalCollectionClass()
        Me.gbSucursales = New System.Windows.Forms.GroupBox()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.ClmCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmDescripcionCorta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmPlaza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmFechaAlta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelSucursales.SuspendLayout()
        Me.gbSucursales.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDescripcionCorta
        '
        Me.txtDescripcionCorta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionCorta.Location = New System.Drawing.Point(114, 90)
        Me.txtDescripcionCorta.MaxLength = 15
        Me.txtDescripcionCorta.Name = "txtDescripcionCorta"
        Me.txtDescripcionCorta.Size = New System.Drawing.Size(211, 20)
        Me.txtDescripcionCorta.TabIndex = 5
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(298, 14)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(82, 13)
        Me.label5.TabIndex = 4
        Me.label5.Text = "Fecha de Alta : "
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(8, 125)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(87, 13)
        Me.label4.TabIndex = 3
        Me.label4.Text = "Observaciones : "
        '
        'lblEstatus
        '
        Me.lblEstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblEstatus.Location = New System.Drawing.Point(590, 8)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(91, 21)
        Me.lblEstatus.TabIndex = 0
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEstatus.Visible = False
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Location = New System.Drawing.Point(114, 116)
        Me.txtObservaciones.MaxLength = 250
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(473, 67)
        Me.txtObservaciones.TabIndex = 6
        '
        'cmbPlaza
        '
        Me.cmbPlaza.DataSource = Me.PlazaCol
        Me.cmbPlaza.DisplayMember = "Descripcion"
        Me.cmbPlaza.FormattingEnabled = True
        Me.cmbPlaza.Location = New System.Drawing.Point(114, 37)
        Me.cmbPlaza.Name = "cmbPlaza"
        Me.cmbPlaza.Size = New System.Drawing.Size(360, 21)
        Me.cmbPlaza.TabIndex = 3
        Me.cmbPlaza.ValueMember = "Codigo"
        '
        'PlazaCol
        '
        Me.PlazaCol.AllowEdit = True
        Me.PlazaCol.AllowNew = True
        Me.PlazaCol.AllowRemove = True
        Me.PlazaCol.MaximoElementosSeleccionados = 1
        Me.PlazaCol.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.PlazaCol.MostrarAlertas = False
        Me.PlazaCol.Name = ""
        Me.PlazaCol.RaiseListChangedEvents = True
        Me.PlazaCol.Transaction = Nothing
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(8, 40)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(42, 13)
        Me.label6.TabIndex = 0
        Me.label6.Text = "Plaza : "
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
        Me.MEAToolBar1.Location = New System.Drawing.Point(0, -27)
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
        Me.MEAToolBar1.TabIndex = 0
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(371, 10)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(103, 20)
        Me.dtpFecha.TabIndex = 2
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(114, 64)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(473, 20)
        Me.txtDescripcion.TabIndex = 4
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Location = New System.Drawing.Point(114, 10)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'PanelSucursales
        '
        Me.PanelSucursales.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelSucursales.Controls.Add(Me.cmbSerieFactura)
        Me.PanelSucursales.Controls.Add(Me.Label8)
        Me.PanelSucursales.Controls.Add(Me.chkActivar)
        Me.PanelSucursales.Controls.Add(Me.txtLetras)
        Me.PanelSucursales.Controls.Add(Me.Label7)
        Me.PanelSucursales.Controls.Add(Me.lblEstatus)
        Me.PanelSucursales.Controls.Add(Me.txtObservaciones)
        Me.PanelSucursales.Controls.Add(Me.cmbPlaza)
        Me.PanelSucursales.Controls.Add(Me.label6)
        Me.PanelSucursales.Controls.Add(Me.dtpFecha)
        Me.PanelSucursales.Controls.Add(Me.txtDescripcion)
        Me.PanelSucursales.Controls.Add(Me.txtCodigo)
        Me.PanelSucursales.Controls.Add(Me.txtDescripcionCorta)
        Me.PanelSucursales.Controls.Add(Me.label5)
        Me.PanelSucursales.Controls.Add(Me.label4)
        Me.PanelSucursales.Controls.Add(Me.label3)
        Me.PanelSucursales.Controls.Add(Me.label2)
        Me.PanelSucursales.Controls.Add(Me.label1)
        Me.PanelSucursales.Location = New System.Drawing.Point(51, 32)
        Me.PanelSucursales.Name = "PanelSucursales"
        Me.PanelSucursales.Size = New System.Drawing.Size(691, 190)
        Me.PanelSucursales.TabIndex = 2
        '
        'cmbSerieFactura
        '
        Me.cmbSerieFactura.DataSource = Me.FacturaFoliosCol
        Me.cmbSerieFactura.DisplayMember = "StaLetraSerie"
        Me.cmbSerieFactura.FormattingEnabled = True
        Me.cmbSerieFactura.Location = New System.Drawing.Point(528, 89)
        Me.cmbSerieFactura.Name = "cmbSerieFactura"
        Me.cmbSerieFactura.Size = New System.Drawing.Size(59, 21)
        Me.cmbSerieFactura.TabIndex = 11
        Me.cmbSerieFactura.ValueMember = "IdFacturaFolios"
        Me.cmbSerieFactura.Visible = False
        '
        'FacturaFoliosCol
        '
        Me.FacturaFoliosCol.AllowEdit = True
        Me.FacturaFoliosCol.AllowNew = True
        Me.FacturaFoliosCol.AllowRemove = True
        Me.FacturaFoliosCol.MaximoElementosSeleccionados = 1
        Me.FacturaFoliosCol.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.FacturaFoliosCol.MostrarAlertas = False
        Me.FacturaFoliosCol.Name = Nothing
        Me.FacturaFoliosCol.RaiseListChangedEvents = True
        Me.FacturaFoliosCol.Transaction = Nothing
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(449, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Serie Factura:"
        Me.Label8.Visible = False
        '
        'chkActivar
        '
        Me.chkActivar.AutoSize = True
        Me.chkActivar.Location = New System.Drawing.Point(528, 41)
        Me.chkActivar.Name = "chkActivar"
        Me.chkActivar.Size = New System.Drawing.Size(59, 17)
        Me.chkActivar.TabIndex = 9
        Me.chkActivar.Text = "Activar"
        Me.chkActivar.UseVisualStyleBackColor = True
        '
        'txtLetras
        '
        Me.txtLetras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLetras.Location = New System.Drawing.Point(376, 90)
        Me.txtLetras.MaxLength = 2
        Me.txtLetras.Name = "txtLetras"
        Me.txtLetras.Size = New System.Drawing.Size(43, 20)
        Me.txtLetras.TabIndex = 8
        Me.txtLetras.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(331, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Letras:"
        Me.Label7.Visible = False
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(8, 93)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(100, 13)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Descripción Corta : "
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(8, 67)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(72, 13)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Descripción : "
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(8, 13)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(49, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Código : "
        '
        'lblTema
        '
        Me.lblTema.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTema.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTema.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTema.Location = New System.Drawing.Point(0, 0)
        Me.lblTema.Name = "lblTema"
        Me.lblTema.Size = New System.Drawing.Size(754, 29)
        Me.lblTema.TabIndex = 1
        Me.lblTema.Text = "CATÁLOGO SUCURSALES"
        Me.lblTema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SucursalCol
        '
        Me.SucursalCol.AllowEdit = True
        Me.SucursalCol.AllowNew = True
        Me.SucursalCol.AllowRemove = True
        Me.SucursalCol.MaximoElementosSeleccionados = 1
        Me.SucursalCol.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.SucursalCol.MostrarAlertas = False
        Me.SucursalCol.Name = ""
        Me.SucursalCol.RaiseListChangedEvents = True
        Me.SucursalCol.Transaction = Nothing
        '
        'gbSucursales
        '
        Me.gbSucursales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbSucursales.Controls.Add(Me.DataGrid)
        Me.gbSucursales.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSucursales.ForeColor = System.Drawing.Color.Blue
        Me.gbSucursales.Location = New System.Drawing.Point(51, 228)
        Me.gbSucursales.Name = "gbSucursales"
        Me.gbSucursales.Size = New System.Drawing.Size(691, 278)
        Me.gbSucursales.TabIndex = 3
        Me.gbSucursales.TabStop = False
        Me.gbSucursales.Text = "Sucursales Registradas"
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.AllowUserToOrderColumns = True
        Me.DataGrid.AllowUserToResizeRows = False
        Me.DataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClmCodigo, Me.ClmDescripcion, Me.ClmDescripcionCorta, Me.ClmPlaza, Me.ClmObservaciones, Me.ClmFechaAlta, Me.ClmEstatus})
        Me.DataGrid.Location = New System.Drawing.Point(6, 22)
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGrid.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGrid.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(679, 250)
        Me.DataGrid.TabIndex = 0
        '
        'ClmCodigo
        '
        Me.ClmCodigo.HeaderText = "Código"
        Me.ClmCodigo.Name = "ClmCodigo"
        Me.ClmCodigo.ReadOnly = True
        Me.ClmCodigo.Width = 70
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
        'ClmPlaza
        '
        Me.ClmPlaza.HeaderText = "Plaza"
        Me.ClmPlaza.Name = "ClmPlaza"
        Me.ClmPlaza.ReadOnly = True
        Me.ClmPlaza.Width = 150
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
        Me.ClmEstatus.Width = 80
        '
        'FrmSucursal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 510)
        Me.Controls.Add(Me.lblTema)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.Controls.Add(Me.PanelSucursales)
        Me.Controls.Add(Me.gbSucursales)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(757, 548)
        Me.MinimumSize = New System.Drawing.Size(757, 548)
        Me.Name = "FrmSucursal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sucursales"
        Me.PanelSucursales.ResumeLayout(False)
        Me.PanelSucursales.PerformLayout()
        Me.gbSucursales.ResumeLayout(False)
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents txtDescripcionCorta As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Private WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Private WithEvents cmbPlaza As System.Windows.Forms.ComboBox
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Private WithEvents txtCodigo As System.Windows.Forms.TextBox
    Private WithEvents PanelSucursales As System.Windows.Forms.Panel
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents lblTema As System.Windows.Forms.Label
    Private WithEvents gbSucursales As System.Windows.Forms.GroupBox
    Friend WithEvents PlazaCol As ClasesNegocio.PlazaCollectionClass
    Friend WithEvents SucursalCol As ClasesNegocio.SucursalCollectionClass
    Friend WithEvents DataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents ClmCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmDescripcionCorta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmPlaza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmObservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmFechaAlta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents txtLetras As System.Windows.Forms.TextBox
    Private WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chkActivar As System.Windows.Forms.CheckBox
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents cmbSerieFactura As System.Windows.Forms.ComboBox
    Friend WithEvents FacturaFoliosCol As ClasesNegocio.FacturaFoliosCollectionClass
End Class
