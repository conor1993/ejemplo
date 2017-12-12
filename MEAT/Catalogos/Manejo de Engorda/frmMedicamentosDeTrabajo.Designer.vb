<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMedicamentosDeTrabajo
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
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.IdMedicamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.UnidadMedidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PorCabezaDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.PorKiloDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.CantidadXCabezaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadXKiloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MedicamentoTrabajoC = New ClasesNegocio.MedicamentoTrabajoColletionClass
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MEAToolBar1
        '
        Me.MEAToolBar1.ButtonSize = New System.Drawing.Size(50, 50)
        Me.MEAToolBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MEAToolBar1.DropDownArrows = True
        Me.MEAToolBar1.HabilitarBorrar = True
        Me.MEAToolBar1.HabilitarBuscar = True
        Me.MEAToolBar1.HabilitarCancelar = True
        Me.MEAToolBar1.HabilitarEditar = True
        Me.MEAToolBar1.HabilitarGuardar = True
        Me.MEAToolBar1.HabilitarImprimir = True
        Me.MEAToolBar1.HabilitarLimpiar = False
        Me.MEAToolBar1.HabilitarNuevo = True
        Me.MEAToolBar1.HabilitarSalir = True
        Me.MEAToolBar1.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32
        Me.MEAToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.MEAToolBar1.MostrarBorrar = False
        Me.MEAToolBar1.MostrarBuscar = False
        Me.MEAToolBar1.MostrarCancelar = True
        Me.MEAToolBar1.MostrarEditar = False
        Me.MEAToolBar1.MostrarGuardar = True
        Me.MEAToolBar1.MostrarImprimir = False
        Me.MEAToolBar1.MostrarLimpiar = False
        Me.MEAToolBar1.MostrarNuevo = False
        Me.MEAToolBar1.MostrarSalir = True
        Me.MEAToolBar1.Name = "MEAToolBar1"
        Me.MEAToolBar1.ShowToolTips = True
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 577)
        Me.MEAToolBar1.TabIndex = 45
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(877, 32)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "MEDICAMENTOS DE TRABAJO"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(859, 530)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de Medicamentos"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdMedicamentoDataGridViewTextBoxColumn, Me.UnidadMedidaDataGridViewTextBoxColumn, Me.PorCabezaDataGridViewCheckBoxColumn, Me.PorKiloDataGridViewCheckBoxColumn, Me.CantidadXCabezaDataGridViewTextBoxColumn, Me.CantidadXKiloDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MedicamentoTrabajoC
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(847, 505)
        Me.DataGridView1.TabIndex = 0
        '
        'IdMedicamentoDataGridViewTextBoxColumn
        '
        Me.IdMedicamentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.IdMedicamentoDataGridViewTextBoxColumn.DataPropertyName = "IdMedicamento"
        Me.IdMedicamentoDataGridViewTextBoxColumn.HeaderText = "Medicamento"
        Me.IdMedicamentoDataGridViewTextBoxColumn.Name = "IdMedicamentoDataGridViewTextBoxColumn"
        Me.IdMedicamentoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IdMedicamentoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.IdMedicamentoDataGridViewTextBoxColumn.Width = 94
        '
        'UnidadMedidaDataGridViewTextBoxColumn
        '
        Me.UnidadMedidaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.UnidadMedidaDataGridViewTextBoxColumn.DataPropertyName = "UnidadMedida"
        Me.UnidadMedidaDataGridViewTextBoxColumn.HeaderText = "Unidad Medida"
        Me.UnidadMedidaDataGridViewTextBoxColumn.Name = "UnidadMedidaDataGridViewTextBoxColumn"
        Me.UnidadMedidaDataGridViewTextBoxColumn.Width = 94
        '
        'PorCabezaDataGridViewCheckBoxColumn
        '
        Me.PorCabezaDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.PorCabezaDataGridViewCheckBoxColumn.DataPropertyName = "PorCabeza"
        Me.PorCabezaDataGridViewCheckBoxColumn.HeaderText = "PorCabeza"
        Me.PorCabezaDataGridViewCheckBoxColumn.Name = "PorCabezaDataGridViewCheckBoxColumn"
        Me.PorCabezaDataGridViewCheckBoxColumn.Width = 63
        '
        'PorKiloDataGridViewCheckBoxColumn
        '
        Me.PorKiloDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.PorKiloDataGridViewCheckBoxColumn.DataPropertyName = "PorKilo"
        Me.PorKiloDataGridViewCheckBoxColumn.HeaderText = "PorKilo"
        Me.PorKiloDataGridViewCheckBoxColumn.Name = "PorKiloDataGridViewCheckBoxColumn"
        Me.PorKiloDataGridViewCheckBoxColumn.Width = 44
        '
        'CantidadXCabezaDataGridViewTextBoxColumn
        '
        Me.CantidadXCabezaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CantidadXCabezaDataGridViewTextBoxColumn.DataPropertyName = "CantidadXCabeza"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N3"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.CantidadXCabezaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.CantidadXCabezaDataGridViewTextBoxColumn.HeaderText = "Cantidad X Cabeza"
        Me.CantidadXCabezaDataGridViewTextBoxColumn.Name = "CantidadXCabezaDataGridViewTextBoxColumn"
        Me.CantidadXCabezaDataGridViewTextBoxColumn.Width = 78
        '
        'CantidadXKiloDataGridViewTextBoxColumn
        '
        Me.CantidadXKiloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CantidadXKiloDataGridViewTextBoxColumn.DataPropertyName = "CantidadXKilo"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N3"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.CantidadXKiloDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.CantidadXKiloDataGridViewTextBoxColumn.HeaderText = "Cantidad X Kilo"
        Me.CantidadXKiloDataGridViewTextBoxColumn.Name = "CantidadXKiloDataGridViewTextBoxColumn"
        Me.CantidadXKiloDataGridViewTextBoxColumn.Width = 78
        '
        'MedicamentoTrabajoC
        '
        Me.MedicamentoTrabajoC.AllowEdit = True
        Me.MedicamentoTrabajoC.AllowNew = True
        Me.MedicamentoTrabajoC.AllowRemove = True
        Me.MedicamentoTrabajoC.MaximoElementosSeleccionados = 1
        Me.MedicamentoTrabajoC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.MedicamentoTrabajoC.MostrarAlertas = False
        Me.MedicamentoTrabajoC.Name = Nothing
        Me.MedicamentoTrabajoC.RaiseListChangedEvents = True
        Me.MedicamentoTrabajoC.Transaction = Nothing
        '
        'frmMedicamentosDeTrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 577)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.MaximizeBox = False
        Me.Name = "frmMedicamentosDeTrabajo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medicamentos de Trabajo"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MedicamentoTrabajoC As ClasesNegocio.MedicamentoTrabajoColletionClass
    Friend WithEvents IdMedicamentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents UnidadMedidaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PorCabezaDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PorKiloDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CantidadXCabezaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadXKiloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
