Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class DevolucionProductosClass
    Inherits ClassBase(Of EC.DevolucionProductosEntity)

    Dim _Producto As ProductosClass
    Dim _Cliente As ClientesIntroductoresClass

#Region "Constructores"

    Sub New()
        Entity = New EC.DevolucionProductosEntity
    End Sub

    Sub New(ByVal Entidad As EC.DevolucionProductosEntity)
        Entity = Entidad
    End Sub

    Sub New(ByVal Folio As String)
        Entity = New EC.DevolucionProductosEntity(Folio)
    End Sub
#End Region

#Region "Propiedades"

    Public Property Folio() As String
        Get
            Return Entity.Folio
        End Get
        Set(ByVal value As String)
            Entity.Folio = value
        End Set
    End Property

    Public Property IdProducto() As Integer
        Get
            Return Entity.IdProducto
        End Get
        Set(ByVal value As Integer)
            Entity.IdProducto = value
        End Set
    End Property

    Public Property Piezas() As Decimal
        Get
            Return Entity.Piezas
        End Get
        Set(ByVal value As Decimal)
            Entity.Piezas = value
        End Set
    End Property

    Public Property Kilos() As Decimal
        Get
            Return Entity.Kilos
        End Get
        Set(ByVal value As Decimal)
            Entity.Kilos = value
        End Set
    End Property

    Public Property FolioEmbarque() As String
        Get
            Return Entity.Embarque
        End Get
        Set(ByVal value As String)
            Entity.Embarque = value
        End Set
    End Property

    Public Property IdCliente() As Integer
        Get
            Return Entity.IdCliente
        End Get
        Set(ByVal value As Integer)
            Entity.IdCliente = value
        End Set
    End Property

    Public Property UtilVenta() As Boolean
        Get
            Return Entity.UtilparaVenta
        End Get
        Set(ByVal value As Boolean)
            Entity.UtilparaVenta = value
        End Set
    End Property

    Public Property Producto() As ProductosClass
        Get
            If _Producto Is Nothing Then
                _Producto = New ProductosClass(Entity.MsccatProductos)
            End If
            Return _Producto
        End Get
        Set(ByVal value As ProductosClass)
            _Producto = value
            If value Is Nothing Then
                Entity.MsccatProductos = Nothing
            Else
                Entity.MsccatProductos = value.ObtenerEntidad
            End If
        End Set
    End Property

    Public ReadOnly Property NomProducto() As String
        Get
            Return Producto.Descripcion
        End Get
    End Property

    Public Property Cliente() As ClientesIntroductoresClass
        Get
            If _Cliente Is Nothing Then
                _Cliente = New ClientesIntroductoresClass(Entity.MfacCatClientes)
            End If
            Return _Cliente
        End Get
        Set(ByVal value As ClientesIntroductoresClass)
            _Cliente = value
            If value Is Nothing Then
                Entity.MfacCatClientes = Nothing
            Else
                Entity.MfacCatClientes = value.ObtenerEntidad
            End If
        End Set
    End Property

    Public ReadOnly Property NomCliente() As String
        Get
            Return Cliente.Nombre
        End Get
    End Property
#End Region

#Region "Metodos"

    Public Function Obtener(ByVal Folio As String) As Boolean
        Try
            Return Entity.FetchUsingPK(Folio)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Public Overrides Function Guardar(Optional ByVal Trans As Integralab.ORM.HelperClasses.Transaction = Nothing) As Boolean
        Try
            If Entity.IsNew Then
                Dim Coleccion As New CC.DevolucionProductosCollection
                Dim Aux As String
                Dim Aux2 As Integer

                Coleccion.GetMulti(Nothing, 1, Nothing)

                If Coleccion.Count > 0 Then
                    Dim ValorMax As String = Coleccion.GetScalar(Integralab.ORM.DevolucionProductosFieldIndex.Folio, _
                                            SD.LLBLGen.Pro.ORMSupportClasses.AggregateFunction.Max)

                    If Not IsDBNull(ValorMax) Then
                        Aux = Microsoft.VisualBasic.Right(ValorMax, 7)
                        Aux2 = CInt(Aux) + 1
                        Entity.Folio = "D" & Microsoft.VisualBasic.Right("0000000" & Aux2, 7)
                    Else
                        Entity.Folio = "D0000001"
                    End If
                Else
                    Entity.Folio = "D0000001"
                End If

                If Not IsNothing(Trans) Then
                    Trans.Add(Entity)
                End If

                Return Entity.Save
            Else
                If Not IsNothing(Trans) Then
                    Trans.Add(Entity)
                End If
                Return Entity.Save
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
#End Region
End Class


Public Class DevolucionProductosCollectionClass
    Inherits ColleccionBase(Of EC.DevolucionProductosEntity, CC.DevolucionProductosCollection, DevolucionProductosClass)

End Class