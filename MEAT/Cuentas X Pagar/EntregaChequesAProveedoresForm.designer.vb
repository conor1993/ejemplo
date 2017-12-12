<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EntregaChequesAProveedoresForm
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
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbCuenta = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DgvCheques = New System.Windows.Forms.DataGridView
        Me.ClmEntregado = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ClmCheque = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmFecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmImporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmConciliado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmFechaCobro = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCuentaHabiente = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtBanco = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvCheques, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(53, 0)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(728, 34)
        Me.lblTitulo.TabIndex = 106
        Me.lblTitulo.Text = "ENTREGA DE CHEQUES A PROVEEDORES"
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
        Me.mtb.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.mtb.MostrarBorrar = False
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = False
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 435)
        Me.mtb.TabIndex = 113
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "Cuenta Bancaria :"
        '
        'cmbCuenta
        '
        Me.cmbCuenta.FormattingEnabled = True
        Me.cmbCuenta.Location = New System.Drawing.Point(175, 50)
        Me.cmbCuenta.Name = "cmbCuenta"
        Me.cmbCuenta.Size = New System.Drawing.Size(222, 21)
        Me.cmbCuenta.TabIndex = 115
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvCheques)
        Me.GroupBox1.Location = New System.Drawing.Point(61, 131)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(678, 292)
        Me.GroupBox1.TabIndex = 116
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cheques"
        '
        'DgvCheques
        '
        Me.DgvCheques.AllowUserToAddRows = False
        Me.DgvCheques.AllowUserToDeleteRows = False
        Me.DgvCheques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCheques.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClmEntregado, Me.ClmCheque, Me.ClmFecha, Me.ClmProveedor, Me.ClmImporte, Me.ClmConciliado, Me.ClmFechaCobro})
        Me.DgvCheques.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvCheques.Location = New System.Drawing.Point(3, 16)
        Me.DgvCheques.MultiSelect = False
        Me.DgvCheques.Name = "DgvCheques"
        Me.DgvCheques.RowHeadersVisible = False
        Me.DgvCheques.Size = New System.Drawing.Size(672, 273)
        Me.DgvCheques.TabIndex = 0
        '
        'ClmEntregado
        '
        Me.ClmEntregado.DataPropertyName = "Entregado"
        Me.ClmEntregado.HeaderText = "Entregado"
        Me.ClmEntregado.Name = "ClmEntregado"
        Me.ClmEntregado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ClmEntregado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ClmEntregado.Width = 60
        '
        'ClmCheque
        '
        Me.ClmCheque.DataPropertyName = "Folio"
        Me.ClmCheque.HeaderText = "Folio Cheque"
        Me.ClmCheque.MaxInputLength = 32760
        Me.ClmCheque.Name = "ClmCheque"
        Me.ClmCheque.ReadOnly = True
        '
        'ClmFecha
        '
        Me.ClmFecha.DataPropertyName = "FechaMovimiento"
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ClmFecha.DefaultCellStyle = DataGridViewCellStyle3
        Me.ClmFecha.HeaderText = "Fecha"
        Me.ClmFecha.Name = "ClmFecha"
        Me.ClmFecha.ReadOnly = True
        '
        'ClmProveedor
        '
        Me.ClmProveedor.DataPropertyName = "Beneficiario"
        Me.ClmProveedor.HeaderText = "Beneficiario"
        Me.ClmProveedor.Name = "ClmProveedor"
        Me.ClmProveedor.ReadOnly = True
        '
        'ClmImporte
        '
        Me.ClmImporte.DataPropertyName = "Importe"
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.ClmImporte.DefaultCellStyle = DataGridViewCellStyle4
        Me.ClmImporte.HeaderText = "Importe"
        Me.ClmImporte.Name = "ClmImporte"
        Me.ClmImporte.ReadOnly = True
        '
        'ClmConciliado
        '
        Me.ClmConciliado.HeaderText = "Conciliado"
        Me.ClmConciliado.Name = "ClmConciliado"
        Me.ClmConciliado.ReadOnly = True
        '
        'ClmFechaCobro
        '
        Me.ClmFechaCobro.HeaderText = "Fecha Cobro"
        Me.ClmFechaCobro.Name = "ClmFechaCobro"
        Me.ClmFechaCobro.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "Cuenta Habiente :"
        '
        'txtCuentaHabiente
        '
        Me.txtCuentaHabiente.Enabled = False
        Me.txtCuentaHabiente.Location = New System.Drawing.Point(175, 99)
        Me.txtCuentaHabiente.Name = "txtCuentaHabiente"
        Me.txtCuentaHabiente.Size = New System.Drawing.Size(222, 20)
        Me.txtCuentaHabiente.TabIndex = 118
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(76, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 119
        Me.Label3.Text = "Banco :"
        '
        'txtBanco
        '
        Me.txtBanco.Enabled = False
        Me.txtBanco.Location = New System.Drawing.Point(175, 75)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(222, 20)
        Me.txtBanco.TabIndex = 120
        '
        'EntregaChequesAProveedoresForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 435)
        Me.Controls.Add(Me.txtBanco)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCuentaHabiente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbCuenta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "EntregaChequesAProveedoresForm"
        Me.Text = "Entrega de Cheques a Proveedores"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgvCheques, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DgvCheques As System.Windows.Forms.DataGridView
    Friend WithEvents ClmEntregado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ClmCheque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmConciliado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmFechaCobro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCuentaHabiente As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBanco As System.Windows.Forms.TextBox
End Class
