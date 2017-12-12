<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBanCierreDiario
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
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.GrpFechas = New System.Windows.Forms.GroupBox
        Me.dtpFechaUltimoCierre = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.DtpFechadeCierre = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.GrpFechas.SuspendLayout()
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
        Me.Label17.Size = New System.Drawing.Size(267, 32)
        Me.Label17.TabIndex = 55
        Me.Label17.Text = "Cierre Diario de Bancos"
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
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = False
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 175)
        Me.mtb.TabIndex = 57
        '
        'GrpFechas
        '
        Me.GrpFechas.Controls.Add(Me.dtpFechaUltimoCierre)
        Me.GrpFechas.Controls.Add(Me.Label1)
        Me.GrpFechas.Controls.Add(Me.DtpFechadeCierre)
        Me.GrpFechas.Controls.Add(Me.Label3)
        Me.GrpFechas.Location = New System.Drawing.Point(56, 48)
        Me.GrpFechas.Name = "GrpFechas"
        Me.GrpFechas.Size = New System.Drawing.Size(240, 80)
        Me.GrpFechas.TabIndex = 56
        Me.GrpFechas.TabStop = False
        '
        'dtpFechaUltimoCierre
        '
        Me.dtpFechaUltimoCierre.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaUltimoCierre.Location = New System.Drawing.Point(133, 19)
        Me.dtpFechaUltimoCierre.Name = "dtpFechaUltimoCierre"
        Me.dtpFechaUltimoCierre.Size = New System.Drawing.Size(88, 20)
        Me.dtpFechaUltimoCierre.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Fecha de Ultimo Cierre :"
        '
        'DtpFechadeCierre
        '
        Me.DtpFechadeCierre.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechadeCierre.Location = New System.Drawing.Point(133, 49)
        Me.DtpFechadeCierre.Name = "DtpFechadeCierre"
        Me.DtpFechadeCierre.Size = New System.Drawing.Size(88, 20)
        Me.DtpFechadeCierre.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha Cierre:"
        '
        'FrmBanCierreDiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 175)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.GrpFechas)
        Me.Name = "FrmBanCierreDiario"
        Me.Text = "Cierre Diarios de Bancos"
        Me.GrpFechas.ResumeLayout(False)
        Me.GrpFechas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents GrpFechas As System.Windows.Forms.GroupBox
    Friend WithEvents DtpFechadeCierre As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaUltimoCierre As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
