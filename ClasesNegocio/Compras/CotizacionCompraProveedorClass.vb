Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses

Public Class CotizacionCompraProveedorClass
    Inherits ClassBase(Of EC.McomCotizacionCompraProveedorEntity)

#Region "Miembros"

    Private _CotizacionCompra As CotizacionCompraClass
    Private _Proveedor As ProveedorClass
    Private _Detalle As CotizacionCompraProveedorDetalleCollectionClass

    Public Enum EstatusCotizacionProveedor As Byte
        CADUCO
        VIGENTE
        PARCIALMENTE_EMITIDO
        EMITIDO
    End Enum

#End Region

#Region "Constructores"

    Sub New()
        Entidad.Importe = 0
        Entidad.Iva = 0
        Entidad.Total = 0
        Entidad.Descuento = 0
    End Sub

#End Region

#Region "Propiedades"

    ''' <summary>
    ''' Obtiene o establece la fecha de alta
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Fecha de Cotizacion")> _
    Public Property FechaCotizacion() As Date
        Get
            Return Entidad.FechaCotizacion
        End Get
        Set(ByVal value As Date)
            Entidad.FechaCotizacion = value
        End Set
    End Property

    Public Property FechaVigencia() As Date
        Get
            Return Entity.FechaVigencia
        End Get
        Set(ByVal value As Date)
            Entity.FechaVigencia = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el importe
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Importe() As Decimal
        Get
            Return Entidad.Importe
        End Get
        Set(ByVal value As Decimal)
            Entidad.Importe = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el descuento
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Descuento() As Decimal
        Get
            Return Entidad.Descuento
        End Get
        Set(ByVal value As Decimal)
            Entidad.Descuento = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el SubTotal
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property SubTotal() As Decimal
        Get
            Return Entidad.SubTotal
        End Get
        Set(ByVal value As Decimal)
            Entidad.SubTotal = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el iva
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property IVA() As Decimal
        Get
            Return Entidad.Iva
        End Get
        Set(ByVal value As Decimal)
            Entidad.Iva = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el total
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Total() As Decimal
        Get
            Return Entidad.Total
        End Get
        Set(ByVal value As Decimal)
            Entidad.Total = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece los dias de crédito
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DisplayName("Dias de Crédito")> _
    Public Property DiasCredito() As Integer
        Get
            Return Entidad.DiasCredito
        End Get
        Set(ByVal value As Integer)
            Entidad.DiasCredito = value
        End Set
    End Property

    Public Property Observaciones() As String
        Get
            Return Entity.Observaciones
        End Get
        Set(ByVal value As String)
            Entity.Observaciones = value
        End Set
    End Property

    Public ReadOnly Property EstatusDescripcion() As String
        Get
            Return Me.Estatus.ToString.Replace("_", "")
        End Get
    End Property

    Public ReadOnly Property Estatus() As EstatusCotizacionProveedor
        Get
            Dim TODO_EMITIDO As Boolean = True, ALGUNO As Boolean = False

            For Each Detalle As CotizacionCompraProveedorDetalleClass In Me.Detalle
                If Detalle.Estatus = CotizacionCompraProveedorDetalleClass.EstatusCotizacionProveedorDetalle.EMITIDO Then
                    ALGUNO = True

                    If Not TODO_EMITIDO Then Exit For
                Else
                    TODO_EMITIDO = False

                    If ALGUNO Then Exit For
                End If
            Next

            If ALGUNO Then
                If TODO_EMITIDO Then
                    Return EstatusCotizacionProveedor.EMITIDO
                Else
                    Return EstatusCotizacionProveedor.PARCIALMENTE_EMITIDO
                End If
            Else
                If Me.FechaVigencia.Date.Ticks < Now.Date.Ticks Then
                    Return EstatusCotizacionProveedor.CADUCO
                Else
                    Return EstatusCotizacionProveedor.VIGENTE
                End If
            End If
        End Get
    End Property

    Public ReadOnly Property CotizacionCompra() As CotizacionCompraClass
        Get
            Return Me._CotizacionCompra
        End Get
    End Property

    Public Property IdProveedor() As Integer
        Get
            Return Entidad.IdProveedor
        End Get
        Set(ByVal value As Integer)
            Entidad.IdProveedor = value
            Entidad.DiasCredito = Proveedor.DiasCredito
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el proveedor
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Proveedor() As ProveedorClass
        Get
            If _Proveedor Is Nothing OrElse _Proveedor.Codigo <> Me.IdProveedor Then
                _Proveedor = New ProveedorClass(Entidad.Proveedor)
            End If
            Return _Proveedor
        End Get
    End Property

    ''' <summary>
    ''' Obtiene o establece el detalle de la cotizacion de compra
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Detalle() As CotizacionCompraProveedorDetalleCollectionClass
        Get
            If _Detalle Is Nothing Then
                _Detalle = New CotizacionCompraProveedorDetalleCollectionClass(Entidad.McomCotizacionCompraProveedorDetalle)
            End If
            Return _Detalle
        End Get
    End Property

#End Region

#Region "Metodos Dinamicos"

    Public Sub EstablecerCabecero(ByRef CotizacionCompra As CotizacionCompraClass)
        Me.Entity.CotizacionCompra = CotizacionCompra.Entidad
        _CotizacionCompra = CotizacionCompra
    End Sub

#End Region

#Region "Metodos Estaticos"

#End Region

End Class

Public Class CotizacionCompraProveedorCollectionClass
    Inherits ColleccionBase(Of EC.McomCotizacionCompraProveedorEntity, CC.McomCotizacionCompraProveedorCollection, CotizacionCompraProveedorClass)

#Region "Miembros"

    Private _CotizacionCompra As CotizacionCompraClass

#End Region

#Region "Constructores"

    Sub New(ByRef CotizacionCompra As CotizacionCompraClass)
        _CotizacionCompra = CotizacionCompra
    End Sub

    Sub New(ByRef CotizacionCompra As CotizacionCompraClass, ByVal coleccion As CC.McomCotizacionCompraProveedorCollection)
        MyBase.New(coleccion)
        _CotizacionCompra = CotizacionCompra
    End Sub

#End Region

#Region "Propiedades"

    Public ReadOnly Property Cabecero() As CotizacionCompraClass
        Get
            Return _CotizacionCompra
        End Get
    End Property

#End Region

#Region "Metodos"

    Protected Overrides Function AddNewCore() As Object
        Dim CotizacionProveedor As CotizacionCompraProveedorClass = CType(MyBase.AddNewCore(), CotizacionCompraProveedorClass)

        CotizacionProveedor.EstablecerCabecero(_CotizacionCompra)
        Return CotizacionProveedor
    End Function

#End Region

End Class
