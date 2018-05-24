<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCapturaInventarioProd
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
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mtb = New MEAToolBar.MEAToolBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFolioEtiqueta = New IntegraLab.Controles.TextBoxMejorado()
        Me.txtCodigoProducto = New IntegraLab.Controles.TextBoxMejorado()
        Me.cmbProducto = New IntegraLab.Controles.ComboBoxMejorado()
        Me.txtPiezas = New IntegraLab.Controles.TextBoxMejorado()
        Me.txtKilos = New IntegraLab.Controles.TextBoxMejorado()
        Me.dtFechaMov = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnLeerExcel = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CmbAlmacenes = New IntegraLab.Controles.ComboBoxMejorado()
        Me.txtCodigoAlmacen = New IntegraLab.Controles.TextBoxMejorado()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DgvProductos = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(838, 32)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "CAPTURA DE INVENTARIO"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DgvProductos)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 131)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(820, 430)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de Productos"
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
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = False
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = False
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 573)
        Me.mtb.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Folio Etiqueta:"
        '
        'txtFolioEtiqueta
        '
        Me.txtFolioEtiqueta.ComboBoxEnlazado = Nothing
        Me.txtFolioEtiqueta.Decimales = 0
        Me.txtFolioEtiqueta.Location = New System.Drawing.Point(130, 71)
        Me.txtFolioEtiqueta.MensajeCombo = "Seleccionar un item..."
        Me.txtFolioEtiqueta.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtFolioEtiqueta.Name = "txtFolioEtiqueta"
        Me.txtFolioEtiqueta.SiguienteControl = Me.txtCodigoProducto
        Me.txtFolioEtiqueta.Size = New System.Drawing.Size(104, 20)
        Me.txtFolioEtiqueta.TabIndex = 3
        Me.txtFolioEtiqueta.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtFolioEtiqueta.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtFolioEtiqueta.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtCodigoProducto
        '
        Me.txtCodigoProducto.ComboBoxEnlazado = Me.cmbProducto
        Me.txtCodigoProducto.Decimales = 0
        Me.txtCodigoProducto.Location = New System.Drawing.Point(299, 67)
        Me.txtCodigoProducto.MaxLength = 3000
        Me.txtCodigoProducto.MensajeCombo = "Seleccionar un producto..."
        Me.txtCodigoProducto.MensajeNoExiste = "No existe un producto con este código o se encuentra inactivo"
        Me.txtCodigoProducto.Name = "txtCodigoProducto"
        Me.txtCodigoProducto.SiguienteControl = Me.txtPiezas
        Me.txtCodigoProducto.Size = New System.Drawing.Size(44, 20)
        Me.txtCodigoProducto.TabIndex = 5
        Me.txtCodigoProducto.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtCodigoProducto.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCodigoProducto.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cmbProducto
        '
        Me.cmbProducto.FormattingEnabled = True
        Me.cmbProducto.Location = New System.Drawing.Point(348, 67)
        Me.cmbProducto.Name = "cmbProducto"
        Me.cmbProducto.NombreMetodo = Nothing
        Me.cmbProducto.Parametros = Nothing
        Me.cmbProducto.SiguienteControl = Me.txtPiezas
        Me.cmbProducto.Size = New System.Drawing.Size(327, 21)
        Me.cmbProducto.TabIndex = 6
        Me.cmbProducto.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbProducto.TextBoxEnlazado = Me.txtCodigoProducto
        '
        'txtPiezas
        '
        Me.txtPiezas.ComboBoxEnlazado = Nothing
        Me.txtPiezas.Decimales = 0
        Me.txtPiezas.Location = New System.Drawing.Point(130, 98)
        Me.txtPiezas.MaxLength = 3000
        Me.txtPiezas.MensajeCombo = "Seleccionar un item..."
        Me.txtPiezas.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtPiezas.Name = "txtPiezas"
        Me.txtPiezas.SiguienteControl = Me.txtKilos
        Me.txtPiezas.Size = New System.Drawing.Size(67, 20)
        Me.txtPiezas.TabIndex = 8
        Me.txtPiezas.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtPiezas.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtPiezas.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtKilos
        '
        Me.txtKilos.ComboBoxEnlazado = Nothing
        Me.txtKilos.Decimales = 2
        Me.txtKilos.Location = New System.Drawing.Point(241, 98)
        Me.txtKilos.MaxLength = 3000
        Me.txtKilos.MensajeCombo = "Seleccionar un item..."
        Me.txtKilos.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtKilos.Name = "txtKilos"
        Me.txtKilos.SiguienteControl = Me.dtFechaMov
        Me.txtKilos.Size = New System.Drawing.Size(75, 20)
        Me.txtKilos.TabIndex = 10
        Me.txtKilos.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.[Decimal]
        Me.txtKilos.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtKilos.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'dtFechaMov
        '
        Me.dtFechaMov.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaMov.Location = New System.Drawing.Point(369, 98)
        Me.dtFechaMov.Name = "dtFechaMov"
        Me.dtFechaMov.ShowUpDown = True
        Me.dtFechaMov.Size = New System.Drawing.Size(94, 20)
        Me.dtFechaMov.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(240, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Producto:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Piezas:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(203, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Kilos:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(323, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Fecha:"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(469, 97)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 13
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnLeerExcel
        '
        Me.btnLeerExcel.Location = New System.Drawing.Point(681, 54)
        Me.btnLeerExcel.Name = "btnLeerExcel"
        Me.btnLeerExcel.Size = New System.Drawing.Size(75, 54)
        Me.btnLeerExcel.TabIndex = 15
        Me.btnLeerExcel.Text = "Leer Archivo de Inventario"
        Me.btnLeerExcel.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Contenedor"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Contenedor"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Contenedor"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Contenedor"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'CmbAlmacenes
        '
        Me.CmbAlmacenes.FormattingEnabled = True
        Me.CmbAlmacenes.Location = New System.Drawing.Point(181, 40)
        Me.CmbAlmacenes.Name = "CmbAlmacenes"
        Me.CmbAlmacenes.NombreMetodo = Nothing
        Me.CmbAlmacenes.Parametros = Nothing
        Me.CmbAlmacenes.SiguienteControl = Me.txtPiezas
        Me.CmbAlmacenes.Size = New System.Drawing.Size(494, 21)
        Me.CmbAlmacenes.TabIndex = 18
        Me.CmbAlmacenes.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.CmbAlmacenes.TextBoxEnlazado = Me.txtCodigoAlmacen
        '
        'txtCodigoAlmacen
        '
        Me.txtCodigoAlmacen.ComboBoxEnlazado = Me.CmbAlmacenes
        Me.txtCodigoAlmacen.Decimales = 0
        Me.txtCodigoAlmacen.Enabled = False
        Me.txtCodigoAlmacen.Location = New System.Drawing.Point(131, 41)
        Me.txtCodigoAlmacen.MaxLength = 3000
        Me.txtCodigoAlmacen.MensajeCombo = "Seleccionar un producto..."
        Me.txtCodigoAlmacen.MensajeNoExiste = "No existe un producto con este código o se encuentra inactivo"
        Me.txtCodigoAlmacen.Name = "txtCodigoAlmacen"
        Me.txtCodigoAlmacen.SiguienteControl = Me.txtPiezas
        Me.txtCodigoAlmacen.Size = New System.Drawing.Size(44, 20)
        Me.txtCodigoAlmacen.TabIndex = 17
        Me.txtCodigoAlmacen.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtCodigoAlmacen.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCodigoAlmacen.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCodigoAlmacen.WordWrap = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(53, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Almacén:"
        Me.Label6.Visible = False
        '
        'DgvProductos
        '
        Me.DgvProductos.AllowUserToAddRows = False
        Me.DgvProductos.AllowUserToResizeRows = False
        Me.DgvProductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvProductos.Location = New System.Drawing.Point(6, 19)
        Me.DgvProductos.Name = "DgvProductos"
        Me.DgvProductos.ReadOnly = True
        Me.DgvProductos.RowHeadersVisible = False
        Me.DgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvProductos.Size = New System.Drawing.Size(808, 405)
        Me.DgvProductos.TabIndex = 0
        '
        'frmCapturaInventarioProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 573)
        Me.Controls.Add(Me.CmbAlmacenes)
        Me.Controls.Add(Me.txtCodigoAlmacen)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnLeerExcel)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dtFechaMov)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtKilos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPiezas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbProducto)
        Me.Controls.Add(Me.txtCodigoProducto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFolioEtiqueta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCapturaInventarioProd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Captura de Inventario"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CajaDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents VicerasDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents CapturaInventarioCajasC As ClasesNegocio.CapturaInventarioCajasCollection
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFolioEtiqueta As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoProducto As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents cmbProducto As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPiezas As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtKilos As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtFechaMov As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnLeerExcel As System.Windows.Forms.Button
    Friend WithEvents LoteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FolioEtiquetaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdFolioEtiquetaReferenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdCorteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CorteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PiezasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdFolioMovimientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoBarraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GradosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaCapturaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaMovimeintoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EntidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeleccionadoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ContenedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IndiceEnContenedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CmbAlmacenes As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents txtCodigoAlmacen As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DgvProductos As System.Windows.Forms.DataGridView
End Class
