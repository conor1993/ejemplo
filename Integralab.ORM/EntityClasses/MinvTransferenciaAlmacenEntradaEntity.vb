' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 11 de enero de 2018 10:37:36
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
	''' <summary>Entity class which represents the entity 'MinvTransferenciaAlmacenEntrada'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class MinvTransferenciaAlmacenEntradaEntity 
#Else
	<Serializable()> _
	Public Class MinvTransferenciaAlmacenEntradaEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _minvTransferenciaAlmacenEntradaDetalle As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaDetalleCollection
		Private _alwaysFetchMinvTransferenciaAlmacenEntradaDetalle, _alreadyFetchedMinvTransferenciaAlmacenEntradaDetalle As Boolean
		Private _productoCollectionViaMinvTransferenciaAlmacenEntradaDetalle As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaMinvTransferenciaAlmacenEntradaDetalle, _alreadyFetchedProductoCollectionViaMinvTransferenciaAlmacenEntradaDetalle As Boolean
		Private _almacenDestino As AlmacenEntity
		Private _alwaysFetchAlmacenDestino, _alreadyFetchedAlmacenDestino, _almacenDestinoReturnsNewIfNotFound As Boolean
		Private _almacenOrigen As AlmacenEntity
		Private _alwaysFetchAlmacenOrigen, _alreadyFetchedAlmacenOrigen, _almacenOrigenReturnsNewIfNotFound As Boolean
		Private _inventarioMovimientoAlmacen As InventarioMovimientoAlmacenEntity
		Private _alwaysFetchInventarioMovimientoAlmacen, _alreadyFetchedInventarioMovimientoAlmacen, _inventarioMovimientoAlmacenReturnsNewIfNotFound As Boolean
		Private _inventarioMovimientoAlmacen_ As InventarioMovimientoAlmacenEntity
		Private _alwaysFetchInventarioMovimientoAlmacen_, _alreadyFetchedInventarioMovimientoAlmacen_, _inventarioMovimientoAlmacen_ReturnsNewIfNotFound As Boolean
		Private _minvTransferenciaAlmacenSalida As MinvTransferenciaAlmacenSalidaEntity
		Private _alwaysFetchMinvTransferenciaAlmacenSalida, _alreadyFetchedMinvTransferenciaAlmacenSalida, _minvTransferenciaAlmacenSalidaReturnsNewIfNotFound As Boolean


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
		''' <param name="folioTransferencia">PK value for MinvTransferenciaAlmacenEntrada which data should be fetched into this MinvTransferenciaAlmacenEntrada Object</param>
		Public Sub New(folioTransferencia As System.String)

			InitClassFetch(folioTransferencia, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folioTransferencia">PK value for MinvTransferenciaAlmacenEntrada which data should be fetched into this MinvTransferenciaAlmacenEntrada Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(folioTransferencia As System.String, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(folioTransferencia, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folioTransferencia">PK value for MinvTransferenciaAlmacenEntrada which data should be fetched into this MinvTransferenciaAlmacenEntrada Object</param>
		''' <param name="validator">The custom validator Object for this MinvTransferenciaAlmacenEntradaEntity</param>
		Public Sub New(folioTransferencia As System.String, validator As IValidator)

			InitClassFetch(folioTransferencia, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_minvTransferenciaAlmacenEntradaDetalle = CType(info.GetValue("_minvTransferenciaAlmacenEntradaDetalle", GetType(Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaDetalleCollection)), Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaDetalleCollection)
			_alwaysFetchMinvTransferenciaAlmacenEntradaDetalle = info.GetBoolean("_alwaysFetchMinvTransferenciaAlmacenEntradaDetalle")
			_alreadyFetchedMinvTransferenciaAlmacenEntradaDetalle = info.GetBoolean("_alreadyFetchedMinvTransferenciaAlmacenEntradaDetalle")
			_productoCollectionViaMinvTransferenciaAlmacenEntradaDetalle = CType(info.GetValue("_productoCollectionViaMinvTransferenciaAlmacenEntradaDetalle", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaMinvTransferenciaAlmacenEntradaDetalle = info.GetBoolean("_alwaysFetchProductoCollectionViaMinvTransferenciaAlmacenEntradaDetalle")
			_alreadyFetchedProductoCollectionViaMinvTransferenciaAlmacenEntradaDetalle = info.GetBoolean("_alreadyFetchedProductoCollectionViaMinvTransferenciaAlmacenEntradaDetalle")
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
			_minvTransferenciaAlmacenSalida = CType(info.GetValue("_minvTransferenciaAlmacenSalida", GetType(MinvTransferenciaAlmacenSalidaEntity)), MinvTransferenciaAlmacenSalidaEntity)
			If Not _minvTransferenciaAlmacenSalida Is Nothing Then
				AddHandler _minvTransferenciaAlmacenSalida.AfterSave, AddressOf OnEntityAfterSave
			End If
			_minvTransferenciaAlmacenSalidaReturnsNewIfNotFound = info.GetBoolean("_minvTransferenciaAlmacenSalidaReturnsNewIfNotFound")
			_alwaysFetchMinvTransferenciaAlmacenSalida = info.GetBoolean("_alwaysFetchMinvTransferenciaAlmacenSalida")
			_alreadyFetchedMinvTransferenciaAlmacenSalida = info.GetBoolean("_alreadyFetchedMinvTransferenciaAlmacenSalida")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedMinvTransferenciaAlmacenEntradaDetalle = (_minvTransferenciaAlmacenEntradaDetalle.Count > 0)
			_alreadyFetchedProductoCollectionViaMinvTransferenciaAlmacenEntradaDetalle = (_productoCollectionViaMinvTransferenciaAlmacenEntradaDetalle.Count > 0)
			_alreadyFetchedAlmacenDestino = Not(_almacenDestino Is Nothing)
			_alreadyFetchedAlmacenOrigen = Not(_almacenOrigen Is Nothing)
			_alreadyFetchedInventarioMovimientoAlmacen = Not(_inventarioMovimientoAlmacen Is Nothing)
			_alreadyFetchedInventarioMovimientoAlmacen_ = Not(_inventarioMovimientoAlmacen_ Is Nothing)
			_alreadyFetchedMinvTransferenciaAlmacenSalida = Not(_minvTransferenciaAlmacenSalida Is Nothing)

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
			info.AddValue("_minvTransferenciaAlmacenEntradaDetalle", _minvTransferenciaAlmacenEntradaDetalle)
			info.AddValue("_alwaysFetchMinvTransferenciaAlmacenEntradaDetalle", _alwaysFetchMinvTransferenciaAlmacenEntradaDetalle)
			info.AddValue("_alreadyFetchedMinvTransferenciaAlmacenEntradaDetalle", _alreadyFetchedMinvTransferenciaAlmacenEntradaDetalle)
			info.AddValue("_productoCollectionViaMinvTransferenciaAlmacenEntradaDetalle", _productoCollectionViaMinvTransferenciaAlmacenEntradaDetalle)
			info.AddValue("_alwaysFetchProductoCollectionViaMinvTransferenciaAlmacenEntradaDetalle", _alwaysFetchProductoCollectionViaMinvTransferenciaAlmacenEntradaDetalle)
			info.AddValue("_alreadyFetchedProductoCollectionViaMinvTransferenciaAlmacenEntradaDetalle", _alreadyFetchedProductoCollectionViaMinvTransferenciaAlmacenEntradaDetalle)
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
			info.AddValue("_minvTransferenciaAlmacenSalida", _minvTransferenciaAlmacenSalida)
			info.AddValue("_minvTransferenciaAlmacenSalidaReturnsNewIfNotFound", _minvTransferenciaAlmacenSalidaReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMinvTransferenciaAlmacenSalida", _alwaysFetchMinvTransferenciaAlmacenSalida)
			info.AddValue("_alreadyFetchedMinvTransferenciaAlmacenSalida", _alreadyFetchedMinvTransferenciaAlmacenSalida)

			
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
				Case "MinvTransferenciaAlmacenSalida"
					_alreadyFetchedMinvTransferenciaAlmacenSalida = True
					Me.MinvTransferenciaAlmacenSalida = CType(entity, MinvTransferenciaAlmacenSalidaEntity)
				Case "MinvTransferenciaAlmacenEntradaDetalle"
					_alreadyFetchedMinvTransferenciaAlmacenEntradaDetalle = True
					If Not entity Is Nothing Then
						Me.MinvTransferenciaAlmacenEntradaDetalle.Add(CType(entity, MinvTransferenciaAlmacenEntradaDetalleEntity))
					End If
				Case "ProductoCollectionViaMinvTransferenciaAlmacenEntradaDetalle"
					_alreadyFetchedProductoCollectionViaMinvTransferenciaAlmacenEntradaDetalle = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaMinvTransferenciaAlmacenEntradaDetalle.Add(CType(entity, ProductoEntity))
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
				Case "MinvTransferenciaAlmacenSalida"
					SetupSyncMinvTransferenciaAlmacenSalida(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MinvTransferenciaAlmacenEntradaDetalle"
					_minvTransferenciaAlmacenEntradaDetalle.Add(CType(relatedEntity, MinvTransferenciaAlmacenEntradaDetalleEntity))
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
				Case "MinvTransferenciaAlmacenSalida"
					DesetupSyncMinvTransferenciaAlmacenSalida(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MinvTransferenciaAlmacenEntradaDetalle"
					MyBase.PerformRelatedEntityRemoval(_minvTransferenciaAlmacenEntradaDetalle, relatedEntity, signalRelatedEntityManyToOne)
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
			If Not _minvTransferenciaAlmacenSalida Is Nothing Then
				toReturn.Add(_minvTransferenciaAlmacenSalida)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_minvTransferenciaAlmacenEntradaDetalle)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folioTransferencia">PK value for MinvTransferenciaAlmacenEntrada which data should be fetched into this MinvTransferenciaAlmacenEntrada Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folioTransferencia As System.String) As Boolean
			Return FetchUsingPK(folioTransferencia, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folioTransferencia">PK value for MinvTransferenciaAlmacenEntrada which data should be fetched into this MinvTransferenciaAlmacenEntrada Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folioTransferencia As System.String, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(folioTransferencia, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folioTransferencia">PK value for MinvTransferenciaAlmacenEntrada which data should be fetched into this MinvTransferenciaAlmacenEntrada Object</param>
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As MinvTransferenciaAlmacenEntradaFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As MinvTransferenciaAlmacenEntradaFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenEntradaDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MinvTransferenciaAlmacenEntradaDetalleEntity'</returns>
		Public Function GetMultiMinvTransferenciaAlmacenEntradaDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaDetalleCollection
			Return GetMultiMinvTransferenciaAlmacenEntradaDetalle(forceFetch, _minvTransferenciaAlmacenEntradaDetalle.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenEntradaDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMinvTransferenciaAlmacenEntradaDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaDetalleCollection
			Return GetMultiMinvTransferenciaAlmacenEntradaDetalle(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenEntradaDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MinvTransferenciaAlmacenEntradaDetalleEntity'</returns>
		Public Function GetMultiMinvTransferenciaAlmacenEntradaDetalle(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaDetalleCollection
			Return GetMultiMinvTransferenciaAlmacenEntradaDetalle(forceFetch, _minvTransferenciaAlmacenEntradaDetalle.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenEntradaDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMinvTransferenciaAlmacenEntradaDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaDetalleCollection
			If ( Not _alreadyFetchedMinvTransferenciaAlmacenEntradaDetalle Or forceFetch Or _alwaysFetchMinvTransferenciaAlmacenEntradaDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _minvTransferenciaAlmacenEntradaDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_minvTransferenciaAlmacenEntradaDetalle)
					End If
				End If
				_minvTransferenciaAlmacenEntradaDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_minvTransferenciaAlmacenEntradaDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_minvTransferenciaAlmacenEntradaDetalle.GetMultiManyToOne(Nothing, Me, Filter)
				_minvTransferenciaAlmacenEntradaDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedMinvTransferenciaAlmacenEntradaDetalle = True
			End If
			Return _minvTransferenciaAlmacenEntradaDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MinvTransferenciaAlmacenEntradaDetalle'. These settings will be taken into account
		''' when the property MinvTransferenciaAlmacenEntradaDetalle is requested or GetMultiMinvTransferenciaAlmacenEntradaDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMinvTransferenciaAlmacenEntradaDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_minvTransferenciaAlmacenEntradaDetalle.SortClauses=sortClauses
			_minvTransferenciaAlmacenEntradaDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViaMinvTransferenciaAlmacenEntradaDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViaMinvTransferenciaAlmacenEntradaDetalle(forceFetch, _productoCollectionViaMinvTransferenciaAlmacenEntradaDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViaMinvTransferenciaAlmacenEntradaDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViaMinvTransferenciaAlmacenEntradaDetalle Or forceFetch Or _alwaysFetchProductoCollectionViaMinvTransferenciaAlmacenEntradaDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViaMinvTransferenciaAlmacenEntradaDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViaMinvTransferenciaAlmacenEntradaDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.MinvTransferenciaAlmacenEntradaDetalleEntityUsingFolioTransferencia, "__MinvTransferenciaAlmacenEntradaEntity__", "MinvTransferenciaAlmacenEntradaDetalle_", JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenEntradaDetalleEntity.Relations.ProductoEntityUsingIdProducto, "MinvTransferenciaAlmacenEntradaDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MinvTransferenciaAlmacenEntradaFieldIndex.FolioTransferencia), ComparisonOperator.Equal, Me.FolioTransferencia))
				_productoCollectionViaMinvTransferenciaAlmacenEntradaDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViaMinvTransferenciaAlmacenEntradaDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViaMinvTransferenciaAlmacenEntradaDetalle.GetMulti(Filter, relations)
				_productoCollectionViaMinvTransferenciaAlmacenEntradaDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViaMinvTransferenciaAlmacenEntradaDetalle = True
			End If
			Return _productoCollectionViaMinvTransferenciaAlmacenEntradaDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViaMinvTransferenciaAlmacenEntradaDetalle'. These settings will be taken into account
		''' when the property ProductoCollectionViaMinvTransferenciaAlmacenEntradaDetalle is requested or GetMultiProductoCollectionViaMinvTransferenciaAlmacenEntradaDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViaMinvTransferenciaAlmacenEntradaDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViaMinvTransferenciaAlmacenEntradaDetalle.SortClauses=sortClauses
			_productoCollectionViaMinvTransferenciaAlmacenEntradaDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				If MyBase.CheckIfLazyLoadingShouldOccur(MinvTransferenciaAlmacenEntradaEntity.Relations.AlmacenEntityUsingIdAlmacenDestino) Then
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
				If MyBase.CheckIfLazyLoadingShouldOccur(MinvTransferenciaAlmacenEntradaEntity.Relations.AlmacenEntityUsingIdAlmacenOrigen) Then
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
				If MyBase.CheckIfLazyLoadingShouldOccur(MinvTransferenciaAlmacenEntradaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenDestinoFolioMovmientoAlmacen) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdAlmacenDestino, Me.FolioMovmientoAlmacen)
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
				If MyBase.CheckIfLazyLoadingShouldOccur(MinvTransferenciaAlmacenEntradaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenDestinoFolioMovmientoAlmacenCancelacion) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdAlmacenDestino, Me.FolioMovmientoAlmacenCancelacion)
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
	
		''' <summary>Retrieves the related entity of type 'MinvTransferenciaAlmacenSalidaEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'MinvTransferenciaAlmacenSalidaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMinvTransferenciaAlmacenSalida() As MinvTransferenciaAlmacenSalidaEntity
			Return GetSingleMinvTransferenciaAlmacenSalida(False)
		End Function

		''' <summary>Retrieves the related entity of type 'MinvTransferenciaAlmacenSalidaEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'MinvTransferenciaAlmacenSalidaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMinvTransferenciaAlmacenSalida(forceFetch As Boolean) As MinvTransferenciaAlmacenSalidaEntity
			If ( Not _alreadyFetchedMinvTransferenciaAlmacenSalida Or forceFetch Or _alwaysFetchMinvTransferenciaAlmacenSalida) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New MinvTransferenciaAlmacenSalidaEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(MinvTransferenciaAlmacenEntradaEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingFolioTransferenciaSalida) Then
					fetchResult = newEntity.FetchUsingPK(Me.FolioTransferenciaSalida)
				End If
				If Not _minvTransferenciaAlmacenSalidaReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.MinvTransferenciaAlmacenSalida = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), MinvTransferenciaAlmacenSalidaEntity)
					End If
					Me.MinvTransferenciaAlmacenSalida = newEntity
					_alreadyFetchedMinvTransferenciaAlmacenSalida = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _minvTransferenciaAlmacenSalida
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(MinvTransferenciaAlmacenEntradaFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, MinvTransferenciaAlmacenEntradaFieldIndex)

					Case MinvTransferenciaAlmacenEntradaFieldIndex.IdAlmacenDestino
						DesetupSyncAlmacenDestino(True, False)
						_alreadyFetchedAlmacenDestino = False
						DesetupSyncInventarioMovimientoAlmacen(True, False)
						_alreadyFetchedInventarioMovimientoAlmacen = False
						DesetupSyncInventarioMovimientoAlmacen_(True, False)
						_alreadyFetchedInventarioMovimientoAlmacen_ = False





					Case MinvTransferenciaAlmacenEntradaFieldIndex.IdAlmacenOrigen
						DesetupSyncAlmacenOrigen(True, False)
						_alreadyFetchedAlmacenOrigen = False


					Case MinvTransferenciaAlmacenEntradaFieldIndex.FolioTransferenciaSalida
						DesetupSyncMinvTransferenciaAlmacenSalida(True, False)
						_alreadyFetchedMinvTransferenciaAlmacenSalida = False
					Case MinvTransferenciaAlmacenEntradaFieldIndex.FolioMovmientoAlmacen
						DesetupSyncInventarioMovimientoAlmacen(True, False)
						_alreadyFetchedInventarioMovimientoAlmacen = False
					Case MinvTransferenciaAlmacenEntradaFieldIndex.FolioMovmientoAlmacenCancelacion
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
			_minvTransferenciaAlmacenEntradaDetalle.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaMinvTransferenciaAlmacenEntradaDetalle.ActiveContext = MyBase.ActiveContext
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
		If Not _minvTransferenciaAlmacenSalida Is Nothing Then
				_minvTransferenciaAlmacenSalida.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As MinvTransferenciaAlmacenEntradaDAO = CType(CreateDAOInstance(), MinvTransferenciaAlmacenEntradaDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As MinvTransferenciaAlmacenEntradaDAO = CType(CreateDAOInstance(), MinvTransferenciaAlmacenEntradaDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As MinvTransferenciaAlmacenEntradaDAO = CType(CreateDAOInstance(), MinvTransferenciaAlmacenEntradaDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this MinvTransferenciaAlmacenEntradaEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.MinvTransferenciaAlmacenEntradaEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="folioTransferencia">PK value for MinvTransferenciaAlmacenEntrada which data should be fetched into this MinvTransferenciaAlmacenEntrada Object</param>
		''' <param name="validator">The validator Object for this MinvTransferenciaAlmacenEntradaEntity</param>
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
			_minvTransferenciaAlmacenEntradaDetalle = New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaDetalleCollection(New MinvTransferenciaAlmacenEntradaDetalleEntityFactory())
			_minvTransferenciaAlmacenEntradaDetalle.SetContainingEntityInfo(Me, "MinvTransferenciaAlmacenEntrada")
			_alwaysFetchMinvTransferenciaAlmacenEntradaDetalle = False
			_alreadyFetchedMinvTransferenciaAlmacenEntradaDetalle = False
			_productoCollectionViaMinvTransferenciaAlmacenEntradaDetalle = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaMinvTransferenciaAlmacenEntradaDetalle = False
			_alreadyFetchedProductoCollectionViaMinvTransferenciaAlmacenEntradaDetalle = False
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
			_minvTransferenciaAlmacenSalida = Nothing
			_minvTransferenciaAlmacenSalidaReturnsNewIfNotFound = True
			_alwaysFetchMinvTransferenciaAlmacenSalida = False
			_alreadyFetchedMinvTransferenciaAlmacenSalida = False

			
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

			_fieldsCustomProperties.Add("FolioTransferenciaSalida", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioMovmientoAlmacen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioMovmientoAlmacenCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdUsuarioAlta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Entrega", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Recibe", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Observaciones", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _almacenDestino</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncAlmacenDestino(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _almacenDestino, AddressOf OnAlmacenDestinoPropertyChanged, "AlmacenDestino", MinvTransferenciaAlmacenEntradaEntity.Relations.AlmacenEntityUsingIdAlmacenDestino, True, signalRelatedEntity, "MinvTransferenciaAlmacenEntrada", resetFKFields, New Integer() { CInt(MinvTransferenciaAlmacenEntradaFieldIndex.IdAlmacenDestino) } )
			_almacenDestino = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _almacenDestino</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncAlmacenDestino(relatedEntity As IEntity)
			DesetupSyncAlmacenDestino(True, True)
			_almacenDestino = CType(relatedEntity, AlmacenEntity)
			MyBase.PerformSetupSyncRelatedEntity( _almacenDestino, AddressOf OnAlmacenDestinoPropertyChanged, "AlmacenDestino", MinvTransferenciaAlmacenEntradaEntity.Relations.AlmacenEntityUsingIdAlmacenDestino, True, _alreadyFetchedAlmacenDestino, New String() {  } )
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
			MyBase.PerformDesetupSyncRelatedEntity( _almacenOrigen, AddressOf OnAlmacenOrigenPropertyChanged, "AlmacenOrigen", MinvTransferenciaAlmacenEntradaEntity.Relations.AlmacenEntityUsingIdAlmacenOrigen, True, signalRelatedEntity, "MinvTransferenciaAlmacenEntrada_", resetFKFields, New Integer() { CInt(MinvTransferenciaAlmacenEntradaFieldIndex.IdAlmacenOrigen) } )
			_almacenOrigen = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _almacenOrigen</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncAlmacenOrigen(relatedEntity As IEntity)
			DesetupSyncAlmacenOrigen(True, True)
			_almacenOrigen = CType(relatedEntity, AlmacenEntity)
			MyBase.PerformSetupSyncRelatedEntity( _almacenOrigen, AddressOf OnAlmacenOrigenPropertyChanged, "AlmacenOrigen", MinvTransferenciaAlmacenEntradaEntity.Relations.AlmacenEntityUsingIdAlmacenOrigen, True, _alreadyFetchedAlmacenOrigen, New String() {  } )
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
			MyBase.PerformDesetupSyncRelatedEntity( _inventarioMovimientoAlmacen, AddressOf OnInventarioMovimientoAlmacenPropertyChanged, "InventarioMovimientoAlmacen", MinvTransferenciaAlmacenEntradaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenDestinoFolioMovmientoAlmacen, True, signalRelatedEntity, "MinvTransferenciaAlmacenEntrada", resetFKFields, New Integer() { CInt(MinvTransferenciaAlmacenEntradaFieldIndex.IdAlmacenDestino), CInt(MinvTransferenciaAlmacenEntradaFieldIndex.FolioMovmientoAlmacen) } )
			_inventarioMovimientoAlmacen = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _inventarioMovimientoAlmacen</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncInventarioMovimientoAlmacen(relatedEntity As IEntity)
			DesetupSyncInventarioMovimientoAlmacen(True, True)
			_inventarioMovimientoAlmacen = CType(relatedEntity, InventarioMovimientoAlmacenEntity)
			MyBase.PerformSetupSyncRelatedEntity( _inventarioMovimientoAlmacen, AddressOf OnInventarioMovimientoAlmacenPropertyChanged, "InventarioMovimientoAlmacen", MinvTransferenciaAlmacenEntradaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenDestinoFolioMovmientoAlmacen, True, _alreadyFetchedInventarioMovimientoAlmacen, New String() {  } )
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
			MyBase.PerformDesetupSyncRelatedEntity( _inventarioMovimientoAlmacen_, AddressOf OnInventarioMovimientoAlmacen_PropertyChanged, "InventarioMovimientoAlmacen_", MinvTransferenciaAlmacenEntradaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenDestinoFolioMovmientoAlmacenCancelacion, True, signalRelatedEntity, "MinvTransferenciaAlmacenEntrada_", resetFKFields, New Integer() { CInt(MinvTransferenciaAlmacenEntradaFieldIndex.IdAlmacenDestino), CInt(MinvTransferenciaAlmacenEntradaFieldIndex.FolioMovmientoAlmacenCancelacion) } )
			_inventarioMovimientoAlmacen_ = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _inventarioMovimientoAlmacen_</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncInventarioMovimientoAlmacen_(relatedEntity As IEntity)
			DesetupSyncInventarioMovimientoAlmacen_(True, True)
			_inventarioMovimientoAlmacen_ = CType(relatedEntity, InventarioMovimientoAlmacenEntity)
			MyBase.PerformSetupSyncRelatedEntity( _inventarioMovimientoAlmacen_, AddressOf OnInventarioMovimientoAlmacen_PropertyChanged, "InventarioMovimientoAlmacen_", MinvTransferenciaAlmacenEntradaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenDestinoFolioMovmientoAlmacenCancelacion, True, _alreadyFetchedInventarioMovimientoAlmacen_, New String() {  } )
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
		''' <summary>Removes the sync logic for member _minvTransferenciaAlmacenSalida</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMinvTransferenciaAlmacenSalida(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _minvTransferenciaAlmacenSalida, AddressOf OnMinvTransferenciaAlmacenSalidaPropertyChanged, "MinvTransferenciaAlmacenSalida", MinvTransferenciaAlmacenEntradaEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingFolioTransferenciaSalida, True, signalRelatedEntity, "MinvTransferenciaAlmacenEntrada", resetFKFields, New Integer() { CInt(MinvTransferenciaAlmacenEntradaFieldIndex.FolioTransferenciaSalida) } )
			_minvTransferenciaAlmacenSalida = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _minvTransferenciaAlmacenSalida</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMinvTransferenciaAlmacenSalida(relatedEntity As IEntity)
			DesetupSyncMinvTransferenciaAlmacenSalida(True, True)
			_minvTransferenciaAlmacenSalida = CType(relatedEntity, MinvTransferenciaAlmacenSalidaEntity)
			MyBase.PerformSetupSyncRelatedEntity( _minvTransferenciaAlmacenSalida, AddressOf OnMinvTransferenciaAlmacenSalidaPropertyChanged, "MinvTransferenciaAlmacenSalida", MinvTransferenciaAlmacenEntradaEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingFolioTransferenciaSalida, True, _alreadyFetchedMinvTransferenciaAlmacenSalida, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMinvTransferenciaAlmacenSalidaPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="folioTransferencia">PK value for MinvTransferenciaAlmacenEntrada which data should be fetched into this MinvTransferenciaAlmacenEntrada Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(folioTransferencia As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(MinvTransferenciaAlmacenEntradaFieldIndex.FolioTransferencia)).ForcedCurrentValueWrite(folioTransferencia)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateMinvTransferenciaAlmacenEntradaDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New MinvTransferenciaAlmacenEntradaEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As MinvTransferenciaAlmacenEntradaRelations
			Get	
				Return New MinvTransferenciaAlmacenEntradaRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MinvTransferenciaAlmacenEntradaDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMinvTransferenciaAlmacenEntradaDetalle() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaDetalleCollection(), _
					MinvTransferenciaAlmacenEntradaEntity.Relations.MinvTransferenciaAlmacenEntradaDetalleEntityUsingFolioTransferencia, _
					CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenEntradaEntity, Integer), CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenEntradaDetalleEntity, Integer), 0, Nothing, Nothing, Nothing, "MinvTransferenciaAlmacenEntradaDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaMinvTransferenciaAlmacenEntradaDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MinvTransferenciaAlmacenEntradaEntity.Relations.MinvTransferenciaAlmacenEntradaDetalleEntityUsingFolioTransferencia, "__MinvTransferenciaAlmacenEntradaEntity__", String.Empty, JoinHint.None)
				relations.Add(MinvTransferenciaAlmacenEntradaDetalleEntity.Relations.ProductoEntityUsingIdProducto)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					MinvTransferenciaAlmacenEntradaEntity.Relations.MinvTransferenciaAlmacenEntradaDetalleEntityUsingFolioTransferencia, _
					CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenEntradaEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaMinvTransferenciaAlmacenEntradaDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenDestino() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					MinvTransferenciaAlmacenEntradaEntity.Relations.AlmacenEntityUsingIdAlmacenDestino, _
					CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenEntradaEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "AlmacenDestino", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenOrigen() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					MinvTransferenciaAlmacenEntradaEntity.Relations.AlmacenEntityUsingIdAlmacenOrigen, _
					CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenEntradaEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "AlmacenOrigen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacen() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					MinvTransferenciaAlmacenEntradaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenDestinoFolioMovmientoAlmacen, _
					CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenEntradaEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "InventarioMovimientoAlmacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacen_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					MinvTransferenciaAlmacenEntradaEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenDestinoFolioMovmientoAlmacenCancelacion, _
					CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenEntradaEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "InventarioMovimientoAlmacen_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MinvTransferenciaAlmacenSalida' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMinvTransferenciaAlmacenSalida() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenSalidaCollection(), _
					MinvTransferenciaAlmacenEntradaEntity.Relations.MinvTransferenciaAlmacenSalidaEntityUsingFolioTransferenciaSalida, _
					CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenEntradaEntity, Integer), CType(Integralab.ORM.EntityType.MinvTransferenciaAlmacenSalidaEntity, Integer), 0, Nothing, Nothing, Nothing, "MinvTransferenciaAlmacenSalida", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "MinvTransferenciaAlmacenEntradaEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return MinvTransferenciaAlmacenEntradaEntity.CustomProperties
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
				Return MinvTransferenciaAlmacenEntradaEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The FolioTransferencia property of the Entity MinvTransferenciaAlmacenEntrada<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvTransferenciaAlmacenEntrada"."FolioTransferencia"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 12<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [FolioTransferencia]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvTransferenciaAlmacenEntradaFieldIndex.FolioTransferencia, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MinvTransferenciaAlmacenEntradaFieldIndex.FolioTransferencia, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdAlmacenDestino property of the Entity MinvTransferenciaAlmacenEntrada<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvTransferenciaAlmacenEntrada"."IdAlmacenDestino"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdAlmacenDestino]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvTransferenciaAlmacenEntradaFieldIndex.IdAlmacenDestino, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MinvTransferenciaAlmacenEntradaFieldIndex.IdAlmacenDestino, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaMovimiento property of the Entity MinvTransferenciaAlmacenEntrada<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvTransferenciaAlmacenEntrada"."FechaMovimiento"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaMovimiento]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvTransferenciaAlmacenEntradaFieldIndex.FechaMovimiento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(MinvTransferenciaAlmacenEntradaFieldIndex.FechaMovimiento, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCaptura property of the Entity MinvTransferenciaAlmacenEntrada<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvTransferenciaAlmacenEntrada"."FechaCaptura"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaCaptura]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvTransferenciaAlmacenEntradaFieldIndex.FechaCaptura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(MinvTransferenciaAlmacenEntradaFieldIndex.FechaCaptura, Integer), value)
			End Set
		End Property
	
		''' <summary>The TotalProductos property of the Entity MinvTransferenciaAlmacenEntrada<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvTransferenciaAlmacenEntrada"."TotalProductos"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TotalProductos]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvTransferenciaAlmacenEntradaFieldIndex.TotalProductos, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(MinvTransferenciaAlmacenEntradaFieldIndex.TotalProductos, Integer), value)
			End Set
		End Property
	
		''' <summary>The Importe property of the Entity MinvTransferenciaAlmacenEntrada<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvTransferenciaAlmacenEntrada"."Importe"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Importe]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvTransferenciaAlmacenEntradaFieldIndex.Importe, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(MinvTransferenciaAlmacenEntradaFieldIndex.Importe, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity MinvTransferenciaAlmacenEntrada<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvTransferenciaAlmacenEntrada"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvTransferenciaAlmacenEntradaFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(MinvTransferenciaAlmacenEntradaFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdAlmacenOrigen property of the Entity MinvTransferenciaAlmacenEntrada<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvTransferenciaAlmacenEntrada"."IdAlmacenOrigen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdAlmacenOrigen]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvTransferenciaAlmacenEntradaFieldIndex.IdAlmacenOrigen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MinvTransferenciaAlmacenEntradaFieldIndex.IdAlmacenOrigen, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCancelacion property of the Entity MinvTransferenciaAlmacenEntrada<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvTransferenciaAlmacenEntrada"."FechaCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaCancelacion]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvTransferenciaAlmacenEntradaFieldIndex.FechaCancelacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(MinvTransferenciaAlmacenEntradaFieldIndex.FechaCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdUsuarioCancelacion property of the Entity MinvTransferenciaAlmacenEntrada<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvTransferenciaAlmacenEntrada"."IdUsuarioCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdUsuarioCancelacion]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvTransferenciaAlmacenEntradaFieldIndex.IdUsuarioCancelacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MinvTransferenciaAlmacenEntradaFieldIndex.IdUsuarioCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioTransferenciaSalida property of the Entity MinvTransferenciaAlmacenEntrada<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvTransferenciaAlmacenEntrada"."FolioTransferenciaSalida"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 12<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FolioTransferenciaSalida]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvTransferenciaAlmacenEntradaFieldIndex.FolioTransferenciaSalida, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MinvTransferenciaAlmacenEntradaFieldIndex.FolioTransferenciaSalida, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioMovmientoAlmacen property of the Entity MinvTransferenciaAlmacenEntrada<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvTransferenciaAlmacenEntrada"."FolioMovmientoAlmacen"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FolioMovmientoAlmacen]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvTransferenciaAlmacenEntradaFieldIndex.FolioMovmientoAlmacen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MinvTransferenciaAlmacenEntradaFieldIndex.FolioMovmientoAlmacen, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioMovmientoAlmacenCancelacion property of the Entity MinvTransferenciaAlmacenEntrada<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvTransferenciaAlmacenEntrada"."FolioMovmientoAlmacenCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FolioMovmientoAlmacenCancelacion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvTransferenciaAlmacenEntradaFieldIndex.FolioMovmientoAlmacenCancelacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MinvTransferenciaAlmacenEntradaFieldIndex.FolioMovmientoAlmacenCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdUsuarioAlta property of the Entity MinvTransferenciaAlmacenEntrada<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvTransferenciaAlmacenEntrada"."IdUsuarioAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdUsuarioAlta]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvTransferenciaAlmacenEntradaFieldIndex.IdUsuarioAlta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MinvTransferenciaAlmacenEntradaFieldIndex.IdUsuarioAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The Entrega property of the Entity MinvTransferenciaAlmacenEntrada<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvTransferenciaAlmacenEntrada"."Entrega"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 100<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Entrega]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvTransferenciaAlmacenEntradaFieldIndex.Entrega, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MinvTransferenciaAlmacenEntradaFieldIndex.Entrega, Integer), value)
			End Set
		End Property
	
		''' <summary>The Recibe property of the Entity MinvTransferenciaAlmacenEntrada<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvTransferenciaAlmacenEntrada"."Recibe"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 100<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Recibe]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvTransferenciaAlmacenEntradaFieldIndex.Recibe, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MinvTransferenciaAlmacenEntradaFieldIndex.Recibe, Integer), value)
			End Set
		End Property
	
		''' <summary>The Observaciones property of the Entity MinvTransferenciaAlmacenEntrada<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvTransferenciaAlmacenEntrada"."Observaciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Observaciones]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvTransferenciaAlmacenEntradaFieldIndex.Observaciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MinvTransferenciaAlmacenEntradaFieldIndex.Observaciones, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'MinvTransferenciaAlmacenEntradaDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMinvTransferenciaAlmacenEntradaDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MinvTransferenciaAlmacenEntradaDetalle]() As Integralab.ORM.CollectionClasses.MinvTransferenciaAlmacenEntradaDetalleCollection
			Get
				Return GetMultiMinvTransferenciaAlmacenEntradaDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MinvTransferenciaAlmacenEntradaDetalle. When set to true, MinvTransferenciaAlmacenEntradaDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MinvTransferenciaAlmacenEntradaDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiMinvTransferenciaAlmacenEntradaDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMinvTransferenciaAlmacenEntradaDetalle As Boolean
			Get
				Return _alwaysFetchMinvTransferenciaAlmacenEntradaDetalle
			End Get
			Set
				_alwaysFetchMinvTransferenciaAlmacenEntradaDetalle = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViaMinvTransferenciaAlmacenEntradaDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViaMinvTransferenciaAlmacenEntradaDetalle]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViaMinvTransferenciaAlmacenEntradaDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViaMinvTransferenciaAlmacenEntradaDetalle. When set to true, ProductoCollectionViaMinvTransferenciaAlmacenEntradaDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViaMinvTransferenciaAlmacenEntradaDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViaMinvTransferenciaAlmacenEntradaDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViaMinvTransferenciaAlmacenEntradaDetalle As Boolean
			Get
				Return _alwaysFetchProductoCollectionViaMinvTransferenciaAlmacenEntradaDetalle
			End Get
			Set
				_alwaysFetchProductoCollectionViaMinvTransferenciaAlmacenEntradaDetalle = value
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
							_almacenDestino.UnsetRelatedEntity(Me, "MinvTransferenciaAlmacenEntrada")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "MinvTransferenciaAlmacenEntrada")
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
							_almacenOrigen.UnsetRelatedEntity(Me, "MinvTransferenciaAlmacenEntrada_")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "MinvTransferenciaAlmacenEntrada_")
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
							_inventarioMovimientoAlmacen.UnsetRelatedEntity(Me, "MinvTransferenciaAlmacenEntrada")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "MinvTransferenciaAlmacenEntrada")
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
							_inventarioMovimientoAlmacen_.UnsetRelatedEntity(Me, "MinvTransferenciaAlmacenEntrada_")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "MinvTransferenciaAlmacenEntrada_")
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
	
		''' <summary>Gets / sets related entity of type 'MinvTransferenciaAlmacenSalidaEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMinvTransferenciaAlmacenSalida()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [MinvTransferenciaAlmacenSalida]() As MinvTransferenciaAlmacenSalidaEntity
			Get
				Return GetSingleMinvTransferenciaAlmacenSalida(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMinvTransferenciaAlmacenSalida(value)
				Else
					If value Is Nothing Then
						If Not _minvTransferenciaAlmacenSalida Is Nothing Then
							_minvTransferenciaAlmacenSalida.UnsetRelatedEntity(Me, "MinvTransferenciaAlmacenEntrada")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "MinvTransferenciaAlmacenEntrada")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for MinvTransferenciaAlmacenSalida. When set to true, MinvTransferenciaAlmacenSalida is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MinvTransferenciaAlmacenSalida is accessed. You can always execute
		''' a forced fetch by calling GetSingleMinvTransferenciaAlmacenSalida(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMinvTransferenciaAlmacenSalida As Boolean
			Get
				Return _alwaysFetchMinvTransferenciaAlmacenSalida
			End Get
			Set
				_alwaysFetchMinvTransferenciaAlmacenSalida = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property MinvTransferenciaAlmacenSalida is not found
		''' in the database. When set to true, MinvTransferenciaAlmacenSalida will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property MinvTransferenciaAlmacenSalidaReturnsNewIfNotFound As Boolean
			Get
				Return _minvTransferenciaAlmacenSalidaReturnsNewIfNotFound
			End Get
			Set
				_minvTransferenciaAlmacenSalidaReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.MinvTransferenciaAlmacenEntradaEntity)
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
