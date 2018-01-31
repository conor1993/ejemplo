' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: miércoles, 31 de enero de 2018 11:15:21
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
	''' <summary>Entity class which represents the entity 'Cliente'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class ClienteEntity 
#Else
	<Serializable()> _
	Public Class ClienteEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _domicilioFiscalesClientes As Integralab.ORM.CollectionClasses.DomicilioFiscalesClientesCollection
		Private _alwaysFetchDomicilioFiscalesClientes, _alreadyFetchedDomicilioFiscalesClientes As Boolean
		Private _domicilioFiscalCollectionViaDomicilioFiscalesClientes As Integralab.ORM.CollectionClasses.DomicilioFiscalCollection
		Private _alwaysFetchDomicilioFiscalCollectionViaDomicilioFiscalesClientes, _alreadyFetchedDomicilioFiscalCollectionViaDomicilioFiscalesClientes As Boolean
		Private _plaza As PlazaEntity
		Private _alwaysFetchPlaza, _alreadyFetchedPlaza, _plazaReturnsNewIfNotFound As Boolean
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
		''' <param name="codigo">PK value for Cliente which data should be fetched into this Cliente Object</param>
		Public Sub New(codigo As System.Int32)

			InitClassFetch(codigo, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for Cliente which data should be fetched into this Cliente Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(codigo As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(codigo, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for Cliente which data should be fetched into this Cliente Object</param>
		''' <param name="validator">The custom validator Object for this ClienteEntity</param>
		Public Sub New(codigo As System.Int32, validator As IValidator)

			InitClassFetch(codigo, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_domicilioFiscalesClientes = CType(info.GetValue("_domicilioFiscalesClientes", GetType(Integralab.ORM.CollectionClasses.DomicilioFiscalesClientesCollection)), Integralab.ORM.CollectionClasses.DomicilioFiscalesClientesCollection)
			_alwaysFetchDomicilioFiscalesClientes = info.GetBoolean("_alwaysFetchDomicilioFiscalesClientes")
			_alreadyFetchedDomicilioFiscalesClientes = info.GetBoolean("_alreadyFetchedDomicilioFiscalesClientes")
			_domicilioFiscalCollectionViaDomicilioFiscalesClientes = CType(info.GetValue("_domicilioFiscalCollectionViaDomicilioFiscalesClientes", GetType(Integralab.ORM.CollectionClasses.DomicilioFiscalCollection)), Integralab.ORM.CollectionClasses.DomicilioFiscalCollection)
			_alwaysFetchDomicilioFiscalCollectionViaDomicilioFiscalesClientes = info.GetBoolean("_alwaysFetchDomicilioFiscalCollectionViaDomicilioFiscalesClientes")
			_alreadyFetchedDomicilioFiscalCollectionViaDomicilioFiscalesClientes = info.GetBoolean("_alreadyFetchedDomicilioFiscalCollectionViaDomicilioFiscalesClientes")
			_plaza = CType(info.GetValue("_plaza", GetType(PlazaEntity)), PlazaEntity)
			If Not _plaza Is Nothing Then
				AddHandler _plaza.AfterSave, AddressOf OnEntityAfterSave
			End If
			_plazaReturnsNewIfNotFound = info.GetBoolean("_plazaReturnsNewIfNotFound")
			_alwaysFetchPlaza = info.GetBoolean("_alwaysFetchPlaza")
			_alreadyFetchedPlaza = info.GetBoolean("_alreadyFetchedPlaza")
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
			_alreadyFetchedDomicilioFiscalesClientes = (_domicilioFiscalesClientes.Count > 0)
			_alreadyFetchedDomicilioFiscalCollectionViaDomicilioFiscalesClientes = (_domicilioFiscalCollectionViaDomicilioFiscalesClientes.Count > 0)
			_alreadyFetchedPlaza = Not(_plaza Is Nothing)
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
			info.AddValue("_domicilioFiscalesClientes", _domicilioFiscalesClientes)
			info.AddValue("_alwaysFetchDomicilioFiscalesClientes", _alwaysFetchDomicilioFiscalesClientes)
			info.AddValue("_alreadyFetchedDomicilioFiscalesClientes", _alreadyFetchedDomicilioFiscalesClientes)
			info.AddValue("_domicilioFiscalCollectionViaDomicilioFiscalesClientes", _domicilioFiscalCollectionViaDomicilioFiscalesClientes)
			info.AddValue("_alwaysFetchDomicilioFiscalCollectionViaDomicilioFiscalesClientes", _alwaysFetchDomicilioFiscalCollectionViaDomicilioFiscalesClientes)
			info.AddValue("_alreadyFetchedDomicilioFiscalCollectionViaDomicilioFiscalesClientes", _alreadyFetchedDomicilioFiscalCollectionViaDomicilioFiscalesClientes)
			info.AddValue("_plaza", _plaza)
			info.AddValue("_plazaReturnsNewIfNotFound", _plazaReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchPlaza", _alwaysFetchPlaza)
			info.AddValue("_alreadyFetchedPlaza", _alreadyFetchedPlaza)
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
				Case "Plaza"
					_alreadyFetchedPlaza = True
					Me.Plaza = CType(entity, PlazaEntity)
				Case "ListaPrecio"
					_alreadyFetchedListaPrecio = True
					Me.ListaPrecio = CType(entity, ListaPrecioEntity)
				Case "DomicilioFiscalesClientes"
					_alreadyFetchedDomicilioFiscalesClientes = True
					If Not entity Is Nothing Then
						Me.DomicilioFiscalesClientes.Add(CType(entity, DomicilioFiscalesClientesEntity))
					End If
				Case "DomicilioFiscalCollectionViaDomicilioFiscalesClientes"
					_alreadyFetchedDomicilioFiscalCollectionViaDomicilioFiscalesClientes = True
					If Not entity Is Nothing Then
						Me.DomicilioFiscalCollectionViaDomicilioFiscalesClientes.Add(CType(entity, DomicilioFiscalEntity))
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
				Case "Plaza"
					SetupSyncPlaza(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "ListaPrecio"
					SetupSyncListaPrecio(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "DomicilioFiscalesClientes"
					_domicilioFiscalesClientes.Add(CType(relatedEntity, DomicilioFiscalesClientesEntity))
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
				Case "Plaza"
					DesetupSyncPlaza(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "ListaPrecio"
					DesetupSyncListaPrecio(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "DomicilioFiscalesClientes"
					MyBase.PerformRelatedEntityRemoval(_domicilioFiscalesClientes, relatedEntity, signalRelatedEntityManyToOne)
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
			If Not _plaza Is Nothing Then
				toReturn.Add(_plaza)
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
			toReturn.Add(_domicilioFiscalesClientes)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for Cliente which data should be fetched into this Cliente Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32) As Boolean
			Return FetchUsingPK(codigo, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for Cliente which data should be fetched into this Cliente Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(codigo, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for Cliente which data should be fetched into this Cliente Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(codigo, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.Codigo, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As ClienteFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As ClienteFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'DomicilioFiscalesClientesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'DomicilioFiscalesClientesEntity'</returns>
		Public Function GetMultiDomicilioFiscalesClientes(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.DomicilioFiscalesClientesCollection
			Return GetMultiDomicilioFiscalesClientes(forceFetch, _domicilioFiscalesClientes.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DomicilioFiscalesClientesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiDomicilioFiscalesClientes(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.DomicilioFiscalesClientesCollection
			Return GetMultiDomicilioFiscalesClientes(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DomicilioFiscalesClientesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'DomicilioFiscalesClientesEntity'</returns>
		Public Function GetMultiDomicilioFiscalesClientes(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DomicilioFiscalesClientesCollection
			Return GetMultiDomicilioFiscalesClientes(forceFetch, _domicilioFiscalesClientes.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'DomicilioFiscalesClientesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiDomicilioFiscalesClientes(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DomicilioFiscalesClientesCollection
			If ( Not _alreadyFetchedDomicilioFiscalesClientes Or forceFetch Or _alwaysFetchDomicilioFiscalesClientes) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _domicilioFiscalesClientes.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_domicilioFiscalesClientes)
					End If
				End If
				_domicilioFiscalesClientes.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_domicilioFiscalesClientes.EntityFactoryToUse = entityFactoryToUse
				End If
				_domicilioFiscalesClientes.GetMultiManyToOne(Nothing, Me, Filter)
				_domicilioFiscalesClientes.SuppressClearInGetMulti = False
				_alreadyFetchedDomicilioFiscalesClientes = True
			End If
			Return _domicilioFiscalesClientes
		End Function

		''' <summary>Sets the collection parameters for the collection for 'DomicilioFiscalesClientes'. These settings will be taken into account
		''' when the property DomicilioFiscalesClientes is requested or GetMultiDomicilioFiscalesClientes is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersDomicilioFiscalesClientes(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_domicilioFiscalesClientes.SortClauses=sortClauses
			_domicilioFiscalesClientes.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'DomicilioFiscalEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'DomicilioFiscalEntity'</returns>
		Public Function GetMultiDomicilioFiscalCollectionViaDomicilioFiscalesClientes(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.DomicilioFiscalCollection
			Return GetMultiDomicilioFiscalCollectionViaDomicilioFiscalesClientes(forceFetch, _domicilioFiscalCollectionViaDomicilioFiscalesClientes.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'DomicilioFiscalEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiDomicilioFiscalCollectionViaDomicilioFiscalesClientes(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.DomicilioFiscalCollection
			If ( Not _alreadyFetchedDomicilioFiscalCollectionViaDomicilioFiscalesClientes Or forceFetch Or _alwaysFetchDomicilioFiscalCollectionViaDomicilioFiscalesClientes) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _domicilioFiscalCollectionViaDomicilioFiscalesClientes.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_domicilioFiscalCollectionViaDomicilioFiscalesClientes)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ClienteEntity.Relations.DomicilioFiscalesClientesEntityUsingCliente, "__ClienteEntity__", "DomicilioFiscalesClientes_", JoinHint.None)
				relations.Add(DomicilioFiscalesClientesEntity.Relations.DomicilioFiscalEntityUsingCodigo, "DomicilioFiscalesClientes_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ClienteFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_domicilioFiscalCollectionViaDomicilioFiscalesClientes.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_domicilioFiscalCollectionViaDomicilioFiscalesClientes.EntityFactoryToUse = entityFactoryToUse
				End If
				_domicilioFiscalCollectionViaDomicilioFiscalesClientes.GetMulti(Filter, relations)
				_domicilioFiscalCollectionViaDomicilioFiscalesClientes.SuppressClearInGetMulti = False
				_alreadyFetchedDomicilioFiscalCollectionViaDomicilioFiscalesClientes = True
			End If
			Return _domicilioFiscalCollectionViaDomicilioFiscalesClientes
		End Function

		''' <summary>Sets the collection parameters for the collection for 'DomicilioFiscalCollectionViaDomicilioFiscalesClientes'. These settings will be taken into account
		''' when the property DomicilioFiscalCollectionViaDomicilioFiscalesClientes is requested or GetMultiDomicilioFiscalCollectionViaDomicilioFiscalesClientes is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersDomicilioFiscalCollectionViaDomicilioFiscalesClientes(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_domicilioFiscalCollectionViaDomicilioFiscalesClientes.SortClauses=sortClauses
			_domicilioFiscalCollectionViaDomicilioFiscalesClientes.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves the related entity of type 'PlazaEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'PlazaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSinglePlaza() As PlazaEntity
			Return GetSinglePlaza(False)
		End Function

		''' <summary>Retrieves the related entity of type 'PlazaEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'PlazaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSinglePlaza(forceFetch As Boolean) As PlazaEntity
			If ( Not _alreadyFetchedPlaza Or forceFetch Or _alwaysFetchPlaza) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New PlazaEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(ClienteEntity.Relations.PlazaEntityUsingCodigoPlaza) Then
					fetchResult = newEntity.FetchUsingPK(Me.CodigoPlaza)
				End If
				If Not _plazaReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Plaza = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), PlazaEntity)
					End If
					Me.Plaza = newEntity
					_alreadyFetchedPlaza = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _plaza
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
				If MyBase.CheckIfLazyLoadingShouldOccur(ClienteEntity.Relations.ListaPrecioEntityUsingListaPrecios) Then
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(ClienteFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, ClienteFieldIndex)











					Case ClienteFieldIndex.CodigoPlaza
						DesetupSyncPlaza(True, False)
						_alreadyFetchedPlaza = False
					Case ClienteFieldIndex.ListaPrecios
						DesetupSyncListaPrecio(True, False)
						_alreadyFetchedListaPrecio = False





					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_domicilioFiscalesClientes.ActiveContext = MyBase.ActiveContext
			_domicilioFiscalCollectionViaDomicilioFiscalesClientes.ActiveContext = MyBase.ActiveContext
		If Not _plaza Is Nothing Then
				_plaza.ActiveContext = MyBase.ActiveContext
			End If
		If Not _listaPrecio Is Nothing Then
				_listaPrecio.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As ClienteDAO = CType(CreateDAOInstance(), ClienteDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As ClienteDAO = CType(CreateDAOInstance(), ClienteDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As ClienteDAO = CType(CreateDAOInstance(), ClienteDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this ClienteEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ClienteEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="codigo">PK value for Cliente which data should be fetched into this Cliente Object</param>
		''' <param name="validator">The validator Object for this ClienteEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(codigo As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(codigo, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_domicilioFiscalesClientes = New Integralab.ORM.CollectionClasses.DomicilioFiscalesClientesCollection(New DomicilioFiscalesClientesEntityFactory())
			_domicilioFiscalesClientes.SetContainingEntityInfo(Me, "Cliente_")
			_alwaysFetchDomicilioFiscalesClientes = False
			_alreadyFetchedDomicilioFiscalesClientes = False
			_domicilioFiscalCollectionViaDomicilioFiscalesClientes = New Integralab.ORM.CollectionClasses.DomicilioFiscalCollection(New DomicilioFiscalEntityFactory())
			_alwaysFetchDomicilioFiscalCollectionViaDomicilioFiscalesClientes = False
			_alreadyFetchedDomicilioFiscalCollectionViaDomicilioFiscalesClientes = False
			_plaza = Nothing
			_plazaReturnsNewIfNotFound = True
			_alwaysFetchPlaza = False
			_alreadyFetchedPlaza = False
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

			_fieldsCustomProperties.Add("Codigo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Nombres", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ApellidoPaterno", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ApellidoMaterno", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("UsuarioAlta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaAlta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCaptura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("PersonaFisica", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Rfc", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CodigoZona", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CodigoPlaza", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ListaPrecios", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("MotivoBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ObservacionesBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("UsuarioBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EsComprador", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _plaza</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncPlaza(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _plaza, AddressOf OnPlazaPropertyChanged, "Plaza", ClienteEntity.Relations.PlazaEntityUsingCodigoPlaza, True, signalRelatedEntity, "Cliente", resetFKFields, New Integer() { CInt(ClienteFieldIndex.CodigoPlaza) } )
			_plaza = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _plaza</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncPlaza(relatedEntity As IEntity)
			DesetupSyncPlaza(True, True)
			_plaza = CType(relatedEntity, PlazaEntity)
			MyBase.PerformSetupSyncRelatedEntity( _plaza, AddressOf OnPlazaPropertyChanged, "Plaza", ClienteEntity.Relations.PlazaEntityUsingCodigoPlaza, True, _alreadyFetchedPlaza, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnPlazaPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _listaPrecio</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncListaPrecio(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _listaPrecio, AddressOf OnListaPrecioPropertyChanged, "ListaPrecio", ClienteEntity.Relations.ListaPrecioEntityUsingListaPrecios, True, signalRelatedEntity, "Cliente", resetFKFields, New Integer() { CInt(ClienteFieldIndex.ListaPrecios) } )
			_listaPrecio = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _listaPrecio</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncListaPrecio(relatedEntity As IEntity)
			DesetupSyncListaPrecio(True, True)
			_listaPrecio = CType(relatedEntity, ListaPrecioEntity)
			MyBase.PerformSetupSyncRelatedEntity( _listaPrecio, AddressOf OnListaPrecioPropertyChanged, "ListaPrecio", ClienteEntity.Relations.ListaPrecioEntityUsingListaPrecios, True, _alreadyFetchedListaPrecio, New String() {  } )
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
		''' <param name="codigo">PK value for Cliente which data should be fetched into this Cliente Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(codigo As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(ClienteFieldIndex.Codigo)).ForcedCurrentValueWrite(codigo)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateClienteDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New ClienteEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As ClienteRelations
			Get	
				Return New ClienteRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DomicilioFiscalesClientes' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDomicilioFiscalesClientes() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DomicilioFiscalesClientesCollection(), _
					ClienteEntity.Relations.DomicilioFiscalesClientesEntityUsingCliente, _
					CType(Integralab.ORM.EntityType.ClienteEntity, Integer), CType(Integralab.ORM.EntityType.DomicilioFiscalesClientesEntity, Integer), 0, Nothing, Nothing, Nothing, "DomicilioFiscalesClientes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DomicilioFiscal' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDomicilioFiscalCollectionViaDomicilioFiscalesClientes() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ClienteEntity.Relations.DomicilioFiscalesClientesEntityUsingCliente, "__ClienteEntity__", String.Empty, JoinHint.None)
				relations.Add(DomicilioFiscalesClientesEntity.Relations.DomicilioFiscalEntityUsingCodigo)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DomicilioFiscalCollection(), _
					ClienteEntity.Relations.DomicilioFiscalesClientesEntityUsingCliente, _
					CType(Integralab.ORM.EntityType.ClienteEntity, Integer), CType(Integralab.ORM.EntityType.DomicilioFiscalEntity, Integer), 0, Nothing, Nothing, relations, "DomicilioFiscalCollectionViaDomicilioFiscalesClientes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Plaza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPlaza() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PlazaCollection(), _
					ClienteEntity.Relations.PlazaEntityUsingCodigoPlaza, _
					CType(Integralab.ORM.EntityType.ClienteEntity, Integer), CType(Integralab.ORM.EntityType.PlazaEntity, Integer), 0, Nothing, Nothing, Nothing, "Plaza", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ListaPrecio' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathListaPrecio() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ListaPrecioCollection(), _
					ClienteEntity.Relations.ListaPrecioEntityUsingListaPrecios, _
					CType(Integralab.ORM.EntityType.ClienteEntity, Integer), CType(Integralab.ORM.EntityType.ListaPrecioEntity, Integer), 0, Nothing, Nothing, Nothing, "ListaPrecio", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "ClienteEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return ClienteEntity.CustomProperties
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
				Return ClienteEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The Codigo property of the Entity Cliente<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasClientes"."CLIdCliente"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [Codigo]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ClienteFieldIndex.Codigo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ClienteFieldIndex.Codigo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Nombres property of the Entity Cliente<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasClientes"."CLNombres"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 150<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Nombres]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ClienteFieldIndex.Nombres, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ClienteFieldIndex.Nombres, Integer), value)
			End Set
		End Property
	
		''' <summary>The ApellidoPaterno property of the Entity Cliente<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasClientes"."CLApPaterno"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 80<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ApellidoPaterno]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ClienteFieldIndex.ApellidoPaterno, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ClienteFieldIndex.ApellidoPaterno, Integer), value)
			End Set
		End Property
	
		''' <summary>The ApellidoMaterno property of the Entity Cliente<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasClientes"."CLApMaterno"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 80<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ApellidoMaterno]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ClienteFieldIndex.ApellidoMaterno, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ClienteFieldIndex.ApellidoMaterno, Integer), value)
			End Set
		End Property
	
		''' <summary>The UsuarioAlta property of the Entity Cliente<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasClientes"."CLIdUsuarioAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [UsuarioAlta]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ClienteFieldIndex.UsuarioAlta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ClienteFieldIndex.UsuarioAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaAlta property of the Entity Cliente<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasClientes"."CLFechaAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaAlta]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ClienteFieldIndex.FechaAlta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(ClienteFieldIndex.FechaAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCaptura property of the Entity Cliente<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasClientes"."CLFechaCaptura"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaCaptura]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ClienteFieldIndex.FechaCaptura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(ClienteFieldIndex.FechaCaptura, Integer), value)
			End Set
		End Property
	
		''' <summary>The PersonaFisica property of the Entity Cliente<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasClientes"."CLPersonaFisica"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [PersonaFisica]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ClienteFieldIndex.PersonaFisica, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(ClienteFieldIndex.PersonaFisica, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity Cliente<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasClientes"."CLEstatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ClienteFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(ClienteFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The Rfc property of the Entity Cliente<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasClientes"."RFC"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 25<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Rfc]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ClienteFieldIndex.Rfc, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ClienteFieldIndex.Rfc, Integer), value)
			End Set
		End Property
	
		''' <summary>The CodigoZona property of the Entity Cliente<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasClientes"."CLIdZona"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CodigoZona]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ClienteFieldIndex.CodigoZona, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ClienteFieldIndex.CodigoZona, Integer), value)
			End Set
		End Property
	
		''' <summary>The CodigoPlaza property of the Entity Cliente<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasClientes"."CLIdPlaza"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CodigoPlaza]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ClienteFieldIndex.CodigoPlaza, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ClienteFieldIndex.CodigoPlaza, Integer), value)
			End Set
		End Property
	
		''' <summary>The ListaPrecios property of the Entity Cliente<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasClientes"."CLIdListaPrecios"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ListaPrecios]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ClienteFieldIndex.ListaPrecios, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ClienteFieldIndex.ListaPrecios, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaBaja property of the Entity Cliente<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasClientes"."CLFechaBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaBaja]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ClienteFieldIndex.FechaBaja, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(ClienteFieldIndex.FechaBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The MotivoBaja property of the Entity Cliente<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasClientes"."CLIdMotivoBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [MotivoBaja]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ClienteFieldIndex.MotivoBaja, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(ClienteFieldIndex.MotivoBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The ObservacionesBaja property of the Entity Cliente<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasClientes"."CLObservacionesBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [ObservacionesBaja]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ClienteFieldIndex.ObservacionesBaja, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ClienteFieldIndex.ObservacionesBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The UsuarioBaja property of the Entity Cliente<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasClientes"."CLIdUsuarioBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [UsuarioBaja]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ClienteFieldIndex.UsuarioBaja, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(ClienteFieldIndex.UsuarioBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The EsComprador property of the Entity Cliente<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVtasClientes"."CLEsComprador"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [EsComprador]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ClienteFieldIndex.EsComprador, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(ClienteFieldIndex.EsComprador, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'DomicilioFiscalesClientesEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDomicilioFiscalesClientes()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [DomicilioFiscalesClientes]() As Integralab.ORM.CollectionClasses.DomicilioFiscalesClientesCollection
			Get
				Return GetMultiDomicilioFiscalesClientes(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for DomicilioFiscalesClientes. When set to true, DomicilioFiscalesClientes is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time DomicilioFiscalesClientes is accessed. You can always execute
		''' a forced fetch by calling GetMultiDomicilioFiscalesClientes(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchDomicilioFiscalesClientes As Boolean
			Get
				Return _alwaysFetchDomicilioFiscalesClientes
			End Get
			Set
				_alwaysFetchDomicilioFiscalesClientes = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'DomicilioFiscalEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDomicilioFiscalCollectionViaDomicilioFiscalesClientes()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [DomicilioFiscalCollectionViaDomicilioFiscalesClientes]() As Integralab.ORM.CollectionClasses.DomicilioFiscalCollection
			Get
				Return GetMultiDomicilioFiscalCollectionViaDomicilioFiscalesClientes(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for DomicilioFiscalCollectionViaDomicilioFiscalesClientes. When set to true, DomicilioFiscalCollectionViaDomicilioFiscalesClientes is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time DomicilioFiscalCollectionViaDomicilioFiscalesClientes is accessed. You can always execute
		''' a forced fetch by calling GetMultiDomicilioFiscalCollectionViaDomicilioFiscalesClientes(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchDomicilioFiscalCollectionViaDomicilioFiscalesClientes As Boolean
			Get
				Return _alwaysFetchDomicilioFiscalCollectionViaDomicilioFiscalesClientes
			End Get
			Set
				_alwaysFetchDomicilioFiscalCollectionViaDomicilioFiscalesClientes = value
			End Set	
		End Property
	
	
		''' <summary>Gets / sets related entity of type 'PlazaEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSinglePlaza()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Plaza]() As PlazaEntity
			Get
				Return GetSinglePlaza(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncPlaza(value)
				Else
					If value Is Nothing Then
						If Not _plaza Is Nothing Then
							_plaza.UnsetRelatedEntity(Me, "Cliente")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "Cliente")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Plaza. When set to true, Plaza is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Plaza is accessed. You can always execute
		''' a forced fetch by calling GetSinglePlaza(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPlaza As Boolean
			Get
				Return _alwaysFetchPlaza
			End Get
			Set
				_alwaysFetchPlaza = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Plaza is not found
		''' in the database. When set to true, Plaza will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property PlazaReturnsNewIfNotFound As Boolean
			Get
				Return _plazaReturnsNewIfNotFound
			End Get
			Set
				_plazaReturnsNewIfNotFound = value
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
							_listaPrecio.UnsetRelatedEntity(Me, "Cliente")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "Cliente")
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
				Return CInt(Integralab.ORM.EntityType.ClienteEntity)
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
