<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompCatPresentacionPdto
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
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar
        Me.Label17 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TxtObservacion = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGrid = New System.Windows.Forms.DataGridView
        Me.CmbUnidadMedida = New System.Windows.Forms.ComboBox
        Me.UnidadesMedidaC = New ClasesNegocio.UnidadesMedidaCollectionClass
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtPiezas = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtDescCorta = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtDescripción = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Txtcodigo = New System.Windows.Forms.TextBox
        Me.LblEstatus = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PresentacionC = New ClasesNegocio.PresentacionCollectionClass
        Me.ClmCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmDescripcionCorta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmPiezas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmUnidadMedida = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 543)
        Me.MEAToolBar1.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.MaximumSize = New System.Drawing.Size(1600, 900)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(756, 29)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "ABC DE PRESENTACIONES DE PRODUCTOS"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.TxtObservacion)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.CmbUnidadMedida)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TxtPiezas)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TxtDescCorta)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TxtDescripción)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Txtcodigo)
        Me.Panel1.Controls.Add(Me.LblEstatus)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(59, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(740, 495)
        Me.Panel1.TabIndex = 2
        '
        'TxtObservacion
        '
        Me.TxtObservacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtObservacion.Location = New System.Drawing.Point(114, 112)
        Me.TxtObservacion.MaxLength = 250
        Me.TxtObservacion.MinimumSize = New System.Drawing.Size(30, 20)
        Me.TxtObservacion.Multiline = True
        Me.TxtObservacion.Name = "TxtObservacion"
        Me.TxtObservacion.Size = New System.Drawing.Size(426, 56)
        Me.TxtObservacion.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Observaciones:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DataGrid)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 188)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(732, 304)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Presentaciones Registradas"
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.AllowUserToResizeRows = False
        Me.DataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClmCodigo, Me.ClmDescripcion, Me.ClmDescripcionCorta, Me.ClmPiezas, Me.ClmUnidadMedida, Me.ClmObservaciones, Me.ClmEstatus})
        Me.DataGrid.Location = New System.Drawing.Point(6, 25)
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(720, 273)
        Me.DataGrid.TabIndex = 0
        '
        'CmbUnidadMedida
        '
        Me.CmbUnidadMedida.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbUnidadMedida.DataSource = Me.UnidadesMedidaC
        Me.CmbUnidadMedida.DisplayMember = "Descripcion"
        Me.CmbUnidadMedida.FormattingEnabled = True
        Me.CmbUnidadMedida.Location = New System.Drawing.Point(357, 85)
        Me.CmbUnidadMedida.Name = "CmbUnidadMedida"
        Me.CmbUnidadMedida.Size = New System.Drawing.Size(183, 21)
        Me.CmbUnidadMedida.TabIndex = 10
        Me.CmbUnidadMedida.ValueMember = "Codigo"
        '
        'UnidadesMedidaC
        '
        Me.UnidadesMedidaC.AllowEdit = True
        Me.UnidadesMedidaC.AllowNew = True
        Me.UnidadesMedidaC.AllowRemove = True
        Me.UnidadesMedidaC.Name = ""
        Me.UnidadesMedidaC.RaiseListChangedEvents = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(254, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Unidad de Medida:"
        '
        'TxtPiezas
        '
        Me.TxtPiezas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPiezas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPiezas.Location = New System.Drawing.Point(114, 85)
        Me.TxtPiezas.MaximumSize = New System.Drawing.Size(150, 20)
        Me.TxtPiezas.MaxLength = 4
        Me.TxtPiezas.MinimumSize = New System.Drawing.Size(30, 20)
        Me.TxtPiezas.Name = "TxtPiezas"
        Me.TxtPiezas.Size = New System.Drawing.Size(82, 20)
        Me.TxtPiezas.TabIndex = 8
        Me.TxtPiezas.Text = "0"
        Me.TxtPiezas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Piezas:"
        '
        'TxtDescCorta
        '
        Me.TxtDescCorta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDescCorta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescCorta.Location = New System.Drawing.Point(114, 59)
        Me.TxtDescCorta.MaxLength = 15
        Me.TxtDescCorta.Name = "TxtDescCorta"
        Me.TxtDescCorta.Size = New System.Drawing.Size(280, 20)
        Me.TxtDescCorta.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Descripción Corta:"
        '
        'TxtDescripción
        '
        Me.TxtDescripción.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDescripción.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescripción.Location = New System.Drawing.Point(114, 33)
        Me.TxtDescripción.MaxLength = 80
        Me.TxtDescripción.Name = "TxtDescripción"
        Me.TxtDescripción.Size = New System.Drawing.Size(426, 20)
        Me.TxtDescripción.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Descripción:"
        '
        'Txtcodigo
        '
        Me.Txtcodigo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtcodigo.Location = New System.Drawing.Point(114, 7)
        Me.Txtcodigo.MaximumSize = New System.Drawing.Size(100, 20)
        Me.Txtcodigo.MaxLength = 4
        Me.Txtcodigo.MinimumSize = New System.Drawing.Size(30, 20)
        Me.Txtcodigo.Name = "Txtcodigo"
        Me.Txtcodigo.ReadOnly = True
        Me.Txtcodigo.Size = New System.Drawing.Size(100, 20)
        Me.Txtcodigo.TabIndex = 1
        '
        'LblEstatus
        '
        Me.LblEstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblEstatus.BackColor = System.Drawing.Color.Navy
        Me.LblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstatus.ForeColor = System.Drawing.Color.White
        Me.LblEstatus.Location = New System.Drawing.Point(565, 3)
        Me.LblEstatus.Name = "LblEstatus"
        Me.LblEstatus.Size = New System.Drawing.Size(103, 21)
        Me.LblEstatus.TabIndex = 2
        Me.LblEstatus.Text = "ESTATUS"
        Me.LblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblEstatus.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        '
        'PresentacionC
        '
        Me.PresentacionC.AllowEdit = True
        Me.PresentacionC.AllowNew = True
        Me.PresentacionC.AllowRemove = True
        Me.PresentacionC.Name = ""
        Me.PresentacionC.RaiseListChangedEvents = True
        '
        'ClmCodigo
        '
        Me.ClmCodigo.HeaderText = "Código"
        Me.ClmCodigo.Name = "ClmCodigo"
        Me.ClmCodigo.ReadOnly = True
        Me.ClmCodigo.Width = 60
        '
        'ClmDescripcion
        '
        Me.ClmDescripcion.HeaderText = "Descripción"
        Me.ClmDescripcion.Name = "ClmDescripcion"
        Me.ClmDescripcion.ReadOnly = True
        Me.ClmDescripcion.Width = 250
        '
        'ClmDescripcionCorta
        '
        Me.ClmDescripcionCorta.HeaderText = "Descripción Corta"
        Me.ClmDescripcionCorta.Name = "ClmDescripcionCorta"
        Me.ClmDescripcionCorta.ReadOnly = True
        Me.ClmDescripcionCorta.Width = 200
        '
        'ClmPiezas
        '
        Me.ClmPiezas.HeaderText = "Piezas"
        Me.ClmPiezas.Name = "ClmPiezas"
        Me.ClmPiezas.ReadOnly = True
        Me.ClmPiezas.Width = 80
        '
        'ClmUnidadMedida
        '
        Me.ClmUnidadMedida.HeaderText = "Unidad de Medida"
        Me.ClmUnidadMedida.Name = "ClmUnidadMedida"
        Me.ClmUnidadMedida.ReadOnly = True
        Me.ClmUnidadMedida.Width = 200
        '
        'ClmObservaciones
        '
        Me.ClmObservaciones.HeaderText = "Observaciones"
        Me.ClmObservaciones.Name = "ClmObservaciones"
        Me.ClmObservaciones.ReadOnly = True
        Me.ClmObservaciones.Width = 200
        '
        'ClmEstatus
        '
        Me.ClmEstatus.HeaderText = "Estatus"
        Me.ClmEstatus.Name = "ClmEstatus"
        Me.ClmEstatus.ReadOnly = True
        Me.ClmEstatus.Width = 80
        '
        'CompCatPresentacionPdto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 543)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(814, 577)
        Me.MinimumSize = New System.Drawing.Size(750, 567)
        Me.Name = "CompCatPresentacionPdto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABC de Presentaciones de Productos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblEstatus As System.Windows.Forms.Label
    Friend WithEvents Txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents TxtDescripción As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbUnidadMedida As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtPiezas As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtDescCorta As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents TxtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PresentacionC As ClasesNegocio.PresentacionCollectionClass
    Friend WithEvents UnidadesMedidaC As ClasesNegocio.UnidadesMedidaCollectionClass
    Friend WithEvents ClmCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmDescripcionCorta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmPiezas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmUnidadMedida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmObservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
