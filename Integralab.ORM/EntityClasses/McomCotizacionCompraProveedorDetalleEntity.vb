' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: miércoles, 31 de enero de 2018 11:15:24
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
	''' <summary>Entity class which represents the entity 'McomCotizacionCompraProveedorDetalle'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class McomCotizacionCompraProveedorDetalleEntity 
#Else
	<Serializable()> _
	Public Class McomCotizacionCompraProveedorDetalleEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"


		Private _producto As ProductoEntity
		Private _alwaysFetchProducto, _alreadyFetchedProducto, _productoReturnsNewIfNotFound As Boolean
		Private _solicitudProductoDetalle As SolicitudProductoDetalleEntity
		Private _alwaysFetchSolicitudProductoDetalle, _alreadyFetchedSolicitudProductoDetalle, _solicitudProductoDetalleReturnsNewIfNotFound As Boolean
		Private _proveedor As ProveedorEntity
		Private _alwaysFetchProveedor, _alreadyFetchedProveedor, _proveedorReturnsNewIfNotFound As Boolean
		Private _tipoMoneda As TipoMonedaEntity
		Private _alwaysFetchTipoMoneda, _alreadyFetchedTipoMoneda, _tipoMonedaReturnsNewIfNotFound As Boolean
		Private _cotizacionCompra As McomCotizacionCompraEntity
		Private _alwaysFetchCotizacionCompra, _alreadyFetchedCotizacionCompra, _cotizacionCompraReturnsNewIfNotFound As Boolean
		Private _mcomCotizacionCompraProveedor As McomCotizacionCompraProveedorEntity
		Private _alwaysFetchMcomCotizacionCompraProveedor, _alreadyFetchedMcomCotizacionCompraProveedor, _mcomCotizacionCompraProveedorReturnsNewIfNotFound As Boolean


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
		''' <param name="idCotizacion">PK value for McomCotizacionCompraProveedorDetalle which data should be fetched into this McomCotizacionCompraProveedorDetalle Object</param>
		''' <param name="idProveedor">PK value for McomCotizacionCompraProveedorDetalle which data should be fetched into this McomCotizacionCompraProveedorDetalle Object</param>
		''' <param name="idProducto">PK value for McomCotizacionCompraProveedorDetalle which data should be fetched into this McomCotizacionCompraProveedorDetalle Object</param>
		Public Sub New(idCotizacion As System.Int32, idProveedor As System.Int32, idProducto As System.Int32)

			InitClassFetch(idCotizacion, idProveedor, idProducto, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idCotizacion">PK value for McomCotizacionCompraProveedorDetalle which data should be fetched into this McomCotizacionCompraProveedorDetalle Object</param>
		''' <param name="idProveedor">PK value for McomCotizacionCompraProveedorDetalle which data should be fetched into this McomCotizacionCompraProveedorDetalle Object</param>
		''' <param name="idProducto">PK value for McomCotizacionCompraProveedorDetalle which data should be fetched into this McomCotizacionCompraProveedorDetalle Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(idCotizacion As System.Int32, idProveedor As System.Int32, idProducto As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(idCotizacion, idProveedor, idProducto, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idCotizacion">PK value for McomCotizacionCompraProveedorDetalle which data should be fetched into this McomCotizacionCompraProveedorDetalle Object</param>
		''' <param name="idProveedor">PK value for McomCotizacionCompraProveedorDetalle which data should be fetched into this McomCotizacionCompraProveedorDetalle Object</param>
		''' <param name="idProducto">PK value for McomCotizacionCompraProveedorDetalle which data should be fetched into this McomCotizacionCompraProveedorDetalle Object</param>
		''' <param name="validator">The custom validator Object for this McomCotizacionCompraProveedorDetalleEntity</param>
		Public Sub New(idCotizacion As System.Int32, idProveedor As System.Int32, idProducto As System.Int32, validator As IValidator)

			InitClassFetch(idCotizacion, idProveedor, idProducto, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)


			_producto = CType(info.GetValue("_producto", GetType(ProductoEntity)), ProductoEntity)
			If Not _producto Is Nothing Then
				AddHandler _producto.AfterSave, AddressOf OnEntityAfterSave
			End If
			_productoReturnsNewIfNotFound = info.GetBoolean("_productoReturnsNewIfNotFound")
			_alwaysFetchProducto = info.GetBoolean("_alwaysFetchProducto")
			_alreadyFetchedProducto = info.GetBoolean("_alreadyFetchedProducto")
			_solicitudProductoDetalle = CType(info.GetValue("_solicitudProductoDetalle", GetType(SolicitudProductoDetalleEntity)), SolicitudProductoDetalleEntity)
			If Not _solicitudProductoDetalle Is Nothing Then
				AddHandler _solicitudProductoDetalle.AfterSave, AddressOf OnEntityAfterSave
			End If
			_solicitudProductoDetalleReturnsNewIfNotFound = info.GetBoolean("_solicitudProductoDetalleReturnsNewIfNotFound")
			_alwaysFetchSolicitudProductoDetalle = info.GetBoolean("_alwaysFetchSolicitudProductoDetalle")
			_alreadyFetchedSolicitudProductoDetalle = info.GetBoolean("_alreadyFetchedSolicitudProductoDetalle")
			_proveedor = CType(info.GetValue("_proveedor", GetType(ProveedorEntity)), ProveedorEntity)
			If Not _proveedor Is Nothing Then
				AddHandler _proveedor.AfterSave, AddressOf OnEntityAfterSave
			End If
			_proveedorReturnsNewIfNotFound = info.GetBoolean("_proveedorReturnsNewIfNotFound")
			_alwaysFetchProveedor = info.GetBoolean("_alwaysFetchProveedor")
			_alreadyFetchedProveedor = info.GetBoolean("_alreadyFetchedProveedor")
			_tipoMoneda = CType(info.GetValue("_tipoMoneda", GetType(TipoMonedaEntity)), TipoMonedaEntity)
			If Not _tipoMoneda Is Nothing Then
				AddHandler _tipoMoneda.AfterSave, AddressOf OnEntityAfterSave
			End If
			_tipoMonedaReturnsNewIfNotFound = info.GetBoolean("_tipoMonedaReturnsNewIfNotFound")
			_alwaysFetchTipoMoneda = info.GetBoolean("_alwaysFetchTipoMoneda")
			_alreadyFetchedTipoMoneda = info.GetBoolean("_alreadyFetchedTipoMoneda")
			_cotizacionCompra = CType(info.GetValue("_cotizacionCompra", GetType(McomCotizacionCompraEntity)), McomCotizacionCompraEntity)
			If Not _cotizacionCompra Is Nothing Then
				AddHandler _cotizacionCompra.AfterSave, AddressOf OnEntityAfterSave
			End If
			_cotizacionCompraReturnsNewIfNotFound = info.GetBoolean("_cotizacionCompraReturnsNewIfNotFound")
			_alwaysFetchCotizacionCompra = info.GetBoolean("_alwaysFetchCotizacionCompra")
			_alreadyFetchedCotizacionCompra = info.GetBoolean("_alreadyFetchedCotizacionCompra")
			_mcomCotizacionCompraProveedor = CType(info.GetValue("_mcomCotizacionCompraProveedor", GetType(McomCotizacionCompraProveedorEntity)), McomCotizacionCompraProveedorEntity)
			If Not _mcomCotizacionCompraProveedor Is Nothing Then
				AddHandler _mcomCotizacionCompraProveedor.AfterSave, AddressOf OnEntityAfterSave
			End If
			_mcomCotizacionCompraProveedorReturnsNewIfNotFound = info.GetBoolean("_mcomCotizacionCompraProveedorReturnsNewIfNotFound")
			_alwaysFetchMcomCotizacionCompraProveedor = info.GetBoolean("_alwaysFetchMcomCotizacionCompraProveedor")
			_alreadyFetchedMcomCotizacionCompraProveedor = info.GetBoolean("_alreadyFetchedMcomCotizacionCompraProveedor")

			MyBase.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance())
			
			' __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub


		''' <summary> Will perform post-ReadXml actions</summary>
		Protected Overrides Sub PostReadXmlFixups()


			_alreadyFetchedProducto = Not(_producto Is Nothing)
			_alreadyFetchedSolicitudProductoDetalle = Not(_solicitudProductoDetalle Is Nothing)
			_alreadyFetchedProveedor = Not(_proveedor Is Nothing)
			_alreadyFetchedTipoMoneda = Not(_tipoMoneda Is Nothing)
			_alreadyFetchedCotizacionCompra = Not(_cotizacionCompra Is Nothing)
			_alreadyFetchedMcomCotizacionCompraProveedor = Not(_mcomCotizacionCompraProveedor Is Nothing)

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


			info.AddValue("_producto", _producto)
			info.AddValue("_productoReturnsNewIfNotFound", _productoReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchProducto", _alwaysFetchProducto)
			info.AddValue("_alreadyFetchedProducto", _alreadyFetchedProducto)
			info.AddValue("_solicitudProductoDetalle", _solicitudProductoDetalle)
			info.AddValue("_solicitudProductoDetalleReturnsNewIfNotFound", _solicitudProductoDetalleReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchSolicitudProductoDetalle", _alwaysFetchSolicitudProductoDetalle)
			info.AddValue("_alreadyFetchedSolicitudProductoDetalle", _alreadyFetchedSolicitudProductoDetalle)
			info.AddValue("_proveedor", _proveedor)
			info.AddValue("_proveedorReturnsNewIfNotFound", _proveedorReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchProveedor", _alwaysFetchProveedor)
			info.AddValue("_alreadyFetchedProveedor", _alreadyFetchedProveedor)
			info.AddValue("_tipoMoneda", _tipoMoneda)
			info.AddValue("_tipoMonedaReturnsNewIfNotFound", _tipoMonedaReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchTipoMoneda", _alwaysFetchTipoMoneda)
			info.AddValue("_alreadyFetchedTipoMoneda", _alreadyFetchedTipoMoneda)
			info.AddValue("_cotizacionCompra", _cotizacionCompra)
			info.AddValue("_cotizacionCompraReturnsNewIfNotFound", _cotizacionCompraReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchCotizacionCompra", _alwaysFetchCotizacionCompra)
			info.AddValue("_alreadyFetchedCotizacionCompra", _alreadyFetchedCotizacionCompra)
			info.AddValue("_mcomCotizacionCompraProveedor", _mcomCotizacionCompraProveedor)
			info.AddValue("_mcomCotizacionCompraProveedorReturnsNewIfNotFound", _mcomCotizacionCompraProveedorReturnsNewIfNotFound)
			info.AddValue("_alwaysFetchMcomCotizacionCompraProveedor", _alwaysFetchMcomCotizacionCompraProveedor)
			info.AddValue("_alreadyFetchedMcomCotizacionCompraProveedor", _alreadyFetchedMcomCotizacionCompraProveedor)

			
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
				Case "Producto"
					_alreadyFetchedProducto = True
					Me.Producto = CType(entity, ProductoEntity)
				Case "SolicitudProductoDetalle"
					_alreadyFetchedSolicitudProductoDetalle = True
					Me.SolicitudProductoDetalle = CType(entity, SolicitudProductoDetalleEntity)
				Case "Proveedor"
					_alreadyFetchedProveedor = True
					Me.Proveedor = CType(entity, ProveedorEntity)
				Case "TipoMoneda"
					_alreadyFetchedTipoMoneda = True
					Me.TipoMoneda = CType(entity, TipoMonedaEntity)
				Case "CotizacionCompra"
					_alreadyFetchedCotizacionCompra = True
					Me.CotizacionCompra = CType(entity, McomCotizacionCompraEntity)
				Case "McomCotizacionCompraProveedor"
					_alreadyFetchedMcomCotizacionCompraProveedor = True
					Me.McomCotizacionCompraProveedor = CType(entity, McomCotizacionCompraProveedorEntity)



				Case Else

			End Select
		End Sub

		''' <summary>Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		''' <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		<EditorBrowsable(EditorBrowsableState.Never)> _
		Public Overrides Overloads Sub SetRelatedEntity(relatedEntity As IEntity, fieldName As String)
			Select Case fieldName
				Case "Producto"
					SetupSyncProducto(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "SolicitudProductoDetalle"
					SetupSyncSolicitudProductoDetalle(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "Proveedor"
					SetupSyncProveedor(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "TipoMoneda"
					SetupSyncTipoMoneda(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "CotizacionCompra"
					SetupSyncCotizacionCompra(relatedEntity)
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "McomCotizacionCompraProveedor"
					SetupSyncMcomCotizacionCompraProveedor(relatedEntity)
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
				Case "Producto"
					DesetupSyncProducto(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "SolicitudProductoDetalle"
					DesetupSyncSolicitudProductoDetalle(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "Proveedor"
					DesetupSyncProveedor(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "TipoMoneda"
					DesetupSyncTipoMoneda(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "CotizacionCompra"
					DesetupSyncCotizacionCompra(False, True)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "McomCotizacionCompraProveedor"
					DesetupSyncMcomCotizacionCompraProveedor(False, True)
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
			If Not _producto Is Nothing Then
				toReturn.Add(_producto)
			End If
			If Not _solicitudProductoDetalle Is Nothing Then
				toReturn.Add(_solicitudProductoDetalle)
			End If
			If Not _proveedor Is Nothing Then
				toReturn.Add(_proveedor)
			End If
			If Not _tipoMoneda Is Nothing Then
				toReturn.Add(_tipoMoneda)
			End If
			If Not _cotizacionCompra Is Nothing Then
				toReturn.Add(_cotizacionCompra)
			End If
			If Not _mcomCotizacionCompraProveedor Is Nothing Then
				toReturn.Add(_mcomCotizacionCompraProveedor)
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
		''' <param name="idCotizacion">PK value for McomCotizacionCompraProveedorDetalle which data should be fetched into this McomCotizacionCompraProveedorDetalle Object</param>
		''' <param name="idProveedor">PK value for McomCotizacionCompraProveedorDetalle which data should be fetched into this McomCotizacionCompraProveedorDetalle Object</param>
		''' <param name="idProducto">PK value for McomCotizacionCompraProveedorDetalle which data should be fetched into this McomCotizacionCompraProveedorDetalle Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idCotizacion As System.Int32, idProveedor As System.Int32, idProducto As System.Int32) As Boolean
			Return FetchUsingPK(idCotizacion, idProveedor, idProducto, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idCotizacion">PK value for McomCotizacionCompraProveedorDetalle which data should be fetched into this McomCotizacionCompraProveedorDetalle Object</param>
		''' <param name="idProveedor">PK value for McomCotizacionCompraProveedorDetalle which data should be fetched into this McomCotizacionCompraProveedorDetalle Object</param>
		''' <param name="idProducto">PK value for McomCotizacionCompraProveedorDetalle which data should be fetched into this McomCotizacionCompraProveedorDetalle Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idCotizacion As System.Int32, idProveedor As System.Int32, idProducto As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(idCotizacion, idProveedor, idProducto, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idCotizacion">PK value for McomCotizacionCompraProveedorDetalle which data should be fetched into this McomCotizacionCompraProveedorDetalle Object</param>
		''' <param name="idProveedor">PK value for McomCotizacionCompraProveedorDetalle which data should be fetched into this McomCotizacionCompraProveedorDetalle Object</param>
		''' <param name="idProducto">PK value for McomCotizacionCompraProveedorDetalle which data should be fetched into this McomCotizacionCompraProveedorDetalle Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idCotizacion As System.Int32, idProveedor As System.Int32, idProducto As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(idCotizacion, idProveedor, idProducto, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.IdCotizacion, Me.IdProveedor, Me.IdProducto, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As McomCotizacionCompraProveedorDetalleFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As McomCotizacionCompraProveedorDetalleFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



	

		''' <summary>Retrieves the related entity of type 'ProductoEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'ProductoEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleProducto() As ProductoEntity
			Return GetSingleProducto(False)
		End Function

		''' <summary>Retrieves the related entity of type 'ProductoEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'ProductoEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleProducto(forceFetch As Boolean) As ProductoEntity
			If ( Not _alreadyFetchedProducto Or forceFetch Or _alwaysFetchProducto) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New ProductoEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(McomCotizacionCompraProveedorDetalleEntity.Relations.ProductoEntityUsingIdProducto) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdProducto)
				End If
				If Not _productoReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.Producto = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), ProductoEntity)
					End If
					Me.Producto = newEntity
					_alreadyFetchedProducto = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _producto
		End Function
	
		''' <summary>Retrieves the related entity of type 'SolicitudProductoDetalleEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'SolicitudProductoDetalleEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleSolicitudProductoDetalle() As SolicitudProductoDetalleEntity
			Return GetSingleSolicitudProductoDetalle(False)
		End Function

		''' <summary>Retrieves the related entity of type 'SolicitudProductoDetalleEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'SolicitudProductoDetalleEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleSolicitudProductoDetalle(forceFetch As Boolean) As SolicitudProductoDetalleEntity
			If ( Not _alreadyFetchedSolicitudProductoDetalle Or forceFetch Or _alwaysFetchSolicitudProductoDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New SolicitudProductoDetalleEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(McomCotizacionCompraProveedorDetalleEntity.Relations.SolicitudProductoDetalleEntityUsingIdSolicitudIdProducto) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdSolicitud, Me.IdProducto)
				End If
				If Not _solicitudProductoDetalleReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.SolicitudProductoDetalle = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), SolicitudProductoDetalleEntity)
					End If
					Me.SolicitudProductoDetalle = newEntity
					_alreadyFetchedSolicitudProductoDetalle = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _solicitudProductoDetalle
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
				If MyBase.CheckIfLazyLoadingShouldOccur(McomCotizacionCompraProveedorDetalleEntity.Relations.ProveedorEntityUsingIdProveedor) Then
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
				If MyBase.CheckIfLazyLoadingShouldOccur(McomCotizacionCompraProveedorDetalleEntity.Relations.TipoMonedaEntityUsingIdMoneda) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdMoneda)
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
	
		''' <summary>Retrieves the related entity of type 'McomCotizacionCompraEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'McomCotizacionCompraEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCotizacionCompra() As McomCotizacionCompraEntity
			Return GetSingleCotizacionCompra(False)
		End Function

		''' <summary>Retrieves the related entity of type 'McomCotizacionCompraEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'McomCotizacionCompraEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleCotizacionCompra(forceFetch As Boolean) As McomCotizacionCompraEntity
			If ( Not _alreadyFetchedCotizacionCompra Or forceFetch Or _alwaysFetchCotizacionCompra) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New McomCotizacionCompraEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(McomCotizacionCompraProveedorDetalleEntity.Relations.McomCotizacionCompraEntityUsingIdCotizacion) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdCotizacion)
				End If
				If Not _cotizacionCompraReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.CotizacionCompra = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), McomCotizacionCompraEntity)
					End If
					Me.CotizacionCompra = newEntity
					_alreadyFetchedCotizacionCompra = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _cotizacionCompra
		End Function
	
		''' <summary>Retrieves the related entity of type 'McomCotizacionCompraProveedorEntity', Imports a relation of type 'n:1'</summary>
		''' <returns>A fetched entity of type 'McomCotizacionCompraProveedorEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMcomCotizacionCompraProveedor() As McomCotizacionCompraProveedorEntity
			Return GetSingleMcomCotizacionCompraProveedor(False)
		End Function

		''' <summary>Retrieves the related entity of type 'McomCotizacionCompraProveedorEntity', Imports a relation of type 'n:1'</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		''' <returns>A fetched entity of type 'McomCotizacionCompraProveedorEntity' which is related to this entity.</returns>
		Public Overridable Function GetSingleMcomCotizacionCompraProveedor(forceFetch As Boolean) As McomCotizacionCompraProveedorEntity
			If ( Not _alreadyFetchedMcomCotizacionCompraProveedor Or forceFetch Or _alwaysFetchMcomCotizacionCompraProveedor) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing Then

				Dim newEntity As New McomCotizacionCompraProveedorEntity()
				If MyBase.ParticipatesInTransaction Then
					MyBase.Transaction.Add(newEntity)
				End If
				Dim fetchResult As Boolean = False
				If MyBase.CheckIfLazyLoadingShouldOccur(McomCotizacionCompraProveedorDetalleEntity.Relations.McomCotizacionCompraProveedorEntityUsingIdCotizacionIdProveedor) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdCotizacion, Me.IdProveedor)
				End If
				If Not _mcomCotizacionCompraProveedorReturnsNewIfNotFound AndAlso Not fetchResult Then
					Me.McomCotizacionCompraProveedor = Nothing
				Else
					If Not MyBase.ActiveContext Is Nothing AndAlso fetchResult Then
						newEntity = CType(MyBase.ActiveContext.Get(newEntity), McomCotizacionCompraProveedorEntity)
					End If
					Me.McomCotizacionCompraProveedor = newEntity
					_alreadyFetchedMcomCotizacionCompraProveedor = fetchResult
				End If
				If MyBase.ParticipatesInTransaction AndAlso Not fetchResult Then
					MyBase.Transaction.Remove(newEntity)
				End If
			End If
			Return _mcomCotizacionCompraProveedor
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
			If toReturn AndAlso System.Enum.IsDefined(GetType(McomCotizacionCompraProveedorDetalleFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, McomCotizacionCompraProveedorDetalleFieldIndex)
					Case McomCotizacionCompraProveedorDetalleFieldIndex.IdCotizacion
						DesetupSyncCotizacionCompra(True, False)
						_alreadyFetchedCotizacionCompra = False
						DesetupSyncMcomCotizacionCompraProveedor(True, False)
						_alreadyFetchedMcomCotizacionCompraProveedor = False
					Case McomCotizacionCompraProveedorDetalleFieldIndex.IdProveedor
						DesetupSyncProveedor(True, False)
						_alreadyFetchedProveedor = False
						DesetupSyncMcomCotizacionCompraProveedor(True, False)
						_alreadyFetchedMcomCotizacionCompraProveedor = False
					Case McomCotizacionCompraProveedorDetalleFieldIndex.IdProducto
						DesetupSyncProducto(True, False)
						_alreadyFetchedProducto = False
						DesetupSyncSolicitudProductoDetalle(True, False)
						_alreadyFetchedSolicitudProductoDetalle = False
					Case McomCotizacionCompraProveedorDetalleFieldIndex.IdSolicitud
						DesetupSyncSolicitudProductoDetalle(True, False)
						_alreadyFetchedSolicitudProductoDetalle = False

					Case McomCotizacionCompraProveedorDetalleFieldIndex.IdMoneda
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


		If Not _producto Is Nothing Then
				_producto.ActiveContext = MyBase.ActiveContext
			End If
		If Not _solicitudProductoDetalle Is Nothing Then
				_solicitudProductoDetalle.ActiveContext = MyBase.ActiveContext
			End If
		If Not _proveedor Is Nothing Then
				_proveedor.ActiveContext = MyBase.ActiveContext
			End If
		If Not _tipoMoneda Is Nothing Then
				_tipoMoneda.ActiveContext = MyBase.ActiveContext
			End If
		If Not _cotizacionCompra Is Nothing Then
				_cotizacionCompra.ActiveContext = MyBase.ActiveContext
			End If
		If Not _mcomCotizacionCompraProveedor Is Nothing Then
				_mcomCotizacionCompraProveedor.ActiveContext = MyBase.ActiveContext
			End If


		End Sub

		''' <summary>Performs the insert action of a new Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function InsertEntity() As Boolean
			Dim dao As McomCotizacionCompraProveedorDetalleDAO = CType(CreateDAOInstance(), McomCotizacionCompraProveedorDetalleDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As McomCotizacionCompraProveedorDetalleDAO = CType(CreateDAOInstance(), McomCotizacionCompraProveedorDetalleDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As McomCotizacionCompraProveedorDetalleDAO = CType(CreateDAOInstance(), McomCotizacionCompraProveedorDetalleDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this McomCotizacionCompraProveedorDetalleEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.McomCotizacionCompraProveedorDetalleEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="idCotizacion">PK value for McomCotizacionCompraProveedorDetalle which data should be fetched into this McomCotizacionCompraProveedorDetalle Object</param>
		''' <param name="idProveedor">PK value for McomCotizacionCompraProveedorDetalle which data should be fetched into this McomCotizacionCompraProveedorDetalle Object</param>
		''' <param name="idProducto">PK value for McomCotizacionCompraProveedorDetalle which data should be fetched into this McomCotizacionCompraProveedorDetalle Object</param>
		''' <param name="validator">The validator Object for this McomCotizacionCompraProveedorDetalleEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(idCotizacion As System.Int32, idProveedor As System.Int32, idProducto As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(idCotizacion, idProveedor, idProducto, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()


			_producto = Nothing
			_productoReturnsNewIfNotFound = True
			_alwaysFetchProducto = False
			_alreadyFetchedProducto = False
			_solicitudProductoDetalle = Nothing
			_solicitudProductoDetalleReturnsNewIfNotFound = True
			_alwaysFetchSolicitudProductoDetalle = False
			_alreadyFetchedSolicitudProductoDetalle = False
			_proveedor = Nothing
			_proveedorReturnsNewIfNotFound = True
			_alwaysFetchProveedor = False
			_alreadyFetchedProveedor = False
			_tipoMoneda = Nothing
			_tipoMonedaReturnsNewIfNotFound = True
			_alwaysFetchTipoMoneda = False
			_alreadyFetchedTipoMoneda = False
			_cotizacionCompra = Nothing
			_cotizacionCompraReturnsNewIfNotFound = True
			_alwaysFetchCotizacionCompra = False
			_alreadyFetchedCotizacionCompra = False
			_mcomCotizacionCompraProveedor = Nothing
			_mcomCotizacionCompraProveedorReturnsNewIfNotFound = True
			_alwaysFetchMcomCotizacionCompraProveedor = False
			_alreadyFetchedMcomCotizacionCompraProveedor = False

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			' __LLBLGENPRO_USER_CODE_REGION_END
		End Sub

		''' <summary>Initializes the hashtables for the entity type and entity field custom properties. </summary>
		Private Shared Sub SetupCustomPropertyHashtables()
			_customProperties = New Dictionary(Of String, String)()
			_fieldsCustomProperties = New Dictionary(Of String, Dictionary(Of String, String))()

			Dim fieldHashtable As Dictionary(Of String, String) = Nothing
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdCotizacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdProveedor", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdProducto", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdSolicitud", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Cantidad", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdMoneda", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TipoCambio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Precio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Importe", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Descuento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SubTotal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Iva", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Total", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _producto</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncProducto(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _producto, AddressOf OnProductoPropertyChanged, "Producto", McomCotizacionCompraProveedorDetalleEntity.Relations.ProductoEntityUsingIdProducto, True, signalRelatedEntity, "McomCotizacionCompraProveedorDetalle", resetFKFields, New Integer() { CInt(McomCotizacionCompraProveedorDetalleFieldIndex.IdProducto) } )
			_producto = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _producto</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncProducto(relatedEntity As IEntity)
			DesetupSyncProducto(True, True)
			_producto = CType(relatedEntity, ProductoEntity)
			MyBase.PerformSetupSyncRelatedEntity( _producto, AddressOf OnProductoPropertyChanged, "Producto", McomCotizacionCompraProveedorDetalleEntity.Relations.ProductoEntityUsingIdProducto, True, _alreadyFetchedProducto, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnProductoPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _solicitudProductoDetalle</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncSolicitudProductoDetalle(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _solicitudProductoDetalle, AddressOf OnSolicitudProductoDetallePropertyChanged, "SolicitudProductoDetalle", McomCotizacionCompraProveedorDetalleEntity.Relations.SolicitudProductoDetalleEntityUsingIdSolicitudIdProducto, True, signalRelatedEntity, "McomCotizacionCompraProveedorDetalle", resetFKFields, New Integer() { CInt(McomCotizacionCompraProveedorDetalleFieldIndex.IdSolicitud), CInt(McomCotizacionCompraProveedorDetalleFieldIndex.IdProducto) } )
			_solicitudProductoDetalle = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _solicitudProductoDetalle</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncSolicitudProductoDetalle(relatedEntity As IEntity)
			DesetupSyncSolicitudProductoDetalle(True, True)
			_solicitudProductoDetalle = CType(relatedEntity, SolicitudProductoDetalleEntity)
			MyBase.PerformSetupSyncRelatedEntity( _solicitudProductoDetalle, AddressOf OnSolicitudProductoDetallePropertyChanged, "SolicitudProductoDetalle", McomCotizacionCompraProveedorDetalleEntity.Relations.SolicitudProductoDetalleEntityUsingIdSolicitudIdProducto, True, _alreadyFetchedSolicitudProductoDetalle, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnSolicitudProductoDetallePropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _proveedor</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncProveedor(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _proveedor, AddressOf OnProveedorPropertyChanged, "Proveedor", McomCotizacionCompraProveedorDetalleEntity.Relations.ProveedorEntityUsingIdProveedor, True, signalRelatedEntity, "McomCotizacionCompraProveedorDetalle", resetFKFields, New Integer() { CInt(McomCotizacionCompraProveedorDetalleFieldIndex.IdProveedor) } )
			_proveedor = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _proveedor</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncProveedor(relatedEntity As IEntity)
			DesetupSyncProveedor(True, True)
			_proveedor = CType(relatedEntity, ProveedorEntity)
			MyBase.PerformSetupSyncRelatedEntity( _proveedor, AddressOf OnProveedorPropertyChanged, "Proveedor", McomCotizacionCompraProveedorDetalleEntity.Relations.ProveedorEntityUsingIdProveedor, True, _alreadyFetchedProveedor, New String() {  } )
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
		''' <summary>Removes the sync logic for member _tipoMoneda</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncTipoMoneda(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _tipoMoneda, AddressOf OnTipoMonedaPropertyChanged, "TipoMoneda", McomCotizacionCompraProveedorDetalleEntity.Relations.TipoMonedaEntityUsingIdMoneda, True, signalRelatedEntity, "McomCotizacionCompraProveedorDetalle", resetFKFields, New Integer() { CInt(McomCotizacionCompraProveedorDetalleFieldIndex.IdMoneda) } )
			_tipoMoneda = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _tipoMoneda</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncTipoMoneda(relatedEntity As IEntity)
			DesetupSyncTipoMoneda(True, True)
			_tipoMoneda = CType(relatedEntity, TipoMonedaEntity)
			MyBase.PerformSetupSyncRelatedEntity( _tipoMoneda, AddressOf OnTipoMonedaPropertyChanged, "TipoMoneda", McomCotizacionCompraProveedorDetalleEntity.Relations.TipoMonedaEntityUsingIdMoneda, True, _alreadyFetchedTipoMoneda, New String() {  } )
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
		''' <summary>Removes the sync logic for member _cotizacionCompra</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncCotizacionCompra(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _cotizacionCompra, AddressOf OnCotizacionCompraPropertyChanged, "CotizacionCompra", McomCotizacionCompraProveedorDetalleEntity.Relations.McomCotizacionCompraEntityUsingIdCotizacion, True, signalRelatedEntity, "McomCotizacionCompraProveedorDetalle", resetFKFields, New Integer() { CInt(McomCotizacionCompraProveedorDetalleFieldIndex.IdCotizacion) } )
			_cotizacionCompra = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _cotizacionCompra</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncCotizacionCompra(relatedEntity As IEntity)
			DesetupSyncCotizacionCompra(True, True)
			_cotizacionCompra = CType(relatedEntity, McomCotizacionCompraEntity)
			MyBase.PerformSetupSyncRelatedEntity( _cotizacionCompra, AddressOf OnCotizacionCompraPropertyChanged, "CotizacionCompra", McomCotizacionCompraProveedorDetalleEntity.Relations.McomCotizacionCompraEntityUsingIdCotizacion, True, _alreadyFetchedCotizacionCompra, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnCotizacionCompraPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub
		''' <summary>Removes the sync logic for member _mcomCotizacionCompraProveedor</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncMcomCotizacionCompraProveedor(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _mcomCotizacionCompraProveedor, AddressOf OnMcomCotizacionCompraProveedorPropertyChanged, "McomCotizacionCompraProveedor", McomCotizacionCompraProveedorDetalleEntity.Relations.McomCotizacionCompraProveedorEntityUsingIdCotizacionIdProveedor, True, signalRelatedEntity, "McomCotizacionCompraProveedorDetalle", resetFKFields, New Integer() { CInt(McomCotizacionCompraProveedorDetalleFieldIndex.IdCotizacion), CInt(McomCotizacionCompraProveedorDetalleFieldIndex.IdProveedor) } )
			_mcomCotizacionCompraProveedor = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _mcomCotizacionCompraProveedor</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncMcomCotizacionCompraProveedor(relatedEntity As IEntity)
			DesetupSyncMcomCotizacionCompraProveedor(True, True)
			_mcomCotizacionCompraProveedor = CType(relatedEntity, McomCotizacionCompraProveedorEntity)
			MyBase.PerformSetupSyncRelatedEntity( _mcomCotizacionCompraProveedor, AddressOf OnMcomCotizacionCompraProveedorPropertyChanged, "McomCotizacionCompraProveedor", McomCotizacionCompraProveedorDetalleEntity.Relations.McomCotizacionCompraProveedorEntityUsingIdCotizacionIdProveedor, True, _alreadyFetchedMcomCotizacionCompraProveedor, New String() {  } )
		End Sub
		
		''' <summary>Handles Property change events of properties In a related entity.</summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub OnMcomCotizacionCompraProveedorPropertyChanged( sender As Object, e As PropertyChangedEventArgs)
			Select Case e.PropertyName

				Case Else
					' Emtpy
			End Select
		End Sub



		''' <summary>Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields Object. </summary>
		''' <param name="idCotizacion">PK value for McomCotizacionCompraProveedorDetalle which data should be fetched into this McomCotizacionCompraProveedorDetalle Object</param>
		''' <param name="idProveedor">PK value for McomCotizacionCompraProveedorDetalle which data should be fetched into this McomCotizacionCompraProveedorDetalle Object</param>
		''' <param name="idProducto">PK value for McomCotizacionCompraProveedorDetalle which data should be fetched into this McomCotizacionCompraProveedorDetalle Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(idCotizacion As System.Int32, idProveedor As System.Int32, idProducto As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(McomCotizacionCompraProveedorDetalleFieldIndex.IdCotizacion)).ForcedCurrentValueWrite(idCotizacion)
				MyBase.Fields(CInt(McomCotizacionCompraProveedorDetalleFieldIndex.IdProveedor)).ForcedCurrentValueWrite(idProveedor)
				MyBase.Fields(CInt(McomCotizacionCompraProveedorDetalleFieldIndex.IdProducto)).ForcedCurrentValueWrite(idProducto)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateMcomCotizacionCompraProveedorDetalleDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New McomCotizacionCompraProveedorDetalleEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As McomCotizacionCompraProveedorDetalleRelations
			Get	
				Return New McomCotizacionCompraProveedorDetalleRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProducto() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					McomCotizacionCompraProveedorDetalleEntity.Relations.ProductoEntityUsingIdProducto, _
					CType(Integralab.ORM.EntityType.McomCotizacionCompraProveedorDetalleEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, Nothing, "Producto", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SolicitudProductoDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSolicitudProductoDetalle() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SolicitudProductoDetalleCollection(), _
					McomCotizacionCompraProveedorDetalleEntity.Relations.SolicitudProductoDetalleEntityUsingIdSolicitudIdProducto, _
					CType(Integralab.ORM.EntityType.McomCotizacionCompraProveedorDetalleEntity, Integer), CType(Integralab.ORM.EntityType.SolicitudProductoDetalleEntity, Integer), 0, Nothing, Nothing, Nothing, "SolicitudProductoDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Proveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProveedor() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProveedorCollection(), _
					McomCotizacionCompraProveedorDetalleEntity.Relations.ProveedorEntityUsingIdProveedor, _
					CType(Integralab.ORM.EntityType.McomCotizacionCompraProveedorDetalleEntity, Integer), CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), 0, Nothing, Nothing, Nothing, "Proveedor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoMoneda' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoMoneda() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoMonedaCollection(), _
					McomCotizacionCompraProveedorDetalleEntity.Relations.TipoMonedaEntityUsingIdMoneda, _
					CType(Integralab.ORM.EntityType.McomCotizacionCompraProveedorDetalleEntity, Integer), CType(Integralab.ORM.EntityType.TipoMonedaEntity, Integer), 0, Nothing, Nothing, Nothing, "TipoMoneda", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McomCotizacionCompra' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCotizacionCompra() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection(), _
					McomCotizacionCompraProveedorDetalleEntity.Relations.McomCotizacionCompraEntityUsingIdCotizacion, _
					CType(Integralab.ORM.EntityType.McomCotizacionCompraProveedorDetalleEntity, Integer), CType(Integralab.ORM.EntityType.McomCotizacionCompraEntity, Integer), 0, Nothing, Nothing, Nothing, "CotizacionCompra", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McomCotizacionCompraProveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMcomCotizacionCompraProveedor() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McomCotizacionCompraProveedorCollection(), _
					McomCotizacionCompraProveedorDetalleEntity.Relations.McomCotizacionCompraProveedorEntityUsingIdCotizacionIdProveedor, _
					CType(Integralab.ORM.EntityType.McomCotizacionCompraProveedorDetalleEntity, Integer), CType(Integralab.ORM.EntityType.McomCotizacionCompraProveedorEntity, Integer), 0, Nothing, Nothing, Nothing, "McomCotizacionCompraProveedor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "McomCotizacionCompraProveedorDetalleEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return McomCotizacionCompraProveedorDetalleEntity.CustomProperties
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
				Return McomCotizacionCompraProveedorDetalleEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The IdCotizacion property of the Entity McomCotizacionCompraProveedorDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComCotizacionCompraProveedorDetalle"."IdCotizacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [IdCotizacion]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McomCotizacionCompraProveedorDetalleFieldIndex.IdCotizacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(McomCotizacionCompraProveedorDetalleFieldIndex.IdCotizacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdProveedor property of the Entity McomCotizacionCompraProveedorDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComCotizacionCompraProveedorDetalle"."IdProveedor"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [IdProveedor]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McomCotizacionCompraProveedorDetalleFieldIndex.IdProveedor, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(McomCotizacionCompraProveedorDetalleFieldIndex.IdProveedor, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdProducto property of the Entity McomCotizacionCompraProveedorDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComCotizacionCompraProveedorDetalle"."IdProducto"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, False
		''' </remarks>
		Public Overridable Property [IdProducto]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McomCotizacionCompraProveedorDetalleFieldIndex.IdProducto, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(McomCotizacionCompraProveedorDetalleFieldIndex.IdProducto, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdSolicitud property of the Entity McomCotizacionCompraProveedorDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComCotizacionCompraProveedorDetalle"."IdSolicitud"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdSolicitud]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McomCotizacionCompraProveedorDetalleFieldIndex.IdSolicitud, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(McomCotizacionCompraProveedorDetalleFieldIndex.IdSolicitud, Integer), value)
			End Set
		End Property
	
		''' <summary>The Cantidad property of the Entity McomCotizacionCompraProveedorDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComCotizacionCompraProveedorDetalle"."Cantidad"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Cantidad]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McomCotizacionCompraProveedorDetalleFieldIndex.Cantidad, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McomCotizacionCompraProveedorDetalleFieldIndex.Cantidad, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdMoneda property of the Entity McomCotizacionCompraProveedorDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComCotizacionCompraProveedorDetalle"."IdMoneda"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdMoneda]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McomCotizacionCompraProveedorDetalleFieldIndex.IdMoneda, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(McomCotizacionCompraProveedorDetalleFieldIndex.IdMoneda, Integer), value)
			End Set
		End Property
	
		''' <summary>The TipoCambio property of the Entity McomCotizacionCompraProveedorDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComCotizacionCompraProveedorDetalle"."TipoCambio"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TipoCambio]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McomCotizacionCompraProveedorDetalleFieldIndex.TipoCambio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McomCotizacionCompraProveedorDetalleFieldIndex.TipoCambio, Integer), value)
			End Set
		End Property
	
		''' <summary>The Precio property of the Entity McomCotizacionCompraProveedorDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComCotizacionCompraProveedorDetalle"."Precio"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Precio]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McomCotizacionCompraProveedorDetalleFieldIndex.Precio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McomCotizacionCompraProveedorDetalleFieldIndex.Precio, Integer), value)
			End Set
		End Property
	
		''' <summary>The Importe property of the Entity McomCotizacionCompraProveedorDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComCotizacionCompraProveedorDetalle"."Importe"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Importe]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McomCotizacionCompraProveedorDetalleFieldIndex.Importe, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McomCotizacionCompraProveedorDetalleFieldIndex.Importe, Integer), value)
			End Set
		End Property
	
		''' <summary>The Descuento property of the Entity McomCotizacionCompraProveedorDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComCotizacionCompraProveedorDetalle"."Descuento"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Descuento]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McomCotizacionCompraProveedorDetalleFieldIndex.Descuento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McomCotizacionCompraProveedorDetalleFieldIndex.Descuento, Integer), value)
			End Set
		End Property
	
		''' <summary>The SubTotal property of the Entity McomCotizacionCompraProveedorDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComCotizacionCompraProveedorDetalle"."SubTotal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SubTotal]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McomCotizacionCompraProveedorDetalleFieldIndex.SubTotal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McomCotizacionCompraProveedorDetalleFieldIndex.SubTotal, Integer), value)
			End Set
		End Property
	
		''' <summary>The Iva property of the Entity McomCotizacionCompraProveedorDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComCotizacionCompraProveedorDetalle"."Iva"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Iva]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McomCotizacionCompraProveedorDetalleFieldIndex.Iva, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McomCotizacionCompraProveedorDetalleFieldIndex.Iva, Integer), value)
			End Set
		End Property
	
		''' <summary>The Total property of the Entity McomCotizacionCompraProveedorDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComCotizacionCompraProveedorDetalle"."Total"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Total]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McomCotizacionCompraProveedorDetalleFieldIndex.Total, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(McomCotizacionCompraProveedorDetalleFieldIndex.Total, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity McomCotizacionCompraProveedorDetalle<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComCotizacionCompraProveedorDetalle"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Byte
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(McomCotizacionCompraProveedorDetalleFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Byte))
				End If
				Return CType(valueToReturn, System.Byte)
			End Get
			Set
				SetNewFieldValue(CType(McomCotizacionCompraProveedorDetalleFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
	
	
	
		''' <summary>Gets / sets related entity of type 'ProductoEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleProducto()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [Producto]() As ProductoEntity
			Get
				Return GetSingleProducto(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncProducto(value)
				Else
					If value Is Nothing Then
						If Not _producto Is Nothing Then
							_producto.UnsetRelatedEntity(Me, "McomCotizacionCompraProveedorDetalle")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "McomCotizacionCompraProveedorDetalle")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for Producto. When set to true, Producto is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time Producto is accessed. You can always execute
		''' a forced fetch by calling GetSingleProducto(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProducto As Boolean
			Get
				Return _alwaysFetchProducto
			End Get
			Set
				_alwaysFetchProducto = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property Producto is not found
		''' in the database. When set to true, Producto will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property ProductoReturnsNewIfNotFound As Boolean
			Get
				Return _productoReturnsNewIfNotFound
			End Get
			Set
				_productoReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'SolicitudProductoDetalleEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleSolicitudProductoDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [SolicitudProductoDetalle]() As SolicitudProductoDetalleEntity
			Get
				Return GetSingleSolicitudProductoDetalle(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncSolicitudProductoDetalle(value)
				Else
					If value Is Nothing Then
						If Not _solicitudProductoDetalle Is Nothing Then
							_solicitudProductoDetalle.UnsetRelatedEntity(Me, "McomCotizacionCompraProveedorDetalle")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "McomCotizacionCompraProveedorDetalle")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for SolicitudProductoDetalle. When set to true, SolicitudProductoDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time SolicitudProductoDetalle is accessed. You can always execute
		''' a forced fetch by calling GetSingleSolicitudProductoDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchSolicitudProductoDetalle As Boolean
			Get
				Return _alwaysFetchSolicitudProductoDetalle
			End Get
			Set
				_alwaysFetchSolicitudProductoDetalle = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property SolicitudProductoDetalle is not found
		''' in the database. When set to true, SolicitudProductoDetalle will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property SolicitudProductoDetalleReturnsNewIfNotFound As Boolean
			Get
				Return _solicitudProductoDetalleReturnsNewIfNotFound
			End Get
			Set
				_solicitudProductoDetalleReturnsNewIfNotFound = value
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
							_proveedor.UnsetRelatedEntity(Me, "McomCotizacionCompraProveedorDetalle")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "McomCotizacionCompraProveedorDetalle")
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
							_tipoMoneda.UnsetRelatedEntity(Me, "McomCotizacionCompraProveedorDetalle")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "McomCotizacionCompraProveedorDetalle")
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
	
		''' <summary>Gets / sets related entity of type 'McomCotizacionCompraEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCotizacionCompra()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [CotizacionCompra]() As McomCotizacionCompraEntity
			Get
				Return GetSingleCotizacionCompra(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncCotizacionCompra(value)
				Else
					If value Is Nothing Then
						If Not _cotizacionCompra Is Nothing Then
							_cotizacionCompra.UnsetRelatedEntity(Me, "McomCotizacionCompraProveedorDetalle")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "McomCotizacionCompraProveedorDetalle")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for CotizacionCompra. When set to true, CotizacionCompra is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CotizacionCompra is accessed. You can always execute
		''' a forced fetch by calling GetSingleCotizacionCompra(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCotizacionCompra As Boolean
			Get
				Return _alwaysFetchCotizacionCompra
			End Get
			Set
				_alwaysFetchCotizacionCompra = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property CotizacionCompra is not found
		''' in the database. When set to true, CotizacionCompra will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property CotizacionCompraReturnsNewIfNotFound As Boolean
			Get
				Return _cotizacionCompraReturnsNewIfNotFound
			End Get
			Set
				_cotizacionCompraReturnsNewIfNotFound = value
			End Set	
		End Property
	
		''' <summary>Gets / sets related entity of type 'McomCotizacionCompraProveedorEntity'. This property is not visible in databound grids.
		''' Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		''' property to Nothing. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		''' <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleMcomCotizacionCompraProveedor()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		<Browsable(False)> _
		Public Overridable Property [McomCotizacionCompraProveedor]() As McomCotizacionCompraProveedorEntity
			Get
				Return GetSingleMcomCotizacionCompraProveedor(False)
			End Get
			Set
				If MyBase.IsDeserializing Then
					SetupSyncMcomCotizacionCompraProveedor(value)
				Else
					If value Is Nothing Then
						If Not _mcomCotizacionCompraProveedor Is Nothing Then
							_mcomCotizacionCompraProveedor.UnsetRelatedEntity(Me, "McomCotizacionCompraProveedorDetalle")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "McomCotizacionCompraProveedorDetalle")
					End If
				End If
			End Set
		End Property

		''' <summary>Gets / sets the lazy loading flag for McomCotizacionCompraProveedor. When set to true, McomCotizacionCompraProveedor is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time McomCotizacionCompraProveedor is accessed. You can always execute
		''' a forced fetch by calling GetSingleMcomCotizacionCompraProveedor(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMcomCotizacionCompraProveedor As Boolean
			Get
				Return _alwaysFetchMcomCotizacionCompraProveedor
			End Get
			Set
				_alwaysFetchMcomCotizacionCompraProveedor = value
			End Set	
		End Property

		''' <summary>Gets / sets the flag for what to do if the related entity available through the property McomCotizacionCompraProveedor is not found
		''' in the database. When set to true, McomCotizacionCompraProveedor will return a new entity instance if the related entity is not found, otherwise 
		''' null be returned if the related entity is not found. Default: true.</summary>
		<Browsable(False)> _
		Public Property McomCotizacionCompraProveedorReturnsNewIfNotFound As Boolean
			Get
				Return _mcomCotizacionCompraProveedorReturnsNewIfNotFound
			End Get
			Set
				_mcomCotizacionCompraProveedorReturnsNewIfNotFound = value
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
				Return CInt(Integralab.ORM.EntityType.McomCotizacionCompraProveedorDetalleEntity)
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
