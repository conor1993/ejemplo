<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusqBalance
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtIdRubro = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgvCab = New System.Windows.Forms.DataGridView
        Me.BalanceCol = New ClasesNegocio.CabBalanceCollectionClass
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DgvDet = New System.Windows.Forms.DataGridView
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
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.BtnAceptar = New System.Windows.Forms.Button
        Me.clmRubro = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaldoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgvCab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvDet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.mtb.MostrarCancelar = False
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = False
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 482)
        Me.mtb.TabIndex = 3
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
        Me.lblTitulo.Size = New System.Drawing.Size(616, 29)
        Me.lblTitulo.TabIndex = 4
        Me.lblTitulo.Text = "BÚSQUEDA DE ESTADOS FINANCIEROS"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(121, 63)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(337, 20)
        Me.txtDescripcion.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Descripción:"
        '
        'txtIdRubro
        '
        Me.txtIdRubro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdRubro.Location = New System.Drawing.Point(121, 37)
        Me.txtIdRubro.MaxLength = 3
        Me.txtIdRubro.Name = "txtIdRubro"
        Me.txtIdRubro.Size = New System.Drawing.Size(56, 20)
        Me.txtIdRubro.TabIndex = 9
        Me.txtIdRubro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Rubro:"
        '
        'dgvCab
        '
        Me.dgvCab.AllowUserToAddRows = False
        Me.dgvCab.AllowUserToDeleteRows = False
        Me.dgvCab.AutoGenerateColumns = False
        Me.dgvCab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCab.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmRubro, Me.NombreDataGridViewTextBoxColumn, Me.SaldoDataGridViewTextBoxColumn, Me.clmCategoria})
        Me.dgvCab.DataSource = Me.BalanceCol
        Me.dgvCab.Location = New System.Drawing.Point(16, 19)
        Me.dgvCab.MultiSelect = False
        Me.dgvCab.Name = "dgvCab"
        Me.dgvCab.ReadOnly = True
        Me.dgvCab.RowHeadersVisible = False
        Me.dgvCab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCab.Size = New System.Drawing.Size(574, 130)
        Me.dgvCab.TabIndex = 12
        '
        'BalanceCol
        '
        Me.BalanceCol.AllowEdit = True
        Me.BalanceCol.AllowNew = True
        Me.BalanceCol.AllowRemove = True
        Me.BalanceCol.MaximoElementosSeleccionados = 1
        Me.BalanceCol.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.BalanceCol.MostrarAlertas = False
        Me.BalanceCol.Name = Nothing
        Me.BalanceCol.RaiseListChangedEvents = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.dgvCab)
        Me.GroupBox1.Location = New System.Drawing.Point(42, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(612, 351)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Estados Financieros"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DgvDet)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 155)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(589, 190)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle"
        '
        'DgvDet
        '
        Me.DgvDet.AllowUserToAddRows = False
        Me.DgvDet.AllowUserToDeleteRows = False
        Me.DgvDet.AllowUserToResizeRows = False
        Me.DgvDet.AutoGenerateColumns = False
        Me.DgvDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdBalanceDataGridViewTextBoxColumn, Me.IdRenglonDataGridViewTextBoxColumn, Me.CtaDataGridViewTextBoxColumn, Me.SCtaDataGridViewTextBoxColumn, Me.SSCtaDataGridViewTextBoxColumn, Me.SSSCtaDataGridViewTextBoxColumn, Me.CuentaDataGridViewTextBoxColumn, Me.clmSumaResta, Me.clmSaldo})
        Me.DgvDet.DataSource = Me.BalanceDetC
        Me.DgvDet.Location = New System.Drawing.Point(6, 13)
        Me.DgvDet.Name = "DgvDet"
        Me.DgvDet.ReadOnly = True
        Me.DgvDet.RowHeadersVisible = False
        Me.DgvDet.Size = New System.Drawing.Size(574, 171)
        Me.DgvDet.TabIndex = 9
        '
        'IdBalanceDataGridViewTextBoxColumn
        '
        Me.IdBalanceDataGridViewTextBoxColumn.DataPropertyName = "IdBalance"
        Me.IdBalanceDataGridViewTextBoxColumn.HeaderText = "IdBalance"
        Me.IdBalanceDataGridViewTextBoxColumn.Name = "IdBalanceDataGridViewTextBoxColumn"
        Me.IdBalanceDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdBalanceDataGridViewTextBoxColumn.Visible = False
        '
        'IdRenglonDataGridViewTextBoxColumn
        '
        Me.IdRenglonDataGridViewTextBoxColumn.DataPropertyName = "IdRenglon"
        Me.IdRenglonDataGridViewTextBoxColumn.HeaderText = "IdRenglon"
        Me.IdRenglonDataGridViewTextBoxColumn.Name = "IdRenglonDataGridViewTextBoxColumn"
        Me.IdRenglonDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdRenglonDataGridViewTextBoxColumn.Visible = False
        '
        'CtaDataGridViewTextBoxColumn
        '
        Me.CtaDataGridViewTextBoxColumn.DataPropertyName = "Cta"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.CtaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.CtaDataGridViewTextBoxColumn.HeaderText = "Cta"
        Me.CtaDataGridViewTextBoxColumn.Name = "CtaDataGridViewTextBoxColumn"
        Me.CtaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CtaDataGridViewTextBoxColumn.Width = 60
        '
        'SCtaDataGridViewTextBoxColumn
        '
        Me.SCtaDataGridViewTextBoxColumn.DataPropertyName = "SCta"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.SCtaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.SCtaDataGridViewTextBoxColumn.HeaderText = "SCta"
        Me.SCtaDataGridViewTextBoxColumn.Name = "SCtaDataGridViewTextBoxColumn"
        Me.SCtaDataGridViewTextBoxColumn.ReadOnly = True
        Me.SCtaDataGridViewTextBoxColumn.Width = 60
        '
        'SSCtaDataGridViewTextBoxColumn
        '
        Me.SSCtaDataGridViewTextBoxColumn.DataPropertyName = "SSCta"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.SSCtaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.SSCtaDataGridViewTextBoxColumn.HeaderText = "SSCta"
        Me.SSCtaDataGridViewTextBoxColumn.Name = "SSCtaDataGridViewTextBoxColumn"
        Me.SSCtaDataGridViewTextBoxColumn.ReadOnly = True
        Me.SSCtaDataGridViewTextBoxColumn.Width = 60
        '
        'SSSCtaDataGridViewTextBoxColumn
        '
        Me.SSSCtaDataGridViewTextBoxColumn.DataPropertyName = "SSSCta"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.SSSCtaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
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
        Me.CuentaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CuentaDataGridViewTextBoxColumn.Width = 180
        '
        'clmSumaResta
        '
        Me.clmSumaResta.DataPropertyName = "SumaResta"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.clmSumaResta.DefaultCellStyle = DataGridViewCellStyle7
        Me.clmSumaResta.HeaderText = "+ / -"
        Me.clmSumaResta.MaxInputLength = 1
        Me.clmSumaResta.Name = "clmSumaResta"
        Me.clmSumaResta.ReadOnly = True
        Me.clmSumaResta.Width = 50
        '
        'clmSaldo
        '
        Me.clmSaldo.DataPropertyName = "Saldo"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "C2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.clmSaldo.DefaultCellStyle = DataGridViewCellStyle8
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
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(557, 446)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 14
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(460, 446)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 15
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'clmRubro
        '
        Me.clmRubro.DataPropertyName = "IdBalance"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.clmRubro.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmRubro.HeaderText = "Id Balance"
        Me.clmRubro.Name = "clmRubro"
        Me.clmRubro.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 250
        '
        'SaldoDataGridViewTextBoxColumn
        '
        Me.SaldoDataGridViewTextBoxColumn.DataPropertyName = "Saldo"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.SaldoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.SaldoDataGridViewTextBoxColumn.HeaderText = "Saldo"
        Me.SaldoDataGridViewTextBoxColumn.Name = "SaldoDataGridViewTextBoxColumn"
        Me.SaldoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'clmCategoria
        '
        Me.clmCategoria.DataPropertyName = "IdBalance"
        Me.clmCategoria.HeaderText = "Categoria"
        Me.clmCategoria.Name = "clmCategoria"
        Me.clmCategoria.ReadOnly = True
        Me.clmCategoria.Width = 110
        '
        'FrmBusqBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 482)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIdRubro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.mtb)
        Me.Name = "FrmBusqBalance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Búsqueda de Estados Finacieros"
        CType(Me.dgvCab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DgvDet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtIdRubro As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvCab As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BalanceDetC As ClasesNegocio.DetBalanceCollectionClass
    Friend WithEvents BalanceCol As ClasesNegocio.CabBalanceCollectionClass
    Friend WithEvents DgvDet As System.Windows.Forms.DataGridView
    Friend WithEvents IdBalanceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdRenglonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CtaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SCtaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SSCtaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SSSCtaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CuentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSumaResta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSaldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdEmpresaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents clmRubro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCategoria As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
