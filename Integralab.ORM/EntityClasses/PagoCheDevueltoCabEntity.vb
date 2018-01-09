' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 5 de enero de 2018 17:48:22
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
	''' <summary>Entity class which represents the entity 'PagoCheDevueltoCab'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class PagoCheDevueltoCabEntity 
#Else
	<Serializable()> _
	Public Class PagoCheDevueltoCabEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _pagoCheDevueltoDet As Integralab.ORM.CollectionClasses.PagoCheDevueltoDetCollection
		Private _alwaysFetchPagoCheDevueltoDet, _alreadyFetchedPagoCheDevueltoDet As Boolean
		Private _chequeDevueltoCollectionViaPagoCheDevueltoDet As Integralab.ORM.CollectionClasses.ChequeDevueltoCollection
		Private _alwaysFetchChequeDevueltoCollectionViaPagoCheDevueltoDet, _alreadyFetchedChequeDevueltoCollectionViaPagoCheDevueltoDet As Boolean
		Private _bancos As BancosEntity
		Private _alwaysFetchBancos, _alreadyFetchedBancos, _bancosReturnsNewIfNotFound As Boolean


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
		''' <param name="idPagoCheDevueltoCab">PK value for PagoCheDevueltoCab which data should be fetched into this PagoCheDevueltoCab Object</param>
		Public Sub New(idPagoCheDevueltoCab As System.Int32)

			InitClassFetch(idPagoCheDevueltoCab, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idPagoCheDevueltoCab">PK value for PagoCheDevueltoCab which data should be fetched into this PagoCheDevueltoCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(idPagoCheDevueltoCab As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(idPagoCheDevueltoCab, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idPagoCheDevueltoCab">PK value for PagoCheDevueltoCab which data should be fetched into this PagoCheDevueltoCab Object</param>
		''' <param name="validator">The custom validator Object for this PagoCheDevueltoCabEntity</param>
		Public Sub New(idPagoCheDevueltoCab As System.Int32, validator As IValidator)

			InitClassFetch(idPagoCheDevueltoCab, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_pagoCheDevueltoDet = CType(info.GetValue("_pagoCheDevueltoDet", GetType(Integralab.ORM.CollectionClasses.PagoCheDevueltoDetCollection)), Integralab.ORM.CollectionClasses.PagoCheDevueltoDetCollection)
			_alwaysFetchPagoCheDevueltoDet = info.GetBoolean("_alwaysFetchPagoCheDevueltoDet")
			_alreadyFetchedPagoCheDevueltoDet = info.GetBoolean("_alreadyFetchedPagoCheDevueltoDet")
			_chequeDevueltoCollectionViaPagoCheDevueltoDet = CType(info.GetValue("_chequeDevueltoCollectionViaPagoCheDevueltoDet", GetType(Integralab.ORM.CollectionClasses.ChequeDevueltoCollection)), Integralab.ORM.CollectionClasses.ChequeDevueltoCollection)
			_alwaysFetchChequeDevueltoCollectionViaPagoCheDevueltoDet = info.GetBoolean("_alwaysFetchChequeDevueltoCollectionViaPagoCheDevueltoDet")
			_alreadyFetchedChequeDevueltoCollectionViaPagoCheDevueltoDet = info.GetBoolean("_alreadyFetchedChequeDevueltoCollectionViaPagoCheDevueltoDet")
			_bancos = CType(info.GetValue("_bancos", GetType(BancosEntity)), BancosEntity)
			If Not _bancos Is Nothing Then
				AddHandler _bancos.AfterSave, AddressOf OnEntityAfterSave
			End If
			_bancosReturnsNewIfNotFound = info.GetBoolean("_bancosReturnsNewIfNotFound")
			_alwaysFetchBancos = info.GetBoolean("_alwaysFetchBancos")
			_alreadyFetchedBancos = info.GetBoolean("_alreadyFetchedBancos")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedPagoCheDevueltoDet = (_pagoCheDevueltoDet.Count > 0)
			_alreadyFetchedChequeDevueltoCollectionViaPagoCheDevueltoDet = (_chequeDevueltoCollectionViaPagoCheDevueltoDet.Count > 0)
			_alreadyFetchedBancos = Not(_bancos Is Nothing)

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
			info.AddValue("_pagoCheDevueltoDet", _pagoCheDevueltoDet)
			info.AddValue("_alwaysFetchPagoCheDevueltoDet", _alwaysFetchPagoCheDevueltoDet)
			info.AddValue("_alreadyFetchedPagoCheDevueltoDet", _alreadyFetchedPagoCheDevueltoDet)
			info.AddValue("_chequeDevueltoCollectionViaPagoCheDevueltoDet", _chequeDevueltoCollectionViaPagoCheDevueltoDet)
			info.AddValue("_alwaysFetchChequeDevueltoCollectionViaPagoCheDevueltoDet", _alwaysFetchChequeDevueltoCollectionViaPagoCheDevueltoDet)
			info.AddValue("_alreadyFetchedChequeDevueltoCollectionViaPagoCheDevueltoDet", _alreadyFetchedChequeDevueltoCollectionViaPagoCheDevueltoDet)
			info.AddValue("_bancos", _bancos)
			info.AddValue("_bancosReturnsNewIfNotFound", _bancosReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchBancos", _alwaysFetchBancos)
			info.AddValue("_alreadyFetchedBancos", _alreadyFetchedBancos)

			
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
				Case "Bancos"
					_alreadyFetchedBancos = True
					Me.Bancos = CType(entity, BancosEntity)
				Case "PagoCheDevueltoDet"
					_alreadyFetchedPagoCheDevueltoDet = True
					If Not entity Is Nothing Then
						Me.PagoCheDevueltoDet.Add(CType(entity, PagoCheDevueltoDetEntity))
					End If
				Case "ChequeDevueltoCollectionViaPagoCheDevueltoDet"
					_alreadyFetchedChequeDevueltoCollectionViaPagoCheDevueltoDet = True
					If Not entity Is Nothing Then
						Me.ChequeDevueltoCollectionViaPagoCheDevueltoDet.Add(CType(entity, ChequeDevueltoEntity))
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
				Case "Bancos"
					SetupSyncBancos(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "PagoCheDevueltoDet"
					_pagoCheDevueltoDet.Add(CType(relatedEntity, PagoCheDevueltoDetEntity))
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
				Case "Bancos"
					DesetupSyncBancos(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "PagoCheDevueltoDet"
					MyBase.PerformRelatedEntityRemoval(_pagoCheDevueltoDet, relatedEntity, signalRelatedEntityManyToOne)
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
			If Not _bancos Is Nothing Then
				toReturn.Add(_bancos)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_pagoCheDevueltoDet)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idPagoCheDevueltoCab">PK value for PagoCheDevueltoCab which data should be fetched into this PagoCheDevueltoCab Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idPagoCheDevueltoCab As System.Int32) As Boolean
			Return FetchUsingPK(idPagoCheDevueltoCab, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idPagoCheDevueltoCab">PK value for PagoCheDevueltoCab which data should be fetched into this PagoCheDevueltoCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idPagoCheDevueltoCab As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(idPagoCheDevueltoCab, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idPagoCheDevueltoCab">PK value for PagoCheDevueltoCab which data should be fetched into this PagoCheDevueltoCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idPagoCheDevueltoCab As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(idPagoCheDevueltoCab, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.IdPagoCheDevueltoCab, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As PagoCheDevueltoCabFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As PagoCheDevueltoCabFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'PagoCheDevueltoDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PagoCheDevueltoDetEntity'</returns>
		Public Function GetMultiPagoCheDevueltoDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PagoCheDevueltoDetCollection
			Return GetMultiPagoCheDevueltoDet(forceFetch, _pagoCheDevueltoDet.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'PagoCheDevueltoDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiPagoCheDevueltoDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PagoCheDevueltoDetCollection
			Return GetMultiPagoCheDevueltoDet(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'PagoCheDevueltoDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'PagoCheDevueltoDetEntity'</returns>
		Public Function GetMultiPagoCheDevueltoDet(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.PagoCheDevueltoDetCollection
			Return GetMultiPagoCheDevueltoDet(forceFetch, _pagoCheDevueltoDet.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'PagoCheDevueltoDetEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPagoCheDevueltoDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.PagoCheDevueltoDetCollection
			If ( Not _alreadyFetchedPagoCheDevueltoDet Or forceFetch Or _alwaysFetchPagoCheDevueltoDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _pagoCheDevueltoDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_pagoCheDevueltoDet)
					End If
				End If
				_pagoCheDevueltoDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_pagoCheDevueltoDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_pagoCheDevueltoDet.GetMultiManyToOne(Nothing, Me, Filter)
				_pagoCheDevueltoDet.SuppressClearInGetMulti = False
				_alreadyFetchedPagoCheDevueltoDet = True
			End If
			Return _pagoCheDevueltoDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PagoCheDevueltoDet'. These settings will be taken into account
		''' when the property PagoCheDevueltoDet is requested or GetMultiPagoCheDevueltoDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPagoCheDevueltoDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_pagoCheDevueltoDet.SortClauses=sortClauses
			_pagoCheDevueltoDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'ChequeDevueltoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ChequeDevueltoEntity'</returns>
		Public Function GetMultiChequeDevueltoCollectionViaPagoCheDevueltoDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ChequeDevueltoCollection
			Return GetMultiChequeDevueltoCollectionViaPagoCheDevueltoDet(forceFetch, _chequeDevueltoCollectionViaPagoCheDevueltoDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ChequeDevueltoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiChequeDevueltoCollectionViaPagoCheDevueltoDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ChequeDevueltoCollection
			If ( Not _alreadyFetchedChequeDevueltoCollectionViaPagoCheDevueltoDet Or forceFetch Or _alwaysFetchChequeDevueltoCollectionViaPagoCheDevueltoDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _chequeDevueltoCollectionViaPagoCheDevueltoDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_chequeDevueltoCollectionViaPagoCheDevueltoDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(PagoCheDevueltoCabEntity.Relations.PagoCheDevueltoDetEntityUsingIdPagoCheDevueltoCab, "__PagoCheDevueltoCabEntity__", "PagoCheDevueltoDet_", JoinHint.None)
				relations.Add(PagoCheDevueltoDetEntity.Relations.ChequeDevueltoEntityUsingIdChequeDevuelto, "PagoCheDevueltoDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PagoCheDevueltoCabFieldIndex.IdPagoCheDevueltoCab), ComparisonOperator.Equal, Me.IdPagoCheDevueltoCab))
				_chequeDevueltoCollectionViaPagoCheDevueltoDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_chequeDevueltoCollectionViaPagoCheDevueltoDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_chequeDevueltoCollectionViaPagoCheDevueltoDet.GetMulti(Filter, relations)
				_chequeDevueltoCollectionViaPagoCheDevueltoDet.SuppressClearInGetMulti = False
				_alreadyFetchedChequeDevueltoCollectionViaPagoCheDevueltoDet = True
			End If
			Return _chequeDevueltoCollectionViaPagoCheDevueltoDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ChequeDevueltoCollectionViaPagoCheDevueltoDet'. These settings will be taken into account
		''' when the property ChequeDevueltoCollectionViaPagoCheDevueltoDet is requested or GetMultiChequeDevueltoCollectionViaPagoCheDevueltoDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersChequeDevueltoCollectionViaPagoCheDevueltoDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_chequeDevueltoCollectionViaPagoCheDevueltoDet.SortClauses=sortClauses
			_chequeDevueltoCollectionViaPagoCheDevueltoDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves the related entity of type 'BancosEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'BancosEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleBancos() As BancosEntity
			Return GetSingleBancos(False)
		End Function

		''' <summary>Retrieves the related entity of type 'BancosEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'BancosEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleBancos(forceFetch As Boolean) As BancosEntity
			If ( Not _alreadyFetchedBancos Or forceFetch Or _alwaysFetchBancos) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New BancosEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(PagoCheDevueltoCabEntity.Relations.BancosEntityUsingIdBancoDeposito) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdBancoDeposito.GetValueOrDefault())
				End If
				If Not _bancosReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Bancos = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), BancosEntity)
					End If
					Me.Bancos = newEntity
					_alreadyFetchedBancos = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _bancos
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(PagoCheDevueltoCabFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, PagoCheDevueltoCabFieldIndex)









					Case PagoCheDevueltoCabFieldIndex.IdBancoDeposito
						DesetupSyncBancos(True, False)
						_alreadyFetchedBancos = False
					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_pagoCheDevueltoDet.ActiveContext = MyBase.ActiveContext
			_chequeDevueltoCollectionViaPagoCheDevueltoDet.ActiveContext = MyBase.ActiveContext
		If Not _bancos Is Nothing Then
				_bancos.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As PagoCheDevueltoCabDAO = CType(CreateDAOInstance(), PagoCheDevueltoCabDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As PagoCheDevueltoCabDAO = CType(CreateDAOInstance(), PagoCheDevueltoCabDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As PagoCheDevueltoCabDAO = CType(CreateDAOInstance(), PagoCheDevueltoCabDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this PagoCheDevueltoCabEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.PagoCheDevueltoCabEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="idPagoCheDevueltoCab">PK value for PagoCheDevueltoCab which data should be fetched into this PagoCheDevueltoCab Object</param>
		''' <param name="validator">The validator Object for this PagoCheDevueltoCabEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(idPagoCheDevueltoCab As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(idPagoCheDevueltoCab, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_pagoCheDevueltoDet = New Integralab.ORM.CollectionClasses.PagoCheDevueltoDetCollection(New PagoCheDevueltoDetEntityFactory())
			_pagoCheDevueltoDet.SetContainingEntityInfo(Me, "PagoCheDevueltoCab")
			_alwaysFetchPagoCheDevueltoDet = False
			_alreadyFetchedPagoCheDevueltoDet = False
			_chequeDevueltoCollectionViaPagoCheDevueltoDet = New Integralab.ORM.CollectionClasses.ChequeDevueltoCollection(New ChequeDevueltoEntityFactory())
			_alwaysFetchChequeDevueltoCollectionViaPagoCheDevueltoDet = False
			_alreadyFetchedChequeDevueltoCollectionViaPagoCheDevueltoDet = False
			_bancos = Nothing
			_bancosReturnsNewIfNotFound = True
			_alwaysFetchBancos = False
			_alreadyFetchedBancos = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdPagoCheDevueltoCab", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCaptura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaPago", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Saldo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Importe", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Referencia", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Folio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdBancoDeposito", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _bancos</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncBancos(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _bancos, AddressOf OnBancosPropertyChanged, "Bancos", PagoCheDevueltoCabEntity.Relations.BancosEntityUsingIdBancoDeposito, True, signalRelatedEntity, "PagoCheDevueltoCab", resetFKFields, New Integer() { CInt(PagoCheDevueltoCabFieldIndex.IdBancoDeposito) } )
			_bancos = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _bancos</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncBancos(relatedEntity As IEntity)
			DesetupSyncBancos(True, True)
			_bancos = CType(relatedEntity, BancosEntity)
			MyBase.PerformSetupSyncRelatedEntity( _bancos, AddressOf OnBancosPropertyChanged, "Bancos", PagoCheDevueltoCabEntity.Relations.BancosEntityUsingIdBancoDeposito, True, _alreadyFetchedBancos, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnBancosPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="idPagoCheDevueltoCab">PK value for PagoCheDevueltoCab which data should be fetched into this PagoCheDevueltoCab Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(idPagoCheDevueltoCab As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(PagoCheDevueltoCabFieldIndex.IdPagoCheDevueltoCab)).ForcedCurrentValueWrite(idPagoCheDevueltoCab)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreatePagoCheDevueltoCabDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New PagoCheDevueltoCabEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As PagoCheDevueltoCabRelations
			Get	
				Return New PagoCheDevueltoCabRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'PagoCheDevueltoDet' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPagoCheDevueltoDet() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PagoCheDevueltoDetCollection(), _
					PagoCheDevueltoCabEntity.Relations.PagoCheDevueltoDetEntityUsingIdPagoCheDevueltoCab, _
					CType(Integralab.ORM.EntityType.PagoCheDevueltoCabEntity, Integer), CType(Integralab.ORM.EntityType.PagoCheDevueltoDetEntity, Integer), 0, Nothing, Nothing, Nothing, "PagoCheDevueltoDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ChequeDevuelto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathChequeDevueltoCollectionViaPagoCheDevueltoDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PagoCheDevueltoCabEntity.Relations.PagoCheDevueltoDetEntityUsingIdPagoCheDevueltoCab, "__PagoCheDevueltoCabEntity__", String.Empty, JoinHint.None)
				relations.Add(PagoCheDevueltoDetEntity.Relations.ChequeDevueltoEntityUsingIdChequeDevuelto)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ChequeDevueltoCollection(), _
					PagoCheDevueltoCabEntity.Relations.PagoCheDevueltoDetEntityUsingIdPagoCheDevueltoCab, _
					CType(Integralab.ORM.EntityType.PagoCheDevueltoCabEntity, Integer), CType(Integralab.ORM.EntityType.ChequeDevueltoEntity, Integer), 0, Nothing, Nothing, relations, "ChequeDevueltoCollectionViaPagoCheDevueltoDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Bancos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathBancos() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.BancosCollection(), _
					PagoCheDevueltoCabEntity.Relations.BancosEntityUsingIdBancoDeposito, _
					CType(Integralab.ORM.EntityType.PagoCheDevueltoCabEntity, Integer), CType(Integralab.ORM.EntityType.BancosEntity, Integer), 0, Nothing, Nothing, Nothing, "Bancos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "PagoCheDevueltoCabEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return PagoCheDevueltoCabEntity.CustomProperties
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
				Return PagoCheDevueltoCabEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The IdPagoCheDevueltoCab property of the Entity PagoCheDevueltoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "PagoCheDevueltoCab"."IdPagoCheDevueltoCab"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [IdPagoCheDevueltoCab]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PagoCheDevueltoCabFieldIndex.IdPagoCheDevueltoCab, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(PagoCheDevueltoCabFieldIndex.IdPagoCheDevueltoCab, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCaptura property of the Entity PagoCheDevueltoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "PagoCheDevueltoCab"."FechaCaptura"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaCaptura]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PagoCheDevueltoCabFieldIndex.FechaCaptura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(PagoCheDevueltoCabFieldIndex.FechaCaptura, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaPago property of the Entity PagoCheDevueltoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "PagoCheDevueltoCab"."FechaPago"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaPago]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PagoCheDevueltoCabFieldIndex.FechaPago, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(PagoCheDevueltoCabFieldIndex.FechaPago, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCancelacion property of the Entity PagoCheDevueltoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "PagoCheDevueltoCab"."FechaCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaCancelacion]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PagoCheDevueltoCabFieldIndex.FechaCancelacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(PagoCheDevueltoCabFieldIndex.FechaCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The Saldo property of the Entity PagoCheDevueltoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "PagoCheDevueltoCab"."Saldo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Saldo]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PagoCheDevueltoCabFieldIndex.Saldo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(PagoCheDevueltoCabFieldIndex.Saldo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Importe property of the Entity PagoCheDevueltoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "PagoCheDevueltoCab"."Importe"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Importe]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PagoCheDevueltoCabFieldIndex.Importe, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(PagoCheDevueltoCabFieldIndex.Importe, Integer), value)
			End Set
		End Property
	
		''' <summary>The Referencia property of the Entity PagoCheDevueltoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "PagoCheDevueltoCab"."Referencia"<br/>
		''' Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 300<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Referencia]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PagoCheDevueltoCabFieldIndex.Referencia, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(PagoCheDevueltoCabFieldIndex.Referencia, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity PagoCheDevueltoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "PagoCheDevueltoCab"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Byte
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PagoCheDevueltoCabFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Byte))
				End If
				Return CType(valueToReturn, System.Byte)
			End Get
			Set
				SetNewFieldValue(CType(PagoCheDevueltoCabFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The Folio property of the Entity PagoCheDevueltoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "PagoCheDevueltoCab"."Folio"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 11<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Folio]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PagoCheDevueltoCabFieldIndex.Folio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(PagoCheDevueltoCabFieldIndex.Folio, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdBancoDeposito property of the Entity PagoCheDevueltoCab<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "PagoCheDevueltoCab"."IdBancoDeposito"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdBancoDeposito]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PagoCheDevueltoCabFieldIndex.IdBancoDeposito, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(PagoCheDevueltoCabFieldIndex.IdBancoDeposito, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'PagoCheDevueltoDetEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPagoCheDevueltoDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PagoCheDevueltoDet]() As Integralab.ORM.CollectionClasses.PagoCheDevueltoDetCollection
			Get
				Return GetMultiPagoCheDevueltoDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PagoCheDevueltoDet. When set to true, PagoCheDevueltoDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PagoCheDevueltoDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiPagoCheDevueltoDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPagoCheDevueltoDet As Boolean
			Get
				Return _alwaysFetchPagoCheDevueltoDet
			End Get
			Set
				_alwaysFetchPagoCheDevueltoDet = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'ChequeDevueltoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiChequeDevueltoCollectionViaPagoCheDevueltoDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ChequeDevueltoCollectionViaPagoCheDevueltoDet]() As Integralab.ORM.CollectionClasses.ChequeDevueltoCollection
			Get
				Return GetMultiChequeDevueltoCollectionViaPagoCheDevueltoDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ChequeDevueltoCollectionViaPagoCheDevueltoDet. When set to true, ChequeDevueltoCollectionViaPagoCheDevueltoDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ChequeDevueltoCollectionViaPagoCheDevueltoDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiChequeDevueltoCollectionViaPagoCheDevueltoDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchChequeDevueltoCollectionViaPagoCheDevueltoDet As Boolean
			Get
				Return _alwaysFetchChequeDevueltoCollectionViaPagoCheDevueltoDet
			End Get
			Set
				_alwaysFetchChequeDevueltoCollectionViaPagoCheDevueltoDet = value
			End Set	
		End Property
	
	
		''' <summary>Gets / sets related entity of type 'BancosEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleBancos()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Bancos]() As BancosEntity
			Get
				Return GetSingleBancos(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncBancos(value)
				Else
					If value Is Nothing Then
						If Not _bancos Is Nothing Then
							_bancos.UnsetRelatedEntity(Me, "PagoCheDevueltoCab")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "PagoCheDevueltoCab")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Bancos. When set to true, Bancos is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Bancos is accessed. You can always execute
		''' a forced fetch by calling GetSingleBancos(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchBancos As Boolean
			Get
				Return _alwaysFetchBancos
			End Get
			Set
				_alwaysFetchBancos = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Bancos is not found
		''' in the database. When set to true, Bancos will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property BancosReturnsNewIfNotFound As Boolean
			Get
				Return _bancosReturnsNewIfNotFound
			End Get
			Set
				_bancosReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.PagoCheDevueltoCabEntity)
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
