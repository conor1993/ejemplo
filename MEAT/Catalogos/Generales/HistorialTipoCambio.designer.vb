<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistorialTipoCambio
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
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.txtTipoMoneda = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtFechaIni = New System.Windows.Forms.DateTimePicker
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.pan = New System.Windows.Forms.Panel
        Me.grpFechas = New System.Windows.Forms.GroupBox
        Me.dtFechaFin = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.chkFecha = New System.Windows.Forms.CheckBox
        Me.cmbTipoMoneda = New System.Windows.Forms.ComboBox
        Me.TiposMoneda = New ClasesNegocio.TipoMonedaCollectionClass
        Me.gpo = New System.Windows.Forms.GroupBox
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.TipoMonedaDataGridViewTextBoxComlumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoCambioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TiposCambio = New ClasesNegocio.TipoCambioCollectionClass
        Me.pan.SuspendLayout()
        Me.grpFechas.SuspendLayout()
        Me.gpo.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(50, 0)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(470, 30)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "TIPOS DE CAMBIO"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTipoMoneda
        '
        Me.txtTipoMoneda.Location = New System.Drawing.Point(102, 6)
        Me.txtTipoMoneda.MaxLength = 20
        Me.txtTipoMoneda.Name = "txtTipoMoneda"
        Me.txtTipoMoneda.Size = New System.Drawing.Size(58, 20)
        Me.txtTipoMoneda.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Moneda:"
        '
        'dtFechaIni
        '
        Me.dtFechaIni.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtFechaIni.Enabled = False
        Me.dtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaIni.Location = New System.Drawing.Point(50, 21)
        Me.dtFechaIni.Name = "dtFechaIni"
        Me.dtFechaIni.Size = New System.Drawing.Size(113, 20)
        Me.dtFechaIni.TabIndex = 8
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
        Me.mtb.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
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
        Me.mtb.Size = New System.Drawing.Size(50, 509)
        Me.mtb.TabIndex = 9
        '
        'pan
        '
        Me.pan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pan.Controls.Add(Me.grpFechas)
        Me.pan.Controls.Add(Me.Label1)
        Me.pan.Controls.Add(Me.txtTipoMoneda)
        Me.pan.Controls.Add(Me.cmbTipoMoneda)
        Me.pan.Location = New System.Drawing.Point(53, 31)
        Me.pan.Name = "pan"
        Me.pan.Size = New System.Drawing.Size(455, 114)
        Me.pan.TabIndex = 10
        '
        'grpFechas
        '
        Me.grpFechas.Controls.Add(Me.dtFechaFin)
        Me.grpFechas.Controls.Add(Me.Label4)
        Me.grpFechas.Controls.Add(Me.Label3)
        Me.grpFechas.Controls.Add(Me.dtFechaIni)
        Me.grpFechas.Controls.Add(Me.chkFecha)
        Me.grpFechas.Location = New System.Drawing.Point(15, 32)
        Me.grpFechas.Name = "grpFechas"
        Me.grpFechas.Size = New System.Drawing.Size(169, 74)
        Me.grpFechas.TabIndex = 10
        Me.grpFechas.TabStop = False
        Me.grpFechas.Text = "Rango de Fechas"
        '
        'dtFechaFin
        '
        Me.dtFechaFin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtFechaFin.Enabled = False
        Me.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaFin.Location = New System.Drawing.Point(50, 45)
        Me.dtFechaFin.Name = "dtFechaFin"
        Me.dtFechaFin.Size = New System.Drawing.Size(113, 20)
        Me.dtFechaFin.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Final:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Inicial:"
        '
        'chkFecha
        '
        Me.chkFecha.AutoSize = True
        Me.chkFecha.Location = New System.Drawing.Point(6, 0)
        Me.chkFecha.Name = "chkFecha"
        Me.chkFecha.Size = New System.Drawing.Size(105, 17)
        Me.chkFecha.TabIndex = 9
        Me.chkFecha.Text = "Filtrar por Fecha:"
        Me.chkFecha.UseVisualStyleBackColor = True
        '
        'cmbTipoMoneda
        '
        Me.cmbTipoMoneda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbTipoMoneda.DataSource = Me.TiposMoneda
        Me.cmbTipoMoneda.DisplayMember = "Descripcion"
        Me.cmbTipoMoneda.FormattingEnabled = True
        Me.cmbTipoMoneda.Location = New System.Drawing.Point(166, 6)
        Me.cmbTipoMoneda.Name = "cmbTipoMoneda"
        Me.cmbTipoMoneda.Size = New System.Drawing.Size(276, 21)
        Me.cmbTipoMoneda.TabIndex = 4
        Me.cmbTipoMoneda.ValueMember = "Codigo"
        '
        'TiposMoneda
        '
        Me.TiposMoneda.AllowEdit = True
        Me.TiposMoneda.AllowNew = True
        Me.TiposMoneda.AllowRemove = True
        Me.TiposMoneda.MaximoElementosSeleccionados = 1
        Me.TiposMoneda.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.TiposMoneda.MostrarAlertas = False
        Me.TiposMoneda.Name = ""
        Me.TiposMoneda.RaiseListChangedEvents = True
        Me.TiposMoneda.Transaction = Nothing
        '
        'gpo
        '
        Me.gpo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpo.Controls.Add(Me.dgv)
        Me.gpo.Location = New System.Drawing.Point(53, 151)
        Me.gpo.Name = "gpo"
        Me.gpo.Size = New System.Drawing.Size(455, 346)
        Me.gpo.TabIndex = 11
        Me.gpo.TabStop = False
        Me.gpo.Text = "Tipos de Cambio de la Moneda"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeRows = False
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.AutoGenerateColumns = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TipoMonedaDataGridViewTextBoxComlumn, Me.TipoCambioDataGridViewTextBoxColumn, Me.clmFecha})
        Me.dgv.DataSource = Me.TiposCambio
        Me.dgv.Location = New System.Drawing.Point(6, 19)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(443, 321)
        Me.dgv.TabIndex = 0
        '
        'TipoMonedaDataGridViewTextBoxComlumn
        '
        Me.TipoMonedaDataGridViewTextBoxComlumn.DataPropertyName = "TipoMoneda"
        Me.TipoMonedaDataGridViewTextBoxComlumn.HeaderText = "Moneda"
        Me.TipoMonedaDataGridViewTextBoxComlumn.Name = "TipoMonedaDataGridViewTextBoxComlumn"
        Me.TipoMonedaDataGridViewTextBoxComlumn.ReadOnly = True
        Me.TipoMonedaDataGridViewTextBoxComlumn.Width = 160
        '
        'TipoCambioDataGridViewTextBoxColumn
        '
        Me.TipoCambioDataGridViewTextBoxColumn.DataPropertyName = "TipoCambio"
        DataGridViewCellStyle1.Format = "C4"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.TipoCambioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.TipoCambioDataGridViewTextBoxColumn.HeaderText = "Tipo de Cambio"
        Me.TipoCambioDataGridViewTextBoxColumn.Name = "TipoCambioDataGridViewTextBoxColumn"
        Me.TipoCambioDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoCambioDataGridViewTextBoxColumn.Width = 150
        '
        'clmFecha
        '
        Me.clmFecha.DataPropertyName = "Fecha"
        DataGridViewCellStyle2.Format = "d"
        Me.clmFecha.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmFecha.HeaderText = "Fecha"
        Me.clmFecha.Name = "clmFecha"
        Me.clmFecha.ReadOnly = True
        Me.clmFecha.Width = 90
        '
        'TiposCambio
        '
        Me.TiposCambio.AllowEdit = True
        Me.TiposCambio.AllowNew = True
        Me.TiposCambio.AllowRemove = True
        Me.TiposCambio.MaximoElementosSeleccionados = 1
        Me.TiposCambio.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.TiposCambio.MostrarAlertas = False
        Me.TiposCambio.Name = Nothing
        Me.TiposCambio.RaiseListChangedEvents = True
        Me.TiposCambio.Transaction = Nothing
        '
        'HistorialTipoCambio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 509)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.gpo)
        Me.Controls.Add(Me.pan)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "HistorialTipoCambio"
        Me.Text = "Tipos de Cambio de Moneda"
        Me.pan.ResumeLayout(False)
        Me.pan.PerformLayout()
        Me.grpFechas.ResumeLayout(False)
        Me.grpFechas.PerformLayout()
        Me.gpo.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents txtTipoMoneda As System.Windows.Forms.TextBox
    Friend WithEvents cmbTipoMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents pan As System.Windows.Forms.Panel
    Friend WithEvents gpo As System.Windows.Forms.GroupBox
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents TiposCambio As ClasesNegocio.TipoCambioCollectionClass
    Friend WithEvents TiposMoneda As ClasesNegocio.TipoMonedaCollectionClass
    Friend WithEvents chkFecha As System.Windows.Forms.CheckBox
    Friend WithEvents grpFechas As System.Windows.Forms.GroupBox
    Friend WithEvents dtFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TipoMonedaDataGridViewTextBoxComlumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoCambioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFecha As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
