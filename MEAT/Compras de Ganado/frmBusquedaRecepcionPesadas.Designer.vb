<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaRecepcionPesadas
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
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dgvRecepcionPesadas = New System.Windows.Forms.DataGridView
        Me.clmLoteRecepcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmKilosRecibidos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmKilosEnviados = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCantCabezas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmKilosSegundaPesada = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmConductor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPlacas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmTipoPesada = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RecepcionGanadoColeccion1 = New ClasesNegocio.RecepcionGanadoColeccion
        Me.txtFolio = New Integralab.Controles.TextBoxMejorado
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtProveedor = New Integralab.Controles.TextBoxMejorado
        Me.cmbProveedor = New Integralab.Controles.ComboBoxMejorado
        Me.Label6 = New System.Windows.Forms.Label
        Me.chkCancelado = New System.Windows.Forms.CheckBox
        Me.chkVigente = New System.Windows.Forms.CheckBox
        Me.chkPorFecha = New System.Windows.Forms.CheckBox
        CType(Me.dgvRecepcionPesadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.mtb.Size = New System.Drawing.Size(50, 423)
        Me.mtb.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(50, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(555, 29)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "BÚSQUEDA DE RECEPCION DE PESADAS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Folio :"
        '
        'dgvRecepcionPesadas
        '
        Me.dgvRecepcionPesadas.AllowUserToAddRows = False
        Me.dgvRecepcionPesadas.AllowUserToDeleteRows = False
        Me.dgvRecepcionPesadas.AllowUserToResizeColumns = False
        Me.dgvRecepcionPesadas.AutoGenerateColumns = False
        Me.dgvRecepcionPesadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecepcionPesadas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmLoteRecepcion, Me.clmFecha, Me.clmKilosRecibidos, Me.clmKilosEnviados, Me.clmCantCabezas, Me.clmKilosSegundaPesada, Me.clmProveedor, Me.clmUnidad, Me.clmConductor, Me.clmPlacas, Me.clmObservaciones, Me.clmTipoPesada, Me.clmEstatus})
        Me.dgvRecepcionPesadas.DataSource = Me.RecepcionGanadoColeccion1
        Me.dgvRecepcionPesadas.Location = New System.Drawing.Point(55, 191)
        Me.dgvRecepcionPesadas.MultiSelect = False
        Me.dgvRecepcionPesadas.Name = "dgvRecepcionPesadas"
        Me.dgvRecepcionPesadas.ReadOnly = True
        Me.dgvRecepcionPesadas.RowHeadersVisible = False
        Me.dgvRecepcionPesadas.Size = New System.Drawing.Size(538, 222)
        Me.dgvRecepcionPesadas.TabIndex = 51
        '
        'clmLoteRecepcion
        '
        Me.clmLoteRecepcion.DataPropertyName = "LoteRecepcion"
        Me.clmLoteRecepcion.HeaderText = "Folio"
        Me.clmLoteRecepcion.Name = "clmLoteRecepcion"
        Me.clmLoteRecepcion.ReadOnly = True
        '
        'clmFecha
        '
        Me.clmFecha.DataPropertyName = "FechaRecepcion"
        Me.clmFecha.HeaderText = "Fecha"
        Me.clmFecha.Name = "clmFecha"
        Me.clmFecha.ReadOnly = True
        Me.clmFecha.Width = 80
        '
        'clmKilosRecibidos
        '
        Me.clmKilosRecibidos.DataPropertyName = "KilosRecibidos"
        Me.clmKilosRecibidos.HeaderText = "Kilos Recibidos"
        Me.clmKilosRecibidos.Name = "clmKilosRecibidos"
        Me.clmKilosRecibidos.ReadOnly = True
        Me.clmKilosRecibidos.Width = 80
        '
        'clmKilosEnviados
        '
        Me.clmKilosEnviados.DataPropertyName = "KilosEnviados"
        Me.clmKilosEnviados.HeaderText = "Kilos Enviados"
        Me.clmKilosEnviados.Name = "clmKilosEnviados"
        Me.clmKilosEnviados.ReadOnly = True
        Me.clmKilosEnviados.Width = 80
        '
        'clmCantCabezas
        '
        Me.clmCantCabezas.DataPropertyName = "CantCabezas"
        Me.clmCantCabezas.HeaderText = "Total Cabezas"
        Me.clmCantCabezas.Name = "clmCantCabezas"
        Me.clmCantCabezas.ReadOnly = True
        Me.clmCantCabezas.Width = 80
        '
        'clmKilosSegundaPesada
        '
        Me.clmKilosSegundaPesada.DataPropertyName = "KilosSegundaPesada"
        Me.clmKilosSegundaPesada.HeaderText = "Kilos 2da Pesada"
        Me.clmKilosSegundaPesada.Name = "clmKilosSegundaPesada"
        Me.clmKilosSegundaPesada.ReadOnly = True
        Me.clmKilosSegundaPesada.Width = 80
        '
        'clmProveedor
        '
        Me.clmProveedor.DataPropertyName = "Proveedor"
        Me.clmProveedor.HeaderText = "Proveedor"
        Me.clmProveedor.Name = "clmProveedor"
        Me.clmProveedor.ReadOnly = True
        '
        'clmUnidad
        '
        Me.clmUnidad.DataPropertyName = "Unidad"
        Me.clmUnidad.HeaderText = "Unidad"
        Me.clmUnidad.Name = "clmUnidad"
        Me.clmUnidad.ReadOnly = True
        '
        'clmConductor
        '
        Me.clmConductor.DataPropertyName = "Conductor"
        Me.clmConductor.HeaderText = "Conductor"
        Me.clmConductor.Name = "clmConductor"
        Me.clmConductor.ReadOnly = True
        '
        'clmPlacas
        '
        Me.clmPlacas.DataPropertyName = "Placas"
        Me.clmPlacas.HeaderText = "Placas"
        Me.clmPlacas.Name = "clmPlacas"
        Me.clmPlacas.ReadOnly = True
        '
        'clmObservaciones
        '
        Me.clmObservaciones.DataPropertyName = "Observaciones"
        Me.clmObservaciones.HeaderText = "Observaciones"
        Me.clmObservaciones.Name = "clmObservaciones"
        Me.clmObservaciones.ReadOnly = True
        '
        'clmTipoPesada
        '
        Me.clmTipoPesada.DataPropertyName = "TipoPesada"
        Me.clmTipoPesada.HeaderText = "Tipo Pesada"
        Me.clmTipoPesada.Name = "clmTipoPesada"
        Me.clmTipoPesada.ReadOnly = True
        '
        'clmEstatus
        '
        Me.clmEstatus.DataPropertyName = "Estatus"
        Me.clmEstatus.HeaderText = "Estatus"
        Me.clmEstatus.Name = "clmEstatus"
        Me.clmEstatus.ReadOnly = True
        '
        'RecepcionGanadoColeccion1
        '
        Me.RecepcionGanadoColeccion1.AllowEdit = True
        Me.RecepcionGanadoColeccion1.AllowNew = True
        Me.RecepcionGanadoColeccion1.AllowRemove = True
        Me.RecepcionGanadoColeccion1.MaximoElementosSeleccionados = 1
        Me.RecepcionGanadoColeccion1.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.RecepcionGanadoColeccion1.MostrarAlertas = False
        Me.RecepcionGanadoColeccion1.Name = Nothing
        Me.RecepcionGanadoColeccion1.RaiseListChangedEvents = True
        '
        'txtFolio
        '
        Me.txtFolio.ComboBoxEnlazado = Nothing
        Me.txtFolio.Decimales = 0
        Me.txtFolio.Location = New System.Drawing.Point(127, 43)
        Me.txtFolio.MaxLength = 3000
        Me.txtFolio.MensajeCombo = "Seleccionar un item..."
        Me.txtFolio.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.SiguienteControl = Nothing
        Me.txtFolio.Size = New System.Drawing.Size(92, 20)
        Me.txtFolio.TabIndex = 55
        Me.txtFolio.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkPorFecha)
        Me.GroupBox1.Controls.Add(Me.dtpFechaInicial)
        Me.GroupBox1.Controls.Add(Me.dtpFechaFinal)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(55, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 51)
        Me.GroupBox1.TabIndex = 127
        Me.GroupBox1.TabStop = False
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicial.Location = New System.Drawing.Point(82, 19)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(85, 20)
        Me.dtpFechaInicial.TabIndex = 126
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(262, 19)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(85, 20)
        Me.dtpFechaFinal.TabIndex = 127
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "Fecha Inicial:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(191, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 128
        Me.Label4.Text = "Fecha Final:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 128
        Me.Label5.Text = "Proveedor :"
        '
        'txtProveedor
        '
        Me.txtProveedor.ComboBoxEnlazado = Nothing
        Me.txtProveedor.Decimales = 0
        Me.txtProveedor.Location = New System.Drawing.Point(127, 68)
        Me.txtProveedor.MaxLength = 3000
        Me.txtProveedor.MensajeCombo = "Seleccionar un item..."
        Me.txtProveedor.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.SiguienteControl = Nothing
        Me.txtProveedor.Size = New System.Drawing.Size(60, 20)
        Me.txtProveedor.TabIndex = 129
        Me.txtProveedor.Text = "0"
        Me.txtProveedor.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        '
        'cmbProveedor
        '
        Me.cmbProveedor.DisplayMember = "RazonSocial"
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(193, 68)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.NombreMetodo = Nothing
        Me.cmbProveedor.Parametros = Nothing
        Me.cmbProveedor.SiguienteControl = Nothing
        Me.cmbProveedor.Size = New System.Drawing.Size(299, 21)
        Me.cmbProveedor.TabIndex = 130
        Me.cmbProveedor.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbProveedor.TextBoxEnlazado = Nothing
        Me.cmbProveedor.ValueMember = "Codigo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 131
        Me.Label6.Text = "Estatus:"
        '
        'chkCancelado
        '
        Me.chkCancelado.AutoSize = True
        Me.chkCancelado.Checked = True
        Me.chkCancelado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCancelado.Location = New System.Drawing.Point(189, 95)
        Me.chkCancelado.Name = "chkCancelado"
        Me.chkCancelado.Size = New System.Drawing.Size(77, 17)
        Me.chkCancelado.TabIndex = 133
        Me.chkCancelado.Text = "Cancelado"
        Me.chkCancelado.UseVisualStyleBackColor = True
        '
        'chkVigente
        '
        Me.chkVigente.AutoSize = True
        Me.chkVigente.Checked = True
        Me.chkVigente.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVigente.Location = New System.Drawing.Point(127, 95)
        Me.chkVigente.Name = "chkVigente"
        Me.chkVigente.Size = New System.Drawing.Size(62, 17)
        Me.chkVigente.TabIndex = 132
        Me.chkVigente.Text = "Vigente"
        Me.chkVigente.UseVisualStyleBackColor = True
        '
        'chkPorFecha
        '
        Me.chkPorFecha.AutoSize = True
        Me.chkPorFecha.Location = New System.Drawing.Point(9, 0)
        Me.chkPorFecha.Name = "chkPorFecha"
        Me.chkPorFecha.Size = New System.Drawing.Size(81, 17)
        Me.chkPorFecha.TabIndex = 134
        Me.chkPorFecha.Text = "Por Fecha :"
        Me.chkPorFecha.UseVisualStyleBackColor = True
        '
        'frmBusquedaRecepcionPesadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 423)
        Me.Controls.Add(Me.chkCancelado)
        Me.Controls.Add(Me.chkVigente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtProveedor)
        Me.Controls.Add(Me.cmbProveedor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.dgvRecepcionPesadas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mtb)
        Me.Name = "frmBusquedaRecepcionPesadas"
        Me.Text = "BÚSQUEDA DE RECEPCION DE PESADAS"
        CType(Me.dgvRecepcionPesadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvRecepcionPesadas As System.Windows.Forms.DataGridView
    Friend WithEvents txtFolio As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtProveedor As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents cmbProveedor As Integralab.Controles.ComboBoxMejorado
    Friend WithEvents RecepcionGanadoColeccion1 As ClasesNegocio.RecepcionGanadoColeccion
    Friend WithEvents FolioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosRecibidosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosCompEnvDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalCabezasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kilos1PesadaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kilos2PesadaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProveedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConductorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlacasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesRecepcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkCancelado As System.Windows.Forms.CheckBox
    Friend WithEvents chkVigente As System.Windows.Forms.CheckBox
    Friend WithEvents clmLoteRecepcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmKilosRecibidos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmKilosEnviados As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCantCabezas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmKilosSegundaPesada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmConductor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPlacas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmObservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTipoPesada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkPorFecha As System.Windows.Forms.CheckBox
End Class
