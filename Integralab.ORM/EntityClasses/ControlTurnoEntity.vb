' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 29 de enero de 2018 16:36:36
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
	''' <summary>Entity class which represents the entity 'ControlTurno'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class ControlTurnoEntity 
#Else
	<Serializable()> _
	Public Class ControlTurnoEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _ingresoCaja As Integralab.ORM.CollectionClasses.IngresoCajaCollection
		Private _alwaysFetchIngresoCaja, _alreadyFetchedIngresoCaja As Boolean
		Private _notasVenta As Integralab.ORM.CollectionClasses.NotaVentaCollection
		Private _alwaysFetchNotasVenta, _alreadyFetchedNotasVenta As Boolean
		Private _notasVentaCanceladas As Integralab.ORM.CollectionClasses.NotaVentaCollection
		Private _alwaysFetchNotasVentaCanceladas, _alreadyFetchedNotasVentaCanceladas As Boolean
		Private _retirosCaja As Integralab.ORM.CollectionClasses.RetiroCajaCollection
		Private _alwaysFetchRetirosCaja, _alreadyFetchedRetirosCaja As Boolean
		Private _sucursalCollectionViaNotaVenta_ As Integralab.ORM.CollectionClasses.SucursalCollection
		Private _alwaysFetchSucursalCollectionViaNotaVenta_, _alreadyFetchedSucursalCollectionViaNotaVenta_ As Boolean
		Private _sucursal As SucursalEntity
		Private _alwaysFetchSucursal, _alreadyFetchedSucursal, _sucursalReturnsNewIfNotFound As Boolean


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
		''' <param name="id">PK value for ControlTurno which data should be fetched into this ControlTurno Object</param>
		Public Sub New(id As System.Int32)

			InitClassFetch(id, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="id">PK value for ControlTurno which data should be fetched into this ControlTurno Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(id As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(id, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="id">PK value for ControlTurno which data should be fetched into this ControlTurno Object</param>
		''' <param name="validator">The custom validator Object for this ControlTurnoEntity</param>
		Public Sub New(id As System.Int32, validator As IValidator)

			InitClassFetch(id, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_ingresoCaja = CType(info.GetValue("_ingresoCaja", GetType(Integralab.ORM.CollectionClasses.IngresoCajaCollection)), Integralab.ORM.CollectionClasses.IngresoCajaCollection)
			_alwaysFetchIngresoCaja = info.GetBoolean("_alwaysFetchIngresoCaja")
			_alreadyFetchedIngresoCaja = info.GetBoolean("_alreadyFetchedIngresoCaja")
			_notasVenta = CType(info.GetValue("_notasVenta", GetType(Integralab.ORM.CollectionClasses.NotaVentaCollection)), Integralab.ORM.CollectionClasses.NotaVentaCollection)
			_alwaysFetchNotasVenta = info.GetBoolean("_alwaysFetchNotasVenta")
			_alreadyFetchedNotasVenta = info.GetBoolean("_alreadyFetchedNotasVenta")
			_notasVentaCanceladas = CType(info.GetValue("_notasVentaCanceladas", GetType(Integralab.ORM.CollectionClasses.NotaVentaCollection)), Integralab.ORM.CollectionClasses.NotaVentaCollection)
			_alwaysFetchNotasVentaCanceladas = info.GetBoolean("_alwaysFetchNotasVentaCanceladas")
			_alreadyFetchedNotasVentaCanceladas = info.GetBoolean("_alreadyFetchedNotasVentaCanceladas")
			_retirosCaja = CType(info.GetValue("_retirosCaja", GetType(Integralab.ORM.CollectionClasses.RetiroCajaCollection)), Integralab.ORM.CollectionClasses.RetiroCajaCollection)
			_alwaysFetchRetirosCaja = info.GetBoolean("_alwaysFetchRetirosCaja")
			_alreadyFetchedRetirosCaja = info.GetBoolean("_alreadyFetchedRetirosCaja")
			_sucursalCollectionViaNotaVenta_ = CType(info.GetValue("_sucursalCollectionViaNotaVenta_", GetType(Integralab.ORM.CollectionClasses.SucursalCollection)), Integralab.ORM.CollectionClasses.SucursalCollection)
			_alwaysFetchSucursalCollectionViaNotaVenta_ = info.GetBoolean("_alwaysFetchSucursalCollectionViaNotaVenta_")
			_alreadyFetchedSucursalCollectionViaNotaVenta_ = info.GetBoolean("_alreadyFetchedSucursalCollectionViaNotaVenta_")
			_sucursal = CType(info.GetValue("_sucursal", GetType(SucursalEntity)), SucursalEntity)
			If Not _sucursal Is Nothing Then
				AddHandler _sucursal.AfterSave, AddressOf OnEntityAfterSave
			End If
			_sucursalReturnsNewIfNotFound = info.GetBoolean("_sucursalReturnsNewIfNotFound")
			_alwaysFetchSucursal = info.GetBoolean("_alwaysFetchSucursal")
			_alreadyFetchedSucursal = info.GetBoolean("_alreadyFetchedSucursal")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedIngresoCaja = (_ingresoCaja.Count > 0)
			_alreadyFetchedNotasVenta = (_notasVenta.Count > 0)
			_alreadyFetchedNotasVentaCanceladas = (_notasVentaCanceladas.Count > 0)
			_alreadyFetchedRetirosCaja = (_retirosCaja.Count > 0)
			_alreadyFetchedSucursalCollectionViaNotaVenta_ = (_sucursalCollectionViaNotaVenta_.Count > 0)
			_alreadyFetchedSucursal = Not(_sucursal Is Nothing)

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
			info.AddValue("_ingresoCaja", _ingresoCaja)
			info.AddValue("_alwaysFetchIngresoCaja", _alwaysFetchIngresoCaja)
			info.AddValue("_alreadyFetchedIngresoCaja", _alreadyFetchedIngresoCaja)
			info.AddValue("_notasVenta", _notasVenta)
			info.AddValue("_alwaysFetchNotasVenta", _alwaysFetchNotasVenta)
			info.AddValue("_alreadyFetchedNotasVenta", _alreadyFetchedNotasVenta)
			info.AddValue("_notasVentaCanceladas", _notasVentaCanceladas)
			info.AddValue("_alwaysFetchNotasVentaCanceladas", _alwaysFetchNotasVentaCanceladas)
			info.AddValue("_alreadyFetchedNotasVentaCanceladas", _alreadyFetchedNotasVentaCanceladas)
			info.AddValue("_retirosCaja", _retirosCaja)
			info.AddValue("_alwaysFetchRetirosCaja", _alwaysFetchRetirosCaja)
			info.AddValue("_alreadyFetchedRetirosCaja", _alreadyFetchedRetirosCaja)
			info.AddValue("_sucursalCollectionViaNotaVenta_", _sucursalCollectionViaNotaVenta_)
			info.AddValue("_alwaysFetchSucursalCollectionViaNotaVenta_", _alwaysFetchSucursalCollectionViaNotaVenta_)
			info.AddValue("_alreadyFetchedSucursalCollectionViaNotaVenta_", _alreadyFetchedSucursalCollectionViaNotaVenta_)
			info.AddValue("_sucursal", _sucursal)
			info.AddValue("_sucursalReturnsNewIfNotFound", _sucursalReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchSucursal", _alwaysFetchSucursal)
			info.AddValue("_alreadyFetchedSucursal", _alreadyFetchedSucursal)

			
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
				Case "Sucursal"
					_alreadyFetchedSucursal = True
					Me.Sucursal = CType(entity, SucursalEntity)
				Case "IngresoCaja"
					_alreadyFetchedIngresoCaja = True
					If Not entity Is Nothing Then
						Me.IngresoCaja.Add(CType(entity, IngresoCajaEntity))
					End If
				Case "NotasVenta"
					_alreadyFetchedNotasVenta = True
					If Not entity Is Nothing Then
						Me.NotasVenta.Add(CType(entity, NotaVentaEntity))
					End If
				Case "NotasVentaCanceladas"
					_alreadyFetchedNotasVentaCanceladas = True
					If Not entity Is Nothing Then
						Me.NotasVentaCanceladas.Add(CType(entity, NotaVentaEntity))
					End If
				Case "RetirosCaja"
					_alreadyFetchedRetirosCaja = True
					If Not entity Is Nothing Then
						Me.RetirosCaja.Add(CType(entity, RetiroCajaEntity))
					End If
				Case "SucursalCollectionViaNotaVenta_"
					_alreadyFetchedSucursalCollectionViaNotaVenta_ = True
					If Not entity Is Nothing Then
						Me.SucursalCollectionViaNotaVenta_.Add(CType(entity, SucursalEntity))
					End If

				Case Else

			End Select
		End Sub

		''' <summary>Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		''' <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		<EditorBrowsable(EditorBrowsableState.Never)> _
		Public Overrides Overloads Sub SetRelatedEntity(relatedEntity As IEntity, fieldName As String)
			Select Case fieldName
				Case "Sucursal"
					SetupSyncSucursal(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "IngresoCaja"
					_ingresoCaja.Add(CType(relatedEntity, IngresoCajaEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "NotasVenta"
					_notasVenta.Add(CType(relatedEntity, NotaVentaEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "NotasVentaCanceladas"
					_notasVentaCanceladas.Add(CType(relatedEntity, NotaVentaEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "RetirosCaja"
					_retirosCaja.Add(CType(relatedEntity, RetiroCajaEntity))
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
				Case "Sucursal"
					DesetupSyncSucursal(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "IngresoCaja"
					MyBase.PerformRelatedEntityRemoval(_ingresoCaja, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "NotasVenta"
					MyBase.PerformRelatedEntityRemoval(_notasVenta, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "NotasVentaCanceladas"
					MyBase.PerformRelatedEntityRemoval(_notasVentaCanceladas, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "RetirosCaja"
					MyBase.PerformRelatedEntityRemoval(_retirosCaja, relatedEntity, signalRelatedEntityManyToOne)
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
			If Not _sucursal Is Nothing Then
				toReturn.Add(_sucursal)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_ingresoCaja)
			toReturn.Add(_notasVenta)
			toReturn.Add(_notasVentaCanceladas)
			toReturn.Add(_retirosCaja)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="id">PK value for ControlTurno which data should be fetched into this ControlTurno Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(id As System.Int32) As Boolean
			Return FetchUsingPK(id, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="id">PK value for ControlTurno which data should be fetched into this ControlTurno Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(id As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(id, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="id">PK value for ControlTurno which data should be fetched into this ControlTurno Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(id As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(id, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.Id, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As ControlTurnoFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As ControlTurnoFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'IngresoCajaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'IngresoCajaEntity'</returns>
		Public Function GetMultiIngresoCaja(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.IngresoCajaCollection
			Return GetMultiIngresoCaja(forceFetch, _ingresoCaja.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'IngresoCajaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiIngresoCaja(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.IngresoCajaCollection
			Return GetMultiIngresoCaja(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'IngresoCajaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'IngresoCajaEntity'</returns>
		Public Function GetMultiIngresoCaja(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.IngresoCajaCollection
			Return GetMultiIngresoCaja(forceFetch, _ingresoCaja.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'IngresoCajaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiIngresoCaja(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.IngresoCajaCollection
			If ( Not _alreadyFetchedIngresoCaja Or forceFetch Or _alwaysFetchIngresoCaja) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _ingresoCaja.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_ingresoCaja)
					End If
				End If
				_ingresoCaja.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_ingresoCaja.EntityFactoryToUse = entityFactoryToUse
				End If
				_ingresoCaja.GetMultiManyToOne(Nothing, Me, Filter)
				_ingresoCaja.SuppressClearInGetMulti = False
				_alreadyFetchedIngresoCaja = True
			End If
			Return _ingresoCaja
		End Function

		''' <summary>Sets the collection parameters for the collection for 'IngresoCaja'. These settings will be taken into account
		''' when the property IngresoCaja is requested or GetMultiIngresoCaja is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersIngresoCaja(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_ingresoCaja.SortClauses=sortClauses
			_ingresoCaja.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'NotaVentaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'NotaVentaEntity'</returns>
		Public Function GetMultiNotasVenta(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.NotaVentaCollection
			Return GetMultiNotasVenta(forceFetch, _notasVenta.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'NotaVentaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiNotasVenta(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.NotaVentaCollection
			Return GetMultiNotasVenta(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'NotaVentaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'NotaVentaEntity'</returns>
		Public Function GetMultiNotasVenta(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.NotaVentaCollection
			Return GetMultiNotasVenta(forceFetch, _notasVenta.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'NotaVentaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiNotasVenta(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.NotaVentaCollection
			If ( Not _alreadyFetchedNotasVenta Or forceFetch Or _alwaysFetchNotasVenta) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _notasVenta.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_notasVenta)
					End If
				End If
				_notasVenta.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_notasVenta.EntityFactoryToUse = entityFactoryToUse
				End If
				_notasVenta.GetMultiManyToOne(Nothing, Me, Nothing, Filter)
				_notasVenta.SuppressClearInGetMulti = False
				_alreadyFetchedNotasVenta = True
			End If
			Return _notasVenta
		End Function

		''' <summary>Sets the collection parameters for the collection for 'NotasVenta'. These settings will be taken into account
		''' when the property NotasVenta is requested or GetMultiNotasVenta is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersNotasVenta(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_notasVenta.SortClauses=sortClauses
			_notasVenta.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'NotaVentaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'NotaVentaEntity'</returns>
		Public Function GetMultiNotasVentaCanceladas(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.NotaVentaCollection
			Return GetMultiNotasVentaCanceladas(forceFetch, _notasVentaCanceladas.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'NotaVentaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiNotasVentaCanceladas(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.NotaVentaCollection
			Return GetMultiNotasVentaCanceladas(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'NotaVentaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'NotaVentaEntity'</returns>
		Public Function GetMultiNotasVentaCanceladas(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.NotaVentaCollection
			Return GetMultiNotasVentaCanceladas(forceFetch, _notasVentaCanceladas.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'NotaVentaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiNotasVentaCanceladas(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.NotaVentaCollection
			If ( Not _alreadyFetchedNotasVentaCanceladas Or forceFetch Or _alwaysFetchNotasVentaCanceladas) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _notasVentaCanceladas.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_notasVentaCanceladas)
					End If
				End If
				_notasVentaCanceladas.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_notasVentaCanceladas.EntityFactoryToUse = entityFactoryToUse
				End If
				_notasVentaCanceladas.GetMultiManyToOne(Nothing, Nothing, Me, Filter)
				_notasVentaCanceladas.SuppressClearInGetMulti = False
				_alreadyFetchedNotasVentaCanceladas = True
			End If
			Return _notasVentaCanceladas
		End Function

		''' <summary>Sets the collection parameters for the collection for 'NotasVentaCanceladas'. These settings will be taken into account
		''' when the property NotasVentaCanceladas is requested or GetMultiNotasVentaCanceladas is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersNotasVentaCanceladas(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_notasVentaCanceladas.SortClauses=sortClauses
			_notasVentaCanceladas.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'RetiroCajaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'RetiroCajaEntity'</returns>
		Public Function GetMultiRetirosCaja(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.RetiroCajaCollection
			Return GetMultiRetirosCaja(forceFetch, _retirosCaja.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'RetiroCajaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiRetirosCaja(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.RetiroCajaCollection
			Return GetMultiRetirosCaja(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'RetiroCajaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'RetiroCajaEntity'</returns>
		Public Function GetMultiRetirosCaja(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.RetiroCajaCollection
			Return GetMultiRetirosCaja(forceFetch, _retirosCaja.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'RetiroCajaEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiRetirosCaja(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.RetiroCajaCollection
			If ( Not _alreadyFetchedRetirosCaja Or forceFetch Or _alwaysFetchRetirosCaja) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _retirosCaja.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_retirosCaja)
					End If
				End If
				_retirosCaja.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_retirosCaja.EntityFactoryToUse = entityFactoryToUse
				End If
				_retirosCaja.GetMultiManyToOne(Nothing, Me, Filter)
				_retirosCaja.SuppressClearInGetMulti = False
				_alreadyFetchedRetirosCaja = True
			End If
			Return _retirosCaja
		End Function

		''' <summary>Sets the collection parameters for the collection for 'RetirosCaja'. These settings will be taken into account
		''' when the property RetirosCaja is requested or GetMultiRetirosCaja is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersRetirosCaja(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_retirosCaja.SortClauses=sortClauses
			_retirosCaja.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'SucursalEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'SucursalEntity'</returns>
		Public Function GetMultiSucursalCollectionViaNotaVenta_(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.SucursalCollection
			Return GetMultiSucursalCollectionViaNotaVenta_(forceFetch, _sucursalCollectionViaNotaVenta_.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'SucursalEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiSucursalCollectionViaNotaVenta_(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.SucursalCollection
			If ( Not _alreadyFetchedSucursalCollectionViaNotaVenta_ Or forceFetch Or _alwaysFetchSucursalCollectionViaNotaVenta_) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _sucursalCollectionViaNotaVenta_.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_sucursalCollectionViaNotaVenta_)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(ControlTurnoEntity.Relations.NotaVentaEntityUsingIdControlTurnoCanc, "__ControlTurnoEntity__", "NotaVenta_", JoinHint.None)
				relations.Add(NotaVentaEntity.Relations.SucursalEntityUsingCodSucursal, "NotaVenta_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(ControlTurnoFieldIndex.Id), ComparisonOperator.Equal, Me.Id))
				_sucursalCollectionViaNotaVenta_.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_sucursalCollectionViaNotaVenta_.EntityFactoryToUse = entityFactoryToUse
				End If
				_sucursalCollectionViaNotaVenta_.GetMulti(Filter, relations)
				_sucursalCollectionViaNotaVenta_.SuppressClearInGetMulti = False
				_alreadyFetchedSucursalCollectionViaNotaVenta_ = True
			End If
			Return _sucursalCollectionViaNotaVenta_
		End Function

		''' <summary>Sets the collection parameters for the collection for 'SucursalCollectionViaNotaVenta_'. These settings will be taken into account
		''' when the property SucursalCollectionViaNotaVenta_ is requested or GetMultiSucursalCollectionViaNotaVenta_ is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersSucursalCollectionViaNotaVenta_(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_sucursalCollectionViaNotaVenta_.SortClauses=sortClauses
			_sucursalCollectionViaNotaVenta_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves the related entity of type 'SucursalEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'SucursalEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleSucursal() As SucursalEntity
			Return GetSingleSucursal(False)
		End Function

		''' <summary>Retrieves the related entity of type 'SucursalEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'SucursalEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleSucursal(forceFetch As Boolean) As SucursalEntity
			If ( Not _alreadyFetchedSucursal Or forceFetch Or _alwaysFetchSucursal) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New SucursalEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(ControlTurnoEntity.Relations.SucursalEntityUsingCodSucursal) Then
					fetchResult = newEntity.FetchUsingPK(Me.CodSucursal)
				End If
				If Not _sucursalReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Sucursal = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), SucursalEntity)
					End If
					Me.Sucursal = newEntity
					_alreadyFetchedSucursal = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _sucursal
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(ControlTurnoFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, ControlTurnoFieldIndex)

					Case ControlTurnoFieldIndex.CodSucursal
						DesetupSyncSucursal(True, False)
						_alreadyFetchedSucursal = False





					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_ingresoCaja.ActiveContext = MyBase.ActiveContext
			_notasVenta.ActiveContext = MyBase.ActiveContext
			_notasVentaCanceladas.ActiveContext = MyBase.ActiveContext
			_retirosCaja.ActiveContext = MyBase.ActiveContext
			_sucursalCollectionViaNotaVenta_.ActiveContext = MyBase.ActiveContext
		If Not _sucursal Is Nothing Then
				_sucursal.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As ControlTurnoDAO = CType(CreateDAOInstance(), ControlTurnoDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As ControlTurnoDAO = CType(CreateDAOInstance(), ControlTurnoDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As ControlTurnoDAO = CType(CreateDAOInstance(), ControlTurnoDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this ControlTurnoEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.ControlTurnoEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="id">PK value for ControlTurno which data should be fetched into this ControlTurno Object</param>
		''' <param name="validator">The validator Object for this ControlTurnoEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(id As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(id, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_ingresoCaja = New Integralab.ORM.CollectionClasses.IngresoCajaCollection(New IngresoCajaEntityFactory())
			_ingresoCaja.SetContainingEntityInfo(Me, "ControlTurno")
			_alwaysFetchIngresoCaja = False
			_alreadyFetchedIngresoCaja = False
			_notasVenta = New Integralab.ORM.CollectionClasses.NotaVentaCollection(New NotaVentaEntityFactory())
			_notasVenta.SetContainingEntityInfo(Me, "ControlTurno")
			_alwaysFetchNotasVenta = False
			_alreadyFetchedNotasVenta = False
			_notasVentaCanceladas = New Integralab.ORM.CollectionClasses.NotaVentaCollection(New NotaVentaEntityFactory())
			_notasVentaCanceladas.SetContainingEntityInfo(Me, "ControlTurnoCanc")
			_alwaysFetchNotasVentaCanceladas = False
			_alreadyFetchedNotasVentaCanceladas = False
			_retirosCaja = New Integralab.ORM.CollectionClasses.RetiroCajaCollection(New RetiroCajaEntityFactory())
			_retirosCaja.SetContainingEntityInfo(Me, "ControlTurno")
			_alwaysFetchRetirosCaja = False
			_alreadyFetchedRetirosCaja = False
			_sucursalCollectionViaNotaVenta_ = New Integralab.ORM.CollectionClasses.SucursalCollection(New SucursalEntityFactory())
			_alwaysFetchSucursalCollectionViaNotaVenta_ = False
			_alreadyFetchedSucursalCollectionViaNotaVenta_ = False
			_sucursal = Nothing
			_sucursalReturnsNewIfNotFound = True
			_alwaysFetchSucursal = False
			_alreadyFetchedSucursal = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Id", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CodSucursal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CodUsuario", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("CodCaja", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaInicio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaFin", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FondoInicial", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _sucursal</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncSucursal(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _sucursal, AddressOf OnSucursalPropertyChanged, "Sucursal", ControlTurnoEntity.Relations.SucursalEntityUsingCodSucursal, True, signalRelatedEntity, "ControlTurno", resetFKFields, New Integer() { CInt(ControlTurnoFieldIndex.CodSucursal) } )
			_sucursal = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _sucursal</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncSucursal(relatedEntity As IEntity)
			DesetupSyncSucursal(True, True)
			_sucursal = CType(relatedEntity, SucursalEntity)
			MyBase.PerformSetupSyncRelatedEntity( _sucursal, AddressOf OnSucursalPropertyChanged, "Sucursal", ControlTurnoEntity.Relations.SucursalEntityUsingCodSucursal, True, _alreadyFetchedSucursal, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnSucursalPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="id">PK value for ControlTurno which data should be fetched into this ControlTurno Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(id As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(ControlTurnoFieldIndex.Id)).ForcedCurrentValueWrite(id)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateControlTurnoDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New ControlTurnoEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As ControlTurnoRelations
			Get	
				Return New ControlTurnoRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'IngresoCaja' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathIngresoCaja() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.IngresoCajaCollection(), _
					ControlTurnoEntity.Relations.IngresoCajaEntityUsingCodControlTurno, _
					CType(Integralab.ORM.EntityType.ControlTurnoEntity, Integer), CType(Integralab.ORM.EntityType.IngresoCajaEntity, Integer), 0, Nothing, Nothing, Nothing, "IngresoCaja", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'NotaVenta' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathNotasVenta() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.NotaVentaCollection(), _
					ControlTurnoEntity.Relations.NotaVentaEntityUsingIdControlTurno, _
					CType(Integralab.ORM.EntityType.ControlTurnoEntity, Integer), CType(Integralab.ORM.EntityType.NotaVentaEntity, Integer), 0, Nothing, Nothing, Nothing, "NotasVenta", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'NotaVenta' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathNotasVentaCanceladas() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.NotaVentaCollection(), _
					ControlTurnoEntity.Relations.NotaVentaEntityUsingIdControlTurnoCanc, _
					CType(Integralab.ORM.EntityType.ControlTurnoEntity, Integer), CType(Integralab.ORM.EntityType.NotaVentaEntity, Integer), 0, Nothing, Nothing, Nothing, "NotasVentaCanceladas", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RetiroCaja' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathRetirosCaja() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.RetiroCajaCollection(), _
					ControlTurnoEntity.Relations.RetiroCajaEntityUsingCodControlTurno, _
					CType(Integralab.ORM.EntityType.ControlTurnoEntity, Integer), CType(Integralab.ORM.EntityType.RetiroCajaEntity, Integer), 0, Nothing, Nothing, Nothing, "RetirosCaja", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Sucursal' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSucursalCollectionViaNotaVenta_() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(ControlTurnoEntity.Relations.NotaVentaEntityUsingIdControlTurnoCanc, "__ControlTurnoEntity__", String.Empty, JoinHint.None)
				relations.Add(NotaVentaEntity.Relations.SucursalEntityUsingCodSucursal)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SucursalCollection(), _
					ControlTurnoEntity.Relations.NotaVentaEntityUsingIdControlTurnoCanc, _
					CType(Integralab.ORM.EntityType.ControlTurnoEntity, Integer), CType(Integralab.ORM.EntityType.SucursalEntity, Integer), 0, Nothing, Nothing, relations, "SucursalCollectionViaNotaVenta_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Sucursal' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSucursal() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SucursalCollection(), _
					ControlTurnoEntity.Relations.SucursalEntityUsingCodSucursal, _
					CType(Integralab.ORM.EntityType.ControlTurnoEntity, Integer), CType(Integralab.ORM.EntityType.SucursalEntity, Integer), 0, Nothing, Nothing, Nothing, "Sucursal", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "ControlTurnoEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return ControlTurnoEntity.CustomProperties
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
				Return ControlTurnoEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The Id property of the Entity ControlTurno<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MVentaControlTurnos"."Id"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [Id]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ControlTurnoFieldIndex.Id, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ControlTurnoFieldIndex.Id, Integer), value)
			End Set
		End Property
	
		''' <summary>The CodSucursal property of the Entity ControlTurno<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MVentaControlTurnos"."CodSucursal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CodSucursal]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ControlTurnoFieldIndex.CodSucursal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ControlTurnoFieldIndex.CodSucursal, Integer), value)
			End Set
		End Property
	
		''' <summary>The CodUsuario property of the Entity ControlTurno<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MVentaControlTurnos"."CodUsuario"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CodUsuario]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ControlTurnoFieldIndex.CodUsuario, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ControlTurnoFieldIndex.CodUsuario, Integer), value)
			End Set
		End Property
	
		''' <summary>The CodCaja property of the Entity ControlTurno<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MVentaControlTurnos"."CodCaja"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [CodCaja]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ControlTurnoFieldIndex.CodCaja, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(ControlTurnoFieldIndex.CodCaja, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaInicio property of the Entity ControlTurno<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MVentaControlTurnos"."FechaInicio"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaInicio]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ControlTurnoFieldIndex.FechaInicio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(ControlTurnoFieldIndex.FechaInicio, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaFin property of the Entity ControlTurno<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MVentaControlTurnos"."FechaFin"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaFin]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ControlTurnoFieldIndex.FechaFin, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(ControlTurnoFieldIndex.FechaFin, Integer), value)
			End Set
		End Property
	
		''' <summary>The FondoInicial property of the Entity ControlTurno<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MVentaControlTurnos"."FondoInicial"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FondoInicial]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(ControlTurnoFieldIndex.FondoInicial, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(ControlTurnoFieldIndex.FondoInicial, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'IngresoCajaEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiIngresoCaja()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [IngresoCaja]() As Integralab.ORM.CollectionClasses.IngresoCajaCollection
			Get
				Return GetMultiIngresoCaja(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for IngresoCaja. When set to true, IngresoCaja is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time IngresoCaja is accessed. You can always execute
		''' a forced fetch by calling GetMultiIngresoCaja(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchIngresoCaja As Boolean
			Get
				Return _alwaysFetchIngresoCaja
			End Get
			Set
				_alwaysFetchIngresoCaja = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'NotaVentaEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiNotasVenta()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [NotasVenta]() As Integralab.ORM.CollectionClasses.NotaVentaCollection
			Get
				Return GetMultiNotasVenta(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for NotasVenta. When set to true, NotasVenta is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time NotasVenta is accessed. You can always execute
		''' a forced fetch by calling GetMultiNotasVenta(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchNotasVenta As Boolean
			Get
				Return _alwaysFetchNotasVenta
			End Get
			Set
				_alwaysFetchNotasVenta = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'NotaVentaEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiNotasVentaCanceladas()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [NotasVentaCanceladas]() As Integralab.ORM.CollectionClasses.NotaVentaCollection
			Get
				Return GetMultiNotasVentaCanceladas(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for NotasVentaCanceladas. When set to true, NotasVentaCanceladas is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time NotasVentaCanceladas is accessed. You can always execute
		''' a forced fetch by calling GetMultiNotasVentaCanceladas(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchNotasVentaCanceladas As Boolean
			Get
				Return _alwaysFetchNotasVentaCanceladas
			End Get
			Set
				_alwaysFetchNotasVentaCanceladas = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'RetiroCajaEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiRetirosCaja()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [RetirosCaja]() As Integralab.ORM.CollectionClasses.RetiroCajaCollection
			Get
				Return GetMultiRetirosCaja(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for RetirosCaja. When set to true, RetirosCaja is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time RetirosCaja is accessed. You can always execute
		''' a forced fetch by calling GetMultiRetirosCaja(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchRetirosCaja As Boolean
			Get
				Return _alwaysFetchRetirosCaja
			End Get
			Set
				_alwaysFetchRetirosCaja = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'SucursalEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSucursalCollectionViaNotaVenta_()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [SucursalCollectionViaNotaVenta_]() As Integralab.ORM.CollectionClasses.SucursalCollection
			Get
				Return GetMultiSucursalCollectionViaNotaVenta_(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for SucursalCollectionViaNotaVenta_. When set to true, SucursalCollectionViaNotaVenta_ is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time SucursalCollectionViaNotaVenta_ is accessed. You can always execute
		''' a forced fetch by calling GetMultiSucursalCollectionViaNotaVenta_(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchSucursalCollectionViaNotaVenta_ As Boolean
			Get
				Return _alwaysFetchSucursalCollectionViaNotaVenta_
			End Get
			Set
				_alwaysFetchSucursalCollectionViaNotaVenta_ = value
			End Set	
		End Property
	
	
		''' <summary>Gets / sets related entity of type 'SucursalEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleSucursal()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Sucursal]() As SucursalEntity
			Get
				Return GetSingleSucursal(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncSucursal(value)
				Else
					If value Is Nothing Then
						If Not _sucursal Is Nothing Then
							_sucursal.UnsetRelatedEntity(Me, "ControlTurno")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "ControlTurno")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Sucursal. When set to true, Sucursal is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Sucursal is accessed. You can always execute
		''' a forced fetch by calling GetSingleSucursal(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchSucursal As Boolean
			Get
				Return _alwaysFetchSucursal
			End Get
			Set
				_alwaysFetchSucursal = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Sucursal is not found
		''' in the database. When set to true, Sucursal will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property SucursalReturnsNewIfNotFound As Boolean
			Get
				Return _sucursalReturnsNewIfNotFound
			End Get
			Set
				_sucursalReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.ControlTurnoEntity)
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
