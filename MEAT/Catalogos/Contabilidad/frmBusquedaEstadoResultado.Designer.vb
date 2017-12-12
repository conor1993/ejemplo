<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaEstadoResultado
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtRubro = New Integralab.Controles.TextBoxMejorado
        Me.txtDescripcion = New Integralab.Controles.TextBoxMejorado
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgEstadoResultado = New System.Windows.Forms.DataGridView
        Me.RubroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaldoMesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaldoAcumuladoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstadoResultadoCollectionClas1 = New ClasesNegocio.EstadoResultadoCollectionClass
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgEstadoResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.lblTitulo.Size = New System.Drawing.Size(830, 29)
        Me.lblTitulo.TabIndex = 5
        Me.lblTitulo.Text = "BUSQUEDA DE ESTADO DE RESULTADO"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = False
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = False
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 594)
        Me.mtb.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Rubro:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Descripción:"
        '
        'txtRubro
        '
        Me.txtRubro.ComboBoxEnlazado = Nothing
        Me.txtRubro.Decimales = 0
        Me.txtRubro.Location = New System.Drawing.Point(124, 37)
        Me.txtRubro.MaxLength = 3
        Me.txtRubro.MensajeCombo = "Seleccionar un item..."
        Me.txtRubro.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtRubro.Name = "txtRubro"
        Me.txtRubro.SiguienteControl = Nothing
        Me.txtRubro.Size = New System.Drawing.Size(46, 20)
        Me.txtRubro.TabIndex = 8
        Me.txtRubro.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'txtDescripcion
        '
        Me.txtDescripcion.ComboBoxEnlazado = Nothing
        Me.txtDescripcion.Decimales = 0
        Me.txtDescripcion.Location = New System.Drawing.Point(124, 63)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.MensajeCombo = "Seleccionar un item..."
        Me.txtDescripcion.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.SiguienteControl = Nothing
        Me.txtDescripcion.Size = New System.Drawing.Size(361, 20)
        Me.txtDescripcion.TabIndex = 9
        Me.txtDescripcion.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgEstadoResultado)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(812, 459)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de Estados de Resultado"
        '
        'dgEstadoResultado
        '
        Me.dgEstadoResultado.AllowUserToAddRows = False
        Me.dgEstadoResultado.AllowUserToDeleteRows = False
        Me.dgEstadoResultado.AllowUserToResizeRows = False
        Me.dgEstadoResultado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgEstadoResultado.AutoGenerateColumns = False
        Me.dgEstadoResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEstadoResultado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RubroDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.SaldoMesDataGridViewTextBoxColumn, Me.SaldoAcumuladoDataGridViewTextBoxColumn})
        Me.dgEstadoResultado.DataSource = Me.EstadoResultadoCollectionClas1
        Me.dgEstadoResultado.Location = New System.Drawing.Point(6, 19)
        Me.dgEstadoResultado.Name = "dgEstadoResultado"
        Me.dgEstadoResultado.ReadOnly = True
        Me.dgEstadoResultado.RowHeadersVisible = False
        Me.dgEstadoResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgEstadoResultado.Size = New System.Drawing.Size(800, 434)
        Me.dgEstadoResultado.TabIndex = 0
        '
        'RubroDataGridViewTextBoxColumn
        '
        Me.RubroDataGridViewTextBoxColumn.DataPropertyName = "Rubro"
        Me.RubroDataGridViewTextBoxColumn.HeaderText = "Rubro"
        Me.RubroDataGridViewTextBoxColumn.Name = "RubroDataGridViewTextBoxColumn"
        Me.RubroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoMesDataGridViewTextBoxColumn
        '
        Me.SaldoMesDataGridViewTextBoxColumn.DataPropertyName = "SaldoMes"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.SaldoMesDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.SaldoMesDataGridViewTextBoxColumn.HeaderText = "Saldo Mes"
        Me.SaldoMesDataGridViewTextBoxColumn.Name = "SaldoMesDataGridViewTextBoxColumn"
        Me.SaldoMesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoAcumuladoDataGridViewTextBoxColumn
        '
        Me.SaldoAcumuladoDataGridViewTextBoxColumn.DataPropertyName = "SaldoAcumulado"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "C2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.SaldoAcumuladoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.SaldoAcumuladoDataGridViewTextBoxColumn.HeaderText = "Saldo Acumulado"
        Me.SaldoAcumuladoDataGridViewTextBoxColumn.Name = "SaldoAcumuladoDataGridViewTextBoxColumn"
        Me.SaldoAcumuladoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoResultadoCollectionClas1
        '
        Me.EstadoResultadoCollectionClas1.AllowEdit = True
        Me.EstadoResultadoCollectionClas1.AllowNew = True
        Me.EstadoResultadoCollectionClas1.AllowRemove = True
        Me.EstadoResultadoCollectionClas1.MaximoElementosSeleccionados = 1
        Me.EstadoResultadoCollectionClas1.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.EstadoResultadoCollectionClas1.MostrarAlertas = False
        Me.EstadoResultadoCollectionClas1.Name = Nothing
        Me.EstadoResultadoCollectionClas1.RaiseListChangedEvents = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Location = New System.Drawing.Point(712, 559)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 11
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Location = New System.Drawing.Point(793, 559)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmBusquedaEstadoResultado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 594)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtRubro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmBusquedaEstadoResultado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de Estado de Resultado"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgEstadoResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRubro As Integralab.Controles.TextBoxMejorado
    Friend WithEvents txtDescripcion As Integralab.Controles.TextBoxMejorado
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgEstadoResultado As System.Windows.Forms.DataGridView
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents EstadoResultadoCollectionClas1 As ClasesNegocio.EstadoResultadoCollectionClass
    Friend WithEvents RubroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoMesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoAcumuladoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
