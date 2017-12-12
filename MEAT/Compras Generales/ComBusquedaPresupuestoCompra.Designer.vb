<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComBusquedaPresupuestoCompra
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
        Me.cmbTipoPresupuesto = New System.Windows.Forms.ComboBox
        Me.txtFolio = New System.Windows.Forms.TextBox
        Me.cmbPlaza = New System.Windows.Forms.ComboBox
        Me.cmbSucursal = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGrid = New System.Windows.Forms.DataGridView
        Me.PresupuestoCompraC = New ClasesNegocio.PresupuestoCompraCollectionClass
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.SucursalC = New ClasesNegocio.SucursalCollectionClass
        Me.PlazaC = New ClasesNegocio.PlazaCollectionClass
        Me.TipoPresupuestoC = New ClasesNegocio.TipoPresupuestoCollectionClass
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbtTodas = New System.Windows.Forms.RadioButton
        Me.rbtCanceladas = New System.Windows.Forms.RadioButton
        Me.rbtAcivas = New System.Windows.Forms.RadioButton
        Me.ClmFolio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmSucursal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoPresupuestoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaAltaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ObservacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OrdenCompraGeneradaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbTipoPresupuesto
        '
        Me.cmbTipoPresupuesto.DisplayMember = "Descripcion"
        Me.cmbTipoPresupuesto.FormattingEnabled = True
        Me.cmbTipoPresupuesto.Location = New System.Drawing.Point(156, 143)
        Me.cmbTipoPresupuesto.Name = "cmbTipoPresupuesto"
        Me.cmbTipoPresupuesto.Size = New System.Drawing.Size(310, 21)
        Me.cmbTipoPresupuesto.TabIndex = 24
        Me.cmbTipoPresupuesto.ValueMember = "Codigo"
        '
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(156, 37)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(81, 20)
        Me.txtFolio.TabIndex = 20
        '
        'cmbPlaza
        '
        Me.cmbPlaza.DisplayMember = "Descripcion"
        Me.cmbPlaza.FormattingEnabled = True
        Me.cmbPlaza.Location = New System.Drawing.Point(156, 89)
        Me.cmbPlaza.Name = "cmbPlaza"
        Me.cmbPlaza.Size = New System.Drawing.Size(310, 21)
        Me.cmbPlaza.TabIndex = 16
        Me.cmbPlaza.ValueMember = "Codigo"
        '
        'cmbSucursal
        '
        Me.cmbSucursal.DisplayMember = "Descripcion"
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(156, 116)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(310, 21)
        Me.cmbSucursal.TabIndex = 18
        Me.cmbSucursal.ValueMember = "Codigo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(56, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Tipo Presupuesto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Folio Presupuesto:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Sucursal:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Plaza:"
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
        Me.MEAToolBar1.MostrarBorrar = False
        Me.MEAToolBar1.MostrarBuscar = True
        Me.MEAToolBar1.MostrarCancelar = False
        Me.MEAToolBar1.MostrarEditar = False
        Me.MEAToolBar1.MostrarGuardar = False
        Me.MEAToolBar1.MostrarImprimir = False
        Me.MEAToolBar1.MostrarLimpiar = True
        Me.MEAToolBar1.MostrarNuevo = False
        Me.MEAToolBar1.MostrarSalir = True
        Me.MEAToolBar1.Name = "MEAToolBar1"
        Me.MEAToolBar1.ShowToolTips = True
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 560)
        Me.MEAToolBar1.TabIndex = 14
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
        Me.Label1.Size = New System.Drawing.Size(889, 29)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "BUSQUEDA DE PRESUPUESTOS DE COMPRAS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(156, 63)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(310, 20)
        Me.txtDescripcion.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Descripción:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DataGrid)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(59, 170)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(868, 349)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de Orden"
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
        Me.DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClmFolio, Me.DescripcionDataGridViewTextBoxColumn, Me.clmSucursal, Me.TipoPresupuestoDataGridViewTextBoxColumn, Me.FechaAltaDataGridViewTextBoxColumn, Me.ObservacionesDataGridViewTextBoxColumn, Me.EstatusDataGridViewTextBoxColumn, Me.OrdenCompraGeneradaDataGridViewTextBoxColumn})
        Me.DataGrid.DataSource = Me.PresupuestoCompraC
        Me.DataGrid.Location = New System.Drawing.Point(6, 22)
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(856, 321)
        Me.DataGrid.TabIndex = 0
        '
        'PresupuestoCompraC
        '
        Me.PresupuestoCompraC.AllowEdit = True
        Me.PresupuestoCompraC.AllowNew = True
        Me.PresupuestoCompraC.AllowRemove = True
        Me.PresupuestoCompraC.Name = ""
        Me.PresupuestoCompraC.RaiseListChangedEvents = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(765, 525)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(846, 525)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SucursalC
        '
        Me.SucursalC.AllowEdit = True
        Me.SucursalC.AllowNew = True
        Me.SucursalC.AllowRemove = True
        Me.SucursalC.Name = ""
        Me.SucursalC.RaiseListChangedEvents = True
        '
        'PlazaC
        '
        Me.PlazaC.AllowEdit = True
        Me.PlazaC.AllowNew = True
        Me.PlazaC.AllowRemove = True
        Me.PlazaC.Name = ""
        Me.PlazaC.RaiseListChangedEvents = True
        '
        'TipoPresupuestoC
        '
        Me.TipoPresupuestoC.AllowEdit = True
        Me.TipoPresupuestoC.AllowNew = True
        Me.TipoPresupuestoC.AllowRemove = True
        Me.TipoPresupuestoC.Name = ""
        Me.TipoPresupuestoC.RaiseListChangedEvents = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.rbtTodas)
        Me.GroupBox2.Controls.Add(Me.rbtCanceladas)
        Me.GroupBox2.Controls.Add(Me.rbtAcivas)
        Me.GroupBox2.Location = New System.Drawing.Point(704, 115)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(223, 49)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estatus"
        '
        'rbtTodas
        '
        Me.rbtTodas.AutoSize = True
        Me.rbtTodas.Checked = True
        Me.rbtTodas.Location = New System.Drawing.Point(159, 20)
        Me.rbtTodas.Name = "rbtTodas"
        Me.rbtTodas.Size = New System.Drawing.Size(55, 17)
        Me.rbtTodas.TabIndex = 2
        Me.rbtTodas.TabStop = True
        Me.rbtTodas.Text = "Todas"
        Me.rbtTodas.UseVisualStyleBackColor = True
        '
        'rbtCanceladas
        '
        Me.rbtCanceladas.AutoSize = True
        Me.rbtCanceladas.Location = New System.Drawing.Point(72, 20)
        Me.rbtCanceladas.Name = "rbtCanceladas"
        Me.rbtCanceladas.Size = New System.Drawing.Size(81, 17)
        Me.rbtCanceladas.TabIndex = 1
        Me.rbtCanceladas.Text = "Canceladas"
        Me.rbtCanceladas.UseVisualStyleBackColor = True
        '
        'rbtAcivas
        '
        Me.rbtAcivas.AutoSize = True
        Me.rbtAcivas.Location = New System.Drawing.Point(6, 19)
        Me.rbtAcivas.Name = "rbtAcivas"
        Me.rbtAcivas.Size = New System.Drawing.Size(60, 17)
        Me.rbtAcivas.TabIndex = 0
        Me.rbtAcivas.Text = "Activas"
        Me.rbtAcivas.UseVisualStyleBackColor = True
        '
        'ClmFolio
        '
        Me.ClmFolio.DataPropertyName = "Folio"
        Me.ClmFolio.HeaderText = "Folio"
        Me.ClmFolio.Name = "ClmFolio"
        Me.ClmFolio.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 200
        '
        'clmSucursal
        '
        Me.clmSucursal.DataPropertyName = "Sucursal"
        Me.clmSucursal.HeaderText = "Sucursal"
        Me.clmSucursal.Name = "clmSucursal"
        Me.clmSucursal.ReadOnly = True
        Me.clmSucursal.Width = 200
        '
        'TipoPresupuestoDataGridViewTextBoxColumn
        '
        Me.TipoPresupuestoDataGridViewTextBoxColumn.DataPropertyName = "TipoPresupuesto"
        Me.TipoPresupuestoDataGridViewTextBoxColumn.HeaderText = "Tipo de Presupuesto"
        Me.TipoPresupuestoDataGridViewTextBoxColumn.Name = "TipoPresupuestoDataGridViewTextBoxColumn"
        Me.TipoPresupuestoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoPresupuestoDataGridViewTextBoxColumn.Width = 200
        '
        'FechaAltaDataGridViewTextBoxColumn
        '
        Me.FechaAltaDataGridViewTextBoxColumn.DataPropertyName = "FechaAlta"
        Me.FechaAltaDataGridViewTextBoxColumn.HeaderText = "Fecha de Alta"
        Me.FechaAltaDataGridViewTextBoxColumn.Name = "FechaAltaDataGridViewTextBoxColumn"
        Me.FechaAltaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ObservacionesDataGridViewTextBoxColumn
        '
        Me.ObservacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.Name = "ObservacionesDataGridViewTextBoxColumn"
        Me.ObservacionesDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObservacionesDataGridViewTextBoxColumn.Width = 200
        '
        'EstatusDataGridViewTextBoxColumn
        '
        Me.EstatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.HeaderText = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.Name = "EstatusDataGridViewTextBoxColumn"
        Me.EstatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OrdenCompraGeneradaDataGridViewTextBoxColumn
        '
        Me.OrdenCompraGeneradaDataGridViewTextBoxColumn.DataPropertyName = "OrdenCompraGenerada"
        Me.OrdenCompraGeneradaDataGridViewTextBoxColumn.HeaderText = "Orden Generada"
        Me.OrdenCompraGeneradaDataGridViewTextBoxColumn.Name = "OrdenCompraGeneradaDataGridViewTextBoxColumn"
        Me.OrdenCompraGeneradaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ComBusqeudaPresupuestoCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 560)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbTipoPresupuesto)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.cmbPlaza)
        Me.Controls.Add(Me.cmbSucursal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.MaximizeBox = False
        Me.Name = "ComBusqeudaPresupuestoCompra"
        Me.Text = "Busqueda de Presupuestos de Compra"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbTipoPresupuesto As System.Windows.Forms.ComboBox
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents cmbPlaza As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PlazaC As ClasesNegocio.PlazaCollectionClass
    Friend WithEvents SucursalC As ClasesNegocio.SucursalCollectionClass
    Friend WithEvents TipoPresupuestoC As ClasesNegocio.TipoPresupuestoCollectionClass
    Friend WithEvents PresupuestoCompraC As ClasesNegocio.PresupuestoCompraCollectionClass
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtTodas As System.Windows.Forms.RadioButton
    Friend WithEvents rbtCanceladas As System.Windows.Forms.RadioButton
    Friend WithEvents rbtAcivas As System.Windows.Forms.RadioButton
    Friend WithEvents ClmFolio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSucursal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoPresupuestoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaAltaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrdenCompraGeneradaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
