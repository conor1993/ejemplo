<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaAplicacionFormula
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label17 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.dtFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtFolio = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.gbRangoFechas = New System.Windows.Forms.GroupBox
        Me.dtFechaFin = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.chkFiltrar = New System.Windows.Forms.CheckBox
        Me.dgResultado = New System.Windows.Forms.DataGridView
        Me.FolAplFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaAplicacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CabezasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalServidasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstatusStrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdAlmacenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.aplicacionesFormulas = New Integralab.ORM.TypedViewClasses.VwBusquedaAplicacionFormulaTypedView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.cmbAlmacen = New Integralab.Controles.ComboBoxMejorado
        Me.txtCodigoAlmacen = New Integralab.Controles.TextBoxMejorado
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.chkCancelado = New System.Windows.Forms.CheckBox
        Me.chkContabilizado = New System.Windows.Forms.CheckBox
        Me.chkVigente = New System.Windows.Forms.CheckBox
        Me.gbRangoFechas.SuspendLayout()
        CType(Me.dgResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.aplicacionesFormulas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
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
        Me.Label17.Size = New System.Drawing.Size(858, 29)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "BUSQUEDA APLICACIÓN DE FORMULAS"
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
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 564)
        Me.mtb.TabIndex = 2
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
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(110, 37)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(137, 20)
        Me.txtFolio.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Folio:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(53, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Almacén:"
        '
        'gbRangoFechas
        '
        Me.gbRangoFechas.Controls.Add(Me.dtFechaFin)
        Me.gbRangoFechas.Controls.Add(Me.Label3)
        Me.gbRangoFechas.Controls.Add(Me.dtFechaInicio)
        Me.gbRangoFechas.Controls.Add(Me.Label2)
        Me.gbRangoFechas.Location = New System.Drawing.Point(521, 60)
        Me.gbRangoFechas.Name = "gbRangoFechas"
        Me.gbRangoFechas.Size = New System.Drawing.Size(173, 70)
        Me.gbRangoFechas.TabIndex = 14
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
        'chkFiltrar
        '
        Me.chkFiltrar.AutoSize = True
        Me.chkFiltrar.Location = New System.Drawing.Point(521, 40)
        Me.chkFiltrar.Name = "chkFiltrar"
        Me.chkFiltrar.Size = New System.Drawing.Size(89, 17)
        Me.chkFiltrar.TabIndex = 15
        Me.chkFiltrar.Text = "Filtrar Fechas"
        Me.chkFiltrar.UseVisualStyleBackColor = True
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
        Me.dgResultado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FolAplFDataGridViewTextBoxColumn, Me.FechaAplicacionDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.CabezasDataGridViewTextBoxColumn, Me.TotalServidasDataGridViewTextBoxColumn, Me.CostoDataGridViewTextBoxColumn, Me.EstatusStrDataGridViewTextBoxColumn, Me.EstatusDataGridViewTextBoxColumn, Me.IdAlmacenDataGridViewTextBoxColumn})
        Me.dgResultado.DataSource = Me.aplicacionesFormulas
        Me.dgResultado.Location = New System.Drawing.Point(6, 19)
        Me.dgResultado.Name = "dgResultado"
        Me.dgResultado.ReadOnly = True
        Me.dgResultado.RowHeadersVisible = False
        Me.dgResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgResultado.Size = New System.Drawing.Size(828, 362)
        Me.dgResultado.TabIndex = 16
        '
        'FolAplFDataGridViewTextBoxColumn
        '
        Me.FolAplFDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.FolAplFDataGridViewTextBoxColumn.DataPropertyName = "FolAplF"
        Me.FolAplFDataGridViewTextBoxColumn.HeaderText = "Folio Aplicación"
        Me.FolAplFDataGridViewTextBoxColumn.Name = "FolAplFDataGridViewTextBoxColumn"
        Me.FolAplFDataGridViewTextBoxColumn.ReadOnly = True
        Me.FolAplFDataGridViewTextBoxColumn.Width = 97
        '
        'FechaAplicacionDataGridViewTextBoxColumn
        '
        Me.FechaAplicacionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.FechaAplicacionDataGridViewTextBoxColumn.DataPropertyName = "FechaAplicacion"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.FechaAplicacionDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.FechaAplicacionDataGridViewTextBoxColumn.HeaderText = "Fecha Aplicación"
        Me.FechaAplicacionDataGridViewTextBoxColumn.Name = "FechaAplicacionDataGridViewTextBoxColumn"
        Me.FechaAplicacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaAplicacionDataGridViewTextBoxColumn.Width = 105
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Almacén"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 73
        '
        'CabezasDataGridViewTextBoxColumn
        '
        Me.CabezasDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CabezasDataGridViewTextBoxColumn.DataPropertyName = "Cabezas"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.CabezasDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.CabezasDataGridViewTextBoxColumn.HeaderText = "Cabezas"
        Me.CabezasDataGridViewTextBoxColumn.Name = "CabezasDataGridViewTextBoxColumn"
        Me.CabezasDataGridViewTextBoxColumn.ReadOnly = True
        Me.CabezasDataGridViewTextBoxColumn.Width = 73
        '
        'TotalServidasDataGridViewTextBoxColumn
        '
        Me.TotalServidasDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TotalServidasDataGridViewTextBoxColumn.DataPropertyName = "TotalServidas"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N3"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.TotalServidasDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.TotalServidasDataGridViewTextBoxColumn.HeaderText = "TotalServidas"
        Me.TotalServidasDataGridViewTextBoxColumn.Name = "TotalServidasDataGridViewTextBoxColumn"
        Me.TotalServidasDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalServidasDataGridViewTextBoxColumn.Width = 97
        '
        'CostoDataGridViewTextBoxColumn
        '
        Me.CostoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CostoDataGridViewTextBoxColumn.DataPropertyName = "Costo"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.CostoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.CostoDataGridViewTextBoxColumn.HeaderText = "Costo"
        Me.CostoDataGridViewTextBoxColumn.Name = "CostoDataGridViewTextBoxColumn"
        Me.CostoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CostoDataGridViewTextBoxColumn.Width = 59
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
        'EstatusDataGridViewTextBoxColumn
        '
        Me.EstatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.HeaderText = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.Name = "EstatusDataGridViewTextBoxColumn"
        Me.EstatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstatusDataGridViewTextBoxColumn.Visible = False
        '
        'IdAlmacenDataGridViewTextBoxColumn
        '
        Me.IdAlmacenDataGridViewTextBoxColumn.DataPropertyName = "IdAlmacen"
        Me.IdAlmacenDataGridViewTextBoxColumn.HeaderText = "IdAlmacen"
        Me.IdAlmacenDataGridViewTextBoxColumn.Name = "IdAlmacenDataGridViewTextBoxColumn"
        Me.IdAlmacenDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdAlmacenDataGridViewTextBoxColumn.Visible = False
        '
        'aplicacionesFormulas
        '
        Me.aplicacionesFormulas.TableName = "VwBusquedaAplicacionFormula"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.dgResultado)
        Me.GroupBox2.Location = New System.Drawing.Point(56, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(840, 387)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultado Busqueda"
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Location = New System.Drawing.Point(740, 529)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 18
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Location = New System.Drawing.Point(821, 529)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 19
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'cmbAlmacen
        '
        Me.cmbAlmacen.FormattingEnabled = True
        Me.cmbAlmacen.Location = New System.Drawing.Point(169, 63)
        Me.cmbAlmacen.Name = "cmbAlmacen"
        Me.cmbAlmacen.NombreMetodo = Nothing
        Me.cmbAlmacen.Parametros = Nothing
        Me.cmbAlmacen.SiguienteControl = Nothing
        Me.cmbAlmacen.Size = New System.Drawing.Size(346, 21)
        Me.cmbAlmacen.TabIndex = 12
        Me.cmbAlmacen.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbAlmacen.TextBoxEnlazado = Me.txtCodigoAlmacen
        '
        'txtCodigoAlmacen
        '
        Me.txtCodigoAlmacen.ComboBoxEnlazado = Me.cmbAlmacen
        Me.txtCodigoAlmacen.Decimales = 0
        Me.txtCodigoAlmacen.Location = New System.Drawing.Point(110, 63)
        Me.txtCodigoAlmacen.MaxLength = 3000
        Me.txtCodigoAlmacen.MensajeCombo = "Seleccionar un almacén..."
        Me.txtCodigoAlmacen.MensajeNoExiste = "No existe un almacén con este código o se encuentra inactivo"
        Me.txtCodigoAlmacen.Name = "txtCodigoAlmacen"
        Me.txtCodigoAlmacen.SiguienteControl = Nothing
        Me.txtCodigoAlmacen.Size = New System.Drawing.Size(53, 20)
        Me.txtCodigoAlmacen.TabIndex = 11
        Me.txtCodigoAlmacen.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtCodigoAlmacen.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtCodigoAlmacen.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkCancelado)
        Me.GroupBox3.Controls.Add(Me.chkContabilizado)
        Me.GroupBox3.Controls.Add(Me.chkVigente)
        Me.GroupBox3.Location = New System.Drawing.Point(700, 40)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(115, 90)
        Me.GroupBox3.TabIndex = 20
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
        'frmBusquedaAplicacionFormula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 564)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.chkFiltrar)
        Me.Controls.Add(Me.gbRangoFechas)
        Me.Controls.Add(Me.cmbAlmacen)
        Me.Controls.Add(Me.txtCodigoAlmacen)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.MaximizeBox = False
        Me.Name = "frmBusquedaAplicacionFormula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda Aplicación De Formula"
        Me.gbRangoFechas.ResumeLayout(False)
        Me.gbRangoFechas.PerformLayout()
        CType(Me.dgResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.aplicacionesFormulas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents dtFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbAlmacen As Integralab.Controles.ComboBoxMejorado
    Friend WithEvents txtCodigoAlmacen As Integralab.Controles.TextBoxMejorado
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents gbRangoFechas As System.Windows.Forms.GroupBox
    Friend WithEvents dtFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkFiltrar As System.Windows.Forms.CheckBox
    Friend WithEvents dgResultado As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents aplicacionesFormulas As IntegraLab.ORM.TypedViewClasses.VwBusquedaAplicacionFormulaTypedView
    Friend WithEvents FolAplFDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaAplicacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CabezasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalServidasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstatusStrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdAlmacenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCancelado As System.Windows.Forms.CheckBox
    Friend WithEvents chkContabilizado As System.Windows.Forms.CheckBox
    Friend WithEvents chkVigente As System.Windows.Forms.CheckBox
End Class
