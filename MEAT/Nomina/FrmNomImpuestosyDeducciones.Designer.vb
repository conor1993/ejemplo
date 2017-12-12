<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNomImpuestosyDeducciones
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgDistribucion = New System.Windows.Forms.DataGridView
        Me.ImporteMayor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CuotaFija = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Porcentaje = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDescripcion = New IntegraLab.Controles.TextBoxMejorado
        Me.txtCodigo = New IntegraLab.Controles.TextBoxMejorado
        Me.Label17 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgDistribucion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgDistribucion)
        Me.GroupBox1.Location = New System.Drawing.Point(59, 107)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(696, 322)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Distribución"
        '
        'dgDistribucion
        '
        Me.dgDistribucion.AllowUserToAddRows = False
        Me.dgDistribucion.AllowUserToDeleteRows = False
        Me.dgDistribucion.AllowUserToResizeRows = False
        Me.dgDistribucion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDistribucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDistribucion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ImporteMayor, Me.CuotaFija, Me.Porcentaje})
        Me.dgDistribucion.Location = New System.Drawing.Point(6, 19)
        Me.dgDistribucion.Name = "dgDistribucion"
        Me.dgDistribucion.ReadOnly = True
        Me.dgDistribucion.RowHeadersVisible = False
        Me.dgDistribucion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDistribucion.Size = New System.Drawing.Size(684, 287)
        Me.dgDistribucion.TabIndex = 1
        '
        'ImporteMayor
        '
        Me.ImporteMayor.HeaderText = "Importe Mayor"
        Me.ImporteMayor.Name = "ImporteMayor"
        Me.ImporteMayor.ReadOnly = True
        '
        'CuotaFija
        '
        Me.CuotaFija.HeaderText = "Cuota Fija"
        Me.CuotaFija.Name = "CuotaFija"
        Me.CuotaFija.ReadOnly = True
        '
        'Porcentaje
        '
        Me.Porcentaje.HeaderText = "Procentaje"
        Me.Porcentaje.Name = "Porcentaje"
        Me.Porcentaje.ReadOnly = True
        '
        'lblEstatus
        '
        Me.lblEstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(598, 55)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(99, 21)
        Me.lblEstatus.TabIndex = 48
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEstatus.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Descripción :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Codigo :"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.ComboBoxEnlazado = Nothing
        Me.txtDescripcion.Decimales = 0
        Me.txtDescripcion.Location = New System.Drawing.Point(160, 81)
        Me.txtDescripcion.MensajeCombo = "Seleccionar un item..."
        Me.txtDescripcion.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.SiguienteControl = Nothing
        Me.txtDescripcion.Size = New System.Drawing.Size(321, 20)
        Me.txtDescripcion.TabIndex = 44
        Me.txtDescripcion.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'txtCodigo
        '
        Me.txtCodigo.ComboBoxEnlazado = Nothing
        Me.txtCodigo.Decimales = 0
        Me.txtCodigo.Location = New System.Drawing.Point(160, 55)
        Me.txtCodigo.MensajeCombo = "Seleccionar un item..."
        Me.txtCodigo.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.SiguienteControl = Nothing
        Me.txtCodigo.Size = New System.Drawing.Size(50, 20)
        Me.txtCodigo.TabIndex = 43
        Me.txtCodigo.TipoValor = IntegraLab.Controles.TextBoxMejorado.TipoValorEnum.Cadena
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(717, 32)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "Distribución de Cuotas (Impuestos/Credito al salario/Vacaciones/Deducciones)"
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
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 451)
        Me.mtb.TabIndex = 41
        '
        'FrmNomImpuestosyDeducciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 451)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblEstatus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.Name = "FrmNomImpuestosyDeducciones"
        Me.Text = "Distribución de Cuotas (Impuestos/Credito al salario/Vacaciones/Deducciones)"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgDistribucion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgDistribucion As System.Windows.Forms.DataGridView
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtCodigo As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents ImporteMayor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CuotaFija As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Porcentaje As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
