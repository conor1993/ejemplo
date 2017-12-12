<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSalidasdeAlmacenXMateriales
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.mtb = New MiToolBar.miToolBar
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.lblCodigo = New System.Windows.Forms.Label
        Me.lblFecha = New System.Windows.Forms.Label
        Me.lblMovimiento = New System.Windows.Forms.Label
        Me.lblAlmacen = New System.Windows.Forms.Label
        Me.lblEntrega = New System.Windows.Forms.Label
        Me.lblRecibe = New System.Windows.Forms.Label
        Me.lblObservaciones = New System.Windows.Forms.Label
        Me.lblImporteTotal = New System.Windows.Forms.Label
        Me.lblImporteGuia = New System.Windows.Forms.Label
        Me.txtFolio = New System.Windows.Forms.TextBox
        Me.txtMovimiento = New System.Windows.Forms.TextBox
        Me.cmbAlmacen = New System.Windows.Forms.ComboBox
        Me.txtEntrega = New System.Windows.Forms.TextBox
        Me.txtRecibe = New System.Windows.Forms.TextBox
        Me.txtObservaciones = New System.Windows.Forms.TextBox
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.gpbImportes = New System.Windows.Forms.GroupBox
        Me.txtImporteGuia = New System.Windows.Forms.TextBox
        Me.txtImporteTotal = New System.Windows.Forms.TextBox
        Me.dgvProductos = New System.Windows.Forms.DataGridView
        Me.Clmproducto = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.ProductosVistaC = New ClasesNegocio.ProductosVistaCollectionClass
        Me.clmCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCosto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmImporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvCuentas = New System.Windows.Forms.DataGridView
        Me.clmCtaM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmScta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmSsct = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmSssc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCuentaContable = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmMov = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmImporteCt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewComboBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.DataGridViewComboBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridViewComboBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.MovAlmDetCol = New ClasesNegocio.MovAlmacenDetCollecionClass
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.gpbImportes.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 615)
        Me.mtb.TabIndex = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(56, 0)
        Me.lblTitulo.MaximumSize = New System.Drawing.Size(1600, 900)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(676, 29)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "SALIDAS DE ALMACÉN POR MATERIALES"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(56, 68)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(32, 13)
        Me.lblCodigo.TabIndex = 3
        Me.lblCodigo.Text = "Folio:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(273, 68)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(40, 13)
        Me.lblFecha.TabIndex = 5
        Me.lblFecha.Text = "Fecha:"
        '
        'lblMovimiento
        '
        Me.lblMovimiento.AutoSize = True
        Me.lblMovimiento.Location = New System.Drawing.Point(56, 97)
        Me.lblMovimiento.Name = "lblMovimiento"
        Me.lblMovimiento.Size = New System.Drawing.Size(64, 13)
        Me.lblMovimiento.TabIndex = 7
        Me.lblMovimiento.Text = "Movimiento:"
        '
        'lblAlmacen
        '
        Me.lblAlmacen.AutoSize = True
        Me.lblAlmacen.Location = New System.Drawing.Point(56, 128)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.Size = New System.Drawing.Size(51, 13)
        Me.lblAlmacen.TabIndex = 9
        Me.lblAlmacen.Text = "Almacén:"
        '
        'lblEntrega
        '
        Me.lblEntrega.AutoSize = True
        Me.lblEntrega.Location = New System.Drawing.Point(56, 157)
        Me.lblEntrega.Name = "lblEntrega"
        Me.lblEntrega.Size = New System.Drawing.Size(47, 13)
        Me.lblEntrega.TabIndex = 11
        Me.lblEntrega.Text = "Entrega:"
        '
        'lblRecibe
        '
        Me.lblRecibe.AutoSize = True
        Me.lblRecibe.Location = New System.Drawing.Point(56, 185)
        Me.lblRecibe.Name = "lblRecibe"
        Me.lblRecibe.Size = New System.Drawing.Size(44, 13)
        Me.lblRecibe.TabIndex = 13
        Me.lblRecibe.Text = "Recibe:"
        '
        'lblObservaciones
        '
        Me.lblObservaciones.AutoSize = True
        Me.lblObservaciones.Location = New System.Drawing.Point(56, 212)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(81, 13)
        Me.lblObservaciones.TabIndex = 15
        Me.lblObservaciones.Text = "Observaciones:"
        '
        'lblImporteTotal
        '
        Me.lblImporteTotal.AutoSize = True
        Me.lblImporteTotal.Location = New System.Drawing.Point(17, 22)
        Me.lblImporteTotal.Name = "lblImporteTotal"
        Me.lblImporteTotal.Size = New System.Drawing.Size(72, 13)
        Me.lblImporteTotal.TabIndex = 0
        Me.lblImporteTotal.Text = "Importe Total:"
        '
        'lblImporteGuia
        '
        Me.lblImporteGuia.AutoSize = True
        Me.lblImporteGuia.Location = New System.Drawing.Point(17, 51)
        Me.lblImporteGuia.Name = "lblImporteGuia"
        Me.lblImporteGuia.Size = New System.Drawing.Size(72, 13)
        Me.lblImporteGuia.TabIndex = 2
        Me.lblImporteGuia.Text = "Importe Guía:"
        '
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(143, 65)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.ReadOnly = True
        Me.txtFolio.Size = New System.Drawing.Size(100, 20)
        Me.txtFolio.TabIndex = 4
        '
        'txtMovimiento
        '
        Me.txtMovimiento.Location = New System.Drawing.Point(143, 94)
        Me.txtMovimiento.Name = "txtMovimiento"
        Me.txtMovimiento.ReadOnly = True
        Me.txtMovimiento.Size = New System.Drawing.Size(265, 20)
        Me.txtMovimiento.TabIndex = 8
        '
        'cmbAlmacen
        '
        Me.cmbAlmacen.FormattingEnabled = True
        Me.cmbAlmacen.Location = New System.Drawing.Point(143, 125)
        Me.cmbAlmacen.Name = "cmbAlmacen"
        Me.cmbAlmacen.Size = New System.Drawing.Size(265, 21)
        Me.cmbAlmacen.TabIndex = 10
        '
        'txtEntrega
        '
        Me.txtEntrega.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEntrega.Location = New System.Drawing.Point(143, 154)
        Me.txtEntrega.MaxLength = 120
        Me.txtEntrega.Name = "txtEntrega"
        Me.txtEntrega.Size = New System.Drawing.Size(265, 20)
        Me.txtEntrega.TabIndex = 12
        '
        'txtRecibe
        '
        Me.txtRecibe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRecibe.Location = New System.Drawing.Point(143, 182)
        Me.txtRecibe.MaxLength = 120
        Me.txtRecibe.Name = "txtRecibe"
        Me.txtRecibe.Size = New System.Drawing.Size(265, 20)
        Me.txtRecibe.TabIndex = 14
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Location = New System.Drawing.Point(143, 209)
        Me.txtObservaciones.MaxLength = 250
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(265, 68)
        Me.txtObservaciones.TabIndex = 16
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(319, 65)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(89, 20)
        Me.dtpFecha.TabIndex = 6
        '
        'gpbImportes
        '
        Me.gpbImportes.Controls.Add(Me.txtImporteGuia)
        Me.gpbImportes.Controls.Add(Me.txtImporteTotal)
        Me.gpbImportes.Controls.Add(Me.lblImporteGuia)
        Me.gpbImportes.Controls.Add(Me.lblImporteTotal)
        Me.gpbImportes.Location = New System.Drawing.Point(440, 106)
        Me.gpbImportes.Name = "gpbImportes"
        Me.gpbImportes.Size = New System.Drawing.Size(216, 92)
        Me.gpbImportes.TabIndex = 17
        Me.gpbImportes.TabStop = False
        Me.gpbImportes.Text = "Importes"
        '
        'txtImporteGuia
        '
        Me.txtImporteGuia.Location = New System.Drawing.Point(95, 48)
        Me.txtImporteGuia.Name = "txtImporteGuia"
        Me.txtImporteGuia.ReadOnly = True
        Me.txtImporteGuia.Size = New System.Drawing.Size(100, 20)
        Me.txtImporteGuia.TabIndex = 3
        Me.txtImporteGuia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtImporteTotal
        '
        Me.txtImporteTotal.Location = New System.Drawing.Point(95, 19)
        Me.txtImporteTotal.Name = "txtImporteTotal"
        Me.txtImporteTotal.ReadOnly = True
        Me.txtImporteTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtImporteTotal.TabIndex = 1
        Me.txtImporteTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvProductos
        '
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Clmproducto, Me.clmCantidad, Me.clmUnidad, Me.clmCosto, Me.clmImporte})
        Me.dgvProductos.Location = New System.Drawing.Point(59, 283)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.RowHeadersWidth = 30
        Me.dgvProductos.Size = New System.Drawing.Size(638, 148)
        Me.dgvProductos.TabIndex = 18
        '
        'Clmproducto
        '
        Me.Clmproducto.DataSource = Me.ProductosVistaC
        Me.Clmproducto.DisplayMember = "Descripcion"
        Me.Clmproducto.HeaderText = "Producto"
        Me.Clmproducto.Name = "Clmproducto"
        Me.Clmproducto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Clmproducto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Clmproducto.ValueMember = "Codigo"
        Me.Clmproducto.Width = 190
        '
        'ProductosVistaC
        '
        Me.ProductosVistaC.AllowEdit = True
        Me.ProductosVistaC.AllowNew = True
        Me.ProductosVistaC.AllowRemove = True
        Me.ProductosVistaC.Name = ""
        Me.ProductosVistaC.RaiseListChangedEvents = True
        '
        'clmCantidad
        '
        Me.clmCantidad.HeaderText = "Cantidad"
        Me.clmCantidad.Name = "clmCantidad"
        '
        'clmUnidad
        '
        Me.clmUnidad.HeaderText = "Unidad"
        Me.clmUnidad.Name = "clmUnidad"
        Me.clmUnidad.ReadOnly = True
        '
        'clmCosto
        '
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.clmCosto.DefaultCellStyle = DataGridViewCellStyle4
        Me.clmCosto.HeaderText = "Costo"
        Me.clmCosto.Name = "clmCosto"
        Me.clmCosto.ReadOnly = True
        '
        'clmImporte
        '
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.clmImporte.DefaultCellStyle = DataGridViewCellStyle5
        Me.clmImporte.HeaderText = "Importe"
        Me.clmImporte.Name = "clmImporte"
        Me.clmImporte.ReadOnly = True
        '
        'dgvCuentas
        '
        Me.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmCtaM, Me.clmScta, Me.clmSsct, Me.clmSssc, Me.clmCuentaContable, Me.clmMov, Me.clmImporteCt})
        Me.dgvCuentas.Location = New System.Drawing.Point(59, 455)
        Me.dgvCuentas.Name = "dgvCuentas"
        Me.dgvCuentas.RowHeadersWidth = 30
        Me.dgvCuentas.Size = New System.Drawing.Size(638, 148)
        Me.dgvCuentas.TabIndex = 20
        '
        'clmCtaM
        '
        Me.clmCtaM.HeaderText = "CtaM"
        Me.clmCtaM.MaxInputLength = 4
        Me.clmCtaM.Name = "clmCtaM"
        Me.clmCtaM.Width = 60
        '
        'clmScta
        '
        Me.clmScta.HeaderText = "Scta"
        Me.clmScta.MaxInputLength = 4
        Me.clmScta.Name = "clmScta"
        Me.clmScta.Width = 60
        '
        'clmSsct
        '
        Me.clmSsct.HeaderText = "SsCt"
        Me.clmSsct.MaxInputLength = 4
        Me.clmSsct.Name = "clmSsct"
        Me.clmSsct.Width = 60
        '
        'clmSssc
        '
        Me.clmSssc.HeaderText = "SssC"
        Me.clmSssc.MaxInputLength = 4
        Me.clmSssc.Name = "clmSssc"
        Me.clmSssc.Width = 60
        '
        'clmCuentaContable
        '
        Me.clmCuentaContable.HeaderText = "Cuenta Contable"
        Me.clmCuentaContable.Name = "clmCuentaContable"
        Me.clmCuentaContable.Width = 200
        '
        'clmMov
        '
        Me.clmMov.HeaderText = "Mov"
        Me.clmMov.MaxInputLength = 1
        Me.clmMov.Name = "clmMov"
        Me.clmMov.Width = 50
        '
        'clmImporteCt
        '
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.clmImporteCt.DefaultCellStyle = DataGridViewCellStyle6
        Me.clmImporteCt.HeaderText = "Importe"
        Me.clmImporteCt.Name = "clmImporteCt"
        '
        'DataGridViewComboBoxColumn1
        '
        Me.DataGridViewComboBoxColumn1.HeaderText = "Producto"
        Me.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1"
        Me.DataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewComboBoxColumn1.Width = 190
        '
        'DataGridViewComboBoxColumn2
        '
        Me.DataGridViewComboBoxColumn2.HeaderText = "Producto"
        Me.DataGridViewComboBoxColumn2.Name = "DataGridViewComboBoxColumn2"
        Me.DataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewComboBoxColumn2.Width = 190
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(59, 429)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(638, 23)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Guía Contable"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridViewComboBoxColumn3
        '
        Me.DataGridViewComboBoxColumn3.HeaderText = "Producto"
        Me.DataGridViewComboBoxColumn3.Name = "DataGridViewComboBoxColumn3"
        Me.DataGridViewComboBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewComboBoxColumn3.Width = 190
        '
        'MovAlmDetCol
        '
        Me.MovAlmDetCol.AllowEdit = True
        Me.MovAlmDetCol.AllowNew = True
        Me.MovAlmDetCol.AllowRemove = True
        Me.MovAlmDetCol.Name = ""
        Me.MovAlmDetCol.RaiseListChangedEvents = True
        '
        'lblEstatus
        '
        Me.lblEstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(600, 39)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(97, 21)
        Me.lblEstatus.TabIndex = 2
        Me.lblEstatus.Text = "ESTATUS"
        '
        'FrmSalidasdeAlmacenXMateriales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 615)
        Me.Controls.Add(Me.lblEstatus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvCuentas)
        Me.Controls.Add(Me.dgvProductos)
        Me.Controls.Add(Me.gpbImportes)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.txtRecibe)
        Me.Controls.Add(Me.txtEntrega)
        Me.Controls.Add(Me.cmbAlmacen)
        Me.Controls.Add(Me.txtMovimiento)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.lblRecibe)
        Me.Controls.Add(Me.lblEntrega)
        Me.Controls.Add(Me.lblAlmacen)
        Me.Controls.Add(Me.lblMovimiento)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmSalidasdeAlmacenXMateriales"
        Me.Text = " Salidas de Almacén por Materiales"
        Me.gpbImportes.ResumeLayout(False)
        Me.gpbImportes.PerformLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MiToolBar.miToolBar
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblMovimiento As System.Windows.Forms.Label
    Friend WithEvents lblAlmacen As System.Windows.Forms.Label
    Friend WithEvents lblEntrega As System.Windows.Forms.Label
    Friend WithEvents lblRecibe As System.Windows.Forms.Label
    Friend WithEvents lblObservaciones As System.Windows.Forms.Label
    Friend WithEvents lblImporteTotal As System.Windows.Forms.Label
    Friend WithEvents lblImporteGuia As System.Windows.Forms.Label
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents txtMovimiento As System.Windows.Forms.TextBox
    Friend WithEvents cmbAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents txtEntrega As System.Windows.Forms.TextBox
    Friend WithEvents txtRecibe As System.Windows.Forms.TextBox
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents gpbImportes As System.Windows.Forms.GroupBox
    Friend WithEvents txtImporteGuia As System.Windows.Forms.TextBox
    Friend WithEvents txtImporteTotal As System.Windows.Forms.TextBox
    Friend WithEvents dgvProductos As System.Windows.Forms.DataGridView
    Friend WithEvents dgvCuentas As System.Windows.Forms.DataGridView
    Friend WithEvents ProductosVistaC As ClasesNegocio.ProductosVistaCollectionClass
    Friend WithEvents MovAlmDetCol As ClasesNegocio.MovAlmacenDetCollecionClass
    Friend WithEvents Clmproducto As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents clmCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCosto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn1 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents clmCtaM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmScta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSsct As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSssc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCuentaContable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmMov As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmImporteCt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
End Class
