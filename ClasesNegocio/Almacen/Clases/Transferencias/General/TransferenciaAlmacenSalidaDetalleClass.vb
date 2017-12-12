Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class TransferenciaAlmacenSalidaDetalleClass
    Inherits ClassBase(Of EC.MinvTransferenciaAlmacenSalidaDetalleEntity)

#Region "Miembros"
    ''' <summary>
    ''' Almacena los datos de la transferencia salida
    ''' a la que pertenese este detalle
    ''' </summary>
    ''' <remarks></remarks>
    Private m_TransferenciaAlmacenSalida As TransferenciaAlmacenSalidaClass

    ''' <summary>
    ''' Almacena los datos del producto que sera transferido
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
    ''' Inicializa la clase con los valores que contiene
    ''' la entity ingresada
    ''' </summary>
    ''' <param name="entidad"></param>
    ''' <remarks></remarks>
    Sub New(ByVal entidad As EC.MinvTransferenciaAlmacenSalidaDetalleEntity)
        MyBase.New(entidad)
    End Sub

    ''' <summary>
    ''' Inicializa la clase y obtiene el detalle de la transferencia
    ''' con el folio de transferencia, código del producto y el lote ingresados
    ''' </summary>
    ''' <param name="folioTransferenciaAlmacenSalida">Folio de la transferencia salida</param>
    ''' <param name="idProducto">Código del producto</param>
    ''' <param name="lote">Lote del que salio el producto en caso de que el producto no se manje 
    ''' en lotes ingresar ""</param>
    ''' <remarks></remarks>
    Sub New(ByVal folioTransferenciaAlmacenSalida As String, ByVal idProducto As Integer, ByVal lote As String)
        MyBase.New(New EC.MinvTransferenciaAlmacenSalidaDetalleEntity(folioTransferenciaAlmacenSalida, idProducto, lote))
    End Sub
#End Region

#Region "Propiedades"
    ''' <summary>
    ''' Obtiene o establece el folio de transferencia al que pertenese
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FolioTransferencia() As String
        Get
            Return Entity.FolioTransferencia
        End Get
        Set(ByVal value As String)
            Entity.FolioTransferencia = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece la transferencia salida a la que pertenese
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property TransferenciaAlmacenSalida() As TransferenciaAlmacenSalidaClass
        Get
            If Me.m_TransferenciaAlmacenSalida Is Nothing Then
                Me.m_TransferenciaAlmacenSalida = New TransferenciaAlmacenSalidaClass(Entity.MinvTransferenciaAlmacenSalida)
            ElseIf Not Me.m_TransferenciaAlmacenSalida.FolioTransferencia.Trim = Me.FolioTransferencia.Trim Then
                Me.m_TransferenciaAlmacenSalida.Entidad = Entity.MinvTransferenciaAlmacenSalida
            End If

            Return Me.m_TransferenciaAlmacenSalida
        End Get
        Set(ByVal value As TransferenciaAlmacenSalidaClass)
            Me.m_TransferenciaAlmacenSalida = value

            If value Is Nothing Then
                Entity.MinvTransferenciaAlmacenSalida = Nothing
            Else
                Entity.MinvTransferenciaAlmacenSalida = value.Entidad
            End If
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el código del producto que se le dara salida del almacén
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property IdProducto() As Integer
        Get
            Return Entity.IdProducto
        End Get
        Set(ByVal value As Integer)
            Entity.IdProducto = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el producto al que se le dara salida del almacén
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Producto() As ProductoClass
        Get
            If m_Producto Is Nothing Then
                m_Producto = New ProductoClass(Entity.Producto)
            ElseIf Not m_Producto.Codigo = IdProducto Then
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
    ''' Obtiene o establece el lote del que saldra el producto en caso que se maneje en lotes
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Lote() As String
        Get
            Return Entity.Lote
        End Get
        Set(ByVal value As String)
            Entity.Lote = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece la cantidad de producto que se la dara salida
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Cantidad() As Decimal
        Get
            Return Entity.Cantidad
        End Get
        Set(ByVal value As Decimal)
            Entity.Cantidad = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el costo total de la salida
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Importe() As Decimal
        Get
            Return Entity.Importe
        End Get
        Set(ByVal value As Decimal)
            Entity.Importe = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el costo por unidad del producto
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property CostoUnitario() As Decimal
        Get
            Return Entity.CostoUnitario
        End Get
        Set(ByVal value As Decimal)
            Entity.CostoUnitario = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el iva total del producto
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property IVA() As Decimal
        Get
            Return Entity.Iva.Value
        End Get
        Set(ByVal value As Decimal)
            Entity.Iva = value
        End Set
    End Property

    Public Property FechaCaducidad() As Nullable(Of Date)
        Get
            Return Entity.FechaCaducidad
        End Get
        Set(ByVal value As Nullable(Of Date))
            Entity.FechaCaducidad = value
        End Set
    End Property
#End Region

#Region "Metodos"

#End Region

#Region "Enumeradores"

#End Region
End Class