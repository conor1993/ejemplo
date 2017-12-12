<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmABCCompradoresGanado
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
        Me.dgvLotes = New System.Windows.Forms.DataGridView
        Me.IdCompradorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ApellidoPaternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ApellidoMaternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RFCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColoniaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PoblacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CompradoresGanadoC = New ClasesNegocio.CompradorGanadoCollectionClass
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtComisionKilos = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.btnCta = New System.Windows.Forms.Button
        Me.txtCta = New System.Windows.Forms.TextBox
        Me.txtApellidoMaterno = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtComisionxCabeza = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.chkPagarComision = New System.Windows.Forms.CheckBox
        Me.cmbPoblacion = New System.Windows.Forms.ComboBox
        Me.PoblacionC = New ClasesNegocio.PoblacionCollectionClass
        Me.cmbCiudad = New System.Windows.Forms.ComboBox
        Me.CiudadC = New ClasesNegocio.CiudadCollectionClass
        Me.cmbEstado = New System.Windows.Forms.ComboBox
        Me.EstadoC = New ClasesNegocio.EstadoCollectionClass
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtColonia = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtCalle = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtRFC = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtApellidoPaterno = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtFiltro = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        CType(Me.dgvLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvLotes
        '
        Me.dgvLotes.AllowUserToAddRows = False
        Me.dgvLotes.AllowUserToDeleteRows = False
        Me.dgvLotes.AllowUserToResizeRows = False
        Me.dgvLotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvLotes.AutoGenerateColumns = False
        Me.dgvLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCompradorDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoPaternoDataGridViewTextBoxColumn, Me.ApellidoMaternoDataGridViewTextBoxColumn, Me.RFCDataGridViewTextBoxColumn, Me.CalleDataGridViewTextBoxColumn, Me.ColoniaDataGridViewTextBoxColumn, Me.PoblacionDataGridViewTextBoxColumn, Me.EstatusDataGridViewTextBoxColumn})
        Me.dgvLotes.DataSource = Me.CompradoresGanadoC
        Me.dgvLotes.Location = New System.Drawing.Point(9, 45)
        Me.dgvLotes.MultiSelect = False
        Me.dgvLotes.Name = "dgvLotes"
        Me.dgvLotes.ReadOnly = True
        Me.dgvLotes.RowHeadersVisible = False
        Me.dgvLotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLotes.Size = New System.Drawing.Size(822, 277)
        Me.dgvLotes.TabIndex = 2
        '
        'IdCompradorDataGridViewTextBoxColumn
        '
        Me.IdCompradorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.IdCompradorDataGridViewTextBoxColumn.DataPropertyName = "IdComprador"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.IdCompradorDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.IdCompradorDataGridViewTextBoxColumn.HeaderText = "Código "
        Me.IdCompradorDataGridViewTextBoxColumn.Name = "IdCompradorDataGridViewTextBoxColumn"
        Me.IdCompradorDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCompradorDataGridViewTextBoxColumn.Width = 66
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 67
        '
        'ApellidoPaternoDataGridViewTextBoxColumn
        '
        Me.ApellidoPaternoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ApellidoPaternoDataGridViewTextBoxColumn.DataPropertyName = "ApellidoPaterno"
        Me.ApellidoPaternoDataGridViewTextBoxColumn.HeaderText = "Apellido Paterno"
        Me.ApellidoPaternoDataGridViewTextBoxColumn.Name = "ApellidoPaternoDataGridViewTextBoxColumn"
        Me.ApellidoPaternoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ApellidoPaternoDataGridViewTextBoxColumn.Width = 98
        '
        'ApellidoMaternoDataGridViewTextBoxColumn
        '
        Me.ApellidoMaternoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ApellidoMaternoDataGridViewTextBoxColumn.DataPropertyName = "ApellidoMaterno"
        Me.ApellidoMaternoDataGridViewTextBoxColumn.HeaderText = "Apellido Materno"
        Me.ApellidoMaternoDataGridViewTextBoxColumn.Name = "ApellidoMaternoDataGridViewTextBoxColumn"
        Me.ApellidoMaternoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RFCDataGridViewTextBoxColumn
        '
        Me.RFCDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.RFCDataGridViewTextBoxColumn.DataPropertyName = "RFC"
        Me.RFCDataGridViewTextBoxColumn.HeaderText = "RFC"
        Me.RFCDataGridViewTextBoxColumn.Name = "RFCDataGridViewTextBoxColumn"
        Me.RFCDataGridViewTextBoxColumn.ReadOnly = True
        Me.RFCDataGridViewTextBoxColumn.Width = 51
        '
        'CalleDataGridViewTextBoxColumn
        '
        Me.CalleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CalleDataGridViewTextBoxColumn.DataPropertyName = "Calle"
        Me.CalleDataGridViewTextBoxColumn.HeaderText = "Calle"
        Me.CalleDataGridViewTextBoxColumn.Name = "CalleDataGridViewTextBoxColumn"
        Me.CalleDataGridViewTextBoxColumn.ReadOnly = True
        Me.CalleDataGridViewTextBoxColumn.Width = 53
        '
        'ColoniaDataGridViewTextBoxColumn
        '
        Me.ColoniaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ColoniaDataGridViewTextBoxColumn.DataPropertyName = "Colonia"
        Me.ColoniaDataGridViewTextBoxColumn.HeaderText = "Colonia"
        Me.ColoniaDataGridViewTextBoxColumn.Name = "ColoniaDataGridViewTextBoxColumn"
        Me.ColoniaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ColoniaDataGridViewTextBoxColumn.Width = 65
        '
        'PoblacionDataGridViewTextBoxColumn
        '
        Me.PoblacionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.PoblacionDataGridViewTextBoxColumn.DataPropertyName = "Poblacion"
        Me.PoblacionDataGridViewTextBoxColumn.HeaderText = "Poblacion"
        Me.PoblacionDataGridViewTextBoxColumn.Name = "PoblacionDataGridViewTextBoxColumn"
        Me.PoblacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.PoblacionDataGridViewTextBoxColumn.Width = 77
        '
        'EstatusDataGridViewTextBoxColumn
        '
        Me.EstatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.EstatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.HeaderText = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.Name = "EstatusDataGridViewTextBoxColumn"
        Me.EstatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstatusDataGridViewTextBoxColumn.Width = 65
        '
        'CompradoresGanadoC
        '
        Me.CompradoresGanadoC.AllowEdit = True
        Me.CompradoresGanadoC.AllowNew = True
        Me.CompradoresGanadoC.AllowRemove = True
        Me.CompradoresGanadoC.MaximoElementosSeleccionados = 1
        Me.CompradoresGanadoC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.CompradoresGanadoC.MostrarAlertas = False
        Me.CompradoresGanadoC.Name = ""
        Me.CompradoresGanadoC.RaiseListChangedEvents = True
        Me.CompradoresGanadoC.Transaction = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtComisionKilos)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.btnCta)
        Me.GroupBox1.Controls.Add(Me.txtCta)
        Me.GroupBox1.Controls.Add(Me.txtApellidoMaterno)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtComisionxCabeza)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.chkPagarComision)
        Me.GroupBox1.Controls.Add(Me.cmbPoblacion)
        Me.GroupBox1.Controls.Add(Me.cmbCiudad)
        Me.GroupBox1.Controls.Add(Me.cmbEstado)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtColonia)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtCalle)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtRFC)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtApellidoPaterno)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.lblEstatus)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(834, 210)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'txtComisionKilos
        '
        Me.txtComisionKilos.Enabled = False
        Me.txtComisionKilos.Location = New System.Drawing.Point(615, 152)
        Me.txtComisionKilos.Name = "txtComisionKilos"
        Me.txtComisionKilos.Size = New System.Drawing.Size(60, 20)
        Me.txtComisionKilos.TabIndex = 28
        Me.txtComisionKilos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(515, 156)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Comisión Por Kilo :"
        '
        'btnCta
        '
        Me.btnCta.Location = New System.Drawing.Point(763, 178)
        Me.btnCta.Name = "btnCta"
        Me.btnCta.Size = New System.Drawing.Size(26, 22)
        Me.btnCta.TabIndex = 26
        Me.btnCta.Text = "..."
        Me.btnCta.UseVisualStyleBackColor = True
        '
        'txtCta
        '
        Me.txtCta.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCta.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtCta.Location = New System.Drawing.Point(424, 178)
        Me.txtCta.Name = "txtCta"
        Me.txtCta.ReadOnly = True
        Me.txtCta.Size = New System.Drawing.Size(333, 22)
        Me.txtCta.TabIndex = 25
        Me.txtCta.TabStop = False
        '
        'txtApellidoMaterno
        '
        Me.txtApellidoMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(629, 50)
        Me.txtApellidoMaterno.MaxLength = 20
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(154, 20)
        Me.txtApellidoMaterno.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(326, 183)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(92, 13)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Cuenta Contable :"
        '
        'txtComisionxCabeza
        '
        Me.txtComisionxCabeza.Enabled = False
        Me.txtComisionxCabeza.Location = New System.Drawing.Point(446, 152)
        Me.txtComisionxCabeza.Name = "txtComisionxCabeza"
        Me.txtComisionxCabeza.Size = New System.Drawing.Size(60, 20)
        Me.txtComisionxCabeza.TabIndex = 23
        Me.txtComisionxCabeza.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(326, 156)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Comisión por cabeza :"
        '
        'chkPagarComision
        '
        Me.chkPagarComision.AutoSize = True
        Me.chkPagarComision.Location = New System.Drawing.Point(326, 127)
        Me.chkPagarComision.Name = "chkPagarComision"
        Me.chkPagarComision.Size = New System.Drawing.Size(102, 17)
        Me.chkPagarComision.TabIndex = 21
        Me.chkPagarComision.Text = "Pagar Comisión "
        Me.chkPagarComision.UseVisualStyleBackColor = True
        '
        'cmbPoblacion
        '
        Me.cmbPoblacion.DataSource = Me.PoblacionC
        Me.cmbPoblacion.DisplayMember = "Nombre"
        Me.cmbPoblacion.FormattingEnabled = True
        Me.cmbPoblacion.Location = New System.Drawing.Point(95, 179)
        Me.cmbPoblacion.Name = "cmbPoblacion"
        Me.cmbPoblacion.Size = New System.Drawing.Size(225, 21)
        Me.cmbPoblacion.TabIndex = 20
        Me.cmbPoblacion.ValueMember = "Codigo"
        '
        'PoblacionC
        '
        Me.PoblacionC.AllowEdit = True
        Me.PoblacionC.AllowNew = True
        Me.PoblacionC.AllowRemove = True
        Me.PoblacionC.MaximoElementosSeleccionados = 1
        Me.PoblacionC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.PoblacionC.MostrarAlertas = False
        Me.PoblacionC.Name = ""
        Me.PoblacionC.RaiseListChangedEvents = True
        Me.PoblacionC.Transaction = Nothing
        '
        'cmbCiudad
        '
        Me.cmbCiudad.DataSource = Me.CiudadC
        Me.cmbCiudad.DisplayMember = "Nombre"
        Me.cmbCiudad.FormattingEnabled = True
        Me.cmbCiudad.Location = New System.Drawing.Point(96, 152)
        Me.cmbCiudad.Name = "cmbCiudad"
        Me.cmbCiudad.Size = New System.Drawing.Size(225, 21)
        Me.cmbCiudad.TabIndex = 18
        Me.cmbCiudad.ValueMember = "Codigo"
        '
        'CiudadC
        '
        Me.CiudadC.AllowEdit = True
        Me.CiudadC.AllowNew = True
        Me.CiudadC.AllowRemove = True
        Me.CiudadC.Name = ""
        Me.CiudadC.RaiseListChangedEvents = True
        '
        'cmbEstado
        '
        Me.cmbEstado.DataSource = Me.EstadoC
        Me.cmbEstado.DisplayMember = "Nombre"
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(95, 125)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(225, 21)
        Me.cmbEstado.TabIndex = 16
        Me.cmbEstado.ValueMember = "Codigo"
        '
        'EstadoC
        '
        Me.EstadoC.AllowEdit = True
        Me.EstadoC.AllowNew = True
        Me.EstadoC.AllowRemove = True
        Me.EstadoC.Name = ""
        Me.EstadoC.RaiseListChangedEvents = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 183)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Poblacion :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 156)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Ciudad :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 125)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Estado :"
        '
        'txtColonia
        '
        Me.txtColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtColonia.Location = New System.Drawing.Point(544, 99)
        Me.txtColonia.MaxLength = 60
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(239, 20)
        Me.txtColonia.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(490, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Colonia :"
        '
        'txtCalle
        '
        Me.txtCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCalle.Location = New System.Drawing.Point(95, 99)
        Me.txtCalle.MaxLength = 120
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(389, 20)
        Me.txtCalle.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Calle y Numero :"
        '
        'txtRFC
        '
        Me.txtRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRFC.Location = New System.Drawing.Point(95, 73)
        Me.txtRFC.MaxLength = 15
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(132, 20)
        Me.txtRFC.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "R.F.C. :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(531, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Apellido Materno :"
        '
        'txtApellidoPaterno
        '
        Me.txtApellidoPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellidoPaterno.Location = New System.Drawing.Point(393, 50)
        Me.txtApellidoPaterno.MaxLength = 20
        Me.txtApellidoPaterno.Name = "txtApellidoPaterno"
        Me.txtApellidoPaterno.Size = New System.Drawing.Size(132, 20)
        Me.txtApellidoPaterno.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(304, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Apellido Paterno :"
        '
        'txtNombre
        '
        Me.txtNombre.AcceptsReturn = True
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(95, 47)
        Me.txtNombre.MaxLength = 40
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(203, 20)
        Me.txtNombre.TabIndex = 4
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(95, 21)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(58, 20)
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblEstatus
        '
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(671, 16)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(157, 24)
        Me.lblEstatus.TabIndex = 2
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEstatus.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 21)
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
        Me.Label4.Location = New System.Drawing.Point(-1, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(907, 32)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "CATÁLOGO COMPRADORES DE GANADO"
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
        Me.mtb.Location = New System.Drawing.Point(3, -26)
        Me.mtb.MostrarBorrar = True
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = True
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 633)
        Me.mtb.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.txtFiltro)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.dgvLotes)
        Me.GroupBox2.Location = New System.Drawing.Point(53, 254)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(837, 328)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Compradores Registrados"
        '
        'txtFiltro
        '
        Me.txtFiltro.AcceptsReturn = True
        Me.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFiltro.Location = New System.Drawing.Point(109, 19)
        Me.txtFiltro.MaxLength = 40
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(347, 20)
        Me.txtFiltro.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Nombre Completo:"
        '
        'FrmABCCompradoresGanado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 594)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmABCCompradoresGanado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compradores de Ganado"
        CType(Me.dgvLotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvLotes As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtApellidoPaterno As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRFC As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtColonia As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbPoblacion As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCiudad As System.Windows.Forms.ComboBox
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents chkPagarComision As System.Windows.Forms.CheckBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtApellidoMaterno As System.Windows.Forms.TextBox
    Friend WithEvents CompradoresGanadoC As ClasesNegocio.CompradorGanadoCollectionClass
    Friend WithEvents CiudadC As ClasesNegocio.CiudadCollectionClass
    Friend WithEvents PoblacionC As ClasesNegocio.PoblacionCollectionClass
    Friend WithEvents EstadoC As ClasesNegocio.EstadoCollectionClass
    Public WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents CtaMayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubCtaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SsbCtaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SssCtaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCta As System.Windows.Forms.Button
    Friend WithEvents txtCta As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents IdCompradorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidoPaternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidoMaternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RFCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CalleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColoniaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PoblacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtComisionKilos As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtComisionxCabeza As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    'friend whitevents CompradoresC as ClasesNegocio.CompradoresCollectionClass
End Class
