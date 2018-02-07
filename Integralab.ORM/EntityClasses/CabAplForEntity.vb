' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: miércoles, 7 de febrero de 2018 11:23:32
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
	''' <summary>Entity class which represents the entity 'CabAplFor'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class CabAplForEntity 
#Else
	<Serializable()> _
	Public Class CabAplForEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _detAplFor As Integralab.ORM.CollectionClasses.DetAplForCollection
		Private _alwaysFetchDetAplFor, _alreadyFetchedDetAplFor As Boolean
		Private _productoCollectionViaDetAplFor As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaDetAplFor, _alreadyFetchedProductoCollectionViaDetAplFor As Boolean
		Private _mcecatCorralesCabCollectionViaDetAplFor As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
		Private _alwaysFetchMcecatCorralesCabCollectionViaDetAplFor, _alreadyFetchedMcecatCorralesCabCollectionViaDetAplFor As Boolean
		Private _mcecatLotesCabCollectionViaDetAplFor As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
		Private _alwaysFetchMcecatLotesCabCollectionViaDetAplFor, _alreadyFetchedMcecatLotesCabCollectionViaDetAplFor As Boolean
		Private _almacen As AlmacenEntity
		Private _alwaysFetchAlmacen, _alreadyFetchedAlmacen, _almacenReturnsNewIfNotFound As Boolean
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
		''' <param name="folAplF">PK value for CabAplFor which data should be fetched into this CabAplFor Object</param>
		Public Sub New(folAplF As System.String)

			InitClassFetch(folAplF, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folAplF">PK value for CabAplFor which data should be fetched into this CabAplFor Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(folAplF As System.String, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(folAplF, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folAplF">PK value for CabAplFor which data should be fetched into this CabAplFor Object</param>
		''' <param name="validator">The custom validator Object for this CabAplForEntity</param>
		Public Sub New(folAplF As System.String, validator As IValidator)

			InitClassFetch(folAplF, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_detAplFor = CType(info.GetValue("_detAplFor", GetType(Integralab.ORM.CollectionClasses.DetAplForCollection)), Integralab.ORM.CollectionClasses.DetAplForCollection)
			_alwaysFetchDetAplFor = info.GetBoolean("_alwaysFetchDetAplFor")
			_alreadyFetchedDetAplFor = info.GetBoolean("_alreadyFetchedDetAplFor")
			_productoCollectionViaDetAplFor = CType(info.GetValue("_productoCollectionViaDetAplFor", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaDetAplFor = info.GetBoolean("_alwaysFetchProductoCollectionViaDetAplFor")
			_alreadyFetchedProductoCollectionViaDetAplFor = info.GetBoolean("_alreadyFetchedProductoCollectionViaDetAplFor")
			_mcecatCorralesCabCollectionViaDetAplFor = CType(info.GetValue("_mcecatCorralesCabCollectionViaDetAplFor", GetType(Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)), Integralab.ORM.CollectionClasses.McecatCorralesCabCollection)
			_alwaysFetchMcecatCorralesCabCollectionViaDetAplFor = info.GetBoolean("_alwaysFetchMcecatCorralesCabCollectionViaDetAplFor")
			_alreadyFetchedMcecatCorralesCabCollectionViaDetAplFor = info.GetBoolean("_alreadyFetchedMcecatCorralesCabCollectionViaDetAplFor")
			_mcecatLotesCabCollectionViaDetAplFor = CType(info.GetValue("_mcecatLotesCabCollectionViaDetAplFor", GetType(Integralab.ORM.CollectionClasses.McecatLotesCabCollection)), Integralab.ORM.CollectionClasses.McecatLotesCabCollection)
			_alwaysFetchMcecatLotesCabCollectionViaDetAplFor = info.GetBoolean("_alwaysFetchMcecatLotesCabCollectionViaDetAplFor")
			_alreadyFetchedMcecatLotesCabCollectionViaDetAplFor = info.GetBoolean("_alreadyFetchedMcecatLotesCabCollectionViaDetAplFor")
			_almacen = CType(info.GetValue("_almacen", GetType(AlmacenEntity)), AlmacenEntity)
			If Not _almacen Is Nothing Then
				AddHandler _almacen.AfterSave, AddressOf OnEntityAfterSave
			End If
			_almacenReturnsNewIfNotFound = info.GetBoolean("_almacenReturnsNewIfNotFound")
			_alwaysFetchAlmacen = info.GetBoolean("_alwaysFetchAlmacen")
			_alreadyFetchedAlmacen = info.GetBoolean("_alreadyFetchedAlmacen")
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
			_alreadyFetchedDetAplFor = (_detAplFor.Count > 0)
			_alreadyFetchedProductoCollectionViaDetAplFor = (_productoCollectionViaDetAplFor.Count > 0)
			_alreadyFetchedMcecatCorralesCabCollectionViaDetAplFor = (_mcecatCorralesCabCollectionViaDetAplFor.Count > 0)
			_alreadyFetchedMcecatLotesCabCollectionViaDetAplFor = (_mcecatLotesCabCollectionViaDetAplFor.Count > 0)
			_alreadyFetchedAlmacen = Not(_almacen Is Nothing)
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
			info.AddValue("_detAplFor", _detAplFor)
			info.AddValue("_alwaysFetchDetAplFor", _alwaysFetchDetAplFor)
			info.AddValue("_alreadyFetchedDetAplFor", _alreadyFetchedDetAplFor)
			info.AddValue("_productoCollectionViaDetAplFor", _productoCollectionViaDetAplFor)
			info.AddValue("_alwaysFetchProductoCollectionViaDetAplFor", _alwaysFetchProductoCollectionViaDetAplFor)
			info.AddValue("_alreadyFetchedProductoCollectionViaDetAplFor", _alreadyFetchedProductoCollectionViaDetAplFor)
			info.AddValue("_mcecatCorralesCabCollectionViaDetAplFor", _mcecatCorralesCabCollectionViaDetAplFor)
			info.AddValue("_alwaysFetchMcecatCorralesCabCollectionViaDetAplFor", _alwaysFetchMcecatCorralesCabCollectionViaDetAplFor)
			info.AddValue("_alreadyFetchedMcecatCorralesCabCollectionViaDetAplFor", _alreadyFetchedMcecatCorralesCabCollectionViaDetAplFor)
			info.AddValue("_mcecatLotesCabCollectionViaDetAplFor", _mcecatLotesCabCollectionViaDetAplFor)
			info.AddValue("_alwaysFetchMcecatLotesCabCollectionViaDetAplFor", _alwaysFetchMcecatLotesCabCollectionViaDetAplFor)
			info.AddValue("_alreadyFetchedMcecatLotesCabCollectionViaDetAplFor", _alreadyFetchedMcecatLotesCabCollectionViaDetAplFor)
			info.AddValue("_almacen", _almacen)
			info.AddValue("_almacenReturnsNewIfNotFound", _almacenReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchAlmacen", _alwaysFetchAlmacen)
			info.AddValue("_alreadyFetchedAlmacen", _alreadyFetchedAlmacen)
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
				Case "Almacen"
					_alreadyFetchedAlmacen = True
					Me.Almacen = CType(entity, AlmacenEntity)
				Case "InventarioMovimientoAlmacen"
					_alreadyFetchedInventarioMovimientoAlmacen = True
					Me.InventarioMovimientoAlmacen = CType(entity, InventarioMovimientoAlmacenEntity)
				Case "InventarioMovimientoAlmacen_"
					_alreadyFetchedInventarioMovimientoAlmacen_ = True
					Me.InventarioMovimientoAlmacen_ = CType(entity, InventarioMovimientoAlmacenEntity)
				Case "DetAplFor"
					_alreadyFetchedDetAplFor = True
					If Not entity Is Nothing Then
						Me.DetAplFor.Add(CType(entity, DetAplForEntity))
					End If
				Case "ProductoCollectionViaDetAplFor"
					_alreadyFetchedProductoCollectionViaDetAplFor = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaDetAplFor.Add(CType(entity, ProductoEntity))
					End If
				Case "McecatCorralesCabCollectionViaDetAplFor"
					_alreadyFetchedMcecatCorralesCabCollectionViaDetAplFor = True
					If Not entity Is Nothing Then
						Me.McecatCorralesCabCollectionViaDetAplFor.Add(CType(entity, McecatCorralesCabEntity))
					End If
				Case "McecatLotesCabCollectionViaDetAplFor"
					_alreadyFetchedMcecatLotesCabCollectionViaDetAplFor = True
					If Not entity Is Nothing Then
						Me.McecatLotesCabCollectionViaDetAplFor.Add(CType(entity, McecatLotesCabEntity))
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
				Case "Almacen"
					SetupSyncAlmacen(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "InventarioMovimientoAlmacen"
					SetupSyncInventarioMovimientoAlmacen(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "InventarioMovimientoAlmacen_"
					SetupSyncInventarioMovimientoAlmacen_(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "DetAplFor"
					_detAplFor.Add(CType(relatedEntity, DetAplForEntity))
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
				Case "Almacen"
					DesetupSyncAlmacen(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "InventarioMovimientoAlmacen"
					DesetupSyncInventarioMovimientoAlmacen(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "InventarioMovimientoAlmacen_"
					DesetupSyncInventarioMovimientoAlmacen_(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "DetAplFor"
					MyBase.PerformRelatedEntityRemoval(_detAplFor, relatedEntity, signalRelatedEntityManyToOne)
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
			If Not _almacen Is Nothing Then
				toReturn.Add(_almacen)
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
			toReturn.Add(_detAplFor)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folAplF">PK value for CabAplFor which data should be fetched into this CabAplFor Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folAplF As System.String) As Boolean
			Return FetchUsingPK(folAplF, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folAplF">PK value for CabAplFor which data should be fetched into this CabAplFor Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folAplF As System.String, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(folAplF, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folAplF">PK value for CabAplFor which data should be fetched into this CabAplFor Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folAplF As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(folAplF, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.FolAplF, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As CabAplForFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As CabAplForFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'DetAplForEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'DetAplForEntity'</returns>
		Public Function GetMultiDetAplFor(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.DetAplForCollection
			Return GetMultiDetAplFor(forceFetch, _detAplFor.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetAplForEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiDetAplFor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.DetAplForCollection
			Return GetMultiDetAplFor(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetAplForEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'DetAplForEntity'</returns>
		Public Function GetMultiDetAplFor(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetAplForCollection
			Return GetMultiDetAplFor(forceFetch, _detAplFor.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'DetAplForEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiDetAplFor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetAplForCollection
			If ( Not _alreadyFetchedDetAplFor Or forceFetch Or _alwaysFetchDetAplFor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _detAplFor.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_detAplFor)
					End If
				End If
				_detAplFor.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_detAplFor.EntityFactoryToUse = entityFactoryToUse
				End If
				_detAplFor.GetMultiManyToOne(Me, Nothing, Nothing, Nothing, Filter)
				_detAplFor.SuppressClearInGetMulti = False
				_alreadyFetchedDetAplFor = True
			End If
			Return _detAplFor
		End Function

		''' <summary>Sets the collection parameters for the collection for 'DetAplFor'. These settings will be taken into account
		''' when the property DetAplFor is requested or GetMultiDetAplFor is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersDetAplFor(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_detAplFor.SortClauses=sortClauses
			_detAplFor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViaDetAplFor(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViaDetAplFor(forceFetch, _productoCollectionViaDetAplFor.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViaDetAplFor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViaDetAplFor Or forceFetch Or _alwaysFetchProductoCollectionViaDetAplFor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViaDetAplFor.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViaDetAplFor)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CabAplForEntity.Relations.DetAplForEntityUsingFolAplF, "__CabAplForEntity__", "DetAplFor_", JoinHint.None)
				relations.Add(DetAplForEntity.Relations.ProductoEntityUsingCveFormula, "DetAplFor_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CabAplForFieldIndex.FolAplF), ComparisonOperator.Equal, Me.FolAplF))
				_productoCollectionViaDetAplFor.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViaDetAplFor.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViaDetAplFor.GetMulti(Filter, relations)
				_productoCollectionViaDetAplFor.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViaDetAplFor = True
			End If
			Return _productoCollectionViaDetAplFor
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViaDetAplFor'. These settings will be taken into account
		''' when the property ProductoCollectionViaDetAplFor is requested or GetMultiProductoCollectionViaDetAplFor is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViaDetAplFor(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViaDetAplFor.SortClauses=sortClauses
			_productoCollectionViaDetAplFor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McecatCorralesCabEntity'</returns>
		Public Function GetMultiMcecatCorralesCabCollectionViaDetAplFor(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			Return GetMultiMcecatCorralesCabCollectionViaDetAplFor(forceFetch, _mcecatCorralesCabCollectionViaDetAplFor.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcecatCorralesCabCollectionViaDetAplFor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			If ( Not _alreadyFetchedMcecatCorralesCabCollectionViaDetAplFor Or forceFetch Or _alwaysFetchMcecatCorralesCabCollectionViaDetAplFor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcecatCorralesCabCollectionViaDetAplFor.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcecatCorralesCabCollectionViaDetAplFor)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CabAplForEntity.Relations.DetAplForEntityUsingFolAplF, "__CabAplForEntity__", "DetAplFor_", JoinHint.None)
				relations.Add(DetAplForEntity.Relations.McecatCorralesCabEntityUsingCveCorral, "DetAplFor_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CabAplForFieldIndex.FolAplF), ComparisonOperator.Equal, Me.FolAplF))
				_mcecatCorralesCabCollectionViaDetAplFor.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcecatCorralesCabCollectionViaDetAplFor.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcecatCorralesCabCollectionViaDetAplFor.GetMulti(Filter, relations)
				_mcecatCorralesCabCollectionViaDetAplFor.SuppressClearInGetMulti = False
				_alreadyFetchedMcecatCorralesCabCollectionViaDetAplFor = True
			End If
			Return _mcecatCorralesCabCollectionViaDetAplFor
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McecatCorralesCabCollectionViaDetAplFor'. These settings will be taken into account
		''' when the property McecatCorralesCabCollectionViaDetAplFor is requested or GetMultiMcecatCorralesCabCollectionViaDetAplFor is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcecatCorralesCabCollectionViaDetAplFor(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcecatCorralesCabCollectionViaDetAplFor.SortClauses=sortClauses
			_mcecatCorralesCabCollectionViaDetAplFor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McecatLotesCabEntity'</returns>
		Public Function GetMultiMcecatLotesCabCollectionViaDetAplFor(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			Return GetMultiMcecatLotesCabCollectionViaDetAplFor(forceFetch, _mcecatLotesCabCollectionViaDetAplFor.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcecatLotesCabCollectionViaDetAplFor(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			If ( Not _alreadyFetchedMcecatLotesCabCollectionViaDetAplFor Or forceFetch Or _alwaysFetchMcecatLotesCabCollectionViaDetAplFor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcecatLotesCabCollectionViaDetAplFor.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcecatLotesCabCollectionViaDetAplFor)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CabAplForEntity.Relations.DetAplForEntityUsingFolAplF, "__CabAplForEntity__", "DetAplFor_", JoinHint.None)
				relations.Add(DetAplForEntity.Relations.McecatLotesCabEntityUsingCveLote, "DetAplFor_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CabAplForFieldIndex.FolAplF), ComparisonOperator.Equal, Me.FolAplF))
				_mcecatLotesCabCollectionViaDetAplFor.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcecatLotesCabCollectionViaDetAplFor.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcecatLotesCabCollectionViaDetAplFor.GetMulti(Filter, relations)
				_mcecatLotesCabCollectionViaDetAplFor.SuppressClearInGetMulti = False
				_alreadyFetchedMcecatLotesCabCollectionViaDetAplFor = True
			End If
			Return _mcecatLotesCabCollectionViaDetAplFor
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McecatLotesCabCollectionViaDetAplFor'. These settings will be taken into account
		''' when the property McecatLotesCabCollectionViaDetAplFor is requested or GetMultiMcecatLotesCabCollectionViaDetAplFor is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcecatLotesCabCollectionViaDetAplFor(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcecatLotesCabCollectionViaDetAplFor.SortClauses=sortClauses
			_mcecatLotesCabCollectionViaDetAplFor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves the related entity of type 'AlmacenEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'AlmacenEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleAlmacen() As AlmacenEntity
			Return GetSingleAlmacen(False)
		End Function

		''' <summary>Retrieves the related entity of type 'AlmacenEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'AlmacenEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleAlmacen(forceFetch As Boolean) As AlmacenEntity
			If ( Not _alreadyFetchedAlmacen Or forceFetch Or _alwaysFetchAlmacen) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New AlmacenEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(CabAplForEntity.Relations.AlmacenEntityUsingIdAlmacen) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdAlmacen)
				End If
				If Not _almacenReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Almacen = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), AlmacenEntity)
					End If
					Me.Almacen = newEntity
					_alreadyFetchedAlmacen = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _almacen
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
				If MyBase.CheckIfLazyLoadingShouldOccur(CabAplForEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacen) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdAlmacen, Me.FolioMovimientoAlmacen)
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
				If MyBase.CheckIfLazyLoadingShouldOccur(CabAplForEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacenCancelacion) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdAlmacen, Me.FolioMovimientoAlmacenCancelacion)
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(CabAplForFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, CabAplForFieldIndex)











					Case CabAplForFieldIndex.FolioMovimientoAlmacen
						DesetupSyncInventarioMovimientoAlmacen(True, False)
						_alreadyFetchedInventarioMovimientoAlmacen = False
					Case CabAplForFieldIndex.FolioMovimientoAlmacenCancelacion
						DesetupSyncInventarioMovimientoAlmacen_(True, False)
						_alreadyFetchedInventarioMovimientoAlmacen_ = False
					Case CabAplForFieldIndex.IdAlmacen
						DesetupSyncAlmacen(True, False)
						_alreadyFetchedAlmacen = False
						DesetupSyncInventarioMovimientoAlmacen(True, False)
						_alreadyFetchedInventarioMovimientoAlmacen = False
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
			_detAplFor.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaDetAplFor.ActiveContext = MyBase.ActiveContext
			_mcecatCorralesCabCollectionViaDetAplFor.ActiveContext = MyBase.ActiveContext
			_mcecatLotesCabCollectionViaDetAplFor.ActiveContext = MyBase.ActiveContext
		If Not _almacen Is Nothing Then
				_almacen.ActiveContext = MyBase.ActiveContext
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
			Dim dao As CabAplForDAO = CType(CreateDAOInstance(), CabAplForDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As CabAplForDAO = CType(CreateDAOInstance(), CabAplForDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As CabAplForDAO = CType(CreateDAOInstance(), CabAplForDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this CabAplForEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CabAplForEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="folAplF">PK value for CabAplFor which data should be fetched into this CabAplFor Object</param>
		''' <param name="validator">The validator Object for this CabAplForEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(folAplF As System.String, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(folAplF, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_detAplFor = New Integralab.ORM.CollectionClasses.DetAplForCollection(New DetAplForEntityFactory())
			_detAplFor.SetContainingEntityInfo(Me, "CabAplFor")
			_alwaysFetchDetAplFor = False
			_alreadyFetchedDetAplFor = False
			_productoCollectionViaDetAplFor = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaDetAplFor = False
			_alreadyFetchedProductoCollectionViaDetAplFor = False
			_mcecatCorralesCabCollectionViaDetAplFor = New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(New McecatCorralesCabEntityFactory())
			_alwaysFetchMcecatCorralesCabCollectionViaDetAplFor = False
			_alreadyFetchedMcecatCorralesCabCollectionViaDetAplFor = False
			_mcecatLotesCabCollectionViaDetAplFor = New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(New McecatLotesCabEntityFactory())
			_alwaysFetchMcecatLotesCabCollectionViaDetAplFor = False
			_alreadyFetchedMcecatLotesCabCollectionViaDetAplFor = False
			_almacen = Nothing
			_almacenReturnsNewIfNotFound = True
			_alwaysFetchAlmacen = False
			_alreadyFetchedAlmacen = False
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

			_fieldsCustomProperties.Add("FolAplF", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaAplicacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaContabilizacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolPoliza", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Costo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdUsuarioAlta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdUsuarioCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCaptura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Cabezas", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioMovimientoAlmacen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioMovimientoAlmacenCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdAlmacen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TotalServidas", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _almacen</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncAlmacen(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _almacen, AddressOf OnAlmacenPropertyChanged, "Almacen", CabAplForEntity.Relations.AlmacenEntityUsingIdAlmacen, True, signalRelatedEntity, "CabAplFor", resetFKFields, New Integer() { CInt(CabAplForFieldIndex.IdAlmacen) } )
			_almacen = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _almacen</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncAlmacen(relatedEntity As IEntity)
			DesetupSyncAlmacen(True, True)
			_almacen = CType(relatedEntity, AlmacenEntity)
			MyBase.PerformSetupSyncRelatedEntity( _almacen, AddressOf OnAlmacenPropertyChanged, "Almacen", CabAplForEntity.Relations.AlmacenEntityUsingIdAlmacen, True, _alreadyFetchedAlmacen, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnAlmacenPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _inventarioMovimientoAlmacen</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncInventarioMovimientoAlmacen(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _inventarioMovimientoAlmacen, AddressOf OnInventarioMovimientoAlmacenPropertyChanged, "InventarioMovimientoAlmacen", CabAplForEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacen, True, signalRelatedEntity, "CabAplFor", resetFKFields, New Integer() { CInt(CabAplForFieldIndex.IdAlmacen), CInt(CabAplForFieldIndex.FolioMovimientoAlmacen) } )
			_inventarioMovimientoAlmacen = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _inventarioMovimientoAlmacen</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncInventarioMovimientoAlmacen(relatedEntity As IEntity)
			DesetupSyncInventarioMovimientoAlmacen(True, True)
			_inventarioMovimientoAlmacen = CType(relatedEntity, InventarioMovimientoAlmacenEntity)
			MyBase.PerformSetupSyncRelatedEntity( _inventarioMovimientoAlmacen, AddressOf OnInventarioMovimientoAlmacenPropertyChanged, "InventarioMovimientoAlmacen", CabAplForEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacen, True, _alreadyFetchedInventarioMovimientoAlmacen, New String() {  } )
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
			MyBase.PerformDesetupSyncRelatedEntity( _inventarioMovimientoAlmacen_, AddressOf OnInventarioMovimientoAlmacen_PropertyChanged, "InventarioMovimientoAlmacen_", CabAplForEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacenCancelacion, True, signalRelatedEntity, "CabAplFor_", resetFKFields, New Integer() { CInt(CabAplForFieldIndex.IdAlmacen), CInt(CabAplForFieldIndex.FolioMovimientoAlmacenCancelacion) } )
			_inventarioMovimientoAlmacen_ = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _inventarioMovimientoAlmacen_</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncInventarioMovimientoAlmacen_(relatedEntity As IEntity)
			DesetupSyncInventarioMovimientoAlmacen_(True, True)
			_inventarioMovimientoAlmacen_ = CType(relatedEntity, InventarioMovimientoAlmacenEntity)
			MyBase.PerformSetupSyncRelatedEntity( _inventarioMovimientoAlmacen_, AddressOf OnInventarioMovimientoAlmacen_PropertyChanged, "InventarioMovimientoAlmacen_", CabAplForEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacenCancelacion, True, _alreadyFetchedInventarioMovimientoAlmacen_, New String() {  } )
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
		''' <param name="folAplF">PK value for CabAplFor which data should be fetched into this CabAplFor Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(folAplF As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(CabAplForFieldIndex.FolAplF)).ForcedCurrentValueWrite(folAplF)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateCabAplForDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New CabAplForEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As CabAplForRelations
			Get	
				Return New CabAplForRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DetAplFor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDetAplFor() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DetAplForCollection(), _
					CabAplForEntity.Relations.DetAplForEntityUsingFolAplF, _
					CType(Integralab.ORM.EntityType.CabAplForEntity, Integer), CType(Integralab.ORM.EntityType.DetAplForEntity, Integer), 0, Nothing, Nothing, Nothing, "DetAplFor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaDetAplFor() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CabAplForEntity.Relations.DetAplForEntityUsingFolAplF, "__CabAplForEntity__", String.Empty, JoinHint.None)
				relations.Add(DetAplForEntity.Relations.ProductoEntityUsingCveFormula)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					CabAplForEntity.Relations.DetAplForEntityUsingFolAplF, _
					CType(Integralab.ORM.EntityType.CabAplForEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaDetAplFor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatCorralesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatCorralesCabCollectionViaDetAplFor() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CabAplForEntity.Relations.DetAplForEntityUsingFolAplF, "__CabAplForEntity__", String.Empty, JoinHint.None)
				relations.Add(DetAplForEntity.Relations.McecatCorralesCabEntityUsingCveCorral)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatCorralesCabCollection(), _
					CabAplForEntity.Relations.DetAplForEntityUsingFolAplF, _
					CType(Integralab.ORM.EntityType.CabAplForEntity, Integer), CType(Integralab.ORM.EntityType.McecatCorralesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatCorralesCabCollectionViaDetAplFor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatLotesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatLotesCabCollectionViaDetAplFor() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CabAplForEntity.Relations.DetAplForEntityUsingFolAplF, "__CabAplForEntity__", String.Empty, JoinHint.None)
				relations.Add(DetAplForEntity.Relations.McecatLotesCabEntityUsingCveLote)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(), _
					CabAplForEntity.Relations.DetAplForEntityUsingFolAplF, _
					CType(Integralab.ORM.EntityType.CabAplForEntity, Integer), CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatLotesCabCollectionViaDetAplFor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacen() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					CabAplForEntity.Relations.AlmacenEntityUsingIdAlmacen, _
					CType(Integralab.ORM.EntityType.CabAplForEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "Almacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacen() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					CabAplForEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacen, _
					CType(Integralab.ORM.EntityType.CabAplForEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "InventarioMovimientoAlmacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacen_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					CabAplForEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacenCancelacion, _
					CType(Integralab.ORM.EntityType.CabAplForEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "InventarioMovimientoAlmacen_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "CabAplForEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return CabAplForEntity.CustomProperties
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
				Return CabAplForEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The FolAplF property of the Entity CabAplFor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabAplFor"."Fol_AplF"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 8<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [FolAplF]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabAplForFieldIndex.FolAplF, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabAplForFieldIndex.FolAplF, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaAplicacion property of the Entity CabAplFor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabAplFor"."FechaAplicacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaAplicacion]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabAplForFieldIndex.FechaAplicacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(CabAplForFieldIndex.FechaAplicacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaContabilizacion property of the Entity CabAplFor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabAplFor"."FechaContabilizacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaContabilizacion]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabAplForFieldIndex.FechaContabilizacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(CabAplForFieldIndex.FechaContabilizacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolPoliza property of the Entity CabAplFor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabAplFor"."Fol_Poliza"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 8<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FolPoliza]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabAplForFieldIndex.FolPoliza, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabAplForFieldIndex.FolPoliza, Integer), value)
			End Set
		End Property
	
		''' <summary>The Costo property of the Entity CabAplFor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabAplFor"."Costo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Costo]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabAplForFieldIndex.Costo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CabAplForFieldIndex.Costo, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdUsuarioAlta property of the Entity CabAplFor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabAplFor"."IdUsuarioAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdUsuarioAlta]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabAplForFieldIndex.IdUsuarioAlta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(CabAplForFieldIndex.IdUsuarioAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdUsuarioCancelacion property of the Entity CabAplFor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabAplFor"."IdUsuarioCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdUsuarioCancelacion]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabAplForFieldIndex.IdUsuarioCancelacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(CabAplForFieldIndex.IdUsuarioCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCaptura property of the Entity CabAplFor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabAplFor"."FechaCaptura"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaCaptura]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabAplForFieldIndex.FechaCaptura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(CabAplForFieldIndex.FechaCaptura, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCancelacion property of the Entity CabAplFor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabAplFor"."FechaCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaCancelacion]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabAplForFieldIndex.FechaCancelacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(CabAplForFieldIndex.FechaCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity CabAplFor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabAplFor"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabAplForFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(CabAplForFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cabezas property of the Entity CabAplFor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabAplFor"."Cabezas"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Cabezas]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabAplForFieldIndex.Cabezas, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(CabAplForFieldIndex.Cabezas, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioMovimientoAlmacen property of the Entity CabAplFor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabAplFor"."FolioMovimientoAlmacen"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FolioMovimientoAlmacen]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabAplForFieldIndex.FolioMovimientoAlmacen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabAplForFieldIndex.FolioMovimientoAlmacen, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioMovimientoAlmacenCancelacion property of the Entity CabAplFor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabAplFor"."FolioMovimientoAlmacenCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FolioMovimientoAlmacenCancelacion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabAplForFieldIndex.FolioMovimientoAlmacenCancelacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabAplForFieldIndex.FolioMovimientoAlmacenCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdAlmacen property of the Entity CabAplFor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabAplFor"."IdAlmacen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdAlmacen]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabAplForFieldIndex.IdAlmacen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(CabAplForFieldIndex.IdAlmacen, Integer), value)
			End Set
		End Property
	
		''' <summary>The TotalServidas property of the Entity CabAplFor<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabAplFor"."TotalServidas"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 18, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TotalServidas]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabAplForFieldIndex.TotalServidas, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CabAplForFieldIndex.TotalServidas, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'DetAplForEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDetAplFor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [DetAplFor]() As Integralab.ORM.CollectionClasses.DetAplForCollection
			Get
				Return GetMultiDetAplFor(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for DetAplFor. When set to true, DetAplFor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time DetAplFor is accessed. You can always execute
		''' a forced fetch by calling GetMultiDetAplFor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchDetAplFor As Boolean
			Get
				Return _alwaysFetchDetAplFor
			End Get
			Set
				_alwaysFetchDetAplFor = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViaDetAplFor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViaDetAplFor]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViaDetAplFor(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViaDetAplFor. When set to true, ProductoCollectionViaDetAplFor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViaDetAplFor is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViaDetAplFor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViaDetAplFor As Boolean
			Get
				Return _alwaysFetchProductoCollectionViaDetAplFor
			End Get
			Set
				_alwaysFetchProductoCollectionViaDetAplFor = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McecatCorralesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcecatCorralesCabCollectionViaDetAplFor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McecatCorralesCabCollectionViaDetAplFor]() As Integralab.ORM.CollectionClasses.McecatCorralesCabCollection
			Get
				Return GetMultiMcecatCorralesCabCollectionViaDetAplFor(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatCorralesCabCollectionViaDetAplFor. When set to true, McecatCorralesCabCollectionViaDetAplFor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatCorralesCabCollectionViaDetAplFor is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcecatCorralesCabCollectionViaDetAplFor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatCorralesCabCollectionViaDetAplFor As Boolean
			Get
				Return _alwaysFetchMcecatCorralesCabCollectionViaDetAplFor
			End Get
			Set
				_alwaysFetchMcecatCorralesCabCollectionViaDetAplFor = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcecatLotesCabCollectionViaDetAplFor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McecatLotesCabCollectionViaDetAplFor]() As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			Get
				Return GetMultiMcecatLotesCabCollectionViaDetAplFor(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatLotesCabCollectionViaDetAplFor. When set to true, McecatLotesCabCollectionViaDetAplFor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatLotesCabCollectionViaDetAplFor is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcecatLotesCabCollectionViaDetAplFor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatLotesCabCollectionViaDetAplFor As Boolean
			Get
				Return _alwaysFetchMcecatLotesCabCollectionViaDetAplFor
			End Get
			Set
				_alwaysFetchMcecatLotesCabCollectionViaDetAplFor = value
			End Set	
		End Property
	
	
		''' <summary>Gets / sets related entity of type 'AlmacenEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleAlmacen()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Almacen]() As AlmacenEntity
			Get
				Return GetSingleAlmacen(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncAlmacen(value)
				Else
					If value Is Nothing Then
						If Not _almacen Is Nothing Then
							_almacen.UnsetRelatedEntity(Me, "CabAplFor")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "CabAplFor")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Almacen. When set to true, Almacen is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Almacen is accessed. You can always execute
		''' a forced fetch by calling GetSingleAlmacen(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacen As Boolean
			Get
				Return _alwaysFetchAlmacen
			End Get
			Set
				_alwaysFetchAlmacen = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Almacen is not found
		''' in the database. When set to true, Almacen will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property AlmacenReturnsNewIfNotFound As Boolean
			Get
				Return _almacenReturnsNewIfNotFound
			End Get
			Set
				_almacenReturnsNewIfNotFound = value
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
							_inventarioMovimientoAlmacen.UnsetRelatedEntity(Me, "CabAplFor")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "CabAplFor")
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
							_inventarioMovimientoAlmacen_.UnsetRelatedEntity(Me, "CabAplFor_")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "CabAplFor_")
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
				Return CInt(Integralab.ORM.EntityType.CabAplForEntity)
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
