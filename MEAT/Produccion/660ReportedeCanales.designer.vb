<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _660ReportedeCanales
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
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dgvDetalleCanales = New System.Windows.Forms.DataGridView
        Me.LoteSacrificio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FolioCanal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Productor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Estatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LoteCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Embarque = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RbtnEmbarcados = New System.Windows.Forms.RadioButton
        Me.RbtnTodos = New System.Windows.Forms.RadioButton
        Me.RbtnVigentes = New System.Windows.Forms.RadioButton
        Me.txtFolioSacrificio = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DtpFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.DtpFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.dgvRegistroCanales = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaSacrificio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotaldeCanales = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CanalesEnCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KilosEnCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CanalesEmbarcados = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KilosEnEmabrque = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RbtnACorte = New System.Windows.Forms.RadioButton
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvDetalleCanales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvRegistroCanales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.mtb.Size = New System.Drawing.Size(50, 529)
        Me.mtb.TabIndex = 60
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(748, 32)
        Me.Label17.TabIndex = 59
        Me.Label17.Text = "Reporte de Canales"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvDetalleCanales)
        Me.GroupBox3.Location = New System.Drawing.Point(56, 315)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(718, 202)
        Me.GroupBox3.TabIndex = 67
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalle de Canales"
        '
        'dgvDetalleCanales
        '
        Me.dgvDetalleCanales.AllowUserToAddRows = False
        Me.dgvDetalleCanales.AllowUserToDeleteRows = False
        Me.dgvDetalleCanales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleCanales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LoteSacrificio, Me.FolioCanal, Me.Productor, Me.Estatus, Me.LoteCorte, Me.Embarque})
        Me.dgvDetalleCanales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDetalleCanales.Location = New System.Drawing.Point(3, 16)
        Me.dgvDetalleCanales.Name = "dgvDetalleCanales"
        Me.dgvDetalleCanales.ReadOnly = True
        Me.dgvDetalleCanales.RowHeadersVisible = False
        Me.dgvDetalleCanales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalleCanales.Size = New System.Drawing.Size(712, 183)
        Me.dgvDetalleCanales.TabIndex = 18
        '
        'LoteSacrificio
        '
        Me.LoteSacrificio.HeaderText = "Lote de Sacrificio"
        Me.LoteSacrificio.Name = "LoteSacrificio"
        Me.LoteSacrificio.ReadOnly = True
        Me.LoteSacrificio.Width = 130
        '
        'FolioCanal
        '
        DataGridViewCellStyle1.Format = "dd/MMM/yyyy"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.FolioCanal.DefaultCellStyle = DataGridViewCellStyle1
        Me.FolioCanal.HeaderText = "Folio Canal"
        Me.FolioCanal.Name = "FolioCanal"
        Me.FolioCanal.ReadOnly = True
        Me.FolioCanal.Width = 130
        '
        'Productor
        '
        Me.Productor.HeaderText = "Kilos"
        Me.Productor.Name = "Productor"
        Me.Productor.ReadOnly = True
        '
        'Estatus
        '
        Me.Estatus.DataPropertyName = "Estatus"
        Me.Estatus.HeaderText = "Estatus"
        Me.Estatus.Name = "Estatus"
        Me.Estatus.ReadOnly = True
        '
        'LoteCorte
        '
        Me.LoteCorte.HeaderText = "Lote Corte"
        Me.LoteCorte.Name = "LoteCorte"
        Me.LoteCorte.ReadOnly = True
        '
        'Embarque
        '
        Me.Embarque.HeaderText = "Folio Embarque"
        Me.Embarque.Name = "Embarque"
        Me.Embarque.ReadOnly = True
        Me.Embarque.Width = 120
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RbtnACorte)
        Me.GroupBox2.Controls.Add(Me.RbtnEmbarcados)
        Me.GroupBox2.Controls.Add(Me.RbtnTodos)
        Me.GroupBox2.Controls.Add(Me.RbtnVigentes)
        Me.GroupBox2.Location = New System.Drawing.Point(534, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(228, 83)
        Me.GroupBox2.TabIndex = 66
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estatus"
        '
        'RbtnEmbarcados
        '
        Me.RbtnEmbarcados.AutoSize = True
        Me.RbtnEmbarcados.Location = New System.Drawing.Point(102, 26)
        Me.RbtnEmbarcados.Name = "RbtnEmbarcados"
        Me.RbtnEmbarcados.Size = New System.Drawing.Size(100, 17)
        Me.RbtnEmbarcados.TabIndex = 2
        Me.RbtnEmbarcados.TabStop = True
        Me.RbtnEmbarcados.Text = "EMBARCADOS"
        Me.RbtnEmbarcados.UseVisualStyleBackColor = True
        '
        'RbtnTodos
        '
        Me.RbtnTodos.AutoSize = True
        Me.RbtnTodos.Location = New System.Drawing.Point(17, 53)
        Me.RbtnTodos.Name = "RbtnTodos"
        Me.RbtnTodos.Size = New System.Drawing.Size(63, 17)
        Me.RbtnTodos.TabIndex = 1
        Me.RbtnTodos.TabStop = True
        Me.RbtnTodos.Text = "TODOS"
        Me.RbtnTodos.UseVisualStyleBackColor = True
        '
        'RbtnVigentes
        '
        Me.RbtnVigentes.AutoSize = True
        Me.RbtnVigentes.Location = New System.Drawing.Point(17, 24)
        Me.RbtnVigentes.Name = "RbtnVigentes"
        Me.RbtnVigentes.Size = New System.Drawing.Size(79, 17)
        Me.RbtnVigentes.TabIndex = 0
        Me.RbtnVigentes.TabStop = True
        Me.RbtnVigentes.Text = "VIGENTES"
        Me.RbtnVigentes.UseVisualStyleBackColor = True
        '
        'txtFolioSacrificio
        '
        Me.txtFolioSacrificio.Location = New System.Drawing.Point(162, 48)
        Me.txtFolioSacrificio.MaxLength = 10
        Me.txtFolioSacrificio.Name = "txtFolioSacrificio"
        Me.txtFolioSacrificio.Size = New System.Drawing.Size(100, 20)
        Me.txtFolioSacrificio.TabIndex = 64
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Folio de Sacrificio :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DtpFechaFinal)
        Me.GroupBox1.Controls.Add(Me.DtpFechaInicio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(298, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(194, 83)
        Me.GroupBox1.TabIndex = 61
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
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgvRegistroCanales)
        Me.GroupBox4.Location = New System.Drawing.Point(59, 140)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(718, 169)
        Me.GroupBox4.TabIndex = 68
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Registro de Canales"
        '
        'dgvRegistroCanales
        '
        Me.dgvRegistroCanales.AllowUserToAddRows = False
        Me.dgvRegistroCanales.AllowUserToDeleteRows = False
        Me.dgvRegistroCanales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegistroCanales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.FechaSacrificio, Me.TotaldeCanales, Me.DataGridViewTextBoxColumn3, Me.CanalesEnCorte, Me.KilosEnCorte, Me.CanalesEmbarcados, Me.KilosEnEmabrque, Me.DataGridViewTextBoxColumn4})
        Me.dgvRegistroCanales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRegistroCanales.Location = New System.Drawing.Point(3, 16)
        Me.dgvRegistroCanales.Name = "dgvRegistroCanales"
        Me.dgvRegistroCanales.ReadOnly = True
        Me.dgvRegistroCanales.RowHeadersVisible = False
        Me.dgvRegistroCanales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRegistroCanales.Size = New System.Drawing.Size(712, 150)
        Me.dgvRegistroCanales.TabIndex = 18
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "FolioSacrificio"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Lote de Sacrificio"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 130
        '
        'FechaSacrificio
        '
        Me.FechaSacrificio.DataPropertyName = "FechaSacrificio"
        Me.FechaSacrificio.HeaderText = "FechaSacrificio"
        Me.FechaSacrificio.Name = "FechaSacrificio"
        Me.FechaSacrificio.ReadOnly = True
        '
        'TotaldeCanales
        '
        Me.TotaldeCanales.DataPropertyName = "CantCanales"
        DataGridViewCellStyle2.Format = "dd/MMM/yyyy"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.TotaldeCanales.DefaultCellStyle = DataGridViewCellStyle2
        Me.TotaldeCanales.HeaderText = "Total de Canales"
        Me.TotaldeCanales.Name = "TotaldeCanales"
        Me.TotaldeCanales.ReadOnly = True
        Me.TotaldeCanales.Width = 130
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "KgrsBascula"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Kilos"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'CanalesEnCorte
        '
        Me.CanalesEnCorte.DataPropertyName = "CanalesenCorte"
        Me.CanalesEnCorte.HeaderText = "Canales En Corte"
        Me.CanalesEnCorte.Name = "CanalesEnCorte"
        Me.CanalesEnCorte.ReadOnly = True
        '
        'KilosEnCorte
        '
        Me.KilosEnCorte.DataPropertyName = "KilosEnCorte"
        Me.KilosEnCorte.HeaderText = "Kilos En Corte"
        Me.KilosEnCorte.Name = "KilosEnCorte"
        Me.KilosEnCorte.ReadOnly = True
        '
        'CanalesEmbarcados
        '
        Me.CanalesEmbarcados.DataPropertyName = "CanalesEnEmbarque"
        Me.CanalesEmbarcados.HeaderText = "Canales Embarcados"
        Me.CanalesEmbarcados.Name = "CanalesEmbarcados"
        Me.CanalesEmbarcados.ReadOnly = True
        '
        'KilosEnEmabrque
        '
        Me.KilosEnEmabrque.DataPropertyName = "KilosEnEmbarque"
        Me.KilosEnEmabrque.HeaderText = "KilosEnEmbarque"
        Me.KilosEnEmabrque.Name = "KilosEnEmabrque"
        Me.KilosEnEmabrque.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Estatus"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Estatus"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'RbtnACorte
        '
        Me.RbtnACorte.AutoSize = True
        Me.RbtnACorte.Location = New System.Drawing.Point(102, 54)
        Me.RbtnACorte.Name = "RbtnACorte"
        Me.RbtnACorte.Size = New System.Drawing.Size(72, 17)
        Me.RbtnACorte.TabIndex = 3
        Me.RbtnACorte.TabStop = True
        Me.RbtnACorte.Text = "A CORTE"
        Me.RbtnACorte.UseVisualStyleBackColor = True
        '
        '_660ReportedeCanales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 529)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtFolioSacrificio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.Name = "_660ReportedeCanales"
        Me.Text = "Reporte de Canales"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvDetalleCanales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvRegistroCanales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFolioSacrificio As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvRegistroCanales As System.Windows.Forms.DataGridView
    Friend WithEvents dgvDetalleCanales As System.Windows.Forms.DataGridView
    Friend WithEvents LoteSacrificio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FolioCanal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Productor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoteCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Embarque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaSacrificio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotaldeCanales As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CanalesEnCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosEnCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CanalesEmbarcados As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosEnEmabrque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RbtnEmbarcados As System.Windows.Forms.RadioButton
    Friend WithEvents RbtnTodos As System.Windows.Forms.RadioButton
    Friend WithEvents RbtnVigentes As System.Windows.Forms.RadioButton
    Friend WithEvents RbtnACorte As System.Windows.Forms.RadioButton
End Class
