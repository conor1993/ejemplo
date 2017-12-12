<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusqCanalesAcorte
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
        Me.Label17 = New System.Windows.Forms.Label
        Me.DgvCanales = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.BtnAceptar = New System.Windows.Forms.Button
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtFolioSacrificio = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtKilos = New IntegraLab.Controles.TextBoxMejorado
        Me.chkAgregar = New System.Windows.Forms.CheckBox
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.ClmFolioMov = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaSacrificio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFolioSacrificio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmLoteRastro = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmFolioCanal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmKgrs = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmLado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCodBarras = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmNomCliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DgvCanales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(923, 32)
        Me.Label17.TabIndex = 48
        Me.Label17.Text = "Búsqueda de Canales"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DgvCanales
        '
        Me.DgvCanales.AllowUserToAddRows = False
        Me.DgvCanales.AllowUserToDeleteRows = False
        Me.DgvCanales.AllowUserToResizeRows = False
        Me.DgvCanales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvCanales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCanales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClmFolioMov, Me.FechaSacrificio, Me.clmFolioSacrificio, Me.clmLoteRastro, Me.ClmFolioCanal, Me.clmKgrs, Me.clmLado, Me.clmCodBarras, Me.clmEstatus, Me.clmNomCliente})
        Me.DgvCanales.Location = New System.Drawing.Point(9, 19)
        Me.DgvCanales.MultiSelect = False
        Me.DgvCanales.Name = "DgvCanales"
        Me.DgvCanales.ReadOnly = True
        Me.DgvCanales.RowHeadersVisible = False
        Me.DgvCanales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCanales.Size = New System.Drawing.Size(881, 458)
        Me.DgvCanales.TabIndex = 49
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DgvCanales)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(909, 483)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Canales Disponibles"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Location = New System.Drawing.Point(863, 581)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(98, 29)
        Me.btnCancelar.TabIndex = 51
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAceptar.Location = New System.Drawing.Point(759, 581)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(98, 29)
        Me.BtnAceptar.TabIndex = 52
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
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
        Me.mtb.Size = New System.Drawing.Size(50, 615)
        Me.mtb.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(225, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Folio Sacrificio:"
        '
        'txtFolioSacrificio
        '
        Me.txtFolioSacrificio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFolioSacrificio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFolioSacrificio.Location = New System.Drawing.Point(309, 59)
        Me.txtFolioSacrificio.Name = "txtFolioSacrificio"
        Me.txtFolioSacrificio.Size = New System.Drawing.Size(137, 20)
        Me.txtFolioSacrificio.TabIndex = 55
        Me.txtFolioSacrificio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(452, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Kilogramos:"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "FolioMovimiento"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Folio Movimiento"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FechaSacrificio"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha de Sacrificio"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 130
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FolioSacrificio"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Folio Sacrificio"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IdFolioCanal"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Canal"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 60
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "KgrsCalientes"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Kilos Calientes"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Lado"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Lado"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Visible = False
        Me.DataGridViewTextBoxColumn6.Width = 40
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CodigoBarra"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Codigo de Barras"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 120
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Estatus"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Estatus"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 150
        '
        'txtKilos
        '
        Me.txtKilos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKilos.ComboBoxEnlazado = Nothing
        Me.txtKilos.Decimales = 3
        Me.txtKilos.Location = New System.Drawing.Point(519, 60)
        Me.txtKilos.MaxLength = 3000
        Me.txtKilos.MensajeCombo = "Seleccionar un item..."
        Me.txtKilos.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtKilos.Name = "txtKilos"
        Me.txtKilos.SiguienteControl = Nothing
        Me.txtKilos.Size = New System.Drawing.Size(147, 20)
        Me.txtKilos.TabIndex = 57
        Me.txtKilos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtKilos.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.[Decimal]
        '
        'chkAgregar
        '
        Me.chkAgregar.AutoSize = True
        Me.chkAgregar.Location = New System.Drawing.Point(65, 38)
        Me.chkAgregar.Name = "chkAgregar"
        Me.chkAgregar.Size = New System.Drawing.Size(163, 17)
        Me.chkAgregar.TabIndex = 60
        Me.chkAgregar.Text = "Agregar fecha a la busqueda"
        Me.chkAgregar.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(108, 60)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(90, 20)
        Me.dtpFecha.TabIndex = 59
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Fecha:"
        '
        'ClmFolioMov
        '
        Me.ClmFolioMov.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ClmFolioMov.DataPropertyName = "FolioMovimiento"
        Me.ClmFolioMov.HeaderText = "Folio Movimiento"
        Me.ClmFolioMov.Name = "ClmFolioMov"
        Me.ClmFolioMov.ReadOnly = True
        Me.ClmFolioMov.Visible = False
        Me.ClmFolioMov.Width = 92
        '
        'FechaSacrificio
        '
        Me.FechaSacrificio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.FechaSacrificio.DataPropertyName = "FechaSacrificio"
        Me.FechaSacrificio.HeaderText = "Fecha de Sacrificio"
        Me.FechaSacrificio.Name = "FechaSacrificio"
        Me.FechaSacrificio.ReadOnly = True
        Me.FechaSacrificio.Width = 113
        '
        'clmFolioSacrificio
        '
        Me.clmFolioSacrificio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmFolioSacrificio.DataPropertyName = "FolioSacrificio"
        Me.clmFolioSacrificio.HeaderText = "Folio Sacrificio"
        Me.clmFolioSacrificio.Name = "clmFolioSacrificio"
        Me.clmFolioSacrificio.ReadOnly = True
        Me.clmFolioSacrificio.Width = 92
        '
        'clmLoteRastro
        '
        Me.clmLoteRastro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmLoteRastro.HeaderText = "Lote Rastro"
        Me.clmLoteRastro.Name = "clmLoteRastro"
        Me.clmLoteRastro.ReadOnly = True
        Me.clmLoteRastro.Visible = False
        Me.clmLoteRastro.Width = 80
        '
        'ClmFolioCanal
        '
        Me.ClmFolioCanal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.ClmFolioCanal.DataPropertyName = "IdFolioCanal"
        Me.ClmFolioCanal.HeaderText = "Canal"
        Me.ClmFolioCanal.Name = "ClmFolioCanal"
        Me.ClmFolioCanal.ReadOnly = True
        Me.ClmFolioCanal.Width = 59
        '
        'clmKgrs
        '
        Me.clmKgrs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmKgrs.DataPropertyName = "KgrsCalientes"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N3"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.clmKgrs.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmKgrs.HeaderText = "Kilos Calientes"
        Me.clmKgrs.Name = "clmKgrs"
        Me.clmKgrs.ReadOnly = True
        Me.clmKgrs.Width = 92
        '
        'clmLado
        '
        Me.clmLado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmLado.DataPropertyName = "Lado"
        Me.clmLado.HeaderText = "Lado"
        Me.clmLado.Name = "clmLado"
        Me.clmLado.ReadOnly = True
        Me.clmLado.Visible = False
        Me.clmLado.Width = 56
        '
        'clmCodBarras
        '
        Me.clmCodBarras.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmCodBarras.DataPropertyName = "CodigoBarra"
        Me.clmCodBarras.HeaderText = "Codigo de Barras"
        Me.clmCodBarras.Name = "clmCodBarras"
        Me.clmCodBarras.ReadOnly = True
        Me.clmCodBarras.Width = 77
        '
        'clmEstatus
        '
        Me.clmEstatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmEstatus.DataPropertyName = "Estatus"
        Me.clmEstatus.HeaderText = "Estatus"
        Me.clmEstatus.Name = "clmEstatus"
        Me.clmEstatus.ReadOnly = True
        Me.clmEstatus.Width = 67
        '
        'clmNomCliente
        '
        Me.clmNomCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clmNomCliente.DataPropertyName = "Nombre"
        Me.clmNomCliente.HeaderText = "Cliente"
        Me.clmNomCliente.Name = "clmNomCliente"
        Me.clmNomCliente.ReadOnly = True
        Me.clmNomCliente.Width = 64
        '
        'FrmBusqCanalesAcorte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 615)
        Me.Controls.Add(Me.chkAgregar)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtKilos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFolioSacrificio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.Name = "FrmBusqCanalesAcorte"
        Me.Text = "Búsqueda de Canales"
        CType(Me.DgvCanales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents DgvCanales As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFolioSacrificio As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtKilos As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkAgregar As System.Windows.Forms.CheckBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ClmFolioMov As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaSacrificio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFolioSacrificio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmLoteRastro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmFolioCanal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmKgrs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmLado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCodBarras As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmNomCliente As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
