<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteAlimentosServCorrales
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.ultdtpFechaInicial = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.ultdtpFechaFinal = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.ultdtpFechaInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ultdtpFechaFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(59, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(336, 49)
        Me.lblTitulo.TabIndex = 66
        Me.lblTitulo.Text = "REPORTE DE ALIMENTOS SERVIDOS EN CORRALES/CBZ"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mtb
        '
        Me.mtb.ButtonSize = New System.Drawing.Size(50, 50)
        Me.mtb.Dock = System.Windows.Forms.DockStyle.None
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
        Me.mtb.Location = New System.Drawing.Point(3, -53)
        Me.mtb.MostrarBorrar = False
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = False
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = False
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = False
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 266)
        Me.mtb.TabIndex = 65
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(123, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Fecha Inicial:"
        '
        'ultdtpFechaInicial
        '
        Me.ultdtpFechaInicial.Location = New System.Drawing.Point(199, 61)
        Me.ultdtpFechaInicial.MaskInput = "{date}"
        Me.ultdtpFechaInicial.Name = "ultdtpFechaInicial"
        Me.ultdtpFechaInicial.Nullable = False
        Me.ultdtpFechaInicial.Size = New System.Drawing.Size(103, 21)
        Me.ultdtpFechaInicial.TabIndex = 0
        '
        'ultdtpFechaFinal
        '
        Me.ultdtpFechaFinal.Location = New System.Drawing.Point(199, 88)
        Me.ultdtpFechaFinal.MaskInput = "{date}"
        Me.ultdtpFechaFinal.Name = "ultdtpFechaFinal"
        Me.ultdtpFechaFinal.ReadOnly = True
        Me.ultdtpFechaFinal.Size = New System.Drawing.Size(103, 21)
        Me.ultdtpFechaFinal.TabIndex = 1
        Me.ultdtpFechaFinal.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(123, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Fecha Final:"
        '
        'FrmReporteAlimentosServCorrales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 123)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ultdtpFechaFinal)
        Me.Controls.Add(Me.ultdtpFechaInicial)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.mtb)
        Me.MaximizeBox = False
        Me.Name = "FrmReporteAlimentosServCorrales"
        Me.Text = "REPORTE DE ALIMENTOS SERVIDOS EN CORRALES/CBZ"
        CType(Me.ultdtpFechaInicial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ultdtpFechaFinal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ultdtpFechaInicial As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents ultdtpFechaFinal As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
End Class
