' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 11 de diciembre de 2017 20:57:29
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
	''' <summary>Entity class which represents the entity 'McgcatVehiculos'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class McgcatVehiculosEntity 
#Else
	<Serializable()> _
	Public Class McgcatVehiculosEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END
			

#Region "Class Member Declarations"
		Private _cabGasTrans As Integralab.ORM.CollectionClasses.CabGasTransCollection
		Private _alwaysFetchCabGasTrans, _alreadyFetchedCabGasTrans As Boolean
		Private _mcgcatChoferesCollectionViaCabGasTrans As Integralab.ORM.CollectionClasses.McgcatChoferesCollection
		Private _alwaysFetchMcgcatChoferesCollectionViaCabGasTrans, _alreadyFetchedMcgcatChoferesCollectionViaCabGasTrans As Boolean



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
		''' <param name="idVehiculo">PK value for McgcatVehiculos which data should be fetched into this McgcatVehiculos Object</param>
		Public Sub New(idVehiculo As System.Int32)

			InitClassFetch(idVehiculo, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idVehiculo">PK value for McgcatVehiculos which data should be fetched into this McgcatVehiculos Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(idVehiculo As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(idVehiculo, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idVehiculo">PK value for McgcatVehiculos which data should be fetched into this McgcatVehiculos Object</param>
		''' <param name="validator">The custom validator Object for this McgcatVehiculosEntity</param>
		Public Sub New(idVehiculo As System.Int32, validator As IValidator)

			InitClassFetch(idVehiculo, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_cabGasTrans = CType(info.GetValue("_cabGasTrans", GetType(Integralab.ORM.CollectionClasses.CabGasTransCollection)), Integralab.ORM.CollectionClasses.CabGasTransCollection)
			_alwaysFetchCabGasTrans = info.GetBoolean("_alwaysFetchCabGasTrans")
			_alreadyFetchedCabGasTrans = info.GetBoolean("_alreadyFetchedCabGasTrans")
			_mcgcatChoferesCollectionViaCabGasTrans = CType(info.GetValue("_mcgcatChoferesCollectionViaCabGasTrans", GetType(Integralab.ORM.CollectionClasses.McgcatChoferesCollection)), Integralab.ORM.CollectionClasses.McgcatChoferesCollection)
			_alwaysFetchMcgcatChoferesCollectionViaCabGasTrans = info.GetBoolean("_alwaysFetchMcgcatChoferesCollectionViaCabGasTrans")
			_alreadyFetchedMcgcatChoferesCollectionViaCabGasTrans = info.GetBoolean("_alreadyFetchedMcgcatChoferesCollectionViaCabGasTrans")


			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
			
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedCabGasTrans = (_cabGasTrans.Count > 0)
			_alreadyFetchedMcgcatChoferesCollectionViaCabGasTrans = (_mcgcatChoferesCollectionViaCabGasTrans.Count > 0)


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
			info.AddValue("_cabGasTrans", _cabGasTrans)
			info.AddValue("_alwaysFetchCabGasTrans", _alwaysFetchCabGasTrans)
			info.AddValue("_alreadyFetchedCabGasTrans", _alreadyFetchedCabGasTrans)
			info.AddValue("_mcgcatChoferesCollectionViaCabGasTrans", _mcgcatChoferesCollectionViaCabGasTrans)
			info.AddValue("_alwaysFetchMcgcatChoferesCollectionViaCabGasTrans", _alwaysFetchMcgcatChoferesCollectionViaCabGasTrans)
			info.AddValue("_alreadyFetchedMcgcatChoferesCollectionViaCabGasTrans", _alreadyFetchedMcgcatChoferesCollectionViaCabGasTrans)


			
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

				Case "CabGasTrans"
					_alreadyFetchedCabGasTrans = True
					If Not entity Is Nothing Then
						Me.CabGasTrans.Add(CType(entity, CabGasTransEntity))
					End If
				Case "McgcatChoferesCollectionViaCabGasTrans"
					_alreadyFetchedMcgcatChoferesCollectionViaCabGasTrans = True
					If Not entity Is Nothing Then
						Me.McgcatChoferesCollectionViaCabGasTrans.Add(CType(entity, McgcatChoferesEntity))
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

				Case "CabGasTrans"
					_cabGasTrans.Add(CType(relatedEntity, CabGasTransEntity))
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

				Case "CabGasTrans"
					MyBase.PerformRelatedEntityRemoval(_cabGasTrans, relatedEntity, signalRelatedEntityManyToOne)
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



			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_cabGasTrans)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idVehiculo">PK value for McgcatVehiculos which data should be fetched into this McgcatVehiculos Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idVehiculo As System.Int32) As Boolean
			Return FetchUsingPK(idVehiculo, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idVehiculo">PK value for McgcatVehiculos which data should be fetched into this McgcatVehiculos Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idVehiculo As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(idVehiculo, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idVehiculo">PK value for McgcatVehiculos which data should be fetched into this McgcatVehiculos Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idVehiculo As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(idVehiculo, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.IdVehiculo, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As McgcatVehiculosFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As McgcatVehiculosFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'CabGasTransEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CabGasTransEntity'</returns>
		Public Function GetMultiCabGasTrans(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CabGasTransCollection
			Return GetMultiCabGasTrans(forceFetch, _cabGasTrans.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CabGasTransEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiCabGasTrans(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CabGasTransCollection
			Return GetMultiCabGasTrans(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CabGasTransEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'CabGasTransEntity'</returns>
		Public Function GetMultiCabGasTrans(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CabGasTransCollection
			Return GetMultiCabGasTrans(forceFetch, _cabGasTrans.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'CabGasTransEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCabGasTrans(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CabGasTransCollection
			If ( Not _alreadyFetchedCabGasTrans Or forceFetch Or _alwaysFetchCabGasTrans) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cabGasTrans.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cabGasTrans)
					End If
				End If
				_cabGasTrans.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cabGasTrans.EntityFactoryToUse = entityFactoryToUse
				End If
				_cabGasTrans.GetMultiManyToOne(Nothing, Me, Filter)
				_cabGasTrans.SuppressClearInGetMulti = False
				_alreadyFetchedCabGasTrans = True
			End If
			Return _cabGasTrans
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CabGasTrans'. These settings will be taken into account
		''' when the property CabGasTrans is requested or GetMultiCabGasTrans is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCabGasTrans(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cabGasTrans.SortClauses=sortClauses
			_cabGasTrans.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'McgcatChoferesEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McgcatChoferesEntity'</returns>
		Public Function GetMultiMcgcatChoferesCollectionViaCabGasTrans(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McgcatChoferesCollection
			Return GetMultiMcgcatChoferesCollectionViaCabGasTrans(forceFetch, _mcgcatChoferesCollectionViaCabGasTrans.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McgcatChoferesEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcgcatChoferesCollectionViaCabGasTrans(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McgcatChoferesCollection
			If ( Not _alreadyFetchedMcgcatChoferesCollectionViaCabGasTrans Or forceFetch Or _alwaysFetchMcgcatChoferesCollectionViaCabGasTrans) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcgcatChoferesCollectionViaCabGasTrans.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcgcatChoferesCollectionViaCabGasTrans)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(McgcatVehiculosEntity.Relations.CabGasTransEntityUsingCveVehiculo, "__McgcatVehiculosEntity__", "CabGasTrans_", JoinHint.None)
				relations.Add(CabGasTransEntity.Relations.McgcatChoferesEntityUsingCveChofer, "CabGasTrans_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(McgcatVehiculosFieldIndex.IdVehiculo), ComparisonOperator.Equal, Me.IdVehiculo))
				_mcgcatChoferesCollectionViaCabGasTrans.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcgcatChoferesCollectionViaCabGasTrans.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcgcatChoferesCollectionViaCabGasTrans.GetMulti(Filter, relations)
				_mcgcatChoferesCollectionViaCabGasTrans.SuppressClearInGetMulti = False
				_alreadyFetchedMcgcatChoferesCollectionViaCabGasTrans = True
			End If
			Return _mcgcatChoferesCollectionViaCabGasTrans
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McgcatChoferesCollectionViaCabGasTrans'. These settings will be taken into account
		''' when the property McgcatChoferesCollectionViaCabGasTrans is requested or GetMultiMcgcatChoferesCollectionViaCabGasTrans is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcgcatChoferesCollectionViaCabGasTrans(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcgcatChoferesCollectionViaCabGasTrans.SortClauses=sortClauses
			_mcgcatChoferesCollectionViaCabGasTrans.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

	
		
		''' <summary>Sets the field On index fieldIndex To the New value value. Marks also the fields Object As dirty. </summary>
		''' <param name="fieldIndex">Index of field To Set the New value of</param>
		''' <param name="value">Value To Set</param>
		''' <param name="checkForRefetch">If Set To True, it will check If this entity Is out of sync And will refetch it first If it Is. Use True In normal behavior, False For framework specific code.</param>
		''' <returns>True If the value Is actually Set, False otherwise.</returns>
		''' <remarks>Dereferences a related Object In an 1:1/m:1 relation If the field Is an FK field And responsible For the reference of that particular related Object.</remarks>
		''' <exception cref="ArgumentOutOfRangeException">When fieldIndex Is smaller than 0 Or bigger than the number of fields In the fields collection.</exception>
		Protected Overrides Overloads Function SetNewFieldValue(fieldIndex As Integer, value As Object, checkForRefetch As Boolean) As Boolean
			Dim toReturn As Boolean = MyBase.SetNewFieldValue (fieldIndex, value, checkForRefetch, False)			
			If toReturn AndAlso System.Enum.IsDefined(GetType(McgcatVehiculosFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, McgcatVehiculosFieldIndex)













					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_cabGasTrans.ActiveContext = MyBase.ActiveContext
			_mcgcatChoferesCollectionViaCabGasTrans.ActiveContext = MyBase.ActiveContext



		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As McgcatVehiculosDAO = CType(CreateDAOInstance(), McgcatVehiculosDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As McgcatVehiculosDAO = CType(CreateDAOInstance(), McgcatVehiculosDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As McgcatVehiculosDAO = CType(CreateDAOInstance(), McgcatVehiculosDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this McgcatVehiculosEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.McgcatVehiculosEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="idVehiculo">PK value for McgcatVehiculos which data should be fetched into this McgcatVehiculos Object</param>
		''' <param name="validator">The validator Object for this McgcatVehiculosEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(idVehiculo As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(idVehiculo, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_cabGasTrans = New Integralab.ORM.CollectionClasses.CabGasTransCollection(New CabGasTransEntityFactory())
			_cabGasTrans.SetContainingEntityInfo(Me, "McgcatVehiculos")
			_alwaysFetchCabGasTrans = False
			_alreadyFetchedCabGasTrans = False
			_mcgcatChoferesCollectionViaCabGasTrans = New Integralab.ORM.CollectionClasses.McgcatChoferesCollection(New McgcatChoferesEntityFactory())
			_alwaysFetchMcgcatChoferesCollectionViaCabGasTrans = False
			_alreadyFetchedMcgcatChoferesCollectionViaCabGasTrans = False


			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
			
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdVehiculo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DescVehiculo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DescCorVehiculo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Marca", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Modelo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Placas", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("NoSerie", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCompra", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Observaciones", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("MotivoBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("QuiendioBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
		End Sub





		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="idVehiculo">PK value for McgcatVehiculos which data should be fetched into this McgcatVehiculos Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(idVehiculo As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(McgcatVehiculosFieldIndex.IdVehiculo)).ForcedCurrentValueWrite(idVehiculo)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateMcgcatVehiculosDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New McgcatVehiculosEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As McgcatVehiculosRelations
			Get	
				Return New McgcatVehiculosRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabGasTrans' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabGasTrans() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabGasTransCollection(), _
					McgcatVehiculosEntity.Relations.CabGasTransEntityUsingCveVehiculo, _
					CType(Integralab.ORM.EntityType.McgcatVehiculosEntity, Integer), CType(Integralab.ORM.EntityType.CabGasTransEntity, Integer), 0, Nothing, Nothing, Nothing, "CabGasTrans", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McgcatChoferes' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcgcatChoferesCollectionViaCabGasTrans() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(McgcatVehiculosEntity.Relations.CabGasTransEntityUsingCveVehiculo, "__McgcatVehiculosEntity__", String.Empty, JoinHint.None)
				relations.Add(CabGasTransEntity.Relations.McgcatChoferesEntityUsingCveChofer)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McgcatChoferesCollection(), _
					McgcatVehiculosEntity.Relations.CabGasTransEntityUsingCveVehiculo, _
					CType(Integralab.ORM.EntityType.McgcatVehiculosEntity, Integer), CType(Integralab.ORM.EntityType.McgcatChoferesEntity, Integer), 0, Nothing, Nothing, relations, "McgcatChoferesCollectionViaCabGasTrans", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "McgcatVehiculosEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return McgcatVehiculosEntity.CustomProperties
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
				Return McgcatVehiculosEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The IdVehiculo property of the Entity McgcatVehiculos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatVehiculos"."IdVehiculo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [IdVehiculo]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatVehiculosFieldIndex.IdVehiculo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(McgcatVehiculosFieldIndex.IdVehiculo, Integer), value)
			End Set
		End Property
	
		''' <summary>The DescVehiculo property of the Entity McgcatVehiculos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatVehiculos"."DescVehiculo"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 100<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DescVehiculo]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatVehiculosFieldIndex.DescVehiculo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(McgcatVehiculosFieldIndex.DescVehiculo, Integer), value)
			End Set
		End Property
	
		''' <summary>The DescCorVehiculo property of the Entity McgcatVehiculos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatVehiculos"."DescCorVehiculo"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DescCorVehiculo]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatVehiculosFieldIndex.DescCorVehiculo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(McgcatVehiculosFieldIndex.DescCorVehiculo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Marca property of the Entity McgcatVehiculos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatVehiculos"."Marca"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Marca]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatVehiculosFieldIndex.Marca, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(McgcatVehiculosFieldIndex.Marca, Integer), value)
			End Set
		End Property
	
		''' <summary>The Modelo property of the Entity McgcatVehiculos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatVehiculos"."Modelo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 4<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Modelo]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatVehiculosFieldIndex.Modelo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(McgcatVehiculosFieldIndex.Modelo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Placas property of the Entity McgcatVehiculos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatVehiculos"."Placas"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Placas]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatVehiculosFieldIndex.Placas, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(McgcatVehiculosFieldIndex.Placas, Integer), value)
			End Set
		End Property
	
		''' <summary>The NoSerie property of the Entity McgcatVehiculos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatVehiculos"."NoSerie"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 30<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [NoSerie]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatVehiculosFieldIndex.NoSerie, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(McgcatVehiculosFieldIndex.NoSerie, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCompra property of the Entity McgcatVehiculos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatVehiculos"."FechaCompra"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaCompra]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatVehiculosFieldIndex.FechaCompra, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(McgcatVehiculosFieldIndex.FechaCompra, Integer), value)
			End Set
		End Property
	
		''' <summary>The Observaciones property of the Entity McgcatVehiculos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatVehiculos"."Observaciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Observaciones]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatVehiculosFieldIndex.Observaciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(McgcatVehiculosFieldIndex.Observaciones, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaBaja property of the Entity McgcatVehiculos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatVehiculos"."FechaBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaBaja]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatVehiculosFieldIndex.FechaBaja, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(McgcatVehiculosFieldIndex.FechaBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The MotivoBaja property of the Entity McgcatVehiculos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatVehiculos"."MotivoBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [MotivoBaja]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatVehiculosFieldIndex.MotivoBaja, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(McgcatVehiculosFieldIndex.MotivoBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The QuiendioBaja property of the Entity McgcatVehiculos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatVehiculos"."QuiendioBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [QuiendioBaja]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatVehiculosFieldIndex.QuiendioBaja, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(McgcatVehiculosFieldIndex.QuiendioBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity McgcatVehiculos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCGCatVehiculos"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 1<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McgcatVehiculosFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(McgcatVehiculosFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'CabGasTransEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCabGasTrans()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CabGasTrans]() As Integralab.ORM.CollectionClasses.CabGasTransCollection
			Get
				Return GetMultiCabGasTrans(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CabGasTrans. When set to true, CabGasTrans is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CabGasTrans is accessed. You can always execute
		''' a forced fetch by calling GetMultiCabGasTrans(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCabGasTrans As Boolean
			Get
				Return _alwaysFetchCabGasTrans
			End Get
			Set
				_alwaysFetchCabGasTrans = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'McgcatChoferesEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcgcatChoferesCollectionViaCabGasTrans()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McgcatChoferesCollectionViaCabGasTrans]() As Integralab.ORM.CollectionClasses.McgcatChoferesCollection
			Get
				Return GetMultiMcgcatChoferesCollectionViaCabGasTrans(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McgcatChoferesCollectionViaCabGasTrans. When set to true, McgcatChoferesCollectionViaCabGasTrans is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McgcatChoferesCollectionViaCabGasTrans is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcgcatChoferesCollectionViaCabGasTrans(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcgcatChoferesCollectionViaCabGasTrans As Boolean
			Get
				Return _alwaysFetchMcgcatChoferesCollectionViaCabGasTrans
			End Get
			Set
				_alwaysFetchMcgcatChoferesCollectionViaCabGasTrans = value
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
				Return CInt(Integralab.ORM.EntityType.McgcatVehiculosEntity)
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
