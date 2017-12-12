Imports System.Windows.Forms
Imports SPA = IntegraLab.ORM.StoredProcedureCallerClasses.ActionProcedures
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports HC = IntegraLab.ORM.HelperClasses
Imports CC = IntegraLab.ORM.CollectionClasses
Imports EC = IntegraLab.ORM.EntityClasses
Imports System.Data.SqlClient

Public Class CapturaInventarioClass
#Region "Miembros"
    Private m_IdProducto As Integer
    Private m_IdProductoAnt As Integer = -1
    Private m_Producto As String
    Private m_Piezas As Integer
    Private m_Kilos As Decimal
    Private m_Costo As Decimal
    Private m_IdAlmacen As Integer
    Private m_Almacen As String
    Private m_Caja As Boolean
    Private m_Viceras As Boolean
    Private m_Canal As Boolean
#End Region

#Region "Constructor"
    Sub New()

    End Sub

    Sub New(ByVal idProducto As Integer, ByVal producto As String, ByVal idAlmacen As Integer, ByVal almacen As String, ByVal piezas As Integer, ByVal kilos As Decimal, ByVal costo As Decimal, ByVal caja As Boolean, ByVal viceras As Boolean, ByVal canal As Boolean)
        With Me
            .IdProducto = idProducto
            .IdAlmacen = idAlmacen
            .Piezas = piezas
            .Kilos = kilos
            .Costo = costo
            .Producto = producto
            .Almacen = almacen
            .EsCorte = caja
            .EsProducto = viceras
            .Canal = canal
        End With
    End Sub
#End Region

#Region "Propiedades"
    Public Property IdProducto() As Integer
        Get
            Return m_IdProducto
        End Get
        Set(ByVal value As Integer)
            m_IdProducto = value
        End Set
    End Property

    Public Property Producto() As String
        Get
            If Not Me.IdProducto = Me.m_IdProductoAnt Then
                ObtenerValoresPord()
                Me.m_IdProductoAnt = Me.IdProducto
            End If

            Return m_Producto
        End Get
        Private Set(ByVal value As String)
            m_Producto = value
        End Set
    End Property

    Public Property Piezas() As Integer
        Get
            Return m_Piezas
        End Get
        Set(ByVal value As Integer)
            m_Piezas = value
        End Set
    End Property

    Public Property Kilos() As Decimal
        Get
            Return m_Kilos
        End Get
        Set(ByVal value As Decimal)
            m_Kilos = value
        End Set
    End Property

    Public Property Costo() As Decimal
        Get
            Return m_Costo
        End Get
        Set(ByVal value As Decimal)
            m_Costo = value
        End Set
    End Property

    Public Property IdAlmacen() As Integer
        Get
            Return m_IdAlmacen
        End Get
        Set(ByVal value As Integer)
            m_IdAlmacen = value
        End Set
    End Property

    Public Property Almacen() As String
        Get
            Return m_Almacen
        End Get
        Private Set(ByVal value As String)
            m_Almacen = value
        End Set
    End Property

    Public Property EsCorte() As Boolean
        Get
            If Not Me.IdProducto = Me.m_IdProductoAnt Then
                ObtenerValoresPord()
            End If

            Return m_Caja
        End Get
        Set(ByVal value As Boolean)
            m_Caja = value
        End Set
    End Property

    Public Property EsProducto() As Boolean
        Get
            If Not Me.IdProducto = Me.m_IdProductoAnt Then
                ObtenerValoresPord()
            End If

            Return m_Viceras
        End Get
        Set(ByVal value As Boolean)
            m_Viceras = value
        End Set
    End Property

    Public Property Canal() As Boolean
        Get
            If Not Me.IdProducto = Me.m_IdProductoAnt Then
                ObtenerValoresPord()
            End If

            Return m_Canal
        End Get
        Set(ByVal value As Boolean)
            m_Canal = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Private Sub ObtenerValoresPord()
        Try
            Dim consulta As String = "SELECT [IdProducto],[Descripcion],Canal,Corte,SubProducto FROM [dbo].[MSCCatProductos] WHERE IdProducto=" & Me.IdProducto

            Using ad As New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(consulta, _
                        New SqlClient.SqlConnection(Integralab.ORM.HelperClasses.DbUtils.ActualConnectionString))), tb As New DataTable
                ad.SelectCommand.Connection.Open()
                ad.Fill(tb)
                ad.SelectCommand.Connection.Close()

                If tb.Rows.Count > 0 Then
                    Me.Producto = tb.Rows(0)("Descripcion")
                    Me.Canal = tb.Rows(0)("Canal")
                    Me.EsCorte = tb.Rows(0)("Corte")
                    Me.EsProducto = tb.Rows(0)("SubProducto")
                End If
            End Using
        Catch ex As Exception
#If CONFIG = "Debug" Then
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
#Else
            msgbox("Ocurrio un error al consultar los datos del producto",MsgBoxStyle.Critical,"Error")
#End If
        End Try
    End Sub
#End Region

#Region "Eventos"

#End Region
End Class