<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmABCAlmacenes
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDescripcionCorta = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdbOtro = New System.Windows.Forms.RadioButton
        Me.rdbProductos = New System.Windows.Forms.RadioButton
        Me.rdbCanales = New System.Windows.Forms.RadioButton
        Me.rdbCortes = New System.Windows.Forms.RadioButton
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtLetraSerie = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbCuentaContable = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCuentaContable = New System.Windows.Forms.TextBox
        Me.dgvAlmacenes = New System.Windows.Forms.DataGridView
        Me.IdCodAlmacenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionCortaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ObservacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdCodTipoAlmacenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CtaMayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubCtaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SsbCtaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SssCtaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PropioDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.IdClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ConsecutivoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LetraSerieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CatAlmacenes = New IntegraLab.ORM.CollectionClasses.AlmacenCatalogoCollection
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvAlmacenes, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MEAToolBar1.MostrarBuscar = True
        Me.MEAToolBar1.MostrarCancelar = True
        Me.MEAToolBar1.MostrarEditar = True
        Me.MEAToolBar1.MostrarGuardar = True
        Me.MEAToolBar1.MostrarImprimir = True
        Me.MEAToolBar1.MostrarLimpiar = True
        Me.MEAToolBar1.MostrarNuevo = True
        Me.MEAToolBar1.MostrarSalir = True
        Me.MEAToolBar1.Name = "MEAToolBar1"
        Me.MEAToolBar1.ShowToolTips = True
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 514)
        Me.MEAToolBar1.TabIndex = 43
        '
        'Label17
        '
        Me.Label17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(56, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(392, 32)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "ABC de Almacenes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Codigo"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(153, 42)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(64, 20)
        Me.txtCodigo.TabIndex = 45
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Descripcion"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(153, 68)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(286, 20)
        Me.txtDescripcion.TabIndex = 47
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Descripcion corta"
        '
        'txtDescripcionCorta
        '
        Me.txtDescripcionCorta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionCorta.Location = New System.Drawing.Point(153, 97)
        Me.txtDescripcionCorta.Name = "txtDescripcionCorta"
        Me.txtDescripcionCorta.Size = New System.Drawing.Size(118, 20)
        Me.txtDescripcionCorta.TabIndex = 49
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbOtro)
        Me.GroupBox1.Controls.Add(Me.rdbProductos)
        Me.GroupBox1.Controls.Add(Me.rdbCanales)
        Me.GroupBox1.Controls.Add(Me.rdbCortes)
        Me.GroupBox1.Location = New System.Drawing.Point(60, 123)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(379, 51)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo"
        '
        'rdbOtro
        '
        Me.rdbOtro.AutoSize = True
        Me.rdbOtro.Location = New System.Drawing.Point(298, 19)
        Me.rdbOtro.Name = "rdbOtro"
        Me.rdbOtro.Size = New System.Drawing.Size(45, 17)
        Me.rdbOtro.TabIndex = 3
        Me.rdbOtro.TabStop = True
        Me.rdbOtro.Text = "Otro"
        Me.rdbOtro.UseVisualStyleBackColor = True
        '
        'rdbProductos
        '
        Me.rdbProductos.AutoSize = True
        Me.rdbProductos.Location = New System.Drawing.Point(183, 19)
        Me.rdbProductos.Name = "rdbProductos"
        Me.rdbProductos.Size = New System.Drawing.Size(73, 17)
        Me.rdbProductos.TabIndex = 2
        Me.rdbProductos.TabStop = True
        Me.rdbProductos.Text = "Productos"
        Me.rdbProductos.UseVisualStyleBackColor = True
        '
        'rdbCanales
        '
        Me.rdbCanales.AutoSize = True
        Me.rdbCanales.Location = New System.Drawing.Point(87, 19)
        Me.rdbCanales.Name = "rdbCanales"
        Me.rdbCanales.Size = New System.Drawing.Size(63, 17)
        Me.rdbCanales.TabIndex = 1
        Me.rdbCanales.TabStop = True
        Me.rdbCanales.Text = "Canales"
        Me.rdbCanales.UseVisualStyleBackColor = True
        '
        'rdbCortes
        '
        Me.rdbCortes.AutoSize = True
        Me.rdbCortes.Location = New System.Drawing.Point(6, 19)
        Me.rdbCortes.Name = "rdbCortes"
        Me.rdbCortes.Size = New System.Drawing.Size(55, 17)
        Me.rdbCortes.TabIndex = 0
        Me.rdbCortes.TabStop = True
        Me.rdbCortes.Text = "Cortes"
        Me.rdbCortes.UseVisualStyleBackColor = True
        '
        'lblEstatus
        '
        Me.lblEstatus.AutoSize = True
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(335, 34)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(104, 24)
        Me.lblEstatus.TabIndex = 51
        Me.lblEstatus.Text = "ESTATUS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(323, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Letra Serie"
        '
        'txtLetraSerie
        '
        Me.txtLetraSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLetraSerie.Location = New System.Drawing.Point(397, 100)
        Me.txtLetraSerie.Name = "txtLetraSerie"
        Me.txtLetraSerie.Size = New System.Drawing.Size(42, 20)
        Me.txtLetraSerie.TabIndex = 53
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Cuenta Contable"
        '
        'cmbCuentaContable
        '
        Me.cmbCuentaContable.FormattingEnabled = True
        Me.cmbCuentaContable.Location = New System.Drawing.Point(153, 180)
        Me.cmbCuentaContable.Name = "cmbCuentaContable"
        Me.cmbCuentaContable.Size = New System.Drawing.Size(286, 21)
        Me.cmbCuentaContable.TabIndex = 55
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "No. Cuenta"
        '
        'txtCuentaContable
        '
        Me.txtCuentaContable.Enabled = False
        Me.txtCuentaContable.Location = New System.Drawing.Point(153, 207)
        Me.txtCuentaContable.Name = "txtCuentaContable"
        Me.txtCuentaContable.Size = New System.Drawing.Size(286, 20)
        Me.txtCuentaContable.TabIndex = 57
        '
        'dgvAlmacenes
        '
        Me.dgvAlmacenes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvAlmacenes.AutoGenerateColumns = False
        Me.dgvAlmacenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlmacenes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCodAlmacenDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.DescripcionCortaDataGridViewTextBoxColumn, Me.ObservacionesDataGridViewTextBoxColumn, Me.IdCodTipoAlmacenDataGridViewTextBoxColumn, Me.CtaMayDataGridViewTextBoxColumn, Me.SubCtaDataGridViewTextBoxColumn, Me.SsbCtaDataGridViewTextBoxColumn, Me.SssCtaDataGridViewTextBoxColumn, Me.PropioDataGridViewCheckBoxColumn, Me.IdClienteDataGridViewTextBoxColumn, Me.ConsecutivoDataGridViewTextBoxColumn, Me.LetraSerieDataGridViewTextBoxColumn, Me.EstatusDataGridViewTextBoxColumn})
        Me.dgvAlmacenes.DataSource = Me.CatAlmacenes
        Me.dgvAlmacenes.Location = New System.Drawing.Point(59, 241)
        Me.dgvAlmacenes.MultiSelect = False
        Me.dgvAlmacenes.Name = "dgvAlmacenes"
        Me.dgvAlmacenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAlmacenes.Size = New System.Drawing.Size(376, 261)
        Me.dgvAlmacenes.TabIndex = 58
        '
        'IdCodAlmacenDataGridViewTextBoxColumn
        '
        Me.IdCodAlmacenDataGridViewTextBoxColumn.DataPropertyName = "IdCodAlmacen"
        Me.IdCodAlmacenDataGridViewTextBoxColumn.HeaderText = "IdCodAlmacen"
        Me.IdCodAlmacenDataGridViewTextBoxColumn.Name = "IdCodAlmacenDataGridViewTextBoxColumn"
        Me.IdCodAlmacenDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        '
        'DescripcionCortaDataGridViewTextBoxColumn
        '
        Me.DescripcionCortaDataGridViewTextBoxColumn.DataPropertyName = "DescripcionCorta"
        Me.DescripcionCortaDataGridViewTextBoxColumn.HeaderText = "DescripcionCorta"
        Me.DescripcionCortaDataGridViewTextBoxColumn.Name = "DescripcionCortaDataGridViewTextBoxColumn"
        '
        'ObservacionesDataGridViewTextBoxColumn
        '
        Me.ObservacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.Name = "ObservacionesDataGridViewTextBoxColumn"
        '
        'IdCodTipoAlmacenDataGridViewTextBoxColumn
        '
        Me.IdCodTipoAlmacenDataGridViewTextBoxColumn.DataPropertyName = "IdCodTipoAlmacen"
        Me.IdCodTipoAlmacenDataGridViewTextBoxColumn.HeaderText = "IdCodTipoAlmacen"
        Me.IdCodTipoAlmacenDataGridViewTextBoxColumn.Name = "IdCodTipoAlmacenDataGridViewTextBoxColumn"
        '
        'CtaMayDataGridViewTextBoxColumn
        '
        Me.CtaMayDataGridViewTextBoxColumn.DataPropertyName = "CtaMay"
        Me.CtaMayDataGridViewTextBoxColumn.HeaderText = "CtaMay"
        Me.CtaMayDataGridViewTextBoxColumn.Name = "CtaMayDataGridViewTextBoxColumn"
        '
        'SubCtaDataGridViewTextBoxColumn
        '
        Me.SubCtaDataGridViewTextBoxColumn.DataPropertyName = "SubCta"
        Me.SubCtaDataGridViewTextBoxColumn.HeaderText = "SubCta"
        Me.SubCtaDataGridViewTextBoxColumn.Name = "SubCtaDataGridViewTextBoxColumn"
        '
        'SsbCtaDataGridViewTextBoxColumn
        '
        Me.SsbCtaDataGridViewTextBoxColumn.DataPropertyName = "SsbCta"
        Me.SsbCtaDataGridViewTextBoxColumn.HeaderText = "SsbCta"
        Me.SsbCtaDataGridViewTextBoxColumn.Name = "SsbCtaDataGridViewTextBoxColumn"
        '
        'SssCtaDataGridViewTextBoxColumn
        '
        Me.SssCtaDataGridViewTextBoxColumn.DataPropertyName = "SssCta"
        Me.SssCtaDataGridViewTextBoxColumn.HeaderText = "SssCta"
        Me.SssCtaDataGridViewTextBoxColumn.Name = "SssCtaDataGridViewTextBoxColumn"
        '
        'PropioDataGridViewCheckBoxColumn
        '
        Me.PropioDataGridViewCheckBoxColumn.DataPropertyName = "Propio"
        Me.PropioDataGridViewCheckBoxColumn.HeaderText = "Propio"
        Me.PropioDataGridViewCheckBoxColumn.Name = "PropioDataGridViewCheckBoxColumn"
        '
        'IdClienteDataGridViewTextBoxColumn
        '
        Me.IdClienteDataGridViewTextBoxColumn.DataPropertyName = "IdCliente"
        Me.IdClienteDataGridViewTextBoxColumn.HeaderText = "IdCliente"
        Me.IdClienteDataGridViewTextBoxColumn.Name = "IdClienteDataGridViewTextBoxColumn"
        '
        'ConsecutivoDataGridViewTextBoxColumn
        '
        Me.ConsecutivoDataGridViewTextBoxColumn.DataPropertyName = "Consecutivo"
        Me.ConsecutivoDataGridViewTextBoxColumn.HeaderText = "Consecutivo"
        Me.ConsecutivoDataGridViewTextBoxColumn.Name = "ConsecutivoDataGridViewTextBoxColumn"
        '
        'LetraSerieDataGridViewTextBoxColumn
        '
        Me.LetraSerieDataGridViewTextBoxColumn.DataPropertyName = "LetraSerie"
        Me.LetraSerieDataGridViewTextBoxColumn.HeaderText = "LetraSerie"
        Me.LetraSerieDataGridViewTextBoxColumn.Name = "LetraSerieDataGridViewTextBoxColumn"
        '
        'EstatusDataGridViewTextBoxColumn
        '
        Me.EstatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.HeaderText = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.Name = "EstatusDataGridViewTextBoxColumn"
        '
        'CatAlmacenes
        '
        Me.CatAlmacenes.ActiveContext = Nothing
        Me.CatAlmacenes.AllowEdit = True
        Me.CatAlmacenes.AllowNew = True
        Me.CatAlmacenes.AllowRemove = True
        Me.CatAlmacenes.Capacity = 32
        Me.CatAlmacenes.ConcurrencyPredicateFactoryToUse = Nothing
        Me.CatAlmacenes.DoNotPerformAddIfPresent = False
        Me.CatAlmacenes.EntityFactoryToUse = New IntegraLab.ORM.FactoryClasses.AlmacenCatalogoEntityFactory
        Me.CatAlmacenes.IsReadOnly = False
        Me.CatAlmacenes.MaxNumberOfItemsToReturn = CType(0, Long)
        Me.CatAlmacenes.SortClauses = Nothing
        Me.CatAlmacenes.SuppressClearInGetMulti = False
        Me.CatAlmacenes.Transaction = Nothing
        '
        'FrmABCAlmacenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 514)
        Me.Controls.Add(Me.dgvAlmacenes)
        Me.Controls.Add(Me.txtCuentaContable)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbCuentaContable)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtLetraSerie)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblEstatus)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtDescripcionCorta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.Controls.Add(Me.Label17)
        Me.Name = "FrmABCAlmacenes"
        Me.Text = "FrmABCAlmacenes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvAlmacenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcionCorta As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbOtro As System.Windows.Forms.RadioButton
    Friend WithEvents rdbProductos As System.Windows.Forms.RadioButton
    Friend WithEvents rdbCanales As System.Windows.Forms.RadioButton
    Friend WithEvents rdbCortes As System.Windows.Forms.RadioButton
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLetraSerie As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbCuentaContable As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCuentaContable As System.Windows.Forms.TextBox
    Friend WithEvents dgvAlmacenes As System.Windows.Forms.DataGridView
    Friend WithEvents IdCodAlmacenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionCortaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdCodTipoAlmacenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CtaMayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubCtaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SsbCtaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SssCtaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PropioDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IdClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConsecutivoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LetraSerieDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CatAlmacenes As Integralab.ORM.CollectionClasses.AlmacenCatalogoCollection
End Class
