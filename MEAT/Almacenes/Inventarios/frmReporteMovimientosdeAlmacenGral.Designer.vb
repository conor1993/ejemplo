<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteMovimientosdeAlmacenGral
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
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbMovimiento = New System.Windows.Forms.ComboBox
        Me.movimiento = New ClasesNegocio.TipoMovimientoAlmacenCollectionClass
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbAlmacen = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar
        Me.txtCodTipoMovimiento = New System.Windows.Forms.TextBox
        Me.txtCodAlmacen = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpFechaFinal)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtpFechaInicial)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(59, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(204, 77)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rango De Fechas"
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(91, 46)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(88, 20)
        Me.dtpFechaFinal.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Fecha Inicial:"
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicial.Location = New System.Drawing.Point(91, 20)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(88, 20)
        Me.dtpFechaInicial.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Fecha Final:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Tipo Movimiento:"
        '
        'cmbMovimiento
        '
        Me.cmbMovimiento.DataSource = Me.movimiento
        Me.cmbMovimiento.DisplayMember = "Nombre"
        Me.cmbMovimiento.FormattingEnabled = True
        Me.cmbMovimiento.Location = New System.Drawing.Point(218, 72)
        Me.cmbMovimiento.Name = "cmbMovimiento"
        Me.cmbMovimiento.Size = New System.Drawing.Size(181, 21)
        Me.cmbMovimiento.TabIndex = 1
        Me.cmbMovimiento.ValueMember = "Codigo"
        '
        'movimiento
        '
        Me.movimiento.AllowEdit = True
        Me.movimiento.AllowNew = True
        Me.movimiento.AllowRemove = True
        Me.movimiento.Name = ""
        Me.movimiento.RaiseListChangedEvents = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Almacén:"
        '
        'cmbAlmacen
        '
        Me.cmbAlmacen.FormattingEnabled = True
        Me.cmbAlmacen.Location = New System.Drawing.Point(218, 45)
        Me.cmbAlmacen.Name = "cmbAlmacen"
        Me.cmbAlmacen.Size = New System.Drawing.Size(182, 21)
        Me.cmbAlmacen.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(375, 32)
        Me.Label17.TabIndex = 51
        Me.Label17.Text = "Reportes De Movimientos De Almacén"
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
        Me.MEAToolBar1.MostrarBorrar = False
        Me.MEAToolBar1.MostrarBuscar = False
        Me.MEAToolBar1.MostrarCancelar = False
        Me.MEAToolBar1.MostrarEditar = False
        Me.MEAToolBar1.MostrarGuardar = False
        Me.MEAToolBar1.MostrarImprimir = True
        Me.MEAToolBar1.MostrarLimpiar = True
        Me.MEAToolBar1.MostrarNuevo = False
        Me.MEAToolBar1.MostrarSalir = True
        Me.MEAToolBar1.Name = "MEAToolBar1"
        Me.MEAToolBar1.ShowToolTips = True
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 190)
        Me.MEAToolBar1.TabIndex = 52
        '
        'txtCodTipoMovimiento
        '
        Me.txtCodTipoMovimiento.Location = New System.Drawing.Point(149, 72)
        Me.txtCodTipoMovimiento.Name = "txtCodTipoMovimiento"
        Me.txtCodTipoMovimiento.Size = New System.Drawing.Size(62, 20)
        Me.txtCodTipoMovimiento.TabIndex = 54
        '
        'txtCodAlmacen
        '
        Me.txtCodAlmacen.Location = New System.Drawing.Point(149, 45)
        Me.txtCodAlmacen.Name = "txtCodAlmacen"
        Me.txtCodAlmacen.Size = New System.Drawing.Size(62, 20)
        Me.txtCodAlmacen.TabIndex = 53
        '
        'frmReporteMovimientosdeAlmacenGral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 190)
        Me.Controls.Add(Me.txtCodTipoMovimiento)
        Me.Controls.Add(Me.txtCodAlmacen)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbMovimiento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbAlmacen)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmReporteMovimientosdeAlmacenGral"
        Me.Text = "Reporte de Movimientos de Almacén"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbMovimiento As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents movimiento As ClasesNegocio.TipoMovimientoAlmacenCollectionClass
    Friend WithEvents txtCodTipoMovimiento As System.Windows.Forms.TextBox
    Friend WithEvents txtCodAlmacen As System.Windows.Forms.TextBox
End Class
