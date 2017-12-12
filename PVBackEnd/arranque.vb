Imports ClasesNegocio
Imports EC = IntegraLab.ORM.EntityClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports IntegraLab.FormasSeguridad
Imports ClasesComunes
Imports System.Data.SqlClient
Imports Microsoft.Win32


Module arranque

#Region "Miembros"

    Public Controlador As ControladorGanadera = Nothing

#End Region

#Region "Metodos"

    <STAThread()> _
    Sub main()
        Dim VerificarLicencia As frmVerificarLicencia



        Dim frmlogin As LoginForm = Nothing, MdiPrincipal As MDIMenuPrincipal = Nothing
        '#If DEBUG Then
        '        My.Settings.Reset()
        '        Exit Sub
        '#End If
        Try


            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(True)
            Controlador = New ControladorGanadera()
            ClasesComunes.Inicializador.Inicializa(Controlador)


            'Controlador.Seguridad.GuardarIlSeguridad("localhost\SQLINTEGRA", "PVINTEGRA", "sa", "int3gr@", False)
            'HC.DbUtils.ActualConnectionString = Controlador.Seguridad.SeguridadConnectionString

            'Application.DoEvents()
            'If Controlador.Seguridad.SeguridadConnectionString <> "" Then
            '    Application.Exit()
            '    Process.Start(Application.ExecutablePath)
            'End If


            If Controlador.Seguridad.SeguridadConnectionString.Equals("Data Source=LOCALHOST; Initial Catalog=ILSEGURIDAD; Integrated Security=SSPI; Persist Security Info=False;Packet Size=4096") Then
                'Controlador.Seguridad.GuardarIlSeguridad("localhost\SQLINTEGRA", "PVINTEGRA", "sa", "int3gr@", False)
                'Application.DoEvents()
                'Controlador = New ControladorGanadera()
                'ClasesComunes.Inicializador.Inicializa(Controlador)
                'Application.DoEvents()
                HC.DbUtils.ActualConnectionString = Controlador.Seguridad.SeguridadConnectionString
                IntegraLab.ORMSeguridad.HelperClasses.DbUtils.ActualConnectionString = Controlador.Seguridad.SeguridadConnectionString
                Application.DoEvents()

                ' ''inserta las configuraciones iniciales para vender
                'Dim reg As RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\INTEGRALAB\", True)
                ''If cmbSucursal.SelectedValue IsNot Nothing Then
                'reg.SetValue("CodigoSucursal", "1", Microsoft.Win32.RegistryValueKind.String)
                ''End If
                ''If cmbImpresorasInstaladas.SelectedIndex <> -1 Then
                'reg.SetValue("NombreImpresora", "Microsoft XPS Document Writer", Microsoft.Win32.RegistryValueKind.String)
                ''End If
                ''If cmbConceptos.SelectedValue IsNot Nothing Then
                'reg.SetValue("ConceptoRetiro", "1", Microsoft.Win32.RegistryValueKind.String)
                ''End If




                'reg.Close()
            End If




            'If Controlador.Seguridad.SeguridadConnectionString <> "" Then
            '    Application.Exit()
            '    Process.Start(Application.ExecutablePath)
            'End If

            Dim validacion As Boolean = True
            '' autoinstalable pv se comento
            'Dim validacion As Boolean = False
            'Dim con As New SqlClient.SqlConnection(Controlador.Seguridad.SeguridadConnectionString)
            'con.Open()
            'Dim cmd1 As SqlCommand = New SqlCommand("select config from config", con)
            'Dim lector As SqlDataReader = cmd1.ExecuteReader
            'If lector.Read Then
            '    validacion = lector.GetBoolean(0)
            'End If
            'con.Close()

            ''VALIDANDO LICENCIAS

            If validacion Then
                MdiPrincipal = New MDIMenuPrincipal()
                frmlogin = New LoginForm(Controlador.Seguridad, MdiPrincipal)
                frmlogin.LogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage

                If frmlogin.ShowDialog = DialogResult.OK Then
                    Controlador.IniciarSesion(frmlogin.Empresa.Empndx, frmlogin.Usuario.Usrndx)
                    Utilerias.AplicarCambiosBaseDatos()

                    Controlador.ActualizarMenu(MdiPrincipal.MainMenuStrip, Application.ProductName)
                    Controlador.ChecarDerechos(MdiPrincipal.MainMenuStrip, 0)
                    If Controlador.ConPermisos = True Then
                        Application.Run(MdiPrincipal)
                    Else
                        Application.Exit()
                    End If
                End If
            Else
                VerificarLicencia = New frmVerificarLicencia(Controlador.Seguridad)
                Dim respuesta As DialogResult = VerificarLicencia.ShowDialog
                If respuesta = DialogResult.OK Then

                    MdiPrincipal = New MDIMenuPrincipal()
                    frmlogin = New LoginForm(Controlador.Seguridad, MdiPrincipal)
                    frmlogin.LogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage

                    If frmlogin.ShowDialog = DialogResult.OK Then
                        Controlador.IniciarSesion(frmlogin.Empresa.Empndx, frmlogin.Usuario.Usrndx)
                        Utilerias.AplicarCambiosBaseDatos()

                        Controlador.ActualizarMenu(MdiPrincipal.MainMenuStrip, Application.ProductName)
                        Controlador.ChecarDerechos(MdiPrincipal.MainMenuStrip, 0)
                        If Controlador.ConPermisos = True Then
                            Application.Run(MdiPrincipal)
                        Else
                            Application.Exit()
                        End If



                    End If
                Else
                    Return
                    Application.Exit()
                End If
            End If




        Catch ex As Exception
            MsgBox(ex.Message + "\n" + ex.StackTrace, MsgBoxStyle.Critical, "INTEGRALAB S.A DE C.V - PUNTO DE VENTA")
        End Try
    End Sub

#End Region

End Module