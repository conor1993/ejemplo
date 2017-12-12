<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCajasNoAutorizadas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dgvExistencias = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmLoteCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmKilo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPiezas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFechaCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgvExistencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvExistencias
        '
        Me.dgvExistencias.AllowUserToAddRows = False
        Me.dgvExistencias.AllowUserToDeleteRows = False
        Me.dgvExistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExistencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmLoteCorte, Me.clmCorte, Me.clmDescripcion, Me.clmKilo, Me.clmPiezas, Me.clmFechaCorte})
        Me.dgvExistencias.Location = New System.Drawing.Point(12, 12)
        Me.dgvExistencias.Name = "dgvExistencias"
        Me.dgvExistencias.ReadOnly = True
        Me.dgvExistencias.RowHeadersVisible = False
        Me.dgvExistencias.Size = New System.Drawing.Size(683, 242)
        Me.dgvExistencias.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "LoteCorte"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Lote de Corte"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CodCorte"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Corte"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CantKgrs"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Kilos"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CantPzas"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Piezas"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "FechaCorte"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Fecha Corte"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'clmLoteCorte
        '
        Me.clmLoteCorte.DataPropertyName = "LoteCorte"
        Me.clmLoteCorte.HeaderText = "Lote de Corte"
        Me.clmLoteCorte.Name = "clmLoteCorte"
        Me.clmLoteCorte.ReadOnly = True
        '
        'clmCorte
        '
        Me.clmCorte.DataPropertyName = "CodCorte"
        Me.clmCorte.HeaderText = "Corte"
        Me.clmCorte.Name = "clmCorte"
        Me.clmCorte.ReadOnly = True
        Me.clmCorte.Width = 60
        '
        'clmDescripcion
        '
        Me.clmDescripcion.DataPropertyName = "Corte"
        Me.clmDescripcion.HeaderText = "Descripcion"
        Me.clmDescripcion.Name = "clmDescripcion"
        Me.clmDescripcion.ReadOnly = True
        Me.clmDescripcion.Width = 200
        '
        'clmKilo
        '
        Me.clmKilo.DataPropertyName = "CantKgrs"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.clmKilo.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmKilo.HeaderText = "Kilos"
        Me.clmKilo.Name = "clmKilo"
        Me.clmKilo.ReadOnly = True
        '
        'clmPiezas
        '
        Me.clmPiezas.DataPropertyName = "CantPzas"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.clmPiezas.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmPiezas.HeaderText = "Piezas"
        Me.clmPiezas.Name = "clmPiezas"
        Me.clmPiezas.ReadOnly = True
        '
        'clmFechaCorte
        '
        Me.clmFechaCorte.DataPropertyName = "FechaCorte"
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.clmFechaCorte.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmFechaCorte.HeaderText = "Fecha Corte"
        Me.clmFechaCorte.Name = "clmFechaCorte"
        Me.clmFechaCorte.ReadOnly = True
        '
        'FrmCajasNoAutorizadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 266)
        Me.Controls.Add(Me.dgvExistencias)
        Me.Name = "FrmCajasNoAutorizadas"
        Me.Text = "Existencias anteriores a cortes en embarque"
        CType(Me.dgvExistencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvExistencias As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmLoteCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmKilo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPiezas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaCorte As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
