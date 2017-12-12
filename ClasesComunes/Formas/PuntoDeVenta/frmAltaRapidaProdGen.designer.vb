<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAltaRapidaProdGen
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
        Me.components = New System.ComponentModel.Container()
        Me.lblTema = New System.Windows.Forms.Label()
        Me.Pan = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtIeps = New System.Windows.Forms.TextBox()
        Me.txtRegistrosql = New System.Windows.Forms.TextBox()
        Me.txtUltimoCosto = New System.Windows.Forms.TextBox()
        Me.chkIVA = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbMarcas = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDescCorta = New System.Windows.Forms.TextBox()
        Me.cmbUnidadesMedida = New System.Windows.Forms.ComboBox()
        Me.cmbFamilia = New System.Windows.Forms.ComboBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtExistenciaActual = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtCodigoBarra = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblestatus = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mtb = New MEAToolBar.MEAToolBar()
        Me.clmPrjNutriente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmNutriente = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ProductosPaqueteC = New ClasesNegocio.ProductosPaqueteCollection()
        Me.ProdCostoIndirectoC = New ClasesNegocio.ProdCostoIndirectoCollection()
        Me.gbInvenario = New System.Windows.Forms.GroupBox()
        Me.txtNuevaExistencia = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Pan.SuspendLayout()
        Me.gbInvenario.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTema
        '
        Me.lblTema.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTema.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTema.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTema.ForeColor = System.Drawing.Color.Transparent
        Me.lblTema.Location = New System.Drawing.Point(50, 0)
        Me.lblTema.Name = "lblTema"
        Me.lblTema.Size = New System.Drawing.Size(598, 29)
        Me.lblTema.TabIndex = 34
        Me.lblTema.Text = "ALTA RÁPIDA DE PRODUCTOS"
        Me.lblTema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Pan
        '
        Me.Pan.Controls.Add(Me.Label8)
        Me.Pan.Controls.Add(Me.txtIeps)
        Me.Pan.Controls.Add(Me.txtRegistrosql)
        Me.Pan.Controls.Add(Me.txtUltimoCosto)
        Me.Pan.Controls.Add(Me.chkIVA)
        Me.Pan.Controls.Add(Me.Label7)
        Me.Pan.Controls.Add(Me.cmbMarcas)
        Me.Pan.Controls.Add(Me.Label17)
        Me.Pan.Controls.Add(Me.Label13)
        Me.Pan.Controls.Add(Me.txtDescCorta)
        Me.Pan.Controls.Add(Me.cmbUnidadesMedida)
        Me.Pan.Controls.Add(Me.cmbFamilia)
        Me.Pan.Controls.Add(Me.txtDescripcion)
        Me.Pan.Controls.Add(Me.Label5)
        Me.Pan.Controls.Add(Me.Label3)
        Me.Pan.Controls.Add(Me.Label2)
        Me.Pan.Location = New System.Drawing.Point(56, 87)
        Me.Pan.Name = "Pan"
        Me.Pan.Size = New System.Drawing.Size(584, 191)
        Me.Pan.TabIndex = 35
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(283, 167)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "% IEPS:"
        '
        'txtIeps
        '
        Me.txtIeps.Location = New System.Drawing.Point(334, 163)
        Me.txtIeps.Name = "txtIeps"
        Me.txtIeps.Size = New System.Drawing.Size(57, 20)
        Me.txtIeps.TabIndex = 80
        Me.txtIeps.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRegistrosql
        '
        Me.txtRegistrosql.Location = New System.Drawing.Point(557, 75)
        Me.txtRegistrosql.Multiline = True
        Me.txtRegistrosql.Name = "txtRegistrosql"
        Me.txtRegistrosql.Size = New System.Drawing.Size(10, 105)
        Me.txtRegistrosql.TabIndex = 79
        Me.txtRegistrosql.Visible = False
        '
        'txtUltimoCosto
        '
        Me.txtUltimoCosto.Location = New System.Drawing.Point(117, 164)
        Me.txtUltimoCosto.Name = "txtUltimoCosto"
        Me.txtUltimoCosto.Size = New System.Drawing.Size(79, 20)
        Me.txtUltimoCosto.TabIndex = 7
        Me.txtUltimoCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkIVA
        '
        Me.chkIVA.AutoSize = True
        Me.chkIVA.Location = New System.Drawing.Point(202, 166)
        Me.chkIVA.Name = "chkIVA"
        Me.chkIVA.Size = New System.Drawing.Size(75, 17)
        Me.chkIVA.TabIndex = 8
        Me.chkIVA.Text = "Aplica IVA"
        Me.chkIVA.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Marca:"
        '
        'cmbMarcas
        '
        Me.cmbMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMarcas.FormattingEnabled = True
        Me.cmbMarcas.Location = New System.Drawing.Point(117, 107)
        Me.cmbMarcas.Name = "cmbMarcas"
        Me.cmbMarcas.Size = New System.Drawing.Size(224, 21)
        Me.cmbMarcas.TabIndex = 4
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(19, 167)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(43, 13)
        Me.Label17.TabIndex = 78
        Me.Label17.Text = "Precio :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(17, 57)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 13)
        Me.Label13.TabIndex = 66
        Me.Label13.Text = "Descripción Corta:"
        '
        'txtDescCorta
        '
        Me.txtDescCorta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescCorta.Location = New System.Drawing.Point(117, 54)
        Me.txtDescCorta.Name = "txtDescCorta"
        Me.txtDescCorta.Size = New System.Drawing.Size(328, 20)
        Me.txtDescCorta.TabIndex = 2
        '
        'cmbUnidadesMedida
        '
        Me.cmbUnidadesMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUnidadesMedida.FormattingEnabled = True
        Me.cmbUnidadesMedida.Location = New System.Drawing.Point(117, 134)
        Me.cmbUnidadesMedida.Name = "cmbUnidadesMedida"
        Me.cmbUnidadesMedida.Size = New System.Drawing.Size(224, 21)
        Me.cmbUnidadesMedida.TabIndex = 5
        '
        'cmbFamilia
        '
        Me.cmbFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFamilia.FormattingEnabled = True
        Me.cmbFamilia.Location = New System.Drawing.Point(117, 80)
        Me.cmbFamilia.Name = "cmbFamilia"
        Me.cmbFamilia.Size = New System.Drawing.Size(224, 21)
        Me.cmbFamilia.TabIndex = 3
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(117, 7)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDescripcion.Size = New System.Drawing.Size(328, 41)
        Me.txtDescripcion.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Unidad de Medida :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Familia :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Descripción:"
        '
        'txtExistenciaActual
        '
        Me.txtExistenciaActual.Location = New System.Drawing.Point(115, 38)
        Me.txtExistenciaActual.Name = "txtExistenciaActual"
        Me.txtExistenciaActual.ReadOnly = True
        Me.txtExistenciaActual.Size = New System.Drawing.Size(104, 20)
        Me.txtExistenciaActual.TabIndex = 85
        Me.txtExistenciaActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Existencia actual:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(75, 68)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(91, 13)
        Me.Label19.TabIndex = 83
        Me.Label19.Text = "Código de Barras:"
        '
        'txtCodigoBarra
        '
        Me.txtCodigoBarra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoBarra.Location = New System.Drawing.Point(175, 65)
        Me.txtCodigoBarra.Name = "txtCodigoBarra"
        Me.txtCodigoBarra.Size = New System.Drawing.Size(222, 20)
        Me.txtCodigoBarra.TabIndex = 6
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(411, 40)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(92, 20)
        Me.dtpFecha.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(323, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "Fecha de Alta:"
        '
        'lblestatus
        '
        Me.lblestatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblestatus.BackColor = System.Drawing.Color.Navy
        Me.lblestatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblestatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblestatus.ForeColor = System.Drawing.Color.White
        Me.lblestatus.Location = New System.Drawing.Point(512, 36)
        Me.lblestatus.Name = "lblestatus"
        Me.lblestatus.Size = New System.Drawing.Size(121, 24)
        Me.lblestatus.TabIndex = 64
        Me.lblestatus.Text = "ESTATUS"
        Me.lblestatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(175, 40)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.TabStop = False
        Me.txtCodigo.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Codigo:"
        Me.Label1.Visible = False
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
        Me.mtb.MaximumSize = New System.Drawing.Size(50, 350)
        Me.mtb.MostrarBorrar = False
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 350)
        Me.mtb.TabIndex = 0
        '
        'clmPrjNutriente
        '
        Me.clmPrjNutriente.DataPropertyName = "PorcentajeNutriente"
        Me.clmPrjNutriente.HeaderText = "Porcentaje"
        Me.clmPrjNutriente.Name = "clmPrjNutriente"
        '
        'clmNutriente
        '
        Me.clmNutriente.DataPropertyName = "IdNutriente"
        Me.clmNutriente.HeaderText = "Nutriente"
        Me.clmNutriente.Name = "clmNutriente"
        Me.clmNutriente.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmNutriente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.clmNutriente.Width = 300
        '
        'ProductosPaqueteC
        '
        Me.ProductosPaqueteC.AllowEdit = True
        Me.ProductosPaqueteC.AllowNew = True
        Me.ProductosPaqueteC.AllowRemove = True
        Me.ProductosPaqueteC.MaximoElementosSeleccionados = 1
        Me.ProductosPaqueteC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.ProductosPaqueteC.MostrarAlertas = False
        Me.ProductosPaqueteC.Name = ""
        Me.ProductosPaqueteC.RaiseListChangedEvents = True
        Me.ProductosPaqueteC.Transaction = Nothing
        '
        'ProdCostoIndirectoC
        '
        Me.ProdCostoIndirectoC.AllowEdit = True
        Me.ProdCostoIndirectoC.AllowNew = True
        Me.ProdCostoIndirectoC.AllowRemove = True
        Me.ProdCostoIndirectoC.Name = ""
        Me.ProdCostoIndirectoC.RaiseListChangedEvents = True
        '
        'gbInvenario
        '
        Me.gbInvenario.Controls.Add(Me.txtNuevaExistencia)
        Me.gbInvenario.Controls.Add(Me.Label6)
        Me.gbInvenario.Controls.Add(Me.txtExistenciaActual)
        Me.gbInvenario.Controls.Add(Me.Label4)
        Me.gbInvenario.Location = New System.Drawing.Point(56, 284)
        Me.gbInvenario.Name = "gbInvenario"
        Me.gbInvenario.Size = New System.Drawing.Size(584, 87)
        Me.gbInvenario.TabIndex = 84
        Me.gbInvenario.TabStop = False
        Me.gbInvenario.Text = "Inventario"
        '
        'txtNuevaExistencia
        '
        Me.txtNuevaExistencia.Location = New System.Drawing.Point(350, 38)
        Me.txtNuevaExistencia.Name = "txtNuevaExistencia"
        Me.txtNuevaExistencia.Size = New System.Drawing.Size(104, 20)
        Me.txtNuevaExistencia.TabIndex = 87
        Me.txtNuevaExistencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(251, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Nueva Existencia:"
        '
        'frmAltaRapidaProdGen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 384)
        Me.Controls.Add(Me.gbInvenario)
        Me.Controls.Add(Me.Pan)
        Me.Controls.Add(Me.lblTema)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblestatus)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCodigoBarra)
        Me.Controls.Add(Me.dtpFecha)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmAltaRapidaProdGen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta Rápida de Productos"
        Me.Pan.ResumeLayout(False)
        Me.Pan.PerformLayout()
        Me.gbInvenario.ResumeLayout(False)
        Me.gbInvenario.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Private WithEvents lblTema As System.Windows.Forms.Label
    Friend WithEvents PresentacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeObtieneMermasDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IngredienteDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SubLineaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeRecibeParcialDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ProductoGeneralDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MaterialEnvaseDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IsNewDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SeRecibeSinFacturaDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SeManejaPorLotesDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DescCortaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnidadMedidaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaBajaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObservacionBajaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoUsuarioBajaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PiezasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiasminCaducidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodigoMotivoBajaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeFacturaDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FechaAltaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeFacturaSinExistenciaDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CodigoUsuarioAltaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MezclaDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pan As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDescCorta As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblestatus As System.Windows.Forms.Label
    Friend WithEvents cmbUnidadesMedida As System.Windows.Forms.ComboBox
    Friend WithEvents cmbFamilia As System.Windows.Forms.ComboBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProductosPaqueteC As ClasesNegocio.ProductosPaqueteCollection
    Friend WithEvents ProdCostoIndirectoC As ClasesNegocio.ProdCostoIndirectoCollection
    Friend WithEvents cmbMarcas As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents clmPrjNutriente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmNutriente As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoBarra As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents chkIVA As System.Windows.Forms.CheckBox
    Friend WithEvents txtUltimoCosto As System.Windows.Forms.TextBox
    Friend WithEvents txtExistenciaActual As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gbInvenario As System.Windows.Forms.GroupBox
    Friend WithEvents txtNuevaExistencia As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtRegistrosql As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtIeps As System.Windows.Forms.TextBox
    'Friend WithEvents ProdCollection As ClasesNegocio.ProductosCollectionClass

End Class
