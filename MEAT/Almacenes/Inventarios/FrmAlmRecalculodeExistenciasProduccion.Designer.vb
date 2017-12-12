<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAlmRecalculodeExistenciasProduccion
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
        Me.chkAlmacenDecomiso = New System.Windows.Forms.CheckBox
        Me.chkAlmacenProductos = New System.Windows.Forms.CheckBox
        Me.chkAlmacenCorte = New System.Windows.Forms.CheckBox
        Me.chkAlmacenCanal = New System.Windows.Forms.CheckBox
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
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
        Me.Label17.Size = New System.Drawing.Size(446, 36)
        Me.Label17.TabIndex = 60
        Me.Label17.Text = "Recalculo de Existencias de Producción"
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
        Me.mtb.MostrarBorrar = False
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = False
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 233)
        Me.mtb.TabIndex = 59
        '
        'chkAlmacenDecomiso
        '
        Me.chkAlmacenDecomiso.AutoSize = True
        Me.chkAlmacenDecomiso.Location = New System.Drawing.Point(54, 136)
        Me.chkAlmacenDecomiso.Name = "chkAlmacenDecomiso"
        Me.chkAlmacenDecomiso.Size = New System.Drawing.Size(206, 17)
        Me.chkAlmacenDecomiso.TabIndex = 67
        Me.chkAlmacenDecomiso.Text = "Recalcular en Almacén de Decomisos"
        Me.chkAlmacenDecomiso.UseVisualStyleBackColor = True
        '
        'chkAlmacenProductos
        '
        Me.chkAlmacenProductos.AutoSize = True
        Me.chkAlmacenProductos.Location = New System.Drawing.Point(54, 109)
        Me.chkAlmacenProductos.Name = "chkAlmacenProductos"
        Me.chkAlmacenProductos.Size = New System.Drawing.Size(202, 17)
        Me.chkAlmacenProductos.TabIndex = 66
        Me.chkAlmacenProductos.Text = "Recalcular en Almacén de Productos"
        Me.chkAlmacenProductos.UseVisualStyleBackColor = True
        '
        'chkAlmacenCorte
        '
        Me.chkAlmacenCorte.AutoSize = True
        Me.chkAlmacenCorte.Location = New System.Drawing.Point(54, 82)
        Me.chkAlmacenCorte.Name = "chkAlmacenCorte"
        Me.chkAlmacenCorte.Size = New System.Drawing.Size(184, 17)
        Me.chkAlmacenCorte.TabIndex = 65
        Me.chkAlmacenCorte.Text = "Recalcular en Almacén de Cortes"
        Me.chkAlmacenCorte.UseVisualStyleBackColor = True
        '
        'chkAlmacenCanal
        '
        Me.chkAlmacenCanal.AutoSize = True
        Me.chkAlmacenCanal.Location = New System.Drawing.Point(54, 55)
        Me.chkAlmacenCanal.Name = "chkAlmacenCanal"
        Me.chkAlmacenCanal.Size = New System.Drawing.Size(192, 17)
        Me.chkAlmacenCanal.TabIndex = 64
        Me.chkAlmacenCanal.Text = "Recalcular en Almacén de Canales"
        Me.chkAlmacenCanal.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(334, 52)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(98, 20)
        Me.dtpFecha.TabIndex = 68
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(286, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Fecha"
        '
        'FrmAlmRecalculodeExistenciasProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 233)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.chkAlmacenDecomiso)
        Me.Controls.Add(Me.chkAlmacenProductos)
        Me.Controls.Add(Me.chkAlmacenCorte)
        Me.Controls.Add(Me.chkAlmacenCanal)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.Name = "FrmAlmRecalculodeExistenciasProduccion"
        Me.Text = "Recalculo de Existencias de Producción"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents chkAlmacenDecomiso As System.Windows.Forms.CheckBox
    Friend WithEvents chkAlmacenProductos As System.Windows.Forms.CheckBox
    Friend WithEvents chkAlmacenCorte As System.Windows.Forms.CheckBox
    Friend WithEvents chkAlmacenCanal As System.Windows.Forms.CheckBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
