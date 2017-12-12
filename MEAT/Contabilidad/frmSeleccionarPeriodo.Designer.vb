<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeleccionarPeriodo
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
        Me.GrpPeriodos = New System.Windows.Forms.GroupBox
        Me.dgvPeriodos = New System.Windows.Forms.DataGridView
        Me.clmEjercicio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFechaCierre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.GrpPeriodos.SuspendLayout()
        CType(Me.dgvPeriodos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpPeriodos
        '
        Me.GrpPeriodos.Controls.Add(Me.dgvPeriodos)
        Me.GrpPeriodos.Location = New System.Drawing.Point(55, 32)
        Me.GrpPeriodos.Name = "GrpPeriodos"
        Me.GrpPeriodos.Size = New System.Drawing.Size(383, 343)
        Me.GrpPeriodos.TabIndex = 7
        Me.GrpPeriodos.TabStop = False
        Me.GrpPeriodos.Text = "Periodos Contables"
        '
        'dgvPeriodos
        '
        Me.dgvPeriodos.AllowUserToAddRows = False
        Me.dgvPeriodos.AllowUserToDeleteRows = False
        Me.dgvPeriodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPeriodos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmEjercicio, Me.clmFechaCierre, Me.clmEstatus})
        Me.dgvPeriodos.Location = New System.Drawing.Point(6, 19)
        Me.dgvPeriodos.MultiSelect = False
        Me.dgvPeriodos.Name = "dgvPeriodos"
        Me.dgvPeriodos.ReadOnly = True
        Me.dgvPeriodos.RowHeadersVisible = False
        Me.dgvPeriodos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPeriodos.Size = New System.Drawing.Size(371, 318)
        Me.dgvPeriodos.TabIndex = 0
        '
        'clmEjercicio
        '
        Me.clmEjercicio.DataPropertyName = "Ejercicio"
        Me.clmEjercicio.HeaderText = "Ejercicio"
        Me.clmEjercicio.Name = "clmEjercicio"
        Me.clmEjercicio.ReadOnly = True
        Me.clmEjercicio.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmEjercicio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'clmFechaCierre
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = "01/01/2000"
        Me.clmFechaCierre.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmFechaCierre.HeaderText = "FechaCierre"
        Me.clmFechaCierre.Name = "clmFechaCierre"
        Me.clmFechaCierre.ReadOnly = True
        Me.clmFechaCierre.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmFechaCierre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'clmEstatus
        '
        Me.clmEstatus.DataPropertyName = "Estatus"
        Me.clmEstatus.HeaderText = "Estatus"
        Me.clmEstatus.Name = "clmEstatus"
        Me.clmEstatus.ReadOnly = True
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
        Me.mtb.MostrarLimpiar = False
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 384)
        Me.mtb.TabIndex = 9
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
        Me.lblTitulo.Size = New System.Drawing.Size(394, 29)
        Me.lblTitulo.TabIndex = 10
        Me.lblTitulo.Text = "Seleccionar Periodos Contables"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmSeleccionarPeriodo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 384)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.GrpPeriodos)
        Me.Name = "frmSeleccionarPeriodo"
        Me.Text = "Seleccionar Periodo Contable "
        Me.GrpPeriodos.ResumeLayout(False)
        CType(Me.dgvPeriodos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpPeriodos As System.Windows.Forms.GroupBox
    Friend WithEvents dgvPeriodos As System.Windows.Forms.DataGridView
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents clmEjercicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaCierre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
