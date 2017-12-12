Imports CCS = Integralab.ORMSeguridad.CollectionClasses
Imports ECS = Integralab.ORMSeguridad.EntityClasses
Imports HCS = Integralab.ORMSeguridad.HelperClasses
Imports OTL = Integralab.ORMSeguridad.TypedListClasses

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetallesEmpresasForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetallesEmpresasForm))
        Me.EmpresaLabel = New System.Windows.Forms.Label
        Me.EmpresaComboBox = New System.Windows.Forms.ComboBox
        Me.Empresas = New OTL.EmpresasTypedList
        Me.tabla = New System.Windows.Forms.TableLayoutPanel
        Me.UsuariosDisponiblesLabel = New System.Windows.Forms.Label
        Me.UsuariosAsociadosLabel = New System.Windows.Forms.Label
        Me.UsuariosDisponiblesListBox = New System.Windows.Forms.ListBox
        Me.UsuariosDisponibles = New OTL.UsuariosTypedList
        Me.UsuariosAsociadosListBox = New System.Windows.Forms.ListBox
        Me.UsuariosAsociados = New OTL.UsuariosTypedList
        Me.AsociarButton = New System.Windows.Forms.Button
        Me.DesasociarButton = New System.Windows.Forms.Button
        CType(Me.Empresas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabla.SuspendLayout()
        CType(Me.UsuariosDisponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosAsociados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmpresaLabel
        '
        Me.EmpresaLabel.AutoSize = True
        Me.EmpresaLabel.Location = New System.Drawing.Point(12, 9)
        Me.EmpresaLabel.Name = "EmpresaLabel"
        Me.EmpresaLabel.Size = New System.Drawing.Size(128, 13)
        Me.EmpresaLabel.TabIndex = 0
        Me.EmpresaLabel.Text = "Seleccione una Empresa:"
        '
        'EmpresaComboBox
        '
        Me.EmpresaComboBox.DataSource = Me.Empresas
        Me.EmpresaComboBox.DisplayMember = "Empnom"
        Me.EmpresaComboBox.FormattingEnabled = True
        Me.EmpresaComboBox.Location = New System.Drawing.Point(12, 25)
        Me.EmpresaComboBox.Name = "EmpresaComboBox"
        Me.EmpresaComboBox.Size = New System.Drawing.Size(457, 21)
        Me.EmpresaComboBox.TabIndex = 1
        Me.EmpresaComboBox.ValueMember = "Empndx"
        '
        'Empresas
        '
        Me.Empresas.ObeyWeakRelations = False
        Me.Empresas.RemotingFormat = System.Data.SerializationFormat.Binary
        Me.Empresas.TableName = "Empresas"
        '
        'tabla
        '
        Me.tabla.ColumnCount = 3
        Me.tabla.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tabla.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tabla.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tabla.Controls.Add(Me.UsuariosDisponiblesLabel, 0, 0)
        Me.tabla.Controls.Add(Me.UsuariosAsociadosLabel, 2, 0)
        Me.tabla.Controls.Add(Me.UsuariosDisponiblesListBox, 0, 1)
        Me.tabla.Controls.Add(Me.UsuariosAsociadosListBox, 2, 1)
        Me.tabla.Controls.Add(Me.AsociarButton, 1, 1)
        Me.tabla.Controls.Add(Me.DesasociarButton, 1, 2)
        Me.tabla.Location = New System.Drawing.Point(12, 52)
        Me.tabla.Name = "tabla"
        Me.tabla.RowCount = 2
        Me.tabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tabla.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tabla.Size = New System.Drawing.Size(457, 324)
        Me.tabla.TabIndex = 2
        '
        'UsuariosDisponiblesLabel
        '
        Me.UsuariosDisponiblesLabel.AutoSize = True
        Me.UsuariosDisponiblesLabel.Location = New System.Drawing.Point(3, 0)
        Me.UsuariosDisponiblesLabel.Name = "UsuariosDisponiblesLabel"
        Me.UsuariosDisponiblesLabel.Size = New System.Drawing.Size(108, 13)
        Me.UsuariosDisponiblesLabel.TabIndex = 0
        Me.UsuariosDisponiblesLabel.Text = "Usuarios Disponibles:"
        '
        'UsuariosAsociadosLabel
        '
        Me.UsuariosAsociadosLabel.AutoSize = True
        Me.UsuariosAsociadosLabel.Location = New System.Drawing.Point(281, 0)
        Me.UsuariosAsociadosLabel.Name = "UsuariosAsociadosLabel"
        Me.UsuariosAsociadosLabel.Size = New System.Drawing.Size(103, 13)
        Me.UsuariosAsociadosLabel.TabIndex = 1
        Me.UsuariosAsociadosLabel.Text = "Usuarios Asociados:"
        '
        'UsuariosDisponiblesListBox
        '
        Me.UsuariosDisponiblesListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UsuariosDisponiblesListBox.DataSource = Me.UsuariosDisponibles
        Me.UsuariosDisponiblesListBox.DisplayMember = "Usrnomcom"
        Me.UsuariosDisponiblesListBox.FormattingEnabled = True
        Me.UsuariosDisponiblesListBox.Location = New System.Drawing.Point(3, 23)
        Me.UsuariosDisponiblesListBox.Name = "UsuariosDisponiblesListBox"
        Me.tabla.SetRowSpan(Me.UsuariosDisponiblesListBox, 2)
        Me.UsuariosDisponiblesListBox.Size = New System.Drawing.Size(172, 290)
        Me.UsuariosDisponiblesListBox.TabIndex = 2
        Me.UsuariosDisponiblesListBox.ValueMember = "Usrndx"
        '
        'UsuariosDisponibles
        '
        Me.UsuariosDisponibles.ObeyWeakRelations = False
        Me.UsuariosDisponibles.RemotingFormat = System.Data.SerializationFormat.Binary
        Me.UsuariosDisponibles.TableName = "Usuarios"
        '
        'UsuariosAsociadosListBox
        '
        Me.UsuariosAsociadosListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UsuariosAsociadosListBox.DataSource = Me.UsuariosAsociados
        Me.UsuariosAsociadosListBox.DisplayMember = "Usrnomcom"
        Me.UsuariosAsociadosListBox.FormattingEnabled = True
        Me.UsuariosAsociadosListBox.Location = New System.Drawing.Point(281, 23)
        Me.UsuariosAsociadosListBox.Name = "UsuariosAsociadosListBox"
        Me.tabla.SetRowSpan(Me.UsuariosAsociadosListBox, 2)
        Me.UsuariosAsociadosListBox.Size = New System.Drawing.Size(173, 290)
        Me.UsuariosAsociadosListBox.TabIndex = 3
        Me.UsuariosAsociadosListBox.ValueMember = "Usrndx"
        '
        'UsuariosAsociados
        '
        Me.UsuariosAsociados.ObeyWeakRelations = False
        Me.UsuariosAsociados.RemotingFormat = System.Data.SerializationFormat.Binary
        Me.UsuariosAsociados.TableName = "Usuarios"
        '
        'AsociarButton
        '
        Me.AsociarButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AsociarButton.Enabled = False
        Me.AsociarButton.Image = My.Resources.user1_into
        Me.AsociarButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.AsociarButton.Location = New System.Drawing.Point(181, 101)
        Me.AsociarButton.Name = "AsociarButton"
        Me.AsociarButton.Size = New System.Drawing.Size(94, 68)
        Me.AsociarButton.TabIndex = 4
        Me.AsociarButton.Text = "Asociar..."
        Me.AsociarButton.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.AsociarButton.UseVisualStyleBackColor = True
        '
        'DesasociarButton
        '
        Me.DesasociarButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DesasociarButton.Enabled = False
        Me.DesasociarButton.Image = My.Resources.user1_back
        Me.DesasociarButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.DesasociarButton.Location = New System.Drawing.Point(181, 175)
        Me.DesasociarButton.Name = "DesasociarButton"
        Me.DesasociarButton.Size = New System.Drawing.Size(94, 69)
        Me.DesasociarButton.TabIndex = 5
        Me.DesasociarButton.Text = "Desasociar..."
        Me.DesasociarButton.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.DesasociarButton.UseVisualStyleBackColor = True
        '
        'DetallesEmpresasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 388)
        Me.Controls.Add(Me.tabla)
        Me.Controls.Add(Me.EmpresaComboBox)
        Me.Controls.Add(Me.EmpresaLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DetallesEmpresasForm"
        Me.Text = "Acceso a Empresas"
        CType(Me.Empresas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabla.ResumeLayout(False)
        Me.tabla.PerformLayout()
        CType(Me.UsuariosDisponibles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosAsociados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EmpresaLabel As System.Windows.Forms.Label
    Friend WithEvents EmpresaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents tabla As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents UsuariosDisponiblesLabel As System.Windows.Forms.Label
    Friend WithEvents UsuariosAsociadosLabel As System.Windows.Forms.Label
    Friend WithEvents UsuariosAsociadosListBox As System.Windows.Forms.ListBox
    Friend WithEvents AsociarButton As System.Windows.Forms.Button
    Friend WithEvents DesasociarButton As System.Windows.Forms.Button
    Friend WithEvents Empresas As OTL.EmpresasTypedList
    Friend WithEvents UsuariosDisponibles As OTL.UsuariosTypedList
    Friend WithEvents UsuariosAsociados As OTL.UsuariosTypedList
    Friend WithEvents UsuariosDisponiblesListBox As System.Windows.Forms.ListBox
End Class
