' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 25 de enero de 2018 11:40:28
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
	''' <summary>Entity class which represents the entity 'RegistroSacrificiosDet'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class RegistroSacrificiosDetEntity 
#Else
	<Serializable()> _
	Public Class RegistroSacrificiosDetEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"


		Private _registroSacrificiosCab As RegistroSacrificiosCabEntity
		Private _alwaysFetchRegistroSacrificiosCab, _alreadyFetchedRegistroSacrificiosCab, _registroSacrificiosCabReturnsNewIfNotFound As Boolean


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
		''' <param name="loteSacrificio">PK value for RegistroSacrificiosDet which data should be fetched into this RegistroSacrificiosDet Object</param>
		''' <param name="folioCanal">PK value for RegistroSacrificiosDet which data should be fetched into this RegistroSacrificiosDet Object</param>
		Public Sub New(loteSacrificio As System.String, folioCanal As System.String)

			InitClassFetch(loteSacrificio, folioCanal, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="loteSacrificio">PK value for RegistroSacrificiosDet which data should be fetched into this RegistroSacrificiosDet Object</param>
		''' <param name="folioCanal">PK value for RegistroSacrificiosDet which data should be fetched into this RegistroSacrificiosDet Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(loteSacrificio As System.String, folioCanal As System.String, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(loteSacrificio, folioCanal, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="loteSacrificio">PK value for RegistroSacrificiosDet which data should be fetched into this RegistroSacrificiosDet Object</param>
		''' <param name="folioCanal">PK value for RegistroSacrificiosDet which data should be fetched into this RegistroSacrificiosDet Object</param>
		''' <param name="validator">The custom validator Object for this RegistroSacrificiosDetEntity</param>
		Public Sub New(loteSacrificio As System.String, folioCanal As System.String, validator As IValidator)

			InitClassFetch(loteSacrificio, folioCanal, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)


			_registroSacrificiosCab = CType(info.GetValue("_registroSacrificiosCab", GetType(RegistroSacrificiosCabEntity)), RegistroSacrificiosCabEntity)
			If Not _registroSacrificiosCab Is Nothing Then
				AddHandler _registroSacrificiosCab.AfterSave, AddressOf OnEntityAfterSave
			End If
			_registroSacrificiosCabReturnsNewIfNotFound = info.GetBoolean("_registroSacrificiosCabReturnsNewIfNotFound")
			_alwaysFetchRegistroSacrificiosCab = info.GetBoolean("_alwaysFetchRegistroSacrificiosCab")
			_alreadyFetchedRegistroSacrificiosCab = info.GetBoolean("_alreadyFetchedRegistroSacrificiosCab")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()


			_alreadyFetchedRegistroSacrificiosCab = Not(_registroSacrificiosCab Is Nothing)

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


			info.AddValue("_registroSacrificiosCab", _registroSacrificiosCab)
			info.AddValue("_registroSacrificiosCabReturnsNewIfNotFound", _registroSacrificiosCabReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchRegistroSacrificiosCab", _alwaysFetchRegistroSacrificiosCab)
			info.AddValue("_alreadyFetchedRegistroSacrificiosCab", _alreadyFetchedRegistroSacrificiosCab)

			
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
				Case "RegistroSacrificiosCab"
					_alreadyFetchedRegistroSacrificiosCab = True
					Me.RegistroSacrificiosCab = CType(entity, RegistroSacrificiosCabEntity)



				Case Else

			End Select
		End Sub

		''' <summary>Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		''' <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		<EditorBrowsable(EditorBrowsableState.Never)> _
		Public Overrides Overloads Sub SetRelatedEntity(relatedEntity As IEntity, fieldName As String)
			Select Case fieldName
				Case "RegistroSacrificiosCab"
					SetupSyncRegistroSacrificiosCab(relatedEntity)
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
				Case "RegistroSacrificiosCab"
					DesetupSyncRegistroSacrificiosCab(False, True)
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
			If Not _registroSacrificiosCab Is Nothing Then
				toReturn.Add(_registroSacrificiosCab)
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
		''' <param name="loteSacrificio">PK value for RegistroSacrificiosDet which data should be fetched into this RegistroSacrificiosDet Object</param>
		''' <param name="folioCanal">PK value for RegistroSacrificiosDet which data should be fetched into this RegistroSacrificiosDet Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(loteSacrificio As System.String, folioCanal As System.String) As Boolean
			Return FetchUsingPK(loteSacrificio, folioCanal, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="loteSacrificio">PK value for RegistroSacrificiosDet which data should be fetched into this RegistroSacrificiosDet Object</param>
		''' <param name="folioCanal">PK value for RegistroSacrificiosDet which data should be fetched into this RegistroSacrificiosDet Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(loteSacrificio As System.String, folioCanal As System.String, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(loteSacrificio, folioCanal, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="loteSacrificio">PK value for RegistroSacrificiosDet which data should be fetched into this RegistroSacrificiosDet Object</param>
		''' <param name="folioCanal">PK value for RegistroSacrificiosDet which data should be fetched into this RegistroSacrificiosDet Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(loteSacrificio As System.String, folioCanal As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(loteSacrificio, folioCanal, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.LoteSacrificio, Me.FolioCanal, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As RegistroSacrificiosDetFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As RegistroSacrificiosDetFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



	

		''' <summary>Retrieves the related entity of type 'RegistroSacrificiosCabEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'RegistroSacrificiosCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleRegistroSacrificiosCab() As RegistroSacrificiosCabEntity
			Return GetSingleRegistroSacrificiosCab(False)
		End Function

		''' <summary>Retrieves the related entity of type 'RegistroSacrificiosCabEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'RegistroSacrificiosCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleRegistroSacrificiosCab(forceFetch As Boolean) As RegistroSacrificiosCabEntity
			If ( Not _alreadyFetchedRegistroSacrificiosCab Or forceFetch Or _alwaysFetchRegistroSacrificiosCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New RegistroSacrificiosCabEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(RegistroSacrificiosDetEntity.Relations.RegistroSacrificiosCabEntityUsingLoteSacrificio) Then
					fetchResult = newEntity.FetchUsingPK(Me.LoteSacrificio)
				End If
				If Not _registroSacrificiosCabReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.RegistroSacrificiosCab = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), RegistroSacrificiosCabEntity)
					End If
					Me.RegistroSacrificiosCab = newEntity
					_alreadyFetchedRegistroSacrificiosCab = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _registroSacrificiosCab
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(RegistroSacrificiosDetFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, RegistroSacrificiosDetFieldIndex)
					Case RegistroSacrificiosDetFieldIndex.LoteSacrificio
						DesetupSyncRegistroSacrificiosCab(True, False)
						_alreadyFetchedRegistroSacrificiosCab = False








					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()


		If Not _registroSacrificiosCab Is Nothing Then
				_registroSacrificiosCab.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As RegistroSacrificiosDetDAO = CType(CreateDAOInstance(), RegistroSacrificiosDetDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As RegistroSacrificiosDetDAO = CType(CreateDAOInstance(), RegistroSacrificiosDetDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As RegistroSacrificiosDetDAO = CType(CreateDAOInstance(), RegistroSacrificiosDetDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this RegistroSacrificiosDetEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.RegistroSacrificiosDetEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="loteSacrificio">PK value for RegistroSacrificiosDet which data should be fetched into this RegistroSacrificiosDet Object</param>
		''' <param name="folioCanal">PK value for RegistroSacrificiosDet which data should be fetched into this RegistroSacrificiosDet Object</param>
		''' <param name="validator">The validator Object for this RegistroSacrificiosDetEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(loteSacrificio As System.String, folioCanal As System.String, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(loteSacrificio, folioCanal, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()


			_registroSacrificiosCab = Nothing
			_registroSacrificiosCabReturnsNewIfNotFound = True
			_alwaysFetchRegistroSacrificiosCab = False
			_alreadyFetchedRegistroSacrificiosCab = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("LoteSacrificio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioCanal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Lado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("KilosCalientes", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCaptura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("KilosFrios", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Rendimiento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("LoteCorte", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _registroSacrificiosCab</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncRegistroSacrificiosCab(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _registroSacrificiosCab, AddressOf OnRegistroSacrificiosCabPropertyChanged, "RegistroSacrificiosCab", RegistroSacrificiosDetEntity.Relations.RegistroSacrificiosCabEntityUsingLoteSacrificio, True, signalRelatedEntity, "RegistroSacrificiosDet", resetFKFields, New Integer() { CInt(RegistroSacrificiosDetFieldIndex.LoteSacrificio) } )
			_registroSacrificiosCab = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _registroSacrificiosCab</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncRegistroSacrificiosCab(relatedEntity As IEntity)
			DesetupSyncRegistroSacrificiosCab(True, True)
			_registroSacrificiosCab = CType(relatedEntity, RegistroSacrificiosCabEntity)
			MyBase.PerformSetupSyncRelatedEntity( _registroSacrificiosCab, AddressOf OnRegistroSacrificiosCabPropertyChanged, "RegistroSacrificiosCab", RegistroSacrificiosDetEntity.Relations.RegistroSacrificiosCabEntityUsingLoteSacrificio, True, _alreadyFetchedRegistroSacrificiosCab, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnRegistroSacrificiosCabPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="loteSacrificio">PK value for RegistroSacrificiosDet which data should be fetched into this RegistroSacrificiosDet Object</param>
		''' <param name="folioCanal">PK value for RegistroSacrificiosDet which data should be fetched into this RegistroSacrificiosDet Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(loteSacrificio As System.String, folioCanal As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(RegistroSacrificiosDetFieldIndex.LoteSacrificio)).ForcedCurrentValueWrite(loteSacrificio)
				MyBase.Fields(CInt(RegistroSacrificiosDetFieldIndex.FolioCanal)).ForcedCurrentValueWrite(folioCanal)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateRegistroSacrificiosDetDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New RegistroSacrificiosDetEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As RegistroSacrificiosDetRelations
			Get	
				Return New RegistroSacrificiosDetRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RegistroSacrificiosCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathRegistroSacrificiosCab() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.RegistroSacrificiosCabCollection(), _
					RegistroSacrificiosDetEntity.Relations.RegistroSacrificiosCabEntityUsingLoteSacrificio, _
					CType(Integralab.ORM.EntityType.RegistroSacrificiosDetEntity, Integer), CType(Integralab.ORM.EntityType.RegistroSacrificiosCabEntity, Integer), 0, Nothing, Nothing, Nothing, "RegistroSacrificiosCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "RegistroSacrificiosDetEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return RegistroSacrificiosDetEntity.CustomProperties
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
				Return RegistroSacrificiosDetEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The LoteSacrificio property of the Entity RegistroSacrificiosDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "RegistroSacrificiosDet"."LoteSacrificio"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [LoteSacrificio]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RegistroSacrificiosDetFieldIndex.LoteSacrificio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(RegistroSacrificiosDetFieldIndex.LoteSacrificio, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioCanal property of the Entity RegistroSacrificiosDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "RegistroSacrificiosDet"."FolioCanal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 15<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [FolioCanal]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RegistroSacrificiosDetFieldIndex.FolioCanal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(RegistroSacrificiosDetFieldIndex.FolioCanal, Integer), value)
			End Set
		End Property
	
		''' <summary>The Lado property of the Entity RegistroSacrificiosDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "RegistroSacrificiosDet"."Lado"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Lado]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RegistroSacrificiosDetFieldIndex.Lado, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(RegistroSacrificiosDetFieldIndex.Lado, Integer), value)
			End Set
		End Property
	
		''' <summary>The KilosCalientes property of the Entity RegistroSacrificiosDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "RegistroSacrificiosDet"."KilosCalientes"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [KilosCalientes]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RegistroSacrificiosDetFieldIndex.KilosCalientes, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(RegistroSacrificiosDetFieldIndex.KilosCalientes, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCaptura property of the Entity RegistroSacrificiosDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "RegistroSacrificiosDet"."FechaCaptura"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaCaptura]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RegistroSacrificiosDetFieldIndex.FechaCaptura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(RegistroSacrificiosDetFieldIndex.FechaCaptura, Integer), value)
			End Set
		End Property
	
		''' <summary>The KilosFrios property of the Entity RegistroSacrificiosDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "RegistroSacrificiosDet"."KilosFrios"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [KilosFrios]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RegistroSacrificiosDetFieldIndex.KilosFrios, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(RegistroSacrificiosDetFieldIndex.KilosFrios, Integer), value)
			End Set
		End Property
	
		''' <summary>The Rendimiento property of the Entity RegistroSacrificiosDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "RegistroSacrificiosDet"."Rendimiento"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallMoney, 10, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Rendimiento]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RegistroSacrificiosDetFieldIndex.Rendimiento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(RegistroSacrificiosDetFieldIndex.Rendimiento, Integer), value)
			End Set
		End Property
	
		''' <summary>The LoteCorte property of the Entity RegistroSacrificiosDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "RegistroSacrificiosDet"."LoteCorte"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [LoteCorte]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RegistroSacrificiosDetFieldIndex.LoteCorte, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(RegistroSacrificiosDetFieldIndex.LoteCorte, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity RegistroSacrificiosDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "RegistroSacrificiosDet"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 1<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(RegistroSacrificiosDetFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(RegistroSacrificiosDetFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
	
	
	
		''' <summary>Gets / sets related entity of type 'RegistroSacrificiosCabEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleRegistroSacrificiosCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [RegistroSacrificiosCab]() As RegistroSacrificiosCabEntity
			Get
				Return GetSingleRegistroSacrificiosCab(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncRegistroSacrificiosCab(value)
				Else
					If value Is Nothing Then
						If Not _registroSacrificiosCab Is Nothing Then
							_registroSacrificiosCab.UnsetRelatedEntity(Me, "RegistroSacrificiosDet")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "RegistroSacrificiosDet")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for RegistroSacrificiosCab. When set to true, RegistroSacrificiosCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time RegistroSacrificiosCab is accessed. You can always execute
		''' a forced fetch by calling GetSingleRegistroSacrificiosCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchRegistroSacrificiosCab As Boolean
			Get
				Return _alwaysFetchRegistroSacrificiosCab
			End Get
			Set
				_alwaysFetchRegistroSacrificiosCab = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property RegistroSacrificiosCab is not found
		''' in the database. When set to true, RegistroSacrificiosCab will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property RegistroSacrificiosCabReturnsNewIfNotFound As Boolean
			Get
				Return _registroSacrificiosCabReturnsNewIfNotFound
			End Get
			Set
				_registroSacrificiosCabReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.RegistroSacrificiosDetEntity)
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
