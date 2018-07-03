<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaCuentaCierre
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbGridCuentas = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.lblNoCuenta = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.dgvCuentasContables = New System.Windows.Forms.DataGridView()
        Me.clmCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmNombreCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCuentaContable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmNaturaleza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmSaldoAnterior = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmSaldoactual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmAfectable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmInactiva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSelecionar = New System.Windows.Forms.Button()
        Me.tbCta = New Integra.Controles.TextboxNumerico()
        Me.tbSubCta = New Integra.Controles.TextboxNumerico()
        Me.tbSsubCta = New Integra.Controles.TextboxNumerico()
        Me.tbSssubCta = New Integra.Controles.TextboxNumerico()
        Me.gbGridCuentas.SuspendLayout()
        CType(Me.dgvCuentasContables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbGridCuentas
        '
        Me.gbGridCuentas.Controls.Add(Me.tbSssubCta)
        Me.gbGridCuentas.Controls.Add(Me.tbSsubCta)
        Me.gbGridCuentas.Controls.Add(Me.tbSubCta)
        Me.gbGridCuentas.Controls.Add(Me.tbCta)
        Me.gbGridCuentas.Controls.Add(Me.Label3)
        Me.gbGridCuentas.Controls.Add(Me.Label2)
        Me.gbGridCuentas.Controls.Add(Me.Label1)
        Me.gbGridCuentas.Controls.Add(Me.tbNombre)
        Me.gbGridCuentas.Controls.Add(Me.lblNoCuenta)
        Me.gbGridCuentas.Controls.Add(Me.lblNombre)
        Me.gbGridCuentas.Controls.Add(Me.dgvCuentasContables)
        Me.gbGridCuentas.Location = New System.Drawing.Point(12, 12)
        Me.gbGridCuentas.Name = "gbGridCuentas"
        Me.gbGridCuentas.Size = New System.Drawing.Size(740, 344)
        Me.gbGridCuentas.TabIndex = 0
        Me.gbGridCuentas.TabStop = False
        Me.gbGridCuentas.Text = "Cuentas Contables"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(334, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(255, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(176, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "-"
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(113, 25)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(294, 20)
        Me.tbNombre.TabIndex = 3
        '
        'lblNoCuenta
        '
        Me.lblNoCuenta.AutoSize = True
        Me.lblNoCuenta.Location = New System.Drawing.Point(6, 59)
        Me.lblNoCuenta.Name = "lblNoCuenta"
        Me.lblNoCuenta.Size = New System.Drawing.Size(79, 13)
        Me.lblNoCuenta.TabIndex = 2
        Me.lblNoCuenta.Text = "No. de Cuenta:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(6, 28)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(101, 13)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Buscar por Nombre:"
        '
        'dgvCuentasContables
        '
        Me.dgvCuentasContables.AllowUserToAddRows = False
        Me.dgvCuentasContables.AllowUserToDeleteRows = False
        Me.dgvCuentasContables.AllowUserToResizeRows = False
        Me.dgvCuentasContables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCuentasContables.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmCodigo, Me.clmNombreCuenta, Me.clmCuentaContable, Me.clmNaturaleza, Me.clmSaldoAnterior, Me.clmSaldoactual, Me.clmAfectable, Me.clmInactiva})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCuentasContables.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvCuentasContables.Location = New System.Drawing.Point(6, 93)
        Me.dgvCuentasContables.Name = "dgvCuentasContables"
        Me.dgvCuentasContables.RowHeadersVisible = False
        Me.dgvCuentasContables.Size = New System.Drawing.Size(728, 245)
        Me.dgvCuentasContables.TabIndex = 0
        '
        'clmCodigo
        '
        Me.clmCodigo.DataPropertyName = "codigo"
        Me.clmCodigo.HeaderText = "Codigo"
        Me.clmCodigo.Name = "clmCodigo"
        Me.clmCodigo.ReadOnly = True
        Me.clmCodigo.Visible = False
        '
        'clmNombreCuenta
        '
        Me.clmNombreCuenta.DataPropertyName = "NomCuenta"
        Me.clmNombreCuenta.HeaderText = "Nombre Cuenta"
        Me.clmNombreCuenta.Name = "clmNombreCuenta"
        Me.clmNombreCuenta.ReadOnly = True
        Me.clmNombreCuenta.Width = 113
        '
        'clmCuentaContable
        '
        Me.clmCuentaContable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.clmCuentaContable.DataPropertyName = "Cuenta"
        Me.clmCuentaContable.HeaderText = "Cuenta Contable"
        Me.clmCuentaContable.Name = "clmCuentaContable"
        Me.clmCuentaContable.ReadOnly = True
        Me.clmCuentaContable.Width = 112
        '
        'clmNaturaleza
        '
        Me.clmNaturaleza.DataPropertyName = "Naturaleza"
        Me.clmNaturaleza.HeaderText = "Naturaleza"
        Me.clmNaturaleza.Name = "clmNaturaleza"
        Me.clmNaturaleza.ReadOnly = True
        '
        'clmSaldoAnterior
        '
        Me.clmSaldoAnterior.DataPropertyName = "SaldoAnoAnt"
        Me.clmSaldoAnterior.HeaderText = "Saldo de Año Anterior"
        Me.clmSaldoAnterior.Name = "clmSaldoAnterior"
        Me.clmSaldoAnterior.ReadOnly = True
        '
        'clmSaldoactual
        '
        Me.clmSaldoactual.DataPropertyName = "SaldoIniEjerc"
        Me.clmSaldoactual.HeaderText = "Saldo Inicio de Ejercicio"
        Me.clmSaldoactual.Name = "clmSaldoactual"
        Me.clmSaldoactual.ReadOnly = True
        '
        'clmAfectable
        '
        Me.clmAfectable.DataPropertyName = "BooAfectable"
        Me.clmAfectable.HeaderText = "Afectable"
        Me.clmAfectable.Name = "clmAfectable"
        Me.clmAfectable.ReadOnly = True
        '
        'clmInactiva
        '
        Me.clmInactiva.DataPropertyName = "BooAfectable"
        Me.clmInactiva.HeaderText = "Inactiva"
        Me.clmInactiva.Name = "clmInactiva"
        Me.clmInactiva.ReadOnly = True
        '
        'btnSelecionar
        '
        Me.btnSelecionar.Location = New System.Drawing.Point(677, 362)
        Me.btnSelecionar.Name = "btnSelecionar"
        Me.btnSelecionar.Size = New System.Drawing.Size(75, 23)
        Me.btnSelecionar.TabIndex = 1
        Me.btnSelecionar.Text = "Selecionar"
        Me.btnSelecionar.UseVisualStyleBackColor = True
        '
        'tbCta
        '
        Me.tbCta.Location = New System.Drawing.Point(113, 56)
        Me.tbCta.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.tbCta.MaxLength = 4
        Me.tbCta.Name = "tbCta"
        Me.tbCta.Posiciones = 4
        Me.tbCta.Size = New System.Drawing.Size(62, 20)
        Me.tbCta.TabIndex = 15
        Me.tbCta.Text = "0000"
        Me.tbCta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSubCta
        '
        Me.tbSubCta.Location = New System.Drawing.Point(190, 56)
        Me.tbSubCta.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.tbSubCta.MaxLength = 4
        Me.tbSubCta.Name = "tbSubCta"
        Me.tbSubCta.Posiciones = 4
        Me.tbSubCta.Size = New System.Drawing.Size(62, 20)
        Me.tbSubCta.TabIndex = 16
        Me.tbSubCta.Text = "0000"
        Me.tbSubCta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSsubCta
        '
        Me.tbSsubCta.Location = New System.Drawing.Point(268, 56)
        Me.tbSsubCta.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.tbSsubCta.MaxLength = 4
        Me.tbSsubCta.Name = "tbSsubCta"
        Me.tbSsubCta.Posiciones = 4
        Me.tbSsubCta.Size = New System.Drawing.Size(62, 20)
        Me.tbSsubCta.TabIndex = 17
        Me.tbSsubCta.Text = "0000"
        Me.tbSsubCta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbSssubCta
        '
        Me.tbSssubCta.Location = New System.Drawing.Point(347, 56)
        Me.tbSssubCta.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.tbSssubCta.MaxLength = 4
        Me.tbSssubCta.Name = "tbSssubCta"
        Me.tbSssubCta.Posiciones = 4
        Me.tbSssubCta.Size = New System.Drawing.Size(60, 20)
        Me.tbSssubCta.TabIndex = 18
        Me.tbSssubCta.Text = "0000"
        Me.tbSssubCta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmBusquedaCuentaCierre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 397)
        Me.Controls.Add(Me.btnSelecionar)
        Me.Controls.Add(Me.gbGridCuentas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBusquedaCuentaCierre"
        Me.Text = "Buscar Cuenta Cierre"
        Me.gbGridCuentas.ResumeLayout(False)
        Me.gbGridCuentas.PerformLayout()
        CType(Me.dgvCuentasContables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbGridCuentas As System.Windows.Forms.GroupBox
    Friend WithEvents dgvCuentasContables As System.Windows.Forms.DataGridView
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents btnSelecionar As System.Windows.Forms.Button
    Friend WithEvents lblNoCuenta As System.Windows.Forms.Label
    Friend WithEvents tbNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents clmCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmNombreCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCuentaContable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmNaturaleza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSaldoAnterior As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSaldoactual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmAfectable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmInactiva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tbCta As Integra.Controles.TextboxNumerico
    Friend WithEvents tbSssubCta As Integra.Controles.TextboxNumerico
    Friend WithEvents tbSsubCta As Integra.Controles.TextboxNumerico
    Friend WithEvents tbSubCta As Integra.Controles.TextboxNumerico
End Class
