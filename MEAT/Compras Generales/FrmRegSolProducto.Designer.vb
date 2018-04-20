<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegSolProducto

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFolio = New System.Windows.Forms.TextBox()
        Me.txtSolicita = New System.Windows.Forms.TextBox()
        Me.dtpFechaSolicitud = New System.Windows.Forms.DateTimePicker()
        Me.txtEntregarEn = New System.Windows.Forms.TextBox()
        Me.txtEntregarA = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvSolicitudDetalles = New System.Windows.Forms.DataGridView()
        Me.cmbPlaza = New System.Windows.Forms.ComboBox()
        Me.cmbSucursal = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPara = New System.Windows.Forms.TextBox()
        Me.txtPlazaCodigo = New System.Windows.Forms.TextBox()
        Me.txtSucursalCodigo = New System.Windows.Forms.TextBox()
        Me.dtpFechaSurtir = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.clmIdSolicitud = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmFamilia = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.clmIdProducto = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.clmUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmUrgente = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.clmFechaSurtir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvSolicitudDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEstatus
        '
        Me.lblEstatus.Location = New System.Drawing.Point(651, 38)
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(759, 29)
        Me.lblTitulo.Text = "REGISTRO DE SOLICITUD DE PRODUCTOS"
        '
        'tbrMenu
        '
        Me.tbrMenu.Size = New System.Drawing.Size(50, 490)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(461, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Folio:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(461, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Solicita:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Fecha de Solicitud:"
        '
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(542, 40)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.ReadOnly = True
        Me.txtFolio.Size = New System.Drawing.Size(100, 20)
        Me.txtFolio.TabIndex = 0
        Me.txtFolio.TabStop = False
        '
        'txtSolicita
        '
        Me.txtSolicita.Location = New System.Drawing.Point(542, 68)
        Me.txtSolicita.Name = "txtSolicita"
        Me.txtSolicita.ReadOnly = True
        Me.txtSolicita.Size = New System.Drawing.Size(259, 20)
        Me.txtSolicita.TabIndex = 2
        Me.txtSolicita.TabStop = False
        '
        'dtpFechaSolicitud
        '
        Me.dtpFechaSolicitud.Enabled = False
        Me.dtpFechaSolicitud.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaSolicitud.Location = New System.Drawing.Point(161, 94)
        Me.dtpFechaSolicitud.Name = "dtpFechaSolicitud"
        Me.dtpFechaSolicitud.Size = New System.Drawing.Size(87, 20)
        Me.dtpFechaSolicitud.TabIndex = 1
        '
        'txtEntregarEn
        '
        Me.txtEntregarEn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEntregarEn.Location = New System.Drawing.Point(161, 172)
        Me.txtEntregarEn.MaxLength = 50
        Me.txtEntregarEn.Name = "txtEntregarEn"
        Me.txtEntregarEn.Size = New System.Drawing.Size(285, 20)
        Me.txtEntregarEn.TabIndex = 7
        '
        'txtEntregarA
        '
        Me.txtEntregarA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEntregarA.Location = New System.Drawing.Point(161, 146)
        Me.txtEntregarA.MaxLength = 50
        Me.txtEntregarA.Name = "txtEntregarA"
        Me.txtEntregarA.Size = New System.Drawing.Size(285, 20)
        Me.txtEntregarA.TabIndex = 6
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Location = New System.Drawing.Point(464, 120)
        Me.txtObservaciones.MaxLength = 250
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(337, 72)
        Me.txtObservaciones.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(461, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Observaciones:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(57, 175)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Entregar en:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(57, 149)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "Entregar a:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvSolicitudDetalles)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(56, 198)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(756, 284)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de la Solicitud"
        '
        'dgvSolicitudDetalles
        '
        Me.dgvSolicitudDetalles.AllowUserToAddRows = False
        Me.dgvSolicitudDetalles.AllowUserToDeleteRows = False
        Me.dgvSolicitudDetalles.AllowUserToResizeRows = False
        Me.dgvSolicitudDetalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmIdSolicitud, Me.clmFamilia, Me.clmIdProducto, Me.clmUnidad, Me.clmCantidad, Me.clmUrgente, Me.clmFechaSurtir, Me.clmObservaciones, Me.clmEstatus})
        Me.dgvSolicitudDetalles.Location = New System.Drawing.Point(6, 22)
        Me.dgvSolicitudDetalles.MultiSelect = False
        Me.dgvSolicitudDetalles.Name = "dgvSolicitudDetalles"
        Me.dgvSolicitudDetalles.RowHeadersVisible = False
        Me.dgvSolicitudDetalles.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSolicitudDetalles.Size = New System.Drawing.Size(744, 256)
        Me.dgvSolicitudDetalles.TabIndex = 0
        '
        'cmbPlaza
        '
        Me.cmbPlaza.FormattingEnabled = True
        Me.cmbPlaza.Location = New System.Drawing.Point(228, 40)
        Me.cmbPlaza.Name = "cmbPlaza"
        Me.cmbPlaza.Size = New System.Drawing.Size(218, 21)
        Me.cmbPlaza.TabIndex = 4
        '
        'cmbSucursal
        '
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(228, 67)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(218, 21)
        Me.cmbSucursal.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Sucursal:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Plaza:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Para:"
        '
        'txtPara
        '
        Me.txtPara.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPara.Location = New System.Drawing.Point(161, 120)
        Me.txtPara.Name = "txtPara"
        Me.txtPara.Size = New System.Drawing.Size(285, 20)
        Me.txtPara.TabIndex = 3
        '
        'txtPlazaCodigo
        '
        Me.txtPlazaCodigo.Location = New System.Drawing.Point(161, 40)
        Me.txtPlazaCodigo.Name = "txtPlazaCodigo"
        Me.txtPlazaCodigo.Size = New System.Drawing.Size(61, 20)
        Me.txtPlazaCodigo.TabIndex = 71
        '
        'txtSucursalCodigo
        '
        Me.txtSucursalCodigo.Location = New System.Drawing.Point(161, 67)
        Me.txtSucursalCodigo.Name = "txtSucursalCodigo"
        Me.txtSucursalCodigo.Size = New System.Drawing.Size(61, 20)
        Me.txtSucursalCodigo.TabIndex = 72
        '
        'dtpFechaSurtir
        '
        Me.dtpFechaSurtir.Enabled = False
        Me.dtpFechaSurtir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaSurtir.Location = New System.Drawing.Point(358, 94)
        Me.dtpFechaSurtir.Name = "dtpFechaSurtir"
        Me.dtpFechaSurtir.Size = New System.Drawing.Size(88, 20)
        Me.dtpFechaSurtir.TabIndex = 73
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(276, 98)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 74
        Me.Label10.Text = "Fecha a Surtir:"
        '
        'clmIdSolicitud
        '
        Me.clmIdSolicitud.DataPropertyName = "IdSolicitud"
        Me.clmIdSolicitud.HeaderText = "IdSolicitud"
        Me.clmIdSolicitud.Name = "clmIdSolicitud"
        Me.clmIdSolicitud.ReadOnly = True
        Me.clmIdSolicitud.Visible = False
        '
        'clmFamilia
        '
        Me.clmFamilia.DataPropertyName = "LNIdLinea"
        Me.clmFamilia.HeaderText = "Familia"
        Me.clmFamilia.Name = "clmFamilia"
        Me.clmFamilia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clmFamilia.Visible = False
        '
        'clmIdProducto
        '
        Me.clmIdProducto.DataPropertyName = "IdProducto"
        Me.clmIdProducto.HeaderText = "Artículos/Insumos "
        Me.clmIdProducto.Name = "clmIdProducto"
        Me.clmIdProducto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmIdProducto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clmIdProducto.Width = 190
        '
        'clmUnidad
        '
        Me.clmUnidad.DataPropertyName = "UnidadMedida"
        Me.clmUnidad.HeaderText = "Unidad"
        Me.clmUnidad.Name = "clmUnidad"
        '
        'clmCantidad
        '
        Me.clmCantidad.DataPropertyName = "Cantidad"
        DataGridViewCellStyle1.Format = "N2"
        Me.clmCantidad.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmCantidad.HeaderText = "Cantidad"
        Me.clmCantidad.Name = "clmCantidad"
        Me.clmCantidad.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmCantidad.Width = 80
        '
        'clmUrgente
        '
        Me.clmUrgente.DataPropertyName = "Urgente"
        Me.clmUrgente.HeaderText = "Urgente"
        Me.clmUrgente.Name = "clmUrgente"
        Me.clmUrgente.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmUrgente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clmUrgente.Width = 70
        '
        'clmFechaSurtir
        '
        Me.clmFechaSurtir.DataPropertyName = "FechaSurtir"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.clmFechaSurtir.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmFechaSurtir.HeaderText = "Surtido"
        Me.clmFechaSurtir.Name = "clmFechaSurtir"
        Me.clmFechaSurtir.Width = 80
        '
        'clmObservaciones
        '
        Me.clmObservaciones.DataPropertyName = "Observaciones"
        Me.clmObservaciones.HeaderText = "Observaciones"
        Me.clmObservaciones.Name = "clmObservaciones"
        Me.clmObservaciones.Width = 120
        '
        'clmEstatus
        '
        Me.clmEstatus.DataPropertyName = "Estatus"
        Me.clmEstatus.HeaderText = "Estatus"
        Me.clmEstatus.Name = "clmEstatus"
        Me.clmEstatus.Width = 80
        '
        'FrmRegSolProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 490)
        Me.Controls.Add(Me.dtpFechaSurtir)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtSucursalCodigo)
        Me.Controls.Add(Me.txtPlazaCodigo)
        Me.Controls.Add(Me.txtPara)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbPlaza)
        Me.Controls.Add(Me.cmbSucursal)
        Me.Controls.Add(Me.txtEntregarEn)
        Me.Controls.Add(Me.txtEntregarA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtSolicita)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpFechaSolicitud)
        Me.Controls.Add(Me.Label6)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(825, 528)
        Me.MinimumSize = New System.Drawing.Size(825, 528)
        Me.Name = "FrmRegSolProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REGISTRO DE SOLICITUD DE PRODUCTOS"
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaSolicitud, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.txtFolio, 0)
        Me.Controls.SetChildIndex(Me.txtSolicita, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.txtObservaciones, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.txtEntregarA, 0)
        Me.Controls.SetChildIndex(Me.lblEstatus, 0)
        Me.Controls.SetChildIndex(Me.txtEntregarEn, 0)
        Me.Controls.SetChildIndex(Me.cmbSucursal, 0)
        Me.Controls.SetChildIndex(Me.cmbPlaza, 0)
        Me.Controls.SetChildIndex(Me.tbrMenu, 0)
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtPara, 0)
        Me.Controls.SetChildIndex(Me.txtPlazaCodigo, 0)
        Me.Controls.SetChildIndex(Me.txtSucursalCodigo, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaSurtir, 0)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvSolicitudDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents txtSolicita As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaSolicitud As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtEntregarEn As System.Windows.Forms.TextBox
    Friend WithEvents txtEntregarA As System.Windows.Forms.TextBox
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvSolicitudDetalles As System.Windows.Forms.DataGridView
    Friend WithEvents cmbPlaza As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPara As System.Windows.Forms.TextBox
    Friend WithEvents txtPlazaCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtSucursalCodigo As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaSurtir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents clmIdSolicitud As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFamilia As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents clmIdProducto As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents clmUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmUrgente As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents clmFechaSurtir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmObservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
