<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaCorralesRecepcion
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
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbCorralRecepcion = New System.Windows.Forms.ComboBox
        Me.txtCabezas = New System.Windows.Forms.TextBox
        Me.txtKilos = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtUltReinicio = New System.Windows.Forms.TextBox
        Me.txtUltSalida = New System.Windows.Forms.TextBox
        Me.txtUltEntrada = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtCostoxCabeza = New System.Windows.Forms.TextBox
        Me.txtCostoxKilo = New System.Windows.Forms.TextBox
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.txtMedicamentos = New System.Windows.Forms.TextBox
        Me.txtAlimentos = New System.Windows.Forms.TextBox
        Me.txtEntradas = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MEAToolBar1
        '
        Me.MEAToolBar1.ButtonSize = New System.Drawing.Size(50, 50)
        Me.MEAToolBar1.Dock = System.Windows.Forms.DockStyle.Left
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
        Me.MEAToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.MEAToolBar1.MostrarBorrar = False
        Me.MEAToolBar1.MostrarBuscar = False
        Me.MEAToolBar1.MostrarCancelar = False
        Me.MEAToolBar1.MostrarEditar = False
        Me.MEAToolBar1.MostrarGuardar = False
        Me.MEAToolBar1.MostrarImprimir = True
        Me.MEAToolBar1.MostrarLimpiar = True
        Me.MEAToolBar1.MostrarNuevo = False
        Me.MEAToolBar1.MostrarSalir = True
        Me.MEAToolBar1.Name = "MEAToolBar1"
        Me.MEAToolBar1.ShowToolTips = True
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 317)
        Me.MEAToolBar1.TabIndex = 33
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(56, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(454, 32)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "Consulta de Corrales de Recepción "
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbCorralRecepcion)
        Me.GroupBox1.Controls.Add(Me.txtCabezas)
        Me.GroupBox1.Controls.Add(Me.txtKilos)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 264)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        '
        'cmbCorralRecepcion
        '
        Me.cmbCorralRecepcion.FormattingEnabled = True
        Me.cmbCorralRecepcion.Location = New System.Drawing.Point(117, 13)
        Me.cmbCorralRecepcion.Name = "cmbCorralRecepcion"
        Me.cmbCorralRecepcion.Size = New System.Drawing.Size(296, 21)
        Me.cmbCorralRecepcion.TabIndex = 56
        '
        'txtCabezas
        '
        Me.txtCabezas.Location = New System.Drawing.Point(117, 39)
        Me.txtCabezas.Name = "txtCabezas"
        Me.txtCabezas.ReadOnly = True
        Me.txtCabezas.Size = New System.Drawing.Size(96, 20)
        Me.txtCabezas.TabIndex = 33
        '
        'txtKilos
        '
        Me.txtKilos.Location = New System.Drawing.Point(316, 39)
        Me.txtKilos.Name = "txtKilos"
        Me.txtKilos.ReadOnly = True
        Me.txtKilos.Size = New System.Drawing.Size(96, 20)
        Me.txtKilos.TabIndex = 32
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtUltReinicio)
        Me.GroupBox3.Controls.Add(Me.txtUltSalida)
        Me.GroupBox3.Controls.Add(Me.txtUltEntrada)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(215, 68)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(219, 185)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Fecha "
        '
        'txtUltReinicio
        '
        Me.txtUltReinicio.Location = New System.Drawing.Point(94, 131)
        Me.txtUltReinicio.Name = "txtUltReinicio"
        Me.txtUltReinicio.ReadOnly = True
        Me.txtUltReinicio.Size = New System.Drawing.Size(96, 20)
        Me.txtUltReinicio.TabIndex = 34
        '
        'txtUltSalida
        '
        Me.txtUltSalida.Location = New System.Drawing.Point(94, 79)
        Me.txtUltSalida.Name = "txtUltSalida"
        Me.txtUltSalida.ReadOnly = True
        Me.txtUltSalida.Size = New System.Drawing.Size(96, 20)
        Me.txtUltSalida.TabIndex = 33
        '
        'txtUltEntrada
        '
        Me.txtUltEntrada.Location = New System.Drawing.Point(94, 22)
        Me.txtUltEntrada.Name = "txtUltEntrada"
        Me.txtUltEntrada.ReadOnly = True
        Me.txtUltEntrada.Size = New System.Drawing.Size(96, 20)
        Me.txtUltEntrada.TabIndex = 32
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(5, 134)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Ultima Reinicio :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 82)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Ultima Salida :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Ultima Entrada :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCostoxCabeza)
        Me.GroupBox2.Controls.Add(Me.txtCostoxKilo)
        Me.GroupBox2.Controls.Add(Me.txtTotal)
        Me.GroupBox2.Controls.Add(Me.txtMedicamentos)
        Me.GroupBox2.Controls.Add(Me.txtAlimentos)
        Me.GroupBox2.Controls.Add(Me.txtEntradas)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 68)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 185)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Costos Aplicados"
        '
        'txtCostoxCabeza
        '
        Me.txtCostoxCabeza.Location = New System.Drawing.Point(98, 151)
        Me.txtCostoxCabeza.Name = "txtCostoxCabeza"
        Me.txtCostoxCabeza.ReadOnly = True
        Me.txtCostoxCabeza.Size = New System.Drawing.Size(96, 20)
        Me.txtCostoxCabeza.TabIndex = 36
        '
        'txtCostoxKilo
        '
        Me.txtCostoxKilo.Location = New System.Drawing.Point(98, 126)
        Me.txtCostoxKilo.Name = "txtCostoxKilo"
        Me.txtCostoxKilo.ReadOnly = True
        Me.txtCostoxKilo.Size = New System.Drawing.Size(96, 20)
        Me.txtCostoxKilo.TabIndex = 35
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(98, 100)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(96, 20)
        Me.txtTotal.TabIndex = 34
        '
        'txtMedicamentos
        '
        Me.txtMedicamentos.Location = New System.Drawing.Point(98, 74)
        Me.txtMedicamentos.Name = "txtMedicamentos"
        Me.txtMedicamentos.ReadOnly = True
        Me.txtMedicamentos.Size = New System.Drawing.Size(96, 20)
        Me.txtMedicamentos.TabIndex = 33
        '
        'txtAlimentos
        '
        Me.txtAlimentos.Location = New System.Drawing.Point(98, 48)
        Me.txtAlimentos.Name = "txtAlimentos"
        Me.txtAlimentos.ReadOnly = True
        Me.txtAlimentos.Size = New System.Drawing.Size(96, 20)
        Me.txtAlimentos.TabIndex = 32
        '
        'txtEntradas
        '
        Me.txtEntradas.Location = New System.Drawing.Point(98, 22)
        Me.txtEntradas.Name = "txtEntradas"
        Me.txtEntradas.ReadOnly = True
        Me.txtEntradas.Size = New System.Drawing.Size(96, 20)
        Me.txtEntradas.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 154)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Costo x cabeza :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Costo x kilo :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Total :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Medicamentos :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Alimentos :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Entradas :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(221, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Kilos : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cabezas :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Corral de recepción :"
        '
        'FrmConsultaCorralesRecepcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 317)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.Controls.Add(Me.Label17)
        Me.Name = "FrmConsultaCorralesRecepcion"
        Me.Text = "Consulta de Corrales de Recepción"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCabezas As System.Windows.Forms.TextBox
    Friend WithEvents txtKilos As System.Windows.Forms.TextBox
    Friend WithEvents txtUltReinicio As System.Windows.Forms.TextBox
    Friend WithEvents txtUltSalida As System.Windows.Forms.TextBox
    Friend WithEvents txtUltEntrada As System.Windows.Forms.TextBox
    Friend WithEvents txtCostoxCabeza As System.Windows.Forms.TextBox
    Friend WithEvents txtCostoxKilo As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtMedicamentos As System.Windows.Forms.TextBox
    Friend WithEvents txtAlimentos As System.Windows.Forms.TextBox
    Friend WithEvents txtEntradas As System.Windows.Forms.TextBox
    Friend WithEvents cmbCorralRecepcion As System.Windows.Forms.ComboBox
End Class
