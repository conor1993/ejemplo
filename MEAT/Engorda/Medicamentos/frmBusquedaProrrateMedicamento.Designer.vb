<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaProrrateMedicamento
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Label17 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.chkCancelado = New System.Windows.Forms.CheckBox
        Me.chkContabilizado = New System.Windows.Forms.CheckBox
        Me.chkVigente = New System.Windows.Forms.CheckBox
        Me.cmbAlmacen = New Integralab.Controles.ComboBoxMejorado
        Me.txtCodigoAlmacen = New Integralab.Controles.TextBoxMejorado
        Me.chkFiltrar = New System.Windows.Forms.CheckBox
        Me.gbRangoFechas = New System.Windows.Forms.GroupBox
        Me.dtFechaFin = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtFolio = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgResultado = New System.Windows.Forms.DataGridView
        Me.vwBusquedaProrrateo = New Integralab.ORM.TypedViewClasses.VwBusquedaProrrateoMedicamentoTypedView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.FolioProrrateoMedicamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AlmacenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FolioMovimientoAlmacenSalidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaProrrateoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostoTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstatusStrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox3.SuspendLayout()
        Me.gbRangoFechas.SuspendLayout()
        CType(Me.dgResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vwBusquedaProrrateo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.MaximumSize = New System.Drawing.Size(1600, 900)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(888, 29)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "BUSQUEDA PRORRATEO DE MEDICAMENTOS"
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
        Me.mtb.Size = New System.Drawing.Size(50, 474)
        Me.mtb.TabIndex = 20
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkCancelado)
        Me.GroupBox3.Controls.Add(Me.chkContabilizado)
        Me.GroupBox3.Controls.Add(Me.chkVigente)
        Me.GroupBox3.Location = New System.Drawing.Point(696, 35)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(115, 90)
        Me.GroupBox3.TabIndex = 41
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Estatus"
        '
        'chkCancelado
        '
        Me.chkCancelado.AutoSize = True
        Me.chkCancelado.Location = New System.Drawing.Point(6, 64)
        Me.chkCancelado.Name = "chkCancelado"
        Me.chkCancelado.Size = New System.Drawing.Size(77, 17)
        Me.chkCancelado.TabIndex = 2
        Me.chkCancelado.Text = "Cancelado"
        Me.chkCancelado.UseVisualStyleBackColor = True
        '
        'chkContabilizado
        '
        Me.chkContabilizado.AutoSize = True
        Me.chkContabilizado.Location = New System.Drawing.Point(6, 41)
        Me.chkContabilizado.Name = "chkContabilizado"
        Me.chkContabilizado.Size = New System.Drawing.Size(89, 17)
        Me.chkContabilizado.TabIndex = 1
        Me.chkContabilizado.Text = "Contabilizado"
        Me.chkContabilizado.UseVisualStyleBackColor = True
        '
        'chkVigente
        '
        Me.chkVigente.AutoSize = True
        Me.chkVigente.Location = New System.Drawing.Point(6, 18)
        Me.chkVigente.Name = "chkVigente"
        Me.chkVigente.Size = New System.Drawing.Size(62, 17)
        Me.chkVigente.TabIndex = 0
        Me.chkVigente.Text = "Vigente"
        Me.chkVigente.UseVisualStyleBackColor = True
        '
        'cmbAlmacen
        '
        Me.cmbAlmacen.FormattingEnabled = True
        Me.cmbAlmacen.Location = New System.Drawing.Point(165, 63)
        Me.cmbAlmacen.Name = "cmbAlmacen"
        Me.cmbAlmacen.NombreMetodo = Nothing
        Me.cmbAlmacen.Parametros = Nothing
        Me.cmbAlmacen.SiguienteControl = Nothing
        Me.cmbAlmacen.Size = New System.Drawing.Size(346, 21)
        Me.cmbAlmacen.TabIndex = 38
        Me.cmbAlmacen.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbAlmacen.TextBoxEnlazado = Me.txtCodigoAlmacen
        '
        'txtCodigoAlmacen
        '
        Me.txtCodigoAlmacen.ComboBoxEnlazado = Me.cmbAlmacen
        Me.txtCodigoAlmacen.Decimales = 0
        Me.txtCodigoAlmacen.Location = New System.Drawing.Point(106, 63)
        Me.txtCodigoAlmacen.MaxLength = 3000
        Me.txtCodigoAlmacen.MensajeCombo = "Seleccionar un almacén..."
        Me.txtCodigoAlmacen.MensajeNoExiste = "No existe un almacén con este código o se encuentra inactivo"
        Me.txtCodigoAlmacen.Name = "txtCodigoAlmacen"
        Me.txtCodigoAlmacen.SiguienteControl = Nothing
        Me.txtCodigoAlmacen.Size = New System.Drawing.Size(53, 20)
        Me.txtCodigoAlmacen.TabIndex = 37
        Me.txtCodigoAlmacen.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtCodigoAlmacen.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCodigoAlmacen.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'chkFiltrar
        '
        Me.chkFiltrar.AutoSize = True
        Me.chkFiltrar.Location = New System.Drawing.Point(517, 35)
        Me.chkFiltrar.Name = "chkFiltrar"
        Me.chkFiltrar.Size = New System.Drawing.Size(89, 17)
        Me.chkFiltrar.TabIndex = 40
        Me.chkFiltrar.Text = "Filtrar Fechas"
        Me.chkFiltrar.UseVisualStyleBackColor = True
        '
        'gbRangoFechas
        '
        Me.gbRangoFechas.Controls.Add(Me.dtFechaFin)
        Me.gbRangoFechas.Controls.Add(Me.Label3)
        Me.gbRangoFechas.Controls.Add(Me.dtFechaInicio)
        Me.gbRangoFechas.Controls.Add(Me.Label2)
        Me.gbRangoFechas.Location = New System.Drawing.Point(517, 55)
        Me.gbRangoFechas.Name = "gbRangoFechas"
        Me.gbRangoFechas.Size = New System.Drawing.Size(173, 70)
        Me.gbRangoFechas.TabIndex = 39
        Me.gbRangoFechas.TabStop = False
        Me.gbRangoFechas.Text = "Rango Fechas"
        '
        'dtFechaFin
        '
        Me.dtFechaFin.CustomFormat = "dd/MMM/yyyy"
        Me.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFechaFin.Location = New System.Drawing.Point(52, 44)
        Me.dtFechaFin.Name = "dtFechaFin"
        Me.dtFechaFin.Size = New System.Drawing.Size(110, 20)
        Me.dtFechaFin.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Fin:"
        '
        'dtFechaInicio
        '
        Me.dtFechaInicio.CustomFormat = "dd/MMM/yyyy"
        Me.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFechaInicio.Location = New System.Drawing.Point(52, 18)
        Me.dtFechaInicio.Name = "dtFechaInicio"
        Me.dtFechaInicio.Size = New System.Drawing.Size(110, 20)
        Me.dtFechaInicio.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Inicio:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(49, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Almacén:"
        '
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(106, 37)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(137, 20)
        Me.txtFolio.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Folio:"
        '
        'dgResultado
        '
        Me.dgResultado.AllowUserToAddRows = False
        Me.dgResultado.AllowUserToDeleteRows = False
        Me.dgResultado.AllowUserToResizeRows = False
        Me.dgResultado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgResultado.AutoGenerateColumns = False
        Me.dgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgResultado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FolioProrrateoMedicamentoDataGridViewTextBoxColumn, Me.AlmacenDataGridViewTextBoxColumn, Me.FolioMovimientoAlmacenSalidaDataGridViewTextBoxColumn, Me.FechaProrrateoDataGridViewTextBoxColumn, Me.CostoTotalDataGridViewTextBoxColumn, Me.EstatusStrDataGridViewTextBoxColumn})
        Me.dgResultado.DataSource = Me.vwBusquedaProrrateo
        Me.dgResultado.Location = New System.Drawing.Point(6, 19)
        Me.dgResultado.Name = "dgResultado"
        Me.dgResultado.ReadOnly = True
        Me.dgResultado.RowHeadersVisible = False
        Me.dgResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgResultado.Size = New System.Drawing.Size(865, 275)
        Me.dgResultado.TabIndex = 16
        '
        'vwBusquedaProrrateo
        '
        Me.vwBusquedaProrrateo.TableName = "VwBusquedaProrrateoMedicamento"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.dgResultado)
        Me.GroupBox2.Location = New System.Drawing.Point(49, 131)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(877, 300)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultado Busqueda"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Location = New System.Drawing.Point(851, 437)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 34
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Location = New System.Drawing.Point(770, 437)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 33
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'FolioProrrateoMedicamentoDataGridViewTextBoxColumn
        '
        Me.FolioProrrateoMedicamentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.FolioProrrateoMedicamentoDataGridViewTextBoxColumn.DataPropertyName = "FolioProrrateoMedicamento"
        Me.FolioProrrateoMedicamentoDataGridViewTextBoxColumn.HeaderText = "Folio"
        Me.FolioProrrateoMedicamentoDataGridViewTextBoxColumn.Name = "FolioProrrateoMedicamentoDataGridViewTextBoxColumn"
        Me.FolioProrrateoMedicamentoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FolioProrrateoMedicamentoDataGridViewTextBoxColumn.Width = 54
        '
        'AlmacenDataGridViewTextBoxColumn
        '
        Me.AlmacenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.AlmacenDataGridViewTextBoxColumn.DataPropertyName = "Almacen"
        Me.AlmacenDataGridViewTextBoxColumn.HeaderText = "Almacén"
        Me.AlmacenDataGridViewTextBoxColumn.Name = "AlmacenDataGridViewTextBoxColumn"
        Me.AlmacenDataGridViewTextBoxColumn.ReadOnly = True
        Me.AlmacenDataGridViewTextBoxColumn.Width = 73
        '
        'FolioMovimientoAlmacenSalidaDataGridViewTextBoxColumn
        '
        Me.FolioMovimientoAlmacenSalidaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.FolioMovimientoAlmacenSalidaDataGridViewTextBoxColumn.DataPropertyName = "FolioMovimientoAlmacenSalida"
        Me.FolioMovimientoAlmacenSalidaDataGridViewTextBoxColumn.HeaderText = "Folio Movimiento Almacén"
        Me.FolioMovimientoAlmacenSalidaDataGridViewTextBoxColumn.Name = "FolioMovimientoAlmacenSalidaDataGridViewTextBoxColumn"
        Me.FolioMovimientoAlmacenSalidaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FolioMovimientoAlmacenSalidaDataGridViewTextBoxColumn.Width = 142
        '
        'FechaProrrateoDataGridViewTextBoxColumn
        '
        Me.FechaProrrateoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.FechaProrrateoDataGridViewTextBoxColumn.DataPropertyName = "FechaProrrateo"
        Me.FechaProrrateoDataGridViewTextBoxColumn.HeaderText = "Fecha Prorrateo"
        Me.FechaProrrateoDataGridViewTextBoxColumn.Name = "FechaProrrateoDataGridViewTextBoxColumn"
        Me.FechaProrrateoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaProrrateoDataGridViewTextBoxColumn.Width = 99
        '
        'CostoTotalDataGridViewTextBoxColumn
        '
        Me.CostoTotalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CostoTotalDataGridViewTextBoxColumn.DataPropertyName = "CostoTotal"
        Me.CostoTotalDataGridViewTextBoxColumn.HeaderText = "Costo Total"
        Me.CostoTotalDataGridViewTextBoxColumn.Name = "CostoTotalDataGridViewTextBoxColumn"
        Me.CostoTotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.CostoTotalDataGridViewTextBoxColumn.Width = 79
        '
        'EstatusStrDataGridViewTextBoxColumn
        '
        Me.EstatusStrDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.EstatusStrDataGridViewTextBoxColumn.DataPropertyName = "EstatusStr"
        Me.EstatusStrDataGridViewTextBoxColumn.HeaderText = "Estatus"
        Me.EstatusStrDataGridViewTextBoxColumn.Name = "EstatusStrDataGridViewTextBoxColumn"
        Me.EstatusStrDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstatusStrDataGridViewTextBoxColumn.Width = 67
        '
        'frmBusquedaProrrateMedicamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(938, 474)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cmbAlmacen)
        Me.Controls.Add(Me.txtCodigoAlmacen)
        Me.Controls.Add(Me.chkFiltrar)
        Me.Controls.Add(Me.gbRangoFechas)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.MaximizeBox = False
        Me.Name = "frmBusquedaProrrateMedicamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda Prorrate de Medicamento"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.gbRangoFechas.ResumeLayout(False)
        Me.gbRangoFechas.PerformLayout()
        CType(Me.dgResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vwBusquedaProrrateo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCancelado As System.Windows.Forms.CheckBox
    Friend WithEvents chkContabilizado As System.Windows.Forms.CheckBox
    Friend WithEvents chkVigente As System.Windows.Forms.CheckBox
    Friend WithEvents cmbAlmacen As Integralab.Controles.ComboBoxMejorado
    Friend WithEvents txtCodigoAlmacen As Integralab.Controles.TextBoxMejorado
    Friend WithEvents chkFiltrar As System.Windows.Forms.CheckBox
    Friend WithEvents gbRangoFechas As System.Windows.Forms.GroupBox
    Friend WithEvents dtFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgResultado As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents vwBusquedaProrrateo As IntegraLab.ORM.TypedViewClasses.VwBusquedaProrrateoMedicamentoTypedView
    Friend WithEvents FolioProrrateoMedicamentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlmacenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FolioMovimientoAlmacenSalidaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaProrrateoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoTotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstatusStrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
