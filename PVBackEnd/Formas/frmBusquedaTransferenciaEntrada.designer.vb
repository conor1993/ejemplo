<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaTransferenciaEntrada
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
        Me.Label17 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chkCanceladas = New System.Windows.Forms.CheckBox
        Me.chkRecibidas = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgTransferencias = New System.Windows.Forms.DataGridView
        Me.clmFolioTransferenciaEntrada = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFolioTransferenciaSalida = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmAlmacenOrigen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmAlmacenDestino = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmNumeroProductos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFechaTransferencia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtFolio = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.AlmacenDestinoC = New ClasesNegocio.AlmacenCollectionClass
        Me.cmbAlmacenDestino = New System.Windows.Forms.ComboBox
        Me.cmbAlmacenOrigen = New System.Windows.Forms.ComboBox
        Me.AlmacenOrigenC = New ClasesNegocio.AlmacenCollectionClass
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgTransferencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(838, 29)
        Me.Label17.TabIndex = 54
        Me.Label17.Text = "BUSQUEDA DE ENTRADAS POR TRANSFERENCIAS A ALMACÉN"
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
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 598)
        Me.mtb.TabIndex = 53
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Location = New System.Drawing.Point(801, 563)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 73
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Location = New System.Drawing.Point(720, 563)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 72
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkCanceladas)
        Me.GroupBox2.Controls.Add(Me.chkRecibidas)
        Me.GroupBox2.Location = New System.Drawing.Point(609, 58)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(170, 53)
        Me.GroupBox2.TabIndex = 71
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estatus"
        '
        'chkCanceladas
        '
        Me.chkCanceladas.AutoSize = True
        Me.chkCanceladas.Checked = True
        Me.chkCanceladas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCanceladas.Location = New System.Drawing.Point(85, 19)
        Me.chkCanceladas.Name = "chkCanceladas"
        Me.chkCanceladas.Size = New System.Drawing.Size(82, 17)
        Me.chkCanceladas.TabIndex = 2
        Me.chkCanceladas.Text = "Canceladas"
        Me.chkCanceladas.UseVisualStyleBackColor = True
        '
        'chkRecibidas
        '
        Me.chkRecibidas.AutoSize = True
        Me.chkRecibidas.Checked = True
        Me.chkRecibidas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRecibidas.Location = New System.Drawing.Point(6, 19)
        Me.chkRecibidas.Name = "chkRecibidas"
        Me.chkRecibidas.Size = New System.Drawing.Size(67, 17)
        Me.chkRecibidas.TabIndex = 1
        Me.chkRecibidas.Text = "Vigentes"
        Me.chkRecibidas.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgTransferencias)
        Me.GroupBox1.Location = New System.Drawing.Point(51, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(825, 435)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resultado de la Busqueda"
        '
        'dgTransferencias
        '
        Me.dgTransferencias.AllowUserToAddRows = False
        Me.dgTransferencias.AllowUserToDeleteRows = False
        Me.dgTransferencias.AllowUserToResizeRows = False
        Me.dgTransferencias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgTransferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTransferencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmFolioTransferenciaEntrada, Me.clmFolioTransferenciaSalida, Me.clmAlmacenOrigen, Me.clmAlmacenDestino, Me.clmNumeroProductos, Me.clmFechaTransferencia, Me.clmEstatus})
        Me.dgTransferencias.Location = New System.Drawing.Point(6, 19)
        Me.dgTransferencias.Name = "dgTransferencias"
        Me.dgTransferencias.ReadOnly = True
        Me.dgTransferencias.RowHeadersVisible = False
        Me.dgTransferencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTransferencias.Size = New System.Drawing.Size(813, 410)
        Me.dgTransferencias.TabIndex = 0
        '
        'clmFolioTransferenciaEntrada
        '
        Me.clmFolioTransferenciaEntrada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmFolioTransferenciaEntrada.DataPropertyName = "FolioTransferenciaEntrada"
        Me.clmFolioTransferenciaEntrada.HeaderText = "Folio Transferencia Entrada"
        Me.clmFolioTransferenciaEntrada.Name = "clmFolioTransferenciaEntrada"
        Me.clmFolioTransferenciaEntrada.ReadOnly = True
        Me.clmFolioTransferenciaEntrada.Width = 148
        '
        'clmFolioTransferenciaSalida
        '
        Me.clmFolioTransferenciaSalida.DataPropertyName = "FolioTransferenciaSalida"
        Me.clmFolioTransferenciaSalida.HeaderText = "Folio Transferencia Salida"
        Me.clmFolioTransferenciaSalida.Name = "clmFolioTransferenciaSalida"
        Me.clmFolioTransferenciaSalida.ReadOnly = True
        '
        'clmAlmacenOrigen
        '
        Me.clmAlmacenOrigen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmAlmacenOrigen.DataPropertyName = "AlmacenOrigen"
        Me.clmAlmacenOrigen.HeaderText = "Almacen Origen"
        Me.clmAlmacenOrigen.Name = "clmAlmacenOrigen"
        Me.clmAlmacenOrigen.ReadOnly = True
        Me.clmAlmacenOrigen.Width = 98
        '
        'clmAlmacenDestino
        '
        Me.clmAlmacenDestino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmAlmacenDestino.DataPropertyName = "AlmacenDestino"
        Me.clmAlmacenDestino.HeaderText = "Almacén Destino"
        Me.clmAlmacenDestino.Name = "clmAlmacenDestino"
        Me.clmAlmacenDestino.ReadOnly = True
        Me.clmAlmacenDestino.Width = 103
        '
        'clmNumeroProductos
        '
        Me.clmNumeroProductos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmNumeroProductos.DataPropertyName = "TotalProductos"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.clmNumeroProductos.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmNumeroProductos.HeaderText = "No. Productos"
        Me.clmNumeroProductos.Name = "clmNumeroProductos"
        Me.clmNumeroProductos.ReadOnly = True
        Me.clmNumeroProductos.Width = 92
        '
        'clmFechaTransferencia
        '
        Me.clmFechaTransferencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmFechaTransferencia.DataPropertyName = "FechaMovimiento"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.clmFechaTransferencia.DefaultCellStyle = DataGridViewCellStyle2
        Me.clmFechaTransferencia.HeaderText = "Fecha Transferencia"
        Me.clmFechaTransferencia.Name = "clmFechaTransferencia"
        Me.clmFechaTransferencia.ReadOnly = True
        Me.clmFechaTransferencia.Width = 119
        '
        'clmEstatus
        '
        Me.clmEstatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmEstatus.DataPropertyName = "EstatusStr"
        Me.clmEstatus.HeaderText = "Estatus"
        Me.clmEstatus.Name = "clmEstatus"
        Me.clmEstatus.ReadOnly = True
        Me.clmEstatus.Width = 67
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Almacen Destino:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Almacen Origen:"
        '
        'txtFolio
        '
        Me.txtFolio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFolio.Location = New System.Drawing.Point(144, 37)
        Me.txtFolio.MaxLength = 12
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(163, 20)
        Me.txtFolio.TabIndex = 65
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Folio:"
        '
        'AlmacenDestinoC
        '
        Me.AlmacenDestinoC.AllowEdit = True
        Me.AlmacenDestinoC.AllowNew = True
        Me.AlmacenDestinoC.AllowRemove = True
        Me.AlmacenDestinoC.Name = ""
        Me.AlmacenDestinoC.RaiseListChangedEvents = True
        Me.AlmacenDestinoC.Tipo = ClasesNegocio.AlmacenEnum.TODOS
        '
        'cmbAlmacenDestino
        '
        Me.cmbAlmacenDestino.DataSource = Me.AlmacenDestinoC
        Me.cmbAlmacenDestino.DisplayMember = "Descripcion"
        Me.cmbAlmacenDestino.FormattingEnabled = True
        Me.cmbAlmacenDestino.Location = New System.Drawing.Point(144, 90)
        Me.cmbAlmacenDestino.Name = "cmbAlmacenDestino"
        Me.cmbAlmacenDestino.Size = New System.Drawing.Size(459, 21)
        Me.cmbAlmacenDestino.TabIndex = 75
        Me.cmbAlmacenDestino.ValueMember = "Codigo"
        '
        'cmbAlmacenOrigen
        '
        Me.cmbAlmacenOrigen.DataSource = Me.AlmacenOrigenC
        Me.cmbAlmacenOrigen.DisplayMember = "Descripcion"
        Me.cmbAlmacenOrigen.FormattingEnabled = True
        Me.cmbAlmacenOrigen.Location = New System.Drawing.Point(144, 63)
        Me.cmbAlmacenOrigen.Name = "cmbAlmacenOrigen"
        Me.cmbAlmacenOrigen.Size = New System.Drawing.Size(459, 21)
        Me.cmbAlmacenOrigen.TabIndex = 74
        Me.cmbAlmacenOrigen.ValueMember = "Codigo"
        '
        'AlmacenOrigenC
        '
        Me.AlmacenOrigenC.AllowEdit = True
        Me.AlmacenOrigenC.AllowNew = True
        Me.AlmacenOrigenC.AllowRemove = True
        Me.AlmacenOrigenC.Name = ""
        Me.AlmacenOrigenC.RaiseListChangedEvents = True
        Me.AlmacenOrigenC.Tipo = ClasesNegocio.AlmacenEnum.TODOS
        '
        'frmBusquedaTransferenciaEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 598)
        Me.Controls.Add(Me.cmbAlmacenDestino)
        Me.Controls.Add(Me.cmbAlmacenOrigen)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.Name = "frmBusquedaTransferenciaEntrada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de Entradas Por Transferencias a Almacén"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgTransferencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCanceladas As System.Windows.Forms.CheckBox
    Friend WithEvents chkRecibidas As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgTransferencias As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents clmFolioTransferenciaEntrada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFolioTransferenciaSalida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmAlmacenOrigen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmAlmacenDestino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmNumeroProductos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaTransferencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlmacenDestinoC As ClasesNegocio.AlmacenCollectionClass
    Friend WithEvents cmbAlmacenDestino As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAlmacenOrigen As System.Windows.Forms.ComboBox
    Friend WithEvents AlmacenOrigenC As ClasesNegocio.AlmacenCollectionClass
End Class
