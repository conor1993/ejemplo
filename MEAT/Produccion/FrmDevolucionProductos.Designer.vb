<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDevolucionProductos
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
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtTipoProducto = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtFolio = New Integralab.Controles.TextBoxMejorado
        Me.txtIdProducto = New Integralab.Controles.TextBoxMejorado
        Me.cmbProducto = New Integralab.Controles.ComboBoxMejorado
        Me.txtPiezas = New Integralab.Controles.TextBoxMejorado
        Me.txtKilos = New Integralab.Controles.TextBoxMejorado
        Me.chkUtil = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtEmbarque = New Integralab.Controles.TextBoxMejorado
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCliente = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DgvDevoluciones = New System.Windows.Forms.DataGridView
        Me.FolioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NomProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PiezasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KilosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UtilVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.FolioEmbarqueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NomClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DevoluccioneProdC = New ClasesNegocio.DevolucionProductosCollectionClass
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvDevoluciones, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.mtb.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32
        Me.mtb.Location = New System.Drawing.Point(0, 0)
        Me.mtb.MostrarBorrar = False
        Me.mtb.MostrarBuscar = True
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = True
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 390)
        Me.mtb.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(563, 32)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "DEVOLUCIÓN DE PRODUCTOS"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Folio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Producto:"
        '
        'txtTipoProducto
        '
        Me.txtTipoProducto.Location = New System.Drawing.Point(448, 126)
        Me.txtTipoProducto.Name = "txtTipoProducto"
        Me.txtTipoProducto.ReadOnly = True
        Me.txtTipoProducto.Size = New System.Drawing.Size(157, 20)
        Me.txtTipoProducto.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Piezas:"
        '
        'txtFolio
        '
        Me.txtFolio.ComboBoxEnlazado = Nothing
        Me.txtFolio.Decimales = 0
        Me.txtFolio.Location = New System.Drawing.Point(122, 48)
        Me.txtFolio.MensajeCombo = "Seleccionar un item..."
        Me.txtFolio.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.ReadOnly = True
        Me.txtFolio.SiguienteControl = Me.txtIdProducto
        Me.txtFolio.Size = New System.Drawing.Size(100, 20)
        Me.txtFolio.TabIndex = 23
        Me.txtFolio.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'txtIdProducto
        '
        Me.txtIdProducto.ComboBoxEnlazado = Me.cmbProducto
        Me.txtIdProducto.Decimales = 0
        Me.txtIdProducto.Location = New System.Drawing.Point(122, 126)
        Me.txtIdProducto.MaxLength = 3000
        Me.txtIdProducto.MensajeCombo = "Seleccionar un Producto..."
        Me.txtIdProducto.MensajeNoExiste = "No existe un Producto con este código o se encuentra inactivo"
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.SiguienteControl = Me.cmbProducto
        Me.txtIdProducto.Size = New System.Drawing.Size(52, 20)
        Me.txtIdProducto.TabIndex = 32
        Me.txtIdProducto.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        '
        'cmbProducto
        '
        Me.cmbProducto.FormattingEnabled = True
        Me.cmbProducto.Location = New System.Drawing.Point(180, 125)
        Me.cmbProducto.Name = "cmbProducto"
        Me.cmbProducto.NombreMetodo = Nothing
        Me.cmbProducto.Parametros = Nothing
        Me.cmbProducto.SiguienteControl = Me.txtPiezas
        Me.cmbProducto.Size = New System.Drawing.Size(262, 21)
        Me.cmbProducto.TabIndex = 33
        Me.cmbProducto.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbProducto.TextBoxEnlazado = Me.txtIdProducto
        '
        'txtPiezas
        '
        Me.txtPiezas.ComboBoxEnlazado = Nothing
        Me.txtPiezas.Decimales = 0
        Me.txtPiezas.Location = New System.Drawing.Point(122, 152)
        Me.txtPiezas.MaxLength = 3000
        Me.txtPiezas.MensajeCombo = "Seleccionar un item..."
        Me.txtPiezas.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtPiezas.Name = "txtPiezas"
        Me.txtPiezas.SiguienteControl = Me.txtKilos
        Me.txtPiezas.Size = New System.Drawing.Size(72, 20)
        Me.txtPiezas.TabIndex = 24
        Me.txtPiezas.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        '
        'txtKilos
        '
        Me.txtKilos.ComboBoxEnlazado = Nothing
        Me.txtKilos.Decimales = 0
        Me.txtKilos.Location = New System.Drawing.Point(263, 152)
        Me.txtKilos.MaxLength = 3000
        Me.txtKilos.MensajeCombo = "Seleccionar un item..."
        Me.txtKilos.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtKilos.Name = "txtKilos"
        Me.txtKilos.SiguienteControl = Me.chkUtil
        Me.txtKilos.Size = New System.Drawing.Size(84, 20)
        Me.txtKilos.TabIndex = 26
        Me.txtKilos.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        '
        'chkUtil
        '
        Me.chkUtil.AutoSize = True
        Me.chkUtil.Location = New System.Drawing.Point(383, 154)
        Me.chkUtil.Name = "chkUtil"
        Me.chkUtil.Size = New System.Drawing.Size(110, 17)
        Me.chkUtil.TabIndex = 27
        Me.chkUtil.Text = "No útil para venta"
        Me.chkUtil.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(225, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Kilos:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Embarque:"
        '
        'txtEmbarque
        '
        Me.txtEmbarque.ComboBoxEnlazado = Nothing
        Me.txtEmbarque.Decimales = 0
        Me.txtEmbarque.Location = New System.Drawing.Point(122, 74)
        Me.txtEmbarque.MensajeCombo = "Seleccionar un item..."
        Me.txtEmbarque.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtEmbarque.Name = "txtEmbarque"
        Me.txtEmbarque.SiguienteControl = Me.txtFolio
        Me.txtEmbarque.Size = New System.Drawing.Size(135, 20)
        Me.txtEmbarque.TabIndex = 29
        Me.txtEmbarque.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(56, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Cliente:"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(122, 100)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(371, 20)
        Me.txtCliente.TabIndex = 31
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvDevoluciones)
        Me.GroupBox1.Location = New System.Drawing.Point(59, 188)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(542, 190)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Productos Registrados en Devolución"
        '
        'DgvDevoluciones
        '
        Me.DgvDevoluciones.AllowUserToAddRows = False
        Me.DgvDevoluciones.AllowUserToDeleteRows = False
        Me.DgvDevoluciones.AllowUserToResizeRows = False
        Me.DgvDevoluciones.AutoGenerateColumns = False
        Me.DgvDevoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDevoluciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FolioDataGridViewTextBoxColumn, Me.IdProductoDataGridViewTextBoxColumn, Me.NomProductoDataGridViewTextBoxColumn, Me.PiezasDataGridViewTextBoxColumn, Me.KilosDataGridViewTextBoxColumn, Me.UtilVentaDataGridViewTextBoxColumn, Me.FolioEmbarqueDataGridViewTextBoxColumn, Me.IdClienteDataGridViewTextBoxColumn, Me.NomClienteDataGridViewTextBoxColumn})
        Me.DgvDevoluciones.DataSource = Me.DevoluccioneProdC
        Me.DgvDevoluciones.Location = New System.Drawing.Point(6, 19)
        Me.DgvDevoluciones.MultiSelect = False
        Me.DgvDevoluciones.Name = "DgvDevoluciones"
        Me.DgvDevoluciones.ReadOnly = True
        Me.DgvDevoluciones.RowHeadersVisible = False
        Me.DgvDevoluciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDevoluciones.Size = New System.Drawing.Size(530, 165)
        Me.DgvDevoluciones.TabIndex = 0
        '
        'FolioDataGridViewTextBoxColumn
        '
        Me.FolioDataGridViewTextBoxColumn.DataPropertyName = "Folio"
        Me.FolioDataGridViewTextBoxColumn.HeaderText = "Folio"
        Me.FolioDataGridViewTextBoxColumn.Name = "FolioDataGridViewTextBoxColumn"
        Me.FolioDataGridViewTextBoxColumn.ReadOnly = True
        Me.FolioDataGridViewTextBoxColumn.Width = 80
        '
        'IdProductoDataGridViewTextBoxColumn
        '
        Me.IdProductoDataGridViewTextBoxColumn.DataPropertyName = "IdProducto"
        Me.IdProductoDataGridViewTextBoxColumn.HeaderText = "IdProducto"
        Me.IdProductoDataGridViewTextBoxColumn.Name = "IdProductoDataGridViewTextBoxColumn"
        Me.IdProductoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdProductoDataGridViewTextBoxColumn.Visible = False
        '
        'NomProductoDataGridViewTextBoxColumn
        '
        Me.NomProductoDataGridViewTextBoxColumn.DataPropertyName = "NomProducto"
        Me.NomProductoDataGridViewTextBoxColumn.HeaderText = "Producto"
        Me.NomProductoDataGridViewTextBoxColumn.Name = "NomProductoDataGridViewTextBoxColumn"
        Me.NomProductoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PiezasDataGridViewTextBoxColumn
        '
        Me.PiezasDataGridViewTextBoxColumn.DataPropertyName = "Piezas"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.PiezasDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.PiezasDataGridViewTextBoxColumn.HeaderText = "Piezas"
        Me.PiezasDataGridViewTextBoxColumn.Name = "PiezasDataGridViewTextBoxColumn"
        Me.PiezasDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KilosDataGridViewTextBoxColumn
        '
        Me.KilosDataGridViewTextBoxColumn.DataPropertyName = "Kilos"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.KilosDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.KilosDataGridViewTextBoxColumn.HeaderText = "Kilos"
        Me.KilosDataGridViewTextBoxColumn.Name = "KilosDataGridViewTextBoxColumn"
        Me.KilosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UtilVentaDataGridViewTextBoxColumn
        '
        Me.UtilVentaDataGridViewTextBoxColumn.DataPropertyName = "UtilVenta"
        Me.UtilVentaDataGridViewTextBoxColumn.HeaderText = "Util Venta"
        Me.UtilVentaDataGridViewTextBoxColumn.Name = "UtilVentaDataGridViewTextBoxColumn"
        Me.UtilVentaDataGridViewTextBoxColumn.ReadOnly = True
        Me.UtilVentaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UtilVentaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.UtilVentaDataGridViewTextBoxColumn.Width = 80
        '
        'FolioEmbarqueDataGridViewTextBoxColumn
        '
        Me.FolioEmbarqueDataGridViewTextBoxColumn.DataPropertyName = "FolioEmbarque"
        Me.FolioEmbarqueDataGridViewTextBoxColumn.HeaderText = "Folio Embarque"
        Me.FolioEmbarqueDataGridViewTextBoxColumn.Name = "FolioEmbarqueDataGridViewTextBoxColumn"
        Me.FolioEmbarqueDataGridViewTextBoxColumn.ReadOnly = True
        Me.FolioEmbarqueDataGridViewTextBoxColumn.Width = 105
        '
        'IdClienteDataGridViewTextBoxColumn
        '
        Me.IdClienteDataGridViewTextBoxColumn.DataPropertyName = "IdCliente"
        Me.IdClienteDataGridViewTextBoxColumn.HeaderText = "IdCliente"
        Me.IdClienteDataGridViewTextBoxColumn.Name = "IdClienteDataGridViewTextBoxColumn"
        Me.IdClienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdClienteDataGridViewTextBoxColumn.Visible = False
        '
        'NomClienteDataGridViewTextBoxColumn
        '
        Me.NomClienteDataGridViewTextBoxColumn.DataPropertyName = "NomCliente"
        Me.NomClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.NomClienteDataGridViewTextBoxColumn.Name = "NomClienteDataGridViewTextBoxColumn"
        Me.NomClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DevoluccioneProdC
        '
        Me.DevoluccioneProdC.AllowEdit = True
        Me.DevoluccioneProdC.AllowNew = True
        Me.DevoluccioneProdC.AllowRemove = True
        Me.DevoluccioneProdC.Name = Nothing
        Me.DevoluccioneProdC.RaiseListChangedEvents = True
        '
        'FrmDevolucionProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 390)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbProducto)
        Me.Controls.Add(Me.txtIdProducto)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtEmbarque)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chkUtil)
        Me.Controls.Add(Me.txtKilos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPiezas)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTipoProducto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.Name = "FrmDevolucionProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DEVOLUCIÓN DE PRODUCTOS"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgvDevoluciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTipoProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFolio As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtPiezas As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtKilos As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents chkUtil As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtEmbarque As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtIdProducto As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents cmbProducto As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DgvDevoluciones As System.Windows.Forms.DataGridView
    Friend WithEvents DevoluccioneProdC As ClasesNegocio.DevolucionProductosCollectionClass
    Friend WithEvents FolioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PiezasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UtilVentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FolioEmbarqueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
