Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class TransferenciaAlmacenEntradaDetalleClass
    Inherits ClassBase(Of EC.MinvTransferenciaAlmacenEntradaDetalleEntity)

#Region "Miembros"
    ''' <summary>
    ''' Almacena los datos de la transferencia de entrada
    ''' </summary>
    ''' <remarks></remarks>
    Private m_TransferenciaEntrada As TransferenciaAlmacenEntradaClass

    ''' <summary>
    ''' Almacena los datos del producto que se le dara entrada
    ''' </summary>
    ''' <remarks></remarks>
    Private m_Producto As ProductoClass
#End Region

#Region "Constructores"
    ''' <summary>
    ''' Inicializa la clase con los valores por default
    ''' </summary>
    ''' <remarks></remarks>
    Sub New()
        MyBase.New()
    End Sub

    ''' <summary>
    ''' Inicializa la clase con los valores de la entity ingresada
    ''' </summary>
    ''' <param name="entidad">Entity con los datos del detalle de entrada de una transferencia</param>
    ''' <remarks></remarks>
    Sub New(ByVal entidad As EC.MinvTransferenciaAlmacenEntradaDetalleEntity)
        MyBase.New(entidad)
    End Sub

    ''' <summary>
    ''' Inicializa la clase y obtiene el detalle de la transferencia entrada 
    ''' con el folio de transferencia de entrada, código del producto y lote ingresados
    ''' </summary>
    ''' <param name="folioTransferenciaEntrada">Folio de transferencia entrada</param>
    ''' <param name="idProducto">Código del producto</param>
    ''' <param name="lote">Lote en el que se dio entrada al producto en caso de que el producto no
    ''' maneje lotes ingrese ""</param>
    ''' <remarks></remarks>
    Sub New(ByVal folioTransferenciaEntrada As String, ByVal idProducto As Integer, ByVal lote As String)
        MyBase.New(New EC.MinvTransferenciaAlmacenEntradaDetalleEntity(folioTransferenciaEntrada, idProducto, lote))
    End Sub
#End Region

#Region "Propiedades"
    ''' <summary>
    ''' Obtiene o establece el folio de transferencia de entrada
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DataObjectField(True, False, False, 12), _
    ComponentModel.Description("Obtiene o establece el folio de transferencia de entrada")> _
    Public Property FolioTransferencia() As String
        Get
            Return Entity.FolioTransferencia
        End Get
        Set(ByVal value As String)
            Entity.FolioTransferencia = value.Trim
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece la transferencia de entrada a la que pertenese el detalle
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property TransferenciaEntrada() As TransferenciaAlmacenEntradaClass
        Get
            If m_TransferenciaEntrada Is Nothing Then
                m_TransferenciaEntrada = New TransferenciaAlmacenEntradaClass(Entity.MinvTransferenciaAlmacenEntrada)
            ElseIf Not FolioTransferencia.Trim = m_TransferenciaEntrada.FolioTranferencia Then
                m_TransferenciaEntrada.Entidad = Entity.MinvTransferenciaAlmacenEntrada
            End If

            Return m_TransferenciaEntrada
        End Get
        Set(ByVal value As TransferenciaAlmacenEntradaClass)
            m_TransferenciaEntrada = value

            If value Is Nothing Then
                Entity.MinvTransferenciaAlmacenEntrada = Nothing
            Else
                Entity.MinvTransferenciaAlmacenEntrada = value.Entidad
            End If
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el código del producto que se le dara entrada
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DataObjectField(True, False, False), _
    ComponentModel.Description("Obtiene o establece el código del producto que se le dara entrada")> _
    Public Property IdProducto() As Integer
        Get
            Return Entity.IdProducto
        End Get
        Set(ByVal value As Integer)
            Entity.IdProducto = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el producto que se le dara entrada
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.Description("Obtiene o establece el producto que se le dara entrada"), _
    ComponentModel.DataObjectField(False, False, False)> _
    Public Property Producto() As ProductoClass
        Get
            If m_Producto Is Nothing Then
                m_Producto = New ProductoClass(Entity.Producto)
            ElseIf Not m_Producto.Codigo And IdProducto Then
                m_Producto.LeerEntidad(Entity.Producto)
            End If

            Return m_Producto
        End Get
        Set(ByVal value As ProductoClass)
            m_Producto = value

            If value Is Nothing Then
                Entity.Producto = Nothing
            Else
                Entity.Producto = value.ObtenerEntidad
            End If
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el lote al que entraran los productos en caso de que se maneje por lotes
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DataObjectField(True, False, False, 15), _
    ComponentModel.Description("Obtiene o establece el lote al que entraran los productos en caso de que se maneje por lotes")> _
    Public Property Lote() As String
        Get
            Return Entity.Lote
        End Get
        Set(ByVal value As String)
            Entity.Lote = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o estalbece la cantidad de producto que se le dara entrada
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DataObjectField(False, False, False), _
    ComponentModel.Description("Obtiene o estalbece la cantidad de producto que se le dara entrada")> _
    Public Property Cantidad() As Decimal
        Get
            Return Entity.Cantidad
        End Get
        Set(ByVal value As Decimal)
            Entity.Cantidad = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el costo total de los productos que entraran
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DataObjectField(False, False, False), _
    ComponentModel.Description("Obtiene o establece el costo total de los productos que entraran")> _
    Public Property Importe() As Decimal
        Get
            Return Entity.Importe
        End Get
        Set(ByVal value As Decimal)
            Entity.Importe = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el costo unitario del producto que entrara
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DataObjectField(False, False, False), _
    ComponentModel.Description("Obtiene o establece el costo unitario del producto que entrara")> _
    Public Property CostoUnitario() As Decimal
        Get
            Return Entity.CostoUnitario
        End Get
        Set(ByVal value As Decimal)
            Entity.CostoUnitario = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el iva total del producto que entrara
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <ComponentModel.DataObjectField(False, False, False), _
    ComponentModel.Description("Obtiene o establece el iva total del producto que entrara")> _
        Public Property Iva() As Decimal
        Get
            Return Entity.Iva
        End Get
        Set(ByVal value As Decimal)
            Entity.Iva = value
        End Set
    End Property
#End Region

#Region "Metodos"

#End Region

#Region "Enumeradores"

#End Region
End Class