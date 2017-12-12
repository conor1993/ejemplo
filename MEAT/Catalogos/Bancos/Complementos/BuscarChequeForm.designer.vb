<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarChequeForm
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.chkAnt = New System.Windows.Forms.CheckBox
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.FolioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BancoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CuentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BeneficiarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaDocumentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoCambioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AnticipoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.MedioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cheques = New ClasesNegocio.ChequeCollectionClass
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbBeneficiario = New System.Windows.Forms.ComboBox
        Me.Beneficiarios = New ClasesNegocio.BeneficiarioCollectionClass
        Me.txtBeneficiario = New System.Windows.Forms.TextBox
        Me.chkEle = New System.Windows.Forms.CheckBox
        Me.txtFolio = New System.Windows.Forms.TextBox
        Me.gpoTipo = New System.Windows.Forms.GroupBox
        Me.rdbTras = New System.Windows.Forms.RadioButton
        Me.rdbAbodiv = New System.Windows.Forms.RadioButton
        Me.rdbCardiv = New System.Windows.Forms.RadioButton
        Me.rdbTod = New System.Windows.Forms.RadioButton
        Me.rdbRet = New System.Windows.Forms.RadioButton
        Me.rdbDep = New System.Windows.Forms.RadioButton
        Me.chkActivos = New System.Windows.Forms.CheckBox
        Me.chkInactivos = New System.Windows.Forms.CheckBox
        Me.txtCodBeneficiario = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chkCheque = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.mtb = New MEAToolBar.MEAToolBar
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpoTipo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkAnt
        '
        Me.chkAnt.AutoSize = True
        Me.chkAnt.Location = New System.Drawing.Point(43, 13)
        Me.chkAnt.Name = "chkAnt"
        Me.chkAnt.Size = New System.Drawing.Size(64, 17)
        Me.chkAnt.TabIndex = 6
        Me.chkAnt.Text = "Anticipo"
        Me.chkAnt.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.AutoGenerateColumns = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FolioDataGridViewTextBoxColumn, Me.BancoDataGridViewTextBoxColumn, Me.CuentaDataGridViewTextBoxColumn, Me.BeneficiarioDataGridViewTextBoxColumn, Me.FechaDocumentoDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn, Me.TipoCambioDataGridViewTextBoxColumn, Me.AnticipoDataGridViewCheckBoxColumn, Me.MedioDataGridViewTextBoxColumn, Me.EstatusDataGridViewTextBoxColumn})
        Me.dgv.DataSource = Me.Cheques
        Me.dgv.Location = New System.Drawing.Point(56, 148)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.RowHeadersWidth = 25
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(739, 275)
        Me.dgv.TabIndex = 9
        '
        'FolioDataGridViewTextBoxColumn
        '
        Me.FolioDataGridViewTextBoxColumn.DataPropertyName = "Folio"
        Me.FolioDataGridViewTextBoxColumn.HeaderText = "Folio"
        Me.FolioDataGridViewTextBoxColumn.Name = "FolioDataGridViewTextBoxColumn"
        Me.FolioDataGridViewTextBoxColumn.ReadOnly = True
        Me.FolioDataGridViewTextBoxColumn.Width = 40
        '
        'BancoDataGridViewTextBoxColumn
        '
        Me.BancoDataGridViewTextBoxColumn.DataPropertyName = "Banco"
        Me.BancoDataGridViewTextBoxColumn.HeaderText = "Banco"
        Me.BancoDataGridViewTextBoxColumn.Name = "BancoDataGridViewTextBoxColumn"
        Me.BancoDataGridViewTextBoxColumn.ReadOnly = True
        Me.BancoDataGridViewTextBoxColumn.Width = 115
        '
        'CuentaDataGridViewTextBoxColumn
        '
        Me.CuentaDataGridViewTextBoxColumn.DataPropertyName = "Cuenta"
        Me.CuentaDataGridViewTextBoxColumn.HeaderText = "Cuenta Bancaria"
        Me.CuentaDataGridViewTextBoxColumn.Name = "CuentaDataGridViewTextBoxColumn"
        Me.CuentaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CuentaDataGridViewTextBoxColumn.Width = 115
        '
        'BeneficiarioDataGridViewTextBoxColumn
        '
        Me.BeneficiarioDataGridViewTextBoxColumn.DataPropertyName = "Beneficiario"
        Me.BeneficiarioDataGridViewTextBoxColumn.HeaderText = "Beneficiario"
        Me.BeneficiarioDataGridViewTextBoxColumn.Name = "BeneficiarioDataGridViewTextBoxColumn"
        Me.BeneficiarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.BeneficiarioDataGridViewTextBoxColumn.Visible = False
        Me.BeneficiarioDataGridViewTextBoxColumn.Width = 200
        '
        'FechaDocumentoDataGridViewTextBoxColumn
        '
        Me.FechaDocumentoDataGridViewTextBoxColumn.DataPropertyName = "FechaDocumento"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.FechaDocumentoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.FechaDocumentoDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDocumentoDataGridViewTextBoxColumn.Name = "FechaDocumentoDataGridViewTextBoxColumn"
        Me.FechaDocumentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ImporteDataGridViewTextBoxColumn
        '
        Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "Importe"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.ImporteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
        Me.ImporteDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImporteDataGridViewTextBoxColumn.Width = 90
        '
        'TipoCambioDataGridViewTextBoxColumn
        '
        Me.TipoCambioDataGridViewTextBoxColumn.DataPropertyName = "TipoCambio"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.TipoCambioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.TipoCambioDataGridViewTextBoxColumn.HeaderText = "T. C."
        Me.TipoCambioDataGridViewTextBoxColumn.Name = "TipoCambioDataGridViewTextBoxColumn"
        Me.TipoCambioDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoCambioDataGridViewTextBoxColumn.Width = 60
        '
        'AnticipoDataGridViewCheckBoxColumn
        '
        Me.AnticipoDataGridViewCheckBoxColumn.DataPropertyName = "Anticipo"
        Me.AnticipoDataGridViewCheckBoxColumn.HeaderText = "Anticipo"
        Me.AnticipoDataGridViewCheckBoxColumn.Name = "AnticipoDataGridViewCheckBoxColumn"
        Me.AnticipoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.AnticipoDataGridViewCheckBoxColumn.Width = 55
        '
        'MedioDataGridViewTextBoxColumn
        '
        Me.MedioDataGridViewTextBoxColumn.DataPropertyName = "Medio"
        Me.MedioDataGridViewTextBoxColumn.HeaderText = "Medio"
        Me.MedioDataGridViewTextBoxColumn.Name = "MedioDataGridViewTextBoxColumn"
        Me.MedioDataGridViewTextBoxColumn.ReadOnly = True
        Me.MedioDataGridViewTextBoxColumn.Width = 80
        '
        'EstatusDataGridViewTextBoxColumn
        '
        Me.EstatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.HeaderText = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.Name = "EstatusDataGridViewTextBoxColumn"
        Me.EstatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstatusDataGridViewTextBoxColumn.Width = 80
        '
        'Cheques
        '
        Me.Cheques.AllowEdit = True
        Me.Cheques.AllowNew = True
        Me.Cheques.AllowRemove = True
        Me.Cheques.MaximoElementosSeleccionados = 1
        Me.Cheques.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.Cheques.MostrarAlertas = False
        Me.Cheques.Name = Nothing
        Me.Cheques.RaiseListChangedEvents = True
        Me.Cheques.Transaction = Nothing
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(51, 0)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(762, 30)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Label1"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(242, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Folio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(242, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Beneficiario:"
        '
        'cmbBeneficiario
        '
        Me.cmbBeneficiario.DataSource = Me.Beneficiarios
        Me.cmbBeneficiario.DisplayMember = "Beneficiario"
        Me.cmbBeneficiario.Enabled = False
        Me.cmbBeneficiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBeneficiario.FormattingEnabled = True
        Me.cmbBeneficiario.Location = New System.Drawing.Point(313, 38)
        Me.cmbBeneficiario.Name = "cmbBeneficiario"
        Me.cmbBeneficiario.Size = New System.Drawing.Size(480, 23)
        Me.cmbBeneficiario.TabIndex = 3
        Me.cmbBeneficiario.ValueMember = "Beneficiario"
        '
        'Beneficiarios
        '
        Me.Beneficiarios.AllowEdit = True
        Me.Beneficiarios.AllowNew = True
        Me.Beneficiarios.AllowRemove = True
        Me.Beneficiarios.Name = Nothing
        Me.Beneficiarios.RaiseListChangedEvents = True
        '
        'txtBeneficiario
        '
        Me.txtBeneficiario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBeneficiario.Enabled = False
        Me.txtBeneficiario.Location = New System.Drawing.Point(56, 456)
        Me.txtBeneficiario.Name = "txtBeneficiario"
        Me.txtBeneficiario.ReadOnly = True
        Me.txtBeneficiario.Size = New System.Drawing.Size(194, 20)
        Me.txtBeneficiario.TabIndex = 2
        Me.txtBeneficiario.Visible = False
        '
        'chkEle
        '
        Me.chkEle.AutoSize = True
        Me.chkEle.Checked = True
        Me.chkEle.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEle.Location = New System.Drawing.Point(92, 15)
        Me.chkEle.Name = "chkEle"
        Me.chkEle.Size = New System.Drawing.Size(79, 17)
        Me.chkEle.TabIndex = 7
        Me.chkEle.Text = "Electronico"
        Me.chkEle.UseVisualStyleBackColor = True
        '
        'txtFolio
        '
        Me.txtFolio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFolio.Location = New System.Drawing.Point(313, 74)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(153, 22)
        Me.txtFolio.TabIndex = 5
        Me.txtFolio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gpoTipo
        '
        Me.gpoTipo.Controls.Add(Me.rdbTras)
        Me.gpoTipo.Controls.Add(Me.rdbAbodiv)
        Me.gpoTipo.Controls.Add(Me.rdbCardiv)
        Me.gpoTipo.Controls.Add(Me.rdbTod)
        Me.gpoTipo.Controls.Add(Me.rdbRet)
        Me.gpoTipo.Controls.Add(Me.rdbDep)
        Me.gpoTipo.Location = New System.Drawing.Point(472, 63)
        Me.gpoTipo.Name = "gpoTipo"
        Me.gpoTipo.Size = New System.Drawing.Size(321, 79)
        Me.gpoTipo.TabIndex = 13
        Me.gpoTipo.TabStop = False
        Me.gpoTipo.Text = "Tipo Movimiento"
        '
        'rdbTras
        '
        Me.rdbTras.AutoSize = True
        Me.rdbTras.Location = New System.Drawing.Point(233, 50)
        Me.rdbTras.Name = "rdbTras"
        Me.rdbTras.Size = New System.Drawing.Size(74, 17)
        Me.rdbTras.TabIndex = 3
        Me.rdbTras.TabStop = True
        Me.rdbTras.Text = "Traspasos"
        Me.rdbTras.UseVisualStyleBackColor = True
        '
        'rdbAbodiv
        '
        Me.rdbAbodiv.AutoSize = True
        Me.rdbAbodiv.Location = New System.Drawing.Point(122, 50)
        Me.rdbAbodiv.Name = "rdbAbodiv"
        Me.rdbAbodiv.Size = New System.Drawing.Size(105, 17)
        Me.rdbAbodiv.TabIndex = 2
        Me.rdbAbodiv.TabStop = True
        Me.rdbAbodiv.Text = "Abonos Diversos"
        Me.rdbAbodiv.UseVisualStyleBackColor = True
        '
        'rdbCardiv
        '
        Me.rdbCardiv.AutoSize = True
        Me.rdbCardiv.Location = New System.Drawing.Point(14, 50)
        Me.rdbCardiv.Name = "rdbCardiv"
        Me.rdbCardiv.Size = New System.Drawing.Size(102, 17)
        Me.rdbCardiv.TabIndex = 1
        Me.rdbCardiv.TabStop = True
        Me.rdbCardiv.Text = "Cargos Diversos"
        Me.rdbCardiv.UseVisualStyleBackColor = True
        '
        'rdbTod
        '
        Me.rdbTod.AutoSize = True
        Me.rdbTod.Location = New System.Drawing.Point(233, 21)
        Me.rdbTod.Name = "rdbTod"
        Me.rdbTod.Size = New System.Drawing.Size(55, 17)
        Me.rdbTod.TabIndex = 0
        Me.rdbTod.TabStop = True
        Me.rdbTod.Text = "Todos"
        Me.rdbTod.UseVisualStyleBackColor = True
        '
        'rdbRet
        '
        Me.rdbRet.AutoSize = True
        Me.rdbRet.Location = New System.Drawing.Point(122, 21)
        Me.rdbRet.Name = "rdbRet"
        Me.rdbRet.Size = New System.Drawing.Size(58, 17)
        Me.rdbRet.TabIndex = 0
        Me.rdbRet.TabStop = True
        Me.rdbRet.Text = "Retiros"
        Me.rdbRet.UseVisualStyleBackColor = True
        '
        'rdbDep
        '
        Me.rdbDep.AutoSize = True
        Me.rdbDep.Location = New System.Drawing.Point(14, 21)
        Me.rdbDep.Name = "rdbDep"
        Me.rdbDep.Size = New System.Drawing.Size(72, 17)
        Me.rdbDep.TabIndex = 0
        Me.rdbDep.TabStop = True
        Me.rdbDep.Text = "Depositos"
        Me.rdbDep.UseVisualStyleBackColor = True
        '
        'chkActivos
        '
        Me.chkActivos.AutoSize = True
        Me.chkActivos.Checked = True
        Me.chkActivos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivos.Location = New System.Drawing.Point(16, 15)
        Me.chkActivos.Name = "chkActivos"
        Me.chkActivos.Size = New System.Drawing.Size(61, 17)
        Me.chkActivos.TabIndex = 14
        Me.chkActivos.Text = "Activos"
        Me.chkActivos.UseVisualStyleBackColor = True
        '
        'chkInactivos
        '
        Me.chkInactivos.AutoSize = True
        Me.chkInactivos.Checked = True
        Me.chkInactivos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkInactivos.Location = New System.Drawing.Point(92, 15)
        Me.chkInactivos.Name = "chkInactivos"
        Me.chkInactivos.Size = New System.Drawing.Size(69, 17)
        Me.chkInactivos.TabIndex = 15
        Me.chkInactivos.Text = "Inactivos"
        Me.chkInactivos.UseVisualStyleBackColor = True
        '
        'txtCodBeneficiario
        '
        Me.txtCodBeneficiario.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodBeneficiario.Enabled = False
        Me.txtCodBeneficiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodBeneficiario.Location = New System.Drawing.Point(144, 38)
        Me.txtCodBeneficiario.MaxLength = 10
        Me.txtCodBeneficiario.Name = "txtCodBeneficiario"
        Me.txtCodBeneficiario.Size = New System.Drawing.Size(92, 22)
        Me.txtCodBeneficiario.TabIndex = 16
        Me.txtCodBeneficiario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(53, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "No. Beneficiario:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkActivos)
        Me.GroupBox1.Controls.Add(Me.chkInactivos)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(180, 38)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Estatus"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkCheque)
        Me.GroupBox2.Controls.Add(Me.chkEle)
        Me.GroupBox2.Location = New System.Drawing.Point(56, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(180, 38)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Medio"
        '
        'chkCheque
        '
        Me.chkCheque.AutoSize = True
        Me.chkCheque.Checked = True
        Me.chkCheque.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCheque.Location = New System.Drawing.Point(16, 15)
        Me.chkCheque.Name = "chkCheque"
        Me.chkCheque.Size = New System.Drawing.Size(63, 17)
        Me.chkCheque.TabIndex = 8
        Me.chkCheque.Text = "Cheque"
        Me.chkCheque.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkAnt)
        Me.GroupBox3.Location = New System.Drawing.Point(313, 106)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(153, 35)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        '
        'mtb
        '
        Me.mtb.ButtonSize = New System.Drawing.Size(50, 50)
        Me.mtb.Dock = System.Windows.Forms.DockStyle.Left
        Me.mtb.DropDownArrows = True
        Me.mtb.HabilitarBorrar = False
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
        Me.mtb.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
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
        Me.mtb.Size = New System.Drawing.Size(50, 435)
        Me.mtb.TabIndex = 182
        '
        'BuscarChequeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 435)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodBeneficiario)
        Me.Controls.Add(Me.gpoTipo)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbBeneficiario)
        Me.Controls.Add(Me.txtBeneficiario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "BuscarChequeForm"
        Me.Text = "Busqueda de Movimientos Bancarios"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpoTipo.ResumeLayout(False)
        Me.gpoTipo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkAnt As System.Windows.Forms.CheckBox
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Cheques As ClasesNegocio.ChequeCollectionClass
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbBeneficiario As System.Windows.Forms.ComboBox
    Friend WithEvents txtBeneficiario As System.Windows.Forms.TextBox
    Friend WithEvents chkEle As System.Windows.Forms.CheckBox
    Friend WithEvents Beneficiarios As ClasesNegocio.BeneficiarioCollectionClass
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents gpoTipo As System.Windows.Forms.GroupBox
    Friend WithEvents rdbTod As System.Windows.Forms.RadioButton
    Friend WithEvents rdbRet As System.Windows.Forms.RadioButton
    Friend WithEvents rdbDep As System.Windows.Forms.RadioButton
    Friend WithEvents rdbTras As System.Windows.Forms.RadioButton
    Friend WithEvents rdbAbodiv As System.Windows.Forms.RadioButton
    Friend WithEvents rdbCardiv As System.Windows.Forms.RadioButton
    Friend WithEvents FolioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BancoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CuentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BeneficiarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDocumentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoCambioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnticipoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MedioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkActivos As System.Windows.Forms.CheckBox
    Friend WithEvents chkInactivos As System.Windows.Forms.CheckBox
    Friend WithEvents txtCodBeneficiario As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCheque As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
End Class
