<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusquedaPolizasDiario
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
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.grid = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbMes = New System.Windows.Forms.ComboBox
        Me.cmbAño = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSSSubCta = New System.Windows.Forms.TextBox
        Me.txtSSubCta = New System.Windows.Forms.TextBox
        Me.txtSubCta = New System.Windows.Forms.TextBox
        Me.txtCta = New System.Windows.Forms.TextBox
        Me.chkFechas = New System.Windows.Forms.CheckBox
        Me.gbFechas = New System.Windows.Forms.GroupBox
        Me.DtpFechaFin = New System.Windows.Forms.DateTimePicker
        Me.DtpFechaIni = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbFechas.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(515, 92)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(102, 23)
        Me.btnBuscar.TabIndex = 177
        Me.btnBuscar.Text = "Obtener Pólizas"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.AllowUserToOrderColumns = True
        Me.grid.AllowUserToResizeColumns = False
        Me.grid.AllowUserToResizeRows = False
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(29, 121)
        Me.grid.MultiSelect = False
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(599, 199)
        Me.grid.TabIndex = 172
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbMes)
        Me.GroupBox1.Controls.Add(Me.cmbAño)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtSSSubCta)
        Me.GroupBox1.Controls.Add(Me.txtSSubCta)
        Me.GroupBox1.Controls.Add(Me.txtSubCta)
        Me.GroupBox1.Controls.Add(Me.txtCta)
        Me.GroupBox1.Controls.Add(Me.chkFechas)
        Me.GroupBox1.Controls.Add(Me.gbFechas)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(599, 78)
        Me.GroupBox1.TabIndex = 179
        Me.GroupBox1.TabStop = False
        '
        'cmbMes
        '
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Location = New System.Drawing.Point(49, 22)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(121, 21)
        Me.cmbMes.TabIndex = 186
        '
        'cmbAño
        '
        Me.cmbAño.FormattingEnabled = True
        Me.cmbAño.Location = New System.Drawing.Point(49, 47)
        Me.cmbAño.Name = "cmbAño"
        Me.cmbAño.Size = New System.Drawing.Size(121, 21)
        Me.cmbAño.TabIndex = 185
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 184
        Me.Label3.Text = "Año:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 183
        Me.Label1.Text = "Mes:"
        '
        'txtSSSubCta
        '
        Me.txtSSSubCta.Location = New System.Drawing.Point(540, 19)
        Me.txtSSSubCta.MaxLength = 4
        Me.txtSSSubCta.Name = "txtSSSubCta"
        Me.txtSSSubCta.Size = New System.Drawing.Size(48, 20)
        Me.txtSSSubCta.TabIndex = 182
        Me.txtSSSubCta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSSSubCta.Visible = False
        '
        'txtSSubCta
        '
        Me.txtSSubCta.Location = New System.Drawing.Point(486, 19)
        Me.txtSSubCta.MaxLength = 4
        Me.txtSSubCta.Name = "txtSSubCta"
        Me.txtSSubCta.Size = New System.Drawing.Size(48, 20)
        Me.txtSSubCta.TabIndex = 181
        Me.txtSSubCta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSSubCta.Visible = False
        '
        'txtSubCta
        '
        Me.txtSubCta.Location = New System.Drawing.Point(176, 48)
        Me.txtSubCta.MaxLength = 4
        Me.txtSubCta.Name = "txtSubCta"
        Me.txtSubCta.Size = New System.Drawing.Size(48, 20)
        Me.txtSubCta.TabIndex = 180
        Me.txtSubCta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSubCta.Visible = False
        '
        'txtCta
        '
        Me.txtCta.Location = New System.Drawing.Point(176, 22)
        Me.txtCta.MaxLength = 4
        Me.txtCta.Name = "txtCta"
        Me.txtCta.Size = New System.Drawing.Size(48, 20)
        Me.txtCta.TabIndex = 179
        Me.txtCta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCta.Visible = False
        '
        'chkFechas
        '
        Me.chkFechas.AutoSize = True
        Me.chkFechas.Checked = True
        Me.chkFechas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFechas.Location = New System.Drawing.Point(250, 24)
        Me.chkFechas.Name = "chkFechas"
        Me.chkFechas.Size = New System.Drawing.Size(171, 17)
        Me.chkFechas.TabIndex = 173
        Me.chkFechas.Text = "Omitir filtro Intervalo de Fechas"
        Me.chkFechas.UseVisualStyleBackColor = True
        '
        'gbFechas
        '
        Me.gbFechas.Controls.Add(Me.DtpFechaFin)
        Me.gbFechas.Controls.Add(Me.DtpFechaIni)
        Me.gbFechas.Controls.Add(Me.Label2)
        Me.gbFechas.Location = New System.Drawing.Point(244, 37)
        Me.gbFechas.Name = "gbFechas"
        Me.gbFechas.Size = New System.Drawing.Size(344, 33)
        Me.gbFechas.TabIndex = 172
        Me.gbFechas.TabStop = False
        '
        'DtpFechaFin
        '
        Me.DtpFechaFin.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaptionText
        Me.DtpFechaFin.Enabled = False
        Me.DtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaFin.Location = New System.Drawing.Point(235, 10)
        Me.DtpFechaFin.Name = "DtpFechaFin"
        Me.DtpFechaFin.Size = New System.Drawing.Size(100, 20)
        Me.DtpFechaFin.TabIndex = 174
        '
        'DtpFechaIni
        '
        Me.DtpFechaIni.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaptionText
        Me.DtpFechaIni.Enabled = False
        Me.DtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaIni.Location = New System.Drawing.Point(115, 10)
        Me.DtpFechaIni.Name = "DtpFechaIni"
        Me.DtpFechaIni.Size = New System.Drawing.Size(100, 20)
        Me.DtpFechaIni.TabIndex = 173
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 172
        Me.Label2.Text = "Intervalo de Fechas:"
        '
        'BusquedaPolizasDiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 333)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.grid)
        Me.Name = "BusquedaPolizasDiario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BusquedaPolizasDiario"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbFechas.ResumeLayout(False)
        Me.gbFechas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkFechas As System.Windows.Forms.CheckBox
    Friend WithEvents gbFechas As System.Windows.Forms.GroupBox
    Friend WithEvents DtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSSSubCta As System.Windows.Forms.TextBox
    Friend WithEvents txtSSubCta As System.Windows.Forms.TextBox
    Friend WithEvents txtSubCta As System.Windows.Forms.TextBox
    Friend WithEvents txtCta As System.Windows.Forms.TextBox
    Friend WithEvents cmbMes As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAño As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
