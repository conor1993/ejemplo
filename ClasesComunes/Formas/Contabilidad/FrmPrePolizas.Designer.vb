<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrePolizas
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.dgvPrePolizaNacional = New System.Windows.Forms.DataGridView
        Me.clmIdCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmSubcta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmSsubcta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmSssubcta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmAfectable = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.PolizaModeloDetCollectionClass1 = New ClasesNegocio.PolizaModeloDetCollectionClass
        CType(Me.dgvPrePolizaNacional, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Label1.Size = New System.Drawing.Size(574, 29)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "PRE-POLIZAS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.mtb.Size = New System.Drawing.Size(50, 434)
        Me.mtb.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Codigo :"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(129, 45)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(74, 20)
        Me.txtCodigo.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Descripción :"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(129, 74)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(308, 20)
        Me.txtDescripcion.TabIndex = 43
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Contenedor"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Contenedor"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'lblEstatus
        '
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(532, 30)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(86, 21)
        Me.lblEstatus.TabIndex = 44
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvPrePolizaNacional
        '
        Me.dgvPrePolizaNacional.AllowUserToAddRows = False
        Me.dgvPrePolizaNacional.AllowUserToDeleteRows = False
        Me.dgvPrePolizaNacional.AutoGenerateColumns = False
        Me.dgvPrePolizaNacional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPrePolizaNacional.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmIdCuenta, Me.clmCta, Me.clmSubcta, Me.clmSsubcta, Me.clmSssubcta, Me.clmDescripcion, Me.clmMovimiento, Me.clmAfectable})
        Me.dgvPrePolizaNacional.DataSource = Me.PolizaModeloDetCollectionClass1
        Me.dgvPrePolizaNacional.Location = New System.Drawing.Point(55, 110)
        Me.dgvPrePolizaNacional.Name = "dgvPrePolizaNacional"
        Me.dgvPrePolizaNacional.ReadOnly = True
        Me.dgvPrePolizaNacional.RowHeadersVisible = False
        Me.dgvPrePolizaNacional.Size = New System.Drawing.Size(563, 300)
        Me.dgvPrePolizaNacional.TabIndex = 39
        '
        'clmIdCuenta
        '
        Me.clmIdCuenta.DataPropertyName = "IdCuentaContable"
        Me.clmIdCuenta.HeaderText = "IdCuenta"
        Me.clmIdCuenta.Name = "clmIdCuenta"
        Me.clmIdCuenta.ReadOnly = True
        Me.clmIdCuenta.Visible = False
        '
        'clmCta
        '
        Me.clmCta.DataPropertyName = "Cta"
        Me.clmCta.HeaderText = "Cuenta"
        Me.clmCta.MaxInputLength = 4
        Me.clmCta.Name = "clmCta"
        Me.clmCta.ReadOnly = True
        Me.clmCta.Width = 60
        '
        'clmSubcta
        '
        Me.clmSubcta.DataPropertyName = "Subcta"
        Me.clmSubcta.HeaderText = "Subcta"
        Me.clmSubcta.MaxInputLength = 4
        Me.clmSubcta.Name = "clmSubcta"
        Me.clmSubcta.ReadOnly = True
        Me.clmSubcta.Width = 60
        '
        'clmSsubcta
        '
        Me.clmSsubcta.DataPropertyName = "Ssubcta"
        Me.clmSsubcta.HeaderText = "Ssubcta"
        Me.clmSsubcta.MaxInputLength = 4
        Me.clmSsubcta.Name = "clmSsubcta"
        Me.clmSsubcta.ReadOnly = True
        Me.clmSsubcta.Width = 60
        '
        'clmSssubcta
        '
        Me.clmSssubcta.DataPropertyName = "Sssubcta"
        Me.clmSssubcta.HeaderText = "Sssubcta"
        Me.clmSssubcta.MaxInputLength = 4
        Me.clmSssubcta.Name = "clmSssubcta"
        Me.clmSssubcta.ReadOnly = True
        Me.clmSssubcta.Width = 60
        '
        'clmDescripcion
        '
        Me.clmDescripcion.DataPropertyName = "CuentaContable"
        Me.clmDescripcion.HeaderText = "Descripcion"
        Me.clmDescripcion.Name = "clmDescripcion"
        Me.clmDescripcion.ReadOnly = True
        Me.clmDescripcion.Width = 230
        '
        'clmMovimiento
        '
        Me.clmMovimiento.DataPropertyName = "CargoAbono"
        Me.clmMovimiento.HeaderText = "CargoAbono"
        Me.clmMovimiento.MaxInputLength = 1
        Me.clmMovimiento.Name = "clmMovimiento"
        Me.clmMovimiento.ReadOnly = True
        Me.clmMovimiento.Width = 70
        '
        'clmAfectable
        '
        Me.clmAfectable.DataPropertyName = "Afectable"
        Me.clmAfectable.HeaderText = "Afectable"
        Me.clmAfectable.Name = "clmAfectable"
        Me.clmAfectable.ReadOnly = True
        Me.clmAfectable.Visible = False
        '
        'PolizaModeloDetCollectionClass1
        '
        Me.PolizaModeloDetCollectionClass1.AllowEdit = True
        Me.PolizaModeloDetCollectionClass1.AllowNew = True
        Me.PolizaModeloDetCollectionClass1.AllowRemove = True
        Me.PolizaModeloDetCollectionClass1.MaximoElementosSeleccionados = 1
        Me.PolizaModeloDetCollectionClass1.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.PolizaModeloDetCollectionClass1.MostrarAlertas = False
        Me.PolizaModeloDetCollectionClass1.Name = Nothing
        Me.PolizaModeloDetCollectionClass1.RaiseListChangedEvents = True
        Me.PolizaModeloDetCollectionClass1.Transaction = Nothing
        '
        'FrmPrePolizas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 434)
        Me.Controls.Add(Me.lblEstatus)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvPrePolizaNacional)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mtb)
        Me.Name = "FrmPrePolizas"
        Me.Text = "PRE-POLIZAS"
        CType(Me.dgvPrePolizaNacional, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents dgvPrePolizaNacional As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents PolizaModeloDetCollectionClass1 As ClasesNegocio.PolizaModeloDetCollectionClass
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents clmIdCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSubcta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSsubcta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSssubcta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmMovimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmAfectable As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
