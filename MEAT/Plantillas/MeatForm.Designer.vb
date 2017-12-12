<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MeatForm
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
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.tbrMenu = New MEAToolBar.MEAToolBar
        Me.SuspendLayout()
        '
        'lblEstatus
        '
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(453, 31)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(150, 21)
        Me.lblEstatus.TabIndex = 63
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTitulo.Location = New System.Drawing.Point(50, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(565, 29)
        Me.lblTitulo.TabIndex = 62
        Me.lblTitulo.Text = "TITULO"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbrMenu
        '
        Me.tbrMenu.ButtonSize = New System.Drawing.Size(50, 50)
        Me.tbrMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.tbrMenu.DropDownArrows = True
        Me.tbrMenu.HabilitarBorrar = True
        Me.tbrMenu.HabilitarBuscar = True
        Me.tbrMenu.HabilitarCancelar = True
        Me.tbrMenu.HabilitarEditar = True
        Me.tbrMenu.HabilitarGuardar = True
        Me.tbrMenu.HabilitarImprimir = True
        Me.tbrMenu.HabilitarLimpiar = True
        Me.tbrMenu.HabilitarNuevo = True
        Me.tbrMenu.HabilitarSalir = True
        Me.tbrMenu.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32
        Me.tbrMenu.Location = New System.Drawing.Point(0, 0)
        Me.tbrMenu.MostrarBorrar = True
        Me.tbrMenu.MostrarBuscar = True
        Me.tbrMenu.MostrarCancelar = True
        Me.tbrMenu.MostrarEditar = True
        Me.tbrMenu.MostrarGuardar = True
        Me.tbrMenu.MostrarImprimir = True
        Me.tbrMenu.MostrarLimpiar = True
        Me.tbrMenu.MostrarNuevo = True
        Me.tbrMenu.MostrarSalir = True
        Me.tbrMenu.Name = "tbrMenu"
        Me.tbrMenu.ShowToolTips = True
        Me.tbrMenu.Size = New System.Drawing.Size(50, 495)
        Me.tbrMenu.TabIndex = 61
        '
        'MeatForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 495)
        Me.Controls.Add(Me.lblEstatus)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.tbrMenu)
        Me.Name = "MeatForm"
        Me.Text = "TITULO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents lblEstatus As System.Windows.Forms.Label
    Public WithEvents lblTitulo As System.Windows.Forms.Label
    Public WithEvents tbrMenu As MEAToolBar.MEAToolBar
End Class
