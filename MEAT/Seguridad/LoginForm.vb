Imports ClasesNegocio
Imports EC = Integralab.ORM.EntityClasses
Imports CCS = Integralab.ORMSeguridad.CollectionClasses
Imports ECS = Integralab.ORMSeguridad.EntityClasses
Imports HCS = Integralab.ORMSeguridad.HelperClasses

Public Class LoginForm

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private _usuario As New ECS.UsuarioEntity
    Private WithEvents tmr As Timer

    WriteOnly Property Logotipo() As Image
        Set(ByVal value As Image)
            Me.LogoPictureBox.Image = value
        End Set
    End Property

#Region "Constructores"

    Sub New()
        Dim a As New System.IO.FileInfo(My.Application.Info.DirectoryPath & "\" & My.Application.Info.AssemblyName & ".exe")

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Text = "Integra-Lab S.A. de C.V.   V." & My.Application.Info.Version.ToString & "     " & a.CreationTime
    End Sub

#End Region

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If OK.Text = "&Aceptar" Then

            Dim _usrs As New CCS.UsuarioCollection
            'se busca a un usuario por el nombre de usuario
            If _usrs.GetDbCount(HCS.UsuarioFields.Usrid = UsernameTextBox.Text) > 0 Then
                _usrs.GetMulti(HCS.UsuarioFields.Usrid = UsernameTextBox.Text)
                _usuario = _usrs(0)

                Dim Encriptador As New ClasesNegocio.EncriptadorClass
                If PasswordTextBox.Text.Length = 0 Then PasswordTextBox.Text = "."
                'se verifica el password es correcto
                If _usuario.Usrpas = Encriptador.Encriptar(PasswordTextBox.Text) Then

                    'se genera un filtro para obtener las empresas a las que pertenece el usuario
                    Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
                    filtro.Add(HCS.DetalleempresasFields.Usrndx = UsernameTextBox.Text)

                    'se obtienen las empresas del usuario
                    If Empresas.GetMultiManyToManyUsingMisUsuarios(_usuario) Then

                        'si nada mas pertenece a una empresa que se conecte directo, si no que seleccione a que empresa
                        'se va conectar
                        If EmpresasComboBox.Items.Count = 1 Then
                            Controlador.IniciarSesion(CType(EmpresasComboBox.SelectedItem, ECS.EmpresasEntity).Empndx, _usuario.Usrndx)
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                            Me.Close()
                        End If
                    End If

                    UsernameTextBox.Enabled = False
                    PasswordTextBox.Enabled = False
                    EmpresasComboBox.TabStop = True
                    EmpresasComboBox.Enabled = True
                    EmpresasComboBox.Focus()
                    OK.Text = "C&onectar"

                    'iniciar un contador que a los 10 segundos cierre la aplicacion
                    Me.Height = 264
                    Me.Refresh()

                    tmr = New Timer()
                    tmr.Interval = 1000
                    AddHandler tmr.Tick, AddressOf tmr_Tick

                    upbIndicador.Maximum = 10000
                    upbIndicador.Value = 10000
                    upbIndicador.Step = 1000
                    upbIndicador.Enabled = True

                    tmr.Enabled = True
                Else
                    MsgBox("contraseña no válida")
                    Limpiar()
                End If
            Else
                MsgBox("usuario no valido")
                Me.Limpiar()
            End If
        ElseIf OK.Text = "C&onectar" Then
            If EmpresasComboBox.SelectedItem Is Nothing Then
                MessageBox.Show("Seleccione Primeramente la Empresa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Controlador.IniciarSesion(CType(EmpresasComboBox.SelectedItem, ECS.EmpresasEntity).Empndx, _usuario.Usrndx)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub tmr_Tick(ByVal sender As Object, ByVal e As System.EventArgs)
        upbIndicador.Value -= upbIndicador.Step
    End Sub

    Private SystemControl As Integer = 0

    Private Sub LoginForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If OK.Text = "&Aceptar" Then
            If e.Control And e.Shift And e.KeyCode = Keys.Delete Then
                SystemControl += 1
            Else
                SystemControl = 0
            End If

            If SystemControl = 2 Then
                Dim frmLoginSeguridad As New SeguridadLoginForm
                If frmLoginSeguridad.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim MenuPrincipal As New MDIMenuPrincipal

                    Controlador.ActualizarMenu(MenuPrincipal.MainMenuStrip)
                    MenuPrincipal.ChecarDerechos(0, 1)
                    MenuPrincipal.ShowDialog()
                End If
            End If
        End If
    End Sub

    Private Sub UsernameTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles UsernameTextBox.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.SelectNextControl(sender, True, True, True, True)
        End If
    End Sub

    Private Sub PasswordTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PasswordTextBox.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.OK_Click(Me, New EventArgs)
        End If
    End Sub

    Private Sub EmpresasComboBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles EmpresasComboBox.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.OK_Click(Me, New EventArgs)
        End If
    End Sub

    Private Sub Limpiar()
        Me.UsernameTextBox.Enabled = True
        Me.PasswordTextBox.Enabled = True
        Me.EmpresasComboBox.Enabled = False
        Me.EmpresasComboBox.TabStop = False
        Me.UsernameTextBox.Clear()
        Me.PasswordTextBox.Clear()
        Me.Empresas.Clear()
        Me.EmpresasComboBox.Text = ""
        Me.UsernameTextBox.Focus()
    End Sub

    Private Sub upbIndicador_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles upbIndicador.ValueChanged
        If sender.Value = sender.Minimum Then
            Me.Close()
        End If
    End Sub

End Class
