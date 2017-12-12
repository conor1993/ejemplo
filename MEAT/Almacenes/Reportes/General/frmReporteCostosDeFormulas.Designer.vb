<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteCostosDeFormulas
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
        Me.lblAlmacen = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbMedicamento = New Integralab.Controles.ComboBoxMejorado
        Me.txtCodigoMedicamento = New Integralab.Controles.TextBoxMejorado
        Me.cmbAlmacen = New Integralab.Controles.ComboBoxMejorado
        Me.txtAlmacen = New Integralab.Controles.TextBoxMejorado
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCantidadPreparar = New Integralab.Controles.TextBoxMejorado
        Me.SuspendLayout()
        '
        'lblAlmacen
        '
        Me.lblAlmacen.AutoSize = True
        Me.lblAlmacen.Location = New System.Drawing.Point(52, 41)
        Me.lblAlmacen.Name = "lblAlmacen"
        Me.lblAlmacen.Size = New System.Drawing.Size(51, 13)
        Me.lblAlmacen.TabIndex = 24
        Me.lblAlmacen.Text = "Almacén:"
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
        Me.Label17.Size = New System.Drawing.Size(470, 29)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "REPORTE COSTOS DE FORMULAS"
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
        Me.mtb.Size = New System.Drawing.Size(50, 180)
        Me.mtb.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Formula:"
        '
        'cmbMedicamento
        '
        Me.cmbMedicamento.FormattingEnabled = True
        Me.cmbMedicamento.Location = New System.Drawing.Point(169, 65)
        Me.cmbMedicamento.Name = "cmbMedicamento"
        Me.cmbMedicamento.NombreMetodo = Nothing
        Me.cmbMedicamento.Parametros = Nothing
        Me.cmbMedicamento.SiguienteControl = Me.txtCodigoMedicamento
        Me.cmbMedicamento.Size = New System.Drawing.Size(339, 21)
        Me.cmbMedicamento.TabIndex = 56
        Me.cmbMedicamento.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbMedicamento.TextBoxEnlazado = Me.txtCodigoMedicamento
        '
        'txtCodigoMedicamento
        '
        Me.txtCodigoMedicamento.ComboBoxEnlazado = Me.cmbMedicamento
        Me.txtCodigoMedicamento.Decimales = 0
        Me.txtCodigoMedicamento.Location = New System.Drawing.Point(109, 65)
        Me.txtCodigoMedicamento.MensajeCombo = "Seleccionar un medicamento..."
        Me.txtCodigoMedicamento.MensajeNoExiste = "No existe un medicamento con este código o se encuentra inactivo"
        Me.txtCodigoMedicamento.Name = "txtCodigoMedicamento"
        Me.txtCodigoMedicamento.SiguienteControl = Me.cmbMedicamento
        Me.txtCodigoMedicamento.Size = New System.Drawing.Size(54, 20)
        Me.txtCodigoMedicamento.TabIndex = 55
        Me.txtCodigoMedicamento.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtCodigoMedicamento.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCodigoMedicamento.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cmbAlmacen
        '
        Me.cmbAlmacen.FormattingEnabled = True
        Me.cmbAlmacen.Location = New System.Drawing.Point(169, 38)
        Me.cmbAlmacen.Name = "cmbAlmacen"
        Me.cmbAlmacen.NombreMetodo = Nothing
        Me.cmbAlmacen.Parametros = Nothing
        Me.cmbAlmacen.SiguienteControl = Nothing
        Me.cmbAlmacen.Size = New System.Drawing.Size(339, 21)
        Me.cmbAlmacen.TabIndex = 26
        Me.cmbAlmacen.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbAlmacen.TextBoxEnlazado = Me.txtAlmacen
        '
        'txtAlmacen
        '
        Me.txtAlmacen.ComboBoxEnlazado = Me.cmbAlmacen
        Me.txtAlmacen.Decimales = 0
        Me.txtAlmacen.Location = New System.Drawing.Point(109, 38)
        Me.txtAlmacen.MaxLength = 3000
        Me.txtAlmacen.MensajeCombo = "Todos Los almacenes"
        Me.txtAlmacen.MensajeNoExiste = "No existe"
        Me.txtAlmacen.Name = "txtAlmacen"
        Me.txtAlmacen.SiguienteControl = Me.cmbAlmacen
        Me.txtAlmacen.Size = New System.Drawing.Size(54, 20)
        Me.txtAlmacen.TabIndex = 25
        Me.txtAlmacen.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtAlmacen.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtAlmacen.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Cantidad a Preparar:"
        '
        'txtCantidadPreparar
        '
        Me.txtCantidadPreparar.ComboBoxEnlazado = Nothing
        Me.txtCantidadPreparar.Decimales = 0
        Me.txtCantidadPreparar.Location = New System.Drawing.Point(169, 92)
        Me.txtCantidadPreparar.MaxLength = 3000
        Me.txtCantidadPreparar.MensajeCombo = "Seleccionar un item..."
        Me.txtCantidadPreparar.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtCantidadPreparar.Name = "txtCantidadPreparar"
        Me.txtCantidadPreparar.SiguienteControl = Nothing
        Me.txtCantidadPreparar.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidadPreparar.TabIndex = 58
        Me.txtCantidadPreparar.Text = "0.000"
        Me.txtCantidadPreparar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCantidadPreparar.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtCantidadPreparar.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCantidadPreparar.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'frmReporteCostosDeFormulas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 180)
        Me.Controls.Add(Me.txtCantidadPreparar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbMedicamento)
        Me.Controls.Add(Me.txtCodigoMedicamento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbAlmacen)
        Me.Controls.Add(Me.txtAlmacen)
        Me.Controls.Add(Me.lblAlmacen)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmReporteCostosDeFormulas"
        Me.Text = "Reporte Costos De Formula"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbAlmacen As Integralab.Controles.ComboBoxMejorado
    Friend WithEvents txtAlmacen As Integralab.Controles.TextBoxMejorado
    Friend WithEvents lblAlmacen As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents cmbMedicamento As Integralab.Controles.ComboBoxMejorado
    Friend WithEvents txtCodigoMedicamento As Integralab.Controles.TextBoxMejorado
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCantidadPreparar As Integralab.Controles.TextBoxMejorado
End Class
