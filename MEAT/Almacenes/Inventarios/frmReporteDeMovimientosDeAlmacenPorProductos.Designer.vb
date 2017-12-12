<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteDeMovimientosDeAlmacenPorProductos
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.txtProducto = New Integralab.Controles.TextBoxMejorado
        Me.cmbProducto = New Integralab.Controles.ComboBoxMejorado
        Me.cmbAlmacen = New Integralab.Controles.ComboBoxMejorado
        Me.txtAlmacen = New Integralab.Controles.TextBoxMejorado
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbMovimiento = New Integralab.Controles.ComboBoxMejorado
        Me.movimiento = New ClasesNegocio.TipoMovimientoAlmacenCollectionClass
        Me.txtMovimiento = New Integralab.Controles.TextBoxMejorado
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Producto:"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(439, 32)
        Me.Label17.TabIndex = 46
        Me.Label17.Text = "Reporte De Movimientos De Almacén Por Productos"
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
        Me.mtb.Size = New System.Drawing.Size(50, 232)
        Me.mtb.TabIndex = 47
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.dtpFechaFinal)
        Me.GroupBox3.Controls.Add(Me.dtpFechaInicial)
        Me.GroupBox3.Location = New System.Drawing.Point(74, 147)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 75)
        Me.GroupBox3.TabIndex = 51
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Rango De Fechas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Fecha Final:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Fecha Inicial:"
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(100, 49)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(94, 20)
        Me.dtpFechaFinal.TabIndex = 1
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicial.Location = New System.Drawing.Point(100, 17)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(94, 20)
        Me.dtpFechaInicial.TabIndex = 0
        '
        'txtProducto
        '
        Me.txtProducto.ComboBoxEnlazado = Me.cmbProducto
        Me.txtProducto.Decimales = 0
        Me.txtProducto.Location = New System.Drawing.Point(161, 51)
        Me.txtProducto.MaxLength = 3000
        Me.txtProducto.MensajeCombo = "Seleccionar un productos..."
        Me.txtProducto.MensajeNoExiste = "No existe un productos con este código o se encuentra inactivo"
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.SiguienteControl = Nothing
        Me.txtProducto.Size = New System.Drawing.Size(55, 20)
        Me.txtProducto.TabIndex = 52
        Me.txtProducto.Text = "          "
        Me.txtProducto.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        '
        'cmbProducto
        '
        Me.cmbProducto.FormattingEnabled = True
        Me.cmbProducto.Location = New System.Drawing.Point(222, 51)
        Me.cmbProducto.Name = "cmbProducto"
        Me.cmbProducto.NombreMetodo = Nothing
        Me.cmbProducto.Parametros = Nothing
        Me.cmbProducto.SiguienteControl = Nothing
        Me.cmbProducto.Size = New System.Drawing.Size(246, 21)
        Me.cmbProducto.TabIndex = 53
        Me.cmbProducto.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbProducto.TextBoxEnlazado = Me.txtProducto
        '
        'cmbAlmacen
        '
        Me.cmbAlmacen.FormattingEnabled = True
        Me.cmbAlmacen.Location = New System.Drawing.Point(222, 78)
        Me.cmbAlmacen.Name = "cmbAlmacen"
        Me.cmbAlmacen.NombreMetodo = Nothing
        Me.cmbAlmacen.Parametros = Nothing
        Me.cmbAlmacen.SiguienteControl = Nothing
        Me.cmbAlmacen.Size = New System.Drawing.Size(246, 21)
        Me.cmbAlmacen.Sorted = True
        Me.cmbAlmacen.TabIndex = 55
        Me.cmbAlmacen.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbAlmacen.TextBoxEnlazado = Me.txtAlmacen
        '
        'txtAlmacen
        '
        Me.txtAlmacen.ComboBoxEnlazado = Me.cmbAlmacen
        Me.txtAlmacen.Decimales = 0
        Me.txtAlmacen.Location = New System.Drawing.Point(161, 78)
        Me.txtAlmacen.MaxLength = 3000
        Me.txtAlmacen.MensajeCombo = "Seleccionar un productos..."
        Me.txtAlmacen.MensajeNoExiste = "No existe un productos con este código o se encuentra inactivo"
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.SiguienteControl = Nothing
        Me.txtAlmacen.Size = New System.Drawing.Size(55, 20)
        Me.txtAlmacen.TabIndex = 54
        Me.txtAlmacen.Text = "  "
        Me.txtAlmacen.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Almacén:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Tipo Movimiento:"
        '
        'cmbMovimiento
        '
        Me.cmbMovimiento.DataSource = Me.movimiento
        Me.cmbMovimiento.DisplayMember = "Nombre"
        Me.cmbMovimiento.FormattingEnabled = True
        Me.cmbMovimiento.Location = New System.Drawing.Point(222, 105)
        Me.cmbMovimiento.Name = "cmbMovimiento"
        Me.cmbMovimiento.NombreMetodo = Nothing
        Me.cmbMovimiento.Parametros = Nothing
        Me.cmbMovimiento.SiguienteControl = Nothing
        Me.cmbMovimiento.Size = New System.Drawing.Size(246, 21)
        Me.cmbMovimiento.TabIndex = 58
        Me.cmbMovimiento.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbMovimiento.TextBoxEnlazado = Me.txtMovimiento
        Me.cmbMovimiento.ValueMember = "Codigo"
        '
        'movimiento
        '
        Me.movimiento.AllowEdit = True
        Me.movimiento.AllowNew = True
        Me.movimiento.AllowRemove = True
        Me.movimiento.Name = ""
        Me.movimiento.RaiseListChangedEvents = True
        '
        'txtMovimiento
        '
        Me.txtMovimiento.ComboBoxEnlazado = Me.cmbMovimiento
        Me.txtMovimiento.Decimales = 0
        Me.txtMovimiento.Location = New System.Drawing.Point(161, 105)
        Me.txtMovimiento.MaxLength = 3000
        Me.txtMovimiento.MensajeCombo = "Seleccionar un productos..."
        Me.txtMovimiento.MensajeNoExiste = "No existe  productos con este código o se encuentra inactivo"
        Me.txtMovimiento.Name = "txtMovimiento"
        Me.txtMovimiento.SiguienteControl = Nothing
        Me.txtMovimiento.Size = New System.Drawing.Size(55, 20)
        Me.txtMovimiento.TabIndex = 57
        Me.txtMovimiento.Text = " "
        Me.txtMovimiento.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        '
        'frmReporteDeMovimientosDeAlmacenPorProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 232)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbMovimiento)
        Me.Controls.Add(Me.txtMovimiento)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbAlmacen)
        Me.Controls.Add(Me.txtAlmacen)
        Me.Controls.Add(Me.cmbProducto)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReporteDeMovimientosDeAlmacenPorProductos"
        Me.Text = "Reporte De Movimientos De Almacén Por Productos"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtProducto As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents cmbProducto As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents cmbAlmacen As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents txtAlmacen As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbMovimiento As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents txtMovimiento As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents movimiento As ClasesNegocio.TipoMovimientoAlmacenCollectionClass
End Class
