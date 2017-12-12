<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteMedicamentosTrabajo
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
        Me.cmbMedicamento = New Integralab.Controles.ComboBoxMejorado
        Me.txtCodigoMedicamento = New Integralab.Controles.TextBoxMejorado
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar
        Me.SuspendLayout()
        '
        'cmbMedicamento
        '
        Me.cmbMedicamento.FormattingEnabled = True
        Me.cmbMedicamento.Location = New System.Drawing.Point(196, 48)
        Me.cmbMedicamento.Name = "cmbMedicamento"
        Me.cmbMedicamento.NombreMetodo = Nothing
        Me.cmbMedicamento.Parametros = Nothing
        Me.cmbMedicamento.SiguienteControl = Me.txtCodigoMedicamento
        Me.cmbMedicamento.Size = New System.Drawing.Size(329, 21)
        Me.cmbMedicamento.TabIndex = 58
        Me.cmbMedicamento.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbMedicamento.TextBoxEnlazado = Me.txtCodigoMedicamento
        '
        'txtCodigoMedicamento
        '
        Me.txtCodigoMedicamento.ComboBoxEnlazado = Me.cmbMedicamento
        Me.txtCodigoMedicamento.Decimales = 0
        Me.txtCodigoMedicamento.Location = New System.Drawing.Point(136, 48)
        Me.txtCodigoMedicamento.MensajeCombo = "Seleccionar un medicamento..."
        Me.txtCodigoMedicamento.MensajeNoExiste = "No existe un medicamento con este código o se encuentra inactivo"
        Me.txtCodigoMedicamento.Name = "txtCodigoMedicamento"
        Me.txtCodigoMedicamento.SiguienteControl = Me.cmbMedicamento
        Me.txtCodigoMedicamento.Size = New System.Drawing.Size(54, 20)
        Me.txtCodigoMedicamento.TabIndex = 57
        Me.txtCodigoMedicamento.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtCodigoMedicamento.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCodigoMedicamento.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Medicamento:"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(487, 32)
        Me.Label17.TabIndex = 54
        Me.Label17.Text = "Reporte de Medicamentos para Trabajo"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MEAToolBar1
        '
        Me.MEAToolBar1.ButtonSize = New System.Drawing.Size(50, 50)
        Me.MEAToolBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MEAToolBar1.DropDownArrows = True
        Me.MEAToolBar1.HabilitarBorrar = True
        Me.MEAToolBar1.HabilitarBuscar = True
        Me.MEAToolBar1.HabilitarCancelar = True
        Me.MEAToolBar1.HabilitarEditar = True
        Me.MEAToolBar1.HabilitarGuardar = True
        Me.MEAToolBar1.HabilitarImprimir = True
        Me.MEAToolBar1.HabilitarLimpiar = True
        Me.MEAToolBar1.HabilitarNuevo = True
        Me.MEAToolBar1.HabilitarSalir = True
        Me.MEAToolBar1.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32
        Me.MEAToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.MEAToolBar1.MostrarBorrar = False
        Me.MEAToolBar1.MostrarBuscar = False
        Me.MEAToolBar1.MostrarCancelar = False
        Me.MEAToolBar1.MostrarEditar = False
        Me.MEAToolBar1.MostrarGuardar = False
        Me.MEAToolBar1.MostrarImprimir = True
        Me.MEAToolBar1.MostrarLimpiar = True
        Me.MEAToolBar1.MostrarNuevo = False
        Me.MEAToolBar1.MostrarSalir = True
        Me.MEAToolBar1.Name = "MEAToolBar1"
        Me.MEAToolBar1.ShowToolTips = True
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 183)
        Me.MEAToolBar1.TabIndex = 55
        '
        'frmReporteMedicamentosTrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 183)
        Me.Controls.Add(Me.cmbMedicamento)
        Me.Controls.Add(Me.txtCodigoMedicamento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.MaximizeBox = False
        Me.Name = "frmReporteMedicamentosTrabajo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Medicamentos para Trabajo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbMedicamento As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents txtCodigoMedicamento As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
End Class
