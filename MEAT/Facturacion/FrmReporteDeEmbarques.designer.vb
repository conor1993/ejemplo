<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteDeEmbarques
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
        Me.Label4 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.cmbClientes = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.grpRangoFechas = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.grpEstatus = New System.Windows.Forms.GroupBox
        Me.chkFacturado = New System.Windows.Forms.CheckBox
        Me.chkCancelado = New System.Windows.Forms.CheckBox
        Me.chkVigente = New System.Windows.Forms.CheckBox
        Me.chkTodos = New System.Windows.Forms.CheckBox
        Me.grpTipoReporte = New System.Windows.Forms.GroupBox
        Me.rbtConcentrado = New System.Windows.Forms.RadioButton
        Me.rbtDetallado = New System.Windows.Forms.RadioButton
        Me.grpOrdenamiento = New System.Windows.Forms.GroupBox
        Me.optFactura = New System.Windows.Forms.RadioButton
        Me.optSalida = New System.Windows.Forms.RadioButton
        Me.optCliente = New System.Windows.Forms.RadioButton
        Me.grpTipoProducto = New System.Windows.Forms.GroupBox
        Me.optProducto = New System.Windows.Forms.RadioButton
        Me.optCorte = New System.Windows.Forms.RadioButton
        Me.optCanal = New System.Windows.Forms.RadioButton
        Me.grpRangoFechas.SuspendLayout()
        Me.grpEstatus.SuspendLayout()
        Me.grpTipoReporte.SuspendLayout()
        Me.grpOrdenamiento.SuspendLayout()
        Me.grpTipoProducto.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(50, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(844, 32)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Reporte De Embarques"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.mtb.Size = New System.Drawing.Size(50, 170)
        Me.mtb.TabIndex = 51
        '
        'cmbClientes
        '
        Me.cmbClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbClientes.FormattingEnabled = True
        Me.cmbClientes.Location = New System.Drawing.Point(106, 36)
        Me.cmbClientes.Name = "cmbClientes"
        Me.cmbClientes.Size = New System.Drawing.Size(468, 21)
        Me.cmbClientes.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Cliente:"
        '
        'grpRangoFechas
        '
        Me.grpRangoFechas.Controls.Add(Me.Label2)
        Me.grpRangoFechas.Controls.Add(Me.dtpFechaFinal)
        Me.grpRangoFechas.Controls.Add(Me.Label1)
        Me.grpRangoFechas.Controls.Add(Me.dtpFechaInicial)
        Me.grpRangoFechas.Location = New System.Drawing.Point(58, 62)
        Me.grpRangoFechas.Name = "grpRangoFechas"
        Me.grpRangoFechas.Size = New System.Drawing.Size(189, 97)
        Me.grpRangoFechas.TabIndex = 1
        Me.grpRangoFechas.TabStop = False
        Me.grpRangoFechas.Text = "Rango de Fechas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Fecha Final:"
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(80, 45)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(102, 20)
        Me.dtpFechaFinal.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Fecha Incial:"
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicial.Location = New System.Drawing.Point(80, 19)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(102, 20)
        Me.dtpFechaInicial.TabIndex = 0
        '
        'grpEstatus
        '
        Me.grpEstatus.Controls.Add(Me.chkFacturado)
        Me.grpEstatus.Controls.Add(Me.chkCancelado)
        Me.grpEstatus.Controls.Add(Me.chkVigente)
        Me.grpEstatus.Controls.Add(Me.chkTodos)
        Me.grpEstatus.Location = New System.Drawing.Point(577, 63)
        Me.grpEstatus.Name = "grpEstatus"
        Me.grpEstatus.Size = New System.Drawing.Size(183, 96)
        Me.grpEstatus.TabIndex = 4
        Me.grpEstatus.TabStop = False
        Me.grpEstatus.Text = "Estatus"
        '
        'chkFacturado
        '
        Me.chkFacturado.AutoSize = True
        Me.chkFacturado.Location = New System.Drawing.Point(101, 23)
        Me.chkFacturado.Name = "chkFacturado"
        Me.chkFacturado.Size = New System.Drawing.Size(74, 17)
        Me.chkFacturado.TabIndex = 3
        Me.chkFacturado.Text = "Facturado"
        Me.chkFacturado.UseVisualStyleBackColor = True
        '
        'chkCancelado
        '
        Me.chkCancelado.AutoSize = True
        Me.chkCancelado.Location = New System.Drawing.Point(22, 69)
        Me.chkCancelado.Name = "chkCancelado"
        Me.chkCancelado.Size = New System.Drawing.Size(77, 17)
        Me.chkCancelado.TabIndex = 2
        Me.chkCancelado.Text = "Cancelado"
        Me.chkCancelado.UseVisualStyleBackColor = True
        '
        'chkVigente
        '
        Me.chkVigente.AutoSize = True
        Me.chkVigente.Checked = True
        Me.chkVigente.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVigente.Location = New System.Drawing.Point(22, 46)
        Me.chkVigente.Name = "chkVigente"
        Me.chkVigente.Size = New System.Drawing.Size(62, 17)
        Me.chkVigente.TabIndex = 1
        Me.chkVigente.Text = "Vigente"
        Me.chkVigente.UseVisualStyleBackColor = True
        '
        'chkTodos
        '
        Me.chkTodos.AutoSize = True
        Me.chkTodos.Location = New System.Drawing.Point(22, 23)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(56, 17)
        Me.chkTodos.TabIndex = 0
        Me.chkTodos.Text = "Todos"
        Me.chkTodos.UseVisualStyleBackColor = True
        '
        'grpTipoReporte
        '
        Me.grpTipoReporte.Controls.Add(Me.rbtConcentrado)
        Me.grpTipoReporte.Controls.Add(Me.rbtDetallado)
        Me.grpTipoReporte.Location = New System.Drawing.Point(258, 62)
        Me.grpTipoReporte.Name = "grpTipoReporte"
        Me.grpTipoReporte.Size = New System.Drawing.Size(107, 97)
        Me.grpTipoReporte.TabIndex = 2
        Me.grpTipoReporte.TabStop = False
        Me.grpTipoReporte.Text = "Reporte"
        '
        'rbtConcentrado
        '
        Me.rbtConcentrado.AutoSize = True
        Me.rbtConcentrado.Checked = True
        Me.rbtConcentrado.Location = New System.Drawing.Point(6, 19)
        Me.rbtConcentrado.Name = "rbtConcentrado"
        Me.rbtConcentrado.Size = New System.Drawing.Size(86, 17)
        Me.rbtConcentrado.TabIndex = 0
        Me.rbtConcentrado.TabStop = True
        Me.rbtConcentrado.Text = "Concentrado"
        Me.rbtConcentrado.UseVisualStyleBackColor = True
        '
        'rbtDetallado
        '
        Me.rbtDetallado.AutoSize = True
        Me.rbtDetallado.Location = New System.Drawing.Point(6, 42)
        Me.rbtDetallado.Name = "rbtDetallado"
        Me.rbtDetallado.Size = New System.Drawing.Size(70, 17)
        Me.rbtDetallado.TabIndex = 1
        Me.rbtDetallado.Text = "Detallado"
        Me.rbtDetallado.UseVisualStyleBackColor = True
        '
        'grpOrdenamiento
        '
        Me.grpOrdenamiento.Controls.Add(Me.optFactura)
        Me.grpOrdenamiento.Controls.Add(Me.optSalida)
        Me.grpOrdenamiento.Controls.Add(Me.optCliente)
        Me.grpOrdenamiento.Location = New System.Drawing.Point(371, 63)
        Me.grpOrdenamiento.Name = "grpOrdenamiento"
        Me.grpOrdenamiento.Size = New System.Drawing.Size(200, 96)
        Me.grpOrdenamiento.TabIndex = 3
        Me.grpOrdenamiento.TabStop = False
        Me.grpOrdenamiento.Text = "Ordenado por :"
        '
        'optFactura
        '
        Me.optFactura.AutoSize = True
        Me.optFactura.Location = New System.Drawing.Point(6, 64)
        Me.optFactura.Name = "optFactura"
        Me.optFactura.Size = New System.Drawing.Size(61, 17)
        Me.optFactura.TabIndex = 2
        Me.optFactura.Text = "Factura"
        Me.optFactura.UseVisualStyleBackColor = True
        '
        'optSalida
        '
        Me.optSalida.AutoSize = True
        Me.optSalida.Location = New System.Drawing.Point(6, 41)
        Me.optSalida.Name = "optSalida"
        Me.optSalida.Size = New System.Drawing.Size(129, 17)
        Me.optSalida.TabIndex = 1
        Me.optSalida.Text = "Salida (Folio Empresa)"
        Me.optSalida.UseVisualStyleBackColor = True
        '
        'optCliente
        '
        Me.optCliente.AutoSize = True
        Me.optCliente.Checked = True
        Me.optCliente.Location = New System.Drawing.Point(6, 18)
        Me.optCliente.Name = "optCliente"
        Me.optCliente.Size = New System.Drawing.Size(57, 17)
        Me.optCliente.TabIndex = 0
        Me.optCliente.TabStop = True
        Me.optCliente.Text = "Cliente"
        Me.optCliente.UseVisualStyleBackColor = True
        '
        'grpTipoProducto
        '
        Me.grpTipoProducto.Controls.Add(Me.optProducto)
        Me.grpTipoProducto.Controls.Add(Me.optCorte)
        Me.grpTipoProducto.Controls.Add(Me.optCanal)
        Me.grpTipoProducto.Location = New System.Drawing.Point(766, 63)
        Me.grpTipoProducto.Name = "grpTipoProducto"
        Me.grpTipoProducto.Size = New System.Drawing.Size(112, 96)
        Me.grpTipoProducto.TabIndex = 5
        Me.grpTipoProducto.TabStop = False
        Me.grpTipoProducto.Text = "Tipo de Producto:"
        '
        'optProducto
        '
        Me.optProducto.AutoSize = True
        Me.optProducto.Location = New System.Drawing.Point(6, 65)
        Me.optProducto.Name = "optProducto"
        Me.optProducto.Size = New System.Drawing.Size(68, 17)
        Me.optProducto.TabIndex = 2
        Me.optProducto.TabStop = True
        Me.optProducto.Text = "Producto"
        Me.optProducto.UseVisualStyleBackColor = True
        '
        'optCorte
        '
        Me.optCorte.AutoSize = True
        Me.optCorte.Location = New System.Drawing.Point(6, 42)
        Me.optCorte.Name = "optCorte"
        Me.optCorte.Size = New System.Drawing.Size(50, 17)
        Me.optCorte.TabIndex = 1
        Me.optCorte.TabStop = True
        Me.optCorte.Text = "Corte"
        Me.optCorte.UseVisualStyleBackColor = True
        '
        'optCanal
        '
        Me.optCanal.AutoSize = True
        Me.optCanal.Location = New System.Drawing.Point(6, 19)
        Me.optCanal.Name = "optCanal"
        Me.optCanal.Size = New System.Drawing.Size(52, 17)
        Me.optCanal.TabIndex = 0
        Me.optCanal.TabStop = True
        Me.optCanal.Text = "Canal"
        Me.optCanal.UseVisualStyleBackColor = True
        '
        'FrmReporteDeEmbarques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 170)
        Me.Controls.Add(Me.grpTipoProducto)
        Me.Controls.Add(Me.grpOrdenamiento)
        Me.Controls.Add(Me.grpTipoReporte)
        Me.Controls.Add(Me.grpEstatus)
        Me.Controls.Add(Me.cmbClientes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.grpRangoFechas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.mtb)
        Me.MaximizeBox = False
        Me.Name = "FrmReporteDeEmbarques"
        Me.Text = "Reporte De Embarques"
        Me.grpRangoFechas.ResumeLayout(False)
        Me.grpRangoFechas.PerformLayout()
        Me.grpEstatus.ResumeLayout(False)
        Me.grpEstatus.PerformLayout()
        Me.grpTipoReporte.ResumeLayout(False)
        Me.grpTipoReporte.PerformLayout()
        Me.grpOrdenamiento.ResumeLayout(False)
        Me.grpOrdenamiento.PerformLayout()
        Me.grpTipoProducto.ResumeLayout(False)
        Me.grpTipoProducto.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents cmbClientes As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grpRangoFechas As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents grpEstatus As System.Windows.Forms.GroupBox
    Friend WithEvents chkFacturado As System.Windows.Forms.CheckBox
    Friend WithEvents chkCancelado As System.Windows.Forms.CheckBox
    Friend WithEvents chkVigente As System.Windows.Forms.CheckBox
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents grpTipoReporte As System.Windows.Forms.GroupBox
    Friend WithEvents rbtConcentrado As System.Windows.Forms.RadioButton
    Friend WithEvents rbtDetallado As System.Windows.Forms.RadioButton
    Friend WithEvents grpOrdenamiento As System.Windows.Forms.GroupBox
    Friend WithEvents optFactura As System.Windows.Forms.RadioButton
    Friend WithEvents optSalida As System.Windows.Forms.RadioButton
    Friend WithEvents optCliente As System.Windows.Forms.RadioButton
    Friend WithEvents grpTipoProducto As System.Windows.Forms.GroupBox
    Friend WithEvents optProducto As System.Windows.Forms.RadioButton
    Friend WithEvents optCorte As System.Windows.Forms.RadioButton
    Friend WithEvents optCanal As System.Windows.Forms.RadioButton
End Class
