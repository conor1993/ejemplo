Imports ClasesNegocio
Imports EC = integralab.ORM.EntityClasses
Imports HC = integralab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports Integralab.FormasSeguridad

Module arranque

#Region "Miembros"

    Public Controlador As ControladorGanadera = Nothing

#End Region

#Region "Metodos"

    <STAThread()> _
    Sub main()
        Dim frmlogin As LoginForm = Nothing, MdiPrincipal As MDIMenuPrincipal = Nothing

        Try
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(True)

            Controlador = New ControladorGanadera()
            ClasesComunes.Inicializador.Inicializa(Controlador)
            MdiPrincipal = New MDIMenuPrincipal()
            frmlogin = New LoginForm(Controlador.Seguridad, MdiPrincipal)
            frmlogin.LogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage

            If frmlogin.ShowDialog = DialogResult.OK Then
                Controlador.IniciarSesion(frmlogin.Empresa.Empndx, frmlogin.Usuario.Usrndx)
                Utilerias.AplicarCambiosBaseDatos()

                Controlador.ActualizarMenu(MdiPrincipal.MainMenuStrip, Application.ProductName)
                Controlador.ChecarDerechos(MdiPrincipal.MainMenuStrip, 0)

                Application.Run(MdiPrincipal)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "INTEGRALAB S.A DE C.V - MEAT")
        End Try
    End Sub



#End Region

End Module