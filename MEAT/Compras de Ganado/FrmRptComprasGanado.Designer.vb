<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRptComprasGanado
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
        Me.chkFiltrar = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chkCanceladas = New System.Windows.Forms.CheckBox
        Me.chkVigentes = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.DtpFechaFin = New System.Windows.Forms.DateTimePicker
        Me.DtpFechaIni = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtFolioCompra = New Integralab.Controles.TextBoxMejorado
        Me.txtCodigoProveedor = New Integralab.Controles.TextBoxMejorado
        Me.cmbProveedor = New Integralab.Controles.ComboBoxMejorado
        Me.txtCodigoComprador = New Integralab.Controles.TextBoxMejorado
        Me.cmbComprador = New Integralab.Controles.ComboBoxMejorado
        Me.txtCodigoCorral = New Integralab.Controles.TextBoxMejorado
        Me.cmbCorral = New Integralab.Controles.ComboBoxMejorado
        Me.txtCodigoLugarCompra = New Integralab.Controles.TextBoxMejorado
        Me.cmbLugarCompra = New Integralab.Controles.ComboBoxMejorado
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.busquedaRecepcionCompras = New Integralab.ORM.TypedViewClasses.VwBusquedaComprasdeGanadoTypedView
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.busquedaRecepcionCompras, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.mtb.Size = New System.Drawing.Size(50, 288)
        Me.mtb.TabIndex = 48
        '
        'chkFiltrar
        '
        Me.chkFiltrar.AutoSize = True
        Me.chkFiltrar.Location = New System.Drawing.Point(59, 175)
        Me.chkFiltrar.Name = "chkFiltrar"
        Me.chkFiltrar.Size = New System.Drawing.Size(103, 17)
        Me.chkFiltrar.TabIndex = 78
        Me.chkFiltrar.Text = "Filtrar Por Fecha"
        Me.chkFiltrar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkCanceladas)
        Me.GroupBox2.Controls.Add(Me.chkVigentes)
        Me.GroupBox2.Location = New System.Drawing.Point(238, 201)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(99, 75)
        Me.GroupBox2.TabIndex = 84
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estatus"
        '
        'chkCanceladas
        '
        Me.chkCanceladas.AutoSize = True
        Me.chkCanceladas.Checked = True
        Me.chkCanceladas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCanceladas.Location = New System.Drawing.Point(6, 42)
        Me.chkCanceladas.Name = "chkCanceladas"
        Me.chkCanceladas.Size = New System.Drawing.Size(82, 17)
        Me.chkCanceladas.TabIndex = 57
        Me.chkCanceladas.Text = "Canceladas"
        Me.chkCanceladas.UseVisualStyleBackColor = True
        '
        'chkVigentes
        '
        Me.chkVigentes.AutoSize = True
        Me.chkVigentes.Checked = True
        Me.chkVigentes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVigentes.Location = New System.Drawing.Point(6, 19)
        Me.chkVigentes.Name = "chkVigentes"
        Me.chkVigentes.Size = New System.Drawing.Size(67, 17)
        Me.chkVigentes.TabIndex = 56
        Me.chkVigentes.Text = "Vigentes"
        Me.chkVigentes.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DtpFechaFin)
        Me.GroupBox1.Controls.Add(Me.DtpFechaIni)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(59, 201)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(173, 75)
        Me.GroupBox1.TabIndex = 83
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rango de Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Fecha Inicial :"
        '
        'DtpFechaFin
        '
        Me.DtpFechaFin.Enabled = False
        Me.DtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaFin.Location = New System.Drawing.Point(80, 45)
        Me.DtpFechaFin.Name = "DtpFechaFin"
        Me.DtpFechaFin.Size = New System.Drawing.Size(85, 20)
        Me.DtpFechaFin.TabIndex = 53
        '
        'DtpFechaIni
        '
        Me.DtpFechaIni.Enabled = False
        Me.DtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaIni.Location = New System.Drawing.Point(80, 19)
        Me.DtpFechaIni.Name = "DtpFechaIni"
        Me.DtpFechaIni.Size = New System.Drawing.Size(85, 20)
        Me.DtpFechaIni.TabIndex = 51
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Fecha Final :"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(555, 32)
        Me.Label17.TabIndex = 95
        Me.Label17.Text = "REPORTE RECEPCIÓN COMPRAS DE GANADO"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFolioCompra
        '
        Me.txtFolioCompra.ComboBoxEnlazado = Nothing
        Me.txtFolioCompra.Decimales = 0
        Me.txtFolioCompra.Location = New System.Drawing.Point(153, 38)
        Me.txtFolioCompra.MensajeCombo = "Seleccionar un item..."
        Me.txtFolioCompra.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtFolioCompra.Name = "txtFolioCompra"
        Me.txtFolioCompra.SiguienteControl = Me.txtCodigoProveedor
        Me.txtFolioCompra.Size = New System.Drawing.Size(137, 20)
        Me.txtFolioCompra.TabIndex = 109
        Me.txtFolioCompra.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtFolioCompra.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtFolioCompra.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtCodigoProveedor
        '
        Me.txtCodigoProveedor.ComboBoxEnlazado = Me.cmbProveedor
        Me.txtCodigoProveedor.Decimales = 0
        Me.txtCodigoProveedor.Location = New System.Drawing.Point(153, 64)
        Me.txtCodigoProveedor.MaxLength = 3000
        Me.txtCodigoProveedor.MensajeCombo = "Seleccionar un proveedor..."
        Me.txtCodigoProveedor.MensajeNoExiste = "No existe un proveedor con este código o se encuentra inactivo"
        Me.txtCodigoProveedor.Name = "txtCodigoProveedor"
        Me.txtCodigoProveedor.SiguienteControl = Me.txtCodigoComprador
        Me.txtCodigoProveedor.Size = New System.Drawing.Size(57, 20)
        Me.txtCodigoProveedor.TabIndex = 101
        Me.txtCodigoProveedor.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtCodigoProveedor.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCodigoProveedor.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cmbProveedor
        '
        Me.cmbProveedor.DisplayMember = "RazonSocial"
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(216, 64)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.NombreMetodo = ""
        Me.cmbProveedor.Parametros = Nothing
        Me.cmbProveedor.SiguienteControl = Me.txtCodigoComprador
        Me.cmbProveedor.Size = New System.Drawing.Size(379, 21)
        Me.cmbProveedor.TabIndex = 105
        Me.cmbProveedor.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbProveedor.TextBoxEnlazado = Me.txtCodigoProveedor
        Me.cmbProveedor.ValueMember = "Codigo"
        '
        'txtCodigoComprador
        '
        Me.txtCodigoComprador.ComboBoxEnlazado = Me.cmbComprador
        Me.txtCodigoComprador.Decimales = 0
        Me.txtCodigoComprador.Location = New System.Drawing.Point(153, 91)
        Me.txtCodigoComprador.MensajeCombo = "Seleccionar un comprador..."
        Me.txtCodigoComprador.MensajeNoExiste = "No existe un comprador con este código o se encuentra inactivo"
        Me.txtCodigoComprador.Name = "txtCodigoComprador"
        Me.txtCodigoComprador.SiguienteControl = Me.txtCodigoCorral
        Me.txtCodigoComprador.Size = New System.Drawing.Size(57, 20)
        Me.txtCodigoComprador.TabIndex = 102
        Me.txtCodigoComprador.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtCodigoComprador.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCodigoComprador.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cmbComprador
        '
        Me.cmbComprador.DisplayMember = "NomCompleto"
        Me.cmbComprador.FormattingEnabled = True
        Me.cmbComprador.Location = New System.Drawing.Point(216, 91)
        Me.cmbComprador.Name = "cmbComprador"
        Me.cmbComprador.NombreMetodo = "Obtener"
        Me.cmbComprador.Parametros = Nothing
        Me.cmbComprador.SiguienteControl = Me.txtCodigoCorral
        Me.cmbComprador.Size = New System.Drawing.Size(379, 21)
        Me.cmbComprador.TabIndex = 106
        Me.cmbComprador.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbComprador.TextBoxEnlazado = Me.txtCodigoComprador
        Me.cmbComprador.ValueMember = "IdComprador"
        '
        'txtCodigoCorral
        '
        Me.txtCodigoCorral.ComboBoxEnlazado = Me.cmbCorral
        Me.txtCodigoCorral.Decimales = 0
        Me.txtCodigoCorral.Location = New System.Drawing.Point(153, 118)
        Me.txtCodigoCorral.MensajeCombo = "Seleccionar un corral..."
        Me.txtCodigoCorral.MensajeNoExiste = "No existe un corral con este código o se encuentra inactivo"
        Me.txtCodigoCorral.Name = "txtCodigoCorral"
        Me.txtCodigoCorral.SiguienteControl = Me.txtCodigoLugarCompra
        Me.txtCodigoCorral.Size = New System.Drawing.Size(57, 20)
        Me.txtCodigoCorral.TabIndex = 103
        Me.txtCodigoCorral.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtCodigoCorral.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCodigoCorral.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cmbCorral
        '
        Me.cmbCorral.DisplayMember = "Descripcion"
        Me.cmbCorral.FormattingEnabled = True
        Me.cmbCorral.Location = New System.Drawing.Point(216, 118)
        Me.cmbCorral.Name = "cmbCorral"
        Me.cmbCorral.NombreMetodo = "Obtener"
        Me.cmbCorral.Parametros = Nothing
        Me.cmbCorral.SiguienteControl = Me.txtCodigoLugarCompra
        Me.cmbCorral.Size = New System.Drawing.Size(379, 21)
        Me.cmbCorral.TabIndex = 107
        Me.cmbCorral.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbCorral.TextBoxEnlazado = Me.txtCodigoCorral
        Me.cmbCorral.ValueMember = "IdCorral"
        '
        'txtCodigoLugarCompra
        '
        Me.txtCodigoLugarCompra.ComboBoxEnlazado = Me.cmbLugarCompra
        Me.txtCodigoLugarCompra.Decimales = 0
        Me.txtCodigoLugarCompra.Location = New System.Drawing.Point(153, 145)
        Me.txtCodigoLugarCompra.MensajeCombo = "Seleccionar un lugar de compra..."
        Me.txtCodigoLugarCompra.MensajeNoExiste = "No existe un lugar de compra con este código o se encuentra inactivo"
        Me.txtCodigoLugarCompra.Name = "txtCodigoLugarCompra"
        Me.txtCodigoLugarCompra.SiguienteControl = Me.chkFiltrar
        Me.txtCodigoLugarCompra.Size = New System.Drawing.Size(57, 20)
        Me.txtCodigoLugarCompra.TabIndex = 104
        Me.txtCodigoLugarCompra.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtCodigoLugarCompra.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCodigoLugarCompra.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cmbLugarCompra
        '
        Me.cmbLugarCompra.DisplayMember = "Descripcion"
        Me.cmbLugarCompra.FormattingEnabled = True
        Me.cmbLugarCompra.Location = New System.Drawing.Point(216, 145)
        Me.cmbLugarCompra.Name = "cmbLugarCompra"
        Me.cmbLugarCompra.NombreMetodo = "Obtener"
        Me.cmbLugarCompra.Parametros = Nothing
        Me.cmbLugarCompra.SiguienteControl = Me.chkFiltrar
        Me.cmbLugarCompra.Size = New System.Drawing.Size(379, 21)
        Me.cmbLugarCompra.TabIndex = 108
        Me.cmbLugarCompra.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbLugarCompra.TextBoxEnlazado = Me.txtCodigoLugarCompra
        Me.cmbLugarCompra.ValueMember = "IdLugarCompra"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "Lugar de Compra:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(56, 122)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 99
        Me.Label12.Text = "Corral :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(56, 95)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 98
        Me.Label11.Text = "Comprador:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "Proveedor :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "Folio :"
        '
        'busquedaRecepcionCompras
        '
        Me.busquedaRecepcionCompras.TableName = "VwBusquedaComprasdeGanado"
        '
        'FrmRptComprasGanado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 288)
        Me.Controls.Add(Me.txtFolioCompra)
        Me.Controls.Add(Me.cmbLugarCompra)
        Me.Controls.Add(Me.cmbCorral)
        Me.Controls.Add(Me.cmbComprador)
        Me.Controls.Add(Me.cmbProveedor)
        Me.Controls.Add(Me.txtCodigoLugarCompra)
        Me.Controls.Add(Me.txtCodigoCorral)
        Me.Controls.Add(Me.txtCodigoComprador)
        Me.Controls.Add(Me.txtCodigoProveedor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkFiltrar)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmRptComprasGanado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Recepción Compras de Ganado"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.busquedaRecepcionCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents chkFiltrar As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCanceladas As System.Windows.Forms.CheckBox
    Friend WithEvents chkVigentes As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtFolioCompra As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtCodigoProveedor As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents cmbProveedor As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents txtCodigoComprador As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents cmbComprador As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents txtCodigoCorral As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents cmbCorral As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents txtCodigoLugarCompra As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents cmbLugarCompra As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents busquedaRecepcionCompras As Integralab.ORM.TypedViewClasses.VwBusquedaComprasdeGanadoTypedView
End Class
