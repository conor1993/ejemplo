<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteRegistroSacrificio
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label17 = New System.Windows.Forms.Label
        Me.BtnImprimir = New System.Windows.Forms.Button
        Me.BtnBuscar = New System.Windows.Forms.Button
        Me.CmbIntroductor = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DtpFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.DtpFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtLoteSacrificio = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DgvSacrificios = New System.Windows.Forms.DataGridView
        Me.LoteSacrificio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LoteRastro = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaSacrificio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantCabezasSacrificio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KilosSacrificio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Canales = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvSacrificios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(-1, -1)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(829, 32)
        Me.Label17.TabIndex = 52
        Me.Label17.Text = "Reporte de Registro de Sacrificios"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Location = New System.Drawing.Point(607, 417)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.BtnImprimir.TabIndex = 66
        Me.BtnImprimir.Text = "Imprimir"
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(434, 101)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 65
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'CmbIntroductor
        '
        Me.CmbIntroductor.FormattingEnabled = True
        Me.CmbIntroductor.Location = New System.Drawing.Point(132, 102)
        Me.CmbIntroductor.Name = "CmbIntroductor"
        Me.CmbIntroductor.Size = New System.Drawing.Size(296, 21)
        Me.CmbIntroductor.TabIndex = 64
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Introductor :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DtpFechaFinal)
        Me.GroupBox1.Controls.Add(Me.DtpFechaInicio)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(525, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(192, 89)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rango de Fechas"
        '
        'DtpFechaFinal
        '
        Me.DtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaFinal.Location = New System.Drawing.Point(92, 55)
        Me.DtpFechaFinal.Name = "DtpFechaFinal"
        Me.DtpFechaFinal.Size = New System.Drawing.Size(92, 20)
        Me.DtpFechaFinal.TabIndex = 3
        '
        'DtpFechaInicio
        '
        Me.DtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaInicio.Location = New System.Drawing.Point(92, 21)
        Me.DtpFechaInicio.Name = "DtpFechaInicio"
        Me.DtpFechaInicio.Size = New System.Drawing.Size(92, 20)
        Me.DtpFechaInicio.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Fecha Final :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fecha Inicio :"
        '
        'txtLoteSacrificio
        '
        Me.txtLoteSacrificio.Location = New System.Drawing.Point(132, 74)
        Me.txtLoteSacrificio.Name = "txtLoteSacrificio"
        Me.txtLoteSacrificio.Size = New System.Drawing.Size(100, 20)
        Me.txtLoteSacrificio.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Lote de Sacrificio : "
        '
        'DgvSacrificios
        '
        Me.DgvSacrificios.AllowUserToAddRows = False
        Me.DgvSacrificios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSacrificios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LoteSacrificio, Me.LoteRastro, Me.FechaSacrificio, Me.IdProveedor, Me.Nombre, Me.CantCabezasSacrificio, Me.KilosSacrificio, Me.Canales})
        Me.DgvSacrificios.Location = New System.Drawing.Point(31, 142)
        Me.DgvSacrificios.Name = "DgvSacrificios"
        Me.DgvSacrificios.ReadOnly = True
        Me.DgvSacrificios.RowHeadersVisible = False
        Me.DgvSacrificios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvSacrificios.Size = New System.Drawing.Size(785, 269)
        Me.DgvSacrificios.TabIndex = 59
        '
        'LoteSacrificio
        '
        Me.LoteSacrificio.DataPropertyName = "IdLoteSacrificio"
        Me.LoteSacrificio.HeaderText = "Lote Sacrificio"
        Me.LoteSacrificio.Name = "LoteSacrificio"
        Me.LoteSacrificio.ReadOnly = True
        '
        'LoteRastro
        '
        Me.LoteRastro.DataPropertyName = "LoteRastro"
        Me.LoteRastro.HeaderText = "Lote Rastro o Engorda"
        Me.LoteRastro.Name = "LoteRastro"
        Me.LoteRastro.ReadOnly = True
        '
        'FechaSacrificio
        '
        Me.FechaSacrificio.DataPropertyName = "FechaSacrificio"
        Me.FechaSacrificio.HeaderText = "Fecha Sacrificio"
        Me.FechaSacrificio.Name = "FechaSacrificio"
        Me.FechaSacrificio.ReadOnly = True
        '
        'IdProveedor
        '
        Me.IdProveedor.DataPropertyName = "Introductor"
        Me.IdProveedor.HeaderText = "Codigo"
        Me.IdProveedor.Name = "IdProveedor"
        Me.IdProveedor.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "NombreIntroductor"
        Me.Nombre.HeaderText = "Introductor"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 200
        '
        'CantCabezasSacrificio
        '
        Me.CantCabezasSacrificio.DataPropertyName = "CantCabezasSacrificio"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.CantCabezasSacrificio.DefaultCellStyle = DataGridViewCellStyle1
        Me.CantCabezasSacrificio.HeaderText = "Cant. Cabezas"
        Me.CantCabezasSacrificio.Name = "CantCabezasSacrificio"
        Me.CantCabezasSacrificio.ReadOnly = True
        Me.CantCabezasSacrificio.Width = 70
        '
        'KilosSacrificio
        '
        Me.KilosSacrificio.DataPropertyName = "KilosSacrificio"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.KilosSacrificio.DefaultCellStyle = DataGridViewCellStyle2
        Me.KilosSacrificio.HeaderText = "Kilos Sacrificio"
        Me.KilosSacrificio.Name = "KilosSacrificio"
        Me.KilosSacrificio.ReadOnly = True
        Me.KilosSacrificio.Visible = False
        Me.KilosSacrificio.Width = 70
        '
        'Canales
        '
        Me.Canales.DataPropertyName = "CantCanales"
        Me.Canales.HeaderText = "Canales"
        Me.Canales.Name = "Canales"
        Me.Canales.ReadOnly = True
        '
        'ReporteRegistroSacrificio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 442)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.CmbIntroductor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtLoteSacrificio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgvSacrificios)
        Me.Controls.Add(Me.Label17)
        Me.Name = "ReporteRegistroSacrificio"
        Me.Text = "Reporte Registro de Sacrificios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvSacrificios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents BtnImprimir As System.Windows.Forms.Button
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents CmbIntroductor As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLoteSacrificio As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DgvSacrificios As System.Windows.Forms.DataGridView
    Friend WithEvents LoteSacrificio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoteRastro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaSacrificio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantCabezasSacrificio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosSacrificio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Canales As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
