<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteFacturasPorCliente
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
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNoFactura = New Integralab.Controles.TextBoxMejorado
        Me.txtCodigoCliente = New Integralab.Controles.TextBoxMejorado
        Me.cmbCliente = New Integralab.Controles.ComboBoxMejorado
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.chkFiltrar = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.optClienteTipoProducto = New System.Windows.Forms.RadioButton
        Me.optTipoProductoCliente = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = False
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = False
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 185)
        Me.mtb.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(537, 32)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "REPORTE DE FACTURAS POR CLIENTE"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "No Factura:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cliente:"
        '
        'txtNoFactura
        '
        Me.txtNoFactura.ComboBoxEnlazado = Nothing
        Me.txtNoFactura.Decimales = 0
        Me.txtNoFactura.Location = New System.Drawing.Point(125, 40)
        Me.txtNoFactura.MensajeCombo = "Seleccionar un item..."
        Me.txtNoFactura.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtNoFactura.Name = "txtNoFactura"
        Me.txtNoFactura.SiguienteControl = Nothing
        Me.txtNoFactura.Size = New System.Drawing.Size(88, 20)
        Me.txtNoFactura.TabIndex = 3
        Me.txtNoFactura.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.ComboBoxEnlazado = Nothing
        Me.txtCodigoCliente.Decimales = 0
        Me.txtCodigoCliente.Location = New System.Drawing.Point(125, 66)
        Me.txtCodigoCliente.MensajeCombo = "Seleccionar un item..."
        Me.txtCodigoCliente.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.SiguienteControl = Nothing
        Me.txtCodigoCliente.Size = New System.Drawing.Size(48, 20)
        Me.txtCodigoCliente.TabIndex = 5
        Me.txtCodigoCliente.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'cmbCliente
        '
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(179, 66)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.NombreMetodo = Nothing
        Me.cmbCliente.Parametros = Nothing
        Me.cmbCliente.SiguienteControl = Nothing
        Me.cmbCliente.Size = New System.Drawing.Size(383, 21)
        Me.cmbCliente.TabIndex = 6
        Me.cmbCliente.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbCliente.TextBoxEnlazado = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtFechaFinal)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtFechaInicial)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(186, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 80)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rango de Fechas"
        '
        'dtFechaFinal
        '
        Me.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaFinal.Location = New System.Drawing.Point(82, 47)
        Me.dtFechaFinal.Name = "dtFechaFinal"
        Me.dtFechaFinal.Size = New System.Drawing.Size(112, 20)
        Me.dtFechaFinal.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Fecha Final:"
        '
        'dtFechaInicial
        '
        Me.dtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaInicial.Location = New System.Drawing.Point(82, 21)
        Me.dtFechaInicial.Name = "dtFechaInicial"
        Me.dtFechaInicial.Size = New System.Drawing.Size(112, 20)
        Me.dtFechaInicial.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Fecha Inicial:"
        '
        'chkFiltrar
        '
        Me.chkFiltrar.AutoSize = True
        Me.chkFiltrar.Checked = True
        Me.chkFiltrar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFiltrar.Location = New System.Drawing.Point(66, 93)
        Me.chkFiltrar.Name = "chkFiltrar"
        Me.chkFiltrar.Size = New System.Drawing.Size(114, 17)
        Me.chkFiltrar.TabIndex = 7
        Me.chkFiltrar.Text = "¿Filtrar por Fecha?"
        Me.chkFiltrar.UseVisualStyleBackColor = True
        Me.chkFiltrar.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optTipoProductoCliente)
        Me.GroupBox2.Controls.Add(Me.optClienteTipoProducto)
        Me.GroupBox2.Location = New System.Drawing.Point(392, 93)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(179, 80)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ordenado por :"
        '
        'optClienteTipoProducto
        '
        Me.optClienteTipoProducto.AutoSize = True
        Me.optClienteTipoProducto.Location = New System.Drawing.Point(15, 23)
        Me.optClienteTipoProducto.Name = "optClienteTipoProducto"
        Me.optClienteTipoProducto.Size = New System.Drawing.Size(148, 17)
        Me.optClienteTipoProducto.TabIndex = 0
        Me.optClienteTipoProducto.TabStop = True
        Me.optClienteTipoProducto.Text = "Cliente - Tipo de Producto"
        Me.optClienteTipoProducto.UseVisualStyleBackColor = True
        '
        'optTipoProductoCliente
        '
        Me.optTipoProductoCliente.AutoSize = True
        Me.optTipoProductoCliente.Location = New System.Drawing.Point(15, 51)
        Me.optTipoProductoCliente.Name = "optTipoProductoCliente"
        Me.optTipoProductoCliente.Size = New System.Drawing.Size(148, 17)
        Me.optTipoProductoCliente.TabIndex = 1
        Me.optTipoProductoCliente.TabStop = True
        Me.optTipoProductoCliente.Text = "Tipo de Producto - Cliente"
        Me.optTipoProductoCliente.UseVisualStyleBackColor = True
        '
        'frmReporteFacturasPorCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 185)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.chkFiltrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbCliente)
        Me.Controls.Add(Me.txtCodigoCliente)
        Me.Controls.Add(Me.txtNoFactura)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReporteFacturasPorCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Facturas Por Cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNoFactura As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtCodigoCliente As Integralab.Controles.TextBoxMejorado
    Friend WithEvents cmbCliente As Integralab.Controles.ComboBoxMejorado
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkFiltrar As System.Windows.Forms.CheckBox
    Friend WithEvents dtFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents optTipoProductoCliente As System.Windows.Forms.RadioButton
    Friend WithEvents optClienteTipoProducto As System.Windows.Forms.RadioButton
End Class
