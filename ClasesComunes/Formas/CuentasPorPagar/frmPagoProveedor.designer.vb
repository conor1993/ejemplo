<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagoProveedor
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbSinDocto = New System.Windows.Forms.RadioButton()
        Me.rbNotaRem = New System.Windows.Forms.RadioButton()
        Me.rbFactura = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNumRemision = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFolRecep = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblFolRecep = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MtxtUUID = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DtpFechaFac = New System.Windows.Forms.DateTimePicker()
        Me.lblFec = New System.Windows.Forms.Label()
        Me.lblProveedor = New System.Windows.Forms.Label()
        Me.txtFactura = New System.Windows.Forms.TextBox()
        Me.lblImporte = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.rbSinDocto)
        Me.GroupBox1.Controls.Add(Me.rbNotaRem)
        Me.GroupBox1.Controls.Add(Me.rbFactura)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtNumRemision)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtFolRecep)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblFolRecep)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.MtxtUUID)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.DtpFechaFac)
        Me.GroupBox1.Controls.Add(Me.lblFec)
        Me.GroupBox1.Controls.Add(Me.lblProveedor)
        Me.GroupBox1.Controls.Add(Me.txtFactura)
        Me.GroupBox1.Controls.Add(Me.lblImporte)
        Me.GroupBox1.Controls.Add(Me.lblFecha)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(685, 377)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'rbSinDocto
        '
        Me.rbSinDocto.AutoSize = True
        Me.rbSinDocto.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSinDocto.Location = New System.Drawing.Point(496, 60)
        Me.rbSinDocto.Name = "rbSinDocto"
        Me.rbSinDocto.Size = New System.Drawing.Size(147, 28)
        Me.rbSinDocto.TabIndex = 3
        Me.rbSinDocto.TabStop = True
        Me.rbSinDocto.Text = "Sin Documento"
        Me.rbSinDocto.UseVisualStyleBackColor = True
        '
        'rbNotaRem
        '
        Me.rbNotaRem.AutoSize = True
        Me.rbNotaRem.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNotaRem.Location = New System.Drawing.Point(299, 60)
        Me.rbNotaRem.Name = "rbNotaRem"
        Me.rbNotaRem.Size = New System.Drawing.Size(165, 28)
        Me.rbNotaRem.TabIndex = 2
        Me.rbNotaRem.TabStop = True
        Me.rbNotaRem.Text = "Nota de Remisión"
        Me.rbNotaRem.UseVisualStyleBackColor = True
        '
        'rbFactura
        '
        Me.rbFactura.AutoSize = True
        Me.rbFactura.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFactura.Location = New System.Drawing.Point(188, 60)
        Me.rbFactura.Name = "rbFactura"
        Me.rbFactura.Size = New System.Drawing.Size(86, 28)
        Me.rbFactura.TabIndex = 1
        Me.rbFactura.TabStop = True
        Me.rbFactura.Text = "Factura"
        Me.rbFactura.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(84, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 27)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "A pagar:"
        '
        'txtNumRemision
        '
        Me.txtNumRemision.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumRemision.Location = New System.Drawing.Point(197, 214)
        Me.txtNumRemision.Name = "txtNumRemision"
        Me.txtNumRemision.Size = New System.Drawing.Size(398, 32)
        Me.txtNumRemision.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(31, 218)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(141, 24)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "No. Remisión:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFolRecep
        '
        Me.txtFolRecep.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFolRecep.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFolRecep.Location = New System.Drawing.Point(448, 252)
        Me.txtFolRecep.Name = "txtFolRecep"
        Me.txtFolRecep.Size = New System.Drawing.Size(147, 32)
        Me.txtFolRecep.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(347, 257)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 24)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Confirme:"
        '
        'lblFolRecep
        '
        Me.lblFolRecep.BackColor = System.Drawing.SystemColors.Window
        Me.lblFolRecep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFolRecep.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFolRecep.Location = New System.Drawing.Point(197, 254)
        Me.lblFolRecep.Name = "lblFolRecep"
        Me.lblFolRecep.Size = New System.Drawing.Size(148, 27)
        Me.lblFolRecep.TabIndex = 33
        Me.lblFolRecep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 257)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(168, 24)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Folio Recepción:"
        '
        'MtxtUUID
        '
        Me.MtxtUUID.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MtxtUUID.Location = New System.Drawing.Point(197, 175)
        Me.MtxtUUID.Mask = ">AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA"
        Me.MtxtUUID.Name = "MtxtUUID"
        Me.MtxtUUID.Size = New System.Drawing.Size(398, 30)
        Me.MtxtUUID.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(107, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 24)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "UUID:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DtpFechaFac
        '
        Me.DtpFechaFac.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFechaFac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaFac.Location = New System.Drawing.Point(197, 139)
        Me.DtpFechaFac.Name = "DtpFechaFac"
        Me.DtpFechaFac.Size = New System.Drawing.Size(129, 30)
        Me.DtpFechaFac.TabIndex = 5
        '
        'lblFec
        '
        Me.lblFec.AutoSize = True
        Me.lblFec.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFec.Location = New System.Drawing.Point(13, 144)
        Me.lblFec.Name = "lblFec"
        Me.lblFec.Size = New System.Drawing.Size(159, 24)
        Me.lblFec.TabIndex = 28
        Me.lblFec.Text = "Fecha Factura: "
        Me.lblFec.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblProveedor
        '
        Me.lblProveedor.BackColor = System.Drawing.SystemColors.Window
        Me.lblProveedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProveedor.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProveedor.Location = New System.Drawing.Point(197, 293)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(398, 27)
        Me.lblProveedor.TabIndex = 27
        Me.lblProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFactura
        '
        Me.txtFactura.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFactura.Location = New System.Drawing.Point(197, 102)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(398, 32)
        Me.txtFactura.TabIndex = 4
        '
        'lblImporte
        '
        Me.lblImporte.BackColor = System.Drawing.SystemColors.Window
        Me.lblImporte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblImporte.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImporte.Location = New System.Drawing.Point(197, 330)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(171, 27)
        Me.lblImporte.TabIndex = 25
        Me.lblImporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFecha
        '
        Me.lblFecha.BackColor = System.Drawing.SystemColors.Window
        Me.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFecha.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(448, 16)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(231, 27)
        Me.lblFecha.TabIndex = 23
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(367, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 24)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Fecha:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(58, 296)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 24)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Proveedor:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(46, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 24)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "No. Factura:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(86, 332)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 24)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Total:"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.MaximumSize = New System.Drawing.Size(800, 800)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(708, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pago de Recep. Orden de Compra"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnPagar
        '
        Me.btnPagar.Font = New System.Drawing.Font("Arial Narrow", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagar.Location = New System.Drawing.Point(371, 415)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(96, 38)
        Me.btnPagar.TabIndex = 9
        Me.btnPagar.Text = "Pagar"
        Me.btnPagar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(508, 415)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 38)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmPagoProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 465)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnPagar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(420, 205)
        Me.Name = "frmPagoProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pago de Recepciones de Compra"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblImporte As System.Windows.Forms.Label
    Friend WithEvents txtFactura As System.Windows.Forms.TextBox
    Friend WithEvents lblProveedor As System.Windows.Forms.Label
    Friend WithEvents DtpFechaFac As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFec As System.Windows.Forms.Label
    Friend WithEvents MtxtUUID As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblFolRecep As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtFolRecep As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtNumRemision As System.Windows.Forms.TextBox
    Friend WithEvents rbNotaRem As System.Windows.Forms.RadioButton
    Friend WithEvents rbFactura As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnPagar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents rbSinDocto As System.Windows.Forms.RadioButton
End Class
