'Imports System.Windows.Forms
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CCS = IntegraLab.ORMSeguridad.CollectionClasses
Imports ECS = IntegraLab.ORMSeguridad.EntityClasses
Imports HCS = IntegraLab.ORMSeguridad.HelperClasses
Imports IntegraLab.FormasSeguridad
Imports ClasesComunes
Imports IntegraLab.FactDigital
Imports System.Configuration
Imports System.Security.AccessControl
Imports Microsoft.Win32
Imports System.Security.Permissions
Imports System.Security.Principal
Imports System.Threading



Public Class MDIMenuPrincipal
    Implements ClasesNegocio.iMainForm

    'Dim t1 As System.Threading.Timer 'declaracion del hilo timer


#Region "Constructores"

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Tag = Controlador.Sesion.MiEmpresa.Empnom

        If Not Controlador.Sesion.MiEmpresa.IsNew Then
            Me.tlsBaseDatos.Text = "Base de Datos: " & Controlador.Sesion.MiEmpresa.Empcat
            Me.tlsServidor.Text = "Servidor: " & Controlador.Sesion.MiEmpresa.Empsrv
        End If

        If Not Controlador.Sesion.MiUsuario.IsNew Then
            Me.tlsUsuario.Text = "Usuario: " & Controlador.Sesion.MiUsuario.Usrnomcom
        End If

        Me.tlsHora.Text = Now

        If Controlador.Sesion.MiEmpresa.EmpIcono.Length > 0 Then
            Dim Stream As New System.IO.MemoryStream(Controlador.Sesion.MiEmpresa.EmpIcono)
            Dim Icono As New System.Drawing.Icon(Stream)
            Me.Icon = Icono
        Else
            'Me.Icon = My.Resources.JSLogo32
        End If

        Dim a As New System.IO.FileInfo(My.Application.Info.DirectoryPath & "\" & My.Application.Info.AssemblyName & ".exe")

        Me.Text = Controlador.Sesion.MiEmpresa.Empnom & "       ""Integra-Lab S.A. de C.V.""   V." & My.Application.Info.Version.ToString & "     " & a.CreationTime
        Me.Timer1.Enabled = True
    End Sub

#End Region

#Region "Metodos"

    Private Sub Abrir(ByRef ventana As Form)
        If Not tlsProgressBar.Visible Then
            tlsProgressBar.Value = 0
            tlsProgressBar.Visible = True
            ventana.MdiParent = Me
            Me.tlsProgressBar.Value = 5
            ventana.Icon = Me.Icon
            Me.tlsProgressBar.Value = 40
            ventana.StartPosition = FormStartPosition.CenterScreen
            Me.tlsProgressBar.Value = 80

            AddHandler ventana.Activated, AddressOf Utilerias.Forma_Activated
            AddHandler ventana.Deactivate, AddressOf Utilerias.Forma_Deactivate
            ventana.Show()


            Me.tlsProgressBar.Value = 100
            Me.tlsProgressBar.Visible = False
            Me.tlsProgressBar.Value = 0
        Else
            ventana.MdiParent = Me
            ventana.Icon = Me.Icon
            ventana.StartPosition = FormStartPosition.CenterScreen

            AddHandler ventana.Activated, AddressOf Utilerias.Forma_Activated
            AddHandler ventana.Deactivate, AddressOf Utilerias.Forma_Deactivate
            ventana.Show()
        End If
    End Sub

    Private Sub Cerrar()
        If Controlador IsNot Nothing Then
            If Controlador.Sesion.Usrndx <> -1 Then
                Controlador.Sesion.Sesact = False
                Controlador.Sesion.Save()
            End If
        End If

        Me.Finalize()
        Me.Dispose()
        End
    End Sub

    'Private Sub MostrarMenusPadres(ByVal Padre As ToolStripItem)
    '    If Padre IsNot Nothing Then
    '        If Padre.Visible = False AndAlso Padre.GetType Is GetType(ToolStripMenuItem) Then
    '            Padre.Visible = True
    '            MostrarMenusPadres(Padre.OwnerItem)
    '        End If
    '    End If
    'End Sub

    'Private Sub HabilitarMenu(ByRef IdMenu As String, ByVal Menus As ToolStripItemCollection)
    '    For Each Item As ToolStripItem In Menus
    '        If Item.Name = IdMenu AndAlso Item.GetType Is GetType(ToolStripMenuItem) Then
    '            Item.Visible = True
    '            MostrarMenusPadres(Item.OwnerItem)
    '            Exit For
    '        ElseIf Item.GetType Is GetType(ToolStripMenuItem) AndAlso CType(Item, ToolStripMenuItem).DropDownItems IsNot Nothing Then
    '            HabilitarMenu(IdMenu, CType(Item, ToolStripMenuItem).DropDownItems)
    '        End If
    '    Next
    'End Sub

    ''' <summary>
    ''' Oculta todos los menus
    ''' </summary>
    ''' <remarks></remarks>
    'Private Sub OcutarMenus(ByVal Menus As ToolStripItemCollection)
    '    'Ocultar menus principales e hijos
    '    If Menus IsNot Nothing And Menus.Count > 0 Then
    '        For Each Item As ToolStripItem In Menus
    '            If Item.GetType Is GetType(ToolStripMenuItem) Then
    '                Dim Menu As ToolStripMenuItem = CType(Item, ToolStripMenuItem)
    '                Menu.Visible = False
    '                OcutarMenus(Menu.DropDownItems)
    '            End If
    '        Next
    '    End If
    'End Sub

    'Private Sub MostrarMenuSeguridad()
    '    For Each Item As ToolStripItem In Me.MainMenuStrip.Items.Find("Seguridad", False)
    '        If Item.GetType Is GetType(ToolStripMenuItem) Then
    '            Item.Visible = True

    '            For Each ItemHijo As ToolStripItem In CType(Item, ToolStripMenuItem).DropDownItems
    '                ItemHijo.Visible = True

    '                If ItemHijo.GetType Is GetType(ToolStripMenuItem) Then
    '                    For Each ItemHijoHijo As ToolStripItem In CType(ItemHijo, ToolStripMenuItem).DropDownItems
    '                        ItemHijoHijo.Visible = True
    '                    Next
    '                End If
    '            Next
    '        End If
    '    Next
    'End Sub

    'Public Sub ChecarDerechos(ByVal UsuarioId As Integer, ByVal Seguridad As Integer)
    '    Dim resultados As Boolean = True
    '    Try
    '        'checar privilegios de usuarios
    '        Dim Privilegios As New CCS.DetallemenususuariosCollection
    '        Dim MenuPrivilegios As New CCS.MenusCollection



    '        'sacar nombres de las funciones y menus del sistema
    '        OcutarMenus(MenuStrip.Items)
    '        'POR USUARIOS
    '        Privilegios.GetMulti(HCS.DetallemenususuariosFields.Usrndx = UsuarioId)
    '        'POR GRUPO


    '        MenuPrivilegios.GetMulti(Nothing)

    '        If Seguridad = 1 Then
    '            'menus de seguridad
    '            MostrarMenuSeguridad()
    '        Else
    '            If Privilegios.Count > 0 Then
    '                For Each Privilegio As ECS.DetallemenususuariosEntity In Privilegios
    '                    For Each MenuPrivilegio As ECS.MenusEntity In MenuPrivilegios
    '                        If Privilegio.Mnundx = MenuPrivilegio.Mnundx Then
    '                            HabilitarMenu(MenuPrivilegio.Mnuid, Me.MainMenuStrip.Items)
    '                        End If
    '                    Next
    '                Next
    '            Else
    '                resultados = False
    '            End If

    '            'GRUPOS
    '            Dim grupos As New Integralab.ORMSeguridad.CollectionClasses.DetallegruposCollection
    '            Dim Filtro As New OC.PredicateExpression(HCS.DetallegruposFields.Usrndx = UsuarioId)
    '            grupos.GetMulti(Filtro)
    '            If grupos.Count > 0 Then
    '                For Each GruposPertenece As ECS.DetallegruposEntity In grupos
    '                    Dim menusGrupo As New Integralab.ORMSeguridad.CollectionClasses.DetallemenusgruposCollection
    '                    menusGrupo.GetMulti(New OC.PredicateExpression(HCS.DetallemenusgruposFields.Gpondx = GruposPertenece.Gpondx))
    '                    If menusGrupo.Count > 0 Then
    '                        For Each PrivilegioGrupo As ECS.DetallemenusgruposEntity In menusGrupo
    '                            For Each MenuPrivilegio As ECS.MenusEntity In MenuPrivilegios
    '                                If PrivilegioGrupo.Mnundx = MenuPrivilegio.Mnundx Then
    '                                    HabilitarMenu(MenuPrivilegio.Mnuid, Me.MainMenuStrip.Items)
    '                                    resultados = True
    '                                End If
    '                            Next
    '                        Next

    '                    End If
    '                Next

    '            End If


    '            If resultados = False Then
    '                MessageBox.Show("Usuario no tiene derechos a ninguna función del sistema", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                Me.Close()
    '            End If

    '            'For i As Integer = 0 To grupos.Count - 1
    '            '    Dim menusGrupo As Integralab.ORMSeguridad.CollectionClasses.DetallemenusgruposCollection
    '            '    menusGrupo.GetMulti(New OC.PredicateExpression(HCS.DetallemenusgruposFields.Gpondx = grupos(i).Gpondx))
    '            '    Dim menuC As New CCS.MenusCollection
    '            '    For j As Integer = 0 To menusGrupo.Count - 1
    '            '        menuC.GetMulti(HCS.MenusFields.Mnundx = menusGrupo(j).Mnundx)
    '            '    Next
    '            '    GuardarMenu(Aplication, menuC, Nothing, trans)


    '            'Next

    '            'If PrivilegiosGrupo.Count > 0 Then
    '            '    For Each PrivilegioGrupo As ECS.DetallemenusgruposEntity In PrivilegiosGrupo

    '            '    Next
    '            'Else
    '            '    MessageBox.Show("Este usuario no tiene ningun grupo asignado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            'End If
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Close()
    '    End Try
    'End Sub

#End Region

#Region "Eventos"

    Private Sub MDIMenuPrincipal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Cerrar()
    End Sub

    Private Sub MDIMenuPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'If Controlador.Sesion.MiUsuario.Usrndx <> 0 Then
            '    ChecarDerechos(Controlador.Sesion.MiUsuario.Usrndx, 0)
            'End If
            'Me.t1 = New Threading.Timer(AddressOf Tick, Nothing, 400, 400)



            TSSLBD.Text = Controlador.Empresa.Catalogo.ToString() & "    "
            TSSLServidor.Text = Controlador.Empresa.Servidor.ToString() & "    "
            TSSLUsuario.Text = Controlador.Sesion.MiUsuario.Usrnom.ToString() & "    "
            TSSLConexion.Text = System.Environment.UserName.ToString() & "    "
            TSSLVersion.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString() & "    "
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            If Controlador.Sesion.Usrndx <> -1 Then
                Me.Timer1.Stop()

                If Me.Timer1.Interval = 200 Then
                    Dim col2 As New CCS.SesionesCollection

                    col2.GetMulti(HCS.SesionesFields.Empndx = Controlador.Sesion.Empndx And _
                                    HCS.SesionesFields.Usrndx = Controlador.Sesion.Usrndx And _
                                    HCS.SesionesFields.Sesact = True, 1, _
                                    New OC.SortExpression(New OC.SortClause(HCS.SesionesFields.Sesfecini, _
                                    SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending)))
                    Controlador.Sesion = col2(0)
                    Timer1.Interval = 20000
                End If

                Controlador.Sesion.Refetch()

                If Not Controlador.Sesion.Sesact Then
                    MsgBox("Se ha iniciado sesión con el mismo usuario en otra computadora", MsgBoxStyle.Information, "Aviso")
                    Cerrar()
                End If

                Dim col As New CCS.SesionesCollection

                col.GetMulti(HCS.SesionesFields.Empndx = Controlador.Sesion.Empndx And _
                                HCS.SesionesFields.Usrndx = Controlador.Sesion.Usrndx And _
                                HCS.SesionesFields.Sesact = True, 0, _
                                New OC.SortExpression(New OC.SortClause(HCS.SesionesFields.Sesfecini, _
                                SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending)))

                If col.Count > 1 Then
                    If Date.Compare(col(0).Sesfecini.ToString("dd/MM/yyyy hh:mm:ss"), Controlador.Sesion.Sesfecini.ToString("dd/MM/yyyy hh:mm:ss")) = 0 Then

#If CONFIG = "Debug" Then
                        For i As Integer = 1 To col.Count - 1
                            col(i).Sesact = False
                        Next

                        col.SaveMulti()
#Else
                        If System.Windows.Forms.MessageBox.Show("Ya se ha iniciado sesión con " & _
                            "este usuario y en esta empresa en otra computadora. ¿Quiere cerrar la " & _
                            "aplicación en la otra computadora?. Si hace click en ""SI"" se cerrara la " & _
                            "aplicación en la otra computadora y los datos que no hayan sido guardados se " & _
                            "perderan, si hace click en ""NO"" se cerrara esta aplicación en esta computadora.", _
                            "Inicio de Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                            MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then

                            For i As Integer = 1 To col.Count - 1
                                col(i).Sesact = False
                            Next

                            col.SaveMulti()
                        Else
                            Controlador.Sesion = col(0)
                            Cerrar()
                        End If
#End If

                    End If
                End If

                Me.Timer1.Start()
            End If
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrio un error al actualizar los datos de la sesion", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Sub

    Private Sub tmProgreso_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmProgreso.Tick
        If Me.tlsProgressBar.Value = Me.tlsProgressBar.Maximum Then
            Me.tlsProgressBar.Value = 0
        Else
            Me.tlsProgressBar.Value += 1
        End If
    End Sub

    Private Sub tmHora_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmHora.Tick
        Me.tlsHora.Text = Now.ToString
        Application.DoEvents()
    End Sub

    'Public Sub cambiarhoratexto()
    '    Me.tlsHora.Text = Now.ToString
    'End Sub

    Private Sub Tick(ByVal cambiarhoratexto As Object)
        Me.tlsHora.Text = Now.ToString
        Application.DoEvents()
    End Sub

#End Region

#Region "Menu Normal"

    '====================================================================
    '=          USEN EL METODO Abrir Para abrir ventanas                =
    '====================================================================

    Private Sub ABCDeEstadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABCDeEstadosToolStripMenuItem.Click
        Abrir(New ClasesComunes.GralCatEstados())
    End Sub

    Private Sub ABCDeCIudadesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABCDeCIudadesToolStripMenuItem.Click
        Abrir(New ClasesComunes.GralCatCiudades())
    End Sub

    Private Sub ABCDePoblacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABCDePoblacionesToolStripMenuItem.Click
        Abrir(New ClasesComunes.GralCatPoblaciones())
    End Sub

    Private Sub DerechosAMenusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DerechosAMenusToolStripMenuItem.Click
        Abrir(New DetallesMenuForm(Me, Application.ProductName))
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Abrir(New MenusForm())
    End Sub

    Private Sub ComprasDirectasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComprasDirectasToolStripMenuItem.Click
        Abrir(New ClasesComunes.frmRecepcionesOrdenesDirectas())

    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Cerrar()
    End Sub

    Private Sub MenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Abrir(New MenusForm())
    End Sub

    Private Sub ConfiguracionToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguracionToolStripMenuItem1.Click
        Abrir(New ConfiguracionForm(Controlador.Seguridad))
    End Sub

    Private Sub AsignacionDeEmpresaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsignacionDeEmpresaToolStripMenuItem.Click
        Abrir(New DetallesEmpresasForm())
    End Sub

    Private Sub RegistroDeUsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroDeUsuariosToolStripMenuItem.Click
        'Abrir(My.Forms.UsuariosForm)
        Abrir(New UsuariosForm())
    End Sub

    Private Sub RegistroDeEmpresasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroDeEmpresasToolStripMenuItem.Click
        Abrir(New EmpresasForm())
    End Sub

    Private Sub AsignacionDePermisosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsignacionDePermisosToolStripMenuItem.Click
        Abrir(New DetallesMenuForm(Me, Application.ProductName))
    End Sub

#End Region

#Region "Menu Esp"

    Private Sub CambiarContraseñaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarContraseñaToolStripMenuItem.Click
        Dim ventana As New frmCambiarPassword

        ventana.Usuario = Controlador.Sesion.MiUsuario
        ventana.ShowDialog()
    End Sub

#End Region

#Region "Menu con Excepcion"

#End Region

    Private Sub ListasPreciosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListasPreciosToolStripMenuItem.Click
        Abrir(New ClasesComunes.FrmListaPrecio())
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        Abrir(New ClasesComunes.FrmABCClientes())
    End Sub

    Private Sub TiposDeClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TiposDeClienteToolStripMenuItem.Click
        Abrir(New ClasesComunes.FrmCatTiposCliente())
    End Sub

    Private Sub ABCDeMovimientosDeAlmacénToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABCDeMovimientosDeAlmacénToolStripMenuItem.Click
        Abrir(New ClasesComunes.CatAlmABCMovtosAlmacen())
    End Sub

    Private Sub TransferenciasDesdeAlmacénToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransferenciasDesdeAlmacénToolStripMenuItem.Click

    End Sub

    'Private Sub PuntoDeVentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Abrir(CatABCPuntosDeVenta)
    'End Sub

    Private Sub NotaDeVentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotaDeVentaToolStripMenuItem.Click
        Abrir(New ClasesComunes.frmNotaDeVenta())
        ' System.Threading.Tasks.Task.Factory.StartNew(AddressOf Abrir, New ClasesComunes.frmNotaDeVenta())
    End Sub

   


    Private Sub LineasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LineasToolStripMenuItem.Click
        Abrir(New ClasesComunes.frmLineas())
    End Sub

    Private Sub ABCDeUnidadDeMedidaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABCDeUnidadDeMedidaToolStripMenuItem.Click
        Abrir(New ClasesComunes.FrmUnidadMedida())
    End Sub

    Private Sub MarcasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarcasToolStripMenuItem.Click
        Abrir(New ClasesComunes.FrmMarcas())
    End Sub

    Private Sub PlazasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlazasToolStripMenuItem.Click
        Abrir(New ClasesComunes.FrmPlaza())
    End Sub

    Private Sub ABCDeProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABCDeProveedoresToolStripMenuItem.Click
        Abrir(New ClasesComunes.CompCatProveedor())
    End Sub

    Private Sub ABCDeTiposDeProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABCDeTiposDeProveedorToolStripMenuItem.Click
        Abrir(New ClasesComunes.FrmTipoProveedor())
    End Sub

    Private Sub ABCDeProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABCDeProductosToolStripMenuItem.Click
        Abrir(New ClasesComunes.frmABCProducosComprasGen())
    End Sub

    Private Sub ConfiguracionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguracionToolStripMenuItem.Click
        Abrir(New ClasesComunes.FrmConfigContabilidad())
    End Sub

    Private Sub SucursalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SucursalesToolStripMenuItem.Click
        Abrir(New ClasesComunes.FrmSucursal())
    End Sub

    Private Sub ReporteDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeToolStripMenuItem.Click
        'Abrir(New ClasesComunes.frmRecepcionFacturas())
        Abrir(New ClasesComunes.frmRepVentaDelDia())
    End Sub

    Private Sub FacturaciónDeNotasDeVentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssmiFacNotasVenta.Click
        Abrir(New frmFacturasNotas())
    End Sub

    Private Sub ConexiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssmiFacConexion.Click
        Abrir(New IntegraLab.FactDigital.Configuracion.frmConfiguracionConexion())

    End Sub

    Private Sub ParametrosYSellosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssmiParamSellos.Click
        Try

            Dim ConStr As String = ControladorFactDigital.Decrypt(System.IO.File.ReadAllText(Application.StartupPath + "\\cx.dat"))
            Dim ctrlFact As New IntegraLab.FactDigital.ControladorFactDigital(Controlador.Empresa.Index, ConStr)
            Abrir(New IntegraLab.FactDigital.Configuracion.frmConfiguracionDigital(ctrlFact))
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString() & " Favor de configurar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
       
    End Sub

    Private Sub tssmiFacDepartamentos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssmiFacDepartamentos.Click
        Try
            Dim ctrlFact As New Integralab.FactDigital.ControladorFactDigital(Controlador.Empresa.Index)
            Abrir(New Integralab.FactDigital.Formas.frmCatDeptos(ctrlFact))
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString() & " Favor de configurar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        
    End Sub

    Private Sub tssmiFacPuestos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssmiFacPuestos.Click
        Try
            Dim ctrlFact As New Integralab.FactDigital.ControladorFactDigital(Controlador.Empresa.Index)
            Abrir(New Integralab.FactDigital.Formas.frmCatPuestos(ctrlFact))
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString() & " Favor de configurar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub tssmiFacEmpleados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssmiFacEmpleados.Click
        Try
            Dim ctrlFact As New Integralab.FactDigital.ControladorFactDigital(Controlador.Empresa.Index)
            Abrir(New Integralab.FactDigital.Formas.frmCatEmpleados(ctrlFact))
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString() & " Favor de configurar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub tssmiFacVentaDiaria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssmiFacVentaDiaria.Click
        Abrir(New frmFacturasVtaDiaria())
    End Sub

    Private Sub tssmiFacFacturaNomina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssmiFacFacturaNomina.Click
        Dim ctrlFact As New IntegraLab.FactDigital.ControladorFactDigital(Controlador.Empresa.Index)
        Abrir(New IntegraLab.FactDigital.Formas.frmPagoNomina(ctrlFact))
    End Sub

    Private Sub FoliosDeFacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FoliosDeFacturasToolStripMenuItem.Click
        Abrir(New ClasesComunes.frmFoliosFacturas())
    End Sub

    'Private Sub RecepciónDeFacturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    'End Sub

    'Private Sub tssmiRecepciónDeFacturas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecepciónDeFacturasToolStripMenuItem.Click

    'End Sub

    Private Sub tssmiRecepciónDeFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tssmiRecepciónDeFacturas.Click
        Abrir(New ClasesComunes.frmRecepcionFacturas())
    End Sub

    Private Sub ProcesoDePagosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcesoDePagosToolStripMenuItem.Click
        'Abrir(New ClasesComunes.PagosaProveedoresForm())        
        Abrir(New ClasesComunes.frmPagoRecepCompra())
    End Sub

    Private Sub ConceptosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConceptosToolStripMenuItem.Click
        Abrir(New ClasesComunes.frmCatConceptos())
    End Sub

    Public Sub LlamaForma(Of tipoForma As {New, System.Windows.Forms.Form, System.IDisposable})() Implements ClasesNegocio.iMainForm.LlamaForma
        Dim forma As New Forma(Of tipoForma)(Me)
    End Sub

#Region "SubClases"
    Class Forma(Of tipoForma As {IDisposable, Windows.Forms.Form, New})
        Dim miForma As tipoForma = Nothing

        Sub New(ByVal Padre As MDIMenuPrincipal)
            Try
                For Each frm As Windows.Forms.Form In Padre.MdiChildren
                    If frm.GetType() Is GetType(tipoForma) Then
                        miForma = DirectCast(frm, tipoForma)
                        Me.Finalize()
                        Exit For
                    End If
                Next
                If IsNothing(miForma) Then
                    miForma = New tipoForma
                    miForma.MdiParent = Padre
                    'miForma.Icon = My.Resources.Icono
                    'miForma.Icon = My.Resources.Culture.i
                    AddHandler miForma.FormClosed, AddressOf FormClosed
                    miForma.Show()
                Else
                    miForma.Focus()
                    miForma.Show()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message & vbCrLf & ex.InnerException.ToString)
            End Try
        End Sub

        Private Sub FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs)
            miForma.Dispose()
            Me.Finalize()
        End Sub

    End Class
#End Region

    Private Sub ComprasDelDiaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ComprasDelDiaToolStripMenuItem.Click
        Abrir(New ClasesComunes.frmRepCompras())
    End Sub

    Private Sub AlmacenesToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles AlmacenesToolStripMenuItem1.Click
        Abrir(New ClasesComunes.CatAlmABCAlmacenes())
    End Sub

    Private Sub InventarioPorProductoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InventarioPorProductoToolStripMenuItem.Click

    End Sub

    Private Sub CapturaDeInventarioFisicoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CapturaDeInventarioFisicoToolStripMenuItem.Click
        Abrir(New ClasesComunes.FrmCapturaInvFisico())
    End Sub

    Private Sub InventarioValorizadoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InventarioValorizadoToolStripMenuItem.Click
        Abrir(New ClasesComunes.rptInventarioValorizado())
    End Sub

    Private Sub ConteoInventarioFisicoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConteoInventarioFisicoToolStripMenuItem.Click
        Abrir(New ClasesComunes.frmReporteInvFisico())
    End Sub

    Private Sub VentasPorProductoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VentasPorProductoToolStripMenuItem.Click

    End Sub

    Private Sub AltaRápidaDeProductosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AltaRápidaDeProductosToolStripMenuItem.Click
        Abrir(New ClasesComunes.frmAltaRapidaProdGen())
    End Sub


    Private Sub ConfiguraciónPVToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConfiguraciónPVToolStripMenuItem.Click
        Abrir(New ClasesComunes.ConfigPV())
    End Sub

    Private Sub MDIMenuPrincipal_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        Dim regVersion As Microsoft.Win32.RegistryKey
        'regVersion = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("INTEGRALAB\\", True)
        Try
            regVersion = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\\INTEGRALAB\\", True)

            'TestMethod("SOFTWARE")
            If regVersion Is Nothing Then
                Dim reg As RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\", True)
                reg.CreateSubKey("INTEGRALAB")
                reg.Close()
                reg = Nothing
                reg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\INTEGRALAB\", True)
                reg.SetValue("CodigoSucursal", "0", Microsoft.Win32.RegistryValueKind.String)
                reg.SetValue("NombreImpresora", "", Microsoft.Win32.RegistryValueKind.String)
                reg.Close()
            End If




            If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\INTEGRALAB\", "CodigoSucursal", Nothing) = "0" Or My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\INTEGRALAB\", "NombreImpresora", Nothing) = "" Then

                Dim config As New ClasesComunes.ConfigPV()
                'config.ShowDialog()
                config.StartPosition = FormStartPosition.CenterScreen
                config.SeleccionarSucursal = My.Settings.CodSucursal
                config.NomImpresora = My.Settings.NomImpresora
                config.ShowDialog()
                'Else
                '    MsgBox(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Wow6432Node\INTEGRALAB\", "CodigoSucursal", Nothing) & "---> " & My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Wow6432Node\INTEGRALAB\", "NombreImpresora", Nothing), MsgBoxStyle.Exclamation, "INTEGRALAB S.A DE C.V - PUNTO DE VENTA")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical, "INTEGRALAB S.A DE C.V - PUNTO DE VENTA")
            Me.Close()
        End Try

    End Sub





    Private Sub RendimientoVentaVsCostoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RendimientoVentaVsCostoToolStripMenuItem.Click
        Abrir(New ClasesComunes.frmReporteVentaCostovb)
    End Sub

    Private Sub MovimientosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MovimientosToolStripMenuItem.Click
        Abrir(New ClasesComunes.frmGenerarMovtosAlmacen)
    End Sub

    Private Sub CuentasContablesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CuentasContablesToolStripMenuItem.Click
        Abrir(New ClasesComunes.CatCuentaContableForm)
    End Sub

    Private Sub DepartamentosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DepartamentosToolStripMenuItem.Click
        Abrir(New ClasesComunes.frmDepartamentos)
    End Sub

    Private Sub MetodosDeProrateoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MetodosDeProrateoToolStripMenuItem.Click
        Abrir(New ClasesComunes.frmMetodoProrrateo)
    End Sub

    Private Sub PresupuestosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PresupuestosToolStripMenuItem.Click

    End Sub

    Private Sub ControlDeMesesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ControlDeMesesToolStripMenuItem.Click
        Abrir(New ClasesComunes.frmControlMeses)
    End Sub

    Private Sub PeriodosContablesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PeriodosContablesToolStripMenuItem.Click
        Abrir(New ClasesComunes.ABCPeriodosContables)
    End Sub

    Private Sub ConfiguracionDeCuentasDeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConfiguracionDeCuentasDeToolStripMenuItem.Click
        Abrir(New ClasesComunes.FrmConfiguracionCtasControl)
    End Sub

    Private Sub ConceptosDeFlujoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConceptosDeFlujoToolStripMenuItem.Click
        Abrir(New ClasesComunes.CatConceptoFlujoForm)
    End Sub

    Private Sub PreToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PreToolStripMenuItem.Click
        Abrir(New ClasesComunes.FrmPrePolizas)
    End Sub

    Private Sub AgrupadoresDeEstadosFinancierosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AgrupadoresDeEstadosFinancierosToolStripMenuItem.Click
        Abrir(New ClasesComunes.frmAgrupadorBalanceGeneral)
    End Sub

    Private Sub SeleccionarPeriodoContableToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SeleccionarPeriodoContableToolStripMenuItem.Click
        Abrir(New ClasesComunes.frmSeleccionarPeriodo)
    End Sub

    Private Sub TraspasoDeCuentasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TraspasoDeCuentasToolStripMenuItem.Click
        Abrir(New ClasesComunes.frmTraspasodeCuentas)
    End Sub

    Private Sub AsignarAgrupadorSATACuentasContablesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AsignarAgrupadorSATACuentasContablesToolStripMenuItem.Click
        Abrir(New ClasesContabilidad.frmAsignaCuentasSAT)
    End Sub

    Private Sub GenerarCatálagoDeCuentasSATToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GenerarCatálagoDeCuentasSATToolStripMenuItem.Click
        Abrir(New ClasesContabilidad.frmGeneraCuentasSAT(Controlador))

    End Sub

    Private Sub CapturaDePolizasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CapturaDePolizasToolStripMenuItem.Click
        Abrir(New ClasesComunes.PolizaDiario)
    End Sub

    Private Sub ReporteDeInventarioMensualToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReporteDeInventarioMensualToolStripMenuItem.Click
        Abrir(New ClasesComunes.frmRepInvMes)
    End Sub

    Private Sub ConfiguraciónDeFacturasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConfiguraciónDeFacturasToolStripMenuItem.Click

    End Sub

    Private Sub StatusStrip_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles StatusStrip.ItemClicked

    End Sub

    Private Sub SplitContainer1_Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub CancelarNotaDeVentaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CancelarNotaDeVentaToolStripMenuItem.Click
        Abrir(New ClasesComunes.frmCancelarNotaVenta)
    End Sub

    Private Sub MovimientosDeAlmacénToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles MovimientosDeAlmacénToolStripMenuItem1.Click
        ''Pantalla de Movimientos de Almacen
        Abrir(New ClasesComunes.frmReporteMovimeintoAlmacenGeneral)
    End Sub

    Private Sub KardexToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KardexToolStripMenuItem.Click
        Abrir(New ClasesComunes.FrmAlmKardex)
    End Sub
End Class