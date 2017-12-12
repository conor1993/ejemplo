<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABCPeriodosContables
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
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GrpPeriodos = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.EjercicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PolizaCierreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PolizaTraspazoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaCierreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PeriodosContablesC = New ClasesNegocio.PeriodosContablesCollectionClass
        Me.txtPeriodo = New Integralab.Controles.TextBoxMejorado
        Me.GrpPeriodos.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.mtb.Size = New System.Drawing.Size(50, 437)
        Me.mtb.TabIndex = 1
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(50, 0)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(552, 29)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "PERIODOS CONTABLES"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Periodo Contable:"
        '
        'GrpPeriodos
        '
        Me.GrpPeriodos.Controls.Add(Me.DataGridView1)
        Me.GrpPeriodos.Location = New System.Drawing.Point(55, 82)
        Me.GrpPeriodos.Name = "GrpPeriodos"
        Me.GrpPeriodos.Size = New System.Drawing.Size(535, 343)
        Me.GrpPeriodos.TabIndex = 6
        Me.GrpPeriodos.TabStop = False
        Me.GrpPeriodos.Text = "Periodos Contables"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EjercicioDataGridViewTextBoxColumn, Me.PolizaCierreDataGridViewTextBoxColumn, Me.PolizaTraspazoDataGridViewTextBoxColumn, Me.FechaCierreDataGridViewTextBoxColumn, Me.EstatusDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PeriodosContablesC
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(523, 318)
        Me.DataGridView1.TabIndex = 0
        '
        'EjercicioDataGridViewTextBoxColumn
        '
        Me.EjercicioDataGridViewTextBoxColumn.DataPropertyName = "Ejercicio"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.EjercicioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.EjercicioDataGridViewTextBoxColumn.HeaderText = "Ejercicio"
        Me.EjercicioDataGridViewTextBoxColumn.Name = "EjercicioDataGridViewTextBoxColumn"
        Me.EjercicioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PolizaCierreDataGridViewTextBoxColumn
        '
        Me.PolizaCierreDataGridViewTextBoxColumn.DataPropertyName = "PolizaCierre"
        Me.PolizaCierreDataGridViewTextBoxColumn.HeaderText = "PolizaCierre"
        Me.PolizaCierreDataGridViewTextBoxColumn.Name = "PolizaCierreDataGridViewTextBoxColumn"
        Me.PolizaCierreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PolizaTraspazoDataGridViewTextBoxColumn
        '
        Me.PolizaTraspazoDataGridViewTextBoxColumn.DataPropertyName = "PolizaTraspazo"
        Me.PolizaTraspazoDataGridViewTextBoxColumn.HeaderText = "Poliza Traspaso"
        Me.PolizaTraspazoDataGridViewTextBoxColumn.Name = "PolizaTraspazoDataGridViewTextBoxColumn"
        Me.PolizaTraspazoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaCierreDataGridViewTextBoxColumn
        '
        Me.FechaCierreDataGridViewTextBoxColumn.DataPropertyName = "FechaCierre"
        Me.FechaCierreDataGridViewTextBoxColumn.HeaderText = "Fecha Cierre"
        Me.FechaCierreDataGridViewTextBoxColumn.Name = "FechaCierreDataGridViewTextBoxColumn"
        Me.FechaCierreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstatusDataGridViewTextBoxColumn
        '
        Me.EstatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.HeaderText = "Estatus"
        Me.EstatusDataGridViewTextBoxColumn.Name = "EstatusDataGridViewTextBoxColumn"
        Me.EstatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PeriodosContablesC
        '
        Me.PeriodosContablesC.AllowEdit = True
        Me.PeriodosContablesC.AllowNew = True
        Me.PeriodosContablesC.AllowRemove = True
        Me.PeriodosContablesC.MaximoElementosSeleccionados = 1
        Me.PeriodosContablesC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.PeriodosContablesC.MostrarAlertas = False
        Me.PeriodosContablesC.Name = Nothing
        Me.PeriodosContablesC.RaiseListChangedEvents = True
        Me.PeriodosContablesC.Transaction = Nothing
        '
        'txtPeriodo
        '
        Me.txtPeriodo.ComboBoxEnlazado = Nothing
        Me.txtPeriodo.Decimales = 0
        Me.txtPeriodo.Location = New System.Drawing.Point(149, 45)
        Me.txtPeriodo.MaxLength = 3000
        Me.txtPeriodo.MensajeCombo = "Seleccionar un item..."
        Me.txtPeriodo.MensajeNoExiste = "No existe un item con este código o se encuentra inactivo"
        Me.txtPeriodo.Name = "txtPeriodo"
        Me.txtPeriodo.SiguienteControl = Nothing
        Me.txtPeriodo.Size = New System.Drawing.Size(80, 20)
        Me.txtPeriodo.TabIndex = 3
        Me.txtPeriodo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPeriodo.TipoValor = Integralab.Controles.TextBoxMejorado.TipoValorEnum.Numerico
        Me.txtPeriodo.ValorMaximo = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtPeriodo.ValorMinimo = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ABCPeriodosContables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 437)
        Me.Controls.Add(Me.GrpPeriodos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPeriodo)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.mtb)
        Me.Name = "ABCPeriodosContables"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PERIODOS CONTABLES"
        Me.GrpPeriodos.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents txtPeriodo As IntegraLab.Controles.TextBoxMejorado
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrpPeriodos As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PeriodosContablesC As ClasesNegocio.PeriodosContablesCollectionClass
    Friend WithEvents EjercicioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PolizaCierreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PolizaTraspazoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaCierreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
