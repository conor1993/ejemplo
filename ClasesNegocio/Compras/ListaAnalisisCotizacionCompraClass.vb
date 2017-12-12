Imports EC = IntegraLab.ORM.EntityClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports TC = IntegraLab.ORM.TypedViewClasses

Public Class ListaAnalisisCotizacionCompraClass
    Implements IEntidad

#Region "Miembros"
    Public Event MensajeError(ByVal sender As Object, ByVal mensaje As String) Implements IEntidad.MensajeError
    Public Event Modificado(ByVal sender As Object, ByVal e As System.EventArgs) Implements IEntidad.Modificado
    Private Row As TC.ListaParaAnalizarCotizacionCompraRow
#End Region

#Region "Propiedades"

    Public Property IdCotizacion() As Integer
        Get
            Return Row.IdCotizacion
        End Get
        Set(ByVal value As Integer)
            Row.IdCotizacion = value
        End Set
    End Property

    Public Property CodigoProducto() As Integer
        Get
            Return Row.Codigo
        End Get
        Set(ByVal value As Integer)
            Row.Codigo = value
        End Set
    End Property

    Public Property Producto() As String
        Get
            Return Row.Producto
        End Get
        Set(ByVal value As String)
            Row.Producto = value
        End Set
    End Property

    Public Property Cantidad() As Decimal
        Get
            Return Row.Cantidad
        End Get
        Set(ByVal value As Decimal)
            Row.Cantidad = value
        End Set
    End Property

    Public Property CodigoProveedor() As Integer
        Get
            Return Row.CodigoProveedor
        End Get
        Set(ByVal value As Integer)
            Row.CodigoProveedor = value
        End Set
    End Property

    Public Property Proveedor() As String
        Get
            Return Row.Proveedor
        End Get
        Set(ByVal value As String)
            Row.Proveedor = value
        End Set
    End Property

    Public Property Precio() As Decimal
        Get
            Return Row.Precio
        End Get
        Set(ByVal value As Decimal)
            Row.Precio = value
        End Set
    End Property

    Public Property Descuento() As Decimal
        Get
            Return Row.Descuento
        End Get
        Set(ByVal value As Decimal)
            Row.Descuento = value
        End Set
    End Property

    Public ReadOnly Property Importe() As Decimal
        Get
            Return Row.Importe
        End Get
    End Property

    Private Property Estatus() As EstatusEnum Implements IEntidad.Estatus
        Get

        End Get
        Set(ByVal value As EstatusEnum)

        End Set
    End Property

    Public Property AplicaIva() As Boolean
        Get
            Return Row.AplicaIva
        End Get
        Set(ByVal value As Boolean)
            Row.AplicaIva = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Function Guardar() As Boolean

    End Function

    Public Function Borrar() As Boolean Implements IEntidad.Borrar

    End Function

    Private Function Obtener(ByVal Codigo As Integer) As Boolean Implements IEntidad.Obtener

    End Function

    Public Function ObtenerEntidad() As TC.ListaParaAnalizarCotizacionCompraRow
        Return Row
    End Function

    Public Sub LeerEntidad(ByVal Entidad As TC.ListaParaAnalizarCotizacionCompraRow)
        Row = Entidad
    End Sub
#End Region

#Region "Constructores"
    Sub New()

    End Sub

    Sub New(ByVal Entidad As TC.ListaParaAnalizarCotizacionCompraRow)
        Row = Entidad
    End Sub
#End Region

    Public Function Cancelar() As Boolean Implements IEntidad.Cancelar

    End Function

    Public Function Guardar1() As Boolean Implements IEntidad.Guardar

    End Function
End Class

Public Class ListaAnalisisCotizacionCompraCollectionClass
    Inherits CollectionClass(Of ListaAnalisisCotizacionCompraClass)

    Private Rows As New TC.ListaParaAnalizarCotizacionCompraTypedView

    Public Function Obtener(Optional ByVal PlazaId As Integer = -1, Optional ByVal SucursalId As Integer = -1) As Integer
        Try
            Dim Filtro As New OC.PredicateExpression

            If PlazaId > -1 Then
                Filtro.Add(HC.ListaParaAnalizarCotizacionCompraFields.Plaza = PlazaId)
            End If

            If SucursalId > -1 Then
                Filtro.Add(HC.ListaParaAnalizarCotizacionCompraFields.IdSucursal = SucursalId)
            End If

            Rows.Clear()

            Rows.Fill(0, Nothing, False, Filtro)

            Rellenar()

            Return Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return -1
        End Try
    End Function

#Region "Metodos de Relleno"
    Private Sub Rellenar()
        Clear()
        For Each row As TC.ListaParaAnalizarCotizacionCompraRow In Rows
            Add(New ListaAnalisisCotizacionCompraClass(row))
        Next
    End Sub
#End Region
End Class