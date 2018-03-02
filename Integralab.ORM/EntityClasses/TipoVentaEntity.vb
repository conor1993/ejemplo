﻿' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 2 de marzo de 2018 10:17:29
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
	''' <summary>Entity class which represents the entity 'TipoVenta'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class TipoVentaEntity 
#Else
	<Serializable()> _
	Public Class TipoVentaEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _listaPrecio As Integralab.ORM.CollectionClasses.ListaPrecioCollection
		Private _alwaysFetchListaPrecio, _alreadyFetchedListaPrecio As Boolean
		Private _plazaCollectionViaListaPrecio As Integralab.ORM.CollectionClasses.PlazaCollection
		Private _alwaysFetchPlazaCollectionViaListaPrecio, _alreadyFetchedPlazaCollectionViaListaPrecio As Boolean
		Private _listaPrecioCollectionViaListaPrecio As Integralab.ORM.CollectionClasses.ListaPrecioCollection
		Private _alwaysFetchListaPrecioCollectionViaListaPrecio, _alreadyFetchedListaPrecioCollectionViaListaPrecio As Boolean



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
		''' <param name="codigo">PK value for TipoVenta which data should be fetched into this TipoVenta Object</param>
		Public Sub New(codigo As System.Int32)

			InitClassFetch(codigo, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for TipoVenta which data should be fetched into this TipoVenta Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(codigo As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(codigo, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for TipoVenta which data should be fetched into this TipoVenta Object</param>
		''' <param name="validator">The custom validator Object for this TipoVentaEntity</param>
		Public Sub New(codigo As System.Int32, validator As IValidator)

			InitClassFetch(codigo, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_listaPrecio = CType(info.GetValue("_listaPrecio", GetType(Integralab.ORM.CollectionClasses.ListaPrecioCollection)), Integralab.ORM.CollectionClasses.ListaPrecioCollection)
			_alwaysFetchListaPrecio = info.GetBoolean("_alwaysFetchListaPrecio")
			_alreadyFetchedListaPrecio = info.GetBoolean("_alreadyFetchedListaPrecio")
			_plazaCollectionViaListaPrecio = CType(info.GetValue("_plazaCollectionViaListaPrecio", GetType(Integralab.ORM.CollectionClasses.PlazaCollection)), Integralab.ORM.CollectionClasses.PlazaCollection)
			_alwaysFetchPlazaCollectionViaListaPrecio = info.GetBoolean("_alwaysFetchPlazaCollectionViaListaPrecio")
			_alreadyFetchedPlazaCollectionViaListaPrecio = info.GetBoolean("_alreadyFetchedPlazaCollectionViaListaPrecio")
			_listaPrecioCollectionViaListaPrecio = CType(info.GetValue("_listaPrecioCollectionViaListaPrecio", GetType(Integralab.ORM.CollectionClasses.ListaPrecioCollection)), Integralab.ORM.CollectionClasses.ListaPrecioCollection)
			_alwaysFetchListaPrecioCollectionViaListaPrecio = info.GetBoolean("_alwaysFetchListaPrecioCollectionViaListaPrecio")
			_alreadyFetchedListaPrecioCollectionViaListaPrecio = info.GetBoolean("_alreadyFetchedListaPrecioCollectionViaListaPrecio")


			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedListaPrecio = (_listaPrecio.Count > 0)
			_alreadyFetchedPlazaCollectionViaListaPrecio = (_plazaCollectionViaListaPrecio.Count > 0)
			_alreadyFetchedListaPrecioCollectionViaListaPrecio = (_listaPrecioCollectionViaListaPrecio.Count > 0)


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
			info.AddValue("_listaPrecio", _listaPrecio)
			info.AddValue("_alwaysFetchListaPrecio", _alwaysFetchListaPrecio)
			info.AddValue("_alreadyFetchedListaPrecio", _alreadyFetchedListaPrecio)
			info.AddValue("_plazaCollectionViaListaPrecio", _plazaCollectionViaListaPrecio)
			info.AddValue("_alwaysFetchPlazaCollectionViaListaPrecio", _alwaysFetchPlazaCollectionViaListaPrecio)
			info.AddValue("_alreadyFetchedPlazaCollectionViaListaPrecio", _alreadyFetchedPlazaCollectionViaListaPrecio)
			info.AddValue("_listaPrecioCollectionViaListaPrecio", _listaPrecioCollectionViaListaPrecio)
			info.AddValue("_alwaysFetchListaPrecioCollectionViaListaPrecio", _alwaysFetchListaPrecioCollectionViaListaPrecio)
			info.AddValue("_alreadyFetchedListaPrecioCollectionViaListaPrecio", _alreadyFetchedListaPrecioCollectionViaListaPrecio)


			
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

				Case "ListaPrecio"
					_alreadyFetchedListaPrecio = True
					If Not entity Is Nothing Then
						Me.ListaPrecio.Add(CType(entity, ListaPrecioEntity))
					End If
				Case "PlazaCollectionViaListaPrecio"
					_alreadyFetchedPlazaCollectionViaListaPrecio = True
					If Not entity Is Nothing Then
						Me.PlazaCollectionViaListaPrecio.Add(CType(entity, PlazaEntity))
					End If
				Case "ListaPrecioCollectionViaListaPrecio"
					_alreadyFetchedListaPrecioCollectionViaListaPrecio = True
					If Not entity Is Nothing Then
						Me.ListaPrecioCollectionViaListaPrecio.Add(CType(entity, ListaPrecioEntity))
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

				Case "ListaPrecio"
					_listaPrecio.Add(CType(relatedEntity, ListaPrecioEntity))
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

				Case "ListaPrecio"
					MyBase.PerformRelatedEntityRemoval(_listaPrecio, relatedEntity, signalRelatedEntityManyToOne)
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
			toReturn.Add(_listaPrecio)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for TipoVenta which data should be fetched into this TipoVenta Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32) As Boolean
			Return FetchUsingPK(codigo, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for TipoVenta which data should be fetched into this TipoVenta Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(codigo, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for TipoVenta which data should be fetched into this TipoVenta Object</param>
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As TipoVentaFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As TipoVentaFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'ListaPrecioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ListaPrecioEntity'</returns>
		Public Function GetMultiListaPrecio(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ListaPrecioCollection
			Return GetMultiListaPrecio(forceFetch, _listaPrecio.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ListaPrecioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiListaPrecio(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ListaPrecioCollection
			Return GetMultiListaPrecio(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ListaPrecioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'ListaPrecioEntity'</returns>
		Public Function GetMultiListaPrecio(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ListaPrecioCollection
			Return GetMultiListaPrecio(forceFetch, _listaPrecio.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'ListaPrecioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiListaPrecio(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ListaPrecioCollection
			If ( Not _alreadyFetchedListaPrecio Or forceFetch Or _alwaysFetchListaPrecio) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _listaPrecio.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_listaPrecio)
					End If
				End If
				_listaPrecio.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_listaPrecio.EntityFactoryToUse = entityFactoryToUse
				End If
				_listaPrecio.GetMultiManyToOne(Nothing, Me, Nothing, Filter)
				_listaPrecio.SuppressClearInGetMulti = False
				_alreadyFetchedListaPrecio = True
			End If
			Return _listaPrecio
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ListaPrecio'. These settings will be taken into account
		''' when the property ListaPrecio is requested or GetMultiListaPrecio is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersListaPrecio(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_listaPrecio.SortClauses=sortClauses
			_listaPrecio.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PlazaEntity'</returns>
		Public Function GetMultiPlazaCollectionViaListaPrecio(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PlazaCollection
			Return GetMultiPlazaCollectionViaListaPrecio(forceFetch, _plazaCollectionViaListaPrecio.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiPlazaCollectionViaListaPrecio(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PlazaCollection
			If ( Not _alreadyFetchedPlazaCollectionViaListaPrecio Or forceFetch Or _alwaysFetchPlazaCollectionViaListaPrecio) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _plazaCollectionViaListaPrecio.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_plazaCollectionViaListaPrecio)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(TipoVentaEntity.Relations.ListaPrecioEntityUsingLpidTipoVenta, "__TipoVentaEntity__", "ListaPrecio_", JoinHint.None)
				relations.Add(ListaPrecioEntity.Relations.PlazaEntityUsingPlaza, "ListaPrecio_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(TipoVentaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_plazaCollectionViaListaPrecio.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_plazaCollectionViaListaPrecio.EntityFactoryToUse = entityFactoryToUse
				End If
				_plazaCollectionViaListaPrecio.GetMulti(Filter, relations)
				_plazaCollectionViaListaPrecio.SuppressClearInGetMulti = False
				_alreadyFetchedPlazaCollectionViaListaPrecio = True
			End If
			Return _plazaCollectionViaListaPrecio
		End Function

		''' <summary>Sets the collection parameters for the collection for 'PlazaCollectionViaListaPrecio'. These settings will be taken into account
		''' when the property PlazaCollectionViaListaPrecio is requested or GetMultiPlazaCollectionViaListaPrecio is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersPlazaCollectionViaListaPrecio(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_plazaCollectionViaListaPrecio.SortClauses=sortClauses
			_plazaCollectionViaListaPrecio.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'ListaPrecioEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ListaPrecioEntity'</returns>
		Public Function GetMultiListaPrecioCollectionViaListaPrecio(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ListaPrecioCollection
			Return GetMultiListaPrecioCollectionViaListaPrecio(forceFetch, _listaPrecioCollectionViaListaPrecio.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ListaPrecioEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiListaPrecioCollectionViaListaPrecio(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ListaPrecioCollection
			If ( Not _alreadyFetchedListaPrecioCollectionViaListaPrecio Or forceFetch Or _alwaysFetchListaPrecioCollectionViaListaPrecio) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _listaPrecioCollectionViaListaPrecio.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_listaPrecioCollectionViaListaPrecio)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(TipoVentaEntity.Relations.ListaPrecioEntityUsingLpidTipoVenta, "__TipoVentaEntity__", "ListaPrecio_", JoinHint.None)
				relations.Add(ListaPrecioEntity.Relations.ListaPrecioEntityUsingListaBase, "ListaPrecio_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(TipoVentaFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_listaPrecioCollectionViaListaPrecio.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_listaPrecioCollectionViaListaPrecio.EntityFactoryToUse = entityFactoryToUse
				End If
				_listaPrecioCollectionViaListaPrecio.GetMulti(Filter, relations)
				_listaPrecioCollectionViaListaPrecio.SuppressClearInGetMulti = False
				_alreadyFetchedListaPrecioCollectionViaListaPrecio = True
			End If
			Return _listaPrecioCollectionViaListaPrecio
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ListaPrecioCollectionViaListaPrecio'. These settings will be taken into account
		''' when the property ListaPrecioCollectionViaListaPrecio is requested or GetMultiListaPrecioCollectionViaListaPrecio is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersListaPrecioCollectionViaListaPrecio(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_listaPrecioCollectionViaListaPrecio.SortClauses=sortClauses
			_listaPrecioCollectionViaListaPrecio.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(TipoVentaFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, TipoVentaFieldIndex)












					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_listaPrecio.ActiveContext = MyBase.ActiveContext
			_plazaCollectionViaListaPrecio.ActiveContext = MyBase.ActiveContext
			_listaPrecioCollectionViaListaPrecio.ActiveContext = MyBase.ActiveContext



		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As TipoVentaDAO = CType(CreateDAOInstance(), TipoVentaDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As TipoVentaDAO = CType(CreateDAOInstance(), TipoVentaDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As TipoVentaDAO = CType(CreateDAOInstance(), TipoVentaDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this TipoVentaEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.TipoVentaEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="codigo">PK value for TipoVenta which data should be fetched into this TipoVenta Object</param>
		''' <param name="validator">The validator Object for this TipoVentaEntity</param>
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
			_listaPrecio = New Integralab.ORM.CollectionClasses.ListaPrecioCollection(New ListaPrecioEntityFactory())
			_listaPrecio.SetContainingEntityInfo(Me, "TipoVenta")
			_alwaysFetchListaPrecio = False
			_alreadyFetchedListaPrecio = False
			_plazaCollectionViaListaPrecio = New Integralab.ORM.CollectionClasses.PlazaCollection(New PlazaEntityFactory())
			_alwaysFetchPlazaCollectionViaListaPrecio = False
			_alreadyFetchedPlazaCollectionViaListaPrecio = False
			_listaPrecioCollectionViaListaPrecio = New Integralab.ORM.CollectionClasses.ListaPrecioCollection(New ListaPrecioEntityFactory())
			_alwaysFetchListaPrecioCollectionViaListaPrecio = False
			_alreadyFetchedListaPrecioCollectionViaListaPrecio = False


			
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

			_fieldsCustomProperties.Add("Descripcion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DescripcionCorta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Observaciones", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaAlta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("UsuarioAlta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("UsuarioBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ObservacionesBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EsCredito", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EsCreditoNormal", fieldHashtable)
		End Sub





		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="codigo">PK value for TipoVenta which data should be fetched into this TipoVenta Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(codigo As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(TipoVentaFieldIndex.Codigo)).ForcedCurrentValueWrite(codigo)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateTipoVentaDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New TipoVentaEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As TipoVentaRelations
			Get	
				Return New TipoVentaRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ListaPrecio' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathListaPrecio() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ListaPrecioCollection(), _
					TipoVentaEntity.Relations.ListaPrecioEntityUsingLpidTipoVenta, _
					CType(Integralab.ORM.EntityType.TipoVentaEntity, Integer), CType(Integralab.ORM.EntityType.ListaPrecioEntity, Integer), 0, Nothing, Nothing, Nothing, "ListaPrecio", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Plaza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPlazaCollectionViaListaPrecio() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(TipoVentaEntity.Relations.ListaPrecioEntityUsingLpidTipoVenta, "__TipoVentaEntity__", String.Empty, JoinHint.None)
				relations.Add(ListaPrecioEntity.Relations.PlazaEntityUsingPlaza)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PlazaCollection(), _
					TipoVentaEntity.Relations.ListaPrecioEntityUsingLpidTipoVenta, _
					CType(Integralab.ORM.EntityType.TipoVentaEntity, Integer), CType(Integralab.ORM.EntityType.PlazaEntity, Integer), 0, Nothing, Nothing, relations, "PlazaCollectionViaListaPrecio", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ListaPrecio' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathListaPrecioCollectionViaListaPrecio() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(TipoVentaEntity.Relations.ListaPrecioEntityUsingLpidTipoVenta, "__TipoVentaEntity__", String.Empty, JoinHint.None)
				relations.Add(ListaPrecioEntity.Relations.ListaPrecioEntityUsingListaBase)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ListaPrecioCollection(), _
					TipoVentaEntity.Relations.ListaPrecioEntityUsingLpidTipoVenta, _
					CType(Integralab.ORM.EntityType.TipoVentaEntity, Integer), CType(Integralab.ORM.EntityType.ListaPrecioEntity, Integer), 0, Nothing, Nothing, relations, "ListaPrecioCollectionViaListaPrecio", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "TipoVentaEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return TipoVentaEntity.CustomProperties
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
				Return TipoVentaEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The Codigo property of the Entity TipoVenta<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVentasTipoVenta"."Codigo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [Codigo]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoVentaFieldIndex.Codigo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(TipoVentaFieldIndex.Codigo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Descripcion property of the Entity TipoVenta<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVentasTipoVenta"."Descripcion"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Descripcion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoVentaFieldIndex.Descripcion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(TipoVentaFieldIndex.Descripcion, Integer), value)
			End Set
		End Property
	
		''' <summary>The DescripcionCorta property of the Entity TipoVenta<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVentasTipoVenta"."DescripcionCorta"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DescripcionCorta]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoVentaFieldIndex.DescripcionCorta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(TipoVentaFieldIndex.DescripcionCorta, Integer), value)
			End Set
		End Property
	
		''' <summary>The Observaciones property of the Entity TipoVenta<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVentasTipoVenta"."Obsevaciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 200<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Observaciones]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoVentaFieldIndex.Observaciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(TipoVentaFieldIndex.Observaciones, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaAlta property of the Entity TipoVenta<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVentasTipoVenta"."FechaAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaAlta]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoVentaFieldIndex.FechaAlta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(TipoVentaFieldIndex.FechaAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity TipoVenta<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVentasTipoVenta"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoVentaFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(TipoVentaFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The UsuarioAlta property of the Entity TipoVenta<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVentasTipoVenta"."UsuarioAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [UsuarioAlta]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoVentaFieldIndex.UsuarioAlta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(TipoVentaFieldIndex.UsuarioAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The UsuarioBaja property of the Entity TipoVenta<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVentasTipoVenta"."UsuarioBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [UsuarioBaja]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoVentaFieldIndex.UsuarioBaja, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(TipoVentaFieldIndex.UsuarioBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The ObservacionesBaja property of the Entity TipoVenta<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVentasTipoVenta"."ObservacionesBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 200<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [ObservacionesBaja]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoVentaFieldIndex.ObservacionesBaja, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(TipoVentaFieldIndex.ObservacionesBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaBaja property of the Entity TipoVenta<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVentasTipoVenta"."FechaBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaBaja]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoVentaFieldIndex.FechaBaja, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(TipoVentaFieldIndex.FechaBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The EsCredito property of the Entity TipoVenta<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVentasTipoVenta"."EsCredito"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [EsCredito]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoVentaFieldIndex.EsCredito, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(TipoVentaFieldIndex.EsCredito, Integer), value)
			End Set
		End Property
	
		''' <summary>The EsCreditoNormal property of the Entity TipoVenta<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatVentasTipoVenta"."EsCreditoNormal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [EsCreditoNormal]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(TipoVentaFieldIndex.EsCreditoNormal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(TipoVentaFieldIndex.EsCreditoNormal, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'ListaPrecioEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiListaPrecio()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ListaPrecio]() As Integralab.ORM.CollectionClasses.ListaPrecioCollection
			Get
				Return GetMultiListaPrecio(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ListaPrecio. When set to true, ListaPrecio is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ListaPrecio is accessed. You can always execute
		''' a forced fetch by calling GetMultiListaPrecio(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchListaPrecio As Boolean
			Get
				Return _alwaysFetchListaPrecio
			End Get
			Set
				_alwaysFetchListaPrecio = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'PlazaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPlazaCollectionViaListaPrecio()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [PlazaCollectionViaListaPrecio]() As Integralab.ORM.CollectionClasses.PlazaCollection
			Get
				Return GetMultiPlazaCollectionViaListaPrecio(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for PlazaCollectionViaListaPrecio. When set to true, PlazaCollectionViaListaPrecio is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PlazaCollectionViaListaPrecio is accessed. You can always execute
		''' a forced fetch by calling GetMultiPlazaCollectionViaListaPrecio(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPlazaCollectionViaListaPrecio As Boolean
			Get
				Return _alwaysFetchPlazaCollectionViaListaPrecio
			End Get
			Set
				_alwaysFetchPlazaCollectionViaListaPrecio = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ListaPrecioEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiListaPrecioCollectionViaListaPrecio()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ListaPrecioCollectionViaListaPrecio]() As Integralab.ORM.CollectionClasses.ListaPrecioCollection
			Get
				Return GetMultiListaPrecioCollectionViaListaPrecio(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ListaPrecioCollectionViaListaPrecio. When set to true, ListaPrecioCollectionViaListaPrecio is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ListaPrecioCollectionViaListaPrecio is accessed. You can always execute
		''' a forced fetch by calling GetMultiListaPrecioCollectionViaListaPrecio(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchListaPrecioCollectionViaListaPrecio As Boolean
			Get
				Return _alwaysFetchListaPrecioCollectionViaListaPrecio
			End Get
			Set
				_alwaysFetchListaPrecioCollectionViaListaPrecio = value
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
				Return CInt(Integralab.ORM.EntityType.TipoVentaEntity)
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
