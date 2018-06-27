<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusquedaCuentasContablesForm
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCta = New Integra.Controles.TextboxNumerico()
        Me.txtSCta = New Integra.Controles.TextboxNumerico()
        Me.txtSSCta = New Integra.Controles.TextboxNumerico()
        Me.txtSSSCta = New Integra.Controles.TextboxNumerico()
        Me.gpoCaracteristicas = New System.Windows.Forms.GroupBox()
        Me.chkBan = New System.Windows.Forms.CheckBox()
        Me.chkIna = New System.Windows.Forms.CheckBox()
        Me.chkDep = New System.Windows.Forms.CheckBox()
        Me.chkAfe = New System.Windows.Forms.CheckBox()
        Me.chkPre = New System.Windows.Forms.CheckBox()
        Me.chkRes = New System.Windows.Forms.CheckBox()
        Me.gpoNaturaleza = New System.Windows.Forms.GroupBox()
        Me.rdbAcr = New System.Windows.Forms.RadioButton()
        Me.rdbDeu = New System.Windows.Forms.RadioButton()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.clmCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gpoCaracteristicas.SuspendLayout()
        Me.gpoNaturaleza.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.lblTitulo.Size = New System.Drawing.Size(931, 30)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Label1"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(37, 83)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(199, 20)
        Me.txtNombre.TabIndex = 2
        '
        'txtCta
        '
        Me.txtCta.Location = New System.Drawing.Point(236, 83)
        Me.txtCta.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.txtCta.MaxLength = 4
        Me.txtCta.Name = "txtCta"
        Me.txtCta.Posiciones = 4
        Me.txtCta.Size = New System.Drawing.Size(62, 20)
        Me.txtCta.TabIndex = 3
        Me.txtCta.Text = "0000"
        Me.txtCta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSCta
        '
        Me.txtSCta.Location = New System.Drawing.Point(298, 83)
        Me.txtSCta.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.txtSCta.MaxLength = 4
        Me.txtSCta.Name = "txtSCta"
        Me.txtSCta.Posiciones = 4
        Me.txtSCta.Size = New System.Drawing.Size(62, 20)
        Me.txtSCta.TabIndex = 4
        Me.txtSCta.Text = "0000"
        Me.txtSCta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSSCta
        '
        Me.txtSSCta.Location = New System.Drawing.Point(360, 83)
        Me.txtSSCta.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.txtSSCta.MaxLength = 4
        Me.txtSSCta.Name = "txtSSCta"
        Me.txtSSCta.Posiciones = 4
        Me.txtSSCta.Size = New System.Drawing.Size(62, 20)
        Me.txtSSCta.TabIndex = 5
        Me.txtSSCta.Text = "0000"
        Me.txtSSCta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSSSCta
        '
        Me.txtSSSCta.Location = New System.Drawing.Point(422, 83)
        Me.txtSSSCta.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.txtSSSCta.MaxLength = 4
        Me.txtSSSCta.Name = "txtSSSCta"
        Me.txtSSSCta.Posiciones = 4
        Me.txtSSSCta.Size = New System.Drawing.Size(62, 20)
        Me.txtSSSCta.TabIndex = 6
        Me.txtSSSCta.Text = "0000"
        Me.txtSSSCta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gpoCaracteristicas
        '
        Me.gpoCaracteristicas.Controls.Add(Me.chkBan)
        Me.gpoCaracteristicas.Controls.Add(Me.chkIna)
        Me.gpoCaracteristicas.Controls.Add(Me.chkDep)
        Me.gpoCaracteristicas.Controls.Add(Me.chkAfe)
        Me.gpoCaracteristicas.Controls.Add(Me.chkPre)
        Me.gpoCaracteristicas.Controls.Add(Me.chkRes)
        Me.gpoCaracteristicas.Location = New System.Drawing.Point(489, 33)
        Me.gpoCaracteristicas.Name = "gpoCaracteristicas"
        Me.gpoCaracteristicas.Size = New System.Drawing.Size(314, 70)
        Me.gpoCaracteristicas.TabIndex = 8
        Me.gpoCaracteristicas.TabStop = False
        Me.gpoCaracteristicas.Text = "Caracteristicas"
        '
        'chkBan
        '
        Me.chkBan.AutoSize = True
        Me.chkBan.Location = New System.Drawing.Point(6, 42)
        Me.chkBan.Name = "chkBan"
        Me.chkBan.Size = New System.Drawing.Size(62, 17)
        Me.chkBan.TabIndex = 3
        Me.chkBan.Text = "Bancos"
        Me.chkBan.UseVisualStyleBackColor = True
        '
        'chkIna
        '
        Me.chkIna.AutoSize = True
        Me.chkIna.Location = New System.Drawing.Point(91, 42)
        Me.chkIna.Name = "chkIna"
        Me.chkIna.Size = New System.Drawing.Size(64, 17)
        Me.chkIna.TabIndex = 4
        Me.chkIna.Text = "Inactiva"
        Me.chkIna.UseVisualStyleBackColor = True
        '
        'chkDep
        '
        Me.chkDep.AutoSize = True
        Me.chkDep.Location = New System.Drawing.Point(186, 19)
        Me.chkDep.Name = "chkDep"
        Me.chkDep.Size = New System.Drawing.Size(122, 17)
        Me.chkDep.TabIndex = 2
        Me.chkDep.Text = "Departamentalizable"
        Me.chkDep.UseVisualStyleBackColor = True
        '
        'chkAfe
        '
        Me.chkAfe.AutoSize = True
        Me.chkAfe.Location = New System.Drawing.Point(187, 42)
        Me.chkAfe.Name = "chkAfe"
        Me.chkAfe.Size = New System.Drawing.Size(71, 17)
        Me.chkAfe.TabIndex = 5
        Me.chkAfe.Text = "Afectable"
        Me.chkAfe.UseVisualStyleBackColor = True
        '
        'chkPre
        '
        Me.chkPre.AutoSize = True
        Me.chkPre.Location = New System.Drawing.Point(91, 19)
        Me.chkPre.Name = "chkPre"
        Me.chkPre.Size = New System.Drawing.Size(90, 17)
        Me.chkPre.TabIndex = 1
        Me.chkPre.Text = "Presupuestos"
        Me.chkPre.UseVisualStyleBackColor = True
        '
        'chkRes
        '
        Me.chkRes.AutoSize = True
        Me.chkRes.Location = New System.Drawing.Point(6, 19)
        Me.chkRes.Name = "chkRes"
        Me.chkRes.Size = New System.Drawing.Size(79, 17)
        Me.chkRes.TabIndex = 0
        Me.chkRes.Text = "Resultados"
        Me.chkRes.UseVisualStyleBackColor = True
        '
        'gpoNaturaleza
        '
        Me.gpoNaturaleza.Controls.Add(Me.rdbAcr)
        Me.gpoNaturaleza.Controls.Add(Me.rdbDeu)
        Me.gpoNaturaleza.Location = New System.Drawing.Point(329, 33)
        Me.gpoNaturaleza.Name = "gpoNaturaleza"
        Me.gpoNaturaleza.Size = New System.Drawing.Size(155, 46)
        Me.gpoNaturaleza.TabIndex = 7
        Me.gpoNaturaleza.TabStop = False
        Me.gpoNaturaleza.Text = "Naturaleza"
        '
        'rdbAcr
        '
        Me.rdbAcr.AutoSize = True
        Me.rdbAcr.Location = New System.Drawing.Point(8, 19)
        Me.rdbAcr.Name = "rdbAcr"
        Me.rdbAcr.Size = New System.Drawing.Size(68, 17)
        Me.rdbAcr.TabIndex = 0
        Me.rdbAcr.TabStop = True
        Me.rdbAcr.Text = "Acredora"
        Me.rdbAcr.UseVisualStyleBackColor = True
        '
        'rdbDeu
        '
        Me.rdbDeu.AutoSize = True
        Me.rdbDeu.Location = New System.Drawing.Point(82, 19)
        Me.rdbDeu.Name = "rdbDeu"
        Me.rdbDeu.Size = New System.Drawing.Size(66, 17)
        Me.rdbDeu.TabIndex = 1
        Me.rdbDeu.TabStop = True
        Me.rdbDeu.Text = "Deudora"
        Me.rdbDeu.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(809, 35)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(102, 34)
        Me.btnLimpiar.TabIndex = 13
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(809, 69)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(102, 34)
        Me.btnBuscar.TabIndex = 9
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Location = New System.Drawing.Point(701, 439)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(102, 34)
        Me.btnAceptar.TabIndex = 11
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(809, 439)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(102, 34)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre y Cuenta:"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmCodigo})
        Me.dgv.Location = New System.Drawing.Point(12, 109)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersWidth = 25
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(899, 324)
        Me.dgv.TabIndex = 10
        '
        'clmCodigo
        '
        Me.clmCodigo.DataPropertyName = "codigo"
        Me.clmCodigo.HeaderText = "Codigo"
        Me.clmCodigo.Name = "clmCodigo"
        Me.clmCodigo.ReadOnly = True
        Me.clmCodigo.Visible = False
        '
        'BusquedaCuentasContablesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 485)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.gpoCaracteristicas)
        Me.Controls.Add(Me.gpoNaturaleza)
        Me.Controls.Add(Me.txtSSSCta)
        Me.Controls.Add(Me.txtSSCta)
        Me.Controls.Add(Me.txtSCta)
        Me.Controls.Add(Me.txtCta)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.lblTitulo)
        Me.KeyPreview = True
        Me.Name = "BusquedaCuentasContablesForm"
        Me.Text = "Busqueda de Cuentas Contables"
        Me.gpoCaracteristicas.ResumeLayout(False)
        Me.gpoCaracteristicas.PerformLayout()
        Me.gpoNaturaleza.ResumeLayout(False)
        Me.gpoNaturaleza.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Cuentas As ClasesNegocio.CuentaContableCollectionClass
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtCta As Integra.Controles.TextboxNumerico
    Friend WithEvents txtSCta As Integra.Controles.TextboxNumerico
    Friend WithEvents txtSSCta As Integra.Controles.TextboxNumerico
    Friend WithEvents txtSSSCta As Integra.Controles.TextboxNumerico
    Friend WithEvents gpoCaracteristicas As System.Windows.Forms.GroupBox
    Friend WithEvents chkBan As System.Windows.Forms.CheckBox
    Friend WithEvents chkIna As System.Windows.Forms.CheckBox
    Friend WithEvents chkDep As System.Windows.Forms.CheckBox
    Friend WithEvents chkAfe As System.Windows.Forms.CheckBox
    Friend WithEvents chkPre As System.Windows.Forms.CheckBox
    Friend WithEvents chkRes As System.Windows.Forms.CheckBox
    Friend WithEvents gpoNaturaleza As System.Windows.Forms.GroupBox
    Friend WithEvents rdbAcr As System.Windows.Forms.RadioButton
    Friend WithEvents rdbDeu As System.Windows.Forms.RadioButton
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NombreCuentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CuentaContableDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NaturalezaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AfectableDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResultadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PresupuestoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartamentalizableDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BancosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InactivaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
