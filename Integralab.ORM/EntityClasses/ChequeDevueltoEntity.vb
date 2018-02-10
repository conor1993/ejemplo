' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 9 de febrero de 2018 17:51:10
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
	''' <summary>Entity class which represents the entity 'ChequeDevuelto'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class ChequeDevueltoEntity 
#Else
	<Serializable()> _
	Public Class ChequeDevueltoEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _pagoCheDevueltoDet As Integralab.ORM.CollectionClasses.PagoCheDevueltoDetCollection
		Private _alwaysFetchPagoCheDevueltoDet, _alreadyFetchedPagoCheDevueltoDet As Boolean
		Private _pagoCheDevueltoCabCollectionViaPagoCheDevueltoDet As Integralab.ORM.CollectionClasses.PagoCheDevueltoCabCollection
		Private _alwaysFetchPagoCheDevueltoCabCollectionViaPagoCheDevueltoDet, _alreadyFetchedPagoCheDevueltoCabCollectionViaPagoCheDevueltoDet As Boolean
		Private _bancos As BancosEntity
		Private _alwaysFetchBancos, _alreadyFetchedBancos, _bancosReturnsNewIfNotFound As Boolean
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
		''' <param name="idChequeDevuelto">PK value for ChequeDevuelto which data should be fetched into this ChequeDevuelto Object</param>
		Public Sub New(idChequeDevuelto As System.Int32)

			InitClassFetch(idChequeDevuelto, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idChequeDevuelto">PK value for ChequeDevuelto which data should be fetched into this ChequeDevuelto Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(idChequeDevuelto As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(idChequeDevuelto, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idChequeDevuelto">PK value for ChequeDevuelto which data should be fetched into this ChequeDevuelto Object</param>
		''' <param name="validator">The custom validator Object for this ChequeDevueltoEntity</param>
		Public Sub New(idChequeDevuelto As System.Int32, validator As IValidator)

			InitClassFetch(idChequeDevuelto, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_pagoCheDevueltoDet = CType(info.GetValue("_pagoCheDevueltoDet", GetType(Integralab.ORM.CollectionClasses.PagoCheDevueltoDetCollection)), Integralab.ORM.CollectionClasses.PagoCheDevueltoDetCollection)
			_alwaysFetchPagoCheDevueltoDet = info.GetBoolean("_alwaysFetchPagoCheDevueltoDet")
			_alreadyFetchedPagoCheDevueltoDet = info.GetBoolean("_alreadyFetchedPagoCheDevueltoDet")
			_pagoCheDevueltoCabCollectionViaPagoCheDevueltoDet = CType(info.GetValue("_pagoCheDevueltoCabCollectionViaPagoCheDevueltoDet", GetType(Integralab.ORM.CollectionClasses.PagoCheDevueltoCabCollection)), Integralab.ORM.CollectionClasses.PagoCheDevueltoCabCollection)
			_alwaysFetchPagoCheDevueltoCabCollectionViaPagoCheDevueltoDet = info.GetBoolean("_alwaysFetchPagoCheDevueltoCabCollectionViaPagoCheDevueltoDet")
			_alreadyFetchedPagoCheDevueltoCabCollectionViaPagoCheDevueltoDet = info.GetBoolean("_alreadyFetchedPagoCheDevueltoCabCollectionViaPagoCheDevueltoDet")
			_bancos = CType(info.GetValue("_bancos", GetType(BancosEntity)), BancosEntity)
			If Not _bancos Is Nothing Then
				AddHandler _bancos.AfterSave, AddressOf OnEntityAfterSave
			End If
			_bancosReturnsNewIfNotFound = info.GetBoolean("_bancosReturnsNewIfNotFound")
			_alwaysFetchBancos = info.GetBoolean("_alwaysFetchBancos")
			_alreadyFetchedBancos = info.GetBoolean("_alreadyFetchedBancos")
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
			_alreadyFetchedPagoCheDevueltoDet = (_pagoCheDevueltoDet.Count > 0)
			_alreadyFetchedPagoCheDevueltoCabCollectionViaPagoCheDevueltoDet = (_pagoCheDevueltoCabCollectionViaPagoCheDevueltoDet.Count > 0)
			_alreadyFetchedBancos = Not(_bancos Is Nothing)
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
			info.AddValue("_pagoCheDevueltoDet", _pagoCheDevueltoDet)
			info.AddValue("_alwaysFetchPagoCheDevueltoDet", _alwaysFetchPagoCheDevueltoDet)
			info.AddValue("_alreadyFetchedPagoCheDevueltoDet", _alreadyFetchedPagoCheDevueltoDet)
			info.AddValue("_pagoCheDevueltoCabCollectionViaPagoCheDevueltoDet", _pagoCheDevueltoCabCollectionViaPagoCheDevueltoDet)
			info.AddValue("_alwaysFetchPagoCheDevueltoCabCollectionViaPagoCheDevueltoDet", _alwaysFetchPagoCheDevueltoCabCollectionViaPagoCheDevueltoDet)
			info.AddValue("_alreadyFetchedPagoCheDevueltoCabCollectionViaPagoCheDevueltoDet", _alreadyFetchedPagoCheDevueltoCabCollectionViaPagoCheDevueltoDet)
			info.AddValue("_bancos", _bancos)
			info.AddValue("_bancosReturnsNewIfNotFound", _bancosReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchBancos", _alwaysFetchBancos)
			info.AddValue("_alreadyFetchedBancos", _alreadyFetchedBancos)
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
				Case "Bancos"
					_alreadyFetchedBancos = True
					Me.Bancos = CType(entity, BancosEntity)
				Case "MfacCatClientes"
					_alreadyFetchedMfacCatClientes = True
					Me.MfacCatClientes = CType(entity, MfacCatClientesEntity)
				Case "PagoCheDevueltoDet"
					_alreadyFetchedPagoCheDevueltoDet = True
					If Not entity Is Nothing Then
						Me.PagoCheDevueltoDet.Add(CType(entity, PagoCheDevueltoDetEntity))
					End If
				Case "PagoCheDevueltoCabCollectionViaPagoCheDevueltoDet"
					_alreadyFetchedPagoCheDevueltoCabCollectionViaPagoCheDevueltoDet = True
					If Not entity Is Nothing Then
						Me.PagoCheDevueltoCabCollectionViaPagoCheDevueltoDet.Add(CType(entity, PagoCheDevueltoCabEntity))
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
				Case "MfacCatClientes"
					SetupSyncMfacCatClientes(relatedEntity)
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
				Case "MfacCatClientes"
					DesetupSyncMfacCatClientes(False, True)
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
			toReturn.Add(_pagoCheDevueltoDet)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idChequeDevuelto">PK value for ChequeDevuelto which data should be fetched into this ChequeDevuelto Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idChequeDevuelto As System.Int32) As Boolean
			Return FetchUsingPK(idChequeDevuelto, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idChequeDevuelto">PK value for ChequeDevuelto which data should be fetched into this ChequeDevuelto Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idChequeDevuelto As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(idChequeDevuelto, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idChequeDevuelto">PK value for ChequeDevuelto which data should be fetched into this ChequeDevuelto Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idChequeDevuelto As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(idChequeDevuelto, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.IdChequeDevuelto, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As ChequeDevueltoFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As ChequeDevueltoFieldIndex) As Boolean
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
				_pagoCheDevueltoDet.GetMultiManyToOne(Me, Nothing, Filter)
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
	
	
		''' <summary>Retrieves all related entities of type 'PagoCheDevueltoCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PagoCheDevueltoCabEntity'</returns>
		Public Function GetMultiPagoCheDevueltoCabCollectionViaPagoCheDevueltoDet(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PagoCheDevueltoCabCollection
			Return GetMultiPagoCheDevueltoCabCollectionViaPagoCheDevueltoDet(forceFetch, _pagoCheDevueltoCabCollectionViaPagoCheDevueltoDet.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'PagoCheDevueltoCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPagoCheDevueltoCabCollectionViaPagoCheDevueltoDet(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PagoCheDevueltoCabCollection
			If ( Not _alreadyFetchedPagoCheDevueltoCabCollectionViaPagoCheDevueltoDet Or forceFetch Or _alwaysFetchPagoCheDevueltoCabCollectionViaPagoCheDevueltoDet) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _pagoCheDevueltoCabCollectionViaPagoCheDevueltoDet.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_pagoCheDevueltoCabCollectionViaPagoCheDevueltoDet)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ChequeDevueltoEntity.Relations.PagoCheDevueltoDetEntityUsingIdChequeDevuelto, "__ChequeDevueltoEntity__", "PagoCheDevueltoDet_", JoinHint.None)
				relations.Add(PagoCheDevueltoDetEntity.Relations.PagoCheDevueltoCabEntityUsingIdPagoCheDevueltoCab, "PagoCheDevueltoDet_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ChequeDevueltoFieldIndex.IdChequeDevuelto), ComparisonOperator.Equal, Me.IdChequeDevuelto))
				_pagoCheDevueltoCabCollectionViaPagoCheDevueltoDet.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_pagoCheDevueltoCabCollectionViaPagoCheDevueltoDet.EntityFactoryToUse = entityFactoryToUse
				End If
				_pagoCheDevueltoCabCollectionViaPagoCheDevueltoDet.GetMulti(Filter, relations)
				_pagoCheDevueltoCabCollectionViaPagoCheDevueltoDet.SuppressClearInGetMulti = False
				_alreadyFetchedPagoCheDevueltoCabCollectionViaPagoCheDevueltoDet = True
			End If
			Return _pagoCheDevueltoCabCollectionViaPagoCheDevueltoDet
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PagoCheDevueltoCabCollectionViaPagoCheDevueltoDet'. These settings will be taken into account
		''' when the property PagoCheDevueltoCabCollectionViaPagoCheDevueltoDet is requested or GetMultiPagoCheDevueltoCabCollectionViaPagoCheDevueltoDet is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPagoCheDevueltoCabCollectionViaPagoCheDevueltoDet(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_pagoCheDevueltoCabCollectionViaPagoCheDevueltoDet.SortClauses=sortClauses
			_pagoCheDevueltoCabCollectionViaPagoCheDevueltoDet.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				If MyBase.CheckIfLazyLoadingShouldOccur(ChequeDevueltoEntity.Relations.BancosEntityUsingIdBanco) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdBanco)
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
				If MyBase.CheckIfLazyLoadingShouldOccur(ChequeDevueltoEntity.Relations.MfacCatClientesEntityUsingIdCliente) Then
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(ChequeDevueltoFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, ChequeDevueltoFieldIndex)


					Case ChequeDevueltoFieldIndex.IdBanco
						DesetupSyncBancos(True, False)
						_alreadyFetchedBancos = False
					Case ChequeDevueltoFieldIndex.IdCliente
						DesetupSyncMfacCatClientes(True, False)
						_alreadyFetchedMfacCatClientes = False






					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_pagoCheDevueltoDet.ActiveContext = MyBase.ActiveContext
			_pagoCheDevueltoCabCollectionViaPagoCheDevueltoDet.ActiveContext = MyBase.ActiveContext
		If Not _bancos Is Nothing Then
				_bancos.ActiveContext = MyBase.ActiveContext
			End If
		If Not _mfacCatClientes Is Nothing Then
				_mfacCatClientes.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As ChequeDevueltoDAO = CType(CreateDAOInstance(), ChequeDevueltoDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As ChequeDevueltoDAO = CType(CreateDAOInstance(), ChequeDevueltoDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As ChequeDevueltoDAO = CType(CreateDAOInstance(), ChequeDevueltoDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this ChequeDevueltoEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ChequeDevueltoEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="idChequeDevuelto">PK value for ChequeDevuelto which data should be fetched into this ChequeDevuelto Object</param>
		''' <param name="validator">The validator Object for this ChequeDevueltoEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(idChequeDevuelto As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(idChequeDevuelto, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_pagoCheDevueltoDet = New Integralab.ORM.CollectionClasses.PagoCheDevueltoDetCollection(New PagoCheDevueltoDetEntityFactory())
			_pagoCheDevueltoDet.SetContainingEntityInfo(Me, "ChequeDevuelto")
			_alwaysFetchPagoCheDevueltoDet = False
			_alreadyFetchedPagoCheDevueltoDet = False
			_pagoCheDevueltoCabCollectionViaPagoCheDevueltoDet = New Integralab.ORM.CollectionClasses.PagoCheDevueltoCabCollection(New PagoCheDevueltoCabEntityFactory())
			_alwaysFetchPagoCheDevueltoCabCollectionViaPagoCheDevueltoDet = False
			_alreadyFetchedPagoCheDevueltoCabCollectionViaPagoCheDevueltoDet = False
			_bancos = Nothing
			_bancosReturnsNewIfNotFound = True
			_alwaysFetchBancos = False
			_alreadyFetchedBancos = False
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

			_fieldsCustomProperties.Add("IdChequeDevuelto", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("NoCheque", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdBanco", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdCliente", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCaptura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaDevolucion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Recibio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Observaciones", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Importe", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _bancos</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncBancos(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _bancos, AddressOf OnBancosPropertyChanged, "Bancos", ChequeDevueltoEntity.Relations.BancosEntityUsingIdBanco, True, signalRelatedEntity, "ChequeDevuelto", resetFKFields, New Integer() { CInt(ChequeDevueltoFieldIndex.IdBanco) } )
			_bancos = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _bancos</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncBancos(relatedEntity As IEntity)
			DesetupSyncBancos(True, True)
			_bancos = CType(relatedEntity, BancosEntity)
			MyBase.PerformSetupSyncRelatedEntity( _bancos, AddressOf OnBancosPropertyChanged, "Bancos", ChequeDevueltoEntity.Relations.BancosEntityUsingIdBanco, True, _alreadyFetchedBancos, New String() {  } )
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
		''' <summary>Removes the sync logic for member _mfacCatClientes</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMfacCatClientes(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _mfacCatClientes, AddressOf OnMfacCatClientesPropertyChanged, "MfacCatClientes", ChequeDevueltoEntity.Relations.MfacCatClientesEntityUsingIdCliente, True, signalRelatedEntity, "ChequeDevuelto", resetFKFields, New Integer() { CInt(ChequeDevueltoFieldIndex.IdCliente) } )
			_mfacCatClientes = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _mfacCatClientes</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMfacCatClientes(relatedEntity As IEntity)
			DesetupSyncMfacCatClientes(True, True)
			_mfacCatClientes = CType(relatedEntity, MfacCatClientesEntity)
			MyBase.PerformSetupSyncRelatedEntity( _mfacCatClientes, AddressOf OnMfacCatClientesPropertyChanged, "MfacCatClientes", ChequeDevueltoEntity.Relations.MfacCatClientesEntityUsingIdCliente, True, _alreadyFetchedMfacCatClientes, New String() {  } )
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
		''' <param name="idChequeDevuelto">PK value for ChequeDevuelto which data should be fetched into this ChequeDevuelto Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(idChequeDevuelto As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(ChequeDevueltoFieldIndex.IdChequeDevuelto)).ForcedCurrentValueWrite(idChequeDevuelto)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateChequeDevueltoDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New ChequeDevueltoEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As ChequeDevueltoRelations
			Get	
				Return New ChequeDevueltoRelations() 
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
					ChequeDevueltoEntity.Relations.PagoCheDevueltoDetEntityUsingIdChequeDevuelto, _
					CType(Integralab.ORM.EntityType.ChequeDevueltoEntity, Integer), CType(Integralab.ORM.EntityType.PagoCheDevueltoDetEntity, Integer), 0, Nothing, Nothing, Nothing, "PagoCheDevueltoDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'PagoCheDevueltoCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPagoCheDevueltoCabCollectionViaPagoCheDevueltoDet() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ChequeDevueltoEntity.Relations.PagoCheDevueltoDetEntityUsingIdChequeDevuelto, "__ChequeDevueltoEntity__", String.Empty, JoinHint.None)
				relations.Add(PagoCheDevueltoDetEntity.Relations.PagoCheDevueltoCabEntityUsingIdPagoCheDevueltoCab)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PagoCheDevueltoCabCollection(), _
					ChequeDevueltoEntity.Relations.PagoCheDevueltoDetEntityUsingIdChequeDevuelto, _
					CType(Integralab.ORM.EntityType.ChequeDevueltoEntity, Integer), CType(Integralab.ORM.EntityType.PagoCheDevueltoCabEntity, Integer), 0, Nothing, Nothing, relations, "PagoCheDevueltoCabCollectionViaPagoCheDevueltoDet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Bancos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathBancos() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.BancosCollection(), _
					ChequeDevueltoEntity.Relations.BancosEntityUsingIdBanco, _
					CType(Integralab.ORM.EntityType.ChequeDevueltoEntity, Integer), CType(Integralab.ORM.EntityType.BancosEntity, Integer), 0, Nothing, Nothing, Nothing, "Bancos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MfacCatClientes' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMfacCatClientes() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MfacCatClientesCollection(), _
					ChequeDevueltoEntity.Relations.MfacCatClientesEntityUsingIdCliente, _
					CType(Integralab.ORM.EntityType.ChequeDevueltoEntity, Integer), CType(Integralab.ORM.EntityType.MfacCatClientesEntity, Integer), 0, Nothing, Nothing, Nothing, "MfacCatClientes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "ChequeDevueltoEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return ChequeDevueltoEntity.CustomProperties
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
				Return ChequeDevueltoEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The IdChequeDevuelto property of the Entity ChequeDevuelto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ChequeDevuelto"."IdChequeDevuelto"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [IdChequeDevuelto]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ChequeDevueltoFieldIndex.IdChequeDevuelto, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ChequeDevueltoFieldIndex.IdChequeDevuelto, Integer), value)
			End Set
		End Property
	
		''' <summary>The NoCheque property of the Entity ChequeDevuelto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ChequeDevuelto"."NoCheque"<br/>
		''' Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [NoCheque]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ChequeDevueltoFieldIndex.NoCheque, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ChequeDevueltoFieldIndex.NoCheque, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdBanco property of the Entity ChequeDevuelto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ChequeDevuelto"."IdBanco"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdBanco]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ChequeDevueltoFieldIndex.IdBanco, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ChequeDevueltoFieldIndex.IdBanco, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdCliente property of the Entity ChequeDevuelto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ChequeDevuelto"."IdCliente"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdCliente]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ChequeDevueltoFieldIndex.IdCliente, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ChequeDevueltoFieldIndex.IdCliente, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCaptura property of the Entity ChequeDevuelto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ChequeDevuelto"."FechaCaptura"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaCaptura]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ChequeDevueltoFieldIndex.FechaCaptura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(ChequeDevueltoFieldIndex.FechaCaptura, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaDevolucion property of the Entity ChequeDevuelto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ChequeDevuelto"."FechaDevolucion"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaDevolucion]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ChequeDevueltoFieldIndex.FechaDevolucion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(ChequeDevueltoFieldIndex.FechaDevolucion, Integer), value)
			End Set
		End Property
	
		''' <summary>The Recibio property of the Entity ChequeDevuelto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ChequeDevuelto"."Recibio"<br/>
		''' Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Recibio]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ChequeDevueltoFieldIndex.Recibio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ChequeDevueltoFieldIndex.Recibio, Integer), value)
			End Set
		End Property
	
		''' <summary>The Observaciones property of the Entity ChequeDevuelto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ChequeDevuelto"."Observaciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 300<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Observaciones]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ChequeDevueltoFieldIndex.Observaciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ChequeDevueltoFieldIndex.Observaciones, Integer), value)
			End Set
		End Property
	
		''' <summary>The Importe property of the Entity ChequeDevuelto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ChequeDevuelto"."Importe"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Importe]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ChequeDevueltoFieldIndex.Importe, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(ChequeDevueltoFieldIndex.Importe, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity ChequeDevuelto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "ChequeDevuelto"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Byte
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ChequeDevueltoFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Byte))
				End If
				Return CType(valueToReturn, System.Byte)
			End Get
			Set
				SetNewFieldValue(CType(ChequeDevueltoFieldIndex.Estatus, Integer), value)
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
	
	
		''' <summary>Retrieves all related entities of type 'PagoCheDevueltoCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPagoCheDevueltoCabCollectionViaPagoCheDevueltoDet()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PagoCheDevueltoCabCollectionViaPagoCheDevueltoDet]() As Integralab.ORM.CollectionClasses.PagoCheDevueltoCabCollection
			Get
				Return GetMultiPagoCheDevueltoCabCollectionViaPagoCheDevueltoDet(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PagoCheDevueltoCabCollectionViaPagoCheDevueltoDet. When set to true, PagoCheDevueltoCabCollectionViaPagoCheDevueltoDet is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PagoCheDevueltoCabCollectionViaPagoCheDevueltoDet is accessed. You can always execute
		''' a forced fetch by calling GetMultiPagoCheDevueltoCabCollectionViaPagoCheDevueltoDet(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPagoCheDevueltoCabCollectionViaPagoCheDevueltoDet As Boolean
			Get
				Return _alwaysFetchPagoCheDevueltoCabCollectionViaPagoCheDevueltoDet
			End Get
			Set
				_alwaysFetchPagoCheDevueltoCabCollectionViaPagoCheDevueltoDet = value
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
							_bancos.UnsetRelatedEntity(Me, "ChequeDevuelto")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "ChequeDevuelto")
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
							_mfacCatClientes.UnsetRelatedEntity(Me, "ChequeDevuelto")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "ChequeDevuelto")
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
				Return CInt(Integralab.ORM.EntityType.ChequeDevueltoEntity)
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
