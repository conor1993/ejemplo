<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNomSubcidio
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgLimites = New System.Windows.Forms.DataGridView
        Me.IngresoDeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IngresoHastaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubcidioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubcidioCollectionClass1 = New ClasesNegocio.SubcidioCollectionClass
        Me.dtAño = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgLimites, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgLimites)
        Me.GroupBox1.Location = New System.Drawing.Point(54, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(529, 354)
        Me.GroupBox1.TabIndex = 74
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Limites"
        '
        'dgLimites
        '
        Me.dgLimites.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgLimites.AutoGenerateColumns = False
        Me.dgLimites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLimites.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IngresoDeDataGridViewTextBoxColumn, Me.IngresoHastaDataGridViewTextBoxColumn, Me.SubcidioDataGridViewTextBoxColumn})
        Me.dgLimites.DataSource = Me.SubcidioCollectionClass1
        Me.dgLimites.Location = New System.Drawing.Point(6, 19)
        Me.dgLimites.Name = "dgLimites"
        Me.dgLimites.Size = New System.Drawing.Size(517, 329)
        Me.dgLimites.TabIndex = 0
        '
        'IngresoDeDataGridViewTextBoxColumn
        '
        Me.IngresoDeDataGridViewTextBoxColumn.DataPropertyName = "IngresoDe"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.IngresoDeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.IngresoDeDataGridViewTextBoxColumn.HeaderText = "IngresoDe"
        Me.IngresoDeDataGridViewTextBoxColumn.Name = "IngresoDeDataGridViewTextBoxColumn"
        '
        'IngresoHastaDataGridViewTextBoxColumn
        '
        Me.IngresoHastaDataGridViewTextBoxColumn.DataPropertyName = "IngresoHasta"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.IngresoHastaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.IngresoHastaDataGridViewTextBoxColumn.HeaderText = "IngresoHasta"
        Me.IngresoHastaDataGridViewTextBoxColumn.Name = "IngresoHastaDataGridViewTextBoxColumn"
        '
        'SubcidioDataGridViewTextBoxColumn
        '
        Me.SubcidioDataGridViewTextBoxColumn.DataPropertyName = "Subcidio"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.SubcidioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.SubcidioDataGridViewTextBoxColumn.HeaderText = "Subcidio"
        Me.SubcidioDataGridViewTextBoxColumn.Name = "SubcidioDataGridViewTextBoxColumn"
        '
        'SubcidioCollectionClass1
        '
        Me.SubcidioCollectionClass1.AllowEdit = True
        Me.SubcidioCollectionClass1.AllowNew = True
        Me.SubcidioCollectionClass1.AllowRemove = True
        Me.SubcidioCollectionClass1.MaximoElementosSeleccionados = 1
        Me.SubcidioCollectionClass1.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.SubcidioCollectionClass1.MostrarAlertas = False
        Me.SubcidioCollectionClass1.Name = Nothing
        Me.SubcidioCollectionClass1.RaiseListChangedEvents = True
        Me.SubcidioCollectionClass1.Transaction = Nothing
        '
        'dtAño
        '
        Me.dtAño.CustomFormat = "yyyy"
        Me.dtAño.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtAño.Location = New System.Drawing.Point(86, 36)
        Me.dtAño.Name = "dtAño"
        Me.dtAño.ShowUpDown = True
        Me.dtAño.Size = New System.Drawing.Size(58, 20)
        Me.dtAño.TabIndex = 73
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Año:"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(545, 32)
        Me.Label17.TabIndex = 71
        Me.Label17.Text = "ISR"
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
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = False
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 428)
        Me.mtb.TabIndex = 70
        '
        'frmNomSubcidio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 428)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtAño)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.Name = "frmNomSubcidio"
        Me.Text = "Subsidio al Empleo"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgLimites, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgLimites As System.Windows.Forms.DataGridView
    Friend WithEvents dtAño As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents SubcidioCollectionClass1 As ClasesNegocio.SubcidioCollectionClass
    Friend WithEvents IngresoDeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IngresoHastaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubcidioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
