<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusquedaSolicitudProducto

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
        Me.cmbPlaza = New System.Windows.Forms.ComboBox
        Me.cmbSucursal = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtFolio = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.ChkFiltroFechas = New System.Windows.Forms.CheckBox
        Me.dtFin = New System.Windows.Forms.DateTimePicker
        Me.dtInicio = New System.Windows.Forms.DateTimePicker
        Me.grbEstatus = New System.Windows.Forms.GroupBox
        Me.chkParEmitida = New System.Windows.Forms.CheckBox
        Me.chkEmitida = New System.Windows.Forms.CheckBox
        Me.chkCancelados = New System.Windows.Forms.CheckBox
        Me.chkVigentes = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dgvSolicitudes = New System.Windows.Forms.DataGridView
        Me.clmFolio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmPlaza = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmSucursal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEntregarA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEntregarEn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFechaAlta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmFolioOrdenCompra = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        Me.grbEstatus.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvSolicitudes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEstatus
        '
        Me.lblEstatus.Location = New System.Drawing.Point(248, 40)
        Me.lblEstatus.Visible = False
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(932, 29)
        Me.lblTitulo.Text = "BUSQUEDA DE SOLICITUD DE PRODUCTOS"
        '
        'tbrMenu
        '
        Me.tbrMenu.MostrarBorrar = False
        Me.tbrMenu.MostrarCancelar = False
        Me.tbrMenu.MostrarEditar = False
        Me.tbrMenu.MostrarGuardar = False
        Me.tbrMenu.MostrarImprimir = False
        Me.tbrMenu.MostrarNuevo = False
        Me.tbrMenu.Size = New System.Drawing.Size(50, 417)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Folio Solicitud:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Plaza:"
        '
        'cmbPlaza
        '
        Me.cmbPlaza.FormattingEnabled = True
        Me.cmbPlaza.Location = New System.Drawing.Point(137, 68)
        Me.cmbPlaza.Name = "cmbPlaza"
        Me.cmbPlaza.Size = New System.Drawing.Size(268, 21)
        Me.cmbPlaza.TabIndex = 5
        '
        'cmbSucursal
        '
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(137, 95)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(268, 21)
        Me.cmbSucursal.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Sucursal:"
        '
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(137, 42)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(100, 20)
        Me.txtFolio.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ChkFiltroFechas)
        Me.GroupBox1.Controls.Add(Me.dtFin)
        Me.GroupBox1.Controls.Add(Me.dtInicio)
        Me.GroupBox1.Location = New System.Drawing.Point(669, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(164, 81)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rango de Fechas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Final:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Inicial:"
        '
        'ChkFiltroFechas
        '
        Me.ChkFiltroFechas.AutoSize = True
        Me.ChkFiltroFechas.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ChkFiltroFechas.Location = New System.Drawing.Point(9, 1)
        Me.ChkFiltroFechas.Name = "ChkFiltroFechas"
        Me.ChkFiltroFechas.Size = New System.Drawing.Size(107, 17)
        Me.ChkFiltroFechas.TabIndex = 13
        Me.ChkFiltroFechas.Text = "Filtrar por Fechas"
        Me.ChkFiltroFechas.UseVisualStyleBackColor = True
        '
        'dtFin
        '
        Me.dtFin.Enabled = False
        Me.dtFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFin.Location = New System.Drawing.Point(49, 49)
        Me.dtFin.Name = "dtFin"
        Me.dtFin.Size = New System.Drawing.Size(87, 20)
        Me.dtFin.TabIndex = 3
        '
        'dtInicio
        '
        Me.dtInicio.Enabled = False
        Me.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtInicio.Location = New System.Drawing.Point(49, 23)
        Me.dtInicio.Name = "dtInicio"
        Me.dtInicio.Size = New System.Drawing.Size(87, 20)
        Me.dtInicio.TabIndex = 1
        '
        'grbEstatus
        '
        Me.grbEstatus.Controls.Add(Me.chkParEmitida)
        Me.grbEstatus.Controls.Add(Me.chkEmitida)
        Me.grbEstatus.Controls.Add(Me.chkCancelados)
        Me.grbEstatus.Controls.Add(Me.chkVigentes)
        Me.grbEstatus.Location = New System.Drawing.Point(411, 35)
        Me.grbEstatus.Name = "grbEstatus"
        Me.grbEstatus.Size = New System.Drawing.Size(252, 81)
        Me.grbEstatus.TabIndex = 9
        Me.grbEstatus.TabStop = False
        Me.grbEstatus.Text = "Estatus"
        '
        'chkParEmitida
        '
        Me.chkParEmitida.AutoSize = True
        Me.chkParEmitida.Location = New System.Drawing.Point(118, 47)
        Me.chkParEmitida.Name = "chkParEmitida"
        Me.chkParEmitida.Size = New System.Drawing.Size(105, 17)
        Me.chkParEmitida.TabIndex = 3
        Me.chkParEmitida.Text = "PAR. EMITIDAS"
        Me.chkParEmitida.UseVisualStyleBackColor = True
        '
        'chkEmitida
        '
        Me.chkEmitida.AutoSize = True
        Me.chkEmitida.Location = New System.Drawing.Point(118, 24)
        Me.chkEmitida.Name = "chkEmitida"
        Me.chkEmitida.Size = New System.Drawing.Size(77, 17)
        Me.chkEmitida.TabIndex = 2
        Me.chkEmitida.Text = "EMITIDAS"
        Me.chkEmitida.UseVisualStyleBackColor = True
        '
        'chkCancelados
        '
        Me.chkCancelados.AutoSize = True
        Me.chkCancelados.Location = New System.Drawing.Point(14, 47)
        Me.chkCancelados.Name = "chkCancelados"
        Me.chkCancelados.Size = New System.Drawing.Size(98, 17)
        Me.chkCancelados.TabIndex = 1
        Me.chkCancelados.Text = "CANCELADOS"
        Me.chkCancelados.UseVisualStyleBackColor = True
        '
        'chkVigentes
        '
        Me.chkVigentes.AutoSize = True
        Me.chkVigentes.Location = New System.Drawing.Point(14, 24)
        Me.chkVigentes.Name = "chkVigentes"
        Me.chkVigentes.Size = New System.Drawing.Size(80, 17)
        Me.chkVigentes.TabIndex = 0
        Me.chkVigentes.Text = "VIGENTES"
        Me.chkVigentes.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvSolicitudes)
        Me.GroupBox3.Location = New System.Drawing.Point(59, 122)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(911, 283)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lista de Solicitudes"
        '
        'dgvSolicitudes
        '
        Me.dgvSolicitudes.AllowUserToAddRows = False
        Me.dgvSolicitudes.AllowUserToDeleteRows = False
        Me.dgvSolicitudes.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSolicitudes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSolicitudes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmFolio, Me.ClmPlaza, Me.clmSucursal, Me.Producto, Me.clmEntregarA, Me.clmEntregarEn, Me.clmFechaAlta, Me.ClmFolioOrdenCompra, Me.clmEstatus, Me.clmObservaciones})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSolicitudes.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSolicitudes.Location = New System.Drawing.Point(6, 19)
        Me.dgvSolicitudes.Name = "dgvSolicitudes"
        Me.dgvSolicitudes.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSolicitudes.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSolicitudes.RowHeadersVisible = False
        Me.dgvSolicitudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSolicitudes.Size = New System.Drawing.Size(899, 258)
        Me.dgvSolicitudes.TabIndex = 0
        '
        'clmFolio
        '
        Me.clmFolio.DataPropertyName = "FolioSolicitud"
        Me.clmFolio.HeaderText = "Folio Solicitud"
        Me.clmFolio.Name = "clmFolio"
        Me.clmFolio.ReadOnly = True
        '
        'ClmPlaza
        '
        Me.ClmPlaza.DataPropertyName = "Plaza"
        Me.ClmPlaza.HeaderText = "Plaza"
        Me.ClmPlaza.Name = "ClmPlaza"
        Me.ClmPlaza.ReadOnly = True
        Me.ClmPlaza.Width = 200
        '
        'clmSucursal
        '
        Me.clmSucursal.DataPropertyName = "Sucursal"
        Me.clmSucursal.HeaderText = "Sucursal"
        Me.clmSucursal.Name = "clmSucursal"
        Me.clmSucursal.ReadOnly = True
        Me.clmSucursal.Width = 200
        '
        'Producto
        '
        Me.Producto.DataPropertyName = "Producto"
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        Me.Producto.Visible = False
        Me.Producto.Width = 200
        '
        'clmEntregarA
        '
        Me.clmEntregarA.DataPropertyName = "EntregarA"
        Me.clmEntregarA.HeaderText = "Entregar A"
        Me.clmEntregarA.Name = "clmEntregarA"
        Me.clmEntregarA.ReadOnly = True
        Me.clmEntregarA.Width = 200
        '
        'clmEntregarEn
        '
        Me.clmEntregarEn.DataPropertyName = "EntregarEn"
        Me.clmEntregarEn.HeaderText = "Entregar En"
        Me.clmEntregarEn.Name = "clmEntregarEn"
        Me.clmEntregarEn.ReadOnly = True
        Me.clmEntregarEn.Width = 200
        '
        'clmFechaAlta
        '
        Me.clmFechaAlta.DataPropertyName = "FechaSolicitud"
        Me.clmFechaAlta.HeaderText = "Fecha Alta"
        Me.clmFechaAlta.Name = "clmFechaAlta"
        Me.clmFechaAlta.ReadOnly = True
        '
        'ClmFolioOrdenCompra
        '
        Me.ClmFolioOrdenCompra.DataPropertyName = "FolioOrdenCompra"
        Me.ClmFolioOrdenCompra.HeaderText = "Folio O. C."
        Me.ClmFolioOrdenCompra.Name = "ClmFolioOrdenCompra"
        Me.ClmFolioOrdenCompra.ReadOnly = True
        '
        'clmEstatus
        '
        Me.clmEstatus.DataPropertyName = "DescripcionEstatus"
        Me.clmEstatus.HeaderText = "Estatus"
        Me.clmEstatus.Name = "clmEstatus"
        Me.clmEstatus.ReadOnly = True
        '
        'clmObservaciones
        '
        Me.clmObservaciones.DataPropertyName = "Observaciones"
        Me.clmObservaciones.HeaderText = "Observaciones"
        Me.clmObservaciones.Name = "clmObservaciones"
        Me.clmObservaciones.ReadOnly = True
        Me.clmObservaciones.Width = 200
        '
        'FrmBusquedaSolicitudProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 417)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.grbEstatus)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbSucursal)
        Me.Controls.Add(Me.cmbPlaza)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmBusquedaSolicitudProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de Solicitudes de Producto"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.cmbPlaza, 0)
        Me.Controls.SetChildIndex(Me.cmbSucursal, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.grbEstatus, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.lblEstatus, 0)
        Me.Controls.SetChildIndex(Me.txtFolio, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.tbrMenu, 0)
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grbEstatus.ResumeLayout(False)
        Me.grbEstatus.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvSolicitudes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbPlaza As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents grbEstatus As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvSolicitudes As System.Windows.Forms.DataGridView
    Friend WithEvents ChkFiltroFechas As System.Windows.Forms.CheckBox
    Friend WithEvents chkEmitida As System.Windows.Forms.CheckBox
    Friend WithEvents chkCancelados As System.Windows.Forms.CheckBox
    Friend WithEvents chkVigentes As System.Windows.Forms.CheckBox
    Friend WithEvents chkParEmitida As System.Windows.Forms.CheckBox
    Friend WithEvents clmFolio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmPlaza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSucursal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEntregarA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEntregarEn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaAlta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmFolioOrdenCompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmObservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
