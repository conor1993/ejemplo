' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 25 de enero de 2018 11:40:30
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
	''' <summary>Entity class which represents the entity 'CabProMed'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class CabProMedEntity 
#Else
	<Serializable()> _
	Public Class CabProMedEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _detDproMed As Integralab.ORM.CollectionClasses.DetDproMedCollection
		Private _alwaysFetchDetDproMed, _alreadyFetchedDetDproMed As Boolean
		Private _detProMed As Integralab.ORM.CollectionClasses.DetProMedCollection
		Private _alwaysFetchDetProMed, _alreadyFetchedDetProMed As Boolean
		Private _detProMedCollectionViaDetDproMed As Integralab.ORM.CollectionClasses.DetProMedCollection
		Private _alwaysFetchDetProMedCollectionViaDetDproMed, _alreadyFetchedDetProMedCollectionViaDetDproMed As Boolean
		Private _productoCollectionViaDetDproMed As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaDetDproMed, _alreadyFetchedProductoCollectionViaDetDproMed As Boolean
		Private _mcecatLotesCabCollectionViaDetDproMed As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
		Private _alwaysFetchMcecatLotesCabCollectionViaDetDproMed, _alreadyFetchedMcecatLotesCabCollectionViaDetDproMed As Boolean
		Private _productoCollectionViaDetProMed As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaDetProMed, _alreadyFetchedProductoCollectionViaDetProMed As Boolean
		Private _almacen As AlmacenEntity
		Private _alwaysFetchAlmacen, _alreadyFetchedAlmacen, _almacenReturnsNewIfNotFound As Boolean
		Private _inventarioMovimientoAlmacen As InventarioMovimientoAlmacenEntity
		Private _alwaysFetchInventarioMovimientoAlmacen, _alreadyFetchedInventarioMovimientoAlmacen, _inventarioMovimientoAlmacenReturnsNewIfNotFound As Boolean


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
		''' <param name="folioProrrateoMedicamento">PK value for CabProMed which data should be fetched into this CabProMed Object</param>
		Public Sub New(folioProrrateoMedicamento As System.String)

			InitClassFetch(folioProrrateoMedicamento, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folioProrrateoMedicamento">PK value for CabProMed which data should be fetched into this CabProMed Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(folioProrrateoMedicamento As System.String, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(folioProrrateoMedicamento, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folioProrrateoMedicamento">PK value for CabProMed which data should be fetched into this CabProMed Object</param>
		''' <param name="validator">The custom validator Object for this CabProMedEntity</param>
		Public Sub New(folioProrrateoMedicamento As System.String, validator As IValidator)

			InitClassFetch(folioProrrateoMedicamento, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_detDproMed = CType(info.GetValue("_detDproMed", GetType(Integralab.ORM.CollectionClasses.DetDproMedCollection)), Integralab.ORM.CollectionClasses.DetDproMedCollection)
			_alwaysFetchDetDproMed = info.GetBoolean("_alwaysFetchDetDproMed")
			_alreadyFetchedDetDproMed = info.GetBoolean("_alreadyFetchedDetDproMed")
			_detProMed = CType(info.GetValue("_detProMed", GetType(Integralab.ORM.CollectionClasses.DetProMedCollection)), Integralab.ORM.CollectionClasses.DetProMedCollection)
			_alwaysFetchDetProMed = info.GetBoolean("_alwaysFetchDetProMed")
			_alreadyFetchedDetProMed = info.GetBoolean("_alreadyFetchedDetProMed")
			_detProMedCollectionViaDetDproMed = CType(info.GetValue("_detProMedCollectionViaDetDproMed", GetType(Integralab.ORM.CollectionClasses.DetProMedCollection)), Integralab.ORM.CollectionClasses.DetProMedCollection)
			_alwaysFetchDetProMedCollectionViaDetDproMed = info.GetBoolean("_alwaysFetchDetProMedCollectionViaDetDproMed")
			_alreadyFetchedDetProMedCollectionViaDetDproMed = info.GetBoolean("_alreadyFetchedDetProMedCollectionViaDetDproMed")
			_productoCollectionViaDetDproMed = CType(info.GetValue("_productoCollectionViaDetDproMed", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaDetDproMed = info.GetBoolean("_alwaysFetchProductoCollectionViaDetDproMed")
			_alreadyFetchedProductoCollectionViaDetDproMed = info.GetBoolean("_alreadyFetchedProductoCollectionViaDetDproMed")
			_mcecatLotesCabCollectionViaDetDproMed = CType(info.GetValue("_mcecatLotesCabCollectionViaDetDproMed", GetType(Integralab.ORM.CollectionClasses.McecatLotesCabCollection)), Integralab.ORM.CollectionClasses.McecatLotesCabCollection)
			_alwaysFetchMcecatLotesCabCollectionViaDetDproMed = info.GetBoolean("_alwaysFetchMcecatLotesCabCollectionViaDetDproMed")
			_alreadyFetchedMcecatLotesCabCollectionViaDetDproMed = info.GetBoolean("_alreadyFetchedMcecatLotesCabCollectionViaDetDproMed")
			_productoCollectionViaDetProMed = CType(info.GetValue("_productoCollectionViaDetProMed", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaDetProMed = info.GetBoolean("_alwaysFetchProductoCollectionViaDetProMed")
			_alreadyFetchedProductoCollectionViaDetProMed = info.GetBoolean("_alreadyFetchedProductoCollectionViaDetProMed")
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

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedDetDproMed = (_detDproMed.Count > 0)
			_alreadyFetchedDetProMed = (_detProMed.Count > 0)
			_alreadyFetchedDetProMedCollectionViaDetDproMed = (_detProMedCollectionViaDetDproMed.Count > 0)
			_alreadyFetchedProductoCollectionViaDetDproMed = (_productoCollectionViaDetDproMed.Count > 0)
			_alreadyFetchedMcecatLotesCabCollectionViaDetDproMed = (_mcecatLotesCabCollectionViaDetDproMed.Count > 0)
			_alreadyFetchedProductoCollectionViaDetProMed = (_productoCollectionViaDetProMed.Count > 0)
			_alreadyFetchedAlmacen = Not(_almacen Is Nothing)
			_alreadyFetchedInventarioMovimientoAlmacen = Not(_inventarioMovimientoAlmacen Is Nothing)

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
			info.AddValue("_detDproMed", _detDproMed)
			info.AddValue("_alwaysFetchDetDproMed", _alwaysFetchDetDproMed)
			info.AddValue("_alreadyFetchedDetDproMed", _alreadyFetchedDetDproMed)
			info.AddValue("_detProMed", _detProMed)
			info.AddValue("_alwaysFetchDetProMed", _alwaysFetchDetProMed)
			info.AddValue("_alreadyFetchedDetProMed", _alreadyFetchedDetProMed)
			info.AddValue("_detProMedCollectionViaDetDproMed", _detProMedCollectionViaDetDproMed)
			info.AddValue("_alwaysFetchDetProMedCollectionViaDetDproMed", _alwaysFetchDetProMedCollectionViaDetDproMed)
			info.AddValue("_alreadyFetchedDetProMedCollectionViaDetDproMed", _alreadyFetchedDetProMedCollectionViaDetDproMed)
			info.AddValue("_productoCollectionViaDetDproMed", _productoCollectionViaDetDproMed)
			info.AddValue("_alwaysFetchProductoCollectionViaDetDproMed", _alwaysFetchProductoCollectionViaDetDproMed)
			info.AddValue("_alreadyFetchedProductoCollectionViaDetDproMed", _alreadyFetchedProductoCollectionViaDetDproMed)
			info.AddValue("_mcecatLotesCabCollectionViaDetDproMed", _mcecatLotesCabCollectionViaDetDproMed)
			info.AddValue("_alwaysFetchMcecatLotesCabCollectionViaDetDproMed", _alwaysFetchMcecatLotesCabCollectionViaDetDproMed)
			info.AddValue("_alreadyFetchedMcecatLotesCabCollectionViaDetDproMed", _alreadyFetchedMcecatLotesCabCollectionViaDetDproMed)
			info.AddValue("_productoCollectionViaDetProMed", _productoCollectionViaDetProMed)
			info.AddValue("_alwaysFetchProductoCollectionViaDetProMed", _alwaysFetchProductoCollectionViaDetProMed)
			info.AddValue("_alreadyFetchedProductoCollectionViaDetProMed", _alreadyFetchedProductoCollectionViaDetProMed)
			info.AddValue("_almacen", _almacen)
			info.AddValue("_almacenReturnsNewIfNotFound", _almacenReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchAlmacen", _alwaysFetchAlmacen)
			info.AddValue("_alreadyFetchedAlmacen", _alreadyFetchedAlmacen)
			info.AddValue("_inventarioMovimientoAlmacen", _inventarioMovimientoAlmacen)
			info.AddValue("_inventarioMovimientoAlmacenReturnsNewIfNotFound", _inventarioMovimientoAlmacenReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchInventarioMovimientoAlmacen", _alwaysFetchInventarioMovimientoAlmacen)
			info.AddValue("_alreadyFetchedInventarioMovimientoAlmacen", _alreadyFetchedInventarioMovimientoAlmacen)

			
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
				Case "DetDproMed"
					_alreadyFetchedDetDproMed = True
					If Not entity Is Nothing Then
						Me.DetDproMed.Add(CType(entity, DetDproMedEntity))
					End If
				Case "DetProMed"
					_alreadyFetchedDetProMed = True
					If Not entity Is Nothing Then
						Me.DetProMed.Add(CType(entity, DetProMedEntity))
					End If
				Case "DetProMedCollectionViaDetDproMed"
					_alreadyFetchedDetProMedCollectionViaDetDproMed = True
					If Not entity Is Nothing Then
						Me.DetProMedCollectionViaDetDproMed.Add(CType(entity, DetProMedEntity))
					End If
				Case "ProductoCollectionViaDetDproMed"
					_alreadyFetchedProductoCollectionViaDetDproMed = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaDetDproMed.Add(CType(entity, ProductoEntity))
					End If
				Case "McecatLotesCabCollectionViaDetDproMed"
					_alreadyFetchedMcecatLotesCabCollectionViaDetDproMed = True
					If Not entity Is Nothing Then
						Me.McecatLotesCabCollectionViaDetDproMed.Add(CType(entity, McecatLotesCabEntity))
					End If
				Case "ProductoCollectionViaDetProMed"
					_alreadyFetchedProductoCollectionViaDetProMed = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaDetProMed.Add(CType(entity, ProductoEntity))
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
				Case "DetDproMed"
					_detDproMed.Add(CType(relatedEntity, DetDproMedEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "DetProMed"
					_detProMed.Add(CType(relatedEntity, DetProMedEntity))
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
				Case "DetDproMed"
					MyBase.PerformRelatedEntityRemoval(_detDproMed, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "DetProMed"
					MyBase.PerformRelatedEntityRemoval(_detProMed, relatedEntity, signalRelatedEntityManyToOne)
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


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_detDproMed)
			toReturn.Add(_detProMed)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folioProrrateoMedicamento">PK value for CabProMed which data should be fetched into this CabProMed Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folioProrrateoMedicamento As System.String) As Boolean
			Return FetchUsingPK(folioProrrateoMedicamento, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folioProrrateoMedicamento">PK value for CabProMed which data should be fetched into this CabProMed Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folioProrrateoMedicamento As System.String, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(folioProrrateoMedicamento, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folioProrrateoMedicamento">PK value for CabProMed which data should be fetched into this CabProMed Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folioProrrateoMedicamento As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(folioProrrateoMedicamento, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.FolioProrrateoMedicamento, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As CabProMedFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As CabProMedFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'DetDproMedEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'DetDproMedEntity'</returns>
		Public Function GetMultiDetDproMed(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.DetDproMedCollection
			Return GetMultiDetDproMed(forceFetch, _detDproMed.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetDproMedEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiDetDproMed(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.DetDproMedCollection
			Return GetMultiDetDproMed(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetDproMedEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'DetDproMedEntity'</returns>
		Public Function GetMultiDetDproMed(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetDproMedCollection
			Return GetMultiDetDproMed(forceFetch, _detDproMed.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'DetDproMedEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiDetDproMed(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetDproMedCollection
			If ( Not _alreadyFetchedDetDproMed Or forceFetch Or _alwaysFetchDetDproMed) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _detDproMed.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_detDproMed)
					End If
				End If
				_detDproMed.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_detDproMed.EntityFactoryToUse = entityFactoryToUse
				End If
				_detDproMed.GetMultiManyToOne(Me, Nothing, Nothing, Nothing, Filter)
				_detDproMed.SuppressClearInGetMulti = False
				_alreadyFetchedDetDproMed = True
			End If
			Return _detDproMed
		End Function

		''' <summary>Sets the collection parameters for the collection for 'DetDproMed'. These settings will be taken into account
		''' when the property DetDproMed is requested or GetMultiDetDproMed is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersDetDproMed(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_detDproMed.SortClauses=sortClauses
			_detDproMed.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'DetProMedEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'DetProMedEntity'</returns>
		Public Function GetMultiDetProMed(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.DetProMedCollection
			Return GetMultiDetProMed(forceFetch, _detProMed.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetProMedEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiDetProMed(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.DetProMedCollection
			Return GetMultiDetProMed(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetProMedEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'DetProMedEntity'</returns>
		Public Function GetMultiDetProMed(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetProMedCollection
			Return GetMultiDetProMed(forceFetch, _detProMed.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'DetProMedEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiDetProMed(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetProMedCollection
			If ( Not _alreadyFetchedDetProMed Or forceFetch Or _alwaysFetchDetProMed) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _detProMed.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_detProMed)
					End If
				End If
				_detProMed.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_detProMed.EntityFactoryToUse = entityFactoryToUse
				End If
				_detProMed.GetMultiManyToOne(Me, Nothing, Filter)
				_detProMed.SuppressClearInGetMulti = False
				_alreadyFetchedDetProMed = True
			End If
			Return _detProMed
		End Function

		''' <summary>Sets the collection parameters for the collection for 'DetProMed'. These settings will be taken into account
		''' when the property DetProMed is requested or GetMultiDetProMed is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersDetProMed(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_detProMed.SortClauses=sortClauses
			_detProMed.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'DetProMedEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'DetProMedEntity'</returns>
		Public Function GetMultiDetProMedCollectionViaDetDproMed(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.DetProMedCollection
			Return GetMultiDetProMedCollectionViaDetDproMed(forceFetch, _detProMedCollectionViaDetDproMed.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'DetProMedEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiDetProMedCollectionViaDetDproMed(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.DetProMedCollection
			If ( Not _alreadyFetchedDetProMedCollectionViaDetDproMed Or forceFetch Or _alwaysFetchDetProMedCollectionViaDetDproMed) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _detProMedCollectionViaDetDproMed.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_detProMedCollectionViaDetDproMed)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CabProMedEntity.Relations.DetDproMedEntityUsingFolioProrrateoMedicamento, "__CabProMedEntity__", "DetDproMed_", JoinHint.None)
				relations.Add(DetDproMedEntity.Relations.DetProMedEntityUsingFolioProrrateoMedicamentoIdMedicamento, "DetDproMed_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CabProMedFieldIndex.FolioProrrateoMedicamento), ComparisonOperator.Equal, Me.FolioProrrateoMedicamento))
				_detProMedCollectionViaDetDproMed.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_detProMedCollectionViaDetDproMed.EntityFactoryToUse = entityFactoryToUse
				End If
				_detProMedCollectionViaDetDproMed.GetMulti(Filter, relations)
				_detProMedCollectionViaDetDproMed.SuppressClearInGetMulti = False
				_alreadyFetchedDetProMedCollectionViaDetDproMed = True
			End If
			Return _detProMedCollectionViaDetDproMed
		End Function

		''' <summary>Sets the collection parameters for the collection for 'DetProMedCollectionViaDetDproMed'. These settings will be taken into account
		''' when the property DetProMedCollectionViaDetDproMed is requested or GetMultiDetProMedCollectionViaDetDproMed is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersDetProMedCollectionViaDetDproMed(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_detProMedCollectionViaDetDproMed.SortClauses=sortClauses
			_detProMedCollectionViaDetDproMed.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViaDetDproMed(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViaDetDproMed(forceFetch, _productoCollectionViaDetDproMed.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViaDetDproMed(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViaDetDproMed Or forceFetch Or _alwaysFetchProductoCollectionViaDetDproMed) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViaDetDproMed.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViaDetDproMed)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CabProMedEntity.Relations.DetDproMedEntityUsingFolioProrrateoMedicamento, "__CabProMedEntity__", "DetDproMed_", JoinHint.None)
				relations.Add(DetDproMedEntity.Relations.ProductoEntityUsingIdMedicamento, "DetDproMed_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CabProMedFieldIndex.FolioProrrateoMedicamento), ComparisonOperator.Equal, Me.FolioProrrateoMedicamento))
				_productoCollectionViaDetDproMed.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViaDetDproMed.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViaDetDproMed.GetMulti(Filter, relations)
				_productoCollectionViaDetDproMed.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViaDetDproMed = True
			End If
			Return _productoCollectionViaDetDproMed
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViaDetDproMed'. These settings will be taken into account
		''' when the property ProductoCollectionViaDetDproMed is requested or GetMultiProductoCollectionViaDetDproMed is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViaDetDproMed(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViaDetDproMed.SortClauses=sortClauses
			_productoCollectionViaDetDproMed.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McecatLotesCabEntity'</returns>
		Public Function GetMultiMcecatLotesCabCollectionViaDetDproMed(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			Return GetMultiMcecatLotesCabCollectionViaDetDproMed(forceFetch, _mcecatLotesCabCollectionViaDetDproMed.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcecatLotesCabCollectionViaDetDproMed(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			If ( Not _alreadyFetchedMcecatLotesCabCollectionViaDetDproMed Or forceFetch Or _alwaysFetchMcecatLotesCabCollectionViaDetDproMed) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcecatLotesCabCollectionViaDetDproMed.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcecatLotesCabCollectionViaDetDproMed)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CabProMedEntity.Relations.DetDproMedEntityUsingFolioProrrateoMedicamento, "__CabProMedEntity__", "DetDproMed_", JoinHint.None)
				relations.Add(DetDproMedEntity.Relations.McecatLotesCabEntityUsingIdLote, "DetDproMed_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CabProMedFieldIndex.FolioProrrateoMedicamento), ComparisonOperator.Equal, Me.FolioProrrateoMedicamento))
				_mcecatLotesCabCollectionViaDetDproMed.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcecatLotesCabCollectionViaDetDproMed.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcecatLotesCabCollectionViaDetDproMed.GetMulti(Filter, relations)
				_mcecatLotesCabCollectionViaDetDproMed.SuppressClearInGetMulti = False
				_alreadyFetchedMcecatLotesCabCollectionViaDetDproMed = True
			End If
			Return _mcecatLotesCabCollectionViaDetDproMed
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McecatLotesCabCollectionViaDetDproMed'. These settings will be taken into account
		''' when the property McecatLotesCabCollectionViaDetDproMed is requested or GetMultiMcecatLotesCabCollectionViaDetDproMed is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcecatLotesCabCollectionViaDetDproMed(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcecatLotesCabCollectionViaDetDproMed.SortClauses=sortClauses
			_mcecatLotesCabCollectionViaDetDproMed.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViaDetProMed(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViaDetProMed(forceFetch, _productoCollectionViaDetProMed.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViaDetProMed(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViaDetProMed Or forceFetch Or _alwaysFetchProductoCollectionViaDetProMed) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViaDetProMed.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViaDetProMed)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CabProMedEntity.Relations.DetProMedEntityUsingFolioProrrateoMedicamento, "__CabProMedEntity__", "DetProMed_", JoinHint.None)
				relations.Add(DetProMedEntity.Relations.ProductoEntityUsingIdMedicamento, "DetProMed_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CabProMedFieldIndex.FolioProrrateoMedicamento), ComparisonOperator.Equal, Me.FolioProrrateoMedicamento))
				_productoCollectionViaDetProMed.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViaDetProMed.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViaDetProMed.GetMulti(Filter, relations)
				_productoCollectionViaDetProMed.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViaDetProMed = True
			End If
			Return _productoCollectionViaDetProMed
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViaDetProMed'. These settings will be taken into account
		''' when the property ProductoCollectionViaDetProMed is requested or GetMultiProductoCollectionViaDetProMed is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViaDetProMed(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViaDetProMed.SortClauses=sortClauses
			_productoCollectionViaDetProMed.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				If MyBase.CheckIfLazyLoadingShouldOccur(CabProMedEntity.Relations.AlmacenEntityUsingIdAlmacen) Then
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
				If MyBase.CheckIfLazyLoadingShouldOccur(CabProMedEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacenSalida) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdAlmacen, Me.FolioMovimientoAlmacenSalida)
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
	
	
		
		''' <summary>Sets the field On index fieldIndex To the New value value. Marks also the fields Object As dirty. </summary>
		''' <param name="fieldIndex">Index of field To Set the New value of</param>
		''' <param name="value">Value To Set</param>
		''' <param name="checkForRefetch">If Set To True, it will check If this entity Is out of sync And will refetch it first If it Is. Use True In normal behavior, False For framework specific code.</param>
		''' <returns>True If the value Is actually Set, False otherwise.</returns>
		''' <remarks>Dereferences a related Object In an 1:1/m:1 relation If the field Is an FK field And responsible For the reference of that particular related Object.</remarks>
		''' <exception cref="ArgumentOutOfRangeException">When fieldIndex Is smaller than 0 Or bigger than the number of fields In the fields collection.</exception>
		Protected Overrides Overloads Function SetNewFieldValue(fieldIndex As Integer, value As Object, checkForRefetch As Boolean) As Boolean
			Dim toReturn As Boolean = MyBase.SetNewFieldValue (fieldIndex, value, checkForRefetch, False)			
			If toReturn AndAlso System.Enum.IsDefined(GetType(CabProMedFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, CabProMedFieldIndex)

					Case CabProMedFieldIndex.IdAlmacen
						DesetupSyncAlmacen(True, False)
						_alreadyFetchedAlmacen = False
						DesetupSyncInventarioMovimientoAlmacen(True, False)
						_alreadyFetchedInventarioMovimientoAlmacen = False

					Case CabProMedFieldIndex.FolioMovimientoAlmacenSalida
						DesetupSyncInventarioMovimientoAlmacen(True, False)
						_alreadyFetchedInventarioMovimientoAlmacen = False






					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_detDproMed.ActiveContext = MyBase.ActiveContext
			_detProMed.ActiveContext = MyBase.ActiveContext
			_detProMedCollectionViaDetDproMed.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaDetDproMed.ActiveContext = MyBase.ActiveContext
			_mcecatLotesCabCollectionViaDetDproMed.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaDetProMed.ActiveContext = MyBase.ActiveContext
		If Not _almacen Is Nothing Then
				_almacen.ActiveContext = MyBase.ActiveContext
			End If
		If Not _inventarioMovimientoAlmacen Is Nothing Then
				_inventarioMovimientoAlmacen.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As CabProMedDAO = CType(CreateDAOInstance(), CabProMedDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As CabProMedDAO = CType(CreateDAOInstance(), CabProMedDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As CabProMedDAO = CType(CreateDAOInstance(), CabProMedDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this CabProMedEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CabProMedEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="folioProrrateoMedicamento">PK value for CabProMed which data should be fetched into this CabProMed Object</param>
		''' <param name="validator">The validator Object for this CabProMedEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(folioProrrateoMedicamento As System.String, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(folioProrrateoMedicamento, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_detDproMed = New Integralab.ORM.CollectionClasses.DetDproMedCollection(New DetDproMedEntityFactory())
			_detDproMed.SetContainingEntityInfo(Me, "CabProMed")
			_alwaysFetchDetDproMed = False
			_alreadyFetchedDetDproMed = False
			_detProMed = New Integralab.ORM.CollectionClasses.DetProMedCollection(New DetProMedEntityFactory())
			_detProMed.SetContainingEntityInfo(Me, "CabProMed")
			_alwaysFetchDetProMed = False
			_alreadyFetchedDetProMed = False
			_detProMedCollectionViaDetDproMed = New Integralab.ORM.CollectionClasses.DetProMedCollection(New DetProMedEntityFactory())
			_alwaysFetchDetProMedCollectionViaDetDproMed = False
			_alreadyFetchedDetProMedCollectionViaDetDproMed = False
			_productoCollectionViaDetDproMed = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaDetDproMed = False
			_alreadyFetchedProductoCollectionViaDetDproMed = False
			_mcecatLotesCabCollectionViaDetDproMed = New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(New McecatLotesCabEntityFactory())
			_alwaysFetchMcecatLotesCabCollectionViaDetDproMed = False
			_alreadyFetchedMcecatLotesCabCollectionViaDetDproMed = False
			_productoCollectionViaDetProMed = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaDetProMed = False
			_alreadyFetchedProductoCollectionViaDetProMed = False
			_almacen = Nothing
			_almacenReturnsNewIfNotFound = True
			_alwaysFetchAlmacen = False
			_alreadyFetchedAlmacen = False
			_inventarioMovimientoAlmacen = Nothing
			_inventarioMovimientoAlmacenReturnsNewIfNotFound = True
			_alwaysFetchInventarioMovimientoAlmacen = False
			_alreadyFetchedInventarioMovimientoAlmacen = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioProrrateoMedicamento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdAlmacen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdUsuarioAlta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioMovimientoAlmacenSalida", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("NumPoliza", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaProrrateo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCaptura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaContabilizacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CostoTotal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _almacen</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncAlmacen(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _almacen, AddressOf OnAlmacenPropertyChanged, "Almacen", CabProMedEntity.Relations.AlmacenEntityUsingIdAlmacen, True, signalRelatedEntity, "CabProMed", resetFKFields, New Integer() { CInt(CabProMedFieldIndex.IdAlmacen) } )
			_almacen = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _almacen</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncAlmacen(relatedEntity As IEntity)
			DesetupSyncAlmacen(True, True)
			_almacen = CType(relatedEntity, AlmacenEntity)
			MyBase.PerformSetupSyncRelatedEntity( _almacen, AddressOf OnAlmacenPropertyChanged, "Almacen", CabProMedEntity.Relations.AlmacenEntityUsingIdAlmacen, True, _alreadyFetchedAlmacen, New String() {  } )
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
			MyBase.PerformDesetupSyncRelatedEntity( _inventarioMovimientoAlmacen, AddressOf OnInventarioMovimientoAlmacenPropertyChanged, "InventarioMovimientoAlmacen", CabProMedEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacenSalida, True, signalRelatedEntity, "CabProMed", resetFKFields, New Integer() { CInt(CabProMedFieldIndex.IdAlmacen), CInt(CabProMedFieldIndex.FolioMovimientoAlmacenSalida) } )
			_inventarioMovimientoAlmacen = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _inventarioMovimientoAlmacen</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncInventarioMovimientoAlmacen(relatedEntity As IEntity)
			DesetupSyncInventarioMovimientoAlmacen(True, True)
			_inventarioMovimientoAlmacen = CType(relatedEntity, InventarioMovimientoAlmacenEntity)
			MyBase.PerformSetupSyncRelatedEntity( _inventarioMovimientoAlmacen, AddressOf OnInventarioMovimientoAlmacenPropertyChanged, "InventarioMovimientoAlmacen", CabProMedEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacenSalida, True, _alreadyFetchedInventarioMovimientoAlmacen, New String() {  } )
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



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="folioProrrateoMedicamento">PK value for CabProMed which data should be fetched into this CabProMed Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(folioProrrateoMedicamento As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(CabProMedFieldIndex.FolioProrrateoMedicamento)).ForcedCurrentValueWrite(folioProrrateoMedicamento)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateCabProMedDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New CabProMedEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As CabProMedRelations
			Get	
				Return New CabProMedRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DetDproMed' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDetDproMed() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DetDproMedCollection(), _
					CabProMedEntity.Relations.DetDproMedEntityUsingFolioProrrateoMedicamento, _
					CType(Integralab.ORM.EntityType.CabProMedEntity, Integer), CType(Integralab.ORM.EntityType.DetDproMedEntity, Integer), 0, Nothing, Nothing, Nothing, "DetDproMed", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DetProMed' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDetProMed() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DetProMedCollection(), _
					CabProMedEntity.Relations.DetProMedEntityUsingFolioProrrateoMedicamento, _
					CType(Integralab.ORM.EntityType.CabProMedEntity, Integer), CType(Integralab.ORM.EntityType.DetProMedEntity, Integer), 0, Nothing, Nothing, Nothing, "DetProMed", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DetProMed' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDetProMedCollectionViaDetDproMed() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CabProMedEntity.Relations.DetDproMedEntityUsingFolioProrrateoMedicamento, "__CabProMedEntity__", String.Empty, JoinHint.None)
				relations.Add(DetDproMedEntity.Relations.DetProMedEntityUsingFolioProrrateoMedicamentoIdMedicamento)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DetProMedCollection(), _
					CabProMedEntity.Relations.DetDproMedEntityUsingFolioProrrateoMedicamento, _
					CType(Integralab.ORM.EntityType.CabProMedEntity, Integer), CType(Integralab.ORM.EntityType.DetProMedEntity, Integer), 0, Nothing, Nothing, relations, "DetProMedCollectionViaDetDproMed", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaDetDproMed() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CabProMedEntity.Relations.DetDproMedEntityUsingFolioProrrateoMedicamento, "__CabProMedEntity__", String.Empty, JoinHint.None)
				relations.Add(DetDproMedEntity.Relations.ProductoEntityUsingIdMedicamento)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					CabProMedEntity.Relations.DetDproMedEntityUsingFolioProrrateoMedicamento, _
					CType(Integralab.ORM.EntityType.CabProMedEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaDetDproMed", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McecatLotesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcecatLotesCabCollectionViaDetDproMed() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CabProMedEntity.Relations.DetDproMedEntityUsingFolioProrrateoMedicamento, "__CabProMedEntity__", String.Empty, JoinHint.None)
				relations.Add(DetDproMedEntity.Relations.McecatLotesCabEntityUsingIdLote)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McecatLotesCabCollection(), _
					CabProMedEntity.Relations.DetDproMedEntityUsingFolioProrrateoMedicamento, _
					CType(Integralab.ORM.EntityType.CabProMedEntity, Integer), CType(Integralab.ORM.EntityType.McecatLotesCabEntity, Integer), 0, Nothing, Nothing, relations, "McecatLotesCabCollectionViaDetDproMed", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaDetProMed() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CabProMedEntity.Relations.DetProMedEntityUsingFolioProrrateoMedicamento, "__CabProMedEntity__", String.Empty, JoinHint.None)
				relations.Add(DetProMedEntity.Relations.ProductoEntityUsingIdMedicamento)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					CabProMedEntity.Relations.DetProMedEntityUsingFolioProrrateoMedicamento, _
					CType(Integralab.ORM.EntityType.CabProMedEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaDetProMed", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacen() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					CabProMedEntity.Relations.AlmacenEntityUsingIdAlmacen, _
					CType(Integralab.ORM.EntityType.CabProMedEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "Almacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'InventarioMovimientoAlmacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioMovimientoAlmacen() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.InventarioMovimientoAlmacenCollection(), _
					CabProMedEntity.Relations.InventarioMovimientoAlmacenEntityUsingIdAlmacenFolioMovimientoAlmacenSalida, _
					CType(Integralab.ORM.EntityType.CabProMedEntity, Integer), CType(Integralab.ORM.EntityType.InventarioMovimientoAlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "InventarioMovimientoAlmacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "CabProMedEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return CabProMedEntity.CustomProperties
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
				Return CabProMedEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The FolioProrrateoMedicamento property of the Entity CabProMed<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabProMed"."FolioProrrateoMedicamento"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 8<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [FolioProrrateoMedicamento]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabProMedFieldIndex.FolioProrrateoMedicamento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabProMedFieldIndex.FolioProrrateoMedicamento, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdAlmacen property of the Entity CabProMed<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabProMed"."IdAlmacen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdAlmacen]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabProMedFieldIndex.IdAlmacen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(CabProMedFieldIndex.IdAlmacen, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdUsuarioAlta property of the Entity CabProMed<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabProMed"."IdUsuarioAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdUsuarioAlta]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabProMedFieldIndex.IdUsuarioAlta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(CabProMedFieldIndex.IdUsuarioAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioMovimientoAlmacenSalida property of the Entity CabProMed<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabProMed"."FolioMovimientoAlmacenSalida"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FolioMovimientoAlmacenSalida]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabProMedFieldIndex.FolioMovimientoAlmacenSalida, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabProMedFieldIndex.FolioMovimientoAlmacenSalida, Integer), value)
			End Set
		End Property
	
		''' <summary>The NumPoliza property of the Entity CabProMed<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabProMed"."NumPoliza"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 8<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [NumPoliza]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabProMedFieldIndex.NumPoliza, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabProMedFieldIndex.NumPoliza, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaProrrateo property of the Entity CabProMed<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabProMed"."FechaProrrateo"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaProrrateo]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabProMedFieldIndex.FechaProrrateo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(CabProMedFieldIndex.FechaProrrateo, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCaptura property of the Entity CabProMed<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabProMed"."FechaCaptura"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaCaptura]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabProMedFieldIndex.FechaCaptura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(CabProMedFieldIndex.FechaCaptura, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaContabilizacion property of the Entity CabProMed<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabProMed"."FechaContabilizacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaContabilizacion]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabProMedFieldIndex.FechaContabilizacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(CabProMedFieldIndex.FechaContabilizacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The CostoTotal property of the Entity CabProMed<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabProMed"."CostoTotal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CostoTotal]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabProMedFieldIndex.CostoTotal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CabProMedFieldIndex.CostoTotal, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity CabProMed<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabProMed"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Byte
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabProMedFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Byte))
				End If
				Return CType(valueToReturn, System.Byte)
			End Get
			Set
				SetNewFieldValue(CType(CabProMedFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'DetDproMedEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDetDproMed()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [DetDproMed]() As Integralab.ORM.CollectionClasses.DetDproMedCollection
			Get
				Return GetMultiDetDproMed(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for DetDproMed. When set to true, DetDproMed is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time DetDproMed is accessed. You can always execute
		''' a forced fetch by calling GetMultiDetDproMed(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchDetDproMed As Boolean
			Get
				Return _alwaysFetchDetDproMed
			End Get
			Set
				_alwaysFetchDetDproMed = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'DetProMedEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDetProMed()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [DetProMed]() As Integralab.ORM.CollectionClasses.DetProMedCollection
			Get
				Return GetMultiDetProMed(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for DetProMed. When set to true, DetProMed is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time DetProMed is accessed. You can always execute
		''' a forced fetch by calling GetMultiDetProMed(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchDetProMed As Boolean
			Get
				Return _alwaysFetchDetProMed
			End Get
			Set
				_alwaysFetchDetProMed = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'DetProMedEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDetProMedCollectionViaDetDproMed()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [DetProMedCollectionViaDetDproMed]() As Integralab.ORM.CollectionClasses.DetProMedCollection
			Get
				Return GetMultiDetProMedCollectionViaDetDproMed(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for DetProMedCollectionViaDetDproMed. When set to true, DetProMedCollectionViaDetDproMed is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time DetProMedCollectionViaDetDproMed is accessed. You can always execute
		''' a forced fetch by calling GetMultiDetProMedCollectionViaDetDproMed(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchDetProMedCollectionViaDetDproMed As Boolean
			Get
				Return _alwaysFetchDetProMedCollectionViaDetDproMed
			End Get
			Set
				_alwaysFetchDetProMedCollectionViaDetDproMed = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViaDetDproMed()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViaDetDproMed]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViaDetDproMed(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViaDetDproMed. When set to true, ProductoCollectionViaDetDproMed is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViaDetDproMed is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViaDetDproMed(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViaDetDproMed As Boolean
			Get
				Return _alwaysFetchProductoCollectionViaDetDproMed
			End Get
			Set
				_alwaysFetchProductoCollectionViaDetDproMed = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McecatLotesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcecatLotesCabCollectionViaDetDproMed()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McecatLotesCabCollectionViaDetDproMed]() As Integralab.ORM.CollectionClasses.McecatLotesCabCollection
			Get
				Return GetMultiMcecatLotesCabCollectionViaDetDproMed(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McecatLotesCabCollectionViaDetDproMed. When set to true, McecatLotesCabCollectionViaDetDproMed is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McecatLotesCabCollectionViaDetDproMed is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcecatLotesCabCollectionViaDetDproMed(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcecatLotesCabCollectionViaDetDproMed As Boolean
			Get
				Return _alwaysFetchMcecatLotesCabCollectionViaDetDproMed
			End Get
			Set
				_alwaysFetchMcecatLotesCabCollectionViaDetDproMed = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViaDetProMed()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViaDetProMed]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViaDetProMed(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViaDetProMed. When set to true, ProductoCollectionViaDetProMed is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViaDetProMed is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViaDetProMed(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViaDetProMed As Boolean
			Get
				Return _alwaysFetchProductoCollectionViaDetProMed
			End Get
			Set
				_alwaysFetchProductoCollectionViaDetProMed = value
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
							_almacen.UnsetRelatedEntity(Me, "CabProMed")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "CabProMed")
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
							_inventarioMovimientoAlmacen.UnsetRelatedEntity(Me, "CabProMed")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "CabProMed")
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
				Return CInt(Integralab.ORM.EntityType.CabProMedEntity)
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
