﻿' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 11 de diciembre de 2017 20:57:30
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
	''' <summary>Entity class which represents the entity 'UsrCxpfacturasApagar'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class UsrCxpfacturasApagarEntity 
#Else
	<Serializable()> _
	Public Class UsrCxpfacturasApagarEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END
			

#Region "Class Member Declarations"


		Private _proveedor As ProveedorEntity
		Private _alwaysFetchProveedor, _alreadyFetchedProveedor, _proveedorReturnsNewIfNotFound As Boolean


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
		''' <param name="empresaId">PK value for UsrCxpfacturasApagar which data should be fetched into this UsrCxpfacturasApagar Object</param>
		''' <param name="idProveedor">PK value for UsrCxpfacturasApagar which data should be fetched into this UsrCxpfacturasApagar Object</param>
		''' <param name="noFactura">PK value for UsrCxpfacturasApagar which data should be fetched into this UsrCxpfacturasApagar Object</param>
		Public Sub New(empresaId As System.Int32, idProveedor As System.Int32, noFactura As System.String)

			InitClassFetch(empresaId, idProveedor, noFactura, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="empresaId">PK value for UsrCxpfacturasApagar which data should be fetched into this UsrCxpfacturasApagar Object</param>
		''' <param name="idProveedor">PK value for UsrCxpfacturasApagar which data should be fetched into this UsrCxpfacturasApagar Object</param>
		''' <param name="noFactura">PK value for UsrCxpfacturasApagar which data should be fetched into this UsrCxpfacturasApagar Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(empresaId As System.Int32, idProveedor As System.Int32, noFactura As System.String, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(empresaId, idProveedor, noFactura, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="empresaId">PK value for UsrCxpfacturasApagar which data should be fetched into this UsrCxpfacturasApagar Object</param>
		''' <param name="idProveedor">PK value for UsrCxpfacturasApagar which data should be fetched into this UsrCxpfacturasApagar Object</param>
		''' <param name="noFactura">PK value for UsrCxpfacturasApagar which data should be fetched into this UsrCxpfacturasApagar Object</param>
		''' <param name="validator">The custom validator Object for this UsrCxpfacturasApagarEntity</param>
		Public Sub New(empresaId As System.Int32, idProveedor As System.Int32, noFactura As System.String, validator As IValidator)

			InitClassFetch(empresaId, idProveedor, noFactura, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)


			_proveedor = CType(info.GetValue("_proveedor", GetType(ProveedorEntity)), ProveedorEntity)
			If Not _proveedor Is Nothing Then
				AddHandler _proveedor.AfterSave, AddressOf OnEntityAfterSave
			End If
			_proveedorReturnsNewIfNotFound = info.GetBoolean("_proveedorReturnsNewIfNotFound")
			_alwaysFetchProveedor = info.GetBoolean("_alwaysFetchProveedor")
			_alreadyFetchedProveedor = info.GetBoolean("_alreadyFetchedProveedor")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
			
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()


			_alreadyFetchedProveedor = Not(_proveedor Is Nothing)

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


			info.AddValue("_proveedor", _proveedor)
			info.AddValue("_proveedorReturnsNewIfNotFound", _proveedorReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchProveedor", _alwaysFetchProveedor)
			info.AddValue("_alreadyFetchedProveedor", _alreadyFetchedProveedor)

			
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
				Case "Proveedor"
					_alreadyFetchedProveedor = True
					Me.Proveedor = CType(entity, ProveedorEntity)



				Case Else

			End Select
		End Sub

		''' <summary>Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		''' <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		<EditorBrowsable(EditorBrowsableState.Never)> _
		Public Overrides Overloads Sub SetRelatedEntity(relatedEntity As IEntity, fieldName As String)
			Select Case fieldName
				Case "Proveedor"
					SetupSyncProveedor(relatedEntity)
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
				Case "Proveedor"
					DesetupSyncProveedor(False, True)
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
			If Not _proveedor Is Nothing Then
				toReturn.Add(_proveedor)
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
		''' <param name="empresaId">PK value for UsrCxpfacturasApagar which data should be fetched into this UsrCxpfacturasApagar Object</param>
		''' <param name="idProveedor">PK value for UsrCxpfacturasApagar which data should be fetched into this UsrCxpfacturasApagar Object</param>
		''' <param name="noFactura">PK value for UsrCxpfacturasApagar which data should be fetched into this UsrCxpfacturasApagar Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(empresaId As System.Int32, idProveedor As System.Int32, noFactura As System.String) As Boolean
			Return FetchUsingPK(empresaId, idProveedor, noFactura, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="empresaId">PK value for UsrCxpfacturasApagar which data should be fetched into this UsrCxpfacturasApagar Object</param>
		''' <param name="idProveedor">PK value for UsrCxpfacturasApagar which data should be fetched into this UsrCxpfacturasApagar Object</param>
		''' <param name="noFactura">PK value for UsrCxpfacturasApagar which data should be fetched into this UsrCxpfacturasApagar Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(empresaId As System.Int32, idProveedor As System.Int32, noFactura As System.String, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(empresaId, idProveedor, noFactura, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="empresaId">PK value for UsrCxpfacturasApagar which data should be fetched into this UsrCxpfacturasApagar Object</param>
		''' <param name="idProveedor">PK value for UsrCxpfacturasApagar which data should be fetched into this UsrCxpfacturasApagar Object</param>
		''' <param name="noFactura">PK value for UsrCxpfacturasApagar which data should be fetched into this UsrCxpfacturasApagar Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(empresaId As System.Int32, idProveedor As System.Int32, noFactura As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(empresaId, idProveedor, noFactura, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.EmpresaId, Me.IdProveedor, Me.NoFactura, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As UsrCxpfacturasApagarFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As UsrCxpfacturasApagarFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



	

		''' <summary>Retrieves the related entity of type 'ProveedorEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'ProveedorEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleProveedor() As ProveedorEntity
			Return GetSingleProveedor(False)
		End Function

		''' <summary>Retrieves the related entity of type 'ProveedorEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'ProveedorEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleProveedor(forceFetch As Boolean) As ProveedorEntity
			If ( Not _alreadyFetchedProveedor Or forceFetch Or _alwaysFetchProveedor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New ProveedorEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(UsrCxpfacturasApagarEntity.Relations.ProveedorEntityUsingIdProveedor) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdProveedor)
				End If
				If Not _proveedorReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Proveedor = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), ProveedorEntity)
					End If
					Me.Proveedor = newEntity
					_alreadyFetchedProveedor = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _proveedor
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(UsrCxpfacturasApagarFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, UsrCxpfacturasApagarFieldIndex)

					Case UsrCxpfacturasApagarFieldIndex.IdProveedor
						DesetupSyncProveedor(True, False)
						_alreadyFetchedProveedor = False









					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()


		If Not _proveedor Is Nothing Then
				_proveedor.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As UsrCxpfacturasApagarDAO = CType(CreateDAOInstance(), UsrCxpfacturasApagarDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As UsrCxpfacturasApagarDAO = CType(CreateDAOInstance(), UsrCxpfacturasApagarDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As UsrCxpfacturasApagarDAO = CType(CreateDAOInstance(), UsrCxpfacturasApagarDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this UsrCxpfacturasApagarEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.UsrCxpfacturasApagarEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="empresaId">PK value for UsrCxpfacturasApagar which data should be fetched into this UsrCxpfacturasApagar Object</param>
		''' <param name="idProveedor">PK value for UsrCxpfacturasApagar which data should be fetched into this UsrCxpfacturasApagar Object</param>
		''' <param name="noFactura">PK value for UsrCxpfacturasApagar which data should be fetched into this UsrCxpfacturasApagar Object</param>
		''' <param name="validator">The validator Object for this UsrCxpfacturasApagarEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(empresaId As System.Int32, idProveedor As System.Int32, noFactura As System.String, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(empresaId, idProveedor, noFactura, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()


			_proveedor = Nothing
			_proveedorReturnsNewIfNotFound = True
			_alwaysFetchProveedor = False
			_alreadyFetchedProveedor = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
			
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EmpresaId", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdProveedor", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("NoFactura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaVencimiento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteTotal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteAbono", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteApagar", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Saldo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaProgramacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdUsuarioAutorizacion", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _proveedor</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncProveedor(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _proveedor, AddressOf OnProveedorPropertyChanged, "Proveedor", UsrCxpfacturasApagarEntity.Relations.ProveedorEntityUsingIdProveedor, True, signalRelatedEntity, "UsrCxpfacturasApagar", resetFKFields, New Integer() { CInt(UsrCxpfacturasApagarFieldIndex.IdProveedor) } )
			_proveedor = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _proveedor</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncProveedor(relatedEntity As IEntity)
			DesetupSyncProveedor(True, True)
			_proveedor = CType(relatedEntity, ProveedorEntity)
			MyBase.PerformSetupSyncRelatedEntity( _proveedor, AddressOf OnProveedorPropertyChanged, "Proveedor", UsrCxpfacturasApagarEntity.Relations.ProveedorEntityUsingIdProveedor, True, _alreadyFetchedProveedor, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnProveedorPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="empresaId">PK value for UsrCxpfacturasApagar which data should be fetched into this UsrCxpfacturasApagar Object</param>
		''' <param name="idProveedor">PK value for UsrCxpfacturasApagar which data should be fetched into this UsrCxpfacturasApagar Object</param>
		''' <param name="noFactura">PK value for UsrCxpfacturasApagar which data should be fetched into this UsrCxpfacturasApagar Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(empresaId As System.Int32, idProveedor As System.Int32, noFactura As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(UsrCxpfacturasApagarFieldIndex.EmpresaId)).ForcedCurrentValueWrite(empresaId)
				MyBase.Fields(CInt(UsrCxpfacturasApagarFieldIndex.IdProveedor)).ForcedCurrentValueWrite(idProveedor)
				MyBase.Fields(CInt(UsrCxpfacturasApagarFieldIndex.NoFactura)).ForcedCurrentValueWrite(noFactura)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateUsrCxpfacturasApagarDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New UsrCxpfacturasApagarEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As UsrCxpfacturasApagarRelations
			Get	
				Return New UsrCxpfacturasApagarRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Proveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProveedor() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProveedorCollection(), _
					UsrCxpfacturasApagarEntity.Relations.ProveedorEntityUsingIdProveedor, _
					CType(Integralab.ORM.EntityType.UsrCxpfacturasApagarEntity, Integer), CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), 0, Nothing, Nothing, Nothing, "Proveedor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "UsrCxpfacturasApagarEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return UsrCxpfacturasApagarEntity.CustomProperties
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
				Return UsrCxpfacturasApagarEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The EmpresaId property of the Entity UsrCxpfacturasApagar<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasApagar"."EmpresaId"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [EmpresaId]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasApagarFieldIndex.EmpresaId, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasApagarFieldIndex.EmpresaId, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdProveedor property of the Entity UsrCxpfacturasApagar<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasApagar"."IdProveedor"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [IdProveedor]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasApagarFieldIndex.IdProveedor, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasApagarFieldIndex.IdProveedor, Integer), value)
			End Set
		End Property
	
		''' <summary>The NoFactura property of the Entity UsrCxpfacturasApagar<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasApagar"."NoFactura"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [NoFactura]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasApagarFieldIndex.NoFactura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasApagarFieldIndex.NoFactura, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaVencimiento property of the Entity UsrCxpfacturasApagar<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasApagar"."FechaVencimiento"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaVencimiento]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasApagarFieldIndex.FechaVencimiento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasApagarFieldIndex.FechaVencimiento, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteTotal property of the Entity UsrCxpfacturasApagar<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasApagar"."ImporteTotal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteTotal]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasApagarFieldIndex.ImporteTotal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasApagarFieldIndex.ImporteTotal, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteAbono property of the Entity UsrCxpfacturasApagar<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasApagar"."ImporteAbono"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteAbono]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasApagarFieldIndex.ImporteAbono, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasApagarFieldIndex.ImporteAbono, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteApagar property of the Entity UsrCxpfacturasApagar<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasApagar"."ImporteApagar"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImporteApagar]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasApagarFieldIndex.ImporteApagar, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasApagarFieldIndex.ImporteApagar, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity UsrCxpfacturasApagar<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasApagar"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasApagarFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasApagarFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The Saldo property of the Entity UsrCxpfacturasApagar<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasApagar"."Saldo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Saldo]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasApagarFieldIndex.Saldo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasApagarFieldIndex.Saldo, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaProgramacion property of the Entity UsrCxpfacturasApagar<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasApagar"."FechaProgramacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaProgramacion]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasApagarFieldIndex.FechaProgramacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasApagarFieldIndex.FechaProgramacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdUsuarioAutorizacion property of the Entity UsrCxpfacturasApagar<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "usrCXPFacturasApagar"."IdUsuarioAutorizacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdUsuarioAutorizacion]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(UsrCxpfacturasApagarFieldIndex.IdUsuarioAutorizacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(UsrCxpfacturasApagarFieldIndex.IdUsuarioAutorizacion, Integer), value)
			End Set
		End Property
	
	
	
	
		''' <summary>Gets / sets related entity of type 'ProveedorEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleProveedor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Proveedor]() As ProveedorEntity
			Get
				Return GetSingleProveedor(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncProveedor(value)
				Else
					If value Is Nothing Then
						If Not _proveedor Is Nothing Then
							_proveedor.UnsetRelatedEntity(Me, "UsrCxpfacturasApagar")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "UsrCxpfacturasApagar")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Proveedor. When set to true, Proveedor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Proveedor is accessed. You can always execute
		''' a forced fetch by calling GetSingleProveedor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProveedor As Boolean
			Get
				Return _alwaysFetchProveedor
			End Get
			Set
				_alwaysFetchProveedor = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Proveedor is not found
		''' in the database. When set to true, Proveedor will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property ProveedorReturnsNewIfNotFound As Boolean
			Get
				Return _proveedorReturnsNewIfNotFound
			End Get
			Set
				_proveedorReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.UsrCxpfacturasApagarEntity)
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
