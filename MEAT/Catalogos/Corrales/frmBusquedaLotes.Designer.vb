<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaLotes
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label4 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCodigoLote = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.dtFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.dtFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.gbRangoFechas = New System.Windows.Forms.GroupBox
        Me.chkFiltrarFecha = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgLotes = New System.Windows.Forms.DataGridView
        Me.LotesCabC = New ClasesNegocio.LoteCollectionClass
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbCorral = New System.Windows.Forms.ComboBox
        Me.CorralesC = New ClasesNegocio.CorralColecttionClass
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.FechaCierreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaInicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PesoEstimadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GDPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CorralDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescCortaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdLoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gbRangoFechas.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgLotes, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label4.Size = New System.Drawing.Size(920, 32)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "BUSQUEDA DE LOTES"
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
        Me.mtb.Size = New System.Drawing.Size(50, 555)
        Me.mtb.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Lote:"
        '
        'txtCodigoLote
        '
        Me.txtCodigoLote.Location = New System.Drawing.Point(122, 35)
        Me.txtCodigoLote.MaxLength = 4
        Me.txtCodigoLote.Name = "txtCodigoLote"
        Me.txtCodigoLote.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigoLote.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Descripción:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(122, 61)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(355, 20)
        Me.txtDescripcion.TabIndex = 56
        '
        'dtFechaInicial
        '
        Me.dtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaInicial.Location = New System.Drawing.Point(82, 19)
        Me.dtFechaInicial.Name = "dtFechaInicial"
        Me.dtFechaInicial.Size = New System.Drawing.Size(98, 20)
        Me.dtFechaInicial.TabIndex = 57
        '
        'dtFechaFinal
        '
        Me.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaFinal.Location = New System.Drawing.Point(82, 45)
        Me.dtFechaFinal.Name = "dtFechaFinal"
        Me.dtFechaFinal.Size = New System.Drawing.Size(98, 20)
        Me.dtFechaFinal.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Fecha Inicial:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Fecha Final:"
        '
        'gbRangoFechas
        '
        Me.gbRangoFechas.Controls.Add(Me.Label3)
        Me.gbRangoFechas.Controls.Add(Me.Label5)
        Me.gbRangoFechas.Controls.Add(Me.dtFechaInicial)
        Me.gbRangoFechas.Controls.Add(Me.dtFechaFinal)
        Me.gbRangoFechas.Controls.Add(Me.chkFiltrarFecha)
        Me.gbRangoFechas.Location = New System.Drawing.Point(483, 38)
        Me.gbRangoFechas.Name = "gbRangoFechas"
        Me.gbRangoFechas.Size = New System.Drawing.Size(186, 70)
        Me.gbRangoFechas.TabIndex = 61
        Me.gbRangoFechas.TabStop = False
        '
        'chkFiltrarFecha
        '
        Me.chkFiltrarFecha.AutoSize = True
        Me.chkFiltrarFecha.Location = New System.Drawing.Point(7, -1)
        Me.chkFiltrarFecha.Name = "chkFiltrarFecha"
        Me.chkFiltrarFecha.Size = New System.Drawing.Size(103, 17)
        Me.chkFiltrarFecha.TabIndex = 62
        Me.chkFiltrarFecha.Text = "Filtrar Por Fecha"
        Me.chkFiltrarFecha.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgLotes)
        Me.GroupBox1.Location = New System.Drawing.Point(53, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(905, 400)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lotes Encontrados"
        '
        'dgLotes
        '
        Me.dgLotes.AllowUserToAddRows = False
        Me.dgLotes.AllowUserToResizeRows = False
        Me.dgLotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgLotes.AutoGenerateColumns = False
        Me.dgLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdLoteDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.DescCortaDataGridViewTextBoxColumn, Me.CorralDataGridViewTextBoxColumn, Me.GDPDataGridViewTextBoxColumn, Me.PesoEstimadoDataGridViewTextBoxColumn, Me.FechaInicioDataGridViewTextBoxColumn, Me.FechaCierreDataGridViewTextBoxColumn})
        Me.dgLotes.DataSource = Me.LotesCabC
        Me.dgLotes.Location = New System.Drawing.Point(6, 19)
        Me.dgLotes.Name = "dgLotes"
        Me.dgLotes.ReadOnly = True
        Me.dgLotes.RowHeadersVisible = False
        Me.dgLotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgLotes.Size = New System.Drawing.Size(893, 375)
        Me.dgLotes.TabIndex = 0
        '
        'LotesCabC
        '
        Me.LotesCabC.AllowEdit = True
        Me.LotesCabC.AllowNew = True
        Me.LotesCabC.AllowRemove = True
        Me.LotesCabC.MaximoElementosSeleccionados = 1
        Me.LotesCabC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.LotesCabC.MostrarAlertas = False
        Me.LotesCabC.Name = Nothing
        Me.LotesCabC.RaiseListChangedEvents = True
        Me.LotesCabC.Transaction = Nothing
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(51, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Corral:"
        '
        'cmbCorral
        '
        Me.cmbCorral.DataSource = Me.CorralesC
        Me.cmbCorral.DisplayMember = "Descripcion"
        Me.cmbCorral.FormattingEnabled = True
        Me.cmbCorral.Location = New System.Drawing.Point(122, 87)
        Me.cmbCorral.Name = "cmbCorral"
        Me.cmbCorral.Size = New System.Drawing.Size(355, 21)
        Me.cmbCorral.TabIndex = 65
        Me.cmbCorral.ValueMember = "IdCorral"
        '
        'CorralesC
        '
        Me.CorralesC.AllowEdit = True
        Me.CorralesC.AllowNew = True
        Me.CorralesC.AllowRemove = True
        Me.CorralesC.MaximoElementosSeleccionados = 1
        Me.CorralesC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.CorralesC.MostrarAlertas = False
        Me.CorralesC.Name = Nothing
        Me.CorralesC.RaiseListChangedEvents = True
        Me.CorralesC.Transaction = Nothing
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(802, 520)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 66
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(883, 520)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 67
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'FechaCierreDataGridViewTextBoxColumn
        '
        Me.FechaCierreDataGridViewTextBoxColumn.DataPropertyName = "FechaCierre"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.FechaCierreDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.FechaCierreDataGridViewTextBoxColumn.HeaderText = "Fecha Cierre"
        Me.FechaCierreDataGridViewTextBoxColumn.Name = "FechaCierreDataGridViewTextBoxColumn"
        Me.FechaCierreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaInicioDataGridViewTextBoxColumn
        '
        Me.FechaInicioDataGridViewTextBoxColumn.DataPropertyName = "FechaInicio"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.FechaInicioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.FechaInicioDataGridViewTextBoxColumn.HeaderText = "Fecha Inicio"
        Me.FechaInicioDataGridViewTextBoxColumn.Name = "FechaInicioDataGridViewTextBoxColumn"
        Me.FechaInicioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PesoEstimadoDataGridViewTextBoxColumn
        '
        Me.PesoEstimadoDataGridViewTextBoxColumn.DataPropertyName = "PesoEstimado"
        DataGridViewCellStyle2.Format = "N3"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.PesoEstimadoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.PesoEstimadoDataGridViewTextBoxColumn.HeaderText = "Peso Proyectado"
        Me.PesoEstimadoDataGridViewTextBoxColumn.Name = "PesoEstimadoDataGridViewTextBoxColumn"
        Me.PesoEstimadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GDPDataGridViewTextBoxColumn
        '
        Me.GDPDataGridViewTextBoxColumn.DataPropertyName = "GDP"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N3"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.GDPDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.GDPDataGridViewTextBoxColumn.HeaderText = "GDP"
        Me.GDPDataGridViewTextBoxColumn.Name = "GDPDataGridViewTextBoxColumn"
        Me.GDPDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CorralDataGridViewTextBoxColumn
        '
        Me.CorralDataGridViewTextBoxColumn.DataPropertyName = "Corral"
        Me.CorralDataGridViewTextBoxColumn.HeaderText = "Corral"
        Me.CorralDataGridViewTextBoxColumn.Name = "CorralDataGridViewTextBoxColumn"
        Me.CorralDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescCortaDataGridViewTextBoxColumn
        '
        Me.DescCortaDataGridViewTextBoxColumn.DataPropertyName = "DescCorta"
        Me.DescCortaDataGridViewTextBoxColumn.HeaderText = "Descripción Corta"
        Me.DescCortaDataGridViewTextBoxColumn.Name = "DescCortaDataGridViewTextBoxColumn"
        Me.DescCortaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdLoteDataGridViewTextBoxColumn
        '
        Me.IdLoteDataGridViewTextBoxColumn.DataPropertyName = "IdLote"
        Me.IdLoteDataGridViewTextBoxColumn.HeaderText = "Lote"
        Me.IdLoteDataGridViewTextBoxColumn.Name = "IdLoteDataGridViewTextBoxColumn"
        Me.IdLoteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmBusquedaLotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 555)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.cmbCorral)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbRangoFechas)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodigoLote)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.mtb)
        Me.Name = "frmBusquedaLotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de Lotes"
        Me.gbRangoFechas.ResumeLayout(False)
        Me.gbRangoFechas.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgLotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoLote As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents dtFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gbRangoFechas As System.Windows.Forms.GroupBox
    Friend WithEvents chkFiltrarFecha As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgLotes As System.Windows.Forms.DataGridView
    Friend WithEvents LotesCabC As ClasesNegocio.LoteCollectionClass
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbCorral As System.Windows.Forms.ComboBox
    Friend WithEvents CorralesC As ClasesNegocio.CorralColecttionClass
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents IdLoteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescCortaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CorralDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GDPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PesoEstimadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaInicioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaCierreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
