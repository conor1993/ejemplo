﻿' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 12 de julio de 2018 17:43:03
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
	''' <summary>Entity class which represents the entity 'MotivoBajaDetalle'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class MotivoBajaDetalleEntity 
#Else
	<Serializable()> _
	Public Class MotivoBajaDetalleEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"


		Private _modulo As ModuloEntity
		Private _alwaysFetchModulo, _alreadyFetchedModulo, _moduloReturnsNewIfNotFound As Boolean
		Private _motivoBaja As MotivoBajaEntity
		Private _alwaysFetchMotivoBaja, _alreadyFetchedMotivoBaja, _motivoBajaReturnsNewIfNotFound As Boolean


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
		''' <param name="idmotivo">PK value for MotivoBajaDetalle which data should be fetched into this MotivoBajaDetalle Object</param>
		''' <param name="idmodulo">PK value for MotivoBajaDetalle which data should be fetched into this MotivoBajaDetalle Object</param>
		Public Sub New(idmotivo As System.Int32, idmodulo As System.Int32)

			InitClassFetch(idmotivo, idmodulo, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idmotivo">PK value for MotivoBajaDetalle which data should be fetched into this MotivoBajaDetalle Object</param>
		''' <param name="idmodulo">PK value for MotivoBajaDetalle which data should be fetched into this MotivoBajaDetalle Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(idmotivo As System.Int32, idmodulo As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(idmotivo, idmodulo, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idmotivo">PK value for MotivoBajaDetalle which data should be fetched into this MotivoBajaDetalle Object</param>
		''' <param name="idmodulo">PK value for MotivoBajaDetalle which data should be fetched into this MotivoBajaDetalle Object</param>
		''' <param name="validator">The custom validator Object for this MotivoBajaDetalleEntity</param>
		Public Sub New(idmotivo As System.Int32, idmodulo As System.Int32, validator As IValidator)

			InitClassFetch(idmotivo, idmodulo, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)


			_modulo = CType(info.GetValue("_modulo", GetType(ModuloEntity)), ModuloEntity)
			If Not _modulo Is Nothing Then
				AddHandler _modulo.AfterSave, AddressOf OnEntityAfterSave
			End If
			_moduloReturnsNewIfNotFound = info.GetBoolean("_moduloReturnsNewIfNotFound")
			_alwaysFetchModulo = info.GetBoolean("_alwaysFetchModulo")
			_alreadyFetchedModulo = info.GetBoolean("_alreadyFetchedModulo")
			_motivoBaja = CType(info.GetValue("_motivoBaja", GetType(MotivoBajaEntity)), MotivoBajaEntity)
			If Not _motivoBaja Is Nothing Then
				AddHandler _motivoBaja.AfterSave, AddressOf OnEntityAfterSave
			End If
			_motivoBajaReturnsNewIfNotFound = info.GetBoolean("_motivoBajaReturnsNewIfNotFound")
			_alwaysFetchMotivoBaja = info.GetBoolean("_alwaysFetchMotivoBaja")
			_alreadyFetchedMotivoBaja = info.GetBoolean("_alreadyFetchedMotivoBaja")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()


			_alreadyFetchedModulo = Not(_modulo Is Nothing)
			_alreadyFetchedMotivoBaja = Not(_motivoBaja Is Nothing)

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


			info.AddValue("_modulo", _modulo)
			info.AddValue("_moduloReturnsNewIfNotFound", _moduloReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchModulo", _alwaysFetchModulo)
			info.AddValue("_alreadyFetchedModulo", _alreadyFetchedModulo)
			info.AddValue("_motivoBaja", _motivoBaja)
			info.AddValue("_motivoBajaReturnsNewIfNotFound", _motivoBajaReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMotivoBaja", _alwaysFetchMotivoBaja)
			info.AddValue("_alreadyFetchedMotivoBaja", _alreadyFetchedMotivoBaja)

			
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
				Case "Modulo"
					_alreadyFetchedModulo = True
					Me.Modulo = CType(entity, ModuloEntity)
				Case "MotivoBaja"
					_alreadyFetchedMotivoBaja = True
					Me.MotivoBaja = CType(entity, MotivoBajaEntity)



				Case Else

			End Select
		End Sub

		''' <summary>Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		''' <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		<EditorBrowsable(EditorBrowsableState.Never)> _
		Public Overrides Overloads Sub SetRelatedEntity(relatedEntity As IEntity, fieldName As String)
			Select Case fieldName
				Case "Modulo"
					SetupSyncModulo(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "MotivoBaja"
					SetupSyncMotivoBaja(relatedEntity)
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
				Case "Modulo"
					DesetupSyncModulo(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "MotivoBaja"
					DesetupSyncMotivoBaja(False, True)
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
			If Not _modulo Is Nothing Then
				toReturn.Add(_modulo)
			End If
			If Not _motivoBaja Is Nothing Then
				toReturn.Add(_motivoBaja)
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
		''' <param name="idmotivo">PK value for MotivoBajaDetalle which data should be fetched into this MotivoBajaDetalle Object</param>
		''' <param name="idmodulo">PK value for MotivoBajaDetalle which data should be fetched into this MotivoBajaDetalle Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idmotivo As System.Int32, idmodulo As System.Int32) As Boolean
			Return FetchUsingPK(idmotivo, idmodulo, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idmotivo">PK value for MotivoBajaDetalle which data should be fetched into this MotivoBajaDetalle Object</param>
		''' <param name="idmodulo">PK value for MotivoBajaDetalle which data should be fetched into this MotivoBajaDetalle Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idmotivo As System.Int32, idmodulo As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(idmotivo, idmodulo, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idmotivo">PK value for MotivoBajaDetalle which data should be fetched into this MotivoBajaDetalle Object</param>
		''' <param name="idmodulo">PK value for MotivoBajaDetalle which data should be fetched into this MotivoBajaDetalle Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idmotivo As System.Int32, idmodulo As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(idmotivo, idmodulo, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.Idmotivo, Me.Idmodulo, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As MotivoBajaDetalleFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As MotivoBajaDetalleFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



	

		''' <summary>Retrieves the related entity of type 'ModuloEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'ModuloEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleModulo() As ModuloEntity
			Return GetSingleModulo(False)
		End Function

		''' <summary>Retrieves the related entity of type 'ModuloEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'ModuloEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleModulo(forceFetch As Boolean) As ModuloEntity
			If ( Not _alreadyFetchedModulo Or forceFetch Or _alwaysFetchModulo) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New ModuloEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(MotivoBajaDetalleEntity.Relations.ModuloEntityUsingIdmodulo) Then
					fetchResult = newEntity.FetchUsingPK(Me.Idmodulo)
				End If
				If Not _moduloReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Modulo = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), ModuloEntity)
					End If
					Me.Modulo = newEntity
					_alreadyFetchedModulo = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _modulo
		End Function
	
		''' <summary>Retrieves the related entity of type 'MotivoBajaEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'MotivoBajaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMotivoBaja() As MotivoBajaEntity
			Return GetSingleMotivoBaja(False)
		End Function

		''' <summary>Retrieves the related entity of type 'MotivoBajaEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'MotivoBajaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMotivoBaja(forceFetch As Boolean) As MotivoBajaEntity
			If ( Not _alreadyFetchedMotivoBaja Or forceFetch Or _alwaysFetchMotivoBaja) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New MotivoBajaEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(MotivoBajaDetalleEntity.Relations.MotivoBajaEntityUsingIdmotivo) Then
					fetchResult = newEntity.FetchUsingPK(Me.Idmotivo)
				End If
				If Not _motivoBajaReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.MotivoBaja = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), MotivoBajaEntity)
					End If
					Me.MotivoBaja = newEntity
					_alreadyFetchedMotivoBaja = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _motivoBaja
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(MotivoBajaDetalleFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, MotivoBajaDetalleFieldIndex)
					Case MotivoBajaDetalleFieldIndex.Idmotivo
						DesetupSyncMotivoBaja(True, False)
						_alreadyFetchedMotivoBaja = False
					Case MotivoBajaDetalleFieldIndex.Idmodulo
						DesetupSyncModulo(True, False)
						_alreadyFetchedModulo = False
					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()


		If Not _modulo Is Nothing Then
				_modulo.ActiveContext = MyBase.ActiveContext
			End If
		If Not _motivoBaja Is Nothing Then
				_motivoBaja.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As MotivoBajaDetalleDAO = CType(CreateDAOInstance(), MotivoBajaDetalleDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As MotivoBajaDetalleDAO = CType(CreateDAOInstance(), MotivoBajaDetalleDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As MotivoBajaDetalleDAO = CType(CreateDAOInstance(), MotivoBajaDetalleDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this MotivoBajaDetalleEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.MotivoBajaDetalleEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="idmotivo">PK value for MotivoBajaDetalle which data should be fetched into this MotivoBajaDetalle Object</param>
		''' <param name="idmodulo">PK value for MotivoBajaDetalle which data should be fetched into this MotivoBajaDetalle Object</param>
		''' <param name="validator">The validator Object for this MotivoBajaDetalleEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(idmotivo As System.Int32, idmodulo As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(idmotivo, idmodulo, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()


			_modulo = Nothing
			_moduloReturnsNewIfNotFound = True
			_alwaysFetchModulo = False
			_alreadyFetchedModulo = False
			_motivoBaja = Nothing
			_motivoBajaReturnsNewIfNotFound = True
			_alwaysFetchMotivoBaja = False
			_alreadyFetchedMotivoBaja = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Idmotivo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Idmodulo", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _modulo</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncModulo(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _modulo, AddressOf OnModuloPropertyChanged, "Modulo", MotivoBajaDetalleEntity.Relations.ModuloEntityUsingIdmodulo, True, signalRelatedEntity, "MotivosBajaDetalle", resetFKFields, New Integer() { CInt(MotivoBajaDetalleFieldIndex.Idmodulo) } )
			_modulo = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _modulo</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncModulo(relatedEntity As IEntity)
			DesetupSyncModulo(True, True)
			_modulo = CType(relatedEntity, ModuloEntity)
			MyBase.PerformSetupSyncRelatedEntity( _modulo, AddressOf OnModuloPropertyChanged, "Modulo", MotivoBajaDetalleEntity.Relations.ModuloEntityUsingIdmodulo, True, _alreadyFetchedModulo, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnModuloPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _motivoBaja</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMotivoBaja(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _motivoBaja, AddressOf OnMotivoBajaPropertyChanged, "MotivoBaja", MotivoBajaDetalleEntity.Relations.MotivoBajaEntityUsingIdmotivo, True, signalRelatedEntity, "MotivosBajaDetalle", resetFKFields, New Integer() { CInt(MotivoBajaDetalleFieldIndex.Idmotivo) } )
			_motivoBaja = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _motivoBaja</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMotivoBaja(relatedEntity As IEntity)
			DesetupSyncMotivoBaja(True, True)
			_motivoBaja = CType(relatedEntity, MotivoBajaEntity)
			MyBase.PerformSetupSyncRelatedEntity( _motivoBaja, AddressOf OnMotivoBajaPropertyChanged, "MotivoBaja", MotivoBajaDetalleEntity.Relations.MotivoBajaEntityUsingIdmotivo, True, _alreadyFetchedMotivoBaja, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMotivoBajaPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="idmotivo">PK value for MotivoBajaDetalle which data should be fetched into this MotivoBajaDetalle Object</param>
		''' <param name="idmodulo">PK value for MotivoBajaDetalle which data should be fetched into this MotivoBajaDetalle Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(idmotivo As System.Int32, idmodulo As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(MotivoBajaDetalleFieldIndex.Idmotivo)).ForcedCurrentValueWrite(idmotivo)
				MyBase.Fields(CInt(MotivoBajaDetalleFieldIndex.Idmodulo)).ForcedCurrentValueWrite(idmodulo)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateMotivoBajaDetalleDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New MotivoBajaDetalleEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As MotivoBajaDetalleRelations
			Get	
				Return New MotivoBajaDetalleRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Modulo' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathModulo() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ModuloCollection(), _
					MotivoBajaDetalleEntity.Relations.ModuloEntityUsingIdmodulo, _
					CType(Integralab.ORM.EntityType.MotivoBajaDetalleEntity, Integer), CType(Integralab.ORM.EntityType.ModuloEntity, Integer), 0, Nothing, Nothing, Nothing, "Modulo", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MotivoBaja' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMotivoBaja() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MotivoBajaCollection(), _
					MotivoBajaDetalleEntity.Relations.MotivoBajaEntityUsingIdmotivo, _
					CType(Integralab.ORM.EntityType.MotivoBajaDetalleEntity, Integer), CType(Integralab.ORM.EntityType.MotivoBajaEntity, Integer), 0, Nothing, Nothing, Nothing, "MotivoBaja", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "MotivoBajaDetalleEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return MotivoBajaDetalleEntity.CustomProperties
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
				Return MotivoBajaDetalleEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The Idmotivo property of the Entity MotivoBajaDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenMotivosBajaDetalle"."IDMotivo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [Idmotivo]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MotivoBajaDetalleFieldIndex.Idmotivo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MotivoBajaDetalleFieldIndex.Idmotivo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Idmodulo property of the Entity MotivoBajaDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MCatGenMotivosBajaDetalle"."IDModulo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [Idmodulo]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(MotivoBajaDetalleFieldIndex.Idmodulo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(MotivoBajaDetalleFieldIndex.Idmodulo, Integer), value)
			End Set
		End Property
	
	
	
	
		''' <summary>Gets / sets related entity of type 'ModuloEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleModulo()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Modulo]() As ModuloEntity
			Get
				Return GetSingleModulo(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncModulo(value)
				Else
					If value Is Nothing Then
						If Not _modulo Is Nothing Then
							_modulo.UnsetRelatedEntity(Me, "MotivosBajaDetalle")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "MotivosBajaDetalle")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Modulo. When set to true, Modulo is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Modulo is accessed. You can always execute
		''' a forced fetch by calling GetSingleModulo(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchModulo As Boolean
			Get
				Return _alwaysFetchModulo
			End Get
			Set
				_alwaysFetchModulo = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Modulo is not found
		''' in the database. When set to true, Modulo will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property ModuloReturnsNewIfNotFound As Boolean
			Get
				Return _moduloReturnsNewIfNotFound
			End Get
			Set
				_moduloReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'MotivoBajaEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMotivoBaja()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [MotivoBaja]() As MotivoBajaEntity
			Get
				Return GetSingleMotivoBaja(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMotivoBaja(value)
				Else
					If value Is Nothing Then
						If Not _motivoBaja Is Nothing Then
							_motivoBaja.UnsetRelatedEntity(Me, "MotivosBajaDetalle")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "MotivosBajaDetalle")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for MotivoBaja. When set to true, MotivoBaja is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MotivoBaja is accessed. You can always execute
		''' a forced fetch by calling GetSingleMotivoBaja(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMotivoBaja As Boolean
			Get
				Return _alwaysFetchMotivoBaja
			End Get
			Set
				_alwaysFetchMotivoBaja = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property MotivoBaja is not found
		''' in the database. When set to true, MotivoBaja will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property MotivoBajaReturnsNewIfNotFound As Boolean
			Get
				Return _motivoBajaReturnsNewIfNotFound
			End Get
			Set
				_motivoBajaReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.MotivoBajaDetalleEntity)
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
