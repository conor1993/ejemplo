<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMensajeCajasNoAgregadas
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
        Me.lvwCajas = New System.Windows.Forms.ListView
        Me.clmFolioEtiqueta = New System.Windows.Forms.ColumnHeader
        Me.clmCodigoBarras = New System.Windows.Forms.ColumnHeader
        Me.clmProducto = New System.Windows.Forms.ColumnHeader
        Me.clmMotivoRechaso = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'lvwCajas
        '
        Me.lvwCajas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwCajas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmFolioEtiqueta, Me.clmCodigoBarras, Me.clmProducto, Me.clmMotivoRechaso})
        Me.lvwCajas.ForeColor = System.Drawing.Color.Red
        Me.lvwCajas.Location = New System.Drawing.Point(12, 12)
        Me.lvwCajas.Name = "lvwCajas"
        Me.lvwCajas.Size = New System.Drawing.Size(976, 511)
        Me.lvwCajas.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvwCajas.TabIndex = 0
        Me.lvwCajas.UseCompatibleStateImageBehavior = False
        Me.lvwCajas.View = System.Windows.Forms.View.Details
        '
        'clmFolioEtiqueta
        '
        Me.clmFolioEtiqueta.Text = "Folio Etiqueta"
        Me.clmFolioEtiqueta.Width = 96
        '
        'clmCodigoBarras
        '
        Me.clmCodigoBarras.Text = "Código de Barras"
        Me.clmCodigoBarras.Width = 176
        '
        'clmProducto
        '
        Me.clmProducto.Text = "Producto"
        Me.clmProducto.Width = 396
        '
        'clmMotivoRechaso
        '
        Me.clmMotivoRechaso.Text = "Motivo de Rechazo"
        Me.clmMotivoRechaso.Width = 295
        '
        'frmMensajeCajasNoAgregadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 535)
        Me.Controls.Add(Me.lvwCajas)
        Me.Name = "frmMensajeCajasNoAgregadas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cajas No Agregadas"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvwCajas As System.Windows.Forms.ListView
    Friend WithEvents clmFolioEtiqueta As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmCodigoBarras As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmProducto As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmMotivoRechaso As System.Windows.Forms.ColumnHeader
End Class
