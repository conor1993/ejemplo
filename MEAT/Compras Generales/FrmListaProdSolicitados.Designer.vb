<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListaProdSolicitados
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbPlaza = New System.Windows.Forms.ComboBox
        Me.cmbSucursal = New System.Windows.Forms.ComboBox
        Me.cmbFamilia = New System.Windows.Forms.ComboBox
        Me.cmbSubFamilia = New System.Windows.Forms.ComboBox
        Me.txtProducto = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGrid = New System.Windows.Forms.DataGridView
        Me.ClmChk = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ClmFolio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmFechaSolicito = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmProducto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmFechaSurtir = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmUrgente = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ClmEntregarA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmEntrgarEn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(983, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "LISTA DE PRODUCTOS SOLICITADOS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Plaza:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Sucursal:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Línea:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(379, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Sub-Línea:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Producto:"
        '
        'cmbPlaza
        '
        Me.cmbPlaza.FormattingEnabled = True
        Me.cmbPlaza.Location = New System.Drawing.Point(71, 35)
        Me.cmbPlaza.Name = "cmbPlaza"
        Me.cmbPlaza.Size = New System.Drawing.Size(302, 21)
        Me.cmbPlaza.TabIndex = 9
        '
        'cmbSucursal
        '
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(71, 62)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(302, 21)
        Me.cmbSucursal.TabIndex = 10
        '
        'cmbFamilia
        '
        Me.cmbFamilia.FormattingEnabled = True
        Me.cmbFamilia.Location = New System.Drawing.Point(71, 89)
        Me.cmbFamilia.Name = "cmbFamilia"
        Me.cmbFamilia.Size = New System.Drawing.Size(302, 21)
        Me.cmbFamilia.TabIndex = 11
        '
        'cmbSubFamilia
        '
        Me.cmbSubFamilia.FormattingEnabled = True
        Me.cmbSubFamilia.Location = New System.Drawing.Point(449, 89)
        Me.cmbSubFamilia.Name = "cmbSubFamilia"
        Me.cmbSubFamilia.Size = New System.Drawing.Size(304, 21)
        Me.cmbSubFamilia.TabIndex = 12
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(71, 116)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(302, 20)
        Me.txtProducto.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DataGrid)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 142)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(959, 411)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de Productos Solicitados"
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.AllowUserToResizeRows = False
        Me.DataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClmChk, Me.ClmFolio, Me.ClmFechaSolicito, Me.ClmCodigo, Me.ClmProducto, Me.ClmCantidad, Me.ClmUnidad, Me.ClmFechaSurtir, Me.ClmUrgente, Me.ClmEntregarA, Me.ClmEntrgarEn, Me.ClmObservaciones})
        Me.DataGrid.Location = New System.Drawing.Point(6, 22)
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.RowHeadersVisible = False
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(947, 383)
        Me.DataGrid.TabIndex = 0
        '
        'ClmChk
        '
        Me.ClmChk.HeaderText = ""
        Me.ClmChk.Name = "ClmChk"
        Me.ClmChk.Width = 30
        '
        'ClmFolio
        '
        Me.ClmFolio.HeaderText = "Folio"
        Me.ClmFolio.Name = "ClmFolio"
        Me.ClmFolio.ReadOnly = True
        '
        'ClmFechaSolicito
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.ClmFechaSolicito.DefaultCellStyle = DataGridViewCellStyle1
        Me.ClmFechaSolicito.HeaderText = "Fecha Solicito"
        Me.ClmFechaSolicito.Name = "ClmFechaSolicito"
        Me.ClmFechaSolicito.ReadOnly = True
        Me.ClmFechaSolicito.Width = 140
        '
        'ClmCodigo
        '
        Me.ClmCodigo.HeaderText = "Código"
        Me.ClmCodigo.Name = "ClmCodigo"
        Me.ClmCodigo.ReadOnly = True
        '
        'ClmProducto
        '
        Me.ClmProducto.HeaderText = "Producto"
        Me.ClmProducto.Name = "ClmProducto"
        Me.ClmProducto.ReadOnly = True
        Me.ClmProducto.Width = 200
        '
        'ClmCantidad
        '
        DataGridViewCellStyle2.Format = "N3"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.ClmCantidad.DefaultCellStyle = DataGridViewCellStyle2
        Me.ClmCantidad.HeaderText = "Cantidad"
        Me.ClmCantidad.Name = "ClmCantidad"
        Me.ClmCantidad.ReadOnly = True
        '
        'ClmUnidad
        '
        Me.ClmUnidad.HeaderText = "Unidad"
        Me.ClmUnidad.Name = "ClmUnidad"
        Me.ClmUnidad.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'ClmFechaSurtir
        '
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ClmFechaSurtir.DefaultCellStyle = DataGridViewCellStyle3
        Me.ClmFechaSurtir.HeaderText = "Fecha Surtir"
        Me.ClmFechaSurtir.Name = "ClmFechaSurtir"
        Me.ClmFechaSurtir.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ClmFechaSurtir.Width = 130
        '
        'ClmUrgente
        '
        Me.ClmUrgente.HeaderText = "Urgente"
        Me.ClmUrgente.Name = "ClmUrgente"
        Me.ClmUrgente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ClmUrgente.Width = 80
        '
        'ClmEntregarA
        '
        Me.ClmEntregarA.HeaderText = "Entregar A"
        Me.ClmEntregarA.Name = "ClmEntregarA"
        Me.ClmEntregarA.ReadOnly = True
        Me.ClmEntregarA.Width = 200
        '
        'ClmEntrgarEn
        '
        Me.ClmEntrgarEn.HeaderText = "Entregar En"
        Me.ClmEntrgarEn.Name = "ClmEntrgarEn"
        Me.ClmEntrgarEn.ReadOnly = True
        Me.ClmEntrgarEn.Width = 200
        '
        'ClmObservaciones
        '
        Me.ClmObservaciones.HeaderText = "Observaciones"
        Me.ClmObservaciones.Name = "ClmObservaciones"
        Me.ClmObservaciones.ReadOnly = True
        Me.ClmObservaciones.Width = 200
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Location = New System.Drawing.Point(815, 559)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 15
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Location = New System.Drawing.Point(896, 559)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 16
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBuscar.Location = New System.Drawing.Point(913, 81)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(58, 56)
        Me.btnBuscar.TabIndex = 17
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'ComListaProdSolicitados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 594)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.cmbSubFamilia)
        Me.Controls.Add(Me.cmbFamilia)
        Me.Controls.Add(Me.cmbSucursal)
        Me.Controls.Add(Me.cmbPlaza)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(991, 628)
        Me.MinimumSize = New System.Drawing.Size(991, 628)
        Me.Name = "ComListaProdSolicitados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Productos Solicitados"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbPlaza As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents cmbFamilia As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSubFamilia As System.Windows.Forms.ComboBox
    Friend WithEvents txtProducto As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents ClmChk As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ClmFolio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmFechaSolicito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmFechaSurtir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmUrgente As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ClmEntregarA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmEntrgarEn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmObservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
