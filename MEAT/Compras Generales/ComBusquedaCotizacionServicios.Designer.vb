<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComBusquedaCotizacionServicios
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
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar
        Me.Label5 = New System.Windows.Forms.Label
        Me.chkFechas = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.DtpFechaFin = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.DtpFechaIni = New System.Windows.Forms.DateTimePicker
        Me.cmbSucursal = New System.Windows.Forms.ComboBox
        Me.SucursalC = New ClasesNegocio.SucursalCollectionClass
        Me.cmbPlaza = New System.Windows.Forms.ComboBox
        Me.PlazaC = New ClasesNegocio.PlazaCollectionClass
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.CmbProveedor = New System.Windows.Forms.ComboBox
        Me.ProveedorC = New ClasesNegocio.ProveedorCollectionClass
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.clmFolio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFechaAlta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPlaza = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmSucursal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.chkFiltro = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MEAToolBar1
        '
        Me.MEAToolBar1.ButtonSize = New System.Drawing.Size(50, 50)
        Me.MEAToolBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MEAToolBar1.DropDownArrows = True
        Me.MEAToolBar1.HabilitarBorrar = False
        Me.MEAToolBar1.HabilitarBuscar = True
        Me.MEAToolBar1.HabilitarCancelar = False
        Me.MEAToolBar1.HabilitarEditar = False
        Me.MEAToolBar1.HabilitarGuardar = False
        Me.MEAToolBar1.HabilitarImprimir = False
        Me.MEAToolBar1.HabilitarLimpiar = True
        Me.MEAToolBar1.HabilitarNuevo = False
        Me.MEAToolBar1.HabilitarSalir = True
        Me.MEAToolBar1.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32
        Me.MEAToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.MEAToolBar1.MostrarBorrar = False
        Me.MEAToolBar1.MostrarBuscar = True
        Me.MEAToolBar1.MostrarCancelar = False
        Me.MEAToolBar1.MostrarEditar = False
        Me.MEAToolBar1.MostrarGuardar = False
        Me.MEAToolBar1.MostrarImprimir = False
        Me.MEAToolBar1.MostrarLimpiar = True
        Me.MEAToolBar1.MostrarNuevo = False
        Me.MEAToolBar1.MostrarSalir = True
        Me.MEAToolBar1.Name = "MEAToolBar1"
        Me.MEAToolBar1.ShowToolTips = True
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 388)
        Me.MEAToolBar1.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SteelBlue
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(50, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(751, 29)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "BUSQUEDA DE COTIZACIONES DE SERVICIOS"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkFechas
        '
        Me.chkFechas.AutoSize = True
        Me.chkFechas.ForeColor = System.Drawing.SystemColors.Highlight
        Me.chkFechas.Location = New System.Drawing.Point(11, 0)
        Me.chkFechas.Name = "chkFechas"
        Me.chkFechas.Size = New System.Drawing.Size(111, 17)
        Me.chkFechas.TabIndex = 36
        Me.chkFechas.Text = "Rango de Fechas"
        Me.chkFechas.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DtpFechaFin)
        Me.GroupBox1.Controls.Add(Me.chkFechas)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DtpFechaIni)
        Me.GroupBox1.Location = New System.Drawing.Point(460, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(281, 108)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha Final:"
        '
        'DtpFechaFin
        '
        Me.DtpFechaFin.Enabled = False
        Me.DtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaFin.Location = New System.Drawing.Point(152, 63)
        Me.DtpFechaFin.Name = "DtpFechaFin"
        Me.DtpFechaFin.Size = New System.Drawing.Size(93, 20)
        Me.DtpFechaFin.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha Inicial:"
        '
        'DtpFechaIni
        '
        Me.DtpFechaIni.Enabled = False
        Me.DtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaIni.Location = New System.Drawing.Point(152, 30)
        Me.DtpFechaIni.Name = "DtpFechaIni"
        Me.DtpFechaIni.Size = New System.Drawing.Size(93, 20)
        Me.DtpFechaIni.TabIndex = 0
        '
        'cmbSucursal
        '
        Me.cmbSucursal.DataSource = Me.SucursalC
        Me.cmbSucursal.DisplayMember = "Descripcion"
        Me.cmbSucursal.Enabled = False
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(101, 46)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(275, 21)
        Me.cmbSucursal.TabIndex = 34
        Me.cmbSucursal.ValueMember = "Codigo"
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
        'cmbPlaza
        '
        Me.cmbPlaza.DataSource = Me.PlazaC
        Me.cmbPlaza.DisplayMember = "Descripcion"
        Me.cmbPlaza.Enabled = False
        Me.cmbPlaza.FormattingEnabled = True
        Me.cmbPlaza.Location = New System.Drawing.Point(101, 19)
        Me.cmbPlaza.Name = "cmbPlaza"
        Me.cmbPlaza.Size = New System.Drawing.Size(275, 21)
        Me.cmbPlaza.TabIndex = 33
        Me.cmbPlaza.ValueMember = "Codigo"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Sucursal:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Plaza:"
        '
        'CmbProveedor
        '
        Me.CmbProveedor.DataSource = Me.ProveedorC
        Me.CmbProveedor.DisplayMember = "RazonSocial"
        Me.CmbProveedor.Enabled = False
        Me.CmbProveedor.FormattingEnabled = True
        Me.CmbProveedor.Location = New System.Drawing.Point(101, 73)
        Me.CmbProveedor.Name = "CmbProveedor"
        Me.CmbProveedor.Size = New System.Drawing.Size(275, 21)
        Me.CmbProveedor.TabIndex = 38
        Me.CmbProveedor.ValueMember = "Codigo"
        '
        'ProveedorC
        '
        Me.ProveedorC.AllowEdit = True
        Me.ProveedorC.AllowNew = True
        Me.ProveedorC.AllowRemove = True
        Me.ProveedorC.MaximoElementosSeleccionados = 1
        Me.ProveedorC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.ProveedorC.Mostrar = ClasesNegocio.MostrarEnum.CLIENTES
        Me.ProveedorC.MostrarAlertas = False
        Me.ProveedorC.Name = ""
        Me.ProveedorC.RaiseListChangedEvents = True
        Me.ProveedorC.Transaction = Nothing
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Proveedor:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(51, 150)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(738, 228)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cotizaciones de Servicios"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmFolio, Me.clmFechaAlta, Me.clmPlaza, Me.clmSucursal, Me.clmProveedor, Me.clmEstatus})
        Me.DataGridView1.Location = New System.Drawing.Point(9, 19)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(723, 193)
        Me.DataGridView1.TabIndex = 0
        '
        'clmFolio
        '
        Me.clmFolio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clmFolio.DataPropertyName = "Folio"
        Me.clmFolio.HeaderText = "Folio"
        Me.clmFolio.Name = "clmFolio"
        Me.clmFolio.ReadOnly = True
        Me.clmFolio.Width = 57
        '
        'clmFechaAlta
        '
        Me.clmFechaAlta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clmFechaAlta.DataPropertyName = "FechaAlta"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.clmFechaAlta.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmFechaAlta.HeaderText = "Fecha Alta"
        Me.clmFechaAlta.Name = "clmFechaAlta"
        Me.clmFechaAlta.ReadOnly = True
        Me.clmFechaAlta.Width = 91
        '
        'clmPlaza
        '
        Me.clmPlaza.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clmPlaza.DataPropertyName = "Plaza"
        Me.clmPlaza.HeaderText = "Plaza"
        Me.clmPlaza.Name = "clmPlaza"
        Me.clmPlaza.ReadOnly = True
        Me.clmPlaza.Width = 61
        '
        'clmSucursal
        '
        Me.clmSucursal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clmSucursal.DataPropertyName = "Sucursal"
        Me.clmSucursal.HeaderText = "Sucursal"
        Me.clmSucursal.Name = "clmSucursal"
        Me.clmSucursal.ReadOnly = True
        Me.clmSucursal.Width = 79
        '
        'clmProveedor
        '
        Me.clmProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clmProveedor.DataPropertyName = "Proveedor"
        Me.clmProveedor.HeaderText = "Proveedor"
        Me.clmProveedor.Name = "clmProveedor"
        Me.clmProveedor.Width = 88
        '
        'clmEstatus
        '
        Me.clmEstatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clmEstatus.DataPropertyName = "Estatus"
        Me.clmEstatus.HeaderText = "Estatus"
        Me.clmEstatus.Name = "clmEstatus"
        Me.clmEstatus.ReadOnly = True
        Me.clmEstatus.Width = 72
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkFiltro)
        Me.GroupBox3.Controls.Add(Me.cmbPlaza)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.CmbProveedor)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.cmbSucursal)
        Me.GroupBox3.Location = New System.Drawing.Point(53, 36)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(392, 108)
        Me.GroupBox3.TabIndex = 40
        Me.GroupBox3.TabStop = False
        '
        'chkFiltro
        '
        Me.chkFiltro.AutoSize = True
        Me.chkFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFiltro.ForeColor = System.Drawing.SystemColors.Highlight
        Me.chkFiltro.Location = New System.Drawing.Point(14, 0)
        Me.chkFiltro.Name = "chkFiltro"
        Me.chkFiltro.Size = New System.Drawing.Size(81, 19)
        Me.chkFiltro.TabIndex = 39
        Me.chkFiltro.Text = "Filtrar por:"
        Me.chkFiltro.UseVisualStyleBackColor = True
        '
        'ComBusquedaCotizacionServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 388)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(809, 422)
        Me.MinimumSize = New System.Drawing.Size(809, 422)
        Me.Name = "ComBusquedaCotizacionServicios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de Cotizaciones de Servicios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkFechas As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DtpFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPlaza As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SucursalC As ClasesNegocio.SucursalCollectionClass
    Friend WithEvents PlazaC As ClasesNegocio.PlazaCollectionClass
    Friend WithEvents ProveedorC As ClasesNegocio.ProveedorCollectionClass
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents clmFolio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaAlta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPlaza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSucursal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkFiltro As System.Windows.Forms.CheckBox
End Class
