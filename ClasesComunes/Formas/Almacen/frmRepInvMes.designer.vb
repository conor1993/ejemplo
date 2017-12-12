<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepInvMes
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
        Me.components = New System.ComponentModel.Container()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.mtb = New MEAToolBar.MEAToolBar()
        Me.cmbAlmacen = New IntegraLab.Controles.ComboBoxMejorado()
        Me.txtAlmacen = New IntegraLab.Controles.TextBoxMejorado()
        Me.lblAlmacen = New System.Windows.Forms.Label()
        Me.gbFechas = New System.Windows.Forms.GroupBox()
        Me.cmbMes = New System.Windows.Forms.ComboBox()
        Me.cmbAnio = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbProducto = New IntegraLab.Controles.ComboBoxMejorado()
        Me.TextBoxMejorado1 = New IntegraLab.Controles.TextBoxMejorado()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbFamilia = New IntegraLab.Controles.ComboBoxMejorado()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbArticulo = New IntegraLab.Controles.ComboBoxMejorado()
        Me.gbPorProducto = New System.Windows.Forms.GroupBox()
        Me.gbFechas.SuspendLayout()
        Me.gbPorProducto.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.MaximumSize = New System.Drawing.Size(1600, 900)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(433, 29)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "REPORTE DE INVENTARIO MENSUAL"
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
        Me.mtb.Size = New System.Drawing.Size(50, 215)
        Me.mtb.TabIndex = 2
        '
        'cmbAlmacen
        '
        Me.cmbAlmacen.FormattingEnabled = True
        Me.cmbAlmacen.Location = New System.Drawing.Point(161, 253)
        Me.cmbAlmacen.Name = "cmbAlmacen"
        Me.cmbAlmacen.NombreMetodo = Nothing
        Me.cmbAlmacen.Parametros = Nothing
        Me.cmbAlmacen.SiguienteControl = Nothing
        Me.cmbAlmacen.Size = New System.Drawing.Size(242, 21)
        Me.cmbAlmacen.TabIndex = 21
        Me.cmbAlmacen.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbAlmacen.TextBoxEnlazado = Me.txtAlmacen
        Me.cmbAlmacen.Visible = False
        '
        'txtAlmacen
        '
        Me.txtAlmacen.ComboBoxEnlazado = Me.cmbAlmacen
        Me.txtAlmacen.Decimales = 0
        Me.txtAlmacen.Location = New System.Drawing.Point(109, 253)
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
        Me.txtAlmacen.Visible = False
        '
        'lblAlmacen
        '
        Me.lblAlmacen.AutoSize = True
        Me.lblAlmacen.Location = New System.Drawing.Point(52, 257)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.Size = New System.Drawing.Size(51, 13)
        Me.lblAlmacen.TabIndex = 19
        Me.lblAlmacen.Text = "Almacen:"
        Me.lblAlmacen.Visible = False
        '
        'gbFechas
        '
        Me.gbFechas.Controls.Add(Me.cmbMes)
        Me.gbFechas.Controls.Add(Me.cmbAnio)
        Me.gbFechas.Controls.Add(Me.Label2)
        Me.gbFechas.Controls.Add(Me.Label1)
        Me.gbFechas.Location = New System.Drawing.Point(55, 32)
        Me.gbFechas.Name = "gbFechas"
        Me.gbFechas.Size = New System.Drawing.Size(352, 88)
        Me.gbFechas.TabIndex = 22
        Me.gbFechas.TabStop = False
        '
        'cmbMes
        '
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Location = New System.Drawing.Point(41, 58)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(95, 21)
        Me.cmbMes.TabIndex = 3
        '
        'cmbAnio
        '
        Me.cmbAnio.FormattingEnabled = True
        Me.cmbAnio.Location = New System.Drawing.Point(41, 13)
        Me.cmbAnio.Name = "cmbAnio"
        Me.cmbAnio.Size = New System.Drawing.Size(95, 21)
        Me.cmbAnio.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mes:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Año:"
        '
        'cmbProducto
        '
        Me.cmbProducto.FormattingEnabled = True
        Me.cmbProducto.Location = New System.Drawing.Point(161, 280)
        Me.cmbProducto.Name = "cmbProducto"
        Me.cmbProducto.NombreMetodo = Nothing
        Me.cmbProducto.Parametros = Nothing
        Me.cmbProducto.SiguienteControl = Nothing
        Me.cmbProducto.Size = New System.Drawing.Size(242, 21)
        Me.cmbProducto.TabIndex = 26
        Me.cmbProducto.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbProducto.TextBoxEnlazado = Me.TextBoxMejorado1
        Me.cmbProducto.Visible = False
        '
        'TextBoxMejorado1
        '
        Me.TextBoxMejorado1.ComboBoxEnlazado = Me.cmbProducto
        Me.TextBoxMejorado1.Decimales = 0
        Me.TextBoxMejorado1.Location = New System.Drawing.Point(109, 280)
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
        Me.TextBoxMejorado1.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 284)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Almacen:"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Familia:"
        '
        'cmbFamilia
        '
        Me.cmbFamilia.FormattingEnabled = True
        Me.cmbFamilia.Location = New System.Drawing.Point(67, 13)
        Me.cmbFamilia.Name = "cmbFamilia"
        Me.cmbFamilia.NombreMetodo = Nothing
        Me.cmbFamilia.Parametros = Nothing
        Me.cmbFamilia.SiguienteControl = Nothing
        Me.cmbFamilia.Size = New System.Drawing.Size(259, 21)
        Me.cmbFamilia.TabIndex = 30
        Me.cmbFamilia.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbFamilia.TextBoxEnlazado = Me.txtAlmacen
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Articulo:"
        '
        'cmbArticulo
        '
        Me.cmbArticulo.FormattingEnabled = True
        Me.cmbArticulo.Location = New System.Drawing.Point(67, 40)
        Me.cmbArticulo.Name = "cmbArticulo"
        Me.cmbArticulo.NombreMetodo = Nothing
        Me.cmbArticulo.Parametros = Nothing
        Me.cmbArticulo.SiguienteControl = Nothing
        Me.cmbArticulo.Size = New System.Drawing.Size(259, 21)
        Me.cmbArticulo.TabIndex = 32
        Me.cmbArticulo.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbArticulo.TextBoxEnlazado = Me.txtAlmacen
        '
        'gbPorProducto
        '
        Me.gbPorProducto.Controls.Add(Me.Label4)
        Me.gbPorProducto.Controls.Add(Me.cmbArticulo)
        Me.gbPorProducto.Controls.Add(Me.cmbFamilia)
        Me.gbPorProducto.Controls.Add(Me.Label5)
        Me.gbPorProducto.Location = New System.Drawing.Point(55, 126)
        Me.gbPorProducto.Name = "gbPorProducto"
        Me.gbPorProducto.Size = New System.Drawing.Size(352, 73)
        Me.gbPorProducto.TabIndex = 33
        Me.gbPorProducto.TabStop = False
        '
        'frmRepInvMes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 215)
        Me.Controls.Add(Me.gbPorProducto)
        Me.Controls.Add(Me.cmbProducto)
        Me.Controls.Add(Me.TextBoxMejorado1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gbFechas)
        Me.Controls.Add(Me.cmbAlmacen)
        Me.Controls.Add(Me.txtAlmacen)
        Me.Controls.Add(Me.lblAlmacen)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(499, 253)
        Me.MinimumSize = New System.Drawing.Size(499, 253)
        Me.Name = "frmRepInvMes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Inventario Mensual"
        Me.gbFechas.ResumeLayout(False)
        Me.gbFechas.PerformLayout()
        Me.gbPorProducto.ResumeLayout(False)
        Me.gbPorProducto.PerformLayout()
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
    Friend WithEvents cmbProducto As Integralab.Controles.ComboBoxMejorado
    Friend WithEvents TextBoxMejorado1 As Integralab.Controles.TextBoxMejorado
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbFamilia As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbArticulo As Integralab.Controles.ComboBoxMejorado
    Friend WithEvents gbPorProducto As System.Windows.Forms.GroupBox
    Friend WithEvents cmbMes As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAnio As System.Windows.Forms.ComboBox
End Class
