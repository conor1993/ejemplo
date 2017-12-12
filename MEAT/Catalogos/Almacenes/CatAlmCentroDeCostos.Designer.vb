<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CatAlmCentroDeCostos
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
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmbPlaza = New System.Windows.Forms.ComboBox
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnCta = New System.Windows.Forms.Button
        Me.txtCta = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtFiltro = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.DgvCentros = New System.Windows.Forms.DataGridView
        Me.clmCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIdPlaza = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmPlaza = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIdCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cllmCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Estatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CentroDeCostosC = New ClasesNegocio.CentroDeCostosCollectionClass
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvCentros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.mtb.MostrarBorrar = True
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = True
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 438)
        Me.mtb.TabIndex = 167
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
        Me.lblTitulo.Size = New System.Drawing.Size(534, 29)
        Me.lblTitulo.TabIndex = 168
        Me.lblTitulo.Text = "CENTRO DE COSTOS"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 169
        Me.Label1.Text = "Código:"
        '
        'CmbPlaza
        '
        Me.CmbPlaza.FormattingEnabled = True
        Me.CmbPlaza.Location = New System.Drawing.Point(158, 67)
        Me.CmbPlaza.Name = "CmbPlaza"
        Me.CmbPlaza.Size = New System.Drawing.Size(275, 21)
        Me.CmbPlaza.TabIndex = 170
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(158, 41)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(91, 20)
        Me.txtCodigo.TabIndex = 171
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 172
        Me.Label2.Text = "Plaza:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 173
        Me.Label3.Text = "Descripción:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(158, 93)
        Me.txtDescripcion.MaxLength = 60
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(275, 20)
        Me.txtDescripcion.TabIndex = 174
        '
        'lblEstatus
        '
        Me.lblEstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(412, 36)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(122, 21)
        Me.lblEstatus.TabIndex = 175
        Me.lblEstatus.Text = "ESTATUS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 176
        Me.Label4.Text = "Cuenta Contable:"
        '
        'btnCta
        '
        Me.btnCta.Location = New System.Drawing.Point(479, 120)
        Me.btnCta.Name = "btnCta"
        Me.btnCta.Size = New System.Drawing.Size(26, 22)
        Me.btnCta.TabIndex = 178
        Me.btnCta.Text = "..."
        Me.btnCta.UseVisualStyleBackColor = True
        '
        'txtCta
        '
        Me.txtCta.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCta.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtCta.Location = New System.Drawing.Point(158, 119)
        Me.txtCta.Name = "txtCta"
        Me.txtCta.ReadOnly = True
        Me.txtCta.Size = New System.Drawing.Size(309, 22)
        Me.txtCta.TabIndex = 177
        Me.txtCta.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtFiltro)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DgvCentros)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 158)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(520, 268)
        Me.GroupBox1.TabIndex = 179
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Centros de Costos Registrados"
        '
        'txtFiltro
        '
        Me.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFiltro.Location = New System.Drawing.Point(102, 27)
        Me.txtFiltro.MaxLength = 60
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(275, 20)
        Me.txtFiltro.TabIndex = 181
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 180
        Me.Label5.Text = "Descripción:"
        '
        'DgvCentros
        '
        Me.DgvCentros.AllowUserToAddRows = False
        Me.DgvCentros.AllowUserToDeleteRows = False
        Me.DgvCentros.AutoGenerateColumns = False
        Me.DgvCentros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCentros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmCodigo, Me.clmDescripcion, Me.clmIdPlaza, Me.ClmPlaza, Me.clmIdCuenta, Me.cllmCuenta, Me.Estatus})
        Me.DgvCentros.DataSource = Me.CentroDeCostosC
        Me.DgvCentros.Location = New System.Drawing.Point(6, 53)
        Me.DgvCentros.MultiSelect = False
        Me.DgvCentros.Name = "DgvCentros"
        Me.DgvCentros.ReadOnly = True
        Me.DgvCentros.RowHeadersVisible = False
        Me.DgvCentros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCentros.Size = New System.Drawing.Size(508, 209)
        Me.DgvCentros.TabIndex = 0
        '
        'clmCodigo
        '
        Me.clmCodigo.DataPropertyName = "Codigo"
        Me.clmCodigo.HeaderText = "Codigo"
        Me.clmCodigo.Name = "clmCodigo"
        Me.clmCodigo.ReadOnly = True
        Me.clmCodigo.Width = 50
        '
        'clmDescripcion
        '
        Me.clmDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clmDescripcion.DataPropertyName = "Descripcion"
        Me.clmDescripcion.HeaderText = "Descripcion"
        Me.clmDescripcion.Name = "clmDescripcion"
        Me.clmDescripcion.ReadOnly = True
        Me.clmDescripcion.Width = 88
        '
        'clmIdPlaza
        '
        Me.clmIdPlaza.DataPropertyName = "IdPlaza"
        Me.clmIdPlaza.HeaderText = "IdPlaza"
        Me.clmIdPlaza.Name = "clmIdPlaza"
        Me.clmIdPlaza.ReadOnly = True
        Me.clmIdPlaza.Visible = False
        '
        'ClmPlaza
        '
        Me.ClmPlaza.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ClmPlaza.DataPropertyName = "NomPlaza"
        Me.ClmPlaza.HeaderText = "NomPlaza"
        Me.ClmPlaza.Name = "ClmPlaza"
        Me.ClmPlaza.ReadOnly = True
        Me.ClmPlaza.Width = 80
        '
        'clmIdCuenta
        '
        Me.clmIdCuenta.DataPropertyName = "IdCuentaContable"
        Me.clmIdCuenta.HeaderText = "IdCuentaContable"
        Me.clmIdCuenta.Name = "clmIdCuenta"
        Me.clmIdCuenta.ReadOnly = True
        Me.clmIdCuenta.Visible = False
        '
        'cllmCuenta
        '
        Me.cllmCuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.cllmCuenta.DataPropertyName = "NomCuenta"
        Me.cllmCuenta.HeaderText = "NomCuenta"
        Me.cllmCuenta.Name = "cllmCuenta"
        Me.cllmCuenta.ReadOnly = True
        Me.cllmCuenta.Width = 88
        '
        'Estatus
        '
        Me.Estatus.DataPropertyName = "Estatus"
        Me.Estatus.HeaderText = "Estatus"
        Me.Estatus.Name = "Estatus"
        Me.Estatus.ReadOnly = True
        '
        'CentroDeCostosC
        '
        Me.CentroDeCostosC.AllowEdit = True
        Me.CentroDeCostosC.AllowNew = True
        Me.CentroDeCostosC.AllowRemove = True
        Me.CentroDeCostosC.MaximoElementosSeleccionados = 1
        Me.CentroDeCostosC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.CentroDeCostosC.MostrarAlertas = False
        Me.CentroDeCostosC.Name = Nothing
        Me.CentroDeCostosC.RaiseListChangedEvents = True
        '
        'CatAlmCentroDeCostos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 438)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCta)
        Me.Controls.Add(Me.txtCta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblEstatus)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.CmbPlaza)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.mtb)
        Me.Name = "CatAlmCentroDeCostos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CENTRO DE COSTOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvCentros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbPlaza As System.Windows.Forms.ComboBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCta As System.Windows.Forms.Button
    Friend WithEvents txtCta As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DgvCentros As System.Windows.Forms.DataGridView
    Friend WithEvents CentroDeCostosC As ClasesNegocio.CentroDeCostosCollectionClass
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents clmCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdPlaza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmPlaza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cllmCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estatus As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
