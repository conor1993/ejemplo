<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArchivoCierreFicticioLotes
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.dtgDatos = New System.Windows.Forms.DataGridView
        Me.clmLote = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCorral = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCabezas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblFechaFinal = New System.Windows.Forms.Label
        CType(Me.dtgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(427, 32)
        Me.lblTitulo.TabIndex = 56
        Me.lblTitulo.Text = "Archivo de Cierre Ficticio de Lotes"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.mtb.Location = New System.Drawing.Point(-2, -21)
        Me.mtb.MostrarBorrar = False
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = False
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = False
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 422)
        Me.mtb.TabIndex = 55
        '
        'dtgDatos
        '
        Me.dtgDatos.AllowUserToAddRows = False
        Me.dtgDatos.AllowUserToDeleteRows = False
        Me.dtgDatos.AllowUserToResizeRows = False
        Me.dtgDatos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmLote, Me.clmCorral, Me.clmCabezas})
        Me.dtgDatos.Location = New System.Drawing.Point(54, 66)
        Me.dtgDatos.Name = "dtgDatos"
        Me.dtgDatos.RowHeadersVisible = False
        Me.dtgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgDatos.Size = New System.Drawing.Size(361, 406)
        Me.dtgDatos.TabIndex = 61
        '
        'clmLote
        '
        Me.clmLote.DataPropertyName = "Descripcion"
        Me.clmLote.HeaderText = "Lote"
        Me.clmLote.Name = "clmLote"
        Me.clmLote.Width = 120
        '
        'clmCorral
        '
        Me.clmCorral.DataPropertyName = "NombreCorral"
        Me.clmCorral.HeaderText = "Corral"
        Me.clmCorral.Name = "clmCorral"
        Me.clmCorral.Width = 120
        '
        'clmCabezas
        '
        Me.clmCabezas.DataPropertyName = "SaldoCabezas"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.clmCabezas.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmCabezas.HeaderText = "Cabezas"
        Me.clmCabezas.Name = "clmCabezas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Fecha Final:"
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.AutoSize = True
        Me.lblFechaFinal.Location = New System.Drawing.Point(134, 40)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(69, 13)
        Me.lblFechaFinal.TabIndex = 62
        Me.lblFechaFinal.Text = "lblFechaFinal"
        '
        'FrmArchivoCierreFicticioLotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 482)
        Me.Controls.Add(Me.lblFechaFinal)
        Me.Controls.Add(Me.dtgDatos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.mtb)
        Me.MaximizeBox = False
        Me.Name = "FrmArchivoCierreFicticioLotes"
        Me.Text = "Archivo de Cierre Ficticio de Lotes"
        CType(Me.dtgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents dtgDatos As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents clmLote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCorral As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCabezas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblFechaFinal As System.Windows.Forms.Label
End Class
