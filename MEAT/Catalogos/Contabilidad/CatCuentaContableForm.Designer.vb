<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CatCuentaContableForm
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gpo = New System.Windows.Forms.GroupBox()
        Me.txtSSSCtaBusq = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSSCtaBusq = New System.Windows.Forms.TextBox()
        Me.txtCtaBusq = New System.Windows.Forms.TextBox()
        Me.txtSCtaBusq = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.clmCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCuentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuentaContableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NaturalezaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoAñoAnteriorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoInicioEjercicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Afectable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InactivaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuentasContable = New ClasesNegocio.CuentaContableCollectionClass()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BtnQuitarCtaE = New System.Windows.Forms.Button()
        Me.btnCtaE = New System.Windows.Forms.Button()
        Me.txtCtaE = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbAfectable = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbNaturazleza = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txtfiltro = New System.Windows.Forms.TextBox()
        Me.cmbEstatus = New System.Windows.Forms.ComboBox()
        Me.Condiciones = New Integra.Clases.CondicionesClass()
        Me.pan = New System.Windows.Forms.Panel()
        Me.gpClasificador = New System.Windows.Forms.GroupBox()
        Me.cmbSubTitulo = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbTitulo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSSSCta = New System.Windows.Forms.TextBox()
        Me.txtSSCta = New System.Windows.Forms.TextBox()
        Me.txtSCta = New System.Windows.Forms.TextBox()
        Me.txtCta = New System.Windows.Forms.TextBox()
        Me.btnCta = New System.Windows.Forms.Button()
        Me.txtCtaC = New System.Windows.Forms.TextBox()
        Me.txtSdoIni = New Integra.Controles.TextboxDecimal()
        Me.txtSdoAnt = New Integra.Controles.TextboxDecimal()
        Me.gpoCaracteristicas = New System.Windows.Forms.GroupBox()
        Me.chkBancos = New System.Windows.Forms.CheckBox()
        Me.chkInactiva = New System.Windows.Forms.CheckBox()
        Me.chkDepartamentalizable = New System.Windows.Forms.CheckBox()
        Me.chkAfectable = New System.Windows.Forms.CheckBox()
        Me.chkPresupuestos = New System.Windows.Forms.CheckBox()
        Me.chkResultados = New System.Windows.Forms.CheckBox()
        Me.gpoNaturaleza = New System.Windows.Forms.GroupBox()
        Me.rdbAcredora = New System.Windows.Forms.RadioButton()
        Me.rdbDeudora = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.mtb = New MEAToolBar.MEAToolBar()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.gpo.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.pan.SuspendLayout()
        Me.gpClasificador.SuspendLayout()
        Me.gpoCaracteristicas.SuspendLayout()
        Me.gpoNaturaleza.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpo
        '
        Me.gpo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gpo.Controls.Add(Me.txtSSSCtaBusq)
        Me.gpo.Controls.Add(Me.Label11)
        Me.gpo.Controls.Add(Me.txtSSCtaBusq)
        Me.gpo.Controls.Add(Me.txtCtaBusq)
        Me.gpo.Controls.Add(Me.txtSCtaBusq)
        Me.gpo.Controls.Add(Me.TabControl1)
        Me.gpo.Controls.Add(Me.Label10)
        Me.gpo.Controls.Add(Me.cmbAfectable)
        Me.gpo.Controls.Add(Me.Label9)
        Me.gpo.Controls.Add(Me.cmbNaturazleza)
        Me.gpo.Controls.Add(Me.Label13)
        Me.gpo.Controls.Add(Me.Label7)
        Me.gpo.Controls.Add(Me.Txtfiltro)
        Me.gpo.Controls.Add(Me.cmbEstatus)
        Me.gpo.Location = New System.Drawing.Point(53, 214)
        Me.gpo.Name = "gpo"
        Me.gpo.Size = New System.Drawing.Size(859, 335)
        Me.gpo.TabIndex = 3
        Me.gpo.TabStop = False
        Me.gpo.Text = "Cuentas Contables Registradas"
        '
        'txtSSSCtaBusq
        '
        Me.txtSSSCtaBusq.Location = New System.Drawing.Point(358, 48)
        Me.txtSSSCtaBusq.MaxLength = 4
        Me.txtSSSCtaBusq.Name = "txtSSSCtaBusq"
        Me.txtSSSCtaBusq.Size = New System.Drawing.Size(85, 20)
        Me.txtSSSCtaBusq.TabIndex = 22
        Me.txtSSSCtaBusq.Text = "0000"
        Me.txtSSSCtaBusq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "No. Cuenta:"
        '
        'txtSSCtaBusq
        '
        Me.txtSSCtaBusq.Location = New System.Drawing.Point(277, 48)
        Me.txtSSCtaBusq.MaxLength = 4
        Me.txtSSCtaBusq.Name = "txtSSCtaBusq"
        Me.txtSSCtaBusq.Size = New System.Drawing.Size(85, 20)
        Me.txtSSCtaBusq.TabIndex = 21
        Me.txtSSCtaBusq.Text = "0000"
        Me.txtSSCtaBusq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCtaBusq
        '
        Me.txtCtaBusq.Location = New System.Drawing.Point(114, 48)
        Me.txtCtaBusq.MaxLength = 4
        Me.txtCtaBusq.Name = "txtCtaBusq"
        Me.txtCtaBusq.Size = New System.Drawing.Size(86, 20)
        Me.txtCtaBusq.TabIndex = 19
        Me.txtCtaBusq.Text = "0000"
        Me.txtCtaBusq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSCtaBusq
        '
        Me.txtSCtaBusq.Location = New System.Drawing.Point(195, 48)
        Me.txtSCtaBusq.MaxLength = 4
        Me.txtSCtaBusq.Name = "txtSCtaBusq"
        Me.txtSCtaBusq.Size = New System.Drawing.Size(85, 20)
        Me.txtSCtaBusq.TabIndex = 20
        Me.txtSCtaBusq.Text = "0000"
        Me.txtSCtaBusq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(11, 75)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(847, 254)
        Me.TabControl1.TabIndex = 24
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgv)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(839, 228)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cuentas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeRows = False
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.AutoGenerateColumns = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmCodigo, Me.NombreCuentaDataGridViewTextBoxColumn, Me.CuentaContableDataGridViewTextBoxColumn, Me.NaturalezaDataGridViewTextBoxColumn, Me.SaldoAñoAnteriorDataGridViewTextBoxColumn, Me.SaldoInicioEjercicioDataGridViewTextBoxColumn, Me.Afectable, Me.InactivaDataGridViewTextBoxColumn})
        Me.dgv.DataSource = Me.CuentasContable
        Me.dgv.Location = New System.Drawing.Point(3, 6)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.RowHeadersWidth = 25
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(830, 222)
        Me.dgv.TabIndex = 0
        '
        'clmCodigo
        '
        Me.clmCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmCodigo.DataPropertyName = "Codigo"
        Me.clmCodigo.Frozen = True
        Me.clmCodigo.HeaderText = "Código"
        Me.clmCodigo.Name = "clmCodigo"
        Me.clmCodigo.ReadOnly = True
        Me.clmCodigo.Visible = False
        '
        'NombreCuentaDataGridViewTextBoxColumn
        '
        Me.NombreCuentaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NombreCuentaDataGridViewTextBoxColumn.DataPropertyName = "NombreCuenta"
        Me.NombreCuentaDataGridViewTextBoxColumn.Frozen = True
        Me.NombreCuentaDataGridViewTextBoxColumn.HeaderText = "Nombre de Cuenta"
        Me.NombreCuentaDataGridViewTextBoxColumn.Name = "NombreCuentaDataGridViewTextBoxColumn"
        Me.NombreCuentaDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreCuentaDataGridViewTextBoxColumn.Width = 111
        '
        'CuentaContableDataGridViewTextBoxColumn
        '
        Me.CuentaContableDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CuentaContableDataGridViewTextBoxColumn.DataPropertyName = "CuentaContable"
        Me.CuentaContableDataGridViewTextBoxColumn.Frozen = True
        Me.CuentaContableDataGridViewTextBoxColumn.HeaderText = "Cuenta Contable"
        Me.CuentaContableDataGridViewTextBoxColumn.Name = "CuentaContableDataGridViewTextBoxColumn"
        Me.CuentaContableDataGridViewTextBoxColumn.ReadOnly = True
        Me.CuentaContableDataGridViewTextBoxColumn.Width = 102
        '
        'NaturalezaDataGridViewTextBoxColumn
        '
        Me.NaturalezaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NaturalezaDataGridViewTextBoxColumn.DataPropertyName = "Naturaleza"
        Me.NaturalezaDataGridViewTextBoxColumn.HeaderText = "Naturaleza"
        Me.NaturalezaDataGridViewTextBoxColumn.Name = "NaturalezaDataGridViewTextBoxColumn"
        Me.NaturalezaDataGridViewTextBoxColumn.ReadOnly = True
        Me.NaturalezaDataGridViewTextBoxColumn.Width = 83
        '
        'SaldoAñoAnteriorDataGridViewTextBoxColumn
        '
        Me.SaldoAñoAnteriorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SaldoAñoAnteriorDataGridViewTextBoxColumn.DataPropertyName = "SaldoAñoAnterior"
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.SaldoAñoAnteriorDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.SaldoAñoAnteriorDataGridViewTextBoxColumn.HeaderText = "Saldo del Año Anterior"
        Me.SaldoAñoAnteriorDataGridViewTextBoxColumn.Name = "SaldoAñoAnteriorDataGridViewTextBoxColumn"
        Me.SaldoAñoAnteriorDataGridViewTextBoxColumn.ReadOnly = True
        Me.SaldoAñoAnteriorDataGridViewTextBoxColumn.Width = 93
        '
        'SaldoInicioEjercicioDataGridViewTextBoxColumn
        '
        Me.SaldoInicioEjercicioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SaldoInicioEjercicioDataGridViewTextBoxColumn.DataPropertyName = "SaldoInicioEjercicio"
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.SaldoInicioEjercicioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.SaldoInicioEjercicioDataGridViewTextBoxColumn.HeaderText = "Saldo de Inicio del Ejercicio"
        Me.SaldoInicioEjercicioDataGridViewTextBoxColumn.Name = "SaldoInicioEjercicioDataGridViewTextBoxColumn"
        Me.SaldoInicioEjercicioDataGridViewTextBoxColumn.ReadOnly = True
        Me.SaldoInicioEjercicioDataGridViewTextBoxColumn.Width = 112
        '
        'Afectable
        '
        Me.Afectable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Afectable.DataPropertyName = "Afectable"
        Me.Afectable.HeaderText = "Afectable"
        Me.Afectable.Name = "Afectable"
        Me.Afectable.ReadOnly = True
        Me.Afectable.Width = 77
        '
        'InactivaDataGridViewTextBoxColumn
        '
        Me.InactivaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.InactivaDataGridViewTextBoxColumn.DataPropertyName = "Inactiva"
        Me.InactivaDataGridViewTextBoxColumn.HeaderText = "Inactiva"
        Me.InactivaDataGridViewTextBoxColumn.Name = "InactivaDataGridViewTextBoxColumn"
        Me.InactivaDataGridViewTextBoxColumn.ReadOnly = True
        Me.InactivaDataGridViewTextBoxColumn.Width = 70
        '
        'CuentasContable
        '
        Me.CuentasContable.AllowEdit = True
        Me.CuentasContable.AllowNew = True
        Me.CuentasContable.AllowRemove = True
        Me.CuentasContable.Name = Nothing
        Me.CuentasContable.RaiseListChangedEvents = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.BtnQuitarCtaE)
        Me.TabPage2.Controls.Add(Me.btnCtaE)
        Me.TabPage2.Controls.Add(Me.txtCtaE)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(839, 228)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "+ . . ."
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'BtnQuitarCtaE
        '
        Me.BtnQuitarCtaE.Location = New System.Drawing.Point(508, 17)
        Me.BtnQuitarCtaE.Name = "BtnQuitarCtaE"
        Me.BtnQuitarCtaE.Size = New System.Drawing.Size(26, 22)
        Me.BtnQuitarCtaE.TabIndex = 29
        Me.BtnQuitarCtaE.Text = "-"
        Me.BtnQuitarCtaE.UseVisualStyleBackColor = True
        '
        'btnCtaE
        '
        Me.btnCtaE.Location = New System.Drawing.Point(476, 17)
        Me.btnCtaE.Name = "btnCtaE"
        Me.btnCtaE.Size = New System.Drawing.Size(26, 22)
        Me.btnCtaE.TabIndex = 25
        Me.btnCtaE.Text = "+"
        Me.btnCtaE.UseVisualStyleBackColor = True
        '
        'txtCtaE
        '
        Me.txtCtaE.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCtaE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtaE.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtCtaE.Location = New System.Drawing.Point(68, 17)
        Me.txtCtaE.MaxLength = 50
        Me.txtCtaE.Name = "txtCtaE"
        Me.txtCtaE.ReadOnly = True
        Me.txtCtaE.Size = New System.Drawing.Size(402, 22)
        Me.txtCtaE.TabIndex = 24
        Me.txtCtaE.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "RF:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(643, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 13)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Caracteristicas:"
        '
        'cmbAfectable
        '
        Me.cmbAfectable.FormattingEnabled = True
        Me.cmbAfectable.Items.AddRange(New Object() {"TODAS", "AFECTABLE", "NO AFECTABLE"})
        Me.cmbAfectable.Location = New System.Drawing.Point(728, 13)
        Me.cmbAfectable.Name = "cmbAfectable"
        Me.cmbAfectable.Size = New System.Drawing.Size(117, 21)
        Me.cmbAfectable.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(450, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Naturaleza:"
        '
        'cmbNaturazleza
        '
        Me.cmbNaturazleza.FormattingEnabled = True
        Me.cmbNaturazleza.Items.AddRange(New Object() {"TODAS", "ACREDORA", "DEUDORA"})
        Me.cmbNaturazleza.Location = New System.Drawing.Point(517, 14)
        Me.cmbNaturazleza.Name = "cmbNaturazleza"
        Me.cmbNaturazleza.Size = New System.Drawing.Size(117, 21)
        Me.cmbNaturazleza.TabIndex = 17
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(8, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 13)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Buscar por Nombre:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(450, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Filtrar por:"
        '
        'Txtfiltro
        '
        Me.Txtfiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtfiltro.Location = New System.Drawing.Point(114, 17)
        Me.Txtfiltro.MaxLength = 100
        Me.Txtfiltro.Name = "Txtfiltro"
        Me.Txtfiltro.Size = New System.Drawing.Size(329, 20)
        Me.Txtfiltro.TabIndex = 16
        '
        'cmbEstatus
        '
        Me.cmbEstatus.DataSource = Me.Condiciones
        Me.cmbEstatus.DisplayMember = "Condicion"
        Me.cmbEstatus.FormattingEnabled = True
        Me.cmbEstatus.Location = New System.Drawing.Point(517, 49)
        Me.cmbEstatus.Name = "cmbEstatus"
        Me.cmbEstatus.Size = New System.Drawing.Size(117, 21)
        Me.cmbEstatus.TabIndex = 23
        Me.cmbEstatus.ValueMember = "Condicion"
        '
        'Condiciones
        '
        Me.Condiciones.AllowEdit = True
        Me.Condiciones.AllowNew = False
        Me.Condiciones.AllowRemove = True
        Me.Condiciones.Name = Nothing
        Me.Condiciones.RaiseListChangedEvents = True
        '
        'pan
        '
        Me.pan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pan.Controls.Add(Me.gpClasificador)
        Me.pan.Controls.Add(Me.txtSSSCta)
        Me.pan.Controls.Add(Me.txtSSCta)
        Me.pan.Controls.Add(Me.txtSCta)
        Me.pan.Controls.Add(Me.txtCta)
        Me.pan.Controls.Add(Me.btnCta)
        Me.pan.Controls.Add(Me.txtCtaC)
        Me.pan.Controls.Add(Me.txtSdoIni)
        Me.pan.Controls.Add(Me.txtSdoAnt)
        Me.pan.Controls.Add(Me.gpoCaracteristicas)
        Me.pan.Controls.Add(Me.gpoNaturaleza)
        Me.pan.Controls.Add(Me.Label4)
        Me.pan.Controls.Add(Me.Label2)
        Me.pan.Controls.Add(Me.Label3)
        Me.pan.Controls.Add(Me.Label8)
        Me.pan.Controls.Add(Me.Label1)
        Me.pan.Controls.Add(Me.txtNombre)
        Me.pan.Location = New System.Drawing.Point(55, 33)
        Me.pan.Name = "pan"
        Me.pan.Size = New System.Drawing.Size(858, 175)
        Me.pan.TabIndex = 2
        '
        'gpClasificador
        '
        Me.gpClasificador.Controls.Add(Me.cmbSubTitulo)
        Me.gpClasificador.Controls.Add(Me.Label12)
        Me.gpClasificador.Controls.Add(Me.cmbTitulo)
        Me.gpClasificador.Controls.Add(Me.Label6)
        Me.gpClasificador.Location = New System.Drawing.Point(443, 62)
        Me.gpClasificador.Name = "gpClasificador"
        Me.gpClasificador.Size = New System.Drawing.Size(277, 70)
        Me.gpClasificador.TabIndex = 16
        Me.gpClasificador.TabStop = False
        Me.gpClasificador.Text = "Clasificador de Estados Financieros"
        '
        'cmbSubTitulo
        '
        Me.cmbSubTitulo.FormattingEnabled = True
        Me.cmbSubTitulo.Location = New System.Drawing.Point(78, 43)
        Me.cmbSubTitulo.Name = "cmbSubTitulo"
        Me.cmbSubTitulo.Size = New System.Drawing.Size(193, 21)
        Me.cmbSubTitulo.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 47)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "SubTitulo :"
        '
        'cmbTitulo
        '
        Me.cmbTitulo.FormattingEnabled = True
        Me.cmbTitulo.Location = New System.Drawing.Point(78, 16)
        Me.cmbTitulo.Name = "cmbTitulo"
        Me.cmbTitulo.Size = New System.Drawing.Size(193, 21)
        Me.cmbTitulo.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Titulo :"
        '
        'txtSSSCta
        '
        Me.txtSSSCta.Location = New System.Drawing.Point(388, 10)
        Me.txtSSSCta.MaxLength = 4
        Me.txtSSSCta.Name = "txtSSSCta"
        Me.txtSSSCta.Size = New System.Drawing.Size(85, 20)
        Me.txtSSSCta.TabIndex = 5
        Me.txtSSSCta.Text = "0000"
        Me.txtSSSCta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSSCta
        '
        Me.txtSSCta.Location = New System.Drawing.Point(297, 10)
        Me.txtSSCta.MaxLength = 4
        Me.txtSSCta.Name = "txtSSCta"
        Me.txtSSCta.Size = New System.Drawing.Size(85, 20)
        Me.txtSSCta.TabIndex = 4
        Me.txtSSCta.Text = "0000"
        Me.txtSSCta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSCta
        '
        Me.txtSCta.Location = New System.Drawing.Point(206, 10)
        Me.txtSCta.MaxLength = 4
        Me.txtSCta.Name = "txtSCta"
        Me.txtSCta.Size = New System.Drawing.Size(85, 20)
        Me.txtSCta.TabIndex = 3
        Me.txtSCta.Text = "0000"
        Me.txtSCta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCta
        '
        Me.txtCta.Location = New System.Drawing.Point(115, 10)
        Me.txtCta.MaxLength = 4
        Me.txtCta.Name = "txtCta"
        Me.txtCta.Size = New System.Drawing.Size(85, 20)
        Me.txtCta.TabIndex = 2
        Me.txtCta.Text = "0000"
        Me.txtCta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCta
        '
        Me.btnCta.Location = New System.Drawing.Point(713, 36)
        Me.btnCta.Name = "btnCta"
        Me.btnCta.Size = New System.Drawing.Size(26, 22)
        Me.btnCta.TabIndex = 2
        Me.btnCta.Text = "..."
        Me.btnCta.UseVisualStyleBackColor = True
        Me.btnCta.Visible = False
        '
        'txtCtaC
        '
        Me.txtCtaC.BackColor = System.Drawing.Color.Bisque
        Me.txtCtaC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtaC.ForeColor = System.Drawing.Color.Black
        Me.txtCtaC.Location = New System.Drawing.Point(482, 8)
        Me.txtCtaC.Name = "txtCtaC"
        Me.txtCtaC.ReadOnly = True
        Me.txtCtaC.Size = New System.Drawing.Size(348, 22)
        Me.txtCtaC.TabIndex = 1
        Me.txtCtaC.TabStop = False
        Me.txtCtaC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCtaC.Visible = False
        '
        'txtSdoIni
        '
        Me.txtSdoIni.Decimales = CType(2UI, UInteger)
        Me.txtSdoIni.Location = New System.Drawing.Point(443, 140)
        Me.txtSdoIni.MaxLength = 20
        Me.txtSdoIni.Name = "txtSdoIni"
        Me.txtSdoIni.Signo = Integra.Controles.TextboxDecimal.RespuestaEnum.NO
        Me.txtSdoIni.Size = New System.Drawing.Size(166, 20)
        Me.txtSdoIni.TabIndex = 15
        Me.txtSdoIni.Text = "0.00"
        Me.txtSdoIni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSdoIni.Visible = False
        '
        'txtSdoAnt
        '
        Me.txtSdoAnt.Decimales = CType(2UI, UInteger)
        Me.txtSdoAnt.Location = New System.Drawing.Point(137, 140)
        Me.txtSdoAnt.Name = "txtSdoAnt"
        Me.txtSdoAnt.Signo = Integra.Controles.TextboxDecimal.RespuestaEnum.NO
        Me.txtSdoAnt.Size = New System.Drawing.Size(166, 20)
        Me.txtSdoAnt.TabIndex = 14
        Me.txtSdoAnt.Text = "0.00"
        Me.txtSdoAnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSdoAnt.Visible = False
        '
        'gpoCaracteristicas
        '
        Me.gpoCaracteristicas.Controls.Add(Me.chkBancos)
        Me.gpoCaracteristicas.Controls.Add(Me.chkInactiva)
        Me.gpoCaracteristicas.Controls.Add(Me.chkDepartamentalizable)
        Me.gpoCaracteristicas.Controls.Add(Me.chkAfectable)
        Me.gpoCaracteristicas.Controls.Add(Me.chkPresupuestos)
        Me.gpoCaracteristicas.Controls.Add(Me.chkResultados)
        Me.gpoCaracteristicas.Location = New System.Drawing.Point(116, 62)
        Me.gpoCaracteristicas.Name = "gpoCaracteristicas"
        Me.gpoCaracteristicas.Size = New System.Drawing.Size(321, 70)
        Me.gpoCaracteristicas.TabIndex = 12
        Me.gpoCaracteristicas.TabStop = False
        Me.gpoCaracteristicas.Text = "Caracteristicas"
        '
        'chkBancos
        '
        Me.chkBancos.AutoSize = True
        Me.chkBancos.Location = New System.Drawing.Point(137, 19)
        Me.chkBancos.Name = "chkBancos"
        Me.chkBancos.Size = New System.Drawing.Size(62, 17)
        Me.chkBancos.TabIndex = 11
        Me.chkBancos.Text = "Bancos"
        Me.chkBancos.UseVisualStyleBackColor = True
        '
        'chkInactiva
        '
        Me.chkInactiva.AutoSize = True
        Me.chkInactiva.Location = New System.Drawing.Point(220, 19)
        Me.chkInactiva.Name = "chkInactiva"
        Me.chkInactiva.Size = New System.Drawing.Size(64, 17)
        Me.chkInactiva.TabIndex = 12
        Me.chkInactiva.Text = "Inactiva"
        Me.chkInactiva.UseVisualStyleBackColor = True
        '
        'chkDepartamentalizable
        '
        Me.chkDepartamentalizable.AutoSize = True
        Me.chkDepartamentalizable.Location = New System.Drawing.Point(6, 47)
        Me.chkDepartamentalizable.Name = "chkDepartamentalizable"
        Me.chkDepartamentalizable.Size = New System.Drawing.Size(122, 17)
        Me.chkDepartamentalizable.TabIndex = 10
        Me.chkDepartamentalizable.Text = "Departamentalizable"
        Me.chkDepartamentalizable.UseVisualStyleBackColor = True
        '
        'chkAfectable
        '
        Me.chkAfectable.AutoSize = True
        Me.chkAfectable.Enabled = False
        Me.chkAfectable.Location = New System.Drawing.Point(137, 47)
        Me.chkAfectable.Name = "chkAfectable"
        Me.chkAfectable.Size = New System.Drawing.Size(71, 17)
        Me.chkAfectable.TabIndex = 13
        Me.chkAfectable.Text = "Afectable"
        Me.chkAfectable.UseVisualStyleBackColor = True
        '
        'chkPresupuestos
        '
        Me.chkPresupuestos.AutoSize = True
        Me.chkPresupuestos.Location = New System.Drawing.Point(220, 46)
        Me.chkPresupuestos.Name = "chkPresupuestos"
        Me.chkPresupuestos.Size = New System.Drawing.Size(90, 17)
        Me.chkPresupuestos.TabIndex = 9
        Me.chkPresupuestos.Text = "Presupuestos"
        Me.chkPresupuestos.UseVisualStyleBackColor = True
        '
        'chkResultados
        '
        Me.chkResultados.AutoSize = True
        Me.chkResultados.Location = New System.Drawing.Point(6, 19)
        Me.chkResultados.Name = "chkResultados"
        Me.chkResultados.Size = New System.Drawing.Size(79, 17)
        Me.chkResultados.TabIndex = 8
        Me.chkResultados.Text = "Resultados"
        Me.chkResultados.UseVisualStyleBackColor = True
        '
        'gpoNaturaleza
        '
        Me.gpoNaturaleza.Controls.Add(Me.rdbAcredora)
        Me.gpoNaturaleza.Controls.Add(Me.rdbDeudora)
        Me.gpoNaturaleza.Location = New System.Drawing.Point(10, 62)
        Me.gpoNaturaleza.Name = "gpoNaturaleza"
        Me.gpoNaturaleza.Size = New System.Drawing.Size(99, 70)
        Me.gpoNaturaleza.TabIndex = 11
        Me.gpoNaturaleza.TabStop = False
        Me.gpoNaturaleza.Text = "Naturaleza"
        '
        'rdbAcredora
        '
        Me.rdbAcredora.AutoSize = True
        Me.rdbAcredora.Location = New System.Drawing.Point(8, 19)
        Me.rdbAcredora.Name = "rdbAcredora"
        Me.rdbAcredora.Size = New System.Drawing.Size(68, 17)
        Me.rdbAcredora.TabIndex = 7
        Me.rdbAcredora.TabStop = True
        Me.rdbAcredora.Text = "Acredora"
        Me.rdbAcredora.UseVisualStyleBackColor = True
        '
        'rdbDeudora
        '
        Me.rdbDeudora.AutoSize = True
        Me.rdbDeudora.Location = New System.Drawing.Point(8, 42)
        Me.rdbDeudora.Name = "rdbDeudora"
        Me.rdbDeudora.Size = New System.Drawing.Size(66, 17)
        Me.rdbDeudora.TabIndex = 8
        Me.rdbDeudora.TabStop = True
        Me.rdbDeudora.Text = "Deudora"
        Me.rdbDeudora.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(312, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Saldo Inicio del Ejercicio:"
        Me.Label4.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "No. Cuenta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Saldo Año Anterior:"
        Me.Label3.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(479, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Cuenta Mayor:"
        Me.Label8.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(115, 36)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(588, 20)
        Me.txtNombre.TabIndex = 6
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
        Me.mtb.Location = New System.Drawing.Point(0, 29)
        Me.mtb.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.mtb.MostrarBorrar = False
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
        Me.mtb.Size = New System.Drawing.Size(50, 690)
        Me.mtb.TabIndex = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(928, 30)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "CATÁLOGO DE CUENTAS CONTABLES"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'CatCuentaContableForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 552)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.gpo)
        Me.Controls.Add(Me.pan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CatCuentaContableForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuentas Contables"
        Me.gpo.ResumeLayout(False)
        Me.gpo.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.pan.ResumeLayout(False)
        Me.pan.PerformLayout()
        Me.gpClasificador.ResumeLayout(False)
        Me.gpClasificador.PerformLayout()
        Me.gpoCaracteristicas.ResumeLayout(False)
        Me.gpoCaracteristicas.PerformLayout()
        Me.gpoNaturaleza.ResumeLayout(False)
        Me.gpoNaturaleza.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gpo As System.Windows.Forms.GroupBox
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents pan As System.Windows.Forms.Panel
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents gpoNaturaleza As System.Windows.Forms.GroupBox
    Friend WithEvents rdbAcredora As System.Windows.Forms.RadioButton
    Friend WithEvents rdbDeudora As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gpoCaracteristicas As System.Windows.Forms.GroupBox
    Friend WithEvents chkInactiva As System.Windows.Forms.CheckBox
    Friend WithEvents chkDepartamentalizable As System.Windows.Forms.CheckBox
    Friend WithEvents chkAfectable As System.Windows.Forms.CheckBox
    Friend WithEvents chkPresupuestos As System.Windows.Forms.CheckBox
    Friend WithEvents chkResultados As System.Windows.Forms.CheckBox
    Friend WithEvents txtSdoIni As Integra.Controles.TextboxDecimal
    Friend WithEvents txtSdoAnt As Integra.Controles.TextboxDecimal
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CuentasContable As ClasesNegocio.CuentaContableCollectionClass
    Friend WithEvents chkBancos As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnCta As System.Windows.Forms.Button
    Friend WithEvents txtCtaC As System.Windows.Forms.TextBox
    Friend WithEvents Condiciones As Integra.Clases.CondicionesClass
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbEstatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Txtfiltro As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbNaturazleza As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbAfectable As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnCtaE As System.Windows.Forms.Button
    Friend WithEvents txtCtaE As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnQuitarCtaE As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCta As System.Windows.Forms.TextBox
    Friend WithEvents txtSSSCta As System.Windows.Forms.TextBox
    Friend WithEvents txtSSCta As System.Windows.Forms.TextBox
    Friend WithEvents txtSCta As System.Windows.Forms.TextBox
    Friend WithEvents txtSSSCtaBusq As System.Windows.Forms.TextBox
    Friend WithEvents txtSSCtaBusq As System.Windows.Forms.TextBox
    Friend WithEvents txtSCtaBusq As System.Windows.Forms.TextBox
    Friend WithEvents txtCtaBusq As System.Windows.Forms.TextBox
    Friend WithEvents clmCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreCuentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CuentaContableDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NaturalezaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoAñoAnteriorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoInicioEjercicioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Afectable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InactivaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gpClasificador As System.Windows.Forms.GroupBox
    Friend WithEvents cmbSubTitulo As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbTitulo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
End Class
