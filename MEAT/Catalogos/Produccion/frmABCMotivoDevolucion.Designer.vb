<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmABCMotivoDevolucion
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgvMotivoDecomiso = New System.Windows.Forms.DataGridView
        Me.IdMotivoDevolucionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionCortaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaCapturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MotivoDevolucionC = New ClasesNegocio.MotivoDevolucionColeccionClass
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDescCorta = New Integralab.Controles.TextBoxMejorado
        Me.txtDescripcion = New Integralab.Controles.TextBoxMejorado
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvMotivoDecomiso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Des. Corta :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgvMotivoDecomiso)
        Me.GroupBox1.Location = New System.Drawing.Point(54, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(736, 421)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de Devoluciones"
        '
        'dgvMotivoDecomiso
        '
        Me.dgvMotivoDecomiso.AllowUserToAddRows = False
        Me.dgvMotivoDecomiso.AllowUserToDeleteRows = False
        Me.dgvMotivoDecomiso.AllowUserToResizeRows = False
        Me.dgvMotivoDecomiso.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMotivoDecomiso.AutoGenerateColumns = False
        Me.dgvMotivoDecomiso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMotivoDecomiso.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdMotivoDevolucionDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.DescripcionCortaDataGridViewTextBoxColumn, Me.FechaCapturaDataGridViewTextBoxColumn, Me.EstatusDataGridViewTextBoxColumn})
        Me.dgvMotivoDecomiso.DataSource = Me.MotivoDevolucionC
        Me.dgvMotivoDecomiso.Location = New System.Drawing.Point(6, 19)
        Me.dgvMotivoDecomiso.MultiSelect = False
        Me.dgvMotivoDecomiso.Name = "dgvMotivoDecomiso"
        Me.dgvMotivoDecomiso.ReadOnly = True
        Me.dgvMotivoDecomiso.RowHeadersVisible = False
        Me.dgvMotivoDecomiso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMotivoDecomiso.Size = New System.Drawing.Size(724, 396)
        Me.dgvMotivoDecomiso.TabIndex = 0
        '
        'IdMotivoDevolucionDataGridViewTextBoxColumn
        '
        Me.IdMotivoDevolucionDataGridViewTextBoxColumn.DataPropertyName = "IdMotivoDevolucion"
        Me.IdMotivoDevolucionDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.IdMotivoDevolucionDataGridViewTextBoxColumn.Name = "IdMotivoDevolucionDataGridViewTextBoxColumn"
        Me.IdMotivoDevolucionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionCortaDataGridViewTextBoxColumn
        '
        Me.DescripcionCortaDataGridViewTextBoxColumn.DataPropertyName = "DescripcionCorta"
        Me.DescripcionCortaDataGridViewTextBoxColumn.HeaderText = "DescripcionCorta"
        Me.DescripcionCortaDataGridViewTextBoxColumn.Name = "DescripcionCortaDataGridViewTextBoxColumn"
        Me.DescripcionCortaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaCapturaDataGridViewTextBoxColumn
        '
        Me.FechaCapturaDataGridViewTextBoxColumn.DataPropertyName = "FechaCaptura"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.FechaCapturaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.FechaCapturaDataGridViewTextBoxColumn.HeaderText = "FechaCaptura"
        Me.FechaCapturaDataGridViewTextBoxColumn.Name = "FechaCapturaDataGridViewTextBoxColumn"
        Me.FechaCapturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstatusDataGridViewTextBoxColumn
        '
        Me.EstatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.HeaderText = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.Name = "EstatusDataGridViewTextBoxColumn"
        Me.EstatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MotivoDevolucionC
        '
        Me.MotivoDevolucionC.AllowEdit = True
        Me.MotivoDevolucionC.AllowNew = True
        Me.MotivoDevolucionC.AllowRemove = True
        Me.MotivoDevolucionC.MaximoElementosSeleccionados = 1
        Me.MotivoDevolucionC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.MotivoDevolucionC.MostrarAlertas = False
        Me.MotivoDevolucionC.Name = Nothing
        Me.MotivoDevolucionC.RaiseListChangedEvents = True
        Me.MotivoDevolucionC.Transaction = Nothing
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(750, 32)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "MOTIVO DE DEVOLUCIÓN"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(140, 35)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(68, 20)
        Me.txtCodigo.TabIndex = 3
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.MEAToolBar1.HabilitarLimpiar = True
        Me.MEAToolBar1.HabilitarNuevo = True
        Me.MEAToolBar1.HabilitarSalir = True
        Me.MEAToolBar1.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32
        Me.MEAToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.MEAToolBar1.MostrarBorrar = True
        Me.MEAToolBar1.MostrarBuscar = False
        Me.MEAToolBar1.MostrarCancelar = True
        Me.MEAToolBar1.MostrarEditar = True
        Me.MEAToolBar1.MostrarGuardar = True
        Me.MEAToolBar1.MostrarImprimir = True
        Me.MEAToolBar1.MostrarLimpiar = True
        Me.MEAToolBar1.MostrarNuevo = True
        Me.MEAToolBar1.MostrarSalir = True
        Me.MEAToolBar1.Name = "MEAToolBar1"
        Me.MEAToolBar1.ShowToolTips = True
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 545)
        Me.MEAToolBar1.TabIndex = 0
        '
        'lblEstatus
        '
        Me.lblEstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(655, 39)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(135, 24)
        Me.lblEstatus.TabIndex = 9
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Descripción :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Codigo :"
        '
        'txtDescCorta
        '
        Me.txtDescCorta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescCorta.ComboBoxEnlazado = Nothing
        Me.txtDescCorta.Decimales = 0
        Me.txtDescCorta.Location = New System.Drawing.Point(140, 88)
        Me.txtDescCorta.MaxLength = 50
        Me.txtDescCorta.MensajeCombo = "Seleccionar un item..."
        Me.txtDescCorta.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtDescCorta.Name = "txtDescCorta"
        Me.txtDescCorta.SiguienteControl = Me.txtDescripcion
        Me.txtDescCorta.Size = New System.Drawing.Size(319, 20)
        Me.txtDescCorta.TabIndex = 7
        Me.txtDescCorta.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtDescCorta.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtDescCorta.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.ComboBoxEnlazado = Nothing
        Me.txtDescripcion.Decimales = 0
        Me.txtDescripcion.Location = New System.Drawing.Point(140, 62)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.MensajeCombo = "Seleccionar un item..."
        Me.txtDescripcion.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.SiguienteControl = Me.txtDescCorta
        Me.txtDescripcion.Size = New System.Drawing.Size(509, 20)
        Me.txtDescripcion.TabIndex = 5
        Me.txtDescripcion.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtDescripcion.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtDescripcion.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'frmABCMotivoDevolucion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 545)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDescCorta)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.Controls.Add(Me.lblEstatus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmABCMotivoDevolucion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Motivo de Devolucion"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvMotivoDecomiso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDescCorta As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtDescripcion As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvMotivoDecomiso As System.Windows.Forms.DataGridView
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IdMotivoDevolucionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionCortaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaCapturaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MotivoDevolucionC As ClasesNegocio.MotivoDevolucionColeccionClass
End Class
