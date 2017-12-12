<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigPV
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
        Me.lblTema = New System.Windows.Forms.Label()
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbSucursal = New System.Windows.Forms.ComboBox()
        Me.cmbImpresorasInstaladas = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbConceptos = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbNO = New System.Windows.Forms.RadioButton()
        Me.rbSI = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbCorteDiario = New System.Windows.Forms.GroupBox()
        Me.rbNOCorteDiario = New System.Windows.Forms.RadioButton()
        Me.rbSICorteDiario = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.gbCorteDiario.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTema
        '
        Me.lblTema.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTema.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTema.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTema.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTema.Location = New System.Drawing.Point(0, 0)
        Me.lblTema.Name = "lblTema"
        Me.lblTema.Size = New System.Drawing.Size(596, 29)
        Me.lblTema.TabIndex = 9
        Me.lblTema.Text = "CONFIGURACIÓN DE PUNTO DE VENTA"
        Me.lblTema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MEAToolBar1
        '
        Me.MEAToolBar1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MEAToolBar1.ButtonSize = New System.Drawing.Size(50, 50)
        Me.MEAToolBar1.Dock = System.Windows.Forms.DockStyle.None
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
        Me.MEAToolBar1.Location = New System.Drawing.Point(-1, 30)
        Me.MEAToolBar1.MaximumSize = New System.Drawing.Size(50, 350)
        Me.MEAToolBar1.MostrarBorrar = False
        Me.MEAToolBar1.MostrarBuscar = False
        Me.MEAToolBar1.MostrarCancelar = False
        Me.MEAToolBar1.MostrarEditar = False
        Me.MEAToolBar1.MostrarGuardar = True
        Me.MEAToolBar1.MostrarImprimir = False
        Me.MEAToolBar1.MostrarLimpiar = False
        Me.MEAToolBar1.MostrarNuevo = False
        Me.MEAToolBar1.MostrarSalir = True
        Me.MEAToolBar1.Name = "MEAToolBar1"
        Me.MEAToolBar1.ShowToolTips = True
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 268)
        Me.MEAToolBar1.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(205, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Sucursal:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(123, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nombre de impresora:"
        '
        'cmbSucursal
        '
        Me.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(278, 56)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(306, 24)
        Me.cmbSucursal.TabIndex = 13
        '
        'cmbImpresorasInstaladas
        '
        Me.cmbImpresorasInstaladas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbImpresorasInstaladas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbImpresorasInstaladas.FormattingEnabled = True
        Me.cmbImpresorasInstaladas.Location = New System.Drawing.Point(278, 104)
        Me.cmbImpresorasInstaladas.Name = "cmbImpresorasInstaladas"
        Me.cmbImpresorasInstaladas.Size = New System.Drawing.Size(306, 24)
        Me.cmbImpresorasInstaladas.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(56, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Concepto retiro pago de compra:"
        '
        'cmbConceptos
        '
        Me.cmbConceptos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbConceptos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbConceptos.FormattingEnabled = True
        Me.cmbConceptos.Location = New System.Drawing.Point(278, 155)
        Me.cmbConceptos.Name = "cmbConceptos"
        Me.cmbConceptos.Size = New System.Drawing.Size(306, 24)
        Me.cmbConceptos.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(123, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 17)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Vender Sin Existencia:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbNO)
        Me.GroupBox1.Controls.Add(Me.rbSI)
        Me.GroupBox1.Location = New System.Drawing.Point(278, 194)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(177, 43)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'rbNO
        '
        Me.rbNO.AutoSize = True
        Me.rbNO.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNO.Location = New System.Drawing.Point(104, 14)
        Me.rbNO.Name = "rbNO"
        Me.rbNO.Size = New System.Drawing.Size(49, 21)
        Me.rbNO.TabIndex = 1
        Me.rbNO.TabStop = True
        Me.rbNO.Text = "NO"
        Me.rbNO.UseVisualStyleBackColor = True
        '
        'rbSI
        '
        Me.rbSI.AutoSize = True
        Me.rbSI.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSI.Location = New System.Drawing.Point(24, 14)
        Me.rbSI.Name = "rbSI"
        Me.rbSI.Size = New System.Drawing.Size(40, 21)
        Me.rbSI.TabIndex = 0
        Me.rbSI.TabStop = True
        Me.rbSI.Text = "SI"
        Me.rbSI.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(135, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 17)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Obligar Corte Diario:"
        '
        'gbCorteDiario
        '
        Me.gbCorteDiario.Controls.Add(Me.rbNOCorteDiario)
        Me.gbCorteDiario.Controls.Add(Me.rbSICorteDiario)
        Me.gbCorteDiario.Location = New System.Drawing.Point(278, 243)
        Me.gbCorteDiario.Name = "gbCorteDiario"
        Me.gbCorteDiario.Size = New System.Drawing.Size(177, 43)
        Me.gbCorteDiario.TabIndex = 20
        Me.gbCorteDiario.TabStop = False
        '
        'rbNOCorteDiario
        '
        Me.rbNOCorteDiario.AutoSize = True
        Me.rbNOCorteDiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNOCorteDiario.Location = New System.Drawing.Point(104, 14)
        Me.rbNOCorteDiario.Name = "rbNOCorteDiario"
        Me.rbNOCorteDiario.Size = New System.Drawing.Size(49, 21)
        Me.rbNOCorteDiario.TabIndex = 1
        Me.rbNOCorteDiario.TabStop = True
        Me.rbNOCorteDiario.Text = "NO"
        Me.rbNOCorteDiario.UseVisualStyleBackColor = True
        '
        'rbSICorteDiario
        '
        Me.rbSICorteDiario.AutoSize = True
        Me.rbSICorteDiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSICorteDiario.Location = New System.Drawing.Point(24, 14)
        Me.rbSICorteDiario.Name = "rbSICorteDiario"
        Me.rbSICorteDiario.Size = New System.Drawing.Size(40, 21)
        Me.rbSICorteDiario.TabIndex = 0
        Me.rbSICorteDiario.TabStop = True
        Me.rbSICorteDiario.Text = "SI"
        Me.rbSICorteDiario.UseVisualStyleBackColor = True
        '
        'ConfigPV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 297)
        Me.Controls.Add(Me.gbCorteDiario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbConceptos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbImpresorasInstaladas)
        Me.Controls.Add(Me.cmbSucursal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.Controls.Add(Me.lblTema)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(612, 335)
        Me.MinimumSize = New System.Drawing.Size(612, 335)
        Me.Name = "ConfigPV"
        Me.Text = "Configuración de Punto de Venta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbCorteDiario.ResumeLayout(False)
        Me.gbCorteDiario.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents lblTema As System.Windows.Forms.Label
    Private WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents cmbImpresorasInstaladas As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbConceptos As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbNO As System.Windows.Forms.RadioButton
    Friend WithEvents rbSI As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gbCorteDiario As System.Windows.Forms.GroupBox
    Friend WithEvents rbNOCorteDiario As System.Windows.Forms.RadioButton
    Friend WithEvents rbSICorteDiario As System.Windows.Forms.RadioButton
End Class
