<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInvRevisionAjuste
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.CmbAlmacenes = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.clmProductoId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmExistencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmExisFisica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDiferencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Separator5 = New System.Windows.Forms.ToolBarButton()
        Me.mtb = New MEAToolBar.MEAToolBar()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(54, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(768, 36)
        Me.Label17.TabIndex = 53
        Me.Label17.Text = "Revisión y Ajuste de Inventario"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbAlmacenes
        '
        Me.CmbAlmacenes.Enabled = False
        Me.CmbAlmacenes.FormattingEnabled = True
        Me.CmbAlmacenes.Location = New System.Drawing.Point(108, 49)
        Me.CmbAlmacenes.Name = "CmbAlmacenes"
        Me.CmbAlmacenes.Size = New System.Drawing.Size(287, 21)
        Me.CmbAlmacenes.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Almacén:"
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToDeleteRows = False
        Me.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmProductoId, Me.clmProducto, Me.clmExistencia, Me.clmExisFisica, Me.clmDiferencia, Me.clmFecha})
        Me.dgvDetalle.Location = New System.Drawing.Point(54, 86)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.ReadOnly = True
        Me.dgvDetalle.RowHeadersVisible = False
        Me.dgvDetalle.Size = New System.Drawing.Size(754, 389)
        Me.dgvDetalle.TabIndex = 56
        '
        'clmProductoId
        '
        Me.clmProductoId.DataPropertyName = "CodProducto"
        Me.clmProductoId.FillWeight = 40.0!
        Me.clmProductoId.HeaderText = "Código"
        Me.clmProductoId.Name = "clmProductoId"
        Me.clmProductoId.ReadOnly = True
        '
        'clmProducto
        '
        Me.clmProducto.DataPropertyName = "PdDescripcion"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.clmProducto.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmProducto.FillWeight = 190.0!
        Me.clmProducto.HeaderText = "Producto"
        Me.clmProducto.Name = "clmProducto"
        Me.clmProducto.ReadOnly = True
        '
        'clmExistencia
        '
        Me.clmExistencia.DataPropertyName = "Existencia"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N3"
        Me.clmExistencia.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmExistencia.FillWeight = 70.0!
        Me.clmExistencia.HeaderText = "Existencia en Sistema"
        Me.clmExistencia.Name = "clmExistencia"
        Me.clmExistencia.ReadOnly = True
        '
        'clmExisFisica
        '
        Me.clmExisFisica.DataPropertyName = "Cantidad"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N3"
        Me.clmExisFisica.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmExisFisica.FillWeight = 70.0!
        Me.clmExisFisica.HeaderText = "Existencia Fisica"
        Me.clmExisFisica.Name = "clmExisFisica"
        Me.clmExisFisica.ReadOnly = True
        '
        'clmDiferencia
        '
        Me.clmDiferencia.DataPropertyName = "Diferencia"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N3"
        Me.clmDiferencia.DefaultCellStyle = DataGridViewCellStyle4
        Me.clmDiferencia.FillWeight = 70.0!
        Me.clmDiferencia.HeaderText = "Diferencia"
        Me.clmDiferencia.Name = "clmDiferencia"
        Me.clmDiferencia.ReadOnly = True
        '
        'clmFecha
        '
        Me.clmFecha.DataPropertyName = "FechaInventario"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "dd-MM-yyyy HH:mm"
        Me.clmFecha.DefaultCellStyle = DataGridViewCellStyle5
        Me.clmFecha.FillWeight = 75.0!
        Me.clmFecha.HeaderText = "Fecha"
        Me.clmFecha.Name = "clmFecha"
        Me.clmFecha.ReadOnly = True
        '
        'Separator5
        '
        Me.Separator5.Name = "Separator5"
        Me.Separator5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        Me.Separator5.Visible = False
        '
        'mtb
        '
        Me.mtb.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.Separator5})
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
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 487)
        Me.mtb.TabIndex = 52
        '
        'FrmInvRevisionAjuste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 487)
        Me.Controls.Add(Me.dgvDetalle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbAlmacenes)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(838, 525)
        Me.MinimumSize = New System.Drawing.Size(838, 525)
        Me.Name = "FrmInvRevisionAjuste"
        Me.Text = "Revisión y Ajuste de Inventario"
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents CmbAlmacenes As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents Separator5 As System.Windows.Forms.ToolBarButton
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents clmProductoId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmExistencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmExisFisica As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDiferencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFecha As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
