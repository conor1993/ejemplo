<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCambiaPrecioProducto
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


#Region "Código generado por el Diseñador de Windows Forms"

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTema = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblPrecioActual = New System.Windows.Forms.Label()
        Me.txtPrecioVentaActual = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblNuevoPrecio = New System.Windows.Forms.Label()
        Me.txtNuevoPrecio = New System.Windows.Forms.TextBox()
        Me.lblCostoUnitarioAnterior = New System.Windows.Forms.Label()
        Me.txtCostoAnterior = New System.Windows.Forms.TextBox()
        Me.lblNuevoCosto = New System.Windows.Forms.Label()
        Me.txtNuevoCosto = New System.Windows.Forms.TextBox()
        Me.txtPorcUtilidad = New System.Windows.Forms.TextBox()
        Me.lblporcUtilidad = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIvaAnt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIepsAnt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIvaNuevo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIepsNuevo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCUImpuestos = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCUImpuestosN = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTema
        '
        Me.lblTema.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTema.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTema.Enabled = False
        Me.lblTema.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTema.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTema.Location = New System.Drawing.Point(0, 0)
        Me.lblTema.Name = "lblTema"
        Me.lblTema.Size = New System.Drawing.Size(688, 29)
        Me.lblTema.TabIndex = 5
        Me.lblTema.Text = "El costo del Producto ha cambiado"
        Me.lblTema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(484, 539)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(84, 33)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(583, 539)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(83, 33)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblPrecioActual
        '
        Me.lblPrecioActual.AutoSize = True
        Me.lblPrecioActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioActual.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPrecioActual.Location = New System.Drawing.Point(16, 41)
        Me.lblPrecioActual.Name = "lblPrecioActual"
        Me.lblPrecioActual.Size = New System.Drawing.Size(86, 25)
        Me.lblPrecioActual.TabIndex = 0
        Me.lblPrecioActual.Text = "Anterior:"
        '
        'txtPrecioVentaActual
        '
        Me.txtPrecioVentaActual.Enabled = False
        Me.txtPrecioVentaActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioVentaActual.Location = New System.Drawing.Point(114, 38)
        Me.txtPrecioVentaActual.Name = "txtPrecioVentaActual"
        Me.txtPrecioVentaActual.ReadOnly = True
        Me.txtPrecioVentaActual.Size = New System.Drawing.Size(138, 30)
        Me.txtPrecioVentaActual.TabIndex = 0
        Me.txtPrecioVentaActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(417, 29)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "¿Desea actualizar el Precio de Venta?"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblNuevoPrecio
        '
        Me.lblNuevoPrecio.AutoSize = True
        Me.lblNuevoPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuevoPrecio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNuevoPrecio.Location = New System.Drawing.Point(23, 82)
        Me.lblNuevoPrecio.Name = "lblNuevoPrecio"
        Me.lblNuevoPrecio.Size = New System.Drawing.Size(75, 25)
        Me.lblNuevoPrecio.TabIndex = 0
        Me.lblNuevoPrecio.Text = "Nuevo:"
        '
        'txtNuevoPrecio
        '
        Me.txtNuevoPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNuevoPrecio.Location = New System.Drawing.Point(114, 79)
        Me.txtNuevoPrecio.Name = "txtNuevoPrecio"
        Me.txtNuevoPrecio.Size = New System.Drawing.Size(138, 30)
        Me.txtNuevoPrecio.TabIndex = 2
        Me.txtNuevoPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCostoUnitarioAnterior
        '
        Me.lblCostoUnitarioAnterior.AutoSize = True
        Me.lblCostoUnitarioAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostoUnitarioAnterior.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCostoUnitarioAnterior.Location = New System.Drawing.Point(85, 45)
        Me.lblCostoUnitarioAnterior.Name = "lblCostoUnitarioAnterior"
        Me.lblCostoUnitarioAnterior.Size = New System.Drawing.Size(73, 25)
        Me.lblCostoUnitarioAnterior.TabIndex = 0
        Me.lblCostoUnitarioAnterior.Text = "Precio:"
        '
        'txtCostoAnterior
        '
        Me.txtCostoAnterior.Enabled = False
        Me.txtCostoAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoAnterior.Location = New System.Drawing.Point(164, 42)
        Me.txtCostoAnterior.Name = "txtCostoAnterior"
        Me.txtCostoAnterior.ReadOnly = True
        Me.txtCostoAnterior.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCostoAnterior.Size = New System.Drawing.Size(138, 30)
        Me.txtCostoAnterior.TabIndex = 0
        '
        'lblNuevoCosto
        '
        Me.lblNuevoCosto.AutoSize = True
        Me.lblNuevoCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuevoCosto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNuevoCosto.Location = New System.Drawing.Point(88, 45)
        Me.lblNuevoCosto.Name = "lblNuevoCosto"
        Me.lblNuevoCosto.Size = New System.Drawing.Size(73, 25)
        Me.lblNuevoCosto.TabIndex = 0
        Me.lblNuevoCosto.Text = "Precio:"
        '
        'txtNuevoCosto
        '
        Me.txtNuevoCosto.Enabled = False
        Me.txtNuevoCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNuevoCosto.Location = New System.Drawing.Point(166, 42)
        Me.txtNuevoCosto.Name = "txtNuevoCosto"
        Me.txtNuevoCosto.ReadOnly = True
        Me.txtNuevoCosto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNuevoCosto.Size = New System.Drawing.Size(138, 30)
        Me.txtNuevoCosto.TabIndex = 0
        Me.txtNuevoCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPorcUtilidad
        '
        Me.txtPorcUtilidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorcUtilidad.Location = New System.Drawing.Point(346, 320)
        Me.txtPorcUtilidad.Name = "txtPorcUtilidad"
        Me.txtPorcUtilidad.Size = New System.Drawing.Size(138, 30)
        Me.txtPorcUtilidad.TabIndex = 1
        Me.txtPorcUtilidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblporcUtilidad
        '
        Me.lblporcUtilidad.AutoSize = True
        Me.lblporcUtilidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblporcUtilidad.Location = New System.Drawing.Point(208, 323)
        Me.lblporcUtilidad.Name = "lblporcUtilidad"
        Me.lblporcUtilidad.Size = New System.Drawing.Size(132, 25)
        Me.lblporcUtilidad.TabIndex = 0
        Me.lblporcUtilidad.Text = "% de Utilidad:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(114, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Iva:"
        '
        'txtIvaAnt
        '
        Me.txtIvaAnt.Enabled = False
        Me.txtIvaAnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIvaAnt.Location = New System.Drawing.Point(164, 84)
        Me.txtIvaAnt.Name = "txtIvaAnt"
        Me.txtIvaAnt.ReadOnly = True
        Me.txtIvaAnt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtIvaAnt.Size = New System.Drawing.Size(138, 30)
        Me.txtIvaAnt.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(103, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Ieps:"
        '
        'txtIepsAnt
        '
        Me.txtIepsAnt.Enabled = False
        Me.txtIepsAnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIepsAnt.Location = New System.Drawing.Point(164, 126)
        Me.txtIepsAnt.Name = "txtIepsAnt"
        Me.txtIepsAnt.ReadOnly = True
        Me.txtIepsAnt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtIepsAnt.Size = New System.Drawing.Size(138, 30)
        Me.txtIepsAnt.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(117, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 25)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Iva:"
        '
        'txtIvaNuevo
        '
        Me.txtIvaNuevo.Enabled = False
        Me.txtIvaNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIvaNuevo.Location = New System.Drawing.Point(166, 83)
        Me.txtIvaNuevo.Name = "txtIvaNuevo"
        Me.txtIvaNuevo.ReadOnly = True
        Me.txtIvaNuevo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtIvaNuevo.Size = New System.Drawing.Size(138, 30)
        Me.txtIvaNuevo.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(106, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 25)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Ieps:"
        '
        'txtIepsNuevo
        '
        Me.txtIepsNuevo.Enabled = False
        Me.txtIepsNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIepsNuevo.Location = New System.Drawing.Point(167, 122)
        Me.txtIepsNuevo.Name = "txtIepsNuevo"
        Me.txtIepsNuevo.ReadOnly = True
        Me.txtIepsNuevo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtIepsNuevo.Size = New System.Drawing.Size(138, 30)
        Me.txtIepsNuevo.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(12, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 25)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Con Impuestos:"
        '
        'txtCUImpuestos
        '
        Me.txtCUImpuestos.Enabled = False
        Me.txtCUImpuestos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCUImpuestos.Location = New System.Drawing.Point(163, 165)
        Me.txtCUImpuestos.Name = "txtCUImpuestos"
        Me.txtCUImpuestos.ReadOnly = True
        Me.txtCUImpuestos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCUImpuestos.Size = New System.Drawing.Size(138, 30)
        Me.txtCUImpuestos.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(11, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(150, 25)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Con Impuestos:"
        '
        'txtCUImpuestosN
        '
        Me.txtCUImpuestosN.Enabled = False
        Me.txtCUImpuestosN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCUImpuestosN.Location = New System.Drawing.Point(167, 158)
        Me.txtCUImpuestosN.Name = "txtCUImpuestosN"
        Me.txtCUImpuestosN.ReadOnly = True
        Me.txtCUImpuestosN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCUImpuestosN.Size = New System.Drawing.Size(138, 30)
        Me.txtCUImpuestosN.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.lblCostoUnitarioAnterior)
        Me.GroupBox1.Controls.Add(Me.txtCostoAnterior)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCUImpuestos)
        Me.GroupBox1.Controls.Add(Me.txtIvaAnt)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtIepsAnt)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox1.Location = New System.Drawing.Point(12, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(322, 209)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Costo Unitario Anterior"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtNuevoCosto)
        Me.GroupBox2.Controls.Add(Me.lblNuevoCosto)
        Me.GroupBox2.Controls.Add(Me.txtCUImpuestosN)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtIvaNuevo)
        Me.GroupBox2.Controls.Add(Me.txtIepsNuevo)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox2.Location = New System.Drawing.Point(346, 85)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(323, 204)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Costo Unitario Actual"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblPrecioActual)
        Me.GroupBox3.Controls.Add(Me.lblNuevoPrecio)
        Me.GroupBox3.Controls.Add(Me.txtPrecioVentaActual)
        Me.GroupBox3.Controls.Add(Me.txtNuevoPrecio)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox3.Location = New System.Drawing.Point(213, 372)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(359, 126)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Precio de Venta con Impuestos"
        '
        'FrmCambiaPrecioProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 584)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtPorcUtilidad)
        Me.Controls.Add(Me.lblporcUtilidad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblTema)
        Me.KeyPreview = True
        Me.Name = "FrmCambiaPrecioProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio de Precio de Productos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private WithEvents lblTema As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lblPrecioActual As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblNuevoPrecio As System.Windows.Forms.Label
    Friend WithEvents txtNuevoPrecio As System.Windows.Forms.TextBox
    Friend WithEvents lblCostoUnitarioAnterior As System.Windows.Forms.Label
    Friend WithEvents lblNuevoCosto As System.Windows.Forms.Label
    Friend WithEvents txtPorcUtilidad As System.Windows.Forms.TextBox
    Friend WithEvents lblporcUtilidad As System.Windows.Forms.Label
    Friend WithEvents txtPrecioVentaActual As System.Windows.Forms.TextBox
    Friend WithEvents txtCostoAnterior As System.Windows.Forms.TextBox
    Friend WithEvents txtNuevoCosto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIvaAnt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtIepsAnt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtIvaNuevo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtIepsNuevo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCUImpuestos As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCUImpuestosN As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class