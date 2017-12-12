<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPreparacionFormulas
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
        Me.dgvIngredientes = New System.Windows.Forms.DataGridView
        Me.mtbMenu = New MiToolBar.miToolBar
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtFolio = New System.Windows.Forms.TextBox
        Me.txtCantidad = New System.Windows.Forms.TextBox
        Me.txtObservaciones = New System.Windows.Forms.TextBox
        Me.txtCantidadReal = New System.Windows.Forms.TextBox
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.grbCantidadReal = New System.Windows.Forms.GroupBox
        Me.txtUnidad = New System.Windows.Forms.TextBox
        Me.PanelEdicion = New System.Windows.Forms.Panel
        Me.cmbAlmacen = New IntegraLab.Controles.ComboBoxMejorado
        Me.cmbFormula = New IntegraLab.Controles.ComboBoxMejorado
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.clmIngrediente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPorcentaje = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmCantSalida = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgvIngredientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbCantidadReal.SuspendLayout()
        Me.PanelEdicion.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvIngredientes
        '
        Me.dgvIngredientes.AllowUserToAddRows = False
        Me.dgvIngredientes.AllowUserToDeleteRows = False
        Me.dgvIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIngredientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmIngrediente, Me.clmPorcentaje, Me.clmCantidad, Me.clmCantSalida})
        Me.dgvIngredientes.Location = New System.Drawing.Point(54, 232)
        Me.dgvIngredientes.Name = "dgvIngredientes"
        Me.dgvIngredientes.RowHeadersVisible = False
        Me.dgvIngredientes.Size = New System.Drawing.Size(454, 258)
        Me.dgvIngredientes.TabIndex = 0
        '
        'mtbMenu
        '
        Me.mtbMenu.ButtonSize = New System.Drawing.Size(50, 50)
        Me.mtbMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.mtbMenu.DropDownArrows = True
        Me.mtbMenu.HabilitarBorrar = True
        Me.mtbMenu.HabilitarBuscar = True
        Me.mtbMenu.HabilitarCancelar = True
        Me.mtbMenu.HabilitarEditar = True
        Me.mtbMenu.HabilitarGuardar = True
        Me.mtbMenu.HabilitarImprimir = True
        Me.mtbMenu.HabilitarLimpiar = True
        Me.mtbMenu.HabilitarNuevo = True
        Me.mtbMenu.HabilitarSalir = True
        Me.mtbMenu.ImageButtonSize = MiToolBar.miToolBar.ImageButtonSizeEnum.de32
        Me.mtbMenu.Location = New System.Drawing.Point(0, 0)
        Me.mtbMenu.MostrarBorrar = True
        Me.mtbMenu.MostrarBuscar = True
        Me.mtbMenu.MostrarCancelar = True
        Me.mtbMenu.MostrarEditar = True
        Me.mtbMenu.MostrarGuardar = True
        Me.mtbMenu.MostrarImprimir = True
        Me.mtbMenu.MostrarLimpiar = True
        Me.mtbMenu.MostrarNuevo = True
        Me.mtbMenu.MostrarSalir = True
        Me.mtbMenu.Name = "mtbMenu"
        Me.mtbMenu.ShowToolTips = True
        Me.mtbMenu.Size = New System.Drawing.Size(50, 496)
        Me.mtbMenu.TabIndex = 34
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(463, 32)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "Preparación de Fórmulas"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Folio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Almacén:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Fórmula:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Cantidad:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Observaciones:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(180, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Fecha:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(176, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Unidad:"
        '
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(61, 1)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.ReadOnly = True
        Me.txtFolio.Size = New System.Drawing.Size(100, 20)
        Me.txtFolio.TabIndex = 43
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(61, 75)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 45
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(61, 123)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(255, 60)
        Me.txtObservaciones.TabIndex = 47
        '
        'txtCantidadReal
        '
        Me.txtCantidadReal.Location = New System.Drawing.Point(15, 19)
        Me.txtCantidadReal.Name = "txtCantidadReal"
        Me.txtCantidadReal.Size = New System.Drawing.Size(87, 20)
        Me.txtCantidadReal.TabIndex = 48
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(226, 0)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(90, 20)
        Me.dtpFecha.TabIndex = 52
        '
        'grbCantidadReal
        '
        Me.grbCantidadReal.Controls.Add(Me.txtCantidadReal)
        Me.grbCantidadReal.Location = New System.Drawing.Point(324, 123)
        Me.grbCantidadReal.Name = "grbCantidadReal"
        Me.grbCantidadReal.Size = New System.Drawing.Size(115, 53)
        Me.grbCantidadReal.TabIndex = 53
        Me.grbCantidadReal.TabStop = False
        Me.grbCantidadReal.Text = "Cantidad Real"
        '
        'txtUnidad
        '
        Me.txtUnidad.Location = New System.Drawing.Point(226, 75)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.ReadOnly = True
        Me.txtUnidad.Size = New System.Drawing.Size(90, 20)
        Me.txtUnidad.TabIndex = 54
        '
        'PanelEdicion
        '
        Me.PanelEdicion.Controls.Add(Me.Label1)
        Me.PanelEdicion.Controls.Add(Me.grbCantidadReal)
        Me.PanelEdicion.Controls.Add(Me.txtUnidad)
        Me.PanelEdicion.Controls.Add(Me.Label6)
        Me.PanelEdicion.Controls.Add(Me.Label2)
        Me.PanelEdicion.Controls.Add(Me.Label3)
        Me.PanelEdicion.Controls.Add(Me.dtpFecha)
        Me.PanelEdicion.Controls.Add(Me.Label4)
        Me.PanelEdicion.Controls.Add(Me.cmbAlmacen)
        Me.PanelEdicion.Controls.Add(Me.Label5)
        Me.PanelEdicion.Controls.Add(Me.cmbFormula)
        Me.PanelEdicion.Controls.Add(Me.Label7)
        Me.PanelEdicion.Controls.Add(Me.txtObservaciones)
        Me.PanelEdicion.Controls.Add(Me.txtFolio)
        Me.PanelEdicion.Controls.Add(Me.txtCantidad)
        Me.PanelEdicion.Location = New System.Drawing.Point(54, 43)
        Me.PanelEdicion.Name = "PanelEdicion"
        Me.PanelEdicion.Size = New System.Drawing.Size(454, 183)
        Me.PanelEdicion.TabIndex = 55
        '
        'cmbAlmacen
        '
        Me.cmbAlmacen.FormattingEnabled = True
        Me.cmbAlmacen.Location = New System.Drawing.Point(61, 25)
        Me.cmbAlmacen.Name = "cmbAlmacen"
        Me.cmbAlmacen.NombreMetodo = Nothing
        Me.cmbAlmacen.Parametros = Nothing
        Me.cmbAlmacen.SiguienteControl = Nothing
        Me.cmbAlmacen.Size = New System.Drawing.Size(255, 21)
        Me.cmbAlmacen.TabIndex = 51
        Me.cmbAlmacen.Tag = "Seleccione el Almacén"
        Me.cmbAlmacen.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbAlmacen.TextBoxEnlazado = Nothing
        '
        'cmbFormula
        '
        Me.cmbFormula.FormattingEnabled = True
        Me.cmbFormula.Location = New System.Drawing.Point(61, 50)
        Me.cmbFormula.Name = "cmbFormula"
        Me.cmbFormula.NombreMetodo = Nothing
        Me.cmbFormula.Parametros = Nothing
        Me.cmbFormula.SiguienteControl = Nothing
        Me.cmbFormula.Size = New System.Drawing.Size(255, 21)
        Me.cmbFormula.TabIndex = 50
        Me.cmbFormula.Tag = "Selecciona la Fórmula"
        Me.cmbFormula.TeclaParaActualizar = System.Windows.Forms.Keys.F12
        Me.cmbFormula.TextBoxEnlazado = Nothing
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Porcentaje"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 60
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cant. Salida"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 90
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'clmIngrediente
        '
        Me.clmIngrediente.DataPropertyName = "Ingrediente"
        Me.clmIngrediente.HeaderText = "Ingrediente"
        Me.clmIngrediente.Name = "clmIngrediente"
        Me.clmIngrediente.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmIngrediente.Width = 225
        '
        'clmPorcentaje
        '
        Me.clmPorcentaje.DataPropertyName = "Porcentaje"
        Me.clmPorcentaje.HeaderText = "Porcentaje"
        Me.clmPorcentaje.Name = "clmPorcentaje"
        Me.clmPorcentaje.Width = 60
        '
        'clmCantidad
        '
        Me.clmCantidad.HeaderText = "Cantidad"
        Me.clmCantidad.Name = "clmCantidad"
        Me.clmCantidad.Width = 60
        '
        'clmCantSalida
        '
        Me.clmCantSalida.HeaderText = "Cant. Salida"
        Me.clmCantSalida.Name = "clmCantSalida"
        Me.clmCantSalida.Width = 90
        '
        'FrmPreparacionFormulas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 496)
        Me.Controls.Add(Me.PanelEdicion)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtbMenu)
        Me.Controls.Add(Me.dgvIngredientes)
        Me.Name = "FrmPreparacionFormulas"
        Me.Text = "Preparación de Fórmulas"
        CType(Me.dgvIngredientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbCantidadReal.ResumeLayout(False)
        Me.grbCantidadReal.PerformLayout()
        Me.PanelEdicion.ResumeLayout(False)
        Me.PanelEdicion.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvIngredientes As System.Windows.Forms.DataGridView
    Friend WithEvents mtbMenu As MiToolBar.miToolBar
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidadReal As System.Windows.Forms.TextBox
    Friend WithEvents cmbFormula As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents cmbAlmacen As IntegraLab.Controles.ComboBoxMejorado
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents grbCantidadReal As System.Windows.Forms.GroupBox
    Friend WithEvents txtUnidad As System.Windows.Forms.TextBox
    Friend WithEvents PanelEdicion As System.Windows.Forms.Panel
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents clmIngrediente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPorcentaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCantSalida As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
