<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmComprasGanado
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label4 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtHorasViaje = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.chkImpuestoPredial = New System.Windows.Forms.CheckBox
        Me.chkImpuestoEducacion = New System.Windows.Forms.CheckBox
        Me.rbtKilo = New System.Windows.Forms.RadioButton
        Me.rbtCabeza = New System.Windows.Forms.RadioButton
        Me.txtImporteEducacion = New System.Windows.Forms.TextBox
        Me.txtComision = New System.Windows.Forms.TextBox
        Me.txtImportePredial = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.txtGastosTransporte = New System.Windows.Forms.TextBox
        Me.txtGuiaTransito = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.txtImporteTotal = New System.Windows.Forms.TextBox
        Me.txtAdquisicion = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.txtImporteGuia = New System.Windows.Forms.TextBox
        Me.txtNoGuia = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtPorcentajeMerma = New System.Windows.Forms.TextBox
        Me.txtKilosMerma = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtKilosRecibidos = New System.Windows.Forms.TextBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label31 = New System.Windows.Forms.Label
        Me.dgvTiposdeGanado = New System.Windows.Forms.DataGridView
        Me.TipoGanadoC = New ClasesNegocio.TipoGanadoColecttionClass
        Me.ComprasGanadoDetalleC = New ClasesNegocio.ComprasGanadoDetalleCollectionClass
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.DgvConceptoGastos = New System.Windows.Forms.DataGridView
        Me.ConceptoGastoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.ConceptoGastoC = New ClasesNegocio.ConceptoGastosTransporteColeccionClass
        Me.PorcentajeIvaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ImporteGastoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DetGasTransC = New ClasesNegocio.GastoTransporteDetalleCollectionClass
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtSubTotal = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtIVA = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.TxtFolio = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.CmbCamion = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.cmbChofer = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.dtpFechaPago = New System.Windows.Forms.DateTimePicker
        Me.txtNoCuenta = New System.Windows.Forms.TextBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.txtSucursal = New System.Windows.Forms.TextBox
        Me.txtBanco = New System.Windows.Forms.TextBox
        Me.txtNoFactura = New System.Windows.Forms.TextBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.txtDiasDeCredito = New System.Windows.Forms.TextBox
        Me.txtCantCabezas = New System.Windows.Forms.TextBox
        Me.CmbLugarCompra = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.cmbComprador = New System.Windows.Forms.ComboBox
        Me.CompradoresGanadoC = New ClasesNegocio.CompradorGanadoCollectionClass
        Me.cmbCorral = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtKilosComprados = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtObservaciones = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbProveedor = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtFolioCompra = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridViewComboBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.IdTipoGanadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.CantKilosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KilosRecibidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrecioXKiloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantCabezasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KilosPromXCabezaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostoPromXCabezaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MovimeintoGanadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FolioMovimeintoGanadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaMovimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EntidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SeleccionadoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ContenedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IndiceEnContenedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EncabezadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FolioDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CompraGanadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdRenglonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionTipoGanadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoGanadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvTiposdeGanado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgvConceptoGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(50, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(883, 32)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Compras de Ganado"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.mtb.Size = New System.Drawing.Size(50, 681)
        Me.mtb.TabIndex = 47
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtHorasViaje)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.txtKilosRecibidos)
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Controls.Add(Me.txtCantCabezas)
        Me.GroupBox1.Controls.Add(Me.CmbLugarCompra)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblEstatus)
        Me.GroupBox1.Controls.Add(Me.cmbComprador)
        Me.GroupBox1.Controls.Add(Me.cmbCorral)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtKilosComprados)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbProveedor)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtFolioCompra)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(60, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(861, 631)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtHorasViaje
        '
        Me.txtHorasViaje.Location = New System.Drawing.Point(768, 223)
        Me.txtHorasViaje.Name = "txtHorasViaje"
        Me.txtHorasViaje.ReadOnly = True
        Me.txtHorasViaje.Size = New System.Drawing.Size(63, 20)
        Me.txtHorasViaje.TabIndex = 68
        Me.txtHorasViaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(768, 207)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "Horas Viaje"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.chkImpuestoPredial)
        Me.GroupBox2.Controls.Add(Me.chkImpuestoEducacion)
        Me.GroupBox2.Controls.Add(Me.rbtKilo)
        Me.GroupBox2.Controls.Add(Me.rbtCabeza)
        Me.GroupBox2.Controls.Add(Me.txtImporteEducacion)
        Me.GroupBox2.Controls.Add(Me.txtComision)
        Me.GroupBox2.Controls.Add(Me.txtImportePredial)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.txtGastosTransporte)
        Me.GroupBox2.Controls.Add(Me.txtGuiaTransito)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.txtImporteTotal)
        Me.GroupBox2.Controls.Add(Me.txtAdquisicion)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Location = New System.Drawing.Point(439, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(254, 224)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gastos"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 43)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(71, 13)
        Me.Label21.TabIndex = 27
        Me.Label21.Text = "Comisión Por:"
        '
        'chkImpuestoPredial
        '
        Me.chkImpuestoPredial.AutoSize = True
        Me.chkImpuestoPredial.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkImpuestoPredial.Location = New System.Drawing.Point(6, 118)
        Me.chkImpuestoPredial.Name = "chkImpuestoPredial"
        Me.chkImpuestoPredial.Size = New System.Drawing.Size(107, 17)
        Me.chkImpuestoPredial.TabIndex = 26
        Me.chkImpuestoPredial.Text = "Impuesto Predial:"
        Me.chkImpuestoPredial.UseVisualStyleBackColor = True
        '
        'chkImpuestoEducacion
        '
        Me.chkImpuestoEducacion.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkImpuestoEducacion.Location = New System.Drawing.Point(6, 137)
        Me.chkImpuestoEducacion.Name = "chkImpuestoEducacion"
        Me.chkImpuestoEducacion.Size = New System.Drawing.Size(107, 33)
        Me.chkImpuestoEducacion.TabIndex = 25
        Me.chkImpuestoEducacion.Text = "Impuesto a la Educación:"
        Me.chkImpuestoEducacion.UseVisualStyleBackColor = True
        '
        'rbtKilo
        '
        Me.rbtKilo.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rbtKilo.Enabled = False
        Me.rbtKilo.Location = New System.Drawing.Point(73, 58)
        Me.rbtKilo.Name = "rbtKilo"
        Me.rbtKilo.Size = New System.Drawing.Size(42, 31)
        Me.rbtKilo.TabIndex = 14
        Me.rbtKilo.TabStop = True
        Me.rbtKilo.Text = "Kilo"
        Me.rbtKilo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rbtKilo.UseVisualStyleBackColor = True
        '
        'rbtCabeza
        '
        Me.rbtCabeza.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rbtCabeza.Enabled = False
        Me.rbtCabeza.Location = New System.Drawing.Point(6, 58)
        Me.rbtCabeza.Name = "rbtCabeza"
        Me.rbtCabeza.Size = New System.Drawing.Size(61, 31)
        Me.rbtCabeza.TabIndex = 13
        Me.rbtCabeza.TabStop = True
        Me.rbtCabeza.Text = "Cabeza"
        Me.rbtCabeza.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rbtCabeza.UseVisualStyleBackColor = True
        '
        'txtImporteEducacion
        '
        Me.txtImporteEducacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtImporteEducacion.Location = New System.Drawing.Point(121, 143)
        Me.txtImporteEducacion.Name = "txtImporteEducacion"
        Me.txtImporteEducacion.ReadOnly = True
        Me.txtImporteEducacion.Size = New System.Drawing.Size(127, 20)
        Me.txtImporteEducacion.TabIndex = 7
        Me.txtImporteEducacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtComision
        '
        Me.txtComision.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComision.Location = New System.Drawing.Point(121, 53)
        Me.txtComision.Name = "txtComision"
        Me.txtComision.ReadOnly = True
        Me.txtComision.Size = New System.Drawing.Size(127, 20)
        Me.txtComision.TabIndex = 0
        Me.txtComision.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtImportePredial
        '
        Me.txtImportePredial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtImportePredial.Location = New System.Drawing.Point(121, 116)
        Me.txtImportePredial.Name = "txtImportePredial"
        Me.txtImportePredial.ReadOnly = True
        Me.txtImportePredial.Size = New System.Drawing.Size(127, 20)
        Me.txtImportePredial.TabIndex = 3
        Me.txtImportePredial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(6, 173)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(107, 13)
        Me.Label29.TabIndex = 20
        Me.Label29.Text = "Gasto de Transporte:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(6, 199)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(45, 13)
        Me.Label30.TabIndex = 19
        Me.Label30.Text = "Importe:"
        '
        'txtGastosTransporte
        '
        Me.txtGastosTransporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGastosTransporte.Location = New System.Drawing.Point(121, 169)
        Me.txtGastosTransporte.Name = "txtGastosTransporte"
        Me.txtGastosTransporte.ReadOnly = True
        Me.txtGastosTransporte.Size = New System.Drawing.Size(127, 20)
        Me.txtGastosTransporte.TabIndex = 5
        Me.txtGastosTransporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtGuiaTransito
        '
        Me.txtGuiaTransito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGuiaTransito.Location = New System.Drawing.Point(121, 90)
        Me.txtGuiaTransito.Name = "txtGuiaTransito"
        Me.txtGuiaTransito.ReadOnly = True
        Me.txtGuiaTransito.Size = New System.Drawing.Size(127, 20)
        Me.txtGuiaTransito.TabIndex = 6
        Me.txtGuiaTransito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(6, 94)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(73, 13)
        Me.Label25.TabIndex = 9
        Me.Label25.Text = "Guia Transito:"
        '
        'txtImporteTotal
        '
        Me.txtImporteTotal.Location = New System.Drawing.Point(121, 195)
        Me.txtImporteTotal.Name = "txtImporteTotal"
        Me.txtImporteTotal.ReadOnly = True
        Me.txtImporteTotal.Size = New System.Drawing.Size(127, 20)
        Me.txtImporteTotal.TabIndex = 4
        Me.txtImporteTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAdquisicion
        '
        Me.txtAdquisicion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAdquisicion.Location = New System.Drawing.Point(121, 19)
        Me.txtAdquisicion.Name = "txtAdquisicion"
        Me.txtAdquisicion.ReadOnly = True
        Me.txtAdquisicion.Size = New System.Drawing.Size(127, 20)
        Me.txtAdquisicion.TabIndex = 2
        Me.txtAdquisicion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(6, 23)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(64, 13)
        Me.Label28.TabIndex = 8
        Me.Label28.Text = "Adquisición:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(208, 156)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(113, 13)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Peso Entrada a Corral:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtImporteGuia)
        Me.GroupBox5.Controls.Add(Me.txtNoGuia)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Location = New System.Drawing.Point(699, 122)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(156, 82)
        Me.GroupBox5.TabIndex = 8
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Guia Transporte"
        '
        'txtImporteGuia
        '
        Me.txtImporteGuia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtImporteGuia.Location = New System.Drawing.Point(69, 47)
        Me.txtImporteGuia.Name = "txtImporteGuia"
        Me.txtImporteGuia.Size = New System.Drawing.Size(77, 20)
        Me.txtImporteGuia.TabIndex = 1
        Me.txtImporteGuia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNoGuia
        '
        Me.txtNoGuia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNoGuia.Location = New System.Drawing.Point(69, 21)
        Me.txtNoGuia.Name = "txtNoGuia"
        Me.txtNoGuia.Size = New System.Drawing.Size(77, 20)
        Me.txtNoGuia.TabIndex = 0
        Me.txtNoGuia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(6, 43)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 31)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "Importe Por Guia:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 24)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(37, 13)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Guias:"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(700, 207)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Cabezas"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtPorcentajeMerma)
        Me.GroupBox4.Controls.Add(Me.txtKilosMerma)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Location = New System.Drawing.Point(699, 42)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(156, 74)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Merma en "
        '
        'txtPorcentajeMerma
        '
        Me.txtPorcentajeMerma.Location = New System.Drawing.Point(47, 44)
        Me.txtPorcentajeMerma.Name = "txtPorcentajeMerma"
        Me.txtPorcentajeMerma.ReadOnly = True
        Me.txtPorcentajeMerma.Size = New System.Drawing.Size(87, 20)
        Me.txtPorcentajeMerma.TabIndex = 1
        Me.txtPorcentajeMerma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtKilosMerma
        '
        Me.txtKilosMerma.Location = New System.Drawing.Point(47, 19)
        Me.txtKilosMerma.Name = "txtKilosMerma"
        Me.txtKilosMerma.ReadOnly = True
        Me.txtKilosMerma.Size = New System.Drawing.Size(87, 20)
        Me.txtKilosMerma.TabIndex = 0
        Me.txtKilosMerma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 45)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(21, 13)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "% :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 13)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Kilos :"
        '
        'txtKilosRecibidos
        '
        Me.txtKilosRecibidos.Location = New System.Drawing.Point(327, 152)
        Me.txtKilosRecibidos.Name = "txtKilosRecibidos"
        Me.txtKilosRecibidos.Size = New System.Drawing.Size(106, 20)
        Me.txtKilosRecibidos.TabIndex = 14
        Me.txtKilosRecibidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(6, 252)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(849, 373)
        Me.TabControl1.TabIndex = 11
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label31)
        Me.TabPage1.Controls.Add(Me.dgvTiposdeGanado)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(841, 347)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Animales"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(6, 331)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(447, 13)
        Me.Label31.TabIndex = 69
        Me.Label31.Text = "De click en el listado de animales y precione F12 para actualizar el listado de t" & _
            "ipos de ganado"
        '
        'dgvTiposdeGanado
        '
        Me.dgvTiposdeGanado.AllowUserToDeleteRows = False
        Me.dgvTiposdeGanado.AllowUserToResizeRows = False
        Me.dgvTiposdeGanado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTiposdeGanado.AutoGenerateColumns = False
        Me.dgvTiposdeGanado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTiposdeGanado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdTipoGanadoDataGridViewTextBoxColumn, Me.CantKilosDataGridViewTextBoxColumn, Me.KilosRecibidosDataGridViewTextBoxColumn, Me.PrecioXKiloDataGridViewTextBoxColumn, Me.CantCabezasDataGridViewTextBoxColumn, Me.KilosPromXCabezaDataGridViewTextBoxColumn, Me.CostoPromXCabezaDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn, Me.MovimeintoGanadoDataGridViewTextBoxColumn, Me.FolioMovimeintoGanadoDataGridViewTextBoxColumn, Me.FechaMovimientoDataGridViewTextBoxColumn, Me.EntidadDataGridViewTextBoxColumn, Me.SeleccionadoDataGridViewCheckBoxColumn, Me.ContenedorDataGridViewTextBoxColumn, Me.IndiceEnContenedorDataGridViewTextBoxColumn, Me.EncabezadoDataGridViewTextBoxColumn, Me.FolioDataGridViewTextBoxColumn1, Me.CompraGanadoDataGridViewTextBoxColumn, Me.IdRenglonDataGridViewTextBoxColumn, Me.DescripcionTipoGanadoDataGridViewTextBoxColumn, Me.TipoGanadoDataGridViewTextBoxColumn})
        Me.dgvTiposdeGanado.DataSource = Me.ComprasGanadoDetalleC
        Me.dgvTiposdeGanado.Location = New System.Drawing.Point(6, 6)
        Me.dgvTiposdeGanado.MultiSelect = False
        Me.dgvTiposdeGanado.Name = "dgvTiposdeGanado"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTiposdeGanado.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvTiposdeGanado.RowHeadersVisible = False
        Me.dgvTiposdeGanado.Size = New System.Drawing.Size(829, 322)
        Me.dgvTiposdeGanado.TabIndex = 0
        Me.dgvTiposdeGanado.VirtualMode = True
        '
        'TipoGanadoC
        '
        Me.TipoGanadoC.AllowEdit = True
        Me.TipoGanadoC.AllowNew = True
        Me.TipoGanadoC.AllowRemove = True
        Me.TipoGanadoC.MaximoElementosSeleccionados = 1
        Me.TipoGanadoC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.TipoGanadoC.MostrarAlertas = False
        Me.TipoGanadoC.Name = ""
        Me.TipoGanadoC.RaiseListChangedEvents = True
        Me.TipoGanadoC.Transaction = Nothing
        '
        'ComprasGanadoDetalleC
        '
        Me.ComprasGanadoDetalleC.AllowEdit = True
        Me.ComprasGanadoDetalleC.AllowNew = True
        Me.ComprasGanadoDetalleC.AllowRemove = True
        Me.ComprasGanadoDetalleC.MaximoElementosSeleccionados = 1
        Me.ComprasGanadoDetalleC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.ComprasGanadoDetalleC.MostrarAlertas = False
        Me.ComprasGanadoDetalleC.Name = Nothing
        Me.ComprasGanadoDetalleC.RaiseListChangedEvents = True
        Me.ComprasGanadoDetalleC.Transaction = Nothing
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.TxtFolio)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.CmbCamion)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.cmbChofer)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(841, 347)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Gastos de Transporte"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.DgvConceptoGastos)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.txtSubTotal)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.txtIVA)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.txtTotal)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 62)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(829, 279)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Gastos de Transporte"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(6, 260)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(525, 13)
        Me.Label32.TabIndex = 70
        Me.Label32.Text = "De click en el listado de gastos de transporte y precione F12 para actualizar el " & _
            "listado de conceptos de gastos"
        '
        'DgvConceptoGastos
        '
        Me.DgvConceptoGastos.AllowUserToDeleteRows = False
        Me.DgvConceptoGastos.AllowUserToResizeRows = False
        Me.DgvConceptoGastos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvConceptoGastos.AutoGenerateColumns = False
        Me.DgvConceptoGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvConceptoGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ConceptoGastoDataGridViewTextBoxColumn, Me.PorcentajeIvaDataGridViewTextBoxColumn, Me.ImporteGastoDataGridViewTextBoxColumn})
        Me.DgvConceptoGastos.DataSource = Me.DetGasTransC
        Me.DgvConceptoGastos.Location = New System.Drawing.Point(6, 19)
        Me.DgvConceptoGastos.MultiSelect = False
        Me.DgvConceptoGastos.Name = "DgvConceptoGastos"
        Me.DgvConceptoGastos.RowHeadersVisible = False
        Me.DgvConceptoGastos.Size = New System.Drawing.Size(817, 184)
        Me.DgvConceptoGastos.TabIndex = 8
        '
        'ConceptoGastoDataGridViewTextBoxColumn
        '
        Me.ConceptoGastoDataGridViewTextBoxColumn.DataPropertyName = "IdGasto"
        Me.ConceptoGastoDataGridViewTextBoxColumn.DataSource = Me.ConceptoGastoC
        Me.ConceptoGastoDataGridViewTextBoxColumn.DisplayMember = "Descripcion"
        Me.ConceptoGastoDataGridViewTextBoxColumn.HeaderText = "ConceptoGasto"
        Me.ConceptoGastoDataGridViewTextBoxColumn.Name = "ConceptoGastoDataGridViewTextBoxColumn"
        Me.ConceptoGastoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ConceptoGastoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ConceptoGastoDataGridViewTextBoxColumn.ValueMember = "IdConceptoGasto"
        Me.ConceptoGastoDataGridViewTextBoxColumn.Width = 450
        '
        'ConceptoGastoC
        '
        Me.ConceptoGastoC.AllowEdit = True
        Me.ConceptoGastoC.AllowNew = True
        Me.ConceptoGastoC.AllowRemove = True
        Me.ConceptoGastoC.MaximoElementosSeleccionados = 1
        Me.ConceptoGastoC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.ConceptoGastoC.MostrarAlertas = False
        Me.ConceptoGastoC.Name = ""
        Me.ConceptoGastoC.RaiseListChangedEvents = True
        Me.ConceptoGastoC.Transaction = Nothing
        '
        'PorcentajeIvaDataGridViewTextBoxColumn
        '
        Me.PorcentajeIvaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.PorcentajeIvaDataGridViewTextBoxColumn.DataPropertyName = "PorcentajeIva"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = "0.0"
        Me.PorcentajeIvaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.PorcentajeIvaDataGridViewTextBoxColumn.HeaderText = "Iva %"
        Me.PorcentajeIvaDataGridViewTextBoxColumn.Name = "PorcentajeIvaDataGridViewTextBoxColumn"
        Me.PorcentajeIvaDataGridViewTextBoxColumn.Width = 56
        '
        'ImporteGastoDataGridViewTextBoxColumn
        '
        Me.ImporteGastoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ImporteGastoDataGridViewTextBoxColumn.DataPropertyName = "ImporteGasto"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "C4"
        DataGridViewCellStyle10.NullValue = "0.0"
        Me.ImporteGastoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.ImporteGastoDataGridViewTextBoxColumn.HeaderText = "Importe Gasto"
        Me.ImporteGastoDataGridViewTextBoxColumn.Name = "ImporteGastoDataGridViewTextBoxColumn"
        Me.ImporteGastoDataGridViewTextBoxColumn.Width = 96
        '
        'DetGasTransC
        '
        Me.DetGasTransC.AllowEdit = True
        Me.DetGasTransC.AllowNew = True
        Me.DetGasTransC.AllowRemove = True
        Me.DetGasTransC.MaximoElementosSeleccionados = 1
        Me.DetGasTransC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.DetGasTransC.MostrarAlertas = False
        Me.DetGasTransC.Name = Nothing
        Me.DetGasTransC.RaiseListChangedEvents = True
        Me.DetGasTransC.Transaction = Nothing
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(627, 256)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(34, 13)
        Me.Label24.TabIndex = 14
        Me.Label24.Text = "Total:"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.AcceptsTab = True
        Me.txtSubTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSubTotal.Enabled = False
        Me.txtSubTotal.Location = New System.Drawing.Point(671, 209)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(152, 20)
        Me.txtSubTotal.TabIndex = 9
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(634, 234)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(27, 13)
        Me.Label23.TabIndex = 13
        Me.Label23.Text = "IVA:"
        '
        'txtIVA
        '
        Me.txtIVA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIVA.Enabled = False
        Me.txtIVA.Location = New System.Drawing.Point(671, 231)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.ReadOnly = True
        Me.txtIVA.Size = New System.Drawing.Size(152, 20)
        Me.txtIVA.TabIndex = 10
        Me.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(605, 212)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(56, 13)
        Me.Label22.TabIndex = 12
        Me.Label22.Text = "Sub Total:"
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(671, 253)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(152, 20)
        Me.txtTotal.TabIndex = 11
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtFolio
        '
        Me.TxtFolio.Enabled = False
        Me.TxtFolio.Location = New System.Drawing.Point(53, 9)
        Me.TxtFolio.Name = "TxtFolio"
        Me.TxtFolio.Size = New System.Drawing.Size(102, 20)
        Me.TxtFolio.TabIndex = 6
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 12)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(32, 13)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "Folio:"
        '
        'CmbCamion
        '
        Me.CmbCamion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCamion.FormattingEnabled = True
        Me.CmbCamion.Location = New System.Drawing.Point(377, 35)
        Me.CmbCamion.Name = "CmbCamion"
        Me.CmbCamion.Size = New System.Drawing.Size(271, 21)
        Me.CmbCamion.TabIndex = 3
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(330, 38)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(45, 13)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Camión:"
        '
        'cmbChofer
        '
        Me.cmbChofer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbChofer.FormattingEnabled = True
        Me.cmbChofer.Location = New System.Drawing.Point(53, 35)
        Me.cmbChofer.Name = "cmbChofer"
        Me.cmbChofer.Size = New System.Drawing.Size(271, 21)
        Me.cmbChofer.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 38)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Chofer:"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dtpFechaPago)
        Me.TabPage3.Controls.Add(Me.txtNoCuenta)
        Me.TabPage3.Controls.Add(Me.Label34)
        Me.TabPage3.Controls.Add(Me.Label35)
        Me.TabPage3.Controls.Add(Me.Label36)
        Me.TabPage3.Controls.Add(Me.txtSucursal)
        Me.TabPage3.Controls.Add(Me.txtBanco)
        Me.TabPage3.Controls.Add(Me.txtNoFactura)
        Me.TabPage3.Controls.Add(Me.Label33)
        Me.TabPage3.Controls.Add(Me.Label27)
        Me.TabPage3.Controls.Add(Me.Label26)
        Me.TabPage3.Controls.Add(Me.txtDiasDeCredito)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(841, 347)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Otos Datos"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dtpFechaPago
        '
        Me.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaPago.Location = New System.Drawing.Point(103, 32)
        Me.dtpFechaPago.Name = "dtpFechaPago"
        Me.dtpFechaPago.Size = New System.Drawing.Size(105, 20)
        Me.dtpFechaPago.TabIndex = 25
        '
        'txtNoCuenta
        '
        Me.txtNoCuenta.Location = New System.Drawing.Point(103, 136)
        Me.txtNoCuenta.Name = "txtNoCuenta"
        Me.txtNoCuenta.Size = New System.Drawing.Size(340, 20)
        Me.txtNoCuenta.TabIndex = 24
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(10, 140)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(87, 13)
        Me.Label34.TabIndex = 23
        Me.Label34.Text = "Num. de Cuenta:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(10, 114)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(51, 13)
        Me.Label35.TabIndex = 22
        Me.Label35.Text = "Sucursal:"
        Me.Label35.Visible = False
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(10, 88)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(41, 13)
        Me.Label36.TabIndex = 21
        Me.Label36.Text = "Banco:"
        '
        'txtSucursal
        '
        Me.txtSucursal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSucursal.Location = New System.Drawing.Point(103, 110)
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.Size = New System.Drawing.Size(340, 20)
        Me.txtSucursal.TabIndex = 20
        Me.txtSucursal.Visible = False
        '
        'txtBanco
        '
        Me.txtBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBanco.Location = New System.Drawing.Point(103, 84)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(340, 20)
        Me.txtBanco.TabIndex = 19
        '
        'txtNoFactura
        '
        Me.txtNoFactura.Location = New System.Drawing.Point(103, 58)
        Me.txtNoFactura.Name = "txtNoFactura"
        Me.txtNoFactura.Size = New System.Drawing.Size(105, 20)
        Me.txtNoFactura.TabIndex = 18
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(10, 62)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(89, 13)
        Me.Label33.TabIndex = 17
        Me.Label33.Text = "Num. de Factura:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(10, 36)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(85, 13)
        Me.Label27.TabIndex = 16
        Me.Label27.Text = "Fecha del Pago:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(10, 10)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(84, 13)
        Me.Label26.TabIndex = 15
        Me.Label26.Text = "Dias De Crédito:"
        '
        'txtDiasDeCredito
        '
        Me.txtDiasDeCredito.Enabled = False
        Me.txtDiasDeCredito.Location = New System.Drawing.Point(103, 6)
        Me.txtDiasDeCredito.Name = "txtDiasDeCredito"
        Me.txtDiasDeCredito.Size = New System.Drawing.Size(105, 20)
        Me.txtDiasDeCredito.TabIndex = 13
        '
        'txtCantCabezas
        '
        Me.txtCantCabezas.Location = New System.Drawing.Point(699, 223)
        Me.txtCantCabezas.Name = "txtCantCabezas"
        Me.txtCantCabezas.ReadOnly = True
        Me.txtCantCabezas.Size = New System.Drawing.Size(63, 20)
        Me.txtCantCabezas.TabIndex = 11
        Me.txtCantCabezas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CmbLugarCompra
        '
        Me.CmbLugarCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbLugarCompra.FormattingEnabled = True
        Me.CmbLugarCompra.Location = New System.Drawing.Point(122, 71)
        Me.CmbLugarCompra.Name = "CmbLugarCompra"
        Me.CmbLugarCompra.Size = New System.Drawing.Size(311, 21)
        Me.CmbLugarCompra.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Lugar de Compra:"
        '
        'lblEstatus
        '
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblEstatus.Location = New System.Drawing.Point(699, 11)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(156, 24)
        Me.lblEstatus.TabIndex = 65
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbComprador
        '
        Me.cmbComprador.DataSource = Me.CompradoresGanadoC
        Me.cmbComprador.DisplayMember = "NomCompleto"
        Me.cmbComprador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbComprador.FormattingEnabled = True
        Me.cmbComprador.Location = New System.Drawing.Point(122, 98)
        Me.cmbComprador.Name = "cmbComprador"
        Me.cmbComprador.Size = New System.Drawing.Size(311, 21)
        Me.cmbComprador.TabIndex = 2
        Me.cmbComprador.ValueMember = "IdComprador"
        '
        'CompradoresGanadoC
        '
        Me.CompradoresGanadoC.AllowEdit = True
        Me.CompradoresGanadoC.AllowNew = True
        Me.CompradoresGanadoC.AllowRemove = True
        Me.CompradoresGanadoC.MaximoElementosSeleccionados = 1
        Me.CompradoresGanadoC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.CompradoresGanadoC.MostrarAlertas = False
        Me.CompradoresGanadoC.Name = ""
        Me.CompradoresGanadoC.RaiseListChangedEvents = True
        Me.CompradoresGanadoC.Transaction = Nothing
        '
        'cmbCorral
        '
        Me.cmbCorral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCorral.FormattingEnabled = True
        Me.cmbCorral.Location = New System.Drawing.Point(122, 125)
        Me.cmbCorral.Name = "cmbCorral"
        Me.cmbCorral.Size = New System.Drawing.Size(311, 21)
        Me.cmbCorral.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 128)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 13)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Corral de Recepción :"
        '
        'txtKilosComprados
        '
        Me.txtKilosComprados.Location = New System.Drawing.Point(122, 152)
        Me.txtKilosComprados.Name = "txtKilosComprados"
        Me.txtKilosComprados.ReadOnly = True
        Me.txtKilosComprados.Size = New System.Drawing.Size(80, 20)
        Me.txtKilosComprados.TabIndex = 4
        Me.txtKilosComprados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 101)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Comprador :"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Location = New System.Drawing.Point(122, 178)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(311, 70)
        Me.txtObservaciones.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Kilos Comprados :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 181)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Observaciones :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 9
        '
        'cmbProveedor
        '
        Me.cmbProveedor.DisplayMember = "RazonSocial"
        Me.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(122, 44)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(311, 21)
        Me.cmbProveedor.TabIndex = 1
        Me.cmbProveedor.ValueMember = "Codigo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Proveedor :"
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "dd/MMM/yyyy"
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(342, 17)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(91, 20)
        Me.dtpFecha.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(254, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha Compra :"
        '
        'txtFolioCompra
        '
        Me.txtFolioCompra.Enabled = False
        Me.txtFolioCompra.Location = New System.Drawing.Point(122, 18)
        Me.txtFolioCompra.Name = "txtFolioCompra"
        Me.txtFolioCompra.ReadOnly = True
        Me.txtFolioCompra.Size = New System.Drawing.Size(80, 20)
        Me.txtFolioCompra.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Folio Compra :"
        '
        'DataGridViewComboBoxColumn1
        '
        Me.DataGridViewComboBoxColumn1.DataPropertyName = "IdTipoGanado"
        Me.DataGridViewComboBoxColumn1.HeaderText = "Tipos de Ganado"
        Me.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1"
        Me.DataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewComboBoxColumn1.Width = 200
        '
        'IdTipoGanadoDataGridViewTextBoxColumn
        '
        Me.IdTipoGanadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.IdTipoGanadoDataGridViewTextBoxColumn.DataPropertyName = "IdTipoGanado"
        Me.IdTipoGanadoDataGridViewTextBoxColumn.DataSource = Me.TipoGanadoC
        Me.IdTipoGanadoDataGridViewTextBoxColumn.DisplayMember = "Descripcion"
        Me.IdTipoGanadoDataGridViewTextBoxColumn.HeaderText = "Tipo Ganado"
        Me.IdTipoGanadoDataGridViewTextBoxColumn.Name = "IdTipoGanadoDataGridViewTextBoxColumn"
        Me.IdTipoGanadoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IdTipoGanadoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.IdTipoGanadoDataGridViewTextBoxColumn.ValueMember = "IdTipoGanado"
        Me.IdTipoGanadoDataGridViewTextBoxColumn.Width = 92
        '
        'CantKilosDataGridViewTextBoxColumn
        '
        Me.CantKilosDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CantKilosDataGridViewTextBoxColumn.DataPropertyName = "CantKilos"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N3"
        DataGridViewCellStyle1.NullValue = "0.0"
        Me.CantKilosDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.CantKilosDataGridViewTextBoxColumn.HeaderText = "Kilos Comprados"
        Me.CantKilosDataGridViewTextBoxColumn.Name = "CantKilosDataGridViewTextBoxColumn"
        Me.CantKilosDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantKilosDataGridViewTextBoxColumn.Width = 99
        '
        'KilosRecibidosDataGridViewTextBoxColumn
        '
        Me.KilosRecibidosDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.KilosRecibidosDataGridViewTextBoxColumn.DataPropertyName = "KilosRecibidos"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N3"
        DataGridViewCellStyle2.NullValue = "0.0"
        Me.KilosRecibidosDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.KilosRecibidosDataGridViewTextBoxColumn.HeaderText = "Kilos Recibidos"
        Me.KilosRecibidosDataGridViewTextBoxColumn.Name = "KilosRecibidosDataGridViewTextBoxColumn"
        Me.KilosRecibidosDataGridViewTextBoxColumn.Visible = False
        Me.KilosRecibidosDataGridViewTextBoxColumn.Width = 94
        '
        'PrecioXKiloDataGridViewTextBoxColumn
        '
        Me.PrecioXKiloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.PrecioXKiloDataGridViewTextBoxColumn.DataPropertyName = "PrecioXKilo"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = "0.0"
        Me.PrecioXKiloDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.PrecioXKiloDataGridViewTextBoxColumn.HeaderText = "Costo X Kilo"
        Me.PrecioXKiloDataGridViewTextBoxColumn.Name = "PrecioXKiloDataGridViewTextBoxColumn"
        Me.PrecioXKiloDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioXKiloDataGridViewTextBoxColumn.Width = 65
        '
        'CantCabezasDataGridViewTextBoxColumn
        '
        Me.CantCabezasDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CantCabezasDataGridViewTextBoxColumn.DataPropertyName = "CantCabezas"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = "0"
        Me.CantCabezasDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.CantCabezasDataGridViewTextBoxColumn.HeaderText = "Cabezas"
        Me.CantCabezasDataGridViewTextBoxColumn.Name = "CantCabezasDataGridViewTextBoxColumn"
        Me.CantCabezasDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantCabezasDataGridViewTextBoxColumn.Width = 71
        '
        'KilosPromXCabezaDataGridViewTextBoxColumn
        '
        Me.KilosPromXCabezaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.KilosPromXCabezaDataGridViewTextBoxColumn.DataPropertyName = "KilosPromXCabeza"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N3"
        DataGridViewCellStyle5.NullValue = "0.0"
        Me.KilosPromXCabezaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.KilosPromXCabezaDataGridViewTextBoxColumn.HeaderText = "Kilos Promedio X Cabeza"
        Me.KilosPromXCabezaDataGridViewTextBoxColumn.Name = "KilosPromXCabezaDataGridViewTextBoxColumn"
        Me.KilosPromXCabezaDataGridViewTextBoxColumn.ReadOnly = True
        Me.KilosPromXCabezaDataGridViewTextBoxColumn.Width = 103
        '
        'CostoPromXCabezaDataGridViewTextBoxColumn
        '
        Me.CostoPromXCabezaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CostoPromXCabezaDataGridViewTextBoxColumn.DataPropertyName = "CostoPromXCabeza"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = "0.0"
        Me.CostoPromXCabezaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.CostoPromXCabezaDataGridViewTextBoxColumn.HeaderText = "Costo Promedio X Cabeza"
        Me.CostoPromXCabezaDataGridViewTextBoxColumn.Name = "CostoPromXCabezaDataGridViewTextBoxColumn"
        Me.CostoPromXCabezaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CostoPromXCabezaDataGridViewTextBoxColumn.Width = 107
        '
        'ImporteDataGridViewTextBoxColumn
        '
        Me.ImporteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "Importe"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = "0.0"
        Me.ImporteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
        Me.ImporteDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImporteDataGridViewTextBoxColumn.Width = 65
        '
        'MovimeintoGanadoDataGridViewTextBoxColumn
        '
        Me.MovimeintoGanadoDataGridViewTextBoxColumn.DataPropertyName = "MovimeintoGanado"
        Me.MovimeintoGanadoDataGridViewTextBoxColumn.HeaderText = "MovimeintoGanado"
        Me.MovimeintoGanadoDataGridViewTextBoxColumn.Name = "MovimeintoGanadoDataGridViewTextBoxColumn"
        Me.MovimeintoGanadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.MovimeintoGanadoDataGridViewTextBoxColumn.Visible = False
        '
        'FolioMovimeintoGanadoDataGridViewTextBoxColumn
        '
        Me.FolioMovimeintoGanadoDataGridViewTextBoxColumn.DataPropertyName = "FolioMovimeintoGanado"
        Me.FolioMovimeintoGanadoDataGridViewTextBoxColumn.HeaderText = "FolioMovimeintoGanado"
        Me.FolioMovimeintoGanadoDataGridViewTextBoxColumn.Name = "FolioMovimeintoGanadoDataGridViewTextBoxColumn"
        Me.FolioMovimeintoGanadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FolioMovimeintoGanadoDataGridViewTextBoxColumn.Visible = False
        '
        'FechaMovimientoDataGridViewTextBoxColumn
        '
        Me.FechaMovimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaMovimiento"
        Me.FechaMovimientoDataGridViewTextBoxColumn.HeaderText = "FechaMovimiento"
        Me.FechaMovimientoDataGridViewTextBoxColumn.Name = "FechaMovimientoDataGridViewTextBoxColumn"
        Me.FechaMovimientoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaMovimientoDataGridViewTextBoxColumn.Visible = False
        '
        'EntidadDataGridViewTextBoxColumn
        '
        Me.EntidadDataGridViewTextBoxColumn.DataPropertyName = "Entidad"
        Me.EntidadDataGridViewTextBoxColumn.HeaderText = "Entidad"
        Me.EntidadDataGridViewTextBoxColumn.Name = "EntidadDataGridViewTextBoxColumn"
        Me.EntidadDataGridViewTextBoxColumn.Visible = False
        '
        'SeleccionadoDataGridViewCheckBoxColumn
        '
        Me.SeleccionadoDataGridViewCheckBoxColumn.DataPropertyName = "Seleccionado"
        Me.SeleccionadoDataGridViewCheckBoxColumn.HeaderText = "Seleccionado"
        Me.SeleccionadoDataGridViewCheckBoxColumn.Name = "SeleccionadoDataGridViewCheckBoxColumn"
        Me.SeleccionadoDataGridViewCheckBoxColumn.Visible = False
        '
        'ContenedorDataGridViewTextBoxColumn
        '
        Me.ContenedorDataGridViewTextBoxColumn.DataPropertyName = "Contenedor"
        Me.ContenedorDataGridViewTextBoxColumn.HeaderText = "Contenedor"
        Me.ContenedorDataGridViewTextBoxColumn.Name = "ContenedorDataGridViewTextBoxColumn"
        Me.ContenedorDataGridViewTextBoxColumn.Visible = False
        '
        'IndiceEnContenedorDataGridViewTextBoxColumn
        '
        Me.IndiceEnContenedorDataGridViewTextBoxColumn.DataPropertyName = "IndiceEnContenedor"
        Me.IndiceEnContenedorDataGridViewTextBoxColumn.HeaderText = "IndiceEnContenedor"
        Me.IndiceEnContenedorDataGridViewTextBoxColumn.Name = "IndiceEnContenedorDataGridViewTextBoxColumn"
        Me.IndiceEnContenedorDataGridViewTextBoxColumn.ReadOnly = True
        Me.IndiceEnContenedorDataGridViewTextBoxColumn.Visible = False
        '
        'EncabezadoDataGridViewTextBoxColumn
        '
        Me.EncabezadoDataGridViewTextBoxColumn.DataPropertyName = "Encabezado"
        Me.EncabezadoDataGridViewTextBoxColumn.HeaderText = "Encabezado"
        Me.EncabezadoDataGridViewTextBoxColumn.Name = "EncabezadoDataGridViewTextBoxColumn"
        Me.EncabezadoDataGridViewTextBoxColumn.Visible = False
        '
        'FolioDataGridViewTextBoxColumn1
        '
        Me.FolioDataGridViewTextBoxColumn1.DataPropertyName = "Folio"
        Me.FolioDataGridViewTextBoxColumn1.HeaderText = "Folio"
        Me.FolioDataGridViewTextBoxColumn1.Name = "FolioDataGridViewTextBoxColumn1"
        Me.FolioDataGridViewTextBoxColumn1.Visible = False
        '
        'CompraGanadoDataGridViewTextBoxColumn
        '
        Me.CompraGanadoDataGridViewTextBoxColumn.DataPropertyName = "CompraGanado"
        Me.CompraGanadoDataGridViewTextBoxColumn.HeaderText = "CompraGanado"
        Me.CompraGanadoDataGridViewTextBoxColumn.Name = "CompraGanadoDataGridViewTextBoxColumn"
        Me.CompraGanadoDataGridViewTextBoxColumn.Visible = False
        '
        'IdRenglonDataGridViewTextBoxColumn
        '
        Me.IdRenglonDataGridViewTextBoxColumn.DataPropertyName = "IdRenglon"
        Me.IdRenglonDataGridViewTextBoxColumn.HeaderText = "IdRenglon"
        Me.IdRenglonDataGridViewTextBoxColumn.Name = "IdRenglonDataGridViewTextBoxColumn"
        Me.IdRenglonDataGridViewTextBoxColumn.Visible = False
        '
        'DescripcionTipoGanadoDataGridViewTextBoxColumn
        '
        Me.DescripcionTipoGanadoDataGridViewTextBoxColumn.DataPropertyName = "DescripcionTipoGanado"
        Me.DescripcionTipoGanadoDataGridViewTextBoxColumn.HeaderText = "DescripcionTipoGanado"
        Me.DescripcionTipoGanadoDataGridViewTextBoxColumn.Name = "DescripcionTipoGanadoDataGridViewTextBoxColumn"
        Me.DescripcionTipoGanadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionTipoGanadoDataGridViewTextBoxColumn.Visible = False
        '
        'TipoGanadoDataGridViewTextBoxColumn
        '
        Me.TipoGanadoDataGridViewTextBoxColumn.DataPropertyName = "TipoGanado"
        Me.TipoGanadoDataGridViewTextBoxColumn.HeaderText = "TipoGanado"
        Me.TipoGanadoDataGridViewTextBoxColumn.Name = "TipoGanadoDataGridViewTextBoxColumn"
        Me.TipoGanadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoGanadoDataGridViewTextBoxColumn.Visible = False
        '
        'FrmComprasGanado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 681)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.mtb)
        Me.MaximizeBox = False
        Me.Name = "FrmComprasGanado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compras de Ganado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvTiposdeGanado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DgvConceptoGastos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFolioCompra As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtKilosComprados As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPorcentajeMerma As System.Windows.Forms.TextBox
    Friend WithEvents txtKilosMerma As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmbCorral As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtImporteGuia As System.Windows.Forms.TextBox
    Friend WithEvents txtNoGuia As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmbComprador As System.Windows.Forms.ComboBox
    Friend WithEvents TipoGanadoC As ClasesNegocio.TipoGanadoColecttionClass
    Friend WithEvents CompradoresGanadoC As ClasesNegocio.CompradorGanadoCollectionClass
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents DataGridViewComboBoxColumn1 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents CmbLugarCompra As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgvTiposdeGanado As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents CmbCamion As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmbChofer As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TxtFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtIVA As System.Windows.Forms.TextBox
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents DgvConceptoGastos As System.Windows.Forms.DataGridView
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtKilosRecibidos As System.Windows.Forms.TextBox
    Friend WithEvents txtCantCabezas As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtDiasDeCredito As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtGastosTransporte As System.Windows.Forms.TextBox
    Friend WithEvents txtImporteTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtComision As System.Windows.Forms.TextBox
    Friend WithEvents rbtKilo As System.Windows.Forms.RadioButton
    Friend WithEvents rbtCabeza As System.Windows.Forms.RadioButton
    Friend WithEvents txtGuiaTransito As System.Windows.Forms.TextBox
    Friend WithEvents txtAdquisicion As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtImporteEducacion As System.Windows.Forms.TextBox
    Friend WithEvents txtImportePredial As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtNoCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtSucursal As System.Windows.Forms.TextBox
    Friend WithEvents txtBanco As System.Windows.Forms.TextBox
    Friend WithEvents txtNoFactura As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaPago As System.Windows.Forms.DateTimePicker
    Friend WithEvents DetGasTransC As ClasesNegocio.GastoTransporteDetalleCollectionClass
    Friend WithEvents ConceptoGastoC As ClasesNegocio.ConceptoGastosTransporteColeccionClass
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkImpuestoPredial As System.Windows.Forms.CheckBox
    Friend WithEvents chkImpuestoEducacion As System.Windows.Forms.CheckBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents CveGastoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    'Friend WithEvents PtjIvaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    'Friend WithEvents ImpteGastoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtHorasViaje As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ComprasGanadoDetalleC As ClasesNegocio.ComprasGanadoDetalleCollectionClass
    Friend WithEvents PromxCabezaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents ConceptoGastoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents PorcentajeIvaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteGastoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdTipoGanadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents CantKilosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosRecibidosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioXKiloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantCabezasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosPromXCabezaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoPromXCabezaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovimeintoGanadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FolioMovimeintoGanadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaMovimientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EntidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeleccionadoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ContenedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IndiceEnContenedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EncabezadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FolioDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompraGanadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdRenglonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionTipoGanadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoGanadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
