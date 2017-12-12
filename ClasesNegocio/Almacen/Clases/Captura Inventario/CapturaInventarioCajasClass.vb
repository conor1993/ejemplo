Imports OC = SD.LLBLGen.Pro.ORMSupportClasses
Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses

Public Class CapturaInventarioCajasClass
    Inherits ClassBase(Of EC.MscloteCortesDetComparacionEntity)

#Region "Declaracioens"
    Private m_Producto As EC.MsccatProductosEntity
    Private m_Corte As EC.MsccatProductosEntity
#End Region

#Region "Constructores"
    Sub New()
        MyBase.New()
    End Sub

    Sub New(ByVal entidad As EC.MscloteCortesDetComparacionEntity)
        MyBase.New(entidad)
    End Sub
#End Region

#Region "Propiedades"
    <ComponentModel.DisplayName("Lote Corte")> _
    Public Property Lote() As String
        Get
            Return Entity.LoteCorte
        End Get
        Set(ByVal value As String)
            Entity.LoteCorte = value
        End Set
    End Property

    <ComponentModel.DisplayName("Folio Etiqueta")> _
    Public Property FolioEtiqueta() As String
        Get
            Return Entity.IdFolioEtiqueta
        End Get
        Set(ByVal value As String)
            Entity.IdFolioEtiqueta = value
        End Set
    End Property

    <ComponentModel.DisplayName("Código Corte")> _
    Public Property IdCorte() As Integer
        Get
            Return Entity.IdCorte
        End Get
        Set(ByVal value As Integer)
            Entity.IdCorte = value
        End Set
    End Property

    Public ReadOnly Property Corte() As String
        Get
            If m_Corte Is Nothing Then
                m_Corte = New EC.MsccatProductosEntity(IdCorte)
            ElseIf Not m_Corte.IdProducto = IdCorte Then
                m_Corte.FetchUsingPK(IdCorte)
            End If

            Return m_Corte.Descripcion
        End Get
    End Property

    <ComponentModel.DisplayName("Código Producto")> _
    Public Property IdProducto() As Integer
        Get
            Return Entity.IdProducto
        End Get
        Set(ByVal value As Integer)
            Entity.IdProducto = value
        End Set
    End Property

    Public ReadOnly Property Producto() As String
        Get
            Return Entity.MsccatProductos.Descripcion
        End Get
    End Property

    Public Property Piezas() As Integer
        Get
            Return Decimal.ToInt32(Entity.CantPzas)
        End Get
        Set(ByVal value As Integer)
            Entity.CantPzas = value
        End Set
    End Property

    Public Property Kilos() As Decimal
        Get
            Return Entity.CantKgrs
        End Get
        Set(ByVal value As Decimal)
            Entity.CantKgrs = value
        End Set
    End Property

    <ComponentModel.DisplayName("Folio Movimiento"), ComponentModel.DataObjectField(False, False, False, 10)> _
    Public Property IdFolioMovimiento() As String
        Get
            Return Entity.IdFolioMovimiento
        End Get
        Set(ByVal value As String)
            Entity.IdFolioMovimiento = value
        End Set
    End Property

    <ComponentModel.DisplayName("Código Barra"), ComponentModel.DataObjectField(False, False, False, 100)> _
    Public Property CodigoBarra() As String
        Get
            Return Entity.CodigoBarra
        End Get
        Set(ByVal value As String)
            Entity.CodigoBarra = value
        End Set
    End Property

    <ComponentModel.DisplayName("Folio Etiqueta Referencia"), ComponentModel.DataObjectField(False, False, True, 14)> _
    Public Property IdFolioEtiquetaReferencia() As String
        Get
            Return Entity.IdFolioEtiquetaReferencia
        End Get
        Set(ByVal value As String)
            Entity.IdFolioEtiquetaReferencia = value
        End Set
    End Property

    Public Property Grados() As Integer
        Get
            Return Entity.Grados
        End Get
        Set(ByVal value As Integer)
            Entity.Grados = value
        End Set
    End Property

    <ComponentModel.DisplayName("Código Cliente")> _
    Public Property IdCliente() As Integer
        Get
            Return Entity.IdCliente
        End Get
        Set(ByVal value As Integer)
            Entity.IdCliente = value
        End Set
    End Property

    <ComponentModel.DisplayName("Fecha Captura")> _
    Public Property FechaCaptura() As Date
        Get
            Return Entity.FechaCaptura
        End Get
        Set(ByVal value As Date)
            Entity.FechaCaptura = value
        End Set
    End Property

    <ComponentModel.DisplayName("Fecha Movimiento")> _
    Public Property FechaMovimeinto() As Date
        Get
            Return Entity.FechaMovimiento
        End Get
        Set(ByVal value As Date)
            Entity.FechaMovimiento = value
        End Set
    End Property

    Public Property CodigoAlmacen() As Nullable(Of Integer)
        Get
            Return Entity.IdAlmacen
        End Get
        Set(ByVal value As Nullable(Of Integer))
            Entity.IdAlmacen = value
        End Set
    End Property
#End Region

#Region "Metodos"

#End Region

#Region "Eventos"

#End Region
End Class