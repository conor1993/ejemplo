' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // This is generated code. 
' ////////////////////////////////////////////////////////////////////////////////////////////////////////
' // Code is generated using LLBLGen Pro version: 2.0.0.0
' // Code is generated on: lunes, 23 de abril de 2018 15:21:56
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
	''' <summary>Entity class which represents the entity 'OrdenCompra'<br/><br/>
	''' </summary>
#If CF Then
	<SD.LLBLGen.Pro.ORMSupportClasses.Serializable()> _
	Public Class OrdenCompraEntity 
#Else
	<Serializable()> _
	Public Class OrdenCompraEntity 
#End If
		Inherits EntityBase

		' __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		' __LLBLGENPRO_USER_CODE_REGION_END	

#Region "Class Member Declarations"
		Private _ordenCompraDetalle As Integralab.ORM.CollectionClasses.OrdenCompraDetalleCollection
		Private _alwaysFetchOrdenCompraDetalle, _alreadyFetchedOrdenCompraDetalle As Boolean
		Private _recepcionOrdenCompra As Integralab.ORM.CollectionClasses.RecepcionOrdenCompraCollection
		Private _alwaysFetchRecepcionOrdenCompra, _alreadyFetchedRecepcionOrdenCompra As Boolean
		Private _productoCollectionViaOrdenCompraDetalle As Integralab.ORM.CollectionClasses.ProductoCollection
		Private _alwaysFetchProductoCollectionViaOrdenCompraDetalle, _alreadyFetchedProductoCollectionViaOrdenCompraDetalle As Boolean
		Private _tipoMonedaCollectionViaOrdenCompraDetalle As Integralab.ORM.CollectionClasses.TipoMonedaCollection
		Private _alwaysFetchTipoMonedaCollectionViaOrdenCompraDetalle, _alreadyFetchedTipoMonedaCollectionViaOrdenCompraDetalle As Boolean
		Private _cotizacionCompraCollectionViaOrdenCompraDetalle As Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection
		Private _alwaysFetchCotizacionCompraCollectionViaOrdenCompraDetalle, _alreadyFetchedCotizacionCompraCollectionViaOrdenCompraDetalle As Boolean
		Private _solicitudProductoCollectionViaOrdenCompraDetalle As Integralab.ORM.CollectionClasses.SolicitudProductoCollection
		Private _alwaysFetchSolicitudProductoCollectionViaOrdenCompraDetalle, _alreadyFetchedSolicitudProductoCollectionViaOrdenCompraDetalle As Boolean
		Private _almacenCollectionViaRecepcionOrdenCompra As Integralab.ORM.CollectionClasses.AlmacenCollection
		Private _alwaysFetchAlmacenCollectionViaRecepcionOrdenCompra, _alreadyFetchedAlmacenCollectionViaRecepcionOrdenCompra As Boolean
		Private _motivoCancelacionCollectionViaRecepcionOrdenCompra As Integralab.ORM.CollectionClasses.MotivoCancelacionCollection
		Private _alwaysFetchMotivoCancelacionCollectionViaRecepcionOrdenCompra, _alreadyFetchedMotivoCancelacionCollectionViaRecepcionOrdenCompra As Boolean
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
		''' <param name="idOrdenCompra">PK value for OrdenCompra which data should be fetched into this OrdenCompra Object</param>
		Public Sub New(idOrdenCompra As System.Int32)

			InitClassFetch(idOrdenCompra, CreateValidator(), Nothing)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idOrdenCompra">PK value for OrdenCompra which data should be fetched into this OrdenCompra Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Public Sub New(idOrdenCompra As System.Int32, prefetchPathToUse As IPrefetchPath)

			InitClassFetch(idOrdenCompra, CreateValidator(), prefetchPathToUse)
		End Sub

		''' <summary>CTor</summary>
		''' <param name="idOrdenCompra">PK value for OrdenCompra which data should be fetched into this OrdenCompra Object</param>
		''' <param name="validator">The custom validator Object for this OrdenCompraEntity</param>
		Public Sub New(idOrdenCompra As System.Int32, validator As IValidator)

			InitClassFetch(idOrdenCompra, validator, Nothing)
		End Sub


		''' <summary>Private CTor for deserialization</summary>
		''' <param name="info"></param>
		''' <param name="context"></param>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context)
			_ordenCompraDetalle = CType(info.GetValue("_ordenCompraDetalle", GetType(Integralab.ORM.CollectionClasses.OrdenCompraDetalleCollection)), Integralab.ORM.CollectionClasses.OrdenCompraDetalleCollection)
			_alwaysFetchOrdenCompraDetalle = info.GetBoolean("_alwaysFetchOrdenCompraDetalle")
			_alreadyFetchedOrdenCompraDetalle = info.GetBoolean("_alreadyFetchedOrdenCompraDetalle")
			_recepcionOrdenCompra = CType(info.GetValue("_recepcionOrdenCompra", GetType(Integralab.ORM.CollectionClasses.RecepcionOrdenCompraCollection)), Integralab.ORM.CollectionClasses.RecepcionOrdenCompraCollection)
			_alwaysFetchRecepcionOrdenCompra = info.GetBoolean("_alwaysFetchRecepcionOrdenCompra")
			_alreadyFetchedRecepcionOrdenCompra = info.GetBoolean("_alreadyFetchedRecepcionOrdenCompra")
			_productoCollectionViaOrdenCompraDetalle = CType(info.GetValue("_productoCollectionViaOrdenCompraDetalle", GetType(Integralab.ORM.CollectionClasses.ProductoCollection)), Integralab.ORM.CollectionClasses.ProductoCollection)
			_alwaysFetchProductoCollectionViaOrdenCompraDetalle = info.GetBoolean("_alwaysFetchProductoCollectionViaOrdenCompraDetalle")
			_alreadyFetchedProductoCollectionViaOrdenCompraDetalle = info.GetBoolean("_alreadyFetchedProductoCollectionViaOrdenCompraDetalle")
			_tipoMonedaCollectionViaOrdenCompraDetalle = CType(info.GetValue("_tipoMonedaCollectionViaOrdenCompraDetalle", GetType(Integralab.ORM.CollectionClasses.TipoMonedaCollection)), Integralab.ORM.CollectionClasses.TipoMonedaCollection)
			_alwaysFetchTipoMonedaCollectionViaOrdenCompraDetalle = info.GetBoolean("_alwaysFetchTipoMonedaCollectionViaOrdenCompraDetalle")
			_alreadyFetchedTipoMonedaCollectionViaOrdenCompraDetalle = info.GetBoolean("_alreadyFetchedTipoMonedaCollectionViaOrdenCompraDetalle")
			_cotizacionCompraCollectionViaOrdenCompraDetalle = CType(info.GetValue("_cotizacionCompraCollectionViaOrdenCompraDetalle", GetType(Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection)), Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection)
			_alwaysFetchCotizacionCompraCollectionViaOrdenCompraDetalle = info.GetBoolean("_alwaysFetchCotizacionCompraCollectionViaOrdenCompraDetalle")
			_alreadyFetchedCotizacionCompraCollectionViaOrdenCompraDetalle = info.GetBoolean("_alreadyFetchedCotizacionCompraCollectionViaOrdenCompraDetalle")
			_solicitudProductoCollectionViaOrdenCompraDetalle = CType(info.GetValue("_solicitudProductoCollectionViaOrdenCompraDetalle", GetType(Integralab.ORM.CollectionClasses.SolicitudProductoCollection)), Integralab.ORM.CollectionClasses.SolicitudProductoCollection)
			_alwaysFetchSolicitudProductoCollectionViaOrdenCompraDetalle = info.GetBoolean("_alwaysFetchSolicitudProductoCollectionViaOrdenCompraDetalle")
			_alreadyFetchedSolicitudProductoCollectionViaOrdenCompraDetalle = info.GetBoolean("_alreadyFetchedSolicitudProductoCollectionViaOrdenCompraDetalle")
			_almacenCollectionViaRecepcionOrdenCompra = CType(info.GetValue("_almacenCollectionViaRecepcionOrdenCompra", GetType(Integralab.ORM.CollectionClasses.AlmacenCollection)), Integralab.ORM.CollectionClasses.AlmacenCollection)
			_alwaysFetchAlmacenCollectionViaRecepcionOrdenCompra = info.GetBoolean("_alwaysFetchAlmacenCollectionViaRecepcionOrdenCompra")
			_alreadyFetchedAlmacenCollectionViaRecepcionOrdenCompra = info.GetBoolean("_alreadyFetchedAlmacenCollectionViaRecepcionOrdenCompra")
			_motivoCancelacionCollectionViaRecepcionOrdenCompra = CType(info.GetValue("_motivoCancelacionCollectionViaRecepcionOrdenCompra", GetType(Integralab.ORM.CollectionClasses.MotivoCancelacionCollection)), Integralab.ORM.CollectionClasses.MotivoCancelacionCollection)
			_alwaysFetchMotivoCancelacionCollectionViaRecepcionOrdenCompra = info.GetBoolean("_alwaysFetchMotivoCancelacionCollectionViaRecepcionOrdenCompra")
			_alreadyFetchedMotivoCancelacionCollectionViaRecepcionOrdenCompra = info.GetBoolean("_alreadyFetchedMotivoCancelacionCollectionViaRecepcionOrdenCompra")
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
			_alreadyFetchedOrdenCompraDetalle = (_ordenCompraDetalle.Count > 0)
			_alreadyFetchedRecepcionOrdenCompra = (_recepcionOrdenCompra.Count > 0)
			_alreadyFetchedProductoCollectionViaOrdenCompraDetalle = (_productoCollectionViaOrdenCompraDetalle.Count > 0)
			_alreadyFetchedTipoMonedaCollectionViaOrdenCompraDetalle = (_tipoMonedaCollectionViaOrdenCompraDetalle.Count > 0)
			_alreadyFetchedCotizacionCompraCollectionViaOrdenCompraDetalle = (_cotizacionCompraCollectionViaOrdenCompraDetalle.Count > 0)
			_alreadyFetchedSolicitudProductoCollectionViaOrdenCompraDetalle = (_solicitudProductoCollectionViaOrdenCompraDetalle.Count > 0)
			_alreadyFetchedAlmacenCollectionViaRecepcionOrdenCompra = (_almacenCollectionViaRecepcionOrdenCompra.Count > 0)
			_alreadyFetchedMotivoCancelacionCollectionViaRecepcionOrdenCompra = (_motivoCancelacionCollectionViaRecepcionOrdenCompra.Count > 0)
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
			info.AddValue("_ordenCompraDetalle", _ordenCompraDetalle)
			info.AddValue("_alwaysFetchOrdenCompraDetalle", _alwaysFetchOrdenCompraDetalle)
			info.AddValue("_alreadyFetchedOrdenCompraDetalle", _alreadyFetchedOrdenCompraDetalle)
			info.AddValue("_recepcionOrdenCompra", _recepcionOrdenCompra)
			info.AddValue("_alwaysFetchRecepcionOrdenCompra", _alwaysFetchRecepcionOrdenCompra)
			info.AddValue("_alreadyFetchedRecepcionOrdenCompra", _alreadyFetchedRecepcionOrdenCompra)
			info.AddValue("_productoCollectionViaOrdenCompraDetalle", _productoCollectionViaOrdenCompraDetalle)
			info.AddValue("_alwaysFetchProductoCollectionViaOrdenCompraDetalle", _alwaysFetchProductoCollectionViaOrdenCompraDetalle)
			info.AddValue("_alreadyFetchedProductoCollectionViaOrdenCompraDetalle", _alreadyFetchedProductoCollectionViaOrdenCompraDetalle)
			info.AddValue("_tipoMonedaCollectionViaOrdenCompraDetalle", _tipoMonedaCollectionViaOrdenCompraDetalle)
			info.AddValue("_alwaysFetchTipoMonedaCollectionViaOrdenCompraDetalle", _alwaysFetchTipoMonedaCollectionViaOrdenCompraDetalle)
			info.AddValue("_alreadyFetchedTipoMonedaCollectionViaOrdenCompraDetalle", _alreadyFetchedTipoMonedaCollectionViaOrdenCompraDetalle)
			info.AddValue("_cotizacionCompraCollectionViaOrdenCompraDetalle", _cotizacionCompraCollectionViaOrdenCompraDetalle)
			info.AddValue("_alwaysFetchCotizacionCompraCollectionViaOrdenCompraDetalle", _alwaysFetchCotizacionCompraCollectionViaOrdenCompraDetalle)
			info.AddValue("_alreadyFetchedCotizacionCompraCollectionViaOrdenCompraDetalle", _alreadyFetchedCotizacionCompraCollectionViaOrdenCompraDetalle)
			info.AddValue("_solicitudProductoCollectionViaOrdenCompraDetalle", _solicitudProductoCollectionViaOrdenCompraDetalle)
			info.AddValue("_alwaysFetchSolicitudProductoCollectionViaOrdenCompraDetalle", _alwaysFetchSolicitudProductoCollectionViaOrdenCompraDetalle)
			info.AddValue("_alreadyFetchedSolicitudProductoCollectionViaOrdenCompraDetalle", _alreadyFetchedSolicitudProductoCollectionViaOrdenCompraDetalle)
			info.AddValue("_almacenCollectionViaRecepcionOrdenCompra", _almacenCollectionViaRecepcionOrdenCompra)
			info.AddValue("_alwaysFetchAlmacenCollectionViaRecepcionOrdenCompra", _alwaysFetchAlmacenCollectionViaRecepcionOrdenCompra)
			info.AddValue("_alreadyFetchedAlmacenCollectionViaRecepcionOrdenCompra", _alreadyFetchedAlmacenCollectionViaRecepcionOrdenCompra)
			info.AddValue("_motivoCancelacionCollectionViaRecepcionOrdenCompra", _motivoCancelacionCollectionViaRecepcionOrdenCompra)
			info.AddValue("_alwaysFetchMotivoCancelacionCollectionViaRecepcionOrdenCompra", _alwaysFetchMotivoCancelacionCollectionViaRecepcionOrdenCompra)
			info.AddValue("_alreadyFetchedMotivoCancelacionCollectionViaRecepcionOrdenCompra", _alreadyFetchedMotivoCancelacionCollectionViaRecepcionOrdenCompra)
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
				Case "OrdenCompraDetalle"
					_alreadyFetchedOrdenCompraDetalle = True
					If Not entity Is Nothing Then
						Me.OrdenCompraDetalle.Add(CType(entity, OrdenCompraDetalleEntity))
					End If
				Case "RecepcionOrdenCompra"
					_alreadyFetchedRecepcionOrdenCompra = True
					If Not entity Is Nothing Then
						Me.RecepcionOrdenCompra.Add(CType(entity, RecepcionOrdenCompraEntity))
					End If
				Case "ProductoCollectionViaOrdenCompraDetalle"
					_alreadyFetchedProductoCollectionViaOrdenCompraDetalle = True
					If Not entity Is Nothing Then
						Me.ProductoCollectionViaOrdenCompraDetalle.Add(CType(entity, ProductoEntity))
					End If
				Case "TipoMonedaCollectionViaOrdenCompraDetalle"
					_alreadyFetchedTipoMonedaCollectionViaOrdenCompraDetalle = True
					If Not entity Is Nothing Then
						Me.TipoMonedaCollectionViaOrdenCompraDetalle.Add(CType(entity, TipoMonedaEntity))
					End If
				Case "CotizacionCompraCollectionViaOrdenCompraDetalle"
					_alreadyFetchedCotizacionCompraCollectionViaOrdenCompraDetalle = True
					If Not entity Is Nothing Then
						Me.CotizacionCompraCollectionViaOrdenCompraDetalle.Add(CType(entity, McomCotizacionCompraEntity))
					End If
				Case "SolicitudProductoCollectionViaOrdenCompraDetalle"
					_alreadyFetchedSolicitudProductoCollectionViaOrdenCompraDetalle = True
					If Not entity Is Nothing Then
						Me.SolicitudProductoCollectionViaOrdenCompraDetalle.Add(CType(entity, SolicitudProductoEntity))
					End If
				Case "AlmacenCollectionViaRecepcionOrdenCompra"
					_alreadyFetchedAlmacenCollectionViaRecepcionOrdenCompra = True
					If Not entity Is Nothing Then
						Me.AlmacenCollectionViaRecepcionOrdenCompra.Add(CType(entity, AlmacenEntity))
					End If
				Case "MotivoCancelacionCollectionViaRecepcionOrdenCompra"
					_alreadyFetchedMotivoCancelacionCollectionViaRecepcionOrdenCompra = True
					If Not entity Is Nothing Then
						Me.MotivoCancelacionCollectionViaRecepcionOrdenCompra.Add(CType(entity, MotivoCancelacionEntity))
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
				Case "OrdenCompraDetalle"
					_ordenCompraDetalle.Add(CType(relatedEntity, OrdenCompraDetalleEntity))
					OnRelatedEntitySet(relatedEntity, fieldName)
				Case "RecepcionOrdenCompra"
					_recepcionOrdenCompra.Add(CType(relatedEntity, RecepcionOrdenCompraEntity))
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
				Case "OrdenCompraDetalle"
					MyBase.PerformRelatedEntityRemoval(_ordenCompraDetalle, relatedEntity, signalRelatedEntityManyToOne)
					OnRelatedEntityUnset(relatedEntity, fieldName)
				Case "RecepcionOrdenCompra"
					MyBase.PerformRelatedEntityRemoval(_recepcionOrdenCompra, relatedEntity, signalRelatedEntityManyToOne)
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
			toReturn.Add(_ordenCompraDetalle)
			toReturn.Add(_recepcionOrdenCompra)

			Return toReturn
		End Function


		
	

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idOrdenCompra">PK value for OrdenCompra which data should be fetched into this OrdenCompra Object</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idOrdenCompra As System.Int32) As Boolean
			Return FetchUsingPK(idOrdenCompra, Nothing, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idOrdenCompra">PK value for OrdenCompra which data should be fetched into this OrdenCompra Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idOrdenCompra As System.Int32, prefetchPathToUse As IPrefetchPath) As Boolean
			Return FetchUsingPK(idOrdenCompra, prefetchPathToUse, Nothing)
		End Function

		''' <summary>Fetches the contents of this entity from the persistent storage Imports the primary key.</summary>
		''' <param name="idOrdenCompra">PK value for OrdenCompra which data should be fetched into this OrdenCompra Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Public Function FetchUsingPK(idOrdenCompra As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Return Fetch(idOrdenCompra, prefetchPathToUse, contextToUse)
		End Function

		''' <summary>Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		''' <returns>true if Refetch succeeded, False otherwise</returns>
		''' <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		''' inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework implemented.</exception>
		Public Overrides Overloads Function Refetch() As Boolean
			Return Fetch(Me.IdOrdenCompra, Nothing, Nothing)
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
		Public  Function TestOriginalFieldValueForNull(fieldIndex As OrdenCompraFieldIndex) As Boolean
			Return MyBase.Fields(CInt(fieldIndex)).IsNull
		End Function
		
		''' <summary>Returns True If the current value For the field With the fieldIndex passed In represents null/Not defined, False otherwise.
		''' Should Not be used For testing If the original value (read from the db) Is NULL</summary>
		''' <param name="fieldIndex">Index of the field To test If its currentvalue Is null/undefined</param>
		''' <returns>True If the field's value isn't defined yet, false otherwise</returns>
		Public  Function TestCurrentFieldValueForNull(fieldIndex As OrdenCompraFieldIndex) As Boolean
			Return MyBase.CheckIfCurrentFieldValueIsNull(CInt(fieldIndex))
		End Function



		''' <summary>Retrieves all related entities of type 'OrdenCompraDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'OrdenCompraDetalleEntity'</returns>
		Public Function GetMultiOrdenCompraDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.OrdenCompraDetalleCollection
			Return GetMultiOrdenCompraDetalle(forceFetch, _ordenCompraDetalle.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'OrdenCompraDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiOrdenCompraDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.OrdenCompraDetalleCollection
			Return GetMultiOrdenCompraDetalle(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'OrdenCompraDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'OrdenCompraDetalleEntity'</returns>
		Public Function GetMultiOrdenCompraDetalle(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.OrdenCompraDetalleCollection
			Return GetMultiOrdenCompraDetalle(forceFetch, _ordenCompraDetalle.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'OrdenCompraDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiOrdenCompraDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.OrdenCompraDetalleCollection
			If ( Not _alreadyFetchedOrdenCompraDetalle Or forceFetch Or _alwaysFetchOrdenCompraDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _ordenCompraDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_ordenCompraDetalle)
					End If
				End If
				_ordenCompraDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_ordenCompraDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_ordenCompraDetalle.GetMultiManyToOne(Nothing, Nothing, Nothing, Me, Nothing, Filter)
				_ordenCompraDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedOrdenCompraDetalle = True
			End If
			Return _ordenCompraDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'OrdenCompraDetalle'. These settings will be taken into account
		''' when the property OrdenCompraDetalle is requested or GetMultiOrdenCompraDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersOrdenCompraDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_ordenCompraDetalle.SortClauses=sortClauses
			_ordenCompraDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
		''' <summary>Retrieves all related entities of type 'RecepcionOrdenCompraEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'RecepcionOrdenCompraEntity'</returns>
		Public Function GetMultiRecepcionOrdenCompra(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.RecepcionOrdenCompraCollection
			Return GetMultiRecepcionOrdenCompra(forceFetch, _recepcionOrdenCompra.EntityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'RecepcionOrdenCompraEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Function GetMultiRecepcionOrdenCompra(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.RecepcionOrdenCompraCollection
			Return GetMultiRecepcionOrdenCompra(forceFetch, entityFactoryToUse, Nothing)
		End Function

		''' <summary>Retrieves all related entities of type 'RecepcionOrdenCompraEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of type 'RecepcionOrdenCompraEntity'</returns>
		Public Function GetMultiRecepcionOrdenCompra(forceFetch As Boolean, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.RecepcionOrdenCompraCollection
			Return GetMultiRecepcionOrdenCompra(forceFetch, _recepcionOrdenCompra.EntityFactoryToUse, Filter)
		End Function

		''' <summary>Retrieves all related entities of type 'RecepcionOrdenCompraEntity' Imports a relation of type '1:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		''' <param name="filter">Extra filter to limit the resultset.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiRecepcionOrdenCompra(forceFetch As Boolean, entityFactoryToUse As IEntityFactory, Filter As IPredicateExpression) As Integralab.ORM.CollectionClasses.RecepcionOrdenCompraCollection
			If ( Not _alreadyFetchedRecepcionOrdenCompra Or forceFetch Or _alwaysFetchRecepcionOrdenCompra) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _recepcionOrdenCompra.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_recepcionOrdenCompra)
					End If
				End If
				_recepcionOrdenCompra.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_recepcionOrdenCompra.EntityFactoryToUse = entityFactoryToUse
				End If
				_recepcionOrdenCompra.GetMultiManyToOne(Nothing, Nothing, Nothing, Me, Filter)
				_recepcionOrdenCompra.SuppressClearInGetMulti = False
				_alreadyFetchedRecepcionOrdenCompra = True
			End If
			Return _recepcionOrdenCompra
		End Function

		''' <summary>Sets the collection parameters for the collection for 'RecepcionOrdenCompra'. These settings will be taken into account
		''' when the property RecepcionOrdenCompra is requested or GetMultiRecepcionOrdenCompra is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersRecepcionOrdenCompra(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_recepcionOrdenCompra.SortClauses=sortClauses
			_recepcionOrdenCompra.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub
	
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'ProductoEntity'</returns>
		Public Function GetMultiProductoCollectionViaOrdenCompraDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.ProductoCollection
			Return GetMultiProductoCollectionViaOrdenCompraDetalle(forceFetch, _productoCollectionViaOrdenCompraDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiProductoCollectionViaOrdenCompraDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.ProductoCollection
			If ( Not _alreadyFetchedProductoCollectionViaOrdenCompraDetalle Or forceFetch Or _alwaysFetchProductoCollectionViaOrdenCompraDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _productoCollectionViaOrdenCompraDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_productoCollectionViaOrdenCompraDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(OrdenCompraEntity.Relations.OrdenCompraDetalleEntityUsingIdOrdenCompra, "__OrdenCompraEntity__", "OrdenCompraDetalle_", JoinHint.None)
				relations.Add(OrdenCompraDetalleEntity.Relations.ProductoEntityUsingIdProducto, "OrdenCompraDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(OrdenCompraFieldIndex.IdOrdenCompra), ComparisonOperator.Equal, Me.IdOrdenCompra))
				_productoCollectionViaOrdenCompraDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_productoCollectionViaOrdenCompraDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_productoCollectionViaOrdenCompraDetalle.GetMulti(Filter, relations)
				_productoCollectionViaOrdenCompraDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedProductoCollectionViaOrdenCompraDetalle = True
			End If
			Return _productoCollectionViaOrdenCompraDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'ProductoCollectionViaOrdenCompraDetalle'. These settings will be taken into account
		''' when the property ProductoCollectionViaOrdenCompraDetalle is requested or GetMultiProductoCollectionViaOrdenCompraDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersProductoCollectionViaOrdenCompraDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_productoCollectionViaOrdenCompraDetalle.SortClauses=sortClauses
			_productoCollectionViaOrdenCompraDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'TipoMonedaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'TipoMonedaEntity'</returns>
		Public Function GetMultiTipoMonedaCollectionViaOrdenCompraDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.TipoMonedaCollection
			Return GetMultiTipoMonedaCollectionViaOrdenCompraDetalle(forceFetch, _tipoMonedaCollectionViaOrdenCompraDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'TipoMonedaEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiTipoMonedaCollectionViaOrdenCompraDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.TipoMonedaCollection
			If ( Not _alreadyFetchedTipoMonedaCollectionViaOrdenCompraDetalle Or forceFetch Or _alwaysFetchTipoMonedaCollectionViaOrdenCompraDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _tipoMonedaCollectionViaOrdenCompraDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_tipoMonedaCollectionViaOrdenCompraDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(OrdenCompraEntity.Relations.OrdenCompraDetalleEntityUsingIdOrdenCompra, "__OrdenCompraEntity__", "OrdenCompraDetalle_", JoinHint.None)
				relations.Add(OrdenCompraDetalleEntity.Relations.TipoMonedaEntityUsingIdMoneda, "OrdenCompraDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(OrdenCompraFieldIndex.IdOrdenCompra), ComparisonOperator.Equal, Me.IdOrdenCompra))
				_tipoMonedaCollectionViaOrdenCompraDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_tipoMonedaCollectionViaOrdenCompraDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_tipoMonedaCollectionViaOrdenCompraDetalle.GetMulti(Filter, relations)
				_tipoMonedaCollectionViaOrdenCompraDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedTipoMonedaCollectionViaOrdenCompraDetalle = True
			End If
			Return _tipoMonedaCollectionViaOrdenCompraDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'TipoMonedaCollectionViaOrdenCompraDetalle'. These settings will be taken into account
		''' when the property TipoMonedaCollectionViaOrdenCompraDetalle is requested or GetMultiTipoMonedaCollectionViaOrdenCompraDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersTipoMonedaCollectionViaOrdenCompraDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_tipoMonedaCollectionViaOrdenCompraDetalle.SortClauses=sortClauses
			_tipoMonedaCollectionViaOrdenCompraDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'McomCotizacionCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'McomCotizacionCompraEntity'</returns>
		Public Function GetMultiCotizacionCompraCollectionViaOrdenCompraDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection
			Return GetMultiCotizacionCompraCollectionViaOrdenCompraDetalle(forceFetch, _cotizacionCompraCollectionViaOrdenCompraDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'McomCotizacionCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiCotizacionCompraCollectionViaOrdenCompraDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection
			If ( Not _alreadyFetchedCotizacionCompraCollectionViaOrdenCompraDetalle Or forceFetch Or _alwaysFetchCotizacionCompraCollectionViaOrdenCompraDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _cotizacionCompraCollectionViaOrdenCompraDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_cotizacionCompraCollectionViaOrdenCompraDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(OrdenCompraEntity.Relations.OrdenCompraDetalleEntityUsingIdOrdenCompra, "__OrdenCompraEntity__", "OrdenCompraDetalle_", JoinHint.None)
				relations.Add(OrdenCompraDetalleEntity.Relations.McomCotizacionCompraEntityUsingIdCotizacion, "OrdenCompraDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(OrdenCompraFieldIndex.IdOrdenCompra), ComparisonOperator.Equal, Me.IdOrdenCompra))
				_cotizacionCompraCollectionViaOrdenCompraDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_cotizacionCompraCollectionViaOrdenCompraDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_cotizacionCompraCollectionViaOrdenCompraDetalle.GetMulti(Filter, relations)
				_cotizacionCompraCollectionViaOrdenCompraDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedCotizacionCompraCollectionViaOrdenCompraDetalle = True
			End If
			Return _cotizacionCompraCollectionViaOrdenCompraDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'CotizacionCompraCollectionViaOrdenCompraDetalle'. These settings will be taken into account
		''' when the property CotizacionCompraCollectionViaOrdenCompraDetalle is requested or GetMultiCotizacionCompraCollectionViaOrdenCompraDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersCotizacionCompraCollectionViaOrdenCompraDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_cotizacionCompraCollectionViaOrdenCompraDetalle.SortClauses=sortClauses
			_cotizacionCompraCollectionViaOrdenCompraDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'SolicitudProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'SolicitudProductoEntity'</returns>
		Public Function GetMultiSolicitudProductoCollectionViaOrdenCompraDetalle(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.SolicitudProductoCollection
			Return GetMultiSolicitudProductoCollectionViaOrdenCompraDetalle(forceFetch, _solicitudProductoCollectionViaOrdenCompraDetalle.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'SolicitudProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiSolicitudProductoCollectionViaOrdenCompraDetalle(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.SolicitudProductoCollection
			If ( Not _alreadyFetchedSolicitudProductoCollectionViaOrdenCompraDetalle Or forceFetch Or _alwaysFetchSolicitudProductoCollectionViaOrdenCompraDetalle) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _solicitudProductoCollectionViaOrdenCompraDetalle.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_solicitudProductoCollectionViaOrdenCompraDetalle)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(OrdenCompraEntity.Relations.OrdenCompraDetalleEntityUsingIdOrdenCompra, "__OrdenCompraEntity__", "OrdenCompraDetalle_", JoinHint.None)
				relations.Add(OrdenCompraDetalleEntity.Relations.SolicitudProductoEntityUsingIdSolicitud, "OrdenCompraDetalle_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(OrdenCompraFieldIndex.IdOrdenCompra), ComparisonOperator.Equal, Me.IdOrdenCompra))
				_solicitudProductoCollectionViaOrdenCompraDetalle.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_solicitudProductoCollectionViaOrdenCompraDetalle.EntityFactoryToUse = entityFactoryToUse
				End If
				_solicitudProductoCollectionViaOrdenCompraDetalle.GetMulti(Filter, relations)
				_solicitudProductoCollectionViaOrdenCompraDetalle.SuppressClearInGetMulti = False
				_alreadyFetchedSolicitudProductoCollectionViaOrdenCompraDetalle = True
			End If
			Return _solicitudProductoCollectionViaOrdenCompraDetalle
		End Function

		''' <summary>Sets the collection parameters for the collection for 'SolicitudProductoCollectionViaOrdenCompraDetalle'. These settings will be taken into account
		''' when the property SolicitudProductoCollectionViaOrdenCompraDetalle is requested or GetMultiSolicitudProductoCollectionViaOrdenCompraDetalle is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersSolicitudProductoCollectionViaOrdenCompraDetalle(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_solicitudProductoCollectionViaOrdenCompraDetalle.SortClauses=sortClauses
			_solicitudProductoCollectionViaOrdenCompraDetalle.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'AlmacenEntity'</returns>
		Public Function GetMultiAlmacenCollectionViaRecepcionOrdenCompra(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.AlmacenCollection
			Return GetMultiAlmacenCollectionViaRecepcionOrdenCompra(forceFetch, _almacenCollectionViaRecepcionOrdenCompra.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiAlmacenCollectionViaRecepcionOrdenCompra(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.AlmacenCollection
			If ( Not _alreadyFetchedAlmacenCollectionViaRecepcionOrdenCompra Or forceFetch Or _alwaysFetchAlmacenCollectionViaRecepcionOrdenCompra) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _almacenCollectionViaRecepcionOrdenCompra.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_almacenCollectionViaRecepcionOrdenCompra)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(OrdenCompraEntity.Relations.RecepcionOrdenCompraEntityUsingIdOrdenCompra, "__OrdenCompraEntity__", "RecepcionOrdenCompra_", JoinHint.None)
				relations.Add(RecepcionOrdenCompraEntity.Relations.AlmacenEntityUsingAlmacenId, "RecepcionOrdenCompra_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(OrdenCompraFieldIndex.IdOrdenCompra), ComparisonOperator.Equal, Me.IdOrdenCompra))
				_almacenCollectionViaRecepcionOrdenCompra.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_almacenCollectionViaRecepcionOrdenCompra.EntityFactoryToUse = entityFactoryToUse
				End If
				_almacenCollectionViaRecepcionOrdenCompra.GetMulti(Filter, relations)
				_almacenCollectionViaRecepcionOrdenCompra.SuppressClearInGetMulti = False
				_alreadyFetchedAlmacenCollectionViaRecepcionOrdenCompra = True
			End If
			Return _almacenCollectionViaRecepcionOrdenCompra
		End Function

		''' <summary>Sets the collection parameters for the collection for 'AlmacenCollectionViaRecepcionOrdenCompra'. These settings will be taken into account
		''' when the property AlmacenCollectionViaRecepcionOrdenCompra is requested or GetMultiAlmacenCollectionViaRecepcionOrdenCompra is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersAlmacenCollectionViaRecepcionOrdenCompra(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_almacenCollectionViaRecepcionOrdenCompra.SortClauses=sortClauses
			_almacenCollectionViaRecepcionOrdenCompra.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
		End Sub	

		''' <summary>Retrieves all related entities of type 'MotivoCancelacionEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <returns>Filled collection with all related entities of type 'MotivoCancelacionEntity'</returns>
		Public Function GetMultiMotivoCancelacionCollectionViaRecepcionOrdenCompra(forceFetch As Boolean) As Integralab.ORM.CollectionClasses.MotivoCancelacionCollection
			Return GetMultiMotivoCancelacionCollectionViaRecepcionOrdenCompra(forceFetch, _motivoCancelacionCollectionViaRecepcionOrdenCompra.EntityFactoryToUse)
		End Function

		''' <summary>Retrieves all related entities of type 'MotivoCancelacionEntity' Imports a relation of type 'm:n'.</summary>
		''' <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		''' <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		''' <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		Public Overridable Function GetMultiMotivoCancelacionCollectionViaRecepcionOrdenCompra(forceFetch As Boolean, entityFactoryToUse As IEntityFactory) As Integralab.ORM.CollectionClasses.MotivoCancelacionCollection
			If ( Not _alreadyFetchedMotivoCancelacionCollectionViaRecepcionOrdenCompra Or forceFetch Or _alwaysFetchMotivoCancelacionCollectionViaRecepcionOrdenCompra) AndAlso Not MyBase.IsSerializing AndAlso Not MyBase.IsDeserializing AndAlso Not MyBase.InDesignMode Then
				If MyBase.ParticipatesInTransaction Then
					If Not _motivoCancelacionCollectionViaRecepcionOrdenCompra.ParticipatesInTransaction Then
						MyBase.Transaction.Add(_motivoCancelacionCollectionViaRecepcionOrdenCompra)
					End If
				End If
				Dim relations As IRelationCollection = New RelationCollection()
				Dim Filter As IPredicateExpression = New PredicateExpression()
				relations.Add(OrdenCompraEntity.Relations.RecepcionOrdenCompraEntityUsingIdOrdenCompra, "__OrdenCompraEntity__", "RecepcionOrdenCompra_", JoinHint.None)
				relations.Add(RecepcionOrdenCompraEntity.Relations.MotivoCancelacionEntityUsingMotivoCancelacionId, "RecepcionOrdenCompra_", String.Empty, JoinHint.None)
				Filter.Add(New FieldCompareValuePredicate(EntityFieldFactory.Create(OrdenCompraFieldIndex.IdOrdenCompra), ComparisonOperator.Equal, Me.IdOrdenCompra))
				_motivoCancelacionCollectionViaRecepcionOrdenCompra.SuppressClearInGetMulti = Not forceFetch
				If Not entityFactoryToUse Is Nothing Then
					_motivoCancelacionCollectionViaRecepcionOrdenCompra.EntityFactoryToUse = entityFactoryToUse
				End If
				_motivoCancelacionCollectionViaRecepcionOrdenCompra.GetMulti(Filter, relations)
				_motivoCancelacionCollectionViaRecepcionOrdenCompra.SuppressClearInGetMulti = False
				_alreadyFetchedMotivoCancelacionCollectionViaRecepcionOrdenCompra = True
			End If
			Return _motivoCancelacionCollectionViaRecepcionOrdenCompra
		End Function

		''' <summary>Sets the collection parameters for the collection for 'MotivoCancelacionCollectionViaRecepcionOrdenCompra'. These settings will be taken into account
		''' when the property MotivoCancelacionCollectionViaRecepcionOrdenCompra is requested or GetMultiMotivoCancelacionCollectionViaRecepcionOrdenCompra is called.</summary>
		''' <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		''' <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		Public Overridable Sub SetCollectionParametersMotivoCancelacionCollectionViaRecepcionOrdenCompra(maxNumberOfItemsToReturn As Long, sortClauses As ISortExpression)
			_motivoCancelacionCollectionViaRecepcionOrdenCompra.SortClauses=sortClauses
			_motivoCancelacionCollectionViaRecepcionOrdenCompra.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn
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
				If MyBase.CheckIfLazyLoadingShouldOccur(OrdenCompraEntity.Relations.ProveedorEntityUsingIdProveedor) Then
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
				If MyBase.CheckIfLazyLoadingShouldOccur(OrdenCompraEntity.Relations.SucursalEntityUsingIdSucursal) Then
					fetchResult = newEntity.FetchUsingPK(Me.IdSucursal)
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
				If MyBase.CheckIfLazyLoadingShouldOccur(OrdenCompraEntity.Relations.TipoMonedaEntityUsingIdMoneda) Then
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
	
	
		
		''' <summary>Sets the field On index fieldIndex To the New value value. Marks also the fields Object As dirty. </summary>
		''' <param name="fieldIndex">Index of field To Set the New value of</param>
		''' <param name="value">Value To Set</param>
		''' <param name="checkForRefetch">If Set To True, it will check If this entity Is out of sync And will refetch it first If it Is. Use True In normal behavior, False For framework specific code.</param>
		''' <returns>True If the value Is actually Set, False otherwise.</returns>
		''' <remarks>Dereferences a related Object In an 1:1/m:1 relation If the field Is an FK field And responsible For the reference of that particular related Object.</remarks>
		''' <exception cref="ArgumentOutOfRangeException">When fieldIndex Is smaller than 0 Or bigger than the number of fields In the fields collection.</exception>
		Protected Overrides Overloads Function SetNewFieldValue(fieldIndex As Integer, value As Object, checkForRefetch As Boolean) As Boolean
			Dim toReturn As Boolean = MyBase.SetNewFieldValue (fieldIndex, value, checkForRefetch, False)			
			If toReturn AndAlso System.Enum.IsDefined(GetType(OrdenCompraFieldIndex), fieldIndex) Then
				Select Case CType(fieldIndex, OrdenCompraFieldIndex)


					Case OrdenCompraFieldIndex.IdSucursal
						DesetupSyncSucursal(True, False)
						_alreadyFetchedSucursal = False
					Case OrdenCompraFieldIndex.IdProveedor
						DesetupSyncProveedor(True, False)
						_alreadyFetchedProveedor = False






















					Case OrdenCompraFieldIndex.IdMoneda
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
			_ordenCompraDetalle.ActiveContext = MyBase.ActiveContext
			_recepcionOrdenCompra.ActiveContext = MyBase.ActiveContext
			_productoCollectionViaOrdenCompraDetalle.ActiveContext = MyBase.ActiveContext
			_tipoMonedaCollectionViaOrdenCompraDetalle.ActiveContext = MyBase.ActiveContext
			_cotizacionCompraCollectionViaOrdenCompraDetalle.ActiveContext = MyBase.ActiveContext
			_solicitudProductoCollectionViaOrdenCompraDetalle.ActiveContext = MyBase.ActiveContext
			_almacenCollectionViaRecepcionOrdenCompra.ActiveContext = MyBase.ActiveContext
			_motivoCancelacionCollectionViaRecepcionOrdenCompra.ActiveContext = MyBase.ActiveContext
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
			Dim dao As OrdenCompraDAO = CType(CreateDAOInstance(), OrdenCompraDAO)
			Return dao.AddNew(MyBase.Fields, MyBase.Transaction)
		End Function

	
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity() As Boolean
			Dim dao As OrdenCompraDAO = CType(CreateDAOInstance(), OrdenCompraDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction)
		End Function
		
		
		''' <summary>Performs the update action of an existing Entity to the persistent storage.</summary>
		''' <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		''' <returns>true if succeeded, False otherwise</returns>
		Protected Overrides Overloads Function UpdateEntity(updateRestriction As IPredicate) As Boolean
			Dim dao As OrdenCompraDAO = CType(CreateDAOInstance(), OrdenCompraDAO)
			Return dao.UpdateExisting(MyBase.Fields, MyBase.Transaction, updateRestriction)
		End Function
	
		''' <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		''' <param name="validatorToUse">The validator Object for this OrdenCompraEntity</param>
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
			Return EntityFieldsFactory.CreateEntityFieldsObject(Integralab.ORM.EntityType.OrdenCompraEntity)
		End Function
		

		''' <summary>Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		''' <param name="idOrdenCompra">PK value for OrdenCompra which data should be fetched into this OrdenCompra Object</param>
		''' <param name="validator">The validator Object for this OrdenCompraEntity</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		Protected Overridable Sub InitClassFetch(idOrdenCompra As System.Int32, validator As IValidator, prefetchPathToUse As IPrefetchPath)
			OnInitializing()
			InitClassMembers()
			
			MyBase.Fields = CreateFields()
			Dim wasSuccesful As Boolean = Fetch(idOrdenCompra, prefetchPathToUse, Nothing)
			MyBase.IsNew = Not wasSuccesful
			MyBase.Validator = validator

			
			' __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			' __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized()
		End Sub

		''' <summary>Initializes the class members</summary>
		Private Sub InitClassMembers()
			_ordenCompraDetalle = New Integralab.ORM.CollectionClasses.OrdenCompraDetalleCollection(New OrdenCompraDetalleEntityFactory())
			_ordenCompraDetalle.SetContainingEntityInfo(Me, "OrdenCompra")
			_alwaysFetchOrdenCompraDetalle = False
			_alreadyFetchedOrdenCompraDetalle = False
			_recepcionOrdenCompra = New Integralab.ORM.CollectionClasses.RecepcionOrdenCompraCollection(New RecepcionOrdenCompraEntityFactory())
			_recepcionOrdenCompra.SetContainingEntityInfo(Me, "OrdenCompra")
			_alwaysFetchRecepcionOrdenCompra = False
			_alreadyFetchedRecepcionOrdenCompra = False
			_productoCollectionViaOrdenCompraDetalle = New Integralab.ORM.CollectionClasses.ProductoCollection(New ProductoEntityFactory())
			_alwaysFetchProductoCollectionViaOrdenCompraDetalle = False
			_alreadyFetchedProductoCollectionViaOrdenCompraDetalle = False
			_tipoMonedaCollectionViaOrdenCompraDetalle = New Integralab.ORM.CollectionClasses.TipoMonedaCollection(New TipoMonedaEntityFactory())
			_alwaysFetchTipoMonedaCollectionViaOrdenCompraDetalle = False
			_alreadyFetchedTipoMonedaCollectionViaOrdenCompraDetalle = False
			_cotizacionCompraCollectionViaOrdenCompraDetalle = New Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection(New McomCotizacionCompraEntityFactory())
			_alwaysFetchCotizacionCompraCollectionViaOrdenCompraDetalle = False
			_alreadyFetchedCotizacionCompraCollectionViaOrdenCompraDetalle = False
			_solicitudProductoCollectionViaOrdenCompraDetalle = New Integralab.ORM.CollectionClasses.SolicitudProductoCollection(New SolicitudProductoEntityFactory())
			_alwaysFetchSolicitudProductoCollectionViaOrdenCompraDetalle = False
			_alreadyFetchedSolicitudProductoCollectionViaOrdenCompraDetalle = False
			_almacenCollectionViaRecepcionOrdenCompra = New Integralab.ORM.CollectionClasses.AlmacenCollection(New AlmacenEntityFactory())
			_alwaysFetchAlmacenCollectionViaRecepcionOrdenCompra = False
			_alreadyFetchedAlmacenCollectionViaRecepcionOrdenCompra = False
			_motivoCancelacionCollectionViaRecepcionOrdenCompra = New Integralab.ORM.CollectionClasses.MotivoCancelacionCollection(New MotivoCancelacionEntityFactory())
			_alwaysFetchMotivoCancelacionCollectionViaRecepcionOrdenCompra = False
			_alreadyFetchedMotivoCancelacionCollectionViaRecepcionOrdenCompra = False
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

			_fieldsCustomProperties.Add("IdOrdenCompra", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FolioOrdenCompra", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdSucursal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdProveedor", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Observaciones", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("DiasCredito", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaOrdenCompra", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCaptura", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdUsuarioAlta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdUsuarioCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ObservacionesCancelacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Importe", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Descuento", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("SubTotal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IvaPor", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IvaTotal", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IvaFlete", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("ImpteIvaFlete", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Total", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Estatus", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Autorizada", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("Recibida", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaAutorizacion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("FechaRecepcion", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("EsDirecta", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IdMoneda", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("TipoCambio", fieldHashtable)
			fieldHashtable = New Dictionary(Of String, String)()

			_fieldsCustomProperties.Add("IepsTotal", fieldHashtable)
		End Sub


		''' <summary>Removes the sync logic for member _proveedor</summary>
		''' <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		''' <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		Private Sub DesetupSyncProveedor(signalRelatedEntity As Boolean, resetFKFields As Boolean)
			MyBase.PerformDesetupSyncRelatedEntity( _proveedor, AddressOf OnProveedorPropertyChanged, "Proveedor", OrdenCompraEntity.Relations.ProveedorEntityUsingIdProveedor, True, signalRelatedEntity, "OrdenCompra", resetFKFields, New Integer() { CInt(OrdenCompraFieldIndex.IdProveedor) } )
			_proveedor = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _proveedor</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncProveedor(relatedEntity As IEntity)
			DesetupSyncProveedor(True, True)
			_proveedor = CType(relatedEntity, ProveedorEntity)
			MyBase.PerformSetupSyncRelatedEntity( _proveedor, AddressOf OnProveedorPropertyChanged, "Proveedor", OrdenCompraEntity.Relations.ProveedorEntityUsingIdProveedor, True, _alreadyFetchedProveedor, New String() {  } )
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
			MyBase.PerformDesetupSyncRelatedEntity( _sucursal, AddressOf OnSucursalPropertyChanged, "Sucursal", OrdenCompraEntity.Relations.SucursalEntityUsingIdSucursal, True, signalRelatedEntity, "OrdenCompra", resetFKFields, New Integer() { CInt(OrdenCompraFieldIndex.IdSucursal) } )
			_sucursal = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _sucursal</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncSucursal(relatedEntity As IEntity)
			DesetupSyncSucursal(True, True)
			_sucursal = CType(relatedEntity, SucursalEntity)
			MyBase.PerformSetupSyncRelatedEntity( _sucursal, AddressOf OnSucursalPropertyChanged, "Sucursal", OrdenCompraEntity.Relations.SucursalEntityUsingIdSucursal, True, _alreadyFetchedSucursal, New String() {  } )
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
			MyBase.PerformDesetupSyncRelatedEntity( _tipoMoneda, AddressOf OnTipoMonedaPropertyChanged, "TipoMoneda", OrdenCompraEntity.Relations.TipoMonedaEntityUsingIdMoneda, True, signalRelatedEntity, "OrdenCompra", resetFKFields, New Integer() { CInt(OrdenCompraFieldIndex.IdMoneda) } )
			_tipoMoneda = Nothing
		End Sub
		
		''' <summary>setups the sync logic for member _tipoMoneda</summary>
		''' <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		Private Sub SetupSyncTipoMoneda(relatedEntity As IEntity)
			DesetupSyncTipoMoneda(True, True)
			_tipoMoneda = CType(relatedEntity, TipoMonedaEntity)
			MyBase.PerformSetupSyncRelatedEntity( _tipoMoneda, AddressOf OnTipoMonedaPropertyChanged, "TipoMoneda", OrdenCompraEntity.Relations.TipoMonedaEntityUsingIdMoneda, True, _alreadyFetchedTipoMoneda, New String() {  } )
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
		''' <param name="idOrdenCompra">PK value for OrdenCompra which data should be fetched into this OrdenCompra Object</param>
		''' <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		''' <param name="contextToUse">The context to fetch the prefetch path with.</param>
		''' <returns>True if succeeded, False otherwise.</returns>
		Private Function Fetch(idOrdenCompra As System.Int32, prefetchPathToUse As IPrefetchPath, contextToUse As Context) As Boolean
			Try
				OnFetch()
				Dim dao As IDao = Me.CreateDAOInstance()
				MyBase.Fields(CInt(OrdenCompraFieldIndex.IdOrdenCompra)).ForcedCurrentValueWrite(idOrdenCompra)
				dao.FetchExisting(Me, MyBase.Transaction, prefetchPathToUse, contextToUse)
				Return (MyBase.Fields.State = EntityState.Fetched)
			Finally
				OnFetchComplete()
			End Try
		End Function

		''' <summary>Creates the DAO instance For this type</summary>
		''' <returns></returns>
		Protected Overrides Function CreateDAOInstance() As IDao
			Return DAOFactory.CreateOrdenCompraDAO()
		End Function
		
		''' <summary>Creates the entity factory For this type.</summary>
		''' <returns></returns>
		Protected Overrides Function CreateEntityFactory() As IEntityFactory 
			Return New OrdenCompraEntityFactory()
		End Function

#Region "Class Property Declarations"
		''' <summary>The relations Object holding all relations of this entity with other entity classes.</summary>
		Public  Shared ReadOnly Property Relations() As OrdenCompraRelations
			Get	
				Return New OrdenCompraRelations() 
			End Get
		End Property
		
		''' <summary>The custom properties for this entity type.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		Public  Shared ReadOnly Property CustomProperties() As Dictionary(Of String, String)
			Get
				Return _customProperties
			End Get
		End Property
		
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'OrdenCompraDetalle' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathOrdenCompraDetalle() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.OrdenCompraDetalleCollection(), _
					OrdenCompraEntity.Relations.OrdenCompraDetalleEntityUsingIdOrdenCompra, _
					CType(Integralab.ORM.EntityType.OrdenCompraEntity, Integer), CType(Integralab.ORM.EntityType.OrdenCompraDetalleEntity, Integer), 0, Nothing, Nothing, Nothing, "OrdenCompraDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'RecepcionOrdenCompra' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath2 instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathRecepcionOrdenCompra() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.RecepcionOrdenCompraCollection(), _
					OrdenCompraEntity.Relations.RecepcionOrdenCompraEntityUsingIdOrdenCompra, _
					CType(Integralab.ORM.EntityType.OrdenCompraEntity, Integer), CType(Integralab.ORM.EntityType.RecepcionOrdenCompraEntity, Integer), 0, Nothing, Nothing, Nothing, "RecepcionOrdenCompra", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Producto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProductoCollectionViaOrdenCompraDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(OrdenCompraEntity.Relations.OrdenCompraDetalleEntityUsingIdOrdenCompra, "__OrdenCompraEntity__", String.Empty, JoinHint.None)
				relations.Add(OrdenCompraDetalleEntity.Relations.ProductoEntityUsingIdProducto)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProductoCollection(), _
					OrdenCompraEntity.Relations.OrdenCompraDetalleEntityUsingIdOrdenCompra, _
					CType(Integralab.ORM.EntityType.OrdenCompraEntity, Integer), CType(Integralab.ORM.EntityType.ProductoEntity, Integer), 0, Nothing, Nothing, relations, "ProductoCollectionViaOrdenCompraDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoMoneda' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoMonedaCollectionViaOrdenCompraDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(OrdenCompraEntity.Relations.OrdenCompraDetalleEntityUsingIdOrdenCompra, "__OrdenCompraEntity__", String.Empty, JoinHint.None)
				relations.Add(OrdenCompraDetalleEntity.Relations.TipoMonedaEntityUsingIdMoneda)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoMonedaCollection(), _
					OrdenCompraEntity.Relations.OrdenCompraDetalleEntityUsingIdOrdenCompra, _
					CType(Integralab.ORM.EntityType.OrdenCompraEntity, Integer), CType(Integralab.ORM.EntityType.TipoMonedaEntity, Integer), 0, Nothing, Nothing, relations, "TipoMonedaCollectionViaOrdenCompraDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'McomCotizacionCompra' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathCotizacionCompraCollectionViaOrdenCompraDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(OrdenCompraEntity.Relations.OrdenCompraDetalleEntityUsingIdOrdenCompra, "__OrdenCompraEntity__", String.Empty, JoinHint.None)
				relations.Add(OrdenCompraDetalleEntity.Relations.McomCotizacionCompraEntityUsingIdCotizacion)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection(), _
					OrdenCompraEntity.Relations.OrdenCompraDetalleEntityUsingIdOrdenCompra, _
					CType(Integralab.ORM.EntityType.OrdenCompraEntity, Integer), CType(Integralab.ORM.EntityType.McomCotizacionCompraEntity, Integer), 0, Nothing, Nothing, relations, "CotizacionCompraCollectionViaOrdenCompraDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'SolicitudProducto' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSolicitudProductoCollectionViaOrdenCompraDetalle() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(OrdenCompraEntity.Relations.OrdenCompraDetalleEntityUsingIdOrdenCompra, "__OrdenCompraEntity__", String.Empty, JoinHint.None)
				relations.Add(OrdenCompraDetalleEntity.Relations.SolicitudProductoEntityUsingIdSolicitud)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SolicitudProductoCollection(), _
					OrdenCompraEntity.Relations.OrdenCompraDetalleEntityUsingIdOrdenCompra, _
					CType(Integralab.ORM.EntityType.OrdenCompraEntity, Integer), CType(Integralab.ORM.EntityType.SolicitudProductoEntity, Integer), 0, Nothing, Nothing, relations, "SolicitudProductoCollectionViaOrdenCompraDetalle", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Almacen' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathAlmacenCollectionViaRecepcionOrdenCompra() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(OrdenCompraEntity.Relations.RecepcionOrdenCompraEntityUsingIdOrdenCompra, "__OrdenCompraEntity__", String.Empty, JoinHint.None)
				relations.Add(RecepcionOrdenCompraEntity.Relations.AlmacenEntityUsingAlmacenId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.AlmacenCollection(), _
					OrdenCompraEntity.Relations.RecepcionOrdenCompraEntityUsingIdOrdenCompra, _
					CType(Integralab.ORM.EntityType.OrdenCompraEntity, Integer), CType(Integralab.ORM.EntityType.AlmacenEntity, Integer), 0, Nothing, Nothing, relations, "AlmacenCollectionViaRecepcionOrdenCompra", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'MotivoCancelacion' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathMotivoCancelacionCollectionViaRecepcionOrdenCompra() As IPrefetchPathElement
			Get
				Dim relations As IRelationCollection = New RelationCollection()
				relations.Add(OrdenCompraEntity.Relations.RecepcionOrdenCompraEntityUsingIdOrdenCompra, "__OrdenCompraEntity__", String.Empty, JoinHint.None)
				relations.Add(RecepcionOrdenCompraEntity.Relations.MotivoCancelacionEntityUsingMotivoCancelacionId)
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.MotivoCancelacionCollection(), _
					OrdenCompraEntity.Relations.RecepcionOrdenCompraEntityUsingIdOrdenCompra, _
					CType(Integralab.ORM.EntityType.OrdenCompraEntity, Integer), CType(Integralab.ORM.EntityType.MotivoCancelacionEntity, Integer), 0, Nothing, Nothing, relations, "MotivoCancelacionCollectionViaRecepcionOrdenCompra", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToMany)
			End Get
		End Property
	
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Proveedor' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathProveedor() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.ProveedorCollection(), _
					OrdenCompraEntity.Relations.ProveedorEntityUsingIdProveedor, _
					CType(Integralab.ORM.EntityType.OrdenCompraEntity, Integer), CType(Integralab.ORM.EntityType.ProveedorEntity, Integer), 0, Nothing, Nothing, Nothing, "Proveedor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'Sucursal' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathSucursal() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.SucursalCollection(), _
					OrdenCompraEntity.Relations.SucursalEntityUsingIdSucursal, _
					CType(Integralab.ORM.EntityType.OrdenCompraEntity, Integer), CType(Integralab.ORM.EntityType.SucursalEntity, Integer), 0, Nothing, Nothing, Nothing, "Sucursal", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
		''' <summary>Creates a New PrefetchPathElement object which contains all the information to prefetch the related entities of type 'TipoMoneda' 
		''' for this entity. Add the object Returned by this property to an existing PrefetchPath instance.</summary>
		''' <Returns>Ready to use IPrefetchPathElement implementation.</Returns>
		Public Shared ReadOnly Property PrefetchPathTipoMoneda() As IPrefetchPathElement
			Get
				Return New PrefetchPathElement( New Integralab.ORM.CollectionClasses.TipoMonedaCollection(), _
					OrdenCompraEntity.Relations.TipoMonedaEntityUsingIdMoneda, _
					CType(Integralab.ORM.EntityType.OrdenCompraEntity, Integer), CType(Integralab.ORM.EntityType.TipoMonedaEntity, Integer), 0, Nothing, Nothing, Nothing, "TipoMoneda", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne)
			End Get
		End Property
	
	

		''' <summary>Returns the full name For this entity, which Is important For the DAO To find back persistence info For this entity.</summary>
		<Browsable(False), XmlIgnore> _
		Public Overrides ReadOnly Property LLBLGenProEntityName As String
			Get
				Return "OrdenCompraEntity"
			End Get
		End Property

		''' <summary>The custom properties for the type of this entity instance.</summary>
		''' <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		<Browsable(False), XmlIgnore> _
		Public Overridable ReadOnly Property CustomPropertiesOfType() As Dictionary(Of String, String)
			Get
				Return OrdenCompraEntity.CustomProperties
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
				Return OrdenCompraEntity.FieldsCustomProperties
			End Get
		End Property

	
		''' <summary>The IdOrdenCompra property of the Entity OrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompra"."IdOrdenCompra"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, True, True
		''' </remarks>
		Public Overridable Property [IdOrdenCompra]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraFieldIndex.IdOrdenCompra, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraFieldIndex.IdOrdenCompra, Integer), value)
			End Set
		End Property
	
		''' <summary>The FolioOrdenCompra property of the Entity OrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompra"."FolioOrdenCompra"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 12<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FolioOrdenCompra]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraFieldIndex.FolioOrdenCompra, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraFieldIndex.FolioOrdenCompra, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdSucursal property of the Entity OrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompra"."IdSucursal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdSucursal]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraFieldIndex.IdSucursal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraFieldIndex.IdSucursal, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdProveedor property of the Entity OrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompra"."IdProveedor"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdProveedor]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraFieldIndex.IdProveedor, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraFieldIndex.IdProveedor, Integer), value)
			End Set
		End Property
	
		''' <summary>The Observaciones property of the Entity OrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompra"."Observaciones"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Observaciones]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraFieldIndex.Observaciones, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraFieldIndex.Observaciones, Integer), value)
			End Set
		End Property
	
		''' <summary>The DiasCredito property of the Entity OrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompra"."DiasCredito"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [DiasCredito]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraFieldIndex.DiasCredito, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraFieldIndex.DiasCredito, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaOrdenCompra property of the Entity OrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompra"."FechaOrdenCompra"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaOrdenCompra]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraFieldIndex.FechaOrdenCompra, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraFieldIndex.FechaOrdenCompra, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCaptura property of the Entity OrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompra"."FechaCaptura"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [FechaCaptura]() As System.DateTime
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraFieldIndex.FechaCaptura, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.DateTime))
				End If
				Return CType(valueToReturn, System.DateTime)
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraFieldIndex.FechaCaptura, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdUsuarioAlta property of the Entity OrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompra"."IdUsuarioAlta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdUsuarioAlta]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraFieldIndex.IdUsuarioAlta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraFieldIndex.IdUsuarioAlta, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaCancelacion property of the Entity OrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompra"."FechaCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaCancelacion]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraFieldIndex.FechaCancelacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraFieldIndex.FechaCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdUsuarioCancelacion property of the Entity OrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompra"."IdUsuarioCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IdUsuarioCancelacion]() As Nullable(Of System.Int32)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraFieldIndex.IdUsuarioCancelacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.Int32))
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraFieldIndex.IdUsuarioCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The ObservacionesCancelacion property of the Entity OrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompra"."ObservacionesCancelacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 200<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ObservacionesCancelacion]() As System.String
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraFieldIndex.ObservacionesCancelacion, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.String))
				End If
				Return CType(valueToReturn, System.String)
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraFieldIndex.ObservacionesCancelacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The Importe property of the Entity OrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompra"."Importe"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Importe]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraFieldIndex.Importe, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraFieldIndex.Importe, Integer), value)
			End Set
		End Property
	
		''' <summary>The Descuento property of the Entity OrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompra"."Descuento"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Descuento]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraFieldIndex.Descuento, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraFieldIndex.Descuento, Integer), value)
			End Set
		End Property
	
		''' <summary>The SubTotal property of the Entity OrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompra"."SubTotal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [SubTotal]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraFieldIndex.SubTotal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraFieldIndex.SubTotal, Integer), value)
			End Set
		End Property
	
		''' <summary>The IvaPor property of the Entity OrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompra"."IvaPor"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IvaPor]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraFieldIndex.IvaPor, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraFieldIndex.IvaPor, Integer), value)
			End Set
		End Property
	
		''' <summary>The IvaTotal property of the Entity OrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompra"."IvaTotal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IvaTotal]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraFieldIndex.IvaTotal, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraFieldIndex.IvaTotal, Integer), value)
			End Set
		End Property
	
		''' <summary>The IvaFlete property of the Entity OrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompra"."IvaFlete"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IvaFlete]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraFieldIndex.IvaFlete, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraFieldIndex.IvaFlete, Integer), value)
			End Set
		End Property
	
		''' <summary>The ImpteIvaFlete property of the Entity OrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompra"."ImpteIvaFlete"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [ImpteIvaFlete]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraFieldIndex.ImpteIvaFlete, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraFieldIndex.ImpteIvaFlete, Integer), value)
			End Set
		End Property
	
		''' <summary>The Total property of the Entity OrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompra"."Total"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Total]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraFieldIndex.Total, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraFieldIndex.Total, Integer), value)
			End Set
		End Property
	
		''' <summary>The Estatus property of the Entity OrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompra"."Estatus"<br/>
		''' Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Estatus]() As System.Byte
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraFieldIndex.Estatus, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Byte))
				End If
				Return CType(valueToReturn, System.Byte)
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraFieldIndex.Estatus, Integer), value)
			End Set
		End Property
	
		''' <summary>The Autorizada property of the Entity OrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompra"."Autorizada"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Autorizada]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraFieldIndex.Autorizada, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraFieldIndex.Autorizada, Integer), value)
			End Set
		End Property
	
		''' <summary>The Recibida property of the Entity OrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompra"."Recibida"<br/>
		''' Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [Recibida]() As System.Byte
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraFieldIndex.Recibida, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Byte))
				End If
				Return CType(valueToReturn, System.Byte)
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraFieldIndex.Recibida, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaAutorizacion property of the Entity OrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompra"."FechaAutorizacion"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaAutorizacion]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraFieldIndex.FechaAutorizacion, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraFieldIndex.FechaAutorizacion, Integer), value)
			End Set
		End Property
	
		''' <summary>The FechaRecepcion property of the Entity OrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompra"."FechaRecepcion"<br/>
		''' Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [FechaRecepcion]() As Nullable(Of System.DateTime)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraFieldIndex.FechaRecepcion, Integer))

				Return CType(valueToReturn, Nullable(Of System.DateTime))
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraFieldIndex.FechaRecepcion, Integer), value)
			End Set
		End Property
	
		''' <summary>The EsDirecta property of the Entity OrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompra"."EsDirecta"<br/>
		''' Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [EsDirecta]() As System.Boolean
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraFieldIndex.EsDirecta, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Boolean))
				End If
				Return CType(valueToReturn, System.Boolean)
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraFieldIndex.EsDirecta, Integer), value)
			End Set
		End Property
	
		''' <summary>The IdMoneda property of the Entity OrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompra"."IdMoneda"<br/>
		''' Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [IdMoneda]() As System.Int32
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraFieldIndex.IdMoneda, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Int32))
				End If
				Return CType(valueToReturn, System.Int32)
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraFieldIndex.IdMoneda, Integer), value)
			End Set
		End Property
	
		''' <summary>The TipoCambio property of the Entity OrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompra"."TipoCambio"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): False, False, False
		''' </remarks>
		Public Overridable Property [TipoCambio]() As System.Decimal
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraFieldIndex.TipoCambio, Integer))
				If valueToReturn Is Nothing Then
					valueToReturn = TypeDefaultValue.GetDefaultValue(GetType(System.Decimal))
				End If
				Return CType(valueToReturn, System.Decimal)
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraFieldIndex.TipoCambio, Integer), value)
			End Set
		End Property
	
		''' <summary>The IepsTotal property of the Entity OrdenCompra<br/><br/>
		''' </summary>
		''' <remarks>
		''' Mapped on table field: "MComOrdenCompra"."IepsTotal"<br/>
		''' Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		''' Table field behavior characteristics (is nullable, is PK, is identity): True, False, False
		''' </remarks>
		Public Overridable Property [IepsTotal]() As Nullable(Of System.Decimal)
			Get
				Dim valueToReturn As Object = MyBase.GetCurrentFieldValue(CType(OrdenCompraFieldIndex.IepsTotal, Integer))

				Return CType(valueToReturn, Nullable(Of System.Decimal))
			End Get
			Set
				SetNewFieldValue(CType(OrdenCompraFieldIndex.IepsTotal, Integer), value)
			End Set
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'OrdenCompraDetalleEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiOrdenCompraDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [OrdenCompraDetalle]() As Integralab.ORM.CollectionClasses.OrdenCompraDetalleCollection
			Get
				Return GetMultiOrdenCompraDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for OrdenCompraDetalle. When set to true, OrdenCompraDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time OrdenCompraDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiOrdenCompraDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchOrdenCompraDetalle As Boolean
			Get
				Return _alwaysFetchOrdenCompraDetalle
			End Get
			Set
				_alwaysFetchOrdenCompraDetalle = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'RecepcionOrdenCompraEntity' Imports a relation of type '1:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiRecepcionOrdenCompra()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [RecepcionOrdenCompra]() As Integralab.ORM.CollectionClasses.RecepcionOrdenCompraCollection
			Get
				Return GetMultiRecepcionOrdenCompra(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for RecepcionOrdenCompra. When set to true, RecepcionOrdenCompra is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time RecepcionOrdenCompra is accessed. You can always execute
		''' a forced fetch by calling GetMultiRecepcionOrdenCompra(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchRecepcionOrdenCompra As Boolean
			Get
				Return _alwaysFetchRecepcionOrdenCompra
			End Get
			Set
				_alwaysFetchRecepcionOrdenCompra = value
			End Set	
		End Property
	
	
		''' <summary>Retrieves all related entities of type 'ProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductoCollectionViaOrdenCompraDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [ProductoCollectionViaOrdenCompraDetalle]() As Integralab.ORM.CollectionClasses.ProductoCollection
			Get
				Return GetMultiProductoCollectionViaOrdenCompraDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for ProductoCollectionViaOrdenCompraDetalle. When set to true, ProductoCollectionViaOrdenCompraDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time ProductoCollectionViaOrdenCompraDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiProductoCollectionViaOrdenCompraDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchProductoCollectionViaOrdenCompraDetalle As Boolean
			Get
				Return _alwaysFetchProductoCollectionViaOrdenCompraDetalle
			End Get
			Set
				_alwaysFetchProductoCollectionViaOrdenCompraDetalle = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'TipoMonedaEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiTipoMonedaCollectionViaOrdenCompraDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [TipoMonedaCollectionViaOrdenCompraDetalle]() As Integralab.ORM.CollectionClasses.TipoMonedaCollection
			Get
				Return GetMultiTipoMonedaCollectionViaOrdenCompraDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for TipoMonedaCollectionViaOrdenCompraDetalle. When set to true, TipoMonedaCollectionViaOrdenCompraDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time TipoMonedaCollectionViaOrdenCompraDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiTipoMonedaCollectionViaOrdenCompraDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchTipoMonedaCollectionViaOrdenCompraDetalle As Boolean
			Get
				Return _alwaysFetchTipoMonedaCollectionViaOrdenCompraDetalle
			End Get
			Set
				_alwaysFetchTipoMonedaCollectionViaOrdenCompraDetalle = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'McomCotizacionCompraEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCotizacionCompraCollectionViaOrdenCompraDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [CotizacionCompraCollectionViaOrdenCompraDetalle]() As Integralab.ORM.CollectionClasses.McomCotizacionCompraCollection
			Get
				Return GetMultiCotizacionCompraCollectionViaOrdenCompraDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for CotizacionCompraCollectionViaOrdenCompraDetalle. When set to true, CotizacionCompraCollectionViaOrdenCompraDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time CotizacionCompraCollectionViaOrdenCompraDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiCotizacionCompraCollectionViaOrdenCompraDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchCotizacionCompraCollectionViaOrdenCompraDetalle As Boolean
			Get
				Return _alwaysFetchCotizacionCompraCollectionViaOrdenCompraDetalle
			End Get
			Set
				_alwaysFetchCotizacionCompraCollectionViaOrdenCompraDetalle = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'SolicitudProductoEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSolicitudProductoCollectionViaOrdenCompraDetalle()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [SolicitudProductoCollectionViaOrdenCompraDetalle]() As Integralab.ORM.CollectionClasses.SolicitudProductoCollection
			Get
				Return GetMultiSolicitudProductoCollectionViaOrdenCompraDetalle(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for SolicitudProductoCollectionViaOrdenCompraDetalle. When set to true, SolicitudProductoCollectionViaOrdenCompraDetalle is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time SolicitudProductoCollectionViaOrdenCompraDetalle is accessed. You can always execute
		''' a forced fetch by calling GetMultiSolicitudProductoCollectionViaOrdenCompraDetalle(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchSolicitudProductoCollectionViaOrdenCompraDetalle As Boolean
			Get
				Return _alwaysFetchSolicitudProductoCollectionViaOrdenCompraDetalle
			End Get
			Set
				_alwaysFetchSolicitudProductoCollectionViaOrdenCompraDetalle = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'AlmacenEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAlmacenCollectionViaRecepcionOrdenCompra()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [AlmacenCollectionViaRecepcionOrdenCompra]() As Integralab.ORM.CollectionClasses.AlmacenCollection
			Get
				Return GetMultiAlmacenCollectionViaRecepcionOrdenCompra(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for AlmacenCollectionViaRecepcionOrdenCompra. When set to true, AlmacenCollectionViaRecepcionOrdenCompra is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time AlmacenCollectionViaRecepcionOrdenCompra is accessed. You can always execute
		''' a forced fetch by calling GetMultiAlmacenCollectionViaRecepcionOrdenCompra(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchAlmacenCollectionViaRecepcionOrdenCompra As Boolean
			Get
				Return _alwaysFetchAlmacenCollectionViaRecepcionOrdenCompra
			End Get
			Set
				_alwaysFetchAlmacenCollectionViaRecepcionOrdenCompra = value
			End Set	
		End Property
	
		''' <summary>Retrieves all related entities of type 'MotivoCancelacionEntity' Imports a relation of type 'm:n'.</summary>
		''' <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiMotivoCancelacionCollectionViaRecepcionOrdenCompra()', because 
		''' this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		''' same scope.</remarks>
		Public Overridable ReadOnly Property [MotivoCancelacionCollectionViaRecepcionOrdenCompra]() As Integralab.ORM.CollectionClasses.MotivoCancelacionCollection
			Get
				Return GetMultiMotivoCancelacionCollectionViaRecepcionOrdenCompra(False)
			End Get
		End Property

		''' <summary>Gets / sets the lazy loading flag for MotivoCancelacionCollectionViaRecepcionOrdenCompra. When set to true, MotivoCancelacionCollectionViaRecepcionOrdenCompra is always refetched from the 
		''' persistent storage. When set to false, the data is only fetched the first time MotivoCancelacionCollectionViaRecepcionOrdenCompra is accessed. You can always execute
		''' a forced fetch by calling GetMultiMotivoCancelacionCollectionViaRecepcionOrdenCompra(True).</summary>
		<Browsable(False)> _
		Public Property AlwaysFetchMotivoCancelacionCollectionViaRecepcionOrdenCompra As Boolean
			Get
				Return _alwaysFetchMotivoCancelacionCollectionViaRecepcionOrdenCompra
			End Get
			Set
				_alwaysFetchMotivoCancelacionCollectionViaRecepcionOrdenCompra = value
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
							_proveedor.UnsetRelatedEntity(Me, "OrdenCompra")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "OrdenCompra")
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
							_sucursal.UnsetRelatedEntity(Me, "OrdenCompra")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "OrdenCompra")
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
							_tipoMoneda.UnsetRelatedEntity(Me, "OrdenCompra")
						End If
					Else
						CType(value, IEntity).SetRelatedEntity(Me, "OrdenCompra")
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
				Return CInt(Integralab.ORM.EntityType.OrdenCompraEntity)
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
