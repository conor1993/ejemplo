<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmABCdeEstadosFinancieros
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtIdRubro = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.lblEmpresa = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtSaldo = New System.Windows.Forms.TextBox
        Me.grid = New System.Windows.Forms.DataGridView
        Me.IdBalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdRenglonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CtaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SCtaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SSCtaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SSSCtaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CuentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmSumaResta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmSaldo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BalanceDetC = New ClasesNegocio.DetBalanceCollectionClass
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbCategoria = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.mtb.MostrarBorrar = False
        Me.mtb.MostrarBuscar = True
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = True
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 584)
        Me.mtb.TabIndex = 2
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
        Me.lblTitulo.Size = New System.Drawing.Size(716, 29)
        Me.lblTitulo.TabIndex = 3
        Me.lblTitulo.Text = "ESTADOS FINACIEROS - BALANCE GENERAL"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Rubro:"
        '
        'txtIdRubro
        '
        Me.txtIdRubro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdRubro.Location = New System.Drawing.Point(124, 66)
        Me.txtIdRubro.MaxLength = 3
        Me.txtIdRubro.Name = "txtIdRubro"
        Me.txtIdRubro.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtIdRubro.Size = New System.Drawing.Size(56, 20)
        Me.txtIdRubro.TabIndex = 5
        Me.txtIdRubro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Descripción:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(124, 92)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(337, 20)
        Me.txtDescripcion.TabIndex = 7
        '
        'lblEmpresa
        '
        Me.lblEmpresa.BackColor = System.Drawing.Color.GhostWhite
        Me.lblEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmpresa.Location = New System.Drawing.Point(124, 40)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(337, 20)
        Me.lblEmpresa.TabIndex = 10
        Me.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblEmpresa.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(52, 44)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 13)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "Empresa:"
        Me.Label18.Visible = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(610, 555)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Saldo:"
        '
        'txtSaldo
        '
        Me.txtSaldo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSaldo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSaldo.Location = New System.Drawing.Point(653, 552)
        Me.txtSaldo.MaxLength = 3
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.ReadOnly = True
        Me.txtSaldo.Size = New System.Drawing.Size(92, 20)
        Me.txtSaldo.TabIndex = 12
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grid
        '
        Me.grid.AllowUserToResizeRows = False
        Me.grid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grid.AutoGenerateColumns = False
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdBalanceDataGridViewTextBoxColumn, Me.IdRenglonDataGridViewTextBoxColumn, Me.CtaDataGridViewTextBoxColumn, Me.SCtaDataGridViewTextBoxColumn, Me.SSCtaDataGridViewTextBoxColumn, Me.SSSCtaDataGridViewTextBoxColumn, Me.CuentaDataGridViewTextBoxColumn, Me.clmSumaResta, Me.clmSaldo})
        Me.grid.DataSource = Me.BalanceDetC
        Me.grid.Location = New System.Drawing.Point(56, 154)
        Me.grid.Name = "grid"
        Me.grid.Size = New System.Drawing.Size(689, 383)
        Me.grid.TabIndex = 8
        '
        'IdBalanceDataGridViewTextBoxColumn
        '
        Me.IdBalanceDataGridViewTextBoxColumn.DataPropertyName = "IdBalance"
        Me.IdBalanceDataGridViewTextBoxColumn.HeaderText = "IdBalance"
        Me.IdBalanceDataGridViewTextBoxColumn.Name = "IdBalanceDataGridViewTextBoxColumn"
        Me.IdBalanceDataGridViewTextBoxColumn.Visible = False
        '
        'IdRenglonDataGridViewTextBoxColumn
        '
        Me.IdRenglonDataGridViewTextBoxColumn.DataPropertyName = "IdRenglon"
        Me.IdRenglonDataGridViewTextBoxColumn.HeaderText = "IdRenglon"
        Me.IdRenglonDataGridViewTextBoxColumn.Name = "IdRenglonDataGridViewTextBoxColumn"
        Me.IdRenglonDataGridViewTextBoxColumn.Visible = False
        '
        'CtaDataGridViewTextBoxColumn
        '
        Me.CtaDataGridViewTextBoxColumn.DataPropertyName = "Cta"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.CtaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.CtaDataGridViewTextBoxColumn.HeaderText = "Cta"
        Me.CtaDataGridViewTextBoxColumn.Name = "CtaDataGridViewTextBoxColumn"
        Me.CtaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CtaDataGridViewTextBoxColumn.Width = 60
        '
        'SCtaDataGridViewTextBoxColumn
        '
        Me.SCtaDataGridViewTextBoxColumn.DataPropertyName = "SCta"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.SCtaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.SCtaDataGridViewTextBoxColumn.HeaderText = "SCta"
        Me.SCtaDataGridViewTextBoxColumn.Name = "SCtaDataGridViewTextBoxColumn"
        Me.SCtaDataGridViewTextBoxColumn.ReadOnly = True
        Me.SCtaDataGridViewTextBoxColumn.Width = 60
        '
        'SSCtaDataGridViewTextBoxColumn
        '
        Me.SSCtaDataGridViewTextBoxColumn.DataPropertyName = "SSCta"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.SSCtaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.SSCtaDataGridViewTextBoxColumn.HeaderText = "SSCta"
        Me.SSCtaDataGridViewTextBoxColumn.Name = "SSCtaDataGridViewTextBoxColumn"
        Me.SSCtaDataGridViewTextBoxColumn.ReadOnly = True
        Me.SSCtaDataGridViewTextBoxColumn.Width = 60
        '
        'SSSCtaDataGridViewTextBoxColumn
        '
        Me.SSSCtaDataGridViewTextBoxColumn.DataPropertyName = "SSSCta"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.SSSCtaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.SSSCtaDataGridViewTextBoxColumn.HeaderText = "SSSCta"
        Me.SSSCtaDataGridViewTextBoxColumn.Name = "SSSCtaDataGridViewTextBoxColumn"
        Me.SSSCtaDataGridViewTextBoxColumn.ReadOnly = True
        Me.SSSCtaDataGridViewTextBoxColumn.Width = 60
        '
        'CuentaDataGridViewTextBoxColumn
        '
        Me.CuentaDataGridViewTextBoxColumn.DataPropertyName = "Cuenta"
        Me.CuentaDataGridViewTextBoxColumn.HeaderText = "Cuenta"
        Me.CuentaDataGridViewTextBoxColumn.Name = "CuentaDataGridViewTextBoxColumn"
        Me.CuentaDataGridViewTextBoxColumn.Width = 250
        '
        'clmSumaResta
        '
        Me.clmSumaResta.DataPropertyName = "SumaResta"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.clmSumaResta.DefaultCellStyle = DataGridViewCellStyle5
        Me.clmSumaResta.HeaderText = "+ / -"
        Me.clmSumaResta.MaxInputLength = 1
        Me.clmSumaResta.Name = "clmSumaResta"
        Me.clmSumaResta.Width = 50
        '
        'clmSaldo
        '
        Me.clmSaldo.DataPropertyName = "Saldo"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.clmSaldo.DefaultCellStyle = DataGridViewCellStyle6
        Me.clmSaldo.HeaderText = "Saldo"
        Me.clmSaldo.Name = "clmSaldo"
        Me.clmSaldo.ReadOnly = True
        '
        'BalanceDetC
        '
        Me.BalanceDetC.AllowEdit = True
        Me.BalanceDetC.AllowNew = True
        Me.BalanceDetC.AllowRemove = True
        Me.BalanceDetC.MaximoElementosSeleccionados = 1
        Me.BalanceDetC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.BalanceDetC.MostrarAlertas = False
        Me.BalanceDetC.Name = Nothing
        Me.BalanceDetC.RaiseListChangedEvents = True
        Me.BalanceDetC.Transaction = Nothing
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(56, 552)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(226, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Para Buscar una Cuenta Contable presione F3"
        '
        'cmbCategoria
        '
        Me.cmbCategoria.FormattingEnabled = True
        Me.cmbCategoria.Location = New System.Drawing.Point(124, 118)
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Size = New System.Drawing.Size(302, 21)
        Me.cmbCategoria.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Categoría:"
        '
        'FrmABCdeEstadosFinancieros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 584)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbCategoria)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblEmpresa)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIdRubro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.mtb)
        Me.Name = "FrmABCdeEstadosFinancieros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estados Financieros  -  Balance General"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIdRubro As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents BalanceDetC As ClasesNegocio.DetBalanceCollectionClass
    Friend WithEvents lblEmpresa As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents IdBalanceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdRenglonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CtaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SCtaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SSCtaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SSSCtaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CuentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSumaResta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSaldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
