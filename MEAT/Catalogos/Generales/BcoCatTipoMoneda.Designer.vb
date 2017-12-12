<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BcoCatTipoMoneda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BcoCatTipoMoneda))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ChkEsMonedaLocal = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGrid = New System.Windows.Forms.DataGridView
        Me.CodigoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionCtaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ObservacionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.clmMonedaLocal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstatusColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtObservacion = New System.Windows.Forms.TextBox
        Me.TxtDescCorta = New System.Windows.Forms.TextBox
        Me.TxtDescripcion = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtCodigo = New System.Windows.Forms.TextBox
        Me.lblEstatus = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Name = "Label1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ChkEsMonedaLocal)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.DtpFecha)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TxtObservacion)
        Me.Panel1.Controls.Add(Me.TxtDescCorta)
        Me.Panel1.Controls.Add(Me.TxtDescripcion)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtCodigo)
        Me.Panel1.Controls.Add(Me.lblEstatus)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'ChkEsMonedaLocal
        '
        resources.ApplyResources(Me.ChkEsMonedaLocal, "ChkEsMonedaLocal")
        Me.ChkEsMonedaLocal.Name = "ChkEsMonedaLocal"
        Me.ChkEsMonedaLocal.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGrid)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.AllowUserToResizeRows = False
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoColumn, Me.DescripcionColumn, Me.DescripcionCtaColumn, Me.ObservacionColumn, Me.FechaColumn, Me.clmMonedaLocal, Me.EstatusColumn})
        resources.ApplyResources(Me.DataGrid, "DataGrid")
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'CodigoColumn
        '
        resources.ApplyResources(Me.CodigoColumn, "CodigoColumn")
        Me.CodigoColumn.Name = "CodigoColumn"
        Me.CodigoColumn.ReadOnly = True
        '
        'DescripcionColumn
        '
        resources.ApplyResources(Me.DescripcionColumn, "DescripcionColumn")
        Me.DescripcionColumn.Name = "DescripcionColumn"
        Me.DescripcionColumn.ReadOnly = True
        '
        'DescripcionCtaColumn
        '
        resources.ApplyResources(Me.DescripcionCtaColumn, "DescripcionCtaColumn")
        Me.DescripcionCtaColumn.Name = "DescripcionCtaColumn"
        Me.DescripcionCtaColumn.ReadOnly = True
        '
        'ObservacionColumn
        '
        resources.ApplyResources(Me.ObservacionColumn, "ObservacionColumn")
        Me.ObservacionColumn.Name = "ObservacionColumn"
        Me.ObservacionColumn.ReadOnly = True
        '
        'FechaColumn
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.FechaColumn.DefaultCellStyle = DataGridViewCellStyle1
        resources.ApplyResources(Me.FechaColumn, "FechaColumn")
        Me.FechaColumn.Name = "FechaColumn"
        Me.FechaColumn.ReadOnly = True
        '
        'clmMonedaLocal
        '
        resources.ApplyResources(Me.clmMonedaLocal, "clmMonedaLocal")
        Me.clmMonedaLocal.Name = "clmMonedaLocal"
        Me.clmMonedaLocal.ReadOnly = True
        '
        'EstatusColumn
        '
        resources.ApplyResources(Me.EstatusColumn, "EstatusColumn")
        Me.EstatusColumn.Name = "EstatusColumn"
        Me.EstatusColumn.ReadOnly = True
        '
        'DtpFecha
        '
        resources.ApplyResources(Me.DtpFecha, "DtpFecha")
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Name = "DtpFecha"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'TxtObservacion
        '
        Me.TxtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.TxtObservacion, "TxtObservacion")
        Me.TxtObservacion.Name = "TxtObservacion"
        '
        'TxtDescCorta
        '
        Me.TxtDescCorta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.TxtDescCorta, "TxtDescCorta")
        Me.TxtDescCorta.Name = "TxtDescCorta"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.TxtDescripcion, "TxtDescripcion")
        Me.TxtDescripcion.Name = "TxtDescripcion"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.TxtCodigo, "TxtCodigo")
        Me.TxtCodigo.Name = "TxtCodigo"
        '
        'lblEstatus
        '
        Me.lblEstatus.BackColor = System.Drawing.Color.Navy
        resources.ApplyResources(Me.lblEstatus, "lblEstatus")
        Me.lblEstatus.ForeColor = System.Drawing.Color.White
        Me.lblEstatus.Name = "lblEstatus"
        '
        'mtb
        '
        resources.ApplyResources(Me.mtb, "mtb")
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
        Me.mtb.MostrarBorrar = True
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = True
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = True
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        '
        'BcoCatTipoMoneda
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mtb)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "BcoCatTipoMoneda"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblEstatus As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents TxtDescCorta As System.Windows.Forms.TextBox
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents ChkEsMonedaLocal As System.Windows.Forms.CheckBox
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CodigoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionCtaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObservacionColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmMonedaLocal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstatusColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
