<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaPrePolizas
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.chkActivo = New System.Windows.Forms.CheckBox
        Me.chkInactivo = New System.Windows.Forms.CheckBox
        Me.txtCodigo = New Integralab.Controles.TextBoxMejorado
        Me.txtDescripcion = New Integralab.Controles.TextBoxMejorado
        Me.dgvPrePolizas = New System.Windows.Forms.DataGridView
        Me.clmIdPoliza = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PolizaModeloCabCollectionClass1 = New ClasesNegocio.PolizaModeloCabCollectionClass
        CType(Me.dgvPrePolizas, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.mtb.Size = New System.Drawing.Size(50, 434)
        Me.mtb.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(50, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(451, 29)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "BÚSQUEDA DE PRE-POLIZAS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Descripción :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Codigo :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Estatus :"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Checked = True
        Me.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivo.Location = New System.Drawing.Point(127, 105)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 52
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'chkInactivo
        '
        Me.chkInactivo.AutoSize = True
        Me.chkInactivo.Checked = True
        Me.chkInactivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkInactivo.Location = New System.Drawing.Point(189, 105)
        Me.chkInactivo.Name = "chkInactivo"
        Me.chkInactivo.Size = New System.Drawing.Size(64, 17)
        Me.chkInactivo.TabIndex = 53
        Me.chkInactivo.Text = "Inactivo"
        Me.chkInactivo.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.ComboBoxEnlazado = Nothing
        Me.txtCodigo.Decimales = 0
        Me.txtCodigo.Location = New System.Drawing.Point(125, 46)
        Me.txtCodigo.MensajeCombo = "Seleccionar un item..."
        Me.txtCodigo.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.SiguienteControl = Nothing
        Me.txtCodigo.Size = New System.Drawing.Size(92, 20)
        Me.txtCodigo.TabIndex = 54
        Me.txtCodigo.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.ComboBoxEnlazado = Nothing
        Me.txtDescripcion.Decimales = 0
        Me.txtDescripcion.Location = New System.Drawing.Point(125, 75)
        Me.txtDescripcion.MensajeCombo = "Seleccionar un item..."
        Me.txtDescripcion.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.SiguienteControl = Nothing
        Me.txtDescripcion.Size = New System.Drawing.Size(292, 20)
        Me.txtDescripcion.TabIndex = 55
        Me.txtDescripcion.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'dgvPrePolizas
        '
        Me.dgvPrePolizas.AllowUserToAddRows = False
        Me.dgvPrePolizas.AllowUserToDeleteRows = False
        Me.dgvPrePolizas.AllowUserToResizeColumns = False
        Me.dgvPrePolizas.AutoGenerateColumns = False
        Me.dgvPrePolizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPrePolizas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmIdPoliza, Me.clmDescripcion, Me.clmEstatus})
        Me.dgvPrePolizas.DataSource = Me.PolizaModeloCabCollectionClass1
        Me.dgvPrePolizas.Location = New System.Drawing.Point(55, 141)
        Me.dgvPrePolizas.MultiSelect = False
        Me.dgvPrePolizas.Name = "dgvPrePolizas"
        Me.dgvPrePolizas.ReadOnly = True
        Me.dgvPrePolizas.RowHeadersVisible = False
        Me.dgvPrePolizas.Size = New System.Drawing.Size(434, 281)
        Me.dgvPrePolizas.TabIndex = 50
        '
        'clmIdPoliza
        '
        Me.clmIdPoliza.DataPropertyName = "IdPoliza"
        Me.clmIdPoliza.HeaderText = "Codigo"
        Me.clmIdPoliza.Name = "clmIdPoliza"
        Me.clmIdPoliza.ReadOnly = True
        Me.clmIdPoliza.Width = 50
        '
        'clmDescripcion
        '
        Me.clmDescripcion.DataPropertyName = "Descripcion"
        Me.clmDescripcion.HeaderText = "Descripcion"
        Me.clmDescripcion.Name = "clmDescripcion"
        Me.clmDescripcion.ReadOnly = True
        Me.clmDescripcion.Width = 280
        '
        'clmEstatus
        '
        Me.clmEstatus.DataPropertyName = "Estatus"
        Me.clmEstatus.HeaderText = "Estatus"
        Me.clmEstatus.Name = "clmEstatus"
        Me.clmEstatus.ReadOnly = True
        Me.clmEstatus.Width = 80
        '
        'PolizaModeloCabCollectionClass1
        '
        Me.PolizaModeloCabCollectionClass1.AllowEdit = True
        Me.PolizaModeloCabCollectionClass1.AllowNew = True
        Me.PolizaModeloCabCollectionClass1.AllowRemove = True
        Me.PolizaModeloCabCollectionClass1.MaximoElementosSeleccionados = 1
        Me.PolizaModeloCabCollectionClass1.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.PolizaModeloCabCollectionClass1.MostrarAlertas = False
        Me.PolizaModeloCabCollectionClass1.Name = Nothing
        Me.PolizaModeloCabCollectionClass1.RaiseListChangedEvents = True
        '
        'frmBusquedaPrePolizas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 434)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.chkInactivo)
        Me.Controls.Add(Me.chkActivo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvPrePolizas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mtb)
        Me.Name = "frmBusquedaPrePolizas"
        Me.Text = "BÚSQUEDA DE PRE-POLIZAS"
        CType(Me.dgvPrePolizas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvPrePolizas As System.Windows.Forms.DataGridView
    Friend WithEvents PolizaModeloCabCollectionClass1 As ClasesNegocio.PolizaModeloCabCollectionClass
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents chkInactivo As System.Windows.Forms.CheckBox
    Friend WithEvents txtCodigo As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtDescripcion As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents clmIdPoliza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
