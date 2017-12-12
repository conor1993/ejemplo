<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteDeCanales
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
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.chkFiltrar = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.dtFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chkEmbarcado = New System.Windows.Forms.CheckBox
        Me.chkCorte = New System.Windows.Forms.CheckBox
        Me.chkExistentes = New System.Windows.Forms.CheckBox
        Me.cmbIntroductor = New Integralab.Controles.ComboBoxMejorado
        Me.txtCodigoIntroductor = New Integralab.Controles.TextBoxMejorado
        Me.txtFolioSacrificio = New Integralab.Controles.TextBoxMejorado
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(50, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(470, 32)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "REPORTE DE CANALES"
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
        Me.mtb.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Folio de Sacrificio:"
        '
        'chkFiltrar
        '
        Me.chkFiltrar.AutoSize = True
        Me.chkFiltrar.Location = New System.Drawing.Point(56, 101)
        Me.chkFiltrar.Name = "chkFiltrar"
        Me.chkFiltrar.Size = New System.Drawing.Size(114, 17)
        Me.chkFiltrar.TabIndex = 7
        Me.chkFiltrar.Text = "¿Filtrar por Fecha?"
        Me.chkFiltrar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtFechaFinal)
        Me.GroupBox1.Controls.Add(Me.dtFechaInicial)
        Me.GroupBox1.Location = New System.Drawing.Point(54, 124)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(186, 78)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rengo de Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha Final:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fecha Inicio:"
        '
        'dtFechaFinal
        '
        Me.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaFinal.Location = New System.Drawing.Point(80, 46)
        Me.dtFechaFinal.Name = "dtFechaFinal"
        Me.dtFechaFinal.Size = New System.Drawing.Size(96, 20)
        Me.dtFechaFinal.TabIndex = 3
        '
        'dtFechaInicial
        '
        Me.dtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaInicial.Location = New System.Drawing.Point(80, 20)
        Me.dtFechaInicial.Name = "dtFechaInicial"
        Me.dtFechaInicial.Size = New System.Drawing.Size(96, 20)
        Me.dtFechaInicial.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Introductor:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkEmbarcado)
        Me.GroupBox2.Controls.Add(Me.chkCorte)
        Me.GroupBox2.Controls.Add(Me.chkExistentes)
        Me.GroupBox2.Location = New System.Drawing.Point(246, 113)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(104, 89)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estatus"
        '
        'chkEmbarcado
        '
        Me.chkEmbarcado.AutoSize = True
        Me.chkEmbarcado.Checked = True
        Me.chkEmbarcado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEmbarcado.Location = New System.Drawing.Point(6, 65)
        Me.chkEmbarcado.Name = "chkEmbarcado"
        Me.chkEmbarcado.Size = New System.Drawing.Size(80, 17)
        Me.chkEmbarcado.TabIndex = 2
        Me.chkEmbarcado.Text = "Embarcado"
        Me.chkEmbarcado.UseVisualStyleBackColor = True
        '
        'chkCorte
        '
        Me.chkCorte.AutoSize = True
        Me.chkCorte.Checked = True
        Me.chkCorte.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCorte.Location = New System.Drawing.Point(6, 42)
        Me.chkCorte.Name = "chkCorte"
        Me.chkCorte.Size = New System.Drawing.Size(67, 17)
        Me.chkCorte.TabIndex = 1
        Me.chkCorte.Text = "En Corte"
        Me.chkCorte.UseVisualStyleBackColor = True
        '
        'chkExistentes
        '
        Me.chkExistentes.AutoSize = True
        Me.chkExistentes.Checked = True
        Me.chkExistentes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkExistentes.Location = New System.Drawing.Point(6, 19)
        Me.chkExistentes.Name = "chkExistentes"
        Me.chkExistentes.Size = New System.Drawing.Size(74, 17)
        Me.chkExistentes.TabIndex = 0
        Me.chkExistentes.Text = "Existentes"
        Me.chkExistentes.UseVisualStyleBackColor = True
        '
        'cmbIntroductor
        '
        Me.cmbIntroductor.FormattingEnabled = True
        Me.cmbIntroductor.Location = New System.Drawing.Point(198, 72)
        Me.cmbIntroductor.Name = "cmbIntroductor"
        Me.cmbIntroductor.NombreMetodo = Nothing
        Me.cmbIntroductor.Parametros = Nothing
        Me.cmbIntroductor.SiguienteControl = Me.chkFiltrar
        Me.cmbIntroductor.Size = New System.Drawing.Size(313, 21)
        Me.cmbIntroductor.TabIndex = 6
        Me.cmbIntroductor.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbIntroductor.TextBoxEnlazado = Me.txtCodigoIntroductor
        '
        'txtCodigoIntroductor
        '
        Me.txtCodigoIntroductor.ComboBoxEnlazado = Nothing
        Me.txtCodigoIntroductor.Decimales = 0
        Me.txtCodigoIntroductor.Location = New System.Drawing.Point(153, 72)
        Me.txtCodigoIntroductor.MensajeCombo = "Seleccionar un Intructor..."
        Me.txtCodigoIntroductor.MensajeNoExiste = "No existe un introductor con este código o se encuentra inactivo"
        Me.txtCodigoIntroductor.Name = "txtCodigoIntroductor"
        Me.txtCodigoIntroductor.SiguienteControl = Me.chkFiltrar
        Me.txtCodigoIntroductor.Size = New System.Drawing.Size(41, 20)
        Me.txtCodigoIntroductor.TabIndex = 5
        Me.txtCodigoIntroductor.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtCodigoIntroductor.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCodigoIntroductor.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtFolioSacrificio
        '
        Me.txtFolioSacrificio.ComboBoxEnlazado = Nothing
        Me.txtFolioSacrificio.Decimales = 0
        Me.txtFolioSacrificio.ForeColor = System.Drawing.Color.Gray
        Me.txtFolioSacrificio.Location = New System.Drawing.Point(153, 46)
        Me.txtFolioSacrificio.MensajeCombo = "Seleccionar un item..."
        Me.txtFolioSacrificio.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtFolioSacrificio.Name = "txtFolioSacrificio"
        Me.txtFolioSacrificio.SiguienteControl = Me.txtCodigoIntroductor
        Me.txtFolioSacrificio.Size = New System.Drawing.Size(100, 20)
        Me.txtFolioSacrificio.TabIndex = 3
        Me.txtFolioSacrificio.Text = "F3 PARA BUSCAR"
        Me.txtFolioSacrificio.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.ToolTip1.SetToolTip(Me.txtFolioSacrificio, "Precione F3 Para Buscar")
        Me.txtFolioSacrificio.ValorMaximo = New Decimal(New Integer() {-727379969, 232, 0, 0})
        Me.txtFolioSacrificio.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'frmReporteDeCanales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 215)
        Me.Controls.Add(Me.cmbIntroductor)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.chkFiltrar)
        Me.Controls.Add(Me.txtCodigoIntroductor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtFolioSacrificio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmReporteDeCanales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Canales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFolioSacrificio As Integralab.Controles.TextBoxMejorado
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCodigoIntroductor As Integralab.Controles.TextBoxMejorado
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkFiltrar As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkEmbarcado As System.Windows.Forms.CheckBox
    Friend WithEvents chkCorte As System.Windows.Forms.CheckBox
    Friend WithEvents chkExistentes As System.Windows.Forms.CheckBox
    Friend WithEvents cmbIntroductor As Integralab.Controles.ComboBoxMejorado
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
