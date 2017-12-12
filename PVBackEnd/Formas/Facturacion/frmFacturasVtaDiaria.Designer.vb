<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturasVtaDiaria
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSubTotalFact = New System.Windows.Forms.TextBox()
        Me.txtiepsFact = New System.Windows.Forms.TextBox()
        Me.txtivaFact = New System.Windows.Forms.TextBox()
        Me.txtTotalSubtotal = New System.Windows.Forms.TextBox()
        Me.txtTotalIVA = New System.Windows.Forms.TextBox()
        Me.txtTotalIeps = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTotalFactTemp = New System.Windows.Forms.TextBox()
        Me.txtDiff = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTotalVentaDia = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalFact = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCambiaFecha = New System.Windows.Forms.Button()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblEstatus = New System.Windows.Forms.Label()
        Me.TxtPorc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mtb = New MEAToolBar.MEAToolBar()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, -1)
        Me.Label1.MaximumSize = New System.Drawing.Size(1800, 1800)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(570, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "FACTURACIÓN DE LA VENTA DIARIA"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.txtObservacion)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtSubTotalFact)
        Me.Panel1.Controls.Add(Me.txtiepsFact)
        Me.Panel1.Controls.Add(Me.txtivaFact)
        Me.Panel1.Controls.Add(Me.txtTotalSubtotal)
        Me.Panel1.Controls.Add(Me.txtTotalIVA)
        Me.Panel1.Controls.Add(Me.txtTotalIeps)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtTotalFactTemp)
        Me.Panel1.Controls.Add(Me.txtDiff)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtTotalVentaDia)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtTotalFact)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnCambiaFecha)
        Me.Panel1.Controls.Add(Me.dtpFecha)
        Me.Panel1.Controls.Add(Me.lblEstatus)
        Me.Panel1.Controls.Add(Me.TxtPorc)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(58, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(499, 334)
        Me.Panel1.TabIndex = 1
        '
        'txtObservacion
        '
        Me.txtObservacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacion.Location = New System.Drawing.Point(90, 196)
        Me.txtObservacion.MaxLength = 250
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(406, 105)
        Me.txtObservacion.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(3, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Observaciones:"
        '
        'txtSubTotalFact
        '
        Me.txtSubTotalFact.Location = New System.Drawing.Point(291, 139)
        Me.txtSubTotalFact.Name = "txtSubTotalFact"
        Me.txtSubTotalFact.ReadOnly = True
        Me.txtSubTotalFact.Size = New System.Drawing.Size(73, 20)
        Me.txtSubTotalFact.TabIndex = 43
        Me.txtSubTotalFact.Visible = False
        '
        'txtiepsFact
        '
        Me.txtiepsFact.Location = New System.Drawing.Point(432, 139)
        Me.txtiepsFact.Name = "txtiepsFact"
        Me.txtiepsFact.ReadOnly = True
        Me.txtiepsFact.Size = New System.Drawing.Size(60, 20)
        Me.txtiepsFact.TabIndex = 42
        Me.txtiepsFact.Visible = False
        '
        'txtivaFact
        '
        Me.txtivaFact.Location = New System.Drawing.Point(373, 139)
        Me.txtivaFact.Name = "txtivaFact"
        Me.txtivaFact.ReadOnly = True
        Me.txtivaFact.Size = New System.Drawing.Size(53, 20)
        Me.txtivaFact.TabIndex = 41
        Me.txtivaFact.Visible = False
        '
        'txtTotalSubtotal
        '
        Me.txtTotalSubtotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalSubtotal.Location = New System.Drawing.Point(140, 29)
        Me.txtTotalSubtotal.MaxLength = 5
        Me.txtTotalSubtotal.Name = "txtTotalSubtotal"
        Me.txtTotalSubtotal.ReadOnly = True
        Me.txtTotalSubtotal.Size = New System.Drawing.Size(118, 20)
        Me.txtTotalSubtotal.TabIndex = 40
        Me.txtTotalSubtotal.Text = "0.00"
        Me.txtTotalSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalIVA
        '
        Me.txtTotalIVA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalIVA.Location = New System.Drawing.Point(140, 55)
        Me.txtTotalIVA.MaxLength = 5
        Me.txtTotalIVA.Name = "txtTotalIVA"
        Me.txtTotalIVA.ReadOnly = True
        Me.txtTotalIVA.Size = New System.Drawing.Size(118, 20)
        Me.txtTotalIVA.TabIndex = 39
        Me.txtTotalIVA.Text = "0.00"
        Me.txtTotalIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalIeps
        '
        Me.txtTotalIeps.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalIeps.Location = New System.Drawing.Point(140, 81)
        Me.txtTotalIeps.MaxLength = 5
        Me.txtTotalIeps.Name = "txtTotalIeps"
        Me.txtTotalIeps.ReadOnly = True
        Me.txtTotalIeps.Size = New System.Drawing.Size(118, 20)
        Me.txtTotalIeps.TabIndex = 38
        Me.txtTotalIeps.Text = "0.00"
        Me.txtTotalIeps.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(70, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Total IEPS:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(77, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Total IVA:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(55, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Total Subtotal:"
        '
        'txtTotalFactTemp
        '
        Me.txtTotalFactTemp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalFactTemp.Location = New System.Drawing.Point(264, 168)
        Me.txtTotalFactTemp.MaxLength = 5
        Me.txtTotalFactTemp.Name = "txtTotalFactTemp"
        Me.txtTotalFactTemp.Size = New System.Drawing.Size(118, 20)
        Me.txtTotalFactTemp.TabIndex = 34
        Me.txtTotalFactTemp.Text = "0.00"
        Me.txtTotalFactTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalFactTemp.Visible = False
        '
        'txtDiff
        '
        Me.txtDiff.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDiff.Location = New System.Drawing.Point(140, 168)
        Me.txtDiff.MaxLength = 10
        Me.txtDiff.Name = "txtDiff"
        Me.txtDiff.Size = New System.Drawing.Size(118, 20)
        Me.txtDiff.TabIndex = 33
        Me.txtDiff.Text = "0.00"
        Me.txtDiff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(49, 171)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Total a facturar:"
        '
        'txtTotalVentaDia
        '
        Me.txtTotalVentaDia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalVentaDia.Location = New System.Drawing.Point(140, 108)
        Me.txtTotalVentaDia.MaxLength = 5
        Me.txtTotalVentaDia.Name = "txtTotalVentaDia"
        Me.txtTotalVentaDia.ReadOnly = True
        Me.txtTotalVentaDia.Size = New System.Drawing.Size(118, 20)
        Me.txtTotalVentaDia.TabIndex = 31
        Me.txtTotalVentaDia.Text = "0.00"
        Me.txtTotalVentaDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(39, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Total venta diaria:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(23, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Total diario facturado:"
        '
        'txtTotalFact
        '
        Me.txtTotalFact.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalFact.Location = New System.Drawing.Point(140, 139)
        Me.txtTotalFact.MaxLength = 5
        Me.txtTotalFact.Name = "txtTotalFact"
        Me.txtTotalFact.ReadOnly = True
        Me.txtTotalFact.Size = New System.Drawing.Size(118, 20)
        Me.txtTotalFact.TabIndex = 28
        Me.txtTotalFact.Text = "0.00"
        Me.txtTotalFact.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(137, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "%"
        Me.Label2.Visible = False
        '
        'btnCambiaFecha
        '
        Me.btnCambiaFecha.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCambiaFecha.Location = New System.Drawing.Point(159, 193)
        Me.btnCambiaFecha.Name = "btnCambiaFecha"
        Me.btnCambiaFecha.Size = New System.Drawing.Size(99, 23)
        Me.btnCambiaFecha.TabIndex = 3
        Me.btnCambiaFecha.Text = "Cambiar Fecha"
        Me.btnCambiaFecha.UseVisualStyleBackColor = True
        Me.btnCambiaFecha.Visible = False
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(264, 3)
        Me.dtpFecha.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        Me.dtpFecha.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(100, 20)
        Me.dtpFecha.TabIndex = 1
        '
        'lblEstatus
        '
        Me.lblEstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        Me.lblEstatus.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Location = New System.Drawing.Point(370, 2)
        Me.lblEstatus.Name = "lblEstatus"
        Me.lblEstatus.Size = New System.Drawing.Size(122, 21)
        Me.lblEstatus.TabIndex = 24
        Me.lblEstatus.Text = "ESTATUS"
        Me.lblEstatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtPorc
        '
        Me.TxtPorc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPorc.Location = New System.Drawing.Point(90, 195)
        Me.TxtPorc.MaxLength = 5
        Me.TxtPorc.Name = "TxtPorc"
        Me.TxtPorc.Size = New System.Drawing.Size(41, 20)
        Me.TxtPorc.TabIndex = 2
        Me.TxtPorc.Text = "0.00"
        Me.TxtPorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtPorc.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(218, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Fecha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(23, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Porcentaje:"
        Me.Label4.Visible = False
        '
        'mtb
        '
        Me.mtb.ButtonSize = New System.Drawing.Size(50, 50)
        Me.mtb.Dock = System.Windows.Forms.DockStyle.Left
        Me.mtb.DropDownArrows = True
        Me.mtb.HabilitarBorrar = False
        Me.mtb.HabilitarBuscar = False
        Me.mtb.HabilitarCancelar = False
        Me.mtb.HabilitarEditar = False
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
        Me.mtb.MostrarLimpiar = False
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 377)
        Me.mtb.TabIndex = 31
        '
        'frmFacturasVtaDiaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 377)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.MaximizeBox = False
        Me.Name = "frmFacturasVtaDiaria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturación de la Venta Diaria"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TxtPorc As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCambiaFecha As System.Windows.Forms.Button
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTotalFact As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalVentaDia As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDiff As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTotalFactTemp As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTotalSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalIVA As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalIeps As System.Windows.Forms.TextBox
    Friend WithEvents txtivaFact As System.Windows.Forms.TextBox
    Friend WithEvents txtiepsFact As System.Windows.Forms.TextBox
    Friend WithEvents txtSubTotalFact As System.Windows.Forms.TextBox
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
End Class
