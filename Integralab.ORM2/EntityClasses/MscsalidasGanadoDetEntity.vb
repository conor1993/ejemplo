﻿' ////////////////////////////////////////////////////////////////////////////////////////////////////////
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
	''' <summary>Entity class which represents the entity 'MscsalidasGanadoDet'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class MscsalidasGanadoDetEntity 
#Else
	<Serializable()> _
	Public Class MscsalidasGanadoDetEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END
			

#Region "Class Member Declarations"


		Private _mscsalidasGanadoCab As MscsalidasGanadoCabEntity
		Private _alwaysFetchMscsalidasGanadoCab, _alreadyFetchedMscsalidasGanadoCab, _mscsalidasGanadoCabReturnsNewIfNotFound As Boolean


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
		''' <param name="folioSalidaGanado">PK value for MscsalidasGanadoDet which data should be fetched into this MscsalidasGanadoDet Object</param>
		''' <param name="codTipoGanado">PK value for MscsalidasGanadoDet which data should be fetched into this MscsalidasGanadoDet Object</param>
		Public Sub New(folioSalidaGanado As System.String, codTipoGanado As System.String)

			InitClassFetch(folioSalidaGanado, codTipoGanado, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folioSalidaGanado">PK value for MscsalidasGanadoDet which data should be fetched into this MscsalidasGanadoDet Object</param>
		''' <param name="codTipoGanado">PK value for MscsalidasGanadoDet which data should be fetched into this MscsalidasGanadoDet Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(folioSalidaGanado As System.String, codTipoGanado As System.String, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(folioSalidaGanado, codTipoGanado, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folioSalidaGanado">PK value for MscsalidasGanadoDet which data should be fetched into this MscsalidasGanadoDet Object</param>
		''' <param name="codTipoGanado">PK value for MscsalidasGanadoDet which data should be fetched into this MscsalidasGanadoDet Object</param>
		''' <param name="validator">The custom validator Object for this MscsalidasGanadoDetEntity</param>
		Public Sub New(folioSalidaGanado As System.String, codTipoGanado As System.String, validator As IValidator)

			InitClassFetch(folioSalidaGanado, codTipoGanado, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)


			_mscsalidasGanadoCab = CType(info.GetValue("_mscsalidasGanadoCab", GetType(MscsalidasGanadoCabEntity)), MscsalidasGanadoCabEntity)
			If Not _mscsalidasGanadoCab Is Nothing Then
				AddHandler _mscsalidasGanadoCab.AfterSave, AddressOf OnEntityAfterSave
			End If
			_mscsalidasGanadoCabReturnsNewIfNotFound = info.GetBoolean("_mscsalidasGanadoCabReturnsNewIfNotFound")
			_alwaysFetchMscsalidasGanadoCab = info.GetBoolean("_alwaysFetchMscsalidasGanadoCab")
			_alreadyFetchedMscsalidasGanadoCab = info.GetBoolean("_alreadyFetchedMscsalidasGanadoCab")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
			
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()


			_alreadyFetchedMscsalidasGanadoCab = Not(_mscsalidasGanadoCab Is Nothing)

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


			info.AddValue("_mscsalidasGanadoCab", _mscsalidasGanadoCab)
			info.AddValue("_mscsalidasGanadoCabReturnsNewIfNotFound", _mscsalidasGanadoCabReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMscsalidasGanadoCab", _alwaysFetchMscsalidasGanadoCab)
			info.AddValue("_alreadyFetchedMscsalidasGanadoCab", _alreadyFetchedMscsalidasGanadoCab)

			
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
				Case "MscsalidasGanadoCab"
					_alreadyFetchedMscsalidasGanadoCab = True
					Me.MscsalidasGanadoCab = CType(entity, MscsalidasGanadoCabEntity)



				Case Else

			End Select
		End Sub

		''' <summary>Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		''' <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		<EditorBrowsable(EditorBrowsableState.Never)> _
		Public Overrides Overloads Sub SetRelatedEntity(relatedEntity As IEntity, fieldName As String)
			Select Case fieldName
				Case "MscsalidasGanadoCab"
					SetupSyncMscsalidasGanadoCab(relatedEntity)
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
				Case "MscsalidasGanadoCab"
					DesetupSyncMscsalidasGanadoCab(False, True)
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
			If Not _mscsalidasGanadoCab Is Nothing Then
				toReturn.Add(_mscsalidasGanadoCab)
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
		''' <param name="folioSalidaGanado">PK value for MscsalidasGanadoDet which data should be fetched into this MscsalidasGanadoDet Object</param>
		''' <param name="codTipoGanado">PK value for MscsalidasGanadoDet which data should be fetched into this MscsalidasGanadoDet Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folioSalidaGanado As System.String, codTipoGanado As System.String) As Boolean
			Return FetchUsingPK(folioSalidaGanado, codTipoGanado, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folioSalidaGanado">PK value for MscsalidasGanadoDet which data should be fetched into this MscsalidasGanadoDet Object</param>
		''' <param name="codTipoGanado">PK value for MscsalidasGanadoDet which data should be fetched into this MscsalidasGanadoDet Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folioSalidaGanado As System.String, codTipoGanado As System.String, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(folioSalidaGanado, codTipoGanado, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folioSalidaGanado">PK value for MscsalidasGanadoDet which data should be fetched into this MscsalidasGanadoDet Object</param>
		''' <param name="codTipoGanado">PK value for MscsalidasGanadoDet which data should be fetched into this MscsalidasGanadoDet Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folioSalidaGanado As System.String, codTipoGanado As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(folioSalidaGanado, codTipoGanado, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.FolioSalidaGanado, Me.CodTipoGanado, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As MscsalidasGanadoDetFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As MscsalidasGanadoDetFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



	

		''' <summary>Retrieves the related entity of type 'MscsalidasGanadoCabEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'MscsalidasGanadoCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMscsalidasGanadoCab() As MscsalidasGanadoCabEntity
			Return GetSingleMscsalidasGanadoCab(False)
		End Function

		''' <summary>Retrieves the related entity of type 'MscsalidasGanadoCabEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'MscsalidasGanadoCabEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMscsalidasGanadoCab(forceFetch As Boolean) As MscsalidasGanadoCabEntity
			If ( Not _alreadyFetchedMscsalidasGanadoCab Or forceFetch Or _alwaysFetchMscsalidasGanadoCab) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New MscsalidasGanadoCabEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(MscsalidasGanadoDetEntity.Relations.MscsalidasGanadoCabEntityUsingFolioSalidaGanado) Then
					fetchResult = newEntity.FetchUsingPK(Me.FolioSalidaGanado)
				End If
				If Not _mscsalidasGanadoCabReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.MscsalidasGanadoCab = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), MscsalidasGanadoCabEntity)
					End If
					Me.MscsalidasGanadoCab = newEntity
					_alreadyFetchedMscsalidasGanadoCab = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _mscsalidasGanadoCab
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(MscsalidasGanadoDetFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, MscsalidasGanadoDetFieldIndex)
					Case MscsalidasGanadoDetFieldIndex.FolioSalidaGanado
						DesetupSyncMscsalidasGanadoCab(True, False)
						_alreadyFetchedMscsalidasGanadoCab = False





					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()


		If Not _mscsalidasGanadoCab Is Nothing Then
				_mscsalidasGanadoCab.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As MscsalidasGanadoDetDAO = CType(CreateDAOInstance(), MscsalidasGanadoDetDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As MscsalidasGanadoDetDAO = CType(CreateDAOInstance(), MscsalidasGanadoDetDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As MscsalidasGanadoDetDAO = CType(CreateDAOInstance(), MscsalidasGanadoDetDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this MscsalidasGanadoDetEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.MscsalidasGanadoDetEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="folioSalidaGanado">PK value for MscsalidasGanadoDet which data should be fetched into this MscsalidasGanadoDet Object</param>
		''' <param name="codTipoGanado">PK value for MscsalidasGanadoDet which data should be fetched into this MscsalidasGanadoDet Object</param>
		''' <param name="validator">The validator Object for this MscsalidasGanadoDetEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(folioSalidaGanado As System.String, codTipoGanado As System.String, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(folioSalidaGanado, codTipoGanado, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()


			_mscsalidasGanadoCab = Nothing
			_mscsalidasGanadoCabReturnsNewIfNotFound = True
			_alwaysFetchMscsalidasGanadoCab = False
			_alreadyFetchedMscsalidasGanadoCab = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
			
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioSalidaGanado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CodTipoGanado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CantCabezas", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CantKilos", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CostoxKilo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Importe", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _mscsalidasGanadoCab</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMscsalidasGanadoCab(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _mscsalidasGanadoCab, AddressOf OnMscsalidasGanadoCabPropertyChanged, "MscsalidasGanadoCab", MscsalidasGanadoDetEntity.Relations.MscsalidasGanadoCabEntityUsingFolioSalidaGanado, True, signalRelatedEntity, "MscsalidasGanadoDet", resetFKFields, New Integer() { CInt(MscsalidasGanadoDetFieldIndex.FolioSalidaGanado) } )
			_mscsalidasGanadoCab = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _mscsalidasGanadoCab</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMscsalidasGanadoCab(relatedEntity As IEntity)
			DesetupSyncMscsalidasGanadoCab(True, True)
			_mscsalidasGanadoCab = CType(relatedEntity, MscsalidasGanadoCabEntity)
			MyBase.PerformSetupSyncRelatedEntity( _mscsalidasGanadoCab, AddressOf OnMscsalidasGanadoCabPropertyChanged, "MscsalidasGanadoCab", MscsalidasGanadoDetEntity.Relations.MscsalidasGanadoCabEntityUsingFolioSalidaGanado, True, _alreadyFetchedMscsalidasGanadoCab, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMscsalidasGanadoCabPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="folioSalidaGanado">PK value for MscsalidasGanadoDet which data should be fetched into this MscsalidasGanadoDet Object</param>
		''' <param name="codTipoGanado">PK value for MscsalidasGanadoDet which data should be fetched into this MscsalidasGanadoDet Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(folioSalidaGanado As System.String, codTipoGanado As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(MscsalidasGanadoDetFieldIndex.FolioSalidaGanado)).ForcedCurrentValueWrite(folioSalidaGanado)
				MyBase.Fields(CInt(MscsalidasGanadoDetFieldIndex.CodTipoGanado)).ForcedCurrentValueWrite(codTipoGanado)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateMscsalidasGanadoDetDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New MscsalidasGanadoDetEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As MscsalidasGanadoDetRelations
			Get	
				Return New MscsalidasGanadoDetRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MscsalidasGanadoCab' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMscsalidasGanadoCab() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MscsalidasGanadoCabCollection(), _
					MscsalidasGanadoDetEntity.Relations.MscsalidasGanadoCabEntityUsingFolioSalidaGanado, _
					CType(Integralab.ORM.EntityType.MscsalidasGanadoDetEntity, Integer), CType(Integralab.ORM.EntityType.MscsalidasGanadoCabEntity, Integer), 0, Nothing, Nothing, Nothing, "MscsalidasGanadoCab", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "MscsalidasGanadoDetEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return MscsalidasGanadoDetEntity.CustomProperties
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
				Return MscsalidasGanadoDetEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The FolioSalidaGanado property of the Entity MscsalidasGanadoDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCSalidasGanadoDet"."FolioSalidaGanado"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [FolioSalidaGanado]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscsalidasGanadoDetFieldIndex.FolioSalidaGanado, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MscsalidasGanadoDetFieldIndex.FolioSalidaGanado, Integer), value)
			End Set
		End Property
	
		''' <summary>The CodTipoGanado property of the Entity MscsalidasGanadoDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCSalidasGanadoDet"."CodTipoGanado"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 6<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [CodTipoGanado]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscsalidasGanadoDetFieldIndex.CodTipoGanado, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(MscsalidasGanadoDetFieldIndex.CodTipoGanado, Integer), value)
			End Set
		End Property
	
		''' <summary>The CantCabezas property of the Entity MscsalidasGanadoDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCSalidasGanadoDet"."CantCabezas"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CantCabezas]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscsalidasGanadoDetFieldIndex.CantCabezas, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MscsalidasGanadoDetFieldIndex.CantCabezas, Integer), value)
			End Set
		End Property
	
		''' <summary>The CantKilos property of the Entity MscsalidasGanadoDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCSalidasGanadoDet"."CantKilos"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CantKilos]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscsalidasGanadoDetFieldIndex.CantKilos, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(MscsalidasGanadoDetFieldIndex.CantKilos, Integer), value)
			End Set
		End Property
	
		''' <summary>The CostoxKilo property of the Entity MscsalidasGanadoDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCSalidasGanadoDet"."CostoxKilo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CostoxKilo]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscsalidasGanadoDetFieldIndex.CostoxKilo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(MscsalidasGanadoDetFieldIndex.CostoxKilo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Importe property of the Entity MscsalidasGanadoDet<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MSCSalidasGanadoDet"."Importe"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Importe]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MscsalidasGanadoDetFieldIndex.Importe, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(MscsalidasGanadoDetFieldIndex.Importe, Integer), value)
			End Set
		End Property
	
	
	
	
		''' <summary>Gets / sets related entity of type 'MscsalidasGanadoCabEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMscsalidasGanadoCab()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [MscsalidasGanadoCab]() As MscsalidasGanadoCabEntity
			Get
				Return GetSingleMscsalidasGanadoCab(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMscsalidasGanadoCab(value)
				Else
					If value Is Nothing Then
						If Not _mscsalidasGanadoCab Is Nothing Then
							_mscsalidasGanadoCab.UnsetRelatedEntity(Me, "MscsalidasGanadoDet")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "MscsalidasGanadoDet")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for MscsalidasGanadoCab. When set to true, MscsalidasGanadoCab is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MscsalidasGanadoCab is accessed. You can always execute
		''' a forced fetch by calling GetSingleMscsalidasGanadoCab(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMscsalidasGanadoCab As Boolean
			Get
				Return _alwaysFetchMscsalidasGanadoCab
			End Get
			Set
				_alwaysFetchMscsalidasGanadoCab = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property MscsalidasGanadoCab is not found
		''' in the database. When set to true, MscsalidasGanadoCab will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property MscsalidasGanadoCabReturnsNewIfNotFound As Boolean
			Get
				Return _mscsalidasGanadoCabReturnsNewIfNotFound
			End Get
			Set
				_mscsalidasGanadoCabReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.MscsalidasGanadoDetEntity)
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
