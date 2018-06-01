Imports CN = ClasesNegocio
Imports HC = Integralab.ORM.HelperClasses
Imports ECS = Integralab.ORMSeguridad.EntityClasses
Imports EC = Integralab.ORM.EntityClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports System.Data.SqlClient

Public Class ClientesIntroductoresClass
    Inherits ClassBase(Of EC.MfacCatClientesEntity)
    Dim _DomiciliosFiscales As DomicilioClienteColeccionClass
    Private _CuentaContable As CuentaContableClass
    Private _Idcuentaventa As CuentaContableClass
    Private _Idcuentanticipo As CuentaContableClass
    Private _Vendedor As VendedorClass
    Private _Estado As EstadoClass
    Private _Ciudad As CiudadClass
    Private _Poblacion As PoblacionClass

#Region "Propiedades"

    Public ReadOnly Property Codigo() As Integer
        Get
            Return Entity.IdCliente
        End Get
    End Property

    Public Property Nombre() As String
        Get
            Return Entity.Nombre
        End Get
        Set(ByVal value As String)
            Entity.Nombre = value
        End Set
    End Property

    Public Property Domicilio() As String
        Get
            Return Entity.Domicilio
        End Get
        Set(ByVal value As String)
            Entity.Domicilio = value
        End Set
    End Property

    Public Property IdEstado() As Integer
        Get
            Return Entity.IdEstado
        End Get
        Set(ByVal value As Integer)
            Entity.IdEstado = value
        End Set
    End Property

    Public Property IdCiudad() As Integer
        Get
            Return Entity.IdCiudad
        End Get
        Set(ByVal value As Integer)
            Entity.IdCiudad = value
        End Set
    End Property

    Public Property IdPoblacion() As Integer
        Get
            Return Entity.IdPoblacion
        End Get
        Set(ByVal value As Integer)
            Entity.IdPoblacion = value
        End Set
    End Property

    Public Property CodigoPostal() As String
        Get
            Return Entity.CodigoPostal
        End Get
        Set(ByVal value As String)
            Entity.CodigoPostal = value
        End Set
    End Property

    Public Property Colonia() As String
        Get
            Return Me.Entity.Colonia
        End Get
        Set(ByVal value As String)
            Me.Entity.Colonia = value
        End Set
    End Property

    Public Property FechaAlta() As Date
        Get
            Return Entity.FechaAlta
        End Get
        Set(ByVal value As Date)
            Entity.FechaAlta = value
        End Set
    End Property

    Public Property FechaCancelacion() As Date
        Get
            Return Entity.FechaCancelacion
        End Get
        Set(ByVal value As Date)
            Entity.FechaCancelacion = value
        End Set
    End Property

    Public Property DiasCredito() As Integer
        Get
            Return Entity.DiasCredito
        End Get
        Set(ByVal value As Integer)
            Entity.DiasCredito = value
        End Set
    End Property

    Public Property DiasRevision() As String
        Get
            Return Entity.DiasRevision
        End Get
        Set(ByVal value As String)
            Entity.DiasRevision = value
        End Set
    End Property

    Public Property LimiteCredito() As Decimal
        Get
            Return Entity.LimiteCredito
        End Get
        Set(ByVal value As Decimal)
            Entity.LimiteCredito = value
        End Set
    End Property

    Public Property DiasPago() As String
        Get
            Return Entity.DiasPago
        End Get
        Set(ByVal value As String)
            Entity.DiasPago = value
        End Set
    End Property

    Public Property TipoFacturacion() As Integer
        Get
            Return Entity.TipoFacturacion
        End Get
        Set(ByVal value As Integer)
            Entity.TipoFacturacion = value
        End Set
    End Property

    Public Property FechaultimaCompra() As Date
        Get
            Return Entity.FechaUltimaCompra
        End Get
        Set(ByVal value As Date)
            Entity.FechaUltimaCompra = value
        End Set
    End Property

    Public Property ImporteUltimaCompra() As Decimal
        Get
            Return Entity.ImporteUltimaCompra
        End Get
        Set(ByVal value As Decimal)
            Entity.ImporteUltimaCompra = value
        End Set
    End Property

    Public Property Telefono() As String
        Get
            Return Entity.Telefono
        End Get
        Set(ByVal value As String)
            Entity.Telefono = value
        End Set
    End Property

    Public Property RFC() As String
        Get
            Return Entity.Rfc
        End Get
        Set(ByVal value As String)
            Entity.Rfc = value
        End Set
    End Property

    Public Property Observaciones() As String
        Get
            Return Entity.ObservacionesPalletizado
        End Get
        Set(ByVal value As String)
            Entity.ObservacionesPalletizado = value
        End Set
    End Property

    Public Property EsPersonaFisica() As Boolean
        Get
            Return Entity.EsPersonaFisica
        End Get
        Set(ByVal value As Boolean)
            Entity.EsPersonaFisica = value
        End Set
    End Property

    Public Property Logo() As Byte()
        Get
            Return Entity.Logo
        End Get
        Set(ByVal value As Byte())
            Entity.Logo = value
        End Set
    End Property

    Public Property Poblacion() As PoblacionClass
        Get
            If _Poblacion Is Nothing Then
                _Poblacion = New PoblacionClass(Entity.IdEstado, Entity.IdCiudad, Entity.IdPoblacion)
            End If
            Return _Poblacion
        End Get
        Set(ByVal value As PoblacionClass)
            _Poblacion = value

            'If value Is Nothing Then
            '    Entity.Poblacion = Nothing
            'Else
            '    Entity.Poblacion = value.ObtenerEntidad()
            'End If
        End Set
    End Property

    Public ReadOnly Property Ciudad() As CiudadClass
        Get
            If _Ciudad Is Nothing Then
                _Ciudad = New CiudadClass(Entity.IdEstado, Entity.IdCiudad)
            End If
            Return _Ciudad
        End Get
    End Property

    Public ReadOnly Property Estado() As EstadoClass
        Get
            If _Estado Is Nothing Then
                _Estado = New EstadoClass(Ciudad.ObtenerEntidad.Estado)
            End If
            Return _Estado
        End Get
    End Property

    Public Property CuentaContable() As CuentaContableClass
        Get
            If _CuentaContable Is Nothing Then
                _CuentaContable = New CuentaContableClass(Entity.CuentaContable)
            End If
            Return _CuentaContable
        End Get
        Set(ByVal value As CuentaContableClass)
            _CuentaContable = value
            If value Is Nothing Then
                Entity.CuentaContable = Nothing
            Else
                Entity.CuentaContable = value.ObtenerEntidad
            End If
        End Set
    End Property

    Public Property CuentaContableAntici() As CuentaContableClass
        Get
            If _Idcuentanticipo Is Nothing Then
                _Idcuentanticipo = New CuentaContableClass(Entity.CuentaAnticipoId)
            End If
            Return _Idcuentanticipo
        End Get
        Set(ByVal value As CuentaContableClass)
            _Idcuentanticipo = value
            If value Is Nothing Then
                Entity.CuentaAnticipoId = Nothing
            Else
                Entity.CuentaContable = value.ObtenerEntidad
            End If
        End Set
    End Property

    Public Property CuentaContableId() As Integer
        Get
            Return Me.Entity.CuentaContId.GetValueOrDefault(-1)
        End Get
        Set(ByVal value As Integer)
            Me.Entity.CuentaContId = value
        End Set
    End Property

    Public Property CuentaAntiId() As Integer
        Get
            Return Entity.CuentaAnticipoId.GetValueOrDefault(-1)
        End Get
        Set(ByVal value As Integer)
            Me.Entity.CuentaAnticipoId = value
        End Set
    End Property

    Public Property Introductor() As Boolean
        Get
            Return Entity.Introductor.GetValueOrDefault(False)
        End Get
        Set(ByVal value As Boolean)
            Entity.Introductor = value
        End Set
    End Property

    Public Property Estatus() As EstatusEnum
        Get
            Return Entity.Estatus
        End Get
        Set(ByVal value As EstatusEnum)
            Entity.Estatus = value
        End Set
    End Property

    Public Property RazonSocial() As String
        Get
            Return Entity.RazonSocial
        End Get
        Set(ByVal value As String)
            Entity.RazonSocial = value
        End Set
    End Property

    Public ReadOnly Property DomiciliosFiscales() As DomicilioClienteColeccionClass
        Get
            If _DomiciliosFiscales Is Nothing Then
                _DomiciliosFiscales = New DomicilioClienteColeccionClass()
                If Not Entity.IsNew Then
                    Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
                    filtro.Add(HC.MfacClientesDatosFiscalesFields.IdCliente = Entidad.IdCliente)
                    _DomiciliosFiscales.Obtener(filtro)
                    '_DomiciliosFiscales.RellenarMe(Me.Entity.MfacClientesDatosFiscales)
                End If
            End If
            Return _DomiciliosFiscales
        End Get
    End Property

    Public Property ClientesVarios() As Boolean
        Get
            Return Entity.ClientesVarios
        End Get
        Set(ByVal value As Boolean)
            Entity.ClientesVarios = value
        End Set
    End Property

    Public Property IdVendedor() As Integer
        Get
            Return Entity.IdVendedor
        End Get
        Set(ByVal value As Integer)
            Entity.IdVendedor = value
        End Set
    End Property

    Public Property Vendedor() As VendedorClass
        Get
            If _Vendedor Is Nothing Then
                _Vendedor = New VendedorClass(Entity.Comicionista)
            End If
            Return _Vendedor
        End Get
        Set(ByVal value As VendedorClass)
            _Vendedor = value
            If value Is Nothing Then
                Entity.Comicionista = Nothing
            Else
                Entity.Comicionista = value.ObtenerEntidad
            End If
        End Set
    End Property

    Public ReadOnly Property DomicilioFiscalPrincipal() As DomicilioClienteClass
        Get
            For Each domicilio As DomicilioClienteClass In DomiciliosFiscales
                If domicilio.EsPrincipal Then Return domicilio
            Next
            Return New DomicilioClienteClass()
        End Get
    End Property

    Public ReadOnly Property Facturas() As CC.FacturasClientesCabCollection
        Get
            Return Me.Entity.FacturasClientesCab_
        End Get
    End Property

    Public ReadOnly Property ChequesDevueltos() As CC.ChequeDevueltoCollection
        Get
            Return Me.Entidad.ChequeDevuelto
        End Get
    End Property

    Public Property Idtipocliente() As Integer
        Get
            Return Entity.Idtipocliente
        End Get
        Set(ByVal value As Integer)
            Entity.Idtipocliente = value
        End Set
    End Property

    Public Property canaldistribucion() As String
        Get
            Return Entity.Canaldistribucion
        End Get
        Set(ByVal value As String)
            Entity.Canaldistribucion = value
        End Set
    End Property


    Public Property UsoCFDI() As String
        Get
            Return Entity.UsoCfdi
        End Get
        Set(ByVal value As String)
            Entity.UsoCfdi = value
        End Set
    End Property

    Public Property FormaPago() As String
        Get
            Return Entity.FormaPago
        End Get
        Set(ByVal value As String)
            Entity.FormaPago = value
        End Set
    End Property


    Public Property Idcuentaventa() As Integer
        Get
            Return Entity.Idcuentaventa
        End Get
        Set(ByVal value As Integer)
            Entity.Idcuentaventa = value
        End Set
    End Property

    Public Property CuentaContableVenta() As CuentaContableClass
        Get
            If _Idcuentaventa Is Nothing Then
                _Idcuentaventa = New CuentaContableClass(Entity.Idcuentaventa)
            End If
            Return _Idcuentaventa
        End Get
        Set(ByVal value As CuentaContableClass)
            _Idcuentaventa = value
            If value Is Nothing Then
                Entity.Idcuentaventa = Nothing
            Else
                Entity.CuentaContable = value.ObtenerEntidad
            End If
        End Set
    End Property
#End Region

#Region "Constructores"
    Sub New()
        Me.Entity = New EC.MfacCatClientesEntity
    End Sub
    Sub New(ByVal Entidad As EC.MfacCatClientesEntity)
        Me.Entity = Entidad
    End Sub
    Sub New(ByVal IdCliente As Integer)
        Me.Entity = New EC.MfacCatClientesEntity(IdCliente)
    End Sub
#End Region

    Public Sub ActualizarDomiciliosFiscales()
        Dim Coleccion As New CC.MfacClientesDatosFiscalesCollection()
        Coleccion.GetMulti(HC.MfacClientesDatosFiscalesFields.IdCliente = Me.Codigo)
        _DomiciliosFiscales = New DomicilioClienteColeccionClass(Coleccion)
    End Sub

    Public Function Obtener(ByVal IdCliente As Integer) As Boolean
        Try
            Return Me.Entity.FetchUsingPK(IdCliente)
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

    Public Overrides Function ToString() As String
        Return Entity.Nombre
    End Function

    Public Function ObtenerSaldoDeuda(ByVal claveCliente As Integer) As Decimal
        Try
            Using connection As New SqlConnection(HC.DbUtils.ActualConnectionString)
                connection.Open()
                Dim command As SqlCommand
                Dim query As String
                Dim reader As SqlDataReader

                query = "SELECT SUM(SubTotal + ImpteIVA) AS Total FROM CabFacturas WHERE Cve_Cliente = '{0}' AND Status = 'V'"
                query = String.Format(query, claveCliente)
                command = connection.CreateCommand()
                command.CommandText = query
                reader = command.ExecuteReader()
                reader.Read()
                If IsDBNull(reader.GetValue(0)) Then
                    Return 0
                Else
                    Console.WriteLine(reader.GetValue(0))
                    Return reader.GetValue(0)
                End If
            End Using
            'Dim Saldo As Decimal
            'Dim FacturasCol As New CC.FacturasClientesCabCollection

            'FacturasCol.GetMulti(HC.FacturasClientesCabFields.IdClienteCargo = Me.Codigo And HC.FacturasClientesCabFields.Estatus = "V")
            'For Each Fact As EC.FacturasClientesCabEntity In FacturasCol
            '    Saldo += Fact.Total
            'Next

            'Dim Pagos As New CC.PagoDeCtesCollection
            'Pagos.GetMulti(HC.PagoDeCtesFields.CveCliente = Me.Codigo And HC.PagoDeCtesFields.Estatus = "V")
            'For Each Pago As EC.PagoDeCtesEntity In Pagos
            '    Saldo += Pago.SaldoFactura
            'Nextx
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

    'Elimina todos los domicilios anteriores para guardar los nuevos,
    'tambien si encuentra un solo domicilio lo define como principal
    'y cuida que en caso de encontrar varios domicilios se defina el principal
    Public Sub GuardarDomiciliosFiscales(ByVal Trans As Integralab.ORM.HelperClasses.Transaction)
        Dim coleccion As New CC.MfacClientesDatosFiscalesCollection()
        Dim Ninguno As Boolean = True

        'Conprueba que si existe mas de un domicilio se defina el principal
        If Me.DomiciliosFiscales.Count = 0 Then
            Ninguno = False
        ElseIf Me.DomiciliosFiscales.Count = 1 Then
            Me.DomiciliosFiscales(0).EsPrincipal = True
            Ninguno = False
        Else
            For Each domicilio As DomicilioClienteClass In DomiciliosFiscales
                If domicilio.EsPrincipal Then
                    Ninguno = False
                End If
            Next
        End If

        If Ninguno Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.CATALOGO_CLIENTES, 0)
        End If

        'Eliminar los domicilios anteriores
        coleccion.GetMulti(HC.MfacClientesDatosFiscalesFields.IdCliente = Me.Codigo)
        Trans.Add(coleccion)
        coleccion.DeleteMulti()

        'Guardar cada uno de los domicilios
        For i As Integer = 0 To Me.DomiciliosFiscales.Count - 1
            Dim Domicilio As New DomicilioClienteClass(DomiciliosFiscales(i).IdEstado, DomiciliosFiscales(i).IdCiudad, DomiciliosFiscales(i).IdPoblacion, DomiciliosFiscales(i).Colonia, DomiciliosFiscales(i).Calle, DomiciliosFiscales(i).NoExt, DomiciliosFiscales(i).NoInt, DomiciliosFiscales(i).CodigPostal, DomiciliosFiscales(i).Telefono1, DomiciliosFiscales(i).Celular, DomiciliosFiscales(i).Fax, DomiciliosFiscales(i).Email, DomiciliosFiscales(i).IdDepartamento)
            Domicilio.IdCliente = Me.Codigo
            Domicilio.IdRenglon = i + 1
            Domicilio.EsPrincipal = DomiciliosFiscales(i).EsPrincipal
            Domicilio.Guardar(Trans)
        Next
    End Sub

    Public Sub EliminarDomicilioFiscal(ByVal index As Integer, ByVal sesion As ECS.SesionesEntity)
        If DomiciliosFiscales.Count <= 0 Then
            Throw New Exception("No existe ningun domicilio")
        ElseIf index > DomiciliosFiscales.Count - 1 Then
            Throw New Exception("No existe ningun domicilio con ese indice")
        Else
            If DomiciliosFiscales.Count = 1 Then
                MsgBox("Unicamente existe este domicilio, se recomienda modificarlo si es el caso" & Chr(13) & String.Format("Domicilio : {0}" & Chr(13) & "Colonia : {1}" & Chr(13) & "Poblacion {2}", Me.DomiciliosFiscales(index).Domicilio, Me.DomiciliosFiscales(index).Colonia, Me.DomiciliosFiscales(index).Poblacion.Descripcion), MsgBoxStyle.Exclamation, sesion.MiEmpresa.Empnom)
                Exit Sub
            End If

            If MsgBox("Esta tratando de eliminar un domicilio, ¿Esta seguro?" & Chr(13) & String.Format("Domicilio : {0}" & Chr(13) & "Colonia : {1}" & Chr(13) & "Poblacion {2}", Me.DomiciliosFiscales(index).Domicilio, Me.DomiciliosFiscales(index).Colonia, Me.DomiciliosFiscales(index).Poblacion.Descripcion), MsgBoxStyle.Question + MsgBoxStyle.YesNo, sesion.MiEmpresa.Empnom) = MsgBoxResult.Yes Then
                DomiciliosFiscales.RemoveAt(index)
            End If
        End If
    End Sub

    Public Shadows Function Guardar(ByVal Trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        ' If Me.Entidad.IsNew Then
        Dim Coleccion As New CC.MfacCatClientesCollection
        If RFC.Trim() <> "XAXX010101000" Then
            If Coleccion.GetDbCount(HC.MfacCatClientesFields.Rfc = RFC And HC.MfacCatClientesFields.IdCliente <> Codigo) > 0 Then
                MsgBox("Ya está registrado un cliente con este RFC, Ingrese otro..", MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End If
        End If
        'End If
        MyBase.Guardar(Trans)
        GuardarDomiciliosFiscales(Trans)
        Return True
    End Function

    Public Sub ValidarDomicliosDiferentes(ByVal Domicilio As DomicilioClienteClass, Optional ByVal index As Integer = -1)
        For i As Integer = 0 To DomiciliosFiscales.Count - 1
            Dim Item As DomicilioClienteClass = DomiciliosFiscales(i)

            If index <> i AndAlso Domicilio.Domicilio.Trim = Item.Domicilio.Trim AndAlso Domicilio.Colonia.Trim = Item.Colonia.Trim AndAlso Domicilio.IdPoblacion = Item.IdPoblacion Then
                Throw New Exception(String.Format("No se permiten domicilios repetidos, favor de proporcionar un domicilio diferente" & Chr(13) & "Domicilio : {0}" & Chr(13) & "Colonia : {1}" & Chr(13) & "Poblacion {2}", Domicilio.Domicilio, Domicilio.Colonia, Domicilio.Poblacion.Descripcion))
            End If
        Next
    End Sub

    Public Sub SeleccionarDomicilioPrincipal(ByVal index As Integer, ByVal sesion As ECS.SesionesEntity)
        If DomiciliosFiscales.Count <= 0 Then
            Throw New Exception("No existe ningun domicilio")
        ElseIf index > DomiciliosFiscales.Count - 1 Then
            Throw New Exception("No existe ningun domicilio con ese indice")
        Else
            If DomiciliosFiscales.Count > 1 Then
                Dim ExistePrincipal As Boolean = False

                For i As Integer = 0 To DomiciliosFiscales.Count - 1
                    If index <> i And DomiciliosFiscales(i).EsPrincipal Then
                        ExistePrincipal = True
                    End If
                Next

                If Not ExistePrincipal Then
                    DomiciliosFiscales(index).EsPrincipal = True
                    Return
                End If

                If MsgBox("Esta tratando de establecer el domicilio como principal, ¿Esta seguro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, sesion.MiEmpresa.Empnom) = MsgBoxResult.Yes Then
                    For i As Integer = 0 To DomiciliosFiscales.Count - 1
                        Dim Domicilio As DomicilioClienteClass = DomiciliosFiscales(i)
                        Domicilio.EsPrincipal = False
                    Next
                    DomiciliosFiscales(index).EsPrincipal = True
                End If
            Else
                DomiciliosFiscales(index).EsPrincipal = True
            End If
        End If
    End Sub
End Class

Public Class ClientesIntroductoresColeccion
    Inherits ColleccionBase(Of EC.MfacCatClientesEntity, CC.MfacCatClientesCollection, ClientesIntroductoresClass)

    Public Overloads Function Obtener(ByVal Estatus As CondicionEstatusEnum) As Integer
        Try
            Dim Filtro As New OC.PredicateExpression
            Dim Orden As New OC.SortExpression(New OC.SortClause(HC.MfacCatClientesFields.Nombre, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))

            If Not Estatus = CondicionEstatusEnum.TODOS Then
                Filtro.Add(HC.MfacCatClientesFields.Estatus = Estatus)
            End If
            coleccion.GetMulti(Filtro, 0, Orden)
            Rellenar()
            Return Count
        Catch ex As Exception
            Return -1
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

    Public Overloads Function Obtener(ByVal EsIntroductor As Boolean) As Integer
        Try
            Dim filtro As New OC.PredicateExpression
            Dim sort As New SD.LLBLGen.Pro.ORMSupportClasses.SortExpression
            sort.Add(New SD.LLBLGen.Pro.ORMSupportClasses.SortClause(HC.MfacCatClientesFields.Nombre, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
            'If Not Estatus = CondicionEstatusEnum.TODOS Then
            '    filtro.Add(HC.MfacCatClientesFields.Estatus = Estatus)
            'End If
            filtro.Add(HC.MfacCatClientesFields.Introductor = EsIntroductor)
            filtro.Add(HC.MfacCatClientesFields.Estatus = EstatusEnum.ACTIVO)
            coleccion.GetMulti(filtro, 0, sort)
            Rellenar()
            Return Count
        Catch ex As Exception
            Return Nothing
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

    Public Overloads Function Obtener(ByVal Nombre As String) As Integer
        Try
            Me.Clear()
            Dim filtro As New SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression
            filtro.Add(HC.MfacCatClientesFields.Nombre Mod String.Format("%{0}%", Nombre))
            coleccion.GetMulti(filtro)
            Rellenar()
            Return Me.Count
        Catch ex As Exception
            Return Nothing
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

    Public Overloads Function Obtener(ByVal EsClienteVarios As Boolean, ByVal Estatus As CondicionEstatusEnum, Optional ByVal Codigo As Integer = 0) As Integer
        Try
            Me.Clear()
            Dim filtro As New OC.PredicateExpression
            Dim orden As New OC.SortExpression(New OC.SortClause(HC.MfacCatClientesFields.Nombre, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))
            If Not Estatus = CondicionEstatusEnum.TODOS Then
                filtro.Add(HC.MfacCatClientesFields.Estatus = Estatus)
            End If
            filtro.Add(HC.MfacCatClientesFields.ClientesVarios = EsClienteVarios)
            If Codigo <> 0 Then
                filtro.Add(HC.MfacCatClientesFields.IdCliente = Codigo)
            End If
            coleccion.GetMulti(filtro, 0, orden)
            Rellenar()
            Return Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
            Return -1
        End Try
    End Function

    Public Function Reporte(ByVal Empresa As String, ByVal Usuario As String) As RptABCClientes
        Dim Report As New RptABCClientes
        Dim ds As New DataSet
        Dim Tabla As New DsClientes.ClientesDataTable
        For Each Cliente As CN.ClientesIntroductoresClass In Me
            Tabla.AddClientesRow(Cliente.Codigo, Cliente.Nombre, Cliente.RFC, Cliente.Domicilio, Cliente.Estatus.ToString)
        Next
        ds.Tables.Add(Tabla)
        Report.SetDataSource(ds)
        Report.SetParameterValue(0, Empresa)
        Report.SetParameterValue(1, Usuario)
        Report.SetParameterValue(2, "Catalogos\Ventas\Clientes")
        Return Report
    End Function

End Class
