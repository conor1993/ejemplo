<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNomPuestos
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
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtCodigo = New IntegraLab.Controles.TextBoxMejorado
        Me.txtDescripcion = New IntegraLab.Controles.TextBoxMejorado
        Me.txtSueldoDiario = New IntegraLab.Controles.TextBoxMejorado
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgLista = New System.Windows.Forms.DataGridView
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SueldoDiarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdUsuarioAltaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaAltaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdUsuarioCancelaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaCancelacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EntidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SeleccionadoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ContenedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IndiceEnContenedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PuestosC = New ClasesNegocio.PuestosCollectionClass
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgLista, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = True
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 441)
        Me.mtb.TabIndex = 31
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(551, 32)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "Puestos"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.ComboBoxEnlazado = Nothing
        Me.txtCodigo.Decimales = 0
        Me.txtCodigo.Location = New System.Drawing.Point(160, 55)
        Me.txtCodigo.MensajeCombo = "Seleccionar un item..."
        Me.txtCodigo.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.SiguienteControl = Nothing
        Me.txtCodigo.Size = New System.Drawing.Size(50, 20)
        Me.txtCodigo.TabIndex = 33
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCodigo.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.ComboBoxEnlazado = Nothing
        Me.txtDescripcion.Decimales = 0
        Me.txtDescripcion.Location = New System.Drawing.Point(160, 81)
        Me.txtDescripcion.MaxLength = 80
        Me.txtDescripcion.MensajeCombo = "Seleccionar un item..."
        Me.txtDescripcion.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.SiguienteControl = Me.txtSueldoDiario
        Me.txtDescripcion.Size = New System.Drawing.Size(321, 20)
        Me.txtDescripcion.TabIndex = 34
        Me.txtDescripcion.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'txtSueldoDiario
        '
        Me.txtSueldoDiario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSueldoDiario.ComboBoxEnlazado = Nothing
        Me.txtSueldoDiario.Decimales = 0
        Me.txtSueldoDiario.Location = New System.Drawing.Point(160, 107)
        Me.txtSueldoDiario.MaxLength = 3000
        Me.txtSueldoDiario.MensajeCombo = "Seleccionar un item..."
        Me.txtSueldoDiario.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtSueldoDiario.Name = "txtSueldoDiario"
        Me.txtSueldoDiario.SiguienteControl = Nothing
        Me.txtSueldoDiario.Size = New System.Drawing.Size(100, 20)
        Me.txtSueldoDiario.TabIndex = 35
        Me.txtSueldoDiario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSueldoDiario.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.[Decimal]
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Codigo :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Descripción :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Sueldo Diario :"
        '
        'lblEstatus
        '
        Me.lblEstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(481, 47)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(99, 21)
        Me.lblEstatus.TabIndex = 39
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEstatus.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgLista)
        Me.GroupBox1.Location = New System.Drawing.Point(59, 133)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(521, 296)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de Puestos"
        '
        'dgLista
        '
        Me.dgLista.AllowUserToAddRows = False
        Me.dgLista.AllowUserToDeleteRows = False
        Me.dgLista.AllowUserToResizeRows = False
        Me.dgLista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgLista.AutoGenerateColumns = False
        Me.dgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.SueldoDiarioDataGridViewTextBoxColumn, Me.EstatusDataGridViewTextBoxColumn, Me.IdUsuarioAltaDataGridViewTextBoxColumn, Me.FechaAltaDataGridViewTextBoxColumn, Me.IdUsuarioCancelaDataGridViewTextBoxColumn, Me.FechaCancelacionDataGridViewTextBoxColumn, Me.EntidadDataGridViewTextBoxColumn, Me.SeleccionadoDataGridViewCheckBoxColumn, Me.ContenedorDataGridViewTextBoxColumn, Me.IndiceEnContenedorDataGridViewTextBoxColumn})
        Me.dgLista.DataSource = Me.PuestosC
        Me.dgLista.Location = New System.Drawing.Point(6, 19)
        Me.dgLista.Name = "dgLista"
        Me.dgLista.ReadOnly = True
        Me.dgLista.RowHeadersVisible = False
        Me.dgLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgLista.Size = New System.Drawing.Size(509, 261)
        Me.dgLista.TabIndex = 1
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Puesto"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 65
        '
        'SueldoDiarioDataGridViewTextBoxColumn
        '
        Me.SueldoDiarioDataGridViewTextBoxColumn.DataPropertyName = "SueldoDiario"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.SueldoDiarioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.SueldoDiarioDataGridViewTextBoxColumn.HeaderText = "SueldoDiario"
        Me.SueldoDiarioDataGridViewTextBoxColumn.Name = "SueldoDiarioDataGridViewTextBoxColumn"
        Me.SueldoDiarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.SueldoDiarioDataGridViewTextBoxColumn.Width = 92
        '
        'EstatusDataGridViewTextBoxColumn
        '
        Me.EstatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.HeaderText = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.Name = "EstatusDataGridViewTextBoxColumn"
        Me.EstatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstatusDataGridViewTextBoxColumn.Width = 67
        '
        'IdUsuarioAltaDataGridViewTextBoxColumn
        '
        Me.IdUsuarioAltaDataGridViewTextBoxColumn.DataPropertyName = "IdUsuarioAlta"
        Me.IdUsuarioAltaDataGridViewTextBoxColumn.HeaderText = "IdUsuarioAlta"
        Me.IdUsuarioAltaDataGridViewTextBoxColumn.Name = "IdUsuarioAltaDataGridViewTextBoxColumn"
        Me.IdUsuarioAltaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdUsuarioAltaDataGridViewTextBoxColumn.Visible = False
        '
        'FechaAltaDataGridViewTextBoxColumn
        '
        Me.FechaAltaDataGridViewTextBoxColumn.DataPropertyName = "FechaAlta"
        Me.FechaAltaDataGridViewTextBoxColumn.HeaderText = "FechaAlta"
        Me.FechaAltaDataGridViewTextBoxColumn.Name = "FechaAltaDataGridViewTextBoxColumn"
        Me.FechaAltaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaAltaDataGridViewTextBoxColumn.Visible = False
        '
        'IdUsuarioCancelaDataGridViewTextBoxColumn
        '
        Me.IdUsuarioCancelaDataGridViewTextBoxColumn.DataPropertyName = "IdUsuarioCancela"
        Me.IdUsuarioCancelaDataGridViewTextBoxColumn.HeaderText = "IdUsuarioCancela"
        Me.IdUsuarioCancelaDataGridViewTextBoxColumn.Name = "IdUsuarioCancelaDataGridViewTextBoxColumn"
        Me.IdUsuarioCancelaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdUsuarioCancelaDataGridViewTextBoxColumn.Visible = False
        '
        'FechaCancelacionDataGridViewTextBoxColumn
        '
        Me.FechaCancelacionDataGridViewTextBoxColumn.DataPropertyName = "FechaCancelacion"
        Me.FechaCancelacionDataGridViewTextBoxColumn.HeaderText = "FechaCancelacion"
        Me.FechaCancelacionDataGridViewTextBoxColumn.Name = "FechaCancelacionDataGridViewTextBoxColumn"
        Me.FechaCancelacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaCancelacionDataGridViewTextBoxColumn.Visible = False
        '
        'EntidadDataGridViewTextBoxColumn
        '
        Me.EntidadDataGridViewTextBoxColumn.DataPropertyName = "Entidad"
        Me.EntidadDataGridViewTextBoxColumn.HeaderText = "Entidad"
        Me.EntidadDataGridViewTextBoxColumn.Name = "EntidadDataGridViewTextBoxColumn"
        Me.EntidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.EntidadDataGridViewTextBoxColumn.Visible = False
        '
        'SeleccionadoDataGridViewCheckBoxColumn
        '
        Me.SeleccionadoDataGridViewCheckBoxColumn.DataPropertyName = "Seleccionado"
        Me.SeleccionadoDataGridViewCheckBoxColumn.HeaderText = "Seleccionado"
        Me.SeleccionadoDataGridViewCheckBoxColumn.Name = "SeleccionadoDataGridViewCheckBoxColumn"
        Me.SeleccionadoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.SeleccionadoDataGridViewCheckBoxColumn.Visible = False
        '
        'ContenedorDataGridViewTextBoxColumn
        '
        Me.ContenedorDataGridViewTextBoxColumn.DataPropertyName = "Contenedor"
        Me.ContenedorDataGridViewTextBoxColumn.HeaderText = "Contenedor"
        Me.ContenedorDataGridViewTextBoxColumn.Name = "ContenedorDataGridViewTextBoxColumn"
        Me.ContenedorDataGridViewTextBoxColumn.ReadOnly = True
        Me.ContenedorDataGridViewTextBoxColumn.Visible = False
        '
        'IndiceEnContenedorDataGridViewTextBoxColumn
        '
        Me.IndiceEnContenedorDataGridViewTextBoxColumn.DataPropertyName = "IndiceEnContenedor"
        Me.IndiceEnContenedorDataGridViewTextBoxColumn.HeaderText = "IndiceEnContenedor"
        Me.IndiceEnContenedorDataGridViewTextBoxColumn.Name = "IndiceEnContenedorDataGridViewTextBoxColumn"
        Me.IndiceEnContenedorDataGridViewTextBoxColumn.ReadOnly = True
        Me.IndiceEnContenedorDataGridViewTextBoxColumn.Visible = False
        '
        'PuestosC
        '
        Me.PuestosC.AllowEdit = True
        Me.PuestosC.AllowNew = True
        Me.PuestosC.AllowRemove = True
        Me.PuestosC.MaximoElementosSeleccionados = 1
        Me.PuestosC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.PuestosC.MostrarAlertas = False
        Me.PuestosC.Name = Nothing
        Me.PuestosC.RaiseListChangedEvents = True
        '
        'FrmNomPuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 441)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblEstatus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSueldoDiario)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.Name = "FrmNomPuestos"
        Me.Text = "Puestos"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtDescripcion As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtSueldoDiario As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgLista As System.Windows.Forms.DataGridView
    Friend WithEvents PuestosC As ClasesNegocio.PuestosCollectionClass
    Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SueldoDiarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdUsuarioAltaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaAltaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdUsuarioCancelaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaCancelacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EntidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeleccionadoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ContenedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IndiceEnContenedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
