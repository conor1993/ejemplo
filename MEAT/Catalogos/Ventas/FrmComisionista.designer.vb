<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmComisionista
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
        Me.TxtNombre = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.DtpFechaAlta = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtCodigo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.ZonaCol = New ClasesNegocio.ZonaCollectionClass
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtSueldo = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtPorcentaje = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.txtPlaza = New System.Windows.Forms.TextBox
        Me.CmbPlaza = New System.Windows.Forms.ComboBox
        Me.PlazaCol = New ClasesNegocio.PlazaCollectionClass
        Me.Label2 = New System.Windows.Forms.Label
        Me.TabControl = New System.Windows.Forms.TabControl
        Me.TabDtosGrales = New System.Windows.Forms.TabPage
        Me.TxtRfc = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtCodPob = New System.Windows.Forms.TextBox
        Me.txtCodCdad = New System.Windows.Forms.TextBox
        Me.TxtCodEdo = New System.Windows.Forms.TextBox
        Me.TxtFax = New System.Windows.Forms.TextBox
        Me.TxtLada2 = New System.Windows.Forms.TextBox
        Me.TxtTelefono1 = New System.Windows.Forms.TextBox
        Me.TxtLada1 = New System.Windows.Forms.TextBox
        Me.TxtTelefono = New System.Windows.Forms.TextBox
        Me.TxtLada = New System.Windows.Forms.TextBox
        Me.TxtCp = New System.Windows.Forms.TextBox
        Me.TxtCorreo = New System.Windows.Forms.TextBox
        Me.TxtColonia = New System.Windows.Forms.TextBox
        Me.TxtDomicilio = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.CmbPoblacion = New System.Windows.Forms.ComboBox
        Me.PoblacionCol = New ClasesNegocio.PoblacionCollectionClass
        Me.CmbCiudad = New System.Windows.Forms.ComboBox
        Me.CiudadCol = New ClasesNegocio.CiudadCollectionClass
        Me.CmbEstado = New System.Windows.Forms.ComboBox
        Me.EstadoCol = New ClasesNegocio.EstadoCollectionClass
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.TabPCtrlContable = New System.Windows.Forms.TabPage
        Me.btnCtaCont = New System.Windows.Forms.Button
        Me.txtCtaCont = New System.Windows.Forms.TextBox
        Me.Label44 = New System.Windows.Forms.Label
        Me.TxtAmaterno = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtAPaterno = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar
        Me.Panel1.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.TabDtosGrales.SuspendLayout()
        Me.TabPCtrlContable.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtNombre
        '
        Me.TxtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre.Location = New System.Drawing.Point(117, 29)
        Me.TxtNombre.MaxLength = 50
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(392, 20)
        Me.TxtNombre.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Nombre:"
        '
        'DtpFechaAlta
        '
        Me.DtpFechaAlta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtpFechaAlta.Enabled = False
        Me.DtpFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaAlta.Location = New System.Drawing.Point(415, 3)
        Me.DtpFechaAlta.Name = "DtpFechaAlta"
        Me.DtpFechaAlta.Size = New System.Drawing.Size(94, 20)
        Me.DtpFechaAlta.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(333, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Fecha de Alta:"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCodigo.Enabled = False
        Me.TxtCodigo.Location = New System.Drawing.Point(117, 3)
        Me.TxtCodigo.MaximumSize = New System.Drawing.Size(120, 20)
        Me.TxtCodigo.MaxLength = 4
        Me.TxtCodigo.MinimumSize = New System.Drawing.Size(30, 20)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.ReadOnly = True
        Me.TxtCodigo.Size = New System.Drawing.Size(86, 20)
        Me.TxtCodigo.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Código:"
        '
        'ZonaCol
        '
        Me.ZonaCol.AllowEdit = True
        Me.ZonaCol.AllowNew = True
        Me.ZonaCol.AllowRemove = True
        Me.ZonaCol.MaximoElementosSeleccionados = 1
        Me.ZonaCol.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.ZonaCol.MostrarAlertas = False
        Me.ZonaCol.Name = ""
        Me.ZonaCol.RaiseListChangedEvents = True
        Me.ZonaCol.Transaction = Nothing
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtSueldo)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.txtPorcentaje)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.lblEstatus)
        Me.Panel1.Controls.Add(Me.txtPlaza)
        Me.Panel1.Controls.Add(Me.CmbPlaza)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TabControl)
        Me.Panel1.Controls.Add(Me.TxtAmaterno)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TxtAPaterno)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TxtNombre)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.DtpFechaAlta)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TxtCodigo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(55, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(663, 479)
        Me.Panel1.TabIndex = 2
        '
        'txtSueldo
        '
        Me.txtSueldo.Location = New System.Drawing.Point(117, 137)
        Me.txtSueldo.MaxLength = 15
        Me.txtSueldo.Name = "txtSueldo"
        Me.txtSueldo.Size = New System.Drawing.Size(86, 20)
        Me.txtSueldo.TabIndex = 21
        '
        'Label20
        '
        Me.Label20.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(5, 167)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(106, 13)
        Me.Label20.TabIndex = 22
        Me.Label20.Text = "Porcentaje Comisión:"
        '
        'txtPorcentaje
        '
        Me.txtPorcentaje.Location = New System.Drawing.Point(117, 163)
        Me.txtPorcentaje.MaxLength = 10
        Me.txtPorcentaje.Name = "txtPorcentaje"
        Me.txtPorcentaje.Size = New System.Drawing.Size(86, 20)
        Me.txtPorcentaje.TabIndex = 23
        '
        'Label19
        '
        Me.Label19.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(5, 141)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(43, 13)
        Me.Label19.TabIndex = 20
        Me.Label19.Text = "Sueldo:"
        '
        'lblEstatus
        '
        Me.lblEstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblEstatus.Location = New System.Drawing.Point(565, 3)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(91, 21)
        Me.lblEstatus.TabIndex = 4
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEstatus.Visible = False
        '
        'txtPlaza
        '
        Me.txtPlaza.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlaza.Location = New System.Drawing.Point(117, 108)
        Me.txtPlaza.MaxLength = 4
        Me.txtPlaza.Name = "txtPlaza"
        Me.txtPlaza.Size = New System.Drawing.Size(51, 20)
        Me.txtPlaza.TabIndex = 12
        '
        'CmbPlaza
        '
        Me.CmbPlaza.DataSource = Me.PlazaCol
        Me.CmbPlaza.DisplayMember = "Descripcion"
        Me.CmbPlaza.FormattingEnabled = True
        Me.CmbPlaza.Location = New System.Drawing.Point(174, 108)
        Me.CmbPlaza.Name = "CmbPlaza"
        Me.CmbPlaza.Size = New System.Drawing.Size(335, 21)
        Me.CmbPlaza.TabIndex = 13
        Me.CmbPlaza.ValueMember = "Codigo"
        '
        'PlazaCol
        '
        Me.PlazaCol.AllowEdit = True
        Me.PlazaCol.AllowNew = True
        Me.PlazaCol.AllowRemove = True
        Me.PlazaCol.MaximoElementosSeleccionados = 1
        Me.PlazaCol.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.PlazaCol.MostrarAlertas = False
        Me.PlazaCol.Name = ""
        Me.PlazaCol.RaiseListChangedEvents = True
        Me.PlazaCol.Transaction = Nothing
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Plaza:"
        '
        'TabControl
        '
        Me.TabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl.Controls.Add(Me.TabDtosGrales)
        Me.TabControl.Controls.Add(Me.TabPCtrlContable)
        Me.TabControl.Location = New System.Drawing.Point(8, 199)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(654, 234)
        Me.TabControl.TabIndex = 24
        '
        'TabDtosGrales
        '
        Me.TabDtosGrales.Controls.Add(Me.TxtRfc)
        Me.TabDtosGrales.Controls.Add(Me.Label15)
        Me.TabDtosGrales.Controls.Add(Me.txtCodPob)
        Me.TabDtosGrales.Controls.Add(Me.txtCodCdad)
        Me.TabDtosGrales.Controls.Add(Me.TxtCodEdo)
        Me.TabDtosGrales.Controls.Add(Me.TxtFax)
        Me.TabDtosGrales.Controls.Add(Me.TxtLada2)
        Me.TabDtosGrales.Controls.Add(Me.TxtTelefono1)
        Me.TabDtosGrales.Controls.Add(Me.TxtLada1)
        Me.TabDtosGrales.Controls.Add(Me.TxtTelefono)
        Me.TabDtosGrales.Controls.Add(Me.TxtLada)
        Me.TabDtosGrales.Controls.Add(Me.TxtCp)
        Me.TabDtosGrales.Controls.Add(Me.TxtCorreo)
        Me.TabDtosGrales.Controls.Add(Me.TxtColonia)
        Me.TabDtosGrales.Controls.Add(Me.TxtDomicilio)
        Me.TabDtosGrales.Controls.Add(Me.Label16)
        Me.TabDtosGrales.Controls.Add(Me.Label17)
        Me.TabDtosGrales.Controls.Add(Me.Label18)
        Me.TabDtosGrales.Controls.Add(Me.CmbPoblacion)
        Me.TabDtosGrales.Controls.Add(Me.CmbCiudad)
        Me.TabDtosGrales.Controls.Add(Me.CmbEstado)
        Me.TabDtosGrales.Controls.Add(Me.Label13)
        Me.TabDtosGrales.Controls.Add(Me.Label14)
        Me.TabDtosGrales.Controls.Add(Me.Label8)
        Me.TabDtosGrales.Controls.Add(Me.Label9)
        Me.TabDtosGrales.Controls.Add(Me.Label10)
        Me.TabDtosGrales.Controls.Add(Me.Label11)
        Me.TabDtosGrales.Location = New System.Drawing.Point(4, 22)
        Me.TabDtosGrales.Name = "TabDtosGrales"
        Me.TabDtosGrales.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDtosGrales.Size = New System.Drawing.Size(646, 208)
        Me.TabDtosGrales.TabIndex = 0
        Me.TabDtosGrales.Text = "Datos Generales"
        Me.TabDtosGrales.UseVisualStyleBackColor = True
        '
        'TxtRfc
        '
        Me.TxtRfc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtRfc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtRfc.Location = New System.Drawing.Point(75, 17)
        Me.TxtRfc.MaxLength = 25
        Me.TxtRfc.Name = "TxtRfc"
        Me.TxtRfc.Size = New System.Drawing.Size(116, 20)
        Me.TxtRfc.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "R.F.C.:"
        '
        'txtCodPob
        '
        Me.txtCodPob.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodPob.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodPob.Location = New System.Drawing.Point(75, 150)
        Me.txtCodPob.MaximumSize = New System.Drawing.Size(40, 20)
        Me.txtCodPob.MaxLength = 4
        Me.txtCodPob.Name = "txtCodPob"
        Me.txtCodPob.Size = New System.Drawing.Size(37, 20)
        Me.txtCodPob.TabIndex = 15
        '
        'txtCodCdad
        '
        Me.txtCodCdad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodCdad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodCdad.Location = New System.Drawing.Point(75, 123)
        Me.txtCodCdad.MaximumSize = New System.Drawing.Size(40, 20)
        Me.txtCodCdad.MaxLength = 4
        Me.txtCodCdad.Name = "txtCodCdad"
        Me.txtCodCdad.Size = New System.Drawing.Size(37, 20)
        Me.txtCodCdad.TabIndex = 12
        '
        'TxtCodEdo
        '
        Me.TxtCodEdo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCodEdo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCodEdo.Location = New System.Drawing.Point(75, 96)
        Me.TxtCodEdo.MaximumSize = New System.Drawing.Size(40, 20)
        Me.TxtCodEdo.MaxLength = 4
        Me.TxtCodEdo.Name = "TxtCodEdo"
        Me.TxtCodEdo.Size = New System.Drawing.Size(37, 20)
        Me.TxtCodEdo.TabIndex = 9
        '
        'TxtFax
        '
        Me.TxtFax.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtFax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtFax.Location = New System.Drawing.Point(476, 147)
        Me.TxtFax.MaxLength = 10
        Me.TxtFax.Name = "TxtFax"
        Me.TxtFax.Size = New System.Drawing.Size(142, 20)
        Me.TxtFax.TabIndex = 26
        Me.TxtFax.Text = "0"
        '
        'TxtLada2
        '
        Me.TxtLada2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtLada2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLada2.Location = New System.Drawing.Point(433, 147)
        Me.TxtLada2.MaximumSize = New System.Drawing.Size(40, 20)
        Me.TxtLada2.MaxLength = 3
        Me.TxtLada2.Name = "TxtLada2"
        Me.TxtLada2.Size = New System.Drawing.Size(37, 20)
        Me.TxtLada2.TabIndex = 25
        Me.TxtLada2.Text = "0"
        '
        'TxtTelefono1
        '
        Me.TxtTelefono1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTelefono1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTelefono1.Location = New System.Drawing.Point(476, 121)
        Me.TxtTelefono1.MaxLength = 10
        Me.TxtTelefono1.Name = "TxtTelefono1"
        Me.TxtTelefono1.Size = New System.Drawing.Size(142, 20)
        Me.TxtTelefono1.TabIndex = 23
        Me.TxtTelefono1.Text = "0"
        '
        'TxtLada1
        '
        Me.TxtLada1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtLada1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLada1.Location = New System.Drawing.Point(433, 121)
        Me.TxtLada1.MaximumSize = New System.Drawing.Size(40, 20)
        Me.TxtLada1.MaxLength = 3
        Me.TxtLada1.Name = "TxtLada1"
        Me.TxtLada1.Size = New System.Drawing.Size(37, 20)
        Me.TxtLada1.TabIndex = 22
        Me.TxtLada1.Text = "0"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTelefono.Location = New System.Drawing.Point(476, 95)
        Me.TxtTelefono.MaxLength = 10
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(142, 20)
        Me.TxtTelefono.TabIndex = 21
        Me.TxtTelefono.Text = "0"
        '
        'TxtLada
        '
        Me.TxtLada.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtLada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLada.Location = New System.Drawing.Point(433, 95)
        Me.TxtLada.MaximumSize = New System.Drawing.Size(40, 20)
        Me.TxtLada.MaxLength = 3
        Me.TxtLada.Name = "TxtLada"
        Me.TxtLada.Size = New System.Drawing.Size(37, 20)
        Me.TxtLada.TabIndex = 20
        Me.TxtLada.Text = "0"
        '
        'TxtCp
        '
        Me.TxtCp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCp.Location = New System.Drawing.Point(433, 69)
        Me.TxtCp.MaxLength = 5
        Me.TxtCp.Name = "TxtCp"
        Me.TxtCp.Size = New System.Drawing.Size(185, 20)
        Me.TxtCp.TabIndex = 7
        Me.TxtCp.Text = "0"
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCorreo.Location = New System.Drawing.Point(75, 176)
        Me.TxtCorreo.MaximumSize = New System.Drawing.Size(280, 20)
        Me.TxtCorreo.MaxLength = 50
        Me.TxtCorreo.MinimumSize = New System.Drawing.Size(30, 20)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(259, 20)
        Me.TxtCorreo.TabIndex = 18
        '
        'TxtColonia
        '
        Me.TxtColonia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtColonia.Location = New System.Drawing.Point(75, 69)
        Me.TxtColonia.MaximumSize = New System.Drawing.Size(280, 20)
        Me.TxtColonia.MaxLength = 50
        Me.TxtColonia.MinimumSize = New System.Drawing.Size(50, 20)
        Me.TxtColonia.Name = "TxtColonia"
        Me.TxtColonia.Size = New System.Drawing.Size(259, 20)
        Me.TxtColonia.TabIndex = 5
        '
        'TxtDomicilio
        '
        Me.TxtDomicilio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDomicilio.Location = New System.Drawing.Point(75, 43)
        Me.TxtDomicilio.MaxLength = 50
        Me.TxtDomicilio.Name = "TxtDomicilio"
        Me.TxtDomicilio.Size = New System.Drawing.Size(543, 20)
        Me.TxtDomicilio.TabIndex = 3
        '
        'Label16
        '
        Me.Label16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(375, 150)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(27, 13)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "Fax:"
        '
        'Label17
        '
        Me.Label17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(375, 98)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 13)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Teléfono:"
        '
        'Label18
        '
        Me.Label18.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(375, 72)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(33, 13)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "C.P. :"
        '
        'CmbPoblacion
        '
        Me.CmbPoblacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbPoblacion.DataSource = Me.PoblacionCol
        Me.CmbPoblacion.DisplayMember = "Descripcion"
        Me.CmbPoblacion.FormattingEnabled = True
        Me.CmbPoblacion.Location = New System.Drawing.Point(118, 149)
        Me.CmbPoblacion.MaximumSize = New System.Drawing.Size(280, 0)
        Me.CmbPoblacion.Name = "CmbPoblacion"
        Me.CmbPoblacion.Size = New System.Drawing.Size(216, 21)
        Me.CmbPoblacion.TabIndex = 16
        Me.CmbPoblacion.ValueMember = "Codigo"
        '
        'PoblacionCol
        '
        Me.PoblacionCol.AllowEdit = True
        Me.PoblacionCol.AllowNew = True
        Me.PoblacionCol.AllowRemove = True
        Me.PoblacionCol.MaximoElementosSeleccionados = 1
        Me.PoblacionCol.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.PoblacionCol.MostrarAlertas = False
        Me.PoblacionCol.Name = ""
        Me.PoblacionCol.RaiseListChangedEvents = True
        Me.PoblacionCol.Transaction = Nothing
        '
        'CmbCiudad
        '
        Me.CmbCiudad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbCiudad.DataSource = Me.CiudadCol
        Me.CmbCiudad.DisplayMember = "Descripcion"
        Me.CmbCiudad.FormattingEnabled = True
        Me.CmbCiudad.Location = New System.Drawing.Point(118, 122)
        Me.CmbCiudad.MaximumSize = New System.Drawing.Size(280, 0)
        Me.CmbCiudad.Name = "CmbCiudad"
        Me.CmbCiudad.Size = New System.Drawing.Size(216, 21)
        Me.CmbCiudad.TabIndex = 13
        Me.CmbCiudad.ValueMember = "Codigo"
        '
        'CiudadCol
        '
        Me.CiudadCol.AllowEdit = True
        Me.CiudadCol.AllowNew = True
        Me.CiudadCol.AllowRemove = True
        Me.CiudadCol.Name = ""
        Me.CiudadCol.RaiseListChangedEvents = True
        '
        'CmbEstado
        '
        Me.CmbEstado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbEstado.DataSource = Me.EstadoCol
        Me.CmbEstado.DisplayMember = "Descripcion"
        Me.CmbEstado.FormattingEnabled = True
        Me.CmbEstado.Location = New System.Drawing.Point(118, 95)
        Me.CmbEstado.MaximumSize = New System.Drawing.Size(280, 0)
        Me.CmbEstado.Name = "CmbEstado"
        Me.CmbEstado.Size = New System.Drawing.Size(216, 21)
        Me.CmbEstado.TabIndex = 10
        Me.CmbEstado.ValueMember = "Codigo"
        '
        'EstadoCol
        '
        Me.EstadoCol.AllowEdit = True
        Me.EstadoCol.AllowNew = True
        Me.EstadoCol.AllowRemove = True
        Me.EstadoCol.Name = ""
        Me.EstadoCol.RaiseListChangedEvents = True
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 179)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 13)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "E-Mail:"
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 152)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Población:"
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Ciudad"
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Estado:"
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Colonia:"
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Domicilio:"
        '
        'TabPCtrlContable
        '
        Me.TabPCtrlContable.Controls.Add(Me.btnCtaCont)
        Me.TabPCtrlContable.Controls.Add(Me.txtCtaCont)
        Me.TabPCtrlContable.Controls.Add(Me.Label44)
        Me.TabPCtrlContable.Location = New System.Drawing.Point(4, 22)
        Me.TabPCtrlContable.Name = "TabPCtrlContable"
        Me.TabPCtrlContable.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPCtrlContable.Size = New System.Drawing.Size(646, 208)
        Me.TabPCtrlContable.TabIndex = 3
        Me.TabPCtrlContable.Text = "Control Contable"
        Me.TabPCtrlContable.UseVisualStyleBackColor = True
        '
        'btnCtaCont
        '
        Me.btnCtaCont.Location = New System.Drawing.Point(472, 22)
        Me.btnCtaCont.Name = "btnCtaCont"
        Me.btnCtaCont.Size = New System.Drawing.Size(26, 22)
        Me.btnCtaCont.TabIndex = 8
        Me.btnCtaCont.Text = "..."
        Me.btnCtaCont.UseVisualStyleBackColor = True
        '
        'txtCtaCont
        '
        Me.txtCtaCont.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCtaCont.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCtaCont.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtCtaCont.Location = New System.Drawing.Point(83, 22)
        Me.txtCtaCont.Name = "txtCtaCont"
        Me.txtCtaCont.ReadOnly = True
        Me.txtCtaCont.Size = New System.Drawing.Size(383, 22)
        Me.txtCtaCont.TabIndex = 7
        Me.txtCtaCont.TabStop = False
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(6, 27)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(71, 13)
        Me.Label44.TabIndex = 6
        Me.Label44.Text = "Cta Contable:"
        '
        'TxtAmaterno
        '
        Me.TxtAmaterno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtAmaterno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtAmaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAmaterno.Location = New System.Drawing.Point(117, 81)
        Me.TxtAmaterno.MaxLength = 50
        Me.TxtAmaterno.Name = "TxtAmaterno"
        Me.TxtAmaterno.Size = New System.Drawing.Size(392, 20)
        Me.TxtAmaterno.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Apellido Materno:"
        '
        'TxtAPaterno
        '
        Me.TxtAPaterno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtAPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAPaterno.Location = New System.Drawing.Point(117, 55)
        Me.TxtAPaterno.MaxLength = 50
        Me.TxtAPaterno.Name = "TxtAPaterno"
        Me.TxtAPaterno.Size = New System.Drawing.Size(392, 20)
        Me.TxtAPaterno.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Apellido Paterno:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(50, 0)
        Me.Label1.MaximumSize = New System.Drawing.Size(1800, 1800)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(677, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CATÁLOGO VENDEDORES"
        '
        'MEAToolBar1
        '
        Me.MEAToolBar1.ButtonSize = New System.Drawing.Size(50, 50)
        Me.MEAToolBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MEAToolBar1.DropDownArrows = True
        Me.MEAToolBar1.HabilitarBorrar = True
        Me.MEAToolBar1.HabilitarBuscar = True
        Me.MEAToolBar1.HabilitarCancelar = True
        Me.MEAToolBar1.HabilitarEditar = True
        Me.MEAToolBar1.HabilitarGuardar = True
        Me.MEAToolBar1.HabilitarImprimir = True
        Me.MEAToolBar1.HabilitarLimpiar = True
        Me.MEAToolBar1.HabilitarNuevo = True
        Me.MEAToolBar1.HabilitarSalir = True
        Me.MEAToolBar1.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32
        Me.MEAToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.MEAToolBar1.MostrarBorrar = True
        Me.MEAToolBar1.MostrarBuscar = True
        Me.MEAToolBar1.MostrarCancelar = True
        Me.MEAToolBar1.MostrarEditar = True
        Me.MEAToolBar1.MostrarGuardar = True
        Me.MEAToolBar1.MostrarImprimir = True
        Me.MEAToolBar1.MostrarLimpiar = True
        Me.MEAToolBar1.MostrarNuevo = True
        Me.MEAToolBar1.MostrarSalir = True
        Me.MEAToolBar1.Name = "MEAToolBar1"
        Me.MEAToolBar1.ShowToolTips = True
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 517)
        Me.MEAToolBar1.TabIndex = 0
        '
        'FrmComisionista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 517)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmComisionista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Vendedor"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.TabDtosGrales.ResumeLayout(False)
        Me.TabDtosGrales.PerformLayout()
        Me.TabPCtrlContable.ResumeLayout(False)
        Me.TabPCtrlContable.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DtpFechaAlta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CmbPlaza As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtAmaterno As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtAPaterno As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPlaza As System.Windows.Forms.TextBox
    Friend WithEvents EstadoCol As ClasesNegocio.EstadoCollectionClass
    Friend WithEvents CiudadCol As ClasesNegocio.CiudadCollectionClass
    Friend WithEvents PoblacionCol As ClasesNegocio.PoblacionCollectionClass
    Friend WithEvents PlazaCol As ClasesNegocio.PlazaCollectionClass
    Friend WithEvents ZonaCol As ClasesNegocio.ZonaCollectionClass
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabDtosGrales As System.Windows.Forms.TabPage
    Friend WithEvents TxtRfc As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCodPob As System.Windows.Forms.TextBox
    Friend WithEvents txtCodCdad As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodEdo As System.Windows.Forms.TextBox
    Friend WithEvents TxtFax As System.Windows.Forms.TextBox
    Friend WithEvents TxtLada2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtTelefono1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtLada1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents TxtLada As System.Windows.Forms.TextBox
    Friend WithEvents TxtCp As System.Windows.Forms.TextBox
    Friend WithEvents TxtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents TxtColonia As System.Windows.Forms.TextBox
    Friend WithEvents TxtDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents CmbPoblacion As System.Windows.Forms.ComboBox
    Friend WithEvents CmbCiudad As System.Windows.Forms.ComboBox
    Friend WithEvents CmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TabPCtrlContable As System.Windows.Forms.TabPage
    'Friend WithEvents TipoComisionistaCol As ClasesNegocios.TipoVendedorCollectionClass
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents btnCtaCont As System.Windows.Forms.Button
    Friend WithEvents txtCtaCont As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents txtSueldo As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtPorcentaje As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
End Class
