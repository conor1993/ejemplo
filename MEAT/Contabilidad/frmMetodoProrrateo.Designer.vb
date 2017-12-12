<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMetodoProrrateo
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
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtTotalPorcentaje = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.dgDetalle = New System.Windows.Forms.DataGridView
        Me.txtDescripcion = New Integralab.Controles.TextBoxMejorado
        Me.txtCodigo = New Integralab.Controles.TextBoxMejorado
        Me.MetodoProrrateoDetalleC = New ClasesNegocio.MetodoProrrateoDetalleCollectionClass
        Me.clmCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmDepartemanto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPorcentaje = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(50, 0)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(564, 29)
        Me.lblTitulo.TabIndex = 3
        Me.lblTitulo.Text = "METODO DE PRORRATEO"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.mtb.Size = New System.Drawing.Size(50, 495)
        Me.mtb.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Código:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Descripción:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtTotalPorcentaje)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dgDetalle)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(546, 393)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle"
        '
        'txtTotalPorcentaje
        '
        Me.txtTotalPorcentaje.Enabled = False
        Me.txtTotalPorcentaje.Location = New System.Drawing.Point(479, 360)
        Me.txtTotalPorcentaje.Name = "txtTotalPorcentaje"
        Me.txtTotalPorcentaje.Size = New System.Drawing.Size(61, 20)
        Me.txtTotalPorcentaje.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(385, 363)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Total Porcentaje:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgDetalle
        '
        Me.dgDetalle.AllowUserToAddRows = False
        Me.dgDetalle.AllowUserToDeleteRows = False
        Me.dgDetalle.AllowUserToResizeRows = False
        Me.dgDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmCodigo, Me.clmDepartemanto, Me.clmPorcentaje})
        Me.dgDetalle.Location = New System.Drawing.Point(6, 19)
        Me.dgDetalle.MultiSelect = False
        Me.dgDetalle.Name = "dgDetalle"
        Me.dgDetalle.RowHeadersVisible = False
        Me.dgDetalle.Size = New System.Drawing.Size(534, 334)
        Me.dgDetalle.TabIndex = 0
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.ComboBoxEnlazado = Nothing
        Me.txtDescripcion.Decimales = 0
        Me.txtDescripcion.Location = New System.Drawing.Point(128, 64)
        Me.txtDescripcion.MaxLength = 40
        Me.txtDescripcion.MensajeCombo = "Seleccionar un item..."
        Me.txtDescripcion.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.SiguienteControl = Nothing
        Me.txtDescripcion.Size = New System.Drawing.Size(446, 20)
        Me.txtDescripcion.TabIndex = 7
        Me.txtDescripcion.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtDescripcion.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtDescripcion.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtCodigo
        '
        Me.txtCodigo.ComboBoxEnlazado = Nothing
        Me.txtCodigo.Decimales = 0
        Me.txtCodigo.Location = New System.Drawing.Point(128, 38)
        Me.txtCodigo.MaxLength = 3000
        Me.txtCodigo.MensajeCombo = "Seleccionar un item..."
        Me.txtCodigo.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.SiguienteControl = Nothing
        Me.txtCodigo.Size = New System.Drawing.Size(52, 20)
        Me.txtCodigo.TabIndex = 6
        Me.txtCodigo.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtCodigo.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCodigo.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'MetodoProrrateoDetalleC
        '
        Me.MetodoProrrateoDetalleC.AllowEdit = True
        Me.MetodoProrrateoDetalleC.AllowNew = True
        Me.MetodoProrrateoDetalleC.AllowRemove = True
        Me.MetodoProrrateoDetalleC.MaximoElementosSeleccionados = 1
        Me.MetodoProrrateoDetalleC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.MetodoProrrateoDetalleC.MostrarAlertas = False
        Me.MetodoProrrateoDetalleC.Name = Nothing
        Me.MetodoProrrateoDetalleC.RaiseListChangedEvents = True
        Me.MetodoProrrateoDetalleC.Transaction = Nothing
        '
        'clmCodigo
        '
        Me.clmCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmCodigo.DataPropertyName = "IdDepartamento"
        Me.clmCodigo.HeaderText = "Código"
        Me.clmCodigo.Name = "clmCodigo"
        Me.clmCodigo.ReadOnly = True
        Me.clmCodigo.Width = 65
        '
        'clmDepartemanto
        '
        Me.clmDepartemanto.DataPropertyName = "Departamento"
        Me.clmDepartemanto.HeaderText = "Departamento"
        Me.clmDepartemanto.Name = "clmDepartemanto"
        '
        'clmPorcentaje
        '
        Me.clmPorcentaje.DataPropertyName = "Porcentaje"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.clmPorcentaje.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmPorcentaje.HeaderText = "Porcentaje"
        Me.clmPorcentaje.Name = "clmPorcentaje"
        '
        'frmMetodoProrrateo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 495)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.mtb)
        Me.MaximizeBox = False
        Me.Name = "frmMetodoProrrateo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Metodo de Prorrateo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As Integralab.Controles.TextBoxMejorado
    Friend WithEvents txtDescripcion As Integralab.Controles.TextBoxMejorado
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents MetodoProrrateoDetalleC As ClasesNegocio.MetodoProrrateoDetalleCollectionClass
    Friend WithEvents txtTotalPorcentaje As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents clmCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDepartemanto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPorcentaje As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
