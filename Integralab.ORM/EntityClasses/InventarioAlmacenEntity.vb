' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 8 de febrero de 2018 08:45:18
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
	''' <summary>Entity class which represents the entity 'InventarioAlmacen'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class InventarioAlmacenEntity 
#Else
	<Serializable()> _
	Public Class InventarioAlmacenEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _inventarioAlmacenLotes As Integralab.ORM.CollectionClasses.inventarioAlmacenLotesCollection
		Private _alwaysFetchInventarioAlmacenLotes, _alreadyFetchedInventarioAlmacenLotes As Boolean
		Private _almacenCollectionViainventarioAlmacenLotes As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViainventarioAlmacenLotes, _alreadyFetchedAlmacenCollectionViainventarioAlmacenLotes As Boolean
		Private _productoCollectionViainventarioAlmacenLotes As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViainventarioAlmacenLotes, _alreadyFetchedProductoCollectionViainventarioAlmacenLotes As Boolean
		Private _almacen As AlmacenEntity
		Private _alwaysFetchAlmacen, _alreadyFetchedAlmacen, _almacenReturnsNewIfNotFound As Boolean
		Private _producto As ProductoEntity
		Private _alwaysFetchProducto, _alreadyFetchedProducto, _productoReturnsNewIfNotFound As Boolean


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
		''' <param name="almacenId">PK value for InventarioAlmacen which data should be fetched into this InventarioAlmacen Object</param>
		''' <param name="productoId">PK value for InventarioAlmacen which data should be fetched into this InventarioAlmacen Object</param>
		''' <param name="año">PK value for InventarioAlmacen which data should be fetched into this InventarioAlmacen Object</param>
		''' <param name="mes">PK value for InventarioAlmacen which data should be fetched into this InventarioAlmacen Object</param>
		Public Sub New(almacenId As System.Int32, productoId As System.Int32, año As System.Int32, mes As System.Int32)

			InitClassFetch(almacenId, productoId, año, mes, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="almacenId">PK value for InventarioAlmacen which data should be fetched into this InventarioAlmacen Object</param>
		''' <param name="productoId">PK value for InventarioAlmacen which data should be fetched into this InventarioAlmacen Object</param>
		''' <param name="año">PK value for InventarioAlmacen which data should be fetched into this InventarioAlmacen Object</param>
		''' <param name="mes">PK value for InventarioAlmacen which data should be fetched into this InventarioAlmacen Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(almacenId As System.Int32, productoId As System.Int32, año As System.Int32, mes As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(almacenId, productoId, año, mes, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="almacenId">PK value for InventarioAlmacen which data should be fetched into this InventarioAlmacen Object</param>
		''' <param name="productoId">PK value for InventarioAlmacen which data should be fetched into this InventarioAlmacen Object</param>
		''' <param name="año">PK value for InventarioAlmacen which data should be fetched into this InventarioAlmacen Object</param>
		''' <param name="mes">PK value for InventarioAlmacen which data should be fetched into this InventarioAlmacen Object</param>
		''' <param name="validator">The custom validator Object for this InventarioAlmacenEntity</param>
		Public Sub New(almacenId As System.Int32, productoId As System.Int32, año As System.Int32, mes As System.Int32, validator As IValidator)

			InitClassFetch(almacenId, productoId, año, mes, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_inventarioAlmacenLotes = CType(info.GetValue("_inventarioAlmacenLotes", GetType(Integralab.ORM.CollectionClasses.inventarioAlmacenLotesCollection)), Integralab.ORM.CollectionClasses.inventarioAlmacenLotesCollection)
			_alwaysFetchInventarioAlmacenLotes = info.GetBoolean("_alwaysFetchInventarioAlmacenLotes")
			_alreadyFetchedInventarioAlmacenLotes = info.GetBoolean("_alreadyFetchedInventarioAlmacenLotes")
			_almacenCollectionViainventarioAlmacenLotes = CType(info.GetValue("_almacenCollectionViainventarioAlmacenLotes", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViainventarioAlmacenLotes = info.GetBoolean("_alwaysFetchAlmacenCollectionViainventarioAlmacenLotes")
			_alreadyFetchedAlmacenCollectionViainventarioAlmacenLotes = info.GetBoolean("_alreadyFetchedAlmacenCollectionViainventarioAlmacenLotes")
			_productoCollectionViainventarioAlmacenLotes = CType(info.GetValue("_productoCollectionViainventarioAlmacenLotes", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViainventarioAlmacenLotes = info.GetBoolean("_alwaysFetchProductoCollectionViainventarioAlmacenLotes")
			_alreadyFetchedProductoCollectionViainventarioAlmacenLotes = info.GetBoolean("_alreadyFetchedProductoCollectionViainventarioAlmacenLotes")
			_almacen = CType(info.GetValue("_almacen", GetType(AlmacenEntity)), AlmacenEntity)
			If Not _almacen Is Nothing Then
				AddHandler _almacen.AfterSave, AddressOf OnEntityAfterSave
			End If
			_almacenReturnsNewIfNotFound = info.GetBoolean("_almacenReturnsNewIfNotFound")
			_alwaysFetchAlmacen = info.GetBoolean("_alwaysFetchAlmacen")
			_alreadyFetchedAlmacen = info.GetBoolean("_alreadyFetchedAlmacen")
			_producto = CType(info.GetValue("_producto", GetType(ProductoEntity)), ProductoEntity)
			If Not _producto Is Nothing Then
				AddHandler _producto.AfterSave, AddressOf OnEntityAfterSave
			End If
			_productoReturnsNewIfNotFound = info.GetBoolean("_productoReturnsNewIfNotFound")
			_alwaysFetchProducto = info.GetBoolean("_alwaysFetchProducto")
			_alreadyFetchedProducto = info.GetBoolean("_alreadyFetchedProducto")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedInventarioAlmacenLotes = (_inventarioAlmacenLotes.Count > 0)
			_alreadyFetchedAlmacenCollectionViainventarioAlmacenLotes = (_almacenCollectionViainventarioAlmacenLotes.Count > 0)
			_alreadyFetchedProductoCollectionViainventarioAlmacenLotes = (_productoCollectionViainventarioAlmacenLotes.Count > 0)
			_alreadyFetchedAlmacen = Not(_almacen Is Nothing)
			_alreadyFetchedProducto = Not(_producto Is Nothing)

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
			info.AddValue("_inventarioAlmacenLotes", _inventarioAlmacenLotes)
			info.AddValue("_alwaysFetchInventarioAlmacenLotes", _alwaysFetchInventarioAlmacenLotes)
			info.AddValue("_alreadyFetchedInventarioAlmacenLotes", _alreadyFetchedInventarioAlmacenLotes)
			info.AddValue("_almacenCollectionViainventarioAlmacenLotes", _almacenCollectionViainventarioAlmacenLotes)
			info.AddValue("_alwaysFetchAlmacenCollectionViainventarioAlmacenLotes", _alwaysFetchAlmacenCollectionViainventarioAlmacenLotes)
			info.AddValue("_alreadyFetchedAlmacenCollectionViainventarioAlmacenLotes", _alreadyFetchedAlmacenCollectionViainventarioAlmacenLotes)
			info.AddValue("_productoCollectionViainventarioAlmacenLotes", _productoCollectionViainventarioAlmacenLotes)
			info.AddValue("_alwaysFetchProductoCollectionViainventarioAlmacenLotes", _alwaysFetchProductoCollectionViainventarioAlmacenLotes)
			info.AddValue("_alreadyFetchedProductoCollectionViainventarioAlmacenLotes", _alreadyFetchedProductoCollectionViainventarioAlmacenLotes)
			info.AddValue("_almacen", _almacen)
			info.AddValue("_almacenReturnsNewIfNotFound", _almacenReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchAlmacen", _alwaysFetchAlmacen)
			info.AddValue("_alreadyFetchedAlmacen", _alreadyFetchedAlmacen)
			info.AddValue("_producto", _producto)
			info.AddValue("_productoReturnsNewIfNotFound", _productoReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchProducto", _alwaysFetchProducto)
			info.AddValue("_alreadyFetchedProducto", _alreadyFetchedProducto)

			
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
				Case "Producto"
					_alreadyFetchedProducto = True
					Me.Producto = CType(entity, ProductoEntity)
				Case "InventarioAlmacenLotes"
					_alreadyFetchedInventarioAlmacenLotes = True
					If Not entity Is Nothing Then
						Me.InventarioAlmacenLotes.Add(CType(entity, inventarioAlmacenLotesEntity))
					End If
				Case "AlmacenCollectionViainventarioAlmacenLotes"
					_alreadyFetchedAlmacenCollectionViainventarioAlmacenLotes = True
					If Not entity Is Nothing Then
						Me.AlmacenCollectionViainventarioAlmacenLotes.Add(CType(entity, AlmacenEntity))
					End If
				Case "ProductoCollectionViainventarioAlmacenLotes"
					_alreadyFetchedProductoCollectionViainventarioAlmacenLotes = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViainventarioAlmacenLotes.Add(CType(entity, ProductoEntity))
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
				Case "Producto"
					SetupSyncProducto(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "InventarioAlmacenLotes"
					_inventarioAlmacenLotes.Add(CType(relatedEntity, inventarioAlmacenLotesEntity))
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
				Case "Producto"
					DesetupSyncProducto(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "InventarioAlmacenLotes"
					MyBase.PerformRelatedEntityRemoval(_inventarioAlmacenLotes, relatedEntity, signalRelatedEntityManyToOne)
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
			If Not _producto Is Nothing Then
				toReturn.Add(_producto)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_inventarioAlmacenLotes)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="almacenId">PK value for InventarioAlmacen which data should be fetched into this InventarioAlmacen Object</param>
		''' <param name="productoId">PK value for InventarioAlmacen which data should be fetched into this InventarioAlmacen Object</param>
		''' <param name="año">PK value for InventarioAlmacen which data should be fetched into this InventarioAlmacen Object</param>
		''' <param name="mes">PK value for InventarioAlmacen which data should be fetched into this InventarioAlmacen Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(almacenId As System.Int32, productoId As System.Int32, año As System.Int32, mes As System.Int32) As Boolean
			Return FetchUsingPK(almacenId, productoId, año, mes, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="almacenId">PK value for InventarioAlmacen which data should be fetched into this InventarioAlmacen Object</param>
		''' <param name="productoId">PK value for InventarioAlmacen which data should be fetched into this InventarioAlmacen Object</param>
		''' <param name="año">PK value for InventarioAlmacen which data should be fetched into this InventarioAlmacen Object</param>
		''' <param name="mes">PK value for InventarioAlmacen which data should be fetched into this InventarioAlmacen Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(almacenId As System.Int32, productoId As System.Int32, año As System.Int32, mes As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(almacenId, productoId, año, mes, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="almacenId">PK value for InventarioAlmacen which data should be fetched into this InventarioAlmacen Object</param>
		''' <param name="productoId">PK value for InventarioAlmacen which data should be fetched into this InventarioAlmacen Object</param>
		''' <param name="año">PK value for InventarioAlmacen which data should be fetched into this InventarioAlmacen Object</param>
		''' <param name="mes">PK value for InventarioAlmacen which data should be fetched into this InventarioAlmacen Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(almacenId As System.Int32, productoId As System.Int32, año As System.Int32, mes As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(almacenId, productoId, año, mes, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.AlmacenId, Me.ProductoId, Me.Año, Me.Mes, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As InventarioAlmacenFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As InventarioAlmacenFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'inventarioAlmacenLotesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'inventarioAlmacenLotesEntity'</returns>
		Public Function GetMultiInventarioAlmacenLotes(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.inventarioAlmacenLotesCollection
			Return GetMultiInventarioAlmacenLotes(forceFetch, _inventarioAlmacenLotes.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'inventarioAlmacenLotesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiInventarioAlmacenLotes(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.inventarioAlmacenLotesCollection
			Return GetMultiInventarioAlmacenLotes(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'inventarioAlmacenLotesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'inventarioAlmacenLotesEntity'</returns>
		Public Function GetMultiInventarioAlmacenLotes(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.inventarioAlmacenLotesCollection
			Return GetMultiInventarioAlmacenLotes(forceFetch, _inventarioAlmacenLotes.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'inventarioAlmacenLotesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiInventarioAlmacenLotes(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.inventarioAlmacenLotesCollection
			If ( Not _alreadyFetchedInventarioAlmacenLotes Or forceFetch Or _alwaysFetchInventarioAlmacenLotes) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _inventarioAlmacenLotes.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_inventarioAlmacenLotes)
					End If
				End If
				_inventarioAlmacenLotes.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_inventarioAlmacenLotes.EntityFactoryToUse = entityFactoryToUse
				End If
				_inventarioAlmacenLotes.GetMultiManyToOne(Nothing, Nothing, Me, Filter)
				_inventarioAlmacenLotes.SuppressClearInGetMulti = False
				_alreadyFetchedInventarioAlmacenLotes = True
			End If
			Return _inventarioAlmacenLotes
		End Function

		''' <summary>Sets the collection parameters for the collection for 'InventarioAlmacenLotes'. These settings will be taken into account
		''' when the property InventarioAlmacenLotes is requested or GetMultiInventarioAlmacenLotes is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersInventarioAlmacenLotes(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_inventarioAlmacenLotes.SortClauses=sortClauses
			_inventarioAlmacenLotes.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacenCollectionViainventarioAlmacenLotes(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacenCollectionViainventarioAlmacenLotes(forceFetch, _almacenCollectionViainventarioAlmacenLotes.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacenCollectionViainventarioAlmacenLotes(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenCollection
			If ( Not _alreadyFetchedAlmacenCollectionViainventarioAlmacenLotes Or forceFetch Or _alwaysFetchAlmacenCollectionViainventarioAlmacenLotes) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacenCollectionViainventarioAlmacenLotes.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacenCollectionViainventarioAlmacenLotes)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(InventarioAlmacenEntity.Relations.inventarioAlmacenLotesEntityUsingAlmacenIdProductoIdAñoMes, "__InventarioAlmacenEntity__", "inventarioAlmacenLotes_", JoinHint.None)
				relations.Add(inventarioAlmacenLotesEntity.Relations.AlmacenEntityUsingAlmacenId, "inventarioAlmacenLotes_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioAlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioAlmacenFieldIndex.ProductoId), ComparisonOperator.Equal, Me.ProductoId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioAlmacenFieldIndex.Año), ComparisonOperator.Equal, Me.Año))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioAlmacenFieldIndex.Mes), ComparisonOperator.Equal, Me.Mes))
				_almacenCollectionViainventarioAlmacenLotes.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacenCollectionViainventarioAlmacenLotes.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacenCollectionViainventarioAlmacenLotes.GetMulti(Filter, relations)
				_almacenCollectionViainventarioAlmacenLotes.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacenCollectionViainventarioAlmacenLotes = True
			End If
			Return _almacenCollectionViainventarioAlmacenLotes
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AlmacenCollectionViainventarioAlmacenLotes'. These settings will be taken into account
		''' when the property AlmacenCollectionViainventarioAlmacenLotes is requested or GetMultiAlmacenCollectionViainventarioAlmacenLotes is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacenCollectionViainventarioAlmacenLotes(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacenCollectionViainventarioAlmacenLotes.SortClauses=sortClauses
			_almacenCollectionViainventarioAlmacenLotes.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViainventarioAlmacenLotes(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViainventarioAlmacenLotes(forceFetch, _productoCollectionViainventarioAlmacenLotes.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViainventarioAlmacenLotes(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViainventarioAlmacenLotes Or forceFetch Or _alwaysFetchProductoCollectionViainventarioAlmacenLotes) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViainventarioAlmacenLotes.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViainventarioAlmacenLotes)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(InventarioAlmacenEntity.Relations.inventarioAlmacenLotesEntityUsingAlmacenIdProductoIdAñoMes, "__InventarioAlmacenEntity__", "inventarioAlmacenLotes_", JoinHint.None)
				relations.Add(inventarioAlmacenLotesEntity.Relations.ProductoEntityUsingProductoId, "inventarioAlmacenLotes_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioAlmacenFieldIndex.AlmacenId), ComparisonOperator.Equal, Me.AlmacenId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioAlmacenFieldIndex.ProductoId), ComparisonOperator.Equal, Me.ProductoId))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioAlmacenFieldIndex.Año), ComparisonOperator.Equal, Me.Año))
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(InventarioAlmacenFieldIndex.Mes), ComparisonOperator.Equal, Me.Mes))
				_productoCollectionViainventarioAlmacenLotes.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViainventarioAlmacenLotes.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViainventarioAlmacenLotes.GetMulti(Filter, relations)
				_productoCollectionViainventarioAlmacenLotes.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViainventarioAlmacenLotes = True
			End If
			Return _productoCollectionViainventarioAlmacenLotes
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViainventarioAlmacenLotes'. These settings will be taken into account
		''' when the property ProductoCollectionViainventarioAlmacenLotes is requested or GetMultiProductoCollectionViainventarioAlmacenLotes is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViainventarioAlmacenLotes(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViainventarioAlmacenLotes.SortClauses=sortClauses
			_productoCollectionViainventarioAlmacenLotes.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				If MyBase.CheckIfLazyLoadingShouldOccur(InventarioAlmacenEntity.Relations.AlmacenEntityUsingAlmacenId) Then
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
	
		''' <summary>Retrieves the related entity of type 'ProductoEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'ProductoEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleProducto() As ProductoEntity
			Return GetSingleProducto(False)
		End Function

		''' <summary>Retrieves the related entity of type 'ProductoEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'ProductoEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleProducto(forceFetch As Boolean) As ProductoEntity
			If ( Not _alreadyFetchedProducto Or forceFetch Or _alwaysFetchProducto) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New ProductoEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(InventarioAlmacenEntity.Relations.ProductoEntityUsingProductoId) Then
					fetchResult = newEntity.FetchUsingPK(Me.ProductoId)
				End If
				If Not _productoReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Producto = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), ProductoEntity)
					End If
					Me.Producto = newEntity
					_alreadyFetchedProducto = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _producto
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(InventarioAlmacenFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, InventarioAlmacenFieldIndex)
					Case InventarioAlmacenFieldIndex.AlmacenId
						DesetupSyncAlmacen(True, False)
						_alreadyFetchedAlmacen = False
					Case InventarioAlmacenFieldIndex.ProductoId
						DesetupSyncProducto(True, False)
						_alreadyFetchedProducto = False












					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_inventarioAlmacenLotes.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViainventarioAlmacenLotes.ActiveContext = MyBase.ActiveContext
			_productoCollectionViainventarioAlmacenLotes.ActiveContext = MyBase.ActiveContext
		If Not _almacen Is Nothing Then
				_almacen.ActiveContext = MyBase.ActiveContext
			End If
		If Not _producto Is Nothing Then
				_producto.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As InventarioAlmacenDAO = CType(CreateDAOInstance(), InventarioAlmacenDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As InventarioAlmacenDAO = CType(CreateDAOInstance(), InventarioAlmacenDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As InventarioAlmacenDAO = CType(CreateDAOInstance(), InventarioAlmacenDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this InventarioAlmacenEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.InventarioAlmacenEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="almacenId">PK value for InventarioAlmacen which data should be fetched into this InventarioAlmacen Object</param>
		''' <param name="productoId">PK value for InventarioAlmacen which data should be fetched into this InventarioAlmacen Object</param>
		''' <param name="año">PK value for InventarioAlmacen which data should be fetched into this InventarioAlmacen Object</param>
		''' <param name="mes">PK value for InventarioAlmacen which data should be fetched into this InventarioAlmacen Object</param>
		''' <param name="validator">The validator Object for this InventarioAlmacenEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(almacenId As System.Int32, productoId As System.Int32, año As System.Int32, mes As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(almacenId, productoId, año, mes, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_inventarioAlmacenLotes = New Integralab.ORM.CollectionClasses.inventarioAlmacenLotesCollection(New inventarioAlmacenLotesEntityFactory())
			_inventarioAlmacenLotes.SetContainingEntityInfo(Me, "InventarioAlmacen")
			_alwaysFetchInventarioAlmacenLotes = False
			_alreadyFetchedInventarioAlmacenLotes = False
			_almacenCollectionViainventarioAlmacenLotes = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViainventarioAlmacenLotes = False
			_alreadyFetchedAlmacenCollectionViainventarioAlmacenLotes = False
			_productoCollectionViainventarioAlmacenLotes = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViainventarioAlmacenLotes = False
			_alreadyFetchedProductoCollectionViainventarioAlmacenLotes = False
			_almacen = Nothing
			_almacenReturnsNewIfNotFound = True
			_alwaysFetchAlmacen = False
			_alreadyFetchedAlmacen = False
			_producto = Nothing
			_productoReturnsNewIfNotFound = True
			_alwaysFetchProducto = False
			_alreadyFetchedProducto = False

			
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

			_fieldsCustomProperties.Add("ProductoId", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Año", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Mes", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaUltimoCosto", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("UltimoCosto", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CostoPromedio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CantidadInicial", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CantidadExistencia", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CantidadEntrada", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaUltimaEntrada", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CantidadSalidas", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaUltimaSalida", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CantidadPorSurtir", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _almacen</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncAlmacen(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _almacen, AddressOf OnAlmacenPropertyChanged, "Almacen", InventarioAlmacenEntity.Relations.AlmacenEntityUsingAlmacenId, True, signalRelatedEntity, "InventarioAlmacen", resetFKFields, New Integer() { CInt(InventarioAlmacenFieldIndex.AlmacenId) } )
			_almacen = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _almacen</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncAlmacen(relatedEntity As IEntity)
			DesetupSyncAlmacen(True, True)
			_almacen = CType(relatedEntity, AlmacenEntity)
			MyBase.PerformSetupSyncRelatedEntity( _almacen, AddressOf OnAlmacenPropertyChanged, "Almacen", InventarioAlmacenEntity.Relations.AlmacenEntityUsingAlmacenId, True, _alreadyFetchedAlmacen, New String() {  } )
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
		''' <summary>Removes the sync logic for member _producto</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncProducto(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _producto, AddressOf OnProductoPropertyChanged, "Producto", InventarioAlmacenEntity.Relations.ProductoEntityUsingProductoId, True, signalRelatedEntity, "InventarioAlmacen", resetFKFields, New Integer() { CInt(InventarioAlmacenFieldIndex.ProductoId) } )
			_producto = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _producto</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncProducto(relatedEntity As IEntity)
			DesetupSyncProducto(True, True)
			_producto = CType(relatedEntity, ProductoEntity)
			MyBase.PerformSetupSyncRelatedEntity( _producto, AddressOf OnProductoPropertyChanged, "Producto", InventarioAlmacenEntity.Relations.ProductoEntityUsingProductoId, True, _alreadyFetchedProducto, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnProductoPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="almacenId">PK value for InventarioAlmacen which data should be fetched into this InventarioAlmacen Object</param>
		''' <param name="productoId">PK value for InventarioAlmacen which data should be fetched into this InventarioAlmacen Object</param>
		''' <param name="año">PK value for InventarioAlmacen which data should be fetched into this InventarioAlmacen Object</param>
		''' <param name="mes">PK value for InventarioAlmacen which data should be fetched into this InventarioAlmacen Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(almacenId As System.Int32, productoId As System.Int32, año As System.Int32, mes As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(InventarioAlmacenFieldIndex.AlmacenId)).ForcedCurrentValueWrite(almacenId)
				MyBase.Fields(CInt(InventarioAlmacenFieldIndex.ProductoId)).ForcedCurrentValueWrite(productoId)
				MyBase.Fields(CInt(InventarioAlmacenFieldIndex.Año)).ForcedCurrentValueWrite(año)
				MyBase.Fields(CInt(InventarioAlmacenFieldIndex.Mes)).ForcedCurrentValueWrite(mes)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateInventarioAlmacenDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New InventarioAlmacenEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As InventarioAlmacenRelations
			Get	
				Return New InventarioAlmacenRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'inventarioAlmacenLotes' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathInventarioAlmacenLotes() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.inventarioAlmacenLotesCollection(), _
					InventarioAlmacenEntity.Relations.inventarioAlmacenLotesEntityUsingAlmacenIdProductoIdAñoMes, _
					CType(Integralab.ORM.EntityType.InventarioAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.inventarioAlmacenLotesEntity, Integer), 0, Nothing, Nothing, Nothing, "InventarioAlmacenLotes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViainventarioAlmacenLotes() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(InventarioAlmacenEntity.Relations.inventarioAlmacenLotesEntityUsingAlmacenIdProductoIdAñoMes, "__InventarioAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(inventarioAlmacenLotesEntity.Relations.AlmacenEntityUsingAlmacenId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					InventarioAlmacenEntity.Relations.inventarioAlmacenLotesEntityUsingAlmacenIdProductoIdAñoMes, _
					CType(Integralab.ORM.EntityType.InventarioAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViainventarioAlmacenLotes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViainventarioAlmacenLotes() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(InventarioAlmacenEntity.Relations.inventarioAlmacenLotesEntityUsingAlmacenIdProductoIdAñoMes, "__InventarioAlmacenEntity__", String.Empty, JoinHint.None)
				relations.Add(inventarioAlmacenLotesEntity.Relations.ProductoEntityUsingProductoId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					InventarioAlmacenEntity.Relations.inventarioAlmacenLotesEntityUsingAlmacenIdProductoIdAñoMes, _
					CType(Integralab.ORM.EntityType.InventarioAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViainventarioAlmacenLotes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacen() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					InventarioAlmacenEntity.Relations.AlmacenEntityUsingAlmacenId, _
					CType(Integralab.ORM.EntityType.InventarioAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "Almacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProducto() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					InventarioAlmacenEntity.Relations.ProductoEntityUsingProductoId, _
					CType(Integralab.ORM.EntityType.InventarioAlmacenEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, Nothing, "Producto", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "InventarioAlmacenEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return InventarioAlmacenEntity.CustomProperties
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
				Return InventarioAlmacenEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The AlmacenId property of the Entity InventarioAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvAlmacen"."AlmacenId"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [AlmacenId]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(InventarioAlmacenFieldIndex.AlmacenId, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(InventarioAlmacenFieldIndex.AlmacenId, Integer), value)
			End Set
		End Property
	
		''' <summary>The ProductoId property of the Entity InventarioAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvAlmacen"."ProductoId"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [ProductoId]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(InventarioAlmacenFieldIndex.ProductoId, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(InventarioAlmacenFieldIndex.ProductoId, Integer), value)
			End Set
		End Property
	
		''' <summary>The Año property of the Entity InventarioAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvAlmacen"."Año"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [Año]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(InventarioAlmacenFieldIndex.Año, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(InventarioAlmacenFieldIndex.Año, Integer), value)
			End Set
		End Property
	
		''' <summary>The Mes property of the Entity InventarioAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvAlmacen"."Mes"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [Mes]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(InventarioAlmacenFieldIndex.Mes, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(InventarioAlmacenFieldIndex.Mes, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaUltimoCosto property of the Entity InventarioAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvAlmacen"."FechaUltimoCosto"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaUltimoCosto]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(InventarioAlmacenFieldIndex.FechaUltimoCosto, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(InventarioAlmacenFieldIndex.FechaUltimoCosto, Integer), value)
			End Set
		End Property
	
		''' <summary>The UltimoCosto property of the Entity InventarioAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvAlmacen"."UltimoCosto"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [UltimoCosto]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(InventarioAlmacenFieldIndex.UltimoCosto, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(InventarioAlmacenFieldIndex.UltimoCosto, Integer), value)
			End Set
		End Property
	
		''' <summary>The CostoPromedio property of the Entity InventarioAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvAlmacen"."CostoPromedio"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CostoPromedio]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(InventarioAlmacenFieldIndex.CostoPromedio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(InventarioAlmacenFieldIndex.CostoPromedio, Integer), value)
			End Set
		End Property
	
		''' <summary>The CantidadInicial property of the Entity InventarioAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvAlmacen"."CantidadInicial"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 18, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CantidadInicial]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(InventarioAlmacenFieldIndex.CantidadInicial, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(InventarioAlmacenFieldIndex.CantidadInicial, Integer), value)
			End Set
		End Property
	
		''' <summary>The CantidadExistencia property of the Entity InventarioAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvAlmacen"."CantidadExistencia"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 18, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CantidadExistencia]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(InventarioAlmacenFieldIndex.CantidadExistencia, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(InventarioAlmacenFieldIndex.CantidadExistencia, Integer), value)
			End Set
		End Property
	
		''' <summary>The CantidadEntrada property of the Entity InventarioAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvAlmacen"."CantidadEntrada"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 18, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CantidadEntrada]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(InventarioAlmacenFieldIndex.CantidadEntrada, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(InventarioAlmacenFieldIndex.CantidadEntrada, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaUltimaEntrada property of the Entity InventarioAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvAlmacen"."FechaUltimaEntrada"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaUltimaEntrada]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(InventarioAlmacenFieldIndex.FechaUltimaEntrada, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(InventarioAlmacenFieldIndex.FechaUltimaEntrada, Integer), value)
			End Set
		End Property
	
		''' <summary>The CantidadSalidas property of the Entity InventarioAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvAlmacen"."CantidadSalidas"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 18, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CantidadSalidas]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(InventarioAlmacenFieldIndex.CantidadSalidas, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(InventarioAlmacenFieldIndex.CantidadSalidas, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaUltimaSalida property of the Entity InventarioAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvAlmacen"."FechaUltimaSalida"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaUltimaSalida]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(InventarioAlmacenFieldIndex.FechaUltimaSalida, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(InventarioAlmacenFieldIndex.FechaUltimaSalida, Integer), value)
			End Set
		End Property
	
		''' <summary>The CantidadPorSurtir property of the Entity InventarioAlmacen<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvAlmacen"."CantidadPorSurtir"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 18, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CantidadPorSurtir]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(InventarioAlmacenFieldIndex.CantidadPorSurtir, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(InventarioAlmacenFieldIndex.CantidadPorSurtir, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'inventarioAlmacenLotesEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiInventarioAlmacenLotes()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [InventarioAlmacenLotes]() As Integralab.ORM.CollectionClasses.inventarioAlmacenLotesCollection
			Get
				Return GetMultiInventarioAlmacenLotes(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for InventarioAlmacenLotes. When set to true, InventarioAlmacenLotes is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time InventarioAlmacenLotes is accessed. You can always execute
		''' a forced fetch by calling GetMultiInventarioAlmacenLotes(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchInventarioAlmacenLotes As Boolean
			Get
				Return _alwaysFetchInventarioAlmacenLotes
			End Get
			Set
				_alwaysFetchInventarioAlmacenLotes = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacenCollectionViainventarioAlmacenLotes()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AlmacenCollectionViainventarioAlmacenLotes]() As Integralab.ORM.CollectionClasses.AlmacenCollection
			Get
				Return GetMultiAlmacenCollectionViainventarioAlmacenLotes(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AlmacenCollectionViainventarioAlmacenLotes. When set to true, AlmacenCollectionViainventarioAlmacenLotes is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AlmacenCollectionViainventarioAlmacenLotes is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacenCollectionViainventarioAlmacenLotes(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacenCollectionViainventarioAlmacenLotes As Boolean
			Get
				Return _alwaysFetchAlmacenCollectionViainventarioAlmacenLotes
			End Get
			Set
				_alwaysFetchAlmacenCollectionViainventarioAlmacenLotes = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViainventarioAlmacenLotes()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViainventarioAlmacenLotes]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViainventarioAlmacenLotes(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViainventarioAlmacenLotes. When set to true, ProductoCollectionViainventarioAlmacenLotes is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViainventarioAlmacenLotes is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViainventarioAlmacenLotes(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViainventarioAlmacenLotes As Boolean
			Get
				Return _alwaysFetchProductoCollectionViainventarioAlmacenLotes
			End Get
			Set
				_alwaysFetchProductoCollectionViainventarioAlmacenLotes = value
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
							_almacen.UnsetRelatedEntity(Me, "InventarioAlmacen")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "InventarioAlmacen")
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
	
		''' <summary>Gets / sets related entity of type 'ProductoEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleProducto()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Producto]() As ProductoEntity
			Get
				Return GetSingleProducto(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncProducto(value)
				Else
					If value Is Nothing Then
						If Not _producto Is Nothing Then
							_producto.UnsetRelatedEntity(Me, "InventarioAlmacen")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "InventarioAlmacen")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Producto. When set to true, Producto is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Producto is accessed. You can always execute
		''' a forced fetch by calling GetSingleProducto(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProducto As Boolean
			Get
				Return _alwaysFetchProducto
			End Get
			Set
				_alwaysFetchProducto = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Producto is not found
		''' in the database. When set to true, Producto will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property ProductoReturnsNewIfNotFound As Boolean
			Get
				Return _productoReturnsNewIfNotFound
			End Get
			Set
				_productoReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.InventarioAlmacenEntity)
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
