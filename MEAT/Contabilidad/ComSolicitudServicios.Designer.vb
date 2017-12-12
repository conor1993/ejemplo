<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComSolicitudServicios
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label17 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtFolio = New System.Windows.Forms.TextBox
        Me.txtSolicita = New System.Windows.Forms.TextBox
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtSuma = New System.Windows.Forms.TextBox
        Me.DgvDetalleSolic = New System.Windows.Forms.DataGridView
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.CmbPlaza = New System.Windows.Forms.ComboBox
        Me.PlazaC = New ClasesNegocio.PlazaCollectionClass
        Me.CmbSucursal = New System.Windows.Forms.ComboBox
        Me.SucursalC = New ClasesNegocio.SucursalCollectionClass
        Me.SolicitudServDetC = New ClasesNegocio.SolicitudServDetCollectionClass
        Me.Tmplaza = New System.Windows.Forms.Timer(Me.components)
        Me.TmSucursal = New System.Windows.Forms.Timer(Me.components)
        Me.txtObservaciones = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtEntregarEn = New System.Windows.Forms.TextBox
        Me.txtEntregarA = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtPara = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.clmFolio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIndice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmServicio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmUrgente = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.clmObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvDetalleSolic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(914, 29)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "SOLICITUD DE SERVICIOS"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 422)
        Me.mtb.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Plaza:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Sucursal:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(437, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Folio:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(635, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Fecha de Alta:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(437, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Solicita:"
        '
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(524, 39)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.ReadOnly = True
        Me.txtFolio.Size = New System.Drawing.Size(105, 20)
        Me.txtFolio.TabIndex = 20
        '
        'txtSolicita
        '
        Me.txtSolicita.Location = New System.Drawing.Point(524, 66)
        Me.txtSolicita.Name = "txtSolicita"
        Me.txtSolicita.ReadOnly = True
        Me.txtSolicita.Size = New System.Drawing.Size(410, 20)
        Me.txtSolicita.TabIndex = 21
        '
        'DtpFecha
        '
        Me.DtpFecha.Enabled = False
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(717, 38)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(90, 20)
        Me.DtpFecha.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtSuma)
        Me.GroupBox1.Controls.Add(Me.DgvDetalleSolic)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(55, 174)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(904, 241)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de Solicitud"
        '
        'txtSuma
        '
        Me.txtSuma.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSuma.Location = New System.Drawing.Point(267, 212)
        Me.txtSuma.Name = "txtSuma"
        Me.txtSuma.ReadOnly = True
        Me.txtSuma.Size = New System.Drawing.Size(105, 23)
        Me.txtSuma.TabIndex = 22
        Me.txtSuma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DgvDetalleSolic
        '
        Me.DgvDetalleSolic.AllowUserToOrderColumns = True
        Me.DgvDetalleSolic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetalleSolic.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmFolio, Me.clmIndice, Me.clmServicio, Me.clmCantidad, Me.clmUrgente, Me.clmObservaciones, Me.clmEstatus, Me.clmFecha})
        Me.DgvDetalleSolic.Location = New System.Drawing.Point(5, 22)
        Me.DgvDetalleSolic.Name = "DgvDetalleSolic"
        Me.DgvDetalleSolic.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DgvDetalleSolic.Size = New System.Drawing.Size(893, 184)
        Me.DgvDetalleSolic.TabIndex = 6
        '
        'lblEstatus
        '
        Me.lblEstatus.AutoSize = True
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblEstatus.Location = New System.Drawing.Point(813, 35)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(104, 24)
        Me.lblEstatus.TabIndex = 19
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.Visible = False
        '
        'CmbPlaza
        '
        Me.CmbPlaza.FormattingEnabled = True
        Me.CmbPlaza.Location = New System.Drawing.Point(145, 39)
        Me.CmbPlaza.Name = "CmbPlaza"
        Me.CmbPlaza.Size = New System.Drawing.Size(282, 21)
        Me.CmbPlaza.TabIndex = 0
        Me.CmbPlaza.ValueMember = "Codigo"
        '
        'PlazaC
        '
        Me.PlazaC.AllowEdit = True
        Me.PlazaC.AllowNew = True
        Me.PlazaC.AllowRemove = True
        Me.PlazaC.MaximoElementosSeleccionados = 1
        Me.PlazaC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.PlazaC.MostrarAlertas = False
        Me.PlazaC.Name = ""
        Me.PlazaC.RaiseListChangedEvents = True
        Me.PlazaC.Transaction = Nothing
        '
        'CmbSucursal
        '
        Me.CmbSucursal.FormattingEnabled = True
        Me.CmbSucursal.Location = New System.Drawing.Point(145, 66)
        Me.CmbSucursal.Name = "CmbSucursal"
        Me.CmbSucursal.Size = New System.Drawing.Size(282, 21)
        Me.CmbSucursal.TabIndex = 1
        Me.CmbSucursal.ValueMember = "Codigo"
        '
        'SucursalC
        '
        Me.SucursalC.AllowEdit = True
        Me.SucursalC.AllowNew = True
        Me.SucursalC.AllowRemove = True
        Me.SucursalC.MaximoElementosSeleccionados = 1
        Me.SucursalC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.SucursalC.MostrarAlertas = False
        Me.SucursalC.Name = ""
        Me.SucursalC.RaiseListChangedEvents = True
        Me.SucursalC.Transaction = Nothing
        '
        'SolicitudServDetC
        '
        Me.SolicitudServDetC.AllowEdit = True
        Me.SolicitudServDetC.AllowNew = True
        Me.SolicitudServDetC.AllowRemove = True
        Me.SolicitudServDetC.MaximoElementosSeleccionados = 1
        Me.SolicitudServDetC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.SolicitudServDetC.MostrarAlertas = False
        Me.SolicitudServDetC.Name = ""
        Me.SolicitudServDetC.RaiseListChangedEvents = True
        Me.SolicitudServDetC.Transaction = Nothing
        '
        'Tmplaza
        '
        Me.Tmplaza.Interval = 1000
        '
        'TmSucursal
        '
        Me.TmSucursal.Interval = 1000
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Location = New System.Drawing.Point(524, 92)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(410, 75)
        Me.txtObservaciones.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(437, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Observaciones:"
        '
        'txtEntregarEn
        '
        Me.txtEntregarEn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEntregarEn.Location = New System.Drawing.Point(145, 145)
        Me.txtEntregarEn.MaxLength = 50
        Me.txtEntregarEn.Name = "txtEntregarEn"
        Me.txtEntregarEn.Size = New System.Drawing.Size(282, 20)
        Me.txtEntregarEn.TabIndex = 4
        '
        'txtEntregarA
        '
        Me.txtEntregarA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEntregarA.Location = New System.Drawing.Point(145, 119)
        Me.txtEntregarA.MaxLength = 50
        Me.txtEntregarA.Name = "txtEntregarA"
        Me.txtEntregarA.Size = New System.Drawing.Size(282, 20)
        Me.txtEntregarA.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Entregar en:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(57, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Entregar a:"
        '
        'txtPara
        '
        Me.txtPara.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPara.Location = New System.Drawing.Point(145, 93)
        Me.txtPara.Name = "txtPara"
        Me.txtPara.Size = New System.Drawing.Size(282, 20)
        Me.txtPara.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(57, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Para:"
        '
        'clmFolio
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.clmFolio.DefaultCellStyle = DataGridViewCellStyle7
        Me.clmFolio.HeaderText = "Folio"
        Me.clmFolio.Name = "clmFolio"
        Me.clmFolio.Visible = False
        '
        'clmIndice
        '
        Me.clmIndice.DataPropertyName = "indice"
        Me.clmIndice.HeaderText = "Indice"
        Me.clmIndice.Name = "clmIndice"
        Me.clmIndice.Visible = False
        '
        'clmServicio
        '
        Me.clmServicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.clmServicio.DataPropertyName = "Servicio"
        Me.clmServicio.HeaderText = "Servicio"
        Me.clmServicio.Name = "clmServicio"
        Me.clmServicio.Width = 250
        '
        'clmCantidad
        '
        Me.clmCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.clmCantidad.DataPropertyName = "cantidad"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.clmCantidad.DefaultCellStyle = DataGridViewCellStyle8
        Me.clmCantidad.HeaderText = "Cantidad"
        Me.clmCantidad.Name = "clmCantidad"
        Me.clmCantidad.Width = 95
        '
        'clmUrgente
        '
        Me.clmUrgente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.clmUrgente.DataPropertyName = "urgente"
        Me.clmUrgente.HeaderText = "Urgente"
        Me.clmUrgente.Name = "clmUrgente"
        Me.clmUrgente.Width = 70
        '
        'clmObservaciones
        '
        Me.clmObservaciones.DataPropertyName = "Observaciones"
        Me.clmObservaciones.HeaderText = "Observaciones"
        Me.clmObservaciones.Name = "clmObservaciones"
        Me.clmObservaciones.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmObservaciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clmObservaciones.Width = 390
        '
        'clmEstatus
        '
        Me.clmEstatus.DataPropertyName = "estatus"
        Me.clmEstatus.HeaderText = "Estatus"
        Me.clmEstatus.Name = "clmEstatus"
        Me.clmEstatus.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmEstatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clmEstatus.Visible = False
        '
        'clmFecha
        '
        Me.clmFecha.DataPropertyName = "FechaServicio"
        Me.clmFecha.HeaderText = "Fecha Servicio"
        Me.clmFecha.Name = "clmFecha"
        Me.clmFecha.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmFecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clmFecha.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(182, 217)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Cantidad Total:"
        '
        'ComSolicitudServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 422)
        Me.Controls.Add(Me.txtPara)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtEntregarEn)
        Me.Controls.Add(Me.txtEntregarA)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblEstatus)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DtpFecha)
        Me.Controls.Add(Me.txtSolicita)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.CmbPlaza)
        Me.Controls.Add(Me.CmbSucursal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(972, 456)
        Me.MinimumSize = New System.Drawing.Size(972, 456)
        Me.Name = "ComSolicitudServicios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solicitud de Servicios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvDetalleSolic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CmbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents CmbPlaza As System.Windows.Forms.ComboBox
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents txtSolicita As System.Windows.Forms.TextBox
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSuma As System.Windows.Forms.TextBox
    Friend WithEvents DgvDetalleSolic As System.Windows.Forms.DataGridView
    Friend WithEvents SucursalC As ClasesNegocio.SucursalCollectionClass
    Friend WithEvents PlazaC As ClasesNegocio.PlazaCollectionClass
    Friend WithEvents SolicitudServDetC As ClasesNegocio.SolicitudServDetCollectionClass
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents Tmplaza As System.Windows.Forms.Timer
    Friend WithEvents TmSucursal As System.Windows.Forms.Timer
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtEntregarEn As System.Windows.Forms.TextBox
    Friend WithEvents txtEntregarA As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPara As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents clmFolio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIndice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmServicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmUrgente As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents clmObservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
