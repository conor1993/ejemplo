' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 2 de marzo de 2018 16:12:40
' // Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
' // Templates vendor: Solutions Design.
' // Templates version: 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
#If Not CF Then
Imports System.Runtime.Serialization
#End If
Imports System.Data
Imports System.Xml.Serialization
Imports Integralab.ORM
Imports Integralab.ORM.FactoryClasses
Imports Integralab.ORM.DaoClasses
Imports Integralab.ORM.RelationClasses
Imports Integralab.ORM.HelperClasses
Imports Integralab.ORM.CollectionClasses

Imports SD.LLBLGen.Pro.ORMSupportClasses

' __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
' __LLBLGENPRO_USER_CODE_REGION_END
Namespace Integralab.ORM.EntityClasses
	''' <summary>Entity class which represents the entity 'MinvTransferenciaAlmacenSalida'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class MinvTransferenciaAlmacenSalidaEntity 
#Else
	<Serializable()> _
	Public Class MinvTransferenciaAlmacenSalidaEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _minvTransferenciaAlmacenEntrada As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection
		Private _alwaysFetchMinvTransferenciaAlmacenEntrada, _alreadyFetchedMinvTransferenciaAlmacenEntrada As Boolean
		Private _minvTransferenciaAlmacenSalidaDetalle As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaDetalleCollection
		Private _alwaysFetchMinvTransferenciaAlmacenSalidaDetalle, _alreadyFetchedMinvTransferenciaAlmacenSalidaDetalle As Boolean
		Private _almacenCollectionViaMinvTransferenciaAlmacenEntrada As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada, _alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada As Boolean
		Private _almacenCollectionViaMinvTransferenciaAlmacenEntrada_ As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_, _alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ As Boolean
		Private _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
		Private _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada, _alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada As Boolean
		Private _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
		Private _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_, _alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ As Boolean
		Private _productoCollectionViaMinvTransferenciaAlmacenSalidaDetalle As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle, _alreadyFetchedProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle As Boolean
		Private _almacenDestino As AlmacenEntity
		Private _alwaysFetchAlmacenDestino, _alreadyFetchedAlmacenDestino, _almacenDestinoReturnsNewIfNotFound As Boolean
		Private _almacenOrigen As AlmacenEntity
		Private _alwaysFetchAlmacenOrigen, _alreadyFetchedAlmacenOrigen, _almacenOrigenReturnsNewIfNotFound As Boolean
		Private _inventarioMovimientoAlmacen As InventarioMovimientoAlmacenEntity
		Private _alwaysFetchInventarioMovimientoAlmacen, _alreadyFetchedInventarioMovimientoAlmacen, _inventarioMovimientoAlmacenReturnsNewIfNotFound As Boolean
		Private _inventarioMovimientoAlmacen_ As InventarioMovimientoAlmacenEntity
		Private _alwaysFetchInventarioMovimientoAlmacen_, _alreadyFetchedInventarioMovimientoAlmacen_, _inventarioMovimientoAlmacen_ReturnsNewIfNotFound As Boolean


		Private Shared _customProperties As Dictionary(Of String, String)
		Private Shared _fieldsCustomProperties As Dictionary(Of String, Dictionary(Of String, String))
		
		' __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

		''' <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		Shared Sub New()
			SetupCustomPropertyHashtables()
		End Sub

		''' <summary>CTor</summary>
		Public Sub New()
			MyBase.New()
			InitClassEmpty(CreateValidator())
		End Sub


		''' <summary>CTor</summary>
		''' <param name="folioTransferencia">PK value for MinvTransferenciaAlmacenSalida which data should be fetched into this MinvTransferenciaAlmacenSalida Object</param>
		Public Sub New(folioTransferencia As System.String)

			InitClassFetch(folioTransferencia, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folioTransferencia">PK value for MinvTransferenciaAlmacenSalida which data should be fetched into this MinvTransferenciaAlmacenSalida Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(folioTransferencia As System.String, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(folioTransferencia, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folioTransferencia">PK value for MinvTransferenciaAlmacenSalida which data should be fetched into this MinvTransferenciaAlmacenSalida Object</param>
		''' <param name="validator">The custom validator Object for this MinvTransferenciaAlmacenSalidaEntity</param>
		Public Sub New(folioTransferencia As System.String, validator As IValidator)

			InitClassFetch(folioTransferencia, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_minvTransferenciaAlmacenEntrada = CType(info.GetValue("_minvTransferenciaAlmacenEntrada", GetType(Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection)), Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection)
			_alwaysFetchMinvTransferenciaAlmacenEntrada = info.GetBoolean("_alwaysFetchMinvTransferenciaAlmacenEntrada")
			_alreadyFetchedMinvTransferenciaAlmacenEntrada = info.GetBoolean("_alreadyFetchedMinvTransferenciaAlmacenEntrada")
			_minvTransferenciaAlmacenSalidaDetalle = CType(info.GetValue("_minvTransferenciaAlmacenSalidaDetalle", GetType(Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaDetalleCollection)), Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaDetalleCollection)
			_alwaysFetchMinvTransferenciaAlmacenSalidaDetalle = info.GetBoolean("_alwaysFetchMinvTransferenciaAlmacenSalidaDetalle")
			_alreadyFetchedMinvTransferenciaAlmacenSalidaDetalle = info.GetBoolean("_alreadyFetchedMinvTransferenciaAlmacenSalidaDetalle")
			_almacenCollectionViaMinvTransferenciaAlmacenEntrada = CType(info.GetValue("_almacenCollectionViaMinvTransferenciaAlmacenEntrada", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada = info.GetBoolean("_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada")
			_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada = info.GetBoolean("_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada")
			_almacenCollectionViaMinvTransferenciaAlmacenEntrada_ = CType(info.GetValue("_almacenCollectionViaMinvTransferenciaAlmacenEntrada_", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ = info.GetBoolean("_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_")
			_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ = info.GetBoolean("_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_")
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada = CType(info.GetValue("_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada", GetType(Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)), Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada = info.GetBoolean("_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada")
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada = info.GetBoolean("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada")
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ = CType(info.GetValue("_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_", GetType(Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)), Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection)
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ = info.GetBoolean("_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_")
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ = info.GetBoolean("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_")
			_productoCollectionViaMinvTransferenciaAlmacenSalidaDetalle = CType(info.GetValue("_productoCollectionViaMinvTransferenciaAlmacenSalidaDetalle", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle = info.GetBoolean("_alwaysFetchProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle")
			_alreadyFetchedProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle = info.GetBoolean("_alreadyFetchedProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle")
			_almacenDestino = CType(info.GetValue("_almacenDestino", GetType(AlmacenEntity)), AlmacenEntity)
			If Not _almacenDestino Is Nothing Then
				AddHandler _almacenDestino.AfterSave, AddressOf OnEntityAfterSave
			End If
			_almacenDestinoReturnsNewIfNotFound = info.GetBoolean("_almacenDestinoReturnsNewIfNotFound")
			_alwaysFetchAlmacenDestino = info.GetBoolean("_alwaysFetchAlmacenDestino")
			_alreadyFetchedAlmacenDestino = info.GetBoolean("_alreadyFetchedAlmacenDestino")
			_almacenOrigen = CType(info.GetValue("_almacenOrigen", GetType(AlmacenEntity)), AlmacenEntity)
			If Not _almacenOrigen Is Nothing Then
				AddHandler _almacenOrigen.AfterSave, AddressOf OnEntityAfterSave
			End If
			_almacenOrigenReturnsNewIfNotFound = info.GetBoolean("_almacenOrigenReturnsNewIfNotFound")
			_alwaysFetchAlmacenOrigen = info.GetBoolean("_alwaysFetchAlmacenOrigen")
			_alreadyFetchedAlmacenOrigen = info.GetBoolean("_alreadyFetchedAlmacenOrigen")
			_inventarioMovimientoAlmacen = CType(info.GetValue("_inventarioMovimientoAlmacen", GetType(InventarioMovimientoAlmacenEntity)), InventarioMovimientoAlmacenEntity)
			If Not _inventarioMovimientoAlmacen Is Nothing Then
				AddHandler _inventarioMovimientoAlmacen.AfterSave, AddressOf OnEntityAfterSave
			End If
			_inventarioMovimientoAlmacenReturnsNewIfNotFound = info.GetBoolean("_inventarioMovimientoAlmacenReturnsNewIfNotFound")
			_alwaysFetchInventarioMovimientoAlmacen = info.GetBoolean("_alwaysFetchInventarioMovimientoAlmacen")
			_alreadyFetchedInventarioMovimientoAlmacen = info.GetBoolean("_alreadyFetchedInventarioMovimientoAlmacen")
			_inventarioMovimientoAlmacen_ = CType(info.GetValue("_inventarioMovimientoAlmacen_", GetType(InventarioMovimientoAlmacenEntity)), InventarioMovimientoAlmacenEntity)
			If Not _inventarioMovimientoAlmacen_ Is Nothing Then
				AddHandler _inventarioMovimientoAlmacen_.AfterSave, AddressOf OnEntityAfterSave
			End If
			_inventarioMovimientoAlmacen_ReturnsNewIfNotFound = info.GetBoolean("_inventarioMovimientoAlmacen_ReturnsNewIfNotFound")
			_alwaysFetchInventarioMovimientoAlmacen_ = info.GetBoolean("_alwaysFetchInventarioMovimientoAlmacen_")
			_alreadyFetchedInventarioMovimientoAlmacen_ = info.GetBoolean("_alreadyFetchedInventarioMovimientoAlmacen_")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedMinvTransferenciaAlmacenEntrada = (_minvTransferenciaAlmacenEntrada.Count > 0)
			_alreadyFetchedMinvTransferenciaAlmacenSalidaDetalle = (_minvTransferenciaAlmacenSalidaDetalle.Count > 0)
			_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada = (_almacenCollectionViaMinvTransferenciaAlmacenEntrada.Count > 0)
			_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ = (_almacenCollectionViaMinvTransferenciaAlmacenEntrada_.Count > 0)
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada = (_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada.Count > 0)
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ = (_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_.Count > 0)
			_alreadyFetchedProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle = (_productoCollectionViaMinvTransferenciaAlmacenSalidaDetalle.Count > 0)
			_alreadyFetchedAlmacenDestino = Not(_almacenDestino Is Nothing)
			_alreadyFetchedAlmacenOrigen = Not(_almacenOrigen Is Nothing)
			_alreadyFetchedInventarioMovimientoAlmacen = Not(_inventarioMovimientoAlmacen Is Nothing)
			_alreadyFetchedInventarioMovimientoAlmacen_ = Not(_inventarioMovimientoAlmacen_ Is Nothing)

		End Sub


		''' <summary>Saves the Entity class to the persistent storage. It updates or inserts the entity, which depends If the entity was originally read from the 
		''' database. If the entity is new, an insert is done and the updateRestriction is ignored. If the entity is not new, the updateRestriction
		''' predicate is used to create an additional where clause (it will be added with AND) for the update query. This predicate can be used for
		''' concurrency checks, like checks on timestamp column values.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query. Will be ignored when the entity is new </param>
		''' <param name="recurse">When true, it will save all dirty objects referenced (directly or indirectly) by this entity also.</param>
		''' <returns>true If Save succeeded, false otherwise</returns>
		''' <exception cref="ORMQueryExecutionException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework
		''' implemented.</exception>
		Public Overloads Overrides Function Save(updateRestriction As IPredicate, recurse As Boolean) As Boolean
			Dim transactionStartedInThisScope As Boolean = False
			Dim transactionManager As Transaction = Nothing
			If recurse OrElse ((Me.LLBLGenProIsInHierarchyOfType=InheritanceHierarchyType.TargetPerEntity) AndAlso Me.LLBLGenProIsSubType) Then
				If Not MyBase.ParticipatesInTransaction Then
					transactionManager = New Transaction(IsolationLevel.ReadCommitted, "SaveRecursively")
					transactionManager.Add(Me)
					transactionStartedInThisScope = True
				End If
			End If
			Try
				Dim result As Boolean = MyBase.Save(updateRestriction, recurse)
				If transactionStartedInThisScope Then
					transactionManager.Commit()
				End If
				Return result
			Catch
				If transactionStartedInThisScope Then
					transactionManager.Rollback()
				End If
				Throw
			Finally
				If transactionStartedInThisScope Then
					transactionManager.Dispose()
				End If
			End Try
		End Function



		''' <summary>ISerializable member. Does custom serialization so event handlers do not get serialized.
		''' Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		<EditorBrowsable(EditorBrowsableState.Never)> _
		Public Overrides Sub GetObjectData(info As SerializationInfo, context As StreamingContext)
			info.AddValue("_minvTransferenciaAlmacenEntrada", _minvTransferenciaAlmacenEntrada)
			info.AddValue("_alwaysFetchMinvTransferenciaAlmacenEntrada", _alwaysFetchMinvTransferenciaAlmacenEntrada)
			info.AddValue("_alreadyFetchedMinvTransferenciaAlmacenEntrada", _alreadyFetchedMinvTransferenciaAlmacenEntrada)
			info.AddValue("_minvTransferenciaAlmacenSalidaDetalle", _minvTransferenciaAlmacenSalidaDetalle)
			info.AddValue("_alwaysFetchMinvTransferenciaAlmacenSalidaDetalle", _alwaysFetchMinvTransferenciaAlmacenSalidaDetalle)
			info.AddValue("_alreadyFetchedMinvTransferenciaAlmacenSalidaDetalle", _alreadyFetchedMinvTransferenciaAlmacenSalidaDetalle)
			info.AddValue("_almacenCollectionViaMinvTransferenciaAlmacenEntrada", _almacenCollectionViaMinvTransferenciaAlmacenEntrada)
			info.AddValue("_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada", _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada)
			info.AddValue("_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada", _alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada)
			info.AddValue("_almacenCollectionViaMinvTransferenciaAlmacenEntrada_", _almacenCollectionViaMinvTransferenciaAlmacenEntrada_)
			info.AddValue("_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_", _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_)
			info.AddValue("_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_", _alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_)
			info.AddValue("_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada", _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada)
			info.AddValue("_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada", _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada)
			info.AddValue("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada", _alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada)
			info.AddValue("_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_", _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_)
			info.AddValue("_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_", _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_)
			info.AddValue("_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_", _alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_)
			info.AddValue("_productoCollectionViaMinvTransferenciaAlmacenSalidaDetalle", _productoCollectionViaMinvTransferenciaAlmacenSalidaDetalle)
			info.AddValue("_alwaysFetchProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle", _alwaysFetchProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle)
			info.AddValue("_alreadyFetchedProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle", _alreadyFetchedProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle)
			info.AddValue("_almacenDestino", _almacenDestino)
			info.AddValue("_almacenDestinoReturnsNewIfNotFound", _almacenDestinoReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchAlmacenDestino", _alwaysFetchAlmacenDestino)
			info.AddValue("_alreadyFetchedAlmacenDestino", _alreadyFetchedAlmacenDestino)
			info.AddValue("_almacenOrigen", _almacenOrigen)
			info.AddValue("_almacenOrigenReturnsNewIfNotFound", _almacenOrigenReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchAlmacenOrigen", _alwaysFetchAlmacenOrigen)
			info.AddValue("_alreadyFetchedAlmacenOrigen", _alreadyFetchedAlmacenOrigen)
			info.AddValue("_inventarioMovimientoAlmacen", _inventarioMovimientoAlmacen)
			info.AddValue("_inventarioMovimientoAlmacenReturnsNewIfNotFound", _inventarioMovimientoAlmacenReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchInventarioMovimientoAlmacen", _alwaysFetchInventarioMovimientoAlmacen)
			info.AddValue("_alreadyFetchedInventarioMovimientoAlmacen", _alreadyFetchedInventarioMovimientoAlmacen)
			info.AddValue("_inventarioMovimientoAlmacen_", _inventarioMovimientoAlmacen_)
			info.AddValue("_inventarioMovimientoAlmacen_ReturnsNewIfNotFound", _inventarioMovimientoAlmacen_ReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchInventarioMovimientoAlmacen_", _alwaysFetchInventarioMovimientoAlmacen_)
			info.AddValue("_alreadyFetchedInventarioMovimientoAlmacen_", _alreadyFetchedInventarioMovimientoAlmacen_)

			
			' __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			' __LLBLGENPRO_USER_CODE_REGION_END
			MyBase.GetObjectData(info, context)
		End Sub

		''' <summary>Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		''' <param name="propertyName">Name of the property.</param>
		''' <param name="entity">Entity to set as an related entity</param>
		''' <remarks>Used by prefetch path logic.</remarks>
		<EditorBrowsable(EditorBrowsableState.Never)> _
		Public Overrides Overloads Sub SetRelatedEntityProperty(propertyName As String, entity As IEntity)
			Select Case propertyName
				Case "AlmacenDestino"
					_alreadyFetchedAlmacenDestino = True
					Me.AlmacenDestino = CType(entity, AlmacenEntity)
				Case "AlmacenOrigen"
					_alreadyFetchedAlmacenOrigen = True
					Me.AlmacenOrigen = CType(entity, AlmacenEntity)
				Case "InventarioMovimientoAlmacen"
					_alreadyFetchedInventarioMovimientoAlmacen = True
					Me.InventarioMovimientoAlmacen = CType(entity, InventarioMovimientoAlmacenEntity)
				Case "InventarioMovimientoAlmacen_"
					_alreadyFetchedInventarioMovimientoAlmacen_ = True
					Me.InventarioMovimientoAlmacen_ = CType(entity, InventarioMovimientoAlmacenEntity)
				Case "MinvTransferenciaAlmacenEntrada"
					_alreadyFetchedMinvTransferenciaAlmacenEntrada = True
					If Not entity Is Nothing Then
						Me.MinvTransferenciaAlmacenEntrada.Add(CType(entity, MinvTransferenciaAlmacenEntradaEntity))
					End If
				Case "MinvTransferenciaAlmacenSalidaDetalle"
					_alreadyFetchedMinvTransferenciaAlmacenSalidaDetalle = True
					If Not entity Is Nothing Then
						Me.MinvTransferenciaAlmacenSalidaDetalle.Add(CType(entity, MinvTransferenciaAlmacenSalidaDetalleEntity))
					End If
				Case "AlmacenCollectionViaMinvTransferenciaAlmacenEntrada"
					_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada = True
					If Not entity Is Nothing Then
						Me.AlmacenCollectionViaMinvTransferenciaAlmacenEntrada.Add(CType(entity, AlmacenEntity))
					End If
				Case "AlmacenCollectionViaMinvTransferenciaAlmacenEntrada_"
					_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ = True
					If Not entity Is Nothing Then
						Me.AlmacenCollectionViaMinvTransferenciaAlmacenEntrada_.Add(CType(entity, AlmacenEntity))
					End If
				Case "InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada"
					_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada = True
					If Not entity Is Nothing Then
						Me.InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada.Add(CType(entity, InventarioMovimientoAlmacenEntity))
					End If
				Case "InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_"
					_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ = True
					If Not entity Is Nothing Then
						Me.InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_.Add(CType(entity, InventarioMovimientoAlmacenEntity))
					End If
				Case "ProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle"
					_alreadyFetchedProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle.Add(CType(entity, ProductoEntity))
					End If

				Case Else

			End Select
		End Sub

		''' <summary>Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		''' <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		<EditorBrowsable(EditorBrowsableState.Never)> _
		Public Overrides Overloads Sub SetRelatedEntity(relatedEntity As IEntity, fieldName As String)
			Select Case fieldName
				Case "AlmacenDestino"
					SetupSyncAlmacenDestino(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "AlmacenOrigen"
					SetupSyncAlmacenOrigen(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "InventarioMovimientoAlmacen"
					SetupSyncInventarioMovimientoAlmacen(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "InventarioMovimientoAlmacen_"
					SetupSyncInventarioMovimientoAlmacen_(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MinvTransferenciaAlmacenEntrada"
					_minvTransferenciaAlmacenEntrada.Add(CType(relatedEntity, MinvTransferenciaAlmacenEntradaEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MinvTransferenciaAlmacenSalidaDetalle"
					_minvTransferenciaAlmacenSalidaDetalle.Add(CType(relatedEntity, MinvTransferenciaAlmacenSalidaDetalleEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)

				Case Else

			End Select
		End Sub

		''' <summary>Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		''' <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		''' <param name="signalRelatedEntityManyToOne">if set to true it will notify the manytoone side, if applicable.</param>
		<EditorBrowsable(EditorBrowsableState.Never)> _
		Public Overrides Overloads Sub UnsetRelatedEntity(relatedEntity As IEntity, fieldName As String, signalRelatedEntityManyToOne As Boolean)
			Select Case fieldName
				Case "AlmacenDestino"
					DesetupSyncAlmacenDestino(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "AlmacenOrigen"
					DesetupSyncAlmacenOrigen(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "InventarioMovimientoAlmacen"
					DesetupSyncInventarioMovimientoAlmacen(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "InventarioMovimientoAlmacen_"
					DesetupSyncInventarioMovimientoAlmacen_(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MinvTransferenciaAlmacenEntrada"
					MyBase.PerformRelatedEntityRemoval(_minvTransferenciaAlmacenEntrada, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MinvTransferenciaAlmacenSalidaDetalle"
					MyBase.PerformRelatedEntityRemoval(_minvTransferenciaAlmacenSalidaDetalle, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)

				Case Else

			End Select
		End Sub

		''' <summary>Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These
		''' entities will have to be persisted after this entity during a recursive save.</summary>
		''' <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		Public Overrides Function GetDependingRelatedEntities() As List(Of IEntity)
			Dim toReturn As New List(Of IEntity)()


			Return toReturn
		End Function

		''' <summary>Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		''' entities will have to be persisted before this entity during a recursive save.</summary>
		''' <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		Public Overrides Function GetDependentRelatedEntities() As List(Of IEntity)
			Dim toReturn As New List(Of IEntity)()
			If Not _almacenDestino Is Nothing Then
				toReturn.Add(_almacenDestino)
			End If
			If Not _almacenOrigen Is Nothing Then
				toReturn.Add(_almacenOrigen)
			End If
			If Not _inventarioMovimientoAlmacen Is Nothing Then
				toReturn.Add(_inventarioMovimientoAlmacen)
			End If
			If Not _inventarioMovimientoAlmacen_ Is Nothing Then
				toReturn.Add(_inventarioMovimientoAlmacen_)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_minvTransferenciaAlmacenEntrada)
			toReturn.Add(_minvTransferenciaAlmacenSalidaDetalle)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folioTransferencia">PK value for MinvTransferenciaAlmacenSalida which data should be fetched into this MinvTransferenciaAlmacenSalida Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folioTransferencia As System.String) As Boolean
			Return FetchUsingPK(folioTransferencia, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folioTransferencia">PK value for MinvTransferenciaAlmacenSalida which data should be fetched into this MinvTransferenciaAlmacenSalida Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folioTransferencia As System.String, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(folioTransferencia, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folioTransferencia">PK value for MinvTransferenciaAlmacenSalida which data should be fetched into this MinvTransferenciaAlmacenSalida Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folioTransferencia As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(folioTransferencia, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.FolioTransferencia, Nothing, Nothing)
		End Function

		''' <summary>Deletes the Entity from the persistent storage. This method succeeds also when the Entity is not present.</summary>
		''' <param name="deleteRestriction">Predicate expression, meant for concurrency checks in a delete query. Overrules the predicate returned by a set ConcurrencyPredicateFactory object.</param>
		''' <returns>true if Delete succeeded, False otherwise</returns>
		''' <exception cref="ORMQueryExecutionException">When an exception is caught during the delete process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Delete(deleteRestriction As IPredicate) As Boolean
			Dim transactionStartedInThisScope As Boolean = False
			Dim transactionManager As Transaction = Nothing
			If (Me.LLBLGenProIsInHierarchyOfType=InheritanceHierarchyType.TargetPerEntity) AndAlso Me.LLBLGenProIsSubType Then
				If Not MyBase.ParticipatesInTransaction Then
					transactionManager = New Transaction(IsolationLevel.ReadCommitted, "SaveRecursively")
					transactionManager.Add(Me)
					transactionStartedInThisScope = True
				End If
			End If
			Try
				OnValidateEntityBeforeDelete()
				OnDelete()
				Dim dao As IDao = CreateDAOInstance()
				Dim wasSuccesful As Boolean = dao.DeleteExisting(MyBase.Fields, MyBase.Transaction, deleteRestriction)
				If wasSuccesful Then
					MyBase.Delete(deleteRestriction)
				Else
					If Not deleteRestriction Is Nothing Then
						Throw New ORMConcurrencyException("The delete action of an entity failed, probably due to the set delete restriction provided. The entity which failed is enclosed.", Me)
					End If
				End If
				If transactionStartedInThisScope Then
					transactionManager.Commit()
				End If
				Return wasSuccesful
			Catch
				If transactionStartedInThisScope Then
					transactionManager.Rollback()
				End If
				Throw
			Finally
				If transactionStartedInThisScope Then
					transactionManager.Dispose()
				End If
				OnDeleteComplete()
			End Try
		End Function

		''' <summary>Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, False otherwise.
		''' Should Not be used For testing If the current value Is NULL, use <see cref="TestCurrentFieldValueForNull"/> For that.</summary>
		''' <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		''' <returns>true if the field with the passed in index was NULL in the persistent storage, False otherwise</returns>
		Public  Function TestOriginalFieldValueForNull(fieldIndex As MinvTransferenciaAlmacenSalidaFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As MinvTransferenciaAlmacenSalidaFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenEntradaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MinvTransferenciaAlmacenEntradaEntity'</returns>
		Public Function GetMultiMinvTransferenciaAlmacenEntrada(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection
			Return GetMultiMinvTransferenciaAlmacenEntrada(forceFetch, _minvTransferenciaAlmacenEntrada.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenEntradaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMinvTransferenciaAlmacenEntrada(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection
			Return GetMultiMinvTransferenciaAlmacenEntrada(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenEntradaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MinvTransferenciaAlmacenEntradaEntity'</returns>
		Public Function GetMultiMinvTransferenciaAlmacenEntrada(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection
			Return GetMultiMinvTransferenciaAlmacenEntrada(forceFetch, _minvTransferenciaAlmacenEntrada.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenEntradaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMinvTransferenciaAlmacenEntrada(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection
			If ( Not _alreadyFetchedMinvTransferenciaAlmacenEntrada Or forceFetch Or _alwaysFetchMinvTransferenciaAlmacenEntrada) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _minvTransferenciaAlmacenEntrada.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_minvTransferenciaAlmacenEntrada)
					End If
				End If
				_minvTransferenciaAlmacenEntrada.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_minvTransferenciaAlmacenEntrada.EntityFactoryToUse = entityFactoryToUse
				End If
				_minvTransferenciaAlmacenEntrada.GetMultiManyToOne(Nothing, Nothing, Nothing, Nothing, Me, Filter)
				_minvTransferenciaAlmacenEntrada.SuppressClearInGetMulti = False
				_alreadyFetchedMinvTransferenciaAlmacenEntrada = True
			End If
			Return _minvTransferenciaAlmacenEntrada
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MinvTransferenciaAlmacenEntrada'. These settings will be taken into account
		''' when the property MinvTransferenciaAlmacenEntrada is requested or GetMultiMinvTransferenciaAlmacenEntrada is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMinvTransferenciaAlmacenEntrada(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_minvTransferenciaAlmacenEntrada.SortClauses=sortClauses
			_minvTransferenciaAlmacenEntrada.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenSalidaDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MinvTransferenciaAlmacenSalidaDetalleEntity'</returns>
		Public Function GetMultiMinvTransferenciaAlmacenSalidaDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaDetalleCollection
			Return GetMultiMinvTransferenciaAlmacenSalidaDetalle(forceFetch, _minvTransferenciaAlmacenSalidaDetalle.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenSalidaDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMinvTransferenciaAlmacenSalidaDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaDetalleCollection
			Return GetMultiMinvTransferenciaAlmacenSalidaDetalle(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenSalidaDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MinvTransferenciaAlmacenSalidaDetalleEntity'</returns>
		Public Function GetMultiMinvTransferenciaAlmacenSalidaDetalle(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaDetalleCollection
			Return GetMultiMinvTransferenciaAlmacenSalidaDetalle(forceFetch, _minvTransferenciaAlmacenSalidaDetalle.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenSalidaDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMinvTransferenciaAlmacenSalidaDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaDetalleCollection
			If ( Not _alreadyFetchedMinvTransferenciaAlmacenSalidaDetalle Or forceFetch Or _alwaysFetchMinvTransferenciaAlmacenSalidaDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _minvTransferenciaAlmacenSalidaDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_minvTransferenciaAlmacenSalidaDetalle)
					End If
				End If
				_minvTransferenciaAlmacenSalidaDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_minvTransferenciaAlmacenSalidaDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_minvTransferenciaAlmacenSalidaDetalle.GetMultiManyToOne(Nothing, Me, Filter)
				_minvTransferenciaAlmacenSalidaDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedMinvTransferenciaAlmacenSalidaDetalle = True
			End If
			Return _minvTransferenciaAlmacenSalidaDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MinvTransferenciaAlmacenSalidaDetalle'. These settings will be taken into account
		''' when the property MinvTransferenciaAlmacenSalidaDetalle is requested or GetMultiMinvTransferenciaAlmacenSalidaDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMinvTransferenciaAlmacenSalidaDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_minvTransferenciaAlmacenSalidaDetalle.SortClauses=sortClauses
			_minvTransferenciaAlmacenSalidaDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada(forceFetch, _almacenCollectionViaMinvTransferenciaAlmacenEntrada.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenCollection
			If ( Not _alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada Or forceFetch Or _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacenCollectionViaMinvTransferenciaAlmacenEntrada.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacenCollectionViaMinvTransferenciaAlmacenEntrada)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingFolioTransferenciaSalida, "__MinvTransferenciaAlmacenSalidaEntity__", "MinvTransferenciaAlmacenEntrada_", JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.AlmacenEntityUsingIdAlmacenDestino, "MinvTransferenciaAlmacenEntrada_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MinvTransferenciaAlmacenSalidaFieldIndex.FolioTransferencia), ComparisonOperator.Equal, Me.FolioTransferencia))
				_almacenCollectionViaMinvTransferenciaAlmacenEntrada.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacenCollectionViaMinvTransferenciaAlmacenEntrada.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacenCollectionViaMinvTransferenciaAlmacenEntrada.GetMulti(Filter, relations)
				_almacenCollectionViaMinvTransferenciaAlmacenEntrada.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada = True
			End If
			Return _almacenCollectionViaMinvTransferenciaAlmacenEntrada
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AlmacenCollectionViaMinvTransferenciaAlmacenEntrada'. These settings will be taken into account
		''' when the property AlmacenCollectionViaMinvTransferenciaAlmacenEntrada is requested or GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacenCollectionViaMinvTransferenciaAlmacenEntrada(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacenCollectionViaMinvTransferenciaAlmacenEntrada.SortClauses=sortClauses
			_almacenCollectionViaMinvTransferenciaAlmacenEntrada.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_(forceFetch, _almacenCollectionViaMinvTransferenciaAlmacenEntrada_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenCollection
			If ( Not _alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ Or forceFetch Or _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacenCollectionViaMinvTransferenciaAlmacenEntrada_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacenCollectionViaMinvTransferenciaAlmacenEntrada_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingFolioTransferenciaSalida, "__MinvTransferenciaAlmacenSalidaEntity__", "MinvTransferenciaAlmacenEntrada_", JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.AlmacenEntityUsingIdAlmacenOrigen, "MinvTransferenciaAlmacenEntrada_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MinvTransferenciaAlmacenSalidaFieldIndex.FolioTransferencia), ComparisonOperator.Equal, Me.FolioTransferencia))
				_almacenCollectionViaMinvTransferenciaAlmacenEntrada_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacenCollectionViaMinvTransferenciaAlmacenEntrada_.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacenCollectionViaMinvTransferenciaAlmacenEntrada_.GetMulti(Filter, relations)
				_almacenCollectionViaMinvTransferenciaAlmacenEntrada_.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ = True
			End If
			Return _almacenCollectionViaMinvTransferenciaAlmacenEntrada_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AlmacenCollectionViaMinvTransferenciaAlmacenEntrada_'. These settings will be taken into account
		''' when the property AlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ is requested or GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacenCollectionViaMinvTransferenciaAlmacenEntrada_.SortClauses=sortClauses
			_almacenCollectionViaMinvTransferenciaAlmacenEntrada_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'InventarioMovimientoAlmacenEntity'</returns>
		Public Function GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Return GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada(forceFetch, _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			If ( Not _alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada Or forceFetch Or _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingFolioTransferenciaSalida, "__MinvTransferenciaAlmacenSalidaEntity__", "MinvTransferenciaAlmacenEntrada_", JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenDestinoFolioMovmientoAlmacen, "MinvTransferenciaAlmacenEntrada_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MinvTransferenciaAlmacenSalidaFieldIndex.FolioTransferencia), ComparisonOperator.Equal, Me.FolioTransferencia))
				_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada.EntityFactoryToUse = entityFactoryToUse
				End If
				_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada.GetMulti(Filter, relations)
				_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada.SuppressClearInGetMulti = False
				_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada = True
			End If
			Return _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada
		End Function

		''' <summary>Sets the collection parameters for the collection for 'InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada'. These settings will be taken into account
		''' when the property InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada is requested or GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada.SortClauses=sortClauses
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'InventarioMovimientoAlmacenEntity'</returns>
		Public Function GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Return GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_(forceFetch, _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			If ( Not _alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ Or forceFetch Or _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingFolioTransferenciaSalida, "__MinvTransferenciaAlmacenSalidaEntity__", "MinvTransferenciaAlmacenEntrada_", JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenDestinoFolioMovmientoAlmacenCancelacion, "MinvTransferenciaAlmacenEntrada_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MinvTransferenciaAlmacenSalidaFieldIndex.FolioTransferencia), ComparisonOperator.Equal, Me.FolioTransferencia))
				_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_.EntityFactoryToUse = entityFactoryToUse
				End If
				_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_.GetMulti(Filter, relations)
				_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_.SuppressClearInGetMulti = False
				_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ = True
			End If
			Return _inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_'. These settings will be taken into account
		''' when the property InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ is requested or GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_.SortClauses=sortClauses
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle(forceFetch, _productoCollectionViaMinvTransferenciaAlmacenSalidaDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle Or forceFetch Or _alwaysFetchProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViaMinvTransferenciaAlmacenSalidaDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViaMinvTransferenciaAlmacenSalidaDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.MinvTransferenciaAlmacenSalidaDetalleEntityUsingFolioTransferencia, "__MinvTransferenciaAlmacenSalidaEntity__", "MinvTransferenciaAlmacenSalidaDetalle_", JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenSalidaDetalleEntity.Relations.ProductoEntityUsingIdProducto, "MinvTransferenciaAlmacenSalidaDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MinvTransferenciaAlmacenSalidaFieldIndex.FolioTransferencia), ComparisonOperator.Equal, Me.FolioTransferencia))
				_productoCollectionViaMinvTransferenciaAlmacenSalidaDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViaMinvTransferenciaAlmacenSalidaDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViaMinvTransferenciaAlmacenSalidaDetalle.GetMulti(Filter, relations)
				_productoCollectionViaMinvTransferenciaAlmacenSalidaDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle = True
			End If
			Return _productoCollectionViaMinvTransferenciaAlmacenSalidaDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle'. These settings will be taken into account
		''' when the property ProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle is requested or GetMultiProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViaMinvTransferenciaAlmacenSalidaDetalle.SortClauses=sortClauses
			_productoCollectionViaMinvTransferenciaAlmacenSalidaDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves the related entity of type 'AlmacenEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'AlmacenEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleAlmacenDestino() As AlmacenEntity
			Return GetSingleAlmacenDestino(False)
		End Function

		''' <summary>Retrieves the related entity of type 'AlmacenEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'AlmacenEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleAlmacenDestino(forceFetch As Boolean) As AlmacenEntity
			If ( Not _alreadyFetchedAlmacenDestino Or forceFetch Or _alwaysFetchAlmacenDestino) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New AlmacenEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(MinvTransferenciaAlmacenSalidaEntity.Relations.AlmacenEntityUsingIdAlmacenDestino) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdAlmacenDestino)
				End If
				If Not _almacenDestinoReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.AlmacenDestino = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), AlmacenEntity)
					End If
					Me.AlmacenDestino = newEntity
					_alreadyFetchedAlmacenDestino = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _almacenDestino
		End Function
	
		''' <summary>Retrieves the related entity of type 'AlmacenEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'AlmacenEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleAlmacenOrigen() As AlmacenEntity
			Return GetSingleAlmacenOrigen(False)
		End Function

		''' <summary>Retrieves the related entity of type 'AlmacenEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'AlmacenEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleAlmacenOrigen(forceFetch As Boolean) As AlmacenEntity
			If ( Not _alreadyFetchedAlmacenOrigen Or forceFetch Or _alwaysFetchAlmacenOrigen) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New AlmacenEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(MinvTransferenciaAlmacenSalidaEntity.Relations.AlmacenEntityUsingIdAlmacenOrigen) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdAlmacenOrigen)
				End If
				If Not _almacenOrigenReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.AlmacenOrigen = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), AlmacenEntity)
					End If
					Me.AlmacenOrigen = newEntity
					_alreadyFetchedAlmacenOrigen = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _almacenOrigen
		End Function
	
		''' <summary>Retrieves the related entity of type 'InventarioMovimientoAlmacenEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'InventarioMovimientoAlmacenEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleInventarioMovimientoAlmacen() As InventarioMovimientoAlmacenEntity
			Return GetSingleInventarioMovimientoAlmacen(False)
		End Function

		''' <summary>Retrieves the related entity of type 'InventarioMovimientoAlmacenEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'InventarioMovimientoAlmacenEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleInventarioMovimientoAlmacen(forceFetch As Boolean) As InventarioMovimientoAlmacenEntity
			If ( Not _alreadyFetchedInventarioMovimientoAlmacen Or forceFetch Or _alwaysFetchInventarioMovimientoAlmacen) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New InventarioMovimientoAlmacenEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(MinvTransferenciaAlmacenSalidaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenOrigenFolioMovimiento) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdAlmacenOrigen, Me.FolioMovimiento)
				End If
				If Not _inventarioMovimientoAlmacenReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.InventarioMovimientoAlmacen = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), InventarioMovimientoAlmacenEntity)
					End If
					Me.InventarioMovimientoAlmacen = newEntity
					_alreadyFetchedInventarioMovimientoAlmacen = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _inventarioMovimientoAlmacen
		End Function
	
		''' <summary>Retrieves the related entity of type 'InventarioMovimientoAlmacenEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'InventarioMovimientoAlmacenEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleInventarioMovimientoAlmacen_() As InventarioMovimientoAlmacenEntity
			Return GetSingleInventarioMovimientoAlmacen_(False)
		End Function

		''' <summary>Retrieves the related entity of type 'InventarioMovimientoAlmacenEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'InventarioMovimientoAlmacenEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleInventarioMovimientoAlmacen_(forceFetch As Boolean) As InventarioMovimientoAlmacenEntity
			If ( Not _alreadyFetchedInventarioMovimientoAlmacen_ Or forceFetch Or _alwaysFetchInventarioMovimientoAlmacen_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New InventarioMovimientoAlmacenEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(MinvTransferenciaAlmacenSalidaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenOrigenFolioMovimientoCancelacion) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdAlmacenOrigen, Me.FolioMovimientoCancelacion)
				End If
				If Not _inventarioMovimientoAlmacen_ReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.InventarioMovimientoAlmacen_ = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), InventarioMovimientoAlmacenEntity)
					End If
					Me.InventarioMovimientoAlmacen_ = newEntity
					_alreadyFetchedInventarioMovimientoAlmacen_ = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _inventarioMovimientoAlmacen_
		End Function
	
	
		
		''' <summary>Sets the field On index fieldIndex To the New value value. Marks also the fields Object As dirty. </summary>
		''' <param name="fieldIndex">Index of field To Set the New value of</param>
		''' <param name="value">Value To Set</param>
		''' <param name="checkForRefetch">If Set To True, it will check If this entity Is out of sync And will refetch it first If it Is. Use True In normal behavior, False For framework specific code.</param>
		''' <returns>True If the value Is actually Set, False otherwise.</returns>
		''' <remarks>Dereferences a related Object In an 1:1/m:1 relation If the field Is an FK field And responsible For the reference of that particular related Object.</remarks>
		''' <exception cref="ArgumentOutOfRangeException">When fieldIndex Is smaller than 0 Or bigger than the number of fields In the fields collection.</exception>
		Protected Overrides Overloads Function SetNewFieldValue(fieldIndex As Integer, value As Object, checkForRefetch As Boolean) As Boolean
			Dim toReturn As Boolean = MyBase.SetNewFieldValue (fieldIndex, value, checkForRefetch, False)			
			If toReturn AndAlso System.Enum.IsDefined(GetType(MinvTransferenciaAlmacenSalidaFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, MinvTransferenciaAlmacenSalidaFieldIndex)

					Case MinvTransferenciaAlmacenSalidaFieldIndex.IdAlmacenDestino
						DesetupSyncAlmacenDestino(True, False)
						_alreadyFetchedAlmacenDestino = False





					Case MinvTransferenciaAlmacenSalidaFieldIndex.IdAlmacenOrigen
						DesetupSyncAlmacenOrigen(True, False)
						_alreadyFetchedAlmacenOrigen = False
						DesetupSyncInventarioMovimientoAlmacen(True, False)
						_alreadyFetchedInventarioMovimientoAlmacen = False
						DesetupSyncInventarioMovimientoAlmacen_(True, False)
						_alreadyFetchedInventarioMovimientoAlmacen_ = False


					Case MinvTransferenciaAlmacenSalidaFieldIndex.FolioMovimiento
						DesetupSyncInventarioMovimientoAlmacen(True, False)
						_alreadyFetchedInventarioMovimientoAlmacen = False
					Case MinvTransferenciaAlmacenSalidaFieldIndex.FolioMovimientoCancelacion
						DesetupSyncInventarioMovimientoAlmacen_(True, False)
						_alreadyFetchedInventarioMovimientoAlmacen_ = False






					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_minvTransferenciaAlmacenEntrada.ActiveContext = MyBase.ActiveContext
			_minvTransferenciaAlmacenSalidaDetalle.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViaMinvTransferenciaAlmacenEntrada.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViaMinvTransferenciaAlmacenEntrada_.ActiveContext = MyBase.ActiveContext
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada.ActiveContext = MyBase.ActiveContext
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaMinvTransferenciaAlmacenSalidaDetalle.ActiveContext = MyBase.ActiveContext
		If Not _almacenDestino Is Nothing Then
				_almacenDestino.ActiveContext = MyBase.ActiveContext
			End If
		If Not _almacenOrigen Is Nothing Then
				_almacenOrigen.ActiveContext = MyBase.ActiveContext
			End If
		If Not _inventarioMovimientoAlmacen Is Nothing Then
				_inventarioMovimientoAlmacen.ActiveContext = MyBase.ActiveContext
			End If
		If Not _inventarioMovimientoAlmacen_ Is Nothing Then
				_inventarioMovimientoAlmacen_.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As MinvTransferenciaAlmacenSalidaDAO = CType(CreateDAOInstance(), MinvTransferenciaAlmacenSalidaDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As MinvTransferenciaAlmacenSalidaDAO = CType(CreateDAOInstance(), MinvTransferenciaAlmacenSalidaDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As MinvTransferenciaAlmacenSalidaDAO = CType(CreateDAOInstance(), MinvTransferenciaAlmacenSalidaDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this MinvTransferenciaAlmacenSalidaEntity</param>
		Protected Overridable Sub InitClassEmpty(validatorToUse As IValidator)
			OnInitializing()
			MyBase.Fields = CreateFields()
			MyBase.IsNew=True
			MyBase.Validator = validatorToUse

			InitClassMembers()
			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Creates entity fields Object For this entity. Used In constructor To setup this entity In a polymorphic scenario.</summary>
		Protected Overridable Function CreateFields() As IEntityFields
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.MinvTransferenciaAlmacenSalidaEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="folioTransferencia">PK value for MinvTransferenciaAlmacenSalida which data should be fetched into this MinvTransferenciaAlmacenSalida Object</param>
		''' <param name="validator">The validator Object for this MinvTransferenciaAlmacenSalidaEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(folioTransferencia As System.String, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(folioTransferencia, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_minvTransferenciaAlmacenEntrada = New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection(New MinvTransferenciaAlmacenEntradaEntityFactory())
			_minvTransferenciaAlmacenEntrada.SetContainingEntityInfo(Me, "MinvTransferenciaAlmacenSalida")
			_alwaysFetchMinvTransferenciaAlmacenEntrada = False
			_alreadyFetchedMinvTransferenciaAlmacenEntrada = False
			_minvTransferenciaAlmacenSalidaDetalle = New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaDetalleCollection(New MinvTransferenciaAlmacenSalidaDetalleEntityFactory())
			_minvTransferenciaAlmacenSalidaDetalle.SetContainingEntityInfo(Me, "MinvTransferenciaAlmacenSalida")
			_alwaysFetchMinvTransferenciaAlmacenSalidaDetalle = False
			_alreadyFetchedMinvTransferenciaAlmacenSalidaDetalle = False
			_almacenCollectionViaMinvTransferenciaAlmacenEntrada = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada = False
			_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada = False
			_almacenCollectionViaMinvTransferenciaAlmacenEntrada_ = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ = False
			_alreadyFetchedAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ = False
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada = New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(New InventarioMovimientoAlmacenEntityFactory())
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada = False
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada = False
			_inventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ = New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(New InventarioMovimientoAlmacenEntityFactory())
			_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ = False
			_alreadyFetchedInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ = False
			_productoCollectionViaMinvTransferenciaAlmacenSalidaDetalle = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle = False
			_alreadyFetchedProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle = False
			_almacenDestino = Nothing
			_almacenDestinoReturnsNewIfNotFound = True
			_alwaysFetchAlmacenDestino = False
			_alreadyFetchedAlmacenDestino = False
			_almacenOrigen = Nothing
			_almacenOrigenReturnsNewIfNotFound = True
			_alwaysFetchAlmacenOrigen = False
			_alreadyFetchedAlmacenOrigen = False
			_inventarioMovimientoAlmacen = Nothing
			_inventarioMovimientoAlmacenReturnsNewIfNotFound = True
			_alwaysFetchInventarioMovimientoAlmacen = False
			_alreadyFetchedInventarioMovimientoAlmacen = False
			_inventarioMovimientoAlmacen_ = Nothing
			_inventarioMovimientoAlmacen_ReturnsNewIfNotFound = True
			_alwaysFetchInventarioMovimientoAlmacen_ = False
			_alreadyFetchedInventarioMovimientoAlmacen_ = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioTransferencia", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdAlmacenDestino", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaMovimiento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCaptura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TotalProductos", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Importe", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdAlmacenOrigen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdUsuarioCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioMovimiento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioMovimientoCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdUsuarioAlta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Entrega", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Recibe", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Observaciones", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Iva", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Total", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _almacenDestino</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncAlmacenDestino(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _almacenDestino, AddressOf OnAlmacenDestinoPropertyChanged, "AlmacenDestino", MinvTransferenciaAlmacenSalidaEntity.Relations.AlmacenEntityUsingIdAlmacenDestino, True, signalRelatedEntity, "MinvTransferenciaAlmacenSalida", resetFKFields, New Integer() { CInt(MinvTransferenciaAlmacenSalidaFieldIndex.IdAlmacenDestino) } )
			_almacenDestino = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _almacenDestino</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncAlmacenDestino(relatedEntity As IEntity)
			DesetupSyncAlmacenDestino(True, True)
			_almacenDestino = CType(relatedEntity, AlmacenEntity)
			MyBase.PerformSetupSyncRelatedEntity( _almacenDestino, AddressOf OnAlmacenDestinoPropertyChanged, "AlmacenDestino", MinvTransferenciaAlmacenSalidaEntity.Relations.AlmacenEntityUsingIdAlmacenDestino, True, _alreadyFetchedAlmacenDestino, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnAlmacenDestinoPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _almacenOrigen</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncAlmacenOrigen(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _almacenOrigen, AddressOf OnAlmacenOrigenPropertyChanged, "AlmacenOrigen", MinvTransferenciaAlmacenSalidaEntity.Relations.AlmacenEntityUsingIdAlmacenOrigen, True, signalRelatedEntity, "MinvTransferenciaAlmacenSalida_", resetFKFields, New Integer() { CInt(MinvTransferenciaAlmacenSalidaFieldIndex.IdAlmacenOrigen) } )
			_almacenOrigen = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _almacenOrigen</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncAlmacenOrigen(relatedEntity As IEntity)
			DesetupSyncAlmacenOrigen(True, True)
			_almacenOrigen = CType(relatedEntity, AlmacenEntity)
			MyBase.PerformSetupSyncRelatedEntity( _almacenOrigen, AddressOf OnAlmacenOrigenPropertyChanged, "AlmacenOrigen", MinvTransferenciaAlmacenSalidaEntity.Relations.AlmacenEntityUsingIdAlmacenOrigen, True, _alreadyFetchedAlmacenOrigen, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnAlmacenOrigenPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _inventarioMovimientoAlmacen</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncInventarioMovimientoAlmacen(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _inventarioMovimientoAlmacen, AddressOf OnInventarioMovimientoAlmacenPropertyChanged, "InventarioMovimientoAlmacen", MinvTransferenciaAlmacenSalidaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenOrigenFolioMovimiento, True, signalRelatedEntity, "MinvTransferenciaAlmacenSalida", resetFKFields, New Integer() { CInt(MinvTransferenciaAlmacenSalidaFieldIndex.IdAlmacenOrigen), CInt(MinvTransferenciaAlmacenSalidaFieldIndex.FolioMovimiento) } )
			_inventarioMovimientoAlmacen = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _inventarioMovimientoAlmacen</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncInventarioMovimientoAlmacen(relatedEntity As IEntity)
			DesetupSyncInventarioMovimientoAlmacen(True, True)
			_inventarioMovimientoAlmacen = CType(relatedEntity, InventarioMovimientoAlmacenEntity)
			MyBase.PerformSetupSyncRelatedEntity( _inventarioMovimientoAlmacen, AddressOf OnInventarioMovimientoAlmacenPropertyChanged, "InventarioMovimientoAlmacen", MinvTransferenciaAlmacenSalidaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenOrigenFolioMovimiento, True, _alreadyFetchedInventarioMovimientoAlmacen, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnInventarioMovimientoAlmacenPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _inventarioMovimientoAlmacen_</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncInventarioMovimientoAlmacen_(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _inventarioMovimientoAlmacen_, AddressOf OnInventarioMovimientoAlmacen_PropertyChanged, "InventarioMovimientoAlmacen_", MinvTransferenciaAlmacenSalidaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenOrigenFolioMovimientoCancelacion, True, signalRelatedEntity, "MinvTransferenciaAlmacenSalida_", resetFKFields, New Integer() { CInt(MinvTransferenciaAlmacenSalidaFieldIndex.IdAlmacenOrigen), CInt(MinvTransferenciaAlmacenSalidaFieldIndex.FolioMovimientoCancelacion) } )
			_inventarioMovimientoAlmacen_ = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _inventarioMovimientoAlmacen_</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncInventarioMovimientoAlmacen_(relatedEntity As IEntity)
			DesetupSyncInventarioMovimientoAlmacen_(True, True)
			_inventarioMovimientoAlmacen_ = CType(relatedEntity, InventarioMovimientoAlmacenEntity)
			MyBase.PerformSetupSyncRelatedEntity( _inventarioMovimientoAlmacen_, AddressOf OnInventarioMovimientoAlmacen_PropertyChanged, "InventarioMovimientoAlmacen_", MinvTransferenciaAlmacenSalidaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenOrigenFolioMovimientoCancelacion, True, _alreadyFetchedInventarioMovimientoAlmacen_, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnInventarioMovimientoAlmacen_PropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="folioTransferencia">PK value for MinvTransferenciaAlmacenSalida which data should be fetched into this MinvTransferenciaAlmacenSalida Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(folioTransferencia As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(MinvTransferenciaAlmacenSalidaFieldIndex.FolioTransferencia)).ForcedCurrentValueWrite(folioTransferencia)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateMinvTransferenciaAlmacenSalidaDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New MinvTransferenciaAlmacenSalidaEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As MinvTransferenciaAlmacenSalidaRelations
			Get	
				Return New MinvTransferenciaAlmacenSalidaRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MinvTransferenciaAlmacenEntrada' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMinvTransferenciaAlmacenEntrada() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection(), _
					MinvTransferenciaAlmacenSalidaEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingFolioTransferenciaSalida, _
					CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenSalidaEntity, Integer), CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenEntradaEntity, Integer), 0, Nothing, Nothing, Nothing, "MinvTransferenciaAlmacenEntrada", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MinvTransferenciaAlmacenSalidaDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMinvTransferenciaAlmacenSalidaDetalle() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaDetalleCollection(), _
					MinvTransferenciaAlmacenSalidaEntity.Relations.MinvTransferenciaAlmacenSalidaDetalleEntityUsingFolioTransferencia, _
					CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenSalidaEntity, Integer), CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenSalidaDetalleEntity, Integer), 0, Nothing, Nothing, Nothing, "MinvTransferenciaAlmacenSalidaDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViaMinvTransferenciaAlmacenEntrada() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingFolioTransferenciaSalida, "__MinvTransferenciaAlmacenSalidaEntity__", String.Empty, JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.AlmacenEntityUsingIdAlmacenDestino)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					MinvTransferenciaAlmacenSalidaEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingFolioTransferenciaSalida, _
					CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenSalidaEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViaMinvTransferenciaAlmacenEntrada", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingFolioTransferenciaSalida, "__MinvTransferenciaAlmacenSalidaEntity__", String.Empty, JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.AlmacenEntityUsingIdAlmacenOrigen)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					MinvTransferenciaAlmacenSalidaEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingFolioTransferenciaSalida, _
					CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenSalidaEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViaMinvTransferenciaAlmacenEntrada_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingFolioTransferenciaSalida, "__MinvTransferenciaAlmacenSalidaEntity__", String.Empty, JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenDestinoFolioMovmientoAlmacen)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					MinvTransferenciaAlmacenSalidaEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingFolioTransferenciaSalida, _
					CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenSalidaEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingFolioTransferenciaSalida, "__MinvTransferenciaAlmacenSalidaEntity__", String.Empty, JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenDestinoFolioMovmientoAlmacenCancelacion)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					MinvTransferenciaAlmacenSalidaEntity.Relations.MinvTransferenciaAlmacenEntradaEntityUsingFolioTransferenciaSalida, _
					CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenSalidaEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, relations, "InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MinvTransferenciaAlmacenSalidaEntity.Relations.MinvTransferenciaAlmacenSalidaDetalleEntityUsingFolioTransferencia, "__MinvTransferenciaAlmacenSalidaEntity__", String.Empty, JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenSalidaDetalleEntity.Relations.ProductoEntityUsingIdProducto)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					MinvTransferenciaAlmacenSalidaEntity.Relations.MinvTransferenciaAlmacenSalidaDetalleEntityUsingFolioTransferencia, _
					CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenSalidaEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenDestino() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					MinvTransferenciaAlmacenSalidaEntity.Relations.AlmacenEntityUsingIdAlmacenDestino, _
					CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenSalidaEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "AlmacenDestino", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenOrigen() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					MinvTransferenciaAlmacenSalidaEntity.Relations.AlmacenEntityUsingIdAlmacenOrigen, _
					CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenSalidaEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "AlmacenOrigen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacen() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					MinvTransferenciaAlmacenSalidaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenOrigenFolioMovimiento, _
					CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenSalidaEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "InventarioMovimientoAlmacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacen_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					MinvTransferenciaAlmacenSalidaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenOrigenFolioMovimientoCancelacion, _
					CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenSalidaEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "InventarioMovimientoAlmacen_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "MinvTransferenciaAlmacenSalidaEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return MinvTransferenciaAlmacenSalidaEntity.CustomProperties
			End Get
		End Property

		''' <summary>The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value
		''' pairs. </summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property FieldsCustomProperties() As Dictionary(Of String, Dictionary(Of String, String))
			Get
				Return _fieldsCustomProperties
			End Get
		End Property

		''' <summary>The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value
		''' pairs. </summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property FieldsCustomPropertiesOfType() As Dictionary(Of String, Dictionary(Of String, String))
			Get
				Return MinvTransferenciaAlmacenSalidaEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The FolioTransferencia property of the Entity MinvTransferenciaAlmacenSalida<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvTransferenciaAlmacenSalida"."FolioTransferencia"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 12<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [FolioTransferencia]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvTransferenciaAlmacenSalidaFieldIndex.FolioTransferencia, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MinvTransferenciaAlmacenSalidaFieldIndex.FolioTransferencia, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdAlmacenDestino property of the Entity MinvTransferenciaAlmacenSalida<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvTransferenciaAlmacenSalida"."IdAlmacenDestino"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdAlmacenDestino]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvTransferenciaAlmacenSalidaFieldIndex.IdAlmacenDestino, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MinvTransferenciaAlmacenSalidaFieldIndex.IdAlmacenDestino, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaMovimiento property of the Entity MinvTransferenciaAlmacenSalida<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvTransferenciaAlmacenSalida"."FechaMovimiento"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaMovimiento]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvTransferenciaAlmacenSalidaFieldIndex.FechaMovimiento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(MinvTransferenciaAlmacenSalidaFieldIndex.FechaMovimiento, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCaptura property of the Entity MinvTransferenciaAlmacenSalida<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvTransferenciaAlmacenSalida"."FechaCaptura"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaCaptura]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvTransferenciaAlmacenSalidaFieldIndex.FechaCaptura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(MinvTransferenciaAlmacenSalidaFieldIndex.FechaCaptura, Integer), value)
			End Set
		End Property
	
		''' <summary>The TotalProductos property of the Entity MinvTransferenciaAlmacenSalida<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvTransferenciaAlmacenSalida"."TotalProductos"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TotalProductos]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvTransferenciaAlmacenSalidaFieldIndex.TotalProductos, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(MinvTransferenciaAlmacenSalidaFieldIndex.TotalProductos, Integer), value)
			End Set
		End Property
	
		''' <summary>The Importe property of the Entity MinvTransferenciaAlmacenSalida<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvTransferenciaAlmacenSalida"."Importe"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Importe]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvTransferenciaAlmacenSalidaFieldIndex.Importe, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(MinvTransferenciaAlmacenSalidaFieldIndex.Importe, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity MinvTransferenciaAlmacenSalida<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvTransferenciaAlmacenSalida"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvTransferenciaAlmacenSalidaFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(MinvTransferenciaAlmacenSalidaFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdAlmacenOrigen property of the Entity MinvTransferenciaAlmacenSalida<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvTransferenciaAlmacenSalida"."IdAlmacenOrigen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdAlmacenOrigen]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvTransferenciaAlmacenSalidaFieldIndex.IdAlmacenOrigen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MinvTransferenciaAlmacenSalidaFieldIndex.IdAlmacenOrigen, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCancelacion property of the Entity MinvTransferenciaAlmacenSalida<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvTransferenciaAlmacenSalida"."FechaCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaCancelacion]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvTransferenciaAlmacenSalidaFieldIndex.FechaCancelacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(MinvTransferenciaAlmacenSalidaFieldIndex.FechaCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdUsuarioCancelacion property of the Entity MinvTransferenciaAlmacenSalida<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvTransferenciaAlmacenSalida"."IdUsuarioCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdUsuarioCancelacion]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvTransferenciaAlmacenSalidaFieldIndex.IdUsuarioCancelacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MinvTransferenciaAlmacenSalidaFieldIndex.IdUsuarioCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioMovimiento property of the Entity MinvTransferenciaAlmacenSalida<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvTransferenciaAlmacenSalida"."FolioMovimiento"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FolioMovimiento]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvTransferenciaAlmacenSalidaFieldIndex.FolioMovimiento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MinvTransferenciaAlmacenSalidaFieldIndex.FolioMovimiento, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioMovimientoCancelacion property of the Entity MinvTransferenciaAlmacenSalida<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvTransferenciaAlmacenSalida"."FolioMovimientoCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FolioMovimientoCancelacion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvTransferenciaAlmacenSalidaFieldIndex.FolioMovimientoCancelacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MinvTransferenciaAlmacenSalidaFieldIndex.FolioMovimientoCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdUsuarioAlta property of the Entity MinvTransferenciaAlmacenSalida<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvTransferenciaAlmacenSalida"."IdUsuarioAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdUsuarioAlta]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvTransferenciaAlmacenSalidaFieldIndex.IdUsuarioAlta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MinvTransferenciaAlmacenSalidaFieldIndex.IdUsuarioAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The Entrega property of the Entity MinvTransferenciaAlmacenSalida<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvTransferenciaAlmacenSalida"."Entrega"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 100<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Entrega]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvTransferenciaAlmacenSalidaFieldIndex.Entrega, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MinvTransferenciaAlmacenSalidaFieldIndex.Entrega, Integer), value)
			End Set
		End Property
	
		''' <summary>The Recibe property of the Entity MinvTransferenciaAlmacenSalida<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvTransferenciaAlmacenSalida"."Recibe"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 100<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Recibe]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvTransferenciaAlmacenSalidaFieldIndex.Recibe, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MinvTransferenciaAlmacenSalidaFieldIndex.Recibe, Integer), value)
			End Set
		End Property
	
		''' <summary>The Observaciones property of the Entity MinvTransferenciaAlmacenSalida<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvTransferenciaAlmacenSalida"."Observaciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 259<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Observaciones]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvTransferenciaAlmacenSalidaFieldIndex.Observaciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MinvTransferenciaAlmacenSalidaFieldIndex.Observaciones, Integer), value)
			End Set
		End Property
	
		''' <summary>The Iva property of the Entity MinvTransferenciaAlmacenSalida<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvTransferenciaAlmacenSalida"."Iva"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Iva]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvTransferenciaAlmacenSalidaFieldIndex.Iva, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(MinvTransferenciaAlmacenSalidaFieldIndex.Iva, Integer), value)
			End Set
		End Property
	
		''' <summary>The Total property of the Entity MinvTransferenciaAlmacenSalida<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvTransferenciaAlmacenSalida"."Total"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Total]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvTransferenciaAlmacenSalidaFieldIndex.Total, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(MinvTransferenciaAlmacenSalidaFieldIndex.Total, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenEntradaEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMinvTransferenciaAlmacenEntrada()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MinvTransferenciaAlmacenEntrada]() As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaCollection
			Get
				Return GetMultiMinvTransferenciaAlmacenEntrada(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MinvTransferenciaAlmacenEntrada. When set to true, MinvTransferenciaAlmacenEntrada is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MinvTransferenciaAlmacenEntrada is accessed. You can always execute
		''' a forced fetch by calling GetMultiMinvTransferenciaAlmacenEntrada(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMinvTransferenciaAlmacenEntrada As Boolean
			Get
				Return _alwaysFetchMinvTransferenciaAlmacenEntrada
			End Get
			Set
				_alwaysFetchMinvTransferenciaAlmacenEntrada = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenSalidaDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMinvTransferenciaAlmacenSalidaDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MinvTransferenciaAlmacenSalidaDetalle]() As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaDetalleCollection
			Get
				Return GetMultiMinvTransferenciaAlmacenSalidaDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MinvTransferenciaAlmacenSalidaDetalle. When set to true, MinvTransferenciaAlmacenSalidaDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MinvTransferenciaAlmacenSalidaDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiMinvTransferenciaAlmacenSalidaDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMinvTransferenciaAlmacenSalidaDetalle As Boolean
			Get
				Return _alwaysFetchMinvTransferenciaAlmacenSalidaDetalle
			End Get
			Set
				_alwaysFetchMinvTransferenciaAlmacenSalidaDetalle = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AlmacenCollectionViaMinvTransferenciaAlmacenEntrada]() As Integralab.ORM.CollectionClasses.AlmacenCollection
			Get
				Return GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AlmacenCollectionViaMinvTransferenciaAlmacenEntrada. When set to true, AlmacenCollectionViaMinvTransferenciaAlmacenEntrada is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AlmacenCollectionViaMinvTransferenciaAlmacenEntrada is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada As Boolean
			Get
				Return _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada
			End Get
			Set
				_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AlmacenCollectionViaMinvTransferenciaAlmacenEntrada_]() As Integralab.ORM.CollectionClasses.AlmacenCollection
			Get
				Return GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AlmacenCollectionViaMinvTransferenciaAlmacenEntrada_. When set to true, AlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ As Boolean
			Get
				Return _alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_
			End Get
			Set
				_alwaysFetchAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada]() As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Get
				Return GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada. When set to true, InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada is accessed. You can always execute
		''' a forced fetch by calling GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada As Boolean
			Get
				Return _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada
			End Get
			Set
				_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'InventarioMovimientoAlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_]() As Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection
			Get
				Return GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_. When set to true, InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time InventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ As Boolean
			Get
				Return _alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_
			End Get
			Set
				_alwaysFetchInventarioMovimientoAlmacenCollectionViaMinvTransferenciaAlmacenEntrada_ = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle. When set to true, ProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle As Boolean
			Get
				Return _alwaysFetchProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle
			End Get
			Set
				_alwaysFetchProductoCollectionViaMinvTransferenciaAlmacenSalidaDetalle = value
			End Set	
		End Property
	
	
		''' <summary>Gets / sets related entity of type 'AlmacenEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleAlmacenDestino()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [AlmacenDestino]() As AlmacenEntity
			Get
				Return GetSingleAlmacenDestino(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncAlmacenDestino(value)
				Else
					If value Is Nothing Then
						If Not _almacenDestino Is Nothing Then
							_almacenDestino.UnsetRelatedEntity(Me, "MinvTransferenciaAlmacenSalida")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "MinvTransferenciaAlmacenSalida")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for AlmacenDestino. When set to true, AlmacenDestino is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AlmacenDestino is accessed. You can always execute
		''' a forced fetch by calling GetSingleAlmacenDestino(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacenDestino As Boolean
			Get
				Return _alwaysFetchAlmacenDestino
			End Get
			Set
				_alwaysFetchAlmacenDestino = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property AlmacenDestino is not found
		''' in the database. When set to true, AlmacenDestino will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property AlmacenDestinoReturnsNewIfNotFound As Boolean
			Get
				Return _almacenDestinoReturnsNewIfNotFound
			End Get
			Set
				_almacenDestinoReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'AlmacenEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleAlmacenOrigen()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [AlmacenOrigen]() As AlmacenEntity
			Get
				Return GetSingleAlmacenOrigen(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncAlmacenOrigen(value)
				Else
					If value Is Nothing Then
						If Not _almacenOrigen Is Nothing Then
							_almacenOrigen.UnsetRelatedEntity(Me, "MinvTransferenciaAlmacenSalida_")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "MinvTransferenciaAlmacenSalida_")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for AlmacenOrigen. When set to true, AlmacenOrigen is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AlmacenOrigen is accessed. You can always execute
		''' a forced fetch by calling GetSingleAlmacenOrigen(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacenOrigen As Boolean
			Get
				Return _alwaysFetchAlmacenOrigen
			End Get
			Set
				_alwaysFetchAlmacenOrigen = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property AlmacenOrigen is not found
		''' in the database. When set to true, AlmacenOrigen will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property AlmacenOrigenReturnsNewIfNotFound As Boolean
			Get
				Return _almacenOrigenReturnsNewIfNotFound
			End Get
			Set
				_almacenOrigenReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'InventarioMovimientoAlmacenEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleInventarioMovimientoAlmacen()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [InventarioMovimientoAlmacen]() As InventarioMovimientoAlmacenEntity
			Get
				Return GetSingleInventarioMovimientoAlmacen(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncInventarioMovimientoAlmacen(value)
				Else
					If value Is Nothing Then
						If Not _inventarioMovimientoAlmacen Is Nothing Then
							_inventarioMovimientoAlmacen.UnsetRelatedEntity(Me, "MinvTransferenciaAlmacenSalida")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "MinvTransferenciaAlmacenSalida")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for InventarioMovimientoAlmacen. When set to true, InventarioMovimientoAlmacen is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time InventarioMovimientoAlmacen is accessed. You can always execute
		''' a forced fetch by calling GetSingleInventarioMovimientoAlmacen(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchInventarioMovimientoAlmacen As Boolean
			Get
				Return _alwaysFetchInventarioMovimientoAlmacen
			End Get
			Set
				_alwaysFetchInventarioMovimientoAlmacen = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property InventarioMovimientoAlmacen is not found
		''' in the database. When set to true, InventarioMovimientoAlmacen will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property InventarioMovimientoAlmacenReturnsNewIfNotFound As Boolean
			Get
				Return _inventarioMovimientoAlmacenReturnsNewIfNotFound
			End Get
			Set
				_inventarioMovimientoAlmacenReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'InventarioMovimientoAlmacenEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleInventarioMovimientoAlmacen_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [InventarioMovimientoAlmacen_]() As InventarioMovimientoAlmacenEntity
			Get
				Return GetSingleInventarioMovimientoAlmacen_(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncInventarioMovimientoAlmacen_(value)
				Else
					If value Is Nothing Then
						If Not _inventarioMovimientoAlmacen_ Is Nothing Then
							_inventarioMovimientoAlmacen_.UnsetRelatedEntity(Me, "MinvTransferenciaAlmacenSalida_")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "MinvTransferenciaAlmacenSalida_")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for InventarioMovimientoAlmacen_. When set to true, InventarioMovimientoAlmacen_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time InventarioMovimientoAlmacen_ is accessed. You can always execute
		''' a forced fetch by calling GetSingleInventarioMovimientoAlmacen_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchInventarioMovimientoAlmacen_ As Boolean
			Get
				Return _alwaysFetchInventarioMovimientoAlmacen_
			End Get
			Set
				_alwaysFetchInventarioMovimientoAlmacen_ = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property InventarioMovimientoAlmacen_ is not found
		''' in the database. When set to true, InventarioMovimientoAlmacen_ will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property InventarioMovimientoAlmacen_ReturnsNewIfNotFound As Boolean
			Get
				Return _inventarioMovimientoAlmacen_ReturnsNewIfNotFound
			End Get
			Set
				_inventarioMovimientoAlmacen_ReturnsNewIfNotFound = value
			End Set	
		End Property
	
	
	
		
		
		''' <summary>Gets the type of the hierarchy this entity Is In. </summary>
		<Browsable(False), XmlIgnore> _
		Protected Overrides ReadOnly Property LLBLGenProIsInHierarchyOfType As InheritanceHierarchyType
			Get 
				Return InheritanceHierarchyType.None
			End Get
		End Property

		''' <summary>Gets Or sets a value indicating whether this entity Is a subtype</summary>
		<Browsable(False), XmlIgnore> _
		Protected Overrides ReadOnly Property LLBLGenProIsSubType As Boolean
			Get 
				Return False
			End Get
		End Property		
		
		''' <summary>Returns the EntityType Enum value For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityTypeValue As Integer
			Get 
				Return CInt(Integralab.ORM.EntityType.MinvTransferenciaAlmacenSalidaEntity)
			End Get
		End Property
#End Region


#Region "Custom Entity Code"
		
		' __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		' __LLBLGENPRO_USER_CODE_REGION_END
#End Region

#Region "Included Code"

#End Region
	End Class
End Namespace
