<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MConsEmbarques
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
        Dim DataGridViewCellStyle61 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle62 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle63 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle64 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle65 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DgvEmbarques = New System.Windows.Forms.DataGridView
        Me.IdFolioEmbarque = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmReferencia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Piezas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Kilos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cajas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Domicilio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RFC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIdCliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtFolio = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmbClientes = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.ChkFechas = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.DtpFechaFin = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.DtpFechaIni = New System.Windows.Forms.DateTimePicker
        Me.lblCliente = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbtnFacturados = New System.Windows.Forms.RadioButton
        Me.rbtnTodos = New System.Windows.Forms.RadioButton
        Me.RbtnCancelado = New System.Windows.Forms.RadioButton
        Me.RbtnVigente = New System.Windows.Forms.RadioButton
        Me.BrnCancelar = New System.Windows.Forms.Button
        Me.BtnAceptar = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtReferencia = New System.Windows.Forms.TextBox
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DgvEmbarques, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvEmbarques
        '
        Me.DgvEmbarques.AllowUserToAddRows = False
        Me.DgvEmbarques.AllowUserToDeleteRows = False
        Me.DgvEmbarques.AllowUserToResizeRows = False
        Me.DgvEmbarques.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvEmbarques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEmbarques.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdFolioEmbarque, Me.clmReferencia, Me.Cliente, Me.Piezas, Me.Kilos, Me.Cajas, Me.Fecha, Me.Domicilio, Me.RFC, Me.ClmEstatus, Me.clmIdCliente})
        Me.DgvEmbarques.Location = New System.Drawing.Point(56, 178)
        Me.DgvEmbarques.Name = "DgvEmbarques"
        Me.DgvEmbarques.ReadOnly = True
        Me.DgvEmbarques.RowHeadersVisible = False
        Me.DgvEmbarques.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvEmbarques.Size = New System.Drawing.Size(835, 354)
        Me.DgvEmbarques.TabIndex = 10
        '
        'IdFolioEmbarque
        '
        Me.IdFolioEmbarque.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.IdFolioEmbarque.DataPropertyName = "IdFolioEmbarque"
        DataGridViewCellStyle61.NullValue = "''"
        Me.IdFolioEmbarque.DefaultCellStyle = DataGridViewCellStyle61
        Me.IdFolioEmbarque.HeaderText = "Folio Embarque"
        Me.IdFolioEmbarque.Name = "IdFolioEmbarque"
        Me.IdFolioEmbarque.ReadOnly = True
        Me.IdFolioEmbarque.Width = 97
        '
        'clmReferencia
        '
        Me.clmReferencia.DataPropertyName = "FolioEmbarqueEmp"
        Me.clmReferencia.HeaderText = "Referencia"
        Me.clmReferencia.Name = "clmReferencia"
        Me.clmReferencia.ReadOnly = True
        '
        'Cliente
        '
        Me.Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Cliente.DataPropertyName = "Nombre"
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        Me.Cliente.Width = 64
        '
        'Piezas
        '
        Me.Piezas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Piezas.DataPropertyName = "TotalPiezas"
        DataGridViewCellStyle62.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Piezas.DefaultCellStyle = DataGridViewCellStyle62
        Me.Piezas.HeaderText = "Piezas"
        Me.Piezas.Name = "Piezas"
        Me.Piezas.ReadOnly = True
        Me.Piezas.Width = 63
        '
        'Kilos
        '
        Me.Kilos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Kilos.DataPropertyName = "TotalKgrs"
        DataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Kilos.DefaultCellStyle = DataGridViewCellStyle63
        Me.Kilos.HeaderText = "Kilos"
        Me.Kilos.Name = "Kilos"
        Me.Kilos.ReadOnly = True
        Me.Kilos.Width = 54
        '
        'Cajas
        '
        Me.Cajas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Cajas.DataPropertyName = "TotalCajas"
        Me.Cajas.HeaderText = "Cajas"
        Me.Cajas.Name = "Cajas"
        Me.Cajas.ReadOnly = True
        Me.Cajas.Width = 58
        '
        'Fecha
        '
        Me.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Fecha.DataPropertyName = "FechaEmbarque"
        Me.Fecha.HeaderText = "Fecha Embarque"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 104
        '
        'Domicilio
        '
        Me.Domicilio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Domicilio.DataPropertyName = "Domicilio"
        Me.Domicilio.HeaderText = "Domicilio"
        Me.Domicilio.Name = "Domicilio"
        Me.Domicilio.ReadOnly = True
        Me.Domicilio.Width = 74
        '
        'RFC
        '
        Me.RFC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.RFC.DataPropertyName = "RFC"
        Me.RFC.HeaderText = "RFC"
        Me.RFC.Name = "RFC"
        Me.RFC.ReadOnly = True
        Me.RFC.Width = 53
        '
        'ClmEstatus
        '
        Me.ClmEstatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ClmEstatus.DataPropertyName = "EstatusCad"
        Me.ClmEstatus.HeaderText = "Estatus"
        Me.ClmEstatus.Name = "ClmEstatus"
        Me.ClmEstatus.ReadOnly = True
        Me.ClmEstatus.Width = 67
        '
        'clmIdCliente
        '
        Me.clmIdCliente.DataPropertyName = "idCliente"
        Me.clmIdCliente.HeaderText = "IdCliente"
        Me.clmIdCliente.Name = "clmIdCliente"
        Me.clmIdCliente.ReadOnly = True
        Me.clmIdCliente.Visible = False
        '
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(141, 39)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(100, 20)
        Me.txtFolio.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Folio Embarque:"
        '
        'CmbClientes
        '
        Me.CmbClientes.FormattingEnabled = True
        Me.CmbClientes.Location = New System.Drawing.Point(141, 67)
        Me.CmbClientes.Name = "CmbClientes"
        Me.CmbClientes.Size = New System.Drawing.Size(323, 21)
        Me.CmbClientes.TabIndex = 2
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(851, 32)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Búsqueda de Embarques"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.mtb.MostrarBorrar = False
        Me.mtb.MostrarBuscar = True
        Me.mtb.MostrarCancelar = False
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = False
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 586)
        Me.mtb.TabIndex = 0
        '
        'ChkFechas
        '
        Me.ChkFechas.AutoSize = True
        Me.ChkFechas.Checked = True
        Me.ChkFechas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkFechas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ChkFechas.Location = New System.Drawing.Point(56, 103)
        Me.ChkFechas.Name = "ChkFechas"
        Me.ChkFechas.Size = New System.Drawing.Size(104, 17)
        Me.ChkFechas.TabIndex = 3
        Me.ChkFechas.Text = "Filtra por Fechas"
        Me.ChkFechas.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DtpFechaFin)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DtpFechaIni)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 126)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 46)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fechas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(185, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha Final:"
        '
        'DtpFechaFin
        '
        Me.DtpFechaFin.Enabled = False
        Me.DtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaFin.Location = New System.Drawing.Point(256, 16)
        Me.DtpFechaFin.Name = "DtpFechaFin"
        Me.DtpFechaFin.Size = New System.Drawing.Size(92, 20)
        Me.DtpFechaFin.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fecha Inicial:"
        '
        'DtpFechaIni
        '
        Me.DtpFechaIni.Enabled = False
        Me.DtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaIni.Location = New System.Drawing.Point(82, 16)
        Me.DtpFechaIni.Name = "DtpFechaIni"
        Me.DtpFechaIni.Size = New System.Drawing.Size(92, 20)
        Me.DtpFechaIni.TabIndex = 0
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(51, 70)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 13)
        Me.lblCliente.TabIndex = 6
        Me.lblCliente.Text = "Cliente:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbtnFacturados)
        Me.GroupBox2.Controls.Add(Me.rbtnTodos)
        Me.GroupBox2.Controls.Add(Me.RbtnCancelado)
        Me.GroupBox2.Controls.Add(Me.RbtnVigente)
        Me.GroupBox2.Location = New System.Drawing.Point(422, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(388, 46)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estatus"
        '
        'rbtnFacturados
        '
        Me.rbtnFacturados.AutoSize = True
        Me.rbtnFacturados.Location = New System.Drawing.Point(92, 18)
        Me.rbtnFacturados.Name = "rbtnFacturados"
        Me.rbtnFacturados.Size = New System.Drawing.Size(98, 17)
        Me.rbtnFacturados.TabIndex = 7
        Me.rbtnFacturados.Text = "FACTURADOS"
        Me.rbtnFacturados.UseVisualStyleBackColor = True
        '
        'rbtnTodos
        '
        Me.rbtnTodos.AutoSize = True
        Me.rbtnTodos.Checked = True
        Me.rbtnTodos.Location = New System.Drawing.Point(313, 18)
        Me.rbtnTodos.Name = "rbtnTodos"
        Me.rbtnTodos.Size = New System.Drawing.Size(63, 17)
        Me.rbtnTodos.TabIndex = 9
        Me.rbtnTodos.TabStop = True
        Me.rbtnTodos.Text = "TODOS"
        Me.rbtnTodos.UseVisualStyleBackColor = True
        '
        'RbtnCancelado
        '
        Me.RbtnCancelado.AutoSize = True
        Me.RbtnCancelado.Location = New System.Drawing.Point(201, 18)
        Me.RbtnCancelado.Name = "RbtnCancelado"
        Me.RbtnCancelado.Size = New System.Drawing.Size(97, 17)
        Me.RbtnCancelado.TabIndex = 8
        Me.RbtnCancelado.Text = "CANCELADOS"
        Me.RbtnCancelado.UseVisualStyleBackColor = True
        '
        'RbtnVigente
        '
        Me.RbtnVigente.AutoSize = True
        Me.RbtnVigente.Location = New System.Drawing.Point(7, 18)
        Me.RbtnVigente.Name = "RbtnVigente"
        Me.RbtnVigente.Size = New System.Drawing.Size(79, 17)
        Me.RbtnVigente.TabIndex = 6
        Me.RbtnVigente.Text = "VIGENTES"
        Me.RbtnVigente.UseVisualStyleBackColor = True
        '
        'BrnCancelar
        '
        Me.BrnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrnCancelar.Location = New System.Drawing.Point(814, 551)
        Me.BrnCancelar.Name = "BrnCancelar"
        Me.BrnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BrnCancelar.TabIndex = 12
        Me.BrnCancelar.Text = "Cancelar"
        Me.BrnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAceptar.Location = New System.Drawing.Point(724, 551)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 11
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(247, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Referencia:"
        '
        'txtReferencia
        '
        Me.txtReferencia.Location = New System.Drawing.Point(312, 39)
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Size = New System.Drawing.Size(100, 20)
        Me.txtReferencia.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdFolioEmbarque"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Folio Embarque"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FechaEmbarque"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha Embarque"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TotalPiezas"
        DataGridViewCellStyle64.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle64
        Me.DataGridViewTextBoxColumn4.HeaderText = "Piezas"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TotalKgrs"
        DataGridViewCellStyle65.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle65
        Me.DataGridViewTextBoxColumn5.HeaderText = "Kilos"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TotalCajas"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cajas"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Domicilio"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Domicilio"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "RFC"
        Me.DataGridViewTextBoxColumn8.HeaderText = "RFC"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Estatus"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Estatus"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "idCliente"
        Me.DataGridViewTextBoxColumn10.HeaderText = "IdCliente"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "FolioEmbarqueEmp"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Referencia"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'MConsEmbarques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 586)
        Me.Controls.Add(Me.txtReferencia)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.BrnCancelar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ChkFechas)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.CmbClientes)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.DgvEmbarques)
        Me.Name = "MConsEmbarques"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Búsqueda de Embarques"
        CType(Me.DgvEmbarques, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgvEmbarques As System.Windows.Forms.DataGridView
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbClientes As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents ChkFechas As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DtpFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RbtnCancelado As System.Windows.Forms.RadioButton
    Friend WithEvents RbtnVigente As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnTodos As System.Windows.Forms.RadioButton
    Friend WithEvents BrnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents rbtnFacturados As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtReferencia As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdFolioEmbarque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmReferencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Piezas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kilos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cajas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Domicilio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RFC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdCliente As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
