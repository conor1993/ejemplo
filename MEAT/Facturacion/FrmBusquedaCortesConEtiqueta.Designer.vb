<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusquedaCortesConEtiqueta
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DgvCortes = New System.Windows.Forms.DataGridView
        Me.clmSeleccion = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ClmLoteCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFolioEtiqueta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmAlmacen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFolioSacrificio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFolioEmbarque = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFechaCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCodigoCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPiezas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmKilos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCodPrecorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCodigoBarra = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.txtCorte = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtFolioSacrificio = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.chkAgregar = New System.Windows.Forms.CheckBox
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
        Me.txtFolioEtiqueta = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtLoteCorte = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtPiezas = New Integralab.Controles.TextBoxMejorado
        Me.txtKilos = New Integralab.Controles.TextBoxMejorado
        Me.gbResultado = New System.Windows.Forms.GroupBox
        Me.btnQuitarSeleccion = New System.Windows.Forms.Button
        Me.btnSleccionar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkAjustada = New System.Windows.Forms.CheckBox
        Me.ChkCanceladas = New System.Windows.Forms.CheckBox
        Me.chkReproceso = New System.Windows.Forms.CheckBox
        Me.chkEmbarcadas = New System.Windows.Forms.CheckBox
        Me.chkVigentes = New System.Windows.Forms.CheckBox
        Me.txtFolioEmbarque = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmbAlmacen = New System.Windows.Forms.ComboBox
        Me.txtAlmacenCodigo = New System.Windows.Forms.TextBox
        CType(Me.DgvCortes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbResultado.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvCortes
        '
        Me.DgvCortes.AllowUserToAddRows = False
        Me.DgvCortes.AllowUserToResizeRows = False
        Me.DgvCortes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvCortes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmSeleccion, Me.ClmLoteCorte, Me.clmFolioEtiqueta, Me.clmAlmacen, Me.clmFolioSacrificio, Me.clmFolioEmbarque, Me.clmFechaCorte, Me.clmCodigoCorte, Me.clmCorte, Me.clmPiezas, Me.clmKilos, Me.clmCodPrecorte, Me.clmIdProducto, Me.clmEstatus, Me.clmCodigoBarra})
        Me.DgvCortes.Location = New System.Drawing.Point(6, 48)
        Me.DgvCortes.Name = "DgvCortes"
        Me.DgvCortes.RowHeadersVisible = False
        Me.DgvCortes.Size = New System.Drawing.Size(824, 420)
        Me.DgvCortes.TabIndex = 0
        '
        'clmSeleccion
        '
        Me.clmSeleccion.HeaderText = ""
        Me.clmSeleccion.Name = "clmSeleccion"
        Me.clmSeleccion.Width = 30
        '
        'ClmLoteCorte
        '
        Me.ClmLoteCorte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ClmLoteCorte.DataPropertyName = "LoteCorte"
        Me.ClmLoteCorte.HeaderText = "Lote Corte"
        Me.ClmLoteCorte.Name = "ClmLoteCorte"
        Me.ClmLoteCorte.Width = 79
        '
        'clmFolioEtiqueta
        '
        Me.clmFolioEtiqueta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmFolioEtiqueta.DataPropertyName = "IdFolioEtiqueta"
        Me.clmFolioEtiqueta.HeaderText = "Folio Etiqueta"
        Me.clmFolioEtiqueta.Name = "clmFolioEtiqueta"
        Me.clmFolioEtiqueta.Width = 94
        '
        'clmAlmacen
        '
        Me.clmAlmacen.DataPropertyName = "Almacen"
        Me.clmAlmacen.HeaderText = "Almacen"
        Me.clmAlmacen.Name = "clmAlmacen"
        '
        'clmFolioSacrificio
        '
        Me.clmFolioSacrificio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmFolioSacrificio.DataPropertyName = "LoteSacrificio"
        Me.clmFolioSacrificio.HeaderText = "Folio Sacrificio"
        Me.clmFolioSacrificio.Name = "clmFolioSacrificio"
        Me.clmFolioSacrificio.Width = 98
        '
        'clmFolioEmbarque
        '
        Me.clmFolioEmbarque.DataPropertyName = "IdFolioEmbarque"
        Me.clmFolioEmbarque.HeaderText = "Folio Embarque"
        Me.clmFolioEmbarque.Name = "clmFolioEmbarque"
        '
        'clmFechaCorte
        '
        Me.clmFechaCorte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmFechaCorte.DataPropertyName = "FechaCorte"
        Me.clmFechaCorte.HeaderText = "Fecha Corte"
        Me.clmFechaCorte.Name = "clmFechaCorte"
        Me.clmFechaCorte.Width = 88
        '
        'clmCodigoCorte
        '
        Me.clmCodigoCorte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmCodigoCorte.DataPropertyName = "CodCorte"
        Me.clmCodigoCorte.HeaderText = "Código Corte"
        Me.clmCodigoCorte.Name = "clmCodigoCorte"
        Me.clmCodigoCorte.Width = 91
        '
        'clmCorte
        '
        Me.clmCorte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmCorte.DataPropertyName = "NomSubCorte"
        Me.clmCorte.HeaderText = "Corte"
        Me.clmCorte.Name = "clmCorte"
        Me.clmCorte.Width = 55
        '
        'clmPiezas
        '
        Me.clmPiezas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmPiezas.DataPropertyName = "CantPzas"
        Me.clmPiezas.HeaderText = "Piezas"
        Me.clmPiezas.Name = "clmPiezas"
        Me.clmPiezas.Width = 61
        '
        'clmKilos
        '
        Me.clmKilos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmKilos.DataPropertyName = "CantKgrs"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.clmKilos.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmKilos.HeaderText = "Kilos"
        Me.clmKilos.Name = "clmKilos"
        Me.clmKilos.Width = 52
        '
        'clmCodPrecorte
        '
        Me.clmCodPrecorte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmCodPrecorte.DataPropertyName = "CodPreCorte"
        Me.clmCodPrecorte.HeaderText = "Cod Precorte"
        Me.clmCodPrecorte.Name = "clmCodPrecorte"
        Me.clmCodPrecorte.Visible = False
        '
        'clmIdProducto
        '
        Me.clmIdProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmIdProducto.DataPropertyName = "IdProducto"
        Me.clmIdProducto.HeaderText = "Id Producto"
        Me.clmIdProducto.Name = "clmIdProducto"
        Me.clmIdProducto.Visible = False
        '
        'clmEstatus
        '
        Me.clmEstatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmEstatus.DataPropertyName = "Estatus"
        Me.clmEstatus.HeaderText = "Estatus"
        Me.clmEstatus.Name = "clmEstatus"
        Me.clmEstatus.Width = 65
        '
        'clmCodigoBarra
        '
        Me.clmCodigoBarra.DataPropertyName = "CodigoBarra"
        Me.clmCodigoBarra.HeaderText = "CodigoBarra"
        Me.clmCodigoBarra.Name = "clmCodigoBarra"
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(50, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(851, 31)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Búsqueda  de Cortes"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCorte
        '
        Me.txtCorte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCorte.Location = New System.Drawing.Point(310, 62)
        Me.txtCorte.Name = "txtCorte"
        Me.txtCorte.Size = New System.Drawing.Size(310, 20)
        Me.txtCorte.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(263, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Corte:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Location = New System.Drawing.Point(814, 620)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 20
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Location = New System.Drawing.Point(714, 620)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 19
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(435, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(481, 115)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(94, 20)
        Me.dtpFecha.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Folio Sacrificio :"
        '
        'txtFolioSacrificio
        '
        Me.txtFolioSacrificio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFolioSacrificio.Location = New System.Drawing.Point(143, 88)
        Me.txtFolioSacrificio.Name = "txtFolioSacrificio"
        Me.txtFolioSacrificio.Size = New System.Drawing.Size(114, 20)
        Me.txtFolioSacrificio.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(356, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Kilos :"
        '
        'mtb
        '
        Me.mtb.ButtonSize = New System.Drawing.Size(50, 50)
        Me.mtb.Dock = System.Windows.Forms.DockStyle.Left
        Me.mtb.DropDownArrows = True
        Me.mtb.HabilitarBorrar = True
        Me.mtb.HabilitarBuscar = True
        Me.mtb.HabilitarCancelar = True
        Me.mtb.HabilitarEditar = False
        Me.mtb.HabilitarGuardar = True
        Me.mtb.HabilitarImprimir = True
        Me.mtb.HabilitarLimpiar = True
        Me.mtb.HabilitarNuevo = True
        Me.mtb.HabilitarSalir = True
        Me.mtb.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32
        Me.mtb.Location = New System.Drawing.Point(0, 0)
        Me.mtb.MostrarBorrar = False
        Me.mtb.MostrarBuscar = True
        Me.mtb.MostrarCancelar = False
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = False
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 655)
        Me.mtb.TabIndex = 0
        '
        'chkAgregar
        '
        Me.chkAgregar.AutoSize = True
        Me.chkAgregar.Location = New System.Drawing.Point(266, 117)
        Me.chkAgregar.Name = "chkAgregar"
        Me.chkAgregar.Size = New System.Drawing.Size(163, 17)
        Me.chkAgregar.TabIndex = 14
        Me.chkAgregar.Text = "Agregar fecha a la busqueda"
        Me.chkAgregar.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "LoteCorte"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Lote Corte"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IdFolioEtiqueta"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Folio Etiqueta"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "LoteSacrificio"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Folio Sacrificio"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "FechaCorte"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fecha Corte"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "NomSubCorte"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Corte"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 160
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CantPzas"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Piezas"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CantKgrs"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Kilos"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CodPreCorte"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Cod Precorte"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "CodCorte"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Cod Corte"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "IdProducto"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Id Producto"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'txtFolioEtiqueta
        '
        Me.txtFolioEtiqueta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFolioEtiqueta.Location = New System.Drawing.Point(143, 62)
        Me.txtFolioEtiqueta.Name = "txtFolioEtiqueta"
        Me.txtFolioEtiqueta.Size = New System.Drawing.Size(114, 20)
        Me.txtFolioEtiqueta.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Folio Etiqueta:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(263, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Piezas:"
        '
        'txtLoteCorte
        '
        Me.txtLoteCorte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLoteCorte.Location = New System.Drawing.Point(506, 36)
        Me.txtLoteCorte.Name = "txtLoteCorte"
        Me.txtLoteCorte.Size = New System.Drawing.Size(114, 20)
        Me.txtLoteCorte.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(441, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Lote Corte:"
        '
        'txtPiezas
        '
        Me.txtPiezas.ComboBoxEnlazado = Nothing
        Me.txtPiezas.Decimales = 0
        Me.txtPiezas.Location = New System.Drawing.Point(310, 88)
        Me.txtPiezas.MaxLength = 3000
        Me.txtPiezas.MensajeCombo = "Seleccionar un item..."
        Me.txtPiezas.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtPiezas.Name = "txtPiezas"
        Me.txtPiezas.SiguienteControl = Nothing
        Me.txtPiezas.Size = New System.Drawing.Size(40, 20)
        Me.txtPiezas.TabIndex = 9
        Me.txtPiezas.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtPiezas.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtPiezas.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtKilos
        '
        Me.txtKilos.ComboBoxEnlazado = Nothing
        Me.txtKilos.Decimales = 2
        Me.txtKilos.Location = New System.Drawing.Point(397, 88)
        Me.txtKilos.MaxLength = 3000
        Me.txtKilos.MensajeCombo = "Seleccionar un item..."
        Me.txtKilos.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtKilos.Name = "txtKilos"
        Me.txtKilos.SiguienteControl = Nothing
        Me.txtKilos.Size = New System.Drawing.Size(63, 20)
        Me.txtKilos.TabIndex = 11
        Me.txtKilos.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.[Decimal]
        Me.txtKilos.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtKilos.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'gbResultado
        '
        Me.gbResultado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbResultado.Controls.Add(Me.btnQuitarSeleccion)
        Me.gbResultado.Controls.Add(Me.btnSleccionar)
        Me.gbResultado.Controls.Add(Me.DgvCortes)
        Me.gbResultado.Location = New System.Drawing.Point(56, 140)
        Me.gbResultado.Name = "gbResultado"
        Me.gbResultado.Size = New System.Drawing.Size(836, 474)
        Me.gbResultado.TabIndex = 18
        Me.gbResultado.TabStop = False
        Me.gbResultado.Text = "Resultado"
        '
        'btnQuitarSeleccion
        '
        Me.btnQuitarSeleccion.Location = New System.Drawing.Point(118, 19)
        Me.btnQuitarSeleccion.Name = "btnQuitarSeleccion"
        Me.btnQuitarSeleccion.Size = New System.Drawing.Size(106, 23)
        Me.btnQuitarSeleccion.TabIndex = 2
        Me.btnQuitarSeleccion.Text = "Quitar Selección"
        Me.btnQuitarSeleccion.UseVisualStyleBackColor = True
        '
        'btnSleccionar
        '
        Me.btnSleccionar.Location = New System.Drawing.Point(6, 19)
        Me.btnSleccionar.Name = "btnSleccionar"
        Me.btnSleccionar.Size = New System.Drawing.Size(106, 23)
        Me.btnSleccionar.TabIndex = 1
        Me.btnSleccionar.Text = "Sleccionar Todas"
        Me.btnSleccionar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkAjustada)
        Me.GroupBox1.Controls.Add(Me.ChkCanceladas)
        Me.GroupBox1.Controls.Add(Me.chkReproceso)
        Me.GroupBox1.Controls.Add(Me.chkEmbarcadas)
        Me.GroupBox1.Controls.Add(Me.chkVigentes)
        Me.GroupBox1.Location = New System.Drawing.Point(650, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(242, 96)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Estatus"
        '
        'chkAjustada
        '
        Me.chkAjustada.AutoSize = True
        Me.chkAjustada.Checked = True
        Me.chkAjustada.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAjustada.Location = New System.Drawing.Point(7, 66)
        Me.chkAjustada.Name = "chkAjustada"
        Me.chkAjustada.Size = New System.Drawing.Size(89, 17)
        Me.chkAjustada.TabIndex = 4
        Me.chkAjustada.Text = "AJUSTADAS"
        Me.chkAjustada.UseVisualStyleBackColor = True
        '
        'ChkCanceladas
        '
        Me.ChkCanceladas.AutoSize = True
        Me.ChkCanceladas.Checked = True
        Me.ChkCanceladas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkCanceladas.Location = New System.Drawing.Point(125, 43)
        Me.ChkCanceladas.Name = "ChkCanceladas"
        Me.ChkCanceladas.Size = New System.Drawing.Size(97, 17)
        Me.ChkCanceladas.TabIndex = 3
        Me.ChkCanceladas.Text = "CANCELADAS"
        Me.ChkCanceladas.UseVisualStyleBackColor = True
        '
        'chkReproceso
        '
        Me.chkReproceso.AutoSize = True
        Me.chkReproceso.Checked = True
        Me.chkReproceso.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkReproceso.Location = New System.Drawing.Point(125, 20)
        Me.chkReproceso.Name = "chkReproceso"
        Me.chkReproceso.Size = New System.Drawing.Size(114, 17)
        Me.chkReproceso.TabIndex = 2
        Me.chkReproceso.Text = "REPROCESADAS"
        Me.chkReproceso.UseVisualStyleBackColor = True
        '
        'chkEmbarcadas
        '
        Me.chkEmbarcadas.AutoSize = True
        Me.chkEmbarcadas.Checked = True
        Me.chkEmbarcadas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEmbarcadas.Location = New System.Drawing.Point(7, 43)
        Me.chkEmbarcadas.Name = "chkEmbarcadas"
        Me.chkEmbarcadas.Size = New System.Drawing.Size(100, 17)
        Me.chkEmbarcadas.TabIndex = 1
        Me.chkEmbarcadas.Text = "EMBARCADAS"
        Me.chkEmbarcadas.UseVisualStyleBackColor = True
        '
        'chkVigentes
        '
        Me.chkVigentes.AutoSize = True
        Me.chkVigentes.Checked = True
        Me.chkVigentes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVigentes.Location = New System.Drawing.Point(7, 20)
        Me.chkVigentes.Name = "chkVigentes"
        Me.chkVigentes.Size = New System.Drawing.Size(80, 17)
        Me.chkVigentes.TabIndex = 0
        Me.chkVigentes.Text = "VIGENTES"
        Me.chkVigentes.UseVisualStyleBackColor = True
        '
        'txtFolioEmbarque
        '
        Me.txtFolioEmbarque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFolioEmbarque.Location = New System.Drawing.Point(143, 114)
        Me.txtFolioEmbarque.Name = "txtFolioEmbarque"
        Me.txtFolioEmbarque.Size = New System.Drawing.Size(114, 20)
        Me.txtFolioEmbarque.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(56, 117)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Folio Embarque:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(56, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Almacen:"
        '
        'cmbAlmacen
        '
        Me.cmbAlmacen.FormattingEnabled = True
        Me.cmbAlmacen.Location = New System.Drawing.Point(212, 35)
        Me.cmbAlmacen.Name = "cmbAlmacen"
        Me.cmbAlmacen.Size = New System.Drawing.Size(223, 21)
        Me.cmbAlmacen.TabIndex = 24
        '
        'txtAlmacenCodigo
        '
        Me.txtAlmacenCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAlmacenCodigo.Location = New System.Drawing.Point(143, 36)
        Me.txtAlmacenCodigo.Name = "txtAlmacenCodigo"
        Me.txtAlmacenCodigo.Size = New System.Drawing.Size(63, 20)
        Me.txtAlmacenCodigo.TabIndex = 25
        '
        'FrmBusquedaCortesConEtiqueta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 655)
        Me.Controls.Add(Me.txtAlmacenCodigo)
        Me.Controls.Add(Me.cmbAlmacen)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtFolioEmbarque)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbResultado)
        Me.Controls.Add(Me.txtKilos)
        Me.Controls.Add(Me.txtPiezas)
        Me.Controls.Add(Me.txtLoteCorte)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtFolioEtiqueta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chkAgregar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtFolioSacrificio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCorte)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.mtb)
        Me.Name = "FrmBusquedaCortesConEtiqueta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Búsqueda de Cortes"
        CType(Me.DgvCortes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbResultado.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgvCortes As System.Windows.Forms.DataGridView
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents txtCorte As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFolioSacrificio As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents chkAgregar As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtFolioEtiqueta As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLoteCorte As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPiezas As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtKilos As Integralab.Controles.TextBoxMejorado
    Friend WithEvents gbResultado As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkCanceladas As System.Windows.Forms.CheckBox
    Friend WithEvents chkReproceso As System.Windows.Forms.CheckBox
    Friend WithEvents chkEmbarcadas As System.Windows.Forms.CheckBox
    Friend WithEvents chkVigentes As System.Windows.Forms.CheckBox
    Friend WithEvents txtFolioEmbarque As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chkAjustada As System.Windows.Forms.CheckBox
    Friend WithEvents btnQuitarSeleccion As System.Windows.Forms.Button
    Friend WithEvents btnSleccionar As System.Windows.Forms.Button
    Friend WithEvents clmSeleccion As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ClmLoteCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFolioEtiqueta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmAlmacen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFolioSacrificio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFolioEmbarque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCodigoCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPiezas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmKilos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCodPrecorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCodigoBarra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents txtAlmacenCodigo As System.Windows.Forms.TextBox
End Class
