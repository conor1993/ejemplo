<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComRegPresupuesto
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.dtFechaAlta = New System.Windows.Forms.DateTimePicker
        Me.cmbSucursal = New System.Windows.Forms.ComboBox
        Me.cmbPlaza = New System.Windows.Forms.ComboBox
        Me.txtFolio = New System.Windows.Forms.TextBox
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.cmbTipoPresupuesto = New System.Windows.Forms.ComboBox
        Me.TipoPresupuestoC = New ClasesNegocio.TipoPresupuestoCollectionClass
        Me.txtObservaciones = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCantidad = New System.Windows.Forms.TextBox
        Me.DataGrid = New System.Windows.Forms.DataGridView
        Me.CodigoProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmProducto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UnidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrecioUltimaCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PresupuestoCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ctmDatagrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ProductosSolicitadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PresupuestoCompraDetalleC = New ClasesNegocio.PresupuestoCompraDetalleCollectionClass
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar
        Me.PlazaC = New ClasesNegocio.PlazaCollectionClass
        Me.SucursalC = New ClasesNegocio.SucursalCollectionClass
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.TmSucursal = New System.Windows.Forms.Timer(Me.components)
        Me.Tmplaza = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctmDatagrid.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(50, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(719, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "REGISTRO DE PRESUPUESTOS DE COMPRAS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Plaza:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Sucursal:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Folio Presupuesto:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Descripción:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(56, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Tipo Presupuesto:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(56, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Observaciones:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(342, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Fecha de Alta:"
        '
        'dtFechaAlta
        '
        Me.dtFechaAlta.Enabled = False
        Me.dtFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaAlta.Location = New System.Drawing.Point(424, 91)
        Me.dtFechaAlta.Name = "dtFechaAlta"
        Me.dtFechaAlta.Size = New System.Drawing.Size(95, 20)
        Me.dtFechaAlta.TabIndex = 9
        '
        'cmbSucursal
        '
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(156, 64)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(310, 21)
        Me.cmbSucursal.TabIndex = 5
        '
        'cmbPlaza
        '
        Me.cmbPlaza.FormattingEnabled = True
        Me.cmbPlaza.Location = New System.Drawing.Point(156, 37)
        Me.cmbPlaza.Name = "cmbPlaza"
        Me.cmbPlaza.Size = New System.Drawing.Size(310, 21)
        Me.cmbPlaza.TabIndex = 3
        '
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(156, 91)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.ReadOnly = True
        Me.txtFolio.Size = New System.Drawing.Size(81, 20)
        Me.txtFolio.TabIndex = 7
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(156, 117)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(363, 20)
        Me.txtDescripcion.TabIndex = 11
        '
        'cmbTipoPresupuesto
        '
        Me.cmbTipoPresupuesto.DataSource = Me.TipoPresupuestoC
        Me.cmbTipoPresupuesto.DisplayMember = "Descripcion"
        Me.cmbTipoPresupuesto.FormattingEnabled = True
        Me.cmbTipoPresupuesto.Location = New System.Drawing.Point(156, 143)
        Me.cmbTipoPresupuesto.Name = "cmbTipoPresupuesto"
        Me.cmbTipoPresupuesto.Size = New System.Drawing.Size(310, 21)
        Me.cmbTipoPresupuesto.TabIndex = 13
        Me.cmbTipoPresupuesto.ValueMember = "Codigo"
        '
        'TipoPresupuestoC
        '
        Me.TipoPresupuestoC.AllowEdit = True
        Me.TipoPresupuestoC.AllowNew = True
        Me.TipoPresupuestoC.AllowRemove = True
        Me.TipoPresupuestoC.Name = ""
        Me.TipoPresupuestoC.RaiseListChangedEvents = True
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Location = New System.Drawing.Point(156, 170)
        Me.txtObservaciones.MaxLength = 250
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(363, 84)
        Me.txtObservaciones.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.DataGrid)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(59, 275)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(698, 228)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de Orden"
        '
        'txtCantidad
        '
        Me.txtCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCantidad.Location = New System.Drawing.Point(354, 199)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.ReadOnly = True
        Me.txtCantidad.Size = New System.Drawing.Size(97, 23)
        Me.txtCantidad.TabIndex = 1
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.AllowUserToResizeRows = False
        Me.DataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGrid.AutoGenerateColumns = False
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoProductoDataGridViewTextBoxColumn, Me.ClmProducto, Me.CantidadDataGridViewTextBoxColumn, Me.UnidadDataGridViewTextBoxColumn, Me.PrecioUltimaCompraDataGridViewTextBoxColumn, Me.EstatusDataGridViewTextBoxColumn, Me.PresupuestoCompraDataGridViewTextBoxColumn})
        Me.DataGrid.ContextMenuStrip = Me.ctmDatagrid
        Me.DataGrid.DataSource = Me.PresupuestoCompraDetalleC
        Me.DataGrid.Location = New System.Drawing.Point(6, 22)
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        Me.DataGrid.RowHeadersWidth = 25
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(686, 171)
        Me.DataGrid.TabIndex = 0
        '
        'CodigoProductoDataGridViewTextBoxColumn
        '
        Me.CodigoProductoDataGridViewTextBoxColumn.DataPropertyName = "CodigoProducto"
        Me.CodigoProductoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CodigoProductoDataGridViewTextBoxColumn.Name = "CodigoProductoDataGridViewTextBoxColumn"
        Me.CodigoProductoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClmProducto
        '
        Me.ClmProducto.DataPropertyName = "Producto"
        Me.ClmProducto.HeaderText = "Producto"
        Me.ClmProducto.Name = "ClmProducto"
        Me.ClmProducto.ReadOnly = True
        Me.ClmProducto.Width = 250
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N3"
        DataGridViewCellStyle3.NullValue = "0"
        Me.CantidadDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UnidadDataGridViewTextBoxColumn
        '
        Me.UnidadDataGridViewTextBoxColumn.DataPropertyName = "Unidad"
        Me.UnidadDataGridViewTextBoxColumn.HeaderText = "Unidad"
        Me.UnidadDataGridViewTextBoxColumn.Name = "UnidadDataGridViewTextBoxColumn"
        Me.UnidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioUltimaCompraDataGridViewTextBoxColumn
        '
        Me.PrecioUltimaCompraDataGridViewTextBoxColumn.DataPropertyName = "PrecioUltimaCompra"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.PrecioUltimaCompraDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.PrecioUltimaCompraDataGridViewTextBoxColumn.HeaderText = "Pre. Ult. Compra"
        Me.PrecioUltimaCompraDataGridViewTextBoxColumn.Name = "PrecioUltimaCompraDataGridViewTextBoxColumn"
        Me.PrecioUltimaCompraDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioUltimaCompraDataGridViewTextBoxColumn.Width = 130
        '
        'EstatusDataGridViewTextBoxColumn
        '
        Me.EstatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.HeaderText = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.Name = "EstatusDataGridViewTextBoxColumn"
        Me.EstatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstatusDataGridViewTextBoxColumn.Visible = False
        '
        'PresupuestoCompraDataGridViewTextBoxColumn
        '
        Me.PresupuestoCompraDataGridViewTextBoxColumn.DataPropertyName = "PresupuestoCompra"
        Me.PresupuestoCompraDataGridViewTextBoxColumn.HeaderText = "Presupuesto de Compra"
        Me.PresupuestoCompraDataGridViewTextBoxColumn.Name = "PresupuestoCompraDataGridViewTextBoxColumn"
        Me.PresupuestoCompraDataGridViewTextBoxColumn.ReadOnly = True
        Me.PresupuestoCompraDataGridViewTextBoxColumn.Visible = False
        '
        'ctmDatagrid
        '
        Me.ctmDatagrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosSolicitadosToolStripMenuItem})
        Me.ctmDatagrid.Name = "ctmDatagrid"
        Me.ctmDatagrid.Size = New System.Drawing.Size(187, 26)
        '
        'ProductosSolicitadosToolStripMenuItem
        '
        Me.ProductosSolicitadosToolStripMenuItem.Name = "ProductosSolicitadosToolStripMenuItem"
        Me.ProductosSolicitadosToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ProductosSolicitadosToolStripMenuItem.Text = "&Productos Solicitados"
        '
        'PresupuestoCompraDetalleC
        '
        Me.PresupuestoCompraDetalleC.AllowEdit = True
        Me.PresupuestoCompraDetalleC.AllowNew = True
        Me.PresupuestoCompraDetalleC.AllowRemove = True
        Me.PresupuestoCompraDetalleC.Name = ""
        Me.PresupuestoCompraDetalleC.RaiseListChangedEvents = True
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
        Me.MEAToolBar1.MostrarBuscar = True
        Me.MEAToolBar1.MostrarCancelar = True
        Me.MEAToolBar1.MostrarEditar = True
        Me.MEAToolBar1.MostrarGuardar = True
        Me.MEAToolBar1.MostrarImprimir = False
        Me.MEAToolBar1.MostrarLimpiar = True
        Me.MEAToolBar1.MostrarNuevo = True
        Me.MEAToolBar1.MostrarSalir = True
        Me.MEAToolBar1.Name = "MEAToolBar1"
        Me.MEAToolBar1.ShowToolTips = True
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 515)
        Me.MEAToolBar1.TabIndex = 0
        '
        'PlazaC
        '
        Me.PlazaC.AllowEdit = True
        Me.PlazaC.AllowNew = True
        Me.PlazaC.AllowRemove = True
        Me.PlazaC.Name = ""
        Me.PlazaC.RaiseListChangedEvents = True
        '
        'SucursalC
        '
        Me.SucursalC.AllowEdit = True
        Me.SucursalC.AllowNew = True
        Me.SucursalC.AllowRemove = True
        Me.SucursalC.Name = ""
        Me.SucursalC.RaiseListChangedEvents = True
        '
        'lblEstatus
        '
        Me.lblEstatus.AutoSize = True
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblEstatus.Location = New System.Drawing.Point(612, 39)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(104, 24)
        Me.lblEstatus.TabIndex = 67
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.Visible = False
        '
        'TmSucursal
        '
        Me.TmSucursal.Interval = 1000
        '
        'Tmplaza
        '
        Me.Tmplaza.Interval = 1000
        '
        'ComRegPresupuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 515)
        Me.Controls.Add(Me.lblEstatus)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.cmbTipoPresupuesto)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.cmbPlaza)
        Me.Controls.Add(Me.cmbSucursal)
        Me.Controls.Add(Me.dtFechaAlta)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(777, 549)
        Me.MinimumSize = New System.Drawing.Size(777, 549)
        Me.Name = "ComRegPresupuesto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Presupuestos de Compras"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctmDatagrid.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtFechaAlta As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPlaza As System.Windows.Forms.ComboBox
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents cmbTipoPresupuesto As System.Windows.Forms.ComboBox
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents DataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents PlazaC As ClasesNegocio.PlazaCollectionClass
    Friend WithEvents SucursalC As ClasesNegocio.SucursalCollectionClass
    Friend WithEvents TipoPresupuestoC As ClasesNegocio.TipoPresupuestoCollectionClass
    Friend WithEvents PresupuestoCompraDetalleC As ClasesNegocio.PresupuestoCompraDetalleCollectionClass
    Friend WithEvents ctmDatagrid As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ProductosSolicitadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents CodigoProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioUltimaCompraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PresupuestoCompraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TmSucursal As System.Windows.Forms.Timer
    Friend WithEvents Tmplaza As System.Windows.Forms.Timer
End Class