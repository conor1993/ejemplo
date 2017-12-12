<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModInvProdConfigForm
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
        Me.lblTema = New System.Windows.Forms.Label
        Me.pptGrid = New System.Windows.Forms.PropertyGrid
        Me.SuspendLayout()
        '
        'lblTema
        '
        Me.lblTema.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTema.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTema.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTema.ForeColor = System.Drawing.Color.White
        Me.lblTema.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTema.Location = New System.Drawing.Point(0, 0)
        Me.lblTema.Name = "lblTema"
        Me.lblTema.Size = New System.Drawing.Size(645, 29)
        Me.lblTema.TabIndex = 2
        Me.lblTema.Text = "CONFIGURACIÓN DE ALMACENES PRODUCCIÓN"
        Me.lblTema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pptGrid
        '
        Me.pptGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pptGrid.Location = New System.Drawing.Point(11, 34)
        Me.pptGrid.Name = "pptGrid"
        Me.pptGrid.Size = New System.Drawing.Size(622, 485)
        Me.pptGrid.TabIndex = 3
        '
        'ModInvProdConfigForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 531)
        Me.Controls.Add(Me.pptGrid)
        Me.Controls.Add(Me.lblTema)
        Me.Name = "ModInvProdConfigForm"
        Me.Text = "Configuración de Almacenes"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents lblTema As System.Windows.Forms.Label
    Friend WithEvents pptGrid As System.Windows.Forms.PropertyGrid
End Class
