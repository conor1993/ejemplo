
Imports System.Windows.Forms
Imports SPA = Integralab.ORM.StoredProcedureCallerClasses
Imports ORM = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = Integralab.ORM.HelperClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports Microsoft.Win32


Public Class RecepcionOrdenCompraClass
    Inherits ClassBase(Of EC.RecepcionOrdenCompraEntity)

    Private _RecepOrdenCompraDet As RecepcionOrdenCompraDetCollectionClass
    Private _Collection As CC.McomRecepcionOrdenCompraDetCollection
    Private _Sucursal As SucursalClass
    Private _OrdenCompra As OrdenCompraClass

#Region "Propiedades"

    Public ReadOnly Property FolioRecepcionOrdenCompra() As String
        Get
            Return Entity.FolioRecepcionOrdenCompra
        End Get
    End Property

    Public ReadOnly Property IdRecepcionOrdenCompra() As Integer
        Get
            Return Me.Entity.IdRecepcionOrdenCompra
        End Get
    End Property

    Public ReadOnly Property OrdenCompra() As OrdenCompraClass
        Get
            If _OrdenCompra Is Nothing OrElse _OrdenCompra.IdOrdenCompra <> Me.IdOrdenCompra Then
                _OrdenCompra = New OrdenCompraClass(Me.Entity.OrdenCompra)
            End If
            Return _OrdenCompra
        End Get
    End Property

    Public Property IdOrdenCompra() As Integer
        Get
            Return Me.Entity.IdOrdenCompra
        End Get
        Set(ByVal value As Integer)
            Me.Entity.IdOrdenCompra = value
        End Set
    End Property

    Public Property IdProveedor() As Integer
        Get
            Return Me.Entity.IdProveedor
        End Get
        Set(ByVal value As Integer)
            Me.Entity.IdProveedor = value
        End Set
    End Property

    Public ReadOnly Property proveedor As String
        Get
            Dim prov As New ClasesNegocio.ProveedorClass(Entity.IdProveedor)
            If prov.RazonSocial.Trim().Equals("") Then
                Return prov.Nombre
            Else
                Return prov.RazonSocial
            End If
        End Get
    End Property

    Public Property NoRemision() As String
        Get
            Return Me.Entity.NoRemision
        End Get
        Set(ByVal value As String)
            Me.Entity.NoRemision = value
        End Set
    End Property

    Public Property Pagada() As Boolean
        Get
            Return Me.Entity.Pagada
        End Get
        Set(ByVal value As Boolean)
            Me.Entity.Pagada = value
        End Set
    End Property

    Public Property FolioMovimientoAlmCan() As String
        Get
            Return Me.Entity.FolioMovimientoAlmCan
        End Get
        Set(ByVal value As String)
            Me.Entity.FolioMovimientoAlmCan = value
        End Set
    End Property

    Public Property FolioMovimientoAlm() As String
        Get
            Return Me.Entity.FolioMovimientoAml
        End Get
        Set(ByVal value As String)
            Me.Entity.FolioMovimientoAml = value
        End Set
    End Property

    Public Property FechaRecepcion() As Date
        Get
            Return Me.Entity.FechaRecepcion
        End Get
        Set(ByVal value As Date)
            Me.Entity.FechaRecepcion = value
        End Set
    End Property

    Public Property FechaCaptura() As Date
        Get
            Return Entity.FechaCaptura
        End Get
        Set(ByVal value As Date)
            Entity.FechaCaptura = value
        End Set
    End Property

    Public Property AlmacenId() As Integer
        Get
            Return Me.Entity.AlmacenId
        End Get
        Set(ByVal value As Integer)
            Me.Entity.AlmacenId = value
        End Set
    End Property

    Public Property FechaCancelacion() As Date
        Get
            Return Me.Entity.FechaCancelacion
        End Get
        Set(ByVal value As Date)
            Me.Entity.FechaCancelacion = value
        End Set
    End Property

    Public Property UsuarioAltaId() As Integer
        Get
            Return Me.Entity.UsuarioAltaId
        End Get
        Set(ByVal value As Integer)
            Me.Entity.UsuarioAltaId = value
        End Set
    End Property

    Public Property UsuarioCancelacionId() As Integer
        Get
            If Me.Entity.UsuarioCancelacionId Is Nothing Then
                Return 0
            Else
                Return Me.Entity.UsuarioCancelacionId
            End If
        End Get
        Set(ByVal value As Integer)
            Me.Entity.UsuarioCancelacionId = value
        End Set
    End Property

    Public Property Observaciones_Cancelacion() As String
        Get
            Return Me.Entity.ObservacionesCancelacion
        End Get
        Set(ByVal value As String)
            Me.Entity.ObservacionesCancelacion = value
        End Set
    End Property

    Public Property Estatus() As EstatusDatos
        Get
            Return Me.Entity.Estatus
        End Get
        Set(ByVal value As EstatusDatos)
            Me.Entity.Estatus = value
        End Set
    End Property

    Public Property MotivoCancelacionId() As Integer
        Get
            If Me.Entity.MotivoCancelacionId Is Nothing Then
                Return 0
            Else
                Return Me.Entity.MotivoCancelacionId
            End If
        End Get
        Set(ByVal value As Integer)
            Me.Entity.MotivoCancelacionId = value
        End Set
    End Property

    Public Property Observaciones() As String
        Get
            Return Me.Entity.Observaciones
        End Get
        Set(ByVal value As String)
            Me.Entity.Observaciones = value
        End Set
    End Property

    Public Property IdSucursal() As Integer
        Get
            Return Me.Entity.IdSucursal
        End Get
        Set(ByVal value As Integer)
            Me.Entity.IdSucursal = value
        End Set
    End Property

    Public Property NumFactura() As String
        Get
            Return Me.Entity.NoFactura
        End Get
        Set(ByVal value As String)
            Me.Entity.NoFactura = value
        End Set
    End Property

    Public ReadOnly Property Detalles() As RecepcionOrdenCompraDetCollectionClass
        Get
            If _RecepOrdenCompraDet Is Nothing Then
                _RecepOrdenCompraDet = New RecepcionOrdenCompraDetCollectionClass
                _RecepOrdenCompraDet.RellenarMe(Me.Entity.McomRecepcionOrdenCompraDet)
            End If
            Return _RecepOrdenCompraDet
        End Get
    End Property

    Public ReadOnly Property Cantidad() As Decimal
        Get
            Dim Cant As Decimal
            For Each Det As EC.McomRecepcionOrdenCompraDetEntity In Me.Entity.McomRecepcionOrdenCompraDet
                Cant = Cant + Det.Cantidad
            Next
            Return Cant
        End Get
    End Property

    Public Property SubTotal() As Decimal
        Get
            If IsNothing(Me.Entity.SubTotal) Then
                Return 0
            End If
            Return Me.Entity.SubTotal
        End Get
        Set(ByVal value As Decimal)
            Me.Entity.SubTotal = value
        End Set
    End Property

    Public Property Descuento() As Decimal
        Get
            Return Me.Entity.Descuento
        End Get
        Set(ByVal value As Decimal)
            Me.Entity.Descuento = value
        End Set
    End Property

    Public Property IVA() As Decimal
        Get
            If IsNothing(Me.Entity.Iva) Then
                Return 0
            End If
            Return Me.Entity.Iva
        End Get
        Set(ByVal value As Decimal)
            Me.Entity.Iva = value
        End Set
    End Property

    Public Property Ieps() As Decimal
        Get
            If IsNothing(Me.Entity.Ieps) Then
                Return 0
            End If
            Return Me.Entity.Ieps
        End Get
        Set(ByVal value As Decimal)
            Me.Entity.Ieps = value
        End Set
    End Property

    Public Property Total() As Decimal
        Get
            Return Me.Entity.Total
        End Get
        Set(ByVal value As Decimal)
            Me.Entity.Total = value
        End Set
    End Property

    Public Property Facturada() As Boolean
        Get
            Return Me.Entity.Facturada
        End Get
        Set(ByVal value As Boolean)
            Me.Entity.Facturada = value
        End Set
    End Property

    Public Property EsDirecta() As Boolean
        Get
            Return Entity.EsDirecta
        End Get
        Set(ByVal value As Boolean)
            Entity.EsDirecta = value
        End Set
    End Property

    Public Property OrigenMovimiento() As String
        Get
            Return Entity.OrigenMovimiento
        End Get
        Set(ByVal value As String)
            Entity.OrigenMovimiento = value
        End Set
    End Property

    Public ReadOnly Property Sucursal() As SucursalClass
        Get
            If _Sucursal Is Nothing Then
                _Sucursal = New SucursalClass(Me.Entity.Sucursal)
            End If
            Return _Sucursal
        End Get
    End Property

#End Region

#Region "Metodos"

    Public Function Borrar(ByRef Trans As HC.Transaction) As Boolean
        Try
            Me.Entity.Estatus = EstatusDatos.CANCELADO
            Me.Entity.FechaCancelacion = Now

            Trans.Add(Me.Entity)
            If Not Me.Entity.Save() Then
                Trans.Rollback()
                Return False
            End If

            Dim ColeccionOrdenDet As New CC.OrdenCompraDetalleCollection
            ColeccionOrdenDet.GetMulti(HC.OrdenCompraDetalleFields.IdOrdenCompra = Me.Entity.IdOrdenCompra)

            Dim Encuentra As Boolean
            For Each OrdenDet As EC.OrdenCompraDetalleEntity In ColeccionOrdenDet
                Encuentra = False
                For Each RecepDet As RecepcionOrdenCompraDetClass In Me.Detalles
                    If RecepDet.IdProducto = OrdenDet.IdProducto Then
                        Dim Resta As Integer = OrdenDet.CantRecibida
                        OrdenDet.CantRecibida = Resta - RecepDet.Cantidad
                        OrdenDet.CantPendientexRecibir = OrdenDet.CantidadOrdenar
                        Encuentra = True
                        Exit For
                    End If
                Next
                If Encuentra Then
                    Trans.Add(OrdenDet)
                    If Not OrdenDet.Save Then
                        Trans.Rollback()
                        Return False
                    End If
                End If
            Next

            Return True
        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    'Public Function Cancelar(ByRef trans As INTEGRA.MEAT.HelperClasses.Transaction) As Boolean 

    'End Function

    'Public Function Guardar() As Boolean

    'End Function

    'Public Function Guardar(ByRef trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
    '    Try
    '        trans.Add(Me.Entity)
    '        Return Me.Entity.Save
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '        'RaiseEvent MensajeError(Me, "No se pudo Guardar la Recepcion de Orden de Compra")
    '        Return False
    '    End Try
    'End Function

    Public Function Obtener(ByVal Codigo As Integer) As Boolean
        Try
            Return Me.Entity.FetchUsingPK(Codigo)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    'Public Function Obtener2(ByVal Folio As String) As Boolean
    '    Try
    '        Return Me.Entity.FetchUsingPK(Folio)
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Return False
    '    End Try
    'End Function

    Public Function ObtenerEntidad() As EC.RecepcionOrdenCompraEntity
        Return Me.Entity
    End Function

    Public Sub LeerEntidad(ByVal Entidad As EC.RecepcionOrdenCompraEntity)
        Me.Entity = Entidad
    End Sub

#End Region

#Region "Constructores"

    Sub New()
        Me.Entity = New EC.RecepcionOrdenCompraEntity
    End Sub

    Sub New(ByVal Entidad As EC.RecepcionOrdenCompraEntity)
        Me.Entity = Entidad
    End Sub

    Sub New(ByVal Codigo As Long)
        Me.Entity = New EC.RecepcionOrdenCompraEntity(Codigo)
    End Sub

#End Region

End Class

Public Class RecepcionOrdenCompraCollectionClass
    Inherits ColleccionBase(Of EC.RecepcionOrdenCompraEntity, CC.RecepcionOrdenCompraCollection, RecepcionOrdenCompraClass)

    Private coleccion As New CC.RecepcionOrdenCompraCollection
    Private RecepOrdenCompraCollection As New CC.RecepcionOrdenCompraCollection
    Private Filtro As ORM.PredicateExpression
    Public Event MensajeError As MensajeErrorHandler
    Public sort As New ORM.SortExpression(New ORM.SortClause(HC.RecepcionOrdenCompraFields.FechaRecepcion, SD.LLBLGen.Pro.ORMSupportClasses.SortOperator.Ascending))


    Public Function Obtener(ByVal fcCondicion As CondicionEnum) As Integer
        Try
            Me.ClearItems()

            If Not fcCondicion = CondicionEnum.TODOS Then
                RecepOrdenCompraCollection.GetMulti(HC.RecepcionOrdenCompraFields.Estatus = fcCondicion)
            Else
                RecepOrdenCompraCollection.GetMulti(Nothing)
            End If

            For Each RecepcionEntity As EC.RecepcionOrdenCompraEntity In RecepOrdenCompraCollection
                Dim RecepcionOrdenCompra As New RecepcionOrdenCompraClass
                RecepcionOrdenCompra.LeerEntidad(RecepcionEntity)
                Me.Add(RecepcionOrdenCompra)
            Next

            Return Count
        Catch ex As Exception
            RaiseEvent MensajeError(Me, ex.Message)
            Return -1
        End Try
    End Function

    Public Function Obtener(ByVal IdProveedor As Integer, Optional ByVal NoFactura As String = "", Optional ByVal fcCondicion As CondicionEnum = CondicionEnum.TODOS) As Integer
        Try
            Me.Clear()
            coleccion = New CC.RecepcionOrdenCompraCollection
            Filtro = New ORM.PredicateExpression
            Dim rel As New ORM.RelationCollection
            rel.Add(EC.RecepcionOrdenCompraEntity.Relations.OrdenCompraEntityUsingIdOrdenCompra, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)
            Filtro.Add(HC.OrdenCompraFields.IdProveedor = IdProveedor)

            If Not NoFactura = "" Then
                Filtro.Add(HC.RecepcionOrdenCompraFields.NoFactura = NoFactura)
            Else
                Filtro.Add(HC.RecepcionOrdenCompraFields.Facturada = False)
            End If
            If fcCondicion <> CondicionEnum.TODOS Then
                Filtro.Add(HC.RecepcionOrdenCompraFields.Estatus = fcCondicion)
            End If
            coleccion.GetMulti(Filtro, rel)
            'Rellenar()

            'For Each RecepcionEntity As EC.RecepcionOrdenCompraEntity In coleccion
            '    Dim RecepcionOrdenCompra As New RecepcionOrdenCompraClass
            '    RecepcionOrdenCompra.LeerEntidad(RecepcionEntity)
            '    Me.Add(RecepcionOrdenCompra)
            'Next

            For Each RecepcionEntity As EC.RecepcionOrdenCompraEntity In coleccion
                Dim RecepcionOrdenCompra As New RecepcionOrdenCompraClass
                RecepcionOrdenCompra.LeerEntidad(RecepcionEntity)
                Me.Add(RecepcionOrdenCompra)
            Next

            Return Me.Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
                MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

    Public Function Obtener(ByVal IdProveedor As Integer, ByVal Anio As Integer) As Integer
        Try
            Me.Clear()
            coleccion = New CC.RecepcionOrdenCompraCollection
            Filtro = New ORM.PredicateExpression
            Dim rel As New ORM.RelationCollection
            rel.Add(EC.RecepcionOrdenCompraEntity.Relations.OrdenCompraEntityUsingIdOrdenCompra, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)
            Filtro.Add(HC.OrdenCompraFields.IdProveedor = IdProveedor)
            Dim datei As New Date(Anio, 1, 1, 0, 0, 0)
            Dim datef As New Date(Anio, 12, 31, 23, 59, 59)
            Filtro.Add(HC.RecepcionOrdenCompraFields.FechaRecepcion >= datei And HC.RecepcionOrdenCompraFields.FechaRecepcion <= datef)
            'If Not NoFactura = "" Then
            '    Filtro.Add(HC.RecepcionOrdenCompraFields.NoFactura = NoFactura)
            'Else
            '    Filtro.Add(HC.RecepcionOrdenCompraFields.Facturada = False)
            'End If
            'If fcCondicion <> CondicionEnum.TODOS Then
            '    Filtro.Add(HC.RecepcionOrdenCompraFields.Estatus = fcCondicion)
            'End If
            coleccion.GetMulti(Filtro, rel)
            'Rellenar()

            'For Each RecepcionEntity As EC.RecepcionOrdenCompraEntity In coleccion
            '    Dim RecepcionOrdenCompra As New RecepcionOrdenCompraClass
            '    RecepcionOrdenCompra.LeerEntidad(RecepcionEntity)
            '    Me.Add(RecepcionOrdenCompra)
            'Next

            For Each RecepcionEntity As EC.RecepcionOrdenCompraEntity In coleccion
                Dim RecepcionOrdenCompra As New RecepcionOrdenCompraClass
                RecepcionOrdenCompra.LeerEntidad(RecepcionEntity)
                Me.Add(RecepcionOrdenCompra)
            Next

            Return Me.Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
                MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

    Public Function Obtener(ByVal filtro As ORM.PredicateExpression) As Integer
        Try
            Me.Clear()
            'coleccion = New CC.RecepcionOrdenCompraCollection
            'Filtro = New ORM.PredicateExpression
            'Dim rel As New ORM.RelationCollection
            'rel.Add(EC.RecepcionOrdenCompraEntity.Relations.OrdenCompraEntityUsingIdOrdenCompra, SD.LLBLGen.Pro.ORMSupportClasses.JoinHint.Inner)
            'Filtro.Add(HC.OrdenCompraFields.IdProveedor = IdProveedor)

            'If Not NoFactura = "" Then
            '    Filtro.Add(HC.RecepcionOrdenCompraFields.NoFactura = NoFactura)
            'Else
            '    Filtro.Add(HC.RecepcionOrdenCompraFields.Facturada = False)
            'End If
            'If fcCondicion <> CondicionEnum.TODOS Then
            '    Filtro.Add(HC.RecepcionOrdenCompraFields.Estatus = fcCondicion)
            'End If
            coleccion.GetMulti(filtro, 0, sort)
            'Rellenar()

            'For Each RecepcionEntity As EC.RecepcionOrdenCompraEntity In coleccion
            '    Dim RecepcionOrdenCompra As New RecepcionOrdenCompraClass
            '    RecepcionOrdenCompra.LeerEntidad(RecepcionEntity)
            '    Me.Add(RecepcionOrdenCompra)
            'Next

            For Each RecepcionEntity As EC.RecepcionOrdenCompraEntity In coleccion
                Dim RecepcionOrdenCompra As New RecepcionOrdenCompraClass
                RecepcionOrdenCompra.LeerEntidad(RecepcionEntity)
                Me.Add(RecepcionOrdenCompra)
            Next

            Return Me.Count
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
                MsgBox("Ocurrió un Error", MsgBoxStyle.Critical, "Error")
#End If
        End Try
    End Function

    Public Function Reporte(ByVal Empresa As String, ByVal Usuario As String) As crRecepCompraTck
        ''CrRecepcionOrdenCompra

        Dim Reportes As New crRecepCompraTck
        Dim Titulo As String = "Recepcion de Compra"
        Dim Directas As Boolean = True
        Dim cont As Double = 0

        Dim Ds As New DataSet
        Dim DsCab As New DSRecepcionOrdenCompra.RecepcionOrdenCabDataTable
        Dim DsDet As New DSRecepcionOrdenCompra.RecepcionOrdenDetDataTable
        Dim ImporteTotal As Decimal = 0
        Dim style As Drawing.FontStyle = Drawing.FontStyle.Bold
        For Each Recep As RecepcionOrdenCompraClass In Me
            Dim RecepRow As DSRecepcionOrdenCompra.RecepcionOrdenCabRow = DsCab.AddRecepcionOrdenCabRow(Recep.ObtenerEntidad.Sucursal.Plaza.Descripcion, _
            Recep.ObtenerEntidad.Sucursal.Descripcion, Recep.FolioRecepcionOrdenCompra, Recep.IdOrdenCompra, Recep.ObtenerEntidad.OrdenCompra.Proveedor.RazonSocial, Recep.ObtenerEntidad.Almacen.Descripcion, Recep.NumFactura, Recep.FechaRecepcion)

            For Each DetRecep As RecepcionOrdenCompraDetClass In Recep.Detalles
                DsDet.AddRecepcionOrdenDetRow(RecepRow, DetRecep.IdProducto, DetRecep.Producto.Descripcion, DetRecep.Cantidad, 0, DetRecep.Cantidad, DetRecep.Costo, DetRecep.Descuento, DetRecep.IVA, DetRecep.Total)
                cont = cont + DetRecep.Cantidad
                ImporteTotal = ImporteTotal + DetRecep.Total
            Next

            If Not Recep.EsDirecta Then
                Directas = False
            End If
            ''DsDet.AddRecepcionOrdenDetRow(RecepRow, "", "", "", "", "", Nothing, Nothing, Nothing, Nothing)
            '' DsDet.AddRecepcionOrdenDetRow(RecepRow, "TOTAL", "", "", "", String.Format("{0:N4}", Double.Parse(cont)), Nothing, Nothing, Nothing, ImporteTotal)

        Next

        Ds.Tables.Add(DsCab)
        Ds.Tables.Add(DsDet)

        If Directas Then
            Titulo = "Recepcion de Compra"
        End If

        Reportes.SetDataSource(Ds)
        Reportes.SetParameterValue(0, Empresa)
        Reportes.SetParameterValue(1, Usuario)
        Reportes.SetParameterValue(2, " Compras Generales\Recepcion de Compra")
        Reportes.SetParameterValue(3, Titulo)
        Dim reg As RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\INTEGRALAB\", True)
        Reportes.PrintOptions.PrinterName = reg.GetValue("NombreImpresora", Nothing).ToString
        Reportes.PrintToPrinter(1, False, 0, 0)

#If DEBUG Then
        '.....prueba del ticket visualmente
        Dim Prev As New PreVisualizarForm
        Prev.Reporte = Reportes
        Prev.Text = "TICKET"
        Prev.Show()
#End If
    End Function


End Class