Imports ClasesNegocio
Imports EC = integralab.ORM.EntityClasses
Imports HC = integralab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports Integralab.FormasSeguridad
Imports ClasesComunes

Module arranque

#Region "Miembros"

    Public Controlador As ControladorGanadera = Nothing

#End Region

#Region "Metodos"

    <STAThread()> _
    Sub main()
        Dim frmlogin As LoginForm = Nothing, MdiPrincipal As ClasesComunes.frmNotaDeVenta = Nothing

        Try
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(True)

            Controlador = New ControladorGanadera()
            ClasesComunes.Inicializador.Inicializa(Controlador)
            MdiPrincipal = New ClasesComunes.frmNotaDeVenta()
            frmlogin = New LoginForm(Controlador.Seguridad, MdiPrincipal)
            frmlogin.LogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage

            If frmlogin.ShowDialog = DialogResult.OK Then
                Controlador.IniciarSesion(frmlogin.Empresa.Empndx, frmlogin.Usuario.Usrndx)
                Utilerias.AplicarCambiosBaseDatos()

                'Controlador.ActualizarMenu(MdiPrincipal.MainMenuStrip)

                Application.Run(MdiPrincipal)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "INTEGRALAB S.A DE C.V - PUNTO DE VENTA")
        End Try
    End Sub

#End Region

End Module