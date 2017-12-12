<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusquedaSalidaDeAlmacenXMaterialesFrm
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
        Me.lblFolio = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.DtpFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.lblFechaFinal = New System.Windows.Forms.Label
        Me.lblFechaInicial = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RbtnTodos = New System.Windows.Forms.RadioButton
        Me.RbtnInactivos = New System.Windows.Forms.RadioButton
        Me.RbtnActivo = New System.Windows.Forms.RadioButton
        Me.txtFolio = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.mtb = New MiToolBar.miToolBar
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.DgvMovimientos = New System.Windows.Forms.DataGridView
        Me.FolioMovimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaMovimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AlmacenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostoTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MovAlmCol = New ClasesNegocio.MovAlmacenCollecionClass
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgvMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFolio
        '
        Me.lblFolio.AutoSize = True
        Me.lblFolio.Location = New System.Drawing.Point(69, 82)
        Me.lblFolio.Name = "lblFolio"
        Me.lblFolio.Size = New System.Drawing.Size(32, 13)
        Me.lblFolio.TabIndex = 53
        Me.lblFolio.Text = "Folio:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpFechaFinal)
        Me.GroupBox1.Controls.Add(Me.DtpFechaInicio)
        Me.GroupBox1.Controls.Add(Me.lblFechaFinal)
        Me.GroupBox1.Controls.Add(Me.lblFechaInicial)
        Me.GroupBox1.Location = New System.Drawing.Point(238, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(215, 87)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fechas"
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(91, 55)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(86, 20)
        Me.dtpFechaFinal.TabIndex = 4
        '
        'DtpFechaInicio
        '
        Me.DtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaInicio.Location = New System.Drawing.Point(91, 27)
        Me.DtpFechaInicio.Name = "DtpFechaInicio"
        Me.DtpFechaInicio.Size = New System.Drawing.Size(86, 20)
        Me.DtpFechaInicio.TabIndex = 3
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.AutoSize = True
        Me.lblFechaFinal.Location = New System.Drawing.Point(15, 59)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(65, 13)
        Me.lblFechaFinal.TabIndex = 2
        Me.lblFechaFinal.Text = "Fecha Final:"
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.AutoSize = True
        Me.lblFechaInicial.Location = New System.Drawing.Point(15, 31)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(70, 13)
        Me.lblFechaInicial.TabIndex = 1
        Me.lblFechaInicial.Text = "Fecha Inicial:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RbtnTodos)
        Me.GroupBox2.Controls.Add(Me.RbtnInactivos)
        Me.GroupBox2.Controls.Add(Me.RbtnActivo)
        Me.GroupBox2.Location = New System.Drawing.Point(459, 42)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(142, 87)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estatus"
        '
        'RbtnTodos
        '
        Me.RbtnTodos.AutoSize = True
        Me.RbtnTodos.Location = New System.Drawing.Point(23, 19)
        Me.RbtnTodos.Name = "RbtnTodos"
        Me.RbtnTodos.Size = New System.Drawing.Size(63, 17)
        Me.RbtnTodos.TabIndex = 2
        Me.RbtnTodos.TabStop = True
        Me.RbtnTodos.Text = "TODOS"
        Me.RbtnTodos.UseVisualStyleBackColor = True
        '
        'RbtnInactivos
        '
        Me.RbtnInactivos.AutoSize = True
        Me.RbtnInactivos.Location = New System.Drawing.Point(23, 61)
        Me.RbtnInactivos.Name = "RbtnInactivos"
        Me.RbtnInactivos.Size = New System.Drawing.Size(82, 17)
        Me.RbtnInactivos.TabIndex = 1
        Me.RbtnInactivos.TabStop = True
        Me.RbtnInactivos.Text = "INACTIVOS"
        Me.RbtnInactivos.UseVisualStyleBackColor = True
        '
        'RbtnActivo
        '
        Me.RbtnActivo.AutoSize = True
        Me.RbtnActivo.Location = New System.Drawing.Point(23, 40)
        Me.RbtnActivo.Name = "RbtnActivo"
        Me.RbtnActivo.Size = New System.Drawing.Size(71, 17)
        Me.RbtnActivo.TabIndex = 0
        Me.RbtnActivo.TabStop = True
        Me.RbtnActivo.Text = "ACTIVOS"
        Me.RbtnActivo.UseVisualStyleBackColor = True
        '
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(72, 98)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(144, 20)
        Me.txtFolio.TabIndex = 57
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DgvMovimientos)
        Me.GroupBox3.Location = New System.Drawing.Point(59, 150)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(611, 253)
        Me.GroupBox3.TabIndex = 59
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Movimientos de Salidas de Almacén por Materiales Registrados"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(482, 409)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 60
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(576, 409)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 61
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
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
        Me.mtb.ImageButtonSize = MiToolBar.miToolBar.ImageButtonSizeEnum.de32
        Me.mtb.Location = New System.Drawing.Point(0, 0)
        Me.mtb.MostrarBorrar = False
        Me.mtb.MostrarBuscar = True
        Me.mtb.MostrarCancelar = False
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = False
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = False
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 436)
        Me.mtb.TabIndex = 62
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(50, 0)
        Me.lblTitulo.MaximumSize = New System.Drawing.Size(1600, 900)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(694, 29)
        Me.lblTitulo.TabIndex = 63
        Me.lblTitulo.Text = "BÚSQUEDA DE SALIDAS DE ALMACÉN POR MATERIALES"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DgvMovimientos
        '
        Me.DgvMovimientos.AllowUserToAddRows = False
        Me.DgvMovimientos.AllowUserToDeleteRows = False
        Me.DgvMovimientos.AutoGenerateColumns = False
        Me.DgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMovimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FolioMovimientoDataGridViewTextBoxColumn, Me.FechaMovimientoDataGridViewTextBoxColumn, Me.AlmacenDataGridViewTextBoxColumn, Me.CostoTotalDataGridViewTextBoxColumn, Me.EstatusDataGridViewTextBoxColumn})
        Me.DgvMovimientos.DataSource = Me.MovAlmCol
        Me.DgvMovimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvMovimientos.Location = New System.Drawing.Point(3, 16)
        Me.DgvMovimientos.Name = "DgvMovimientos"
        Me.DgvMovimientos.ReadOnly = True
        Me.DgvMovimientos.RowHeadersVisible = False
        Me.DgvMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvMovimientos.Size = New System.Drawing.Size(605, 234)
        Me.DgvMovimientos.TabIndex = 0
        '
        'FolioMovimientoDataGridViewTextBoxColumn
        '
        Me.FolioMovimientoDataGridViewTextBoxColumn.DataPropertyName = "FolioMovimiento"
        Me.FolioMovimientoDataGridViewTextBoxColumn.HeaderText = "Folio"
        Me.FolioMovimientoDataGridViewTextBoxColumn.Name = "FolioMovimientoDataGridViewTextBoxColumn"
        Me.FolioMovimientoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FolioMovimientoDataGridViewTextBoxColumn.Width = 110
        '
        'FechaMovimientoDataGridViewTextBoxColumn
        '
        Me.FechaMovimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaMovimiento"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.FechaMovimientoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.FechaMovimientoDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaMovimientoDataGridViewTextBoxColumn.Name = "FechaMovimientoDataGridViewTextBoxColumn"
        Me.FechaMovimientoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaMovimientoDataGridViewTextBoxColumn.Width = 110
        '
        'AlmacenDataGridViewTextBoxColumn
        '
        Me.AlmacenDataGridViewTextBoxColumn.DataPropertyName = "Almacen"
        Me.AlmacenDataGridViewTextBoxColumn.HeaderText = "Almacen"
        Me.AlmacenDataGridViewTextBoxColumn.Name = "AlmacenDataGridViewTextBoxColumn"
        Me.AlmacenDataGridViewTextBoxColumn.ReadOnly = True
        Me.AlmacenDataGridViewTextBoxColumn.Width = 150
        '
        'CostoTotalDataGridViewTextBoxColumn
        '
        Me.CostoTotalDataGridViewTextBoxColumn.DataPropertyName = "CostoTotal"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.CostoTotalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.CostoTotalDataGridViewTextBoxColumn.HeaderText = "CostoTotal"
        Me.CostoTotalDataGridViewTextBoxColumn.Name = "CostoTotalDataGridViewTextBoxColumn"
        Me.CostoTotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstatusDataGridViewTextBoxColumn
        '
        Me.EstatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.HeaderText = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.Name = "EstatusDataGridViewTextBoxColumn"
        Me.EstatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MovAlmCol
        '
        Me.MovAlmCol.AllowEdit = True
        Me.MovAlmCol.AllowNew = True
        Me.MovAlmCol.AllowRemove = True
        Me.MovAlmCol.Name = ""
        Me.MovAlmCol.RaiseListChangedEvents = True
        '
        'BusquedaSalidaDeAlmacenXMaterialesFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 436)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblFolio)
        Me.Name = "BusquedaSalidaDeAlmacenXMaterialesFrm"
        Me.Text = "Búsqueda de Salida de Almacén Por Materiales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DgvMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFolio As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblFechaFinal As System.Windows.Forms.Label
    Friend WithEvents lblFechaInicial As System.Windows.Forms.Label
    Friend WithEvents DtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents RbtnTodos As System.Windows.Forms.RadioButton
    Friend WithEvents RbtnInactivos As System.Windows.Forms.RadioButton
    Friend WithEvents RbtnActivo As System.Windows.Forms.RadioButton
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DgvMovimientos As System.Windows.Forms.DataGridView
    Friend WithEvents MovAlmCol As ClasesNegocio.MovAlmacenCollecionClass
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents mtb As MiToolBar.miToolBar
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents FolioMovimientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaMovimientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlmacenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoTotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
