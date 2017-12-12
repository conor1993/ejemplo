<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteExistenciasYCostosfrm
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
        Me.mtb = New MiToolBar.miToolBar
        Me.gpbOrdenar = New System.Windows.Forms.GroupBox
        Me.rdbAlmacen = New System.Windows.Forms.RadioButton
        Me.rdbProducto = New System.Windows.Forms.RadioButton
        Me.lblProducto = New System.Windows.Forms.Label
        Me.lblAlmacen = New System.Windows.Forms.Label
        Me.cmbProducto = New Integralab.Controles.ComboBoxMejorado
        Me.txtCodigoAlmacen = New Integralab.Controles.TextBoxMejorado
        Me.cmbAlmacen = New Integralab.Controles.ComboBoxMejorado
        Me.txtCodigoProducto = New Integralab.Controles.TextBoxMejorado
        Me.gpbOrdenar.SuspendLayout()
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
        Me.mtb.MostrarBorrar = False
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = False
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = False
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 240)
        Me.mtb.TabIndex = 3
        '
        'gpbOrdenar
        '
        Me.gpbOrdenar.Controls.Add(Me.rdbAlmacen)
        Me.gpbOrdenar.Controls.Add(Me.rdbProducto)
        Me.gpbOrdenar.Location = New System.Drawing.Point(65, 41)
        Me.gpbOrdenar.Name = "gpbOrdenar"
        Me.gpbOrdenar.Size = New System.Drawing.Size(288, 53)
        Me.gpbOrdenar.TabIndex = 6
        Me.gpbOrdenar.TabStop = False
        Me.gpbOrdenar.Text = "Ordenar Por"
        '
        'rdbAlmacen
        '
        Me.rdbAlmacen.AutoSize = True
        Me.rdbAlmacen.Location = New System.Drawing.Point(111, 25)
        Me.rdbAlmacen.Name = "rdbAlmacen"
        Me.rdbAlmacen.Size = New System.Drawing.Size(66, 17)
        Me.rdbAlmacen.TabIndex = 1
        Me.rdbAlmacen.Text = "Almacén"
        Me.rdbAlmacen.UseVisualStyleBackColor = True
        '
        'rdbProducto
        '
        Me.rdbProducto.AutoSize = True
        Me.rdbProducto.Checked = True
        Me.rdbProducto.Location = New System.Drawing.Point(19, 25)
        Me.rdbProducto.Name = "rdbProducto"
        Me.rdbProducto.Size = New System.Drawing.Size(68, 17)
        Me.rdbProducto.TabIndex = 0
        Me.rdbProducto.TabStop = True
        Me.rdbProducto.Text = "Producto"
        Me.rdbProducto.UseVisualStyleBackColor = True
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(62, 133)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(53, 13)
        Me.lblProducto.TabIndex = 7
        Me.lblProducto.Text = "Producto:"
        '
        'lblAlmacen
        '
        Me.lblAlmacen.AutoSize = True
        Me.lblAlmacen.Location = New System.Drawing.Point(64, 160)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.Size = New System.Drawing.Size(51, 13)
        Me.lblAlmacen.TabIndex = 8
        Me.lblAlmacen.Text = "Almacén:"
        '
        'cmbProducto
        '
        Me.cmbProducto.FormattingEnabled = True
        Me.cmbProducto.Location = New System.Drawing.Point(197, 130)
        Me.cmbProducto.Name = "cmbProducto"
        Me.cmbProducto.NombreMetodo = Nothing
        Me.cmbProducto.Parametros = Nothing
        Me.cmbProducto.SiguienteControl = Me.txtCodigoAlmacen
        Me.cmbProducto.Size = New System.Drawing.Size(212, 21)
        Me.cmbProducto.Sorted = True
        Me.cmbProducto.TabIndex = 9
        Me.cmbProducto.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbProducto.TextBoxEnlazado = Me.txtCodigoProducto
        '
        'txtCodigoAlmacen
        '
        Me.txtCodigoAlmacen.ComboBoxEnlazado = Nothing
        Me.txtCodigoAlmacen.Decimales = 0
        Me.txtCodigoAlmacen.Location = New System.Drawing.Point(121, 157)
        Me.txtCodigoAlmacen.MensajeCombo = "Seleccionar un item..."
        Me.txtCodigoAlmacen.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtCodigoAlmacen.Name = "txtCodigoAlmacen"
        Me.txtCodigoAlmacen.SiguienteControl = Me.cmbAlmacen
        Me.txtCodigoAlmacen.Size = New System.Drawing.Size(70, 20)
        Me.txtCodigoAlmacen.TabIndex = 12
        Me.txtCodigoAlmacen.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'cmbAlmacen
        '
        Me.cmbAlmacen.FormattingEnabled = True
        Me.cmbAlmacen.Location = New System.Drawing.Point(197, 157)
        Me.cmbAlmacen.Name = "cmbAlmacen"
        Me.cmbAlmacen.NombreMetodo = Nothing
        Me.cmbAlmacen.Parametros = Nothing
        Me.cmbAlmacen.SiguienteControl = Me.mtb
        Me.cmbAlmacen.Size = New System.Drawing.Size(212, 21)
        Me.cmbAlmacen.Sorted = True
        Me.cmbAlmacen.TabIndex = 10
        Me.cmbAlmacen.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbAlmacen.TextBoxEnlazado = Me.txtCodigoAlmacen
        '
        'txtCodigoProducto
        '
        Me.txtCodigoProducto.ComboBoxEnlazado = Nothing
        Me.txtCodigoProducto.Decimales = 0
        Me.txtCodigoProducto.Location = New System.Drawing.Point(121, 130)
        Me.txtCodigoProducto.MensajeCombo = "Seleccione un Producto"
        Me.txtCodigoProducto.MensajeNoExiste = "No existe un producto con ese Código"
        Me.txtCodigoProducto.Name = "txtCodigoProducto"
        Me.txtCodigoProducto.SiguienteControl = Me.cmbProducto
        Me.txtCodigoProducto.Size = New System.Drawing.Size(70, 20)
        Me.txtCodigoProducto.TabIndex = 11
        Me.txtCodigoProducto.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'ReporteExistenciasYCostosfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 240)
        Me.Controls.Add(Me.txtCodigoAlmacen)
        Me.Controls.Add(Me.txtCodigoProducto)
        Me.Controls.Add(Me.cmbAlmacen)
        Me.Controls.Add(Me.cmbProducto)
        Me.Controls.Add(Me.lblAlmacen)
        Me.Controls.Add(Me.lblProducto)
        Me.Controls.Add(Me.gpbOrdenar)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ReporteExistenciasYCostosfrm"
        Me.Text = "Reporte de Existencias y Costos de Almacén"
        Me.gpbOrdenar.ResumeLayout(False)
        Me.gpbOrdenar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MiToolBar.miToolBar
    Friend WithEvents gpbOrdenar As System.Windows.Forms.GroupBox
    Friend WithEvents rdbAlmacen As System.Windows.Forms.RadioButton
    Friend WithEvents rdbProducto As System.Windows.Forms.RadioButton
    Friend WithEvents lblProducto As System.Windows.Forms.Label
    Friend WithEvents lblAlmacen As System.Windows.Forms.Label
    Friend WithEvents cmbProducto As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents cmbAlmacen As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents txtCodigoProducto As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtCodigoAlmacen As IntegraLab.Controles.TextBoxMejorado
End Class
