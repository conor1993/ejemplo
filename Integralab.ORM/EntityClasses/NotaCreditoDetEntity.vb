' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 2 de marzo de 2018 16:12:40
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
	''' <summary>Entity class which represents the entity 'NotaCreditoDet'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class NotaCreditoDetEntity 
#Else
	<Serializable()> _
	Public Class NotaCreditoDetEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"


		Private _facturasClientesCab As FacturasClientesCabEntity
		Private _alwaysFetchFacturasClientesCab, _alreadyFetchedFacturasClientesCab, _facturasClientesCabReturnsNewIfNotFound As Boolean
		Private _notaCreditoCab As NotaCreditoCabEntity
		Private _alwaysFetchNotaCreditoCab, _alreadyFetchedNotaCreditoCab, _notaCreditoCabReturnsNewIfNotFound As Boolean


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
		''' <param name="folNota">PK value for NotaCreditoDet which data should be fetched into this NotaCreditoDet Object</param>
		''' <param name="folFactura">PK value for NotaCreditoDet which data should be fetched into this NotaCreditoDet Object</param>
		Public Sub New(folNota As System.String, folFactura As System.String)

			InitClassFetch(folNota, folFactura, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folNota">PK value for NotaCreditoDet which data should be fetched into this NotaCreditoDet Object</param>
		''' <param name="folFactura">PK value for NotaCreditoDet which data should be fetched into this NotaCreditoDet Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(folNota As System.String, folFactura As System.String, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(folNota, folFactura, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folNota">PK value for NotaCreditoDet which data should be fetched into this NotaCreditoDet Object</param>
		''' <param name="folFactura">PK value for NotaCreditoDet which data should be fetched into this NotaCreditoDet Object</param>
		''' <param name="validator">The custom validator Object for this NotaCreditoDetEntity</param>
		Public Sub New(folNota As System.String, folFactura As System.String, validator As IValidator)

			InitClassFetch(folNota, folFactura, validator, Nothing)
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
			_notaCreditoCab = CType(info.GetValue("_notaCreditoCab", GetType(NotaCreditoCabEntity)), NotaCreditoCabEntity)
			If Not _notaCreditoCab Is Nothing Then
				AddHandler _notaCreditoCab.AfterSave, AddressOf OnEntityAfterSave
			End If
			_notaCreditoCabReturnsNewIfNotFound = info.GetBoolean("_notaCreditoCabReturnsNewIfNotFound")
			_alwaysFetchNotaCreditoCab = info.GetBoolean("_alwaysFetchNotaCreditoCab")
			_alreadyFetchedNotaCreditoCab = info.GetBoolean("_alreadyFetchedNotaCreditoCab")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()


			_alreadyFetchedFacturasClientesCab = Not(_facturasClientesCab Is Nothing)
			_alreadyFetchedNotaCreditoCab = Not(_notaCreditoCab Is Nothing)

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
			info.AddValue("_notaCreditoCab", _notaCreditoCab)
			info.AddValue("_notaCreditoCabReturnsNewIfNotFound", _notaCreditoCabReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchNotaCreditoCab", _alwaysFetchNotaCreditoCab)
			info.AddValue("_alreadyFetchedNotaCreditoCab", _alreadyFetchedNotaCreditoCab)

			
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
				Case "NotaCreditoCab"
					_alreadyFetchedNotaCreditoCab = True
					Me.NotaCreditoCab = CType(entity, NotaCreditoCabEntity)



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
				Case "NotaCreditoCab"
					SetupSyncNotaCreditoCab(relatedEntity)
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
				Case "NotaCreditoCab"
					DesetupSyncNotaCreditoCab(False, True)
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
			If Not _notaCreditoCab Is Nothing Then
				toReturn.Add(_notaCreditoCab)
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
		''' <param name="folNota">PK value for NotaCreditoDet which data should be fetched into this NotaCreditoDet Object</param>
		''' <param name="folFactura">PK value for NotaCreditoDet which data should be fetched into this NotaCreditoDet Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folNota As System.String, folFactura As System.String) As Boolean
			Return FetchUsingPK(folNota, folFactura, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folNota">PK value for NotaCreditoDet which data should be fetched into this NotaCreditoDet Object</param>
		''' <param name="folFactura">PK value for NotaCreditoDet which data should be fetched into this NotaCreditoDet Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folNota As System.String, folFactura As System.String, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(folNota, folFactura, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folNota">PK value for NotaCreditoDet which data should be fetched into this NotaCreditoDet Object</param>
		''' <param name="folFactura">PK value for NotaCreditoDet which data should be fetched into this NotaCreditoDet Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folNota As System.String, folFactura As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(folNota, folFactura, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.FolNota, Me.FolFactura, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As NotaCreditoDetFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As NotaCreditoDetFieldIndex) As Boolean
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
				If MyBase.CheckIfLazyLoadingShouldOccur(NotaCreditoDetEntity.Relations.FacturasClientesCabEntityUsingSerieFacturaFolFactura) Then
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
	
		''' <summary>Retrieves the related entity of type 'NotaCreditoCabEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'NotaCreditoCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleNotaCreditoCab() As NotaCreditoCabEntity
			Return GetSingleNotaCreditoCab(False)
		End Function

		''' <summary>Retrieves the related entity of type 'NotaCreditoCabEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'NotaCreditoCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleNotaCreditoCab(forceFetch As Boolean) As NotaCreditoCabEntity
			If ( Not _alreadyFetchedNotaCreditoCab Or forceFetch Or _alwaysFetchNotaCreditoCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New NotaCreditoCabEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(NotaCreditoDetEntity.Relations.NotaCreditoCabEntityUsingFolNota) Then
					fetchResult = newEntity.FetchUsingPK(Me.FolNota)
				End If
				If Not _notaCreditoCabReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.NotaCreditoCab = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), NotaCreditoCabEntity)
					End If
					Me.NotaCreditoCab = newEntity
					_alreadyFetchedNotaCreditoCab = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _notaCreditoCab
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(NotaCreditoDetFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, NotaCreditoDetFieldIndex)
					Case NotaCreditoDetFieldIndex.FolNota
						DesetupSyncNotaCreditoCab(True, False)
						_alreadyFetchedNotaCreditoCab = False
					Case NotaCreditoDetFieldIndex.FolFactura
						DesetupSyncFacturasClientesCab(True, False)
						_alreadyFetchedFacturasClientesCab = False









					Case NotaCreditoDetFieldIndex.SerieFactura
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
		If Not _notaCreditoCab Is Nothing Then
				_notaCreditoCab.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As NotaCreditoDetDAO = CType(CreateDAOInstance(), NotaCreditoDetDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As NotaCreditoDetDAO = CType(CreateDAOInstance(), NotaCreditoDetDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As NotaCreditoDetDAO = CType(CreateDAOInstance(), NotaCreditoDetDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this NotaCreditoDetEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.NotaCreditoDetEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="folNota">PK value for NotaCreditoDet which data should be fetched into this NotaCreditoDet Object</param>
		''' <param name="folFactura">PK value for NotaCreditoDet which data should be fetched into this NotaCreditoDet Object</param>
		''' <param name="validator">The validator Object for this NotaCreditoDetEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(folNota As System.String, folFactura As System.String, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(folNota, folFactura, prefetchPathToUse, Nothing)
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
			_notaCreditoCab = Nothing
			_notaCreditoCabReturnsNewIfNotFound = True
			_alwaysFetchNotaCreditoCab = False
			_alreadyFetchedNotaCreditoCab = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolNota", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolFactura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SubTotal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImpteIva", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Total", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FecAplica", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Cheque", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("OrigenCta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Aplicar", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolPago", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SerieFactura", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _facturasClientesCab</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncFacturasClientesCab(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _facturasClientesCab, AddressOf OnFacturasClientesCabPropertyChanged, "FacturasClientesCab", NotaCreditoDetEntity.Relations.FacturasClientesCabEntityUsingSerieFacturaFolFactura, True, signalRelatedEntity, "NotaCreditoDet", resetFKFields, New Integer() { CInt(NotaCreditoDetFieldIndex.SerieFactura), CInt(NotaCreditoDetFieldIndex.FolFactura) } )
			_facturasClientesCab = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _facturasClientesCab</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncFacturasClientesCab(relatedEntity As IEntity)
			DesetupSyncFacturasClientesCab(True, True)
			_facturasClientesCab = CType(relatedEntity, FacturasClientesCabEntity)
			MyBase.PerformSetupSyncRelatedEntity( _facturasClientesCab, AddressOf OnFacturasClientesCabPropertyChanged, "FacturasClientesCab", NotaCreditoDetEntity.Relations.FacturasClientesCabEntityUsingSerieFacturaFolFactura, True, _alreadyFetchedFacturasClientesCab, New String() {  } )
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
		''' <summary>Removes the sync logic for member _notaCreditoCab</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncNotaCreditoCab(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _notaCreditoCab, AddressOf OnNotaCreditoCabPropertyChanged, "NotaCreditoCab", NotaCreditoDetEntity.Relations.NotaCreditoCabEntityUsingFolNota, True, signalRelatedEntity, "NotaCreditoDet", resetFKFields, New Integer() { CInt(NotaCreditoDetFieldIndex.FolNota) } )
			_notaCreditoCab = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _notaCreditoCab</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncNotaCreditoCab(relatedEntity As IEntity)
			DesetupSyncNotaCreditoCab(True, True)
			_notaCreditoCab = CType(relatedEntity, NotaCreditoCabEntity)
			MyBase.PerformSetupSyncRelatedEntity( _notaCreditoCab, AddressOf OnNotaCreditoCabPropertyChanged, "NotaCreditoCab", NotaCreditoDetEntity.Relations.NotaCreditoCabEntityUsingFolNota, True, _alreadyFetchedNotaCreditoCab, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnNotaCreditoCabPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="folNota">PK value for NotaCreditoDet which data should be fetched into this NotaCreditoDet Object</param>
		''' <param name="folFactura">PK value for NotaCreditoDet which data should be fetched into this NotaCreditoDet Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(folNota As System.String, folFactura As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(NotaCreditoDetFieldIndex.FolNota)).ForcedCurrentValueWrite(folNota)
				MyBase.Fields(CInt(NotaCreditoDetFieldIndex.FolFactura)).ForcedCurrentValueWrite(folFactura)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateNotaCreditoDetDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New NotaCreditoDetEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As NotaCreditoDetRelations
			Get	
				Return New NotaCreditoDetRelations() 
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
					NotaCreditoDetEntity.Relations.FacturasClientesCabEntityUsingSerieFacturaFolFactura, _
					CType(Integralab.ORM.EntityType.NotaCreditoDetEntity, Integer), CType(Integralab.ORM.EntityType.FacturasClientesCabEntity, Integer), 0, Nothing, Nothing, Nothing, "FacturasClientesCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'NotaCreditoCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathNotaCreditoCab() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.NotaCreditoCabCollection(), _
					NotaCreditoDetEntity.Relations.NotaCreditoCabEntityUsingFolNota, _
					CType(Integralab.ORM.EntityType.NotaCreditoDetEntity, Integer), CType(Integralab.ORM.EntityType.NotaCreditoCabEntity, Integer), 0, Nothing, Nothing, Nothing, "NotaCreditoCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "NotaCreditoDetEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return NotaCreditoDetEntity.CustomProperties
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
				Return NotaCreditoDetEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The FolNota property of the Entity NotaCreditoDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NotaCreditoDet"."Fol_Nota"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 8<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [FolNota]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NotaCreditoDetFieldIndex.FolNota, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(NotaCreditoDetFieldIndex.FolNota, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolFactura property of the Entity NotaCreditoDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NotaCreditoDet"."Fol_Factura"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [FolFactura]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NotaCreditoDetFieldIndex.FolFactura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(NotaCreditoDetFieldIndex.FolFactura, Integer), value)
			End Set
		End Property
	
		''' <summary>The SubTotal property of the Entity NotaCreditoDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NotaCreditoDet"."SubTotal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SubTotal]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NotaCreditoDetFieldIndex.SubTotal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NotaCreditoDetFieldIndex.SubTotal, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImpteIva property of the Entity NotaCreditoDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NotaCreditoDet"."ImpteIVA"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImpteIva]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NotaCreditoDetFieldIndex.ImpteIva, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NotaCreditoDetFieldIndex.ImpteIva, Integer), value)
			End Set
		End Property
	
		''' <summary>The Total property of the Entity NotaCreditoDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NotaCreditoDet"."Total"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Total]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NotaCreditoDetFieldIndex.Total, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NotaCreditoDetFieldIndex.Total, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity NotaCreditoDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NotaCreditoDet"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Byte
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NotaCreditoDetFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Byte))
				End If
				Return CType(valueToReturn, System.Byte)
			End Get
			Set
				SetNewFieldValue(CType(NotaCreditoDetFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The FecAplica property of the Entity NotaCreditoDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NotaCreditoDet"."Fec_Aplica"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FecAplica]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NotaCreditoDetFieldIndex.FecAplica, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(NotaCreditoDetFieldIndex.FecAplica, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cheque property of the Entity NotaCreditoDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NotaCreditoDet"."Cheque"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 8<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Cheque]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NotaCreditoDetFieldIndex.Cheque, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(NotaCreditoDetFieldIndex.Cheque, Integer), value)
			End Set
		End Property
	
		''' <summary>The OrigenCta property of the Entity NotaCreditoDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NotaCreditoDet"."OrigenCta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 2<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [OrigenCta]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NotaCreditoDetFieldIndex.OrigenCta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(NotaCreditoDetFieldIndex.OrigenCta, Integer), value)
			End Set
		End Property
	
		''' <summary>The Aplicar property of the Entity NotaCreditoDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NotaCreditoDet"."Aplicar"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Aplicar]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NotaCreditoDetFieldIndex.Aplicar, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(NotaCreditoDetFieldIndex.Aplicar, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolPago property of the Entity NotaCreditoDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NotaCreditoDet"."Fol_Pago"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 8<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FolPago]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NotaCreditoDetFieldIndex.FolPago, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(NotaCreditoDetFieldIndex.FolPago, Integer), value)
			End Set
		End Property
	
		''' <summary>The SerieFactura property of the Entity NotaCreditoDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NotaCreditoDet"."SerieFactura"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SerieFactura]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NotaCreditoDetFieldIndex.SerieFactura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(NotaCreditoDetFieldIndex.SerieFactura, Integer), value)
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
							_facturasClientesCab.UnsetRelatedEntity(Me, "NotaCreditoDet")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "NotaCreditoDet")
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
	
		''' <summary>Gets / sets related entity of type 'NotaCreditoCabEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleNotaCreditoCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [NotaCreditoCab]() As NotaCreditoCabEntity
			Get
				Return GetSingleNotaCreditoCab(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncNotaCreditoCab(value)
				Else
					If value Is Nothing Then
						If Not _notaCreditoCab Is Nothing Then
							_notaCreditoCab.UnsetRelatedEntity(Me, "NotaCreditoDet")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "NotaCreditoDet")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for NotaCreditoCab. When set to true, NotaCreditoCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time NotaCreditoCab is accessed. You can always execute
		''' a forced fetch by calling GetSingleNotaCreditoCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchNotaCreditoCab As Boolean
			Get
				Return _alwaysFetchNotaCreditoCab
			End Get
			Set
				_alwaysFetchNotaCreditoCab = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property NotaCreditoCab is not found
		''' in the database. When set to true, NotaCreditoCab will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property NotaCreditoCabReturnsNewIfNotFound As Boolean
			Get
				Return _notaCreditoCabReturnsNewIfNotFound
			End Get
			Set
				_notaCreditoCabReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.NotaCreditoDetEntity)
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
