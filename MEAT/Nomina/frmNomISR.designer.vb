<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNomISR
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label17 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtAño = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgLimites = New System.Windows.Forms.DataGridView
        Me.LimiteInferiorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LimiteSuperiorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CuotaFijaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PorcentajeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ISRc = New ClasesNegocio.ISRCollectionClass
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgLimites, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label17.Size = New System.Drawing.Size(511, 32)
        Me.Label17.TabIndex = 66
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
        Me.mtb.Size = New System.Drawing.Size(50, 444)
        Me.mtb.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Año:"
        '
        'dtAño
        '
        Me.dtAño.CustomFormat = "yyyy"
        Me.dtAño.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtAño.Location = New System.Drawing.Point(86, 38)
        Me.dtAño.Name = "dtAño"
        Me.dtAño.ShowUpDown = True
        Me.dtAño.Size = New System.Drawing.Size(58, 20)
        Me.dtAño.TabIndex = 68
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgLimites)
        Me.GroupBox1.Location = New System.Drawing.Point(54, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(495, 368)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Limites"
        '
        'dgLimites
        '
        Me.dgLimites.AutoGenerateColumns = False
        Me.dgLimites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLimites.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LimiteInferiorDataGridViewTextBoxColumn, Me.LimiteSuperiorDataGridViewTextBoxColumn, Me.CuotaFijaDataGridViewTextBoxColumn, Me.PorcentajeDataGridViewTextBoxColumn})
        Me.dgLimites.DataSource = Me.ISRc
        Me.dgLimites.Location = New System.Drawing.Point(6, 19)
        Me.dgLimites.Name = "dgLimites"
        Me.dgLimites.Size = New System.Drawing.Size(483, 343)
        Me.dgLimites.TabIndex = 0
        '
        'LimiteInferiorDataGridViewTextBoxColumn
        '
        Me.LimiteInferiorDataGridViewTextBoxColumn.DataPropertyName = "LimiteInferior"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.LimiteInferiorDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.LimiteInferiorDataGridViewTextBoxColumn.HeaderText = "LimiteInferior"
        Me.LimiteInferiorDataGridViewTextBoxColumn.Name = "LimiteInferiorDataGridViewTextBoxColumn"
        '
        'LimiteSuperiorDataGridViewTextBoxColumn
        '
        Me.LimiteSuperiorDataGridViewTextBoxColumn.DataPropertyName = "LimiteSuperior"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.LimiteSuperiorDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.LimiteSuperiorDataGridViewTextBoxColumn.HeaderText = "LimiteSuperior"
        Me.LimiteSuperiorDataGridViewTextBoxColumn.Name = "LimiteSuperiorDataGridViewTextBoxColumn"
        '
        'CuotaFijaDataGridViewTextBoxColumn
        '
        Me.CuotaFijaDataGridViewTextBoxColumn.DataPropertyName = "CuotaFija"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.CuotaFijaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.CuotaFijaDataGridViewTextBoxColumn.HeaderText = "CuotaFija"
        Me.CuotaFijaDataGridViewTextBoxColumn.Name = "CuotaFijaDataGridViewTextBoxColumn"
        '
        'PorcentajeDataGridViewTextBoxColumn
        '
        Me.PorcentajeDataGridViewTextBoxColumn.DataPropertyName = "Porcentaje"
        Me.PorcentajeDataGridViewTextBoxColumn.HeaderText = "Porcentaje"
        Me.PorcentajeDataGridViewTextBoxColumn.Name = "PorcentajeDataGridViewTextBoxColumn"
        '
        'ISRc
        '
        Me.ISRc.AllowEdit = True
        Me.ISRc.AllowNew = True
        Me.ISRc.AllowRemove = True
        Me.ISRc.MaximoElementosSeleccionados = 1
        Me.ISRc.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.ISRc.MostrarAlertas = False
        Me.ISRc.Name = Nothing
        Me.ISRc.RaiseListChangedEvents = True
        '
        'frmNomISR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 444)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtAño)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmNomISR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ISR"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgLimites, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtAño As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgLimites As System.Windows.Forms.DataGridView
    Friend WithEvents ISRc As ClasesNegocio.ISRCollectionClass
    Friend WithEvents LimiteInferiorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LimiteSuperiorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CuotaFijaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PorcentajeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
