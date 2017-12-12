<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteMovimeintoAlmacenGeneral
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Label17 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.cmbAlmacen = New Integralab.Controles.ComboBoxMejorado
        Me.txtAlmacen = New Integralab.Controles.TextBoxMejorado
        Me.lblAlmacen = New System.Windows.Forms.Label
        Me.gbFechas = New System.Windows.Forms.GroupBox
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.chkFiltrarFecha = New System.Windows.Forms.CheckBox
        Me.cmbProducto = New Integralab.Controles.ComboBoxMejorado
        Me.TextBoxMejorado1 = New Integralab.Controles.TextBoxMejorado
        Me.Label3 = New System.Windows.Forms.Label
        Me.chkAgruparProducto = New System.Windows.Forms.CheckBox
        Me.gbFechas.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.MaximumSize = New System.Drawing.Size(1600, 900)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(522, 29)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "REPORTE DE MOVIMIENTOS DE ALMACÉN"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mtb
        '
        Me.mtb.ButtonSize = New System.Drawing.Size(50, 50)
        Me.mtb.Dock = System.Windows.Forms.DockStyle.Left
        Me.mtb.DropDownArrows = True
        Me.mtb.HabilitarBorrar = False
        Me.mtb.HabilitarBuscar = False
        Me.mtb.HabilitarCancelar = True
        Me.mtb.HabilitarEditar = False
        Me.mtb.HabilitarGuardar = False
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
        Me.mtb.Size = New System.Drawing.Size(50, 187)
        Me.mtb.TabIndex = 2
        '
        'cmbAlmacen
        '
        Me.cmbAlmacen.FormattingEnabled = True
        Me.cmbAlmacen.Location = New System.Drawing.Point(165, 38)
        Me.cmbAlmacen.Name = "cmbAlmacen"
        Me.cmbAlmacen.NombreMetodo = Nothing
        Me.cmbAlmacen.Parametros = Nothing
        Me.cmbAlmacen.SiguienteControl = Nothing
        Me.cmbAlmacen.Size = New System.Drawing.Size(395, 21)
        Me.cmbAlmacen.TabIndex = 21
        Me.cmbAlmacen.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbAlmacen.TextBoxEnlazado = Me.txtAlmacen
        '
        'txtAlmacen
        '
        Me.txtAlmacen.ComboBoxEnlazado = Me.cmbAlmacen
        Me.txtAlmacen.Decimales = 0
        Me.txtAlmacen.Location = New System.Drawing.Point(113, 38)
        Me.txtAlmacen.MaxLength = 3000
        Me.txtAlmacen.MensajeCombo = "Todos Los almacenes"
        Me.txtAlmacen.MensajeNoExiste = "No existe"
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.SiguienteControl = Me.cmbAlmacen
        Me.txtAlmacen.Size = New System.Drawing.Size(46, 20)
        Me.txtAlmacen.TabIndex = 20
        Me.txtAlmacen.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtAlmacen.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtAlmacen.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblAlmacen
        '
        Me.lblAlmacen.AutoSize = True
        Me.lblAlmacen.Location = New System.Drawing.Point(56, 42)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.Size = New System.Drawing.Size(51, 13)
        Me.lblAlmacen.TabIndex = 19
        Me.lblAlmacen.Text = "Almacen:"
        '
        'gbFechas
        '
        Me.gbFechas.Controls.Add(Me.dtpFechaFin)
        Me.gbFechas.Controls.Add(Me.dtpFechaInicio)
        Me.gbFechas.Controls.Add(Me.Label2)
        Me.gbFechas.Controls.Add(Me.Label1)
        Me.gbFechas.Location = New System.Drawing.Point(283, 92)
        Me.gbFechas.Name = "gbFechas"
        Me.gbFechas.Size = New System.Drawing.Size(156, 85)
        Me.gbFechas.TabIndex = 22
        Me.gbFechas.TabStop = False
        Me.gbFechas.Text = "Rango de Fechas"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaFin.Location = New System.Drawing.Point(47, 46)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(96, 20)
        Me.dtpFechaFin.TabIndex = 3
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaInicio.Location = New System.Drawing.Point(47, 19)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(96, 20)
        Me.dtpFechaInicio.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fin:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inicio:"
        '
        'chkFiltrarFecha
        '
        Me.chkFiltrarFecha.AutoSize = True
        Me.chkFiltrarFecha.Location = New System.Drawing.Point(193, 92)
        Me.chkFiltrarFecha.Name = "chkFiltrarFecha"
        Me.chkFiltrarFecha.Size = New System.Drawing.Size(84, 17)
        Me.chkFiltrarFecha.TabIndex = 23
        Me.chkFiltrarFecha.Text = "Filtrar Fecha"
        Me.chkFiltrarFecha.UseVisualStyleBackColor = True
        '
        'cmbProducto
        '
        Me.cmbProducto.FormattingEnabled = True
        Me.cmbProducto.Location = New System.Drawing.Point(165, 65)
        Me.cmbProducto.Name = "cmbProducto"
        Me.cmbProducto.NombreMetodo = Nothing
        Me.cmbProducto.Parametros = Nothing
        Me.cmbProducto.SiguienteControl = Nothing
        Me.cmbProducto.Size = New System.Drawing.Size(395, 21)
        Me.cmbProducto.TabIndex = 26
        Me.cmbProducto.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbProducto.TextBoxEnlazado = Me.TextBoxMejorado1
        '
        'TextBoxMejorado1
        '
        Me.TextBoxMejorado1.ComboBoxEnlazado = Me.cmbProducto
        Me.TextBoxMejorado1.Decimales = 0
        Me.TextBoxMejorado1.Location = New System.Drawing.Point(113, 65)
        Me.TextBoxMejorado1.MaxLength = 3000
        Me.TextBoxMejorado1.MensajeCombo = "Todos Los almacenes"
        Me.TextBoxMejorado1.MensajeNoExiste = "No existe"
        Me.TextBoxMejorado1.Name = "TextBoxMejorado1"
        Me.TextBoxMejorado1.SiguienteControl = Me.cmbProducto
        Me.TextBoxMejorado1.Size = New System.Drawing.Size(46, 20)
        Me.TextBoxMejorado1.TabIndex = 25
        Me.TextBoxMejorado1.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.TextBoxMejorado1.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.TextBoxMejorado1.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Almacen:"
        '
        'chkAgruparProducto
        '
        Me.chkAgruparProducto.AutoSize = True
        Me.chkAgruparProducto.Location = New System.Drawing.Point(59, 92)
        Me.chkAgruparProducto.Name = "chkAgruparProducto"
        Me.chkAgruparProducto.Size = New System.Drawing.Size(128, 17)
        Me.chkAgruparProducto.TabIndex = 27
        Me.chkAgruparProducto.Text = "Agrupar Por Producto"
        Me.chkAgruparProducto.UseVisualStyleBackColor = True
        '
        'frmReporteMovimeintoAlmacenGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 187)
        Me.Controls.Add(Me.chkAgruparProducto)
        Me.Controls.Add(Me.cmbProducto)
        Me.Controls.Add(Me.TextBoxMejorado1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkFiltrarFecha)
        Me.Controls.Add(Me.gbFechas)
        Me.Controls.Add(Me.cmbAlmacen)
        Me.Controls.Add(Me.txtAlmacen)
        Me.Controls.Add(Me.lblAlmacen)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.MaximizeBox = False
        Me.Name = "frmReporteMovimeintoAlmacenGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Movimientos de Almacén"
        Me.gbFechas.ResumeLayout(False)
        Me.gbFechas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents cmbAlmacen As Integralab.Controles.ComboBoxMejorado
    Friend WithEvents txtAlmacen As Integralab.Controles.TextBoxMejorado
    Friend WithEvents lblAlmacen As System.Windows.Forms.Label
    Friend WithEvents gbFechas As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkFiltrarFecha As System.Windows.Forms.CheckBox
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbProducto As Integralab.Controles.ComboBoxMejorado
    Friend WithEvents TextBoxMejorado1 As Integralab.Controles.TextBoxMejorado
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkAgruparProducto As System.Windows.Forms.CheckBox
End Class
