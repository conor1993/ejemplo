<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfigContabilidad
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
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
        Me.gbCancelacionPolizas = New System.Windows.Forms.GroupBox
        Me.rbContrarios = New System.Windows.Forms.RadioButton
        Me.rbNegativos = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtFlete = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtTasaRetenida = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtISR = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtIVA = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ChkMostrarDomicilio = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.gbCancelacionPolizas.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mtb
        '
        Me.mtb.ButtonSize = New System.Drawing.Size(50, 50)
        Me.mtb.Dock = System.Windows.Forms.DockStyle.Left
        Me.mtb.DropDownArrows = True
        Me.mtb.HabilitarBorrar = True
        Me.mtb.HabilitarBuscar = False
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
        Me.mtb.Size = New System.Drawing.Size(50, 262)
        Me.mtb.TabIndex = 135
        '
        'gbCancelacionPolizas
        '
        Me.gbCancelacionPolizas.Controls.Add(Me.rbContrarios)
        Me.gbCancelacionPolizas.Controls.Add(Me.rbNegativos)
        Me.gbCancelacionPolizas.Location = New System.Drawing.Point(74, 135)
        Me.gbCancelacionPolizas.Name = "gbCancelacionPolizas"
        Me.gbCancelacionPolizas.Size = New System.Drawing.Size(222, 100)
        Me.gbCancelacionPolizas.TabIndex = 136
        Me.gbCancelacionPolizas.TabStop = False
        Me.gbCancelacionPolizas.Text = "Método para Cancelar Pólizas"
        Me.gbCancelacionPolizas.Visible = False
        '
        'rbContrarios
        '
        Me.rbContrarios.AutoSize = True
        Me.rbContrarios.Location = New System.Drawing.Point(28, 53)
        Me.rbContrarios.Name = "rbContrarios"
        Me.rbContrarios.Size = New System.Drawing.Size(108, 17)
        Me.rbContrarios.TabIndex = 1
        Me.rbContrarios.TabStop = True
        Me.rbContrarios.Text = "Cargos Contrarios"
        Me.rbContrarios.UseVisualStyleBackColor = True
        '
        'rbNegativos
        '
        Me.rbNegativos.AutoSize = True
        Me.rbNegativos.Location = New System.Drawing.Point(28, 30)
        Me.rbNegativos.Name = "rbNegativos"
        Me.rbNegativos.Size = New System.Drawing.Size(135, 17)
        Me.rbNegativos.TabIndex = 0
        Me.rbNegativos.TabStop = True
        Me.rbNegativos.Text = "Movimientos Negativos"
        Me.rbNegativos.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtFlete)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtTasaRetenida)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtISR)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtIVA)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(74, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(222, 92)
        Me.GroupBox1.TabIndex = 137
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Valores Predeterminados"
        '
        'txtFlete
        '
        Me.txtFlete.Location = New System.Drawing.Point(169, 56)
        Me.txtFlete.Name = "txtFlete"
        Me.txtFlete.Size = New System.Drawing.Size(41, 20)
        Me.txtFlete.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(88, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "IVA Flete :"
        '
        'txtTasaRetenida
        '
        Me.txtTasaRetenida.Location = New System.Drawing.Point(170, 30)
        Me.txtTasaRetenida.Name = "txtTasaRetenida"
        Me.txtTasaRetenida.Size = New System.Drawing.Size(41, 20)
        Me.txtTasaRetenida.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(89, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tasa Retenida:"
        '
        'txtISR
        '
        Me.txtISR.Location = New System.Drawing.Point(47, 56)
        Me.txtISR.Name = "txtISR"
        Me.txtISR.Size = New System.Drawing.Size(41, 20)
        Me.txtISR.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ISR:"
        '
        'txtIVA
        '
        Me.txtIVA.Location = New System.Drawing.Point(47, 30)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.Size = New System.Drawing.Size(41, 20)
        Me.txtIVA.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IVA:"
        '
        'ChkMostrarDomicilio
        '
        Me.ChkMostrarDomicilio.AutoSize = True
        Me.ChkMostrarDomicilio.Location = New System.Drawing.Point(302, 92)
        Me.ChkMostrarDomicilio.Name = "ChkMostrarDomicilio"
        Me.ChkMostrarDomicilio.Size = New System.Drawing.Size(157, 17)
        Me.ChkMostrarDomicilio.TabIndex = 138
        Me.ChkMostrarDomicilio.Text = "Mostrar Domicilio en Polizas"
        Me.ChkMostrarDomicilio.UseVisualStyleBackColor = True
        Me.ChkMostrarDomicilio.Visible = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SteelBlue
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(50, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(452, 29)
        Me.Label5.TabIndex = 139
        Me.Label5.Text = "CONFIGURACION DE CONTABILIDAD"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmConfigContabilidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 262)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ChkMostrarDomicilio)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbCancelacionPolizas)
        Me.Controls.Add(Me.mtb)
        Me.MaximizeBox = False
        Me.Name = "FrmConfigContabilidad"
        Me.Text = "Configuración de Contabilidad"
        Me.gbCancelacionPolizas.ResumeLayout(False)
        Me.gbCancelacionPolizas.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents gbCancelacionPolizas As System.Windows.Forms.GroupBox
    Friend WithEvents rbContrarios As System.Windows.Forms.RadioButton
    Friend WithEvents rbNegativos As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTasaRetenida As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtISR As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtIVA As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ChkMostrarDomicilio As System.Windows.Forms.CheckBox
    Friend WithEvents txtFlete As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
