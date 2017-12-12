Imports HC = integralab.ORM.HelperClasses
Imports HCS = integralab.ORMSeguridad.HelperClasses
Imports ClasesNegocio

Public Class SeguridadLoginForm

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            Dim Datasource As String = ServidorTextBox.Text.ToUpper(), InitialCatalog As String = txtNombreBD.Text.Trim.ToUpper
            Dim Usuario As String = IIf(Not SICheckBox.Checked, UsuarioSQLTextBox.Text.ToUpper, ""), Contrasena As String = IIf(Not SICheckBox.Checked, PasswordSQLTextBox.Text, "")

            Controlador.Seguridad.VerificarAdministrador(UsernameTextBox.Text.Trim, PasswordTextBox.Text.Trim)
            Controlador.Seguridad.GuardarIlSeguridad(Datasource, InitialCatalog, Usuario, Contrasena, SICheckBox.Checked)

            HCS.DbUtils.ActualConnectionString = Controlador.Seguridad.SeguridadConnectionString
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub SICheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SICheckBox.CheckedChanged
        UsuarioSQLTextBox.Enabled = Not SICheckBox.Checked
        PasswordSQLTextBox.Enabled = Not SICheckBox.Checked
    End Sub

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Try
            ServidorTextBox.Text = Controlador.Seguridad.IlSeguridad_DataSource
            txtNombreBD.Text = Controlador.Seguridad.IlSeguridad_InitialCatalog
            SICheckBox.Checked = Controlador.Seguridad.IlSeguridad_SeguridadIntegrada
            UsuarioSQLTextBox.Text = Controlador.Seguridad.IlSeguridad_User
            PasswordSQLTextBox.Text = Controlador.Seguridad.IlSeguridad_Pass
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso")
            For Each control As Control In Me.Controls
                control.Enabled = False
            Next
            Cancel.Enabled = True
            Me.Close()
        End Try
    End Sub

End Class