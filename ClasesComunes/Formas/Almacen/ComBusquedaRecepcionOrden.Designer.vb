<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComBusquedaRecepcionOrden
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
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbSucursal = New System.Windows.Forms.ComboBox
        Me.cmbPlaza = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbProveedor = New System.Windows.Forms.ComboBox
        Me.ProveedorC = New ClasesNegocio.ProveedorCollectionClass
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.clmidCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFolioRecep = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFolioOrden = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmSucursal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPlaza = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmAlmacen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIdRecepcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIdOrdenCompra = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AlmacenC = New ClasesNegocio.AlmacenCollectionClass
        Me.CmbAlmacen = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GrpFechas = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.ChkFechas = New System.Windows.Forms.CheckBox
        Me.DtpFechaFin = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.DtpFechaini = New System.Windows.Forms.DateTimePicker
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbtnTodas = New System.Windows.Forms.RadioButton
        Me.rbtnCanceladas = New System.Windows.Forms.RadioButton
        Me.rbtnVigentes = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpFechas.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 537)
        Me.MEAToolBar1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(50, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(958, 29)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "BUSQUEDA DE RECEPCIONES DE  ORDENES DE COMPRA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbSucursal
        '
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(145, 63)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(275, 21)
        Me.cmbSucursal.TabIndex = 19
        '
        'cmbPlaza
        '
        Me.cmbPlaza.DisplayMember = "Descripcion"
        Me.cmbPlaza.FormattingEnabled = True
        Me.cmbPlaza.Location = New System.Drawing.Point(145, 36)
        Me.cmbPlaza.Name = "cmbPlaza"
        Me.cmbPlaza.Size = New System.Drawing.Size(275, 21)
        Me.cmbPlaza.TabIndex = 18
        Me.cmbPlaza.ValueMember = "Codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Sucursal:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Plaza:"
        '
        'cmbProveedor
        '
        Me.cmbProveedor.DataSource = Me.ProveedorC
        Me.cmbProveedor.DisplayMember = "RazonSocial"
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(145, 90)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(275, 21)
        Me.cmbProveedor.TabIndex = 42
        Me.cmbProveedor.ValueMember = "Codigo"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Proveedor:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(55, 156)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(941, 369)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de Recepciones de Orden"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmidCodigo, Me.clmFolioRecep, Me.clmFolioOrden, Me.clmSucursal, Me.clmPlaza, Me.clmAlmacen, Me.clmProveedor, Me.clmEstatus, Me.clmFecha, Me.clmIdRecepcion, Me.clmIdOrdenCompra})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 22)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(930, 341)
        Me.DataGridView1.TabIndex = 0
        '
        'clmidCodigo
        '
        Me.clmidCodigo.DataPropertyName = "IdOrdenCompra"
        Me.clmidCodigo.HeaderText = "Id-Codio"
        Me.clmidCodigo.Name = "clmidCodigo"
        Me.clmidCodigo.Visible = False
        '
        'clmFolioRecep
        '
        Me.clmFolioRecep.DataPropertyName = "FolioRecepcionOrdenCompra"
        Me.clmFolioRecep.HeaderText = "Folio "
        Me.clmFolioRecep.Name = "clmFolioRecep"
        Me.clmFolioRecep.ReadOnly = True
        Me.clmFolioRecep.Width = 120
        '
        'clmFolioOrden
        '
        Me.clmFolioOrden.DataPropertyName = "FolioOrdenCompra"
        Me.clmFolioOrden.HeaderText = "Folio Orden"
        Me.clmFolioOrden.Name = "clmFolioOrden"
        Me.clmFolioOrden.ReadOnly = True
        Me.clmFolioOrden.Width = 130
        '
        'clmSucursal
        '
        Me.clmSucursal.DataPropertyName = "Sucursal"
        Me.clmSucursal.HeaderText = "Sucursal"
        Me.clmSucursal.Name = "clmSucursal"
        Me.clmSucursal.ReadOnly = True
        Me.clmSucursal.Width = 120
        '
        'clmPlaza
        '
        Me.clmPlaza.DataPropertyName = "plaza"
        Me.clmPlaza.HeaderText = "Plaza"
        Me.clmPlaza.Name = "clmPlaza"
        Me.clmPlaza.ReadOnly = True
        Me.clmPlaza.Width = 120
        '
        'clmAlmacen
        '
        Me.clmAlmacen.DataPropertyName = "Nombre"
        Me.clmAlmacen.HeaderText = "Almacén"
        Me.clmAlmacen.Name = "clmAlmacen"
        Me.clmAlmacen.Width = 120
        '
        'clmProveedor
        '
        Me.clmProveedor.DataPropertyName = "Proveedor"
        Me.clmProveedor.HeaderText = "Proveedor"
        Me.clmProveedor.Name = "clmProveedor"
        Me.clmProveedor.ReadOnly = True
        Me.clmProveedor.Width = 200
        '
        'clmEstatus
        '
        Me.clmEstatus.DataPropertyName = "Estatus"
        Me.clmEstatus.HeaderText = "Estatus"
        Me.clmEstatus.Name = "clmEstatus"
        Me.clmEstatus.ReadOnly = True
        '
        'clmFecha
        '
        Me.clmFecha.DataPropertyName = "FechaRecepcion"
        Me.clmFecha.HeaderText = "Fecha "
        Me.clmFecha.Name = "clmFecha"
        Me.clmFecha.ReadOnly = True
        '
        'clmIdRecepcion
        '
        Me.clmIdRecepcion.DataPropertyName = "idRecepcionOrdenCompra"
        Me.clmIdRecepcion.HeaderText = "IdRecepcion"
        Me.clmIdRecepcion.Name = "clmIdRecepcion"
        Me.clmIdRecepcion.Visible = False
        '
        'clmIdOrdenCompra
        '
        Me.clmIdOrdenCompra.DataPropertyName = "IdOrdenCompra"
        Me.clmIdOrdenCompra.HeaderText = "IdOrden"
        Me.clmIdOrdenCompra.Name = "clmIdOrdenCompra"
        Me.clmIdOrdenCompra.Visible = False
        '
        'AlmacenC
        '
        Me.AlmacenC.AllowEdit = True
        Me.AlmacenC.AllowNew = True
        Me.AlmacenC.AllowRemove = True
        Me.AlmacenC.Name = ""
        Me.AlmacenC.RaiseListChangedEvents = True
        Me.AlmacenC.Tipo = ClasesNegocio.AlmacenEnum.ALMACEN
        '
        'CmbAlmacen
        '
        Me.CmbAlmacen.DataSource = Me.AlmacenC
        Me.CmbAlmacen.DisplayMember = "Descripcion"
        Me.CmbAlmacen.Enabled = False
        Me.CmbAlmacen.FormattingEnabled = True
        Me.CmbAlmacen.Location = New System.Drawing.Point(145, 117)
        Me.CmbAlmacen.Name = "CmbAlmacen"
        Me.CmbAlmacen.Size = New System.Drawing.Size(275, 21)
        Me.CmbAlmacen.TabIndex = 47
        Me.CmbAlmacen.ValueMember = "Codigo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Almacén:"
        '
        'GrpFechas
        '
        Me.GrpFechas.Controls.Add(Me.Label7)
        Me.GrpFechas.Controls.Add(Me.ChkFechas)
        Me.GrpFechas.Controls.Add(Me.DtpFechaFin)
        Me.GrpFechas.Controls.Add(Me.Label6)
        Me.GrpFechas.Controls.Add(Me.DtpFechaini)
        Me.GrpFechas.Enabled = False
        Me.GrpFechas.Location = New System.Drawing.Point(455, 52)
        Me.GrpFechas.Name = "GrpFechas"
        Me.GrpFechas.Size = New System.Drawing.Size(200, 77)
        Me.GrpFechas.TabIndex = 48
        Me.GrpFechas.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Fecha Final:"
        '
        'ChkFechas
        '
        Me.ChkFechas.AutoSize = True
        Me.ChkFechas.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ChkFechas.Location = New System.Drawing.Point(9, 0)
        Me.ChkFechas.Name = "ChkFechas"
        Me.ChkFechas.Size = New System.Drawing.Size(111, 17)
        Me.ChkFechas.TabIndex = 49
        Me.ChkFechas.Text = "Rango de Fechas"
        Me.ChkFechas.UseVisualStyleBackColor = True
        '
        'DtpFechaFin
        '
        Me.DtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaFin.Location = New System.Drawing.Point(94, 45)
        Me.DtpFechaFin.Name = "DtpFechaFin"
        Me.DtpFechaFin.Size = New System.Drawing.Size(91, 20)
        Me.DtpFechaFin.TabIndex = 52
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Fecha Inicial:"
        '
        'DtpFechaini
        '
        Me.DtpFechaini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaini.Location = New System.Drawing.Point(94, 19)
        Me.DtpFechaini.Name = "DtpFechaini"
        Me.DtpFechaini.Size = New System.Drawing.Size(91, 20)
        Me.DtpFechaini.TabIndex = 53
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbtnTodas)
        Me.GroupBox2.Controls.Add(Me.rbtnCanceladas)
        Me.GroupBox2.Controls.Add(Me.rbtnVigentes)
        Me.GroupBox2.Location = New System.Drawing.Point(695, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(125, 88)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estatus"
        '
        'rbtnTodas
        '
        Me.rbtnTodas.AutoSize = True
        Me.rbtnTodas.Location = New System.Drawing.Point(6, 65)
        Me.rbtnTodas.Name = "rbtnTodas"
        Me.rbtnTodas.Size = New System.Drawing.Size(62, 17)
        Me.rbtnTodas.TabIndex = 2
        Me.rbtnTodas.Text = "TODAS"
        Me.rbtnTodas.UseVisualStyleBackColor = True
        '
        'rbtnCanceladas
        '
        Me.rbtnCanceladas.AutoSize = True
        Me.rbtnCanceladas.Location = New System.Drawing.Point(6, 42)
        Me.rbtnCanceladas.Name = "rbtnCanceladas"
        Me.rbtnCanceladas.Size = New System.Drawing.Size(96, 17)
        Me.rbtnCanceladas.TabIndex = 1
        Me.rbtnCanceladas.Text = "CANCELADAS"
        Me.rbtnCanceladas.UseVisualStyleBackColor = True
        '
        'rbtnVigentes
        '
        Me.rbtnVigentes.AutoSize = True
        Me.rbtnVigentes.Checked = True
        Me.rbtnVigentes.Location = New System.Drawing.Point(6, 19)
        Me.rbtnVigentes.Name = "rbtnVigentes"
        Me.rbtnVigentes.Size = New System.Drawing.Size(79, 17)
        Me.rbtnVigentes.TabIndex = 0
        Me.rbtnVigentes.TabStop = True
        Me.rbtnVigentes.Text = "VIGENTES"
        Me.rbtnVigentes.UseVisualStyleBackColor = True
        '
        'ComBusquedaRecepcionOrden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 537)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GrpFechas)
        Me.Controls.Add(Me.CmbAlmacen)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbProveedor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbSucursal)
        Me.Controls.Add(Me.cmbPlaza)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ComBusquedaRecepcionOrden"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de Recepciones de Ordenes de Compra"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpFechas.ResumeLayout(False)
        Me.GrpFechas.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPlaza As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ProveedorC As ClasesNegocio.ProveedorCollectionClass
    Friend WithEvents AlmacenC As ClasesNegocio.AlmacenCollectionClass
    Friend WithEvents CmbAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GrpFechas As System.Windows.Forms.GroupBox
    Friend WithEvents ChkFechas As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpFechaini As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnTodas As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnCanceladas As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnVigentes As System.Windows.Forms.RadioButton
    Friend WithEvents clmidCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFolioRecep As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFolioOrden As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSucursal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPlaza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmAlmacen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdRecepcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdOrdenCompra As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
