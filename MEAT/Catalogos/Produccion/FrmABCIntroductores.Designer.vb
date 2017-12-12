<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmABCIntroductores
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
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.txtCantCabezas = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtApellidoPaterno = New System.Windows.Forms.TextBox
        Me.txtApellidoMaterno = New System.Windows.Forms.TextBox
        Me.txtRFC = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dgvIntroductores = New System.Windows.Forms.DataGridView
        Me.IdIntroductorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ApellidoPaternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ApellidoMaternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RFCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaUltimaIntGanadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantCabUltimaIntGanadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Estatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IntroductorC = New ClasesNegocio.CatIntroductoresCollectionClass
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvIntroductores, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.mtb.Size = New System.Drawing.Size(50, 498)
        Me.mtb.TabIndex = 50
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(740, 32)
        Me.Label17.TabIndex = 49
        Me.Label17.Text = "ABC de Introductores de Ganado"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Codigo :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Nombre :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Apellido Paterno :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Apellido Materno :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(60, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "RFC :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.txtCantCabezas)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(533, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(239, 78)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ultimas Introducciones de Ganado"
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(141, 23)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(92, 20)
        Me.dtpFecha.TabIndex = 62
        '
        'txtCantCabezas
        '
        Me.txtCantCabezas.Enabled = False
        Me.txtCantCabezas.Location = New System.Drawing.Point(121, 49)
        Me.txtCantCabezas.Name = "txtCantCabezas"
        Me.txtCantCabezas.Size = New System.Drawing.Size(112, 20)
        Me.txtCantCabezas.TabIndex = 62
        Me.txtCantCabezas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 13)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Cantidad Cabezas :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Fecha :"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(155, 52)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(69, 20)
        Me.txtCodigo.TabIndex = 57
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(155, 80)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(363, 20)
        Me.txtNombre.TabIndex = 58
        '
        'txtApellidoPaterno
        '
        Me.txtApellidoPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellidoPaterno.Location = New System.Drawing.Point(155, 110)
        Me.txtApellidoPaterno.Name = "txtApellidoPaterno"
        Me.txtApellidoPaterno.Size = New System.Drawing.Size(202, 20)
        Me.txtApellidoPaterno.TabIndex = 59
        '
        'txtApellidoMaterno
        '
        Me.txtApellidoMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(155, 136)
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(202, 20)
        Me.txtApellidoMaterno.TabIndex = 60
        '
        'txtRFC
        '
        Me.txtRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRFC.Location = New System.Drawing.Point(155, 168)
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(112, 20)
        Me.txtRFC.TabIndex = 61
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvIntroductores)
        Me.GroupBox2.Location = New System.Drawing.Point(54, 208)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(724, 278)
        Me.GroupBox2.TabIndex = 62
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Introductores"
        '
        'dgvIntroductores
        '
        Me.dgvIntroductores.AllowUserToAddRows = False
        Me.dgvIntroductores.AllowUserToDeleteRows = False
        Me.dgvIntroductores.AllowUserToResizeRows = False
        Me.dgvIntroductores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvIntroductores.AutoGenerateColumns = False
        Me.dgvIntroductores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIntroductores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdIntroductorDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoPaternoDataGridViewTextBoxColumn, Me.ApellidoMaternoDataGridViewTextBoxColumn, Me.RFCDataGridViewTextBoxColumn, Me.FechaUltimaIntGanadoDataGridViewTextBoxColumn, Me.CantCabUltimaIntGanadoDataGridViewTextBoxColumn, Me.Estatus})
        Me.dgvIntroductores.DataSource = Me.IntroductorC
        Me.dgvIntroductores.Location = New System.Drawing.Point(9, 29)
        Me.dgvIntroductores.Name = "dgvIntroductores"
        Me.dgvIntroductores.ReadOnly = True
        Me.dgvIntroductores.RowHeadersVisible = False
        Me.dgvIntroductores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvIntroductores.Size = New System.Drawing.Size(709, 243)
        Me.dgvIntroductores.TabIndex = 0
        '
        'IdIntroductorDataGridViewTextBoxColumn
        '
        Me.IdIntroductorDataGridViewTextBoxColumn.DataPropertyName = "IdIntroductor"
        Me.IdIntroductorDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.IdIntroductorDataGridViewTextBoxColumn.Name = "IdIntroductorDataGridViewTextBoxColumn"
        Me.IdIntroductorDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdIntroductorDataGridViewTextBoxColumn.Width = 60
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApellidoPaternoDataGridViewTextBoxColumn
        '
        Me.ApellidoPaternoDataGridViewTextBoxColumn.DataPropertyName = "ApellidoPaterno"
        Me.ApellidoPaternoDataGridViewTextBoxColumn.HeaderText = "Ap.  Paterno"
        Me.ApellidoPaternoDataGridViewTextBoxColumn.Name = "ApellidoPaternoDataGridViewTextBoxColumn"
        Me.ApellidoPaternoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApellidoMaternoDataGridViewTextBoxColumn
        '
        Me.ApellidoMaternoDataGridViewTextBoxColumn.DataPropertyName = "ApellidoMaterno"
        Me.ApellidoMaternoDataGridViewTextBoxColumn.HeaderText = "Ap. Materno"
        Me.ApellidoMaternoDataGridViewTextBoxColumn.Name = "ApellidoMaternoDataGridViewTextBoxColumn"
        Me.ApellidoMaternoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RFCDataGridViewTextBoxColumn
        '
        Me.RFCDataGridViewTextBoxColumn.DataPropertyName = "RFC"
        Me.RFCDataGridViewTextBoxColumn.HeaderText = "RFC"
        Me.RFCDataGridViewTextBoxColumn.Name = "RFCDataGridViewTextBoxColumn"
        Me.RFCDataGridViewTextBoxColumn.ReadOnly = True
        Me.RFCDataGridViewTextBoxColumn.Width = 80
        '
        'FechaUltimaIntGanadoDataGridViewTextBoxColumn
        '
        Me.FechaUltimaIntGanadoDataGridViewTextBoxColumn.DataPropertyName = "FechaUltimaIntGanado"
        Me.FechaUltimaIntGanadoDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaUltimaIntGanadoDataGridViewTextBoxColumn.Name = "FechaUltimaIntGanadoDataGridViewTextBoxColumn"
        Me.FechaUltimaIntGanadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaUltimaIntGanadoDataGridViewTextBoxColumn.Width = 80
        '
        'CantCabUltimaIntGanadoDataGridViewTextBoxColumn
        '
        Me.CantCabUltimaIntGanadoDataGridViewTextBoxColumn.DataPropertyName = "CantCabUltimaIntGanado"
        Me.CantCabUltimaIntGanadoDataGridViewTextBoxColumn.HeaderText = "Cabezas"
        Me.CantCabUltimaIntGanadoDataGridViewTextBoxColumn.Name = "CantCabUltimaIntGanadoDataGridViewTextBoxColumn"
        Me.CantCabUltimaIntGanadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantCabUltimaIntGanadoDataGridViewTextBoxColumn.Width = 80
        '
        'Estatus
        '
        Me.Estatus.DataPropertyName = "Estatus"
        Me.Estatus.HeaderText = "Estatus"
        Me.Estatus.Name = "Estatus"
        Me.Estatus.ReadOnly = True
        '
        'IntroductorC
        '
        Me.IntroductorC.AllowEdit = True
        Me.IntroductorC.AllowNew = True
        Me.IntroductorC.AllowRemove = True
        Me.IntroductorC.Name = ""
        Me.IntroductorC.RaiseListChangedEvents = True
        '
        'lblEstatus
        '
        Me.lblEstatus.AutoSize = True
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblEstatus.Location = New System.Drawing.Point(414, 50)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(104, 24)
        Me.lblEstatus.TabIndex = 63
        Me.lblEstatus.Text = "ESTATUS"
        '
        'FrmABCIntroductores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 498)
        Me.Controls.Add(Me.lblEstatus)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtRFC)
        Me.Controls.Add(Me.txtApellidoMaterno)
        Me.Controls.Add(Me.txtApellidoPaterno)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.Name = "FrmABCIntroductores"
        Me.Text = "ABC de Introductores de Ganado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvIntroductores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtApellidoPaterno As System.Windows.Forms.TextBox
    Friend WithEvents txtApellidoMaterno As System.Windows.Forms.TextBox
    Friend WithEvents txtRFC As System.Windows.Forms.TextBox
    Friend WithEvents txtCantCabezas As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvIntroductores As System.Windows.Forms.DataGridView
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents IntroductorC As ClasesNegocio.CatIntroductoresCollectionClass
    Friend WithEvents IdIntroductorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidoPaternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidoMaternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RFCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaUltimaIntGanadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantCabUltimaIntGanadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estatus As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
