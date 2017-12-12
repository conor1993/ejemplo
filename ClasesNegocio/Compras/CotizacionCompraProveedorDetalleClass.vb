Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses

Public Class CotizacionCompraProveedorDetalleClass
    Inherits ClassBase(Of EC.McomCotizacionCompraProveedorDetalleEntity)

#Region "Miembros"

    Private _Producto As ProductoGeneralClass
    Private _Moneda As TipoMonedaClass
    Private _CotizacionCompra As CotizacionCompraClass

    Public Enum EstatusCotizacionProveedorDetalle As Byte
        VIGENTE
        ORDENADO
        EMITIDO
    End Enum

#End Region

#Region "Propiedades"
    ''' <summary>
    ''' Obtiene o establece la cotización de compra
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Cotización Compra")> _
    Public ReadOnly Property CotizacionCompra() As CotizacionCompraClass
        Get
            If _CotizacionCompra Is Nothing Then
                _CotizacionCompra = New CotizacionCompraClass(Entity.CotizacionCompra)
            ElseIf Not _CotizacionCompra.IdCotizacion = Entity.IdCotizacion Then
                _CotizacionCompra.LeerEntidad(Entity.CotizacionCompra)
            End If
            Return _CotizacionCompra
        End Get
    End Property

    Public ReadOnly Property FolioCotizacion() As String
        Get
            Return _CotizacionCompra.FolioCotizacion
        End Get
    End Property

    Public Property IdCotizacion() As Integer
        Get
            Return Entity.IdCotizacion
        End Get
        Set(ByVal value As Integer)
            Entity.IdCotizacion = IdCotizacion
        End Set
    End Property

    Public Property IdProveedor() As Integer
        Get
            Return Entity.IdProveedor
        End Get
        Set(ByVal value As Integer)
            Entity.IdProveedor = value
        End Set
    End Property

    Public Property IdSolicitud() As Integer
        Get
            Return Entity.IdSolicitud
        End Get
        Set(ByVal value As Integer)
            Entity.IdSolicitud = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el codigo del producto
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
    ''' Obtiene o establece el producto del detalle
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
    ''' Obtiene la unidad de medida del producto
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Unidad de Medida")> _
    Public ReadOnly Property Unidad() As String
        Get
            Return Producto.UnidadMedida.DescCorta
        End Get
    End Property

    ''' <summary>
    ''' Obtiene o establece la cantidad
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

    Public Property IdMoneda() As Integer
        Get
            Return Entidad.IdMoneda
        End Get
        Set(ByVal value As Integer)
            Entidad.IdMoneda = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece la moneda
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Moneda() As TipoMonedaClass
        Get
            If _Moneda Is Nothing OrElse _Moneda.Codigo <> Me.IdMoneda Then
                _Moneda = New TipoMonedaClass(Entidad.TipoMoneda)
            End If
            Return _Moneda
        End Get
    End Property

    ''' <summary>
    ''' Obtiene o establece el tipo de cambio
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Tipo de Cambio")> _
    Public Property TipoCambio() As Decimal
        Get
            Return Entidad.TipoCambio
        End Get
        Set(ByVal value As Decimal)
            Entidad.TipoCambio = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el precio del producto
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Precio() As Decimal
        Get
            Return Entity.Precio
        End Get
        Set(ByVal value As Decimal)
            Entity.Precio = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el descuento que se le ara al producto
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Descuento() As Decimal
        Get
            Return Entity.Descuento
        End Get
        Set(ByVal value As Decimal)
            Entity.Descuento = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el importe total
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Importe() As Decimal
        Get
            Return Entity.Importe
        End Get
        Set(ByVal value As Decimal)
            Entity.Importe = value
        End Set
    End Property

    Public Property Estatus() As EstatusCotizacionProveedorDetalle
        Get
            Return CType(Entity.Estatus, EstatusCotizacionProveedorDetalle)
        End Get
        Set(ByVal value As EstatusCotizacionProveedorDetalle)
            Entity.Estatus = CType(value, Byte)
        End Set
    End Property

#End Region

#Region "Metodos"

    Public Shadows Function Guardar(ByVal Trans As HC.Transaction) As Boolean
        Try
            Trans.Add(Entity)

            Return Entity.Save
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

#End Region

#Region "Constructores"
    Sub New()
        Entity = New EC.McomCotizacionCompraProveedorDetalleEntity
    End Sub

    Sub New(ByVal IdCotizacion As Integer, ByVal IdProveedor As Integer, ByVal IdProducto As Integer)
        Entity = New EC.McomCotizacionCompraProveedorDetalleEntity(IdCotizacion, IdProveedor, IdProducto)
    End Sub

    Sub New(ByVal Entidad As EC.McomCotizacionCompraProveedorDetalleEntity)
        Entity = Entidad
    End Sub
#End Region

End Class

Public Class CotizacionCompraProveedorDetalleCollectionClass
    Inherits ColleccionBase(Of EC.McomCotizacionCompraProveedorDetalleEntity, CC.McomCotizacionCompraProveedorDetalleCollection, CotizacionCompraProveedorDetalleClass)

    Sub New()

    End Sub

    Sub New(ByVal Coleccion As CC.McomCotizacionCompraProveedorDetalleCollection)
        MyBase.New(Coleccion)
    End Sub

End Class