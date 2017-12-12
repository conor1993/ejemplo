Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class DocumentoClass
    Inherits EC.DocumentoEntity

#Region "Declaraciones"

    Public Enum DocumentoMedidaEnum As Byte
        Milimetros
        Pulgadas
        Pixeles
    End Enum

#End Region

#Region "Miembros Privados"

    Private _Detalles As DocumentoDetalleCollectionClass

#End Region

#Region "Constructores"

    Sub New()

    End Sub

    Sub New(ByVal IdDocumento As Integer)
        Me.FetchUsingPK(IdDocumento)
    End Sub

    Sub New(ByVal Entidad As EC.DocumentoEntity)
        If Not Entidad.IsNew Then Me.FetchUsingPK(Entidad.IdDocumento)

        If Entidad.IsDirty Then
            Me.Descripcion = Entidad.Descripcion
            Me.Medida = CType(Entidad.Medida, DocumentoMedidaEnum)
            Me.PaginaWidth = Entidad.PaginaWidth
            Me.PaginaHeight = Entidad.PaginaHeight
        End If
    End Sub

    Sub New(ByVal Descripcion As String, ByVal Medida As DocumentoMedidaEnum, ByVal PaginaWidth As Integer, ByVal PaginaHeght As Integer)
        Me.Descripcion = Descripcion
        Me.Medida = Medida
        Me.PaginaWidth = PaginaWidth
        Me.PaginaHeight = PaginaHeight
    End Sub

#End Region

#Region "Propiedades"

    Public Shadows Property Medida() As DocumentoMedidaEnum
        Get
            Return CType(MyBase.Medida, DocumentoMedidaEnum)
        End Get
        Set(ByVal value As DocumentoMedidaEnum)
            MyBase.Medida = CType(value, Byte)
        End Set
    End Property

    Public ReadOnly Property Detalles() As DocumentoDetalleCollectionClass
        Get
            If _Detalles Is Nothing Then
                _Detalles = New DocumentoDetalleCollectionClass(Me)

                For Each Detalle As EC.DocumentoDetalleEntity In Me.DocumentoDetalle
                    _Detalles.Add(Detalle)
                Next
            End If
            Return _Detalles
        End Get
    End Property

#End Region

#Region "Metodos Publicos"

#End Region

End Class

Public Class DocumentoCollectionClass
    Inherits ColleccionBase(Of DocumentoClass)

#Region "Metodos Publicos"

    Public Overloads Function IndexOf(ByVal IdDocumento As Integer) As Integer
        For i As Integer = 0 To Me.Items.Count - 1
            If IdDocumento = i Then
                Return i
            End If
        Next
        Return -1
    End Function

#End Region

End Class
