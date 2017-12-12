Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses

Public Class MSCRelacionProductosRastrosClass
    Inherits ClassBase(Of EC.MscrelacionProductosRastrosEntity)

#Region "Atributos"
    Dim m_Producto As ProductosClass
#End Region

#Region "Constructores"
    Sub New()

    End Sub

    Sub New(ByVal IdRastro As Integer, ByVal Producto As EC.MsccatProductosEntity, ByVal CodigoProductoRastro As String)
        Entity.CodRastro = IdRastro
        Entity.CodProducto = Producto.IdProducto
        Entity.Descripcion = Producto.Descripcion
        Entity.CodProductoRastro = CodigoProductoRastro
        m_Producto = New ProductosClass(Producto)
    End Sub
#End Region

#Region "Propiedades"
    Property IdRastro() As Integer
        Get
            Return Entity.CodRastro
        End Get
        Set(ByVal value As Integer)
            Entity.CodRastro = value
        End Set
    End Property

    Property IdProducto() As Integer
        Get
            Return Entity.CodProducto
        End Get
        Set(ByVal value As Integer)
            Dim producto As New ProductosClass(value)
            Entity.CodProducto = value
            Entity.Descripcion = producto.Descripcion
        End Set
    End Property

    Property DescripcionProducto() As String
        Get
            Return Entity.Descripcion
        End Get
        Set(ByVal value As String)
            Entity.Descripcion = value
        End Set
    End Property

    Property CodigoProductoRastro() As String
        Get
            Return Entity.CodProductoRastro
        End Get
        Set(ByVal value As String)
            Entity.CodProductoRastro = value
        End Set
    End Property

    Public Property Producto() As ProductosClass
        Get
            If Me.m_Producto Is Nothing Then
                m_Producto = New ProductosClass(Entity.MsccatProductos)
            ElseIf Not m_Producto.IdProducto = IdProducto Then
                m_Producto.Entidad = Entity.MsccatProductos
            End If

            Return m_Producto
        End Get
        Set(ByVal value As ProductosClass)
            m_Producto = value

            If value Is Nothing Then
                Entity.MsccatProductos = Nothing
            Else
                Entity.MsccatProductos = value.Entidad
                Entity.CodProducto = value.IdProducto
                Entity.Descripcion = value.Descripcion
            End If
        End Set
    End Property
#End Region

#Region "Metodos"
#End Region
End Class

Public Class MSCRelacionProductosRastrosCollectionClass
    Inherits ColleccionBase(Of EC.MscrelacionProductosRastrosEntity, CC.MscrelacionProductosRastrosCollection, MSCRelacionProductosRastrosClass)

#Region "Constructores"
    Sub New()

    End Sub

    Sub New(ByVal IdRastro As Integer)
        Me.Obtener(HC.MscrelacionProductosRastrosFields.CodRastro = IdRastro)
    End Sub
#End Region

#Region "Propiedades"

#End Region

#Region "Metodos"

#End Region
End Class
