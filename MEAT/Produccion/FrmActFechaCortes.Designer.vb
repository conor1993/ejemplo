<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmActFechaCortes
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
        Me.mtbMenu = New MEAToolBar.MEAToolBar
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtObservaciones = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtpFechaCaducidad = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtDiasCaducidad = New System.Windows.Forms.TextBox
        Me.txtCodCliente = New System.Windows.Forms.TextBox
        Me.dtpFechaSacrificio = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.dtpFechaLoteCorte = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtFolioSacrificio = New System.Windows.Forms.TextBox
        Me.txtLoteCorte = New System.Windows.Forms.TextBox
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mtbMenu
        '
        Me.mtbMenu.ButtonSize = New System.Drawing.Size(50, 50)
        Me.mtbMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.mtbMenu.DropDownArrows = True
        Me.mtbMenu.HabilitarBorrar = True
        Me.mtbMenu.HabilitarBuscar = True
        Me.mtbMenu.HabilitarCancelar = True
        Me.mtbMenu.HabilitarEditar = True
        Me.mtbMenu.HabilitarGuardar = True
        Me.mtbMenu.HabilitarImprimir = True
        Me.mtbMenu.HabilitarLimpiar = True
        Me.mtbMenu.HabilitarNuevo = True
        Me.mtbMenu.HabilitarSalir = True
        Me.mtbMenu.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32
        Me.mtbMenu.Location = New System.Drawing.Point(0, 0)
        Me.mtbMenu.MostrarBorrar = False
        Me.mtbMenu.MostrarBuscar = True
        Me.mtbMenu.MostrarCancelar = True
        Me.mtbMenu.MostrarEditar = True
        Me.mtbMenu.MostrarGuardar = True
        Me.mtbMenu.MostrarImprimir = False
        Me.mtbMenu.MostrarLimpiar = False
        Me.mtbMenu.MostrarNuevo = False
        Me.mtbMenu.MostrarSalir = True
        Me.mtbMenu.Name = "mtbMenu"
        Me.mtbMenu.ShowToolTips = True
        Me.mtbMenu.Size = New System.Drawing.Size(50, 280)
        Me.mtbMenu.TabIndex = 42
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpFechaCaducidad)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtDiasCaducidad)
        Me.GroupBox1.Controls.Add(Me.txtCodCliente)
        Me.GroupBox1.Controls.Add(Me.dtpFechaSacrificio)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.dtpFechaLoteCorte)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtFolioSacrificio)
        Me.GroupBox1.Controls.Add(Me.txtLoteCorte)
        Me.GroupBox1.Controls.Add(Me.lblEstatus)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(526, 212)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        '
        'txtObservaciones
        '
        Me.txtObservaciones.AcceptsReturn = True
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Location = New System.Drawing.Point(108, 124)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(295, 69)
        Me.txtObservaciones.TabIndex = 59
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Observaciones :"
        '
        'dtpFechaCaducidad
        '
        Me.dtpFechaCaducidad.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFechaCaducidad.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaCaducidad.Location = New System.Drawing.Point(311, 98)
        Me.dtpFechaCaducidad.Name = "dtpFechaCaducidad"
        Me.dtpFechaCaducidad.Size = New System.Drawing.Size(92, 20)
        Me.dtpFechaCaducidad.TabIndex = 57
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(208, 102)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 13)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "Fecha Caducidad :"
        '
        'txtDiasCaducidad
        '
        Me.txtDiasCaducidad.AcceptsReturn = True
        Me.txtDiasCaducidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDiasCaducidad.Location = New System.Drawing.Point(108, 100)
        Me.txtDiasCaducidad.Name = "txtDiasCaducidad"
        Me.txtDiasCaducidad.Size = New System.Drawing.Size(50, 20)
        Me.txtDiasCaducidad.TabIndex = 55
        '
        'txtCodCliente
        '
        Me.txtCodCliente.AcceptsReturn = True
        Me.txtCodCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodCliente.Location = New System.Drawing.Point(108, 74)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.Size = New System.Drawing.Size(50, 20)
        Me.txtCodCliente.TabIndex = 54
        '
        'dtpFechaSacrificio
        '
        Me.dtpFechaSacrificio.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFechaSacrificio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaSacrificio.Location = New System.Drawing.Point(311, 47)
        Me.dtpFechaSacrificio.Name = "dtpFechaSacrificio"
        Me.dtpFechaSacrificio.Size = New System.Drawing.Size(92, 20)
        Me.dtpFechaSacrificio.TabIndex = 53
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(216, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 13)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Fecha Sacrificio :"
        '
        'dtpFechaLoteCorte
        '
        Me.dtpFechaLoteCorte.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFechaLoteCorte.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaLoteCorte.Location = New System.Drawing.Point(311, 21)
        Me.dtpFechaLoteCorte.Name = "dtpFechaLoteCorte"
        Me.dtpFechaLoteCorte.Size = New System.Drawing.Size(92, 20)
        Me.dtpFechaLoteCorte.TabIndex = 51
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Dias Caducidad :"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(163, 74)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(240, 20)
        Me.txtNombre.TabIndex = 46
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Cliente :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(216, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Fecha Corte :"
        '
        'txtFolioSacrificio
        '
        Me.txtFolioSacrificio.AcceptsReturn = True
        Me.txtFolioSacrificio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFolioSacrificio.Location = New System.Drawing.Point(108, 48)
        Me.txtFolioSacrificio.Name = "txtFolioSacrificio"
        Me.txtFolioSacrificio.Size = New System.Drawing.Size(102, 20)
        Me.txtFolioSacrificio.TabIndex = 36
        '
        'txtLoteCorte
        '
        Me.txtLoteCorte.Location = New System.Drawing.Point(108, 21)
        Me.txtLoteCorte.Name = "txtLoteCorte"
        Me.txtLoteCorte.Size = New System.Drawing.Size(102, 20)
        Me.txtLoteCorte.TabIndex = 30
        Me.txtLoteCorte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblEstatus
        '
        Me.lblEstatus.AutoSize = True
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(416, 21)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(104, 24)
        Me.lblEstatus.TabIndex = 29
        Me.lblEstatus.Text = "ESTATUS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Folio de Sacrifio :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lote Corte :"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(56, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(535, 32)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "Apertura de Lotes de Corte"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmActFechaCortes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 280)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mtbMenu)
        Me.Name = "FrmActFechaCortes"
        Me.Text = "FrmActFechaCortes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtbMenu As MEAToolBar.MEAToolBar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaCaducidad As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDiasCaducidad As System.Windows.Forms.TextBox
    Friend WithEvents txtCodCliente As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaSacrificio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaLoteCorte As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFolioSacrificio As System.Windows.Forms.TextBox
    Friend WithEvents txtLoteCorte As System.Windows.Forms.TextBox
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class
