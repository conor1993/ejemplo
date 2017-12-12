<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TipoMovimientosBanForm
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
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar
        Me.lblTema = New System.Windows.Forms.Label
        Me.pan = New System.Windows.Forms.Panel
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.txtObservacion = New System.Windows.Forms.TextBox
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.txtDescripcionCorta = New System.Windows.Forms.TextBox
        Me.label5 = New System.Windows.Forms.Label
        Me.label4 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.gpo = New System.Windows.Forms.GroupBox
        Me.Txtfiltro = New System.Windows.Forms.TextBox
        Me.Datagrid = New System.Windows.Forms.DataGridView
        Me.Label11 = New System.Windows.Forms.Label
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Descripcioncorta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Estatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pan.SuspendLayout()
        Me.gpo.SuspendLayout()
        CType(Me.Datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 514)
        Me.MEAToolBar1.TabIndex = 12
        'Me.MEAToolBar1.TextoBorrar = "Borrar"
        'Me.MEAToolBar1.TextoBuscar = "Buscar"
        'Me.MEAToolBar1.TextoCancelar = "Cancelar"
        'Me.MEAToolBar1.TextoEditar = "Editar"
        'Me.MEAToolBar1.TextoGuardar = "Guardar"
        'Me.MEAToolBar1.TextoImprimir = "Imprimir"
        'Me.MEAToolBar1.TextoLimpiar = "Limpiar"
        'Me.MEAToolBar1.TextoNuevo = "Nuevo"
        'Me.MEAToolBar1.TextoSalir = "Salir"
        '
        'lblTema
        '
        Me.lblTema.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTema.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTema.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTema.ForeColor = System.Drawing.Color.White
        Me.lblTema.Location = New System.Drawing.Point(49, 0)
        Me.lblTema.Name = "lblTema"
        Me.lblTema.Size = New System.Drawing.Size(606, 29)
        Me.lblTema.TabIndex = 13
        Me.lblTema.Text = "ABC DE TIPOS DE MOVIMIENTOS BANCARIOS"
        Me.lblTema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pan
        '
        Me.pan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pan.Controls.Add(Me.lblEstatus)
        Me.pan.Controls.Add(Me.txtObservacion)
        Me.pan.Controls.Add(Me.dtpFecha)
        Me.pan.Controls.Add(Me.txtDescripcion)
        Me.pan.Controls.Add(Me.txtCodigo)
        Me.pan.Controls.Add(Me.txtDescripcionCorta)
        Me.pan.Controls.Add(Me.label5)
        Me.pan.Controls.Add(Me.label4)
        Me.pan.Controls.Add(Me.label3)
        Me.pan.Controls.Add(Me.label2)
        Me.pan.Controls.Add(Me.label1)
        Me.pan.Location = New System.Drawing.Point(52, 34)
        Me.pan.Name = "pan"
        Me.pan.Size = New System.Drawing.Size(595, 156)
        Me.pan.TabIndex = 14
        '
        'lblEstatus
        '
        Me.lblEstatus.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(465, 12)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(122, 21)
        Me.lblEstatus.TabIndex = 0
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtObservacion
        '
        Me.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacion.Location = New System.Drawing.Point(114, 92)
        Me.txtObservacion.MaxLength = 250
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(474, 53)
        Me.txtObservacion.TabIndex = 3
        '
        'dtpFecha
        '
        Me.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(348, 13)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(103, 20)
        Me.dtpFecha.TabIndex = 0
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(114, 40)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(474, 20)
        Me.txtDescripcion.TabIndex = 1
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(114, 14)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'txtDescripcionCorta
        '
        Me.txtDescripcionCorta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionCorta.Location = New System.Drawing.Point(114, 66)
        Me.txtDescripcionCorta.MaxLength = 15
        Me.txtDescripcionCorta.Name = "txtDescripcionCorta"
        Me.txtDescripcionCorta.Size = New System.Drawing.Size(237, 20)
        Me.txtDescripcionCorta.TabIndex = 2
        '
        'label5
        '
        Me.label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(302, 17)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(40, 13)
        Me.label5.TabIndex = 4
        Me.label5.Text = "Fecha:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(8, 101)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(87, 13)
        Me.label4.TabIndex = 3
        Me.label4.Text = "Observaciones : "
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(8, 69)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(100, 13)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Descripción Corta : "
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(8, 43)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(72, 13)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Descripción : "
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(8, 17)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(49, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Código : "
        '
        'gpo
        '
        Me.gpo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpo.Controls.Add(Me.Label11)
        Me.gpo.Controls.Add(Me.Txtfiltro)
        Me.gpo.Controls.Add(Me.Datagrid)
        Me.gpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpo.ForeColor = System.Drawing.Color.Blue
        Me.gpo.Location = New System.Drawing.Point(52, 196)
        Me.gpo.Name = "gpo"
        Me.gpo.Size = New System.Drawing.Size(595, 313)
        Me.gpo.TabIndex = 15
        Me.gpo.TabStop = False
        Me.gpo.Text = "Tipos de Movimientos Bancarios Registrados"
        '
        'Txtfiltro
        '
        Me.Txtfiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtfiltro.Location = New System.Drawing.Point(102, 19)
        Me.Txtfiltro.Name = "Txtfiltro"
        Me.Txtfiltro.Size = New System.Drawing.Size(157, 20)
        Me.Txtfiltro.TabIndex = 0
        '
        'Datagrid
        '
        Me.Datagrid.AllowUserToAddRows = False
        Me.Datagrid.AllowUserToDeleteRows = False
        Me.Datagrid.AllowUserToResizeRows = False
        Me.Datagrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Datagrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datagrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.Descripcion, Me.Descripcioncorta, Me.observaciones, Me.Estatus})
        Me.Datagrid.Location = New System.Drawing.Point(6, 48)
        Me.Datagrid.Name = "Datagrid"
        Me.Datagrid.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Datagrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Datagrid.RowHeadersVisible = False
        Me.Datagrid.RowHeadersWidth = 30
        Me.Datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Datagrid.Size = New System.Drawing.Size(582, 259)
        Me.Datagrid.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(17, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Buscar:"
        '
        'codigo
        '
        Me.codigo.DataPropertyName = "Codigo"
        Me.codigo.HeaderText = "Código"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 150
        '
        'Descripcioncorta
        '
        Me.Descripcioncorta.DataPropertyName = "DescripcionCorta"
        Me.Descripcioncorta.HeaderText = "Descripción Corta"
        Me.Descripcioncorta.Name = "Descripcioncorta"
        Me.Descripcioncorta.ReadOnly = True
        '
        'observaciones
        '
        Me.observaciones.DataPropertyName = "Observaciones"
        Me.observaciones.HeaderText = "Observaciones"
        Me.observaciones.Name = "observaciones"
        Me.observaciones.ReadOnly = True
        Me.observaciones.Width = 130
        '
        'Estatus
        '
        Me.Estatus.DataPropertyName = "Estatus"
        Me.Estatus.HeaderText = "Estatus"
        Me.Estatus.Name = "Estatus"
        Me.Estatus.ReadOnly = True
        '
        'TipoMovimientosBanForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 514)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.Controls.Add(Me.lblTema)
        Me.Controls.Add(Me.pan)
        Me.Controls.Add(Me.gpo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "TipoMovimientosBanForm"
        Me.Text = "ABC  de Tipos de Movimientos Bancarios"
        Me.pan.ResumeLayout(False)
        Me.pan.PerformLayout()
        Me.gpo.ResumeLayout(False)
        Me.gpo.PerformLayout()
        CType(Me.Datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Private WithEvents lblTema As System.Windows.Forms.Label
    Private WithEvents pan As System.Windows.Forms.Panel
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Private WithEvents txtObservacion As System.Windows.Forms.TextBox
    Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Private WithEvents txtCodigo As System.Windows.Forms.TextBox
    Private WithEvents txtDescripcionCorta As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents gpo As System.Windows.Forms.GroupBox
    Friend WithEvents Txtfiltro As System.Windows.Forms.TextBox
    Private WithEvents Datagrid As System.Windows.Forms.DataGridView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcioncorta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents observaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estatus As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
