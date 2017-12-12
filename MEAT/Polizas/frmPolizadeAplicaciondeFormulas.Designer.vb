<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPolizadeAplicaciondeFormulas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.dgvCuentasControl = New System.Windows.Forms.DataGridView
        Me.IdCuentaCont = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SsubCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SssubCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCargo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmAbono = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dtbFechaContable = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar
        Me.CuentaControl = New Integralab.ORM.CollectionClasses.CfgCtrlCtasCollection
        Me.Label17 = New System.Windows.Forms.Label
        CType(Me.dgvCuentasControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCuentasControl
        '
        Me.dgvCuentasControl.AllowUserToAddRows = False
        Me.dgvCuentasControl.AllowUserToDeleteRows = False
        Me.dgvCuentasControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCuentasControl.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCuentaCont, Me.Column7, Me.Cuenta, Me.SubCuenta, Me.SsubCuenta, Me.SssubCuenta, Me.Descripcion, Me.clmCargo, Me.clmAbono})
        Me.dgvCuentasControl.Location = New System.Drawing.Point(60, 104)
        Me.dgvCuentasControl.Name = "dgvCuentasControl"
        Me.dgvCuentasControl.RowHeadersVisible = False
        Me.dgvCuentasControl.Size = New System.Drawing.Size(316, 120)
        Me.dgvCuentasControl.TabIndex = 64
        Me.dgvCuentasControl.Visible = False
        '
        'IdCuentaCont
        '
        Me.IdCuentaCont.DataPropertyName = "IdCuentaCont"
        Me.IdCuentaCont.HeaderText = "IdCuentaCont"
        Me.IdCuentaCont.Name = "IdCuentaCont"
        Me.IdCuentaCont.Visible = False
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "Folio"
        Me.Column7.HeaderText = "Folio"
        Me.Column7.Name = "Column7"
        '
        'Cuenta
        '
        Me.Cuenta.DataPropertyName = "CveCta"
        Me.Cuenta.HeaderText = "Cuenta"
        Me.Cuenta.Name = "Cuenta"
        Me.Cuenta.Width = 80
        '
        'SubCuenta
        '
        Me.SubCuenta.DataPropertyName = "cvesubcta"
        Me.SubCuenta.HeaderText = "SubCta"
        Me.SubCuenta.Name = "SubCuenta"
        Me.SubCuenta.Width = 80
        '
        'SsubCuenta
        '
        Me.SsubCuenta.DataPropertyName = "cvessubcta"
        Me.SsubCuenta.HeaderText = "SsubCta"
        Me.SsubCuenta.Name = "SsubCuenta"
        Me.SsubCuenta.Width = 80
        '
        'SssubCuenta
        '
        Me.SssubCuenta.DataPropertyName = "cvesssubcta"
        Me.SssubCuenta.HeaderText = "SssubCta"
        Me.SssubCuenta.Name = "SssubCuenta"
        Me.SssubCuenta.Width = 80
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "nomconcepto"
        Me.Descripcion.HeaderText = "Concepto"
        Me.Descripcion.Name = "Descripcion"
        '
        'clmCargo
        '
        Me.clmCargo.HeaderText = "Cargo"
        Me.clmCargo.Name = "clmCargo"
        '
        'clmAbono
        '
        Me.clmAbono.HeaderText = "Abono"
        Me.clmAbono.Name = "clmAbono"
        '
        'dtbFechaContable
        '
        Me.dtbFechaContable.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtbFechaContable.Location = New System.Drawing.Point(149, 66)
        Me.dtbFechaContable.Name = "dtbFechaContable"
        Me.dtbFechaContable.Size = New System.Drawing.Size(88, 20)
        Me.dtbFechaContable.TabIndex = 63
        Me.dtbFechaContable.Value = New Date(2007, 7, 31, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Fecha Contable :"
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
        Me.MEAToolBar1.MostrarBuscar = False
        Me.MEAToolBar1.MostrarCancelar = False
        Me.MEAToolBar1.MostrarEditar = False
        Me.MEAToolBar1.MostrarGuardar = True
        Me.MEAToolBar1.MostrarImprimir = False
        Me.MEAToolBar1.MostrarLimpiar = True
        Me.MEAToolBar1.MostrarNuevo = False
        Me.MEAToolBar1.MostrarSalir = True
        Me.MEAToolBar1.Name = "MEAToolBar1"
        Me.MEAToolBar1.ShowToolTips = True
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 246)
        Me.MEAToolBar1.TabIndex = 60
        '
        'CuentaControl
        '
        Me.CuentaControl.ActiveContext = Nothing
        Me.CuentaControl.AllowEdit = True
        Me.CuentaControl.AllowNew = True
        Me.CuentaControl.AllowRemove = True
        Me.CuentaControl.Capacity = 32
        Me.CuentaControl.ConcurrencyPredicateFactoryToUse = Nothing
        Me.CuentaControl.DoNotPerformAddIfPresent = False
        Me.CuentaControl.EntityFactoryToUse = New Integralab.ORM.FactoryClasses.CfgCtrlCtasEntityFactory
        Me.CuentaControl.IsReadOnly = False
        Me.CuentaControl.MaxNumberOfItemsToReturn = CType(0, Long)
        Me.CuentaControl.SortClauses = Nothing
        Me.CuentaControl.SuppressClearInGetMulti = False
        Me.CuentaControl.Transaction = Nothing
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(440, 32)
        Me.Label17.TabIndex = 65
        Me.Label17.Text = "Póliza de Aplicación y Prorrateo de Formula"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmPolizadeAplicaciondeFormulas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 246)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.dgvCuentasControl)
        Me.Controls.Add(Me.dtbFechaContable)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.Name = "frmPolizadeAplicaciondeFormulas"
        Me.Text = "Poliza de Aplicacion de Formulas"
        CType(Me.dgvCuentasControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvCuentasControl As System.Windows.Forms.DataGridView
    Friend WithEvents IdCuentaCont As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SsubCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SssubCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmAbono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtbFechaContable As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents CuentaControl As Integralab.ORM.CollectionClasses.CfgCtrlCtasCollection
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class
