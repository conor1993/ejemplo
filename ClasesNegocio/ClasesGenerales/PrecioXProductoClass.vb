Imports CC = Integralab.ORM.CollectionClasses
Imports EC = Integralab.ORM.EntityClasses
Imports HC = Integralab.ORM.HelperClasses


Public Class PrecioXProductoClass
    Inherits ClassBase(Of EC.CatPrexProdEntity)


#Region "Contructores"

    Sub New(ByVal Entidad As EC.CatPrexProdEntity)
        Entity = Entidad
    End Sub

    Sub New()
        Entity = New EC.CatPrexProdEntity
    End Sub

    Sub New(ByVal IdCliente As Integer, ByVal IdDestino As Integer, ByVal IdProducto As Integer)
        Entity = New EC.CatPrexProdEntity(IdCliente, IdDestino, IdProducto)
    End Sub
#End Region

#Region "Propiedades"
    Public Property IdCliente() As Integer
        Get
            Return Entity.CveCliente
        End Get
        Set(ByVal value As Integer)
            Entity.CveCliente = value
        End Set
    End Property

    Public Property IdDestino() As Integer
        Get
            Return Entity.CveDestino
        End Get
        Set(ByVal value As Integer)
            Entity.CveDestino = value
        End Set
    End Property

    Public Property IdProducto() As Integer
        Get
            Return Entity.CveProdRas
        End Get
        Set(ByVal value As Integer)
            Entity.CveProdRas = value
        End Set
    End Property

    Public Property Precio() As Decimal
        Get
            Return Entity.PrecioxKgr
        End Get
        Set(ByVal value As Decimal)
            Entity.PrecioxKgr = value
        End Set
    End Property

#End Region

#Region "Metodos"
    Public Function Obtener(ByVal IdCliente As Integer, ByVal IdDestino As Integer, ByVal IdProducto As Integer) As Boolean
        Try
            Return Entity.FetchUsingPK(IdCliente, IdDestino, IdProducto)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
#End Region
End Class

Public Class PrecioXproductoCollectionClass
    Inherits ColleccionBase(Of EC.CatPrexProdEntity, CC.CatPrexProdCollection, PrecioXProductoClass)

    Public Overloads Function obtener(ByVal IdCliente As Integer) As Integer
        Try
            coleccion.GetMulti(HC.CatPrexProdFields.CveCliente = IdCliente)
            Rellenar()
            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function
End Class

Public Class PrecioXcorteClass
    Inherits ClassBase(Of EC.CatPrexCortEntity)
    Dim Producto As EC.MsccatProductosEntity

#Region "Constructores"
    Sub New()
        Entity = New EC.CatPrexCortEntity
    End Sub

    Sub New(ByVal Entidad As EC.CatPrexCortEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal IdCliente As Integer, ByVal IdDestino As Integer, ByVal IdPrecorte As Integer, ByVal IdCorte As Integer)
        Entity = New EC.CatPrexCortEntity(IdCliente, IdDestino, IdCorte)
    End Sub
#End Region

#Region "Propiedades"

    Public Property IdCliente() As Integer
        Get
            Return Entity.CveCliente
        End Get
        Set(ByVal value As Integer)
            Entity.CveCliente = value
        End Set
    End Property

    Public Property IdDestino() As Integer
        Get
            Return Entity.CveDestino
        End Get
        Set(ByVal value As Integer)
            Entity.CveDestino = value
        End Set
    End Property

    Public Property IdPrecorte() As Integer
        Get
            Return Entity.CveCorte
        End Get
        Set(ByVal value As Integer)
            Entity.CveCorte = value
        End Set
    End Property

    Public Property IdCorte() As Integer
        Get
            Return Entity.CveSubCorte
        End Get
        Set(ByVal value As Integer)
            Entity.CveSubCorte = value
        End Set
    End Property

    Public Property Precio() As Decimal
        Get
            Return Entity.PrecioxKgr
        End Get
        Set(ByVal value As Decimal)
            Entity.PrecioxKgr = value
        End Set
    End Property

    Public ReadOnly Property NomPreCorte() As String
        Get
            If IsNothing(Producto) Then
                Producto = New EC.MsccatProductosEntity(IdPrecorte)
            ElseIf Not IdPrecorte = Producto.IdProducto Then
                Producto.FetchUsingPK(IdPrecorte)
            End If
            Return Producto.Descripcion
        End Get
    End Property

#End Region

#Region "Metodos"
    Public Function Obtener(ByVal IdCliente As Integer, ByVal IdDestino As Integer, ByVal IdPrecorte As Integer, ByVal IdCorte As Integer) As Boolean
        Try
            Return Entity.FetchUsingPK(IdCliente, IdDestino, IdCorte)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
#End Region
End Class

Public Class PrecioXCorteCollectiionClass
    Inherits ColleccionBase(Of EC.CatPrexCortEntity, CC.CatPrexCortCollection, PrecioXcorteClass)

    Public Overloads Function Obtener(ByVal IdCliente As Integer) As Integer
        Try
            coleccion.GetMulti(HC.CatPrexCortFields.CveCliente = IdCliente)
            Rellenar()
            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function
End Class