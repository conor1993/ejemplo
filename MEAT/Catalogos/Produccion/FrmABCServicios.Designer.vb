<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmABCServicios
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
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.rbtnProduccion = New System.Windows.Forms.RadioButton
        Me.GrpTipoServ = New System.Windows.Forms.GroupBox
        Me.rbtnEmbarque = New System.Windows.Forms.RadioButton
        Me.Dtpfecha = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtDescFiltro = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dgvServicios = New System.Windows.Forms.DataGridView
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoServicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaAltaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ServiciosC = New ClasesNegocio.ServiciosCollectionClass
        Me.GrpTipoServ.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.MEAToolBar1.MostrarBorrar = True
        Me.MEAToolBar1.MostrarBuscar = False
        Me.MEAToolBar1.MostrarCancelar = True
        Me.MEAToolBar1.MostrarEditar = True
        Me.MEAToolBar1.MostrarGuardar = True
        Me.MEAToolBar1.MostrarImprimir = True
        Me.MEAToolBar1.MostrarLimpiar = True
        Me.MEAToolBar1.MostrarNuevo = True
        Me.MEAToolBar1.MostrarSalir = True
        Me.MEAToolBar1.Name = "MEAToolBar1"
        Me.MEAToolBar1.ShowToolTips = True
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 501)
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
        Me.Label17.Size = New System.Drawing.Size(541, 32)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "SERVICIOS DE RASTROS"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(123, 61)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(58, 20)
        Me.txtCodigo.TabIndex = 34
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Descripción:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(123, 87)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(277, 20)
        Me.txtDescripcion.TabIndex = 36
        '
        'rbtnProduccion
        '
        Me.rbtnProduccion.AutoSize = True
        Me.rbtnProduccion.Checked = True
        Me.rbtnProduccion.Location = New System.Drawing.Point(16, 19)
        Me.rbtnProduccion.Name = "rbtnProduccion"
        Me.rbtnProduccion.Size = New System.Drawing.Size(79, 17)
        Me.rbtnProduccion.TabIndex = 37
        Me.rbtnProduccion.TabStop = True
        Me.rbtnProduccion.Text = "Producción"
        Me.rbtnProduccion.UseVisualStyleBackColor = True
        '
        'GrpTipoServ
        '
        Me.GrpTipoServ.Controls.Add(Me.rbtnEmbarque)
        Me.GrpTipoServ.Controls.Add(Me.rbtnProduccion)
        Me.GrpTipoServ.Enabled = False
        Me.GrpTipoServ.Location = New System.Drawing.Point(54, 113)
        Me.GrpTipoServ.Name = "GrpTipoServ"
        Me.GrpTipoServ.Size = New System.Drawing.Size(226, 52)
        Me.GrpTipoServ.TabIndex = 38
        Me.GrpTipoServ.TabStop = False
        Me.GrpTipoServ.Text = "Tipo de Servicio"
        '
        'rbtnEmbarque
        '
        Me.rbtnEmbarque.AutoSize = True
        Me.rbtnEmbarque.Location = New System.Drawing.Point(126, 19)
        Me.rbtnEmbarque.Name = "rbtnEmbarque"
        Me.rbtnEmbarque.Size = New System.Drawing.Size(73, 17)
        Me.rbtnEmbarque.TabIndex = 38
        Me.rbtnEmbarque.TabStop = True
        Me.rbtnEmbarque.Text = "Embarque"
        Me.rbtnEmbarque.UseVisualStyleBackColor = True
        '
        'Dtpfecha
        '
        Me.Dtpfecha.Enabled = False
        Me.Dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtpfecha.Location = New System.Drawing.Point(308, 61)
        Me.Dtpfecha.Name = "Dtpfecha"
        Me.Dtpfecha.Size = New System.Drawing.Size(92, 20)
        Me.Dtpfecha.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(226, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Fecha de Alta:"
        '
        'lblEstatus
        '
        Me.lblEstatus.AutoSize = True
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(436, 42)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(104, 24)
        Me.lblEstatus.TabIndex = 41
        Me.lblEstatus.Text = "ESTATUS"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.txtDescFiltro)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.dgvServicios)
        Me.GroupBox2.Location = New System.Drawing.Point(54, 181)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(524, 304)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Servicios Registrados"
        '
        'txtDescFiltro
        '
        Me.txtDescFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescFiltro.Location = New System.Drawing.Point(81, 19)
        Me.txtDescFiltro.MaxLength = 50
        Me.txtDescFiltro.Name = "txtDescFiltro"
        Me.txtDescFiltro.Size = New System.Drawing.Size(255, 20)
        Me.txtDescFiltro.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Descripción:"
        '
        'dgvServicios
        '
        Me.dgvServicios.AllowUserToAddRows = False
        Me.dgvServicios.AllowUserToDeleteRows = False
        Me.dgvServicios.AllowUserToResizeRows = False
        Me.dgvServicios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvServicios.AutoGenerateColumns = False
        Me.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvServicios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.EstatusDataGridViewTextBoxColumn, Me.TipoServicioDataGridViewTextBoxColumn, Me.FechaAltaDataGridViewTextBoxColumn})
        Me.dgvServicios.DataSource = Me.ServiciosC
        Me.dgvServicios.Location = New System.Drawing.Point(6, 47)
        Me.dgvServicios.MultiSelect = False
        Me.dgvServicios.Name = "dgvServicios"
        Me.dgvServicios.ReadOnly = True
        Me.dgvServicios.RowHeadersVisible = False
        Me.dgvServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvServicios.Size = New System.Drawing.Size(505, 251)
        Me.dgvServicios.TabIndex = 0
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoDataGridViewTextBoxColumn.Width = 50
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 150
        '
        'EstatusDataGridViewTextBoxColumn
        '
        Me.EstatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.HeaderText = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.Name = "EstatusDataGridViewTextBoxColumn"
        Me.EstatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoServicioDataGridViewTextBoxColumn
        '
        Me.TipoServicioDataGridViewTextBoxColumn.DataPropertyName = "TipoServicio"
        Me.TipoServicioDataGridViewTextBoxColumn.HeaderText = "Tipo Servicio"
        Me.TipoServicioDataGridViewTextBoxColumn.Name = "TipoServicioDataGridViewTextBoxColumn"
        Me.TipoServicioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaAltaDataGridViewTextBoxColumn
        '
        Me.FechaAltaDataGridViewTextBoxColumn.DataPropertyName = "FechaAlta"
        Me.FechaAltaDataGridViewTextBoxColumn.HeaderText = "FechaAlta"
        Me.FechaAltaDataGridViewTextBoxColumn.Name = "FechaAltaDataGridViewTextBoxColumn"
        Me.FechaAltaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ServiciosC
        '
        Me.ServiciosC.AllowEdit = True
        Me.ServiciosC.AllowNew = True
        Me.ServiciosC.AllowRemove = True
        Me.ServiciosC.MaximoElementosSeleccionados = 1
        Me.ServiciosC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.ServiciosC.MostrarAlertas = False
        Me.ServiciosC.Name = Nothing
        Me.ServiciosC.RaiseListChangedEvents = True
        Me.ServiciosC.Transaction = Nothing
        '
        'FrmABCServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 501)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblEstatus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Dtpfecha)
        Me.Controls.Add(Me.GrpTipoServ)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.Name = "FrmABCServicios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Servicios de Rastros"
        Me.GrpTipoServ.ResumeLayout(False)
        Me.GrpTipoServ.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents rbtnProduccion As System.Windows.Forms.RadioButton
    Friend WithEvents GrpTipoServ As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnEmbarque As System.Windows.Forms.RadioButton
    Friend WithEvents Dtpfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvServicios As System.Windows.Forms.DataGridView
    Friend WithEvents txtDescFiltro As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ServiciosC As ClasesNegocio.ServiciosCollectionClass
    Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoServicioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaAltaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
