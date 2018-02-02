' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: viernes, 2 de febrero de 2018 11:54:48
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
	''' <summary>Entity class which represents the entity 'Presupuesto'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class PresupuestoEntity 
#Else
	<Serializable()> _
	Public Class PresupuestoEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _mcomPresupuestoDetalle As Integralab.ORM.CollectionClasses.PresupuestoCompraDetalleCollection
		Private _alwaysFetchMcomPresupuestoDetalle, _alreadyFetchedMcomPresupuestoDetalle As Boolean
		Private _productoCollectionViaMcomPresupuestoDetalle As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaMcomPresupuestoDetalle, _alreadyFetchedProductoCollectionViaMcomPresupuestoDetalle As Boolean
		Private _motivoCancelacion As MotivoCancelacionEntity
		Private _alwaysFetchMotivoCancelacion, _alreadyFetchedMotivoCancelacion, _motivoCancelacionReturnsNewIfNotFound As Boolean
		Private _sucursal As SucursalEntity
		Private _alwaysFetchSucursal, _alreadyFetchedSucursal, _sucursalReturnsNewIfNotFound As Boolean
		Private _tipoPresupuesto As TipoPresupuestoEntity
		Private _alwaysFetchTipoPresupuesto, _alreadyFetchedTipoPresupuesto, _tipoPresupuestoReturnsNewIfNotFound As Boolean


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
		''' <param name="folio">PK value for Presupuesto which data should be fetched into this Presupuesto Object</param>
		Public Sub New(folio As System.String)

			InitClassFetch(folio, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folio">PK value for Presupuesto which data should be fetched into this Presupuesto Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(folio As System.String, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(folio, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folio">PK value for Presupuesto which data should be fetched into this Presupuesto Object</param>
		''' <param name="validator">The custom validator Object for this PresupuestoEntity</param>
		Public Sub New(folio As System.String, validator As IValidator)

			InitClassFetch(folio, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_mcomPresupuestoDetalle = CType(info.GetValue("_mcomPresupuestoDetalle", GetType(Integralab.ORM.CollectionClasses.PresupuestoCompraDetalleCollection)), Integralab.ORM.CollectionClasses.PresupuestoCompraDetalleCollection)
			_alwaysFetchMcomPresupuestoDetalle = info.GetBoolean("_alwaysFetchMcomPresupuestoDetalle")
			_alreadyFetchedMcomPresupuestoDetalle = info.GetBoolean("_alreadyFetchedMcomPresupuestoDetalle")
			_productoCollectionViaMcomPresupuestoDetalle = CType(info.GetValue("_productoCollectionViaMcomPresupuestoDetalle", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaMcomPresupuestoDetalle = info.GetBoolean("_alwaysFetchProductoCollectionViaMcomPresupuestoDetalle")
			_alreadyFetchedProductoCollectionViaMcomPresupuestoDetalle = info.GetBoolean("_alreadyFetchedProductoCollectionViaMcomPresupuestoDetalle")
			_motivoCancelacion = CType(info.GetValue("_motivoCancelacion", GetType(MotivoCancelacionEntity)), MotivoCancelacionEntity)
			If Not _motivoCancelacion Is Nothing Then
				AddHandler _motivoCancelacion.AfterSave, AddressOf OnEntityAfterSave
			End If
			_motivoCancelacionReturnsNewIfNotFound = info.GetBoolean("_motivoCancelacionReturnsNewIfNotFound")
			_alwaysFetchMotivoCancelacion = info.GetBoolean("_alwaysFetchMotivoCancelacion")
			_alreadyFetchedMotivoCancelacion = info.GetBoolean("_alreadyFetchedMotivoCancelacion")
			_sucursal = CType(info.GetValue("_sucursal", GetType(SucursalEntity)), SucursalEntity)
			If Not _sucursal Is Nothing Then
				AddHandler _sucursal.AfterSave, AddressOf OnEntityAfterSave
			End If
			_sucursalReturnsNewIfNotFound = info.GetBoolean("_sucursalReturnsNewIfNotFound")
			_alwaysFetchSucursal = info.GetBoolean("_alwaysFetchSucursal")
			_alreadyFetchedSucursal = info.GetBoolean("_alreadyFetchedSucursal")
			_tipoPresupuesto = CType(info.GetValue("_tipoPresupuesto", GetType(TipoPresupuestoEntity)), TipoPresupuestoEntity)
			If Not _tipoPresupuesto Is Nothing Then
				AddHandler _tipoPresupuesto.AfterSave, AddressOf OnEntityAfterSave
			End If
			_tipoPresupuestoReturnsNewIfNotFound = info.GetBoolean("_tipoPresupuestoReturnsNewIfNotFound")
			_alwaysFetchTipoPresupuesto = info.GetBoolean("_alwaysFetchTipoPresupuesto")
			_alreadyFetchedTipoPresupuesto = info.GetBoolean("_alreadyFetchedTipoPresupuesto")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedMcomPresupuestoDetalle = (_mcomPresupuestoDetalle.Count > 0)
			_alreadyFetchedProductoCollectionViaMcomPresupuestoDetalle = (_productoCollectionViaMcomPresupuestoDetalle.Count > 0)
			_alreadyFetchedMotivoCancelacion = Not(_motivoCancelacion Is Nothing)
			_alreadyFetchedSucursal = Not(_sucursal Is Nothing)
			_alreadyFetchedTipoPresupuesto = Not(_tipoPresupuesto Is Nothing)

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
			info.AddValue("_mcomPresupuestoDetalle", _mcomPresupuestoDetalle)
			info.AddValue("_alwaysFetchMcomPresupuestoDetalle", _alwaysFetchMcomPresupuestoDetalle)
			info.AddValue("_alreadyFetchedMcomPresupuestoDetalle", _alreadyFetchedMcomPresupuestoDetalle)
			info.AddValue("_productoCollectionViaMcomPresupuestoDetalle", _productoCollectionViaMcomPresupuestoDetalle)
			info.AddValue("_alwaysFetchProductoCollectionViaMcomPresupuestoDetalle", _alwaysFetchProductoCollectionViaMcomPresupuestoDetalle)
			info.AddValue("_alreadyFetchedProductoCollectionViaMcomPresupuestoDetalle", _alreadyFetchedProductoCollectionViaMcomPresupuestoDetalle)
			info.AddValue("_motivoCancelacion", _motivoCancelacion)
			info.AddValue("_motivoCancelacionReturnsNewIfNotFound", _motivoCancelacionReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMotivoCancelacion", _alwaysFetchMotivoCancelacion)
			info.AddValue("_alreadyFetchedMotivoCancelacion", _alreadyFetchedMotivoCancelacion)
			info.AddValue("_sucursal", _sucursal)
			info.AddValue("_sucursalReturnsNewIfNotFound", _sucursalReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchSucursal", _alwaysFetchSucursal)
			info.AddValue("_alreadyFetchedSucursal", _alreadyFetchedSucursal)
			info.AddValue("_tipoPresupuesto", _tipoPresupuesto)
			info.AddValue("_tipoPresupuestoReturnsNewIfNotFound", _tipoPresupuestoReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchTipoPresupuesto", _alwaysFetchTipoPresupuesto)
			info.AddValue("_alreadyFetchedTipoPresupuesto", _alreadyFetchedTipoPresupuesto)

			
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
				Case "MotivoCancelacion"
					_alreadyFetchedMotivoCancelacion = True
					Me.MotivoCancelacion = CType(entity, MotivoCancelacionEntity)
				Case "Sucursal"
					_alreadyFetchedSucursal = True
					Me.Sucursal = CType(entity, SucursalEntity)
				Case "TipoPresupuesto"
					_alreadyFetchedTipoPresupuesto = True
					Me.TipoPresupuesto = CType(entity, TipoPresupuestoEntity)
				Case "McomPresupuestoDetalle"
					_alreadyFetchedMcomPresupuestoDetalle = True
					If Not entity Is Nothing Then
						Me.McomPresupuestoDetalle.Add(CType(entity, PresupuestoCompraDetalleEntity))
					End If
				Case "ProductoCollectionViaMcomPresupuestoDetalle"
					_alreadyFetchedProductoCollectionViaMcomPresupuestoDetalle = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaMcomPresupuestoDetalle.Add(CType(entity, ProductoEntity))
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
				Case "MotivoCancelacion"
					SetupSyncMotivoCancelacion(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Sucursal"
					SetupSyncSucursal(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "TipoPresupuesto"
					SetupSyncTipoPresupuesto(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "McomPresupuestoDetalle"
					_mcomPresupuestoDetalle.Add(CType(relatedEntity, PresupuestoCompraDetalleEntity))
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
				Case "MotivoCancelacion"
					DesetupSyncMotivoCancelacion(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Sucursal"
					DesetupSyncSucursal(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "TipoPresupuesto"
					DesetupSyncTipoPresupuesto(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "McomPresupuestoDetalle"
					MyBase.PerformRelatedEntityRemoval(_mcomPresupuestoDetalle, relatedEntity, signalRelatedEntityManyToOne)
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
			If Not _motivoCancelacion Is Nothing Then
				toReturn.Add(_motivoCancelacion)
			End If
			If Not _sucursal Is Nothing Then
				toReturn.Add(_sucursal)
			End If
			If Not _tipoPresupuesto Is Nothing Then
				toReturn.Add(_tipoPresupuesto)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_mcomPresupuestoDetalle)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folio">PK value for Presupuesto which data should be fetched into this Presupuesto Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folio As System.String) As Boolean
			Return FetchUsingPK(folio, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folio">PK value for Presupuesto which data should be fetched into this Presupuesto Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folio As System.String, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(folio, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folio">PK value for Presupuesto which data should be fetched into this Presupuesto Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folio As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(folio, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.Folio, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As PresupuestoFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As PresupuestoFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'PresupuestoCompraDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'PresupuestoCompraDetalleEntity'</returns>
		Public Function GetMultiMcomPresupuestoDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.PresupuestoCompraDetalleCollection
			Return GetMultiMcomPresupuestoDetalle(forceFetch, _mcomPresupuestoDetalle.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'PresupuestoCompraDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiMcomPresupuestoDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.PresupuestoCompraDetalleCollection
			Return GetMultiMcomPresupuestoDetalle(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'PresupuestoCompraDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'PresupuestoCompraDetalleEntity'</returns>
		Public Function GetMultiMcomPresupuestoDetalle(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.PresupuestoCompraDetalleCollection
			Return GetMultiMcomPresupuestoDetalle(forceFetch, _mcomPresupuestoDetalle.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'PresupuestoCompraDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMcomPresupuestoDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.PresupuestoCompraDetalleCollection
			If ( Not _alreadyFetchedMcomPresupuestoDetalle Or forceFetch Or _alwaysFetchMcomPresupuestoDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _mcomPresupuestoDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_mcomPresupuestoDetalle)
					End If
				End If
				_mcomPresupuestoDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_mcomPresupuestoDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_mcomPresupuestoDetalle.GetMultiManyToOne(Nothing, Me, Filter)
				_mcomPresupuestoDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedMcomPresupuestoDetalle = True
			End If
			Return _mcomPresupuestoDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'McomPresupuestoDetalle'. These settings will be taken into account
		''' when the property McomPresupuestoDetalle is requested or GetMultiMcomPresupuestoDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMcomPresupuestoDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_mcomPresupuestoDetalle.SortClauses=sortClauses
			_mcomPresupuestoDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViaMcomPresupuestoDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViaMcomPresupuestoDetalle(forceFetch, _productoCollectionViaMcomPresupuestoDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViaMcomPresupuestoDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViaMcomPresupuestoDetalle Or forceFetch Or _alwaysFetchProductoCollectionViaMcomPresupuestoDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViaMcomPresupuestoDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViaMcomPresupuestoDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(PresupuestoEntity.Relations.PresupuestoCompraDetalleEntityUsingPresupuestoId, "__PresupuestoEntity__", "PresupuestoCompraDetalle_", JoinHint.None)
				relations.Add(PresupuestoCompraDetalleEntity.Relations.ProductoEntityUsingProductoId, "PresupuestoCompraDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(PresupuestoFieldIndex.Folio), ComparisonOperator.Equal, Me.Folio))
				_productoCollectionViaMcomPresupuestoDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViaMcomPresupuestoDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViaMcomPresupuestoDetalle.GetMulti(Filter, relations)
				_productoCollectionViaMcomPresupuestoDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViaMcomPresupuestoDetalle = True
			End If
			Return _productoCollectionViaMcomPresupuestoDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViaMcomPresupuestoDetalle'. These settings will be taken into account
		''' when the property ProductoCollectionViaMcomPresupuestoDetalle is requested or GetMultiProductoCollectionViaMcomPresupuestoDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViaMcomPresupuestoDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViaMcomPresupuestoDetalle.SortClauses=sortClauses
			_productoCollectionViaMcomPresupuestoDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves the related entity of type 'MotivoCancelacionEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'MotivoCancelacionEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMotivoCancelacion() As MotivoCancelacionEntity
			Return GetSingleMotivoCancelacion(False)
		End Function

		''' <summary>Retrieves the related entity of type 'MotivoCancelacionEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'MotivoCancelacionEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMotivoCancelacion(forceFetch As Boolean) As MotivoCancelacionEntity
			If ( Not _alreadyFetchedMotivoCancelacion Or forceFetch Or _alwaysFetchMotivoCancelacion) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New MotivoCancelacionEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(PresupuestoEntity.Relations.MotivoCancelacionEntityUsingMotivoCancelacionId) Then
					fetchResult = newEntity.FetchUsingPK(Me.MotivoCancelacionId.GetValueOrDefault())
				End If
				If Not _motivoCancelacionReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.MotivoCancelacion = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), MotivoCancelacionEntity)
					End If
					Me.MotivoCancelacion = newEntity
					_alreadyFetchedMotivoCancelacion = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _motivoCancelacion
		End Function
	
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
				If MyBase.CheckIfLazyLoadingShouldOccur(PresupuestoEntity.Relations.SucursalEntityUsingSucursalId) Then
					fetchResult = newEntity.FetchUsingPK(Me.SucursalId)
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
	
		''' <summary>Retrieves the related entity of type 'TipoPresupuestoEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'TipoPresupuestoEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleTipoPresupuesto() As TipoPresupuestoEntity
			Return GetSingleTipoPresupuesto(False)
		End Function

		''' <summary>Retrieves the related entity of type 'TipoPresupuestoEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'TipoPresupuestoEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleTipoPresupuesto(forceFetch As Boolean) As TipoPresupuestoEntity
			If ( Not _alreadyFetchedTipoPresupuesto Or forceFetch Or _alwaysFetchTipoPresupuesto) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New TipoPresupuestoEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(PresupuestoEntity.Relations.TipoPresupuestoEntityUsingTipoPresupuestoId) Then
					fetchResult = newEntity.FetchUsingPK(Me.TipoPresupuestoId)
				End If
				If Not _tipoPresupuestoReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.TipoPresupuesto = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), TipoPresupuestoEntity)
					End If
					Me.TipoPresupuesto = newEntity
					_alreadyFetchedTipoPresupuesto = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _tipoPresupuesto
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(PresupuestoFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, PresupuestoFieldIndex)

					Case PresupuestoFieldIndex.SucursalId
						DesetupSyncSucursal(True, False)
						_alreadyFetchedSucursal = False
					Case PresupuestoFieldIndex.TipoPresupuestoId
						DesetupSyncTipoPresupuesto(True, False)
						_alreadyFetchedTipoPresupuesto = False





					Case PresupuestoFieldIndex.MotivoCancelacionId
						DesetupSyncMotivoCancelacion(True, False)
						_alreadyFetchedMotivoCancelacion = False




					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_mcomPresupuestoDetalle.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaMcomPresupuestoDetalle.ActiveContext = MyBase.ActiveContext
		If Not _motivoCancelacion Is Nothing Then
				_motivoCancelacion.ActiveContext = MyBase.ActiveContext
			End If
		If Not _sucursal Is Nothing Then
				_sucursal.ActiveContext = MyBase.ActiveContext
			End If
		If Not _tipoPresupuesto Is Nothing Then
				_tipoPresupuesto.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As PresupuestoDAO = CType(CreateDAOInstance(), PresupuestoDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As PresupuestoDAO = CType(CreateDAOInstance(), PresupuestoDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As PresupuestoDAO = CType(CreateDAOInstance(), PresupuestoDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this PresupuestoEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.PresupuestoEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="folio">PK value for Presupuesto which data should be fetched into this Presupuesto Object</param>
		''' <param name="validator">The validator Object for this PresupuestoEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(folio As System.String, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(folio, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_mcomPresupuestoDetalle = New Integralab.ORM.CollectionClasses.PresupuestoCompraDetalleCollection(New PresupuestoCompraDetalleEntityFactory())
			_mcomPresupuestoDetalle.SetContainingEntityInfo(Me, "McomPresupuesto")
			_alwaysFetchMcomPresupuestoDetalle = False
			_alreadyFetchedMcomPresupuestoDetalle = False
			_productoCollectionViaMcomPresupuestoDetalle = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaMcomPresupuestoDetalle = False
			_alreadyFetchedProductoCollectionViaMcomPresupuestoDetalle = False
			_motivoCancelacion = Nothing
			_motivoCancelacionReturnsNewIfNotFound = True
			_alwaysFetchMotivoCancelacion = False
			_alreadyFetchedMotivoCancelacion = False
			_sucursal = Nothing
			_sucursalReturnsNewIfNotFound = True
			_alwaysFetchSucursal = False
			_alreadyFetchedSucursal = False
			_tipoPresupuesto = Nothing
			_tipoPresupuestoReturnsNewIfNotFound = True
			_alwaysFetchTipoPresupuesto = False
			_alreadyFetchedTipoPresupuesto = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Folio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SucursalId", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TipoPresupuestoId", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Descripcion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Obserbaciones", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaAlta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("UsuarioAlta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("UsuarioCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("MotivoCancelacionId", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ObserbacionesCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("OrdenCompraGenerada", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _motivoCancelacion</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMotivoCancelacion(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _motivoCancelacion, AddressOf OnMotivoCancelacionPropertyChanged, "MotivoCancelacion", PresupuestoEntity.Relations.MotivoCancelacionEntityUsingMotivoCancelacionId, True, signalRelatedEntity, "McomPresupuesto", resetFKFields, New Integer() { CInt(PresupuestoFieldIndex.MotivoCancelacionId) } )
			_motivoCancelacion = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _motivoCancelacion</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMotivoCancelacion(relatedEntity As IEntity)
			DesetupSyncMotivoCancelacion(True, True)
			_motivoCancelacion = CType(relatedEntity, MotivoCancelacionEntity)
			MyBase.PerformSetupSyncRelatedEntity( _motivoCancelacion, AddressOf OnMotivoCancelacionPropertyChanged, "MotivoCancelacion", PresupuestoEntity.Relations.MotivoCancelacionEntityUsingMotivoCancelacionId, True, _alreadyFetchedMotivoCancelacion, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMotivoCancelacionPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _sucursal</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncSucursal(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _sucursal, AddressOf OnSucursalPropertyChanged, "Sucursal", PresupuestoEntity.Relations.SucursalEntityUsingSucursalId, True, signalRelatedEntity, "McomPresupuesto", resetFKFields, New Integer() { CInt(PresupuestoFieldIndex.SucursalId) } )
			_sucursal = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _sucursal</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncSucursal(relatedEntity As IEntity)
			DesetupSyncSucursal(True, True)
			_sucursal = CType(relatedEntity, SucursalEntity)
			MyBase.PerformSetupSyncRelatedEntity( _sucursal, AddressOf OnSucursalPropertyChanged, "Sucursal", PresupuestoEntity.Relations.SucursalEntityUsingSucursalId, True, _alreadyFetchedSucursal, New String() {  } )
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
		''' <summary>Removes the sync logic for member _tipoPresupuesto</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncTipoPresupuesto(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _tipoPresupuesto, AddressOf OnTipoPresupuestoPropertyChanged, "TipoPresupuesto", PresupuestoEntity.Relations.TipoPresupuestoEntityUsingTipoPresupuestoId, True, signalRelatedEntity, "McomPresupuesto", resetFKFields, New Integer() { CInt(PresupuestoFieldIndex.TipoPresupuestoId) } )
			_tipoPresupuesto = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _tipoPresupuesto</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncTipoPresupuesto(relatedEntity As IEntity)
			DesetupSyncTipoPresupuesto(True, True)
			_tipoPresupuesto = CType(relatedEntity, TipoPresupuestoEntity)
			MyBase.PerformSetupSyncRelatedEntity( _tipoPresupuesto, AddressOf OnTipoPresupuestoPropertyChanged, "TipoPresupuesto", PresupuestoEntity.Relations.TipoPresupuestoEntityUsingTipoPresupuestoId, True, _alreadyFetchedTipoPresupuesto, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnTipoPresupuestoPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="folio">PK value for Presupuesto which data should be fetched into this Presupuesto Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(folio As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(PresupuestoFieldIndex.Folio)).ForcedCurrentValueWrite(folio)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreatePresupuestoDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New PresupuestoEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As PresupuestoRelations
			Get	
				Return New PresupuestoRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'PresupuestoCompraDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcomPresupuestoDetalle() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.PresupuestoCompraDetalleCollection(), _
					PresupuestoEntity.Relations.PresupuestoCompraDetalleEntityUsingPresupuestoId, _
					CType(Integralab.ORM.EntityType.PresupuestoEntity, Integer), CType(Integralab.ORM.EntityType.PresupuestoCompraDetalleEntity, Integer), 0, Nothing, Nothing, Nothing, "McomPresupuestoDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaMcomPresupuestoDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(PresupuestoEntity.Relations.PresupuestoCompraDetalleEntityUsingPresupuestoId, "__PresupuestoEntity__", String.Empty, JoinHint.None)
				relations.Add(PresupuestoCompraDetalleEntity.Relations.ProductoEntityUsingProductoId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					PresupuestoEntity.Relations.PresupuestoCompraDetalleEntityUsingPresupuestoId, _
					CType(Integralab.ORM.EntityType.PresupuestoEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaMcomPresupuestoDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MotivoCancelacion' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMotivoCancelacion() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MotivoCancelacionCollection(), _
					PresupuestoEntity.Relations.MotivoCancelacionEntityUsingMotivoCancelacionId, _
					CType(Integralab.ORM.EntityType.PresupuestoEntity, Integer), CType(Integralab.ORM.EntityType.MotivoCancelacionEntity, Integer), 0, Nothing, Nothing, Nothing, "MotivoCancelacion", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Sucursal' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSucursal() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SucursalCollection(), _
					PresupuestoEntity.Relations.SucursalEntityUsingSucursalId, _
					CType(Integralab.ORM.EntityType.PresupuestoEntity, Integer), CType(Integralab.ORM.EntityType.SucursalEntity, Integer), 0, Nothing, Nothing, Nothing, "Sucursal", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoPresupuesto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoPresupuesto() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoPresupuestoCollection(), _
					PresupuestoEntity.Relations.TipoPresupuestoEntityUsingTipoPresupuestoId, _
					CType(Integralab.ORM.EntityType.PresupuestoEntity, Integer), CType(Integralab.ORM.EntityType.TipoPresupuestoEntity, Integer), 0, Nothing, Nothing, Nothing, "TipoPresupuesto", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "PresupuestoEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return PresupuestoEntity.CustomProperties
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
				Return PresupuestoEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The Folio property of the Entity Presupuesto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComPresupuesto"."Folio"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 15<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [Folio]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PresupuestoFieldIndex.Folio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(PresupuestoFieldIndex.Folio, Integer), value)
			End Set
		End Property
	
		''' <summary>The SucursalId property of the Entity Presupuesto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComPresupuesto"."SucursalId"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SucursalId]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PresupuestoFieldIndex.SucursalId, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(PresupuestoFieldIndex.SucursalId, Integer), value)
			End Set
		End Property
	
		''' <summary>The TipoPresupuestoId property of the Entity Presupuesto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComPresupuesto"."TipoPresupuestoId"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TipoPresupuestoId]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PresupuestoFieldIndex.TipoPresupuestoId, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(PresupuestoFieldIndex.TipoPresupuestoId, Integer), value)
			End Set
		End Property
	
		''' <summary>The Descripcion property of the Entity Presupuesto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComPresupuesto"."Descripcion"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 50<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Descripcion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PresupuestoFieldIndex.Descripcion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(PresupuestoFieldIndex.Descripcion, Integer), value)
			End Set
		End Property
	
		''' <summary>The Obserbaciones property of the Entity Presupuesto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComPresupuesto"."Obserbaciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Obserbaciones]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PresupuestoFieldIndex.Obserbaciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(PresupuestoFieldIndex.Obserbaciones, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaAlta property of the Entity Presupuesto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComPresupuesto"."FechaAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaAlta]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PresupuestoFieldIndex.FechaAlta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(PresupuestoFieldIndex.FechaAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The UsuarioAlta property of the Entity Presupuesto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComPresupuesto"."UsuarioAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [UsuarioAlta]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PresupuestoFieldIndex.UsuarioAlta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(PresupuestoFieldIndex.UsuarioAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The UsuarioCancelacion property of the Entity Presupuesto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComPresupuesto"."UsuarioCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [UsuarioCancelacion]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PresupuestoFieldIndex.UsuarioCancelacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(PresupuestoFieldIndex.UsuarioCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The MotivoCancelacionId property of the Entity Presupuesto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComPresupuesto"."MotivoCancelacionId"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [MotivoCancelacionId]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PresupuestoFieldIndex.MotivoCancelacionId, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(PresupuestoFieldIndex.MotivoCancelacionId, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCancelacion property of the Entity Presupuesto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComPresupuesto"."FechaCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaCancelacion]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PresupuestoFieldIndex.FechaCancelacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(PresupuestoFieldIndex.FechaCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The ObserbacionesCancelacion property of the Entity Presupuesto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComPresupuesto"."ObserbacionesCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 200<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [ObserbacionesCancelacion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PresupuestoFieldIndex.ObserbacionesCancelacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(PresupuestoFieldIndex.ObserbacionesCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity Presupuesto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComPresupuesto"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Int16
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PresupuestoFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int16))
				End If
				Return CType(valueToReturn, System.Int16)
			End Get
			Set
				SetNewFieldValue(CType(PresupuestoFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The OrdenCompraGenerada property of the Entity Presupuesto<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComPresupuesto"."OrdenCompraGenerada"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [OrdenCompraGenerada]() As Nullable(Of System.Boolean)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(PresupuestoFieldIndex.OrdenCompraGenerada, Integer))

				Return CType(valueToReturn, Nullable(Of System.Boolean))
			End Get
			Set
				SetNewFieldValue(CType(PresupuestoFieldIndex.OrdenCompraGenerada, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'PresupuestoCompraDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMcomPresupuestoDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [McomPresupuestoDetalle]() As Integralab.ORM.CollectionClasses.PresupuestoCompraDetalleCollection
			Get
				Return GetMultiMcomPresupuestoDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for McomPresupuestoDetalle. When set to true, McomPresupuestoDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McomPresupuestoDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiMcomPresupuestoDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcomPresupuestoDetalle As Boolean
			Get
				Return _alwaysFetchMcomPresupuestoDetalle
			End Get
			Set
				_alwaysFetchMcomPresupuestoDetalle = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViaMcomPresupuestoDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViaMcomPresupuestoDetalle]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViaMcomPresupuestoDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViaMcomPresupuestoDetalle. When set to true, ProductoCollectionViaMcomPresupuestoDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViaMcomPresupuestoDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViaMcomPresupuestoDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViaMcomPresupuestoDetalle As Boolean
			Get
				Return _alwaysFetchProductoCollectionViaMcomPresupuestoDetalle
			End Get
			Set
				_alwaysFetchProductoCollectionViaMcomPresupuestoDetalle = value
			End Set	
		End Property
	
	
		''' <summary>Gets / sets related entity of type 'MotivoCancelacionEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMotivoCancelacion()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [MotivoCancelacion]() As MotivoCancelacionEntity
			Get
				Return GetSingleMotivoCancelacion(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMotivoCancelacion(value)
				Else
					If value Is Nothing Then
						If Not _motivoCancelacion Is Nothing Then
							_motivoCancelacion.UnsetRelatedEntity(Me, "McomPresupuesto")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "McomPresupuesto")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for MotivoCancelacion. When set to true, MotivoCancelacion is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MotivoCancelacion is accessed. You can always execute
		''' a forced fetch by calling GetSingleMotivoCancelacion(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMotivoCancelacion As Boolean
			Get
				Return _alwaysFetchMotivoCancelacion
			End Get
			Set
				_alwaysFetchMotivoCancelacion = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property MotivoCancelacion is not found
		''' in the database. When set to true, MotivoCancelacion will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property MotivoCancelacionReturnsNewIfNotFound As Boolean
			Get
				Return _motivoCancelacionReturnsNewIfNotFound
			End Get
			Set
				_motivoCancelacionReturnsNewIfNotFound = value
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
							_sucursal.UnsetRelatedEntity(Me, "McomPresupuesto")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "McomPresupuesto")
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
	
		''' <summary>Gets / sets related entity of type 'TipoPresupuestoEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleTipoPresupuesto()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [TipoPresupuesto]() As TipoPresupuestoEntity
			Get
				Return GetSingleTipoPresupuesto(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncTipoPresupuesto(value)
				Else
					If value Is Nothing Then
						If Not _tipoPresupuesto Is Nothing Then
							_tipoPresupuesto.UnsetRelatedEntity(Me, "McomPresupuesto")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "McomPresupuesto")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for TipoPresupuesto. When set to true, TipoPresupuesto is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time TipoPresupuesto is accessed. You can always execute
		''' a forced fetch by calling GetSingleTipoPresupuesto(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchTipoPresupuesto As Boolean
			Get
				Return _alwaysFetchTipoPresupuesto
			End Get
			Set
				_alwaysFetchTipoPresupuesto = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property TipoPresupuesto is not found
		''' in the database. When set to true, TipoPresupuesto will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property TipoPresupuestoReturnsNewIfNotFound As Boolean
			Get
				Return _tipoPresupuestoReturnsNewIfNotFound
			End Get
			Set
				_tipoPresupuestoReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.PresupuestoEntity)
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
