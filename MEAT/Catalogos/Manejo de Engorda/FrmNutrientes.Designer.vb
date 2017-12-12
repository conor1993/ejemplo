<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNutrientes
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
        Me.mtbMenu = New MEAToolBar.MEAToolBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.dgvNutrientes = New System.Windows.Forms.DataGridView
        Me.clmIdNutriente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmbUnidadMedida = New Integralab.Controles.ComboBoxMejorado
        Me.txtDescripcion = New Integralab.Controles.TextBoxMejorado
        CType(Me.dgvNutrientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mtbMenu
        '
        Me.mtbMenu.ButtonSize = New System.Drawing.Size(50, 50)
        Me.mtbMenu.Dock = System.Windows.Forms.DockStyle.None
        Me.mtbMenu.DropDownArrows = True
        Me.mtbMenu.HabilitarBorrar = True
        Me.mtbMenu.HabilitarBuscar = True
        Me.mtbMenu.HabilitarCancelar = True
        Me.mtbMenu.HabilitarEditar = True
        Me.mtbMenu.HabilitarGuardar = True
        Me.mtbMenu.HabilitarImprimir = True
        Me.mtbMenu.HabilitarLimpiar = True
        Me.mtbMenu.HabilitarNuevo = True
        Me.mtbMenu.HabilitarSalir = True
        Me.mtbMenu.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32
        Me.mtbMenu.Location = New System.Drawing.Point(3, -27)
        Me.mtbMenu.MostrarBorrar = True
        Me.mtbMenu.MostrarBuscar = False
        Me.mtbMenu.MostrarCancelar = True
        Me.mtbMenu.MostrarEditar = True
        Me.mtbMenu.MostrarGuardar = True
        Me.mtbMenu.MostrarImprimir = True
        Me.mtbMenu.MostrarLimpiar = True
        Me.mtbMenu.MostrarNuevo = True
        Me.mtbMenu.MostrarSalir = True
        Me.mtbMenu.Name = "mtbMenu"
        Me.mtbMenu.ShowToolTips = True
        Me.mtbMenu.Size = New System.Drawing.Size(50, 747)
        Me.mtbMenu.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Descripcion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tipo Unidad:"
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(428, 29)
        Me.lblTitulo.TabIndex = 7
        Me.lblTitulo.Text = "CATÁLOGO NUTRIENTES"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvNutrientes
        '
        Me.dgvNutrientes.AllowUserToAddRows = False
        Me.dgvNutrientes.AllowUserToDeleteRows = False
        Me.dgvNutrientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNutrientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmIdNutriente, Me.clmDescripcion, Me.clmUnidad, Me.clmEstatus})
        Me.dgvNutrientes.Location = New System.Drawing.Point(55, 115)
        Me.dgvNutrientes.Name = "dgvNutrientes"
        Me.dgvNutrientes.ReadOnly = True
        Me.dgvNutrientes.RowHeadersVisible = False
        Me.dgvNutrientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvNutrientes.Size = New System.Drawing.Size(361, 343)
        Me.dgvNutrientes.TabIndex = 8
        '
        'clmIdNutriente
        '
        Me.clmIdNutriente.DataPropertyName = "CveNutriente"
        Me.clmIdNutriente.HeaderText = "Codigo"
        Me.clmIdNutriente.Name = "clmIdNutriente"
        Me.clmIdNutriente.ReadOnly = True
        Me.clmIdNutriente.Width = 60
        '
        'clmDescripcion
        '
        Me.clmDescripcion.DataPropertyName = "NomNutriente"
        Me.clmDescripcion.HeaderText = "Descripcion"
        Me.clmDescripcion.Name = "clmDescripcion"
        Me.clmDescripcion.ReadOnly = True
        Me.clmDescripcion.Width = 140
        '
        'clmUnidad
        '
        Me.clmUnidad.DataPropertyName = "Unidad"
        Me.clmUnidad.HeaderText = "Unidad"
        Me.clmUnidad.Name = "clmUnidad"
        Me.clmUnidad.ReadOnly = True
        Me.clmUnidad.Width = 80
        '
        'clmEstatus
        '
        Me.clmEstatus.DataPropertyName = "Estatus"
        Me.clmEstatus.HeaderText = "Estatus"
        Me.clmEstatus.Name = "clmEstatus"
        Me.clmEstatus.ReadOnly = True
        Me.clmEstatus.Width = 70
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CveNutriente"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NomNutriente"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 140
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Unidad"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Unidad"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Estatus"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Estatus"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 70
        '
        'cmbUnidadMedida
        '
        Me.cmbUnidadMedida.FormattingEnabled = True
        Me.cmbUnidadMedida.Location = New System.Drawing.Point(138, 69)
        Me.cmbUnidadMedida.Name = "cmbUnidadMedida"
        Me.cmbUnidadMedida.NombreMetodo = Nothing
        Me.cmbUnidadMedida.Parametros = Nothing
        Me.cmbUnidadMedida.SiguienteControl = Nothing
        Me.cmbUnidadMedida.Size = New System.Drawing.Size(182, 21)
        Me.cmbUnidadMedida.TabIndex = 6
        Me.cmbUnidadMedida.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbUnidadMedida.TextBoxEnlazado = Nothing
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.ComboBoxEnlazado = Nothing
        Me.txtDescripcion.Decimales = 0
        Me.txtDescripcion.Location = New System.Drawing.Point(138, 43)
        Me.txtDescripcion.MensajeCombo = "Seleccionar un item..."
        Me.txtDescripcion.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.SiguienteControl = Nothing
        Me.txtDescripcion.Size = New System.Drawing.Size(182, 20)
        Me.txtDescripcion.TabIndex = 3
        Me.txtDescripcion.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        Me.txtDescripcion.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtDescripcion.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'FrmNutrientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 466)
        Me.Controls.Add(Me.dgvNutrientes)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.cmbUnidadMedida)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.mtbMenu)
        Me.Name = "FrmNutrientes"
        Me.Text = "NUTRIENTES"
        CType(Me.dgvNutrientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents mtbMenu As MEAToolBar.MEAToolBar
    Friend WithEvents txtDescripcion As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbUnidadMedida As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents dgvNutrientes As System.Windows.Forms.DataGridView
    Friend WithEvents clmIdNutriente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
