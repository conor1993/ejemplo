<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteVentas
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.chkFecha = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.chkPagadas = New System.Windows.Forms.CheckBox
        Me.chkAbonadas = New System.Windows.Forms.CheckBox
        Me.chkCanceladas = New System.Windows.Forms.CheckBox
        Me.chkVigentes = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbtAscendente = New System.Windows.Forms.RadioButton
        Me.rbtDescendente = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtFechaFinal)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.chkFecha)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtFechaInicial)
        Me.GroupBox1.Location = New System.Drawing.Point(54, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(195, 77)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'dtFechaFinal
        '
        Me.dtFechaFinal.Enabled = False
        Me.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaFinal.Location = New System.Drawing.Point(82, 45)
        Me.dtFechaFinal.Name = "dtFechaFinal"
        Me.dtFechaFinal.Size = New System.Drawing.Size(100, 20)
        Me.dtFechaFinal.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha Final:"
        '
        'chkFecha
        '
        Me.chkFecha.AutoSize = True
        Me.chkFecha.Location = New System.Drawing.Point(9, 0)
        Me.chkFecha.Name = "chkFecha"
        Me.chkFecha.Size = New System.Drawing.Size(113, 17)
        Me.chkFecha.TabIndex = 1
        Me.chkFecha.Text = "Rango De Fechas"
        Me.chkFecha.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha Inicial:"
        '
        'dtFechaInicial
        '
        Me.dtFechaInicial.Enabled = False
        Me.dtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaInicial.Location = New System.Drawing.Point(82, 19)
        Me.dtFechaInicial.Name = "dtFechaInicial"
        Me.dtFechaInicial.Size = New System.Drawing.Size(100, 20)
        Me.dtFechaInicial.TabIndex = 2
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(50, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(252, 32)
        Me.lblTitulo.TabIndex = 17
        Me.lblTitulo.Text = "REPORTE DE VENTAS POR FACTURA"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.mtb.MostrarGuardar = False
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 231)
        Me.mtb.TabIndex = 51
        '
        'chkPagadas
        '
        Me.chkPagadas.AutoSize = True
        Me.chkPagadas.Checked = True
        Me.chkPagadas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPagadas.Location = New System.Drawing.Point(199, 62)
        Me.chkPagadas.Name = "chkPagadas"
        Me.chkPagadas.Size = New System.Drawing.Size(77, 17)
        Me.chkPagadas.TabIndex = 67
        Me.chkPagadas.Tag = "PAGADA"
        Me.chkPagadas.Text = "PAGADAS"
        Me.chkPagadas.UseVisualStyleBackColor = True
        '
        'chkAbonadas
        '
        Me.chkAbonadas.AutoSize = True
        Me.chkAbonadas.Checked = True
        Me.chkAbonadas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAbonadas.Location = New System.Drawing.Point(102, 62)
        Me.chkAbonadas.Name = "chkAbonadas"
        Me.chkAbonadas.Size = New System.Drawing.Size(85, 17)
        Me.chkAbonadas.TabIndex = 66
        Me.chkAbonadas.Tag = "ABONADA"
        Me.chkAbonadas.Text = "ABONADAS"
        Me.chkAbonadas.UseVisualStyleBackColor = True
        '
        'chkCanceladas
        '
        Me.chkCanceladas.AutoSize = True
        Me.chkCanceladas.Checked = True
        Me.chkCanceladas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCanceladas.Location = New System.Drawing.Point(199, 43)
        Me.chkCanceladas.Name = "chkCanceladas"
        Me.chkCanceladas.Size = New System.Drawing.Size(97, 17)
        Me.chkCanceladas.TabIndex = 65
        Me.chkCanceladas.Tag = "CANCELADA"
        Me.chkCanceladas.Text = "CANCELADAS"
        Me.chkCanceladas.UseVisualStyleBackColor = True
        '
        'chkVigentes
        '
        Me.chkVigentes.AutoSize = True
        Me.chkVigentes.Checked = True
        Me.chkVigentes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVigentes.Location = New System.Drawing.Point(102, 42)
        Me.chkVigentes.Name = "chkVigentes"
        Me.chkVigentes.Size = New System.Drawing.Size(80, 17)
        Me.chkVigentes.TabIndex = 64
        Me.chkVigentes.Tag = "VIGENTE"
        Me.chkVigentes.Text = "VIGENTES"
        Me.chkVigentes.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Estatus:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbtDescendente)
        Me.GroupBox2.Controls.Add(Me.rbtAscendente)
        Me.GroupBox2.Location = New System.Drawing.Point(54, 168)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(195, 50)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ordenamiento por Fecha"
        '
        'rbtAscendente
        '
        Me.rbtAscendente.AutoSize = True
        Me.rbtAscendente.Checked = True
        Me.rbtAscendente.Location = New System.Drawing.Point(9, 19)
        Me.rbtAscendente.Name = "rbtAscendente"
        Me.rbtAscendente.Size = New System.Drawing.Size(82, 17)
        Me.rbtAscendente.TabIndex = 68
        Me.rbtAscendente.TabStop = True
        Me.rbtAscendente.Text = "Ascendente"
        Me.rbtAscendente.UseVisualStyleBackColor = True
        '
        'rbtDescendente
        '
        Me.rbtDescendente.AutoSize = True
        Me.rbtDescendente.Location = New System.Drawing.Point(100, 19)
        Me.rbtDescendente.Name = "rbtDescendente"
        Me.rbtDescendente.Size = New System.Drawing.Size(89, 17)
        Me.rbtDescendente.TabIndex = 69
        Me.rbtDescendente.TabStop = True
        Me.rbtDescendente.Text = "Descendente"
        Me.rbtDescendente.UseVisualStyleBackColor = True
        '
        'frmReporteVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 231)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.chkPagadas)
        Me.Controls.Add(Me.chkAbonadas)
        Me.Controls.Add(Me.chkCanceladas)
        Me.Controls.Add(Me.chkVigentes)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmReporteVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Ventas por Factura"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkFecha As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents chkPagadas As System.Windows.Forms.CheckBox
    Friend WithEvents chkAbonadas As System.Windows.Forms.CheckBox
    Friend WithEvents chkCanceladas As System.Windows.Forms.CheckBox
    Friend WithEvents chkVigentes As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtDescendente As System.Windows.Forms.RadioButton
    Friend WithEvents rbtAscendente As System.Windows.Forms.RadioButton
End Class
