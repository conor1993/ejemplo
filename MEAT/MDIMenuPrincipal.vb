'Imports System.Windows.Forms
Imports HC = Integralab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CCS = Integralab.ORMSeguridad.CollectionClasses
Imports ECS = Integralab.ORMSeguridad.EntityClasses
Imports HCS = Integralab.ORMSeguridad.HelperClasses
Imports Integralab.FormasSeguridad
Imports ClasesComunes

Public Class MDIMenuPrincipal

#Region "Constructores"

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Tag = Controlador.Sesion.MiEmpresa.Empnom

        If Not Controlador.Sesion.MiEmpresa IsNot Nothing Then
            Me.tlsBaseDatos.Text = "Base de Datos: " & Controlador.Sesion.MiEmpresa.Empcat
            Me.tlsServidor.Text = "Servidor: " & Controlador.Sesion.MiEmpresa.Empsrv
        End If

        If Not Controlador.Sesion.MiUsuario IsNot Nothing Then
            Me.tlsUsuario.Text = "Usuario: " & Controlador.Sesion.MiUsuario.Usrnomcom
        End If

        Me.tlsHora.Text = Now

        If Controlador.Sesion.MiEmpresa.EmpIcono.Length > 0 Then
            Dim Stream As New System.IO.MemoryStream(Controlador.Sesion.MiEmpresa.EmpIcono)
            Dim Icono As New System.Drawing.Icon(Stream)
            Me.Icon = Icono
        Else
            Me.Icon = My.Resources.JSLogo32
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

    '''' <summary>
    '''' Oculta todos los menus
    '''' </summary>
    '''' <remarks></remarks>
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
    '    Try
    '        'checar privilegios de usuarios
    '        Dim Privilegios As New CCS.DetallemenususuariosCollection
    '        Dim MenuPrivilegios As New CCS.MenusCollection

    '        'sacar nombres de las funciones y menus del sistema
    '        OcutarMenus(MenuStrip.Items)
    '        Privilegios.GetMulti(HCS.DetallemenususuariosFields.Usrndx = UsuarioId)
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
    '                MessageBox.Show("Usuario no tiene derechos a ninguna función del sistema", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            End If
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
            'If Not Controlador.Sesion.MiEmpresa IsNot Nothing Then
            Me.tlsBaseDatos.Text = "Base de Datos: " & Controlador.Sesion.MiEmpresa.Empcat
            Me.tlsServidor.Text = "Servidor: " & Controlador.Sesion.MiEmpresa.Empsrv
            'End If

            'If Not Controlador.Sesion.MiUsuario IsNot Nothing Then
            Me.tlsUsuario.Text = "Usuario: " & Controlador.Sesion.MiUsuario.Usrnomcom
            ' End If
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
    End Sub

#End Region

#Region "Menu Normal"

    '====================================================================
    '=          USEN EL METODO Abrir Para abrir ventanas                =
    '====================================================================

    Private Sub ToolStripMenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem24.Click
        Abrir(My.Forms.MFacRegFacturasVentas)
    End Sub

    Private Sub FacturaDeCortesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturaDeCortesToolStripMenuItem.Click
        Abrir(MFacRegEmbarques)
    End Sub

    Private Sub ABCDeRastrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABCDeRastrosToolStripMenuItem.Click
        Abrir(FrmABCRastros)
    End Sub

    Private Sub AperturaDeLoteDeCortesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AperturaDeLoteDeCortesToolStripMenuItem.Click
        Abrir(FrmAperturaLoteCorte)
    End Sub

    Private Sub ABCDePreCortesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABCDePreCortesToolStripMenuItem.Click
        Abrir(FrmABCPreCortes)
    End Sub

    Private Sub ABCDeCortesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABCDeCortesToolStripMenuItem.Click
        Abrir(FrmABCCortes)
    End Sub

    Private Sub ABCDeAlmacenesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABCDeAlmacenesToolStripMenuItem.Click
        Abrir(New CatAlmABCAlmacenes())
    End Sub

    Private Sub EntradaDeCanalesACorteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntradaDeCanalesACorteToolStripMenuItem.Click
        Abrir(FrmEntCanalesaCorte)
    End Sub

    Private Sub CierreDeLoteDeCortesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CierreDeLoteDeCortesToolStripMenuItem.Click
        Abrir(FrmCierreLoteCorte)
    End Sub

    Private Sub ABCDeProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABCDeProductosToolStripMenuItem.Click
        Abrir(frmABCProductosCompras)
    End Sub

    Private Sub TiposDeCorralesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TiposDeCorralesToolStripMenuItem.Click
        Abrir(FrmABCTiposCorrales)
    End Sub

    Private Sub ABCDeCorralesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABCDeCorralesToolStripMenuItem.Click
        Abrir(FrmABCCorrales)
    End Sub

    Private Sub ABCDeLotesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABCDeLotesToolStripMenuItem.Click
        Abrir(FrmABCLotes)
    End Sub

    Private Sub CompradoresDeGanadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompradoresDeGanadoToolStripMenuItem.Click
        Abrir(FrmABCCompradoresGanado)
    End Sub

    Private Sub TiposDeGanadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TiposDeGanadoToolStripMenuItem.Click
        Abrir(FrmABCTipoGanado)
    End Sub

    Private Sub CausasDeMuerteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CausasDeMuerteToolStripMenuItem.Click
        Abrir(FrmABCCausasMuertes)
    End Sub

    Private Sub ABCDeCuentasContablesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABCDeCuentasContablesToolStripMenuItem.Click
        Abrir(My.Forms.CatCuentaContableForm)
    End Sub

    Private Sub RecepciónDeCompraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecepciónDeCompraToolStripMenuItem.Click
        Abrir(My.Forms.FrmComprasGanado)
    End Sub

    Private Sub SalidasDeRecibaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalidasDeRecibaToolStripMenuItem.Click
        Abrir(My.Forms.frmSalidasRecibaCorral)
    End Sub

    Private Sub AplicaciónDeFormulasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AplicaciónDeFormulasToolStripMenuItem.Click
        Abrir(My.Forms.frmAplicacionFormula)
    End Sub

    Private Sub SolicitudDeProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SolicitudDeProductosToolStripMenuItem.Click
        Abrir(FrmRegSolProducto)
    End Sub

    Private Sub RecepciónDePagosDeClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecepciónDePagosDeClientesToolStripMenuItem.Click
        Abrir(FrmRecepcionPagosClientes)
    End Sub

    Private Sub RecepciónDeFacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecepciónDeFacturasToolStripMenuItem.Click
        Abrir(RecepcionFacturasForm)
    End Sub

    Private Sub RecepcionDeGanadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecepcionDeGanadoToolStripMenuItem.Click
        Abrir(FrmRecepciondeGanado)
    End Sub

    Private Sub RegistroDeSacrificioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroDeSacrificioToolStripMenuItem.Click
        Abrir(FrmRegistroSacrificios)
    End Sub

    Private Sub DecomisosYSubProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecomisosYSubProductosToolStripMenuItem.Click
        Abrir(FrmDecomisos)
    End Sub

    Private Sub ABCMotivosDeDecomisoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABCMotivosDeDecomisoToolStripMenuItem.Click
        Abrir(FrmABCmotivosDecomiso)
    End Sub

    Private Sub ABCDeEstadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABCDeEstadosToolStripMenuItem.Click
        Abrir(GralCatEstados)
    End Sub

    Private Sub LineasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LineasToolStripMenuItem.Click
        Abrir(frmLineas)
    End Sub

    Private Sub SubLineasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Abrir(FrmSubLinea)
    End Sub

    Private Sub ABCDeUnidadDeMedidaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABCDeUnidadDeMedidaToolStripMenuItem.Click
        Abrir(FrmUnidadMedida)
    End Sub

    Private Sub MarcaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Abrir(CompCatMarcas)
    End Sub

    Private Sub PresentacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Abrir(CompCatPresentacionPdto)
    End Sub

    Private Sub TipoDeProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Abrir(frmtiposproductos)
    End Sub

    Private Sub ABCDeProductosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABCDeProductosToolStripMenuItem1.Click
        Abrir(frmABCProducosComprasGen)
    End Sub

    Private Sub TipoDePresupuestosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Abrir(CompCatTipoPresupuesto)
    End Sub

    Private Sub ABCDeTiposDeProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABCDeTiposDeProveedorToolStripMenuItem.Click
        Abrir(FrmTipoProveedor)
    End Sub

    Private Sub ABCDeProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABCDeProveedoresToolStripMenuItem.Click
        Abrir(CompCatProveedor)
    End Sub

    Private Sub EmisiónDeOrdenesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Abrir(FrmRegCotizaciones)
    End Sub

    Private Sub RecepciónDeOrdenesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Abrir(ComAnalisisCotCompras)
    End Sub

    Private Sub ReimpresiónDeRecepciónDeOrdenesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReimpresiónDeRecepciónDeOrdenesToolStripMenuItem.Click
        Abrir(ComEmisionOrdenCompra)
    End Sub

    Private Sub ABCDePlazasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABCDePlazasToolStripMenuItem.Click
        Abrir(FrmPlaza)
    End Sub

    Private Sub ABCDeSucursalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABCDeSucursalesToolStripMenuItem.Click
        Abrir(FrmSucursal)
    End Sub

    Private Sub ABCDeCIudadesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABCDeCIudadesToolStripMenuItem.Click
        Abrir(GralCatCiudades)
    End Sub

    Private Sub ABCDePoblacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABCDePoblacionesToolStripMenuItem.Click
        Abrir(GralCatPoblaciones)
    End Sub

    Private Sub AutorizaciónDeOrdenesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutorizaciónDeOrdenesToolStripMenuItem.Click
        Abrir(ComAutOrdenCpra)
    End Sub

    Private Sub MovimientosDeGanadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovimientosDeGanadoToolStripMenuItem.Click
        Abrir(FrmABCMovimientosGanado)
    End Sub

    Private Sub ConceptoDeGastosDeTransporteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConceptoDeGastosDeTransporteToolStripMenuItem.Click
        Abrir(FrmABCConceptoGastosTransportes)
    End Sub

    Private Sub CancelaciónDeProductosSolicitadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelaciónDeProductosSolicitadosToolStripMenuItem.Click
        Abrir(ComRecepcionOrdenesCompra)
    End Sub

    Private Sub CancelaProductosSolicitadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelaProductosSolicitadosToolStripMenuItem.Click
        Abrir(FrmCanProductosSolicitados)
    End Sub

    Private Sub FiniquitoDeOrdenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FiniquitoDeOrdenToolStripMenuItem.Click
        Abrir(ComFiniquitoOrdenCompra)
    End Sub

    Private Sub AplicacionesDeGastosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AplicacionesDeGastosToolStripMenuItem.Click
        Abrir(CatAlmTipoAlmacen)
    End Sub

    Private Sub ABCDeMovimientosDeAlmacénToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABCDeMovimientosDeAlmacénToolStripMenuItem.Click
        Abrir(New CatAlmABCMovtosAlmacen)
    End Sub

    Private Sub opReportes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opReportes.Click
        Abrir(FormaReportes)
    End Sub

    Private Sub SolicitudDeServiciosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SolicitudDeServiciosToolStripMenuItem.Click
        Abrir(ComSolicitudServicios)
    End Sub

    Private Sub CotizaciónDeServiciosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CotizaciónDeServiciosToolStripMenuItem.Click
        Abrir(ComRegCotizacionServicio)
    End Sub

    Private Sub EmisiónDeOrdenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmisiónDeOrdenToolStripMenuItem.Click
        Abrir(ComEmisionOrdenServicio)
    End Sub

    Private Sub BancosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BancosToolStripMenuItem.Click
        Abrir(BcoCatBancos)
    End Sub

    Private Sub ABCDeChoferesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABCDeChoferesToolStripMenuItem.Click
        Abrir(CatComp07Choferes)
    End Sub

    Private Sub RecepciónDeCompraToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecepciónDeCompraToolStripMenuItem1.Click
        Abrir(FrmRptComprasGanado)
    End Sub

    Private Sub ConsultaCorralesDeRecepciómToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaCorralesDeRecepciómToolStripMenuItem.Click
        Abrir(FrmConsultaCorralesRecepcion)
    End Sub

    Private Sub BeneficiariosToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeneficiariosToolStripMenuItem.Click
        Abrir(CatBeneficiariosForm)
    End Sub

    Private Sub ABCDeVehiculosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABCDeVehiculosToolStripMenuItem.Click
        Abrir(FrmABCVehiculos)
    End Sub

    Private Sub ActualizarSaldosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarSaldosToolStripMenuItem.Click
        Abrir(frmActualizacionSaldos)
    End Sub

    Private Sub CapturaDePolizasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CapturaDePolizasToolStripMenuItem.Click
        Abrir(My.Forms.PolizaDiario)
    End Sub

    Private Sub GeneraciónDeArchivoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Abrir(GeneraArchivoFacturasForm)
    End Sub

    Private Sub ProgramaciónDePagosDeFacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Abrir(AutorizaPagosForm)
    End Sub

    Private Sub ConsultaDeProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeProveedoresToolStripMenuItem.Click
        Abrir(_390ConsultaProveedores)
    End Sub

    Private Sub EntregaDeChequesAProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntregaDeChequesAProveedoresToolStripMenuItem.Click
        Abrir(EntregaChequesAProveedoresForm)
    End Sub

    Private Sub CinfiguracionProduccónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CinfiguracionProduccónToolStripMenuItem.Click
        Abrir(ModInvProdConfigForm)
    End Sub

    Private Sub ConfiguraciónDeMovimientosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguraciónDeMovimientosToolStripMenuItem.Click
        Abrir(ModInvConfiguracionForm)
    End Sub

    Private Sub CapturaDeProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CapturaDeProductosToolStripMenuItem.Click
        Abrir(FrmCapturaProductos)
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        Abrir(New ClasesComunes.FrmABCClientes())
    End Sub

    Private Sub ReporteDeFacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeFacturasToolStripMenuItem.Click
        Abrir(ReporteFacturasForm)
    End Sub

    Private Sub RecepFacturasGastosToolStripMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecepFacturasGastosToolStripMenu.Click
        Abrir(RegistroFacGastosFrm)
    End Sub

    Private Sub ReporteDeFacturasDeGastosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeFacturasDeGastosToolStripMenuItem.Click
        Abrir(_690ReporteFacturasGastos)
    End Sub

    Private Sub RegistroDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroDeToolStripMenuItem.Click
        Abrir(RegistroChequeForm)
    End Sub

    Private Sub CancelaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelaciónToolStripMenuItem.Click
        Abrir(CancelacionChequeForm)
    End Sub

    Private Sub RegistroDeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroDeToolStripMenuItem1.Click
        Abrir(RegistroIngresosForm)
    End Sub

    Private Sub CancelaciónToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelaciónToolStripMenuItem1.Click
        Abrir(CancelacionIngresosForm)
    End Sub

    Private Sub ReporteDeAntigüedadDeSaldosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeAntigüedadDeSaldosToolStripMenuItem.Click
        Abrir(_390AntiguedadSaldosFrm)
    End Sub

    Private Sub ConfiguaciónDeCuentasDeControlToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguaciónDeCuentasDeControlToolStripMenuItem.Click
        Abrir(FrmConfiguracionCtasControl)
    End Sub

    Private Sub ChequesPostfechadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChequesPostfechadosToolStripMenuItem.Click
        Abrir(_092ChequesPostfechados)
    End Sub

    Private Sub AuxiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AuxiToolStripMenuItem.Click
        Abrir(_390AuxiliardePasivos)
    End Sub

    Private Sub PólizaDePasivosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PólizaDePasivosToolStripMenuItem.Click
        Abrir(_390GeneraPolizaPasivo)
    End Sub

    Private Sub CancelaciónDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelaciónDeToolStripMenuItem.Click
        Abrir(_390CancelacionPolizaPasivo)
    End Sub

    Private Sub DerechosAMenusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DerechosAMenusToolStripMenuItem.Click
        Abrir(New DetallesMenuForm(Me, "MEAT"))
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Abrir(New MenusForm())
    End Sub

    Private Sub DestinosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DestinosToolStripMenuItem.Click
        Abrir(FrmDestinos)
    End Sub

    Private Sub EstadoDeCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstadoDeCuenta.Click
        Abrir(ReportedeEstadodeCuenta)
    End Sub

    Private Sub Saldos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Saldos.Click
        Abrir(_692ReportedeSaldos)
    End Sub

    Private Sub ComprasDirectasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComprasDirectasToolStripMenuItem.Click
        Abrir(frmRecepcionesOrdenesDirectasMeat)
    End Sub

    Private Sub CortesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CortesToolStripMenuItem.Click
        Abrir(_660ReportedeCortes)
    End Sub

    Private Sub CentroDeCostosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CentroDeCostosToolStripMenuItem.Click
        Abrir(CatAlmCentroDeCostos)
    End Sub

    Private Sub ABCDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Abrir(CatCuentaContableForm)
    End Sub

    Private Sub PeriodosContablesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PeriodosContablesToolStripMenuItem.Click
        Abrir(ABCPeriodosContables)
    End Sub

    Private Sub ConceptosDeFlujoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConceptosDeFlujoToolStripMenuItem.Click
        Abrir(CatConceptoFlujoForm)
    End Sub

    Private Sub ServiciosDeRastrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServiciosDeRastrosToolStripMenuItem.Click
        Abrir(My.Forms.FrmABCServicios)
    End Sub

    Private Sub RendimientosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RendimientosToolStripMenuItem.Click
        Abrir(FrmReporteCanal_Corte)
    End Sub

    Private Sub IntegralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IntegralToolStripMenuItem.Click
        Abrir(FrmReporteIntegral)
    End Sub

    Private Sub ABCDeDepartamentosToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABCDeDepartamentosToolStripMenuItem.Click
        Abrir(frmDepartamentos)
    End Sub

    Private Sub PuestosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Abrir(FrmNomPuestos)
    End Sub

    Private Sub PercepcionesDeducciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Abrir(FrmNomConfiguracionIMSS)
    End Sub

    Private Sub Impuestos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Abrir(frmNomISR)
    End Sub

    Private Sub PersonalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Abrir(FrmNomEmpleados)
    End Sub

    Private Sub EstadoDeResultadosToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Abrir(frmEstadoResultado)
    End Sub

    Private Sub ReimpresiónDeEtiquetasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReimpresiónDeEtiquetasToolStripMenuItem.Click
        Abrir(My.Forms.FrmReEtiquetacion)
    End Sub

    Private Sub BalanceGeneralToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Abrir(My.Forms.FrmABCdeEstadosFinancieros)
    End Sub

    Private Sub ReToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReToolStripMenuItem.Click
        Abrir(FrmReEtiquetacionCortes)
    End Sub

    Private Sub RelacionProductosClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelacionProductosClientesToolStripMenuItem.Click
        Abrir(FrmRelacionClienteCorte)
    End Sub

    Private Sub PrecioXClienteYDestinoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrecioXClienteYDestinoToolStripMenuItem.Click
        Abrir(FrmABCPrecioxClienteDestino)
    End Sub

    Private Sub ReporteDeVentasPorFacturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeVentasPorFacturaToolStripMenuItem.Click
        Abrir(My.Forms.frmReporteVentas)
    End Sub

    Private Sub ControlMesesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControlMesesToolStripMenuItem.Click
        Abrir(My.Forms.frmControlMeses)
    End Sub

    Private Sub TiposDeNotaDeCreditoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TiposDeNotaDeCreditoToolStripMenuItem.Click
        Abrir(_092ConceptodeNotasdeCredito)
    End Sub

    Private Sub VentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasToolStripMenuItem.Click
        Abrir(My.Forms.frmReporteFacturacionXCliente)
    End Sub

    Private Sub MetodosDeProrrateoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetodosDeProrrateoToolStripMenuItem.Click
        Abrir(My.Forms.frmMetodoProrrateo)
    End Sub

    Private Sub NotasDeCréditoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotasDeCréditoToolStripMenuItem.Click
        Abrir(My.Forms.FrmNotaCredito)
    End Sub

    Private Sub SaldosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaldosToolStripMenuItem.Click
        Abrir(My.Forms.frmConsultaSaldo)
    End Sub

    Private Sub DesactualizaciónDeSaldosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DesactualizaciónDeSaldosToolStripMenuItem.Click
        Abrir(My.Forms.frmDesactualizacionSaldos)
    End Sub

    Private Sub SaldosAnaliticaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaldosAnaliticaToolStripMenuItem.Click
        Abrir(My.Forms.frmConsultaAnaliticaSaldos)
    End Sub

    Private Sub ProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductToolStripMenuItem.Click
        Abrir(My.Forms.FrmReporteProductos)
    End Sub

    Private Sub RecepcionCanalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecepcionCanalToolStripMenuItem.Click
        Abrir(My.Forms.frmReporteDeCanales)
    End Sub

    Private Sub DecomisosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecomisosToolStripMenuItem.Click
        Abrir(My.Forms.FrmReporteDecomisos)
    End Sub

    Private Sub FacturacionDeVentasPorClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturacionDeVentasPorClienteToolStripMenuItem.Click
        Abrir(My.Forms.frmReporteFacturasPorCliente)
    End Sub

    Private Sub VendedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendedoresToolStripMenuItem.Click
        Abrir(My.Forms.FrmComisionista)
    End Sub

    Private Sub PagosDeClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagosDeClientesToolStripMenuItem.Click
        Abrir(My.Forms.frmReportedePagos)
    End Sub

    Private Sub DepartamentosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Abrir(My.Forms.frmDepartamentos)
    End Sub

    Private Sub SubsidioAlEmpleoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Abrir(My.Forms.frmNomSubcidio)
    End Sub

    Private Sub KardexToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KardexToolStripMenuItem.Click
        'Abrir(CatAlmConsKardexPto)
        Abrir(FrmAlmKardex)
    End Sub

    Private Sub KArdexToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KArdexToolStripMenuItem1.Click
        Abrir(My.Forms.frmKardexProduccion)
    End Sub

    Private Sub MovimientosDeAlmacénToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovimientosDeAlmacénToolStripMenuItem.Click
        Abrir(My.Forms.frmReporteDeMovimientosDeAlmacen)
    End Sub

    Private Sub MovimientosDeAlmacénPorProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovimientosDeAlmacénPorProductoToolStripMenuItem.Click
        Abrir(My.Forms.frmReporteDeMovimientosDeAlmacenPorProductos)
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

    Private Sub VentasPorProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasPorProductoToolStripMenuItem.Click
        Abrir(My.Forms.FrmReporteDeVentasPorProducto)
    End Sub

    Private Sub EmbarquesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmbarquesToolStripMenuItem.Click
        Abrir(My.Forms.FrmReporteDeEmbarques)
    End Sub

    Private Sub CierreDeLotesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CierreDeLotesToolStripMenuItem.Click
        Abrir(My.Forms.FrmCierreDeLotes)
    End Sub

    Private Sub EstadisticoDeLotesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstadisticoDeLotesToolStripMenuItem.Click
        Abrir(My.Forms.frmEstadisticoLotes)
    End Sub

    Private Sub CierreFicticioDeLotesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CierreFicticioDeLotesToolStripMenuItem.Click
        Abrir(My.Forms.FrmCierreFicticioDeLotes)
    End Sub

    Private Sub ConsultaDeCorralesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeCorralesToolStripMenuItem.Click
        Abrir(My.Forms.FrmConsultaCorrales)
    End Sub

    Private Sub CambioDeCorralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambioDeCorralToolStripMenuItem.Click
        Abrir(My.Forms.FrmCambioCorral)
    End Sub

    Private Sub CierreDiarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CierreDiarioToolStripMenuItem.Click
        Abrir(My.Forms.FrmCierreDiarioEngorda)
    End Sub

    Private Sub ArchivoDeCierreFicticioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArchivoDeCierreFicticioToolStripMenuItem.Click
        Abrir(My.Forms.FrmArchivoCierreFicticioLotes)
    End Sub

    Private Sub DetalladodeLotes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetalladodeLotes.Click
        Abrir(My.Forms.FrmReporteDetalladoLotes)
    End Sub

    Private Sub ExistenciasPorTipoDeGanadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExistenciasPorTipoDeGanadoToolStripMenuItem.Click
        Abrir(FrmReporteExistenciasxTipoGanado)
    End Sub

    Private Sub TarjetaAuxiliarDeCortesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TarjetaAuxiliarDeCortesToolStripMenuItem.Click
        Abrir(My.Forms.FrmAlmProdTarjetaAuxiliar)
    End Sub

    Private Sub ToolStripMenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem10.Click
        Abrir(My.Forms.FrmComparativoFisicoLibrosProduccion)
    End Sub

    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        Abrir(My.Forms.FrmAlmRecalculodeExistenciasProduccion)
    End Sub

    Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click
        Abrir(My.Forms.FrmAlmSustituciondeInventario)
    End Sub

    Private Sub CapturaInventarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CapturaInventarioToolStripMenuItem.Click
        Abrir(My.Forms.FrmCapturaInvFisico)
    End Sub

    Private Sub AnalisisDeInventarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnalisisDeInventarioToolStripMenuItem.Click
        Abrir(My.Forms.FrmInvFisicoVsLibro)
    End Sub

    Private Sub InventarioPorProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventarioPorProductoToolStripMenuItem.Click
        Abrir(My.Forms.CatAlmConsultaInventProd)
    End Sub

    Private Sub SalidaDeCortesPorReprocesoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalidaDeCortesPorReprocesoToolStripMenuItem.Click
        Abrir(My.Forms.frmSalidaXReproceso)
    End Sub

    Private Sub MotivosDeDevoluciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MotivosDeDevoluciónToolStripMenuItem.Click
        Abrir(My.Forms.frmABCMotivoDevolucion)
    End Sub

    Private Sub DevoluciónVentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevoluciónVentaToolStripMenuItem.Click
        Abrir(My.Forms.frmDevolucion)
    End Sub

    Private Sub DevolucionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevolucionesToolStripMenuItem.Click
        Abrir(My.Forms.frmReporteDevoluciones)
    End Sub

    Private Sub ConfiguracionDeMovimientosDeGanadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguracionDeMovimientosDeGanadoToolStripMenuItem.Click
        Abrir(My.Forms.frmConfiguracionMovimientoGanado)
    End Sub

    Private Sub FacturasGeneralesToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturasGeneralesToolStripMenuItem.Click
        Abrir(My.Forms.frmReporteFactura)
    End Sub

    Private Sub TransferenciasCajasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransferenciasCajasToolStripMenuItem.Click
        Abrir(My.Forms.frmTransferenciasCajas)
    End Sub

    Private Sub PrepolizasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrepolizasToolStripMenuItem.Click
        Abrir(My.Forms.FrmPrePolizas)
    End Sub

    Private Sub CuentasBanacariasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuentasBanacariasToolStripMenuItem.Click
        Abrir(My.Forms.CatCuentasForm)
    End Sub

    Private Sub ReprocesosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReprocesosToolStripMenuItem.Click
        Abrir(My.Forms.FrmReportedeReprocesos)
    End Sub

    Private Sub AntigüedadDeCajasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AntigüedadDeCajasToolStripMenuItem.Click
        Abrir(My.Forms.FrmReportedeAntiguedaddeCajas)
    End Sub

    Private Sub LugaresDeCompraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LugaresDeCompraToolStripMenuItem.Click
        Abrir(My.Forms.frmLugarDeCompra)
    End Sub

    Private Sub FacturasPorVendedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturasPorVendedorToolStripMenuItem.Click
        Abrir(My.Forms.FrmReportedeVendedores)
    End Sub

    Private Sub TransferenciasDeCajasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransferenciasDeCajasToolStripMenuItem.Click
        Abrir(My.Forms.frmReporteTransferenciasCaja)
    End Sub

    Private Sub NutrientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NutrientesToolStripMenuItem.Click
        Abrir(My.Forms.FrmNutrientes)
    End Sub

    Private Sub PreparaciónDeFormulasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreparaciónDeFormulasToolStripMenuItem1.Click
        Abrir(CatAlmRegPreparacionMezcla)
    End Sub

    Private Sub CarteraPorTipoProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CarteraPorTipoProductoToolStripMenuItem.Click
        Abrir(My.Forms._692ReporteDeCarteraPorTipodeProducto)
    End Sub

    Private Sub CarteraPorVendedorToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CarteraPorVendedorToolStripMenuItem.Click
        Abrir(My.Forms._692ReportedeCarteraPorvendedor)
    End Sub

    Private Sub FacturasGeneralesPorClientesCargoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturasGeneralesPorClientesCargoToolStripMenuItem.Click
        Abrir(My.Forms.frmReporteFacturaporClienteCargo)
    End Sub

    Private Sub ActualizacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizacionToolStripMenuItem.Click
        Abrir(My.Forms.FrmActFechaCortes)
    End Sub

    Private Sub RelacionProductosRastrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelacionProductosRastrosToolStripMenuItem.Click
        Abrir(My.Forms.frmProductosRastro)
    End Sub

    Private Sub AgrupadoresParaEstadosFinancierosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgrupadoresParaEstadosFinancierosToolStripMenuItem.Click
        Abrir(frmAgrupadorBalanceGeneral)
    End Sub

    Private Sub BalanceGeneralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BalanceGeneralToolStripMenuItem.Click
        Abrir(frmBalanceGeneral)
    End Sub

    Private Sub EsatdoDeResultadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EsatdoDeResultadosToolStripMenuItem.Click
        Abrir(frmEstadodeResultados)
    End Sub

    Private Sub ReporteDeDiariosDePólizasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeDiariosDePólizasToolStripMenuItem.Click
        Abrir(My.Forms.FrmRptDiariosPolizas)
    End Sub

    Private Sub ReporteDeEmisiónDePólizasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeEmisiónDePólizasToolStripMenuItem.Click
        Abrir(My.Forms.FrmRptEmisionPolizas)
    End Sub

    Private Sub ReporteVerificadorDePólizasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteVerificadorDePólizasToolStripMenuItem.Click
        Abrir(frmRptVerificadorDePolizas)
    End Sub

    Private Sub AuxiliarDeCuentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AuxiliarDeCuentasToolStripMenuItem.Click
        Abrir(frmRptAuxiliarCuentas)
    End Sub

    Private Sub AsignarPermisosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsignarPermisosToolStripMenuItem.Click
        Abrir(My.Forms.frmAsignarPermiso)
    End Sub

    Private Sub MayorGeneralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MayorGeneralToolStripMenuItem.Click
        Abrir(frmRptMayorGeneral)
    End Sub

    Private Sub SalidaDeMaterialesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalidaDeMaterialesToolStripMenuItem.Click
        Abrir(CatAlmRegSalAlmConsumo)
    End Sub

    Private Sub OtrasSalidasDeAlmacénToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtrasSalidasDeAlmacénToolStripMenuItem1.Click
        Abrir(CatAlmRegOtraSalidaAlmacen)
    End Sub

    Private Sub OtrasEntradasDeAlmacénToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtrasEntradasDeAlmacénToolStripMenuItem1.Click
        Abrir(CatAlmRegOtraEntradaAlmacen)
    End Sub

    Private Sub InventarioValorizadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventarioValorizadoToolStripMenuItem.Click
        Abrir(rptInventarioValorizado)
    End Sub

    Private Sub BalanzaDeComprobaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BalanzaDeComprobaciónToolStripMenuItem.Click
        Abrir(frmRptBalanzaDeComprobacion)
    End Sub

    Private Sub RelacionesAnalitícasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Abrir(frmRptRelacionesAnaliticas)
    End Sub

    Private Sub ARastroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ARastroToolStripMenuItem.Click
        Abrir(frmSalidasRecibaRastro)
    End Sub

    Private Sub PorVentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorVentaToolStripMenuItem.Click
        Abrir(frmSalidasRecibaVenta)
    End Sub

    Private Sub PorMuerteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorMuerteToolStripMenuItem.Click
        Abrir(frmSalidasRecibaMuerte)
    End Sub

    Private Sub MovimientosDeAlmacénToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovimientosDeAlmacénToolStripMenuItem1.Click
        Abrir(My.Forms.frmReporteMovimeintoAlmacenGeneral)
    End Sub

    Private Sub TrabajoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrabajoToolStripMenuItem.Click
        Abrir(My.Forms.frmMedicamentosDeTrabajo)
    End Sub

    Private Sub ReimplanteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReimplanteToolStripMenuItem.Click
        Abrir(My.Forms.frmMedicamentosDeReimplante)
    End Sub

    Private Sub MermasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MermasToolStripMenuItem.Click
        Abrir(FrmRptMermas)
    End Sub

    Private Sub DeTransferenciasRecepcionLotesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeTransferenciasRecepcionLotesToolStripMenuItem.Click
        Abrir(FrmRptTranferenciasRecibaLotesEngorda)
    End Sub

    Private Sub AplicacionDeMedicamentosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AplicacionDeMedicamentosToolStripMenuItem.Click
        Abrir(My.Forms.frmAplicacionMedicamento)
    End Sub

    Private Sub ProToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProToolStripMenuItem.Click
        Abrir(My.Forms.frmProrrateoMedicamento)
    End Sub

    Private Sub SalidaDeMedicamentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalidaDeMedicamentoToolStripMenuItem.Click
        Abrir(My.Forms.frmSalidasDeMedicamento)
    End Sub

    Private Sub CargaPorInicioDeSistemaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargaPorInicioDeSistemaToolStripMenuItem.Click
        Abrir(My.Forms.ModInvCargaInicialForm)
    End Sub

    Private Sub DeTransferenciasDeRecepcionTotalizadoPorLotesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeTransferenciasDeRecepcionTotalizadoPorLotesToolStripMenuItem.Click
        Abrir(FrmRptTranferenciasRecibaLotesTotalizado)
    End Sub

    Private Sub DeSalidasDeCorralDeRecepcionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeSalidasDeCorralDeRecepcionToolStripMenuItem.Click
        Abrir(FrmRptSalidasReciba)
    End Sub

    Private Sub ReimplanteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReimplanteToolStripMenuItem1.Click
        Abrir(My.Forms.frmReporteMedicamentosReimplante)
    End Sub

    Private Sub TrabajoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrabajoToolStripMenuItem1.Click
        Abrir(My.Forms.frmReporteMedicamentosTrabajo)
    End Sub

    Private Sub ProrrateosDeCostosPorCierreDeRecibaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProrrateosDeCostosPorCierreDeRecibaToolStripMenuItem.Click
        Abrir(FrmRptProCostoCierreReciba)
    End Sub

    Private Sub ARastroToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ARastroToolStripMenuItem2.Click
        Abrir(frmSalidasEngordaRastro)
    End Sub

    Private Sub AVentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AVentaToolStripMenuItem.Click
        Abrir(frmSalidasEngordaVenta)
    End Sub

    Private Sub PorMuerteToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorMuerteToolStripMenuItem2.Click
        Abrir(frmSalidasEngordaMuerte)
    End Sub

    Private Sub CostosDeFormulasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CostosDeFormulasToolStripMenuItem.Click
        Abrir(My.Forms.frmReporteCostosDeFormulas)
    End Sub

    Private Sub SalidasACorralesDeEngordaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalidasACorralesDeEngordaToolStripMenuItem.Click
        Abrir(My.Forms.frmReportSalidaMedicamentoCorralesEngorda)
    End Sub

    Private Sub ComparativoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComparativoToolStripMenuItem.Click
        Abrir(My.Forms.frmReporteComparativoMedicamento)
    End Sub

    Private Sub PorTransferenciaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorTransferenciaToolStripMenuItem.Click
        Abrir(frmSalidasCorralTraspaso)
    End Sub

    Private Sub ToolStripMenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem22.Click
        Abrir(My.Forms.frmReporteAplicacionMedicamentosPorLote)
    End Sub

    Private Sub ToolStripMenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem11.Click
        Abrir(frmCapturaInventarioProd)
    End Sub

    Private Sub RegistroDeToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroDeToolStripMenuItem2.Click
        Abrir(FrmBanCargosDiversos)
    End Sub

    Private Sub CancelacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelacionToolStripMenuItem.Click
        Abrir(CancelacionCargosDiversosForm)
    End Sub

    Private Sub RegistroDeToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroDeToolStripMenuItem3.Click
        Abrir(FrmBanAbonosDiversos)
    End Sub

    Private Sub CancelaciónToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelaciónToolStripMenuItem2.Click
        Abrir(CancelacionAbonosDiversosForm)
    End Sub

    Private Sub RegistroDeToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroDeToolStripMenuItem4.Click
        Abrir(FrmBanTraspasos)
    End Sub

    Private Sub CancelaciónToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelaciónToolStripMenuItem3.Click
        Abrir(CancelacionTraspasosForm)
    End Sub

    Private Sub FrmConciliacionBancariaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrmConciliacionBancariaToolStripMenuItem.Click
        Abrir(FrmConciliacionBancaria)
    End Sub

    Private Sub ConsultaSaldosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaSaldosToolStripMenuItem.Click
        Abrir(FrmBanConsultasdeSaldos)
    End Sub

    Private Sub CapturaDeMovimientosDeEstadoDeCuentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CapturaDeMovimientosDeEstadoDeCuentaToolStripMenuItem.Click
        Abrir(FrmMovimientosEstadoCuenta)
    End Sub

    Private Sub DiarioDeBancosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiarioDeBancosToolStripMenuItem.Click
        Abrir(FrmBanDiarioMovimientos)
    End Sub

    Private Sub ConciliaciónBancariaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConciliaciónBancariaToolStripMenuItem.Click
        Abrir(FrmBanConciliacionBancaria)
    End Sub

    Private Sub MovimientosDeConciliaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovimientosDeConciliaciónToolStripMenuItem.Click
        Abrir(FrmBanMovimientosdeConciliacion)
    End Sub

    Private Sub AnalisisDiarioDeBancosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnalisisDiarioDeBancosToolStripMenuItem.Click
        Abrir(FrmBanAnalisisDiarios)
    End Sub

    Private Sub ChequesPorBeneficiarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChequesPorBeneficiarioToolStripMenuItem.Click
        Abrir(FrmBanReporteChequesBeneficiarios)
    End Sub

    Private Sub SaldosPromediosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaldosPromediosToolStripMenuItem.Click
        Abrir(FrmSaldosPromedios)
    End Sub

    Private Sub CierreDiarioDeBancosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Abrir(FrmBanCierreDiario)
    End Sub

    Private Sub RegistroDeToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroDeToolStripMenuItem5.Click
        Abrir(frmRegistroChequesDevueltos)
    End Sub

    Private Sub RegistroDePagosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroDePagosToolStripMenuItem.Click
        Abrir(frmRegistroPagosChequesDevueltos)
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
        Abrir(New DetallesMenuForm(Me, "MEAT"))
    End Sub

    Private Sub CorralesDeEngordaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CorralesDeEngordaToolStripMenuItem.Click
        Abrir(FrmReporteDeExistenciasYCostosLotes)
    End Sub

    Private Sub CorralesDeRecepcionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CorralesDeRecepcionToolStripMenuItem.Click
        Abrir(FrmReporteDeExistenciasYCostosReciba)
    End Sub

    Private Sub DeVentaEnRecibaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeVentaEnRecibaToolStripMenuItem.Click
        Abrir(frmFacturacionVentaReciba)
    End Sub

    Private Sub DeMuerteEnRecibaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeMuerteEnRecibaToolStripMenuItem.Click
        Abrir(frmFacturaciondeMuerteEnReciba)
    End Sub

    Private Sub DeVentaEnCorralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeVentaEnCorralToolStripMenuItem.Click
        Abrir(frmFacturacionVentaCorral)
    End Sub

    Private Sub DeMuerteEnCorralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeMuerteEnCorralToolStripMenuItem.Click
        Abrir(frmFacturaciondeMuerteenCorral)
    End Sub

    Private Sub FacturacionDeProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturacionDeProductosToolStripMenuItem.Click
        Abrir(frmFacturacionProductos)
    End Sub

    Private Sub FacturacionEspecialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturacionEspecialToolStripMenuItem.Click
        Abrir(frmFacturacionEspecial)
    End Sub

    Private Sub ChequesDevueltosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChequesDevueltosToolStripMenuItem.Click
        Abrir(frmBusquedaChequesDevueltos)
    End Sub

    Private Sub PagosDeChequesDevueltosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagosDeChequesDevueltosToolStripMenuItem.Click
        Abrir(frmBusquedaPagosCheDev)
    End Sub

    Private Sub DiarioDeCorralesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiarioDeCorralesToolStripMenuItem.Click
        Abrir(FrmReporteDiarioDeCorrales)
    End Sub

    Private Sub SalidasProgramadasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalidasProgramadasToolStripMenuItem.Click
        Abrir(FrmReporteSalidasProgramadas)
    End Sub

    Private Sub SalidasProgramadasPorSemanaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalidasProgramadasPorSemanaToolStripMenuItem.Click
        Abrir(FrmReporteSalidasProgramadasxSem)
    End Sub

    Private Sub SalidasDeCorralesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalidasDeCorralesToolStripMenuItem.Click
        Abrir(FrmRptSalidasEngorda)
    End Sub

    Private Sub LotesCerradosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LotesCerradosToolStripMenuItem.Click
        Abrir(FrmReporteLotesCerrados)
    End Sub

    Private Sub MovimientosPorLoteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovimientosPorLoteToolStripMenuItem.Click
        Abrir(FrmReporteMovimientosPorLotes)
    End Sub

    Private Sub ReImplantesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReImplantesToolStripMenuItem.Click
        Abrir(FrmReporteReimplantes)
    End Sub

    Private Sub AnalisisDeLotesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnalisisDeLotesToolStripMenuItem.Click
        Abrir(FrmReporteAnalisisLotes)
    End Sub

    Private Sub ServidasPorFechaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServidasPorFechaToolStripMenuItem.Click
        Abrir(FrmReporteServidasxFecha)
    End Sub

    Private Sub AlimentosServidosEnCorralesPorCabezaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlimentosServidosEnCorralesPorCabezaToolStripMenuItem.Click
        Abrir(FrmReporteAlimentosServCorrales)
    End Sub

    Private Sub FaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FaToolStripMenuItem.Click
        Abrir(frmAuxiliarPolizaFacturaRecibaaVenta)
    End Sub

    Private Sub ProducciónSugeridoDelDíaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProducciónSugeridoDelDíaToolStripMenuItem.Click
        Abrir(FrmRptProdAlimSugDia)
    End Sub

    Private Sub FacturacionDeRecibaDeVentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturacionDeRecibaDeVentaToolStripMenuItem.Click
        Abrir(frmPolizaFacturaRecibaVenta)
    End Sub
    Private Sub FacturacionDeRecibaAMuerteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturacionDeRecibaAMuerteToolStripMenuItem.Click
        Abrir(frmPolizaFacturaRecibaaMuerte)
    End Sub
    Private Sub FacturacionDeCorralAVentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturacionDeCorralAVentaToolStripMenuItem.Click
        Abrir(frmPolizaFacturaCorralVenta)
    End Sub
    Private Sub FacturacionDeCorralAMuerteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturacionDeCorralAMuerteToolStripMenuItem.Click
        Abrir(frmPolizaFacturaCorralaMuerte)
    End Sub

    Private Sub ProgramacionDeFormulasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramacionDeFormulasToolStripMenuItem.Click
        Abrir(frmProgramacionFormulas)
    End Sub

    Private Sub DePólizaDeFacturaciónDeMuerteEnRecibaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DePólizaDeFacturaciónDeMuerteEnRecibaToolStripMenuItem.Click
        Abrir(frmAuxiliarPolizaFacturaRecibaaMuerte)
    End Sub

    Private Sub DePólizaDeFacturaciónDeVentaEnCorralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DePólizaDeFacturaciónDeVentaEnCorralToolStripMenuItem.Click
        Abrir(FrmAuxiliarPolizaFacturaCorralaVenta)
    End Sub

    Private Sub DePólizaDeFacturaciónDeMuerteEnCorralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DePólizaDeFacturaciónDeMuerteEnCorralToolStripMenuItem.Click
        Abrir(FrmAuxiliarPolizaFacturaCorralaMuerte)
    End Sub

    Private Sub EmbarquesPorDestinosClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmbarquesPorDestinosClienteToolStripMenuItem.Click
        Abrir(FrmReporteEmbarquesxDestinosyCliente)
    End Sub

    Private Sub ReporteDeMarbetesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeMarbetesToolStripMenuItem.Click
        Abrir(rptReporteDeMarbetes)
    End Sub

    Private Sub ComparativoDeAlimentosProducidosVsSurtidosEnCorralesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComparativoDeAlimentosProducidosVsSurtidosEnCorralesToolStripMenuItem.Click
        Abrir(FrmRptComAlimProdvsSur)
    End Sub

    Private Sub ProcesoDePagosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcesoDePagosToolStripMenuItem.Click
        Abrir(PagosaProveedoresForm)
    End Sub

    Private Sub CancelaciónDePagosToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelaciónDePagosToolStripMenuItem2.Click
        Abrir(CancelacionPagoAProveedoresForm)
    End Sub

    Private Sub TiposDeMonedaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TiposDeMonedaToolStripMenuItem.Click
        Abrir(BcoCatTipoMoneda)
    End Sub

    Private Sub TipoCambioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoCambioToolStripMenuItem.Click
        Abrir(TipoCambioForm)
    End Sub

    Private Sub HistorialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistorialToolStripMenuItem.Click
        Abrir(HistorialTipoCambio)
    End Sub

    Private Sub DePólizaDeFacturaciónDeProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DePólizaDeFacturaciónDeProductosToolStripMenuItem.Click
        Abrir(frmAuxiliarPolizaFacturadeProductos)
    End Sub

    Private Sub FacturacionDeProductosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturacionDeProductosToolStripMenuItem1.Click
        Abrir(frmPolizaFacturaProductos)
    End Sub

    Private Sub ConfiguracionToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguracionToolStripMenuItem2.Click
        Abrir(My.Forms.frmConfiguracionEngorda)
    End Sub

    Private Sub ConfiguraciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguraciónToolStripMenuItem.Click
        Abrir(FrmConfigProduccion)
    End Sub

    Private Sub ConfiguraciónDeFacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguraciónDeFacturasToolStripMenuItem.Click
        Abrir(FrmConfigurarFactura)
    End Sub

    Private Sub ConfiguraciónToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguraciónToolStripMenuItem2.Click
        Abrir(FrmConfigContabilidad)
    End Sub

    Private Sub ConfiguraciónToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguraciónToolStripMenuItem3.Click
        Abrir(ConfiguracionChequeForm)
    End Sub

    Private Sub ConfiguraciónDeImpresiónDeChequesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguraciónDeImpresiónDeChequesToolStripMenuItem1.Click
        Abrir(FrmConfigImpresionCheque)
    End Sub

    Private Sub ConfiguracionDeDocumentosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguracionDeDocumentosToolStripMenuItem.Click
        Abrir(frmConfiguracionDocumento)
    End Sub

    Private Sub SeleccionarPeriodoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeleccionarPeriodoToolStripMenuItem.Click
        Abrir(frmSeleccionarPeriodo)
    End Sub

    Private Sub TraspasoDeCuentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TraspasoDeCuentasToolStripMenuItem.Click
        Abrir(frmTraspasodeCuentas)
    End Sub

    Private Sub FoliosDeFacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FoliosDeFacturasToolStripMenuItem.Click
        Abrir(frmFoliosFacturas)
    End Sub

    Private Sub RecepciónDeOrdenesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecepciónDeOrdenesToolStripMenuItem1.Click
        Abrir(ComRecepcionOrdenServicio)
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

    Private Sub RecepciónDeCanalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecepciónDeCanalesToolStripMenuItem.Click
        Try
            Abrir(FrmRecepcionCanales)
        Catch ex As InvalidOperationException
            Utilerias.RegistrarTalbcActiveX()
            Abrir(FrmRecepcionCanales)
        End Try
    End Sub

    Private Sub CapturaDeCortesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CapturaDeCortesToolStripMenuItem.Click
        Try
            Abrir(FrmCapturadeCortes)
        Catch ex As InvalidOperationException
            Utilerias.RegistrarTalbcActiveX()
            Abrir(FrmCapturadeCortes)
        End Try
    End Sub

#End Region

    Private Sub TraspasosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TraspasosToolStripMenuItem.Click

    End Sub

    Private Sub InventarioFisicoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InventarioFisicoToolStripMenuItem.Click

    End Sub

    Private Sub SustituciónDeInventarioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SustituciónDeInventarioToolStripMenuItem.Click

    End Sub

    Private Sub PresupuestosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PresupuestosToolStripMenuItem.Click

    End Sub

    Private Sub TiposDeClientesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TiposDeClientesToolStripMenuItem.Click
        Abrir(FrmTipoclientes)
    End Sub

    Private Sub Conexiontsmi_Click(sender As System.Object, e As System.EventArgs) Handles Conexiontsmi.Click
        Abrir(New IntegraLab.FactDigital.Configuracion.frmConfiguracionConexion())
    End Sub

    Private Sub ParametrosYSellostsmi_Click(sender As System.Object, e As System.EventArgs) Handles ParametrosYSellostsmi.Click
        Try

            Dim ConStr As String = Integralab.FactDigital.ControladorFactDigital.Decrypt(System.IO.File.ReadAllText(Application.StartupPath + "\\cx.dat"))
            Dim ctrlFact As New IntegraLab.FactDigital.ControladorFactDigital(Controlador.Empresa.Index, ConStr)
            Abrir(New IntegraLab.FactDigital.Configuracion.frmConfiguracionDigital(ctrlFact))
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString() & " Favor de configurar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub AperturaDeLoteDeCortes2ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AperturaDeLoteDeCortes2ToolStripMenuItem.Click
        Abrir(FrmAperturaLoteCorte2)
    End Sub


    Private Sub CapturaDeProductoTerminadoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CapturaDeProductoTerminadoToolStripMenuItem.Click
        Abrir(FrmCapturaProdTerminado)
    End Sub

    Private Sub ProgramaciónDePagosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Abrir(AutorizaPagosForm)
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Abrir(GeneraArchivoFacturasForm)
    End Sub

    Private Sub ProgramaciónDePagosToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles ProgramaciónDePagosToolStripMenuItem.Click
        Abrir(AutorizaPagosForm)
    End Sub

    Private Sub ReporteDeDepartamentosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReporteDeDepartamentosToolStripMenuItem.Click
        Abrir(frmRptdepartamentos)
    End Sub

    Private Sub DepartartamentosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DepartartamentosToolStripMenuItem.Click
        Abrir(frmRptDepartamentosDos)
    End Sub

    Private Sub CierresContablesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CierresContablesToolStripMenuItem.Click
        Abrir(frmCierreContableAnual)
    End Sub

    Private Sub CancelaciónDeCierresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelaciónDeCierresToolStripMenuItem.Click
        Abrir(frmCancelaciondeCierre)
    End Sub

    Private Sub RendimientosporFechaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RendimientosporFechaToolStripMenuItem.Click
        Abrir(FrmReporteCanal_CortePorFecha)
    End Sub

    Private Sub InventarioValorizadoToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles InventarioValorizadoToolStripMenuItem1.Click
        Abrir(frmpinventariovalorizado)
    End Sub

    Private Sub EstadoDeCuentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstadoDeCuentasToolStripMenuItem.Click
        Abrir(frmEstadoCuentasProvedores)
    End Sub
End Class