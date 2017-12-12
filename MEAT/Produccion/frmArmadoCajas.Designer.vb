<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArmadoCajas
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
        Me.Label17 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtFecha = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgDetalle = New System.Windows.Forms.DataGridView
        Me.clmSeleccionado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPiezas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmKilos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFolio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtFolio = New Integralab.Controles.TextBoxMejorado
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBoxMejorado1 = New Integralab.Controles.TextBoxMejorado
        Me.ComboBoxMejorado1 = New Integralab.Controles.ComboBoxMejorado
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label17.Size = New System.Drawing.Size(671, 32)
        Me.Label17.TabIndex = 55
        Me.Label17.Text = "ARMADO DE CAJAS"
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
        Me.mtb.MostrarBorrar = True
        Me.mtb.MostrarBuscar = True
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = True
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 497)
        Me.mtb.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Folio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(199, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Fecha:"
        '
        'dtFecha
        '
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha.Location = New System.Drawing.Point(245, 43)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(90, 20)
        Me.dtFecha.TabIndex = 60
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgDetalle)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(653, 389)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cortes/Productos"
        '
        'dgDetalle
        '
        Me.dgDetalle.AllowUserToAddRows = False
        Me.dgDetalle.AllowUserToDeleteRows = False
        Me.dgDetalle.AllowUserToResizeRows = False
        Me.dgDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmSeleccionado, Me.clmDescripcion, Me.clmPiezas, Me.clmKilos, Me.clmIdProducto, Me.clmFolio})
        Me.dgDetalle.Location = New System.Drawing.Point(6, 19)
        Me.dgDetalle.Name = "dgDetalle"
        Me.dgDetalle.ReadOnly = True
        Me.dgDetalle.RowHeadersVisible = False
        Me.dgDetalle.Size = New System.Drawing.Size(641, 364)
        Me.dgDetalle.TabIndex = 0
        '
        'clmSeleccionado
        '
        Me.clmSeleccionado.HeaderText = ""
        Me.clmSeleccionado.Name = "clmSeleccionado"
        Me.clmSeleccionado.ReadOnly = True
        Me.clmSeleccionado.Width = 30
        '
        'clmDescripcion
        '
        Me.clmDescripcion.HeaderText = "Descripción"
        Me.clmDescripcion.Name = "clmDescripcion"
        Me.clmDescripcion.ReadOnly = True
        Me.clmDescripcion.Width = 250
        '
        'clmPiezas
        '
        Me.clmPiezas.HeaderText = "Piezas"
        Me.clmPiezas.Name = "clmPiezas"
        Me.clmPiezas.ReadOnly = True
        '
        'clmKilos
        '
        Me.clmKilos.HeaderText = "Kilos"
        Me.clmKilos.Name = "clmKilos"
        Me.clmKilos.ReadOnly = True
        '
        'clmIdProducto
        '
        Me.clmIdProducto.HeaderText = "IdProducto"
        Me.clmIdProducto.Name = "clmIdProducto"
        Me.clmIdProducto.ReadOnly = True
        Me.clmIdProducto.Visible = False
        '
        'clmFolio
        '
        Me.clmFolio.HeaderText = "Folio"
        Me.clmFolio.Name = "clmFolio"
        Me.clmFolio.ReadOnly = True
        Me.clmFolio.Visible = False
        '
        'txtFolio
        '
        Me.txtFolio.ComboBoxEnlazado = Nothing
        Me.txtFolio.Decimales = 0
        Me.txtFolio.Location = New System.Drawing.Point(93, 43)
        Me.txtFolio.MensajeCombo = "Seleccionar un item..."
        Me.txtFolio.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.SiguienteControl = Nothing
        Me.txtFolio.Size = New System.Drawing.Size(100, 20)
        Me.txtFolio.TabIndex = 62
        Me.txtFolio.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Corte/Producto:"
        '
        'TextBoxMejorado1
        '
        Me.TextBoxMejorado1.ComboBoxEnlazado = Me.ComboBoxMejorado1
        Me.TextBoxMejorado1.Decimales = 0
        Me.TextBoxMejorado1.Location = New System.Drawing.Point(144, 69)
        Me.TextBoxMejorado1.MensajeCombo = "Seleccionar un corte/producto..."
        Me.TextBoxMejorado1.MensajeNoExiste = "No existe un corte/producto con este código o se encuentra inactivo"
        Me.TextBoxMejorado1.Name = "TextBoxMejorado1"
        Me.TextBoxMejorado1.SiguienteControl = Me.dgDetalle
        Me.TextBoxMejorado1.Size = New System.Drawing.Size(49, 20)
        Me.TextBoxMejorado1.TabIndex = 64
        Me.TextBoxMejorado1.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'ComboBoxMejorado1
        '
        Me.ComboBoxMejorado1.FormattingEnabled = True
        Me.ComboBoxMejorado1.Location = New System.Drawing.Point(199, 69)
        Me.ComboBoxMejorado1.Name = "ComboBoxMejorado1"
        Me.ComboBoxMejorado1.NombreMetodo = Nothing
        Me.ComboBoxMejorado1.Parametros = Nothing
        Me.ComboBoxMejorado1.SiguienteControl = Nothing
        Me.ComboBoxMejorado1.Size = New System.Drawing.Size(398, 21)
        Me.ComboBoxMejorado1.TabIndex = 65
        Me.ComboBoxMejorado1.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.ComboBoxMejorado1.TextBoxEnlazado = Nothing
        '
        'frmArmadoCajas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 497)
        Me.Controls.Add(Me.ComboBoxMejorado1)
        Me.Controls.Add(Me.TextBoxMejorado1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.MaximizeBox = False
        Me.Name = "frmArmadoCajas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Armado de Cajas"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents txtFolio As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents clmSeleccionado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPiezas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmKilos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIdProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFolio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxMejorado1 As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents ComboBoxMejorado1 As IntegraLab.Controles.ComboBoxMejorado
End Class
