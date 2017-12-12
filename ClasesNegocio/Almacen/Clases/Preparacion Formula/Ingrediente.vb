Imports EC = Integralab.ORM.EntityClasses
Imports CC = Integralab.ORM.CollectionClasses
Imports HC = Integralab.ORM.HelperClasses
Imports OC = SD.LLBLGen.Pro.ORMSupportClasses

Public Class Ingrediente
    Inherits ClassBase(Of EC.DetPrepFormEntity)

#Region "Campos"
    ''' <summary>
    ''' Contiene los datos de la mezcla que se esta preparando
    ''' </summary>
    Private m_MezclaPreparada As Mezcla
    ''' <summary>
    ''' Contirne la plaza en la que se prepara la mezcla
    ''' </summary>
    Private m_Plaza As PlazaClass
    ''' <summary>
    ''' Contiene el producto o ingrediente que contiene la mezcla
    ''' </summary>
    Private m_Producto As ProductoClass
    ''' <summary>
    ''' Contiene que cantidad del ingrediente o producto salio del almacen y lote para la preparacion de la mezcla
    ''' </summary>
    Private m_LotesIngredientes As IngredienteLoteColletion
    ''' <summary>
    ''' Contiene la cantidad disponible en el inventario del almacén
    ''' </summary>
    ''' <remarks></remarks>
    Private m_CantidadDisponible As Decimal
#End Region

#Region "Constructores"
    ''' <param name="entidad">Entity con los datos del ingrediente con que se prepara la mezcla</param>
    Sub New(ByVal entidad As EC.DetPrepFormEntity)
        MyBase.New(entidad)
    End Sub

    ''' <param name="folioPreparacionMezcla">Folio de la preparacion de la mezcla</param>
    ''' <param name="idPlaza">Código de la plaza donde se prepara la mezcla</param>
    ''' <param name="idProducto">Código del producto o ingrediente con que se prepara la mezcla</param>
    Sub New(ByVal folioPreparacionMezcla As String, ByVal idPlaza As Integer, ByVal idProducto As Integer)
        MyBase.New(New EC.DetPrepFormEntity(folioPreparacionMezcla, idPlaza, idProducto))
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
    ''' Obtiene o establece el porcentaje sugerido que tiene el ingrediente en la preparacion de la mezcla
    ''' </summary>
    Public Property PorcentajeMezcla() As Decimal
        Get
            Return Entity.PtjFormula
        End Get
        Set(ByVal value As Decimal)
            Entity.PtjFormula = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece los kilosgramos sugeridos que se usan de este ingrediente para la preparacion de la mezcla
    ''' </summary>
    Public Property KilogramosMezcla() As Decimal
        Get
            Return Entity.KgrsFormula
        End Get
        Set(ByVal value As Decimal)
            Entity.KgrsFormula = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece los kilogramos que se le daran salida del alamcen para la preparacion de la mezcla
    ''' </summary>
    Public Property KilogramosSalidaMezcla() As Decimal
        Get
            Return Entity.KgrsSalida
        End Get
        Set(ByVal value As Decimal)
            If value > Me.CantidadDisponible Then
                value = Me.CantidadDisponible
            End If

            Entity.KgrsSalida = value
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece el costo del ingrediente
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
    ''' Obtiene o establece el producto que se usa como ingrediente en la preparacion de mezcla
    ''' </summary>
    Public Property Producto() As ProductoClass
        Get
            If Me.m_Producto Is Nothing Then
                Me.m_Producto = New ProductoClass(Entity.Producto)
            ElseIf Not m_Producto.Codigo = IdProducto Then
                m_Producto.LeerEntidad(Entity.Producto)
            End If

            Return m_Producto
        End Get
        Set(ByVal value As ProductoClass)
            m_Producto = value

            If m_Producto Is Nothing Then
                Entity.Producto = Nothing
            Else
                Entity.Producto = value.ObtenerEntidad
            End If
        End Set
    End Property

    ''' <summary>
    ''' Obtiene o establece la plaza en la que se prepara la mezcla
    ''' </summary>
    Public Property Plaza() As PlazaClass
        Get
            If m_Plaza Is Nothing Then
                m_Plaza = New PlazaClass
                m_Plaza.LeerEntidad(Entity.Plaza)
            ElseIf Not m_Plaza.Codigo = IdPlaza Then
                m_Plaza.LeerEntidad(Entity.Plaza)
            End If

            Return m_Plaza
        End Get
        Set(ByVal value As PlazaClass)
            m_Plaza = value

            If value Is Nothing Then
                Entity.Plaza = Nothing
            Else
                Entity.Plaza = value.ObtenerEntidad
            End If
        End Set
    End Property

    ''' <summary>
    ''' Contiene los lotes de donde salen el producto o ingrediente para la preparacion de la mezcla
    ''' </summary>
    ''' <remarks>Contiene los lotes de donde salen el producto o ingrediente para la preparacion de la mezcla</remarks>
    Public ReadOnly Property IngredienteLotes() As IngredienteLoteColletion
        Get
            If Me.m_LotesIngredientes Is Nothing Then
                Me.m_LotesIngredientes = New IngredienteLoteColletion(Entity.DetPrepFormLote)
            End If

            Return Me.m_LotesIngredientes
        End Get
    End Property

    ''' <summary>
    ''' Obtiene o establece la mezcla a la que pretenece este ingrediente
    ''' </summary>
    ''' <remarks>Obtiene o establece la mezcla a la que pretenece este ingrediente</remarks>
    Public Property PreparacionMezcla() As Mezcla
        Get
            If Me.m_MezclaPreparada Is Nothing Then
                Me.m_MezclaPreparada.Entidad = Entity.CabPrepForm
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
    ''' Cantidad deisponible en el inventario del alamcén donde se prepara la mezcla
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property CantidadDisponible() As Decimal
        Get
            Return Me.m_CantidadDisponible
        End Get
        Set(ByVal value As Decimal)
            m_CantidadDisponible = value
        End Set
    End Property

    Public ReadOnly Property Importe() As Decimal
        Get
            Return Me.CostoUnitario * Me.KilogramosSalidaMezcla
        End Get
    End Property
#End Region
    
#Region "Metodos"
    ''' <summary>
    ''' Consulta el ingrediente de una preparacion de mezcla
    ''' </summary>
    ''' <param name="folioPreparacionMezcla">Folio de la prepracion de mezcla</param>
    ''' <param name="idPlaza">Código del plaza donde se prepara la mezcla</param>
    ''' <param name="idProducto">Código del producto o ingrediente que contiene la mezcla</param>
    Public Function Obtener(ByVal folioPreparacionMezcla As String, ByVal idPlaza As Integer, ByVal idProducto As Integer) As Boolean

    End Function

    Public Shadows Function Guardar(ByVal trans As HC.Transaction) As Boolean
        
trans.Add(Entidad)
        Entidad.Save()
        Me.IngredienteLotes.Guardar(trans)
    End Function
#End Region
End Class