Imports CCS = Integralab.ORMSeguridad.CollectionClasses
Imports ECS = Integralab.ORMSeguridad.EntityClasses
Imports HCS = Integralab.ORMSeguridad.HelperClasses
Imports FCS = Integralab.ORMSeguridad.FactoryClasses

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox
        Me.UsernameLabel = New System.Windows.Forms.Label
        Me.PasswordLabel = New System.Windows.Forms.Label
        Me.UsernameTextBox = New System.Windows.Forms.TextBox
        Me.PasswordTextBox = New System.Windows.Forms.TextBox
        Me.OK = New System.Windows.Forms.Button
        Me.Cancel = New System.Windows.Forms.Button
        Me.Usuarios = New Integralab.ORMSeguridad.CollectionClasses.UsuarioCollection
        Me.EmpresaLabel = New System.Windows.Forms.Label
        Me.EmpresasComboBox = New System.Windows.Forms.ComboBox
        Me.Empresas = New Integralab.ORMSeguridad.CollectionClasses.EmpresasCollection
        Me.upbIndicador = New Infragistics.Win.UltraWinProgressBar.UltraProgressBar
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(370, 193)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(171, 3)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&Nombre de usuario"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(171, 52)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Contraseña"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.UsernameTextBox.Location = New System.Drawing.Point(173, 29)
        Me.UsernameTextBox.MaxLength = 15
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(220, 20)
        Me.UsernameTextBox.TabIndex = 0
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(173, 78)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(220, 20)
        Me.PasswordTextBox.TabIndex = 1
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(200, 161)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 23)
        Me.OK.TabIndex = 3
        Me.OK.Text = "&Aceptar"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(300, 161)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 23)
        Me.Cancel.TabIndex = 4
        Me.Cancel.Text = "&Cancelar"
        '
        'Usuarios
        '
        Me.Usuarios.ActiveContext = Nothing
        Me.Usuarios.AllowEdit = True
        Me.Usuarios.AllowNew = True
        Me.Usuarios.AllowRemove = True
        Me.Usuarios.Capacity = 32
        Me.Usuarios.ConcurrencyPredicateFactoryToUse = Nothing
        Me.Usuarios.DoNotPerformAddIfPresent = False
        Me.Usuarios.EntityFactoryToUse = New Integralab.ORMSeguridad.FactoryClasses.UsuarioEntityFactory
        Me.Usuarios.IsReadOnly = False
        Me.Usuarios.MaxNumberOfItemsToReturn = CType(0, Long)
        Me.Usuarios.SortClauses = Nothing
        Me.Usuarios.SuppressClearInGetMulti = False
        Me.Usuarios.Transaction = Nothing
        '
        'EmpresaLabel
        '
        Me.EmpresaLabel.Location = New System.Drawing.Point(171, 101)
        Me.EmpresaLabel.Name = "EmpresaLabel"
        Me.EmpresaLabel.Size = New System.Drawing.Size(220, 23)
        Me.EmpresaLabel.TabIndex = 4
        Me.EmpresaLabel.Text = "&Empresa"
        Me.EmpresaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EmpresasComboBox
        '
        Me.EmpresasComboBox.DataSource = Me.Empresas
        Me.EmpresasComboBox.DisplayMember = "Empnom"
        Me.EmpresasComboBox.Enabled = False
        Me.EmpresasComboBox.FormattingEnabled = True
        Me.EmpresasComboBox.Location = New System.Drawing.Point(173, 127)
        Me.EmpresasComboBox.Name = "EmpresasComboBox"
        Me.EmpresasComboBox.Size = New System.Drawing.Size(220, 21)
        Me.EmpresasComboBox.TabIndex = 2
        Me.EmpresasComboBox.TabStop = False
        Me.EmpresasComboBox.ValueMember = "Empid"
        '
        'Empresas
        '
        Me.Empresas.ActiveContext = Nothing
        Me.Empresas.AllowEdit = True
        Me.Empresas.AllowNew = True
        Me.Empresas.AllowRemove = True
        Me.Empresas.Capacity = 32
        Me.Empresas.ConcurrencyPredicateFactoryToUse = Nothing
        Me.Empresas.DoNotPerformAddIfPresent = False
        Me.Empresas.EntityFactoryToUse = New Integralab.ORMSeguridad.FactoryClasses.EmpresasEntityFactory
        Me.Empresas.IsReadOnly = False
        Me.Empresas.MaxNumberOfItemsToReturn = CType(0, Long)
        Me.Empresas.SortClauses = Nothing
        Me.Empresas.SuppressClearInGetMulti = False
        Me.Empresas.Transaction = Nothing
        '
        'upbIndicador
        '
        Me.upbIndicador.Enabled = False
        Me.upbIndicador.Location = New System.Drawing.Point(11, 200)
        Me.upbIndicador.Name = "upbIndicador"
        Me.upbIndicador.Size = New System.Drawing.Size(379, 23)
        Me.upbIndicador.TabIndex = 8
        Me.upbIndicador.Text = "[Formatted]"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 192)
        Me.Controls.Add(Me.upbIndicador)
        Me.Controls.Add(Me.EmpresasComboBox)
        Me.Controls.Add(Me.EmpresaLabel)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Inicio de Sesión..."
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Usuarios As CCS.UsuarioCollection
    Friend WithEvents EmpresaLabel As System.Windows.Forms.Label
    Friend WithEvents EmpresasComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Empresas As CCS.EmpresasCollection
    Public WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents upbIndicador As Infragistics.Win.UltraWinProgressBar.UltraProgressBar

End Class
