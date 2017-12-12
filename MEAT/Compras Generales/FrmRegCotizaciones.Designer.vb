<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegCotizaciones

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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCantidad = New System.Windows.Forms.TextBox
        Me.dgvProductosSolicitados = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.txtIVA = New System.Windows.Forms.TextBox
        Me.txtSubTotal = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.dtpFechaCotizacion = New System.Windows.Forms.DateTimePicker
        Me.txtCapturista = New System.Windows.Forms.TextBox
        Me.txtObservaciones = New System.Windows.Forms.TextBox
        Me.cmbSucursal = New System.Windows.Forms.ComboBox
        Me.cmbPlaza = New System.Windows.Forms.ComboBox
        Me.GrpImportesPesos = New System.Windows.Forms.GroupBox
        Me.txtTotalPesos = New System.Windows.Forms.TextBox
        Me.txtIvaPesos = New System.Windows.Forms.TextBox
        Me.txtSubTotalPesos = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.dtpFechaVigencia = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtFolio = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtPlazaCodigo = New System.Windows.Forms.TextBox
        Me.txtSucursalCodigo = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.dgvProveedores = New System.Windows.Forms.DataGridView
        Me.clmProProveedor = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.clmProDiasCredito = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFechaCotizacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFechaVigencia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmProImporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmProDescuento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmProSubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmProIva = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmProTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmProObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvProductosSolicitados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GrpImportesPesos.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEstatus
        '
        Me.lblEstatus.Location = New System.Drawing.Point(817, 30)
        '
        'lblTitulo
        '
        Me.lblTitulo.Size = New System.Drawing.Size(1105, 29)
        Me.lblTitulo.Text = "REGISTRO DE COTIZACIONES DE COMPRAS"
        '
        'tbrMenu
        '
        Me.tbrMenu.Size = New System.Drawing.Size(50, 719)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Plaza:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Sucursal:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(274, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Fecha de Cotizacion:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(55, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Capturista:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(55, 143)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Observaciones:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.dgvProductosSolicitados)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 391)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1087, 209)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de Cotizacion"
        '
        'txtCantidad
        '
        Me.txtCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCantidad.Location = New System.Drawing.Point(306, 211)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.ReadOnly = True
        Me.txtCantidad.Size = New System.Drawing.Size(105, 20)
        Me.txtCantidad.TabIndex = 1
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvProductosSolicitados
        '
        Me.dgvProductosSolicitados.AllowUserToAddRows = False
        Me.dgvProductosSolicitados.AllowUserToDeleteRows = False
        Me.dgvProductosSolicitados.AllowUserToResizeRows = False
        Me.dgvProductosSolicitados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductosSolicitados.Location = New System.Drawing.Point(6, 22)
        Me.dgvProductosSolicitados.Name = "dgvProductosSolicitados"
        Me.dgvProductosSolicitados.RowHeadersVisible = False
        Me.dgvProductosSolicitados.Size = New System.Drawing.Size(1075, 183)
        Me.dgvProductosSolicitados.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTotal)
        Me.GroupBox2.Controls.Add(Me.txtIVA)
        Me.GroupBox2.Controls.Add(Me.txtSubTotal)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Location = New System.Drawing.Point(964, 607)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(179, 100)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Importes"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(68, 72)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(105, 20)
        Me.txtTotal.TabIndex = 5
        Me.txtTotal.TabStop = False
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIVA
        '
        Me.txtIVA.Location = New System.Drawing.Point(68, 46)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.ReadOnly = True
        Me.txtIVA.Size = New System.Drawing.Size(105, 20)
        Me.txtIVA.TabIndex = 3
        Me.txtIVA.TabStop = False
        Me.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Location = New System.Drawing.Point(68, 20)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(105, 20)
        Me.txtSubTotal.TabIndex = 1
        Me.txtSubTotal.TabStop = False
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 76)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(34, 13)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Total:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 50)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(27, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "IVA:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Sub-Total:"
        '
        'dtpFechaCotizacion
        '
        Me.dtpFechaCotizacion.Enabled = False
        Me.dtpFechaCotizacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaCotizacion.Location = New System.Drawing.Point(387, 34)
        Me.dtpFechaCotizacion.Name = "dtpFechaCotizacion"
        Me.dtpFechaCotizacion.Size = New System.Drawing.Size(87, 20)
        Me.dtpFechaCotizacion.TabIndex = 0
        '
        'txtCapturista
        '
        Me.txtCapturista.Location = New System.Drawing.Point(168, 61)
        Me.txtCapturista.Name = "txtCapturista"
        Me.txtCapturista.ReadOnly = True
        Me.txtCapturista.Size = New System.Drawing.Size(281, 20)
        Me.txtCapturista.TabIndex = 3
        Me.txtCapturista.TabStop = False
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Location = New System.Drawing.Point(168, 141)
        Me.txtObservaciones.MaxLength = 250
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(491, 63)
        Me.txtObservaciones.TabIndex = 10
        '
        'cmbSucursal
        '
        Me.cmbSucursal.DisplayMember = "Descripcion"
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(235, 114)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(214, 21)
        Me.cmbSucursal.TabIndex = 6
        Me.cmbSucursal.ValueMember = "Codigo"
        '
        'cmbPlaza
        '
        Me.cmbPlaza.DisplayMember = "Descripcion"
        Me.cmbPlaza.FormattingEnabled = True
        Me.cmbPlaza.Location = New System.Drawing.Point(235, 87)
        Me.cmbPlaza.Name = "cmbPlaza"
        Me.cmbPlaza.Size = New System.Drawing.Size(214, 21)
        Me.cmbPlaza.TabIndex = 3
        Me.cmbPlaza.ValueMember = "Codigo"
        '
        'GrpImportesPesos
        '
        Me.GrpImportesPesos.Controls.Add(Me.txtTotalPesos)
        Me.GrpImportesPesos.Controls.Add(Me.txtIvaPesos)
        Me.GrpImportesPesos.Controls.Add(Me.txtSubTotalPesos)
        Me.GrpImportesPesos.Controls.Add(Me.Label16)
        Me.GrpImportesPesos.Controls.Add(Me.Label17)
        Me.GrpImportesPesos.Controls.Add(Me.Label18)
        Me.GrpImportesPesos.Location = New System.Drawing.Point(764, 607)
        Me.GrpImportesPesos.Name = "GrpImportesPesos"
        Me.GrpImportesPesos.Size = New System.Drawing.Size(179, 100)
        Me.GrpImportesPesos.TabIndex = 26
        Me.GrpImportesPesos.TabStop = False
        Me.GrpImportesPesos.Text = "Importes en Pesos"
        '
        'txtTotalPesos
        '
        Me.txtTotalPesos.Location = New System.Drawing.Point(68, 72)
        Me.txtTotalPesos.Name = "txtTotalPesos"
        Me.txtTotalPesos.ReadOnly = True
        Me.txtTotalPesos.Size = New System.Drawing.Size(105, 20)
        Me.txtTotalPesos.TabIndex = 5
        Me.txtTotalPesos.TabStop = False
        Me.txtTotalPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIvaPesos
        '
        Me.txtIvaPesos.Location = New System.Drawing.Point(68, 46)
        Me.txtIvaPesos.Name = "txtIvaPesos"
        Me.txtIvaPesos.ReadOnly = True
        Me.txtIvaPesos.Size = New System.Drawing.Size(105, 20)
        Me.txtIvaPesos.TabIndex = 3
        Me.txtIvaPesos.TabStop = False
        Me.txtIvaPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSubTotalPesos
        '
        Me.txtSubTotalPesos.Location = New System.Drawing.Point(68, 20)
        Me.txtSubTotalPesos.Name = "txtSubTotalPesos"
        Me.txtSubTotalPesos.ReadOnly = True
        Me.txtSubTotalPesos.Size = New System.Drawing.Size(105, 20)
        Me.txtSubTotalPesos.TabIndex = 1
        Me.txtSubTotalPesos.TabStop = False
        Me.txtSubTotalPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 76)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(34, 13)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Total:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 50)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(27, 13)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "IVA:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 24)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Sub-Total:"
        '
        'dtpFechaVigencia
        '
        Me.dtpFechaVigencia.Enabled = False
        Me.dtpFechaVigencia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaVigencia.Location = New System.Drawing.Point(537, 34)
        Me.dtpFechaVigencia.Name = "dtpFechaVigencia"
        Me.dtpFechaVigencia.Size = New System.Drawing.Size(88, 20)
        Me.dtpFechaVigencia.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(480, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Vigencia:"
        '
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(168, 35)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.ReadOnly = True
        Me.txtFolio.Size = New System.Drawing.Size(100, 20)
        Me.txtFolio.TabIndex = 0
        Me.txtFolio.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(55, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Folio Cotización:"
        '
        'txtPlazaCodigo
        '
        Me.txtPlazaCodigo.Location = New System.Drawing.Point(168, 87)
        Me.txtPlazaCodigo.Name = "txtPlazaCodigo"
        Me.txtPlazaCodigo.Size = New System.Drawing.Size(61, 20)
        Me.txtPlazaCodigo.TabIndex = 2
        '
        'txtSucursalCodigo
        '
        Me.txtSucursalCodigo.Location = New System.Drawing.Point(168, 114)
        Me.txtSucursalCodigo.Name = "txtSucursalCodigo"
        Me.txtSucursalCodigo.Size = New System.Drawing.Size(61, 20)
        Me.txtSucursalCodigo.TabIndex = 5
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgvProveedores)
        Me.GroupBox4.Location = New System.Drawing.Point(56, 210)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1087, 175)
        Me.GroupBox4.TabIndex = 67
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Proveedores"
        '
        'dgvProveedores
        '
        Me.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmProProveedor, Me.clmProDiasCredito, Me.clmFechaCotizacion, Me.clmFechaVigencia, Me.clmEstatus, Me.clmProImporte, Me.clmProDescuento, Me.clmProSubTotal, Me.clmProIva, Me.clmProTotal, Me.clmProObservaciones})
        Me.dgvProveedores.Location = New System.Drawing.Point(6, 19)
        Me.dgvProveedores.Name = "dgvProveedores"
        Me.dgvProveedores.Size = New System.Drawing.Size(1075, 150)
        Me.dgvProveedores.TabIndex = 0
        '
        'clmProProveedor
        '
        Me.clmProProveedor.DataPropertyName = "IdProveedor"
        Me.clmProProveedor.HeaderText = "Proveedor"
        Me.clmProProveedor.Name = "clmProProveedor"
        Me.clmProProveedor.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmProProveedor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clmProProveedor.Width = 170
        '
        'clmProDiasCredito
        '
        Me.clmProDiasCredito.DataPropertyName = "DiasCredito"
        DataGridViewCellStyle9.Format = "N0"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.clmProDiasCredito.DefaultCellStyle = DataGridViewCellStyle9
        Me.clmProDiasCredito.HeaderText = "Dias Credito"
        Me.clmProDiasCredito.Name = "clmProDiasCredito"
        Me.clmProDiasCredito.Width = 50
        '
        'clmFechaCotizacion
        '
        Me.clmFechaCotizacion.DataPropertyName = "FechaCotizacion"
        DataGridViewCellStyle10.Format = "d"
        Me.clmFechaCotizacion.DefaultCellStyle = DataGridViewCellStyle10
        Me.clmFechaCotizacion.HeaderText = "Fecha Cotizacion"
        Me.clmFechaCotizacion.Name = "clmFechaCotizacion"
        Me.clmFechaCotizacion.Width = 80
        '
        'clmFechaVigencia
        '
        Me.clmFechaVigencia.DataPropertyName = "FechaVigencia"
        DataGridViewCellStyle11.Format = "d"
        Me.clmFechaVigencia.DefaultCellStyle = DataGridViewCellStyle11
        Me.clmFechaVigencia.HeaderText = "Fecha Vigencia"
        Me.clmFechaVigencia.Name = "clmFechaVigencia"
        Me.clmFechaVigencia.Width = 80
        '
        'clmEstatus
        '
        Me.clmEstatus.DataPropertyName = "EstatusDescripcion"
        Me.clmEstatus.HeaderText = "Estatus"
        Me.clmEstatus.Name = "clmEstatus"
        '
        'clmProImporte
        '
        Me.clmProImporte.DataPropertyName = "Importe"
        DataGridViewCellStyle12.Format = "C"
        Me.clmProImporte.DefaultCellStyle = DataGridViewCellStyle12
        Me.clmProImporte.HeaderText = "Importe"
        Me.clmProImporte.Name = "clmProImporte"
        Me.clmProImporte.Width = 80
        '
        'clmProDescuento
        '
        Me.clmProDescuento.DataPropertyName = "Descuento"
        DataGridViewCellStyle13.Format = "C"
        Me.clmProDescuento.DefaultCellStyle = DataGridViewCellStyle13
        Me.clmProDescuento.HeaderText = "Descuento"
        Me.clmProDescuento.Name = "clmProDescuento"
        Me.clmProDescuento.Width = 60
        '
        'clmProSubTotal
        '
        Me.clmProSubTotal.DataPropertyName = "SubTotal"
        DataGridViewCellStyle14.Format = "C"
        Me.clmProSubTotal.DefaultCellStyle = DataGridViewCellStyle14
        Me.clmProSubTotal.HeaderText = "SubTotal"
        Me.clmProSubTotal.Name = "clmProSubTotal"
        Me.clmProSubTotal.Width = 80
        '
        'clmProIva
        '
        Me.clmProIva.DataPropertyName = "IVA"
        DataGridViewCellStyle15.Format = "C"
        Me.clmProIva.DefaultCellStyle = DataGridViewCellStyle15
        Me.clmProIva.HeaderText = "Iva"
        Me.clmProIva.Name = "clmProIva"
        Me.clmProIva.Width = 60
        '
        'clmProTotal
        '
        Me.clmProTotal.DataPropertyName = "Total"
        DataGridViewCellStyle16.Format = "C"
        Me.clmProTotal.DefaultCellStyle = DataGridViewCellStyle16
        Me.clmProTotal.HeaderText = "Total"
        Me.clmProTotal.Name = "clmProTotal"
        Me.clmProTotal.Width = 80
        '
        'clmProObservaciones
        '
        Me.clmProObservaciones.DataPropertyName = "Observaciones"
        Me.clmProObservaciones.HeaderText = "Observaciones"
        Me.clmProObservaciones.Name = "clmProObservaciones"
        Me.clmProObservaciones.Width = 170
        '
        'FrmRegCotizaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1155, 719)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.txtSucursalCodigo)
        Me.Controls.Add(Me.txtPlazaCodigo)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GrpImportesPesos)
        Me.Controls.Add(Me.dtpFechaVigencia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.txtCapturista)
        Me.Controls.Add(Me.cmbSucursal)
        Me.Controls.Add(Me.cmbPlaza)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dtpFechaCotizacion)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "FrmRegCotizaciones"
        Me.Text = "REGISTRO DE COTIZACIONES DE COMPRAS"
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaCotizacion, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.cmbPlaza, 0)
        Me.Controls.SetChildIndex(Me.cmbSucursal, 0)
        Me.Controls.SetChildIndex(Me.txtCapturista, 0)
        Me.Controls.SetChildIndex(Me.txtObservaciones, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaVigencia, 0)
        Me.Controls.SetChildIndex(Me.GrpImportesPesos, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.txtFolio, 0)
        Me.Controls.SetChildIndex(Me.lblEstatus, 0)
        Me.Controls.SetChildIndex(Me.tbrMenu, 0)
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.txtPlazaCodigo, 0)
        Me.Controls.SetChildIndex(Me.txtSucursalCodigo, 0)
        Me.Controls.SetChildIndex(Me.GroupBox4, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvProductosSolicitados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GrpImportesPesos.ResumeLayout(False)
        Me.GrpImportesPesos.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvProductosSolicitados As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtIVA As System.Windows.Forms.TextBox
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbPlaza As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaCotizacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCapturista As System.Windows.Forms.TextBox
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents GrpImportesPesos As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotalPesos As System.Windows.Forms.TextBox
    Friend WithEvents txtIvaPesos As System.Windows.Forms.TextBox
    Friend WithEvents txtSubTotalPesos As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaVigencia As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPlazaCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtSucursalCodigo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvProveedores As System.Windows.Forms.DataGridView
    Friend WithEvents clmProProveedor As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents clmProDiasCredito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaCotizacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaVigencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmProImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmProDescuento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmProSubTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmProIva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmProTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmProObservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
