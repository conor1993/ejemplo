<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDevolucion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDevolucion))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtFolio = New Integralab.Controles.TextBoxMejorado
        Me.btnVaciarPistola = New System.Windows.Forms.Button
        Me.imgCajas = New System.Windows.Forms.ImageList(Me.components)
        Me.btnBusquedaEtiquetas = New System.Windows.Forms.Button
        Me.chkUtilParaVenta = New System.Windows.Forms.CheckBox
        Me.dtFechaEmbarque = New System.Windows.Forms.DateTimePicker
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtCliente = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtFolioEmbarque = New Integralab.Controles.TextBoxMejorado
        Me.Label10 = New System.Windows.Forms.Label
        Me.dgDevoluciones = New System.Windows.Forms.DataGridView
        Me.clmFolioDevilucion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFolioEmbarque = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIdCliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIdPreCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPrecorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIdCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEsCaja = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmUtilParaVenta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPiezas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmKilos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gbListaDevolucionesRegistradas = New System.Windows.Forms.GroupBox
        Me.gbDevolucionesmasde1 = New System.Windows.Forms.GroupBox
        Me.txtFolioEmbarqueConsulta = New Integralab.Controles.TextBoxMejorado
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtCodigoCliente = New Integralab.Controles.TextBoxMejorado
        Me.gbCaja = New System.Windows.Forms.GroupBox
        Me.btnBuscarCortes = New System.Windows.Forms.Button
        Me.txtCodigoCorte = New Integralab.Controles.TextBoxMejorado
        Me.txtCodigoPrecorte = New Integralab.Controles.TextBoxMejorado
        Me.dtFechaCaducidad = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.dtFechaEmpaque = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtCorte = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtPrecorte = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtPiezas = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtKilos = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtLoteCorte = New System.Windows.Forms.TextBox
        Me.txtFolioEtiqueta = New Integralab.Controles.TextBoxMejorado
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtCodigoMotivoDevolucion = New Integralab.Controles.TextBoxMejorado
        Me.cmbMotivoDevolucion = New Integralab.Controles.ComboBoxMejorado
        Me.MotivoDevolucionC = New ClasesNegocio.MotivoDevolucionColeccionClass
        CType(Me.dgDevoluciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbListaDevolucionesRegistradas.SuspendLayout()
        Me.gbDevolucionesmasde1.SuspendLayout()
        Me.gbCaja.SuspendLayout()
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
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 589)
        Me.mtb.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(904, 32)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "DEVOLUCIONES DE VENTAS"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Folio:"
        '
        'txtFolio
        '
        Me.txtFolio.ComboBoxEnlazado = Nothing
        Me.txtFolio.Decimales = 0
        Me.txtFolio.Enabled = False
        Me.txtFolio.Location = New System.Drawing.Point(102, 35)
        Me.txtFolio.MensajeCombo = "Seleccionar un item..."
        Me.txtFolio.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.SiguienteControl = Nothing
        Me.txtFolio.Size = New System.Drawing.Size(90, 20)
        Me.txtFolio.TabIndex = 3
        Me.txtFolio.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'btnVaciarPistola
        '
        Me.btnVaciarPistola.ImageIndex = 3
        Me.btnVaciarPistola.ImageList = Me.imgCajas
        Me.btnVaciarPistola.Location = New System.Drawing.Point(6, 66)
        Me.btnVaciarPistola.Name = "btnVaciarPistola"
        Me.btnVaciarPistola.Size = New System.Drawing.Size(36, 33)
        Me.btnVaciarPistola.TabIndex = 2
        Me.btnVaciarPistola.UseVisualStyleBackColor = True
        '
        'imgCajas
        '
        Me.imgCajas.ImageStream = CType(resources.GetObject("imgCajas.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgCajas.TransparentColor = System.Drawing.Color.Transparent
        Me.imgCajas.Images.SetKeyName(0, "images.jpg")
        Me.imgCajas.Images.SetKeyName(1, "caja.jpg")
        Me.imgCajas.Images.SetKeyName(2, "MC9000Ga.jpg")
        Me.imgCajas.Images.SetKeyName(3, "pistola.jpg")
        '
        'btnBusquedaEtiquetas
        '
        Me.btnBusquedaEtiquetas.ImageIndex = 1
        Me.btnBusquedaEtiquetas.ImageList = Me.imgCajas
        Me.btnBusquedaEtiquetas.Location = New System.Drawing.Point(48, 66)
        Me.btnBusquedaEtiquetas.Name = "btnBusquedaEtiquetas"
        Me.btnBusquedaEtiquetas.Size = New System.Drawing.Size(36, 33)
        Me.btnBusquedaEtiquetas.TabIndex = 3
        Me.btnBusquedaEtiquetas.UseVisualStyleBackColor = True
        '
        'chkUtilParaVenta
        '
        Me.chkUtilParaVenta.AutoSize = True
        Me.chkUtilParaVenta.Checked = True
        Me.chkUtilParaVenta.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkUtilParaVenta.Enabled = False
        Me.chkUtilParaVenta.Location = New System.Drawing.Point(198, 37)
        Me.chkUtilParaVenta.Name = "chkUtilParaVenta"
        Me.chkUtilParaVenta.Size = New System.Drawing.Size(97, 17)
        Me.chkUtilParaVenta.TabIndex = 4
        Me.chkUtilParaVenta.Text = "Util Para Venta"
        Me.chkUtilParaVenta.UseVisualStyleBackColor = True
        '
        'dtFechaEmbarque
        '
        Me.dtFechaEmbarque.Enabled = False
        Me.dtFechaEmbarque.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaEmbarque.Location = New System.Drawing.Point(597, 35)
        Me.dtFechaEmbarque.Name = "dtFechaEmbarque"
        Me.dtFechaEmbarque.Size = New System.Drawing.Size(90, 20)
        Me.dtFechaEmbarque.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(507, 39)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Fecha Embarque:"
        '
        'txtCliente
        '
        Me.txtCliente.Enabled = False
        Me.txtCliente.Location = New System.Drawing.Point(160, 61)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(438, 20)
        Me.txtCliente.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(56, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Cliente:"
        '
        'txtFolioEmbarque
        '
        Me.txtFolioEmbarque.ComboBoxEnlazado = Nothing
        Me.txtFolioEmbarque.Decimales = 0
        Me.txtFolioEmbarque.Enabled = False
        Me.txtFolioEmbarque.ForeColor = System.Drawing.Color.Gray
        Me.txtFolioEmbarque.Location = New System.Drawing.Point(392, 35)
        Me.txtFolioEmbarque.MensajeCombo = "Seleccionar un item..."
        Me.txtFolioEmbarque.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtFolioEmbarque.Name = "txtFolioEmbarque"
        Me.txtFolioEmbarque.SiguienteControl = Nothing
        Me.txtFolioEmbarque.Size = New System.Drawing.Size(109, 20)
        Me.txtFolioEmbarque.TabIndex = 6
        Me.txtFolioEmbarque.Text = "F3 para buscar"
        Me.txtFolioEmbarque.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(301, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Folio Embarque:"
        '
        'dgDevoluciones
        '
        Me.dgDevoluciones.AllowUserToAddRows = False
        Me.dgDevoluciones.AllowUserToDeleteRows = False
        Me.dgDevoluciones.AllowUserToResizeRows = False
        Me.dgDevoluciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDevoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDevoluciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmFolioDevilucion, Me.clmFolioEmbarque, Me.clmIdCliente, Me.clmCliente, Me.clmIdPreCorte, Me.clmPrecorte, Me.clmIdCorte, Me.clmCorte, Me.clmEsCaja, Me.clmUtilParaVenta, Me.clmPiezas, Me.clmKilos, Me.clmEstatus, Me.clmFecha})
        Me.dgDevoluciones.Location = New System.Drawing.Point(6, 19)
        Me.dgDevoluciones.MultiSelect = False
        Me.dgDevoluciones.Name = "dgDevoluciones"
        Me.dgDevoluciones.ReadOnly = True
        Me.dgDevoluciones.RowHeadersVisible = False
        Me.dgDevoluciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDevoluciones.Size = New System.Drawing.Size(879, 330)
        Me.dgDevoluciones.TabIndex = 0
        '
        'clmFolioDevilucion
        '
        Me.clmFolioDevilucion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmFolioDevilucion.DataPropertyName = "Folio"
        Me.clmFolioDevilucion.HeaderText = "Folio"
        Me.clmFolioDevilucion.Name = "clmFolioDevilucion"
        Me.clmFolioDevilucion.ReadOnly = True
        Me.clmFolioDevilucion.Width = 54
        '
        'clmFolioEmbarque
        '
        Me.clmFolioEmbarque.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmFolioEmbarque.DataPropertyName = "Embarque"
        Me.clmFolioEmbarque.HeaderText = "Embarque"
        Me.clmFolioEmbarque.Name = "clmFolioEmbarque"
        Me.clmFolioEmbarque.ReadOnly = True
        Me.clmFolioEmbarque.Width = 80
        '
        'clmIdCliente
        '
        Me.clmIdCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmIdCliente.DataPropertyName = "IdCliente"
        Me.clmIdCliente.HeaderText = "Codigo Cliente"
        Me.clmIdCliente.Name = "clmIdCliente"
        Me.clmIdCliente.ReadOnly = True
        Me.clmIdCliente.Width = 92
        '
        'clmCliente
        '
        Me.clmCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmCliente.DataPropertyName = "Nombre"
        Me.clmCliente.HeaderText = "Cliente"
        Me.clmCliente.Name = "clmCliente"
        Me.clmCliente.ReadOnly = True
        Me.clmCliente.Width = 64
        '
        'clmIdPreCorte
        '
        Me.clmIdPreCorte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmIdPreCorte.DataPropertyName = "IdPrecorte"
        Me.clmIdPreCorte.HeaderText = "Codigo Precorte"
        Me.clmIdPreCorte.Name = "clmIdPreCorte"
        Me.clmIdPreCorte.ReadOnly = True
        Me.clmIdPreCorte.Width = 99
        '
        'clmPrecorte
        '
        Me.clmPrecorte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmPrecorte.DataPropertyName = "Precorte"
        Me.clmPrecorte.HeaderText = "Precorte"
        Me.clmPrecorte.Name = "clmPrecorte"
        Me.clmPrecorte.ReadOnly = True
        Me.clmPrecorte.Width = 72
        '
        'clmIdCorte
        '
        Me.clmIdCorte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmIdCorte.DataPropertyName = "IdCorte"
        Me.clmIdCorte.HeaderText = "Codigo Corte"
        Me.clmIdCorte.Name = "clmIdCorte"
        Me.clmIdCorte.ReadOnly = True
        Me.clmIdCorte.Width = 86
        '
        'clmCorte
        '
        Me.clmCorte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmCorte.DataPropertyName = "Corte"
        Me.clmCorte.HeaderText = "Corte"
        Me.clmCorte.Name = "clmCorte"
        Me.clmCorte.ReadOnly = True
        Me.clmCorte.Width = 57
        '
        'clmEsCaja
        '
        Me.clmEsCaja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmEsCaja.DataPropertyName = "EnCaja"
        Me.clmEsCaja.HeaderText = "Es Caja"
        Me.clmEsCaja.Name = "clmEsCaja"
        Me.clmEsCaja.ReadOnly = True
        Me.clmEsCaja.Visible = False
        '
        'clmUtilParaVenta
        '
        Me.clmUtilParaVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmUtilParaVenta.DataPropertyName = "UtilparaVenta"
        Me.clmUtilParaVenta.HeaderText = "Util Para Venta"
        Me.clmUtilParaVenta.Name = "clmUtilParaVenta"
        Me.clmUtilParaVenta.ReadOnly = True
        Me.clmUtilParaVenta.Visible = False
        '
        'clmPiezas
        '
        Me.clmPiezas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmPiezas.DataPropertyName = "Piezas"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.clmPiezas.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmPiezas.HeaderText = "Piezas"
        Me.clmPiezas.Name = "clmPiezas"
        Me.clmPiezas.ReadOnly = True
        Me.clmPiezas.Width = 63
        '
        'clmKilos
        '
        Me.clmKilos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmKilos.DataPropertyName = "Kilos"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N3"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.clmKilos.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmKilos.HeaderText = "Kilos"
        Me.clmKilos.Name = "clmKilos"
        Me.clmKilos.ReadOnly = True
        Me.clmKilos.Width = 54
        '
        'clmEstatus
        '
        Me.clmEstatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmEstatus.DataPropertyName = "EstatusCad"
        Me.clmEstatus.HeaderText = "Estatus"
        Me.clmEstatus.Name = "clmEstatus"
        Me.clmEstatus.ReadOnly = True
        Me.clmEstatus.Width = 67
        '
        'clmFecha
        '
        Me.clmFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmFecha.DataPropertyName = "FechaCaptura"
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.clmFecha.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmFecha.HeaderText = "Fecha"
        Me.clmFecha.Name = "clmFecha"
        Me.clmFecha.ReadOnly = True
        Me.clmFecha.Width = 62
        '
        'gbListaDevolucionesRegistradas
        '
        Me.gbListaDevolucionesRegistradas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbListaDevolucionesRegistradas.Controls.Add(Me.dgDevoluciones)
        Me.gbListaDevolucionesRegistradas.Location = New System.Drawing.Point(56, 224)
        Me.gbListaDevolucionesRegistradas.Name = "gbListaDevolucionesRegistradas"
        Me.gbListaDevolucionesRegistradas.Size = New System.Drawing.Size(891, 355)
        Me.gbListaDevolucionesRegistradas.TabIndex = 21
        Me.gbListaDevolucionesRegistradas.TabStop = False
        Me.gbListaDevolucionesRegistradas.Text = "Lista de Devoluciones Registradas"
        '
        'gbDevolucionesmasde1
        '
        Me.gbDevolucionesmasde1.Controls.Add(Me.txtFolioEmbarqueConsulta)
        Me.gbDevolucionesmasde1.Controls.Add(Me.Label13)
        Me.gbDevolucionesmasde1.Controls.Add(Me.btnVaciarPistola)
        Me.gbDevolucionesmasde1.Controls.Add(Me.btnBusquedaEtiquetas)
        Me.gbDevolucionesmasde1.Enabled = False
        Me.gbDevolucionesmasde1.Location = New System.Drawing.Point(731, 113)
        Me.gbDevolucionesmasde1.Name = "gbDevolucionesmasde1"
        Me.gbDevolucionesmasde1.Size = New System.Drawing.Size(216, 105)
        Me.gbDevolucionesmasde1.TabIndex = 20
        Me.gbDevolucionesmasde1.TabStop = False
        Me.gbDevolucionesmasde1.Text = "Devolver mas de 1 Caja"
        '
        'txtFolioEmbarqueConsulta
        '
        Me.txtFolioEmbarqueConsulta.ComboBoxEnlazado = Nothing
        Me.txtFolioEmbarqueConsulta.Decimales = 0
        Me.txtFolioEmbarqueConsulta.Location = New System.Drawing.Point(101, 19)
        Me.txtFolioEmbarqueConsulta.MensajeCombo = "Seleccionar un item..."
        Me.txtFolioEmbarqueConsulta.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtFolioEmbarqueConsulta.Name = "txtFolioEmbarqueConsulta"
        Me.txtFolioEmbarqueConsulta.SiguienteControl = Nothing
        Me.txtFolioEmbarqueConsulta.Size = New System.Drawing.Size(109, 20)
        Me.txtFolioEmbarqueConsulta.TabIndex = 1
        Me.txtFolioEmbarqueConsulta.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(10, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Folio Embarque:"
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.ComboBoxEnlazado = Nothing
        Me.txtCodigoCliente.Decimales = 0
        Me.txtCodigoCliente.Enabled = False
        Me.txtCodigoCliente.Location = New System.Drawing.Point(104, 61)
        Me.txtCodigoCliente.MensajeCombo = "Seleccionar un item..."
        Me.txtCodigoCliente.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.SiguienteControl = Nothing
        Me.txtCodigoCliente.Size = New System.Drawing.Size(50, 20)
        Me.txtCodigoCliente.TabIndex = 10
        Me.txtCodigoCliente.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'gbCaja
        '
        Me.gbCaja.Controls.Add(Me.btnBuscarCortes)
        Me.gbCaja.Controls.Add(Me.txtCodigoCorte)
        Me.gbCaja.Controls.Add(Me.txtCodigoPrecorte)
        Me.gbCaja.Controls.Add(Me.dtFechaCaducidad)
        Me.gbCaja.Controls.Add(Me.Label8)
        Me.gbCaja.Controls.Add(Me.dtFechaEmpaque)
        Me.gbCaja.Controls.Add(Me.Label7)
        Me.gbCaja.Controls.Add(Me.txtCorte)
        Me.gbCaja.Controls.Add(Me.Label6)
        Me.gbCaja.Controls.Add(Me.txtPrecorte)
        Me.gbCaja.Controls.Add(Me.Label5)
        Me.gbCaja.Controls.Add(Me.txtPiezas)
        Me.gbCaja.Controls.Add(Me.Label4)
        Me.gbCaja.Controls.Add(Me.Label3)
        Me.gbCaja.Controls.Add(Me.txtKilos)
        Me.gbCaja.Enabled = False
        Me.gbCaja.Location = New System.Drawing.Point(59, 113)
        Me.gbCaja.Name = "gbCaja"
        Me.gbCaja.Size = New System.Drawing.Size(666, 105)
        Me.gbCaja.TabIndex = 19
        Me.gbCaja.TabStop = False
        Me.gbCaja.Text = "Datos de la Caja o Pieza"
        '
        'btnBuscarCortes
        '
        Me.btnBuscarCortes.BackColor = System.Drawing.SystemColors.Control
        Me.btnBuscarCortes.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnBuscarCortes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBuscarCortes.Image = CType(resources.GetObject("btnBuscarCortes.Image"), System.Drawing.Image)
        Me.btnBuscarCortes.Location = New System.Drawing.Point(443, 48)
        Me.btnBuscarCortes.Name = "btnBuscarCortes"
        Me.btnBuscarCortes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnBuscarCortes.Size = New System.Drawing.Size(20, 20)
        Me.btnBuscarCortes.TabIndex = 6
        Me.btnBuscarCortes.TabStop = False
        Me.btnBuscarCortes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscarCortes.UseVisualStyleBackColor = False
        '
        'txtCodigoCorte
        '
        Me.txtCodigoCorte.ComboBoxEnlazado = Nothing
        Me.txtCodigoCorte.Decimales = 0
        Me.txtCodigoCorte.Enabled = False
        Me.txtCodigoCorte.Location = New System.Drawing.Point(65, 48)
        Me.txtCodigoCorte.MensajeCombo = "Seleccionar un item..."
        Me.txtCodigoCorte.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtCodigoCorte.Name = "txtCodigoCorte"
        Me.txtCodigoCorte.SiguienteControl = Nothing
        Me.txtCodigoCorte.Size = New System.Drawing.Size(37, 20)
        Me.txtCodigoCorte.TabIndex = 4
        Me.txtCodigoCorte.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'txtCodigoPrecorte
        '
        Me.txtCodigoPrecorte.ComboBoxEnlazado = Nothing
        Me.txtCodigoPrecorte.Decimales = 0
        Me.txtCodigoPrecorte.Enabled = False
        Me.txtCodigoPrecorte.Location = New System.Drawing.Point(65, 22)
        Me.txtCodigoPrecorte.MensajeCombo = "Seleccionar un item..."
        Me.txtCodigoPrecorte.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtCodigoPrecorte.Name = "txtCodigoPrecorte"
        Me.txtCodigoPrecorte.SiguienteControl = Nothing
        Me.txtCodigoPrecorte.Size = New System.Drawing.Size(37, 20)
        Me.txtCodigoPrecorte.TabIndex = 1
        Me.txtCodigoPrecorte.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'dtFechaCaducidad
        '
        Me.dtFechaCaducidad.Enabled = False
        Me.dtFechaCaducidad.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaCaducidad.Location = New System.Drawing.Point(298, 74)
        Me.dtFechaCaducidad.Name = "dtFechaCaducidad"
        Me.dtFechaCaducidad.Size = New System.Drawing.Size(89, 20)
        Me.dtFechaCaducidad.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(198, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Fecha Caducidad:"
        '
        'dtFechaEmpaque
        '
        Me.dtFechaEmpaque.Enabled = False
        Me.dtFechaEmpaque.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaEmpaque.Location = New System.Drawing.Point(103, 74)
        Me.dtFechaEmpaque.Name = "dtFechaEmpaque"
        Me.dtFechaEmpaque.Size = New System.Drawing.Size(89, 20)
        Me.dtFechaEmpaque.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Fecha Empaque:"
        '
        'txtCorte
        '
        Me.txtCorte.Enabled = False
        Me.txtCorte.Location = New System.Drawing.Point(108, 48)
        Me.txtCorte.Name = "txtCorte"
        Me.txtCorte.Size = New System.Drawing.Size(334, 20)
        Me.txtCorte.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Corte:"
        '
        'txtPrecorte
        '
        Me.txtPrecorte.Enabled = False
        Me.txtPrecorte.Location = New System.Drawing.Point(108, 22)
        Me.txtPrecorte.Name = "txtPrecorte"
        Me.txtPrecorte.Size = New System.Drawing.Size(334, 20)
        Me.txtPrecorte.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Precorte:"
        '
        'txtPiezas
        '
        Me.txtPiezas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPiezas.Location = New System.Drawing.Point(491, 19)
        Me.txtPiezas.Name = "txtPiezas"
        Me.txtPiezas.Size = New System.Drawing.Size(52, 26)
        Me.txtPiezas.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(549, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Kilos:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(444, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Piezas:"
        '
        'txtKilos
        '
        Me.txtKilos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKilos.Location = New System.Drawing.Point(587, 18)
        Me.txtKilos.Name = "txtKilos"
        Me.txtKilos.Size = New System.Drawing.Size(73, 26)
        Me.txtKilos.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Folio Etiqueta:"
        '
        'txtLoteCorte
        '
        Me.txtLoteCorte.Enabled = False
        Me.txtLoteCorte.Location = New System.Drawing.Point(322, 87)
        Me.txtLoteCorte.Name = "txtLoteCorte"
        Me.txtLoteCorte.Size = New System.Drawing.Size(121, 20)
        Me.txtLoteCorte.TabIndex = 15
        '
        'txtFolioEtiqueta
        '
        Me.txtFolioEtiqueta.ComboBoxEnlazado = Nothing
        Me.txtFolioEtiqueta.Decimales = 0
        Me.txtFolioEtiqueta.Enabled = False
        Me.txtFolioEtiqueta.ForeColor = System.Drawing.Color.Gray
        Me.txtFolioEtiqueta.Location = New System.Drawing.Point(136, 87)
        Me.txtFolioEtiqueta.MensajeCombo = "Seleccionar un item..."
        Me.txtFolioEtiqueta.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtFolioEtiqueta.Name = "txtFolioEtiqueta"
        Me.txtFolioEtiqueta.SiguienteControl = Nothing
        Me.txtFolioEtiqueta.Size = New System.Drawing.Size(115, 20)
        Me.txtFolioEtiqueta.TabIndex = 13
        Me.txtFolioEtiqueta.Text = "F3 para buscar"
        Me.txtFolioEtiqueta.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(257, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Lote Corte:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(449, 91)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(114, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Motivo de Devolución:"
        '
        'txtCodigoMotivoDevolucion
        '
        Me.txtCodigoMotivoDevolucion.ComboBoxEnlazado = Me.cmbMotivoDevolucion
        Me.txtCodigoMotivoDevolucion.Decimales = 0
        Me.txtCodigoMotivoDevolucion.Enabled = False
        Me.txtCodigoMotivoDevolucion.Location = New System.Drawing.Point(570, 87)
        Me.txtCodigoMotivoDevolucion.MaxLength = 3000
        Me.txtCodigoMotivoDevolucion.MensajeCombo = "Seleccionar un motivo de devolución..."
        Me.txtCodigoMotivoDevolucion.MensajeNoExiste = "No existe un motivo de devolución con este código o se encuentra inactivo"
        Me.txtCodigoMotivoDevolucion.Name = "txtCodigoMotivoDevolucion"
        Me.txtCodigoMotivoDevolucion.SiguienteControl = Nothing
        Me.txtCodigoMotivoDevolucion.Size = New System.Drawing.Size(42, 20)
        Me.txtCodigoMotivoDevolucion.TabIndex = 17
        Me.txtCodigoMotivoDevolucion.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        '
        'cmbMotivoDevolucion
        '
        Me.cmbMotivoDevolucion.DataSource = Me.MotivoDevolucionC
        Me.cmbMotivoDevolucion.DisplayMember = "Descripcion"
        Me.cmbMotivoDevolucion.Enabled = False
        Me.cmbMotivoDevolucion.FormattingEnabled = True
        Me.cmbMotivoDevolucion.Location = New System.Drawing.Point(618, 87)
        Me.cmbMotivoDevolucion.Name = "cmbMotivoDevolucion"
        Me.cmbMotivoDevolucion.NombreMetodo = Nothing
        Me.cmbMotivoDevolucion.Parametros = Nothing
        Me.cmbMotivoDevolucion.SiguienteControl = Nothing
        Me.cmbMotivoDevolucion.Size = New System.Drawing.Size(329, 21)
        Me.cmbMotivoDevolucion.TabIndex = 18
        Me.cmbMotivoDevolucion.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbMotivoDevolucion.TextBoxEnlazado = Me.txtCodigoMotivoDevolucion
        Me.cmbMotivoDevolucion.ValueMember = "IdMotivoDevolucion"
        '
        'MotivoDevolucionC
        '
        Me.MotivoDevolucionC.AllowEdit = True
        Me.MotivoDevolucionC.AllowNew = True
        Me.MotivoDevolucionC.AllowRemove = True
        Me.MotivoDevolucionC.MaximoElementosSeleccionados = 1
        Me.MotivoDevolucionC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.MotivoDevolucionC.MostrarAlertas = False
        Me.MotivoDevolucionC.Name = Nothing
        Me.MotivoDevolucionC.RaiseListChangedEvents = True
        '
        'frmDevolucion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 589)
        Me.Controls.Add(Me.cmbMotivoDevolucion)
        Me.Controls.Add(Me.txtCodigoMotivoDevolucion)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.gbCaja)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtLoteCorte)
        Me.Controls.Add(Me.txtFolioEtiqueta)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCodigoCliente)
        Me.Controls.Add(Me.gbDevolucionesmasde1)
        Me.Controls.Add(Me.dtFechaEmbarque)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.gbListaDevolucionesRegistradas)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.chkUtilParaVenta)
        Me.Controls.Add(Me.txtFolioEmbarque)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.KeyPreview = True
        Me.Name = "frmDevolucion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Devoluciones de Ventas"
        CType(Me.dgDevoluciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbListaDevolucionesRegistradas.ResumeLayout(False)
        Me.gbDevolucionesmasde1.ResumeLayout(False)
        Me.gbDevolucionesmasde1.PerformLayout()
        Me.gbCaja.ResumeLayout(False)
        Me.gbCaja.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFolio As Integralab.Controles.TextBoxMejorado
    Friend WithEvents btnVaciarPistola As System.Windows.Forms.Button
    Friend WithEvents imgCajas As System.Windows.Forms.ImageList
    Friend WithEvents btnBusquedaEtiquetas As System.Windows.Forms.Button
    Friend WithEvents chkUtilParaVenta As System.Windows.Forms.CheckBox
    Friend WithEvents dtFechaEmbarque As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtFolioEmbarque As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dgDevoluciones As System.Windows.Forms.DataGridView
    Friend WithEvents gbListaDevolucionesRegistradas As System.Windows.Forms.GroupBox
    Friend WithEvents gbDevolucionesmasde1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFolioEmbarqueConsulta As Integralab.Controles.TextBoxMejorado
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoCliente As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents gbCaja As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodigoCorte As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtCodigoPrecorte As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents dtFechaCaducidad As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtFechaEmpaque As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCorte As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPrecorte As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPiezas As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtKilos As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLoteCorte As System.Windows.Forms.TextBox
    Friend WithEvents txtFolioEtiqueta As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents btnBuscarCortes As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoMotivoDevolucion As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents cmbMotivoDevolucion As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents MotivoDevolucionC As ClasesNegocio.MotivoDevolucionColeccionClass
    Friend WithEvents clmFolioDevilucion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFolioEmbarque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdPreCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPrecorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEsCaja As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmUtilParaVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPiezas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmKilos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFecha As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
