<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLineas
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
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.label5 = New System.Windows.Forms.Label
        Me.label4 = New System.Windows.Forms.Label
        Me.txtObservaciones = New System.Windows.Forms.TextBox
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.txtDescCorta = New System.Windows.Forms.TextBox
        Me.label3 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.panel1 = New System.Windows.Forms.Panel
        Me.label1 = New System.Windows.Forms.Label
        Me.lblTema = New System.Windows.Forms.Label
        Me.gbDetalles = New System.Windows.Forms.GroupBox
        Me.dgvLineasReg = New System.Windows.Forms.DataGridView
        Me.ClmCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmDescripcionCorta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmFechaAlta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LineaC = New ClasesNegocio.LineaCollectionClass
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar
        Me.panel1.SuspendLayout()
        Me.gbDetalles.SuspendLayout()
        CType(Me.dgvLineasReg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(117, 7)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(14, 36)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(97, 13)
        Me.label5.TabIndex = 4
        Me.label5.Text = "Descripción Corta :"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(14, 88)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(87, 13)
        Me.label4.TabIndex = 3
        Me.label4.Text = "Observaciones : "
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Location = New System.Drawing.Point(117, 85)
        Me.txtObservaciones.MaxLength = 250
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(517, 66)
        Me.txtObservaciones.TabIndex = 3
        '
        'lblEstatus
        '
        Me.lblEstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblEstatus.Location = New System.Drawing.Point(569, 7)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(91, 21)
        Me.lblEstatus.TabIndex = 27
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpFecha
        '
        Me.dtpFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(446, 7)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(100, 20)
        Me.dtpFecha.TabIndex = 4
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(117, 59)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(483, 20)
        Me.txtDescripcion.TabIndex = 2
        '
        'txtDescCorta
        '
        Me.txtDescCorta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescCorta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescCorta.Location = New System.Drawing.Point(117, 33)
        Me.txtDescCorta.MaxLength = 15
        Me.txtDescCorta.Name = "txtDescCorta"
        Me.txtDescCorta.Size = New System.Drawing.Size(213, 20)
        Me.txtDescCorta.TabIndex = 1
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(14, 62)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(69, 13)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Descripción :"
        '
        'label2
        '
        Me.label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(363, 11)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(82, 13)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Fecha de Alta : "
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.txtObservaciones)
        Me.panel1.Controls.Add(Me.lblEstatus)
        Me.panel1.Controls.Add(Me.dtpFecha)
        Me.panel1.Controls.Add(Me.txtDescripcion)
        Me.panel1.Controls.Add(Me.txtDescCorta)
        Me.panel1.Controls.Add(Me.txtCodigo)
        Me.panel1.Controls.Add(Me.label5)
        Me.panel1.Controls.Add(Me.label4)
        Me.panel1.Controls.Add(Me.label3)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Location = New System.Drawing.Point(53, 34)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(666, 162)
        Me.panel1.TabIndex = 6
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(14, 11)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(49, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Código : "
        '
        'lblTema
        '
        Me.lblTema.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTema.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTema.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTema.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTema.Location = New System.Drawing.Point(0, 0)
        Me.lblTema.Name = "lblTema"
        Me.lblTema.Size = New System.Drawing.Size(716, 29)
        Me.lblTema.TabIndex = 8
        Me.lblTema.Text = "CATÁLOGO DE FAMILIAS"
        Me.lblTema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbDetalles
        '
        Me.gbDetalles.Controls.Add(Me.dgvLineasReg)
        Me.gbDetalles.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDetalles.ForeColor = System.Drawing.Color.Blue
        Me.gbDetalles.Location = New System.Drawing.Point(53, 202)
        Me.gbDetalles.Name = "gbDetalles"
        Me.gbDetalles.Size = New System.Drawing.Size(667, 265)
        Me.gbDetalles.TabIndex = 7
        Me.gbDetalles.TabStop = False
        Me.gbDetalles.Text = "Familias Registradas"
        '
        'dgvLineasReg
        '
        Me.dgvLineasReg.AllowUserToAddRows = False
        Me.dgvLineasReg.AllowUserToDeleteRows = False
        Me.dgvLineasReg.AllowUserToResizeRows = False
        Me.dgvLineasReg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvLineasReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLineasReg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClmCodigo, Me.ClmDescripcion, Me.ClmDescripcionCorta, Me.ClmObservaciones, Me.ClmFechaAlta, Me.ClmEstatus})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLineasReg.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLineasReg.Location = New System.Drawing.Point(6, 23)
        Me.dgvLineasReg.Name = "dgvLineasReg"
        Me.dgvLineasReg.ReadOnly = True
        Me.dgvLineasReg.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvLineasReg.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLineasReg.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvLineasReg.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvLineasReg.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvLineasReg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLineasReg.Size = New System.Drawing.Size(655, 236)
        Me.dgvLineasReg.TabIndex = 0
        '
        'ClmCodigo
        '
        Me.ClmCodigo.HeaderText = "Código"
        Me.ClmCodigo.Name = "ClmCodigo"
        Me.ClmCodigo.ReadOnly = True
        Me.ClmCodigo.Width = 80
        '
        'ClmDescripcion
        '
        Me.ClmDescripcion.HeaderText = "Descripción"
        Me.ClmDescripcion.Name = "ClmDescripcion"
        Me.ClmDescripcion.ReadOnly = True
        Me.ClmDescripcion.Width = 250
        '
        'ClmDescripcionCorta
        '
        Me.ClmDescripcionCorta.HeaderText = "Descripción Corta"
        Me.ClmDescripcionCorta.Name = "ClmDescripcionCorta"
        Me.ClmDescripcionCorta.ReadOnly = True
        Me.ClmDescripcionCorta.Width = 200
        '
        'ClmObservaciones
        '
        Me.ClmObservaciones.HeaderText = "Observaciones"
        Me.ClmObservaciones.Name = "ClmObservaciones"
        Me.ClmObservaciones.ReadOnly = True
        Me.ClmObservaciones.Width = 200
        '
        'ClmFechaAlta
        '
        Me.ClmFechaAlta.HeaderText = "Fecha de Alta"
        Me.ClmFechaAlta.Name = "ClmFechaAlta"
        Me.ClmFechaAlta.ReadOnly = True
        Me.ClmFechaAlta.Width = 150
        '
        'ClmEstatus
        '
        Me.ClmEstatus.HeaderText = "Estatus"
        Me.ClmEstatus.Name = "ClmEstatus"
        Me.ClmEstatus.ReadOnly = True
        Me.ClmEstatus.Width = 80
        '
        'LineaC
        '
        Me.LineaC.AllowEdit = True
        Me.LineaC.AllowNew = True
        Me.LineaC.AllowRemove = True
        Me.LineaC.Name = ""
        Me.LineaC.RaiseListChangedEvents = True
        '
        'MEAToolBar1
        '
        Me.MEAToolBar1.ButtonSize = New System.Drawing.Size(50, 50)
        Me.MEAToolBar1.Dock = System.Windows.Forms.DockStyle.None
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
        Me.MEAToolBar1.Location = New System.Drawing.Point(-1, -27)
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
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 747)
        Me.MEAToolBar1.TabIndex = 5
        '
        'frmLineas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 467)
        Me.Controls.Add(Me.lblTema)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.gbDetalles)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(732, 505)
        Me.MinimumSize = New System.Drawing.Size(732, 505)
        Me.Name = "frmLineas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catálogo de Familias"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.gbDetalles.ResumeLayout(False)
        CType(Me.dgvLineasReg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents txtCodigo As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Private WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Private WithEvents txtDescCorta As System.Windows.Forms.TextBox
    Private WithEvents dgvLineasReg As System.Windows.Forms.DataGridView
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents lblTema As System.Windows.Forms.Label
    Private WithEvents gbDetalles As System.Windows.Forms.GroupBox
    Friend WithEvents LineaC As ClasesNegocio.LineaCollectionClass
    Friend WithEvents ClmCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmDescripcionCorta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmObservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmFechaAlta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
