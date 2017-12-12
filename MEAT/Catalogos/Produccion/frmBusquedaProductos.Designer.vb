<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaProductos
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
        Me.Label17 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCodigo = New IntegraLab.Controles.TextBoxMejorado
        Me.txtDescripcion = New IntegraLab.Controles.TextBoxMejorado
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkInactivo = New System.Windows.Forms.CheckBox
        Me.chkActivo = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionCortaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ObservacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubProductoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.PreCorteDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.CorteDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.CanalDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DecomisaDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.EnPiezasDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.EsMermaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EsDerivable = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProductosC = New ClasesNegocio.ProductosCollectionsClass
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(925, 32)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "BUSQUEDA DE PRODUCTOS"
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
        Me.mtb.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32
        Me.mtb.Location = New System.Drawing.Point(0, 0)
        Me.mtb.MostrarBorrar = False
        Me.mtb.MostrarBuscar = True
        Me.mtb.MostrarCancelar = False
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = False
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 561)
        Me.mtb.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.ComboBoxEnlazado = Nothing
        Me.txtCodigo.Decimales = 0
        Me.txtCodigo.Location = New System.Drawing.Point(128, 38)
        Me.txtCodigo.MensajeCombo = "Seleccionar un item..."
        Me.txtCodigo.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.SiguienteControl = Nothing
        Me.txtCodigo.Size = New System.Drawing.Size(70, 20)
        Me.txtCodigo.TabIndex = 46
        Me.txtCodigo.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtCodigo.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCodigo.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtDescripcion
        '
        Me.txtDescripcion.ComboBoxEnlazado = Nothing
        Me.txtDescripcion.Decimales = 0
        Me.txtDescripcion.Location = New System.Drawing.Point(128, 64)
        Me.txtDescripcion.MensajeCombo = "Seleccionar un item..."
        Me.txtDescripcion.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.SiguienteControl = Nothing
        Me.txtDescripcion.Size = New System.Drawing.Size(346, 20)
        Me.txtDescripcion.TabIndex = 48
        Me.txtDescripcion.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtDescripcion.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtDescripcion.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Descripción:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 49
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkInactivo)
        Me.GroupBox1.Controls.Add(Me.chkActivo)
        Me.GroupBox1.Location = New System.Drawing.Point(480, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(153, 46)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Estatus"
        '
        'chkInactivo
        '
        Me.chkInactivo.AutoSize = True
        Me.chkInactivo.Location = New System.Drawing.Point(78, 20)
        Me.chkInactivo.Name = "chkInactivo"
        Me.chkInactivo.Size = New System.Drawing.Size(64, 17)
        Me.chkInactivo.TabIndex = 1
        Me.chkInactivo.Text = "Inactivo"
        Me.chkInactivo.UseVisualStyleBackColor = True
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Location = New System.Drawing.Point(7, 20)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 0
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(61, 90)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(902, 459)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista de Productos"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProductoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.DescripcionCortaDataGridViewTextBoxColumn, Me.ObservacionesDataGridViewTextBoxColumn, Me.SubProductoDataGridViewCheckBoxColumn, Me.PreCorteDataGridViewCheckBoxColumn, Me.CorteDataGridViewCheckBoxColumn, Me.CanalDataGridViewCheckBoxColumn, Me.DecomisaDataGridViewCheckBoxColumn, Me.EnPiezasDataGridViewCheckBoxColumn, Me.EsMermaDataGridViewTextBoxColumn, Me.EsDerivable, Me.EstatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProductosC
        Me.DataGridView1.Location = New System.Drawing.Point(6, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(890, 434)
        Me.DataGridView1.TabIndex = 0
        '
        'IdProductoDataGridViewTextBoxColumn
        '
        Me.IdProductoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.IdProductoDataGridViewTextBoxColumn.DataPropertyName = "IdProducto"
        Me.IdProductoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.IdProductoDataGridViewTextBoxColumn.Name = "IdProductoDataGridViewTextBoxColumn"
        Me.IdProductoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdProductoDataGridViewTextBoxColumn.Width = 63
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 86
        '
        'DescripcionCortaDataGridViewTextBoxColumn
        '
        Me.DescripcionCortaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DescripcionCortaDataGridViewTextBoxColumn.DataPropertyName = "DescripcionCorta"
        Me.DescripcionCortaDataGridViewTextBoxColumn.HeaderText = "Descripcion Corta"
        Me.DescripcionCortaDataGridViewTextBoxColumn.Name = "DescripcionCortaDataGridViewTextBoxColumn"
        Me.DescripcionCortaDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionCortaDataGridViewTextBoxColumn.Width = 104
        '
        'ObservacionesDataGridViewTextBoxColumn
        '
        Me.ObservacionesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ObservacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.Name = "ObservacionesDataGridViewTextBoxColumn"
        Me.ObservacionesDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObservacionesDataGridViewTextBoxColumn.Width = 101
        '
        'SubProductoDataGridViewCheckBoxColumn
        '
        Me.SubProductoDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SubProductoDataGridViewCheckBoxColumn.DataPropertyName = "SubProducto"
        Me.SubProductoDataGridViewCheckBoxColumn.HeaderText = "SubProducto"
        Me.SubProductoDataGridViewCheckBoxColumn.Name = "SubProductoDataGridViewCheckBoxColumn"
        Me.SubProductoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.SubProductoDataGridViewCheckBoxColumn.Width = 73
        '
        'PreCorteDataGridViewCheckBoxColumn
        '
        Me.PreCorteDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.PreCorteDataGridViewCheckBoxColumn.DataPropertyName = "PreCorte"
        Me.PreCorteDataGridViewCheckBoxColumn.HeaderText = "PreCorte"
        Me.PreCorteDataGridViewCheckBoxColumn.Name = "PreCorteDataGridViewCheckBoxColumn"
        Me.PreCorteDataGridViewCheckBoxColumn.ReadOnly = True
        Me.PreCorteDataGridViewCheckBoxColumn.Width = 52
        '
        'CorteDataGridViewCheckBoxColumn
        '
        Me.CorteDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CorteDataGridViewCheckBoxColumn.DataPropertyName = "Corte"
        Me.CorteDataGridViewCheckBoxColumn.HeaderText = "Corte"
        Me.CorteDataGridViewCheckBoxColumn.Name = "CorteDataGridViewCheckBoxColumn"
        Me.CorteDataGridViewCheckBoxColumn.ReadOnly = True
        Me.CorteDataGridViewCheckBoxColumn.Width = 36
        '
        'CanalDataGridViewCheckBoxColumn
        '
        Me.CanalDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CanalDataGridViewCheckBoxColumn.DataPropertyName = "Canal"
        Me.CanalDataGridViewCheckBoxColumn.HeaderText = "Canal"
        Me.CanalDataGridViewCheckBoxColumn.Name = "CanalDataGridViewCheckBoxColumn"
        Me.CanalDataGridViewCheckBoxColumn.ReadOnly = True
        Me.CanalDataGridViewCheckBoxColumn.Width = 38
        '
        'DecomisaDataGridViewCheckBoxColumn
        '
        Me.DecomisaDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DecomisaDataGridViewCheckBoxColumn.DataPropertyName = "Decomisa"
        Me.DecomisaDataGridViewCheckBoxColumn.HeaderText = "Decomisable"
        Me.DecomisaDataGridViewCheckBoxColumn.Name = "DecomisaDataGridViewCheckBoxColumn"
        Me.DecomisaDataGridViewCheckBoxColumn.ReadOnly = True
        Me.DecomisaDataGridViewCheckBoxColumn.Width = 72
        '
        'EnPiezasDataGridViewCheckBoxColumn
        '
        Me.EnPiezasDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.EnPiezasDataGridViewCheckBoxColumn.DataPropertyName = "EnPiezas"
        Me.EnPiezasDataGridViewCheckBoxColumn.HeaderText = "En Piezas"
        Me.EnPiezasDataGridViewCheckBoxColumn.Name = "EnPiezasDataGridViewCheckBoxColumn"
        Me.EnPiezasDataGridViewCheckBoxColumn.ReadOnly = True
        Me.EnPiezasDataGridViewCheckBoxColumn.Width = 52
        '
        'EsMermaDataGridViewTextBoxColumn
        '
        Me.EsMermaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.EsMermaDataGridViewTextBoxColumn.DataPropertyName = "EsMerma"
        Me.EsMermaDataGridViewTextBoxColumn.HeaderText = "Es Merma"
        Me.EsMermaDataGridViewTextBoxColumn.Name = "EsMermaDataGridViewTextBoxColumn"
        Me.EsMermaDataGridViewTextBoxColumn.ReadOnly = True
        Me.EsMermaDataGridViewTextBoxColumn.Width = 71
        '
        'EsDerivable
        '
        Me.EsDerivable.DataPropertyName = "EsDerivable"
        Me.EsDerivable.HeaderText = "Es Derivable"
        Me.EsDerivable.Name = "EsDerivable"
        Me.EsDerivable.ReadOnly = True
        Me.EsDerivable.Width = 52
        '
        'EstatusDataGridViewTextBoxColumn
        '
        Me.EstatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.EstatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.HeaderText = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.Name = "EstatusDataGridViewTextBoxColumn"
        Me.EstatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstatusDataGridViewTextBoxColumn.Width = 65
        '
        'ProductosC
        '
        Me.ProductosC.AllowEdit = True
        Me.ProductosC.AllowNew = True
        Me.ProductosC.AllowRemove = True
        Me.ProductosC.MaximoElementosSeleccionados = 1
        Me.ProductosC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.ProductosC.MostrarAlertas = False
        Me.ProductosC.Name = ""
        Me.ProductosC.RaiseListChangedEvents = True
        '
        'frmBusquedaProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(975, 561)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.Name = "frmBusquedaProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de Productos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtDescripcion As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkInactivo As System.Windows.Forms.CheckBox
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ProductosC As ClasesNegocio.ProductosCollectionsClass
    Friend WithEvents IdProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionCortaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubProductoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PreCorteDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CorteDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CanalDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DecomisaDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents EnPiezasDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents EsMermaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EsDerivable As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
