<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CatAlmConsKardexPto
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
        Me.mtb = New MiToolBar.miToolBar
        Me.Label17 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TxtReferencia = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGrid = New System.Windows.Forms.DataGridView
        Me.FechaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FolioColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MovtoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EntradaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SalidaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ExistenciaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostopColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.TxtExisActual = New System.Windows.Forms.TextBox
        Me.TxtSalidas = New System.Windows.Forms.TextBox
        Me.TxtEntrada = New System.Windows.Forms.TextBox
        Me.TxtExisInicial = New System.Windows.Forms.TextBox
        Me.TxtCosto = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker
        Me.TxtUnidad = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtLinea = New System.Windows.Forms.TextBox
        Me.CmbAño = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.CmbMes = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.CmbSublinea = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.CmbProducto = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmbPlaza = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.PlazaCol = New ClasesNegocio.PlazaCollectionClass
        Me.ProductoCol = New ClasesNegocio.ProductoCollectionClass
        Me.SubLineaCol = New ClasesNegocio.SubLineaCollectionClass
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
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
        Me.mtb.ImageButtonSize = MiToolBar.miToolBar.ImageButtonSizeEnum.de32
        Me.mtb.Location = New System.Drawing.Point(0, 0)
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
        Me.mtb.Size = New System.Drawing.Size(50, 471)
        Me.mtb.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(53, 0)
        Me.Label17.MaximumSize = New System.Drawing.Size(1600, 900)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(762, 29)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "CONSULTA DE KARDEX DE PRODUCTOS"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.TxtReferencia)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.DtpFecha)
        Me.Panel1.Controls.Add(Me.TxtUnidad)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TxtLinea)
        Me.Panel1.Controls.Add(Me.CmbAño)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.CmbMes)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.CmbSublinea)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.CmbProducto)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.CmbPlaza)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(56, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(750, 429)
        Me.Panel1.TabIndex = 2
        '
        'TxtReferencia
        '
        Me.TxtReferencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtReferencia.Location = New System.Drawing.Point(135, 392)
        Me.TxtReferencia.MaxLength = 10
        Me.TxtReferencia.Name = "TxtReferencia"
        Me.TxtReferencia.Size = New System.Drawing.Size(155, 20)
        Me.TxtReferencia.TabIndex = 8
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(13, 395)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(116, 13)
        Me.Label14.TabIndex = 105
        Me.Label14.Text = "Referencia de Compra:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DataGrid)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 197)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(724, 181)
        Me.GroupBox1.TabIndex = 104
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de Movimientos"
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.AllowUserToResizeRows = False
        Me.DataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaColumn, Me.FolioColumn, Me.MovtoColumn, Me.EntradaColumn, Me.SalidaColumn, Me.ExistenciaColumn, Me.CostoColumn, Me.CostopColumn})
        Me.DataGrid.Location = New System.Drawing.Point(8, 19)
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(705, 150)
        Me.DataGrid.TabIndex = 0
        '
        'FechaColumn
        '
        Me.FechaColumn.HeaderText = "Fecha Movimiento"
        Me.FechaColumn.Name = "FechaColumn"
        Me.FechaColumn.ReadOnly = True
        Me.FechaColumn.Width = 130
        '
        'FolioColumn
        '
        Me.FolioColumn.HeaderText = "Folio Movimiento"
        Me.FolioColumn.Name = "FolioColumn"
        Me.FolioColumn.ReadOnly = True
        Me.FolioColumn.Width = 130
        '
        'MovtoColumn
        '
        Me.MovtoColumn.HeaderText = "Movimiento"
        Me.MovtoColumn.Name = "MovtoColumn"
        Me.MovtoColumn.ReadOnly = True
        Me.MovtoColumn.Width = 200
        '
        'EntradaColumn
        '
        Me.EntradaColumn.HeaderText = "Entrada"
        Me.EntradaColumn.Name = "EntradaColumn"
        Me.EntradaColumn.ReadOnly = True
        '
        'SalidaColumn
        '
        Me.SalidaColumn.HeaderText = "Salida"
        Me.SalidaColumn.Name = "SalidaColumn"
        Me.SalidaColumn.ReadOnly = True
        '
        'ExistenciaColumn
        '
        Me.ExistenciaColumn.HeaderText = "Existencia"
        Me.ExistenciaColumn.Name = "ExistenciaColumn"
        Me.ExistenciaColumn.ReadOnly = True
        '
        'CostoColumn
        '
        Me.CostoColumn.HeaderText = "Costo"
        Me.CostoColumn.Name = "CostoColumn"
        Me.CostoColumn.ReadOnly = True
        '
        'CostopColumn
        '
        Me.CostopColumn.HeaderText = "Costo Promedio"
        Me.CostopColumn.Name = "CostopColumn"
        Me.CostopColumn.ReadOnly = True
        Me.CostopColumn.Width = 120
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.TxtExisActual)
        Me.Panel2.Controls.Add(Me.TxtSalidas)
        Me.Panel2.Controls.Add(Me.TxtEntrada)
        Me.Panel2.Controls.Add(Me.TxtExisInicial)
        Me.Panel2.Controls.Add(Me.TxtCosto)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Location = New System.Drawing.Point(484, 19)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(256, 161)
        Me.Panel2.TabIndex = 103
        '
        'TxtExisActual
        '
        Me.TxtExisActual.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtExisActual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtExisActual.Location = New System.Drawing.Point(108, 121)
        Me.TxtExisActual.MaxLength = 10
        Me.TxtExisActual.Name = "TxtExisActual"
        Me.TxtExisActual.Size = New System.Drawing.Size(136, 20)
        Me.TxtExisActual.TabIndex = 4
        Me.TxtExisActual.Text = "0"
        '
        'TxtSalidas
        '
        Me.TxtSalidas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSalidas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSalidas.Location = New System.Drawing.Point(108, 91)
        Me.TxtSalidas.MaxLength = 10
        Me.TxtSalidas.Name = "TxtSalidas"
        Me.TxtSalidas.Size = New System.Drawing.Size(136, 20)
        Me.TxtSalidas.TabIndex = 3
        Me.TxtSalidas.Text = "0"
        '
        'TxtEntrada
        '
        Me.TxtEntrada.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtEntrada.Location = New System.Drawing.Point(108, 65)
        Me.TxtEntrada.MaxLength = 10
        Me.TxtEntrada.Name = "TxtEntrada"
        Me.TxtEntrada.Size = New System.Drawing.Size(136, 20)
        Me.TxtEntrada.TabIndex = 2
        Me.TxtEntrada.Text = "0"
        '
        'TxtExisInicial
        '
        Me.TxtExisInicial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtExisInicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtExisInicial.Location = New System.Drawing.Point(108, 37)
        Me.TxtExisInicial.MaxLength = 10
        Me.TxtExisInicial.Name = "TxtExisInicial"
        Me.TxtExisInicial.Size = New System.Drawing.Size(136, 20)
        Me.TxtExisInicial.TabIndex = 1
        Me.TxtExisInicial.Text = "0"
        '
        'TxtCosto
        '
        Me.TxtCosto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCosto.Location = New System.Drawing.Point(108, 10)
        Me.TxtCosto.MaxLength = 10
        Me.TxtCosto.Name = "TxtCosto"
        Me.TxtCosto.Size = New System.Drawing.Size(136, 20)
        Me.TxtCosto.TabIndex = 0
        Me.TxtCosto.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 13)
        Me.Label9.TabIndex = 108
        Me.Label9.Text = "Existencia Actual:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 13)
        Me.Label12.TabIndex = 105
        Me.Label12.Text = "Existencia Inicial:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 13)
        Me.Label10.TabIndex = 107
        Me.Label10.Text = "Total Salidas:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 13)
        Me.Label13.TabIndex = 104
        Me.Label13.Text = "Costo Inicial:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 13)
        Me.Label11.TabIndex = 106
        Me.Label11.Text = "Total Entradas:"
        '
        'DtpFecha
        '
        Me.DtpFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(318, 131)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(90, 20)
        Me.DtpFecha.TabIndex = 6
        '
        'TxtUnidad
        '
        Me.TxtUnidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtUnidad.Location = New System.Drawing.Point(334, 81)
        Me.TxtUnidad.MaxLength = 4
        Me.TxtUnidad.Name = "TxtUnidad"
        Me.TxtUnidad.Size = New System.Drawing.Size(74, 20)
        Me.TxtUnidad.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(240, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 100
        Me.Label7.Text = "Ultima Fecha:"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(284, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = "Unidad:"
        '
        'TxtLinea
        '
        Me.TxtLinea.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtLinea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLinea.Location = New System.Drawing.Point(79, 79)
        Me.TxtLinea.MaxLength = 10
        Me.TxtLinea.Name = "TxtLinea"
        Me.TxtLinea.Size = New System.Drawing.Size(155, 20)
        Me.TxtLinea.TabIndex = 2
        '
        'CmbAño
        '
        Me.CmbAño.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbAño.FormattingEnabled = True
        Me.CmbAño.Location = New System.Drawing.Point(79, 159)
        Me.CmbAño.Name = "CmbAño"
        Me.CmbAño.Size = New System.Drawing.Size(113, 21)
        Me.CmbAño.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "Año Inicial"
        '
        'CmbMes
        '
        Me.CmbMes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbMes.FormattingEnabled = True
        Me.CmbMes.Location = New System.Drawing.Point(79, 132)
        Me.CmbMes.Name = "CmbMes"
        Me.CmbMes.Size = New System.Drawing.Size(133, 21)
        Me.CmbMes.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "Mes Inicial"
        '
        'CmbSublinea
        '
        Me.CmbSublinea.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbSublinea.FormattingEnabled = True
        Me.CmbSublinea.Location = New System.Drawing.Point(79, 105)
        Me.CmbSublinea.Name = "CmbSublinea"
        Me.CmbSublinea.Size = New System.Drawing.Size(155, 21)
        Me.CmbSublinea.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "Sub Linea:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "Linea:"
        '
        'CmbProducto
        '
        Me.CmbProducto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbProducto.FormattingEnabled = True
        Me.CmbProducto.Location = New System.Drawing.Point(79, 51)
        Me.CmbProducto.Name = "CmbProducto"
        Me.CmbProducto.Size = New System.Drawing.Size(329, 21)
        Me.CmbProducto.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Producto:"
        '
        'CmbPlaza
        '
        Me.CmbPlaza.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbPlaza.FormattingEnabled = True
        Me.CmbPlaza.Location = New System.Drawing.Point(79, 24)
        Me.CmbPlaza.Name = "CmbPlaza"
        Me.CmbPlaza.Size = New System.Drawing.Size(329, 21)
        Me.CmbPlaza.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Plaza:"
        '
        'PlazaCol
        '
        Me.PlazaCol.AllowEdit = True
        Me.PlazaCol.AllowNew = True
        Me.PlazaCol.AllowRemove = True
        Me.PlazaCol.Name = Nothing
        Me.PlazaCol.RaiseListChangedEvents = True
        '
        'ProductoCol
        '
        Me.ProductoCol.AllowEdit = True
        Me.ProductoCol.AllowNew = True
        Me.ProductoCol.AllowRemove = True
        Me.ProductoCol.Name = "0"
        Me.ProductoCol.RaiseListChangedEvents = True
        '
        'SubLineaCol
        '
        Me.SubLineaCol.AllowEdit = True
        Me.SubLineaCol.AllowNew = True
        Me.SubLineaCol.AllowRemove = True
        Me.SubLineaCol.Name = Nothing
        Me.SubLineaCol.RaiseListChangedEvents = True
        '
        'CatAlmConsKardexPto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 471)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.MinimumSize = New System.Drawing.Size(819, 505)
        Me.Name = "CatAlmConsKardexPto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Kardex de Productos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MiToolBar.miToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CmbProducto As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbPlaza As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtLinea As System.Windows.Forms.TextBox
    Friend WithEvents CmbAño As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CmbMes As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CmbSublinea As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TxtExisActual As System.Windows.Forms.TextBox
    Friend WithEvents TxtSalidas As System.Windows.Forms.TextBox
    Friend WithEvents TxtEntrada As System.Windows.Forms.TextBox
    Friend WithEvents TxtExisInicial As System.Windows.Forms.TextBox
    Friend WithEvents TxtCosto As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtUnidad As System.Windows.Forms.TextBox
    Friend WithEvents TxtReferencia As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents FechaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FolioColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovtoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EntradaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SalidaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExistenciaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostopColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlazaCol As ClasesNegocio.PlazaCollectionClass
    Friend WithEvents ProductoCol As ClasesNegocio.ProductoCollectionClass
    Friend WithEvents SubLineaCol As ClasesNegocio.SubLineaCollectionClass
End Class
