Imports CCS = Integralab.ORMSeguridad.CollectionClasses
Imports ECS = Integralab.ORMSeguridad.EntityClasses
Imports HCS = Integralab.ORMSeguridad.HelperClasses
Imports FCS = Integralab.ORMSeguridad.FactoryClasses

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmpresasForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmpresasForm))
        Me.tabla = New System.Windows.Forms.TableLayoutPanel
        Me.Label2 = New System.Windows.Forms.Label
        Me.CodigoLabel = New System.Windows.Forms.Label
        Me.NombreLabel = New System.Windows.Forms.Label
        Me.CodigoTextBox = New System.Windows.Forms.TextBox
        Me.NombreTextBox = New System.Windows.Forms.TextBox
        Me.CatalogoTextBox = New System.Windows.Forms.TextBox
        Me.CatalogoLabel = New System.Windows.Forms.Label
        Me.ServidorLabel = New System.Windows.Forms.Label
        Me.ServidorTextBox = New System.Windows.Forms.TextBox
        Me.chkSI = New System.Windows.Forms.CheckBox
        Me.UserNameLabel = New System.Windows.Forms.Label
        Me.PassWordLabel = New System.Windows.Forms.Label
        Me.UserNameTextBox = New System.Windows.Forms.TextBox
        Me.PassWordTextBox = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.brnCambiar = New System.Windows.Forms.Button
        Me.pic = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnCambiarIcono = New System.Windows.Forms.Button
        Me.pcbIcono = New System.Windows.Forms.PictureBox
        Me.EmpresasDataGridView = New System.Windows.Forms.DataGridView
        Me.EmpidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EmpnomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EmpcatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Empresas = New Integralab.ORMSeguridad.CollectionClasses.EmpresasCollection
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.ColorDg = New System.Windows.Forms.ColorDialog
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AbrirArchivo = New System.Windows.Forms.OpenFileDialog
        Me.tabla.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.pcbIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabla
        '
        Me.tabla.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tabla.ColumnCount = 2
        Me.tabla.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tabla.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tabla.Controls.Add(Me.Label2, 0, 8)
        Me.tabla.Controls.Add(Me.CodigoLabel, 0, 0)
        Me.tabla.Controls.Add(Me.NombreLabel, 0, 1)
        Me.tabla.Controls.Add(Me.CodigoTextBox, 1, 0)
        Me.tabla.Controls.Add(Me.NombreTextBox, 1, 1)
        Me.tabla.Controls.Add(Me.CatalogoTextBox, 1, 3)
        Me.tabla.Controls.Add(Me.CatalogoLabel, 0, 3)
        Me.tabla.Controls.Add(Me.ServidorLabel, 0, 2)
        Me.tabla.Controls.Add(Me.ServidorTextBox, 1, 2)
        Me.tabla.Controls.Add(Me.chkSI, 0, 4)
        Me.tabla.Controls.Add(Me.UserNameLabel, 0, 5)
        Me.tabla.Controls.Add(Me.PassWordLabel, 0, 6)
        Me.tabla.Controls.Add(Me.UserNameTextBox, 1, 5)
        Me.tabla.Controls.Add(Me.PassWordTextBox, 1, 6)
        Me.tabla.Controls.Add(Me.Panel1, 1, 7)
        Me.tabla.Controls.Add(Me.Label1, 0, 7)
        Me.tabla.Controls.Add(Me.Panel2, 1, 8)
        Me.tabla.Location = New System.Drawing.Point(55, 12)
        Me.tabla.Name = "tabla"
        Me.tabla.RowCount = 9
        Me.tabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49877!))
        Me.tabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49876!))
        Me.tabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49876!))
        Me.tabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50256!))
        Me.tabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.48387!))
        Me.tabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.17391!))
        Me.tabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.6087!))
        Me.tabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.95652!))
        Me.tabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.tabla.Size = New System.Drawing.Size(471, 274)
        Me.tabla.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Icono:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CodigoLabel
        '
        Me.CodigoLabel.AutoSize = True
        Me.CodigoLabel.Location = New System.Drawing.Point(3, 0)
        Me.CodigoLabel.Name = "CodigoLabel"
        Me.CodigoLabel.Size = New System.Drawing.Size(113, 13)
        Me.CodigoLabel.TabIndex = 0
        Me.CodigoLabel.Text = "Codigo de la Empresa:"
        Me.CodigoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NombreLabel
        '
        Me.NombreLabel.AutoSize = True
        Me.NombreLabel.Location = New System.Drawing.Point(3, 27)
        Me.NombreLabel.Name = "NombreLabel"
        Me.NombreLabel.Size = New System.Drawing.Size(117, 13)
        Me.NombreLabel.TabIndex = 1
        Me.NombreLabel.Text = "Nombre de la Empresa:"
        Me.NombreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CodigoTextBox.Location = New System.Drawing.Point(153, 3)
        Me.CodigoTextBox.MaxLength = 15
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(315, 20)
        Me.CodigoTextBox.TabIndex = 4
        '
        'NombreTextBox
        '
        Me.NombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NombreTextBox.Location = New System.Drawing.Point(153, 30)
        Me.NombreTextBox.MaxLength = 100
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(315, 20)
        Me.NombreTextBox.TabIndex = 5
        '
        'CatalogoTextBox
        '
        Me.CatalogoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CatalogoTextBox.Location = New System.Drawing.Point(153, 84)
        Me.CatalogoTextBox.MaxLength = 50
        Me.CatalogoTextBox.Name = "CatalogoTextBox"
        Me.CatalogoTextBox.Size = New System.Drawing.Size(315, 20)
        Me.CatalogoTextBox.TabIndex = 7
        '
        'CatalogoLabel
        '
        Me.CatalogoLabel.AutoSize = True
        Me.CatalogoLabel.Location = New System.Drawing.Point(3, 81)
        Me.CatalogoLabel.Name = "CatalogoLabel"
        Me.CatalogoLabel.Size = New System.Drawing.Size(52, 13)
        Me.CatalogoLabel.TabIndex = 3
        Me.CatalogoLabel.Text = "Catalogo:"
        Me.CatalogoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ServidorLabel
        '
        Me.ServidorLabel.AutoSize = True
        Me.ServidorLabel.Location = New System.Drawing.Point(3, 54)
        Me.ServidorLabel.Name = "ServidorLabel"
        Me.ServidorLabel.Size = New System.Drawing.Size(49, 13)
        Me.ServidorLabel.TabIndex = 2
        Me.ServidorLabel.Text = "Servidor:"
        Me.ServidorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ServidorTextBox
        '
        Me.ServidorTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ServidorTextBox.Location = New System.Drawing.Point(153, 57)
        Me.ServidorTextBox.MaxLength = 50
        Me.ServidorTextBox.Name = "ServidorTextBox"
        Me.ServidorTextBox.Size = New System.Drawing.Size(315, 20)
        Me.ServidorTextBox.TabIndex = 6
        '
        'chkSI
        '
        Me.chkSI.AutoSize = True
        Me.chkSI.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSI.Checked = True
        Me.chkSI.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSI.Location = New System.Drawing.Point(3, 111)
        Me.chkSI.Name = "chkSI"
        Me.chkSI.Size = New System.Drawing.Size(125, 17)
        Me.chkSI.TabIndex = 8
        Me.chkSI.Text = "Seguridad Integrada:"
        Me.chkSI.UseVisualStyleBackColor = True
        '
        'UserNameLabel
        '
        Me.UserNameLabel.AutoSize = True
        Me.UserNameLabel.Location = New System.Drawing.Point(3, 131)
        Me.UserNameLabel.Name = "UserNameLabel"
        Me.UserNameLabel.Size = New System.Drawing.Size(101, 13)
        Me.UserNameLabel.TabIndex = 9
        Me.UserNameLabel.Text = "Nombre de Usuario:"
        Me.UserNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PassWordLabel
        '
        Me.PassWordLabel.AutoSize = True
        Me.PassWordLabel.Location = New System.Drawing.Point(3, 158)
        Me.PassWordLabel.Name = "PassWordLabel"
        Me.PassWordLabel.Size = New System.Drawing.Size(64, 13)
        Me.PassWordLabel.TabIndex = 10
        Me.PassWordLabel.Text = "Contraseña:"
        Me.PassWordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserNameTextBox.Enabled = False
        Me.UserNameTextBox.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserNameTextBox.Location = New System.Drawing.Point(153, 134)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(315, 22)
        Me.UserNameTextBox.TabIndex = 11
        '
        'PassWordTextBox
        '
        Me.PassWordTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PassWordTextBox.Enabled = False
        Me.PassWordTextBox.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassWordTextBox.Location = New System.Drawing.Point(153, 161)
        Me.PassWordTextBox.Name = "PassWordTextBox"
        Me.PassWordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassWordTextBox.Size = New System.Drawing.Size(315, 22)
        Me.PassWordTextBox.TabIndex = 12
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.brnCambiar)
        Me.Panel1.Controls.Add(Me.pic)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(150, 186)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(321, 37)
        Me.Panel1.TabIndex = 14
        '
        'brnCambiar
        '
        Me.brnCambiar.Location = New System.Drawing.Point(109, 3)
        Me.brnCambiar.Name = "brnCambiar"
        Me.brnCambiar.Size = New System.Drawing.Size(74, 27)
        Me.brnCambiar.TabIndex = 1
        Me.brnCambiar.Text = "Cambiar..."
        Me.brnCambiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.brnCambiar.UseVisualStyleBackColor = True
        '
        'pic
        '
        Me.pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic.Location = New System.Drawing.Point(3, 3)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(100, 27)
        Me.pic.TabIndex = 0
        Me.pic.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Color:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnCambiarIcono)
        Me.Panel2.Controls.Add(Me.pcbIcono)
        Me.Panel2.Location = New System.Drawing.Point(153, 226)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 45)
        Me.Panel2.TabIndex = 16
        '
        'btnCambiarIcono
        '
        Me.btnCambiarIcono.Location = New System.Drawing.Point(49, 13)
        Me.btnCambiarIcono.Name = "btnCambiarIcono"
        Me.btnCambiarIcono.Size = New System.Drawing.Size(74, 27)
        Me.btnCambiarIcono.TabIndex = 2
        Me.btnCambiarIcono.Text = "Cambiar..."
        Me.btnCambiarIcono.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCambiarIcono.UseVisualStyleBackColor = True
        '
        'pcbIcono
        '
        Me.pcbIcono.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pcbIcono.Location = New System.Drawing.Point(3, 6)
        Me.pcbIcono.Name = "pcbIcono"
        Me.pcbIcono.Size = New System.Drawing.Size(40, 34)
        Me.pcbIcono.TabIndex = 0
        Me.pcbIcono.TabStop = False
        '
        'EmpresasDataGridView
        '
        Me.EmpresasDataGridView.AllowUserToAddRows = False
        Me.EmpresasDataGridView.AllowUserToDeleteRows = False
        Me.EmpresasDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmpresasDataGridView.AutoGenerateColumns = False
        Me.EmpresasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpresasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpidDataGridViewTextBoxColumn, Me.EmpnomDataGridViewTextBoxColumn, Me.EmpcatDataGridViewTextBoxColumn})
        Me.EmpresasDataGridView.DataSource = Me.Empresas
        Me.EmpresasDataGridView.Location = New System.Drawing.Point(55, 303)
        Me.EmpresasDataGridView.Name = "EmpresasDataGridView"
        Me.EmpresasDataGridView.ReadOnly = True
        Me.EmpresasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.EmpresasDataGridView.Size = New System.Drawing.Size(471, 139)
        Me.EmpresasDataGridView.TabIndex = 2
        '
        'EmpidDataGridViewTextBoxColumn
        '
        Me.EmpidDataGridViewTextBoxColumn.DataPropertyName = "Empid"
        Me.EmpidDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.EmpidDataGridViewTextBoxColumn.Name = "EmpidDataGridViewTextBoxColumn"
        Me.EmpidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpnomDataGridViewTextBoxColumn
        '
        Me.EmpnomDataGridViewTextBoxColumn.DataPropertyName = "Empnom"
        Me.EmpnomDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.EmpnomDataGridViewTextBoxColumn.Name = "EmpnomDataGridViewTextBoxColumn"
        Me.EmpnomDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmpnomDataGridViewTextBoxColumn.Width = 250
        '
        'EmpcatDataGridViewTextBoxColumn
        '
        Me.EmpcatDataGridViewTextBoxColumn.DataPropertyName = "Empcat"
        Me.EmpcatDataGridViewTextBoxColumn.HeaderText = "Catalogo"
        Me.EmpcatDataGridViewTextBoxColumn.Name = "EmpcatDataGridViewTextBoxColumn"
        Me.EmpcatDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmpcatDataGridViewTextBoxColumn.Width = 150
        '
        'Empresas
        '
        Me.Empresas.ActiveContext = Nothing
        Me.Empresas.AllowEdit = True
        Me.Empresas.AllowNew = True
        Me.Empresas.AllowRemove = True
        Me.Empresas.Capacity = 32
        Me.Empresas.ConcurrencyPredicateFactoryToUse = Nothing
        Me.Empresas.DoNotPerformAddIfPresent = False
        Me.Empresas.EntityFactoryToUse = New Integralab.ORMSeguridad.FactoryClasses.EmpresasEntityFactory
        Me.Empresas.IsReadOnly = False
        Me.Empresas.MaxNumberOfItemsToReturn = CType(0, Long)
        Me.Empresas.SortClauses = Nothing
        Me.Empresas.SuppressClearInGetMulti = False
        Me.Empresas.Transaction = Nothing
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
        Me.mtb.Size = New System.Drawing.Size(50, 454)
        Me.mtb.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Empid"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Empnom"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 250
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Empcat"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Catalogo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'AbrirArchivo
        '
        Me.AbrirArchivo.Filter = "Iconos|*.ico"
        '
        'EmpresasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 454)
        Me.Controls.Add(Me.EmpresasDataGridView)
        Me.Controls.Add(Me.tabla)
        Me.Controls.Add(Me.mtb)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(543, 481)
        Me.Name = "EmpresasForm"
        Me.Text = "Catalogo de Empresas"
        Me.tabla.ResumeLayout(False)
        Me.tabla.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.pcbIcono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents tabla As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents CodigoLabel As System.Windows.Forms.Label
    Friend WithEvents NombreLabel As System.Windows.Forms.Label
    Friend WithEvents CatalogoLabel As System.Windows.Forms.Label
    Friend WithEvents CodigoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CatalogoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmpresasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents EmpidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpnomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpcatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Empresas As CCS.EmpresasCollection
    Friend WithEvents ServidorLabel As System.Windows.Forms.Label
    Friend WithEvents ServidorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents chkSI As System.Windows.Forms.CheckBox
    Friend WithEvents UserNameLabel As System.Windows.Forms.Label
    Friend WithEvents PassWordLabel As System.Windows.Forms.Label
    Friend WithEvents UserNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PassWordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ColorDg As System.Windows.Forms.ColorDialog
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pic As System.Windows.Forms.PictureBox
    Friend WithEvents brnCambiar As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AbrirArchivo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnCambiarIcono As System.Windows.Forms.Button
    Friend WithEvents pcbIcono As System.Windows.Forms.PictureBox
End Class
