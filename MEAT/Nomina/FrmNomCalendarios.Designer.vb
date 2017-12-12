<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNomCalendarios
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
        Me.dgLista = New System.Windows.Forms.DataGridView
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDescripcion = New IntegraLab.Controles.TextBoxMejorado
        Me.txtCodigo = New IntegraLab.Controles.TextBoxMejorado
        Me.Label17 = New System.Windows.Forms.Label
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar
        Me.Periodo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaInicial = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaFinal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Dias = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgLista)
        Me.GroupBox1.Location = New System.Drawing.Point(59, 107)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(696, 322)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Distribución"
        '
        'dgLista
        '
        Me.dgLista.AllowUserToAddRows = False
        Me.dgLista.AllowUserToDeleteRows = False
        Me.dgLista.AllowUserToResizeRows = False
        Me.dgLista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Periodo, Me.FechaInicial, Me.FechaFinal, Me.Dias})
        Me.dgLista.Location = New System.Drawing.Point(6, 19)
        Me.dgLista.Name = "dgLista"
        Me.dgLista.ReadOnly = True
        Me.dgLista.RowHeadersVisible = False
        Me.dgLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgLista.Size = New System.Drawing.Size(684, 287)
        Me.dgLista.TabIndex = 1
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
        Me.lblEstatus.TabIndex = 56
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
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Descripción :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 54
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
        Me.txtDescripcion.TabIndex = 53
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
        Me.txtCodigo.TabIndex = 52
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
        Me.Label17.Size = New System.Drawing.Size(748, 32)
        Me.Label17.TabIndex = 51
        Me.Label17.Text = "Calendarios "
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.MEAToolBar1.MostrarBuscar = True
        Me.MEAToolBar1.MostrarCancelar = True
        Me.MEAToolBar1.MostrarEditar = False
        Me.MEAToolBar1.MostrarGuardar = True
        Me.MEAToolBar1.MostrarImprimir = True
        Me.MEAToolBar1.MostrarLimpiar = True
        Me.MEAToolBar1.MostrarNuevo = True
        Me.MEAToolBar1.MostrarSalir = True
        Me.MEAToolBar1.Name = "MEAToolBar1"
        Me.MEAToolBar1.ShowToolTips = True
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 513)
        Me.MEAToolBar1.TabIndex = 50
        '
        'Periodo
        '
        Me.Periodo.HeaderText = "Periodo"
        Me.Periodo.Name = "Periodo"
        Me.Periodo.ReadOnly = True
        '
        'FechaInicial
        '
        Me.FechaInicial.HeaderText = "Fecha Inicial"
        Me.FechaInicial.Name = "FechaInicial"
        Me.FechaInicial.ReadOnly = True
        '
        'FechaFinal
        '
        Me.FechaFinal.HeaderText = "Fecha Final"
        Me.FechaFinal.Name = "FechaFinal"
        Me.FechaFinal.ReadOnly = True
        '
        'Dias
        '
        Me.Dias.HeaderText = "Dias"
        Me.Dias.Name = "Dias"
        Me.Dias.ReadOnly = True
        '
        'FrmNomCalendarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 513)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblEstatus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.Name = "FrmNomCalendarios"
        Me.Text = "Calendarios"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgLista As System.Windows.Forms.DataGridView
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents txtCodigo As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents Periodo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaInicial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaFinal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dias As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
