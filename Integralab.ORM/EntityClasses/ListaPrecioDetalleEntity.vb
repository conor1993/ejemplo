' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: miércoles, 24 de enero de 2018 11:05:22
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
	''' <summary>Entity class which represents the entity 'ListaPrecioDetalle'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class ListaPrecioDetalleEntity 
#Else
	<Serializable()> _
	Public Class ListaPrecioDetalleEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"


		Private _producto_ As ProductoEntity
		Private _alwaysFetchProducto_, _alreadyFetchedProducto_, _producto_ReturnsNewIfNotFound As Boolean
		Private _listaPrecio As ListaPrecioEntity
		Private _alwaysFetchListaPrecio, _alreadyFetchedListaPrecio, _listaPrecioReturnsNewIfNotFound As Boolean


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
		''' <param name="listaPrecios">PK value for ListaPrecioDetalle which data should be fetched into this ListaPrecioDetalle Object</param>
		''' <param name="producto">PK value for ListaPrecioDetalle which data should be fetched into this ListaPrecioDetalle Object</param>
		Public Sub New(listaPrecios As System.Int32, producto As System.Int32)

			InitClassFetch(listaPrecios, producto, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="listaPrecios">PK value for ListaPrecioDetalle which data should be fetched into this ListaPrecioDetalle Object</param>
		''' <param name="producto">PK value for ListaPrecioDetalle which data should be fetched into this ListaPrecioDetalle Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(listaPrecios As System.Int32, producto As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(listaPrecios, producto, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="listaPrecios">PK value for ListaPrecioDetalle which data should be fetched into this ListaPrecioDetalle Object</param>
		''' <param name="producto">PK value for ListaPrecioDetalle which data should be fetched into this ListaPrecioDetalle Object</param>
		''' <param name="validator">The custom validator Object for this ListaPrecioDetalleEntity</param>
		Public Sub New(listaPrecios As System.Int32, producto As System.Int32, validator As IValidator)

			InitClassFetch(listaPrecios, producto, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)


			_producto_ = CType(info.GetValue("_producto_", GetType(ProductoEntity)), ProductoEntity)
			If Not _producto_ Is Nothing Then
				AddHandler _producto_.AfterSave, AddressOf OnEntityAfterSave
			End If
			_producto_ReturnsNewIfNotFound = info.GetBoolean("_producto_ReturnsNewIfNotFound")
			_alwaysFetchProducto_ = info.GetBoolean("_alwaysFetchProducto_")
			_alreadyFetchedProducto_ = info.GetBoolean("_alreadyFetchedProducto_")
			_listaPrecio = CType(info.GetValue("_listaPrecio", GetType(ListaPrecioEntity)), ListaPrecioEntity)
			If Not _listaPrecio Is Nothing Then
				AddHandler _listaPrecio.AfterSave, AddressOf OnEntityAfterSave
			End If
			_listaPrecioReturnsNewIfNotFound = info.GetBoolean("_listaPrecioReturnsNewIfNotFound")
			_alwaysFetchListaPrecio = info.GetBoolean("_alwaysFetchListaPrecio")
			_alreadyFetchedListaPrecio = info.GetBoolean("_alreadyFetchedListaPrecio")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()


			_alreadyFetchedProducto_ = Not(_producto_ Is Nothing)
			_alreadyFetchedListaPrecio = Not(_listaPrecio Is Nothing)

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


			info.AddValue("_producto_", _producto_)
			info.AddValue("_producto_ReturnsNewIfNotFound", _producto_ReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchProducto_", _alwaysFetchProducto_)
			info.AddValue("_alreadyFetchedProducto_", _alreadyFetchedProducto_)
			info.AddValue("_listaPrecio", _listaPrecio)
			info.AddValue("_listaPrecioReturnsNewIfNotFound", _listaPrecioReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchListaPrecio", _alwaysFetchListaPrecio)
			info.AddValue("_alreadyFetchedListaPrecio", _alreadyFetchedListaPrecio)

			
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
				Case "Producto_"
					_alreadyFetchedProducto_ = True
					Me.Producto_ = CType(entity, ProductoEntity)
				Case "ListaPrecio"
					_alreadyFetchedListaPrecio = True
					Me.ListaPrecio = CType(entity, ListaPrecioEntity)



				Case Else

			End Select
		End Sub

		''' <summary>Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		''' <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		<EditorBrowsable(EditorBrowsableState.Never)> _
		Public Overrides Overloads Sub SetRelatedEntity(relatedEntity As IEntity, fieldName As String)
			Select Case fieldName
				Case "Producto_"
					SetupSyncProducto_(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "ListaPrecio"
					SetupSyncListaPrecio(relatedEntity)
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
				Case "Producto_"
					DesetupSyncProducto_(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "ListaPrecio"
					DesetupSyncListaPrecio(False, True)
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
			If Not _producto_ Is Nothing Then
				toReturn.Add(_producto_)
			End If
			If Not _listaPrecio Is Nothing Then
				toReturn.Add(_listaPrecio)
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
		''' <param name="listaPrecios">PK value for ListaPrecioDetalle which data should be fetched into this ListaPrecioDetalle Object</param>
		''' <param name="producto">PK value for ListaPrecioDetalle which data should be fetched into this ListaPrecioDetalle Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(listaPrecios As System.Int32, producto As System.Int32) As Boolean
			Return FetchUsingPK(listaPrecios, producto, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="listaPrecios">PK value for ListaPrecioDetalle which data should be fetched into this ListaPrecioDetalle Object</param>
		''' <param name="producto">PK value for ListaPrecioDetalle which data should be fetched into this ListaPrecioDetalle Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(listaPrecios As System.Int32, producto As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(listaPrecios, producto, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="listaPrecios">PK value for ListaPrecioDetalle which data should be fetched into this ListaPrecioDetalle Object</param>
		''' <param name="producto">PK value for ListaPrecioDetalle which data should be fetched into this ListaPrecioDetalle Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(listaPrecios As System.Int32, producto As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(listaPrecios, producto, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.ListaPrecios, Me.Producto, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As ListaPrecioDetalleFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As ListaPrecioDetalleFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



	

		''' <summary>Retrieves the related entity of type 'ProductoEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'ProductoEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleProducto_() As ProductoEntity
			Return GetSingleProducto_(False)
		End Function

		''' <summary>Retrieves the related entity of type 'ProductoEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'ProductoEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleProducto_(forceFetch As Boolean) As ProductoEntity
			If ( Not _alreadyFetchedProducto_ Or forceFetch Or _alwaysFetchProducto_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New ProductoEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(ListaPrecioDetalleEntity.Relations.ProductoEntityUsingProducto) Then
					fetchResult = newEntity.FetchUsingPK(Me.Producto)
				End If
				If Not _producto_ReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Producto_ = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), ProductoEntity)
					End If
					Me.Producto_ = newEntity
					_alreadyFetchedProducto_ = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _producto_
		End Function
	
		''' <summary>Retrieves the related entity of type 'ListaPrecioEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'ListaPrecioEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleListaPrecio() As ListaPrecioEntity
			Return GetSingleListaPrecio(False)
		End Function

		''' <summary>Retrieves the related entity of type 'ListaPrecioEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'ListaPrecioEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleListaPrecio(forceFetch As Boolean) As ListaPrecioEntity
			If ( Not _alreadyFetchedListaPrecio Or forceFetch Or _alwaysFetchListaPrecio) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New ListaPrecioEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(ListaPrecioDetalleEntity.Relations.ListaPrecioEntityUsingListaPrecios) Then
					fetchResult = newEntity.FetchUsingPK(Me.ListaPrecios)
				End If
				If Not _listaPrecioReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.ListaPrecio = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), ListaPrecioEntity)
					End If
					Me.ListaPrecio = newEntity
					_alreadyFetchedListaPrecio = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _listaPrecio
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(ListaPrecioDetalleFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, ListaPrecioDetalleFieldIndex)
					Case ListaPrecioDetalleFieldIndex.ListaPrecios
						DesetupSyncListaPrecio(True, False)
						_alreadyFetchedListaPrecio = False
					Case ListaPrecioDetalleFieldIndex.Producto
						DesetupSyncProducto_(True, False)
						_alreadyFetchedProducto_ = False









					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()


		If Not _producto_ Is Nothing Then
				_producto_.ActiveContext = MyBase.ActiveContext
			End If
		If Not _listaPrecio Is Nothing Then
				_listaPrecio.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As ListaPrecioDetalleDAO = CType(CreateDAOInstance(), ListaPrecioDetalleDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As ListaPrecioDetalleDAO = CType(CreateDAOInstance(), ListaPrecioDetalleDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As ListaPrecioDetalleDAO = CType(CreateDAOInstance(), ListaPrecioDetalleDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this ListaPrecioDetalleEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ListaPrecioDetalleEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="listaPrecios">PK value for ListaPrecioDetalle which data should be fetched into this ListaPrecioDetalle Object</param>
		''' <param name="producto">PK value for ListaPrecioDetalle which data should be fetched into this ListaPrecioDetalle Object</param>
		''' <param name="validator">The validator Object for this ListaPrecioDetalleEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(listaPrecios As System.Int32, producto As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(listaPrecios, producto, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()


			_producto_ = Nothing
			_producto_ReturnsNewIfNotFound = True
			_alwaysFetchProducto_ = False
			_alreadyFetchedProducto_ = False
			_listaPrecio = Nothing
			_listaPrecioReturnsNewIfNotFound = True
			_alwaysFetchListaPrecio = False
			_alreadyFetchedListaPrecio = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ListaPrecios", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Producto", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Costo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Utilidad", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("PrecioVentaC", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("PrecioVentaP", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ComicionP", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ComicionC", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("LpdporcDescto", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("LpdimpDescto", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _producto_</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncProducto_(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _producto_, AddressOf OnProducto_PropertyChanged, "Producto_", ListaPrecioDetalleEntity.Relations.ProductoEntityUsingProducto, True, signalRelatedEntity, "ListaPrecioDetalle", resetFKFields, New Integer() { CInt(ListaPrecioDetalleFieldIndex.Producto) } )
			_producto_ = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _producto_</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncProducto_(relatedEntity As IEntity)
			DesetupSyncProducto_(True, True)
			_producto_ = CType(relatedEntity, ProductoEntity)
			MyBase.PerformSetupSyncRelatedEntity( _producto_, AddressOf OnProducto_PropertyChanged, "Producto_", ListaPrecioDetalleEntity.Relations.ProductoEntityUsingProducto, True, _alreadyFetchedProducto_, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnProducto_PropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _listaPrecio</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncListaPrecio(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _listaPrecio, AddressOf OnListaPrecioPropertyChanged, "ListaPrecio", ListaPrecioDetalleEntity.Relations.ListaPrecioEntityUsingListaPrecios, True, signalRelatedEntity, "ListaPreciosDetalle", resetFKFields, New Integer() { CInt(ListaPrecioDetalleFieldIndex.ListaPrecios) } )
			_listaPrecio = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _listaPrecio</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncListaPrecio(relatedEntity As IEntity)
			DesetupSyncListaPrecio(True, True)
			_listaPrecio = CType(relatedEntity, ListaPrecioEntity)
			MyBase.PerformSetupSyncRelatedEntity( _listaPrecio, AddressOf OnListaPrecioPropertyChanged, "ListaPrecio", ListaPrecioDetalleEntity.Relations.ListaPrecioEntityUsingListaPrecios, True, _alreadyFetchedListaPrecio, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnListaPrecioPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="listaPrecios">PK value for ListaPrecioDetalle which data should be fetched into this ListaPrecioDetalle Object</param>
		''' <param name="producto">PK value for ListaPrecioDetalle which data should be fetched into this ListaPrecioDetalle Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(listaPrecios As System.Int32, producto As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(ListaPrecioDetalleFieldIndex.ListaPrecios)).ForcedCurrentValueWrite(listaPrecios)
				MyBase.Fields(CInt(ListaPrecioDetalleFieldIndex.Producto)).ForcedCurrentValueWrite(producto)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateListaPrecioDetalleDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New ListaPrecioDetalleEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As ListaPrecioDetalleRelations
			Get	
				Return New ListaPrecioDetalleRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProducto_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					ListaPrecioDetalleEntity.Relations.ProductoEntityUsingProducto, _
					CType(Integralab.ORM.EntityType.ListaPrecioDetalleEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, Nothing, "Producto_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ListaPrecio' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathListaPrecio() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ListaPrecioCollection(), _
					ListaPrecioDetalleEntity.Relations.ListaPrecioEntityUsingListaPrecios, _
					CType(Integralab.ORM.EntityType.ListaPrecioDetalleEntity, Integer), CType(Integralab.ORM.EntityType.ListaPrecioEntity, Integer), 0, Nothing, Nothing, Nothing, "ListaPrecio", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "ListaPrecioDetalleEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return ListaPrecioDetalleEntity.CustomProperties
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
				Return ListaPrecioDetalleEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The ListaPrecios property of the Entity ListaPrecioDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasListasPreciosDet"."LPDIdListaPrecios"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [ListaPrecios]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ListaPrecioDetalleFieldIndex.ListaPrecios, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ListaPrecioDetalleFieldIndex.ListaPrecios, Integer), value)
			End Set
		End Property
	
		''' <summary>The Producto property of the Entity ListaPrecioDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasListasPreciosDet"."LPdIdProducto"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [Producto]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ListaPrecioDetalleFieldIndex.Producto, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ListaPrecioDetalleFieldIndex.Producto, Integer), value)
			End Set
		End Property
	
		''' <summary>The Costo property of the Entity ListaPrecioDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasListasPreciosDet"."LPDCosto"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Costo]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ListaPrecioDetalleFieldIndex.Costo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(ListaPrecioDetalleFieldIndex.Costo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Utilidad property of the Entity ListaPrecioDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasListasPreciosDet"."LPDUtilidad"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Utilidad]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ListaPrecioDetalleFieldIndex.Utilidad, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(ListaPrecioDetalleFieldIndex.Utilidad, Integer), value)
			End Set
		End Property
	
		''' <summary>The PrecioVentaC property of the Entity ListaPrecioDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasListasPreciosDet"."LPDPrecioVentaC"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [PrecioVentaC]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ListaPrecioDetalleFieldIndex.PrecioVentaC, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(ListaPrecioDetalleFieldIndex.PrecioVentaC, Integer), value)
			End Set
		End Property
	
		''' <summary>The PrecioVentaP property of the Entity ListaPrecioDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasListasPreciosDet"."LPDPrecioVentaP"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [PrecioVentaP]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ListaPrecioDetalleFieldIndex.PrecioVentaP, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(ListaPrecioDetalleFieldIndex.PrecioVentaP, Integer), value)
			End Set
		End Property
	
		''' <summary>The ComicionP property of the Entity ListaPrecioDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasListasPreciosDet"."LPDComicionP"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 10, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ComicionP]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ListaPrecioDetalleFieldIndex.ComicionP, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(ListaPrecioDetalleFieldIndex.ComicionP, Integer), value)
			End Set
		End Property
	
		''' <summary>The ComicionC property of the Entity ListaPrecioDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasListasPreciosDet"."LPDComicionC"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ComicionC]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ListaPrecioDetalleFieldIndex.ComicionC, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(ListaPrecioDetalleFieldIndex.ComicionC, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity ListaPrecioDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasListasPreciosDet"."LPDEstatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ListaPrecioDetalleFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(ListaPrecioDetalleFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The LpdporcDescto property of the Entity ListaPrecioDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasListasPreciosDet"."LPDPorcDescto"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [LpdporcDescto]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ListaPrecioDetalleFieldIndex.LpdporcDescto, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(ListaPrecioDetalleFieldIndex.LpdporcDescto, Integer), value)
			End Set
		End Property
	
		''' <summary>The LpdimpDescto property of the Entity ListaPrecioDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasListasPreciosDet"."LPDImpDescto"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [LpdimpDescto]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ListaPrecioDetalleFieldIndex.LpdimpDescto, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(ListaPrecioDetalleFieldIndex.LpdimpDescto, Integer), value)
			End Set
		End Property
	
	
	
	
		''' <summary>Gets / sets related entity of type 'ProductoEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleProducto_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Producto_]() As ProductoEntity
			Get
				Return GetSingleProducto_(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncProducto_(value)
				Else
					If value Is Nothing Then
						If Not _producto_ Is Nothing Then
							_producto_.UnsetRelatedEntity(Me, "ListaPrecioDetalle")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "ListaPrecioDetalle")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Producto_. When set to true, Producto_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Producto_ is accessed. You can always execute
		''' a forced fetch by calling GetSingleProducto_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProducto_ As Boolean
			Get
				Return _alwaysFetchProducto_
			End Get
			Set
				_alwaysFetchProducto_ = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Producto_ is not found
		''' in the database. When set to true, Producto_ will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property Producto_ReturnsNewIfNotFound As Boolean
			Get
				Return _producto_ReturnsNewIfNotFound
			End Get
			Set
				_producto_ReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'ListaPrecioEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleListaPrecio()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [ListaPrecio]() As ListaPrecioEntity
			Get
				Return GetSingleListaPrecio(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncListaPrecio(value)
				Else
					If value Is Nothing Then
						If Not _listaPrecio Is Nothing Then
							_listaPrecio.UnsetRelatedEntity(Me, "ListaPreciosDetalle")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "ListaPreciosDetalle")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for ListaPrecio. When set to true, ListaPrecio is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ListaPrecio is accessed. You can always execute
		''' a forced fetch by calling GetSingleListaPrecio(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchListaPrecio As Boolean
			Get
				Return _alwaysFetchListaPrecio
			End Get
			Set
				_alwaysFetchListaPrecio = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property ListaPrecio is not found
		''' in the database. When set to true, ListaPrecio will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property ListaPrecioReturnsNewIfNotFound As Boolean
			Get
				Return _listaPrecioReturnsNewIfNotFound
			End Get
			Set
				_listaPrecioReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.ListaPrecioDetalleEntity)
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
