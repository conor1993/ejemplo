<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteInvFisico
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.mtb = New MEAToolBar.MEAToolBar()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbProducto = New System.Windows.Forms.ComboBox()
        Me.gbLineas = New System.Windows.Forms.GroupBox()
        Me.gbMovimientos = New System.Windows.Forms.GroupBox()
        Me.rbSinMov = New System.Windows.Forms.RadioButton()
        Me.rbConMov = New System.Windows.Forms.RadioButton()
        Me.gbLineas.SuspendLayout()
        Me.gbMovimientos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Location = New System.Drawing.Point(6, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(495, 91)
        Me.Panel1.TabIndex = 0
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
        Me.mtb.Size = New System.Drawing.Size(50, 303)
        Me.mtb.TabIndex = 3
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.MaximumSize = New System.Drawing.Size(1600, 900)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(546, 29)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "REPORTE CONTEO DEL INVENTARIO FISICO"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Productos:"
        '
        'cmbProducto
        '
        Me.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProducto.FormattingEnabled = True
        Me.cmbProducto.Location = New System.Drawing.Point(162, 185)
        Me.cmbProducto.Name = "cmbProducto"
        Me.cmbProducto.Size = New System.Drawing.Size(423, 24)
        Me.cmbProducto.TabIndex = 6
        '
        'gbLineas
        '
        Me.gbLineas.Controls.Add(Me.Panel1)
        Me.gbLineas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbLineas.Location = New System.Drawing.Point(77, 46)
        Me.gbLineas.Name = "gbLineas"
        Me.gbLineas.Size = New System.Drawing.Size(507, 126)
        Me.gbLineas.TabIndex = 7
        Me.gbLineas.TabStop = False
        Me.gbLineas.Text = "Lineas"
        '
        'gbMovimientos
        '
        Me.gbMovimientos.Controls.Add(Me.rbSinMov)
        Me.gbMovimientos.Controls.Add(Me.rbConMov)
        Me.gbMovimientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbMovimientos.Location = New System.Drawing.Point(86, 224)
        Me.gbMovimientos.Name = "gbMovimientos"
        Me.gbMovimientos.Size = New System.Drawing.Size(460, 65)
        Me.gbMovimientos.TabIndex = 8
        Me.gbMovimientos.TabStop = False
        Me.gbMovimientos.Text = "Movimientos"
        '
        'rbSinMov
        '
        Me.rbSinMov.AutoSize = True
        Me.rbSinMov.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSinMov.Location = New System.Drawing.Point(260, 30)
        Me.rbSinMov.Name = "rbSinMov"
        Me.rbSinMov.Size = New System.Drawing.Size(111, 19)
        Me.rbSinMov.TabIndex = 1
        Me.rbSinMov.TabStop = True
        Me.rbSinMov.Text = "Con y Sin Movs."
        Me.rbSinMov.UseVisualStyleBackColor = True
        '
        'rbConMov
        '
        Me.rbConMov.AutoSize = True
        Me.rbConMov.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbConMov.Location = New System.Drawing.Point(76, 30)
        Me.rbConMov.Name = "rbConMov"
        Me.rbConMov.Size = New System.Drawing.Size(82, 19)
        Me.rbConMov.TabIndex = 0
        Me.rbConMov.TabStop = True
        Me.rbConMov.Text = "Con Movs."
        Me.rbConMov.UseVisualStyleBackColor = True
        '
        'frmReporteInvFisico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 303)
        Me.Controls.Add(Me.gbMovimientos)
        Me.Controls.Add(Me.gbLineas)
        Me.Controls.Add(Me.cmbProducto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(612, 341)
        Me.MinimumSize = New System.Drawing.Size(612, 341)
        Me.Name = "frmReporteInvFisico"
        Me.Text = "frmReporteInvFisico"
        Me.gbLineas.ResumeLayout(False)
        Me.gbMovimientos.ResumeLayout(False)
        Me.gbMovimientos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbProducto As System.Windows.Forms.ComboBox
    Friend WithEvents gbLineas As System.Windows.Forms.GroupBox
    Friend WithEvents gbMovimientos As System.Windows.Forms.GroupBox
    Friend WithEvents rbSinMov As System.Windows.Forms.RadioButton
    Friend WithEvents rbConMov As System.Windows.Forms.RadioButton
End Class
