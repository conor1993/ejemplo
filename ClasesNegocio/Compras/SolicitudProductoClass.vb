Imports Ec = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports SPR = Integralab.ORM.StoredProcedureCallerClasses.RetrievalProcedures
'Imports System.Windows.Forms

Public Class SolicitudProductoClass
    Inherits ClassBase(Of Ec.SolicitudProductoEntity)

#Region "Miembros"

    Private _Sucursal As SucursalClass = Nothing
    Private _Usuario As UsuarioClass = Nothing
    Private _UsuarioCan As UsuarioClass = Nothing
    Private _Detalle As SolicitudProductoDetalleCollectionClass = Nothing

    Public Enum EstatusSolicitud As Byte
        CANCELADA = 0
        VIGENTE = 1
        EMITIDA = 2
        PARCIALMENTE_EMITIDA = 3
    End Enum

#End Region

#Region "Constructores"

    Sub New()
        Entidad = New Ec.SolicitudProductoEntity
        Me.ObservacionesCancelacion = ""
    End Sub

    Sub New(ByVal Entidad As Ec.SolicitudProductoEntity)
        Me.Entidad = Entidad
    End Sub
    Sub New(ByVal IdSolicitud As Integer)
        Me.Entidad = New Ec.SolicitudProductoEntity(IdSolicitud)
    End Sub
    Sub New(ByVal IdSucursal As Integer, ByVal Para As String, ByVal EntregarA As String, ByVal EntregarEn As String, ByVal Observaciones As String, ByVal FechaSolicitud As Date, ByVal FechaSurtir As Date)
        Me.IdSucursal = IdSucursal
        Me.SolicitadoPor = Para
        Me.EntregarA = EntregarA
        Me.EntregarEn = EntregarEn
        Me.Observaciones = Observaciones
        Me.FechaSolicitud = FechaSolicitud
        Me.FechaSurtir = FechaSurtir
        Me.ObservacionesCancelacion = ""
    End Sub

#End Region

#Region "Propiedades"

    Public ReadOnly Property IdSolicitud() As Integer
        Get
            Return Me.Entity.IdSolicitud
        End Get
    End Property

    ''' <summary>
    ''' Obtiene el folio de la solicitud
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property FolioSolicitud() As String
        Get
            Return Entidad.FolioSolicitud
        End Get
    End Property

    Public Property IdSucursal() As Integer
        Get
            Return Entidad.IdSucursal
        End Get
        Set(ByVal value As Integer)
            Entidad.IdSucursal = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece la sucursal de la solicitud
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Sucursal() As SucursalClass
        Get
            If _Sucursal Is Nothing OrElse _Sucursal.Codigo <> Me.IdSucursal Then
                _Sucursal = New SucursalClass(Entidad.Sucursal)
            End If
            Return _Sucursal
        End Get
    End Property

    Public ReadOnly Property Plaza() As PlazaClass
        Get
            Return Sucursal.Plaza
        End Get
    End Property

    ''' <summary>
    ''' Obtiene o establece las observaciones de la solicitud
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Observaciones() As String
        Get
            Return Entidad.Observaciones
        End Get
        Set(ByVal value As String)
            Entidad.Observaciones = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece a quien se le entregara la solicitud
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property EntregarA() As String
        Get
            Return Entidad.EntregarA
        End Get
        Set(ByVal value As String)
            Entidad.EntregarA = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece en donde se entregara la solicitud
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property EntregarEn() As String
        Get
            Return Entidad.EntregarEn
        End Get
        Set(ByVal value As String)
            Entidad.EntregarEn = value
        End Set
    End Property

    Public Property SolicitadoPor() As String
        Get
            Return Entity.SolicitadoPor
        End Get
        Set(ByVal value As String)
            Entity.SolicitadoPor = value
        End Set
    End Property

    Public Property IdUsuarioAlta() As Integer
        Get
            Return Entidad.IdUsuarioAlta
        End Get
        Set(ByVal value As Integer)
            Entidad.IdUsuarioAlta = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el usuario de alta 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property UsuarioAlta() As UsuarioClass
        Get
            If _Usuario Is Nothing OrElse _Usuario.Codigo <> Me.IdUsuarioAlta Then
                _Usuario = New UsuarioClass(Entidad.IdUsuarioAlta)
            End If
            Return _Usuario
        End Get
    End Property

    Public Property IdUsuarioCancelacion() As Nullable(Of Integer)
        Get
            Return Entidad.IdUsuarioCancelacion
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Entidad.IdUsuarioCancelacion = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el usuario de cancelación
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property UsuarioCancelacion() As UsuarioClass
        Get
            If _UsuarioCan Is Nothing OrElse Me.IdUsuarioCancelacion.HasValue AndAlso _UsuarioCan.Codigo <> Me.IdUsuarioCancelacion.Value Then
                _UsuarioCan = New UsuarioClass(Entidad.IdUsuarioCancelacion)
            End If
            Return _UsuarioCan
        End Get
    End Property

    ''' <summary>
    ''' Obtiene la fecha de alta
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Fecha de Alta")> _
    Public Property FechaSolicitud() As Date
        Get
            Return Entidad.FechaSolicitud
        End Get
        Set(ByVal value As Date)
            Entidad.FechaSolicitud = value
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

    ''' <summary>
    ''' Obtiene o establece la fecha a surtir
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Fecha a Surtir")> _
    Public Property FechaSurtir() As Date
        Get
            Return Entity.FechaSurtir
        End Get
        Set(ByVal value As Date)
            Entity.FechaSurtir = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene la fecha de cancelación
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FechaCancelacion() As Nullable(Of Date)
        Get
            Return Entidad.FechaCancelacion
        End Get
        Set(ByVal value As Nullable(Of Date))
            Entidad.FechaCaptura = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece las obserbaciones de cancelación
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Obserbaciones de Cancelación")> _
    Public Property ObservacionesCancelacion() As String
        Get
            Return Entidad.ObserbacionesCancelacion
        End Get
        Set(ByVal value As String)
            Entidad.ObserbacionesCancelacion = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el detalle de la solicitud
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Detalle() As SolicitudProductoDetalleCollectionClass
        Get
            If _Detalle Is Nothing Then
                _Detalle = New SolicitudProductoDetalleCollectionClass()
                _Detalle.RellenarMe(Entidad.SolicitudProductoDetalle)
            End If
            Return _Detalle
        End Get
    End Property

    Public Property Estatus() As EstatusSolicitud
        Get
            Return CType(Entidad.Estatus, EstatusSolicitud)
        End Get
        Set(ByVal value As EstatusSolicitud)
            Entidad.Estatus = CType(value, Short)
        End Set
    End Property

    Public ReadOnly Property DescripcionEstatus() As String
        Get
            Return Me.Estatus.ToString.Replace("_"c, " "c)
        End Get
    End Property

#End Region

#Region "Metodos Dinamicos"

    Public Sub Validar()
        If Me.Sucursal.Entidad.IsNew Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.GENERAL, 11)
        ElseIf Me.SolicitadoPor.Trim = "" Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SOLICITUD_PRODUCTOS, 1)
        ElseIf Me.Detalle.Count = 0 Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SOLICITUD_PRODUCTOS, 3)
        ElseIf Me.Detalle.Count = 1 AndAlso Not Me.Detalle(0).Entidad.IsDirty AndAlso Me.Detalle(0).Entidad.IsNew Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SOLICITUD_PRODUCTOS, 3)
        Else
            For Each SolicitudDetalle As SolicitudProductoDetalleClass In Me.Detalle
                SolicitudDetalle.Validar()
            Next
        End If
    End Sub

    Friend Sub Borrar(ByVal Trans As HC.Transaction)
        Dim Cotizaciones As New CC.McomCotizacionCompraCollection
        Dim Relacion As New OC.RelationCollection
        Dim Ordenes As New CC.OrdenCompraCollection
        Dim RelacionOrdenCompra As New OC.RelationCollection

        Trans.Add(Cotizaciones)
        Trans.Add(Ordenes)

        Relacion.Add(Ec.McomCotizacionCompraEntity.Relations.McomCotizacionCompraProveedorDetalleEntityUsingIdCotizacion)
        Relacion.Add(Ec.McomCotizacionCompraProveedorDetalleEntity.Relations.SolicitudProductoDetalleEntityUsingIdSolicitudIdProducto)
        Relacion.Add(Ec.SolicitudProductoDetalleEntity.Relations.SolicitudProductoEntityUsingIdSolicitud)

        Cotizaciones.GetMulti(HC.SolicitudProductoFields.IdSolicitud = Me.IdSolicitud And HC.McomCotizacionCompraFields.Estatus = EstatusDatos.VIGENTE, 0, Nothing, Relacion)

        If Cotizaciones.Count > 0 Then
            Dim FoliosCotizaciones As New List(Of String)

            For Each Cotizacion As Ec.McomCotizacionCompraEntity In Cotizaciones
                FoliosCotizaciones.Add(Cotizacion.FolioCotizacion)
            Next
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SOLICITUD_PRODUCTOS, 0, "(" & String.Join(", ", FoliosCotizaciones.ToArray) & ")")
        End If
        RelacionOrdenCompra.Add(Ec.OrdenCompraEntity.Relations.OrdenCompraDetalleEntityUsingIdOrdenCompra)
        Ordenes.GetMulti(HC.OrdenCompraDetalleFields.IdSolicitud = Me.IdSolicitud And HC.OrdenCompraFields.Estatus <> EstatusOrdenCompra.CANCELADO And HC.OrdenCompraFields.Estatus <> EstatusOrdenCompra.FINIQUITADO, 0, Nothing, RelacionOrdenCompra)

        If Ordenes.Count > 0 Then
            Dim FoliosOrdenes As New List(Of String)

            For Each Orden As Ec.OrdenCompraEntity In Ordenes
                FoliosOrdenes.Add(Orden.FolioOrdenCompra)
            Next
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SOLICITUD_PRODUCTOS, 7, "(" & String.Join(", ", FoliosOrdenes.ToArray) & ")")
        End If

        Me.Estatus = EstatusSolicitud.CANCELADA
        Me.FechaCancelacion = Now

        Trans.Add(Me.Entidad)
        Me.Entidad.Save()

        For Each SolicitudDetalle As SolicitudProductoDetalleClass In Me.Detalle
            SolicitudDetalle.Estatus = SolicitudProductoDetalleClass.EstatusSolicitudDetalle.CANCELADA
            SolicitudDetalle.Guardar(Trans)
        Next
    End Sub

    Friend Sub Guardar(ByRef Trans As HC.Transaction)
        Trans.Add(Me.Entity)

        If Me.Entity.Save Then
            For Each SolicitudDetalle As SolicitudProductoDetalleClass In Me.Detalle
                SolicitudDetalle.Estatus = SolicitudProductoDetalleClass.EstatusSolicitudDetalle.VIGENTE
                SolicitudDetalle.IdSolicitud = Me.IdSolicitud
                SolicitudDetalle.Guardar(Trans)
            Next
        End If
    End Sub

    Public Overrides Function ToString() As String
        Return Me.FolioSolicitud
    End Function

#End Region

#Region "Metodos Estaticos"

    Public Shared Function Obtener(ByVal IdSolicitud As Integer) As SolicitudProductoClass
        Dim Solicitud As New SolicitudProductoClass

        If Solicitud.Entity.FetchUsingPK(IdSolicitud) Then
            Return Solicitud
        End If
        Return Nothing
    End Function

#End Region

End Class

Public Class SolicitudProductoDetalleClass
    Inherits ClassBase(Of Ec.SolicitudProductoDetalleEntity)

#Region "Miembros"

    Private _Solicitud As SolicitudProductoClass
    Private _Producto As ProductoGeneralClass

    Public Enum EstatusSolicitudDetalle As Byte
        CANCELADA = 0
        VIGENTE = 1
        EMITIDA = 2
    End Enum

#End Region

#Region "Constructores"

    Sub New()
        Entity = New Ec.SolicitudProductoDetalleEntity
        Entity.Cantidad = 1
        Entity.Urgente = False
        Entity.Observaciones = ""
    End Sub

    Sub New(ByVal Entidad As Ec.SolicitudProductoDetalleEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal IdProducto As Integer, ByVal Cantidad As Decimal, ByVal Urgente As Boolean, ByVal Observaciones As String)
        Me.IdProducto = IdProducto
        Me.Cantidad = Cantidad
        Me.Urgente = Urgente
        Me.Observaciones = Observaciones
    End Sub

#End Region

#Region "Propiedades"

    Public ReadOnly Property FolioSolicitud() As String
        Get
            Return Me.SolicitudProducto.FolioSolicitud
        End Get
    End Property

    Public ReadOnly Property EntregarA() As String
        Get
            Return Me.SolicitudProducto.EntregarA
        End Get
    End Property


    Public Property IdSolicitud() As Integer
        Get
            Return Me.Entity.IdSolicitud
        End Get
        Set(ByVal value As Integer)
            Me.Entity.IdSolicitud = value
        End Set
    End Property

    Public ReadOnly Property FechaSolicitud() As Date
        Get
            Return Me.SolicitudProducto.FechaSolicitud
        End Get
    End Property

    ''' <summary>
    ''' Obtiene o establece la solicitud de productos
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Solicitud de Producto")> _
    Public ReadOnly Property SolicitudProducto() As SolicitudProductoClass
        Get
            If _Solicitud Is Nothing Then
                _Solicitud = New SolicitudProductoClass(Entity.SolicitudProducto)
            ElseIf _Solicitud.IdSolicitud <> Me.IdSolicitud Then
                _Solicitud.LeerEntidad(Entity.SolicitudProducto)
            End If
            Return _Solicitud
        End Get
    End Property

    ''' <summary>
    ''' Obtiene el código del producto
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Código")> _
    Public Property IdProducto() As Integer
        Get
            Return Entity.IdProducto
        End Get
        Set(ByVal value As Integer)
            Entity.IdProducto = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el producto
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Producto() As ProductoGeneralClass
        Get
            If _Producto Is Nothing Then
                _Producto = New ProductoGeneralClass(Entity.Producto)
            ElseIf Not _Producto.Codigo = IdProducto Then
                _Producto.LeerEntidad(Entity.Producto)
            End If
            Return _Producto
        End Get
    End Property

    ''' <summary>
    ''' Obtiene o establece la cantidad de productos
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Cantidad() As Decimal
        Get
            Return Entity.Cantidad
        End Get
        Set(ByVal value As Decimal)
            Entity.Cantidad = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece si es urgente
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Urgente() As Boolean
        Get
            Return Entity.Urgente
        End Get
        Set(ByVal value As Boolean)
            Entity.Urgente = value
        End Set
    End Property

    Public ReadOnly Property DescripcionUrgente() As String
        Get
            Return IIf(Urgente, "SI", "NO")
        End Get
    End Property

    ''' <summary>
    ''' Obtiene o establece las observaciones
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Observaciones() As String
        Get
            Return Entity.Observaciones
        End Get
        Set(ByVal value As String)
            Entity.Observaciones = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene la unidad de medida del producto
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Unidad de Medida")> _
    Public ReadOnly Property UnidadMedida() As String
        Get
            Return Producto.UnidadMedida.DescCorta
        End Get
    End Property

    Public Property Estatus() As EstatusSolicitudDetalle
        Get
            Return Entity.Estatus
        End Get
        Set(ByVal value As EstatusSolicitudDetalle)
            Entity.Estatus = value
        End Set
    End Property

#End Region

#Region "Metodos Dinamicos"

    Public Sub Validar()
        If Me.Producto.IsNew Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SOLICITUD_PRODUCTOS, 6)
        ElseIf Me.Cantidad = 0 Then
            Throw New BusinessException(CategoriaEnumException.VALIDACION, ModuloEnum.SOLICITUD_PRODUCTOS, 4)
        End If
    End Sub

    Public Sub Guardar(ByRef Trans As HC.Transaction)
        Trans.Add(Entity)
        Entity.Save()
    End Sub

#End Region

#Region "Metodos Estaticos"

    Public Shared Function Obtener(ByVal IdSolicitud As Integer, ByVal IdProducto As Integer) As SolicitudProductoDetalleClass
        Dim SolicitudDetalle As New SolicitudProductoDetalleClass

        If SolicitudDetalle.Entity.FetchUsingPK(IdSolicitud, IdProducto) Then
            Return SolicitudDetalle
        End If
        Return Nothing
    End Function

#End Region

End Class

Public Class SolicitudProductoCollectionClass
    Inherits ColleccionBase(Of Ec.SolicitudProductoEntity, CC.SolicitudProductoCollection, SolicitudProductoClass)

#Region "Metodos Dinamicos"

    Public Overloads Function Contains(ByVal IdSolicitud As Integer) As Boolean
        For Each Solicitud As SolicitudProductoClass In Me.Items
            If Solicitud.IdSolicitud = IdSolicitud Then
                Return True
            End If
        Next
        Return False
    End Function

#End Region

End Class

Public Class SolicitudProductoDetalleCollectionClass
    Inherits ColleccionBase(Of Ec.SolicitudProductoDetalleEntity, CC.SolicitudProductoDetalleCollection, SolicitudProductoDetalleClass)

End Class