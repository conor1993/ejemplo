Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = Integralab.ORM.HelperClasses

Public Class RecepcionOrdenCompraDetClass
    Inherits ClassBase(Of EC.McomRecepcionOrdenCompraDetEntity)

#Region "Miembros Privados"

    Private _RecepcionOrdenCompra As RecepcionOrdenCompraClass
    Private _OrdenCompra As OrdenCompraClass
    Private _Producto As ProductoGeneralClass
    Private _OrdenCompraDetalle As OrdenCompraDetalleClass

#End Region

#Region "Constructores"

    Sub New()
        Me.Entity = New EC.McomRecepcionOrdenCompraDetEntity
    End Sub

    Sub New(ByVal Entidad As EC.McomRecepcionOrdenCompraDetEntity)
        Me.Entity = Entidad
    End Sub

    Sub New(ByVal Codigo As Long)
        Me.Entity = New EC.McomRecepcionOrdenCompraDetEntity
    End Sub

#End Region

#Region "Propiedades"

    Public ReadOnly Property FolioRecepcionOrdenCompra() As String
        Get
            Return RecepcionOrdenCompra.FolioRecepcionOrdenCompra
        End Get
    End Property

    Public Property IdRecepcionOrdenCompra() As Integer
        Get
            Return Me.Entity.IdRecepcionOrdenCompra
        End Get
        Set(ByVal value As Integer)
            Me.Entity.IdRecepcionOrdenCompra = value
        End Set
    End Property

    Public Property IdProducto() As Integer
        Get
            Return Me.Entity.IdProducto
        End Get
        Set(ByVal value As Integer)
            Me.Entity.IdProducto = value
        End Set
    End Property

    Public ReadOnly Property RecepcionOrdenCompra() As RecepcionOrdenCompraClass
        Get
            If _RecepcionOrdenCompra Is Nothing OrElse _RecepcionOrdenCompra.IdRecepcionOrdenCompra <> Me.IdRecepcionOrdenCompra Then
                _RecepcionOrdenCompra = New RecepcionOrdenCompraClass(Me.Entity.RecepcionOrdenCompra)
            End If
            Return _RecepcionOrdenCompra
        End Get
    End Property

    Public ReadOnly Property OrdenCompra() As OrdenCompraClass
        Get
            Return RecepcionOrdenCompra.OrdenCompra
        End Get
    End Property

    Public Property Cantidad() As Decimal
        Get
            Return Me.Entity.Cantidad
        End Get
        Set(ByVal value As Decimal)
            Me.Entity.Cantidad = value
        End Set
    End Property

    Public Property Costo() As Decimal
        Get
            Return Entity.Costo
        End Get
        Set(ByVal value As Decimal)
            Entity.Costo = value
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
            Return Me.Entity.Iva
        End Get
        Set(ByVal value As Decimal)
            Me.Entity.Iva = value
        End Set
    End Property

    Public Property Ieps() As Decimal
        Get
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

    Public ReadOnly Property Producto() As ProductoGeneralClass
        Get
            If _Producto Is Nothing Then
                _Producto = New ProductoGeneralClass(Me.Entity.Producto)
            End If
            Return _Producto
        End Get
    End Property

    Public ReadOnly Property OrdenCompraDetalle() As OrdenCompraDetalleClass
        Get
            If _OrdenCompraDetalle Is Nothing OrElse _OrdenCompraDetalle.IdOrdenCompra <> Me.RecepcionOrdenCompra.IdOrdenCompra _
            AndAlso _OrdenCompraDetalle.IdProducto <> Me.IdProducto Then
                Dim ColDet As New CC.OrdenCompraDetalleCollection()

                ColDet.GetMulti(HC.OrdenCompraDetalleFields.IdOrdenCompra = Me.RecepcionOrdenCompra.IdOrdenCompra And HC.OrdenCompraDetalleFields.IdProducto = Me.IdProducto)
                _OrdenCompraDetalle = New OrdenCompraDetalleClass(ColDet(0))
            End If
            Return _OrdenCompraDetalle
        End Get
    End Property

#End Region

#Region "Metodos"

    Public Enum CamposOrdenDetalleEnum
        CANTIDAD_SOLICITADA
        CANTIDAD_ORDENADA
        CANTIDAD_RECIBIDA
        CANTIDAD_PENDIENTE
    End Enum

    Public Function ObtenerCant(ByVal Campo As CamposOrdenDetalleEnum) As Decimal
        Select Case Campo
            Case CamposOrdenDetalleEnum.CANTIDAD_ORDENADA
                ObtenerCant = OrdenCompraDetalle.CantidadOrdenada
            Case CamposOrdenDetalleEnum.CANTIDAD_PENDIENTE
                ObtenerCant = OrdenCompraDetalle.CantPendiente
            Case CamposOrdenDetalleEnum.CANTIDAD_RECIBIDA
                ObtenerCant = OrdenCompraDetalle.CantRecibida
            Case CamposOrdenDetalleEnum.CANTIDAD_SOLICITADA
                ObtenerCant = OrdenCompraDetalle.CantidadSolicitada
        End Select
    End Function

    Public Shadows Function Guardar(ByRef Trans As Integralab.ORM.HelperClasses.Transaction) As Boolean
        If Me.Entity.IsNew Then
            Trans.Add(Me.Entity)
            Return Me.Entity.Save
        End If
        Return False
    End Function

#End Region

End Class

Public Class RecepcionOrdenCompraDetCollectionClass
    Inherits ColleccionBase(Of EC.McomRecepcionOrdenCompraDetEntity, CC.McomRecepcionOrdenCompraDetCollection, RecepcionOrdenCompraDetClass)

    Public Overloads Function Obtener(ByVal IdRecepcionOrdenCompra As Integer) As Integer
        Return MyBase.Obtener(HC.McomRecepcionOrdenCompraDetFields.IdRecepcionOrdenCompra = IdRecepcionOrdenCompra)
    End Function

End Class
