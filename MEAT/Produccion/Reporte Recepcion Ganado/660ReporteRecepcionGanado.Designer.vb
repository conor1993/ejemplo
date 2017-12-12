<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _660ReporteRecepcionGanado
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DtpFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.DtpFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtFolioRec = New System.Windows.Forms.TextBox
        Me.txtLoteEngorda = New System.Windows.Forms.TextBox
        Me.CmbIntroductor = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RdbTodas = New System.Windows.Forms.RadioButton
        Me.RdbCanceladas = New System.Windows.Forms.RadioButton
        Me.RdbVigentes = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DgvRecepcionGanado = New System.Windows.Forms.DataGridView
        Me.LoteRecepcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaRecepcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Productor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LoteEngorda = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantCabezas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KilosEnviados = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KilosRecibidos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Conductor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Unidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Placas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Estatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgvRecepcionGanado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(56, -1)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(748, 32)
        Me.Label17.TabIndex = 48
        Me.Label17.Text = "Reporte de Recepción de Ganado"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DtpFechaFinal)
        Me.GroupBox1.Controls.Add(Me.DtpFechaInicio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(449, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(194, 83)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rango de Fechas"
        '
        'DtpFechaFinal
        '
        Me.DtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaFinal.Location = New System.Drawing.Point(83, 50)
        Me.DtpFechaFinal.Name = "DtpFechaFinal"
        Me.DtpFechaFinal.Size = New System.Drawing.Size(98, 20)
        Me.DtpFechaFinal.TabIndex = 3
        '
        'DtpFechaInicio
        '
        Me.DtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaInicio.Location = New System.Drawing.Point(83, 22)
        Me.DtpFechaInicio.Name = "DtpFechaInicio"
        Me.DtpFechaInicio.Size = New System.Drawing.Size(98, 20)
        Me.DtpFechaInicio.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha Final :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Inicio :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(70, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Folio de Recepción :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(70, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Lote de Engorda :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(70, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Introductor :"
        '
        'txtFolioRec
        '
        Me.txtFolioRec.Location = New System.Drawing.Point(181, 43)
        Me.txtFolioRec.MaxLength = 10
        Me.txtFolioRec.Name = "txtFolioRec"
        Me.txtFolioRec.Size = New System.Drawing.Size(100, 20)
        Me.txtFolioRec.TabIndex = 53
        '
        'txtLoteEngorda
        '
        Me.txtLoteEngorda.Location = New System.Drawing.Point(181, 71)
        Me.txtLoteEngorda.MaxLength = 10
        Me.txtLoteEngorda.Name = "txtLoteEngorda"
        Me.txtLoteEngorda.Size = New System.Drawing.Size(100, 20)
        Me.txtLoteEngorda.TabIndex = 54
        '
        'CmbIntroductor
        '
        Me.CmbIntroductor.FormattingEnabled = True
        Me.CmbIntroductor.Location = New System.Drawing.Point(181, 99)
        Me.CmbIntroductor.Name = "CmbIntroductor"
        Me.CmbIntroductor.Size = New System.Drawing.Size(250, 21)
        Me.CmbIntroductor.TabIndex = 55
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RdbTodas)
        Me.GroupBox2.Controls.Add(Me.RdbCanceladas)
        Me.GroupBox2.Controls.Add(Me.RdbVigentes)
        Me.GroupBox2.Location = New System.Drawing.Point(649, 37)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(133, 83)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estatus"
        '
        'RdbTodas
        '
        Me.RdbTodas.AutoSize = True
        Me.RdbTodas.Location = New System.Drawing.Point(17, 62)
        Me.RdbTodas.Name = "RdbTodas"
        Me.RdbTodas.Size = New System.Drawing.Size(62, 17)
        Me.RdbTodas.TabIndex = 2
        Me.RdbTodas.TabStop = True
        Me.RdbTodas.Text = "TODAS"
        Me.RdbTodas.UseVisualStyleBackColor = True
        '
        'RdbCanceladas
        '
        Me.RdbCanceladas.AutoSize = True
        Me.RdbCanceladas.Location = New System.Drawing.Point(17, 40)
        Me.RdbCanceladas.Name = "RdbCanceladas"
        Me.RdbCanceladas.Size = New System.Drawing.Size(96, 17)
        Me.RdbCanceladas.TabIndex = 1
        Me.RdbCanceladas.TabStop = True
        Me.RdbCanceladas.Text = "CANCELADAS"
        Me.RdbCanceladas.UseVisualStyleBackColor = True
        '
        'RdbVigentes
        '
        Me.RdbVigentes.AutoSize = True
        Me.RdbVigentes.Location = New System.Drawing.Point(17, 17)
        Me.RdbVigentes.Name = "RdbVigentes"
        Me.RdbVigentes.Size = New System.Drawing.Size(79, 17)
        Me.RdbVigentes.TabIndex = 0
        Me.RdbVigentes.TabStop = True
        Me.RdbVigentes.Text = "VIGENTES"
        Me.RdbVigentes.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DgvRecepcionGanado)
        Me.GroupBox3.Location = New System.Drawing.Point(73, 147)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(718, 229)
        Me.GroupBox3.TabIndex = 57
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Recepciones Registradas"
        '
        'DgvRecepcionGanado
        '
        Me.DgvRecepcionGanado.AllowUserToAddRows = False
        Me.DgvRecepcionGanado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRecepcionGanado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LoteRecepcion, Me.FechaRecepcion, Me.Productor, Me.Nombre, Me.LoteEngorda, Me.CantCabezas, Me.KilosEnviados, Me.KilosRecibidos, Me.Conductor, Me.Unidad, Me.Placas, Me.Observaciones, Me.Estatus})
        Me.DgvRecepcionGanado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvRecepcionGanado.Location = New System.Drawing.Point(3, 16)
        Me.DgvRecepcionGanado.Name = "DgvRecepcionGanado"
        Me.DgvRecepcionGanado.ReadOnly = True
        Me.DgvRecepcionGanado.RowHeadersVisible = False
        Me.DgvRecepcionGanado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvRecepcionGanado.Size = New System.Drawing.Size(712, 210)
        Me.DgvRecepcionGanado.TabIndex = 18
        '
        'LoteRecepcion
        '
        Me.LoteRecepcion.DataPropertyName = "LoteRecepcion"
        Me.LoteRecepcion.HeaderText = "Lote de Recepcion"
        Me.LoteRecepcion.Name = "LoteRecepcion"
        Me.LoteRecepcion.ReadOnly = True
        Me.LoteRecepcion.Width = 130
        '
        'FechaRecepcion
        '
        Me.FechaRecepcion.DataPropertyName = "FechaRecepcion"
        DataGridViewCellStyle1.Format = "dd/MMM/yyyy"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.FechaRecepcion.DefaultCellStyle = DataGridViewCellStyle1
        Me.FechaRecepcion.HeaderText = "Fecha Recepcion"
        Me.FechaRecepcion.Name = "FechaRecepcion"
        Me.FechaRecepcion.ReadOnly = True
        Me.FechaRecepcion.Width = 130
        '
        'Productor
        '
        Me.Productor.DataPropertyName = "IdCliente"
        Me.Productor.HeaderText = "Introductor"
        Me.Productor.Name = "Productor"
        Me.Productor.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "NombreIntroductor"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 200
        '
        'LoteEngorda
        '
        Me.LoteEngorda.DataPropertyName = "LoteEngorda"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.LoteEngorda.DefaultCellStyle = DataGridViewCellStyle2
        Me.LoteEngorda.HeaderText = "Lote de Engorda"
        Me.LoteEngorda.Name = "LoteEngorda"
        Me.LoteEngorda.ReadOnly = True
        Me.LoteEngorda.Width = 130
        '
        'CantCabezas
        '
        Me.CantCabezas.DataPropertyName = "CantCabezas"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.CantCabezas.DefaultCellStyle = DataGridViewCellStyle3
        Me.CantCabezas.HeaderText = "Cabezas"
        Me.CantCabezas.Name = "CantCabezas"
        Me.CantCabezas.ReadOnly = True
        Me.CantCabezas.Width = 70
        '
        'KilosEnviados
        '
        Me.KilosEnviados.DataPropertyName = "KilosEnviados"
        Me.KilosEnviados.HeaderText = "Kgrs. Enviados"
        Me.KilosEnviados.Name = "KilosEnviados"
        Me.KilosEnviados.ReadOnly = True
        '
        'KilosRecibidos
        '
        Me.KilosRecibidos.DataPropertyName = "KilosRecibidos"
        Me.KilosRecibidos.HeaderText = "Kgrs. Recibidos"
        Me.KilosRecibidos.Name = "KilosRecibidos"
        Me.KilosRecibidos.ReadOnly = True
        '
        'Conductor
        '
        Me.Conductor.DataPropertyName = "Conductor"
        Me.Conductor.HeaderText = "Conductor"
        Me.Conductor.Name = "Conductor"
        Me.Conductor.ReadOnly = True
        '
        'Unidad
        '
        Me.Unidad.DataPropertyName = "Unidad"
        Me.Unidad.HeaderText = "Unidad"
        Me.Unidad.Name = "Unidad"
        Me.Unidad.ReadOnly = True
        '
        'Placas
        '
        Me.Placas.DataPropertyName = "Placas"
        Me.Placas.HeaderText = "Placas"
        Me.Placas.Name = "Placas"
        Me.Placas.ReadOnly = True
        '
        'Observaciones
        '
        Me.Observaciones.DataPropertyName = "Observaciones"
        Me.Observaciones.HeaderText = "Observaciones"
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.ReadOnly = True
        '
        'Estatus
        '
        Me.Estatus.DataPropertyName = "Estatus"
        Me.Estatus.HeaderText = "Estatus"
        Me.Estatus.Name = "Estatus"
        Me.Estatus.ReadOnly = True
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
        Me.mtb.MostrarBuscar = True
        Me.mtb.MostrarCancelar = False
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = False
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 388)
        Me.mtb.TabIndex = 58
        '
        '_660ReporteRecepcionGanado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 388)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.CmbIntroductor)
        Me.Controls.Add(Me.txtLoteEngorda)
        Me.Controls.Add(Me.txtFolioRec)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label17)
        Me.Name = "_660ReporteRecepcionGanado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Recepción de Ganado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DgvRecepcionGanado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFolioRec As System.Windows.Forms.TextBox
    Friend WithEvents txtLoteEngorda As System.Windows.Forms.TextBox
    Friend WithEvents CmbIntroductor As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RdbTodas As System.Windows.Forms.RadioButton
    Friend WithEvents RdbCanceladas As System.Windows.Forms.RadioButton
    Friend WithEvents RdbVigentes As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DgvRecepcionGanado As System.Windows.Forms.DataGridView
    Friend WithEvents LoteRecepcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaRecepcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Productor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoteEngorda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantCabezas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosEnviados As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosRecibidos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Conductor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Placas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Observaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
End Class
