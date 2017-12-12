<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNuevoDomicilio
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtCodigoPoblacion = New System.Windows.Forms.TextBox
        Me.txtCodigoCiudad = New System.Windows.Forms.TextBox
        Me.txtCodigoEstado = New System.Windows.Forms.TextBox
        Me.cmbPoblacion = New System.Windows.Forms.ComboBox
        Me.PoblacionC = New ClasesNegocio.PoblacionCollectionClass
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbCiudad = New System.Windows.Forms.ComboBox
        Me.CiudadC = New ClasesNegocio.CiudadCollectionClass
        Me.cmbEstado = New System.Windows.Forms.ComboBox
        Me.EstadoC = New ClasesNegocio.EstadoCollectionClass
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.DomicilioFiscalC = New ClasesNegocio.DomicilioFiscalCollectionClass
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.UlvDomicilio = New Infragistics.Win.Misc.UltraValidator(Me.components)
        Me.UltDomicilio = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltCodigoPostal = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.UltColonia = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Panel1.SuspendLayout()
        CType(Me.UlvDomicilio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltDomicilio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltCodigoPostal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltColonia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.MaximumSize = New System.Drawing.Size(1600, 800)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(809, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "DOMICILIO"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.UltColonia)
        Me.Panel1.Controls.Add(Me.UltCodigoPostal)
        Me.Panel1.Controls.Add(Me.UltDomicilio)
        Me.Panel1.Controls.Add(Me.txtCodigoPoblacion)
        Me.Panel1.Controls.Add(Me.txtCodigoCiudad)
        Me.Panel1.Controls.Add(Me.txtCodigoEstado)
        Me.Panel1.Controls.Add(Me.cmbPoblacion)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.cmbCiudad)
        Me.Panel1.Controls.Add(Me.cmbEstado)
        Me.Panel1.Location = New System.Drawing.Point(12, 34)
        Me.Panel1.MinimumSize = New System.Drawing.Size(50, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(785, 161)
        Me.Panel1.TabIndex = 3
        '
        'txtCodigoPoblacion
        '
        Me.txtCodigoPoblacion.Location = New System.Drawing.Point(91, 125)
        Me.txtCodigoPoblacion.Name = "txtCodigoPoblacion"
        Me.txtCodigoPoblacion.Size = New System.Drawing.Size(50, 20)
        Me.txtCodigoPoblacion.TabIndex = 9
        '
        'txtCodigoCiudad
        '
        Me.txtCodigoCiudad.Location = New System.Drawing.Point(91, 98)
        Me.txtCodigoCiudad.Name = "txtCodigoCiudad"
        Me.txtCodigoCiudad.Size = New System.Drawing.Size(50, 20)
        Me.txtCodigoCiudad.TabIndex = 7
        '
        'txtCodigoEstado
        '
        Me.txtCodigoEstado.Location = New System.Drawing.Point(91, 71)
        Me.txtCodigoEstado.Name = "txtCodigoEstado"
        Me.txtCodigoEstado.Size = New System.Drawing.Size(50, 20)
        Me.txtCodigoEstado.TabIndex = 5
        '
        'cmbPoblacion
        '
        Me.cmbPoblacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbPoblacion.DataSource = Me.PoblacionC
        Me.cmbPoblacion.DisplayMember = "Descripcion"
        Me.cmbPoblacion.FormattingEnabled = True
        Me.cmbPoblacion.Location = New System.Drawing.Point(147, 124)
        Me.cmbPoblacion.MaximumSize = New System.Drawing.Size(280, 0)
        Me.cmbPoblacion.MinimumSize = New System.Drawing.Size(50, 0)
        Me.cmbPoblacion.Name = "cmbPoblacion"
        Me.cmbPoblacion.Size = New System.Drawing.Size(256, 21)
        Me.cmbPoblacion.TabIndex = 10
        Me.cmbPoblacion.ValueMember = "Codigo"
        '
        'PoblacionC
        '
        Me.PoblacionC.AllowEdit = True
        Me.PoblacionC.AllowNew = True
        Me.PoblacionC.AllowRemove = True
        Me.PoblacionC.MaximoElementosSeleccionados = 1
        Me.PoblacionC.MensajeLimiteMaximo = "Ya se selecciono el maximo de elementos permitidos"
        Me.PoblacionC.MostrarAlertas = False
        Me.PoblacionC.Name = ""
        Me.PoblacionC.RaiseListChangedEvents = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Poblacion:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Ciudad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Estado:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(386, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "C.P. :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Colonia:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Domicilio:"
        '
        'cmbCiudad
        '
        Me.cmbCiudad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCiudad.DataSource = Me.CiudadC
        Me.cmbCiudad.DisplayMember = "Descripcion"
        Me.cmbCiudad.FormattingEnabled = True
        Me.cmbCiudad.Location = New System.Drawing.Point(147, 98)
        Me.cmbCiudad.MaximumSize = New System.Drawing.Size(300, 0)
        Me.cmbCiudad.MinimumSize = New System.Drawing.Size(50, 0)
        Me.cmbCiudad.Name = "cmbCiudad"
        Me.cmbCiudad.Size = New System.Drawing.Size(256, 21)
        Me.cmbCiudad.TabIndex = 8
        Me.cmbCiudad.ValueMember = "Codigo"
        '
        'CiudadC
        '
        Me.CiudadC.AllowEdit = True
        Me.CiudadC.AllowNew = True
        Me.CiudadC.AllowRemove = True
        Me.CiudadC.Name = ""
        Me.CiudadC.RaiseListChangedEvents = True
        '
        'cmbEstado
        '
        Me.cmbEstado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbEstado.DataSource = Me.EstadoC
        Me.cmbEstado.DisplayMember = "Descripcion"
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(147, 71)
        Me.cmbEstado.MaximumSize = New System.Drawing.Size(280, 0)
        Me.cmbEstado.MinimumSize = New System.Drawing.Size(50, 0)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(256, 21)
        Me.cmbEstado.TabIndex = 6
        Me.cmbEstado.ValueMember = "Codigo"
        '
        'EstadoC
        '
        Me.EstadoC.AllowEdit = True
        Me.EstadoC.AllowNew = True
        Me.EstadoC.AllowRemove = True
        Me.EstadoC.Name = ""
        Me.EstadoC.RaiseListChangedEvents = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(10, 186)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(57, 13)
        Me.Label24.TabIndex = 29
        Me.Label24.Text = "Poblacion:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(8, 157)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(40, 13)
        Me.Label25.TabIndex = 28
        Me.Label25.Text = "Ciudad"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(8, 129)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(43, 13)
        Me.Label26.TabIndex = 27
        Me.Label26.Text = "Estado:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(417, 97)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(33, 13)
        Me.Label23.TabIndex = 19
        Me.Label23.Text = "C.P. :"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 97)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 13)
        Me.Label22.TabIndex = 17
        Me.Label22.Text = "Colonia:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 71)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 13)
        Me.Label19.TabIndex = 15
        Me.Label19.Text = "Domicilio:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 41)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(73, 13)
        Me.Label20.TabIndex = 13
        Me.Label20.Text = "Razon Social:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 12)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(43, 13)
        Me.Label21.TabIndex = 11
        Me.Label21.Text = "R.F.C. :"
        '
        'DomicilioFiscalC
        '
        Me.DomicilioFiscalC.AllowEdit = True
        Me.DomicilioFiscalC.AllowNew = True
        Me.DomicilioFiscalC.AllowRemove = True
        Me.DomicilioFiscalC.Name = ""
        Me.DomicilioFiscalC.RaiseListChangedEvents = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(628, 210)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 46
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(718, 210)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 47
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'UltDomicilio
        '
        Me.UltDomicilio.Location = New System.Drawing.Point(91, 15)
        Me.UltDomicilio.Name = "UltDomicilio"
        Me.UltDomicilio.Size = New System.Drawing.Size(664, 21)
        Me.UltDomicilio.TabIndex = 46
        Me.UlvDomicilio.GetValidationSettings(Me.UltDomicilio).IsRequired = True
        '
        'UltCodigoPostal
        '
        Me.UltCodigoPostal.Location = New System.Drawing.Point(425, 43)
        Me.UltCodigoPostal.Name = "UltCodigoPostal"
        Me.UltCodigoPostal.Size = New System.Drawing.Size(330, 21)
        Me.UltCodigoPostal.TabIndex = 47
        '
        'UltColonia
        '
        Me.UltColonia.Location = New System.Drawing.Point(91, 43)
        Me.UltColonia.Name = "UltColonia"
        Me.UltColonia.Size = New System.Drawing.Size(289, 21)
        Me.UltColonia.TabIndex = 48
        Me.UlvDomicilio.GetValidationSettings(Me.UltColonia).IsRequired = True
        '
        'FrmNuevoDomicilio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 249)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(817, 302)
        Me.MinimumSize = New System.Drawing.Size(696, 279)
        Me.Name = "FrmNuevoDomicilio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Domicilio Fiscal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.UlvDomicilio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltDomicilio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltCodigoPostal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltColonia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmbPoblacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbCiudad As System.Windows.Forms.ComboBox
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents DomicilioFiscalC As ClasesNegocio.DomicilioFiscalCollectionClass
    Friend WithEvents CiudadC As ClasesNegocio.CiudadCollectionClass
    Friend WithEvents EstadoC As ClasesNegocio.EstadoCollectionClass
    Friend WithEvents PoblacionC As ClasesNegocio.PoblacionCollectionClass
    Friend WithEvents txtCodigoPoblacion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoCiudad As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoEstado As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents UlvDomicilio As Infragistics.Win.Misc.UltraValidator
    Friend WithEvents UltColonia As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltCodigoPostal As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltDomicilio As Infragistics.Win.UltraWinEditors.UltraTextEditor
End Class
