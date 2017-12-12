<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmABCPrecioxClienteDestino
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label17 = New System.Windows.Forms.Label
        Me.dgvProductos = New System.Windows.Forms.DataGridView
        Me.clmIdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIdPreCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmNombreProducto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPrecioAnterior = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPrecioPrevisto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPrecioNuevo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.nudAumentoPrecio = New System.Windows.Forms.NumericUpDown
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtTodoa = New System.Windows.Forms.TextBox
        Me.dgvClientes = New System.Windows.Forms.DataGridView
        Me.clmIdCliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmSeleccion = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.clmNombreCliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvDestinos = New System.Windows.Forms.DataGridView
        Me.clmIdPuntoEntrega = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmNombreDestino = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPrecioActual = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnAplicaPrecios = New System.Windows.Forms.Button
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAumentoPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDestinos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.mtb.Location = New System.Drawing.Point(0, -56)
        Me.mtb.MostrarBorrar = False
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = False
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 519)
        Me.mtb.TabIndex = 46
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(52, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(954, 32)
        Me.Label17.TabIndex = 47
        Me.Label17.Text = "CATÁLOGO DE PRECIOS POR CLIENTE Y DESTINO"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.AllowUserToDeleteRows = False
        Me.dgvProductos.AllowUserToResizeRows = False
        Me.dgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmIdProducto, Me.clmIdPreCorte, Me.clmNombreProducto, Me.clmPrecioAnterior, Me.clmPrecioPrevisto, Me.clmPrecioNuevo, Me.clmCategoria})
        Me.dgvProductos.Location = New System.Drawing.Point(56, 73)
        Me.dgvProductos.MultiSelect = False
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.RowHeadersVisible = False
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.Size = New System.Drawing.Size(350, 458)
        Me.dgvProductos.TabIndex = 48
        '
        'clmIdProducto
        '
        Me.clmIdProducto.DataPropertyName = "IdProducto"
        Me.clmIdProducto.HeaderText = "IdProducto"
        Me.clmIdProducto.Name = "clmIdProducto"
        Me.clmIdProducto.ReadOnly = True
        Me.clmIdProducto.Visible = False
        '
        'clmIdPreCorte
        '
        Me.clmIdPreCorte.DataPropertyName = "IdPreCorte"
        Me.clmIdPreCorte.HeaderText = "IdPreCorte"
        Me.clmIdPreCorte.Name = "clmIdPreCorte"
        Me.clmIdPreCorte.ReadOnly = True
        Me.clmIdPreCorte.Visible = False
        '
        'clmNombreProducto
        '
        Me.clmNombreProducto.DataPropertyName = "Descripcion"
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmNombreProducto.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmNombreProducto.HeaderText = "Producto"
        Me.clmNombreProducto.Name = "clmNombreProducto"
        Me.clmNombreProducto.ReadOnly = True
        Me.clmNombreProducto.Width = 180
        '
        'clmPrecioAnterior
        '
        Me.clmPrecioAnterior.DataPropertyName = "PrecioMasFrecuente"
        Me.clmPrecioAnterior.HeaderText = "Precio Anterior"
        Me.clmPrecioAnterior.Name = "clmPrecioAnterior"
        Me.clmPrecioAnterior.ReadOnly = True
        Me.clmPrecioAnterior.Visible = False
        Me.clmPrecioAnterior.Width = 60
        '
        'clmPrecioPrevisto
        '
        Me.clmPrecioPrevisto.DataPropertyName = "PrecioPrevisto"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.clmPrecioPrevisto.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmPrecioPrevisto.HeaderText = "Precio Previsto"
        Me.clmPrecioPrevisto.Name = "clmPrecioPrevisto"
        Me.clmPrecioPrevisto.ReadOnly = True
        Me.clmPrecioPrevisto.Width = 60
        '
        'clmPrecioNuevo
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.clmPrecioNuevo.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmPrecioNuevo.HeaderText = "Precio Nuevo"
        Me.clmPrecioNuevo.Name = "clmPrecioNuevo"
        Me.clmPrecioNuevo.Width = 60
        '
        'clmCategoria
        '
        Me.clmCategoria.DataPropertyName = "Categoria"
        Me.clmCategoria.HeaderText = "C/P"
        Me.clmCategoria.Name = "clmCategoria"
        Me.clmCategoria.ReadOnly = True
        Me.clmCategoria.Width = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Aumentar Precio:"
        '
        'nudAumentoPrecio
        '
        Me.nudAumentoPrecio.DecimalPlaces = 2
        Me.nudAumentoPrecio.Location = New System.Drawing.Point(147, 41)
        Me.nudAumentoPrecio.Name = "nudAumentoPrecio"
        Me.nudAumentoPrecio.Size = New System.Drawing.Size(60, 20)
        Me.nudAumentoPrecio.TabIndex = 50
        Me.nudAumentoPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudAumentoPrecio.ThousandsSeparator = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(237, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Todo a:"
        '
        'txtTodoa
        '
        Me.txtTodoa.Location = New System.Drawing.Point(287, 40)
        Me.txtTodoa.MaxLength = 9
        Me.txtTodoa.Name = "txtTodoa"
        Me.txtTodoa.Size = New System.Drawing.Size(60, 20)
        Me.txtTodoa.TabIndex = 52
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.AllowUserToResizeRows = False
        Me.dgvClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvClientes.ColumnHeadersHeight = 31
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmIdCliente, Me.clmSeleccion, Me.clmNombreCliente})
        Me.dgvClientes.Location = New System.Drawing.Point(412, 73)
        Me.dgvClientes.MultiSelect = False
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.RowHeadersVisible = False
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClientes.Size = New System.Drawing.Size(283, 458)
        Me.dgvClientes.TabIndex = 53
        '
        'clmIdCliente
        '
        Me.clmIdCliente.DataPropertyName = "IdCliente"
        Me.clmIdCliente.HeaderText = "IdCliente"
        Me.clmIdCliente.Name = "clmIdCliente"
        Me.clmIdCliente.ReadOnly = True
        Me.clmIdCliente.Visible = False
        '
        'clmSeleccion
        '
        Me.clmSeleccion.HeaderText = ""
        Me.clmSeleccion.Name = "clmSeleccion"
        Me.clmSeleccion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmSeleccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clmSeleccion.Width = 20
        '
        'clmNombreCliente
        '
        Me.clmNombreCliente.DataPropertyName = "Nombre"
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmNombreCliente.DefaultCellStyle = DataGridViewCellStyle4
        Me.clmNombreCliente.HeaderText = "Clientes"
        Me.clmNombreCliente.Name = "clmNombreCliente"
        Me.clmNombreCliente.ReadOnly = True
        Me.clmNombreCliente.Width = 243
        '
        'dgvDestinos
        '
        Me.dgvDestinos.AllowUserToAddRows = False
        Me.dgvDestinos.AllowUserToDeleteRows = False
        Me.dgvDestinos.AllowUserToResizeRows = False
        Me.dgvDestinos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvDestinos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvDestinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDestinos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmIdPuntoEntrega, Me.clmNombreDestino, Me.clmPrecioActual, Me.clmPrecio})
        Me.dgvDestinos.Location = New System.Drawing.Point(701, 73)
        Me.dgvDestinos.MultiSelect = False
        Me.dgvDestinos.Name = "dgvDestinos"
        Me.dgvDestinos.RowHeadersVisible = False
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvDestinos.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvDestinos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDestinos.Size = New System.Drawing.Size(293, 458)
        Me.dgvDestinos.TabIndex = 54
        '
        'clmIdPuntoEntrega
        '
        Me.clmIdPuntoEntrega.DataPropertyName = "IdPuntoEntrega"
        Me.clmIdPuntoEntrega.HeaderText = "IdPuntoEntrega"
        Me.clmIdPuntoEntrega.Name = "clmIdPuntoEntrega"
        Me.clmIdPuntoEntrega.ReadOnly = True
        Me.clmIdPuntoEntrega.Visible = False
        '
        'clmNombreDestino
        '
        Me.clmNombreDestino.DataPropertyName = "Descripcion"
        Me.clmNombreDestino.HeaderText = "Destino"
        Me.clmNombreDestino.Name = "clmNombreDestino"
        Me.clmNombreDestino.ReadOnly = True
        Me.clmNombreDestino.Width = 153
        '
        'clmPrecioActual
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        Me.clmPrecioActual.DefaultCellStyle = DataGridViewCellStyle5
        Me.clmPrecioActual.HeaderText = "Precio Actual"
        Me.clmPrecioActual.Name = "clmPrecioActual"
        Me.clmPrecioActual.ReadOnly = True
        Me.clmPrecioActual.Width = 60
        '
        'clmPrecio
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.clmPrecio.DefaultCellStyle = DataGridViewCellStyle6
        Me.clmPrecio.HeaderText = "Precio"
        Me.clmPrecio.Name = "clmPrecio"
        Me.clmPrecio.ReadOnly = True
        Me.clmPrecio.Width = 60
        '
        'btnAplicaPrecios
        '
        Me.btnAplicaPrecios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAplicaPrecios.Location = New System.Drawing.Point(423, 37)
        Me.btnAplicaPrecios.Name = "btnAplicaPrecios"
        Me.btnAplicaPrecios.Size = New System.Drawing.Size(258, 23)
        Me.btnAplicaPrecios.TabIndex = 55
        Me.btnAplicaPrecios.Text = "APLICAR PRECIOS A TODOS LOS CLIENTES"
        Me.btnAplicaPrecios.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Precio"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "C2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn1.HeaderText = "Precio x Kg"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NomPreCorte"
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn2.HeaderText = "Corte"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 70
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Precio"
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn3.HeaderText = "Precio x Kg"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 70
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IdPrecorte"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Id Corte"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 30
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Categoria"
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn5.HeaderText = "Clientes"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 190
        '
        'DataGridViewTextBoxColumn6
        '
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn6.HeaderText = "Destino"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 135
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Categoria"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 70
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "IdCliente"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        Me.DataGridViewTextBoxColumn8.Width = 70
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Nombre"
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn9.HeaderText = "Clientes"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 190
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "IdPuntoEntrega"
        Me.DataGridViewTextBoxColumn10.HeaderText = "IdPuntoEntrega"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Destino"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 135
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 70
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 70
        '
        'FrmABCPrecioxClienteDestino
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 541)
        Me.Controls.Add(Me.btnAplicaPrecios)
        Me.Controls.Add(Me.dgvDestinos)
        Me.Controls.Add(Me.dgvClientes)
        Me.Controls.Add(Me.txtTodoa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nudAumentoPrecio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvProductos)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmABCPrecioxClienteDestino"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Precios por Cliente y Destino"
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAumentoPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDestinos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvProductos As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nudAumentoPrecio As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTodoa As System.Windows.Forms.TextBox
    Friend WithEvents dgvClientes As System.Windows.Forms.DataGridView
    Friend WithEvents dgvDestinos As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAplicaPrecios As System.Windows.Forms.Button
    Friend WithEvents clmIdCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSeleccion As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents clmNombreCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdPreCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmNombreProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPrecioAnterior As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPrecioPrevisto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPrecioNuevo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCategoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdPuntoEntrega As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmNombreDestino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPrecioActual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPrecio As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
