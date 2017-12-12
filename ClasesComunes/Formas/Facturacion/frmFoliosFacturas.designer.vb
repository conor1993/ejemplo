<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFoliosFacturas
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
        Me.sucursalesC = New ClasesNegocio.SucursalCollectionClass
        Me.Mtb = New MEAToolBar.MEAToolBar
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtFolioInicial = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtSerie = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtConsecutivo = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'sucursalesC
        '
        Me.sucursalesC.AllowEdit = True
        Me.sucursalesC.AllowNew = True
        Me.sucursalesC.AllowRemove = True
        Me.sucursalesC.MaximoElementosSeleccionados = 1
        Me.sucursalesC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.sucursalesC.MostrarAlertas = False
        Me.sucursalesC.Name = ""
        Me.sucursalesC.RaiseListChangedEvents = True
        Me.sucursalesC.Transaction = Nothing
        '
        'Mtb
        '
        Me.Mtb.ButtonSize = New System.Drawing.Size(50, 50)
        Me.Mtb.Dock = System.Windows.Forms.DockStyle.None
        Me.Mtb.DropDownArrows = True
        Me.Mtb.HabilitarBorrar = True
        Me.Mtb.HabilitarBuscar = False
        Me.Mtb.HabilitarCancelar = True
        Me.Mtb.HabilitarEditar = True
        Me.Mtb.HabilitarGuardar = True
        Me.Mtb.HabilitarImprimir = True
        Me.Mtb.HabilitarLimpiar = True
        Me.Mtb.HabilitarNuevo = True
        Me.Mtb.HabilitarSalir = True
        Me.Mtb.ImageButtonSize = MEAToolBar.MEAToolBar.ImageButtonSizeEnum.de32
        Me.Mtb.Location = New System.Drawing.Point(3, -54)
        Me.Mtb.MostrarBorrar = False
        Me.Mtb.MostrarBuscar = False
        Me.Mtb.MostrarCancelar = False
        Me.Mtb.MostrarEditar = False
        Me.Mtb.MostrarGuardar = True
        Me.Mtb.MostrarImprimir = False
        Me.Mtb.MostrarLimpiar = False
        Me.Mtb.MostrarNuevo = False
        Me.Mtb.MostrarSalir = True
        Me.Mtb.Name = "Mtb"
        Me.Mtb.ShowToolTips = True
        Me.Mtb.Size = New System.Drawing.Size(50, 266)
        Me.Mtb.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.SteelBlue
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(56, 0)
        Me.Label5.MaximumSize = New System.Drawing.Size(1600, 800)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(262, 29)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Folios de Facturas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Folio Inicial:"
        '
        'txtFolioInicial
        '
        Me.txtFolioInicial.Location = New System.Drawing.Point(161, 43)
        Me.txtFolioInicial.MaxLength = 19
        Me.txtFolioInicial.Name = "txtFolioInicial"
        Me.txtFolioInicial.Size = New System.Drawing.Size(100, 20)
        Me.txtFolioInicial.TabIndex = 5
        Me.txtFolioInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Serie:"
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(161, 69)
        Me.txtSerie.MaxLength = 10
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(100, 20)
        Me.txtSerie.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(86, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Consecutivo:"
        '
        'txtConsecutivo
        '
        Me.txtConsecutivo.Location = New System.Drawing.Point(161, 95)
        Me.txtConsecutivo.Name = "txtConsecutivo"
        Me.txtConsecutivo.ReadOnly = True
        Me.txtConsecutivo.Size = New System.Drawing.Size(100, 20)
        Me.txtConsecutivo.TabIndex = 9
        '
        'frmFoliosFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 133)
        Me.Controls.Add(Me.txtConsecutivo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSerie)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFolioInicial)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Mtb)
        Me.Name = "frmFoliosFacturas"
        Me.Text = "Folios de Facturas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Mtb As MEAToolBar.MEAToolBar
    Friend WithEvents sucursalesC As New ClasesNegocio.SucursalCollectionClass
    Friend WithEvents SucursalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ConsecutivoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SerieDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFolioInicial As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtConsecutivo As System.Windows.Forms.TextBox
End Class
