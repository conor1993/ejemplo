<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmABCClientes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.mtb = New MEAToolBar.MEAToolBar()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TbpDatosGen = New System.Windows.Forms.TabPage()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.rdtcanaldis2 = New System.Windows.Forms.RadioButton()
        Me.rdtcanaldis = New System.Windows.Forms.RadioButton()
        Me.lblBorrar = New System.Windows.Forms.Label()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.cmbtipocliente = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.RbtnPersonaMoral = New System.Windows.Forms.RadioButton()
        Me.RbtnPersonaFisica = New System.Windows.Forms.RadioButton()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtRfc = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmbVendedor = New System.Windows.Forms.ComboBox()
        Me.lblVendedor = New System.Windows.Forms.Label()
        Me.cmbPasarInformacion = New System.Windows.Forms.Button()
        Me.chkIntroductor = New System.Windows.Forms.CheckBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnCtaAnticipo = New System.Windows.Forms.Button()
        Me.txtCtaAnticipo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnCtaContable = New System.Windows.Forms.Button()
        Me.txtCtaContable = New System.Windows.Forms.TextBox()
        Me.CmbPoblaciones = New System.Windows.Forms.ComboBox()
        Me.CmbCiudades = New System.Windows.Forms.ComboBox()
        Me.CmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCodigoPostal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtColonia = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbpDatosCred = New System.Windows.Forms.TabPage()
        Me.cmbDiasPago = New System.Windows.Forms.ComboBox()
        Me.cmbDiasRevision = New System.Windows.Forms.ComboBox()
        Me.cmbTipoFacturacion = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtDiasCred = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtLimiteCred = New System.Windows.Forms.TextBox()
        Me.TbpDatosFiscales = New System.Windows.Forms.TabPage()
        Me.txtNoIntFisc = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtNoExtFisc = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.chkPrincipal = New System.Windows.Forms.CheckBox()
        Me.btnEditarDomicilio = New System.Windows.Forms.Button()
        Me.dgvDomicilios = New System.Windows.Forms.DataGridView()
        Me.clmEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCiudad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPoblacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmColonia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmBtnEliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnCrearDomicilio = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtTelCel = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtTelefonoFisc = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cmbPoblacionFisc = New System.Windows.Forms.ComboBox()
        Me.cmbCiudadFisc = New System.Windows.Forms.ComboBox()
        Me.txtCPfiscal = New System.Windows.Forms.TextBox()
        Me.cmbEstadoFisc = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtColoniaFisc = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtCalleFisc = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblEstatus = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.pktxtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TbpDatosGen.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbpDatosCred.SuspendLayout()
        Me.TbpDatosFiscales.SuspendLayout()
        CType(Me.dgvDomicilios, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.mtb.MostrarEditar = True
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 509)
        Me.mtb.TabIndex = 5
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(695, 29)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "CATÁLOGO DE CLIENTES"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Controls.Add(Me.lblEstatus)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.pktxtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(55, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(683, 467)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TbpDatosGen)
        Me.TabControl1.Controls.Add(Me.TbpDatosCred)
        Me.TabControl1.Controls.Add(Me.TbpDatosFiscales)
        Me.TabControl1.Location = New System.Drawing.Point(6, 85)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(668, 358)
        Me.TabControl1.TabIndex = 4
        '
        'TbpDatosGen
        '
        Me.TbpDatosGen.Controls.Add(Me.Label35)
        Me.TbpDatosGen.Controls.Add(Me.rdtcanaldis2)
        Me.TbpDatosGen.Controls.Add(Me.rdtcanaldis)
        Me.TbpDatosGen.Controls.Add(Me.lblBorrar)
        Me.TbpDatosGen.Controls.Add(Me.pbLogo)
        Me.TbpDatosGen.Controls.Add(Me.Label34)
        Me.TbpDatosGen.Controls.Add(Me.cmbtipocliente)
        Me.TbpDatosGen.Controls.Add(Me.Label31)
        Me.TbpDatosGen.Controls.Add(Me.RbtnPersonaMoral)
        Me.TbpDatosGen.Controls.Add(Me.RbtnPersonaFisica)
        Me.TbpDatosGen.Controls.Add(Me.txtRazonSocial)
        Me.TbpDatosGen.Controls.Add(Me.Label20)
        Me.TbpDatosGen.Controls.Add(Me.txtRfc)
        Me.TbpDatosGen.Controls.Add(Me.Label19)
        Me.TbpDatosGen.Controls.Add(Me.cmbVendedor)
        Me.TbpDatosGen.Controls.Add(Me.lblVendedor)
        Me.TbpDatosGen.Controls.Add(Me.cmbPasarInformacion)
        Me.TbpDatosGen.Controls.Add(Me.chkIntroductor)
        Me.TbpDatosGen.Controls.Add(Me.txtTelefono)
        Me.TbpDatosGen.Controls.Add(Me.Label12)
        Me.TbpDatosGen.Controls.Add(Me.btnCtaAnticipo)
        Me.TbpDatosGen.Controls.Add(Me.txtCtaAnticipo)
        Me.TbpDatosGen.Controls.Add(Me.Label11)
        Me.TbpDatosGen.Controls.Add(Me.Label10)
        Me.TbpDatosGen.Controls.Add(Me.btnCtaContable)
        Me.TbpDatosGen.Controls.Add(Me.txtCtaContable)
        Me.TbpDatosGen.Controls.Add(Me.CmbPoblaciones)
        Me.TbpDatosGen.Controls.Add(Me.CmbCiudades)
        Me.TbpDatosGen.Controls.Add(Me.CmbEstado)
        Me.TbpDatosGen.Controls.Add(Me.Label9)
        Me.TbpDatosGen.Controls.Add(Me.Label8)
        Me.TbpDatosGen.Controls.Add(Me.Label7)
        Me.TbpDatosGen.Controls.Add(Me.txtCodigoPostal)
        Me.TbpDatosGen.Controls.Add(Me.Label6)
        Me.TbpDatosGen.Controls.Add(Me.txtColonia)
        Me.TbpDatosGen.Controls.Add(Me.Label5)
        Me.TbpDatosGen.Controls.Add(Me.txtDomicilio)
        Me.TbpDatosGen.Controls.Add(Me.Label4)
        Me.TbpDatosGen.Location = New System.Drawing.Point(4, 22)
        Me.TbpDatosGen.Name = "TbpDatosGen"
        Me.TbpDatosGen.Padding = New System.Windows.Forms.Padding(3)
        Me.TbpDatosGen.Size = New System.Drawing.Size(660, 332)
        Me.TbpDatosGen.TabIndex = 0
        Me.TbpDatosGen.Text = "Datos Generales"
        Me.TbpDatosGen.UseVisualStyleBackColor = True
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(6, 300)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(108, 13)
        Me.Label35.TabIndex = 44
        Me.Label35.Text = "Canal de distribucion:"
        '
        'rdtcanaldis2
        '
        Me.rdtcanaldis2.AutoSize = True
        Me.rdtcanaldis2.Location = New System.Drawing.Point(217, 298)
        Me.rdtcanaldis2.Name = "rdtcanaldis2"
        Me.rdtcanaldis2.Size = New System.Drawing.Size(58, 17)
        Me.rdtcanaldis2.TabIndex = 43
        Me.rdtcanaldis2.Text = "Detalle"
        Me.rdtcanaldis2.UseVisualStyleBackColor = True
        '
        'rdtcanaldis
        '
        Me.rdtcanaldis.AutoSize = True
        Me.rdtcanaldis.Checked = True
        Me.rdtcanaldis.Location = New System.Drawing.Point(120, 298)
        Me.rdtcanaldis.Name = "rdtcanaldis"
        Me.rdtcanaldis.Size = New System.Drawing.Size(66, 17)
        Me.rdtcanaldis.TabIndex = 42
        Me.rdtcanaldis.TabStop = True
        Me.rdtcanaldis.Text = "Mayoreo"
        Me.rdtcanaldis.UseVisualStyleBackColor = True
        '
        'lblBorrar
        '
        Me.lblBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrar.ForeColor = System.Drawing.Color.Firebrick
        Me.lblBorrar.Location = New System.Drawing.Point(644, 11)
        Me.lblBorrar.Margin = New System.Windows.Forms.Padding(0)
        Me.lblBorrar.Name = "lblBorrar"
        Me.lblBorrar.Size = New System.Drawing.Size(12, 12)
        Me.lblBorrar.TabIndex = 41
        Me.lblBorrar.Text = "X"
        Me.lblBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbLogo
        '
        Me.pbLogo.Location = New System.Drawing.Point(522, 17)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(130, 130)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLogo.TabIndex = 40
        Me.pbLogo.TabStop = False
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(519, 1)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(31, 13)
        Me.Label34.TabIndex = 39
        Me.Label34.Text = "Logo"
        '
        'cmbtipocliente
        '
        Me.cmbtipocliente.FormattingEnabled = True
        Me.cmbtipocliente.Location = New System.Drawing.Point(112, 259)
        Me.cmbtipocliente.Name = "cmbtipocliente"
        Me.cmbtipocliente.Size = New System.Drawing.Size(196, 21)
        Me.cmbtipocliente.TabIndex = 36
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(6, 262)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(81, 13)
        Me.Label31.TabIndex = 35
        Me.Label31.Text = "Tipo de Cliente:"
        '
        'RbtnPersonaMoral
        '
        Me.RbtnPersonaMoral.AutoSize = True
        Me.RbtnPersonaMoral.Location = New System.Drawing.Point(424, 117)
        Me.RbtnPersonaMoral.Name = "RbtnPersonaMoral"
        Me.RbtnPersonaMoral.Size = New System.Drawing.Size(93, 17)
        Me.RbtnPersonaMoral.TabIndex = 10
        Me.RbtnPersonaMoral.Text = "Persona Moral"
        Me.RbtnPersonaMoral.UseVisualStyleBackColor = True
        '
        'RbtnPersonaFisica
        '
        Me.RbtnPersonaFisica.AutoSize = True
        Me.RbtnPersonaFisica.Location = New System.Drawing.Point(324, 117)
        Me.RbtnPersonaFisica.Name = "RbtnPersonaFisica"
        Me.RbtnPersonaFisica.Size = New System.Drawing.Size(94, 17)
        Me.RbtnPersonaFisica.TabIndex = 9
        Me.RbtnPersonaFisica.Text = "Persona Fisica"
        Me.RbtnPersonaFisica.UseVisualStyleBackColor = True
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.AcceptsReturn = True
        Me.txtRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRazonSocial.Location = New System.Drawing.Point(85, 10)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(223, 20)
        Me.txtRazonSocial.TabIndex = 0
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 13)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(73, 13)
        Me.Label20.TabIndex = 34
        Me.Label20.Text = "Razon Social:"
        '
        'txtRfc
        '
        Me.txtRfc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRfc.Location = New System.Drawing.Point(379, 10)
        Me.txtRfc.Name = "txtRfc"
        Me.txtRfc.Size = New System.Drawing.Size(100, 20)
        Me.txtRfc.TabIndex = 1
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(316, 13)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 13)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "R.F.C.:"
        '
        'cmbVendedor
        '
        Me.cmbVendedor.FormattingEnabled = True
        Me.cmbVendedor.Location = New System.Drawing.Point(85, 169)
        Me.cmbVendedor.Name = "cmbVendedor"
        Me.cmbVendedor.Size = New System.Drawing.Size(223, 21)
        Me.cmbVendedor.TabIndex = 12
        '
        'lblVendedor
        '
        Me.lblVendedor.AutoSize = True
        Me.lblVendedor.Location = New System.Drawing.Point(6, 172)
        Me.lblVendedor.Name = "lblVendedor"
        Me.lblVendedor.Size = New System.Drawing.Size(56, 13)
        Me.lblVendedor.TabIndex = 30
        Me.lblVendedor.Text = "Vendedor:"
        '
        'cmbPasarInformacion
        '
        Me.cmbPasarInformacion.Location = New System.Drawing.Point(318, 141)
        Me.cmbPasarInformacion.Name = "cmbPasarInformacion"
        Me.cmbPasarInformacion.Size = New System.Drawing.Size(200, 23)
        Me.cmbPasarInformacion.TabIndex = 13
        Me.cmbPasarInformacion.Text = "Pasar información a datos fiscales"
        Me.cmbPasarInformacion.UseVisualStyleBackColor = True
        '
        'chkIntroductor
        '
        Me.chkIntroductor.AutoSize = True
        Me.chkIntroductor.Location = New System.Drawing.Point(380, 92)
        Me.chkIntroductor.Name = "chkIntroductor"
        Me.chkIntroductor.Size = New System.Drawing.Size(77, 17)
        Me.chkIntroductor.TabIndex = 7
        Me.chkIntroductor.Text = "Introductor"
        Me.chkIntroductor.UseVisualStyleBackColor = True
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(379, 62)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(114, 20)
        Me.txtTelefono.TabIndex = 5
        Me.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(316, 65)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Telefono:"
        '
        'btnCtaAnticipo
        '
        Me.btnCtaAnticipo.Location = New System.Drawing.Point(520, 231)
        Me.btnCtaAnticipo.Name = "btnCtaAnticipo"
        Me.btnCtaAnticipo.Size = New System.Drawing.Size(26, 22)
        Me.btnCtaAnticipo.TabIndex = 25
        Me.btnCtaAnticipo.Text = "..."
        Me.btnCtaAnticipo.UseVisualStyleBackColor = True
        '
        'txtCtaAnticipo
        '
        Me.txtCtaAnticipo.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCtaAnticipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtaAnticipo.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtCtaAnticipo.Location = New System.Drawing.Point(112, 231)
        Me.txtCtaAnticipo.Name = "txtCtaAnticipo"
        Me.txtCtaAnticipo.ReadOnly = True
        Me.txtCtaAnticipo.Size = New System.Drawing.Size(402, 22)
        Me.txtCtaAnticipo.TabIndex = 15
        Me.txtCtaAnticipo.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 236)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Cuenta de Anticipo:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 208)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Cuenta Contable:"
        '
        'btnCtaContable
        '
        Me.btnCtaContable.Location = New System.Drawing.Point(520, 203)
        Me.btnCtaContable.Name = "btnCtaContable"
        Me.btnCtaContable.Size = New System.Drawing.Size(26, 22)
        Me.btnCtaContable.TabIndex = 21
        Me.btnCtaContable.Text = "..."
        Me.btnCtaContable.UseVisualStyleBackColor = True
        '
        'txtCtaContable
        '
        Me.txtCtaContable.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCtaContable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtaContable.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtCtaContable.Location = New System.Drawing.Point(112, 203)
        Me.txtCtaContable.Name = "txtCtaContable"
        Me.txtCtaContable.ReadOnly = True
        Me.txtCtaContable.Size = New System.Drawing.Size(402, 22)
        Me.txtCtaContable.TabIndex = 14
        Me.txtCtaContable.TabStop = False
        '
        'CmbPoblaciones
        '
        Me.CmbPoblaciones.FormattingEnabled = True
        Me.CmbPoblaciones.Location = New System.Drawing.Point(85, 142)
        Me.CmbPoblaciones.Name = "CmbPoblaciones"
        Me.CmbPoblaciones.Size = New System.Drawing.Size(223, 21)
        Me.CmbPoblaciones.TabIndex = 11
        '
        'CmbCiudades
        '
        Me.CmbCiudades.FormattingEnabled = True
        Me.CmbCiudades.Location = New System.Drawing.Point(85, 115)
        Me.CmbCiudades.Name = "CmbCiudades"
        Me.CmbCiudades.Size = New System.Drawing.Size(223, 21)
        Me.CmbCiudades.TabIndex = 8
        '
        'CmbEstado
        '
        Me.CmbEstado.FormattingEnabled = True
        Me.CmbEstado.Location = New System.Drawing.Point(85, 88)
        Me.CmbEstado.Name = "CmbEstado"
        Me.CmbEstado.Size = New System.Drawing.Size(223, 21)
        Me.CmbEstado.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 145)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Poblacion:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Ciudad:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Estado:"
        '
        'txtCodigoPostal
        '
        Me.txtCodigoPostal.Location = New System.Drawing.Point(379, 36)
        Me.txtCodigoPostal.MaxLength = 5
        Me.txtCodigoPostal.Name = "txtCodigoPostal"
        Me.txtCodigoPostal.Size = New System.Drawing.Size(78, 20)
        Me.txtCodigoPostal.TabIndex = 3
        Me.txtCodigoPostal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(316, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "C.P.:"
        '
        'txtColonia
        '
        Me.txtColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtColonia.Location = New System.Drawing.Point(85, 62)
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(223, 20)
        Me.txtColonia.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Colonia:"
        '
        'txtDomicilio
        '
        Me.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDomicilio.Location = New System.Drawing.Point(85, 36)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(223, 20)
        Me.txtDomicilio.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Domicilio:"
        '
        'TbpDatosCred
        '
        Me.TbpDatosCred.Controls.Add(Me.cmbDiasPago)
        Me.TbpDatosCred.Controls.Add(Me.cmbDiasRevision)
        Me.TbpDatosCred.Controls.Add(Me.cmbTipoFacturacion)
        Me.TbpDatosCred.Controls.Add(Me.Label18)
        Me.TbpDatosCred.Controls.Add(Me.Label16)
        Me.TbpDatosCred.Controls.Add(Me.Label15)
        Me.TbpDatosCred.Controls.Add(Me.txtDiasCred)
        Me.TbpDatosCred.Controls.Add(Me.Label14)
        Me.TbpDatosCred.Controls.Add(Me.Label13)
        Me.TbpDatosCred.Controls.Add(Me.txtLimiteCred)
        Me.TbpDatosCred.Location = New System.Drawing.Point(4, 22)
        Me.TbpDatosCred.Name = "TbpDatosCred"
        Me.TbpDatosCred.Padding = New System.Windows.Forms.Padding(3)
        Me.TbpDatosCred.Size = New System.Drawing.Size(660, 332)
        Me.TbpDatosCred.TabIndex = 1
        Me.TbpDatosCred.Text = "Datos Para Crédito"
        Me.TbpDatosCred.UseVisualStyleBackColor = True
        '
        'cmbDiasPago
        '
        Me.cmbDiasPago.FormattingEnabled = True
        Me.cmbDiasPago.Location = New System.Drawing.Point(123, 78)
        Me.cmbDiasPago.Name = "cmbDiasPago"
        Me.cmbDiasPago.Size = New System.Drawing.Size(284, 21)
        Me.cmbDiasPago.TabIndex = 4
        '
        'cmbDiasRevision
        '
        Me.cmbDiasRevision.FormattingEnabled = True
        Me.cmbDiasRevision.Location = New System.Drawing.Point(123, 52)
        Me.cmbDiasRevision.Name = "cmbDiasRevision"
        Me.cmbDiasRevision.Size = New System.Drawing.Size(284, 21)
        Me.cmbDiasRevision.TabIndex = 3
        '
        'cmbTipoFacturacion
        '
        Me.cmbTipoFacturacion.FormattingEnabled = True
        Me.cmbTipoFacturacion.Location = New System.Drawing.Point(123, 148)
        Me.cmbTipoFacturacion.Name = "cmbTipoFacturacion"
        Me.cmbTipoFacturacion.Size = New System.Drawing.Size(284, 21)
        Me.cmbTipoFacturacion.TabIndex = 2
        Me.cmbTipoFacturacion.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(7, 81)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(74, 13)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "Dias de Pago:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(7, 55)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 13)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Dias de Revisión:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 151)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(105, 13)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Tipo de Facturación:"
        Me.Label15.Visible = False
        '
        'txtDiasCred
        '
        Me.txtDiasCred.Location = New System.Drawing.Point(343, 26)
        Me.txtDiasCred.Name = "txtDiasCred"
        Me.txtDiasCred.Size = New System.Drawing.Size(64, 20)
        Me.txtDiasCred.TabIndex = 1
        Me.txtDiasCred.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(270, 29)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Dias Crédito:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 29)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Limite Crédito:"
        '
        'txtLimiteCred
        '
        Me.txtLimiteCred.Location = New System.Drawing.Point(123, 26)
        Me.txtLimiteCred.Name = "txtLimiteCred"
        Me.txtLimiteCred.Size = New System.Drawing.Size(121, 20)
        Me.txtLimiteCred.TabIndex = 0
        Me.txtLimiteCred.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbpDatosFiscales
        '
        Me.TbpDatosFiscales.Controls.Add(Me.txtNoIntFisc)
        Me.TbpDatosFiscales.Controls.Add(Me.Label33)
        Me.TbpDatosFiscales.Controls.Add(Me.txtNoExtFisc)
        Me.TbpDatosFiscales.Controls.Add(Me.Label32)
        Me.TbpDatosFiscales.Controls.Add(Me.chkPrincipal)
        Me.TbpDatosFiscales.Controls.Add(Me.btnEditarDomicilio)
        Me.TbpDatosFiscales.Controls.Add(Me.dgvDomicilios)
        Me.TbpDatosFiscales.Controls.Add(Me.btnCrearDomicilio)
        Me.TbpDatosFiscales.Controls.Add(Me.txtEmail)
        Me.TbpDatosFiscales.Controls.Add(Me.Label30)
        Me.TbpDatosFiscales.Controls.Add(Me.txtTelCel)
        Me.TbpDatosFiscales.Controls.Add(Me.Label29)
        Me.TbpDatosFiscales.Controls.Add(Me.txtFax)
        Me.TbpDatosFiscales.Controls.Add(Me.Label28)
        Me.TbpDatosFiscales.Controls.Add(Me.txtTelefonoFisc)
        Me.TbpDatosFiscales.Controls.Add(Me.Label27)
        Me.TbpDatosFiscales.Controls.Add(Me.Label26)
        Me.TbpDatosFiscales.Controls.Add(Me.Label25)
        Me.TbpDatosFiscales.Controls.Add(Me.cmbPoblacionFisc)
        Me.TbpDatosFiscales.Controls.Add(Me.cmbCiudadFisc)
        Me.TbpDatosFiscales.Controls.Add(Me.txtCPfiscal)
        Me.TbpDatosFiscales.Controls.Add(Me.cmbEstadoFisc)
        Me.TbpDatosFiscales.Controls.Add(Me.Label24)
        Me.TbpDatosFiscales.Controls.Add(Me.Label23)
        Me.TbpDatosFiscales.Controls.Add(Me.txtColoniaFisc)
        Me.TbpDatosFiscales.Controls.Add(Me.Label22)
        Me.TbpDatosFiscales.Controls.Add(Me.txtCalleFisc)
        Me.TbpDatosFiscales.Controls.Add(Me.Label21)
        Me.TbpDatosFiscales.Location = New System.Drawing.Point(4, 22)
        Me.TbpDatosFiscales.Name = "TbpDatosFiscales"
        Me.TbpDatosFiscales.Padding = New System.Windows.Forms.Padding(3)
        Me.TbpDatosFiscales.Size = New System.Drawing.Size(660, 332)
        Me.TbpDatosFiscales.TabIndex = 2
        Me.TbpDatosFiscales.Text = "Datos Fiscales"
        Me.TbpDatosFiscales.UseVisualStyleBackColor = True
        '
        'txtNoIntFisc
        '
        Me.txtNoIntFisc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNoIntFisc.Location = New System.Drawing.Point(259, 37)
        Me.txtNoIntFisc.Name = "txtNoIntFisc"
        Me.txtNoIntFisc.Size = New System.Drawing.Size(77, 20)
        Me.txtNoIntFisc.TabIndex = 27
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(191, 40)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(62, 13)
        Me.Label33.TabIndex = 28
        Me.Label33.Text = "No. Interior:"
        '
        'txtNoExtFisc
        '
        Me.txtNoExtFisc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNoExtFisc.Location = New System.Drawing.Point(85, 37)
        Me.txtNoExtFisc.Name = "txtNoExtFisc"
        Me.txtNoExtFisc.Size = New System.Drawing.Size(77, 20)
        Me.txtNoExtFisc.TabIndex = 25
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(6, 40)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(65, 13)
        Me.Label32.TabIndex = 26
        Me.Label32.Text = "No. Exterior:"
        '
        'chkPrincipal
        '
        Me.chkPrincipal.AutoSize = True
        Me.chkPrincipal.Location = New System.Drawing.Point(487, 118)
        Me.chkPrincipal.Name = "chkPrincipal"
        Me.chkPrincipal.Size = New System.Drawing.Size(66, 17)
        Me.chkPrincipal.TabIndex = 10
        Me.chkPrincipal.Text = "Principal"
        Me.chkPrincipal.UseVisualStyleBackColor = True
        '
        'btnEditarDomicilio
        '
        Me.btnEditarDomicilio.Location = New System.Drawing.Point(345, 171)
        Me.btnEditarDomicilio.Name = "btnEditarDomicilio"
        Me.btnEditarDomicilio.Size = New System.Drawing.Size(152, 23)
        Me.btnEditarDomicilio.TabIndex = 12
        Me.btnEditarDomicilio.Text = "Modificar domicilio"
        Me.btnEditarDomicilio.UseVisualStyleBackColor = True
        '
        'dgvDomicilios
        '
        Me.dgvDomicilios.AllowUserToAddRows = False
        Me.dgvDomicilios.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDomicilios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDomicilios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDomicilios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmEstado, Me.clmCiudad, Me.clmPoblacion, Me.clmColonia, Me.clmBtnEliminar})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDomicilios.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDomicilios.Location = New System.Drawing.Point(9, 200)
        Me.dgvDomicilios.MultiSelect = False
        Me.dgvDomicilios.Name = "dgvDomicilios"
        Me.dgvDomicilios.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDomicilios.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDomicilios.RowHeadersVisible = False
        Me.dgvDomicilios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDomicilios.Size = New System.Drawing.Size(549, 126)
        Me.dgvDomicilios.TabIndex = 14
        '
        'clmEstado
        '
        Me.clmEstado.DataPropertyName = "Estado"
        Me.clmEstado.HeaderText = "Estado"
        Me.clmEstado.Name = "clmEstado"
        Me.clmEstado.ReadOnly = True
        Me.clmEstado.Width = 120
        '
        'clmCiudad
        '
        Me.clmCiudad.DataPropertyName = "Ciudad"
        Me.clmCiudad.HeaderText = "Ciudad"
        Me.clmCiudad.Name = "clmCiudad"
        Me.clmCiudad.ReadOnly = True
        Me.clmCiudad.Width = 120
        '
        'clmPoblacion
        '
        Me.clmPoblacion.DataPropertyName = "Poblacion"
        Me.clmPoblacion.HeaderText = "Poblacion"
        Me.clmPoblacion.Name = "clmPoblacion"
        Me.clmPoblacion.ReadOnly = True
        Me.clmPoblacion.Width = 120
        '
        'clmColonia
        '
        Me.clmColonia.DataPropertyName = "Colonia"
        Me.clmColonia.HeaderText = "Colonia"
        Me.clmColonia.Name = "clmColonia"
        Me.clmColonia.ReadOnly = True
        Me.clmColonia.Width = 120
        '
        'clmBtnEliminar
        '
        Me.clmBtnEliminar.HeaderText = ""
        Me.clmBtnEliminar.Name = "clmBtnEliminar"
        Me.clmBtnEliminar.ReadOnly = True
        Me.clmBtnEliminar.Text = "Eliminar"
        Me.clmBtnEliminar.UseColumnTextForButtonValue = True
        Me.clmBtnEliminar.Width = 50
        '
        'btnCrearDomicilio
        '
        Me.btnCrearDomicilio.Location = New System.Drawing.Point(85, 171)
        Me.btnCrearDomicilio.Name = "btnCrearDomicilio"
        Me.btnCrearDomicilio.Size = New System.Drawing.Size(152, 23)
        Me.btnCrearDomicilio.TabIndex = 11
        Me.btnCrearDomicilio.Text = "Nuevo domicilio"
        Me.btnCrearDomicilio.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(407, 90)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(151, 20)
        Me.txtEmail.TabIndex = 7
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(342, 93)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(39, 13)
        Me.Label30.TabIndex = 24
        Me.Label30.Text = "E-Mail:"
        '
        'txtTelCel
        '
        Me.txtTelCel.Location = New System.Drawing.Point(407, 63)
        Me.txtTelCel.Name = "txtTelCel"
        Me.txtTelCel.Size = New System.Drawing.Size(109, 20)
        Me.txtTelCel.TabIndex = 5
        Me.txtTelCel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(342, 66)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(60, 13)
        Me.Label29.TabIndex = 22
        Me.Label29.Text = "Tel Celular:"
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(407, 37)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(109, 20)
        Me.txtFax.TabIndex = 3
        Me.txtFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(342, 40)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(27, 13)
        Me.Label28.TabIndex = 20
        Me.Label28.Text = "Fax:"
        '
        'txtTelefonoFisc
        '
        Me.txtTelefonoFisc.Location = New System.Drawing.Point(407, 11)
        Me.txtTelefonoFisc.Name = "txtTelefonoFisc"
        Me.txtTelefonoFisc.Size = New System.Drawing.Size(110, 20)
        Me.txtTelefonoFisc.TabIndex = 1
        Me.txtTelefonoFisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(342, 14)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(52, 13)
        Me.Label27.TabIndex = 18
        Me.Label27.Text = "Telefono:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(6, 148)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(57, 13)
        Me.Label26.TabIndex = 17
        Me.Label26.Text = "Poblacion:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(6, 121)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(43, 13)
        Me.Label25.TabIndex = 16
        Me.Label25.Text = "Ciudad:"
        '
        'cmbPoblacionFisc
        '
        Me.cmbPoblacionFisc.FormattingEnabled = True
        Me.cmbPoblacionFisc.Location = New System.Drawing.Point(85, 143)
        Me.cmbPoblacionFisc.Name = "cmbPoblacionFisc"
        Me.cmbPoblacionFisc.Size = New System.Drawing.Size(251, 21)
        Me.cmbPoblacionFisc.TabIndex = 8
        '
        'cmbCiudadFisc
        '
        Me.cmbCiudadFisc.FormattingEnabled = True
        Me.cmbCiudadFisc.Location = New System.Drawing.Point(85, 116)
        Me.cmbCiudadFisc.Name = "cmbCiudadFisc"
        Me.cmbCiudadFisc.Size = New System.Drawing.Size(251, 21)
        Me.cmbCiudadFisc.TabIndex = 6
        '
        'txtCPfiscal
        '
        Me.txtCPfiscal.Location = New System.Drawing.Point(407, 116)
        Me.txtCPfiscal.MaxLength = 5
        Me.txtCPfiscal.Name = "txtCPfiscal"
        Me.txtCPfiscal.Size = New System.Drawing.Size(71, 20)
        Me.txtCPfiscal.TabIndex = 9
        Me.txtCPfiscal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbEstadoFisc
        '
        Me.cmbEstadoFisc.FormattingEnabled = True
        Me.cmbEstadoFisc.Location = New System.Drawing.Point(85, 89)
        Me.cmbEstadoFisc.Name = "cmbEstadoFisc"
        Me.cmbEstadoFisc.Size = New System.Drawing.Size(251, 21)
        Me.cmbEstadoFisc.TabIndex = 4
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 94)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(43, 13)
        Me.Label24.TabIndex = 11
        Me.Label24.Text = "Estado:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(342, 119)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(30, 13)
        Me.Label23.TabIndex = 10
        Me.Label23.Text = "C.P.:"
        '
        'txtColoniaFisc
        '
        Me.txtColoniaFisc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtColoniaFisc.Location = New System.Drawing.Point(85, 63)
        Me.txtColoniaFisc.Name = "txtColoniaFisc"
        Me.txtColoniaFisc.Size = New System.Drawing.Size(251, 20)
        Me.txtColoniaFisc.TabIndex = 2
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 66)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 13)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "Colonia:"
        '
        'txtCalleFisc
        '
        Me.txtCalleFisc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCalleFisc.Location = New System.Drawing.Point(85, 11)
        Me.txtCalleFisc.Name = "txtCalleFisc"
        Me.txtCalleFisc.Size = New System.Drawing.Size(251, 20)
        Me.txtCalleFisc.TabIndex = 0
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 14)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(33, 13)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "Calle:"
        '
        'lblEstatus
        '
        Me.lblEstatus.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(578, 22)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(99, 21)
        Me.lblEstatus.TabIndex = 60
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEstatus.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(261, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha de Alta:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(343, 23)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(93, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(85, 49)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(351, 20)
        Me.txtNombre.TabIndex = 0
        '
        'pktxtCodigo
        '
        Me.pktxtCodigo.Location = New System.Drawing.Point(85, 23)
        Me.pktxtCodigo.Name = "pktxtCodigo"
        Me.pktxtCodigo.ReadOnly = True
        Me.pktxtCodigo.Size = New System.Drawing.Size(77, 20)
        Me.pktxtCodigo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Codigo:"
        '
        'FrmABCClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 509)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmABCClientes"
        Me.Text = "Clientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TbpDatosGen.ResumeLayout(False)
        Me.TbpDatosGen.PerformLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbpDatosCred.ResumeLayout(False)
        Me.TbpDatosCred.PerformLayout()
        Me.TbpDatosFiscales.ResumeLayout(False)
        Me.TbpDatosFiscales.PerformLayout()
        CType(Me.dgvDomicilios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents pktxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TbpDatosGen As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TbpDatosCred As System.Windows.Forms.TabPage
    Friend WithEvents TbpDatosFiscales As System.Windows.Forms.TabPage
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents CmbPoblaciones As System.Windows.Forms.ComboBox
    Friend WithEvents CmbCiudades As System.Windows.Forms.ComboBox
    Friend WithEvents CmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoPostal As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtColonia As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents chkIntroductor As System.Windows.Forms.CheckBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnCtaAnticipo As System.Windows.Forms.Button
    Friend WithEvents txtCtaAnticipo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnCtaContable As System.Windows.Forms.Button
    Friend WithEvents txtCtaContable As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtLimiteCred As System.Windows.Forms.TextBox
    Friend WithEvents cmbDiasPago As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDiasRevision As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTipoFacturacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtDiasCred As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtCalleFisc As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtTelefonoFisc As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cmbPoblacionFisc As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCiudadFisc As System.Windows.Forms.ComboBox
    Friend WithEvents txtCPfiscal As System.Windows.Forms.TextBox
    Friend WithEvents cmbEstadoFisc As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtColoniaFisc As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtTelCel As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents cmbPasarInformacion As System.Windows.Forms.Button
    Friend WithEvents cmbVendedor As System.Windows.Forms.ComboBox
    Friend WithEvents lblVendedor As System.Windows.Forms.Label
    Friend WithEvents btnCrearDomicilio As System.Windows.Forms.Button
    Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtRfc As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents RbtnPersonaMoral As System.Windows.Forms.RadioButton
    Friend WithEvents RbtnPersonaFisica As System.Windows.Forms.RadioButton
    Friend WithEvents dgvDomicilios As System.Windows.Forms.DataGridView
    Friend WithEvents btnEditarDomicilio As System.Windows.Forms.Button
    Friend WithEvents chkPrincipal As System.Windows.Forms.CheckBox
    Friend WithEvents clmEstado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCiudad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPoblacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmColonia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmBtnEliminar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents cmbtipocliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtNoIntFisc As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtNoExtFisc As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents pbLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblBorrar As System.Windows.Forms.Label
    Friend WithEvents rdtcanaldis2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdtcanaldis As System.Windows.Forms.RadioButton
    Friend WithEvents Label35 As System.Windows.Forms.Label
End Class
