' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: jueves, 25 de enero de 2018 11:40:30
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
	''' <summary>Entity class which represents the entity 'AcumuladoCuentasContables'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class AcumuladoCuentasContablesEntity 
#Else
	<Serializable()> _
	Public Class AcumuladoCuentasContablesEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"


		Private _cuentaContable As CuentaContableEntity
		Private _alwaysFetchCuentaContable, _alreadyFetchedCuentaContable, _cuentaContableReturnsNewIfNotFound As Boolean
		Private _periodosCont As PeriodosContEntity
		Private _alwaysFetchPeriodosCont, _alreadyFetchedPeriodosCont, _periodosContReturnsNewIfNotFound As Boolean


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
		''' <param name="codigo">PK value for AcumuladoCuentasContables which data should be fetched into this AcumuladoCuentasContables Object</param>
		''' <param name="ejercicio">PK value for AcumuladoCuentasContables which data should be fetched into this AcumuladoCuentasContables Object</param>
		Public Sub New(codigo As System.Int32, ejercicio As System.Int16)

			InitClassFetch(codigo, ejercicio, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for AcumuladoCuentasContables which data should be fetched into this AcumuladoCuentasContables Object</param>
		''' <param name="ejercicio">PK value for AcumuladoCuentasContables which data should be fetched into this AcumuladoCuentasContables Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(codigo As System.Int32, ejercicio As System.Int16, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(codigo, ejercicio, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="codigo">PK value for AcumuladoCuentasContables which data should be fetched into this AcumuladoCuentasContables Object</param>
		''' <param name="ejercicio">PK value for AcumuladoCuentasContables which data should be fetched into this AcumuladoCuentasContables Object</param>
		''' <param name="validator">The custom validator Object for this AcumuladoCuentasContablesEntity</param>
		Public Sub New(codigo As System.Int32, ejercicio As System.Int16, validator As IValidator)

			InitClassFetch(codigo, ejercicio, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)


			_cuentaContable = CType(info.GetValue("_cuentaContable", GetType(CuentaContableEntity)), CuentaContableEntity)
			If Not _cuentaContable Is Nothing Then
				AddHandler _cuentaContable.AfterSave, AddressOf OnEntityAfterSave
			End If
			_cuentaContableReturnsNewIfNotFound = info.GetBoolean("_cuentaContableReturnsNewIfNotFound")
			_alwaysFetchCuentaContable = info.GetBoolean("_alwaysFetchCuentaContable")
			_alreadyFetchedCuentaContable = info.GetBoolean("_alreadyFetchedCuentaContable")
			_periodosCont = CType(info.GetValue("_periodosCont", GetType(PeriodosContEntity)), PeriodosContEntity)
			If Not _periodosCont Is Nothing Then
				AddHandler _periodosCont.AfterSave, AddressOf OnEntityAfterSave
			End If
			_periodosContReturnsNewIfNotFound = info.GetBoolean("_periodosContReturnsNewIfNotFound")
			_alwaysFetchPeriodosCont = info.GetBoolean("_alwaysFetchPeriodosCont")
			_alreadyFetchedPeriodosCont = info.GetBoolean("_alreadyFetchedPeriodosCont")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()


			_alreadyFetchedCuentaContable = Not(_cuentaContable Is Nothing)
			_alreadyFetchedPeriodosCont = Not(_periodosCont Is Nothing)

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


			info.AddValue("_cuentaContable", _cuentaContable)
			info.AddValue("_cuentaContableReturnsNewIfNotFound", _cuentaContableReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchCuentaContable", _alwaysFetchCuentaContable)
			info.AddValue("_alreadyFetchedCuentaContable", _alreadyFetchedCuentaContable)
			info.AddValue("_periodosCont", _periodosCont)
			info.AddValue("_periodosContReturnsNewIfNotFound", _periodosContReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchPeriodosCont", _alwaysFetchPeriodosCont)
			info.AddValue("_alreadyFetchedPeriodosCont", _alreadyFetchedPeriodosCont)

			
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
				Case "CuentaContable"
					_alreadyFetchedCuentaContable = True
					Me.CuentaContable = CType(entity, CuentaContableEntity)
				Case "PeriodosCont"
					_alreadyFetchedPeriodosCont = True
					Me.PeriodosCont = CType(entity, PeriodosContEntity)



				Case Else

			End Select
		End Sub

		''' <summary>Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		''' <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		<EditorBrowsable(EditorBrowsableState.Never)> _
		Public Overrides Overloads Sub SetRelatedEntity(relatedEntity As IEntity, fieldName As String)
			Select Case fieldName
				Case "CuentaContable"
					SetupSyncCuentaContable(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "PeriodosCont"
					SetupSyncPeriodosCont(relatedEntity)
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
				Case "CuentaContable"
					DesetupSyncCuentaContable(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "PeriodosCont"
					DesetupSyncPeriodosCont(False, True)
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
			If Not _cuentaContable Is Nothing Then
				toReturn.Add(_cuentaContable)
			End If
			If Not _periodosCont Is Nothing Then
				toReturn.Add(_periodosCont)
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
		''' <param name="codigo">PK value for AcumuladoCuentasContables which data should be fetched into this AcumuladoCuentasContables Object</param>
		''' <param name="ejercicio">PK value for AcumuladoCuentasContables which data should be fetched into this AcumuladoCuentasContables Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32, ejercicio As System.Int16) As Boolean
			Return FetchUsingPK(codigo, ejercicio, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for AcumuladoCuentasContables which data should be fetched into this AcumuladoCuentasContables Object</param>
		''' <param name="ejercicio">PK value for AcumuladoCuentasContables which data should be fetched into this AcumuladoCuentasContables Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32, ejercicio As System.Int16, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(codigo, ejercicio, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="codigo">PK value for AcumuladoCuentasContables which data should be fetched into this AcumuladoCuentasContables Object</param>
		''' <param name="ejercicio">PK value for AcumuladoCuentasContables which data should be fetched into this AcumuladoCuentasContables Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(codigo As System.Int32, ejercicio As System.Int16, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(codigo, ejercicio, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.Codigo, Me.Ejercicio, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As AcumuladoCuentasContablesFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As AcumuladoCuentasContablesFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
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
				If MyBase.CheckIfLazyLoadingShouldOccur(AcumuladoCuentasContablesEntity.Relations.CuentaContableEntityUsingCodigo) Then
					fetchResult = newEntity.FetchUsingPK(Me.Codigo)
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
	
		''' <summary>Retrieves the related entity of type 'PeriodosContEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'PeriodosContEntity' which is related to this entity.</returns>
		Public Overridable Function GetSinglePeriodosCont() As PeriodosContEntity
			Return GetSinglePeriodosCont(False)
		End Function

		''' <summary>Retrieves the related entity of type 'PeriodosContEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'PeriodosContEntity' which is related to this entity.</returns>
		Public Overridable Function GetSinglePeriodosCont(forceFetch As Boolean) As PeriodosContEntity
			If ( Not _alreadyFetchedPeriodosCont Or forceFetch Or _alwaysFetchPeriodosCont) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New PeriodosContEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(AcumuladoCuentasContablesEntity.Relations.PeriodosContEntityUsingEjercicio) Then
					fetchResult = newEntity.FetchUsingPK(Me.Ejercicio)
				End If
				If Not _periodosContReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.PeriodosCont = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), PeriodosContEntity)
					End If
					Me.PeriodosCont = newEntity
					_alreadyFetchedPeriodosCont = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _periodosCont
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(AcumuladoCuentasContablesFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, AcumuladoCuentasContablesFieldIndex)
					Case AcumuladoCuentasContablesFieldIndex.Codigo
						DesetupSyncCuentaContable(True, False)
						_alreadyFetchedCuentaContable = False
					Case AcumuladoCuentasContablesFieldIndex.Ejercicio
						DesetupSyncPeriodosCont(True, False)
						_alreadyFetchedPeriodosCont = False






































					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()


		If Not _cuentaContable Is Nothing Then
				_cuentaContable.ActiveContext = MyBase.ActiveContext
			End If
		If Not _periodosCont Is Nothing Then
				_periodosCont.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As AcumuladoCuentasContablesDAO = CType(CreateDAOInstance(), AcumuladoCuentasContablesDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As AcumuladoCuentasContablesDAO = CType(CreateDAOInstance(), AcumuladoCuentasContablesDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As AcumuladoCuentasContablesDAO = CType(CreateDAOInstance(), AcumuladoCuentasContablesDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this AcumuladoCuentasContablesEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.AcumuladoCuentasContablesEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="codigo">PK value for AcumuladoCuentasContables which data should be fetched into this AcumuladoCuentasContables Object</param>
		''' <param name="ejercicio">PK value for AcumuladoCuentasContables which data should be fetched into this AcumuladoCuentasContables Object</param>
		''' <param name="validator">The validator Object for this AcumuladoCuentasContablesEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(codigo As System.Int32, ejercicio As System.Int16, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(codigo, ejercicio, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()


			_cuentaContable = Nothing
			_cuentaContableReturnsNewIfNotFound = True
			_alwaysFetchCuentaContable = False
			_alreadyFetchedCuentaContable = False
			_periodosCont = Nothing
			_periodosContReturnsNewIfNotFound = True
			_alwaysFetchPeriodosCont = False
			_alreadyFetchedPeriodosCont = False

			
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

			_fieldsCustomProperties.Add("Ejercicio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SaldoIniEjer", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Cargos01", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Cargos02", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Cargos03", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Cargos04", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Cargos05", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Cargos06", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Cargos07", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Cargos08", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Cargos09", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Cargos10", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Cargos11", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Cargos12", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Abonos01", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Abonos02", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Abonos03", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Abonos04", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Abonos05", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Abonos06", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Abonos07", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Abonos08", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Abonos09", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Abonos10", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Abonos11", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Abonos12", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Presup01", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Presup02", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Presup03", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Presup04", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Presup05", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Presup06", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Presup07", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Presup08", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Presup09", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Presup10", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Presup11", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Presup12", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SaldoFinEjer", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _cuentaContable</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncCuentaContable(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _cuentaContable, AddressOf OnCuentaContablePropertyChanged, "CuentaContable", AcumuladoCuentasContablesEntity.Relations.CuentaContableEntityUsingCodigo, True, signalRelatedEntity, "AcumuladoCuentasContables", resetFKFields, New Integer() { CInt(AcumuladoCuentasContablesFieldIndex.Codigo) } )
			_cuentaContable = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _cuentaContable</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncCuentaContable(relatedEntity As IEntity)
			DesetupSyncCuentaContable(True, True)
			_cuentaContable = CType(relatedEntity, CuentaContableEntity)
			MyBase.PerformSetupSyncRelatedEntity( _cuentaContable, AddressOf OnCuentaContablePropertyChanged, "CuentaContable", AcumuladoCuentasContablesEntity.Relations.CuentaContableEntityUsingCodigo, True, _alreadyFetchedCuentaContable, New String() {  } )
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
		''' <summary>Removes the sync logic for member _periodosCont</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncPeriodosCont(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _periodosCont, AddressOf OnPeriodosContPropertyChanged, "PeriodosCont", AcumuladoCuentasContablesEntity.Relations.PeriodosContEntityUsingEjercicio, True, signalRelatedEntity, "AcumuladoCuentasContables", resetFKFields, New Integer() { CInt(AcumuladoCuentasContablesFieldIndex.Ejercicio) } )
			_periodosCont = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _periodosCont</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncPeriodosCont(relatedEntity As IEntity)
			DesetupSyncPeriodosCont(True, True)
			_periodosCont = CType(relatedEntity, PeriodosContEntity)
			MyBase.PerformSetupSyncRelatedEntity( _periodosCont, AddressOf OnPeriodosContPropertyChanged, "PeriodosCont", AcumuladoCuentasContablesEntity.Relations.PeriodosContEntityUsingEjercicio, True, _alreadyFetchedPeriodosCont, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnPeriodosContPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="codigo">PK value for AcumuladoCuentasContables which data should be fetched into this AcumuladoCuentasContables Object</param>
		''' <param name="ejercicio">PK value for AcumuladoCuentasContables which data should be fetched into this AcumuladoCuentasContables Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(codigo As System.Int32, ejercicio As System.Int16, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(AcumuladoCuentasContablesFieldIndex.Codigo)).ForcedCurrentValueWrite(codigo)
				MyBase.Fields(CInt(AcumuladoCuentasContablesFieldIndex.Ejercicio)).ForcedCurrentValueWrite(ejercicio)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateAcumuladoCuentasContablesDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New AcumuladoCuentasContablesEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As AcumuladoCuentasContablesRelations
			Get	
				Return New AcumuladoCuentasContablesRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CuentaContable' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCuentaContable() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CuentaContableCollection(), _
					AcumuladoCuentasContablesEntity.Relations.CuentaContableEntityUsingCodigo, _
					CType(Integralab.ORM.EntityType.AcumuladoCuentasContablesEntity, Integer), CType(Integralab.ORM.EntityType.CuentaContableEntity, Integer), 0, Nothing, Nothing, Nothing, "CuentaContable", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'PeriodosCont' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathPeriodosCont() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PeriodosContCollection(), _
					AcumuladoCuentasContablesEntity.Relations.PeriodosContEntityUsingEjercicio, _
					CType(Integralab.ORM.EntityType.AcumuladoCuentasContablesEntity, Integer), CType(Integralab.ORM.EntityType.PeriodosContEntity, Integer), 0, Nothing, Nothing, Nothing, "PeriodosCont", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "AcumuladoCuentasContablesEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return AcumuladoCuentasContablesEntity.CustomProperties
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
				Return AcumuladoCuentasContablesEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The Codigo property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."Codigo"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [Codigo]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Codigo, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Codigo, Integer), value)
			End Set
		End Property
	
		''' <summary>The Ejercicio property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."Ejercicio"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [Ejercicio]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Ejercicio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Ejercicio, Integer), value)
			End Set
		End Property
	
		''' <summary>The SaldoIniEjer property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."SaldoIniEjer"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SaldoIniEjer]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.SaldoIniEjer, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.SaldoIniEjer, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cargos01 property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."Cargos01"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Cargos01]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Cargos01, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Cargos01, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cargos02 property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."Cargos02"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Cargos02]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Cargos02, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Cargos02, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cargos03 property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."Cargos03"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Cargos03]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Cargos03, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Cargos03, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cargos04 property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."Cargos04"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Cargos04]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Cargos04, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Cargos04, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cargos05 property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."Cargos05"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Cargos05]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Cargos05, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Cargos05, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cargos06 property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."Cargos06"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Cargos06]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Cargos06, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Cargos06, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cargos07 property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."Cargos07"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Cargos07]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Cargos07, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Cargos07, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cargos08 property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."Cargos08"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Cargos08]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Cargos08, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Cargos08, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cargos09 property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."Cargos09"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Cargos09]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Cargos09, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Cargos09, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cargos10 property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."Cargos10"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Cargos10]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Cargos10, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Cargos10, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cargos11 property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."Cargos11"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Cargos11]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Cargos11, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Cargos11, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cargos12 property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."Cargos12"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Cargos12]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Cargos12, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Cargos12, Integer), value)
			End Set
		End Property
	
		''' <summary>The Abonos01 property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."Abonos01"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Abonos01]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Abonos01, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Abonos01, Integer), value)
			End Set
		End Property
	
		''' <summary>The Abonos02 property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."Abonos02"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Abonos02]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Abonos02, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Abonos02, Integer), value)
			End Set
		End Property
	
		''' <summary>The Abonos03 property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."Abonos03"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Abonos03]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Abonos03, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Abonos03, Integer), value)
			End Set
		End Property
	
		''' <summary>The Abonos04 property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."Abonos04"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Abonos04]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Abonos04, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Abonos04, Integer), value)
			End Set
		End Property
	
		''' <summary>The Abonos05 property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."Abonos05"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Abonos05]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Abonos05, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Abonos05, Integer), value)
			End Set
		End Property
	
		''' <summary>The Abonos06 property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."Abonos06"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Abonos06]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Abonos06, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Abonos06, Integer), value)
			End Set
		End Property
	
		''' <summary>The Abonos07 property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."Abonos07"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Abonos07]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Abonos07, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Abonos07, Integer), value)
			End Set
		End Property
	
		''' <summary>The Abonos08 property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."Abonos08"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Abonos08]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Abonos08, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Abonos08, Integer), value)
			End Set
		End Property
	
		''' <summary>The Abonos09 property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."Abonos09"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Abonos09]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Abonos09, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Abonos09, Integer), value)
			End Set
		End Property
	
		''' <summary>The Abonos10 property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."Abonos10"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Abonos10]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Abonos10, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Abonos10, Integer), value)
			End Set
		End Property
	
		''' <summary>The Abonos11 property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."Abonos11"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Abonos11]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Abonos11, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Abonos11, Integer), value)
			End Set
		End Property
	
		''' <summary>The Abonos12 property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."Abonos12"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Abonos12]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Abonos12, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Abonos12, Integer), value)
			End Set
		End Property
	
		''' <summary>The Presup01 property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."Presup01"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Presup01]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Presup01, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Presup01, Integer), value)
			End Set
		End Property
	
		''' <summary>The Presup02 property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."Presup02"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Presup02]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Presup02, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Presup02, Integer), value)
			End Set
		End Property
	
		''' <summary>The Presup03 property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."Presup03"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Presup03]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Presup03, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Presup03, Integer), value)
			End Set
		End Property
	
		''' <summary>The Presup04 property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."Presup04"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Presup04]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Presup04, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Presup04, Integer), value)
			End Set
		End Property
	
		''' <summary>The Presup05 property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."Presup05"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Presup05]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Presup05, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Presup05, Integer), value)
			End Set
		End Property
	
		''' <summary>The Presup06 property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."Presup06"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Presup06]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Presup06, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Presup06, Integer), value)
			End Set
		End Property
	
		''' <summary>The Presup07 property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."Presup07"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Presup07]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Presup07, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Presup07, Integer), value)
			End Set
		End Property
	
		''' <summary>The Presup08 property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."Presup08"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Presup08]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Presup08, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Presup08, Integer), value)
			End Set
		End Property
	
		''' <summary>The Presup09 property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."Presup09"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Presup09]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Presup09, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Presup09, Integer), value)
			End Set
		End Property
	
		''' <summary>The Presup10 property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."Presup10"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Presup10]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Presup10, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Presup10, Integer), value)
			End Set
		End Property
	
		''' <summary>The Presup11 property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."Presup11"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Presup11]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Presup11, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Presup11, Integer), value)
			End Set
		End Property
	
		''' <summary>The Presup12 property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."Presup12"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Presup12]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Presup12, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.Presup12, Integer), value)
			End Set
		End Property
	
		''' <summary>The SaldoFinEjer property of the Entity AcumuladoCuentasContables<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "AcumuladoCuentasContables"."SaldoFinEjer"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SaldoFinEjer]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(AcumuladoCuentasContablesFieldIndex.SaldoFinEjer, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(AcumuladoCuentasContablesFieldIndex.SaldoFinEjer, Integer), value)
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
							_cuentaContable.UnsetRelatedEntity(Me, "AcumuladoCuentasContables")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "AcumuladoCuentasContables")
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
	
		''' <summary>Gets / sets related entity of type 'PeriodosContEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSinglePeriodosCont()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [PeriodosCont]() As PeriodosContEntity
			Get
				Return GetSinglePeriodosCont(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncPeriodosCont(value)
				Else
					If value Is Nothing Then
						If Not _periodosCont Is Nothing Then
							_periodosCont.UnsetRelatedEntity(Me, "AcumuladoCuentasContables")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "AcumuladoCuentasContables")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for PeriodosCont. When set to true, PeriodosCont is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time PeriodosCont is accessed. You can always execute
		''' a forced fetch by calling GetSinglePeriodosCont(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchPeriodosCont As Boolean
			Get
				Return _alwaysFetchPeriodosCont
			End Get
			Set
				_alwaysFetchPeriodosCont = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property PeriodosCont is not found
		''' in the database. When set to true, PeriodosCont will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property PeriodosContReturnsNewIfNotFound As Boolean
			Get
				Return _periodosContReturnsNewIfNotFound
			End Get
			Set
				_periodosContReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.AcumuladoCuentasContablesEntity)
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
