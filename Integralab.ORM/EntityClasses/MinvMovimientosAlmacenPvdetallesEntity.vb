' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 26 de enero de 2018 13:41:33
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
	''' <summary>Entity class which represents the entity 'MinvMovimientosAlmacenPvdetalles'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class MinvMovimientosAlmacenPvdetallesEntity 
#Else
	<Serializable()> _
	Public Class MinvMovimientosAlmacenPvdetallesEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"


		Private _almacen As AlmacenEntity
		Private _alwaysFetchAlmacen, _alreadyFetchedAlmacen, _almacenReturnsNewIfNotFound As Boolean
		Private _producto As ProductoEntity
		Private _alwaysFetchProducto, _alreadyFetchedProducto, _productoReturnsNewIfNotFound As Boolean
		Private _minvMovimientosAlmacenPv As MinvMovimientosAlmacenPvEntity
		Private _alwaysFetchMinvMovimientosAlmacenPv, _alreadyFetchedMinvMovimientosAlmacenPv, _minvMovimientosAlmacenPvReturnsNewIfNotFound As Boolean


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
		''' <param name="indice">PK value for MinvMovimientosAlmacenPvdetalles which data should be fetched into this MinvMovimientosAlmacenPvdetalles Object</param>
		''' <param name="almacenId">PK value for MinvMovimientosAlmacenPvdetalles which data should be fetched into this MinvMovimientosAlmacenPvdetalles Object</param>
		''' <param name="folioMovimiento">PK value for MinvMovimientosAlmacenPvdetalles which data should be fetched into this MinvMovimientosAlmacenPvdetalles Object</param>
		''' <param name="productoId">PK value for MinvMovimientosAlmacenPvdetalles which data should be fetched into this MinvMovimientosAlmacenPvdetalles Object</param>
		Public Sub New(indice As System.Int32, almacenId As System.Int32, folioMovimiento As System.String, productoId As System.Int32)

			InitClassFetch(indice, almacenId, folioMovimiento, productoId, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="indice">PK value for MinvMovimientosAlmacenPvdetalles which data should be fetched into this MinvMovimientosAlmacenPvdetalles Object</param>
		''' <param name="almacenId">PK value for MinvMovimientosAlmacenPvdetalles which data should be fetched into this MinvMovimientosAlmacenPvdetalles Object</param>
		''' <param name="folioMovimiento">PK value for MinvMovimientosAlmacenPvdetalles which data should be fetched into this MinvMovimientosAlmacenPvdetalles Object</param>
		''' <param name="productoId">PK value for MinvMovimientosAlmacenPvdetalles which data should be fetched into this MinvMovimientosAlmacenPvdetalles Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(indice As System.Int32, almacenId As System.Int32, folioMovimiento As System.String, productoId As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(indice, almacenId, folioMovimiento, productoId, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="indice">PK value for MinvMovimientosAlmacenPvdetalles which data should be fetched into this MinvMovimientosAlmacenPvdetalles Object</param>
		''' <param name="almacenId">PK value for MinvMovimientosAlmacenPvdetalles which data should be fetched into this MinvMovimientosAlmacenPvdetalles Object</param>
		''' <param name="folioMovimiento">PK value for MinvMovimientosAlmacenPvdetalles which data should be fetched into this MinvMovimientosAlmacenPvdetalles Object</param>
		''' <param name="productoId">PK value for MinvMovimientosAlmacenPvdetalles which data should be fetched into this MinvMovimientosAlmacenPvdetalles Object</param>
		''' <param name="validator">The custom validator Object for this MinvMovimientosAlmacenPvdetallesEntity</param>
		Public Sub New(indice As System.Int32, almacenId As System.Int32, folioMovimiento As System.String, productoId As System.Int32, validator As IValidator)

			InitClassFetch(indice, almacenId, folioMovimiento, productoId, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)


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
			_minvMovimientosAlmacenPv = CType(info.GetValue("_minvMovimientosAlmacenPv", GetType(MinvMovimientosAlmacenPvEntity)), MinvMovimientosAlmacenPvEntity)
			If Not _minvMovimientosAlmacenPv Is Nothing Then
				AddHandler _minvMovimientosAlmacenPv.AfterSave, AddressOf OnEntityAfterSave
			End If
			_minvMovimientosAlmacenPvReturnsNewIfNotFound = info.GetBoolean("_minvMovimientosAlmacenPvReturnsNewIfNotFound")
			_alwaysFetchMinvMovimientosAlmacenPv = info.GetBoolean("_alwaysFetchMinvMovimientosAlmacenPv")
			_alreadyFetchedMinvMovimientosAlmacenPv = info.GetBoolean("_alreadyFetchedMinvMovimientosAlmacenPv")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()


			_alreadyFetchedAlmacen = Not(_almacen Is Nothing)
			_alreadyFetchedProducto = Not(_producto Is Nothing)
			_alreadyFetchedMinvMovimientosAlmacenPv = Not(_minvMovimientosAlmacenPv Is Nothing)

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


			info.AddValue("_almacen", _almacen)
			info.AddValue("_almacenReturnsNewIfNotFound", _almacenReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchAlmacen", _alwaysFetchAlmacen)
			info.AddValue("_alreadyFetchedAlmacen", _alreadyFetchedAlmacen)
			info.AddValue("_producto", _producto)
			info.AddValue("_productoReturnsNewIfNotFound", _productoReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchProducto", _alwaysFetchProducto)
			info.AddValue("_alreadyFetchedProducto", _alreadyFetchedProducto)
			info.AddValue("_minvMovimientosAlmacenPv", _minvMovimientosAlmacenPv)
			info.AddValue("_minvMovimientosAlmacenPvReturnsNewIfNotFound", _minvMovimientosAlmacenPvReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMinvMovimientosAlmacenPv", _alwaysFetchMinvMovimientosAlmacenPv)
			info.AddValue("_alreadyFetchedMinvMovimientosAlmacenPv", _alreadyFetchedMinvMovimientosAlmacenPv)

			
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
				Case "MinvMovimientosAlmacenPv"
					_alreadyFetchedMinvMovimientosAlmacenPv = True
					Me.MinvMovimientosAlmacenPv = CType(entity, MinvMovimientosAlmacenPvEntity)



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
				Case "MinvMovimientosAlmacenPv"
					SetupSyncMinvMovimientosAlmacenPv(relatedEntity)
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
				Case "MinvMovimientosAlmacenPv"
					DesetupSyncMinvMovimientosAlmacenPv(False, True)
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
			If Not _minvMovimientosAlmacenPv Is Nothing Then
				toReturn.Add(_minvMovimientosAlmacenPv)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()


			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="indice">PK value for MinvMovimientosAlmacenPvdetalles which data should be fetched into this MinvMovimientosAlmacenPvdetalles Object</param>
		''' <param name="almacenId">PK value for MinvMovimientosAlmacenPvdetalles which data should be fetched into this MinvMovimientosAlmacenPvdetalles Object</param>
		''' <param name="folioMovimiento">PK value for MinvMovimientosAlmacenPvdetalles which data should be fetched into this MinvMovimientosAlmacenPvdetalles Object</param>
		''' <param name="productoId">PK value for MinvMovimientosAlmacenPvdetalles which data should be fetched into this MinvMovimientosAlmacenPvdetalles Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(indice As System.Int32, almacenId As System.Int32, folioMovimiento As System.String, productoId As System.Int32) As Boolean
			Return FetchUsingPK(indice, almacenId, folioMovimiento, productoId, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="indice">PK value for MinvMovimientosAlmacenPvdetalles which data should be fetched into this MinvMovimientosAlmacenPvdetalles Object</param>
		''' <param name="almacenId">PK value for MinvMovimientosAlmacenPvdetalles which data should be fetched into this MinvMovimientosAlmacenPvdetalles Object</param>
		''' <param name="folioMovimiento">PK value for MinvMovimientosAlmacenPvdetalles which data should be fetched into this MinvMovimientosAlmacenPvdetalles Object</param>
		''' <param name="productoId">PK value for MinvMovimientosAlmacenPvdetalles which data should be fetched into this MinvMovimientosAlmacenPvdetalles Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(indice As System.Int32, almacenId As System.Int32, folioMovimiento As System.String, productoId As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(indice, almacenId, folioMovimiento, productoId, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="indice">PK value for MinvMovimientosAlmacenPvdetalles which data should be fetched into this MinvMovimientosAlmacenPvdetalles Object</param>
		''' <param name="almacenId">PK value for MinvMovimientosAlmacenPvdetalles which data should be fetched into this MinvMovimientosAlmacenPvdetalles Object</param>
		''' <param name="folioMovimiento">PK value for MinvMovimientosAlmacenPvdetalles which data should be fetched into this MinvMovimientosAlmacenPvdetalles Object</param>
		''' <param name="productoId">PK value for MinvMovimientosAlmacenPvdetalles which data should be fetched into this MinvMovimientosAlmacenPvdetalles Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(indice As System.Int32, almacenId As System.Int32, folioMovimiento As System.String, productoId As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(indice, almacenId, folioMovimiento, productoId, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.Indice, Me.AlmacenId, Me.FolioMovimiento, Me.ProductoId, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As MinvMovimientosAlmacenPvdetallesFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As MinvMovimientosAlmacenPvdetallesFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
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
				If MyBase.CheckIfLazyLoadingShouldOccur(MinvMovimientosAlmacenPvdetallesEntity.Relations.AlmacenEntityUsingAlmacenId) Then
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
				If MyBase.CheckIfLazyLoadingShouldOccur(MinvMovimientosAlmacenPvdetallesEntity.Relations.ProductoEntityUsingProductoId) Then
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
	
		''' <summary>Retrieves the related entity of type 'MinvMovimientosAlmacenPvEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'MinvMovimientosAlmacenPvEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMinvMovimientosAlmacenPv() As MinvMovimientosAlmacenPvEntity
			Return GetSingleMinvMovimientosAlmacenPv(False)
		End Function

		''' <summary>Retrieves the related entity of type 'MinvMovimientosAlmacenPvEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'MinvMovimientosAlmacenPvEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMinvMovimientosAlmacenPv(forceFetch As Boolean) As MinvMovimientosAlmacenPvEntity
			If ( Not _alreadyFetchedMinvMovimientosAlmacenPv Or forceFetch Or _alwaysFetchMinvMovimientosAlmacenPv) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New MinvMovimientosAlmacenPvEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(MinvMovimientosAlmacenPvdetallesEntity.Relations.MinvMovimientosAlmacenPvEntityUsingAlmacenIdFolioMovimiento) Then
					fetchResult = newEntity.FetchUsingPK(Me.AlmacenId, Me.FolioMovimiento)
				End If
				If Not _minvMovimientosAlmacenPvReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.MinvMovimientosAlmacenPv = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), MinvMovimientosAlmacenPvEntity)
					End If
					Me.MinvMovimientosAlmacenPv = newEntity
					_alreadyFetchedMinvMovimientosAlmacenPv = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _minvMovimientosAlmacenPv
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(MinvMovimientosAlmacenPvdetallesFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, MinvMovimientosAlmacenPvdetallesFieldIndex)

					Case MinvMovimientosAlmacenPvdetallesFieldIndex.AlmacenId
						DesetupSyncAlmacen(True, False)
						_alreadyFetchedAlmacen = False
						DesetupSyncMinvMovimientosAlmacenPv(True, False)
						_alreadyFetchedMinvMovimientosAlmacenPv = False
					Case MinvMovimientosAlmacenPvdetallesFieldIndex.FolioMovimiento
						DesetupSyncMinvMovimientosAlmacenPv(True, False)
						_alreadyFetchedMinvMovimientosAlmacenPv = False
					Case MinvMovimientosAlmacenPvdetallesFieldIndex.ProductoId
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


		If Not _almacen Is Nothing Then
				_almacen.ActiveContext = MyBase.ActiveContext
			End If
		If Not _producto Is Nothing Then
				_producto.ActiveContext = MyBase.ActiveContext
			End If
		If Not _minvMovimientosAlmacenPv Is Nothing Then
				_minvMovimientosAlmacenPv.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As MinvMovimientosAlmacenPvdetallesDAO = CType(CreateDAOInstance(), MinvMovimientosAlmacenPvdetallesDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As MinvMovimientosAlmacenPvdetallesDAO = CType(CreateDAOInstance(), MinvMovimientosAlmacenPvdetallesDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As MinvMovimientosAlmacenPvdetallesDAO = CType(CreateDAOInstance(), MinvMovimientosAlmacenPvdetallesDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this MinvMovimientosAlmacenPvdetallesEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.MinvMovimientosAlmacenPvdetallesEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="indice">PK value for MinvMovimientosAlmacenPvdetalles which data should be fetched into this MinvMovimientosAlmacenPvdetalles Object</param>
		''' <param name="almacenId">PK value for MinvMovimientosAlmacenPvdetalles which data should be fetched into this MinvMovimientosAlmacenPvdetalles Object</param>
		''' <param name="folioMovimiento">PK value for MinvMovimientosAlmacenPvdetalles which data should be fetched into this MinvMovimientosAlmacenPvdetalles Object</param>
		''' <param name="productoId">PK value for MinvMovimientosAlmacenPvdetalles which data should be fetched into this MinvMovimientosAlmacenPvdetalles Object</param>
		''' <param name="validator">The validator Object for this MinvMovimientosAlmacenPvdetallesEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(indice As System.Int32, almacenId As System.Int32, folioMovimiento As System.String, productoId As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(indice, almacenId, folioMovimiento, productoId, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()


			_almacen = Nothing
			_almacenReturnsNewIfNotFound = True
			_alwaysFetchAlmacen = False
			_alreadyFetchedAlmacen = False
			_producto = Nothing
			_productoReturnsNewIfNotFound = True
			_alwaysFetchProducto = False
			_alreadyFetchedProducto = False
			_minvMovimientosAlmacenPv = Nothing
			_minvMovimientosAlmacenPvReturnsNewIfNotFound = True
			_alwaysFetchMinvMovimientosAlmacenPv = False
			_alreadyFetchedMinvMovimientosAlmacenPv = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Indice", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("AlmacenId", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioMovimiento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ProductoId", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaMovimiento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Cantidad", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Costo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Descuento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Lote", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CostoPromedioAnterior", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CostoPromedio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdCentroCosto", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CantidadUsada", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdProdComp", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _almacen</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncAlmacen(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _almacen, AddressOf OnAlmacenPropertyChanged, "Almacen", MinvMovimientosAlmacenPvdetallesEntity.Relations.AlmacenEntityUsingAlmacenId, True, signalRelatedEntity, "MinvMovimientosAlmacenPvdetalles", resetFKFields, New Integer() { CInt(MinvMovimientosAlmacenPvdetallesFieldIndex.AlmacenId) } )
			_almacen = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _almacen</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncAlmacen(relatedEntity As IEntity)
			DesetupSyncAlmacen(True, True)
			_almacen = CType(relatedEntity, AlmacenEntity)
			MyBase.PerformSetupSyncRelatedEntity( _almacen, AddressOf OnAlmacenPropertyChanged, "Almacen", MinvMovimientosAlmacenPvdetallesEntity.Relations.AlmacenEntityUsingAlmacenId, True, _alreadyFetchedAlmacen, New String() {  } )
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
			MyBase.PerformDesetupSyncRelatedEntity( _producto, AddressOf OnProductoPropertyChanged, "Producto", MinvMovimientosAlmacenPvdetallesEntity.Relations.ProductoEntityUsingProductoId, True, signalRelatedEntity, "MinvMovimientosAlmacenPvdetalles", resetFKFields, New Integer() { CInt(MinvMovimientosAlmacenPvdetallesFieldIndex.ProductoId) } )
			_producto = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _producto</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncProducto(relatedEntity As IEntity)
			DesetupSyncProducto(True, True)
			_producto = CType(relatedEntity, ProductoEntity)
			MyBase.PerformSetupSyncRelatedEntity( _producto, AddressOf OnProductoPropertyChanged, "Producto", MinvMovimientosAlmacenPvdetallesEntity.Relations.ProductoEntityUsingProductoId, True, _alreadyFetchedProducto, New String() {  } )
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
		''' <summary>Removes the sync logic for member _minvMovimientosAlmacenPv</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMinvMovimientosAlmacenPv(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _minvMovimientosAlmacenPv, AddressOf OnMinvMovimientosAlmacenPvPropertyChanged, "MinvMovimientosAlmacenPv", MinvMovimientosAlmacenPvdetallesEntity.Relations.MinvMovimientosAlmacenPvEntityUsingAlmacenIdFolioMovimiento, True, signalRelatedEntity, "MinvMovimientosAlmacenPvdetalles", resetFKFields, New Integer() { CInt(MinvMovimientosAlmacenPvdetallesFieldIndex.AlmacenId), CInt(MinvMovimientosAlmacenPvdetallesFieldIndex.FolioMovimiento) } )
			_minvMovimientosAlmacenPv = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _minvMovimientosAlmacenPv</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMinvMovimientosAlmacenPv(relatedEntity As IEntity)
			DesetupSyncMinvMovimientosAlmacenPv(True, True)
			_minvMovimientosAlmacenPv = CType(relatedEntity, MinvMovimientosAlmacenPvEntity)
			MyBase.PerformSetupSyncRelatedEntity( _minvMovimientosAlmacenPv, AddressOf OnMinvMovimientosAlmacenPvPropertyChanged, "MinvMovimientosAlmacenPv", MinvMovimientosAlmacenPvdetallesEntity.Relations.MinvMovimientosAlmacenPvEntityUsingAlmacenIdFolioMovimiento, True, _alreadyFetchedMinvMovimientosAlmacenPv, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMinvMovimientosAlmacenPvPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="indice">PK value for MinvMovimientosAlmacenPvdetalles which data should be fetched into this MinvMovimientosAlmacenPvdetalles Object</param>
		''' <param name="almacenId">PK value for MinvMovimientosAlmacenPvdetalles which data should be fetched into this MinvMovimientosAlmacenPvdetalles Object</param>
		''' <param name="folioMovimiento">PK value for MinvMovimientosAlmacenPvdetalles which data should be fetched into this MinvMovimientosAlmacenPvdetalles Object</param>
		''' <param name="productoId">PK value for MinvMovimientosAlmacenPvdetalles which data should be fetched into this MinvMovimientosAlmacenPvdetalles Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(indice As System.Int32, almacenId As System.Int32, folioMovimiento As System.String, productoId As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(MinvMovimientosAlmacenPvdetallesFieldIndex.Indice)).ForcedCurrentValueWrite(indice)
				MyBase.Fields(CInt(MinvMovimientosAlmacenPvdetallesFieldIndex.AlmacenId)).ForcedCurrentValueWrite(almacenId)
				MyBase.Fields(CInt(MinvMovimientosAlmacenPvdetallesFieldIndex.FolioMovimiento)).ForcedCurrentValueWrite(folioMovimiento)
				MyBase.Fields(CInt(MinvMovimientosAlmacenPvdetallesFieldIndex.ProductoId)).ForcedCurrentValueWrite(productoId)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateMinvMovimientosAlmacenPvdetallesDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New MinvMovimientosAlmacenPvdetallesEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As MinvMovimientosAlmacenPvdetallesRelations
			Get	
				Return New MinvMovimientosAlmacenPvdetallesRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacen() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					MinvMovimientosAlmacenPvdetallesEntity.Relations.AlmacenEntityUsingAlmacenId, _
					CType(Integralab.ORM.EntityType.MinvMovimientosAlmacenPvdetallesEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, Nothing, "Almacen", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProducto() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					MinvMovimientosAlmacenPvdetallesEntity.Relations.ProductoEntityUsingProductoId, _
					CType(Integralab.ORM.EntityType.MinvMovimientosAlmacenPvdetallesEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, Nothing, "Producto", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MinvMovimientosAlmacenPv' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMinvMovimientosAlmacenPv() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MinvMovimientosAlmacenPvCollection(), _
					MinvMovimientosAlmacenPvdetallesEntity.Relations.MinvMovimientosAlmacenPvEntityUsingAlmacenIdFolioMovimiento, _
					CType(Integralab.ORM.EntityType.MinvMovimientosAlmacenPvdetallesEntity, Integer), CType(Integralab.ORM.EntityType.MinvMovimientosAlmacenPvEntity, Integer), 0, Nothing, Nothing, Nothing, "MinvMovimientosAlmacenPv", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "MinvMovimientosAlmacenPvdetallesEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return MinvMovimientosAlmacenPvdetallesEntity.CustomProperties
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
				Return MinvMovimientosAlmacenPvdetallesEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The Indice property of the Entity MinvMovimientosAlmacenPvdetalles<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacenPVDetalles"."Indice"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [Indice]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvMovimientosAlmacenPvdetallesFieldIndex.Indice, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MinvMovimientosAlmacenPvdetallesFieldIndex.Indice, Integer), value)
			End Set
		End Property
	
		''' <summary>The AlmacenId property of the Entity MinvMovimientosAlmacenPvdetalles<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacenPVDetalles"."AlmacenId"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [AlmacenId]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvMovimientosAlmacenPvdetallesFieldIndex.AlmacenId, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MinvMovimientosAlmacenPvdetallesFieldIndex.AlmacenId, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioMovimiento property of the Entity MinvMovimientosAlmacenPvdetalles<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacenPVDetalles"."FolioMovimiento"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [FolioMovimiento]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvMovimientosAlmacenPvdetallesFieldIndex.FolioMovimiento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MinvMovimientosAlmacenPvdetallesFieldIndex.FolioMovimiento, Integer), value)
			End Set
		End Property
	
		''' <summary>The ProductoId property of the Entity MinvMovimientosAlmacenPvdetalles<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacenPVDetalles"."ProductoId"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [ProductoId]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvMovimientosAlmacenPvdetallesFieldIndex.ProductoId, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MinvMovimientosAlmacenPvdetallesFieldIndex.ProductoId, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaMovimiento property of the Entity MinvMovimientosAlmacenPvdetalles<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacenPVDetalles"."FechaMovimiento"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaMovimiento]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvMovimientosAlmacenPvdetallesFieldIndex.FechaMovimiento, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(MinvMovimientosAlmacenPvdetallesFieldIndex.FechaMovimiento, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cantidad property of the Entity MinvMovimientosAlmacenPvdetalles<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacenPVDetalles"."Cantidad"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 18, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Cantidad]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvMovimientosAlmacenPvdetallesFieldIndex.Cantidad, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(MinvMovimientosAlmacenPvdetallesFieldIndex.Cantidad, Integer), value)
			End Set
		End Property
	
		''' <summary>The Costo property of the Entity MinvMovimientosAlmacenPvdetalles<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacenPVDetalles"."Costo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Costo]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvMovimientosAlmacenPvdetallesFieldIndex.Costo, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(MinvMovimientosAlmacenPvdetallesFieldIndex.Costo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Descuento property of the Entity MinvMovimientosAlmacenPvdetalles<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacenPVDetalles"."Descuento"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Descuento]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvMovimientosAlmacenPvdetallesFieldIndex.Descuento, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(MinvMovimientosAlmacenPvdetallesFieldIndex.Descuento, Integer), value)
			End Set
		End Property
	
		''' <summary>The Lote property of the Entity MinvMovimientosAlmacenPvdetalles<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacenPVDetalles"."Lote"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 15<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Lote]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvMovimientosAlmacenPvdetallesFieldIndex.Lote, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MinvMovimientosAlmacenPvdetallesFieldIndex.Lote, Integer), value)
			End Set
		End Property
	
		''' <summary>The CostoPromedioAnterior property of the Entity MinvMovimientosAlmacenPvdetalles<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacenPVDetalles"."CostoPromedioAnterior"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CostoPromedioAnterior]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvMovimientosAlmacenPvdetallesFieldIndex.CostoPromedioAnterior, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(MinvMovimientosAlmacenPvdetallesFieldIndex.CostoPromedioAnterior, Integer), value)
			End Set
		End Property
	
		''' <summary>The CostoPromedio property of the Entity MinvMovimientosAlmacenPvdetalles<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacenPVDetalles"."CostoPromedio"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CostoPromedio]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvMovimientosAlmacenPvdetallesFieldIndex.CostoPromedio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(MinvMovimientosAlmacenPvdetallesFieldIndex.CostoPromedio, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdCentroCosto property of the Entity MinvMovimientosAlmacenPvdetalles<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacenPVDetalles"."IdCentroCosto"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdCentroCosto]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvMovimientosAlmacenPvdetallesFieldIndex.IdCentroCosto, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(MinvMovimientosAlmacenPvdetallesFieldIndex.IdCentroCosto, Integer), value)
			End Set
		End Property
	
		''' <summary>The CantidadUsada property of the Entity MinvMovimientosAlmacenPvdetalles<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacenPVDetalles"."CantidadUsada"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 18, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [CantidadUsada]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvMovimientosAlmacenPvdetallesFieldIndex.CantidadUsada, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(MinvMovimientosAlmacenPvdetallesFieldIndex.CantidadUsada, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdProdComp property of the Entity MinvMovimientosAlmacenPvdetalles<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MInvMovimientosAlmacenPVDetalles"."IdProdComp"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdProdComp]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MinvMovimientosAlmacenPvdetallesFieldIndex.IdProdComp, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MinvMovimientosAlmacenPvdetallesFieldIndex.IdProdComp, Integer), value)
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
							_almacen.UnsetRelatedEntity(Me, "MinvMovimientosAlmacenPvdetalles")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "MinvMovimientosAlmacenPvdetalles")
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
							_producto.UnsetRelatedEntity(Me, "MinvMovimientosAlmacenPvdetalles")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "MinvMovimientosAlmacenPvdetalles")
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
	
		''' <summary>Gets / sets related entity of type 'MinvMovimientosAlmacenPvEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMinvMovimientosAlmacenPv()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [MinvMovimientosAlmacenPv]() As MinvMovimientosAlmacenPvEntity
			Get
				Return GetSingleMinvMovimientosAlmacenPv(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMinvMovimientosAlmacenPv(value)
				Else
					If value Is Nothing Then
						If Not _minvMovimientosAlmacenPv Is Nothing Then
							_minvMovimientosAlmacenPv.UnsetRelatedEntity(Me, "MinvMovimientosAlmacenPvdetalles")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "MinvMovimientosAlmacenPvdetalles")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for MinvMovimientosAlmacenPv. When set to true, MinvMovimientosAlmacenPv is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MinvMovimientosAlmacenPv is accessed. You can always execute
		''' a forced fetch by calling GetSingleMinvMovimientosAlmacenPv(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMinvMovimientosAlmacenPv As Boolean
			Get
				Return _alwaysFetchMinvMovimientosAlmacenPv
			End Get
			Set
				_alwaysFetchMinvMovimientosAlmacenPv = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property MinvMovimientosAlmacenPv is not found
		''' in the database. When set to true, MinvMovimientosAlmacenPv will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property MinvMovimientosAlmacenPvReturnsNewIfNotFound As Boolean
			Get
				Return _minvMovimientosAlmacenPvReturnsNewIfNotFound
			End Get
			Set
				_minvMovimientosAlmacenPvReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.MinvMovimientosAlmacenPvdetallesEntity)
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
