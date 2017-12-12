<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConFacturas
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
        Me.DgvFacturas = New System.Windows.Forms.DataGridView
        Me.Factura = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdCLiente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaFactura = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaCaptura = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaVencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Contado = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Credito = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IVA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Estatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RFC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Poliza = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdFolioEmbarque = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Domicilio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNoFactura = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmbCliente = New System.Windows.Forms.ComboBox
        Me.ChkFechas = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DtpFechaFin = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.DtpFechaIni = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RbtnTodas = New System.Windows.Forms.RadioButton
        Me.RbtnAbonadas = New System.Windows.Forms.RadioButton
        Me.RbtnPagadas = New System.Windows.Forms.RadioButton
        Me.RbtnCanceladas = New System.Windows.Forms.RadioButton
        Me.RbtVigentes = New System.Windows.Forms.RadioButton
        Me.BtnAceptar = New System.Windows.Forms.Button
        Me.BrnCancelar = New System.Windows.Forms.Button
        CType(Me.DgvFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvFacturas
        '
        Me.DgvFacturas.AllowUserToAddRows = False
        Me.DgvFacturas.AllowUserToDeleteRows = False
        Me.DgvFacturas.AllowUserToResizeRows = False
        Me.DgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Factura, Me.IdCLiente, Me.Cliente, Me.FechaFactura, Me.FechaCaptura, Me.FechaVencimiento, Me.Contado, Me.Credito, Me.SubTotal, Me.IVA, Me.Total, Me.Estatus, Me.Observaciones, Me.RFC, Me.Poliza, Me.IdFolioEmbarque, Me.Domicilio})
        Me.DgvFacturas.Location = New System.Drawing.Point(54, 156)
        Me.DgvFacturas.Name = "DgvFacturas"
        Me.DgvFacturas.ReadOnly = True
        Me.DgvFacturas.RowHeadersVisible = False
        Me.DgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvFacturas.Size = New System.Drawing.Size(720, 269)
        Me.DgvFacturas.TabIndex = 12
        '
        'Factura
        '
        Me.Factura.DataPropertyName = "NoFactura"
        Me.Factura.HeaderText = "Factura"
        Me.Factura.Name = "Factura"
        Me.Factura.ReadOnly = True
        '
        'IdCLiente
        '
        Me.IdCLiente.DataPropertyName = "IdCliente"
        Me.IdCLiente.HeaderText = "Codigo"
        Me.IdCLiente.Name = "IdCLiente"
        Me.IdCLiente.ReadOnly = True
        Me.IdCLiente.Width = 80
        '
        'Cliente
        '
        Me.Cliente.DataPropertyName = "Nombre"
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        Me.Cliente.Width = 200
        '
        'FechaFactura
        '
        Me.FechaFactura.DataPropertyName = "FechaFactura"
        Me.FechaFactura.HeaderText = "Fecha"
        Me.FechaFactura.Name = "FechaFactura"
        Me.FechaFactura.ReadOnly = True
        '
        'FechaCaptura
        '
        Me.FechaCaptura.DataPropertyName = "FechaCaptura"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.FechaCaptura.DefaultCellStyle = DataGridViewCellStyle1
        Me.FechaCaptura.HeaderText = "FechaCaptura"
        Me.FechaCaptura.Name = "FechaCaptura"
        Me.FechaCaptura.ReadOnly = True
        Me.FechaCaptura.Width = 70
        '
        'FechaVencimiento
        '
        Me.FechaVencimiento.DataPropertyName = "FechaVencimiento"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.FechaVencimiento.DefaultCellStyle = DataGridViewCellStyle2
        Me.FechaVencimiento.HeaderText = "FechaVencimiento"
        Me.FechaVencimiento.Name = "FechaVencimiento"
        Me.FechaVencimiento.ReadOnly = True
        Me.FechaVencimiento.Width = 70
        '
        'Contado
        '
        Me.Contado.DataPropertyName = "Contado"
        Me.Contado.HeaderText = "Contado"
        Me.Contado.Name = "Contado"
        Me.Contado.ReadOnly = True
        Me.Contado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Contado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Contado.Width = 70
        '
        'Credito
        '
        Me.Credito.DataPropertyName = "Credito"
        Me.Credito.HeaderText = "Credito"
        Me.Credito.Name = "Credito"
        Me.Credito.ReadOnly = True
        Me.Credito.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Credito.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'SubTotal
        '
        Me.SubTotal.DataPropertyName = "SubTotal"
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.SubTotal.DefaultCellStyle = DataGridViewCellStyle3
        Me.SubTotal.HeaderText = "SubTotal"
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.ReadOnly = True
        '
        'IVA
        '
        Me.IVA.DataPropertyName = "Iva"
        Me.IVA.HeaderText = "IVA"
        Me.IVA.Name = "IVA"
        Me.IVA.ReadOnly = True
        '
        'Total
        '
        Me.Total.DataPropertyName = "Total"
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Total.DefaultCellStyle = DataGridViewCellStyle4
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'Estatus
        '
        Me.Estatus.DataPropertyName = "EstatusCad"
        Me.Estatus.HeaderText = "Estatus"
        Me.Estatus.Name = "Estatus"
        Me.Estatus.ReadOnly = True
        '
        'Observaciones
        '
        Me.Observaciones.DataPropertyName = "Observaciones"
        Me.Observaciones.HeaderText = "Observaciones"
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.ReadOnly = True
        '
        'RFC
        '
        Me.RFC.DataPropertyName = "RFC"
        Me.RFC.HeaderText = "RFC"
        Me.RFC.Name = "RFC"
        Me.RFC.ReadOnly = True
        '
        'Poliza
        '
        Me.Poliza.DataPropertyName = "IdPoliza"
        Me.Poliza.HeaderText = "Poliza"
        Me.Poliza.Name = "Poliza"
        Me.Poliza.ReadOnly = True
        '
        'IdFolioEmbarque
        '
        Me.IdFolioEmbarque.DataPropertyName = "IdFolioEmbarque"
        Me.IdFolioEmbarque.HeaderText = "IdFolioEmbarque"
        Me.IdFolioEmbarque.Name = "IdFolioEmbarque"
        Me.IdFolioEmbarque.ReadOnly = True
        '
        'Domicilio
        '
        Me.Domicilio.DataPropertyName = "Domicilio"
        Me.Domicilio.HeaderText = "Domicilio"
        Me.Domicilio.Name = "Domicilio"
        Me.Domicilio.ReadOnly = True
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
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 480)
        Me.MEAToolBar1.TabIndex = 31
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(741, 32)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "CONSULTA DE FACTURAS"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "No. Factura:"
        '
        'txtNoFactura
        '
        Me.txtNoFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNoFactura.Location = New System.Drawing.Point(133, 46)
        Me.txtNoFactura.Name = "txtNoFactura"
        Me.txtNoFactura.Size = New System.Drawing.Size(106, 20)
        Me.txtNoFactura.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Cliente:"
        '
        'CmbCliente
        '
        Me.CmbCliente.FormattingEnabled = True
        Me.CmbCliente.Location = New System.Drawing.Point(133, 72)
        Me.CmbCliente.Name = "CmbCliente"
        Me.CmbCliente.Size = New System.Drawing.Size(309, 21)
        Me.CmbCliente.TabIndex = 1
        '
        'ChkFechas
        '
        Me.ChkFechas.AutoSize = True
        Me.ChkFechas.Location = New System.Drawing.Point(568, 45)
        Me.ChkFechas.Name = "ChkFechas"
        Me.ChkFechas.Size = New System.Drawing.Size(155, 17)
        Me.ChkFechas.TabIndex = 8
        Me.ChkFechas.Text = "Fitrar por Rango de Fechas"
        Me.ChkFechas.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DtpFechaFin)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DtpFechaIni)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(568, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(206, 72)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rango de Fechas"
        '
        'DtpFechaFin
        '
        Me.DtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaFin.Location = New System.Drawing.Point(92, 45)
        Me.DtpFechaFin.Name = "DtpFechaFin"
        Me.DtpFechaFin.Size = New System.Drawing.Size(93, 20)
        Me.DtpFechaFin.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Fecha Final:"
        '
        'DtpFechaIni
        '
        Me.DtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaIni.Location = New System.Drawing.Point(92, 19)
        Me.DtpFechaIni.Name = "DtpFechaIni"
        Me.DtpFechaIni.Size = New System.Drawing.Size(93, 20)
        Me.DtpFechaIni.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Fecha Inicial:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RbtnTodas)
        Me.GroupBox2.Controls.Add(Me.RbtnAbonadas)
        Me.GroupBox2.Controls.Add(Me.RbtnPagadas)
        Me.GroupBox2.Controls.Add(Me.RbtnCanceladas)
        Me.GroupBox2.Controls.Add(Me.RbtVigentes)
        Me.GroupBox2.Location = New System.Drawing.Point(54, 99)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(495, 41)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estatus"
        '
        'RbtnTodas
        '
        Me.RbtnTodas.AutoSize = True
        Me.RbtnTodas.Location = New System.Drawing.Point(413, 14)
        Me.RbtnTodas.Name = "RbtnTodas"
        Me.RbtnTodas.Size = New System.Drawing.Size(62, 17)
        Me.RbtnTodas.TabIndex = 7
        Me.RbtnTodas.TabStop = True
        Me.RbtnTodas.Text = "TODAS"
        Me.RbtnTodas.UseVisualStyleBackColor = True
        '
        'RbtnAbonadas
        '
        Me.RbtnAbonadas.AutoSize = True
        Me.RbtnAbonadas.Location = New System.Drawing.Point(313, 14)
        Me.RbtnAbonadas.Name = "RbtnAbonadas"
        Me.RbtnAbonadas.Size = New System.Drawing.Size(84, 17)
        Me.RbtnAbonadas.TabIndex = 6
        Me.RbtnAbonadas.TabStop = True
        Me.RbtnAbonadas.Text = "ABONADAS"
        Me.RbtnAbonadas.UseVisualStyleBackColor = True
        '
        'RbtnPagadas
        '
        Me.RbtnPagadas.AutoSize = True
        Me.RbtnPagadas.Location = New System.Drawing.Point(221, 14)
        Me.RbtnPagadas.Name = "RbtnPagadas"
        Me.RbtnPagadas.Size = New System.Drawing.Size(76, 17)
        Me.RbtnPagadas.TabIndex = 5
        Me.RbtnPagadas.TabStop = True
        Me.RbtnPagadas.Text = "PAGADAS"
        Me.RbtnPagadas.UseVisualStyleBackColor = True
        '
        'RbtnCanceladas
        '
        Me.RbtnCanceladas.AutoSize = True
        Me.RbtnCanceladas.Location = New System.Drawing.Point(110, 14)
        Me.RbtnCanceladas.Name = "RbtnCanceladas"
        Me.RbtnCanceladas.Size = New System.Drawing.Size(96, 17)
        Me.RbtnCanceladas.TabIndex = 4
        Me.RbtnCanceladas.TabStop = True
        Me.RbtnCanceladas.Text = "CANCELADAS"
        Me.RbtnCanceladas.UseVisualStyleBackColor = True
        '
        'RbtVigentes
        '
        Me.RbtVigentes.AutoSize = True
        Me.RbtVigentes.Location = New System.Drawing.Point(16, 16)
        Me.RbtVigentes.Name = "RbtVigentes"
        Me.RbtVigentes.Size = New System.Drawing.Size(79, 17)
        Me.RbtVigentes.TabIndex = 3
        Me.RbtVigentes.TabStop = True
        Me.RbtVigentes.Text = "VIGENTES"
        Me.RbtVigentes.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(564, 440)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 13
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BrnCancelar
        '
        Me.BrnCancelar.Location = New System.Drawing.Point(660, 440)
        Me.BrnCancelar.Name = "BrnCancelar"
        Me.BrnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BrnCancelar.TabIndex = 14
        Me.BrnCancelar.Text = "Cancelar"
        Me.BrnCancelar.UseVisualStyleBackColor = True
        '
        'FrmConFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 480)
        Me.Controls.Add(Me.BrnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ChkFechas)
        Me.Controls.Add(Me.CmbCliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNoFactura)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.Controls.Add(Me.DgvFacturas)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConFacturas"
        Me.Text = "Consulta de Facturas"
        CType(Me.DgvFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgvFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNoFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbCliente As System.Windows.Forms.ComboBox
    Friend WithEvents ChkFechas As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DtpFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RbtnTodas As System.Windows.Forms.RadioButton
    Friend WithEvents RbtnAbonadas As System.Windows.Forms.RadioButton
    Friend WithEvents RbtnPagadas As System.Windows.Forms.RadioButton
    Friend WithEvents RbtnCanceladas As System.Windows.Forms.RadioButton
    Friend WithEvents RbtVigentes As System.Windows.Forms.RadioButton
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents BrnCancelar As System.Windows.Forms.Button
    Friend WithEvents Factura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdCLiente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaCaptura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaVencimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Contado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Credito As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SubTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Observaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RFC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Poliza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdFolioEmbarque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Domicilio As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
