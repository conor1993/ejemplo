<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusqProductos
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
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DgvDecomisos = New System.Windows.Forms.DataGridView
        Me.ClmSelccion = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ClmLoteSacrificio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmIdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmProducto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmPiezas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPiezasEmbarcadas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPiezasrestantes = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmKilos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmkilosEmbarcados = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmKilosRestantes = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CmbIntroductor = New System.Windows.Forms.ComboBox
        Me.CmbLoteSacrificio = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BrnAceptar = New System.Windows.Forms.Button
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbProducto = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvDecomisos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.mtb.Size = New System.Drawing.Size(50, 610)
        Me.mtb.TabIndex = 51
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(928, 32)
        Me.Label17.TabIndex = 52
        Me.Label17.Text = "BÚSQUEDA DE PRODUCTOS"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DgvDecomisos)
        Me.GroupBox1.Location = New System.Drawing.Point(54, 156)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(907, 414)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Productos Registrados"
        '
        'DgvDecomisos
        '
        Me.DgvDecomisos.AllowUserToAddRows = False
        Me.DgvDecomisos.AllowUserToDeleteRows = False
        Me.DgvDecomisos.AllowUserToResizeRows = False
        Me.DgvDecomisos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvDecomisos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClmSelccion, Me.ClmLoteSacrificio, Me.ClmIdProducto, Me.ClmProducto, Me.ClmPiezas, Me.clmPiezasEmbarcadas, Me.clmPiezasrestantes, Me.ClmKilos, Me.clmkilosEmbarcados, Me.clmKilosRestantes})
        Me.DgvDecomisos.Location = New System.Drawing.Point(6, 19)
        Me.DgvDecomisos.Name = "DgvDecomisos"
        Me.DgvDecomisos.RowHeadersVisible = False
        Me.DgvDecomisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDecomisos.Size = New System.Drawing.Size(895, 389)
        Me.DgvDecomisos.TabIndex = 0
        '
        'ClmSelccion
        '
        Me.ClmSelccion.HeaderText = ""
        Me.ClmSelccion.Name = "ClmSelccion"
        Me.ClmSelccion.Width = 35
        '
        'ClmLoteSacrificio
        '
        Me.ClmLoteSacrificio.DataPropertyName = "LoteSacrificio"
        Me.ClmLoteSacrificio.HeaderText = "Lote Sacrificio"
        Me.ClmLoteSacrificio.Name = "ClmLoteSacrificio"
        Me.ClmLoteSacrificio.ReadOnly = True
        '
        'ClmIdProducto
        '
        Me.ClmIdProducto.DataPropertyName = "IdProducto"
        Me.ClmIdProducto.HeaderText = "Id Producto"
        Me.ClmIdProducto.Name = "ClmIdProducto"
        Me.ClmIdProducto.ReadOnly = True
        Me.ClmIdProducto.Visible = False
        '
        'ClmProducto
        '
        Me.ClmProducto.DataPropertyName = "NombreProducto"
        Me.ClmProducto.HeaderText = "Producto"
        Me.ClmProducto.Name = "ClmProducto"
        Me.ClmProducto.ReadOnly = True
        Me.ClmProducto.Width = 150
        '
        'ClmPiezas
        '
        Me.ClmPiezas.DataPropertyName = "Piezas"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.ClmPiezas.DefaultCellStyle = DataGridViewCellStyle1
        Me.ClmPiezas.HeaderText = "Piezas"
        Me.ClmPiezas.Name = "ClmPiezas"
        Me.ClmPiezas.ReadOnly = True
        Me.ClmPiezas.Width = 61
        '
        'clmPiezasEmbarcadas
        '
        Me.clmPiezasEmbarcadas.DataPropertyName = "PiezasEmbarcadas"
        Me.clmPiezasEmbarcadas.HeaderText = "Piezas Embarcadas"
        Me.clmPiezasEmbarcadas.Name = "clmPiezasEmbarcadas"
        Me.clmPiezasEmbarcadas.ReadOnly = True
        Me.clmPiezasEmbarcadas.Width = 113
        '
        'clmPiezasrestantes
        '
        Me.clmPiezasrestantes.DataPropertyName = "PiezasDisponibles"
        Me.clmPiezasrestantes.HeaderText = "Piezas Restantes"
        Me.clmPiezasrestantes.Name = "clmPiezasrestantes"
        Me.clmPiezasrestantes.ReadOnly = True
        Me.clmPiezasrestantes.Width = 103
        '
        'ClmKilos
        '
        Me.ClmKilos.DataPropertyName = "Kilos"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.ClmKilos.DefaultCellStyle = DataGridViewCellStyle2
        Me.ClmKilos.HeaderText = "Kilos"
        Me.ClmKilos.Name = "ClmKilos"
        Me.ClmKilos.ReadOnly = True
        Me.ClmKilos.Width = 52
        '
        'clmkilosEmbarcados
        '
        Me.clmkilosEmbarcados.DataPropertyName = "KilosEmbarcados"
        Me.clmkilosEmbarcados.HeaderText = "Kilos Embarcardos"
        Me.clmkilosEmbarcados.Name = "clmkilosEmbarcados"
        Me.clmkilosEmbarcados.ReadOnly = True
        Me.clmkilosEmbarcados.Width = 107
        '
        'clmKilosRestantes
        '
        Me.clmKilosRestantes.DataPropertyName = "KilosDisponibles"
        Me.clmKilosRestantes.HeaderText = "Kilos Restantes"
        Me.clmKilosRestantes.Name = "clmKilosRestantes"
        Me.clmKilosRestantes.ReadOnly = True
        Me.clmKilosRestantes.Width = 95
        '
        'CmbIntroductor
        '
        Me.CmbIntroductor.FormattingEnabled = True
        Me.CmbIntroductor.Location = New System.Drawing.Point(152, 76)
        Me.CmbIntroductor.Name = "CmbIntroductor"
        Me.CmbIntroductor.Size = New System.Drawing.Size(324, 21)
        Me.CmbIntroductor.TabIndex = 56
        '
        'CmbLoteSacrificio
        '
        Me.CmbLoteSacrificio.FormattingEnabled = True
        Me.CmbLoteSacrificio.Location = New System.Drawing.Point(152, 42)
        Me.CmbLoteSacrificio.Name = "CmbLoteSacrificio"
        Me.CmbLoteSacrificio.Size = New System.Drawing.Size(121, 21)
        Me.CmbLoteSacrificio.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Introductor :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Lote de Sacrificio :"
        '
        'BrnAceptar
        '
        Me.BrnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrnAceptar.Location = New System.Drawing.Point(810, 575)
        Me.BrnAceptar.Name = "BrnAceptar"
        Me.BrnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BrnAceptar.TabIndex = 58
        Me.BrnAceptar.Text = "Aceptar"
        Me.BrnAceptar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancelar.Location = New System.Drawing.Point(891, 575)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 59
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "LoteSacrificio"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Lote Sacrificio"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IdProducto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Id Producto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NombreProducto"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Producto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Piezas"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn4.HeaderText = "Piezas"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Kilos"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn5.HeaderText = "Kilos"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Producto :"
        '
        'cmbProducto
        '
        Me.cmbProducto.FormattingEnabled = True
        Me.cmbProducto.Location = New System.Drawing.Point(152, 110)
        Me.cmbProducto.Name = "cmbProducto"
        Me.cmbProducto.Size = New System.Drawing.Size(249, 21)
        Me.cmbProducto.TabIndex = 61
        '
        'FrmBusqProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 610)
        Me.Controls.Add(Me.cmbProducto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BrnAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CmbIntroductor)
        Me.Controls.Add(Me.CmbLoteSacrificio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.MaximizeBox = False
        Me.Name = "FrmBusqProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Búsqueda de Productos"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgvDecomisos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DgvDecomisos As System.Windows.Forms.DataGridView
    Friend WithEvents CmbIntroductor As System.Windows.Forms.ComboBox
    Friend WithEvents CmbLoteSacrificio As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BrnAceptar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbProducto As System.Windows.Forms.ComboBox
    Friend WithEvents ClmSelccion As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ClmLoteSacrificio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmIdProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmPiezas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPiezasEmbarcadas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPiezasrestantes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmKilos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmkilosEmbarcados As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmKilosRestantes As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
