<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCuentasContables
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCuentasContables))
        Me.txtCtaC = New System.Windows.Forms.TextBox
        Me.gpo = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtSSSCtaBusq = New Integra.Controles.TextboxNumerico
        Me.txtSSCtaBusq = New Integra.Controles.TextboxNumerico
        Me.txtSctaBusq = New Integra.Controles.TextboxNumerico
        Me.txtCtaBusq = New Integra.Controles.TextboxNumerico
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmbAfectable = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmbNaturazleza = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Txtfiltro = New System.Windows.Forms.TextBox
        Me.cmbEstatus = New System.Windows.Forms.ComboBox
        Me.Condiciones = New Integra.Clases.CondicionesClass
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.CuentasContable = New ClasesNegocio.CuentaContableCollectionClass
        Me.btnCta = New System.Windows.Forms.Button
        Me.pan = New System.Windows.Forms.Panel
        Me.txtSSSCta = New System.Windows.Forms.TextBox
        Me.txtSSCta = New System.Windows.Forms.TextBox
        Me.txtSCta = New System.Windows.Forms.TextBox
        Me.txtCta = New System.Windows.Forms.TextBox
        Me.txtSdoIni = New Integra.Controles.TextboxDecimal
        Me.txtSdoAnt = New Integra.Controles.TextboxDecimal
        Me.gpoCaracteristicas = New System.Windows.Forms.GroupBox
        Me.chkBancos = New System.Windows.Forms.CheckBox
        Me.chkInactiva = New System.Windows.Forms.CheckBox
        Me.chkDepartamentalizable = New System.Windows.Forms.CheckBox
        Me.chkAfectable = New System.Windows.Forms.CheckBox
        Me.chkPresupuestos = New System.Windows.Forms.CheckBox
        Me.chkResultados = New System.Windows.Forms.CheckBox
        Me.gpoNaturaleza = New System.Windows.Forms.GroupBox
        Me.rdbAcredora = New System.Windows.Forms.RadioButton
        Me.rdbDeudora = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreCuentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CuentaContableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NaturalezaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaldoAñoAnteriorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaldoInicioEjercicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Afectable = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InactivaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmCuentaMayor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmSubCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmSSubCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmSSSubCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gpo.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan.SuspendLayout()
        Me.gpoCaracteristicas.SuspendLayout()
        Me.gpoNaturaleza.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCtaC
        '
        Me.txtCtaC.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCtaC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtaC.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtCtaC.Location = New System.Drawing.Point(115, 8)
        Me.txtCtaC.MaxLength = 100
        Me.txtCtaC.Name = "txtCtaC"
        Me.txtCtaC.ReadOnly = True
        Me.txtCtaC.Size = New System.Drawing.Size(338, 22)
        Me.txtCtaC.TabIndex = 1
        Me.txtCtaC.TabStop = False
        '
        'gpo
        '
        Me.gpo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpo.Controls.Add(Me.Label5)
        Me.gpo.Controls.Add(Me.txtSSSCtaBusq)
        Me.gpo.Controls.Add(Me.txtSSCtaBusq)
        Me.gpo.Controls.Add(Me.txtSctaBusq)
        Me.gpo.Controls.Add(Me.txtCtaBusq)
        Me.gpo.Controls.Add(Me.Label10)
        Me.gpo.Controls.Add(Me.cmbAfectable)
        Me.gpo.Controls.Add(Me.Label9)
        Me.gpo.Controls.Add(Me.cmbNaturazleza)
        Me.gpo.Controls.Add(Me.Label13)
        Me.gpo.Controls.Add(Me.Label7)
        Me.gpo.Controls.Add(Me.Txtfiltro)
        Me.gpo.Controls.Add(Me.cmbEstatus)
        Me.gpo.Controls.Add(Me.dgv)
        Me.gpo.Location = New System.Drawing.Point(49, 232)
        Me.gpo.Name = "gpo"
        Me.gpo.Size = New System.Drawing.Size(920, 335)
        Me.gpo.TabIndex = 7
        Me.gpo.TabStop = False
        Me.gpo.Text = "Cuentas Contables Registradas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "No. Cuenta:"
        '
        'txtSSSCtaBusq
        '
        Me.txtSSSCtaBusq.Location = New System.Drawing.Point(351, 44)
        Me.txtSSSCtaBusq.MaxLength = 4
        Me.txtSSSCtaBusq.Name = "txtSSSCtaBusq"
        Me.txtSSSCtaBusq.Posiciones = 5
        Me.txtSSSCtaBusq.Size = New System.Drawing.Size(80, 20)
        Me.txtSSSCtaBusq.TabIndex = 52
        Me.txtSSSCtaBusq.Text = "0000"
        Me.txtSSSCtaBusq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSSCtaBusq
        '
        Me.txtSSCtaBusq.Location = New System.Drawing.Point(271, 44)
        Me.txtSSCtaBusq.MaxLength = 4
        Me.txtSSCtaBusq.Name = "txtSSCtaBusq"
        Me.txtSSCtaBusq.Posiciones = 5
        Me.txtSSCtaBusq.Size = New System.Drawing.Size(80, 20)
        Me.txtSSCtaBusq.TabIndex = 51
        Me.txtSSCtaBusq.Text = "0000"
        Me.txtSSCtaBusq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSctaBusq
        '
        Me.txtSctaBusq.Location = New System.Drawing.Point(192, 44)
        Me.txtSctaBusq.MaxLength = 4
        Me.txtSctaBusq.Name = "txtSctaBusq"
        Me.txtSctaBusq.Posiciones = 5
        Me.txtSctaBusq.Size = New System.Drawing.Size(80, 20)
        Me.txtSctaBusq.TabIndex = 50
        Me.txtSctaBusq.Text = "0000"
        Me.txtSctaBusq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCtaBusq
        '
        Me.txtCtaBusq.Location = New System.Drawing.Point(113, 44)
        Me.txtCtaBusq.MaxLength = 4
        Me.txtCtaBusq.Name = "txtCtaBusq"
        Me.txtCtaBusq.Posiciones = 5
        Me.txtCtaBusq.Size = New System.Drawing.Size(80, 20)
        Me.txtCtaBusq.TabIndex = 49
        Me.txtCtaBusq.Text = "0000"
        Me.txtCtaBusq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(693, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 13)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Caracteristicas:"
        '
        'cmbAfectable
        '
        Me.cmbAfectable.FormattingEnabled = True
        Me.cmbAfectable.Items.AddRange(New Object() {"TODAS", "AFECTABLE", "NO AFECTABLE"})
        Me.cmbAfectable.Location = New System.Drawing.Point(778, 18)
        Me.cmbAfectable.Name = "cmbAfectable"
        Me.cmbAfectable.Size = New System.Drawing.Size(128, 21)
        Me.cmbAfectable.TabIndex = 46
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(479, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Naturaleza:"
        '
        'cmbNaturazleza
        '
        Me.cmbNaturazleza.FormattingEnabled = True
        Me.cmbNaturazleza.Items.AddRange(New Object() {"TODAS", "ACREDORA", "DEUDORA"})
        Me.cmbNaturazleza.Location = New System.Drawing.Point(546, 18)
        Me.cmbNaturazleza.Name = "cmbNaturazleza"
        Me.cmbNaturazleza.Size = New System.Drawing.Size(117, 21)
        Me.cmbNaturazleza.TabIndex = 44
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
        Me.Label7.Location = New System.Drawing.Point(479, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Filtrar por:"
        '
        'Txtfiltro
        '
        Me.Txtfiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtfiltro.Location = New System.Drawing.Point(114, 18)
        Me.Txtfiltro.MaxLength = 50
        Me.Txtfiltro.Name = "Txtfiltro"
        Me.Txtfiltro.Size = New System.Drawing.Size(339, 20)
        Me.Txtfiltro.TabIndex = 42
        '
        'cmbEstatus
        '
        Me.cmbEstatus.DataSource = Me.Condiciones
        Me.cmbEstatus.DisplayMember = "Condicion"
        Me.cmbEstatus.FormattingEnabled = True
        Me.cmbEstatus.Location = New System.Drawing.Point(546, 44)
        Me.cmbEstatus.Name = "cmbEstatus"
        Me.cmbEstatus.Size = New System.Drawing.Size(117, 21)
        Me.cmbEstatus.TabIndex = 6
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
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmCodigo, Me.NombreCuentaDataGridViewTextBoxColumn, Me.CuentaContableDataGridViewTextBoxColumn, Me.NaturalezaDataGridViewTextBoxColumn, Me.SaldoAñoAnteriorDataGridViewTextBoxColumn, Me.SaldoInicioEjercicioDataGridViewTextBoxColumn, Me.Afectable, Me.InactivaDataGridViewTextBoxColumn, Me.ClmCuentaMayor, Me.ClmSubCuenta, Me.ClmSSubCuenta, Me.ClmSSSubCuenta})
        Me.dgv.DataSource = Me.CuentasContable
        Me.dgv.Location = New System.Drawing.Point(6, 72)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.RowHeadersWidth = 25
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(908, 259)
        Me.dgv.TabIndex = 0
        '
        'CuentasContable
        '
        Me.CuentasContable.AllowEdit = True
        Me.CuentasContable.AllowNew = True
        Me.CuentasContable.AllowRemove = True
        Me.CuentasContable.Name = Nothing
        Me.CuentasContable.RaiseListChangedEvents = True
        '
        'btnCta
        '
        Me.btnCta.Location = New System.Drawing.Point(459, 8)
        Me.btnCta.Name = "btnCta"
        Me.btnCta.Size = New System.Drawing.Size(26, 22)
        Me.btnCta.TabIndex = 2
        Me.btnCta.Text = "..."
        Me.btnCta.UseVisualStyleBackColor = True
        '
        'pan
        '
        Me.pan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.pan.Location = New System.Drawing.Point(49, 33)
        Me.pan.Name = "pan"
        Me.pan.Size = New System.Drawing.Size(920, 193)
        Me.pan.TabIndex = 6
        '
        'txtSSSCta
        '
        Me.txtSSSCta.Location = New System.Drawing.Point(388, 62)
        Me.txtSSSCta.MaxLength = 4
        Me.txtSSSCta.Name = "txtSSSCta"
        Me.txtSSSCta.Size = New System.Drawing.Size(85, 20)
        Me.txtSSSCta.TabIndex = 32
        Me.txtSSSCta.Text = "0000"
        Me.txtSSSCta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSSCta
        '
        Me.txtSSCta.Location = New System.Drawing.Point(297, 62)
        Me.txtSSCta.MaxLength = 4
        Me.txtSSCta.Name = "txtSSCta"
        Me.txtSSCta.Size = New System.Drawing.Size(85, 20)
        Me.txtSSCta.TabIndex = 31
        Me.txtSSCta.Text = "0000"
        Me.txtSSCta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSCta
        '
        Me.txtSCta.Location = New System.Drawing.Point(206, 62)
        Me.txtSCta.MaxLength = 4
        Me.txtSCta.Name = "txtSCta"
        Me.txtSCta.Size = New System.Drawing.Size(85, 20)
        Me.txtSCta.TabIndex = 30
        Me.txtSCta.Text = "0000"
        Me.txtSCta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCta
        '
        Me.txtCta.Location = New System.Drawing.Point(115, 62)
        Me.txtCta.MaxLength = 4
        Me.txtCta.Name = "txtCta"
        Me.txtCta.Size = New System.Drawing.Size(85, 20)
        Me.txtCta.TabIndex = 29
        Me.txtCta.Text = "0000"
        Me.txtCta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSdoIni
        '
        Me.txtSdoIni.Decimales = CType(2UI, UInteger)
        Me.txtSdoIni.Location = New System.Drawing.Point(137, 166)
        Me.txtSdoIni.MaxLength = 20
        Me.txtSdoIni.Name = "txtSdoIni"
        Me.txtSdoIni.Signo = Integra.Controles.TextboxDecimal.RespuestaEnum.NO
        Me.txtSdoIni.Size = New System.Drawing.Size(166, 20)
        Me.txtSdoIni.TabIndex = 16
        Me.txtSdoIni.Text = "0.00"
        Me.txtSdoIni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSdoAnt
        '
        Me.txtSdoAnt.Decimales = CType(2UI, UInteger)
        Me.txtSdoAnt.Location = New System.Drawing.Point(137, 140)
        Me.txtSdoAnt.MaxLength = 20
        Me.txtSdoAnt.Name = "txtSdoAnt"
        Me.txtSdoAnt.Signo = Integra.Controles.TextboxDecimal.RespuestaEnum.NO
        Me.txtSdoAnt.Size = New System.Drawing.Size(166, 20)
        Me.txtSdoAnt.TabIndex = 14
        Me.txtSdoAnt.Text = "0.00"
        Me.txtSdoAnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gpoCaracteristicas
        '
        Me.gpoCaracteristicas.Controls.Add(Me.chkBancos)
        Me.gpoCaracteristicas.Controls.Add(Me.chkInactiva)
        Me.gpoCaracteristicas.Controls.Add(Me.chkDepartamentalizable)
        Me.gpoCaracteristicas.Controls.Add(Me.chkAfectable)
        Me.gpoCaracteristicas.Controls.Add(Me.chkPresupuestos)
        Me.gpoCaracteristicas.Controls.Add(Me.chkResultados)
        Me.gpoCaracteristicas.Location = New System.Drawing.Point(171, 88)
        Me.gpoCaracteristicas.Name = "gpoCaracteristicas"
        Me.gpoCaracteristicas.Size = New System.Drawing.Size(532, 46)
        Me.gpoCaracteristicas.TabIndex = 12
        Me.gpoCaracteristicas.TabStop = False
        Me.gpoCaracteristicas.Text = "Caracteristicas"
        '
        'chkBancos
        '
        Me.chkBancos.AutoSize = True
        Me.chkBancos.Location = New System.Drawing.Point(315, 19)
        Me.chkBancos.Name = "chkBancos"
        Me.chkBancos.Size = New System.Drawing.Size(62, 17)
        Me.chkBancos.TabIndex = 3
        Me.chkBancos.Text = "Bancos"
        Me.chkBancos.UseVisualStyleBackColor = True
        '
        'chkInactiva
        '
        Me.chkInactiva.AutoSize = True
        Me.chkInactiva.Location = New System.Drawing.Point(383, 19)
        Me.chkInactiva.Name = "chkInactiva"
        Me.chkInactiva.Size = New System.Drawing.Size(64, 17)
        Me.chkInactiva.TabIndex = 4
        Me.chkInactiva.Text = "Inactiva"
        Me.chkInactiva.UseVisualStyleBackColor = True
        '
        'chkDepartamentalizable
        '
        Me.chkDepartamentalizable.AutoSize = True
        Me.chkDepartamentalizable.Location = New System.Drawing.Point(187, 20)
        Me.chkDepartamentalizable.Name = "chkDepartamentalizable"
        Me.chkDepartamentalizable.Size = New System.Drawing.Size(122, 17)
        Me.chkDepartamentalizable.TabIndex = 2
        Me.chkDepartamentalizable.Text = "Departamentalizable"
        Me.chkDepartamentalizable.UseVisualStyleBackColor = True
        '
        'chkAfectable
        '
        Me.chkAfectable.AutoSize = True
        Me.chkAfectable.Enabled = False
        Me.chkAfectable.Location = New System.Drawing.Point(453, 19)
        Me.chkAfectable.Name = "chkAfectable"
        Me.chkAfectable.Size = New System.Drawing.Size(71, 17)
        Me.chkAfectable.TabIndex = 5
        Me.chkAfectable.Text = "Afectable"
        Me.chkAfectable.UseVisualStyleBackColor = True
        '
        'chkPresupuestos
        '
        Me.chkPresupuestos.AutoSize = True
        Me.chkPresupuestos.Location = New System.Drawing.Point(91, 19)
        Me.chkPresupuestos.Name = "chkPresupuestos"
        Me.chkPresupuestos.Size = New System.Drawing.Size(90, 17)
        Me.chkPresupuestos.TabIndex = 1
        Me.chkPresupuestos.Text = "Presupuestos"
        Me.chkPresupuestos.UseVisualStyleBackColor = True
        '
        'chkResultados
        '
        Me.chkResultados.AutoSize = True
        Me.chkResultados.Location = New System.Drawing.Point(6, 19)
        Me.chkResultados.Name = "chkResultados"
        Me.chkResultados.Size = New System.Drawing.Size(79, 17)
        Me.chkResultados.TabIndex = 0
        Me.chkResultados.Text = "Resultados"
        Me.chkResultados.UseVisualStyleBackColor = True
        '
        'gpoNaturaleza
        '
        Me.gpoNaturaleza.Controls.Add(Me.rdbAcredora)
        Me.gpoNaturaleza.Controls.Add(Me.rdbDeudora)
        Me.gpoNaturaleza.Location = New System.Drawing.Point(10, 88)
        Me.gpoNaturaleza.Name = "gpoNaturaleza"
        Me.gpoNaturaleza.Size = New System.Drawing.Size(155, 46)
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
        Me.rdbAcredora.TabIndex = 0
        Me.rdbAcredora.TabStop = True
        Me.rdbAcredora.Text = "Acredora"
        Me.rdbAcredora.UseVisualStyleBackColor = True
        '
        'rdbDeudora
        '
        Me.rdbDeudora.AutoSize = True
        Me.rdbDeudora.Location = New System.Drawing.Point(82, 19)
        Me.rdbDeudora.Name = "rdbDeudora"
        Me.rdbDeudora.Size = New System.Drawing.Size(66, 17)
        Me.rdbDeudora.TabIndex = 1
        Me.rdbDeudora.TabStop = True
        Me.rdbDeudora.Text = "Deudora"
        Me.rdbDeudora.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Saldo Inicio del Ejercicio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 65)
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
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Cuenta Mayor:"
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
        Me.txtNombre.TabIndex = 5
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
        Me.mtb.Size = New System.Drawing.Size(50, 574)
        Me.mtb.TabIndex = 4
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(50, 0)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(933, 30)
        Me.lblTitulo.TabIndex = 5
        Me.lblTitulo.Text = "ABC DE CUENTAS CONTABLES"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Afectable"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Afectable"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Inactiva"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Inactiva"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
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
        Me.clmCodigo.Width = 46
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
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.SaldoAñoAnteriorDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.SaldoAñoAnteriorDataGridViewTextBoxColumn.HeaderText = "Saldo del Año Anterior"
        Me.SaldoAñoAnteriorDataGridViewTextBoxColumn.Name = "SaldoAñoAnteriorDataGridViewTextBoxColumn"
        Me.SaldoAñoAnteriorDataGridViewTextBoxColumn.ReadOnly = True
        Me.SaldoAñoAnteriorDataGridViewTextBoxColumn.Width = 93
        '
        'SaldoInicioEjercicioDataGridViewTextBoxColumn
        '
        Me.SaldoInicioEjercicioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SaldoInicioEjercicioDataGridViewTextBoxColumn.DataPropertyName = "SaldoInicioEjercicio"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.SaldoInicioEjercicioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
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
        'ClmCuentaMayor
        '
        Me.ClmCuentaMayor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ClmCuentaMayor.DataPropertyName = "Cta"
        Me.ClmCuentaMayor.HeaderText = "CuentaMayor"
        Me.ClmCuentaMayor.Name = "ClmCuentaMayor"
        Me.ClmCuentaMayor.ReadOnly = True
        Me.ClmCuentaMayor.Visible = False
        Me.ClmCuentaMayor.Width = 95
        '
        'ClmSubCuenta
        '
        Me.ClmSubCuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ClmSubCuenta.DataPropertyName = "SubCta"
        Me.ClmSubCuenta.HeaderText = "SubCuenta"
        Me.ClmSubCuenta.Name = "ClmSubCuenta"
        Me.ClmSubCuenta.ReadOnly = True
        Me.ClmSubCuenta.Visible = False
        Me.ClmSubCuenta.Width = 85
        '
        'ClmSSubCuenta
        '
        Me.ClmSSubCuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ClmSSubCuenta.DataPropertyName = "SSubCta"
        Me.ClmSSubCuenta.HeaderText = "SSubCuenta"
        Me.ClmSSubCuenta.Name = "ClmSSubCuenta"
        Me.ClmSSubCuenta.ReadOnly = True
        Me.ClmSSubCuenta.Visible = False
        Me.ClmSSubCuenta.Width = 92
        '
        'ClmSSSubCuenta
        '
        Me.ClmSSSubCuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ClmSSSubCuenta.DataPropertyName = "SSSubCta"
        Me.ClmSSSubCuenta.HeaderText = "SSSubCuenta"
        Me.ClmSSSubCuenta.Name = "ClmSSSubCuenta"
        Me.ClmSSSubCuenta.ReadOnly = True
        Me.ClmSSSubCuenta.Visible = False
        Me.ClmSSSubCuenta.Width = 99
        '
        'FrmCuentasContables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 574)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.gpo)
        Me.Controls.Add(Me.pan)
        Me.Controls.Add(Me.mtb)
        Me.Name = "FrmCuentasContables"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = resources.GetString("$this.Text")
        Me.gpo.ResumeLayout(False)
        Me.gpo.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan.ResumeLayout(False)
        Me.pan.PerformLayout()
        Me.gpoCaracteristicas.ResumeLayout(False)
        Me.gpoCaracteristicas.PerformLayout()
        Me.gpoNaturaleza.ResumeLayout(False)
        Me.gpoNaturaleza.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCtaC As System.Windows.Forms.TextBox
    Friend WithEvents gpo As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbAfectable As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbNaturazleza As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Txtfiltro As System.Windows.Forms.TextBox
    Friend WithEvents cmbEstatus As System.Windows.Forms.ComboBox
    Friend WithEvents Condiciones As Integra.Clases.CondicionesClass
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents CuentasContable As ClasesNegocio.CuentaContableCollectionClass
    Friend WithEvents btnCta As System.Windows.Forms.Button
    Friend WithEvents pan As System.Windows.Forms.Panel
    Friend WithEvents txtSdoIni As Integra.Controles.TextboxDecimal
    Friend WithEvents txtSdoAnt As Integra.Controles.TextboxDecimal
    Friend WithEvents gpoCaracteristicas As System.Windows.Forms.GroupBox
    Friend WithEvents chkBancos As System.Windows.Forms.CheckBox
    Friend WithEvents chkInactiva As System.Windows.Forms.CheckBox
    Friend WithEvents chkDepartamentalizable As System.Windows.Forms.CheckBox
    Friend WithEvents chkAfectable As System.Windows.Forms.CheckBox
    Friend WithEvents chkPresupuestos As System.Windows.Forms.CheckBox
    Friend WithEvents chkResultados As System.Windows.Forms.CheckBox
    Friend WithEvents gpoNaturaleza As System.Windows.Forms.GroupBox
    Friend WithEvents rdbAcredora As System.Windows.Forms.RadioButton
    Friend WithEvents rdbDeudora As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSSSCtaBusq As Integra.Controles.TextboxNumerico
    Friend WithEvents txtSSCtaBusq As Integra.Controles.TextboxNumerico
    Friend WithEvents txtSctaBusq As Integra.Controles.TextboxNumerico
    Friend WithEvents txtCtaBusq As Integra.Controles.TextboxNumerico
    Friend WithEvents txtSSSCta As System.Windows.Forms.TextBox
    Friend WithEvents txtSSCta As System.Windows.Forms.TextBox
    Friend WithEvents txtSCta As System.Windows.Forms.TextBox
    Friend WithEvents txtCta As System.Windows.Forms.TextBox
    Friend WithEvents clmCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreCuentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CuentaContableDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NaturalezaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoAñoAnteriorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoInicioEjercicioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Afectable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InactivaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmCuentaMayor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmSubCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmSSubCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmSSSubCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
