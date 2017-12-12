<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmABCConceptoGastosTransportes
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
        Me.txtPorcentaje = New Integralab.Controles.TextBoxMejorado
        Me.txtObservaciones = New System.Windows.Forms.TextBox
        Me.btnCtaCont = New System.Windows.Forms.Button
        Me.txtCtaCont = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.chkIVA = New System.Windows.Forms.CheckBox
        Me.txtDescCorta = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtFiltro = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.dgvConceptoGasto = New System.Windows.Forms.DataGridView
        Me.IdConceptoGastoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescCortaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AplicaIVADataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.PorcentajeIVADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ObservacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ConceptoGastoC = New ClasesNegocio.ConceptoGastosTransporteColeccionClass
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvConceptoGasto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPorcentaje)
        Me.GroupBox1.Controls.Add(Me.btnCtaCont)
        Me.GroupBox1.Controls.Add(Me.txtCtaCont)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.chkIVA)
        Me.GroupBox1.Controls.Add(Me.txtDescCorta)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.lblEstatus)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(517, 202)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        '
        'txtPorcentaje
        '
        Me.txtPorcentaje.ComboBoxEnlazado = Nothing
        Me.txtPorcentaje.Decimales = 0
        Me.txtPorcentaje.Location = New System.Drawing.Point(154, 125)
        Me.txtPorcentaje.MaxLength = 3000
        Me.txtPorcentaje.MensajeCombo = "Seleccionar un item..."
        Me.txtPorcentaje.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtPorcentaje.Name = "txtPorcentaje"
        Me.txtPorcentaje.SiguienteControl = Me.txtObservaciones
        Me.txtPorcentaje.Size = New System.Drawing.Size(53, 20)
        Me.txtPorcentaje.TabIndex = 4
        Me.txtPorcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPorcentaje.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.[Decimal]
        Me.txtPorcentaje.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtPorcentaje.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtObservaciones
        '
        Me.txtObservaciones.AcceptsReturn = True
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Location = New System.Drawing.Point(105, 150)
        Me.txtObservaciones.MaxLength = 250
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(328, 44)
        Me.txtObservaciones.TabIndex = 5
        '
        'btnCtaCont
        '
        Me.btnCtaCont.Location = New System.Drawing.Point(440, 97)
        Me.btnCtaCont.Name = "btnCtaCont"
        Me.btnCtaCont.Size = New System.Drawing.Size(22, 23)
        Me.btnCtaCont.TabIndex = 9
        Me.btnCtaCont.Text = "..."
        Me.btnCtaCont.UseVisualStyleBackColor = True
        '
        'txtCtaCont
        '
        Me.txtCtaCont.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCtaCont.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtaCont.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtCtaCont.Location = New System.Drawing.Point(105, 98)
        Me.txtCtaCont.Name = "txtCtaCont"
        Me.txtCtaCont.ReadOnly = True
        Me.txtCtaCont.Size = New System.Drawing.Size(324, 22)
        Me.txtCtaCont.TabIndex = 45
        Me.txtCtaCont.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 13)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Cuenta Contable :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Observaciones :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(213, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 13)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "%"
        '
        'chkIVA
        '
        Me.chkIVA.AutoSize = True
        Me.chkIVA.Location = New System.Drawing.Point(105, 127)
        Me.chkIVA.Name = "chkIVA"
        Me.chkIVA.Size = New System.Drawing.Size(43, 17)
        Me.chkIVA.TabIndex = 3
        Me.chkIVA.Text = "IVA"
        Me.chkIVA.UseVisualStyleBackColor = True
        '
        'txtDescCorta
        '
        Me.txtDescCorta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescCorta.Location = New System.Drawing.Point(105, 72)
        Me.txtDescCorta.MaxLength = 6
        Me.txtDescCorta.Name = "txtDescCorta"
        Me.txtDescCorta.Size = New System.Drawing.Size(102, 20)
        Me.txtDescCorta.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Des. Corta :"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AcceptsReturn = True
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(105, 47)
        Me.txtDescripcion.MaxLength = 60
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(324, 20)
        Me.txtDescripcion.TabIndex = 0
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(105, 21)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(58, 20)
        Me.txtCodigo.TabIndex = 10
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblEstatus
        '
        Me.lblEstatus.AutoSize = True
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(403, 14)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(104, 24)
        Me.lblEstatus.TabIndex = 29
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripción :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo :"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(587, 29)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "CATÁLOGO CONCEPTOS DE GASTOS DE TRANSPORTE"
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
        Me.mtb.Location = New System.Drawing.Point(3, 28)
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
        Me.mtb.TabIndex = 6
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdConceptoGasto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DescCorta"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Descripción Corta"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PorcentajeIVA"
        Me.DataGridViewTextBoxColumn4.HeaderText = "% IVA"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 50
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Observaciones"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Estatus"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Estatus"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtFiltro)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.dgvConceptoGasto)
        Me.GroupBox2.Location = New System.Drawing.Point(56, 242)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(517, 261)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Conceptos Regustrados"
        '
        'txtFiltro
        '
        Me.txtFiltro.AcceptsReturn = True
        Me.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFiltro.Location = New System.Drawing.Point(109, 24)
        Me.txtFiltro.MaxLength = 60
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(324, 20)
        Me.txtFiltro.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Descripción :"
        '
        'dgvConceptoGasto
        '
        Me.dgvConceptoGasto.AllowUserToAddRows = False
        Me.dgvConceptoGasto.AllowUserToDeleteRows = False
        Me.dgvConceptoGasto.AllowUserToResizeRows = False
        Me.dgvConceptoGasto.AutoGenerateColumns = False
        Me.dgvConceptoGasto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConceptoGasto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdConceptoGastoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.DescCortaDataGridViewTextBoxColumn, Me.AplicaIVADataGridViewCheckBoxColumn, Me.PorcentajeIVADataGridViewTextBoxColumn, Me.ObservacionesDataGridViewTextBoxColumn, Me.EstatusDataGridViewTextBoxColumn})
        Me.dgvConceptoGasto.DataSource = Me.ConceptoGastoC
        Me.dgvConceptoGasto.Location = New System.Drawing.Point(9, 52)
        Me.dgvConceptoGasto.MultiSelect = False
        Me.dgvConceptoGasto.Name = "dgvConceptoGasto"
        Me.dgvConceptoGasto.ReadOnly = True
        Me.dgvConceptoGasto.RowHeadersVisible = False
        Me.dgvConceptoGasto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvConceptoGasto.Size = New System.Drawing.Size(491, 198)
        Me.dgvConceptoGasto.TabIndex = 8
        '
        'IdConceptoGastoDataGridViewTextBoxColumn
        '
        Me.IdConceptoGastoDataGridViewTextBoxColumn.DataPropertyName = "IdConceptoGasto"
        Me.IdConceptoGastoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.IdConceptoGastoDataGridViewTextBoxColumn.Name = "IdConceptoGastoDataGridViewTextBoxColumn"
        Me.IdConceptoGastoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdConceptoGastoDataGridViewTextBoxColumn.Width = 50
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 200
        '
        'DescCortaDataGridViewTextBoxColumn
        '
        Me.DescCortaDataGridViewTextBoxColumn.DataPropertyName = "DescCorta"
        Me.DescCortaDataGridViewTextBoxColumn.HeaderText = "Descripción Corta"
        Me.DescCortaDataGridViewTextBoxColumn.Name = "DescCortaDataGridViewTextBoxColumn"
        Me.DescCortaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AplicaIVADataGridViewCheckBoxColumn
        '
        Me.AplicaIVADataGridViewCheckBoxColumn.DataPropertyName = "AplicaIVA"
        Me.AplicaIVADataGridViewCheckBoxColumn.HeaderText = "Aplica IVA"
        Me.AplicaIVADataGridViewCheckBoxColumn.Name = "AplicaIVADataGridViewCheckBoxColumn"
        Me.AplicaIVADataGridViewCheckBoxColumn.ReadOnly = True
        '
        'PorcentajeIVADataGridViewTextBoxColumn
        '
        Me.PorcentajeIVADataGridViewTextBoxColumn.DataPropertyName = "PorcentajeIVA"
        Me.PorcentajeIVADataGridViewTextBoxColumn.HeaderText = "% IVA"
        Me.PorcentajeIVADataGridViewTextBoxColumn.Name = "PorcentajeIVADataGridViewTextBoxColumn"
        Me.PorcentajeIVADataGridViewTextBoxColumn.ReadOnly = True
        Me.PorcentajeIVADataGridViewTextBoxColumn.Width = 60
        '
        'ObservacionesDataGridViewTextBoxColumn
        '
        Me.ObservacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.Name = "ObservacionesDataGridViewTextBoxColumn"
        Me.ObservacionesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstatusDataGridViewTextBoxColumn
        '
        Me.EstatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.HeaderText = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.Name = "EstatusDataGridViewTextBoxColumn"
        Me.EstatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ConceptoGastoC
        '
        Me.ConceptoGastoC.AllowEdit = True
        Me.ConceptoGastoC.AllowNew = True
        Me.ConceptoGastoC.AllowRemove = True
        Me.ConceptoGastoC.MaximoElementosSeleccionados = 1
        Me.ConceptoGastoC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.ConceptoGastoC.MostrarAlertas = False
        Me.ConceptoGastoC.Name = ""
        Me.ConceptoGastoC.RaiseListChangedEvents = True
        Me.ConceptoGastoC.Transaction = Nothing
        '
        'FrmABCConceptoGastosTransportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 515)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.mtb)
        Me.Name = "FrmABCConceptoGastosTransportes"
        Me.Text = "Conceptos de Gastos de Transportes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvConceptoGasto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvConceptoGasto As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescCorta As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkIVA As System.Windows.Forms.CheckBox
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ConceptoGastoC As ClasesNegocio.ConceptoGastosTransporteColeccionClass
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnCtaCont As System.Windows.Forms.Button
    Friend WithEvents txtCtaCont As System.Windows.Forms.TextBox
    Friend WithEvents txtPorcentaje As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents IdConceptoGastoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescCortaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AplicaIVADataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PorcentajeIVADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
