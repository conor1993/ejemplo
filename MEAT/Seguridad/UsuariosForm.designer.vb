Imports CCS = Integralab.ORMSeguridad.CollectionClasses
Imports ECS = Integralab.ORMSeguridad.EntityClasses
Imports HCS = Integralab.ORMSeguridad.HelperClasses
Imports FCS = Integralab.ORMSeguridad.FactoryClasses

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsuariosForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsuariosForm))
        Me.tabControl = New System.Windows.Forms.TabControl
        Me.UsuariosTabPage = New System.Windows.Forms.TabPage
        Me.Panel = New System.Windows.Forms.Panel
        Me.EdoLabel = New System.Windows.Forms.Label
        Me.CdLabel = New System.Windows.Forms.Label
        Me.ColoniaLabel = New System.Windows.Forms.Label
        Me.EdoTextBox = New System.Windows.Forms.TextBox
        Me.DomicilioLabel = New System.Windows.Forms.Label
        Me.CdTextBox = New System.Windows.Forms.TextBox
        Me.ColoniaTextBox = New System.Windows.Forms.TextBox
        Me.DomicilioTextBox = New System.Windows.Forms.TextBox
        Me.CPMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.CPLabel = New System.Windows.Forms.Label
        Me.Tel2MaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.Tel2Label = New System.Windows.Forms.Label
        Me.Tel1MaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.TelefonoLabel = New System.Windows.Forms.Label
        Me.RfcMaskedTextBox = New System.Windows.Forms.MaskedTextBox
        Me.RfcLabel = New System.Windows.Forms.Label
        Me.NacimientoDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.NacimientoLabel = New System.Windows.Forms.Label
        Me.ApellidoMLabel = New System.Windows.Forms.Label
        Me.ApellidoPLabel = New System.Windows.Forms.Label
        Me.NombreLabel = New System.Windows.Forms.Label
        Me.ApellidoMTextBox = New System.Windows.Forms.TextBox
        Me.ApellidoPTextBox = New System.Windows.Forms.TextBox
        Me.NombreTextBox = New System.Windows.Forms.TextBox
        Me.IdTextBox = New System.Windows.Forms.TextBox
        Me.IdLabel = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.GruposTabPage = New System.Windows.Forms.TabPage
        Me.GruposListBox = New System.Windows.Forms.ListBox
        Me.Grupos = New CCS.GruposCollection
        Me.PanelGrupo = New System.Windows.Forms.Panel
        Me.ReqAutGrupoCheckBox = New System.Windows.Forms.CheckBox
        Me.SeguridadGrupoCheckBox = New System.Windows.Forms.CheckBox
        Me.IdGrupoLabel = New System.Windows.Forms.Label
        Me.DescripcionGrupoTextBox = New System.Windows.Forms.TextBox
        Me.CodigoGrupoTextBox = New System.Windows.Forms.TextBox
        Me.DescripcionGrupoLabel = New System.Windows.Forms.Label
        Me.NombreGrupoLabel = New System.Windows.Forms.Label
        Me.NombreGrupoTextBox = New System.Windows.Forms.TextBox
        Me.Grupomtb = New MEAToolBar.MEAToolBar
        Me.MiembroDeTabPage = New System.Windows.Forms.TabPage
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DesasociarButton = New System.Windows.Forms.Button
        Me.AsociarButton = New System.Windows.Forms.Button
        Me.GruposAsociadosListBox = New System.Windows.Forms.ListBox
        Me.GruposAsociados = New CCS.GruposCollection
        Me.GruposDisponiblesListBox = New System.Windows.Forms.ListBox
        Me.GruposDisponibles = New CCS.GruposCollection
        Me.Lista = New System.Windows.Forms.ImageList(Me.components)
        Me.UsuariosListBox = New System.Windows.Forms.ListBox
        Me.UsuariosContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RestablecerContraseñaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Usuarios = New CCS.UsuarioCollection
        Me.tabControl.SuspendLayout()
        Me.UsuariosTabPage.SuspendLayout()
        Me.Panel.SuspendLayout()
        Me.GruposTabPage.SuspendLayout()
        Me.PanelGrupo.SuspendLayout()
        Me.MiembroDeTabPage.SuspendLayout()
        Me.UsuariosContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabControl
        '
        Me.tabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabControl.Controls.Add(Me.UsuariosTabPage)
        Me.tabControl.Controls.Add(Me.GruposTabPage)
        Me.tabControl.Controls.Add(Me.MiembroDeTabPage)
        Me.tabControl.ImageList = Me.Lista
        Me.tabControl.Location = New System.Drawing.Point(3, 8)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(520, 377)
        Me.tabControl.TabIndex = 0
        '
        'UsuariosTabPage
        '
        Me.UsuariosTabPage.Controls.Add(Me.Panel)
        Me.UsuariosTabPage.Controls.Add(Me.mtb)
        Me.UsuariosTabPage.ImageIndex = 0
        Me.UsuariosTabPage.Location = New System.Drawing.Point(4, 23)
        Me.UsuariosTabPage.Name = "UsuariosTabPage"
        Me.UsuariosTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.UsuariosTabPage.Size = New System.Drawing.Size(512, 350)
        Me.UsuariosTabPage.TabIndex = 0
        Me.UsuariosTabPage.Text = "Usuarios"
        Me.UsuariosTabPage.UseVisualStyleBackColor = True
        '
        'Panel
        '
        Me.Panel.Controls.Add(Me.EdoLabel)
        Me.Panel.Controls.Add(Me.CdLabel)
        Me.Panel.Controls.Add(Me.ColoniaLabel)
        Me.Panel.Controls.Add(Me.EdoTextBox)
        Me.Panel.Controls.Add(Me.DomicilioLabel)
        Me.Panel.Controls.Add(Me.CdTextBox)
        Me.Panel.Controls.Add(Me.ColoniaTextBox)
        Me.Panel.Controls.Add(Me.DomicilioTextBox)
        Me.Panel.Controls.Add(Me.CPMaskedTextBox)
        Me.Panel.Controls.Add(Me.CPLabel)
        Me.Panel.Controls.Add(Me.Tel2MaskedTextBox)
        Me.Panel.Controls.Add(Me.Tel2Label)
        Me.Panel.Controls.Add(Me.Tel1MaskedTextBox)
        Me.Panel.Controls.Add(Me.TelefonoLabel)
        Me.Panel.Controls.Add(Me.RfcMaskedTextBox)
        Me.Panel.Controls.Add(Me.RfcLabel)
        Me.Panel.Controls.Add(Me.NacimientoDateTimePicker)
        Me.Panel.Controls.Add(Me.NacimientoLabel)
        Me.Panel.Controls.Add(Me.ApellidoMLabel)
        Me.Panel.Controls.Add(Me.ApellidoPLabel)
        Me.Panel.Controls.Add(Me.NombreLabel)
        Me.Panel.Controls.Add(Me.ApellidoMTextBox)
        Me.Panel.Controls.Add(Me.ApellidoPTextBox)
        Me.Panel.Controls.Add(Me.NombreTextBox)
        Me.Panel.Controls.Add(Me.IdTextBox)
        Me.Panel.Controls.Add(Me.IdLabel)
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel.Location = New System.Drawing.Point(3, 61)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(506, 286)
        Me.Panel.TabIndex = 1
        '
        'EdoLabel
        '
        Me.EdoLabel.AutoSize = True
        Me.EdoLabel.Location = New System.Drawing.Point(3, 239)
        Me.EdoLabel.Name = "EdoLabel"
        Me.EdoLabel.Size = New System.Drawing.Size(43, 13)
        Me.EdoLabel.TabIndex = 38
        Me.EdoLabel.Text = "Estado:"
        '
        'CdLabel
        '
        Me.CdLabel.AutoSize = True
        Me.CdLabel.Location = New System.Drawing.Point(3, 213)
        Me.CdLabel.Name = "CdLabel"
        Me.CdLabel.Size = New System.Drawing.Size(43, 13)
        Me.CdLabel.TabIndex = 37
        Me.CdLabel.Text = "Ciudad:"
        '
        'ColoniaLabel
        '
        Me.ColoniaLabel.AutoSize = True
        Me.ColoniaLabel.Location = New System.Drawing.Point(3, 161)
        Me.ColoniaLabel.Name = "ColoniaLabel"
        Me.ColoniaLabel.Size = New System.Drawing.Size(45, 13)
        Me.ColoniaLabel.TabIndex = 40
        Me.ColoniaLabel.Text = "Colonia:"
        '
        'EdoTextBox
        '
        Me.EdoTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EdoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EdoTextBox.Location = New System.Drawing.Point(110, 236)
        Me.EdoTextBox.Name = "EdoTextBox"
        Me.EdoTextBox.Size = New System.Drawing.Size(393, 20)
        Me.EdoTextBox.TabIndex = 10
        '
        'DomicilioLabel
        '
        Me.DomicilioLabel.AutoSize = True
        Me.DomicilioLabel.Location = New System.Drawing.Point(3, 135)
        Me.DomicilioLabel.Name = "DomicilioLabel"
        Me.DomicilioLabel.Size = New System.Drawing.Size(52, 13)
        Me.DomicilioLabel.TabIndex = 39
        Me.DomicilioLabel.Text = "Domicilio:"
        '
        'CdTextBox
        '
        Me.CdTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CdTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CdTextBox.Location = New System.Drawing.Point(110, 210)
        Me.CdTextBox.Name = "CdTextBox"
        Me.CdTextBox.Size = New System.Drawing.Size(393, 20)
        Me.CdTextBox.TabIndex = 9
        '
        'ColoniaTextBox
        '
        Me.ColoniaTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ColoniaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ColoniaTextBox.Location = New System.Drawing.Point(110, 158)
        Me.ColoniaTextBox.Name = "ColoniaTextBox"
        Me.ColoniaTextBox.Size = New System.Drawing.Size(393, 20)
        Me.ColoniaTextBox.TabIndex = 7
        '
        'DomicilioTextBox
        '
        Me.DomicilioTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DomicilioTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DomicilioTextBox.Location = New System.Drawing.Point(110, 132)
        Me.DomicilioTextBox.Name = "DomicilioTextBox"
        Me.DomicilioTextBox.Size = New System.Drawing.Size(393, 20)
        Me.DomicilioTextBox.TabIndex = 6
        '
        'CPMaskedTextBox
        '
        Me.CPMaskedTextBox.Location = New System.Drawing.Point(110, 184)
        Me.CPMaskedTextBox.Mask = "99999"
        Me.CPMaskedTextBox.Name = "CPMaskedTextBox"
        Me.CPMaskedTextBox.Size = New System.Drawing.Size(131, 20)
        Me.CPMaskedTextBox.TabIndex = 8
        '
        'CPLabel
        '
        Me.CPLabel.AutoSize = True
        Me.CPLabel.Location = New System.Drawing.Point(3, 187)
        Me.CPLabel.Name = "CPLabel"
        Me.CPLabel.Size = New System.Drawing.Size(75, 13)
        Me.CPLabel.TabIndex = 27
        Me.CPLabel.Text = "Codigo Postal:"
        '
        'Tel2MaskedTextBox
        '
        Me.Tel2MaskedTextBox.Location = New System.Drawing.Point(372, 262)
        Me.Tel2MaskedTextBox.Mask = "(999)000-0000"
        Me.Tel2MaskedTextBox.Name = "Tel2MaskedTextBox"
        Me.Tel2MaskedTextBox.Size = New System.Drawing.Size(131, 20)
        Me.Tel2MaskedTextBox.TabIndex = 12
        Me.Tel2MaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Tel2Label
        '
        Me.Tel2Label.AutoSize = True
        Me.Tel2Label.Location = New System.Drawing.Point(268, 265)
        Me.Tel2Label.Name = "Tel2Label"
        Me.Tel2Label.Size = New System.Drawing.Size(61, 13)
        Me.Tel2Label.TabIndex = 28
        Me.Tel2Label.Text = "Telefono 2:"
        '
        'Tel1MaskedTextBox
        '
        Me.Tel1MaskedTextBox.Location = New System.Drawing.Point(110, 262)
        Me.Tel1MaskedTextBox.Mask = "(999)000-0000"
        Me.Tel1MaskedTextBox.Name = "Tel1MaskedTextBox"
        Me.Tel1MaskedTextBox.Size = New System.Drawing.Size(131, 20)
        Me.Tel1MaskedTextBox.TabIndex = 11
        Me.Tel1MaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'TelefonoLabel
        '
        Me.TelefonoLabel.AutoSize = True
        Me.TelefonoLabel.Location = New System.Drawing.Point(3, 265)
        Me.TelefonoLabel.Name = "TelefonoLabel"
        Me.TelefonoLabel.Size = New System.Drawing.Size(61, 13)
        Me.TelefonoLabel.TabIndex = 26
        Me.TelefonoLabel.Text = "Telefono 1:"
        '
        'RfcMaskedTextBox
        '
        Me.RfcMaskedTextBox.Location = New System.Drawing.Point(372, 105)
        Me.RfcMaskedTextBox.Mask = ">AAAA-999999->AAA"
        Me.RfcMaskedTextBox.Name = "RfcMaskedTextBox"
        Me.RfcMaskedTextBox.Size = New System.Drawing.Size(131, 20)
        Me.RfcMaskedTextBox.TabIndex = 5
        Me.RfcMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'RfcLabel
        '
        Me.RfcLabel.AutoSize = True
        Me.RfcLabel.Location = New System.Drawing.Point(268, 109)
        Me.RfcLabel.Name = "RfcLabel"
        Me.RfcLabel.Size = New System.Drawing.Size(40, 13)
        Me.RfcLabel.TabIndex = 25
        Me.RfcLabel.Text = "R.F.C.:"
        '
        'NacimientoDateTimePicker
        '
        Me.NacimientoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.NacimientoDateTimePicker.Location = New System.Drawing.Point(110, 105)
        Me.NacimientoDateTimePicker.Name = "NacimientoDateTimePicker"
        Me.NacimientoDateTimePicker.Size = New System.Drawing.Size(131, 20)
        Me.NacimientoDateTimePicker.TabIndex = 4
        '
        'NacimientoLabel
        '
        Me.NacimientoLabel.AutoSize = True
        Me.NacimientoLabel.Location = New System.Drawing.Point(3, 109)
        Me.NacimientoLabel.Name = "NacimientoLabel"
        Me.NacimientoLabel.Size = New System.Drawing.Size(111, 13)
        Me.NacimientoLabel.TabIndex = 23
        Me.NacimientoLabel.Text = "Fecha de Nacimiento:"
        '
        'ApellidoMLabel
        '
        Me.ApellidoMLabel.AutoSize = True
        Me.ApellidoMLabel.Location = New System.Drawing.Point(3, 82)
        Me.ApellidoMLabel.Name = "ApellidoMLabel"
        Me.ApellidoMLabel.Size = New System.Drawing.Size(89, 13)
        Me.ApellidoMLabel.TabIndex = 22
        Me.ApellidoMLabel.Text = "Apellido Materno:"
        '
        'ApellidoPLabel
        '
        Me.ApellidoPLabel.AutoSize = True
        Me.ApellidoPLabel.Location = New System.Drawing.Point(3, 56)
        Me.ApellidoPLabel.Name = "ApellidoPLabel"
        Me.ApellidoPLabel.Size = New System.Drawing.Size(87, 13)
        Me.ApellidoPLabel.TabIndex = 21
        Me.ApellidoPLabel.Text = "Apellido Paterno:"
        '
        'NombreLabel
        '
        Me.NombreLabel.AutoSize = True
        Me.NombreLabel.Location = New System.Drawing.Point(3, 30)
        Me.NombreLabel.Name = "NombreLabel"
        Me.NombreLabel.Size = New System.Drawing.Size(58, 13)
        Me.NombreLabel.TabIndex = 20
        Me.NombreLabel.Text = "Nombre(s):"
        '
        'ApellidoMTextBox
        '
        Me.ApellidoMTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ApellidoMTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ApellidoMTextBox.Location = New System.Drawing.Point(110, 79)
        Me.ApellidoMTextBox.MaxLength = 50
        Me.ApellidoMTextBox.Name = "ApellidoMTextBox"
        Me.ApellidoMTextBox.Size = New System.Drawing.Size(393, 20)
        Me.ApellidoMTextBox.TabIndex = 3
        '
        'ApellidoPTextBox
        '
        Me.ApellidoPTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ApellidoPTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ApellidoPTextBox.Location = New System.Drawing.Point(110, 53)
        Me.ApellidoPTextBox.MaxLength = 50
        Me.ApellidoPTextBox.Name = "ApellidoPTextBox"
        Me.ApellidoPTextBox.Size = New System.Drawing.Size(393, 20)
        Me.ApellidoPTextBox.TabIndex = 2
        '
        'NombreTextBox
        '
        Me.NombreTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NombreTextBox.Location = New System.Drawing.Point(110, 27)
        Me.NombreTextBox.MaxLength = 50
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(393, 20)
        Me.NombreTextBox.TabIndex = 1
        '
        'IdTextBox
        '
        Me.IdTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.IdTextBox.Location = New System.Drawing.Point(110, 1)
        Me.IdTextBox.MaxLength = 15
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(235, 20)
        Me.IdTextBox.TabIndex = 0
        '
        'IdLabel
        '
        Me.IdLabel.AutoSize = True
        Me.IdLabel.Location = New System.Drawing.Point(3, 4)
        Me.IdLabel.Name = "IdLabel"
        Me.IdLabel.Size = New System.Drawing.Size(101, 13)
        Me.IdLabel.TabIndex = 15
        Me.IdLabel.Text = "Nombre de Usuario:"
        '
        'mtb
        '
        Me.mtb.AccessibleDescription = ""
        Me.mtb.ButtonSize = New System.Drawing.Size(50, 50)
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
        Me.mtb.Location = New System.Drawing.Point(3, 3)
        Me.mtb.MostrarBorrar = True
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = True
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = False
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(506, 58)
        Me.mtb.TabIndex = 0
        '
        'GruposTabPage
        '
        Me.GruposTabPage.Controls.Add(Me.GruposListBox)
        Me.GruposTabPage.Controls.Add(Me.PanelGrupo)
        Me.GruposTabPage.Controls.Add(Me.Grupomtb)
        Me.GruposTabPage.ImageIndex = 1
        Me.GruposTabPage.Location = New System.Drawing.Point(4, 23)
        Me.GruposTabPage.Name = "GruposTabPage"
        Me.GruposTabPage.Size = New System.Drawing.Size(512, 350)
        Me.GruposTabPage.TabIndex = 2
        Me.GruposTabPage.Text = "Grupos"
        Me.GruposTabPage.UseVisualStyleBackColor = True
        '
        'GruposListBox
        '
        Me.GruposListBox.DataSource = Me.Grupos
        Me.GruposListBox.DisplayMember = "Gponom"
        Me.GruposListBox.FormattingEnabled = True
        Me.GruposListBox.Location = New System.Drawing.Point(5, 198)
        Me.GruposListBox.Name = "GruposListBox"
        Me.GruposListBox.Size = New System.Drawing.Size(499, 134)
        Me.GruposListBox.TabIndex = 0
        Me.GruposListBox.ValueMember = "Gpondx"
        '
        'Grupos
        '
        Me.Grupos.ActiveContext = Nothing
        Me.Grupos.AllowEdit = True
        Me.Grupos.AllowNew = True
        Me.Grupos.AllowRemove = True
        Me.Grupos.Capacity = 32
        Me.Grupos.ConcurrencyPredicateFactoryToUse = Nothing
        Me.Grupos.DoNotPerformAddIfPresent = False
        Me.Grupos.EntityFactoryToUse = New FCS.GruposEntityFactory
        Me.Grupos.IsReadOnly = False
        Me.Grupos.MaxNumberOfItemsToReturn = CType(0, Long)
        Me.Grupos.SortClauses = Nothing
        Me.Grupos.SuppressClearInGetMulti = False
        Me.Grupos.Transaction = Nothing
        '
        'PanelGrupo
        '
        Me.PanelGrupo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelGrupo.Controls.Add(Me.ReqAutGrupoCheckBox)
        Me.PanelGrupo.Controls.Add(Me.SeguridadGrupoCheckBox)
        Me.PanelGrupo.Controls.Add(Me.IdGrupoLabel)
        Me.PanelGrupo.Controls.Add(Me.DescripcionGrupoTextBox)
        Me.PanelGrupo.Controls.Add(Me.CodigoGrupoTextBox)
        Me.PanelGrupo.Controls.Add(Me.DescripcionGrupoLabel)
        Me.PanelGrupo.Controls.Add(Me.NombreGrupoLabel)
        Me.PanelGrupo.Controls.Add(Me.NombreGrupoTextBox)
        Me.PanelGrupo.Location = New System.Drawing.Point(5, 64)
        Me.PanelGrupo.Name = "PanelGrupo"
        Me.PanelGrupo.Size = New System.Drawing.Size(502, 128)
        Me.PanelGrupo.TabIndex = 3
        '
        'ReqAutGrupoCheckBox
        '
        Me.ReqAutGrupoCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReqAutGrupoCheckBox.AutoSize = True
        Me.ReqAutGrupoCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ReqAutGrupoCheckBox.Location = New System.Drawing.Point(251, 106)
        Me.ReqAutGrupoCheckBox.Name = "ReqAutGrupoCheckBox"
        Me.ReqAutGrupoCheckBox.Size = New System.Drawing.Size(248, 17)
        Me.ReqAutGrupoCheckBox.TabIndex = 4
        Me.ReqAutGrupoCheckBox.Text = "¿ Requiere autentificación para seleccionarlo ?"
        Me.ReqAutGrupoCheckBox.UseVisualStyleBackColor = True
        '
        'SeguridadGrupoCheckBox
        '
        Me.SeguridadGrupoCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeguridadGrupoCheckBox.AutoSize = True
        Me.SeguridadGrupoCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SeguridadGrupoCheckBox.Location = New System.Drawing.Point(6, 106)
        Me.SeguridadGrupoCheckBox.Name = "SeguridadGrupoCheckBox"
        Me.SeguridadGrupoCheckBox.Size = New System.Drawing.Size(167, 17)
        Me.SeguridadGrupoCheckBox.TabIndex = 3
        Me.SeguridadGrupoCheckBox.Text = "¿ Es un grupo de Seguridad ?"
        Me.SeguridadGrupoCheckBox.UseVisualStyleBackColor = True
        '
        'IdGrupoLabel
        '
        Me.IdGrupoLabel.AutoSize = True
        Me.IdGrupoLabel.Location = New System.Drawing.Point(3, 6)
        Me.IdGrupoLabel.Name = "IdGrupoLabel"
        Me.IdGrupoLabel.Size = New System.Drawing.Size(43, 13)
        Me.IdGrupoLabel.TabIndex = 1
        Me.IdGrupoLabel.Text = "Codigo:"
        '
        'DescripcionGrupoTextBox
        '
        Me.DescripcionGrupoTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescripcionGrupoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescripcionGrupoTextBox.Location = New System.Drawing.Point(99, 55)
        Me.DescripcionGrupoTextBox.Multiline = True
        Me.DescripcionGrupoTextBox.Name = "DescripcionGrupoTextBox"
        Me.DescripcionGrupoTextBox.Size = New System.Drawing.Size(400, 45)
        Me.DescripcionGrupoTextBox.TabIndex = 2
        '
        'CodigoGrupoTextBox
        '
        Me.CodigoGrupoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CodigoGrupoTextBox.Location = New System.Drawing.Point(99, 3)
        Me.CodigoGrupoTextBox.Name = "CodigoGrupoTextBox"
        Me.CodigoGrupoTextBox.Size = New System.Drawing.Size(206, 20)
        Me.CodigoGrupoTextBox.TabIndex = 0
        '
        'DescripcionGrupoLabel
        '
        Me.DescripcionGrupoLabel.AutoSize = True
        Me.DescripcionGrupoLabel.Location = New System.Drawing.Point(3, 58)
        Me.DescripcionGrupoLabel.Name = "DescripcionGrupoLabel"
        Me.DescripcionGrupoLabel.Size = New System.Drawing.Size(66, 13)
        Me.DescripcionGrupoLabel.TabIndex = 1
        Me.DescripcionGrupoLabel.Text = "Descripcion:"
        '
        'NombreGrupoLabel
        '
        Me.NombreGrupoLabel.AutoSize = True
        Me.NombreGrupoLabel.Location = New System.Drawing.Point(3, 32)
        Me.NombreGrupoLabel.Name = "NombreGrupoLabel"
        Me.NombreGrupoLabel.Size = New System.Drawing.Size(47, 13)
        Me.NombreGrupoLabel.TabIndex = 1
        Me.NombreGrupoLabel.Text = "Nombre:"
        '
        'NombreGrupoTextBox
        '
        Me.NombreGrupoTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NombreGrupoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NombreGrupoTextBox.Location = New System.Drawing.Point(99, 29)
        Me.NombreGrupoTextBox.Name = "NombreGrupoTextBox"
        Me.NombreGrupoTextBox.Size = New System.Drawing.Size(400, 20)
        Me.NombreGrupoTextBox.TabIndex = 1
        '
        'Grupomtb
        '
        Me.Grupomtb.ButtonSize = New System.Drawing.Size(50, 50)
        Me.Grupomtb.DropDownArrows = True
        Me.Grupomtb.HabilitarBorrar = True
        Me.Grupomtb.HabilitarBuscar = True
        Me.Grupomtb.HabilitarCancelar = True
        Me.Grupomtb.HabilitarEditar = True
        Me.Grupomtb.HabilitarGuardar = True
        Me.Grupomtb.HabilitarImprimir = True
        Me.Grupomtb.HabilitarLimpiar = True
        Me.Grupomtb.HabilitarNuevo = True
        Me.Grupomtb.HabilitarSalir = True
        Me.Grupomtb.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32
        Me.Grupomtb.Location = New System.Drawing.Point(0, 0)
        Me.Grupomtb.MostrarBorrar = True
        Me.Grupomtb.MostrarBuscar = False
        Me.Grupomtb.MostrarCancelar = True
        Me.Grupomtb.MostrarEditar = True
        Me.Grupomtb.MostrarGuardar = True
        Me.Grupomtb.MostrarImprimir = False
        Me.Grupomtb.MostrarLimpiar = True
        Me.Grupomtb.MostrarNuevo = True
        Me.Grupomtb.MostrarSalir = False
        Me.Grupomtb.Name = "Grupomtb"
        Me.Grupomtb.ShowToolTips = True
        Me.Grupomtb.Size = New System.Drawing.Size(512, 58)
        Me.Grupomtb.TabIndex = 0
        '
        'MiembroDeTabPage
        '
        Me.MiembroDeTabPage.Controls.Add(Me.Label2)
        Me.MiembroDeTabPage.Controls.Add(Me.Label1)
        Me.MiembroDeTabPage.Controls.Add(Me.DesasociarButton)
        Me.MiembroDeTabPage.Controls.Add(Me.AsociarButton)
        Me.MiembroDeTabPage.Controls.Add(Me.GruposAsociadosListBox)
        Me.MiembroDeTabPage.Controls.Add(Me.GruposDisponiblesListBox)
        Me.MiembroDeTabPage.ImageIndex = 2
        Me.MiembroDeTabPage.Location = New System.Drawing.Point(4, 23)
        Me.MiembroDeTabPage.Name = "MiembroDeTabPage"
        Me.MiembroDeTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.MiembroDeTabPage.Size = New System.Drawing.Size(512, 350)
        Me.MiembroDeTabPage.TabIndex = 1
        Me.MiembroDeTabPage.Text = "Miembro de..."
        Me.MiembroDeTabPage.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(327, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Grupos a los que pertenece:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Grupos Disponibles:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DesasociarButton
        '
        Me.DesasociarButton.Image = My.Resources.user1_back
        Me.DesasociarButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.DesasociarButton.Location = New System.Drawing.Point(202, 177)
        Me.DesasociarButton.Name = "DesasociarButton"
        Me.DesasociarButton.Size = New System.Drawing.Size(109, 56)
        Me.DesasociarButton.TabIndex = 3
        Me.DesasociarButton.Text = "Desasociar"
        Me.DesasociarButton.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.DesasociarButton.UseVisualStyleBackColor = True
        '
        'AsociarButton
        '
        Me.AsociarButton.Image = My.Resources.user1_into
        Me.AsociarButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.AsociarButton.Location = New System.Drawing.Point(202, 119)
        Me.AsociarButton.Name = "AsociarButton"
        Me.AsociarButton.Size = New System.Drawing.Size(109, 52)
        Me.AsociarButton.TabIndex = 1
        Me.AsociarButton.Text = "Asociar"
        Me.AsociarButton.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.AsociarButton.UseVisualStyleBackColor = True
        '
        'GruposAsociadosListBox
        '
        Me.GruposAsociadosListBox.DataSource = Me.GruposAsociados
        Me.GruposAsociadosListBox.DisplayMember = "Gponom"
        Me.GruposAsociadosListBox.FormattingEnabled = True
        Me.GruposAsociadosListBox.Location = New System.Drawing.Point(317, 37)
        Me.GruposAsociadosListBox.Name = "GruposAsociadosListBox"
        Me.GruposAsociadosListBox.Size = New System.Drawing.Size(189, 303)
        Me.GruposAsociadosListBox.TabIndex = 2
        Me.GruposAsociadosListBox.ValueMember = "Gpondx"
        '
        'GruposAsociados
        '
        Me.GruposAsociados.ActiveContext = Nothing
        Me.GruposAsociados.AllowEdit = True
        Me.GruposAsociados.AllowNew = True
        Me.GruposAsociados.AllowRemove = True
        Me.GruposAsociados.Capacity = 32
        Me.GruposAsociados.ConcurrencyPredicateFactoryToUse = Nothing
        Me.GruposAsociados.DoNotPerformAddIfPresent = False
        Me.GruposAsociados.EntityFactoryToUse = New FCS.GruposEntityFactory
        Me.GruposAsociados.IsReadOnly = False
        Me.GruposAsociados.MaxNumberOfItemsToReturn = CType(0, Long)
        Me.GruposAsociados.SortClauses = Nothing
        Me.GruposAsociados.SuppressClearInGetMulti = False
        Me.GruposAsociados.Transaction = Nothing
        '
        'GruposDisponiblesListBox
        '
        Me.GruposDisponiblesListBox.DataSource = Me.GruposDisponibles
        Me.GruposDisponiblesListBox.DisplayMember = "Gponom"
        Me.GruposDisponiblesListBox.FormattingEnabled = True
        Me.GruposDisponiblesListBox.Location = New System.Drawing.Point(6, 37)
        Me.GruposDisponiblesListBox.Name = "GruposDisponiblesListBox"
        Me.GruposDisponiblesListBox.Size = New System.Drawing.Size(190, 303)
        Me.GruposDisponiblesListBox.TabIndex = 0
        Me.GruposDisponiblesListBox.ValueMember = "Gpondx"
        '
        'GruposDisponibles
        '
        Me.GruposDisponibles.ActiveContext = Nothing
        Me.GruposDisponibles.AllowEdit = True
        Me.GruposDisponibles.AllowNew = True
        Me.GruposDisponibles.AllowRemove = True
        Me.GruposDisponibles.Capacity = 32
        Me.GruposDisponibles.ConcurrencyPredicateFactoryToUse = Nothing
        Me.GruposDisponibles.DoNotPerformAddIfPresent = False
        Me.GruposDisponibles.EntityFactoryToUse = New FCS.GruposEntityFactory
        Me.GruposDisponibles.IsReadOnly = False
        Me.GruposDisponibles.MaxNumberOfItemsToReturn = CType(0, Long)
        Me.GruposDisponibles.SortClauses = Nothing
        Me.GruposDisponibles.SuppressClearInGetMulti = False
        Me.GruposDisponibles.Transaction = Nothing
        '
        'Lista
        '
        Me.Lista.ImageStream = CType(resources.GetObject("Lista.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Lista.TransparentColor = System.Drawing.Color.Transparent
        Me.Lista.Images.SetKeyName(0, "user1.png")
        Me.Lista.Images.SetKeyName(1, "users2.png")
        Me.Lista.Images.SetKeyName(2, "users_into.png")
        '
        'UsuariosListBox
        '
        Me.UsuariosListBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UsuariosListBox.ContextMenuStrip = Me.UsuariosContextMenuStrip
        Me.UsuariosListBox.DataSource = Me.Usuarios
        Me.UsuariosListBox.DisplayMember = "Usrid"
        Me.UsuariosListBox.FormattingEnabled = True
        Me.UsuariosListBox.Location = New System.Drawing.Point(3, 391)
        Me.UsuariosListBox.MultiColumn = True
        Me.UsuariosListBox.Name = "UsuariosListBox"
        Me.UsuariosListBox.Size = New System.Drawing.Size(520, 108)
        Me.UsuariosListBox.Sorted = True
        Me.UsuariosListBox.TabIndex = 0
        Me.UsuariosListBox.ValueMember = "Usrndx"
        '
        'UsuariosContextMenuStrip
        '
        Me.UsuariosContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestablecerContraseñaToolStripMenuItem})
        Me.UsuariosContextMenuStrip.Name = "UsuariosContextMenuStrip"
        Me.UsuariosContextMenuStrip.Size = New System.Drawing.Size(212, 26)
        '
        'RestablecerContraseñaToolStripMenuItem
        '
        Me.RestablecerContraseñaToolStripMenuItem.Name = "RestablecerContraseñaToolStripMenuItem"
        Me.RestablecerContraseñaToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.RestablecerContraseñaToolStripMenuItem.Text = "Restablecer contraseña..."
        '
        'Usuarios
        '
        Me.Usuarios.ActiveContext = Nothing
        Me.Usuarios.AllowEdit = True
        Me.Usuarios.AllowNew = True
        Me.Usuarios.AllowRemove = True
        Me.Usuarios.Capacity = 32
        Me.Usuarios.ConcurrencyPredicateFactoryToUse = Nothing
        Me.Usuarios.DoNotPerformAddIfPresent = False
        Me.Usuarios.EntityFactoryToUse = New FCS.UsuarioEntityFactory
        Me.Usuarios.IsReadOnly = False
        Me.Usuarios.MaxNumberOfItemsToReturn = CType(0, Long)
        Me.Usuarios.SortClauses = Nothing
        Me.Usuarios.SuppressClearInGetMulti = False
        Me.Usuarios.Transaction = Nothing
        '
        'UsuariosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 512)
        Me.Controls.Add(Me.UsuariosListBox)
        Me.Controls.Add(Me.tabControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UsuariosForm"
        Me.Text = "Usuarios y Grupos"
        Me.tabControl.ResumeLayout(False)
        Me.UsuariosTabPage.ResumeLayout(False)
        Me.UsuariosTabPage.PerformLayout()
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.GruposTabPage.ResumeLayout(False)
        Me.GruposTabPage.PerformLayout()
        Me.PanelGrupo.ResumeLayout(False)
        Me.PanelGrupo.PerformLayout()
        Me.MiembroDeTabPage.ResumeLayout(False)
        Me.UsuariosContextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabControl As System.Windows.Forms.TabControl
    Friend WithEvents UsuariosTabPage As System.Windows.Forms.TabPage
    Friend WithEvents MiembroDeTabPage As System.Windows.Forms.TabPage
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents UsuariosListBox As System.Windows.Forms.ListBox
    Friend WithEvents Panel As System.Windows.Forms.Panel
    Friend WithEvents EdoLabel As System.Windows.Forms.Label
    Friend WithEvents CdLabel As System.Windows.Forms.Label
    Friend WithEvents ColoniaLabel As System.Windows.Forms.Label
    Friend WithEvents EdoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DomicilioLabel As System.Windows.Forms.Label
    Friend WithEvents CdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ColoniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DomicilioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CPMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CPLabel As System.Windows.Forms.Label
    Friend WithEvents Tel2MaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Tel2Label As System.Windows.Forms.Label
    Friend WithEvents Tel1MaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TelefonoLabel As System.Windows.Forms.Label
    Friend WithEvents RfcMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents RfcLabel As System.Windows.Forms.Label
    Friend WithEvents NacimientoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NacimientoLabel As System.Windows.Forms.Label
    Friend WithEvents ApellidoMLabel As System.Windows.Forms.Label
    Friend WithEvents ApellidoPLabel As System.Windows.Forms.Label
    Friend WithEvents NombreLabel As System.Windows.Forms.Label
    Friend WithEvents ApellidoMTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ApellidoPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdLabel As System.Windows.Forms.Label
    Friend WithEvents Usuarios As CCS.UsuarioCollection
    Friend WithEvents UsuariosContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RestablecerContraseñaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GruposTabPage As System.Windows.Forms.TabPage
    Friend WithEvents Grupomtb As MEAToolBar.MEAToolBar
    Friend WithEvents IdGrupoLabel As System.Windows.Forms.Label
    Friend WithEvents DescripcionGrupoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionGrupoLabel As System.Windows.Forms.Label
    Friend WithEvents NombreGrupoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreGrupoLabel As System.Windows.Forms.Label
    Friend WithEvents CodigoGrupoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PanelGrupo As System.Windows.Forms.Panel
    Friend WithEvents ReqAutGrupoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SeguridadGrupoCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GruposListBox As System.Windows.Forms.ListBox
    Friend WithEvents Grupos As CCS.GruposCollection
    Friend WithEvents DesasociarButton As System.Windows.Forms.Button
    Friend WithEvents AsociarButton As System.Windows.Forms.Button
    Friend WithEvents GruposAsociadosListBox As System.Windows.Forms.ListBox
    Friend WithEvents GruposDisponiblesListBox As System.Windows.Forms.ListBox
    Friend WithEvents GruposAsociados As CCS.GruposCollection
    Friend WithEvents GruposDisponibles As CCS.GruposCollection
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lista As System.Windows.Forms.ImageList
End Class
