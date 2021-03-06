﻿' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 12 de julio de 2018 17:43:08
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
	''' <summary>Entity class which represents the entity 'CatNutrientes'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class CatNutrientesEntity 
#Else
	<Serializable()> _
	Public Class CatNutrientesEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _detAlimentos As Integralab.ORM.CollectionClasses.DetAlimentosCollection
		Private _alwaysFetchDetAlimentos, _alreadyFetchedDetAlimentos As Boolean
		Private _productoCollectionViaDetAlimentos As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaDetAlimentos, _alreadyFetchedProductoCollectionViaDetAlimentos As Boolean
		Private _unidadMedida As UnidadMedidaEntity
		Private _alwaysFetchUnidadMedida, _alreadyFetchedUnidadMedida, _unidadMedidaReturnsNewIfNotFound As Boolean


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
		''' <param name="cveNutriente">PK value for CatNutrientes which data should be fetched into this CatNutrientes Object</param>
		Public Sub New(cveNutriente As System.Int32)

			InitClassFetch(cveNutriente, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="cveNutriente">PK value for CatNutrientes which data should be fetched into this CatNutrientes Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(cveNutriente As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(cveNutriente, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="cveNutriente">PK value for CatNutrientes which data should be fetched into this CatNutrientes Object</param>
		''' <param name="validator">The custom validator Object for this CatNutrientesEntity</param>
		Public Sub New(cveNutriente As System.Int32, validator As IValidator)

			InitClassFetch(cveNutriente, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_detAlimentos = CType(info.GetValue("_detAlimentos", GetType(Integralab.ORM.CollectionClasses.DetAlimentosCollection)), Integralab.ORM.CollectionClasses.DetAlimentosCollection)
			_alwaysFetchDetAlimentos = info.GetBoolean("_alwaysFetchDetAlimentos")
			_alreadyFetchedDetAlimentos = info.GetBoolean("_alreadyFetchedDetAlimentos")
			_productoCollectionViaDetAlimentos = CType(info.GetValue("_productoCollectionViaDetAlimentos", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaDetAlimentos = info.GetBoolean("_alwaysFetchProductoCollectionViaDetAlimentos")
			_alreadyFetchedProductoCollectionViaDetAlimentos = info.GetBoolean("_alreadyFetchedProductoCollectionViaDetAlimentos")
			_unidadMedida = CType(info.GetValue("_unidadMedida", GetType(UnidadMedidaEntity)), UnidadMedidaEntity)
			If Not _unidadMedida Is Nothing Then
				AddHandler _unidadMedida.AfterSave, AddressOf OnEntityAfterSave
			End If
			_unidadMedidaReturnsNewIfNotFound = info.GetBoolean("_unidadMedidaReturnsNewIfNotFound")
			_alwaysFetchUnidadMedida = info.GetBoolean("_alwaysFetchUnidadMedida")
			_alreadyFetchedUnidadMedida = info.GetBoolean("_alreadyFetchedUnidadMedida")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedDetAlimentos = (_detAlimentos.Count > 0)
			_alreadyFetchedProductoCollectionViaDetAlimentos = (_productoCollectionViaDetAlimentos.Count > 0)
			_alreadyFetchedUnidadMedida = Not(_unidadMedida Is Nothing)

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
			info.AddValue("_detAlimentos", _detAlimentos)
			info.AddValue("_alwaysFetchDetAlimentos", _alwaysFetchDetAlimentos)
			info.AddValue("_alreadyFetchedDetAlimentos", _alreadyFetchedDetAlimentos)
			info.AddValue("_productoCollectionViaDetAlimentos", _productoCollectionViaDetAlimentos)
			info.AddValue("_alwaysFetchProductoCollectionViaDetAlimentos", _alwaysFetchProductoCollectionViaDetAlimentos)
			info.AddValue("_alreadyFetchedProductoCollectionViaDetAlimentos", _alreadyFetchedProductoCollectionViaDetAlimentos)
			info.AddValue("_unidadMedida", _unidadMedida)
			info.AddValue("_unidadMedidaReturnsNewIfNotFound", _unidadMedidaReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchUnidadMedida", _alwaysFetchUnidadMedida)
			info.AddValue("_alreadyFetchedUnidadMedida", _alreadyFetchedUnidadMedida)

			
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
				Case "UnidadMedida"
					_alreadyFetchedUnidadMedida = True
					Me.UnidadMedida = CType(entity, UnidadMedidaEntity)
				Case "DetAlimentos"
					_alreadyFetchedDetAlimentos = True
					If Not entity Is Nothing Then
						Me.DetAlimentos.Add(CType(entity, DetAlimentosEntity))
					End If
				Case "ProductoCollectionViaDetAlimentos"
					_alreadyFetchedProductoCollectionViaDetAlimentos = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaDetAlimentos.Add(CType(entity, ProductoEntity))
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
				Case "UnidadMedida"
					SetupSyncUnidadMedida(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "DetAlimentos"
					_detAlimentos.Add(CType(relatedEntity, DetAlimentosEntity))
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
				Case "UnidadMedida"
					DesetupSyncUnidadMedida(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "DetAlimentos"
					MyBase.PerformRelatedEntityRemoval(_detAlimentos, relatedEntity, signalRelatedEntityManyToOne)
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
			If Not _unidadMedida Is Nothing Then
				toReturn.Add(_unidadMedida)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_detAlimentos)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="cveNutriente">PK value for CatNutrientes which data should be fetched into this CatNutrientes Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(cveNutriente As System.Int32) As Boolean
			Return FetchUsingPK(cveNutriente, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="cveNutriente">PK value for CatNutrientes which data should be fetched into this CatNutrientes Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(cveNutriente As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(cveNutriente, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="cveNutriente">PK value for CatNutrientes which data should be fetched into this CatNutrientes Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(cveNutriente As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(cveNutriente, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.CveNutriente, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As CatNutrientesFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As CatNutrientesFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'DetAlimentosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'DetAlimentosEntity'</returns>
		Public Function GetMultiDetAlimentos(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.DetAlimentosCollection
			Return GetMultiDetAlimentos(forceFetch, _detAlimentos.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetAlimentosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiDetAlimentos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.DetAlimentosCollection
			Return GetMultiDetAlimentos(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'DetAlimentosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'DetAlimentosEntity'</returns>
		Public Function GetMultiDetAlimentos(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetAlimentosCollection
			Return GetMultiDetAlimentos(forceFetch, _detAlimentos.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'DetAlimentosEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiDetAlimentos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.DetAlimentosCollection
			If ( Not _alreadyFetchedDetAlimentos Or forceFetch Or _alwaysFetchDetAlimentos) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _detAlimentos.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_detAlimentos)
					End If
				End If
				_detAlimentos.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_detAlimentos.EntityFactoryToUse = entityFactoryToUse
				End If
				_detAlimentos.GetMultiManyToOne(Me, Nothing, Filter)
				_detAlimentos.SuppressClearInGetMulti = False
				_alreadyFetchedDetAlimentos = True
			End If
			Return _detAlimentos
		End Function

		''' <summary>Sets the collection parameters for the collection for 'DetAlimentos'. These settings will be taken into account
		''' when the property DetAlimentos is requested or GetMultiDetAlimentos is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersDetAlimentos(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_detAlimentos.SortClauses=sortClauses
			_detAlimentos.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViaDetAlimentos(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViaDetAlimentos(forceFetch, _productoCollectionViaDetAlimentos.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViaDetAlimentos(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViaDetAlimentos Or forceFetch Or _alwaysFetchProductoCollectionViaDetAlimentos) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViaDetAlimentos.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViaDetAlimentos)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CatNutrientesEntity.Relations.DetAlimentosEntityUsingCveNutriente, "__CatNutrientesEntity__", "DetAlimentos_", JoinHint.None)
				relations.Add(DetAlimentosEntity.Relations.ProductoEntityUsingCveAlimento, "DetAlimentos_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CatNutrientesFieldIndex.CveNutriente), ComparisonOperator.Equal, Me.CveNutriente))
				_productoCollectionViaDetAlimentos.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViaDetAlimentos.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViaDetAlimentos.GetMulti(Filter, relations)
				_productoCollectionViaDetAlimentos.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViaDetAlimentos = True
			End If
			Return _productoCollectionViaDetAlimentos
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViaDetAlimentos'. These settings will be taken into account
		''' when the property ProductoCollectionViaDetAlimentos is requested or GetMultiProductoCollectionViaDetAlimentos is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViaDetAlimentos(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViaDetAlimentos.SortClauses=sortClauses
			_productoCollectionViaDetAlimentos.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves the related entity of type 'UnidadMedidaEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'UnidadMedidaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleUnidadMedida() As UnidadMedidaEntity
			Return GetSingleUnidadMedida(False)
		End Function

		''' <summary>Retrieves the related entity of type 'UnidadMedidaEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'UnidadMedidaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleUnidadMedida(forceFetch As Boolean) As UnidadMedidaEntity
			If ( Not _alreadyFetchedUnidadMedida Or forceFetch Or _alwaysFetchUnidadMedida) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New UnidadMedidaEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(CatNutrientesEntity.Relations.UnidadMedidaEntityUsingUnidad) Then
					fetchResult = newEntity.FetchUsingPK(Me.Unidad)
				End If
				If Not _unidadMedidaReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.UnidadMedida = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), UnidadMedidaEntity)
					End If
					Me.UnidadMedida = newEntity
					_alreadyFetchedUnidadMedida = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _unidadMedida
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(CatNutrientesFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, CatNutrientesFieldIndex)


					Case CatNutrientesFieldIndex.Unidad
						DesetupSyncUnidadMedida(True, False)
						_alreadyFetchedUnidadMedida = False

					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_detAlimentos.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaDetAlimentos.ActiveContext = MyBase.ActiveContext
		If Not _unidadMedida Is Nothing Then
				_unidadMedida.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As CatNutrientesDAO = CType(CreateDAOInstance(), CatNutrientesDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As CatNutrientesDAO = CType(CreateDAOInstance(), CatNutrientesDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As CatNutrientesDAO = CType(CreateDAOInstance(), CatNutrientesDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this CatNutrientesEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CatNutrientesEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="cveNutriente">PK value for CatNutrientes which data should be fetched into this CatNutrientes Object</param>
		''' <param name="validator">The validator Object for this CatNutrientesEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(cveNutriente As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(cveNutriente, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_detAlimentos = New Integralab.ORM.CollectionClasses.DetAlimentosCollection(New DetAlimentosEntityFactory())
			_detAlimentos.SetContainingEntityInfo(Me, "CatNutrientes")
			_alwaysFetchDetAlimentos = False
			_alreadyFetchedDetAlimentos = False
			_productoCollectionViaDetAlimentos = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaDetAlimentos = False
			_alreadyFetchedProductoCollectionViaDetAlimentos = False
			_unidadMedida = Nothing
			_unidadMedidaReturnsNewIfNotFound = True
			_alwaysFetchUnidadMedida = False
			_alreadyFetchedUnidadMedida = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CveNutriente", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("NomNutriente", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Unidad", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _unidadMedida</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncUnidadMedida(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _unidadMedida, AddressOf OnUnidadMedidaPropertyChanged, "UnidadMedida", CatNutrientesEntity.Relations.UnidadMedidaEntityUsingUnidad, True, signalRelatedEntity, "CatNutrientes", resetFKFields, New Integer() { CInt(CatNutrientesFieldIndex.Unidad) } )
			_unidadMedida = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _unidadMedida</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncUnidadMedida(relatedEntity As IEntity)
			DesetupSyncUnidadMedida(True, True)
			_unidadMedida = CType(relatedEntity, UnidadMedidaEntity)
			MyBase.PerformSetupSyncRelatedEntity( _unidadMedida, AddressOf OnUnidadMedidaPropertyChanged, "UnidadMedida", CatNutrientesEntity.Relations.UnidadMedidaEntityUsingUnidad, True, _alreadyFetchedUnidadMedida, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnUnidadMedidaPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="cveNutriente">PK value for CatNutrientes which data should be fetched into this CatNutrientes Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(cveNutriente As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(CatNutrientesFieldIndex.CveNutriente)).ForcedCurrentValueWrite(cveNutriente)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateCatNutrientesDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New CatNutrientesEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As CatNutrientesRelations
			Get	
				Return New CatNutrientesRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'DetAlimentos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathDetAlimentos() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.DetAlimentosCollection(), _
					CatNutrientesEntity.Relations.DetAlimentosEntityUsingCveNutriente, _
					CType(Integralab.ORM.EntityType.CatNutrientesEntity, Integer), CType(Integralab.ORM.EntityType.DetAlimentosEntity, Integer), 0, Nothing, Nothing, Nothing, "DetAlimentos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaDetAlimentos() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CatNutrientesEntity.Relations.DetAlimentosEntityUsingCveNutriente, "__CatNutrientesEntity__", String.Empty, JoinHint.None)
				relations.Add(DetAlimentosEntity.Relations.ProductoEntityUsingCveAlimento)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					CatNutrientesEntity.Relations.DetAlimentosEntityUsingCveNutriente, _
					CType(Integralab.ORM.EntityType.CatNutrientesEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaDetAlimentos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'UnidadMedida' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathUnidadMedida() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.UnidadMedidaCollection(), _
					CatNutrientesEntity.Relations.UnidadMedidaEntityUsingUnidad, _
					CType(Integralab.ORM.EntityType.CatNutrientesEntity, Integer), CType(Integralab.ORM.EntityType.UnidadMedidaEntity, Integer), 0, Nothing, Nothing, Nothing, "UnidadMedida", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "CatNutrientesEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return CatNutrientesEntity.CustomProperties
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
				Return CatNutrientesEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The CveNutriente property of the Entity CatNutrientes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CatNutrientes"."Cve_Nutriente"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [CveNutriente]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CatNutrientesFieldIndex.CveNutriente, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(CatNutrientesFieldIndex.CveNutriente, Integer), value)
			End Set
		End Property
	
		''' <summary>The NomNutriente property of the Entity CatNutrientes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CatNutrientes"."Nom_Nutriente"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 60<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [NomNutriente]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CatNutrientesFieldIndex.NomNutriente, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CatNutrientesFieldIndex.NomNutriente, Integer), value)
			End Set
		End Property
	
		''' <summary>The Unidad property of the Entity CatNutrientes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CatNutrientes"."Unidad"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Unidad]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CatNutrientesFieldIndex.Unidad, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(CatNutrientesFieldIndex.Unidad, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity CatNutrientes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CatNutrientes"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 1<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CatNutrientesFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CatNutrientesFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'DetAlimentosEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDetAlimentos()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [DetAlimentos]() As Integralab.ORM.CollectionClasses.DetAlimentosCollection
			Get
				Return GetMultiDetAlimentos(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for DetAlimentos. When set to true, DetAlimentos is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time DetAlimentos is accessed. You can always execute
		''' a forced fetch by calling GetMultiDetAlimentos(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchDetAlimentos As Boolean
			Get
				Return _alwaysFetchDetAlimentos
			End Get
			Set
				_alwaysFetchDetAlimentos = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViaDetAlimentos()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViaDetAlimentos]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViaDetAlimentos(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViaDetAlimentos. When set to true, ProductoCollectionViaDetAlimentos is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViaDetAlimentos is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViaDetAlimentos(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViaDetAlimentos As Boolean
			Get
				Return _alwaysFetchProductoCollectionViaDetAlimentos
			End Get
			Set
				_alwaysFetchProductoCollectionViaDetAlimentos = value
			End Set	
		End Property
	
	
		''' <summary>Gets / sets related entity of type 'UnidadMedidaEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleUnidadMedida()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [UnidadMedida]() As UnidadMedidaEntity
			Get
				Return GetSingleUnidadMedida(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncUnidadMedida(value)
				Else
					If value Is Nothing Then
						If Not _unidadMedida Is Nothing Then
							_unidadMedida.UnsetRelatedEntity(Me, "CatNutrientes")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "CatNutrientes")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for UnidadMedida. When set to true, UnidadMedida is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time UnidadMedida is accessed. You can always execute
		''' a forced fetch by calling GetSingleUnidadMedida(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchUnidadMedida As Boolean
			Get
				Return _alwaysFetchUnidadMedida
			End Get
			Set
				_alwaysFetchUnidadMedida = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property UnidadMedida is not found
		''' in the database. When set to true, UnidadMedida will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property UnidadMedidaReturnsNewIfNotFound As Boolean
			Get
				Return _unidadMedidaReturnsNewIfNotFound
			End Get
			Set
				_unidadMedidaReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.CatNutrientesEntity)
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
