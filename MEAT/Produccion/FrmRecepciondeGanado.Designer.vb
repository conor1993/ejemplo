<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRecepciondeGanado
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
        Me.mtb = New MEAToolBar.MEAToolBar()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtLeerPeso = New wclTextBoxSerial.TextBoxSerial()
        Me.chkBascula = New System.Windows.Forms.CheckBox()
        Me.txtCabezasHembra = New IntegraLab.Controles.TextBoxMejorado()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.txtCabezasMachos = New IntegraLab.Controles.TextBoxMejorado()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CmbTipoGanado = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtKilos1erpasada = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ChkMultiples = New System.Windows.Forms.CheckBox()
        Me.chkMaquila = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPlacas = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtConductor = New System.Windows.Forms.TextBox()
        Me.txtUnidad = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbIntroductor = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtKilosEnviados = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCantCabezas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLoteEngorda = New System.Windows.Forms.TextBox()
        Me.LblReferenciaOLote = New System.Windows.Forms.Label()
        Me.dtpFechaRecepcion = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtLoteRecepcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.gb2dapesada = New System.Windows.Forms.GroupBox()
        Me.txtKilos2daPasada = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKilosRecibidos = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.gb2dapesada.SuspendLayout()
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
        Me.mtb.Size = New System.Drawing.Size(50, 501)
        Me.mtb.TabIndex = 48
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(509, 32)
        Me.Label17.TabIndex = 47
        Me.Label17.Text = "Recepción de Animales a Sacrificio o en Pie / Materia Prima"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.gb2dapesada)
        Me.GroupBox1.Controls.Add(Me.txtLeerPeso)
        Me.GroupBox1.Controls.Add(Me.chkBascula)
        Me.GroupBox1.Controls.Add(Me.txtCabezasHembra)
        Me.GroupBox1.Controls.Add(Me.txtCabezasMachos)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.CmbTipoGanado)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtKilos1erpasada)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.ChkMultiples)
        Me.GroupBox1.Controls.Add(Me.chkMaquila)
        Me.GroupBox1.Controls.Add(Me.txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtPlacas)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtConductor)
        Me.GroupBox1.Controls.Add(Me.txtUnidad)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmbIntroductor)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtKilosEnviados)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCantCabezas)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtLoteEngorda)
        Me.GroupBox1.Controls.Add(Me.LblReferenciaOLote)
        Me.GroupBox1.Controls.Add(Me.dtpFechaRecepcion)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtLoteRecepcion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(60, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(490, 454)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        '
        'txtLeerPeso
        '
        Me.txtLeerPeso.BaudRate = 9600
        Me.txtLeerPeso.DataBit = 8
        Me.txtLeerPeso.Format = wclTextBoxSerial.TextBoxSerial.FormatoDatos.Ascii
        Me.txtLeerPeso.Location = New System.Drawing.Point(20, 406)
        Me.txtLeerPeso.Name = "txtLeerPeso"
        Me.txtLeerPeso.Parity = wclTextBoxSerial.Rs232.DataParity.Parity_None
        Me.txtLeerPeso.Port = 1
        Me.txtLeerPeso.Size = New System.Drawing.Size(67, 20)
        Me.txtLeerPeso.StopBit = wclTextBoxSerial.Rs232.DataStopBit.StopBit_1
        Me.txtLeerPeso.TabIndex = 91
        Me.txtLeerPeso.TimeOut = 1500
        Me.txtLeerPeso.TimeToWaitForMoreData = 300
        Me.txtLeerPeso.Visible = False
        '
        'chkBascula
        '
        Me.chkBascula.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkBascula.Location = New System.Drawing.Point(293, 68)
        Me.chkBascula.Name = "chkBascula"
        Me.chkBascula.Size = New System.Drawing.Size(76, 72)
        Me.chkBascula.TabIndex = 90
        Me.chkBascula.Text = "Lectura de Bascula Desactivada"
        Me.chkBascula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkBascula.UseVisualStyleBackColor = True
        '
        'txtCabezasHembra
        '
        Me.txtCabezasHembra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCabezasHembra.ComboBoxEnlazado = Nothing
        Me.txtCabezasHembra.Decimales = 0
        Me.txtCabezasHembra.Location = New System.Drawing.Point(161, 124)
        Me.txtCabezasHembra.MaxLength = 3000
        Me.txtCabezasHembra.MensajeCombo = "Seleccionar un item..."
        Me.txtCabezasHembra.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtCabezasHembra.Name = "txtCabezasHembra"
        Me.txtCabezasHembra.SiguienteControl = Me.txtObservaciones
        Me.txtCabezasHembra.Size = New System.Drawing.Size(72, 20)
        Me.txtCabezasHembra.TabIndex = 89
        Me.txtCabezasHembra.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtCabezasHembra.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCabezasHembra.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Location = New System.Drawing.Point(161, 374)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(314, 61)
        Me.txtObservaciones.TabIndex = 78
        '
        'txtCabezasMachos
        '
        Me.txtCabezasMachos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCabezasMachos.ComboBoxEnlazado = Nothing
        Me.txtCabezasMachos.Decimales = 0
        Me.txtCabezasMachos.Location = New System.Drawing.Point(161, 98)
        Me.txtCabezasMachos.MaxLength = 3000
        Me.txtCabezasMachos.MensajeCombo = "Seleccionar un item..."
        Me.txtCabezasMachos.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtCabezasMachos.Name = "txtCabezasMachos"
        Me.txtCabezasMachos.SiguienteControl = Me.txtObservaciones
        Me.txtCabezasMachos.Size = New System.Drawing.Size(72, 20)
        Me.txtCabezasMachos.TabIndex = 88
        Me.txtCabezasMachos.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtCabezasMachos.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCabezasMachos.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 127)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(109, 13)
        Me.Label15.TabIndex = 87
        Me.Label15.Text = "No. de Cab Hembras:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 101)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(148, 13)
        Me.Label14.TabIndex = 86
        Me.Label14.Text = "No. de Cab Machos/Combos:"
        '
        'CmbTipoGanado
        '
        Me.CmbTipoGanado.FormattingEnabled = True
        Me.CmbTipoGanado.Location = New System.Drawing.Point(161, 238)
        Me.CmbTipoGanado.Name = "CmbTipoGanado"
        Me.CmbTipoGanado.Size = New System.Drawing.Size(314, 21)
        Me.CmbTipoGanado.TabIndex = 69
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 241)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(143, 13)
        Me.Label13.TabIndex = 84
        Me.Label13.Text = "Tipo Ganado/Materia prima :"
        '
        'txtKilos1erpasada
        '
        Me.txtKilos1erpasada.Location = New System.Drawing.Point(161, 207)
        Me.txtKilos1erpasada.Name = "txtKilos1erpasada"
        Me.txtKilos1erpasada.Size = New System.Drawing.Size(102, 20)
        Me.txtKilos1erpasada.TabIndex = 65
        Me.txtKilos1erpasada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 210)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 13)
        Me.Label12.TabIndex = 79
        Me.Label12.Text = "Kilos 1er Pesada :"
        '
        'ChkMultiples
        '
        Me.ChkMultiples.AutoSize = True
        Me.ChkMultiples.Location = New System.Drawing.Point(343, 45)
        Me.ChkMultiples.Name = "ChkMultiples"
        Me.ChkMultiples.Size = New System.Drawing.Size(132, 17)
        Me.ChkMultiples.TabIndex = 85
        Me.ChkMultiples.Text = "Múltiples Introductores"
        Me.ChkMultiples.UseVisualStyleBackColor = True
        '
        'chkMaquila
        '
        Me.chkMaquila.AutoSize = True
        Me.chkMaquila.Location = New System.Drawing.Point(277, 45)
        Me.chkMaquila.Name = "chkMaquila"
        Me.chkMaquila.Size = New System.Drawing.Size(63, 17)
        Me.chkMaquila.TabIndex = 80
        Me.chkMaquila.Text = "Maquila"
        Me.chkMaquila.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 377)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 13)
        Me.Label11.TabIndex = 73
        Me.Label11.Text = "Observaciones :"
        '
        'txtPlacas
        '
        Me.txtPlacas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlacas.Location = New System.Drawing.Point(161, 347)
        Me.txtPlacas.Name = "txtPlacas"
        Me.txtPlacas.Size = New System.Drawing.Size(102, 20)
        Me.txtPlacas.TabIndex = 77
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 350)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "Placas :"
        '
        'txtConductor
        '
        Me.txtConductor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConductor.Location = New System.Drawing.Point(161, 321)
        Me.txtConductor.Name = "txtConductor"
        Me.txtConductor.Size = New System.Drawing.Size(314, 20)
        Me.txtConductor.TabIndex = 74
        '
        'txtUnidad
        '
        Me.txtUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUnidad.Location = New System.Drawing.Point(161, 294)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(314, 20)
        Me.txtUnidad.TabIndex = 72
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 324)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Conductor :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 297)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Unidad :"
        '
        'cmbIntroductor
        '
        Me.cmbIntroductor.FormattingEnabled = True
        Me.cmbIntroductor.Location = New System.Drawing.Point(161, 267)
        Me.cmbIntroductor.Name = "cmbIntroductor"
        Me.cmbIntroductor.Size = New System.Drawing.Size(314, 21)
        Me.cmbIntroductor.TabIndex = 70
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Introductor/Cliente :"
        '
        'txtKilosEnviados
        '
        Me.txtKilosEnviados.Location = New System.Drawing.Point(161, 176)
        Me.txtKilosEnviados.Name = "txtKilosEnviados"
        Me.txtKilosEnviados.Size = New System.Drawing.Size(102, 20)
        Me.txtKilosEnviados.TabIndex = 61
        Me.txtKilosEnviados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Kilos Enviados :"
        '
        'txtCantCabezas
        '
        Me.txtCantCabezas.Enabled = False
        Me.txtCantCabezas.Location = New System.Drawing.Point(161, 150)
        Me.txtCantCabezas.Name = "txtCantCabezas"
        Me.txtCantCabezas.Size = New System.Drawing.Size(102, 20)
        Me.txtCantCabezas.TabIndex = 59
        Me.txtCantCabezas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 13)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "No. Total de Cab/Combos :"
        '
        'txtLoteEngorda
        '
        Me.txtLoteEngorda.Location = New System.Drawing.Point(161, 72)
        Me.txtLoteEngorda.Name = "txtLoteEngorda"
        Me.txtLoteEngorda.Size = New System.Drawing.Size(102, 20)
        Me.txtLoteEngorda.TabIndex = 57
        Me.txtLoteEngorda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LblReferenciaOLote
        '
        Me.LblReferenciaOLote.AutoSize = True
        Me.LblReferenciaOLote.Location = New System.Drawing.Point(12, 75)
        Me.LblReferenciaOLote.Name = "LblReferenciaOLote"
        Me.LblReferenciaOLote.Size = New System.Drawing.Size(144, 13)
        Me.LblReferenciaOLote.TabIndex = 56
        Me.LblReferenciaOLote.Text = "Lote de Engorda/embarque :"
        '
        'dtpFechaRecepcion
        '
        Me.dtpFechaRecepcion.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFechaRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaRecepcion.Location = New System.Drawing.Point(350, 15)
        Me.dtpFechaRecepcion.Name = "dtpFechaRecepcion"
        Me.dtpFechaRecepcion.Size = New System.Drawing.Size(92, 20)
        Me.dtpFechaRecepcion.TabIndex = 55
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(245, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Fecha  :"
        '
        'txtLoteRecepcion
        '
        Me.txtLoteRecepcion.Location = New System.Drawing.Point(161, 46)
        Me.txtLoteRecepcion.MaxLength = 10
        Me.txtLoteRecepcion.Name = "txtLoteRecepcion"
        Me.txtLoteRecepcion.Size = New System.Drawing.Size(102, 20)
        Me.txtLoteRecepcion.TabIndex = 32
        Me.txtLoteRecepcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Folio interno :"
        '
        'gb2dapesada
        '
        Me.gb2dapesada.Controls.Add(Me.txtKilos2daPasada)
        Me.gb2dapesada.Controls.Add(Me.Label2)
        Me.gb2dapesada.Controls.Add(Me.txtKilosRecibidos)
        Me.gb2dapesada.Controls.Add(Me.Label5)
        Me.gb2dapesada.Location = New System.Drawing.Point(277, 153)
        Me.gb2dapesada.Name = "gb2dapesada"
        Me.gb2dapesada.Size = New System.Drawing.Size(203, 79)
        Me.gb2dapesada.TabIndex = 92
        Me.gb2dapesada.TabStop = False
        Me.gb2dapesada.Text = "Kilos"
        '
        'txtKilos2daPasada
        '
        Me.txtKilos2daPasada.Location = New System.Drawing.Point(102, 53)
        Me.txtKilos2daPasada.Name = "txtKilos2daPasada"
        Me.txtKilos2daPasada.Size = New System.Drawing.Size(96, 20)
        Me.txtKilos2daPasada.TabIndex = 86
        Me.txtKilos2daPasada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "2da Pesada(tara) :"
        '
        'txtKilosRecibidos
        '
        Me.txtKilosRecibidos.Enabled = False
        Me.txtKilosRecibidos.Location = New System.Drawing.Point(102, 22)
        Me.txtKilosRecibidos.Name = "txtKilosRecibidos"
        Me.txtKilosRecibidos.Size = New System.Drawing.Size(96, 20)
        Me.txtKilosRecibidos.TabIndex = 84
        Me.txtKilosRecibidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Recibidos :"
        '
        'FrmRecepciondeGanado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 501)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmRecepciondeGanado"
        Me.Text = "Recepción de Animales a Sacrificio o en Pie / Materia Prima"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gb2dapesada.ResumeLayout(False)
        Me.gb2dapesada.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLoteRecepcion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaRecepcion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCantCabezas As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLoteEngorda As System.Windows.Forms.TextBox
    Friend WithEvents LblReferenciaOLote As System.Windows.Forms.Label
    Friend WithEvents txtKilosEnviados As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtConductor As System.Windows.Forms.TextBox
    Friend WithEvents txtUnidad As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbIntroductor As System.Windows.Forms.ComboBox
    Friend WithEvents txtPlacas As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents chkMaquila As System.Windows.Forms.CheckBox
    Friend WithEvents ChkMultiples As System.Windows.Forms.CheckBox
    Friend WithEvents SerialPort As System.IO.Ports.SerialPort
    Friend WithEvents txtKilos1erpasada As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CmbTipoGanado As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtCabezasHembra As Integralab.Controles.TextBoxMejorado
    Friend WithEvents txtCabezasMachos As Integralab.Controles.TextBoxMejorado
    Friend WithEvents chkBascula As System.Windows.Forms.CheckBox
    Friend WithEvents txtLeerPeso As wclTextBoxSerial.TextBoxSerial
    Friend WithEvents gb2dapesada As System.Windows.Forms.GroupBox
    Friend WithEvents txtKilos2daPasada As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtKilosRecibidos As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
