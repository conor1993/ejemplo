<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _960BusquasedaLotesDeCortes
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
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.CmbIntroductor = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.DtpFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.gbFechas = New System.Windows.Forms.GroupBox
        Me.DtpFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.txtLoteCorte = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnAceptar = New System.Windows.Forms.Button
        Me.DgvLotes = New System.Windows.Forms.DataGridView
        Me.clmLoteCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmLoteSacrificio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmIntroductor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmlKilos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmFechaCorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmTipoLote = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmDiasCad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmPiezas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button1 = New System.Windows.Forms.Button
        Me.gbResultadoBusqueda = New System.Windows.Forms.GroupBox
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.chkFecha = New System.Windows.Forms.CheckBox
        Me.gbEstatus = New System.Windows.Forms.GroupBox
        Me.chkCerrado = New System.Windows.Forms.CheckBox
        Me.chkVigentes = New System.Windows.Forms.CheckBox
        Me.chkReproceso = New System.Windows.Forms.CheckBox
        Me.chkProduccion = New System.Windows.Forms.CheckBox
        Me.gbTipoLote = New System.Windows.Forms.GroupBox
        Me.gbFechas.SuspendLayout()
        CType(Me.DgvLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbResultadoBusqueda.SuspendLayout()
        Me.gbEstatus.SuspendLayout()
        Me.gbTipoLote.SuspendLayout()
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
        Me.Label17.Size = New System.Drawing.Size(926, 32)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "SELECCIONE UN LOTE DE CORTES PARA CAPTURAR CORTES"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha Final :"
        '
        'CmbIntroductor
        '
        Me.CmbIntroductor.FormattingEnabled = True
        Me.CmbIntroductor.Location = New System.Drawing.Point(144, 64)
        Me.CmbIntroductor.Name = "CmbIntroductor"
        Me.CmbIntroductor.Size = New System.Drawing.Size(348, 21)
        Me.CmbIntroductor.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Introductor :"
        '
        'DtpFechaFinal
        '
        Me.DtpFechaFinal.CustomFormat = "dd/MM/yyyy"
        Me.DtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpFechaFinal.Location = New System.Drawing.Point(92, 45)
        Me.DtpFechaFinal.Name = "DtpFechaFinal"
        Me.DtpFechaFinal.Size = New System.Drawing.Size(92, 20)
        Me.DtpFechaFinal.TabIndex = 3
        '
        'gbFechas
        '
        Me.gbFechas.Controls.Add(Me.DtpFechaFinal)
        Me.gbFechas.Controls.Add(Me.DtpFechaInicio)
        Me.gbFechas.Controls.Add(Me.Label3)
        Me.gbFechas.Controls.Add(Me.Label2)
        Me.gbFechas.Enabled = False
        Me.gbFechas.Location = New System.Drawing.Point(716, 56)
        Me.gbFechas.Name = "gbFechas"
        Me.gbFechas.Size = New System.Drawing.Size(192, 75)
        Me.gbFechas.TabIndex = 9
        Me.gbFechas.TabStop = False
        Me.gbFechas.Text = "Rango de Fechas"
        '
        'DtpFechaInicio
        '
        Me.DtpFechaInicio.CustomFormat = "dd/MM/yyyy"
        Me.DtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpFechaInicio.Location = New System.Drawing.Point(92, 19)
        Me.DtpFechaInicio.Name = "DtpFechaInicio"
        Me.DtpFechaInicio.Size = New System.Drawing.Size(92, 20)
        Me.DtpFechaInicio.TabIndex = 1
        '
        'txtLoteCorte
        '
        Me.txtLoteCorte.Location = New System.Drawing.Point(144, 38)
        Me.txtLoteCorte.Name = "txtLoteCorte"
        Me.txtLoteCorte.Size = New System.Drawing.Size(100, 20)
        Me.txtLoteCorte.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Lote de Cortes: "
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(808, 576)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 11
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'DgvLotes
        '
        Me.DgvLotes.AllowUserToAddRows = False
        Me.DgvLotes.AllowUserToDeleteRows = False
        Me.DgvLotes.AllowUserToResizeRows = False
        Me.DgvLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvLotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmLoteCorte, Me.clmLoteSacrificio, Me.clmIntroductor, Me.cmlKilos, Me.clmFechaCorte, Me.clmTipoLote, Me.clmEstatus, Me.clmDiasCad, Me.clmPiezas})
        Me.DgvLotes.Location = New System.Drawing.Point(6, 19)
        Me.DgvLotes.MultiSelect = False
        Me.DgvLotes.Name = "DgvLotes"
        Me.DgvLotes.ReadOnly = True
        Me.DgvLotes.RowHeadersVisible = False
        Me.DgvLotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvLotes.Size = New System.Drawing.Size(898, 408)
        Me.DgvLotes.TabIndex = 0
        '
        'clmLoteCorte
        '
        Me.clmLoteCorte.DataPropertyName = "LoteCorte"
        Me.clmLoteCorte.HeaderText = "Lote Corte"
        Me.clmLoteCorte.Name = "clmLoteCorte"
        Me.clmLoteCorte.ReadOnly = True
        '
        'clmLoteSacrificio
        '
        Me.clmLoteSacrificio.DataPropertyName = "LoteSacrificio"
        Me.clmLoteSacrificio.HeaderText = "Lote Sacrificio"
        Me.clmLoteSacrificio.Name = "clmLoteSacrificio"
        Me.clmLoteSacrificio.ReadOnly = True
        Me.clmLoteSacrificio.Visible = False
        '
        'clmIntroductor
        '
        Me.clmIntroductor.DataPropertyName = "Introductor"
        Me.clmIntroductor.HeaderText = "Introductor"
        Me.clmIntroductor.Name = "clmIntroductor"
        Me.clmIntroductor.ReadOnly = True
        Me.clmIntroductor.Width = 200
        '
        'cmlKilos
        '
        Me.cmlKilos.DataPropertyName = "TotalKgs"
        Me.cmlKilos.HeaderText = "Kgrs Producidos"
        Me.cmlKilos.Name = "cmlKilos"
        Me.cmlKilos.ReadOnly = True
        '
        'clmFechaCorte
        '
        Me.clmFechaCorte.DataPropertyName = "FechaCorte"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.clmFechaCorte.DefaultCellStyle = DataGridViewCellStyle1
        Me.clmFechaCorte.HeaderText = "Fecha de Corte"
        Me.clmFechaCorte.Name = "clmFechaCorte"
        Me.clmFechaCorte.ReadOnly = True
        '
        'clmTipoLote
        '
        Me.clmTipoLote.DataPropertyName = "TipoLote"
        Me.clmTipoLote.HeaderText = "Tipo Lote"
        Me.clmTipoLote.Name = "clmTipoLote"
        Me.clmTipoLote.ReadOnly = True
        '
        'clmEstatus
        '
        Me.clmEstatus.DataPropertyName = "EstatusCad"
        Me.clmEstatus.HeaderText = "Estatus"
        Me.clmEstatus.Name = "clmEstatus"
        Me.clmEstatus.ReadOnly = True
        '
        'clmDiasCad
        '
        Me.clmDiasCad.DataPropertyName = "DiasCad"
        Me.clmDiasCad.HeaderText = "Dias Cad"
        Me.clmDiasCad.Name = "clmDiasCad"
        Me.clmDiasCad.ReadOnly = True
        Me.clmDiasCad.Visible = False
        '
        'clmPiezas
        '
        Me.clmPiezas.DataPropertyName = "TotalPzas"
        Me.clmPiezas.HeaderText = "Piezas"
        Me.clmPiezas.Name = "clmPiezas"
        Me.clmPiezas.ReadOnly = True
        Me.clmPiezas.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(889, 576)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'gbResultadoBusqueda
        '
        Me.gbResultadoBusqueda.Controls.Add(Me.DgvLotes)
        Me.gbResultadoBusqueda.Location = New System.Drawing.Point(54, 137)
        Me.gbResultadoBusqueda.Name = "gbResultadoBusqueda"
        Me.gbResultadoBusqueda.Size = New System.Drawing.Size(910, 433)
        Me.gbResultadoBusqueda.TabIndex = 10
        Me.gbResultadoBusqueda.TabStop = False
        Me.gbResultadoBusqueda.Text = "Resultado Busqueda"
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
        Me.mtb.MostrarBuscar = True
        Me.mtb.MostrarCancelar = False
        Me.mtb.MostrarEditar = False
        Me.mtb.MostrarGuardar = False
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 611)
        Me.mtb.TabIndex = 0
        '
        'chkFecha
        '
        Me.chkFecha.AutoSize = True
        Me.chkFecha.Location = New System.Drawing.Point(716, 35)
        Me.chkFecha.Name = "chkFecha"
        Me.chkFecha.Size = New System.Drawing.Size(103, 17)
        Me.chkFecha.TabIndex = 8
        Me.chkFecha.Text = "Filtrar Por Fecha"
        Me.chkFecha.UseVisualStyleBackColor = True
        '
        'gbEstatus
        '
        Me.gbEstatus.Controls.Add(Me.chkCerrado)
        Me.gbEstatus.Controls.Add(Me.chkVigentes)
        Me.gbEstatus.Location = New System.Drawing.Point(498, 35)
        Me.gbEstatus.Name = "gbEstatus"
        Me.gbEstatus.Size = New System.Drawing.Size(212, 45)
        Me.gbEstatus.TabIndex = 6
        Me.gbEstatus.TabStop = False
        Me.gbEstatus.Text = "Estatus"
        '
        'chkCerrado
        '
        Me.chkCerrado.AutoSize = True
        Me.chkCerrado.Checked = True
        Me.chkCerrado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCerrado.Location = New System.Drawing.Point(92, 19)
        Me.chkCerrado.Name = "chkCerrado"
        Me.chkCerrado.Size = New System.Drawing.Size(79, 17)
        Me.chkCerrado.TabIndex = 1
        Me.chkCerrado.Text = "CERRADO"
        Me.chkCerrado.UseVisualStyleBackColor = True
        '
        'chkVigentes
        '
        Me.chkVigentes.AutoSize = True
        Me.chkVigentes.Checked = True
        Me.chkVigentes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVigentes.Location = New System.Drawing.Point(6, 19)
        Me.chkVigentes.Name = "chkVigentes"
        Me.chkVigentes.Size = New System.Drawing.Size(80, 17)
        Me.chkVigentes.TabIndex = 0
        Me.chkVigentes.Text = "VIGENTES"
        Me.chkVigentes.UseVisualStyleBackColor = True
        '
        'chkReproceso
        '
        Me.chkReproceso.AutoSize = True
        Me.chkReproceso.Checked = True
        Me.chkReproceso.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkReproceso.Location = New System.Drawing.Point(110, 19)
        Me.chkReproceso.Name = "chkReproceso"
        Me.chkReproceso.Size = New System.Drawing.Size(93, 17)
        Me.chkReproceso.TabIndex = 1
        Me.chkReproceso.Text = "REPROCESO"
        Me.chkReproceso.UseVisualStyleBackColor = True
        '
        'chkProduccion
        '
        Me.chkProduccion.AutoSize = True
        Me.chkProduccion.Checked = True
        Me.chkProduccion.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkProduccion.Location = New System.Drawing.Point(6, 19)
        Me.chkProduccion.Name = "chkProduccion"
        Me.chkProduccion.Size = New System.Drawing.Size(98, 17)
        Me.chkProduccion.TabIndex = 0
        Me.chkProduccion.Text = "PRODUCCIÓN"
        Me.chkProduccion.UseVisualStyleBackColor = True
        '
        'gbTipoLote
        '
        Me.gbTipoLote.Controls.Add(Me.chkProduccion)
        Me.gbTipoLote.Controls.Add(Me.chkReproceso)
        Me.gbTipoLote.Location = New System.Drawing.Point(498, 86)
        Me.gbTipoLote.Name = "gbTipoLote"
        Me.gbTipoLote.Size = New System.Drawing.Size(212, 45)
        Me.gbTipoLote.TabIndex = 7
        Me.gbTipoLote.TabStop = False
        Me.gbTipoLote.Text = "Tipo Lote"
        '
        '_960BusquasedaLotesDeCortes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 611)
        Me.Controls.Add(Me.gbTipoLote)
        Me.Controls.Add(Me.gbEstatus)
        Me.Controls.Add(Me.chkFecha)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.gbResultadoBusqueda)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.CmbIntroductor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.gbFechas)
        Me.Controls.Add(Me.txtLoteCorte)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "_960BusquasedaLotesDeCortes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccione un lote de cortes para capturar cortes"
        Me.gbFechas.ResumeLayout(False)
        Me.gbFechas.PerformLayout()
        CType(Me.DgvLotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbResultadoBusqueda.ResumeLayout(False)
        Me.gbEstatus.ResumeLayout(False)
        Me.gbEstatus.PerformLayout()
        Me.gbTipoLote.ResumeLayout(False)
        Me.gbTipoLote.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmbIntroductor As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbFechas As System.Windows.Forms.GroupBox
    Friend WithEvents DtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtLoteCorte As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents DgvLotes As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents gbResultadoBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents chkFecha As System.Windows.Forms.CheckBox
    Friend WithEvents gbEstatus As System.Windows.Forms.GroupBox
    Friend WithEvents chkCerrado As System.Windows.Forms.CheckBox
    Friend WithEvents chkVigentes As System.Windows.Forms.CheckBox
    Friend WithEvents chkReproceso As System.Windows.Forms.CheckBox
    Friend WithEvents chkProduccion As System.Windows.Forms.CheckBox
    Friend WithEvents gbTipoLote As System.Windows.Forms.GroupBox
    Friend WithEvents clmLoteCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmLoteSacrificio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmIntroductor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmlKilos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmFechaCorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTipoLote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmDiasCad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmPiezas As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
