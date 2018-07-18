<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptMayorGeneral
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ValueListItem13 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem14 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem15 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem16 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem17 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem18 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem19 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem20 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem21 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem22 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem23 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem24 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem7 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem8 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem9 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem10 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem11 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem12 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Me.MEAToolBar1 = New MEAToolBar.MEAToolBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ultcmbMes = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ucbe_Ejercicio = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cbOrdenar = New System.Windows.Forms.CheckBox()
        CType(Me.ultcmbMes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucbe_Ejercicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MEAToolBar1
        '
        Me.MEAToolBar1.ButtonSize = New System.Drawing.Size(50, 50)
        Me.MEAToolBar1.Dock = System.Windows.Forms.DockStyle.None
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
        Me.MEAToolBar1.Size = New System.Drawing.Size(50, 266)
        Me.MEAToolBar1.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(56, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Mes a Generar:"
        '
        'ultcmbMes
        '
        Me.ultcmbMes.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        ValueListItem13.DataValue = CType(1, Byte)
        ValueListItem13.DisplayText = "ENERO"
        ValueListItem14.DataValue = CType(2, Byte)
        ValueListItem14.DisplayText = "FEBRERO"
        ValueListItem15.DataValue = CType(3, Byte)
        ValueListItem15.DisplayText = "MARZO"
        ValueListItem16.DataValue = CType(4, Byte)
        ValueListItem16.DisplayText = "ABRIL"
        ValueListItem17.DataValue = CType(5, Byte)
        ValueListItem17.DisplayText = "MAYO"
        ValueListItem18.DataValue = CType(6, Byte)
        ValueListItem18.DisplayText = "JUNIO"
        ValueListItem19.DataValue = CType(7, Byte)
        ValueListItem19.DisplayText = "JULIO"
        ValueListItem20.DataValue = CType(8, Byte)
        ValueListItem20.DisplayText = "AGOSTO"
        ValueListItem21.DataValue = CType(9, Byte)
        ValueListItem21.DisplayText = "SEPTIEMBRE"
        ValueListItem22.DataValue = CType(10, Byte)
        ValueListItem22.DisplayText = "OCTUBRE"
        ValueListItem23.DataValue = CType(11, Byte)
        ValueListItem23.DisplayText = "NOVIEMBRE"
        ValueListItem24.DataValue = CType(12, Byte)
        ValueListItem24.DisplayText = "DICIEMBRE"
        Me.ultcmbMes.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem13, ValueListItem14, ValueListItem15, ValueListItem16, ValueListItem17, ValueListItem18, ValueListItem19, ValueListItem20, ValueListItem21, ValueListItem22, ValueListItem23, ValueListItem24})
        Me.ultcmbMes.Location = New System.Drawing.Point(169, 71)
        Me.ultcmbMes.Name = "ultcmbMes"
        Me.ultcmbMes.NullText = "Seleccione el Mes"
        Me.ultcmbMes.Size = New System.Drawing.Size(121, 21)
        Me.ultcmbMes.TabIndex = 41
        Me.ultcmbMes.Text = "Seleccione el Mes"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(71, 178)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(201, 20)
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(53, 0)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(253, 29)
        Me.lblTitulo.TabIndex = 43
        Me.lblTitulo.Text = "MAYOR GENERAL"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(56, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Ejercicio:"
        '
        'ucbe_Ejercicio
        '
        Me.ucbe_Ejercicio.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        ValueListItem1.DataValue = CType(1, Byte)
        ValueListItem1.DisplayText = "ENERO"
        ValueListItem2.DataValue = CType(2, Byte)
        ValueListItem2.DisplayText = "FEBRERO"
        ValueListItem3.DataValue = CType(3, Byte)
        ValueListItem3.DisplayText = "MARZO"
        ValueListItem4.DataValue = CType(4, Byte)
        ValueListItem4.DisplayText = "ABRIL"
        ValueListItem5.DataValue = CType(5, Byte)
        ValueListItem5.DisplayText = "MAYO"
        ValueListItem6.DataValue = CType(6, Byte)
        ValueListItem6.DisplayText = "JUNIO"
        ValueListItem7.DataValue = CType(7, Byte)
        ValueListItem7.DisplayText = "JULIO"
        ValueListItem8.DataValue = CType(8, Byte)
        ValueListItem8.DisplayText = "AGOSTO"
        ValueListItem9.DataValue = CType(9, Byte)
        ValueListItem9.DisplayText = "SEPTIEMBRE"
        ValueListItem10.DataValue = CType(10, Byte)
        ValueListItem10.DisplayText = "OCTUBRE"
        ValueListItem11.DataValue = CType(11, Byte)
        ValueListItem11.DisplayText = "NOVIEMBRE"
        ValueListItem12.DataValue = CType(12, Byte)
        ValueListItem12.DisplayText = "DICIEMBRE"
        Me.ucbe_Ejercicio.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2, ValueListItem3, ValueListItem4, ValueListItem5, ValueListItem6, ValueListItem7, ValueListItem8, ValueListItem9, ValueListItem10, ValueListItem11, ValueListItem12})
        Me.ucbe_Ejercicio.Location = New System.Drawing.Point(169, 102)
        Me.ucbe_Ejercicio.Name = "ucbe_Ejercicio"
        Me.ucbe_Ejercicio.NullText = "Ejercicio"
        Me.ucbe_Ejercicio.Size = New System.Drawing.Size(121, 21)
        Me.ucbe_Ejercicio.TabIndex = 46
        Me.ucbe_Ejercicio.Text = "Ejercicio"
        '
        'cbOrdenar
        '
        Me.cbOrdenar.AutoSize = True
        Me.cbOrdenar.Location = New System.Drawing.Point(59, 144)
        Me.cbOrdenar.Name = "cbOrdenar"
        Me.cbOrdenar.Size = New System.Drawing.Size(215, 17)
        Me.cbOrdenar.TabIndex = 47
        Me.cbOrdenar.Text = "Ordenar Cuentas(Acreedoras-Deudoras)"
        Me.cbOrdenar.UseVisualStyleBackColor = True
        '
        'frmRptMayorGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 210)
        Me.Controls.Add(Me.cbOrdenar)
        Me.Controls.Add(Me.ucbe_Ejercicio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ultcmbMes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MEAToolBar1)
        Me.Name = "frmRptMayorGeneral"
        Me.Text = "Mayor General"
        CType(Me.ultcmbMes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucbe_Ejercicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MEAToolBar1 As MEAToolBar.MEAToolBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ultcmbMes As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ucbe_Ejercicio As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cbOrdenar As System.Windows.Forms.CheckBox
End Class
