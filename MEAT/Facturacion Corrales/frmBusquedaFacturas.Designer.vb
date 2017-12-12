<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaFacturas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dgvFacturasDetalle = New System.Windows.Forms.DataGridView
        Me.clmTipoGanado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCabezas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmKilos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPrecioxKilo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPrecioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmImporteDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ultdtpFechaFinal = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.ultdtpFechaInicial = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.chkCancelados = New System.Windows.Forms.CheckBox
        Me.chkVigentes = New System.Windows.Forms.CheckBox
        Me.txtFolio = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dgvFacturasCabecero = New System.Windows.Forms.DataGridView
        Me.clmNoFactura = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmImporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbClientes = New System.Windows.Forms.ComboBox
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvFacturasDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ultdtpFechaFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ultdtpFechaInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvFacturasCabecero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mtb
        '
        Me.mtb.ButtonSize = New System.Drawing.Size(50, 50)
        Me.mtb.Dock = System.Windows.Forms.DockStyle.Left
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
        Me.mtb.Location = New System.Drawing.Point(0, 0)
        Me.mtb.MostrarBorrar = True
        Me.mtb.MostrarBuscar = True
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = True
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 497)
        Me.mtb.TabIndex = 32
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(688, 32)
        Me.Label17.TabIndex = 33
        Me.Label17.Tag = "Busqueda de Facturas"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvFacturasDetalle)
        Me.GroupBox3.Location = New System.Drawing.Point(53, 291)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(670, 164)
        Me.GroupBox3.TabIndex = 62
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalle"
        '
        'dgvFacturasDetalle
        '
        Me.dgvFacturasDetalle.AllowUserToAddRows = False
        Me.dgvFacturasDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFacturasDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmTipoGanado, Me.clmCabezas, Me.clmKilos, Me.clmPrecioxKilo, Me.clmDescripcion, Me.clmCantidad, Me.clmPrecioUnitario, Me.clmImporteDetalle})
        Me.dgvFacturasDetalle.Location = New System.Drawing.Point(7, 19)
        Me.dgvFacturasDetalle.MultiSelect = False
        Me.dgvFacturasDetalle.Name = "dgvFacturasDetalle"
        Me.dgvFacturasDetalle.ReadOnly = True
        Me.dgvFacturasDetalle.RowHeadersVisible = False
        Me.dgvFacturasDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFacturasDetalle.Size = New System.Drawing.Size(659, 138)
        Me.dgvFacturasDetalle.TabIndex = 53
        '
        'clmTipoGanado
        '
        Me.clmTipoGanado.DataPropertyName = "TipoGanado"
        Me.clmTipoGanado.HeaderText = "Tipo de Ganado"
        Me.clmTipoGanado.Name = "clmTipoGanado"
        Me.clmTipoGanado.ReadOnly = True
        Me.clmTipoGanado.Width = 180
        '
        'clmCabezas
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.clmCabezas.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmCabezas.HeaderText = "Cabezas"
        Me.clmCabezas.Name = "clmCabezas"
        Me.clmCabezas.ReadOnly = True
        Me.clmCabezas.Width = 55
        '
        'clmKilos
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.clmKilos.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmKilos.HeaderText = "Kilos"
        Me.clmKilos.Name = "clmKilos"
        Me.clmKilos.ReadOnly = True
        '
        'clmPrecioxKilo
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.clmPrecioxKilo.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmPrecioxKilo.HeaderText = "Precio x Kilo"
        Me.clmPrecioxKilo.Name = "clmPrecioxKilo"
        Me.clmPrecioxKilo.ReadOnly = True
        '
        'clmDescripcion
        '
        Me.clmDescripcion.HeaderText = "Descripcion"
        Me.clmDescripcion.Name = "clmDescripcion"
        Me.clmDescripcion.ReadOnly = True
        '
        'clmCantidad
        '
        Me.clmCantidad.HeaderText = "Cantidad"
        Me.clmCantidad.Name = "clmCantidad"
        Me.clmCantidad.ReadOnly = True
        '
        'clmPrecioUnitario
        '
        Me.clmPrecioUnitario.HeaderText = "Precio"
        Me.clmPrecioUnitario.Name = "clmPrecioUnitario"
        Me.clmPrecioUnitario.ReadOnly = True
        '
        'clmImporteDetalle
        '
        Me.clmImporteDetalle.HeaderText = "Importe"
        Me.clmImporteDetalle.Name = "clmImporteDetalle"
        Me.clmImporteDetalle.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ultdtpFechaFinal)
        Me.GroupBox2.Controls.Add(Me.ultdtpFechaInicial)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(344, 35)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(183, 74)
        Me.GroupBox2.TabIndex = 61
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rango de Fechas"
        '
        'ultdtpFechaFinal
        '
        Me.ultdtpFechaFinal.Location = New System.Drawing.Point(82, 43)
        Me.ultdtpFechaFinal.Name = "ultdtpFechaFinal"
        Me.ultdtpFechaFinal.Size = New System.Drawing.Size(83, 21)
        Me.ultdtpFechaFinal.TabIndex = 53
        '
        'ultdtpFechaInicial
        '
        Me.ultdtpFechaInicial.Location = New System.Drawing.Point(82, 16)
        Me.ultdtpFechaInicial.Name = "ultdtpFechaInicial"
        Me.ultdtpFechaInicial.Size = New System.Drawing.Size(83, 21)
        Me.ultdtpFechaInicial.TabIndex = 52
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Fecha Final:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Fecha Inicial:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.chkCancelados)
        Me.GroupBox1.Controls.Add(Me.chkVigentes)
        Me.GroupBox1.Location = New System.Drawing.Point(543, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(180, 74)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Estatus"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(102, 40)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(74, 17)
        Me.CheckBox2.TabIndex = 3
        Me.CheckBox2.Text = "Abonadas"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(102, 20)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(71, 17)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "Pagadas "
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'chkCancelados
        '
        Me.chkCancelados.AutoSize = True
        Me.chkCancelados.Location = New System.Drawing.Point(15, 42)
        Me.chkCancelados.Name = "chkCancelados"
        Me.chkCancelados.Size = New System.Drawing.Size(82, 17)
        Me.chkCancelados.TabIndex = 1
        Me.chkCancelados.Text = "Canceladas"
        Me.chkCancelados.UseVisualStyleBackColor = True
        '
        'chkVigentes
        '
        Me.chkVigentes.AutoSize = True
        Me.chkVigentes.Location = New System.Drawing.Point(15, 19)
        Me.chkVigentes.Name = "chkVigentes"
        Me.chkVigentes.Size = New System.Drawing.Size(67, 17)
        Me.chkVigentes.TabIndex = 0
        Me.chkVigentes.Text = "Vigentes"
        Me.chkVigentes.UseVisualStyleBackColor = True
        '
        'txtFolio
        '
        Me.txtFolio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFolio.Location = New System.Drawing.Point(112, 50)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(100, 20)
        Me.txtFolio.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Factura :"
        '
        'dgvFacturasCabecero
        '
        Me.dgvFacturasCabecero.AllowUserToAddRows = False
        Me.dgvFacturasCabecero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFacturasCabecero.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmNoFactura, Me.clmFecha, Me.clmImporte, Me.clmCliente})
        Me.dgvFacturasCabecero.Location = New System.Drawing.Point(60, 115)
        Me.dgvFacturasCabecero.MultiSelect = False
        Me.dgvFacturasCabecero.Name = "dgvFacturasCabecero"
        Me.dgvFacturasCabecero.ReadOnly = True
        Me.dgvFacturasCabecero.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvFacturasCabecero.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvFacturasCabecero.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFacturasCabecero.Size = New System.Drawing.Size(658, 170)
        Me.dgvFacturasCabecero.TabIndex = 55
        '
        'clmNoFactura
        '
        Me.clmNoFactura.DataPropertyName = "FolFactura"
        Me.clmNoFactura.HeaderText = "Factura"
        Me.clmNoFactura.Name = "clmNoFactura"
        Me.clmNoFactura.ReadOnly = True
        '
        'clmFecha
        '
        Me.clmFecha.DataPropertyName = "FecFactura"
        Me.clmFecha.HeaderText = "Fecha "
        Me.clmFecha.Name = "clmFecha"
        Me.clmFecha.ReadOnly = True
        '
        'clmImporte
        '
        Me.clmImporte.DataPropertyName = "SubTotal"
        Me.clmImporte.HeaderText = "Importe"
        Me.clmImporte.Name = "clmImporte"
        Me.clmImporte.ReadOnly = True
        '
        'clmCliente
        '
        Me.clmCliente.DataPropertyName = "IdCliente"
        Me.clmCliente.HeaderText = "cliente"
        Me.clmCliente.Name = "clmCliente"
        Me.clmCliente.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Clientes :"
        '
        'cmbClientes
        '
        Me.cmbClientes.FormattingEnabled = True
        Me.cmbClientes.Location = New System.Drawing.Point(112, 73)
        Me.cmbClientes.Name = "cmbClientes"
        Me.cmbClientes.Size = New System.Drawing.Size(226, 21)
        Me.cmbClientes.TabIndex = 64
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(643, 462)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 66
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(562, 462)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 65
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'frmBusquedaFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 497)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.cmbClientes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvFacturasCabecero)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.Name = "frmBusquedaFacturas"
        Me.Text = "Busqueda de Facturas"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvFacturasDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ultdtpFechaFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ultdtpFechaInicial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvFacturasCabecero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvFacturasDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ultdtpFechaFinal As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents ultdtpFechaInicial As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCancelados As System.Windows.Forms.CheckBox
    Friend WithEvents chkVigentes As System.Windows.Forms.CheckBox
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvFacturasCabecero As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents cmbClientes As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents clmNoFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTipoGanado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCabezas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmKilos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPrecioxKilo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPrecioUnitario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmImporteDetalle As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
