' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 2 de febrero de 2018 11:54:49
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
	''' <summary>Entity class which represents the entity 'NotaCreditoCab'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class NotaCreditoCabEntity 
#Else
	<Serializable()> _
	Public Class NotaCreditoCabEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _notaCreditoDet As Integralab.ORM.CollectionClasses.NotaCreditoDetCollection
		Private _alwaysFetchNotaCreditoDet, _alreadyFetchedNotaCreditoDet As Boolean

		Private _catTipNotas As CatTipNotasEntity
		Private _alwaysFetchCatTipNotas, _alreadyFetchedCatTipNotas, _catTipNotasReturnsNewIfNotFound As Boolean
		Private _mfacCatClientes As MfacCatClientesEntity
		Private _alwaysFetchMfacCatClientes, _alreadyFetchedMfacCatClientes, _mfacCatClientesReturnsNewIfNotFound As Boolean


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
		''' <param name="folNota">PK value for NotaCreditoCab which data should be fetched into this NotaCreditoCab Object</param>
		Public Sub New(folNota As System.String)

			InitClassFetch(folNota, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folNota">PK value for NotaCreditoCab which data should be fetched into this NotaCreditoCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(folNota As System.String, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(folNota, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folNota">PK value for NotaCreditoCab which data should be fetched into this NotaCreditoCab Object</param>
		''' <param name="validator">The custom validator Object for this NotaCreditoCabEntity</param>
		Public Sub New(folNota As System.String, validator As IValidator)

			InitClassFetch(folNota, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_notaCreditoDet = CType(info.GetValue("_notaCreditoDet", GetType(Integralab.ORM.CollectionClasses.NotaCreditoDetCollection)), Integralab.ORM.CollectionClasses.NotaCreditoDetCollection)
			_alwaysFetchNotaCreditoDet = info.GetBoolean("_alwaysFetchNotaCreditoDet")
			_alreadyFetchedNotaCreditoDet = info.GetBoolean("_alreadyFetchedNotaCreditoDet")

			_catTipNotas = CType(info.GetValue("_catTipNotas", GetType(CatTipNotasEntity)), CatTipNotasEntity)
			If Not _catTipNotas Is Nothing Then
				AddHandler _catTipNotas.AfterSave, AddressOf OnEntityAfterSave
			End If
			_catTipNotasReturnsNewIfNotFound = info.GetBoolean("_catTipNotasReturnsNewIfNotFound")
			_alwaysFetchCatTipNotas = info.GetBoolean("_alwaysFetchCatTipNotas")
			_alreadyFetchedCatTipNotas = info.GetBoolean("_alreadyFetchedCatTipNotas")
			_mfacCatClientes = CType(info.GetValue("_mfacCatClientes", GetType(MfacCatClientesEntity)), MfacCatClientesEntity)
			If Not _mfacCatClientes Is Nothing Then
				AddHandler _mfacCatClientes.AfterSave, AddressOf OnEntityAfterSave
			End If
			_mfacCatClientesReturnsNewIfNotFound = info.GetBoolean("_mfacCatClientesReturnsNewIfNotFound")
			_alwaysFetchMfacCatClientes = info.GetBoolean("_alwaysFetchMfacCatClientes")
			_alreadyFetchedMfacCatClientes = info.GetBoolean("_alreadyFetchedMfacCatClientes")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedNotaCreditoDet = (_notaCreditoDet.Count > 0)

			_alreadyFetchedCatTipNotas = Not(_catTipNotas Is Nothing)
			_alreadyFetchedMfacCatClientes = Not(_mfacCatClientes Is Nothing)

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
			info.AddValue("_notaCreditoDet", _notaCreditoDet)
			info.AddValue("_alwaysFetchNotaCreditoDet", _alwaysFetchNotaCreditoDet)
			info.AddValue("_alreadyFetchedNotaCreditoDet", _alreadyFetchedNotaCreditoDet)

			info.AddValue("_catTipNotas", _catTipNotas)
			info.AddValue("_catTipNotasReturnsNewIfNotFound", _catTipNotasReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchCatTipNotas", _alwaysFetchCatTipNotas)
			info.AddValue("_alreadyFetchedCatTipNotas", _alreadyFetchedCatTipNotas)
			info.AddValue("_mfacCatClientes", _mfacCatClientes)
			info.AddValue("_mfacCatClientesReturnsNewIfNotFound", _mfacCatClientesReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMfacCatClientes", _alwaysFetchMfacCatClientes)
			info.AddValue("_alreadyFetchedMfacCatClientes", _alreadyFetchedMfacCatClientes)

			
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
				Case "CatTipNotas"
					_alreadyFetchedCatTipNotas = True
					Me.CatTipNotas = CType(entity, CatTipNotasEntity)
				Case "MfacCatClientes"
					_alreadyFetchedMfacCatClientes = True
					Me.MfacCatClientes = CType(entity, MfacCatClientesEntity)
				Case "NotaCreditoDet"
					_alreadyFetchedNotaCreditoDet = True
					If Not entity Is Nothing Then
						Me.NotaCreditoDet.Add(CType(entity, NotaCreditoDetEntity))
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
				Case "CatTipNotas"
					SetupSyncCatTipNotas(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MfacCatClientes"
					SetupSyncMfacCatClientes(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "NotaCreditoDet"
					_notaCreditoDet.Add(CType(relatedEntity, NotaCreditoDetEntity))
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
				Case "CatTipNotas"
					DesetupSyncCatTipNotas(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MfacCatClientes"
					DesetupSyncMfacCatClientes(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "NotaCreditoDet"
					MyBase.PerformRelatedEntityRemoval(_notaCreditoDet, relatedEntity, signalRelatedEntityManyToOne)
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
			If Not _catTipNotas Is Nothing Then
				toReturn.Add(_catTipNotas)
			End If
			If Not _mfacCatClientes Is Nothing Then
				toReturn.Add(_mfacCatClientes)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_notaCreditoDet)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folNota">PK value for NotaCreditoCab which data should be fetched into this NotaCreditoCab Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folNota As System.String) As Boolean
			Return FetchUsingPK(folNota, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folNota">PK value for NotaCreditoCab which data should be fetched into this NotaCreditoCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folNota As System.String, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(folNota, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folNota">PK value for NotaCreditoCab which data should be fetched into this NotaCreditoCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folNota As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(folNota, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.FolNota, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As NotaCreditoCabFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As NotaCreditoCabFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'NotaCreditoDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'NotaCreditoDetEntity'</returns>
		Public Function GetMultiNotaCreditoDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.NotaCreditoDetCollection
			Return GetMultiNotaCreditoDet(forceFetch, _notaCreditoDet.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'NotaCreditoDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiNotaCreditoDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.NotaCreditoDetCollection
			Return GetMultiNotaCreditoDet(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'NotaCreditoDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'NotaCreditoDetEntity'</returns>
		Public Function GetMultiNotaCreditoDet(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.NotaCreditoDetCollection
			Return GetMultiNotaCreditoDet(forceFetch, _notaCreditoDet.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'NotaCreditoDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiNotaCreditoDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.NotaCreditoDetCollection
			If ( Not _alreadyFetchedNotaCreditoDet Or forceFetch Or _alwaysFetchNotaCreditoDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _notaCreditoDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_notaCreditoDet)
					End If
				End If
				_notaCreditoDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_notaCreditoDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_notaCreditoDet.GetMultiManyToOne(Nothing, Me, Filter)
				_notaCreditoDet.SuppressClearInGetMulti = False
				_alreadyFetchedNotaCreditoDet = True
			End If
			Return _notaCreditoDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'NotaCreditoDet'. These settings will be taken into account
		''' when the property NotaCreditoDet is requested or GetMultiNotaCreditoDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersNotaCreditoDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_notaCreditoDet.SortClauses=sortClauses
			_notaCreditoDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	

		''' <summary>Retrieves the related entity of type 'CatTipNotasEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'CatTipNotasEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCatTipNotas() As CatTipNotasEntity
			Return GetSingleCatTipNotas(False)
		End Function

		''' <summary>Retrieves the related entity of type 'CatTipNotasEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'CatTipNotasEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCatTipNotas(forceFetch As Boolean) As CatTipNotasEntity
			If ( Not _alreadyFetchedCatTipNotas Or forceFetch Or _alwaysFetchCatTipNotas) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New CatTipNotasEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(NotaCreditoCabEntity.Relations.CatTipNotasEntityUsingIdConcepto) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdConcepto)
				End If
				If Not _catTipNotasReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.CatTipNotas = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), CatTipNotasEntity)
					End If
					Me.CatTipNotas = newEntity
					_alreadyFetchedCatTipNotas = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _catTipNotas
		End Function
	
		''' <summary>Retrieves the related entity of type 'MfacCatClientesEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'MfacCatClientesEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMfacCatClientes() As MfacCatClientesEntity
			Return GetSingleMfacCatClientes(False)
		End Function

		''' <summary>Retrieves the related entity of type 'MfacCatClientesEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'MfacCatClientesEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMfacCatClientes(forceFetch As Boolean) As MfacCatClientesEntity
			If ( Not _alreadyFetchedMfacCatClientes Or forceFetch Or _alwaysFetchMfacCatClientes) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New MfacCatClientesEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(NotaCreditoCabEntity.Relations.MfacCatClientesEntityUsingIdCliente) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdCliente)
				End If
				If Not _mfacCatClientesReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.MfacCatClientes = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), MfacCatClientesEntity)
					End If
					Me.MfacCatClientes = newEntity
					_alreadyFetchedMfacCatClientes = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _mfacCatClientes
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(NotaCreditoCabFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, NotaCreditoCabFieldIndex)

					Case NotaCreditoCabFieldIndex.IdCliente
						DesetupSyncMfacCatClientes(True, False)
						_alreadyFetchedMfacCatClientes = False




					Case NotaCreditoCabFieldIndex.IdConcepto
						DesetupSyncCatTipNotas(True, False)
						_alreadyFetchedCatTipNotas = False


					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_notaCreditoDet.ActiveContext = MyBase.ActiveContext

		If Not _catTipNotas Is Nothing Then
				_catTipNotas.ActiveContext = MyBase.ActiveContext
			End If
		If Not _mfacCatClientes Is Nothing Then
				_mfacCatClientes.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As NotaCreditoCabDAO = CType(CreateDAOInstance(), NotaCreditoCabDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As NotaCreditoCabDAO = CType(CreateDAOInstance(), NotaCreditoCabDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As NotaCreditoCabDAO = CType(CreateDAOInstance(), NotaCreditoCabDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this NotaCreditoCabEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.NotaCreditoCabEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="folNota">PK value for NotaCreditoCab which data should be fetched into this NotaCreditoCab Object</param>
		''' <param name="validator">The validator Object for this NotaCreditoCabEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(folNota As System.String, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(folNota, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_notaCreditoDet = New Integralab.ORM.CollectionClasses.NotaCreditoDetCollection(New NotaCreditoDetEntityFactory())
			_notaCreditoDet.SetContainingEntityInfo(Me, "NotaCreditoCab")
			_alwaysFetchNotaCreditoDet = False
			_alreadyFetchedNotaCreditoDet = False

			_catTipNotas = Nothing
			_catTipNotasReturnsNewIfNotFound = True
			_alwaysFetchCatTipNotas = False
			_alreadyFetchedCatTipNotas = False
			_mfacCatClientes = Nothing
			_mfacCatClientesReturnsNewIfNotFound = True
			_alwaysFetchMfacCatClientes = False
			_alreadyFetchedMfacCatClientes = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolNota", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdCliente", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaNota", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Elaboro", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Autorizo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdConcepto", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Total", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Observaciones", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _catTipNotas</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncCatTipNotas(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _catTipNotas, AddressOf OnCatTipNotasPropertyChanged, "CatTipNotas", NotaCreditoCabEntity.Relations.CatTipNotasEntityUsingIdConcepto, True, signalRelatedEntity, "NotaCreditoCab", resetFKFields, New Integer() { CInt(NotaCreditoCabFieldIndex.IdConcepto) } )
			_catTipNotas = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _catTipNotas</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncCatTipNotas(relatedEntity As IEntity)
			DesetupSyncCatTipNotas(True, True)
			_catTipNotas = CType(relatedEntity, CatTipNotasEntity)
			MyBase.PerformSetupSyncRelatedEntity( _catTipNotas, AddressOf OnCatTipNotasPropertyChanged, "CatTipNotas", NotaCreditoCabEntity.Relations.CatTipNotasEntityUsingIdConcepto, True, _alreadyFetchedCatTipNotas, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnCatTipNotasPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _mfacCatClientes</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMfacCatClientes(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _mfacCatClientes, AddressOf OnMfacCatClientesPropertyChanged, "MfacCatClientes", NotaCreditoCabEntity.Relations.MfacCatClientesEntityUsingIdCliente, True, signalRelatedEntity, "NotaCreditoCab", resetFKFields, New Integer() { CInt(NotaCreditoCabFieldIndex.IdCliente) } )
			_mfacCatClientes = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _mfacCatClientes</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMfacCatClientes(relatedEntity As IEntity)
			DesetupSyncMfacCatClientes(True, True)
			_mfacCatClientes = CType(relatedEntity, MfacCatClientesEntity)
			MyBase.PerformSetupSyncRelatedEntity( _mfacCatClientes, AddressOf OnMfacCatClientesPropertyChanged, "MfacCatClientes", NotaCreditoCabEntity.Relations.MfacCatClientesEntityUsingIdCliente, True, _alreadyFetchedMfacCatClientes, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMfacCatClientesPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="folNota">PK value for NotaCreditoCab which data should be fetched into this NotaCreditoCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(folNota As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(NotaCreditoCabFieldIndex.FolNota)).ForcedCurrentValueWrite(folNota)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateNotaCreditoCabDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New NotaCreditoCabEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As NotaCreditoCabRelations
			Get	
				Return New NotaCreditoCabRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'NotaCreditoDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathNotaCreditoDet() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.NotaCreditoDetCollection(), _
					NotaCreditoCabEntity.Relations.NotaCreditoDetEntityUsingFolNota, _
					CType(Integralab.ORM.EntityType.NotaCreditoCabEntity, Integer), CType(Integralab.ORM.EntityType.NotaCreditoDetEntity, Integer), 0, Nothing, Nothing, Nothing, "NotaCreditoDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CatTipNotas' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCatTipNotas() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CatTipNotasCollection(), _
					NotaCreditoCabEntity.Relations.CatTipNotasEntityUsingIdConcepto, _
					CType(Integralab.ORM.EntityType.NotaCreditoCabEntity, Integer), CType(Integralab.ORM.EntityType.CatTipNotasEntity, Integer), 0, Nothing, Nothing, Nothing, "CatTipNotas", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MfacCatClientes' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMfacCatClientes() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MfacCatClientesCollection(), _
					NotaCreditoCabEntity.Relations.MfacCatClientesEntityUsingIdCliente, _
					CType(Integralab.ORM.EntityType.NotaCreditoCabEntity, Integer), CType(Integralab.ORM.EntityType.MfacCatClientesEntity, Integer), 0, Nothing, Nothing, Nothing, "MfacCatClientes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "NotaCreditoCabEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return NotaCreditoCabEntity.CustomProperties
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
				Return NotaCreditoCabEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The FolNota property of the Entity NotaCreditoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NotaCreditoCab"."Fol_Nota"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 8<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [FolNota]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NotaCreditoCabFieldIndex.FolNota, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(NotaCreditoCabFieldIndex.FolNota, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdCliente property of the Entity NotaCreditoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NotaCreditoCab"."IdCliente"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdCliente]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NotaCreditoCabFieldIndex.IdCliente, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(NotaCreditoCabFieldIndex.IdCliente, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaNota property of the Entity NotaCreditoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NotaCreditoCab"."Fecha_Nota"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaNota]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NotaCreditoCabFieldIndex.FechaNota, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(NotaCreditoCabFieldIndex.FechaNota, Integer), value)
			End Set
		End Property
	
		''' <summary>The Elaboro property of the Entity NotaCreditoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NotaCreditoCab"."Elaboro"<br/>
		''' Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 60<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Elaboro]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NotaCreditoCabFieldIndex.Elaboro, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(NotaCreditoCabFieldIndex.Elaboro, Integer), value)
			End Set
		End Property
	
		''' <summary>The Autorizo property of the Entity NotaCreditoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NotaCreditoCab"."Autorizo"<br/>
		''' Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 60<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Autorizo]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NotaCreditoCabFieldIndex.Autorizo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(NotaCreditoCabFieldIndex.Autorizo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity NotaCreditoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NotaCreditoCab"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Byte
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NotaCreditoCabFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Byte))
				End If
				Return CType(valueToReturn, System.Byte)
			End Get
			Set
				SetNewFieldValue(CType(NotaCreditoCabFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdConcepto property of the Entity NotaCreditoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NotaCreditoCab"."IdConcepto"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdConcepto]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NotaCreditoCabFieldIndex.IdConcepto, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(NotaCreditoCabFieldIndex.IdConcepto, Integer), value)
			End Set
		End Property
	
		''' <summary>The Total property of the Entity NotaCreditoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NotaCreditoCab"."Total"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Total]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NotaCreditoCabFieldIndex.Total, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NotaCreditoCabFieldIndex.Total, Integer), value)
			End Set
		End Property
	
		''' <summary>The Observaciones property of the Entity NotaCreditoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NotaCreditoCab"."Observaciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 150<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Observaciones]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NotaCreditoCabFieldIndex.Observaciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(NotaCreditoCabFieldIndex.Observaciones, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'NotaCreditoDetEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiNotaCreditoDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [NotaCreditoDet]() As Integralab.ORM.CollectionClasses.NotaCreditoDetCollection
			Get
				Return GetMultiNotaCreditoDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for NotaCreditoDet. When set to true, NotaCreditoDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time NotaCreditoDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiNotaCreditoDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchNotaCreditoDet As Boolean
			Get
				Return _alwaysFetchNotaCreditoDet
			End Get
			Set
				_alwaysFetchNotaCreditoDet = value
			End Set	
		End Property
	
	
	
		''' <summary>Gets / sets related entity of type 'CatTipNotasEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCatTipNotas()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [CatTipNotas]() As CatTipNotasEntity
			Get
				Return GetSingleCatTipNotas(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncCatTipNotas(value)
				Else
					If value Is Nothing Then
						If Not _catTipNotas Is Nothing Then
							_catTipNotas.UnsetRelatedEntity(Me, "NotaCreditoCab")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "NotaCreditoCab")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for CatTipNotas. When set to true, CatTipNotas is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CatTipNotas is accessed. You can always execute
		''' a forced fetch by calling GetSingleCatTipNotas(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCatTipNotas As Boolean
			Get
				Return _alwaysFetchCatTipNotas
			End Get
			Set
				_alwaysFetchCatTipNotas = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property CatTipNotas is not found
		''' in the database. When set to true, CatTipNotas will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property CatTipNotasReturnsNewIfNotFound As Boolean
			Get
				Return _catTipNotasReturnsNewIfNotFound
			End Get
			Set
				_catTipNotasReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'MfacCatClientesEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMfacCatClientes()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [MfacCatClientes]() As MfacCatClientesEntity
			Get
				Return GetSingleMfacCatClientes(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMfacCatClientes(value)
				Else
					If value Is Nothing Then
						If Not _mfacCatClientes Is Nothing Then
							_mfacCatClientes.UnsetRelatedEntity(Me, "NotaCreditoCab")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "NotaCreditoCab")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for MfacCatClientes. When set to true, MfacCatClientes is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MfacCatClientes is accessed. You can always execute
		''' a forced fetch by calling GetSingleMfacCatClientes(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMfacCatClientes As Boolean
			Get
				Return _alwaysFetchMfacCatClientes
			End Get
			Set
				_alwaysFetchMfacCatClientes = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property MfacCatClientes is not found
		''' in the database. When set to true, MfacCatClientes will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property MfacCatClientesReturnsNewIfNotFound As Boolean
			Get
				Return _mfacCatClientesReturnsNewIfNotFound
			End Get
			Set
				_mfacCatClientesReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.NotaCreditoCabEntity)
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
