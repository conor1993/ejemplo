<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CatBeneficiariosForm
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
        Me.gpo = New System.Windows.Forms.GroupBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.chkTodos = New System.Windows.Forms.CheckBox
        Me.Txtfiltro = New System.Windows.Forms.TextBox
        Me.dgvBeneficiarios = New System.Windows.Forms.DataGridView
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BeneficiarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EsProveedorDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Beneficiarios = New ClasesNegocio.BeneficiarioCollectionClass
        Me.pan = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.gpo.SuspendLayout()
        CType(Me.dgvBeneficiarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pan.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpo
        '
        Me.gpo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpo.Controls.Add(Me.Label13)
        Me.gpo.Controls.Add(Me.chkTodos)
        Me.gpo.Controls.Add(Me.Txtfiltro)
        Me.gpo.Controls.Add(Me.dgvBeneficiarios)
        Me.gpo.Location = New System.Drawing.Point(55, 108)
        Me.gpo.Name = "gpo"
        Me.gpo.Size = New System.Drawing.Size(545, 345)
        Me.gpo.TabIndex = 7
        Me.gpo.TabStop = False
        Me.gpo.Text = "Beneficiarios Registrados"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(7, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Buscar:"
        '
        'chkTodos
        '
        Me.chkTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkTodos.AutoSize = True
        Me.chkTodos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkTodos.Location = New System.Drawing.Point(445, 19)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(94, 17)
        Me.chkTodos.TabIndex = 0
        Me.chkTodos.Text = "Mostrar Todos"
        Me.chkTodos.UseVisualStyleBackColor = True
        '
        'Txtfiltro
        '
        Me.Txtfiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtfiltro.Location = New System.Drawing.Point(56, 17)
        Me.Txtfiltro.Name = "Txtfiltro"
        Me.Txtfiltro.Size = New System.Drawing.Size(199, 20)
        Me.Txtfiltro.TabIndex = 42
        '
        'dgvBeneficiarios
        '
        Me.dgvBeneficiarios.AllowUserToAddRows = False
        Me.dgvBeneficiarios.AllowUserToDeleteRows = False
        Me.dgvBeneficiarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBeneficiarios.AutoGenerateColumns = False
        Me.dgvBeneficiarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBeneficiarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.BeneficiarioDataGridViewTextBoxColumn, Me.EsProveedorDataGridViewCheckBoxColumn, Me.EstatusDataGridViewTextBoxColumn})
        Me.dgvBeneficiarios.DataSource = Me.Beneficiarios
        Me.dgvBeneficiarios.Location = New System.Drawing.Point(10, 52)
        Me.dgvBeneficiarios.MultiSelect = False
        Me.dgvBeneficiarios.Name = "dgvBeneficiarios"
        Me.dgvBeneficiarios.ReadOnly = True
        Me.dgvBeneficiarios.RowHeadersVisible = False
        Me.dgvBeneficiarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBeneficiarios.Size = New System.Drawing.Size(529, 287)
        Me.dgvBeneficiarios.TabIndex = 1
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "Codigo"
        Me.Codigo.Frozen = True
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 60
        '
        'BeneficiarioDataGridViewTextBoxColumn
        '
        Me.BeneficiarioDataGridViewTextBoxColumn.DataPropertyName = "Beneficiario"
        Me.BeneficiarioDataGridViewTextBoxColumn.Frozen = True
        Me.BeneficiarioDataGridViewTextBoxColumn.HeaderText = "Beneficiario"
        Me.BeneficiarioDataGridViewTextBoxColumn.Name = "BeneficiarioDataGridViewTextBoxColumn"
        Me.BeneficiarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.BeneficiarioDataGridViewTextBoxColumn.Width = 250
        '
        'EsProveedorDataGridViewCheckBoxColumn
        '
        Me.EsProveedorDataGridViewCheckBoxColumn.DataPropertyName = "EsProveedor"
        Me.EsProveedorDataGridViewCheckBoxColumn.HeaderText = "Es Proveedor"
        Me.EsProveedorDataGridViewCheckBoxColumn.Name = "EsProveedorDataGridViewCheckBoxColumn"
        Me.EsProveedorDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'EstatusDataGridViewTextBoxColumn
        '
        Me.EstatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.HeaderText = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.Name = "EstatusDataGridViewTextBoxColumn"
        Me.EstatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Beneficiarios
        '
        Me.Beneficiarios.AllowEdit = True
        Me.Beneficiarios.AllowNew = True
        Me.Beneficiarios.AllowRemove = True
        Me.Beneficiarios.Name = Nothing
        Me.Beneficiarios.RaiseListChangedEvents = True
        '
        'pan
        '
        Me.pan.Controls.Add(Me.Label2)
        Me.pan.Controls.Add(Me.txtDescripcion)
        Me.pan.Location = New System.Drawing.Point(55, 65)
        Me.pan.Name = "pan"
        Me.pan.Size = New System.Drawing.Size(534, 32)
        Me.pan.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Beneficiario:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(94, 6)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(296, 20)
        Me.txtDescripcion.TabIndex = 3
        '
        'mtb
        '
        Me.mtb.ButtonSize = New System.Drawing.Size(50, 50)
        Me.mtb.Dock = System.Windows.Forms.DockStyle.None
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
        Me.mtb.Location = New System.Drawing.Point(3, 28)
        Me.mtb.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.mtb.MostrarBorrar = True
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = True
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 747)
        Me.mtb.TabIndex = 4
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(616, 30)
        Me.lblTitulo.TabIndex = 5
        Me.lblTitulo.Text = "CATÁLOGO BENEFICIARIOS"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEstatus
        '
        Me.lblEstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(472, 34)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(122, 21)
        Me.lblEstatus.TabIndex = 22
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CatBeneficiariosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 465)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lblEstatus)
        Me.Controls.Add(Me.gpo)
        Me.Controls.Add(Me.pan)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(618, 497)
        Me.MinimumSize = New System.Drawing.Size(618, 497)
        Me.Name = "CatBeneficiariosForm"
        Me.Text = "Beneficiarios"
        Me.gpo.ResumeLayout(False)
        Me.gpo.PerformLayout()
        CType(Me.dgvBeneficiarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pan.ResumeLayout(False)
        Me.pan.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gpo As System.Windows.Forms.GroupBox
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents dgvBeneficiarios As System.Windows.Forms.DataGridView
    Friend WithEvents pan As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents Beneficiarios As ClasesNegocio.BeneficiarioCollectionClass
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Txtfiltro As System.Windows.Forms.TextBox
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BeneficiarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EsProveedorDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
