<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteExistencias
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
        Me.Label17 = New System.Windows.Forms.Label
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBoxMejorado1 = New Integralab.Controles.TextBoxMejorado
        Me.txtCodigoIntroductor = New Integralab.Controles.TextBoxMejorado
        Me.cmbIntroductor = New Integralab.Controles.ComboBoxMejorado
        Me.txtFolioSacrificio = New Integralab.Controles.TextBoxMejorado
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
        Me.Label17.Size = New System.Drawing.Size(467, 32)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "REPORTE DE EXISTENCIAS"
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
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 177)
        Me.MEAToolBar1.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Introductor:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Folio de Sacrificio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Lote de Corte:"
        '
        'TextBoxMejorado1
        '
        Me.TextBoxMejorado1.ComboBoxEnlazado = Nothing
        Me.TextBoxMejorado1.Decimales = 0
        Me.TextBoxMejorado1.Location = New System.Drawing.Point(155, 71)
        Me.TextBoxMejorado1.MensajeCombo = "Seleccionar un item..."
        Me.TextBoxMejorado1.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.TextBoxMejorado1.Name = "TextBoxMejorado1"
        Me.TextBoxMejorado1.SiguienteControl = Me.txtCodigoIntroductor
        Me.TextBoxMejorado1.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxMejorado1.TabIndex = 66
        Me.TextBoxMejorado1.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'txtCodigoIntroductor
        '
        Me.txtCodigoIntroductor.ComboBoxEnlazado = Nothing
        Me.txtCodigoIntroductor.Decimales = 0
        Me.txtCodigoIntroductor.Location = New System.Drawing.Point(155, 97)
        Me.txtCodigoIntroductor.MensajeCombo = "Seleccionar un Intructor..."
        Me.txtCodigoIntroductor.MensajeNoExiste = "No existe un introductor con este código o se encuentra inactivo"
        Me.txtCodigoIntroductor.Name = "txtCodigoIntroductor"
        Me.txtCodigoIntroductor.SiguienteControl = Nothing
        Me.txtCodigoIntroductor.Size = New System.Drawing.Size(41, 20)
        Me.txtCodigoIntroductor.TabIndex = 64
        Me.txtCodigoIntroductor.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'cmbIntroductor
        '
        Me.cmbIntroductor.FormattingEnabled = True
        Me.cmbIntroductor.Location = New System.Drawing.Point(202, 97)
        Me.cmbIntroductor.Name = "cmbIntroductor"
        Me.cmbIntroductor.NombreMetodo = Nothing
        Me.cmbIntroductor.Parametros = Nothing
        Me.cmbIntroductor.SiguienteControl = Nothing
        Me.cmbIntroductor.Size = New System.Drawing.Size(303, 21)
        Me.cmbIntroductor.TabIndex = 60
        Me.cmbIntroductor.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbIntroductor.TextBoxEnlazado = Me.txtCodigoIntroductor
        '
        'txtFolioSacrificio
        '
        Me.txtFolioSacrificio.ComboBoxEnlazado = Nothing
        Me.txtFolioSacrificio.Decimales = 0
        Me.txtFolioSacrificio.Location = New System.Drawing.Point(155, 45)
        Me.txtFolioSacrificio.MensajeCombo = "Seleccionar un item..."
        Me.txtFolioSacrificio.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtFolioSacrificio.Name = "txtFolioSacrificio"
        Me.txtFolioSacrificio.SiguienteControl = Me.txtCodigoIntroductor
        Me.txtFolioSacrificio.Size = New System.Drawing.Size(100, 20)
        Me.txtFolioSacrificio.TabIndex = 62
        Me.txtFolioSacrificio.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'frmReporteExistencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 177)
        Me.Controls.Add(Me.TextBoxMejorado1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbIntroductor)
        Me.Controls.Add(Me.txtCodigoIntroductor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtFolioSacrificio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmReporteExistencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Existencias"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents cmbIntroductor As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents txtCodigoIntroductor As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFolioSacrificio As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxMejorado1 As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
