' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: martes, 26 de diciembre de 2017 16:41:36
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
	''' <summary>Entity class which represents the entity 'MinvMovimientosAlmacenPv'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class MinvMovimientosAlmacenPvEntity 
#Else
	<Serializable()> _
	Public Class MinvMovimientosAlmacenPvEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _minvMovimientosAlmacenPvdetalles As Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvdetallesCollection
		Private _alwaysFetchMinvMovimientosAlmacenPvdetalles, _alreadyFetchedMinvMovimientosAlmacenPvdetalles As Boolean
		Private _almacenCollectionViaMinvMovimientosAlmacenPvdetalles As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles, _alreadyFetchedAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles As Boolean
		Private _productoCollectionViaMinvMovimientosAlmacenPvdetalles As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaMinvMovimientosAlmacenPvdetalles, _alreadyFetchedProductoCollectionViaMinvMovimientosAlmacenPvdetalles As Boolean
		Private _catMovimientosAlmacenPv As CatMovimientosAlmacenPvEntity
		Private _alwaysFetchCatMovimientosAlmacenPv, _alreadyFetchedCatMovimientosAlmacenPv, _catMovimientosAlmacenPvReturnsNewIfNotFound As Boolean
		Private _almacen As AlmacenEntity
		Private _alwaysFetchAlmacen, _alreadyFetchedAlmacen, _almacenReturnsNewIfNotFound As Boolean


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
		''' <param name="almacenId">PK value for MinvMovimientosAlmacenPv which data should be fetched into this MinvMovimientosAlmacenPv Object</param>
		''' <param name="folioMovimiento">PK value for MinvMovimientosAlmacenPv which data should be fetched into this MinvMovimientosAlmacenPv Object</param>
		Public Sub New(almacenId As System.Int32, folioMovimiento As System.String)

			InitClassFetch(almacenId, folioMovimiento, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="almacenId">PK value for MinvMovimientosAlmacenPv which data should be fetched into this MinvMovimientosAlmacenPv Object</param>
		''' <param name="folioMovimiento">PK value for MinvMovimientosAlmacenPv which data should be fetched into this MinvMovimientosAlmacenPv Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(almacenId As System.Int32, folioMovimiento As System.String, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(almacenId, folioMovimiento, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="almacenId">PK value for MinvMovimientosAlmacenPv which data should be fetched into this MinvMovimientosAlmacenPv Object</param>
		''' <param name="folioMovimiento">PK value for MinvMovimientosAlmacenPv which data should be fetched into this MinvMovimientosAlmacenPv Object</param>
		''' <param name="validator">The custom validator Object for this MinvMovimientosAlmacenPvEntity</param>
		Public Sub New(almacenId As System.Int32, folioMovimiento As System.String, validator As IValidator)

			InitClassFetch(almacenId, folioMovimiento, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_minvMovimientosAlmacenPvdetalles = CType(info.GetValue("_minvMovimientosAlmacenPvdetalles", GetType(Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvdetallesCollection)), Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvdetallesCollection)
			_alwaysFetchMinvMovimientosAlmacenPvdetalles = info.GetBoolean("_alwaysFetchMinvMovimientosAlmacenPvdetalles")
			_alreadyFetchedMinvMovimientosAlmacenPvdetalles = info.GetBoolean("_alreadyFetchedMinvMovimientosAlmacenPvdetalles")
			_almacenCollectionViaMinvMovimientosAlmacenPvdetalles = CType(info.GetValue("_almacenCollectionViaMinvMovimientosAlmacenPvdetalles", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles = info.GetBoolean("_alwaysFetchAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles")
			_alreadyFetchedAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles = info.GetBoolean("_alreadyFetchedAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles")
			_productoCollectionViaMinvMovimientosAlmacenPvdetalles = CType(info.GetValue("_productoCollectionViaMinvMovimientosAlmacenPvdetalles", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaMinvMovimientosAlmacenPvdetalles = info.GetBoolean("_alwaysFetchProductoCollectionViaMinvMovimientosAlmacenPvdetalles")
			_alreadyFetchedProductoCollectionViaMinvMovimientosAlmacenPvdetalles = info.GetBoolean("_alreadyFetchedProductoCollectionViaMinvMovimientosAlmacenPvdetalles")
			_catMovimientosAlmacenPv = CType(info.GetValue("_catMovimientosAlmacenPv", GetType(CatMovimientosAlmacenPvEntity)), CatMovimientosAlmacenPvEntity)
			If Not _catMovimientosAlmacenPv Is Nothing Then
				AddHandler _catMovimientosAlmacenPv.AfterSave, AddressOf OnEntityAfterSave
			End If
			_catMovimientosAlmacenPvReturnsNewIfNotFound = info.GetBoolean("_catMovimientosAlmacenPvReturnsNewIfNotFound")
			_alwaysFetchCatMovimientosAlmacenPv = info.GetBoolean("_alwaysFetchCatMovimientosAlmacenPv")
			_alreadyFetchedCatMovimientosAlmacenPv = info.GetBoolean("_alreadyFetchedCatMovimientosAlmacenPv")
			_almacen = CType(info.GetValue("_almacen", GetType(AlmacenEntity)), AlmacenEntity)
			If Not _almacen Is Nothing Then
				AddHandler _almacen.AfterSave, AddressOf OnEntityAfterSave
			End If
			_almacenReturnsNewIfNotFound = info.GetBoolean("_almacenReturnsNewIfNotFound")
			_alwaysFetchAlmacen = info.GetBoolean("_alwaysFetchAlmacen")
			_alreadyFetchedAlmacen = info.GetBoolean("_alreadyFetchedAlmacen")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedMinvMovimientosAlmacenPvdetalles = (_minvMovimientosAlmacenPvdetalles.Count > 0)
			_alreadyFetchedAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles = (_almacenCollectionViaMinvMovimientosAlmacenPvdetalles.Count > 0)
			_alreadyFetchedProductoCollectionViaMinvMovimientosAlmacenPvdetalles = (_productoCollectionViaMinvMovimientosAlmacenPvdetalles.Count > 0)
			_alreadyFetchedCatMovimientosAlmacenPv = Not(_catMovimientosAlmacenPv Is Nothing)
			_alreadyFetchedAlmacen = Not(_almacen Is Nothing)

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
			info.AddValue("_minvMovimientosAlmacenPvdetalles", _minvMovimientosAlmacenPvdetalles)
			info.AddValue("_alwaysFetchMinvMovimientosAlmacenPvdetalles", _alwaysFetchMinvMovimientosAlmacenPvdetalles)
			info.AddValue("_alreadyFetchedMinvMovimientosAlmacenPvdetalles", _alreadyFetchedMinvMovimientosAlmacenPvdetalles)
			info.AddValue("_almacenCollectionViaMinvMovimientosAlmacenPvdetalles", _almacenCollectionViaMinvMovimientosAlmacenPvdetalles)
			info.AddValue("_alwaysFetchAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles", _alwaysFetchAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles)
			info.AddValue("_alreadyFetchedAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles", _alreadyFetchedAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles)
			info.AddValue("_productoCollectionViaMinvMovimientosAlmacenPvdetalles", _productoCollectionViaMinvMovimientosAlmacenPvdetalles)
			info.AddValue("_alwaysFetchProductoCollectionViaMinvMovimientosAlmacenPvdetalles", _alwaysFetchProductoCollectionViaMinvMovimientosAlmacenPvdetalles)
			info.AddValue("_alreadyFetchedProductoCollectionViaMinvMovimientosAlmacenPvdetalles", _alreadyFetchedProductoCollectionViaMinvMovimientosAlmacenPvdetalles)
			info.AddValue("_catMovimientosAlmacenPv", _catMovimientosAlmacenPv)
			info.AddValue("_catMovimientosAlmacenPvReturnsNewIfNotFound", _catMovimientosAlmacenPvReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchCatMovimientosAlmacenPv", _alwaysFetchCatMovimientosAlmacenPv)
			info.AddValue("_alreadyFetchedCatMovimientosAlmacenPv", _alreadyFetchedCatMovimientosAlmacenPv)
			info.AddValue("_almacen", _almacen)
			info.AddValue("_almacenReturnsNewIfNotFound", _almacenReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchAlmacen", _alwaysFetchAlmacen)
			info.AddValue("_alreadyFetchedAlmacen", _alreadyFetchedAlmacen)

			
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
				Case "CatMovimientosAlmacenPv"
					_alreadyFetchedCatMovimientosAlmacenPv = True
					Me.CatMovimientosAlmacenPv = CType(entity, CatMovimientosAlmacenPvEntity)
				Case "Almacen"
					_alreadyFetchedAlmacen = True
					Me.Almacen = CType(entity, AlmacenEntity)
				Case "MinvMovimientosAlmacenPvdetalles"
					_alreadyFetchedMinvMovimientosAlmacenPvdetalles = True
					If Not entity Is Nothing Then
						Me.MinvMovimientosAlmacenPvdetalles.Add(CType(entity, MinvMovimientosAlmacenPvdetallesEntity))
					End If
				Case "AlmacenCollectionViaMinvMovimientosAlmacenPvdetalles"
					_alreadyFetchedAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles = True
					If Not entity Is Nothing Then
						Me.AlmacenCollectionViaMinvMovimientosAlmacenPvdetalles.Add(CType(entity, AlmacenEntity))
					End If
				Case "ProductoCollectionViaMinvMovimientosAlmacenPvdetalles"
					_alreadyFetchedProductoCollectionViaMinvMovimientosAlmacenPvdetalles = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaMinvMovimientosAlmacenPvdetalles.Add(CType(entity, ProductoEntity))
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
				Case "CatMovimientosAlmacenPv"
					SetupSyncCatMovimientosAlmacenPv(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Almacen"
					SetupSyncAlmacen(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MinvMovimientosAlmacenPvdetalles"
					_minvMovimientosAlmacenPvdetalles.Add(CType(relatedEntity, MinvMovimientosAlmacenPvdetallesEntity))
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
				Case "CatMovimientosAlmacenPv"
					DesetupSyncCatMovimientosAlmacenPv(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Almacen"
					DesetupSyncAlmacen(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MinvMovimientosAlmacenPvdetalles"
					MyBase.PerformRelatedEntityRemoval(_minvMovimientosAlmacenPvdetalles, relatedEntity, signalRelatedEntityManyToOne)
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
			If Not _catMovimientosAlmacenPv Is Nothing Then
				toReturn.Add(_catMovimientosAlmacenPv)
			End If
			If Not _almacen Is Nothing Then
				toReturn.Add(_almacen)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_minvMovimientosAlmacenPvdetalles)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="almacenId">PK value for MinvMovimientosAlmacenPv which data should be fetched into this MinvMovimientosAlmacenPv Object</param>
		''' <param name="folioMovimiento">PK value for MinvMovimientosAlmacenPv which data should be fetched into this MinvMovimientosAlmacenPv Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(almacenId As System.Int32, folioMovimiento As System.String) As Boolean
			Return FetchUsingPK(almacenId, folioMovimiento, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="almacenId">PK value for MinvMovimientosAlmacenPv which data should be fetched into this MinvMovimientosAlmacenPv Object</param>
		''' <param name="folioMovimiento">PK value for MinvMovimientosAlmacenPv which data should be fetched into this MinvMovimientosAlmacenPv Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(almacenId As System.Int32, folioMovimiento As System.String, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(almacenId, folioMovimiento, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="almacenId">PK value for MinvMovimientosAlmacenPv which data should be fetched into this MinvMovimientosAlmacenPv Object</param>
		''' <param name="folioMovimiento">PK value for MinvMovimientosAlmacenPv which data should be fetched into this MinvMovimientosAlmacenPv Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(almacenId As System.Int32, folioMovimiento As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(almacenId, folioMovimiento, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.AlmacenId, Me.FolioMovimiento, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As MinvMovimientosAlmacenPvFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As MinvMovimientosAlmacenPvFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'MinvMovimientosAlmacenPvdetallesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MinvMovimientosAlmacenPvdetallesEntity'</returns>
		Public Function GetMultiMinvMovimientosAlmacenPvdetalles(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvdetallesCollection
			Return GetMultiMinvMovimientosAlmacenPvdetalles(forceFetch, _minvMovimientosAlmacenPvdetalles.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvMovimientosAlmacenPvdetallesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMinvMovimientosAlmacenPvdetalles(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvdetallesCollection
			Return GetMultiMinvMovimientosAlmacenPvdetalles(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvMovimientosAlmacenPvdetallesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MinvMovimientosAlmacenPvdetallesEntity'</returns>
		Public Function GetMultiMinvMovimientosAlmacenPvdetalles(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvdetallesCollection
			Return GetMultiMinvMovimientosAlmacenPvdetalles(forceFetch, _minvMovimientosAlmacenPvdetalles.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MinvMovimientosAlmacenPvdetallesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMinvMovimientosAlmacenPvdetalles(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvdetallesCollection
			If ( Not _alreadyFetchedMinvMovimientosAlmacenPvdetalles Or forceFetch Or _alwaysFetchMinvMovimientosAlmacenPvdetalles) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _minvMovimientosAlmacenPvdetalles.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_minvMovimientosAlmacenPvdetalles)
					End If
				End If
				_minvMovimientosAlmacenPvdetalles.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_minvMovimientosAlmacenPvdetalles.EntityFactoryToUse = entityFactoryToUse
				End If
				_minvMovimientosAlmacenPvdetalles.GetMultiManyToOne(Nothing, Nothing, Me, Filter)
				_minvMovimientosAlmacenPvdetalles.SuppressClearInGetMulti = False
				_alreadyFetchedMinvMovimientosAlmacenPvdetalles = True
			End If
			Return _minvMovimientosAlmacenPvdetalles
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MinvMovimientosAlmacenPvdetalles'. These settings will be taken into account
		''' when the property MinvMovimientosAlmacenPvdetalles is requested or GetMultiMinvMovimientosAlmacenPvdetalles is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMinvMovimientosAlmacenPvdetalles(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_minvMovimientosAlmacenPvdetalles.SortClauses=sortClauses
			_minvMovimientosAlmacenPvdetalles.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles(forceFetch, _almacenCollectionViaMinvMovimientosAlmacenPvdetalles.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenCollection
			If ( Not _alreadyFetchedAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles Or forceFetch Or _alwaysFetchAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacenCollectionViaMinvMovimientosAlmacenPvdetalles.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacenCollectionViaMinvMovimientosAlmacenPvdetalles)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(MinvMovimientosAlmacenPvEntity.Relations.MinvMovimientosAlmacenPvdetallesEntityUsingAlmacenIdFolioMovimiento, "__MinvMovimientosAlmacenPvEntity__", "MinvMovimientosAlmacenPvdetalles_", JoinHint.None)
				relations.Add(MinvMovimientosAlmacenPvdetallesEntity.Relations.AlmacenEntityUsingAlmacenId, "MinvMovimientosAlmacenPvdetalles_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MinvMovimientosAlmacenPvFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MinvMovimientosAlmacenPvFieldIndex.FolioMovimiento), ComparisonOperator.Equal, Me.FolioMovimiento))
				_almacenCollectionViaMinvMovimientosAlmacenPvdetalles.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacenCollectionViaMinvMovimientosAlmacenPvdetalles.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacenCollectionViaMinvMovimientosAlmacenPvdetalles.GetMulti(Filter, relations)
				_almacenCollectionViaMinvMovimientosAlmacenPvdetalles.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles = True
			End If
			Return _almacenCollectionViaMinvMovimientosAlmacenPvdetalles
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AlmacenCollectionViaMinvMovimientosAlmacenPvdetalles'. These settings will be taken into account
		''' when the property AlmacenCollectionViaMinvMovimientosAlmacenPvdetalles is requested or GetMultiAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacenCollectionViaMinvMovimientosAlmacenPvdetalles.SortClauses=sortClauses
			_almacenCollectionViaMinvMovimientosAlmacenPvdetalles.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViaMinvMovimientosAlmacenPvdetalles(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViaMinvMovimientosAlmacenPvdetalles(forceFetch, _productoCollectionViaMinvMovimientosAlmacenPvdetalles.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViaMinvMovimientosAlmacenPvdetalles(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViaMinvMovimientosAlmacenPvdetalles Or forceFetch Or _alwaysFetchProductoCollectionViaMinvMovimientosAlmacenPvdetalles) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViaMinvMovimientosAlmacenPvdetalles.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViaMinvMovimientosAlmacenPvdetalles)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(MinvMovimientosAlmacenPvEntity.Relations.MinvMovimientosAlmacenPvdetallesEntityUsingAlmacenIdFolioMovimiento, "__MinvMovimientosAlmacenPvEntity__", "MinvMovimientosAlmacenPvdetalles_", JoinHint.None)
				relations.Add(MinvMovimientosAlmacenPvdetallesEntity.Relations.ProductoEntityUsingProductoId, "MinvMovimientosAlmacenPvdetalles_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MinvMovimientosAlmacenPvFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(MinvMovimientosAlmacenPvFieldIndex.FolioMovimiento), ComparisonOperator.Equal, Me.FolioMovimiento))
				_productoCollectionViaMinvMovimientosAlmacenPvdetalles.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViaMinvMovimientosAlmacenPvdetalles.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViaMinvMovimientosAlmacenPvdetalles.GetMulti(Filter, relations)
				_productoCollectionViaMinvMovimientosAlmacenPvdetalles.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViaMinvMovimientosAlmacenPvdetalles = True
			End If
			Return _productoCollectionViaMinvMovimientosAlmacenPvdetalles
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViaMinvMovimientosAlmacenPvdetalles'. These settings will be taken into account
		''' when the property ProductoCollectionViaMinvMovimientosAlmacenPvdetalles is requested or GetMultiProductoCollectionViaMinvMovimientosAlmacenPvdetalles is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViaMinvMovimientosAlmacenPvdetalles(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViaMinvMovimientosAlmacenPvdetalles.SortClauses=sortClauses
			_productoCollectionViaMinvMovimientosAlmacenPvdetalles.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves the related entity of type 'CatMovimientosAlmacenPvEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'CatMovimientosAlmacenPvEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCatMovimientosAlmacenPv() As CatMovimientosAlmacenPvEntity
			Return GetSingleCatMovimientosAlmacenPv(False)
		End Function

		''' <summary>Retrieves the related entity of type 'CatMovimientosAlmacenPvEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'CatMovimientosAlmacenPvEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCatMovimientosAlmacenPv(forceFetch As Boolean) As CatMovimientosAlmacenPvEntity
			If ( Not _alreadyFetchedCatMovimientosAlmacenPv Or forceFetch Or _alwaysFetchCatMovimientosAlmacenPv) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New CatMovimientosAlmacenPvEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(MinvMovimientosAlmacenPvEntity.Relations.CatMovimientosAlmacenPvEntityUsingTipoMovimientoId) Then
					fetchResult = newEntity.FetchUsingPK(Me.TipoMovimientoId)
				End If
				If Not _catMovimientosAlmacenPvReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.CatMovimientosAlmacenPv = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), CatMovimientosAlmacenPvEntity)
					End If
					Me.CatMovimientosAlmacenPv = newEntity
					_alreadyFetchedCatMovimientosAlmacenPv = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _catMovimientosAlmacenPv
		End Function
	
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
				If MyBase.CheckIfLazyLoadingShouldOccur(MinvMovimientosAlmacenPvEntity.Relations.AlmacenEntityUsingAlmacenId) Then
					fetchResult = newEntity.FetchUsingPK(Me.AlmacenId)
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
	
	
		
		''' <summary>Sets the field On index fieldIndex To the New value value. Marks also the fields Object As dirty. </summary>
		''' <param name="fieldIndex">Index of field To Set the New value of</param>
		''' <param name="value">Value To Set</param>
		''' <param name="checkForRefetch">If Set To True, it will check If this entity Is out of sync And will refetch it first If it Is. Use True In normal behavior, False For framework specific code.</param>
		''' <returns>True If the value Is actually Set, False otherwise.</returns>
		''' <remarks>Dereferences a related Object In an 1:1/m:1 relation If the field Is an FK field And responsible For the reference of that particular related Object.</remarks>
		''' <exception cref="ArgumentOutOfRangeException">When fieldIndex Is smaller than 0 Or bigger than the number of fields In the fields collection.</exception>
		Protected Overrides Overloads Function SetNewFieldValue(fieldIndex As Integer, value As Object, checkForRefetch As Boolean) As Boolean
			Dim toReturn As Boolean = MyBase.SetNewFieldValue (fieldIndex, value, checkForRefetch, False)			
			If toReturn AndAlso System.Enum.IsDefined(GetType(MinvMovimientosAlmacenPvFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, MinvMovimientosAlmacenPvFieldIndex)
					Case MinvMovimientosAlmacenPvFieldIndex.AlmacenId
						DesetupSyncAlmacen(True, False)
						_alreadyFetchedAlmacen = False


					Case MinvMovimientosAlmacenPvFieldIndex.TipoMovimientoId
						DesetupSyncCatMovimientosAlmacenPv(True, False)
						_alreadyFetchedCatMovimientosAlmacenPv = False










					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_minvMovimientosAlmacenPvdetalles.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViaMinvMovimientosAlmacenPvdetalles.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaMinvMovimientosAlmacenPvdetalles.ActiveContext = MyBase.ActiveContext
		If Not _catMovimientosAlmacenPv Is Nothing Then
				_catMovimientosAlmacenPv.ActiveContext = MyBase.ActiveContext
			End If
		If Not _almacen Is Nothing Then
				_almacen.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As MinvMovimientosAlmacenPvDAO = CType(CreateDAOInstance(), MinvMovimientosAlmacenPvDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As MinvMovimientosAlmacenPvDAO = CType(CreateDAOInstance(), MinvMovimientosAlmacenPvDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As MinvMovimientosAlmacenPvDAO = CType(CreateDAOInstance(), MinvMovimientosAlmacenPvDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this MinvMovimientosAlmacenPvEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.MinvMovimientosAlmacenPvEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="almacenId">PK value for MinvMovimientosAlmacenPv which data should be fetched into this MinvMovimientosAlmacenPv Object</param>
		''' <param name="folioMovimiento">PK value for MinvMovimientosAlmacenPv which data should be fetched into this MinvMovimientosAlmacenPv Object</param>
		''' <param name="validator">The validator Object for this MinvMovimientosAlmacenPvEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(almacenId As System.Int32, folioMovimiento As System.String, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(almacenId, folioMovimiento, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_minvMovimientosAlmacenPvdetalles = New Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvdetallesCollection(New MinvMovimientosAlmacenPvdetallesEntityFactory())
			_minvMovimientosAlmacenPvdetalles.SetContainingEntityInfo(Me, "MinvMovimientosAlmacenPv")
			_alwaysFetchMinvMovimientosAlmacenPvdetalles = False
			_alreadyFetchedMinvMovimientosAlmacenPvdetalles = False
			_almacenCollectionViaMinvMovimientosAlmacenPvdetalles = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles = False
			_alreadyFetchedAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles = False
			_productoCollectionViaMinvMovimientosAlmacenPvdetalles = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaMinvMovimientosAlmacenPvdetalles = False
			_alreadyFetchedProductoCollectionViaMinvMovimientosAlmacenPvdetalles = False
			_catMovimientosAlmacenPv = Nothing
			_catMovimientosAlmacenPvReturnsNewIfNotFound = True
			_alwaysFetchCatMovimientosAlmacenPv = False
			_alreadyFetchedCatMovimientosAlmacenPv = False
			_almacen = Nothing
			_almacenReturnsNewIfNotFound = True
			_alwaysFetchAlmacen = False
			_alreadyFetchedAlmacen = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("AlmacenId", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioMovimiento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaMovimiento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TipoMovimientoId", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CostoTotal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Origen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Referencia", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("UsuarioId", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EstatusContabilizado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaContabilizacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("PolizaContabilidad", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Entrega", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Recibe", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Observaciones", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _catMovimientosAlmacenPv</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncCatMovimientosAlmacenPv(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _catMovimientosAlmacenPv, AddressOf OnCatMovimientosAlmacenPvPropertyChanged, "CatMovimientosAlmacenPv", MinvMovimientosAlmacenPvEntity.Relations.CatMovimientosAlmacenPvEntityUsingTipoMovimientoId, True, signalRelatedEntity, "MinvMovimientosAlmacenPv", resetFKFields, New Integer() { CInt(MinvMovimientosAlmacenPvFieldIndex.TipoMovimientoId) } )
			_catMovimientosAlmacenPv = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _catMovimientosAlmacenPv</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncCatMovimientosAlmacenPv(relatedEntity As IEntity)
			DesetupSyncCatMovimientosAlmacenPv(True, True)
			_catMovimientosAlmacenPv = CType(relatedEntity, CatMovimientosAlmacenPvEntity)
			MyBase.PerformSetupSyncRelatedEntity( _catMovimientosAlmacenPv, AddressOf OnCatMovimientosAlmacenPvPropertyChanged, "CatMovimientosAlmacenPv", MinvMovimientosAlmacenPvEntity.Relations.CatMovimientosAlmacenPvEntityUsingTipoMovimientoId, True, _alreadyFetchedCatMovimientosAlmacenPv, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnCatMovimientosAlmacenPvPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _almacen</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncAlmacen(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _almacen, AddressOf OnAlmacenPropertyChanged, "Almacen", MinvMovimientosAlmacenPvEntity.Relations.AlmacenEntityUsingAlmacenId, True, signalRelatedEntity, "MinvMovimientosAlmacenPv", resetFKFields, New Integer() { CInt(MinvMovimientosAlmacenPvFieldIndex.AlmacenId) } )
			_almacen = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _almacen</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncAlmacen(relatedEntity As IEntity)
			DesetupSyncAlmacen(True, True)
			_almacen = CType(relatedEntity, AlmacenEntity)
			MyBase.PerformSetupSyncRelatedEntity( _almacen, AddressOf OnAlmacenPropertyChanged, "Almacen", MinvMovimientosAlmacenPvEntity.Relations.AlmacenEntityUsingAlmacenId, True, _alreadyFetchedAlmacen, New String() {  } )
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



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="almacenId">PK value for MinvMovimientosAlmacenPv which data should be fetched into this MinvMovimientosAlmacenPv Object</param>
		''' <param name="folioMovimiento">PK value for MinvMovimientosAlmacenPv which data should be fetched into this MinvMovimientosAlmacenPv Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(almacenId As System.Int32, folioMovimiento As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(MinvMovimientosAlmacenPvFieldIndex.AlmacenId)).ForcedCurrentValueWrite(almacenId)
				MyBase.Fields(CInt(MinvMovimientosAlmacenPvFieldIndex.FolioMovimiento)).ForcedCurrentValueWrite(folioMovimiento)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateMinvMovimientosAlmacenPvDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New MinvMovimientosAlmacenPvEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As MinvMovimientosAlmacenPvRelations
			Get	
				Return New MinvMovimientosAlmacenPvRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MinvMovimientosAlmacenPvdetalles' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMinvMovimientosAlmacenPvdetalles() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvdetallesCollection(), _
					MinvMovimientosAlmacenPvEntity.Relations.MinvMovimientosAlmacenPvdetallesEntityUsingAlmacenIdFolioMovimiento, _
					CType(Integralab.ORM.EntityType.MinvMovimientosAlmacenPvEntity, Integer), CType(Integralab.ORM.EntityType.MinvMovimientosAlmacenPvdetallesEntity, Integer), 0, Nothing, Nothing, Nothing, "MinvMovimientosAlmacenPvdetalles", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MinvMovimientosAlmacenPvEntity.Relations.MinvMovimientosAlmacenPvdetallesEntityUsingAlmacenIdFolioMovimiento, "__MinvMovimientosAlmacenPvEntity__", String.Empty, JoinHint.None)
				relations.Add(MinvMovimientosAlmacenPvdetallesEntity.Relations.AlmacenEntityUsingAlmacenId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					MinvMovimientosAlmacenPvEntity.Relations.MinvMovimientosAlmacenPvdetallesEntityUsingAlmacenIdFolioMovimiento, _
					CType(Integralab.ORM.EntityType.MinvMovimientosAlmacenPvEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViaMinvMovimientosAlmacenPvdetalles", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaMinvMovimientosAlmacenPvdetalles() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(MinvMovimientosAlmacenPvEntity.Relations.MinvMovimientosAlmacenPvdetallesEntityUsingAlmacenIdFolioMovimiento, "__MinvMovimientosAlmacenPvEntity__", String.Empty, JoinHint.None)
				relations.Add(MinvMovimientosAlmacenPvdetallesEntity.Relations.ProductoEntityUsingProductoId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					MinvMovimientosAlmacenPvEntity.Relations.MinvMovimientosAlmacenPvdetallesEntityUsingAlmacenIdFolioMovimiento, _
					CType(Integralab.ORM.EntityType.MinvMovimientosAlmacenPvEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaMinvMovimientosAlmacenPvdetalles", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CatMovimientosAlmacenPv' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCatMovimientosAlmacenPv() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CatMovimientosAlmacenPvCollection(), _
					MinvMovimientosAlmacenPvEntity.Relations.CatMovimientosAlmacenPvEntityUsingTipoMovimientoId, _
					CType(Integralab.ORM.EntityType.MinvMovimientosAlmacenPvEntity, Integer), CType(Integralab.ORM.EntityType.CatMovimientosAlmacenPvEntity, Integer), 0, Nothing, Nothing, Nothing, "CatMovimientosAlmacenPv", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacen() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					MinvMovimientosAlmacenPvEntity.Relations.AlmacenEntityUsingAlmacenId, _
					CType(Integralab.ORM.EntityType.MinvMovimientosAlmacenPvEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "Almacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "MinvMovimientosAlmacenPvEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return MinvMovimientosAlmacenPvEntity.CustomProperties
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
				Return MinvMovimientosAlmacenPvEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The AlmacenId property of the Entity MinvMovimientosAlmacenPv<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacenPV"."AlmacenId"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [AlmacenId]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvMovimientosAlmacenPvFieldIndex.AlmacenId, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MinvMovimientosAlmacenPvFieldIndex.AlmacenId, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioMovimiento property of the Entity MinvMovimientosAlmacenPv<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacenPV"."FolioMovimiento"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [FolioMovimiento]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvMovimientosAlmacenPvFieldIndex.FolioMovimiento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MinvMovimientosAlmacenPvFieldIndex.FolioMovimiento, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaMovimiento property of the Entity MinvMovimientosAlmacenPv<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacenPV"."FechaMovimiento"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaMovimiento]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvMovimientosAlmacenPvFieldIndex.FechaMovimiento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(MinvMovimientosAlmacenPvFieldIndex.FechaMovimiento, Integer), value)
			End Set
		End Property
	
		''' <summary>The TipoMovimientoId property of the Entity MinvMovimientosAlmacenPv<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacenPV"."TipoMovimientoId"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TipoMovimientoId]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvMovimientosAlmacenPvFieldIndex.TipoMovimientoId, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MinvMovimientosAlmacenPvFieldIndex.TipoMovimientoId, Integer), value)
			End Set
		End Property
	
		''' <summary>The CostoTotal property of the Entity MinvMovimientosAlmacenPv<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacenPV"."CostoTotal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CostoTotal]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvMovimientosAlmacenPvFieldIndex.CostoTotal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(MinvMovimientosAlmacenPvFieldIndex.CostoTotal, Integer), value)
			End Set
		End Property
	
		''' <summary>The Origen property of the Entity MinvMovimientosAlmacenPv<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacenPV"."Origen"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 30<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Origen]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvMovimientosAlmacenPvFieldIndex.Origen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MinvMovimientosAlmacenPvFieldIndex.Origen, Integer), value)
			End Set
		End Property
	
		''' <summary>The Referencia property of the Entity MinvMovimientosAlmacenPv<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacenPV"."Referencia"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Referencia]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvMovimientosAlmacenPvFieldIndex.Referencia, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MinvMovimientosAlmacenPvFieldIndex.Referencia, Integer), value)
			End Set
		End Property
	
		''' <summary>The UsuarioId property of the Entity MinvMovimientosAlmacenPv<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacenPV"."UsuarioId"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [UsuarioId]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvMovimientosAlmacenPvFieldIndex.UsuarioId, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MinvMovimientosAlmacenPvFieldIndex.UsuarioId, Integer), value)
			End Set
		End Property
	
		''' <summary>The EstatusContabilizado property of the Entity MinvMovimientosAlmacenPv<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacenPV"."EstatusContabilizado"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [EstatusContabilizado]() As Nullable(Of System.Int16)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvMovimientosAlmacenPvFieldIndex.EstatusContabilizado, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int16))
			End Get
			Set
				SetNewFieldValue(CType(MinvMovimientosAlmacenPvFieldIndex.EstatusContabilizado, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaContabilizacion property of the Entity MinvMovimientosAlmacenPv<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacenPV"."FechaContabilizacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaContabilizacion]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvMovimientosAlmacenPvFieldIndex.FechaContabilizacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(MinvMovimientosAlmacenPvFieldIndex.FechaContabilizacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The PolizaContabilidad property of the Entity MinvMovimientosAlmacenPv<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacenPV"."PolizaContabilidad"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [PolizaContabilidad]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvMovimientosAlmacenPvFieldIndex.PolizaContabilidad, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MinvMovimientosAlmacenPvFieldIndex.PolizaContabilidad, Integer), value)
			End Set
		End Property
	
		''' <summary>The Entrega property of the Entity MinvMovimientosAlmacenPv<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacenPV"."Entrega"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 150<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Entrega]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvMovimientosAlmacenPvFieldIndex.Entrega, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MinvMovimientosAlmacenPvFieldIndex.Entrega, Integer), value)
			End Set
		End Property
	
		''' <summary>The Recibe property of the Entity MinvMovimientosAlmacenPv<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacenPV"."Recibe"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 150<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Recibe]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvMovimientosAlmacenPvFieldIndex.Recibe, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MinvMovimientosAlmacenPvFieldIndex.Recibe, Integer), value)
			End Set
		End Property
	
		''' <summary>The Observaciones property of the Entity MinvMovimientosAlmacenPv<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacenPV"."Observaciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Observaciones]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvMovimientosAlmacenPvFieldIndex.Observaciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MinvMovimientosAlmacenPvFieldIndex.Observaciones, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'MinvMovimientosAlmacenPvdetallesEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMinvMovimientosAlmacenPvdetalles()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MinvMovimientosAlmacenPvdetalles]() As Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvdetallesCollection
			Get
				Return GetMultiMinvMovimientosAlmacenPvdetalles(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MinvMovimientosAlmacenPvdetalles. When set to true, MinvMovimientosAlmacenPvdetalles is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MinvMovimientosAlmacenPvdetalles is accessed. You can always execute
		''' a forced fetch by calling GetMultiMinvMovimientosAlmacenPvdetalles(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMinvMovimientosAlmacenPvdetalles As Boolean
			Get
				Return _alwaysFetchMinvMovimientosAlmacenPvdetalles
			End Get
			Set
				_alwaysFetchMinvMovimientosAlmacenPvdetalles = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AlmacenCollectionViaMinvMovimientosAlmacenPvdetalles]() As Integralab.ORM.CollectionClasses.AlmacenCollection
			Get
				Return GetMultiAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AlmacenCollectionViaMinvMovimientosAlmacenPvdetalles. When set to true, AlmacenCollectionViaMinvMovimientosAlmacenPvdetalles is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AlmacenCollectionViaMinvMovimientosAlmacenPvdetalles is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles As Boolean
			Get
				Return _alwaysFetchAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles
			End Get
			Set
				_alwaysFetchAlmacenCollectionViaMinvMovimientosAlmacenPvdetalles = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViaMinvMovimientosAlmacenPvdetalles()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViaMinvMovimientosAlmacenPvdetalles]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViaMinvMovimientosAlmacenPvdetalles(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViaMinvMovimientosAlmacenPvdetalles. When set to true, ProductoCollectionViaMinvMovimientosAlmacenPvdetalles is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViaMinvMovimientosAlmacenPvdetalles is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViaMinvMovimientosAlmacenPvdetalles(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViaMinvMovimientosAlmacenPvdetalles As Boolean
			Get
				Return _alwaysFetchProductoCollectionViaMinvMovimientosAlmacenPvdetalles
			End Get
			Set
				_alwaysFetchProductoCollectionViaMinvMovimientosAlmacenPvdetalles = value
			End Set	
		End Property
	
	
		''' <summary>Gets / sets related entity of type 'CatMovimientosAlmacenPvEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCatMovimientosAlmacenPv()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [CatMovimientosAlmacenPv]() As CatMovimientosAlmacenPvEntity
			Get
				Return GetSingleCatMovimientosAlmacenPv(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncCatMovimientosAlmacenPv(value)
				Else
					If value Is Nothing Then
						If Not _catMovimientosAlmacenPv Is Nothing Then
							_catMovimientosAlmacenPv.UnsetRelatedEntity(Me, "MinvMovimientosAlmacenPv")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "MinvMovimientosAlmacenPv")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for CatMovimientosAlmacenPv. When set to true, CatMovimientosAlmacenPv is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CatMovimientosAlmacenPv is accessed. You can always execute
		''' a forced fetch by calling GetSingleCatMovimientosAlmacenPv(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCatMovimientosAlmacenPv As Boolean
			Get
				Return _alwaysFetchCatMovimientosAlmacenPv
			End Get
			Set
				_alwaysFetchCatMovimientosAlmacenPv = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property CatMovimientosAlmacenPv is not found
		''' in the database. When set to true, CatMovimientosAlmacenPv will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property CatMovimientosAlmacenPvReturnsNewIfNotFound As Boolean
			Get
				Return _catMovimientosAlmacenPvReturnsNewIfNotFound
			End Get
			Set
				_catMovimientosAlmacenPvReturnsNewIfNotFound = value
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
							_almacen.UnsetRelatedEntity(Me, "MinvMovimientosAlmacenPv")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "MinvMovimientosAlmacenPv")
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
				Return CInt(Integralab.ORM.EntityType.MinvMovimientosAlmacenPvEntity)
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
