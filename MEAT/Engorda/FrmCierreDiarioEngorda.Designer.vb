<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCierreDiarioEngorda
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
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblFechaUltimoCierre = New System.Windows.Forms.Label
        Me.lblFechaACerrar = New System.Windows.Forms.Label
        Me.SuspendLayout()
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
        Me.mtb.Location = New System.Drawing.Point(0, -57)
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
        Me.mtb.Size = New System.Drawing.Size(50, 266)
        Me.mtb.TabIndex = 110
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(56, -1)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(237, 32)
        Me.Label17.TabIndex = 109
        Me.Label17.Text = "Cierre Diario de Engorda"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 13)
        Me.Label3.TabIndex = 111
        Me.Label3.Text = "Fecha de Último Cierre :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 113
        Me.Label4.Text = "Fecha a Cerrar :"
        '
        'lblFechaUltimoCierre
        '
        Me.lblFechaUltimoCierre.AutoSize = True
        Me.lblFechaUltimoCierre.Location = New System.Drawing.Point(183, 55)
        Me.lblFechaUltimoCierre.Name = "lblFechaUltimoCierre"
        Me.lblFechaUltimoCierre.Size = New System.Drawing.Size(103, 13)
        Me.lblFechaUltimoCierre.TabIndex = 114
        Me.lblFechaUltimoCierre.Text = "lblFechaUltimoCierre"
        '
        'lblFechaACerrar
        '
        Me.lblFechaACerrar.AutoSize = True
        Me.lblFechaACerrar.Location = New System.Drawing.Point(183, 78)
        Me.lblFechaACerrar.Name = "lblFechaACerrar"
        Me.lblFechaACerrar.Size = New System.Drawing.Size(82, 13)
        Me.lblFechaACerrar.TabIndex = 115
        Me.lblFechaACerrar.Text = "lblFechaACerrar"
        '
        'FrmCierreDiarioEngorda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 116)
        Me.Controls.Add(Me.lblFechaACerrar)
        Me.Controls.Add(Me.lblFechaUltimoCierre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.Label17)
        Me.Name = "FrmCierreDiarioEngorda"
        Me.Text = "Cierre Diario de Engorda"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblFechaUltimoCierre As System.Windows.Forms.Label
    Friend WithEvents lblFechaACerrar As System.Windows.Forms.Label
End Class
