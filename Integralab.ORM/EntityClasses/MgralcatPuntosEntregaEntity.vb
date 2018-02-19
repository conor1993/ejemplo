' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: domingo, 18 de febrero de 2018 17:52:57
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
	''' <summary>Entity class which represents the entity 'MgralcatPuntosEntrega'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class MgralcatPuntosEntregaEntity 
#Else
	<Serializable()> _
	Public Class MgralcatPuntosEntregaEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _mscrelacionCortesClientes As Integralab.ORM.CollectionClasses.MscrelacionCortesClientesCollection
		Private _alwaysFetchMscrelacionCortesClientes, _alreadyFetchedMscrelacionCortesClientes As Boolean

		Private _estado As EstadoEntity
		Private _alwaysFetchEstado, _alreadyFetchedEstado, _estadoReturnsNewIfNotFound As Boolean
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
		''' <param name="idPuntoEntrega">PK value for MgralcatPuntosEntrega which data should be fetched into this MgralcatPuntosEntrega Object</param>
		Public Sub New(idPuntoEntrega As System.Int32)

			InitClassFetch(idPuntoEntrega, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idPuntoEntrega">PK value for MgralcatPuntosEntrega which data should be fetched into this MgralcatPuntosEntrega Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(idPuntoEntrega As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(idPuntoEntrega, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idPuntoEntrega">PK value for MgralcatPuntosEntrega which data should be fetched into this MgralcatPuntosEntrega Object</param>
		''' <param name="validator">The custom validator Object for this MgralcatPuntosEntregaEntity</param>
		Public Sub New(idPuntoEntrega As System.Int32, validator As IValidator)

			InitClassFetch(idPuntoEntrega, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_mscrelacionCortesClientes = CType(info.GetValue("_mscrelacionCortesClientes", GetType(Integralab.ORM.CollectionClasses.MscrelacionCortesClientesCollection)), Integralab.ORM.CollectionClasses.MscrelacionCortesClientesCollection)
			_alwaysFetchMscrelacionCortesClientes = info.GetBoolean("_alwaysFetchMscrelacionCortesClientes")
			_alreadyFetchedMscrelacionCortesClientes = info.GetBoolean("_alreadyFetchedMscrelacionCortesClientes")

			_estado = CType(info.GetValue("_estado", GetType(EstadoEntity)), EstadoEntity)
			If Not _estado Is Nothing Then
				AddHandler _estado.AfterSave, AddressOf OnEntityAfterSave
			End If
			_estadoReturnsNewIfNotFound = info.GetBoolean("_estadoReturnsNewIfNotFound")
			_alwaysFetchEstado = info.GetBoolean("_alwaysFetchEstado")
			_alreadyFetchedEstado = info.GetBoolean("_alreadyFetchedEstado")
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
			_alreadyFetchedMscrelacionCortesClientes = (_mscrelacionCortesClientes.Count > 0)

			_alreadyFetchedEstado = Not(_estado Is Nothing)
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
			info.AddValue("_mscrelacionCortesClientes", _mscrelacionCortesClientes)
			info.AddValue("_alwaysFetchMscrelacionCortesClientes", _alwaysFetchMscrelacionCortesClientes)
			info.AddValue("_alreadyFetchedMscrelacionCortesClientes", _alreadyFetchedMscrelacionCortesClientes)

			info.AddValue("_estado", _estado)
			info.AddValue("_estadoReturnsNewIfNotFound", _estadoReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchEstado", _alwaysFetchEstado)
			info.AddValue("_alreadyFetchedEstado", _alreadyFetchedEstado)
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
				Case "Estado"
					_alreadyFetchedEstado = True
					Me.Estado = CType(entity, EstadoEntity)
				Case "MfacCatClientes"
					_alreadyFetchedMfacCatClientes = True
					Me.MfacCatClientes = CType(entity, MfacCatClientesEntity)
				Case "MscrelacionCortesClientes"
					_alreadyFetchedMscrelacionCortesClientes = True
					If Not entity Is Nothing Then
						Me.MscrelacionCortesClientes.Add(CType(entity, MscrelacionCortesClientesEntity))
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
				Case "Estado"
					SetupSyncEstado(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MfacCatClientes"
					SetupSyncMfacCatClientes(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MscrelacionCortesClientes"
					_mscrelacionCortesClientes.Add(CType(relatedEntity, MscrelacionCortesClientesEntity))
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
				Case "Estado"
					DesetupSyncEstado(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MfacCatClientes"
					DesetupSyncMfacCatClientes(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MscrelacionCortesClientes"
					MyBase.PerformRelatedEntityRemoval(_mscrelacionCortesClientes, relatedEntity, signalRelatedEntityManyToOne)
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
			If Not _estado Is Nothing Then
				toReturn.Add(_estado)
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
			toReturn.Add(_mscrelacionCortesClientes)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idPuntoEntrega">PK value for MgralcatPuntosEntrega which data should be fetched into this MgralcatPuntosEntrega Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idPuntoEntrega As System.Int32) As Boolean
			Return FetchUsingPK(idPuntoEntrega, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idPuntoEntrega">PK value for MgralcatPuntosEntrega which data should be fetched into this MgralcatPuntosEntrega Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idPuntoEntrega As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(idPuntoEntrega, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idPuntoEntrega">PK value for MgralcatPuntosEntrega which data should be fetched into this MgralcatPuntosEntrega Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idPuntoEntrega As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(idPuntoEntrega, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.IdPuntoEntrega, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As MgralcatPuntosEntregaFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As MgralcatPuntosEntregaFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'MscrelacionCortesClientesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MscrelacionCortesClientesEntity'</returns>
		Public Function GetMultiMscrelacionCortesClientes(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MscrelacionCortesClientesCollection
			Return GetMultiMscrelacionCortesClientes(forceFetch, _mscrelacionCortesClientes.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MscrelacionCortesClientesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMscrelacionCortesClientes(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MscrelacionCortesClientesCollection
			Return GetMultiMscrelacionCortesClientes(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'MscrelacionCortesClientesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'MscrelacionCortesClientesEntity'</returns>
		Public Function GetMultiMscrelacionCortesClientes(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MscrelacionCortesClientesCollection
			Return GetMultiMscrelacionCortesClientes(forceFetch, _mscrelacionCortesClientes.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'MscrelacionCortesClientesEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMscrelacionCortesClientes(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.MscrelacionCortesClientesCollection
			If ( Not _alreadyFetchedMscrelacionCortesClientes Or forceFetch Or _alwaysFetchMscrelacionCortesClientes) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mscrelacionCortesClientes.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mscrelacionCortesClientes)
					End If
				End If
				_mscrelacionCortesClientes.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mscrelacionCortesClientes.EntityFactoryToUse = entityFactoryToUse
				End If
				_mscrelacionCortesClientes.GetMultiManyToOne(Nothing, Me, Nothing, Filter)
				_mscrelacionCortesClientes.SuppressClearInGetMulti = False
				_alreadyFetchedMscrelacionCortesClientes = True
			End If
			Return _mscrelacionCortesClientes
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MscrelacionCortesClientes'. These settings will be taken into account
		''' when the property MscrelacionCortesClientes is requested or GetMultiMscrelacionCortesClientes is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMscrelacionCortesClientes(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mscrelacionCortesClientes.SortClauses=sortClauses
			_mscrelacionCortesClientes.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	

		''' <summary>Retrieves the related entity of type 'EstadoEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'EstadoEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleEstado() As EstadoEntity
			Return GetSingleEstado(False)
		End Function

		''' <summary>Retrieves the related entity of type 'EstadoEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'EstadoEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleEstado(forceFetch As Boolean) As EstadoEntity
			If ( Not _alreadyFetchedEstado Or forceFetch Or _alwaysFetchEstado) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New EstadoEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(MgralcatPuntosEntregaEntity.Relations.EstadoEntityUsingIdEstado) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdEstado)
				End If
				If Not _estadoReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Estado = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), EstadoEntity)
					End If
					Me.Estado = newEntity
					_alreadyFetchedEstado = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _estado
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
				If MyBase.CheckIfLazyLoadingShouldOccur(MgralcatPuntosEntregaEntity.Relations.MfacCatClientesEntityUsingIdCliente) Then
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(MgralcatPuntosEntregaFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, MgralcatPuntosEntregaFieldIndex)
					Case MgralcatPuntosEntregaFieldIndex.IdEstado
						DesetupSyncEstado(True, False)
						_alreadyFetchedEstado = False









					Case MgralcatPuntosEntregaFieldIndex.IdCliente
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
			_mscrelacionCortesClientes.ActiveContext = MyBase.ActiveContext

		If Not _estado Is Nothing Then
				_estado.ActiveContext = MyBase.ActiveContext
			End If
		If Not _mfacCatClientes Is Nothing Then
				_mfacCatClientes.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As MgralcatPuntosEntregaDAO = CType(CreateDAOInstance(), MgralcatPuntosEntregaDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As MgralcatPuntosEntregaDAO = CType(CreateDAOInstance(), MgralcatPuntosEntregaDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As MgralcatPuntosEntregaDAO = CType(CreateDAOInstance(), MgralcatPuntosEntregaDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this MgralcatPuntosEntregaEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.MgralcatPuntosEntregaEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="idPuntoEntrega">PK value for MgralcatPuntosEntrega which data should be fetched into this MgralcatPuntosEntrega Object</param>
		''' <param name="validator">The validator Object for this MgralcatPuntosEntregaEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(idPuntoEntrega As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(idPuntoEntrega, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_mscrelacionCortesClientes = New Integralab.ORM.CollectionClasses.MscrelacionCortesClientesCollection(New MscrelacionCortesClientesEntityFactory())
			_mscrelacionCortesClientes.SetContainingEntityInfo(Me, "MgralcatPuntosEntrega")
			_alwaysFetchMscrelacionCortesClientes = False
			_alreadyFetchedMscrelacionCortesClientes = False

			_estado = Nothing
			_estadoReturnsNewIfNotFound = True
			_alwaysFetchEstado = False
			_alreadyFetchedEstado = False
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

			_fieldsCustomProperties.Add("IdEstado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdCiudad", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdPoblacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdPuntoEntrega", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Descripcion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Direccion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Colonia", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Telefono", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CodigoPostal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdCliente", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _estado</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncEstado(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _estado, AddressOf OnEstadoPropertyChanged, "Estado", MgralcatPuntosEntregaEntity.Relations.EstadoEntityUsingIdEstado, True, signalRelatedEntity, "MgralcatPuntosEntrega", resetFKFields, New Integer() { CInt(MgralcatPuntosEntregaFieldIndex.IdEstado) } )
			_estado = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _estado</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncEstado(relatedEntity As IEntity)
			DesetupSyncEstado(True, True)
			_estado = CType(relatedEntity, EstadoEntity)
			MyBase.PerformSetupSyncRelatedEntity( _estado, AddressOf OnEstadoPropertyChanged, "Estado", MgralcatPuntosEntregaEntity.Relations.EstadoEntityUsingIdEstado, True, _alreadyFetchedEstado, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnEstadoPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _mfacCatClientes</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMfacCatClientes(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _mfacCatClientes, AddressOf OnMfacCatClientesPropertyChanged, "MfacCatClientes", MgralcatPuntosEntregaEntity.Relations.MfacCatClientesEntityUsingIdCliente, True, signalRelatedEntity, "MgralcatPuntosEntrega", resetFKFields, New Integer() { CInt(MgralcatPuntosEntregaFieldIndex.IdCliente) } )
			_mfacCatClientes = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _mfacCatClientes</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMfacCatClientes(relatedEntity As IEntity)
			DesetupSyncMfacCatClientes(True, True)
			_mfacCatClientes = CType(relatedEntity, MfacCatClientesEntity)
			MyBase.PerformSetupSyncRelatedEntity( _mfacCatClientes, AddressOf OnMfacCatClientesPropertyChanged, "MfacCatClientes", MgralcatPuntosEntregaEntity.Relations.MfacCatClientesEntityUsingIdCliente, True, _alreadyFetchedMfacCatClientes, New String() {  } )
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
		''' <param name="idPuntoEntrega">PK value for MgralcatPuntosEntrega which data should be fetched into this MgralcatPuntosEntrega Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(idPuntoEntrega As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(MgralcatPuntosEntregaFieldIndex.IdPuntoEntrega)).ForcedCurrentValueWrite(idPuntoEntrega)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateMgralcatPuntosEntregaDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New MgralcatPuntosEntregaEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As MgralcatPuntosEntregaRelations
			Get	
				Return New MgralcatPuntosEntregaRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscrelacionCortesClientes' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscrelacionCortesClientes() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscrelacionCortesClientesCollection(), _
					MgralcatPuntosEntregaEntity.Relations.MscrelacionCortesClientesEntityUsingIdDestino, _
					CType(Integralab.ORM.EntityType.MgralcatPuntosEntregaEntity, Integer), CType(Integralab.ORM.EntityType.MscrelacionCortesClientesEntity, Integer), 0, Nothing, Nothing, Nothing, "MscrelacionCortesClientes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Estado' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathEstado() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.EstadoCollection(), _
					MgralcatPuntosEntregaEntity.Relations.EstadoEntityUsingIdEstado, _
					CType(Integralab.ORM.EntityType.MgralcatPuntosEntregaEntity, Integer), CType(Integralab.ORM.EntityType.EstadoEntity, Integer), 0, Nothing, Nothing, Nothing, "Estado", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MfacCatClientes' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMfacCatClientes() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MfacCatClientesCollection(), _
					MgralcatPuntosEntregaEntity.Relations.MfacCatClientesEntityUsingIdCliente, _
					CType(Integralab.ORM.EntityType.MgralcatPuntosEntregaEntity, Integer), CType(Integralab.ORM.EntityType.MfacCatClientesEntity, Integer), 0, Nothing, Nothing, Nothing, "MfacCatClientes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "MgralcatPuntosEntregaEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return MgralcatPuntosEntregaEntity.CustomProperties
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
				Return MgralcatPuntosEntregaEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The IdEstado property of the Entity MgralcatPuntosEntrega<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MGRALCatPuntosEntrega"."IdEstado"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdEstado]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MgralcatPuntosEntregaFieldIndex.IdEstado, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MgralcatPuntosEntregaFieldIndex.IdEstado, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdCiudad property of the Entity MgralcatPuntosEntrega<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MGRALCatPuntosEntrega"."IdCiudad"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdCiudad]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MgralcatPuntosEntregaFieldIndex.IdCiudad, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MgralcatPuntosEntregaFieldIndex.IdCiudad, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdPoblacion property of the Entity MgralcatPuntosEntrega<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MGRALCatPuntosEntrega"."IdPoblacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdPoblacion]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MgralcatPuntosEntregaFieldIndex.IdPoblacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MgralcatPuntosEntregaFieldIndex.IdPoblacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdPuntoEntrega property of the Entity MgralcatPuntosEntrega<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MGRALCatPuntosEntrega"."IdPuntoEntrega"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [IdPuntoEntrega]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MgralcatPuntosEntregaFieldIndex.IdPuntoEntrega, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MgralcatPuntosEntregaFieldIndex.IdPuntoEntrega, Integer), value)
			End Set
		End Property
	
		''' <summary>The Descripcion property of the Entity MgralcatPuntosEntrega<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MGRALCatPuntosEntrega"."Descripcion"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Descripcion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MgralcatPuntosEntregaFieldIndex.Descripcion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MgralcatPuntosEntregaFieldIndex.Descripcion, Integer), value)
			End Set
		End Property
	
		''' <summary>The Direccion property of the Entity MgralcatPuntosEntrega<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MGRALCatPuntosEntrega"."Direccion"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Direccion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MgralcatPuntosEntregaFieldIndex.Direccion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MgralcatPuntosEntregaFieldIndex.Direccion, Integer), value)
			End Set
		End Property
	
		''' <summary>The Colonia property of the Entity MgralcatPuntosEntrega<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MGRALCatPuntosEntrega"."Colonia"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 120<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Colonia]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MgralcatPuntosEntregaFieldIndex.Colonia, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MgralcatPuntosEntregaFieldIndex.Colonia, Integer), value)
			End Set
		End Property
	
		''' <summary>The Telefono property of the Entity MgralcatPuntosEntrega<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MGRALCatPuntosEntrega"."Telefono"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Telefono]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MgralcatPuntosEntregaFieldIndex.Telefono, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MgralcatPuntosEntregaFieldIndex.Telefono, Integer), value)
			End Set
		End Property
	
		''' <summary>The CodigoPostal property of the Entity MgralcatPuntosEntrega<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MGRALCatPuntosEntrega"."CodigoPostal"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CodigoPostal]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MgralcatPuntosEntregaFieldIndex.CodigoPostal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MgralcatPuntosEntregaFieldIndex.CodigoPostal, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity MgralcatPuntosEntrega<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MGRALCatPuntosEntrega"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 1<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MgralcatPuntosEntregaFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MgralcatPuntosEntregaFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdCliente property of the Entity MgralcatPuntosEntrega<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MGRALCatPuntosEntrega"."IdCliente"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdCliente]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MgralcatPuntosEntregaFieldIndex.IdCliente, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MgralcatPuntosEntregaFieldIndex.IdCliente, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'MscrelacionCortesClientesEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMscrelacionCortesClientes()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MscrelacionCortesClientes]() As Integralab.ORM.CollectionClasses.MscrelacionCortesClientesCollection
			Get
				Return GetMultiMscrelacionCortesClientes(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MscrelacionCortesClientes. When set to true, MscrelacionCortesClientes is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MscrelacionCortesClientes is accessed. You can always execute
		''' a forced fetch by calling GetMultiMscrelacionCortesClientes(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMscrelacionCortesClientes As Boolean
			Get
				Return _alwaysFetchMscrelacionCortesClientes
			End Get
			Set
				_alwaysFetchMscrelacionCortesClientes = value
			End Set	
		End Property
	
	
	
		''' <summary>Gets / sets related entity of type 'EstadoEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleEstado()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Estado]() As EstadoEntity
			Get
				Return GetSingleEstado(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncEstado(value)
				Else
					If value Is Nothing Then
						If Not _estado Is Nothing Then
							_estado.UnsetRelatedEntity(Me, "MgralcatPuntosEntrega")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "MgralcatPuntosEntrega")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Estado. When set to true, Estado is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Estado is accessed. You can always execute
		''' a forced fetch by calling GetSingleEstado(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchEstado As Boolean
			Get
				Return _alwaysFetchEstado
			End Get
			Set
				_alwaysFetchEstado = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Estado is not found
		''' in the database. When set to true, Estado will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property EstadoReturnsNewIfNotFound As Boolean
			Get
				Return _estadoReturnsNewIfNotFound
			End Get
			Set
				_estadoReturnsNewIfNotFound = value
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
							_mfacCatClientes.UnsetRelatedEntity(Me, "MgralcatPuntosEntrega")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "MgralcatPuntosEntrega")
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
				Return CInt(Integralab.ORM.EntityType.MgralcatPuntosEntregaEntity)
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
