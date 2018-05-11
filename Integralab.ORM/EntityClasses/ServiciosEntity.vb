' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 30 de abril de 2018 09:07:32
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
	''' <summary>Entity class which represents the entity 'Servicios'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class ServiciosEntity 
#Else
	<Serializable()> _
	Public Class ServiciosEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _serviciosPorSacrificio As Integralab.ORM.CollectionClasses.ServiciosPorSacrificioCollection
		Private _alwaysFetchServiciosPorSacrificio, _alreadyFetchedServiciosPorSacrificio As Boolean
		Private _serviciosXembarque As Integralab.ORM.CollectionClasses.ServiciosXembarqueCollection
		Private _alwaysFetchServiciosXembarque, _alreadyFetchedServiciosXembarque As Boolean
		Private _mfacEmbarquesCabCollectionViaServiciosXembarque As Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection
		Private _alwaysFetchMfacEmbarquesCabCollectionViaServiciosXembarque, _alreadyFetchedMfacEmbarquesCabCollectionViaServiciosXembarque As Boolean



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
		''' <param name="codigo">PK value for Servicios which data should be fetched into this Servicios Object</param>
		Public Sub New(codigo As System.Int16)

			InitClassFetch(codigo, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for Servicios which data should be fetched into this Servicios Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(codigo As System.Int16, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(codigo, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for Servicios which data should be fetched into this Servicios Object</param>
		''' <param name="validator">The custom validator Object for this ServiciosEntity</param>
		Public Sub New(codigo As System.Int16, validator As IValidator)

			InitClassFetch(codigo, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_serviciosPorSacrificio = CType(info.GetValue("_serviciosPorSacrificio", GetType(Integralab.ORM.CollectionClasses.ServiciosPorSacrificioCollection)), Integralab.ORM.CollectionClasses.ServiciosPorSacrificioCollection)
			_alwaysFetchServiciosPorSacrificio = info.GetBoolean("_alwaysFetchServiciosPorSacrificio")
			_alreadyFetchedServiciosPorSacrificio = info.GetBoolean("_alreadyFetchedServiciosPorSacrificio")
			_serviciosXembarque = CType(info.GetValue("_serviciosXembarque", GetType(Integralab.ORM.CollectionClasses.ServiciosXembarqueCollection)), Integralab.ORM.CollectionClasses.ServiciosXembarqueCollection)
			_alwaysFetchServiciosXembarque = info.GetBoolean("_alwaysFetchServiciosXembarque")
			_alreadyFetchedServiciosXembarque = info.GetBoolean("_alreadyFetchedServiciosXembarque")
			_mfacEmbarquesCabCollectionViaServiciosXembarque = CType(info.GetValue("_mfacEmbarquesCabCollectionViaServiciosXembarque", GetType(Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection)), Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection)
			_alwaysFetchMfacEmbarquesCabCollectionViaServiciosXembarque = info.GetBoolean("_alwaysFetchMfacEmbarquesCabCollectionViaServiciosXembarque")
			_alreadyFetchedMfacEmbarquesCabCollectionViaServiciosXembarque = info.GetBoolean("_alreadyFetchedMfacEmbarquesCabCollectionViaServiciosXembarque")


			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedServiciosPorSacrificio = (_serviciosPorSacrificio.Count > 0)
			_alreadyFetchedServiciosXembarque = (_serviciosXembarque.Count > 0)
			_alreadyFetchedMfacEmbarquesCabCollectionViaServiciosXembarque = (_mfacEmbarquesCabCollectionViaServiciosXembarque.Count > 0)


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
			info.AddValue("_serviciosPorSacrificio", _serviciosPorSacrificio)
			info.AddValue("_alwaysFetchServiciosPorSacrificio", _alwaysFetchServiciosPorSacrificio)
			info.AddValue("_alreadyFetchedServiciosPorSacrificio", _alreadyFetchedServiciosPorSacrificio)
			info.AddValue("_serviciosXembarque", _serviciosXembarque)
			info.AddValue("_alwaysFetchServiciosXembarque", _alwaysFetchServiciosXembarque)
			info.AddValue("_alreadyFetchedServiciosXembarque", _alreadyFetchedServiciosXembarque)
			info.AddValue("_mfacEmbarquesCabCollectionViaServiciosXembarque", _mfacEmbarquesCabCollectionViaServiciosXembarque)
			info.AddValue("_alwaysFetchMfacEmbarquesCabCollectionViaServiciosXembarque", _alwaysFetchMfacEmbarquesCabCollectionViaServiciosXembarque)
			info.AddValue("_alreadyFetchedMfacEmbarquesCabCollectionViaServiciosXembarque", _alreadyFetchedMfacEmbarquesCabCollectionViaServiciosXembarque)


			
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

				Case "ServiciosPorSacrificio"
					_alreadyFetchedServiciosPorSacrificio = True
					If Not entity Is Nothing Then
						Me.ServiciosPorSacrificio.Add(CType(entity, ServiciosPorSacrificioEntity))
					End If
				Case "ServiciosXembarque"
					_alreadyFetchedServiciosXembarque = True
					If Not entity Is Nothing Then
						Me.ServiciosXembarque.Add(CType(entity, ServiciosXembarqueEntity))
					End If
				Case "MfacEmbarquesCabCollectionViaServiciosXembarque"
					_alreadyFetchedMfacEmbarquesCabCollectionViaServiciosXembarque = True
					If Not entity Is Nothing Then
						Me.MfacEmbarquesCabCollectionViaServiciosXembarque.Add(CType(entity, MfacEmbarquesCabEntity))
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

				Case "ServiciosPorSacrificio"
					_serviciosPorSacrificio.Add(CType(relatedEntity, ServiciosPorSacrificioEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "ServiciosXembarque"
					_serviciosXembarque.Add(CType(relatedEntity, ServiciosXembarqueEntity))
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

				Case "ServiciosPorSacrificio"
					MyBase.PerformRelatedEntityRemoval(_serviciosPorSacrificio, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "ServiciosXembarque"
					MyBase.PerformRelatedEntityRemoval(_serviciosXembarque, relatedEntity, signalRelatedEntityManyToOne)
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
			toReturn.Add(_serviciosPorSacrificio)
			toReturn.Add(_serviciosXembarque)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for Servicios which data should be fetched into this Servicios Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int16) As Boolean
			Return FetchUsingPK(codigo, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for Servicios which data should be fetched into this Servicios Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int16, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(codigo, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for Servicios which data should be fetched into this Servicios Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int16, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As ServiciosFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As ServiciosFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'ServiciosPorSacrificioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ServiciosPorSacrificioEntity'</returns>
		Public Function GetMultiServiciosPorSacrificio(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ServiciosPorSacrificioCollection
			Return GetMultiServiciosPorSacrificio(forceFetch, _serviciosPorSacrificio.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ServiciosPorSacrificioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiServiciosPorSacrificio(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ServiciosPorSacrificioCollection
			Return GetMultiServiciosPorSacrificio(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ServiciosPorSacrificioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'ServiciosPorSacrificioEntity'</returns>
		Public Function GetMultiServiciosPorSacrificio(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ServiciosPorSacrificioCollection
			Return GetMultiServiciosPorSacrificio(forceFetch, _serviciosPorSacrificio.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'ServiciosPorSacrificioEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiServiciosPorSacrificio(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ServiciosPorSacrificioCollection
			If ( Not _alreadyFetchedServiciosPorSacrificio Or forceFetch Or _alwaysFetchServiciosPorSacrificio) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _serviciosPorSacrificio.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_serviciosPorSacrificio)
					End If
				End If
				_serviciosPorSacrificio.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_serviciosPorSacrificio.EntityFactoryToUse = entityFactoryToUse
				End If
				_serviciosPorSacrificio.GetMultiManyToOne(Me, Filter)
				_serviciosPorSacrificio.SuppressClearInGetMulti = False
				_alreadyFetchedServiciosPorSacrificio = True
			End If
			Return _serviciosPorSacrificio
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ServiciosPorSacrificio'. These settings will be taken into account
		''' when the property ServiciosPorSacrificio is requested or GetMultiServiciosPorSacrificio is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersServiciosPorSacrificio(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_serviciosPorSacrificio.SortClauses=sortClauses
			_serviciosPorSacrificio.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'ServiciosXembarqueEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ServiciosXembarqueEntity'</returns>
		Public Function GetMultiServiciosXembarque(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ServiciosXembarqueCollection
			Return GetMultiServiciosXembarque(forceFetch, _serviciosXembarque.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ServiciosXembarqueEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiServiciosXembarque(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ServiciosXembarqueCollection
			Return GetMultiServiciosXembarque(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'ServiciosXembarqueEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'ServiciosXembarqueEntity'</returns>
		Public Function GetMultiServiciosXembarque(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ServiciosXembarqueCollection
			Return GetMultiServiciosXembarque(forceFetch, _serviciosXembarque.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'ServiciosXembarqueEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiServiciosXembarque(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.ServiciosXembarqueCollection
			If ( Not _alreadyFetchedServiciosXembarque Or forceFetch Or _alwaysFetchServiciosXembarque) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _serviciosXembarque.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_serviciosXembarque)
					End If
				End If
				_serviciosXembarque.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_serviciosXembarque.EntityFactoryToUse = entityFactoryToUse
				End If
				_serviciosXembarque.GetMultiManyToOne(Me, Nothing, Nothing, Filter)
				_serviciosXembarque.SuppressClearInGetMulti = False
				_alreadyFetchedServiciosXembarque = True
			End If
			Return _serviciosXembarque
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ServiciosXembarque'. These settings will be taken into account
		''' when the property ServiciosXembarque is requested or GetMultiServiciosXembarque is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersServiciosXembarque(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_serviciosXembarque.SortClauses=sortClauses
			_serviciosXembarque.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'MfacEmbarquesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MfacEmbarquesCabEntity'</returns>
		Public Function GetMultiMfacEmbarquesCabCollectionViaServiciosXembarque(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection
			Return GetMultiMfacEmbarquesCabCollectionViaServiciosXembarque(forceFetch, _mfacEmbarquesCabCollectionViaServiciosXembarque.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'MfacEmbarquesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMfacEmbarquesCabCollectionViaServiciosXembarque(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection
			If ( Not _alreadyFetchedMfacEmbarquesCabCollectionViaServiciosXembarque Or forceFetch Or _alwaysFetchMfacEmbarquesCabCollectionViaServiciosXembarque) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mfacEmbarquesCabCollectionViaServiciosXembarque.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mfacEmbarquesCabCollectionViaServiciosXembarque)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ServiciosEntity.Relations.ServiciosXembarqueEntityUsingIdServicio, "__ServiciosEntity__", "ServiciosXembarque_", JoinHint.None)
				relations.Add(ServiciosXembarqueEntity.Relations.MfacEmbarquesCabEntityUsingFoloEmbarque, "ServiciosXembarque_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ServiciosFieldIndex.Codigo), ComparisonOperator.Equal, Me.Codigo))
				_mfacEmbarquesCabCollectionViaServiciosXembarque.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mfacEmbarquesCabCollectionViaServiciosXembarque.EntityFactoryToUse = entityFactoryToUse
				End If
				_mfacEmbarquesCabCollectionViaServiciosXembarque.GetMulti(Filter, relations)
				_mfacEmbarquesCabCollectionViaServiciosXembarque.SuppressClearInGetMulti = False
				_alreadyFetchedMfacEmbarquesCabCollectionViaServiciosXembarque = True
			End If
			Return _mfacEmbarquesCabCollectionViaServiciosXembarque
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MfacEmbarquesCabCollectionViaServiciosXembarque'. These settings will be taken into account
		''' when the property MfacEmbarquesCabCollectionViaServiciosXembarque is requested or GetMultiMfacEmbarquesCabCollectionViaServiciosXembarque is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMfacEmbarquesCabCollectionViaServiciosXembarque(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mfacEmbarquesCabCollectionViaServiciosXembarque.SortClauses=sortClauses
			_mfacEmbarquesCabCollectionViaServiciosXembarque.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(ServiciosFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, ServiciosFieldIndex)






					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_serviciosPorSacrificio.ActiveContext = MyBase.ActiveContext
			_serviciosXembarque.ActiveContext = MyBase.ActiveContext
			_mfacEmbarquesCabCollectionViaServiciosXembarque.ActiveContext = MyBase.ActiveContext



		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As ServiciosDAO = CType(CreateDAOInstance(), ServiciosDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As ServiciosDAO = CType(CreateDAOInstance(), ServiciosDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As ServiciosDAO = CType(CreateDAOInstance(), ServiciosDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this ServiciosEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ServiciosEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="codigo">PK value for Servicios which data should be fetched into this Servicios Object</param>
		''' <param name="validator">The validator Object for this ServiciosEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(codigo As System.Int16, validator As IValidator, prefetchPathToUse As IPrefetchPath)
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
			_serviciosPorSacrificio = New Integralab.ORM.CollectionClasses.ServiciosPorSacrificioCollection(New ServiciosPorSacrificioEntityFactory())
			_serviciosPorSacrificio.SetContainingEntityInfo(Me, "Servicios")
			_alwaysFetchServiciosPorSacrificio = False
			_alreadyFetchedServiciosPorSacrificio = False
			_serviciosXembarque = New Integralab.ORM.CollectionClasses.ServiciosXembarqueCollection(New ServiciosXembarqueEntityFactory())
			_serviciosXembarque.SetContainingEntityInfo(Me, "Servicios")
			_alwaysFetchServiciosXembarque = False
			_alreadyFetchedServiciosXembarque = False
			_mfacEmbarquesCabCollectionViaServiciosXembarque = New Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection(New MfacEmbarquesCabEntityFactory())
			_alwaysFetchMfacEmbarquesCabCollectionViaServiciosXembarque = False
			_alreadyFetchedMfacEmbarquesCabCollectionViaServiciosXembarque = False


			
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

			_fieldsCustomProperties.Add("NomServicio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TipoServicio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaAlta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Costo", fieldHashtable)
		End Sub





		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="codigo">PK value for Servicios which data should be fetched into this Servicios Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(codigo As System.Int16, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(ServiciosFieldIndex.Codigo)).ForcedCurrentValueWrite(codigo)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateServiciosDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New ServiciosEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As ServiciosRelations
			Get	
				Return New ServiciosRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiciosPorSacrificio' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathServiciosPorSacrificio() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ServiciosPorSacrificioCollection(), _
					ServiciosEntity.Relations.ServiciosPorSacrificioEntityUsingIdServicio, _
					CType(Integralab.ORM.EntityType.ServiciosEntity, Integer), CType(Integralab.ORM.EntityType.ServiciosPorSacrificioEntity, Integer), 0, Nothing, Nothing, Nothing, "ServiciosPorSacrificio", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ServiciosXembarque' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathServiciosXembarque() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ServiciosXembarqueCollection(), _
					ServiciosEntity.Relations.ServiciosXembarqueEntityUsingIdServicio, _
					CType(Integralab.ORM.EntityType.ServiciosEntity, Integer), CType(Integralab.ORM.EntityType.ServiciosXembarqueEntity, Integer), 0, Nothing, Nothing, Nothing, "ServiciosXembarque", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MfacEmbarquesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMfacEmbarquesCabCollectionViaServiciosXembarque() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ServiciosEntity.Relations.ServiciosXembarqueEntityUsingIdServicio, "__ServiciosEntity__", String.Empty, JoinHint.None)
				relations.Add(ServiciosXembarqueEntity.Relations.MfacEmbarquesCabEntityUsingFoloEmbarque)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection(), _
					ServiciosEntity.Relations.ServiciosXembarqueEntityUsingIdServicio, _
					CType(Integralab.ORM.EntityType.ServiciosEntity, Integer), CType(Integralab.ORM.EntityType.MfacEmbarquesCabEntity, Integer), 0, Nothing, Nothing, relations, "MfacEmbarquesCabCollectionViaServiciosXembarque", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "ServiciosEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return ServiciosEntity.CustomProperties
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
				Return ServiciosEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The Codigo property of the Entity Servicios<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CatServicios"."Cve_Servicio"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [Codigo]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ServiciosFieldIndex.Codigo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(ServiciosFieldIndex.Codigo, Integer), value)
			End Set
		End Property
	
		''' <summary>The NomServicio property of the Entity Servicios<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CatServicios"."Nom_Servicio"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [NomServicio]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ServiciosFieldIndex.NomServicio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(ServiciosFieldIndex.NomServicio, Integer), value)
			End Set
		End Property
	
		''' <summary>The TipoServicio property of the Entity Servicios<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CatServicios"."TipoServicio"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [TipoServicio]() As Nullable(Of System.Int16)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ServiciosFieldIndex.TipoServicio, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int16))
			End Get
			Set
				SetNewFieldValue(CType(ServiciosFieldIndex.TipoServicio, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity Servicios<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CatServicios"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ServiciosFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(ServiciosFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaAlta property of the Entity Servicios<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CatServicios"."FechaAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaAlta]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ServiciosFieldIndex.FechaAlta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(ServiciosFieldIndex.FechaAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The Costo property of the Entity Servicios<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "CatServicios"."Costo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Costo]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ServiciosFieldIndex.Costo, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(ServiciosFieldIndex.Costo, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'ServiciosPorSacrificioEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiServiciosPorSacrificio()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ServiciosPorSacrificio]() As Integralab.ORM.CollectionClasses.ServiciosPorSacrificioCollection
			Get
				Return GetMultiServiciosPorSacrificio(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ServiciosPorSacrificio. When set to true, ServiciosPorSacrificio is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ServiciosPorSacrificio is accessed. You can always execute
		''' a forced fetch by calling GetMultiServiciosPorSacrificio(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchServiciosPorSacrificio As Boolean
			Get
				Return _alwaysFetchServiciosPorSacrificio
			End Get
			Set
				_alwaysFetchServiciosPorSacrificio = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'ServiciosXembarqueEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiServiciosXembarque()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ServiciosXembarque]() As Integralab.ORM.CollectionClasses.ServiciosXembarqueCollection
			Get
				Return GetMultiServiciosXembarque(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ServiciosXembarque. When set to true, ServiciosXembarque is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ServiciosXembarque is accessed. You can always execute
		''' a forced fetch by calling GetMultiServiciosXembarque(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchServiciosXembarque As Boolean
			Get
				Return _alwaysFetchServiciosXembarque
			End Get
			Set
				_alwaysFetchServiciosXembarque = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'MfacEmbarquesCabEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMfacEmbarquesCabCollectionViaServiciosXembarque()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MfacEmbarquesCabCollectionViaServiciosXembarque]() As Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection
			Get
				Return GetMultiMfacEmbarquesCabCollectionViaServiciosXembarque(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MfacEmbarquesCabCollectionViaServiciosXembarque. When set to true, MfacEmbarquesCabCollectionViaServiciosXembarque is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MfacEmbarquesCabCollectionViaServiciosXembarque is accessed. You can always execute
		''' a forced fetch by calling GetMultiMfacEmbarquesCabCollectionViaServiciosXembarque(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMfacEmbarquesCabCollectionViaServiciosXembarque As Boolean
			Get
				Return _alwaysFetchMfacEmbarquesCabCollectionViaServiciosXembarque
			End Get
			Set
				_alwaysFetchMfacEmbarquesCabCollectionViaServiciosXembarque = value
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
				Return CInt(Integralab.ORM.EntityType.ServiciosEntity)
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
