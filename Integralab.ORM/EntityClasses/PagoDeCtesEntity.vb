' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: miércoles, 7 de febrero de 2018 11:23:32
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
	''' <summary>Entity class which represents the entity 'PagoDeCtes'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class PagoDeCtesEntity 
#Else
	<Serializable()> _
	Public Class PagoDeCtesEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"


		Private _facturasClientesCab As FacturasClientesCabEntity
		Private _alwaysFetchFacturasClientesCab, _alreadyFetchedFacturasClientesCab, _facturasClientesCabReturnsNewIfNotFound As Boolean
		Private _mfacCatClientes As MfacCatClientesEntity
		Private _alwaysFetchMfacCatClientes, _alreadyFetchedMfacCatClientes, _mfacCatClientesReturnsNewIfNotFound As Boolean
		Private _poliza As PolizaEntity
		Private _alwaysFetchPoliza, _alreadyFetchedPoliza, _polizaReturnsNewIfNotFound As Boolean
		Private _poliza_ As PolizaEntity
		Private _alwaysFetchPoliza_, _alreadyFetchedPoliza_, _poliza_ReturnsNewIfNotFound As Boolean


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
		''' <param name="folIngreso">PK value for PagoDeCtes which data should be fetched into this PagoDeCtes Object</param>
		''' <param name="folFactura">PK value for PagoDeCtes which data should be fetched into this PagoDeCtes Object</param>
		Public Sub New(folIngreso As System.String, folFactura As System.String)

			InitClassFetch(folIngreso, folFactura, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folIngreso">PK value for PagoDeCtes which data should be fetched into this PagoDeCtes Object</param>
		''' <param name="folFactura">PK value for PagoDeCtes which data should be fetched into this PagoDeCtes Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(folIngreso As System.String, folFactura As System.String, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(folIngreso, folFactura, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folIngreso">PK value for PagoDeCtes which data should be fetched into this PagoDeCtes Object</param>
		''' <param name="folFactura">PK value for PagoDeCtes which data should be fetched into this PagoDeCtes Object</param>
		''' <param name="validator">The custom validator Object for this PagoDeCtesEntity</param>
		Public Sub New(folIngreso As System.String, folFactura As System.String, validator As IValidator)

			InitClassFetch(folIngreso, folFactura, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)


			_facturasClientesCab = CType(info.GetValue("_facturasClientesCab", GetType(FacturasClientesCabEntity)), FacturasClientesCabEntity)
			If Not _facturasClientesCab Is Nothing Then
				AddHandler _facturasClientesCab.AfterSave, AddressOf OnEntityAfterSave
			End If
			_facturasClientesCabReturnsNewIfNotFound = info.GetBoolean("_facturasClientesCabReturnsNewIfNotFound")
			_alwaysFetchFacturasClientesCab = info.GetBoolean("_alwaysFetchFacturasClientesCab")
			_alreadyFetchedFacturasClientesCab = info.GetBoolean("_alreadyFetchedFacturasClientesCab")
			_mfacCatClientes = CType(info.GetValue("_mfacCatClientes", GetType(MfacCatClientesEntity)), MfacCatClientesEntity)
			If Not _mfacCatClientes Is Nothing Then
				AddHandler _mfacCatClientes.AfterSave, AddressOf OnEntityAfterSave
			End If
			_mfacCatClientesReturnsNewIfNotFound = info.GetBoolean("_mfacCatClientesReturnsNewIfNotFound")
			_alwaysFetchMfacCatClientes = info.GetBoolean("_alwaysFetchMfacCatClientes")
			_alreadyFetchedMfacCatClientes = info.GetBoolean("_alreadyFetchedMfacCatClientes")
			_poliza = CType(info.GetValue("_poliza", GetType(PolizaEntity)), PolizaEntity)
			If Not _poliza Is Nothing Then
				AddHandler _poliza.AfterSave, AddressOf OnEntityAfterSave
			End If
			_polizaReturnsNewIfNotFound = info.GetBoolean("_polizaReturnsNewIfNotFound")
			_alwaysFetchPoliza = info.GetBoolean("_alwaysFetchPoliza")
			_alreadyFetchedPoliza = info.GetBoolean("_alreadyFetchedPoliza")
			_poliza_ = CType(info.GetValue("_poliza_", GetType(PolizaEntity)), PolizaEntity)
			If Not _poliza_ Is Nothing Then
				AddHandler _poliza_.AfterSave, AddressOf OnEntityAfterSave
			End If
			_poliza_ReturnsNewIfNotFound = info.GetBoolean("_poliza_ReturnsNewIfNotFound")
			_alwaysFetchPoliza_ = info.GetBoolean("_alwaysFetchPoliza_")
			_alreadyFetchedPoliza_ = info.GetBoolean("_alreadyFetchedPoliza_")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()


			_alreadyFetchedFacturasClientesCab = Not(_facturasClientesCab Is Nothing)
			_alreadyFetchedMfacCatClientes = Not(_mfacCatClientes Is Nothing)
			_alreadyFetchedPoliza = Not(_poliza Is Nothing)
			_alreadyFetchedPoliza_ = Not(_poliza_ Is Nothing)

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


			info.AddValue("_facturasClientesCab", _facturasClientesCab)
			info.AddValue("_facturasClientesCabReturnsNewIfNotFound", _facturasClientesCabReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchFacturasClientesCab", _alwaysFetchFacturasClientesCab)
			info.AddValue("_alreadyFetchedFacturasClientesCab", _alreadyFetchedFacturasClientesCab)
			info.AddValue("_mfacCatClientes", _mfacCatClientes)
			info.AddValue("_mfacCatClientesReturnsNewIfNotFound", _mfacCatClientesReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMfacCatClientes", _alwaysFetchMfacCatClientes)
			info.AddValue("_alreadyFetchedMfacCatClientes", _alreadyFetchedMfacCatClientes)
			info.AddValue("_poliza", _poliza)
			info.AddValue("_polizaReturnsNewIfNotFound", _polizaReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchPoliza", _alwaysFetchPoliza)
			info.AddValue("_alreadyFetchedPoliza", _alreadyFetchedPoliza)
			info.AddValue("_poliza_", _poliza_)
			info.AddValue("_poliza_ReturnsNewIfNotFound", _poliza_ReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchPoliza_", _alwaysFetchPoliza_)
			info.AddValue("_alreadyFetchedPoliza_", _alreadyFetchedPoliza_)

			
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
				Case "FacturasClientesCab"
					_alreadyFetchedFacturasClientesCab = True
					Me.FacturasClientesCab = CType(entity, FacturasClientesCabEntity)
				Case "MfacCatClientes"
					_alreadyFetchedMfacCatClientes = True
					Me.MfacCatClientes = CType(entity, MfacCatClientesEntity)
				Case "Poliza"
					_alreadyFetchedPoliza = True
					Me.Poliza = CType(entity, PolizaEntity)
				Case "Poliza_"
					_alreadyFetchedPoliza_ = True
					Me.Poliza_ = CType(entity, PolizaEntity)



				Case Else

			End Select
		End Sub

		''' <summary>Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		''' <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		<EditorBrowsable(EditorBrowsableState.Never)> _
		Public Overrides Overloads Sub SetRelatedEntity(relatedEntity As IEntity, fieldName As String)
			Select Case fieldName
				Case "FacturasClientesCab"
					SetupSyncFacturasClientesCab(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MfacCatClientes"
					SetupSyncMfacCatClientes(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Poliza"
					SetupSyncPoliza(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Poliza_"
					SetupSyncPoliza_(relatedEntity)
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
				Case "FacturasClientesCab"
					DesetupSyncFacturasClientesCab(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MfacCatClientes"
					DesetupSyncMfacCatClientes(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Poliza"
					DesetupSyncPoliza(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Poliza_"
					DesetupSyncPoliza_(False, True)
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
			If Not _facturasClientesCab Is Nothing Then
				toReturn.Add(_facturasClientesCab)
			End If
			If Not _mfacCatClientes Is Nothing Then
				toReturn.Add(_mfacCatClientes)
			End If
			If Not _poliza Is Nothing Then
				toReturn.Add(_poliza)
			End If
			If Not _poliza_ Is Nothing Then
				toReturn.Add(_poliza_)
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
		''' <param name="folIngreso">PK value for PagoDeCtes which data should be fetched into this PagoDeCtes Object</param>
		''' <param name="folFactura">PK value for PagoDeCtes which data should be fetched into this PagoDeCtes Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folIngreso As System.String, folFactura As System.String) As Boolean
			Return FetchUsingPK(folIngreso, folFactura, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folIngreso">PK value for PagoDeCtes which data should be fetched into this PagoDeCtes Object</param>
		''' <param name="folFactura">PK value for PagoDeCtes which data should be fetched into this PagoDeCtes Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folIngreso As System.String, folFactura As System.String, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(folIngreso, folFactura, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folIngreso">PK value for PagoDeCtes which data should be fetched into this PagoDeCtes Object</param>
		''' <param name="folFactura">PK value for PagoDeCtes which data should be fetched into this PagoDeCtes Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folIngreso As System.String, folFactura As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(folIngreso, folFactura, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.FolIngreso, Me.FolFactura, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As PagoDeCtesFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As PagoDeCtesFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



	

		''' <summary>Retrieves the related entity of type 'FacturasClientesCabEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'FacturasClientesCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleFacturasClientesCab() As FacturasClientesCabEntity
			Return GetSingleFacturasClientesCab(False)
		End Function

		''' <summary>Retrieves the related entity of type 'FacturasClientesCabEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'FacturasClientesCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleFacturasClientesCab(forceFetch As Boolean) As FacturasClientesCabEntity
			If ( Not _alreadyFetchedFacturasClientesCab Or forceFetch Or _alwaysFetchFacturasClientesCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New FacturasClientesCabEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(PagoDeCtesEntity.Relations.FacturasClientesCabEntityUsingSerieFacturaFolFactura) Then
					fetchResult = newEntity.FetchUsingPK(Me.FolFactura, Me.SerieFactura)
				End If
				If Not _facturasClientesCabReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.FacturasClientesCab = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), FacturasClientesCabEntity)
					End If
					Me.FacturasClientesCab = newEntity
					_alreadyFetchedFacturasClientesCab = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _facturasClientesCab
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
				If MyBase.CheckIfLazyLoadingShouldOccur(PagoDeCtesEntity.Relations.MfacCatClientesEntityUsingCveCliente) Then
					fetchResult = newEntity.FetchUsingPK(Me.CveCliente)
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
	
		''' <summary>Retrieves the related entity of type 'PolizaEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'PolizaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSinglePoliza() As PolizaEntity
			Return GetSinglePoliza(False)
		End Function

		''' <summary>Retrieves the related entity of type 'PolizaEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'PolizaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSinglePoliza(forceFetch As Boolean) As PolizaEntity
			If ( Not _alreadyFetchedPoliza Or forceFetch Or _alwaysFetchPoliza) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New PolizaEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(PagoDeCtesEntity.Relations.PolizaEntityUsingIdPoliza) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdPoliza.GetValueOrDefault())
				End If
				If Not _polizaReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Poliza = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), PolizaEntity)
					End If
					Me.Poliza = newEntity
					_alreadyFetchedPoliza = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _poliza
		End Function
	
		''' <summary>Retrieves the related entity of type 'PolizaEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'PolizaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSinglePoliza_() As PolizaEntity
			Return GetSinglePoliza_(False)
		End Function

		''' <summary>Retrieves the related entity of type 'PolizaEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'PolizaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSinglePoliza_(forceFetch As Boolean) As PolizaEntity
			If ( Not _alreadyFetchedPoliza_ Or forceFetch Or _alwaysFetchPoliza_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New PolizaEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(PagoDeCtesEntity.Relations.PolizaEntityUsingIdPolizaCancelacion) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdPolizaCancelacion.GetValueOrDefault())
				End If
				If Not _poliza_ReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Poliza_ = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), PolizaEntity)
					End If
					Me.Poliza_ = newEntity
					_alreadyFetchedPoliza_ = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _poliza_
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(PagoDeCtesFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, PagoDeCtesFieldIndex)
					Case PagoDeCtesFieldIndex.CveCliente
						DesetupSyncMfacCatClientes(True, False)
						_alreadyFetchedMfacCatClientes = False


					Case PagoDeCtesFieldIndex.FolFactura
						DesetupSyncFacturasClientesCab(True, False)
						_alreadyFetchedFacturasClientesCab = False











					Case PagoDeCtesFieldIndex.IdPoliza
						DesetupSyncPoliza(True, False)
						_alreadyFetchedPoliza = False
					Case PagoDeCtesFieldIndex.IdPolizaCancelacion
						DesetupSyncPoliza_(True, False)
						_alreadyFetchedPoliza_ = False
					Case PagoDeCtesFieldIndex.SerieFactura
						DesetupSyncFacturasClientesCab(True, False)
						_alreadyFetchedFacturasClientesCab = False
					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()


		If Not _facturasClientesCab Is Nothing Then
				_facturasClientesCab.ActiveContext = MyBase.ActiveContext
			End If
		If Not _mfacCatClientes Is Nothing Then
				_mfacCatClientes.ActiveContext = MyBase.ActiveContext
			End If
		If Not _poliza Is Nothing Then
				_poliza.ActiveContext = MyBase.ActiveContext
			End If
		If Not _poliza_ Is Nothing Then
				_poliza_.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As PagoDeCtesDAO = CType(CreateDAOInstance(), PagoDeCtesDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As PagoDeCtesDAO = CType(CreateDAOInstance(), PagoDeCtesDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As PagoDeCtesDAO = CType(CreateDAOInstance(), PagoDeCtesDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this PagoDeCtesEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.PagoDeCtesEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="folIngreso">PK value for PagoDeCtes which data should be fetched into this PagoDeCtes Object</param>
		''' <param name="folFactura">PK value for PagoDeCtes which data should be fetched into this PagoDeCtes Object</param>
		''' <param name="validator">The validator Object for this PagoDeCtesEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(folIngreso As System.String, folFactura As System.String, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(folIngreso, folFactura, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()


			_facturasClientesCab = Nothing
			_facturasClientesCabReturnsNewIfNotFound = True
			_alwaysFetchFacturasClientesCab = False
			_alreadyFetchedFacturasClientesCab = False
			_mfacCatClientes = Nothing
			_mfacCatClientesReturnsNewIfNotFound = True
			_alwaysFetchMfacCatClientes = False
			_alreadyFetchedMfacCatClientes = False
			_poliza = Nothing
			_polizaReturnsNewIfNotFound = True
			_alwaysFetchPoliza = False
			_alreadyFetchedPoliza = False
			_poliza_ = Nothing
			_poliza_ReturnsNewIfNotFound = True
			_alwaysFetchPoliza_ = False
			_alreadyFetchedPoliza_ = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CveCliente", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolIngreso", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FecIngreso", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolFactura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImpteIngreso", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TipoPago", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Documento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImpteNotaCred", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImpteChePos", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CveUser", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CveUserCancel", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FecCancela", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImpteFactura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SaldoFactura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdPoliza", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdPolizaCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SerieFactura", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _facturasClientesCab</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncFacturasClientesCab(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _facturasClientesCab, AddressOf OnFacturasClientesCabPropertyChanged, "FacturasClientesCab", PagoDeCtesEntity.Relations.FacturasClientesCabEntityUsingSerieFacturaFolFactura, True, signalRelatedEntity, "PagoDeCtes", resetFKFields, New Integer() { CInt(PagoDeCtesFieldIndex.SerieFactura), CInt(PagoDeCtesFieldIndex.FolFactura) } )
			_facturasClientesCab = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _facturasClientesCab</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncFacturasClientesCab(relatedEntity As IEntity)
			DesetupSyncFacturasClientesCab(True, True)
			_facturasClientesCab = CType(relatedEntity, FacturasClientesCabEntity)
			MyBase.PerformSetupSyncRelatedEntity( _facturasClientesCab, AddressOf OnFacturasClientesCabPropertyChanged, "FacturasClientesCab", PagoDeCtesEntity.Relations.FacturasClientesCabEntityUsingSerieFacturaFolFactura, True, _alreadyFetchedFacturasClientesCab, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnFacturasClientesCabPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _mfacCatClientes</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMfacCatClientes(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _mfacCatClientes, AddressOf OnMfacCatClientesPropertyChanged, "MfacCatClientes", PagoDeCtesEntity.Relations.MfacCatClientesEntityUsingCveCliente, True, signalRelatedEntity, "PagoDeCtes", resetFKFields, New Integer() { CInt(PagoDeCtesFieldIndex.CveCliente) } )
			_mfacCatClientes = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _mfacCatClientes</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMfacCatClientes(relatedEntity As IEntity)
			DesetupSyncMfacCatClientes(True, True)
			_mfacCatClientes = CType(relatedEntity, MfacCatClientesEntity)
			MyBase.PerformSetupSyncRelatedEntity( _mfacCatClientes, AddressOf OnMfacCatClientesPropertyChanged, "MfacCatClientes", PagoDeCtesEntity.Relations.MfacCatClientesEntityUsingCveCliente, True, _alreadyFetchedMfacCatClientes, New String() {  } )
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
		''' <summary>Removes the sync logic for member _poliza</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncPoliza(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _poliza, AddressOf OnPolizaPropertyChanged, "Poliza", PagoDeCtesEntity.Relations.PolizaEntityUsingIdPoliza, True, signalRelatedEntity, "PagoDeCtes", resetFKFields, New Integer() { CInt(PagoDeCtesFieldIndex.IdPoliza) } )
			_poliza = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _poliza</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncPoliza(relatedEntity As IEntity)
			DesetupSyncPoliza(True, True)
			_poliza = CType(relatedEntity, PolizaEntity)
			MyBase.PerformSetupSyncRelatedEntity( _poliza, AddressOf OnPolizaPropertyChanged, "Poliza", PagoDeCtesEntity.Relations.PolizaEntityUsingIdPoliza, True, _alreadyFetchedPoliza, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnPolizaPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _poliza_</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncPoliza_(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _poliza_, AddressOf OnPoliza_PropertyChanged, "Poliza_", PagoDeCtesEntity.Relations.PolizaEntityUsingIdPolizaCancelacion, True, signalRelatedEntity, "PagoDeCtes_", resetFKFields, New Integer() { CInt(PagoDeCtesFieldIndex.IdPolizaCancelacion) } )
			_poliza_ = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _poliza_</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncPoliza_(relatedEntity As IEntity)
			DesetupSyncPoliza_(True, True)
			_poliza_ = CType(relatedEntity, PolizaEntity)
			MyBase.PerformSetupSyncRelatedEntity( _poliza_, AddressOf OnPoliza_PropertyChanged, "Poliza_", PagoDeCtesEntity.Relations.PolizaEntityUsingIdPolizaCancelacion, True, _alreadyFetchedPoliza_, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnPoliza_PropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="folIngreso">PK value for PagoDeCtes which data should be fetched into this PagoDeCtes Object</param>
		''' <param name="folFactura">PK value for PagoDeCtes which data should be fetched into this PagoDeCtes Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(folIngreso As System.String, folFactura As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(PagoDeCtesFieldIndex.FolIngreso)).ForcedCurrentValueWrite(folIngreso)
				MyBase.Fields(CInt(PagoDeCtesFieldIndex.FolFactura)).ForcedCurrentValueWrite(folFactura)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreatePagoDeCtesDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New PagoDeCtesEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As PagoDeCtesRelations
			Get	
				Return New PagoDeCtesRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'FacturasClientesCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathFacturasClientesCab() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.FacturasClientesCabCollection(), _
					PagoDeCtesEntity.Relations.FacturasClientesCabEntityUsingSerieFacturaFolFactura, _
					CType(Integralab.ORM.EntityType.PagoDeCtesEntity, Integer), CType(Integralab.ORM.EntityType.FacturasClientesCabEntity, Integer), 0, Nothing, Nothing, Nothing, "FacturasClientesCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MfacCatClientes' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMfacCatClientes() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MfacCatClientesCollection(), _
					PagoDeCtesEntity.Relations.MfacCatClientesEntityUsingCveCliente, _
					CType(Integralab.ORM.EntityType.PagoDeCtesEntity, Integer), CType(Integralab.ORM.EntityType.MfacCatClientesEntity, Integer), 0, Nothing, Nothing, Nothing, "MfacCatClientes", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Poliza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPoliza() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PolizaCollection(), _
					PagoDeCtesEntity.Relations.PolizaEntityUsingIdPoliza, _
					CType(Integralab.ORM.EntityType.PagoDeCtesEntity, Integer), CType(Integralab.ORM.EntityType.PolizaEntity, Integer), 0, Nothing, Nothing, Nothing, "Poliza", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Poliza' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPoliza_() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PolizaCollection(), _
					PagoDeCtesEntity.Relations.PolizaEntityUsingIdPolizaCancelacion, _
					CType(Integralab.ORM.EntityType.PagoDeCtesEntity, Integer), CType(Integralab.ORM.EntityType.PolizaEntity, Integer), 0, Nothing, Nothing, Nothing, "Poliza_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "PagoDeCtesEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return PagoDeCtesEntity.CustomProperties
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
				Return PagoDeCtesEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The CveCliente property of the Entity PagoDeCtes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "PagoDeCtes"."Cve_Cliente"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CveCliente]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PagoDeCtesFieldIndex.CveCliente, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(PagoDeCtesFieldIndex.CveCliente, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolIngreso property of the Entity PagoDeCtes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "PagoDeCtes"."Fol_Ingreso"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 8<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [FolIngreso]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PagoDeCtesFieldIndex.FolIngreso, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(PagoDeCtesFieldIndex.FolIngreso, Integer), value)
			End Set
		End Property
	
		''' <summary>The FecIngreso property of the Entity PagoDeCtes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "PagoDeCtes"."Fec_Ingreso"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FecIngreso]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PagoDeCtesFieldIndex.FecIngreso, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(PagoDeCtesFieldIndex.FecIngreso, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolFactura property of the Entity PagoDeCtes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "PagoDeCtes"."Fol_Factura"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [FolFactura]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PagoDeCtesFieldIndex.FolFactura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(PagoDeCtesFieldIndex.FolFactura, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImpteIngreso property of the Entity PagoDeCtes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "PagoDeCtes"."ImpteIngreso"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImpteIngreso]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PagoDeCtesFieldIndex.ImpteIngreso, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(PagoDeCtesFieldIndex.ImpteIngreso, Integer), value)
			End Set
		End Property
	
		''' <summary>The TipoPago property of the Entity PagoDeCtes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "PagoDeCtes"."TipoPago"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 1<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TipoPago]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PagoDeCtesFieldIndex.TipoPago, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(PagoDeCtesFieldIndex.TipoPago, Integer), value)
			End Set
		End Property
	
		''' <summary>The Documento property of the Entity PagoDeCtes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "PagoDeCtes"."Documento"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Documento]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PagoDeCtesFieldIndex.Documento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(PagoDeCtesFieldIndex.Documento, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImpteNotaCred property of the Entity PagoDeCtes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "PagoDeCtes"."ImpteNotaCred"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImpteNotaCred]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PagoDeCtesFieldIndex.ImpteNotaCred, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(PagoDeCtesFieldIndex.ImpteNotaCred, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImpteChePos property of the Entity PagoDeCtes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "PagoDeCtes"."ImpteChePos"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImpteChePos]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PagoDeCtesFieldIndex.ImpteChePos, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(PagoDeCtesFieldIndex.ImpteChePos, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity PagoDeCtes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "PagoDeCtes"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 1<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PagoDeCtesFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(PagoDeCtesFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The CveUser property of the Entity PagoDeCtes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "PagoDeCtes"."CveUser"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CveUser]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PagoDeCtesFieldIndex.CveUser, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(PagoDeCtesFieldIndex.CveUser, Integer), value)
			End Set
		End Property
	
		''' <summary>The CveUserCancel property of the Entity PagoDeCtes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "PagoDeCtes"."CveUserCancel"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CveUserCancel]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PagoDeCtesFieldIndex.CveUserCancel, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(PagoDeCtesFieldIndex.CveUserCancel, Integer), value)
			End Set
		End Property
	
		''' <summary>The FecCancela property of the Entity PagoDeCtes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "PagoDeCtes"."Fec_Cancela"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FecCancela]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PagoDeCtesFieldIndex.FecCancela, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(PagoDeCtesFieldIndex.FecCancela, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImpteFactura property of the Entity PagoDeCtes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "PagoDeCtes"."ImpteFactura"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImpteFactura]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PagoDeCtesFieldIndex.ImpteFactura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(PagoDeCtesFieldIndex.ImpteFactura, Integer), value)
			End Set
		End Property
	
		''' <summary>The SaldoFactura property of the Entity PagoDeCtes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "PagoDeCtes"."SaldoFactura"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SaldoFactura]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PagoDeCtesFieldIndex.SaldoFactura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(PagoDeCtesFieldIndex.SaldoFactura, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdPoliza property of the Entity PagoDeCtes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "PagoDeCtes"."IdPoliza"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdPoliza]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PagoDeCtesFieldIndex.IdPoliza, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(PagoDeCtesFieldIndex.IdPoliza, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdPolizaCancelacion property of the Entity PagoDeCtes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "PagoDeCtes"."IdPolizaCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdPolizaCancelacion]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PagoDeCtesFieldIndex.IdPolizaCancelacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(PagoDeCtesFieldIndex.IdPolizaCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The SerieFactura property of the Entity PagoDeCtes<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "PagoDeCtes"."SerieFactura"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SerieFactura]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PagoDeCtesFieldIndex.SerieFactura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(PagoDeCtesFieldIndex.SerieFactura, Integer), value)
			End Set
		End Property
	
	
	
	
		''' <summary>Gets / sets related entity of type 'FacturasClientesCabEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleFacturasClientesCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [FacturasClientesCab]() As FacturasClientesCabEntity
			Get
				Return GetSingleFacturasClientesCab(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncFacturasClientesCab(value)
				Else
					If value Is Nothing Then
						If Not _facturasClientesCab Is Nothing Then
							_facturasClientesCab.UnsetRelatedEntity(Me, "PagoDeCtes")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "PagoDeCtes")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for FacturasClientesCab. When set to true, FacturasClientesCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time FacturasClientesCab is accessed. You can always execute
		''' a forced fetch by calling GetSingleFacturasClientesCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchFacturasClientesCab As Boolean
			Get
				Return _alwaysFetchFacturasClientesCab
			End Get
			Set
				_alwaysFetchFacturasClientesCab = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property FacturasClientesCab is not found
		''' in the database. When set to true, FacturasClientesCab will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property FacturasClientesCabReturnsNewIfNotFound As Boolean
			Get
				Return _facturasClientesCabReturnsNewIfNotFound
			End Get
			Set
				_facturasClientesCabReturnsNewIfNotFound = value
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
							_mfacCatClientes.UnsetRelatedEntity(Me, "PagoDeCtes")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "PagoDeCtes")
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
	
		''' <summary>Gets / sets related entity of type 'PolizaEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSinglePoliza()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Poliza]() As PolizaEntity
			Get
				Return GetSinglePoliza(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncPoliza(value)
				Else
					If value Is Nothing Then
						If Not _poliza Is Nothing Then
							_poliza.UnsetRelatedEntity(Me, "PagoDeCtes")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "PagoDeCtes")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Poliza. When set to true, Poliza is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Poliza is accessed. You can always execute
		''' a forced fetch by calling GetSinglePoliza(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPoliza As Boolean
			Get
				Return _alwaysFetchPoliza
			End Get
			Set
				_alwaysFetchPoliza = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Poliza is not found
		''' in the database. When set to true, Poliza will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property PolizaReturnsNewIfNotFound As Boolean
			Get
				Return _polizaReturnsNewIfNotFound
			End Get
			Set
				_polizaReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'PolizaEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSinglePoliza_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Poliza_]() As PolizaEntity
			Get
				Return GetSinglePoliza_(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncPoliza_(value)
				Else
					If value Is Nothing Then
						If Not _poliza_ Is Nothing Then
							_poliza_.UnsetRelatedEntity(Me, "PagoDeCtes_")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "PagoDeCtes_")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Poliza_. When set to true, Poliza_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Poliza_ is accessed. You can always execute
		''' a forced fetch by calling GetSinglePoliza_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPoliza_ As Boolean
			Get
				Return _alwaysFetchPoliza_
			End Get
			Set
				_alwaysFetchPoliza_ = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Poliza_ is not found
		''' in the database. When set to true, Poliza_ will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property Poliza_ReturnsNewIfNotFound As Boolean
			Get
				Return _poliza_ReturnsNewIfNotFound
			End Get
			Set
				_poliza_ReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.PagoDeCtesEntity)
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
