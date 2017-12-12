<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfiguracionEngorda
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.chkTransRecibaPorArete = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtImpuestoPredialXAnimal = New Integralab.Controles.TextBoxMejorado
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtPorcentajeEducacion = New Integralab.Controles.TextBoxMejorado
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtGDP = New Integralab.Controles.TextBoxMejorado
        Me.Label2 = New System.Windows.Forms.Label
        Me.chkRequerirArete = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCostoIndirectoMen = New Integralab.Controles.TextBoxMejorado
        Me.cmbMesCostoIndirecto = New System.Windows.Forms.ComboBox
        Me.ultdtpFechaCierreDiario = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.lblFechaCierreInicial = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmbLinea = New System.Windows.Forms.ComboBox
        Me.LineaCollectionClass1 = New ClasesNegocio.LineaCollectionClass
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbTipoAlmacenRolado = New System.Windows.Forms.ComboBox
        Me.TipoAlmacenRoladoC = New ClasesNegocio.TipoAlmacenCollectionClass
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbTipoAlmacenMedicamento = New System.Windows.Forms.ComboBox
        Me.TipoAlmacenMedicamentoC = New ClasesNegocio.TipoAlmacenCollectionClass
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbTipoAlmacenFormula = New System.Windows.Forms.ComboBox
        Me.TipoAlmacenFormulaC = New ClasesNegocio.TipoAlmacenCollectionClass
        Me.Label3 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ultdtpFechaCierreDiario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(56, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(498, 29)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "CONFIGURACIÓN DE ENGORDA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mtb
        '
        Me.mtb.ButtonSize = New System.Drawing.Size(50, 50)
        Me.mtb.Dock = System.Windows.Forms.DockStyle.None
        Me.mtb.DropDownArrows = True
        Me.mtb.HabilitarBorrar = True
        Me.mtb.HabilitarBuscar = True
        Me.mtb.HabilitarCancelar = True
        Me.mtb.HabilitarEditar = False
        Me.mtb.HabilitarGuardar = True
        Me.mtb.HabilitarImprimir = True
        Me.mtb.HabilitarLimpiar = True
        Me.mtb.HabilitarNuevo = True
        Me.mtb.HabilitarSalir = True
        Me.mtb.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32
        Me.mtb.Location = New System.Drawing.Point(0, -52)
        Me.mtb.MostrarBorrar = False
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = False
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = False
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 266)
        Me.mtb.TabIndex = 12
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(56, 32)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(486, 307)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.chkTransRecibaPorArete)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.chkRequerirArete)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.cmbLinea)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.cmbTipoAlmacenRolado)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.cmbTipoAlmacenMedicamento)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.cmbTipoAlmacenFormula)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(478, 281)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'chkTransRecibaPorArete
        '
        Me.chkTransRecibaPorArete.AutoSize = True
        Me.chkTransRecibaPorArete.Location = New System.Drawing.Point(31, 142)
        Me.chkTransRecibaPorArete.Name = "chkTransRecibaPorArete"
        Me.chkTransRecibaPorArete.Size = New System.Drawing.Size(148, 17)
        Me.chkTransRecibaPorArete.TabIndex = 13
        Me.chkTransRecibaPorArete.Text = "Permitir Captura de Aretes"
        Me.chkTransRecibaPorArete.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtImpuestoPredialXAnimal)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtPorcentajeEducacion)
        Me.GroupBox3.Location = New System.Drawing.Point(267, 119)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(205, 76)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Compras de Ganado"
        '
        'txtImpuestoPredialXAnimal
        '
        Me.txtImpuestoPredialXAnimal.ComboBoxEnlazado = Nothing
        Me.txtImpuestoPredialXAnimal.Decimales = 2
        Me.txtImpuestoPredialXAnimal.Location = New System.Drawing.Point(145, 19)
        Me.txtImpuestoPredialXAnimal.MaxLength = 3000
        Me.txtImpuestoPredialXAnimal.MensajeCombo = "Seleccionar un item..."
        Me.txtImpuestoPredialXAnimal.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtImpuestoPredialXAnimal.Name = "txtImpuestoPredialXAnimal"
        Me.txtImpuestoPredialXAnimal.SiguienteControl = Nothing
        Me.txtImpuestoPredialXAnimal.Size = New System.Drawing.Size(54, 20)
        Me.txtImpuestoPredialXAnimal.TabIndex = 0
        Me.txtImpuestoPredialXAnimal.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.[Decimal]
        Me.txtImpuestoPredialXAnimal.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtImpuestoPredialXAnimal.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Importe Predial Por Animal:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Porcentaje a la Educación:"
        '
        'txtPorcentajeEducacion
        '
        Me.txtPorcentajeEducacion.ComboBoxEnlazado = Nothing
        Me.txtPorcentajeEducacion.Decimales = 2
        Me.txtPorcentajeEducacion.Location = New System.Drawing.Point(145, 45)
        Me.txtPorcentajeEducacion.MaxLength = 3000
        Me.txtPorcentajeEducacion.MensajeCombo = "Seleccionar un item..."
        Me.txtPorcentajeEducacion.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtPorcentajeEducacion.Name = "txtPorcentajeEducacion"
        Me.txtPorcentajeEducacion.SiguienteControl = Nothing
        Me.txtPorcentajeEducacion.Size = New System.Drawing.Size(54, 20)
        Me.txtPorcentajeEducacion.TabIndex = 1
        Me.txtPorcentajeEducacion.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.[Decimal]
        Me.txtPorcentajeEducacion.ValorMaximo = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtPorcentajeEducacion.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtGDP)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(267, 201)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(205, 51)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Catalogo de Lotes"
        '
        'txtGDP
        '
        Me.txtGDP.ComboBoxEnlazado = Nothing
        Me.txtGDP.Decimales = 3
        Me.txtGDP.Location = New System.Drawing.Point(145, 19)
        Me.txtGDP.MaxLength = 3000
        Me.txtGDP.MensajeCombo = "Seleccionar un item..."
        Me.txtGDP.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtGDP.Name = "txtGDP"
        Me.txtGDP.SiguienteControl = Nothing
        Me.txtGDP.Size = New System.Drawing.Size(54, 20)
        Me.txtGDP.TabIndex = 0
        Me.txtGDP.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.[Decimal]
        Me.txtGDP.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtGDP.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Ganancia Diaria de Peso:"
        '
        'chkRequerirArete
        '
        Me.chkRequerirArete.AutoSize = True
        Me.chkRequerirArete.Location = New System.Drawing.Point(12, 119)
        Me.chkRequerirArete.Name = "chkRequerirArete"
        Me.chkRequerirArete.Size = New System.Drawing.Size(233, 17)
        Me.chkRequerirArete.TabIndex = 4
        Me.chkRequerirArete.Text = "Requerir Arete (Transporte, Siniiga o Propio)"
        Me.chkRequerirArete.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCostoIndirectoMen)
        Me.GroupBox1.Controls.Add(Me.cmbMesCostoIndirecto)
        Me.GroupBox1.Controls.Add(Me.ultdtpFechaCierreDiario)
        Me.GroupBox1.Controls.Add(Me.lblFechaCierreInicial)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 165)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(255, 110)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cierre Diario de Engorda"
        '
        'txtCostoIndirectoMen
        '
        Me.txtCostoIndirectoMen.ComboBoxEnlazado = Nothing
        Me.txtCostoIndirectoMen.Decimales = 2
        Me.txtCostoIndirectoMen.Location = New System.Drawing.Point(152, 22)
        Me.txtCostoIndirectoMen.MaxLength = 3000
        Me.txtCostoIndirectoMen.MensajeCombo = "Seleccionar un item..."
        Me.txtCostoIndirectoMen.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtCostoIndirectoMen.Name = "txtCostoIndirectoMen"
        Me.txtCostoIndirectoMen.SiguienteControl = Nothing
        Me.txtCostoIndirectoMen.Size = New System.Drawing.Size(91, 20)
        Me.txtCostoIndirectoMen.TabIndex = 11
        Me.txtCostoIndirectoMen.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.[Decimal]
        Me.txtCostoIndirectoMen.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCostoIndirectoMen.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cmbMesCostoIndirecto
        '
        Me.cmbMesCostoIndirecto.FormattingEnabled = True
        Me.cmbMesCostoIndirecto.Location = New System.Drawing.Point(152, 48)
        Me.cmbMesCostoIndirecto.Name = "cmbMesCostoIndirecto"
        Me.cmbMesCostoIndirecto.Size = New System.Drawing.Size(91, 21)
        Me.cmbMesCostoIndirecto.TabIndex = 1
        '
        'ultdtpFechaCierreDiario
        '
        Me.ultdtpFechaCierreDiario.Location = New System.Drawing.Point(152, 75)
        Me.ultdtpFechaCierreDiario.Name = "ultdtpFechaCierreDiario"
        Me.ultdtpFechaCierreDiario.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.ultdtpFechaCierreDiario.Size = New System.Drawing.Size(91, 21)
        Me.ultdtpFechaCierreDiario.TabIndex = 2
        '
        'lblFechaCierreInicial
        '
        Me.lblFechaCierreInicial.AutoSize = True
        Me.lblFechaCierreInicial.Location = New System.Drawing.Point(11, 79)
        Me.lblFechaCierreInicial.Name = "lblFechaCierreInicial"
        Me.lblFechaCierreInicial.Size = New System.Drawing.Size(115, 13)
        Me.lblFechaCierreInicial.TabIndex = 19
        Me.lblFechaCierreInicial.Text = "Fecha de Cierre Diario:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Al mes de:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Costo Indirecto Mensual:"
        '
        'cmbLinea
        '
        Me.cmbLinea.DataSource = Me.LineaCollectionClass1
        Me.cmbLinea.DisplayMember = "Descripcion"
        Me.cmbLinea.FormattingEnabled = True
        Me.cmbLinea.Location = New System.Drawing.Point(157, 92)
        Me.cmbLinea.Name = "cmbLinea"
        Me.cmbLinea.Size = New System.Drawing.Size(305, 21)
        Me.cmbLinea.TabIndex = 3
        Me.cmbLinea.ValueMember = "Codigo"
        '
        'LineaCollectionClass1
        '
        Me.LineaCollectionClass1.AllowEdit = True
        Me.LineaCollectionClass1.AllowNew = True
        Me.LineaCollectionClass1.AllowRemove = True
        Me.LineaCollectionClass1.Name = ""
        Me.LineaCollectionClass1.RaiseListChangedEvents = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Familia Medicamentos:"
        '
        'cmbTipoAlmacenRolado
        '
        Me.cmbTipoAlmacenRolado.DataSource = Me.TipoAlmacenRoladoC
        Me.cmbTipoAlmacenRolado.DisplayMember = "Descripcion"
        Me.cmbTipoAlmacenRolado.FormattingEnabled = True
        Me.cmbTipoAlmacenRolado.Location = New System.Drawing.Point(157, 65)
        Me.cmbTipoAlmacenRolado.Name = "cmbTipoAlmacenRolado"
        Me.cmbTipoAlmacenRolado.Size = New System.Drawing.Size(305, 21)
        Me.cmbTipoAlmacenRolado.TabIndex = 2
        Me.cmbTipoAlmacenRolado.ValueMember = "Codigo"
        '
        'TipoAlmacenRoladoC
        '
        Me.TipoAlmacenRoladoC.AllowEdit = True
        Me.TipoAlmacenRoladoC.AllowNew = True
        Me.TipoAlmacenRoladoC.AllowRemove = True
        Me.TipoAlmacenRoladoC.Name = ""
        Me.TipoAlmacenRoladoC.RaiseListChangedEvents = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Tipo Almacén Rolado:"
        '
        'cmbTipoAlmacenMedicamento
        '
        Me.cmbTipoAlmacenMedicamento.DataSource = Me.TipoAlmacenMedicamentoC
        Me.cmbTipoAlmacenMedicamento.DisplayMember = "Descripcion"
        Me.cmbTipoAlmacenMedicamento.FormattingEnabled = True
        Me.cmbTipoAlmacenMedicamento.Location = New System.Drawing.Point(157, 38)
        Me.cmbTipoAlmacenMedicamento.Name = "cmbTipoAlmacenMedicamento"
        Me.cmbTipoAlmacenMedicamento.Size = New System.Drawing.Size(305, 21)
        Me.cmbTipoAlmacenMedicamento.TabIndex = 1
        Me.cmbTipoAlmacenMedicamento.ValueMember = "Codigo"
        '
        'TipoAlmacenMedicamentoC
        '
        Me.TipoAlmacenMedicamentoC.AllowEdit = True
        Me.TipoAlmacenMedicamentoC.AllowNew = True
        Me.TipoAlmacenMedicamentoC.AllowRemove = True
        Me.TipoAlmacenMedicamentoC.Name = ""
        Me.TipoAlmacenMedicamentoC.RaiseListChangedEvents = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tipo Almacén Medicamento:"
        '
        'cmbTipoAlmacenFormula
        '
        Me.cmbTipoAlmacenFormula.DataSource = Me.TipoAlmacenFormulaC
        Me.cmbTipoAlmacenFormula.DisplayMember = "Descripcion"
        Me.cmbTipoAlmacenFormula.FormattingEnabled = True
        Me.cmbTipoAlmacenFormula.Location = New System.Drawing.Point(157, 11)
        Me.cmbTipoAlmacenFormula.Name = "cmbTipoAlmacenFormula"
        Me.cmbTipoAlmacenFormula.Size = New System.Drawing.Size(305, 21)
        Me.cmbTipoAlmacenFormula.TabIndex = 0
        Me.cmbTipoAlmacenFormula.ValueMember = "Codigo"
        '
        'TipoAlmacenFormulaC
        '
        Me.TipoAlmacenFormulaC.AllowEdit = True
        Me.TipoAlmacenFormulaC.AllowNew = True
        Me.TipoAlmacenFormulaC.AllowRemove = True
        Me.TipoAlmacenFormulaC.Name = ""
        Me.TipoAlmacenFormulaC.RaiseListChangedEvents = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tipo Almacén Formula:"
        '
        'frmConfiguracionEngorda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 351)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmConfiguracionEngorda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración de Engorda"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ultdtpFechaCierreDiario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtGDP As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents cmbTipoAlmacenRolado As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoAlmacenMedicamento As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoAlmacenFormula As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtImpuestoPredialXAnimal As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPorcentajeEducacion As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TipoAlmacenFormulaC As ClasesNegocio.TipoAlmacenCollectionClass
    Friend WithEvents TipoAlmacenMedicamentoC As ClasesNegocio.TipoAlmacenCollectionClass
    Friend WithEvents TipoAlmacenRoladoC As ClasesNegocio.TipoAlmacenCollectionClass
    Friend WithEvents cmbLinea As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LineaCollectionClass1 As ClasesNegocio.LineaCollectionClass
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbMesCostoIndirecto As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ultdtpFechaCierreDiario As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents lblFechaCierreInicial As System.Windows.Forms.Label
    Friend WithEvents chkRequerirArete As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCostoIndirectoMen As Integralab.Controles.TextBoxMejorado
    Friend WithEvents chkTransRecibaPorArete As System.Windows.Forms.CheckBox
End Class
