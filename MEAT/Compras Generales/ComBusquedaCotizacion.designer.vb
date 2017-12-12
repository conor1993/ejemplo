<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComBusquedaCotizacion
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.rbtTodas = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbtCanceladas = New System.Windows.Forms.RadioButton
        Me.rbtActivaa = New System.Windows.Forms.RadioButton
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtFin = New System.Windows.Forms.DateTimePicker
        Me.dtInicio = New System.Windows.Forms.DateTimePicker
        Me.txtFolio = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbSucursal = New System.Windows.Forms.ComboBox
        Me.cmbPlaza = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbProveedor = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtPresupuesto = New System.Windows.Forms.TextBox
        Me.chkFechas = New System.Windows.Forms.CheckBox
        Me.clmFolio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFolioPresupuesto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmPlaza = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmSucursal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmimporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmDescuento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIva = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFechaAlta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Folio Cotizacion:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmFolio, Me.clmFolioPresupuesto, Me.clmProveedor, Me.ClmPlaza, Me.clmSucursal, Me.clmimporte, Me.clmDescuento, Me.clmSubtotal, Me.clmIva, Me.clmTotal, Me.clmObservaciones, Me.clmFechaAlta, Me.clmEstatus})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(899, 375)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Location = New System.Drawing.Point(59, 175)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(911, 400)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lista de Solicitudes"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(814, 592)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rbtTodas
        '
        Me.rbtTodas.AutoSize = True
        Me.rbtTodas.Checked = True
        Me.rbtTodas.Location = New System.Drawing.Point(6, 65)
        Me.rbtTodas.Name = "rbtTodas"
        Me.rbtTodas.Size = New System.Drawing.Size(62, 17)
        Me.rbtTodas.TabIndex = 2
        Me.rbtTodas.TabStop = True
        Me.rbtTodas.Text = "TODAS"
        Me.rbtTodas.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbtTodas)
        Me.GroupBox2.Controls.Add(Me.rbtCanceladas)
        Me.GroupBox2.Controls.Add(Me.rbtActivaa)
        Me.GroupBox2.Location = New System.Drawing.Point(659, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(114, 91)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estatus"
        '
        'rbtCanceladas
        '
        Me.rbtCanceladas.AutoSize = True
        Me.rbtCanceladas.Location = New System.Drawing.Point(6, 42)
        Me.rbtCanceladas.Name = "rbtCanceladas"
        Me.rbtCanceladas.Size = New System.Drawing.Size(96, 17)
        Me.rbtCanceladas.TabIndex = 1
        Me.rbtCanceladas.Text = "CANCELADAS"
        Me.rbtCanceladas.UseVisualStyleBackColor = True
        '
        'rbtActivaa
        '
        Me.rbtActivaa.AutoSize = True
        Me.rbtActivaa.Location = New System.Drawing.Point(6, 19)
        Me.rbtActivaa.Name = "rbtActivaa"
        Me.rbtActivaa.Size = New System.Drawing.Size(70, 17)
        Me.rbtActivaa.TabIndex = 0
        Me.rbtActivaa.Text = "ACTIVAS"
        Me.rbtActivaa.UseVisualStyleBackColor = True
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
        Me.MEAToolBar1.MostrarBuscar = True
        Me.MEAToolBar1.MostrarCancelar = False
        Me.MEAToolBar1.MostrarEditar = False
        Me.MEAToolBar1.MostrarGuardar = False
        Me.MEAToolBar1.MostrarImprimir = False
        Me.MEAToolBar1.MostrarLimpiar = True
        Me.MEAToolBar1.MostrarNuevo = False
        Me.MEAToolBar1.MostrarSalir = True
        Me.MEAToolBar1.Name = "MEAToolBar1"
        Me.MEAToolBar1.ShowToolTips = True
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 625)
        Me.MEAToolBar1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dtFin)
        Me.GroupBox1.Controls.Add(Me.dtInicio)
        Me.GroupBox1.Location = New System.Drawing.Point(445, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(179, 79)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rango de Fechas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Final:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Inicial:"
        '
        'dtFin
        '
        Me.dtFin.Enabled = False
        Me.dtFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFin.Location = New System.Drawing.Point(49, 45)
        Me.dtFin.Name = "dtFin"
        Me.dtFin.Size = New System.Drawing.Size(124, 20)
        Me.dtFin.TabIndex = 3
        '
        'dtInicio
        '
        Me.dtInicio.Enabled = False
        Me.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtInicio.Location = New System.Drawing.Point(49, 19)
        Me.dtInicio.Name = "dtInicio"
        Me.dtInicio.Size = New System.Drawing.Size(124, 20)
        Me.dtInicio.TabIndex = 1
        '
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(156, 42)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(100, 20)
        Me.txtFolio.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Sucursal:"
        '
        'cmbSucursal
        '
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Location = New System.Drawing.Point(156, 121)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(269, 21)
        Me.cmbSucursal.TabIndex = 9
        '
        'cmbPlaza
        '
        Me.cmbPlaza.FormattingEnabled = True
        Me.cmbPlaza.Location = New System.Drawing.Point(156, 94)
        Me.cmbPlaza.Name = "cmbPlaza"
        Me.cmbPlaza.Size = New System.Drawing.Size(269, 21)
        Me.cmbPlaza.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Plaza:"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(895, 592)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(50, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(930, 29)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "BUSQUEDA DE COTIZACIONES DE PRODUCTOS"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(56, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Propveedor:"
        '
        'cmbProveedor
        '
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(156, 148)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(269, 21)
        Me.cmbProveedor.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(56, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Folio Presupuesto:"
        '
        'txtPresupuesto
        '
        Me.txtPresupuesto.Location = New System.Drawing.Point(156, 68)
        Me.txtPresupuesto.Name = "txtPresupuesto"
        Me.txtPresupuesto.Size = New System.Drawing.Size(100, 20)
        Me.txtPresupuesto.TabIndex = 5
        '
        'chkFechas
        '
        Me.chkFechas.AutoSize = True
        Me.chkFechas.Location = New System.Drawing.Point(445, 56)
        Me.chkFechas.Name = "chkFechas"
        Me.chkFechas.Size = New System.Drawing.Size(111, 17)
        Me.chkFechas.TabIndex = 17
        Me.chkFechas.Text = "Rango de Fechas"
        Me.chkFechas.UseVisualStyleBackColor = True
        '
        'clmFolio
        '
        Me.clmFolio.DataPropertyName = "Folio"
        Me.clmFolio.HeaderText = "Folio Cotización"
        Me.clmFolio.Name = "clmFolio"
        Me.clmFolio.ReadOnly = True
        '
        'clmFolioPresupuesto
        '
        Me.clmFolioPresupuesto.DataPropertyName = "PresupuestoId"
        Me.clmFolioPresupuesto.HeaderText = "Folio Presupuesto"
        Me.clmFolioPresupuesto.Name = "clmFolioPresupuesto"
        Me.clmFolioPresupuesto.ReadOnly = True
        '
        'clmProveedor
        '
        Me.clmProveedor.DataPropertyName = "Proveedor"
        Me.clmProveedor.HeaderText = "Proveedor"
        Me.clmProveedor.Name = "clmProveedor"
        Me.clmProveedor.ReadOnly = True
        Me.clmProveedor.Width = 200
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
        'clmimporte
        '
        Me.clmimporte.DataPropertyName = "Importe"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.clmimporte.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmimporte.HeaderText = "Importe"
        Me.clmimporte.Name = "clmimporte"
        Me.clmimporte.ReadOnly = True
        '
        'clmDescuento
        '
        Me.clmDescuento.DataPropertyName = "Descuento"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.clmDescuento.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmDescuento.HeaderText = "Descuento"
        Me.clmDescuento.Name = "clmDescuento"
        Me.clmDescuento.ReadOnly = True
        '
        'clmSubtotal
        '
        Me.clmSubtotal.DataPropertyName = "SubTotal"
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.clmSubtotal.DefaultCellStyle = DataGridViewCellStyle3
        Me.clmSubtotal.HeaderText = "Sub Total"
        Me.clmSubtotal.Name = "clmSubtotal"
        Me.clmSubtotal.ReadOnly = True
        '
        'clmIva
        '
        Me.clmIva.DataPropertyName = "Iva"
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.clmIva.DefaultCellStyle = DataGridViewCellStyle4
        Me.clmIva.HeaderText = "IVA"
        Me.clmIva.Name = "clmIva"
        Me.clmIva.ReadOnly = True
        '
        'clmTotal
        '
        Me.clmTotal.DataPropertyName = "Total"
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.clmTotal.DefaultCellStyle = DataGridViewCellStyle5
        Me.clmTotal.HeaderText = "Total"
        Me.clmTotal.Name = "clmTotal"
        Me.clmTotal.ReadOnly = True
        '
        'clmObservaciones
        '
        Me.clmObservaciones.DataPropertyName = "Observaciones"
        Me.clmObservaciones.HeaderText = "Observaciones"
        Me.clmObservaciones.Name = "clmObservaciones"
        Me.clmObservaciones.ReadOnly = True
        Me.clmObservaciones.Width = 200
        '
        'clmFechaAlta
        '
        Me.clmFechaAlta.DataPropertyName = "FechaAlta"
        Me.clmFechaAlta.HeaderText = "Fecha Alta"
        Me.clmFechaAlta.Name = "clmFechaAlta"
        Me.clmFechaAlta.ReadOnly = True
        '
        'clmEstatus
        '
        Me.clmEstatus.DataPropertyName = "EstatusStr"
        Me.clmEstatus.HeaderText = "Estatus"
        Me.clmEstatus.Name = "clmEstatus"
        Me.clmEstatus.ReadOnly = True
        '
        'ComBusquedaCotizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 625)
        Me.Controls.Add(Me.chkFechas)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPresupuesto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbProveedor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbSucursal)
        Me.Controls.Add(Me.cmbPlaza)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Name = "ComBusquedaCotizacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de Cotizaciones"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents rbtTodas As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtCanceladas As System.Windows.Forms.RadioButton
    Friend WithEvents rbtActivaa As System.Windows.Forms.RadioButton
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPlaza As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPresupuesto As System.Windows.Forms.TextBox
    Friend WithEvents chkFechas As System.Windows.Forms.CheckBox
    Friend WithEvents clmFolio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFolioPresupuesto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmPlaza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSucursal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmimporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDescuento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSubtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmObservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaAlta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
