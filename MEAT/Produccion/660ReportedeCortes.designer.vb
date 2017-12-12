<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _660ReportedeCortes
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
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle40 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle41 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle42 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle43 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle44 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle45 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle46 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle47 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle48 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle49 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle50 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle51 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle52 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle53 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle54 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle55 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle56 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle57 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label17 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.txtFolioSacrificio = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkRangodeFechas = New System.Windows.Forms.CheckBox
        Me.DtpFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.DtpFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtCajasCanceladas = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtCajasEmbarcadas = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtCajasExistentes = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtCajasProducidas = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.txtFechaCorte = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtLoteCorte = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dgvRegistroCortes = New System.Windows.Forms.DataGridView
        Me.LoteCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LoteSacrificio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaCaducidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Estatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PiezasProducidas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PiezasExistentes = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PiezasEmbarcadas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalKilos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KilosExistentes = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KilosEmbarcados = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CajasProducidas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CajasExistentes = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CajasEmbarcadas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CajasCanceladas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CanalesACorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KilosACorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPiezasCanceladas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmKilosCancelados = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dgvDetalleCortes = New System.Windows.Forms.DataGridView
        Me.FolioEtiqueta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Corte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Piezas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Productor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstatusC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Embarque = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LoteCortes = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LotedeSacrificio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechadeCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechadeCaducidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.optdetallecortes = New System.Windows.Forms.RadioButton
        Me.txtCodigoCorte = New System.Windows.Forms.TextBox
        Me.txtCorte = New System.Windows.Forms.TextBox
        Me.chkCorteEspecifico = New System.Windows.Forms.CheckBox
        Me.optDetalleCortesporLote = New System.Windows.Forms.RadioButton
        Me.txtLoteCorte1 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.chkTodos = New System.Windows.Forms.CheckBox
        Me.chkEmbarcados = New System.Windows.Forms.CheckBox
        Me.chkVigentes = New System.Windows.Forms.CheckBox
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
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.optConcentradodeCortes = New System.Windows.Forms.RadioButton
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.ultcmbAlmacen = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvRegistroCortes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvDetalleCortes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.ultcmbAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(952, 32)
        Me.Label17.TabIndex = 61
        Me.Label17.Text = "Reporte de Cortes"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.mtb.MostrarBuscar = True
        Me.mtb.MostrarCancelar = False
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = False
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 530)
        Me.mtb.TabIndex = 62
        '
        'txtFolioSacrificio
        '
        Me.txtFolioSacrificio.Location = New System.Drawing.Point(162, 67)
        Me.txtFolioSacrificio.MaxLength = 10
        Me.txtFolioSacrificio.Name = "txtFolioSacrificio"
        Me.txtFolioSacrificio.Size = New System.Drawing.Size(100, 20)
        Me.txtFolioSacrificio.TabIndex = 67
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Folio de Sacrificio :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkRangodeFechas)
        Me.GroupBox1.Controls.Add(Me.DtpFechaFinal)
        Me.GroupBox1.Controls.Add(Me.DtpFechaInicio)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(436, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(345, 52)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        '
        'chkRangodeFechas
        '
        Me.chkRangodeFechas.AutoSize = True
        Me.chkRangodeFechas.Location = New System.Drawing.Point(7, 0)
        Me.chkRangodeFechas.Name = "chkRangodeFechas"
        Me.chkRangodeFechas.Size = New System.Drawing.Size(111, 17)
        Me.chkRangodeFechas.TabIndex = 4
        Me.chkRangodeFechas.Text = "Rango de Fechas"
        Me.chkRangodeFechas.UseVisualStyleBackColor = True
        '
        'DtpFechaFinal
        '
        Me.DtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaFinal.Location = New System.Drawing.Point(249, 22)
        Me.DtpFechaFinal.Name = "DtpFechaFinal"
        Me.DtpFechaFinal.Size = New System.Drawing.Size(87, 20)
        Me.DtpFechaFinal.TabIndex = 3
        '
        'DtpFechaInicio
        '
        Me.DtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaInicio.Location = New System.Drawing.Point(83, 22)
        Me.DtpFechaInicio.Name = "DtpFechaInicio"
        Me.DtpFechaInicio.Size = New System.Drawing.Size(86, 20)
        Me.DtpFechaInicio.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Inicio :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(175, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha Final :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox2)
        Me.GroupBox4.Controls.Add(Me.lblEstatus)
        Me.GroupBox4.Controls.Add(Me.txtFechaCorte)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txtLoteCorte)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.dgvRegistroCortes)
        Me.GroupBox4.Location = New System.Drawing.Point(54, 145)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(936, 195)
        Me.GroupBox4.TabIndex = 70
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Registro de Cortes"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCajasCanceladas)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtCajasEmbarcadas)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtCajasExistentes)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtCajasProducidas)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(584, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(317, 65)
        Me.GroupBox2.TabIndex = 72
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cajas"
        '
        'txtCajasCanceladas
        '
        Me.txtCajasCanceladas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCajasCanceladas.Enabled = False
        Me.txtCajasCanceladas.Location = New System.Drawing.Point(225, 43)
        Me.txtCajasCanceladas.MaxLength = 10
        Me.txtCajasCanceladas.Name = "txtCajasCanceladas"
        Me.txtCajasCanceladas.Size = New System.Drawing.Size(75, 20)
        Me.txtCajasCanceladas.TabIndex = 80
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(158, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 79
        Me.Label8.Text = "Canceladas :"
        '
        'txtCajasEmbarcadas
        '
        Me.txtCajasEmbarcadas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCajasEmbarcadas.Enabled = False
        Me.txtCajasEmbarcadas.Location = New System.Drawing.Point(85, 43)
        Me.txtCajasEmbarcadas.MaxLength = 10
        Me.txtCajasEmbarcadas.Name = "txtCajasEmbarcadas"
        Me.txtCajasEmbarcadas.Size = New System.Drawing.Size(67, 20)
        Me.txtCajasEmbarcadas.TabIndex = 78
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 77
        Me.Label9.Text = "Embarcadas :"
        '
        'txtCajasExistentes
        '
        Me.txtCajasExistentes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCajasExistentes.Enabled = False
        Me.txtCajasExistentes.Location = New System.Drawing.Point(225, 19)
        Me.txtCajasExistentes.MaxLength = 10
        Me.txtCajasExistentes.Name = "txtCajasExistentes"
        Me.txtCajasExistentes.Size = New System.Drawing.Size(75, 20)
        Me.txtCajasExistentes.TabIndex = 76
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(158, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "Existentes :"
        '
        'txtCajasProducidas
        '
        Me.txtCajasProducidas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCajasProducidas.Enabled = False
        Me.txtCajasProducidas.Location = New System.Drawing.Point(85, 19)
        Me.txtCajasProducidas.MaxLength = 10
        Me.txtCajasProducidas.Name = "txtCajasProducidas"
        Me.txtCajasProducidas.Size = New System.Drawing.Size(67, 20)
        Me.txtCajasProducidas.TabIndex = 74
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Producidas :"
        '
        'lblEstatus
        '
        Me.lblEstatus.AutoSize = True
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(438, 18)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(104, 24)
        Me.lblEstatus.TabIndex = 71
        Me.lblEstatus.Text = "ESTATUS"
        '
        'txtFechaCorte
        '
        Me.txtFechaCorte.Enabled = False
        Me.txtFechaCorte.Location = New System.Drawing.Point(287, 22)
        Me.txtFechaCorte.MaxLength = 10
        Me.txtFechaCorte.Name = "txtFechaCorte"
        Me.txtFechaCorte.Size = New System.Drawing.Size(100, 20)
        Me.txtFechaCorte.TabIndex = 71
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(195, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Fecha de Corte :"
        '
        'txtLoteCorte
        '
        Me.txtLoteCorte.Enabled = False
        Me.txtLoteCorte.Location = New System.Drawing.Point(89, 22)
        Me.txtLoteCorte.MaxLength = 10
        Me.txtLoteCorte.Name = "txtLoteCorte"
        Me.txtLoteCorte.Size = New System.Drawing.Size(100, 20)
        Me.txtLoteCorte.TabIndex = 69
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Lote de Corte :"
        '
        'dgvRegistroCortes
        '
        Me.dgvRegistroCortes.AllowUserToAddRows = False
        Me.dgvRegistroCortes.AllowUserToDeleteRows = False
        Me.dgvRegistroCortes.AllowUserToResizeRows = False
        Me.dgvRegistroCortes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegistroCortes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LoteCorte, Me.LoteSacrificio, Me.FechaCorte, Me.FechaCaducidad, Me.Codigo, Me.Cliente, Me.Estatus, Me.PiezasProducidas, Me.PiezasExistentes, Me.PiezasEmbarcadas, Me.TotalKilos, Me.KilosExistentes, Me.KilosEmbarcados, Me.CajasProducidas, Me.CajasExistentes, Me.CajasEmbarcadas, Me.CajasCanceladas, Me.CanalesACorte, Me.KilosACorte, Me.clmPiezasCanceladas, Me.clmKilosCancelados})
        Me.dgvRegistroCortes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvRegistroCortes.Location = New System.Drawing.Point(3, 81)
        Me.dgvRegistroCortes.Name = "dgvRegistroCortes"
        Me.dgvRegistroCortes.ReadOnly = True
        Me.dgvRegistroCortes.RowHeadersVisible = False
        Me.dgvRegistroCortes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRegistroCortes.Size = New System.Drawing.Size(930, 111)
        Me.dgvRegistroCortes.TabIndex = 18
        '
        'LoteCorte
        '
        Me.LoteCorte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.LoteCorte.DataPropertyName = "LoteCorte"
        DataGridViewCellStyle39.Format = "dd/MMM/yyyy"
        DataGridViewCellStyle39.NullValue = Nothing
        Me.LoteCorte.DefaultCellStyle = DataGridViewCellStyle39
        Me.LoteCorte.HeaderText = "Lote Corte"
        Me.LoteCorte.Name = "LoteCorte"
        Me.LoteCorte.ReadOnly = True
        Me.LoteCorte.Width = 79
        '
        'LoteSacrificio
        '
        Me.LoteSacrificio.DataPropertyName = "LoteSacrificio"
        DataGridViewCellStyle40.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LoteSacrificio.DefaultCellStyle = DataGridViewCellStyle40
        Me.LoteSacrificio.HeaderText = "Sacrificio"
        Me.LoteSacrificio.Name = "LoteSacrificio"
        Me.LoteSacrificio.ReadOnly = True
        Me.LoteSacrificio.Visible = False
        '
        'FechaCorte
        '
        Me.FechaCorte.DataPropertyName = "FechaCorte"
        Me.FechaCorte.HeaderText = "Fecha Corte"
        Me.FechaCorte.Name = "FechaCorte"
        Me.FechaCorte.ReadOnly = True
        Me.FechaCorte.Visible = False
        '
        'FechaCaducidad
        '
        Me.FechaCaducidad.DataPropertyName = "FechaCad"
        Me.FechaCaducidad.HeaderText = "Fecha Cad"
        Me.FechaCaducidad.Name = "FechaCaducidad"
        Me.FechaCaducidad.ReadOnly = True
        Me.FechaCaducidad.Visible = False
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "IdCliente"
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Visible = False
        '
        'Cliente
        '
        Me.Cliente.DataPropertyName = "Nombre"
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        Me.Cliente.Visible = False
        '
        'Estatus
        '
        Me.Estatus.DataPropertyName = "Estatus"
        Me.Estatus.HeaderText = "Estatus"
        Me.Estatus.Name = "Estatus"
        Me.Estatus.ReadOnly = True
        Me.Estatus.Visible = False
        '
        'PiezasProducidas
        '
        Me.PiezasProducidas.DataPropertyName = "TotalPiezas"
        DataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle41.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle41.Format = "N0"
        DataGridViewCellStyle41.NullValue = Nothing
        Me.PiezasProducidas.DefaultCellStyle = DataGridViewCellStyle41
        Me.PiezasProducidas.HeaderText = "Piezas  Prod"
        Me.PiezasProducidas.Name = "PiezasProducidas"
        Me.PiezasProducidas.ReadOnly = True
        '
        'PiezasExistentes
        '
        Me.PiezasExistentes.DataPropertyName = "PiezasExistentes"
        DataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle42.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle42.Format = "N0"
        DataGridViewCellStyle42.NullValue = Nothing
        Me.PiezasExistentes.DefaultCellStyle = DataGridViewCellStyle42
        Me.PiezasExistentes.HeaderText = "Piezas Exis"
        Me.PiezasExistentes.Name = "PiezasExistentes"
        Me.PiezasExistentes.ReadOnly = True
        '
        'PiezasEmbarcadas
        '
        Me.PiezasEmbarcadas.DataPropertyName = "PiezasEmbarcadas"
        DataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle43.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle43.Format = "N0"
        DataGridViewCellStyle43.NullValue = Nothing
        Me.PiezasEmbarcadas.DefaultCellStyle = DataGridViewCellStyle43
        Me.PiezasEmbarcadas.HeaderText = "Piezas Emb"
        Me.PiezasEmbarcadas.Name = "PiezasEmbarcadas"
        Me.PiezasEmbarcadas.ReadOnly = True
        '
        'TotalKilos
        '
        Me.TotalKilos.DataPropertyName = "TotalKilos"
        DataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle44.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle44.Format = "N3"
        DataGridViewCellStyle44.NullValue = Nothing
        Me.TotalKilos.DefaultCellStyle = DataGridViewCellStyle44
        Me.TotalKilos.HeaderText = "Kilos Prod"
        Me.TotalKilos.Name = "TotalKilos"
        Me.TotalKilos.ReadOnly = True
        '
        'KilosExistentes
        '
        Me.KilosExistentes.DataPropertyName = "KilosExistentes"
        DataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle45.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle45.Format = "N3"
        DataGridViewCellStyle45.NullValue = Nothing
        Me.KilosExistentes.DefaultCellStyle = DataGridViewCellStyle45
        Me.KilosExistentes.HeaderText = "Kilos Exis"
        Me.KilosExistentes.Name = "KilosExistentes"
        Me.KilosExistentes.ReadOnly = True
        '
        'KilosEmbarcados
        '
        Me.KilosEmbarcados.DataPropertyName = "KilosEmbarcados"
        DataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle46.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle46.Format = "N3"
        DataGridViewCellStyle46.NullValue = Nothing
        Me.KilosEmbarcados.DefaultCellStyle = DataGridViewCellStyle46
        Me.KilosEmbarcados.HeaderText = "Kilos Emb"
        Me.KilosEmbarcados.Name = "KilosEmbarcados"
        Me.KilosEmbarcados.ReadOnly = True
        '
        'CajasProducidas
        '
        Me.CajasProducidas.DataPropertyName = "TotalCajas"
        Me.CajasProducidas.HeaderText = "Cajas Producidas"
        Me.CajasProducidas.Name = "CajasProducidas"
        Me.CajasProducidas.ReadOnly = True
        Me.CajasProducidas.Visible = False
        '
        'CajasExistentes
        '
        Me.CajasExistentes.DataPropertyName = "CajasExistentes"
        Me.CajasExistentes.HeaderText = "Cajas Existentes"
        Me.CajasExistentes.Name = "CajasExistentes"
        Me.CajasExistentes.ReadOnly = True
        Me.CajasExistentes.Visible = False
        '
        'CajasEmbarcadas
        '
        Me.CajasEmbarcadas.DataPropertyName = "CajasEmbarcadas"
        Me.CajasEmbarcadas.HeaderText = "Cajas Embarcadas"
        Me.CajasEmbarcadas.Name = "CajasEmbarcadas"
        Me.CajasEmbarcadas.ReadOnly = True
        Me.CajasEmbarcadas.Visible = False
        '
        'CajasCanceladas
        '
        Me.CajasCanceladas.DataPropertyName = "CajasCanceladas"
        Me.CajasCanceladas.HeaderText = "Cajas Canceladas"
        Me.CajasCanceladas.Name = "CajasCanceladas"
        Me.CajasCanceladas.ReadOnly = True
        Me.CajasCanceladas.Visible = False
        '
        'CanalesACorte
        '
        Me.CanalesACorte.DataPropertyName = "CanalesACorte"
        Me.CanalesACorte.HeaderText = "Canal A Corte"
        Me.CanalesACorte.Name = "CanalesACorte"
        Me.CanalesACorte.ReadOnly = True
        '
        'KilosACorte
        '
        Me.KilosACorte.DataPropertyName = "KilosACorte"
        Me.KilosACorte.HeaderText = "Kilos A Corte"
        Me.KilosACorte.Name = "KilosACorte"
        Me.KilosACorte.ReadOnly = True
        '
        'clmPiezasCanceladas
        '
        Me.clmPiezasCanceladas.DataPropertyName = "PiezasCanceladas"
        Me.clmPiezasCanceladas.HeaderText = "Piezas Canceladas"
        Me.clmPiezasCanceladas.Name = "clmPiezasCanceladas"
        Me.clmPiezasCanceladas.ReadOnly = True
        Me.clmPiezasCanceladas.Visible = False
        '
        'clmKilosCancelados
        '
        Me.clmKilosCancelados.DataPropertyName = "KilosCancelados"
        Me.clmKilosCancelados.HeaderText = "Kilos Cancelados"
        Me.clmKilosCancelados.Name = "clmKilosCancelados"
        Me.clmKilosCancelados.ReadOnly = True
        Me.clmKilosCancelados.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvDetalleCortes)
        Me.GroupBox3.Location = New System.Drawing.Point(51, 346)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(718, 176)
        Me.GroupBox3.TabIndex = 69
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalle de Cortes"
        '
        'dgvDetalleCortes
        '
        Me.dgvDetalleCortes.AllowUserToAddRows = False
        Me.dgvDetalleCortes.AllowUserToDeleteRows = False
        Me.dgvDetalleCortes.AllowUserToResizeRows = False
        Me.dgvDetalleCortes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleCortes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FolioEtiqueta, Me.Corte, Me.Piezas, Me.Productor, Me.EstatusC, Me.Embarque, Me.LoteCortes, Me.LotedeSacrificio, Me.FechadeCorte, Me.FechadeCaducidad})
        Me.dgvDetalleCortes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDetalleCortes.Location = New System.Drawing.Point(3, 16)
        Me.dgvDetalleCortes.Name = "dgvDetalleCortes"
        Me.dgvDetalleCortes.ReadOnly = True
        Me.dgvDetalleCortes.RowHeadersVisible = False
        Me.dgvDetalleCortes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetalleCortes.Size = New System.Drawing.Size(712, 157)
        Me.dgvDetalleCortes.TabIndex = 18
        '
        'FolioEtiqueta
        '
        Me.FolioEtiqueta.DataPropertyName = "IdFolioEtiqueta"
        Me.FolioEtiqueta.HeaderText = "Folio Etiqueta"
        Me.FolioEtiqueta.Name = "FolioEtiqueta"
        Me.FolioEtiqueta.ReadOnly = True
        Me.FolioEtiqueta.Width = 130
        '
        'Corte
        '
        Me.Corte.DataPropertyName = "Corte"
        DataGridViewCellStyle47.Format = "dd/MMM/yyyy"
        DataGridViewCellStyle47.NullValue = Nothing
        Me.Corte.DefaultCellStyle = DataGridViewCellStyle47
        Me.Corte.HeaderText = "Corte"
        Me.Corte.Name = "Corte"
        Me.Corte.ReadOnly = True
        Me.Corte.Width = 130
        '
        'Piezas
        '
        Me.Piezas.DataPropertyName = "CantPzas"
        Me.Piezas.HeaderText = "Piezas"
        Me.Piezas.Name = "Piezas"
        Me.Piezas.ReadOnly = True
        '
        'Productor
        '
        Me.Productor.DataPropertyName = "CantKgrs"
        Me.Productor.HeaderText = "Kilos"
        Me.Productor.Name = "Productor"
        Me.Productor.ReadOnly = True
        '
        'EstatusC
        '
        Me.EstatusC.DataPropertyName = "Estatus"
        Me.EstatusC.HeaderText = "Estatus"
        Me.EstatusC.Name = "EstatusC"
        Me.EstatusC.ReadOnly = True
        '
        'Embarque
        '
        Me.Embarque.DataPropertyName = "IdFolioEmbarque"
        Me.Embarque.HeaderText = "Folio Embarque"
        Me.Embarque.Name = "Embarque"
        Me.Embarque.ReadOnly = True
        Me.Embarque.Width = 120
        '
        'LoteCortes
        '
        Me.LoteCortes.DataPropertyName = "LoteCorte"
        Me.LoteCortes.HeaderText = "Lote Corte"
        Me.LoteCortes.Name = "LoteCortes"
        Me.LoteCortes.ReadOnly = True
        Me.LoteCortes.Visible = False
        '
        'LotedeSacrificio
        '
        Me.LotedeSacrificio.DataPropertyName = "LoteSacrificio"
        Me.LotedeSacrificio.HeaderText = "Lote Sacrificio"
        Me.LotedeSacrificio.Name = "LotedeSacrificio"
        Me.LotedeSacrificio.ReadOnly = True
        Me.LotedeSacrificio.Visible = False
        '
        'FechadeCorte
        '
        Me.FechadeCorte.DataPropertyName = "FechaCorte"
        Me.FechadeCorte.HeaderText = "Fecha de Corte"
        Me.FechadeCorte.Name = "FechadeCorte"
        Me.FechadeCorte.ReadOnly = True
        Me.FechadeCorte.Visible = False
        '
        'FechadeCaducidad
        '
        Me.FechadeCaducidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.FechadeCaducidad.DataPropertyName = "FechaCad"
        Me.FechadeCaducidad.HeaderText = "Fecha Caducidad"
        Me.FechadeCaducidad.Name = "FechadeCaducidad"
        Me.FechadeCaducidad.ReadOnly = True
        Me.FechadeCaducidad.Visible = False
        '
        'optdetallecortes
        '
        Me.optdetallecortes.AutoSize = True
        Me.optdetallecortes.Location = New System.Drawing.Point(6, 45)
        Me.optdetallecortes.Name = "optdetallecortes"
        Me.optdetallecortes.Size = New System.Drawing.Size(106, 17)
        Me.optdetallecortes.TabIndex = 73
        Me.optdetallecortes.TabStop = True
        Me.optdetallecortes.Text = "Detalle de Cortes"
        Me.optdetallecortes.UseVisualStyleBackColor = True
        '
        'txtCodigoCorte
        '
        Me.txtCodigoCorte.Enabled = False
        Me.txtCodigoCorte.Location = New System.Drawing.Point(162, 93)
        Me.txtCodigoCorte.MaxLength = 10
        Me.txtCodigoCorte.Name = "txtCodigoCorte"
        Me.txtCodigoCorte.Size = New System.Drawing.Size(51, 20)
        Me.txtCodigoCorte.TabIndex = 75
        '
        'txtCorte
        '
        Me.txtCorte.Enabled = False
        Me.txtCorte.Location = New System.Drawing.Point(219, 93)
        Me.txtCorte.MaxLength = 10
        Me.txtCorte.Name = "txtCorte"
        Me.txtCorte.Size = New System.Drawing.Size(230, 20)
        Me.txtCorte.TabIndex = 76
        '
        'chkCorteEspecifico
        '
        Me.chkCorteEspecifico.AutoSize = True
        Me.chkCorteEspecifico.Location = New System.Drawing.Point(54, 95)
        Me.chkCorteEspecifico.Name = "chkCorteEspecifico"
        Me.chkCorteEspecifico.Size = New System.Drawing.Size(102, 17)
        Me.chkCorteEspecifico.TabIndex = 77
        Me.chkCorteEspecifico.Text = "Corte especifico"
        Me.chkCorteEspecifico.UseVisualStyleBackColor = True
        '
        'optDetalleCortesporLote
        '
        Me.optDetalleCortesporLote.AutoSize = True
        Me.optDetalleCortesporLote.Location = New System.Drawing.Point(6, 22)
        Me.optDetalleCortesporLote.Name = "optDetalleCortesporLote"
        Me.optDetalleCortesporLote.Size = New System.Drawing.Size(191, 17)
        Me.optDetalleCortesporLote.TabIndex = 78
        Me.optDetalleCortesporLote.TabStop = True
        Me.optDetalleCortesporLote.Text = "Detalle de Cortes por Lote de Corte"
        Me.optDetalleCortesporLote.UseVisualStyleBackColor = True
        '
        'txtLoteCorte1
        '
        Me.txtLoteCorte1.Location = New System.Drawing.Point(162, 119)
        Me.txtLoteCorte1.MaxLength = 10
        Me.txtLoteCorte1.Name = "txtLoteCorte1"
        Me.txtLoteCorte1.Size = New System.Drawing.Size(100, 20)
        Me.txtLoteCorte1.TabIndex = 80
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(51, 122)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 13)
        Me.Label10.TabIndex = 79
        Me.Label10.Text = "Lote de Corte :"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chkTodos)
        Me.GroupBox5.Controls.Add(Me.chkEmbarcados)
        Me.GroupBox5.Controls.Add(Me.chkVigentes)
        Me.GroupBox5.Location = New System.Drawing.Point(547, 93)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(234, 44)
        Me.GroupBox5.TabIndex = 81
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Estatus"
        '
        'chkTodos
        '
        Me.chkTodos.AutoSize = True
        Me.chkTodos.Location = New System.Drawing.Point(168, 19)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(56, 17)
        Me.chkTodos.TabIndex = 2
        Me.chkTodos.Text = "Todos"
        Me.chkTodos.UseVisualStyleBackColor = True
        '
        'chkEmbarcados
        '
        Me.chkEmbarcados.AutoSize = True
        Me.chkEmbarcados.Location = New System.Drawing.Point(82, 20)
        Me.chkEmbarcados.Name = "chkEmbarcados"
        Me.chkEmbarcados.Size = New System.Drawing.Size(80, 17)
        Me.chkEmbarcados.TabIndex = 1
        Me.chkEmbarcados.Text = "Embarcada"
        Me.chkEmbarcados.UseVisualStyleBackColor = True
        '
        'chkVigentes
        '
        Me.chkVigentes.AutoSize = True
        Me.chkVigentes.Checked = True
        Me.chkVigentes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVigentes.Location = New System.Drawing.Point(9, 20)
        Me.chkVigentes.Name = "chkVigentes"
        Me.chkVigentes.Size = New System.Drawing.Size(67, 17)
        Me.chkVigentes.TabIndex = 0
        Me.chkVigentes.Text = "Vigentes"
        Me.chkVigentes.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdFolioEtiqueta"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Folio Etiqueta"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 130
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Corte"
        DataGridViewCellStyle48.Format = "dd/MMM/yyyy"
        DataGridViewCellStyle48.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle48
        Me.DataGridViewTextBoxColumn2.HeaderText = "Corte"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 130
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CantPzas"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Piezas"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CantKgrs"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Kilos"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Estatus"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Estatus"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "IdFolioEmbarque"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Folio Embarque"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 120
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "LoteCorte"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Lote Corte"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "LoteSacrificio"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Lote Sacrificio"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "FechaCorte"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Fecha de Corte"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "FechaCad"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Fecha Caducidad"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "LoteSacrificio"
        DataGridViewCellStyle49.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle49
        Me.DataGridViewTextBoxColumn11.HeaderText = "Sacrificio"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "LoteCorte"
        DataGridViewCellStyle50.Format = "dd/MMM/yyyy"
        DataGridViewCellStyle50.NullValue = Nothing
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle50
        Me.DataGridViewTextBoxColumn12.HeaderText = "Corte"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "FechaCorte"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Fecha Corte"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "FechaCad"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Fecha Cad"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "CanalesACorte"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Canal A Corte"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "KilosACorte"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Kilos A Corte"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "TotalPzas"
        DataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle51.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle51.Format = "N0"
        DataGridViewCellStyle51.NullValue = Nothing
        Me.DataGridViewTextBoxColumn17.DefaultCellStyle = DataGridViewCellStyle51
        Me.DataGridViewTextBoxColumn17.HeaderText = "Piezas  Prod"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Visible = False
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "PiezasExistentes"
        DataGridViewCellStyle52.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle52.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle52.Format = "N0"
        DataGridViewCellStyle52.NullValue = Nothing
        Me.DataGridViewTextBoxColumn18.DefaultCellStyle = DataGridViewCellStyle52
        Me.DataGridViewTextBoxColumn18.HeaderText = "Piezas Exis"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "PiezasEmbarcadas"
        DataGridViewCellStyle53.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle53.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle53.Format = "N0"
        DataGridViewCellStyle53.NullValue = Nothing
        Me.DataGridViewTextBoxColumn19.DefaultCellStyle = DataGridViewCellStyle53
        Me.DataGridViewTextBoxColumn19.HeaderText = "Piezas Emb"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "TotalKgs"
        DataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle54.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle54.Format = "N3"
        DataGridViewCellStyle54.NullValue = Nothing
        Me.DataGridViewTextBoxColumn20.DefaultCellStyle = DataGridViewCellStyle54
        Me.DataGridViewTextBoxColumn20.HeaderText = "Kilos Prod"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "KilosExistentes"
        DataGridViewCellStyle55.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle55.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle55.Format = "N3"
        DataGridViewCellStyle55.NullValue = Nothing
        Me.DataGridViewTextBoxColumn21.DefaultCellStyle = DataGridViewCellStyle55
        Me.DataGridViewTextBoxColumn21.HeaderText = "Kilos Exis"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "KilosEmbarcados"
        DataGridViewCellStyle56.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle56.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle56.Format = "N3"
        DataGridViewCellStyle56.NullValue = Nothing
        Me.DataGridViewTextBoxColumn22.DefaultCellStyle = DataGridViewCellStyle56
        Me.DataGridViewTextBoxColumn22.HeaderText = "Kilos Emb"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Estatus"
        DataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle57.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle57.Format = "N3"
        DataGridViewCellStyle57.NullValue = Nothing
        Me.DataGridViewTextBoxColumn23.DefaultCellStyle = DataGridViewCellStyle57
        Me.DataGridViewTextBoxColumn23.HeaderText = "Estatus"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Visible = False
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Visible = False
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "IdCliente"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        Me.DataGridViewTextBoxColumn25.Visible = False
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "TotalCajas"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Cajas Producidas"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        Me.DataGridViewTextBoxColumn26.Visible = False
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "CajasExistentes"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Cajas Existentes"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        Me.DataGridViewTextBoxColumn27.Visible = False
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "CajasEmbarcadas"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Cajas Embarcadas"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        Me.DataGridViewTextBoxColumn28.Visible = False
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "CajasCanceladas"
        Me.DataGridViewTextBoxColumn29.HeaderText = "Cajas Canceladas"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        Me.DataGridViewTextBoxColumn29.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(268, 122)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(122, 13)
        Me.Label11.TabIndex = 82
        Me.Label11.Text = "F3 Buscar Lote de Corte"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(455, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 13)
        Me.Label12.TabIndex = 83
        Me.Label12.Text = "F3 Buscar  Corte"
        '
        'optConcentradodeCortes
        '
        Me.optConcentradodeCortes.AutoSize = True
        Me.optConcentradodeCortes.Location = New System.Drawing.Point(6, 68)
        Me.optConcentradodeCortes.Name = "optConcentradodeCortes"
        Me.optConcentradodeCortes.Size = New System.Drawing.Size(134, 17)
        Me.optConcentradodeCortes.TabIndex = 84
        Me.optConcentradodeCortes.TabStop = True
        Me.optConcentradodeCortes.Text = "Concentrado de Cortes"
        Me.optConcentradodeCortes.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.optConcentradodeCortes)
        Me.GroupBox6.Controls.Add(Me.optdetallecortes)
        Me.GroupBox6.Controls.Add(Me.optDetalleCortesporLote)
        Me.GroupBox6.Location = New System.Drawing.Point(787, 35)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(203, 102)
        Me.GroupBox6.TabIndex = 85
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Tipo"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(51, 44)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 13)
        Me.Label13.TabIndex = 86
        Me.Label13.Text = "Almacen :"
        '
        'ultcmbAlmacen
        '
        Me.ultcmbAlmacen.Location = New System.Drawing.Point(162, 40)
        Me.ultcmbAlmacen.Name = "ultcmbAlmacen"
        Me.ultcmbAlmacen.Size = New System.Drawing.Size(268, 21)
        Me.ultcmbAlmacen.TabIndex = 87
        '
        '_660ReportedeCortes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 530)
        Me.Controls.Add(Me.ultcmbAlmacen)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.txtLoteCorte1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.chkCorteEspecifico)
        Me.Controls.Add(Me.txtCorte)
        Me.Controls.Add(Me.txtCodigoCorte)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.txtFolioSacrificio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "_660ReportedeCortes"
        Me.Text = "Reporte de Cortes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvRegistroCortes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvDetalleCortes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.ultcmbAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents txtFolioSacrificio As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvRegistroCortes As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDetalleCortes As System.Windows.Forms.DataGridView
    Friend WithEvents txtLoteCorte As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFechaCorte As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCajasCanceladas As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCajasEmbarcadas As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCajasExistentes As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCajasProducidas As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents optdetallecortes As System.Windows.Forms.RadioButton
    Friend WithEvents FolioEtiqueta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Corte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Piezas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Productor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstatusC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Embarque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoteCortes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LotedeSacrificio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechadeCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechadeCaducidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCodigoCorte As System.Windows.Forms.TextBox
    Friend WithEvents txtCorte As System.Windows.Forms.TextBox
    Friend WithEvents chkCorteEspecifico As System.Windows.Forms.CheckBox
    Friend WithEvents optDetalleCortesporLote As System.Windows.Forms.RadioButton
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
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtLoteCorte1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents chkEmbarcados As System.Windows.Forms.CheckBox
    Friend WithEvents chkVigentes As System.Windows.Forms.CheckBox
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents chkRangodeFechas As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LoteCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoteSacrificio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaCaducidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PiezasProducidas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PiezasExistentes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PiezasEmbarcadas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalKilos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosExistentes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosEmbarcados As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CajasProducidas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CajasExistentes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CajasEmbarcadas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CajasCanceladas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CanalesACorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosACorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPiezasCanceladas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmKilosCancelados As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents optConcentradodeCortes As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ultcmbAlmacen As Infragistics.Win.UltraWinEditors.UltraComboEditor
End Class
