<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleDevolucion
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
        Me.Label17 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.clmFolioEtiqueta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCodigoBarra = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCantPzas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCantKgrs = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFechaCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFolioEmbarque = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFechaEmbarque = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(0, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(1065, 32)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "DETALLE DE DEVOLUCION"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmFolioEtiqueta, Me.clmCodigoBarra, Me.clmCliente, Me.clmCorte, Me.clmCantPzas, Me.clmCantKgrs, Me.clmFechaCorte, Me.clmFolioEmbarque, Me.clmFechaEmbarque, Me.clmEstatus})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 35)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(1041, 219)
        Me.DataGridView1.TabIndex = 3
        '
        'clmFolioEtiqueta
        '
        Me.clmFolioEtiqueta.DataPropertyName = "IdFolioEtiqueta"
        Me.clmFolioEtiqueta.HeaderText = "FolioEtiqueta"
        Me.clmFolioEtiqueta.Name = "clmFolioEtiqueta"
        Me.clmFolioEtiqueta.ReadOnly = True
        '
        'clmCodigoBarra
        '
        Me.clmCodigoBarra.DataPropertyName = "CodigoBarra"
        Me.clmCodigoBarra.HeaderText = "CodigoBarra"
        Me.clmCodigoBarra.Name = "clmCodigoBarra"
        Me.clmCodigoBarra.ReadOnly = True
        Me.clmCodigoBarra.Width = 120
        '
        'clmCliente
        '
        Me.clmCliente.DataPropertyName = "Cliente"
        Me.clmCliente.HeaderText = "Cliente"
        Me.clmCliente.Name = "clmCliente"
        Me.clmCliente.ReadOnly = True
        Me.clmCliente.Width = 200
        '
        'clmCorte
        '
        Me.clmCorte.DataPropertyName = "Corte"
        Me.clmCorte.HeaderText = "Corte"
        Me.clmCorte.Name = "clmCorte"
        Me.clmCorte.ReadOnly = True
        '
        'clmCantPzas
        '
        Me.clmCantPzas.DataPropertyName = "CantPzas"
        Me.clmCantPzas.HeaderText = "CantPzas"
        Me.clmCantPzas.Name = "clmCantPzas"
        Me.clmCantPzas.ReadOnly = True
        Me.clmCantPzas.Width = 70
        '
        'clmCantKgrs
        '
        Me.clmCantKgrs.DataPropertyName = "clmCantKgrs"
        Me.clmCantKgrs.HeaderText = "CantKgrs"
        Me.clmCantKgrs.Name = "clmCantKgrs"
        Me.clmCantKgrs.ReadOnly = True
        Me.clmCantKgrs.Width = 70
        '
        'clmFechaCorte
        '
        Me.clmFechaCorte.DataPropertyName = "FechaCorte"
        Me.clmFechaCorte.HeaderText = "FechaCorte"
        Me.clmFechaCorte.Name = "clmFechaCorte"
        Me.clmFechaCorte.ReadOnly = True
        '
        'clmFolioEmbarque
        '
        Me.clmFolioEmbarque.DataPropertyName = "IdFolioEmbarque"
        Me.clmFolioEmbarque.HeaderText = "FolioEmbarque"
        Me.clmFolioEmbarque.Name = "clmFolioEmbarque"
        Me.clmFolioEmbarque.ReadOnly = True
        '
        'clmFechaEmbarque
        '
        Me.clmFechaEmbarque.DataPropertyName = "FechaEmbarque"
        Me.clmFechaEmbarque.HeaderText = "FechaEmbarque"
        Me.clmFechaEmbarque.Name = "clmFechaEmbarque"
        Me.clmFechaEmbarque.ReadOnly = True
        '
        'clmEstatus
        '
        Me.clmEstatus.DataPropertyName = "Estatus"
        Me.clmEstatus.HeaderText = "Estatus"
        Me.clmEstatus.Name = "clmEstatus"
        Me.clmEstatus.ReadOnly = True
        '
        'frmDetalleDevolucion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 266)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label17)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetalleDevolucion"
        Me.Text = "DETALLE DE DEVOLUCION"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents clmFolioEtiqueta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCodigoBarra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCantPzas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCantKgrs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFolioEmbarque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaEmbarque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
