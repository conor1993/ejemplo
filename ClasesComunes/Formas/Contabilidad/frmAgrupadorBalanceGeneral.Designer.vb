<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgrupadorBalanceGeneral
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
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbnEstadoResultados = New System.Windows.Forms.RadioButton()
        Me.rbnBalancegrl = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvAgrupadoresBalanceGeneral = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtOrden = New System.Windows.Forms.TextBox()
        Me.grbTipo = New System.Windows.Forms.GroupBox()
        Me.rbnPasivo = New System.Windows.Forms.RadioButton()
        Me.rbnActivo = New System.Windows.Forms.RadioButton()
        Me.clmCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmBalanceGral = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmDescripcionBalanceGral = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmPriodidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvAgrupadoresBalanceGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbTipo.SuspendLayout()
        Me.SuspendLayout()
        '
        'MEAToolBar1
        '
        Me.MEAToolBar1.ButtonSize = New System.Drawing.Size(50, 50)
        Me.MEAToolBar1.Dock = System.Windows.Forms.DockStyle.None
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
        Me.MEAToolBar1.Location = New System.Drawing.Point(1, -27)
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
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 747)
        Me.MEAToolBar1.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(697, 29)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "CATÁLOGO DE AGUPADORES PARA BALANCE GENERAL"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Codigo:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(130, 41)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(74, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Descripcion:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(130, 67)
        Me.txtDescripcion.MaxLength = 80
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(280, 20)
        Me.txtDescripcion.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbnEstadoResultados)
        Me.GroupBox1.Controls.Add(Me.rbnBalancegrl)
        Me.GroupBox1.Location = New System.Drawing.Point(223, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(269, 42)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agrupadores para"
        Me.GroupBox1.Visible = False
        '
        'rbnEstadoResultados
        '
        Me.rbnEstadoResultados.AutoSize = True
        Me.rbnEstadoResultados.Location = New System.Drawing.Point(131, 16)
        Me.rbnEstadoResultados.Name = "rbnEstadoResultados"
        Me.rbnEstadoResultados.Size = New System.Drawing.Size(129, 17)
        Me.rbnEstadoResultados.TabIndex = 6
        Me.rbnEstadoResultados.TabStop = True
        Me.rbnEstadoResultados.Text = "Estado de Resultados"
        Me.rbnEstadoResultados.UseVisualStyleBackColor = True
        Me.rbnEstadoResultados.Visible = False
        '
        'rbnBalancegrl
        '
        Me.rbnBalancegrl.AutoSize = True
        Me.rbnBalancegrl.Location = New System.Drawing.Point(18, 16)
        Me.rbnBalancegrl.Name = "rbnBalancegrl"
        Me.rbnBalancegrl.Size = New System.Drawing.Size(104, 17)
        Me.rbnBalancegrl.TabIndex = 5
        Me.rbnBalancegrl.TabStop = True
        Me.rbnBalancegrl.Text = "Balance General"
        Me.rbnBalancegrl.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvAgrupadoresBalanceGeneral)
        Me.GroupBox2.Location = New System.Drawing.Point(55, 141)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(629, 315)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Agrupadores"
        '
        'dgvAgrupadoresBalanceGeneral
        '
        Me.dgvAgrupadoresBalanceGeneral.AllowUserToAddRows = False
        Me.dgvAgrupadoresBalanceGeneral.AllowUserToDeleteRows = False
        Me.dgvAgrupadoresBalanceGeneral.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAgrupadoresBalanceGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAgrupadoresBalanceGeneral.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmCodigo, Me.clmDescripcion, Me.clmBalanceGral, Me.clmDescripcionBalanceGral, Me.clmPriodidad})
        Me.dgvAgrupadoresBalanceGeneral.Location = New System.Drawing.Point(6, 19)
        Me.dgvAgrupadoresBalanceGeneral.Name = "dgvAgrupadoresBalanceGeneral"
        Me.dgvAgrupadoresBalanceGeneral.RowHeadersVisible = False
        Me.dgvAgrupadoresBalanceGeneral.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAgrupadoresBalanceGeneral.Size = New System.Drawing.Size(616, 284)
        Me.dgvAgrupadoresBalanceGeneral.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Código"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "BalanceGral"
        Me.DataGridViewTextBoxColumn3.HeaderText = "BalanceGral"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Agrupador para"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 140
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(220, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Orden:"
        '
        'txtOrden
        '
        Me.txtOrden.Location = New System.Drawing.Point(271, 41)
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.Size = New System.Drawing.Size(53, 20)
        Me.txtOrden.TabIndex = 2
        '
        'grbTipo
        '
        Me.grbTipo.Controls.Add(Me.rbnPasivo)
        Me.grbTipo.Controls.Add(Me.rbnActivo)
        Me.grbTipo.Location = New System.Drawing.Point(61, 93)
        Me.grbTipo.Name = "grbTipo"
        Me.grbTipo.Size = New System.Drawing.Size(156, 42)
        Me.grbTipo.TabIndex = 45
        Me.grbTipo.TabStop = False
        Me.grbTipo.Text = "Tipo"
        '
        'rbnPasivo
        '
        Me.rbnPasivo.AutoSize = True
        Me.rbnPasivo.Location = New System.Drawing.Point(86, 16)
        Me.rbnPasivo.Name = "rbnPasivo"
        Me.rbnPasivo.Size = New System.Drawing.Size(57, 17)
        Me.rbnPasivo.TabIndex = 4
        Me.rbnPasivo.TabStop = True
        Me.rbnPasivo.Text = "Pasivo"
        Me.rbnPasivo.UseVisualStyleBackColor = True
        '
        'rbnActivo
        '
        Me.rbnActivo.AutoSize = True
        Me.rbnActivo.Location = New System.Drawing.Point(19, 16)
        Me.rbnActivo.Name = "rbnActivo"
        Me.rbnActivo.Size = New System.Drawing.Size(55, 17)
        Me.rbnActivo.TabIndex = 3
        Me.rbnActivo.TabStop = True
        Me.rbnActivo.Text = "Activo"
        Me.rbnActivo.UseVisualStyleBackColor = True
        '
        'clmCodigo
        '
        Me.clmCodigo.DataPropertyName = "Código"
        Me.clmCodigo.FillWeight = 60.0!
        Me.clmCodigo.HeaderText = "Codigo"
        Me.clmCodigo.Name = "clmCodigo"
        Me.clmCodigo.ReadOnly = True
        '
        'clmDescripcion
        '
        Me.clmDescripcion.DataPropertyName = "Descripcion"
        Me.clmDescripcion.FillWeight = 150.0!
        Me.clmDescripcion.HeaderText = "Descripcion"
        Me.clmDescripcion.Name = "clmDescripcion"
        Me.clmDescripcion.ReadOnly = True
        '
        'clmBalanceGral
        '
        Me.clmBalanceGral.DataPropertyName = "BalanceGral"
        Me.clmBalanceGral.HeaderText = "BalanceGral"
        Me.clmBalanceGral.Name = "clmBalanceGral"
        Me.clmBalanceGral.ReadOnly = True
        Me.clmBalanceGral.Visible = False
        '
        'clmDescripcionBalanceGral
        '
        Me.clmDescripcionBalanceGral.FillWeight = 120.0!
        Me.clmDescripcionBalanceGral.HeaderText = "Agrupador para"
        Me.clmDescripcionBalanceGral.Name = "clmDescripcionBalanceGral"
        Me.clmDescripcionBalanceGral.ReadOnly = True
        '
        'clmPriodidad
        '
        Me.clmPriodidad.DataPropertyName = "Prioridad"
        Me.clmPriodidad.FillWeight = 80.0!
        Me.clmPriodidad.HeaderText = "Orden"
        Me.clmPriodidad.Name = "clmPriodidad"
        Me.clmPriodidad.ReadOnly = True
        '
        'frmAgrupadorBalanceGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 466)
        Me.Controls.Add(Me.grbTipo)
        Me.Controls.Add(Me.txtOrden)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.MaximizeBox = False
        Me.Name = "frmAgrupadorBalanceGeneral"
        Me.Text = "Agrupadores para Balance General"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvAgrupadoresBalanceGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbTipo.ResumeLayout(False)
        Me.grbTipo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbnBalancegrl As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvAgrupadoresBalanceGeneral As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtOrden As System.Windows.Forms.TextBox
    Friend WithEvents grbTipo As System.Windows.Forms.GroupBox
    Friend WithEvents rbnEstadoResultados As System.Windows.Forms.RadioButton
    Friend WithEvents rbnPasivo As System.Windows.Forms.RadioButton
    Friend WithEvents rbnActivo As System.Windows.Forms.RadioButton
    Friend WithEvents clmCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmBalanceGral As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDescripcionBalanceGral As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPriodidad As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
