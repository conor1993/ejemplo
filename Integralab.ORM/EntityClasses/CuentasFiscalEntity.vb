' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 2 de marzo de 2018 16:12:39
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
	''' <summary>Entity class which represents the entity 'CuentasFiscal'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class CuentasFiscalEntity 
#Else
	<Serializable()> _
	Public Class CuentasFiscalEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _cuentasHijas As Integralab.ORM.CollectionClasses.CuentasFiscalCollection
		Private _alwaysFetchCuentasHijas, _alreadyFetchedCuentasHijas As Boolean

		Private _cuentaPadre As CuentasFiscalEntity
		Private _alwaysFetchCuentaPadre, _alreadyFetchedCuentaPadre, _cuentaPadreReturnsNewIfNotFound As Boolean


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
		''' <param name="codigo">PK value for CuentasFiscal which data should be fetched into this CuentasFiscal Object</param>
		Public Sub New(codigo As System.Int32)

			InitClassFetch(codigo, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for CuentasFiscal which data should be fetched into this CuentasFiscal Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(codigo As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(codigo, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for CuentasFiscal which data should be fetched into this CuentasFiscal Object</param>
		''' <param name="validator">The custom validator Object for this CuentasFiscalEntity</param>
		Public Sub New(codigo As System.Int32, validator As IValidator)

			InitClassFetch(codigo, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_cuentasHijas = CType(info.GetValue("_cuentasHijas", GetType(Integralab.ORM.CollectionClasses.CuentasFiscalCollection)), Integralab.ORM.CollectionClasses.CuentasFiscalCollection)
			_alwaysFetchCuentasHijas = info.GetBoolean("_alwaysFetchCuentasHijas")
			_alreadyFetchedCuentasHijas = info.GetBoolean("_alreadyFetchedCuentasHijas")

			_cuentaPadre = CType(info.GetValue("_cuentaPadre", GetType(CuentasFiscalEntity)), CuentasFiscalEntity)
			If Not _cuentaPadre Is Nothing Then
				AddHandler _cuentaPadre.AfterSave, AddressOf OnEntityAfterSave
			End If
			_cuentaPadreReturnsNewIfNotFound = info.GetBoolean("_cuentaPadreReturnsNewIfNotFound")
			_alwaysFetchCuentaPadre = info.GetBoolean("_alwaysFetchCuentaPadre")
			_alreadyFetchedCuentaPadre = info.GetBoolean("_alreadyFetchedCuentaPadre")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedCuentasHijas = (_cuentasHijas.Count > 0)

			_alreadyFetchedCuentaPadre = Not(_cuentaPadre Is Nothing)

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
			info.AddValue("_cuentasHijas", _cuentasHijas)
			info.AddValue("_alwaysFetchCuentasHijas", _alwaysFetchCuentasHijas)
			info.AddValue("_alreadyFetchedCuentasHijas", _alreadyFetchedCuentasHijas)

			info.AddValue("_cuentaPadre", _cuentaPadre)
			info.AddValue("_cuentaPadreReturnsNewIfNotFound", _cuentaPadreReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchCuentaPadre", _alwaysFetchCuentaPadre)
			info.AddValue("_alreadyFetchedCuentaPadre", _alreadyFetchedCuentaPadre)

			
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
				Case "CuentaPadre"
					_alreadyFetchedCuentaPadre = True
					Me.CuentaPadre = CType(entity, CuentasFiscalEntity)
				Case "CuentasHijas"
					_alreadyFetchedCuentasHijas = True
					If Not entity Is Nothing Then
						Me.CuentasHijas.Add(CType(entity, CuentasFiscalEntity))
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
				Case "CuentaPadre"
					SetupSyncCuentaPadre(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CuentasHijas"
					_cuentasHijas.Add(CType(relatedEntity, CuentasFiscalEntity))
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
				Case "CuentaPadre"
					DesetupSyncCuentaPadre(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CuentasHijas"
					MyBase.PerformRelatedEntityRemoval(_cuentasHijas, relatedEntity, signalRelatedEntityManyToOne)
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
			If Not _cuentaPadre Is Nothing Then
				toReturn.Add(_cuentaPadre)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_cuentasHijas)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for CuentasFiscal which data should be fetched into this CuentasFiscal Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32) As Boolean
			Return FetchUsingPK(codigo, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for CuentasFiscal which data should be fetched into this CuentasFiscal Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(codigo, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for CuentasFiscal which data should be fetched into this CuentasFiscal Object</param>
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As CuentasFiscalFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As CuentasFiscalFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'CuentasFiscalEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CuentasFiscalEntity'</returns>
		Public Function GetMultiCuentasHijas(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CuentasFiscalCollection
			Return GetMultiCuentasHijas(forceFetch, _cuentasHijas.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentasFiscalEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCuentasHijas(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CuentasFiscalCollection
			Return GetMultiCuentasHijas(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentasFiscalEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'CuentasFiscalEntity'</returns>
		Public Function GetMultiCuentasHijas(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CuentasFiscalCollection
			Return GetMultiCuentasHijas(forceFetch, _cuentasHijas.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'CuentasFiscalEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCuentasHijas(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CuentasFiscalCollection
			If ( Not _alreadyFetchedCuentasHijas Or forceFetch Or _alwaysFetchCuentasHijas) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cuentasHijas.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cuentasHijas)
					End If
				End If
				_cuentasHijas.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cuentasHijas.EntityFactoryToUse = entityFactoryToUse
				End If
				_cuentasHijas.GetMultiManyToOne(Me, Filter)
				_cuentasHijas.SuppressClearInGetMulti = False
				_alreadyFetchedCuentasHijas = True
			End If
			Return _cuentasHijas
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CuentasHijas'. These settings will be taken into account
		''' when the property CuentasHijas is requested or GetMultiCuentasHijas is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCuentasHijas(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cuentasHijas.SortClauses=sortClauses
			_cuentasHijas.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	

		''' <summary>Retrieves the related entity of type 'CuentasFiscalEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'CuentasFiscalEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCuentaPadre() As CuentasFiscalEntity
			Return GetSingleCuentaPadre(False)
		End Function

		''' <summary>Retrieves the related entity of type 'CuentasFiscalEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'CuentasFiscalEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCuentaPadre(forceFetch As Boolean) As CuentasFiscalEntity
			If ( Not _alreadyFetchedCuentaPadre Or forceFetch Or _alwaysFetchCuentaPadre) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New CuentasFiscalEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(CuentasFiscalEntity.Relations.CuentasFiscalEntityUsingCodigoCtaPadre) Then
					fetchResult = newEntity.FetchUsingPK(Me.CtaPadre.GetValueOrDefault())
				End If
				If Not _cuentaPadreReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.CuentaPadre = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), CuentasFiscalEntity)
					End If
					Me.CuentaPadre = newEntity
					_alreadyFetchedCuentaPadre = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _cuentaPadre
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(CuentasFiscalFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, CuentasFiscalFieldIndex)








					Case CuentasFiscalFieldIndex.CtaPadre
						DesetupSyncCuentaPadre(True, False)
						_alreadyFetchedCuentaPadre = False














































					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_cuentasHijas.ActiveContext = MyBase.ActiveContext

		If Not _cuentaPadre Is Nothing Then
				_cuentaPadre.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As CuentasFiscalDAO = CType(CreateDAOInstance(), CuentasFiscalDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As CuentasFiscalDAO = CType(CreateDAOInstance(), CuentasFiscalDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As CuentasFiscalDAO = CType(CreateDAOInstance(), CuentasFiscalDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this CuentasFiscalEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CuentasFiscalEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="codigo">PK value for CuentasFiscal which data should be fetched into this CuentasFiscal Object</param>
		''' <param name="validator">The validator Object for this CuentasFiscalEntity</param>
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
			_cuentasHijas = New Integralab.ORM.CollectionClasses.CuentasFiscalCollection(New CuentasFiscalEntityFactory())
			_cuentasHijas.SetContainingEntityInfo(Me, "CuentaPadre")
			_alwaysFetchCuentasHijas = False
			_alreadyFetchedCuentasHijas = False

			_cuentaPadre = Nothing
			_cuentaPadreReturnsNewIfNotFound = True
			_alwaysFetchCuentaPadre = False
			_alreadyFetchedCuentaPadre = False

			
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

			_fieldsCustomProperties.Add("Cta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SubCta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SsubCta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SssubCta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("NomCuenta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Naturaleza", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("NumeroHijos", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CtaPadre", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CtaEnt", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CtaSal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SaldoAnoAnt", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SaldoIniEjerc", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("BooResultad", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("BooPresup", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("BooAfectable", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("BooInactiva", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("BooDepta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("BooBancos", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Cargos01", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Cargos02", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Cargos03", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Cargos04", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Cargos05", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Cargos06", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Cargos07", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Cargos08", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Cargos09", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Cargos10", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Cargos11", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Cargos12", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Abonos01", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Abonos02", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Abonos03", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Abonos04", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Abonos05", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Abonos06", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Abonos07", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Abonos08", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Abonos09", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Abonos10", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Abonos11", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Abonos12", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Presup01", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Presup02", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Presup03", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Presup04", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Presup05", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Presup06", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Presup07", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Presup08", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Presup09", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Presup10", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Presup11", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Presup12", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _cuentaPadre</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncCuentaPadre(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _cuentaPadre, AddressOf OnCuentaPadrePropertyChanged, "CuentaPadre", CuentasFiscalEntity.Relations.CuentasFiscalEntityUsingCodigoCtaPadre, True, signalRelatedEntity, "CuentasHijas", resetFKFields, New Integer() { CInt(CuentasFiscalFieldIndex.CtaPadre) } )
			_cuentaPadre = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _cuentaPadre</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncCuentaPadre(relatedEntity As IEntity)
			DesetupSyncCuentaPadre(True, True)
			_cuentaPadre = CType(relatedEntity, CuentasFiscalEntity)
			MyBase.PerformSetupSyncRelatedEntity( _cuentaPadre, AddressOf OnCuentaPadrePropertyChanged, "CuentaPadre", CuentasFiscalEntity.Relations.CuentasFiscalEntityUsingCodigoCtaPadre, True, _alreadyFetchedCuentaPadre, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnCuentaPadrePropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="codigo">PK value for CuentasFiscal which data should be fetched into this CuentasFiscal Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(codigo As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(CuentasFiscalFieldIndex.Codigo)).ForcedCurrentValueWrite(codigo)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateCuentasFiscalDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New CuentasFiscalEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As CuentasFiscalRelations
			Get	
				Return New CuentasFiscalRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CuentasFiscal' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentasHijas() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentasFiscalCollection(), _
					CuentasFiscalEntity.Relations.CuentasFiscalEntityUsingCtaPadre, _
					CType(Integralab.ORM.EntityType.CuentasFiscalEntity, Integer), CType(Integralab.ORM.EntityType.CuentasFiscalEntity, Integer), 0, Nothing, Nothing, Nothing, "CuentasHijas", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CuentasFiscal' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaPadre() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentasFiscalCollection(), _
					CuentasFiscalEntity.Relations.CuentasFiscalEntityUsingCodigoCtaPadre, _
					CType(Integralab.ORM.EntityType.CuentasFiscalEntity, Integer), CType(Integralab.ORM.EntityType.CuentasFiscalEntity, Integer), 0, Nothing, Nothing, Nothing, "CuentaPadre", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "CuentasFiscalEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return CuentasFiscalEntity.CustomProperties
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
				Return CuentasFiscalEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The Codigo property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."codigo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [Codigo]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.Codigo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.Codigo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cta property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."Cta"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Cta]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.Cta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.Cta, Integer), value)
			End Set
		End Property
	
		''' <summary>The SubCta property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."SubCta"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SubCta]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.SubCta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.SubCta, Integer), value)
			End Set
		End Property
	
		''' <summary>The SsubCta property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."SSubCta"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SsubCta]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.SsubCta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.SsubCta, Integer), value)
			End Set
		End Property
	
		''' <summary>The SssubCta property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."SSSubCta"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SssubCta]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.SssubCta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.SssubCta, Integer), value)
			End Set
		End Property
	
		''' <summary>The NomCuenta property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."NomCuenta"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 100<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [NomCuenta]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.NomCuenta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.NomCuenta, Integer), value)
			End Set
		End Property
	
		''' <summary>The Naturaleza property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."Naturaleza"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 1<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Naturaleza]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.Naturaleza, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.Naturaleza, Integer), value)
			End Set
		End Property
	
		''' <summary>The NumeroHijos property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."NumeroHijos"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [NumeroHijos]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.NumeroHijos, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.NumeroHijos, Integer), value)
			End Set
		End Property
	
		''' <summary>The CtaPadre property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."CtaPadre"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [CtaPadre]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.CtaPadre, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.CtaPadre, Integer), value)
			End Set
		End Property
	
		''' <summary>The CtaEnt property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."CtaEnt"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [CtaEnt]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.CtaEnt, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.CtaEnt, Integer), value)
			End Set
		End Property
	
		''' <summary>The CtaSal property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."CtaSal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [CtaSal]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.CtaSal, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.CtaSal, Integer), value)
			End Set
		End Property
	
		''' <summary>The SaldoAnoAnt property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."SaldoAnoAnt"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SaldoAnoAnt]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.SaldoAnoAnt, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.SaldoAnoAnt, Integer), value)
			End Set
		End Property
	
		''' <summary>The SaldoIniEjerc property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."SaldoIniEjerc"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SaldoIniEjerc]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.SaldoIniEjerc, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.SaldoIniEjerc, Integer), value)
			End Set
		End Property
	
		''' <summary>The BooResultad property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."BooResultad"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [BooResultad]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.BooResultad, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.BooResultad, Integer), value)
			End Set
		End Property
	
		''' <summary>The BooPresup property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."BooPresup"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [BooPresup]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.BooPresup, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.BooPresup, Integer), value)
			End Set
		End Property
	
		''' <summary>The BooAfectable property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."BooAfectable"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [BooAfectable]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.BooAfectable, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.BooAfectable, Integer), value)
			End Set
		End Property
	
		''' <summary>The BooInactiva property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."BooInactiva"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [BooInactiva]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.BooInactiva, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.BooInactiva, Integer), value)
			End Set
		End Property
	
		''' <summary>The BooDepta property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."BooDepta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [BooDepta]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.BooDepta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.BooDepta, Integer), value)
			End Set
		End Property
	
		''' <summary>The BooBancos property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."BooBancos"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [BooBancos]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.BooBancos, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.BooBancos, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cargos01 property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."Cargos01"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Cargos01]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.Cargos01, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.Cargos01, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cargos02 property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."Cargos02"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Cargos02]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.Cargos02, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.Cargos02, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cargos03 property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."Cargos03"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Cargos03]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.Cargos03, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.Cargos03, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cargos04 property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."Cargos04"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Cargos04]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.Cargos04, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.Cargos04, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cargos05 property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."Cargos05"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Cargos05]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.Cargos05, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.Cargos05, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cargos06 property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."Cargos06"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Cargos06]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.Cargos06, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.Cargos06, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cargos07 property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."Cargos07"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Cargos07]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.Cargos07, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.Cargos07, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cargos08 property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."Cargos08"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Cargos08]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.Cargos08, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.Cargos08, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cargos09 property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."Cargos09"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Cargos09]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.Cargos09, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.Cargos09, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cargos10 property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."Cargos10"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Cargos10]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.Cargos10, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.Cargos10, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cargos11 property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."Cargos11"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Cargos11]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.Cargos11, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.Cargos11, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cargos12 property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."Cargos12"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Cargos12]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.Cargos12, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.Cargos12, Integer), value)
			End Set
		End Property
	
		''' <summary>The Abonos01 property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."Abonos01"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Abonos01]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.Abonos01, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.Abonos01, Integer), value)
			End Set
		End Property
	
		''' <summary>The Abonos02 property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."Abonos02"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Abonos02]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.Abonos02, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.Abonos02, Integer), value)
			End Set
		End Property
	
		''' <summary>The Abonos03 property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."Abonos03"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Abonos03]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.Abonos03, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.Abonos03, Integer), value)
			End Set
		End Property
	
		''' <summary>The Abonos04 property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."Abonos04"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Abonos04]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.Abonos04, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.Abonos04, Integer), value)
			End Set
		End Property
	
		''' <summary>The Abonos05 property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."Abonos05"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Abonos05]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.Abonos05, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.Abonos05, Integer), value)
			End Set
		End Property
	
		''' <summary>The Abonos06 property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."Abonos06"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Abonos06]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.Abonos06, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.Abonos06, Integer), value)
			End Set
		End Property
	
		''' <summary>The Abonos07 property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."Abonos07"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Abonos07]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.Abonos07, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.Abonos07, Integer), value)
			End Set
		End Property
	
		''' <summary>The Abonos08 property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."Abonos08"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Abonos08]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.Abonos08, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.Abonos08, Integer), value)
			End Set
		End Property
	
		''' <summary>The Abonos09 property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."Abonos09"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Abonos09]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.Abonos09, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.Abonos09, Integer), value)
			End Set
		End Property
	
		''' <summary>The Abonos10 property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."Abonos10"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Abonos10]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.Abonos10, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.Abonos10, Integer), value)
			End Set
		End Property
	
		''' <summary>The Abonos11 property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."Abonos11"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Abonos11]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.Abonos11, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.Abonos11, Integer), value)
			End Set
		End Property
	
		''' <summary>The Abonos12 property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."Abonos12"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Abonos12]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.Abonos12, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.Abonos12, Integer), value)
			End Set
		End Property
	
		''' <summary>The Presup01 property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."Presup01"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Presup01]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.Presup01, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.Presup01, Integer), value)
			End Set
		End Property
	
		''' <summary>The Presup02 property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."Presup02"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Presup02]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.Presup02, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.Presup02, Integer), value)
			End Set
		End Property
	
		''' <summary>The Presup03 property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."Presup03"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Presup03]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.Presup03, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.Presup03, Integer), value)
			End Set
		End Property
	
		''' <summary>The Presup04 property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."Presup04"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Presup04]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.Presup04, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.Presup04, Integer), value)
			End Set
		End Property
	
		''' <summary>The Presup05 property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."Presup05"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Presup05]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.Presup05, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.Presup05, Integer), value)
			End Set
		End Property
	
		''' <summary>The Presup06 property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."Presup06"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Presup06]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.Presup06, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.Presup06, Integer), value)
			End Set
		End Property
	
		''' <summary>The Presup07 property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."Presup07"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Presup07]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.Presup07, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.Presup07, Integer), value)
			End Set
		End Property
	
		''' <summary>The Presup08 property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."Presup08"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Presup08]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.Presup08, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.Presup08, Integer), value)
			End Set
		End Property
	
		''' <summary>The Presup09 property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."Presup09"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Presup09]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.Presup09, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.Presup09, Integer), value)
			End Set
		End Property
	
		''' <summary>The Presup10 property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."Presup10"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Presup10]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.Presup10, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.Presup10, Integer), value)
			End Set
		End Property
	
		''' <summary>The Presup11 property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."Presup11"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Presup11]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.Presup11, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.Presup11, Integer), value)
			End Set
		End Property
	
		''' <summary>The Presup12 property of the Entity CuentasFiscal<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrContCuentasFisc"."Presup12"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Presup12]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CuentasFiscalFieldIndex.Presup12, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CuentasFiscalFieldIndex.Presup12, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'CuentasFiscalEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCuentasHijas()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CuentasHijas]() As Integralab.ORM.CollectionClasses.CuentasFiscalCollection
			Get
				Return GetMultiCuentasHijas(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentasHijas. When set to true, CuentasHijas is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentasHijas is accessed. You can always execute
		''' a forced fetch by calling GetMultiCuentasHijas(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentasHijas As Boolean
			Get
				Return _alwaysFetchCuentasHijas
			End Get
			Set
				_alwaysFetchCuentasHijas = value
			End Set	
		End Property
	
	
	
		''' <summary>Gets / sets related entity of type 'CuentasFiscalEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCuentaPadre()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [CuentaPadre]() As CuentasFiscalEntity
			Get
				Return GetSingleCuentaPadre(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncCuentaPadre(value)
				Else
					If value Is Nothing Then
						If Not _cuentaPadre Is Nothing Then
							_cuentaPadre.UnsetRelatedEntity(Me, "CuentasHijas")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "CuentasHijas")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentaPadre. When set to true, CuentaPadre is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentaPadre is accessed. You can always execute
		''' a forced fetch by calling GetSingleCuentaPadre(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentaPadre As Boolean
			Get
				Return _alwaysFetchCuentaPadre
			End Get
			Set
				_alwaysFetchCuentaPadre = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property CuentaPadre is not found
		''' in the database. When set to true, CuentaPadre will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property CuentaPadreReturnsNewIfNotFound As Boolean
			Get
				Return _cuentaPadreReturnsNewIfNotFound
			End Get
			Set
				_cuentaPadreReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.CuentasFiscalEntity)
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
