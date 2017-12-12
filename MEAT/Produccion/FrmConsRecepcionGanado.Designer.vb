<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsRecepcionGanado
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DgvRecepcionGanado = New System.Windows.Forms.DataGridView
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtIntroductor = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DtpFechaFin = New System.Windows.Forms.DateTimePicker
        Me.DtpFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnBuscar = New System.Windows.Forms.Button
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.chkFiltrarFecha = New System.Windows.Forms.CheckBox
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LoteRecepcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaRecepcion = New System.Windows.Forms.DataGridViewTextBoxColumn
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
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.DgvRecepcionGanado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvRecepcionGanado
        '
        Me.DgvRecepcionGanado.AllowUserToAddRows = False
        Me.DgvRecepcionGanado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvRecepcionGanado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRecepcionGanado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LoteRecepcion, Me.FechaRecepcion, Me.Nombre, Me.LoteEngorda, Me.CantCabezas, Me.KilosEnviados, Me.KilosRecibidos, Me.Conductor, Me.Unidad, Me.Placas, Me.Observaciones, Me.Estatus})
        Me.DgvRecepcionGanado.Location = New System.Drawing.Point(54, 152)
        Me.DgvRecepcionGanado.Name = "DgvRecepcionGanado"
        Me.DgvRecepcionGanado.ReadOnly = True
        Me.DgvRecepcionGanado.RowHeadersVisible = False
        Me.DgvRecepcionGanado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvRecepcionGanado.Size = New System.Drawing.Size(898, 474)
        Me.DgvRecepcionGanado.TabIndex = 17
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(914, 32)
        Me.Label17.TabIndex = 48
        Me.Label17.Text = "Consulta de Recepción de Ganado"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIntroductor
        '
        Me.txtIntroductor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIntroductor.Location = New System.Drawing.Point(369, 126)
        Me.txtIntroductor.MaxLength = 50
        Me.txtIntroductor.Name = "txtIntroductor"
        Me.txtIntroductor.Size = New System.Drawing.Size(346, 20)
        Me.txtIntroductor.TabIndex = 49
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DtpFechaFin)
        Me.GroupBox1.Controls.Add(Me.DtpFechaInicio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(56, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 88)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rango de Fechas"
        '
        'DtpFechaFin
        '
        Me.DtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaFin.Location = New System.Drawing.Point(94, 53)
        Me.DtpFechaFin.Name = "DtpFechaFin"
        Me.DtpFechaFin.Size = New System.Drawing.Size(90, 20)
        Me.DtpFechaFin.TabIndex = 3
        '
        'DtpFechaInicio
        '
        Me.DtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaInicio.Location = New System.Drawing.Point(94, 23)
        Me.DtpFechaInicio.Name = "DtpFechaInicio"
        Me.DtpFechaInicio.Size = New System.Drawing.Size(90, 20)
        Me.DtpFechaInicio.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha Final :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Inicio :"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(679, 35)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 51
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        Me.BtnBuscar.Visible = False
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
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 638)
        Me.mtb.TabIndex = 52
        '
        'chkFiltrarFecha
        '
        Me.chkFiltrarFecha.AutoSize = True
        Me.chkFiltrarFecha.Location = New System.Drawing.Point(54, 35)
        Me.chkFiltrarFecha.Name = "chkFiltrarFecha"
        Me.chkFiltrarFecha.Size = New System.Drawing.Size(115, 17)
        Me.chkFiltrarFecha.TabIndex = 53
        Me.chkFiltrarFecha.Text = "¿Filtrar Por Fecha?"
        Me.chkFiltrarFecha.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "LoteRecepcion"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Lote de Recepcion"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 130
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FechaRecepcion"
        DataGridViewCellStyle13.Format = "dd/MMM/yyyy"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha Recepcion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 130
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IdCliente"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Introductor"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NombreIntroductor"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 200
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "LoteEngorda"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn5.HeaderText = "Lote de Engorda"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 130
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CantCabezas"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cabezas"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 70
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "KilosEnviados"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Kgrs. Enviados"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "KilosRecibidos"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Kgrs. Recibidos"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Conductor"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Conductor"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Unidad"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Unidad"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Placas"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Placas"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Observaciones"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Estatus"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Estatus"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
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
        DataGridViewCellStyle16.Format = "dd/MMM/yyyy"
        DataGridViewCellStyle16.NullValue = Nothing
        Me.FechaRecepcion.DefaultCellStyle = DataGridViewCellStyle16
        Me.FechaRecepcion.HeaderText = "Fecha Recepcion"
        Me.FechaRecepcion.Name = "FechaRecepcion"
        Me.FechaRecepcion.ReadOnly = True
        Me.FechaRecepcion.Width = 130
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "NombreIntroductor"
        Me.Nombre.HeaderText = "Nombre Introductor"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 200
        '
        'LoteEngorda
        '
        Me.LoteEngorda.DataPropertyName = "LoteEngorda"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.LoteEngorda.DefaultCellStyle = DataGridViewCellStyle17
        Me.LoteEngorda.HeaderText = "Lote de Engorda"
        Me.LoteEngorda.Name = "LoteEngorda"
        Me.LoteEngorda.ReadOnly = True
        Me.LoteEngorda.Width = 130
        '
        'CantCabezas
        '
        Me.CantCabezas.DataPropertyName = "CantCabezas"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.CantCabezas.DefaultCellStyle = DataGridViewCellStyle18
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
        Me.Estatus.DataPropertyName = "EstatusStr"
        Me.Estatus.HeaderText = "Estatus"
        Me.Estatus.Name = "Estatus"
        Me.Estatus.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(262, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Nombre Introductor:"
        '
        'FrmConsRecepcionGanado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 638)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkFiltrarFecha)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtIntroductor)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.DgvRecepcionGanado)
        Me.Controls.Add(Me.mtb)
        Me.Name = "FrmConsRecepcionGanado"
        Me.Text = "Consulta de Recepciones de Ganado"
        CType(Me.DgvRecepcionGanado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgvRecepcionGanado As System.Windows.Forms.DataGridView
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtIntroductor As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents chkFiltrarFecha As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoteRecepcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaRecepcion As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
