<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarProveedores
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
        Me.btnCacnelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRfc = New System.Windows.Forms.TextBox()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar()
        Me.grpEstatus = New System.Windows.Forms.GroupBox()
        Me.chkInactivo = New System.Windows.Forms.CheckBox()
        Me.chkVigente = New System.Windows.Forms.CheckBox()
        Me.TiposProveedorC = New ClasesNegocio.TiposProveedorCollectionClass()
        Me.chkDeGando = New System.Windows.Forms.CheckBox()
        Me.clmCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmRazonSocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmRFC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFechaAlta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEstatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCacnelar
        '
        Me.btnCacnelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCacnelar.Location = New System.Drawing.Point(890, 556)
        Me.btnCacnelar.Name = "btnCacnelar"
        Me.btnCacnelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCacnelar.TabIndex = 25
        Me.btnCacnelar.Text = "Cancelar"
        Me.btnCacnelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Location = New System.Drawing.Point(809, 556)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 24
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DataGrid)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(55, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(910, 466)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Proveedores Registrados"
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmCodigo, Me.clmRazonSocial, Me.clmRFC, Me.clmFechaAlta, Me.clmEstatus})
        Me.DataGrid.Location = New System.Drawing.Point(6, 24)
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(898, 436)
        Me.DataGrid.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.SteelBlue
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(50, 0)
        Me.Label6.MaximumSize = New System.Drawing.Size(1800, 1800)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(927, 29)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "BUSQUEDA DE PROVEEDORES"
        '
        'txtRfc
        '
        Me.txtRfc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRfc.Location = New System.Drawing.Point(269, 32)
        Me.txtRfc.MaxLength = 20
        Me.txtRfc.Name = "txtRfc"
        Me.txtRfc.Size = New System.Drawing.Size(129, 20)
        Me.txtRfc.TabIndex = 21
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRazonSocial.Location = New System.Drawing.Point(145, 58)
        Me.txtRazonSocial.MaxLength = 80
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(490, 20)
        Me.txtRazonSocial.TabIndex = 20
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Location = New System.Drawing.Point(145, 32)
        Me.txtCodigo.MaxLength = 4
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(72, 20)
        Me.txtCodigo.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(223, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "R.F.C.:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Razón Social:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Codigo:"
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
        Me.MEAToolBar1.MostrarBorrar = False
        Me.MEAToolBar1.MostrarBuscar = True
        Me.MEAToolBar1.MostrarCancelar = False
        Me.MEAToolBar1.MostrarEditar = False
        Me.MEAToolBar1.MostrarGuardar = False
        Me.MEAToolBar1.MostrarImprimir = False
        Me.MEAToolBar1.MostrarLimpiar = True
        Me.MEAToolBar1.MostrarNuevo = False
        Me.MEAToolBar1.MostrarSalir = True
        Me.MEAToolBar1.Name = "MEAToolBar1"
        Me.MEAToolBar1.ShowToolTips = True
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 585)
        Me.MEAToolBar1.TabIndex = 27
        '
        'grpEstatus
        '
        Me.grpEstatus.Controls.Add(Me.chkInactivo)
        Me.grpEstatus.Controls.Add(Me.chkVigente)
        Me.grpEstatus.Location = New System.Drawing.Point(641, 32)
        Me.grpEstatus.Name = "grpEstatus"
        Me.grpEstatus.Size = New System.Drawing.Size(143, 46)
        Me.grpEstatus.TabIndex = 28
        Me.grpEstatus.TabStop = False
        Me.grpEstatus.Text = "Estatus"
        '
        'chkInactivo
        '
        Me.chkInactivo.AutoSize = True
        Me.chkInactivo.Checked = True
        Me.chkInactivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkInactivo.Location = New System.Drawing.Point(74, 19)
        Me.chkInactivo.Name = "chkInactivo"
        Me.chkInactivo.Size = New System.Drawing.Size(64, 17)
        Me.chkInactivo.TabIndex = 1
        Me.chkInactivo.Text = "Inactivo"
        Me.chkInactivo.UseVisualStyleBackColor = True
        '
        'chkVigente
        '
        Me.chkVigente.AutoSize = True
        Me.chkVigente.Checked = True
        Me.chkVigente.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVigente.Location = New System.Drawing.Point(6, 19)
        Me.chkVigente.Name = "chkVigente"
        Me.chkVigente.Size = New System.Drawing.Size(62, 17)
        Me.chkVigente.TabIndex = 0
        Me.chkVigente.Text = "Vigente"
        Me.chkVigente.UseVisualStyleBackColor = True
        '
        'TiposProveedorC
        '
        Me.TiposProveedorC.AllowEdit = True
        Me.TiposProveedorC.AllowNew = True
        Me.TiposProveedorC.AllowRemove = True
        Me.TiposProveedorC.MaximoElementosSeleccionados = 1
        Me.TiposProveedorC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.TiposProveedorC.MostrarAlertas = False
        Me.TiposProveedorC.Name = ""
        Me.TiposProveedorC.RaiseListChangedEvents = True
        Me.TiposProveedorC.Transaction = Nothing
        '
        'chkDeGando
        '
        Me.chkDeGando.AutoSize = True
        Me.chkDeGando.Location = New System.Drawing.Point(434, 33)
        Me.chkDeGando.Name = "chkDeGando"
        Me.chkDeGando.Size = New System.Drawing.Size(115, 17)
        Me.chkDeGando.TabIndex = 29
        Me.chkDeGando.Text = "Proveedor Primario"
        Me.chkDeGando.UseVisualStyleBackColor = True
        '
        'clmCodigo
        '
        Me.clmCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clmCodigo.DataPropertyName = "IdProveedor"
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.clmCodigo.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmCodigo.FillWeight = 10.0!
        Me.clmCodigo.HeaderText = "Código"
        Me.clmCodigo.Name = "clmCodigo"
        Me.clmCodigo.ReadOnly = True
        '
        'clmRazonSocial
        '
        Me.clmRazonSocial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clmRazonSocial.DataPropertyName = "PrRazSocial"
        Me.clmRazonSocial.FillWeight = 45.0!
        Me.clmRazonSocial.HeaderText = "Razón Social"
        Me.clmRazonSocial.Name = "clmRazonSocial"
        Me.clmRazonSocial.ReadOnly = True
        '
        'clmRFC
        '
        Me.clmRFC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clmRFC.DataPropertyName = "PrRFC"
        Me.clmRFC.FillWeight = 15.0!
        Me.clmRFC.HeaderText = "RFC"
        Me.clmRFC.Name = "clmRFC"
        Me.clmRFC.ReadOnly = True
        '
        'clmFechaAlta
        '
        Me.clmFechaAlta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clmFechaAlta.DataPropertyName = "PrFechaAlta"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.clmFechaAlta.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmFechaAlta.FillWeight = 15.0!
        Me.clmFechaAlta.HeaderText = "Fecha Alta"
        Me.clmFechaAlta.Name = "clmFechaAlta"
        Me.clmFechaAlta.ReadOnly = True
        '
        'clmEstatus
        '
        Me.clmEstatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.clmEstatus.DataPropertyName = "EstatusCad"
        Me.clmEstatus.FillWeight = 15.0!
        Me.clmEstatus.HeaderText = "Estatus"
        Me.clmEstatus.Name = "clmEstatus"
        Me.clmEstatus.ReadOnly = True
        '
        'FrmBuscarProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 585)
        Me.Controls.Add(Me.chkDeGando)
        Me.Controls.Add(Me.grpEstatus)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnCacnelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtRfc)
        Me.Controls.Add(Me.txtRazonSocial)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.MinimumSize = New System.Drawing.Size(985, 619)
        Me.Name = "FrmBuscarProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de Proveedores"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEstatus.ResumeLayout(False)
        Me.grpEstatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCacnelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtRfc As System.Windows.Forms.TextBox
    Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents grpEstatus As System.Windows.Forms.GroupBox
    Friend WithEvents chkInactivo As System.Windows.Forms.CheckBox
    Friend WithEvents chkVigente As System.Windows.Forms.CheckBox
    Friend WithEvents TiposProveedorC As ClasesNegocio.TiposProveedorCollectionClass
    Friend WithEvents chkDeGando As System.Windows.Forms.CheckBox
    Friend WithEvents clmCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmRazonSocial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmRFC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaAlta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
