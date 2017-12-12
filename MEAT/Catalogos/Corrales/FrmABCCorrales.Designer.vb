<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmABCCorrales
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
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.cmbTipoCorral = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDescCorta = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtFiltro = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.dgvCorrales = New System.Windows.Forms.DataGridView
        Me.IdCorralDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescCortaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoCorralDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CapacidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SuperficieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CorralesCol = New ClasesNegocio.CorralColecttionClass
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
        Me.txtCapacidad = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtSuperficie = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbtReciba = New System.Windows.Forms.RadioButton
        Me.rbtEnfermeria = New System.Windows.Forms.RadioButton
        Me.rbtEngorda = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvCorrales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEstatus
        '
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(602, 37)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(160, 24)
        Me.lblEstatus.TabIndex = 29
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(774, 32)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "CATÁLOGO CORRALES"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mtb
        '
        Me.mtb.ButtonSize = New System.Drawing.Size(50, 50)
        Me.mtb.Dock = System.Windows.Forms.DockStyle.None
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
        Me.mtb.Location = New System.Drawing.Point(3, 30)
        Me.mtb.MostrarBorrar = True
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = True
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 747)
        Me.mtb.TabIndex = 45
        '
        'cmbTipoCorral
        '
        Me.cmbTipoCorral.FormattingEnabled = True
        Me.cmbTipoCorral.Location = New System.Drawing.Point(145, 117)
        Me.cmbTipoCorral.Name = "cmbTipoCorral"
        Me.cmbTipoCorral.Size = New System.Drawing.Size(380, 21)
        Me.cmbTipoCorral.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Tipo de Corral :"
        '
        'txtDescCorta
        '
        Me.txtDescCorta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescCorta.Location = New System.Drawing.Point(145, 89)
        Me.txtDescCorta.MaxLength = 50
        Me.txtDescCorta.Name = "txtDescCorta"
        Me.txtDescCorta.Size = New System.Drawing.Size(174, 20)
        Me.txtDescCorta.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Des. Corta :"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AcceptsReturn = True
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(145, 63)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(380, 20)
        Me.txtDescripcion.TabIndex = 1
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(145, 37)
        Me.txtCodigo.MaxLength = 5
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(58, 20)
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Descripción :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Corral:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtFiltro)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dgvCorrales)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 175)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(706, 290)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Corrales Registrados"
        '
        'txtFiltro
        '
        Me.txtFiltro.AcceptsReturn = True
        Me.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFiltro.Location = New System.Drawing.Point(102, 19)
        Me.txtFiltro.MaxLength = 100
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(309, 20)
        Me.txtFiltro.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Descripción :"
        '
        'dgvCorrales
        '
        Me.dgvCorrales.AllowUserToAddRows = False
        Me.dgvCorrales.AllowUserToDeleteRows = False
        Me.dgvCorrales.AllowUserToResizeRows = False
        Me.dgvCorrales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCorrales.AutoGenerateColumns = False
        Me.dgvCorrales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCorrales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCorralDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.DescCortaDataGridViewTextBoxColumn, Me.TipoCorralDataGridViewTextBoxColumn, Me.CapacidadDataGridViewTextBoxColumn, Me.SuperficieDataGridViewTextBoxColumn, Me.EstatusDataGridViewTextBoxColumn})
        Me.dgvCorrales.DataSource = Me.CorralesCol
        Me.dgvCorrales.Location = New System.Drawing.Point(9, 44)
        Me.dgvCorrales.MultiSelect = False
        Me.dgvCorrales.Name = "dgvCorrales"
        Me.dgvCorrales.ReadOnly = True
        Me.dgvCorrales.RowHeadersVisible = False
        Me.dgvCorrales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCorrales.Size = New System.Drawing.Size(688, 239)
        Me.dgvCorrales.TabIndex = 10
        '
        'IdCorralDataGridViewTextBoxColumn
        '
        Me.IdCorralDataGridViewTextBoxColumn.DataPropertyName = "IdCorral"
        Me.IdCorralDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.IdCorralDataGridViewTextBoxColumn.Name = "IdCorralDataGridViewTextBoxColumn"
        Me.IdCorralDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCorralDataGridViewTextBoxColumn.Width = 50
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 200
        '
        'DescCortaDataGridViewTextBoxColumn
        '
        Me.DescCortaDataGridViewTextBoxColumn.DataPropertyName = "DescCorta"
        Me.DescCortaDataGridViewTextBoxColumn.HeaderText = "Desc Corta"
        Me.DescCortaDataGridViewTextBoxColumn.Name = "DescCortaDataGridViewTextBoxColumn"
        Me.DescCortaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoCorralDataGridViewTextBoxColumn
        '
        Me.TipoCorralDataGridViewTextBoxColumn.DataPropertyName = "TipoCorral"
        Me.TipoCorralDataGridViewTextBoxColumn.HeaderText = "Tipo Corral"
        Me.TipoCorralDataGridViewTextBoxColumn.Name = "TipoCorralDataGridViewTextBoxColumn"
        Me.TipoCorralDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CapacidadDataGridViewTextBoxColumn
        '
        Me.CapacidadDataGridViewTextBoxColumn.DataPropertyName = "Capacidad"
        Me.CapacidadDataGridViewTextBoxColumn.HeaderText = "Capacidad"
        Me.CapacidadDataGridViewTextBoxColumn.Name = "CapacidadDataGridViewTextBoxColumn"
        Me.CapacidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SuperficieDataGridViewTextBoxColumn
        '
        Me.SuperficieDataGridViewTextBoxColumn.DataPropertyName = "Superficie"
        Me.SuperficieDataGridViewTextBoxColumn.HeaderText = "Superficie"
        Me.SuperficieDataGridViewTextBoxColumn.Name = "SuperficieDataGridViewTextBoxColumn"
        Me.SuperficieDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstatusDataGridViewTextBoxColumn
        '
        Me.EstatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.HeaderText = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.Name = "EstatusDataGridViewTextBoxColumn"
        Me.EstatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CorralesCol
        '
        Me.CorralesCol.AllowEdit = True
        Me.CorralesCol.AllowNew = True
        Me.CorralesCol.AllowRemove = True
        Me.CorralesCol.MaximoElementosSeleccionados = 1
        Me.CorralesCol.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.CorralesCol.MostrarAlertas = False
        Me.CorralesCol.Name = ""
        Me.CorralesCol.RaiseListChangedEvents = True
        Me.CorralesCol.Transaction = Nothing
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdCorral"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdCorral"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NombreCorral"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NomCorCorral"
        Me.DataGridViewTextBoxColumn3.HeaderText = "NomCorCorral"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IdTipoCorral"
        Me.DataGridViewTextBoxColumn4.HeaderText = "IdTipoCorral"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Capacidad"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Capacidad"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Superficie"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Superficie"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Observaciones"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Estatus"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Estatus"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "FechaBaja"
        Me.DataGridViewTextBoxColumn9.HeaderText = "FechaBaja"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "MotivoBaja"
        Me.DataGridViewTextBoxColumn10.HeaderText = "MotivoBaja"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "QuiendioBaja"
        Me.DataGridViewTextBoxColumn11.HeaderText = "QuiendioBaja"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'txtCapacidad
        '
        Me.txtCapacidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCapacidad.Location = New System.Drawing.Point(185, 146)
        Me.txtCapacidad.Name = "txtCapacidad"
        Me.txtCapacidad.Size = New System.Drawing.Size(78, 20)
        Me.txtCapacidad.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(56, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 13)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Capacidad en Cabezas :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(271, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 13)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Superficie en M² :"
        '
        'txtSuperficie
        '
        Me.txtSuperficie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSuperficie.Location = New System.Drawing.Point(367, 146)
        Me.txtSuperficie.Name = "txtSuperficie"
        Me.txtSuperficie.Size = New System.Drawing.Size(82, 20)
        Me.txtSuperficie.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbtReciba)
        Me.GroupBox2.Controls.Add(Me.rbtEnfermeria)
        Me.GroupBox2.Controls.Add(Me.rbtEngorda)
        Me.GroupBox2.Location = New System.Drawing.Point(531, 100)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(231, 47)
        Me.GroupBox2.TabIndex = 62
        Me.GroupBox2.TabStop = False
        '
        'rbtReciba
        '
        Me.rbtReciba.AutoSize = True
        Me.rbtReciba.Location = New System.Drawing.Point(158, 19)
        Me.rbtReciba.Name = "rbtReciba"
        Me.rbtReciba.Size = New System.Drawing.Size(59, 17)
        Me.rbtReciba.TabIndex = 6
        Me.rbtReciba.TabStop = True
        Me.rbtReciba.Text = "Reciba"
        Me.rbtReciba.UseVisualStyleBackColor = True
        '
        'rbtEnfermeria
        '
        Me.rbtEnfermeria.AutoSize = True
        Me.rbtEnfermeria.Location = New System.Drawing.Point(77, 19)
        Me.rbtEnfermeria.Name = "rbtEnfermeria"
        Me.rbtEnfermeria.Size = New System.Drawing.Size(77, 17)
        Me.rbtEnfermeria.TabIndex = 5
        Me.rbtEnfermeria.TabStop = True
        Me.rbtEnfermeria.Text = "Enfermería"
        Me.rbtEnfermeria.UseVisualStyleBackColor = True
        '
        'rbtEngorda
        '
        Me.rbtEngorda.AutoSize = True
        Me.rbtEngorda.Location = New System.Drawing.Point(6, 19)
        Me.rbtEngorda.Name = "rbtEngorda"
        Me.rbtEngorda.Size = New System.Drawing.Size(65, 17)
        Me.rbtEngorda.TabIndex = 4
        Me.rbtEngorda.TabStop = True
        Me.rbtEngorda.Text = "Engorda"
        Me.rbtEngorda.UseVisualStyleBackColor = True
        '
        'FrmABCCorrales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 477)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtSuperficie)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCapacidad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbTipoCorral)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDescCorta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblEstatus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmABCCorrales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Corrales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvCorrales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvCorrales As System.Windows.Forms.DataGridView
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents cmbTipoCorral As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDescCorta As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
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
    Friend WithEvents CorralesCol As ClasesNegocio.CorralColecttionClass
    Friend WithEvents txtCapacidad As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSuperficie As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtReciba As System.Windows.Forms.RadioButton
    Friend WithEvents rbtEnfermeria As System.Windows.Forms.RadioButton
    Friend WithEvents rbtEngorda As System.Windows.Forms.RadioButton
    Friend WithEvents IdCorralDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescCortaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoCorralDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CapacidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SuperficieDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
