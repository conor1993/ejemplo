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
	''' <summary>Entity class which represents the entity 'DevolucionProductos'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class DevolucionProductosEntity 
#Else
	<Serializable()> _
	Public Class DevolucionProductosEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"


		Private _mfacCatClientes As MfacCatClientesEntity
		Private _alwaysFetchMfacCatClientes, _alreadyFetchedMfacCatClientes, _mfacCatClientesReturnsNewIfNotFound As Boolean
		Private _mfacEmbarquesCab As MfacEmbarquesCabEntity
		Private _alwaysFetchMfacEmbarquesCab, _alreadyFetchedMfacEmbarquesCab, _mfacEmbarquesCabReturnsNewIfNotFound As Boolean
		Private _msccatMotivoDevolucion As MsccatMotivoDevolucionEntity
		Private _alwaysFetchMsccatMotivoDevolucion, _alreadyFetchedMsccatMotivoDevolucion, _msccatMotivoDevolucionReturnsNewIfNotFound As Boolean
		Private _msccatProductos As MsccatProductosEntity
		Private _alwaysFetchMsccatProductos, _alreadyFetchedMsccatProductos, _msccatProductosReturnsNewIfNotFound As Boolean


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
		''' <param name="folio">PK value for DevolucionProductos which data should be fetched into this DevolucionProductos Object</param>
		Public Sub New(folio As System.String)

			InitClassFetch(folio, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folio">PK value for DevolucionProductos which data should be fetched into this DevolucionProductos Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(folio As System.String, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(folio, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folio">PK value for DevolucionProductos which data should be fetched into this DevolucionProductos Object</param>
		''' <param name="validator">The custom validator Object for this DevolucionProductosEntity</param>
		Public Sub New(folio As System.String, validator As IValidator)

			InitClassFetch(folio, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)


			_mfacCatClientes = CType(info.GetValue("_mfacCatClientes", GetType(MfacCatClientesEntity)), MfacCatClientesEntity)
			If Not _mfacCatClientes Is Nothing Then
				AddHandler _mfacCatClientes.AfterSave, AddressOf OnEntityAfterSave
			End If
			_mfacCatClientesReturnsNewIfNotFound = info.GetBoolean("_mfacCatClientesReturnsNewIfNotFound")
			_alwaysFetchMfacCatClientes = info.GetBoolean("_alwaysFetchMfacCatClientes")
			_alreadyFetchedMfacCatClientes = info.GetBoolean("_alreadyFetchedMfacCatClientes")
			_mfacEmbarquesCab = CType(info.GetValue("_mfacEmbarquesCab", GetType(MfacEmbarquesCabEntity)), MfacEmbarquesCabEntity)
			If Not _mfacEmbarquesCab Is Nothing Then
				AddHandler _mfacEmbarquesCab.AfterSave, AddressOf OnEntityAfterSave
			End If
			_mfacEmbarquesCabReturnsNewIfNotFound = info.GetBoolean("_mfacEmbarquesCabReturnsNewIfNotFound")
			_alwaysFetchMfacEmbarquesCab = info.GetBoolean("_alwaysFetchMfacEmbarquesCab")
			_alreadyFetchedMfacEmbarquesCab = info.GetBoolean("_alreadyFetchedMfacEmbarquesCab")
			_msccatMotivoDevolucion = CType(info.GetValue("_msccatMotivoDevolucion", GetType(MsccatMotivoDevolucionEntity)), MsccatMotivoDevolucionEntity)
			If Not _msccatMotivoDevolucion Is Nothing Then
				AddHandler _msccatMotivoDevolucion.AfterSave, AddressOf OnEntityAfterSave
			End If
			_msccatMotivoDevolucionReturnsNewIfNotFound = info.GetBoolean("_msccatMotivoDevolucionReturnsNewIfNotFound")
			_alwaysFetchMsccatMotivoDevolucion = info.GetBoolean("_alwaysFetchMsccatMotivoDevolucion")
			_alreadyFetchedMsccatMotivoDevolucion = info.GetBoolean("_alreadyFetchedMsccatMotivoDevolucion")
			_msccatProductos = CType(info.GetValue("_msccatProductos", GetType(MsccatProductosEntity)), MsccatProductosEntity)
			If Not _msccatProductos Is Nothing Then
				AddHandler _msccatProductos.AfterSave, AddressOf OnEntityAfterSave
			End If
			_msccatProductosReturnsNewIfNotFound = info.GetBoolean("_msccatProductosReturnsNewIfNotFound")
			_alwaysFetchMsccatProductos = info.GetBoolean("_alwaysFetchMsccatProductos")
			_alreadyFetchedMsccatProductos = info.GetBoolean("_alreadyFetchedMsccatProductos")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()


			_alreadyFetchedMfacCatClientes = Not(_mfacCatClientes Is Nothing)
			_alreadyFetchedMfacEmbarquesCab = Not(_mfacEmbarquesCab Is Nothing)
			_alreadyFetchedMsccatMotivoDevolucion = Not(_msccatMotivoDevolucion Is Nothing)
			_alreadyFetchedMsccatProductos = Not(_msccatProductos Is Nothing)

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


			info.AddValue("_mfacCatClientes", _mfacCatClientes)
			info.AddValue("_mfacCatClientesReturnsNewIfNotFound", _mfacCatClientesReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMfacCatClientes", _alwaysFetchMfacCatClientes)
			info.AddValue("_alreadyFetchedMfacCatClientes", _alreadyFetchedMfacCatClientes)
			info.AddValue("_mfacEmbarquesCab", _mfacEmbarquesCab)
			info.AddValue("_mfacEmbarquesCabReturnsNewIfNotFound", _mfacEmbarquesCabReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMfacEmbarquesCab", _alwaysFetchMfacEmbarquesCab)
			info.AddValue("_alreadyFetchedMfacEmbarquesCab", _alreadyFetchedMfacEmbarquesCab)
			info.AddValue("_msccatMotivoDevolucion", _msccatMotivoDevolucion)
			info.AddValue("_msccatMotivoDevolucionReturnsNewIfNotFound", _msccatMotivoDevolucionReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMsccatMotivoDevolucion", _alwaysFetchMsccatMotivoDevolucion)
			info.AddValue("_alreadyFetchedMsccatMotivoDevolucion", _alreadyFetchedMsccatMotivoDevolucion)
			info.AddValue("_msccatProductos", _msccatProductos)
			info.AddValue("_msccatProductosReturnsNewIfNotFound", _msccatProductosReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMsccatProductos", _alwaysFetchMsccatProductos)
			info.AddValue("_alreadyFetchedMsccatProductos", _alreadyFetchedMsccatProductos)

			
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
				Case "MfacCatClientes"
					_alreadyFetchedMfacCatClientes = True
					Me.MfacCatClientes = CType(entity, MfacCatClientesEntity)
				Case "MfacEmbarquesCab"
					_alreadyFetchedMfacEmbarquesCab = True
					Me.MfacEmbarquesCab = CType(entity, MfacEmbarquesCabEntity)
				Case "MsccatMotivoDevolucion"
					_alreadyFetchedMsccatMotivoDevolucion = True
					Me.MsccatMotivoDevolucion = CType(entity, MsccatMotivoDevolucionEntity)
				Case "MsccatProductos"
					_alreadyFetchedMsccatProductos = True
					Me.MsccatProductos = CType(entity, MsccatProductosEntity)



				Case Else

			End Select
		End Sub

		''' <summary>Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		''' <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		<EditorBrowsable(EditorBrowsableState.Never)> _
		Public Overrides Overloads Sub SetRelatedEntity(relatedEntity As IEntity, fieldName As String)
			Select Case fieldName
				Case "MfacCatClientes"
					SetupSyncMfacCatClientes(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MfacEmbarquesCab"
					SetupSyncMfacEmbarquesCab(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MsccatMotivoDevolucion"
					SetupSyncMsccatMotivoDevolucion(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MsccatProductos"
					SetupSyncMsccatProductos(relatedEntity)
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
				Case "MfacCatClientes"
					DesetupSyncMfacCatClientes(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MfacEmbarquesCab"
					DesetupSyncMfacEmbarquesCab(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MsccatMotivoDevolucion"
					DesetupSyncMsccatMotivoDevolucion(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MsccatProductos"
					DesetupSyncMsccatProductos(False, True)
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
			If Not _mfacCatClientes Is Nothing Then
				toReturn.Add(_mfacCatClientes)
			End If
			If Not _mfacEmbarquesCab Is Nothing Then
				toReturn.Add(_mfacEmbarquesCab)
			End If
			If Not _msccatMotivoDevolucion Is Nothing Then
				toReturn.Add(_msccatMotivoDevolucion)
			End If
			If Not _msccatProductos Is Nothing Then
				toReturn.Add(_msccatProductos)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()


			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folio">PK value for DevolucionProductos which data should be fetched into this DevolucionProductos Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folio As System.String) As Boolean
			Return FetchUsingPK(folio, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folio">PK value for DevolucionProductos which data should be fetched into this DevolucionProductos Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folio As System.String, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(folio, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folio">PK value for DevolucionProductos which data should be fetched into this DevolucionProductos Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folio As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(folio, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.Folio, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As DevolucionProductosFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As DevolucionProductosFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
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
				If MyBase.CheckIfLazyLoadingShouldOccur(DevolucionProductosEntity.Relations.MfacCatClientesEntityUsingIdCliente) Then
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
	
		''' <summary>Retrieves the related entity of type 'MfacEmbarquesCabEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'MfacEmbarquesCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMfacEmbarquesCab() As MfacEmbarquesCabEntity
			Return GetSingleMfacEmbarquesCab(False)
		End Function

		''' <summary>Retrieves the related entity of type 'MfacEmbarquesCabEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'MfacEmbarquesCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMfacEmbarquesCab(forceFetch As Boolean) As MfacEmbarquesCabEntity
			If ( Not _alreadyFetchedMfacEmbarquesCab Or forceFetch Or _alwaysFetchMfacEmbarquesCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New MfacEmbarquesCabEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(DevolucionProductosEntity.Relations.MfacEmbarquesCabEntityUsingEmbarque) Then
					fetchResult = newEntity.FetchUsingPK(Me.Embarque)
				End If
				If Not _mfacEmbarquesCabReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.MfacEmbarquesCab = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), MfacEmbarquesCabEntity)
					End If
					Me.MfacEmbarquesCab = newEntity
					_alreadyFetchedMfacEmbarquesCab = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _mfacEmbarquesCab
		End Function
	
		''' <summary>Retrieves the related entity of type 'MsccatMotivoDevolucionEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'MsccatMotivoDevolucionEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMsccatMotivoDevolucion() As MsccatMotivoDevolucionEntity
			Return GetSingleMsccatMotivoDevolucion(False)
		End Function

		''' <summary>Retrieves the related entity of type 'MsccatMotivoDevolucionEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'MsccatMotivoDevolucionEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMsccatMotivoDevolucion(forceFetch As Boolean) As MsccatMotivoDevolucionEntity
			If ( Not _alreadyFetchedMsccatMotivoDevolucion Or forceFetch Or _alwaysFetchMsccatMotivoDevolucion) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New MsccatMotivoDevolucionEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(DevolucionProductosEntity.Relations.MsccatMotivoDevolucionEntityUsingIdMotivoDevolucion) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdMotivoDevolucion)
				End If
				If Not _msccatMotivoDevolucionReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.MsccatMotivoDevolucion = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), MsccatMotivoDevolucionEntity)
					End If
					Me.MsccatMotivoDevolucion = newEntity
					_alreadyFetchedMsccatMotivoDevolucion = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _msccatMotivoDevolucion
		End Function
	
		''' <summary>Retrieves the related entity of type 'MsccatProductosEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'MsccatProductosEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMsccatProductos() As MsccatProductosEntity
			Return GetSingleMsccatProductos(False)
		End Function

		''' <summary>Retrieves the related entity of type 'MsccatProductosEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'MsccatProductosEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMsccatProductos(forceFetch As Boolean) As MsccatProductosEntity
			If ( Not _alreadyFetchedMsccatProductos Or forceFetch Or _alwaysFetchMsccatProductos) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New MsccatProductosEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(DevolucionProductosEntity.Relations.MsccatProductosEntityUsingIdProducto) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdProducto)
				End If
				If Not _msccatProductosReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.MsccatProductos = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), MsccatProductosEntity)
					End If
					Me.MsccatProductos = newEntity
					_alreadyFetchedMsccatProductos = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _msccatProductos
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(DevolucionProductosFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, DevolucionProductosFieldIndex)

					Case DevolucionProductosFieldIndex.IdProducto
						DesetupSyncMsccatProductos(True, False)
						_alreadyFetchedMsccatProductos = False


					Case DevolucionProductosFieldIndex.Embarque
						DesetupSyncMfacEmbarquesCab(True, False)
						_alreadyFetchedMfacEmbarquesCab = False
					Case DevolucionProductosFieldIndex.IdCliente
						DesetupSyncMfacCatClientes(True, False)
						_alreadyFetchedMfacCatClientes = False









					Case DevolucionProductosFieldIndex.IdMotivoDevolucion
						DesetupSyncMsccatMotivoDevolucion(True, False)
						_alreadyFetchedMsccatMotivoDevolucion = False


					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()


		If Not _mfacCatClientes Is Nothing Then
				_mfacCatClientes.ActiveContext = MyBase.ActiveContext
			End If
		If Not _mfacEmbarquesCab Is Nothing Then
				_mfacEmbarquesCab.ActiveContext = MyBase.ActiveContext
			End If
		If Not _msccatMotivoDevolucion Is Nothing Then
				_msccatMotivoDevolucion.ActiveContext = MyBase.ActiveContext
			End If
		If Not _msccatProductos Is Nothing Then
				_msccatProductos.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As DevolucionProductosDAO = CType(CreateDAOInstance(), DevolucionProductosDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As DevolucionProductosDAO = CType(CreateDAOInstance(), DevolucionProductosDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As DevolucionProductosDAO = CType(CreateDAOInstance(), DevolucionProductosDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this DevolucionProductosEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.DevolucionProductosEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="folio">PK value for DevolucionProductos which data should be fetched into this DevolucionProductos Object</param>
		''' <param name="validator">The validator Object for this DevolucionProductosEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(folio As System.String, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(folio, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()


			_mfacCatClientes = Nothing
			_mfacCatClientesReturnsNewIfNotFound = True
			_alwaysFetchMfacCatClientes = False
			_alreadyFetchedMfacCatClientes = False
			_mfacEmbarquesCab = Nothing
			_mfacEmbarquesCabReturnsNewIfNotFound = True
			_alwaysFetchMfacEmbarquesCab = False
			_alreadyFetchedMfacEmbarquesCab = False
			_msccatMotivoDevolucion = Nothing
			_msccatMotivoDevolucionReturnsNewIfNotFound = True
			_alwaysFetchMsccatMotivoDevolucion = False
			_alreadyFetchedMsccatMotivoDevolucion = False
			_msccatProductos = Nothing
			_msccatProductosReturnsNewIfNotFound = True
			_alwaysFetchMsccatProductos = False
			_alreadyFetchedMsccatProductos = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Folio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdProducto", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Piezas", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Kilos", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Embarque", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdCliente", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("UtilparaVenta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EnCaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdFolioEtiqueta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioMovimientoAlmacen", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioMovimeintoAlmacenCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCaptura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdUsuarioAlta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdUsuarioCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdMotivoDevolucion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Observaciones", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _mfacCatClientes</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMfacCatClientes(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _mfacCatClientes, AddressOf OnMfacCatClientesPropertyChanged, "MfacCatClientes", DevolucionProductosEntity.Relations.MfacCatClientesEntityUsingIdCliente, True, signalRelatedEntity, "DevolucionProductos", resetFKFields, New Integer() { CInt(DevolucionProductosFieldIndex.IdCliente) } )
			_mfacCatClientes = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _mfacCatClientes</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMfacCatClientes(relatedEntity As IEntity)
			DesetupSyncMfacCatClientes(True, True)
			_mfacCatClientes = CType(relatedEntity, MfacCatClientesEntity)
			MyBase.PerformSetupSyncRelatedEntity( _mfacCatClientes, AddressOf OnMfacCatClientesPropertyChanged, "MfacCatClientes", DevolucionProductosEntity.Relations.MfacCatClientesEntityUsingIdCliente, True, _alreadyFetchedMfacCatClientes, New String() {  } )
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
		''' <summary>Removes the sync logic for member _mfacEmbarquesCab</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMfacEmbarquesCab(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _mfacEmbarquesCab, AddressOf OnMfacEmbarquesCabPropertyChanged, "MfacEmbarquesCab", DevolucionProductosEntity.Relations.MfacEmbarquesCabEntityUsingEmbarque, True, signalRelatedEntity, "DevolucionProductos", resetFKFields, New Integer() { CInt(DevolucionProductosFieldIndex.Embarque) } )
			_mfacEmbarquesCab = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _mfacEmbarquesCab</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMfacEmbarquesCab(relatedEntity As IEntity)
			DesetupSyncMfacEmbarquesCab(True, True)
			_mfacEmbarquesCab = CType(relatedEntity, MfacEmbarquesCabEntity)
			MyBase.PerformSetupSyncRelatedEntity( _mfacEmbarquesCab, AddressOf OnMfacEmbarquesCabPropertyChanged, "MfacEmbarquesCab", DevolucionProductosEntity.Relations.MfacEmbarquesCabEntityUsingEmbarque, True, _alreadyFetchedMfacEmbarquesCab, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMfacEmbarquesCabPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _msccatMotivoDevolucion</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMsccatMotivoDevolucion(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _msccatMotivoDevolucion, AddressOf OnMsccatMotivoDevolucionPropertyChanged, "MsccatMotivoDevolucion", DevolucionProductosEntity.Relations.MsccatMotivoDevolucionEntityUsingIdMotivoDevolucion, True, signalRelatedEntity, "DevolucionProductos", resetFKFields, New Integer() { CInt(DevolucionProductosFieldIndex.IdMotivoDevolucion) } )
			_msccatMotivoDevolucion = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _msccatMotivoDevolucion</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMsccatMotivoDevolucion(relatedEntity As IEntity)
			DesetupSyncMsccatMotivoDevolucion(True, True)
			_msccatMotivoDevolucion = CType(relatedEntity, MsccatMotivoDevolucionEntity)
			MyBase.PerformSetupSyncRelatedEntity( _msccatMotivoDevolucion, AddressOf OnMsccatMotivoDevolucionPropertyChanged, "MsccatMotivoDevolucion", DevolucionProductosEntity.Relations.MsccatMotivoDevolucionEntityUsingIdMotivoDevolucion, True, _alreadyFetchedMsccatMotivoDevolucion, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMsccatMotivoDevolucionPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _msccatProductos</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMsccatProductos(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _msccatProductos, AddressOf OnMsccatProductosPropertyChanged, "MsccatProductos", DevolucionProductosEntity.Relations.MsccatProductosEntityUsingIdProducto, True, signalRelatedEntity, "DevolucionProductos", resetFKFields, New Integer() { CInt(DevolucionProductosFieldIndex.IdProducto) } )
			_msccatProductos = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _msccatProductos</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMsccatProductos(relatedEntity As IEntity)
			DesetupSyncMsccatProductos(True, True)
			_msccatProductos = CType(relatedEntity, MsccatProductosEntity)
			MyBase.PerformSetupSyncRelatedEntity( _msccatProductos, AddressOf OnMsccatProductosPropertyChanged, "MsccatProductos", DevolucionProductosEntity.Relations.MsccatProductosEntityUsingIdProducto, True, _alreadyFetchedMsccatProductos, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMsccatProductosPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="folio">PK value for DevolucionProductos which data should be fetched into this DevolucionProductos Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(folio As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(DevolucionProductosFieldIndex.Folio)).ForcedCurrentValueWrite(folio)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateDevolucionProductosDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New DevolucionProductosEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As DevolucionProductosRelations
			Get	
				Return New DevolucionProductosRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MfacCatClientes' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMfacCatClientes() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MfacCatClientesCollection(), _
					DevolucionProductosEntity.Relations.MfacCatClientesEntityUsingIdCliente, _
					CType(Integralab.ORM.EntityType.DevolucionProductosEntity, Integer), CType(Integralab.ORM.EntityType.MfacCatClientesEntity, Integer), 0, Nothing, Nothing, Nothing, "MfacCatClientes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MfacEmbarquesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMfacEmbarquesCab() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MfacEmbarquesCabCollection(), _
					DevolucionProductosEntity.Relations.MfacEmbarquesCabEntityUsingEmbarque, _
					CType(Integralab.ORM.EntityType.DevolucionProductosEntity, Integer), CType(Integralab.ORM.EntityType.MfacEmbarquesCabEntity, Integer), 0, Nothing, Nothing, Nothing, "MfacEmbarquesCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MsccatMotivoDevolucion' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMsccatMotivoDevolucion() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MsccatMotivoDevolucionCollection(), _
					DevolucionProductosEntity.Relations.MsccatMotivoDevolucionEntityUsingIdMotivoDevolucion, _
					CType(Integralab.ORM.EntityType.DevolucionProductosEntity, Integer), CType(Integralab.ORM.EntityType.MsccatMotivoDevolucionEntity, Integer), 0, Nothing, Nothing, Nothing, "MsccatMotivoDevolucion", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MsccatProductos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMsccatProductos() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MsccatProductosCollection(), _
					DevolucionProductosEntity.Relations.MsccatProductosEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.DevolucionProductosEntity, Integer), CType(Integralab.ORM.EntityType.MsccatProductosEntity, Integer), 0, Nothing, Nothing, Nothing, "MsccatProductos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "DevolucionProductosEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return DevolucionProductosEntity.CustomProperties
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
				Return DevolucionProductosEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The Folio property of the Entity DevolucionProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCDevolucionProductos"."Folio"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [Folio]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(DevolucionProductosFieldIndex.Folio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(DevolucionProductosFieldIndex.Folio, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdProducto property of the Entity DevolucionProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCDevolucionProductos"."IdProducto"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdProducto]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(DevolucionProductosFieldIndex.IdProducto, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(DevolucionProductosFieldIndex.IdProducto, Integer), value)
			End Set
		End Property
	
		''' <summary>The Piezas property of the Entity DevolucionProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCDevolucionProductos"."Piezas"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 18, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Piezas]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(DevolucionProductosFieldIndex.Piezas, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(DevolucionProductosFieldIndex.Piezas, Integer), value)
			End Set
		End Property
	
		''' <summary>The Kilos property of the Entity DevolucionProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCDevolucionProductos"."Kilos"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 18, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Kilos]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(DevolucionProductosFieldIndex.Kilos, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(DevolucionProductosFieldIndex.Kilos, Integer), value)
			End Set
		End Property
	
		''' <summary>The Embarque property of the Entity DevolucionProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCDevolucionProductos"."Embarque"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Embarque]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(DevolucionProductosFieldIndex.Embarque, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(DevolucionProductosFieldIndex.Embarque, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdCliente property of the Entity DevolucionProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCDevolucionProductos"."IdCliente"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdCliente]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(DevolucionProductosFieldIndex.IdCliente, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(DevolucionProductosFieldIndex.IdCliente, Integer), value)
			End Set
		End Property
	
		''' <summary>The UtilparaVenta property of the Entity DevolucionProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCDevolucionProductos"."UtilparaVenta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [UtilparaVenta]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(DevolucionProductosFieldIndex.UtilparaVenta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(DevolucionProductosFieldIndex.UtilparaVenta, Integer), value)
			End Set
		End Property
	
		''' <summary>The EnCaja property of the Entity DevolucionProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCDevolucionProductos"."EnCaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [EnCaja]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(DevolucionProductosFieldIndex.EnCaja, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(DevolucionProductosFieldIndex.EnCaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdFolioEtiqueta property of the Entity DevolucionProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCDevolucionProductos"."IdFolioEtiqueta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 14<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdFolioEtiqueta]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(DevolucionProductosFieldIndex.IdFolioEtiqueta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(DevolucionProductosFieldIndex.IdFolioEtiqueta, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioMovimientoAlmacen property of the Entity DevolucionProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCDevolucionProductos"."FolioMovimientoAlmacen"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 12<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FolioMovimientoAlmacen]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(DevolucionProductosFieldIndex.FolioMovimientoAlmacen, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(DevolucionProductosFieldIndex.FolioMovimientoAlmacen, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioMovimeintoAlmacenCancelacion property of the Entity DevolucionProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCDevolucionProductos"."FolioMovimeintoAlmacenCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 12<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FolioMovimeintoAlmacenCancelacion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(DevolucionProductosFieldIndex.FolioMovimeintoAlmacenCancelacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(DevolucionProductosFieldIndex.FolioMovimeintoAlmacenCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCaptura property of the Entity DevolucionProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCDevolucionProductos"."FechaCaptura"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaCaptura]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(DevolucionProductosFieldIndex.FechaCaptura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(DevolucionProductosFieldIndex.FechaCaptura, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCancelacion property of the Entity DevolucionProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCDevolucionProductos"."FechaCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaCancelacion]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(DevolucionProductosFieldIndex.FechaCancelacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(DevolucionProductosFieldIndex.FechaCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdUsuarioAlta property of the Entity DevolucionProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCDevolucionProductos"."IdUsuarioAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdUsuarioAlta]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(DevolucionProductosFieldIndex.IdUsuarioAlta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(DevolucionProductosFieldIndex.IdUsuarioAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdUsuarioCancelacion property of the Entity DevolucionProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCDevolucionProductos"."IdUsuarioCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdUsuarioCancelacion]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(DevolucionProductosFieldIndex.IdUsuarioCancelacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(DevolucionProductosFieldIndex.IdUsuarioCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdMotivoDevolucion property of the Entity DevolucionProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCDevolucionProductos"."IdMotivoDevolucion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdMotivoDevolucion]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(DevolucionProductosFieldIndex.IdMotivoDevolucion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(DevolucionProductosFieldIndex.IdMotivoDevolucion, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity DevolucionProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCDevolucionProductos"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(DevolucionProductosFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(DevolucionProductosFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The Observaciones property of the Entity DevolucionProductos<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCDevolucionProductos"."Observaciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 500<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Observaciones]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(DevolucionProductosFieldIndex.Observaciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(DevolucionProductosFieldIndex.Observaciones, Integer), value)
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
							_mfacCatClientes.UnsetRelatedEntity(Me, "DevolucionProductos")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "DevolucionProductos")
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
	
		''' <summary>Gets / sets related entity of type 'MfacEmbarquesCabEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMfacEmbarquesCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [MfacEmbarquesCab]() As MfacEmbarquesCabEntity
			Get
				Return GetSingleMfacEmbarquesCab(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMfacEmbarquesCab(value)
				Else
					If value Is Nothing Then
						If Not _mfacEmbarquesCab Is Nothing Then
							_mfacEmbarquesCab.UnsetRelatedEntity(Me, "DevolucionProductos")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "DevolucionProductos")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for MfacEmbarquesCab. When set to true, MfacEmbarquesCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MfacEmbarquesCab is accessed. You can always execute
		''' a forced fetch by calling GetSingleMfacEmbarquesCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMfacEmbarquesCab As Boolean
			Get
				Return _alwaysFetchMfacEmbarquesCab
			End Get
			Set
				_alwaysFetchMfacEmbarquesCab = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property MfacEmbarquesCab is not found
		''' in the database. When set to true, MfacEmbarquesCab will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property MfacEmbarquesCabReturnsNewIfNotFound As Boolean
			Get
				Return _mfacEmbarquesCabReturnsNewIfNotFound
			End Get
			Set
				_mfacEmbarquesCabReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'MsccatMotivoDevolucionEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMsccatMotivoDevolucion()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [MsccatMotivoDevolucion]() As MsccatMotivoDevolucionEntity
			Get
				Return GetSingleMsccatMotivoDevolucion(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMsccatMotivoDevolucion(value)
				Else
					If value Is Nothing Then
						If Not _msccatMotivoDevolucion Is Nothing Then
							_msccatMotivoDevolucion.UnsetRelatedEntity(Me, "DevolucionProductos")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "DevolucionProductos")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for MsccatMotivoDevolucion. When set to true, MsccatMotivoDevolucion is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MsccatMotivoDevolucion is accessed. You can always execute
		''' a forced fetch by calling GetSingleMsccatMotivoDevolucion(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMsccatMotivoDevolucion As Boolean
			Get
				Return _alwaysFetchMsccatMotivoDevolucion
			End Get
			Set
				_alwaysFetchMsccatMotivoDevolucion = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property MsccatMotivoDevolucion is not found
		''' in the database. When set to true, MsccatMotivoDevolucion will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property MsccatMotivoDevolucionReturnsNewIfNotFound As Boolean
			Get
				Return _msccatMotivoDevolucionReturnsNewIfNotFound
			End Get
			Set
				_msccatMotivoDevolucionReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'MsccatProductosEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMsccatProductos()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [MsccatProductos]() As MsccatProductosEntity
			Get
				Return GetSingleMsccatProductos(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMsccatProductos(value)
				Else
					If value Is Nothing Then
						If Not _msccatProductos Is Nothing Then
							_msccatProductos.UnsetRelatedEntity(Me, "DevolucionProductos")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "DevolucionProductos")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for MsccatProductos. When set to true, MsccatProductos is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MsccatProductos is accessed. You can always execute
		''' a forced fetch by calling GetSingleMsccatProductos(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMsccatProductos As Boolean
			Get
				Return _alwaysFetchMsccatProductos
			End Get
			Set
				_alwaysFetchMsccatProductos = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property MsccatProductos is not found
		''' in the database. When set to true, MsccatProductos will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property MsccatProductosReturnsNewIfNotFound As Boolean
			Get
				Return _msccatProductosReturnsNewIfNotFound
			End Get
			Set
				_msccatProductosReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.DevolucionProductosEntity)
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
