Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports TV = Integralab.ORM.TypedViewClasses
Imports SP = Integralab.ORM.StoredProcedureCallerClasses

Imports ECS = Integralab.ORMSeguridad.EntityClasses
Imports CCS = Integralab.ORMSeguridad.CollectionClasses
Imports HCS = Integralab.ORMSeguridad.HelperClasses

Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports AlmacenGeneral
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Integralab.Seguridad.Classes
Imports System.ComponentModel
Imports ClasesNegocio.AlmacenGeneral

#Region "Definiciones"

Public Structure Ejercicio
    Dim Ejercicio As Short
    Dim PolizaCierre As String
    Dim PolizaTraspaso As String
    Dim FechaCierre As DateTime
    Dim Estatus As Short

End Structure

Public Class RangoFechas

#Region "Miembros"
    Dim _FechaInicial As Nullable(Of Date)
    Dim _FechaFinal As Nullable(Of Date)
#End Region

#Region "Constructores"
    Sub New(ByVal FechaInicial As Nullable(Of Date), ByVal FechaFinal As Nullable(Of Date))
        _FechaInicial = FechaInicial
        _FechaFinal = FechaFinal
    End Sub
#End Region

#Region "Propiedades"
    Public ReadOnly Property FechaInicial() As Nullable(Of Date)
        Get
            Return _FechaInicial
        End Get
    End Property

    Public ReadOnly Property FechaFinal() As Nullable(Of Date)
        Get
            Return _FechaFinal
        End Get
    End Property
#End Region

End Class

Public Class ConfiguracionClass

#Region "Definiciones"

    Private _Produccion As ConfiguracionProduccionClass
    Private _Engorda As ConfiguracionEngordaClass
    Private _Venta As ConfiguracionFacturaCollectionClass
    Private _SeleccionConfiguracionFactura As ConfiguracionFacturaClass
    Private _Inventario As ConfiguracionMovimientoAlmacenGeneralClass
    Private _TiposMovimientos As TipoMovimientoAlmacenCollectionClass
    Private _FacturaFolios As FacturaFoliosClass

#End Region

#Region "Constructores"

    

    Sub New()
        Dim Trans As HC.Transaction = Nothing
        Dim Cambios As Boolean

        ActualizarProduccion()
        ActualizarEngorda()

        If _Engorda.Entidad.IsNew Then
            If Trans Is Nothing Then
                Trans = New HC.Transaction(IsolationLevel.ReadCommitted, "Configuracion")
            End If
            _Engorda.Entidad.IdConfiguracion = 1
            _Engorda.Guardar(Trans)
            Cambios = True
        End If
        ActualizarVenta()
        ActualizarInventario()

        If _Inventario.ObtenerEntidad.IsNew Then
            Dim Inv As EC.InventarioConfiguracionEntity = _Inventario.ObtenerEntidad

            If Trans Is Nothing Then
                Trans = New HC.Transaction(IsolationLevel.ReadCommitted, "Configuracion")
            End If
            Inv = New EC.InventarioConfiguracionEntity
            Trans.Add(Inv)
            Inv.Ndx = 1
            Inv.Save()
            Cambios = True
        End If

        If Cambios Then
            Trans.Commit()
        End If

        _FacturaFolios = New FacturaFoliosClass(1)

        If _FacturaFolios.Entidad.IsNew Then
            _FacturaFolios = New FacturaFoliosClass()
            _FacturaFolios.IdFacturaFolios = 1
            _FacturaFolios.FolioInicial = 1
            _FacturaFolios.Consecutivo = 1
            _FacturaFolios.NumFolios = 0
            _FacturaFolios.StaLetraSerie = ""
            _FacturaFolios.NoAprobacion = 0
            _FacturaFolios.AnoAprobacion = 0
        End If
    End Sub

#End Region

#Region "Propiedades"

    Public ReadOnly Property Produccion() As ConfiguracionProduccionClass
        Get
            Return _Produccion
        End Get
    End Property

    Public ReadOnly Property Engorda() As ConfiguracionEngordaClass
        Get
            Return _Engorda
        End Get
    End Property

    Public ReadOnly Property Venta() As ConfiguracionFacturaCollectionClass
        Get
            Return _Venta
        End Get
    End Property

    Public ReadOnly Property Inventario() As ConfiguracionMovimientoAlmacenGeneralClass
        Get
            Return _Inventario
        End Get
    End Property

    Public ReadOnly Property FacturaFolios() As FacturaFoliosClass
        Get
            Return _FacturaFolios
        End Get
    End Property


    

#End Region

#Region "Metodos"

    Public Function SeleccionarConfiguracionFactura(ByVal IdConfiguracionFactura As Integer) As ConfiguracionFacturaClass
        For Each Configuracion As ConfiguracionFacturaClass In Me.Venta
            If Configuracion.IdConfiguracion = IdConfiguracionFactura Then
                _SeleccionConfiguracionFactura = Configuracion
                Exit For
            End If
        Next
        Return _SeleccionConfiguracionFactura
    End Function

    Public Function SeleccionActualConfiguracionFactura() As ConfiguracionFacturaClass
        Return _SeleccionConfiguracionFactura
    End Function

    Public Sub ActualizarVenta()
        If _Venta IsNot Nothing Then
            _Venta.Dispose()
        End If
        _Venta = New ConfiguracionFacturaCollectionClass
        _Venta.Obtener()
    End Sub

    Public Sub ActualizarProduccion()
        _Produccion = New ConfiguracionProduccionClass(1)
    End Sub

    Public Sub ActualizarEngorda()
        _Engorda = New ConfiguracionEngordaClass(1)
    End Sub

    Public Sub ActualizarInventario()
        _TiposMovimientos = New TipoMovimientoAlmacenCollectionClass()
        _TiposMovimientos.Obtener(CondicionEnum.ACTIVOS)
        _Inventario = New ConfiguracionMovimientoAlmacenGeneralClass(1, _TiposMovimientos)
    End Sub

    Public Sub ActualizarFacturaFolios(ByVal CodFoliofactura As Integer)
        _FacturaFolios = New FacturaFoliosClass(CodFoliofactura)
    End Sub

#End Region

End Class

#End Region

Partial Public Class ControladorGanadera

#Region "Miembros"

    Private _Sesion As ECS.SesionesEntity
    Private _EjercicioContable As Ejercicio
    Private _Culture As Globalization.CultureInfo
    Private _Configuracion As ConfiguracionClass
    Private _Seguridad As Seguridad
    Private _Empresa As EmpresaClass
    Dim Permiso As Boolean = False

    Public Shared Function ObtenerVtaSinExistencia() As Boolean
        Dim strSql As String = "SELECT VenderSinExistencia FROM ConfigPuntoVta"
        Dim dtb As New DataSet
        Using cnn As New SqlConnection(HC.DbUtils.ActualConnectionString)
            cnn.Open()
            Using dad As New SqlDataAdapter(strSql, cnn)
                dad.Fill(dtb)
            End Using
            cnn.Close()
        End Using

        Return CBool(dtb.Tables(0).Rows(0)(0))

    End Function

    Public Shared Function ValidarCierreDiario() As Boolean
        Dim sqlAdapter As New SqlClient.SqlDataAdapter("Select CortePorDia From dbo.ConfigPuntoVta", HC.DbUtils.ActualConnectionString)
        Dim dsDatos As New DataSet
        Try
            sqlAdapter.Fill(dsDatos)
            Return CBool(dsDatos.Tables(0).Rows(0)(0))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Return False
        End Try
    End Function

    Enum ReporteMermasAgrupacion As Byte
        Fecha
        Proveedor
        Comprador
        Lugar_de_Compra
        Chofer
    End Enum

    Enum ReporteSalidaOrigen As Byte
        Recepcion
        Engorda
    End Enum

    Enum ReporteSalidasReciba As Byte
        Todos
        Rastro
        Venta
        Muerte
    End Enum

    Enum ReporteSalidasEngorda As Byte
        Todos
        Rastro
        Venta
        Muerte
        Transferencia
    End Enum

    Enum ReporteSalidasOrden As Byte
        Fecha
        CorralRecepcion
        CausaMuerte
    End Enum

    Enum ImpresionDatosDeLote As Byte
        Resumen
        Detalle
        Movimientos
    End Enum

#End Region

#Region "Constructores"

    Sub New()
        _Culture = New Globalization.CultureInfo("es-mx")
        My.Resources.Culture = _Culture
        Application.CurrentCulture = _Culture
        _Seguridad = New Seguridad("MEAT")
        HCS.DbUtils.ActualConnectionString = _Seguridad.SeguridadConnectionString
        _Sesion = New ECS.SesionesEntity
        _Sesion.Sesfecini = Now
        _Sesion.Usrndx = -1
        _Sesion.Empndx = -1
        _Sesion.MiUsuario = New ECS.UsuarioEntity()
        _Sesion.MiEmpresa = New ECS.EmpresasEntity()
    End Sub

#End Region

#Region "Propiedades"

    Public Property Sesion() As ECS.SesionesEntity
        Get
            Return _Sesion
        End Get
        Set(ByVal value As ECS.SesionesEntity)
            _Sesion = value
        End Set
    End Property

    Public ReadOnly Property ConPermisos() As Boolean
        Get
            Return Permiso
        End Get
    End Property

    Public ReadOnly Property fechaServidor() As Date
        Get
            Dim resultado As New DataSet
            Dim consulta As String = "select getdate()"
            Using ad As New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(consulta, _
                        New SqlClient.SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString)))
                ad.SelectCommand.Connection.Open()
                ad.Fill(resultado)
                ad.SelectCommand.Connection.Close()
            End Using
            Return CDate(resultado.Tables(0).Rows(0).Item(0))
        End Get
    End Property

    Public Property EjercicioContable() As Ejercicio
        Get
            Return _EjercicioContable
        End Get
        Set(ByVal value As Ejercicio)
            _EjercicioContable = value
        End Set
    End Property

    Public ReadOnly Property Culture() As Globalization.CultureInfo
        Get
            Return _Culture
        End Get
    End Property

    Public ReadOnly Property Configuracion() As ConfiguracionClass
        Get
            If _Configuracion Is Nothing Then
                _Configuracion = New ConfiguracionClass()
            End If
            Return _Configuracion
        End Get
    End Property

    Public ReadOnly Property Seguridad() As Seguridad
        Get
            Return _Seguridad
        End Get
    End Property

    Public ReadOnly Property Empresa() As EmpresaClass
        Get
            If _Empresa Is Nothing OrElse _Empresa.Codigo <> _Sesion.MiEmpresa.Empid Then
                _Empresa = New EmpresaClass(_Sesion.MiEmpresa.Empndx)
            End If
            Return _Empresa
        End Get
    End Property

#End Region

#Region "Metodos Dinamicos"

    Public Sub ActualizarMenu(ByVal MenuPrincipal As Windows.Forms.MenuStrip, ByVal Aplication As String)
        Dim trans As New HCS.Transaction(IsolationLevel.ReadCommitted, "Menus")
        Dim Menus As New MenuCollectionClass

        If Aplication = Nothing Or Aplication = String.Empty Then
            Aplication = Application.ProductName
        End If

        Menus.LeerMenuStrip(MenuPrincipal, Aplication)
        GuardarMenu(Aplication, Menus, Nothing, trans)

        'Dim grupos As New Integralab.ORMSeguridad.CollectionClasses.DetallegruposCollection
        'Dim Filtro As New OC.PredicateExpression(HCS.DetallegruposFields.Usrndx = Me.Sesion.MiUsuario.Usrndx)
        'grupos.GetMulti(Filtro)
        'For i As Integer = 0 To grupos.Count - 1
        '    Dim menusGrupo As Integralab.ORMSeguridad.CollectionClasses.DetallemenusgruposCollection
        '    menusGrupo.GetMulti(New OC.PredicateExpression(HCS.DetallemenusgruposFields.Gpondx = grupos(i).Gpondx))
        '    Dim menuC As New CCS.MenusCollection
        '    For j As Integer = 0 To menusGrupo.Count - 1
        '        menuC.GetMulti(HCS.MenusFields.Mnundx = menusGrupo(j).Mnundx)
        '    Next
        '    GuardarMenu(Aplication, menuC, Nothing, trans)


        'Next


        trans.Commit()
        'HCS.Transaction trans = new HCS.Transaction(IsolationLevel.ReadCommitted, "Menus");
        '    MenuCollectionClass Menus = new MenuCollectionClass();

        '    if (Aplicacion == null || Aplicacion == String.Empty)
        '    {
        '        Aplicacion = Application.ProductName;  // Controlador.Sesion.MiEmpresa.Empnom;
        '    }
        '    Menus.LeerMenuStrip(MenuPrincipal);
        '    GuardarMenu(Aplicacion, Menus, null, trans);
        '    trans.Commit();
    End Sub

    Private Sub GuardarMenu(ByVal Aplicacion As String, ByRef menus As MenuCollectionClass, ByRef padre As ECS.MenusEntity, ByRef trans As HCS.Transaction)
        For Each menu As MenuClass In menus
            Dim menuC As New CCS.MenusCollection
            Dim ent As ECS.MenusEntity

            trans.Add(menuC)
            menuC.GetMulti(HCS.MenusFields.Mnuid = menu.NombreCorto And HCS.MenusFields.Mnusol = menu.Solucion)

            If menuC.Count > 0 Then
                ent = menuC(0)
            Else
                ent = New ECS.MenusEntity
            End If

            trans.Add(ent)

            If padre IsNot Nothing Then
                ent.Mnupad = padre.Mnundx
            End If

            ent.Mnusol = Aplicacion
            ent.Mnunom = menu.Nombre
            ent.Mnuid = menu.NombreCorto
            ent.Mnuglo = menu.Obligatorio
            ent.Save()
            GuardarMenu(Aplicacion, menu.MisMenus, ent, trans)
        Next
    End Sub

    Public Sub RegistrarSolicitudCompra(ByRef Solicitud As SolicitudProductoClass, ByRef Trans As HC.Transaction)
        Solicitud.Validar()

        For i As Integer = Solicitud.Detalle.Count - 1 To 0 Step -1
            If Not Solicitud.Detalle(i).Entidad.IsDirty AndAlso Solicitud.Detalle(i).Entidad.IsNew Then
                Solicitud.Detalle.RemoveAt(i)
            End If
        Next

        If Solicitud.Entidad.IsNew Then
            Solicitud.IdUsuarioAlta = Me.Sesion.MiUsuario.Usrndx
            Solicitud.Estatus = SolicitudProductoClass.EstatusSolicitud.VIGENTE
            Solicitud.FechaCaptura = Now
        Else
            Dim DetalleAnterior As New CC.SolicitudProductoDetalleCollection

            Trans.Add(DetalleAnterior)
            DetalleAnterior.DeleteMulti(HC.SolicitudProductoDetalleFields.IdSolicitud = Solicitud.IdSolicitud)

            For i As Integer = 0 To Solicitud.Detalle.Count - 1
                With Solicitud.Detalle(i)
                    If Not .Entidad.IsNew Then
                        Solicitud.Detalle(i) = New SolicitudProductoDetalleClass(.IdProducto, .Cantidad, .Urgente, .Observaciones)
                    End If
                End With
            Next
        End If
        Solicitud.Guardar(Trans)
    End Sub

    Public Sub CancelarSolicitudCompra(ByVal Solicitud As SolicitudProductoClass, ByVal Trans As HC.Transaction)
        Solicitud.IdUsuarioCancelacion = Me.Sesion.MiUsuario.Usrndx
        Solicitud.ObservacionesCancelacion = "Registro de Solicitud de Productos"
        Solicitud.Borrar(Trans)
    End Sub

    Public Function ValidarLoteFormula(ByVal LoteFormula As LoteFormulaClass) As Boolean
        If LoteFormula.Formula.IsNew Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.PROGRAMACION_FORMULAS, 0)
        ElseIf LoteFormula.FecInicio = Date.MinValue Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.PROGRAMACION_FORMULAS, 1)
        ElseIf LoteFormula.FecFinal = Date.MinValue Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.PROGRAMACION_FORMULAS, 2)
        ElseIf LoteFormula.FecInicio.Ticks > LoteFormula.FecFinal.Ticks Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.PROGRAMACION_FORMULAS, 3)
        ElseIf LoteFormula.ConsxCabKil = 0D Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.PROGRAMACION_FORMULAS, 4)
        Else
            Dim TotPor As Decimal = 100D

            TotPor -= LoteFormula.PorServida1
            TotPor -= LoteFormula.PorServida2
            TotPor -= LoteFormula.PorServida3
            TotPor -= LoteFormula.PorServida4

            If TotPor <> 0D Then
                Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.PROGRAMACION_FORMULAS, 5)
            End If
        End If
        Return True
    End Function

    Public Sub GuardarProgramacion(ByRef Programacion As LoteFormulaCollectionClass, ByRef Trans As HC.Transaction)
        Dim ProgramacionAnterior As New CC.McecatLotesCabForCollection()
        Trans.Add(ProgramacionAnterior)
        ProgramacionAnterior.GetMulti(HC.McecatLotesCabForFields.IdLote = Programacion(0).IdLote)
        ProgramacionAnterior.DeleteMulti()

        For i As Integer = 0 To Programacion.Count - 1
            If Programacion(i).IsDirty OrElse Not Programacion(i).IsNew Then
                Me.ValidarLoteFormula(Programacion(i))
                Programacion(i).IsNew = True
                Programacion(i).IdRenglon = i + 1
                Programacion(i).DiasFormula = (Programacion(i).FecFinal.Ticks - Programacion(i).FecInicio.Ticks) / TimeSpan.TicksPerDay

                Dim LoteFormula As New LoteFormulaClass(CType(Programacion(i), EC.McecatLotesCabForEntity))
                Trans.Add(LoteFormula)
                LoteFormula.Save()
            End If
        Next
    End Sub

    Public Function RegistrarPagoChequeDevuelto(ByVal FechaPago As Date, ByVal IdBancoDeposito As Integer, ByVal Observaciones As String, ByVal Detalle As PagoCheDevueltoDetCollectionClass, ByRef Trans As HC.Transaction) As PagoCheDevueltoCabClass
        If Detalle Is Nothing OrElse Detalle.Count = 0 Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.PAGOS_CHEQUES_DEVUELTOS, 0)
        End If

        RegistrarPagoChequeDevuelto = New PagoCheDevueltoCabClass(FechaPago, 0D, 0D, IdBancoDeposito, Observaciones)
        Detalle.EstablecerCabecero(RegistrarPagoChequeDevuelto)
        RegistrarPagoChequeDevuelto.Saldo = 0D
        RegistrarPagoChequeDevuelto.Importe = 0D

        For Each DetallePago As PagoCheDevueltoDetClass In Detalle
            RegistrarPagoChequeDevuelto.Detalles.Add(DetallePago)
            RegistrarPagoChequeDevuelto.Saldo += DetallePago.Saldo
            RegistrarPagoChequeDevuelto.Importe += DetallePago.Importe

            If DetallePago.Saldo <= 0D Then
                DetallePago.ChequeDevuelto.Estatus = ChequeDevueltoClass.ChequeDevueltoEstatus.PAGADO
            Else
                DetallePago.ChequeDevuelto.Estatus = ChequeDevueltoClass.ChequeDevueltoEstatus.ABONADO
            End If
            Trans.Add(DetallePago.ChequeDevuelto)
            DetallePago.ChequeDevuelto.Save()
        Next
        RegistrarPagoChequeDevuelto.Guardar(Trans)
        Return RegistrarPagoChequeDevuelto
    End Function

    Public Sub CancelarPagoChequeDevuelto(ByRef Pago As PagoCheDevueltoCabClass, ByRef Trans As HC.Transaction)
        Pago.Cancelar(Trans)

        For Each DetallePago As PagoCheDevueltoDetClass In Pago.Detalles
            If DetallePago.Saldo + DetallePago.Importe <= DetallePago.ChequeDevuelto.Importe Then
                DetallePago.ChequeDevuelto.Estatus = ChequeDevueltoClass.ChequeDevueltoEstatus.VIGENTE
            Else
                DetallePago.ChequeDevuelto.Estatus = ChequeDevueltoClass.ChequeDevueltoEstatus.ABONADO
            End If
            Trans.Add(DetallePago.ChequeDevuelto)
            DetallePago.ChequeDevuelto.Save()
        Next
    End Sub

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

    Public Sub ChecarDerechos(ByVal MenuStrip As System.Windows.Forms.MenuStrip, ByVal Seguridad As Integer)
        Dim resultados As Boolean = False
        Try
            'checar privilegios de usuarios
            Dim Privilegios As New CCS.DetallemenususuariosCollection
            Dim MenuPrivilegios As New CCS.MenusCollection

            'sacar nombres de las funciones y menus del sistema

            OcutarMenus(MenuStrip.Items)

            Privilegios.GetMulti(HCS.DetallemenususuariosFields.Usrndx = Me.Sesion.MiUsuario.Usrndx And HCS.DetallemenususuariosFields.Empndx = Me.Sesion.MiEmpresa.Empndx)
            MenuPrivilegios.GetMulti(Nothing)

            If Seguridad = 1 Then
                'menus de seguridad
                MostrarMenuSeguridad(MenuStrip)
            Else
                Dim tipo As New ECS.DetalleempresasEntity(Me.Sesion.MiEmpresa.Empndx, Me.Sesion.MiUsuario.Usrndx)
                If Not IsDBNull(tipo.Usrtipo) And Not tipo.Usrtipo.Equals("") And Not tipo.Usrtipo.Equals("O") Then
                    For Each MenuPrivilegio As ECS.MenusEntity In MenuPrivilegios
                        ' If Privilegio.Mnundx = MenuPrivilegio.Mnundx Then
                        

                        HabilitarMenu(MenuPrivilegio.Mnuid, MenuStrip.Items)
                        Permiso = True
                        'resultados = True
                        'End If
                    Next
                Else
                    If Privilegios.Count > 0 Then
                        For Each Privilegio As ECS.DetallemenususuariosEntity In Privilegios
                            For Each MenuPrivilegio As ECS.MenusEntity In MenuPrivilegios
                                If Privilegio.Mnundx = MenuPrivilegio.Mnundx Then
                                    HabilitarMenu(MenuPrivilegio.Mnuid, MenuStrip.Items)
                                    resultados = True
                                    Permiso = True
                                End If
                            Next
                        Next
                        'Else
                        '    MessageBox.Show("Usuario no tiene derechos a ninguna función del sistema", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                    '            'GRUPOS
                    Dim grupos As New Integralab.ORMSeguridad.CollectionClasses.DetallegruposCollection
                    Dim Filtro As New OC.PredicateExpression(HCS.DetallegruposFields.Usrndx = Me.Sesion.MiUsuario.Usrndx)
                    grupos.GetMulti(Filtro)
                    If grupos.Count > 0 Then
                        For Each GruposPertenece As ECS.DetallegruposEntity In grupos
                            Dim menusGrupo As New Integralab.ORMSeguridad.CollectionClasses.DetallemenusgruposCollection
                            menusGrupo.GetMulti(New OC.PredicateExpression(HCS.DetallemenusgruposFields.Gpondx = GruposPertenece.Gpondx))
                            If menusGrupo.Count > 0 Then
                                For Each PrivilegioGrupo As ECS.DetallemenusgruposEntity In menusGrupo
                                    For Each MenuPrivilegio As ECS.MenusEntity In MenuPrivilegios
                                        If PrivilegioGrupo.Mnundx = MenuPrivilegio.Mnundx Then
                                            HabilitarMenu(MenuPrivilegio.Mnuid, MenuStrip.Items)
                                            resultados = True
                                            Permiso = True
                                        End If
                                    Next
                                Next

                            End If
                        Next

                    End If

                    If resultados = False Then
                        MessageBox.Show("Usuario no tiene derechos a ninguna función del sistema", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Me.Finalize()
                    End If
                End If
                
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Close()
        End Try
    End Sub

    Private Sub HabilitarMenu(ByRef IdMenu As String, ByVal Menus As ToolStripItemCollection)
        For Each Item As ToolStripItem In Menus
            If Item.Name = IdMenu AndAlso Item.GetType Is GetType(ToolStripMenuItem) Then
                If Item.Tag = Nothing Then Item.Tag = ""
                If Not Item.Tag.ToString().Contains("0") Then
                    Item.Visible = True
                    MostrarMenusPadres(Item.OwnerItem)
                    Exit For
                End If
            ElseIf Item.GetType Is GetType(ToolStripMenuItem) AndAlso CType(Item, ToolStripMenuItem).DropDownItems IsNot Nothing Then
                'If Not Item.Tag.ToString().Contains("I") Then
                HabilitarMenu(IdMenu, CType(Item, ToolStripMenuItem).DropDownItems)
                'End If
            End If
        Next
    End Sub

    ''' <summary>
    ''' Oculta todos los menus
    ''' </summary>
    ''' <remarks></remarks>


    Private Sub OcutarMenus(ByVal Menus As ToolStripItemCollection)
        'Ocultar menus principales e hijos
        If Menus IsNot Nothing And Menus.Count > 0 Then
            For Each Item As ToolStripItem In Menus
                If Item.GetType Is GetType(ToolStripMenuItem) Then
                    If Item.Tag = Nothing Then Item.Tag = ""
                    If Not Item.Tag.ToString().Contains("0") Then
                        Dim Menu As ToolStripMenuItem = CType(Item, ToolStripMenuItem)
                        Menu.Visible = False
                        OcutarMenus(Menu.DropDownItems)
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub MostrarMenuSeguridad(ByVal MenuStrip As System.Windows.Forms.MenuStrip)
        For Each Item As ToolStripItem In MenuStrip.Items.Find("Seguridad", False)
            If Item.GetType Is GetType(ToolStripMenuItem) Then
                Item.Visible = True

                For Each ItemHijo As ToolStripItem In CType(Item, ToolStripMenuItem).DropDownItems
                    ItemHijo.Visible = True

                    If ItemHijo.GetType Is GetType(ToolStripMenuItem) Then
                        For Each ItemHijoHijo As ToolStripItem In CType(ItemHijo, ToolStripMenuItem).DropDownItems
                            ItemHijoHijo.Visible = True
                        Next
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub MostrarMenusPadres(ByVal Padre As ToolStripItem)
        If Padre IsNot Nothing Then
            If Padre.Visible = False AndAlso Padre.GetType Is GetType(ToolStripMenuItem) Then
                Padre.Visible = True
                MostrarMenusPadres(Padre.OwnerItem)
            End If
        End If
    End Sub



    Public Sub ValidarDatosChequeDevuelto(ByRef ChequeDevuelto As ChequeDevueltoClass)
        'Dim ChequesDevueltos As New CC.ChequeDevueltoCollection()

        If ChequeDevuelto.IdBanco = 0 Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 7)
        ElseIf ChequeDevuelto.IdCliente = 0 Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 8)
        ElseIf ChequeDevuelto.NoCheque = String.Empty Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.CHEQUES_DEVUELTOS, 0)
        ElseIf ChequeDevuelto.Importe <= 0 Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.CHEQUES_DEVUELTOS, 1)
            'ElseIf ChequesDevueltos.GetMulti(HC.ChequeDevueltoFields.NoCheque = ChequeDevuelto.NoCheque) Then
            '    Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.CHEQUES_DEVUELTOS, 2)
        End If
    End Sub

    Public Sub RegistrarChequeDevuelto(ByRef ChequeDevuelto As ChequeDevueltoClass, ByRef Trans As HC.Transaction)
        ValidarDatosChequeDevuelto(ChequeDevuelto)
        ChequeDevuelto.Guardar(Trans)
    End Sub

    Public Sub CancelarChequeDevuelto(ByRef ChequeDevuelto As ChequeDevueltoClass, ByRef Trans As HC.Transaction)
        If ChequeDevuelto.Pagos_Vigentes.Count > 0 Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.CHEQUES_DEVUELTOS, 3)
        End If
        ChequeDevuelto.Cancelar(Trans)
    End Sub

    Public Sub ArchivoCierreFicticioLote(ByRef Lotes As LoteCollectionClass, ByVal FechaCierre As Date, ByRef Trans As HC.Transaction)
        Dim Coleccion As New CC.CierreFicticioCollection()
        Trans.Add(Coleccion)
        Coleccion.GetMulti(Nothing)
        Coleccion.DeleteMulti()

        For Each Lote As LoteClass In Lotes
            Coleccion.Add(New ArchivoCierreFicticioClass(Lote.IdLote, Lote.FechaInicio, FechaCierre, Lote.DiasCabeza, Lote.SaldoKilosAlim, Lote.CalcularPesoEntrada, Lote.CalcularPesoActual, Lote.PesoEstimado, Lote.SaldoImpte, Lote.SaldoImpteAlim, Lote.SaldoimpteMed, Lote.SaldoCostoInd))
        Next
        Coleccion.SaveMulti()
    End Sub

    Public Sub RealizarCierreDiarioEngorda(ByRef Trans As HC.Transaction)
        Dim CostoIndirectoxCabeza As Decimal = 0D
        Dim DiasDelMes As Integer = Date.DaysInMonth(Now.Year, Now.Month)
        Dim DetallesLotes As New CC.McecatLotesDetCollection
        Dim Lote As New CC.McecatLotesCabCollection
        Dim DetalleCorral As New CC.McecatCorralesDetCollection
        Dim Relacion As New OC.RelationCollection

        Me.Configuracion.Engorda.Entidad.Refetch()
        Me.ValidarCierreDiarioEngorda()
        CostoIndirectoxCabeza = Configuracion.Engorda.CostoIndirectoMensual / DiasDelMes

        Trans.Add(DetallesLotes)
        Trans.Add(Lote)
        Trans.Add(DetalleCorral)

        Relacion.Add(EC.McecatLotesDetEntity.Relations.McecatLotesCabEntityUsingIdLote)
        DetallesLotes.GetMulti(HC.McecatLotesDetFields.Estatus = LoteDetClass.EstatusLoteDetalle.VIGENTE And HC.McecatLotesCabFields.Estatus = LoteClass.EstatusLote.VIGENTE, Relacion)

        If DetallesLotes.Count > 0 Then
            CostoIndirectoxCabeza /= DetallesLotes.Count
        Else
            Exit Sub
        End If

        For Each Cabeza As EC.McecatLotesDetEntity In DetallesLotes
            Lote.GetMulti(HC.McecatLotesCabFields.IdLote = Cabeza.IdLote)
            DetalleCorral.GetMulti(HC.McecatCorralesDetFields.IdCorral = Cabeza.IdLote)

            For Each Lot As EC.McecatLotesCabEntity In Lote
                Lot.SaldoCostoInd += CostoIndirectoxCabeza
            Next

            For Each DetCorral As EC.McecatCorralesDetEntity In DetalleCorral
                DetCorral.SaldoCostoInd += CostoIndirectoxCabeza
            Next

            Cabeza.SaldoCostoInd += CostoIndirectoxCabeza
            Lote.SaveMulti()
            DetalleCorral.SaveMulti()
        Next
        DetallesLotes.SaveMulti()
        Configuracion.Engorda.FechaCierreEngorda = Configuracion.Engorda.FechaCierreEngorda.AddDays(1)
        Configuracion.Engorda.Guardar(Trans)
    End Sub

    Public Sub ValidarCierreDiarioEngorda()
        If Me.Configuracion.Engorda.FechaCierreEngorda > Now.AddDays(-1) Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.CIERRE_DIARIO_ENGORDA, 0)
        Else
            If Me.Configuracion.Engorda.CostoIndirectoMensual = 0 Then
                Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.CONFIGURACION_ENGORDA, 0)
            ElseIf CType(Me.Configuracion.Engorda.MesCostosIndirecto, Byte) = 0 Then
                Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.CONFIGURACION_ENGORDA, 1)
            ElseIf Me.Configuracion.Engorda.FechaCierreEngorda.Year = 1900 Then
                Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.CONFIGURACION_ENGORDA, 2)
            Else
                If Not Configuracion.Engorda.FechaCierreEngorda.Year = "1900" AndAlso CType(Configuracion.Engorda.MesCostosIndirecto, Byte) < Configuracion.Engorda.FechaCierreEngorda.Month Then
                    If MsgBox("El último mes en que se capturó el Costo Indirecto Mensual es, " & Configuracion.Engorda.MesCostosIndirecto.ToString() & vbNewLine & "¿Desea Continuar...?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Sesion.MiEmpresa.Empnom) = MsgBoxResult.No Then
                        Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 6)
                    End If
                End If
            End If
        End If
    End Sub

    Public Function CambiarCorral(ByRef Lote As LoteClass, ByRef CorralNuevo As CorralClass, ByRef Trans As HC.Transaction) As Boolean
        If Lote Is Nothing Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 4)
        ElseIf CorralNuevo Is Nothing Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 5)
        ElseIf Lote.IdCorral = CorralNuevo.IdCorral Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.CAMBIO_DE_CORRAL, 0)
        End If

        If MsgBox("Este proceso reemplazará los datos del corral actual al nuevo corral." & _
        vbNewLine & "El corral actual se quedara con datos en cero" & _
        vbNewLine & "¿Desea Continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Sesion.MiEmpresa.Empnom) = MsgBoxResult.Yes Then
            Dim DetCorrales As New CC.McecatCorralesDetCollection
            Trans.Add(DetCorrales)

            'Limpia el detalle del corral nuevo
            DetCorrales.GetMulti(HC.McecatCorralesDetFields.IdCorral = CorralNuevo.IdCorral)
            DetCorrales.DeleteMulti()

            'Cambia el corral actual por el nuevo corral en el detalle
            DetCorrales.GetMulti(HC.McecatCorralesDetFields.IdCorral = Lote.IdCorral)

            For Each Detalle As EC.McecatCorralesDetEntity In DetCorrales
                Detalle.IdCorral = CorralNuevo.IdCorral
            Next
            DetCorrales.SaveMulti()

            'Realiza el cambio en el Lote
            Lote.IdCorral = CorralNuevo.IdCorral
            Lote.Guardar(Trans)
            Return True
        End If
    End Function

    Public Sub CerrarLotes(ByRef Lotes As LoteCollectionClass, ByVal FechaCierre As Date, ByRef Trans As HC.Transaction)
        For Each Lote As LoteClass In Lotes
            Lote.Cerrar(FechaCierre, Trans)
        Next
    End Sub

    Public Sub CancelarCierreLotes(ByRef Lotes As LoteCollectionClass, ByRef Trans As HC.Transaction)
        For Each lote As LoteClass In Lotes
            lote.CancelarCerrado(Trans)
        Next
    End Sub

    Private Sub ReiniciarCorralDeReciba(ByRef CorralReciba As CorralClass, ByVal Referencia As String, ByVal FechaReinicio As Date, ByRef Trans As HC.Transaction)
        Trans = New HC.Transaction(IsolationLevel.ReadCommitted, "Reiniciar Corral Reciba")
        Dim SalidasReciba As New CC.SalidaGanadoCabCollection
        Dim SalidasTranferencia As New CC.SalidaGanadoCabCollection, sKilos As Decimal = 0D
        Dim KilosReciba As Decimal = 0D, DineroReciba As Decimal = 0D, CostoEntrada As Decimal = 0D, CostoAlimentos As Decimal = 0D, CostoMedicamentos As Decimal = 0D, CostoIndirecto As Decimal = 0D
        Dim MovimientoGanadoDetalles As New MovimientoGanadoDetalleCollectionClass, Lotes As New LoteCollectionClass
        Dim FechaUltimoReinicio As Date = #1/1/1900#

        For Each detalle As CorralDetalleClass In CorralReciba.Detalle
            KilosReciba += detalle.ExistKilos
            DineroReciba += detalle.CostoEnt + detalle.ImpteMedicamento + detalle.ImpteAlimento + detalle.SaldoCostoInd

            If detalle.FechaUltReinicio.Ticks > FechaUltimoReinicio.Ticks Then FechaUltimoReinicio = detalle.FechaUltReinicio
        Next
        SalidasReciba.GetMulti(HC.SalidaGanadoCabFields.IdCorral = CorralReciba.IdCorral And HC.SalidaGanadoCabFields.Estatus = 1 _
        And HC.SalidaGanadoCabFields.Fecha > FechaUltimoReinicio _
        And (HC.SalidaGanadoCabFields.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Reciba_a_Rastro _
        Or HC.SalidaGanadoCabFields.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Reciba_a_Venta _
        Or HC.SalidaGanadoCabFields.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Reciba_por_Muerte _
        Or HC.SalidaGanadoCabFields.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Transferencia_de_Reciba_a_Corral))

        For Each SalidaReciba As EC.SalidaGanadoCabEntity In SalidasReciba
            sKilos += SalidaReciba.Kilos

            If SalidaReciba.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Transferencia_de_Reciba_a_Corral Then
                SalidasTranferencia.Add(SalidaReciba)
            End If
        Next

        If Not SalidasTranferencia.Count > 0 Then
            MsgBox("No hay movimientos para el prorrateo, no se llevo a cabo el proceso de reinicio de reciba", MsgBoxStyle.Information, Me.Sesion.MiEmpresa.Empnom)
            Trans.Rollback()
            Exit Sub
        End If

        For Each SalidaTransferencia As EC.SalidaGanadoCabEntity In SalidasTranferencia
            Dim Kilos As Decimal = 0D, CostoxKilo As Decimal = 0D, Importe As Decimal = 0D
            Dim Lote As LoteClass = Nothing, Indice As Integer = -1, ProrrateoReciba As ProrrateoRecibaClass

            If sKilos > 0 Then
                Kilos = KilosReciba / sKilos * SalidaTransferencia.Kilos
                Importe = DineroReciba / sKilos * SalidaTransferencia.Kilos
            End If
            If KilosReciba > 0 Then CostoxKilo = DineroReciba / KilosReciba
            ProrrateoReciba = New ProrrateoRecibaClass(SalidaTransferencia.IdSalidaGanadoCab, FechaReinicio, Kilos, SalidaTransferencia.IdLoteDestino, SalidaTransferencia.IdCorral, CostoxKilo, Importe)
            ProrrateoReciba.Guardar(Trans)

            Indice = Lotes.IndexOf(SalidaTransferencia.IdLoteDestino)

            If Indice > -1 Then
                Lote = Lotes(Indice)
            Else
                Lote = New LoteClass(SalidaTransferencia.McecatLotesCab)
                Lotes.Add(Lote)
            End If
            Lote.AcumEntImpte += Importe
            Lote.SaldoImpte += Importe

            For Each Detalle As EC.SalidaGanadoDetEntity In SalidaTransferencia.SalidaGanadoDet
                MovimientoGanadoDetalles.Add(New MovimientoGanadoDetalleClass(Detalle.IdTipoGanado, 0, FechaReinicio, Detalle.Cabezas, Detalle.Kilos, Detalle.CostoxKilo))
            Next
        Next
        Trans.Add(Lotes.ObtenerColeccion)
        Lotes.ObtenerColeccion.SaveMulti()

        For Each detalle As CorralDetalleClass In CorralReciba.Detalle
            detalle.ExistCabezas = 0D
            detalle.ExistKilos = 0D
            detalle.CostoEnt = 0D
            detalle.ImpteAlimento = 0D
            detalle.ImpteMedicamento = 0D
            detalle.KilosAlimento = 0D
            detalle.SaldoCostoInd = 0D
            detalle.FechaUltReinicio = FechaReinicio
            Trans.Add(detalle.Entidad)
            detalle.Entidad.Save()
        Next
        Me.RegistrarMovimientoDeGanado(InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.EntradaReinicioReciba, FechaReinicio, Referencia, MovimientoGanadoDetalles, Trans)
    End Sub

    Public Function ActualizarErroresPolizas(ByRef Trans As HC.Transaction, Optional ByRef Polizas As CC.PolizaCollection = Nothing) As CC.PolizaCollection
        Dim PolizasConError As New CC.PolizaCollection

        If Polizas Is Nothing Then
            Polizas = New CC.PolizaCollection
            Polizas.GetMulti(Nothing)
        End If

        For Each poliza As EC.PolizaEntity In Polizas
            If poliza.FechaPoliza.Year < Me.EjercicioContable.Ejercicio Or poliza.FechaPoliza > Me.EjercicioContable.FechaCierre Then
                poliza.TipoError = 1
                PolizasConError.Add(poliza)
            ElseIf poliza.PolizaDetalle Is Nothing OrElse poliza.PolizaDetalle.Count < 1 Then
                poliza.TipoError = 6
                PolizasConError.Add(poliza)
            Else
                Dim Suma As Decimal = 0D

                For Each detalle As EC.PolizaDetalleEntity In poliza.PolizaDetalle
                    If detalle.CuentaContable.IsNew Then
                        poliza.TipoError = 3
                        PolizasConError.Add(poliza)
                        Exit For
                    ElseIf Not detalle.CuentaContable.BooAfectable Then
                        poliza.TipoError = 4
                        PolizasConError.Add(poliza)
                        Exit For
                    End If

                    If detalle.OperacionCa = "C" Then
                        Suma -= detalle.Importe
                    ElseIf detalle.OperacionCa = "A" Then
                        Suma += detalle.Importe
                    Else
                        poliza.TipoError = 5
                        PolizasConError.Add(poliza)
                        Exit For
                    End If
                Next

                If Suma = 0D Then
                    poliza.TipoError = 2
                    PolizasConError.Add(poliza)
                    Exit For
                End If
            End If
        Next
        Trans.Add(PolizasConError)
        PolizasConError.SaveMulti()
        Return PolizasConError
    End Function

    Private Sub ActualizarAcumTipodeGanado(ByVal IdTipoGanado As Integer, ByVal EsSalida As Boolean, ByVal Cabezas As Integer, ByVal Kilos As Decimal, ByVal Fecha As Date, ByRef Trans As HC.Transaction)
        Dim TipoGanado As New EC.McgcatTiposdeGanadoEntity()
        Dim Operador As Integer = IIf(EsSalida, -1, 1)

        Trans.Add(TipoGanado)
        TipoGanado.FetchUsingPK(IdTipoGanado)
        TipoGanado.AcumuladoCabezas += Cabezas * Operador
        TipoGanado.AcumuladoKilos += Kilos * Operador

        If EsSalida Then
            TipoGanado.FechaUltimaSalida = Fecha
        Else
            TipoGanado.FechaUltimaEntrada = Fecha
        End If
        TipoGanado.Save()
    End Sub

    Private Sub ActualizarSalidaDeAreteDeCorral(ByVal IdCorral As String, ByVal IdTipoGanado As Integer, ByVal Cabezas As Integer, ByVal Kilos As Decimal, ByVal CostoEntrada As Decimal, ByVal CostoAlimentos As Decimal, ByVal CostoMedicamentos As Decimal, ByVal KilosAlimento As Decimal, ByVal CostoIndirecto As Decimal, ByRef Trans As HC.Transaction)
        Dim CorralDetalles As New CC.McecatCorralesDetCollection
        Trans.Add(CorralDetalles)
        CorralDetalles.GetMulti(HC.McecatCorralesDetFields.IdCorral = IdCorral And HC.McecatCorralesDetFields.IdTipoGanado = IdTipoGanado)

        For Each CorralDetalle As EC.McecatCorralesDetEntity In CorralDetalles
            CorralDetalle.ExistCabezas -= Cabezas
            CorralDetalle.ExistKilos -= Kilos
            CorralDetalle.CostoEnt -= CostoEntrada
            CorralDetalle.ImpteAlimento -= CostoAlimentos
            CorralDetalle.ImpteMedicamento -= CostoMedicamentos
            CorralDetalle.KilosAlimento -= KilosAlimento
            CorralDetalle.SaldoCostoInd -= CostoIndirecto
            CorralDetalle.FechaUltSal = Now
            Trans.Add(CorralDetalle)
            CorralDetalle.Save()
        Next
    End Sub

    Private Sub ActualizarEntradaDeAreteACorral(ByVal IdCorral As String, ByVal IdTipoGanado As Integer, ByVal Cabezas As Integer, ByVal Kilos As Decimal, ByVal CostoEntrada As Decimal, ByVal CostoAlimentos As Decimal, ByVal CostoMedicamentos As Decimal, ByVal KilosAlimento As Decimal, ByVal CostoIndirecto As Decimal, ByRef Trans As HC.Transaction)
        Dim CorralDetalles As New CC.McecatCorralesDetCollection
        Trans.Add(CorralDetalles)
        CorralDetalles.GetMulti(HC.McecatCorralesDetFields.IdCorral = IdCorral And HC.McecatCorralesDetFields.IdTipoGanado = IdTipoGanado)

        If CorralDetalles.Count > 0 Then
            For Each CorralDetalle As EC.McecatCorralesDetEntity In CorralDetalles
                CorralDetalle.ExistCabezas += Cabezas
                CorralDetalle.ExistKilos += Kilos
                CorralDetalle.CostoEnt += CostoEntrada
                CorralDetalle.ImpteAlimento += CostoAlimentos
                CorralDetalle.ImpteMedicamento += CostoMedicamentos
                CorralDetalle.KilosAlimento += KilosAlimento
                CorralDetalle.SaldoCostoInd += CostoIndirecto
                CorralDetalle.FechaUltEnt = Now
                Trans.Add(CorralDetalle)
                CorralDetalle.Save()
            Next
        Else
            Dim NuevoDetalle As New CorralDetalleClass
            NuevoDetalle.IdCorral = IdCorral
            NuevoDetalle.IdTipoGanado = IdTipoGanado
            NuevoDetalle.ExistCabezas = Cabezas
            NuevoDetalle.ExistKilos = Kilos
            NuevoDetalle.CostoEnt = CostoEntrada * Kilos
            NuevoDetalle.ImpteMedicamento = CostoMedicamentos * Kilos
            NuevoDetalle.ImpteAlimento = CostoAlimentos * Kilos
            NuevoDetalle.KilosAlimento = KilosAlimento * Kilos
            NuevoDetalle.SaldoCostoInd = CostoIndirecto
            NuevoDetalle.FechaUltEnt = Now
            NuevoDetalle.Guardar(Trans)
        End If
    End Sub

    Private Sub ActualizarSalidaDeAreteDeLote(ByVal Lote As LoteClass, ByVal Cabezas As Integer, ByVal Kilos As Decimal, ByVal CostoEntrada As Decimal, ByVal CostoMedicina As Decimal, ByVal CostoAlimento As Decimal, ByVal KilosAlimento As Decimal, ByVal CostoIndirecto As Decimal, ByRef Trans As HC.Transaction)
        Lote.SaldoCabezas -= Cabezas
        Lote.SaldoKilos -= Kilos
        Lote.SaldoKilosAlim -= KilosAlimento
        Lote.SaldoImpteAlim -= CostoAlimento
        Lote.SaldoimpteMed -= CostoMedicina
        Lote.SaldoCostoInd -= CostoIndirecto
        Lote.SaldoImpte -= CostoEntrada
        Lote.AcumSalCab += Cabezas
        Lote.AcumSalKilos += Kilos
        Lote.AcumImpteAlim -= CostoAlimento
        Lote.AcumImpteMedic -= CostoMedicina
        Lote.AcumEntImpte -= CostoEntrada
        Lote.AcumKilosAlim -= KilosAlimento
        Trans.Add(Lote.Entidad)
        Lote.Entidad.Save()
    End Sub

    Private Sub ActualizarEntradaDeAreteALote(ByVal Lote As LoteClass, ByVal Cabezas As Integer, ByVal Kilos As Decimal, ByVal CostoEntrada As Decimal, ByVal CostoMedicina As Decimal, ByVal CostoAlimento As Decimal, ByVal KilosAlimento As Decimal, ByVal CostoIndirecto As Decimal, ByRef Trans As HC.Transaction)
        Lote.SaldoCabezas += Cabezas
        Lote.SaldoKilos += Kilos
        Lote.SaldoKilosAlim += KilosAlimento
        Lote.SaldoImpteAlim += CostoAlimento
        Lote.SaldoimpteMed += CostoMedicina
        Lote.SaldoCostoInd += CostoIndirecto
        Lote.SaldoImpte += CostoEntrada
        Lote.AcumEntCab += Cabezas
        Lote.AcumEntKilos += Kilos
        Lote.AcumImpteAlim += CostoAlimento
        Lote.AcumImpteMedic += CostoMedicina
        Lote.AcumEntImpte += CostoEntrada
        Lote.AcumKilosAlim += KilosAlimento
        Trans.Add(Lote.Entidad)
        Lote.Entidad.Save()
    End Sub

    Private Sub ReContabilizarTiposdeGanado(ByRef CorralReciba As SalidaGanadoCabeceroClass, ByVal EsSalida As Boolean, ByRef Trans As HC.Transaction)
        Dim TiposGanado As New CC.McgcatTiposdeGanadoCollection

        For Each detalle As SalidaGanadoDetalleClass In CorralReciba.Detalles
            Dim TipoGanado As EC.McgcatTiposdeGanadoEntity = Nothing

            For Each TipoGan As EC.McgcatTiposdeGanadoEntity In TiposGanado
                If TipoGan.IdTipoGanado = detalle.IdTipoGanado Then
                    TipoGanado = TipoGan
                End If
            Next

            If TipoGanado Is Nothing Then
                TipoGanado = detalle.TipoGanado.Entidad
                TiposGanado.Add(TipoGanado)
            End If

            If EsSalida Then
                TipoGanado.AcumuladoCabezas -= detalle.Cabezas
                TipoGanado.AcumuladoKilos -= detalle.Kilos
                TipoGanado.FechaUltimaSalida = CorralReciba.Fecha
            Else
                TipoGanado.AcumuladoCabezas += detalle.Cabezas
                TipoGanado.AcumuladoKilos += detalle.Kilos
                TipoGanado.FechaUltimaEntrada = Now
            End If
        Next
        Trans.Add(TiposGanado)
        TiposGanado.SaveMulti()
    End Sub

    Private Sub CambiarAretesDeLote(ByVal FechaMovimiento As Date, ByVal LoteOrigen As LoteClass, ByVal LoteDestino As LoteClass, ByVal Aretes As LoteDetCollectionClass, ByRef Trans As HC.Transaction)
        For Each Arete As LoteDetClass In Aretes
            Dim MoviendoArete As New LoteDetClass()
            Trans.Add(MoviendoArete)
            Trans.Add(Arete)

            ActualizarSalidaDeAreteDeCorral(LoteOrigen.IdCorral, Arete.IdTipoGanado, 1, Arete.PesoEstimado, Arete.Impte, Arete.ImpteAlim, Arete.ImpteMed, Arete.KilosAlim, Arete.SaldoCostoInd, Trans)
            ActualizarSalidaDeAreteDeLote(LoteOrigen, 1, Arete.PesoEstimado, Arete.Impte, Arete.ImpteMed, Arete.ImpteAlim, Arete.KilosAlim, Arete.SaldoCostoInd, Trans)

            MoviendoArete.IdLote = LoteDestino.IdLote
            MoviendoArete.IdTipoGanado = Arete.IdTipoGanado
            MoviendoArete.AretePropio = Arete.AretePropio
            MoviendoArete.AreteSiniiga = Arete.AreteSiniiga
            MoviendoArete.AreteTransporte = Arete.AreteTransporte
            MoviendoArete.KilosEntrada = Arete.PesoEstimado
            MoviendoArete.FechaEntrada = FechaMovimiento
            MoviendoArete.Gdpini = Arete.Gdpini
            MoviendoArete.Impte = Arete.ImpteAlim + Arete.ImpteMed + Arete.SaldoCostoInd + Arete.Impte
            MoviendoArete.Save()

            Arete.FechaSalida = FechaMovimiento
            Arete.Estatus = LoteDetClass.EstatusLoteDetalle.CERRADO
            Arete.Save()

            ActualizarEntradaDeAreteALote(LoteDestino, 1, Arete.PesoEstimado, Arete.Impte, Arete.ImpteMed, Arete.ImpteAlim, Arete.KilosAlim, Arete.SaldoCostoInd, Trans)
            ActualizarEntradaDeAreteACorral(LoteDestino.IdCorral, Arete.IdTipoGanado, 1, Arete.PesoEstimado, Arete.Impte, Arete.ImpteAlim, Arete.ImpteMed, Arete.KilosAlim, Arete.SaldoCostoInd, Trans)
        Next
    End Sub

    Private Sub CancelarCambiarAretesDeLote(ByVal FechaMovimiento As Date, ByVal LoteOrigen As LoteClass, ByVal LoteDestino As LoteClass, ByVal Aretes As LoteDetCollectionClass, ByRef Trans As HC.Transaction)
        For Each Arete As LoteDetClass In Aretes
            Dim MoviendoArete As New CC.McecatLotesDetCollection
            Dim SalidaDetalle As New CC.SalidaGanadoDetCollection

            Trans.Add(MoviendoArete)
            Trans.Add(Arete)
            Trans.Add(SalidaDetalle)

            ActualizarSalidaDeAreteDeCorral(LoteOrigen.IdCorral, Arete.IdTipoGanado, 1, Arete.KilosEntrada, Arete.Impte, Arete.ImpteAlim, Arete.ImpteMed, Arete.KilosAlim, Arete.SaldoCostoInd, Trans)
            ActualizarSalidaDeAreteDeLote(LoteOrigen, 1, Arete.KilosEntrada, Arete.Impte, Arete.ImpteMed, Arete.ImpteAlim, Arete.KilosAlim, Arete.SaldoCostoInd, Trans)
            ActualizarEntradaDeAreteALote(LoteDestino, 1, Arete.KilosEntrada, Arete.Impte, Arete.ImpteMed, Arete.ImpteAlim, Arete.KilosAlim, Arete.SaldoCostoInd, Trans)
            ActualizarEntradaDeAreteACorral(LoteDestino.IdCorral, Arete.IdTipoGanado, 1, Arete.KilosEntrada, Arete.Impte, Arete.ImpteAlim, Arete.ImpteMed, Arete.KilosAlim, Arete.SaldoCostoInd, Trans)

            MoviendoArete.GetMulti(HC.McecatLotesDetFields.IdLote = LoteOrigen.IdLote And HC.McecatLotesDetFields.AretePropio = Arete.AretePropio And HC.McecatLotesDetFields.Estatus = 1)

            If MoviendoArete.Count <> 1 Then
                Throw New BusinessException(CategoriaEnumException.INCONSISTENCIA_DE_DATOS, ModuloEnum.SALIDA_CORRAL_TRANSFERENCIA, 0, Arete.AretePropio)
            End If

            SalidaDetalle.GetMulti(HC.SalidaGanadoDetFields.IdMcecatLotesDet = Arete.IdMcecatLotesDet)

            If SalidaDetalle.Count <> 1 Then
                Throw New BusinessException(CategoriaEnumException.INCONSISTENCIA_DE_DATOS, ModuloEnum.SALIDA_CORRAL_TRANSFERENCIA, 0, Arete.AretePropio)
            End If

            For Each SalidaDet As EC.SalidaGanadoDetEntity In SalidaDetalle
                SalidaDet.IdMcecatLotesDet = Nothing
                SalidaDet.AreteTransporte = Arete.AreteTransporte
                SalidaDet.AreteSiniiga = Arete.AreteSiniiga
                SalidaDet.Arete = Arete.AretePropio
                SalidaDet.Save()
            Next
            MoviendoArete.DeleteMulti()

            Arete.FechaSalida = Nothing
            Arete.Estatus = LoteDetClass.EstatusLoteDetalle.VIGENTE
            Arete.Save()
        Next
    End Sub

    Private Sub RealizarSalidaoEntradadeLotes(ByRef SalidaGanado As SalidaGanadoCabeceroClass, ByVal EsSalida As Boolean, ByRef Trans As HC.Transaction)
        Dim Lotes As New CC.McecatLotesCabCollection
        Dim LotesDetalle As New CC.McecatLotesDetCollection

        For Each detalle As SalidaGanadoDetalleClass In SalidaGanado.Detalles
            Dim ExisteLote As Boolean = False
            Dim Lote As EC.McecatLotesCabEntity = detalle.Lote.Entidad

            If EsSalida Then
                detalle.LoteDetalle.Estatus = LoteDetClass.EstatusLoteDetalle.CERRADO
                detalle.LoteDetalle.FechaSalida = SalidaGanado.Fecha
                detalle.LoteDetalle.KilosSalida = detalle.Kilos
            Else
                detalle.LoteDetalle.Estatus = LoteDetClass.EstatusLoteDetalle.VIGENTE
                detalle.LoteDetalle.FechaSalida = Nothing
                detalle.LoteDetalle.KilosSalida = 0D
            End If
            LotesDetalle.Add(detalle.LoteDetalle)

            For Each Item As EC.McecatLotesCabEntity In Lotes
                If Item.IdLote = detalle.IdLote.Value Then
                    AfectarLote(Item, detalle, EsSalida)
                    ExisteLote = True
                End If
            Next

            If Not ExisteLote Then
                Lotes.Add(Lote)
                AfectarLote(Lote, detalle, EsSalida)
            End If
        Next
        Trans.Add(Lotes)
        Trans.Add(LotesDetalle)
        Lotes.SaveMulti()
        LotesDetalle.SaveMulti()
    End Sub

    Private Sub AfectarLote(ByRef Lote As EC.McecatLotesCabEntity, ByRef detalle As SalidaGanadoDetalleClass, ByVal EsSalida As Boolean)
        If EsSalida Then
            Lote.SaldoKilosAlim -= detalle.KilosAlimento * detalle.Kilos
            Lote.SaldoImpteAlim -= detalle.CostoAlimento * detalle.Kilos
            Lote.SaldoCostoInd -= detalle.CostoIndirecto * detalle.Cabezas
            Lote.SaldoImpteMed -= detalle.CostoMedicina * detalle.Kilos
            Lote.SaldoImpte -= detalle.CostoEntrada * detalle.Kilos
            Lote.SaldoKilos -= detalle.Kilos
            Lote.SaldoCabezas -= detalle.Cabezas
            Lote.AcumSalKilos += detalle.Kilos
            Lote.AcumSalCab += detalle.Cabezas

            If detalle.SalidaGanadoCabecero.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_por_Muerte Then
                Lote.AcumCabMuerte += detalle.Cabezas
                Lote.AcumImpteMuerte += detalle.Importe
                Lote.AcumKilosMuerte += detalle.Kilos
            End If
        Else
            Lote.SaldoKilosAlim += detalle.KilosAlimento * detalle.Kilos
            Lote.SaldoImpteAlim += detalle.CostoAlimento * detalle.Kilos
            Lote.SaldoCostoInd += detalle.CostoIndirecto * detalle.Cabezas
            Lote.SaldoImpteMed += detalle.CostoMedicina * detalle.Kilos
            Lote.SaldoImpte += detalle.CostoEntrada * detalle.Kilos
            Lote.SaldoKilos += detalle.Kilos
            Lote.SaldoCabezas += detalle.Cabezas
            Lote.AcumSalKilos -= detalle.Kilos
            Lote.AcumSalCab -= detalle.Cabezas

            If detalle.SalidaGanadoCabecero.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_por_Muerte Then
                Lote.AcumCabMuerte -= detalle.Cabezas
                Lote.AcumImpteMuerte -= detalle.Importe
                Lote.AcumKilosMuerte -= detalle.Kilos
            End If
        End If
    End Sub

    Private Sub RealizarSalidaoEntradadeCorral(ByRef CorralReciba As SalidaGanadoCabeceroClass, ByVal EsSalida As Boolean, ByRef Trans As HC.Transaction)
        For Each CorralDetalle As EC.McecatCorralesDetEntity In CorralReciba.Corral.Detalle.ObtenerColeccion()
            For Each detalle As SalidaGanadoDetalleClass In CorralReciba.Detalles
                If detalle.IdTipoGanado = CorralDetalle.IdTipoGanado Then
                    If EsSalida Then
                        CorralDetalle.SaldoCostoInd -= detalle.CostoIndirecto * detalle.Kilos
                        CorralDetalle.CostoEnt -= detalle.CostoEntrada * detalle.Kilos
                        CorralDetalle.ImpteAlimento -= detalle.CostoAlimento * detalle.Kilos
                        CorralDetalle.ImpteMedicamento -= detalle.CostoMedicina * detalle.Kilos
                        CorralDetalle.KilosAlimento -= detalle.KilosAlimento * detalle.Kilos
                        CorralDetalle.ExistCabezas -= detalle.Cabezas
                        CorralDetalle.ExistKilos -= detalle.Kilos
                        CorralDetalle.FechaUltSal = CorralReciba.Fecha
                    Else
                        CorralDetalle.SaldoCostoInd += detalle.CostoIndirecto * detalle.Kilos
                        CorralDetalle.CostoEnt += detalle.CostoEntrada * detalle.Kilos
                        CorralDetalle.ImpteAlimento += detalle.CostoAlimento * detalle.Kilos
                        CorralDetalle.ImpteMedicamento += detalle.CostoMedicina * detalle.Kilos
                        CorralDetalle.KilosAlimento += detalle.KilosAlimento * detalle.Kilos
                        CorralDetalle.ExistCabezas += detalle.Cabezas
                        CorralDetalle.ExistKilos += detalle.Kilos
                        CorralDetalle.FechaUltEnt = Now
                    End If
                End If
            Next
        Next
        Trans.Add(CorralReciba.Corral.Detalle.ObtenerColeccion())
        CorralReciba.Corral.Detalle.ObtenerColeccion().SaveMulti()
    End Sub

    Private Sub CancelarRegistrodeMovimientoGanado(ByRef CorralReciba As SalidaGanadoCabeceroClass, ByRef Trans As HC.Transaction)
        If CorralReciba.MovimientoGanado.Entidad.IsNew Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 1)
        Else
            Trans.Add(CorralReciba.MovimientoGanado.Entidad)
            CorralReciba.MovimientoGanado.Estatus = MovimientoGanadoClass.EstatusMovimiento.CANCELADO
            CorralReciba.MovimientoGanado.Entidad.Save()
        End If
    End Sub

    Private Function RegistrarMovimientoDeGanado(ByVal TipoMovimiento As InventarioConfigGanadoClass.TipoMovimientoGanadoEnum, _
    ByVal FechaMovimiento As Date, ByVal Referencia As String, ByVal MovimientoGanadoDetalle As MovimientoGanadoDetalleCollectionClass, _
    ByRef Trans As HC.Transaction) As MovimientoGanadoClass
        Dim MovimientoGanado As New MovimientoGanadoClass()
        MovimientoGanado.EstablecerTipoMovimientoGanado(TipoMovimiento, Trans)
        MovimientoGanado.Estatus = MovimientoGanadoClass.EstatusMovimiento.VIGENTE
        MovimientoGanado.FechaMovimeinto = FechaMovimiento
        MovimientoGanado.Referencia = Referencia

        For Each detalle As MovimientoGanadoDetalleClass In MovimientoGanadoDetalle
            MovimientoGanado.Detalle.Add(MovimientoGanado, detalle)
        Next
        MovimientoGanado.Guardar(Trans)
        Return MovimientoGanado
    End Function

    Private Sub RegistrarMovimientoDeGanadoParaSalidaGanado(ByRef CorralReciba As SalidaGanadoCabeceroClass, ByVal EsSalida As Boolean, ByRef Trans As HC.Transaction)
        Dim MovimientoGanado As New MovimientoGanadoClass()

        If EsSalida Then
            Select Case CorralReciba.IdTipoReciba
                Case SalidaGanadoCabeceroClass.TipoSalida.Transferencia_de_Reciba_a_Corral
                    MovimientoGanado.EstablecerTipoMovimientoGanado(InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.SalidaRecibaXtransferenciaAcorral, Trans)
                Case SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Reciba_por_Muerte
                    MovimientoGanado.EstablecerTipoMovimientoGanado(InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.SalidaRecibaMuerte, Trans)
                Case SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Reciba_a_Rastro
                    MovimientoGanado.EstablecerTipoMovimientoGanado(InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.SalidaRecibaRastro, Trans)
                Case SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Reciba_a_Venta
                    MovimientoGanado.EstablecerTipoMovimientoGanado(InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.SalidaRecibaVenta, Trans)
                Case SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_por_Muerte
                    MovimientoGanado.EstablecerTipoMovimientoGanado(InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.SalidaCorralMuerte, Trans)
                Case SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_a_Rastro
                    MovimientoGanado.EstablecerTipoMovimientoGanado(InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.SalidaCorralRastro, Trans)
                Case SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_a_Venta
                    MovimientoGanado.EstablecerTipoMovimientoGanado(InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.SalidaCorralVenta, Trans)
                Case SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_por_Tranferencia
                    MovimientoGanado.EstablecerTipoMovimientoGanado(InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.SalidaCorralTraspaso, Trans)
            End Select
        Else
            Select Case CorralReciba.IdTipoReciba
                Case SalidaGanadoCabeceroClass.TipoSalida.Transferencia_de_Reciba_a_Corral
                    MovimientoGanado.EstablecerTipoMovimientoGanado(InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.EntradaRecibaXcancelacionTransferenciaRecibaAcorral, Trans)
                Case SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Reciba_por_Muerte
                    MovimientoGanado.EstablecerTipoMovimientoGanado(InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.EntradaRecibaCancelacionMuerte, Trans)
                Case SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Reciba_a_Rastro
                    MovimientoGanado.EstablecerTipoMovimientoGanado(InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.EntradaRecibaCancelacionRastro, Trans)
                Case SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Reciba_a_Venta
                    MovimientoGanado.EstablecerTipoMovimientoGanado(InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.EntradaRecibaCancelacionVenta, Trans)
                Case SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_por_Muerte
                    MovimientoGanado.EstablecerTipoMovimientoGanado(InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.EntradaCorralCancelacionMuerte, Trans)
                Case SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_a_Rastro
                    MovimientoGanado.EstablecerTipoMovimientoGanado(InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.EntradaCorralCancelacionRastro, Trans)
                Case SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_a_Venta
                    MovimientoGanado.EstablecerTipoMovimientoGanado(InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.EntradaCorralCancelacionVenta, Trans)
                Case SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_por_Tranferencia
                    MovimientoGanado.EstablecerTipoMovimientoGanado(InventarioConfigGanadoClass.TipoMovimientoGanadoEnum.EntradaCorralCancelacionTraspaso, Trans)
            End Select
        End If
        MovimientoGanado.Estatus = MovimientoGanadoClass.EstatusMovimiento.VIGENTE
        MovimientoGanado.FechaMovimeinto = CType(IIf(EsSalida, CorralReciba.Fecha, Now), Date)
        CorralReciba.MovimientoGanado = MovimientoGanado

        For Each detalle As SalidaGanadoDetalleClass In CorralReciba.Detalles
            If detalle.IsDirty OrElse Not detalle.IsNew Then
                MovimientoGanado.Detalle.Add(CType(detalle, IMovimientoGanadoDetalle))
            End If
        Next
        MovimientoGanado.Guardar(Trans)
    End Sub

    Private Sub GuardarSalidaDeGanado(ByRef CorralReciba As SalidaGanadoCabeceroClass, ByVal EsCancelacion As Boolean, ByRef Trans As HC.Transaction, Optional ByVal RequerirArete As Boolean = True)
        Trans.Add(CorralReciba.MovimientoGanado.Entidad)

        If Not EsCancelacion Then
            CorralReciba.Guardar(Trans, RequerirArete)
        Else
            CorralReciba.Cancelar(Trans)
        End If
        CorralReciba.MovimientoGanado.Referencia = CorralReciba.Folio
        CorralReciba.MovimientoGanado.Entidad.Save()
    End Sub

    'funcion para guardar el estatus de una salida de ganado cuando esta es facturada
    Public Sub FacturarSalidaDeGanadodeReciba(ByRef CorralReciba As SalidaGanadoCabeceroClass, ByVal EsFacturacion As Boolean, ByRef Trans As HC.Transaction, Optional ByVal RequerirArete As Boolean = True)
        If EsFacturacion Then
            CorralReciba.Facturar(Trans)
        Else
            CorralReciba.QuitarFacturado(Trans)
        End If
    End Sub

    Private Sub ValidarCorralReciba(ByRef CorralReciba As SalidaGanadoCabeceroClass)
        If CorralReciba.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Reciba_a_Rastro _
        OrElse CorralReciba.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Reciba_a_Venta _
        OrElse CorralReciba.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Reciba_por_Muerte _
        OrElse CorralReciba.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Transferencia_de_Reciba_a_Corral Then
            If CorralReciba.Corral.Entidad.IsNew Then
                Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SALIDA_RECIBA_RASTRO, 4)
            End If
        ElseIf (CorralReciba.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Reciba_a_Rastro _
        OrElse CorralReciba.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_a_Rastro) AndAlso CorralReciba.Rastro.Entidad.IsNew Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SALIDA_RECIBA_RASTRO, 3)
        ElseIf (CorralReciba.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Transferencia_de_Reciba_a_Corral _
        OrElse CorralReciba.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_por_Tranferencia) AndAlso CorralReciba.LoteDestino.Entidad.IsNew Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SALIDA_RECIBA_CORRAL, 0)
        ElseIf (CorralReciba.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Reciba_por_Muerte _
        OrElse CorralReciba.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_por_Muerte) AndAlso CorralReciba.CausaMuerte.ObtenerEntidad.IsNew Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SALIDA_RECIBA_MUERTE, 0)
        ElseIf CorralReciba.Detalles.Count <= 0 Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SALIDA_RECIBA_RASTRO, 5)
        ElseIf CorralReciba.Detalles.Count = 1 AndAlso Not CorralReciba.Detalles(0).IsDirty Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SALIDA_RECIBA_RASTRO, 5)
        Else
            For i As Integer = CorralReciba.Detalles.Count - 1 To 0 Step -1
                If Not CorralReciba.Detalles(i).IsDirty And CorralReciba.Detalles(i).IsNew Then
                    CorralReciba.Detalles.RemoveAt(i)
                ElseIf CorralReciba.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Transferencia_de_Reciba_a_Corral Then
                    If Me.Configuracion.Engorda.RequerirArete AndAlso CorralReciba.Detalles(i).Arete.Trim = String.Empty _
                    AndAlso CorralReciba.Detalles(i).AreteTransporte.Trim = String.Empty AndAlso CorralReciba.Detalles(i).AreteSiniiga.Trim = String.Empty Then
                        Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SALIDA_RECIBA_CORRAL, 2)
                    ElseIf (Not Me.Configuracion.Engorda.RequerirArete AndAlso CorralReciba.Detalles(i).Arete.Trim <> String.Empty AndAlso CorralReciba.Detalles(i).AreteSiniiga.Trim <> String.Empty _
                    OrElse Me.Configuracion.Engorda.RequerirArete) _
                    AndAlso (CorralReciba.Detalles(i).Arete.Trim <> String.Empty AndAlso CC.McecatLotesDetCollection.GetMultiAsDataTable(HC.McecatLotesDetFields.AretePropio = CorralReciba.Detalles(i).Arete, 0, Nothing).Rows.Count > 0 _
                    OrElse CorralReciba.Detalles(i).AreteSiniiga.Trim <> String.Empty AndAlso CC.McecatLotesDetCollection.GetMultiAsDataTable(HC.McecatLotesDetFields.AreteSiniiga = CorralReciba.Detalles(i).AreteSiniiga, 0, Nothing).Rows.Count > 0) Then
                        Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SALIDA_RECIBA_CORRAL, 1)
                    End If
                ElseIf CorralReciba.Detalles(i).TipoGanado.Entidad.IsNew Then
                    Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SALIDA_RECIBA_RASTRO, 7)
                ElseIf CorralReciba.IdTipoReciba <> SalidaGanadoCabeceroClass.TipoSalida.Transferencia_de_Reciba_a_Corral Then
                    If CorralReciba.Detalles(i).Cabezas <= 0 Then
                        Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SALIDA_RECIBA_RASTRO, 1)
                    End If
                ElseIf CorralReciba.Detalles(i).Kilos <= 0 Then
                    Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SALIDA_RECIBA_RASTRO, 2)
                End If
            Next

            If CorralReciba.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Reciba_a_Rastro _
            OrElse CorralReciba.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Reciba_a_Venta _
            OrElse CorralReciba.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Reciba_por_Muerte Then
                For Each CorralDetalle As EC.McecatCorralesDetEntity In CorralReciba.Corral.Detalle.ObtenerColeccion()
                    Dim TotalCabezas As Decimal = CorralDetalle.ExistCabezas

                    For Each detalle As SalidaGanadoDetalleClass In CorralReciba.Detalles
                        If detalle.IdTipoGanado = CorralDetalle.IdTipoGanado Then
                            If detalle.Cabezas <= TotalCabezas Then
                                TotalCabezas -= detalle.Cabezas
                            Else
                                Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SALIDA_RECIBA_RASTRO, 6)
                            End If
                        End If
                    Next
                Next
            End If
        End If
    End Sub

    Private Sub GenerarMovimientoSacrificio(ByVal SalidaGanado As SalidaGanadoCabeceroClass, ByRef Trans As HC.Transaction)
        Dim ConLotSacrificio As New ConLotSacClass(SalidaGanado.IdSalidaGanadoCab, SalidaGanado.Cabezas, SalidaGanado.Kilos, 0, 0)
        ConLotSacrificio.Guardar(Trans)
    End Sub

    Private Sub CancelarMovimientoSacrificio(ByVal SalidaGanado As SalidaGanadoCabeceroClass, ByRef Trans As HC.Transaction)
        Dim MovimientoSacrificio As New CC.ConLotSacCollection()
        MovimientoSacrificio.GetMulti(HC.ConLotSacFields.IdSalidaGanadoRastro = SalidaGanado.IdSalidaGanadoCab)
        Trans.Add(MovimientoSacrificio)
        MovimientoSacrificio.DeleteMulti()
    End Sub

    Public Sub RealizarSalidadeRecibaaRastro(ByRef CorralReciba As SalidaGanadoCabeceroClass, ByVal Fecha As Date, ByRef Trans As HC.Transaction)
        CorralReciba.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Reciba_a_Rastro
        CorralReciba.Fecha = Fecha
        ValidarCorralReciba(CorralReciba)
        Me.ReContabilizarTiposdeGanado(CorralReciba, True, Trans)
        Me.RealizarSalidaoEntradadeCorral(CorralReciba, True, Trans)
        Me.RegistrarMovimientoDeGanadoParaSalidaGanado(CorralReciba, True, Trans)
        Me.GuardarSalidaDeGanado(CorralReciba, False, Trans)
        Me.GenerarMovimientoSacrificio(CorralReciba, Trans)

        If CorralReciba.Corral.TotalCabezas <= 0 Then
            Trans.Commit()
            Trans = New HC.Transaction(IsolationLevel.ReadCommitted, "Reiniciar Corral Reciba")
            Me.ReiniciarCorralDeReciba(CorralReciba.Corral, CorralReciba.Folio, Fecha, Trans)
        End If
    End Sub

    Public Sub RealizarSalidadeRecibaaVenta(ByRef CorralReciba As SalidaGanadoCabeceroClass, ByVal Fecha As Date, ByRef Trans As HC.Transaction)
        CorralReciba.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Reciba_a_Venta
        CorralReciba.Fecha = Fecha
        ValidarCorralReciba(CorralReciba)
        Me.ReContabilizarTiposdeGanado(CorralReciba, True, Trans)
        Me.RealizarSalidaoEntradadeCorral(CorralReciba, True, Trans)
        Me.RegistrarMovimientoDeGanadoParaSalidaGanado(CorralReciba, True, Trans)
        Me.GuardarSalidaDeGanado(CorralReciba, False, Trans)

        If CorralReciba.Corral.TotalCabezas <= 0 Then
            Trans.Commit()
            Trans = New HC.Transaction(IsolationLevel.ReadCommitted, "Reiniciar Corral Reciba")
            Me.ReiniciarCorralDeReciba(CorralReciba.Corral, CorralReciba.Folio, Fecha, Trans)
        End If
    End Sub

    Public Sub RealizarSalidadeRecibaaMuerte(ByRef CorralReciba As SalidaGanadoCabeceroClass, ByVal Fecha As Date, ByVal Aviso As String, ByVal IdCausaMuerte As Short, ByVal Recuperacion As Boolean, ByRef Trans As HC.Transaction)
        CorralReciba.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Reciba_por_Muerte
        CorralReciba.Aviso = Aviso
        CorralReciba.IdCausaMuerte = IdCausaMuerte
        CorralReciba.Recuperacion = Recuperacion
        CorralReciba.Fecha = Fecha
        ValidarCorralReciba(CorralReciba)
        Me.ReContabilizarTiposdeGanado(CorralReciba, True, Trans)
        Me.RealizarSalidaoEntradadeCorral(CorralReciba, True, Trans)
        Me.RegistrarMovimientoDeGanadoParaSalidaGanado(CorralReciba, True, Trans)
        Me.GuardarSalidaDeGanado(CorralReciba, False, Trans)

        If CorralReciba.Corral.TotalCabezas <= 0 Then
            Trans.Commit()
            Trans = New HC.Transaction(IsolationLevel.ReadCommitted, "Reiniciar Corral Reciba")
            Me.ReiniciarCorralDeReciba(CorralReciba.Corral, CorralReciba.Folio, Fecha, Trans)
        End If
    End Sub

    Public Sub RealizarSalidadeRecibaaCorral(ByRef CorralReciba As SalidaGanadoCabeceroClass, ByVal Fecha As Date, ByRef Trans As HC.Transaction)
        CorralReciba.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Transferencia_de_Reciba_a_Corral
        CorralReciba.Fecha = Fecha
        ValidarCorralReciba(CorralReciba)
        Me.RealizarSalidaoEntradadeCorral(CorralReciba, True, Trans)
        Me.RegistrarMovimientoDeGanadoParaSalidaGanado(CorralReciba, True, Trans)
        Me.RealizarEntradaoSalidaCorralDestino(CorralReciba, True, Trans)
        Me.GuardarSalidaDeGanado(CorralReciba, False, Trans, Me.Configuracion.Engorda.RequerirArete)
        Me.RealizarTraspasoRecibaLote(CorralReciba, True, Trans)

        If CorralReciba.Corral.TotalCabezas <= 0 Then
            Trans.Commit()
            Trans = New HC.Transaction(IsolationLevel.ReadCommitted, "Reiniciar Corral Reciba")
            Me.ReiniciarCorralDeReciba(CorralReciba.Corral, CorralReciba.Folio, Fecha, Trans)
        End If
    End Sub

    Public Sub RealizarSalidadeCorralaRastro(ByRef SalidaGanado As SalidaGanadoCabeceroClass, ByVal Fecha As Date, ByRef Trans As HC.Transaction)
        SalidaGanado.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_a_Rastro
        SalidaGanado.Fecha = Fecha
        ValidarCorralReciba(SalidaGanado)
        Me.ReContabilizarTiposdeGanado(SalidaGanado, True, Trans)
        Me.RegistrarMovimientoDeGanadoParaSalidaGanado(SalidaGanado, True, Trans)
        Me.GuardarSalidaDeGanado(SalidaGanado, False, Trans)
        Me.RealizarSalidaoEntradadeLotes(SalidaGanado, True, Trans)
        Me.GenerarMovimientoSacrificio(SalidaGanado, Trans)

        For Each SalidaGanadoDetalle As SalidaGanadoDetalleClass In SalidaGanado.Detalles
            Me.ActualizarSalidaDeAreteDeCorral(SalidaGanadoDetalle.Lote.IdCorral, SalidaGanadoDetalle.IdTipoGanado, SalidaGanadoDetalle.Cabezas, SalidaGanadoDetalle.Kilos, SalidaGanadoDetalle.CostoEntrada * SalidaGanadoDetalle.Kilos, SalidaGanadoDetalle.CostoAlimento * SalidaGanadoDetalle.Kilos, SalidaGanadoDetalle.CostoMedicina * SalidaGanadoDetalle.Kilos, SalidaGanadoDetalle.KilosAlimento * SalidaGanadoDetalle.Kilos, SalidaGanadoDetalle.CostoIndirecto * SalidaGanadoDetalle.Kilos, Trans)
        Next
    End Sub

    Public Sub RealizarSalidadeCorralaVenta(ByRef SalidaGanado As SalidaGanadoCabeceroClass, ByVal Fecha As Date, ByRef Trans As HC.Transaction)
        SalidaGanado.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_a_Venta
        SalidaGanado.Fecha = Fecha
        ValidarCorralReciba(SalidaGanado)
        Me.ReContabilizarTiposdeGanado(SalidaGanado, True, Trans)
        Me.RegistrarMovimientoDeGanadoParaSalidaGanado(SalidaGanado, True, Trans)
        Me.GuardarSalidaDeGanado(SalidaGanado, False, Trans)
        Me.RealizarSalidaoEntradadeLotes(SalidaGanado, True, Trans)

        For Each SalidaGanadoDetalle As SalidaGanadoDetalleClass In SalidaGanado.Detalles
            Me.ActualizarSalidaDeAreteDeCorral(SalidaGanadoDetalle.Lote.IdCorral, SalidaGanadoDetalle.IdTipoGanado, SalidaGanadoDetalle.Cabezas, SalidaGanadoDetalle.Kilos, SalidaGanadoDetalle.CostoEntrada * SalidaGanadoDetalle.Kilos, SalidaGanadoDetalle.CostoAlimento * SalidaGanadoDetalle.Kilos, SalidaGanadoDetalle.CostoMedicina * SalidaGanadoDetalle.Kilos, SalidaGanadoDetalle.KilosAlimento * SalidaGanadoDetalle.Kilos, SalidaGanadoDetalle.CostoIndirecto * SalidaGanadoDetalle.Kilos, Trans)
        Next
    End Sub

    Public Sub RealizarSalidadeCorralaMuerte(ByRef SalidaGanado As SalidaGanadoCabeceroClass, ByVal Fecha As Date, ByVal IdCausaMuerte As Nullable(Of Integer), ByVal NoAviso As String, ByVal Recuperacion As Boolean, ByRef Trans As HC.Transaction)
        SalidaGanado.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_por_Muerte
        SalidaGanado.Fecha = Fecha
        SalidaGanado.IdCausaMuerte = IdCausaMuerte
        SalidaGanado.Aviso = NoAviso
        SalidaGanado.Recuperacion = Recuperacion
        ValidarCorralReciba(SalidaGanado)
        Me.ReContabilizarTiposdeGanado(SalidaGanado, True, Trans)
        Me.RegistrarMovimientoDeGanadoParaSalidaGanado(SalidaGanado, True, Trans)
        Me.GuardarSalidaDeGanado(SalidaGanado, False, Trans)
        Me.RealizarSalidaoEntradadeLotes(SalidaGanado, True, Trans)

        For Each SalidaGanadoDetalle As SalidaGanadoDetalleClass In SalidaGanado.Detalles
            Me.ActualizarSalidaDeAreteDeCorral(SalidaGanadoDetalle.Lote.IdCorral, SalidaGanadoDetalle.IdTipoGanado, SalidaGanadoDetalle.Cabezas, SalidaGanadoDetalle.Kilos, SalidaGanadoDetalle.CostoEntrada * SalidaGanadoDetalle.Kilos, SalidaGanadoDetalle.CostoAlimento * SalidaGanadoDetalle.Kilos, SalidaGanadoDetalle.CostoMedicina * SalidaGanadoDetalle.Kilos, SalidaGanadoDetalle.KilosAlimento * SalidaGanadoDetalle.Kilos, SalidaGanadoDetalle.CostoIndirecto * SalidaGanadoDetalle.Kilos, Trans)
        Next
    End Sub

    Public Sub RealizarSalidadeCorralporTranferencia(ByRef SalidaGanado As SalidaGanadoCabeceroClass, ByVal IdLoteDestino As Integer, ByVal Fecha As Date, ByRef Trans As HC.Transaction)
        Dim Aretes As New LoteDetCollectionClass
        SalidaGanado.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_por_Tranferencia
        SalidaGanado.IdLoteDestino = IdLoteDestino
        SalidaGanado.Fecha = Fecha
        ValidarCorralReciba(SalidaGanado)
        Me.RegistrarMovimientoDeGanadoParaSalidaGanado(SalidaGanado, True, Trans)
        Me.GuardarSalidaDeGanado(SalidaGanado, False, Trans)

        For Each SalidaGanadoDetalle As SalidaGanadoDetalleClass In SalidaGanado.Detalles
            Aretes.Add(New LoteDetClass(SalidaGanadoDetalle.McecatLotesDet))
        Next
        Me.CambiarAretesDeLote(Fecha, SalidaGanado.LoteOrigen, SalidaGanado.LoteDestino, Aretes, Trans)
    End Sub

    Private Sub RealizarTraspasoRecibaLote(ByRef CorralReciba As SalidaGanadoCabeceroClass, ByVal EsEntrada As Boolean, ByRef Trans As HC.Transaction)
        Dim Lote As LoteClass = CorralReciba.LoteDestino, Operador As Integer = -1
        Trans.Add(Lote.Entidad)

        If EsEntrada Then
            Operador = 1
        End If

        Lote.AcumEntCab += CorralReciba.Cabezas * Operador
        Lote.AcumEntKilos += CorralReciba.Kilos * Operador
        Lote.SaldoCabezas += CorralReciba.Cabezas * Operador
        Lote.SaldoKilos += CorralReciba.Kilos * Operador
        Lote.SaldoKilosAlim += CorralReciba.KilosAlimento * Operador
        Lote.SaldoImpteAlim += CorralReciba.CostoAlimento * Operador
        Lote.SaldoimpteMed += CorralReciba.CostoMedicina * Operador
        Lote.SaldoImpte += CorralReciba.CostoEntrada * Operador
        Lote.SaldoCostoInd += CorralReciba.CostoIndirecto * Operador
        Lote.AcumImpteAlim += CorralReciba.CostoAlimento * Operador
        Lote.AcumImpteMedic += CorralReciba.CostoMedicina * Operador
        Lote.AcumKilosAlim += CorralReciba.KilosAlimento * Operador
        Lote.AcumEntImpte += CorralReciba.CostoEntrada * Operador
        Lote.Entidad.Save()

        For Each _Detalle As SalidaGanadoDetalleClass In CorralReciba.Detalles
            With _Detalle
                Dim LoteDetalle As LoteDetClass

                If EsEntrada Then
                    LoteDetalle = New LoteDetClass(.SalidaGanadoCabecero.IdLoteDestino, .IdTipoGanado, .Arete, .AreteSiniiga, .AreteTransporte, .Kilos, 0D, .SalidaGanadoCabecero.Fecha, Nothing, .KilosAlimento * .Kilos, .CostoAlimento * .Kilos, .CostoMedicina * .Kilos, Lote.GDPINI, 0D, 0D, 0D, .CostoIndirecto * .Kilos, 1, .CostoEntrada * .Kilos)
                    Trans.Add(LoteDetalle)
                    LoteDetalle.Save()
                    .IdMcecatLotesDet = LoteDetalle.IdMcecatLotesDet
                    Trans.Add(_Detalle)
                    _Detalle.Save()
                Else
                    LoteDetalle = New LoteDetClass(.McecatLotesDet)
                    .IdMcecatLotesDet = Nothing
                    Trans.Add(_Detalle)
                    _Detalle.Save()

                    If Not LoteDetalle.IsNew Then
                        Trans.Add(LoteDetalle)
                        LoteDetalle.Delete()
                    End If
                End If
            End With
        Next
    End Sub

    Private Sub RealizarEntradaoSalidaCorralDestino(ByRef CorralReciba As SalidaGanadoCabeceroClass, ByVal EsEntrada As Boolean, ByRef Trans As HC.Transaction)
        Dim Operador As Integer = IIf(EsEntrada, 1, -1)

        For Each detalle As SalidaGanadoDetalleClass In CorralReciba.Detalles
            Dim CorralDetalleDes As CorralDetalleClass = Nothing

            For Each CorralDestinoDetalle As CorralDetalleClass In CorralReciba.LoteDestino.Corral.Detalle
                If detalle.IdTipoGanado = CorralDestinoDetalle.IdTipoGanado Then
                    CorralDetalleDes = CorralDestinoDetalle
                    Exit For
                End If
            Next

            If EsEntrada AndAlso CorralDetalleDes Is Nothing Then
                CorralDetalleDes = New CorralDetalleClass()
                CorralReciba.LoteDestino.Corral.Detalle.Add(CorralDetalleDes)
                CorralDetalleDes.IdCorral = CorralReciba.LoteDestino.Corral.IdCorral
                CorralDetalleDes.IdTipoGanado = detalle.IdTipoGanado
            End If

            If EsEntrada Then
                CorralDetalleDes.FechaUltEnt = Now
            Else
                CorralDetalleDes.FEchaUltSal = Now
            End If

            CorralDetalleDes.ExistCabezas += detalle.Cabezas * Operador
            CorralDetalleDes.ExistKilos += detalle.Kilos * Operador
            CorralDetalleDes.CostoEnt += detalle.CostoEntrada * detalle.Kilos * Operador
            CorralDetalleDes.ImpteAlimento += detalle.CostoAlimento * detalle.Kilos * Operador
            CorralDetalleDes.ImpteMedicamento += detalle.CostoMedicina * detalle.Kilos * Operador
            CorralDetalleDes.KilosAlimento += detalle.KilosAlimento * detalle.Kilos * Operador
            CorralDetalleDes.SaldoCostoInd += detalle.CostoIndirecto * detalle.Kilos * Operador
        Next
        Trans.Add(CorralReciba.LoteDestino.Corral.Detalle.ObtenerColeccion())
        CorralReciba.LoteDestino.Corral.Detalle.ObtenerColeccion().SaveMulti()
    End Sub

    Public Sub CancelarSalidadeRecibaaRastro(ByRef CorralReciba As SalidaGanadoCabeceroClass, ByRef Detalles As SalidaGanadoDetalleCollectionClass, ByRef Trans As HC.Transaction)
        If Not CorralReciba.IsNew AndAlso CorralReciba.Estatus = SalidaGanadoCabeceroClass.EstatusSalida.CANCELADO Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 0)
        Else
            Me.ReContabilizarTiposdeGanado(CorralReciba, False, Trans)
            Me.RealizarSalidaoEntradadeCorral(CorralReciba, False, Trans)
            Me.RegistrarMovimientoDeGanadoParaSalidaGanado(CorralReciba, False, Trans)
            Me.GuardarSalidaDeGanado(CorralReciba, True, Trans)
            Me.CancelarMovimientoSacrificio(CorralReciba, Trans)
        End If
    End Sub

    Public Sub CancelarSalidadeRecibaaVenta(ByRef CorralReciba As SalidaGanadoCabeceroClass, ByRef Detalles As SalidaGanadoDetalleCollectionClass, ByRef Trans As HC.Transaction)
        If Not CorralReciba.IsNew AndAlso CorralReciba.Estatus = SalidaGanadoCabeceroClass.EstatusSalida.CANCELADO Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 0)
        Else
            Me.ReContabilizarTiposdeGanado(CorralReciba, False, Trans)
            Me.RealizarSalidaoEntradadeCorral(CorralReciba, False, Trans)
            Me.RegistrarMovimientoDeGanadoParaSalidaGanado(CorralReciba, False, Trans)
            Me.GuardarSalidaDeGanado(CorralReciba, True, Trans)
        End If
    End Sub

    Public Sub CancelarSalidadeRecibaaMuerte(ByRef CorralReciba As SalidaGanadoCabeceroClass, ByRef Detalles As SalidaGanadoDetalleCollectionClass, ByRef Trans As HC.Transaction)
        If Not CorralReciba.IsNew AndAlso CorralReciba.Estatus = SalidaGanadoCabeceroClass.EstatusSalida.CANCELADO Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 0)
        Else
            Me.ReContabilizarTiposdeGanado(CorralReciba, False, Trans)
            Me.RealizarSalidaoEntradadeCorral(CorralReciba, False, Trans)
            Me.RegistrarMovimientoDeGanadoParaSalidaGanado(CorralReciba, False, Trans)
            Me.GuardarSalidaDeGanado(CorralReciba, True, Trans)
        End If
    End Sub

    Public Sub CancelarSalidadeRecibaaCorral(ByRef CorralReciba As SalidaGanadoCabeceroClass, ByRef Detalles As SalidaGanadoDetalleCollectionClass, ByRef Trans As HC.Transaction)
        If Not CorralReciba.IsNew AndAlso CorralReciba.Estatus = SalidaGanadoCabeceroClass.EstatusSalida.CANCELADO Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 0)
        Else
            Me.RealizarSalidaoEntradadeCorral(CorralReciba, False, Trans)
            Me.RegistrarMovimientoDeGanadoParaSalidaGanado(CorralReciba, False, Trans)
            Me.RealizarEntradaoSalidaCorralDestino(CorralReciba, False, Trans)
            Me.GuardarSalidaDeGanado(CorralReciba, True, Trans)
            Me.RealizarTraspasoRecibaLote(CorralReciba, False, Trans)
        End If
    End Sub

    Public Sub CancelarSalidaDeCorralARastro(ByRef CorralReciba As SalidaGanadoCabeceroClass, ByRef Trans As HC.Transaction)
        If Not CorralReciba.IsNew AndAlso CorralReciba.Estatus = SalidaGanadoCabeceroClass.EstatusSalida.CANCELADO Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 0)
        Else
            Me.ReContabilizarTiposdeGanado(CorralReciba, False, Trans)
            Me.RegistrarMovimientoDeGanadoParaSalidaGanado(CorralReciba, False, Trans)
            Me.GuardarSalidaDeGanado(CorralReciba, True, Trans)
            Me.RealizarSalidaoEntradadeLotes(CorralReciba, False, Trans)
            Me.CancelarMovimientoSacrificio(CorralReciba, Trans)

            For Each SalidaGanadoDetalle As SalidaGanadoDetalleClass In CorralReciba.Detalles
                Me.ActualizarEntradaDeAreteACorral(SalidaGanadoDetalle.Lote.IdCorral, SalidaGanadoDetalle.IdTipoGanado, SalidaGanadoDetalle.Cabezas, SalidaGanadoDetalle.Kilos, SalidaGanadoDetalle.CostoEntrada * SalidaGanadoDetalle.Kilos, SalidaGanadoDetalle.CostoAlimento * SalidaGanadoDetalle.Kilos, SalidaGanadoDetalle.CostoMedicina * SalidaGanadoDetalle.Kilos, SalidaGanadoDetalle.KilosAlimento * SalidaGanadoDetalle.Kilos, SalidaGanadoDetalle.CostoIndirecto * SalidaGanadoDetalle.Kilos, Trans)
            Next
        End If
    End Sub

    Public Sub CancelarSalidaDeCorralAVenta(ByRef CorralReciba As SalidaGanadoCabeceroClass, ByRef Trans As HC.Transaction)
        If Not CorralReciba.IsNew AndAlso CorralReciba.Estatus = SalidaGanadoCabeceroClass.EstatusSalida.CANCELADO Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 0)
        Else
            Me.ReContabilizarTiposdeGanado(CorralReciba, False, Trans)
            Me.RegistrarMovimientoDeGanadoParaSalidaGanado(CorralReciba, False, Trans)
            Me.GuardarSalidaDeGanado(CorralReciba, True, Trans)
            Me.RealizarSalidaoEntradadeLotes(CorralReciba, False, Trans)

            For Each SalidaGanadoDetalle As SalidaGanadoDetalleClass In CorralReciba.Detalles
                Me.ActualizarEntradaDeAreteACorral(SalidaGanadoDetalle.Lote.IdCorral, SalidaGanadoDetalle.IdTipoGanado, SalidaGanadoDetalle.Cabezas, SalidaGanadoDetalle.Kilos, SalidaGanadoDetalle.CostoEntrada * SalidaGanadoDetalle.Kilos, SalidaGanadoDetalle.CostoAlimento * SalidaGanadoDetalle.Kilos, SalidaGanadoDetalle.CostoMedicina * SalidaGanadoDetalle.Kilos, SalidaGanadoDetalle.KilosAlimento * SalidaGanadoDetalle.Kilos, SalidaGanadoDetalle.CostoIndirecto * SalidaGanadoDetalle.Kilos, Trans)
            Next
        End If
    End Sub

    Public Sub CancelarSalidaDeCorralAMuerte(ByRef CorralReciba As SalidaGanadoCabeceroClass, ByRef Trans As HC.Transaction)
        If Not CorralReciba.IsNew AndAlso CorralReciba.Estatus = SalidaGanadoCabeceroClass.EstatusSalida.CANCELADO Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 0)
        Else
            Me.ReContabilizarTiposdeGanado(CorralReciba, False, Trans)
            Me.RegistrarMovimientoDeGanadoParaSalidaGanado(CorralReciba, False, Trans)
            Me.GuardarSalidaDeGanado(CorralReciba, True, Trans)
            Me.RealizarSalidaoEntradadeLotes(CorralReciba, False, Trans)

            For Each SalidaGanadoDetalle As SalidaGanadoDetalleClass In CorralReciba.Detalles
                Me.ActualizarEntradaDeAreteACorral(SalidaGanadoDetalle.Lote.IdCorral, SalidaGanadoDetalle.IdTipoGanado, SalidaGanadoDetalle.Cabezas, SalidaGanadoDetalle.Kilos, SalidaGanadoDetalle.CostoEntrada * SalidaGanadoDetalle.Kilos, SalidaGanadoDetalle.CostoAlimento * SalidaGanadoDetalle.Kilos, SalidaGanadoDetalle.CostoMedicina * SalidaGanadoDetalle.Kilos, SalidaGanadoDetalle.KilosAlimento * SalidaGanadoDetalle.Kilos, SalidaGanadoDetalle.CostoIndirecto * SalidaGanadoDetalle.Kilos, Trans)
            Next
        End If
    End Sub

    Public Sub CancelarSalidaDeCorralporTranferencia(ByRef SalidaGanado As SalidaGanadoCabeceroClass, ByRef Trans As HC.Transaction)
        If Not SalidaGanado.IsNew AndAlso SalidaGanado.Estatus = SalidaGanadoCabeceroClass.EstatusSalida.CANCELADO Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 0)
        Else
            Dim Aretes As New LoteDetCollectionClass()
            Me.RegistrarMovimientoDeGanadoParaSalidaGanado(SalidaGanado, False, Trans)
            Me.GuardarSalidaDeGanado(SalidaGanado, True, Trans)

            For Each SalidaGanadoDetalle As SalidaGanadoDetalleClass In SalidaGanado.Detalles
                Aretes.Add(New LoteDetClass(SalidaGanadoDetalle.McecatLotesDet))
            Next
            Me.CancelarCambiarAretesDeLote(SalidaGanado.Fecha, SalidaGanado.LoteDestino, SalidaGanado.LoteOrigen, Aretes, Trans)
        End If
    End Sub

    Public Sub ModificarPreciosClientes(ByVal ListaClientes As List(Of Integer), ByVal NuevoPrecio As Decimal, ByVal Trans As SqlTransaction)
        Dim Query1 As String = "DELETE CatPrexProd"
        Dim Query2 As String = Query1.Replace("CatPrexProd", "CatPrexCort")
        Dim Query3 As String = "INSERT INTO CatPrexProd SELECT MFacCatClientes.IdCliente, IdPuntoEntrega, IdProducto, '" & NuevoPrecio & "' FROM MGRALCatPuntosEntrega CROSS JOIN MSCCatProductos INNER JOIN MFacCatClientes ON MFacCatClientes.IdCliente = MGRALCatPuntosEntrega.IdCliente " & _
            "WHERE MFacCatClientes.Estatus = 1 AND MSCCatProductos.Estatus = 1 AND MGRALCatPuntosEntrega.Estatus = 'V' AND Corte = 0"
        Dim Query4 As String = "INSERT INTO CatPrexCort SELECT MFacCatClientes.IdCliente, IdPuntoEntrega, IdPreCorte, IdProducto, '" & NuevoPrecio & "' FROM MGRALCatPuntosEntrega CROSS JOIN MSCCatProductos INNER JOIN MFacCatClientes ON MFacCatClientes.IdCliente = MGRALCatPuntosEntrega.IdCliente INNER JOIN MSCCortesPreCortes ON MSCCortesPreCortes.IdCorte = MSCCatProductos.IdProducto " & _
            "WHERE MFacCatClientes.Estatus = 1 AND MSCCatProductos.Estatus = 1 AND MGRALCatPuntosEntrega.Estatus = 'V' AND Corte = 1"
        Dim ParametrosIn As New System.Text.StringBuilder(" in (")
        Dim Comando As New SqlCommand("", Trans.Connection)
        Comando.CommandTimeout = 60
        Comando.Transaction = Trans

        If ListaClientes Is Nothing Then
            Comando.CommandText = Query1
            Comando.ExecuteNonQuery()
            Comando.CommandText = Query2
            Comando.ExecuteNonQuery()
            Comando.CommandText = Query3
            Comando.ExecuteNonQuery()
            Comando.CommandText = Query4
            Comando.ExecuteNonQuery()
            Exit Sub
        End If
        ParametrosIn.Append(ListaClientes(0).ToString())

        For i As Integer = 1 To ListaClientes.Count - 1
            ParametrosIn.Append("," & ListaClientes(i).ToString())

            If i + 1 Mod 2000D = 0 Then
                Dim WhereCliente1 As String = " WHERE Cve_Cliente" & ParametrosIn.ToString() & ")"
                Dim WhereCliente2 As String = " AND MFacCatClientes.IdCliente" & ParametrosIn.ToString() & ")"
                Comando.CommandText = Query1 & WhereCliente1
                Comando.ExecuteNonQuery()
                Comando.CommandText = Query2 & WhereCliente1
                Comando.ExecuteNonQuery()
                Comando.CommandText = Query3 & WhereCliente2
                Comando.ExecuteNonQuery()
                Comando.CommandText = Query4 & WhereCliente2
                Comando.ExecuteNonQuery()

                If ListaClientes.Count - 1 > i Then
                    ParametrosIn = New System.Text.StringBuilder(" in (" & ListaClientes(i + 1).ToString())
                Else
                    ParametrosIn = Nothing
                End If
            End If
        Next

        If ParametrosIn IsNot Nothing Then
            Dim WhereCliente1 As String = " WHERE Cve_Cliente" & ParametrosIn.ToString() & ")"
            Dim WhereCliente2 As String = " AND MFacCatClientes.IdCliente" & ParametrosIn.ToString() & ")"
            Comando.CommandText = Query1 & WhereCliente1
            Comando.ExecuteNonQuery()
            Comando.CommandText = Query2 & WhereCliente1
            Comando.ExecuteNonQuery()
            Comando.CommandText = Query3 & WhereCliente2
            Comando.ExecuteNonQuery()
            Comando.CommandText = Query4 & WhereCliente2
            Comando.ExecuteNonQuery()
        End If
    End Sub

    Public Sub AumentarPreciosClientes(ByVal ListaClientes As List(Of Integer), ByVal Porcentaje As Decimal, ByVal Trans As SqlTransaction)
        Dim Query1 As String = "UPDATE cpp SET cpp.PrecioxKgr = ISNULL((SELECT TOP 1 PrecioxKgr FROM catprexprod WHERE Cve_ProdRas = MSCCatProductos.IdProducto AND PrecioxKgr IN (SELECT DISTINCT(cpxp.PrecioxKgr) FROM catprexprod AS cpxp WHERE cpxp.Cve_ProdRas = Cve_ProdRas) GROUP BY PrecioxKgr ORDER BY count(PrecioxKgr) desc),0) *" & 1 + Porcentaje / 100 & _
            " FROM MGRALCatPuntosEntrega CROSS JOIN MSCCatProductos INNER JOIN MFacCatClientes ON MFacCatClientes.IdCliente = MGRALCatPuntosEntrega.IdCliente " & _
            "INNER JOIN CatPrexProd AS cpp ON MFacCatClientes.IdCliente = cpp.Cve_Cliente AND IdPuntoEntrega = cpp.Cve_Destino AND IdProducto = cpp.Cve_ProdRas " & _
            "WHERE MFacCatClientes.Estatus = 1 AND MSCCatProductos.Estatus = 1 AND MGRALCatPuntosEntrega.Estatus = 'V' AND Corte = 0"
        Dim Query2 As String = "UPDATE cpc SET cpc.PrecioxKgr = ISNULL((SELECT TOP 1 PrecioxKgr FROM catprexcort WHERE Cve_SubCorte = MSCCatProductos.IdProducto AND PrecioxKgr IN (SELECT DISTINCT(cpxc.PrecioxKgr) FROM catprexcort AS cpxc WHERE cpxc.Cve_SubCorte = Cve_SubCorte) GROUP BY PrecioxKgr ORDER BY count(PrecioxKgr) desc),0) *" & 1 + Porcentaje / 100 & _
            " FROM MGRALCatPuntosEntrega CROSS JOIN MSCCatProductos INNER JOIN MFacCatClientes ON MFacCatClientes.IdCliente = MGRALCatPuntosEntrega.IdCliente INNER JOIN MSCCortesPreCortes ON MSCCortesPreCortes.IdCorte = MSCCatProductos.IdProducto " & _
            "INNER JOIN CatPrexCort AS cpc ON MFacCatClientes.IdCliente = cpc.Cve_Cliente AND IdPuntoEntrega = cpc.Cve_Destino AND IdProducto = cpc.Cve_SubCorte " & _
            "WHERE MFacCatClientes.Estatus = 1 AND MSCCatProductos.Estatus = 1 AND MGRALCatPuntosEntrega.Estatus = 'V' AND Corte = 1"
        Dim Query3 As String = "INSERT INTO CatPrexProd SELECT MFacCatClientes.IdCliente, IdPuntoEntrega, IdProducto, ISNULL((SELECT TOP 1 PrecioxKgr FROM catprexprod WHERE Cve_ProdRas = MSCCatProductos.IdProducto AND PrecioxKgr IN (SELECT DISTINCT(cpxp.PrecioxKgr) FROM catprexprod AS cpxp WHERE cpxp.Cve_ProdRas = Cve_ProdRas) GROUP BY PrecioxKgr ORDER BY count(PrecioxKgr) desc),0) *" & 1 + Porcentaje / 100 & _
            " FROM MGRALCatPuntosEntrega CROSS JOIN MSCCatProductos INNER JOIN MFacCatClientes ON MFacCatClientes.IdCliente = MGRALCatPuntosEntrega.IdCliente " & _
            "WHERE MFacCatClientes.Estatus = 1 AND MSCCatProductos.Estatus = 1 AND MGRALCatPuntosEntrega.Estatus = 'V' AND Corte = 0 AND NOT EXISTS(SELECT * FROM CatPrexProd WHERE CatPrexProd.Cve_Cliente = MFacCatClientes.IdCliente AND CatPrexProd.Cve_Destino = IdPuntoEntrega AND CatPrexProd.Cve_ProdRas = IdProducto)"
        Dim Query4 As String = "INSERT INTO CatPrexCort SELECT MFacCatClientes.IdCliente, IdPuntoEntrega, IdPreCorte, IdProducto, ISNULL((SELECT TOP 1 PrecioxKgr FROM catprexcort WHERE Cve_SubCorte = MSCCatProductos.IdProducto AND PrecioxKgr IN (SELECT DISTINCT(cpxc.PrecioxKgr) FROM catprexcort AS cpxc WHERE cpxc.Cve_SubCorte = Cve_SubCorte) GROUP BY PrecioxKgr ORDER BY count(PrecioxKgr) desc),0) *" & 1 + Porcentaje / 100 & _
            " FROM MGRALCatPuntosEntrega CROSS JOIN MSCCatProductos INNER JOIN MFacCatClientes ON MFacCatClientes.IdCliente = MGRALCatPuntosEntrega.IdCliente INNER JOIN MSCCortesPreCortes ON MSCCortesPreCortes.IdCorte = MSCCatProductos.IdProducto " & _
            "WHERE MFacCatClientes.Estatus = 1 AND MSCCatProductos.Estatus = 1 AND MGRALCatPuntosEntrega.Estatus = 'V' AND Corte = 1 AND NOT EXISTS(SELECT * FROM CatPrexCort WHERE CatPrexCort.Cve_Cliente = MFacCatClientes.IdCliente AND CatPrexCort.Cve_Destino = IdPuntoEntrega AND CatPrexCort.Cve_SubCorte = IdProducto)"
        Dim ParametrosIn As New System.Text.StringBuilder(" in (")
        Dim Comando As New SqlCommand("", Trans.Connection)
        Comando.CommandTimeout = 60
        Comando.Transaction = Trans

        If ListaClientes Is Nothing Then
            Comando.CommandText = Query1
            Comando.ExecuteNonQuery()
            Comando.CommandText = Query2
            Comando.ExecuteNonQuery()
            Comando.CommandText = Query3
            Comando.ExecuteNonQuery()
            Comando.CommandText = Query4
            Comando.ExecuteNonQuery()
            Exit Sub
        End If
        ParametrosIn.Append(ListaClientes(0).ToString())

        For i As Integer = 1 To ListaClientes.Count - 1
            ParametrosIn.Append("," & ListaClientes(i).ToString())

            If i + 1 Mod 2000D = 0 Then
                Dim WhereCliente As String = " AND MFacCatClientes.IdCliente" & ParametrosIn.ToString() & ")"
                Comando.CommandText &= WhereCliente
                Comando.CommandText = Query1 & WhereCliente
                Comando.ExecuteNonQuery()
                Comando.CommandText = Query2 & WhereCliente
                Comando.ExecuteNonQuery()
                Comando.CommandText = Query3 & WhereCliente
                Comando.ExecuteNonQuery()
                Comando.CommandText = Query4 & WhereCliente
                Comando.ExecuteNonQuery()

                If ListaClientes.Count - 1 > i Then
                    ParametrosIn = New System.Text.StringBuilder(" in (" & ListaClientes(i + 1).ToString())
                Else
                    ParametrosIn = Nothing
                End If
            End If
        Next

        If ParametrosIn IsNot Nothing Then
            Dim WhereCliente As String = " AND MFacCatClientes.IdCliente" & ParametrosIn.ToString() & ")"
            Comando.CommandText &= WhereCliente
            Comando.CommandText = Query1 & WhereCliente
            Comando.ExecuteNonQuery()
            Comando.CommandText = Query2 & WhereCliente
            Comando.ExecuteNonQuery()
            Comando.CommandText = Query3 & WhereCliente
            Comando.ExecuteNonQuery()
            Comando.CommandText = Query4 & WhereCliente
            Comando.ExecuteNonQuery()
        End If
    End Sub

    Public Sub ModificarPreciosClientes(ByVal ProductosPrecios As dsCatPrecios.CatPrexProdDataTable, ByVal Trans As SqlTransaction)
        Dim ComandoEliminar As New SqlCommand("DELETE CatPrexProd WHERE Cve_Cliente = @IdCliente AND Cve_Destino = @IdPuntoEntrega AND Cve_ProdRas = @IdProducto ", Trans.Connection)
        Dim ComandoInsertar As New SqlCommand("INSERT INTO CatPrexProd ([Cve_Cliente], [Cve_Destino], [Cve_ProdRas], [PrecioxKgr])" & _
            " VALUES (@IdCliente, @IdPuntoEntrega, @IdProducto, @PrecioxKgr)", Trans.Connection)
        Dim ElimIdCliente As New SqlParameter("@IdCliente", SqlDbType.SmallInt, 32767)
        Dim ElimIdPuntoEntrega As New SqlParameter("@IdPuntoEntrega", SqlDbType.SmallInt, 32767)
        Dim ElimIdProducto As New SqlParameter("@IdProducto", SqlDbType.SmallInt, 32767)
        Dim InstIdCliente As New SqlParameter("@IdCliente", SqlDbType.SmallInt, 32767)
        Dim InstIdPuntoEntrega As New SqlParameter("@IdPuntoEntrega", SqlDbType.SmallInt, 32767)
        Dim InstIdProducto As New SqlParameter("@IdProducto", SqlDbType.SmallInt, 32767)
        Dim InstPrecioxKgr As New SqlParameter("@PrecioxKgr", SqlDbType.SmallMoney, 214748.3647)
        ComandoEliminar.Transaction = Trans
        ComandoInsertar.Transaction = Trans
        ComandoEliminar.Parameters.AddRange(New SqlParameter() {ElimIdCliente, ElimIdPuntoEntrega, ElimIdProducto})
        ComandoInsertar.Parameters.AddRange(New SqlParameter() {InstIdCliente, InstIdPuntoEntrega, InstIdProducto, InstPrecioxKgr})
        ComandoEliminar.Prepare()
        ComandoInsertar.Prepare()

        For Each Renglon As dsCatPrecios.CatPrexProdRow In ProductosPrecios.Rows
            ElimIdCliente.Value = Renglon.IdCliente
            ElimIdPuntoEntrega.Value = Renglon.IdPuntoEntrega
            ElimIdProducto.Value = Renglon.IdProducto
            ComandoEliminar.ExecuteNonQuery()
            InstIdCliente.Value = Renglon.IdCliente
            InstIdPuntoEntrega.Value = Renglon.IdPuntoEntrega
            InstIdProducto.Value = Renglon.IdProducto
            InstPrecioxKgr.Value = Renglon.PrecioxKgr
            ComandoInsertar.ExecuteNonQuery()
        Next
    End Sub

    Public Sub ModificarPreciosClientes(ByVal ProductosPrecios As dsCatPrecios.CatPrexCortDataTable, ByVal Trans As SqlTransaction)
        Dim ComandoEliminar As New SqlCommand("DELETE CatPrexCort WHERE Cve_Cliente = @IdCliente AND Cve_Destino = @IdPuntoEntrega AND Cve_SubCorte = @IdCorte ", Trans.Connection)
        Dim ComandoInsertar As New SqlCommand("INSERT INTO CatPrexCort ([Cve_Cliente], [Cve_Destino], [Cve_Corte], [Cve_SubCorte], [PrecioxKgr])" & _
            " VALUES (@IdCliente, @IdPuntoEntrega, @IdPreCorte, @IdCorte, @PrecioxKgr)", Trans.Connection)
        Dim ElimIdCliente As New SqlParameter("@IdCliente", SqlDbType.SmallInt, 32767)
        Dim ElimIdPuntoEntrega As New SqlParameter("@IdPuntoEntrega", SqlDbType.SmallInt, 32767)
        Dim ElimIdCorte As New SqlParameter("@IdCorte", SqlDbType.SmallInt, 32767)
        Dim InstIdCliente As New SqlParameter("@IdCliente", SqlDbType.SmallInt, 32767)
        Dim InstIdPuntoEntrega As New SqlParameter("@IdPuntoEntrega", SqlDbType.SmallInt, 32767)
        Dim InstIdPreCorte As New SqlParameter("@IdPreCorte", SqlDbType.SmallInt, 32767)
        Dim InstIdCorte As New SqlParameter("@IdCorte", SqlDbType.SmallInt, 32767)
        Dim InstPrecioxKgr As New SqlParameter("@PrecioxKgr", SqlDbType.SmallMoney, 214748.3647)
        ComandoEliminar.Transaction = Trans
        ComandoInsertar.Transaction = Trans
        ComandoEliminar.Parameters.AddRange(New SqlParameter() {ElimIdCliente, ElimIdPuntoEntrega, ElimIdCorte})
        ComandoInsertar.Parameters.AddRange(New SqlParameter() {InstIdCliente, InstIdPuntoEntrega, InstIdPreCorte, InstIdCorte, InstPrecioxKgr})
        ComandoEliminar.Prepare()
        ComandoInsertar.Prepare()

        For Each Renglon As dsCatPrecios.CatPrexCortRow In ProductosPrecios.Rows
            ElimIdCliente.Value = Renglon.IdCliente
            ElimIdPuntoEntrega.Value = Renglon.IdPuntoEntrega
            ElimIdCorte.Value = Renglon.IdProducto
            ComandoEliminar.ExecuteNonQuery()
            InstIdCliente.Value = Renglon.IdCliente
            InstIdPuntoEntrega.Value = Renglon.IdPuntoEntrega
            InstIdPreCorte.Value = Renglon.IdPreCorte
            InstIdCorte.Value = Renglon.IdProducto
            InstPrecioxKgr.Value = Renglon.PrecioxKgr
            ComandoInsertar.ExecuteNonQuery()
        Next
    End Sub

    'Funciones para la facturación de ventas
    Public Sub RealizarFacturasdeVenta(ByRef FacturasCabecero As FacturasClass, ByVal Fecha As Date, ByVal Tipo As TipoFacturaEnum, ByRef Trans As HC.Transaction)
        FacturasCabecero.TipoFactura = Tipo
        FacturasCabecero.FechaCaptura = Fecha
        Me.GuardarFacturasdeVenta(FacturasCabecero, False, Trans)
    End Sub

    Public Sub RealizarFacturasdeVentaenDetalle(ByRef FacturasDetalle As FacturasDetalleClass, ByVal NoFactura As String, ByRef Trans As HC.Transaction)
        FacturasDetalle.NoFactura = NoFactura
        Me.GuardarFacturasdeVentaenDetalle(FacturasDetalle, False, Trans)
    End Sub

    Private Sub GuardarFacturasdeVenta(ByRef FacturasCabecero As FacturasClass, ByVal EsCancelacion As Boolean, ByRef Trans As HC.Transaction)
        If Not EsCancelacion Then
            If FacturasCabecero.Estatus = "P" Then
                FacturasCabecero.Pagar(Trans)
            Else
                If FacturasCabecero.Estatus = "A" Then
                    FacturasCabecero.Abonada(Trans)
                Else
                    FacturasCabecero.Guardar(Trans)
                End If
            End If
        Else
            FacturasCabecero.Cancelar(Trans)
        End If
    End Sub

    Public Sub ContabilizarFacturas(ByVal FacturasCab As FacturasClass, ByVal NoFactura As String, ByRef Trans As HC.Transaction)
        FacturasCab.Guardar(Trans)
    End Sub

    Private Sub GuardarFacturasdeVentaenDetalle(ByRef FacturasDetalle As FacturasDetalleClass, ByVal EsCancelacion As Boolean, ByRef Trans As HC.Transaction)
        FacturasDetalle.Guardar(Trans)
    End Sub

    Public Sub IniciarSesion(ByVal IdEmpresa As Integer, ByVal IdUsuario As Integer)
        _Sesion.Empndx = IdEmpresa
        _Sesion.Usrndx = IdUsuario
        _Sesion.Sesfecini = Now
        _Sesion.Sesact = True
        _Sesion.Save()

        HC.DbUtils.ActualConnectionString = Me.Empresa.BDConnectionString
        HC.DbUtils.CommandTimeOut = 30 * 3
    End Sub

#End Region

#Region "Metodos Obtener"

    Public Function ObtenerMonedas(ByVal Estatus As CondicionEnum) As TipoMonedaCollectionClass
        ObtenerMonedas = New TipoMonedaCollectionClass
        ObtenerMonedas.Obtener(Estatus)
        Return ObtenerMonedas
    End Function

    Public Function ObtenerSucursales(ByVal Estatus As CondicionEnum) As SucursalCollectionClass
        Dim Sucursales As New SucursalCollectionClass
        Sucursales.Obtener(Estatus)
        Return Sucursales
    End Function

    Public Function ObtenerPlazas(ByVal Estatus As CondicionEnum) As PlazaCollectionClass
        Dim Plazas As New PlazaCollectionClass
        Plazas.Obtener(Estatus)
        Return Plazas
    End Function

    Public Function ObtenerAlmacenesParaCargaInicial(ByVal Estatus As CondicionEnum) As AlmacenCollectionClass
        Dim Almacenes As New AlmacenCollectionClass

        Almacenes.Obtener(Estatus)

        For i As Integer = Almacenes.Count - 1 To 0 Step -1
            If Almacenes(i).InventarioProductosGenerales.Count > 0 OrElse Almacenes(i).Familias.Count = 0 Then
                Almacenes.RemoveAt(i)
            End If
        Next
        Return Almacenes
    End Function

    Public Function ObtenerAlmacenesDeProduccion(Optional ByVal idAlmacenesIgnorar As List(Of Integer) = Nothing) As AlmacenCollectionClass
        Dim Almacenes As New AlmacenCollectionClass

        Almacenes.ObtenerDeProduccion(idAlmacenesIgnorar)
        Return Almacenes
    End Function

    Public Function ObtenerAlmacenesConInventarioDeProductosGenerales(Optional ByVal Plazas As PlazaCollectionClass = Nothing, Optional ByVal Familias As LineaCollectionClass = Nothing) As AlmacenCollectionClass
        Dim Almacenes As New AlmacenCollectionClass, Filtro As New OC.PredicateExpression(HC.InventarioAlmacenFields.CantidadExistencia > 0)
        Dim Relacion As New OC.RelationCollection

        Relacion.Add(EC.AlmacenEntity.Relations.InventarioAlmacenEntityUsingAlmacenId)

        If Plazas IsNot Nothing AndAlso Plazas.Count > 0 Then
            Dim CodigosPlaza As New List(Of Integer)

            For Each Plaza As PlazaClass In Plazas
                CodigosPlaza.Add(Plaza.Codigo)
            Next
            Filtro.Add(New OC.FieldCompareRangePredicate(HC.AlmacenFields.Plaza, CodigosPlaza))
        End If

        If Familias IsNot Nothing AndAlso Familias.Count > 0 Then
            Dim CodigosLinea As New List(Of Integer)

            Relacion.Add(EC.InventarioAlmacenEntity.Relations.ProductoEntityUsingProductoId)
            Relacion.Add(EC.ProductoEntity.Relations.LineaEntityUsingPdIdLinea)

            For Each Familia As LineaClass In Familias
                CodigosLinea.Add(Familia.Codigo)
            Next
            Filtro.Add(New OC.FieldCompareRangePredicate(HC.ProductoFields.PdIdLinea, CodigosLinea))
        End If
        Almacenes.Obtener(Filtro, Relacion)

        For i As Integer = Almacenes.Count - 1 To 0 Step -1
            If Not Almacenes(i).InventarioProductosGenerales(0).CantidadExistencia > 0 Then
                Almacenes.RemoveAt(i)
            End If
        Next
        Return Almacenes
    End Function

    Public Function ObtenerMedicamentosConExistencia(ByRef Almacen As AlmacenClass) As ProductoCollectionClass
        ObtenerMedicamentosConExistencia = New ProductoCollectionClass

        For Each Producto As ProductoGeneralClass In Almacen.ProductosConExistencia
            If Producto.IdLinea = Me.Configuracion.Engorda.IdFamiliaMedicamento.Value Then
                ObtenerMedicamentosConExistencia.Add(Producto)
            End If
        Next
    End Function

    Public Function ObtenerFacturasDeVenta(Optional ByVal Folio As String = "", Optional ByVal Fechas As RangoFechas = Nothing, Optional ByVal Cliente As Integer = 0, Optional ByVal Estatus As EstatusChar = EstatusChar.TODOS, Optional ByVal TipoFactura As TipoFacturaEnum = TipoFacturaEnum.VENTA_DE_PRODUCTO, Optional ByVal TipoComprobante As String = "I") As FacturasCollectionClass
        Dim Filtro As OC.PredicateExpression = FiltroFacturasdeVenta(TipoFactura, Folio, Fechas, Cliente, Estatus, TipoComprobante)
        Return ObtenerFacturasdeVentayCorrales(Filtro)
    End Function


    Public Function ObtenerFacturasdeVentasParaAuxiliarContable(ByVal FechaContable As Date, Optional ByVal TipoFactura As TipoFacturaEnum = TipoFacturaEnum.VENTA_DE_PRODUCTO) As FacturasCollectionClass
        Dim Filtro As New OC.PredicateExpression
        Filtro.Add(HC.CabFacturasFields.FecConta <= FechaContable.ToShortDateString Or HC.CabFacturasFields.FecConta = DBNull.Value)
        Filtro.Add(HC.CabFacturasFields.Status <> "C")
        Filtro.Add(HC.CabFacturasFields.StaFacturacion = "N")
        Filtro.Add(HC.CabFacturasFields.TipoFactu = TipoFactura)
        Return ObtenerFacturasdeVentayCorrales(Filtro)
    End Function

    Private Function ObtenerFacturasdeVentayCorrales(ByRef Filtro As OC.PredicateExpression, Optional ByVal Relaciones As OC.RelationCollection = Nothing) As FacturasCollectionClass
        Dim FacturasVentaColeccion As New CC.CabFacturasCollection
        Dim FacturasVenta As New FacturasCollectionClass
        Dim Ordenamiento As New OC.SortExpression(New OC.SortClause(HC.CabFacturasFields.FolFactura, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))

        FacturasVentaColeccion.GetMulti(Filtro, 0, Ordenamiento, Relaciones)

        If Not FacturasVentaColeccion.Count > 0 Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 2, "No se encontraton facturas para esta opcion")
        Else
            For Each FacturaVenta As EC.CabFacturasEntity In FacturasVentaColeccion
                FacturasVenta.Add(FacturaVenta)
            Next
        End If
        Return FacturasVenta
    End Function

    Private Function FiltroFacturasdeVenta( _
    ByVal TipoFactura As TipoFacturaEnum, _
    Optional ByVal Folio As String = "", _
    Optional ByVal Fechas As RangoFechas = Nothing, _
    Optional ByVal Cliente As Integer = 0, _
    Optional ByVal Estatus As EstatusChar = EstatusChar.TODOS, _
    Optional ByVal TipoComprobante As String = "I") _
    As OC.PredicateExpression

        Dim Filtro As New OC.PredicateExpression
        Dim Relaciones As New OC.RelationCollection

        Filtro.Add(HC.CabFacturasFields.TipoFactu = TipoFactura)

        Filtro.Add(HC.CabFacturasFields.TipoComprobante = TipoComprobante)

        If Folio.Trim <> String.Empty Then
            'Folio = IIf(Folio(0) = "R", Folio.Substring(1), Folio)
            Filtro.Add(HC.CabFacturasFields.FolFactura = Folio Or HC.CabFacturasFields.Uuid = Folio)
            'Filtro.Add(HC.CabFacturasFields.Uuid = Folio)
        Else
            If Fechas IsNot Nothing Then
                If Fechas.FechaInicial.HasValue Then
                    Filtro.Add(HC.CabFacturasFields.FecFactura >= Fechas.FechaInicial)
                End If

                If Fechas.FechaFinal.HasValue Then
                    Filtro.Add(HC.CabFacturasFields.FecFactura <= Fechas.FechaFinal.Value.AddDays(1).AddMilliseconds(-1))
                End If
            End If


            If Estatus = EstatusChar.VIGENTE Then
                Filtro.Add(HC.CabFacturasFields.Status = "V")
            ElseIf Estatus = EstatusChar.CANCELADO Then
                Filtro.Add(HC.CabFacturasFields.Status = "C")
            ElseIf Estatus = EstatusChar.PAGADO Then
                Filtro.Add(HC.CabFacturasFields.Status = "P")
            ElseIf Estatus = EstatusChar.ABONADO Then
                Filtro.Add(HC.CabFacturasFields.Status = "A")
            End If



            If Cliente <> 0 Then
                Filtro.Add(HC.CabFacturasFields.CveCliente = Cliente)
            End If


            Filtro.Add(HC.CabFacturasFields.TipoFactu = TipoFactura)


        End If
        Return Filtro
    End Function

    Public Function ObtenerPagosChequesDevueltos(ByVal FechaInicial As Nullable(Of Date), ByVal FechaFinal As Nullable(Of Date), ByVal Vigentes As Boolean, ByVal Cancelados As Boolean, ByVal IdCliente As Nullable(Of Integer), Optional ByVal Folio As String = Nothing, Optional ByVal NoCheque As String = Nothing, Optional ByVal Observaciones As String = Nothing) As PagoCheDevueltoCabCollectionClass
        Dim PagosChequesDevueltos As New CC.PagoCheDevueltoCabCollection, Orden As New OC.SortExpression(New OC.SortClause(HC.PagoCheDevueltoCabFields.FechaPago, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
        Dim Filtro As New OC.PredicateExpression, FiltroEstatus As New OC.PredicateExpression, Relacion As New OC.RelationCollection

        Relacion.Add(EC.PagoCheDevueltoCabEntity.Relations.PagoCheDevueltoDetEntityUsingIdPagoCheDevueltoCab)
        Relacion.Add(EC.PagoCheDevueltoDetEntity.Relations.ChequeDevueltoEntityUsingIdChequeDevuelto)

        If FechaInicial.HasValue Then
            Filtro.Add(HC.PagoCheDevueltoCabFields.FechaPago >= FechaInicial)
        End If

        If FechaFinal.HasValue Then
            Filtro.Add(HC.PagoCheDevueltoCabFields.FechaPago <= FechaFinal)
        End If

        If NoCheque <> String.Empty Then
            Filtro.Add(HC.ChequeDevueltoFields.NoCheque Mod String.Format("%{0}%", NoCheque))
        End If

        If Observaciones <> String.Empty Then
            Filtro.Add(HC.PagoCheDevueltoCabFields.Referencia Mod String.Format("%{0}%", Observaciones))
        End If

        If Folio <> String.Empty Then
            Filtro.Add(HC.PagoCheDevueltoCabFields.Folio Mod String.Format("%{0}%", Folio))
        End If

        If IdCliente.HasValue Then
            Filtro.Add(HC.ChequeDevueltoFields.IdCliente = IdCliente.Value)
        End If

        If Vigentes Then
            FiltroEstatus.AddWithOr(HC.PagoCheDevueltoCabFields.Estatus = ChequeDevueltoClass.ChequeDevueltoEstatus.VIGENTE)
        End If

        If Cancelados Then
            FiltroEstatus.AddWithOr(HC.PagoCheDevueltoCabFields.Estatus = ChequeDevueltoClass.ChequeDevueltoEstatus.CANCELADO)
        End If

        Filtro.Add(FiltroEstatus)

        ObtenerPagosChequesDevueltos = New PagoCheDevueltoCabCollectionClass
        PagosChequesDevueltos.GetMulti(Filtro, 0, Orden, Relacion)

        For Each Pago As EC.PagoCheDevueltoCabEntity In PagosChequesDevueltos
            ObtenerPagosChequesDevueltos.Add(New PagoCheDevueltoCabClass(Pago))
        Next
        Return ObtenerPagosChequesDevueltos
    End Function

    Public Function ObtenerChequesDevueltos(ByVal FechaInicial As Nullable(Of Date), ByVal FechaFinal As Nullable(Of Date), ByVal Vigentes As Boolean, ByVal Cancelados As Boolean, ByVal Abonados As Boolean, ByVal Pagados As Boolean, ByVal IdCliente As Nullable(Of Integer), ByVal IdBanco As Nullable(Of Integer), Optional ByVal NoCheque As String = Nothing, Optional ByVal Observaciones As String = Nothing) As ChequeDevueltoCollectionClass
        Dim ChequesDevueltos As New CC.ChequeDevueltoCollection, Orden As New OC.SortExpression(New OC.SortClause(HC.ChequeDevueltoFields.FechaDevolucion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
        Dim Filtro As New OC.PredicateExpression, FiltroEstatus As New OC.PredicateExpression

        If FechaInicial.HasValue Then
            Filtro.Add(HC.ChequeDevueltoFields.FechaDevolucion >= FechaInicial)
        End If

        If FechaFinal.HasValue Then
            Filtro.Add(HC.ChequeDevueltoFields.FechaDevolucion <= FechaFinal)
        End If

        If NoCheque <> String.Empty Then
            Filtro.Add(HC.ChequeDevueltoFields.NoCheque Mod String.Format("%{0}%", NoCheque))
        End If

        If Observaciones <> String.Empty Then
            Filtro.Add(HC.ChequeDevueltoFields.Observaciones Mod String.Format("%{0}%", Observaciones))
        End If

        If IdBanco.HasValue Then
            Filtro.Add(HC.ChequeDevueltoFields.IdBanco = IdBanco.Value)
        End If

        If IdCliente.HasValue Then
            Filtro.Add(HC.ChequeDevueltoFields.IdCliente = IdCliente.Value)
        End If

        If Vigentes Then
            FiltroEstatus.AddWithOr(HC.ChequeDevueltoFields.Estatus = ChequeDevueltoClass.ChequeDevueltoEstatus.VIGENTE)
        End If

        If Cancelados Then
            FiltroEstatus.AddWithOr(HC.ChequeDevueltoFields.Estatus = ChequeDevueltoClass.ChequeDevueltoEstatus.CANCELADO)
        End If

        If Abonados Then
            FiltroEstatus.AddWithOr(HC.ChequeDevueltoFields.Estatus = ChequeDevueltoClass.ChequeDevueltoEstatus.ABONADO)
        End If

        If Pagados Then
            FiltroEstatus.AddWithOr(HC.ChequeDevueltoFields.Estatus = ChequeDevueltoClass.ChequeDevueltoEstatus.PAGADO)
        End If

        Filtro.Add(FiltroEstatus)

        ObtenerChequesDevueltos = New ChequeDevueltoCollectionClass
        ChequesDevueltos.GetMulti(Filtro, 0, Orden)

        For Each ChequeDevuelto As EC.ChequeDevueltoEntity In ChequesDevueltos
            ObtenerChequesDevueltos.Add(ChequeDevuelto)
        Next
        Return ObtenerChequesDevueltos
    End Function

    Public Function ObtenerBancos(ByVal Estatus As CondicionEnum) As BancosCollectionClass
        ObtenerBancos = New BancosCollectionClass()
        ObtenerBancos.Obtener(Estatus)
        Return ObtenerBancos
    End Function

    Public Function ObtenerLotesSinCabezasParaCerrar() As LoteCollectionClass
        Dim Filtro As New OC.PredicateExpression
        ObtenerLotesSinCabezasParaCerrar = New LoteCollectionClass()
        Filtro.Add(HC.McecatLotesCabFields.Estatus = LoteClass.EstatusLote.VIGENTE And HC.McecatLotesCabFields.SaldoCabezas <= 0)
        ObtenerLotes.Obtener(Filtro, New OC.SortExpression(New OC.SortClause(HC.McecatLotesCabFields.NombreLote, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
        Return ObtenerLotes()
    End Function

    Public Function ObtenerLineas(ByVal Estatus As CondicionEnum) As LineaCollectionClass
        ObtenerLineas = New LineaCollectionClass()
        ObtenerLineas.Obtener(Estatus)
        Return ObtenerLineas
    End Function

    Public Function ObtenerChoferes(ByVal Estatus As EstatusChar) As DataTable
        Dim Filtro As New OC.PredicateExpression()
        Dim Orden As New OC.SortExpression(New OC.SortClause(HC.McgcatChoferesFields.ApPatChofer, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
        Orden.Add(New OC.SortClause(HC.McgcatChoferesFields.ApMatChofer, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
        Orden.Add(New OC.SortClause(HC.McgcatChoferesFields.NombreChofer, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))

        If Estatus <> EstatusChar.TODOS Then
            Filtro.Add(HC.McgcatChoferesFields.Estatus = Estatus)
        End If
        Return CC.McgcatChoferesCollection.GetMultiAsDataTable(Filtro, 0, Orden)
    End Function

    Public Function ObtenerProveedores(ByVal Estatus As EstatusChar, Optional ByVal DeGanado As Object = Nothing) As ProveedorCollectionClass
        Dim Filtro As New OC.PredicateExpression()

        ObtenerProveedores = New ProveedorCollectionClass

        If Estatus <> EstatusChar.TODOS Then
            Filtro.Add(HC.ProveedorFields.Estatus = IIf(Estatus = EstatusChar.VIGENTE, 1, 0))
        End If

        If DeGanado.GetType Is GetType(Boolean) Then
            Filtro.Add(HC.ProveedorFields.EsdeGanado = DeGanado)
        End If
        ObtenerProveedores.Obtener(Filtro, New OC.SortExpression(New OC.SortClause(HC.ProveedorFields.Nombre, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
    End Function

    Public Function ObtenerFormulas() As ProductoCollectionClass
        ObtenerFormulas = New ProductoCollectionClass
        ObtenerFormulas.Obtener(HC.ProductoFields.EsMezcla = True And HC.ProductoFields.Estatus = 1, New OC.SortExpression(New OC.SortClause(HC.ProductoFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
        Return ObtenerFormulas
    End Function

    Public Function ObtenerCompradoresGanado(ByVal Estatus As EstatusChar) As DataTable
        Dim Filtro As New OC.PredicateExpression()
        Dim Ordenamiento As New OC.SortExpression(New OC.SortClause(HC.McgcatCompradoresdeGanadoFields.ApellidoPaterno, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
        Ordenamiento.Add(New OC.SortClause(HC.McgcatCompradoresdeGanadoFields.ApellidoMaterno, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
        Ordenamiento.Add(New OC.SortClause(HC.McgcatCompradoresdeGanadoFields.Nombre, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))

        If Estatus <> EstatusChar.TODOS Then
            Filtro.Add(HC.McgcatCompradoresdeGanadoFields.Estatus = IIf(Estatus = EstatusChar.VIGENTE, 1, 0))
        End If
        Return CC.McgcatCompradoresdeGanadoCollection.GetMultiAsDataTable(Filtro, 0, Ordenamiento)
    End Function

    Public Function ObtenerLugaresDeCompra(ByVal Estatus As EstatusChar) As DataTable
        Dim Filtro As New OC.PredicateExpression()

        If Estatus <> EstatusChar.TODOS Then
            Filtro.Add(HC.CatLugaresDeCompraFields.Estatus = IIf(Estatus = EstatusChar.VIGENTE, 1, 0))
        End If
        Return CC.CatLugaresDeCompraCollection.GetMultiAsDataTable(Filtro, 0, New OC.SortExpression(New OC.SortClause(HC.CatLugaresDeCompraFields.Descripcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
    End Function

    Public Function ObtenerCausasMuerte(ByVal Estatus As CondicionEnum) As CC.McgcatCausasMuerteCollection
        Dim CausasMuerte As New CC.McgcatCausasMuerteCollection
        Dim Filtro As New OC.PredicateExpression

        If Estatus <> CondicionEnum.TODOS Then
            Filtro.Add(HC.McgcatCausasMuerteFields.Estatus = Estatus)
        End If
        CausasMuerte.GetMulti(Filtro, 0, New OC.SortExpression(New OC.SortClause(HC.McgcatCausasMuerteFields.NombreCausaMuerte, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
        Return CausasMuerte
    End Function

    Public Function ObtenerPreciosMasFrecuentesdeProductos() As DataTable
        ObtenerPreciosMasFrecuentesdeProductos = New DataTable
        Dim SqlQuery As String = "" & _
            " SELECT  IdProducto, " & _
                    " IdPrecorte, " & _
                    " Descripcion, " & _
                        " CASE WHEN Corte = 1 THEN " & _
                            " ISNULL((SELECT TOP 1 PrecioxKgr FROM catprexcort WHERE Cve_SubCorte = MSCCatProductos.IdProducto AND PrecioxKgr IN (SELECT DISTINCT(cpxc.PrecioxKgr) FROM catprexcort AS cpxc WHERE cpxc.Cve_SubCorte = Cve_SubCorte) GROUP BY PrecioxKgr ORDER BY count(PrecioxKgr) desc),0) " & _
                        " ELSE " & _
                            " ISNULL((SELECT TOP 1 PrecioxKgr FROM catprexprod WHERE Cve_ProdRas = MSCCatProductos.IdProducto AND PrecioxKgr IN (SELECT DISTINCT(cpxp.PrecioxKgr) FROM catprexprod AS cpxp WHERE cpxp.Cve_ProdRas = Cve_ProdRas) GROUP BY PrecioxKgr ORDER BY count(PrecioxKgr) desc),0) " & _
                        " End " & _
                    " AS PrecioMasFrecuente, " & _
                    " 0.00 AS PrecioPrevisto, " & _
                    " CASE WHEN Corte = 1 THEN 'C' ELSE 'P' END AS Categoria " & _
            " FROM dbo.MSCCatProductos LEFT JOIN MSCCortesPreCortes ON MSCCatProductos.IdProducto = MSCCortesPreCortes.IdCorte " & _
            " WHERE Estatus = 1 AND (Corte = 0 OR IdPrecorte IS NOT NULL) " & _
            " ORDER BY Descripcion "

        Dim DataAdapter As New SqlDataAdapter(SqlQuery, HC.DbUtils.ActualConnectionString)
        DataAdapter.Fill(ObtenerPreciosMasFrecuentesdeProductos)
        Return ObtenerPreciosMasFrecuentesdeProductos
    End Function

    Public Function ObtenerCuentasMaestras() As CC.CuentaContableCollection
        ObtenerCuentasMaestras = New CC.CuentaContableCollection
        ObtenerCuentasMaestras.GetMulti(HC.CuentaContableFields.SubCta = "0000" And HC.CuentaContableFields.SsubCta = "0000" And HC.CuentaContableFields.SssubCta = "0000" And HC.CuentaContableFields.BooInactiva = False)
        Return ObtenerCuentasMaestras
    End Function

    Public Function ObtenerCorral(ByVal IdCorral As String) As CorralClass
        Dim Corral As New CorralClass(IdCorral)
        Return Corral
    End Function
    'obtener metodos de prorrateo
    Public Function ObtenerMetododeProrrateo() As DataTable
        'Dim Filtro As New OC.PredicateExpression()
        'Dim Ordenamiento As New OC.SortExpression(New OC.SortClause(HC.McgcatCompradoresdeGanadoFields.ApellidoPaterno, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
        'Ordenamiento.Add(New OC.SortClause(HC.McgcatCompradoresdeGanadoFields.ApellidoMaterno, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
        'Ordenamiento.Add(New OC.SortClause(HC.McgcatCompradoresdeGanadoFields.Nombre, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))

        'If Estatus <> EstatusChar.TODOS Then
        '    Filtro.Add(HC.MetodoCabFields.Estatus = IIf(Estatus = EstatusChar.VIGENTE, 1, 0))
        'End If
        Return CC.MetodoCabCollection.GetMultiAsDataTable(Nothing, 0, Nothing)
    End Function

    Public Function ObtenerCorrales(ByVal Estado As CondicionEnum, Optional ByVal Tipo As TipoCorral = TipoCorral.TODOS, Optional ByVal ConCabezas As EstatusAutorizada = EstatusAutorizada.TODAS, Optional ByVal ConLoteAsignado As EstatusAutorizada = EstatusAutorizada.TODAS) As CC.McecatCorralesCabCollection
        Dim Filtro As New OC.PredicateExpression(), Relaciones As New OC.RelationCollection
        Dim Coleccion As New CC.McecatCorralesCabCollection

        If Tipo <> TipoCorral.TODOS Then
            Filtro.Add(HC.McecatCorralesCabFields.TipoCorral = Tipo)
        End If

        Select Case Estado
            Case CondicionEnum.ACTIVOS
                Filtro.Add(HC.McecatCorralesCabFields.Estatus = 1)
            Case CondicionEnum.INACTIVOS
                Filtro.Add(HC.McecatCorralesCabFields.Estatus = 0)
        End Select

        Coleccion.GetMulti(Filtro, 0, New OC.SortExpression(New OC.SortClause(HC.McecatCorralesCabFields.NombreCorral, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))

        If ConCabezas = EstatusAutorizada.NO OrElse ConLoteAsignado = EstatusAutorizada.NO _
        OrElse ConCabezas = EstatusAutorizada.SI OrElse ConLoteAsignado = EstatusAutorizada.SI Then
            For i As Integer = Coleccion.Count - 1 To 0 Step -1
                Dim Corral As EC.McecatCorralesCabEntity = Coleccion(i)
                Dim TieneLoteAsignado As Boolean = False
                Dim TieneCabezas As Boolean = False

                For Each Lote As EC.McecatLotesCabEntity In Corral.McecatLotesCab
                    If Lote.Estatus = LoteClass.EstatusLote.VIGENTE Then
                        TieneLoteAsignado = True
                        Exit For
                    End If
                Next

                If ConLoteAsignado <> EstatusAutorizada.TODAS Then
                    If ConLoteAsignado = EstatusAutorizada.SI AndAlso Not TieneLoteAsignado _
                    OrElse ConLoteAsignado = EstatusAutorizada.NO AndAlso TieneLoteAsignado Then
                        Coleccion.RemoveAt(i)
                        Continue For
                    End If
                End If

                For Each Detalle As EC.McecatCorralesDetEntity In Corral.McecatCorralesDet
                    If Detalle.ExistCabezas > 0 Then
                        TieneCabezas = True
                        Exit For
                    End If
                Next

                If ConCabezas <> EstatusAutorizada.TODAS Then
                    If ConCabezas = EstatusAutorizada.SI AndAlso Not TieneCabezas _
                    OrElse ConCabezas = EstatusAutorizada.NO AndAlso TieneCabezas Then
                        Coleccion.RemoveAt(i)
                        Continue For
                    End If
                End If
            Next
        End If

        Return Coleccion
    End Function

    Public Function ObtenerTiposGanado(ByVal Estado As CondicionEnum) As CC.McgcatTiposdeGanadoCollection
        Dim Filtro As New OC.PredicateExpression()
        Dim Coleccion As New CC.McgcatTiposdeGanadoCollection

        If Estado <> CondicionEnum.TODOS Then
            Filtro.Add(HC.McgcatTiposdeGanadoFields.Estatus = Estado)
        End If
        Coleccion.GetMulti(Filtro)
        Return Coleccion
    End Function

    Public Function ObtenerRastros(ByVal Estado As CondicionEnum) As CC.CatRastrosCollection
        Dim Filtro As New OC.PredicateExpression()
        Dim Coleccion As New CC.CatRastrosCollection

        Select Case Estado
            Case CondicionEnum.ACTIVOS
                Filtro.Add(HC.CatRastrosFields.Estatus = "1")
            Case CondicionEnum.INACTIVOS
                Filtro.Add(HC.CatRastrosFields.Estatus = "0")
        End Select
        Coleccion.GetMulti(Filtro)
        Return Coleccion
    End Function

    Public Function ObtenerCuentasContables(Optional ByVal CuentaInicial As String = "", Optional ByVal CuentaFinal As String = "") As CC.CuentaContableCollection
        ObtenerCuentasContables = New CC.CuentaContableCollection
        Dim Ordenamiento As New OC.SortExpression(New OC.SortClause(HC.CuentaContableFields.Cta, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
        Dim Filtro As New OC.PredicateExpression()

        If CuentaInicial.Trim <> String.Empty AndAlso Val(CuentaInicial) <> 0 Then
            Filtro.Add(HC.CuentaContableFields.Cta >= CuentaInicial.Substring(0, 4) And HC.CuentaContableFields.SubCta >= CuentaInicial.Substring(4, 4) And HC.CuentaContableFields.SsubCta >= CuentaInicial.Substring(8, 4) And HC.CuentaContableFields.SssubCta >= CuentaInicial.Substring(12, 4))
        End If

        If CuentaFinal.Trim <> String.Empty AndAlso Val(CuentaFinal) <> 0 Then
            Filtro.Add(HC.CuentaContableFields.Cta <= CuentaFinal.Substring(0, 4) And HC.CuentaContableFields.SubCta <= CuentaFinal.Substring(4, 4) And HC.CuentaContableFields.SsubCta <= CuentaFinal.Substring(8, 4) And HC.CuentaContableFields.SssubCta <= CuentaFinal.Substring(12, 4))
        End If
        Ordenamiento.Add(New OC.SortClause(HC.CuentaContableFields.SubCta, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
        Ordenamiento.Add(New OC.SortClause(HC.CuentaContableFields.SsubCta, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
        Ordenamiento.Add(New OC.SortClause(HC.CuentaContableFields.SssubCta, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
        ObtenerCuentasContables.GetMulti(Filtro, 0, Ordenamiento)
        Return ObtenerCuentasContables
    End Function

    Private Function FiltroCorralesDeReciba( _
    ByVal TipoReciba As SalidaGanadoCabeceroClass.TipoSalida, _
    Optional ByVal Folio As String = "", _
    Optional ByVal Fechas As RangoFechas = Nothing, _
    Optional ByVal Estatus As EstatusChar = EstatusChar.TODOS, _
    Optional ByVal Corral As CorralClass = Nothing, _
    Optional ByVal Rastro As RastroClass = Nothing, _
    Optional ByVal LoteDestino As LoteClass = Nothing, _
    Optional ByVal CausaMuerte As CausaMuertesClass = Nothing, _
    Optional ByVal AretePropio As String = Nothing, _
    Optional ByVal LoteSalida As LoteClass = Nothing, _
    Optional ByVal EsRecuperacion As Object = Nothing) _
    As OC.PredicateExpression
        Dim Filtro As New OC.PredicateExpression
        Dim Relaciones As New OC.RelationCollection

        Filtro.Add(HC.SalidaGanadoCabFields.IdTipoReciba = TipoReciba)

        If Folio.Trim <> String.Empty Then
            Folio = IIf(Folio(0) = "R", Folio.Substring(1), Folio)
            Filtro.Add(HC.SalidaGanadoCabFields.IdSalidaGanadoCab Mod String.Format("%{0}%", Folio))
        Else
            If Fechas IsNot Nothing Then
                If Fechas.FechaInicial.HasValue Then
                    Filtro.Add(HC.SalidaGanadoCabFields.Fecha >= Fechas.FechaInicial)
                End If

                If Fechas.FechaFinal.HasValue Then
                    Filtro.Add(HC.SalidaGanadoCabFields.Fecha <= Fechas.FechaFinal.Value.AddDays(1).AddMilliseconds(-1))
                End If
            End If

            If Estatus = EstatusChar.VIGENTE Then
                Filtro.Add(HC.SalidaGanadoCabFields.Estatus = 1)
            ElseIf Estatus = EstatusChar.CANCELADO Then
                Filtro.Add(HC.SalidaGanadoCabFields.Estatus = 0)
            End If

            If Corral IsNot Nothing AndAlso Corral.Entidad IsNot Nothing AndAlso Not Corral.Entidad.IsNew Then
                Filtro.Add(HC.SalidaGanadoCabFields.IdCorral = Corral.IdCorral)
            End If

            If AretePropio <> String.Empty Then
                Filtro.Add(HC.SalidaGanadoDetFields.Arete = AretePropio)
            End If

            If TipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Reciba_a_Rastro _
            OrElse TipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_a_Rastro Then
                If Rastro IsNot Nothing AndAlso Rastro.Entidad IsNot Nothing AndAlso Not Rastro.Entidad.IsNew Then
                    Filtro.Add(HC.SalidaGanadoCabFields.IdRastro = Rastro.IdRastro)
                End If
            ElseIf TipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Reciba_por_Muerte _
            OrElse TipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_por_Muerte Then
                If CausaMuerte IsNot Nothing AndAlso CausaMuerte.ObtenerEntidad IsNot Nothing AndAlso Not CausaMuerte.ObtenerEntidad.IsNew Then
                    Filtro.Add(HC.SalidaGanadoCabFields.IdCausaMuerte = CausaMuerte.IdCausaMuerte)
                End If

                If EsRecuperacion IsNot Nothing AndAlso EsRecuperacion.GetType Is GetType(Boolean) Then
                    Filtro.Add(HC.SalidaGanadoCabFields.Recuperacion = EsRecuperacion)
                End If
            ElseIf TipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Transferencia_de_Reciba_a_Corral _
            OrElse TipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_por_Tranferencia Then
                If LoteDestino IsNot Nothing AndAlso LoteDestino.Entidad IsNot Nothing AndAlso Not LoteDestino.Entidad.IsNew Then
                    Filtro.Add(HC.SalidaGanadoCabFields.IdLoteDestino = LoteDestino.IdLote)
                End If

                If TipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_por_Tranferencia Then
                    If LoteSalida IsNot Nothing AndAlso LoteSalida.Entidad IsNot Nothing AndAlso Not LoteSalida.Entidad.IsNew Then
                        Filtro.Add(HC.SalidaGanadoDetFields.IdLote = LoteSalida.IdLote)
                    End If
                End If
            End If
        End If
        Return Filtro
    End Function

    Private Function ObtenerSalidasGanado(ByRef Filtro As OC.PredicateExpression, Optional ByVal Relaciones As OC.RelationCollection = Nothing) As SalidaGanadoCabeceroCollectionClass
        Dim SalidasColeccion As New CC.SalidaGanadoCabCollection
        Dim SalidasCabecero As New SalidaGanadoCabeceroCollectionClass
        Dim Ordenamiento As New OC.SortExpression(New OC.SortClause(HC.SalidaGanadoCabFields.Fecha, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Descending))

        SalidasColeccion.GetMulti(Filtro, 0, Ordenamiento, Relaciones)

        If Not SalidasColeccion.Count > 0 Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 2)
        Else
            For Each CorralReciba As EC.SalidaGanadoCabEntity In SalidasColeccion
                SalidasCabecero.Add(CorralReciba)
            Next
        End If
        Return SalidasCabecero
    End Function

    Public Function ObtenerSalidasDeRecibaARastro(Optional ByVal Folio As String = "", Optional ByVal Fechas As RangoFechas = Nothing, Optional ByVal Estatus As EstatusChar = EstatusChar.TODOS, Optional ByVal Corral As CorralClass = Nothing, Optional ByVal Rastro As RastroClass = Nothing) As SalidaGanadoCabeceroCollectionClass
        Dim Filtro As OC.PredicateExpression = FiltroCorralesDeReciba(SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Reciba_a_Rastro, Folio, Fechas, Estatus, Corral, Rastro)
        Return ObtenerSalidasGanado(Filtro)
    End Function

    Public Function ObtenerSalidasDeRecibaAMuerte(Optional ByVal Folio As String = "", Optional ByVal Fechas As RangoFechas = Nothing, Optional ByVal Estatus As EstatusChar = EstatusChar.TODOS, Optional ByVal Corral As CorralClass = Nothing, Optional ByVal CausaMuerte As CausaMuertesClass = Nothing, Optional ByVal EsRecuperacion As Object = Nothing) As SalidaGanadoCabeceroCollectionClass
        Dim Filtro As OC.PredicateExpression = FiltroCorralesDeReciba(SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Reciba_por_Muerte, Folio, Fechas, Estatus, Corral, Nothing, Nothing, CausaMuerte, Nothing, Nothing, EsRecuperacion)
        Return ObtenerSalidasGanado(Filtro)
    End Function

    Public Function ObtenerSalidasDeRecibaAVenta(Optional ByVal Folio As String = "", Optional ByVal Fechas As RangoFechas = Nothing, Optional ByVal Estatus As EstatusChar = EstatusChar.TODOS, Optional ByVal Corral As CorralClass = Nothing) As SalidaGanadoCabeceroCollectionClass
        Dim Filtro As OC.PredicateExpression = FiltroCorralesDeReciba(SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Reciba_a_Venta, Folio, Fechas, Estatus, Corral)
        Return ObtenerSalidasGanado(Filtro)
    End Function

    Public Function ObtenerSalidasDeRecibaACorral(Optional ByVal Folio As String = "", Optional ByVal Fechas As RangoFechas = Nothing, Optional ByVal Estatus As EstatusChar = EstatusChar.TODOS, Optional ByVal Corral As CorralClass = Nothing, Optional ByVal LoteDestino As LoteClass = Nothing) As SalidaGanadoCabeceroCollectionClass
        Dim Filtro As OC.PredicateExpression = FiltroCorralesDeReciba(SalidaGanadoCabeceroClass.TipoSalida.Transferencia_de_Reciba_a_Corral, Folio, Fechas, Estatus, Corral, Nothing, LoteDestino, Nothing)
        Return ObtenerSalidasGanado(Filtro)
    End Function

    Public Function ObtenerSalidasDeCorralARastro(Optional ByVal Folio As String = "", Optional ByVal Fechas As RangoFechas = Nothing, Optional ByVal Estatus As EstatusChar = EstatusChar.TODOS, Optional ByVal AretePropio As String = Nothing, Optional ByVal Rastro As RastroClass = Nothing) As SalidaGanadoCabeceroCollectionClass
        Dim Filtro As OC.PredicateExpression = FiltroCorralesDeReciba(SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_a_Rastro, Folio, Fechas, Estatus, Nothing, Rastro, Nothing, Nothing, AretePropio)
        Dim Relacion As New OC.RelationCollection

        If AretePropio <> String.Empty Then
            Relacion.Add(EC.SalidaGanadoCabEntity.Relations.SalidaGanadoDetEntityUsingIdSalidaGanadoCab)
        End If
        Return ObtenerSalidasGanado(Filtro, Relacion)
    End Function

    Public Function ObtenerSalidasDeCorralAVenta(Optional ByVal Folio As String = "", Optional ByVal Fechas As RangoFechas = Nothing, Optional ByVal Estatus As EstatusChar = EstatusChar.TODOS, Optional ByVal AretePropio As String = Nothing) As SalidaGanadoCabeceroCollectionClass
        Dim Filtro As OC.PredicateExpression = FiltroCorralesDeReciba(SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_a_Venta, Folio, Fechas, Estatus, Nothing, Nothing, Nothing, Nothing, AretePropio)
        Dim Relacion As New OC.RelationCollection

        If AretePropio <> String.Empty Then
            Relacion.Add(EC.SalidaGanadoCabEntity.Relations.SalidaGanadoDetEntityUsingIdSalidaGanadoCab)
        End If
        Return ObtenerSalidasGanado(Filtro, Relacion)
    End Function

    Public Function ObtenerSalidasDeCorralAMuerte(Optional ByVal Folio As String = "", Optional ByVal Fechas As RangoFechas = Nothing, Optional ByVal Estatus As EstatusChar = EstatusChar.TODOS, Optional ByVal AretePropio As String = Nothing, Optional ByVal CausaMuerte As CausaMuertesClass = Nothing, Optional ByVal EsRecuperacion As Object = Nothing) As SalidaGanadoCabeceroCollectionClass
        Dim Filtro As OC.PredicateExpression = FiltroCorralesDeReciba(SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_por_Muerte, Folio, Fechas, Estatus, Nothing, Nothing, Nothing, CausaMuerte, AretePropio, Nothing, EsRecuperacion)
        Dim Relacion As New OC.RelationCollection

        If AretePropio <> String.Empty Then
            Relacion.Add(EC.SalidaGanadoCabEntity.Relations.SalidaGanadoDetEntityUsingIdSalidaGanadoCab)
        End If
        Return ObtenerSalidasGanado(Filtro, Relacion)
    End Function

    Public Function ObtenerSalidasDeCorralporTransferencia(Optional ByVal Folio As String = "", Optional ByVal Fechas As RangoFechas = Nothing, Optional ByVal Estatus As EstatusChar = EstatusChar.TODOS, Optional ByVal AretePropio As String = Nothing, Optional ByVal LoteSalida As LoteClass = Nothing, Optional ByVal LoteEntrada As LoteClass = Nothing) As SalidaGanadoCabeceroCollectionClass
        Dim Filtro As OC.PredicateExpression = FiltroCorralesDeReciba(SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_por_Tranferencia, Folio, Fechas, Estatus, Nothing, Nothing, LoteEntrada, Nothing, AretePropio, LoteSalida)
        Dim Relacion As New OC.RelationCollection

        If AretePropio <> String.Empty OrElse LoteSalida IsNot Nothing Then
            Relacion.Add(EC.SalidaGanadoCabEntity.Relations.SalidaGanadoDetEntityUsingIdSalidaGanadoCab)
        End If
        Return ObtenerSalidasGanado(Filtro, Relacion)
    End Function

    Public Function ObtenerLotes(Optional ByVal Estatus As LoteClass.EstatusLote = LoteClass.EstatusLote.TODOS) As LoteCollectionClass
        Dim Filtro As New OC.PredicateExpression
        ObtenerLotes = New LoteCollectionClass()

        If Estatus <> LoteClass.EstatusLote.TODOS Then
            Filtro.Add(HC.McecatLotesCabFields.Estatus = Estatus)
        End If

        ObtenerLotes.Obtener(Filtro, New OC.SortExpression(New OC.SortClause(HC.McecatLotesCabFields.NombreLote, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
        Return ObtenerLotes
    End Function

    Public Function ObtenerLotes(ByVal Filtro As OC.PredicateExpression) As LoteCollectionClass
        ObtenerLotes = New LoteCollectionClass()
        ObtenerLotes.Obtener(Filtro, New OC.SortExpression(New OC.SortClause(HC.McecatLotesCabFields.NombreLote, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
        Return ObtenerLotes
    End Function

    Public Function ObtenerClientes(ByVal Estatus As EstatusChar, Optional ByVal ExcluirSinDestinos As Boolean = False) As DataTable
        Dim Filtro As New OC.PredicateExpression
        Dim Relaciones As New OC.RelationCollection

        If Estatus <> EstatusChar.TODOS Then
            If Estatus = EstatusChar.VIGENTE Then
                Filtro.Add(HC.MfacCatClientesFields.Estatus = 1)
            Else 'if Estatus = EstatusChar.CANCELADO Then
                Filtro.Add(HC.MfacCatClientesFields.Estatus = 0)
            End If
        End If

        If ExcluirSinDestinos Then
            Relaciones.Add(EC.MfacCatClientesEntity.Relations.MgralcatPuntosEntregaEntityUsingIdCliente)
        End If
        Return CC.MfacCatClientesCollection.GetMultiAsDataTable(Filtro, 0, New OC.SortExpression(New OC.SortClause(HC.MfacCatClientesFields.Nombre, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)), Relaciones)
    End Function

    Public Function ObtenerTiposCorrales(ByVal Estatus As EstatusChar) As TipoCorralColecttionClass
        Dim Filtro As New OC.PredicateExpression()
        ObtenerTiposCorrales = New TipoCorralColecttionClass()

        If Estatus <> EstatusChar.TODOS Then
            Filtro.Add(HC.McecatTiposCorralFields.Estatus = IIf(Estatus = EstatusChar.VIGENTE, 1, 0))
        End If
        ObtenerTiposCorrales.Obtener(Filtro, New OC.SortExpression(New OC.SortClause(HC.McecatTiposCorralFields.DescTipoCorral, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)))
        Return ObtenerTiposCorrales
    End Function

    Public Function ObtenerTiposMovimientos(ByVal Estatus As CondicionEnum) As TipoMovimientoAlmacenCollectionClass
        ObtenerTiposMovimientos = New TipoMovimientoAlmacenCollectionClass
        ObtenerTiposMovimientos.Obtener(Estatus)
        Return ObtenerTiposMovimientos
    End Function

    Public Function ObtenerIVA() As Decimal
        Try
            Dim ConfigGral As New Integralab.ORM.CollectionClasses.UsrConfigContabilidadCollection
            ConfigGral.GetMulti(Nothing)

            If ConfigGral.Count > 0 Then
                Return ConfigGral(0).Iva
            Else
                MsgBox("Agrege datos a la configuración de Contabilidad", MsgBoxStyle.Exclamation, Me.Sesion.MiEmpresa.Empnom)
                Return 0D
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Function ObtenerProductosParaCargaInicialNueva(ByVal IdAlmacen As Integer, ByVal Familias As LineaCollectionClass) As DataTable
        Dim CodigosFamilias As New List(Of String), SQL As String, SQLIn As String = ""

        For Each Familia As LineaClass In Familias
            CodigosFamilias.Add(Familia.Codigo)
        Next
        SQL = "SELECT MCatCompProductos.PdDescrpcionCorta AS Clave, MCatCompProductos.PdDescripcion AS Producto, 0 AS Cantidad, CAST(NULL AS datetime) AS Caducidad" & _
            ", '' AS Lote, MCatCompProductos.PdCaduca AS Caduca, MCatCompProductos.PdIdLinea AS IdLinea" & _
            ", MCatCompLineas.LNDescripcion AS Linea, 0.0 AS CostoPromedio, 0.0 AS UltimoCosto" & _
            ", MCatCompProductos.PdIdProducto AS ProductoId, MCatCompProductos.PdSeManejaPorLotes AS SeManejaPorLotes" & _
            " FROM MCatCompProductos INNER JOIN MCatCompLineas ON MCatCompProductos.PdIdLinea = MCatCompLineas.LNIdLinea" & _
            " WHERE MCatCompProductos.PdIdProducto NOT IN (SELECT DISTINCT ProductoId FROM MInvAlmacen" & _
            " INNER JOIN dbo.MCatCompProductos ON MInvAlmacen.ProductoId = MCatCompProductos.PdIdProducto WHERE MCatCompProductos.PdSeManejaPorLotes = 0 AND MInvAlmacen.AlmacenId = @AlmacenId)" & _
            " AND MCatCompProductos.PdIdLinea in (" & String.Join(",", CodigosFamilias.ToArray) & ")" & _
            " ORDER BY Producto"
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(SQL, HC.DbUtils.ActualConnectionString)

        da.SelectCommand.Parameters.Add("@AlmacenId", SqlDbType.Int).Value = IdAlmacen
        da.SelectCommand.Connection.Open()
        da.SelectCommand.Prepare()
        da.Fill(dt)
        Return dt
    End Function

    Public Function ObtenerProductosGenerales(ByVal Estatus As CondicionEnum, Optional ByVal Familias As LineaCollectionClass = Nothing) As ProductoCollectionClass
        Dim Productos As New ProductoCollectionClass
        Dim Filtro As New OC.PredicateExpression
        Dim Relacion As New OC.RelationCollection

        If Estatus <> CondicionEnum.TODOS Then
            Filtro.Add(HC.ProductoFields.Estatus = Estatus)
        End If

        If Familias IsNot Nothing AndAlso Familias.Count > 0 Then
            Dim FamiliasCodigos As New List(Of Integer)

            Relacion.Add(EC.ProductoEntity.Relations.LineaEntityUsingPdIdLinea)

            For Each Familia As LineaClass In Familias
                FamiliasCodigos.Add(Familia.Codigo)
            Next
            Filtro.Add(New OC.FieldCompareRangePredicate(HC.LineaFields.Codigo, FamiliasCodigos))
        End If
        Productos.Obtener(Filtro, Relacion)
        Return Productos
    End Function

    Public Function ObtenerProductosSolicitados(ByVal IdSucursal As Integer) As SolicitudProductoDetalleCollectionClass
        Dim Relacion As New OC.RelationCollection

        Relacion.Add(EC.SolicitudProductoDetalleEntity.Relations.SolicitudProductoEntityUsingIdSolicitud)
        ObtenerProductosSolicitados = New SolicitudProductoDetalleCollectionClass()
        ObtenerProductosSolicitados.Obtener(HC.SolicitudProductoFields.IdSucursal = IdSucursal, New OC.SortExpression(New OC.SortClause(HC.SolicitudProductoFields.FechaSolicitud, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)), Relacion)
        Return ObtenerProductosSolicitados
    End Function

#End Region

#Region "Metodos Actualizar Combos"

    Public Sub LlenarComboMonedas(ByVal Combo As Object, ByVal Estatus As CondicionEnum)
        Combo.DataSource = Nothing
        Combo.ValueMember = "Codigo"
        Combo.DisplayMember = "Descripcion"
        Combo.DataSource = Me.ObtenerMonedas(Estatus)

        If Combo.GetType Is GetType(ComboBox) Then
            Combo.SelectedIndex = -1
            Combo.Text = "Seleccione la Moneda"
        End If
    End Sub

    Public Sub LlenarComboProductosGenerales(ByVal Combo As Object, ByVal Estatus As CondicionEnum)
        Combo.DataSource = Nothing
        Combo.ValueMember = "Codigo"
        Combo.DisplayMember = "Descripcion"
        Combo.DataSource = Me.ObtenerProductosGenerales(Estatus)

        If Combo.GetType Is GetType(ComboBox) Then
            Combo.SelectedIndex = -1
            Combo.Text = "Seleccione el Producto"
        End If
    End Sub

    Public Sub LlenarComboSucursales(ByVal Combo As Object, ByVal Estatus As CondicionEnum)
        Combo.DataSource = Nothing
        Combo.ValueMember = "Codigo"
        Combo.DisplayMember = "Descripcion"
        Combo.DataSource = Me.ObtenerSucursales(Estatus)

        If Combo.GetType Is GetType(ComboBox) Then
            Combo.SelectedIndex = -1
            Combo.Text = "Seleccione la Sucursal"
        End If
    End Sub

    Public Sub LlenarComboPlazas(ByVal Combo As Object, ByVal Estatus As CondicionEnum)
        Combo.DataSource = Nothing
        Combo.ValueMember = "Codigo"
        Combo.DisplayMember = "Descripcion"
        Combo.DataSource = Me.ObtenerPlazas(Estatus)

        If Combo.GetType Is GetType(ComboBox) Then
            Combo.SelectedIndex = -1
            Combo.Text = "Seleccione la Plaza"
        End If
    End Sub

    Public Sub LlenarComboTiposGanado(ByVal Combo As Object, ByVal Estatus As CondicionEnum)
        Dim TiposGanado As New TipoGanadoColecttionClass()

        TiposGanado.RellenarMe(Me.ObtenerTiposGanado(Estatus))

        Combo.DataSource = Nothing
        Combo.ValueMember = "IdTipoGanado"
        Combo.DisplayMember = "Descripcion"
        Combo.DataSource = TiposGanado

        If Combo.GetType Is GetType(ComboBox) Then
            Combo.SelectedIndex = -1
            Combo.Text = "Seleccione el Tipo de Ganado"
        End If
    End Sub

    Public Sub LlenarComboAlmacenesParaCargaInicial(ByVal Combo As Object, ByVal Estatus As CondicionEnum)
        Combo.DataSource = Nothing
        Combo.ValueMember = "Codigo"
        Combo.DisplayMember = "Descripcion"
        Combo.DataSource = Me.ObtenerAlmacenesParaCargaInicial(Estatus)

        If Combo.GetType Is GetType(ComboBox) Then
            Combo.SelectedIndex = -1
            Combo.Text = "Seleccione el Almacen"
        End If
    End Sub

    Public Sub LlenarComboAlmacenesDeProduccion(ByVal Combo As Object)
        Combo.DataSource = Nothing
        Combo.ValueMember = "Codigo"
        Combo.DisplayMember = "Descripcion"
        Combo.DataSource = Me.ObtenerAlmacenesDeProduccion()

        If Combo.GetType Is GetType(ComboBox) Then
            Combo.SelectedIndex = -1
            Combo.Text = "Seleccione el Almacen"
        End If
    End Sub

    Public Sub LlenarComboAlmacenesConInventarioDeProductosGenerales(ByVal Combo As Object, Optional ByVal Plazas As PlazaCollectionClass = Nothing, Optional ByVal Familias As LineaCollectionClass = Nothing)
        Combo.DataSource = Nothing
        Combo.ValueMember = "Codigo"
        Combo.DisplayMember = "Descripcion"
        Combo.DataSource = Me.ObtenerAlmacenesConInventarioDeProductosGenerales(Plazas, Familias)

        If Combo.GetType Is GetType(ComboBox) Then
            Combo.SelectedIndex = -1
            Combo.Text = "Seleccione el Almacen"
        End If
    End Sub

    Public Sub LlenarComboRastros(ByVal Combo As Object)
        Combo.DataSource = Nothing
        Combo.ValueMember = "IdRastro"
        Combo.DisplayMember = "Descripcion"
        Combo.DataSource = Me.ObtenerRastros(CondicionEnum.ACTIVOS)

        If Combo.GetType Is GetType(ComboBox) Then
            Combo.SelectedIndex = -1
            Combo.Text = "Seleccione el Rastro"
        End If
    End Sub

    Public Sub LlenarComboCausasMuerte(ByVal Combo As Object)
        Combo.DataSource = Nothing
        Combo.ValueMember = "IdCausaMuerte"
        Combo.DisplayMember = "NombreCausaMuerte"
        Combo.DataSource = Me.ObtenerCausasMuerte(CondicionEnum.ACTIVOS)

        If Combo.GetType Is GetType(ComboBox) Then
            Combo.SelectedIndex = -1
            Combo.Text = "Seleccione la Causa de Muerte"
        End If
    End Sub

    ''' <summary>
    ''' Codigo: IdLote
    ''' Descripcion: Descripcion
    ''' Mensaje elemento vacio: "Seleccione el Lote"
    ''' </summary>
    ''' <param name="Combo"></param>
    ''' <param name="Estatus"></param>
    ''' <remarks></remarks>
    Public Sub LlenarComboLotes(ByVal Combo As Object, Optional ByVal Estatus As LoteClass.EstatusLote = LoteClass.EstatusLote.TODOS)
        Combo.DataSource = Nothing
        Combo.ValueMember = "IdLote"
        Combo.DisplayMember = "Descripcion"
        Combo.DataSource = Me.ObtenerLotes(Estatus)

        If Combo.GetType Is GetType(ComboBox) Then
            Combo.SelectedIndex = -1
            Combo.Text = "Seleccione el Lote"
        End If
    End Sub

    Public Sub LlenarComboCorralesRecepcion(ByVal Combo As Object)
        Combo.DataSource = Nothing
        Combo.ValueMember = "IdCorral"
        Combo.DisplayMember = "NombreCorral"
        Combo.DataSource = Me.ObtenerCorrales(CondicionEnum.ACTIVOS, TipoCorral.RECIBA)

        If Combo.GetType Is GetType(ComboBox) Then
            Combo.SelectedIndex = -1
            Combo.Text = "Seleccione el Corral de Recepcion"
        End If
    End Sub

    Public Sub LlenarComboProveedores(ByVal Combo As Object, Optional ByVal DeGanado As Object = Nothing)
        Combo.DataSource = Nothing
        Combo.ValueMember = "Codigo"
        Combo.DisplayMember = "Nombre"
        Combo.DataSource = Me.ObtenerProveedores(EstatusChar.VIGENTE, DeGanado)

        If Combo.GetType Is GetType(ComboBox) Then
            Combo.SelectedIndex = -1
            Combo.Text = "Seleccione el Proveedor"
        End If
    End Sub

    Public Sub LlenarComboChoferes(ByVal Combo As Object)
        Dim dt As DataTable = Me.ObtenerChoferes(EstatusChar.VIGENTE)
        dt.Columns.Add("NombreCompleto", GetType(String), "ApPatChofer + ' ' + ApMatChofer + ' ' + NombreChofer")
        Combo.DataSource = Nothing
        Combo.ValueMember = "IdChofer"
        Combo.DisplayMember = "NombreCompleto"
        Combo.DataSource = dt

        If Combo.GetType Is GetType(ComboBox) Then
            Combo.SelectedIndex = -1
            Combo.Text = "Seleccione el Chofer"
        End If
    End Sub

    Public Sub LlenarComboClientes(ByVal Combo As Object, ByVal Estatus As EstatusChar, Optional ByVal ExcluirSinDestinos As Boolean = False)
        Dim dt As DataTable = Me.ObtenerClientes(Estatus, ExcluirSinDestinos)
        Combo.DataSource = Nothing
        Combo.ValueMember = "IdCliente"
        Combo.DisplayMember = "Nombre"
        Combo.DataSource = dt

        If Combo.GetType Is GetType(ComboBox) Then
            Combo.SelectedIndex = -1
            Combo.Text = "Seleccione el Cliente"
        End If
    End Sub

    Public Sub LlenarComboBancos(ByVal Combo As Object, ByVal Estatus As CondicionEnum)
        Combo.DataSource = Nothing
        Combo.ValueMember = "Codigo"
        Combo.DisplayMember = "Descripcion"
        Combo.DataSource = Me.ObtenerBancos(Estatus)

        If Combo.GetType Is GetType(ComboBox) Then
            Combo.SelectedIndex = -1
            Combo.Text = "Seleccione el Banco"
        End If
    End Sub

    Public Sub LlenarComboLugaresDeCompra(ByVal Combo As Object)
        Combo.DataSource = Nothing
        Combo.ValueMember = "IdLugarCompra"
        Combo.DisplayMember = "Descripcion"
        Combo.DataSource = Me.ObtenerLugaresDeCompra(EstatusChar.VIGENTE)

        If Combo.GetType Is GetType(ComboBox) Then
            Combo.SelectedIndex = -1
            Combo.Text = "Seleccione el Lugar de Compra"
        End If
    End Sub

    Public Sub LlenarComboCompradoresDeGanado(ByVal Combo As Object)
        Dim dt As DataTable = Me.ObtenerCompradoresGanado(EstatusChar.VIGENTE)
        dt.Columns.Add("NombreCompleto", GetType(String), "ApellidoPaterno + ' ' + ApellidoMaterno + ' ' + Nombre")
        Combo.DataSource = Nothing
        Combo.ValueMember = "IdComprador"
        Combo.DisplayMember = "NombreCompleto"
        Combo.DataSource = dt

        If Combo.GetType Is GetType(ComboBox) Then
            Combo.SelectedIndex = -1
            Combo.Text = "Seleccione el Comisionista"
        End If
    End Sub
    Public Sub LlenarComboMetodosdeProrrateo(ByVal Combo As Object)
        Dim dt As DataTable = Me.ObtenerMetododeProrrateo()
        Combo.DataSource = Nothing
        Combo.ValueMember = "Codigo"
        Combo.DisplayMember = "Descripcion"
        Combo.DataSource = dt

        If Combo.GetType Is GetType(ComboBox) Then
            Combo.SelectedIndex = -1
            Combo.Text = "Seleccione el Metodo de Prorrateo"
        End If
    End Sub
#End Region

#Region "Metodos Impresion de Catalogos"

    Public Sub ImpresionSolicitudCompra(ByVal Solicitud As SolicitudProductoClass)
        Dim PreVisualizar As New PreVisualizarForm
        Dim Solicitudes As New SolicitudProductoCollectionClass

        Solicitudes.Add(Solicitud)
        PreVisualizar.Reporte = rptSolicitudProd(Solicitudes)
        PreVisualizar.ShowDialog()
    End Sub

    Private Function rptSolicitudProd(ByRef Solicitudes As SolicitudProductoCollectionClass) As rptSolicitudProd
        Dim dsSolicitudProduc As dsSolicitudProduc = New dsSolicitudProduc, dtSolicitudProducCab As dsSolicitudProduc.CabeceroDataTable = dsSolicitudProduc.Cabecero
        Dim dtSolicitudProducDet As dsSolicitudProduc.DetalleDataTable = dsSolicitudProduc.Detalle

        rptSolicitudProd = New rptSolicitudProd

        For Each Solic As SolicitudProductoClass In Solicitudes
            Dim SolicRow As dsSolicitudProduc.CabeceroRow = dtSolicitudProducCab.AddCabeceroRow(Solic.Sucursal.Plaza.Descripcion, Solic.Sucursal.Descripcion, Solic.FolioSolicitud, Solic.FechaSolicitud, _
                                                            Solic.FechaSurtir, Solic.EntregarA, Solic.EntregarEn, Solic.Estatus.ToString, Solic.Observaciones.ToString)

            For Each det As SolicitudProductoDetalleClass In Solic.Detalle
                Dim FechaSurtir As Date = #1/1/1900#

                dtSolicitudProducDet.AddDetalleRow(SolicRow, det.Producto.Descripcion, det.Cantidad, IIf(det.Urgente, "Si", "No").ToString(), det.UnidadMedida, det.Producto.Marca.NombreCorto, det.Producto.Linea.Descripcion)
            Next
        Next
        rptSolicitudProd.SetDataSource(dsSolicitudProduc)
        rptSolicitudProd.SetParameterValue(0, Me.Sesion.MiEmpresa.Empnom)
        rptSolicitudProd.SetParameterValue(2, Me.Sesion.MiUsuario.Usrnomcom)
        rptSolicitudProd.SetParameterValue(1, "Compras Generales/Solicitud de Productos")
        Return rptSolicitudProd
    End Function

    Public Sub ImpresionPrecios()
        Dim Previsualizar As New PreVisualizarForm
        Dim Reporte As New RptPreciosClientes
        Dim ds As New DataSet
        Dim dt As New DsRptPreciosClientes.PreciosDestinosClienteDataTable
        Dim SqlAdapter As New SqlDataAdapter("", HC.DbUtils.ActualConnectionString)

        SqlAdapter.SelectCommand.CommandText = "" & _
            "SELECT Cve_Cliente AS IdCliente, Cve_Destino AS IdPuntoEntrega, Cve_SubCorte AS IdProducto, PrecioxKgr, 'CORTE' AS Tipo " & _
            "	,MSCCatProductos.Descripcion AS NombreProducto " & _
            "	,MFacCatClientes.Nombre AS NombreCliente " & _
            "	,MGRALCatPuntosEntrega.Descripcion + ' COL:' + MGRALCatPuntosEntrega.Colonia + ' DIR:' + MGRALCatPuntosEntrega.Direccion AS NombreDestino " & _
            "FROM catprexcort " & _
            "INNER JOIN MSCCatProductos ON MSCCatProductos.IdProducto = catprexcort.Cve_SubCorte " & _
            "INNER JOIN MFacCatClientes ON MFacCatClientes.IdCliente = catprexcort.Cve_Cliente " & _
            "INNER JOIN MGRALCatPuntosEntrega ON MGRALCatPuntosEntrega.IdPuntoEntrega = catprexcort.Cve_Destino " & _
            "UNION " & _
            "SELECT Cve_Cliente AS IdCliente, Cve_Destino AS IdPuntoEntrega, Cve_ProdRas AS IdProducto, PrecioxKgr, 'PRODUCTO' AS Tipo " & _
            "	,MSCCatProductos.Descripcion AS NombreProducto " & _
            "	,MFacCatClientes.Nombre AS NombreCliente " & _
            "	,MGRALCatPuntosEntrega.Descripcion + ' COL:' + MGRALCatPuntosEntrega.Colonia + ' DIR:' + MGRALCatPuntosEntrega.Direccion AS NombreDestino " & _
            "FROM CatPrexProd " & _
            "INNER JOIN MSCCatProductos ON MSCCatProductos.IdProducto = catprexprod.Cve_ProdRas " & _
            "INNER JOIN MFacCatClientes ON MFacCatClientes.IdCliente = catprexprod.Cve_Cliente " & _
            "INNER JOIN MGRALCatPuntosEntrega ON MGRALCatPuntosEntrega.IdPuntoEntrega = catprexprod.Cve_Destino " & _
            "WHERE MSCCatProductos.Estatus = 1 AND MFacCatClientes.Estatus = 1 AND MGRALCatPuntosEntrega.Estatus = 'V' " & _
            "ORDER BY NombreProducto"
        SqlAdapter.Fill(dt)

        ds.Tables.Add(dt)
        Reporte.SetDataSource(ds)
        Reporte.SetParameterValue(0, "Catalogos/Ventas/Precio x Cliente y Destino")
        Reporte.SetParameterValue(1, Sesion.MiUsuario.Usrnomcom)
        Reporte.SetParameterValue(2, Sesion.MiEmpresa.Empnom)
        Previsualizar.Reporte = Reporte
        Previsualizar.ShowDialog()
    End Sub

    Public Sub ImpresionCorrales(Optional ByVal IdCorral As Object = Nothing)
        Dim Previsualizar As New PreVisualizarForm
        Dim Reporte As New RptCorrales
        Dim ds As New dsRptCorrales()
        Dim Modulo As String = ""
        Dim FiltroCab As New OC.PredicateExpression()
        Dim FiltroDet As New OC.PredicateExpression()

        If IsNumeric(IdCorral) Then
            FiltroCab.Add(HC.McecatCorralesCabFields.IdCorral = IdCorral)
            FiltroDet.Add(HC.McecatCorralesDetFields.IdCorral = IdCorral)
        End If
        ds.MCECatCorralesCab.Merge(CC.McecatCorralesCabCollection.GetMultiAsDataTable(FiltroCab, 0, Nothing))
        ds.MCECatCorralesDet.Merge(CC.McecatCorralesDetCollection.GetMultiAsDataTable(FiltroDet, 0, Nothing))
        ds.MCECatTiposCorral.Merge(CC.McecatTiposCorralCollection.GetMultiAsDataTable(Nothing, 0, Nothing))

        If Not ds.MCECatCorralesCab.Rows.Count > 0 Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 3)
        End If
        Reporte.SetDataSource(ds)
        Reporte.SetParameterValue(0, "Compras de Ganado/Consulta de Corrales")
        Reporte.SetParameterValue(1, Sesion.MiUsuario.Usrnomcom)
        Reporte.SetParameterValue(2, Sesion.MiEmpresa.Empnom)
        Previsualizar.Reporte = Reporte
        Previsualizar.ShowDialog()
    End Sub

    Public Sub ImpresionSalidaDeGanado(ByVal SalidaGanado As SalidaGanadoCabeceroClass)
        Dim SalidasDeGanado As New SalidaGanadoCabeceroCollectionClass
        Dim Previsualizar As New PreVisualizarForm
        Dim Reporte As Object
        Dim ds As New DataSet, dt As New dsRptCorralRecibaRastros.CorralRecibaRastroDataTable
        Dim Modulo As String = String.Empty, TipoSalida As String = String.Empty

        Select Case SalidaGanado.IdTipoReciba
            Case SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Reciba_a_Rastro
                Modulo = "Salida de Reciba a Rastro"
                Reporte = New RptSalidasDeRecibaARastro
                TipoSalida = "SALIDAS DE RECIBA A RASTRO"
            Case SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Reciba_a_Venta
                Modulo = "Salida de Reciba a Venta"
                Reporte = New RptSalidasDeRecibaAVenta
                TipoSalida = "SALIDAS DE RECIBA POR A VENTA"
            Case SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Reciba_por_Muerte
                Modulo = "Salida de Reciba por Muerte"
                Reporte = New RptSalidasDeRecibaPorMuerte
                TipoSalida = "SALIDAS DE RECIBA POR MUERTE"
            Case SalidaGanadoCabeceroClass.TipoSalida.Transferencia_de_Reciba_a_Corral
                Modulo = "Tranferencia de Reciba a Corral"
                Reporte = New RptSalidasDeRecibaPorTransferencia
                TipoSalida = "SALIDAS DE RECIBA POR TRANSFERENCIA"
            Case SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_a_Rastro
                Modulo = "Salida de Corral a Rastro"
                Reporte = New RptSalidasDeEngordaARastro
                TipoSalida = "SALIDAS DE CORRAL A RASTRO"
            Case SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_a_Venta
                Modulo = "Salida de Corral a Venta"
                Reporte = New RptSalidasDeEngordaPorVenta
                TipoSalida = "SALIDAS DE CORRAL A VENTA"
            Case SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_por_Muerte
                Modulo = "Salida de Corral por Muerte"
                Reporte = New RptSalidasDeEngordaPorMuerte
                TipoSalida = "SALIDAS DE CORRAL POR MUERTE"
            Case Else
                Modulo = "Salida de Corral por Transferencia"
                Reporte = New RptSalidasDeEngordaPorTransferencia
                TipoSalida = "SALIDAS DE CORRAL POR TRANSFERENCIA"
        End Select

        If SalidaGanado IsNot Nothing Then
            SalidasDeGanado.Add(SalidaGanado)
        End If

        For Each SalidaGanadoCabecero As SalidaGanadoCabeceroClass In SalidasDeGanado
            With SalidaGanadoCabecero
                For Each detalle As SalidaGanadoDetalleClass In .Detalles
                    Dim CorralDescripcion As String = "", RastroDescripcion As String = "", LoteDestinoDescripcion As String = ""
                    Dim CorralDestinoDescripcion As String = "", CausaMuerteDescripcion As String = "", Recuperacion As String = "NO"
                    Dim LoteOrigen As String = ""

                    If .Corral.Entidad IsNot Nothing AndAlso Not .Corral.Entidad.IsNew Then
                        CorralDescripcion = .Corral.Descripcion
                    End If

                    If .Rastro.Entidad IsNot Nothing AndAlso Not .Rastro.Entidad.IsNew Then
                        RastroDescripcion = .Rastro.Descripcion
                    End If

                    If SalidaGanadoCabecero.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_a_Rastro _
                    OrElse SalidaGanadoCabecero.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_a_Venta _
                    OrElse SalidaGanadoCabecero.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_por_Muerte _
                    OrElse (SalidaGanadoCabecero.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_por_Tranferencia AndAlso Not SalidaGanadoCabecero.LoteOrigen.Entidad.IsNew) Then
                        If detalle.Lote.Entidad IsNot Nothing AndAlso Not detalle.Lote.Entidad.IsNew Then
                            LoteOrigen = detalle.Lote.Descripcion
                        End If

                        If Not SalidaGanado.LoteDestino.Entidad.IsNew Then
                            LoteDestinoDescripcion = SalidaGanado.LoteDestino.Descripcion
                        End If
                    Else
                        If .LoteDestino.Entidad IsNot Nothing AndAlso Not .LoteDestino.Entidad.IsNew Then
                            LoteDestinoDescripcion = .LoteDestino.Descripcion
                            CorralDestinoDescripcion = .LoteDestino.Corral.Descripcion
                        End If
                    End If

                    If .Recuperacion.HasValue AndAlso .Recuperacion.Value Then
                        Recuperacion = "SI"
                    End If

                    If .CausaMuerte.ObtenerEntidad IsNot Nothing AndAlso Not .CausaMuerte.ObtenerEntidad.IsNew Then
                        CausaMuerteDescripcion = .CausaMuerte.Descripcion
                    End If

                    If Not detalle.PrecioxKilo.HasValue Then
                        detalle.PrecioxKilo = 0D
                    End If
                    dt.AddCorralRecibaRastroRow(.Folio, detalle.TipoGanado.Descripcion, detalle.IdSalidaGanadoDet, detalle.Arete, detalle.AreteSiniiga, detalle.AreteTransporte, .Fecha, CorralDescripcion, RastroDescripcion, LoteDestinoDescripcion, CorralDestinoDescripcion, .Aviso, Recuperacion, CausaMuerteDescripcion, detalle.Cabezas, detalle.Kilos, detalle.PrecioxKilo, detalle.CostoxKilo, detalle.Importe, TipoSalida, LoteOrigen, detalle.ImporteVenta)
                Next
            End With
        Next

        ds.Tables.Add(dt)
        Reporte.SetDataSource(ds)
        Reporte.SetParameterValue(0, "Compras de Ganado/" & Modulo)
        Reporte.SetParameterValue(1, Sesion.MiUsuario.Usrnomcom)
        Reporte.SetParameterValue(2, Sesion.MiEmpresa.Empnom)
        Previsualizar.Reporte = Reporte
        Previsualizar.ShowDialog()
    End Sub

#End Region

#Region "Metodos de Reporte"

    Public Sub ReporteOrdenesCompra(ByVal PLazaId As Integer, ByVal SucursalId As Integer, ByVal ProductoId As Integer, ByVal ProveedorId As Integer, ByVal Folio As String, ByVal FechaInicial As Date, ByVal FechaFinal As Date)
        Dim Previsualizar As New PreVisualizarForm
        Previsualizar.Reporte = Me.rptCompOrdenesCompra(PLazaId, SucursalId, ProductoId, ProveedorId, Folio, FechaInicial, FechaFinal)
        Previsualizar.ShowDialog()
    End Sub

    Private Function rptCompOrdenesCompra(ByVal PLazaId As Integer, ByVal SucursalId As Integer, ByVal ProductoId As Integer, ByVal ProveedorId As Integer, ByVal Folio As String, ByVal FechaInicial As Date, ByVal FechaFinal As Date) As rptCompOrdenesCompra
        Dim dsOrdenes As New dsOrdenesCompra(), dtOrdenesCompra As dsOrdenesCompra.vwCompReporteOrdenesCompraDataTable = dsOrdenes.vwCompReporteOrdenesCompra
        Dim OrdenesCompraDetalle As New CC.OrdenCompraDetalleCollection, Filtro As New OC.PredicateExpression
        Dim Relacion As New OC.RelationCollection

        rptCompOrdenesCompra = New rptCompOrdenesCompra()

        Relacion.Add(EC.OrdenCompraDetalleEntity.Relations.OrdenCompraEntityUsingIdOrdenCompra)

        If Folio = "" Then
            If PLazaId > 0 Then
                Relacion.Add(EC.OrdenCompraEntity.Relations.SucursalEntityUsingIdSucursal)
                Filtro.Add(HC.SucursalFields.CodigoPlaza = PLazaId)
            End If

            If SucursalId > 0 Then
                Filtro.Add(HC.OrdenCompraFields.IdSucursal = SucursalId)
            End If

            If ProductoId > 0 Then
                Filtro.Add(HC.OrdenCompraDetalleFields.IdProducto = ProductoId)
            End If

            If ProveedorId > 0 Then
                Filtro.Add(HC.OrdenCompraFields.IdProveedor = ProveedorId)
            End If
        Else
            Filtro.Add(HC.OrdenCompraFields.FolioOrdenCompra Mod String.Format("%{0}%", Folio))
        End If
        Filtro.Add(New OC.FieldBetweenPredicate(HC.OrdenCompraFields.FechaOrdenCompra, FechaInicial.Date, FechaFinal.Date.AddDays(1).Date.AddMilliseconds(-1)))
        OrdenesCompraDetalle.GetMulti(Filtro, 0, New OC.SortExpression(New OC.SortClause(HC.OrdenCompraFields.FechaOrdenCompra, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)), Relacion)

        For Each OrdenCompraDetalle As EC.OrdenCompraDetalleEntity In OrdenesCompraDetalle
            With OrdenCompraDetalle
                Dim EstatusOrden As String = CType(.OrdenCompra.Estatus, EstatusOrdenCompra).ToString()
                Dim Autorizada As String = IIf(.OrdenCompra.Autorizada, "Si", "No")
                Dim Recibida As String = IIf(.OrdenCompra.Recibida, "Si", "No")

                dtOrdenesCompra.AddvwCompReporteOrdenesCompraRow(.OrdenCompra.FolioOrdenCompra, "", .OrdenCompra.IdSucursal, .OrdenCompra.Sucursal.Descripcion, .OrdenCompra.Sucursal.CodigoPlaza, .OrdenCompra.Sucursal.Plaza.Descripcion, .OrdenCompra.FechaOrdenCompra, .OrdenCompra.Observaciones, .IdProducto, .Producto.Descripcion, .CantidadSolicitada, .CantidadOrdenar, .CantPendientexRecibir, .Producto.UnidadMedida.Descripcion, .OrdenCompra.IdProveedor, .OrdenCompra.Proveedor.RazonSocial, .Precio, .Descuento, .Importe, EstatusOrden, Autorizada, Recibida)
            End With
        Next

        If Not dsOrdenes.vwCompReporteOrdenesCompra.Count > 0 Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.ORDEN_COMPRA, 0) '"No se enconto ninguna Orden de Compra "
        Else
            rptCompOrdenesCompra.SetDataSource(dsOrdenes)
            rptCompOrdenesCompra.SetParameterValue(rptCompOrdenesCompra.Parameter_Modulo.ParameterFieldName, "Compras Generales/Reportes")
            rptCompOrdenesCompra.SetParameterValue(rptCompOrdenesCompra.Parameter_NomEmpresa.ParameterFieldName, Me.Sesion.MiEmpresa.Empnom)
            rptCompOrdenesCompra.SetParameterValue(rptCompOrdenesCompra.Parameter_Usuario.ParameterFieldName, Me.Sesion.MiUsuario.Usrnomcom)
            Return rptCompOrdenesCompra
        End If
    End Function

    Public Sub ReporteComAliProdvsSur(ByVal Dia As Date)
        Dim Previsualizar As New PreVisualizarForm
        Previsualizar.Reporte = Me.RptComAlimProdvsSur(Dia)
        Previsualizar.ShowDialog()
    End Sub

    Private Function RptComAlimProdvsSur(ByVal Dia As Date) As RptComAlimProdvsSur
        Dim dsComAlimProdvsSur As New dsRptComAlimProdvsSur, dtComAlimProdvsSur As dsRptComAlimProdvsSur.DataTable1DataTable = dsComAlimProdvsSur.DataTable1
        Dim Query As String = "SELECT MCatCompProductos.PdIdProducto as IdFormula, MCatCompProductos.PdDescripcion as Formula" & _
            ", sum(DetAplFor.CantServ1 + DetAplFor.CantServ2 + DetAplFor.CantServ3 + DetAplFor.CantServ4) as ProducidaDia" & _
            ", (SELECT sum(CabPrepForm.CantRealaPrep) FROM CabPrepForm WHERE CabPrepForm.Estatus = 1 and CabPrepForm.Cve_Formula = MCatCompProductos.PdIdProducto and CabPrepForm.Fec_PrepForm between @FechaInicial and @FechaFinal) as SurtidaDia" & _
            " FROM MCatCompProductos INNER JOIN DetAplFor on DetAplFor.Cve_Formula = MCatCompProductos.PdIdProducto" & _
            " INNER JOIN CabAplFor on CabAplFor.Fol_AplF = DetAplFor.Fol_AplF" & _
            " WHERE CabAplFor.Estatus = 1 and CabAplFor.FechaAplicacion between @FechaInicial and @FechaFinal" & _
            " GROUP BY MCatCompProductos.PdIdProducto, MCatCompProductos.PdDescripcion" & _
            " ORDER BY MCatCompProductos.PdDescripcion"
        Dim da As New SqlDataAdapter(Query, HC.DbUtils.ActualConnectionString)

        RptComAlimProdvsSur = New RptComAlimProdvsSur()

        da.SelectCommand.Parameters.Add("@FechaInicial", SqlDbType.DateTime).Value = Dia.Date
        da.SelectCommand.Parameters.Add("@FechaFinal", SqlDbType.DateTime).Value = Dia.Date.AddDays(1).AddTicks(-1)
        da.SelectCommand.Connection.Open()
        da.SelectCommand.Prepare()
        da.Fill(dtComAlimProdvsSur)

        If Not dtComAlimProdvsSur.Rows.Count > 0 Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 9)
        End If

        For Each Fila As dsRptComAlimProdvsSur.DataTable1Row In dtComAlimProdvsSur.Rows
            Fila.DiferenciaPorcentual = Math.Abs(Fila.ProducidaDia - Fila.SurtidaDia) * 100

            If Fila.ProducidaDia > Fila.SurtidaDia And Fila.ProducidaDia > 0 Then
                Fila.DiferenciaPorcentual /= Fila.ProducidaDia
            Else
                If Fila.ProducidaDia < Fila.SurtidaDia And Fila.SurtidaDia > 0 Then
                    Fila.DiferenciaPorcentual = Fila.DiferenciaPorcentual / Fila.SurtidaDia * -1
                Else
                    Fila.DiferenciaPorcentual = 0
                End If
            End If
        Next

        RptComAlimProdvsSur.SetDataSource(dsComAlimProdvsSur)
        RptComAlimProdvsSur.SetParameterValue(RptComAlimProdvsSur.Parameter_Empresa.ParameterFieldName, Me.Sesion.MiEmpresa.Empnom)
        RptComAlimProdvsSur.SetParameterValue(RptComAlimProdvsSur.Parameter_Modulo.ParameterFieldName, "Manejo de Ganado/Reportes/Aplicacion Formula/Comparativo de Alimentos Producido vs Surtido en Corrales")
        RptComAlimProdvsSur.SetParameterValue(RptComAlimProdvsSur.Parameter_Usuario.ParameterFieldName, Me.Sesion.MiUsuario.Usrnomcom)
        RptComAlimProdvsSur.SetParameterValue(RptComAlimProdvsSur.Parameter_Dia.ParameterFieldName, Dia.ToString("dd/MMM/yyyy"))
        Return RptComAlimProdvsSur
    End Function

    Public Function ReporteEmbarquesxDestinosyCliente(ByVal IdCliente As Integer, Optional ByVal RangoDeFechas As RangoFechas = Nothing) As DataTable
        Dim dtRptEmbarquesxDestinosCliente As New dsRptEmbarquesxDestinosCliente.DataTable1DataTable, dt As New DataTable
        Dim Query As String = "Select MSCCatProductos.IdProducto as IdProducto, MSCCatProductos.Descripcion as DescripcionProducto, MGRALCatPuntosEntrega.IdPuntoEntrega, MGRALCatPuntosEntrega.Descripcion as DescripcionDestino, count(MFacEmbarquesDet.IdFolioEtiqueta) as Cantidad" & _
            " From MFacEmbarquesDet inner join MFacEmbarquesCab on MFacEmbarquesDet.IdFolioEmbarque = MFacEmbarquesCab.IdFolioEmbarque and MFacEmbarquesCab.IdFolioEmbarque <> 'X'" & _
            " Inner join MSCCatProductos on MSCCatProductos.idproducto = MFacEmbarquesDet.idproducto and MSCCatProductos.Corte = 1" & _
            " Inner join MGRALCatPuntosEntrega on MfacEmbarquesCab.IdPuntoEntrega = MGRALCatPuntosEntrega.IdPuntoEntrega" & _
            " Where MFacEmbarquesDet.IdFolioEtiqueta <> '' And MFacEmbarquesCab.IdClienteAsignado = @IdCliente"
        Dim GroupQuery As String = " Group by MSCCatProductos.IdProducto, MSCCatProductos.Descripcion, MGRALCatPuntosEntrega.IdPuntoEntrega, MGRALCatPuntosEntrega.Descripcion" & _
            " Order by DescripcionDestino"
        Dim WhereOpcional As String = " And MFacEmbarquesCab.FechaEmbarque between @FechaInicio and @FechaFinal"
        Dim da As New SqlDataAdapter(Query, HC.DbUtils.ActualConnectionString)

        da.SelectCommand.Parameters.Add("@IdCliente", SqlDbType.Int).Value = IdCliente

        If RangoDeFechas IsNot Nothing Then
            da.SelectCommand.CommandText &= WhereOpcional
            da.SelectCommand.Parameters.Add("@FechaInicio", SqlDbType.DateTime).Value = RangoDeFechas.FechaInicial.Value.Date
            da.SelectCommand.Parameters.Add("@FechaFinal", SqlDbType.DateTime).Value = RangoDeFechas.FechaFinal.Value.Date.AddDays(1).AddTicks(-1)
        End If
        da.SelectCommand.CommandText &= GroupQuery
        da.SelectCommand.Connection.Open()
        da.SelectCommand.Prepare()
        da.Fill(dtRptEmbarquesxDestinosCliente)

        If Not dtRptEmbarquesxDestinosCliente.Rows.Count > 0 Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 9)
        Else
            Dim Periodo As String = String.Empty

            If RangoDeFechas IsNot Nothing Then
                Periodo &= RangoDeFechas.FechaInicial.Value.ToString("dd/MMM/yyyy").ToUpper & " a " & RangoDeFechas.FechaFinal.Value.ToString("dd/MMM/yyyy").ToUpper
            End If
            dt.Columns.Add("IdProducto", GetType(String)).Caption = Periodo
        End If

        For Each Fila As dsRptEmbarquesxDestinosCliente.DataTable1Row In dtRptEmbarquesxDestinosCliente.Rows
            Dim Columna As DataColumn = Nothing
            Dim Busqueda() As DataRow = Nothing

            For Each Col As DataColumn In dt.Columns
                If Col.ColumnName = Fila.IdPuntoEntrega.ToString() Then
                    Columna = Col
                    Exit For
                End If
            Next

            If Columna Is Nothing Then
                Columna = dt.Columns.Add(Fila.IdPuntoEntrega.ToString, GetType(Int64))
                Columna.Caption = Fila.DescripcionDestino & " (" & Fila.IdPuntoEntrega & ")"
            End If
            Busqueda = dt.Select("IdProducto ='" & Fila.DescripcionProducto & " (" & Fila.IdProducto & ")'")

            If Busqueda IsNot Nothing AndAlso Busqueda.Length > 0 Then
                Busqueda(0)(Columna.Ordinal) = Fila.Cantidad
            Else
                Dim NuevaFila As DataRow = dt.NewRow
                NuevaFila(0) = Fila.DescripcionProducto & " " & "(" & Fila.IdProducto.ToString & ")"
                NuevaFila(Columna.Ordinal) = Fila.Cantidad
                dt.Rows.Add(NuevaFila)
            End If
        Next
        Return dt
    End Function

    Public Sub ReporteProdAlimSugDia(ByVal Resumen As Boolean, ByVal Fecha As Date)
        Dim Previsualizar As New PreVisualizarForm, Reporte As Object

        If Resumen Then
            Reporte = Me.RptProdAlimSugAlDiaCon(Fecha)
        Else
            Reporte = Me.RptProdAlimSugDelDia(Fecha)
        End If

        Previsualizar.Reporte = Reporte
        Previsualizar.ShowDialog()
    End Sub

    Private Function RptProdAlimSugAlDiaCon(ByVal Fecha As Date) As RptProdAlimSugAlDiaCon
        Dim dsProdAlimSugAlDia As New dsRptProdAlimSugAlDia, dtProdAlimSugAlDia As dsRptProdAlimSugAlDia.DataTable1DataTable = dsProdAlimSugAlDia.DataTable1
        Dim LoteFormulas As New CC.McecatLotesCabForCollection, Filtro As New OC.PredicateExpression, Relacion As New OC.RelationCollection

        RptProdAlimSugAlDiaCon = New RptProdAlimSugAlDiaCon()

        Filtro.Add(HC.McecatLotesCabFields.Estatus = LoteClass.EstatusLote.VIGENTE And HC.McecatCorralesCabFields.Estatus = 1)
        Filtro.Add(HC.McecatLotesCabForFields.FecInicio <= Fecha.Date And HC.McecatLotesCabForFields.FecFinal >= Fecha.Date)
        Relacion.Add(EC.McecatLotesCabForEntity.Relations.McecatLotesCabEntityUsingIdLote, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)
        Relacion.Add(EC.McecatLotesCabEntity.Relations.McecatCorralesCabEntityUsingIdCorral, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)
        LoteFormulas.GetMulti(Filtro, 0, Nothing, Relacion)

        For Each LoteFormula As EC.McecatLotesCabForEntity In LoteFormulas
            dtProdAlimSugAlDia.AddDataTable1Row(LoteFormula.McecatLotesCab.IdCorral, LoteFormula.McecatLotesCab.McecatCorralesCab.NombreCorral, _
            LoteFormula.IdLote, LoteFormula.McecatLotesCab.NombreLote, LoteFormula.IdFormula, LoteFormula.Producto.Descripcion, _
            LoteFormula.McecatLotesCab.SaldoCabezas, LoteFormula.ConsxCabKil)
        Next

        If Not dtProdAlimSugAlDia.Rows.Count > 0 Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 9)
        End If

        RptProdAlimSugAlDiaCon.SetDataSource(dsProdAlimSugAlDia)
        RptProdAlimSugAlDiaCon.SetParameterValue(RptProdAlimSugAlDiaCon.Parameter_Empresa.ParameterFieldName, Me.Sesion.MiEmpresa.Empnom)
        RptProdAlimSugAlDiaCon.SetParameterValue(RptProdAlimSugAlDiaCon.Parameter_Modulo.ParameterFieldName, "Manejo de Ganado/Reportes/Aplicacion Formula/Producción Sugerido del Día")
        RptProdAlimSugAlDiaCon.SetParameterValue(RptProdAlimSugAlDiaCon.Parameter_Usuario.ParameterFieldName, Me.Sesion.MiUsuario.Usrnomcom)
        RptProdAlimSugAlDiaCon.SetParameterValue(RptProdAlimSugAlDiaCon.Parameter_Dia.ParameterFieldName, Fecha)
        Return RptProdAlimSugAlDiaCon
    End Function

    Private Function RptProdAlimSugDelDia(ByVal Fecha As Date) As RptProdAlimSugDelDia
        Dim dsProdAlimSugAlDia As New dsRptProdAlimSugAlDia, dtProdAlimSugAlDia As dsRptProdAlimSugAlDia.DataTable1DataTable = dsProdAlimSugAlDia.DataTable1
        Dim LoteFormulas As New CC.McecatLotesCabForCollection, Filtro As New OC.PredicateExpression, Relacion As New OC.RelationCollection

        RptProdAlimSugDelDia = New RptProdAlimSugDelDia()

        Filtro.Add(HC.McecatLotesCabFields.Estatus = LoteClass.EstatusLote.VIGENTE And HC.McecatCorralesCabFields.Estatus = 1)
        Filtro.Add(HC.McecatLotesCabForFields.FecInicio <= Fecha.Date And HC.McecatLotesCabForFields.FecFinal >= Fecha.Date)
        Relacion.Add(EC.McecatLotesCabForEntity.Relations.McecatLotesCabEntityUsingIdLote, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)
        Relacion.Add(EC.McecatLotesCabEntity.Relations.McecatCorralesCabEntityUsingIdCorral, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)
        LoteFormulas.GetMulti(Filtro, 0, Nothing, Relacion)

        For Each LoteFormula As EC.McecatLotesCabForEntity In LoteFormulas
            dtProdAlimSugAlDia.AddDataTable1Row(LoteFormula.McecatLotesCab.IdCorral, LoteFormula.McecatLotesCab.McecatCorralesCab.NombreCorral, _
            LoteFormula.IdLote, LoteFormula.McecatLotesCab.NombreLote, LoteFormula.IdFormula, LoteFormula.Producto.Descripcion, _
            LoteFormula.McecatLotesCab.SaldoCabezas, LoteFormula.ConsxCabKil)
        Next

        If Not dtProdAlimSugAlDia.Rows.Count > 0 Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 9)
        End If

        RptProdAlimSugDelDia.SetDataSource(dsProdAlimSugAlDia)
        RptProdAlimSugDelDia.SetParameterValue(RptProdAlimSugDelDia.Parameter_Empresa.ParameterFieldName, Me.Sesion.MiEmpresa.Empnom)
        RptProdAlimSugDelDia.SetParameterValue(RptProdAlimSugDelDia.Parameter_Modulo.ParameterFieldName, "Manejo de Ganado/Reportes/Aplicacion Formula/Producción Sugerido del Día")
        RptProdAlimSugDelDia.SetParameterValue(RptProdAlimSugDelDia.Parameter_Usuario.ParameterFieldName, Me.Sesion.MiUsuario.Usrnomcom)
        RptProdAlimSugDelDia.SetParameterValue(RptProdAlimSugDelDia.Parameter_Dia.ParameterFieldName, Fecha)
        Return RptProdAlimSugDelDia
    End Function

    Public Sub ReporteAlimentosDeServicioEnCorrales(ByVal FechaInicio As Date)
        Dim Previsualizar As New PreVisualizarForm
        Previsualizar.Reporte = RptAlimentosServCorrales(FechaInicio)
        Previsualizar.ShowDialog()
    End Sub

    Private Function RptAlimentosServCorrales(ByVal FechaInicio As Date) As RptAlimentosServCorrales
        Dim dsAlimentosServCorrales As New dsRptAlimentosServCorrales, dtAlimentosServCorrales As dsRptAlimentosServCorrales.DataTable1DataTable = dsAlimentosServCorrales.DataTable1
        Dim Lotes As New LoteCollectionClass, Filtro As New OC.PredicateExpression(New OC.FieldBetweenPredicate(HC.CabAplForFields.FechaAplicacion, FechaInicio.Date, FechaInicio.AddDays(7).Date.AddTicks(-1)))
        Dim Relacion As New OC.RelationCollection

        RptAlimentosServCorrales = New RptAlimentosServCorrales()

        Relacion.Add(EC.McecatLotesCabEntity.Relations.McecatCorralesCabEntityUsingIdCorral)
        Lotes.Obtener(HC.McecatLotesCabFields.Estatus = LoteClass.EstatusLote.VIGENTE And HC.McecatCorralesCabFields.Estatus = 1, Nothing, Relacion)

        For Each Lote As LoteClass In Lotes
            Dim Dias(6) As Decimal
            Dim FiltroDetApl As New OC.PredicateExpression(HC.DetAplForFields.CveLote = Lote.IdLote And HC.CabAplForFields.Estatus = AplicacionFormulaClass.EstatusAplicacionFormula.VIGENTE)
            Dim RelacionDetApl As New OC.RelationCollection(), Orden As New OC.SortExpression(New OC.SortClause(HC.CabAplForFields.FechaAplicacion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
            Dim FormulasAplicadas As New CC.DetAplForCollection

            RelacionDetApl.Add(EC.DetAplForEntity.Relations.CabAplForEntityUsingFolAplF)
            FiltroDetApl.Add(Filtro)
            FormulasAplicadas.GetMulti(FiltroDetApl, 0, Orden, RelacionDetApl)

            For i As Integer = 0 To 6
                Dim Kilos As Decimal = 0D, Cabezas As Decimal = 0D

                For Each FormulaAplicada As EC.DetAplForEntity In FormulasAplicadas
                    If FechaInicio.AddDays(i).Date = FormulaAplicada.CabAplFor.FechaAplicacion.Date Then
                        Kilos += FormulaAplicada.KilosxLote
                        Cabezas += FormulaAplicada.Cabezas
                    End If
                Next

                If Cabezas <> 0D Then
                    Dias(i) = Kilos / Cabezas
                End If
            Next
            dtAlimentosServCorrales.AddDataTable1Row(Lote.IdCorral, Lote.NombreCorral, Lote.IdLote, Lote.Descripcion, Dias(0), Dias(1), Dias(2), Dias(3), Dias(4), Dias(5), Dias(6))
        Next

        If Not dtAlimentosServCorrales.Rows.Count > 0 Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 9)
        End If

        RptAlimentosServCorrales.SetDataSource(dsAlimentosServCorrales)
        RptAlimentosServCorrales.SetParameterValue(RptAlimentosServCorrales.Parameter_Empresa.ParameterFieldName, Me.Sesion.MiEmpresa.Empnom)
        RptAlimentosServCorrales.SetParameterValue(RptAlimentosServCorrales.Parameter_Modulo.ParameterFieldName, "Manejo de Ganado/Reportes/Aplicacion Formula/Alimentos Servidos en Corrales/Cbz")
        RptAlimentosServCorrales.SetParameterValue(RptAlimentosServCorrales.Parameter_Usuario.ParameterFieldName, Me.Sesion.MiUsuario.Usrnomcom)
        RptAlimentosServCorrales.SetParameterValue(RptAlimentosServCorrales.Parameter_FechaDia1.ParameterFieldName, FechaInicio)
        RptAlimentosServCorrales.SetParameterValue(RptAlimentosServCorrales.Parameter_FechaDia2.ParameterFieldName, FechaInicio.AddDays(1))
        RptAlimentosServCorrales.SetParameterValue(RptAlimentosServCorrales.Parameter_FechaDia3.ParameterFieldName, FechaInicio.AddDays(2))
        RptAlimentosServCorrales.SetParameterValue(RptAlimentosServCorrales.Parameter_FechaDia4.ParameterFieldName, FechaInicio.AddDays(3))
        RptAlimentosServCorrales.SetParameterValue(RptAlimentosServCorrales.Parameter_FechaDia5.ParameterFieldName, FechaInicio.AddDays(4))
        RptAlimentosServCorrales.SetParameterValue(RptAlimentosServCorrales.Parameter_FechaDia6.ParameterFieldName, FechaInicio.AddDays(5))
        RptAlimentosServCorrales.SetParameterValue(RptAlimentosServCorrales.Parameter_FechaDia7.ParameterFieldName, FechaInicio.AddDays(6))
        Return RptAlimentosServCorrales
    End Function

    Public Sub ReporteServidasPorFecha(ByVal Fecha As Date)
        Dim Previsualizar As New PreVisualizarForm
        Previsualizar.Reporte = RptServidasxFecha(Fecha)
        Previsualizar.ShowDialog()
    End Sub

    Private Function RptServidasxFecha(ByVal Fecha As Date) As RptServidasxFecha
        Dim ds As New DataSet, dtServidasxFecha As New dsRptServidasxFecha.DataTable1DataTable
        Dim Query As String = "SELECT DetAplFor.Fol_AplF as Folio " & _
         ", DetAplFor.Cve_Corral as IdCorral " & _
         ", MCECatCorralesCab.NombreCorral " & _
         ", DetAplFor.Cve_Lote as IdLote " & _
         ", MCECatLotesCab.NombreLote " & _
         ", MCatCompProductos.PdIdProducto as IdFormula " & _
         ", MCatCompProductos.PdDescripcion AS Formula " & _
         ", DetAplFor.CantServ1 " & _
         ", DetAplFor.CantServ2 " & _
         ", DetAplFor.CantServ3 " & _
         ", DetAplFor.CantServ4 " & _
         ", DetAplFor.costo as Costo " & _
         "FROM DetAplFor inner join CabAplFor on DetAplFor.Fol_AplF = CabAplFor.Fol_AplF " & _
         "inner join MCECatCorralesCab on DetAplFor.Cve_Corral = MCECatCorralesCab.IdCorral " & _
         "inner join MCECatLotesCab on MCECatLotesCab.IdLote = DetAplFor.Cve_Lote " & _
         "inner join MCatCompProductos on DetAplFor.Cve_Formula = MCatCompProductos.PdIdProducto " & _
            "WHERE CabAplFor.Estatus = 1 " & _
           "AND CabAplFor.FechaAplicacion Between '" & Fecha.ToString("yyyyMMdd") & "' AND '" & Fecha.AddDays(1).ToString("yyyyMMdd") & "'" & _
         " ORDER BY DetAplFor.Fol_AplF " & _
         ", MCECatCorralesCab.NombreCorral " & _
         ", DetAplFor.Cve_Lote " & _
         ", MCatCompProductos.PdDescripcion"
        Dim da As New SqlDataAdapter(Query, HC.DbUtils.ActualConnectionString)

        RptServidasxFecha = New RptServidasxFecha()

        da.Fill(dtServidasxFecha)

        If Not dtServidasxFecha.Rows.Count > 0 Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 9)
        End If

        ds.Tables.Add(dtServidasxFecha)
        RptServidasxFecha.SetDataSource(ds)
        RptServidasxFecha.SetParameterValue(RptServidasxFecha.Parameter_Empresa.ParameterFieldName, Me.Sesion.MiEmpresa.Empnom)
        RptServidasxFecha.SetParameterValue(RptServidasxFecha.Parameter_Modulo.ParameterFieldName, "Manejo de Ganado/Reportes/Aplicacion Formula/Servidas por Fecha")
        RptServidasxFecha.SetParameterValue(RptServidasxFecha.Parameter_Usuario.ParameterFieldName, Me.Sesion.MiUsuario.Usrnomcom)
        Return RptServidasxFecha
    End Function

    Public Sub ReporteSaldosClientesAcumulados(ByVal bdWorker As BackgroundWorker, ByVal OrdenarPorSaldoActual As Boolean, ByVal IdClienteInicial As Integer, ByVal IdClienteFinal As Integer, ByVal FechaInicial As Date, ByVal FechaFinal As Date)
        Dim Previsualizar As New PreVisualizarForm
        Previsualizar.Reporte = RptSaldosClientesAcum(bdWorker, OrdenarPorSaldoActual, IdClienteInicial, IdClienteFinal, FechaInicial, FechaFinal)
        bdWorker.ReportProgress(100)
        Previsualizar.ShowDialog()
    End Sub

    Private Function RptSaldosClientesAcum(ByRef bdWorker As BackgroundWorker, ByVal OrdenarPorSaldoActual As Boolean, ByVal IdClienteInicial As Integer, ByVal IdClienteFinal As Integer, ByVal FechaInicial As Date, ByVal FechaFinal As Date) As RptSaldosClientesAcum
        Dim dsSaldosClientesAcum As New dsRptSaldosClientesAcum, dtSaldosClientesAcum As dsRptSaldosClientesAcum.DataTable1DataTable = dsSaldosClientesAcum.DataTable1
        Dim Query As String = "Select MFacCatClientes.IdCliente, MFacCatClientes.Nombre as NombreCliente" & _
            ", isnull(Sum(FacturasClientesCab.Total),0) - isnull((select sum(PagoDeCtes.ImpteIngreso + PagoDeCtes.ImpteNotaCred + PagoDeCtes.ImpteChePos)" & _
                " From PagoDeCtes INNER JOIN FacturasClientesCab fac on PagoDeCtes.Fol_Factura = fac.NoFactura AND fac.Estatus <> 'X'" & _
                " WHERE PagoDeCtes.Estatus <> 'C' AND fac.IdClienteCargo = MFacCatClientes.IdCliente AND PagoDeCtes.Fec_Ingreso <= @FechaInicial),0) as SaldoAnterior" & _
            ", isnull((Select Sum(fac.Total) FROM FacturasClientesCab fac WHERE fac.Estatus <> 'X' AND fac.IdClienteCargo = MFacCatClientes.IdCliente AND fac.FechaFactura between @FechaInicial AND @FechaFinal), 0) as Cargos" & _
            ", isnull((select sum(PagoDeCtes.ImpteIngreso + PagoDeCtes.ImpteNotaCred + PagoDeCtes.ImpteChePos)" & _
                " From PagoDeCtes INNER JOIN FacturasClientesCab on FacturasClientesCab.NoFactura = PagoDeCtes.Fol_Factura AND FacturasClientesCab.Estatus <> 'X'" & _
                " WHERE PagoDeCtes.Estatus <> 'C' AND FacturasClientesCab.IdClienteCargo = MFacCatClientes.IdCliente AND PagoDeCtes.Fec_Ingreso between @FechaInicial AND @FechaFinal), 0) as Abonos" & _
            " FROM FacturasClientesCab INNER JOIN MFacCatClientes on MFacCatClientes.IdCliente = FacturasClientesCab.IdClienteCargo" & _
            " WHERE FacturasClientesCab.Estatus <> 'X' AND FacturasClientesCab.FechaFactura <= @FechaInicial" & _
            " AND MFacCatClientes.IdCliente >= @IdClienteInicial AND MFacCatClientes.IdCliente <= @IdClienteFinal" & _
            " Group by MFacCatClientes.IdCliente, MFacCatClientes.Nombre" & _
            " Order By MFacCatClientes.Nombre"
        Dim da As New SqlDataAdapter(Query, HC.DbUtils.ActualConnectionString)

        RptSaldosClientesAcum = New RptSaldosClientesAcum()

        da.SelectCommand.Parameters.Add("@FechaInicial", SqlDbType.DateTime).Value = FechaInicial.Date
        da.SelectCommand.Parameters.Add("@FechaFinal", SqlDbType.DateTime).Value = FechaFinal.Date.AddTicks(TimeSpan.TicksPerDay - 1)
        da.SelectCommand.Parameters.Add("@IdClienteInicial", SqlDbType.Int).Value = IdClienteInicial
        da.SelectCommand.Parameters.Add("@IdClienteFinal", SqlDbType.Int).Value = IdClienteFinal
        bdWorker.ReportProgress(10)

        da.SelectCommand.Connection.Open()
        da.SelectCommand.Prepare()
        bdWorker.ReportProgress(20)

        da.Fill(dtSaldosClientesAcum)
        bdWorker.ReportProgress(30)

        If Not dtSaldosClientesAcum.Rows.Count > 0 Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 9)
        Else
            If OrdenarPorSaldoActual Then
                Dim dt As New dsRptSaldosClientesAcum.DataTable1DataTable

                For Each Fila As DataRow In dtSaldosClientesAcum.Select("", "SaldoActual desc")
                    dt.ImportRow(Fila)
                Next
                bdWorker.ReportProgress(50)
                dsSaldosClientesAcum.Tables.RemoveAt(0)
                dsSaldosClientesAcum.Tables.Add(dt)
            End If
        End If
        bdWorker.ReportProgress(60)
        RptSaldosClientesAcum.SetDataSource(dsSaldosClientesAcum)
        RptSaldosClientesAcum.SetParameterValue(RptSaldosClientesAcum.Parameter_NombreEmpresa.ParameterFieldName, Me.Sesion.MiEmpresa.Empnom)
        RptSaldosClientesAcum.SetParameterValue(RptSaldosClientesAcum.Parameter_MenuOpcion.ParameterFieldName, "CuentasxPagar/Reportes/Estados de Cuenta")
        RptSaldosClientesAcum.SetParameterValue(RptSaldosClientesAcum.Parameter_NombreUsuario.ParameterFieldName, Me.Sesion.MiUsuario.Usrnomcom)
        RptSaldosClientesAcum.SetParameterValue(RptSaldosClientesAcum.Parameter_Periodo.ParameterFieldName, FechaInicial.ToString("dd/MMM/yyyy").ToUpper() & " al " & FechaFinal.ToString("dd/MMM/yyyy").ToUpper())
        bdWorker.ReportProgress(70)
        Return RptSaldosClientesAcum
    End Function

    Public Sub ReporteAnalisisLotes(Optional ByVal Lot As LoteClass = Nothing)
        Dim Previsualizar As New PreVisualizarForm
        Previsualizar.Reporte = RptAnalisisLotes(Lot)
        Previsualizar.ShowDialog()
    End Sub

    Private Function RptAnalisisLotes(Optional ByVal Lot As LoteClass = Nothing) As RptAnalisisLotes
        Dim dsAnalisisLote As New dsRptAnalisisLotes, dtAnalisisLote As dsRptAnalisisLotes.DataTable1DataTable = dsAnalisisLote.DataTable1
        Dim Lotes As New LoteCollectionClass, Relaciones As New OC.RelationCollection, Ordenamiento As New OC.SortExpression(New OC.SortClause(HC.CabAplForFields.FechaAplicacion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
        Dim dtDetAplFor As DataTable = Nothing, dtCabAplFor As DataTable = Nothing

        RptAnalisisLotes = New RptAnalisisLotes
        Relaciones.Add(EC.DetAplForEntity.Relations.CabAplForEntityUsingFolAplF, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)
        Relaciones.Add(EC.DetAplForEntity.Relations.McecatCorralesCabEntityUsingCveCorral, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)

        If Lot IsNot Nothing Then
            Lotes.Add(Lot)
        Else
            Lotes = Me.ObtenerLotes(LoteClass.EstatusLote.VIGENTE)
        End If

        For i As Integer = Lotes.Count - 1 To 0 Step -1
            Dim ConsumoPromedio As Decimal = 0D, Dias As Integer = 0, ConsumoEsperado As Decimal = 0D
            Dim NombreFormula As String = String.Empty, IdFormula As Integer = 0

            For Each LoteFormula As LoteFormulaClass In Lotes(i).ProgramacionFormulas
                If LoteFormula.FecInicio <= Now AndAlso LoteFormula.FecFinal >= Now Then
                    IdFormula = LoteFormula.IdFormula
                    NombreFormula = LoteFormula.Formula.Descripcion
                    Dias = LoteFormula.DiasFormula
                    ConsumoEsperado = LoteFormula.ConsxCabKil
                    Exit For
                End If
            Next

            dtDetAplFor = CC.DetAplForCollection.GetMultiAsDataTable(HC.DetAplForFields.CveLote = Lotes(i).IdLote And _
            HC.DetAplForFields.CveCorral = Lotes(i).IdCorral And _
            HC.CabAplForFields.Estatus <> AplicacionFormulaClass.EstatusAplicacionFormula.CANCELADA And _
            HC.McecatCorralesCabFields.Estatus = 1, Nothing, Nothing, Relaciones)

            If Not dtDetAplFor.Rows.Count > 0 Then
                Lotes.RemoveAt(i)
            Else
                Dim Contador As Integer = 0, DiaInicial As Date, DiaFinal As Date
                dtCabAplFor = CC.CabAplForCollection.GetMultiAsDataTable(HC.CabAplForFields.FolAplF = dtDetAplFor.Rows(0)("FolAplF"), 0, Nothing)
                DiaInicial = CType(dtCabAplFor.Rows(0)("FechaAplicacion"), Date)
                dtCabAplFor = CC.CabAplForCollection.GetMultiAsDataTable(HC.CabAplForFields.FolAplF = dtDetAplFor.Rows(dtDetAplFor.Rows.Count - 1)("FolAplF"), 0, Nothing)
                DiaFinal = CType(dtCabAplFor.Rows(0)("FechaAplicacion"), Date)

                For Each Fila As DataRow In dtDetAplFor.Rows
                    Dim dtDetApl As DataTable = CC.DetAplForCollection.GetMultiAsDataTable(HC.DetAplForFields.CveCorral = Fila("CveCorral") And _
                    HC.DetAplForFields.CveLote = Fila("CveLote") And HC.DetAplForFields.CveFormula = IdFormula, 0, Nothing)

                    Dim Fecha As Date = #1/1/1900#

                    For Each FilaDet As DataRow In dtDetApl.Rows
                        Dim dtCabApl As DataTable = CC.CabAplForCollection.GetMultiAsDataTable(HC.CabAplForFields.FolAplF = FilaDet("FolAplF"), 0, Nothing)

                        If Contador >= 7 Then
                            Exit For
                        Else
                            If Fecha <> CType(dtCabApl.Rows(0)("FechaAplicacion"), Date) Then
                                Contador += 1
                                Fecha = CType(dtCabApl.Rows(0)("FechaAplicacion"), Date)

                                If CType(FilaDet("Cabezas"), Integer) <> 0 Then
                                    ConsumoPromedio += FilaDet("KilosxLote") / FilaDet("Cabezas")
                                End If
                            Else
                                If Fecha.Year = CType(dtCabApl.Rows(0)("FechaAplicacion"), Date).Year _
                                AndAlso Fecha.Month = CType(dtCabApl.Rows(0)("FechaAplicacion"), Date).Month _
                                AndAlso Fecha.Day = CType(dtCabApl.Rows(0)("FechaAplicacion"), Date).Day Then
                                    ConsumoPromedio += FilaDet("KilosxLote") / FilaDet("Cabezas")
                                End If
                            End If
                        End If
                    Next
                Next
                If ConsumoPromedio > 0 AndAlso Contador > 0 Then
                    ConsumoPromedio /= Contador
                End If
                dtAnalisisLote.AddDataTable1Row(Lotes(i).IdCorral, Lotes(i).NombreCorral, Lotes(i).IdLote, Lotes(i).Descripcion, NombreFormula, Dias, Lotes(i).SaldoKilos, ConsumoEsperado, (DiaFinal.Ticks - DiaInicial.Ticks) / TimeSpan.TicksPerDay, ConsumoPromedio, Lotes(i).SaldoKilos * Lotes(i).PesoProyectadoxCbz * Lotes(i).SaldoCabezas)
            End If
        Next

        If Not Lotes.Count > 0 Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 9)
        End If

        RptAnalisisLotes.SetDataSource(dsAnalisisLote)
        RptAnalisisLotes.SetParameterValue(RptAnalisisLotes.Parameter_Empresa.ParameterFieldName, Me.Sesion.MiEmpresa.Empnom)
        RptAnalisisLotes.SetParameterValue(RptAnalisisLotes.Parameter_Modulo.ParameterFieldName, "Engorda/Reportes/Analisis de Lotes")
        RptAnalisisLotes.SetParameterValue(RptAnalisisLotes.Parameter_Usuario.ParameterFieldName, Me.Sesion.MiUsuario.Usrnomcom)
        Return RptAnalisisLotes
    End Function

    Public Sub ReporteMotivoDevolucion()
        Dim Previsualizar As New PreVisualizarForm
        Previsualizar.Reporte = RptMotivoDevolucion()
        Previsualizar.ShowDialog()
    End Sub

    Private Function RptMotivoDevolucion() As RptMotivoDevolucion
        Dim Coleccion As New MotivoDevolucionColeccionClass

        RptMotivoDevolucion = New RptMotivoDevolucion()
        Coleccion.Obtener()

        RptMotivoDevolucion.SetDataSource(Coleccion)
        RptMotivoDevolucion.SetParameterValue(RptMotivoDevolucion.Parameter_Empresa.ParameterFieldName, Me.Sesion.MiEmpresa.Empnom)
        RptMotivoDevolucion.SetParameterValue(RptMotivoDevolucion.Parameter_Modulo.ParameterFieldName, "Catalogos/Produccion/Motivos de Devolucion")
        RptMotivoDevolucion.SetParameterValue(RptMotivoDevolucion.Parameter_Usuario.ParameterFieldName, Me.Sesion.MiUsuario.Usrnomcom)
        Return RptMotivoDevolucion
    End Function
    Public Sub ReporteRelacionProductoRastro()
        Dim Previsualizar As New PreVisualizarForm
        Previsualizar.Reporte = RptRelacionProductoRastro()
        Previsualizar.ShowDialog()
    End Sub

    Private Function RptRelacionProductoRastro() As RptRelacionProductoRastro
        Dim Coleccion As New MSCRelacionProductosRastrosCollectionClass
        Dim Tabla As New DsRelacionProductoRastro
        Coleccion.Obtener()

        For Each Relacion As MSCRelacionProductosRastrosClass In Coleccion
            Tabla.DataTable1.AddDataTable1Row(Relacion.IdRastro, Relacion.Entidad.CatRastros.Descripcion, Relacion.IdProducto, Relacion.DescripcionProducto, Relacion.CodigoProductoRastro)
        Next

        RptRelacionProductoRastro = New RptRelacionProductoRastro

        RptRelacionProductoRastro.SetDataSource(Tabla)
        RptRelacionProductoRastro.SetParameterValue(RptRelacionProductoRastro.Parameter_Empresa.ParameterFieldName, Me.Sesion.MiEmpresa.Empnom)
        RptRelacionProductoRastro.SetParameterValue(RptRelacionProductoRastro.Parameter_Modulo.ParameterFieldName, "Catalogos/Produccion/Relacion Productos Rastros")
        RptRelacionProductoRastro.SetParameterValue(RptRelacionProductoRastro.Parameter_Usuario.ParameterFieldName, Me.Sesion.MiUsuario.Usrnomcom)
        Return RptRelacionProductoRastro
    End Function


    Public Sub ReporteReimplantes(ByVal FechaInicio As Date, ByVal FechaFinal As Date)
        Dim Previsualizar As New PreVisualizarForm
        Previsualizar.Reporte = RptReimplantes(FechaInicio, FechaFinal)
        Previsualizar.ShowDialog()
    End Sub

    Private Function RptReimplantes(ByVal FechaInicio As Date, ByVal FechaFinal As Date) As RptReimplantes
        Dim Lotes As New LoteCollectionClass
        Dim Relacion As New OC.RelationCollection

        If FechaInicio.Ticks > FechaFinal.Ticks Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 10)
        End If

        RptReimplantes = New RptReimplantes()

        FechaInicio = FechaInicio.Date
        FechaFinal = New Date(FechaFinal.Year, FechaFinal.Month, FechaFinal.Day).AddDays(1).AddTicks(-1)

        Relacion.Add(EC.McecatLotesCabEntity.Relations.McecatCorralesCabEntityUsingIdCorral, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)
        Lotes.Obtener(HC.McecatLotesCabFields.Estatus = LoteClass.EstatusLote.VIGENTE And HC.McecatCorralesCabFields.Estatus = 1, New OC.SortExpression(New OC.SortClause(HC.McecatLotesCabFields.NombreLote, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)), Relacion)

        For i As Integer = Lotes.Count - 1 To 0 Step -1
            If Not Lotes(i).FechaReimplante.Year = 1900 AndAlso (Lotes(i).FechaReimplante.Ticks < FechaInicio.Ticks OrElse Lotes(i).FechaReimplante.Ticks > FechaFinal.Ticks) Then
                Lotes.RemoveAt(i)
            End If
        Next

        If Not Lotes.Count > 0 Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 9)
        End If

        RptReimplantes.SetDataSource(Lotes)
        RptReimplantes.SetParameterValue(RptReimplantes.Parameter_Empresa.ParameterFieldName, Me.Sesion.MiEmpresa.Empnom)
        RptReimplantes.SetParameterValue(RptReimplantes.Parameter_Modulo.ParameterFieldName, "Engorda/Reportes/Re-Implantes")
        RptReimplantes.SetParameterValue(RptReimplantes.Parameter_Usuario.ParameterFieldName, Me.Sesion.MiUsuario.Usrnomcom)
        Return RptReimplantes
    End Function

    Public Sub ReporteLotesCerrados(ByVal MesAno As Date)
        Dim Previsualizar As New PreVisualizarForm
        Previsualizar.Reporte = RptLotesCerrados(MesAno)
        Previsualizar.ShowDialog()
    End Sub

    Private Function RptLotesCerrados(ByVal MesAno As Date) As RptLotesCerrados
        Dim Lotes As New LoteCollectionClass

        RptLotesCerrados = New RptLotesCerrados()

        MesAno = New Date(MesAno.Year, MesAno.Month, 1)
        Lotes.Obtener(New OC.FieldBetweenPredicate(HC.McecatLotesCabFields.FechaCierre, MesAno, MesAno.AddMonths(1).AddTicks(-1)))

        If Not Lotes.Count > 0 Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 9)
        End If

        RptLotesCerrados.SetDataSource(Lotes)
        RptLotesCerrados.SetParameterValue(RptLotesCerrados.Parameter_Empresa.ParameterFieldName, Me.Sesion.MiEmpresa.Empnom)
        RptLotesCerrados.SetParameterValue(RptLotesCerrados.Parameter_Modulo.ParameterFieldName, "Engorda/Reportes/Lotes Cerrados")
        RptLotesCerrados.SetParameterValue(RptLotesCerrados.Parameter_Usuario.ParameterFieldName, Me.Sesion.MiUsuario.Usrnomcom)
        Return RptLotesCerrados
    End Function

    Public Sub ReporteExistenciasxTipoGanado(Optional ByVal TipoGanado As TipoGanadoClass = Nothing)
        Dim Previsualizar As New PreVisualizarForm
        Previsualizar.Reporte = RptExistenciasxTipoGanado(TipoGanado)
        Previsualizar.ShowDialog()
    End Sub

    Private Function RptExistenciasxTipoGanado(Optional ByVal TipoGanado As TipoGanadoClass = Nothing) As RptExistenciasxTipoGanado
        Dim dsExistxTipoGanado As New dsRptExistenciasxTipoGanado, dtExistxTipoGanado As dsRptExistenciasxTipoGanado.DataTable1DataTable = dsExistxTipoGanado.DataTable1
        Dim Aretes As New CC.McecatLotesDetCollection, Corrales As New CC.McecatCorralesDetCollection
        Dim FiltroAretes As New OC.PredicateExpression, FiltroCorrales As New OC.PredicateExpression, RelacionCorrales As New OC.RelationCollection
        Dim TiposGanado As New CC.McgcatTiposdeGanadoCollection

        RptExistenciasxTipoGanado = New RptExistenciasxTipoGanado()

        If TipoGanado Is Nothing Then
            TiposGanado = Me.ObtenerTiposGanado(CondicionEnum.ACTIVOS)
        Else
            TiposGanado.Add(TipoGanado.Entidad)
        End If

        For Each TipoGan As EC.McgcatTiposdeGanadoEntity In TiposGanado
            FiltroAretes.AddWithOr(HC.McecatLotesDetFields.IdTipoGanado = TipoGan.IdTipoGanado)
            FiltroCorrales.AddWithOr(HC.McecatCorralesDetFields.IdTipoGanado = TipoGan.IdTipoGanado)
        Next
        'Busca el ganado(Aretes) que esta en engorda(Lotes)
        Aretes.GetMulti(HC.McecatLotesDetFields.Estatus = LoteDetClass.EstatusLoteDetalle.VIGENTE And (FiltroAretes))

        'Busca el ganado que esta en reciba
        RelacionCorrales.Add(EC.McecatCorralesDetEntity.Relations.McecatCorralesCabEntityUsingIdCorral)
        Corrales.GetMulti(HC.McecatCorralesDetFields.ExistCabezas > 0 And (FiltroCorrales) And HC.McecatCorralesCabFields.Estatus = 1 _
            And HC.McecatCorralesCabFields.TipoCorral = 3, 0, Nothing, RelacionCorrales)

        For Each Arete As EC.McecatLotesDetEntity In Aretes
            Dim Busqueda() As DataRow = dtExistxTipoGanado.Select("IdTipoGanado =" & Arete.IdTipoGanado)
            Dim Fila As dsRptExistenciasxTipoGanado.DataTable1Row

            If Busqueda.Length > 0 Then
                Fila = CType(Busqueda(0), dsRptExistenciasxTipoGanado.DataTable1Row)
            Else
                Fila = dtExistxTipoGanado.NewDataTable1Row()
                Fila.IdTipoGanado = Arete.IdTipoGanado
                Fila.DescripcionTipoGanado = Arete.McgcatTiposdeGanado.Descripcion
                dtExistxTipoGanado.AddDataTable1Row(Fila)
            End If

            Select Case Arete.KilosEntrada
                Case Is < 150
                    Fila.Menos_150 += 1
                Case 150 To 199
                    Fila._150_199 += 1
                Case 200 To 249
                    Fila._200_249 += 1
                Case 250 To 299
                    Fila._250_299 += 1
                Case 300 To 399
                    Fila._300_399 += 1
                Case 400 To 499
                    Fila._400_499 += 1
                Case 500 To 599
                    Fila._500_599 += 1
                Case 600 To 799
                    Fila._600_799 += 1
                Case Else
                    Fila._799_Mas += 1
            End Select
            Fila.Total += 1
        Next

        For Each Ganado As EC.McecatCorralesDetEntity In Corrales
            Dim Busqueda() As DataRow = dtExistxTipoGanado.Select("IdTipoGanado =" & Ganado.IdTipoGanado)
            Dim Fila As dsRptExistenciasxTipoGanado.DataTable1Row
            Dim KilosPromedio As Decimal = Ganado.ExistKilos / Ganado.ExistCabezas

            If Busqueda.Length > 0 Then
                Fila = CType(Busqueda(0), dsRptExistenciasxTipoGanado.DataTable1Row)
            Else
                Fila = dtExistxTipoGanado.NewDataTable1Row()
                Fila.IdTipoGanado = Ganado.IdTipoGanado
                Fila.DescripcionTipoGanado = Ganado.McgcatTiposdeGanado.Descripcion
                dtExistxTipoGanado.AddDataTable1Row(Fila)
            End If

            Select Case KilosPromedio
                Case Is < 150
                    Fila.Menos_150 += Ganado.ExistCabezas
                Case 150 To 199
                    Fila._150_199 += Ganado.ExistCabezas
                Case 200 To 249
                    Fila._200_249 += Ganado.ExistCabezas
                Case 250 To 299
                    Fila._250_299 += Ganado.ExistCabezas
                Case 300 To 399
                    Fila._300_399 += Ganado.ExistCabezas
                Case 400 To 499
                    Fila._400_499 += Ganado.ExistCabezas
                Case 500 To 599
                    Fila._500_599 += Ganado.ExistCabezas
                Case 600 To 799
                    Fila._600_799 += Ganado.ExistCabezas
                Case Else
                    Fila._799_Mas += Ganado.ExistCabezas
            End Select
            Fila.Total += Ganado.ExistCabezas
        Next

        If Not dtExistxTipoGanado.Rows.Count > 0 Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 9)
        End If

        RptExistenciasxTipoGanado.SetDataSource(dsExistxTipoGanado)
        RptExistenciasxTipoGanado.SetParameterValue(RptExistenciasxTipoGanado.Parameter_Empresa.ParameterFieldName, Me.Sesion.MiEmpresa.Empnom)
        RptExistenciasxTipoGanado.SetParameterValue(RptExistenciasxTipoGanado.Parameter_Modulo.ParameterFieldName, "Engorda/Reportes/Existencias por Tipo de Ganado")
        RptExistenciasxTipoGanado.SetParameterValue(RptExistenciasxTipoGanado.Parameter_Usuario.ParameterFieldName, Me.Sesion.MiUsuario.Usrnomcom)
        Return RptExistenciasxTipoGanado
    End Function

    Public Sub ReporteSalidasProgramadasxSemanas(ByVal FechaInicial As Date, ByVal FechaFinal As Date)
        Dim Previsualizar As New PreVisualizarForm
        Previsualizar.Reporte = RptSalidasProgramadasxSemanas(FechaInicial, FechaFinal)
        Previsualizar.ShowDialog()
    End Sub

    Private Function RptSalidasProgramadasxSemanas(ByVal FechaInicial As Date, ByVal FechaFinal As Date) As RptSalidasProgramadasxSemanas
        Dim dsSalidasProgramadasxSem As New dsRptDiarioDeCorrales, dtSalidasProgramadasxSem As dsRptDiarioDeCorrales.DataTable1DataTable = dsSalidasProgramadasxSem.DataTable1
        Dim Corrales As New CorralColecttionClass, Semanas As Integer = Decimal.Ceiling((FechaFinal.Ticks - FechaInicial.Ticks) / TimeSpan.TicksPerDay) / 7
        Dim EtiquetasSemanales As New Collection, dtSalProgxOrdenar As New dsRptDiarioDeCorrales.DataTable1DataTable

        RptSalidasProgramadasxSemanas = New RptSalidasProgramadasxSemanas()

        For i As Integer = 0 To Semanas - 1
            Dim FechaIni As Date = FechaInicial, FechaFin As Date = FechaFinal
            Dim Etiqueta(1) As Object

            If i = Semanas - 1 Then
                If i > 0 Then
                    FechaIni = FechaInicial.AddDays(7 * i)
                End If
            ElseIf i = 0 Then
                FechaFin = FechaInicial.AddDays(7).AddTicks(-1)
            Else
                FechaIni = FechaInicial.AddDays(7 * i)
                FechaFin = FechaInicial.AddDays(7 * (i + 1)).AddTicks(-1)
            End If
            Etiqueta(0) = New RangoFechas(FechaIni, FechaFin)
            Etiqueta(1) = "Semana del día: " & CType(Etiqueta(0), RangoFechas).FechaInicial.Value.ToString("dd/MM/yyyy") & " Al: " & CType(Etiqueta(0), RangoFechas).FechaFinal.Value.ToString("dd/MM/yyyy")
            EtiquetasSemanales.Add(Etiqueta)
        Next

        For Each Corral As EC.McecatCorralesCabEntity In Me.ObtenerCorrales(CondicionEnum.ACTIVOS, TipoCorral.ENGORDA, EstatusAutorizada.TODAS, EstatusAutorizada.SI)
            Corrales.Add(New CorralClass(Corral))
        Next

        For i As Integer = Corrales.Count - 1 To 0 Step -1
            If Corrales(i).LoteActivo.FechaEstimadaDeSalida.Year = 1900 _
            OrElse Corrales(i).LoteActivo.FechaEstimadaDeSalida.Ticks < FechaInicial.Ticks _
            OrElse Corrales(i).LoteActivo.FechaEstimadaDeSalida.Ticks > FechaFinal.Ticks Then
                Corrales.RemoveAt(i)
            Else
                With Corrales(i)
                    Dim DiasxTranscurrir As Integer = .LoteActivo.DiasEngordaProyectado - .LoteActivo.DiasEngorda
                    Dim DescripcionFormula As String = String.Empty, EtiquetaSemanal As String = String.Empty

                    If .LoteActivo.FormulaActual IsNot Nothing Then
                        DescripcionFormula = .LoteActivo.FormulaActual.Formula.Descripcion
                    End If

                    For Each Etiqueta As Object In EtiquetasSemanales
                        Dim RangoDeFechas As RangoFechas = CType(Etiqueta(0), RangoFechas)

                        If .LoteActivo.FechaEstimadaDeSalida.Ticks >= RangoDeFechas.FechaInicial.Value.Ticks _
                         AndAlso .LoteActivo.FechaEstimadaDeSalida.Ticks <= RangoDeFechas.FechaFinal.Value.Ticks Then
                            EtiquetaSemanal = Etiqueta(1).ToString
                            Exit For
                        End If
                    Next
                    dtSalProgxOrdenar.AddDataTable1Row(.IdCorral, .Descripcion, .LoteActivo.IdLote, .LoteActivo.Descripcion, .LoteActivo.FechaInicio, .LoteActivo.DiasEngordaProyectado, .LoteActivo.FechaEstimadaDeSalida, .LoteActivo.DiasEngorda, DiasxTranscurrir, .LoteActivo.SaldoCabezas, .LoteActivo.PesoPromedioxCabeza, DescripcionFormula, .LoteActivo.DiasAplFormulaActual, EtiquetaSemanal)
                End With
            End If
        Next

        Dim Filas() As DataRow = dtSalProgxOrdenar.Select("", "FecEstSalida")

        For i As Integer = 0 To Filas.Length - 1
            dtSalidasProgramadasxSem.ImportRow(Filas(i))
        Next
        dtSalProgxOrdenar.Dispose()

        If Not dtSalidasProgramadasxSem.Rows.Count > 0 Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 9)
        End If

        RptSalidasProgramadasxSemanas.SetDataSource(dsSalidasProgramadasxSem)
        RptSalidasProgramadasxSemanas.SetParameterValue(RptSalidasProgramadasxSemanas.Parameter_Empresa.ParameterFieldName, Me.Sesion.MiEmpresa.Empnom)
        RptSalidasProgramadasxSemanas.SetParameterValue(RptSalidasProgramadasxSemanas.Parameter_Modulo.ParameterFieldName, "Engorda/Reportes/Salidas Programadas por Semana")
        RptSalidasProgramadasxSemanas.SetParameterValue(RptSalidasProgramadasxSemanas.Parameter_Usuario.ParameterFieldName, Me.Sesion.MiUsuario.Usrnomcom)
        Return RptSalidasProgramadasxSemanas
    End Function

    Public Sub ReporteSalidasProgramadas(Optional ByRef Corral As CorralClass = Nothing)
        Dim Previsualizar As New PreVisualizarForm
        Previsualizar.Reporte = RptSalidasProgramadas(Corral)
        Previsualizar.ShowDialog()
    End Sub

    Private Function RptSalidasProgramadas(Optional ByRef Corral As CorralClass = Nothing) As RptSalidasProgramadas
        Dim dsSalidasProgramadas As New dsRptDiarioDeCorrales, dtSalidasProgramadas As dsRptDiarioDeCorrales.DataTable1DataTable = dsSalidasProgramadas.DataTable1
        Dim Corrales As New CorralColecttionClass

        RptSalidasProgramadas = New RptSalidasProgramadas()

        If Corral Is Nothing Then
            For Each Cor As EC.McecatCorralesCabEntity In Me.ObtenerCorrales(CondicionEnum.ACTIVOS, TipoCorral.ENGORDA, EstatusAutorizada.TODAS, EstatusAutorizada.SI)
                Corrales.Add(New CorralClass(Cor))
            Next
        Else
            Corrales.Add(Corral)
        End If

        For Each Cor As CorralClass In Corrales
            With Cor
                Dim DiasxTranscurrir As Integer = .LoteActivo.DiasEngordaProyectado - .LoteActivo.DiasEngorda
                Dim DescripcionFormula As String = String.Empty

                If .LoteActivo.FormulaActual IsNot Nothing Then
                    DescripcionFormula = .LoteActivo.FormulaActual.Formula.Descripcion
                End If
                dtSalidasProgramadas.AddDataTable1Row(.IdCorral, .Descripcion, .LoteActivo.IdLote, .LoteActivo.Descripcion, .LoteActivo.FechaInicio, .LoteActivo.DiasEngordaProyectado, .LoteActivo.FechaEstimadaDeSalida, .LoteActivo.DiasEngorda, DiasxTranscurrir, .LoteActivo.SaldoCabezas, .LoteActivo.PesoPromedioxCabeza, DescripcionFormula, .LoteActivo.DiasAplFormulaActual, String.Empty)
            End With
        Next

        If Not dtSalidasProgramadas.Rows.Count > 0 Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 9)
        End If

        RptSalidasProgramadas.SetDataSource(dsSalidasProgramadas)
        RptSalidasProgramadas.SetParameterValue(RptSalidasProgramadas.Parameter_Empresa.ParameterFieldName, Me.Sesion.MiEmpresa.Empnom)
        RptSalidasProgramadas.SetParameterValue(RptSalidasProgramadas.Parameter_Modulo.ParameterFieldName, "Engorda/Reportes/Salidas Programadas")
        RptSalidasProgramadas.SetParameterValue(RptSalidasProgramadas.Parameter_Usuario.ParameterFieldName, Me.Sesion.MiUsuario.Usrnomcom)
        Return RptSalidasProgramadas
    End Function

    Public Sub ReporteDiarioDeCorrales(Optional ByRef Corral As CorralClass = Nothing)
        Dim Previsualizar As New PreVisualizarForm
        Previsualizar.Reporte = RptDiarioDeCorrales(Corral)
        Previsualizar.ShowDialog()
    End Sub

    Private Function RptDiarioDeCorrales(Optional ByRef Corral As CorralClass = Nothing) As RptDiarioDeCorrales
        Dim dsDiarioDeCorrales As New dsRptDiarioDeCorrales, dtDiariodeCorrales As dsRptDiarioDeCorrales.DataTable1DataTable = dsDiarioDeCorrales.DataTable1
        Dim Corrales As New CorralColecttionClass

        RptDiarioDeCorrales = New RptDiarioDeCorrales()

        If Corral Is Nothing Then
            For Each Cor As EC.McecatCorralesCabEntity In Me.ObtenerCorrales(CondicionEnum.ACTIVOS, TipoCorral.ENGORDA, EstatusAutorizada.TODAS, EstatusAutorizada.SI)
                Corrales.Add(New CorralClass(Cor))
            Next
        Else
            Corrales.Add(Corral)
        End If

        For Each Cor As CorralClass In Corrales
            With Cor
                Dim DiasxTranscurrir As Integer = .LoteActivo.DiasEngordaProyectado - .LoteActivo.DiasEngorda
                Dim DescripcionFormula As String = String.Empty

                If .LoteActivo.FormulaActual IsNot Nothing Then
                    DescripcionFormula = .LoteActivo.FormulaActual.Formula.Descripcion
                End If
                dtDiariodeCorrales.AddDataTable1Row(.IdCorral, .Descripcion, .LoteActivo.IdLote, .LoteActivo.Descripcion, .LoteActivo.FechaInicio, .LoteActivo.DiasEngordaProyectado, .LoteActivo.FechaEstimadaDeSalida, .LoteActivo.DiasEngorda, DiasxTranscurrir, .LoteActivo.SaldoCabezas, .LoteActivo.PesoPromedioxCabeza, DescripcionFormula, .LoteActivo.DiasAplFormulaActual, String.Empty)
            End With
        Next

        If Not dtDiariodeCorrales.Rows.Count > 0 Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 9)
        End If

        RptDiarioDeCorrales.SetDataSource(dsDiarioDeCorrales)
        RptDiarioDeCorrales.SetParameterValue(RptDiarioDeCorrales.Parameter_Empresa.ParameterFieldName, Me.Sesion.MiEmpresa.Empnom)
        RptDiarioDeCorrales.SetParameterValue(RptDiarioDeCorrales.Parameter_Modulo.ParameterFieldName, "Engorda/Reportes/Diario de Corrales")
        RptDiarioDeCorrales.SetParameterValue(RptDiarioDeCorrales.Parameter_Usuario.ParameterFieldName, Me.Sesion.MiUsuario.Usrnomcom)
        Return RptDiarioDeCorrales
    End Function

    Public Sub ReporteDetalladoDeLotes(Optional ByVal Lote As LoteClass = Nothing)
        Dim Previsualizar As New PreVisualizarForm
        Previsualizar.Reporte = RptDetalladoDeLotes(Lote)
        Previsualizar.ShowDialog()
    End Sub

    Private Function RptDetalladoDeLotes(Optional ByVal Lote As LoteClass = Nothing) As RptDetalladoDeLotes
        Dim dsDetalladoLotes As New dsRptDetalladoLotes, dtDetalladoLotes As dsRptDetalladoLotes.CabeceroDataTable = dsDetalladoLotes.Cabecero, dtDetDetalladoLotes As dsRptDetalladoLotes.DetalleDataTable = dsDetalladoLotes.Detalle
        Dim Lotes As LoteCollectionClass = Nothing

        RptDetalladoDeLotes = New RptDetalladoDeLotes()

        If Lote Is Nothing Then
            Lotes = Me.ObtenerLotes(LoteClass.EstatusLote.VIGENTE)
        Else
            Lotes = New LoteCollectionClass()
            Lotes.Add(Lote)
        End If

        For Each Lot As LoteClass In Lotes
            If Lot.Detalles_Vigentes.Count > 0 Then
                With Lot
                    Dim DescripcionFormula As String = String.Empty

                    If .FormulaActual IsNot Nothing Then
                        DescripcionFormula = .FormulaActual.Formula.Descripcion
                    End If
                    dtDetalladoLotes.AddCabeceroRow(.IdLote, .Descripcion, .DiasEngorda, DescripcionFormula, .DiasAplFormulaActual, .GDPINI, .PesoProyectadoxCbz, .FechaEstimadaDeSalida, .SalidasPorMuerteEnCabezas, .SaldoCabezas, .SaldoImpte, .SaldoImpteAlim, .SaldoimpteMed, .SaldoCostoInd)

                    For Each Arete As LoteDetClass In Lot.Detalles_Vigentes
                        Dim Busqueda() As DataRow = dtDetDetalladoLotes.Select("IdLote =" & .IdLote & " and " & "IdTipoGanado =" & Arete.IdTipoGanado)

                        If Busqueda IsNot Nothing AndAlso Busqueda.Length > 0 Then
                            Dim Fila As dsRptDetalladoLotes.DetalleRow = Busqueda(0)

                            Fila.Cabezas += 1
                            Fila.KgrsEntrada += Arete.KilosEntrada
                            Fila.KgrsProyectados += Arete.PesoEstimado
                            Fila.GananciaKgrs += Arete.PesoEstimado - Arete.KilosEntrada
                        Else
                            dtDetDetalladoLotes.AddDetalleRow(dtDetalladoLotes.Rows(dtDetalladoLotes.Count - 1), Arete.IdTipoGanado, Arete.TipoGanado.Descripcion, 1, Arete.KilosEntrada, Arete.PesoEstimado, Arete.PesoEstimado - Arete.KilosEntrada)
                        End If
                    Next
                End With
            End If
        Next

        If Not dtDetalladoLotes.Rows.Count > 0 Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 9)
        End If

        RptDetalladoDeLotes.SetDataSource(dsDetalladoLotes)
        RptDetalladoDeLotes.SetParameterValue(RptDetalladoDeLotes.Parameter_Empresa.ParameterFieldName, Me.Sesion.MiEmpresa.Empnom)
        RptDetalladoDeLotes.SetParameterValue(RptDetalladoDeLotes.Parameter_Modulo.ParameterFieldName, "Engorda/Reportes/Detallado de Lotes")
        RptDetalladoDeLotes.SetParameterValue(RptDetalladoDeLotes.Parameter_Usuario.ParameterFieldName, Me.Sesion.MiUsuario.Usrnomcom)
        Return RptDetalladoDeLotes
    End Function

    Public Sub ReportePagosCheDevueltos(ByRef PagosCheDevueltos As PagoCheDevueltoCabCollectionClass, ByVal Detallado As Boolean)
        If PagosCheDevueltos IsNot Nothing Then
            Dim Previsualizar As New PreVisualizarForm
            Previsualizar.Reporte = RptPagosCheDevueltos(PagosCheDevueltos, Detallado)
            Previsualizar.ShowDialog()
        End If
    End Sub

    Private Function RptPagosCheDevueltos(ByRef PagosCheDevueltos As PagoCheDevueltoCabCollectionClass, ByVal Detallado As Boolean) As RptPagosCheDevueltos
        Dim dsPagosCheDevueltos As New DataSet, dtPagosCheDevueltos As New dsRptPagosCheDevueltos.DataTable1DataTable
        Dim dsDetallesPagos As New DataSet, dtDetallesPagos As New dsRptDetallesCheDevueltos.DataTable1DataTable

        RptPagosCheDevueltos = New RptPagosCheDevueltos

        For Each Pago As PagoCheDevueltoCabClass In PagosCheDevueltos
            Dim FechaCancelacion As Object = #1/1/1900#

            With Pago
                If .FechaCancelacion.HasValue Then
                    FechaCancelacion = .FechaCancelacion
                End If

                dtPagosCheDevueltos.AddDataTable1Row(.Folio, .FechaPago, FechaCancelacion, .Saldo, .Importe, .Referencia, .Estatus.ToString)

                If Detallado Then
                    For Each PagoDetalle As PagoCheDevueltoDetClass In .Detalles
                        dtDetallesPagos.AddDataTable1Row(PagoDetalle.IdChequeDevuelto, .Folio, .FechaPago, String.Empty, PagoDetalle.Saldo, PagoDetalle.Importe, PagoDetalle.NoCheque, PagoDetalle.ChequeDevuelto.FechaDevolucion, PagoDetalle.ChequeDevuelto.NombreCliente, PagoDetalle.ChequeDevuelto.Banco.Descripcion, PagoDetalle.ChequeDevuelto.Importe)
                    Next
                End If
            End With
        Next

        dsPagosCheDevueltos.Tables.Add(dtPagosCheDevueltos)
        dsDetallesPagos.Tables.Add(dtDetallesPagos)
        RptPagosCheDevueltos.SetDataSource(dsPagosCheDevueltos)
        RptPagosCheDevueltos.Subreports(0).SetDataSource(dsDetallesPagos)
        RptPagosCheDevueltos.SetParameterValue(RptPagosCheDevueltos.Parameter_Empresa.ParameterFieldName, Me.Sesion.MiEmpresa.Empnom)
        RptPagosCheDevueltos.SetParameterValue(RptPagosCheDevueltos.Parameter_Modulo.ParameterFieldName, "CuentasxCobrar/Cheques Devueltos/Reportes/Pagos de Cheques Devueltos")
        RptPagosCheDevueltos.SetParameterValue(RptPagosCheDevueltos.Parameter_Usuario.ParameterFieldName, Me.Sesion.MiUsuario.Usrnomcom)
        Return RptPagosCheDevueltos
    End Function

    Public Sub ReporteChequesDevueltos(ByRef ChequesDevueltos As ChequeDevueltoCollectionClass, ByVal Detallado As Boolean)
        If ChequesDevueltos IsNot Nothing Then
            Dim Previsualizar As New PreVisualizarForm
            Previsualizar.Reporte = RptChequesDevueltos(ChequesDevueltos, Detallado)
            Previsualizar.ShowDialog()
        End If
    End Sub

    Private Function RptChequesDevueltos(ByRef ChequesDevueltos As ChequeDevueltoCollectionClass, ByVal Detallado As Boolean) As RptChequesDevueltos
        Dim dsChequesDevueltos As New DataSet, dtChequesDevueltos As New dsRptChequesDevueltos.DataTable1DataTable
        Dim dsDetallesPagos As New DataSet, dtDetallesPagos As New dsRptDetallesCheDevueltos.DataTable1DataTable

        RptChequesDevueltos = New RptChequesDevueltos()

        For Each ChequeDevuelto As ChequeDevueltoClass In ChequesDevueltos
            With ChequeDevuelto
                dtChequesDevueltos.AddDataTable1Row(.IdChequeDevuelto, .NoCheque, .DescripcionBanco, .DescripcionEstatus, .NombreCliente, .Recibio, .Observaciones, .Saldo, .Importe, .FechaDevolucion)

                If Detallado Then
                    For Each DetallePago As PagoCheDevueltoDetClass In ChequeDevuelto.Pagos_Vigentes
                        dtDetallesPagos.AddDataTable1Row(.IdChequeDevuelto, DetallePago.Folio, DetallePago.FechaPago, DetallePago.Observaciones, DetallePago.Saldo, DetallePago.Importe, .NoCheque, .FechaDevolucion, .Cliente.Nombre, .Banco.Descripcion, .Importe)
                    Next
                End If
            End With
        Next

        dsChequesDevueltos.Tables.Add(dtChequesDevueltos)
        dsDetallesPagos.Tables.Add(dtDetallesPagos)
        RptChequesDevueltos.SetDataSource(dsChequesDevueltos)
        RptChequesDevueltos.Subreports(0).SetDataSource(dsDetallesPagos)
        RptChequesDevueltos.SetParameterValue(RptChequesDevueltos.Parameter_Empresa.ParameterFieldName, Me.Sesion.MiEmpresa.Empnom)
        RptChequesDevueltos.SetParameterValue(RptChequesDevueltos.Parameter_Modulo.ParameterFieldName, "CuentasxCobrar/Cheques Devueltos/Reportes/Cheques Devueltos")
        RptChequesDevueltos.SetParameterValue(RptChequesDevueltos.Parameter_Usuario.ParameterFieldName, Me.Sesion.MiUsuario.Usrnomcom)
        Return RptChequesDevueltos
    End Function

    Public Sub ReporteExistenciasYCostosLotes(Optional ByVal Lote As LoteClass = Nothing)
        Dim Previsualizar As New PreVisualizarForm
        Previsualizar.Reporte = RptExistenciasYCostosLotes(Lote)
        Previsualizar.ShowDialog()
    End Sub

    Public Sub ReporteExistenciasYCostosRecepcion(Optional ByVal Corral As EC.McecatCorralesCabEntity = Nothing)
        Dim Previsualizar As New PreVisualizarForm
        Previsualizar.Reporte = RptExistenciasYCostosReciba(Corral)
        Previsualizar.ShowDialog()
    End Sub

    Private Function RptExistenciasYCostosLotes(Optional ByVal Lote As LoteClass = Nothing) As RptExistenciasYCostosLotes
        Dim ds As New DataSet, dt As New dsRptExistenciasYCostos.DataTable1DataTable
        Dim Lotes As LoteCollectionClass = Nothing

        RptExistenciasYCostosLotes = New RptExistenciasYCostosLotes

        If Lote Is Nothing Then
            Lotes = Me.ObtenerLotes(LoteClass.EstatusLote.VIGENTE)

            For Each Lot As LoteClass In Lotes
                Dim PromedioEntradasKgs As Decimal = 0D, CostoPromedioEntradas As Decimal = 0D

                If Lot.SaldoCabezas <> 0 Then
                    PromedioEntradasKgs = Lot.CalcularPesoActual / Lot.SaldoCabezas
                    CostoPromedioEntradas = Lot.SaldoImpte / Lot.SaldoCabezas
                End If
                dt.AddDataTable1Row(Lot.IdCorral, Lot.NombreCorral, Lot.Descripcion, Lot.DiasEngorda_Ficticio, Lot.SaldoCabezas, PromedioEntradasKgs, Lot.CalcularPesoActual, CostoPromedioEntradas, Lot.SaldoImpte, Lot.SaldoImpteAlim, Lot.SaldoimpteMed, Lot.SaldoCostoInd, Lot.SaldoImpte + Lot.SaldoImpteAlim + Lot.SaldoimpteMed + Lot.SaldoCostoInd)
            Next
        Else
            Dim PromedioEntradasKgs As Decimal = 0D, CostoPromedioEntradas As Decimal = 0D

            If Lote.SaldoCabezas <> 0 Then
                PromedioEntradasKgs = Lote.CalcularPesoActual / Lote.SaldoCabezas
                CostoPromedioEntradas = Lote.SaldoImpte / Lote.SaldoCabezas
            End If
            dt.AddDataTable1Row(Lote.IdCorral, Lote.NombreCorral, Lote.Descripcion, Lote.DiasEngorda_Ficticio, Lote.SaldoCabezas, PromedioEntradasKgs, Lote.CalcularPesoActual, CostoPromedioEntradas, Lote.SaldoImpte, Lote.SaldoImpteAlim, Lote.SaldoimpteMed, Lote.SaldoCostoInd, Lote.SaldoImpte + Lote.SaldoImpteAlim + Lote.SaldoimpteMed + Lote.SaldoCostoInd)
        End If
        ds.Tables.Add(dt)
        RptExistenciasYCostosLotes.SetDataSource(ds)
        RptExistenciasYCostosLotes.SetParameterValue(RptExistenciasYCostosLotes.Parameter_Empresa.ParameterFieldName, Me.Sesion.MiEmpresa.Empnom)
        RptExistenciasYCostosLotes.SetParameterValue(RptExistenciasYCostosLotes.Parameter_Modulo.ParameterFieldName, "Engorda/Reportes/Existencias y Costos/Corrales de Engorda")
        RptExistenciasYCostosLotes.SetParameterValue(RptExistenciasYCostosLotes.Parameter_Usuario.ParameterFieldName, Me.Sesion.MiUsuario.Usrnomcom)
        Return RptExistenciasYCostosLotes
    End Function

    Private Function RptExistenciasYCostosReciba(Optional ByVal Corral As EC.McecatCorralesCabEntity = Nothing) As RptExistenciasYCostosReciba
        Dim ds As New DataSet, dt As New dsRptExistenciasYCostos.DataTable1DataTable
        Dim Corrales As CC.McecatCorralesCabCollection = Nothing

        RptExistenciasYCostosReciba = New RptExistenciasYCostosReciba

        If Corral Is Nothing Then
            Corrales = Me.ObtenerCorrales(CondicionEnum.ACTIVOS, TipoCorral.RECIBA)

            For Each Cor As EC.McecatCorralesCabEntity In Corrales
                Dim PromedioEntradasKgs As Decimal = 0D, CostoPromedioEntradas As Decimal = 0D, TotalEntradaKgs As Decimal = 0D, Cabezas As Integer = 0
                Dim CostoEntradas As Decimal = 0D, CostoAlimentos As Decimal = 0D, CostoMedicamentos As Decimal = 0D, CostoIndirectos As Decimal = 0D

                For Each DetalleCorral As EC.McecatCorralesDetEntity In Cor.McecatCorralesDet
                    Cabezas += DetalleCorral.ExistCabezas
                    TotalEntradaKgs += DetalleCorral.ExistKilos
                    CostoEntradas += DetalleCorral.CostoEnt
                    CostoAlimentos += DetalleCorral.ImpteAlimento
                    CostoMedicamentos += DetalleCorral.ImpteMedicamento
                    CostoIndirectos += DetalleCorral.SaldoCostoInd
                Next

                If Cabezas <> 0 Then
                    PromedioEntradasKgs = TotalEntradaKgs / Cabezas
                    CostoPromedioEntradas = CostoEntradas / Cabezas
                End If
                dt.AddDataTable1Row(Cor.IdCorral, Cor.NombreCorral, "", 0, Cabezas, PromedioEntradasKgs, TotalEntradaKgs, CostoPromedioEntradas, CostoEntradas, CostoAlimentos, CostoMedicamentos, CostoIndirectos, CostoEntradas + CostoAlimentos + CostoMedicamentos + CostoIndirectos)
            Next
        Else
            Dim PromedioEntradasKgs As Decimal = 0D, CostoPromedioEntradas As Decimal = 0D, TotalEntradaKgs As Decimal = 0D, Cabezas As Integer = 0
            Dim CostoEntradas As Decimal = 0D, CostoAlimentos As Decimal = 0D, CostoMedicamentos As Decimal = 0D, CostoIndirectos As Decimal = 0D

            For Each DetalleCorral As EC.McecatCorralesDetEntity In Corral.McecatCorralesDet
                Cabezas += DetalleCorral.ExistCabezas
                TotalEntradaKgs += DetalleCorral.ExistKilos
                CostoEntradas += DetalleCorral.CostoEnt
                CostoAlimentos += DetalleCorral.ImpteAlimento
                CostoMedicamentos += DetalleCorral.ImpteMedicamento
                CostoIndirectos += DetalleCorral.SaldoCostoInd
            Next

            If Cabezas <> 0 Then
                PromedioEntradasKgs = TotalEntradaKgs / Cabezas
                CostoPromedioEntradas = CostoEntradas / Cabezas
            End If
            dt.AddDataTable1Row(Corral.IdCorral, Corral.NombreCorral, "", 0, Cabezas, PromedioEntradasKgs, TotalEntradaKgs, CostoPromedioEntradas, CostoEntradas, CostoAlimentos, CostoMedicamentos, CostoIndirectos, CostoEntradas + CostoAlimentos + CostoMedicamentos + CostoIndirectos)
        End If
        ds.Tables.Add(dt)
        RptExistenciasYCostosReciba.SetDataSource(ds)
        RptExistenciasYCostosReciba.SetParameterValue(RptExistenciasYCostosReciba.Parameter_Empresa.ParameterFieldName, Me.Sesion.MiEmpresa.Empnom)
        RptExistenciasYCostosReciba.SetParameterValue(RptExistenciasYCostosReciba.Parameter_Modulo.ParameterFieldName, "Engorda/Reportes/Existencias y Costos/Corrales de Recepcion")
        RptExistenciasYCostosReciba.SetParameterValue(RptExistenciasYCostosReciba.Parameter_Usuario.ParameterFieldName, Me.Sesion.MiUsuario.Usrnomcom)
        Return RptExistenciasYCostosReciba
    End Function

    Public Sub ReporteCierreLotes(Optional ByRef Lotes As LoteCollectionClass = Nothing)
        Dim Previsualizar As New PreVisualizarForm
        Previsualizar.Reporte = RptCierreLotes(Lotes)
        Previsualizar.ShowDialog()
    End Sub

    Private Function RptCierreLotes(Optional ByRef Lotes As LoteCollectionClass = Nothing) As RptCierreLotes
        If Lotes Is Nothing Then
            Lotes = New LoteCollectionClass()
            Lotes.Obtener(HC.McecatLotesCabFields.Estatus <> LoteClass.EstatusLote.CANCELADO)
        End If

        RptCierreLotes = New RptCierreLotes()
        RptCierreLotes.SetDataSource(Lotes)
        RptCierreLotes.SetParameterValue(RptCierreLotes.Parameter_Empresa.ParameterFieldName, Me.Sesion.MiEmpresa.Empnom)
        RptCierreLotes.SetParameterValue(RptCierreLotes.Parameter_Modulo.ParameterFieldName, "Engorda/Cierre de Lotes")
        RptCierreLotes.SetParameterValue(RptCierreLotes.Parameter_Usuario.ParameterFieldName, Me.Sesion.MiUsuario.Usrnomcom)
        Return RptCierreLotes
    End Function

    Public Sub ReporteProrrateoCostosCierreRecibas(ByVal OrdenPorCorral As Boolean, Optional ByVal RangoDeFechas As RangoFechas = Nothing, Optional ByVal IdCorralRecepcion As Object = Nothing)
        Dim Previsualizar As New PreVisualizarForm
        Dim Reporte As New RptProCostosCierresReciba
        Dim ds As New DataSet
        Dim dt As New dsRptProCostosCierresReciba.ProrraRecDataTable
        Dim Filtro As New OC.PredicateExpression
        Dim Ordenamiento As New OC.SortExpression()
        Dim Relacion As New OC.RelationCollection()

        If RangoDeFechas IsNot Nothing Then
            If RangoDeFechas.FechaInicial.HasValue And RangoDeFechas.FechaFinal.HasValue Then
                Filtro.Add(New OC.FieldBetweenPredicate(HC.ProrraRecFields.Fecha, RangoDeFechas.FechaInicial.Value, RangoDeFechas.FechaFinal.Value.AddDays(1)))
            End If
        End If

        If IdCorralRecepcion IsNot Nothing Then
            Filtro.Add(HC.ProrraRecFields.IdCorralReciba = IdCorralRecepcion)
        End If

        If OrdenPorCorral Then
            Relacion.Add(EC.ProrraRecEntity.Relations.McecatCorralesCabEntityUsingIdCorralReciba, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)
            Ordenamiento.Add(New OC.SortClause(HC.McecatCorralesCabFields.NombreCorral, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
        Else
            Ordenamiento.Add(New OC.SortClause(HC.ProrraRecFields.Fecha, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
        End If
        dt.Merge(CC.ProrraRecCollection.GetMultiAsDataTable(Filtro, 0, Ordenamiento, Relacion))

        For Each ProrraRec As dsRptProCostosCierresReciba.ProrraRecRow In dt.Rows
            ProrraRec.Folio = "G" & ProrraRec.IdProrraRec.ToString.PadLeft(10, "0")
            ProrraRec.LoteDestino = CC.McecatLotesCabCollection.GetMultiAsDataTable(HC.McecatLotesCabFields.IdLote = ProrraRec.IdLote, 0, Nothing).Rows(0).Item("NombreLote")
            ProrraRec.CorralReciba = CC.McecatCorralesCabCollection.GetMultiAsDataTable(HC.McecatCorralesCabFields.IdCorral = ProrraRec.IdCorralReciba, 0, Nothing).Rows(0).Item("NombreCorral")
        Next
        ds.Tables.Add(dt)
        Reporte.SetDataSource(ds)
        Reporte.SetParameterValue(0, "Compras de Ganado/Reportes/Prorrateos de Costos por Cierre de Reciba")
        Reporte.SetParameterValue(1, Sesion.MiUsuario.Usrnomcom)
        Reporte.SetParameterValue(2, Sesion.MiEmpresa.Empnom)
        Previsualizar.Reporte = Reporte
        Previsualizar.ShowDialog()
    End Sub

    Public Sub ReporteSalidasDeReciba(ByVal IdCorralRecepcion As String, ByVal IdCausaMuerte As Nullable(Of Integer), Optional ByVal Tipo As ReporteSalidasReciba = ReporteSalidasReciba.Todos, Optional ByVal Orden As ReporteSalidasOrden = ReporteSalidasOrden.Fecha, Optional ByVal RangoDeFechas As RangoFechas = Nothing, Optional ByVal Estatus As EstatusChar = EstatusChar.TODOS)
        Dim CorralesRecibaRastro As New SalidaGanadoCabeceroCollectionClass
        Dim Previsualizar As New PreVisualizarForm, Reporte As Object = Nothing
        Dim ds As New DataSet, dt As New dsRptCorralRecibaRastros.CorralRecibaRastroDataTable
        Dim dtOrdenado As New dsRptCorralRecibaRastros.CorralRecibaRastroDataTable
        Dim Filtro As New OC.PredicateExpression
        Dim Rows() As DataRow = Nothing

        If Estatus <> EstatusChar.TODOS Then
            If Estatus = EstatusChar.VIGENTE Then
                Filtro.Add(HC.SalidaGanadoCabFields.Estatus = 1)
            Else
                Filtro.Add(HC.SalidaGanadoCabFields.Estatus = 0)
            End If
        End If

        If RangoDeFechas IsNot Nothing Then
            If RangoDeFechas.FechaInicial.HasValue And RangoDeFechas.FechaFinal.HasValue Then
                Filtro.Add(New OC.FieldBetweenPredicate(HC.SalidaGanadoCabFields.Fecha, RangoDeFechas.FechaInicial.Value, RangoDeFechas.FechaFinal.Value.AddDays(1)))
            End If
        End If

        If IdCorralRecepcion IsNot Nothing Then
            Filtro.Add(HC.SalidaGanadoCabFields.IdCorral = IdCorralRecepcion)
        End If

        If IdCausaMuerte.HasValue AndAlso IdCausaMuerte.Value > 0 Then
            Filtro.Add(HC.SalidaGanadoCabFields.IdCausaMuerte = IdCausaMuerte)
        End If

        Select Case Tipo
            Case ReporteSalidasReciba.Rastro
                Filtro.Add(HC.SalidaGanadoCabFields.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Reciba_a_Rastro)
                Reporte = New RptSalidasDeRecibaARastro
            Case ReporteSalidasReciba.Venta
                Filtro.Add(HC.SalidaGanadoCabFields.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Reciba_a_Venta)
                Reporte = New RptSalidasDeRecibaAVenta
            Case ReporteSalidasReciba.Muerte
                Filtro.Add(HC.SalidaGanadoCabFields.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Reciba_por_Muerte)
                Reporte = New RptSalidasDeRecibaPorMuerte
            Case Else
                Filtro.Add(HC.SalidaGanadoCabFields.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Reciba_a_Rastro _
                    Or HC.SalidaGanadoCabFields.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Reciba_a_Venta _
                    Or HC.SalidaGanadoCabFields.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Reciba_por_Muerte)
                Reporte = New RptSalidasDeReciba
        End Select

        For Each CorralCabecero As SalidaGanadoCabeceroClass In Me.ObtenerSalidasGanado(Filtro)
            With CorralCabecero
                For Each detalle As SalidaGanadoDetalleClass In .Detalles
                    Dim CorralDescripcion As String = "", RastroDescripcion As String = "", LoteDestinoDescripcion As String = ""
                    Dim CorralDestinoDescripcion As String = "", CausaMuerteDescripcion As String = "", Recuperacion As String = "NO"
                    Dim TipoSalida As String

                    If .Corral.Entidad IsNot Nothing AndAlso Not .Corral.Entidad.IsNew Then
                        CorralDescripcion = .Corral.Descripcion
                    End If

                    If .Rastro.Entidad IsNot Nothing AndAlso Not .Rastro.Entidad.IsNew Then
                        RastroDescripcion = .Rastro.Descripcion
                    End If

                    If .LoteDestino.Entidad IsNot Nothing AndAlso Not .LoteDestino.Entidad.IsNew Then
                        LoteDestinoDescripcion = .LoteDestino.Descripcion
                        CorralDestinoDescripcion = .LoteDestino.Corral.Descripcion
                    End If

                    If .Recuperacion.HasValue AndAlso .Recuperacion.Value Then
                        Recuperacion = "SI"
                    End If

                    If .CausaMuerte.ObtenerEntidad IsNot Nothing AndAlso Not .CausaMuerte.ObtenerEntidad.IsNew Then
                        CausaMuerteDescripcion = .CausaMuerte.Descripcion
                    End If

                    If Not detalle.PrecioxKilo.HasValue Then detalle.PrecioxKilo = 0D

                    Select Case .IdTipoReciba
                        Case SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Reciba_por_Muerte
                            TipoSalida = "SALIDAS DE RECIBA POR MUERTE"
                        Case SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Reciba_a_Venta
                            TipoSalida = "SALIDAS DE RECIBA POR A VENTA"
                        Case Else
                            TipoSalida = "SALIDAS DE RECIBA A RASTRO"
                    End Select
                    dt.AddCorralRecibaRastroRow(.Folio, detalle.TipoGanado.Descripcion, detalle.IdSalidaGanadoDet, detalle.Arete, detalle.AreteSiniiga, detalle.AreteTransporte, .Fecha, CorralDescripcion, RastroDescripcion, LoteDestinoDescripcion, CorralDestinoDescripcion, .Aviso, Recuperacion, CausaMuerteDescripcion, detalle.Cabezas, detalle.Kilos, detalle.PrecioxKilo, detalle.CostoxKilo, detalle.Importe, TipoSalida, "", detalle.ImporteVenta)
                Next
            End With
        Next

        Select Case Orden
            Case ReporteSalidasOrden.CorralRecepcion
                Rows = dt.Select("", "CorralRecepcion asc, Fecha asc")
            Case ReporteSalidasOrden.Fecha
                Rows = dt.Select("", "Fecha asc, CorralRecepcion asc")
            Case ReporteSalidasOrden.CausaMuerte
                Rows = dt.Select("", "CausaMuerteDescripcion asc, CorralRecepcion asc")
        End Select

        For Each Renglon As DataRow In Rows
            dtOrdenado.ImportRow(Renglon)
        Next
        dt.Clear()
        ds.Tables.Add(dtOrdenado)
        Reporte.SetDataSource(ds)
        Reporte.SetParameterValue(0, "Compras de Ganado/Reportes/" & "De Salidas de Corral de Recepcion")
        Reporte.SetParameterValue(1, Sesion.MiUsuario.Usrnomcom)
        Reporte.SetParameterValue(2, Sesion.MiEmpresa.Empnom)
        Previsualizar.Reporte = Reporte
        Previsualizar.ShowDialog()
    End Sub

    Public Sub ReporteSalidasDeEngorda(ByVal IdLote As Nullable(Of Integer), ByVal IdCausaMuerte As Nullable(Of Integer), Optional ByVal Tipo As ReporteSalidasEngorda = ReporteSalidasEngorda.Todos, Optional ByVal Orden As ReporteSalidasOrden = ReporteSalidasOrden.Fecha, Optional ByVal RangoDeFechas As RangoFechas = Nothing, Optional ByVal Estatus As EstatusChar = EstatusChar.TODOS)
        Dim CorralesRecibaRastro As New SalidaGanadoCabeceroCollectionClass
        Dim Previsualizar As New PreVisualizarForm, Reporte As Object = Nothing
        Dim ds As New DataSet, dt As New dsRptCorralRecibaRastros.CorralRecibaRastroDataTable
        Dim dtOrdenado As New dsRptCorralRecibaRastros.CorralRecibaRastroDataTable
        Dim Filtro As New OC.PredicateExpression, Relacion As New OC.RelationCollection
        Dim Rows() As DataRow = Nothing

        If Estatus <> EstatusChar.TODOS Then
            If Estatus = EstatusChar.VIGENTE Then
                Filtro.Add(HC.SalidaGanadoCabFields.Estatus = 1)
            Else
                Filtro.Add(HC.SalidaGanadoCabFields.Estatus = 0)
            End If
        End If

        If RangoDeFechas IsNot Nothing Then
            If RangoDeFechas.FechaInicial.HasValue And RangoDeFechas.FechaFinal.HasValue Then
                Filtro.Add(New OC.FieldBetweenPredicate(HC.SalidaGanadoCabFields.Fecha, RangoDeFechas.FechaInicial.Value, RangoDeFechas.FechaFinal.Value.AddDays(1)))
            End If
        End If

        If IdLote.HasValue AndAlso IdLote.Value > 0 Then
            Relacion.Add(EC.SalidaGanadoCabEntity.Relations.SalidaGanadoDetEntityUsingIdSalidaGanadoCab, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)
            Filtro.Add(HC.SalidaGanadoDetFields.IdLote = IdLote)
        End If

        If IdCausaMuerte.HasValue AndAlso IdCausaMuerte.Value > 0 Then
            Filtro.Add(HC.SalidaGanadoCabFields.IdCausaMuerte = IdCausaMuerte)
        End If

        Select Case Tipo
            Case ReporteSalidasEngorda.Rastro
                Filtro.Add(HC.SalidaGanadoCabFields.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_a_Rastro)
                Reporte = New RptSalidasDeEngordaARastro
            Case ReporteSalidasEngorda.Venta
                Filtro.Add(HC.SalidaGanadoCabFields.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_a_Venta)
                Reporte = New RptSalidasDeEngordaPorVenta
            Case ReporteSalidasEngorda.Muerte
                Filtro.Add(HC.SalidaGanadoCabFields.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_por_Muerte)
                Reporte = New RptSalidasDeEngordaPorMuerte
            Case ReporteSalidasEngorda.Transferencia
                Filtro.Add(HC.SalidaGanadoCabFields.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_por_Tranferencia)
                Reporte = New RptSalidasDeEngordaPorTransferencia
            Case Else
                Filtro.Add(HC.SalidaGanadoCabFields.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_a_Rastro _
                    Or HC.SalidaGanadoCabFields.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_a_Venta _
                    Or HC.SalidaGanadoCabFields.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_por_Muerte _
                    Or HC.SalidaGanadoCabFields.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_por_Tranferencia)
                Reporte = New RptSalidasDeEngorda
        End Select

        For Each CorralCabecero As SalidaGanadoCabeceroClass In Me.ObtenerSalidasGanado(Filtro, Relacion)
            With CorralCabecero
                For Each detalle As SalidaGanadoDetalleClass In .Detalles
                    Dim CorralDescripcion As String = "", RastroDescripcion As String = "", LoteDestinoDescripcion As String = ""
                    Dim CorralDestinoDescripcion As String = "", CausaMuerteDescripcion As String = "", Recuperacion As String = "NO"
                    Dim TipoSalida As String, LoteOrigen As String = String.Empty

                    If .Corral.Entidad IsNot Nothing AndAlso Not .Corral.Entidad.IsNew Then
                        CorralDescripcion = .Corral.Descripcion
                    End If

                    If .Rastro.Entidad IsNot Nothing AndAlso Not .Rastro.Entidad.IsNew Then
                        RastroDescripcion = .Rastro.Descripcion
                    End If

                    If detalle.Lote.Entidad IsNot Nothing AndAlso Not detalle.Lote.Entidad.IsNew Then
                        LoteOrigen = detalle.Lote.Descripcion
                    End If

                    If Not .LoteDestino.Entidad.IsNew Then
                        LoteDestinoDescripcion = .LoteDestino.Descripcion
                        CorralDestinoDescripcion = .LoteDestino.Corral.Descripcion
                    End If

                    If .Recuperacion.HasValue AndAlso .Recuperacion.Value Then
                        Recuperacion = "SI"
                    End If

                    If .CausaMuerte.ObtenerEntidad IsNot Nothing AndAlso Not .CausaMuerte.ObtenerEntidad.IsNew Then
                        CausaMuerteDescripcion = .CausaMuerte.Descripcion
                    End If

                    If Not detalle.PrecioxKilo.HasValue Then detalle.PrecioxKilo = 0D

                    Select Case .IdTipoReciba
                        Case SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_a_Rastro
                            TipoSalida = "SALIDAS DE CORRAL A RASTRO"
                        Case SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_a_Venta
                            TipoSalida = "SALIDAS DE CORRAL A VENTA"
                        Case SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_por_Muerte
                            TipoSalida = "SALIDAS DE CORRAL POR MUERTE"
                        Case Else
                            TipoSalida = "SALIDAS DE CORRAL POR TRANSFERENCIA"
                    End Select
                    dt.AddCorralRecibaRastroRow(.Folio, detalle.TipoGanado.Descripcion, detalle.IdSalidaGanadoDet, detalle.Arete, detalle.AreteSiniiga, detalle.AreteTransporte, .Fecha, CorralDescripcion, RastroDescripcion, LoteDestinoDescripcion, CorralDestinoDescripcion, .Aviso, Recuperacion, CausaMuerteDescripcion, detalle.Cabezas, detalle.Kilos, detalle.PrecioxKilo, detalle.CostoxKilo, detalle.Importe, TipoSalida, LoteOrigen, detalle.ImporteVenta)
                Next
            End With
        Next

        Select Case Orden
            Case ReporteSalidasOrden.CorralRecepcion
                Rows = dt.Select("", "CorralRecepcion asc, Fecha asc")
            Case ReporteSalidasOrden.Fecha
                Rows = dt.Select("", "Fecha asc, CorralRecepcion asc")
            Case ReporteSalidasOrden.CausaMuerte
                Rows = dt.Select("", "CausaMuerteDescripcion asc, CorralRecepcion asc")
        End Select

        For Each Renglon As DataRow In Rows
            dtOrdenado.ImportRow(Renglon)
        Next
        dt.Clear()
        ds.Tables.Add(dtOrdenado)
        Reporte.SetDataSource(ds)
        Reporte.SetParameterValue(0, "Engorda/Reportes/Salidas de Corrales")
        Reporte.SetParameterValue(1, Sesion.MiUsuario.Usrnomcom)
        Reporte.SetParameterValue(2, Sesion.MiEmpresa.Empnom)
        Previsualizar.Reporte = Reporte
        Previsualizar.ShowDialog()
    End Sub

    Public Sub ReporteTransferenciasRecibaLotesTotalizado(ByVal Estatus As EstatusChar, ByVal OrdenPorLote As Boolean, Optional ByVal IdLote As Object = Nothing, Optional ByVal RangoDeFechas As RangoFechas = Nothing)
        Dim Previsualizar As New PreVisualizarForm
        Dim Reporte As New RptTransferenciasRecibaLotesTotal
        Dim ds As New DataSet
        Dim dt As New DsRptTranferenciasRecibaLotesEngorda.TranferenciasRecepcionLotesEngordaDataTable
        Dim dtTranferencias As New DsRptTranferenciasRecibaLotesEngorda.TranferenciasRecepcionLotesEngordaDataTable
        Dim Filtro As New OC.PredicateExpression(HC.SalidaGanadoCabFields.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Transferencia_de_Reciba_a_Corral)
        Dim Rows() As DataRow = Nothing

        If Estatus <> EstatusChar.TODOS Then
            If Estatus = EstatusChar.VIGENTE Then
                Filtro.Add(HC.SalidaGanadoCabFields.Estatus = 1)
            Else
                Filtro.Add(HC.SalidaGanadoCabFields.Estatus = 0)
            End If
        End If

        If RangoDeFechas IsNot Nothing Then
            If RangoDeFechas.FechaInicial.HasValue And RangoDeFechas.FechaFinal.HasValue Then
                Filtro.Add(New OC.FieldBetweenPredicate(HC.SalidaGanadoCabFields.Fecha, RangoDeFechas.FechaInicial.Value, RangoDeFechas.FechaFinal.Value.AddDays(1)))
            End If
        End If

        If IsNumeric(IdLote) Then
            Filtro.Add(HC.SalidaGanadoCabFields.IdLoteDestino = IdLote)
        End If

        For Each CorralReciba As SalidaGanadoCabeceroClass In Me.ObtenerSalidasGanado(Filtro)
            For Each Detalle As SalidaGanadoDetalleClass In CorralReciba.Detalles
                dt.AddTranferenciasRecepcionLotesEngordaRow(CorralReciba.Corral.Descripcion, CorralReciba.Folio, CorralReciba.LoteDestino.Descripcion, CorralReciba.LoteDestino.Corral.Descripcion, CorralReciba.Fecha, Detalle.Kilos, Detalle.Cabezas, Detalle.TipoGanado.Descripcion, Detalle.CostoxKilo, Detalle.Kilos / Detalle.Cabezas, Detalle.Kilos / Detalle.Cabezas * Detalle.CostoxKilo, Detalle.CostoxKilo * Detalle.Kilos, Detalle.Arete)
            Next
        Next

        If OrdenPorLote Then
            Rows = dt.Select("", "LoteDestino asc, Fecha asc")
        Else
            Rows = dt.Select("", "Fecha asc, LoteDestino asc")
        End If

        For Each Renglon As DataRow In Rows
            dtTranferencias.ImportRow(Renglon)
        Next
        dt.Clear()
        ds.Tables.Add(dtTranferencias)
        Reporte.SetDataSource(ds)
        Reporte.SetParameterValue(0, "Compras de Ganado/Reportes/De Transferencias de Recepcion Totalizado Por lotes")
        Reporte.SetParameterValue(1, Sesion.MiUsuario.Usrnomcom)
        Reporte.SetParameterValue(2, Sesion.MiEmpresa.Empnom)
        Previsualizar.Reporte = Reporte
        Previsualizar.ShowDialog()
    End Sub

    Public Sub ReporteTransferenciasRecibaLotesEngorda(ByVal Concentrado As Boolean, ByVal Estatus As EstatusChar, ByVal OrdenPorCorral As Boolean, Optional ByVal IdCorral As Object = Nothing, Optional ByVal RangoDeFechas As RangoFechas = Nothing)
        Dim Previsualizar As New PreVisualizarForm
        Dim Reporte As Object
        Dim ds As New DataSet
        Dim dt As New DsRptTranferenciasRecibaLotesEngorda.TranferenciasRecepcionLotesEngordaDataTable
        Dim dtTranferencias As New DsRptTranferenciasRecibaLotesEngorda.TranferenciasRecepcionLotesEngordaDataTable
        Dim Filtro As New OC.PredicateExpression(HC.SalidaGanadoCabFields.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Transferencia_de_Reciba_a_Corral)
        Dim Rows() As DataRow = Nothing

        If Estatus <> EstatusChar.TODOS Then
            If Estatus = EstatusChar.VIGENTE Then
                Filtro.Add(HC.SalidaGanadoCabFields.Estatus = 1)
            Else
                Filtro.Add(HC.SalidaGanadoCabFields.Estatus = 0)
            End If
        End If

        If RangoDeFechas IsNot Nothing Then
            If RangoDeFechas.FechaInicial.HasValue And RangoDeFechas.FechaFinal.HasValue Then
                Filtro.Add(New OC.FieldBetweenPredicate(HC.SalidaGanadoCabFields.Fecha, RangoDeFechas.FechaInicial.Value, RangoDeFechas.FechaFinal.Value.AddDays(1)))
            End If
        End If

        If IdCorral IsNot Nothing Then
            Filtro.Add(HC.SalidaGanadoCabFields.IdCorral = IdCorral)
        End If

        For Each CorralReciba As SalidaGanadoCabeceroClass In Me.ObtenerSalidasGanado(Filtro)
            For Each Detalle As SalidaGanadoDetalleClass In CorralReciba.Detalles
                dt.AddTranferenciasRecepcionLotesEngordaRow(CorralReciba.Corral.Descripcion, CorralReciba.Folio, CorralReciba.LoteDestino.Descripcion, CorralReciba.LoteDestino.Corral.Descripcion, CorralReciba.Fecha, Detalle.Kilos, Detalle.Cabezas, Detalle.TipoGanado.Descripcion, Detalle.CostoxKilo, Detalle.Kilos / Detalle.Cabezas, Detalle.Kilos / Detalle.Cabezas * Detalle.CostoxKilo, Detalle.CostoxKilo * Detalle.Kilos, Detalle.Arete)
            Next
        Next

        If OrdenPorCorral Then
            Rows = dt.Select("", "CorralRecepcion asc, Fecha asc")
        Else
            Rows = dt.Select("", "Fecha asc, CorralRecepcion asc")
        End If

        For Each Renglon As DataRow In Rows
            dtTranferencias.ImportRow(Renglon)
        Next
        dt.Clear()

        If Concentrado Then
            Reporte = New RptTransferenciasRecibaLotesEngordaConcentrado
        Else
            Reporte = New RptTransferenciasRecibaLotesEngorda
        End If

        ds.Tables.Add(dtTranferencias)
        Reporte.SetDataSource(ds)
        Reporte.SetParameterValue(0, "Compras de Ganado/Reportes/De Transferencias de Recepcion a Lotes de Engorda")
        Reporte.SetParameterValue(1, Sesion.MiUsuario.Usrnomcom)
        Reporte.SetParameterValue(2, Sesion.MiEmpresa.Empnom)
        Previsualizar.Reporte = Reporte
        Previsualizar.ShowDialog()
    End Sub

    Public Sub ReporteMermas(ByVal Estatus As EstatusChar, ByVal Agrupacion As ReporteMermasAgrupacion, Optional ByVal IdProveedor As Object = Nothing, Optional ByVal IdComprador As Object = Nothing, Optional ByVal IdLugarCompra As Object = Nothing, Optional ByVal IdChofer As Object = Nothing, Optional ByVal RangoDeFechas As RangoFechas = Nothing)
        Dim Previsualizar As New PreVisualizarForm
        Dim Reporte As New RptMermas
        Dim ds As New DataSet
        Dim dt As New dsRptMermas.dtComprasGanadoDataTable
        Dim TituloSecundario As String = ""
        Dim Filtro As New OC.PredicateExpression
        Dim Relaciones As New OC.RelationCollection

        Select Case Agrupacion
            Case ReporteMermasAgrupacion.Fecha
                TituloSecundario &= "FECHA "
            Case ReporteMermasAgrupacion.Proveedor
                TituloSecundario &= "PROVEEDOR "
            Case ReporteMermasAgrupacion.Chofer
                TituloSecundario &= "CHOFER "
            Case ReporteMermasAgrupacion.Comprador
                TituloSecundario &= "COMPRADOR "
            Case Else
                TituloSecundario &= "LUGAR DE COMPRA "
        End Select

        If RangoDeFechas IsNot Nothing Then
            If RangoDeFechas.FechaInicial.HasValue And RangoDeFechas.FechaFinal.HasValue Then
                Filtro.Add(New OC.FieldBetweenPredicate(HC.CabRegComFields.FecRecep, RangoDeFechas.FechaInicial.Value, RangoDeFechas.FechaFinal.Value.AddDays(1)))

                TituloSecundario &= "DEL " & RangoDeFechas.FechaInicial.Value.Day.ToString.PadLeft(2, "0") & "/" & Me.Culture.DateTimeFormat.GetAbbreviatedMonthName(RangoDeFechas.FechaInicial.Value.Month) & "/" & RangoDeFechas.FechaInicial.Value.Year & _
                    " AL " & _
                    RangoDeFechas.FechaFinal.Value.Day.ToString.PadLeft(2, "0") & "/" & Me.Culture.DateTimeFormat.GetAbbreviatedMonthName(RangoDeFechas.FechaFinal.Value.Month) & "/" & RangoDeFechas.FechaFinal.Value.Year
            End If
        End If

        If IsNumeric(IdProveedor) Then
            Filtro.Add(HC.CabRegComFields.CveProveGan = IdProveedor)
        End If

        If IsNumeric(IdComprador) Then
            Filtro.Add(HC.CabRegComFields.CveComiGan = IdComprador)
        End If

        If IsNumeric(IdLugarCompra) Then
            Filtro.Add(HC.CabRegComFields.CveLugCom = IdLugarCompra)
        End If

        If IsNumeric(IdChofer) Then
            Relaciones.Add(EC.CabRegComEntity.Relations.CabGasTransEntityUsingFolRecep)
            Filtro.Add(HC.CabGasTransFields.CveChofer = IdChofer)
        End If

        If Estatus <> EstatusChar.TODOS Then
            If Estatus = EstatusChar.VIGENTE Then
                Filtro.Add(HC.CabRegComFields.Status = "V")
            Else
                Filtro.Add(HC.CabRegComFields.Status = "C")
            End If
        End If

        For Each Renglon As DataRow In CC.CabRegComCollection.GetMultiAsDataTable(Filtro, 0, Nothing, Relaciones).Rows
            Dim Agrupador As String

            Select Case Agrupacion
                Case ReporteMermasAgrupacion.Fecha
                    Agrupador = CType(Renglon("FecRecep"), Date).ToShortDateString
                Case ReporteMermasAgrupacion.Proveedor
                    If CC.ProveedorCollection.GetMultiAsDataTable(HC.ProveedorFields.Codigo = Renglon("CveProveGan"), 0, Nothing).Rows.Count > 0 Then
                        Agrupador = CC.ProveedorCollection.GetMultiAsDataTable(HC.ProveedorFields.Codigo = Renglon("CveProveGan"), 0, Nothing).Rows(0).Item("Nombre")
                    Else
                        Agrupador = "Proveedor no encontrado"
                    End If
                Case ReporteMermasAgrupacion.Chofer
                    'Dim RelacionChofer As New OC.RelationCollection
                    'RelacionChofer.Add(EC.McgcatChoferesEntity.Relations.CabGasTransEntityUsingCveChofer)
                    Dim dtChoferes As DataTable = CC.McgcatChoferesCollection.GetMultiAsDataTable(HC.CabGasTransFields.FolRecep = Renglon("FolRecep"), 0, Nothing) ', RelacionChofer)

                    If dtChoferes.Rows.Count > 0 Then
                        Agrupador = dtChoferes.Rows(0).Item("ApPatChofer") & " " & dtChoferes.Rows(0).Item("ApMatChofer") & " " & dtChoferes.Rows(0).Item("NombreChofer")
                    Else
                        Agrupador = "Sin Gastos de Transportes"
                    End If
                Case ReporteMermasAgrupacion.Comprador
                    Dim dtComprador As DataTable = CC.McgcatCompradoresdeGanadoCollection.GetMultiAsDataTable(HC.McgcatCompradoresdeGanadoFields.IdComprador = Renglon("CveComiGan"), 0, Nothing)

                    If dtComprador.Rows.Count > 0 Then
                        Agrupador = dtComprador.Rows(0).Item("ApellidoPaterno") & " " & dtComprador.Rows(0).Item("ApellidoMaterno") & " " & dtComprador.Rows(0).Item("Nombre")
                    Else
                        Agrupador = "Comprador no encontrado"
                    End If
                Case Else
                    Agrupador = CC.CatLugaresDeCompraCollection.GetMultiAsDataTable(HC.CatLugaresDeCompraFields.IdLugarCompra = Renglon("CveLugCom"), 0, Nothing).Rows(0).Item("Descripcion")
            End Select
            dt.AdddtComprasGanadoRow(Renglon("FolRecep"), Renglon("FecRecep"), Agrupador, Renglon("CabezasComp"), Renglon("ImpteComp"), Renglon("KilosComp"), Renglon("PesoEntReal"), Renglon("KilosComp") - Renglon("PesoEntReal"), (Renglon("KilosComp") - Renglon("PesoEntReal")) / Renglon("KilosComp") * 100, (Renglon("KilosComp") - Renglon("PesoEntReal")) / Renglon("CabezasComp"), Renglon("ImpteComp") / Renglon("KilosComp"))
        Next

        If Not dt.Rows.Count > 0 Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 3)
        End If

        ds.Tables.Add(dt)
        Reporte.SetDataSource(ds)
        Reporte.SetParameterValue(0, "Compras de Ganado/Reportes/De Mermas")
        Reporte.SetParameterValue(1, Sesion.MiUsuario.Usrnomcom)
        Reporte.SetParameterValue(2, Sesion.MiEmpresa.Empnom)
        Reporte.SetParameterValue(3, "REPORTE DE MERMAS POR " & TituloSecundario)
        Previsualizar.Reporte = Reporte
        Previsualizar.ShowDialog()
    End Sub

    Public Sub ReporteAuxiliarContable(ByVal FechaInicial As Date, ByVal FechaFinal As Date, Optional ByVal CuentaInicial As String = "", Optional ByVal CuentaFinal As String = "")
        Dim Previsualizar As New PreVisualizarForm
        Dim Reporte As New rptAuxiliarContable
        Dim ds As New DataSet
        Dim dt As New dsRptAuxiliarContable.AuxiliarContableDataTable
        Dim CuentasContables As CC.CuentaContableCollection = ObtenerCuentasContables(CuentaInicial, CuentaFinal)
        Dim Periodo As String

        For Each Cuenta As EC.CuentaContableEntity In CuentasContables
            Dim CuentaContable As New CuentaContableClass(Cuenta)
            Dim SaldoInicial As Decimal = CuentaContable.CalcularSaldoInicial(FechaInicial.AddDays(-1))
            Dim Saldo As Decimal = SaldoInicial

            For Each PolizaDetalle As EC.PolizaDetalleEntity In CuentaContable.ObtenerPolizasDetalleEnRangoDeFechas(FechaInicial, FechaFinal)
                Dim PolizaDet As New PolizaDetalleClass(PolizaDetalle)
                Dim Poliza As New PolizaClass(PolizaDetalle.Poliza)

                If CuentaContable.Naturaleza = CuentaContableNaturalezaEnum.ACREEDORA Then
                    Saldo += PolizaDet.Abono - PolizaDet.Cargo
                Else
                    Saldo += PolizaDet.Cargo - PolizaDet.Abono
                End If
                dt.AddAuxiliarContableRow(PolizaDetalle.PolizaId, Poliza.AbrOrigen, PolizaDetalle.Poliza.FechaPoliza, PolizaDetalle.Poliza.Concepto, PolizaDetalle.CuentaContableId, PolizaDetalle.CuentaContable.NomCuenta, PolizaDetalle.Poliza.Referencia, PolizaDet.Cargo, PolizaDet.Abono, Saldo, PolizaDetalle.CuentaContable.Cta & PolizaDetalle.CuentaContable.SubCta & PolizaDetalle.CuentaContable.SsubCta & PolizaDetalle.CuentaContable.SssubCta, SaldoInicial, PolizaDetalle.Poliza.NumeroPoliza)
            Next
        Next

        If Not dt.Rows.Count > 0 Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.AUXILIAR_CONTABLE, 1)
        End If
        Periodo = FechaInicial.Day.ToString.PadLeft(2, "0") & "/" & Me.Culture.DateTimeFormat.GetAbbreviatedMonthName(FechaInicial.Month) & "/" & FechaInicial.Year & _
                    " AL " & _
                    FechaFinal.Day.ToString.PadLeft(2, "0") & "/" & Me.Culture.DateTimeFormat.GetAbbreviatedMonthName(FechaFinal.Month) & "/" & FechaFinal.Year

        ds.Tables.Add(dt)
        Reporte.SetDataSource(ds)
        Reporte.SetParameterValue(0, Sesion.MiEmpresa.Empnom)
        Reporte.SetParameterValue(1, Sesion.MiUsuario.Usrnomcom)
        Reporte.SetParameterValue(2, "Contabilidad/Reportes/Auxiliar de Cuentas")
        Reporte.SetParameterValue(3, Periodo)
        Previsualizar.Reporte = Reporte
        Previsualizar.ShowDialog()
    End Sub

    Public Sub ReporteMayorGeneral(ByVal Mes As MesEnum2)
        Dim Previsualizar As New PreVisualizarForm
        Dim Reporte As New RptMayorGeneral
        Dim ds As New DataSet
        Dim dt As New dsRptMayorGeneral.MayorGeneralDataTable
        Dim CuentasContables As CC.CuentaContableCollection = ObtenerCuentasMaestras()
        Dim FechaInicial As Date = Date.Parse(Now.Year & "-" & CInt(Mes).ToString.PadLeft(2, "0") & "-" & "01")
        Dim FechaFinal As Date = Date.Parse(Now.Year & "-" & (Mes + 1).ToString.PadLeft(2, "0") & "-" & "01").AddDays(-1)

        For Each Cuenta As EC.CuentaContableEntity In CuentasContables
            Dim CuentaContable As New CuentaContableClass(Cuenta)
            Dim SaldoAnterior As Decimal = CuentaContable.CalcularSaldoInicial(FechaInicial.AddDays(-1), True)
            Dim Saldo As Decimal = SaldoAnterior, Cargos As Decimal = 0D, Abonos As Decimal = 0D

            For Each PolizaDetalle As EC.PolizaDetalleEntity In CuentaContable.ObtenerPolizasDetalleEnRangoDeFechas(FechaInicial, FechaFinal, True)
                Dim PolizaDet As New PolizaDetalleClass(PolizaDetalle)
                Cargos += PolizaDet.Cargo
                Abonos += PolizaDet.Abono

                If CuentaContable.Naturaleza = CuentaContableNaturalezaEnum.ACREEDORA Then
                    Saldo += PolizaDet.Abono - PolizaDet.Cargo
                Else
                    Saldo += PolizaDet.Cargo - PolizaDet.Abono
                End If
            Next
            dt.AddMayorGeneralRow(Cuenta.Codigo, CuentaContable.DescripcionNaturaleza & "S", Cuenta.NomCuenta, Cuenta.Cta, Cuenta.SubCta, Cuenta.SsubCta, Cuenta.SssubCta, SaldoAnterior, Cargos, Abonos, Saldo)
        Next

        If Not dt.Rows.Count > 0 Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.MAYOR_GENERAL, 0)
        End If
        ds.Tables.Add(dt)
        Reporte.SetDataSource(ds)
        Reporte.SetParameterValue(0, Sesion.MiEmpresa.Empnom)
        Reporte.SetParameterValue(1, Sesion.MiUsuario.Usrnomcom)
        Reporte.SetParameterValue(2, "Contabilidad/Reportes/Mayor General")
        Reporte.SetParameterValue(3, Me.Culture.DateTimeFormat.GetMonthName(Mes).ToUpper())
        Previsualizar.Reporte = Reporte
        Previsualizar.ShowDialog()
    End Sub

    Public Sub ReporteBalanzaDeComprobacion(ByVal Mes As MesEnum2)
        Dim Previsualizar As New PreVisualizarForm
        Dim Reporte As New RptBalanzaDeComprobacion
        Dim ds As New DataSet
        Dim dt As New dsRptBalanzeDeComprobacion.BalanzaDeComprobacionDataTable
        Dim CuentasContables As CC.CuentaContableCollection = ObtenerCuentasContables()
        Dim FechaInicial As Date = Date.Parse(Now.Year & "-" & CInt(Mes).ToString.PadLeft(2, "0") & "-" & "01")
        Dim FechaFinal As Date = Date.Parse(Now.Year & "-" & (Mes + 1).ToString.PadLeft(2, "0") & "-" & "01").AddDays(-1)
        Dim CuentaAnterior As EC.CuentaContableEntity = Nothing

        For Each Cuenta As EC.CuentaContableEntity In CuentasContables
            Dim CuentaContable As New CuentaContableClass(Cuenta)
            Dim SaldoAnterior As Decimal = CuentaContable.CalcularSaldoInicial(FechaInicial.AddDays(-1), True)
            Dim Saldo As Decimal = SaldoAnterior, Cargos As Decimal = 0D, Abonos As Decimal = 0D
            Dim Cta As String = Cuenta.Cta, SubCta As String = Cuenta.SubCta, SsubCta As String = Cuenta.SsubCta, SssubCta As String = Cuenta.SssubCta

            For Each PolizaDetalle As EC.PolizaDetalleEntity In CuentaContable.ObtenerPolizasDetalleEnRangoDeFechas(FechaInicial, FechaFinal, True)
                Dim PolizaDet As New PolizaDetalleClass(PolizaDetalle)
                Cargos += PolizaDet.Cargo
                Abonos += PolizaDet.Abono

                If CuentaContable.Naturaleza = CuentaContableNaturalezaEnum.ACREEDORA Then
                    Saldo += PolizaDet.Abono - PolizaDet.Cargo
                Else
                    Saldo += PolizaDet.Cargo - PolizaDet.Abono
                End If
            Next

            If CuentaAnterior IsNot Nothing Then
                If CuentaAnterior.Cta = Cuenta.Cta And CuentaAnterior.SubCta = Cuenta.SubCta And CuentaAnterior.SsubCta = Cuenta.SsubCta Then
                    Cta = ""
                    SubCta = ""
                    SsubCta = ""
                ElseIf CuentaAnterior.Cta = Cuenta.Cta And CuentaAnterior.SubCta = Cuenta.SubCta Then
                    Cta = ""
                    SubCta = ""
                ElseIf CuentaAnterior.Cta = Cuenta.Cta Then
                    Cta = ""
                End If
            End If
            CuentaAnterior = Cuenta
            dt.AddBalanzaDeComprobacionRow(Cuenta.Codigo, CuentaContable.DescripcionNaturaleza & "S", Cuenta.NomCuenta, Cta, SubCta.Replace("0000", ""), SsubCta.Replace("0000", ""), SssubCta.Replace("0000", ""), SaldoAnterior, Cargos, Abonos, Saldo)
        Next

        If Not dt.Rows.Count > 0 Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.MAYOR_GENERAL, 0)
        End If
        ds.Tables.Add(dt)
        Reporte.SetDataSource(ds)
        Reporte.SetParameterValue(0, Sesion.MiEmpresa.Empnom)
        Reporte.SetParameterValue(1, Sesion.MiUsuario.Usrnomcom)
        Reporte.SetParameterValue(2, "Contabilidad/Reportes/Balanza de Comprobación")
        Reporte.SetParameterValue(3, Me.Culture.DateTimeFormat.GetMonthName(Mes).ToUpper())
        Previsualizar.Reporte = Reporte
        Previsualizar.ShowDialog()
    End Sub

    Public Sub ReporteRelacionesAnaliticas(ByVal FechaInicial As Date, ByVal FechaFinal As Date, Optional ByVal CuentaInicial As String = "", Optional ByVal CuentaFinal As String = "")
        Dim Previsualizar As New PreVisualizarForm, Reporte As New RptRelacionesAnaliticas
        Dim ds As New DataSet, dt As New dsRptBalanzeDeComprobacion.BalanzaDeComprobacionDataTable
        Dim CuentasContables As CC.CuentaContableCollection = ObtenerCuentasContables(CuentaInicial, CuentaFinal)
        Dim CuentaAnterior As EC.CuentaContableEntity = Nothing
        Dim Periodo As String = ""

        For Each Cuenta As EC.CuentaContableEntity In CuentasContables
            Dim CuentaContable As New CuentaContableClass(Cuenta)
            Dim SaldoAnterior As Decimal = CuentaContable.CalcularSaldoInicial(FechaInicial.AddDays(-1), True)
            Dim Saldo As Decimal = SaldoAnterior, Cargos As Decimal = 0D, Abonos As Decimal = 0D
            Dim Categoria As String = ""
            Dim CabBalance As CC.CabBalanceCollection = Cuenta.CabBalanceCollectionViaDetBalance

            For Each PolizaDetalle As EC.PolizaDetalleEntity In CuentaContable.ObtenerPolizasDetalleEnRangoDeFechas(FechaInicial, FechaFinal, True)
                Dim PolizaDet As New PolizaDetalleClass(PolizaDetalle)
                Cargos += PolizaDet.Cargo
                Abonos += PolizaDet.Abono

                If CuentaContable.Naturaleza = CuentaContableNaturalezaEnum.ACREEDORA Then
                    Saldo += PolizaDet.Abono - PolizaDet.Cargo
                Else
                    Saldo += PolizaDet.Cargo - PolizaDet.Abono
                End If
            Next

            If CabBalance.Count > 0 Then
                Categoria = IIf(CabBalance(0).CatAgrupadoresBalGralEdoRes.EsActivo, "DE ACTIVO", "DE PASIVO")
            Else
                Categoria = "OTROS"
            End If
            dt.AddBalanzaDeComprobacionRow(Cuenta.Codigo, Categoria, Cuenta.NomCuenta, Cuenta.Cta, Cuenta.SubCta.Replace("0000", ""), Cuenta.SsubCta.Replace("0000", ""), Cuenta.SssubCta.Replace("0000", ""), SaldoAnterior, Cargos, Abonos, Saldo)
        Next

        If Not dt.Rows.Count > 0 Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.MAYOR_GENERAL, 0)
        End If
        Periodo = FechaInicial.Day.ToString.PadLeft(2, "0") & "/" & Me.Culture.DateTimeFormat.GetAbbreviatedMonthName(FechaInicial.Month) & "/" & FechaInicial.Year & _
                    " AL " & _
                    FechaFinal.Day.ToString.PadLeft(2, "0") & "/" & Me.Culture.DateTimeFormat.GetAbbreviatedMonthName(FechaFinal.Month) & "/" & FechaFinal.Year

        ds.Tables.Add(dt)
        Reporte.SetDataSource(ds)
        Reporte.SetParameterValue(0, Sesion.MiEmpresa.Empnom)
        Reporte.SetParameterValue(1, Sesion.MiUsuario.Usrnomcom)
        Reporte.SetParameterValue(2, "Contabilidad/Reportes/Relaciones Analíticas")
        Reporte.SetParameterValue(3, Periodo)
        Previsualizar.Reporte = Reporte
        Previsualizar.ShowDialog()
    End Sub

    Public Function ReporteVerificadorDePolizas(ByVal Trans As HC.Transaction, ByVal OrdenarPorFecha As Boolean) As Boolean
        Dim Previsualizar As New PreVisualizarForm
        Dim Reporte As New rptVerificadorDePolizas
        Dim ds As New DataSet
        Dim dt As New dsRptVerificadorDePolizas.PolizasErroresDataTable
        Dim Polizas As New CC.PolizaCollection
        Dim PolizasConError As CC.PolizaCollection
        Dim Ordenamiento As New OC.SortExpression()

        If OrdenarPorFecha Then
            Ordenamiento.Add(New OC.SortClause(HC.PolizaFields.FechaPoliza, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
        Else
            Ordenamiento.Add(New OC.SortClause(HC.PolizaFields.NumeroPoliza, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
        End If

        Polizas.GetMulti(Nothing, 0, Ordenamiento)
        PolizasConError = ActualizarErroresPolizas(Trans, Polizas)
        Trans.Commit()

        For Each Poliza As EC.PolizaEntity In PolizasConError
            Dim Er1, Er2, Er3, Er4, Er5, Er6 As Char
            Dim Origen As String = String.Empty

            Select Case Poliza.TipoError
                Case 1 : Er1 = "X"
                Case 2 : Er2 = "X"
                Case 3 : Er3 = "X"
                Case 4 : Er4 = "X"
                Case 5 : Er5 = "X"
                Case 6 : Er6 = "X"
            End Select

            Dim Ori As PolizaOrigenEnum = CType(Asc(Poliza.Origen), PolizaOrigenEnum)
            Select Case Ori
                Case PolizaOrigenEnum.CUENTASxCOBRAR
                    Origen = "CXC"
                Case PolizaOrigenEnum.CUENTASxPAGAR
                    Origen = "CXP"
                Case PolizaOrigenEnum.ALMACEN
                    Origen = "ALM"
                Case PolizaOrigenEnum.BANCOS
                    Origen = "BAN"
                Case PolizaOrigenEnum.COMPRAS
                    Origen = "COM"
                Case PolizaOrigenEnum.CONTABILIDAD
                    Origen = "CON"
                Case PolizaOrigenEnum.VENTAS
                    Origen = "VEN"
            End Select
            dt.AddPolizasErroresRow(Poliza.FechaPoliza, Poliza.NumeroPoliza, Origen, Poliza.Concepto, Poliza.Importe, Er1, Er2, Er3, Er4, Er4, Er6)
        Next
        ds.Tables.Add(dt)
        Reporte.SetDataSource(ds)
        Reporte.SetParameterValue(0, Sesion.MiEmpresa.Empnom)
        Reporte.SetParameterValue(1, Sesion.MiUsuario.Usrnomcom)
        Reporte.SetParameterValue(2, "Contabilidad/Reportes/Verificador de Pólizas")
        Reporte.SetParameterValue(3, Me.EjercicioContable.Ejercicio)
        Reporte.SetParameterValue(4, Polizas.Count)
        Reporte.SetParameterValue(5, dt.Rows.Count)
        Previsualizar.Reporte = Reporte
        Previsualizar.ShowDialog()
        Return True
    End Function

    Public Sub ReporteEstadisticoDeLote(ByVal Lote As LoteClass, ByVal TipoImpresion As ImpresionDatosDeLote)
        Dim Previsualizar As New PreVisualizarForm, ModuloOrigen As String = "Engorda/Estadistico de Lotes"

        Select Case TipoImpresion
            Case ImpresionDatosDeLote.Resumen
                Previsualizar.Reporte = ReporteResumenLote(Lote, ModuloOrigen)
            Case ImpresionDatosDeLote.Detalle
                Previsualizar.Reporte = ReporteDetalleLote(Lote, ModuloOrigen)
            Case Else
                Previsualizar.Reporte = ReporteMovimientosLote(Lote, ModuloOrigen)
        End Select
        Previsualizar.ShowDialog()
    End Sub

    Public Sub ReporteHistorialDeTiposCambio(ByVal TiposCambio As TipoCambioCollectionClass)
        Dim Previsualizar As New PreVisualizarForm

        Previsualizar.Reporte = rptHistorialTiposCambio(TiposCambio)
        Previsualizar.ShowDialog()
    End Sub

    Private Function rptHistorialTiposCambio(ByVal TiposCambio As TipoCambioCollectionClass) As rptHistorialTiposCambio
        rptHistorialTiposCambio = New rptHistorialTiposCambio()

        rptHistorialTiposCambio.SetDataSource(TiposCambio)
        rptHistorialTiposCambio.SetParameterValue(rptHistorialTiposCambio.Parameter_Empresa.ParameterFieldName, Me.Sesion.MiEmpresa.Empnom)
        rptHistorialTiposCambio.SetParameterValue(rptHistorialTiposCambio.Parameter_Modulo.ParameterFieldName, "Catalogos/Generales/Historial de Tipos de Cambio")
        rptHistorialTiposCambio.SetParameterValue(rptHistorialTiposCambio.Parameter_Usuario.ParameterFieldName, Me.Sesion.MiUsuario.Usrnomcom)
    End Function

    Public Sub ReporteCierreFicticioDeLote(ByVal Lote As LoteClass, ByVal TipoImpresion As ImpresionDatosDeLote)
        Dim Previsualizar As New PreVisualizarForm, ModuloOrigen As String = "Engorda/Cierre Ficticio de Lotes"

        Select Case TipoImpresion
            Case ImpresionDatosDeLote.Resumen
                Previsualizar.Reporte = ReporteResumenLote(Lote, ModuloOrigen)
            Case ImpresionDatosDeLote.Detalle
                Previsualizar.Reporte = ReporteDetalleLote(Lote, ModuloOrigen)
            Case Else
                Previsualizar.Reporte = ReporteMovimientosLote(Lote, ModuloOrigen)
        End Select
        Previsualizar.ShowDialog()
    End Sub

    Private Function ReporteResumenLote(ByVal Lote As LoteClass, ByVal ModuloOrigen As String) As Object
        Dim Coleccion As New Collection(), Titulo As String

        If ModuloOrigen = "Engorda/Estadistico de Lotes" Then
            ReporteResumenLote = New rptResumenEstadisticoLote
            Titulo = "ESTADISTICO DE LOTES"
        Else
            ReporteResumenLote = New rptResumenCierreFicticioLote
            Titulo = "CIERRE FICTICIO DE LOTES"
        End If

        Coleccion.Add(Lote)
        ReporteResumenLote.SetDataSource(Coleccion)
        ReporteResumenLote.Subreports("FormulasAplicadas").SetDataSource(CType(Lote.FormulasAplicadas, Object))
        ReporteResumenLote.Subreports("MedicamentosAplicados").SetDataSource(CType(Lote.MedicamentosAplicados, Object))
        ReporteResumenLote.SetParameterValue(0, Sesion.MiEmpresa.Empnom)
        ReporteResumenLote.SetParameterValue(1, Titulo)
        ReporteResumenLote.SetParameterValue(2, Sesion.MiUsuario.Usrnomcom)
        ReporteResumenLote.SetParameterValue(3, ModuloOrigen)
        Return ReporteResumenLote
    End Function

    Private Function ReporteDetalleLote(ByVal Lote As LoteClass, ByVal ModuloOrigen As String) As Object
        Dim Coleccion As New Collection(), Titulo As String

        If ModuloOrigen = "Engorda/Estadistico de Lotes" Then
            ReporteDetalleLote = New rptEstadisticoLote
            Titulo = "ESTADISTICO DE LOTES"
        Else
            ReporteDetalleLote = New rptCierreFicticioLote
            Titulo = "CIERRE FICTICIO DE LOTES"
        End If

        Coleccion.Add(Lote)
        ReporteDetalleLote.SetDataSource(Coleccion)
        ReporteDetalleLote.Subreports("FormulasAplicadas").SetDataSource(CType(Lote.FormulasAplicadas, Object))
        ReporteDetalleLote.Subreports("MedicamentosAplicados").SetDataSource(CType(Lote.MedicamentosAplicados, Object))
        ReporteDetalleLote.SetParameterValue(0, Sesion.MiEmpresa.Empnom)
        ReporteDetalleLote.SetParameterValue(1, Titulo)
        ReporteDetalleLote.SetParameterValue(2, Sesion.MiUsuario.Usrnomcom)
        ReporteDetalleLote.SetParameterValue(3, ModuloOrigen)
        Return ReporteDetalleLote
    End Function

    Public Sub ReporteMovimientosPorLote(ByVal Lote As LoteClass)
        Dim Previsualizar As New PreVisualizarForm
        Previsualizar.Reporte = ReporteMovimientosLote(Lote, "Engorda/Reportes/Movimientos Por Lote")
        Previsualizar.ShowDialog()
    End Sub

    Private Function ReporteMovimientosLote(ByVal Lote As LoteClass, ByVal ModuloOrigen As String) As RptMovimientosPorLote
        ReporteMovimientosLote = New RptMovimientosPorLote
        Dim ds As New DataSet, dt As New dsRptMovimientosGanadoPorLote.TablaDataTable
        Dim SalidasGanado As New CC.SalidaGanadoCabCollection(), SalidasGanadoDetalle As New CC.SalidaGanadoDetCollection
        Dim Filtro As New OC.PredicateExpression, Filtro2 As New OC.PredicateExpression, Relacion As New OC.RelationCollection
        Dim Saldo As Integer = 0

        Filtro.Add(HC.SalidaGanadoCabFields.IdLoteDestino = Lote.IdLote And HC.SalidaGanadoCabFields.Estatus = EstatusDatos.VIGENTE And _
        (HC.SalidaGanadoCabFields.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Transferencia_de_Reciba_a_Corral _
        Or HC.SalidaGanadoCabFields.IdTipoReciba = SalidaGanadoCabeceroClass.TipoSalida.Corral_de_Engorda_por_Tranferencia))

        SalidasGanado.GetMulti(Filtro)

        For Each SalidaGanado As EC.SalidaGanadoCabEntity In SalidasGanado
            dt.AddTablaRow(Lote.Descripcion, SalidaGanado.IdTipoReciba, SalidaGanado.Folio, SalidaGanado.Fecha, SalidaGanado.Cabezas, 0, SalidaGanado.Kilos, SalidaGanado.CostoMovto.Value, True)
        Next

        ' Cuando son Salidas de Lote, el LoteOrigen se Establece en el campo Lote en el detalle de las Salidas de Ganado
        Filtro2.Add(HC.SalidaGanadoDetFields.IdLote = Lote.IdLote And HC.SalidaGanadoCabFields.Estatus = EstatusDatos.VIGENTE)
        Relacion.Add(EC.SalidaGanadoDetEntity.Relations.SalidaGanadoCabEntityUsingIdSalidaGanadoCab)
        SalidasGanadoDetalle.GetMulti(Filtro2, 0, New OC.SortExpression(New OC.SortClause(HC.SalidaGanadoDetFields.IdSalidaGanadoCab, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending)), Relacion)

        For i As Integer = 0 To SalidasGanadoDetalle.Count - 1
            Dim Detalle() As dsRptMovimientosGanadoPorLote.TablaRow = dt.Select("Folio ='" & SalidasGanadoDetalle(i).SalidaGanadoCab.Folio & "'")

            If Detalle.Length > 0 Then
                Detalle(0).Kilos += SalidasGanadoDetalle(i).Kilos
                Detalle(0).CostoTotal += SalidasGanadoDetalle(i).CostoxKilo * SalidasGanadoDetalle(i).Kilos
                Detalle(0).Cabezas += SalidasGanadoDetalle(i).Cabezas
            Else
                dt.AddTablaRow(Lote.Descripcion, SalidasGanadoDetalle(i).SalidaGanadoCab.IdTipoReciba, SalidasGanadoDetalle(i).SalidaGanadoCab.Folio, SalidasGanadoDetalle(i).Fecha, SalidasGanadoDetalle(i).Cabezas, 0, SalidasGanadoDetalle(i).Kilos, 0D, False)
            End If
        Next

        If Not dt.Rows.Count > 0 Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 9)
        Else
            For Each Fila As dsRptMovimientosGanadoPorLote.TablaRow In dt.Select("", "Fecha")
                If Fila.EsEntrada Then
                    Saldo += Fila.Cabezas
                Else
                    Saldo -= Fila.Cabezas
                End If
                Fila.Saldo = Saldo
            Next
        End If

        ds.Tables.Add(dt)
        ReporteMovimientosLote = New RptMovimientosPorLote
        ReporteMovimientosLote.SetDataSource(ds)
        ReporteMovimientosLote.SetParameterValue(0, ModuloOrigen)
        ReporteMovimientosLote.SetParameterValue(1, Sesion.MiUsuario.Usrnomcom)
        ReporteMovimientosLote.SetParameterValue(2, Sesion.MiEmpresa.Empnom)
        Return ReporteMovimientosLote
    End Function

    'Reportes de Auxiliares de Polizas de Facturacion

    Public Sub ReporteAuxiliarPolizasFacturasReciba(Optional ByVal Tipo As TipoFacturaEnum = TipoFacturaEnum.FACTURACION_DE_VENTA_DE_RECIBA, Optional ByVal FechaContable As DateTime = Nothing, Optional ByVal Estatus As EstatusChar = EstatusChar.TODOS)
        '    Dim FacturasdeVenta As New FacturasCollectionClass
        '    Dim Previsualizar As New PreVisualizarForm
        '    Dim Reporte As Object = Nothing
        '    Dim ds As New DataSet, dt As New dsAuxiliarPolizaFacturaRecibaVenta.AuxiliarFacturasRecibaVentaDataTable
        '    Dim Modulo As String = String.Empty
        '    Dim Filtro As New OC.PredicateExpression
        '    Dim Rows() As DataRow = Nothing

        '    Filtro.Add(HC.CabFacturasFields.Status = EstatusChar.VIGENTE)
        '    Filtro.Add(HC.CabFacturasFields.FecConta <= FechaContable)
        '    Filtro.Add(HC.CabFacturasFields.TipoFactu = Tipo)

        '    Select Case Tipo
        '        Case TipoFacturaEnum.FACTURACION_DE_VENTA_DE_RECIBA
        '            Modulo = "Auxiliar de Póliza de Facturación de Venta en Reciba"
        '            Reporte = New rptAuxiliarPolizaFacturaVentaReciba
        '    End Select


        '    For Each FacturasdeVentaCabecero As FacturasClass In Me.ObtenerFacturasdeVentayCorrales(Filtro)
        '        With FacturasdeVentaCabecero
        '            For Each detalle As FacturasDetalleClass In .Detalles
        '                Dim GanadoDescripcion As String = "", ProductoDescripcion As String = "", UnidadMedidaDescripcion As String = ""
        '                Dim CorralDestinoDescripcion As String = "", CausaMuerteDescripcion As String = "", Recuperacion As String = "NO"
        '                Dim LoteOrigen As String = ""
        '                Dim Clientes As New ClientesIntroductoresClass
        '                Clientes.Obtener(.Cliente)

        '                If (FacturasdeVentaCabecero.TipoFactura = TipoFacturaEnum.FACTURACION_DE_VENTA_DE_RECIBA _
        '                OrElse FacturasdeVentaCabecero.TipoFactura = TipoFacturaEnum.FACTURACION_DE_VENTA_DE_CORRAL _
        '                OrElse FacturasdeVentaCabecero.TipoFactura = TipoFacturaEnum.FACTURACION_DE_MUERTE_EN_RECIBA _
        '                OrElse FacturasdeVentaCabecero.TipoFactura = TipoFacturaEnum.FACTURACION_DE_MUERTE_EN_CORRAL) _
        '                Then
        '                    Dim TipodeGanado As New TipoGanadoClass
        '                    TipodeGanado.Obtener(detalle.TipoGanado)
        '                    GanadoDescripcion = TipodeGanado.Descripcion
        '                End If


        '                If (FacturasdeVentaCabecero.TipoFactura = TipoFacturaEnum.FACTURACION_ESPECIAL _
        '                 OrElse FacturasdeVentaCabecero.TipoFactura = TipoFacturaEnum.VENTA_DE_PRODUCTO) _
        '                 Then
        '                    If detalle.IdProducto <> 0 Then
        '                        Dim Producto As New ProductoClass
        '                        Producto.Obtener(detalle.IdProducto)
        '                        ProductoDescripcion = Producto.Descripcion
        '                        UnidadMedidaDescripcion = Producto.UnidadMedida.DescCorta
        '                    Else
        '                        ProductoDescripcion = detalle.Descripcion
        '                    End If
        '                End If


        '                If Not detalle.PrecioxKilo.HasValue Then
        '                    detalle.PrecioxKilo = 0D
        '                End If
        '                dt.AddAuxiliarFacturasRecibaVentaRow(.NoFactura, .Cliente, Clientes.Nombre, .FechaFactura, .FechaVencimiento, .ImporteSubTotal, .ImporteDescuento, detalle.PorcentajeIVA, detalle.TipoGanado, GanadoDescripcion, detalle.IdProducto, _
        '                                                  ProductoDescripcion, UnidadMedidaDescripcion, detalle.Cabezas, detalle.Kilos, detalle.PrecioxKiloxTipoGanado, detalle.Cantidad, detalle.PrecioUnitario, detalle.Descripcion)
        '            Next
        '        End With
        '    Next

        '    ds.Tables.Add(dt)
        '    Reporte.SetDataSource(ds)
        '    'Reporte.SetParameterValue(0, "AuxiliaresContables/" & Modulo)
        '    'Reporte.SetParameterValue(1, Sesion.MiUsuario.Usrnomcom)
        '    Reporte.SetParameterValue(0, Sesion.MiEmpresa.Empnom)
        '    Previsualizar.Reporte = Reporte
        '    Previsualizar.ShowDialog()
    End Sub

#End Region

End Class


