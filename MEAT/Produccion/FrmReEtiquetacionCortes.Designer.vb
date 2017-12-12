<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReEtiquetacionCortes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReEtiquetacionCortes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtLeerPeso = New wclTextBoxSerial.TextBoxSerial
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.DtpFechaCad = New System.Windows.Forms.DateTimePicker
        Me.DtpFechaCorte = New System.Windows.Forms.DateTimePicker
        Me.txtKilos = New System.Windows.Forms.TextBox
        Me.txtPzas = New System.Windows.Forms.TextBox
        Me.txtSubCorte = New System.Windows.Forms.TextBox
        Me.txtCorte = New System.Windows.Forms.TextBox
        Me.txtLoteCorte = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chkActivarLectura = New System.Windows.Forms.CheckBox
        Me.txtKilosNvos = New Integralab.Controles.TextBoxMejorado
        Me.txtPzasNvas = New Integralab.Controles.TextBoxMejorado
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtEtiqueta = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        'Me.codigoBarras = New AxTALBarCode.AxTALBarCd
        Me.txtLoteCorteFiltro = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtFiltro = New System.Windows.Forms.TextBox
        Me.DgvCortes = New System.Windows.Forms.DataGridView
        Me.clmEtiqueta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmLote = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmSubCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmKilos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPiezas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFechaCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFechaCad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFolioMov = New System.Windows.Forms.DataGridViewTextBoxColumn
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
        Me.pdDocumento = New System.Drawing.Printing.PrintDocument
        Me.ListaImagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        ' CType(Me.codigoBarras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvCortes, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.mtb.MostrarBorrar = False
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = False
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 614)
        Me.mtb.TabIndex = 45
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(804, 32)
        Me.Label17.TabIndex = 46
        Me.Label17.Text = "Re-Etiquetación de Cortes"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtLeerPeso)
        Me.GroupBox1.Controls.Add(Me.lblEstatus)
        Me.GroupBox1.Controls.Add(Me.DtpFechaCad)
        Me.GroupBox1.Controls.Add(Me.DtpFechaCorte)
        Me.GroupBox1.Controls.Add(Me.txtKilos)
        Me.GroupBox1.Controls.Add(Me.txtPzas)
        Me.GroupBox1.Controls.Add(Me.txtSubCorte)
        Me.GroupBox1.Controls.Add(Me.txtCorte)
        Me.GroupBox1.Controls.Add(Me.txtLoteCorte)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtEtiqueta)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(54, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 258)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales"
        '
        'txtLeerPeso
        '
        Me.txtLeerPeso.BaudRate = 9600
        Me.txtLeerPeso.DataBit = 8
        Me.txtLeerPeso.Format = wclTextBoxSerial.TextBoxSerial.FormatoDatos.Ascii
        Me.txtLeerPeso.Location = New System.Drawing.Point(207, 150)
        Me.txtLeerPeso.Name = "txtLeerPeso"
        Me.txtLeerPeso.Parity = wclTextBoxSerial.Rs232.DataParity.Parity_None
        Me.txtLeerPeso.Port = 1
        Me.txtLeerPeso.Size = New System.Drawing.Size(100, 20)
        Me.txtLeerPeso.StopBit = wclTextBoxSerial.Rs232.DataStopBit.StopBit_1
        Me.txtLeerPeso.TabIndex = 49
        Me.txtLeerPeso.TimeOut = 1500
        Me.txtLeerPeso.TimeToWaitForMoreData = 300
        Me.txtLeerPeso.Visible = False
        '
        'lblEstatus
        '
        Me.lblEstatus.AutoSize = True
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblEstatus.Location = New System.Drawing.Point(326, 14)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(104, 24)
        Me.lblEstatus.TabIndex = 67
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.Visible = False
        '
        'DtpFechaCad
        '
        Me.DtpFechaCad.Enabled = False
        Me.DtpFechaCad.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaCad.Location = New System.Drawing.Point(92, 149)
        Me.DtpFechaCad.Name = "DtpFechaCad"
        Me.DtpFechaCad.Size = New System.Drawing.Size(102, 20)
        Me.DtpFechaCad.TabIndex = 16
        '
        'DtpFechaCorte
        '
        Me.DtpFechaCorte.Enabled = False
        Me.DtpFechaCorte.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaCorte.Location = New System.Drawing.Point(330, 45)
        Me.DtpFechaCorte.Name = "DtpFechaCorte"
        Me.DtpFechaCorte.Size = New System.Drawing.Size(102, 20)
        Me.DtpFechaCorte.TabIndex = 15
        '
        'txtKilos
        '
        Me.txtKilos.Location = New System.Drawing.Point(332, 123)
        Me.txtKilos.Name = "txtKilos"
        Me.txtKilos.ReadOnly = True
        Me.txtKilos.Size = New System.Drawing.Size(100, 20)
        Me.txtKilos.TabIndex = 14
        '
        'txtPzas
        '
        Me.txtPzas.Location = New System.Drawing.Point(92, 123)
        Me.txtPzas.Name = "txtPzas"
        Me.txtPzas.ReadOnly = True
        Me.txtPzas.Size = New System.Drawing.Size(100, 20)
        Me.txtPzas.TabIndex = 13
        '
        'txtSubCorte
        '
        Me.txtSubCorte.Location = New System.Drawing.Point(92, 97)
        Me.txtSubCorte.Name = "txtSubCorte"
        Me.txtSubCorte.ReadOnly = True
        Me.txtSubCorte.Size = New System.Drawing.Size(340, 20)
        Me.txtSubCorte.TabIndex = 12
        '
        'txtCorte
        '
        Me.txtCorte.Location = New System.Drawing.Point(92, 71)
        Me.txtCorte.Name = "txtCorte"
        Me.txtCorte.ReadOnly = True
        Me.txtCorte.Size = New System.Drawing.Size(340, 20)
        Me.txtCorte.TabIndex = 11
        '
        'txtLoteCorte
        '
        Me.txtLoteCorte.Location = New System.Drawing.Point(92, 45)
        Me.txtLoteCorte.Name = "txtLoteCorte"
        Me.txtLoteCorte.ReadOnly = True
        Me.txtLoteCorte.Size = New System.Drawing.Size(100, 20)
        Me.txtLoteCorte.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkActivarLectura)
        Me.GroupBox2.Controls.Add(Me.txtKilosNvos)
        Me.GroupBox2.Controls.Add(Me.txtPzasNvas)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 175)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(396, 76)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nuevos Datos de la Etiqueta"
        '
        'chkActivarLectura
        '
        Me.chkActivarLectura.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkActivarLectura.Location = New System.Drawing.Point(304, 19)
        Me.chkActivarLectura.Name = "chkActivarLectura"
        Me.chkActivarLectura.Size = New System.Drawing.Size(80, 50)
        Me.chkActivarLectura.TabIndex = 93
        Me.chkActivarLectura.Text = "Lectura de Peso Desactivada"
        Me.chkActivarLectura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkActivarLectura.UseVisualStyleBackColor = True
        '
        'txtKilosNvos
        '
        Me.txtKilosNvos.ComboBoxEnlazado = Nothing
        Me.txtKilosNvos.Decimales = 0
        Me.txtKilosNvos.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKilosNvos.Location = New System.Drawing.Point(152, 19)
        Me.txtKilosNvos.MaxLength = 3000
        Me.txtKilosNvos.MensajeCombo = "Seleccionar un item..."
        Me.txtKilosNvos.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtKilosNvos.Name = "txtKilosNvos"
        Me.txtKilosNvos.SiguienteControl = Nothing
        Me.txtKilosNvos.Size = New System.Drawing.Size(146, 49)
        Me.txtKilosNvos.TabIndex = 12
        Me.txtKilosNvos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtKilosNvos.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.[Decimal]
        '
        'txtPzasNvas
        '
        Me.txtPzasNvas.ComboBoxEnlazado = Nothing
        Me.txtPzasNvas.Decimales = 0
        Me.txtPzasNvas.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPzasNvas.Location = New System.Drawing.Point(53, 19)
        Me.txtPzasNvas.MaxLength = 3000
        Me.txtPzasNvas.MensajeCombo = "Seleccionar un item..."
        Me.txtPzasNvas.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtPzasNvas.Name = "txtPzasNvas"
        Me.txtPzasNvas.SiguienteControl = Nothing
        Me.txtPzasNvas.Size = New System.Drawing.Size(55, 49)
        Me.txtPzasNvas.TabIndex = 11
        Me.txtPzasNvas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPzasNvas.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(114, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Kilos:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Piezas:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Fecha Cad:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(292, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Kilos:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Piezas:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Sub Corte:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Corte:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(241, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Fecha de Corte:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Lote de Corte:"
        '
        'txtEtiqueta
        '
        Me.txtEtiqueta.Location = New System.Drawing.Point(92, 19)
        Me.txtEtiqueta.Name = "txtEtiqueta"
        Me.txtEtiqueta.ReadOnly = True
        Me.txtEtiqueta.Size = New System.Drawing.Size(100, 20)
        Me.txtEtiqueta.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Etiqueta:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        'Me.GroupBox3.Controls.Add(Me.codigoBarras)
        Me.GroupBox3.Controls.Add(Me.txtLoteCorteFiltro)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtFiltro)
        Me.GroupBox3.Controls.Add(Me.DgvCortes)
        Me.GroupBox3.Location = New System.Drawing.Point(54, 299)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(790, 303)
        Me.GroupBox3.TabIndex = 48
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Etiquetas de Cortes"
        '
        'codigoBarras
        '
        'Me.codigoBarras.Enabled = True
        'Me.codigoBarras.Location = New System.Drawing.Point(572, 74)
        'Me.codigoBarras.Name = "codigoBarras"
        'Me.codigoBarras.OcxState = CType(resources.GetObject("codigoBarras.OcxState"), System.Windows.Forms.AxHost.State)
        'Me.codigoBarras.Size = New System.Drawing.Size(126, 109)
        'Me.codigoBarras.TabIndex = 68
        'Me.codigoBarras.Visible = False
        '
        'txtLoteCorteFiltro
        '
        Me.txtLoteCorteFiltro.Location = New System.Drawing.Point(86, 19)
        Me.txtLoteCorteFiltro.Name = "txtLoteCorteFiltro"
        Me.txtLoteCorteFiltro.Size = New System.Drawing.Size(132, 20)
        Me.txtLoteCorteFiltro.TabIndex = 69
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 13)
        Me.Label12.TabIndex = 68
        Me.Label12.Text = "Lote de Corte:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(230, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Corte:"
        '
        'txtFiltro
        '
        Me.txtFiltro.Location = New System.Drawing.Point(271, 19)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(337, 20)
        Me.txtFiltro.TabIndex = 1
        '
        'DgvCortes
        '
        Me.DgvCortes.AllowUserToAddRows = False
        Me.DgvCortes.AllowUserToDeleteRows = False
        Me.DgvCortes.AllowUserToResizeRows = False
        Me.DgvCortes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvCortes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCortes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmEtiqueta, Me.clmIdProducto, Me.clmLote, Me.clmCorte, Me.clmSubCorte, Me.clmKilos, Me.clmPiezas, Me.clmFechaCorte, Me.clmFechaCad, Me.clmEstatus, Me.clmFolioMov})
        Me.DgvCortes.Location = New System.Drawing.Point(6, 45)
        Me.DgvCortes.MultiSelect = False
        Me.DgvCortes.Name = "DgvCortes"
        Me.DgvCortes.ReadOnly = True
        Me.DgvCortes.RowHeadersVisible = False
        Me.DgvCortes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCortes.Size = New System.Drawing.Size(778, 252)
        Me.DgvCortes.TabIndex = 0
        '
        'clmEtiqueta
        '
        Me.clmEtiqueta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmEtiqueta.DataPropertyName = "IdFolioEtiqueta"
        Me.clmEtiqueta.HeaderText = "Etiqueta"
        Me.clmEtiqueta.Name = "clmEtiqueta"
        Me.clmEtiqueta.ReadOnly = True
        Me.clmEtiqueta.Width = 71
        '
        'clmIdProducto
        '
        Me.clmIdProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmIdProducto.DataPropertyName = "IdProducto"
        Me.clmIdProducto.HeaderText = "Id Producto"
        Me.clmIdProducto.Name = "clmIdProducto"
        Me.clmIdProducto.ReadOnly = True
        Me.clmIdProducto.Visible = False
        '
        'clmLote
        '
        Me.clmLote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmLote.DataPropertyName = "LoteCorte"
        Me.clmLote.HeaderText = "Lote"
        Me.clmLote.Name = "clmLote"
        Me.clmLote.ReadOnly = True
        Me.clmLote.Width = 53
        '
        'clmCorte
        '
        Me.clmCorte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmCorte.DataPropertyName = "NomCorte"
        Me.clmCorte.HeaderText = "Corte"
        Me.clmCorte.Name = "clmCorte"
        Me.clmCorte.ReadOnly = True
        Me.clmCorte.Width = 57
        '
        'clmSubCorte
        '
        Me.clmSubCorte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmSubCorte.DataPropertyName = "NomSubCorte"
        Me.clmSubCorte.HeaderText = "SubCorte"
        Me.clmSubCorte.Name = "clmSubCorte"
        Me.clmSubCorte.ReadOnly = True
        Me.clmSubCorte.Width = 76
        '
        'clmKilos
        '
        Me.clmKilos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmKilos.DataPropertyName = "CantKgrs"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "C3"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.clmKilos.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmKilos.HeaderText = "Kilos"
        Me.clmKilos.Name = "clmKilos"
        Me.clmKilos.ReadOnly = True
        Me.clmKilos.Width = 54
        '
        'clmPiezas
        '
        Me.clmPiezas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmPiezas.DataPropertyName = "CantPzas"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.clmPiezas.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmPiezas.HeaderText = "Piezas"
        Me.clmPiezas.Name = "clmPiezas"
        Me.clmPiezas.ReadOnly = True
        Me.clmPiezas.Width = 63
        '
        'clmFechaCorte
        '
        Me.clmFechaCorte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmFechaCorte.DataPropertyName = "FechaCorte"
        Me.clmFechaCorte.HeaderText = "Fecha Corte"
        Me.clmFechaCorte.Name = "clmFechaCorte"
        Me.clmFechaCorte.ReadOnly = True
        Me.clmFechaCorte.Width = 83
        '
        'clmFechaCad
        '
        Me.clmFechaCad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmFechaCad.DataPropertyName = "FechaCad"
        Me.clmFechaCad.HeaderText = "Fecha Caducidad"
        Me.clmFechaCad.Name = "clmFechaCad"
        Me.clmFechaCad.ReadOnly = True
        Me.clmFechaCad.Width = 106
        '
        'clmEstatus
        '
        Me.clmEstatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmEstatus.DataPropertyName = "Estatus"
        Me.clmEstatus.HeaderText = "Estatus"
        Me.clmEstatus.Name = "clmEstatus"
        Me.clmEstatus.ReadOnly = True
        Me.clmEstatus.Width = 67
        '
        'clmFolioMov
        '
        Me.clmFolioMov.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmFolioMov.DataPropertyName = "IdFolioMovimiento"
        Me.clmFolioMov.HeaderText = "Folio Movimiento"
        Me.clmFolioMov.Name = "clmFolioMov"
        Me.clmFolioMov.ReadOnly = True
        Me.clmFolioMov.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdFolioEtiqueta"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Etiqueta"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IdProducto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Id Producto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "LoteCorte"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Lote"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NomCorte"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Corte"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "NomSubCorte"
        Me.DataGridViewTextBoxColumn5.HeaderText = "SubCorte"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CantKgrs"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C3"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn6.HeaderText = "Kilos"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CantPzas"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn7.HeaderText = "Piezas"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "FechaCorte"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Fecha Corte"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "FechaCad"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Fecha Caducidad"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Estatus"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Estatus"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "IdFolioMovimiento"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Folio Movimiento"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'ListaImagenes
        '
        Me.ListaImagenes.ImageStream = CType(resources.GetObject("ListaImagenes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ListaImagenes.TransparentColor = System.Drawing.Color.Transparent
        Me.ListaImagenes.Images.SetKeyName(0, "fELCHA.JPG")
        Me.ListaImagenes.Images.SetKeyName(1, "GetAttachment.aspx.jpg")
        '
        'FrmReEtiquetacionCortes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 614)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmReEtiquetacionCortes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Re-Etiquetación de Cortes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        'CType(Me.codigoBarras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvCortes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEtiqueta As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DgvCortes As System.Windows.Forms.DataGridView
    Friend WithEvents DtpFechaCad As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpFechaCorte As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtKilos As System.Windows.Forms.TextBox
    Friend WithEvents txtPzas As System.Windows.Forms.TextBox
    Friend WithEvents txtSubCorte As System.Windows.Forms.TextBox
    Friend WithEvents txtCorte As System.Windows.Forms.TextBox
    Friend WithEvents txtLoteCorte As System.Windows.Forms.TextBox
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents txtKilosNvos As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtPzasNvas As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents clmEtiqueta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmLote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSubCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmKilos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPiezas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaCad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFolioMov As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtLeerPeso As wclTextBoxSerial.TextBoxSerial
    Friend WithEvents txtLoteCorteFiltro As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
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
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkActivarLectura As System.Windows.Forms.CheckBox
    'Friend WithEvents codigoBarras As AxTALBarCode.AxTALBarCd
    Friend WithEvents pdDocumento As System.Drawing.Printing.PrintDocument
    Friend WithEvents ListaImagenes As System.Windows.Forms.ImageList
End Class
