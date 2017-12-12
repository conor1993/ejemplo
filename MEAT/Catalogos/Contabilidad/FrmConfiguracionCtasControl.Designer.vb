<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfiguracionCtasControl
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
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgvcuentas = New System.Windows.Forms.DataGridView
        Me.clmConcepto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCuentaContable = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvcuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mtb
        '
        Me.mtb.ButtonSize = New System.Drawing.Size(50, 50)
        Me.mtb.Dock = System.Windows.Forms.DockStyle.None
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
        Me.mtb.Location = New System.Drawing.Point(3, -24)
        Me.mtb.MostrarBorrar = False
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = False
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 405)
        Me.mtb.TabIndex = 100
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(706, 29)
        Me.lblTitulo.TabIndex = 101
        Me.lblTitulo.Text = "CONFIGURACIÓN DE CUENTAS DE CONTROL"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvcuentas)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(638, 266)
        Me.GroupBox1.TabIndex = 117
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cuentas de Control Registradas"
        '
        'dgvcuentas
        '
        Me.dgvcuentas.AllowUserToAddRows = False
        Me.dgvcuentas.AllowUserToDeleteRows = False
        Me.dgvcuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmConcepto, Me.clmCuentaContable})
        Me.dgvcuentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvcuentas.Location = New System.Drawing.Point(3, 16)
        Me.dgvcuentas.Name = "dgvcuentas"
        Me.dgvcuentas.RowHeadersVisible = False
        Me.dgvcuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvcuentas.Size = New System.Drawing.Size(632, 247)
        Me.dgvcuentas.TabIndex = 0
        '
        'clmConcepto
        '
        Me.clmConcepto.DataPropertyName = "Concepto"
        Me.clmConcepto.HeaderText = "Concepto"
        Me.clmConcepto.Name = "clmConcepto"
        Me.clmConcepto.Width = 260
        '
        'clmCuentaContable
        '
        Me.clmCuentaContable.DataPropertyName = "IdCuentaContable"
        Me.clmCuentaContable.HeaderText = "Cuenta Contable"
        Me.clmCuentaContable.Name = "clmCuentaContable"
        Me.clmCuentaContable.Width = 350
        '
        'ConfiguracionCtasControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 311)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ConfiguracionCtasControl"
        Me.Text = "Configuración de Cuentas de Control"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvcuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvcuentas As System.Windows.Forms.DataGridView
    Friend WithEvents clmConcepto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCuentaContable As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
