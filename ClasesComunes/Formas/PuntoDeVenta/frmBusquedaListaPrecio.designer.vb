<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaListaPrecio
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
        Me.cmbPlaza = New System.Windows.Forms.ComboBox
        Me.PlazaCol = New ClasesNegocio.PlazaCollectionClass
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGrid = New System.Windows.Forms.DataGridView
        Me.ListaPrecioCol = New ClasesNegocio.ListaPrecioCollectionClass
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtCodigo = New System.Windows.Forms.TextBox
        Me.TxtDescripcion = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtDescta = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionCortaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EsListaBaseDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DiasVigenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaVigenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PlazaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ListaBaseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbPlaza
        '
        Me.cmbPlaza.DataSource = Me.PlazaCol
        Me.cmbPlaza.DisplayMember = "Descripcion"
        Me.cmbPlaza.FormattingEnabled = True
        Me.cmbPlaza.Location = New System.Drawing.Point(162, 71)
        Me.cmbPlaza.Name = "cmbPlaza"
        Me.cmbPlaza.Size = New System.Drawing.Size(321, 21)
        Me.cmbPlaza.TabIndex = 1
        Me.cmbPlaza.ValueMember = "Codigo"
        '
        'PlazaCol
        '
        Me.PlazaCol.AllowEdit = True
        Me.PlazaCol.AllowNew = True
        Me.PlazaCol.AllowRemove = True
        Me.PlazaCol.Name = ""
        Me.PlazaCol.RaiseListChangedEvents = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Plaza:"
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.AllowUserToResizeRows = False
        Me.DataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGrid.AutoGenerateColumns = False
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.DescripcionCortaDataGridViewTextBoxColumn, Me.EsListaBaseDataGridViewCheckBoxColumn, Me.DiasVigenciaDataGridViewTextBoxColumn, Me.FechaVigenciaDataGridViewTextBoxColumn, Me.PlazaDataGridViewTextBoxColumn, Me.ListaBaseDataGridViewTextBoxColumn, Me.EstatusDataGridViewTextBoxColumn})
        Me.DataGrid.DataSource = Me.ListaPrecioCol
        Me.DataGrid.Location = New System.Drawing.Point(6, 23)
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(783, 254)
        Me.DataGrid.TabIndex = 6
        '
        'ListaPrecioCol
        '
        Me.ListaPrecioCol.AllowEdit = True
        Me.ListaPrecioCol.AllowNew = True
        Me.ListaPrecioCol.AllowRemove = True
        Me.ListaPrecioCol.Mostrar = ClasesNegocio.TipoListaPrecioEnum.LISTA_NO_BASE
        Me.ListaPrecioCol.Name = ""
        Me.ListaPrecioCol.RaiseListChangedEvents = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Location = New System.Drawing.Point(731, 441)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(88, 40)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Código:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Descripción:"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(162, 45)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(68, 20)
        Me.TxtCodigo.TabIndex = 0
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(162, 98)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(413, 20)
        Me.TxtDescripcion.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(50, 0)
        Me.Label4.MaximumSize = New System.Drawing.Size(1800, 1800)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(808, 33)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "BUSQUEDA DE LISTAS DE PRECIOS"
        '
        'TxtDescta
        '
        Me.TxtDescta.Location = New System.Drawing.Point(162, 124)
        Me.TxtDescta.Name = "TxtDescta"
        Me.TxtDescta.Size = New System.Drawing.Size(214, 20)
        Me.TxtDescta.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(65, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Descripción Corta:"
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
        Me.MEAToolBar1.MostrarImprimir = True
        Me.MEAToolBar1.MostrarLimpiar = True
        Me.MEAToolBar1.MostrarNuevo = False
        Me.MEAToolBar1.MostrarSalir = True
        Me.MEAToolBar1.Name = "MEAToolBar1"
        Me.MEAToolBar1.ShowToolTips = True
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 487)
        Me.MEAToolBar1.TabIndex = 69
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DataGrid)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(56, 159)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(795, 283)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de Listas de Precios Registradas"
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoDataGridViewTextBoxColumn.Width = 130
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 150
        '
        'DescripcionCortaDataGridViewTextBoxColumn
        '
        Me.DescripcionCortaDataGridViewTextBoxColumn.DataPropertyName = "DescripcionCorta"
        Me.DescripcionCortaDataGridViewTextBoxColumn.HeaderText = "Descripción Corta"
        Me.DescripcionCortaDataGridViewTextBoxColumn.Name = "DescripcionCortaDataGridViewTextBoxColumn"
        Me.DescripcionCortaDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionCortaDataGridViewTextBoxColumn.Width = 170
        '
        'EsListaBaseDataGridViewCheckBoxColumn
        '
        Me.EsListaBaseDataGridViewCheckBoxColumn.DataPropertyName = "EsListaBase"
        Me.EsListaBaseDataGridViewCheckBoxColumn.HeaderText = "Es Lista Base"
        Me.EsListaBaseDataGridViewCheckBoxColumn.Name = "EsListaBaseDataGridViewCheckBoxColumn"
        Me.EsListaBaseDataGridViewCheckBoxColumn.ReadOnly = True
        Me.EsListaBaseDataGridViewCheckBoxColumn.Width = 130
        '
        'DiasVigenciaDataGridViewTextBoxColumn
        '
        Me.DiasVigenciaDataGridViewTextBoxColumn.DataPropertyName = "DiasVigencia"
        Me.DiasVigenciaDataGridViewTextBoxColumn.HeaderText = "Dias de Vigencia"
        Me.DiasVigenciaDataGridViewTextBoxColumn.Name = "DiasVigenciaDataGridViewTextBoxColumn"
        Me.DiasVigenciaDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiasVigenciaDataGridViewTextBoxColumn.Width = 160
        '
        'FechaVigenciaDataGridViewTextBoxColumn
        '
        Me.FechaVigenciaDataGridViewTextBoxColumn.DataPropertyName = "FechaVigencia"
        Me.FechaVigenciaDataGridViewTextBoxColumn.HeaderText = "Fecha de Vigencia"
        Me.FechaVigenciaDataGridViewTextBoxColumn.Name = "FechaVigenciaDataGridViewTextBoxColumn"
        Me.FechaVigenciaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaVigenciaDataGridViewTextBoxColumn.Width = 170
        '
        'PlazaDataGridViewTextBoxColumn
        '
        Me.PlazaDataGridViewTextBoxColumn.DataPropertyName = "Plaza"
        Me.PlazaDataGridViewTextBoxColumn.HeaderText = "Plaza"
        Me.PlazaDataGridViewTextBoxColumn.Name = "PlazaDataGridViewTextBoxColumn"
        Me.PlazaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ListaBaseDataGridViewTextBoxColumn
        '
        Me.ListaBaseDataGridViewTextBoxColumn.DataPropertyName = "ListaBase"
        Me.ListaBaseDataGridViewTextBoxColumn.HeaderText = "ListaBase"
        Me.ListaBaseDataGridViewTextBoxColumn.Name = "ListaBaseDataGridViewTextBoxColumn"
        Me.ListaBaseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstatusDataGridViewTextBoxColumn
        '
        Me.EstatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.HeaderText = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.Name = "EstatusDataGridViewTextBoxColumn"
        Me.EstatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmBusquedaListaPrecio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 487)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.Controls.Add(Me.TxtDescta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.TxtCodigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbPlaza)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(866, 521)
        Me.MinimumSize = New System.Drawing.Size(866, 521)
        Me.Name = "frmBusquedaListaPrecio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de Listas de Precios"
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbPlaza As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents PlazaCol As ClasesNegocio.PlazaCollectionClass
    Friend WithEvents ListaPrecioCol As ClasesNegocio.ListaPrecioCollectionClass
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtDescta As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionCortaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EsListaBaseDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DiasVigenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaVigenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlazaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ListaBaseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
