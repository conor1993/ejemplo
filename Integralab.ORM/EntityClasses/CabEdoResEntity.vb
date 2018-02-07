' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: miércoles, 7 de febrero de 2018 11:23:31
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
	''' <summary>Entity class which represents the entity 'CabEdoRes'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class CabEdoResEntity 
#Else
	<Serializable()> _
	Public Class CabEdoResEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _detEdoRes As Integralab.ORM.CollectionClasses.DetEdoResCollection
		Private _alwaysFetchDetEdoRes, _alreadyFetchedDetEdoRes As Boolean
		Private _cuentaContableCollectionViaDetEdoRes As Integralab.ORM.CollectionClasses.CuentaContableCollection
		Private _alwaysFetchCuentaContableCollectionViaDetEdoRes, _alreadyFetchedCuentaContableCollectionViaDetEdoRes As Boolean
		Private _catAgrupadoresBalGralEdoRes As CatAgrupadoresBalGralEdoResEntity
		Private _alwaysFetchCatAgrupadoresBalGralEdoRes, _alreadyFetchedCatAgrupadoresBalGralEdoRes, _catAgrupadoresBalGralEdoResReturnsNewIfNotFound As Boolean


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
		''' <param name="cveEdoRes">PK value for CabEdoRes which data should be fetched into this CabEdoRes Object</param>
		Public Sub New(cveEdoRes As System.String)

			InitClassFetch(cveEdoRes, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="cveEdoRes">PK value for CabEdoRes which data should be fetched into this CabEdoRes Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(cveEdoRes As System.String, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(cveEdoRes, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="cveEdoRes">PK value for CabEdoRes which data should be fetched into this CabEdoRes Object</param>
		''' <param name="validator">The custom validator Object for this CabEdoResEntity</param>
		Public Sub New(cveEdoRes As System.String, validator As IValidator)

			InitClassFetch(cveEdoRes, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_detEdoRes = CType(info.GetValue("_detEdoRes", GetType(Integralab.ORM.CollectionClasses.DetEdoResCollection)), Integralab.ORM.CollectionClasses.DetEdoResCollection)
			_alwaysFetchDetEdoRes = info.GetBoolean("_alwaysFetchDetEdoRes")
			_alreadyFetchedDetEdoRes = info.GetBoolean("_alreadyFetchedDetEdoRes")
			_cuentaContableCollectionViaDetEdoRes = CType(info.GetValue("_cuentaContableCollectionViaDetEdoRes", GetType(Integralab.ORM.CollectionClasses.CuentaContableCollection)), Integralab.ORM.CollectionClasses.CuentaContableCollection)
			_alwaysFetchCuentaContableCollectionViaDetEdoRes = info.GetBoolean("_alwaysFetchCuentaContableCollectionViaDetEdoRes")
			_alreadyFetchedCuentaContableCollectionViaDetEdoRes = info.GetBoolean("_alreadyFetchedCuentaContableCollectionViaDetEdoRes")
			_catAgrupadoresBalGralEdoRes = CType(info.GetValue("_catAgrupadoresBalGralEdoRes", GetType(CatAgrupadoresBalGralEdoResEntity)), CatAgrupadoresBalGralEdoResEntity)
			If Not _catAgrupadoresBalGralEdoRes Is Nothing Then
				AddHandler _catAgrupadoresBalGralEdoRes.AfterSave, AddressOf OnEntityAfterSave
			End If
			_catAgrupadoresBalGralEdoResReturnsNewIfNotFound = info.GetBoolean("_catAgrupadoresBalGralEdoResReturnsNewIfNotFound")
			_alwaysFetchCatAgrupadoresBalGralEdoRes = info.GetBoolean("_alwaysFetchCatAgrupadoresBalGralEdoRes")
			_alreadyFetchedCatAgrupadoresBalGralEdoRes = info.GetBoolean("_alreadyFetchedCatAgrupadoresBalGralEdoRes")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedDetEdoRes = (_detEdoRes.Count > 0)
			_alreadyFetchedCuentaContableCollectionViaDetEdoRes = (_cuentaContableCollectionViaDetEdoRes.Count > 0)
			_alreadyFetchedCatAgrupadoresBalGralEdoRes = Not(_catAgrupadoresBalGralEdoRes Is Nothing)

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
			info.AddValue("_detEdoRes", _detEdoRes)
			info.AddValue("_alwaysFetchDetEdoRes", _alwaysFetchDetEdoRes)
			info.AddValue("_alreadyFetchedDetEdoRes", _alreadyFetchedDetEdoRes)
			info.AddValue("_cuentaContableCollectionViaDetEdoRes", _cuentaContableCollectionViaDetEdoRes)
			info.AddValue("_alwaysFetchCuentaContableCollectionViaDetEdoRes", _alwaysFetchCuentaContableCollectionViaDetEdoRes)
			info.AddValue("_alreadyFetchedCuentaContableCollectionViaDetEdoRes", _alreadyFetchedCuentaContableCollectionViaDetEdoRes)
			info.AddValue("_catAgrupadoresBalGralEdoRes", _catAgrupadoresBalGralEdoRes)
			info.AddValue("_catAgrupadoresBalGralEdoResReturnsNewIfNotFound", _catAgrupadoresBalGralEdoResReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchCatAgrupadoresBalGralEdoRes", _alwaysFetchCatAgrupadoresBalGralEdoRes)
			info.AddValue("_alreadyFetchedCatAgrupadoresBalGralEdoRes", _alreadyFetchedCatAgrupadoresBalGralEdoRes)

			
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
				Case "CatAgrupadoresBalGralEdoRes"
					_alreadyFetchedCatAgrupadoresBalGralEdoRes = True
					Me.CatAgrupadoresBalGralEdoRes = CType(entity, CatAgrupadoresBalGralEdoResEntity)
				Case "DetEdoRes"
					_alreadyFetchedDetEdoRes = True
					If Not entity Is Nothing Then
						Me.DetEdoRes.Add(CType(entity, DetEdoResEntity))
					End If
				Case "CuentaContableCollectionViaDetEdoRes"
					_alreadyFetchedCuentaContableCollectionViaDetEdoRes = True
					If Not entity Is Nothing Then
						Me.CuentaContableCollectionViaDetEdoRes.Add(CType(entity, CuentaContableEntity))
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
				Case "CatAgrupadoresBalGralEdoRes"
					SetupSyncCatAgrupadoresBalGralEdoRes(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "DetEdoRes"
					_detEdoRes.Add(CType(relatedEntity, DetEdoResEntity))
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
				Case "CatAgrupadoresBalGralEdoRes"
					DesetupSyncCatAgrupadoresBalGralEdoRes(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "DetEdoRes"
					MyBase.PerformRelatedEntityRemoval(_detEdoRes, relatedEntity, signalRelatedEntityManyToOne)
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
			If Not _catAgrupadoresBalGralEdoRes Is Nothing Then
				toReturn.Add(_catAgrupadoresBalGralEdoRes)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_detEdoRes)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="cveEdoRes">PK value for CabEdoRes which data should be fetched into this CabEdoRes Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(cveEdoRes As System.String) As Boolean
			Return FetchUsingPK(cveEdoRes, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="cveEdoRes">PK value for CabEdoRes which data should be fetched into this CabEdoRes Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(cveEdoRes As System.String, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(cveEdoRes, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="cveEdoRes">PK value for CabEdoRes which data should be fetched into this CabEdoRes Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(cveEdoRes As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(cveEdoRes, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.CveEdoRes, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As CabEdoResFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As CabEdoResFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'DetEdoResEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'DetEdoResEntity'</returns>
		Public Function GetMultiDetEdoRes(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.DetEdoResCollection
			Return GetMultiDetEdoRes(forceFetch, _detEdoRes.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetEdoResEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiDetEdoRes(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.DetEdoResCollection
			Return GetMultiDetEdoRes(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetEdoResEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'DetEdoResEntity'</returns>
		Public Function GetMultiDetEdoRes(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetEdoResCollection
			Return GetMultiDetEdoRes(forceFetch, _detEdoRes.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'DetEdoResEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiDetEdoRes(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetEdoResCollection
			If ( Not _alreadyFetchedDetEdoRes Or forceFetch Or _alwaysFetchDetEdoRes) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _detEdoRes.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_detEdoRes)
					End If
				End If
				_detEdoRes.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_detEdoRes.EntityFactoryToUse = entityFactoryToUse
				End If
				_detEdoRes.GetMultiManyToOne(Me, Nothing, Filter)
				_detEdoRes.SuppressClearInGetMulti = False
				_alreadyFetchedDetEdoRes = True
			End If
			Return _detEdoRes
		End Function

		''' <summary>Sets the collection parameters for the collection for 'DetEdoRes'. These settings will be taken into account
		''' when the property DetEdoRes is requested or GetMultiDetEdoRes is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersDetEdoRes(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_detEdoRes.SortClauses=sortClauses
			_detEdoRes.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CuentaContableEntity'</returns>
		Public Function GetMultiCuentaContableCollectionViaDetEdoRes(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Return GetMultiCuentaContableCollectionViaDetEdoRes(forceFetch, _cuentaContableCollectionViaDetEdoRes.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCuentaContableCollectionViaDetEdoRes(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CuentaContableCollection
			If ( Not _alreadyFetchedCuentaContableCollectionViaDetEdoRes Or forceFetch Or _alwaysFetchCuentaContableCollectionViaDetEdoRes) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cuentaContableCollectionViaDetEdoRes.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cuentaContableCollectionViaDetEdoRes)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CabEdoResEntity.Relations.DetEdoResEntityUsingCveEdoRes, "__CabEdoResEntity__", "DetEdoRes_", JoinHint.None)
				relations.Add(DetEdoResEntity.Relations.CuentaContableEntityUsingCuentaContableId, "DetEdoRes_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CabEdoResFieldIndex.CveEdoRes), ComparisonOperator.Equal, Me.CveEdoRes))
				_cuentaContableCollectionViaDetEdoRes.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cuentaContableCollectionViaDetEdoRes.EntityFactoryToUse = entityFactoryToUse
				End If
				_cuentaContableCollectionViaDetEdoRes.GetMulti(Filter, relations)
				_cuentaContableCollectionViaDetEdoRes.SuppressClearInGetMulti = False
				_alreadyFetchedCuentaContableCollectionViaDetEdoRes = True
			End If
			Return _cuentaContableCollectionViaDetEdoRes
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CuentaContableCollectionViaDetEdoRes'. These settings will be taken into account
		''' when the property CuentaContableCollectionViaDetEdoRes is requested or GetMultiCuentaContableCollectionViaDetEdoRes is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCuentaContableCollectionViaDetEdoRes(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cuentaContableCollectionViaDetEdoRes.SortClauses=sortClauses
			_cuentaContableCollectionViaDetEdoRes.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves the related entity of type 'CatAgrupadoresBalGralEdoResEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'CatAgrupadoresBalGralEdoResEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCatAgrupadoresBalGralEdoRes() As CatAgrupadoresBalGralEdoResEntity
			Return GetSingleCatAgrupadoresBalGralEdoRes(False)
		End Function

		''' <summary>Retrieves the related entity of type 'CatAgrupadoresBalGralEdoResEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'CatAgrupadoresBalGralEdoResEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCatAgrupadoresBalGralEdoRes(forceFetch As Boolean) As CatAgrupadoresBalGralEdoResEntity
			If ( Not _alreadyFetchedCatAgrupadoresBalGralEdoRes Or forceFetch Or _alwaysFetchCatAgrupadoresBalGralEdoRes) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New CatAgrupadoresBalGralEdoResEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(CabEdoResEntity.Relations.CatAgrupadoresBalGralEdoResEntityUsingIdAgrupador) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdAgrupador.GetValueOrDefault())
				End If
				If Not _catAgrupadoresBalGralEdoResReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.CatAgrupadoresBalGralEdoRes = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), CatAgrupadoresBalGralEdoResEntity)
					End If
					Me.CatAgrupadoresBalGralEdoRes = newEntity
					_alreadyFetchedCatAgrupadoresBalGralEdoRes = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _catAgrupadoresBalGralEdoRes
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(CabEdoResFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, CabEdoResFieldIndex)




					Case CabEdoResFieldIndex.IdAgrupador
						DesetupSyncCatAgrupadoresBalGralEdoRes(True, False)
						_alreadyFetchedCatAgrupadoresBalGralEdoRes = False
					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_detEdoRes.ActiveContext = MyBase.ActiveContext
			_cuentaContableCollectionViaDetEdoRes.ActiveContext = MyBase.ActiveContext
		If Not _catAgrupadoresBalGralEdoRes Is Nothing Then
				_catAgrupadoresBalGralEdoRes.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As CabEdoResDAO = CType(CreateDAOInstance(), CabEdoResDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As CabEdoResDAO = CType(CreateDAOInstance(), CabEdoResDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As CabEdoResDAO = CType(CreateDAOInstance(), CabEdoResDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this CabEdoResEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CabEdoResEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="cveEdoRes">PK value for CabEdoRes which data should be fetched into this CabEdoRes Object</param>
		''' <param name="validator">The validator Object for this CabEdoResEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(cveEdoRes As System.String, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(cveEdoRes, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_detEdoRes = New Integralab.ORM.CollectionClasses.DetEdoResCollection(New DetEdoResEntityFactory())
			_detEdoRes.SetContainingEntityInfo(Me, "CabEdoRes")
			_alwaysFetchDetEdoRes = False
			_alreadyFetchedDetEdoRes = False
			_cuentaContableCollectionViaDetEdoRes = New Integralab.ORM.CollectionClasses.CuentaContableCollection(New CuentaContableEntityFactory())
			_alwaysFetchCuentaContableCollectionViaDetEdoRes = False
			_alreadyFetchedCuentaContableCollectionViaDetEdoRes = False
			_catAgrupadoresBalGralEdoRes = Nothing
			_catAgrupadoresBalGralEdoResReturnsNewIfNotFound = True
			_alwaysFetchCatAgrupadoresBalGralEdoRes = False
			_alreadyFetchedCatAgrupadoresBalGralEdoRes = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CveEdoRes", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("NomEdoRes", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SaldoMes", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SaldoAcum", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdAgrupador", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _catAgrupadoresBalGralEdoRes</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncCatAgrupadoresBalGralEdoRes(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _catAgrupadoresBalGralEdoRes, AddressOf OnCatAgrupadoresBalGralEdoResPropertyChanged, "CatAgrupadoresBalGralEdoRes", CabEdoResEntity.Relations.CatAgrupadoresBalGralEdoResEntityUsingIdAgrupador, True, signalRelatedEntity, "CabEdoRes", resetFKFields, New Integer() { CInt(CabEdoResFieldIndex.IdAgrupador) } )
			_catAgrupadoresBalGralEdoRes = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _catAgrupadoresBalGralEdoRes</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncCatAgrupadoresBalGralEdoRes(relatedEntity As IEntity)
			DesetupSyncCatAgrupadoresBalGralEdoRes(True, True)
			_catAgrupadoresBalGralEdoRes = CType(relatedEntity, CatAgrupadoresBalGralEdoResEntity)
			MyBase.PerformSetupSyncRelatedEntity( _catAgrupadoresBalGralEdoRes, AddressOf OnCatAgrupadoresBalGralEdoResPropertyChanged, "CatAgrupadoresBalGralEdoRes", CabEdoResEntity.Relations.CatAgrupadoresBalGralEdoResEntityUsingIdAgrupador, True, _alreadyFetchedCatAgrupadoresBalGralEdoRes, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnCatAgrupadoresBalGralEdoResPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="cveEdoRes">PK value for CabEdoRes which data should be fetched into this CabEdoRes Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(cveEdoRes As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(CabEdoResFieldIndex.CveEdoRes)).ForcedCurrentValueWrite(cveEdoRes)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateCabEdoResDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New CabEdoResEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As CabEdoResRelations
			Get	
				Return New CabEdoResRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DetEdoRes' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDetEdoRes() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DetEdoResCollection(), _
					CabEdoResEntity.Relations.DetEdoResEntityUsingCveEdoRes, _
					CType(Integralab.ORM.EntityType.CabEdoResEntity, Integer), CType(Integralab.ORM.EntityType.DetEdoResEntity, Integer), 0, Nothing, Nothing, Nothing, "DetEdoRes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CuentaContable' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaContableCollectionViaDetEdoRes() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CabEdoResEntity.Relations.DetEdoResEntityUsingCveEdoRes, "__CabEdoResEntity__", String.Empty, JoinHint.None)
				relations.Add(DetEdoResEntity.Relations.CuentaContableEntityUsingCuentaContableId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaContableCollection(), _
					CabEdoResEntity.Relations.DetEdoResEntityUsingCveEdoRes, _
					CType(Integralab.ORM.EntityType.CabEdoResEntity, Integer), CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), 0, Nothing, Nothing, relations, "CuentaContableCollectionViaDetEdoRes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CatAgrupadoresBalGralEdoRes' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCatAgrupadoresBalGralEdoRes() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CatAgrupadoresBalGralEdoResCollection(), _
					CabEdoResEntity.Relations.CatAgrupadoresBalGralEdoResEntityUsingIdAgrupador, _
					CType(Integralab.ORM.EntityType.CabEdoResEntity, Integer), CType(Integralab.ORM.EntityType.CatAgrupadoresBalGralEdoResEntity, Integer), 0, Nothing, Nothing, Nothing, "CatAgrupadoresBalGralEdoRes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "CabEdoResEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return CabEdoResEntity.CustomProperties
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
				Return CabEdoResEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The CveEdoRes property of the Entity CabEdoRes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabEdoRes"."Cve_EdoRes"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 3<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [CveEdoRes]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabEdoResFieldIndex.CveEdoRes, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabEdoResFieldIndex.CveEdoRes, Integer), value)
			End Set
		End Property
	
		''' <summary>The NomEdoRes property of the Entity CabEdoRes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabEdoRes"."Nom_EdoRes"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [NomEdoRes]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabEdoResFieldIndex.NomEdoRes, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CabEdoResFieldIndex.NomEdoRes, Integer), value)
			End Set
		End Property
	
		''' <summary>The SaldoMes property of the Entity CabEdoRes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabEdoRes"."SaldoMes"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SaldoMes]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabEdoResFieldIndex.SaldoMes, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CabEdoResFieldIndex.SaldoMes, Integer), value)
			End Set
		End Property
	
		''' <summary>The SaldoAcum property of the Entity CabEdoRes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabEdoRes"."SaldoAcum"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SaldoAcum]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabEdoResFieldIndex.SaldoAcum, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CabEdoResFieldIndex.SaldoAcum, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdAgrupador property of the Entity CabEdoRes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CabEdoRes"."IdAgrupador"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdAgrupador]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CabEdoResFieldIndex.IdAgrupador, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(CabEdoResFieldIndex.IdAgrupador, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'DetEdoResEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDetEdoRes()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [DetEdoRes]() As Integralab.ORM.CollectionClasses.DetEdoResCollection
			Get
				Return GetMultiDetEdoRes(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for DetEdoRes. When set to true, DetEdoRes is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time DetEdoRes is accessed. You can always execute
		''' a forced fetch by calling GetMultiDetEdoRes(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchDetEdoRes As Boolean
			Get
				Return _alwaysFetchDetEdoRes
			End Get
			Set
				_alwaysFetchDetEdoRes = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'CuentaContableEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCuentaContableCollectionViaDetEdoRes()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CuentaContableCollectionViaDetEdoRes]() As Integralab.ORM.CollectionClasses.CuentaContableCollection
			Get
				Return GetMultiCuentaContableCollectionViaDetEdoRes(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentaContableCollectionViaDetEdoRes. When set to true, CuentaContableCollectionViaDetEdoRes is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentaContableCollectionViaDetEdoRes is accessed. You can always execute
		''' a forced fetch by calling GetMultiCuentaContableCollectionViaDetEdoRes(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentaContableCollectionViaDetEdoRes As Boolean
			Get
				Return _alwaysFetchCuentaContableCollectionViaDetEdoRes
			End Get
			Set
				_alwaysFetchCuentaContableCollectionViaDetEdoRes = value
			End Set	
		End Property
	
	
		''' <summary>Gets / sets related entity of type 'CatAgrupadoresBalGralEdoResEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCatAgrupadoresBalGralEdoRes()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [CatAgrupadoresBalGralEdoRes]() As CatAgrupadoresBalGralEdoResEntity
			Get
				Return GetSingleCatAgrupadoresBalGralEdoRes(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncCatAgrupadoresBalGralEdoRes(value)
				Else
					If value Is Nothing Then
						If Not _catAgrupadoresBalGralEdoRes Is Nothing Then
							_catAgrupadoresBalGralEdoRes.UnsetRelatedEntity(Me, "CabEdoRes")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "CabEdoRes")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for CatAgrupadoresBalGralEdoRes. When set to true, CatAgrupadoresBalGralEdoRes is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CatAgrupadoresBalGralEdoRes is accessed. You can always execute
		''' a forced fetch by calling GetSingleCatAgrupadoresBalGralEdoRes(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCatAgrupadoresBalGralEdoRes As Boolean
			Get
				Return _alwaysFetchCatAgrupadoresBalGralEdoRes
			End Get
			Set
				_alwaysFetchCatAgrupadoresBalGralEdoRes = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property CatAgrupadoresBalGralEdoRes is not found
		''' in the database. When set to true, CatAgrupadoresBalGralEdoRes will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property CatAgrupadoresBalGralEdoResReturnsNewIfNotFound As Boolean
			Get
				Return _catAgrupadoresBalGralEdoResReturnsNewIfNotFound
			End Get
			Set
				_catAgrupadoresBalGralEdoResReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.CabEdoResEntity)
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
