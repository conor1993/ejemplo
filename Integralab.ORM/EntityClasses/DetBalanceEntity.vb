' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 15 de marzo de 2018 12:00:10
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
	''' <summary>Entity class which represents the entity 'DetBalance'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class DetBalanceEntity 
#Else
	<Serializable()> _
	Public Class DetBalanceEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"


		Private _cabBalance As CabBalanceEntity
		Private _alwaysFetchCabBalance, _alreadyFetchedCabBalance, _cabBalanceReturnsNewIfNotFound As Boolean
		Private _cuentaContable As CuentaContableEntity
		Private _alwaysFetchCuentaContable, _alreadyFetchedCuentaContable, _cuentaContableReturnsNewIfNotFound As Boolean


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
		''' <param name="cveBalance">PK value for DetBalance which data should be fetched into this DetBalance Object</param>
		''' <param name="cveCuentaContable">PK value for DetBalance which data should be fetched into this DetBalance Object</param>
		Public Sub New(cveBalance As System.String, cveCuentaContable As System.Int32)

			InitClassFetch(cveBalance, cveCuentaContable, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="cveBalance">PK value for DetBalance which data should be fetched into this DetBalance Object</param>
		''' <param name="cveCuentaContable">PK value for DetBalance which data should be fetched into this DetBalance Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(cveBalance As System.String, cveCuentaContable As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(cveBalance, cveCuentaContable, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="cveBalance">PK value for DetBalance which data should be fetched into this DetBalance Object</param>
		''' <param name="cveCuentaContable">PK value for DetBalance which data should be fetched into this DetBalance Object</param>
		''' <param name="validator">The custom validator Object for this DetBalanceEntity</param>
		Public Sub New(cveBalance As System.String, cveCuentaContable As System.Int32, validator As IValidator)

			InitClassFetch(cveBalance, cveCuentaContable, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)


			_cabBalance = CType(info.GetValue("_cabBalance", GetType(CabBalanceEntity)), CabBalanceEntity)
			If Not _cabBalance Is Nothing Then
				AddHandler _cabBalance.AfterSave, AddressOf OnEntityAfterSave
			End If
			_cabBalanceReturnsNewIfNotFound = info.GetBoolean("_cabBalanceReturnsNewIfNotFound")
			_alwaysFetchCabBalance = info.GetBoolean("_alwaysFetchCabBalance")
			_alreadyFetchedCabBalance = info.GetBoolean("_alreadyFetchedCabBalance")
			_cuentaContable = CType(info.GetValue("_cuentaContable", GetType(CuentaContableEntity)), CuentaContableEntity)
			If Not _cuentaContable Is Nothing Then
				AddHandler _cuentaContable.AfterSave, AddressOf OnEntityAfterSave
			End If
			_cuentaContableReturnsNewIfNotFound = info.GetBoolean("_cuentaContableReturnsNewIfNotFound")
			_alwaysFetchCuentaContable = info.GetBoolean("_alwaysFetchCuentaContable")
			_alreadyFetchedCuentaContable = info.GetBoolean("_alreadyFetchedCuentaContable")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()


			_alreadyFetchedCabBalance = Not(_cabBalance Is Nothing)
			_alreadyFetchedCuentaContable = Not(_cuentaContable Is Nothing)

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


			info.AddValue("_cabBalance", _cabBalance)
			info.AddValue("_cabBalanceReturnsNewIfNotFound", _cabBalanceReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchCabBalance", _alwaysFetchCabBalance)
			info.AddValue("_alreadyFetchedCabBalance", _alreadyFetchedCabBalance)
			info.AddValue("_cuentaContable", _cuentaContable)
			info.AddValue("_cuentaContableReturnsNewIfNotFound", _cuentaContableReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchCuentaContable", _alwaysFetchCuentaContable)
			info.AddValue("_alreadyFetchedCuentaContable", _alreadyFetchedCuentaContable)

			
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
				Case "CabBalance"
					_alreadyFetchedCabBalance = True
					Me.CabBalance = CType(entity, CabBalanceEntity)
				Case "CuentaContable"
					_alreadyFetchedCuentaContable = True
					Me.CuentaContable = CType(entity, CuentaContableEntity)



				Case Else

			End Select
		End Sub

		''' <summary>Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		''' <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		<EditorBrowsable(EditorBrowsableState.Never)> _
		Public Overrides Overloads Sub SetRelatedEntity(relatedEntity As IEntity, fieldName As String)
			Select Case fieldName
				Case "CabBalance"
					SetupSyncCabBalance(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CuentaContable"
					SetupSyncCuentaContable(relatedEntity)
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
				Case "CabBalance"
					DesetupSyncCabBalance(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CuentaContable"
					DesetupSyncCuentaContable(False, True)
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
			If Not _cabBalance Is Nothing Then
				toReturn.Add(_cabBalance)
			End If
			If Not _cuentaContable Is Nothing Then
				toReturn.Add(_cuentaContable)
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
		''' <param name="cveBalance">PK value for DetBalance which data should be fetched into this DetBalance Object</param>
		''' <param name="cveCuentaContable">PK value for DetBalance which data should be fetched into this DetBalance Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(cveBalance As System.String, cveCuentaContable As System.Int32) As Boolean
			Return FetchUsingPK(cveBalance, cveCuentaContable, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="cveBalance">PK value for DetBalance which data should be fetched into this DetBalance Object</param>
		''' <param name="cveCuentaContable">PK value for DetBalance which data should be fetched into this DetBalance Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(cveBalance As System.String, cveCuentaContable As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(cveBalance, cveCuentaContable, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="cveBalance">PK value for DetBalance which data should be fetched into this DetBalance Object</param>
		''' <param name="cveCuentaContable">PK value for DetBalance which data should be fetched into this DetBalance Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(cveBalance As System.String, cveCuentaContable As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(cveBalance, cveCuentaContable, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.CveBalance, Me.CveCuentaContable, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As DetBalanceFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As DetBalanceFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



	

		''' <summary>Retrieves the related entity of type 'CabBalanceEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'CabBalanceEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCabBalance() As CabBalanceEntity
			Return GetSingleCabBalance(False)
		End Function

		''' <summary>Retrieves the related entity of type 'CabBalanceEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'CabBalanceEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCabBalance(forceFetch As Boolean) As CabBalanceEntity
			If ( Not _alreadyFetchedCabBalance Or forceFetch Or _alwaysFetchCabBalance) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New CabBalanceEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(DetBalanceEntity.Relations.CabBalanceEntityUsingCveBalance) Then
					fetchResult = newEntity.FetchUsingPK(Me.CveBalance)
				End If
				If Not _cabBalanceReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.CabBalance = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), CabBalanceEntity)
					End If
					Me.CabBalance = newEntity
					_alreadyFetchedCabBalance = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _cabBalance
		End Function
	
		''' <summary>Retrieves the related entity of type 'CuentaContableEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'CuentaContableEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCuentaContable() As CuentaContableEntity
			Return GetSingleCuentaContable(False)
		End Function

		''' <summary>Retrieves the related entity of type 'CuentaContableEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'CuentaContableEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCuentaContable(forceFetch As Boolean) As CuentaContableEntity
			If ( Not _alreadyFetchedCuentaContable Or forceFetch Or _alwaysFetchCuentaContable) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New CuentaContableEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(DetBalanceEntity.Relations.CuentaContableEntityUsingCveCuentaContable) Then
					fetchResult = newEntity.FetchUsingPK(Me.CveCuentaContable)
				End If
				If Not _cuentaContableReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.CuentaContable = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), CuentaContableEntity)
					End If
					Me.CuentaContable = newEntity
					_alreadyFetchedCuentaContable = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _cuentaContable
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(DetBalanceFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, DetBalanceFieldIndex)
					Case DetBalanceFieldIndex.CveBalance
						DesetupSyncCabBalance(True, False)
						_alreadyFetchedCabBalance = False
					Case DetBalanceFieldIndex.CveCuentaContable
						DesetupSyncCuentaContable(True, False)
						_alreadyFetchedCuentaContable = False







					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()


		If Not _cabBalance Is Nothing Then
				_cabBalance.ActiveContext = MyBase.ActiveContext
			End If
		If Not _cuentaContable Is Nothing Then
				_cuentaContable.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As DetBalanceDAO = CType(CreateDAOInstance(), DetBalanceDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As DetBalanceDAO = CType(CreateDAOInstance(), DetBalanceDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As DetBalanceDAO = CType(CreateDAOInstance(), DetBalanceDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this DetBalanceEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.DetBalanceEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="cveBalance">PK value for DetBalance which data should be fetched into this DetBalance Object</param>
		''' <param name="cveCuentaContable">PK value for DetBalance which data should be fetched into this DetBalance Object</param>
		''' <param name="validator">The validator Object for this DetBalanceEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(cveBalance As System.String, cveCuentaContable As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(cveBalance, cveCuentaContable, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()


			_cabBalance = Nothing
			_cabBalanceReturnsNewIfNotFound = True
			_alwaysFetchCabBalance = False
			_alreadyFetchedCabBalance = False
			_cuentaContable = Nothing
			_cuentaContableReturnsNewIfNotFound = True
			_alwaysFetchCuentaContable = False
			_alreadyFetchedCuentaContable = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CveBalance", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CveCuentaContable", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CveRenglon", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("StaSumaResta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CveCta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CveSubCta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CveSsubCta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CveSssubCta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Saldo", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _cabBalance</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncCabBalance(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _cabBalance, AddressOf OnCabBalancePropertyChanged, "CabBalance", DetBalanceEntity.Relations.CabBalanceEntityUsingCveBalance, True, signalRelatedEntity, "DetBalance", resetFKFields, New Integer() { CInt(DetBalanceFieldIndex.CveBalance) } )
			_cabBalance = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _cabBalance</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncCabBalance(relatedEntity As IEntity)
			DesetupSyncCabBalance(True, True)
			_cabBalance = CType(relatedEntity, CabBalanceEntity)
			MyBase.PerformSetupSyncRelatedEntity( _cabBalance, AddressOf OnCabBalancePropertyChanged, "CabBalance", DetBalanceEntity.Relations.CabBalanceEntityUsingCveBalance, True, _alreadyFetchedCabBalance, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnCabBalancePropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _cuentaContable</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncCuentaContable(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _cuentaContable, AddressOf OnCuentaContablePropertyChanged, "CuentaContable", DetBalanceEntity.Relations.CuentaContableEntityUsingCveCuentaContable, True, signalRelatedEntity, "DetBalance", resetFKFields, New Integer() { CInt(DetBalanceFieldIndex.CveCuentaContable) } )
			_cuentaContable = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _cuentaContable</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncCuentaContable(relatedEntity As IEntity)
			DesetupSyncCuentaContable(True, True)
			_cuentaContable = CType(relatedEntity, CuentaContableEntity)
			MyBase.PerformSetupSyncRelatedEntity( _cuentaContable, AddressOf OnCuentaContablePropertyChanged, "CuentaContable", DetBalanceEntity.Relations.CuentaContableEntityUsingCveCuentaContable, True, _alreadyFetchedCuentaContable, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnCuentaContablePropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="cveBalance">PK value for DetBalance which data should be fetched into this DetBalance Object</param>
		''' <param name="cveCuentaContable">PK value for DetBalance which data should be fetched into this DetBalance Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(cveBalance As System.String, cveCuentaContable As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(DetBalanceFieldIndex.CveBalance)).ForcedCurrentValueWrite(cveBalance)
				MyBase.Fields(CInt(DetBalanceFieldIndex.CveCuentaContable)).ForcedCurrentValueWrite(cveCuentaContable)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateDetBalanceDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New DetBalanceEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As DetBalanceRelations
			Get	
				Return New DetBalanceRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CabBalance' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCabBalance() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CabBalanceCollection(), _
					DetBalanceEntity.Relations.CabBalanceEntityUsingCveBalance, _
					CType(Integralab.ORM.EntityType.DetBalanceEntity, Integer), CType(Integralab.ORM.EntityType.CabBalanceEntity, Integer), 0, Nothing, Nothing, Nothing, "CabBalance", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CuentaContable' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaContable() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaContableCollection(), _
					DetBalanceEntity.Relations.CuentaContableEntityUsingCveCuentaContable, _
					CType(Integralab.ORM.EntityType.DetBalanceEntity, Integer), CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), 0, Nothing, Nothing, Nothing, "CuentaContable", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "DetBalanceEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return DetBalanceEntity.CustomProperties
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
				Return DetBalanceEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The CveBalance property of the Entity DetBalance<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "DetBalance"."Cve_Balance"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 3<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [CveBalance]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(DetBalanceFieldIndex.CveBalance, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(DetBalanceFieldIndex.CveBalance, Integer), value)
			End Set
		End Property
	
		''' <summary>The CveCuentaContable property of the Entity DetBalance<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "DetBalance"."Cve_CuentaContable"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [CveCuentaContable]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(DetBalanceFieldIndex.CveCuentaContable, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(DetBalanceFieldIndex.CveCuentaContable, Integer), value)
			End Set
		End Property
	
		''' <summary>The CveRenglon property of the Entity DetBalance<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "DetBalance"."Cve_Renglon"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CveRenglon]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(DetBalanceFieldIndex.CveRenglon, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(DetBalanceFieldIndex.CveRenglon, Integer), value)
			End Set
		End Property
	
		''' <summary>The StaSumaResta property of the Entity DetBalance<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "DetBalance"."Sta_SumaResta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 1<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [StaSumaResta]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(DetBalanceFieldIndex.StaSumaResta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(DetBalanceFieldIndex.StaSumaResta, Integer), value)
			End Set
		End Property
	
		''' <summary>The CveCta property of the Entity DetBalance<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "DetBalance"."Cve_Cta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 4<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CveCta]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(DetBalanceFieldIndex.CveCta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(DetBalanceFieldIndex.CveCta, Integer), value)
			End Set
		End Property
	
		''' <summary>The CveSubCta property of the Entity DetBalance<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "DetBalance"."Cve_SubCta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 4<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CveSubCta]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(DetBalanceFieldIndex.CveSubCta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(DetBalanceFieldIndex.CveSubCta, Integer), value)
			End Set
		End Property
	
		''' <summary>The CveSsubCta property of the Entity DetBalance<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "DetBalance"."Cve_SSubCta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 4<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CveSsubCta]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(DetBalanceFieldIndex.CveSsubCta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(DetBalanceFieldIndex.CveSsubCta, Integer), value)
			End Set
		End Property
	
		''' <summary>The CveSssubCta property of the Entity DetBalance<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "DetBalance"."Cve_SSSubCta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Char, 0, 0, 4<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CveSssubCta]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(DetBalanceFieldIndex.CveSssubCta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(DetBalanceFieldIndex.CveSssubCta, Integer), value)
			End Set
		End Property
	
		''' <summary>The Saldo property of the Entity DetBalance<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "DetBalance"."Saldo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Saldo]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(DetBalanceFieldIndex.Saldo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(DetBalanceFieldIndex.Saldo, Integer), value)
			End Set
		End Property
	
	
	
	
		''' <summary>Gets / sets related entity of type 'CabBalanceEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCabBalance()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [CabBalance]() As CabBalanceEntity
			Get
				Return GetSingleCabBalance(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncCabBalance(value)
				Else
					If value Is Nothing Then
						If Not _cabBalance Is Nothing Then
							_cabBalance.UnsetRelatedEntity(Me, "DetBalance")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "DetBalance")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for CabBalance. When set to true, CabBalance is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CabBalance is accessed. You can always execute
		''' a forced fetch by calling GetSingleCabBalance(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCabBalance As Boolean
			Get
				Return _alwaysFetchCabBalance
			End Get
			Set
				_alwaysFetchCabBalance = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property CabBalance is not found
		''' in the database. When set to true, CabBalance will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property CabBalanceReturnsNewIfNotFound As Boolean
			Get
				Return _cabBalanceReturnsNewIfNotFound
			End Get
			Set
				_cabBalanceReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'CuentaContableEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCuentaContable()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [CuentaContable]() As CuentaContableEntity
			Get
				Return GetSingleCuentaContable(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncCuentaContable(value)
				Else
					If value Is Nothing Then
						If Not _cuentaContable Is Nothing Then
							_cuentaContable.UnsetRelatedEntity(Me, "DetBalance")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "DetBalance")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for CuentaContable. When set to true, CuentaContable is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CuentaContable is accessed. You can always execute
		''' a forced fetch by calling GetSingleCuentaContable(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCuentaContable As Boolean
			Get
				Return _alwaysFetchCuentaContable
			End Get
			Set
				_alwaysFetchCuentaContable = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property CuentaContable is not found
		''' in the database. When set to true, CuentaContable will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property CuentaContableReturnsNewIfNotFound As Boolean
			Get
				Return _cuentaContableReturnsNewIfNotFound
			End Get
			Set
				_cuentaContableReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.DetBalanceEntity)
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
