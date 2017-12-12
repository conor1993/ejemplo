<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormaReportes
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
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbRecepciones = New System.Windows.Forms.RadioButton()
        Me.rbOrdenes = New System.Windows.Forms.RadioButton()
        Me.rbSolicitudes = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFolio = New System.Windows.Forms.TextBox()
        Me.dtFechaF = New System.Windows.Forms.DateTimePicker()
        Me.dtFechaI = New System.Windows.Forms.DateTimePicker()
        Me.cmbProducto = New System.Windows.Forms.ComboBox()
        Me.ProductoC = New ClasesNegocio.ProductoCollectionClass()
        Me.cmbProveedor = New System.Windows.Forms.ComboBox()
        Me.ProveedorC = New ClasesNegocio.ProveedorCollectionClass()
        Me.cmbSucursal = New System.Windows.Forms.ComboBox()
        Me.SucursalC = New ClasesNegocio.SucursalCollectionClass()
        Me.cmbPlaza = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RbtRecepServ = New System.Windows.Forms.RadioButton()
        Me.RbtOrdSer = New System.Windows.Forms.RadioButton()
        Me.RbtCotizServ = New System.Windows.Forms.RadioButton()
        Me.rbtSolSer = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rbtServicios = New System.Windows.Forms.RadioButton()
        Me.rbtCompras = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'MEAToolBar1
        '
        Me.MEAToolBar1.ButtonSize = New System.Drawing.Size(50, 50)
        Me.MEAToolBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MEAToolBar1.DropDownArrows = True
        Me.MEAToolBar1.HabilitarBorrar = True
        Me.MEAToolBar1.HabilitarBuscar = False
        Me.MEAToolBar1.HabilitarCancelar = True
        Me.MEAToolBar1.HabilitarEditar = True
        Me.MEAToolBar1.HabilitarGuardar = True
        Me.MEAToolBar1.HabilitarImprimir = True
        Me.MEAToolBar1.HabilitarLimpiar = True
        Me.MEAToolBar1.HabilitarNuevo = True
        Me.MEAToolBar1.HabilitarSalir = True
        Me.MEAToolBar1.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32
        Me.MEAToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.MEAToolBar1.MostrarBorrar = False
        Me.MEAToolBar1.MostrarBuscar = False
        Me.MEAToolBar1.MostrarCancelar = False
        Me.MEAToolBar1.MostrarEditar = False
        Me.MEAToolBar1.MostrarGuardar = False
        Me.MEAToolBar1.MostrarImprimir = True
        Me.MEAToolBar1.MostrarLimpiar = True
        Me.MEAToolBar1.MostrarNuevo = False
        Me.MEAToolBar1.MostrarSalir = True
        Me.MEAToolBar1.Name = "MEAToolBar1"
        Me.MEAToolBar1.ShowToolTips = True
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 406)
        Me.MEAToolBar1.TabIndex = 60
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbRecepciones)
        Me.GroupBox1.Controls.Add(Me.rbOrdenes)
        Me.GroupBox1.Controls.Add(Me.rbSolicitudes)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(56, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(148, 116)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Compras"
        '
        'rbRecepciones
        '
        Me.rbRecepciones.AutoSize = True
        Me.rbRecepciones.Location = New System.Drawing.Point(16, 66)
        Me.rbRecepciones.Name = "rbRecepciones"
        Me.rbRecepciones.Size = New System.Drawing.Size(88, 17)
        Me.rbRecepciones.TabIndex = 4
        Me.rbRecepciones.TabStop = True
        Me.rbRecepciones.Text = "Recepciones"
        Me.rbRecepciones.UseVisualStyleBackColor = True
        '
        'rbOrdenes
        '
        Me.rbOrdenes.AutoSize = True
        Me.rbOrdenes.Location = New System.Drawing.Point(16, 43)
        Me.rbOrdenes.Name = "rbOrdenes"
        Me.rbOrdenes.Size = New System.Drawing.Size(119, 17)
        Me.rbOrdenes.TabIndex = 3
        Me.rbOrdenes.TabStop = True
        Me.rbOrdenes.Text = "Ordenes de Compra"
        Me.rbOrdenes.UseVisualStyleBackColor = True
        '
        'rbSolicitudes
        '
        Me.rbSolicitudes.AutoSize = True
        Me.rbSolicitudes.Location = New System.Drawing.Point(16, 20)
        Me.rbSolicitudes.Name = "rbSolicitudes"
        Me.rbSolicitudes.Size = New System.Drawing.Size(76, 17)
        Me.rbSolicitudes.TabIndex = 0
        Me.rbSolicitudes.TabStop = True
        Me.rbSolicitudes.Text = "Solicitudes"
        Me.rbSolicitudes.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtFolio)
        Me.GroupBox2.Controls.Add(Me.dtFechaF)
        Me.GroupBox2.Controls.Add(Me.dtFechaI)
        Me.GroupBox2.Controls.Add(Me.cmbProducto)
        Me.GroupBox2.Controls.Add(Me.cmbProveedor)
        Me.GroupBox2.Controls.Add(Me.cmbSucursal)
        Me.GroupBox2.Controls.Add(Me.cmbPlaza)
        Me.GroupBox2.Location = New System.Drawing.Point(370, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(362, 166)
        Me.GroupBox2.TabIndex = 62
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrado Por"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(216, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "a"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Fecha:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Folio:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Producto:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Proveedor:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Sucursal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Plaza:"
        '
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(102, 111)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(108, 20)
        Me.txtFolio.TabIndex = 13
        '
        'dtFechaF
        '
        Me.dtFechaF.CustomFormat = "dd/MMM/yyyy"
        Me.dtFechaF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFechaF.Location = New System.Drawing.Point(240, 133)
        Me.dtFechaF.Name = "dtFechaF"
        Me.dtFechaF.Size = New System.Drawing.Size(108, 20)
        Me.dtFechaF.TabIndex = 12
        '
        'dtFechaI
        '
        Me.dtFechaI.CustomFormat = "dd/MMM/yyyy"
        Me.dtFechaI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFechaI.Location = New System.Drawing.Point(102, 133)
        Me.dtFechaI.Name = "dtFechaI"
        Me.dtFechaI.Size = New System.Drawing.Size(108, 20)
        Me.dtFechaI.TabIndex = 11
        '
        'cmbProducto
        '
        Me.cmbProducto.DataSource = Me.ProductoC
        Me.cmbProducto.DisplayMember = "Descripcion"
        Me.cmbProducto.FormattingEnabled = True
        Me.cmbProducto.Location = New System.Drawing.Point(102, 88)
        Me.cmbProducto.Name = "cmbProducto"
        Me.cmbProducto.Size = New System.Drawing.Size(246, 21)
        Me.cmbProducto.TabIndex = 9
        Me.cmbProducto.ValueMember = "Codigo"
        '
        'ProductoC
        '
        Me.ProductoC.AllowEdit = True
        Me.ProductoC.AllowNew = True
        Me.ProductoC.AllowRemove = True
        Me.ProductoC.MaximoElementosSeleccionados = 1
        Me.ProductoC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.ProductoC.MostrarAlertas = False
        Me.ProductoC.Name = ""
        Me.ProductoC.RaiseListChangedEvents = True
        Me.ProductoC.Transaction = Nothing
        '
        'cmbProveedor
        '
        Me.cmbProveedor.DataSource = Me.ProveedorC
        Me.cmbProveedor.DisplayMember = "RazonSocial"
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(102, 66)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(246, 21)
        Me.cmbProveedor.TabIndex = 8
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
        'cmbSucursal
        '
        Me.cmbSucursal.DataSource = Me.SucursalC
        Me.cmbSucursal.DisplayMember = "Descripcion"
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(102, 43)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(246, 21)
        Me.cmbSucursal.TabIndex = 7
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
        Me.cmbPlaza.FormattingEnabled = True
        Me.cmbPlaza.Location = New System.Drawing.Point(102, 21)
        Me.cmbPlaza.Name = "cmbPlaza"
        Me.cmbPlaza.Size = New System.Drawing.Size(246, 21)
        Me.cmbPlaza.TabIndex = 6
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(56, 301)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(676, 203)
        Me.DataGridView1.TabIndex = 63
        Me.DataGridView1.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RbtRecepServ)
        Me.GroupBox3.Controls.Add(Me.RbtOrdSer)
        Me.GroupBox3.Controls.Add(Me.RbtCotizServ)
        Me.GroupBox3.Controls.Add(Me.rbtSolSer)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Location = New System.Drawing.Point(210, 59)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(154, 116)
        Me.GroupBox3.TabIndex = 62
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Servicios"
        '
        'RbtRecepServ
        '
        Me.RbtRecepServ.AutoSize = True
        Me.RbtRecepServ.Location = New System.Drawing.Point(16, 88)
        Me.RbtRecepServ.Name = "RbtRecepServ"
        Me.RbtRecepServ.Size = New System.Drawing.Size(88, 17)
        Me.RbtRecepServ.TabIndex = 4
        Me.RbtRecepServ.TabStop = True
        Me.RbtRecepServ.Text = "Recepciones"
        Me.RbtRecepServ.UseVisualStyleBackColor = True
        '
        'RbtOrdSer
        '
        Me.RbtOrdSer.AutoSize = True
        Me.RbtOrdSer.Location = New System.Drawing.Point(16, 65)
        Me.RbtOrdSer.Name = "RbtOrdSer"
        Me.RbtOrdSer.Size = New System.Drawing.Size(126, 17)
        Me.RbtOrdSer.TabIndex = 3
        Me.RbtOrdSer.TabStop = True
        Me.RbtOrdSer.Text = "Ordenes de Servicios"
        Me.RbtOrdSer.UseVisualStyleBackColor = True
        '
        'RbtCotizServ
        '
        Me.RbtCotizServ.AutoSize = True
        Me.RbtCotizServ.Location = New System.Drawing.Point(16, 42)
        Me.RbtCotizServ.Name = "RbtCotizServ"
        Me.RbtCotizServ.Size = New System.Drawing.Size(85, 17)
        Me.RbtCotizServ.TabIndex = 2
        Me.RbtCotizServ.TabStop = True
        Me.RbtCotizServ.Text = "Cotizaciones"
        Me.RbtCotizServ.UseVisualStyleBackColor = True
        '
        'rbtSolSer
        '
        Me.rbtSolSer.AutoSize = True
        Me.rbtSolSer.Location = New System.Drawing.Point(16, 19)
        Me.rbtSolSer.Name = "rbtSolSer"
        Me.rbtSolSer.Size = New System.Drawing.Size(76, 17)
        Me.rbtSolSer.TabIndex = 0
        Me.rbtSolSer.TabStop = True
        Me.rbtSolSer.Text = "Solicitudes"
        Me.rbtSolSer.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbtServicios)
        Me.GroupBox4.Controls.Add(Me.rbtCompras)
        Me.GroupBox4.Location = New System.Drawing.Point(56, 9)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(308, 47)
        Me.GroupBox4.TabIndex = 64
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Reportes"
        '
        'rbtServicios
        '
        Me.rbtServicios.AutoSize = True
        Me.rbtServicios.Location = New System.Drawing.Point(170, 19)
        Me.rbtServicios.Name = "rbtServicios"
        Me.rbtServicios.Size = New System.Drawing.Size(68, 17)
        Me.rbtServicios.TabIndex = 1
        Me.rbtServicios.TabStop = True
        Me.rbtServicios.Text = "Servicios"
        Me.rbtServicios.UseVisualStyleBackColor = True
        '
        'rbtCompras
        '
        Me.rbtCompras.AutoSize = True
        Me.rbtCompras.Location = New System.Drawing.Point(16, 19)
        Me.rbtCompras.Name = "rbtCompras"
        Me.rbtCompras.Size = New System.Drawing.Size(66, 17)
        Me.rbtCompras.TabIndex = 0
        Me.rbtCompras.TabStop = True
        Me.rbtCompras.Text = "Compras"
        Me.rbtCompras.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(56, 199)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(662, 65)
        Me.TextBox1.TabIndex = 65
        '
        'FormaReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 406)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.MaximizeBox = False
        Me.Name = "FormaReportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbRecepciones As System.Windows.Forms.RadioButton
    Friend WithEvents rbOrdenes As System.Windows.Forms.RadioButton
    Friend WithEvents rbSolicitudes As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbProducto As System.Windows.Forms.ComboBox
    Friend WithEvents cmbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPlaza As System.Windows.Forms.ComboBox
    Friend WithEvents dtFechaI As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFechaF As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents ProveedorC As ClasesNegocio.ProveedorCollectionClass
    Friend WithEvents ProductoC As ClasesNegocio.ProductoCollectionClass
    Friend WithEvents SucursalC As ClasesNegocio.SucursalCollectionClass
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RbtRecepServ As System.Windows.Forms.RadioButton
    Friend WithEvents RbtOrdSer As System.Windows.Forms.RadioButton
    Friend WithEvents RbtCotizServ As System.Windows.Forms.RadioButton
    Friend WithEvents rbtSolSer As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtServicios As System.Windows.Forms.RadioButton
    Friend WithEvents rbtCompras As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
