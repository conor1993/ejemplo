<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTraspasoCajasBusqueda
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtFolioTraspaso = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.gbRangoFechas = New System.Windows.Forms.GroupBox
        Me.dtFechaFin = New System.Windows.Forms.DateTimePicker
        Me.dtFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.chkFiltrarFecha = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.clmFolioTraspaso = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmAlmacenDestino = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPiezas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmKilos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFechaTraspaso = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIdAlmacenDestino = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.chkCancelados = New System.Windows.Forms.CheckBox
        Me.chkVigentes = New System.Windows.Forms.CheckBox
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmbAlmacenDestino = New Integralab.Controles.ComboBoxMejorado
        Me.gbRangoFechas.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
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
        Me.mtb.Size = New System.Drawing.Size(50, 580)
        Me.mtb.TabIndex = 82
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(878, 32)
        Me.Label17.TabIndex = 83
        Me.Label17.Text = "BUSQUEDA DE TRASPASOS DE CAJAS"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFolioTraspaso
        '
        Me.txtFolioTraspaso.Location = New System.Drawing.Point(160, 39)
        Me.txtFolioTraspaso.Name = "txtFolioTraspaso"
        Me.txtFolioTraspaso.Size = New System.Drawing.Size(100, 20)
        Me.txtFolioTraspaso.TabIndex = 84
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Folio Traspaso:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "Almacén Destino:"
        '
        'gbRangoFechas
        '
        Me.gbRangoFechas.Controls.Add(Me.dtFechaFin)
        Me.gbRangoFechas.Controls.Add(Me.dtFechaInicial)
        Me.gbRangoFechas.Controls.Add(Me.Label3)
        Me.gbRangoFechas.Controls.Add(Me.Label2)
        Me.gbRangoFechas.Location = New System.Drawing.Point(537, 39)
        Me.gbRangoFechas.Name = "gbRangoFechas"
        Me.gbRangoFechas.Size = New System.Drawing.Size(182, 76)
        Me.gbRangoFechas.TabIndex = 96
        Me.gbRangoFechas.TabStop = False
        Me.gbRangoFechas.Text = "Rango de Fechas"
        '
        'dtFechaFin
        '
        Me.dtFechaFin.Enabled = False
        Me.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaFin.Location = New System.Drawing.Point(81, 45)
        Me.dtFechaFin.Name = "dtFechaFin"
        Me.dtFechaFin.Size = New System.Drawing.Size(92, 20)
        Me.dtFechaFin.TabIndex = 3
        '
        'dtFechaInicial
        '
        Me.dtFechaInicial.Enabled = False
        Me.dtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaInicial.Location = New System.Drawing.Point(81, 19)
        Me.dtFechaInicial.Name = "dtFechaInicial"
        Me.dtFechaInicial.Size = New System.Drawing.Size(92, 20)
        Me.dtFechaInicial.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Fecha Fin:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fecha Inicio:"
        '
        'chkFiltrarFecha
        '
        Me.chkFiltrarFecha.AutoSize = True
        Me.chkFiltrarFecha.Location = New System.Drawing.Point(428, 39)
        Me.chkFiltrarFecha.Name = "chkFiltrarFecha"
        Me.chkFiltrarFecha.Size = New System.Drawing.Size(103, 17)
        Me.chkFiltrarFecha.TabIndex = 97
        Me.chkFiltrarFecha.Text = "Filtrar Por Fecha"
        Me.chkFiltrarFecha.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(56, 121)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(860, 418)
        Me.GroupBox2.TabIndex = 98
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultado de la busqueda"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmFolioTraspaso, Me.clmAlmacenDestino, Me.clmPiezas, Me.clmKilos, Me.clmFechaTraspaso, Me.clmEstatus, Me.clmIdAlmacenDestino})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(848, 393)
        Me.DataGridView1.TabIndex = 0
        '
        'clmFolioTraspaso
        '
        Me.clmFolioTraspaso.DataPropertyName = "FolioTransferencia"
        Me.clmFolioTraspaso.HeaderText = "Folio Traspaso"
        Me.clmFolioTraspaso.Name = "clmFolioTraspaso"
        Me.clmFolioTraspaso.ReadOnly = True
        '
        'clmAlmacenDestino
        '
        Me.clmAlmacenDestino.DataPropertyName = "Almacen"
        Me.clmAlmacenDestino.HeaderText = "Almacen Destino"
        Me.clmAlmacenDestino.Name = "clmAlmacenDestino"
        Me.clmAlmacenDestino.ReadOnly = True
        '
        'clmPiezas
        '
        Me.clmPiezas.DataPropertyName = "Piezas"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.clmPiezas.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmPiezas.HeaderText = "Piezas"
        Me.clmPiezas.Name = "clmPiezas"
        Me.clmPiezas.ReadOnly = True
        '
        'clmKilos
        '
        Me.clmKilos.DataPropertyName = "Kilos"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.clmKilos.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmKilos.HeaderText = "Kilos"
        Me.clmKilos.Name = "clmKilos"
        Me.clmKilos.ReadOnly = True
        '
        'clmFechaTraspaso
        '
        Me.clmFechaTraspaso.DataPropertyName = "FechaMovimiento"
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.clmFechaTraspaso.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmFechaTraspaso.HeaderText = "Fecha Traspaso"
        Me.clmFechaTraspaso.Name = "clmFechaTraspaso"
        Me.clmFechaTraspaso.ReadOnly = True
        '
        'clmEstatus
        '
        Me.clmEstatus.DataPropertyName = "EstatusCad"
        Me.clmEstatus.HeaderText = "Estatus"
        Me.clmEstatus.Name = "clmEstatus"
        Me.clmEstatus.ReadOnly = True
        '
        'clmIdAlmacenDestino
        '
        Me.clmIdAlmacenDestino.DataPropertyName = "IdAlmacenDestino"
        Me.clmIdAlmacenDestino.HeaderText = "Id Almacen Destino"
        Me.clmIdAlmacenDestino.Name = "clmIdAlmacenDestino"
        Me.clmIdAlmacenDestino.ReadOnly = True
        Me.clmIdAlmacenDestino.Visible = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Location = New System.Drawing.Point(754, 545)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 99
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Location = New System.Drawing.Point(835, 545)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 100
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkCancelados)
        Me.GroupBox3.Controls.Add(Me.chkVigentes)
        Me.GroupBox3.Location = New System.Drawing.Point(725, 39)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(104, 76)
        Me.GroupBox3.TabIndex = 101
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Estatus"
        '
        'chkCancelados
        '
        Me.chkCancelados.AutoSize = True
        Me.chkCancelados.Location = New System.Drawing.Point(7, 42)
        Me.chkCancelados.Name = "chkCancelados"
        Me.chkCancelados.Size = New System.Drawing.Size(82, 17)
        Me.chkCancelados.TabIndex = 1
        Me.chkCancelados.Text = "Cancelados"
        Me.chkCancelados.UseVisualStyleBackColor = True
        '
        'chkVigentes
        '
        Me.chkVigentes.AutoSize = True
        Me.chkVigentes.Location = New System.Drawing.Point(7, 19)
        Me.chkVigentes.Name = "chkVigentes"
        Me.chkVigentes.Size = New System.Drawing.Size(67, 17)
        Me.chkVigentes.TabIndex = 0
        Me.chkVigentes.Text = "Vigentes"
        Me.chkVigentes.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Folio Traspaso"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Almacen Destino"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn3.HeaderText = "Piezas"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn4.HeaderText = "Kilos"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        DataGridViewCellStyle6.Format = "d"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn5.HeaderText = "Fecha Traspaso"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Estatus"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Id Almacen Destino"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'cmbAlmacenDestino
        '
        Me.cmbAlmacenDestino.DisplayMember = "Descripcion"
        Me.cmbAlmacenDestino.FormattingEnabled = True
        Me.cmbAlmacenDestino.Location = New System.Drawing.Point(160, 65)
        Me.cmbAlmacenDestino.Name = "cmbAlmacenDestino"
        Me.cmbAlmacenDestino.NombreMetodo = Nothing
        Me.cmbAlmacenDestino.Parametros = Nothing
        Me.cmbAlmacenDestino.SiguienteControl = Nothing
        Me.cmbAlmacenDestino.Size = New System.Drawing.Size(371, 21)
        Me.cmbAlmacenDestino.TabIndex = 95
        Me.cmbAlmacenDestino.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbAlmacenDestino.TextBoxEnlazado = Nothing
        Me.cmbAlmacenDestino.ValueMember = "Codigo"
        '
        'frmTraspasoCajasBusqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 580)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.chkFiltrarFecha)
        Me.Controls.Add(Me.gbRangoFechas)
        Me.Controls.Add(Me.cmbAlmacenDestino)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFolioTraspaso)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.Name = "frmTraspasoCajasBusqueda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busaqueda De Traspasos De Cajas"
        Me.gbRangoFechas.ResumeLayout(False)
        Me.gbRangoFechas.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtFolioTraspaso As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbAlmacenDestino As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gbRangoFechas As System.Windows.Forms.GroupBox
    Friend WithEvents dtFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkFiltrarFecha As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCancelados As System.Windows.Forms.CheckBox
    Friend WithEvents chkVigentes As System.Windows.Forms.CheckBox
    Friend WithEvents clmFolioTraspaso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmAlmacenDestino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPiezas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmKilos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaTraspaso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdAlmacenDestino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
