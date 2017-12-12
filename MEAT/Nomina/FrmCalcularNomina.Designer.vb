<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCalcularNomina
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
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.lblFolio = New System.Windows.Forms.Label
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.lblFecha = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtFolio = New System.Windows.Forms.TextBox
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.gpbEmpleados = New System.Windows.Forms.GroupBox
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView
        Me.EmpleadoCol = New ClasesNegocio.EmpleadosCollectionClass
        Me.txtSmRegionA = New System.Windows.Forms.TextBox
        Me.txtSmRegionC = New System.Windows.Forms.TextBox
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.txtMesComercial = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmNombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmDiasTrabajados = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmHRD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmHRT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmComisiones = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPrestamos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmSalario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFactor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gpbEmpleados.SuspendLayout()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.mtb.MostrarBorrar = True
        Me.mtb.MostrarBuscar = True
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 490)
        Me.mtb.TabIndex = 51
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(50, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(855, 32)
        Me.lblTitulo.TabIndex = 52
        Me.lblTitulo.Text = "Calcular Nómina"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFolio
        '
        Me.lblFolio.AutoSize = True
        Me.lblFolio.Location = New System.Drawing.Point(70, 85)
        Me.lblFolio.Name = "lblFolio"
        Me.lblFolio.Size = New System.Drawing.Size(32, 13)
        Me.lblFolio.TabIndex = 53
        Me.lblFolio.Text = "Folio:"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(70, 112)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.lblDescripcion.TabIndex = 54
        Me.lblDescripcion.Text = "Descripción:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(274, 85)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(40, 13)
        Me.lblFecha.TabIndex = 55
        Me.lblFecha.Text = "Fecha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(428, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "SM Región A:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(428, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "SM Región C:"
        '
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(144, 82)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.ReadOnly = True
        Me.txtFolio.Size = New System.Drawing.Size(113, 20)
        Me.txtFolio.TabIndex = 0
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(322, 81)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(87, 20)
        Me.dtpFecha.TabIndex = 2
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(144, 109)
        Me.txtDescripcion.MaxLength = 60
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(265, 20)
        Me.txtDescripcion.TabIndex = 1
        '
        'gpbEmpleados
        '
        Me.gpbEmpleados.Controls.Add(Me.dgvEmpleados)
        Me.gpbEmpleados.Location = New System.Drawing.Point(73, 155)
        Me.gpbEmpleados.Name = "gpbEmpleados"
        Me.gpbEmpleados.Size = New System.Drawing.Size(805, 323)
        Me.gpbEmpleados.TabIndex = 61
        Me.gpbEmpleados.TabStop = False
        Me.gpbEmpleados.Text = "Empleados"
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.AllowUserToAddRows = False
        Me.dgvEmpleados.AllowUserToDeleteRows = False
        Me.dgvEmpleados.AutoGenerateColumns = False
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmCodigo, Me.clmNombre, Me.clmDiasTrabajados, Me.clmHRD, Me.clmHRT, Me.clmComisiones, Me.clmPrestamos, Me.clmSalario, Me.clmFactor})
        Me.dgvEmpleados.DataSource = Me.EmpleadoCol
        Me.dgvEmpleados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEmpleados.Location = New System.Drawing.Point(3, 16)
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.RowHeadersVisible = False
        Me.dgvEmpleados.Size = New System.Drawing.Size(799, 304)
        Me.dgvEmpleados.TabIndex = 0
        '
        'EmpleadoCol
        '
        Me.EmpleadoCol.AllowEdit = True
        Me.EmpleadoCol.AllowNew = True
        Me.EmpleadoCol.AllowRemove = True
        Me.EmpleadoCol.MaximoElementosSeleccionados = 1
        Me.EmpleadoCol.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.EmpleadoCol.mostrar = ClasesNegocio.MostrarEnum.CLIENTES
        Me.EmpleadoCol.MostrarAlertas = False
        Me.EmpleadoCol.Name = Nothing
        Me.EmpleadoCol.RaiseListChangedEvents = True
        '
        'txtSmRegionA
        '
        Me.txtSmRegionA.Location = New System.Drawing.Point(507, 78)
        Me.txtSmRegionA.Name = "txtSmRegionA"
        Me.txtSmRegionA.Size = New System.Drawing.Size(100, 20)
        Me.txtSmRegionA.TabIndex = 3
        '
        'txtSmRegionC
        '
        Me.txtSmRegionC.Location = New System.Drawing.Point(507, 104)
        Me.txtSmRegionC.Name = "txtSmRegionC"
        Me.txtSmRegionC.Size = New System.Drawing.Size(100, 20)
        Me.txtSmRegionC.TabIndex = 4
        '
        'lblEstatus
        '
        Me.lblEstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(779, 41)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(99, 21)
        Me.lblEstatus.TabIndex = 64
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEstatus.Visible = False
        '
        'txtMesComercial
        '
        Me.txtMesComercial.Location = New System.Drawing.Point(507, 129)
        Me.txtMesComercial.Name = "txtMesComercial"
        Me.txtMesComercial.Size = New System.Drawing.Size(100, 20)
        Me.txtMesComercial.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(428, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Mes Comercial:"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Codigo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NombreCompleto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Días Trabajados"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 110
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn4.HeaderText = "HRD"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn5.HeaderText = "HRT"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn6.HeaderText = "Comisiones"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Préstamos"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Salario"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Salario"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Factor"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Factor"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'clmCodigo
        '
        Me.clmCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmCodigo.DataPropertyName = "Codigo"
        Me.clmCodigo.HeaderText = "Código"
        Me.clmCodigo.Name = "clmCodigo"
        Me.clmCodigo.ReadOnly = True
        Me.clmCodigo.Width = 65
        '
        'clmNombre
        '
        Me.clmNombre.DataPropertyName = "NombreCompleto"
        Me.clmNombre.HeaderText = "Nombre"
        Me.clmNombre.Name = "clmNombre"
        Me.clmNombre.ReadOnly = True
        Me.clmNombre.Width = 200
        '
        'clmDiasTrabajados
        '
        Me.clmDiasTrabajados.HeaderText = "Días Trabajados"
        Me.clmDiasTrabajados.Name = "clmDiasTrabajados"
        Me.clmDiasTrabajados.Width = 110
        '
        'clmHRD
        '
        Me.clmHRD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmHRD.HeaderText = "HRD"
        Me.clmHRD.Name = "clmHRD"
        Me.clmHRD.Width = 56
        '
        'clmHRT
        '
        Me.clmHRT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmHRT.HeaderText = "HRT"
        Me.clmHRT.Name = "clmHRT"
        Me.clmHRT.Width = 55
        '
        'clmComisiones
        '
        Me.clmComisiones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmComisiones.HeaderText = "Comisiones"
        Me.clmComisiones.Name = "clmComisiones"
        Me.clmComisiones.Width = 85
        '
        'clmPrestamos
        '
        Me.clmPrestamos.HeaderText = "Préstamos"
        Me.clmPrestamos.Name = "clmPrestamos"
        '
        'clmSalario
        '
        Me.clmSalario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmSalario.DataPropertyName = "Salario"
        Me.clmSalario.HeaderText = "Salario"
        Me.clmSalario.Name = "clmSalario"
        Me.clmSalario.ReadOnly = True
        Me.clmSalario.Width = 64
        '
        'clmFactor
        '
        Me.clmFactor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmFactor.DataPropertyName = "Factor"
        Me.clmFactor.HeaderText = "Factor"
        Me.clmFactor.Name = "clmFactor"
        Me.clmFactor.ReadOnly = True
        Me.clmFactor.Width = 62
        '
        'FrmCalcularNomina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 490)
        Me.Controls.Add(Me.txtMesComercial)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblEstatus)
        Me.Controls.Add(Me.txtSmRegionC)
        Me.Controls.Add(Me.txtSmRegionA)
        Me.Controls.Add(Me.gpbEmpleados)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblFolio)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmCalcularNomina"
        Me.Text = "Calcular Nómina"
        Me.gpbEmpleados.ResumeLayout(False)
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblFolio As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents gpbEmpleados As System.Windows.Forms.GroupBox
    Friend WithEvents dgvEmpleados As System.Windows.Forms.DataGridView
    Friend WithEvents txtSmRegionA As System.Windows.Forms.TextBox
    Friend WithEvents txtSmRegionC As System.Windows.Forms.TextBox
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents txtMesComercial As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EmpleadoCol As ClasesNegocio.EmpleadosCollectionClass
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDiasTrabajados As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmHRD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmHRT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmComisiones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPrestamos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSalario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFactor As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
