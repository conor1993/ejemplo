<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaCorrales
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
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle40 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.txtCapacidad = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbTipoCorral = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label17 = New System.Windows.Forms.Label
        Me.cmbCorral = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.dgvGanado = New System.Windows.Forms.DataGridView
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtTotalCostoGanado = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtTotalCostosIndirectos = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtTotalCostoAlimentos = New System.Windows.Forms.TextBox
        Me.txtTotalCostoMedicamentos = New System.Windows.Forms.TextBox
        Me.txtTotalCostoEntrada = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtLotes = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtSuperficie = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.Formula = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaInicio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaFin = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Kilogramos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DiasFormula = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCostoAlimento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmKgrsAlimento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCostosIndirecto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmUltimaEntrada = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmUltimaSalida = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmUltReinicio = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgvGanado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCapacidad
        '
        Me.txtCapacidad.Location = New System.Drawing.Point(391, 19)
        Me.txtCapacidad.Name = "txtCapacidad"
        Me.txtCapacidad.ReadOnly = True
        Me.txtCapacidad.Size = New System.Drawing.Size(105, 20)
        Me.txtCapacidad.TabIndex = 94
        Me.txtCapacidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(385, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Corral :"
        '
        'cmbTipoCorral
        '
        Me.cmbTipoCorral.DisplayMember = "Descripcion"
        Me.cmbTipoCorral.FormattingEnabled = True
        Me.cmbTipoCorral.Location = New System.Drawing.Point(144, 46)
        Me.cmbTipoCorral.Name = "cmbTipoCorral"
        Me.cmbTipoCorral.Size = New System.Drawing.Size(235, 21)
        Me.cmbTipoCorral.TabIndex = 92
        Me.cmbTipoCorral.ValueMember = "IdTipoCorral"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Tipo de Corral :"
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
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 392)
        Me.mtb.TabIndex = 90
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(52, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(942, 32)
        Me.Label17.TabIndex = 89
        Me.Label17.Text = "Consulta de Corrales "
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbCorral
        '
        Me.cmbCorral.FormattingEnabled = True
        Me.cmbCorral.Location = New System.Drawing.Point(431, 46)
        Me.cmbCorral.Name = "cmbCorral"
        Me.cmbCorral.Size = New System.Drawing.Size(196, 21)
        Me.cmbCorral.TabIndex = 99
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(321, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = "Capacidad :"
        '
        'dgvGanado
        '
        Me.dgvGanado.AllowUserToAddRows = False
        Me.dgvGanado.AllowUserToDeleteRows = False
        Me.dgvGanado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGanado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Formula, Me.FechaInicio, Me.FechaFin, Me.Kilogramos, Me.DiasFormula, Me.clmCostoAlimento, Me.clmKgrsAlimento, Me.clmCostosIndirecto, Me.clmUltimaEntrada, Me.clmUltimaSalida, Me.clmUltReinicio})
        Me.dgvGanado.Location = New System.Drawing.Point(6, 19)
        Me.dgvGanado.Name = "dgvGanado"
        Me.dgvGanado.ReadOnly = True
        Me.dgvGanado.RowHeadersVisible = False
        Me.dgvGanado.Size = New System.Drawing.Size(902, 205)
        Me.dgvGanado.TabIndex = 102
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 233)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 13)
        Me.Label7.TabIndex = 106
        Me.Label7.Text = "Total Costo de Ganado :"
        '
        'txtTotalCostoGanado
        '
        Me.txtTotalCostoGanado.Location = New System.Drawing.Point(136, 230)
        Me.txtTotalCostoGanado.Name = "txtTotalCostoGanado"
        Me.txtTotalCostoGanado.ReadOnly = True
        Me.txtTotalCostoGanado.Size = New System.Drawing.Size(105, 20)
        Me.txtTotalCostoGanado.TabIndex = 105
        Me.txtTotalCostoGanado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTotalCostosIndirectos)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtTotalCostoAlimentos)
        Me.GroupBox2.Controls.Add(Me.txtTotalCostoMedicamentos)
        Me.GroupBox2.Controls.Add(Me.txtTotalCostoEntrada)
        Me.GroupBox2.Controls.Add(Me.dgvGanado)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtTotalCostoGanado)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(914, 259)
        Me.GroupBox2.TabIndex = 107
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ganado"
        '
        'txtTotalCostosIndirectos
        '
        Me.txtTotalCostosIndirectos.Location = New System.Drawing.Point(591, 230)
        Me.txtTotalCostosIndirectos.Name = "txtTotalCostosIndirectos"
        Me.txtTotalCostosIndirectos.ReadOnly = True
        Me.txtTotalCostosIndirectos.Size = New System.Drawing.Size(93, 20)
        Me.txtTotalCostosIndirectos.TabIndex = 116
        Me.txtTotalCostosIndirectos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(572, 233)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 13)
        Me.Label13.TabIndex = 115
        Me.Label13.Text = "+"
        '
        'txtTotalCostoAlimentos
        '
        Me.txtTotalCostoAlimentos.Location = New System.Drawing.Point(471, 230)
        Me.txtTotalCostoAlimentos.Name = "txtTotalCostoAlimentos"
        Me.txtTotalCostoAlimentos.ReadOnly = True
        Me.txtTotalCostoAlimentos.Size = New System.Drawing.Size(95, 20)
        Me.txtTotalCostoAlimentos.TabIndex = 111
        Me.txtTotalCostoAlimentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalCostoMedicamentos
        '
        Me.txtTotalCostoMedicamentos.Location = New System.Drawing.Point(380, 230)
        Me.txtTotalCostoMedicamentos.Name = "txtTotalCostoMedicamentos"
        Me.txtTotalCostoMedicamentos.ReadOnly = True
        Me.txtTotalCostoMedicamentos.Size = New System.Drawing.Size(78, 20)
        Me.txtTotalCostoMedicamentos.TabIndex = 110
        Me.txtTotalCostoMedicamentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalCostoEntrada
        '
        Me.txtTotalCostoEntrada.Location = New System.Drawing.Point(262, 230)
        Me.txtTotalCostoEntrada.Name = "txtTotalCostoEntrada"
        Me.txtTotalCostoEntrada.ReadOnly = True
        Me.txtTotalCostoEntrada.Size = New System.Drawing.Size(105, 20)
        Me.txtTotalCostoEntrada.TabIndex = 109
        Me.txtTotalCostoEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(246, 233)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 13)
        Me.Label12.TabIndex = 114
        Me.Label12.Text = "="
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(367, 233)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 13)
        Me.Label11.TabIndex = 113
        Me.Label11.Text = "+"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(458, 233)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 13)
        Me.Label10.TabIndex = 112
        Me.Label10.Text = "+"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtLotes)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtSuperficie)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtCapacidad)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(927, 312)
        Me.GroupBox1.TabIndex = 108
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "General"
        '
        'txtLotes
        '
        Me.txtLotes.Location = New System.Drawing.Point(209, 19)
        Me.txtLotes.Name = "txtLotes"
        Me.txtLotes.ReadOnly = True
        Me.txtLotes.Size = New System.Drawing.Size(105, 20)
        Me.txtLotes.TabIndex = 109
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(502, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 111
        Me.Label9.Text = "Superficie :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(169, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 110
        Me.Label6.Text = "Lote :"
        '
        'txtSuperficie
        '
        Me.txtSuperficie.Location = New System.Drawing.Point(568, 19)
        Me.txtSuperficie.Name = "txtSuperficie"
        Me.txtSuperficie.ReadOnly = True
        Me.txtSuperficie.Size = New System.Drawing.Size(105, 20)
        Me.txtSuperficie.TabIndex = 110
        Me.txtSuperficie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 109
        Me.Label8.Text = "Codigo :"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(58, 19)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(105, 20)
        Me.txtCodigo.TabIndex = 108
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Formula
        '
        Me.Formula.DataPropertyName = "TipoGanado"
        Me.Formula.HeaderText = "Tipo de Ganado"
        Me.Formula.Name = "Formula"
        Me.Formula.ReadOnly = True
        Me.Formula.Width = 130
        '
        'FechaInicio
        '
        Me.FechaInicio.DataPropertyName = "ExistCabezas"
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle31.Format = "N0"
        Me.FechaInicio.DefaultCellStyle = DataGridViewCellStyle31
        Me.FechaInicio.HeaderText = "Cabezas"
        Me.FechaInicio.Name = "FechaInicio"
        Me.FechaInicio.ReadOnly = True
        Me.FechaInicio.Width = 60
        '
        'FechaFin
        '
        Me.FechaFin.DataPropertyName = "ExistKilos"
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle32.Format = "N4"
        Me.FechaFin.DefaultCellStyle = DataGridViewCellStyle32
        Me.FechaFin.HeaderText = "Kilos"
        Me.FechaFin.Name = "FechaFin"
        Me.FechaFin.ReadOnly = True
        Me.FechaFin.Width = 80
        '
        'Kilogramos
        '
        Me.Kilogramos.DataPropertyName = "CostoEnt"
        DataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle33.Format = "C2"
        Me.Kilogramos.DefaultCellStyle = DataGridViewCellStyle33
        Me.Kilogramos.HeaderText = "Costo Entrada"
        Me.Kilogramos.Name = "Kilogramos"
        Me.Kilogramos.ReadOnly = True
        '
        'DiasFormula
        '
        Me.DiasFormula.DataPropertyName = "ImpteMedicamento"
        DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle34.Format = "C2"
        Me.DiasFormula.DefaultCellStyle = DataGridViewCellStyle34
        Me.DiasFormula.HeaderText = "Costo Medicamento"
        Me.DiasFormula.Name = "DiasFormula"
        Me.DiasFormula.ReadOnly = True
        Me.DiasFormula.Width = 80
        '
        'clmCostoAlimento
        '
        Me.clmCostoAlimento.DataPropertyName = "ImpteAlimento"
        DataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle35.Format = "C2"
        Me.clmCostoAlimento.DefaultCellStyle = DataGridViewCellStyle35
        Me.clmCostoAlimento.HeaderText = "Costo Alimento"
        Me.clmCostoAlimento.Name = "clmCostoAlimento"
        Me.clmCostoAlimento.ReadOnly = True
        Me.clmCostoAlimento.Width = 80
        '
        'clmKgrsAlimento
        '
        Me.clmKgrsAlimento.DataPropertyName = "KilosAlimento"
        DataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle36.Format = "N4"
        Me.clmKgrsAlimento.DefaultCellStyle = DataGridViewCellStyle36
        Me.clmKgrsAlimento.HeaderText = "Kgrs. Alimento"
        Me.clmKgrsAlimento.Name = "clmKgrsAlimento"
        Me.clmKgrsAlimento.ReadOnly = True
        Me.clmKgrsAlimento.Width = 80
        '
        'clmCostosIndirecto
        '
        Me.clmCostosIndirecto.DataPropertyName = "SaldoCostoInd"
        DataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle37.Format = "C2"
        Me.clmCostosIndirecto.DefaultCellStyle = DataGridViewCellStyle37
        Me.clmCostosIndirecto.HeaderText = "Costos Indirectos"
        Me.clmCostosIndirecto.Name = "clmCostosIndirecto"
        Me.clmCostosIndirecto.ReadOnly = True
        Me.clmCostosIndirecto.Width = 60
        '
        'clmUltimaEntrada
        '
        Me.clmUltimaEntrada.DataPropertyName = "FechaUltEnt"
        DataGridViewCellStyle38.Format = "d"
        Me.clmUltimaEntrada.DefaultCellStyle = DataGridViewCellStyle38
        Me.clmUltimaEntrada.HeaderText = "Ult. Entrada"
        Me.clmUltimaEntrada.Name = "clmUltimaEntrada"
        Me.clmUltimaEntrada.ReadOnly = True
        Me.clmUltimaEntrada.Width = 70
        '
        'clmUltimaSalida
        '
        Me.clmUltimaSalida.DataPropertyName = "FEchaUltSal"
        DataGridViewCellStyle39.Format = "d"
        DataGridViewCellStyle39.NullValue = "Sin Salidas"
        Me.clmUltimaSalida.DefaultCellStyle = DataGridViewCellStyle39
        Me.clmUltimaSalida.HeaderText = "Ult. Salida"
        Me.clmUltimaSalida.Name = "clmUltimaSalida"
        Me.clmUltimaSalida.ReadOnly = True
        Me.clmUltimaSalida.Width = 70
        '
        'clmUltReinicio
        '
        Me.clmUltReinicio.DataPropertyName = "FechaUltReinicio"
        DataGridViewCellStyle40.Format = "d"
        DataGridViewCellStyle40.NullValue = "Sin Reinicios"
        Me.clmUltReinicio.DefaultCellStyle = DataGridViewCellStyle40
        Me.clmUltReinicio.HeaderText = "Ult. Reinicio"
        Me.clmUltReinicio.Name = "clmUltReinicio"
        Me.clmUltReinicio.ReadOnly = True
        Me.clmUltReinicio.Width = 70
        '
        'FrmConsultaCorrales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 392)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbCorral)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbTipoCorral)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.Label17)
        Me.Name = "FrmConsultaCorrales"
        Me.Text = "FrmConsultaCorrales"
        CType(Me.dgvGanado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCapacidad As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoCorral As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmbCorral As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgvGanado As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTotalCostoGanado As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtSuperficie As System.Windows.Forms.TextBox
    Friend WithEvents txtLotes As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTotalCostoAlimentos As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalCostoMedicamentos As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalCostoEntrada As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTotalCostosIndirectos As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Formula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kilogramos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiasFormula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCostoAlimento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmKgrsAlimento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCostosIndirecto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmUltimaEntrada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmUltimaSalida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmUltReinicio As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
