<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAlmSustituciondeInventario
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DataGridView3 = New System.Windows.Forms.DataGridView
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmbAlmacenes = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
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
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEtiqueta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmKilosLibros = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPiezasLibros = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmLoteCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFechaCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Etiqueta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CodigoFis = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCorteFisico = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EtiquetaFisica = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.kilosfisicos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.piezasfisicas = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoFis, Me.clmCorteFisico, Me.EtiquetaFisica, Me.kilosfisicos, Me.piezasfisicas})
        Me.DataGridView3.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.RowHeadersVisible = False
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView3.Size = New System.Drawing.Size(409, 363)
        Me.DataGridView3.TabIndex = 77
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.clmCorte, Me.clmEtiqueta, Me.clmKilosLibros, Me.clmPiezasLibros, Me.clmLoteCorte, Me.clmFechaCorte, Me.Etiqueta})
        Me.DataGridView2.Location = New System.Drawing.Point(6, 17)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(477, 365)
        Me.DataGridView2.TabIndex = 75
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(476, 44)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(89, 20)
        Me.DateTimePicker1.TabIndex = 74
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(427, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Fecha :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Almacén:"
        '
        'CmbAlmacenes
        '
        Me.CmbAlmacenes.FormattingEnabled = True
        Me.CmbAlmacenes.Location = New System.Drawing.Point(110, 44)
        Me.CmbAlmacenes.Name = "CmbAlmacenes"
        Me.CmbAlmacenes.Size = New System.Drawing.Size(287, 21)
        Me.CmbAlmacenes.TabIndex = 70
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(926, 36)
        Me.Label17.TabIndex = 69
        Me.Label17.Text = "Sustitución de Inventario"
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
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = False
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 478)
        Me.mtb.TabIndex = 68
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView2)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(489, 395)
        Me.GroupBox1.TabIndex = 78
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Existencia en Libros"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView3)
        Me.GroupBox2.Location = New System.Drawing.Point(551, 70)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(421, 395)
        Me.GroupBox2.TabIndex = 79
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Existencias Fisicas"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Codigo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Corte"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Producto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 120
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Etiqueta"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Caja"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 160
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "KilosLibros"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn4.HeaderText = "Kilos"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 50
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PiezasLibros"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = "0"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn5.HeaderText = "Piezas"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 50
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "LoteCorte"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Lote "
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 70
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "FechaCorte"
        Me.DataGridViewTextBoxColumn7.HeaderText = "FechaCorte"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        Me.DataGridViewTextBoxColumn7.Width = 80
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "IdFolioEtiqueta"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Etiqueta"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "CodigoFis"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Corte"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Producto"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "EtiquetaFisica"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Caja"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 160
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "KilosFisicos"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = "0"
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn12.HeaderText = "Kilos"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 60
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "PiezasFisicas"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = "0"
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn13.HeaderText = "Piezas"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 60
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "Codigo"
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'clmCorte
        '
        Me.clmCorte.DataPropertyName = "Corte"
        Me.clmCorte.HeaderText = "Producto"
        Me.clmCorte.Name = "clmCorte"
        Me.clmCorte.ReadOnly = True
        Me.clmCorte.Width = 120
        '
        'clmEtiqueta
        '
        Me.clmEtiqueta.DataPropertyName = "Etiqueta"
        Me.clmEtiqueta.HeaderText = "Caja"
        Me.clmEtiqueta.Name = "clmEtiqueta"
        Me.clmEtiqueta.ReadOnly = True
        Me.clmEtiqueta.Width = 160
        '
        'clmKilosLibros
        '
        Me.clmKilosLibros.DataPropertyName = "KilosLibros"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.clmKilosLibros.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmKilosLibros.HeaderText = "Kilos"
        Me.clmKilosLibros.Name = "clmKilosLibros"
        Me.clmKilosLibros.ReadOnly = True
        Me.clmKilosLibros.Width = 50
        '
        'clmPiezasLibros
        '
        Me.clmPiezasLibros.DataPropertyName = "PiezasLibros"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.clmPiezasLibros.DefaultCellStyle = DataGridViewCellStyle4
        Me.clmPiezasLibros.HeaderText = "Piezas"
        Me.clmPiezasLibros.Name = "clmPiezasLibros"
        Me.clmPiezasLibros.ReadOnly = True
        Me.clmPiezasLibros.Width = 50
        '
        'clmLoteCorte
        '
        Me.clmLoteCorte.DataPropertyName = "LoteCorte"
        Me.clmLoteCorte.HeaderText = "Lote "
        Me.clmLoteCorte.Name = "clmLoteCorte"
        Me.clmLoteCorte.ReadOnly = True
        Me.clmLoteCorte.Width = 70
        '
        'clmFechaCorte
        '
        Me.clmFechaCorte.DataPropertyName = "FechaCorte"
        Me.clmFechaCorte.HeaderText = "FechaCorte"
        Me.clmFechaCorte.Name = "clmFechaCorte"
        Me.clmFechaCorte.ReadOnly = True
        Me.clmFechaCorte.Visible = False
        Me.clmFechaCorte.Width = 80
        '
        'Etiqueta
        '
        Me.Etiqueta.DataPropertyName = "IdFolioEtiqueta"
        Me.Etiqueta.HeaderText = "Etiqueta"
        Me.Etiqueta.Name = "Etiqueta"
        Me.Etiqueta.ReadOnly = True
        '
        'CodigoFis
        '
        Me.CodigoFis.DataPropertyName = "CodigoFis"
        Me.CodigoFis.HeaderText = "Codigo"
        Me.CodigoFis.Name = "CodigoFis"
        Me.CodigoFis.ReadOnly = True
        '
        'clmCorteFisico
        '
        Me.clmCorteFisico.DataPropertyName = "Corte"
        Me.clmCorteFisico.HeaderText = "Producto"
        Me.clmCorteFisico.Name = "clmCorteFisico"
        Me.clmCorteFisico.ReadOnly = True
        '
        'EtiquetaFisica
        '
        Me.EtiquetaFisica.DataPropertyName = "EtiquetaFisica"
        Me.EtiquetaFisica.HeaderText = "Caja"
        Me.EtiquetaFisica.Name = "EtiquetaFisica"
        Me.EtiquetaFisica.ReadOnly = True
        Me.EtiquetaFisica.Width = 160
        '
        'kilosfisicos
        '
        Me.kilosfisicos.DataPropertyName = "KilosFisicos"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.kilosfisicos.DefaultCellStyle = DataGridViewCellStyle1
        Me.kilosfisicos.HeaderText = "Kilos"
        Me.kilosfisicos.Name = "kilosfisicos"
        Me.kilosfisicos.ReadOnly = True
        Me.kilosfisicos.Width = 60
        '
        'piezasfisicas
        '
        Me.piezasfisicas.DataPropertyName = "PiezasFisicas"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.piezasfisicas.DefaultCellStyle = DataGridViewCellStyle2
        Me.piezasfisicas.HeaderText = "Piezas"
        Me.piezasfisicas.Name = "piezasfisicas"
        Me.piezasfisicas.ReadOnly = True
        Me.piezasfisicas.Width = 60
        '
        'FrmAlmSustituciondeInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 478)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbAlmacenes)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.Name = "FrmAlmSustituciondeInventario"
        Me.Text = "Sustitución de Inventario"
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbAlmacenes As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEtiqueta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmKilosLibros As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPiezasLibros As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmLoteCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Etiqueta As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents CodigoFis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCorteFisico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EtiquetaFisica As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kilosfisicos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents piezasfisicas As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
