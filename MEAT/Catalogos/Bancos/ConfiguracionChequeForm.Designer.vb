<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfiguracionChequeForm
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
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.gpoCuentas = New System.Windows.Forms.GroupBox
        Me.lv = New System.Windows.Forms.ListView
        Me.chCuenta = New System.Windows.Forms.ColumnHeader
        Me.chDescripcion = New System.Windows.Forms.ColumnHeader
        Me.chTipoMoneda = New System.Windows.Forms.ColumnHeader
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCuenta = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbBanco = New System.Windows.Forms.ComboBox
        Me.Bancos = New ClasesNegocio.BancosCollectionClass
        Me.txtBanco = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtFolioActual = New Integra.Controles.TextboxInteger
        Me.pan = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCarpeta = New System.Windows.Forms.TextBox
        Me.Carpeta = New System.Windows.Forms.FolderBrowserDialog
        Me.btnCarpeta = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtImpresora = New System.Windows.Forms.TextBox
        Me.btnImpresora = New System.Windows.Forms.Button
        Me.Impresora = New System.Windows.Forms.PrintDialog
        Me.gpoCuentas.SuspendLayout()
        Me.pan.SuspendLayout()
        Me.SuspendLayout()
        '
        'mtb
        '
        Me.mtb.ButtonSize = New System.Drawing.Size(50, 50)
        Me.mtb.Dock = System.Windows.Forms.DockStyle.None
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
        Me.mtb.Location = New System.Drawing.Point(3, -26)
        Me.mtb.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.mtb.MostrarBorrar = False
        Me.mtb.MostrarBuscar = False
        Me.mtb.MostrarCancelar = True
        Me.mtb.MostrarEditar = True
        Me.mtb.MostrarGuardar = True
        Me.mtb.MostrarImprimir = False
        Me.mtb.MostrarLimpiar = True
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 519)
        Me.mtb.TabIndex = 2
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitulo.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(712, 30)
        Me.lblTitulo.TabIndex = 3
        Me.lblTitulo.Text = "Label1"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gpoCuentas
        '
        Me.gpoCuentas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpoCuentas.Controls.Add(Me.lv)
        Me.gpoCuentas.Controls.Add(Me.Label6)
        Me.gpoCuentas.Controls.Add(Me.txtCuenta)
        Me.gpoCuentas.Location = New System.Drawing.Point(3, 38)
        Me.gpoCuentas.Name = "gpoCuentas"
        Me.gpoCuentas.Size = New System.Drawing.Size(639, 147)
        Me.gpoCuentas.TabIndex = 9
        Me.gpoCuentas.TabStop = False
        Me.gpoCuentas.Text = "Cuentas"
        '
        'lv
        '
        Me.lv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chCuenta, Me.chDescripcion, Me.chTipoMoneda})
        Me.lv.FullRowSelect = True
        Me.lv.Location = New System.Drawing.Point(6, 19)
        Me.lv.MultiSelect = False
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(627, 96)
        Me.lv.TabIndex = 0
        Me.lv.UseCompatibleStateImageBehavior = False
        Me.lv.View = System.Windows.Forms.View.Details
        '
        'chCuenta
        '
        Me.chCuenta.Text = "Nº Cuenta"
        Me.chCuenta.Width = 200
        '
        'chDescripcion
        '
        Me.chDescripcion.Text = "Descripción"
        Me.chDescripcion.Width = 300
        '
        'chTipoMoneda
        '
        Me.chTipoMoneda.Text = "Folio Actual"
        Me.chTipoMoneda.Width = 100
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Cuenta Seleccionada:"
        '
        'txtCuenta
        '
        Me.txtCuenta.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtCuenta.Location = New System.Drawing.Point(124, 119)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.ReadOnly = True
        Me.txtCuenta.Size = New System.Drawing.Size(415, 22)
        Me.txtCuenta.TabIndex = 1
        Me.txtCuenta.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Banco:"
        '
        'cmbBanco
        '
        Me.cmbBanco.DataSource = Me.Bancos
        Me.cmbBanco.DisplayMember = "Descripcion"
        Me.cmbBanco.FormattingEnabled = True
        Me.cmbBanco.Location = New System.Drawing.Point(189, 12)
        Me.cmbBanco.Name = "cmbBanco"
        Me.cmbBanco.Size = New System.Drawing.Size(272, 21)
        Me.cmbBanco.TabIndex = 8
        Me.cmbBanco.ValueMember = "DescripcionCta"
        '
        'Bancos
        '
        Me.Bancos.AllowEdit = True
        Me.Bancos.AllowNew = True
        Me.Bancos.AllowRemove = True
        Me.Bancos.Name = ""
        Me.Bancos.RaiseListChangedEvents = True
        '
        'txtBanco
        '
        Me.txtBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBanco.Location = New System.Drawing.Point(83, 12)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(100, 20)
        Me.txtBanco.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Folio Actual:"
        '
        'txtFolioActual
        '
        Me.txtFolioActual.Location = New System.Drawing.Point(182, 231)
        Me.txtFolioActual.Name = "txtFolioActual"
        Me.txtFolioActual.Signo = Integra.Controles.TextboxInteger.RespuestaEnum.NO
        Me.txtFolioActual.Size = New System.Drawing.Size(100, 20)
        Me.txtFolioActual.TabIndex = 10
        Me.txtFolioActual.Text = "0"
        Me.txtFolioActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pan
        '
        Me.pan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pan.Controls.Add(Me.Label1)
        Me.pan.Controls.Add(Me.txtBanco)
        Me.pan.Controls.Add(Me.gpoCuentas)
        Me.pan.Controls.Add(Me.cmbBanco)
        Me.pan.Location = New System.Drawing.Point(55, 34)
        Me.pan.Name = "pan"
        Me.pan.Size = New System.Drawing.Size(645, 191)
        Me.pan.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 286)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Carpeta Temporal:"
        '
        'txtCarpeta
        '
        Me.txtCarpeta.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtCarpeta.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtCarpeta.Location = New System.Drawing.Point(182, 283)
        Me.txtCarpeta.Name = "txtCarpeta"
        Me.txtCarpeta.ReadOnly = True
        Me.txtCarpeta.Size = New System.Drawing.Size(478, 20)
        Me.txtCarpeta.TabIndex = 13
        Me.txtCarpeta.TabStop = False
        Me.txtCarpeta.Tag = "Esta carpeta es necesaria para la impresión del cheque ya que se manda un archivo" & _
            " temporal para su posterior impresión."
        '
        'btnCarpeta
        '
        Me.btnCarpeta.Location = New System.Drawing.Point(666, 281)
        Me.btnCarpeta.Name = "btnCarpeta"
        Me.btnCarpeta.Size = New System.Drawing.Size(25, 23)
        Me.btnCarpeta.TabIndex = 14
        Me.btnCarpeta.Text = "..."
        Me.btnCarpeta.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(64, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Impresora:"
        '
        'txtImpresora
        '
        Me.txtImpresora.BackColor = System.Drawing.Color.LemonChiffon
        Me.txtImpresora.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtImpresora.Location = New System.Drawing.Point(182, 257)
        Me.txtImpresora.Name = "txtImpresora"
        Me.txtImpresora.ReadOnly = True
        Me.txtImpresora.Size = New System.Drawing.Size(478, 20)
        Me.txtImpresora.TabIndex = 13
        Me.txtImpresora.TabStop = False
        Me.txtImpresora.Tag = "Esta carpeta es necesaria para la impresión del cheque ya que se manda un archivo" & _
            " temporal para su posterior impresión."
        '
        'btnImpresora
        '
        Me.btnImpresora.Location = New System.Drawing.Point(666, 254)
        Me.btnImpresora.Name = "btnImpresora"
        Me.btnImpresora.Size = New System.Drawing.Size(25, 23)
        Me.btnImpresora.TabIndex = 14
        Me.btnImpresora.Text = "..."
        Me.btnImpresora.UseVisualStyleBackColor = True
        '
        'Impresora
        '
        Me.Impresora.UseEXDialog = True
        '
        'ConfiguracionChequeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 341)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnImpresora)
        Me.Controls.Add(Me.btnCarpeta)
        Me.Controls.Add(Me.txtImpresora)
        Me.Controls.Add(Me.txtCarpeta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pan)
        Me.Controls.Add(Me.txtFolioActual)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ConfiguracionChequeForm"
        Me.Text = "Configuración de Cheques"
        Me.gpoCuentas.ResumeLayout(False)
        Me.gpoCuentas.PerformLayout()
        Me.pan.ResumeLayout(False)
        Me.pan.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents gpoCuentas As System.Windows.Forms.GroupBox
    Friend WithEvents lv As System.Windows.Forms.ListView
    Friend WithEvents chCuenta As System.Windows.Forms.ColumnHeader
    Friend WithEvents chDescripcion As System.Windows.Forms.ColumnHeader
    Friend WithEvents chTipoMoneda As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbBanco As System.Windows.Forms.ComboBox
    Friend WithEvents txtBanco As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFolioActual As Integra.Controles.TextboxInteger
    Friend WithEvents pan As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCarpeta As System.Windows.Forms.TextBox
    Friend WithEvents Carpeta As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnCarpeta As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtImpresora As System.Windows.Forms.TextBox
    Friend WithEvents btnImpresora As System.Windows.Forms.Button
    Friend WithEvents Impresora As System.Windows.Forms.PrintDialog
    Friend WithEvents Bancos As ClasesNegocio.BancosCollectionClass
End Class
