Public Class ProductoCargaInicialClass

    Private m_Clave As String

    Public Property Clave() As String
        Get
            Return m_Clave
        End Get
        Set(ByVal value As String)
            m_Clave = value
        End Set
    End Property

    Private m_Producto As String

    Public Property Producto() As String
        Get
            Return m_Producto
        End Get
        Set(ByVal value As String)
            m_Producto = value
        End Set
    End Property

    Private m_Linea As String

    Public Property Linea() As String
        Get
            Return m_Linea
        End Get
        Set(ByVal value As String)
            m_Linea = value
        End Set
    End Property

    Private m_Cantidad As Decimal

    Public Property Cantidad() As Decimal
        Get
            Return m_Cantidad
        End Get
        Set(ByVal value As Decimal)
            m_Cantidad = value
        End Set
    End Property

    Private m_UltimoCosto As Decimal

    Public Property UltimoCosto() As Decimal
        Get
            Return m_UltimoCosto
        End Get
        Set(ByVal value As Decimal)
            m_UltimoCosto = value
        End Set
    End Property

    Private m_CostoPromedio As Decimal

    Public Property CostoPromedio() As Decimal
        Get
            Return m_CostoPromedio
        End Get
        Set(ByVal value As Decimal)
            m_CostoPromedio = value
        End Set
    End Property

    Private m_Lote As String

    Public Property Lote() As String
        Get
            Return m_Lote
        End Get
        Set(ByVal value As String)
            m_Lote = value
        End Set
    End Property

    Private m_Caduca As Boolean

    Public Property Caduca() As Boolean
        Get
            Return m_Caduca
        End Get
        Set(ByVal value As Boolean)
            m_Caduca = value
        End Set
    End Property

    Private m_FechaCaducidad As System.Nullable(Of Date)

    Public Property Caducidad() As System.Nullable(Of Date)
        Get
            Return m_FechaCaducidad
        End Get
        Set(ByVal value As System.Nullable(Of Date))
            m_FechaCaducidad = value
        End Set
    End Property

    Private m_SeManejaPorLotes As Boolean

    Public Property SeManejaPorLotes() As Boolean
        Get
            Return m_SeManejaPorLotes
        End Get
        Set(ByVal value As Boolean)
            m_SeManejaPorLotes = value
        End Set
    End Property

    Private m_ProductoId As Integer

    Public Property ProductoId() As Integer
        Get
            Return m_ProductoId
        End Get
        Set(ByVal value As Integer)
            m_ProductoId = value
        End Set
    End Property

End Class