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
	''' <summary>Entity class which represents the entity 'NomCatEmpleados'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class NomCatEmpleadosEntity 
#Else
	<Serializable()> _
	Public Class NomCatEmpleadosEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"


		Private _catDeptos As CatDeptosEntity
		Private _alwaysFetchCatDeptos, _alreadyFetchedCatDeptos, _catDeptosReturnsNewIfNotFound As Boolean
		Private _nomCatPuestos As NomCatPuestosEntity
		Private _alwaysFetchNomCatPuestos, _alreadyFetchedNomCatPuestos, _nomCatPuestosReturnsNewIfNotFound As Boolean


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
		''' <param name="codigo">PK value for NomCatEmpleados which data should be fetched into this NomCatEmpleados Object</param>
		Public Sub New(codigo As System.Int32)

			InitClassFetch(codigo, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for NomCatEmpleados which data should be fetched into this NomCatEmpleados Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(codigo As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(codigo, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for NomCatEmpleados which data should be fetched into this NomCatEmpleados Object</param>
		''' <param name="validator">The custom validator Object for this NomCatEmpleadosEntity</param>
		Public Sub New(codigo As System.Int32, validator As IValidator)

			InitClassFetch(codigo, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)


			_catDeptos = CType(info.GetValue("_catDeptos", GetType(CatDeptosEntity)), CatDeptosEntity)
			If Not _catDeptos Is Nothing Then
				AddHandler _catDeptos.AfterSave, AddressOf OnEntityAfterSave
			End If
			_catDeptosReturnsNewIfNotFound = info.GetBoolean("_catDeptosReturnsNewIfNotFound")
			_alwaysFetchCatDeptos = info.GetBoolean("_alwaysFetchCatDeptos")
			_alreadyFetchedCatDeptos = info.GetBoolean("_alreadyFetchedCatDeptos")
			_nomCatPuestos = CType(info.GetValue("_nomCatPuestos", GetType(NomCatPuestosEntity)), NomCatPuestosEntity)
			If Not _nomCatPuestos Is Nothing Then
				AddHandler _nomCatPuestos.AfterSave, AddressOf OnEntityAfterSave
			End If
			_nomCatPuestosReturnsNewIfNotFound = info.GetBoolean("_nomCatPuestosReturnsNewIfNotFound")
			_alwaysFetchNomCatPuestos = info.GetBoolean("_alwaysFetchNomCatPuestos")
			_alreadyFetchedNomCatPuestos = info.GetBoolean("_alreadyFetchedNomCatPuestos")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()


			_alreadyFetchedCatDeptos = Not(_catDeptos Is Nothing)
			_alreadyFetchedNomCatPuestos = Not(_nomCatPuestos Is Nothing)

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


			info.AddValue("_catDeptos", _catDeptos)
			info.AddValue("_catDeptosReturnsNewIfNotFound", _catDeptosReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchCatDeptos", _alwaysFetchCatDeptos)
			info.AddValue("_alreadyFetchedCatDeptos", _alreadyFetchedCatDeptos)
			info.AddValue("_nomCatPuestos", _nomCatPuestos)
			info.AddValue("_nomCatPuestosReturnsNewIfNotFound", _nomCatPuestosReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchNomCatPuestos", _alwaysFetchNomCatPuestos)
			info.AddValue("_alreadyFetchedNomCatPuestos", _alreadyFetchedNomCatPuestos)

			
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
				Case "CatDeptos"
					_alreadyFetchedCatDeptos = True
					Me.CatDeptos = CType(entity, CatDeptosEntity)
				Case "NomCatPuestos"
					_alreadyFetchedNomCatPuestos = True
					Me.NomCatPuestos = CType(entity, NomCatPuestosEntity)



				Case Else

			End Select
		End Sub

		''' <summary>Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		''' <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		<EditorBrowsable(EditorBrowsableState.Never)> _
		Public Overrides Overloads Sub SetRelatedEntity(relatedEntity As IEntity, fieldName As String)
			Select Case fieldName
				Case "CatDeptos"
					SetupSyncCatDeptos(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "NomCatPuestos"
					SetupSyncNomCatPuestos(relatedEntity)
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
				Case "CatDeptos"
					DesetupSyncCatDeptos(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "NomCatPuestos"
					DesetupSyncNomCatPuestos(False, True)
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
			If Not _catDeptos Is Nothing Then
				toReturn.Add(_catDeptos)
			End If
			If Not _nomCatPuestos Is Nothing Then
				toReturn.Add(_nomCatPuestos)
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
		''' <param name="codigo">PK value for NomCatEmpleados which data should be fetched into this NomCatEmpleados Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32) As Boolean
			Return FetchUsingPK(codigo, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for NomCatEmpleados which data should be fetched into this NomCatEmpleados Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(codigo, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for NomCatEmpleados which data should be fetched into this NomCatEmpleados Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As NomCatEmpleadosFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As NomCatEmpleadosFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



	

		''' <summary>Retrieves the related entity of type 'CatDeptosEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'CatDeptosEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCatDeptos() As CatDeptosEntity
			Return GetSingleCatDeptos(False)
		End Function

		''' <summary>Retrieves the related entity of type 'CatDeptosEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'CatDeptosEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCatDeptos(forceFetch As Boolean) As CatDeptosEntity
			If ( Not _alreadyFetchedCatDeptos Or forceFetch Or _alwaysFetchCatDeptos) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New CatDeptosEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(NomCatEmpleadosEntity.Relations.CatDeptosEntityUsingIdDepartamento) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdDepartamento)
				End If
				If Not _catDeptosReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.CatDeptos = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), CatDeptosEntity)
					End If
					Me.CatDeptos = newEntity
					_alreadyFetchedCatDeptos = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _catDeptos
		End Function
	
		''' <summary>Retrieves the related entity of type 'NomCatPuestosEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'NomCatPuestosEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleNomCatPuestos() As NomCatPuestosEntity
			Return GetSingleNomCatPuestos(False)
		End Function

		''' <summary>Retrieves the related entity of type 'NomCatPuestosEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'NomCatPuestosEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleNomCatPuestos(forceFetch As Boolean) As NomCatPuestosEntity
			If ( Not _alreadyFetchedNomCatPuestos Or forceFetch Or _alwaysFetchNomCatPuestos) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New NomCatPuestosEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(NomCatEmpleadosEntity.Relations.NomCatPuestosEntityUsingIdPuesto) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdPuesto)
				End If
				If Not _nomCatPuestosReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.NomCatPuestos = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), NomCatPuestosEntity)
					End If
					Me.NomCatPuestos = newEntity
					_alreadyFetchedNomCatPuestos = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _nomCatPuestos
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(NomCatEmpleadosFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, NomCatEmpleadosFieldIndex)





















					Case NomCatEmpleadosFieldIndex.IdDepartamento
						DesetupSyncCatDeptos(True, False)
						_alreadyFetchedCatDeptos = False
					Case NomCatEmpleadosFieldIndex.IdPuesto
						DesetupSyncNomCatPuestos(True, False)
						_alreadyFetchedNomCatPuestos = False

























					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()


		If Not _catDeptos Is Nothing Then
				_catDeptos.ActiveContext = MyBase.ActiveContext
			End If
		If Not _nomCatPuestos Is Nothing Then
				_nomCatPuestos.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As NomCatEmpleadosDAO = CType(CreateDAOInstance(), NomCatEmpleadosDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As NomCatEmpleadosDAO = CType(CreateDAOInstance(), NomCatEmpleadosDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As NomCatEmpleadosDAO = CType(CreateDAOInstance(), NomCatEmpleadosDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this NomCatEmpleadosEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.NomCatEmpleadosEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="codigo">PK value for NomCatEmpleados which data should be fetched into this NomCatEmpleados Object</param>
		''' <param name="validator">The validator Object for this NomCatEmpleadosEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(codigo As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
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


			_catDeptos = Nothing
			_catDeptosReturnsNewIfNotFound = True
			_alwaysFetchCatDeptos = False
			_alreadyFetchedCatDeptos = False
			_nomCatPuestos = Nothing
			_nomCatPuestosReturnsNewIfNotFound = True
			_alwaysFetchNomCatPuestos = False
			_alreadyFetchedNomCatPuestos = False

			
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

			_fieldsCustomProperties.Add("Nombres", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ApellidoPaterno", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ApellidoMaterno", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaNacimiento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Rfc", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Curp", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Sexo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Domicilio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Colonia", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CodigoPostal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdEstado", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdCiudad", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdPoblacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Telefono", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Celular", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EstadoCivil", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Conyuge", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Padre", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Madre", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Imss", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdDepartamento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdPuesto", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SalarioActual", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Sdi", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Fonacot", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Descanso", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Turno", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("AplicaImss", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("AplicaIsr", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Factor", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DiasAginaldo", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DiasAginaldoAdicional", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DiasVacaciones", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DiasVacacionesAdicional", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DiasPrimaVacacional", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaAlta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaIngreso", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaBaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Infonavit", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Tipocreditoinfonavit", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImporteDescuentoInfonavit", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FecheOtorgamientoCrédito", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("PensionAlimenticia", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("PorcDescuentoPensionAlimenticia", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("NoClinica", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("NombreClinica", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _catDeptos</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncCatDeptos(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _catDeptos, AddressOf OnCatDeptosPropertyChanged, "CatDeptos", NomCatEmpleadosEntity.Relations.CatDeptosEntityUsingIdDepartamento, True, signalRelatedEntity, "NomCatEmpleados", resetFKFields, New Integer() { CInt(NomCatEmpleadosFieldIndex.IdDepartamento) } )
			_catDeptos = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _catDeptos</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncCatDeptos(relatedEntity As IEntity)
			DesetupSyncCatDeptos(True, True)
			_catDeptos = CType(relatedEntity, CatDeptosEntity)
			MyBase.PerformSetupSyncRelatedEntity( _catDeptos, AddressOf OnCatDeptosPropertyChanged, "CatDeptos", NomCatEmpleadosEntity.Relations.CatDeptosEntityUsingIdDepartamento, True, _alreadyFetchedCatDeptos, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnCatDeptosPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _nomCatPuestos</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncNomCatPuestos(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _nomCatPuestos, AddressOf OnNomCatPuestosPropertyChanged, "NomCatPuestos", NomCatEmpleadosEntity.Relations.NomCatPuestosEntityUsingIdPuesto, True, signalRelatedEntity, "NomCatEmpleados", resetFKFields, New Integer() { CInt(NomCatEmpleadosFieldIndex.IdPuesto) } )
			_nomCatPuestos = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _nomCatPuestos</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncNomCatPuestos(relatedEntity As IEntity)
			DesetupSyncNomCatPuestos(True, True)
			_nomCatPuestos = CType(relatedEntity, NomCatPuestosEntity)
			MyBase.PerformSetupSyncRelatedEntity( _nomCatPuestos, AddressOf OnNomCatPuestosPropertyChanged, "NomCatPuestos", NomCatEmpleadosEntity.Relations.NomCatPuestosEntityUsingIdPuesto, True, _alreadyFetchedNomCatPuestos, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnNomCatPuestosPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="codigo">PK value for NomCatEmpleados which data should be fetched into this NomCatEmpleados Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(codigo As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(NomCatEmpleadosFieldIndex.Codigo)).ForcedCurrentValueWrite(codigo)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateNomCatEmpleadosDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New NomCatEmpleadosEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As NomCatEmpleadosRelations
			Get	
				Return New NomCatEmpleadosRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CatDeptos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCatDeptos() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CatDeptosCollection(), _
					NomCatEmpleadosEntity.Relations.CatDeptosEntityUsingIdDepartamento, _
					CType(Integralab.ORM.EntityType.NomCatEmpleadosEntity, Integer), CType(Integralab.ORM.EntityType.CatDeptosEntity, Integer), 0, Nothing, Nothing, Nothing, "CatDeptos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'NomCatPuestos' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathNomCatPuestos() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.NomCatPuestosCollection(), _
					NomCatEmpleadosEntity.Relations.NomCatPuestosEntityUsingIdPuesto, _
					CType(Integralab.ORM.EntityType.NomCatEmpleadosEntity, Integer), CType(Integralab.ORM.EntityType.NomCatPuestosEntity, Integer), 0, Nothing, Nothing, Nothing, "NomCatPuestos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "NomCatEmpleadosEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return NomCatEmpleadosEntity.CustomProperties
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
				Return NomCatEmpleadosEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The Codigo property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."Codigo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [Codigo]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.Codigo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.Codigo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Nombres property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."Nombres"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 60<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Nombres]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.Nombres, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.Nombres, Integer), value)
			End Set
		End Property
	
		''' <summary>The ApellidoPaterno property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."ApellidoPaterno"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 30<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ApellidoPaterno]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.ApellidoPaterno, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.ApellidoPaterno, Integer), value)
			End Set
		End Property
	
		''' <summary>The ApellidoMaterno property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."ApellidoMaterno"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 30<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ApellidoMaterno]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.ApellidoMaterno, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.ApellidoMaterno, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaNacimiento property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."FechaNacimiento"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaNacimiento]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.FechaNacimiento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.FechaNacimiento, Integer), value)
			End Set
		End Property
	
		''' <summary>The Rfc property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."RFC"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 15<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Rfc]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.Rfc, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.Rfc, Integer), value)
			End Set
		End Property
	
		''' <summary>The Curp property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."CURP"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Curp]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.Curp, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.Curp, Integer), value)
			End Set
		End Property
	
		''' <summary>The Sexo property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."Sexo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Sexo]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.Sexo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.Sexo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Domicilio property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."Domicilio"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 60<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Domicilio]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.Domicilio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.Domicilio, Integer), value)
			End Set
		End Property
	
		''' <summary>The Colonia property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."Colonia"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 60<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Colonia]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.Colonia, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.Colonia, Integer), value)
			End Set
		End Property
	
		''' <summary>The CodigoPostal property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."CodigoPostal"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CodigoPostal]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.CodigoPostal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.CodigoPostal, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdEstado property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."IdEstado"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdEstado]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.IdEstado, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.IdEstado, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdCiudad property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."IdCiudad"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdCiudad]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.IdCiudad, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.IdCiudad, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdPoblacion property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."IdPoblacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdPoblacion]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.IdPoblacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.IdPoblacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The Telefono property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."Telefono"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 30<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Telefono]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.Telefono, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.Telefono, Integer), value)
			End Set
		End Property
	
		''' <summary>The Celular property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."Celular"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 30<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Celular]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.Celular, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.Celular, Integer), value)
			End Set
		End Property
	
		''' <summary>The EstadoCivil property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."EstadoCivil"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 15<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [EstadoCivil]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.EstadoCivil, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.EstadoCivil, Integer), value)
			End Set
		End Property
	
		''' <summary>The Conyuge property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."Conyuge"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 120<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Conyuge]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.Conyuge, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.Conyuge, Integer), value)
			End Set
		End Property
	
		''' <summary>The Padre property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."Padre"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 120<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Padre]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.Padre, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.Padre, Integer), value)
			End Set
		End Property
	
		''' <summary>The Madre property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."Madre"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 120<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Madre]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.Madre, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.Madre, Integer), value)
			End Set
		End Property
	
		''' <summary>The Imss property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."IMSS"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Imss]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.Imss, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.Imss, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdDepartamento property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."IdDepartamento"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdDepartamento]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.IdDepartamento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.IdDepartamento, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdPuesto property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."IdPuesto"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdPuesto]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.IdPuesto, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.IdPuesto, Integer), value)
			End Set
		End Property
	
		''' <summary>The SalarioActual property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."SalarioActual"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SalarioActual]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.SalarioActual, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.SalarioActual, Integer), value)
			End Set
		End Property
	
		''' <summary>The Sdi property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."SDI"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Sdi]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.Sdi, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.Sdi, Integer), value)
			End Set
		End Property
	
		''' <summary>The Fonacot property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."FONACOT"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 20<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Fonacot]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.Fonacot, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.Fonacot, Integer), value)
			End Set
		End Property
	
		''' <summary>The Descanso property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."Descanso"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 10<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Descanso]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.Descanso, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.Descanso, Integer), value)
			End Set
		End Property
	
		''' <summary>The Turno property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."Turno"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Turno]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.Turno, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.Turno, Integer), value)
			End Set
		End Property
	
		''' <summary>The AplicaImss property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."AplicaIMSS"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [AplicaImss]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.AplicaImss, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.AplicaImss, Integer), value)
			End Set
		End Property
	
		''' <summary>The AplicaIsr property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."AplicaISR"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [AplicaIsr]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.AplicaIsr, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.AplicaIsr, Integer), value)
			End Set
		End Property
	
		''' <summary>The Factor property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."Factor"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Factor]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.Factor, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.Factor, Integer), value)
			End Set
		End Property
	
		''' <summary>The DiasAginaldo property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."DiasAginaldo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DiasAginaldo]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.DiasAginaldo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.DiasAginaldo, Integer), value)
			End Set
		End Property
	
		''' <summary>The DiasAginaldoAdicional property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."DiasAginaldoAdicional"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DiasAginaldoAdicional]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.DiasAginaldoAdicional, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.DiasAginaldoAdicional, Integer), value)
			End Set
		End Property
	
		''' <summary>The DiasVacaciones property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."DiasVacaciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DiasVacaciones]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.DiasVacaciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.DiasVacaciones, Integer), value)
			End Set
		End Property
	
		''' <summary>The DiasVacacionesAdicional property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."DiasVacacionesAdicional"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DiasVacacionesAdicional]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.DiasVacacionesAdicional, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.DiasVacacionesAdicional, Integer), value)
			End Set
		End Property
	
		''' <summary>The DiasPrimaVacacional property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."DiasPrimaVacacional"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DiasPrimaVacacional]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.DiasPrimaVacacional, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.DiasPrimaVacacional, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaAlta property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."FechaAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaAlta]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.FechaAlta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.FechaAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaIngreso property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."FechaIngreso"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaIngreso]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.FechaIngreso, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.FechaIngreso, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaBaja property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."FechaBaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaBaja]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.FechaBaja, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.FechaBaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The Infonavit property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."INFONAVIT"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 30<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Infonavit]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.Infonavit, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.Infonavit, Integer), value)
			End Set
		End Property
	
		''' <summary>The Tipocreditoinfonavit property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."TIPOCREDITOINFONAVIT"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Tipocreditoinfonavit]() As Nullable(Of System.Int16)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.Tipocreditoinfonavit, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int16))
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.Tipocreditoinfonavit, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImporteDescuentoInfonavit property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."ImporteDescuentoINFONAVIT"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 9, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [ImporteDescuentoInfonavit]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.ImporteDescuentoInfonavit, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.ImporteDescuentoInfonavit, Integer), value)
			End Set
		End Property
	
		''' <summary>The FecheOtorgamientoCrédito property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."FecheOtorgamientoCrédito"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FecheOtorgamientoCrédito]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.FecheOtorgamientoCrédito, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.FecheOtorgamientoCrédito, Integer), value)
			End Set
		End Property
	
		''' <summary>The PensionAlimenticia property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."PensionAlimenticia"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [PensionAlimenticia]() As Nullable(Of System.Boolean)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.PensionAlimenticia, Integer))

				Return CType(valueToReturn, Nullable(Of System.Boolean))
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.PensionAlimenticia, Integer), value)
			End Set
		End Property
	
		''' <summary>The PorcDescuentoPensionAlimenticia property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."PorcDescuentoPensionAlimenticia"<br/>
		''' Table field type characteristics (type, precision, scale, length): Decimal, 4, 2, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [PorcDescuentoPensionAlimenticia]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.PorcDescuentoPensionAlimenticia, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.PorcDescuentoPensionAlimenticia, Integer), value)
			End Set
		End Property
	
		''' <summary>The NoClinica property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."NoClinica"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [NoClinica]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.NoClinica, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.NoClinica, Integer), value)
			End Set
		End Property
	
		''' <summary>The NombreClinica property of the Entity NomCatEmpleados<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "NomCatEmpleados"."NombreClinica"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [NombreClinica]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(NomCatEmpleadosFieldIndex.NombreClinica, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(NomCatEmpleadosFieldIndex.NombreClinica, Integer), value)
			End Set
		End Property
	
	
	
	
		''' <summary>Gets / sets related entity of type 'CatDeptosEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCatDeptos()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [CatDeptos]() As CatDeptosEntity
			Get
				Return GetSingleCatDeptos(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncCatDeptos(value)
				Else
					If value Is Nothing Then
						If Not _catDeptos Is Nothing Then
							_catDeptos.UnsetRelatedEntity(Me, "NomCatEmpleados")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "NomCatEmpleados")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for CatDeptos. When set to true, CatDeptos is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CatDeptos is accessed. You can always execute
		''' a forced fetch by calling GetSingleCatDeptos(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCatDeptos As Boolean
			Get
				Return _alwaysFetchCatDeptos
			End Get
			Set
				_alwaysFetchCatDeptos = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property CatDeptos is not found
		''' in the database. When set to true, CatDeptos will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property CatDeptosReturnsNewIfNotFound As Boolean
			Get
				Return _catDeptosReturnsNewIfNotFound
			End Get
			Set
				_catDeptosReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'NomCatPuestosEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleNomCatPuestos()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [NomCatPuestos]() As NomCatPuestosEntity
			Get
				Return GetSingleNomCatPuestos(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncNomCatPuestos(value)
				Else
					If value Is Nothing Then
						If Not _nomCatPuestos Is Nothing Then
							_nomCatPuestos.UnsetRelatedEntity(Me, "NomCatEmpleados")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "NomCatEmpleados")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for NomCatPuestos. When set to true, NomCatPuestos is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time NomCatPuestos is accessed. You can always execute
		''' a forced fetch by calling GetSingleNomCatPuestos(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchNomCatPuestos As Boolean
			Get
				Return _alwaysFetchNomCatPuestos
			End Get
			Set
				_alwaysFetchNomCatPuestos = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property NomCatPuestos is not found
		''' in the database. When set to true, NomCatPuestos will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property NomCatPuestosReturnsNewIfNotFound As Boolean
			Get
				Return _nomCatPuestosReturnsNewIfNotFound
			End Get
			Set
				_nomCatPuestosReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.NomCatEmpleadosEntity)
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
