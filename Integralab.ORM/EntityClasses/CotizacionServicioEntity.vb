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
	''' <summary>Entity class which represents the entity 'CotizacionServicio'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class CotizacionServicioEntity 
#Else
	<Serializable()> _
	Public Class CotizacionServicioEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _usrCompCotizacionServicioDetalle As Integralab.ORM.CollectionClasses.CotizacionServicioDetalleCollection
		Private _alwaysFetchUsrCompCotizacionServicioDetalle, _alreadyFetchedUsrCompCotizacionServicioDetalle As Boolean
		Private _solicitudServiciosDetalleCollectionViaCotizacionServicioDetalle As Integralab.ORM.CollectionClasses.SolicitudServiciosDetalleCollection
		Private _alwaysFetchSolicitudServiciosDetalleCollectionViaCotizacionServicioDetalle, _alreadyFetchedSolicitudServiciosDetalleCollectionViaCotizacionServicioDetalle As Boolean
		Private _proveedor As ProveedorEntity
		Private _alwaysFetchProveedor, _alreadyFetchedProveedor, _proveedorReturnsNewIfNotFound As Boolean
		Private _sucursal As SucursalEntity
		Private _alwaysFetchSucursal, _alreadyFetchedSucursal, _sucursalReturnsNewIfNotFound As Boolean
		Private _tipoMoneda As TipoMonedaEntity
		Private _alwaysFetchTipoMoneda, _alreadyFetchedTipoMoneda, _tipoMonedaReturnsNewIfNotFound As Boolean


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
		''' <param name="folio">PK value for CotizacionServicio which data should be fetched into this CotizacionServicio Object</param>
		Public Sub New(folio As System.String)

			InitClassFetch(folio, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folio">PK value for CotizacionServicio which data should be fetched into this CotizacionServicio Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(folio As System.String, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(folio, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="folio">PK value for CotizacionServicio which data should be fetched into this CotizacionServicio Object</param>
		''' <param name="validator">The custom validator Object for this CotizacionServicioEntity</param>
		Public Sub New(folio As System.String, validator As IValidator)

			InitClassFetch(folio, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_usrCompCotizacionServicioDetalle = CType(info.GetValue("_usrCompCotizacionServicioDetalle", GetType(Integralab.ORM.CollectionClasses.CotizacionServicioDetalleCollection)), Integralab.ORM.CollectionClasses.CotizacionServicioDetalleCollection)
			_alwaysFetchUsrCompCotizacionServicioDetalle = info.GetBoolean("_alwaysFetchUsrCompCotizacionServicioDetalle")
			_alreadyFetchedUsrCompCotizacionServicioDetalle = info.GetBoolean("_alreadyFetchedUsrCompCotizacionServicioDetalle")
			_solicitudServiciosDetalleCollectionViaCotizacionServicioDetalle = CType(info.GetValue("_solicitudServiciosDetalleCollectionViaCotizacionServicioDetalle", GetType(Integralab.ORM.CollectionClasses.SolicitudServiciosDetalleCollection)), Integralab.ORM.CollectionClasses.SolicitudServiciosDetalleCollection)
			_alwaysFetchSolicitudServiciosDetalleCollectionViaCotizacionServicioDetalle = info.GetBoolean("_alwaysFetchSolicitudServiciosDetalleCollectionViaCotizacionServicioDetalle")
			_alreadyFetchedSolicitudServiciosDetalleCollectionViaCotizacionServicioDetalle = info.GetBoolean("_alreadyFetchedSolicitudServiciosDetalleCollectionViaCotizacionServicioDetalle")
			_proveedor = CType(info.GetValue("_proveedor", GetType(ProveedorEntity)), ProveedorEntity)
			If Not _proveedor Is Nothing Then
				AddHandler _proveedor.AfterSave, AddressOf OnEntityAfterSave
			End If
			_proveedorReturnsNewIfNotFound = info.GetBoolean("_proveedorReturnsNewIfNotFound")
			_alwaysFetchProveedor = info.GetBoolean("_alwaysFetchProveedor")
			_alreadyFetchedProveedor = info.GetBoolean("_alreadyFetchedProveedor")
			_sucursal = CType(info.GetValue("_sucursal", GetType(SucursalEntity)), SucursalEntity)
			If Not _sucursal Is Nothing Then
				AddHandler _sucursal.AfterSave, AddressOf OnEntityAfterSave
			End If
			_sucursalReturnsNewIfNotFound = info.GetBoolean("_sucursalReturnsNewIfNotFound")
			_alwaysFetchSucursal = info.GetBoolean("_alwaysFetchSucursal")
			_alreadyFetchedSucursal = info.GetBoolean("_alreadyFetchedSucursal")
			_tipoMoneda = CType(info.GetValue("_tipoMoneda", GetType(TipoMonedaEntity)), TipoMonedaEntity)
			If Not _tipoMoneda Is Nothing Then
				AddHandler _tipoMoneda.AfterSave, AddressOf OnEntityAfterSave
			End If
			_tipoMonedaReturnsNewIfNotFound = info.GetBoolean("_tipoMonedaReturnsNewIfNotFound")
			_alwaysFetchTipoMoneda = info.GetBoolean("_alwaysFetchTipoMoneda")
			_alreadyFetchedTipoMoneda = info.GetBoolean("_alreadyFetchedTipoMoneda")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()
			_alreadyFetchedUsrCompCotizacionServicioDetalle = (_usrCompCotizacionServicioDetalle.Count > 0)
			_alreadyFetchedSolicitudServiciosDetalleCollectionViaCotizacionServicioDetalle = (_solicitudServiciosDetalleCollectionViaCotizacionServicioDetalle.Count > 0)
			_alreadyFetchedProveedor = Not(_proveedor Is Nothing)
			_alreadyFetchedSucursal = Not(_sucursal Is Nothing)
			_alreadyFetchedTipoMoneda = Not(_tipoMoneda Is Nothing)

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
			info.AddValue("_usrCompCotizacionServicioDetalle", _usrCompCotizacionServicioDetalle)
			info.AddValue("_alwaysFetchUsrCompCotizacionServicioDetalle", _alwaysFetchUsrCompCotizacionServicioDetalle)
			info.AddValue("_alreadyFetchedUsrCompCotizacionServicioDetalle", _alreadyFetchedUsrCompCotizacionServicioDetalle)
			info.AddValue("_solicitudServiciosDetalleCollectionViaCotizacionServicioDetalle", _solicitudServiciosDetalleCollectionViaCotizacionServicioDetalle)
			info.AddValue("_alwaysFetchSolicitudServiciosDetalleCollectionViaCotizacionServicioDetalle", _alwaysFetchSolicitudServiciosDetalleCollectionViaCotizacionServicioDetalle)
			info.AddValue("_alreadyFetchedSolicitudServiciosDetalleCollectionViaCotizacionServicioDetalle", _alreadyFetchedSolicitudServiciosDetalleCollectionViaCotizacionServicioDetalle)
			info.AddValue("_proveedor", _proveedor)
			info.AddValue("_proveedorReturnsNewIfNotFound", _proveedorReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchProveedor", _alwaysFetchProveedor)
			info.AddValue("_alreadyFetchedProveedor", _alreadyFetchedProveedor)
			info.AddValue("_sucursal", _sucursal)
			info.AddValue("_sucursalReturnsNewIfNotFound", _sucursalReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchSucursal", _alwaysFetchSucursal)
			info.AddValue("_alreadyFetchedSucursal", _alreadyFetchedSucursal)
			info.AddValue("_tipoMoneda", _tipoMoneda)
			info.AddValue("_tipoMonedaReturnsNewIfNotFound", _tipoMonedaReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchTipoMoneda", _alwaysFetchTipoMoneda)
			info.AddValue("_alreadyFetchedTipoMoneda", _alreadyFetchedTipoMoneda)

			
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
				Case "Sucursal"
					_alreadyFetchedSucursal = True
					Me.Sucursal = CType(entity, SucursalEntity)
				Case "TipoMoneda"
					_alreadyFetchedTipoMoneda = True
					Me.TipoMoneda = CType(entity, TipoMonedaEntity)
				Case "UsrCompCotizacionServicioDetalle"
					_alreadyFetchedUsrCompCotizacionServicioDetalle = True
					If Not entity Is Nothing Then
						Me.UsrCompCotizacionServicioDetalle.Add(CType(entity, CotizacionServicioDetalleEntity))
					End If
				Case "SolicitudServiciosDetalleCollectionViaCotizacionServicioDetalle"
					_alreadyFetchedSolicitudServiciosDetalleCollectionViaCotizacionServicioDetalle = True
					If Not entity Is Nothing Then
						Me.SolicitudServiciosDetalleCollectionViaCotizacionServicioDetalle.Add(CType(entity, SolicitudServiciosDetalleEntity))
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
				Case "Proveedor"
					SetupSyncProveedor(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Sucursal"
					SetupSyncSucursal(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "TipoMoneda"
					SetupSyncTipoMoneda(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "UsrCompCotizacionServicioDetalle"
					_usrCompCotizacionServicioDetalle.Add(CType(relatedEntity, CotizacionServicioDetalleEntity))
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
				Case "Sucursal"
					DesetupSyncSucursal(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "TipoMoneda"
					DesetupSyncTipoMoneda(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "UsrCompCotizacionServicioDetalle"
					MyBase.PerformRelatedEntityRemoval(_usrCompCotizacionServicioDetalle, relatedEntity, signalRelatedEntityManyToOne)
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
			If Not _sucursal Is Nothing Then
				toReturn.Add(_sucursal)
			End If
			If Not _tipoMoneda Is Nothing Then
				toReturn.Add(_tipoMoneda)
			End If


			Return toReturn
		End Function
		
		''' <summary>Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		''' used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		''' <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		Public Overrides Function GetMemberEntityCollections() As List(Of IEntityCollection)
			Dim toReturn As New List(Of IEntityCollection)()
			toReturn.Add(_usrCompCotizacionServicioDetalle)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folio">PK value for CotizacionServicio which data should be fetched into this CotizacionServicio Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folio As System.String) As Boolean
			Return FetchUsingPK(folio, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folio">PK value for CotizacionServicio which data should be fetched into this CotizacionServicio Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(folio As System.String, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(folio, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="folio">PK value for CotizacionServicio which data should be fetched into this CotizacionServicio Object</param>
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As CotizacionServicioFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As CotizacionServicioFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'CotizacionServicioDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'CotizacionServicioDetalleEntity'</returns>
		Public Function GetMultiUsrCompCotizacionServicioDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.CotizacionServicioDetalleCollection
			Return GetMultiUsrCompCotizacionServicioDetalle(forceFetch, _usrCompCotizacionServicioDetalle.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CotizacionServicioDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiUsrCompCotizacionServicioDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.CotizacionServicioDetalleCollection
			Return GetMultiUsrCompCotizacionServicioDetalle(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'CotizacionServicioDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'CotizacionServicioDetalleEntity'</returns>
		Public Function GetMultiUsrCompCotizacionServicioDetalle(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CotizacionServicioDetalleCollection
			Return GetMultiUsrCompCotizacionServicioDetalle(forceFetch, _usrCompCotizacionServicioDetalle.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'CotizacionServicioDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiUsrCompCotizacionServicioDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.CotizacionServicioDetalleCollection
			If ( Not _alreadyFetchedUsrCompCotizacionServicioDetalle Or forceFetch Or _alwaysFetchUsrCompCotizacionServicioDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _usrCompCotizacionServicioDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_usrCompCotizacionServicioDetalle)
					End If
				End If
				_usrCompCotizacionServicioDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_usrCompCotizacionServicioDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_usrCompCotizacionServicioDetalle.GetMultiManyToOne(Me, Nothing, Filter)
				_usrCompCotizacionServicioDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedUsrCompCotizacionServicioDetalle = True
			End If
			Return _usrCompCotizacionServicioDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'UsrCompCotizacionServicioDetalle'. These settings will be taken into account
		''' when the property UsrCompCotizacionServicioDetalle is requested or GetMultiUsrCompCotizacionServicioDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersUsrCompCotizacionServicioDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_usrCompCotizacionServicioDetalle.SortClauses=sortClauses
			_usrCompCotizacionServicioDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'SolicitudServiciosDetalleEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'SolicitudServiciosDetalleEntity'</returns>
		Public Function GetMultiSolicitudServiciosDetalleCollectionViaCotizacionServicioDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.SolicitudServiciosDetalleCollection
			Return GetMultiSolicitudServiciosDetalleCollectionViaCotizacionServicioDetalle(forceFetch, _solicitudServiciosDetalleCollectionViaCotizacionServicioDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'SolicitudServiciosDetalleEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiSolicitudServiciosDetalleCollectionViaCotizacionServicioDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.SolicitudServiciosDetalleCollection
			If ( Not _alreadyFetchedSolicitudServiciosDetalleCollectionViaCotizacionServicioDetalle Or forceFetch Or _alwaysFetchSolicitudServiciosDetalleCollectionViaCotizacionServicioDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _solicitudServiciosDetalleCollectionViaCotizacionServicioDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_solicitudServiciosDetalleCollectionViaCotizacionServicioDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(CotizacionServicioEntity.Relations.CotizacionServicioDetalleEntityUsingFolioCotizacion, "__CotizacionServicioEntity__", "CotizacionServicioDetalle_", JoinHint.None)
				relations.Add(CotizacionServicioDetalleEntity.Relations.SolicitudServiciosDetalleEntityUsingFolioSolicitudIndice, "CotizacionServicioDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(CotizacionServicioFieldIndex.Folio), ComparisonOperator.Equal, Me.Folio))
				_solicitudServiciosDetalleCollectionViaCotizacionServicioDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_solicitudServiciosDetalleCollectionViaCotizacionServicioDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_solicitudServiciosDetalleCollectionViaCotizacionServicioDetalle.GetMulti(Filter, relations)
				_solicitudServiciosDetalleCollectionViaCotizacionServicioDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedSolicitudServiciosDetalleCollectionViaCotizacionServicioDetalle = True
			End If
			Return _solicitudServiciosDetalleCollectionViaCotizacionServicioDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'SolicitudServiciosDetalleCollectionViaCotizacionServicioDetalle'. These settings will be taken into account
		''' when the property SolicitudServiciosDetalleCollectionViaCotizacionServicioDetalle is requested or GetMultiSolicitudServiciosDetalleCollectionViaCotizacionServicioDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersSolicitudServiciosDetalleCollectionViaCotizacionServicioDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_solicitudServiciosDetalleCollectionViaCotizacionServicioDetalle.SortClauses=sortClauses
			_solicitudServiciosDetalleCollectionViaCotizacionServicioDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

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
				If MyBase.CheckIfLazyLoadingShouldOccur(CotizacionServicioEntity.Relations.ProveedorEntityUsingProveedorId) Then
					fetchResult = newEntity.FetchUsingPK(Me.ProveedorId)
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
				If MyBase.CheckIfLazyLoadingShouldOccur(CotizacionServicioEntity.Relations.SucursalEntityUsingSucursalId) Then
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
	
		''' <summary>Retrieves the related entity of type 'TipoMonedaEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'TipoMonedaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleTipoMoneda() As TipoMonedaEntity
			Return GetSingleTipoMoneda(False)
		End Function

		''' <summary>Retrieves the related entity of type 'TipoMonedaEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'TipoMonedaEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleTipoMoneda(forceFetch As Boolean) As TipoMonedaEntity
			If ( Not _alreadyFetchedTipoMoneda Or forceFetch Or _alwaysFetchTipoMoneda) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New TipoMonedaEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(CotizacionServicioEntity.Relations.TipoMonedaEntityUsingTipoMonedaId) Then
					fetchResult = newEntity.FetchUsingPK(Me.TipoMonedaId)
				End If
				If Not _tipoMonedaReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.TipoMoneda = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), TipoMonedaEntity)
					End If
					Me.TipoMoneda = newEntity
					_alreadyFetchedTipoMoneda = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _tipoMoneda
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(CotizacionServicioFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, CotizacionServicioFieldIndex)

					Case CotizacionServicioFieldIndex.SucursalId
						DesetupSyncSucursal(True, False)
						_alreadyFetchedSucursal = False
					Case CotizacionServicioFieldIndex.ProveedorId
						DesetupSyncProveedor(True, False)
						_alreadyFetchedProveedor = False













					Case CotizacionServicioFieldIndex.TipoMonedaId
						DesetupSyncTipoMoneda(True, False)
						_alreadyFetchedTipoMoneda = False

					Case Else
				End Select
				MyBase.PostFieldValueSetAction(toReturn, Me.Fields(fieldIndex).Name)
			End If
			Return toReturn
		End Function

		''' <summary>Adds the internals To the active context. </summary>
		Protected Overrides Overloads Sub AddInternalsToContext()
			_usrCompCotizacionServicioDetalle.ActiveContext = MyBase.ActiveContext
			_solicitudServiciosDetalleCollectionViaCotizacionServicioDetalle.ActiveContext = MyBase.ActiveContext
		If Not _proveedor Is Nothing Then
				_proveedor.ActiveContext = MyBase.ActiveContext
			End If
		If Not _sucursal Is Nothing Then
				_sucursal.ActiveContext = MyBase.ActiveContext
			End If
		If Not _tipoMoneda Is Nothing Then
				_tipoMoneda.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As CotizacionServicioDAO = CType(CreateDAOInstance(), CotizacionServicioDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As CotizacionServicioDAO = CType(CreateDAOInstance(), CotizacionServicioDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As CotizacionServicioDAO = CType(CreateDAOInstance(), CotizacionServicioDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this CotizacionServicioEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.CotizacionServicioEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="folio">PK value for CotizacionServicio which data should be fetched into this CotizacionServicio Object</param>
		''' <param name="validator">The validator Object for this CotizacionServicioEntity</param>
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
			_usrCompCotizacionServicioDetalle = New Integralab.ORM.CollectionClasses.CotizacionServicioDetalleCollection(New CotizacionServicioDetalleEntityFactory())
			_usrCompCotizacionServicioDetalle.SetContainingEntityInfo(Me, "UsrCompCotizacionServicio")
			_alwaysFetchUsrCompCotizacionServicioDetalle = False
			_alreadyFetchedUsrCompCotizacionServicioDetalle = False
			_solicitudServiciosDetalleCollectionViaCotizacionServicioDetalle = New Integralab.ORM.CollectionClasses.SolicitudServiciosDetalleCollection(New SolicitudServiciosDetalleEntityFactory())
			_alwaysFetchSolicitudServiciosDetalleCollectionViaCotizacionServicioDetalle = False
			_alreadyFetchedSolicitudServiciosDetalleCollectionViaCotizacionServicioDetalle = False
			_proveedor = Nothing
			_proveedorReturnsNewIfNotFound = True
			_alwaysFetchProveedor = False
			_alreadyFetchedProveedor = False
			_sucursal = Nothing
			_sucursalReturnsNewIfNotFound = True
			_alwaysFetchSucursal = False
			_alreadyFetchedSucursal = False
			_tipoMoneda = Nothing
			_tipoMonedaReturnsNewIfNotFound = True
			_alwaysFetchTipoMoneda = False
			_alreadyFetchedTipoMoneda = False

			
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

			_fieldsCustomProperties.Add("ProveedorId", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Observaciones", fieldHashtable)
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

			_fieldsCustomProperties.Add("ObservacionesCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("OrdenServicioGenerada", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SubTotal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Iva", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Descuento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Total", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TipoMonedaId", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioOrdenServicio", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _proveedor</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncProveedor(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _proveedor, AddressOf OnProveedorPropertyChanged, "Proveedor", CotizacionServicioEntity.Relations.ProveedorEntityUsingProveedorId, True, signalRelatedEntity, "CotizacionServicio", resetFKFields, New Integer() { CInt(CotizacionServicioFieldIndex.ProveedorId) } )
			_proveedor = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _proveedor</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncProveedor(relatedEntity As IEntity)
			DesetupSyncProveedor(True, True)
			_proveedor = CType(relatedEntity, ProveedorEntity)
			MyBase.PerformSetupSyncRelatedEntity( _proveedor, AddressOf OnProveedorPropertyChanged, "Proveedor", CotizacionServicioEntity.Relations.ProveedorEntityUsingProveedorId, True, _alreadyFetchedProveedor, New String() {  } )
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
		''' <summary>Removes the sync logic for member _sucursal</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncSucursal(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _sucursal, AddressOf OnSucursalPropertyChanged, "Sucursal", CotizacionServicioEntity.Relations.SucursalEntityUsingSucursalId, True, signalRelatedEntity, "CotizacionServicio", resetFKFields, New Integer() { CInt(CotizacionServicioFieldIndex.SucursalId) } )
			_sucursal = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _sucursal</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncSucursal(relatedEntity As IEntity)
			DesetupSyncSucursal(True, True)
			_sucursal = CType(relatedEntity, SucursalEntity)
			MyBase.PerformSetupSyncRelatedEntity( _sucursal, AddressOf OnSucursalPropertyChanged, "Sucursal", CotizacionServicioEntity.Relations.SucursalEntityUsingSucursalId, True, _alreadyFetchedSucursal, New String() {  } )
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
		''' <summary>Removes the sync logic for member _tipoMoneda</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncTipoMoneda(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _tipoMoneda, AddressOf OnTipoMonedaPropertyChanged, "TipoMoneda", CotizacionServicioEntity.Relations.TipoMonedaEntityUsingTipoMonedaId, True, signalRelatedEntity, "CotizacionServicio", resetFKFields, New Integer() { CInt(CotizacionServicioFieldIndex.TipoMonedaId) } )
			_tipoMoneda = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _tipoMoneda</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncTipoMoneda(relatedEntity As IEntity)
			DesetupSyncTipoMoneda(True, True)
			_tipoMoneda = CType(relatedEntity, TipoMonedaEntity)
			MyBase.PerformSetupSyncRelatedEntity( _tipoMoneda, AddressOf OnTipoMonedaPropertyChanged, "TipoMoneda", CotizacionServicioEntity.Relations.TipoMonedaEntityUsingTipoMonedaId, True, _alreadyFetchedTipoMoneda, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnTipoMonedaPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="folio">PK value for CotizacionServicio which data should be fetched into this CotizacionServicio Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(folio As System.String, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(CotizacionServicioFieldIndex.Folio)).ForcedCurrentValueWrite(folio)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateCotizacionServicioDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New CotizacionServicioEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As CotizacionServicioRelations
			Get	
				Return New CotizacionServicioRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'CotizacionServicioDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathUsrCompCotizacionServicioDetalle() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.CotizacionServicioDetalleCollection(), _
					CotizacionServicioEntity.Relations.CotizacionServicioDetalleEntityUsingFolioCotizacion, _
					CType(Integralab.ORM.EntityType.CotizacionServicioEntity, Integer), CType(Integralab.ORM.EntityType.CotizacionServicioDetalleEntity, Integer), 0, Nothing, Nothing, Nothing, "UsrCompCotizacionServicioDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SolicitudServiciosDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSolicitudServiciosDetalleCollectionViaCotizacionServicioDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(CotizacionServicioEntity.Relations.CotizacionServicioDetalleEntityUsingFolioCotizacion, "__CotizacionServicioEntity__", String.Empty, JoinHint.None)
				relations.Add(CotizacionServicioDetalleEntity.Relations.SolicitudServiciosDetalleEntityUsingFolioSolicitudIndice)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SolicitudServiciosDetalleCollection(), _
					CotizacionServicioEntity.Relations.CotizacionServicioDetalleEntityUsingFolioCotizacion, _
					CType(Integralab.ORM.EntityType.CotizacionServicioEntity, Integer), CType(Integralab.ORM.EntityType.SolicitudServiciosDetalleEntity, Integer), 0, Nothing, Nothing, relations, "SolicitudServiciosDetalleCollectionViaCotizacionServicioDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Proveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProveedor() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProveedorCollection(), _
					CotizacionServicioEntity.Relations.ProveedorEntityUsingProveedorId, _
					CType(Integralab.ORM.EntityType.CotizacionServicioEntity, Integer), CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), 0, Nothing, Nothing, Nothing, "Proveedor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Sucursal' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSucursal() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SucursalCollection(), _
					CotizacionServicioEntity.Relations.SucursalEntityUsingSucursalId, _
					CType(Integralab.ORM.EntityType.CotizacionServicioEntity, Integer), CType(Integralab.ORM.EntityType.SucursalEntity, Integer), 0, Nothing, Nothing, Nothing, "Sucursal", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoMoneda' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoMoneda() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoMonedaCollection(), _
					CotizacionServicioEntity.Relations.TipoMonedaEntityUsingTipoMonedaId, _
					CType(Integralab.ORM.EntityType.CotizacionServicioEntity, Integer), CType(Integralab.ORM.EntityType.TipoMonedaEntity, Integer), 0, Nothing, Nothing, Nothing, "TipoMoneda", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "CotizacionServicioEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return CotizacionServicioEntity.CustomProperties
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
				Return CotizacionServicioEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The Folio property of the Entity CotizacionServicio<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrCompCotizacionServicio"."Folio"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 15<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [Folio]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CotizacionServicioFieldIndex.Folio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CotizacionServicioFieldIndex.Folio, Integer), value)
			End Set
		End Property
	
		''' <summary>The SucursalId property of the Entity CotizacionServicio<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrCompCotizacionServicio"."SucursalId"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SucursalId]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CotizacionServicioFieldIndex.SucursalId, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(CotizacionServicioFieldIndex.SucursalId, Integer), value)
			End Set
		End Property
	
		''' <summary>The ProveedorId property of the Entity CotizacionServicio<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrCompCotizacionServicio"."ProveedorId"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ProveedorId]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CotizacionServicioFieldIndex.ProveedorId, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(CotizacionServicioFieldIndex.ProveedorId, Integer), value)
			End Set
		End Property
	
		''' <summary>The Observaciones property of the Entity CotizacionServicio<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrCompCotizacionServicio"."Observaciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Observaciones]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CotizacionServicioFieldIndex.Observaciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CotizacionServicioFieldIndex.Observaciones, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaAlta property of the Entity CotizacionServicio<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrCompCotizacionServicio"."FechaAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaAlta]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CotizacionServicioFieldIndex.FechaAlta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(CotizacionServicioFieldIndex.FechaAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The UsuarioAlta property of the Entity CotizacionServicio<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrCompCotizacionServicio"."UsuarioAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [UsuarioAlta]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CotizacionServicioFieldIndex.UsuarioAlta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(CotizacionServicioFieldIndex.UsuarioAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The UsuarioCancelacion property of the Entity CotizacionServicio<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrCompCotizacionServicio"."UsuarioCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [UsuarioCancelacion]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CotizacionServicioFieldIndex.UsuarioCancelacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(CotizacionServicioFieldIndex.UsuarioCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The MotivoCancelacionId property of the Entity CotizacionServicio<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrCompCotizacionServicio"."MotivoCancelacionId"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [MotivoCancelacionId]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CotizacionServicioFieldIndex.MotivoCancelacionId, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(CotizacionServicioFieldIndex.MotivoCancelacionId, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCancelacion property of the Entity CotizacionServicio<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrCompCotizacionServicio"."FechaCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaCancelacion]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CotizacionServicioFieldIndex.FechaCancelacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(CotizacionServicioFieldIndex.FechaCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The ObservacionesCancelacion property of the Entity CotizacionServicio<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrCompCotizacionServicio"."ObservacionesCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 200<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [ObservacionesCancelacion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CotizacionServicioFieldIndex.ObservacionesCancelacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CotizacionServicioFieldIndex.ObservacionesCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity CotizacionServicio<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrCompCotizacionServicio"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As Nullable(Of System.Int16)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CotizacionServicioFieldIndex.Estatus, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int16))
			End Get
			Set
				SetNewFieldValue(CType(CotizacionServicioFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The OrdenServicioGenerada property of the Entity CotizacionServicio<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrCompCotizacionServicio"."OrdenServicioGenerada"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [OrdenServicioGenerada]() As Nullable(Of System.Boolean)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CotizacionServicioFieldIndex.OrdenServicioGenerada, Integer))

				Return CType(valueToReturn, Nullable(Of System.Boolean))
			End Get
			Set
				SetNewFieldValue(CType(CotizacionServicioFieldIndex.OrdenServicioGenerada, Integer), value)
			End Set
		End Property
	
		''' <summary>The SubTotal property of the Entity CotizacionServicio<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrCompCotizacionServicio"."SubTotal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SubTotal]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CotizacionServicioFieldIndex.SubTotal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CotizacionServicioFieldIndex.SubTotal, Integer), value)
			End Set
		End Property
	
		''' <summary>The Iva property of the Entity CotizacionServicio<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrCompCotizacionServicio"."IVA"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Iva]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CotizacionServicioFieldIndex.Iva, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CotizacionServicioFieldIndex.Iva, Integer), value)
			End Set
		End Property
	
		''' <summary>The Descuento property of the Entity CotizacionServicio<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrCompCotizacionServicio"."Descuento"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Descuento]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CotizacionServicioFieldIndex.Descuento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CotizacionServicioFieldIndex.Descuento, Integer), value)
			End Set
		End Property
	
		''' <summary>The Total property of the Entity CotizacionServicio<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrCompCotizacionServicio"."Total"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Total]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CotizacionServicioFieldIndex.Total, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(CotizacionServicioFieldIndex.Total, Integer), value)
			End Set
		End Property
	
		''' <summary>The TipoMonedaId property of the Entity CotizacionServicio<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrCompCotizacionServicio"."TipoMonedaId"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TipoMonedaId]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CotizacionServicioFieldIndex.TipoMonedaId, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(CotizacionServicioFieldIndex.TipoMonedaId, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioOrdenServicio property of the Entity CotizacionServicio<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "UsrCompCotizacionServicio"."FolioOrdenServicio"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 15<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FolioOrdenServicio]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(CotizacionServicioFieldIndex.FolioOrdenServicio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(CotizacionServicioFieldIndex.FolioOrdenServicio, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'CotizacionServicioDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUsrCompCotizacionServicioDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [UsrCompCotizacionServicioDetalle]() As Integralab.ORM.CollectionClasses.CotizacionServicioDetalleCollection
			Get
				Return GetMultiUsrCompCotizacionServicioDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for UsrCompCotizacionServicioDetalle. When set to true, UsrCompCotizacionServicioDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time UsrCompCotizacionServicioDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiUsrCompCotizacionServicioDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchUsrCompCotizacionServicioDetalle As Boolean
			Get
				Return _alwaysFetchUsrCompCotizacionServicioDetalle
			End Get
			Set
				_alwaysFetchUsrCompCotizacionServicioDetalle = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'SolicitudServiciosDetalleEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSolicitudServiciosDetalleCollectionViaCotizacionServicioDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [SolicitudServiciosDetalleCollectionViaCotizacionServicioDetalle]() As Integralab.ORM.CollectionClasses.SolicitudServiciosDetalleCollection
			Get
				Return GetMultiSolicitudServiciosDetalleCollectionViaCotizacionServicioDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for SolicitudServiciosDetalleCollectionViaCotizacionServicioDetalle. When set to true, SolicitudServiciosDetalleCollectionViaCotizacionServicioDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time SolicitudServiciosDetalleCollectionViaCotizacionServicioDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiSolicitudServiciosDetalleCollectionViaCotizacionServicioDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchSolicitudServiciosDetalleCollectionViaCotizacionServicioDetalle As Boolean
			Get
				Return _alwaysFetchSolicitudServiciosDetalleCollectionViaCotizacionServicioDetalle
			End Get
			Set
				_alwaysFetchSolicitudServiciosDetalleCollectionViaCotizacionServicioDetalle = value
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
							_proveedor.UnsetRelatedEntity(Me, "CotizacionServicio")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "CotizacionServicio")
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
							_sucursal.UnsetRelatedEntity(Me, "CotizacionServicio")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "CotizacionServicio")
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
	
		''' <summary>Gets / sets related entity of type 'TipoMonedaEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleTipoMoneda()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [TipoMoneda]() As TipoMonedaEntity
			Get
				Return GetSingleTipoMoneda(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncTipoMoneda(value)
				Else
					If value Is Nothing Then
						If Not _tipoMoneda Is Nothing Then
							_tipoMoneda.UnsetRelatedEntity(Me, "CotizacionServicio")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "CotizacionServicio")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for TipoMoneda. When set to true, TipoMoneda is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time TipoMoneda is accessed. You can always execute
		''' a forced fetch by calling GetSingleTipoMoneda(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchTipoMoneda As Boolean
			Get
				Return _alwaysFetchTipoMoneda
			End Get
			Set
				_alwaysFetchTipoMoneda = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property TipoMoneda is not found
		''' in the database. When set to true, TipoMoneda will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property TipoMonedaReturnsNewIfNotFound As Boolean
			Get
				Return _tipoMonedaReturnsNewIfNotFound
			End Get
			Set
				_tipoMonedaReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.CotizacionServicioEntity)
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
