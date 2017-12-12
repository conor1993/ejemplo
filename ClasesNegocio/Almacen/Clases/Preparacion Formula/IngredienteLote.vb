Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class IngredienteLote
    Inherits ClassBase(Of EC.DetPrepFormLoteEntity)

#Region "Campos"
    ''' <summary>
    ''' Contirne la plaza en la que se prepara la mezcla
    ''' </summary>
    Private m_Plaza As PlazaClass
    ''' <summary>
    ''' Contiene los datos de la mezcla que se esta preparando
    ''' </summary>
    Private m_MezclaPreparada As Mezcla
    ''' <summary>
    ''' Contiene el producto o ingrediente que contiene la mezcla
    ''' </summary>
    Private m_Producto As ProductoClass
    ''' <summary>
    ''' Contiene los datos del ingrediente con que se prepara la mezcla
    ''' </summary>
    Private m_IngredienteMezcla As Ingrediente
#End Region

#Region "Constructores"
    ''' <param name="entidad">Entity con los datos del lote del ingrediente usado para la preparacion de la mezcla</param>
    Sub New(ByVal entidad As EC.DetPrepFormLoteEntity)
        MyBase.New(entidad)
    End Sub

    ''' <param name="folioPreparacionMezcla">Folio de la preparacion de la mezcla</param>
    ''' <param name="idPlaza">Código de la plaza donde se prepara la mezcla</param>
    ''' <param name="idProducto">Código del producto o ingtrediente con que se prepara la mezcla</param>
    ''' <param name="lote">Lote donde sale el producto o ingrediente para la preparacion de la mezcla</param>
    Sub New(ByVal folioPreparacionMezcla As String, ByVal idPlaza As Integer, ByVal idProducto As Integer, ByVal lote As String)
        MyBase.New(New EC.DetPrepFormLoteEntity(folioPreparacionMezcla, idProducto, lote, idPlaza))
    End Sub

    Sub New()
        MyBase.New()
    End Sub
#End Region

#Region "Propiedades"
    ''' <summary>
    ''' Obtiene o establece el folio de la preparacion de mezcla a la que pertenese este ingrediente
    ''' </summary>
    Public Property FolioPreparacionMezcla() As String
        Get
            Return Entity.FolPrepForm
        End Get
        Set(ByVal value As String)
            Entity.FolPrepForm = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el código de la plaza donde se prepara la mezcla
    ''' </summary>
    Public Property IdPlaza() As Integer
        Get
            Return Entity.IdPlaza
        End Get
        Set(ByVal value As Integer)
            Entity.IdPlaza = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el código del producto
    ''' </summary>
    Public Property IdProducto() As Integer
        Get
            Return Entity.CveProducto
        End Get
        Set(ByVal value As Integer)
            Entity.CveProducto = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece la plaza en la que se prepara la mezcla
    ''' </summary>
    Public Property Plaza() As PlazaClass
        Get
            If Me.m_Plaza Is Nothing Then
                Me.m_Plaza = New PlazaClass
                Me.m_Plaza.LeerEntidad(Entity.Plaza)
            ElseIf Not Me.m_Plaza.Codigo = IdPlaza Then
                Me.m_Plaza.LeerEntidad(Entity.Plaza)
            End If

            Return Me.m_Plaza
        End Get
        Set(ByVal value As PlazaClass)
            Me.m_Plaza = value

            If value Is Nothing Then
                Entity.Plaza = Nothing
            Else
                Entity.Plaza = value.ObtenerEntidad
            End If
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el producto que se usa como ingrediente en la preparacion de mezcla
    ''' </summary>
    Public Property Producto() As ProductoClass
        Get
            If Me.m_Producto Is Nothing Then
                Me.m_Producto = New ProductoClass(Entity.Producto)
            ElseIf Not Me.m_Producto.Codigo = IdProducto Then
                Me.m_Producto.LeerEntidad(Entity.Producto)
            End If

            Return Me.m_Producto
        End Get
        Set(ByVal value As ProductoClass)
            Me.m_Producto = value

            If value Is Nothing Then
                Entity.Producto = Nothing
            Else
                Entity.Producto = value.ObtenerEntidad
            End If
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece la cantidad de producto que salio del lote
    ''' </summary>
    Public Property Cantidad() As Decimal
        Get
            Return Entity.Cantidad
        End Get
        Set(ByVal value As Decimal)
            Entity.Cantidad = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el costo del producto en el lote
    ''' </summary>
    Public Property CostoUnitario() As Decimal
        Get
            Return Entity.CostoUni
        End Get
        Set(ByVal value As Decimal)
            Entity.CostoUni = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece la mezcla a la que pretenece este ingrediente
    ''' </summary>
    Public Property PreparacionMezcla() As Mezcla
        Get
            If Me.m_MezclaPreparada Is Nothing Then
                Me.m_MezclaPreparada = New Mezcla(Entity.CabPrepForm)
            ElseIf Not Me.m_MezclaPreparada.FolioPreparacionMezcla.Trim = Me.FolioPreparacionMezcla.Trim AndAlso _
                    Not Me.m_MezclaPreparada.IdPlaza = IdPlaza Then
                Me.m_MezclaPreparada.Entidad = Entity.CabPrepForm
            End If

            Return Me.m_MezclaPreparada
        End Get
        Set(ByVal value As Mezcla)
            Me.m_MezclaPreparada = value

            If value Is Nothing Then
                Entity.CabPrepForm = Nothing
            Else
                Entity.CabPrepForm = value.Entidad
            End If
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el ingrediente de la mezcla
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property IngredienteMezcla() As Ingrediente
        Get
            If Me.m_IngredienteMezcla Is Nothing Then
                Me.m_IngredienteMezcla = New Ingrediente(Entity.DetPrepForm)
            ElseIf Not Me.m_IngredienteMezcla.IdProducto = IdProducto AndAlso _
                    Me.m_IngredienteMezcla.IdPlaza = IdPlaza AndAlso _
                    Me.m_IngredienteMezcla.FolioPreparacionMezcla.Trim = Me.FolioPreparacionMezcla.Trim Then
                Me.m_IngredienteMezcla.Entidad = Entity.DetPrepForm
            End If

            Return Me.m_IngredienteMezcla
        End Get
        Set(ByVal value As Ingrediente)
            Me.m_IngredienteMezcla = value

            If value Is Nothing Then
                Entity.DetPrepForm = Nothing
            Else
                Entity.DetPrepForm = value.Entidad
            End If
        End Set
    End Property

    Public Property Lote() As String
        Get
            Return Entity.Lote
        End Get
        Set(ByVal value As String)
            Entity.Lote = value
        End Set
    End Property
#End Region

#Region "Metodos"
    ''' <summary>
    ''' Consulta el ingrediente de una preparacion de mezcla
    ''' </summary>
    ''' <param name="folioPreparacionMezcla">Folio de la prepracion de mezcla</param>
    ''' <param name="idPlaza">Código del plaza donde se prepara la mezcla</param>
    ''' <param name="idProducto">Código del producto o ingrediente que contiene la mezcla</param>
    ''' <param name="lote">Lote de donde se toma el producto o ingrediente para la preparacion de la mezcla</param>
    Public Function Obtener(ByVal folioPreparacionMezcla As String, ByVal idPlaza As Integer, ByVal idProducto As Integer, ByVal lote As String) As Boolean

    End Function
#End Region

End Class