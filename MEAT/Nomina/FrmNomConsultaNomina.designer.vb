<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNomConsultaNomina
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
        Me.Label17 = New System.Windows.Forms.Label
        Me.mtb = New MEAToolBar.MEAToolBar
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.dgvConsultaNomina = New System.Windows.Forms.DataGridView
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Sueldo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Comisiones = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ImporteHRE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ISRSubsidio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CuotaMensual = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Prestamos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Infonavit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PensionAlimenticia = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgvConsultaNomina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(50, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(785, 37)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Consulta de Nomina"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.mtb.MostrarImprimir = True
        Me.mtb.MostrarLimpiar = False
        Me.mtb.MostrarNuevo = False
        Me.mtb.MostrarSalir = True
        Me.mtb.Name = "mtb"
        Me.mtb.ShowToolTips = True
        Me.mtb.Size = New System.Drawing.Size(50, 418)
        Me.mtb.TabIndex = 18
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(122, 70)
        Me.txtDescripcion.MaxLength = 60
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(313, 20)
        Me.txtDescripcion.TabIndex = 66
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(52, 74)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.lblDescripcion.TabIndex = 65
        Me.lblDescripcion.Text = "Descripción:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Folio :"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(122, 44)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(84, 20)
        Me.txtCodigo.TabIndex = 63
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvConsultaNomina
        '
        Me.dgvConsultaNomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultaNomina.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Sueldo, Me.Comisiones, Me.ImporteHRE, Me.ISRSubsidio, Me.CuotaMensual, Me.Prestamos, Me.Infonavit, Me.PensionAlimenticia})
        Me.dgvConsultaNomina.Location = New System.Drawing.Point(55, 106)
        Me.dgvConsultaNomina.Name = "dgvConsultaNomina"
        Me.dgvConsultaNomina.Size = New System.Drawing.Size(768, 282)
        Me.dgvConsultaNomina.TabIndex = 67
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Sueldo
        '
        Me.Sueldo.DataPropertyName = "Importesueldo"
        Me.Sueldo.HeaderText = "Sueldo"
        Me.Sueldo.Name = "Sueldo"
        '
        'Comisiones
        '
        Me.Comisiones.DataPropertyName = "comisiones"
        Me.Comisiones.HeaderText = "Comisiones"
        Me.Comisiones.Name = "Comisiones"
        '
        'ImporteHRE
        '
        Me.ImporteHRE.DataPropertyName = "importeshoraextras"
        Me.ImporteHRE.HeaderText = "ImporteHRE"
        Me.ImporteHRE.Name = "ImporteHRE"
        '
        'ISRSubsidio
        '
        Me.ISRSubsidio.DataPropertyName = "importeisrseguntarifa"
        Me.ISRSubsidio.HeaderText = "ISR/Subsidio"
        Me.ISRSubsidio.Name = "ISRSubsidio"
        '
        'CuotaMensual
        '
        Me.CuotaMensual.DataPropertyName = "impotetotalcuotamensual"
        Me.CuotaMensual.HeaderText = "CuotaMensual"
        Me.CuotaMensual.Name = "CuotaMensual"
        '
        'Prestamos
        '
        Me.Prestamos.DataPropertyName = "Prestamos"
        Me.Prestamos.HeaderText = "Prestamos"
        Me.Prestamos.Name = "Prestamos"
        '
        'Infonavit
        '
        Me.Infonavit.DataPropertyName = "infonavit"
        Me.Infonavit.HeaderText = "Infonavit"
        Me.Infonavit.Name = "Infonavit"
        '
        'PensionAlimenticia
        '
        Me.PensionAlimenticia.DataPropertyName = "pensionalimenticia"
        Me.PensionAlimenticia.HeaderText = "PensionAlimenticia"
        Me.PensionAlimenticia.Name = "PensionAlimenticia"
        '
        'FrmNomConsultaNomina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 418)
        Me.Controls.Add(Me.dgvConsultaNomina)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtb)
        Me.Name = "FrmNomConsultaNomina"
        Me.Text = "Consulta de Nomina"
        CType(Me.dgvConsultaNomina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents mtb As MEAToolBar.MEAToolBar
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents dgvConsultaNomina As System.Windows.Forms.DataGridView
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sueldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comisiones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImporteHRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ISRSubsidio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CuotaMensual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Prestamos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Infonavit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PensionAlimenticia As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
